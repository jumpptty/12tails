# Skill Cooldown/Duration Lookup — Design Spec

**Status:** approved by user, ready for implementation planning.

## Goal

A new tool mounted inline into the "12 Tails Tools" hub (`12t_projects/player-reference-tool/index.html`)
that lets a player look up, across all 12 classes, every active skill's max-rank cooldown and (if
applicable) buff/debuff duration — both the raw source value and the value adjusted for the player's own
AGI/CHA/LCK, with an optional `revisedArt5` (12% CD reduction) toggle.

This is a **mounted** tool (`{id, title, category, icon, mounted, mount(root)}` in the `TOOLS` registry),
not a link-out entry — per the 2026-08-12 policy (see root `CLAUDE.md`), link-out is the default for new
tools, but this one is small enough to embed directly, matching the exception already made for
Stat-Gain Calculator.

## Scope

- **12 classes**: Bat, Bison, Cat, Chameleon, Mole, Monkey, Panda, Penguin, Rabbit, Sheep, Whale, Wolf —
  confirmed as the full roster via the 12 `<Class>Skill.cs` files present at the repo root.
- **Active skills only** — a skill must have a real cooldown to be included. Passive/stat-boost skills
  (no cooldown, no duration) are excluded entirely from research and from the tool.
- **Max rank only** — for skills that scale by rank, only the highest rank's numbers are shown (most
  skills share the same cooldown across ranks; where a class turns out to differ, max rank still wins).
- **Cooldown and duration only** — no damage formulas, no per-rank breakdown, no Class C synergy notes.
  Much narrower than the existing Penguin skill-sheet's scope.
- Skills whose duration is **CHA-contested** (target's own stat affects final duration, not a pure
  caster-CHA function) are treated as having no duration for this tool's purposes — the duration field
  is simply omitted for that skill, indistinguishable from a skill with no duration at all.

## Research plan

Each class gets a small, uniformly-structured verified reference doc:
`12t_reference/<class>-skill-reference.md` (e.g. `wolf-skill-reference.md`) — including
one for Penguin, even though its full data already exists in
`12t_reference/penguin-skill-damage-reference.md`, so all 12 classes feed the tool from the same
uniform shape (skill id, cooldown, duration) rather than one class being extracted differently from the
other 11.

For each class, using the same method already proven on Penguin (and citing `file:line` per this repo's
sourcing convention):
1. Read `<Class>Skill.cs` for the skill roster and max-rank cost/cd metadata.
2. Read the class's own `.cs` file's cast-site `RPC_<skill>` handlers to find the actual cooldown call
   (`addTimeOut(...)`) and confirm whether it's wrapped in `agiAdjust(...)` or is a bare literal — **do
   not assume wrapping from the metadata alone**, since Penguin's `manaArc` looked `agiAdjust`-wrapped in
   an earlier pass of its own doc and turned out not to be (verified at `Penguin.cs:21756`). Every skill
   needs its own cast-site check.
3. For skills that call `RPC_AddStatus(...)`, check whether the duration argument is wrapped in
   `chaAdjust(...)` and whether it's contested by the target (skip duration entirely if contested).
4. Record: skill id, display name, cooldown base value + wrapped(bool), duration base value +
   wrapped(bool) or omitted.

This research is dispatched via the `mechanics-researcher` agent, one pass per class — independent
across classes, so passes can run in parallel/background.

## Tool architecture

**Data shape** (JS, populated from the 12 reference docs):
```js
const SKILLS = [
  { id:"...", name:"...", class:"Wolf", icon:"data:image/png;base64,...",
    cd: 8, cdWrapped: true,             // cdWrapped=false → adjusted CD == base CD, no range
    revisedArtExempt: false,            // true for basic-attack/consumable skills (nAttack/cAttack-type) —
                                         // revisedArt5's 12% CD reduction never applies to these, per the
                                         // documented exemption (12t_reference/...penguin-skill-damage-reference.md)
    duration: 12, durWrapped: true },   // duration/durWrapped omitted entirely if not applicable
  ...
];
```
Research must record `revisedArtExempt` per skill (basic-attack/charge-attack-type skills like `cAttack`
have a real cooldown and belong in the table, but are exempt) — this isn't optional metadata, it changes
the adjusted-CD number whenever the toggle is on.

**Icons**: extracted from `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/<skillId><maxRank>.png`,
base64-embedded the same way as Penguin's (`.superpowers/sdd/dump_penguin_icons.py` pattern), generalized
to loop over all 12 class folders instead of one.

**UI**:
- 3 stat inputs (AGI / CHA / LCK) at the top, same input-field pattern as Stat-Gain's controls.
- `revisedArt5` toggle button next to the stat inputs — its own icon (Penguin's copy of
  `revisedArt5.png`, already previously extracted and verified; every class has its own near-identical
  copy of this icon but one canonical copy is enough since the toggle isn't class-scoped), grayscale +
  50% opacity when OFF, full color when ON — exact same CSS pattern as the Penguin sheet's
  `.revisedarttoggle` (`filter:grayscale(100%);opacity:.5` → `.on{filter:none;opacity:1}` plus a border
  color change), reused verbatim under a new `.sk-` prefix.
- Text search input (filters by skill name) + class filter (text-label chips: Bat/Bison/.../All).
- One flat table, all matching skills across all classes: **Skill** (icon+name), **Class**,
  **Cooldown** (original), **Cooldown** (adjusted), **Duration** (original), **Duration** (adjusted).
  Duration columns are always present structurally; a skill with no applicable duration renders "—" in
  both duration cells rather than the columns disappearing.
- Table recomputes live on any stat input change, toggle change, search, or class-filter change.

**Adjusted-value math** (reusing the Penguin sheet's already-verified formulas/pattern, not re-derived):
```
n = AGI + R          where R = Random(0, ceil(0.2*LCK)) — compute as a [min,max] range, not a single roll
agiAdjust(t)_range = [ t*(1 - max_n/(max_n+128)),  t*(1 - min_n/(min_n+128)) ]   // min R → longest CD, max R → shortest CD
chaAdjust(t)_range = [ ceil(t*(1+0.015*clamp(CHA+min_R,1,512))), ceil(t*(1+0.015*clamp(CHA+max_R,1,512))) ]

if cdWrapped:      adjustedCD = agiAdjust_range(baseCD)          else adjustedCD = baseCD (single value, no range)
if revisedArtOn && !revisedArtExempt:   adjustedCD = ceil(0.88 * each endpoint)   // applied AFTER the agiAdjust range, matching Penguin sheet's chipHTML order exactly; skipped entirely for exempt skills regardless of toggle state
if durWrapped:     adjustedDuration = chaAdjust_range(baseDuration)  else adjustedDuration = baseDuration (single value)
```

## Visual design

No new design language — inherits the hub's existing "Ledger" tokens (`--ink`/`--panel`/`--gold`/etc.)
and reuses the `.sg-results`-style table conventions already established for Stat-Gain (uppercase
headers, `ui-monospace` numeric cells, row hover highlight). New CSS uses a `.sk-` class prefix
(matching the `.sg-`/`.gk-` isolation convention already documented in this hub's own `CLAUDE.md`) so it
can't collide with the other mounted tool or any future one.

## Error handling / edge cases

- Empty AGI/CHA/LCK inputs default to 0, matching the existing stat-panel convention used elsewhere in
  this repo.
- Zero search/filter matches: a plain "no matches" line in the table body, no elaborate empty state
  (per the minimal-UI instruction already given for this project).
- A skill with `cdWrapped:false` never shows a range for cooldown — it shows a single adjusted number
  (base, or base×0.88 if revisedArt is on and `revisedArtExempt` is false). `cdWrapped` and
  `revisedArtExempt` are independent flags; a skill can be either, both, or neither.

## Testing / verification approach

Earlier work on this hub (the Penguin sheet's design-corrections report) used a headless Node `vm`
harness for verification — **not available in this environment** (confirmed this session: no `node` on
PATH, only Python). Verification here instead uses: Python-computed hand cases for the adjusted-value
math (agiAdjust/chaAdjust ranges, revisedArt ×0.88, spot-checked against a handful of skills per class,
not all ~200+), static structural checks on the merged `index.html` (brace/tag balance, the same method
already used for this hub's earlier edits this session), and full manual review of every research doc's
`file:line` citations before any number is trusted into the tool's data table. No claim of "verified in
a browser" should be made without actually opening the file — flag explicitly if that step is skipped.

## Open scope note (not a blocker, flagged for the implementation plan)

The full research pass (11 new classes + Penguin's parallel-format doc) is the majority of the work here
and is substantially larger than the tool-building step itself. The implementation plan should treat
each class's research as its own independently-completable task (well suited to
`subagent-driven-development`/parallel dispatch), with the tool UI as a final task that only starts
once enough class data exists to populate it meaningfully.
