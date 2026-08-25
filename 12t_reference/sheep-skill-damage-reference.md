# Sheep — Skill Damage & Mechanics Reference Blueprint

> **Status:** Preliminary Architecture & Decompilation Blueprint (To be fully implemented upon Sheep rework kick-off)  
> **Primary Source Files:** `DecompiledSource/Sheep.cs`, `DecompiledSource/SheepSkill.cs`, `DecompiledSource/CharacterControl.cs`  
> **Companion Reference:** `12t_reference/sheep-skill-reference.md` (Verified cooldowns, durations, and max ranks)

---

## 1. Core Mechanics Overview

Sheep is the primary hybrid Support / Priest / Shaman / Mage class in 12Tails, specializing in:
1. **Healing & Regeneration** (`Heal`, `Quick Heal`, `All Heal`, `Over Heal`, `Revive`, `Revert`)
2. **Blessings & Stat Buffs** (`Bless`, `Feather`, `All Feather`, `Illuminate`, `Soul of Arms`)
3. **Seals & Ground Fields** (`Seal of Attack/Defense/Earth/Heaven`, `Repel`, `Reverse`, `Eden Sanctuary`)
4. **Divinity Attacks & Light Spells** (`Holy Light`, `Light Bind`, `Divinity Sword`, `Divinity Spear`, `Divinity Axe`, `Purifying Tear`)

---

## 2. Preliminary Decompiled Formula Analysis

### A. Healing & Recovery Pipeline
* **`heal1-4` (Heal)**:
  * Cast site: `Sheep.cs:23850` (or `RPC_heal_cast`)
  * Base formula: `characterControl.RPC_AddHeal(skillId, talAdjust(baseHeal * sLv), 0, 0, ...)`
  * Focus / INT interaction: Scales with `talAdjust` and `INT` stat multipliers.
* **`quickHeal1-2`**: Instant single-target recovery with 1s cooldown.
* **`allHeal1-2`**: Party-wide AoE recovery.
* **`overHeal1-2`**: Converts overheal into temporary barrier / shield or extra max HP buffer.

### B. Buffs & CHA Scaling Cadence
* All timed buffs and seals utilize `chaAdjust(baseDuration)`:
  * `bless1-4`: 30s base $\rightarrow$ `chaAdjust(30)`
  * `feather1-2` / `allFeather1-2`: 15s base $\rightarrow$ `chaAdjust(15)`
  * `illuminate1-4`: 12s base $\rightarrow$ `chaAdjust(12)`
  * `seal`: 60s base $\rightarrow$ `chaAdjust(60)` ground lifetime (`Sheep.cs:32284`)
  * `repel1-2`: 6s base $\rightarrow$ `chaAdjust(6)`
  * `reverse1-2`: 3s base $\rightarrow$ `chaAdjust(3)`
  * `worldEncarta`: 9s base $\rightarrow$ `chaAdjust(9)`

### C. Divinity Weapons & Offensive Holy Spells
* **`holyLight1-2`**: Single-target / frontal holy ray.
* **`lightBind1-4`**: Holy bind / root debuff.
* **`divinitySword1-2`**: Physical/magical hybrid strike.
* **`divinitySpear1-2`**: Piercing linear divinity thrust.
* **`divinityAxe`**: Heavy holy execution strike.
* **`purifyingTear`**: High-cooldown ultimate holy burst.

### D. Effect Damage & Mitigation Bypassing
* Any skill invoking `RPC_AddEffectDamage` directly (like true damage / status bursts) will be flagged with `effectDamage: true` (purple font in formula card + `dmgdigit_p<N>` purple in-game damage simulator numbers).

---

## 3. Implementation Workflow for Future Execution

1. **Decompilation & Formula Verification**:
   * Trace `Sheep.cs` line-by-line for each skill's `RPC_<name>_cast` and `RPC_<name>_hit` / `mChar.hit(...)` / `RPC_AddHeal` calls.
   * Document exact base numbers, stat coefficients (`talAdjust`, `ATK`, `INT`, `CHA`), and Class C passive interactions.
2. **Icon Validation**:
   * Extract and verify all 64×64 PNG base64 strings directly from `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/sheep/` into `SKILL_ICONS`.
3. **Player Reference Tool Integration**:
   * Insert all 28 Sheep skill definitions into `SKILLS` in `12t_projects/player-reference-tool/index.html`.
   * Configure `cdWrapped: true`, `durWrapped: true`, `hitCountDuration` (for pulsing fields), `dmgRankDep`, and `heal` properties.
4. **Interactive Validation & Commit**:
   * Run `/grill-me` or interactive verification for edge cases and push to `skill-cooldown-lookup`.
