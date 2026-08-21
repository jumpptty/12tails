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
| immunity | 3 | none (buff) | — | — | — | — |
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
| slayer | 4 | flat `talAdjust(20)` (real formula also scales w/ Improved Slayer, not modeled) | 5 | 1/target | Improved Slayer dmg-side effect NOT modeled (only Cast Time side is) | — |
| allSlayer | 4 | flat `talAdjust(20)` (same caveat) | 5 | n/a (target cap not modeled) | same as slayer | — |
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
  different meaning of "rank" than every other skill in this tool. Modeled as a FLAT `dmg` (`talAdjust(20)`
  for slayer, `talAdjust(20)` for allSlayer, i.e. Improved Slayer at rank 0), with a `dmgNote` explicitly
  flagging both the flat-regardless-of-rank behavior and Improved Slayer's real, un-modeled bonus
  (`+0.15×ATK/+10` per rank for slayer, `+0.3×ATK/+20` per rank for allSlayer) — chosen over attempting to
  dynamically model it because the existing `dmgDep` engine only supports appending an additive term, not
  changing the `atkCoeff`/`talAdjust`-base coefficients themselves, which is what this passive actually
  does. A future pass could build that mechanism if warranted.
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

## Open items / could not verify

None outstanding from this pass — every one of the 24 active skills was checked for damage/KO/hit-count/
dep/lckProc and reported above, either with a real citation or a confirmed "no damage" finding.

See `player-reference-tool/CLAUDE.md`'s own dated section for the full implementation narrative
(engine reuse, icon extraction, verification detail).
