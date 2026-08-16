# 12 Tails Workspace — Handoff

**Update 2026-08-16 (on top of the 2026-08-14 rank-selector/damage-formula pilot below): Final Damage
chip built out to the full real damage pipeline, a new "Mods" buff/debuff popup, and the remaining Class
C dependency sweep across the Penguin skills already built out.** Continuing the Penguin damage-formula
pilot from 2026-08-14, this session (a long back-and-forth with the user, many small dated passes — see
`player-reference-tool/CLAUDE.md`'s 15th-through-22nd passes for the full blow-by-blow) added:
- **Target-mitigated "Final Damage" chip** — 3 real named enemy presets (Carron/Stingdune/Silverbug, real
  target-avatar icons from `gamegui/icons/targetavatar/`), `defAdjust`'s real formula (a weighted blend of
  a subtractive and a multiplicative term, each independently floored at 1 — **got this wrong twice**
  before landing right; see the 15th pass for the "read an obfuscated function all the way to its real
  `return`, don't stop at the first plausible assignment" lesson, now the project's 3rd documented instance
  of that mistake). Shown as a `[min,max]` range, plus an opt-in "Test" button (renamed from "Simulate")
  that rolls one concrete hit using the real in-game damage-digit textures (`GameAssets/Effects/DamageNum/`)
  and a floating/fading animation matching the live game — supports multiple concurrent popups so a second
  click doesn't kill the first one's in-flight animation (18th pass).
- **New "Mods" popup** — `damageMod` (attacker-side) and `hitMod` (target-side), two real `CharacterControl`
  fields (`dmgAdjust`/`RPC_AddDamage`) missing from every earlier damage-chip pass, both defaulting to 1.0
  and only moving while a specific buff/debuff status is active. A `mechanics-researcher` subagent swept
  `CharacterControl.cs` and found 13 distinct statuses touching either field; user curated a 5-buff subset
  (`reduce`, `miracleDrop`, `valor`, `sealOfHeaven`, `amplifyDamage`) for the actual popup. Uses the real
  in-game buff-bar icons (`gamegui/icons/status/`), not skill-hotbar art — a better semantic fit for an
  on/off toggle.
- **Remaining Penguin Class C damage dependencies found and wired in**: `manaArc`'s `penguinOfArc`
  (+0.5×LV, additive — straightforward, reused the existing `dmgDep` shape). `iceShield`'s `frostSpike`
  (+LV, but genuinely different formula ORDER — its Class C bonus is added BEFORE focusIntellect's
  multiplier, not after like every other skill checked, needed a whole new `shield`/`shieldDep`/
  `renderShieldFormula` code path since a shield HP pool isn't damage dealt to a target — no `defAdjust`
  mitigation applies to it, so it's a 2-chip row, not 3). `fallingStars`/`fallingComets`'s `giantStar`
  (×1.25, the tool's first MULTIPLICATIVE Class C dep, needed its own `dmgMultDep` schema field) — **this
  one was initially missed**: `hasSkill(442)` doesn't apply its bonus inline, it dispatches to a wholly
  separate coroutine (`RPC_giantStars_fire`/`RPC_giantComets_fire`), and the first pass stopped reading at
  "it switches coroutines" without opening the target function — caught by the user quoting the real
  in-game tooltip ("+50% range and +25% damage") against the tool's unchanged output.
- **Two real bugs found and fixed**: ATK/TAL/CHAR-LV stat inputs never had their `input` event listener
  wired at all (added when those fields were introduced, listener wiring was missed) — Raw Damage/Final
  Damage looked unresponsive to the stat that matters most for them until some unrelated field happened to
  trigger a re-render. And the Final Damage range text could render outside its own chip's visible box — a
  `min-width:auto`-family CSS bug, same family already documented multiple times in this file, this time
  one level deeper (the chip container was already fixed earlier; a child inside it also needed the same
  `max-width:100%` treatment once that chip's layout stopped stretching its children by default).

Full formula citations, every corrected mistake (including the two `defAdjust` misreads and the missed
`giantStar` dispatch), and every Python cross-check script used (no browser tool available this session
either) are in `player-reference-tool/CLAUDE.md`'s 15th-through-22nd dated passes — **read those before
extending any of this further**, don't re-derive from scratch. **Published live** to the tool's existing
Artifact URL after every single pass this session (standing user instruction: always publish, never
without `url:`) — same URL as every prior session, no fork. Git state unchanged from the 2026-08-14
snapshot further down (same modified-file list — `index.html`, `player-reference-tool/CLAUDE.md`, this
doc, root `CLAUDE.md` — just more content within them; still all uncommitted, still on the
`skill-cooldown-lookup` branch, still not merged to `master`).

**Update 2026-08-14 (3rd session today, on top of the Cast Time/layout work already logged below): a
skill-rank selector + damage formula row, Penguin-only pilot.** Click a Penguin skill's hero icon to
cycle its rank (icon art itself swaps per rank, no text badge) — `cd`/`castTime` now resolve per-rank
where the source genuinely varies by rank (confirmed real, e.g. `manaMissile`'s CD is `8+2×sLv`, not
hypothetical). New full-width damage-formula row below the 3-stat grid, `talAdjust(...)` expanded to its
real algebraic form (`X + 0.02X×TAL`, verified against `CharacterControl.cs:20624`) with color-coded
terms (aqua TAL, blue INT, red ATK token added for parity though unused by Penguin), plus a Focus
Intellect toggle that simplifies `×(1+0.01×focusIntellect)` to `×0.01×INT` (verified algebraically true
against source, since the buff's stored value is exactly `INT-100`). Side effect: found and fixed 6
pre-existing mislabeled skill-icon keys left over from the original Task 13 extraction (`focusIntellect`/
`parallelShift`/`snowBall`/`cosmicRift`/`cosmicFriday`/`tripleCast` were stored under the wrong rank
suffix). Full detail, all the judgment calls on what counts as "damage" vs. shield/heal/contingent
effects, and the verification method used (no browser available — a Python reimplementation of the
render logic plus an exhaustive icon-key/array-length coverage script, not a live visual check) are in
`12t_projects/player-reference-tool/CLAUDE.md`'s new "Rank selector + damage formula — Penguin pilot"
section — read that before touching this feature or extending it to another class. **Scope is Penguin's
27 `SKILLS` entries only** — the other 11 classes have no `maxRank`/`dmg` fields yet.

**Update 2026-08-14:** still on the `skill-cooldown-lookup` branch, still not merged to `master`, and a
large additional session's worth of work landed on top of the already-committed 2026-08-13 state
described below — **all of it currently uncommitted** (`git status` shows `index.html` and every
`12t_reference/*-skill-cooldown-reference.md` modified, on top of the pre-existing unrelated
uncommitted Penguin sheet/reorg work noted further down). Despite being uncommitted, the tool **has
been published live** to its Artifact URL multiple times this session via the
`publish-player-reference-tool` skill — publishing and committing are independent actions here, don't
assume "uncommitted" means "not live" the way earlier snapshots of this doc did. What landed:
- **New `dep`/`cdDep` mechanic**: a skill's Cooldown or Duration can now depend on a separate passive's
  learned rank — extended (2026-08-13 committed at `2b18241`, then further 2026-08-14 work on top) to
  Sheep's `bless`↔`gospel5` and Whale's six `knightOfTheDeep1`-affected skills (Cooldown-side deps, a
  new capability beyond the original Duration-only design) — see
  `docs/superpowers/specs/2026-08-14-skill-dependent-cooldown-design.md`.
- **A full cross-class Duration re-audit**, at the user's direction, correcting or adding data for
  specific skills across Bat, Cat, Chameleon, Mole, Monkey, Panda, Penguin, Rabbit, and Sheep — see
  `12t_projects/player-reference-tool/CLAUDE.md`'s new "data & UI conventions" section for the two
  general rules this surfaced (object/summon lifetimes now count as Duration; "enemy-applied debuff,
  wrong side of the cast" is its own exclusion reason distinct from CHA-contested) and two genuine
  miscites caught and fixed (Mole's `flameCarnival`, Penguin's `iceBlock`).
- **New `durationInfinite` (∞ chip)** for confirmed-no-despawn-timer pet summons (Mole's `barrelBot`,
  Monkey's `phoenix`/`ja`/`gadina`/`buiten`/`summonGaos`), **new `durPostAdd`** schema field for
  Penguin's `iceBlock` compound formula, and a **hover probability tooltip** on both stat numbers
  showing the real per-outcome LCK-roll distribution (not a naive uniform assumption) — all documented
  in the same `player-reference-tool/CLAUDE.md` section.
- **Display precision changed 1→2 decimals** at the user's request (the underlying formulas are real
  floats with no in-game rounding of their own; 1 decimal was losing real precision).
- **Verified 2026-08-14**: ran a full programmatic diff of every `SKILLS` entry in `index.html` against
  its class's own `12t_reference/*.md` table — **zero mismatches across all 306 skills**, so the
  reference docs are trustworthy as of this snapshot despite the volume of changes above.
- Also worth correcting from the 2026-08-13 text below: `12t_reference/penguin-skill-cooldown-reference.md`
  **does exist** (it was mistakenly flagged as a gap mid-session before being found) — Penguin has the
  same per-class cooldown doc every other class has, it just wasn't caught by an early `Glob` check.

**Further update, same day (2026-08-14), a separate session on top of everything above — new "Cast
Time" chip, castDep mechanic, and a layout overhaul. Still all uncommitted, still published live
(multiple times) via `publish-player-reference-tool`.** What landed, in order:

1. **New third stat: Cast Time**, MAG(displayed as INT)-based via `CharacterControl.magAdjust(t)`
   (`CharacterControl.cs:20584-20589`) — a genuinely different formula shape from `agiAdjust`/`chaAdjust`:
   `n = clamp(INT+R, 1, 512)` then `t - floor(n/32)` (a real **integer** divide, not a smooth curve),
   clamped to `[0.1, 600]`. New `magAdjustAtRoll`/`magAdjustRange` functions in `index.html` (beside
   `chaAdjustRange`) replicate the floor exactly — don't "smooth" it out, the coarse stepping is real
   in-game behavior. New INT input added to the tool's controls row (AGI/INT/CHA/LCK).
   - Data gathered by dispatching one research subagent per class in parallel (11 classes + Penguin done
     directly), each tracing `magAdjust()` call sites through the obfuscated source and cross-referencing
     each skill's already-verified Max Rank from the existing `12t_reference/*-skill-cooldown-reference.md`
     docs. **104 of 306 skills have a real cast time** — most are instant. `sLv` in these formulas is
     1-indexed (equal to the real in-game rank number), confirmed independently across 6 different
     classes by tracing literal call sites (e.g. `RPC_cast1("phantomBane", ..., 1/2/3/4)`).
   - **Unlike the cooldown/duration research, this data has no per-class `*-casttime-reference.md` doc
     family** — it's cited only in `player-reference-tool/CLAUDE.md`'s dated notes and the `SKILLS`
     array's own fields. See root `CLAUDE.md`'s new note on this.
   - Two judgment calls, documented in `player-reference-tool/CLAUDE.md`: Rabbit's `contract` picks one
     of 3 different cast times (6/9/12s) depending on which ally it summons, not rank — reported the
     floor value (6s). Chameleon's `tent` has a second, separate 6s→12s phase after its main cast —
     reported only the first 6s, matching every other skill's "time before the cast bar finishes"
     definition.
2. **`castDep` — a new dependency mechanic for Cast Time, 2 real cases, both user-requested in a
   follow-up ask.** Reuses `getDepRank`/`renderDepBlock` from the existing Cooldown/Duration `dep`
   pattern unchanged, but **does NOT reuse `depPostMultiply`-after-adjust** the way Duration's `dep`
   does — both known `castDep` cases apply their multiplier/formula **before** `magAdjust` in source
   (verified against Wolf's `darkEdge` for the contrasting Duration-side order), so `castBlock` folds the
   dep into `rawCast` directly before calling `magAdjustRange`. This is intentional, not an inconsistency
   to "fix" later.
   - **Chameleon `slayer`/`allSlayer`**: depend on "Improved Slayer" (`getImprovedSlayerLv()`,
     `Chameleon.cs:9501`, `hasSkill(351-354)`, 4 real ranks) — renders as the numbered-button stepper
     (same format as Rabbit's Medical Enhancement/Alchemist Lab), per explicit user request.
   - **Whale's 8 `reducedCast`-affected skills** (`bubbleShield`, `heavyWeight`, `hydroBlast`,
     `rejuvenate`, `callToArm`, `salvation`, `megalodon`, `revitalize`): `hasSkill(373)` halves cast time
     via `Mathf.FloorToInt(0.5*mCastTime)` before `magAdjust` — confirmed exhaustive (only one
     `hasSkill(373)` call in all of `Whale.cs`, so this list is complete, not a sample). Renders as a
     single icon toggle, same visual language as the existing Cooldown-side `knightOfTheDeep` toggle —
     genuinely a **different** passive from `knightOfTheDeep` (different 6-vs-8-skill set, different
     stat), don't merge them.
   - New icons extracted from `RippedAssets/.../gamegui/icons/skills/{chameleon,whale}/`:
     `improvedSlayer4.png`, `reducedCast1.png`.
3. **Layout overhaul, user-requested from a screenshot.** `.sk-hero-stats` switched from flex to CSS
   grid (`repeat(3,1fr)`) with `.sk-stat-cd`/`-cast`/`-dur` each pinning `grid-column:1/2/3` explicitly —
   necessary because the 3 boxes are conditionally rendered, and grid's default auto-placement would
   otherwise pack whichever exist into the first open columns (e.g. Duration sliding into column 2 on a
   Cast-Time-less skill) instead of leaving a skill's missing stat as blank space in its own column.
   Also moved `.sk-dep`/`.sk-ps-toggle` from stacking as a new bordered row below the base-value line to
   `position:absolute` in the box's own bottom-right corner, so a dep-bearing box no longer renders
   visibly taller than its siblings. Widened `.stage` from 760px to 940px **only while this tool is
   open** (new `html.tool-wide-hero` class, same toggle mechanism as the existing `tool-fit-screen`) —
   the menu/Stat-Gain keep the original 760px.
   - **None of this session's UI work (steps 1-3) was visually verified live — no browser/Playwright tool
     was available in the session that built it**, unlike most of the 2026-08-12/13 work below, which
     did have Playwright. Structural checks (brace/tag balance, script parses, exact field-count
     assertions) all pass and the underlying math was hand-verified, but the actual rendered layout
     (especially the corner-positioned dep/ps-toggle's fit against the box's other content) is a
     considered-but-unconfirmed guess. **Do a real visual pass on this before treating it as done** —
     open the tool, check a 3-chip skill (e.g. Sheep's `bless`, Whale's `bubbleShield`), a skill with a
     stepper dep (Chameleon's `slayer`), and a private-server skill, at a few window widths.
4. **Separately, a live-server data correction (Mole's `stunMine`)**: the user reported its Duration is
   `chaAdjust`, not the `talAdjust` the decompiled source (`Mole_stunMine.cs:60`) still shows — the game
   has been patched since this build was captured. Fixed in `12t_reference/mole-skill-cooldown-reference.md`
   and the `SKILLS` entry (`durWrapped:false`→`true`), old source citation kept for the record with a
   "superseded" note rather than deleted. See root `CLAUDE.md`'s new note on decompiled-source-vs-live
   drift for the general pattern this represents.

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
  - **Skill Cooldown/Duration Lookup grew a 3rd "Cast Time" stat 2026-08-14** (new INT control, MAG-based
    `magAdjust()`, 104/306 skills) plus a `castDep` mechanic and a flex→grid layout overhaul — see the
    "Further update, same day (2026-08-14)" section at the very top of this doc for full detail; not
    visually verified live (no browser tool that session).
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

**Update (2026-08-14, exact `git status` at the end of the Cast Time session — trust this over the
2026-08-13 paragraph above for current state, it's now stale):**
```
 M 12t_projects/penguin-skill-sheet/12_Penguin_skill-sheet.html
 M 12t_projects/player-reference-tool/CLAUDE.md
 M 12t_projects/player-reference-tool/index.html
 M 12t_reference/2026-07-21-penguin-skill-data-reference.md
 M 12t_reference/mole-skill-cooldown-reference.md
 M 12t_reference/panda-skill-cooldown-reference.md
 M 12t_reference/whale-skill-cooldown-reference.md
 M docs/superpowers/plans/2026-07-21-penguin-classc-toggle.md
 M docs/superpowers/plans/2026-07-21-penguin-interactive-infographic.md
 M docs/superpowers/plans/2026-07-22-penguin-lck-range-and-revisedart.md
 M docs/superpowers/specs/2026-07-21-penguin-classc-toggle-design.md
?? .claude/
?? 12t_projects/agi-cha-sweetspot/
?? 12t_projects/goldenkingbug-spawn-map/
?? 12t_projects/stat-gain-tables/
?? 12t_reference/12Tails-Mechanics-Reference.md
```
The `player-reference-tool`/`mole`/`panda`/`whale`/`.claude` rows are this and the prior 2026-08-14
session's work described above. **The four Penguin-titled `M` rows (`penguin-skill-sheet.html`,
`2026-07-21-penguin-skill-data-reference.md`, and the 3 `docs/superpowers/plans|specs` files) predate
both 2026-08-14 sessions and were never touched by either** — this handoff doc doesn't know what they
contain or whether they're finished; the "Known local uncommitted work" paragraph above may or may not
still describe them accurately (a "Hit Mod" feature + `manaArc` CD fix) — re-check with `git diff`
before assuming, don't trust that paragraph blindly, it wasn't re-verified this session. `??
12t_projects/{agi-cha-sweetspot,goldenkingbug-spawn-map,stat-gain-tables}/` and `12t_reference/
12Tails-Mechanics-Reference.md` being untracked looks like a `.gitignore` scoping gap (these are real
shipped deliverables per the "Shipped deliverables" section above, not throwaway files) — worth an
explicit decision (add to git, or confirm intentionally excluded) rather than leaving it ambiguous
indefinitely.

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
