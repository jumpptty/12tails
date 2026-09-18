# Bible Deliverable Guidelines (`12t_projects/bible/`)

This document contains mandatory guidelines, UI conventions, card schemas, verification pipelines, and file-handling safety rules specifically for the **Bible multi-tool deliverable** (`12t_projects/bible/index.html`).

---

## 1. Large File Handling & Crash Prevention Protocol (>6.4 MB)

`12t_projects/bible/index.html` is **>6.4 MB** because it embeds 670+ game icons as raw Base64 data URIs (lines ~3,600 to ~9,600). Ingesting this into an AI chat context triggers token exhaustion, emergency context truncations, memory loss, and crash loops.

To permanently prevent session crashes and turn interruptions:

1. **Strict Zero-Base64 Ingestion:**
   * Never execute `view_file`, `grep_search`, or raw file dumps across the Base64 icon definitions (lines ~3,600 to ~9,600).
   * To inspect icon keys or definitions, run a small Node.js scratch script that tests keys with regex and prints only string names, never the Base64 payloads.

2. **Out-of-Process Patching via Scratch Scripts:**
   * Never use IDE editing tools (`replace_file_content` / `multi_replace_file_content`) to pass large sections of `index.html` through the context window.
   * All modifications to `index.html` must be applied using small Node.js patch scripts located in `<appDataDir>/brain/<conversation-id>/scratch/`.
   * The patch script loads `index.html`, replaces the targeted logic in memory, writes the file back, and prints only a 1-line confirmation (e.g., `SUCCESS: Patched Left Stride (42 lines)`). Exactly 0 KB of raw HTML or Base64 enters the agent context.

3. **Git Checkpoint Before Every Phase:**
   * Always verify a clean working tree (`git status`) or commit working states before applying edits. If any script behaves unexpectedly, revert immediately via `git checkout`.
   * If the tree is dirty, inspect and preserve unrelated changes; do not commit or revert them.

4. **Mandatory Post-Edit Verification & Changelog Gate:**
   * Before committing, prepend a `CHANGELOG_DATA.entries` item in `index.html` using the **exact planned commit subject** and the current ISO timestamp.
   * Execute automated integrity test suite: `node scripts/validate_skills.js` (validates all skills, formula permutations across ranks 1..maxRank and dependencies, and icon assets).

---

## 2. Deliverable & Visual Design Conventions

* **Self-Contained Single File:** Must remain a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly) that opens and runs immediately in any browser without a web server.
* **Preserve Design Integrity:** Adhere strictly to the "Ledger" visual design system (deep lacquer ground `#141311`, brass-gold ink `#d4af37`, oxblood-red accent `#8b1e1e`, high-contrast legible typography).
* **Inline Skill Description Container (`.sk-hero-desc`):**
  * Sits inline to the right of the skill icon and title in the card hero header (`flex: 1; min-width: 0; margin-left: 14px;`).
  * **Visual Style:** Gold Accent Bar (`background: var(--panel); border: 1px solid var(--line); border-left: 3px solid var(--gold); border-radius: 4px; box-shadow: 0 1px 3px rgba(0,0,0,0.3);`).
  * **Typography:** Google Fonts **Prompt** (`font-family: 'Prompt', -apple-system, sans-serif; font-size: 12px; line-height: 1.42; color: var(--muted);`). Height is unlimited (no line-clamp or max-height restriction).
  * **Responsive:** Stretches `100%` full width beneath the title on mobile viewports.
  * **Dynamic Variable Highlights (`**value**`):** Wrap dynamic rank/dependency-scaled numbers in `**${value}**` inside `desc` functions (`(rank, depRank) => ...`). `renderHero()` parses this to `<span class="sk-val">value</span>` (styled in Brass Gold).
  * **No Native Browser Tooltip:** Native `title` attribute is explicitly omitted from `.sk-hero-desc` to prevent unsightly default browser tooltip popups.
* **Basic Attacks & Passives as Cards Policy:** Basic attacks (Combo / `nAttack`), charge attacks (`cAttack`), and passive skills CAN be authored as full skill cards in `bible` (`skill-details`), but strictly when explicitly requested by the user.
* **Vertical Collapse Convention for Skill Cards:**
  * All skill cards must collapse vertically whenever a chip row is empty.
  * **Zero Preserved Blank Space:** Never render empty chip row containers (`<div class="sk-dmg-row"></div>` or empty `.sk-hero-stats`) or enforce artificial fixed min-heights.
  * If a skill has no cooldown/cast/duration/stats chips, omit `.sk-hero-stats` completely.
  * If a skill has no damage formula/shield chips, omit `.sk-dmg-row` completely.
* **`dmgGroups` Skills Mirroring Rule:** `dmgGroups` skills MUST declare a top-level `dmg`/`atkCoeff`/`ko` mirroring the primary group. `renderHero()`'s "Total LCK Variance" calc chip reads the top-level `dmg` unconditionally when `dmgGroups` is present; omitting it causes a fatal `SyntaxError` in `evalArith("")`.
* **KO Badge per Group:** When individual `dmgGroups` differ in KO value (e.g. `ko: "10"` vs `ko: "5"`), declare `ko` on each group. `getGroupKOInfo()` automatically splits into inline chips only when they differ, or collapses to a single `.sk-ko-badge` when uniform.
* **Per-Class `SKILLS` Ordering:** Within a class's block in the `SKILLS` array, order entries by that class's own internal skill ID sequence from `<Class>Skill.cs`'s `getSkillTree()` `result = "<class>_<name><rank>"` assignments.

---

## 3. Skill Verification & Quality Assurance Pipeline

Every skill authoring, formula update, or tooltip review must strictly follow this linear execution pipeline:

### 3.A. Active Skill Pipeline

#### Step A1: Pre-Flight Active Source Extraction (Zero Assumptions)
* **Never guess or use generic RPG tropes.**
* Run a temporary scratch script (in `<appDataDir>/brain/<conversation-id>/scratch/`) or `view_file` to trace the full lifecycle across:
  0. **Cost/Mode/Req Table:** Run `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` for every skill's MP/SP/reqLv before reading `getSkill()`'s obfuscated fallthrough chain by eye. SP field sign indicates type (negative = red/consumed, positive = blue/threshold gate, `0` = no SP cost).
  1. **Cast Dispatch:** `<Class>.cs` (`RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust` wrappers, per-rank arrays).
  2. **Execution & Companion Logic:** `<Class>_<companion>.cs` (multi-hit loops, secondary triggers, collision handlers).
  3. **Status Effect Tracing (Name, Level, and Classification):**
     * **Status Name (`sType`) & ID (`nCode`):** Exact string and integer code from `StatusData.cs`.
     * **Status Level (`sLv`):** Exact level passed or calculated per rank.
     * **Status Classification (via `StatusData.cs`, see [12Tails-Mechanics-Reference.md §4.2](../../12t_reference/12Tails-Mechanics-Reference.md#42-status-classification-cleanse-system-statusdatacs)):** Verify `isBuffStatus`, `isDebuffStatus`, `isStateStatus`, `isMagicalStatus`, `isPhysicalStatus`, `isLockStatus`, `isShieldStatus`.
     * **Debuff Duration Contesting:** Any status calculated via `Damage.getDebuff(...)` requires `durWrapped: true` and `durContested: true`. For `Damage.getDebuffInvert(...)`, declare `durContestedInverted: true`.
  4. **Multi-Rank Icon Completeness:** For `maxRank > 1`, inspect and extract every rank variant icon (`<skill>1`..`<skill><maxRank>`) from `RippedAssets/`. Zero placeholders.
  5. **In-Game Tooltips:** Cite raw strings from `<Class>Skill_eng.cs` & `<Class>Skill_thai.cs`.
  6. **Passive Dependencies:** Trace all `hasSkill(ID)` / `get<Passive>Lv()` hooks (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).
  7. **Summons & Companions:** If the skill spawns an entity or commands a companion, adhere strictly to [Section 5](#5-summon-mechanics-companion-movesets--summon-stat-cards).

#### Step A2: Active Observable Proof Review Table
Present a structured review table to the user including:
1. **Identity Mapping:** Internal source key, user-facing name (EN & TH), planned ID, class, max rank.
2. **Cast Dispatch Excerpt (`<Class>.cs:line`):** Exact `addTimeOut`, `DisplayCastBar`, and `RPC_<skill>` snippets.
3. **Execution / Status Delta Excerpt (`CharacterControl.cs:line` or Companion):** Exact logic modifying stats, damage, or statuses.
4. **Status Profile:** Name (`sType`), Numeric ID (`nCode`), `sLv`, and full boolean classification breakdown.
5. **Client Tooltips:** Exact strings cited from `*Skill_thai.cs` and `*Skill_eng.cs`.
6. **Proposed Header Tooltip (`desc`):** Authentic client phrasing as baseline, qualitative over quantitative, dynamic highlights with `**bold**`, clear mention of geometries and cleanse thresholds.
7. **Proposed Card Schema:** Complete deliverable card definition (see [Section 4](#4-skill-card-schema--authoring-standards)).

---

### 3.B. Passive Skill Pipeline

#### Step B1: Pre-Flight Passive Source Extraction (Zero Assumptions)
* Systematically scan and trace across the **5 Passive Hook Categories**:
  1. **Stat Alteration Hook:** Modifies base or derived attributes (`CharacterControl.getTypeStat`, `calTotalStat`, `calHp`, `calMp`, `calAtk`, `calDef`, `calSpeed`).
  2. **Active Skill Dependency Hook:** Modifies cooldown, cast time, MP/SP consumption, hit count, or projectile patterns.
  3. **Status Application / Proc Hook:** Grants on-hit effects, debuff chances, or modifies status levels in `AttackHit`, `MagicHit`, or `mod`.
  4. **AI / Companion Hook:** Modifies summon pet stats or AI behaviors (e.g. `HeavyBuilt`, `SynchroMole`, `HiddenTurret`).
  5. **Attack Augmentation Hook:** Modifies normal attack combos or charge attack behaviors (`nAttack`, `cAttack`).
* **Multi-Rank Icon Completeness:** Verify all rank variant icons from `RippedAssets/`.
* **Cross-Linking Target Audit:** Identify and list every active skill altered by this passive.

#### Step B2: Passive Observable Proof Review Table
Present a structured review table including:
1. **Hook & Logic Excerpt (`file:line`):** Exact source line showing `hasSkill(...)` / `get<Name>Lv()` check and its execution branch.
2. **Mechanics & Derivation:** Precise arithmetic for stat additions, timer scaling, proc chances, or level calculations.
3. **Cross-Linked Active Skills & Dependency Mapping:** List all affected active skills and proposed dependency toggles.
4. **Status Profile:** Status details if granted/applied.
5. **Client Tooltips:** Exact raw strings from client files.
6. **Proposed Card Definition:** Schema block ready for `index.html` (see [Section 4](#4-skill-card-schema--authoring-standards)).

---

### 3.C. Shared Gates, Review & Verification

1. **Strict Single-Class User Gate:** Process strictly one class at a time and wait for explicit user approval before writing changes.
2. **Close the SkillDep Loop:** When a skill introduces a dependency on another skill that has no card yet, proactively surface those related skills to the user to implement next.
3. **Zero Silent Omissions & Numbered Remainder List:** Account for every verified finding in card fields or `desc`. Any verified finding that does not fit an existing field must be presented as a numbered remainder list for the user to review and decide upon.
4. **Validation & Integrity Pass:** After patching via out-of-process scratch scripts, run `node scripts/validate_skills.js` to ensure 100% integrity pass before committing.

---

## 4. Skill Card Schema & Authoring Standards

### Proposed Active Card Schema (`SKILLS` Object)
```javascript
{
  id: "class_skillName",
  name: "English Name",
  nameTha: "ชื่อไทย",
  class: "Class",
  icon: "iconKeyMaxRank",
  maxRank: 3,
  cost: { mp: [15, 30, 45], sp: [1, 2, 3], spType: "red" }, // "red" = consumed, "blue" = threshold
  cd: [10, 8, 6],
  cdWrapped: true, // true if agiAdjust/cd wrapped
  castTime: 1.5,
  castWrapped: true, // true if chaAdjust/cast wrapped
  duration: [10, 15, 20],
  durWrapped: true, // true if chaAdjust/dur wrapped
  durContested: true, // true if Damage.getDebuff contested
  status: { name: "statusName", sLv: [1, 2, 3], class: "Physical Debuff" },
  dmg: "100 + 20*rank",
  atkCoeff: 1.0,
  ko: "15",
  desc: (rank) => `คำอธิบายสกิลพร้อมตัวแปร **${value}**`
}
```

### Proposed Passive Card Schema

```javascript
// Minimal / Standard Passive (Stat modifier or pure passive hook)
{
  id: "class_passiveName",
  name: "English Name",
  nameTha: "ชื่อไทย",
  class: "Class",
  icon: "iconKeyMaxRank",
  maxRank: 3,
  passive: true,
  desc: (rank) => `เพิ่มความสามารถ **${rank * 10}%**`
}

// Feature-Rich Passive (with Status, Internal Cooldown, Duration, or Proc Rate)
{
  id: "class_procPassive",
  name: "English Name",
  nameTha: "ชื่อไทย",
  class: "Class",
  icon: "iconKeyMaxRank",
  maxRank: 3,
  passive: true,
  cd: [10, 8, 6], // Internal proc cooldown (if present in source)
  duration: [5, 5, 5], // Temporary buff duration (if applied)
  status: { name: "buffStatus", sLv: [1, 2, 3], class: "Buff Status" }, // Status badge & classification
  lckProc: [15, 20, 25], // Proc chance % (if probabilistic)
  desc: (rank) => `เมื่อโจมตีมีโอกาส **${15 + rank*5}%** มอบสถานะ...`
}
```

> **Chip Support on Passives Policy:**
> Passive cards *can and should* carry `status`, `cd`, `duration`, `lckProc`, `cost`, or `ko` whenever decompiled source code proves the passive genuinely possesses them (e.g. granted statuses, internal cooldowns, proc rates, or toggle costs). Do not omit verified mechanics under the false assumption that passives are restricted to text-only descriptions. Unused chip rows collapse automatically per the Vertical Collapse Convention.

---

## 5. Summon Mechanics, Companion Movesets & Summon Stat Cards

When working with summon skills (Barrel Bot, King Kaiser, Auto Gyro Gun, Phoenix, etc.):

1. **Main Summon Card vs Child Moveset Cards:**
   * **Main Summon Card** (`mole_barrelBot`, `mole_kingKaiser`, `mole_autoGyroGun`):
     - Displays the full 9-stat Summon Status grid (`mhp`, `atk`, `def`, `agi`, `vit`, `mag`, `cha`, `tal`, `lck`).
     - All 9 stats colorize/accent when responsive to summon upgrade toggles (`heavyBuilt`, `synchroMole`, `doubleBot`, `hiddenTurret`).
     - Omits `.sk-dmg-row` when summon cast deals no direct damage.
   * **Child Moveset / Summon-Attack Cards** (`King Kaiser - Normal Attack`, `Barrel Bot - Mega Punch`, `Auto Gyro Gun - ยิงปกติ`):
     - Displays summon stat row with **selective glowing**: only stats actively used by this move's calculations glow. Inert stats are dimmed (`.sk-summon-stat-unused`).
     - Uses **summon's own stats** (`ownStats`, `ownStatsKaiser`, `ownStatsGyro`, `ownStatsDmgOnly`), not player's stats.
2. **LCK Stat Separation for Summons:**
   * Summon's own LCK (`agg.lck`, `bb.lck`, `kk.lck`) is strictly the **attacker's LCK** for hits (`dmgAdjust`).
   * Summon's **duration / channel variance** originates from the PLAYER. Always calculate duration variance using **Player CHA and Player LCK**, NEVER summon's LCK.
3. **Duration Chip Suppression on Sub-Attacks:**
   * Attacks defining duration strictly for simulation hit count math must declare `hideDurationChip: true`.
4. **Resource Badges / Cost Policy on Summon AI Moves:**
   * Automated summon pet attacks / AI moves must omit `cost` completely (never show "Free" or SP/MP badges).
5. **Stat Accent Tokens:**
   * Core stats use dedicated CSS variables (`--stat-atk`, `--stat-def`, `--stat-agi`, `--stat-vit`, `--stat-int`, `--stat-cha`, `--stat-tal`, `--stat-lck`, `--stat-lv`, `--stat-hp`).

---

## 6. Compatible Skills Navigation (`compatSkills`) Conventions

1. **Bidirectional Policy:** Every `compatSkills` edge must be reciprocated. If skill A lists skill B, skill B's own `compatSkills` must list A back. Sibling-to-sibling mesh links are allowed where beneficial for player navigation.
2. **Header & Typography:** Header is strictly `<p class="sk-compat-title">สกิลที่เกี่ยวข้อง</p>` (Google Fonts **Prompt**, Brass Gold `14px`). Redundant badges (`LINK`, `MASS CAST`, `MOVES`) are prohibited.
3. **Container & Chip Geometry:**
   * Button `.sk-compat-item`: `height: 44px; display: flex; align-items: center;`.
   * Icon `img.sk-compat-icon`: `width: 42px; height: 42px;` occupying full inner height.
   * Skill name `.sk-compat-name`: `-webkit-line-clamp: 2;` staying within 42px height boundary.
4. **Grid Layouts:**
   * Multi-item: `.sk-compat-grid` (`repeat(auto-fill, minmax(170px, 1fr))`).
   * Few-item (2–4): `.sk-compat-few-grid` (`repeat(auto-fit, minmax(170px, 1fr))` in 1 single row on desktop).
   * Single-item (1): `.sk-compat-single-grid` (`max-width: 340px;` with `"คลิกเพื่อดูสกิล →"`).

---

## 7. Player Stat Input Highlighting (Stat Signature Accents)

Controls the highlighting of the player's global stat inputs (`.sk-controls`: ATK/DEF/TAL/AGI/VIT/CHA/INT/LCK/CHAR LV) when the selected skill's chips read that input:

1. **`getUsedPlayerStatKeys(skill)`**: Reads `SKILLS` fields directly (`cdWrapped`, `castWrapped`, `durWrapped`, `dmg`, `atkCoeff`, `defCoeff`, `lckProc`, dep objects) and returns active stat keys.
2. **CSS Styling**: `.sk-stat-glow-<key>` classes apply `--sg-color` as input border, label color, number text color, and soft static `box-shadow` (no animation).
3. **CHAR LV (`lv`) Live-Toggle Gating**: LV only glows when its controlling dependency is actually toggled on (`getDepRank(dep) === dep.maxRank`).
4. **LCK Direct-Read Rule**: LCK only glows on a direct read (`lckProc`, literal `lckCoeff`, or `lckAdjust()` in formula text). Ambient LCK rolls inside `*Adjust` wrappers do NOT trigger LCK glowing.
5. **Own-Stat Exclusion Rules**: Summon sub-moves exclude player ATK/TAL/AGI according to summon ownership (`ownStats`, `ownStatsDmgOnly`, `ownStatsKaiser`, `ownStatsPhoenix`, `phoenixFireballCd`).
