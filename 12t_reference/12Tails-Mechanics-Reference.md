# 12 Tails — Game Mechanics & Formula Reference

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
> **Status tick cadence:** `StatusUpdate()` (CharacterControl.cs:8659) runs its per-status body at most once per **0.5 s** (`if (kNtcObrGvdk > Time.time - 0.5f)` skip, else `kNtcObrGvdk = Time.time`). A status with no extra gate in its branch (e.g. `ashura`, `:8841`) acts every 0.5 s; others add their own modulo gate on top (`holyWolf`: `mod(2·(sTime − now), 16) == 0` = every 8 s, `:8787`; `afterShock`: `mod(2·now, 6) == 3`, `:8820`).

### 1.3 Where total stats come from
`total[i] = bStat[i] + bonus[i] + typeLevelStat[i] + skillBonus + Σ equipment.att[i]`
- `bStat` — the character's own allocated base stats (string).
- `bonus` — misc bonus string.
- `typeLevelStat` — per-class growth from level (see 1.4).
- `skillBonus` — small flat bonuses from owning certain passive skills.
- `equipment.att[i]` — gear stat bonuses (see §5).

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

> **Server Difference:** Original code has no level cap on this formula (scales continuously up to Lv 100+). In Tales of Tail (ToT), passive stat growth from level is capped at Lv 95 (`min(lv, 95)` — levels 96–100 grant no additional passive level stats).

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
N     = clamp(DEF + R, 1, 512)               // R uses the DEFENDER's luck
light = max( d - 0.5 * N , 1 )               // flat armor component
heavy = max( d * (1 - N/(N + 64)) , 1 )      // percentage component
taken = ceil( 0.35 * light + 0.65 * heavy )
```
Interpretation: 35% of the hit is reduced by flat armor (`−DEF/2`), 65% by a diminishing-returns percentage
(`DEF/(DEF+64)`). DEF has *no* hard cap on usefulness but the percentage term saturates (e.g. DEF 64 → −50% on
the heavy part; DEF 192 → −75%).

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
- **Inside `RPC_AddDamage`** everything applies no matter how it was reached: `hitMod` (`:3765`), `noDamage`/`perfectArmor`/`perfectShield`, the Whale Peninsula Round redirect (`:4299-4367`), and then the `AddDamage` coroutine (`:5822`/`:6035` → `$AddDamage$35579`) with shield statuses such as Whale's `shield` (`:30855-30960`) and the type-specific flat reductions of §2.7.
- **`RPC_AddEffectDamage` (`:6058`)** is its own path: `hitMod` (`:6203`) but no dodge, no `defAdjust`, no shield statuses and no Peninsula Round redirect (the only `"peninsulaRound"` check in the engine is `:4313`).
- **Tool note:** the bible models these with card flags. `dmgAdjustSkip:true` = skips `dmgAdjust` but keeps `defAdjust` (Mole Missile, Barrel Bot Missile). `penetrating:true` = skips both (Flame Turret, Flame Carnival, Monkey Lavu). `effectDamage:true` = the `RPC_AddEffectDamage` path. A direct-caller card without the right flag overstates damage, because the default pipeline applies `dmgAdjust`.

---

### 2.10 Equipment critical hit — `getCritPlus` (verified 2026-09-29)

Every class with crit gear wraps some raw damage values in its own `getCritPlus(nDmg)` before calling `hit()` (Wolf `Wolf.cs:14160-14186`, Bison `Bison.cs:13801-13950`, Sheep `Sheep.cs:16494-16640`, Rabbit `Rabbit.cs:16471-16600`; identical shape):

- **Gear sum** `n`: weapon `w_<cls>43`/`44` +5, `w_<cls>58` +7; armor `a_all43`/`44` +4, `a_all58` +6; hat `c_all43`/`44` +3, `c_all58` +5. Full Marshal (supreme commander) set = 12, full Champion set = 18; there is no other source of crit in these functions.
- **Roll:** `Random.Range(0, 100) < lckAdjust(n)` (`lckAdjust` as in §2.4, LCK clamped to 1-512); each call rolls on its own. `n = 0` never crits.
- **Effect:** `FloorToInt(1.8 × nDmg)` on the raw value only. The result still goes through `hit()` → `dmgAdjust` → `defAdjust` → `hitMod`, so final damage is not exactly 1.8x.
- **Example chances** (LCK 0 / 128 / 512): Marshal 12 → 12% / 23% / 45%; Champion 18 → 18% / 33% / 57%.
- **Where the wrap sits differs per skill:** Rabbit rifle Combo, the ricochet and From the Above wrap `hitDmg + Hyper Shot`; the Customized Shotgun wraps only `(int)(0.5 × ATK)` and adds Hyper Shot after; Rabbit Charge Attack has no `getCritPlus` at all. Modeled in the Bible on Wolf Combo, Bison Combo, Sheep Book Bash and Rabbit Combo (`critProc` / `rawModel.critBase`, "ดูสูตรคริ" toggle that shows the card as a crit hit).

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
  the target's collider edge nearest `pos` (`transform.position + radius·dir`) tested against it; `TargetHeight` is the
  height. Cards quote it as `รัศมี <TargetRange>m สูง <TargetHeight>m`.
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

**`poison`** (code 605, Debuff + Physical: `StatusData.cs:1174`, `:5457`, `:7406`): a pure damage-over-time with no stat change on apply (`CharacterControl.cs:36965`). Each tick is Effect Damage `RPC_AddEffectDamage(1, 10 × sLv − 1, ...)` from `StatusUpdate` (`:9208+`), so it cannot be dodged (§2.8) and gets only `hitMod`. **Tick interval: every 4 seconds**, from the user's in-game observation (2026-09-23). The source timer is obfuscated and was not traced. `removeDot()` clears it (`:19664`).

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

**Debuffs that are also State (verified 2026-09-27).** `isDebuffStatus ∩ isStateStatus` (`StatusData.cs:7175`, `:4809`, junk predicates evaluated) = `artCancel`, `blackServant`, `bloodCarnage`, `blueFlag`, `cut`, `darkStalker`, `elementalBound`, `grab`, `overPresence`, `petrify`, `puncture`, `redFlag`. Any resist that filters `isDebuffStatus && !isStateStatus` (e.g. Panda Resistance `CharacterControl.cs:13512-13580`, the equipment debuff-resist branch `:13672`) cannot block these 12.

**`lock`, `ko`, `death` statuses (verified 2026-09-27).** All three are Debuff + System only.
- `lock`: its only reader is `ApplyMovement()` (`CharacterControl.cs:2278-2297`, junk predicates evaluated): each frame `moveSpeed = 0`, `myForce.x = 0`, `myForce.z = 0` (vertical force kept). No other `"lock"` read exists in the source, so attacking and casting are unaffected. It is **not** in `isLockStatus` / `removeLockStatus` (`:19456`: groundLock, needlePrison, sticky, frost, lightBind), so Backflip-style unlocks do not remove it. Appliers: Cat Delta Strike (`Cat.cs:37186, 37265, 37430`, Lv1 3s), Panda Rising Dragons (`Panda.cs:29625`, Lv1 2s), Ranger Robot (`RangerRobot.cs:3112`, `RangerRobotMount.cs:3175`, Lv5 6s).
- `ko`: apply handler `ko = clamp(ko − 5 × sLv, 0, mko)`, not kept in the status list (`:33670`). Only applier: Panda weapon Boxing Grove `w_pnd15`, `lckAdjust(6)` per normal-attack hit, Lv1 (−5 KO) (`Panda.cs:51265`).
- `death`: apply handler `hp = 0` (`:35416`); Immunity explicitly skips it (`:12665`). Appliers: Panda Death Blow (`Panda.cs:35211`, `lckAdjust(20 × sLv) > Random(0, target hp)`, target standing/running/emoting) and the Fire Arena map (`M981_FireArena.cs:479`).

**Target-skill range = the 40 m target lock (verified 2026-09-27).** `eSkillMode.target` skills send `doSkill` with the currently selected `targetObject` (`GameGui.cs:37857-37880`) and have no generic distance check there; a class may add its own gate (e.g. Chameleon Slayer `< 24 + 4×FarReach`, `Chameleon.cs:7571`). The selection itself is dropped every frame once the horizontal (XZ) distance from the camera target (the player) exceeds 40 m (`sqrMagnitude > 1600`, `GameGui.cs:4339`, `:4350`), so a target skill without its own gate reaches **40 m**. Tab-cycling only picks targets within 36 m (`cycleEnemyTarget(…, 1296)`, `:2168`, `:2176`). Mouse selection (`RenderTargetArea`, `:4137-4290`) is a `Physics.Raycast` from the **camera** through the cursor: 30 m long while hovering, **40 m** on the frame the right button goes down (`GetMouseButtonDown(1)` → `num2 = 40`, layer mask `~6`, `:4160-4300`); right-click locks that hit (`GetKeyDown("mouse 1")` → `targetObject`, `:1880-1890`), left-click release on a hovered target also selects it (`:1782`). Because the ray starts at the camera, the reach measured from the character is somewhat under 40 m; once locked, the 40 m-from-player drop rule above decides how long it stays. **Camera offset (`PlayerCameraControl.cs`):** `distance` starts at 6 with a pending `zoom` of 5 (constructor `:24-33`), applied on the first update and clamped to **2-12** (`:360-381`), so a fresh camera sits at 11 (not saved to PlayerPrefs). The mouse wheel sets `zoom = clamp(GetAxis("Mouse ScrollWheel"), -0.3, 0.3)` each frame (`GameGui.cs:2145`) and the axis sensitivity is 1000 (`ProjectSettings/InputManager.asset:257`), so every wheel notch saturates to **±0.3**: from 11 the reachable distances are 2.0, 2.3 … 11.9 and 12 — **35 zoom positions**. Pitch = `4 × distance − 4`° (`− 16` with the Low Angle option, `:392-395`, `:436`, `:482`). `ApplyPositionDamping` (`:627-640`) places the camera `(distance + max(0, height − 1.5))` from a pivot at the character's bounds centre + `0.2 × height` up, along that pitch: horizontal `cos(pitch) × d` behind, `sin(pitch) × d` above. For a character up to 1.5 m tall: d 2 → 2.0 m behind / 0.1 m up; d 6 → 5.6 / 2.1; **d 11 (default) → 8.4 m behind / 7.1 m up**; d 12 → 8.6 / 8.3. Right-click reach on flat ground (40 m ray, pivot ≈ 0.5 m up): straight ahead ≈ 38 / 34 / **31** / 30 m at d 2 / 6 / 11 / 12; to the side ≈ 38-40 m. Vertical FOV = `clamp(45 + camera-to-pivot distance + 5 × max(0, height − 1.5), 15, 90)` (`:672`), about 56° at d 11, so the top screen edge looks `pitch − FOV/2` below horizontal: at the normal angle and d 11 / 12 the screen only shows the ground out to ≈ 26 / 22 m ahead (pivot 0.85 m, target centre 0.6 m, flat ground), which caps click-targeting straight ahead below the 40 m ray. **Low Angle** (pitch −12°) keeps the horizon on screen at every zoom, so its straight-ahead reach is the ray limit, ≈ 30 / 29 m at d 11 / 12 (the camera sits ~1.3-1.5 m further back, costing ~1 m of ray reach). At d ≤ 6 both angles see the horizon and reach ≈ 34-38 m. Caveat: these are the script's constructor defaults; a scene-serialized `distance`/`zoom` on the camera object would override them, and the ripped scene YAML does not keep those values. Example: Cat Swift Pace has no gate of its own (`Cat.cs:6528-6600`).

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

> **Server Difference (TTO, user-reported live change 2026-09-28, not in the decompiled client):** on Tailstopia Online the Poseidon Bow (+12%) and Poseidon Helmet (+8%) `hpDrain` proc chance no longer goes through `lckAdjust`. The full set is a flat 20%, or 40% with Chameleon Double Effect (which doubles the base). Other gear procs are not covered by this report. The Bible's Character Hit Mod sim models this with its BB/TTO server toggle.

**Equipment debuff resist (verified 2026-09-27, `CharacterControl.cs:13588-13660` + labels `:14315-14333`, all classes).** Inside `RPC_AddStatus`, after the class-specific blocks: `num3 = 0`; `getInteger(weapon)` 47 or 48 → +6; `getInteger(armor)` 47 or 48 → +6; `getInteger(accessory)` 47 or 48 → +4; `getInteger(accessory)` 19 → +3. If `num3 > 0` and `isDebuffStatus && !isStateStatus && !isSystemStatus`, one roll `Random.Range(0, 100) < lckAdjust(num3)` rejects the status (`RPC_AddDamage(-83)` + `break`). Item 47/48 = each class's bug-themed "prevention of negative statuses" set (e.g. Panda Worm Knuckle/Suit/Cap, Wolf scorpion hat, Bison beetle helmet); accessory 19 = the class "Helps protect against abnormal status" hats (e.g. Panda mushroom hat `c_pnd19`). `Stringf.getInteger`'s body is not in the decompile (the firstpass `Stringf.cs` is an empty stub), so whether it matches only the trailing number (and so whether e.g. `c_all19` also counts) is inferred, not verified. The same function then has per-status accessory resists (`ice`: `c_all21`/`c_all22`, `snowMan`: `c_all29`, `sleep`: `c_mal37`/`c_fem37`, `corruption`: `c_all27`, …; the ice/snowMan/sleep ones roll `lckAdjust(12)`, `:13660+`).

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

## 5. Items & equipment

### 5.1 Item data — `ItemClass` (ItemClass.cs:143–186)
```
name, des, cType,
price, expire, lv, weight,
att[8]   : flat stat bonuses, SAME order ATK,DEF,AGI,VIT,MAG,CHA,TAL,LCK
hp, mp, sp, ko : flat bonuses to the corresponding max pools
special  : special-effect tag
status   : status applied (on-hit for weapons / on-use for consumables)
cure     : status it removes (consumables)
```
Gear contributes `att[i]` straight into each total stat, and `hp/mp/sp/ko` into the `bonusHP/bonusMP/...` pools
that feed the derived values in §1.2.

### 5.2 Equipment slots (6) — CharacterControl.cs:1482–1497
```
[0] weapon   [1] armor   [2] accessory   [3] boot   [4] trinket   [5] pet
```

### 5.3 Crafting / "Compound"
Item creation is the **Compound** system (`CompoundData.cs`, `CompoundGui.cs`, `eCompoundType.cs`). The client
holds recipe data only; there is **no client-side success-rate formula** — success is resolved server-side. So
upgrade/synthesis odds are not recoverable from this assembly.

---

### 5.2 Monster stats (all CharacterControl units, verified 2026-10-02)

- **Source:** the original client data, `D:\12tails\12TailsOnline_Data` (Unity 3.5.7f6; git-ignored). The install under `C:\Program Files (x86)\TalesofTails\game` is now the new ToT build (IL2CPP, encrypted `TTOENC01` bundles) and has no readable monster data; TailsTopia's bundles are wrapped too (`TTOBND1`). Neither was decrypted.
- **Method:** UnityPy 1.25 loads all 543 files (`resources.assets`, `level0-270`, `sharedassets0-270.assets`) together so each MonoBehaviour's `m_Script` resolves; every component whose script is `CharacterControl` is parsed from its raw bytes: `m_GameObject` PPtr (8) + `m_Enabled` (4) + `m_Script` PPtr (8) + `m_Name`, then `Name`, `Type` (length-prefixed, 4-byte aligned), `Lv`, `Skin`, `Race`, `mTargetAvartar` (PPtr, **8 bytes**), `hp sp mp ko mhp msp mmp mko atk def agi vit mag cha tal lck weight` (int32), `runSpeed` (float), `weapon armor accessory` (strings), the declaration order of `CharacterControl.cs:29675-29753`.
- **Validation:** printable ASCII strings, `0 ≤ Lv ≤ 999`, `0 ≤ Race ≤ 20`, every int stat in `0..500000`. 2,164 components found, 2,155 valid (9 rejected), 307 unit types, 332 distinct (Name, Type, stats) rows. Checks: First Whale (`Movah`, `resources.assets` pathID 80634) = Lv 150, MHP 60000, ATK 300, DEF 350, AGI 50, VIT 60000, MAG 50, CHA 300, TAL 300, LCK 150, MKO 400, identical to the hand-verified Bible preset; all nine enemy presets match their units.
- **What a row is:** one unit + stat set. Multi-part bosses carry one `CharacterControl` per part with its own `Name` (e.g. Nemesis Head / Body, Ancient Bug hands, Ewiniar tails); a few units have map-specific copies with different stats (e.g. Mok legs 6000 / 9000 HP, two Ancient Bug part sets). `hp/mp/sp/ko` are the starting values and `mhp/mmp/msp/mko` the maxima; the page shows the maxima. `Race` is `eRace` (0 NPC, 1 Tails, 2 Plants, 3 Bugs, 4 Robots, 5 Elementals, 6 Structure). Units whose own script overwrites stats at spawn (summons, e.g. Gadina ATK/DEF, Ja HP) keep their prefab numbers here; their cards use the source.
- **No monster ID:** `CharacterControl` has no ID field; the only number is the runtime `ActorNr` assigned at spawn.
- **Bible:** `MONSTER_STATS` (320 rows; the 12 player-class templates are left out) drives the monster stats page (`mountMonsterStats`, TOOLS id `monster-stats`); `[MONSTER STATS ERROR]` re-checks the ranges, the number of rows rendered and the First Whale row.

## 6. Worked example (sanity check)

A Cat (TAL 100, LCK 50) casts the AoE skill `talAdjust(50) + 200` at a target with DEF 50, LCK 30,
`damageMod = 1`. Using average rolls:

1. **Skill power:** `R_atk = Random(0, ceil(0.2*50)) = Random(0,10) ≈ 5`.
   `talAdjust(50) = floor(50 * (1 + 0.02*(100+5))) = floor(50 * 3.10) = 155`. → `raw = 155 + 200 = 355`.
2. **Attacker dmgAdjust:** `ceil(clamp(1,0,5)*355 + ≈5) ≈ 360`.
3. **Target defAdjust:** `R_def = Random(0, ceil(0.2*30)=6) ≈ 3`, `N = clamp(50+3,1,512) = 53`.
   `light = max(360 − 26.5, 1) = 333`; `heavy = max(360*(1 − 53/117), 1) = 360*0.547 ≈ 197`.
   `taken = ceil(0.35*333 + 0.65*197) = ceil(116.55 + 128.05) = 245`.

**Result ≈ 245 damage.** Raising the target's DEF to 192 would push the heavy term to `360*0.25 = 90`, and the
flat term to `360 − 96 = 264`, giving `ceil(0.35*264 + 0.65*90) = ceil(92.4 + 58.5) = 151` — illustrating DEF's
diminishing-but-uncapped value.

---

## 7. Source map

| System | Key file(s) / lines |
|--------|---------------------|
| Damage helpers & display | `Damage.cs` (`getDamage` :262, `getBuff` :309, `getDebuff` :317; AoE target finders; FX displays) |
| Combat adjusters | `CharacterControl.cs` :20487–20671 (`dmgAdjust/atkAdjust/defAdjust/agiAdjust/magAdjust/chaAdjust/talAdjust/lckAdjust/koAdjust/hateAdjust/forceAdjust`; `atkAdjust` at :20516 is dead code — zero call sites project-wide, see §3.2) |
| Hit pipeline | `CharacterControl.cs` :2807 (`hit`), :3540–3566 (order), :3680 (`RPC_AddDamage`) |
| Derived stats & gear assembly | `CharacterControl.cs` :1431–1497 |
| Stat string parse/build | `CharacterDataClass.cs` :1216 (`getStat`), stat assembly ~:370–407 |
| Class base stats & level growth | `CharacterData.cs` :218–493 (`getTypeStat`), :498–534 (`getTypeLevelStat`), :538 (`getNewRandomStat`) |
| Skills | `SkillClass.cs`, `SkillData.cs` :21, per-class `*Skill.cs`; damage at execution sites (e.g. `Cat.cs`) |
| Status system | `StatusData.cs` :50–1372 (`getStatusCode`), `StatusControl.cs`, status apply/remove in `CharacterControl.cs` :14660+ |
| Items / equipment | `ItemClass.cs` :143–186, `ItemData.cs`, `EquipmentControl.cs` |
| Crafting | `CompoundData.cs`, `CompoundGui.cs` (recipes only; success server-side) |
| Enums | `eDamageType.cs`, `eSkillType.cs`, `eSkillMode.cs`, `eSkillTarget.cs` |

> **Reading obfuscated code:** ignore all `if (<int> - <int> != <int>) { … }` wrappers and the `for(;;)…break`
> scaffolding — they're always-true/false filler. The real logic is the assignments, arithmetic, `Mathf.*`
> calls and `.Split('%')`. Field/class names like `LTRpgsKoBpCYTrSOvr` or `QkpcO7j5692` are mangled; identify
> them by how they're used (`QkpcO7j5692` = bonusHP because it's added as `VIT*10 + QkpcO7j5692`).
