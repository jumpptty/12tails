# Whale — Skill Damage & Mechanics Reference

Verified from decompiled source (`DecompiledSource/Whale.cs`, `DecompiledSource/WhaleSkill.cs`, `DecompiledSource/CharacterControl.cs`, and companion scripts) for the player-reference-tool (`12t_projects/player-reference-tool/index.html`).

---

## 1. Summary of Whale Mechanics

- **Resource System (MP, Red SP, Blue SP)**:
  - **MP (Mana Points)**: Consumed on cast by water/shamanic spells.
  - **Red SP (Stamina / Rage)**: `cSP < 0` in decompiled source (`GameGui.cs:37782`). Requires and **consumes** that amount of SP on cast (rendered in-game as Red SP: `new Color(1f, 0.2f, 0.2f)`). Almost all Whale weapon swings and physical maneuvers consume Red SP.
  - **Blue SP (Combo / Action Requirement)**: `cSP > 0` in decompiled source (`GameGui.cs:37609`). Requires minimum SP threshold to cast, but **does not consume SP** (rendered in-game as Blue SP: `new Color(0.2f, 0.6f, 1f)`). Only `whale_rejuvenate` uses Blue SP threshold at Ranks 3–4 (12 Blue SP).
- **Physical & Shield-Based Damage Scaling**:
  - **ATK Scaling**: `0.5 × ATK` on `whale_sweep`, `whale_javelin`, `whale_peninsulaImpale`, and `whale_peninsulaRound`; `0.7 × ATK` on `whale_bowlingWhale`; `1.0 × ATK` on `whale_grandTide`; and `0.2 × ATK` on `whale_12thKingdomKnight`.
  - **DEF Scaling (Unique to Whale)**:
    - `whale_shieldRush`: `Floor(0.5 × sLv × DEF) + talAdjust(10 × sLv)`.
    - `whale_flyingShield`: `Floor(0.5 × sLv × DEF) + talAdjust(10 × sLv)`.
    - `whale_homingShield`: `0.5 × DEF + talAdjust(20)`.
  - **Weight Scaling (Whale Wave & Hydro Blast)**:
    - `whale_whaleWave`: Ground smash dealing `talAdjust(WhaleWeight × (0.5 + 0.5×sLv))` scaled by distance from impact (100 / 150 TAL at base 100 weight).
    - `whale_hydroBlast`: Vertical water geyser dealing `talAdjust(10×sLv + 10) + TargetWeight`.
- **Healing & Protective Bubble Mechanics**:
  - `whale_rejuvenate`: Periodic regeneration ticking 5 times over 18s (every 4s). Each tick restores `6×sLv + 6 + Floor(0.004 × sLv × TargetMaxHP)`.
  - `whale_revitalize`: Casts Rejuvenate Rank 3 on all allies within 12m radius, ticking 5 times for `24 + Floor(0.012 × TargetMaxHP)`.
  - `whale_bubbleShield`: Absorbs 50% of incoming damage up to `30 + 10×sLv` HP. When expired (12s) or broken, explodes in an 8m AoE dealing `talAdjust(10×sLv + 20)` magic damage.
  - `whale_bubbleBurst`: Passively adds +1 effective rank and +20 TAL burst damage to Bubble Shield; active trigger detonates all shields immediately.
  - `whale_salvation`: Grants 100% damage invulnerability to all allies in range for `chaAdjust(2×sLv + 2)` seconds (4s at R1, 6s at R2).
- **Passive Skill Hooks & Dependencies**:
  - **Knight of the Deep** (`whale_knightOfTheDeep1`, single-rank passive): Reduces weapon-skill cooldowns by skill-specific flat amounts:
    - Sweep: -10s (30s → 20s)
    - Javelin: -10s (30s → 20s)
    - Shield Rush: -15s (45s → 30s)
    - Flying Shield: -15s (45s → 30s)
    - Peninsula Impale: -30s (90s → 60s)
    - Peninsula Round: -40s (120s → 80s)
    - Homing Shield: -40s (120s → 80s)
  - **Reduced Cast** (`whale_reducedCast1`, single-rank passive): Halves base cast time (post-multiply `× 0.5`) across all 8 cast-bar spells (`bubbleShield`, `heavyWeight`, `hydroBlast`, `rejuvenate`, `callToArm`, `salvation`, `megalodon`, `revitalize`).
  - **Wonder Belly** (`whale_wonderBelly1`, single-rank passive): Adds +3s base duration to `whale_swallow`.

---

## 2. Whale Skill Reference Table

| Skill ID | Name | Max Rank | Cost (Base) | Cooldown (Base) | Cast Time (Base) | Duration (Base) | Formula / Effect | KO | Notes |
| :--- | :--- | :---: | :---: | :---: | :---: | :---: | :--- | :---: | :--- |
| `whale_sweep` | Sweep | 2 | [0, 10] MP, [12, 8] SP (red) | 30s | 0s | — | `0.5×ATK + talAdjust(5 + 5×sLv)` | 2 | 2 hits. Each hit deals 0.5×ATK + talAdjust(5 + 5×sLv), KO=2 per hit. Knight of the Deep reduces CD by -10s. |
| `whale_javelin` | Javelin | 2 | 10 MP, [8, 12] SP (red) | 30s | 0s | — | `0.5×ATK + talAdjust(10×sLv)` | 1 | Pierces enemies in a straight line dealing 0.5×ATK + talAdjust(10×sLv), KO=1, applying puncture. Knight of the Deep reduces CD by -10s. |
| `whale_honor` | Honor | 4 | [10, 15, 20, 25] MP, 15 SP (red) | 60s | 0s | 12s | `+10×sLv ATK/DEF/CHA` | — | Grants honor to all allies in 15m radius, adding +10×sLv to ATK, DEF, and CHA for 12s (`chaAdjusted`). Taunts enemies in 18+6×sLv meters. |
| `whale_shieldRush` | Shield Rush | 2 | 0 MP, [15, 18] SP (red) | 45s | 0s | — | `Floor(0.5×sLv×DEF) + talAdjust(10×sLv)` | 10×sLv | Charging shield slam dealing 0.5×sLv×DEF + talAdjust(10×sLv), knocking targets down with KO=10×sLv. Knight of the Deep reduces CD by -15s. |
| `whale_flyingShield`| Flying Shield | 2 | 0 MP, [16, 20] SP (red) | 45s | 0s | — | `Floor(0.5×sLv×DEF) + talAdjust(10×sLv)` | 10×sLv | Throws boomerang shield dealing Floor(0.5×sLv×DEF) + talAdjust(10×sLv), KO=10×sLv to all targets in its path. Knight of the Deep reduces CD by -15s. |
| `whale_homingShield`| Homing Shield | 1 | 0 MP, 24 SP (red) | 120s | 0s | 3s | `0.5×DEF + talAdjust(20)` | 10 | Multi-hit homing projectile dealing 0.5×DEF + talAdjust(20), KO=10 per hit. Imposes 3s noShield status. Knight of the Deep reduces CD by -40s. |
| `whale_swallow` | Swallow | 2 | 0 MP, [10, 15] SP (red) | 90s | 0s | Contested (12s base) | Utility / Disable | — | Pulls target (9m / 15m). Swallows smaller target, disabling it and adding 50% of its weight to Whale for 12s base (`chaAdjusted`, contested, +3s with Wonder Belly). |
| `whale_gobbleUp` | Gobble Up | 1 | 0 MP, 5 SP (red) | 60s | 0s | — | `talAdjust(30)` | 15 | Requires swallowed target in mouth. Spits target out dealing talAdjust(30), KO=15. |
| `whale_peninsulaImpale` | Peninsula Impale | 2 | 0 MP, [18, 24] SP (red) | 90s | 0s | — | `6 × [0.5×ATK + talAdjust(5×sLv + 5)]` | 1 | 6 strikes. Each strike deals 0.5×ATK + talAdjust(5×sLv + 5), KO=1. Knight of the Deep reduces CD by -30s. |
| `whale_peninsulaRound` | Peninsula Round | 2 | 0 MP, [20, 25] SP (red) | 120s | 0s | — | `5 × [0.5×ATK + talAdjust(5×sLv + 5)]` | 1 | 5 spins dealing 0.5×ATK + talAdjust(5×sLv + 5), KO=1 each. Redirects incoming projectiles. Knight of the Deep reduces CD by -40s. |
| `whale_12thKingdomKnight` | 12th Kingdom Knight | 2 | 0 MP, [45, 60] SP (red) | 600s | 0s | 60s | `0.2×ATK + talAdjust(5×sLv)` | 1 | Summons 4 Kingdom Knights for 60s. Each knight attacks dealing 0.2×ATK + talAdjust(5×sLv), KO=1. |
| `whale_bubbleShield`| Bubble Shield | 4 | [6, 8, 10, 12] MP, 0 SP | 30s | 4.5s | 12s | `talAdjust(10×sLv + 20)` (Burst) | — | Bubble shield absorbs 50% damage up to 30+10×sLv HP. Explodes upon breaking or after 12s dealing talAdjust(10×sLv + 20) in 8m AoE. Reduced Cast halves cast time. |
| `whale_heavyWeight` | Heavy Weight | 2 | [10, 14] MP, 0 SP | 60s | 4s | Contested (15s base) | `+15×sLv Weight, -sLv Run Speed` | — | Target weight increased by 15×sLv and run speed reduced by sLv for 15s base (`chaAdjusted`, contested). Reduced Cast halves cast time. |
| `whale_hydroBlast` | Hydro Blast | 4 | [8, 12, 16, 20] MP, 0 SP | 60s | 4.5s | — | `talAdjust(10×sLv + 10) + TargetWeight` | sLv | Launches target into the air dealing talAdjust(10×sLv + 10) + TargetWeight, KO=sLv. Reduced Cast halves cast time. |
| `whale_rejuvenate` | Rejuvenate | 4 | [10, 15, 20, 25] MP, [0, 0, 12, 12] SP (blue) | 90s | 5.5s | 18s | `5 ticks × [6×sLv + 6 + Floor(0.004×sLv×MaxHP)]` | 0 | Heals target every 4s for 18s (5 ticks total). Each tick heals 6×sLv + 6 + Floor(0.004×sLv×TargetMaxHP). Reduced Cast halves cast time. |
| `whale_whaleWave` | Whale Wave | 2 | 0 MP, [12, 16] SP (red) | 60s | 0s | — | `talAdjust(WhaleWeight × (0.5 + 0.5×sLv))` | 1-3 | Ground smash AoE (6m radius). Deals talAdjust(WhaleWeight × (0.5 + 0.5×sLv)) scaled by distance (100 / 150 TAL at base 100 weight). |
| `whale_malStorm` | Mal Storm | 2 | 0 MP, [18, 24] SP (red) | 60s | 0s | — | `4 × talAdjust(20×sLv + 10)` | 1 | Storm AoE (8m radius). 4 lightning strikes, each dealing talAdjust(20×sLv + 10), KO=1. |
| `whale_callToArm` | Call To Arm | 1 | 15 MP, 0 SP | 120s | 5s | — | `talAdjust(30)` | 10 | Teleports to the ally with lowest HP, releasing a shockwave that deals talAdjust(30), KO=10, Hate=10. Reduced Cast halves cast time. |
| `whale_salvation` | Salvation | 2 | [24, 36] MP, 0 SP | 240s | 5s | [4, 6]s | 100% Invulnerability | — | Grants 100% damage invulnerability to all allies within area for chaAdjust(2×sLv + 2) seconds (4s / 6s). Reduced Cast halves cast time. |
| `whale_megalodon` | Megalodon | 2 | [30, 45] MP, [25, 35] SP (red) | 240s | 8s | — | `2 × talAdjust(100×sLv + 100)` | 1 | Ancient leviathan bites twice dealing talAdjust(100×sLv + 100) per bite (400 / 600 TAL total), KO=1 each. Reduced Cast halves cast time. |
| `whale_bubbleBurst` | Bubble Burst | 1 | Free (0 MP, 0 SP) | 60s | 0s | — | Detonate Shields | — | Passively adds +1 effective rank and +20 TAL burst to Bubble Shield. Active: instantly detonates all active Bubble Shields. |
| `whale_revitalize` | Revitalize | 1 | 60 MP, 0 SP | 180s | 6s | 18s | `5 ticks × [24 + 1.2% Max HP]` | 0 | Casts Rejuvenate Rank 3 on all allies in 12m radius, healing 24 + Floor(0.012×MaxHP) every 4s for 18s (5 ticks). Reduced Cast halves cast time. |
| `whale_bowlingWhale`| Bowling Whale | 1 | 0 MP, 25 SP (red) | 180s | 0s | — | `0.7×ATK + talAdjust(35)` | 1 | Curls into a ball and rolls through enemies dealing 0.7×ATK + talAdjust(35), KO=1, knocking targets away. |
| `whale_grandTide` | Grand Tide | 1 | 30 MP, 20 SP (red) | 300s | 0s | Channeled | `1.0×ATK + talAdjust(200)` (per tick) | 0 | Channeled tsunami sweeping forward. Drains 10 MP and 20 SP (10 SP with Revised Skill) per sec, dealing 1.0×ATK + talAdjust(200) per tick. |

---

## 3. Verified Code Citations

### 3.1 Sweep (`Whale.cs:20601–20610`, `Whale.cs:22879–22883`)
```csharp
case 1:
    this.mChar.cMp = ((this.skillSlot[0] != 0) ? 10 : 0);
    this.mChar.cSp = ((this.skillSlot[0] != 0) ? -8 : -12);
    this.mChar.addTimeOut(0, (float)(30 - (this.hasSkill(115) ? 10 : 0)));
    this.RPC_sweep(base.transform.position, this.skillSlot[0] + 1);
```
Damage dealing (`Whale.cs:22879–22883`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(5 + 5 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 2, 0, 1, 0, false, 0);
```

### 3.2 Javelin (`Whale.cs:20623–20632`, `Whale.cs:22960–22965`)
```csharp
case 2:
    this.mChar.cMp = 10;
    this.mChar.cSp = ((this.skillSlot[1] != 0) ? -12 : -8);
    this.mChar.addTimeOut(1, (float)(30 - (this.hasSkill(115) ? 10 : 0)));
    this.RPC_javelin(vector, this.skillSlot[1] + 1);
```
Damage dealing (`Whale.cs:22960–22965`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(10 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
characterControl.addStatus("puncture", this.mChar.chaAdjust(12f), 1, true);
```

### 3.3 Shield Rush (`Whale.cs:20658–20668`, `Whale.cs:23113–23118`)
```csharp
case 4:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[3] != 0) ? -18 : -15);
    this.mChar.addTimeOut(3, (float)(45 - (this.hasSkill(115) ? 15 : 0)));
    this.RPC_shieldRush(this.skillSlot[3] + 1);
```
Damage dealing (`Whale.cs:23113–23118`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(10 * sLv)));
num += (int)((float)this.mChar.def * (0.5f * (float)sLv));
damage.hit(characterControl, num, 10 * sLv, 0, 1, 0, false, 0);
```

### 3.4 Flying Shield (`Whale.cs:20677–20687`, `Whale_flyingShield.cs:51–56`)
```csharp
case 5:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[4] != 0) ? -20 : -16);
    this.mChar.addTimeOut(4, (float)(45 - (this.hasSkill(115) ? 15 : 0)));
    this.RPC_flyingShield(vector, this.skillSlot[4] + 1);
```
Damage dealing (`Whale_flyingShield.cs:51–56`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust((float)(10 * this.sLv)));
num += (int)((float)this.mWhale.mChar.def * (0.5f * (float)this.sLv));
damage.hit(characterControl, num, 10 * this.sLv, 0, 1, 0, false, 0);
```

### 3.5 Homing Shield (`Whale.cs:20696–20706`, `Whale_homingShield.cs:105–109`)
```csharp
case 6:
    this.mChar.cMp = 0;
    this.mChar.cSp = -24;
    this.mChar.addTimeOut(5, (float)(120 - (this.hasSkill(115) ? 40 : 0)));
    this.RPC_homingShield(this.mTarget.transform.position, this.skillSlot[5] + 1);
```
Damage dealing (`Whale_homingShield.cs:105–109`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust(20f));
num += (int)((float)this.mWhale.mChar.def * 0.5f);
damage.hit(characterControl, num, 10, 0, 1, 0, false, 0);
characterControl.addStatus("noShield", this.mWhale.mChar.chaAdjust(3f), 1, true);
```

### 3.6 Peninsula Impale (`Whale.cs:20743–20753`, `Whale.cs:23253–23258`)
```csharp
case 9:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[8] != 0) ? -24 : -18);
    this.mChar.addTimeOut(8, (float)(90 - (this.hasSkill(115) ? 30 : 0)));
    this.RPC_peninsulaImpale(this.skillSlot[8] + 1);
```
Damage dealing (`Whale.cs:23253–23258`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(5 + 5 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.7 Peninsula Round (`Whale.cs:20762–20772`, `Whale.cs:23293–23298`)
```csharp
case 10:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[9] != 0) ? -25 : -20);
    this.mChar.addTimeOut(9, (float)(120 - (this.hasSkill(115) ? 40 : 0)));
    this.RPC_peninsulaRound(this.skillSlot[9] + 1);
```
Damage dealing (`Whale.cs:23293–23298`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(5 + 5 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.8 Whale Wave (`Whale.cs:20888–20898`, `Whale.cs:23447–23454`)
```csharp
case 16:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[15] != 0) ? -16 : -12);
    this.mChar.addTimeOut(15, 60f);
    this.RPC_whaleWave(this.skillSlot[15] + 1);
```
Damage dealing (`Whale.cs:23447–23454`):
```csharp
num = this.mChar.talAdjust((float)this.mChar.weight * (0.5f + 0.5f * (float)sLv));
num = (int)((float)num * (1f - num2 / 6f));
num = this.mChar.dmgAdjust((float)num);
damage.hit(characterControl, num, UnityEngine.Random.Range(1, 4), 0, 1, 0, false, 0);
```

### 3.9 Rejuvenate (`Whale.cs:20857–20875`, `Whale.cs:23707–23712`, `CharacterControl.cs:9123–9136`)
```csharp
case 15:
    this.mChar.cMp = 10 + 5 * this.skillSlot[14];
    this.mChar.cSp = ((this.skillSlot[14] <= 1) ? 0 : 12);
    this.mChar.addTimeOut(14, 90f);
    base.StartCoroutine(this.DisplayCastBar(5.5f * (this.hasSkill(137) ? 0.5f : 1f)));
    this.RPC_rejuvenate(characterControl, this.skillSlot[14] + 1);
```
Status effect tick in `CharacterControl.cs:9123–9136`:
```csharp
case "rejuvenate":
    num = 6 * this.statusLevel[i] + 6;
    num += (int)((float)this.mhp * (0.004f * (float)this.statusLevel[i]));
    this.hp += num;
    this.RPC_AddHeal(num);
```

### 3.10 Megalodon (`Whale.cs:20947–20959`, `Whale_megalodon.cs:81–85`)
```csharp
case 20:
    this.mChar.cMp = 30 + 15 * this.skillSlot[19];
    this.mChar.cSp = ((this.skillSlot[19] != 0) ? -35 : -25);
    this.mChar.addTimeOut(19, 240f);
    base.StartCoroutine(this.DisplayCastBar(8f * (this.hasSkill(137) ? 0.5f : 1f)));
    this.RPC_megalodon(this.mTarget.transform.position, this.skillSlot[19] + 1);
```
Damage dealing (`Whale_megalodon.cs:81–85`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust((float)(100 + 100 * this.sLv)));
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.11 Bowling Whale (`Whale.cs:20986–20996`, `Whale.cs:23851–23856`)
```csharp
case 23:
    this.mChar.cMp = 0;
    this.mChar.cSp = -25;
    this.mChar.addTimeOut(22, 180f);
    this.RPC_bowlingWhale(vector, 1);
```
Damage dealing (`Whale.cs:23851–23856`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust(35f));
num += (int)((float)this.mChar.atk * 0.7f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.12 Grand Tide (`Whale.cs:20999–21008`, `Whale_grandTide.cs:93–98`)
```csharp
case 24:
    this.mChar.cMp = 30;
    this.mChar.cSp = -20;
    this.mChar.addTimeOut(23, 300f);
    this.RPC_grandTide(1);
```
Damage dealing (`Whale_grandTide.cs:93–98`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust(200f));
num += (int)((float)this.mWhale.mChar.atk * 1f);
damage.hit(characterControl, num, 0, 0, 1, 0, false, 0);
```
Per-second drain (`Whale_grandTide.cs:72–79`):
```csharp
this.mWhale.mChar.cMp = 10;
this.mWhale.mChar.cSp = (this.mWhale.hasSkill(126) ? -10 : -20);
```
