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
  * `bible/`: The multi-tool hub (`index.html`) using the Thai temple lacquerware design system.
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
2. **Companion Skill Files:** Always check for `<Class>_<skillName>.cs` (e.g. `Mole_napalm.cs`, `Bat_illusionFire.cs`, `BarrelBot_missile.cs`). `<Class>.cs` often only dispatches the cast, while the actual damage loop or multi-hit logic lives in the companion `MonoBehaviour`. Read companion files to the very end. For companion entities and summons (`BarrelBot.cs`, `Phoenix.cs`, `AutoGyroGun.cs`), trace summon stat inheritance and refer to [Section 7](#7-summon-mechanics-companion-movesets--summon-stat-cards).
3. **Mangled Identifiers:** Identifiers like `this.$mSpawnPoint$44454` or `LTRpgsKoBpCYTrSOvr` are compiler noise. Real game functions (`getTypeStat`, `createActor`, `dmgAdjust`, `talAdjust`) are intact.
4. **Live Server vs Decompiled Code:** If direct user testing or live gameplay contradicts a decompiled value (e.g. a live patch adjusted a duration from `talAdjust` to `chaAdjust`), **the user's live observation takes precedence**. Document the discrepancy with a note.

---

## 4. Deliverable Conventions

* **Self-Contained Single Files:** Every delivered tool under `12t_projects/` must be a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly). It must open and run immediately in any browser by double-clicking without a web server.
* **Preserve Design Integrity:** When updating `12t_projects/bible/index.html`, adhere to its "Ledger" visual design system (deep lacquer ground `#141311`, brass-gold ink `#d4af37`, oxblood-red accent `#8b1e1e`, high-contrast legible typography).
* **Inline Skill Description Container (`.sk-hero-desc`):**
  * Sits inline to the right of the skill icon and title in the card hero header (`flex: 1; min-width: 0; margin-left: 14px;`).
  * **Visual Style:** Gold Accent Bar (`background: var(--panel); border: 1px solid var(--line); border-left: 3px solid var(--gold); border-radius: 4px; box-shadow: 0 1px 3px rgba(0,0,0,0.3);`).
  * **Typography:** Google Fonts **Prompt** (`font-family: 'Prompt', -apple-system, sans-serif; font-size: 12px; line-height: 1.42; color: var(--muted);`). Auto-adapts up to 4 lines (desktop, max-height `90px`) and 5 lines (mobile, max-height `105px`), dynamically scaling font size down to `10px` if text requires more room.
  * **Responsive:** Stretches `100%` full width beneath the title on mobile viewports.
* **Basic Attacks & Passives as Cards Policy:** Basic attacks (Combo / `nAttack`), charge attacks (`cAttack`), and passive skills CAN be authored as full skill cards in `bible` (`skill-details`), but strictly when explicitly requested by the user. Do not blanket-exclude them.
* **Vertical Collapse Convention for Skill Cards:**
  * All skill cards must collapse vertically whenever a chip row is empty.
  * **Zero Preserved Blank Space:** Never render empty chip row containers (`<div class="sk-dmg-row"></div>` or empty `.sk-hero-stats`) or enforce artificial fixed min-heights to preserve empty vertical space.
  * If a skill has no cooldown/cast/duration/stats chips, the top chip row (`.sk-hero-stats`) is omitted completely.
  * If a skill has no damage formula/shield chips, the second chip row (`.sk-dmg-row`) is omitted completely.
  * Any skill card with only header information (or only one row of chips) must immediately collapse its vertical footprint to fit its actual contents.
* **`dmgGroups` skills MUST also declare a top-level `dmg`/`atkCoeff`/`ko`** mirroring the most representative group (usually the first/primary one), even though the per-hit breakdown itself iterates `dmgGroups` independently via `renderOneDmgFormula`. `renderHero()`'s "Total LCK Variance" calc chip (`index.html`, the `if ((talMatchCalc || flatComputableCalc || activeSelected.dmgGroups) && !isDmgDisabled)` branch) reads the skill's top-level `dmg` unconditionally whenever `dmgGroups` is present. Omitting it (Planet Breaker's original stub->card upgrade, 2026-09-15) makes `getDmgText()` return `undefined`, which `evalArith("")` turns into a literal `SyntaxError` (`Function("return ()")`) that aborts `renderHero()` mid-render — the card's header still shows (it was written before the crash) but everything below it is blank. King Kaiser's Normal Attack already modeled this correctly; copy that pattern for any new `dmgGroups` card.
* **KO badge, per-group values (added 2026-09-15, Planet Breaker pilot):** a `dmgGroups` skill's individual groups may each declare their own `ko` field when they genuinely differ (e.g. Planet Breaker's Inner Circle `ko:"10"` vs Outer Ring `ko:"5"`) — `getGroupKOInfo()` (`index.html`, next to `getKOValue`) automatically collapses to the existing single corner `.sk-ko-badge` when every visible group's own `ko` (or the skill-level `ko` fallback, for a group with no override) matches, and splits into a small inline chip on each group's own label row only when they differ. No card-authoring action needed beyond giving each group the `ko` it actually has — don't hand-roll a combined string like `"10/5"` into the skill-level `ko` field instead. `.sk-ko-badge` itself is a bordered chip (`background: var(--gold-soft); border: 1px solid var(--gold)`), not bare text — reuse those tokens, don't invent a new color for it.

---

## 5. Skill Verification & Quality Assurance Pipeline

Every skill authoring, formula update, or tooltip review must strictly follow this linear execution pipeline, bifurcated by skill type:

**Shared/Universal Skills Exemption (added 2026-09-16):** Five skills share identical numeric skill IDs and mechanics across all 12 classes (verified: same IDs/effects in `Monkey.cs`, `CharacterControl.cs`, `CharacterDataClass.cs`, cross-checked against `PenguinSkill.cs`) — Revised Art (`#424`, -12% cooldown on all skills except `nAttack`/`cAttack`/consumables), Revised Magic (`#414`, -20% MP cost, rounded up), Revised Skill (`#404`, -50% SP cost, rounded up), Stat Plus (`#141-144`, +2 to all 8 stats per rank), and Super Stat Plus (`#441`, +10 to all 8 stats). These are authored **once**, under a dedicated `class: "Common"` tile in `12t_projects/bible/index.html` (`common_revisedArt`, `common_revisedMagic`, `common_revisedSkill`, `common_statPlus`, `common_superStatPlus`), not duplicated per class. **Skip these five when running the per-class research pipeline below** — reference the existing Common cards instead of re-deriving them. The separate 12-card Common support batch (Replenishment through Divine Channel) is now fully researched and authored; unlike the five universal skills, each card has its own source-class level formula and must retain its individual source proof and `supportSourceClass` / `supportFormula` wiring.

---

### 5.A. Active Skill Pipeline

#### Step A1: Pre-Flight Active Source Extraction (Zero Assumptions)
* **Never guess or use generic RPG tropes.**
* Run a temporary scratch script (in `<appDataDir>/brain/<conversation-id>/scratch/`) or `view_file` to trace the full lifecycle across:
  1. **Cast Dispatch:** `<Class>.cs` (`RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust` wrappers, per-rank arrays for `maxRank > 1`).
  2. **Execution & Companion Logic:** `<Class>_<companion>.cs` (multi-hit loops, secondary triggers, collision handlers).
  3. **Status Effect Tracing (Name, Level, and Classification):**
     * **Status Name (`sType`) & ID:** Exact string passed to `RPC_AddStatus` and integer code `nCode` from `StatusData.cs`.
     * **Status Level (`sLv`):** Exact level passed or calculated at each rank.
     * **Status Classification (via `StatusData.cs`):** Must verify and report exact boolean return values:
       - `isBuffStatus(sType)` / `isDebuffStatus(sType)`
       - `isStateStatus(sType)`
       - `isMagicalStatus(sType)` (eligible for Dispell) vs `isPhysicalStatus(sType)` (physical cleanses)
       - `isLockStatus(sType)` / `isShieldStatus(sType)` / `isSystemStatus(sType)`
     * **Target & Stat Deltas:** Target (`self`, `ally`, `enemy`), class restrictions, stat adjustments (`deltaAtk`, `deltaDef`, `deltaRunSpeed`), periodic ticks in `mod`, and removal in `removeStatus`.
  4. **Multi-Rank Icon Completeness:**
     * For any skill with `maxRank > 1`, inspect and extract **every rank variant icon** (`<skill>1`, `<skill>2`, `<skill>3`, `<skill>4`, `<skill>5`) from `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/`.
     * **Zero Placeholders Rule:** Never rely on a single rank icon or placeholder when authentic rank-numbered icons exist in ripped game assets.
  5. **In-Game Tooltips:** `<Class>Skill_eng.cs` & `<Class>Skill_thai.cs` (reference for authentic flavor context; code findings always override tooltip errors).
  6. **Passive Dependencies:** Scan for all `hasSkill(ID)` / `get<Passive>Lv()` calls; map to proper tool hooks (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).
  7. **Summon / Companion Trigger (MANDATORY):** If the skill spawns an entity, deploys a turret, or commands a companion (e.g., `RPC_SpawnBarrelBot`, `RPC_CreatePet`, `RPC_KingKaiser`, `BarrelBot.cs`, `Phoenix.cs`, `Gadina.cs`):
     * **IMMEDIATELY activate and strictly adhere to [Section 7](#7-summon-mechanics-companion-movesets--summon-stat-cards) and [Section 8](#8-compatible-skills-navigation-compatskills-conventions).**
     * Separate Main Summon Card (full 9-stat grid) from Child Moveset Cards (selective stat glowing).
     * Strictly separate Player LCK (duration/channel variance) from Summon LCK (damage spread).
     * Suppress duration chips on simulation sub-attacks (`hideDurationChip: true`).
     * Omit `cost` completely on automated companion AI moves.

#### Step A2: Active Observable Proof Review Table
Present a structured review table to the user. Every single active skill entry must include:
1. **Identity Mapping:** Source key / internal name, user-facing card name, and planned `SKILLS.id`. Resolve any naming mismatch here before discussing mechanics or authoring the card.
2. **Cast Dispatch Excerpt (`<Class>.cs:line`):** Exact `addTimeOut`, `DisplayCastBar`, and `RPC_<skill>` call.
3. **Execution / Status Delta Excerpt (`CharacterControl.cs:line` or Companion Script):** Exact code modifying stats, dealing damage/heals, or applying buffs/debuffs.
4. **Status Profile (if status applied):**
   * Name (`sType`), Numeric ID (`nCode`), Status Level (`sLv`) per rank.
   * Full classification breakdown (`Buff`/`Debuff`, `State`, `Magical`/`Physical`, `Lock`, `Shield`).
   * **Rendered Status Badge:** Every applied status MUST be represented in the proposed schema as `status: { name, sLv, class }` (or a `status` array for multiple statuses), producing its `[statusLevel]` keyword badge and classification tooltip. State `None` only when the skill applies no status.
5. **In-Game Client Tooltip (`<Class>Skill_eng.cs:line` & `_thai.cs:line`):** Exact raw strings from client language files.
6. **Proposed Header Tooltip (`desc`):**
   * **In-Game Client Phrasing as Baseline:** Base descriptions directly on authentic client tooltips (Thai strings as primary) to preserve original flavor context and terminology.
   * **Qualitative Over Quantitative:** Strip out all rank-dependent and dependency-scaled quantitative numbers (damage values, durations, tick counts, percentage bonuses) to avoid duplicating or conflicting with live UI calculation chips.
   * **Omit Universal Always-On Side Effects (added 2026-09-17):** Don't restate a mechanic baked into a shared, engine-level system that fires identically across classes and skills, regardless of which one is on the card — it adds no class-specific information and just clutters every desc it touches. Confirmed example: **+1 SP per landed basic-attack hit**, written into each class's own `nAttack` coroutine in near-identical form (verified duplicated across `Monkey.cs:20055`, `Wolf.cs:15292`, `Penguin.cs:29541`, among others — `self.<char>.sp = self.<char>.sp + 1` on the attacker, on every hit). Distinct from `CharacterControl.cs:2122`'s `this.sp++` inside the shared `ApplyDamage()` — that one fires on the character *taking* damage, a different mechanic entirely; don't conflate the two when citing this exemption. Applies only to effects this systemic and this uniformly duplicated — a passive-gated or class-specific proc still belongs in `desc` even if it superficially resembles this pattern.
   * **Always Include Verified Geometries:** Always state exact AoE radii, projectile ranges, and cleanse areas whenever verified from decompiled targeting code (`Damage.FindAreaTarget`, `Damage.FindRecTarget`, OverlapSphere, raycasts).
   * **Dynamic Variable Highlights (`**value**`):**
     * For any qualitative variable that changes with `rank` or passive dependency (`skillDep`), define `desc` as a function: `(rank, depRank) => ...`.
     * Wrap the dynamic value in markdown bold: `**${value}**` (e.g. `**${3 * rank + 2}m**` or `**เลเวล ${x}**`).
     * `renderHero()` automatically parses `**value**` into `<span class="sk-val">value</span>`, styled as **Brass Gold** (`color: var(--gold); font-weight: 600;`).
     * **No Native Browser Tooltip:** Native `title` attribute is explicitly omitted from `.sk-hero-desc` to prevent unsightly default browser tooltip popups.
   * **Highlight Utility & Hidden Mechanics:** Clearly note non-obvious behavior (cleanses, lock removals, sleep breaks, aggro wipes, absolute immunities, unlisted passive hooks).
7. **Proposed Active Card Definition (`index.html` Schema):** Show one complete schema block before requesting approval; do not substitute prose for any field.
   * **Identity:** `id`, `name`, `nameTha`, `class`, `icon` (max-rank icon), `maxRank`.
   * **Complete Chip Audit:** Explicitly account for every applicable field—`cost` (including `spType: "red" | "blue"` whenever `sp` is specified), `cd`/`cdWrapped`, `castTime`/`castWrapped`, `duration`/`durWrapped` (or `durationInfinite`/`hideDurationChip`), `status`, `lckProc`, `ko`/`koDep`, `dmg`/`shield`/`dmgGroups`, hit count, and clamps. State `None` for each category that is not present.
     * **SP Cost Conventions (`spType: "red" | "blue"`, enforced by `scripts/validate_skills.js`):**
       - **Red SP (`spType: "red"`)**: Consumed SP. Corresponds to `cSP < 0` (`skillClass.setSP(-X)`) in decompiled source. Requires and **consumes** SP on cast (`GameGui.cs:37782-37807`: `mChar.sp += cSP`), and is halved by Revised Skill (#404). Rendered in-game as red text `new Color(1f, 0.2f, 0.2f)` (`GameGui.cs:22032`, `Guix.cs:3301`). Standard for almost all physical skills.
       - **Blue SP (`spType: "blue"`)**: Threshold/Activation SP. Corresponds to `cSP > 0` (`skillClass.setSP(X)`) in decompiled source. Checks that the player currently possesses at least that amount of SP (`GameGui.cs:37609`), but **does NOT consume SP** on cast (the `cSP < 0` deduction branch in `GameGui.cs:37782` is bypassed). Rendered in-game as cyan-blue text `new Color(0.2f, 0.6f, 1f)` (`GameGui.cs:22054`, `Guix.cs:3288`). (e.g., Whale's `rejuvenate` Ranks 3–4 requiring 12 SP without spending it).
   * **Simulation & Cross-Links:** List every dependency hook (`cdDep`, `castDep`, `durDep`, `dmgRankDep`, `dmgDep`, `koDep`, `hitCountDep`), any own-stat/summon routing, and proposed reciprocal `compatSkills` links. State `None` when absent.

---

### 5.B. Passive Skill Pipeline

#### Step B1: Pre-Flight Passive Source Extraction (Zero Assumptions)
* **Never assume a passive only affects one place.** Passives have no cast dispatch; their logic is distributed across checks (`hasSkill(ID)`, `get<Passive>Lv()`, `heroSkill.getSkillRank(...)`).
* Systematically scan and trace across the **5 Passive Hook Categories**:
  1. **Stat Alteration Hook:** Modifies base or derived attributes (`CharacterControl.getTypeStat`, `calTotalStat`, `calHp`, `calMp`, `calAtk`, `calDef`, `calSpeed`).
  2. **Active Skill Dependency Hook:** Modifies cooldown, cast time, MP/SP consumption, hit count, or projectile patterns in `<Class>.cs` or companion scripts.
  3. **Status Application / Proc Hook:** Grants on-hit effects, debuff chances, or modifies status levels in `AttackHit`, `MagicHit`, or `mod`.
  4. **AI / Companion Hook:** Modifies summon pet stats, attack intervals, or AI behaviors (e.g. `Phoenix.cs`, `Gadina.cs`, `BarrelBot.cs`, `HeavyBuilt`, `SynchroMole`, `HiddenTurret`). **MANDATORY:** Cross-reference [Section 7.1](#7-summon-mechanics-companion-movesets--summon-stat-cards) to ensure affected summon stat tables dynamically recalculate when toggled.
  5. **Attack Augmentation Hook:** Modifies normal attack combos or charge attack behaviors (`nAttack`, `cAttack`).
* **Multi-Rank Icon Completeness:** Inspect and extract every rank variant icon (`<passive>1`..`<passive><maxRank>`) from `RippedAssets/`.
* **Cross-Linking Target Audit:** Identify and list **every active skill** altered by this passive to ensure interactive dependency wiring (`*Dep`).

#### Step B2: Passive Observable Proof Review Table
Present a structured review table to the user for every passive entry:
1. **Hook & Logic Excerpt (`file:line`):** Exact source line showing `hasSkill(...)` / `get<Name>Lv()` check and its execution branch.
2. **Mechanics & Formula Derivation:** Precise arithmetic for stat additions, timer scaling, proc chances, or level calculations.
3. **Cross-Linked Active Skills & Dependency Mapping:**
   * List all affected active skills.
   * Proposed dependency toggle constant (`const <CLASS>_<NAME>_DEP = { ... }`) and target hooks (`cdDep`, `castDep`, `durDep`, `dmgRankDep`, `hitCountDep`, `descDep`). If self-contained, declare `None`.
4. **Status Profile (if status granted/applied):** Name (`sType`), Numeric ID (`nCode`), Level (`sLv`), Classification breakdown.
5. **In-Game Client Tooltip (`<Class>Skill_eng.cs:line` & `_thai.cs:line`):** Exact raw strings.
6. **Proposed Card Definition (`index.html` Schema):**
   * **Mandatory Fields:** `id`, `name`, `nameTha`, `class`, `icon` (maxRank icon), `maxRank`, `passive: true`, `desc`.
   * **Rendered Status Badge:** If the passive directly applies or grants a status, its proposed schema MUST include `status: { name, sLv, class }` (or a `status` array for multiple statuses); otherwise explicitly state `status: None`.
   * **Exclusion Rule (revised 2026-09-15 — was previously "MUST NEVER"):** Passive cards *may* carry `cd`, `castTime`, `cost`, `duration`, or `ko` when the passive genuinely has one (e.g. an internal proc cooldown, a real MP/SP tax) — but this is rare; the default expectation for a stat-modifier/dependency passive is still none of these. Don't add one speculatively. (The UI omits `.sk-hero-stats` when empty, collapsing the top row vertically, exactly as before.)
   * **Dynamic Highlights:** Wrap dynamic numerical/stat ranks in `**${value}**` inside `desc`.

### 5.B.3. Finding Preservation Review (All Skill-Details Cards)

* **Zero Silent Omissions:** When composing a skill card's `desc`, account for **every verified finding** from the source extraction. Put every finding that fits a card field into that field (`status`, chips, formula rows, dependency hooks, summon table, `compatSkills`, or `desc`).
* **Required Numbered Remainder List:** Before requesting approval or applying a skill-details card, present every verified finding that does **not** fit an existing card field as a numbered list for user review. Each item must include its `file:line` citation, a concise description of the finding, and why it cannot be represented in the current schema.
* **User Chooses Omissions:** Do not silently discard, simplify away, or decide to omit any item in that numbered list. Ask the user to choose which finding(s), if any, may be omitted; retain the rest in the proposed schema, header description, or a documented follow-up as the user directs. State `None` explicitly when no findings remain outside the card fields.

> ⚠️ **Hard Gate:** Any formula, stat delta, or mechanic presented without its exact `file:line` source citation and code snippet is rejected as unverified by definition.

---

### 5.C. Shared Gates, Application & Verification

#### Step 3: Strict Single-Class User Gate
* Process strictly **one class at a time**.
* **Hard STOP:** Wait for explicit user review and approval before writing changes to `index.html` or advancing to the next class.

#### Step 3.5: Close the SkillDep Loop
* When a skill's own review/apply introduces a real `dep`/`dmgDep`/`cdDep`/`hitCountDep`/etc. pointing at ANOTHER skill that has no `SKILLS` card of its own yet (only a standalone dep object built ahead of time, e.g. `GADINA_TITANSWORD_DEP` before Titan Sword existed, or `MNK_GROUNDLOCK_AEGIS_DEP`/`MNK_GROUNDLOCK_SECONDSTONE_DEP` before Aegis of Earth/Second Stone existed), **proactively name those related skills and urge doing them next** — even if they're passives, and even if the original research plan deferred them to a later batch. A dep object with no card behind it is only half the loop.
* This takes priority over whatever the next item in the pre-planned batch/queue order happens to be — ask the user explicitly rather than silently defaulting back to the original queue.

#### Step 4: Apply, Verify & Lint
* Apply changes to deliverables using authentic PNG header icons (`89 50 4E 47 0D 0A 1A 0A`) for all ranks 1..maxRank.
* **Bible Changelog Freshness Gate:** Before every commit with tracked workspace changes, prepend a `CHANGELOG_DATA.entries` item in `12t_projects/bible/index.html` using the **exact planned commit subject** and the current ISO timestamp. `node scripts/validate_skills.js` rejects a dirty tree whose panel still names `HEAD`, and rejects a clean tree whose newest panel entry does not match `HEAD`. Run it once with the prepared entry before committing, then again after committing before pushing. Never push a commit that fails this check.
* Execute automated integrity test suite: `node scripts/validate_skills.js` (validates all skills, formula permutations across ranks 1..maxRank and dependencies, and icon assets).
* **Summon & Companion Checklist:** If skills involve summons or companion moves, verify 100% adherence to [Section 7](#7-summon-mechanics-companion-movesets--summon-stat-cards) (selective stat glowing, LCK separation for damage vs duration variance, `hideDurationChip: true` where applicable, automated move cost omission) and [Section 8](#8-compatible-skills-navigation-compatskills-conventions) (bidirectional `compatSkills`, Prompt Gold 14px header, 42px full-height icons).
* **Strict Ban on Routine Visual Checks:** Do NOT launch the browser subagent (`browser_subagent`) or capture visual screenshots for skill additions, formula corrections, tooltip text, or small fixes. Verification must be performed strictly via `node scripts/validate_skills.js` and git diffs. Visual browser checks are strictly reserved for major layout/CSS redesigns or when the user explicitly requests a visual check.

---

## 6. Large File Handling & Crash Prevention Protocol (Mandatory for index.html)

`12t_projects/bible/index.html` is **>6.4 MB** because it embeds 670 game icons as raw Base64 data URIs (lines ~3,600 to ~9,600). Ingesting this into an AI chat context triggers token exhaustion, emergency context truncations (`CHECKPOINT 0`), memory loss, and recursive crash loops.

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
   * If the tree is dirty, inspect and preserve unrelated changes; do not commit or revert them.

5. **Mandatory Post-Edit Verification:**
   * Immediately after any patch script runs, execute:
     `node scripts/validate_skills.js`
   * Confirm that 100% of skills, formula permutations, and icons continue to pass automated integrity checks.

---

## 7. Summon Mechanics, Companion Movesets & Summon Stat Cards

When working with summon skills (Barrel Bot, King Kaiser, Auto Gyro Gun, Phoenix, etc.):

1. **Main Summon Card vs Child Moveset Cards:**
   * **Main Summon Card** (`mole_barrelBot`, `mole_kingKaiser`, `mole_autoGyroGun`):
     - Displays the full 9-stat Summon Status grid (`mhp`, `atk`, `def`, `agi`, `vit`, `mag`, `cha`, `tal`, `lck`).
     - All 9 stats are colorized/accented when responsive to summon upgrade toggles (`heavyBuilt`, `synchroMole`, `doubleBot`, `hiddenTurret`).
     - Omits `.sk-dmg-row` (Damage Formula row) when the summon cast itself deals no direct damage.
     - Toggle state (e.g. King Kaiser Lv 1..3 icon cycle, Heavy Built, Double Bot, Hidden Turret) dynamically recalculates and updates the summon's stats table.
   * **Child Moveset / Summon-Attack Cards** (`King Kaiser - Normal Attack`, `Barrel Bot - Mega Punch`, `Auto Gyro Gun - ยิงปกติ`):
      - Displays the summon stat row with **selective glowing / stat accents**: only stats actively used by this specific move's calculations (`ATK` for damage, `AGI` for cooldown if `cdWrapped`) glow with their stat accents. Inert stats are dimmed (`.sk-summon-stat-unused`).
     - Enemy DEF mitigation uses target DEF/LCK (`defAdjust`), which does NOT cause the summon's DEF/LCK to glow unless the move itself scales from them.
     - Damage calculations and simulation chips MUST use the **summon's own stats** (`ownStats`, `ownStatsKaiser`, `ownStatsGyro`, `ownStatsDmgOnly`), not the player's stats.
2. **LCK Stat Separation for Summons & Duration Variance:**
   * A summon's own LCK stat (`agg.lck`, `bb.lck`, `kk.lck`) is strictly the **attacker's LCK** for the summon's own hits (`dmgAdjust` / `attackerLCK` / `rMax`).
   * The summon's **duration / channel variance** (e.g. `chaAdjust(120)` or `hitCountDuration` simulation) originates from the PLAYER who cast the summon (Mole). It MUST always calculate duration variance using **Player CHA and Player LCK** (`parseFloat(lckEl.value)`), NEVER the summon's own LCK.
   * In `renderHero()`, never overwrite the top-level `LCK` variable with the summon's LCK; store the summon's LCK in dedicated variables (`gyroOwnLCK`, `bbOwnLCK`) for `attackerLCK`.
3. **Duration Chip Suppression on Sub-Attacks:**
   * Summon attack cards that define `duration` and `hitCountDuration` strictly for simulation hit count math (e.g. `Auto Gyro Gun - ยิงปกติ`) must declare `hideDurationChip: true`.
   * Adhering to the Vertical Collapse Convention, omitting CD, Cast, Duration, and LCK Proc chips causes `.sk-hero-stats` to collapse completely with zero preserved height.
4. **Resource Badges / Cost Policy on Summon AI Moves:**
   * Automated summon pet attacks / AI moves (`mole_barrelBot_nAttack`, `punch`, `hammer`, `chopper`, `missile`, `drill`, `cannon (Auto)`) must omit `cost` completely. Never show "Free" or SP/MP badges for automated companion moves.
   * Active player command skills where the player casts and spends resources (e.g. `Barrel Bot - Barrel Cannon` non-Auto, costing 50 SP) keep their explicit `cost`.
5. **Stat Accent Tokens:**
   * 8 core stats + HP + CHAR LV use dedicated CSS color variables (`--stat-atk`, `--stat-def`, `--stat-agi`, `--stat-vit`, `--stat-int`, `--stat-cha`, `--stat-tal`, `--stat-lck`, `--stat-lv`, `--stat-hp`). **Don't hardcode hex values for these in this doc** — a prior version of this bullet did, and several had silently drifted wrong (TAL/LCK/HP were miscited, and INT was recolored pink on 2026-09-14 without this doc being updated at the time). The tokens exist once, in `index.html`'s `:root` / dark-theme blocks — check there before citing a specific value elsewhere. See [Section 9](#9-player-stat-input-highlighting-stat-signature-accents) for the full mechanism that consumes them.

---

## 8. Compatible Skills Navigation (`compatSkills`) Conventions

When linking related skills (e.g. Mass Cast targets, Barrel Bot moves, King Kaiser weapons, Auto Gyro Gun):

1. **Bidirectional Policy (revised 2026-09-15, per direct user request — replaces the prior "main skill only" hub rule):** Every `compatSkills` edge must be reciprocated. If skill A lists skill B, skill B's own `compatSkills` must list A back. This applies uniformly to summon/mass-cast hubs (e.g. `bat_massCast` → its 15 spell targets; `mole_barrelBot`/`mole_kingKaiser`/`mole_autoGyroGun` → their child moves) and to small skillDep clusters (e.g. Ground Lock ↔ Aegis of Earth ↔ Second Stone) alike — there is no longer a distinct "hub" category with different rules.
   * **Sibling-mesh curation (revised 2026-09-17, per direct user request — drops the prior "reciprocal-edge only, not a full sibling mesh" restriction):** A child/target is no longer limited to linking back only to its parent(s). A full sibling-to-sibling mesh (every child in a hub linking to every other child) is allowed even with no shared mechanical dependency between them (e.g. the 5 Gaos moveset children were meshed together purely for navigation convenience). This is curated case by case by the user, not gated behind a rule — don't assume reciprocal-to-parent-only is the default; ask the user when unsure how thorough a given hub's mesh should be.
   * Previously, hub children (Barrel Bot's moves, King Kaiser's moves, Auto Gyro Gun's move, Bat's Mass Cast targets) were forbidden from defining `compatSkills` at all, to avoid navigation clutter for a hub with many children. That restriction is lifted — clutter/loop concerns are secondary to letting a player navigate back to the parent from any child card.
   * When trimming a `compatSkills` list (e.g. dropping generic/low-value entries), also remove or update the corresponding reverse edge on the skill(s) being dropped so the graph doesn't end up one-directional again.
2. **Header & Typography:**
   * Header text is strictly `<p class="sk-compat-title">สกิลที่เกี่ยวข้อง</p>`.
   * Styled with Google Fonts **Prompt**, Brass Gold (`color: var(--gold); font-size: 14px; font-weight: 600; letter-spacing: .04em; margin: 0 0 10px 2px;`).
   * Redundant English badges (`LINK`, `MASS CAST`, `MOVES`) and duplicate headers are strictly prohibited.
3. **Container Spacing & Clearance:**
   * Container row `.sk-compat-row` has `margin-top: 14px;`, guaranteeing clean clearance below Position 5-8 (`.sk-dmg-row`) so it never sticks to the row above.
   * Card `.sk-compat-chip` has `padding: 12px 14px; background: var(--panel); border: 1px solid var(--line); border-radius: 4px; box-shadow: 0 1px 3px rgba(0,0,0,0.25);`.
4. **Full-Height Chip Icon & 2-Line Text Geometry:**
   * Button `.sk-compat-item`: `display: flex; align-items: center; height: 44px; padding: 0 10px 0 0; border-radius: 6px; overflow: hidden;`.
   * Icon `img.sk-compat-icon`: `width: 42px; height: 42px;` occupying the **full inner height** of the chip on the left edge, with subtle divider `border-right: 1px solid rgba(255,255,255,0.08)`.
   * Skill name `.sk-compat-name`: to the right of the icon (`flex: 1; margin-left: 9px; font-size: 11.5px; line-height: 1.22; font-weight: 500;`).
   * **2-Line Height Boundary:** Long names that wrap to 2 lines (`-webkit-line-clamp: 2`) measure ~28px total, staying strictly within the 42px icon height so chips maintain consistent alignment without bulging.
5. **Grid Behavior & No Artificial Clamping:**
   * `.sk-compat-grid`: `display: grid; grid-template-columns: repeat(auto-fill, minmax(170px, 1fr)); gap: 8px 10px;`.
   * `.sk-compat-few-grid` (2-4 items, e.g. King Kaiser with 3 skills): `grid-template-columns: repeat(auto-fit, minmax(170px, 1fr));` with NO restrictive `max-width` clamping, ensuring all items fit in **1 single row** on desktop.
   * `.sk-compat-single-grid` (1 item): `max-width: 340px;` with `"คลิกเพื่อดูสกิล →"`.

---

## 9. Player Stat Input Highlighting (Stat Signature Accents)

Added 2026-09-14. Distinct from Section 7's summon-stat-table glowing (which colors cells inside a *summon's own* 9-stat block, e.g. the "Barrel Bot Stats" chip) — this colors the **player's own global stat inputs** (`.sk-controls`: ATK/DEF/TAL/AGI/VIT/CHA/INT/LCK/CHAR LV) whenever the currently selected skill's own displayed chips genuinely read that input.

1. **`getUsedPlayerStatKeys(skill)`** (`index.html`, next to `getUsedOwnStatKeys`): a structural function — reads `SKILLS` fields directly (`cdWrapped`, `castWrapped`, `durWrapped`/`durContested`, `dmg`/`shield` text, `atkCoeff`, `defCoeff`, `lckProc`, dep objects) rather than threading through `renderHero()`'s runtime branches. Returns a `Set` of stat keys (`atk`/`def`/`tal`/`agi`/`vit`/`cha`/`int`/`lck`/`lv`).
2. **CSS**: `.sk-stat-glow-<key>` classes (toggled on each input's wrapping `<div>`, once per `renderHero()` call) set one `--sg-color` custom property to that stat's own `--stat-<key>` token; shared `[class^="sk-stat-glow-"]` rules apply it as the input's border color, label color, number text color, and a soft **static** `box-shadow` glow. **No animation** — an earlier pulsing-gold-only version was tried and explicitly rejected by the user in favor of this per-stat, non-animated treatment. The number-text color rule (added 2026-09-14) shares the same selector as the border/glow rule rather than needing its own `:focus` override — that selector's specificity (0,3,2) already beats `.sk-controls input[type=number]:focus`'s own `color:#ffffff` (0,3,1), so the accent color persists even while the input is focused, consistent with how the border/glow already behaved.
3. **`defCoeff`** is the DEF-equivalent of `atkCoeff` (Whale's Shield Rush/Flying Shield/Homing Shield only, so far) — a flat coefficient of the caster's own DEF added to the damage formula. Easy to miss: it was missed on the first pass and had to be added as a follow-up fix.
4. **CHAR LV (`lv`) detection** — no chip literally labeled "LV" exists, so this isn't a simple field check:
   * A Class C dep's own display `term` literally contains the substring `"LV"` (`dmgDep`/`shieldDep` — Mana Missile's More Missile, Mana Arc's Penguin of Arc, TNT's Super TNT, Mix's Extra Potion, Ice Shield's Frost Spike).
   * `skill.ownStats` or `skill.ownStatsDmgOnly` — both route through `barrelBotOwnStats()`, whose Double Bot bonus (`floor(0.5×moleLV)`) is added to every one of Barrel Bot's own stats.
   * `skill.ownStatsGyro` — routes through `autoGyroGunOwnStats()`, whose Hidden Turret bonus is `floor(0.25×rank×moleLV)`.
   * `kingKaiserOwnStats()`/`phoenixOwnStats()` take **no** LV parameter at all — King Kaiser and Phoenix skills never glow LV, regardless of `ownStatsKaiser`/`ownStatsPhoenix`.
   * **Live-toggle gated, not just structural** — changed 2026-09-14, per user feedback: every one of the above ONLY glows LV while its controlling dep is actually switched on (`getDepRank(dep) === dep.maxRank`, the exact same live value `renderDepBlock` reads to draw the dep's own on/off toggle chip) — Mana Missile's LV term is completely absent from the formula until More Missile is toggled on, so glowing LV regardless of that toggle's state showed a stat that wasn't really contributing. Applies to all 5 `dmgDep`/`shieldDep` cases, `dmgReplaceDep.coeff`, and the `ownStats`/`ownStatsDmgOnly`→`MOLE_DOUBLEBOT_DEP` / `ownStatsGyro`→`MOLE_HIDDENTURRET_DEP` pairs alike.
5. **LCK glows only on a DIRECT read of the stat** (`lckProc`'s own chance chip, a literal `lckCoeff` formula term, or an inline `lckAdjust()` call in the formula text) — changed 2026-09-14, per user feedback. Previously LCK also glowed alongside AGI/INT/CHA/TAL/ATK/DEF any time their own `*Adjust` wrapper ran at all (`cdWrapped`, `castWrapped`, `durWrapped`, a `talAdjust`/`atkCoeff`/`defCoeff` damage formula), because `agiAdjust`/`magAdjust`/`chaAdjust`/`talAdjust`/`dmgAdjust`/`defAdjust` all bake an LCK-derived roll into their own variance range ambiently. That's true of nearly every chip, so LCK glowed almost constantly and taught users nothing. The same exclusion applies to `getUsedOwnStatKeys` (summon stat tables, [Section 7](#7-summon-mechanics-companion-movesets--summon-stat-cards)) — ambient LCK-roll usage doesn't glow there either, only a direct `lckProc`/`lckCoeff`/`lckAdjust()` read. This also covers indirect-by-nature mechanics not yet in the tool (e.g. Cat's Gambler-class damage calc, cited by the user as the same category of "don't glow").
6. **Own-stat exclusion rules** (which own-stat variant hides which player input, since the real attacker isn't the player for that chip):
   * `ownStats` (Barrel Bot's 8 moveset children): fully summon-sourced — AGI/ATK/TAL never glow; only LV glows (via Double Bot).
   * `ownStatsDmgOnly` (Barrel Cannon): ATK/TAL excluded (Barrel Bot's own stats), but AGI still glows for Cooldown (genuinely Mole's own, per its own citation trail) and LV still glows.
   * `ownStatsKaiser` (King Kaiser moves): ATK/TAL excluded; no Cooldown chip exists on any King Kaiser move at all, so AGI never applies; no LV (per point 4).
   * `ownStatsPhoenix` (Phoenix, including the base summon skill): TAL excluded (Phoenix's own stat); AGI/CHA/INT still glow for Cooldown/Cast Time/Duration, which stay Monkey's own (Rebirth Chance's LCK glows only via its direct `lckProc` read, unaffected by this exclusion list). No LV.
   * `phoenixFireballCd` (Phoenix Fireball only): Cooldown glows **INT**, not AGI — Rapid Fire scales off Monkey's own INT (`Phoenix.cs:2562-2573`), a real, deliberately atypical exception verified against source, not an oversight to "fix" later. **Also live-toggle gated** (2026-09-14): INT only glows while `cdDep` (Rapid Fire) has any rank invested (`getDepRank(skill.cdDep) > 0`, not `=== maxRank` — Rapid Fire is a 0-3 investment, not a binary toggle, and any positive rank already contributes a nonzero factor per `phoenixFireballPassiveFactor`). At rank 0 the render path falls back to a flat, INT-free `cd:5`, so INT correctly stops glowing there too.
7. **Verified via a scratch VM harness** (2026-09-14, `scripts/validate_skills.js`'s own sandbox pattern — loads `index.html`'s script into a `vm` context with a DOM shim and calls `mountSkillCooldownLookup`) rather than code review alone: toggling `moreMissile`/`rapidFire` between 0 and their max rank and calling `getUsedPlayerStatKeys` directly confirmed `lv`/`int` appear and disappear exactly as designed, with the sibling stats that are NOT dep-gated (`agi`/`tal` on Mana Missile) staying glowed throughout.

