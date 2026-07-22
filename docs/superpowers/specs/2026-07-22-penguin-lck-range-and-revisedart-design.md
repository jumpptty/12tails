# Penguin LCK-Range Display + revisedArt Toggle — Design

## Goal

The sheet's formula evaluator currently treats every "adjuster" function
(`talAdjust`, `agiAdjust`, `magAdjust`, `chaAdjust`, `dmgAdjust`, `defAdjust`,
`atkAdjust`) as producing one deterministic number in plug-in view. In the
real game, every one of these functions rolls `random(0, ⌈0.2×LCK⌉)`
internally — the displayed number has always been an approximation of one
possible outcome, not the true range a player would actually see.

This work makes plug-in view show the true `[min-max]` range for every chip
whose underlying formula involves a randomized adjuster, computed by
evaluating each formula at both extremes of every attacker- and
defender-side LCK roll simultaneously (not chip-by-chip in isolation). Base
(symbolic) view is entirely unaffected — no mention of LCK rolls or ranges
is added there; it keeps its current single-formula display.

This also adds:
- An **Enemy Stats** panel (DEF/CHA/LCK) alongside the existing **Player
  Stats** panel (now labeled as such, was unlabeled/implicit before),
  feeding the defender-side half of the damage pipeline (`defAdjust`).
- **Player Level** renamed from the prior generic "Lv" label (already
  implemented as a stat token in the evaluator; this is a display-label
  change only, not a new field).
- **DMG Mod** as an 8th Player Stats field, feeding `dmgAdjust`'s
  gear-multiplier term (`damageMod`).
- A **global revisedArt5 toggle** in the control bar (not per-card, since
  it's a single class-wide passive) — a clickable icon, grayscale when OFF
  / full color when ON, applying the verified `ceil(0.88 × x)` reduction to
  every cooldown chip's computed range, except cType `nAttack`/`cAttack`
  and any consumable-item type (none of which currently exist as skill-tree
  cooldowns on this sheet, so in practice this exclusion list only matters
  if it ever does).

## Source formulas (verified against `CharacterControl.cs`, exact)

All 7 adjusters share the identical roll: `roll = random(0, ⌈0.2×LCK⌉)`,
using **whichever character's own LCK the function is called on** — for
player-side adjusters (`talAdjust`, `agiAdjust`, `magAdjust`, `chaAdjust`,
`dmgAdjust`, `atkAdjust`) that's the attacker's LCK; for `defAdjust` it's
the **defender's** LCK, since `defAdjust` is called on the *target*
character, not the caster (confirmed at `CharacterControl.cs:3546`:
`nDamage = characterControl.defAdjust(nDamage)` where `characterControl` is
the hit target, immediately after `nDamage = this.dmgAdjust(nDamage)` where
`this` is the attacker — two different characters' stats, two independent
rolls).

- `talAdjust(n)` — `CharacterControl.cs:20624`: if `n≤0` return `0`; else
  `num = clamp(TAL+roll, 1, 512)`; `n = (int)(n × (1+0.02×num))`; return
  `ceil((float)n)`. (The `(int)` truncation happens on the multiply, THEN
  `ceil` is applied to the already-truncated integer promoted back to
  float — functionally a no-op ceil since it's already an integer, but
  replicate the two-step shape for fidelity.)
- `agiAdjust(t)` — `CharacterControl.cs:20575`: `num = AGI+roll` (no
  clamp); return `t × (1 − num/(num+128))` as a raw float, no rounding
  inside the function itself (matches the sheet's current `agiAdjust`
  implementation exactly — unchanged).
- `magAdjust(t)` — `CharacterControl.cs:20584`: `num = clamp(INT+roll, 1,
  512)`; return `clamp(t − num/32, 0.1, 600)` — note `num/32` here: `num`
  is `int`, `32` is `int`, giving C#'s integer division (truncating
  toward zero) BEFORE the subtraction, not a float divide. Must replicate
  this exact truncation, not `num/32` as a real-number division.
- `chaAdjust(t)` — `CharacterControl.cs:20593`: `num = clamp(CHA+roll, 1,
  512)`; `t = (int)(t × (1+0.015×num))`; if `t>0` return `ceil((float)t)`
  else return `t` unchanged (raw, un-ceil'd) — the zero/negative branch
  skips the ceil, replicate this conditional exactly.
- `dmgAdjust(d)` — `CharacterControl.cs:20487`: `ceil(clamp(damageMod,0,5)
  × d + roll)` — `roll` here is added directly (not added to a stat first)
  — this is the attacker's own LCK roll and their `damageMod` (DMG Mod
  stat field).
- `defAdjust(d)` — `CharacterControl.cs:20524` — the defender-side blend:
  ```
  DEF′ = clamp(DEF + roll, 1, 512)          // defender's own DEF+LCK roll
  flat = (int)(d − 0.5×DEF′); if flat<1 → flat=1
  pct  = (int)(d × (1 − DEF′/(DEF′+64)));  if pct<1 → pct=1
  result = ceil(0.35×flat + 0.65×pct)
  ```
- `atkAdjust(p)` — `CharacterControl.cs:20516`: `floor(clamp(p×(ATK+roll),
  1, 512))` — not currently used by any Penguin formula on this sheet
  (Penguin's `dmg` formulas use `talAdjust`, not `atkAdjust`, since ATK
  itself is a flat multiplier term like `0.5×ATK`, not run through an
  adjuster) — included here for completeness/fidelity but likely dead
  code for this specific class's sheet. Confirm during implementation
  whether anything actually calls it; if not, skip implementing it.
- `lckAdjust(n)` — `CharacterControl.cs:20658-20671`: **has no random roll
  of its own** (unaffected by min/max roll mode — it's the one adjuster in
  this list that isn't itself randomized, only used to size the diminishing-
  returns curve for LCK-driven percentage/chance terms elsewhere). Exact
  formula, all 3 steps required, none of which were in this doc's original
  draft (a real gap caught in review — do not re-drop these when reading
  this doc): if `n≤0` return `0` outright; else `num = n × (1+0.01×clamp(LCK,
  1,512))` (LCK IS clamped here, unlike the roll-based adjusters where the
  clamp applies to `stat+roll` — here it applies to the bare LCK stat);
  return `floor(100×num / (num−n+100))` — the result is always an integer
  (floored), never a raw float.

**revisedArt5** (`CharacterControl.cs:20102-20227`, `addTimeOut`): once a
cooldown value is computed by the caller (i.e., AFTER `agiAdjust` has
already run), if `hasSkill(424)` and `cType` isn't in the exclusion list
(`nAttack, cAttack, emoticon, potion, drug, salve, boost, tonic, elixir,
firework, bomb, flag, key, prize, special, food, desert, drink`), then
`cTime = ceil(0.88 × cTime)`. This is a strictly sequential second step,
not part of `agiAdjust` itself.

## Full damage pipeline (for the dmg chip's [min-max] range)

```
baseFormula(stats)          // e.g. talAdjust(15) — the sheet's existing dmg field, itself LCK-randomized
  → dmgAdjust(...)          // attacker's damageMod + attacker's own independent LCK roll
  → defAdjust(...)          // defender's DEF + defender's own independent LCK roll
```

Three independent random draws feed into one final number: the roll(s)
inside the base formula's own adjusters (e.g. `talAdjust`'s TAL roll),
`dmgAdjust`'s own roll, and `defAdjust`'s own roll. Per the user's decision,
**all attacker-side rolls (base formula's own + dmgAdjust's) move together**
(both at 0 for the minimum, both at their ceiling for the maximum, since
they draw from the same attacker LCK stat and there's no reason a "lucky"
attacker roll would desync between the two call sites in a true worst/best
case) — the **defender-side roll (defAdjust's DEF roll) moves independently
and in the OPPOSITE direction** for genuine min/max bracketing (attacker
best case + defender worst case = max damage; attacker worst case +
defender best case = min damage).

## Range computation architecture

The evaluator needs a second numeric mode alongside today's single-value
`renderNumeric`: a **ranged** evaluation that, for any AST containing one or
more randomized-adjuster calls, produces `{min, max}` instead of one number.

**Approach**: extend each adjuster's numeric implementation to accept an
explicit roll-selection mode (`"min"` or `"max"`) instead of always
internally drawing `Math.random()`-equivalent noise. A new
`renderRange(ast, stats, enemyStats)` walks the AST twice — once forcing
every attacker-side adjuster to its `roll=0` extreme and every
defender-side adjuster (`defAdjust` only) to its `roll=ceil(0.2×enemyLCK)`
extreme (giving the minimum output), and once with attacker-side at
`roll=ceil(0.2×LCK)` and defender-side at `roll=0` (giving the maximum
output) — reusing the exact same per-function formula logic as
`renderNumeric`, just parameterized by which extreme to plug in for each
call's own roll term, rather than duplicating formula logic in two places.

This is a natural generalization of the existing `renderNumeric(ast,
stats)` — becomes `renderNumeric(ast, stats, enemyStats, rollMode)` where
`rollMode` is `"min"` or `"max"`, and the base `renderNumeric` behavior used
everywhere else that doesn't need a range (is there anywhere else? — the
old chip renderer used `renderNumeric` for a single number; every plug-in
numeric chip will now go through the ranged path for chips whose formula
contains an adjuster, i.e. essentially all of them, so `renderNumeric`'s
old signature likely gets fully replaced rather than kept alongside a new
function — final call left to implementation, since this is an internal
refactor of an existing function, not a new public interface with external
consumers to preserve compatibility for).

`dmg` chips additionally route through `dmgAdjust`/`defAdjust` after the
base formula's own range is computed — meaning the `chipHTML`/
`substituteInlineChips` call site for `dmg` specifically needs its own
wrapper that: (1) computes the base formula's `{min,max}`, (2) feeds each
through `dmgAdjust`'s min/max (attacker roll synced with step 1's own
direction), (3) feeds each through `defAdjust`'s min/max (defender roll
INVERTED relative to steps 1-2's direction). Every other chip type (CD,
CAST, DUR) only has step 1 (their own formula's range) plus, for CD
specifically, the `revisedArt` ×0.88 step applied to both endpoints
afterward if the global toggle is ON.

## UI changes

### Player Stats panel (renamed from the current unlabeled stat panel)
- Existing 6 fields (ATK/INT/AGI/CHA/TAL/LCK) unchanged.
- `Lv` relabeled to `Player Level` (label text only — the underlying stat
  key/token stays `Lv` in code, since that's already wired through the
  evaluator and every `classC` override formula string; renaming the JS
  key itself would be a much larger, purely-cosmetic-benefit change not
  worth the risk of touching every `{{...}}`/formula string that
  references it).
- New 8th field: `DMG Mod` (`damageMod`), default `1`, feeds `dmgAdjust`.

### Enemy Stats panel (new)
- Three fields: `DEF`, `CHA`, `LCK` — matching exactly what `defAdjust`
  needs (`DEF`, `LCK` directly; `CHA` is NOT used by `defAdjust` itself,
  but is included per the user's explicit request — likely anticipating a
  future contested-duration/`getDebuff`-style calculation that also needs
  defender CHA, even though no current formula on this sheet consumes it
  yet; include the field now, wire it up only where an actual formula
  needs it, leave it inert/unused elsewhere rather than blocking on
  finding a current consumer).
- Same visual treatment as Player Stats (a labeled group of number inputs),
  positioned adjacent to it in the control bar.
- Also persisted via localStorage, same mechanism as Player Stats (the
  existing persistence code already generalizes over "every key in a
  stats-like object" — extend to a second `enemyStats` object with its own
  storage key).

### revisedArt global toggle
- A single icon button in the control bar (not per-card). Uses the
  `revisedArt5` skill icon already available in `ICONS` (confirmed present
  from the original icon-extraction pass — `revisedArt5` was one of the 96
  icons dumped, even though it was never wired into `SKILLS` data since
  Class C tier population was never completed).
- CSS: `filter: grayscale(100%)` when OFF (default), no filter (full
  color) when ON — matching the user's exact request.
- Toggling recomputes every CD chip's range (both base agiAdjust range and,
  if ON, the subsequent ×0.88 step) sheet-wide via the existing
  `rerenderAll()` mechanism — same pattern as the view toggle.
- State: a single top-level boolean (e.g. `let revisedArtOn = false`), not
  a `{[famId]: ...}` map like `classCToggle`, since this is genuinely
  global, not per-card.

## Display format

`[min-max]` bracket notation for any ranged chip, unit suffix once after
the closing bracket: `CD [8.5-9.2]s`, `CAST [3.1-3.6]s`, damage chip
`[142-198]` (no unit suffix, matching today's unitless damage numbers).
If `min === max` (no adjuster in the formula at all, or a degenerate
0-LCK-range case), collapse to a single number with no brackets — avoids
a redundant `[142-142]` display for a chip that happens to have no real
range.

Base (symbolic) view: **completely unchanged**. No `[x-y]` bracket
notation, no LCK-roll mention, current single-formula text exactly as
today.

## Non-goals / explicitly out of scope for this pass

- `atkAdjust` implementation is speculative/likely-unused per the note
  above — only build it if something on this sheet's data actually calls
  it; don't add dead formula-evaluator code for a function nothing uses.
- Extending ranges to any chip type beyond CD/CAST/DUR/dmg (e.g. MP/SP
  costs are NOT LCK-randomized in source — `SkillClass.MP`/`SP` fields are
  flat costs with no adjuster call anywhere in the decompile) — do not add
  ranges to chips that were never actually randomized in the real game.
- Actually populating Class C tier `SKILLS` data (the broader Task 7/8 from
  the original main plan) — this pass only adds the `revisedArt` toggle
  mechanism and control-bar icon; it does not add `revisedArt5`'s own skill
  card content, since Class C tier population is separate, larger,
  already-deferred work.
