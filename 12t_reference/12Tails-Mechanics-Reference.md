# 12 Tails — Game Mechanics & Formula Reference

> **Reborn (2026-10-25):** this file covers the original BB client and the ToT / TTO server differences. The Reborn client is a separate build with its own code; see [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md). Do not assume a rule here holds in Reborn.

> Reverse-engineered from the decompiled client (`Assembly-UnityScript`). Every formula below was read
> directly from source and stripped of the obfuscator's dead-code noise (junk predicates like
> `if (163919 - 190023 != -26104) { ... }` wrapped around the real statements). Citations are `file:line`.
>
> **Stat order is fixed everywhere as an 8-slot array:** `ATK, DEF, AGI, VIT, MAG, CHA, TAL, LCK` (index 0–7).
> Stored on a character as a `%`-delimited string, e.g. `stat = "12%9%8%10%5%4%6%7"`.

---

## 1. Stats

### 1.1 The 8 base stats
Parsed by `CharacterDataClass.getStat(n)` → `Stringf.splitToIntList(this.stat)[n]` (CharacterDataClass.cs:1216).
Index → role confirmed by the in-combat stat assembly (CharacterControl.cs:1431–1452):

| Idx | Stat | Primary role |
|----|------|--------------|
| 0 | **ATK** Attack   | physical skill base damage (read raw, see §3.2 — `atkAdjust` exists but is dead code) |
| 1 | **DEF** Defense  | damage mitigation (`defAdjust`); max KO |
| 2 | **AGI** Agility  | reduces action/recovery time (`agiAdjust`) |
| 3 | **VIT** Vitality | max HP |
| 4 | **MAG** Magic    | max MP; reduces cast time (`magAdjust`) |
| 5 | **CHA** Charisma | extends buff/debuff duration (`chaAdjust`) |
| 6 | **TAL** Talent   | skill power %; max SP (`talAdjust`) |
| 7 | **LCK** Luck     | adds a random spread to every roll; boosts % chances (`lckAdjust`) |

**Effective stat in combat** = `getStat(i)` (base+bonus+level+gear, see 1.3) **+ live modifier** from buffs/statuses
(`this.atk = current.getStat(0) + <atkMod>`, etc., CharacterControl.cs:1431–1452).

### 1.2 Derived values (CharacterControl.cs:1464–1479)
```
maxHP = VIT * 10 + bonusHP        // bonusHP from gear/skill flat HP
maxMP = MAG * 3  + bonusMP        // bonusMP from gear/skill flat MP
maxKO = floor(DEF / 3) + 10
maxSP = floor(TAL / 5) + 10
```
Exact source lines:
- `maxHP = VIT*10 + bonusHP` (`this.mhp = this.vit * 10 + ...`, :1467)
- `maxMP = MAG*3  + bonusMP` (`this.mmp = this.mag * 3 + ...`, :1473)
- `maxKO = floor(DEF/3) + 10` (`this.mko = Math.div(def,3) + 10`, :1476)
- `maxSP = floor(TAL/5) + 10` (`this.msp = Math.div(tal,5) + 10`, :1479)

When max HP/MP changes, current HP/MP is **rescaled proportionally** so the % stays the same (:1464, :1470).

> **KO / SP**: "KO" is a knock-out/stagger pool (max ≈ `DEF/3+10`); "SP" is a stamina/skill pool used by
> physical and hybrid abilities (`cSP` cost on skills, see §3.1). Both regenerate passively over time (see CharacterControl.cs ~:1949/:2029).
>
> **Universal In-Combat SP Generation Rules:**
> 1. **Attacker Basic Attack Hit:** Every landed basic attack hit (`nAttack` / Combo) grants **+1 SP** to the attacker (`self.<class>.sp = self.<class>.sp + 1`, duplicated across `Monkey.cs:20055`, `Wolf.cs:15292`, `Bat_nAttack.cs:294`, `Penguin.cs:29541`, etc.).
> 2. **Victim Damage Taken:** Whenever a character takes direct damage (`myDamage > 0`), the engine immediately grants **+1 SP** to the victim (`this.sp++`, CharacterControl.cs:2122 inside `ApplyDamage()`).
>
> **SP above max SP decays (verified 2026-09-24, CharacterControl.cs:1945-2005).** SP can exceed `maxSP` (e.g. Panda Ashura's gain clamps to 100, not `maxSP`). While `sp > msp`, the engine removes **1 SP** each time all of these hold: at least `1 + 0.01·(msp − sp)` seconds since the last decay tick (so the interval *shrinks* the further SP is over the cap), at least **2 s** since the last action (`actionTime + 2`), and `actionState` is `standby` or `run`. Exceptions: a `ShadowCopy` never decays, and a **Panda with the `ashura` status** skips the decay (`getStatusLv("ashura") != 0`). The `sp < msp` branch right after it is the passive regen and was not traced.
>
> **Status tick cadence:** `StatusUpdate()` (CharacterControl.cs:8659) runs its per-status body at most once per **0.5 s** (`if (kNtcObrGvdk > Time.time - 0.5f)` skip, else `kNtcObrGvdk = Time.time`). A status with no extra gate in its branch (e.g. `ashura`, `:8841`) acts every 0.5 s; others add their own modulo gate on top (`holyWolf`: `mod(2·(sTime − now), 16) == 0` = every 8 s, `:8787`; `afterShock`: `mod(2·now, 6) == 3`, `:8820`). `global::Math.mod(a, b)` floors both arguments first (`Math.cs:39-47`: `a = Floor(a)`, `b = Floor(b)`, then `a − b·FloorToInt(a / b)`), so `mod(2·now, 8) == 0` is true for the whole half-second window `now ∈ [4k, 4k + 0.5)` (verified 2026-10-19). Such a gate therefore fires once per window on the **owner's own `Time.time` grid**, not a fixed time after the status was applied: the first tick comes 0-4 s after the status lands (2 s on average). Because the update runs every 0.5 s **plus up to one frame**, its phase drifts by about a frame per update and now and then a whole window holds no update, so roughly 1-2 % of ticks are skipped (more at low frame rates).

### 1.3 Where total stats come from
`total[i] = bStat[i] + bonus[i] + typeLevelStat[i] + skillBonus + Σ equipment.att[i]`
- `bStat` — the character's own allocated base stats (string).
- `bonus` — misc bonus string.
- `typeLevelStat` — per-class growth from level (see 1.4).
- `skillBonus` — small flat bonuses from owning certain passive skills.
- `equipment.att[i]` — gear stat bonuses (see §5).

#### Status window display: ATK row includes `damageMod` (client display bug, verified 2026-10-05)
The status window (`GameGui.cs:12327-12366`) draws 8 rows, each as a big number plus a coloured `+X` / `- X` column:
- **Big number:** `getBaseStat(9+i)` for DEF…LCK (`:12348`), but for **ATK only** `Mathf.FloorToInt(damageMod * getBaseStat(9))` (`:12340`).
- **± column:** `getAddStat(9+i) = getStat(9+i) - getBaseStat(9+i)` (`CharacterControl.cs:23385`), i.e. real stat (`atk`, `def`, …) minus base. Never multiplied.
- **Base (`getBaseStat`, `CharacterControl.cs:22680`, own player, not transformed):** `getBStat + getBonus + typeLevelStat`, plus Stat Plus #141-144 (+2 per rank, all stats), Whale VIT +15/rank (#131-134), Cat AGI +5/rank (#131-134), Penguin MAG +10/rank (#121-124) and TAL +10/rank (#261-264). Gear, buffs and `deltaAtk` effects (e.g. Bison Over Power) land in the ± column.

So a `damageMod` change moves the displayed ATK although the real `atk` used by formulas is unchanged; `damageMod` multiplies final damage in `dmgAdjust` (§2.2) for every `hit()` regardless of the stat the formula used, and is skipped by direct `RPC_AddDamage` callers (§2.9). Statuses that change `damageMod` (apply / remove sites in `CharacterControl.cs`):

| Status | Δ damageMod | Apply | Remove | Player source |
|---|---|---|---|---|
| valor | +(0.02 + 0.02×sLv) | :33988 | :15072 | Wolf Brave Spirit (`Wolf.cs:20489`) |
| enrage | +(0.04 + 0.04×sLv) | :34732 | :15431 | Bison Enrage (`Bison.cs:20973`) |
| drunken | −0.1 | :35393 | :15790 | Panda Drunken Fist + Drunken Plus (`Panda.cs:32591`) |
| reduce | +0.05×sLv | :37258 | :16695 | Rabbit Miracle Blend (`Rabbit_potion.cs:390`) |
| enlarge | −0.05×sLv | :37338 | :16769 | Rabbit Miracle Blend (`Rabbit_potion.cs:402`) |
| miracleDrop | +(0.1 + 0.1×sLv) | :37671 | :16959 | Rabbit Miracle Blend + Miracle Drop (`Rabbit_potion.cs:438`) |
| sealOfAttack | +0.1 | :39688 | :17905 | Sheep Seal (`Sheep_seal.cs:268`) |
| sealOfEarth | +0.05 | :39710 | :17927 | Sheep Seal (`Sheep_seal.cs:292`) |
| sealOfHeaven | +0.15 | :39725 | :17942 | Sheep Seal (`Sheep_seal.cs:304`) |

The Bible flags this with a `bbBug` on Enrage, Brave Spirit, Drunken Fist, Miracle Blend and Seal, and a Common entry in `BB_ISSUES_EXTRA`. The transformed (`isTransform`) path of the window was not traced.

### 1.4 Class growth & level scaling (CharacterData.cs)
**Per-class base stats** `getTypeStat(type)` (CharacterData.cs:218–493), in `ATK,DEF,AGI,VIT,MAG,CHA,TAL,LCK` order:

| Class | ATK | DEF | AGI | VIT | MAG | CHA | TAL | LCK |
|-----------|----|----|----|----|----|----|----|----|
| Wolf      | 7 | 8 | 7 | 7 | 6 | 5 | 5 | 3 |
| Bison     | 9 | 8 | 6 | 8 | 4 | 4 | 5 | 4 |
| Panda     | 8 | 7 | 8 | 6 | 4 | 4 | 6 | 5 |
| Whale     | 5 | 9 | 3 | 9 | 7 | 7 | 4 | 4 |
| Cat       | 8 | 4 | 9 | 5 | 3 | 4 | 6 | 9 |
| Chameleon | 7 | 5 | 8 | 5 | 4 | 5 | 7 | 7 |
| Rabbit    | 6 | 4 | 7 | 7 | 5 | 6 | 5 | 8 |
| Mole      | 5 | 7 | 5 | 6 | 5 | 5 | 8 | 7 |
| Monkey    | 5 | 5 | 4 | 8 | 8 | 8 | 6 | 5 |
| Sheep     | 4 | 5 | 4 | 4 | 8 | 8 | 8 | 4 |
| Penguin   | 3 | 6 | 5 | 3 | 9 | 7 | 9 | 6 |
| Bat       | 6 | 5 | 6 | 5 | 7 | 9 | 4 | 6 |

**Level scaling** `getTypeLevelStat(type, lv)` (CharacterData.cs:515):
```
typeLevelStat[i] = floor( (lv - 1) * (baseStat[i] + 3) * 0.083 )
```
So each stat grows ~`(base+3)/12` per level (0.083 ≈ 1/12). Higher base stats grow faster.

> **Server Difference:** Original code has no level cap on this formula (scales continuously up to Lv 100+). In Tales of Tail (ToT), passive stat growth from level is capped at Lv 95 (`min(lv, 95)` — levels 96–100 grant no additional passive level stats). **User-reported 2026-10-25 (not in the decompiled client):** on ToT, every 5 levels past Lv 95 the player chooses between 5 plain stat points (not +5 on every stat) and a Class C skill point (1 assumed from the singular wording; unconfirmed). Shown on the Bible's server balance page under Common.

**Character creation** `getNewRandomStat` (CharacterData.cs:538–624):
1. Start with class base stats `getTypeStat(mType)` (CharacterData.cs:547).
2. Add `+1` to 4 randomly chosen stats with replacement (CharacterData.cs:553–570).
3. Subtract `−1` from 4 randomly chosen stats with replacement (CharacterData.cs:576–593).
4. Add `+1` to all 8 stats and clamp each stat to `[3, 12]`: `Mathf.Clamp(typeStat[k] + 1, 3, 12)` (CharacterData.cs:601).
Net: Maximum possible roll on any stat is hard-capped at **12**, and minimum possible roll is **3**. For high-base stats (e.g. Bison ATK base 9, Whale DEF base 9), unconstrained `9 + 1 + 4 = 14` is clamped down to `12`.

---

## 2. Combat / damage pipeline

A hit is resolved in `CharacterControl.hit(actionCode, target, nDamage, nKo, nHate, nForce)` (CharacterControl.cs:2807).
The **canonical order** (CharacterControl.cs:3540–3566):
```
raw      = flatBase + statAdjust(coefficient)   // computed by the skill (see §3)
nDamage  = attacker.dmgAdjust(raw)              // attacker's outgoing multiplier + LCK spread
nDamage  = target.defAdjust(nDamage)            // TARGET's mitigation (DEF + LCK spread)
nKo      = attacker.koAdjust(nKo)
nHate    = attacker.hateAdjust(nHate)
target.RPC_AddDamage(actionCode, nDamage, nKo, nHate, nForce, attackerID)
```

**`hit()` return value versus final HP loss:** After calling the target's `RPC_AddDamage`, `hit()` returns its local `nDamage` (`CharacterControl.cs:3566-3571,3672-3673`), which is the value after `defAdjust` and before the target's `hitMod`. `RPC_AddDamage` is `void` (`CharacterControl.cs:3680`) and applies `ceil(clamp(hitMod, 0, 3) × nDamage)` to its own local parameter (`CharacterControl.cs:3765`); that later `finalDmg` is not returned to the attacker. Skills that heal or scale another effect from the return of `hit()` therefore read **`netDmg`**, not final HP loss. This matters when the target's `hitMod` differs from 1.

### 2.1 The LCK spread
Almost every adjuster adds a random roll driven by the actor's Luck:
```
R = Random(0, ceil(0.2 * LCK))     // integer in [0, ceil(0.2*LCK))
```
Higher LCK ⇒ a wider upward spread on damage dealt, damage mitigated, action speed, cast speed, buff length, skill power.

Unity's integer `Random.Range(min, max)` excludes `max`. All 11 `*Adjust` methods are defined once, in
CharacterControl.cs:20487-20671, and no subclass overrides them. Seven of them roll `R`: `dmgAdjust`, `atkAdjust` (dead code),
`defAdjust`, `agiAdjust`, `magAdjust`, `chaAdjust` and `talAdjust`. The other four have **no** `R`:
`koAdjust`, `hateAdjust`, `forceAdjust` (plain `*Mod` multipliers) and `lckAdjust` (reads LCK directly, clamped 1-512).

> **Server Difference (TTO, user-reported live change 2026-09-28, not in the decompiled client):** Tailstopia Online removed `R` from `talAdjust`, `dmgAdjust` and `defAdjust`, which are now `R = 0` there. `agiAdjust`, `magAdjust` and `chaAdjust` keep their roll. Call sites that add their own inline `Random.Range(0, ceil(0.2 × LCK))` outside these three functions are not covered by this report and are assumed unchanged, for example Wolf Dark Edge's Effect Damage (`Wolf.cs:15267`) and Cat No Chance's flat `0.3 × LCK` (not a roll). The Bible applies this with `tdlRoll(R)` inside its `talAdjustAtRoll` / `dmgAdjustAtRoll` / `defAdjustAtRoll`.

### 2.2 Attacker side
**`dmgAdjust(d)`** outgoing damage (CharacterControl.cs:20487):
```
dmgAdjust(d) = ceil( clamp(damageMod, 0, 5) * d + R )
```
`damageMod` defaults to `1.0` (CharacterControl.cs:142) and is raised/lowered by buffs/debuffs (e.g. `damagePlus`,
`powerBreak`). Capped at 5× outgoing.

**`atkAdjust(p)`** (CharacterControl.cs:20516) — **dead code, never called.** Fully implemented, same shape as
every other adjuster:
```
atkAdjust(p) = floor( clamp( p * (ATK + R), 1, 512 ) )
```
but `grep -rn "atkAdjust("` across the entire `DecompiledSource/` tree returns only this definition — zero
call sites in any `<Class>.cs`, companion file, or elsewhere in `CharacterControl.cs` itself. Real ATK-scaling
damage (basic attacks, charge attacks, hybrid ATK+TAL skills) reads the raw `mChar.atk` stat directly with a
plain float coefficient instead (see §3.2) — do not cite this function as live in any card/desc.

**`koAdjust` / `hateAdjust` / `forceAdjust`** (CharacterControl.cs:20495/20509/20502):
```
koAdjust(n)   = clamp(floor(koMod   * n), 0, 99)
hateAdjust(n) = clamp(floor(hateMod * n), 0, 999)
forceAdjust(v)= forceMod * v        // knockback vector scaling
```

### 2.3 Defender side — `defAdjust(d)` (CharacterControl.cs:20524)
The **live mitigation formula**:
```
N     = clamp(DEF + R, 1, 512)                       // R uses the DEFENDER's luck
light = max( (int)( d - 0.5 * N ) , 1 )              // flat armor component, truncated to int (num2)
heavy = max( (int)( d * (1 - N/(N + 64)) ) , 1 )     // percentage component, truncated to int (num3)
taken = ceil( 0.35 * light + 0.65 * heavy )
```
Both parts are `int` locals (`num2`, `num3`, `CharacterControl.cs:20524-20570`), so each is truncated **before** the
35/65 mix; only the mix is rounded up. Using the un-truncated parts overshoots by 1 on some inputs (found 2026-10-06
while fitting TTO Gorgon Shot readings). The Bible's `defAdjustAtRoll` already truncates both parts.
Interpretation: 35% of the hit is reduced by flat armor (`−DEF/2`), 65% by a diminishing-returns percentage
(`DEF/(DEF+64)`). DEF has *no* hard cap on usefulness but the percentage term saturates (e.g. DEF 64 → −50% on
the heavy part; DEF 192 → −75%).

> **Server Difference (TTO Magic Damage, user-reported live change 2026-10-06, not in the decompiled client):** on
> Tailstopia Online a hit from a skill tagged **Magic** goes through the same `dmgAdjust` → `defAdjust` → `hitMod`
> pipeline, but `defAdjust` uses **half the defender's DEF, not rounded**: `N = clamp(DEF / 2 + R, 1, 512)` (R is 0 on TTO,
> see §2.1). The BigBug client has no magic/physical split; the tag is TTO's own. **Which skills:** the official
> TailsTopia skill simulator (`https://tailstopia.online/skill-simulator`, login required) gives every skill a
> `dmgType` of `Physical`, `Magic`, `Effect`, `Heal` or `None` (labels กายภาพ / เวทมนตร์ / สถานะ / ฟื้นฟู); read
> 2026-10-06: 75 skill families are `Magic` (e.g. Wolf Crusader, Monkey Fireball, every Penguin mana / star / ice
> skill, Rabbit Gorgon Shot, Chameleon Slayers). The full list is `TTO_MAGIC_DMG` in the Bible `index.html`.
> **Conditional:** Mole's Auto Gyro Gun shots are Magic while **Synchro Mole** is on (user-reported 2026-10-06; the
> simulator tags Synchro Mole itself as Magic).
> **Measured (user, TTO, 2026-10-06):** Rabbit Gorgon Shot (`talAdjust(50 × sLv)`) at TAL 101 (base 302 / 151), LCK 0
> on both sides, no buffs, first hit on a fresh target (petrify lowers DEF afterwards). The rest of `defAdjust` is
> unchanged, both parts still truncated to `int` (see above):
>
> | Target DEF | 2 | 5 | 15 | 112 | 177 | 200 | 300 |
> |---|---|---|---|---|---|---|---|
> | Rank 2 (base 302) | 299 | | | 201 | 172 | 165 | 138 |
> | Rank 1 (base 151) | 149 | 147 | 140 | 96 | 79 | 74 | 56 |
>
> All 12 match `DEF / 2` exactly. The odd DEFs settle the rounding: `ceil(DEF / 2)` gives 146 at DEF 5 and 139 at DEF 15,
> and `floor(DEF / 2)` gives 173 at DEF 177 (rank 2). Full DEF (the BigBug formula) gives 158 at DEF 112 (rank 2).
> `scripts/validate_skills.js` pins these readings (`[TTO MAGIC ERROR]`).

> **Alternate / legacy formula** `Damage.getDamage(d, def)` (Damage.cs:262):
> `ceil( 0.25*d + 0.75*d*(1 − def/(def+64)) )` — a simpler 25/75 split with **no** flat term and **no** luck roll.
> The instance `defAdjust` (35/65 split, +luck, +flat armor) is what real player/mob combat uses; `getDamage`
> is only the static helper. If your numbers don't match, you're probably comparing against the wrong one.

### 2.4 Timing / duration / chance adjusters
**`magAdjust(t)`** cast time, MAG-based (CharacterControl.cs:20584):
```
n            = clamp(MAG + R, 1, 512)
magAdjust(t) = clamp( t - floor(n/32) , 0.1 , 600 )   // flat cast-time reduction; n/32 is an int divide
```
Source: `int num = Mathf.Clamp(this.mag + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)this.lck)), 1, 512); nCastTime = Mathf.Clamp(nCastTime - (float)(num / 32), 0.1f, (float)600);` (CharacterControl.cs:20586-20587).
**`agiAdjust(t)`** action/recovery time, AGI-based (CharacterControl.cs:20575):
```
n            = AGI + R
agiAdjust(t) = t * (1 - n/(n + 128))             // diminishing-returns speedup
```
**`chaAdjust(t)`** buff/debuff duration, CHA-based (CharacterControl.cs:20593):
```
chaAdjust(t) = floor( t * (1 + 0.015 * clamp(CHA + R, 1, 512)) )   // +1.5% duration per CHA
```
Rounds **down**, not up: `nTimer = (int)((float)nTimer * ((float)1 + 0.015f * (float)num));` truncates first, so the
later `Mathf.CeilToInt((float)nTimer)` is a no-op on an already-whole number (CharacterControl.cs:20603, :20619).
**`Damage.getDebuff(t, casterCHA, targetCHA)`** contested debuff duration (Damage.cs:317):
Used by debuffs where duration is contested between caster and target (e.g. `Amplify Damage`, `Ignite`, `World Ignition`, `Acidic Field`).
```
delta = casterCHA - targetCHA
if (casterCHA <= targetCHA):
    getDebuff = floor( t * (1 + delta / (|delta| + 64)) )    // diminishing penalty down to >0
else:
    getDebuff = floor( t * (1 + 0.01 * delta) )               // +1% duration per point of CHA lead
```
**`Damage.getBuff(t, cha1, cha2)`** dual-actor buff duration (Damage.cs:311):
```
getBuff = floor( t * (1 + 0.01 * (cha1 + cha2)) )
```
**`talAdjust(p)`** skill power, TAL-based (CharacterControl.cs:20624):
```
talAdjust(p) = floor( p * (1 + 0.02 * clamp(TAL + R, 1, 512)) )    // +2% power per TAL; p <= 0 returns 0
```
Rounds **down** for the same reason as `chaAdjust`: `nPower = (int)(...)` truncates before the no-op
`Mathf.CeilToInt` (CharacterControl.cs:20643, :20653).
**`lckAdjust(c)`** probability boost, LCK-based (CharacterControl.cs:20658):
```
X            = c * (1 + 0.01 * clamp(LCK, 1, 512))
lckAdjust(c) = floor( 100 * X / (X - c + 100) )     // pushes a % chance upward, with diminishing returns
```
Used wherever a percentage roll happens (status infliction, special procs). Note: at very high LCK the result
asymptotically approaches but never reaches 100.

### 2.5 Outcome display categories
`eDamageType { damage, ally, effect, heal }` (eDamageType.cs) selects damage-number color. Combat outcome FX
(no-hit results) have dedicated displays: **miss, evade, resist, immune, deflect, reflect, confuse**
(Damage.cs `displayMiss/displayEvade/displayResist/displayImmune/displayDeflect/displayReflect/displayConfuse`).

### 2.6 Target-side damage received multiplier — `hitMod` (CharacterControl.cs:160, 3765, 6203)
`hitMod` is the engine-level incoming damage multiplier stored on each character (`this.hitMod`, default `1.0f`, CharacterControl.cs:160). It scales **all incoming damage** received by the character before shield absorption:

1. **Direct Physical / Skill Damage (`RPC_AddDamage`, CharacterControl.cs:3765):**
   ```csharp
   nDamage = Mathf.CeilToInt(Mathf.Clamp(this.hitMod, 0f, 3f) * (float)nDamage);
   ```
2. **Effect / True / DoT Damage (`RPC_AddEffectDamage`, CharacterControl.cs:6203):**
   ```csharp
   nDamage = Mathf.FloorToInt(Mathf.Clamp(this.hitMod, 0f, 3f) * (float)nDamage);
   ```
3. **Hard Clamps:** Multiplier is clamped to `[0.0, 3.0]`.

#### Apply-site vs removeStatus mirror (fixed 2026-09-22 — see the same-day `atkAdjust` finding for the
general pattern; citations below were pointing at the `removeStatus` mirror, not the real apply site)
The true apply-site logic lives in the generic per-status coroutine (`CharacterControl.cs` ~29658–42189, the
"Main()" state machine `hit()`/`RPC_AddStatus` compiles down to), **not** `removeStatus` (CharacterControl.cs
:14452–19043) — `removeStatus` only reverses whatever the apply site did, at the same line offset minus
~21000. Citing the mirror instead of the apply site is an easy mistake (both contain a plausible-looking
`hitMod -=`/`+=` line for the right status name) and is exactly what happened here previously. Values below
are re-verified at the real apply-site line:
* **Incoming Damage Amplifiers (Debuffs, `hitMod` increases):**
  * `amplifyDamage` (Bat): `this.hitMod += 0.05f * sLv` (CharacterControl.cs:40480) — `+5%×rank` (+0.05 to +0.20) incoming damage.
  * `ignite` (Monkey, World Ignition): `this.hitMod += 0.1f * sLv` (CharacterControl.cs:37903) — `+10%×rank` incoming damage; card-verified, `monkey_worldIgnition2`'s own `desc` independently states "รับความเสียหายเพิ่มขึ้นจากทุกแหล่งที่มา".
  * `inferno`: `this.hitMod += 0.1f * sLv` (CharacterControl.cs:42083).
  * `miracleDrop` (Rabbit): `this.hitMod += 0.1f * sLv + 0.1f` (CharacterControl.cs:37674) — a tradeoff, not a pure debuff: `damageMod` gains the identical `+0.1×sLv+0.1` in the same block, so this is "hit harder, get hit harder."
  * `reduce`: `this.hitMod += 0.05f * sLv` (CharacterControl.cs:37261) — same tradeoff shape as `miracleDrop` (a self-shrink effect; see `MOD_DEFS.reduceDmg`/`reduceHit` in `index.html`).
  * `maim` (Rabbit): **not a `hitMod`/`damageMod`/`moveMod` change — a direct, continuous `moveSpeed` clamp.** The `sType == "maim"` apply-site (`CharacterControl.cs:37208-37214`) and `removeStatus` (`:16642-16648`) cases are indeed empty (`goto`/`break` only), which is what caused this entry to previously claim no effect was found — that conclusion only checked the one-time apply/remove handlers. The real effect lives in a **third, separate site**: `CharacterControl.cs:2509-2546`, inside `CharacterUpdate()` (the per-frame update loop, not `RPC_AddStatus`/`removeStatus`), in the same `sType` switch that also handles `nightmare`'s hard `moveSpeed = 0`. Every frame, while `this.isMine` and `this.actionState == "run"`: `if (this.moveSpeed > 4f - 0.5f*statusClass.sLv) this.moveSpeed = 4f - 0.5f*statusClass.sLv;` — a live clamp on `moveSpeed` itself (not a `moveMod` percentage), gated to running only (matches the client tooltip "จำกัดความเร็ววิ่ง"). Corrected 2026-09-23 after the user reported the earlier "no effect found" claim contradicted clear live behavior.
* **Incoming Damage Reducers (Buffs, `hitMod` decreases):**
  * `sealOfDefense` (Sheep): `this.hitMod -= 0.1f` (CharacterControl.cs:39699) — `-10%` incoming damage.
  * `sealOfEarth` (Sheep): `this.hitMod -= 0.15f` (CharacterControl.cs:39713) — also `damageMod += 0.05f` in the same block.
  * `sealOfHeaven` (Sheep): `this.hitMod -= 0.05f` (CharacterControl.cs:39728) — also `damageMod += 0.15f` in the same block.
  * `enlarge`: `this.hitMod -= 0.05f * sLv` (CharacterControl.cs:37341).
* **Removal:** Status expiration reverses the exact operation — the mirror lines are in `removeStatus`,
  CharacterControl.cs:14452–19043 (e.g. `amplifyDamage`'s own mirror sits at :18163, `ignite`'s at :17127).
* **Deliverables & Tooltip Convention:** Player tools describe this mechanic using the player-facing standard
  `+0.xx hitmod` (e.g. `+0.05` to `+0.20` for Amplify Damage), which matches the sign of the real apply site
  above — no inversion to correct for.

### 2.7 Type-specific flat reduction — CaptainCrab

`CaptainCrab` (Crab Captain) has a built-in **100 flat damage reduction per direct hit**. It is not part of `defAdjust` or `hitMod`:

```csharp
// RPC_AddDamage first: ceil(clamp(hitMod, 0, 3) * nDamage)
// CharacterControl.cs:3765

// Later, in the direct-damage AddDamage coroutine:
if (this.self.Type == "CaptainCrab")
    nDamage = Mathf.Max(0, nDamage - 100);
// CharacterControl.cs:31639-31650
```

Therefore the native direct-hit order at this tail of the pipeline is **`hitMod` → shields/status absorption → `max(0, damage − 100)` → HP damage accumulation** (`RPC_AddDamage`: CharacterControl.cs:3759-3765; `AddDamage`: CharacterControl.cs:31580-31662). The test is absent from the separate `RPC_AddEffectDamage` path (whose `hitMod` is at CharacterControl.cs:6203), so this special reduction does **not** apply to effect/true/DoT damage. `GiantSandBug` has the analogous direct-hit `−30` clause immediately before it (CharacterControl.cs:31627-31638).

### 2.8 Evasion (EVADE): only inside the attacker's `hit()` (verified 2026-09-23)

Every dodge in the game is checked in one block of the **attacker's** `hit()` (`CharacterControl.cs:2807`), after the target's `hide` / `noDamage` / `swallow` / `salvation` checks and before `damagePlus` and `dmgAdjust`. `characterControl` there is the target. A successful dodge calls `target.RPC_AddDamage(-82, 0, 0, 0, ...)` and `hit()` returns 0 (`:3636-3641`), so no damage or KO is dealt and every attacker follow-up gated on `hit() != 0` (SP gain, Shadow Fist, on-hit statuses) is skipped too.

| Source | Condition | Chance | Line |
|---|---|---|---|
| `drunken` status (Panda Drunken Plus) | target has the status | `lckAdjust(5 × statusLv)` | `:3076-3094` |
| Panda Roll / Roll Around | `actionState == "attack"` and `myCommand` is `roll` / `rollAround` | 100% | `:3099-3126` |
| Panda Water Monkey / Water Crane | during that command | `lckAdjust(50)`, `lckAdjust(100)` with Time and Tide (#413) | `:3135-3164` |
| Panda Wind & Cloud / Rain & Storm | `actionState == "attack"`, command `windCloud` / `rainStorm` | `lckAdjust(30)` | `:3170-3197` |
| Cat Back Flip | `actionState == "attack"`, command `backflip` | 100% | `:3207-3225` |
| Cat Evasion (#361-#363) | passive; skipped while the attacker has `sleep`/`snowMan`/`snowBall`/`petrify`/`paralysis` | `lckAdjust(4 × level)`, doubled while `actionState == "run"` | `:3246-3334` |
| Chameleon Mass Shot | `actionState == "attack"`, command `massShot` | 100% | `:3361-3379` |
| XunWu (monster) Flame Smite | `actionState == "attack"`, command `flameSmite` | 100% | `:3388-3406` |

Cat **Vendetta** (#364) grants the Cat `RPC_AddHeal(364, 0, 0, 10, ...)` (+10 SP) on every Back Flip or Evasion dodge (`:3230-3241`, `:3339-3350`). Separately, an attacker with `blind` misses `10 + 10 × blindLv`% of the time (marker −81), also inside `hit()`.

**Popup text:** the receiving side maps the negative codes to the floating text in `RPC_AddDamage`'s display coroutine (`CharacterControl.cs:30686-30760`): −81 → `Damage.displayMiss` (**MISS**, a blinded attacker), −82 → `Damage.displayEvade` (**EVADE**, every dodge above), −83 → `displayResist`, −84 → `displayImmune`, followed in the same chain by `displayDeflect` and `displayReflect` (their codes were not read). The textures are `Resources/GameAssets/Effects/Damage/miss` and `evade` (`Damage.cs:611`, `:654`); the PNGs under `effects/damage/assets/materials/` are stored mirrored.

**Not dodgeable:** anything that does not go through `hit()`. That includes Effect Damage (`RPC_AddEffectDamage`, e.g. Panda Shadow Fist, and every Wolf normal attack while Wolf has `darkEdge`, `Wolf.cs:15267`), status ticks/status damage (`StatusUpdate`, `:8832-10634`), projectiles that call `RPC_AddDamage` themselves (`Mole_missile.cs:369`, `BarrelBot_missile.cs:369`, Gallon Bot missile, and many monster projectiles), pet damage, and damage passed on inside `RPC_AddDamage` (`:4994`, `:5531`, `:5661`). The class files contain more direct `RPC_AddDamage` calls that were not classified one by one. The bible's mechanic-glossary topic `evasion` summarises this section.

### 2.9 Damage routing: `hit()` vs direct `RPC_AddDamage` vs `RPC_AddEffectDamage` (verified 2026-09-24)

There are three entry points, and which one a skill uses decides which pipeline stages it gets:

```
hit()  ──(unless a target-state exit)──►  RPC_AddDamage  ◄── direct callers (projectiles, Upheaval AoE, …)
                                            (hitMod, shields, Peninsula Round redirect, …)
RPC_AddEffectDamage  ── separate path: hitMod only
```

- **`hit()` (`CharacterControl.cs:2807-3680`)** calls the target's `RPC_AddDamage` in exactly three ways: the landed hit (`:3566`, after `damagePlus` → `dmgAdjust` → `defAdjust` (`:3546`) → `koAdjust`/`hateAdjust`), a dodge `RPC_AddDamage(-82, 0, …)` (8 sites `:3091-3406`, §2.8), or a blind miss `RPC_AddDamage(-81, 0, …)` (`:3504`). It **returns 0 without calling anything** when: the target is null, not tagged `Player`/`Enemy`, or has no `CharacterControl`; `target.recieveDamage == false`; the target has been dead for more than 3 s; or the target has `hide`, `noDamage`, `swallow` or `salvation` (`:2809-2870` → the `return 0` labels at `:3625-3675`). So every `hit()` that reaches the target goes through `RPC_AddDamage`, but a target-state exit reaches nothing.
- **Direct `RPC_AddDamage` callers** skip everything inside `hit()`: dodge (§2.8), `damagePlus`, `dmgAdjust` and `defAdjust`. `RPC_AddDamage` itself never calls `defAdjust` (the only pipeline call is `hit()`'s `:3546`), so **each direct caller applies defense or not on its own**:
  - Mole Missile (`Mole_missile.cs:349-369`) and Barrel Bot missile (`BarrelBot_missile.cs:349-369`): `target.RPC_AddDamage(…, target.defAdjust(talAdjust(30)), 3, …)`, so DEF applies but there is no `dmgAdjust` (no attacker `damageMod`, no `dmgAdjust` LCK spread).
  - Monkey Lavu Upheaval AoE (`Monkey.cs:35201-35240`): `target.RPC_AddDamage(1, 20·L + 10, 2·L + 1, …)` with no `defAdjust`, so a flat value only modified by the target's `hitMod`.
  - Engine examples that do call `defAdjust` themselves: `CharacterControl.cs:9005`, `:10634`, `:38586` (mana burn).
- **What reaches the `AddDamage` status switch (traced 2026-10-09, `CharacterControl.cs:30600-30821`):** the coroutine ends first when `recieveDamage` is false (`recieveDamage` at `:30602`; `RPC_AddDamage` itself already drops the call on `recieveDamage == false` `:3688`, a game state other than Normal / Hold `:3709-3715`, or `noDamage` `:3724`). Then the **pseudo-hit codes** −81 miss, −82 evade, −83 resist, −84 immune, −85 deflect, −86 reflect, −87 confuse show their floating text and `break` (`:30688-30766`), so they never reach the status switch. Only then does `if (nDamage > 0)` open the per-status switch (shields, `ignite`, **`tent`** → `nDamage = mhp` at `:31050`, `petrify` …, `:30821-31650`), and the damage left over is added to `myDamage` (`:31651`). Consequences: every `hit()` that lands arrives with at least 1 damage, because `defAdjust` is floored at 1 in both branches (`:20524-20560`), even from a raw 0; a **direct** call with damage 0, such as the `RPC_AddDamage(-1, 0, 0, hate, …)` taunts (Whale Honor `Whale.cs:23914`, a Monkey taunt `Monkey.cs:37958`), arrives with 0 and by this code skips the switch. Direct callers with damage are e.g. Cactus Trap / Flying Cacton (`-261`, 20 / 10) and the King Rodinia kill (`-99`, 30000). **Live vs code (user, 2026-10-09):** a Whale's 0-damage Honor taunt **does** kill a tented Chameleon, which this `> 0` gate does not predict; live observation wins, the mechanism is not found (see [chameleon-skill-reference.md](chameleon-skill-reference.md), Tent).
- **Inside `RPC_AddDamage`** everything applies no matter how it was reached: `hitMod` (`:3765`), `noDamage`/`perfectArmor`/`perfectShield`, the Whale Peninsula Round redirect (`:4299-4367`), and then the `AddDamage` coroutine (`:5822`/`:6035` → `$AddDamage$35579`) with shield statuses such as Whale's `shield` (`:30855-30960`) and the type-specific flat reductions of §2.7.
- **`RPC_AddEffectDamage` (`:6058`)** is its own path: `hitMod` (`:6203`) but no dodge, no `defAdjust`, no shield statuses and no Peninsula Round redirect (the only `"peninsulaRound"` check in the engine is `:4313`).
- **Who can receive Effect Damage (decoded from the game data 2026-10-13; this corrects a wrong first answer).** `RPC_AddEffectDamage` / `AddEffectDamage` / `onEffectDamageEvent` refuse a target when the game state is not Normal / Hold, `recieveEffectDamage` is false, the target has `hide` / `noDamage` / `swallow`, is at `hp <= 0`, or its `Type` is `SmashBall` / `IronBall` (`CharacterControl.cs:6080-6110`, `:6498`, `:6559-6590`). The C# default of the flag is `true` (`:169`), but **each prefab serialises its own value, and that value wins** (the first answer wrongly trusted the default because the ripped prefab YAML shows no `CharacterControl` fields at all). Decoding every `CharacterControl` in `12TailsOnline_Data` (2,299 components, 429 distinct `Name` / `Type`; layout in [decode-character-stats](../.claude/skills/decode-character-stats/SKILL.md)) gives **20 unit types with `recieveEffectDamage = 0`, the same in every copy: Annonite, EarthAvatar, Ewiniar, Germanotta, GuardTower_i, SkyBug2 (HiSkyBug), IronBall, LifeTower_i, **ManaVortex**, MokBug, MokBug2, NemesisBug, NemesisBug_a, SkyBug, **SnowFortGate**, Snowman, SoccerBall, **StingDune**, WarGate and SmashBall (WhaleBall)**. Every other unit takes it. Twelve of these also have `recieveDamage = 0` (cannot be hit at all): Annonite, EarthAvatar, Ewiniar, GuardTower_i, SkyBug2, LifeTower_i, MokBug, MokBug2, NemesisBug, NemesisBug_a, SkyBug, SoccerBall; ManaVortex, SnowFortGate, StingDune, Germanotta, IronBall, Snowman, WarGate and SmashBall can be hit but not by Effect Damage. For the three the user asked about: ManaVortex flags `Target 1, Damage 1, EffectDamage 0, Movement 1, Force 0, Status 0, Heal 1, Hate 0, Revive 0, Gravity 1`; SnowFortGate and WarGate `1 1 0 0 0 0 0 0 0 0`; StingDune `1 1 0 0 1 0 0 0 0 0` (one copy has Force 0). **HP is applied the same way for hit damage:** `AddDamage` adds to `myDamage` (`:31657`) and `CharacterUpdate` subtracts it from `hp`, flashes the body red and holds `myDamage = -1` for one frame (`:2103-2128`); StingDune keys its hit reaction off that flag (`StingDune.cs:160-168`: `RPC_getHit` on the owner's client when the 3 s `nAttack` timeout is free: `getHit` animation, a new 3 s timeout, then a `20 + 0.03 × hp` % chance to spawn three `StingBug2_y`, at most one wave per 200 HP lost, `:575-640`), so **only normal hits** trigger it: Effect Damage is refused at the gate before it reaches `myDamage` (`:6966`). Whether a *skill* reaches a structure is a separate, skill-side targeting filter (e.g. Cat Grand Casino, Combo's Hidden Blade check).
- **Tool note:** the bible models these with card flags. `dmgAdjustSkip:true` = skips `dmgAdjust` but keeps `defAdjust` (Mole Missile, Barrel Bot Missile). `penetrating:true` = skips both (Flame Turret, Flame Carnival, Monkey Lavu). `effectDamage:true` = the `RPC_AddEffectDamage` path. A direct-caller card without the right flag overstates damage, because the default pipeline applies `dmgAdjust`.

---

### 2.10 Equipment critical hit — `getCritPlus` (verified 2026-09-29)

Every class with crit gear wraps some raw damage values in its own `getCritPlus(nDmg)` before calling `hit()` (Wolf `Wolf.cs:14160-14186`, Bison `Bison.cs:13801-13950`, Sheep `Sheep.cs:16494-16640`, Rabbit `Rabbit.cs:16471-16600`, Cat `Cat.cs:15410`, Monkey `Monkey.cs:19061`, Penguin `Penguin.cs:16239`, Bat `Bat.cs:19389`; identical shape):

- **Gear sum** `n`: weapon `w_<cls>43`/`44` +5, `w_<cls>58` +7; armor `a_all43`/`44` +4, `a_all58` +6; hat `c_all43`/`44` +3, `c_all58` +5. Full Marshal (supreme commander) set = 12, full Champion set = 18; there is no other source of crit in these functions.
- **Roll:** `Random.Range(0, 100) < lckAdjust(n)` (`lckAdjust` as in §2.4, LCK clamped to 1-512); each call rolls on its own. `n = 0` never crits.
- **Effect:** `FloorToInt(1.8 × nDmg)` on the raw value only. The result still goes through `hit()` → `dmgAdjust` → `defAdjust` → `hitMod`, so final damage is not exactly 1.8x.
- **Example chances** (LCK 0 / 128 / 512): Marshal 12 → 12% / 23% / 45%; Champion 18 → 18% / 33% / 57%.
- **Where the wrap sits differs per skill:** Rabbit rifle Combo, the ricochet and From the Above wrap `hitDmg + Hyper Shot`; the Customized Shotgun wraps only `(int)(0.5 × ATK)` and adds Hyper Shot after; Rabbit Charge Attack has no `getCritPlus` at all; Cat's Hidden Blade replacement hit skips it too (`Cat.cs:16622`).
- **Lv 60 weapon `w_<cls>59` and the crit (verified 2026-10-06):** on Cat, Monkey, Penguin, Bat, Rabbit, Sheep, Mole and Whale Combo the weapon's `floor(0.75 × raw)` comes **before** `getCritPlus` (`Cat.cs:16525`, `Monkey.cs:19984`, `Penguin_nAttack.cs:115`, `Bat_nAttack.cs:217`, `Whale.cs:16169-16180`), so a crit is `floor(1.8 × floor(0.75 × raw))`; on Wolf (Katana), Bison (Vacuum Hammer, `Bison.cs:14776-14787`) and Panda (Force Gauntlet, `Panda.cs:15333-15349`) it scales the **already crit-rolled** value. Chameleon's Power Bow only raises the hit force (no damage change). The Lv 60 weapon and the crit weapon share the weapon slot, so the Champion crit set with it tops out at 11. All twelve are modelled on the Combo cards.
- Modeled in the Bible on Wolf Combo, Bison Combo, Sheep Book Bash, Rabbit Combo and Cat / Monkey / Penguin / Bat Combo (`critProc` / `rawModel.critBase`, "ดูสูตรคริ" toggle that shows the card as a crit hit).

## 3. Skills

### 3.1 Skill metadata — `SkillClass` (SkillClass.cs:154–188)
```
name, des,
type   : eSkillType   { normal, support, finalMove }
mode   : eSkillMode
target : eSkillTarget
cType  : class prefix
cMP    : MP cost      cSP : SP cost      cMana : Mana cost
rLv    : required level
rBn    : required bonus/rebirth tier
rSkill : prerequisite skill id
```
Skills are looked up by a 3-letter class prefix (`wlf`, `bsn`, `pnd`, …) in `SkillData.getSkill` (SkillData.cs:21),
which dispatches to the per-class `*Skill.cs` table. The `*Skill.cs` files only hold this metadata
(costs / requirements / text) — **not** the damage numbers.

#### Signed SP Cost Semantics (`cSP`):
* **Red SP (Consumed, `cSP < 0` / `skillClass.setSP(-X)`):**
  Requires and **consumes** SP on cast (`GameGui.cs:37782–37807`: `mChar.sp += cSP`). Its cost is halved by Revised Skill (#404, `Mathf.CeilToInt(cSP * 0.5f)`). Rendered in-game as red text `new Color(1f, 0.2f, 0.2f)` (`GameGui.cs:22032`, `Guix.cs:3301`). Standard for almost all physical skills.
* **Blue SP (Activation Threshold / Gate-Only, `cSP > 0` / `skillClass.setSP(X)`):**
  Checks that the player currently possesses at least that amount of SP (`GameGui.cs:37609`), but **does NOT consume SP** on cast (the `cSP < 0` deduction branch in `GameGui.cs:37782` is bypassed). Rendered in-game as cyan-blue text `new Color(0.2f, 0.6f, 1f)` (`GameGui.cs:22054`, `Guix.cs:3288`). (e.g. Whale's `rejuvenate` Ranks 3–4 requiring 12 SP without spending it).
#### Cost is paid on the press, not on the cast (verified 2026-10-06)
GameGui's skill-press coroutine checks cooldown (`TimeOut!`), SP, MP, Mana and `isSpecialForm` / `isTransform`
(`GameGui.cs:37596-37667`), then `SendMessage("doSkill", …)` to the character and **immediately deducts the cost**
(`:37929-37980` for target mode, `:37748-37823` for the others). It has no `actionState` gate, and the class
`doSkill` returns nothing to it, so when the class code refuses (wrong state, no target) the MP/SP is lost unless
that class refunds it explicitly (e.g. Chameleon Fatal Strike under Immunity, `Chameleon.cs:7904`). Example:
Chameleon Skin Shift pressed while casting ([chameleon-skill-reference.md](chameleon-skill-reference.md)).

#### Who a skill can target (verified 2026-10-06)
Only `eSkillMode.target` skills get the layer check: `target: enemy` refuses an ally ("Cannot Target Ally!"),
`target: ally` refuses an enemy (`GameGui.cs:37884-37919`); `target: all` has none. Instant-mode skills pass the
current selection as is (`:37726-37752`). The ally-cycle key selects the player first (`:2214`), so `all`-target
and instant skills can be used on yourself (Whale Swallow on itself rolls Auto Shield 9 times; Chameleon Venom
Shock on an ally is a poison block; see the class references).

### 3.2 Skill damage model
Damage values are hardcoded at each skill's execution site (in the class combat script, e.g. `Cat.cs`, and in
projectile/effect scripts). The universal shape is:
```
raw = flatBase + <statAdjust>(coefficient)
```
Example — Cat AoE skill (action 444), Cat.cs:10845:
```
this.mChar.hit(444, target, this.mChar.talAdjust(50) + 200, 3, 0, Vector3.zero);
            //                       └ TAL-scaled power ┘  └flat┘
```
So that skill's damage before the attacker/defender adjusters is `talAdjust(50) + 200`.

- **Most active skills scale on TAL** via `talAdjust(coeff)` (`+2%`/TAL).
- **Basic/weapon-style and hybrid ATK+TAL hits scale on ATK by reading the raw stat directly**
  (`mChar.atk` × a plain float coefficient, e.g. Cat's Combo at `Cat.cs:16502`: `(int)(0.5f * mChar.atk)`;
  Cat action 434 at `Cat.cs:40195`: `(int)(1.5f * mChar.atk + talAdjust(45))`) — **not** through `atkAdjust`.
  `atkAdjust(p)` is fully implemented at
  `CharacterControl.cs:20516` (`floor(clamp(p*(ATK+R),1,512))`, matching the shape of the other
  adjusters) but has **zero call sites anywhere in the decompiled source** (`grep -rn "atkAdjust("` across
  all of `DecompiledSource/` returns only its own definition) — verified dead code, not merely unwired in
  one class's files (checked project-wide, per the Dead Code Verification Gate in AGENTS.md §3.0). Do not
  cite `atkAdjust` as the mechanism for ATK-scaling damage in any card/desc.
- The final number then runs through `dmgAdjust` (attacker) → `defAdjust` (target) from §2.

### 3.3 Representative coefficients (sampled from Cat.cs)
Coefficient = the literal passed to `talAdjust(...)` (ATK-scaling terms, per §3.2 above, are a plain float
multiplier on the raw stat, not a call to any adjuster); small for low-tier moves, large for ultimates:

| Coeff seen | 1 | 3 | 5 | 6 | 12 | 14 | 15 | 30 | 45 | 50 |
|------------|---|---|---|---|----|----|----|----|----|----|

(Cat.cs:8854, 8916, 10845, 19723, 20882, 21453, 22082, 40195, 50053…). Other classes follow the same pattern with
their own coefficients/flat bases. To read any specific skill: find its action-id in the class script and look at
the `hit(id, target, <expr>, …)` call — `<expr>` is the exact pre-mitigation damage.

### 3.4 Heals
Heals reuse the same dispatch with `RPC_AddHeal`. Example passive regen (CharacterControl.cs:8898):
```
heal = 6*skillLv + 6 + floor(0.004 * skillLv * maxHP)
```
i.e. a flat part plus a % of the target's max HP scaled by skill level.

### 3.5 Universal Shared Skills (CharacterDataClass.cs, CharacterControl.cs)
Five skills share identical numeric skill IDs, mechanics, and effects across all 12 classes (verified in `Monkey.cs`, `CharacterControl.cs`, `CharacterDataClass.cs`, and `PenguinSkill.cs`):

| Skill Name | ID | Mechanics & Effect |
|------------|----|--------------------|
| **Stat Plus** (`statPlus1..4`) | `#141–144` | Grants `+2` to all 8 stats per rank (`+2, +4, +6, +8` total). Evaluated directly in `CharacterDataClass.getStat(n)` (CharacterDataClass.cs:1216). |
| **Super Stat Plus** (`superStatPlus5`) | `#441` | Grants `+10` to all 8 stats unconditionally. Evaluated in `CharacterDataClass.getStat(n)`. |
| **Revised Art** (`revisedArt5`) | `#424` | `-12%` cooldown reduction on all skills across the board, applied in `addTimeOut` as `cTime = (float)Mathf.CeilToInt(0.88f * cTime)` (`CharacterControl.cs:20227`; `cTime` is the already-`agiAdjust`ed fractional value, and without Revised Art it is left unrounded). **Round-up can raise the cooldown:** `ceil(0.88X) > X` whenever `(k-1)/0.88 < X < k` for a whole `k <= 8` (e.g. `0.5 → 1`, `3.5 → 4`, `7.96 → 8`); a raw `7.9` still drops to `7`. From `k >= 9` the window is empty, so it only happens for cooldowns under 8s. Excludes basic attack (`nAttack`), charge attack (`cAttack`), and consumables. |
| **Revised Magic** (`revisedMagic5`) | `#414` | `-20%` MP cost reduction (`Mathf.CeilToInt(cMP * 0.8f)`). |
| **Revised Skill** (`revisedSkill5`) | `#404` | `-50%` SP cost reduction (`Mathf.CeilToInt(cSP * 0.5f)`). |

These five skills are class-independent engine constants.

**AGI that replaces Revised Art (verified 2026-09-25, LCK 0).** From `agiAdjust` (§2.4) the cooldown is `CD × 128 / (AGI + 128)`; Revised Art multiplies it by 0.88. Matching the Revised Art cooldown without it: `CD × 128 / (AGI' + 128) = 0.88 × CD × 128 / (AGI + 128)`, and `CD` cancels, so for **every** skill:

```
AGI' = (AGI + 128) / 0.88 − 128 = 1.136 × AGI + 17.5      extra AGI = 0.136 × (AGI + 128) ≈ (AGI + 128) / 7.3
```

| AGI with Revised Art | 0 | 50 | 100 | 150 | 200 | 300 | 400 |
|---|---|---|---|---|---|---|---|
| AGI without it | 17.5 | 74.3 | 131.1 | 187.9 | 244.7 | 358.4 | 472.0 |
| Extra AGI | +17.5 | +24.3 | +31.1 | +37.9 | +44.7 | +58.4 | +72.0 |

Revised Art is a flat 12% of the cooldown while each AGI point's cut shrinks as AGI rises, so the AGI it is worth grows with AGI. Rounding: with Revised Art the cooldown is `ceil(0.88 × cd)` (whole seconds, up) and without it it is unrounded, so the exact need can be up to one AGI lower (120s at AGI 0: `ceil(105.6) = 106s`, reached without Revised Art at AGI 17, not 17.5). Checked against exact rounding on Dark Edge / Lunar Eclipse / Rapid Trance / Immunity: the formula is within 0.5 AGI.

---

### 3.6 Skill learning rules (class skill window; verified 2026-10-12)

Source: `CharacterDataClass.cs` `upgradeSkill` / `upgradeCSkill`, `GameGui.cs:16429-16560` (skill window states), `SkillClass.setReq` (`SkillClass.cs:108`, stores `rLv` and `rBn`). Used by the hub's Skill Simulator.

* **Skill ids and grid:** a skill's command number is `tree*100 + row*10 + column` with trees 1 = Basic, 2 = Class A, 3 = Class B, 4 = Class C, rows 0-7, columns 1-4 (`<Class>Skill.getSkillTree`, e.g. `RabbitSkill.cs:2287`). The window counts the learned skills inside `tree*100+100 .. tree*100+199` as that tree's points (`GameGui.cs:16355`, field `mXacbsG6yTa`).
* **Point pools:** Basic + A + B share one pool of `clamp(lv − 1, 0, 49)` (`upgradeSkill`, `CharacterDataClass.cs:4005`: refuses when `skillCount() >= that`). Class C has its own pool of `clamp(floor(0.2 × (lv − 50)), 0, 12)` (`upgradeCSkill`, `:4388`), i.e. one C point per 5 levels from Lv 55, 9 at Lv 95.
* **Window states** (`GameGui.cs:16429-16560`): a skill is locked when `lv < rLv`; locked when the points already spent **in its own tree** are `< rBn`; locked when its `rSkill` is not learned (`rSkill > 99999` means two skills, `rSkill / 1000` and `rSkill % 1000`); and, for every skill below 400 whose command number does not end in 1, locked until the skill one number lower (the previous rank or the cell to its left) is learned. Class C skills have no left-cell rule.
* **Reading `rBn`:** it is "skills already learned in this tree before this one" (first cell of a tree is 0). A learned set is reachable only if, with each tree's `rBn` values sorted ascending, the k-th value (from 0) is `≤ k`.
* **Cells that need a live check:** 12 cells (empty `getSkill` branches whose value is borrowed from a shared tail, and jumps to a shared `setReq` that the 2014 simulators contradict) are listed with the full simulator comparison in §3.7. The tool uses the game code for them; change a value only after the user confirms it in the live game.
* **Decoding caveat:** `rLv`/`rBn` come from `getSkill` (`python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs`); `rSkill` is a separate `skillClass.rSkill = N` line the decoder does not print (grep it in `<Class>Skill.cs`).

### 3.7 Skill Simulator discrepancies: game code vs the 2014 blog vs TailsTails (recorded 2026-10-12)

Everything the hub's Skill Simulator was checked against, kept in one place so it can be recalled later. **Rule: the simulator always uses the game code.** A value changes only when the user confirms the live game shows something else (live observation beats decompiled code, AGENTS.md §3 item 4).

* **Sources.** *Game code* = `<Class>Skill.getSkill` (decoded with `scripts/decode_skilldata.py`) and `getSkillTree`. *Blog* = Rain Niar's SkillSimulator V.3 per class (April 2014; the 3.1 versions from May 2015 are offline). *TailsTails* = tailstailssimulator.online/<class>. **The TailsTails data equals the blog's in every cell compared, so it is a copy and not independent confirmation.** Where the two simulators agree against the code, that proves nothing about the live game. *TailsTopia* = the TTO server's own simulator (tailstopia.online/skill-simulator, login only, read through the user's Chrome); it carries the game's own fields and is compared in section E.
* **Totals.** 1,159 cells compared over all 12 classes (grids of 15-18 / 30 / 30 / 20 cells); **1,139 equal in all three, 20 differ** (table A). Bison, Monkey, Penguin and Wolf have no difference at all.

**A. The 20 cells whose Lv / points differ** (`Lv/points`, game code first; this is what the simulator uses)

| Class | Skill | Cell | Game code | Blog | TailsTails | Kind |
|---|---|---|---|---|---|---|
| Rabbit | Long Shot II (`nAttack2`) | Basic r1c2 | **2/0** | 2/1 | 2/1 | no effect (rank chain) |
| Rabbit | Long Shot III (`nAttack3`) | Basic r1c3 | **3/0** | 3/2 | 3/2 | no effect (rank chain) |
| Rabbit | Long Shot IV (`nAttack4`) | Basic r1c4 | **4/0** | 4/3 | 4/3 | no effect (rank chain) |
| Rabbit | Life Shot | A r6c4 | **32/21** | 32/22 | 32/22 | explicit `setReq` |
| Rabbit | Customized Shotgun II (`customizedShotgun2`) | B r6c4 | **28/22** | 32/22 | 32/22 | empty branch (fall-through) |
| Mole | Extra Powder II | A r7c2 | **28/18** | 27/18 | 27/18 | empty branch (fall-through) |
| Mole | Heavy Built II | B r7c2 | **28/18** | 27/18 | 27/18 | empty branch (fall-through) |
| Bat | Drain Life II (`cAttack2`) | Basic r2c2 | **10/3** | 10/2 | 10/2 | empty branch (fall-through) |
| Bat | Drain Life III (`cAttack3`) | Basic r2c3 | **16/5** | 16/3 | 16/3 | jump to a shared `setReq` |
| Cat | Feline Agility II | Basic r4c2 | **19/6** | 18/6 | 18/6 | jump to a shared `setReq` |
| Cat | Feline Agility III | Basic r4c3 | **24/8** | 28/8 | 28/8 | jump to a shared `setReq` |
| Cat | Feline Agility IV | Basic r4c4 | **32/10** | 38/10 | 38/10 | empty branch (fall-through) |
| Chameleon | C Attack II | Basic r2c2 | **10/3** | 10/2 | 10/2 | empty branch (fall-through) |
| Chameleon | C Attack III | Basic r2c3 | **16/5** | 16/3 | 16/3 | jump to a shared `setReq` |
| Panda | Combo II (`nAttack2`) | Basic r1c2 | **2/0** | 2/1 | 2/1 | no effect (rank chain) |
| Panda | Combo III (`nAttack3`) | Basic r1c3 | **3/0** | 3/2 | 3/2 | no effect (rank chain) |
| Panda | Combo IV (`nAttack4`) | Basic r1c4 | **4/0** | 4/3 | 4/3 | no effect (rank chain) |
| Panda | Rain & Storm II | B r6c4 | **30/21** | 32/21 | 32/21 | empty branch (fall-through) |
| Sheep | Combo II (`nAttack2`) | Basic r1c2 | **2/0** | 2/1 | 2/1 | no effect (rank chain) |
| Whale | Rejuvenate III | B r4c3 | **18/7** | 21/7 | 21/7 | jump to a shared `setReq` |

Kinds: **explicit `setReq`** (1): the code states the value, the simulators are wrong (Rabbit Life Shot needs 21 points in `setReq(32, 21)` at `RabbitSkill.cs:580`, the simulators say 22). **no effect (rank chain)** (7): 0 points in the code against 1 / 2 / 3 in the simulators; a rank always needs the rank before it, so the rows that many skills anyway and nothing changes. **jump to a shared `setReq`** (5): the branch jumps to a shared `setReq` label, a defined path, but the simulators show another value (possibly an older server version; not known). **empty branch (fall-through)** (7): the branch has no `setReq` and no `goto`, so the decoder's value is whatever shared tail it falls into; the least certain.

**To verify in the live game (12 cells; lower priority since section E: TailsTopia shows the game-code value for all of them, but it is the TTO server, not the original one):** every `jump` and `empty` row above. The skill window shows the Lv and, for a locked skill, `unknown: n/<points needed>` (read from `GameGui.cs:17167-17173`, not yet seen live). If the live game shows the simulators' value, fix that cell's `SKILL_SIM` entry and the class reference together.

**B. Other data differences (not Lv / points)**

* **SP / MP costs, Rabbit:** Millionaire I / II cost SP 50 / 75 in the code and in the Bible cards, MP 50 / 75 in both simulators; Diamond Shot costs SP 20 in the code, the simulators list none.
* **SP / MP costs, Mole** (8 skills; the Bible cards follow the code): Detonate (SP 24 + MP 24) and Napalm (SP 40) are missing in the simulators; Mega Drill SP 36 and Barrel Cannon SP 50 against none / SP 36; King Kaiser SP 80 + MP 80 against SP 55 + MP 80; Flame Carnival MP 35 against SP 10; War Capital MP 100 + SP 50 against SP 50; Kaiser Cannon has no cost in the decoder output, SP 70 in the simulators. Full list: mole-skill-reference.md.
* **SP / MP costs, the other 10 classes: not compared.** The simulator tool shows no costs, so this was skipped; do it before trusting any simulator's cost column.
* **Names.** The simulators use the community names (Longshot, Aimed Shot, ExtraReward, Deadly Aim); the tool's cell labels are the game's skill keys split into words (`specialDeal` = Special Deal, `deadShot` = Dead Shot, `nAttack` is shown as Long Shot). They only appear in the accessibility label, because the tool has no tooltips.
* **Tree names** (Sharp Shooter, Engineer, ...) exist only on the simulators and in the client art, not in the code. Taken from TailsTails; its Cat tree "Glambler" is spelled Gambler here (the game's item names say Gambler). Bat's trees read "ShadowCaller" and "DreamCaster" exactly as the site writes them; unverified.
* **Level caps.** Blog 95, TailsTails 100, **TailsTopia 110** (input 1-110, default 110), the tool 95, the game code has none (the Class C pool formula `clamp(floor(0.2*(lv-50)), 0, 12)` reaches its maximum of 12 at Lv 110). Lv 95 gives 9 Class C points, Lv 110 gives 12, so the cap changes what a build can hold. **Decided by the user 2026-10-12: BB 95 forever, TTO 95 for now, ToT 100** (the tool has a server gate and one entry per server in `SKILL_SIM_SERVERS`, so each server's cap and cell values are edited on their own; ToT's 100 gives 10 Class C points). The original comparison excluded EX skills. On 2026-10-13 the user requested ToT EX skills; the tool now includes ToT’s published EX slots with a separate pool (see below).

**C. Rule differences between the three**

| | Game code / the hub tool | Blog 2014 | TailsTails |
|---|---|---|---|
| Class C points | `floor((lv-50)/5)`, **max 12** | same, no cap | same, no cap |
| Learning | the tool: **one click learns every prerequisite** (ranks before it, required skills, enough points in the tree); the game: one skill at a time | one skill | one skill |
| Unlearning | the tool: the clicked rank and the ranks above it go (rank 1 = unlearned), only if nothing needs them | only the top rank | only the top rank, a pop-up explains a refusal |
| First skill of a tree | can go if the build stays legal | blocked while any other skill is learned | blocked while any other skill is learned |
| Changing level | a build that no longer fits is cleared (undoable) | always clears everything | keeps the build, remaining points can go negative (red) |
| Class C prerequisite | one named skill (`rSkill`) | every skill in the row | every skill in the row (same effect) |
| Class C level | exact level is enough | the click is refused at exactly the level, though the `+` shows (blog bug) | exact level is enough |
| Interface | no tooltips, no counts, no backdrop (user choice) | tooltips, per-class counts, backdrop | tooltips with a requirement checklist, per-class counts, backdrop |

**E. TailsTopia cross-check (read through the user's logged-in Chrome, 2026-10-12)**

TailsTopia's page carries, for all 12 classes, the same fields as the game's `SkillClass`: `cmd`, `rLv`, `rBn`, `rSkill`, `cMP`, `cSP`. All 1,159 cells of the game grids were compared in the page itself.

* **Level / points / prerequisite: 1,158 of 1,159 cells equal the game code, including all 20 cells of table A** (TailsTopia shows the game-code value, not the 2014 simulators' value, so the blog and TailsTails values are wrong or from an older server). Because the 12 `jump` / `empty` cells agree too, the decoder's fall-through reading is probably right, at least for TTO.
* **The one difference: Panda Heaven Breath (cmd 443).** Game code: `rSkill = 334` (explicit, `PandaSkill.cs:1314`, the same value as Spirit Fist at `:1291`) = Shadow Fist IV. TailsTopia: `344` = Sacred Sage Technique II. Likely a copy-paste typo in the client that the TTO server fixed. **The tool uses the game code (334); live-check item 13.**
* **SP / MP: all 1,159 cells equal the decoder values.** This settles section B for every class: Millionaire costs SP 50 / 75, Diamond Shot SP 20, and the Mole costs follow the game code (the blog and TailsTails cost columns were wrong). The costs of the 10 other classes, never compared before, are confirmed as well.
* **Rules:** same pools (normal points `clamp(lv, 0, 50) - 1`, Class C `clamp(floor(0.2 * (lv - 50)), 0, 12)`) and the same gates (level, points already in the skill's own tree, `rSkill`, the rank before it for ids below 400). A level that no longer fits prunes only the skills that stop being learnable (the hub tool clears the whole build instead; undoable).
* **Three extra Rabbit entries** (TailsTopia lists 101 Rabbit skills, the client 98): `mixshot` (cmd 452, Lv -1 / -1, needs 442), `thousandShot5` (453, Lv 120 / 7, needs 354) and `tradingWithWind5` (454, Lv 120 / 7, needs 444). Its own code gives them the "unknown" icon, so they have no client art; the tool ignores them (the user says there are no EX skills).
* **How far to trust it:** TailsTopia is a TTO-server tool. Its agreement with the client code means TTO still has the original values in these cells; it is not the original BB server, and it is not a mechanical copy of the client (it differs once). It confirms the code, it does not replace a live check on BB.

**D. Where each class is documented:** every class's table and its own differences are in `12t_reference/<class>-skill-reference.md`, section "Skill Tree Layout & Learn Requirements".

#### ToT EX skills (published simulator, 2026-10-13)

The user requested ToT EX support for all 12 classes. Source: [ToT library](https://talesoftails.net/library), its public class datasets at `/data/skill-simulator/<class>.json` (for example [Wolf](https://talesoftails.net/data/skill-simulator/wolf.json)), and [the simulator client](https://talesoftails.net/_next/static/chunks/673.2ecb414e00f7368e.js). This documents the published ToT simulator allocation rules, not BigBug engine formulas or live damage verification.

* **Separate EX pool:** 0 below Lv 95, 1 at Lv 95–99, 2 at Lv 100. Each EX skill costs one EX point; ordinary pools remain normal = 49 and C = 10 at Lv 100.
* **Five extra slots per class:** C row 6 columns 1–4 (hub cells 451–454), row 7 column 1 (461). Shared passive skills UpdamageMonter and DowndamageMonter unlock at Lv 95 and exclude each other. At most one of the three Lv 100 class choices (452–454) can be learned.
* **Requirements:** class choices require six already-learned ordinary C skills plus all explicit dependencies from `customReqs` and `exPrereqs`. EX spending never satisfies ordinary C tree-point requirements; ordinary C spending does not consume EX points. EX is single-click, without automatic prerequisite filling.
* **Availability:** Bat, Bison, Monkey, Panda, Penguin and Wolf publish three named class choices. Cat, Chameleon, Mole, Rabbit, Sheep and Whale still publish placeholder class choices. The hub leaves these unavailable while providing both shared passive choices for every class. Per-class names, levels and prerequisites are recorded in each class reference.
* **Refunds / reset:** validate all three pools, explicit prerequisites, exclusions and ordinary C counts. Clearing a tree prunes skills losing explicit dependencies or tree-point thresholds repeatedly until the remaining layout is valid. The hub’s existing undo restores server, class, level and EX selections together. BB and TTO do not receive these ToT-only entries.

### 3.7 Skill-window icon containers (verified 2026-10-13)

The skill window draws the original **iron frame for passive skills** and **wooden frame for every other mode**, then draws the transparent skill icon over the frame at the same 64 × 64 rectangle (`GameGui.cs:16993,16998-17018`). Assets are loaded from `GameGui/Icons/Common/ironFrame` and `GameGui/Icons/Common/woodenFrame` (`GameGui.cs:15618-15621`), exported as PNGs under `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/common/`.

```csharp
if (skill.mode == eSkillMode.passive)
    GUI.DrawTexture(rect, this.ToRcbXc2ylw); // ironFrame
else
    GUI.DrawTexture(rect, this.d2Gcbtu0WBe); // woodenFrame
GUI.DrawTexture(rect, iconButtonClass.image);
```

`eSkillMode.passive` is enum value 0 (`eSkillMode.cs:8`); `SkillClass` does not assign `mode` in its constructor (`SkillClass.cs:12-49`), so an unset decoded mode also uses the iron frame. The Skill Simulator follows this rule for all classes using decoded per-cell modes.

## 4. Hidden mechanics & special interactions

- **Luck touches everything actually reachable.** The `R = Random(0, ceil(0.2*LCK))` spread is added inside
  `dmgAdjust`, `defAdjust`, `agiAdjust`, `magAdjust`, `chaAdjust`, `talAdjust` — all confirmed live. `atkAdjust`
  also contains this same roll in its own body but is dead code (see §3.2), so its `R` spread never actually
  fires; ATK-scaling damage gets its LCK spread only from the shared `dmgAdjust`/`defAdjust` stages downstream,
  same as everything else. High LCK is a soft, universal stat buff (more upside on every roll) plus a direct
  `%`-chance boost through `lckAdjust`.
- **Global multiplier mods** (default 1.0, changed by statuses): `damageMod` (0–5 cap on outgoing damage),
  `koMod`, `hateMod`, `forceMod`. Reset to defaults at CharacterControl.cs:142+.
- **Holy interactions** — `holyArmor` and `holySword` multiply a value by `1000` then add `getStatusValue(...)`
  (CharacterControl.cs:11942 / 11966), i.e. special flat-ignoring damage/defense behavior for those buffs.
- **Stat buffs are flat deltas.** Applying `atkUp` does `deltaAtk(+num)`; on expiry `deltaAtk(-num)`
  (CharacterControl.cs:14691+). The same pattern covers `defUp/agiUp/vitUp/magUp/chaUp/talUp/lckUp` and the
  matching `*Down` debuffs. `num` is the status' strength/level, set by the skill that applied it.
- **Rectangle/trapezoid hit boxes — `Damage.FindRecTarget(pos, dir, BaseWidth, TopWidth, TargetRange, TargetHeight, layerMask)`**
  (verified 2026-09-23, `Damage.cs:1416-1600`). Corners are `(±BaseWidth, 0, 0)` and `(±TopWidth, 0, TargetRange)` in
  the caster's frame (`:1437-1446`, rotated by `dir` at `:1455-1464`), so the **full width is `2×BaseWidth` at the caster
  and `2×TopWidth` at the far end** — the width arguments are half-widths. A target counts when the point of its
  CharacterController bounds nearest the far-end centre lies inside that quad (angle-sum > 355°, `:1576-1590`; or its
  centre is within `extents.x` of the far-end centre, `:1541-1556`) **and** its capsule overlaps the vertical band
  `[pos.y − 0.5×TargetHeight, pos.y + TargetHeight]` (`:1567`, `:1576`). Cards should quote full width
  (`2×BaseWidth`) and `TargetHeight` as the height.
- **Circle hit areas — `Damage.FindAreaTarget(pos, TargetRange, TargetHeight, layerMask)`** (`Damage.cs:963`): an
  all-around circle of radius `TargetRange` centred on `pos` (debug outline drawn as an octagon at `TargetRange`), with
  the target's collider edge nearest `pos` (`transform.position + radius·dir`) tested against it on the flat (y ignored,
  `Damage.cs:1058-1085`); `TargetHeight` is the height: the target's capsule must overlap the vertical band
  `[pos.y − 0.5×TargetHeight, pos.y + TargetHeight]` (`Damage.cs:1108`, `:1124`), the same band as the box test above.
  Cards quote it as `รัศมี <TargetRange>m สูง <TargetHeight>m`.
- **Other range checks (verified 2026-10-07):** `Hate.findEnemies` / `Hate.findFriends` / `Hate.findClosestEnemy`
  compare `Math.vFlat(tPos − pos).sqrMagnitude` with `tRange²` (`Hate.cs:64`, `:192`, `:325`): a flat circle with **no
  height limit** (cards: `รัศมี Nm (ไม่จำกัดความสูง)`). `Damage.FindClosestTarget` (`Damage.cs:1976`) and inline
  `(a − b).sqrMagnitude < N²` checks (Ja / Phoenix / Gadina AI attack range, Wolf Impulse, Panda Aura Field, Penguin Mana
  Field) use the full 3D vector: a **sphere** (cards: `ทรงกลมรัศมี Nm`). Prefab trigger volumes take their shape from the
  collider (`SphereCollider` = sphere, e.g. Bat Mirage Orb radius 1, Bison Overlord radius 10 before the parent's scale).
- **A blast deep inside a large body misses (verified 2026-10-09):** the test point is the collider-circle point **toward** the blast, so the flat distance tested is `|d - colliderRadius|` (`d` = centre to blast), an absolute value. A blast at `d < colliderRadius - TargetRange` is farther from that point than one outside the body and is **not** a hit (a 15 m body and a 6 m blast: only `9 < d < 21` counts); an exactly zero offset has no direction (`Vector3.normalized` is zero), so the point collapses onto the centre and it hits. Seen on Falling Comets ([penguin-skill-reference.md](penguin-skill-reference.md)).
- **Target radius in area checks:** `FindAreaTarget` offsets the target point by `characterController.radius` (`Damage.cs:1095-1110`), the unscaled component value, so body-scale statuses (`enlarge`, `titanForm`, `enrage`, `reduce`) do not widen a character for hit tests. Hero radii (prefab): Cat / Monkey / Panda 0.2, Bat / Chameleon / Mole / Penguin / Rabbit / Sheep / Wolf 0.3, Bison 0.6, Whale `0.6 + 0.05 × (Super Size ranks + Mega Size)` set at spawn ([whale-skill-reference.md](whale-skill-reference.md) §4.12).
- **`rangeMod` (hit-area scale, verified 2026-10-02):** a per-character float, `1` by default (`CharacterControl.cs:154`, field `:29900`), raised on apply by `lunarEclipse` (+0.4 × sLv, `:34248`), `enrage` (+0.1, `:34738`), `titanForm` (+0.3 × sLv, `:35234`) and `enlarge` (+0.1 × sLv, `:37344`), lowered by `reduce` (−0.1 × sLv, `:37264`), each reversed in `removeStatus` (`:15150-16766`). Many skill hit boxes, radii and projectile lifetimes multiply their sizes by the caster's `rangeMod` (summons and bots use their own); others use plain numbers. Cards write a scaled size as `N×rangeMod m` (lifetimes as `N×rangeMod วินาที`) and leave unscaled sizes as `Nm`; a box can mix both (e.g. Whale Combo width `3×rangeMod m`, length `4m`).

### 4.1 Status effect catalog (StatusData.getStatusCode, StatusData.cs)
Each status maps to a sequential integer code. Grouped by function:

- **Control / disables:** `ko`, `lock`, `paralysis`, `petrify`, `fear`, `drunken`/`drunk`, `grab`, `swallow`,
  `gobble`, `provoke`, `disarm`, `artCancel`, `delayQi`, `sticky`, `heavy`, `needlePrison`, `maim`.
- **Damage-over-time / decay:** `burn`, `poison`, `venomShock`, `bleed`, `acid`, `rust`, `rustyDecay`, `puncture`,
  `hpSap/mpSap/spSap/koSap`, `hpDrain/mpDrain/spDrain/koDrain`, `heat`.
- **Shield-piercing state:** `cut` (Debuff + State; on apply removes magical shields of level ≤ its own, `CharacterControl.cs:36308`; see [cat-skill-reference.md](cat-skill-reference.md)).
- **Regen / restore:** `hpRegen`, `mpRegen`, `rejuvenate`, `remedy`, `salvation`, `lifeBoost`, `magicBoost`,
  `autoLife`, `lastHope`, `miracleDrop`.
- **Stat up/down:** `atkUp…lckUp`, `atkDown…lckDown` (see flat-delta note above).
- **Shields / defense:** `ironShield`, `diamondShield`, `perfectShield`, `bubbleShield`, `shield`, `noShield`,
  `hardenSkin`, `perfectArmor`, `armorBreak`, `powerBreak`, `ironShield`/`afterShock`.
- **Offense / buffs:** `valor`, `enrage`, `berserkerRush`, `furyTrance`, `overPower`, `ashura`, `titanForm`,
  `comboPlus`, `damagePlus`, `damageRoulette`, `boost`, `overPresence`, `fatalStrike`, `slayerMark`, `insight`,
  `awareness`, `fortune`, `pillage`, `honor`, `darkEdge`, `lunarEclipse`, `holySword/holyArmor/holyWolf`.
- **Immunity / special-state:** `hide`, `invisible`, `blend`, `immunity`, `noDamage`, `noKo`, `noHate`,
  `noForce`, `reflect`, `awake`, `mount`, `transform`, `enlarge`, `reduce`, `kingdomKnight`, `rapidTrance`,
  `eraseBoost`, `speedBoost`, `wash`, `tent`, `happy`, `sad`, `death`.

(Full enumerated codes live in StatusData.cs:63–1372; icons resolve from `GameGui/Icons/Status/<name>`.)

**`awareness` and `insight` statuses.** `awareness` (code 501) is Buff + Magical (`StatusData.cs:1031-1040`, `:5687`, `:6638`). On application, it immediately removes any existing `blend` and `invisible` from the recipient (`CharacterControl.cs:36204-36227`): the handler checks only whether each status level is greater than zero, with no comparison to `awareness.sLv`. It has no ongoing reapplication block; a source-wide search found no `hasStatus("awareness")` or `getStatusLv("awareness")` reader in the invisibility-application paths. `insight` (code 508) is Buff + State (`StatusData.cs:1108-1117`, `:4908`, `:6662`); it has no generic damage-reduction rule. Instead, individual traps and structures check `hasStatus("insight")` and skip their damage when it is present (e.g. `CactunTrap.cs:63-69`, `GuardTower.cs:1236`, `FlyingCacton.cs:218-229`, `Mole.cs:10636`). Those checks do not remove or decrement the status, so it protects against each covered hit until its timer expires (`CharacterControl.cs:19043-19085`, `:10658`). Cat Awareness applies the former to nearby targets and, with the Insight passive, grants the latter to the Cat for `chaAdjust(3)` seconds (`Cat.cs:8837`, `:8848-8854`; full skill mechanics in [cat-skill-reference.md](cat-skill-reference.md)).

**`poison`** (code 605, Debuff + Physical: `StatusData.cs:1174`, `:5457`, `:7406`): a pure damage-over-time with no stat change on apply (`CharacterControl.cs:36965`). Each tick is Effect Damage `RPC_AddEffectDamage(1, 10 × sLv − 1, ...)` from `StatusUpdate` (`:9208+`), so it cannot be dodged (§2.8) and gets only `hitMod`. **Tick interval: every 4 seconds**, from the user's in-game observation (2026-09-23), now traced (2026-10-19): the branch gates on `global::Math.mod(2 × kNtcObrGvdk, 8) == 0` (`:9208-9240`; `rust` the same at `:9241-9270`), i.e. one tick per window `[4k, 4k + 0.5)` of the target's `Time.time` (see Status tick cadence above), so ticks sit on a fixed 4 s grid of the target's clock and the first comes 0-4 s after the poison lands. `removeDot()` clears it (`:19664`).

**`doom`** (Debuff + Magical: `StatusData.cs:5963`, `:7562`). Applying or removing it has no mechanical effect: the apply site only spawns the Bat doom visual (`CharacterControl.cs:40487-40508`) and the `removeStatus` case is empty (`:18152`). The damage happens **only on expiry**, in the expired-status branch of `StatusUpdate` (`:10214` `else` of `statusClass.sTime > now`, `doom` case `:10364-10543`): if the status owner (`sID`, looked up in `PhotonClient.ActorNrList`) still exists and has `hp > 0`, the holder takes `RPC_AddEffectDamage(1, X, 0, 0, …, sID)` with X by level 1–7 = **330 / 450 / 666 / 999 / 1199 / 1300 / 1599**, then the status is removed. Level 8 and above matches no case, so it is removed with **no damage**; so is a Doom whose owner is dead or gone ("No Doom Owner Found"). Because the damage is Effect Damage it cannot be dodged and only `hitMod` applies (§2.9); `noDamage` blocks it (`:6122`). A cleanse or dispel before expiry removes it without the explosion. Sources: Bat Doom (contested duration, `Damage.getDebuff` with the CHA roles swapped), Cat Joker via Lucky Card (level 1, `Damage.getDebuff`), Cat Grand Casino Arcade (level = holder's current + 1, a flat 60 s, on the Cat's own side). Durations pass through `RPC_AddStatus`'s receiver-side rules, e.g. Wolf Fortitude `⌈0.75×sTime⌉` (`:13421-13434`).

**Status effects traced for the status popups (verified 2026-09-30).** `CharacterControl.cs` unless noted; "apply" = the `addStatus` switch, "direct" = the `AddDamage` coroutine status loop, "effect" = the `AddEffectDamage` status loop.
- **Shared support skills** (all cast from each class's `RPC_<name>`, e.g. `Wolf.cs:10120-10971`): each computes `N = clamp(getTypeLv(<class>), 0, 60)`, and if `N > own Lv` then `N = floor(0.5 × (N + Lv))`.
  - `seaAegis` (Whale, sLv 9, 12 s, sValue N): every hit is reduced by `2 × N`, floored at 0, on both the direct (`:31604`) and effect (`:6946`) paths.
  - `zephyrLore` (Chameleon, 12 s, sValue N): `deltaRunSpeed(0.08 × N)`, and every non-System debuff is removed on apply (`:41504-41560`).
  - `elementalBound` (Monkey level, 12 m radius, duration `floor(0.2 × N)`): every frame sets `moveSpeed = 0` and `myForce = 0` (`:2547`), so the target cannot move or be knocked back.
  - `astralShift` (Penguin, applied locally with `addStatus`, 12 s, sValue N): `deltaTal(N)` (`:41622`), plus an MP heal of `3 × N` at cast (`Wolf.cs:10756`). Unclassified in `StatusData.cs`.
  - `bloodCarnage` (Bat, 12 s, sValue N): every 2 s (`mod(2t, 4) == 2`) the holder takes `RPC_AddEffectDamage(182, floor(N))` and the caster gets `RPC_AddHeal(182, floor(0.5 × N))` (`:9869-9905`).
  - **Targets and areas (verified 2026-10-02):** `seaAegis`, `zephyrLore` and `psalmOfEnergy` are `instant`/`self`, `replenishment` is `target`/`ally`, `assassinate` is `target`/`enemy`, `mineWalker` is `instant`/`enemy` (`SkillData.cs:1740-1890`). Replenishment heals the targeted ally (`RPC_AddHeal(178, …)` on `tID`, `Wolf.cs:10313-10433`); Assassinate deals `clamp(40 − distance, 10, 40)`-scaled damage to the target (`Wolf.cs:38400`); Mine Walker hits `FindAreaTarget(caster, 4, 4)` (`:38750`), Obsidian Fang `FindAreaTarget(caster, 24, 4)` (`:38123`), Stunning Ground `FindAreaTarget(caster, 6, 4)` and Elemental Bound `FindAreaTarget(caster, 12, 4)` (e.g. `Penguin.cs:11985`, `:12713`). Target support skills have no distance gate, so the 40 m target lock applies.
  - **Amounts (verified 2026-10-03, `Wolf.cs`; identical in every class):** Replenishment heals `floor(N% ×` max HP / MP / SP / KO`)` once (`:10413`). Psalm of Energy gives the caster `N` SP and every other own-layer character within 12 m `floor(0.5 × N)` SP (`:9920-9977`, skips the caster). Stunning Ground: one `hit(172, t, N, KO N)` on every enemy within 6 m (`:9810`). Obsidian Fang: one hit per enemy within 24 m, at most 6; the k-th attempted target (k = 0..5) takes `(int)(0.5 × N × (5 + k))`, and k advances even when the hit is dodged (`:37886-37968`). Assassinate: `(int)min(0.5 × N × clamp(40 − distance, 10, 40), 0.5 × target max HP)` (`:38400-38417`). Mine Walker: 24 pulses 0.5 s apart, re-centred on the caster each pulse, `floor(0.04 × N × (40 − distance²))`, KO 1, enemies within 4 m (`:38750-38826`). Divine Channel: caster `8 × N` HP, every other own-layer character within 12 m `4 × N` HP, once (`:39086-39152`). Astral Shift heals `3 × N` MP once.
- **Shields** (direct path, `:30996-31510`): `bubbleShield` absorbs half of each hit from its sValue pool (`dmg −= 0.5 × dmg` while the pool covers it; otherwise `dmg −= pool` and the status is removed); `repel` subtracts `50 × sLv` per hit; `reverse` turns the hit into `nDamage = -1` and heals the holder `0.5 × sLv × damage` (`RPC_AddHeal(352 + sLv, …)`). Applying `repel` removes `reverse` and vice versa (`:39736`, `:39763`). `salvation`: the attacker's `hit()` exits early when the target has it (`:3067`), and `RPC_AddDamage` zeroes damage and KO (`:4808`).
- **`burn`**: every second (`mod(2t, 2) == 0`), `RPC_AddEffectDamage(220 + sLv, 4 × sLv)` (`:9293`).
- **`overPresence`**: `moveMod −= 0.1 × sLv` on apply (`:35951`).
- **`artCancel`**: on apply, an attacking holder is put back to `standby` with the message "Your action has been cancelled!", and `isAdd = false`, so the status is never kept (`:34117-34130`).
- **`redFlag` / `blueFlag`**: applied for 3 s by a consumable in each hero's `RPC_useItem` (e.g. `Bison.cs:36746`, `:38028`); no client code reads either status.
- **`mimic`**: placed on the copy; if its owner (`sID`) is the local player, `Game.mPlayer` switches to the copy, so the Bat controls it (`:40851-40900`).
- **Monkey** (details in [monkey-skill-reference.md](monkey-skill-reference.md)): the five souls apply `deltaAtk/Tal/Def/Vit(10 × sLv)` (Phoenix/Ja/Gadina/Buiten) and `deltaAtk + deltaDef(8 × sLv)` for Gaos (`:38149-38289`); `ignite` gives `hitMod += 0.1 × sLv` (`:37899`); `fireAvatar` gives `+100` AGI/TAL and `earthForm` `+100` ATK/DEF, and both set `Race = Elementals` and remove `invisible` (`:38328`, `:38443`); `buiten` gives `deltaDef(sValue)` (`:38048`) and redirects damage (`:4925-4990`).

**Weapon effects and their rolls (verified 2026-09-30).** Every weapon check in the decompiled heroes falls into one of these groups:
- **On-hit proc list:** each hero's `onNormalAttackHit` coroutine switches on `mChar.weapon` (e.g. `Wolf.cs:46424+`; same table in all 12 heroes and `Bat_illusion`). Effects: `w_*3` happy3 (`lckAdjust(12)`), `w_*14` charm1 on players (`lckAdjust(14)`), `w_*15` a per-class status Lv1 (`lckAdjust(6)`), `w_*19` self heal 300 HP (`lckAdjust(3)`), `w_*39` a per-class status (`lckAdjust(12)`), `w_*49` heavy2 (`lckAdjust(6)`), `w_*69` full HP/MP/KO restore (`lckAdjust(1)`), and `w_*46` / `w_*56` / `w_*66` add 12 to the plague / MP-drain / HP-drain pool, rolled afterwards as `Random.Range(0,100) < lckAdjust(pool)`. Chameleon multiplies the base chance of `w_*14`/`15`/`39`/`49`/`69` and the three pools by its `doubleEffect` factor (2 with Double Effect #431, `Chameleon.cs:47347`), and doubles the charm/sticky/burn/heavy/plague durations; its `happy3`, BD Bow heal and Demonic rolls are not multiplied. **Exception: `w_*79` (the Demonic weapon of each class) rolls a flat `Random.Range(0,100) < 13` with no `lckAdjust` and deals `RPC_AddEffectDamage(1, 666)`.**
- **Gear crit (`w_*43`, `w_*44`, `w_*58`, plus armor/accessory 43/44/58):** every hero's `getCritPlus` sums the bonuses and crits unless `Random.Range(0,100) >= lckAdjust(sum)` (e.g. `Bison.cs:13801-13947`, `Bat_illusionFire.cs:549`); the Chameleon arrow has its own copy with `w_chm43/44/48` (`Chameleon_nAttack.cs:523-663`, `lckAdjust(num2)`).
- **`w_*59` class weapons:** deterministic, no roll: raw damage `floor(0.75 ×)` plus a fixed side effect (Bison pull, Sheep ally heal, Penguin projectile reshape, etc.).
- **Weapon categories and cosmetics:** Bison `isHammer()`, Rabbit `isShotgun()`, `w_chm25` arrow model, `w_chm15` / `w_mol25` sounds, and the full-set emote poses (`w_*5/25/35/45/46/56/58/65/66` + matching armor/accessory) have no roll.

### 4.2 Status classification & cleanse system (StatusData.cs)
Status effects are queried at runtime via static boolean predicates in `StatusData.cs` that govern cleanse eligibility, dispel interactions, and UI categorization:

| Category Query | Purpose / Engine Behavior |
|----------------|---------------------------|
| **`isDebuffStatus(sType)`** | Evaluates whether the effect is negative. Target-contested via `Damage.getDebuff` (§2.4). |
| **`isBuffStatus(sType)`** | Evaluates whether the effect is positive. Extended via caster CHA (`chaAdjust`). |
| **`isMagicalStatus(sType)`** | Marks status as magical in nature. Eligible for magical dispels (e.g. Penguin's `Dispell`, Bat's `Dissolute`). |
| **`isPhysicalStatus(sType)`** | Marks status as physical/biological in nature (e.g. `amplifyDamage`, `poison`, `bleed`, `blind`). Removed by physical cures/cleanses. |
| **`isStateStatus(sType)`** | Structural character states (e.g. `transform`, `mount`, `guardianOfTheNight`, `berserkerRush`). |
| **`isLockStatus(sType)`** | Total action disables / locks. |
| **`isShieldStatus(sType)`** | Active protective shields absorbing incoming damage. |
| **`isSystemStatus(sType)`** | Internal engine statuses that cannot be modified or cleared by player abilities. |

**`hide` (Buff, System; verified 2026-10-16).** A hidden character takes no damage at all: `CharacterControl.hit` returns 0 when the target has `hide` (`CharacterControl.cs:3046`, the same branch as `noDamage`), and Effect Damage skips it (`:6115`, `:6505`, `:6589`); it cannot be clicked as a target (`GameGui.cs:3877`, with `invisible` / `blend`) and its name label is hidden (`CharacterControl.cs:327`). Applied by Rabbit Bounce (`Rabbit.cs:21068`, `4 x sLv + 1` s), Panda Raijin Ken's leap (`Panda.cs:41732`, 1 s), and internally to the caster's own body while it controls a double or a robot: Bat Mimic (`Bat.cs:39312`) and Mole King Kaiser (`Mole.cs:36135`).

**Debuffs that are also State (verified 2026-09-27).** `isDebuffStatus ∩ isStateStatus` (`StatusData.cs:7175`, `:4809`, junk predicates evaluated) = `artCancel`, `blackServant`, `bloodCarnage`, `blueFlag`, `cut`, `darkStalker`, `elementalBound`, `grab`, `overPresence`, `petrify`, `puncture`, `redFlag`. Any resist that filters `isDebuffStatus && !isStateStatus` (e.g. Panda Resistance `CharacterControl.cs:13512-13580`, the equipment debuff-resist branch `:13672`) cannot block these 12.

**`lock`, `ko`, `death` statuses (verified 2026-09-27).** All three are Debuff + System only.
- `lock`: its only reader is `ApplyMovement()` (`CharacterControl.cs:2278-2297`, junk predicates evaluated): each frame `moveSpeed = 0`, `myForce.x = 0`, `myForce.z = 0` (vertical force kept). No other `"lock"` read exists in the source, so attacking and casting are unaffected. It is **not** in `isLockStatus` / `removeLockStatus` (`:19456`: groundLock, needlePrison, sticky, frost, lightBind), so Backflip-style unlocks do not remove it. Appliers: Cat Delta Strike (`Cat.cs:37186, 37265, 37430`, Lv1 3s), Panda Rising Dragons (`Panda.cs:29625`, Lv1 2s), Ranger Robot (`RangerRobot.cs:3112`, `RangerRobotMount.cs:3175`, Lv5 6s).
- `ko`: apply handler `ko = clamp(ko − 5 × sLv, 0, mko)`, not kept in the status list (`:33670`). Only applier: Panda weapon Boxing Grove `w_pnd15`, `lckAdjust(6)` per normal-attack hit, Lv1 (−5 KO) (`Panda.cs:51265`).
- `death`: apply handler `hp = 0` (`:35416`); Immunity explicitly skips it (`:12665`). Appliers: Panda Death Blow (`Panda.cs:35211`, `lckAdjust(20 × sLv) > Random(0, target hp)`, target standing/running/emoting) and the Fire Arena map (`M981_FireArena.cs:479`).

**Target-skill range = the 40 m target lock (verified 2026-09-27).** `eSkillMode.target` skills send `doSkill` with the currently selected `targetObject` (`GameGui.cs:37857-37880`) and have no generic distance check there; a class may add its own gate (e.g. Chameleon Slayer `< 24 + 4×FarReach`, `Chameleon.cs:7571`). The selection itself is dropped every frame once the horizontal (XZ) distance from the camera target (the player) exceeds 40 m (`sqrMagnitude > 1600`, `GameGui.cs:4339`, `:4350`), so a target skill without its own gate reaches **40 m**. Tab-cycling only picks targets within 36 m (`cycleEnemyTarget(…, 1296)`, `:2168`, `:2176`). Mouse selection (`RenderTargetArea`, `:4137-4290`) is a `Physics.Raycast` from the **camera** through the cursor: 30 m long while hovering, **40 m** on the frame the right button goes down (`GetMouseButtonDown(1)` → `num2 = 40`, layer mask `~6`, `:4160-4300`); right-click locks that hit (`GetKeyDown("mouse 1")` → `targetObject`, `:1880-1890`), left-click release on a hovered target also selects it (`:1782`). Because the ray starts at the camera, the reach measured from the character is somewhat under 40 m; once locked, the 40 m-from-player drop rule above decides how long it stays. **Camera offset (`PlayerCameraControl.cs`):** `distance` starts at 6 with a pending `zoom` of 5 (constructor `:24-33`), applied on the first update and clamped to **2-12** (`:360-381`), so a fresh camera sits at 11 (not saved to PlayerPrefs). The mouse wheel sets `zoom = clamp(GetAxis("Mouse ScrollWheel"), -0.3, 0.3)` each frame (`GameGui.cs:2145`) and the axis sensitivity is 1000 (`ProjectSettings/InputManager.asset:257`), so every wheel notch saturates to **±0.3**: from 11 the reachable distances are 2.0, 2.3 … 11.9 and 12 — **35 zoom positions**. Pitch = `4 × distance − 4`° (`− 16` with the Low Angle option, `:392-395`, `:436`, `:482`). `ApplyPositionDamping` (`:627-640`) places the camera `(distance + max(0, height − 1.5))` from a pivot at the character's bounds centre + `0.2 × height` up, along that pitch: horizontal `cos(pitch) × d` behind, `sin(pitch) × d` above. For a character up to 1.5 m tall: d 2 → 2.0 m behind / 0.1 m up; d 6 → 5.6 / 2.1; **d 11 (default) → 8.4 m behind / 7.1 m up**; d 12 → 8.6 / 8.3. Right-click reach on flat ground (40 m ray, pivot ≈ 0.5 m up): straight ahead ≈ 38 / 34 / **31** / 30 m at d 2 / 6 / 11 / 12; to the side ≈ 38-40 m. Vertical FOV = `clamp(45 + camera-to-pivot distance + 5 × max(0, height − 1.5), 15, 90)` (`:672`), about 56° at d 11, so the top screen edge looks `pitch − FOV/2` below horizontal: at the normal angle and d 11 / 12 the screen only shows the ground out to ≈ 26 / 22 m ahead (pivot 0.85 m, target centre 0.6 m, flat ground), which caps click-targeting straight ahead below the 40 m ray. **Low Angle** (pitch −12°) keeps the horizon on screen at every zoom, so its straight-ahead reach is the ray limit, ≈ 30 / 29 m at d 11 / 12 (the camera sits ~1.3-1.5 m further back, costing ~1 m of ray reach). At d ≤ 6 both angles see the horizon and reach ≈ 34-38 m. Caveat: these are the script's constructor defaults; a scene-serialized `distance`/`zoom` on the camera object would override them, and the ripped scene YAML does not keep those values. Example: Cat Swift Pace has no gate of its own (`Cat.cs:6528-6600`).

**Which reach shape a lock or projectile gets (decided 2026-10-14, user).** The 40 m lock is a **flat circle** (the selection is dropped by the horizontal distance, `GameGui.cs:4339`), so a lock-only skill is drawn as a faint ground **ring** `r 40`, never a line or a sphere; a gate that uses `vFlat` (Panda Raijin Ken 35 m, `GameGui.cs:11285`) is a ring too, and one that subtracts raw positions (Wolf Art Breaker 30 m `Wolf.cs:33983`, Grand Cross command range 30 m `:5700-5735`) is a true 3D distance, drawn as a faint **sphere**. A `Physics.Raycast` projectile (Cat daggers and cards, most Rabbit and Chameleon shots) has no width: it stays a `line`. A projectile that is a trigger collider (`OnTriggerEnter`, e.g. `Monkey_fireBall.cs:91`) hits what its collider touches, so its corridor is the collider's size **plus the target's own capsule** (a Wolf / Cat capsule radius is 0.2 m, Panda 0.2 m). Collider sizes read from the ripped effect prefabs (`BoxCollider.m_Size` is the full size, `SphereCollider.m_Radius` the radius, all `m_IsTrigger`):

| Projectile prefab | Collider | Corridor (collider + target) |
|---|---|---|
| Bat Illusion Fire / Combo, Penguin Combo / Spread Shot / Mana Missile | sphere r 0.3-0.4 | about 1.0-1.2 m wide |
| Sheep Combo / Homing Light r 0.3, Charge Attack r 0.5 | sphere | 1.0-1.4 m |
| Mole rockets and shells (Missile, War Missile, Bazooka, Mortar, Napalm, Combo) | box 0.2-0.25 x 0.2-0.25 x 0.5 | about 0.7 m |
| Chameleon arrows (Combo, Clear Arrow) | box 0.3 x 0.3 x 1.5 | about 0.7 m |
| Cat Support Fire shell | box 0.25 x 0.25 x 0.5 | about 0.7 m |
| Whale Javelin | box 0.25 x 0.25 x 3 | about 0.7 m |
| Bat Mirage Orb, Whale Flying Shield | sphere r 1 | about 2.4 m |
| Whale Homing Shield | sphere r 0.5 | about 1.4 m |

So almost every projectile's corridor is under 1.2 m wide, and a tube that thin is hard to tell from a line at the preview's zoom. Rule: keep the `line` for raycasts and for a collider under about 0.5 m radius; use the `tube` shape (radius = collider radius, `l` = the travel range) only for the wide ones (Mirage Orb, Flying Shield), when that class is done. Area triggers (Mole mines r 4, Flame Carnival r 4, Penguin Cosmic Friday r 3, Whale Over Presence r 6, Bison Overlord r 10) are `FindAreaTarget`-style areas, not corridors.

**Perfect Shield / Perfect Armor come from merging (verified 2026-09-27).** No skill applies `perfectShield` or `perfectArmor` directly. In `RPC_AddStatus` (`CharacterControl.cs:11975-12040`, no class gate): an incoming `ironShield` on a character that already has `diamondShield`, or an incoming `diamondShield` on one that already has `ironShield`, is turned into `perfectArmor` if **the receiver** `hasSkill(443)`, otherwise into `perfectShield`. The only appliers of `ironShield` / `diamondShield` are Bison's own self-casts (`Bison.cs:27708`, `:28295`, both on `self.mChar`), and Bison's #443 is **Mythril Skin**, so in practice only a Bison with Mythril Skin that stacks Iron Shield and Diamond Shield gets Perfect Armor. Non-Bisons can never hold any of the four: `RPC_AddStatus` rejects `ironShield`, `diamondShield`, `perfectShield`, `perfectArmor` (and `titanForm`) when `this.Type != "Bison"` (`CharacterControl.cs:12184-12250`). A weaker shield cannot replace a stronger one: an incoming `ironShield`/`diamondShield` is rejected while `perfectShield` or `perfectArmor` is up, and `perfectShield` while `perfectArmor` is up (`:11085-11155`); applying a Perfect status removes the other three (`:35116-35161`).
- **Effects, in the Bison block of `RPC_AddDamage` (`CharacterControl.cs:4011`, `:4085-4290`):** `perfectArmor` → `nDamage = 0` and `nKo = 0` from every hit; `perfectShield` → `nDamage = 0` only (**KO still lands**); both regardless of attacker distance. Otherwise `ironShield` → damage and KO 0 only from attackers within 4 m (`sqrMagnitude < 16`, 9 m with #433), and only if the Bison has passive #331; `diamondShield` → damage and KO 0 only from attackers farther than 12 m (`> 144`, 9 m with #443 Mythril Skin), and only with passive #341. So Perfect Shield = Iron + Diamond coverage at every range but without KO immunity; Mythril Skin upgrades the merge to Perfect Armor, which also blocks KO. All 9 shield statuses are Buff + Magical + Shield.

**Drain / Sap statuses (verified 2026-09-27).** `hpDrain`, `hpSap`, `mpDrain`, `mpSap`, `spDrain`, `spSap`, `koDrain`, `koSap` are all classified **Debuff + System** only (not Physical/Magical/State). Their effect lives in the `RPC_AddStatus` apply switch (`CharacterControl.cs:33416-33670`) and happens **once, at application**; no `StatusUpdate` tick reads them. `sValue` is the amount:
- `hpSap`: `n = clamp(floor(hitMod × sValue), 0, hp)` → `RPC_AddEffectDamage(66, n, …)` on the target (`:33416`); not added to the status list.
- `hpDrain`: same `n` (only while `hp > 0`), sent as `RPC_AddEffectDamage(66, n)` on the target **and** `RPC_AddHeal(66, n)` on the caster (`sOwnerChar`, required non-null) (`:33488-33540`).
- `mpSap` / `spSap` / `koSap`: `mp`/`sp`/`ko -= sValue`, clamped (SP to 0-100) (`:33443-33485`); nothing returned.
- `mpDrain` / `spDrain` / `koDrain`: take `min(sValue, current)` from the target and `RPC_AddHeal` the same amount of MP / SP / KO to the caster (`:33543-33670`).
- Being System statuses, the equipment debuff-resist roll skips them, but Panda Resistance does not (see [panda-skill-reference.md](panda-skill-reference.md)). Trinkets add their own `lckAdjust(24)` block: `t_mal56`/`t_fem56` vs `mpSap`/`mpDrain`/`manaBurn`, `t_mal66`/`t_fem66` vs `hpSap`/`hpDrain` (`:13919-13952` → `:14225-14280`).
- **`t_mal66` Calmar Wing / `t_fem66` Nageoire Wing also block lifesteal hits** (`TrinketData.cs:3892-3898`, `:4312-4318`; verified 2026-09-30). In `CharacterControl.hit()`, when the target wears either trinket (`:3430-3445`), the target rolls `Random.Range(0,100) < target.lckAdjust(24)` (`:3573`). On success, a **Wolf** attacker with `actionCode` 210-219 (Crusader `hit(210 + sLv, …)`, `Wolf.cs:21207`; Armor Break, `Wolf.cs:22696`) or a **Bison** attacker with the `berserkerRush` status and `actionCode <= 9` (Combo stages) gets `return 0` (`:3579-3633`): no `RPC_AddDamage` is sent, so the hit deals no damage, KO or hate, and the stage's Berserker Rush heal (which needs a hit return > 0) does not fire. Any other attacker falls through to the normal path (`IL_1B8`, `:3446`).
- Appliers: `hpDrain`/`mpDrain` from every class file (e.g. `Bat.cs:22152`), `spDrain` from `Bat.cs`, `mpSap` from `ManaVortex.cs`/`ReefBug.cs`; no `RPC_AddStatus` caller for `hpSap`, `spSap`, `koDrain`, `koSap` in the decompile.

> **Server Difference (TTO, user-reported live change 2026-09-28, not in the decompiled client):** on Tailstopia Online the Poseidon Bow (+12%) and Poseidon Helmet (+8%) `hpDrain` proc chance no longer goes through `lckAdjust`. The full set is a flat 20%, or 40% with Chameleon Double Effect (which doubles the base). Other gear procs are not covered by this report. The Bible's Character Hit Mod sim models this with its BB/TTO server toggle. **Extended 2026-10-25 (user report):** the Frozen series (Frozen Bow / Frozen Crown, MP Drain) and the Mummy series (Mummy Bow / Mummy Bandana, plague) and their helmet counterparts lose the `lckAdjust` on TTO too. No flat percentages are known for them yet. The Bible's server balance page lists the three series under Common.

**Equipment debuff resist (verified 2026-09-27, `CharacterControl.cs:13588-13660` + labels `:14315-14333`, all classes).** Inside `RPC_AddStatus`, after the class-specific blocks: `num3 = 0`; `getInteger(weapon)` 47 or 48 → +6; `getInteger(armor)` 47 or 48 → +6; `getInteger(accessory)` 47 or 48 → +4; `getInteger(accessory)` 19 → +3. If `num3 > 0` and `isDebuffStatus && !isStateStatus && !isSystemStatus`, one roll `Random.Range(0, 100) < lckAdjust(num3)` rejects the status (`RPC_AddDamage(-83)` + `break`). Item 47/48 = each class's bug-themed "prevention of negative statuses" set (e.g. Panda Worm Knuckle/Suit/Cap, Wolf scorpion hat, Bison beetle helmet); accessory 19 = the class "Helps protect against abnormal status" hats (e.g. Panda mushroom hat `c_pnd19`). `Stringf.getInteger`'s body is not in the decompile (the firstpass `Stringf.cs` is an empty stub), so whether it matches only the trailing number (and so whether e.g. `c_all19` also counts) is inferred, not verified. The same function then has per-status accessory resists (`ice`: `c_all21`/`c_all22`, `snowMan`: `c_all29`, `sleep`: `c_mal37`/`c_fem37`, `corruption`: `c_all27`, …; the ice/snowMan/sleep ones roll `lckAdjust(12)`, `:13660+`).

**Robots refuse a fixed list of statuses (verified 2026-10-09, `CharacterControl.cs:10833-10927`, inside `RPC_AddStatus`).** When `Race == eRace.Robots`, a status named `paralysis`, `immunity`, `poison`, `boost`, `heat`, `autoLife`, `sleep`, `charm`, `mindControl`, `nightmare` or `plague` is never applied: the code falls out of the nested "not this name" tests to `RPC_AddDamage(-84, 0, 0, 0, …, ActorNr)` (the IMMUNE pseudo-hit) and `continue`s (`:10922`). Every other name goes on to the `mImmuneList` check (`:10950`). A non-Robots target refuses `rust` the same way (`:10936-10947`), so `rust` is the Robots-only counterpart of `poison`. The refusal sits in the receiver, so it does not matter whether the applying skill checks the race itself (Poison Arrow does, Poison Volley does not: Robots take the Volley hit but never get `poison`).

**The `damagePlus` status (next-hit raw-damage bonus).** `damagePlus` is both **Magical** and a **Buff** (`StatusData.cs:5421`, `:6644`). During the generic `CharacterControl.hit()` pipeline, an active stack adds `10 × status.sLv` to `nDamage`, then subtracts 1 from `status.sValue`; the status is removed when that value reaches 0 (`CharacterControl.cs:3447-3474`). It therefore applies after any earlier raw-damage transformation at the hit site and before the ordinary attacker `dmgAdjust` step. **Cat-only in practice:** the only `RPC_AddStatus("damagePlus", …)` in the whole source is Cat's charge attack (`$RPC_cAttack1$21702`, `Cat.cs:20031`): level = charge level, `sValue` (charges) = `1 + (hasSkill(411) ? 1 : 0)`. Since it lives in `hit()`, direct `RPC_AddDamage` callers and Effect Damage neither get the bonus nor consume a charge (§2.9).

**The `dispell` status (magic-status purge + short immunity).** `StatusData.cs:5813/6848/7478` list `dispell` in `isMagicalStatus`, `isBuffStatus` and `isDebuffStatus`. Its `sLv` is the **purge tier**, applied with `sTime = 1` (1 second):
- **On apply** (`CharacterControl.cs:38485`, `case "dispell"`): every active status with `isMagical()` and `status.sLv <= dispell.sLv` is collected into `mDispellList` and removed via `removeStatus` (`:38508-38560`).
- **While active** (`CharacterControl.cs:12977`, inside `RPC_AddStatus`): an incoming magical status with `sLv <= getStatusLv("dispell")` is rejected (`RPC_AddDamage(-83, ...)` fires as the feedback) -- `dissolute` takes a separate branch and is exempt (`:12967`).
- Sources: Penguin `Dispell` -> level `2×sLv (+1 with parallelShift5)` (`Penguin.cs:22252`); Fay / IceGuardian bosses apply level 5 (`Fay.cs:2495`, `IceGuardian.cs:2494`).

**The `dissolute` status (buff purge + buff block).** `dissolute` is `isMagicalStatus` + `isDebuffStatus` (`StatusData.cs:5939`, `:7532`), not a buff. With `d` = its `sLv`:
- **Apply-time purge** (`CharacterControl.cs:40160`): removes every status with `isBuff()`, `!isSystem()` and `status.sLv <= d+2`. **State buffs are removed** (no State check); **System buffs are immune** (e.g. `hpRegen`, `mpRegen`, `reflect`, `noForce`, `awake`).
- **Block while active** (`CharacterControl.cs:13081-13095`, `RPC_AddStatus`): rejects incoming `isBuffStatus && !isStateStatus` with `sLv <= d+2` (`RPC_AddDamage(-83)` feedback). **State buffs pass; System buffs are blocked** (no `isSystemStatus` check in this branch -- the two `isSystemStatus` calls in `RPC_AddStatus`, `:12677` and `:13672`, belong to the `immunity` and debuff-LCK-resist branches).
- **Exempt from the Dispell block:** `RPC_AddStatus` skips the `dispell`/`clear`/`cleanse` checks for `dissolute` (`:12968`), so it always lands.
- **Dispell vs Dissolute:** Dissolute strips an existing `dispell` (level `L`) when `L <= d+2`. Dispell can only land (and then purge Dissolute) when `L >= d+3`, since `dispell` is a non-State, non-System buff blocked by the rule above.
- Bat sources: level = rank `+1` (Revised Art) `+1` (target has `shame`), clamped to 4 with Shadow Mastery (`Bat.cs:26111-26145`); bosses apply 4-6.



### 4.2.1 Re-applying an already-active status — level merge rule (`CharacterControl.cs:14017-14160`, inside `RPC_AddStatus`)

Found empirically (2026-09-20): two Rabbits with Medical Enhancement 3 (level cap 4) shot the same target and it reached `heat5`, above either caster's cap, after which further shots no longer refreshed the duration. This is the **generic** same-`sType` merge in `RPC_AddStatus`, not Rabbit code. For the target's existing entry with the same `sType`, compared with the incoming `(sLv, sID)` (`sID` = the caster's `ActorNr`):

| Existing vs incoming | Result | Source |
|---|---|---|
| `existing.sLv == sLv` **and** `existing.sID == sID` (same caster) | `sTime = max(existing remaining, sTime)`, i.e. the duration refreshes to whichever is longer; the level stays. A few types also tweak `sValue` (`comboPlus`, `hardenSkin`, `damagePlus`, default `max`). | `:14023-14035`, `:14056-14103` |
| `existing.sLv == sLv` **and** `existing.sID != sID` (different caster) | **`sLv++`**: the level is bumped by 1 above the incoming level, then applied. Skipped only for `hpDrain` / `mpDrain` / `spDrain`. | `:14115-14143` (`else { ... sLv++; }`) |
| `existing.sLv > sLv` | **`return`**: the new application is dropped entirely (no level change, no duration refresh). | `:14153-14159` |
| `existing.sLv < sLv` | falls through to `addStatus(sType, sLv, sTime, sValue, sID)`, replacing the lower-level entry. | `:14182` |

**Consequences (Rabbit Heat Shot worked example).** A Rabbit's own cast computes `heatLv = min(current + 1, 1 + medEnhLv)` (`Rabbit.cs:28375-28399`), so a single Rabbit never exceeds its cap and its recasts at the cap refresh the duration (same caster, equal level). A **second** caster whose cap equals the current level hits the different-caster branch and pushes the level to `cap + 1` (heat4 → **heat5**). Once the target is above every caster's cap, every later shot has `existing.sLv > sLv` and is silently dropped, so the duration stops refreshing until the status expires. The caster's own `RPC_AddHeal` SP gain (`Rabbit.cs:28405`) still fires because it is a separate call. Whether `sLv++` is intended for the level-capped Rabbit shots is unknown; the rule itself is generic to all statuses. Other sources of `heat` (`Bear.cs:1555` applies `heat` level 4 for `chaAdjust(12)`; `GameGui.cs:33430` applies level 2) hit the same rule but were not tested. **`addStatus` swap (traced 2026-09-20):** the `$addStatus$35621` coroutine (`CharacterControl.cs:32343+`) first calls `removeStatus(sType)` (`:32773`). `removeStatus` (`:14452`) rebuilds `mStatusList` without the entry of that `sType` (`:14469-14533`), reads the **removed entry's** `sLv` (`:14536`) and dispatches the per-status reverse — for `heat`, `deltaTal(-10 * sLv)` (`:16830-16834`). It then pushes a fresh `statusClass` (`sLv`, `sTime = Time.time + sTime`, `sID`; `:32709-32744`) and applies the new level's effect — for `heat`, `deltaTal(10 * sLv)` (`:37506`). So the old level's TAL is reversed before the new level's is applied (heat4 → heat5 nets `+50` TAL, and expiry reverses `-50`); no stat leak. The new entry's `sTime` is the incoming duration only: the `max(remaining, sTime)` in the table above is applied solely for same-level same-caster refreshes, so a cross-caster bump or a higher-level replacement **replaces** the remaining time (it can shorten it if the new caster's `chaAdjust` duration is lower). Expiry is checked per list entry in `StatusUpdate` (`:8659-8759`, comparing `statusClass.sTime`), so a replaced entry's old timer no longer exists; the removal-on-expiry call itself was not read.

### 4.2.2 KO gauge, knock-down and the actionState locks (petrify, nightmare) (verified 2026-10-08)

- **The gauge:** `ko` starts at `mko`; a hit's KO is added to `myKo` (`CharacterControl.cs:31663-31669`) and `ApplyKo()` subtracts it each frame (`:2223-2226`). The **knock-down** is triggered by the hero class script, not by `CharacterControl`: its `Update` runs `RPC_ko` when `hp > 0`, `ko <= 0` and `actionState` is neither `"ko"` nor `"dead"` (`Rabbit.cs:398-455`, same code in `Bat.cs:441`, `Chameleon.cs:474`; the other classes were not read). `RPC_ko` sets `ko = 0`, `actionState = "ko"`, `moveSpeed = 0` and plays the fall; after the wait it plays `getUp`, and **only if `actionState` is still `"ko"`** (checked at both steps, `Rabbit.cs:48332-48367`) sets `actionState = "standby"` and refills `ko = mko`.
- **KO zeroed on incoming hits:** the status loop of the damage coroutine sets `nKo = 0` for `petrify` (`:31062-31068`, and the Effect Damage path `:6691-6697`), `snowMan` / `snowBall` / `iceShield` while their pool holds (`:31192-31407`), `noKo`, `cosmicRift` / `cosmicFriday`, `nemesisLarva`. `nightmare` is **not** in that list, so only a petrified (or snow / noKo) target is immune to KO damage; a nightmared one is not. The Nightmare tick itself carries KO 0 (`RPC_AddDamage(242 + sLv, 22 x sLv + 22, 0, ...)`, `:9666`).
- **A lock status on an already knocked-down target:** `petrify` (`:37535-37566`) and `nightmare` (`:40405-40408`) apply `actionState = "petrify"` / `"nightmare"` and `moveSpeed = 0` **once**, and `RPC_AddStatus` never refuses them for a `"ko"` target (its only `actionState` test is `"attack"`, `:13447`). On a KO'd target the new `actionState` overwrites `"ko"`, so the stand-up steps of `RPC_ko` (which only act while `actionState` is still `"ko"`) are skipped; **no second knock-down animation plays** (user, live 2026-10-08). In game the target then **moves and acts normally under a petrify / nightmare that is still on** (stone shader and DEF -40 / -60, or the Nightmare tick). The code path that frees the movement was **not traced**: the class scripts take movement input only in `"standby"` / `"run"` (e.g. `Rabbit.cs:218-224`, `:644-650`) and removal only restores `"standby"` if `actionState` is still the status's own (`:16870`, `:18122`). Treat the live observation as ground truth.
- **The same thing from the other side:** a nightmared (not petrified) target that is knocked down gets `actionState = "ko"` over `"nightmare"`; per the live report it also ends up moving normally with the status still on (path not traced).


### 4.3 Summon & companion entity mechanics
Summons (Barrel Bot, King Kaiser, Auto Gyro Gun, Phoenix, Gadina, Shadow Clones) are separate `CharacterControl` instances with specific engine inheritance rules:

1. **Independent 9-Stat Profile (`ownStats`):**
   * Summon entities instantiate with their own 9-stat array (`mhp, atk, def, agi, vit, mag, cha, tal, lck`), independent of the player's direct base stats.
   * Summon upgrade passives (e.g. Mole's `Double Bot`, `Synchro Mole`, `Hidden Turret`, `Heavy Built`) scale the summon's base attributes based on player level (`moleLV`).
2. **LCK Stat Separation (Damage Roll vs Duration Variance):**
   * **Damage Spread (`dmgAdjust`):** The summon's **own LCK stat** (`agg.lck`, `bb.lck`, `kk.lck`) is strictly the attacker's LCK for the summon's own attacks and movesets.
   * **Duration / Channel Variance:** In contrast, summon existence timers, channel durations, and skill active lifetimes (`chaAdjust`, `hitCountDuration`) originate from the **Player Caster** and calculate variance using the **Player's CHA and Player's LCK**, never the summon's LCK.
3. **Automated Move Resource Policy:**
   * Automated companion AI moves (`barrelBot_nAttack`, `punch`, `hammer`, `autoGyroGun_nAttack`) consume 0 MP/SP (`cost: None`).
   * Active command abilities where the player spends resources to command the summon (e.g. `Barrel Cannon` manual cast, 50 SP) consume player resources normally.

### 4.4 Knockback force versus movement roots (`CharacterControl.cs`)

Incoming direct damage can add a knockback vector to `myForce` (`CharacterControl.cs:6969`, `:31675`). Each update runs `ApplyForce()` (decay), then `ApplyMovement()` (status-specific changes), then `MovementUpdate()` (`:1060-1093`). The final movement call adds force **separately** from voluntary movement: `mChar.Move((vMovement * moveSpeed * clamp(moveMod, 0.1, 2) + verticalSpeed) * deltaTime + myForce)` (`:2722`). Therefore `moveSpeed = 0` alone does not remove an already-queued force vector in this client code.

| Status | Per-update `ApplyMovement()` behavior | Source |
|---|---|---|
| `noForce` (status code 5) | `myForce = Vector3.zero`; does not set `moveSpeed` | `StatusData.cs:107-114`; `CharacterControl.cs:2266-2275` |
| `needlePrison` (604) | `moveSpeed = 0` **and** `myForce = Vector3.zero` | `StatusData.cs:1163-1170`; `CharacterControl.cs:2358-2372` |
| `groundLock` (906) | `moveSpeed = 0` **and** `myForce = Vector3.zero` | `StatusData.cs:1449-1456`; `CharacterControl.cs:2392-2406` |
| `lightBind` (1106) | `moveSpeed = 0` only; its branch has no `myForce` assignment | `StatusData.cs:1757-1764`; `CharacterControl.cs:2485-2495` |

`noForce` is a distinct status, not an automatic part of `StatusData.isLockStatus()`: that predicate names `groundLock`, `needlePrison`, `sticky`, `frost` and `lightBind` (`StatusData.cs:6133-6238`), while the `noForce` branch is separately keyed by its own `sType` in `ApplyMovement()`. Sheep Light Bind applies only `RPC_AddStatus("lightBind", ...)` (`Sheep.cs:28898-28902`); no `noForce` application appears in `Sheep.cs`. **Light Bind and knockback (re-traced 2026-10-01):** a 2026-09-25 live report said Light Bind prevents knockback. A second trace found no suppression path: the `lightBind` apply site only spawns its effect and calls `PositionEvent()` (`CharacterControl.cs:39607-39623`), its `ApplyMovement()` branch only sets `moveSpeed = 0` (`:2485-2495`), and `recieveForce` (the only flag that zeroes `nForce` in `RPC_AddDamage`, `:3703`) is never set false anywhere. Per the user's decision the app's status text no longer claims knockback immunity. Needle Prison and Ground Lock need no `noForce` status to block force in the decompiled client.

### 4.5 Hidden treasure-box placements and spawn rule

`TreasureBox.Start()` rolls once when the scene loads. It destroys a candidate box if `Random.Range(0, 100) < num`, where `num` is 40/30/20/10 for wood/silver/gold/diamond (`TreasureBox.cs:20-86`; `eTreasureBoxLv.cs:5-17`). A surviving box is renamed `treasureBox` and all child renderers are disabled (`TreasureBox.cs:93-115`). Cat Awareness reveals surviving boxes within its 12/24 m radius (`Cat.cs:8922-8945`; `TreasureBox.cs:402-449`). With Treasure Hunt, Awareness marks all loaded surviving boxes on the minimap, regardless of reveal radius (`Cat.cs:8867-8916`).

**Opening and contents:** A revealed box offers a click interaction only to the Cat. The box maps wood/silver/gold/diamond to action ranks 1/2/3/4, calls `Cat.RPC_treasureHunt(...)`, broadcasts the matching action when Photon is active, plays the open animation, and destroys itself after 3 seconds (`TreasureBox.cs:183-355`, `:156-178`). `Cat.RPC_treasureHunt` only instantiates the `treasureHunt` effect prefab (`Cat.cs:9078-9116`); the broadcast encodes those four actions as `-121` through `-124` (`Cat.cs:2028-2075`, `:3398-3425`). The available client source and exported effect prefab contain **no verified item, currency, or reward table for these boxes**. Their actual contents and drop odds remain unknown; the four action ranks establish box tiers, not rewards.

The exported Unity scenes contain **52 scripted candidate placements in 23 scenes**. These are possible spawn points, not guaranteed boxes on every run. Coordinates below are scene positions `(x, y, z)`, rounded to 0.001 unit. Each `file:line` citation is relative to `RippedAssets/ExportedProject/Assets/Scene/` and points to that object's Transform. The scene YAML omits serialized `mLv`, so its `TreasueBox1/2/3` names do **not** verify a wood/silver/gold/diamond tier.

| Scene | Candidate positions `(x, y, z)` and source |
|---|---|
| M105_NeedleCave | `-67.682, 41.337, 78.889` (M105_NeedleCave.unity:6758)<br>`37.727, 39.165, 57.406` (M105_NeedleCave.unity:7250)<br>`22.184, 42.799, 33.385` (M105_NeedleCave.unity:7297) |
| M205_CrossingPlainLagoon1 | `22.031, 50.183, 81.221` (M205_CrossingPlainLagoon1.unity:5996) |
| M206_GrandTheftMupo1 | `-9.784, 50.577, -9.506` (M206_GrandTheftMupo1.unity:15024) |
| M401_DownFromVolcano1 | `-29.649, 42.952, 36.446` (M401_DownFromVolcano1.unity:5998)<br>`24.131, 43.063, 37.065` (M401_DownFromVolcano1.unity:6056)<br>`47.55, 45.928, -6.177` (M401_DownFromVolcano1.unity:6103) |
| M401_DownFromVolcano2 | `57.927, 44.508, -37.093` (M401_DownFromVolcano2.unity:10261)<br>`-24.574, 46.503, -9.735` (M401_DownFromVolcano2.unity:10214) |
| M403_CactonGarden | `27.306, 50.089, 18.315` (M403_CactonGarden.unity:4537) |
| M504_WaterTemple | `12.279, 40.006, 32.65` (M504_WaterTemple.unity:7641)<br>`-47.5, 51, -77.5` (M504_WaterTemple.unity:7688)<br>`47.5, 51, -77.5` (M504_WaterTemple.unity:7735) |
| M505_SunkenCity2 | `51.236, 50.002, -33.146` (M505_SunkenCity2.unity:6525)<br>`-48.477, 50.031, 33.906` (M505_SunkenCity2.unity:7135)<br>`3.924, 51.197, -15.433` (M505_SunkenCity2.unity:7182) |
| M603_ShadeInTheCity2 | `-30.432, 49.999, -50.93` (M603_ShadeInTheCity2.unity:12821)<br>`15.42, 50.971, -2.061` (M603_ShadeInTheCity2.unity:12774)<br>`-15.5, 50.955, -7.23` (M603_ShadeInTheCity2.unity:12727) |
| M606_WalrusGoneMad | `-18.001, 50.014, -2.779` (M606_WalrusGoneMad.unity:6012)<br>`-5.184, 50.002, -17.358` (M606_WalrusGoneMad.unity:7888) |
| M701_StrangeNewFoe | `-22.71, 50.4, -49.685` (M701_StrangeNewFoe.unity:6937)<br>`76.627, 50.612, 135.202` (M701_StrangeNewFoe.unity:7039) |
| M702_EasternWorldDivide2 | `-35.426, 50.374, 91.142` (M702_EasternWorldDivide2.unity:8673)<br>`-107.018, 50.063, -89.736` (M702_EasternWorldDivide2.unity:8720) |
| M704_ZappaBaseEntrance | `-39.314, 50.237, 79.071` (M704_ZappaBaseEntrance.unity:8000) |
| M805_LightVaultCleaning | `-33.399, 50, 16.124` (M805_LightVaultCleaning.unity:3728)<br>`74, 50, 2` (M805_LightVaultCleaning.unity:3775) |
| M903_ShadowPalace2 | `211.002, 50, 224.993` (M903_ShadowPalace2.unity:30136)<br>`250.445, 50, -173.293` (M903_ShadowPalace2.unity:30260)<br>`-249.988, 50, 229.065` (M903_ShadowPalace2.unity:30307)<br>`-125.642, 50, -17.977` (M903_ShadowPalace2.unity:30354) |
| M932_WindHollow1 | `34.708, 31.365, -101.196` (M932_WindHollow1.unity:9151)<br>`-50.354, 37.498, -85.02` (M932_WindHollow1.unity:9732) |
| M971_MaohsTomb1 | `0, 94.039, 43` (M971_MaohsTomb1.unity:4734) |
| M971_MaohsTomb4 | `0, 50, 4` (M971_MaohsTomb4.unity:6726) |
| M971_MaohsTomb8 | `12, 50, 122` (M971_MaohsTomb8.unity:7354)<br>`-12, 50, 122` (M971_MaohsTomb8.unity:7436) |
| M971_MaohsTomb9 | `54, 50, 72` (M971_MaohsTomb9.unity:9389)<br>`0, 50, 64` (M971_MaohsTomb9.unity:9471)<br>`-36, 50, 195` (M971_MaohsTomb9.unity:9483)<br>`-48, 50, 195` (M971_MaohsTomb9.unity:9565) |
| M972_IceTower8 | `-6.42, 43.379, -15.104` (M972_IceTower8.unity:5349) |
| M972_IceTower9 | `13.523, 28, 1.965` (M972_IceTower9.unity:5089)<br>`-8.158, 18, 3.453` (M972_IceTower9.unity:5136)<br>`13.802, 68, -2.839` (M972_IceTower9.unity:5183)<br>`-9.687, 48, 2.841` (M972_IceTower9.unity:5230) |
| M973_PirateCave2 | `-89.474, 55.21, 97.739` (M973_PirateCave2.unity:8116)<br>`74.909, 47.63, 19.339` (M973_PirateCave2.unity:8645)<br>`22.883, 58.438, 31.178` (M973_PirateCave2.unity:9591)<br>`83.212, 58.378, 72.798` (M973_PirateCave2.unity:13391) |

### 4.6 Team containers and team-wide skills (`Game.cs`)
Every spawned character is re-parented under a scene object named `"Team" + (layer - 7)`:
```csharp
string name = "Team" + (gameObject.layer - 7);
GameObject gameObject2 = GameObject.Find(name);
gameObject.transform.parent = gameObject2.transform;
```
(`Game.cs:2924-2926`, same pattern at `:4120-4122` and `:4405-4407`.)

A skill that loops over `self.gameObject.transform.parent` and keeps children tagged `"Player"` therefore reaches **every player on the caster's team, including the caster, anywhere in the scene**. There is no distance, party or line-of-sight filter unless the loop adds one. Example: Sheep All Cleanse (`Sheep.cs:25756-25835`, see [sheep-skill-reference.md](sheep-skill-reference.md)). Its tooltip says "all players in the same team", which matches the team container, not the party list.

---

### 4.7 GoldenKingBug mission (M946): boss spawn and player placement (`M946_GoldenKingBug.cs`)

* **One boss, five equally likely spots.** The mission owner (`ownerID == PlayerData.UID`) picks `GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 6))` (`M946_GoldenKingBug.cs:1794`; the int overload, so 1-5 uniform) and creates `GoldenKingBug2` (advance mode, `Game.useAdvanceMode`) or `GoldenKingBug` there (`:1811` / `:1819`).
* **Placement.** Each player is teleported to `GameObject.Find("WarpPoint" + Game.getPlayerSlot(PlayerData.UID))` and takes that object's position and rotation (`:2244-2260`), so slot 1..N always starts at the same fixed spots and faces the same way. Warp-point positions / yaws and the five spawn positions are in the Bible's Golden King Bug map tool (`12t_projects/goldenkingbug-spawn-map/`).
* **Search strategy (derived, not a game value).** The map tool's right-hand panel gives, for 1-12 players, the visiting routes that minimise the mean time until the party knows where the boss is (exhaustive search over every split and order; ties: smaller worst case, then fewer players moving). Model (user, 2026-10-10): walking 5 units/s; a spot counts as checked once the player is within 30 units of it; **elimination rule:** once 4 spots have been checked empty the 5th must hold the boss, which counts as finding it, so plans only visit 4 spots and the time to know is min(arrival at the boss spot, arrival at the last of the other four). Distances are shortest paths on a walkway centre-line graph built from the cave mesh (midpoints of the floor-strip edges that cross each tunnel; a vertex is ceiling when a vertex sits about 7 units straight below it, everything else is floor, so stacked tunnels are not confused; so paths run down the middle of the walkway, not along the walls; each spot snapped to its nearest node). Mean / worst seconds: 1 player 37 / 72, 2 players 19 / 33, 3 players 15 / 24, 4-7 players 7 / 9, 8-12 players 7 / 9; beyond 4 players extra people add almost nothing. In the simulation, once the boss is seen (or deduced) everyone takes the shortest route to it and stops at 30 units from it until the whole party has gathered.

### 4.8 Normal-attack combo schedule (read 2026-10-15, user: "Wolf combo timing is too fast")

A combo is a fixed schedule from the first stage, not a chain of equal waits. In `Wolf.cs` (the same shape in Cat, Panda and Whale):
- **Only stage 1 sets `actionTime`** (`Wolf.cs:15429`); stages 2-4 set `actionState = "attack"` and `myCommand` only (`:16240`, `:16943`, `:17977`), so `actionTime` stays at the start T0 of stage 1.
- **Input windows** (the dispatcher, `Wolf.cs:7540-7830`): stage 2 can be pressed when `T0 + 0.3 < t < T0 + 0.8`, stage 3 when `T0 + 1.0 < t < T0 + 1.44`, stage 4 after `T0 + 1.6`. An early press is ignored (not buffered).
- **The stage waits for its anchor:** the first thing stage k does is `Yield(2, WaitForSeconds(actionTime - Time.time + X))` (`Wolf.cs:16267`, `:16959`, `:18024`), so its animation, movement and hits begin at the same moment (T0 + X) whenever you pressed inside the window. Anchors X: **Wolf** 0.8 / 1.44 / 1.97 (stage 5, 3.1); **Cat** 0.6 / 1.2 / 1.7 (`Cat.cs:17609`, `:18538`, `:19511`); **Panda** 0.6 / 1.5 / 2.4 / 3.0 (`Panda.cs:16621`, `:17501`, `:18064`, `:18802`); **Whale** 0.8 / 1.8 (`Whale.cs:17775`, `:18589`). Each anchor equals the end of the previous stage's own waits (Wolf stage 2 ends at 0.8 + 0.16 + 0.32 + 0.16 = 1.44), so the schedule is continuous.
- **Each stage also has waits of its own before it moves or hits** (e.g. Wolf stage 2: 0.16 s, then `moveSpeed 4` for 0.32 s, then the hit). The first version of the range preview left these out and chained stages at the previous stage's last speed change, which made the combo about 0.2-0.5 s per hit too fast.
- **Combo restart lock:** every stage adds `addTimeOut("nAttack", 1.5)` (`Wolf.cs:15435`, `:15760`, `:16482`, `:17179`); a new stage 1 is refused while it runs (`isTimeOut("nAttack")`, `:7814`).

### 4.9 Pets: effects that are not stats (verified 2026-10-18)

A pet is item slot 5 (`CharacterControl.cs:1497`, `this.pet = current.equipment[5].name`). Its stats are plain `att[]` gear stats (`PetData.getData`, `PetData.cs`; index order as §1.1). This section covers only pets whose code does something else. Pure stat pets (balloons except Bigbug, Smash / Soccer Ball, the four festival kites (weight only), L. BD Mellon, Cake Carron, Disco Peppon, S. RedPanda, S. Santa Skunk, S. ClownDemion, S. Doov, S. BarrelBot, the eight S. bug pets) are left out. `p_ssb` S. SamuraiBug has a `PetData` entry ("valor1 (14+N)m") but no prefab in any `<Class>Equipment.cs`, no shop entry and no code, so it never existed in game.

**Pet level `N`.** The id ends in the level, `p_lmc1` … `p_lmc9` (`Stringf.getInteger` / `getLastDigit`; their bodies are a stub in the decompile, read as "trailing number" as in §4.2). Shops sell Lv 1 only (`ShopData.cs`). The pet shop upgrades one level at a time up to 9 (`PetShopGui.cs:1904`, "already reach maximum level"); the recipe is `PetShopData.getUpgradeItem` (`PetShopData.cs:123-670`), each material `clamp(floor(factor × N), 1, 99)` for the current `N` (`PetShopGui.cs:2003`). Pets with no recipe (S. Kumo, S. Karazo, the balloons and kites, S. RedPanda, …) stay Lv 1. The MiniBug recipes eat other MiniBugs (e.g. MiniNemesis needs `floor(0.5 × N)` MiniNemesis Lv 1).

**Where the code lives.**
- **Timed effects:** `PetUpdate()` in every hero script (`Bat.cs:17293-19221`; Bison `:11705`, Cat `:13320`, Chameleon `:12569`, Mole `:17136`, Monkey `:17023`, Panda `:12336`, Penguin `:14146`, Rabbit `:14433`, Sheep `:14398`, Whale `:13027`, Wolf `:11952`). The twelve copies were compared statement by statement (2026-10-18) and are identical. It runs from `Update()` only on the owner's client and only while `Game.mGameType > 4` (`Bat.cs:170-218`): normal missions (5) and the PvP arenas M981-M987 (7). In towns (3), guild camps (2) and the type-4 missions (M107, M207, M307, M407, M507, M607, M707, M807, M917, M927, M937) no timed pet effect runs. One timer per character: `+= Time.fixedDeltaTime` each tick, reset to 0 when the pet changes (`:17329-17350`) and when an effect fires. For every timed effect below the timer resets *before* the target search, so a cycle with no target in range is still spent.
- **Visuals and delayed damage:** `RPC_petEffect` coroutine (`Bat.cs:51856-52676`).
- **Reactive effects:** `RPC_AddDamage` (`CharacterControl.cs:5748-5821`, after `hitMod`, shields and trinket seals, just before the `AddDamage` coroutine), `RPC_AddStatus` (`:14167`, `getPetProtection` `:19722-20001`) and the death check in each hero's `Update()` (`Bat.cs:350-394`, same in all 12). These run in every game type.
- **Damage path:** every pet hit is a direct `RPC_AddDamage` or `RPC_AddEffectDamage` with hate 0 (§2.9): no dodge, no `dmgAdjust`, no DEF, no TAL or LCK, only the target's `hitMod` and shields. Areas use `Damage.FindAreaTarget(centre, radius, height, mask)` (`Damage.cs:963-1162`): distance to the near edge of each target's `CharacterController`, Enemy-tagged objects listed before Player-tagged ones.

**Timed attacks** (centre "you" = the owner's transform, `Bat.cs:57`; mask = every team layer except the owner's unless noted):

| Pet (id, req Lv) | Every | Targets | Effect | Source |
|---|---|---|---|---|
| L. Mad Carron (`p_lmc`, 31) | 6 s | first unit within `0.5 + 0.5N` m of the **pet** | direct `31 + 4N` | `:17543-17682` |
| L. Mad Peppon (`p_lmn`, 31) | 3 s | same, `0.5 + 0.5N` m | direct `11 + 4N` | `:17684-17824` |
| L. Mad Cocon (`p_lmo`, 31) | 9 s | same, `3 + N` m | Effect Damage `6 + 3N` | `:17825-17965` |
| MiniSkyBug (`p_msb`, 41) | `21 − N` s | up to 3 enemies within 12 m of you | Effect Damage `12 + 2N` each | `:18264-18386` |
| MiniCrystalBug (`p_mcb`, 42) | `21 − N` s | up to 2 within 8 m | direct `20 + 4N`, KO 2 | `:18387-18509` |
| MiniAncient (`p_mab`, 43) | `21 − N` s | 1 within 24 m | direct `24 + 4N`, KO 5, force `0.3 × up` | `:18510-18632` |
| MiniReef (`p_mrb`, 44) | 60 s | first enemy within 18 m (height 4) marks the spot | 1 s later every enemy within 6 m of the spot: direct `40 + 20N` | `:18633-18733`, `:52030` |
| MiniMok (`p_mmb`, 45) | `21 − N` s | **every** enemy within 6 m | direct `N + 4`, KO `N + 4`, force `0.3 × up` | `:18734-18835` |
| MiniGolden (`p_mgb`, 46) | `21 − N` s | up to 4 within 18 m (height 4) | k-th target (k = 1..4): direct `12 + 4N + 4k`, KO 2 | `:18836-18958` |
| MiniNemesis (`p_mnb`, 47) | `60 − N` s | closest living enemy within 9 m | Chaos Ray from the pet: direct `15 + 5N` every 0.4 s while the ray exists | `:18961-19031`, `:52063-52126`, `:52496-52546` |

- **Heights and shapes:** every pet area above is `FindAreaTarget` with height `3 × rangeMod` (the owner's `rangeMod`; the window runs from `0.5 × height` below the centre to `height` above it, `Damage.cs:1140-1156`), except the MiniReef search and MiniGolden (height `4`, no `rangeMod`). MiniNemesis instead uses `FindClosestNonDeadTarget` (`Damage.cs:2061-2160`): a 3D sphere measured centre to centre, nearest living unit wins; the ray's re-aim uses the same search with 6 m.
- **Chaos Ray length:** the `miniChaosRay` prefab's `EffectControl` has `life 2.0`, `afterLife 0` (decoded from `12TailsOnline_Data/resources.assets`, pathID 78457; the object is destroyed at `life + afterLife`, `EffectControl.cs:179-183`). The first tick is 0.4 s after the ray appears, so ticks land at 0.4 / 0.8 / 1.2 / 1.6 s; a tick at 2.0 s races the destroy in the same frame. The ray re-aims at the closest non-dead target within 6 m of the first target's position (`:52506`).
- **L. Mad pets can hit allies:** their mask is `130816` (all team layers) where every other pet uses `130816 − (1 << own layer)`, and the only exclusion is the owner (`gameObject != this.gameObject`). `FindAreaTarget` lists Enemy-tagged units first, so a monster in range is always picked first, but with none in range the first Player-tagged unit in range (an ally, or your own summon) takes the hit. `RPC_AddDamage` has no team check (`:3680-3770`). Not live-checked.

**Timed self / area effects:**

| Pet (id, req Lv) | When | Effect | Source |
|---|---|---|---|
| Bigbug Balloon (`p_all1`) | every 60 s | `Game.mGameMana++` (+1 mission mana, the gold counter the stage adds +1 to every 12 s, e.g. `M101_CarronHunt.cs:235-238`), chat "Go Go AlphaTester!" | `Bat.cs:17370-17395` |
| L. Carron / Mupo / Peppon Saver (`p_lcs` / `p_lms` / `p_lps`, 21) | every `32 − 2N` s, `Random(0,100) < 4 + 2N` (no LCK) | self `float` Lv 4, 3 s | `:19159-19186` |
| S. Kumo (`p_skm`, 15, no upgrade) | every 15 s, `Random(0,100) < 30` (no LCK) | self `wash` Lv 4, 3 s | `:18027-18060` |
| S. FlowerBug (`p_sfb`) | every 60 s | self `bless` Lv 1 (all 8 stats +8), `11 + N` s | `:18061-18091` |
| S. Ice Mixer (`p_sim`, 30) | every 45 s | every enemy within 5 m of the pet: `ice` Lv 2 (move speed −30%), `N + 1` s | `:18092-18193` |
| S. Ammonite (`p_sam`, 35) | every 120 s | self `bubbleShield` Lv 2, `11 + N` s, pool `15 + 15N` (absorbs half of each direct hit, §4.1) | `:18194-18224` |
| S. IcePenguin (`p_spg`, 41) | HP below `(0.11 + 0.01N) × max HP` and 60 s since the last one | self `iceShield` Lv 2, `11 + N` s, `30 + 10N` HP | `:18225-18263` |
| S. Ninja Kite r / g / y / b / k (`p_skr` / `skg` / `sky` / `skb` / `skk`, 25) | every `45 − 2N` s | every enemy within 15 m of the kite: `awareness` Lv 2, 1 s (removes `blend` and `invisible`, §4.1) | `:17996-18026` → `:19037-19157` |

Durations are passed as is: no `chaAdjust`. Ice Mixer and the kites search with height `3 × rangeMod` like the attacks; the kite search is centred on the kite's x / z at the owner's height (`Bat.cs:19081`). All five kite prefabs contain the `SmallNinjaKite_tri/kite` child the code looks up (`RippedAssets/.../pet/smallNinjaKite_*.prefab`).
- **`wash` strips your own buffs:** `wash` removes every status that is both Physical and Buff with a level ≤ the wash level (`CharacterControl.cs:36103-36189`; Whale's Spiral Blast puts it on the enemies it hits, see [whale-skill-reference.md](whale-skill-reference.md) §4.15). S. Kumo puts Lv 4 on its owner, so it removes the owner's `atkUp` … `lckUp`, `berserkerRush`, `blend`, `damagePlus`, `drunken`, `enlarge`, `furyTrance`, `gobble`, `hardenSkin`, `lifeBoost`, `magicBoost`, `reduce`, `shield`, `speedBoost` up to Lv 4 (`isPhysicalStatus` `StatusData.cs:5220` ∩ `isBuffStatus` `:6323`). Its Thai description says it "ช่วยล้างสถานะ" (cleanses statuses).
- **`float` Lv 4:** on apply removes `heavy`, `groundLock`, `needlePrison`, `sticky`, `frost`, `lightBind` (`CharacterControl.cs:39790-39812`); while it lasts, a new `heavy`, `groundLock`, `needlePrison`, `sticky`, `frost`, `lightBind` or `maim` of level ≤ `2 × 4` is resisted (`-83`, `:13115-13185`).

**Reactive effects:**

| Pet (id, req Lv) | Trigger | Effect | Source |
|---|---|---|---|
| S. Anubi (`p_sab`, 31) | you reach 0 HP, the pet timer is ≥ 12 s, no `death` status | `Random(0,100) <= lckAdjust(3 + N)` (so `lckAdjust + 1` % ): HP set to 1, then `RPC_AddHeal(1, 100)`, timer reset, chat "Small Anubi doesn't want you to die!" Checked after Black Servant and Auto Life. | `Bat.cs:350-394` |
| S. Karazo (`p_skz`, 15, no upgrade) | an incoming direct hit of 1-30 damage (after `hitMod` and shields) | `Random(0,100) < lckAdjust(30)`: deflect (`-85`), damage 0. `N` unused. | `CharacterControl.cs:5748-5790` |
| S. PirateFish (`p_spf`, 51) | an incoming direct hit with KO > 0 | `Random(0,100) < lckAdjust(4)`: KO set to 0. `N` unused. | `:5791-5821` |
| Anti-status pets (below) | a matching status arrives (after every other resist in `RPC_AddStatus`) | `Random(0,100) < lckAdjust(chance)`: resist (`-83`) | `:14167`, `:19722-20001` |

Anti-status: `3 + N` for L. Carron `sleep`, L. Mupo `maim`, L. Peppon `ice`, L. Cacton `poison`, L. Cocon `burn`, L. Pumpkon `curse`, L. Mellon `cut`; `5 + N` for L. Dead Carron `lightBind`, L. Dead Mupo `paralysis`, L. Dead Peppon `petrify`, L. Dead Cacton `groundLock`, L. Dead Cocon `provoke`, L. Dead Pumpkon `nightmare`. `lckAdjust` is the owner's (§2.4). Karazo and PirateFish sit in `RPC_AddDamage`, so Effect Damage (§2.9) never triggers them. The six plain Little pets and S. RedPanda also post a chat line on a timer (Carron 240 s, Mupo 210 s, Peppon 300 s, Cacton 360 s, Cocon 300 s, Pumpkon 360 s, RedPanda 240 s; `Bat.cs:17408-17517`, `:19191-19200`, `:17966-17991`), with no other effect.

**Tooltip vs code** (`PetData.cs` `special` line, shown in the item tooltip):
- L. Carron (P) `p_lcp`: "+(6+N)% anti-sleep", but `getPetProtection` has no `p_lcp` case: no effect.
- S. Kumo: "wash 14%" → 30% every 15 s, and `wash` strips the owner's physical buffs (above).
- S. Karazo: "block 30 dmg (14+N)50%" (garbled) → `lckAdjust(30)` on hits of 30 or less.
- S. PirateFish: "(3+N)% no ko" → `lckAdjust(4)`, level ignored.
- Savers: "+(2+2N)% Float" → `4 + 2N` %, no LCK.
- Ninja Kites: "awareness (14+N)m" → radius always 15 m; the level shortens the interval instead.
- S. Anubi: "(3+N)% autoRevive" → `lckAdjust(3 + N) + 1` %, at most once per 12 s.
- S. BarrelBot (a stat pet): "+4 tal" → TAL `4 + N`.

### 4.10 Monster target pick: `getRandomHateTarget` (verified 2026-10-21)

Boss AIs and moves (including Germanotta, 2026-10-21) are in [boss-reference.md](boss-reference.md).

**`getRandomHateTarget(maxRange)` (`CharacterControl.cs:8514-8648`, engine-wide).** Makes `mHateList.length` draws of a uniformly random hate-list entry (with replacement) and returns the first that exists, is on an enemy layer (`layer > 7`, not its own), is alive and within `maxRange` horizontally. The hate amount plays no part, and it can return `null` by bad luck even when a valid entry exists.

### 4.11 Battle Colosseum 3 vs 3 (M982): start points and respawn (verified 2026-10-23)

Mission 982 "Battle Colosseum" (`MissionData.cs:9893-9974`): `player = 3` per team, `allowRespawn` and `allowChange` true, items and mounts off, Lv 25 minimum; the first team to 12 KOs wins (`MissionData_eng.cs:1657-1660`). Scene `M982_BattleColosseum.unity`.

* **Match start: fixed by slot.** Each player spawns at `GameObject.Find("StartPoint" + playerSlot)` (`M982_BattleColoseum.cs:1143`; a slot outside 1-6 falls back to `StartPoint1`, `:1194`). Team = `floor((slot - 1) / 3) + 1` (`:1154`, `Math.cs:23`): slots 1-3 are team 1, slots 4-6 team 2. In the scene, StartPoint1-3 sit at x ≈ +14..15 facing −x and StartPoint4-6 at x ≈ −14..−15 facing +x, so the teams start on opposite sides facing each other.
* **On a KO.** After 2 s (`:2976`) every one of the player's three characters gets a timer of at least 12 s (only raised, never lowered: `if timeOut < 12 + now → setTimeOut(slot, 12)`, `:2821-2851`), and the dead menu opens (`:2914`). The menu shows the three characters; one below the mission level is locked, one with time left shows the countdown, and a ready one is a button (`GameGui.cs:22955-23014`). The respawn waits for that click; it is not automatic, and the player may pick any of their three characters.
* **Respawn: a random point, fresh each time.** The click sends `RespawnPlayer(CID)` (`GameGui.cs:23009`); 1 s later it picks `GameObject.Find("SpawnPoint" + (1 + UnityEngine.Random.Range(0, 12)))` (`M982_BattleColoseum.cs:3370`, the int overload, so SpawnPoint1-12 each 1/12) and keeps the player's team (`:3383`). There is no sequence or rotation, no team side, no check for enemies nearby or for the last point used, so two players can land on the same point. The roll is made on the dying player's own client (unseeded `UnityEngine.Random`), which sends the position to the server (`OpCustom(65)`, `:3448`). No client code sets `Random.seed` anywhere, and that generator also feeds every other roll the client makes (combat, effects), so other players cannot know the next point before the player appears. The SpawnPoint markers are invisible in game (`HideIcon` turns their renderer off, `HideIcon.cs:22`).
* **Spawn ring.** The 12 SpawnPoints form a ring of radius ≈ 12.5 around the arena centre, about 30° apart, each facing the centre (local positions under `Icons`, centre ≈ (0, 25.5) in x/z). The ring is shared by both teams, so half the respawns land on the side the enemy team started on.
* **After the revive.** `onRevivePlayer` sets all three character timers to the minimum 6 s (`setTimeOut(slot, 0)` clamps to 6-120, `:1727-1733`, `CharacterData.cs:2269`).

## Riding mounts: G. Marshal and G. Champion (verified 2026-10-17)
Mount items any class can ride. In the app: `common_marshalMount`, `common_championMount`, `common_championMount_charge`, and per class `<class>_mountAttack` / `<class>_mountDash` (formulas in each class reference).
- **Items** (`MountData.cs`): `o_all3` / `o_all4` = `PvpMount1` / `PvpMount2`, the blue and red armoured mupo ("+20 all stats", the G. Marshal pair, matching the (B) / (R) G. Marshal gear; the app shows the red one). `o_all5` = `G.Champion Mount`, the golden armoured mupo ("+50 all stats"). Item `lv` -60 / -70 = PvP rank.
- **Using the item** (`GameGui.cs:35923-35990`): stage mana 2 (Marshal) / 3 (Champion); refused below PvP rank 60 / 70 ("Your rank is too low").
- **Riding cast:** `RPC_useMount` casts `magAdjust(6)` (`Wolf.cs:43719-43725`; the same in every class).
- **Stats** (`onMount`, `PvpMount.cs:157` / `ChampionMount.cs:157`): each of the 8 stats = the rider's `getNoDeltaStat` (base, no buffs) + 20 / + 50; `mhp = 10 × vit`, `mmp = 3 × mag`, `msp = floor(0.2 × tal) + 10`, `mko = floor(def / 3) + 10`; current HP / MP / SP / KO copy the rider's fractions. The mount character's `Type` stays "none" (`CharacterControl.cs:34`), so class checks inside `hit()` such as Cat Power do not apply to mount hits.
- **Which attack** (`doNormalAttack`, `PvpMount.cs:2336`): no attacks while `Game.mGameType < 4` (town); on `isTimeOut("nAttack") == 0`, `moveSpeed <= 0.4 × runSpeed` runs the class's `RPC_nAttack_<class>`, anything faster `RPC_rAttack_<class>`. Both share the `nAttack` timeout (each move sets its own length). Ride speed 8 (Marshal) / 9 (Champion) after an attack.
- **Same moves on both mounts:** a line-by-line diff of every attack coroutine's targets, hits and timeouts in `PvpMount.cs` against `ChampionMount.cs` differs only in that ride speed. The projectile prefabs' scripts are the `PvpMount_<class>_nAttack.cs` files (Bat, Chameleon, Mole, Penguin, Sheep).
- **Charge:** the G. Marshal answers a charge with "This character cannot use charged attack". The G. Champion charges (`RPC_cAttack1`, "Charging...") and on release runs `RPC_cAttack2` (`ChampionMount.cs:18031-18528`): `addTimeOut("cAttack", agiAdjust(30))` (the mount's own AGI / LCK), dash at speed 10, after 0.2 s one `FindRecTarget(pos, fwd, 2, 2, 3, 3)` and `hit(41, 400, KO 4)` per target (`:18415, :18434`), then 0.3 s more. Flat 400 before the usual damage adjustments.
