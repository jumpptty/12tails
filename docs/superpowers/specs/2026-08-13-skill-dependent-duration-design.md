# Skill-Dependent Duration Variables — Design Spec

Date: 2026-08-13
Feeds: `12t_projects/player-reference-tool/index.html` (Skill Cooldown/Duration Lookup tool)
Reference doc updated alongside: `12t_reference/rabbit-skill-reference.md`

## Problem

Some active skills' Duration is not a fixed number — it's modified by the rank of a
separate *passive* skill the character has learned. Two verified Rabbit examples:

- **Medical Enhancement** (passive, ranks 0-3) raises the duration of **Immune Shot**,
  **Boost Shot**, **Heat Shot**, and **Life Shot** by a flat amount per rank.
- **Alchemist Lab** (passive, ranks 1-4) raises the duration of **Miracle Blend**'s
  thrown-potion effect by a flat amount per rank.

The Skill Cooldown/Duration Lookup tool had no way to represent this — Duration was
always a fixed base number adjusted only by CHA/LCK. This spec adds general
infrastructure for "a skill's duration depends on another skill's rank," using Rabbit's
two families as the first real data.

## Data verified

- **Medical Enhancement → Immune/Boost/Heat/Life Shot**: `Rabbit.cs:10381-10420`
  (`getMedicalEnhancementLv()`, returns 0-3) feeds `Rabbit.cs:28224`
  (`$mLv$27104 = 1 + getMedicalEnhancementLv()`), which feeds each skill's own
  `chaAdjust(coreBase + $mLv$27104 * 5)` duration call (`:28287`, `:28341`, `:28400`,
  `:28459`). The table's existing `duration` field already stores the rank-0 raw value
  (e.g. `boostShot` = 35 = `30 + 1*5`), so the per-rank raw value is
  `duration + 5*rank` for `rank` in `[0,3]`.
- **Alchemist Lab → Miracle Blend**: previously undocumented (main `Rabbit.cs` has zero
  `alchemistLab` references). Found in `Rabbit_potion.cs:223-270` — the thrown potion's
  pickup handler checks `hasSkill(231/232/233/234)` (= `rab_alchemistLab1-4`, confirmed
  in `RabbitSkill.cs:2628-2671`) to set a rank variable `num` (1-4, default 0 but
  clamped to a floor of 1 by `Mathf.Clamp(num,1,4)`), which drives the `"miracleDrop"`
  status duration at `Rabbit_potion.cs:432-438`:
  `chaAdjust(4 + 2*num)` → 6/8/10/12s. Raw value formula: `4 + 2*rank` for `rank` in
  `[1,4]`; rank-1 raw value is 6, matching the family's own base.

## Data model

Any `SKILLS` entry may add an optional `dep` object:

```js
{ id:"rabbit_boostShot", ..., duration:35, durWrapped:true,
  dep:{ id:"medicalEnhancement", label:"Medical Enhancement",
        icon:"rabbit_medicalEnhancement3", minRank:0, maxRank:3, perRank:5 } }

{ id:"rabbit_miracleBlend", ..., duration:6, durWrapped:true,
  dep:{ id:"alchemistLab", label:"Alchemist Lab",
        icon:"rabbit_alchemistLab4", minRank:1, maxRank:4, perRank:2 } }
```

`duration` always stores the raw (pre-`chaAdjust`) value at `dep.minRank`. The raw
value at an arbitrary rank `R` (`minRank <= R <= maxRank`) is:

```
rawAtRank(R) = duration + dep.perRank * (R - dep.minRank)
```

`durWrapped` continues to control whether `chaAdjust`/`agiAdjust` is applied to that
raw value, same as today.

`dep.icon` is a single representative icon (the passive's max-rank icon file, matching
the existing convention for active skills) — not swapped per selected rank.

## Icons

`medicalEnhancement3.png` and `alchemistLab4.png` already exist in
`RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/Rabbit/` and get
base64-embedded into `SKILL_ICONS` as `rabbit_medicalEnhancement3` /
`rabbit_alchemistLab4`, same extraction pattern as `.superpowers/sdd/dump_skill_cooldown_icons.py`.

## UI / interaction

- Rank stepper renders **inline inside the Duration stat box**, below the existing
  "base Xs" line, only when `selected.dep` is present.
- Layout: passive icon (small, ~20px) + `dep.label`, then a row of numbered buttons
  from `dep.minRank` to `dep.maxRank` (segmented-control style, gold fill on the active
  rank — matches the Ledger design system's existing button/toggle treatment, no new
  visual language).
- Clicking a rank button recomputes and re-renders the Duration value live, same as
  editing the AGI/CHA/LCK inputs does today.
- State is a single `depRanks` map (`{ [dep.id]: rank }`) scoped at the tool's mount
  level, defaulting each passive to `dep.maxRank` the first time it's encountered
  (changed from `dep.minRank` on 2026-08-13, same day, at the user's request — the
  tool now assumes a fully-invested build by default rather than an unlearned one).
  This persists across skill switches within the session — e.g. picking rank 1 while
  viewing Boost Shot keeps rank 1 selected when switching to Heat Shot, since both
  share the same `medicalEnhancement` passive. Not persisted across page reloads,
  matching AGI/CHA/LCK's existing behavior.
- AGI/CHA/LCK inputs default to `128` (changed from `0` same day, same request) rather
  than an unstatted character.

## Reference doc changes

`12t_reference/rabbit-skill-reference.md`:
- `miracleBlend`'s Duration cell changes from `—` to `6` (Duration Wrapped: `true`),
  with a new citation pointing at `Rabbit_potion.cs`.
- A new judgment-call note documents the Alchemist Lab dependency and that it was
  found outside `Rabbit.cs` (in the per-skill `Rabbit_potion.cs`), correcting the
  prior "no usable Duration" conclusion for `miracleBlend`.
- Existing `medicalEnhancement` note gets a short addendum pointing at the new `dep`
  field in the tool's data as the place this relationship is now encoded structurally,
  not just described in prose.

## Scope

This build wires up only Rabbit's two confirmed families (5 skills total: Immune
Shot, Boost Shot, Heat Shot, Life Shot, Miracle Blend). The `dep` field and rendering
logic are generic — any future class's skill can opt in the same way once traced,
without further infrastructure work. Other classes are out of scope for this change;
the user has more candidates to point out in a follow-up session.

## Addendum (same day): `dep.kind` — a second dependency shape (Wolf Perseverance)

The user's next pointer — Wolf's `perseverance1`/`2` extending the duration of *all*
Wolf buff skills by 30%/50% — turned out to be a structurally different relationship
than Rabbit's, requiring a schema extension rather than just new data.

**What's different.** Rabbit's `medicalEnhancement`/`alchemistLab` change the *raw*
seconds fed into `chaAdjust` (a pre-wrap additive step). Wolf's Perseverance instead
multiplies the *already-`chaAdjust`-wrapped* integer, using `Mathf.FloorToInt`, not
`chaAdjust`'s own `Ceil` — verified at `CharacterControl.cs:13379-13419`, inside
`RPC_AddStatus` itself (not `Wolf.cs` — same "verified in a different file" pattern as
Alchemist Lab). It's also class-wide rather than tied to specific named skills: it
applies to any status `StatusData.isBuffStatus()` classifies as a buff, which covers
all five of Wolf's current Duration-bearing skills (`braveSpirit`, `darkEdge`,
`lunarEclipse`, `holySword`, `holyArmor`), confirmed individually against
`StatusData.cs:6323-7171`.

**Schema.** `dep` gains an optional `kind` field, `"preAdd"` (default, unchanged
Rabbit behavior) or `"postMultiply"`:

```js
dep:{ id:"perseverance", label:"Perseverance", icon:"wolf_perseverance2",
      minRank:0, maxRank:2, kind:"postMultiply", multipliers:[1, 1.3, 1.5] }
```

`multipliers` is an explicit per-rank lookup array rather than a `perRank` formula,
because the real relationship isn't linear through rank 0 — the multiplier block in
`CharacterControl.cs` is skipped entirely (i.e. exactly ×1) when Perseverance isn't
learned, then jumps to `1.1 + 0.2*rank` at rank 1+. An explicit array avoids baking
that discontinuity into a formula.

**Render logic change.** For `kind:"postMultiply"`, the raw pre-`chaAdjust` value
stays fixed at `selected.duration` regardless of the selected rank (Perseverance
doesn't touch it), so the "base Xs" line is unaffected by the rank stepper — unlike
Rabbit's `preAdd` deps, where "base" already moves with rank. Only the final
`chaAdjust`-wrapped range gets an extra `Math.floor(v * multipliers[rank])` step per
side of the range, after `chaAdjustRange` runs.

**Data change.** `braveSpirit`, `darkEdge`, `lunarEclipse`, `holySword`, `holyArmor`
in the Wolf `SKILLS` entries each get the same `dep` object (a single shared JS
constant referenced by all five, not five copies — since the relationship is
genuinely class-wide, unlike Rabbit's per-family objects). `wolf-skill-cooldown-
reference.md` gets a new judgment-call note plus a one-line addendum on each of the
five Duration citations.
