# Penguin Class C Synergy Toggle — Design

## Goal

Replace the current static "needs X" prose bullets on cards affected by a
Class C passive with an interactive per-card toggle that live-recomputes
the card's chips and notes to reflect the passive's actual bonus, in both
base (symbolic) and plug-in (numeric) view — consistent with how the rank
toggle and stat panel already make the sheet interactive rather than static.

This is a follow-up to the main Penguin interactive infographic build
(`2026-07-21-penguin-interactive-infographic-design.md` and its
implementation plan). It applies retroactively to the 7 existing
cross-references already written into Basic/Class A tier data, and its
schema must be followed by Class B/C tier data still to be written (Tasks
7-8 of the main plan).

## Scope

**In scope:**
- A `classC` override schema on `SKILLS[id].ranks[i]`.
- A per-card toggle UI element, one per `classC` entry.
- A 7th global stat input, Character Level, added to the existing stat
  panel.
- `renderSkillCard` merging active overrides into the rank before rendering,
  in both base and plug-in view.
- Converting the 7 existing prose-only synergy cross-references (see
  "Existing cross-references to convert" below) into real `classC` entries.

**Out of scope (unless a future correction says otherwise):**
- Synchronizing toggle state across multiple cards referencing the same
  passive (confirmed: each card's toggle is independent, per user decision).
- A "which passives have I learned" global character-build panel — this
  toggle is scoped per-card, not a class-wide passive tree.
- Any Class C passive not yet represented in `SKILLS` data (Class B/C tiers
  are separate, not-yet-written tasks — those tasks' own briefs must be
  written to populate `classC` entries directly, using this schema, rather
  than writing prose bullets that get converted later).

## Data schema

Each rank object may gain an optional `classC` array (omit entirely if the
rank has no Class C synergy — most ranks will omit it):

```js
{
  id: "pgn_manaMissile1", /* ...existing fields... */
  classC: [
    {
      passiveId: "moreMissile5",       // toggle label; matches the SKILLS
                                        // key of that Class C passive's own
                                        // card, so cross-linking is trivial
      dmg: "talAdjust(15) + 0.1×Lv",   // override for the dmg field
      notes: [                          // override for the ENTIRE notes array
        "<b>4 missiles</b> (2 base + 2 from \"moreMissile5\"), each hits independently."
      ]
    }
  ]
}
```

Rules:
- Any top-level rank field named in an override object (`dmg`, `cd`, `cast`,
  `mp`, `sp`, `ko`, `range`, `notes`, etc.) REPLACES that field's base value
  when the toggle is ON. Fields not named in the override keep their base
  value.
- `notes` overrides replace the entire array, not append to it — this keeps
  authoring explicit (write the complete on-state notes yourself) rather
  than needing a merge/diff convention for list fields.
- `classC` is an array to allow more than one independent synergy per card
  in the future, though no current card has more than one (verified: every
  existing cross-reference is 1-to-1, card-to-passive). Each array entry
  gets its own independent toggle.
- A new stat token, `Lv` (character level), becomes available to formula
  strings alongside the existing 6 (`ATK/INT/AGI/CHA/TAL/LCK`), for
  overrides whose bonus scales with character level (e.g. `moreMissile5`,
  `penguinOfArc5`).

## UI

Each `classC` entry renders a small toggle control (checkbox or pill-style
button, following the sheet's existing control aesthetic — exact markup
decided at implementation time to match the rank-toggle/view-toggle visual
language already established) placed near the card's rank-toggle row,
labeled with `passiveId` (e.g. `☐ moreMissile5`). Clicking it flips that
one entry's on/off state and re-renders that card only (same `rerenderAll`-
style targeted re-render the rank toggle already uses, not a full-page
re-render).

State: `classCToggle[famId][passiveId] = boolean`, defaulting `false`
(OFF) for every entry on page load — matching the sheet's existing default
of showing baseline info first, with rank already defaulting to max
(Correction 5) as the one exception where "most complete state" is already
the default. Class C toggles stay OFF by default since not every reader
has every Class C passive learned; this is a toggle to explore "what if,"
not a state to assume.

Toggle behavior is identical in base view and plug-in view — the same
overridden field values feed into the existing `chipHTML`/`renderSymbolic`/
`renderNumeric` pipeline exactly as base rank data does today. No new
rendering pipeline is introduced.

## Rendering integration

`renderSkillCard(famId, fam, rankIdx, view, stats)` gains one step at the
top: build an "effective rank" by shallow-merging the selected rank's base
fields with any currently-ON `classC` override fields (later-array-entries
win if somehow two were both on and touched the same field, though this
doesn't occur in current data). The rest of the function is unchanged — it
already doesn't care whether a field's value came from base data or a
merge, so no chip-building or notes-building logic needs to know toggles
exist.

Character Level (`Lv`) is added to the existing global `stats` object
(`{ ATK, INT, AGI, CHA, TAL, LCK, Lv }`) and to the stat panel's HTML markup,
following the exact same input-field pattern as the other 6 stats
(`<label>Lv<input type="number" id="stat-Lv" value="0" min="0"></label>`).

## Existing cross-references to convert

7 prose-only synergy bullets currently exist in Basic/Class A tier data and
must become real `classC` entries (exact override values to be derived from
`12t_reference/penguin-skill-damage-reference.md` at
implementation time, not invented fresh):

| Card (family) | Passive | Current prose (summary) |
|---|---|---|
| `nAttack` | `spreadShot5` | 20%/40% chance to fire 3 spread projectiles instead of 1 |
| `cAttack` | `manaField5` | +chargeLv MP/tick, shares MP with nearby allies |
| `manaMissile` | `moreMissile5` | +2 missiles, +0.1×Lv dmg each |
| `manaArc` | `penguinOfArc5` | +0.5×Lv damage, cosmetic VFX swap |
| `dispell` | `parallelShift5` | dispell level +1 |
| `manaBurn` + `mpTransfer` | `manaSurge5` | manaBurn: status lv+2, +0.1×curMP; mpTransfer: +0.5×Lv heal |
| `fallingStars` + `fallingComets` | `giantStar5` | ×1.5 targeting radius, cap 5→10, impact radius bump, ×1.25 dmg |

Some of these (`spreadShot5`'s chance-based proc, `cAttack`'s ally-sharing
mechanic) don't cleanly reduce to a single chip override — for those, the
`classC` entry's `notes` override is the primary mechanism (restating the
full on-state description), with any chip fields that DO have a clean
numeric form (e.g. none of spreadShot5's effect is chip-representable; it's
a proc chance already described in prose) left out of the override object
entirely if there's nothing to override.

## Testing / verification

Same methodology as the main plan: browser-driven (or equivalent headless
harness if no browser is available) verification that:
- Toggling each of the 7 converted cards' checkboxes updates chips/notes
  correctly in both base and plug-in view.
- Toggling OFF correctly reverts to base values (not stuck showing the
  override).
- The new `Lv` stat input feeds `moreMissile5`/`penguinOfArc5`'s formulas
  correctly in plug-in view.
- No regression to rank-toggle or view-toggle behavior on cards that have
  no `classC` entries at all (the common case — most cards).

## Open risk

`spreadShot5` and `cAttack`'s `manaField5` synergy don't have a clean
chip-formula override (they're proc-chance and ally-AoE mechanics
respectively) — their `classC` entries will be notes-only overrides with no
chip changes, which is a valid but less visually dramatic case of the
toggle than e.g. `manaMissile`'s damage-formula change. This was already
anticipated (see "Existing cross-references to convert" above) but is
called out again as the two cases where "the chips visibly change" won't
actually be demonstrated even though the toggle itself still works
correctly.
