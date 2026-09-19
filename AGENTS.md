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
  * `<class>-skill-reference.md`: **One file per class (12 classes), and the only place to look.** Top section = cooldown, duration and cast-time table (active skills, max rank). The `# Damage & Mechanics` section below it = damage formulas, rank selectors, scaling coefficients, passives, and `## Server Balance Variations`. **Every skill shown in the app must have an entry in its class file — no exclusions** (passives, basic/charge attacks and Class-C skills included).
  * ⚠️ **Strictly Portable Markdown Links:** All documentation links between Markdown files in this repo must use repo-relative paths (e.g. `[12Tails-Mechanics-Reference.md §3.5](12t_reference/12Tails-Mechanics-Reference.md#35-universal-shared-skills-characterdataclasscs-charactercontrolcs)`) rather than OS-specific absolute URIs (`file:///c:/...`).
  * ⚠️ **Clean Reference Directory:** `12t_reference/` is strictly for verified, permanent ground-truth documents. Temporary session drafts or in-progress research dumps must stay in `<appDataDir>/brain/<conversation-id>/scratch/` until fully reviewed and consolidated into `12Tails-Mechanics-Reference.md` or the class's `<class>-skill-reference.md` (`# Damage & Mechanics` section).
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
5. **Server Balance Section in the Class Reference:** Whenever a skill features private server overrides (e.g. `servers.tot` or `servers.tto`), document both the base BigBug engine formula and the known server balance deltas in the class's `<class>-skill-reference.md` (`# Damage & Mechanics` section) under a dedicated "## Server Balance Variations" section. If a server change alters a global engine formula or cap (such as ToT's Lv 95 level stat scaling cap), document it directly in `12Tails-Mechanics-Reference.md`.

---

## 4. Mechanics Reference Documentation Protocol

**Mandatory Reference Review First:** Before starting any decompiled source tracing or deep-dive research, the agent MUST read `12t_reference/12Tails-Mechanics-Reference.md` (and the corresponding `<class>-skill-reference.md`) to check if the global mechanic, formula, stat adjuster, or damage pipeline has already been verified and documented. Never spend turns re-researching solved mechanics (such as `hitMod`, `defAdjust`, `chaAdjust`, derived stats, or class growth tables).

**Mandatory Engine Findings Recording Rule:** Whenever research reveals a new global formula, game-wide engine mechanic, status classification behavior, or cross-class system that is not yet documented in `12t_reference/12Tails-Mechanics-Reference.md`:
1. **Immediate Document Update:** Append or update verified findings in `12t_reference/12Tails-Mechanics-Reference.md` with complete source citations (`file:line`) and decompiled snippets.
2. **Class-Specific vs Global Separation:** If the finding is specific to one class, record it in `12t_reference/<class>-skill-reference.md` (`# Damage & Mechanics` section). If it affects the global engine or multiple classes, record it in `12Tails-Mechanics-Reference.md`.
3. **Never Leave Ground Truth Solely in Code:** Never leave newly discovered mechanics trapped only in deliverable card objects or chat responses.

**Strict Prohibition on Approximations & Wiki Guesses:** Approximations, linear extrapolations (e.g. assuming Rank 2 MP is +25%/+50%), or unverified community wiki values are strictly forbidden across all deliverables and reference documents. All resource costs (MP, SP sign and magnitude), requirements (`reqLv`, `reqBn`), cast times, cooldowns, durations, and damage formulas MUST be decoded and verified directly from decompiled source (`DecompiledSource/`) using `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` and source files (`<Class>.cs`, `<Class>_<companion>.cs`).

**Shared/Universal Skills Exemption:** Five skills share identical numeric skill IDs and mechanics across all 12 classes (Revised Art `#424`, Revised Magic `#414`, Revised Skill `#404`, Stat Plus `#141-144`, Super Stat Plus `#441`). These are authored **once** under the Common category (documented in [12Tails-Mechanics-Reference.md §3.5](12t_reference/12Tails-Mechanics-Reference.md#35-universal-shared-skills-characterdataclasscs-charactercontrolcs)). Skip these five when running per-class skill pipelines.

---

## 5. Universal Deliverable Conventions & Sub-Project Pointers

* **Self-Contained Single Files:** Every delivered tool under `12t_projects/` must be a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly). It must open and run immediately in any browser by double-clicking without a web server.
* **Strict Ban on Routine Visual Checks:** Do NOT launch the browser subagent (`browser_subagent`) or capture visual screenshots for data additions, formula corrections, tooltip text, or small fixes. Verification must be performed strictly via automated test scripts (`node scripts/validate_skills.js`) and git diffs. Visual browser checks are strictly reserved for major layout/CSS redesigns or when explicitly requested by the user.
* **Editing `index.html` safely (silent-loss prevention):** Never run `git checkout` / `git restore` / `git reset` / `git stash` on `index.html`, never replace a whole skill-card line, and back the file up (scratch dir) before every scripted edit; change only the specific fields you mean to. `node scripts/validate_skills.js` fails with `[FIELD LOSS ERROR]` when a card loses a field it had at `HEAD` (deliberate removals need `--allow-field-loss=<cardId:field,...>`) and reports `[DOC BACKLOG]` for app skills missing from their class reference. Full rules: [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md) §1.3.
* **Changelog Gate (every commit that touches `12t_projects/bible/index.html`):** before committing, prepend a `CHANGELOG_DATA.entries` item `["<current UTC ISO>", "<exact commit subject>"]` (newest first) in `index.html`, then run `node scripts/validate_skills.js` (it errors if the newest entry does not match the commit). Full rule: [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md) §1.4. The panel numbers entries oldest = 01, newest first; "ดูเพิ่มเติม" reveals all remaining entries at once.
* **Sub-Project Guidelines:** For project-specific UI standards, verification pipelines, schemas, and design systems, refer directly to that deliverable's local guideline document:
  * **Bible Hub (`12t_projects/bible/`)**: See [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md) for the "Ledger" design system, skill verification & QA pipeline, review table standards, card schemas, summon mechanics, `compatSkills`, stat glow tokens, and the 6.4MB large-file patching protocol.
