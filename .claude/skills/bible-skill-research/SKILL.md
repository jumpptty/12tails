---
name: bible-skill-research
description: "Use when researching a 12 Tails skill from DecompiledSource for the Bible (the /sd workflow): dead-code verification gate, active and passive source extraction, the review table, approval gates, and summon / companion / mercenary / mount card rules."
---

# Bible: skill research and verification pipeline

Part of the Bible rulebook (core rules: [12t_projects/bible/CLAUDE.md](../../../12t_projects/bible/CLAUDE.md)).

## Skill Verification & Quality Assurance Pipeline

### 3.0. Dead Code Verification Gate (checked before declaring ANYTHING dead/unwired)

Never call a mechanic dead, unwired or "not in code" from one file. A field written once in `<Class>.cs` with no read there is usually read elsewhere (precedent: `getFrostBiteLv()` in `Penguin.cs` is read in `Penguin_nAttack.cs:321-359`).

1. Search **every** `DecompiledSource/<Class>_*.cs` companion plus `CharacterControl.cs`, `Damage.cs`, `StatusData.cs`, `GameGui.cs` for the identifier (function, field or `hasSkill(ID)` number).
2. Only then report it as unverified, citing the full search scope.
3. Dead-code claims in `12t_reference/*.md` are prior findings, not ground truth; re-verify the same way.
4. **Statuses:** a status's effect is not fixed by the one `RPC_AddStatus` call you traced. Grep `CharacterControl.cs` (the generic `sType ==` switch) and `StatusData.cs` (classification, immunity/cleanse lists) for the exact status string before describing it. Precedent: `frost` looked cosmetic from its `moveMod`, but is a hard `moveSpeed=0` lock (`CharacterControl.cs:2409-2424`, `isLockStatus` at `StatusData.cs:6160`).

### 3.A. Active Skill Pipeline

#### Step A1: Pre-Flight Active Source Extraction (Zero Assumptions)
No guesses, linear extrapolations or wiki values. Trace:
0. **Cost/req table:** `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` (SP sign: negative = red/consumed, positive = blue/threshold, 0 = none).
1. **Cast dispatch** in `<Class>.cs`: `RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust`, per-rank arrays.
2. **Execution** in `<Class>_<companion>.cs`: hit loops, secondary triggers, collisions.
3. **Statuses:** `sType` and `nCode` (`StatusData.cs`), `sLv` per rank, classification (`isBuff/Debuff/State/Magical/Physical/Lock/ShieldStatus`, see [12Tails-Mechanics-Reference.md §4.2](../../../12t_reference/12Tails-Mechanics-Reference.md#42-status-classification-cleanse-system-statusdatacs)). `Damage.getDebuff(...)` → `durWrapped:true, durContested:true`; `getDebuffInvert(...)` → `durContestedInverted:true`.
4. **Rank icons:** every `<skill>1..<maxRank>` icon from `RippedAssets/` (Passive pipeline, below).
5. **Tooltips:** `<Class>Skill_eng.cs` and `<Class>Skill_thai.cs`.
6. **Passive deps:** every `hasSkill(ID)` / `get<Passive>Lv()` hook (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).
7. **Summons:** follow "Summon Mechanics" below.

#### Step A2: Active Review Table
Present to the user: identity (source key, EN/TH name, planned id, class, max rank); cast excerpt (`<Class>.cs:line`); execution/status excerpt; status profile (`sType`, `nCode`, `sLv`, classification); client tooltips; proposed `desc` (client phrasing as baseline, `**bold**` dynamic values, geometry, cleanse thresholds); proposed card schema (bible-card-fields). Use the compact table format the user prefers.

### 3.B. Passive Skill Pipeline

#### Step B1: Pre-Flight Passive Source Extraction
Scan the 5 hook categories: (1) stat alteration (`getTypeStat`, `calTotalStat`, `calHp/Mp/Atk/Def/Speed`); (2) active-skill modifiers (cd, cast, MP/SP, hit count, projectiles); (3) status/proc hooks (`AttackHit`, `MagicHit`, `mod`); (4) AI/companion (`HeavyBuilt`, `SynchroMole`, `HiddenTurret`); (5) attack augmentation (`nAttack`, `cAttack`). List every active skill the passive alters.

**Rank icons:** a `maxRank > 1` card needs every `<icon base><rank>` key (`[ICON RANK ERROR]`). Source: `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/<skill><rank>.png`, embedded as raw base64.

#### Step B2: Passive Review Table
Hook excerpt (`file:line`), exact arithmetic, affected actives + proposed dep toggles, status profile, client tooltips, proposed card (bible-card-fields).

### 3.C. Shared Gates, Review & Verification

1. One class at a time; wait for explicit user approval before writing.
2. When a skill depends on a skill with no card, surface that skill to do next.
3. Every verified finding goes into a card field or `desc`; anything that doesn't fit is listed as a numbered remainder for the user.
4. After patching, `node scripts/validate_skills.js` must pass before committing.

## Summon Mechanics, Companion Movesets & Summon Stat Cards

1. **Main summon card** (`mole_barrelBot`, `mole_kingKaiser`, `mole_autoGyroGun`): full 9-stat grid (`mhp atk def agi vit mag cha tal lck`), accented when upgrade toggles (`heavyBuilt`, `synchroMole`, `doubleBot`, `hiddenTurret`) affect them; no `.sk-dmg-row` if the summon cast deals no damage.
2. **Child move cards** (King Kaiser normal attack, Mega Punch, Gyro shot): summon stat row where only stats the move uses glow (others `.sk-summon-stat-unused`); use the summon's own stats (`ownStats`, `ownStatsKaiser`, `ownStatsGyro`, `ownStatsDmgOnly`).
3. **LCK:** summon LCK is the attacker LCK for hits (`dmgAdjust`); duration/channel variance always uses the **player's** CHA and LCK.
4. Duration used only for hit-count math: `hideDurationChip:true`.
5. Automated summon AI moves omit `cost` entirely.
6. Stat accent tokens: `--stat-atk/def/agi/vit/int/cha/tal/lck/lv/hp`.
7. **Rabbit Contract mercenaries** (`ownStatsMerc: "panther" | "leopard" | "golem"`, `contractOwnStats` / `mercOwnStats`): one stats card per unit (`mercParent: true`, full 9-stat grid, all accented, Contract level cast time and 300 s life, no cost or cooldown) plus move cards that attack with the mercenary's own ATK / TAL / LCK. The grid has a **New Order** toggle (`RABBIT_NEWORDER_DEP`, ×1.5 floored on every stat except SP). Move cards map to Contract's internal ID 434. The validator's own-stat render check (Gaos) also covers them.
8. **Mount items** (`mount: true`, e.g. Mole's Tank `mole_moleTank` and Giga Cannon `mole_gigaCannon` with their attack cards): no skill number, so the validator's SKILL_INTERNAL_ID check skips them. A mount copies the rider's base stats (`getNoDeltaStat`) plus its own bonuses, so its attack cards use the player's stat inputs directly (no own-stats flag); bonuses are stated in the mount card desc. Icons are the real item icons from `gamegui/icons/items/mount/`.
