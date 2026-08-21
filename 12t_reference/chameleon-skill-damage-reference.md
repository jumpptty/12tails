# Chameleon — Skill Damage/KO/Rank Reference

Companion to `chameleon-skill-reference.md` (Cooldown/Duration, cite that for CD/Duration citations —
not re-derived here). Written 2026-08-21, the 3rd class (after Penguin, Mole) to get the full rank-
selector/Damage-Formula/KO/`lckProc` treatment this tool now supports for every chip it has. Sourced
from a `mechanics-researcher` sweep of `Chameleon.cs`/`ChameleonSkill.cs`/`Chameleon_nAttack.cs`/
`Chameleon_campFire.cs`/`Chameleon_needlePrison.cs`/`CharacterControl.cs`; every citation below traces
back to that sweep.

## Summary table

| Skill | Max Rank | dmg shape | KO | Hit count | Dep mechanism | lckProc |
|---|---|---|---|---|---|---|
| immunity | 2 | none (buff) | — | — | — | — |
| skinShift | 1 | none (self-cost only) | — | — | shares Immunity's own cooldown key | — |
| quickFire | 4 | 3-phase `dmgGroups`: open/close flat `0.25×ATK`, burst `0.25→0.35×ATK` w/ Added Fire | 0 | `2+2×rank` base, `2+4×rank` w/ Added Fire | `addedFire5` (hasSkill 402): both the burst coefficient bump AND hit-count doubling modeled (rank+dep-aware `dmgGroups` group values, new engine capability this pass) | — |
| perfectBlend | 2 | none (buff) | — | — | — | — |
| trueInvisibility | 2 | none (buff) | — | — | — | — |
| needlePrison | 2 | none (CC) | — | — | — | — |
| massShot | 2 | `0.5×ATK + talAdjust(sLv×8+8)` | 1 | 1 (AoE) | `massHouseLock5` (422) ×1.5 mult | — |
| poisonVolley | 2 | flat `0.5×ATK` | 1 | 1 (cone AoE) | — | — |
| venomShock | 2 | opaque, state-contingent poison detonation | 0 | 1 | scales w/ live poison stack | — |
| massInvisibility | 2 | none (buff) | — | — | — | — |
| finalEntrapment | 2 | none (CC prop) | — | — | — | — |
| tormentRain | 1 | `0.5×ATK + talAdjust(60)` | 1 | 1 (AoE) | — | — |
| fatalStrike | 4 | none of its own (buffs normal attack `+6×lv`) | n/a | — | `extraArrows5`(403): +1 lv, +5 stacks — not modeled (no chip to attach to) | — |
| leftStride | 2 | none of its own (fires normal-attack shots) | 1 | n/a (dmgNote only) | `doubleStrider5`(423) doubles shots — not modeled (no dmg field) | — |
| rightStride | 2 | flat `0.4×ATK`, piercing raycast | 2 | `rank×2+1` volleys | `doubleStrider5`(423) doubles volley count | — |
| campFire | 2 | none (heal) | — | — | — | — |
| bloodBurn | 2 | none (self HP-cost→heal) | — | — | — | — |
| slayer | 4 | `(0.3+0.15×impSlayerLv)×ATK + talAdjust(20+10×impSlayerLv)`, flat w.r.t. own rank | 5 | 1/target | Improved Slayer dmg-side effect modeled (rank-aware `atkCoeff`/`dmg`, linked to existing Cast Time toggle) | — |
| allSlayer | 4 | `(0.6+0.3×impSlayerLv)×ATK + talAdjust(20+20×impSlayerLv)`, flat w.r.t. own rank | 5 | n/a (target cap not modeled) | same as slayer | — |
| allSlain | 2 | `talAdjust(sLv×100)` | 0 | variable/uncapped (dmgNote only) | fed by nearly every other damage skill's hit history | — |
| rustyDecay | 1 | opaque, state-contingent rust detonation | 0 | 1 | requires prior normal-attack rust stack | — |
| tent | 1 | none (self status) | — | — | — | — |
| markOfSlayer | 1 | none directly (enables slayer/allSlayer race-bypass) | — | — | — | — |
| zeroShot | 1 | `3×ATK + talAdjust(100)` | 10 | 1 | — | — |
| thunderDragon | 1 | flat `50`/tick self-AoE (+ separate flat-350 reflect, not merged) | 0 | 6 | — | **12% paralyze/tick, unconditional** |

## Notable findings

- **`slayer`/`allSlayer`'s real formula does not scale with the skill's own rank at all** — confirmed by
  reading `Chameleon.cs:31488`/`:33249` directly: both formulas are driven entirely by the separate
  Improved Slayer passive's own rank (`improvedSlayerLv`), not by `sLv`. The skill's own "rank" (1-4)
  instead selects which enemy type (Bug→Tail→Elemental→Machine) the ×2 race bonus applies to — a genuinely
  different meaning of "rank" than every other skill in this tool.
- **UPDATE, 2026-08-21 same day**: Improved Slayer's real damage-side effect IS now modeled, at the user's
  explicit request ("Slayer and AllSlayer damage formula should have ImprovedSlayer skillDep too"). Needed
  a new engine capability, since it changes the `atkCoeff`/`talAdjust`-base coefficients THEMSELVES (not
  an additive term the existing `dmgDep` could append): `skill.atkCoeff` may now optionally be a function
  `(rank, depLv) => number`, and `skill.dmg` text may contain a 2nd substitution token (`depLv`, alongside
  the existing `sLv`) resolved via a new `skill.dmgRankDep` field — a skill-level generalization of the
  per-group function support added for Quick Fire earlier this pass, applied here at the whole-skill
  level since neither skill uses `dmgGroups`. `dmgRankDep` deliberately reuses the SAME `id:"improvedSlayer"`
  as both skills' existing `castDep`, so the new Damage Formula corner toggle and the existing Cast Time
  one share live state — toggling either updates both. Verified in Node: `slayer` at Improved Slayer 0/4 →
  101/303 (ATK 100, TAL 128); `allSlayer` at 0/4 → 131/536, both matching the source formula by hand.
- **Icon fix, a genuinely new shape**: `slayer`/`allSlayer`'s real per-rank icon files are named by ENEMY
  TYPE, not by a plain rank digit (`bugSlayer{0-4}.png`, `tailSlayer{0-4}.png`,
  `elementalSlayer{0-4}.png`, `machineSlayer{0-4}.png` for slayer; `allBugSlayer1.png`/`allTailSlayer2.png`/
  `allElementalSlayer3.png`/`allMachineSlayer4.png` for allSlayer, one file per tier). Re-keyed under the
  tool's normal `chameleon_slayer1-4`/`chameleon_allSlayer1-4` convention at extraction time (rank1↔bug,
  rank2↔tail, rank3↔elemental, rank4↔machine — matching each tier's own unlock progression), so the
  existing generic rank-cycle icon logic works unchanged without needing an engine change.
- **5 more mislabeled icon keys found, same family as the Penguin/Mole/King-Kaiser precedent**: `tent`,
  `markOfSlayer`, `zeroShot`, `thunderDragon`, `rustyDecay` (all Max Rank 1) previously pointed at a
  nonexistent `...1`-suffix icon file; the real files are all suffix `5`. Fixed.
- **`venomShock`/`rustyDecay` are a genuinely new damage shape for this tool**: neither skill's own cast
  deals damage directly — each applies a status (poison/rust), and the REAL damage fires later, inside
  `CharacterControl.cs`'s own `addStatus` dispatch, the instant that skill's SECOND status (venomShock/
  rustyDecay itself) lands on a target already carrying the FIRST status (poison/rust). Both formulas scale
  with the existing stack's own level and remaining duration — genuinely state-contingent, same opaque-text
  bucket as Penguin's `novaFlare`, not reducible to a clean formula independent of live combat state.
- **`quickFire`'s Added Fire passive (`addedFire5`) changes BOTH a coefficient and the hit count on one
  `dmgGroups` phase only** — first modeled with only the hit-count doubling reflected (the coefficient
  bump flagged in `dmgNote` but not computed), then corrected same-day after the user asked directly why
  it wasn't reflected. Required a real, generalized engine extension: a `dmgGroups` group's `atkCoeff`/
  `hitCount` fields can now each optionally be a function `(rank, depOn) => value` instead of a static
  number (mirroring the skill-level `hitCount(rank, dmgDepOn, hitCountDepOn)` convention exactly), read
  via 2 new small resolver functions (`resolveGroupAtkCoeff`/`resolveGroupHitCount`) that every existing
  `dmgGroups` read site (8 total across `resolveHitDmgText`/`resolveHitAtkCoeff`/`renderDmgFormula`/Raw
  Damage/Final Damage/the total-hits label) now goes through — fully backward compatible, a group with a
  plain number behaves identically to before (King Kaiser's Normal Attack, Napalm, unaffected). A real
  correctness trap caught and fixed along the way: the group-walk logic that finds which formula/coefficient
  a given hit index belongs to (`idx -= g.hitCount`) would have misrouted hits to the wrong group if the
  burst group's hit count had stayed fixed at its toggle-ON maximum while the toggle was actually off — the
  closing shot's real (smaller) index would still have landed "inside" the burst group's now-too-generous
  static bound. Verified in Node: rank 4 with Added Fire on → 18 total hits, burst coefficient 0.35;
  Added Fire off → 10 total hits, burst coefficient 0.25, and the group boundary correctly shrinks (hit
  index 9 routes to the closing shot, not a phantom extra burst hit).
- **`fatalStrike`/`leftStride` deal no damage of their own** — both buff/drive the shared normal-attack
  formula (`Chameleon_nAttack.cs:502`), which this tool has never modeled as its own tracked mechanic for
  any class. `leftStride` still gets a standalone KO chip (flat 1, from the normal-attack path) since KO
  doesn't require a `dmg` field the way the Damage Formula/Raw Damage/Final Damage chips do; `fatalStrike`
  gets neither (no direct hit call at all, its effect is entirely a buff on OTHER attacks).
- **`allSlain` and `thunderDragon`'s reflect component are both real damage this tool's `hitCount`
  mechanism can't cleanly express** — `allSlain`'s hit count depends on live combat history (how many
  distinct enemies were recently damaged by ANY of this Chameleon's skills), not a fixed function of rank;
  `thunderDragon`'s reflect fires on an unpredictable number of incoming hits, not a caster-side loop.
  Both flagged via `dmgNote` rather than forcing a numeric `hitCount` that would misrepresent them.

## Follow-up, 2026-08-21: Immunity/Skin Shift split into 2 real skill cards, per-rank Duration bug fixed

User: "Immunity Skill card max at rank 2, and remove mention of skinshift, it deserves its own skill
card." The original cooldown-reference doc had combined `chm_immunity1`/`chm_immunity2` (the 2 real
Immunity ranks) with the Class-C `chm_skinShift5` entry into one Max-Rank-3 row, following this doc
family's own "shares one cType, combine into one row" precedent — reasonable at the cooldown/duration
level (both share the exact same `"immunity"` cooldown key and Skin Shift applies no duration of its
own), but not right once Damage/KO fields entered the picture: Skin Shift is a genuinely distinct cast
(its own `req level 70` unlock, own SP/MP cost, own self-damage mechanic, own icon) that happens to share
a cooldown lock with Immunity, matching the same "materially different mechanics, own row even with a
shared cType" precedent already established elsewhere in this tool (Whale's flyingShield/homingShield,
Panda's Tiger Toss family).

`chameleon_immunity` reverted to Max Rank 2 (`chm_immunity1`/`chm_immunity2` only), name back to plain
"Immunity", icon back to the real rank-2 art. New `chameleon_skinShift` entry (Max Rank 1, same shared
cooldown, own icon) — no `dmg`/`ko` fields (its only combat-adjacent effect is self-damage, `ceil(0.1×
current hp)`, `Chameleon.cs:35229`, same "self-cost, not damage dealt" treatment as Blood Burn earlier in
this same pass), fully explained via `dmgNote` instead: costs 10% current HP to re-level whatever
Immunity status is already active, grants no fresh Immunity of its own.

**Real bug found and fixed in the same pass**: Perfect Blend's and True Invisibility's `duration` fields
were still flat numbers (matching only rank 2's own value) despite both formulas genuinely scaling with
rank (`2×sLv` and `4+4×sLv` respectively) — cycling either skill's rank selector had no effect on the
displayed Duration at all. Converted both to per-rank arrays (`duration:[2,4]` / `duration:[8,12]`).
Verified in Node that the existing per-rank-array-resolution and Erase-Senses-dep mechanisms already
compose correctly with no further engine changes needed (`resolveRank` picks the right array element
before the dep applies on top): Perfect Blend rank 1/2 × Erase Senses off/on → 2/6/4/8; True Invisibility
rank 1/2 × off/on → 8/12/12/16, all matching the source formulas by hand.

## Follow-up, 2026-08-21: same per-rank Duration bug found on Mass Invisibility/Final Entrapment too

User: "fix mass invis and final entrpment durations on skill rank too" — same class of bug as Perfect
Blend/True Invisibility, caught by the user a 2nd time rather than swept for proactively the first time.
Re-verified both directly: `massInvisibility` (`Chameleon.cs:24575`) — `chaAdjust(4×sLv+4)`, no passive
gate → 8/12 at rank 1/2. `finalEntrapment` (`Chameleon.cs:24999`) — `floor(chaAdjust(2×sLv+3))` → 5/7 at
rank 1/2. Both converted from a flat number (matching only rank 2) to a per-rank array
(`duration:[8,12]`/`duration:[5,7]`).

**Swept the rest of Chameleon's Duration-bearing skills for the same bug while at it** (should have been
done the first time this bug was found, not just fixed reactively skill-by-skill): re-read Immunity's
(`Chameleon.cs:18876`) and Fatal Strike's (`Chameleon.cs:26313`) own `RPC_AddStatus` calls directly —
both confirmed genuinely flat, `sLv` only affects the STATUS LEVEL argument (2nd param) in both, the
DURATION argument (3rd param) is a literal `chaAdjust(12)` in both cases, not `sLv`-dependent at all. No
fix needed for either. Camp Fire's own duration (`chaAdjust(30)`, a spawned-prop lifetime not
`RPC_AddStatus`) was already confirmed flat in the original cooldown-reference doc's own citation.
Every Chameleon skill with a Duration field is now confirmed either correctly flat or correctly
per-rank-array — no more instances of this bug remain in this class's roster.

## Follow-up, 2026-08-21: Skin Shift's placement in the skill order fixed, its 120s CD re-verified

User: "Skin Shift placement in the order is off, it should be so much later in the order" + "check too if
it really has the same 120s base CD." Both checked directly rather than assumed.

**CD re-verified real**: `Chameleon.cs:34978`, inside `$RPC_skinShift$23027`'s own class body (line range
34709-35336), calls `addTimeOut("immunity", agiAdjust(120))` — the identical literal `120` and the same
`"immunity"` cooldown-lock key as Immunity's own cast site (`Chameleon.cs:19009`). Confirmed by reading
the actual coroutine body, not re-citing the earlier pass's own note.

**Ordering fixed via real `setReq` (level requirement) data**, not a guess: Skin Shift requires level 70
(`ChameleonSkill.cs:1136`, `setReq(70, 3)`) — confirmed against several anchor points elsewhere in the
roster (Immunity rank 1 = level 6, All Slain rank 2 = level 55, Rusty Decay/Tent/Zero Shot = level 75,
Mark of Slayer/Thunder Dragon = level 85), all read directly rather than trusted from a wide/unreliable
forward-scan (an initial broad search past 40 lines routinely grabbed a SIBLING skill's `setReq` instead
of the target's own, due to the fallthrough control-flow shape already documented elsewhere in this repo —
a tight ~15-line window immediately after each skill's own `skillname ==` check was reliable). Moved from
right after Immunity (2nd in the list, where it landed purely because it shared Immunity's own cooldown
key) to between All Slain and Rusty Decay — the correct spot between the "normal" 2-rank skill cluster
(≤55) and the level-75+ standalone high-tier cluster.

## Follow-up, 2026-08-21: Erase Senses wired up as a real Duration dep on Perfect Blend/True Invisibility

User asked directly whether `eraseSenses5` (hasSkill 412) affects `perfectBlend`/`trueInvisibility`'s
Duration — re-verified against source (not just trusted the existing `chameleon-skill-reference.md`
citation): confirmed real for both. `Chameleon.cs:20687` — `perfectBlend`'s raw duration is
`2×sLv + (hasSkill(412) ? 4 : 0)`; `Chameleon.cs:21155` — `trueInvisibility`'s is
`4 + 4×sLv + (hasSkill(412) ? 4 : 0)`. Both a flat `+4` to the raw value, gated on the same passive.
`massInvisibility` (the 3rd invisibility-family skill) double-checked and confirmed genuinely unaffected —
its own `RPC_AddStatus("invisible", ...)` call site (`Chameleon.cs:24575`) has no `hasSkill(412)` check
at all.

Neither skill had this modeled as an interactive dep before — both just showed the no-passive value with
no toggle. Added `dep:{id:"eraseSenses", perRank:4, minRank:0, maxRank:1}` to both (same standard
additive-`perRank` shape already used elsewhere in this tool, e.g. Rabbit's Alchemist Lab), icon extracted
and byte-verified. Per this tool's standing "assume the passive is learned" default, both skills' shown
Duration changes from the base value to the with-passive one by default (Perfect Blend 4s→8s, True
Invisibility 12s→16s at max rank) — a real, correct behavior change, not a regression.

## Open items / could not verify

None outstanding — every one of the 24 active skills was checked for damage/KO/hit-count/dep/lckProc and
reported above, either with a real citation or a confirmed "no damage" finding.

See `player-reference-tool/CLAUDE.md`'s own dated section for the full implementation narrative
(engine reuse, icon extraction, verification detail).
