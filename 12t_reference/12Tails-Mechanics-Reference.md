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
| 0 | **ATK** Attack   | physical skill base damage (`atkAdjust`) |
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
> some abilities (`cSP` cost on skills). Both regenerate over time (see CharacterControl.cs ~:1949/:2029).

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

### 2.1 The LCK spread
Almost every adjuster adds a random roll driven by the actor's Luck:
```
R = Random(0, ceil(0.2 * LCK))     // integer in [0, ceil(0.2*LCK))
```
Higher LCK ⇒ a wider upward spread on damage dealt, damage mitigated, action speed, buff length, skill power.

### 2.2 Attacker side
**`dmgAdjust(d)`** outgoing damage (CharacterControl.cs:20487):
```
dmgAdjust(d) = ceil( clamp(damageMod, 0, 5) * d + R )
```
`damageMod` defaults to `1.0` (CharacterControl.cs:142) and is raised/lowered by buffs/debuffs (e.g. `damagePlus`,
`powerBreak`). Capped at 5× outgoing.

**`atkAdjust(p)`** physical skill base damage (CharacterControl.cs:20516):
```
atkAdjust(p) = floor( clamp( p * (ATK + R), 1, 512 ) )
```

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
magAdjust(t) = clamp( t - MAG/32 , 0.1 , 600 )   // flat cast-time reduction
```
**`agiAdjust(t)`** action/recovery time, AGI-based (CharacterControl.cs:20575):
```
n            = AGI + R
agiAdjust(t) = t * (1 - n/(n + 128))             // diminishing-returns speedup
```
**`chaAdjust(t)`** buff/debuff duration, CHA-based (CharacterControl.cs:20593):
```
chaAdjust(t) = ceil( t * (1 + 0.015 * clamp(CHA + R, 1, 512)) )   // +1.5% duration per CHA
```
**`talAdjust(p)`** skill power, TAL-based (CharacterControl.cs:20624):
```
talAdjust(p) = ceil( p * (1 + 0.02 * clamp(TAL + R, 1, 512)) )    // +2% power per TAL
```
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

---

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
- **Basic/weapon-style hits scale on ATK** via `atkAdjust(coeff)` (`×(ATK+R)`).
- The final number then runs through `dmgAdjust` (attacker) → `defAdjust` (target) from §2.

### 3.3 Representative coefficients (sampled from Cat.cs)
Coefficient = the literal passed to `talAdjust(...)`/`atkAdjust(...)`; small for low-tier moves, large for
ultimates:

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

---

## 4. Hidden mechanics & special interactions

- **Luck touches everything.** The `R = Random(0, ceil(0.2*LCK))` spread is added inside `dmgAdjust`, `atkAdjust`,
  `defAdjust`, `agiAdjust`, `magAdjust`, `chaAdjust`, `talAdjust`. High LCK is a soft, universal stat buff (more
  upside on every roll) plus a direct `%`-chance boost through `lckAdjust`.
- **Global multiplier mods** (default 1.0, changed by statuses): `damageMod` (0–5 cap on outgoing damage),
  `koMod`, `hateMod`, `forceMod`. Reset to defaults at CharacterControl.cs:142+.
- **Holy interactions** — `holyArmor` and `holySword` multiply a value by `1000` then add `getStatusValue(...)`
  (CharacterControl.cs:11942 / 11966), i.e. special flat-ignoring damage/defense behavior for those buffs.
- **Stat buffs are flat deltas.** Applying `atkUp` does `deltaAtk(+num)`; on expiry `deltaAtk(-num)`
  (CharacterControl.cs:14691+). The same pattern covers `defUp/agiUp/vitUp/magUp/chaUp/talUp/lckUp` and the
  matching `*Down` debuffs. `num` is the status' strength/level, set by the skill that applied it.

### 4.1 Status effect catalog (StatusData.getStatusCode, StatusData.cs)
Each status maps to a sequential integer code. Grouped by function:

- **Control / disables:** `ko`, `lock`, `paralysis`, `petrify`, `fear`, `drunken`/`drunk`, `grab`, `swallow`,
  `gobble`, `provoke`, `disarm`, `artCancel`, `delayQi`, `sticky`, `heavy`, `needlePrison`, `maim`.
- **Damage-over-time / decay:** `poison`, `venomShock`, `bleed`, `cut`, `acid`, `rust`, `rustyDecay`, `puncture`,
  `hpSap/mpSap/spSap/koSap`, `hpDrain/mpDrain/spDrain/koDrain`, `heat`.
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

## 6. Worked example (sanity check)

A Cat (TAL 100, LCK 50) casts the AoE skill `talAdjust(50) + 200` at a target with DEF 50, LCK 30,
`damageMod = 1`. Using average rolls:

1. **Skill power:** `R_atk = Random(0, ceil(0.2*50)) = Random(0,10) ≈ 5`.
   `talAdjust(50) = ceil(50 * (1 + 0.02*(100+5))) = ceil(50 * 3.10) = 155`. → `raw = 155 + 200 = 355`.
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
| Combat adjusters | `CharacterControl.cs` :20487–20671 (`dmgAdjust/atkAdjust/defAdjust/agiAdjust/magAdjust/chaAdjust/talAdjust/lckAdjust/koAdjust/hateAdjust/forceAdjust`) |
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
