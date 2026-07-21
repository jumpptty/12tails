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

### 1. Rank merge

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

### 3. Base view vs. plug-in view

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
