# Sheep — Skill Damage, Healing & Mechanics Reference

> **Status:** Ground-Truth Verified Reference  
> **Source Files:** `DecompiledSource/Sheep.cs`, `DecompiledSource/SheepSkill.cs`, `DecompiledSource/Sheep_edenSanctuary.cs`, `DecompiledSource/CharacterControl.cs`  
> **Companion Reference:** `12t_reference/sheep-skill-reference.md`

---

## 1. Healing Mechanics & Formulas

In 12Tails, direct healing power scales strictly with **TAL** (and **LCK** via `talAdjust` spread). **INT does not affect healing power**.

### `talAdjust(base)` Definition (`CharacterControl.cs:20624-20644`):
```csharp
int num = Mathf.Clamp(this.tal + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)this.lck)), 1, 512);
nPower = (int)((float)nPower * (1f + 0.02f * (float)num));
```

### `Benediction` Passive Multiplier (`Sheep.cs:22284`):
- Rank 0: `1.0×`
- Rank 1: `1.15×` (+15%)
- Rank 2: `1.30×` (+30%)
- Rank 3: `1.45×` (+45%)

---

## 2. Verified Skill Roster

### 1. Heal (`heal`, Max Rank 4)
* **Cast Site:** `Sheep.cs:22284`
* **Base Formula:** `talAdjust((1 + 0.15 × benedictionLv) × (10 + 15 × sLv))`
* **Ranks (Base):** Rank 1: `25`, Rank 2: `40`, Rank 3: `55`, Rank 4: `70`
* **Cooldown:** `20s` (agiAdjust), **Cast Time:** `1.5s`
* **Mechanics:** Single-target direct heal. Spawns green healing floating numbers (`#4ade80`). DEF is bypassed.

### 2. Quick Heal (`quickHeal`, Max Rank 2)
* **Cast Site:** `Sheep.cs:10423`
* **Base Formula:** `talAdjust((1 + 0.15 × benedictionLv) × (10 × sLv))`
* **Ranks (Base):** Rank 1: `10`, Rank 2: `20`
* **Cooldown:** `1s` (flat, not agiAdjusted), **Cast Time:** `0s` (instant)
* **Mechanics:** Fast, low-cooldown single-target heal.

### 3. All Heal (`allHeal`, Max Rank 2)
* **Cast Site:** `Sheep.cs:23284`
* **Base Formula:** `talAdjust((1 + 0.15 × benedictionLv) × (10 + 15 × sLv))`
* **Ranks (Base):** Rank 1: `25`, Rank 2: `40`
* **Cooldown:** `60s` (agiAdjust), **Cast Time:** `2.5s`
* **Mechanics:** 8m radius party AoE recovery.

### 4. Over Heal (`overHeal`, Max Rank 2)
* **Cast Site:** `Sheep.cs:26334`
* **Base Formula:** `talAdjust((1 + 0.15 × benedictionLv) × (20 + 30 × sLv))`
* **Ranks (Base):** Rank 1: `50`, Rank 2: `80`
* **Cooldown:** `45s` (agiAdjust), **Cast Time:** `2.0s`
* **Mechanics:** Applies direct heal; excess healing becomes a temporary shield buffer up to `sLv × 100` max HP.

### 5. Revive (`revive`, Max Rank 2)
* **Cast Site:** `Sheep.cs:26864`
* **Base Formula:** `talAdjust((1 + 0.15 × benedictionLv) × (50 × sLv))`
* **Ranks (Base):** Rank 1: `50`, Rank 2: `100`
* **Cooldown:** `180s` (agiAdjust), **Cast Time:** `5.0s`
* **Mechanics:** Revives a fallen ally with recovered HP.

### 6. Revert (`revert`, Max Rank 1)
* **Cast Site:** `Sheep.cs:27371`
* **Cooldown:** `900s` (agiAdjust), **Cast Time:** `0s`
* **Mechanics:** Fully restores self to 100% HP, MP, and KO.

### 7. Holy Light (`holyLight`, Max Rank 2)
* **Cast Site:** `Sheep.cs:27897`
* **Base Formula:** `talAdjust(12 + 12 × sLv)`
* **Ranks (Base):** Rank 1: `24`, Rank 2: `36`
* **Knockdown KO:** `1`
* **Cooldown:** `60s` (agiAdjust), **Cast Time:** `1.5s`
* **Mechanics:** Straight-line piercing holy ray.

### 8. Light Bind (`lightBind`, Max Rank 4)
* **Cast Site:** `Sheep.cs:34255-34555`
* **Multi-Hit Structure:** 7 Hits total
  * Ticks 1–6: `talAdjust(10 + 20 × sLv)` $\rightarrow$ Rank 1: `30`, Rank 4: `90`
  * Tick 7 (Burst): `talAdjust(50 + 50 × sLv)` $\rightarrow$ Rank 1: `100`, Rank 4: `250`
* **Cooldown:** `30s` (agiAdjust), **Cast Time:** `1.5s`, **Root Duration:** `chaAdjust(3 + sLv)`

### 9. Divinity Sword (`divinitySword`, Max Rank 2)
* **Cast Site:** `Sheep.cs:31049`
* **Base Formula:** `talAdjust(10 + 20 × sLv)`
* **Ranks (Base):** Rank 1: `30`, Rank 2: `50`
* **Cooldown:** `45s` (agiAdjust), **Cast Time:** `1.5s`

### 10. Divinity Spear (`divinitySpear`, Max Rank 2)
* **Cast Site:** `Sheep.cs:31786`
* **Base Formula:** `talAdjust(10 + 15 × sLv)`
* **Ranks (Base):** Rank 1: `25`, Rank 2: `40`
* **Cooldown:** `60s` (agiAdjust), **Cast Time:** `1.5s`

### 11. Divinity Axe (`divinityAxe`, Max Rank 1)
* **Cast Site:** `Sheep.cs:36612`
* **Base Formula:** `talAdjust(45)`
* **Cooldown:** `150s` (agiAdjust), **Cast Time:** `2.5s`

### 12. Purifying Tear (`purifyingTear`, Max Rank 1)
* **Cast Site:** `Sheep.cs:35600-36200`
* **Cooldown:** `480s` (agiAdjust), **Cast Time:** `3.0s`
* **Mechanics:** Clears all enemy hate/threat (`removeHate`) in a 40m radius.

### 13. Bless (`bless`, Max Rank 4)
* **Cooldown:** `90s` (agiAdjust), **Duration:** `30s` (chaAdjust)
* **Buff:** `+5/10/15/20` all 8 core stats.

### 14. Feather (`feather`, Max Rank 2)
* **Cooldown:** `18s` (agiAdjust), **Duration:** `15s` (chaAdjust)
* **Buff:** `+10/20` AGI to target.

### 15. All Feather (`allFeather`, Max Rank 2)
* **Cooldown:** `60s` (agiAdjust), **Duration:** `15s` (chaAdjust)
* **Buff:** `+10/20` AGI to entire party.

### 16. Illuminate (`illuminate`, Max Rank 4)
* **Cooldown:** `24s` (agiAdjust), **Duration:** `12s` (chaAdjust)
* **Buff:** Stealth reveal and hit accuracy boost.

### 17. Pacify (`pacify`, Max Rank 2)
* **Cooldown:** `60s` (agiAdjust), **Cast Time:** `1.0s`
* **Debuff:** Lowers target aggression and attack power.

### 18. Sleep (`sleep`, Max Rank 2)
* **Cooldown:** `90s` (agiAdjust), **Cast Time:** `2.0s`, **Duration:** `chaAdjust(10 + 5 × sLv)`

### 19. Lullaby (`lullaby`, Max Rank 1)
* **Cooldown:** `60s` (agiAdjust), **Cast Time:** `1.5s`
* **Mechanics:** AoE sleep singing wave.

### 20. Clear (`clear`, Max Rank 2)
* **Cooldown:** `18s` (agiAdjust), **Cast Time:** `0s`
* **Mechanics:** Cleanses 1 negative status effect from target.

### 21. Cleanse (`cleanse`, Max Rank 1)
* **Cooldown:** `30s` (agiAdjust), **Cast Time:** `0.5s`
* **Mechanics:** Cleanses negative status effects from target.

### 22. All Cleanse (`allCleanse`, Max Rank 1)
* **Cooldown:** `90s` (agiAdjust), **Cast Time:** `1.5s`
* **Mechanics:** Cleanses negative status effects from all party members.

### 23. Seal (`seal`, Max Rank 1)
* **Cooldown:** `12s` (agiAdjust), **Duration:** `60s` (chaAdjust)
* **Mechanics:** Places Red or Blue seal on ground.

### 24. Repel (`repel`, Max Rank 2)
* **Cooldown:** `120s` (agiAdjust), **Duration:** `6s` (chaAdjust)
* **Mechanics:** Spawns a physical deflection barrier.

### 25. Reverse (`reverse`, Max Rank 2)
* **Cooldown:** `240s` (agiAdjust), **Duration:** `3s` (chaAdjust)
* **Mechanics:** Inverts status and damage.

### 26. Soul of Arms (`soulOfArms`, Max Rank 2)
* **Cooldown:** `300s` (agiAdjust), **Cast Time:** `3.0s`
* **Mechanics:** Summons floating divinity weapons that auto-attack with master's stats.

### 27. Eden Sanctuary (`edenSanctuary`, Max Rank 1)
* **Source:** `Sheep_edenSanctuary.cs:165-205`
* **Cooldown:** `240s` (agiAdjust), **Duration:** `12s`
* **Mechanics:** Ground sanctuary pulses every 2s, granting 50% damage reduction (`sanctuary` status).

### 28. World Encarta (`worldEncarta`, Max Rank 1)
* **Source:** `Sheep.cs:38357`
* **Cooldown:** `150s` (agiAdjust), **Duration:** `9s` (chaAdjust)
* **Mechanics:** Grants complete invulnerability barrier.
