# Panda — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.
`climbingCliff`/`crumblingMountain` added 2026-08-14 — see the Tiger Toss family judgment-call note
below for why they were initially left out and then given their own rows.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| roll | Roll | 2 | 60 | true | false | — | — |
| threeSteps | Three Steps | 2 | 30 | true | false | — | — |
| rushingFalcon | Rushing Falcon | 2 | 30 | true | false | — | — |
| qiStrike | Qi Strike | 3 | 90 | true | false | — | — |
| pummel | Pummel | 2 | 30 | true | false | — | — |
| towerRush | Tower Rush | 2 | 30 | true | false | — | — |
| tigerToss | Tiger Toss | 1 | 30 | true | false | — | — |
| climbingCliff | Climbing Cliff | 1 | 240 | true | false | 2 | false |
| crumblingMountain | Crumbling Mountain | 1 | 300 | true | false | 3 | false |
| risingVortex | Rising Vortex | 2 | 60 | true | false | — | — |
| risingDragons | Rising Dragons | 2 | 240 | true | false | — | — |
| ashura | Ashura | 2 | 300 | true | false | 24 | true |
| drunkenFist | Drunken Fist | 2 | 30 | true | false | 12 | true |
| waterMonkey | Water Monkey | 2 | 30 | true | false | — | — |
| waterCrane | Water Crane | 2 | 30 | true | false | — | — |
| stasisBlow | Stasis Blow | 2 | 30 | true | false | — | — |
| deathBlow | Death Blow | 2 | 30 | true | false | — | — |
| spTransfer | Sp Transfer | 2 | 30 | true | false | — | — |
| wind&cloud | Wind & Cloud | 2 | 120 | true | false | — | — |
| rain&storm | Rain & Storm | 2 | 180 | true | false | — | — |
| lotusPalm | Lotus Palm | 2 | 75 | true | false | — | — |
| heavenPalm | Heaven Palm | 2 | 150 | true | false | — | — |
| comboLink | Combo Link | 1 | 240 | true | false | 6 | true |
| fuujinKen | Fuujin Ken | 1 | 240 | true | false | — | — |
| raijinKen | Raijin Ken | 1 | 300 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Panda's own thematic `psalmOfEnergy`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Panda.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Panda.cs:9997`), `psalmOfEnergy`
  (`Panda.cs:10237`), `seaAegis` (`Panda.cs:10406`), `zephyrLore` (`Panda.cs:10600`), `replenishment`
  (`Panda.cs:10701`), `elementalBound` (`Panda.cs:10831`), `astralShift` (`Panda.cs:10983`),
  `bloodCarnage` (`Panda.cs:11174`), `obsidianFang` (`Panda.cs:42860`), `assassinate`
  (`Panda.cs:43316`), `mineWalker` (`Panda.cs:43695`), `divineChannel` (`Panda.cs:44071`) — all 12
  present, all bare-`600`. A direct grep of `PandaSkill.cs` for `psalmOfEnergy` (Panda's own
  thematically-named support skill) returns zero matches, confirming it isn't part of Panda's own
  learnable-skill roster (`getSkill()`). All 12 excluded.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.**
  `pnd_nAttack1`/`pnd_nAttack2` explicitly `goto IL_940` (`PandaSkill.cs:42`, `:50`) and `pnd_nAttack4`
  goes `goto IL_8AC` (`:65`), landing on `cType = "nAttack"` (`PandaSkill.cs:2216`); the live cast sites
  are `Panda.cs:7612` (`addTimeOut("nAttack", 1f)`) and the `1.5f`/`(float)1` combo-stage variants
  scattered through the file (e.g. `:15730`, `:16030`, `:19342`). `pnd_nAttack3`'s own branch
  (`PandaSkill.cs:54-60`) is empty (its guard evaluates false, no `setReq`/goto) — a dead roster entry,
  same shape as Monkey's `damageCast1`/`2` precedent — but excluded regardless per the blanket rule
  either way.
- **`mount` is not a Panda class skill — excluded, not a judgment call.** `Panda.cs:48431` —
  `this.$self_$25885.mChar.addTimeOut("mount", (float)12);` — the universal ride-a-mount action shared
  by every class. `PandaSkill.cs` has no `cType`/`getSkill()` entry for `"mount"` at all.
- **`resistance1`-`4` and `statPlus1`-`4` are confirmed passives** (status-nullify chance / flat +2-all-stats,
  `PandaSkill_eng.cs:136`, `:180`), landing on a shared `mode = eSkillMode.passive` tail
  (`resistance` → `IL_21A4`, `PandaSkill.cs:2139`; `statPlus` → `IL_1897`/`IL_2040`,
  `PandaSkill.cs:2113`/`2106`) with no `cType` and no `addTimeOut`/`RPC_<name>` anywhere in `Panda.cs`.
- **`delayQi1` is `mode = eSkillMode.passive` in `getSkill()` (`PandaSkill.cs:304`, own `break`) yet
  Panda.cs dispatches it as a real, directly-cast skill (`RPC_delayQi(vector, vector2, num2, 1/2/3)`,
  `ActionName == "RPC_delayQi1/2/3"` at `Panda.cs:2399/2411/2423`) with its own `RPC_AddStatus("delayQi",
  sLv, chaAdjust(3) + 3*getQiBurstLv(), 0, ...)` at `Panda.cs:24255` — but no `addTimeOut("delayQi", ...)`
  call exists anywhere in the file.** Matching the eng description ("hold his QiStrike and release it
  later when you press attack, max 3 sec", `PandaSkill_eng.cs:301`), this is a resource/charge-hold
  mechanic, not a cooldown-gated skill — excluded per "has a real cooldown," independent of the
  passive/active metadata mismatch.
- **`sacredSageTechnique1`/`2` (cast as `RPC_sacredSage`) land cleanly on their own dedicated passive
  tail in `getSkill()` (`setReq(28,16); mode=passive; break`, `PandaSkill.cs:1575-1585`, reached by
  natural empty-fallthrough from both ranks) — and independently, `Panda.cs`'s `RPC_sacredSage` handler
  (`Panda.cs:9211`) sets `this.mChar.sp = 0` (or `50` with the `heavenBreath5` passive, `hasSkill(404)`)
  and heals HP via `RPC_AddHeal(352+sLv, 50+50*sLv, ...)` at `Panda.cs:9429` — with no `addTimeOut` call
  anywhere in the method.** Two independent lines of evidence (clean passive metadata, and a genuinely
  cooldown-free resource-gated handler) both confirm exclusion — matching the eng description "refocus
  his over-charged sp into 100/150 hp" (`PandaSkill_eng.cs:752`, `:763`), gated by needing to rebuild SP,
  not a timer.
- **`tigerToss`/`climbingCliff`/`crumblingMountain` are three separate rows sharing one `"tigerToss"`
  cooldown-lock key (added 2026-08-14, user override — same pattern as Whale's `flyingShield`/
  `homingShield`).** An earlier pass on this doc treated `climbingCliff`/`crumblingMountain` as an
  "upgrade chain" and folded their cooldowns into a citation footnote instead of giving them rows,
  reasoning that `climbingCliff1`'s own `getSkill()` metadata falls through to a shared passive tail
  (`PandaSkill.cs:1921-1932`: `setReq(27,9); mode=passive;`, no `cType`) and `crumblingMountain1`'s own
  `getSkill()` branch is dead/unreachable code entirely. The user corrected this: a shared
  `addTimeOut` cooldown-lock string doesn't mean "not a real skill" — what matters is whether `Panda.cs`
  gives it its own live cast site, and both do: `RPC_climbingCliff` (`Panda.cs:27598` onward) and
  `RPC_crumblingMountain` (`Panda.cs:28383` onward) are both fully-functional coroutines with their own
  `myCommand` dispatch, their own hit/VFX calls, and their own in-game toast strings (`"ClimbingCliff!"`
  at `:27687`; `"Crumbling Mountain!"` at `:28279`) — genuinely separate actions that happen to reuse
  `tigerToss1`'s timer key, not variations of one cast. Each is single-rank (`getClimbingCliffLv()`/
  `getCrumblingMountainLv()`, `Panda.cs:8720`/`:8777`, both plain `hasSkill()` 0/1 checks — no
  `climbingCliff2-4`/`crumblingMountain2-4` exist). Both are also, previously unreported, `noForce`
  (knockback-immunity) self-status casters — `Panda.cs:27619` (`climbingCliff`, base `2`) and `:28404`
  (`crumblingMountain`, base `3`) — via `addStatus(sType, sLv, sTime, sValue, sID)`
  (`CharacterControl.cs:14445`), which does **no internal CHA scaling**: both durations are flat literals,
  `durWrapped:false`, unlike every other Duration in this table. Neither is exempt from revisedArt5
  (same mechanism/exemption-list check as the Whale precedent — `"tigerToss"` isn't on
  `CharacterControl.cs:20116-20226`'s exemption list). `tigerPounce` and a further passive tier surfaced
  during this research, `crushingMonolith` (`pnd_crushingMonolith5`, `rSkill=234` i.e. requires
  `crumblingMountain`), remain excluded — both are confirmed damage-only passives with **no `addTimeOut`
  of their own anywhere in the codebase** (`tigerPounce`'s bonus-hit block lives *inside*
  `$RPC_tigerToss$25362`, `tigerToss`'s own coroutine class, gated by `getTigerPounceLv()`
  (`Panda.cs:8670`, `hasSkill(232)` 0/1); `crushingMonolith` is a `crumblingMountain`-only damage/VFX
  swap gated by `hasSkill(432)` inside `crumblingMountain`'s own coroutine, `Panda.cs:28158`) — neither
  is a "skill with a cooldown" by this tool's own scope rule, so neither gets a row. The `"grab"`
  sub-action (`RPC_grab`, `Panda.cs:8656`) is the pre-toss grapple-hold applied to the target before
  TigerToss executes — no `addTimeOut` of its own and no `PandaSkill.cs` roster entry — part of the same
  family, excluded.
- **`focusedSpirit1`/`2` and `focusedArt1`/`2` are confirmed passives** ("Passively add 30%/60% of
  Panda's current sp to its normal attack's damage" / "...to all of its StikeMaster skills damage",
  `PandaSkill_eng.cs:488`, `:499`, `:510`, `:521`), landing on a shared passive tail
  (`IL_16AB` → `IL_BAD` → `IL_2F85`, `PandaSkill.cs:1821-1839`: `setReq(33,24); mode=passive; break`)
  with no `cType` and no `addTimeOut`/`RPC_<name>` anywhere in `Panda.cs`.
- **`comboPlus1`-`4` are confirmed passives** ("Temporary increases Panda's attack by 1/2/3/4 everytime
  he hits with a normal attack or a StikeMaster skill", `PandaSkill_eng.cs:400` etc.), landing on a
  shared passive tail (`IL_3461` → `IL_66D` → `IL_2E65`, `PandaSkill.cs:1895-1912`:
  `setReq(28,16); mode=passive; break`). `Panda.cs:8848` — `RPC_AddStatus("comboPlus", num, sTime, 0,
  ...)` — confirms this is an automatic on-hit proc that stacks a temporary attack buff, not a
  player-cast skill with its own cooldown.
- **`drunkenPlus1`/`2` fall through into `drunkenFist`'s own active-skill tail — a fallthrough trap, but
  one that doesn't need its own table row since the resulting `cType` string is identical to
  `drunkenFist`'s.** `drunkenFist1`, `drunkenFist2`, `drunkenPlus1`, and `drunkenPlus2` are four sibling
  branches (`PandaSkill.cs:582-627`) that are all either empty or set only `setReq`/`setMPSP` with no
  goto; whichever one matches falls through to the same terminal code
  (`PandaSkill.cs:1760-1785`: `setReq(9,1); setMPSP(6,12); mode=instant; target=enemy;
  cType="drunkenFist"; break`). For `drunkenFist1`/`2` this is correct (their own family's real active
  skill). For `drunkenPlus1`/`2` this is a decompiler artifact — their eng description ("Adds 'drunken1'/
  'drunken2' status to Drunken Fist, giving Panda and its target a 10%/20% evasion chance and damage
  decrease", `PandaSkill_eng.cs:576`, `:587`) reads as a passive modifier, not a separately-cast attack —
  confirmed by `Panda.cs:32591`, where learning drunkenPlus (`$mDrunkenPluslv$25475` from
  `getDrunkenPlusLv()`) adds a **separate** self-buff status `"drunken"` (`chaAdjust(12)`) during
  `drunkenFist`'s own cast, rather than drunkenPlus having any independent cast site of its own. No
  additional row is added for `drunkenPlus`.
- **`drunkenFist`'s Duration cell now reports this `"drunken"` self-buff's `chaAdjust(12)` — re-checked
  2026-08-14 (user request) — but it only exists at all once `drunkenPlus` (either rank) is learned; the
  value itself does not change between rank 1 and rank 2.** `Panda.cs:32576-32591`: `$mDrunkenPluslv$25475
  = getDrunkenPlusLv()` (`Panda.cs:9011-9014`: `hasSkill(304)→2, hasSkill(303)→1, else 0` —
  `PandaSkill.cs:2788-2809` confirms commandNum 303/304 = `drunkenPlus1`/`2`); `if (mDrunkenPluslv <= 0)
  goto IL_6DA` skips the whole block when drunkenPlus is unlearned — so with neither rank learned,
  `drunkenFist` has no self-buff duration at all, matching this table's own "no dep = no upgrade path"
  convention rather than a `dep`-steppable value (there's nothing to step between — it's on-at-a-flat-
  value or off, not a scaling rank). `RPC_AddStatus("drunken", mDrunkenPluslv, chaAdjust(12), 0,
  ActorNr)` — the `chaAdjust(12)` third argument (duration) is a fixed literal, not derived from
  `mDrunkenPluslv`, so rank 1 and rank 2 both give the same `12`; only the *status level* argument
  (used for evasion/damage magnitude, not duration) scales 1→2. **Also corrects the eng flavor text**
  (`PandaSkill_eng.cs:576`/`:587`, "giving Panda **and its target** a 10%/20% evasion chance and 10%/20%
  damage decrease"): `RPC_AddStatus` is only ever called on `self_.mChar` — no target-side application
  exists anywhere in the coroutine, so "and its target" is inaccurate; separately, the coded effect is a
  flat `damageMod += 0.1f` (`CharacterControl.cs:15790`, a **damage-dealt increase**, not a "decrease")
  regardless of rank, and evasion (`lckAdjust(5*statusLv)`, `CharacterControl.cs:3085`) is the only value
  that actually scales by rank (5%/10%, not the tooltip's claimed 10%/20%). This self-buff `"drunken"` is
  distinct from `"drunk"`, the CHA-contested target debuff cited in the judgment-call note below — the
  two share a name root but are separate statuses on separate characters.
- **`shadowFist1`-`4` are confirmed passives (normal-attack/SageFist extra-hit-damage proc), but rank 4
  is a genuine `getSkill()` dead-code-fallthrough trap landing on `deathBlow`'s cType — matching the
  Mole `heavyBuilt`/`speedDrill`/`skyDrill` precedent.** Ranks 1-3 explicitly `goto IL_BD1`/`IL_259D`
  (`PandaSkill.cs:742`, `:750`, `:758`) → `IL_4B0` (`:1614-1625`: `setReq(27,9); mode=passive; break`) —
  their own shared passive tail, matching the eng description ("Gives Panda's normal attack and all
  SageFist skills, a second hit with 3/6/9 effect damage", `PandaSkill_eng.cs:686` etc.).
  `shadowFist4`'s own branch (`PandaSkill.cs:762-768`) is empty with no live goto — falling through
  skips past the `IL_BD1`/`IL_259D`/`IL_4B0` labels entirely (they sit inside a sibling branch's nested
  scope, unreachable by simple fallthrough) and lands one level further out, on `deathBlow`'s own tail
  (`PandaSkill.cs:1640-1665`: `mode=target; target=enemy; cType="deathBlow"`) — despite `shadowFist4`'s
  description ("...a second hit with 12 effect damage") being just as clearly passive as ranks 1-3. No
  extra row needed since `deathBlow` is already reported.
- **`mysticSage1`/`2` are confirmed passives (double-summon damage mitigation), but their `getSkill()`
  entries are a dead-code-fallthrough trap landing on `heavenPalm`'s real active-skill tail — the
  clearest instance of the Mole-precedent bug in this file.** Both ranks (`PandaSkill.cs:922-937`) are
  empty with no goto, matching their eng description ("Passively creates a double that takes half of 100
  or more damage for Panda every 12/6 seconds", `PandaSkill_eng.cs:862`, `:873`). Because `mysticSage`'s
  own nested "else" contains only the unrelated Class-C ultimate-passive chain (`auraBlast5` through
  `raijinKen5`, terminating in a generic `setReq(40,25); mode=passive` default at
  `PandaSkill.cs:1455-1465` that is itself unreachable from a valid skillname), `mysticSage` has no
  dedicated tail of its own analogous to `sacredSageTechnique`'s clean one — falling through the whole
  chain lands one level further out, at `PandaSkill.cs:1467-1492`
  (`setReq(33,24); mode=target; target=enemy; cType="heavenPalm"`). `heavenPalm1`/`heavenPalm2`
  legitimately reach this exact same code via their own genuine empty-fallthrough (`PandaSkill.cs:896-920`,
  confirmed correct — this is simply how a family's own multi-rank shared tail is written throughout this
  file); the trap is specific to `mysticSage` accidentally borrowing it. No extra row needed; `heavenPalm`
  is reported using its own real cast site.
- **`ashuraFist` is Ashura-form's own charge-attack sub-state, not an independently learnable skill —
  excluded, same reasoning as Monkey's `blazingForm`/`sentinalGuard`.** `Panda.cs:31272` —
  `addTimeOut("ashuraFist", (float)12)` (flat, unwrapped) — is a real, working cooldown call, but a
  grep of both `PandaSkill.cs` and `PandaSkill_eng.cs` for `ashuraFist` returns zero matches: no
  `getSkill()`/`getSkillTree()` entry and no description. It's an internal state of the `ashura`
  transformation, not a roster skill.
- **Confirmed-passive Class-C (Lv.5) skills excluded from the table** (no cooldown, `mode =
  eSkillMode.passive` in `getSkill()`, no `RPC_<name>` cast handler with its own `addTimeOut` in
  `Panda.cs`): `auraBlast5` (final-combo → area attack), `auraField5` (sp-charge aura for allies),
  `superStatPlus5` (+10 all stats), `nineSteps5` (ThreeStep/RushingFalcon hit-count damage passive),
  `qiBurst5` (QiStrike line-AoE + delayQi extension passive), `ogreImpact5` (Pummel/TowerRush
  range/damage passive), `crushingMonolith5` (ClimbingCliff/CrumblingMountain height-damage passive —
  eng description keyed under the legacy name `wallCrush5`, `PandaSkill_eng.cs:972`), `drunkenSpin5`
  (adds damage + "drunk" status to DrunkenFist, see dedicated note above), `timeAndTide5`
  (WaterMonkey/WaterCrane damage+evasion passive), `windWalker5` (StasisBlow/DeathBlow warp+crit
  passive), `spiritFist5` (ShadowFist/"Sage" skill range/damage passive), `heavenBreath5`
  (SacredSage/SpTransfer scaling passive), `revisedSkill5`/`revisedMagic5`/`revisedArt5` (flat
  sp/mp/cooldown-reduction modifiers for other skills). **`safeGuard5`** is also a confirmed passive
  ("Gives Panda the ability to passively nullify one negative status every 3 minute",
  `PandaSkill_eng.cs:917`, `mode=passive` in `getSkill()`) despite having a real, working internal
  proc-recharge timer — `Panda.cs:9728` — `addTimeOut("safeGuard", agiAdjust(180f))` — this gates an
  automatic status-nullify proc, not a player-cast action, so it is excluded like Monkey's `fireKeep5`/
  `earthRune`-style internally-cooled passives, not treated as an active skill with a player-facing
  cooldown.
- **Two `RPC_AddStatus` calls inside otherwise-real active skills are excluded as incidental
  side-effects, not the skill's own reportable Duration.** `risingDragons`: `Panda.cs:29625` —
  `this.$tChar$25432.RPC_AddStatus("lock", 1, 2, 0, ...)` — a flat, unwrapped 2-second stagger applied
  only when `tChar.isMine` (a client-side hit-reaction/prediction gate, not a universal debuff) — same
  "incidental hit-stun, not the skill's own duration" reasoning as Mole's excluded `noForce` grace
  period. `deathBlow`: `Panda.cs:35211` — `this.$tChar$25554.RPC_AddStatus("death", 1, 1, 0, ...)` —
  fires only when the lck-scaled instant-kill roll succeeds (`Panda.cs:35205`:
  `lckAdjust(20*sLv) > Random(0, tChar.hp)`) — a 1-second technical status flag marking the kill, not a
  debuff duration a player experiences. Both skills report Duration `—`.
- **CHA-contested Duration exclusions, per the plan's contested-duration rule.** `drunkenFist`'s own
  `"drunk"` status is computed through `Damage.getDebuff(...)`: `Panda.cs:31817` —
  `RPC_AddStatus("drunk", 1, Damage.getDebuff((float)12, this.$self_$25490.mChar.cha,
  this.$hitChar$25478.cha), 0, ...)` (first-hit value; three further hit-instances at `:32039`,
  `:32214`, `:32362` use a base of `6`). `stasisBlow`'s `"paralysis"` status: `Panda.cs:34361` —
  `this.$mDuration$25535 = Damage.getDebuff((float)(1 + 2*sLv), this.$self_$25541.mChar.cha,
  this.$tChar$25534.cha);` — applied at `Panda.cs:34394`. Both skills report Duration `—`.
- **No `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists for**: `roll`, `threeSteps`,
  `rushingFalcon`, `qiStrike`, `pummel`, `towerRush`, `tigerToss`, `risingVortex`, `waterMonkey`,
  `waterCrane`, `spTransfer`, `wind&cloud`, `rain&storm`, `lotusPalm`, `heavenPalm`, `fuujinKen`,
  `raijinKen` — confirmed by a full-file grep of every `RPC_AddStatus`/`.addStatus(` call in `Panda.cs`
  and cross-checking each hit against these skills' own coroutine bodies; the remaining hits belong
  either to the 12 support skills, to the excluded/passive skills documented above, or to an unrelated
  shared minigame/consumable-item/flag-capture effect system (`wash`, `bless`, `ice`, `bubbleShield`,
  `iceShield`, `awareness`, `float`, `mpsap`, `burn`, `blind`, `plague`, `frost`, `redFlag`, `cleanse`,
  `blueFlag`, `whiteFlag`, `awake`, `yellowFlag`, `happy`, `charm`, `ko`, `defUp`, `heavy`, `mpDrain`,
  `hpDrain` — none tied to any `PandaSkill.cs` roster entry, matching the same generic-effects block
  documented in the Monkey doc). Duration cells for all seventeen skills listed above are `—`.

### CD citations
- `roll` CD: `Panda.cs:19955` — `addTimeOut("roll", agiAdjust((float)30))` (rank 1); max rank:
  `Panda.cs:20497` — `this.$self_$25229.mChar.addTimeOut("roll", this.$self_$25229.mChar.agiAdjust((float)60));`
- `threeSteps` CD: `Panda.cs:21519` — `this.$self_$25253.mChar.addTimeOut("threeSteps", this.$self_$25253.mChar.agiAdjust(30f));`
- `rushingFalcon` CD: `Panda.cs:22587` — `this.$self_$25274.mChar.addTimeOut("rushingFalcon", this.$self_$25274.mChar.agiAdjust(30f));`
- `qiStrike` CD: `Panda.cs:23123` — `this.$self_$25285.mChar.addTimeOut("qiStrike", this.$self_$25285.mChar.agiAdjust((float)90));` (single shared cast site for all 3 ranks; fixed literal, not rank-scaled)
- `pummel` CD: `Panda.cs:24895` — `this.$self_$25324.mChar.addTimeOut("pummel", this.$self_$25324.mChar.agiAdjust(30f));`
- `towerRush` CD: `Panda.cs:25632` — `this.$self_$25339.mChar.addTimeOut("towerRush", this.$self_$25339.mChar.agiAdjust(30f));`
- `tigerToss` CD: `Panda.cs:26950` — `this.$self_$25374.mChar.addTimeOut("tigerToss", this.$self_$25374.mChar.agiAdjust(30f));`
- `climbingCliff` CD (own cast site, shares `tigerToss`'s cooldown-lock key — see judgment-call note): `Panda.cs:27598` — `addTimeOut("tigerToss", agiAdjust((float)240))`
- `crumblingMountain` CD (own cast site, shares `tigerToss`'s cooldown-lock key — see judgment-call note): `Panda.cs:28383` — `addTimeOut("tigerToss", agiAdjust((float)300))`
- `risingVortex` CD: `Panda.cs:29127` — `this.$self_$25422.mChar.addTimeOut("risingVortex", this.$self_$25422.mChar.agiAdjust(60f));`
- `risingDragons` CD: `Panda.cs:30103` — `this.$self_$25442.mChar.addTimeOut("risingDragons", this.$self_$25442.mChar.agiAdjust(240f));`
- `ashura` CD: `Panda.cs:30659` — `this.$self_$25452.mChar.addTimeOut("ashura", this.$self_$25452.mChar.agiAdjust((float)300));`
- `drunkenFist` CD: `Panda.cs:32458` — `this.$self_$25490.mChar.addTimeOut("drunkenFist", this.$self_$25490.mChar.agiAdjust(30f));`
- `waterMonkey` CD: `Panda.cs:33109` — `this.$self_$25506.mChar.addTimeOut("waterMonkey", this.$self_$25506.mChar.agiAdjust(30f));`
- `waterCrane` CD: `Panda.cs:33660` — `this.$self_$25522.mChar.addTimeOut("waterCrane", this.$self_$25522.mChar.agiAdjust(30f));`
- `stasisBlow` CD: `Panda.cs:34603` — `this.$self_$25541.mChar.addTimeOut("stasisBlow", this.$self_$25541.mChar.agiAdjust(30f));`
- `deathBlow` CD: `Panda.cs:35421` — `this.$self_$25560.mChar.addTimeOut("deathBlow", this.$self_$25560.mChar.agiAdjust(30f));`
- `spTransfer` CD: `Panda.cs:36153` — `this.$self_$25585.mChar.addTimeOut("spTransfer", this.$self_$25585.mChar.agiAdjust(30f));`
- `wind&cloud` CD: `Panda.cs:37802` — `this.$self_$25617.mChar.addTimeOut("wind&cloud", this.$self_$25617.mChar.agiAdjust((float)120));`
- `rain&storm` CD: `Panda.cs:38830` — `this.$self_$25638.mChar.addTimeOut("rain&storm", this.$self_$25638.mChar.agiAdjust((float)180));`
- `lotusPalm` CD: `Panda.cs:39322` — `this.$self_$25651.mChar.addTimeOut("lotusPalm", this.$self_$25651.mChar.agiAdjust(75f));`
- `heavenPalm` CD: `Panda.cs:40167` — `this.$self_$25672.mChar.addTimeOut("heavenPalm", this.$self_$25672.mChar.agiAdjust(150f));`
- `comboLink` CD: `Panda.cs:40663` — `this.$self_$25683.mChar.addTimeOut("comboLink", this.$self_$25683.mChar.agiAdjust((float)240));`
- `fuujinKen` CD: `Panda.cs:41124` — `this.$self_$25701.mChar.addTimeOut("fuujinKen", this.$self_$25701.mChar.agiAdjust(240f));` (also a matching preemptive `addTimeOut` at `Panda.cs:86`)
- `raijinKen` CD: `Panda.cs:42057` — `this.$self_$25712.mChar.addTimeOut("raijinKen", this.$self_$25712.mChar.agiAdjust(300f));` (also a matching preemptive `addTimeOut` at `Panda.cs:89`)

### Duration citations
- `ashura` Duration: `Panda.cs:30572` — `this.$self_$25452.mChar.RPC_AddStatus("ashura", this.$sLv$25451, this.$self_$25452.mChar.chaAdjust(24), 0, this.$self_$25452.mChar.ActorNr);` (self, not target-contested)
- `comboLink` Duration: `Panda.cs:40570` — `this.$self_$25683.mChar.RPC_AddStatus("atkUp", 5, this.$self_$25683.mChar.chaAdjust(6), this.$nComboCount$25682, this.$self_$25683.mChar.ActorNr);` (self, not target-contested; 4th param is the combo-count stack value, not duration)
- `drunkenFist` Duration: `Panda.cs:32591` — `this.$self_$25490.mChar.RPC_AddStatus("drunken", this.$mDrunkenPluslv$25475, this.$self_$25490.mChar.chaAdjust(12), 0, this.$self_$25490.mChar.ActorNr);` (self, not target-contested — but gated entirely on `drunkenPlus` being learned; see dedicated judgment-call note above. `drunkenFist`'s *separate* `"drunk"` target debuff remains CHA-contested/excluded, see below)
- `stasisBlow`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cell is `—`
- `risingDragons`, `deathBlow`: incidental hit-reaction/proc-flag statuses (`"lock"`, `"death"`), not the skill's own duration — see judgment-call note; Duration cells are `—`
- `climbingCliff` Duration: `Panda.cs:27619` — `this.$self_$25388.mChar.StartCoroutine_Auto(this.$self_$25388.mChar.addStatus("noForce", 1, 2, 0, this.$self_$25388.mChar.ActorNr));` (self-applied knockback-immunity while climbing; `addStatus`'s `sTime` param does no internal CHA scaling — flat literal `2`, `durWrapped:false`, unlike every other Duration in this table)
- `crumblingMountain` Duration: `Panda.cs:28404` — `this.$self_$25406.mChar.StartCoroutine_Auto(this.$self_$25406.mChar.addStatus("noForce", 1, 3, 0, this.$self_$25406.mChar.ActorNr));` (same `noForce` mechanism as `climbingCliff`, flat literal `3`, `durWrapped:false`)
- `roll`, `threeSteps`, `rushingFalcon`, `qiStrike`, `pummel`, `towerRush`, `tigerToss`, `risingVortex`,
  `waterMonkey`, `waterCrane`, `spTransfer`, `wind&cloud`, `rain&storm`, `lotusPalm`, `heavenPalm`,
  `fuujinKen`, `raijinKen`: no usable Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime
  call exists in the skill's own coroutine class body; see the bulk judgment-call note above. Duration
  cells are `—`.
