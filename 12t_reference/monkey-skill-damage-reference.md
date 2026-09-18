# Monkey — Skill Damage/KO/Rank Reference

Companion to `monkey-skill-reference.md` (Cooldown/Duration, cite that for CD/Duration citations — not re-derived here).
Consolidated ground-truth reference for Monkey skill damage formulas, status profiles, companion/summon scaling, and dependencies verified against `DecompiledSource/Monkey.cs`, `MonkeySkill.cs`, `Monkey_*.cs`, and `CharacterControl.cs`.

---

## 1. Active Skills Summary

| Skill | Max Rank | Cost (Base) | Base Damage / Formula | KO | Hit Count | Key Dependencies & Mechanics |
|---|---|---|---|---|---|---|
| **Combo** (`nAttack`) | 3 | — | `0.5×ATK` (all ranks) | 1 | 2 / 3 / 5 | R1: 2 hits, R2: 3 hits, R3: 3 hits + 3-way spread (5 hits total). Grants +1 SP per hit. |
| **HP Transfer** (`cAttack`) | 4 | [10, 15, 20, 25] HP | None (Utility) | 0 | 1 | Channels HP from Monkey into active summon pet. |
| **Damage Cast** (`damageCast`) | 4 | 50 SP (red) | Buffs next magic cast | 0 | 1 | Triggers Fire Rune check; consumes SP. |
| **Instant Cast** (`instantCast`) | 2 | [16, 24] MP, [16, 24] SP (red) | None (Buff) | 0 | — | Grants instant cast buff for duration. |
| **Fireball** (`fireBall`) | 4 | [9, 13, 17, 21] MP | `talAdjust(20 + 20×sLv)` | 0 | 1 | Single-target magic projectile. Gated by INT for cast time. |
| **Phoenix** (`phoenix`) | 4 | [30, 45, 60, 75] MP | Summon Entity | 0 | — | Spawns Phoenix companion. Uses own 9-stat array (`ownStatsPhoenix`). |
| **Phoenix - Fireball** | 1 | — | `talAdjust(20)` | 0 | 1 | Phoenix automated AI attack. Scales with Phoenix's own TAL; CD scales with Monkey's INT via `rapidFire`. |
| **Phoenix - SkyCrimson** | 1 | 35 MP, 30 SP (red) | `talAdjust(120)` | 5 | 1 | Commanded Phoenix AoE dive attack. |
| **Blazing Arrow** (`blazingArrow`) | 1 | 35 MP, 30 SP (red) | `talAdjust(120)` | 5 | 1 | Ground-target AoE pillar. |
| **Flash Fire** (`flashFire`) | 4 | [12, 16, 20, 24] MP, [12, 16, 20, 24] SP (red) | `talAdjust(15 + 15×sLv)` | 5 | 1 | Cone fire burst. |
| **Ja** (`ja`) | 4 | [15, 30, 45, 60] MP | `talAdjust(25×sLv)` | 0 | 1 | Spawns floating Ja entity. Detonates via command or on expiration. |
| **Ja - Detonate** | 1 | — | `talAdjust(25×sLv)` | 5 | 1 | Commanded manual explosion of Ja. |
| **Runic Flame** (`runicFlame`) | 1 | 30 MP, all SP | `talAdjust(24)` | 0 | Variable | Leaves flame trail while running. Duration = `floor(sp × 0.2)` sec. |
| **World Ignition** (`worldIgnition`) | 2 | [40, 50] MP, [30, 40] SP (red) | `talAdjust(80 + 40×sLv)` | 10 | 1 | Massive radial firestorm. Ignites all targets hit. |
| **Ground Lock** (`groundLock`) | 4 | [12, 16, 20, 24] MP | `talAdjust(25 + 25×sLv)` | 0 | 1 | Earth projectile rooting enemies in area. |
| **Gadina** (`gadina`) | 4 | [30, 45, 60, 75] MP | Main Summon | 0 | — | Spawns Gadina golem mount/companion (`ownStatsGadina`). Base HP/ATK/DEF scale with rank. |
| **Gadina - Normal Attack** | 1 | — | `1.0×Gadina ATK` | 2 | 1 | Automated Gadina melee slam. |
| **Gadina - Planet Breaker** | 1 | 40 MP, 60 SP (red) | Inner: `talAdjust(150)`<br>Outer: `talAdjust(50)` | 10 (Inner)<br>5 (Outer) | 1 | Gadina ground slam with two damage rings (Inner circle 4m, Outer ring 10m). |
| **Gadina - Titanic Earth Pulse** | 1 | 40 MP, 60 SP (red) | `0.35 × Gadina4 Current HP` | 10 | 5 | Sacrifices Gadina4. Gravity pulse expanding 1m to 5m over 5 ticks (max 1999/tick). |
| **Stone Hammer** (`stoneHammer`) | 4 | [12, 20, 28, 36] MP | `talAdjust(20 + 25×sLv)`<br>*(+30 with Stone Sentinel)* | 20 / 30 / 40 / 50<br>*(+10 with Sentinel)* | 1 | Cylinder AoE (radius `1 + 0.5×sLv` m, height 6m). Channel interruptible. |
| **Buiten Hou Hou** (`buiten`) | 4 | [20, 30, 40, 50] MP | Summon Totem | 0 | — | Deploys Buiten totem buffing allies / attacking nearby targets. |
| **Runic Sand** (`runicSand`) | 1 | 30 MP, all SP | `talAdjust(24)` | 0 | Variable | Earth-element trail counterpart to Runic Flame. |
| **Lavu** (`lavu`) | 2 | [35, 45] MP, [30, 40] SP (red) | `talAdjust(30 + 30×sLv)` | 0 | Continuous | Creates quicksand / lava hazard field slowing enemies. |
| **Volcanic Eruption** (`volcanicEruption`)| 1 | 50 MP, 50 SP (red) | `talAdjust(150)` | 10 | 6 | Erupts ground in 6 successive volcanic shocks. |
| **Summon Gaos** (`summonGaos`) | 1 | 100 MP, 50 SP (red) | Ultimate Summon | 0 | — | Deploys Gaos dragon summon (`ownStatsGaos`). |

---

## 2. Deep Mechanic Analyses & Source Citations

### 2.1 Gadina & Titanic Earth Pulse (`monkey_titanicEarthPulse`)
* **Source:** `Monkey.cs:33100–33250`, `Monkey_earthPulse.cs:1–150`.
* **Requirement:** Requires Gadina at Rank 4 (`gadinaLv == 4`). Consumes/sacrifices Gadina immediately upon cast.
* **Damage Mechanics:**
  - Base damage is **NOT** calculated from Monkey's own ATK/TAL.
  - Base formula: `nDamage = Mathf.Clamp(Mathf.FloorToInt(gadina.hp * 0.35f), 1, 1999)`.
  - Fires a straight-line gravity projectile (~15 m/s, ~45m max travel).
  - On first contact, creates an expanding pulse over 5 consecutive ticks with expanding hitboxes:
    - Tick 1: 1m radius
    - Tick 2: 2m radius
    - Tick 3: 3m radius
    - Tick 4: 4m radius
    - Tick 5: 5m radius (fixed 6m cylinder height).
  - Targets caught within 1m of the epicenter suffer all 5 damage ticks.

### 2.2 Stone Hammer (`monkey_stoneHammer`)
* **Source:** `Monkey.cs:33448–33492`, `MonkeySkill.cs:680–720`.
* **Targeting Geometry:** Ground-targeted cylinder AoE centered on landing zone:
  - Radius: `1.0 + 0.5 * sLv` meters (1.5m / 2.0m / 2.5m / 3.0m).
  - Height: 6.0 meters.
* **Base Damage & Scaling:**
  - Base formula: `talAdjust(20 + 25 * sLv)` (Ranks: 45 / 70 / 95 / 120).
  - **Stone Sentinel Capstone Synergy (`hasSkill(443)`):** Adds flat `+30` damage to the base formula across all ranks (75 / 100 / 125 / 150).
* **KO Knockout Pool:**
  - Base KO: `10 + 10 * sLv` (20 / 30 / 40 / 50).
  - **Stone Sentinel Capstone Synergy (`hasSkill(443)`):** Adds flat `+10` KO across all ranks (30 / 40 / 50 / 60).
* **Channeling Vulnerability:**
  - Carries a ~0.8s local animation channel after cast completion. Re-verifies `actionState == "attack"` and `myCommand == "stoneHammer"`. If interrupted (stunned, staggered, moved), cast aborts with 0 damage dealt.

### 2.3 Runic Flame & Fire Rune
* **Source:** `Monkey.cs:12229–12457`, `Monkey_runicFlame.cs:207`.
* **Duration Formula:** Consumes all banked player SP on cast:
  `duration = Mathf.FloorToInt(sp * 0.2f)` seconds.
* **Trail Segment Spawning:** While moving, drops a flame segment every 1.58 units.
  Segment lifetime is governed by caster CHA: `tID = chaAdjust(5f)`.
* **Damage:** `talAdjust(24)` per touch.
* **Fire Rune Passive Hook:**
  - Internal cooldown: 1.0s.
  - Proc roll: `Random(0, 100) < lckAdjust(12)`. At LCK 0, base chance is 12% (rises to ~21% at LCK 100).
  - Grants `4 * fireRuneLv` MP and `4 * fireRuneLv` SP on successful damage triggers.

---

## 3. Server Balance Variations (ToT & TTO)

### Complete skill-detail catalog

The existing Titanic Earth Pulse notes below are retained. This catalog is the complete private-server inventory from the Bible tool. BigBug is the baseline; these values are server-only observations maintained in `12t_projects/bible/index.html:9337-10461`, not decompiled behavior.

#### ToT — Fire branch

- **Instant Cast:** cooldown 240s → 180s; Rank 2 becomes unlimited instant casts during its 12s buff.
- **Fireball:** a hit reduces all A-branch cooldowns by 1s.
- **Phoenix:** cooldown 45s → 60s; can coexist with Gadina; hits reduce A-branch cooldowns by 1s; rebirth becomes guaranteed (100%, still 120s rebirth cooldown) instead of 12–30%.
- **Phoenix Fireball / Rapid Fire / Intense Fire:** Phoenix attack-speed INT scaling 20/30/40% → 40/60/80%; Intense Fire bonus 20/30/40% → 60/80/100% of Monkey `talAdjust(40)`.
- **Sky Crimson:** Intense Fire bonus becomes 60/80/100%; Fire Soul reduces cooldown to 12s.
- **Blazing Arrow:** red SP 48 → 45; Phoenix charges from the caster, can aim until fired, skips mount/skill animation, rebirth becomes 100%, and Fire Soul reduces cooldown to 60s.
- **Flash Fire:** base damage 16/24/32/40 → 8/16/24/32; radius 5m → 6.5m.
- **Ja:** resets Phoenix cooldown on cast.
- **Fire Rune:** proc chance 20% → 45/60/75%; SP/MP restoration 4/4, 8/8, 12/12 → 16/4, 22/6, 28/8.
- **Fire Keep:** maximum stored Fireballs 2 → 3.
- **Instant Blaze:** a 10s activation causes Phoenix Fireball impacts to deal AoE.
- **Fire Soul:** Phoenix stat inheritance 10/20/30/40% → 30/40/50/60%; Sky Crimson / Blazing Arrow cooldowns become 12s / 60s.
- **Fire Avatar:** all potions usable; replace time-charged large Fireball with one on every third normal attack.
- **Blazing Fire:** charge cooldown 6s → 2.5s; forward movement reduced 66%.

#### ToT — Earth, Gadina, and other branch changes

- **Ground Lock:** root 3s → 4s; damage 24/32/40/48 → 20/40/60/80; Second Stone adds 10 first-hit KO and +1s root.
- **Gadina:** cooldown 45s → 60s; Rank 4 KO 20 → 40; attacks 50% faster; can coexist with Phoenix; KO range is limited around Gadina.
- **Gadina normal attack / Titan Sword:** attack interval 4.0s/5.33s → 2.0s/2.67s; Titan Sword ATK 20/40/60 → 40/80/120 and KO 2/3/4 → 6/8/10.
- **Planet Breaker:** pull/damage range +25%; Earth Soul reduces cooldown to 12s.
- **Aegis of Earth:** Gadina DEF 20/35/50 → 30/55/80; Ground Lock duration extension removed.
- **Titanic Earth Pulse:** red SP 60 → 45; damage 35% → 28% Gadina4 HP; projectile speed 15 → 19.95 m/s; charge behavior gains the same warp/aim/no-animation treatment as Blazing Arrow.
- **Buiten Hou Hou:** resets Gadina cooldown on cast.
- **Earth Rune:** proc chance 20% → 45/60/75%; SP/MP restoration 4/4, 8/8, 12/12 → 16/4, 22/6, 28/8.
- **Lavu:** base damage 30/50 → 50/100; entry animation 50% faster; its buff reduces incoming damage 15/25%; cooldown and MP/SP costs reduced.
- **Mike Circle:** becomes a 3s-cooldown active retargetable ally-protection damage/heal command.
- **Summon Soul:** red SP 30 → 10; Gaos Soul +40 ATK/DEF → +40 ATK/AGI/TAL.
- **Auto Instant:** Instant Cast Lv.2 → Lv.4; grants 40% MP reduction, +40 ATK/DEF/VIT/TAL, 1% max HP/s healing, and two C-branch casts.
- **Earth Guard:** Gadina deals surrounding damage/KO for 10s, can move/attack, and cannot be healed.
- **Earth Soul:** Gadina stat inheritance 10/20/30/40% → 30/40/50/60%; Planet Breaker / Titanic Earth Pulse cooldowns become 12s / 60s.
- **Earth Form:** all potions usable; punch animation +20%; immune to physical knockback.
- **Stone Sentinel:** charge cooldown 6s → 5s.
- **Volcanic Eruption:** MP 150 → 100; enemies only; caster can move/use skills after 2s; requirement Fire Rune1/Earth Rune1 → Ja1/Buiten Hou Hou1.
- **Summon Gaos:** MP 300 → 150; no ally burn; Gaos Soul +40 ATK/DEF → +40 ATK/AGI/TAL.

#### TTO changes

- **Titanic Earth Pulse:** animation 4s → 2s; structure damage is 2×; pulse hitboxes 1/2/3/4m → 3/4/5/6m; projectile hitbox 0.25m² → 0.5m².
- **Fire Soul / Earth Soul:** each adds one summon slot.
- **Fire Avatar / Earth Form:** normal skill casting is allowed while transformed.

The BigBug-side skill formulas, status logic, and geometry remain documented in the preceding sections and the cited decompiled source. Server-only changes above should be revised in step with the Bible schema.

### Gadina - Titanic Earth Pulse
* **Tailstopia Online (TTO):**
  - Animation reduced from 4.0s to 2.0s.
  - Structure damage multiplier increased to `2.0×`.
  - Detonation hitboxes expanded to 3m / 4m / 5m / 6m.
* **Tales of Tail (ToT):**
  - SP cost reduced from 60 to 45 SP.
  - Projectile speed increased by +33% (15 m/s → 19.95 m/s).
  - Damage coefficient reduced by -20% (from 35% HP to 28% HP of Gadina4).
  - Gadina automatically warps to Monkey and tracks facing angle until fired.
