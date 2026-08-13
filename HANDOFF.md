# 12 Tails Workspace — Handoff

Snapshot as of 2026-08-12, with updates on 2026-08-13 (workplace machine) — the skill-cooldown-lookup
plan (all 17 tasks, see below) finished this session on its dedicated branch, not yet merged to
`master`. This is a point-in-time note for resuming from a different machine — see "No remote
configured" below: anything not committed here doesn't exist anywhere else. Trust `git log` over this
doc for anything more recent. Each in-progress plan keeps its own ledger under
`.superpowers/sdd/<plan-basename>/progress.md` (e.g.
`.superpowers/sdd/2026-08-12-skill-cooldown-lookup/progress.md`) — trust that plan's ledger over this
doc's summary of it. The old flat `.superpowers/sdd/progress.md` (no subfolder) belongs to the earlier,
already-finished Penguin Interactive Infographic/Class-C/LCK-range plans, not any in-progress work.

## Shipped deliverables (`12t_projects/`)

- `penguin-skill-sheet/12_Penguin_skill-sheet.html` — interactive Penguin class skill infographic (rank
  toggles, base/plug-in numeric view, Class C synergy toggles, LCK-range display). Main build + Class C
  toggle + LCK-range/revisedArt features all complete and reviewed — see `.superpowers/sdd/progress.md`
  for the task-by-task ledger.
- `stat-gain-tables/` — `Stat Calc.html` + README.
- `goldenkingbug-spawn-map/GoldenKingBug-spawn-map.html` — now published as its own Artifact (title
  trimmed to just "GoldenKingBug Spawn Map"), see that folder's own `CLAUDE.md` (**new 2026-08-12**)
  for the URL to republish in place. Linked from the tools hub below rather than embedded in it.
- `agi-cha-sweetspot/AGI-CHA-Sweetspot-Infographic.html`.
- `player-reference-tool/index.html` — **new 2026-08-12**, the "12 Tails Tools" multi-tool Artifact hub.
  Uses a new "Ledger" visual design system, documented in that folder's own `CLAUDE.md` — read it
  before touching the UI. Publish with the `publish-player-reference-tool` skill, always to its
  existing Artifact URL (never omit `url:`).
  - **Policy set 2026-08-12**: new tools link out to their own separate Artifacts — they are not
    mounted inline into this hub's `TOOLS` registry (see root `CLAUDE.md`'s `player-reference-tool`
    bullet). Same-day, an inline embed of the GoldenKingBug Spawn Map (Three.js, ~700KB) was built and
    then fully reverted once this policy was decided — no trace of that merge attempt remains; the map
    is now a link-out `TOOLS` entry pointing at its own separate Artifact instead.
  - Ledger index changed from a full-width single-column row list to a **2-column chip grid** (1
    column under 560px) — the single Stat-Gain row read as disproportionately long at full width.
  - **3 tools total as of 2026-08-13**: Stat-Gain Calculator (mounted), Skill Cooldown/Duration Lookup
    (mounted — **new 2026-08-13**, see the finished plan below), GoldenKingBug Spawn Map (link-out).
  - The shared-`#toolMount`-DOM-clobbering bug this doc used to flag as "still-unfixed" **is now fixed**
    (landed 2026-08-13 as part of the skill-cooldown-lookup plan's Task 16, since that tool is what made
    the bug real instead of hypothetical) — each mounted tool now gets its own lazily-created, persistent
    container, shown/hidden on switch instead of a shared `innerHTML` write. Verified live via Playwright
    that switching between the two mounted tools preserves each one's state rather than wiping it.
  - The "All Tools" breadcrumb link was removed same-day (redundant with clicking the "12 Tails Tools"
    brand title, which already navigates home) — only the current-tool-name crumb remains.
  - **Published live** as of the 2026-08-12 session with the 2-col grid/GoldenKingBug link/All-Tools-
    removal changes above — the `publish-player-reference-tool` skill's `disable-model-invocation` lock
    was removed (at user request) and it was used successfully after a session restart picked up the
    unlock. **The 2026-08-13 Skill Cooldown/Duration Lookup addition is committed on the
    `skill-cooldown-lookup` branch but not yet published live** — publish it (with the same skill, to the
    same existing Artifact URL) once the branch is merged/the user is ready, don't assume it's already
    live just because it's shipped in this doc's sense of "committed."

### Complete: Skill Cooldown/Duration Lookup tool — all 17 of 17 tasks done, on a dedicated branch, not yet merged

A 3rd tool for the hub (mounted inline, not link-out — small enough per the user). Full design spec at
`docs/superpowers/specs/2026-08-12-skill-cooldown-lookup-design.md`, full 17-task implementation plan
at `docs/superpowers/plans/2026-08-12-skill-cooldown-lookup.md` (both user-approved, **both still
untracked** — Task 17 only commits `player-reference-tool/CLAUDE.md`/root `CLAUDE.md`/this doc, not the
plan/spec themselves; see "Known local uncommitted work"). Summary: look up every active skill's
max-rank cooldown/duration across all 12 classes, adjusted live for AGI/CHA/LCK (as a `[min,max]`
range — LCK adds a random spread inside
`agiAdjust`/`chaAdjust`) plus a `revisedArt5` toggle. Tasks 1-12 were independent per-class research
passes (grep/read the decompiled source, write `12t_reference/<class>-skill-cooldown-reference.md`);
Tasks 13-17 built the tool itself.

**⚠️ Checkout `skill-cooldown-lookup` before resuming — this work is NOT on `master`.**
`git checkout skill-cooldown-lookup`. All commits below live only on this branch — **the branch has not
been merged to `master` and the finished tool has not been published live** (see the
`player-reference-tool` bullet above); both are decisions for the user, not assumed as this plan's own
next step. See `superpowers:finishing-a-development-branch` for the merge decision once the user is
ready.

**Worktree abandoned, plain branch used instead:** the isolated-worktree approach hit an unresolved
Windows symlink blocker (bulk-symlinking ~1470 untracked `.cs` files, and a directory-symlink failure
for `RippedAssets/`). On reconsideration this isolation was never actually needed — Tasks 1-12 only
*read* `.cs` files (already blocked from editing by the repo's own guard hook) and each *writes one
distinct new file* under `12t_reference/`, so there's no shared-state collision to isolate against. The
worktree and its branch (`worktree-skill-cooldown-lookup`) were deleted; work continued directly on the
plain branch `skill-cooldown-lookup` (created off `master`) in the main repo — no worktree, no symlinks.

**Execution status (via `superpowers:subagent-driven-development`):** all 17 tasks complete and
committed. Research tasks (1-12, one per class) — Penguin (`27b9755`), Bat (`5d96eff`, includes 1 fix
round), Bison (`9a7765a`), Cat (`a1ac964`), Chameleon (`dec636a`), Mole (`54e5c53`), Monkey (`a735382`),
Panda (`fa64547`), Rabbit (`f5e742b`), Sheep (`ae2e3dd`), Wolf (`39b3d63`), Whale (`7392739`). Build
tasks (13-17) — icon extraction (`425740d`, plus a bugfix `7696a2a`), adjusted-value math functions
(`f6a6de9`), SKILLS data population (`60e90b4`), tool UI + shared-mount-container bugfix (`77aa015`),
this doc/`CLAUDE.md` update (final commit of this session). **306 active skills documented across all 12
classes**, each with a verified `file:line`-cited cooldown (and duration, where applicable) formula.
Full task-by-task ledger, including every mid-execution scope decision below, per-task spot-check
detail (several research tasks surfaced genuine `getSkill()` dead-code-fallthrough traps in the
obfuscated source — e.g. Mole's `heavyBuilt`/`speedDrill`/`skyDrill` silently converging on
`synchroMole`'s `cType`, Panda's `shadowFist4`/`mysticSage` traps, Rabbit's `gilShot4`/`maimShot4`
traps, Wolf's inverse case where `lunarEclipse`'s broken `getSkill()` metadata does NOT affect its real
independently-dispatched cast site — each independently re-traced by the controller before being
accepted), and the build-phase discoveries (a real Task-13-script bug that silently dropped Panda's
`wind&cloud`/`rain&storm`-onward rows before an ampersand-unfriendly regex, found and fixed before it
could reach the shipped tool; the shared-`#toolMount` fix), is at
`.superpowers/sdd/2026-08-12-skill-cooldown-lookup/progress.md` — **trust it over this section** for
anything past this snapshot. Process for Tasks 5-12: each dispatched to a background `sonnet` implementer
subagent (no separate reviewer subagent — controller spot-checks 5-8 citations directly against the
`.cs` source per task instead, per the process change adopted after Task 4); Tasks 13-16 (mechanical/
scripted data-merge and UI work, not research) were done directly by the controller rather than
dispatched. **Verification for Tasks 14/16 exceeded the plan's own assumed sandbox**: this session
actually has both `node` and Playwright browser automation available (the plan assumed neither) — used
`node` to execute the real math functions/data structures straight out of the committed file rather than
hand-tracing, and used Playwright (via a locally-spun-up `python -m http.server`, since `file://` URLs
are blocked) to run the actual manual smoke-test the plan wrote as instructions for a hypothetical future
human: opened the live tool, confirmed all 12 classes' skills render, live AGI/CHA/LCK adjustment matches
hand-computed values exactly, class-filter chips and search narrow the table correctly, the revisedArt
toggle changes adjusted CD (not duration) as expected, and — critically — switching to Stat-Gain and back
preserves the first tool's state rather than losing it, confirming the shared-container fix actually
works, not just compiles.

**Two scope corrections discovered mid-execution — both now baked into the plan's Global Constraints,
but only from Task 3/Task 2 onward respectively (Task 1/2 predate one or both):**
1. **Exclude the 12 shared "support skills"** (`obsidianFang`/`stunningGround`/`psalmOfEnergy`/
   `seaAegis`/`assassinate`/`zephyrLore`/`mineWalker`/`replenishment`/`elementalBound`/`divineChannel`/
   `astralShift`/`bloodCarnage`) — a separate `eSkillType.support` system (`SkillData.cs`), duplicated
   as `RPC_<name>` handlers with a flat unwrapped `addTimeOut("<name>", (float)600)` in **every** class's
   own `.cs` file. Not that class's own skill, even when thematically named for it.
2. **Exclude `nAttack`/`cAttack` entirely, every class, no exceptions** — even when (confirmed true for
   Bat and Cat) the basic-attack combo has a genuine per-stage named cooldown. This is a blanket
   product-scope call, not a "does it have a real cooldown" test. Task 2's Bat doc originally had an
   `nAttack` row (reviewed and approved before this rule existed) and needed a fix round to remove it.

**Process note:** per-task review switched from a dispatched reviewer subagent (Tasks 1-3 — thorough
but slow, 40-60 tool calls per task) to a lighter controller-level spot-check (Task 4 onward) — grepping
a handful of citations directly rather than dispatching a second subagent. Tasks 5-12 should continue
using this lighter process, plus a `grep -n "addTimeOut("` -first extraction method (surfaces every real
cooldown key across the whole class file in one pass, rather than starting from
`<Class>Skill.cs`'s `cType` list and cross-referencing each skill individually).

**Scrapped, unrelated to the above:** the separate penguin-`meteora` Blender animation project (design
spec, plan, and leftover `RippedAssets/meteora.obj`/`penguin_meteora.blend*` mesh/scene files) was
abandoned and fully removed this session (commit `3ca9132`, on the `skill-cooldown-lookup` branch) —
the user had already discarded the Blender model itself outside the repo. No trace of it should remain;
if you see any reference to it, that's stale.

## Reference docs (`12t_reference/`)

- `12Tails-Mechanics-Reference.md` — core mechanics ground truth (8-stat system, derived HP/MP/KO/SP,
  level-scaling).
- `2026-07-21-penguin-skill-data-reference.md` — Penguin class skill data, source of truth backing the
  Penguin sheet above.
- `*-skill-cooldown-reference.md` — **new 2026-08-13, all 12 classes** (bat, bison, cat, chameleon,
  mole, monkey, panda, penguin, rabbit, sheep, whale, wolf). Max-rank active-skill cooldown/duration
  data backing the Skill Cooldown/Duration Lookup tool above — 306 skills total, every cell cited to a
  `file:line` in the class's own `.cs`/`<Class>Skill.cs`. Narrower scope than the skill-data-reference
  docs (cooldown/duration only, active skills only, no damage formulas) — don't conflate the two.

## Harness tooling (`.claude/`) — added 2026-08-12

Ported and adapted from a Desktop copy of this project:
- `agents/mechanics-researcher.md` — read-only subagent for tracing skill/damage/heal formulas through
  the decompiled source instead of ad-hoc `.cs` reading.
- `skills/decode-character-stats/` — hex-decodes monster/structure base stats directly from
  `12TailsOnline_Data/` binaries (PowerShell only in this repo's setup, no ilspycmd/DLL step needed).
  Field order re-verified against this repo's own `CharacterControl.cs` (~line 29675).
- `hooks/guard-decompiled-and-data.sh` (wired via `settings.json`) — denies Edit/Write to any `.cs`
  file repo-wide, and to anything under `RippedAssets/`/`12TailsOnline_Data/`.

See root `CLAUDE.md`'s "Repo layout" section for the permanent pointers to all of the above — this
handoff doc just marks when each landed.

## Known local uncommitted work (this machine, not yet committed)

As of this snapshot the working tree has real uncommitted changes that are **not** described above:
a staged rename of the Penguin sheet + its data reference into `12t_projects/`/`12t_reference/` (part
of the 2026-07-31 reorg convention) with matching path-reference fixes across `HANDOFF.md`/plan/spec
docs, plus an unstaged, seemingly-complete but unreviewed feature on the Penguin sheet adding an enemy
"Hit Mod" damage-taken multiplier (`evalHitMod`, cited against `CharacterControl.cs`'s
`RPC_AddDamage`/`RPC_AddEffectDamage`) and a `manaArc` cooldown data fix (its CD is a bare literal, not
`agiAdjust`-wrapped — verified at `Penguin.cs:21756`). No plan/spec/progress-ledger entry backs this
feature yet. Run `git status` / `git diff` to see the exact state before continuing it — don't assume
it's finished just because it reads as internally consistent.

**Update (2026-08-13):** root `CLAUDE.md` and `12t_projects/player-reference-tool/CLAUDE.md` are now
tracked as of this session's Task 17 commit (see below) — `player-reference-tool/index.html` itself has
been tracked since Task 14's commit earlier this session. **Still untracked** (confirmed this session,
`??` in `git status`): `.claude/` (all of it, including the `mechanics-researcher` agent/
`decode-character-stats` skill/guard hook described above), `12t_projects/goldenkingbug-spawn-map/`
(including its own `CLAUDE.md`), and the skill-cooldown-lookup plan/spec docs under `docs/superpowers/`
(`2026-08-12-skill-cooldown-lookup.md`/`-design.md` — the 17-task plan this session executed end to end
is itself still uncommitted, unlike its own output). This repo has no remote — anything still untracked
exists in exactly one place on disk. Run `git status` before assuming anything described in this
handoff is actually recoverable from git history.

## Repo setup notes

- Git identity is set locally (not global) to `Jump <jumpthai@gmail.com>` — only affects this repo.
- **No remote configured** (`git remote -v` is empty) — this repo is local-only on whichever machine
  has it. Anything left uncommitted here does not exist anywhere else; commit (or otherwise transfer
  the working copy) before switching machines.
- `.gitignore` excludes `RippedAssets/` and `12TailsOnline_Data/` (huge, ~9.8GB combined) — never
  remove this exclusion; a stray `git add -A`/`git add .` would try to stage the entire decompiled game.
- Hundreds of untracked loose `.cs` decompiled source files at the repo root are expected, pre-existing,
  and never meant to be tracked — only `12t_projects/`, `12t_reference/`, `docs/`, `.claude/`, and
  `.superpowers/` paths matter for this project's own work.
