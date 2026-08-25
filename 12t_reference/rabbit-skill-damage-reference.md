# Rabbit — Skill Damage/Rank Reference

Companion to `rabbit-skill-reference.md` (cooldown/duration/maxRank — trusted as-is below, not re-derived here except where flagged). This doc backs the rank-selector + damage/heal-formula fields (`maxRank`, per-rank `cd`/`castTime`/`duration` arrays, `dmg`, `dmgDep`/`dmgMultDep`, `atkCoeff`, `hitCount`, `dmgGroups`) added to Rabbit's `SKILLS` entries in `12t_projects/player-reference-tool/index.html`, 2026-08-25 — the 3rd class built out beyond Penguin (1st) and Mole (2nd). Researched via decompiled source analysis of `DecompiledSource/Rabbit.cs`, `DecompiledSource/RabbitSkill.cs`, `DecompiledSource/RabbitSkill_eng.cs`, and companion files (`Rabbit_potion.cs`, `Rabbit_acidicField.cs`, `Rabbit_healingField.cs`, `Rabbit_stickyGum.cs`). All citations are `file:line` against `DecompiledSource/Rabbit.cs` unless noted.

---

## Summary table

| Skill | maxRank | cd/castTime/duration rank-variance | dmg (`sLv`=rank) | dmgNote | dmgDep / dmgMultDep | hitCount |
|---|---|---|---|---|---|---|
| statScan | 1 | none | no dmg — reveals target stats | — | — | — |
| bounce | 2 | none | `ATK`, KO=20 (`Rabbit.cs:21652`) | melee leap attack; if `fromTheAbove5` owned, triggers ground stomp | **fromTheAbove5** (stomp effect) | 1 |
| maimShot | 4 | none | `0.5×ATK + talAdjust(5×sLv)` (`Rabbit.cs:23280`) | restores +1 SP; applies `"maim"` status (`Damage.getDebuff(3, cha, target.cha)`) | **kneeShot5** (hasSkill 402, +20 to talAdjust base) | 1 |
| mix | 4 | none | no direct dmg — creates HP/SP/MP potion pickups (`Rabbit_potion.cs`) | HP potion heals `20×sLv` (`[20, 40, 60, 80]`) | **extraPotion5** (hasSkill 412, `+0.3×LV` HP heal) | — |
| shake | 3 | none | no direct dmg — creates compound potions on ground (lifetime 60s) | — | — | — |
| miracleBlend | 1 | none | no direct dmg — spawns miracle potion (`Rabbit_potion.cs:438`) | status `"miracleDrop"` duration = `chaAdjust(4 + 2×num)` (6/8/10/12s), +50 all stats | **alchemistLab** (hasSkill 231-234, ranks 1..4, +2s/rank) | — |
| stickyGum | 2 | none | no dmg — slows movement in radius `1.5m / 2.5m` (`Rabbit_stickyGum.cs:140`) | status `"sticky"` (lv `sLv`) for `chaAdjust(12)` | — | — |
| acidicField | 2 | none | `10×sLv` flat true effect damage per tick (`[10, 20]`) (`Rabbit_acidicField.cs:198`) | penetrating (direct `RPC_AddEffectDamage`), pulses every 2s (6 ticks over 12s) + `"acid"` debuff | — | 6 |
| immuneShot | 1 | none | no dmg — cures debuffs (`"remedy"`), grants `"immunity"` (`Rabbit.cs:28287`) | duration `chaAdjust(15 + 5×[medEnhanceLv+1])` (20s to 35s) | **medicalEnhancement** (ranks 0..3, +5s/rank) | — |
| boostShot | 1 | none | no dmg — heals `100×(1+medEnhanceLv)` HP (`100–400`) (`Rabbit.cs:28346`) | grants `"boost"` for `chaAdjust(30 + 5×[medEnhanceLv+1])` (35s to 50s) | **medicalEnhancement** (ranks 0..3, +5s/rank, +100 HP/rank) | — |
| heatShot | 1 | none | no dmg — grants `"heat"` status (`Rabbit.cs:28400`) | duration `chaAdjust(30 + 5×[medEnhanceLv+1])` (35s to 50s) | **medicalEnhancement** (ranks 0..3, +5s/rank) | — |
| lifeShot | 1 | none | no dmg — grants `"autoLife"` revive buff (`Rabbit.cs:295`) | duration `chaAdjust(60 + 5×[medEnhanceLv+1])` (65s to 80s) | **medicalEnhancement** (ranks 0..3, +5s/rank) | — |
| rapidTrance | 1 | none | no dmg — grants `"rapidTrance"` action speed buff for `chaAdjust(12)` (`Rabbit.cs:28846`) | — | — | — |
| gorgonShot | 2 | none | `talAdjust(50×sLv)` (`[50, 100]`) (`Rabbit.cs:29671`) | petrifies target (`"petrify"`) for `3×sLv+3`s (`[6s, 9s]` contested) | — | 1 |
| gilShot | 4 | none | `(0.6 + 0.1×sLv)×ATK + talAdjust(10×sLv)` (`Rabbit.cs:30399`) | KO=`sLv+1` (`[2, 3, 4, 5]`), restores +1 SP | **diamondShot5** (hasSkill 403, +20 to talAdjust base) | 1 |
| backpack | 2 | none | `0.5×sLv×Weight` (`Rabbit.cs:31593`) | KO=`10×sLv` (`[10, 20]`) | **bigBag5** (hasSkill 423, adds `+0.25×ItemCount`) | 1 |
| fourShot | 2 | none | `0.5×ATK + talAdjust(15×sLv)` per shot (`Rabbit.cs:32374`) | 4 rapid shots, KO=1/hit | **tenShot5** (hasSkill 433, +10 to talAdjust base) | 4 |
| circleShot | 2 | none | `0.5×ATK + talAdjust(15×sLv)` (`Rabbit.cs:32732`) | 360-degree AoE burst (radius `8×rangeMod`), KO=1 | **tenShot5** (hasSkill 433, +10 to talAdjust base) | 1 |
| mall | 2 | none | no dmg — sets up mobile player shop vendor | — | — | — |
| truceTrading | 2 | none | no dmg — invulnerable trading zone | — | — | — |
| shootingArray | 2 | none | 3 hits of `0.5×ATK + talAdjust(15×sLv)` + 1 finisher of `1.0×ATK + talAdjust(30×sLv)` (`Rabbit.cs:35331`, `:35630`) | modeled via `dmgGroups` (4 hits total), KO=1/hit | — | 4 (`dmgGroups`) |
| millionaire | 2 | none | `ceil(0.005×sLv×min(Gil+Jil, 99999))` (`Rabbit.cs:37212`) | scales with gold holdings (max 500 at rank 1, max 1000 at rank 2), KO=1 | — | 1 |
| healingField | 1 | none | no dmg — area healing field, radius 12m (`Rabbit_healingField.cs:189`) | heals **70 flat HP** per tick, pulses every 2s (6 ticks over 12s) | — | 6 |
| diamondShot | 1 | none | **1000 flat true effect damage** (`Rabbit.cs:38322`) | direct `RPC_AddEffectDamage`, penetrating vs monsters | — | 1 |
| tenShot | 1 | none | `0.5×ATK + talAdjust(60)` per bullet (`Rabbit.cs:39499`, `:39552`) | 10 bullets barrage (10 hits total), KO=1/hit | — | 10 |
| extravagance | 1 | none | no dmg — spends `1% Gil` (capped at 512) to grant `+GilSpent` ATK buff for `chaAdjust(6)` (`Rabbit.cs:39902`, `:40056`) | — | **skillBargain5** (hasSkill 413, reduces cost by 40%) | — |
| contract | 1 | none | no dmg — summons 2 Black Panther bodyguards for 300s (`Rabbit.cs:40382`) | — | — | — |

---

## Detailed Citations & Mechanics Notes

### 1. Maim Shot (`maimShot1-4`)
* **Source:** `Rabbit.cs:23280` inside `$RPC_maimShot$26971`
* **Formula:** `(int)(0.5f * atk + talAdjust(sLv * 5 + (hasSkill(402) ? 20 : 0)))`
* **KO:** Passed `$hitKo$26980` (defaults to 0).
* **On Hit:** Restores `+1 SP` (`Rabbit.cs:23354`) and applies `"maim"` status for duration `Damage.getDebuff(3f, caster.cha, target.cha)`.
* **Dependency:** `rab_kneeShot5` (Skill ID 402, `RabbitSkill.cs:3215`) adds a flat `+20` inside the `talAdjust` base.

### 2. Four Shot (`fourShot1-2`)
* **Source:** `Rabbit.cs:32374` inside `$RPC_fourShot$27214`
* **Formula:** `(int)(0.5f * atk + talAdjust(15 * sLv + (hasSkill(433) ? 10 : 0)))` per shot.
* **Hit Count:** 4 shots in rapid sequence.
* **KO:** 1 per hit.
* **Dependency:** `rab_tenShot5` (Skill ID 433, `RabbitSkill.cs:3303`) adds `+10` to `talAdjust` base.

### 3. Circle Shot (`circleShot1-2`)
* **Source:** `Rabbit.cs:32732` inside `$RPC_circleShot$27232`
* **Formula:** `(int)(0.5f * atk + talAdjust(15 * sLv + (hasSkill(433) ? 10 : 0)))`
* **Radius:** `8 * rangeMod` (1 pulse).
* **KO:** 1.
* **Dependency:** Shares `rab_tenShot5` (+10 to talAdjust base).

### 4. Shooting Array (`shootingArray1-2`)
* **Source:** `Rabbit.cs:35331` (ticks 1–3) and `Rabbit.cs:35630` (final tick) inside `$RPC_shootingArray$27293`
* **Ticks 1–3:** `(int)(0.5f * atk + talAdjust(15 * sLv))` (3 hits).
* **Tick 4 (Finisher):** `atk + talAdjust(30 * sLv)` (1 hit).
* **Total Hits:** 4 hits. Modeled with `dmgGroups`.

### 5. Gil Shot (`gilShot1-4`)
* **Source:** `Rabbit.cs:30399` inside `$RPC_gilShot$27155`
* **Formula:** `(int)((0.6f + 0.1f * sLv) * atk + talAdjust(10 * sLv + (hasSkill(403) ? 20 : 0)))`
  * Rank 1: `0.7×ATK + talAdjust(10 + dep)`
  * Rank 2: `0.8×ATK + talAdjust(20 + dep)`
  * Rank 3: `0.9×ATK + talAdjust(30 + dep)`
  * Rank 4: `1.0×ATK + talAdjust(40 + dep)`
* **KO:** `sLv + 1` (2, 3, 4, 5).
* **On Hit:** Restores `+1 SP`.
* **Dependency:** `rab_diamondShot5` (Skill ID 403, `RabbitSkill.cs:3271`) adds `+20` inside `talAdjust`.

### 6. Backpack (`backpack1-2`)
* **Source:** `Rabbit.cs:31593` inside `$RPC_backpack$27175`
* **Formula:** `0.5f * sLv * InventoryWeight + (useBigBag ? 0.25f * InventoryCount : 0)`
* **KO:** `10 * sLv` (10 at rank 1, 20 at rank 2).
* **Dependency:** `rab_bigBag5` (Skill ID 423, `RabbitSkill.cs:3293`).

### 7. Millionaire (`millionaire1-2`)
* **Source:** `Rabbit.cs:37212` inside `$RPC_millionaire$27336`
* **Formula:** `Mathf.CeilToInt(0.005f * sLv * Mathf.Clamp(PlayerData.Gil + PlayerData.Jil, 0, 99999))`
  * Rank 1: `0.005 * Money` (Max 500 base damage).
  * Rank 2: `0.010 * Money` (Max 1000 base damage).
* **KO:** 1.

### 8. Diamond Shot (`diamondShot`)
* **Source:** `Rabbit.cs:38322` inside `$RPC_diamondShot$27367`
* **Formula:** `RPC_AddEffectDamage(403, 1000, 0, 0, ...)`
* **Mechanic:** Flat 1,000 true effect damage (penetrating, bypasses defAdjust).

### 9. Ten Shot (`tenShot`)
* **Source:** `Rabbit.cs:39499`, `:39552` inside `$RPC_tenShot$27386`
* **Formula:** `(int)(0.5f * atk + talAdjust(60))` per bullet.
* **Hit Count:** 10 bullets (5 from left launcher, 5 from right launcher).
* **KO:** 1 per hit.

### 10. Acidic Field (`acidicField1-2`)
* **Source:** `Rabbit_acidicField.cs:198`, `Rabbit.cs:27128`
* **Formula:** `RPC_AddEffectDamage(242 + sLv, 10 * sLv, 0, 0, ...)`
* **Duration & Pulse Cadence:** `chaAdjust(12)` seconds total duration, pulsing once every 2.0s (`Rabbit_acidicField.cs:131`).
* **Hit Count Scaling:** Dynamic pulse count $= \lfloor\text{chaAdjust}(12) / 2\rfloor$ (6 pulses at base CHA, increasing with higher CHA stat).
* **Damage:** 10 flat true effect damage at rank 1, 20 at rank 2 per tick (penetrating, bypasses enemy DEF and damageMod).
* **Status:** Applies `"acid"` status.

### 11. Healing Field (`healingField1`)
* **Source:** `Rabbit.cs:37831`, `Rabbit_healingField.cs:189`
* **Formula:** `RPC_AddHeal(442, 70, 0, 0, ...)`
* **Duration & Pulse Cadence:** `chaAdjust(12)` seconds total duration, pulsing once every 2.0s.
* **Hit Count Scaling:** Dynamic pulse count $= \lfloor\text{chaAdjust}(12) / 2\rfloor$ (6 pulses at base CHA $\rightarrow$ 420 total HP, scaling with CHA).
* **Healing Output:** 70 flat HP restored per pulse to all allies in a 12m radius.
