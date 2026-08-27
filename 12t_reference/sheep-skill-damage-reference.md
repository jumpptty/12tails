# Sheep — Skill Damage & Mechanics Reference

Verified from decompiled source (`DecompiledSource/Sheep.cs`, `DecompiledSource/SheepSkill.cs`) for the player-reference-tool (`12t_projects/player-reference-tool/index.html`).

---

## 1. Summary of Sheep Mechanics

- **Healing & Benediction Scaling**:
  - Direct heals (`heal`, `quickHeal`, `allHeal`, `overHeal`, `revive`) scale directly with `TAL` via `mChar.talAdjust(...)`.
  - Multiplied by the **Benediction** passive: `× (1.0 + 0.15 × benedictionLv)` (+15% per rank, up to +45% at Rank 3).
  - Threat reduction via **Harmonic Diffuse** passive: `-0.15 × healAmount × harmonicDiffuseLv`.
- **Holy Arts & Divinity Damage**:
  - `holyLight`: Straight holy ray dealing `talAdjust(12 + 12×sLv)` with 1 KO knockback.
  - `overHeal`: Offensive opening strike targeting enemies at 100% full HP (`Sheep.cs:26334–26357`). Deals `talAdjust((20 + 30×sLv) × (1 + 0.15×benedictionLv))` magic damage capped at `(20% + 10%×sLv) × target Max HP` (30% Max HP at R1, 40% at R2). Deals 0 damage if target is below max HP.
  - `lightBind`: Single-target root (`moveSpeed = 0`) dealing `6×sLv` flat true effect damage every 1.0s (`CharacterControl.cs:9369`, purple penetrating damage). No burst finisher.
  - `divinitySword`: Holy summon slash dealing `talAdjust(10 + 20×sLv)`, 1 KO.
  - `divinitySpear`: Piercing line thrust dealing `talAdjust(10 + 15×sLv)`, 1 KO.
  - `divinityAxe`: Crushing holy slam dealing `talAdjust(45)`, 2 KO.
- **Support, Blessings & Seals**:
  - `bless`: Increases all 8 core stats by `4 + 4×sLv` (+8/+12/+16/+20, or +12/+16/+20/+24 with Gospel) for 30s (`chaAdjusted`).
  - `illuminate`: Targeted restorative aura pulsing every 3s to restore `4×(sLv + 2×depLv)` HP and `sLv + 2×depLv` MP/SP for 12s (`chaAdjusted`). Grants +2 bonus ranks with Blinding Light passive (4/8/12/16 HP base, or 12/16/20/24 HP with Blinding Light).
  - `sleep` & `lullaby`: Single-target and area sleep crowd control (contested by target CHA).
  - `feather` & `allFeather`: Reduces character weight by -5/-10 (super jump/slow fall) and adds +0.25/+0.50 m/s flat run speed for 15s (`chaAdjusted`). (Does not grant AGI).
  - `seal`: Places Red / Blue ground seals for 60s.
  - `repel` & `reverse`: Tactical barriers lasting 6s / 3s (`chaAdjusted`).
  - `edenSanctuary`: 18m area field granting 50% damage reduction for 12s.
  - `worldEncarta`: Divine sanctuary for 9s (`chaAdjusted`), granting +20% of caster's ATK as flat DEF and absolute damage/debuff invulnerability.

---

## 2. Sheep Skill Reference Table

| Skill ID | Name | Max Rank | Cooldown (Base) | Cast Time (Base) | Duration (Base) | Formula / Effect | KO | Notes |
| :--- | :--- | :---: | :---: | :---: | :---: | :--- | :---: | :--- |
| `sheep_heal` | Heal | 4 | [14, 16, 18, 20]s | [2, 3, 4, 5]s | — | `talAdjust(10 + 15×sLv)` | 0 | Single-target heal scaling with TAL and Benediction (+15%/rank). |
| `sheep_bless` | Bless | 4 | [45, 60, 75, 90]s | [3, 4, 5, 6]s | 30s | +8/12/16/20 all stats | — | Buffs all 8 stats by `4 + 4×sLv` for 30s (`chaAdjusted`). Gospel passive fixes CD to 30s and grants +1 status level (+4 all stats). |
| `sheep_quickHeal` | Quick Heal | 2 | 1s (unwrapped) | 0s | — | `talAdjust(10×sLv)` | 0 | Instant 3m AoE heal around caster scaling with TAL and Benediction (hits up to 5 allies, or 7 with KO Heal). |
| `sheep_allHeal` | All Heal | 2 | [45, 60]s | [4, 5]s | — | `talAdjust(10 + 15×sLv)` | 0 | Map-wide party heal (unlimited range) scaling with TAL and Benediction. |
| `sheep_pacify` | Pacify | 2 | [45, 60]s | [2, 3]s | — | Aggro reduction | — | Calms target enemy, reducing threat. |
| `sheep_sleep` | Sleep | 2 | 90s | [6, 8]s | [15, 20]s | Sleep CC | — | Single-target sleep for (10 + 5×sLv)s (`chaAdjusted`, contested by target CHA). Breaks on damage. |
| `sheep_clear` | Clear | 2 | [12, 18]s | [2, 3]s | — | Cleanse 1 debuff | — | Cleanses 1 negative status from target ally. |
| `sheep_cleanse` | Cleanse | 1 | 30s | 4s | — | Cleanse debuffs | — | Targeted status cleanse. |
| `sheep_allCleanse` | All Cleanse | 1 | 90s | 6s | — | Party cleanse | — | Cleanses debuffs from all party members. |
| `sheep_overHeal` | Over Heal | 2 | [30, 45]s | [4, 6]s | — | `talAdjust(20 + 30×sLv)` | 0 | Offensive opening burst against full HP enemies (`hp == mhp`). Deals `talAdjust(20+30×sLv)` magic damage, capped at (20%+10%×sLv) of target Max HP (30% at R1, 40% at R2). Deals 0 damage if target `hp != mhp`. |
| `sheep_revive` | Revive | 2 | [240, 180]s | [4, 5]s | — | `talAdjust(50×sLv)` | 0 | Resurrects fallen ally with HP scaling with TAL and Benediction. |
| `sheep_revert` | Revert | 1 | 900s | 6s | — | 100% HP/MP/KO reset | — | Complete emergency recovery. |
| `sheep_holyLight` | Holy Light | 2 | 60s | 6s | — | `talAdjust(12 + 12×sLv)` | 1 | Linear holy ray dealing magic damage with 1 KO knockback. |
| `sheep_lightBind` | Light Bind | 4 | [18, 22, 26, 30]s | [2, 2.5, 3, 3.5]s | 3s | `6×(sLv+depLv)` (per 1.0s tick) | 0 | Roots target (0 moveSpeed) for 3s base (`chaAdjusted`, contested) + 1.0s fixed duration with Intense Bind. Deals 6×(sLv+depLv) effect damage/tick (up to 30 at Rank 4 with Intense Bind). |
| `sheep_illuminate` | Illuminate | 4 | [15, 18, 21, 24]s | [2, 3, 4, 5]s | 12s | `+4×(sLv + 2×depLv) HP, +(sLv + 2×depLv) MP/SP` | — | Friendly HoT/MoT/SoT buff pulsing every 3s for 12s (`chaAdjusted`). +2 effective ranks with Blinding Light (12/16/20/24 HP, 3/4/5/6 MP/SP per tick). |
| `sheep_feather` | Feather | 2 | [15, 18]s | [2, 3]s | 15s | -5/-10 weight, +0.25/0.50 spd | — | Reduces weight by -5/-10 (super jump) and increases run speed by +0.25/+0.50 m/s for 15s (`chaAdjusted`). |
| `sheep_allFeather` | All Feather | 2 | 60s | [4, 5]s | 15s | -5/-10 weight, +0.25/0.50 spd | — | Party-wide weight reduction (-5/-10) and run speed buff (+0.25/+0.50 m/s) for 15s (`chaAdjusted`). |
| `sheep_divinitySword`| Divinity Sword | 2 | 45s | [3, 4]s | — | `talAdjust(10 + 20×sLv)` | 1 | Forward holy slash summoned weapon strike. |
| `sheep_divinitySpear`| Divinity Spear | 2 | 60s | [4, 5]s | — | `3 × talAdjust(10 + 15×sLv)` | 1 | Linear piercing spear thrust through enemies, striking 3 times. |
| `sheep_seal` | Seal | 1 | 12s | 0s | 60s | Red/Blue ground seal | — | Ground seal lasting 60s (`chaAdjusted`) for combo alignment. |
| `sheep_repel` | Repel | 2 | 120s | [5, 4]s | 6s | Physical deflection | — | Deflection wall lasting 6s (`chaAdjusted`), absorbing 50/100 damage/hit and blocking projectiles. |
| `sheep_reverse` | Reverse | 2 | 240s | [7, 5]s | 3s | Status inversion | — | Inversion seal lasting 3s (`chaAdjusted`), converting `50% × sLv` (50%/100%) of incoming damage to healing. |
| `sheep_soulOfArms` | Soul of Arms | 2 | 300s | [6, 8]s | — | Autonomous weapons | — | Summons spiritual weapons that auto-attack nearby targets. |
| `sheep_purifyingTear`| Purifying Tear | 1 | 480s | 3s | — | Threat wipe (AoE) | — | 40m holy shockwave wiping all accumulated enemy threat/hate. |
| `sheep_lullaby` | Lullaby | 1 | 60s | 9s | 6s | Area Sleep CC | — | Soothing area hymn sleeping all nearby targets for 6s (`chaAdjusted`, contested by target CHA). Breaks on damage. |
| `sheep_divinityAxe` | Divinity Axe | 1 | 150s | 7s | — | `5 × talAdjust(45)` | 2 | Summons a divine battleaxe, damaging enemies in the area 5 times. |
| `sheep_edenSanctuary`| Eden Sanctuary | 1 | 240s | 0s | 12s | 50% dmg reduction | — | 18m sanctuary field reducing incoming damage by 50% for 12s. |
| `sheep_worldEncarta` | World Encarta | 1 | 150s | 7s | 9s | Invulnerability + DEF | — | Target invulnerability barrier for 9s (`chaAdjusted`): adds +20% of caster's ATK as DEF and grants 100% immunity. |

---

## 3. Decompiled Source Citations

- **`heal`**:
  - Cast Time: `Sheep.cs:21224` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted at `:21588`).
  - Cooldown: `Sheep.cs:21229` — `this.$mTimeOut$27749 = 12 + 2 * this.$sLv$27762;` (agiAdjusted at `:21606`).
  - Healing: `Sheep.cs:22281–22290` — `talAdjust((10 + 15*sLv) * (1 + 0.15*benedictionLv))`, `RPC_AddHeal`.
- **`allHeal`**:
  - Cast Time: `Sheep.cs:21241` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21246` — `this.$mTimeOut$27749 = 30 + 15 * this.$sLv$27762;` (agiAdjusted).
  - Healing: `Sheep.cs:23850` — `talAdjust((10 + 15*sLv) * (1 + 0.15*benedictionLv))`.
- **`bless`**:
  - Cast Time: `Sheep.cs:21258` — `this.$mCastTime$27748 = (float)(2 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21263` — `this.$mTimeOut$27749 = ((!hasSkill(412)) ? (30 + 15 * sLv) : 30);` (agiAdjusted).
- **`pacify`**:
  - Cast Time: `Sheep.cs:21271` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21276` — `this.$mTimeOut$27749 = 30 + 15 * this.$sLv$27762;` (agiAdjusted).
- **`sleep`**:
  - Cast Time: `Sheep.cs:21288` — `this.$mCastTime$27748 = (float)(4 + 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21293` — `this.$mTimeOut$27749 = 90;` (agiAdjusted).
- **`clear`**:
  - Cast Time: `Sheep.cs:21305` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21310` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (agiAdjusted).
- **`quickHeal`**:
  - Cast Time: `0` (instant).
  - Cooldown: `Sheep.cs:10316` — `this.mChar.addTimeOut("quickHeal", (float)1);` (bare literal 1s).
  - Healing: `Sheep.cs:22800` — `talAdjust(10*sLv * (1 + 0.15*benedictionLv))`.
- **`overHeal`**:
  - Cast Time: `Sheep.cs:21356` — `this.$mCastTime$27748 = (float)(2 + 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21361` — `this.$mTimeOut$27749 = 15 + 15 * this.$sLv$27762;` (agiAdjusted).
  - Offensive Logic: `Sheep.cs:26334–26357` —
    - Target condition check: `if (this.$tChar$27882.hp != this.$tChar$27882.mhp) { mHeal = 0; } else { mHeal = Mathf.Min(talAdjust(...), Mathf.FloorToInt((0.2f + 0.1f * sLv) * target.mhp)); }`
    - Damage application: `RPC_AddDamage(250 + sLv, mHeal, 0, 0, Vector3.zero, caster.ActorNr)` (0 KO).
- **`revive`**:
  - Cast Time: `Sheep.cs:21373` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21378` — `this.$mTimeOut$27749 = 60 + 60 * this.$sLv$27762;` (agiAdjusted).
  - Healing: `Sheep.cs:28600` — `talAdjust(50*sLv * (1 + 0.15*benedictionLv))`.
- **`holyLight`**:
  - Cast Time: `Sheep.cs:21390` — `this.$mCastTime$27748 = (float)6;` (magAdjusted).
  - Cooldown: `Sheep.cs:21395` — `this.$mTimeOut$27749 = 60;` (agiAdjusted).
  - Damage: `Sheep.cs:29300` — `talAdjust(12 + 12*sLv)`, KO 1.
- **`lightBind`**:
  - Cast Time: `Sheep.cs:21407` — `this.$mCastTime$27748 = 1.5f + 0.5f * (float)this.$sLv$27762;` (magAdjusted).
  - Cooldown: `Sheep.cs:21412` — `this.$mTimeOut$27749 = 14 + 4 * this.$sLv$27762;` (agiAdjusted).
  - Duration: `Sheep.cs:28899` — `Damage.getDebuff(3f, casterCha, targetCha) + intenseBindLv` (3s base CHA-contested, +1s fixed uncontested from Intense Bind).
  - Root: `CharacterControl.cs:2491` — `this.moveSpeed = 0f;`.
  - Damage: `CharacterControl.cs:9369` — `RPC_AddEffectDamage(300 + sLv, 6 * sLv, 0, 0, Vector3.zero, sID)` (every 1.0s, deals 6×(sLv+depLv) true effect damage per tick, reaching 30 damage at Rank 4 + Intense Bind; no burst finisher).
- **`illuminate`**:
  - Cast Time: `Sheep.cs:21424` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21429` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (agiAdjusted).
  - Duration: `Sheep.cs:29411` — `this.$self_$27966.mChar.chaAdjust(12)`.
  - Status Level: `Sheep.cs:29411` — `sLv + ((!this.$self_$27966.mChar.hasSkill(413)) ? 0 : 2)` (Blinding Light passive grants +2 effective ranks).
  - Effect: `CharacterControl.cs:9402` — `this.RPC_AddHeal(1, 4 * sLv, sLv, sLv, 0, 0, sID)` pulsing every 3.0s (`global::Math.mod(2 * (sTime - sAge), 6) == 0`). Restores `4×(sLv + 2×depLv)` HP and `sLv + 2×depLv` MP/SP per tick (16 HP base at Rank 4, 24 HP with Blinding Light).
- **`feather`**:
  - Cast Time: `Sheep.cs:21441` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21446` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (agiAdjusted).
  - Effect: `CharacterControl.cs:39638–39644` — `weight -= 5 * sLv`, `sF2cOBZX7wK -= 5 * sLv` (jump gravity), `deltaRunSpeed(0.25f * sLv)`.
- **`allFeather`**:
  - Cast Time: `Sheep.cs:21458` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21463` — `this.$mTimeOut$27749 = 60;` (agiAdjusted).
  - Effect: `CharacterControl.cs:39638–39644` — party-wide weight reduction (-5/-10) and flat run speed (+0.25/+0.50 m/s).
- **`divinitySword`**:
  - Cast Time: `Sheep.cs:21475` — `this.$mCastTime$27748 = (float)(2 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21480` — `this.$mTimeOut$27749 = 45;` (agiAdjusted).
  - Damage: `Sheep.cs:30200` — `talAdjust(10 + 20*sLv)`, KO 1.
- **`divinitySpear`**:
  - Cast Time: `Sheep.cs:21492` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21497` — `this.$mTimeOut$27749 = 60;` (agiAdjusted).
  - Damage: `Sheep.cs:30800` — `talAdjust(10 + 15*sLv)`, KO 1.
- **`repel`**:
  - Cast Time: `Sheep.cs:21509` — `this.$mCastTime$27748 = (float)(6 - this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21514` — `this.$mTimeOut$27749 = 120;` (agiAdjusted).
- **`reverse`**:
  - Cast Time: `Sheep.cs:21526` — `this.$mCastTime$27748 = (float)(9 - 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21531` — `this.$mTimeOut$27749 = 240;` (agiAdjusted).
- **`soulOfArms`**:
  - Cast Time: `Sheep.cs:21543` — `this.$mCastTime$27748 = (float)(4 + 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21548` — `this.$mTimeOut$27749 = 300;` (agiAdjusted).
- **`divinityAxe`**:
  - Cast Time: `Sheep.cs:21560` — `this.$mCastTime$27748 = (float)7;` (magAdjusted).
  - Cooldown: `Sheep.cs:21565` — `this.$mTimeOut$27749 = 150;` (agiAdjusted).
  - Damage: `Sheep.cs:36100` — `talAdjust(45)`, KO 2.
- **`worldEncarta`**:
  - Cast Time: `Sheep.cs:21577` — `this.$mCastTime$27748 = (float)7;` (magAdjusted).
  - Cooldown: `Sheep.cs:21582` — `this.$mTimeOut$27749 = 150;` (agiAdjusted).
  - DEF & Immunity: `Sheep.cs:38357` & `CharacterControl.cs:39883` — `deltaDef(Mathf.FloorToInt(0.2f * casterAtk))`.
- **`purifyingTear`**:
  - Cast Time: `Sheep.cs:34888` — `3.0s` (magAdjusted).
  - Cooldown: `Sheep.cs:35011` — `this.mChar.addTimeOut("purifyingTear", this.mChar.agiAdjust(480f));`.
- **`lullaby`**:
  - Cast Time: `Sheep.cs:35388` — `this.$mCastTime$28120 = this.$self_$28130.mChar.magAdjust((float)9);`.
  - Cooldown: `Sheep.cs:35500` — `60s` (agiAdjusted).
- **`edenSanctuary`**:
  - Cast Time: `0` (instant).
  - Cooldown: `Sheep.cs:36951` — `this.mChar.addTimeOut("edenSanctuary", this.mChar.agiAdjust(240f));`.
