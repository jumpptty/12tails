# AGENTS.md

This file provides instructions and guidelines for AI agents (Antigravity, Gemini, and pair-programming assistants) working in this repository.

---

## 1. What This Project Is

This repository is a reverse-engineering, mechanics-verification, and documentation workspace for **12 Tails Online** (a Unity MMORPG).

* **No build, compile, or test step:** There is no npm build, cargo build, or webpack.
* **Core activities:**
  1. Reading obfuscated decompiled C# source in `DecompiledSource/` to extract verified game formulas, stats, and skill logic.
  2. Building/updating static, self-contained single-file deliverables (HTML infographics, calculators, interactive tools) in `12t_projects/` (the Bible hub is `index.html` plus its `assets.js`).
  3. Documenting verified formulas and class stats in `12t_reference/`.

---

## 2. Directory Layout & Architecture

* **`DecompiledSource/`**: ~1,455 `.cs` files (`CharacterData.cs`, `Penguin.cs`, `Mole.cs`, etc.). Flat directory.
  * ⚠️ **READ-ONLY:** Never edit, modify, or delete files in `DecompiledSource/`.
  * **Always cite source excerpts with `file:line`** (e.g., `Penguin.cs:20624`).
  * **Citation build tags (2026-10-25):** a bare citation (`Penguin.cs:20624`) means the original BB client in `DecompiledSource/`. Any other build is tagged: `Reborn:Panda.cs:15657` is `DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/Panda.cs` (the Reborn build of 2026-10-25), and `Reborn1027:Panda.cs:N` is `DecompiledSource_Reborn_2026-10-27/Assembly-CSharp/Panda.cs` (build `2026.10.27.1936-bible3`). **Each new Reborn build (2026-10-27) gets its own dated folders and its own tag `Reborn<MMDD>:`; old citations keep their tag and stay valid**, since line numbers differ between builds. The same file name exists in every build with different line numbers, so never drop the tag. ToT and TTO have no decompiled code (their clients are encrypted): their deltas are live changes reported by the user, written as "user-reported <date>".
* **`Scaffolding/`**: Compiler-generated noise and decompiler stubs (`$ArrayType$*.cs`, `Assembly-UnityScript.csproj`, etc.). Safe to ignore.
* **`12t_reference/`**: Ground-truth verified mechanics reference docs:
  * `12Tails-Mechanics-Reference.md`: 8-stat system, derived HP/MP/KO/SP formulas, growth tables.
  * `<class>-skill-reference.md`: **One file per class (12 classes), and the only place to look.** Top section = cooldown, duration and cast-time table (active skills, max rank). The `# Damage & Mechanics` section below it = damage formulas, rank selectors, scaling coefficients, passives, and `## Server Balance Variations`. **Every skill shown in the app must have an entry in its class file — no exclusions** (passives, basic/charge attacks and Class-C skills included).
  * `Reborn-Mechanics-Reference.md`: the Reborn client, a separate build with its own codebase (2026-10-25): the client build it was verified against, how it is decompiled and its string table read, global balance, gear, units, per-class findings, open questions. **Never mix Reborn findings into the BB class files or `12Tails-Mechanics-Reference.md`**; Reborn is being added as the **4th app server** (infrastructure 2026-10-25, W.I.P.: registry `SERVER_INFO`, logo `server_reborn` with a W.I.P. stamp, server tab on cards with `servers.reborn` and, since 2026-10-26, on every card whose TAL / INT / CHA numbers lose the 512 cap there (`rebornStatTab`); details in `.claude/skills/bible-skill-page-ui/SKILL.md`, "Servers"). When a skill's Reborn values are verified, give its card `servers.reborn` and move the finding into that class file's `## Server Balance Variations (Reborn)` section.
  * **Splitting server sections (2026-10-25 decision):** ToT and TTO deltas stay inside the class files (about 9% of the text on that date). When one class's server sections pass about 40% of its file (Panda 38% and Wolf 37% on 2026-10-25) or a fifth server arrives, move that class's server sections to `12t_reference/servers/<server>-<class>.md`, Panda and Wolf first.
  * ⚠️ **Strictly Portable Markdown Links:** All documentation links between Markdown files in this repo must use repo-relative paths (e.g. `[12Tails-Mechanics-Reference.md §3.5](12t_reference/12Tails-Mechanics-Reference.md#35-universal-shared-skills-characterdataclasscs-charactercontrolcs)`) rather than OS-specific absolute URIs (`file:///c:/...`).
  * ⚠️ **Clean Reference Directory:** `12t_reference/` is strictly for verified, permanent ground-truth documents. Temporary session drafts or in-progress research dumps must stay in `<appDataDir>/brain/<conversation-id>/scratch/` until fully reviewed and consolidated into `12Tails-Mechanics-Reference.md` or the class's `<class>-skill-reference.md` (`# Damage & Mechanics` section).
* **`12t_projects/`**: Shipped player-facing deliverables. Every deliverable gets its own sub-folder:
  * `bible/`: The multi-tool hub (`index.html`). Core rules (large-file safety, changelog, validator, design basics): [12t_projects/bible/CLAUDE.md](12t_projects/bible/CLAUDE.md). Topic rules (desc writing, card fields, damage model, skill page UI, hub tools, research pipeline): `.claude/skills/bible-*/SKILL.md`, indexed in [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md).
  * `penguin-skill-sheet/`: Interactive skill infographic.
  * `agi-cha-sweetspot/`: Interactive AGI/CHA stat sweetspot calculator.
  * `goldenkingbug-spawn-map/`: 3D Three.js spawn map.
  * `donate-worker/`: Cloudflare Worker that checks a ☕ donor's slip form and forwards it to the owner's private Discord channel (with an อนุมัติ link into the guide manager). Stores nothing; the webhook is a Worker secret. Setup: its `README.md`.
  * `guide-manager/`: The class guide manager page (add / replace / remove guides in the Bible). Served by `scripts/add_guide.js` on the PC and by GitHub Pages for the phone, where it publishes through `.github/workflows/guide-manager.yml`. Rules: [12t_projects/bible/CLASS-GUIDES.md](12t_projects/bible/CLASS-GUIDES.md).
* **`docs/superpowers/`**: Feature specs (`specs/`) and implementation plans (`plans/`).
* **`RippedAssets/` & `12TailsOnline_Data/`**: Raw Unity asset ripper outputs and binary game data (git-ignored).
  * ⚠️ `RippedAssets/ExportedProject/Assets/Scripts/.../*.cs` are **empty dummy stubs**. Always read the real code from `DecompiledSource/`.
  * **Reborn (2026-10-25, all git-ignored, big folders travel by flash drive):** one dated set per client build (2026-10-27): `12TailsReborn_Data_<date>/` (the client), `DecompiledSource_Reborn_<date>/` (its code, one folder per assembly, read the game code in `Assembly-CSharp/`; not obfuscated with junk predicates) and `RippedAssets_Reborn_<date>/` (AssetRipper export; its `Scripts` are empty stubs too). Builds so far: **2026-10-25** (all three) and **2026-10-27** = `2026.10.27.1936-bible3` (client snapshot and decompile; not ripped yet: its scene and asset files differ byte for byte from 2026-10-25 after the Unity rebuild, so rip it when a check needs prefab or scene data; see its `BUILD.md`). Each folder has a `BUILD.md` with the version, DLL hash and how it was made. The `.csproj` files are renamed `*.csproj.ide-off` so VS Code's C# extension does not load the project and lock the folder. A build-to-build diff with the strings resolved lives in `D:\12tails-assets-archive\reborn-diff-<old>_to_<new>\`.
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
   * **Heading format (2026-10-25):** one heading per server, `## Server Balance Variations (<server>)` with `ToT` or `TTO`, or an umbrella `## Server Balance Variations` with one `### <server>` under it. Never one section that mixes servers; the two existing mixed ones (`(ToT & TTO)` in the Bat and Monkey files) are split when next edited. Patch-note and EX sections keep their own titles.
6. **Reborn client (2026-10-25):** its code is not obfuscated with junk predicates, but item codes and many strings are helper calls (`_XXXX_XXXX()`) into a string table read from `StreamingAssets/strblob.bytes`; how to read them and everything verified about Reborn is in [12t_reference/Reborn-Mechanics-Reference.md](12t_reference/Reborn-Mechanics-Reference.md). Cite its code as `Reborn:<file>:<line>`.

---

## 4. Mechanics Reference Documentation Protocol

**Mandatory Reference Review First:** Before starting any decompiled source tracing or deep-dive research, the agent MUST read `12t_reference/12Tails-Mechanics-Reference.md` (and the corresponding `<class>-skill-reference.md`) to check if the global mechanic, formula, stat adjuster, or damage pipeline has already been verified and documented. Never spend turns re-researching solved mechanics (such as `hitMod`, `defAdjust`, `chaAdjust`, derived stats, or class growth tables). **When the task is about one server, read the base sections plus only that server's section (find it by its heading), and check which build every citation refers to.**

**Mandatory Engine Findings Recording Rule:** Whenever research reveals a new global formula, game-wide engine mechanic, status classification behavior, or cross-class system that is not yet documented in `12t_reference/12Tails-Mechanics-Reference.md`:
1. **Immediate Document Update:** Append or update verified findings in `12t_reference/12Tails-Mechanics-Reference.md` with complete source citations (`file:line`) and decompiled snippets.
2. **Class-Specific vs Global Separation:** If the finding is specific to one class, record it in `12t_reference/<class>-skill-reference.md` (`# Damage & Mechanics` section). If it affects the global engine or multiple classes, record it in `12Tails-Mechanics-Reference.md`.
3. **Never Leave Ground Truth Solely in Code:** Never leave newly discovered mechanics trapped only in deliverable card objects or chat responses.

**Strict Prohibition on Approximations & Wiki Guesses:** Approximations, linear extrapolations (e.g. assuming Rank 2 MP is +25%/+50%), or unverified community wiki values are strictly forbidden across all deliverables and reference documents. All resource costs (MP, SP sign and magnitude), requirements (`reqLv`, `reqBn`), cast times, cooldowns, durations, and damage formulas MUST be decoded and verified directly from decompiled source (`DecompiledSource/`) using `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` and source files (`<Class>.cs`, `<Class>_<companion>.cs`).

**Shared/Universal Skills Exemption:** Five skills share identical numeric skill IDs and mechanics across all 12 classes (Revised Art `#424`, Revised Magic `#414`, Revised Skill `#404`, Stat Plus `#141-144`, Super Stat Plus `#441`). These are authored **once** under the Common category (documented in [12Tails-Mechanics-Reference.md §3.5](12t_reference/12Tails-Mechanics-Reference.md#35-universal-shared-skills-characterdataclasscs-charactercontrolcs)). Skip these five when running per-class skill pipelines.

---

## 5. Universal Deliverable Conventions & Sub-Project Pointers

* **Self-Contained Single Files:** Every delivered tool under `12t_projects/` must be a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly). It must open and run immediately in any browser by double-clicking without a web server. **Exception (user 2026-10-20):** the Bible hub is `index.html` plus a versioned `assets.js` beside it that holds its images, 3D models and sounds (`scripts/bible_assets.js`), so a page update doesn't make every visitor download them again. The two files together still open by double-click.
* **Strict Ban on Routine Visual Checks:** Do NOT launch the browser subagent (`browser_subagent`) or capture visual screenshots for data additions, formula corrections, tooltip text, or small fixes. Verification must be performed strictly via automated test scripts (`node scripts/validate_skills.js`) and git diffs. Visual browser checks are strictly reserved for major layout/CSS redesigns or when explicitly requested by the user.
* **Editing `index.html` safely (silent-loss prevention):** Never run `git checkout` / `git restore` / `git reset` / `git stash` on `index.html`, never replace a whole skill-card line, and back the file up (scratch dir) before every scripted edit; change only the specific fields you mean to. `node scripts/validate_skills.js` fails with `[FIELD LOSS ERROR]` when a card loses a field it had at `HEAD` (deliberate removals need `--allow-field-loss=<cardId:field,...>`) and reports `[DOC BACKLOG]` for app skills missing from their class reference. Full rules: [12t_projects/bible/CLAUDE.md](12t_projects/bible/CLAUDE.md) §1.
* **Changelog entry (every commit that touches `12t_projects/bible/index.html`; a habit, no longer enforced):** before committing, prepend a `CHANGELOG_DATA.entries` item `["<current UTC ISO>", "<exact commit subject>"]` (newest first) in `index.html`. The validator stopped checking it on 2026-10-20 (user: the gate hindered work in progress), so nothing fails if it is forgotten; keep adding it anyway (user: "still update the commit note regularly"). Full rule: [12t_projects/bible/CLAUDE.md](12t_projects/bible/CLAUDE.md) §1. The panel numbers entries oldest = 01, newest first; "ดูเพิ่มเติม" reveals all remaining entries at once.
* **Sub-Project Guidelines:** For project-specific UI standards, verification pipelines, schemas, and design systems, refer directly to that deliverable's local guideline document:
  * **Bible Hub (`12t_projects/bible/`)**: Start with [12t_projects/bible/CLAUDE.md](12t_projects/bible/CLAUDE.md) (core rules), then the topic file for the task, listed in [12t_projects/bible/GEMINI.md](12t_projects/bible/GEMINI.md) ("Ledger" design system, skill verification & QA pipeline, review table standards, card schemas, summon mechanics, `compatSkills`, stat glow tokens, large-file patching protocol). Claude Code loads the topic files automatically as skills.
