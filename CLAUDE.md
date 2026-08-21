# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this project is

Reverse-engineering and documentation workspace for **12 Tails Online**, a Unity MMORPG. There is no
build, run, or test step — this repo is (1) a decompiled, obfuscated C# source dump used as read-only
reference material, and (2) a set of hand-built, self-contained deliverables (HTML infographics, data
references) derived from reading that source. Treat every task here as either "read the decompiled
source to extract a verified fact" or "build/update a static single-file artifact."

## Keeping this file and the repo layout accurate

- When you introduce a new top-level folder, rename one, or establish a new convention, **update this
  file in the same session** — don't leave it to drift into a stale map of the repo.
- New verified game-knowledge docs (mechanics formulas, per-class skill data references) go in
  **`12t_reference/`** — never loose at the repo root or scattered into `docs/`.
- New deliverables (skill sheets, maps, calculators, any shipped artifact) go in their own sub-folder
  under **`12t_projects/`** — never loose at the repo root.

## Where the real source is (important — don't get this backwards)

- **The ~1,455 `.cs` files in `DecompiledSource/`** (`CharacterData.cs`, `GoldenKingBug.cs`,
  `M946_GoldenKingBug.cs`, etc. — flat, no further subfolders inside it) are the **actual decompiled game
  source** — this is what to read and cite. **Moved here from the repo root on 2026-08-18** (previously
  loose at the top level); citations throughout this repo (`12t_reference/*.md`, this file's own history,
  `player-reference-tool/CLAUDE.md`'s dated passes) still just say `Penguin.cs:20624` etc. with no path
  prefix — that bare-filename citation format didn't change, only where the file actually lives. If you're
  reading an older doc/commit message that says "at the repo root," mentally substitute `DecompiledSource/`.
- **`RippedAssets/ExportedProject/Assets/Scripts/Assembly-UnityScript/*.cs`** (same filenames as above)
  are **all AssetRipper dummy stubs** — empty placeholder classes AssetRipper generates when it can't
  recover script bodies. Every single one of the 1,317 files there is a boilerplate "Dummy class..."
  explanation, not real code. **Never read scripts from this path expecting logic** — always use the
  `DecompiledSource/` file of the same name instead.
- `RippedAssets/` is still the right place for everything AssetRipper *could* recover: meshes
  (`Assets/Mesh/*.asset`), materials, textures, scene transforms (`Assets/Scene/*.unity`), and prefabs.
  These are legitimate and were used, e.g., to reconstruct exact spawn-point coordinates and collision
  geometry.
- `RippedAssets/`, `12TailsOnline_Data/`, `DecompiledSource/`, and `Scaffolding/` are all git-ignored (see
  `.gitignore`) — never `git add -A`/`git add .` here, always add specific files.
- **`Scaffolding/`** (moved out of the repo root alongside `DecompiledSource/`, same date) holds pure
  compiler-generated noise, not game logic: `$ArrayType$*.cs`, `-Module-*.cs`,
  `-PrivateImplementationDetails-*.cs`, and the decompiler's own `Assembly-UnityScript.csproj`/
  `.g.resources` project files (not buildable, no reason to build them). Safe to ignore entirely for any
  task in this repo.

## Reading the decompiled source

The source was run through an obfuscator; expect this on every file:
- **Junk predicates** wrapping real logic for no functional reason, e.g.
  `if (68549 - 287643 != -219094) { ... }` — the condition is always true/false and can be ignored when
  tracing logic, but don't delete it if quoting a source excerpt.
- **Mangled identifiers** for compiler-added fields/helpers, e.g. `this.$mSpawnPoint$44454`,
  `LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn()` — these are noise around otherwise-readable game logic
  (real method/class names like `CharacterData`, `getTypeStat`, `createActor` are intact).
- File naming conventions: `M<missionNumber>_<Name>.cs` for mission/instance scripts (e.g.
  `M946_GoldenKingBug.cs`), `<Class>_<skillName>.cs` for individual skill scripts (e.g.
  `Bat_illusionFire.cs`), `<Class>Skill.cs` for a class's skill cost/rank table, `_eng`/`_th` suffixes for
  localized text variants of the same script.
- **Before treating a skill's mechanic as fully traced from `<Class>.cs` alone, check for a companion
  `<Class>_<skillName>.cs` file — automatically, as a standard first step, not only when something looks
  incomplete or the user has to ask.** `<Class>.cs` (Mole.cs, Penguin.cs, …) holds the cast/dispatch
  coroutine for every skill in that class, but a skill whose behavior needs its own `MonoBehaviour`
  (a summoned prop, projectile, pet, or deployed structure) frequently puts the ACTUAL payoff — the real
  damage call, a multi-hit loop, a status proc — in that companion file instead, with `<Class>.cs` itself
  only spawning it. Two real, separately-caught misses from this exact gap: Napalm's true per-projectile
  5×6-pulse mechanic lived in `Mole_napalm.cs`, not `Mole.cs`, initially missed; War Factory's "Cart Bomb"
  action needed `Mole_cartBomb.cs` checked to confirm it carries no damage logic at all (it's the
  structure's own deploy coroutine, not a 5th sub-attack) before that could be written down as fact
  rather than a guess. **Use `ls`/`find` via Bash for this check, not the `Glob` tool** —
  `DecompiledSource/` (like `RippedAssets/`) is gitignored, and `Glob` silently returns "no files found"
  for gitignored paths instead of erroring, which reads exactly like "no companion file exists" when it
  actually means "the tool didn't look." Confirmed live, 2026-08-20 (BarrelBot pass): `Glob
  DecompiledSource/BarrelBot*.cs` returned nothing; `ls DecompiledSource/ | grep -i barrelbot` in the same
  moment found 4 real files (`BarrelBot.cs`, `BarrelBotAI.cs`, `BarrelBot_cannon.cs`,
  `BarrelBot_missile.cs`). `ls DecompiledSource/ | grep -i <skillName>` (or `find DecompiledSource -iname
  '*<skillName>*'`) — or `*<summonedPropName>*` if the summon's own name differs from the skill's — before
  concluding "no companion file worth checking." Don't wait for it to become a visible gap in the tool's
  data before doing this. **Checking for the file
  is not the same claim as reading it to its actual end** — confirmed as a real, separate miss the very
  next time this rule was applied (Mole's War Factory "Cart Bomb," 2026-08-20): the companion file WAS
  found and opened, but reading stopped around what looked like the natural end of a short, simple
  `MonoBehaviour` — the real damage-dealing call was later in that same file's `Update()`. Same discipline
  this file's own reference docs already apply to a single obfuscated function's control flow ("read to
  the actual closing brace and final `return`, don't stop at the first plausible-looking point") applies
  one level up to a companion file too — finish reading it, don't stop at a plausible-looking end.
- Always cite extracted facts as `file:line` (or a line range) — every existing doc in this repo does
  this and it's how numbers get re-verified later.

## Ground-truth reference docs (read these before re-deriving a formula)

- **`12t_reference/12Tails-Mechanics-Reference.md`** — verified core mechanics: the 8-stat system, derived HP/MP/KO/SP,
  per-class growth tables, level-scaling formula. Cross-check any stat/damage formula against this before
  re-deriving it from source.
- **`12t_reference/*-skill-reference.md`** — one file per class, **all 12 classes present**
  (added 2026-08-13) — max-rank active-skill cooldown/duration data (`agiAdjust`/`chaAdjust`-wrapped
  status, `revisedArtExempt`) feeding the Skill Cooldown/Duration Lookup tool in `player-reference-tool`
  below. **Renamed 2026-08-20** from `*-skill-cooldown-reference.md` — the tool's own scope had already
  grown well past cooldown alone (Cast Time, Damage Formula, KO, `lckProc`, …) by the time the rename
  happened, so the old "cooldown"-specific filename no longer matched what the tool — or, for some
  classes, this doc family itself — actually covers; every citation elsewhere in this repo that used the
  old filename was updated in the same pass, `git mv`'d so history follows. **Narrower scope than the
  `*-skill-damage-reference.md` docs below** (cooldown/duration/cast-time only, no damage formulas,
  active skills only) for the 10 classes that don't yet have a damage companion doc — don't conflate the
  two doc families. **Cast Time (added 2026-08-14) has no matching `*-casttime-reference.md` doc family**
  — unlike cooldown/duration, its 104-skill (of 306) research pass was distilled straight into
  `index.html`'s own `SKILLS` entries (`castTime`/`castWrapped`/`castDep` fields) and dated notes in
  `player-reference-tool/CLAUDE.md`, not written out as separate per-class markdown docs. Don't go
  looking for a cast-time equivalent of these cooldown docs — it doesn't exist; the tool's own
  data/CLAUDE.md notes are the citation trail.
- **`12t_reference/*-skill-damage-reference.md`** — per-class damage-formula/rank-selector companion
  data (`maxRank`, per-rank `cd`/`castTime`/`duration` arrays, `dmg`, dep/mult mechanisms, `hitCount`) —
  currently **3 of 12 classes** (Penguin, Mole, Chameleon — added 2026-08-21), added as each class gets
  the rank-selector/damage-chip treatment described under "Rank selector + damage formula" in
  `player-reference-tool/CLAUDE.md`, not all at once. Penguin's copy is the original, pre-dating this
  naming convention — it shipped as the
  dated `2026-07-21-penguin-skill-data-reference.md` (the class's initial full research pass, source of
  truth for the interactive skill sheet in `12t_projects/` too) and was **renamed to
  `penguin-skill-damage-reference.md` in the same 2026-08-20 pass**, to match Mole's already-established
  `mole-skill-damage-reference.md` naming instead of carrying its own one-off scheme forward.
- **Decompiled source can lag the *live* server, not just the repo's own history** — confirmed 2026-08-14:
  `Mole_stunMine.cs:60` still reads `talAdjust(60)` for Stun Mine's duration, but the user confirmed the
  live game has since been patched to `chaAdjust(60)` (matching sibling `mine`'s behavior). When a
  decompiled-source citation and direct user testing disagree, the user's live observation wins — update
  the doc/tool and leave a note (see `12t_reference/mole-skill-reference.md`'s `stunMine`
  citation for the pattern) rather than trusting the source blindly just because it's the thing you can
  grep.

## Repo layout

- **`12t_projects/`** — the actual deliverables, one sub-folder per project (e.g.
  `penguin-skill-sheet/`, `stat-gain-tables/`, `goldenkingbug-spawn-map/`). This convention was
  established 2026-07-31 — **every new deliverable gets its own sub-folder here**, not a loose file at
  the repo root.
- **`12t_projects/goldenkingbug-spawn-map/`** — a 3D (Three.js) boss-spawn/warp-point map, published as
  its own Artifact (2026-08-12). Has its own `CLAUDE.md` with the Artifact URL to republish in place —
  check it before publishing this one, omitting `url:` forks a duplicate. Linked from the
  `player-reference-tool` hub below as a link-out entry, not merged into it.
- **`12t_projects/player-reference-tool/`** — the "12 Tails Tools" Artifact, a single-file multi-tool
  hub for player-facing reference calculators. **Policy (set 2026-08-12): new tools are added as links
  out to their own separate Artifacts, never mounted inline into this hub's `TOOLS` registry** — a
  same-day attempt to inline-embed the GoldenKingBug Spawn Map (a ~700KB Three.js scene) was reverted
  specifically because of this; don't repeat that approach. **3 tools total** (as of 2026-08-13): two
  mounted inline (Stat-Gain Calculator, and Skill Cooldown/Duration Lookup — added 2026-08-13, small
  enough per the user to be a 2nd exception to the link-out default) and one link-out (GoldenKingBug
  Spawn Map, pointing at `12t_projects/goldenkingbug-spawn-map/`'s own Artifact). The ledger index is a
  2-column chip grid (since 2026-08-12, collapses to 1 column under 560px), not the original full-width
  row list. Has its own `CLAUDE.md` documenting the "Ledger" visual design system (Thai temple
  lacquerware — deep lacquer ground, brass-gold ink, oxblood-red accent) — **read it before touching
  this project's UI**, its conventions differ from the rest of this repo's infographic-style
  deliverables; that `CLAUDE.md` also documents the shared-`#toolMount` container-per-tool fix that
  landed alongside the 2nd mounted tool. Publish updates with the `publish-player-reference-tool` skill
  (or `/publish-player-reference-tool`) — it always targets the tool's existing Artifact URL in place;
  never publish this one without the `url:` param or it forks a duplicate. **Skill Cooldown/Duration
  Lookup grew a 3rd Cast Time chip 2026-08-14** (MAG/INT-based, `magAdjust()`, new INT control alongside
  AGI/CHA/LCK; 104 of 306 skills have one) plus a `castDep` mechanism (Chameleon's Improved Slayer
  stepper, Whale's Reduced Cast toggle) — see `player-reference-tool/CLAUDE.md`'s dated 2026-08-14 notes
  for the full detail, including why `castDep` deliberately does NOT reuse the existing Cooldown/Duration
  `dep` pattern's post-adjust-multiply order. The 3-stat row is now a fixed CSS grid (not flex) so a
  skill missing one of the three leaves that column blank instead of stretching its neighbors, and any
  dep/private-server toggle sits absolutely positioned in the box's own corner instead of adding a new
  row underneath — **not visually verified live**, no browser tool was available in the session that
  built it.
- **Penguin's Damage Formula chip grew a full "Final Damage" pipeline + a "Mods" popup, 2026-08-16.**
  Damage now chains all 4 real stages (attacker's `dmgAdjust`, target's `defAdjust`, target's `hitMod`,
  on top of the existing `talAdjust`-based Raw Damage), shown as a `[min,max]` range against 3 real named
  enemy presets plus an opt-in one-hit "Test" simulation using real damage-digit textures. `damageMod`/
  `hitMod` (both real, previously-missing `CharacterControl` fields) are now user-controllable via a new
  "Mods" popup — a curated 5-buff subset out of 13 found by sweeping the source. Also filled in 3 more
  Class C damage dependencies (`penguinOfArc` on Mana Arc, `frostSpike` on a new Ice Shield "Shield
  Formula" row, `giantStar` on Falling Stars/Comets — the tool's first *multiplicative* dep, initially
  missed and caught by the user against the real in-game tooltip) and fixed 2 real bugs (ATK/TAL/CHAR-LV
  inputs never triggered a re-render; the Final Damage range could render outside its own chip). Full
  detail — every formula citation, both `defAdjust` misreads corrected mid-session, every Python
  cross-check — is in `player-reference-tool/CLAUDE.md`'s 15th-through-22nd dated passes; see
  `HANDOFF.md`'s 2026-08-16 entry for the session-level summary.
- **The Final Damage chip's "Test" button grew a full multi-hit Simulate display, 2026-08-17, now live and
  visually verified against the real published Artifact (the first session with Playwright available since
  this damage-formula work began).** For skills that fire more than once per cast (`manaMissile`,
  `fallingComets`, `blizzard`, `tornado`, `arcticWind` so far — every Penguin damage skill without a
  `hitCount`/`hitCountDuration` field still defaults to the original single-hit behavior), Test now shows a
  grid of independently-rolled small numbers plus a full-size running total, all in a persistent overlay
  positioned in the open space to the right of the tool shell — **not** inside the cramped Final Damage
  chip itself. Two real bugs only reproduced on the *live* Artifact (never in local dev, which lacks the
  `.view` wrapper/iframe): `position:fixed` silently resolving against `.view`'s small box instead of the
  true viewport, and a genuine 0-width collapse on doubly-nested `position:absolute` boxes with no explicit
  width — both fixed and re-verified live, not just re-implemented in Node. Single-hit Simulate was later
  unified into this same code path (no more separate chip-local popup). Full blow-by-blow — every formula
  citation for the 4 newly-wired skills (including Blizzard's real "excludes the locked target" mechanic,
  reinterpreted per the user's own instruction rather than skipped), the publish/share-pin debugging
  detour, and the Mods popup's new 3rd "Final Multiplier" category (a synthetic, non-additive pipeline
  stage distinct from real `hitMod`) — is in `player-reference-tool/CLAUDE.md`'s 24th pass; see
  `HANDOFF.md`'s 2026-08-17 entry for the session-level summary.
- **The rank-selector/damage-formula feature (previously Penguin-only) was extended to Mole, 2026-08-18**
  — the 2nd of 12 classes, done as an explicit single-class scope, not a template blindly repeated for
  the other 10. Found a genuinely new formula shape (`0.5×ATK + talAdjust(...)`, several Mole skills add
  a flat ATK-stat term the engine didn't support before — new `atkCoeff` field), a rank-dependent Class C
  dep (`superTNT5`, needed `dmgDep.calc`/`term` to optionally take the skill's own rank, not just LV),
  and fixed a pre-existing icon-key bug (8 Mole Class-C-tier skills shipped pointing at a nonexistent
  `...1` icon file instead of the real `...5` one — same family as Penguin's original 6 mislabeled keys).
  Full detail and every formula citation in the new `12t_reference/mole-skill-damage-reference.md` and
  `player-reference-tool/CLAUDE.md`'s dated section — **not visually verified live**, no browser tool
  available this session.
- **Mole declared fully complete, 2026-08-21** — user's own call, the 2nd class (after Penguin) held to
  this bar. Reached across many sessions since the 2026-08-18 rollout above: War Factory split into 5
  entries, Barrel Bot split into 8 (plus its own independent stat block, `revisedArt5` exemption fix, and
  real-Mole-icon-with-caster-badge reformat), King Kaiser split into 3, a full 8-stat-+-mhp own-stats
  table with real `doubleBot5`/`synchroMole`/Heavy Built dependencies, and a real tool-wide CSS bug found
  and fixed (a stray `*/` inside a comment had silently broken styling for every skill in every class, not
  just Mole's — see `player-reference-tool/CLAUDE.md`'s own dated section for the diagnosis). Full detail
  across many dated passes in `player-reference-tool/CLAUDE.md`; see `HANDOFF.md`'s 2026-08-21 entry for
  the session-level summary. 10 classes (Bat, Bison, Cat, Chameleon, Monkey, Panda, Rabbit, Sheep, Whale,
  Wolf) remain below this bar.
- **`.claude/`** — harness config specific to this repo, ported 2026-08-12 from a Desktop copy of this
  project and adapted to this repo's actual layout: `agents/mechanics-researcher.md` (read-only agent
  that traces skill/damage/heal formulas through the decompiled source — prefer it over ad-hoc `.cs`
  reading for "what does skill X actually do" questions), `skills/decode-character-stats/` (hex-decodes
  monster/structure base stats straight out of the `12TailsOnline_Data/` binaries for the common case
  where the decompiled `.cs` only has placeholder values and there's no `MonsterData.cs` table; field
  order re-verified against this repo's own `CharacterControl.cs`, no ilspycmd/DLL step needed here),
  and `hooks/guard-decompiled-and-data.sh` (wired via `settings.json`) which denies any Edit/Write to a
  `.cs` file anywhere in the repo, or under `RippedAssets/`/`12TailsOnline_Data/` — this enforces the
  read-only rule in "Where the real source is" above at the tool-call level, not just by convention.
- **`docs/superpowers/plans/`** and **`docs/superpowers/specs/`** — planning/design docs produced by the
  superpowers skill workflow (brainstorming → spec → plan → execution) for each feature. Plans reference
  their deliverable's path directly, so if a deliverable moves, update the plan's path references too.
- **`.superpowers/sdd/`** — subagent-driven-development working state: task briefs, task reports, review
  diffs. **`.superpowers/sdd/progress.md` is the authoritative task-by-task ledger** for in-flight work —
  trust it (and `git log`) over conversation memory of what's been done.
- **`HANDOFF.md`** — a point-in-time session handoff snapshot (state as of a specific date/commit, not a
  living doc). Useful for picking up exactly where a prior session paused, but check `git log` and
  `.superpowers/sdd/progress.md` for anything more recent than its date.

## Deliverable conventions

- Every shipped artifact (skill sheets, spawn maps, calculators) is a **single self-contained HTML
  file** — all CSS/JS/data/icons inline, no external requests, no build step. This is a hard requirement,
  not a style preference: these get published via the Artifact tool, which cannot fetch a separate
  `.js`/`.css` file at runtime, and the file also needs to work by double-clicking it open in a browser
  with no server.
- Git identity for this repo is set locally (not global) to `Jump <jumpthai@gmail.com>`; there is no
  remote configured (`git remote -v` is empty) — it's local-only.
