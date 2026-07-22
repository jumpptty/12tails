# Penguin Interactive Skill Infographic — Design

## Goal

Produce a print-quality-but-primarily-interactive HTML skill sheet for the
Penguin class, built on the existing `12tails-class-infographic` skill and
its `example-template.html` (Chameleon) conventions, extended with three new
capabilities that Chameleon's static sheet doesn't have:

1. **Aqua accent theme** for Penguin (formalizing per-class accent as a
   template-level convention, not a one-off hack).
2. **Per-card rank toggle** — same-family skill-tree entries (e.g.
   `manaMissile1/2/3/4`) merge into one card with a rank switch, instead of
   four separate cards.
3. **Dual view mode**: a base view (today's symbolic formulas/adjuster tags,
   default) and a character-stat plug-in view (a global stat panel feeds
   every card's formulas and chips recompute to live numbers).

This is an Artifact/browser-first interactive build. Print/PDF export via
`export_to_png.py` is secondary — toggles should default to a sane static
state (base view, max rank) if ever rendered to print, but print fidelity
is not a design driver here.

## Non-goals

- Not building a generic "infographic engine" for all 12 classes right now —
  this spec covers Penguin only. Reusable pieces (accent-per-class CSS
  variable, the rank-merge convention, the formula-evaluator engine) should
  be written so a future class CAN reuse them, but no other class's sheet is
  being touched in this pass.
- Not implementing a full expression parser/CAS. The formula evaluator only
  needs to handle the finite, known shapes already appearing in this
  skill's decompiled formulas (linear sums of stat terms, the 5 documented
  adjuster functions, and the AGI-based CD formula) — not arbitrary math.
- Not adding gear/equipment bonuses to the stat panel. Stat panel inputs are
  raw character stats only (ATK/INT/AGI/CHA/TAL/LCK), matching what the
  decompiled formulas themselves consume.

## Source data

- `PenguinSkill.cs` — skill tree (`getSkillTree`, commandNum 101-444) and
  obfuscated cost table (`getSkill`), decoded via
  `scripts/decode_skilldata.py` (confirmed working generically on this file;
  output saved to scratchpad for the build).
- `Penguin.cs` — main coroutine file; ranked skills like manaMissile follow
  a shared `RPC_<skill>N` / `RPC_<skill>_castN` / `RPC_<skill>_fireN` /
  `RPC_<skill>_hit` pattern per rank, confirming the rank-family structure.
- Companion files: `Penguin_manaMissile.cs`, `Penguin_snowBall.cs`,
  `Penguin_snowMan.cs`, `Penguin_tornado.cs`, `Penguin_typhoon.cs`,
  `Penguin_iceBlock.cs`, `Penguin_arcticEmperor.cs`, `Penguin_cosmicFriday.cs`
  — projectile/summon-specific mechanics (per skill-sheet Procedure step 4,
  Class C passives especially may hide secondary effects in these).
  `Penguin_nAttack.cs` for normal-attack mechanics.
- `PenguinSkill_eng.cs` — tooltip text, used only as a hint per the skill's
  existing "tooltips can be stale" caveat.
- Icons: `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/penguin/<cType><rank>.png`.

## Skill tree structure (confirmed)

68 `commandNum` entries, 101-444, cleanly bucketed by leading digit exactly
like Chameleon (1xx Basic / 2xx Class A / 3xx Class B / 4xx Class C). Unlike
Chameleon, many skills are **rank-families**: sibling commandNums sharing a
base name with a trailing rank digit (`manaMissile1..4`, `frozenBlast1..4`,
`iceShield1..4`, `arcticWind1..3`, `absoluteZero1..2`, `blink1..2`, etc.),
each a fully separate skill-tree entry with its own `reqLv`/`reqBn`/cost row
in `getSkill`, not "one skill with 4 ranks" in the game's own data model.

Confirmed: every rank-family's members all share the same tier band (no
family spans e.g. Class A into Class B) — so the "merged card goes in the
tier of its lowest rank" rule never has to arbitrate a cross-tier conflict
for this class.

## Card model changes from Chameleon template

> **2026-07-22 update:** Sections 1 and 3 below describe the *original*
> design as implemented in the main 9-task plan and Class C toggle plan.
> Both have since been superseded by conventions established during the
> card-by-card review pass (see "Current conventions (post-review)" below,
> which is authoritative for anything it covers). Kept here for history —
> do not re-implement the "plug-in view" naming or the name-pattern-only
> rank-merge rule; both were corrected.

### 1. Rank merge (superseded — see below)

Any set of sibling `commandNum`s whose skill names differ only by a trailing
rank digit (verified by checking they share a `cType`/coroutine dispatch
prefix in `Penguin.cs`, not just by name pattern) become **one card**,
placed at the position of the lowest rank's `commandNum` in tree order.

The card gets a small rank selector control (e.g. a row of `1 2 3 4`
buttons/pills near the title). Selecting a rank:
- Updates `reqLv`/`reqBn` shown (if displayed — Chameleon's template doesn't
  show these today; carry that convention forward, req info stays off-card).
- Re-populates every chip (CD/MP/SP/CAST/DUR/Range/DMG/KO) from that rank's
  own row in the underlying data table.
- Notes (`<ul class="notes">`) also switch if their content is genuinely
  rank-dependent (e.g. different projectile counts per rank); shared notes
  that don't vary by rank stay static.

Skills with no sibling ranks (most Class B/C entries, all passives) are
unaffected — single card, no rank selector, same as Chameleon's convention.

### 2. Aqua theme (formalized as template convention)

`example-template.html`'s `:root` currently hardcodes one accent for the
whole document with a comment explaining why it's shared across tiers. This
becomes a **named, class-level override point**: the accent variables move
to a single, clearly-marked block at the top of the `<style>` that a future
class build swaps wholesale, documented in the skill's SKILL.md as "set
these N variables for your class's accent, nothing else in the CSS should
need to change." Penguin's values: an aqua hue for `--acc`/`--acc-tint`
(exact hex chosen during implementation, following the same tint-derivation
approach as Chameleon's green — light tint background, saturated border/text
accent), spot-checked in both light and dark preview.

### 3. Base view vs. plug-in view (superseded — see below)

A view toggle (two-state control, e.g. a segmented switch) fixed near the
top of the document, above the first tier's content:

- **Base view (default)**: today's Chameleon-style rendering — symbolic
  formulas (`0.5×ATK + 60 + 1.2×TAL`), adjuster tags (`INT↓`, `CHA↑`,
  `LCK↑`), `Locked-on`/`∞` range chips, everything exactly per the existing
  template conventions and Common Mistakes table.
- **Plug-in view**: every chip that has an underlying formula recomputes in
  place to a concrete number, using live values from a **global stat
  panel** (see below). Per user decision, the symbolic formula is replaced
  by the computed number (not shown alongside).
  - Deterministic formulas (CD, MP/SP already deterministic, CAST, DUR,
    flat/linear DMG, KO) → single computed number in the chip.
  - Probabilistic terms (LCK-gated proc/crit chance, e.g. a crit multiplier
    chip) → chip shows the computed `lckAdjust`-adjusted percentage **and**
    both outcome values, e.g. `24% → 342 / 616`.
  - Range chips with no formula (`Locked-on`, `∞`, fixed meter values) are
    unaffected by either view — they're already concrete.
  - Rank selector state is preserved independently — plug-in view computes
    using whichever rank is currently selected on that card, not forced to
    max.

**Global stat panel**: one fixed input block at the top of the document
(below the view toggle), six numeric inputs — `ATK, INT, AGI, CHA, TAL,
LCK` — feeding every card simultaneously. Changing a value live-recomputes
all currently-plug-in-view chips. Panel is inert/hidden (or just visually
de-emphasized) in base view since it has no effect there.

## Current conventions (post-review, authoritative)

The card-by-card review pass (started after the main build, Class C toggle,
and LCK-range/revisedArt plans were all complete) established several
conventions beyond what any prior spec covers. This section is the living
reference — update it in place as new conventions are set, rather than
leaving them to only exist in commit messages.

### View naming: "Base" / "Final" (not "Plug-in Stats")

The second view's **button label** is "FINAL", not "Plug-in Stats"/"Plug-in
view" (renamed per explicit request — the internal JS identifier is still
the string `"plugin"` throughout the code; only the user-facing label
changed). Two stat panels feed it: "Player Stats" (`ATK, INT, AGI, CHA, TAL,
LCK, Player Level` — `Lv` was renamed from the original spec's plain `Lv`)
and "Enemy Stats" (`DEF, CHA, LCK`), the latter added later to drive the
damage chip's defense-mitigation pipeline (see LCK-range design doc for the
full pipeline). Both panels persist to `localStorage`, scoped as
`#statPanel input` / the enemy panel's own id — never a shared
`.statpanel input` class selector, which would conflate the two panels (a
real bug caught during the LCK-range build, see that plan's review notes).

### Family merge: same skill *slot*, not just same name pattern

The original rank-merge rule (trailing-digit siblings of the same name)
still holds, but the review pass established a broader rule: **any set of
skills that occupy the same effective skill slot** — sharing a cooldown,
being mutually exclusive, or otherwise being "one skill with several named
ranks" in all but the game's own data model — merge into one card with a
rank toggle, even when their names don't share a prefix. Example:
`doubleCast1` and `tripleCast2` were originally two separate one-rank cards
that cross-referenced each other via "shares cooldown with" warning text;
merged into a single `doubleCast` family (rank 1 = `doubleCast1`, rank 2 =
`tripleCast2`) once recognized as the same slot. Each rank keeps its own
`<h3>` title (driven by that rank's own `r.id`, unaffected by which family
object groups it) and its own real cost/cooldown/notes — merging is purely
a card-grouping decision, not a data change.

### Inline chip mechanism (`{{token}}`)

A rank's `notes` strings may embed `{{token}}` placeholders that get
replaced with a live, view-aware chip inline in the sentence — e.g. "Fires
ice projectile, each dealing {{dmg}} damage." Implemented as
`INLINE_CHIP_RE` / `substituteInlineChips` in the script. Supported tokens:
`dmg, cd, mp, sp, cast, range, ko`, plus the parameterized
`chance:N` (e.g. `{{chance:20}}`) for LCK-adjusted proc/spread chances whose
base value isn't a per-rank data field (a single rank can reference several
independent chances, so the base % travels in the placeholder text itself).

**Visual rule (current, corrected twice during review — this is the final
state):** every inline chip is a full visual clone of the `{{dmg}}` chip —
same accent background, white text, same padding, **no border**, regardless
of what color that chip type uses in the fixed row (e.g. `.chip.mp` is
light-blue-with-border in the fixed row, but solid-accent-with-white-text
when rendered inline via `{{mp}}`). This is implemented as a `.chip-inline`
modifier class, added only at inline call sites (never on fixed-row chips),
declared *last* in the stylesheet — after every per-type `.chip.<type>`
color/border rule — so its background/color/border/box-shadow always win
the cascade at equal specificity without an `!important`. Earlier
intermediate states (per-type color kept, only box-model unified; then a
manually-added thin border via inset `box-shadow` on `.chip.mp` alone) were
both superseded — do not reintroduce either.

`dmg` is the one field that's *also* unconditionally removed from the fixed
chip row (whether or not a rank's notes actually reference `{{dmg}}`) —
every other inlined field still renders in the fixed row too unless that
specific rank opts out (see `mpIsGain` below).

### `mpIsGain`: a rank's `mp` field can mean "gained", not "cost"

Default assumption everywhere is `mp` = a cost paid to cast. A rank can set
`mpIsGain: true` to flag that its `mp` value is actually MP *gained* (e.g.
`cAttack`'s channel-for-MP passive), which does two things:
- Excludes that rank from the fixed MP-cost chip row (`mpIsCost = r.mp &&
  !r.mpIsGain` gates both `isActive` and the `mpChip` render).
- The value still renders correctly wherever `{{mp}}` is used inline in
  notes — the flag only changes fixed-row/isActive treatment, not the
  chip's own math.

Scoped per-rank, never global — every other card's `mp` field is an
unaffected real cost. A card whose only "active" signal was `mp` (no
cd/sp/cast) becomes a pure passive (zero chip rows) once `mpIsGain` is set,
same as any other passive.

### Class C synergy toggle

Per-card checkbox (`classCToggle[famId][passiveId]`, independent per card
even when two cards reference the same `passiveId`) that live-recomputes
chips/notes when a Class C passive is toggled ON. A rank's `classC` array
holds `{passiveId, ...fieldOverrides}` entries; the active rank is a
non-mutating merge (`{...baseRank, ...matchedEntry}`) of the base rank plus
any currently-ON override. ON-state note text is wrapped in
`<span class="classc-on">` (dark gold, **not bold** — bold was removed per
review feedback) and is fully hidden (not shown as grayed-out "needs X"
prose) until toggled on.

### Keyboard shortcuts

`V` toggles Base/Final view, `R` toggles revisedArt — both implemented by
dispatching a real `.click()` on the existing toggle button (single source
of truth, no duplicated toggle logic), ignored while an `<input>`/`<textarea>`
has focus.

### Chip alignment: top, not center

`.sk` (skill-card icon+body grid) and `.pv` (passive-card icon+body flex)
both use `align-items:start`, not `center` — so icon/text don't visually
jump vertically when toggling rank or view changes a card's content height.
Applies to passive cards too (confirmed in review), not just multi-rank
skill cards.

### Bracket-free ranges

`formatRange(a, b, suffix)` renders `min-maxsuffix` (e.g. `12-18s`), not
`[min-max]suffix` — brackets were removed sheet-wide (dmg, CD, CAST) per
review feedback. Dmg/inline chips also use tighter padding (`1px 4px`) than
the base fixed-row chip (`3.5px 4px`), so the box hugs the value more
closely; the base `.chip` rule's own horizontal padding (`4px`) was
unchanged, only its vertical padding differs between the two contexts.

## Formula evaluator engine

**Data-first, not DOM-first.** Each skill's formula data lives in one
centralized JS object (not scattered `data-*` attributes), keyed by skill
id, e.g.:

```js
const SKILLS = {
  manaMissile: {
    tier: "classA",
    ranks: [
      { id: "pgn_manaMissile1", reqLv:.., cd: "...", mp:.., sp:.., cast:.., dmg: "...", ko:.., ... },
      { id: "pgn_manaMissile2", ... },
      ...
    ]
  },
  ...
};
```

Formula strings use named stat tokens (`ATK`, `INT`, `AGI`, `CHA`, `TAL`,
`LCK`) and the 5 documented adjuster functions as callable forms:
`agiAdjust(base)`, `magAdjust(base)` (displayed as INT-adjust), `chaAdjust(base)`,
`talAdjust(n)`, `lckAdjust(n)`. A small hand-rolled evaluator (no `eval`,
per security defaults) parses these into an AST once at load time and
evaluates against either:

- **symbolic mode**: adjuster calls render as their existing tag shorthand
  (`INT↓` on a cast-time chip, `CHA↑` on a duration chip, `LCK↑` marker on a
  chance term) and stat tokens render as their bare names — i.e. today's
  static text, generated from the same data instead of hand-typed HTML.
- **numeric mode**: adjuster calls actually compute
  (`agiAdjust(base) = base × 128/(statAGI+128)`, `talAdjust(n) = n + 0.02n×TAL`,
  `chaAdjust(v) = v × (1+0.015×CHA)`, `lckAdjust(n)` per its documented
  diminishing-returns curve, `magAdjust` same shape as `chaAdjust` but on
  INT) using the global stat panel's current values, producing a plain
  number.

This keeps card HTML declarative — cards render from `SKILLS` data via a
template function — so the rank-merge (multiple `ranks[]` entries) and the
view toggle (symbolic vs numeric render of the same AST) are both handled
by one engine rather than bolted on separately. This is the main new,
genuinely uncertain piece of engineering in this build; expect it to need
iteration once real formulas from steps below are in hand.

## Build procedure (delta from the skill's standard Procedure)

The standard 10-step Procedure in `12tails-class-infographic/SKILL.md`
still applies in full for data extraction (mechanics from `Penguin.cs` +
companions, range categorization, SP color, Class C passive cross-file
grepping, icon lookup). Deltas specific to this build:

1. After step 1 (map skill tree), add a **rank-family detection pass**:
   group commandNums by shared coroutine dispatch prefix (verified in code,
   not assumed from name pattern alone) before starting mechanics
   extraction, so extraction work happens once per family with per-rank
   deltas noted, not four times independently.
2. Step 3 (extract mechanics) runs per rank-family, capturing each rank's
   own CD/cost/cast/damage/duration values as a row, plus flagging which
   parts of the mechanic are rank-invariant (e.g. a fixed AoE radius that
   doesn't change 1→4) vs rank-scaling.
3. Step 9 (build the sheet) is replaced by: populate the `SKILLS` JS data
   object per the schema above, then verify the template's render function
   produces output matching what a hand-authored Chameleon-style card would
   have looked like, for both symbolic and numeric modes, before moving to
   the next skill family.
4. New step: implement and visually verify the rank selector and view
   toggle controls against at least one multi-rank family (manaMissile) and
   one single-card skill before populating the remaining ~60 entries, to
   catch engine design problems early rather than after full data entry.

## Testing / verification

Since this is interactive, "run it in a browser" replaces the print-PDF
check as primary verification:
- Toggle every rank on 2-3 representative multi-rank families, confirm
  chips/notes update correctly.
- Toggle base ↔ plug-in view with the stat panel at defaults (likely 0 or
  blank), confirm no `NaN`/broken-formula rendering — define a sensible
  zero-state.
- Enter representative stat values, spot-check 3-4 computed numbers by hand
  against the formula (e.g. confirm `agiAdjust` CD math matches the
  documented `128/(AGI+128)` shape).
- Verify a probabilistic chip (crit/proc) renders both outcome values
  correctly in plug-in view.
- Confirm the aqua accent renders correctly in both light and dark preview
  (`prefers-color-scheme` + `data-theme` override, per template convention).
- Print-preview sanity check only (not full PDF export pass) — confirm the
  page doesn't visibly break when toggles are at their default state.

## Open risks

- **Formula coverage**: Penguin's real formulas (not yet fully extracted)
  might include a shape the evaluator doesn't anticipate (e.g. a term
  gated by another skill's rank the way Chameleon's `improvedSlayer` was) —
  the engine needs to support conditional/named terms (per the `.dmg` chip
  convention with `.syn`-tagged conditional clauses) in both symbolic and
  numeric render modes, which is more complex than a flat linear sum. This
  will likely require iteration once real formulas are in hand from
  extraction, not full certainty at spec time.
- **Card layout at scale**: 68 tree entries merging to an unknown-but-fewer
  number of cards (rank families collapse ~30 entries down to ~10-12 cards)
  — page/column packing behavior is untested until real content exists;
  the existing multi-column CSS approach (not CSS Grid, per Common
  Mistakes) should still apply but wasn't validated against a rank-toggle
  control's extra vertical space.
