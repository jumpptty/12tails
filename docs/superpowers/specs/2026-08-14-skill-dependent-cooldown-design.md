# Skill-Dependent Cooldown Variables + Single-Rank Toggle UI — Design Spec

Date: 2026-08-14
Feeds: `12t_projects/player-reference-tool/index.html` (Skill Cooldown/Duration Lookup tool)
Builds on: `2026-08-13-skill-dependent-duration-design.md` (the original `dep` field, Duration-only)
Reference docs updated alongside: `12t_reference/sheep-skill-reference.md`,
`12t_reference/whale-skill-reference.md`

## Problem

The 2026-08-13 `dep` field let a skill's *Duration* depend on a separate passive's
learned rank (Rabbit's Medical Enhancement/Alchemist Lab, Wolf's Perseverance). The
user's next two pointers were both **Cooldown**-side instead:

- **Sheep's `bless`**: cooldown is capped at a flat 30s once the `gospel5` passive is
  learned (base 90s unlearned) — verified `Sheep.cs:21263`, already documented in the
  reference doc's existing judgment-call note.
- **Whale's `sweep`/`javelin`/`shieldRush`/`flyingShield`/`peninsulaImpale`/
  `peninsulaRound`**: all six reduce their cooldown by a skill-specific flat amount
  once `knightOfTheDeep1` is learned — verified `Whale.cs:9813-9816`
  (`getKnightOfTheDeepLv()`, 0 or 1) plus each skill's own cast site, already
  documented in the reference doc's existing judgment-call note.

Both mechanics were already fully researched and cited in the 12t_reference docs from
the original Tasks 1-12 research pass — this build only had to wire already-verified
data into the tool, not re-derive anything.

## Data model: `cdDep`

A new field, `cdDep`, mirrors `dep`'s exact schema (`id`/`label`/`icon`/`minRank`/
`maxRank`/`perRank`, or `kind:"postMultiply"`/`multipliers`) but is read against the
skill's **Cooldown** stat instead of Duration:

```js
{ id:"sheep_bless", ..., cd:90, cdWrapped:true, ...,
  cdDep:{ id:"gospel", label:"Gospel", icon:"sheep_gospel5", minRank:0, maxRank:1, perRank:-60 } }

{ id:"whale_sweep", ..., cd:30, cdWrapped:true, ...,
  cdDep: whaleKnightDep(-10) }   // whaleKnightDep(perRank) factory, shared id "knightOfTheDeep"
```

Both discovered relationships turned out to reduce to the *existing* linear
`rawAtRank(R) = base + perRank*(R - minRank)` formula from the original spec — no new
`kind` was needed. This is expected, not a coincidence to be suspicious of: both
`gospel5` and `knightOfTheDeep1` are single-rank passives (only ranks 0/1 exist), and
any two points trivially fit a line. Whale's six skills don't share one `perRank`
(`-10`/`-15`/`-30`/`-40` depending on the skill) but do share one `id`
(`"knightOfTheDeep"`), so a `whaleKnightDep(perRank)` factory function produces six
distinct dep objects that nonetheless read/write the same `depRanks["knightOfTheDeep"]`
slot — toggling the passive on any one of the six carries over to the other five,
matching it being one single in-game learned/not-learned state, the same
shared-state-via-shared-`id` pattern `WOLF_PERSEVERANCE_DEP` already established for
Duration deps.

## Render logic

`renderHero()`'s Duration-dep handling (`dep`) and the new Cooldown-dep handling
(`cdDep`) are both routed through three shared helpers rather than duplicating the
rank-resolution/formula logic per stat:

- `getDepRank(dep)` — reads (initializing to `dep.maxRank` on first use) the shared
  `depRanks[dep.id]` slot.
- `depRawValue(baseValue, dep, depRank)` — the `preAdd`-vs-`postMultiply` branch that
  used to be inlined in the Duration block only; now callable against either `cd` or
  `duration` as `baseValue`.
- `depPostMultiply(range, dep, depRank)` — the post-`chaAdjust`/`agiAdjust` multiply
  step for `kind:"postMultiply"` deps, same generalization.

The Cooldown box computes `rawCd` from `cdBase` (already private-server-aware) through
`depRawValue`, feeds that into `agiAdjustRange` in place of the un-adjusted base, then
applies `depPostMultiply` before `applyRevisedArt` — mirroring the Duration box's own
`rawDuration` → `chaAdjustRange` → `depPostMultiply` sequence exactly. The "base Xs"
line under each stat now always shows the dep-adjusted raw value (`rawCd`/
`rawDuration`), not the un-adjusted `selected.cd`/`selected.duration` — this was
already true for Duration and is now true for Cooldown too, so e.g. Bless's own base
line reads `90s` (gospel unlearned) or `30s` (learned), not a static `90s` regardless
of the toggle.

## UI addition: single-rank deps render as a toggle, not a stepper

Both `gospel5` and `knightOfTheDeep1` are learned-or-not passives — `dep.maxRank -
dep.minRank === 1`, i.e. exactly two selectable states. The existing numbered-button
rank stepper (built for Rabbit's 4-rank Medical Enhancement and Wolf's 3-rank
Perseverance) reads oddly for a binary case — two buttons labeled "0"/"1" for a
concept that's really just "learned/not". Changed (same day, at the user's request)
so `renderDepBlock(dep, depRank)` branches on this:

- **`maxRank - minRank === 1`** → renders `.sk-dep-toggle`, a single button showing
  just the dep's own icon at 48px, `on` class applied when the current rank equals
  `maxRank`. Clicking flips between `dep.minRank`/`dep.maxRank` (wired via
  `data-dep-toggle-off`/`data-dep-toggle-on` attributes on the button, read by a
  dedicated click handler alongside the existing `.sk-dep-rank-btn` one). Same on/off
  visual language as the existing `.sk-revisedart` global toggle (grayscale + 50%
  opacity when off, full color when on) — **not** `.sk-ps-toggle`'s panel-background
  "chip" styling, which was tried first and reverted same-day: `.sk-ps-toggle`'s icon
  is a generic UI glyph (fine inside a colored chip), but a *skill* icon inside a
  background box reintroduces exactly the boxed-icon look the 2026-08-13 borderless
  rule (this project's own `CLAUDE.md`) was written to eliminate. `.sk-dep-toggle`
  therefore uses `.sk-revisedart`'s fully frameless pattern (`background:none;
  padding:0`) — no button chrome at all behind the icon.
- **`maxRank - minRank > 1`** (Rabbit's two families, Wolf's Perseverance) → unchanged
  numbered-button stepper, since there genuinely is a middle rank worth picking.

Both branches share one `data-dep-id` attribute convention on their buttons so a
single delegated click handler per button-class can update the correct `depRanks` slot
without assuming which stat box (Cooldown or Duration) it lives in — needed once a
skill could plausibly have both a `dep` and a `cdDep` at once (none currently does, but
the render path no longer assumes only one dep block exists per skill).

## Icons

`gospel5.png` (Sheep) and `KnightOfTheDeep1.png` (Whale) already exist in
`RippedAssets/.../gamegui/icons/skills/<Class>/` and were base64-embedded into
`SKILL_ICONS` as `sheep_gospel5` / `whale_knightOfTheDeep1`, same extraction pattern as
`.superpowers/sdd/dump_skill_cooldown_icons.py`. `knightOfTheDeep1` is confirmed
single-rank in `WhaleSkill.cs:566-583` (only that one numbered variant exists as a
learnable skill; the on-disk `KnightOfTheDeep0/2/3.png` files are unused sibling
assets, not real in-game ranks) — `KnightOfTheDeep1.png` is the correct representative
icon.

## Verification

Hand-computed against the live formulas at AGI=CHA=LCK=128 (the tool's own defaults)
and confirmed via Playwright against the actual rendered tool:

- `bless`, gospel learned (default): Cooldown `13.6–15s` (base `30s`).
- `bless`, gospel unlearned (toggled off): Cooldown `40.9–45s` (base `90s`).
- `sweep`, knightOfTheDeep learned (default): Cooldown `9.1–10s` (base `20s`).
- `sweep`, knightOfTheDeep unlearned (toggled off): Cooldown `13.6–15s` (base `30s`).
- `peninsulaRound`, knightOfTheDeep learned: Cooldown `36.3–40s` (base `80s`).
- Regression-checked Rabbit's `boostShot` (4-rank Duration `dep`) and Wolf's
  `darkEdge` (3-rank `postMultiply` Duration `dep`) still render the numbered
  stepper and compute correctly after the shared-helper refactor — `darkEdge` at
  rank 2 (×1.5): Duration `36–40s` (base `8s`), matching the pre-refactor formula.

## Scope

This build wires up only Sheep's `bless`/`gospel5` and Whale's six `knightOfTheDeep1`-
affected skills. The `cdDep` field, shared render helpers, and toggle-vs-stepper UI
split are generic — any future class's Cooldown-side dependency (or a future
single-rank Duration `dep`, which would now automatically render as a toggle too) can
opt in the same way once traced. Other classes are out of scope for this change.
