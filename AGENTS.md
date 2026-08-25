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

## 5. Quality Assurance & Skill Verification Protocol

To eliminate regressions and discrepancies when authoring or updating skill mechanics:

1. **Per-Rank Scaling Audit (`maxRank > 1`)**:
   * Never assume flat scalar properties for skills with multiple ranks.
   * Always inspect the decompiled `RPC_<name>` cast site / `DisplayCastBar` / `addTimeOut` / companion `MonoBehaviour` for `sLv` scaling in:
     * `castTime` (e.g., `2 + 0.5 * sLv` $\rightarrow$ `[2.5, 3, 3.5, 4]`).
     * `cd` (e.g., `[10, 12, 14, 16]`).
     * `duration` / `hitCountDuration` (e.g., dynamic CHA pulse intervals).
2. **Formula & Variable Permutation Validation**:
   * Any formula with variables (`sLv`, `depLv`) or parentheses must evaluate without error across all rank combinations ($1..\text{maxRank}$) and toggle states.
   * Flat arithmetic parser regexes must always support parentheses: `/^[\d\s×*+\-().]+$/`.
3. **Programmatic PNG Header Icon Extraction**:
   * Icons must be extracted directly from `RippedAssets/...` and validated for authentic PNG headers (`89 50 4E 47 0D 0A 1A 0A`). Never use placeholder base64 strings.
5. **Full-Lifecycle End-to-End Execution Trace (Mandatory for All Skills)**:
   * **Never stop early** after reading the initial cast dispatch or a single coroutine.
   * Thoroughly trace the **entire lifecycle** of the skill from initiation to resolution:
     1. **Cast & Wind-up:** `RPC_<skill>`, `DisplayCastBar`, `addTimeOut` / cooldown application.
     2. **Multi-Phase Transitions:** In-flight coroutines, secondary triggers (e.g. mid-air actions, collision handlers, landing phases), companion `MonoBehaviour` instances.
     3. **All Damage & KO Instances:** Check EVERY `hit()` / `RPC_AddDamage` / `FindAreaTarget` call in all phases (initial hit, mid-air triggers, ground slam / landing, recurring tick loops). Record both `nDamage` formula and `nKo` value for every phase.
     4. **Conditional Passive Branches:** Check all `hasSkill(...)` branches for added hits, modified coefficients, or secondary effects.
     5. **Secondary Effects:** SP/MP recovery or siphoning, debuff status applications (`RPC_AddStatus`), buffs, and summon lifetimes/destruction.
6. **Mandatory Automated Linting**:
   * Before committing, run `node scripts/validate_skills.js` to execute the 100% automated integrity test suite covering all skills, formula permutations, and base64 icon assets.
