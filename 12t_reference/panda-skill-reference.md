# Panda — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.
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
  `crumblingMountain`), remain without a table row — both are confirmed damage-only passives with **no `addTimeOut`
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
  flat `damageMod − 0.1` regardless of rank: a **damage-dealt decrease**, so the tooltip's "decrease" is
  right. **Corrected 2026-09-23:** this note used to say `+= 0.1` (an increase), citing `CharacterControl.cs:15790`,
  but that line is inside `removeStatus` (`:14452`) and only undoes the effect. The apply site is
  `self_.damageMod = self_.damageMod - 0.1f;` in the `$addStatus$35621` coroutine (`CharacterControl.cs:35393`).
  Evasion (`lckAdjust(5*statusLv)`, `CharacterControl.cs:3076-3079`) is the only value
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
- **Confirmed-passive Class-C (Lv.5) skills have no row in this table** (no cooldown, `mode =
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
  either to the 12 support skills, to the passive skills documented above, or to an unrelated
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

---

# Damage & Mechanics

### Three Steps (`panda_threeSteps`)

- **Class / Category:** Panda (Basic Combat Tree, Skill IDs: #201, #202)
- **Ranks:** 2 (`maxRank: 2`)
- **Requirements & Resource Type:**
  - Rank 1: `reqLv: 3`, `reqBn: 0`, `MP: 0`, `SP: 12` (SP threshold requirement gate: positive integer in `PandaSkill.cs:214`, meaning >=12 SP required to initiate, but consumes 0 SP).
  - Rank 2: `reqLv: 9`, `reqBn: 1`, `MP: 0`, `SP: 15` (SP threshold requirement gate: positive integer in `PandaSkill.cs:2067`, meaning >=15 SP required to initiate, consumes 0 SP).
- **Cooldown & Timing:**
  - Base Cooldown: `30s` (scaled via `agiAdjust(30f)`, `Panda.cs:21519`).
  - Cast Time: `0s` (Instant cast).
  - Duration: `—` (no status applied).
- **Execution Lifecycle & Hit Geometry:**
  - Coroutine: `$RPC_threeStep$25233` (`Panda.cs:20835-21805`).
  - Movement & Timing:
    - Step 1: Dash forward at `moveSpeed = 4f` for `0.3s`, hits forward box (`1m * rangeMod` W x `1m * rangeMod` H x `1m * rangeMod` L, `2m * rangeMod` forward distance, `Panda.cs:20938`), yields `0.1s` + `0.2s` transition.
    - Step 2: Hit check at forward position, yields `0.1s`.
    - Step 3: Dash forward at `moveSpeed = 5f` for `0.4s`, yields `0.1s` prep, hits forward box, yields `0.1s` recovery.
  - Resource Generation: `mChar.sp = mChar.sp + 1` (+1 SP per target hit on each step, `Panda.cs:20999`, `:21181`, `:21395`).
  - KO: `1` per step hit (`Panda.cs:20966`, `:21148`, `:21362`).
- **Damage Formula & Scaling:**
  - Base Step Formula:
    `hitDmg = int(0.4 * (ATK + getFocusedArtDmg()) + talAdjust(3 * sLv))` (`Panda.cs:20943`, `:21113`, `:21327`).
  - **Focused Art Interaction (`Panda.cs:10841`):**
    `getFocusedArtDmg() = 0.5 * SP * getFocusedArtLv()` (where `SP` is the character's current SP pool, and `focusedArtLv` is 1 or 2).
    Expanded outside ATK bracket: `0.4 * ATK + talAdjust(3 * sLv) + 0.2 * SP * focusedArtLv`.
  - **Nine Steps Multiplier Hook (`Panda.cs:21124`, `:21338`):**
    `if (getNineStepsLv() > 0) hitDmg *= 1 + hitCount;`
    When Nine Steps (#402) is active, successful hits increment `hitCount`, scaling subsequent steps:
    - Step 1: `hitCount == 0` -> Multiplier = `1x`
    - Step 2: `hitCount == 1` (if Step 1 hit) -> Multiplier = `2x` (`0.8 * ATK + talAdjust(6 * sLv) + 0.4 * SP * focusedArtLv`)
    - Step 3: `hitCount == 2` (if Steps 1 & 2 hit) -> Multiplier = `3x` (`1.2 * ATK + talAdjust(9 * sLv) + 0.6 * SP * focusedArtLv`)
    - Total sequence damage: `1x + 2x + 3x = 6x` (versus `3x` without Nine Steps).




### Shadow Fist (`panda_shadowFist`, skill IDs #331–#334)

- **Ranks / requirements:** four passive ranks with no MP or SP cost: R1 Lv. 9 / Bn. 3, R2 Lv. 15 / Bn. 5, R3 Lv. 21 / Bn. 7, R4 Lv. 27 / Bn. 9 (`PandaSkill.cs:733-768`, `:1614-1638`; decoded `pnd_shadowFist1`–`4`). `getShadowFistLv()` resolves the highest learned ID 331/332/333/334 to levels 1/2/3/4 (`Panda.cs:9144-9192`).
- **Effect Damage:** after a successful eligible base hit, `ShadowFist(target)` checks that the target is a living `CharacterControl`, then calls `RPC_AddEffectDamage(433, nShadowDamage, ...)` (`Panda.cs:35783-35821`). The separate hit is **Effect Damage**, not ATK/TAL damage and does not enter the ordinary defense damage formula. Its amount is `3 * ShadowFistRank`: 3 / 6 / 9 / 12.
- **Spirit Fist interaction:** with Spirit Fist (#433), Shadow Fist adds `floor(0.16 * PandaLevel)` to that Effect Damage before the `RPC_AddEffectDamage` call (`Panda.cs:35804-35821`). This is a flat addition after rank damage, not a 16% multiplier.
- **Trigger rule:** it is not a random proc. A skill must successfully connect and explicitly start `ShadowFist(target)`; examples include normal-attack hit paths (`Panda.cs:15397-15407`, `:15582-15592`) and Sage-skill hit paths such as Water Monkey (`Panda.cs:33043-33086`), Water Crane (`:33905-33958`), Wind & Cloud, Rain & Storm, Lotus Palm, and Heaven Palm. If Shadow Fist is unlearned, the coroutine exits before making the Effect Damage call (`Panda.cs:35834-35855`).
- **Duration / cooldown:** none; this is an immediate passive follow-up, not a status or cast.

### Spirit Fist (`panda_spiritFist`, skill ID #433)

- **Passive / requirement:** single-rank Class-C passive, Lv. 75 / Bn. 4, no MP or SP cost (`PandaSkill.cs:1275-1296`; decoded `pnd_spiritFist5`).
- **Shadow Fist bonus:** adds `floor(0.16 * PandaLevel)` Effect Damage to each Shadow Fist follow-up (`Panda.cs:35804-35821`).
- **Sage range bonus:** the code reads `hasSkill(433)` as 0/1 and adds it directly to the affected target-finder dimension, giving a genuine +1m before `rangeMod`: Water Monkey's three 2m rectangle dimensions (`Panda.cs:32900-33020`); Water Crane's 4m radius (`:33539`, `:33884-33886`); Stasis Blow and Death Blow's 1m/4m rectangle dimensions (`:34298-34312`, `:35114-35128`); Wind & Cloud (`:36768`); Rain & Storm's 5m radius (`:38381-38390`); and Heaven Palm's target radius (`:39821-39826`, `:40077`). It does not alter their base damage coefficients.
- **Duration / cooldown:** none; all changes are passive and read at the affected cast's execution time.

### Drunken Fist (`panda_drunkenFist`, skill IDs #301/#302)

- **Ranks, requirements, and resource gate:** Rank 1 costs 4 MP and needs 10 SP (Lv. 3 / Bn. 0); Rank 2 costs 6 MP and needs 12 SP (Lv. 9 / Bn. 1). `setMPSP(4, 10)` / `setMPSP(6, 12)` (`PandaSkill.cs:593`, `:1765`): the positive SP is an initiation threshold (blue), not SP spent. Instant, enemy-targeted, `cType = "drunkenFist"` (`:1770-1780`).
- **Cooldown:** `addTimeOut("drunkenFist", agiAdjust(30f))` (`Panda.cs:32458`).
- **Sequence:** four hits from the `$RPC_drunkenFist$25474` state machine. Cast at t=0, then hits at 0.2s (state 2), 0.5s (state 3), 0.7s (state 5) and 0.86s (state 6), and the move ends at 1.2s (state 7) (`Panda.cs:32611-32636` yields). Each hit state first checks `myCommand == "drunkenFist"`, so an interrupted cast skips the remaining hits. Hit detection runs only on the owner (`if (!isMine) goto ...`, `:31712`).
- **Area:** every hit uses `Damage.FindRecTarget(pos, forward, 1×rangeMod, 1×rangeMod, 1×rangeMod, 2×rangeMod)` (`:31718`, `:31940`, `:32115`, `:32263`): a 2m wide × 1m deep × 2m high box in front. Spirit Fist does not change it (no `hasSkill(433)` term).
- **Damage:** action ID `300 + sLv`, KO 1, truncated with `(int)`:
  - Hit 1: `0.4×ATK + talAdjust(3 + 3×sLv)` (`:31741`)
  - Hits 2-4: `0.4×ATK + talAdjust(3×sLv)` (`:31963`, `:32138`, `:32286`)

  So Rank 1 is `talAdjust(6)` then 3× `talAdjust(3)`, and Rank 2 is `talAdjust(9)` then 3× `talAdjust(6)`. No `getFocusedArtDmg()`. The tooltips say 3 hits ("3x3 dmg" / "6x3 dmg", `PandaSkill_eng.cs:554`, `:565`; TH `PandaSkill_thai.cs:576`, `:587`). The code does 4.
- **On each successful hit:** +1 SP to the Panda and `ShadowFist(target)` (`:31774-31779` and the matching lines of the other three hits).
- **Drunken Plus (#303/#304, `getDrunkenPlusLv()` 0/1/2, `Panda.cs:9011-9014`):** at cast start, before hit 1, the Panda gets the self status `drunken` at level = Drunken Plus rank for `chaAdjust(12)` (`:32576-32591`). `drunken` (code 305, Buff + Physical, `StatusData.cs:822`, `:5379`, `:6578`) does `damageMod −0.1` (`CharacterControl.cs:35393`, reversed in `removeStatus` at `:15790`). `damageMod` is read by the shared `hit()` for **every** direct hit the Panda lands (`CharacterControl.cs:3531`, `:3540`), so all Panda direct damage, including Drunken Fist's own 4 hits, is ×0.9 while it lasts. Shadow Fist's Effect Damage (`RPC_AddEffectDamage`) is not affected. The status also gives evasion `Random(0,100) < lckAdjust(5 × level)` against incoming hits (`CharacterControl.cs:3076-3079`). **Evasion scope:** the roll exists only inside the attacker's `hit()` (`:2807`) and is the only `drunken` read in the engine besides apply/remove. A dodge sends `RPC_AddDamage(-82, ...)` (shown in game as **EVADE**, not MISS) and makes `hit()` return 0 (`:3636-3637`), so the attacker's on-hit follow-ups gated on `hit() != 0` (SP gain, Shadow Fist, on-hit statuses) are skipped as well. It covers every direct hit routed through `hit()`, from players, monsters or summons alike. It does **not** cover damage that skips `hit()`: Effect Damage (`RPC_AddEffectDamage`, e.g. Shadow Fist, Bat Mirage Orb, Rabbit Acidic Field, and every Wolf normal attack made while Wolf has the `darkEdge` status, `Wolf.cs:15267` etc., see `wolf-skill-reference.md`), status ticks and status-triggered damage in `StatusUpdate` (`CharacterControl.cs:8832-10634`), projectiles that call `RPC_AddDamage` themselves (Mole missile `Mole_missile.cs:369`, Barrel Bot missile `BarrelBot_missile.cs:369`, Gallon Bot missile, and monster projectiles such as `NinjaBug_shuriken_shuriken.cs:256` and `WormBug_poisonSpit.cs:292`), pet damage (`Panda.cs` `PetUpdate`, `:12681+`), or damage passed on inside `RPC_AddDamage` itself (`:4994`, `:5531`, `:5661`). The class files contain further direct `RPC_AddDamage` calls that were not classified one by one. Recasting refreshes the duration without stacking (Mechanics Reference §4.2.1: same caster, same level).
- **Drunken Spin (#403, `getDrunkenSpinLv()` 0/1, `Panda.cs:9707-9710`):** each hit applies `drunk` (level 1) to a target that does not already have it: `Damage.getDebuff(12, cha, targetCha)` on hit 1 (`:31817`), `getDebuff(6, ...)` on hits 2-4 (`:32039`, `:32214`, `:32362`). `drunk` (code 308, Debuff + Physical, `StatusData.cs:855`, `:5391`, `:7346`) has no stat effect on apply (`CharacterControl.cs:35531`). It reverses movement input in the player hero controllers (`vector *= -1` when `hasStatus("drunk")`, e.g. `Panda.cs:1468`; the same check exists in all 12 hero class files plus BisonCult/PandaCult), so it only matters against players. Otherwise Drunken Spin only swaps the cast effect to `drunkenSpin` (`:31621-31653`).
- **⚠️ Tooltip vs code:** both tooltips say Drunken Spin adds +6 damage to Drunken Fist (`PandaSkill_eng.cs:994`, `PandaSkill_thai.cs:1016`). None of the four hit expressions reads `getDrunkenSpinLv()`, so the +6 is not in the client code. Not live-tested.

### Water Monkey (`panda_waterMonkey`, skill IDs #311/#312)

- **Ranks, requirements, and resource gate:** Rank 1 requires Lv. 5 / Bn. 1 / 12 SP; Rank 2 requires Lv. 11 / Bn. 3 / 16 SP. Both are instant, enemy-targeted casts and use `setSP(...)` (a positive SP initiation threshold, not SP consumption): `PandaSkill.cs:629-645`, `:1721-1746`.
- **Cooldown and sequence:** the move sets `addTimeOut("waterMonkey", agiAdjust(30))` (`Panda.cs:33100-33118`). It executes two forward rectangular target scans, 0.7 seconds apart (`Panda.cs:32900-33020`, `:33003-33020`). `FindRecTarget` takes **base half-width, far half-width, forward depth, height** (`Damage.cs:1416-1452`), so the `2, 2, 2, 3×rangeMod` call is a 4m-wide × 2m-deep × 3m-high rectangle, not four independent dimensions. Spirit Fist changes it to `3, 3, 3, 3×rangeMod`: 6m wide × 3m deep × 3m high.
- **Damage:** every connected target hit uses action ID `310 + sLv` (311/312), KO `5 * sLv`, and
  `floor(0.5 * ATK + talAdjust(10 * sLv) * (1 + 0.5 * TimeAndTideLv))` (`Panda.cs:33043`). Rank 1/2 therefore use `talAdjust(10)` / `talAdjust(20)` before Time and Tide. The passive multiplies only the TAL-adjusted term; it does **not** scale the 0.5 ATK term. There is no `getFocusedArtDmg()` in the expression.
- **Evasion while attacking:** against incoming damage while `myCommand == "waterMonkey"`, the engine rolls `Random.Range(0,100) < lckAdjust(50 * (hasSkill(413) ? 2 : 1))` and negates the attack on success (`CharacterControl.cs:3134-3167`). Thus its base is 50%, or 100% with Time and Tide (#413), before LCK adjustment; this is defensive and is deliberately not an outgoing-damage simulation proc.
- **On successful base hits:** each target hit grants +1 SP and starts `ShadowFist(target)` (`Panda.cs:33043-33086`). Shadow Fist adds its separate Effect Damage only when learned; its normal value is `3 * ShadowFistRank`, plus `floor(0.16 * level)` with Spirit Fist (`Panda.cs:9144-9192`, `:35804-35845`).
- **Duration:** none; the two attack scans and evasive state are animation/coroutine state, not an applied status.

### Water Crane (`panda_waterCrane`, skill IDs #313/#314)

- **Ranks, requirements, and resource gate:** Rank 1 requires Lv. 17 / Bn. 5 / 14 SP; Rank 2 requires Lv. 23 / Bn. 7 / 18 SP. Both are instant, enemy-targeted casts; positive `setSP(...)` is an initiation threshold rather than an expenditure (`PandaSkill.cs:655-678`, `:1694-1719`).
- **Cooldown and pulses:** `addTimeOut("waterCrane", agiAdjust(30))` sets the 30-second pre-AGI cooldown (`Panda.cs:33645-33675`). The attack executes two area scans, separated by 0.7 seconds (`Panda.cs:33870-33905`, `:33974-33976`), centered on the Panda. Each scan has 4m radius (5m with Spirit Fist) and 5m height, all multiplied by `rangeMod` (`Panda.cs:33529-33540`, `:33884-33886`).
- **Damage:** each target caught by each pulse gets action ID `312 + sLv` (313/314), KO 1, and
  `floor(0.5 * ATK + talAdjust(10 * sLv) * (1 + 0.5 * TimeAndTideLv))` (`Panda.cs:33905`). Rank 1/2 use `talAdjust(10)` / `talAdjust(20)` before the passive. As with Water Monkey, Time and Tide scales the TAL term only and Focused Art is absent.
- **Evasion and successful-hit follow-up:** Water Crane uses the same 50% / 100%-with-Time-and-Tide LCK-adjusted defensive evasion gate as Water Monkey (`CharacterControl.cs:3134-3167`). Every successful base pulse grants +1 SP and starts `ShadowFist(target)` (`Panda.cs:33905-33958`), whose optional Effect Damage follows the same Shadow Fist / Spirit Fist rule cited above.
- **Duration:** none; the two pulses are attack sequence timing rather than a status or field duration.

### Time and Tide (`panda_timeAndTide`, skill ID #413)

- **Passive / requirement:** single-rank Class-C passive, Lv. 60 / Bn. 1, no MP or SP cost (`PandaSkill.cs:1229-1245`; decoded `pnd_timeAndTide5`). Its getter returns exactly 0 or 1 from `hasSkill(413)` (`Panda.cs:9714-9717`).
- **Water Monkey and Water Crane damage:** their hit expressions multiply the `talAdjust(10 * sLv)` result by `1 + 0.5 * getTimeAndTideLv()` (`Panda.cs:33043`, `:33905`). Learning Time and Tide makes that term 1.5x; the separate `0.5 * ATK` term remains unchanged.
- **Evasion:** it doubles the Water Monkey / Water Crane incoming-attack evasion base from 50 to 100 before `lckAdjust` (`CharacterControl.cs:3140-3161`). It is not a damage proc and does not appear in either skill's outgoing damage simulator.
- **Visual-only branch:** the casts select `timeAndTideMonkey` / `timeAndTideCrane` effects when this passive is learned (`Panda.cs:33237-33264`, `:33792-33825`); these effect assets do not add another damage instance.

### Wind & Cloud (`panda_wind&cloud`, skill IDs #351/#352)

- **Ranks, requirements, and cost:** Rank 1 requires Lv. 20 / Bn. 12 and consumes 10 MP + 20 SP; Rank 2 requires Lv. 24 / Bn. 15 and consumes 10 MP + 24 SP (`PandaSkill.cs:818-829`, `:1548-1568`). It is an instant, enemy-targeted skill.
- **Cooldown:** 120 seconds before AGI adjustment: `addTimeOut("wind&cloud", agiAdjust(120))` (`Panda.cs:37799-37802`). Revised Art applies normally.
- **Nine nearby-area strikes:** The coroutine performs nine sequential area checks. Each connecting hit uses action ID `350 + sLv` (351/352), KO 1, and raw damage
  `floor(0.4 × ATK + talAdjust(5 × sLv))` — Rank 1 uses `talAdjust(5)`, Rank 2 `talAdjust(10)` (`Panda.cs:36768-36802`, `:36895-36911`, `:37056-37072`, `:37160-37176`, `:37264-37280`, `:37368-37384`, `:37499-37515`, `:37603-37619`, `:37688-37704`).
- **Evasion during the sequence:** While `actionState == "attack"` and `myCommand` is `"windCloud"`, an incoming attack rolls `Random.Range(0,100) < lckAdjust(30)` and is negated on success (`CharacterControl.cs:3170-3203`). The displayed 30% is therefore LCK-adjusted, not a fixed chance; `lckAdjust(p) = floor(100 × p(1+0.01×LCK)/(100+0.01×p×LCK))` (`CharacterControl.cs:20658-20670`).
- **Shadow Fist interaction and SP gain:** Every successful base hit grants +1 SP and starts `ShadowFist(target)` (`Panda.cs:36797-36802`, `:36906-36911`, `:37067-37072`, `:37171-37176`, `:37275-37280`, `:37379-37384`, `:37510-37515`, `:37614-37619`, `:37699-37704` — all nine strike blocks). Shadow Fist does nothing without the passive; with it, it adds Effect Damage `3 × ShadowFistRank`, plus `floor(0.16 × character level)` when Spirit Fist (#433) is learned (`Panda.cs:9144-9192`, `:35804-35821`, `:35834-35845`). Spirit Fist also expands this skill's first area dimension from `3 × rangeMod` to `4 × rangeMod` (`Panda.cs:36768`).
- **Duration:** none — the move has no applied status or independent duration; its protected/evasive window is only the active attack sequence.

### Rain & Storm (`panda_rain&storm`, skill IDs #353/#354)

- **Ranks, requirements, and cost:** Rank 1 requires Lv. 28 / Bn. 18 and consumes 15 MP + 32 SP (`PandaSkill.cs:844-855`). Rank 2 requires Lv. 30 / Bn. 21 and consumes 15 MP + 40 SP; it is instant and enemy-targeted (`PandaSkill.cs:1521-1541`).
- **Cooldown:** 180 seconds before AGI adjustment: `addTimeOut("rain&storm", agiAdjust(180))` (`Panda.cs:38827-38830`). Revised Art applies normally.
- **Four nearby-area pulses:** The coroutine runs four area checks, each centered on the Panda, with range `(5 + SpiritFistLv) × rangeMod` and height `2 × rangeMod` (`Panda.cs:38390`, `:38482`, `:38579`, `:38671`). Each successful hit uses action ID `352 + sLv` (353/354), KO 1, and raw damage `floor(0.65 × ATK + talAdjust(15 × sLv))` (`Panda.cs:38413`, `:38505`, `:38602`, `:38694`). Rank 1 therefore uses `talAdjust(15)` and Rank 2 uses `talAdjust(30)`.
- **Evasion during the sequence:** Like Wind & Cloud, an incoming attack while `myCommand == "rainStorm"` rolls `Random.Range(0,100) < lckAdjust(30)` and is negated on success (`CharacterControl.cs:3170-3203`). This is a defensive reactive roll, not an outgoing-hit proc.
- **Shadow Fist interaction and SP gain:** Each connected base pulse grants +1 SP and starts `ShadowFist(target)` (`Panda.cs:38413-38424`, `:38505-38516`, `:38602-38613`, `:38694-38705`). Shadow Fist's Effect Damage is `3 × ShadowFistRank`, plus `floor(0.16 × character level)` with Spirit Fist (#433) (`Panda.cs:9144-9192`, `:35804-35845`). Spirit Fist also extends the base 5m area range to 6m.
- **Duration:** none — it applies no status or independent field lifetime; the evasive window only exists during the active attack sequence.

### Lotus Palm (`panda_lotusPalm`, skill IDs #361/#362)

- **Ranks, requirements, and cost:** Rank 1 requires Lv. 24 / Bn. 15 and consumes 7 MP + 30 SP (`PandaSkill.cs:870-881`). Rank 2 requires Lv. 27 / Bn. 18 and consumes 7 MP + 35 SP; it is a target-mode enemy skill (`PandaSkill.cs:1494-1514`).
- **Cooldown:** BigBug baseline is 75 seconds before AGI adjustment: `addTimeOut("lotusPalm", agiAdjust(75))` (`Panda.cs:39317-39322`). ToT changes the base cooldown to 67.5 seconds (documented below under Server Balance Variations).
- **One direct target hit:** At 1.4 seconds after the action starts, the cast checks the selected target object and hits it directly — no `FindAreaTarget` call or area pulse loop exists (`Panda.cs:39493-39528`). The raw damage is `floor(0.5 × ATK + talAdjust(10 + 20 × sLv))`, with action ID `360 + sLv` (361/362), KO 5, and a forward force vector (`Panda.cs:39528`). Rank 1 uses `talAdjust(30)`; Rank 2 uses `talAdjust(50)`.
- **No Focused Art:** The literal hit expression contains only `0.5 × ATK` and `talAdjust(10 + 20 × sLv)`; there is no `getFocusedArtDmg()` call (`Panda.cs:39528`).
- **Shadow Fist interaction and SP gain:** On a successful direct hit, Lotus Palm grants +1 SP and starts `ShadowFist(target)` (`Panda.cs:39528-39537`). Shadow Fist's Effect Damage is `3 × ShadowFistRank`, plus `floor(0.16 × character level)` with Spirit Fist (#433) (`Panda.cs:9144-9192`, `:35804-35845`).
- **Duration:** none — it applies no status or independent duration.

### Heaven Palm (`panda_heavenPalm`, skill IDs #363/#364)

- **Ranks, requirements, and cost:** Rank 1 requires Lv. 30 / Bn. 21 and consumes 23 MP + 60 SP (`PandaSkill.cs:896-907`). Rank 2 requires Lv. 33 / Bn. 24 and consumes 23 MP + 75 SP; both ranks use target-mode enemy casting (`PandaSkill.cs:1467-1487`).
- **Cooldown:** BigBug baseline is 150 seconds before AGI adjustment: `addTimeOut("heavenPalm", agiAdjust(150))` (`Panda.cs:40164-40167`). ToT changes the base cooldown to 135 seconds (documented below under Server Balance Variations).
- **Four target-area pulses:** The cast locks movement, schedules pulses at 1.2s, 1.8s, 2.2s, and 2.6s after action start (`Panda.cs:39800-39826`, `:39982-40060`). Every pulse scans around the selected impact position using range `(2 × sLv + 2 + SpiritFistLv) × rangeMod` and height `2 × rangeMod` (`Panda.cs:40077`). This is 4m / 6m base radius at ranks 1 / 2, increased to 5m / 7m with Spirit Fist (#433).
- **Damage:** Each connected target receives action ID `362 + sLv` (363/364), KO 1, and raw damage `floor(0.5 × ATK + talAdjust(15 × sLv + 10))` (`Panda.cs:40100`). Rank 1 uses `talAdjust(25)`; Rank 2 uses `talAdjust(40)`.
- **No Focused Art:** The literal hit expression contains only `0.5 × ATK` and `talAdjust(15 × sLv + 10)`; there is no `getFocusedArtDmg()` call (`Panda.cs:40100`).
- **Shadow Fist interaction and SP gain:** Each successful pulse hit grants +1 SP and starts `ShadowFist(target)` (`Panda.cs:40100-40111`). Shadow Fist's Effect Damage is `3 × ShadowFistRank`, plus `floor(0.16 × character level)` with Spirit Fist (`Panda.cs:9144-9192`, `:35804-35845`).
- **Duration:** none — the timed pulses are part of the attack animation, not a status or independent field duration.

## Server Balance Variations (ToT)

Private-server values are documented from the Bible skill-detail schema; BigBug source remains the original-server baseline.

| Skill | Original BigBug baseline | ToT delta |
|---|---|---|
| Lotus Palm | 75s base cooldown. | Base cooldown reduced to 67.5s. |
| Heaven Palm | 150s base cooldown. | Base cooldown reduced to 135s. |

Source of server deltas: `12t_projects/bible/index.html:10537-10538`.

### Rushing Falcon (`panda_rushingFalcon`)

- **Class / Category:** Panda (Basic Combat Tree, Skill IDs: #203, #204)
- **Ranks:** 2 (`maxRank: 2`)
- **Requirements & Resource Type:**
  - Rank 1: `reqLv: 15`, `reqBn: 2`, `MP: 0`, `SP: 18` (SP threshold requirement gate: positive integer in `PandaSkill.cs:238`, meaning >=18 SP required to initiate, but consumes 0 SP).
  - Rank 2: `reqLv: 21`, `reqBn: 3`, `MP: 0`, `SP: 22` (SP threshold requirement gate: positive integer in `PandaSkill.cs:2040`, meaning >=22 SP required to initiate, consumes 0 SP).
- **Cooldown & Timing:**
  - Base Cooldown: `30s` (scaled via `agiAdjust(30f)`, `Panda.cs:22587`).
  - Cast Time: `0s` (Instant cast, `skillClass.mode = eSkillMode.instant`, `PandaSkill.cs:2044`).
  - Duration: `—` (no status applied).
- **Execution Lifecycle & Hit Geometry:**
  - Coroutine: `$RPC_rushingFalcon$25258` (`Panda.cs:21885-22750`).
  - Movement & Timing:
    - Dash forward at `moveSpeed = 8f` (state 2) then `moveSpeed = 6f` (states 3, 4, 5).
    - Step 1: Hit check in rectangular box (`1.6m * rangeMod` W x `1m * rangeMod` H x `2m * rangeMod` L, forward offset `-0.5m * transform.forward`, `Panda.cs:22115`).
    - Step 2: Hit check in rectangular box (`1m * rangeMod` W x `1m * rangeMod` H x `1m * rangeMod` L, `2m * rangeMod` forward distance, `Panda.cs:22245`).
    - Step 3: Hit check in rectangular box (`1m * rangeMod` W x `1m * rangeMod` H x `1m * rangeMod` L, `2m * rangeMod` forward distance, `Panda.cs:22395`).
- **Damage Formula & Resource Generation:**
  - Base Damage per hit: `hitDmg = (int)(0.5f * ((float)mChar.atk + getFocusedArtDmg()) + talAdjust(sLv * 5))` (`Panda.cs:22120`, `:22250`, `:22400`).
    - ATK component: `0.5 * ATK`.
    - TAL component: `talAdjust(5 * sLv)` (Rank 1: base 5; Rank 2: base 10; scaling: `base + 0.02 * base * TAL`).
    - Focused Art component: `0.5 * getFocusedArtDmg() = 0.5 * (0.5 * SP * focusedArtLv) = 0.25 * SP * focusedArtLv` (`Panda.cs:10841`).
  - SP Generation: Every target connected on each hit yields `mChar.sp = mChar.sp + 1` (+1 SP per target per step hit, `Panda.cs:22164`, `:22294`, `:22444`).
  - Knockout (KO): `1` per hit (`mChar.hit(202 + sLv, hitObject, hitDmg, 1, 0, 0.5f * transform.forward)`).
- **Nine Steps Synergy (`nineSteps`, Skill #402):**
  - Hit count tracking: each connecting hit increments `hitCount++` (`Panda.cs:22180`, `:22310`, `:22460`).
  - If `getNineStepsLv() > 0`, hit damage is escalated by `hitDmg *= 1 + hitCount`:
    - Step 1: 1x damage multiplier (`hitCount = 0`).
    - Step 2: 2x damage multiplier (`hitCount = 1`).
    - Step 3: 3x damage multiplier (`hitCount = 2`).
  - All components (ATK, TAL, and Focused Art) scale proportionally with the step multiplier.


### Focused Art (`panda_focusedArt`, skills #263/#264)

- **Passive, 0 MP / 0 SP, no cooldown.** Rank 1 = Lv 30 / Bn 21, rank 2 = Lv 33 / Bn 24 (`decode_skilldata.py`; passive tail `PandaSkill.cs:1821-1839`).
- **Tooltip:** "Passively add 50% / 100% of Panda's current sp to all of its StikeMaster skills damage." (`PandaSkill_eng.cs:506-523`; Thai `PandaSkill_thai.cs:528`, `:539`).
- **Formula (`Panda.cs:8976-8985`):**
  `getFocusedArtLv() = hasSkill(264) ? 2 : (hasSkill(263) ? 1 : 0)` (rank 2 replaces rank 1, no stacking);
  `getFocusedArtDmg() = 0.5 * mChar.sp * getFocusedArtLv()`.
- **Where it applies:** the term is added *inside* the ATK bracket, `coeff * (ATK + getFocusedArtDmg()) + talAdjust(...)`, so the effective bonus per hit is `coeff * 0.5 * SP * rank` — it scales with each skill's own ATK coefficient (the tooltip's "50%/100%" is relative to that bracket, not a flat share of SP). SP is the live `mChar.sp` at the moment the hit resolves.
- **Consumers** (all `Panda.cs`; Focused Spirit is a separate passive for normal attacks, `getFocusedSpiritDmg() = 0.3*sp*lv`, `:8969`):

| Skill | Lines | Damage formula |
|---|---|---|
| Three Steps | 20943, 21113, 21327 | `0.4·(ATK+FA) + talAdjust(3·sLv)` |
| Rushing Falcon | 22107, 22245, 22395 | `0.5·(ATK+FA) + talAdjust(5·sLv)` |
| Qi Strike (`$RPC_qiStrike2`) | 23526 | `sLv·(ATK+FA)` (hit id `210+sLv`) |
| Pummel | 24770, 24788 | `0.35·(ATK+FA) + talAdjust(5·sLv+5)`; `0.25·(ATK+FA) + talAdjust(5·sLv)` |
| Tower Rush | 25429, 25442 | `0.75·(ATK+FA) + talAdjust(15·sLv+15)`; `0.5·(ATK+FA) + talAdjust(15·sLv)` |
| Tiger Toss | 26675 | `0.5·(ATK+FA) + talAdjust(15·sLv)` |
| Tiger Pounce | 26828 | `0.5·(ATK+FA) + talAdjust(weight)` |
| Climbing Cliff | 27516 | `0.3·(ATK+FA) + talAdjust(10)` |
| Crumbling Mountain | 28153 | `0.3·(ATK+FA) + talAdjust(10)` |
| Rising Vortex | 28855, 28970 | `0.5·(ATK+FA) + talAdjust(10·sLv)` |
| Rising Dragons | 29844, 30033 | `0.5·(ATK+FA) + talAdjust(40·sLv)`; `0.35·(ATK+FA) + talAdjust(5·sLv)` |

  (`FA` = `getFocusedArtDmg()`. Only Three Steps and Rushing Falcon cards are fully verified in the app so far; the rest are recorded here for their future cards.)

### Nine Steps (`panda_nineSteps`, skill #402)

- **Passive Class-C, Lv 55 / Bn 0, 0 MP / 0 SP, no cooldown** (`decode_skilldata.py`).
- **Tooltip:** "Passively increases damage of ThreeStep and RushingFalcon by the number of its own hit." (`PandaSkill_eng.cs:935-943`; Thai `PandaSkill_thai.cs:957`).
- **Hook:** `getNineStepsLv() = hasSkill(402) ? 1 : 0` (`Panda.cs:9693`); each step does `if (getNineStepsLv() > 0) hitDmg *= 1 + hitCount;` (`Panda.cs:21118-21124`, `:21332`, `:22250`, `:22400`). Steps therefore deal 100% / 200% / 300% (6× total vs 3×), scaling ATK, TAL and Focused Art terms alike.
- The `getNineStepsLv() != 0` check at `Panda.cs:21569` only chooses between the `nineStep1` / `nineStep2` voice clips (50% each) — no damage effect.
