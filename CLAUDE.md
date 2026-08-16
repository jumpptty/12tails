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

- **The ~1,470 loose `.cs` files at the repo root** (`CharacterData.cs`, `GoldenKingBug.cs`,
  `M946_GoldenKingBug.cs`, etc.) are the **actual decompiled game source** — this is what to read and
  cite. `Assembly-UnityScript.csproj` is the decompiler's project file listing them; it is not buildable
  and there's no reason to build it.
- **`RippedAssets/ExportedProject/Assets/Scripts/Assembly-UnityScript/*.cs`** (same filenames as above)
  are **all AssetRipper dummy stubs** — empty placeholder classes AssetRipper generates when it can't
  recover script bodies. Every single one of the 1,317 files there is a boilerplate "Dummy class..."
  explanation, not real code. **Never read scripts from this path expecting logic** — always use the
  root-level `.cs` file of the same name instead.
- `RippedAssets/` is still the right place for everything AssetRipper *could* recover: meshes
  (`Assets/Mesh/*.asset`), materials, textures, scene transforms (`Assets/Scene/*.unity`), and prefabs.
  These are legitimate and were used, e.g., to reconstruct exact spawn-point coordinates and collision
  geometry.
- `RippedAssets/` and `12TailsOnline_Data/` are git-ignored (~9.8GB combined, raw Unity asset export +
  player data) — never `git add -A`/`git add .` here, always add specific files.
- Stray compiler-generated noise at the root (`$ArrayType$*.cs`, `-Module-.cs`,
  `-PrivateImplementationDetails-*.cs`) is decompiler scaffolding, not game logic — ignore it.

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
- Always cite extracted facts as `file:line` (or a line range) — every existing doc in this repo does
  this and it's how numbers get re-verified later.

## Ground-truth reference docs (read these before re-deriving a formula)

- **`12t_reference/12Tails-Mechanics-Reference.md`** — verified core mechanics: the 8-stat system, derived HP/MP/KO/SP,
  per-class growth tables, level-scaling formula. Cross-check any stat/damage formula against this before
  re-deriving it from source.
- **`12t_reference/*-skill-data-reference.md`** — per-class, per-skill verified data (one file
  per class worked on so far, e.g. Penguin). This is the source of truth backing the interactive skill
  sheets in `12t_projects/`.
- **`12t_reference/*-skill-cooldown-reference.md`** — one file per class, **all 12 classes present**
  (added 2026-08-13) — max-rank active-skill cooldown/duration data (`agiAdjust`/`chaAdjust`-wrapped
  status, `revisedArtExempt`) feeding the Skill Cooldown/Duration Lookup tool in `player-reference-tool`
  below. Narrower scope than the `*-skill-data-reference.md` docs above (cooldown/duration only, no
  damage formulas, active skills only) — don't conflate the two doc families. **Cast Time (added
  2026-08-14) has no matching `*-casttime-reference.md` doc family** — unlike cooldown/duration, its
  104-skill (of 306) research pass was distilled straight into `index.html`'s own `SKILLS` entries
  (`castTime`/`castWrapped`/`castDep` fields) and dated notes in `player-reference-tool/CLAUDE.md`, not
  written out as separate per-class markdown docs. Don't go looking for a cast-time equivalent of these
  cooldown docs — it doesn't exist; the tool's own data/CLAUDE.md notes are the citation trail.
- **Decompiled source can lag the *live* server, not just the repo's own history** — confirmed 2026-08-14:
  `Mole_stunMine.cs:60` still reads `talAdjust(60)` for Stun Mine's duration, but the user confirmed the
  live game has since been patched to `chaAdjust(60)` (matching sibling `mine`'s behavior). When a
  decompiled-source citation and direct user testing disagree, the user's live observation wins — update
  the doc/tool and leave a note (see `12t_reference/mole-skill-cooldown-reference.md`'s `stunMine`
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
