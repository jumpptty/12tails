# AGENTS.md

This file provides instructions and guidelines for AI agents (Antigravity, Gemini, and pair-programming assistants) working in this repository.

---

## 1. What This Project Is

This repository is a reverse-engineering, mechanics-verification, and documentation workspace for **12 Tails Online** (a Unity MMORPG).

* **No build, compile, or test step:** There is no npm build, cargo build, or webpack.
* **Core activities:**
  1. Reading obfuscated decompiled C# source in `DecompiledSource/` to extract verified game formulas, stats, and skill logic.
  2. Building/updating static, self-contained single-file deliverables (HTML infographics, calculators, interactive tools) in `12t_projects/`.
  3. Documenting verified formulas and class stats in `12t_reference/`.

---

## 2. Directory Layout & Architecture

* **`DecompiledSource/`**: ~1,455 `.cs` files (`CharacterData.cs`, `Penguin.cs`, `Mole.cs`, etc.). Flat directory.
  * ⚠️ **READ-ONLY:** Never edit, modify, or delete files in `DecompiledSource/`.
  * **Always cite source excerpts with `file:line`** (e.g., `Penguin.cs:20624`).
* **`Scaffolding/`**: Compiler-generated noise and decompiler stubs (`$ArrayType$*.cs`, `Assembly-UnityScript.csproj`, etc.). Safe to ignore.
* **`12t_reference/`**: Ground-truth verified mechanics reference docs:
  * `12Tails-Mechanics-Reference.md`: 8-stat system, derived HP/MP/KO/SP formulas, growth tables.
  * `*-skill-reference.md`: Cooldown, duration, cast-time data across all 12 classes.
  * `*-skill-damage-reference.md`: Damage formulas, rank selectors, scaling coefficients (Penguin, Mole, Chameleon, Monkey so far).
  * ⚠️ **Strictly Portable Markdown Links:** All documentation links between Markdown files in this repo must use repo-relative paths (e.g. `[12Tails-Mechanics-Reference.md §3.5](12t_reference/12Tails-Mechanics-Reference.md#35-universal-shared-skills-characterdataclasscs-charactercontrolcs)`) rather than OS-specific absolute URIs (`file:///c:/...`).
  * ⚠️ **Clean Reference Directory:** `12t_reference/` is strictly for verified, permanent ground-truth documents. Temporary session drafts or in-progress research dumps must stay in `<appDataDir>/brain/<conversation-id>/scratch/` until fully reviewed and consolidated into `12Tails-Mechanics-Reference.md` or `<class>-skill-damage-reference.md`.
* **`12t_projects/`**: Shipped player-facing deliverables. Every deliverable gets its own sub-folder:
  * `bible/`: The multi-tool hub (`index.html`). See [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md) for its dedicated design system, card schemas, and large-file safety protocol.
  * `penguin-skill-sheet/`: Interactive skill infographic.
  * `agi-cha-sweetspot/`: Interactive AGI/CHA stat sweetspot calculator.
  * `goldenkingbug-spawn-map/`: 3D Three.js spawn map.
* **`docs/superpowers/`**: Feature specs (`specs/`) and implementation plans (`plans/`).
* **`RippedAssets/` & `12TailsOnline_Data/`**: Raw Unity asset ripper outputs and binary game data (git-ignored).
  * ⚠️ `RippedAssets/ExportedProject/Assets/Scripts/.../*.cs` are **empty dummy stubs**. Always read the real code from `DecompiledSource/`.
* **`scripts/`**: Permanent workspace validation and test scripts only (e.g. `scripts/validate_skills.js`).
  * ⚠️ **Scratch Scripts Rule:** Temporary one-off scripts, research snippets, and investigation helpers MUST NEVER be written to `scripts/` or workspace folders. Always write them to the internal agent scratch directory (`<appDataDir>/brain/<conversation-id>/scratch/`) to keep the repository clean and avoid triggering unwanted IDE diff review prompts.

---

## 3. Reading Decompiled Source (Obfuscation Guide)

When reading `.cs` files in `DecompiledSource/`:
1. **Junk Predicates:** The obfuscator wraps logic in bogus arithmetic (e.g., `if (68549 - 287643 != -219094)`). Ignore the condition and follow the true branch.
2. **Companion Skill Files:** Always check for `<Class>_<skillName>.cs` (e.g. `Mole_napalm.cs`, `Bat_illusionFire.cs`, `BarrelBot_missile.cs`). `<Class>.cs` often only dispatches the cast, while the actual damage loop or multi-hit logic lives in the companion `MonoBehaviour`. Read companion files to the very end. For companion entities and summons (`BarrelBot.cs`, `Phoenix.cs`, `AutoGyroGun.cs`), trace summon stat inheritance and refer to summon mechanics guidelines.
3. **Mangled Identifiers:** Identifiers like `this.$mSpawnPoint$44454` or `LTRpgsKoBpCYTrSOvr` are compiler noise. Real game functions (`getTypeStat`, `createActor`, `dmgAdjust`, `talAdjust`) are intact.
4. **Live Server vs Decompiled Code:** If direct user testing or live gameplay contradicts a decompiled value (e.g. a live patch adjusted a duration from `talAdjust` to `chaAdjust`), **the user's live observation takes precedence**. Document the discrepancy with a note.
5. **Server Balance Section in Damage References:** Whenever a skill features private server overrides (e.g. `servers.tot` or `servers.tto`), document both the base BigBug engine formula and the known server balance deltas in the class's `*-skill-damage-reference.md` under a dedicated "## Server Balance Variations" section. If a server change alters a global engine formula or cap (such as ToT's Lv 95 level stat scaling cap), document it directly in `12Tails-Mechanics-Reference.md`.

---

## 4. Universal Deliverable Conventions

* **Self-Contained Single Files:** Every delivered tool under `12t_projects/` must be a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly). It must open and run immediately in any browser by double-clicking without a web server.
* **Strict Ban on Routine Visual Checks:** Do NOT launch the browser subagent (`browser_subagent`) or capture visual screenshots for data additions, formula corrections, tooltip text, or small fixes. Verification must be performed strictly via automated test scripts (`node scripts/validate_skills.js`) and git diffs. Visual browser checks are strictly reserved for major layout/CSS redesigns or when explicitly requested by the user.
* **Sub-Project Guidelines:** For project-specific UI standards, schemas, and design systems, refer directly to that deliverable's local guideline document:
  * **Bible Hub (`12t_projects/bible/`)**: See [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md) for the "Ledger" design system, `.sk-hero-desc` container, card schema, summon mechanics, `compatSkills`, stat glow tokens, and the 6.4MB large-file patching protocol.

---

## 5. Skill Verification & Quality Assurance Pipeline

Every skill authoring, formula update, or tooltip review must strictly follow this linear execution pipeline:

**Mandatory Reference Review First:** Before starting any decompiled source tracing or deep-dive research, the agent MUST read `12t_reference/12Tails-Mechanics-Reference.md` (and the corresponding `*-skill-reference.md` / `*-skill-damage-reference.md`) to check if the global mechanic, formula, stat adjuster, or damage pipeline has already been verified and documented. Never spend turns re-researching solved mechanics (such as `hitMod`, `defAdjust`, `chaAdjust`, derived stats, or class growth tables).

**Mandatory Engine Findings Recording Rule:** Whenever research reveals a new global formula, game-wide engine mechanic, status classification behavior, or cross-class system that is not yet documented in `12t_reference/12Tails-Mechanics-Reference.md`:
1. **Immediate Document Update:** Append or update verified findings in `12t_reference/12Tails-Mechanics-Reference.md` with complete source citations (`file:line`) and decompiled snippets.
2. **Class-Specific vs Global Separation:** If the finding is specific to one class, record it in `12t_reference/<class>-skill-damage-reference.md`. If it affects the global engine or multiple classes, record it in `12Tails-Mechanics-Reference.md`.
3. **Never Leave Ground Truth Solely in Code:** Never leave newly discovered mechanics trapped only in deliverable card objects or chat responses.

**Shared/Universal Skills Exemption:** Five skills share identical numeric skill IDs and mechanics across all 12 classes (Revised Art `#424`, Revised Magic `#414`, Revised Skill `#404`, Stat Plus `#141-144`, Super Stat Plus `#441`). These are authored **once** under the Common category (documented in [12Tails-Mechanics-Reference.md §3.5](12t_reference/12Tails-Mechanics-Reference.md#35-universal-shared-skills-characterdataclasscs-charactercontrolcs)). Skip these five when running per-class skill pipelines.

---

### 5.A. Active Skill Pipeline

#### Step A1: Pre-Flight Active Source Extraction (Zero Assumptions)
* **Never guess or use generic RPG tropes.**
* Run a temporary scratch script (in `<appDataDir>/brain/<conversation-id>/scratch/`) or `view_file` to trace the full lifecycle across:
  0. **Cost/Mode/Req Table:** Run `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` for every skill's MP/SP/reqLv before reading `getSkill()`'s obfuscated fallthrough chain by eye. SP field sign indicates type (negative = red/consumed, positive = blue/threshold gate, `0` = no SP cost).
  1. **Cast Dispatch:** `<Class>.cs` (`RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust` wrappers, per-rank arrays).
  2. **Execution & Companion Logic:** `<Class>_<companion>.cs` (multi-hit loops, secondary triggers, collision handlers).
  3. **Status Effect Tracing (Name, Level, and Classification):**
     * **Status Name (`sType`) & ID (`nCode`):** Exact string and integer code from `StatusData.cs`.
     * **Status Level (`sLv`):** Exact level passed or calculated per rank.
     * **Status Classification (via `StatusData.cs`, see [12Tails-Mechanics-Reference.md §4.2](12t_reference/12Tails-Mechanics-Reference.md#42-status-classification--cleanse-system-statusdatacs)):** Verify `isBuffStatus`, `isDebuffStatus`, `isStateStatus`, `isMagicalStatus`, `isPhysicalStatus`, `isLockStatus`, `isShieldStatus`.
     * **Debuff Duration Contesting:** Any status calculated via `Damage.getDebuff(...)` requires `durWrapped: true` and `durContested: true`. For `Damage.getDebuffInvert(...)`, declare `durContestedInverted: true`.
  4. **Multi-Rank Icon Completeness:** For `maxRank > 1`, inspect and extract every rank variant icon (`<skill>1`..`<skill><maxRank>`) from `RippedAssets/`. Zero placeholders.
  5. **In-Game Tooltips:** Cite raw strings from `<Class>Skill_eng.cs` & `<Class>Skill_thai.cs`.
  6. **Passive Dependencies:** Trace all `hasSkill(ID)` / `get<Passive>Lv()` hooks (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).
  7. **Summons & Companions:** If the skill spawns an entity or commands a companion, adhere strictly to [12t_projects/bible/GEMINI.md §4](12t_projects/bible/GEMINI.md#4-summon-mechanics-companion-movesets--summon-stat-cards) and [12Tails-Mechanics-Reference.md §4.3](12t_reference/12Tails-Mechanics-Reference.md#43-summon--companion-entity-mechanics).

#### Step A2: Active Observable Proof Review Table
Present a structured review table to the user including:
1. **Identity Mapping:** Internal source key, user-facing name (EN & TH), planned ID, class, max rank.
2. **Cast Dispatch Excerpt (`<Class>.cs:line`):** Exact `addTimeOut`, `DisplayCastBar`, and `RPC_<skill>` snippets.
3. **Execution / Status Delta Excerpt (`CharacterControl.cs:line` or Companion):** Exact logic modifying stats, damage, or statuses.
4. **Status Profile:** Name (`sType`), Numeric ID (`nCode`), `sLv`, and full boolean classification breakdown.
5. **Client Tooltips:** Exact strings cited from `*Skill_thai.cs` and `*Skill_eng.cs`.
6. **Proposed Header Tooltip (`desc`):** Authentic client phrasing as baseline, qualitative over quantitative, dynamic highlights with `**bold**`, clear mention of geometries and cleanse thresholds.
7. **Proposed Card Schema:** Complete deliverable card definition (see [12t_projects/bible/GEMINI.md §3](12t_projects/bible/GEMINI.md#3-skill-card-schema--authoring-standards)).

---

### 5.B. Passive Skill Pipeline

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
6. **Proposed Card Definition:** Schema block ready for `index.html` (see [12t_projects/bible/GEMINI.md §3](12t_projects/bible/GEMINI.md#3-skill-card-schema--authoring-standards)).

---

### 5.C. Shared Gates, Review & Verification

1. **Strict Single-Class User Gate:** Process strictly one class at a time and wait for explicit user approval before writing changes.
2. **Close the SkillDep Loop:** When a skill introduces a dependency on another skill that has no card yet, proactively surface those related skills to the user to implement next.
3. **Zero Silent Omissions & Numbered Remainder List:** Account for every verified finding in card fields or `desc`. Any verified finding that does not fit an existing field must be presented as a numbered remainder list for the user to review and decide upon.
4. **Validation & Integrity Pass:** After patching via out-of-process scratch scripts (see [12t_projects/bible/GEMINI.md §1](12t_projects/bible/GEMINI.md#1-large-file-handling--crash-prevention-protocol-64-mb)), run `node scripts/validate_skills.js` to ensure 100% integrity pass before committing.
