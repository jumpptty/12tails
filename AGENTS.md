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
  * `*-skill-damage-reference.md`: Damage formulas, rank selectors, scaling coefficients (Penguin, Mole, Chameleon so far).
* **`12t_projects/`**: Shipped player-facing deliverables. Every deliverable gets its own sub-folder:
  * `player-reference-tool/`: The multi-tool hub (`index.html`) using the Thai temple lacquerware design system.
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
2. **Companion Skill Files:** Always check for `<Class>_<skillName>.cs` (e.g. `Mole_napalm.cs`, `Bat_illusionFire.cs`, `BarrelBot_missile.cs`). `<Class>.cs` often only dispatches the cast, while the actual damage loop or multi-hit logic lives in the companion `MonoBehaviour`. Read companion files to the very end.
3. **Mangled Identifiers:** Identifiers like `this.$mSpawnPoint$44454` or `LTRpgsKoBpCYTrSOvr` are compiler noise. Real game functions (`getTypeStat`, `createActor`, `dmgAdjust`, `talAdjust`) are intact.
4. **Live Server vs Decompiled Code:** If direct user testing or live gameplay contradicts a decompiled value (e.g. a live patch adjusted a duration from `talAdjust` to `chaAdjust`), **the user's live observation takes precedence**. Document the discrepancy with a note.

---

## 4. Deliverable Conventions

* **Self-Contained Single Files:** Every delivered tool under `12t_projects/` must be a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly). It must open and run immediately in any browser by double-clicking without a web server.
* **Preserve Design Integrity:** When updating `12t_projects/player-reference-tool/index.html`, adhere to its "Ledger" visual design system (deep lacquer ground `#141311`, brass-gold ink `#d4af37`, oxblood-red accent `#8b1e1e`, high-contrast legible typography).

---

## 5. Skill Verification & Quality Assurance Pipeline

Every skill authoring, formula update, or tooltip review must strictly follow this linear 4-step execution pipeline:

### Step 1: Pre-Flight Source Extraction (Zero Assumptions)
* **Never guess or use generic RPG tropes.**
* Run a temporary scratch script (in `<appDataDir>/brain/<conversation-id>/scratch/`) or `view_file` to trace the full lifecycle across:
  1. **Cast Dispatch:** `<Class>.cs` (`RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust` wrappers, per-rank arrays for `maxRank > 1`).
  2. **Execution & Companion Logic:** `<Class>_<companion>.cs` (multi-hit loops, secondary triggers, collision handlers).
  3. **Status Effects:** `CharacterControl.cs` (`case "<status>":` and `sType == "<status>"` to verify exact stat deltas: `deltaAtk`, `deltaDef`, `deltaRunSpeed`, `weight`, tick formulas in `mod`, and removal in `removeStatus`).
  4. **In-Game Tooltips:** `<Class>Skill_eng.cs` (reference for authentic flavor context; code findings always override tooltip errors).
  5. **Passive Dependencies:** Scan for all `hasSkill(ID)` / `get<Passive>Lv()` calls; map to proper tool hooks (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).

### Step 2: Observable Proof Review Table (3-Point Citation)
Present a structured review table to the user. Every single skill entry must include:
1. **Cast Dispatch Excerpt (`<Class>.cs:line`):** Exact `addTimeOut`, `DisplayCastBar`, and `RPC_<skill>` call.
2. **Execution / Status Delta Excerpt (`CharacterControl.cs:line` or Companion Script):** Exact code modifying stats, dealing damage/heals, or applying buffs/debuffs.
3. **In-Game Client Tooltip (`<Class>Skill_eng.cs:line`):** Exact raw string from client language files.
4. **Proposed Header Tooltip (`desc`):**
   * **In-Game Client Phrasing as Baseline:** Base descriptions directly on authentic client tooltips (`<Class>Skill_eng.cs`) to preserve original flavor context and terminology.
   * **Qualitative Over Quantitative:** Strip out all rank-dependent and dependency-scaled quantitative numbers (damage values, durations, tick counts, percentage bonuses) to avoid duplicating or conflicting with live UI calculation chips.
   * **Always Include Verified Geometries:** Always state exact AoE radii, projectile ranges, and cleanse areas whenever verified from decompiled targeting code (`Damage.FindAreaTarget`, `Damage.FindRecTarget`, OverlapSphere, raycasts).
   * **Highlight Utility & Hidden Mechanics:** Clearly note non-obvious behavior (cleanses, lock removals, sleep breaks, aggro wipes, absolute immunities, unlisted passive hooks).

> ⚠️ **Hard Gate:** Any formula, stat delta, or mechanic presented without its exact `file:line` source citation and code snippet is rejected as unverified by definition.

### Step 3: Strict Single-Class User Gate
* Process strictly **one class at a time**.
* **Hard STOP:** Wait for explicit user review and approval before writing changes to `index.html` or advancing to the next class.

### Step 4: Apply, Verify & Lint
* Apply changes to deliverables using authentic PNG header icons (`89 50 4E 47 0D 0A 1A 0A`).
* Execute automated integrity test suite: `node scripts/validate_skills.js` (validates all skills, formula permutations across ranks 1..maxRank and dependencies, and icon assets).

---

## 6. Typography & Markdown Formatting Rule (STRICT NO-LATEX)

> ⛔ **CRITICAL MANDATORY RULE — ZERO LATEX IN CHAT & DELIVERABLES:**
> 
> The IDE chat interface and markdown deliverables DO NOT support KaTeX / MathJax / LaTeX math plugins. Any LaTeX syntax renders as raw, ugly, unreadable text like `\frac{64}{\text{EnemyDef} + 64}` or `$$ ... $$`.
> 
> **NEVER output any of the following:**
> - ❌ Math delimiters: `$ ... $`, `$$ ... $$`
> - ❌ LaTeX commands: `\frac`, `\text`, `\times`, `\le`, `\ge`, `\neq`, `\pm`, `\left`, `\right`, `\lceil`, `\rceil`, `\lfloor`, `\rfloor`, `\dots`
> - ❌ Subscripts/superscripts via TeX: `\text{TAL}_{\text{eff}}` (use plain text `TAL_eff` or code blocks)
>
> **ALWAYS use plain English, standard code blocks, or native Unicode symbols:**
> - Code blocks for formulas: `Final Damage = Base Damage * (64 / (EnemyDef + 64))`
> - Arrows: `→`, `←`, `↔`
> - Arithmetic & Comparisons: `×`, `÷`, `±`, `≤`, `≥`, `≠`, `≈`
> - Ranges & Exponents: `1..maxRank`, `[0..ceil(0.2 * LCK)]`, `x²`, `x³`
> - Subscripts/Identifiers: `TAL_eff`, `Clamp(...)`, `Floor(...)`, `Ceil(...)`

---

## 7. Large File Handling & Crash Prevention Protocol (Mandatory for index.html)

`12t_projects/player-reference-tool/index.html` is **>6.4 MB** because it embeds 670 game icons as raw Base64 data URIs (lines ~3,600 to ~9,600). Ingesting this into an AI chat context triggers token exhaustion, emergency context truncations (`CHECKPOINT 0`), memory loss, and recursive crash loops.

To permanently prevent session crashes and turn interruptions:

1. **Strict Zero-Base64 Ingestion:**
   * Never execute `view_file`, `grep_search`, or raw file dumps across the Base64 icon definitions (lines ~3,600 to ~9,600).
   * To inspect icon keys or definitions, run a small Node.js scratch script that tests keys with regex and prints only string names, never the Base64 payloads.

2. **Out-of-Process Patching via Scratch Scripts:**
   * Never use IDE editing tools (`replace_file_content` / `multi_replace_file_content`) to pass large sections of `index.html` through the context window.
   * All modifications to `index.html` must be applied using small Node.js patch scripts located in `<appDataDir>/brain/<conversation-id>/scratch/`.
   * The patch script loads `index.html`, replaces the targeted logic in memory, writes the file back, and prints only a 1-line confirmation (e.g., `SUCCESS: Patched Left Stride (42 lines)`). Exactly 0 KB of raw HTML or Base64 enters the agent context.

3. **Absolute Ban on Reading Transcripts:**
   * Never run shell commands to read, tail, or grep `transcript.jsonl`, `transcript_full.jsonl`, or anything under `.system_generated/logs/`.

4. **Git Checkpoint Before Every Phase:**
   * Always verify a clean working tree (`git status`) or commit working states before applying edits. If any script behaves unexpectedly, revert immediately via `git checkout`.

5. **Mandatory Post-Edit Verification:**
   * Immediately after any patch script runs, execute:
     `node scripts/validate_skills.js`
   * Confirm that 100% of skills, formula permutations, and icons continue to pass automated integrity checks.


