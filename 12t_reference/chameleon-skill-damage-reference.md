# Chameleon — Skill Damage/KO/Rank Reference

Companion to `chameleon-skill-reference.md` (Cooldown/Duration, cite that for CD/Duration citations —
not re-derived here). Written 2026-08-21, the 3rd class (after Penguin, Mole) to get the full rank-
selector/Damage-Formula/KO/`lckProc` treatment this tool now supports for every chip it has. Sourced
from a `mechanics-researcher` sweep of `Chameleon.cs`/`ChameleonSkill.cs`/`Chameleon_nAttack.cs`/
`Chameleon_campFire.cs`/`Chameleon_needlePrison.cs`/`CharacterControl.cs`; every citation below traces
back to that sweep.

## Summary table

| Skill | Max Rank | Cost (Base) | dmg shape | KO | Hit count | Dep mechanism | lckProc |
|---|---|---|---|---|---|---|---|
| immunity | 2 | [3, 5] MP | none (buff) | — | — | — | — |
| skinShift | 1 | 10 MP, 10 SP (red) | none (self-cost only) | — | — | shares Immunity's own cooldown key | — |
| quickFire | 4 | [12, 16, 20, 24] SP (blue) | 3-phase `dmgGroups`: open/close flat `0.25×ATK`, burst `0.25→0.35×ATK` w/ Added Fire | 0 | `2+2×rank` base, `2+4×rank` w/ Added Fire | `addedFire5` (hasSkill 402): both the burst coefficient bump AND hit-count doubling modeled (rank+dep-aware `dmgGroups` group values, new engine capability this pass) | — |
| perfectBlend | 2 | 12 MP, [8, 14] SP (red) | none (buff) | — | — | — | — |
| trueInvisibility | 2 | 12 MP, [14, 20] SP (red) | none (buff) | — | — | — | — |
| needlePrison | 2 | [14, 20] SP (red) | none (CC) | — | — | — | — |
| massShot | 2 | [10, 15] SP (red) | `0.5×ATK + talAdjust(sLv×8+8)` | 1 | 1 (AoE) | `massHouseLock5` (422) ×1.5 mult | — |
| poisonVolley | 2 | [6, 12] MP, [12, 24] SP (red) | flat `0.5×ATK` | 1 | 1 (cone AoE) | — | — |
| venomShock | 2 | [12, 24] MP, [24, 36] SP (red) | 100%/150% of "remaining poison" (rank 1/2), state-contingent | 0 | 1 | scales w/ live poison stack | — |
| massInvisibility | 2 | [28, 38] MP | none (buff) | — | — | — | — |
| finalEntrapment | 2 | [20, 30] MP, [35, 45] SP (red) | none (CC prop) | — | — | — | — |
| tormentRain | 1 | 15 MP, 15 SP (red) | `0.5×ATK + talAdjust(60)` | 1 | 1 (AoE) | — | — |
| fatalStrike | 4 | [6, 8, 10, 12] MP, [6, 8, 10, 12] SP (blue) | none of its own (buffs normal attack `+6×lv`) | n/a | — | `extraArrows5`(403): +1 lv, +5 stacks — not modeled (no chip to attach to) | — |
| leftStride | 2 | 4 MP, 12 SP (red) | none of its own — "5 Normal Attack Arrows" (3 at rank 1), plain-worded dmgNote | 1 | n/a (dmgNote only, no dmg/sim chip by design) | `doubleStrider5`(423) doubles to 10 (6 at rank 1) — stated in dmgNote, not a live toggle | — |
| rightStride | 2 | [4, 8] MP, [12, 24] SP (red) | flat `0.4×ATK`, piercing raycast | 2 | `rank×2+1` volleys | `doubleStrider5`(423) doubles volley count | — |
| campFire | 2 | [10, 15] MP, 24 SP (red) | none (heal) | — | — | — | — |
| bloodBurn | 2 | [12, 18] MP, 24 SP (red) | none (self HP-cost→heal) | — | — | — | — |
| slayer | 4 | 12 MP, 24 SP (red) | `(0.3+0.15×impSlayerLv)×ATK + talAdjust(20+10×impSlayerLv)`, flat w.r.t. own rank | 5 | 1/target | Improved Slayer dmg-side effect modeled (rank-aware `atkCoeff`/`dmg`, linked to existing Cast Time toggle) | — |
| allSlayer | 4 | 24 MP, 36 SP (red) | `(0.6+0.3×impSlayerLv)×ATK + talAdjust(20+20×impSlayerLv)`, flat w.r.t. own rank | 5 | n/a (target cap not modeled) | same as slayer | — |
| allSlain | 2 | [32, 45] MP, [45, 60] SP (red) | `talAdjust(sLv×100)` | 0 | variable/uncapped (dmgNote only) | fed by nearly every other damage skill's hit history | — |
| rustyDecay | 1 | 24 MP, 30 SP (red) | 150% of "remaining rust" (always, only 1 rank), state-contingent | 0 | 1 | requires prior normal-attack rust stack | — |
| tent | 1 | 40 MP, 30 SP (red) | none (self status) | — | — | — | — |
| markOfSlayer | 1 | 45 MP, 45 SP (red) | none directly (enables slayer/allSlayer race-bypass) | — | — | — | — |
| zeroShot | 1 | 30 MP, 30 SP (red) | `3×ATK + talAdjust(100)` | 10 | 1 | — | — |
| thunderDragon | 1 | Free / 0 | flat `50`/tick self-AoE, **real effect damage** (`RPC_AddEffectDamage`, ignores defense, floors hitMod) + separate flat-350 reflect, not merged | 0 | 6 | — | **12% paralyze/tick, caster-LCK only, unconditional** |

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

## Follow-up, 2026-08-21: Venom Shock/Rusty Decay reworded to "100%/150% of remaining X"

User asked for a simple explanation of Venom Shock's formula, then pointed out the cleaner framing
directly: "100% of remaining poison / 150% of remaining poison / 100% of remaining rust / 150% of
remaining rust." Verified this is exactly equivalent to the original formula, not an approximation:
defining "remaining poison" = `ceil(0.25×(poisonLv×10−1)×remaining seconds)` (folding the constant
`0.25` into the definition), Venom Shock's own per-rank coefficient `0.5×sLv+0.5` simplifies to exactly
`1.0`/`1.5` at rank 1/2 — a clean 100%/150% multiplier on that base, confirmed in Node. Same reframing
for Rusty Decay ("remaining rust" = `ceil(0.25×rustLv×15×remaining seconds)`) — user then caught their
own initial phrasing implied a 100%/150% pair for Rusty Decay too and corrected it: Rusty Decay only has
1 real learnable rank (re-confirmed via `ChameleonSkill.cs` — only `chm_rustyDecay5` exists, no
`chm_rustyDecay1`), and its own internal status level is hardcoded to `2` (not the skill's own rank),
which lands it permanently on the 150% case — there's no reachable 100% version of Rusty Decay. Both
`dmg` fields reworded to lead with the percentage framing, `dmgNote` keeps the underlying formula for
citation purposes.

### Follow-up, 2026-08-21: Venom Shock/Rusty Decay's `dmg` text shortened to a literal percentage, and `dmg` gained per-rank array support

User: "venomShock and rustyDecay damage formulas are still long, replace them with literally / XXX% of
remaining poison/rust damage." Since both skills render via the tool's 3rd (opaque-prose) `dmg` shape —
literal text with only `sLv`/`depLv` token substitution, never arithmetic evaluation — getting Venom
Shock's own rank-dependent 100%/150% split to display correctly per rank (not a static sentence covering
both) needed a small, generalized engine extension rather than a compromise: `skill.dmg` may now
optionally be a per-rank array, resolved via the SAME `resolveRank(value, rank)` helper `cd`/`castTime`/
`duration` already use (`getDmgText(skill, rank)`, `index.html`, added right after `resolveRank`'s own
definition). Every direct `.dmg` text consumer (`resolveHitDmgText`'s fallback — gained a 3rd `rank`
parameter, `renderDmgFormula`, `renderHero`'s `talMatchCalc`/`flatComputableCalc`/`dmgCalcRange`/the
`dmgReplaceDep` LCK branch) now routes through `getDmgText` first, so nothing downstream needs to know or
care whether a given skill's `dmg` is a flat string or a per-rank array — the exact same "resolve once,
right before the value is used" principle already established for the other 3 rank-varying fields.

- `venomShock`'s `dmg` is now `["100% of remaining poison damage", "150% of remaining poison damage"]` —
  genuinely dynamic per the rank selector, not a two-value sentence. The dropped "Deals 0 if the target has
  no active poison" caveat was folded into `dmgNote` instead (now leads with it) rather than lost.
- `rustyDecay`'s `dmg` is now the flat string `"150% of remaining rust damage"` (no array needed — only 1
  real rank, always the 150% case, matching this doc's own already-verified finding above). Same
  "0 if no active rust" caveat folded into `dmgNote`.
- Every underlying formula citation (`CharacterControl.cs:36976-37030` / `:37192`, the `0.25×(...)×seconds`
  base, the `0.5×sLv+0.5` coefficient) is unchanged and still lives in each skill's own `dmgNote` — only the
  `dmg` chip's own headline text got shorter; nothing about the verified mechanic changed.

**Separately, same session: a real UI gap found via the user asking "leftStride wording fix is not here in
the latest artifact?"** — the artifact WAS fully current (independently verified byte-exact against the
local file via a fresh `WebFetch`, including the exact `leftStride` `dmgNote` text), but Left Stride's
`dmgNote` had genuinely never had anywhere to render: `dmgNote` only ever displayed via the Damage Formula
chip's click-to-open info icon (`.sk-dmg-info`), and Left Stride has no `dmg` field at all (its damage
routes through the untracked shared normal-attack formula) — only a standalone KO chip, which never had an
info icon wired to it. Same gap exists for Fatal Strike and Mark of Slayer (`dmgNote` set, no `dmg` AND no
`ko`, so previously not even a KO chip to nest under — a fully blank `.sk-dmg-row`). Fixed generally, not
Chameleon-specifically, in `index.html`'s `renderHero()`: the standalone-KO branch now renders the same
`.sk-dmg-info`/`.sk-dmg-info-pop` markup the Damage Formula chip already uses, and a new minimal "Note"-only
chip renders for the fully-blank case when `dmgNote` is the only thing a skill has. Safe to reuse the
existing single-instance `.sk-dmg-info` toggle listener/`positionDmgInfoPopup` wiring unchanged — `dmgBlock`
only ever renders ONE of its 4 branches (dmg / shield / KO-standalone / note-only) per skill, so at most one
`.sk-dmg-info` instance ever exists in the DOM at a time regardless of which branch produced it.

Verified: JS syntax (`new Function` over the full script block) clean, CSS comment-strip + brace-balance
check clean, no remaining raw `.dmg` string-method call site left unguarded (`grep`-checked). **Not yet
visually verified live** — no browser tool available this session; check Venom Shock's rank 1↔2 toggle
actually swaps the displayed percentage, and that Left Stride's new info icon opens/positions correctly
(same gutter-popup mechanism as the Damage Formula chip's), before treating this as fully done.

### Follow-up, immediately after: the standalone KO chip removed entirely — Left Stride was its only user

User: "remove the KO chip, it is useless, check if it appears elsewhere" — the standalone `.sk-ko-standalone`
chip (for a skill with a real KO value but no Damage Formula), not the small `.sk-ko-badge` nested inside
the Damage Formula chip (kept, e.g. Mega Punch/Mega Hammer/Absolute Zero). Audited via a full `SKILLS`
array parse (bracket-depth walker, not a line-based grep) before removing anything: exactly **one** skill
across all 12 classes ever reached the standalone branch — Chameleon's Left Stride — since every other
`ko`-bearing skill also carries a `dmg` field (even `dmg:"0"`), routing it through the badge instead.
Removed the `else if (koVal){...}` branch in `renderHero()` entirely; Left Stride's `ko:"1"` data field
stays (a real, cited fact — its own `dmgNote` already explains "KO alone is the normal-attack's own flat 1
per arrow"), it's just no longer surfaced as a numeric chip. Left Stride now falls through to the
note-only branch (added the same session, just above) instead, so its `dmgNote` still displays via the
info icon — the citation isn't lost, only the standalone "KO 1" number is gone. Cleaned up the now-dead
`.sk-ko-standalone-toggles` CSS rule and its stale comment (`getKOValue`/`koDep`/`koMultDep` are all still
live, just only reachable via the nested badge path now). Verified: JS syntax clean, CSS comment-strip +
brace-balance check clean, grepped for zero dangling `koVal`/`koToggles`/`sk-ko-standalone-toggles`
references outside the still-live `.sk-ko-badge` block.

### Follow-up, immediately after: Left Stride gets a real Damage Formula chip instead of the note-only chip

User, reacting to a screenshot of the note-only chip: "Is it so hard to remove this shit and put a proper
damage formula chip here / 3 normal attack arrows for level 1 / 5 normal attack arrows for level 2 /
double the count for the related skillDep." Left Stride's own arrow count (not a damage NUMBER, since each
arrow still uses the untracked shared normal-attack formula) is itself rank- and dep-dependent text — a
genuinely new shape, since the existing per-rank-array `dmg` extension (Venom Shock/Rusty Decay, above)
only varies by rank, not by a dep too.

**New capability, not a one-off**: `skill.dmg` may now ALSO be a function `(rank, depLv) => string` —
same `(rank, depLv)` calling convention `resolveAtkCoeff` already uses for a function-shaped `atkCoeff`
(Slayer/All Slayer's Improved Slayer pilot, earlier this file), reading the same `skill.dmgRankDep`
reference. `getDmgText` (the resolver added for the array case) now checks `typeof skill.dmg ===
"function"` first, before falling back to `resolveRank` for the array/flat-string cases.

Left Stride: `dmg:(rank,depLv)=>{ const base = rank===1?3:5; return `${depLv?base*2:base} Normal Attack
Arrows`; }`, `dmgRankDep:CHAMELEON_DOUBLESTRIDER_DEP` — the SAME dep object Right Stride's own
`hitCountDep` already references (`Chameleon.cs:27058` citation unchanged from the original note), so the
corner toggle this automatically wires up (`renderHero`'s existing `selected.dmgRankDep ?
renderDmgRankToggle(...)` line, no changes needed there) shares live state with Right Stride's — toggling
either updates both, same linked-toggle precedent used throughout this file. Verified in Node: rank
1/dep-off → "3 Normal Attack Arrows", rank 2/dep-off → "5", rank 1/dep-on → "6", rank 2/dep-on → "10" —
exact match to the user's spec and the original citation's 3/5/6/10 figures.

Left Stride now renders through the normal `if (selected.dmg)` branch like every other damage skill —
real Damage Formula chip, `.sk-ko-badge` showing "KO 1" nested in its corner (previously the flat KO badge
never rendered for this skill at all, since it never had a real `dmg` field to nest under). Raw/Final
Damage/Simulate all correctly stay absent — the resolved text is opaque prose (contains letters), so it
fails both the `talAdjust(...)` and pure-arithmetic regex checks the same as Venom Shock/Rusty Decay,
matching the user's own earlier instruction on this exact skill ("no raw / dmg sim needed").

Verified: JS syntax clean, CSS comment-strip + brace-balance check clean, Node-verified the 4 output
values above match exactly.

### Follow-up, immediately after: 2 more user-reported issues from the same screenshot round

**1. The note-only chip is gone entirely, tool-wide, not just for Fatal Strike.** User: "remove this kind
of off on every skill card, a blank chip with only note icon, disgusting" — a flat rejection of the
minimal note-only chip added a few passes above, not a request to scope it down. Removed `renderHero()`'s
`else if (selected.dmgNote){...}` branch outright; any skill with neither a real Damage Formula nor a
shield now renders the plain blank `.sk-dmg-row` again (same as every buff/heal/summon already did before
that branch existed). `dmgNote` text for skills like Fatal Strike/Mark of Slayer stays in the data as a
citation, just isn't surfaced by any chip — matching how every OTHER un-chipped `dmgNote` in this file
already worked before this detour. Also cleaned up the now-fully-dead `.sk-ko-standalone` CSS rule (its
last real consumer, the note-only chip, is gone) and rewrote the stale comment block explaining both
removals.

**2. Left Stride's own new Double Strider toggle icon was broken (a placeholder image), caught live via a
screenshot.** Root cause: I'd wired Left Stride's `dmgRankDep` toggle through `renderDmgRankToggle` (used
for a TRUE multi-rank cycle, e.g. Improved Slayer's 0-4) instead of `renderDmgToggle` (a plain 0/1 toggle
that reads `dep.icon` directly). `renderDmgRankToggle`'s own icon-key logic strips the dep icon's trailing
digit and appends `1..maxRank` — for `CHAMELEON_DOUBLESTRIDER_DEP` (`icon:"chameleon_doubleStrider5",
minRank:0, maxRank:1`) that computes `"chameleon_doubleStrider1"` at BOTH rank 0 and rank 1, a key that
never existed in `SKILL_ICONS` (the only real embedded icon is `chameleon_doubleStrider5`, the Class-C-tier
suffix, not a rank digit) — `SKILL_ICONS["chameleon_doubleStrider1"]` is `undefined`, hence the broken
`<img src="undefined">`. Confirmed the icon itself was never the problem (`Buffer.compare` against the real
source PNG — byte-exact, per the user's own correction not to bother re-extracting it). Fixed by branching
the `dmgRankDep` toggle render in `renderHero`'s `dmgToggles` array on `dep.maxRank - dep.minRank > 1` —
`renderDmgRankToggle` only for a genuine multi-rank cycle, `renderDmgToggle` otherwise — matching exactly
how Right Stride's own `hitCountDep` already renders this SAME dep object correctly one line above. Node-
verified the branch condition routes Double Strider (0-1) to `renderDmgToggle` and Improved Slayer (0-4)
to `renderDmgRankToggle`, unaffected.

Verified: JS syntax clean, CSS comment-strip + brace-balance check clean, grepped for zero remaining
`sk-ko-standalone` references outside its own removal-explaining comment.

### Follow-up, 2026-08-21: Thunder Dragon is real effect damage — new `effectDamage` pipeline shape, purple font/digits, and the paralyze-chance LCK question answered

User: "Thunder Dragon Fix — 1. The damage is effect damage, please use purple font for the damage formula
chip, and use purple in game font for damage sim, ignore defense, not the usual pipeline. 2. Check if you
can calculate paralyze chance without considering the target LCK stat."

**Re-read `Chameleon.cs:38380-38470` directly (the tick loop) to verify, not assume from the existing
citation.** Confirmed: the damage call is `this.$hitChar$23117.RPC_AddEffectDamage(444, 50, 0, 0,
Vector3.zero, ...)` (`:38453`) — the literal `50` is passed straight in with no `dmgAdjust`/`defAdjust`
wrapper anywhere in the calling coroutine, and the paralyze-chance roll two lines later
(`this.$self_$23135.mChar.lckAdjust(12) > Random.Range(0,100)`, `:38459`) reads `lckAdjust` off
`$self_$23135.mChar` — the CASTER, not the hit target. `Damage.getDebuff(3, casterCha, targetCha)` on the
next line is a separate, already-excluded mechanic (the paralysis DURATION, CHA-contested, applied to the
target — matches this doc's own standing "enemy-applied debuff" exclusion rule, not the proc chance).

**Then read `RPC_AddEffectDamage` itself start-to-finish** (`CharacterControl.cs:6058-6209`, ~150 lines of
per-class guard checks — Panda's rollAround reflect, Monkey's fireAvatar/earthForm KO-nullify, none
applicable to Chameleon) to find its actual mitigation step, not just confirm "no defAdjust call" via a
grep (this file's own standing lesson: read to the function's real end before concluding what it computes).
Found exactly ONE line that touches `nDamage`: `nDamage = Mathf.FloorToInt(Mathf.Clamp(this.hitMod,0,3) *
nDamage)` (`:6203`) — **FloorToInt, not CeilToInt** (matches this doc's own earlier note about
`RPC_AddEffectDamage` using Floor where `RPC_AddDamage`/`hit()` use Ceil, now actually acted on for the
first time). No `dmgAdjust` call, no `defAdjust` call anywhere in the function. **Conclusion: Thunder
Dragon's real damage has ZERO stat-driven RNG variance** — the only thing that can move it off exactly 50
is a target-side `hitMod`-affecting buff/debuff (this tool's existing Mods popup: `reduce`/`miracleDrop`/
`amplifyDamage`), a deterministic multiplier, not a probability roll.

**Answer to question 2, directly**: yes — the paralyze chance genuinely never considers the target's LCK
at all, confirmed by the source line above (`lckAdjust(12)` on the caster only). The tool's own EXISTING
`lckProc` implementation (`lckAdjustChance(lp.chance, LCK)` in the render path, `rollLckProc` in the
Simulate path — both checked directly) already only ever reads the tool's single global `LCK` input
(modeled as the caster's stat, same as every other `lckProc` skill) and never references `selectedEnemy`
or any target field — so no code change was needed for this half of the request, just confirmation.

**New `effectDamage:true` flag** (Thunder Dragon's `SKILLS` entry) — a 4th pipeline shape alongside
`penetrating`/`dmgAdjustSkip`, grouped with `penetrating` in the "skip both dmgAdjust and defAdjust
entirely" branch (`rollOneHit` and `renderHero`'s `finalRangeForRange`, both updated identically) since the
mitigation-skip itself is the same — the only NEW behavior is the hitMod rounding direction, via a new
`hitModAdjustFloor(nDamage, hitMod)` function (mirrors `hitModAdjust` exactly, `Math.floor` instead of
`Math.ceil`), selected via `selected.effectDamage ? hitModAdjustFloor : hitModAdjust` at both call sites.
Verified in Node the two functions genuinely diverge at a fractional `hitMod` (1.75 × 50 → 88 ceil vs. 87
floor), not just a theoretical distinction.

**Purple font.** Thunder Dragon's `dmg:"50"` renders through `renderOneDmgFormula`'s flat-arithmetic
branch, whose base-value item previously always got `cls:"dmg-num"` (plain `--text` color, no term
coloring — matches this tool's own documented "flat shape has no color breakdown" rule for every OTHER
flat skill). Added a new `cls: skill.effectDamage ? "dmg-effect" : "dmg-num"` branch feeding the exact same
`buildFormulaGrid` item shape, plus a new `.dmg-effect{color:var(--stat-effect); font-weight:700}` CSS rule
and a new `--stat-effect` token (light `#7c3aed`, dark `#c084fc`) defined alongside the existing
`--stat-atk`/`--stat-tal`/`--stat-int` term-coloring tokens (all 3 theme blocks — light `:root`, the
`prefers-color-scheme:dark` media query, and the explicit `[data-theme="dark"]` override). Scoped
narrowly to the Damage Formula chip's own number, per the user's literal ask — Raw Damage/Final Damage's
range text is untouched (still gold), since neither was named in the request.

**Purple in-game digits.** `renderDamageDigits(n, color, size)` already accepted a `color` parameter, and
the purple `dmgdigit_p0`-`dmgdigit_p9` textures were already sitting in `SKILL_ICONS` — extracted back
during the original Penguin Final Damage pipeline work (2026-08-16) for exactly this eventuality, but never
actually called by any skill until now (verified all 10 are present and structurally valid PNGs before
trusting the docs' own claim they were "ready"). Both `revealMultiHit` call sites (`renderDamageDigits(hit
.value, "w"/"p", ...)`, per-hit and cumulative-total) now compute `digitColor = selected.effectDamage ? "p"
: "w"` once and use it for both — white stays the default for every other skill, unchanged.

`dmgNote` rewritten to cite the new findings directly (`RPC_AddEffectDamage`/`RPC_AddDamage` line numbers,
the no-defAdjust/no-dmgAdjust confirmation, the FloorToInt hitMod, the caster-only paralyze roll).

Verified: JS syntax clean, CSS comment-strip + brace-balance check clean, Node-verified the floor/ceil
hitMod divergence and confirmed no residual `.dmg-num`/white-digit path is reachable for this skill.

### Follow-up, immediately after: the multi-hit Simulate proc label was hardcoded to "frost" tool-wide

User: "in the damage sim, when paralyze procc, it shows frost, such as beginner mistake :(" — a real, valid
catch. `revealMultiHit`'s `procLabel` (`index.html`) had hardcoded the literal text `"frost"` since the
`lckProc` Simulate-integration pass (2026-08-20), reasoned as safe at the time because only Arctic Wind/
Ice Shield/Tornado (all genuinely frost) had a `dmg` field + `lckProc` combo able to reach that code path.
That reasoning broke the instant Thunder Dragon (this same day, above) became the first non-frost
`lckProc` skill with a real `dmg` field — its own proc genuinely applies `"paralysis"`, not frost, so its
Simulate popup was showing the wrong status name on every successful roll.

Fixed generally, not skill-specifically: every `lckProc` object now carries a new `applies` field (the
literal in-game status name the proc actually inflicts) — `"frost"` for Arctic Wind/Ice Shield/Tornado,
`"paralysis"` for Thunder Dragon, `"multicast"` for Double Cast (harmless to set even though Double Cast
has no `dmg` field and can never actually reach this code path — consistency, not dead weight).
`procLabel` now reads `selected.lckProc.applies` at render time instead of a literal, falling back to the
generic `"proc"` only if a future `lckProc` skill forgets to set it. Also renamed the CSS class itself
(`.sk-multihit-frost` → `.sk-multihit-proc`) — a class name that only ever meant "frost" was part of the
same mistake, not just the text inside it.

Verified: JS syntax clean, CSS comment-strip + brace-balance check clean, confirmed all 5 real `lckProc`
entries carry a correct `applies` value via a Node scan (Paralyze Chance→paralysis, Multicast Chance→
multicast, the 3 Frost Chance entries→frost), and zero remaining `sk-multihit-frost` references outside
the rename's own explanatory comment.

### Follow-up, immediately after: paralysis proc label recolored yellow

User: "paralysis yellow font color please." New `--stat-paralysis` token (light `#ca8a04`, dark
`#facc15`) added to all 3 theme blocks alongside the existing `--stat-*` family. `procLabel` (`revealMultiHit`)
now adds a 2nd, `applies`-keyed class (`sk-multihit-proc-${procApplies}`) alongside the base
`.sk-multihit-proc`; a new `.sk-multihit-proc-paralysis{color:var(--stat-paralysis)}` rule overrides the
base blue for a paralysis proc specifically (same specificity, wins on source order — verified the
override rule is declared after the base rule in the stylesheet). Frost/multicast keep the existing blue,
unchanged, since neither was named in the request.

Verified: JS syntax clean, CSS comment-strip + brace-balance check clean, confirmed cascade order
programmatically (override rule's string index > base rule's).

## Open items / could not verify

None outstanding — every one of the 24 active skills was checked for damage/KO/hit-count/dep/lckProc and
reported above, either with a real citation or a confirmed "no damage" finding.

See `player-reference-tool/CLAUDE.md`'s own dated section for the full implementation narrative
(engine reuse, icon extraction, verification detail).
