# Chameleon — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| immunity | Immunity / Skin Shift | 3 | 120 | true | false | 12 | true |
| quickFire | Quick Fire | 4 | 60 | true | false | — | — |
| perfectBlend | Perfect Blend | 2 | 60 | true | false | 4 | true |
| trueInvisibility | True Invisibility | 2 | 90 | true | false | 12 | true |
| needlePrison | Needle Prison | 2 | 60 | true | false | — | — |
| massShot | Mass Shot | 2 | 30 | true | false | — | — |
| poisonVolley | Poison Volley | 2 | 60 | true | false | — | — |
| venomShock | Venom Shock | 2 | 90 | true | false | — | — |
| massInvisibility | Mass Invisibility | 2 | 300 | true | false | 12 | true |
| finalEntrapment | Final Entrapment | 2 | 300 | true | false | 7 | true |
| tormentRain | Torment Rain | 1 | 3 | true | false | — | — |
| fatalStrike | Fatal Strike | 4 | 30 | true | false | 12 | true |
| leftStride | Left Stride | 2 | 60 | true | false | — | — |
| rightStride | Right Stride | 2 | 60 | true | false | — | — |
| campFire | Camp Fire | 2 | 60 | true | false | 30 | true |
| bloodBurn | Blood Burn | 2 | 18 | true | false | — | — |
| slayer | Bug Slayer / Tail Slayer / Elemental Slayer / Machine Slayer | 4 | 90 | true | false | — | — |
| allSlayer | All Bug Slayer / All Tail Slayer / All Elemental Slayer / All Machine Slayer | 4 | 240 | true | false | — | — |
| allSlain | All Slain | 2 | 300 | true | false | — | — |
| rustyDecay | Rusty Decay | 1 | 90 | true | false | — | — |
| tent | Tent | 1 | 240 | true | false | — | — |
| markOfSlayer | Mark of Slayer | 1 | 150 | true | false | — | — |
| zeroShot | Zero Shot | 1 | 60 | true | false | — | — |
| thunderDragon | Thunder Dragon | 1 | 90 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Chameleon's own thematic `zephyrLore`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Chameleon.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Chameleon.cs:10230`), `psalmOfEnergy`
  (`Chameleon.cs:10473`), `seaAegis` (`Chameleon.cs:10642`), `zephyrLore` (`Chameleon.cs:10836`),
  `replenishment` (`Chameleon.cs:10937`), `elementalBound` (`Chameleon.cs:11067`), `astralShift`
  (`Chameleon.cs:11216`), `bloodCarnage` (`Chameleon.cs:11407`), `obsidianFang` (`Chameleon.cs:38818`),
  `assassinate` (`Chameleon.cs:39273`), `mineWalker` (`Chameleon.cs:39651`), `divineChannel`
  (`Chameleon.cs:40028`) — all 12 present, all bare-`600`. A direct grep of `ChameleonSkill.cs` for
  `zephyrLore` (Chameleon's own thematically-named support skill) and `mount` returns zero matches for
  both, confirming neither is part of Chameleon's own learnable-skill roster (`getSkill()`). All 12
  excluded from this table.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.** Both
  carry their own named cooldowns in `Chameleon.cs`: `nAttack`'s combo stages use bare (non-`agiAdjust`)
  `addTimeOut("nAttack", ...)` calls (`Chameleon.cs:15950`, `15962`, `15974`, `15986`, `15994`; an
  unrelated `addTimeOut("nAttack", 1f)` also exists at `Chameleon.cs:5970` for a different action), and
  `cAttack` carries its own bare `addTimeOut("cAttack", 1f)` (`Chameleon.cs:16673`). Both excluded from
  this table regardless, per the plan's blanket policy.
- **`mount` is not a Chameleon class skill — excluded, not a judgment call.** `Chameleon.cs:44484` —
  `this.$self_$23292.mChar.addTimeOut("mount", (float)12);` — sits inside `$RPC_useMount$23285`
  (`Chameleon.cs:44159-44586`), the universal ride-a-mount action shared by every class. `ChameleonSkill.cs`
  has no `cType`/`getSkill()` entry for `"mount"` at all (see support-skill note above), confirming it
  isn't part of Chameleon's learnable roster.
- **A generic confused-random-cast cooldown call at `Chameleon.cs:6322` is not a specific skill's own
  cooldown — excluded as noise.** `characterControl.addTimeOut(SkillData.getSkillCD((string)obj2),
  (float)30);` fires when the Chameleon itself is under the `"confuse"` status and randomly re-triggers an
  arbitrary skill from its own skill array — a shared confusion-status mechanic present identically in
  other classes' files, not a named cast site for any one skill.
- **The four "Slayer" skills (`slayer1`-`slayer4` cooldown keys) share one cast site, one command, and
  one flat cooldown — combined into a single row.** `ChameleonSkill.cs` lists four separately-learnable
  entries with distinct `cType` values but identical shape (mode=target, target=enemy): `chm_bugSlayer1`
  → `cType = "slayer1"` (`ChameleonSkill.cs:756-782`, req level 16), `chm_tailSlayer2` → `"slayer2"`
  (`ChameleonSkill.cs:789-815`, req level 20), `chm_elementalSlayer3` → `"slayer3"`
  (`ChameleonSkill.cs:822-848`, req level 24), `chm_machineSlayer4` → `"slayer4"`
  (`ChameleonSkill.cs:855-881`, req level 28) — each just adds bonus damage to a different target-type
  (plant/bug, tail, elemental, mechanical). At the source level all four route through the **same**
  `$RPC_slayer$22906` coroutine (`Chameleon.cs:30217-31274`), gated behind the single unified
  `mChar.myCommand == "slayer"` check (`Chameleon.cs:30611`, `30654`, `30778`), and set cooldown via
  `addTimeOut("slayer" + sLv, agiAdjust((float)90))` (`Chameleon.cs:30820`) — a flat `90` regardless of
  which tier's `sLv` (1-4) is passed in. This table reports it as one skill, **Max Rank 4** (count of
  learnable entries, matching the Cat doc's `heartRipper`/`finishingBlow5` precedent), with Skill ID
  `slayer` standing in for the dynamic `slayer1`-`slayer4` keys.
- **The four "All Slayer" skills follow the identical pattern — combined into a single row.**
  `chm_allBugSlayer1` → `cType = "allSlayer1"` (`ChameleonSkill.cs:926-952`, req level 24),
  `chm_allTailSlayer2` → `"allSlayer2"` (`ChameleonSkill.cs:959-985`, req level 27),
  `chm_allElementalSlayer3` → `"allSlayer3"` (`ChameleonSkill.cs:992-1018`, req level 30),
  `chm_allMachineSlayer4` → `"allSlayer4"` (`ChameleonSkill.cs:1025-1051`, req level 33) — all four route
  through `$RPC_allSlayer$22964` (`Chameleon.cs:32144-32805`), share `myCommand = "allSlayer1"`
  (`Chameleon.cs:32420`, hardcoded literal regardless of actual tier), and set cooldown via
  `addTimeOut("allSlayer" + sLv, agiAdjust((float)240))` (`Chameleon.cs:32425`) — flat `240` for all four.
  Reported as one skill, **Max Rank 4**, Skill ID `allSlayer`.
- **`immunity` and Class-C `skinShift5` share one cooldown key and one duration — combined into a single
  row, following the Cat doc's `heartRipper`/`finishingBlow5` precedent.** `chm_immunity1`
  (`ChameleonSkill.cs:98-114`, req level 6) and `chm_immunity2` (`ChameleonSkill.cs:115-131`) share
  `cType = "immunity"` (`ChameleonSkill.cs:1156` and again at `2263`, both reached via the same
  fallthrough tail). `chm_skinShift5` (`ChameleonSkill.cs:1130-1166`, req level 70) is a Class-C skill
  that also explicitly sets `cType = "immunity"` (`ChameleonSkill.cs:1156`) rather than a `skinShift`
  key of its own — its own eng description confirms this is an upgrade, not a new skill: "Removes all
  status on Chameleon in exchange for 10% of its hp. **Increases immunity status by 1 level.**"
  (`ChameleonSkill_eng.cs:906`). At the source level, `$RPC_immunity$22572` (`Chameleon.cs:18689-19240`)
  sets `addTimeOut("immunity", agiAdjust(120))` (`Chameleon.cs:19009`) and applies the actual duration
  (`Chameleon.cs:18876`, see Duration citations); `$RPC_skinShift$23027`
  (`Chameleon.cs:34709-35336`) sets the **same** `addTimeOut("immunity", agiAdjust(120))`
  (`Chameleon.cs:34978`) but contains no `RPC_AddStatus` call of its own anywhere in its class body —
  it only re-levels whatever `immunity` status is already present, it doesn't grant a fresh one. This
  table reports it as one skill, **Max Rank 3** (3 learnable entries), Skill ID `immunity`, Display Name
  "Immunity / Skin Shift", using the base `immunity1`/`immunity2` cast site's Duration value (`skinShift5`
  contributes no duration of its own).
- **`tormentRain`'s CD is a genuinely small flat value (3s), not a misread.** `Chameleon.cs:25659` —
  `addTimeOut("tormentRain", agiAdjust((float)3))` — sits in `$RPC_tormentRain$22762`
  (`Chameleon.cs:25269-25872`), the coroutine that plays the cast animation and locks `myCommand =
  "tormentRain"`; the actual arrow-rain damage application is a separate downstream coroutine,
  `$RPC_tormentRain_fire$22779` (`Chameleon.cs:25872-26159`), which has no `RPC_AddStatus`/`addTimeOut`
  of its own. `tormentRain`'s eng description ("Shoot a barrage of arrows... inside Final Entrapment's
  cage") and its high `setReq(45, 27)` req/SP cost (`ChameleonSkill.cs:549-554`) confirm it's a genuine,
  high-investment finisher skill with an intentionally short cooldown, gated by requiring an active
  `finalEntrapment` cage to be useful.
- **`fatalStrike`'s Class-C `chm_fatalStrike4` name-branch has no inline logic of its own — falls
  through to the shared tail, same as the other three ranks.** All four of `chm_fatalStrike1`
  (`ChameleonSkill.cs:578-595`), `fatalStrike2` (`596-603`), `fatalStrike3` (`604-611`), `fatalStrike4`
  (`612-618`, matched condition but empty body) resolve via `goto`/fallthrough to the same tail block
  (`ChameleonSkill.cs:1812-1838`) that sets `cType = "fatalStrike"` — confirmed **Max Rank 4**, matching
  the CD/Duration cast site (`$RPC_fatalStrike$22791`, `Chameleon.cs:26159-26607`) which reads a single
  `sLv` parameter (1-4) with a flat CD/Duration regardless of value.
- **`needlePrison`'s and `poisonVolley`'s durations are target-CHA-contested via `Damage.getDebuff` —
  excluded, Duration cells `—`.** `needlePrison`: `Chameleon.cs:21745` —
  `this.$mDuration$22648 = Damage.getDebuff((float)(1 + this.$sLv$22660), this.$self_$22661.mChar.cha,
  this.$hitChar$22647.cha) + ((!this.$hasMassHouseLock$22641) ? 0 : 2);` (the `+2` bonus is itself gated
  behind a separate passive, `massHouseLock5`, irrelevant since the base formula is contested either way),
  applied at `Chameleon.cs:21750`. `poisonVolley` (applies a `"poison"` status, not a `"poisonVolley"`
  one): `Chameleon.cs:23340` — `this.$mPoisonDuration$22704 = Damage.getDebuff((float)(8 + 2 *
  this.$mIncreasedPoisonLv$22702), this.$self_$22716.mChar.cha, this.$hitChar$22701.cha);` (the poison
  level/stack count is separately gated behind the `increasedPoison` passive; the duration formula itself
  is contested regardless), applied at `Chameleon.cs:23345`.
- **`markOfSlayer`'s `slayerMark` and `thunderDragon`'s reflect-`paralysis` procs are both
  target-CHA-contested — excluded, Duration cells `—`.** `markOfSlayer`: `Chameleon.cs:36792` —
  `this.$tChar$23076.RPC_AddStatus("slayerMark", 5, Damage.getDebuff((float)30,
  this.$self_$23078.mChar.cha, this.$tChar$23076.cha), 0, this.$self_$23078.mChar.ActorNr);`.
  `thunderDragon`: `Chameleon.cs:38465` — `this.$hitChar$23117.RPC_AddStatus("paralysis", 1,
  Damage.getDebuff((float)3, this.$self_$23135.mChar.cha, this.$hitChar$23117.cha), 0,
  this.$self_$23135.mChar.ActorNr);` — a guaranteed-damage-plus-`lckAdjust(12)`%-chance-to-paralyze
  reflect effect triggered when something attacks the Chameleon while `thunderDragon` is active
  (`Chameleon.cs:38459-38465`), inside `$RPC_thunderDragon$23108` itself.
- **`campFire` and `finalEntrapment` don't call `RPC_AddStatus` — their "duration" is a spawned
  field-effect's lifetime instead, and is reported as a genuine Duration value, following the existing
  Cat doc's precedent that a hardcoded/computed value applied outside `RPC_AddStatus` is still usable.**
  `campFire` spawns a `Chameleon_campFire` prop (a separate `MonoBehaviour`, `Chameleon_campFire.cs`, that
  periodically heals nearby sitting/sleeping allies) whose lifetime timer is set at
  `Chameleon.cs:29360` — `this.$mCampFireTimer$22881 = this.$self_$22884.mChar.chaAdjust(30);` — flat
  `chaAdjust(30)` regardless of rank, passed through `RPC_campFire_create`
  (`Chameleon.cs:9417-9455`) into `Chameleon_campFire.Init(nOwner, nTimer)`
  (`Chameleon_campFire.cs:23-48`). `finalEntrapment` spawns a "cage" VFX prop whose lifetime is set at
  `Chameleon.cs:24999` — `this.$mDuration$22755 =
  Mathf.FloorToInt((float)this.$self_$22758.mChar.chaAdjust(2 * this.$sLv$22757 + 3));` (at max rank
  `sLv=2`: `chaAdjust(7)`, matching the eng text's "(7 sec)" for `finalEntrapment2`) — passed to
  `RPC_finalEntrapment_hit` (`Chameleon.cs:9116-9175`) which sets `effectControl.life = (float)mDuration;`
  (`Chameleon.cs:9172`) on the spawned cage object (the same cage that `tormentRain`'s own barrage is
  scoped to hit). Both durations are chaAdjust-wrapped, non-contested, and not gated behind a separate
  passive.
- **`tent`, `rustyDecay`, and `venomShock` are excluded (2026-08-14, at the user's request) — all three
  citable values are real, but none is the kind of duration this doc's table reports for other skills.**
  `tent`: `Chameleon.cs:36128` — `this.$castTime$23070 = this.$self_$23071.mChar.magAdjust((float)12);`,
  applied at `Chameleon.cs:36139` — `RPC_AddStatus("tent", 5, (int)this.$castTime$23070, 0, ActorNr)` —
  but this fires from inside the cast/channel state machine itself (`case 3:`, gated on
  `actionState == "attack"` and `myCommand == "tent"`, `Chameleon.cs:36109-36118`), tagging the caster
  with a `"tent"` status for the same `magAdjust(12)` span as the cast/channel animation — a channel-lock
  marker synced to the cast, not a lingering post-cast buff the way this doc's other Duration entries
  are. `rustyDecay`: `Chameleon.cs:35523` — `this.$tChar$23053.RPC_AddStatus("rustyDecay", 2, 12, 0,
  this.$self_$23064.mChar.ActorNr);` (bare `12`, not `chaAdjust`-wrapped) — but `$tChar$` is the enemy
  hit by the skill, not the caster, matching the Cat doc's `grandCasinoArcade`/`moonBlade`/`moonStorm`/
  `deltaStrike` precedent (an on-hit debuff inflicted on a target is the wrong side of the cast for this
  column). `venomShock`: `Chameleon.cs:23956` — `this.$tChar$22726.RPC_AddStatus("venomShock",
  this.$sLv$22737, 12, 0, this.$self_$22738.mChar.ActorNr);` (bare `12`, not `chaAdjust`-wrapped) — same
  target-applied-debuff reason as `rustyDecay`.
- **No `RPC_AddStatus` call exists anywhere in the coroutine class body** (confirmed by bounding each
  skill's `internal sealed class $RPC_<name>` range in `Chameleon.cs`, then cross-checking against the
  full-file `RPC_AddStatus` grep) for: `quickFire` (`Chameleon.cs:19240-20438`), `massShot`
  (`22195-23037`), `tormentRain` and its downstream `tormentRain_fire`
  (`25269-25872`, `25872-26159`), `leftStride` (`26607-27821`), `rightStride` (`27821-29212`),
  `bloodBurn` (`29654-30217`), `slayer` and its downstream `slayer_fire`
  (`30217-31274`, `31274-32144`), `allSlayer` and its downstream `allSlayer_fire`
  (`32144-32805`, `32805-34044`), `allSlain` (`34044-34709`), `skinShift` (`34709-35336`, see the
  `immunity`/`skinShift5` note above), and `zeroShot` (`36976-37784`) — pure-damage, pure-utility, or
  (for `skinShift`) status-re-leveling skills with no fresh buff/debuff duration of their own. Duration
  cells are `—`.

### CD citations
- `immunity` CD: `Chameleon.cs:19009` — `this.$self_$22585.mChar.addTimeOut("immunity", this.$self_$22585.mChar.agiAdjust((float)120));` (same value re-set at the `skinShift5` cast site, `Chameleon.cs:34978` — see judgment-call note)
- `quickFire` CD: `Chameleon.cs:20154` — `this.$self_$22615.mChar.addTimeOut("quickFire", this.$self_$22615.mChar.agiAdjust((float)(20 + this.$sLv$22614 * 10)));` (sLv4 → 60)
- `perfectBlend` CD: `Chameleon.cs:20780` — `this.$self_$22625.mChar.addTimeOut("perfectBlend", this.$self_$22625.mChar.agiAdjust((float)60));`
- `trueInvisibility` CD: `Chameleon.cs:18294` (sets `$mTimeOut$22547 = 90`) applied at `Chameleon.cs:18380` — `this.$self_$22565.mChar.addTimeOut(this.$sType$22560, this.$self_$22565.mChar.agiAdjust((float)this.$mTimeOut$22547));` (shared cast-windup coroutine, `$RPC_cast1$22545`, `Chameleon.cs:17732-18689`)
- `needlePrison` CD: `Chameleon.cs:21906` — `this.$self_$22661.mChar.addTimeOut("needlePrison", this.$self_$22661.mChar.agiAdjust((float)60));`
- `massShot` CD: `Chameleon.cs:22762` — `this.$self_$22689.mChar.addTimeOut("massShot", this.$self_$22689.mChar.agiAdjust((float)30));`
- `poisonVolley` CD: `Chameleon.cs:23494` — `this.$self_$22716.mChar.addTimeOut("poisonVolley", this.$self_$22716.mChar.agiAdjust((float)60));`
- `venomShock` CD: `Chameleon.cs:24089` — `this.$self_$22738.mChar.addTimeOut("venomShock", this.$self_$22738.mChar.agiAdjust((float)90));`
- `massInvisibility` CD: `Chameleon.cs:18311` (sets `$mTimeOut$22547 = 300`) applied at `Chameleon.cs:18380` (shared cast-windup coroutine, see `trueInvisibility` citation above)
- `finalEntrapment` CD: `Chameleon.cs:18328` (sets `$mTimeOut$22547 = 300`) applied at `Chameleon.cs:18380` (shared cast-windup coroutine)
- `tormentRain` CD: `Chameleon.cs:25659` — `this.$self_$22775.mChar.addTimeOut("tormentRain", this.$self_$22775.mChar.agiAdjust((float)3));`
- `fatalStrike` CD: `Chameleon.cs:26400` — `this.$self_$22795.mChar.addTimeOut("fatalStrike", this.$self_$22795.mChar.agiAdjust((float)30));`
- `leftStride` CD: `Chameleon.cs:27097` — `this.$self_$22820.mChar.addTimeOut("leftStride", this.$self_$22820.mChar.agiAdjust((float)60));`
- `rightStride` CD: `Chameleon.cs:28471` — `this.$self_$22863.mChar.addTimeOut("rightStride", this.$self_$22863.mChar.agiAdjust((float)60));`
- `campFire` CD: `Chameleon.cs:18277` (sets `$mTimeOut$22547 = 60`) applied at `Chameleon.cs:18380` (shared cast-windup coroutine)
- `bloodBurn` CD: `Chameleon.cs:29985` — `this.$self_$22901.mChar.addTimeOut("bloodBurn", this.$self_$22901.mChar.agiAdjust((float)(12 + this.$sLv$22900 * 3)));` (sLv2 → 18)
- `slayer` CD: `Chameleon.cs:30820` — `this.$self_$22922.mChar.addTimeOut("slayer" + this.$sLv$22921, this.$self_$22922.mChar.agiAdjust((float)90));` (flat regardless of sLv 1-4; see judgment-call note)
- `allSlayer` CD: `Chameleon.cs:32425` — `this.$self_$22977.mChar.addTimeOut("allSlayer" + this.$sLv$22976, this.$self_$22977.mChar.agiAdjust((float)240));` (flat regardless of sLv 1-4; see judgment-call note)
- `allSlain` CD: `Chameleon.cs:34480` — `this.$self_$23022.mChar.addTimeOut("allSlain", this.$self_$23022.mChar.agiAdjust((float)300));`
- `rustyDecay` CD: `Chameleon.cs:35656` — `this.$self_$23064.mChar.addTimeOut("rustyDecay", this.$self_$23064.mChar.agiAdjust((float)90));`
- `tent` CD: `Chameleon.cs:18345` (sets `$mTimeOut$22547 = 240`) applied at `Chameleon.cs:18380` (shared cast-windup coroutine)
- `markOfSlayer` CD: `Chameleon.cs:18362` (sets `$mTimeOut$22547 = 150`) applied at `Chameleon.cs:18380` (shared cast-windup coroutine)
- `zeroShot` CD: `Chameleon.cs:37513` — `this.$self_$23104.mChar.addTimeOut("zeroShot", this.$self_$23104.mChar.agiAdjust((float)60));` (an unrelated pre-emptive `addTimeOut("zeroShot", agiAdjust(60f))` also runs once at spawn in `Start()`, `Chameleon.cs:86`, same value — not this skill's cast site)
- `thunderDragon` CD: `Chameleon.cs:38225` — `this.$self_$23135.mChar.addTimeOut("thunderDragon", this.$self_$23135.mChar.agiAdjust((float)90));` (an unrelated pre-emptive `addTimeOut("thunderDragon", agiAdjust(90f))` also runs once at spawn in `Start()`, `Chameleon.cs:89`, same value — not this skill's cast site)

### Duration citations
- `immunity` Duration: `Chameleon.cs:18876` — `characterControl.RPC_AddStatus("immunity", 2 * this.$sLv$22584 + ((!this.$self_$22585.mChar.hasSkill(421)) ? 0 : 1), this.$self_$22585.mChar.chaAdjust(12), 0, this.$self_$22585.mChar.ActorNr);` (duration argument is a flat `chaAdjust(12)`, unaffected by sLv or the passive; `skinShift5`'s own cast site sets no duration of its own — see judgment-call note)
- `perfectBlend` Duration: `Chameleon.cs:20687` — `this.$self_$22625.mChar.RPC_AddStatus("blend", this.$sLv$22624, this.$self_$22625.mChar.chaAdjust(2 * this.$sLv$22624 + ((!this.$self_$22625.mChar.hasSkill(412)) ? 0 : 4)), 0, this.$self_$22625.mChar.ActorNr);` (sLv2, no passive → chaAdjust(4); self-buff, not target-contested)
- `trueInvisibility` Duration: `Chameleon.cs:21155` — `this.$tChar$22632.RPC_AddStatus("invisible", this.$sLv$22634, this.$self_$22635.mChar.chaAdjust(4 + 4 * this.$sLv$22634 + ((!this.$self_$22635.mChar.hasSkill(412)) ? 0 : 4)), this.$self_$22635.mChar.talAdjust(10 * this.$sLv$22634), this.$self_$22635.mChar.ActorNr);` (sLv2, no passive → chaAdjust(12))
- `massInvisibility` Duration: `Chameleon.cs:24575` — `this.$tChar$22747.RPC_AddStatus("invisible", this.$sLv$22749, this.$self_$22750.mChar.chaAdjust(4 * this.$sLv$22749 + 4), this.$self_$22750.mChar.talAdjust(20 * this.$sLv$22749), this.$self_$22750.mChar.ActorNr);` (sLv2 → chaAdjust(12))
- `finalEntrapment` Duration: `Chameleon.cs:24999` — `this.$mDuration$22755 = Mathf.FloorToInt((float)this.$self_$22758.mChar.chaAdjust(2 * this.$sLv$22757 + 3));`, applied as a spawned-effect lifetime at `Chameleon.cs:9172` — `effectControl.life = (float)mDuration;` (sLv2 → chaAdjust(7); field-effect lifetime, not `RPC_AddStatus` — see judgment-call note)
- `fatalStrike` Duration: `Chameleon.cs:26313` — `this.$self_$22795.mChar.RPC_AddStatus("fatalStrike", this.$sLv$22794 + ((!this.$self_$22795.mChar.hasSkill(403)) ? 0 : 1), this.$self_$22795.mChar.chaAdjust(12), 5 + ((!this.$self_$22795.mChar.hasSkill(403)) ? 0 : 5), this.$self_$22795.mChar.ActorNr);` (duration argument is a flat `chaAdjust(12)`, unaffected by sLv or the passive)
- `campFire` Duration: `Chameleon.cs:29360` — `this.$mCampFireTimer$22881 = this.$self_$22884.mChar.chaAdjust(30);`, passed into `Chameleon_campFire.Init` via `RPC_campFire_create` (`Chameleon.cs:29365`, `9417-9455`) (field-effect lifetime, not `RPC_AddStatus` — see judgment-call note)
- `needlePrison`, `poisonVolley`, `markOfSlayer`, `thunderDragon`: target-CHA-contested via `Damage.getDebuff` — see judgment-call notes above for each skill's specific citation. Duration cells are `—`.
- `quickFire`, `massShot`, `tormentRain`, `leftStride`, `rightStride`, `bloodBurn`, `slayer`, `allSlayer`,
  `allSlain`, `zeroShot`: no usable Duration — no `RPC_AddStatus` call exists in the skill's own coroutine
  class body (or its downstream `_fire` coroutine, where applicable); see the bulk judgment-call note
  above for the exact class-range bounds checked. Duration cells are `—`.
- `tent`, `rustyDecay`, `venomShock`: excluded on scope grounds (channel-lock marker / enemy-applied
  debuff, not the caster's own duration), not because no citable value exists — see the dedicated
  judgment-call note above for the exact citations.

---

# Damage & Mechanics

Verified from decompiled source (`DecompiledSource/Chameleon.cs`, `Chameleon_nAttack.cs`, `Chameleon_campFire.cs`, `Chameleon_needlePrison.cs`, `ChameleonSkill.cs`) for the Bible skill-details tool (`12t_projects/bible/index.html`).

Per-skill entries (`### chm_<name>`) are the verified 2026-10-01 pass; they take precedence over anything older in this file. Command numbers come from `ChameleonSkill.cs` `getSkillTree()`; costs and requirements were decoded with `scripts/decode_skilldata.py`.

### chm_nAttack1-4 (Combo, #101-104): one arrow per attack (verified 2026-10-01)

- **Metadata:** passive, no cost; Lv/Bn 1/0, 2/1, 3/2, 4/3. `getNormalAttackLv()` = highest of #101-104, 0-4 (`Chameleon.cs:8387-8436`).
- **Flow:** `doNormalAttack` starts `RPC_nAttack1` from standby/run when the `nAttack` lock is free (`Chameleon.cs:5996-6057`). The coroutine sets `addTimeOut("nAttack", 1.5 − 0.3 × Combo)` = 1.5 / 1.2 / 0.9 / 0.6 / 0.3 s (`:15950-15994`), waits 0.2 s and fires **one** arrow: `RPC_clearArrow_fire` if `getClearArrow()` (Clear Arrow learned and the Chameleon has `invisible`), otherwise `RPC_nAttack_fire` (`:15586-15643`). It fires only in real game modes (`Game.mGameType > 4`, `:15578`).
- **Arrow:** `ProjectileControl.life = (0.4 + 0.1 × FarReach) × rangeMod` (`:8482`); `Chameleon_nAttack.Awake` speed 30 m/s, 40 m/s with Bow Mastery (`Chameleon_nAttack.cs:34`, `:100`); destroyed on the first enemy it touches. Range 12 + 3 × FR m (16 + 4 × FR with Bow Mastery).
- **Damage (`Chameleon_nAttack.OnTriggerEnter`, `Chameleon_nAttack.cs:496-688`):** `num = FloorToInt((0.45 − 0.025 × Combo) × ATK) + 6 × fatalStrikeStatusLv + 6 × PiercingVenomLv × target poison lv` (`:502`); Bow Mastery (#401) `num += floor(0.1 × Lv)` (`:505-511`). Coefficient 0.425 / 0.4 / 0.375 / 0.35 ATK at Combo 1-4.
- **Crit (`:517-668`):** chance sum = weapon `w_chm43`/`w_chm44` (G.Marshal Bow B/R) +4, `w_chm48` (Mantis Bow R) +5; armor `a_chm48` (Mantis Suit R) +4; hat `c_chm48` (Mantis Hat R) +3; Critical Plus `4 × lv + 4`. The armor/hat checks list `a_chm43`/`c_chm43` twice, which are not items (no entry in `ArmorData.cs`/`AccessoryData.cs`). Champion gear (`w_chm58`, `a_all58`, `c_all58`) and Marshal armor/hat (`a_all43/44`, `c_all43/44`) are not in this table, and `Chameleon.getCritPlus` (`Chameleon.cs:14658`, the Marshal/Champion table other classes use) has no caller in any Chameleon file. Roll `Random.Range(0,100) < lckAdjust(sum)` → `CeilToInt(num × 1.8)`, or `CeilToInt(num × (1.8 + 0.15 × CriticalPlusLv))` with Bull's Eye (#413) (`:643-668`). Rounding is **up**, unlike the `getCritPlus` floor.
- **Hit:** `hit(1 + Combo, target, num, KO 1, hate floor(−0.5 × num × clearLv), 0.15 × forward)` (`:688`), force 1.5 × forward with `w_chm59` Power Bow (`:415-421`). On a landed hit: `onNormalAttackHit`, `sp++`, then the Poison Arrow roll (see Poison Arrow) and All Slain list (#371) (`:696-799`).
- **Tooltip:** "decrease its damage by 5/10/15/15%" (`ChameleonSkill_eng.cs:37-70`); the code is 0.45 → 0.425/0.4/0.375/0.35 (−5.6/−11/−17/−22%), the Thai rank 4 "20%" is closer.
- **Card:** `rawModel` (`chameleonComboParts`) with Bow Mastery, Fatal Strike + Extra Arrows, Piercing Venom (rank 2 = Deadly Venom) × target poison level, Critical Plus, Bull's Eye and the crit gear as header deps; crit drawn as ⌈…⌉.

### chm_cAttack1-3 (Charge Attack, #111-113): hidden charge, then a volley (verified 2026-10-01)

- **Metadata:** passive, no cost; Lv/Bn 4/1, 10/3, 16/5. `getChargeAttackLv()` 0-3 (`Chameleon.cs:8608-8648`).
- **Charge (`RPC_cAttack1`, `Chameleon.cs:16112-16841`):** sets `myCommand = "cAttack1"`, `addTimeOut("cAttack", 1)`; 0.2 s later (real game modes only) `RPC_AddStatus("blend", 4, chaAdjust(3 × chargeLv + 3), 0, …)` on the Chameleon (`:16358`) → 6 / 9 / 12 s, not contested. Silent Walk (#411) lets it walk at `moveSpeed` lerped to 2 (`:16526-16600`).
- **Release (`doReleaseCharge`, `:6204-6263`):** only after `actionTime + 1.8 s` and in real game modes; `n = FloorToInt(Clamp(held − 0.8, 0, 3 × chargeLv))` → `RPC_cAttack2(…, n)`, else `RPC_cAttack0` (no attack).
- **Volley (`RPC_cAttack2`, `:16841-17527`):** `2 × n` swings 0.2 s apart (`:17202-17212`), up to 6 / 12 / 18. Each swing: `FindRecTarget(pos, forward, 1, 8, 12, 4)` (2 m wide at the Chameleon, 16 m at 12 m, height 4) and every target takes `hit(111, t, (int)(0.3 × ATK) [+ floor(0.1 × Lv) with Silent Walk] + 6 × PiercingVenomLv × poison lv, KO 1, 0, …)` (`:16976-17036`). No crit, no `sp++`; All Slain list on hit.
- **`blend` status:** Buff (`StatusData.cs:6674`) + Physical (`:5445`), in `isInvisibleStatus` (`:6196`). Apply (`CharacterControl.cs:36665-36760`): removes `invisible`; for other teams the renderers get the `FX/Camaflage` shader, or are switched off when the Chameleon has Erase Senses (#412). Monster AI skips `blend` targets (e.g. `Alpaca_AI.cs:1321`) and the GUI target picker skips them (`GameGui.cs:3871`). Only a Chameleon or Matti can receive it (`CharacterControl.cs:12399`). `Chameleon.Update` removes it as soon as `actionState` is not standby/run and the command is not `perfectBlend`/`cAttack1` (`Chameleon.cs:166-201`), so the release itself breaks it.
- **Tooltip:** "(max 3/6/9 sec)" matches the `3 × chargeLv` clamp.
- **Card:** `rawModel` per swing, `hitCount 6 × rank` (full charge), duration 6/9/12 s with `[blend4]`; Silent Walk and Piercing Venom deps.

### chm_farReach1-4 (Far Reach, #131-134) (verified 2026-09-27, re-checked 2026-10-01)

- `getFarReachLv()` (`Chameleon.cs:8716-8768`, junk predicates re-evaluated) and every read are listed in the Far Reach section further down; unchanged.

### chm_quickFire1-4 (Quick Fire, #201-204): rapid single-target shots (verified 2026-10-01)

- **Metadata:** SP 12/16/20/24 **blue** (threshold, not consumed), Lv/Bn 3/0, 9/1, 15/2, 21/3, mode target, enemy. Cast gate: target closer than `18 + 4 × FR` m (`Chameleon.cs:8232`).
- **CD:** `addTimeOut("quickFire", agiAdjust(20 + 10 × sLv))` = **30 / 40 / 50 / 60 s** (`Chameleon.cs:20154`). The card's former flat 60 was only right at rank 4.
- **Shots (`RPC_quickFire`, `Chameleon.cs:19240-20438`):** 0.4 s wind-up, then shots 0.1 s apart, each a `Physics.Raycast` of `20 + 4 × FR` m (`:19467`) that hits the first collider in line. Opening shot `hit(200 + sLv, t, (int)(0.25 × ATK), KO 0, …)` (`:19620`), a loop of `2 × sLv` shots (`4 × sLv` with Added Fire #402, `:20061`) at `(int)((0.25 + 0.1 if Added Fire) × ATK)` (`:19741`), then a closing shot at 0.25 ATK (`:19912`). Total 2 + 2 × sLv (2 + 4 × sLv). Each landed shot `sp + 1` and All Slain list.
- **Tooltip:** 4/6/8/10 hits matches. Added Fire's Thai "+30%" is +0.1 ATK on 0.25 (+40%) in code.

### chm_bowMastery5 (Bow Mastery, #401) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. Combo and Clear Arrow arrows: speed 40 instead of 30 m/s (`Chameleon_nAttack.cs:100`) and `+ floor(0.1 × Lv)` damage (`:505-511`). No other reads in the Chameleon files. Tooltip "+50% speed" is +33% in code (30 → 40).

### chm_criticalPlus1-4 (Critical Plus, #311-314) and chm_bullsEye5 (Bull's Eye, #413) (verified 2026-10-01)

- Critical Plus: passive, Lv/Bn 5/1, 11/3, 17/5, 23/7. `getCriticalPlusLv()` 0-4 (`Chameleon.cs:9272-9323`); adds `4 × lv + 4` = 8/12/16/20 to the Combo crit chance (`Chameleon_nAttack.cs:620-631`). Tooltip matches.
- Bull's Eye: passive, Lv 60/Bn 1. Crit multiplier `1.8 + 0.15 × CriticalPlusLv` (`:649-655`), 2.4 at Critical Plus 4 ("240%"). Read only there.

### chm_extraArrows5 (Extra Arrows, #403) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. Fatal Strike's status level +1 and arrow count 5 → 10 (`Chameleon.cs:26313`). Also raises the Immunity gate before Fatal Strike (`:7904`, see Fatal Strike).

### chm_poisonArrow1-4 (Poison Arrow, #231-234): poison on Combo hits (verified 2026-10-01)

- **Metadata:** passive, Lv/Bn 9/3, 15/5, 21/7, 27/9. `getPoisonArrowLv()` 0-4 (`Chameleon.cs:8804-8856`).
- **Roll (`Chameleon_nAttack.cs:713-789`, after a landed Combo / Clear Arrow hit):** `Random.Range(0,100) < lckAdjust(8 + 4 × lv)` (12/16/20/24). Target not `eRace.Robots`: `RPC_AddStatus("poison", Clamp(currentPoisonLv + 1 + (RustyDecay #432 ? 1 : 0), 0, IncreasedPoisonLv + 1), Damage.getDebuff(8 + 2 × IncreasedPoisonLv, cha, targetCha), 0, …)`. Robots: nothing, unless Rusty Decay is learned, then the same formula applies `rust` instead.
- **Status `poison`:** Debuff (`StatusData.cs:7406`) + Physical (`:5457`). Tick (`CharacterControl.cs:9208-9240`): every 4 s while alive, owner client, `RPC_AddEffectDamage(1, 10 × lv − 1, …)`. `RPC_AddStatus` rejects it while the target has `venomShock` (`:11265-11273`); some bug types (FlowerBug, FudaBug, WormBug) reject it (`:12725-12800`).
- **Status `rust`:** Debuff (`:7418`) + Physical (`:5469`); tick `RPC_AddEffectDamage(1, 15 × lv, …)` every 4 s (`:9241-9270`); rejected while `rustyDecay` is on the target (`:11340-11348`).
- **Tooltip:** chance 12-24% and "(9/4 dps, 8 sec)" match (poison 1 = 9 per 4 s).

### chm_increasedPoison1-3 (Increased Poison, #241-243) and chm_deadlyVenom5 (Deadly Venom, #442) (verified 2026-10-01)

- Increased Poison: passive, Lv/Bn 16/4, 20/8, 24/12. `getIncreasedPoisonLv()` returns 1-3, and **5 whenever Deadly Venom is learned** (`Chameleon.cs:8857-8909`). It sets the poison/rust level cap `lv + 1` and duration `getDebuff(8 + 2 × lv)` for Poison Arrow and Poison Volley (`Chameleon_nAttack.cs:741-773`, `Chameleon.cs:23318-23340`).
- Deadly Venom: passive, Lv 85/Bn 6. Cap 6, base duration 18 s; also `getPiercingVenomLv()` = 2 (`Chameleon.cs:8912`), even without Piercing Venom.
- **Tooltip discrepancy:** English "+2/4/6 s" matches; Thai "+2 sec" at every rank does not.

### chm_piercingVenom1 (Piercing Venom, #244) (verified 2026-10-01)

- Passive, Lv 28/Bn 16. `getPiercingVenomLv()` = 1 (2 with Deadly Venom) (`Chameleon.cs:8912`). Combo/Clear Arrow `+ 6 × lv × target poison lv` (`Chameleon_nAttack.cs:499-502`) and each Charge Attack swing the same (`Chameleon.cs:17003`, `:17036`).
- **Tooltip discrepancy:** "+4 dmg per poison lv" (`ChameleonSkill_thai.cs:431`); the code adds 6.

### chm_poisonVolley1-2 (Poison Volley, #251-252) (verified 2026-10-01)

- MP 6/9, SP −12/−18 (red), Lv/Bn 20/12, 24/15, instant. CD `agiAdjust(60)` (`Chameleon.cs:23494`). The card's former MP 6/12, SP 12/24 were wrong.
- `RPC_poisonVolley` (`Chameleon.cs:23037-23758`): 0.3 s wind-up, then one pass over `FindRecTarget(pos, forward, 1, 8, 12, 4)` (owner client): `hit(252 + sLv, t, (int)(0.5 × ATK), KO 1, 0, 0.5 × away)` (`:23312`); on a landed hit `poison` at `Clamp(currentLv + sLv, 0, IncreasedPoisonLv + 1)`, raised to at least `sLv`, for `getDebuff(8 + 2 × IncreasedPoisonLv)` (`:23318-23345`). No race check, so Robots are poisoned too.

### chm_venomShock1-2 (Venom Shock, #253-254) (verified 2026-10-01)

- MP 12/24, SP −24/−30 (red), Lv/Bn 28/18, 32/21. CD `agiAdjust(90)` (`Chameleon.cs:24089`). The card's former SP 24/36 was wrong. Needs a selected target (`doSkill` does nothing with no target, `Chameleon.cs:8016-8020`).
- `RPC_venomShock` (`:23758-24389`): `tChar.RPC_AddStatus("venomShock", sLv, 12, 0, …)` (`:23956`), 12 s, not wrapped or contested.
- **Status `venomShock`** (Debuff `StatusData.cs:7412` + Physical `:5463`), apply `CharacterControl.cs:36972-37030`: if the target has `poison` with more than 1 s left, `RPC_AddEffectDamage(252 + sLv, CeilToInt(0.25 × (0.5 × sLv + 0.5) × (10 × poisonLv − 1) × secondsLeft), …)`, then `poison` is removed. `0.25 × (10 × lv − 1)` is the poison damage per second, so this is 100% / 150% of the poison damage still to come. While `venomShock` lasts, new `poison` is rejected.

### chm_rustyDecay5 (Rusty Decay, #432) (verified 2026-10-01)

- MP 24, SP −30 (red), Lv 75/Bn 4, needs a target. CD `agiAdjust(90)` (`Chameleon.cs:35656`). `RPC_AddStatus("rustyDecay", 2, 12, 0, …)` (`:35523`).
- **Status `rustyDecay`** (Debuff `:7424` + Physical `:5475`), apply `CharacterControl.cs:37142-37200`: `CeilToInt(0.25 × 1.5 × 15 × rustLv × secondsLeft)` Effect Damage when `rust` has more than 1 s left, then `rust` is removed; blocks new `rust` for 12 s. The level is fixed at 2, so it is always 150%.
- **Passive part:** Poison Arrow adds 2 levels per proc instead of 1, and gives Robots `rust` (`Chameleon_nAttack.cs:741`, `:762-783`).

### chm_doubleEffect5 (Double Effect, #431) (verified 2026-10-01)

- Passive, Lv 75/Bn 4. In `onNormalAttackHit` (`Chameleon.cs:47330-47640`, called only from the Combo/Clear Arrow projectile, `Chameleon_nAttack.cs:702`) `doubleEffect = 2`: it multiplies the base chance (inside `lckAdjust`) of Heart Bow charm, Plunger Bow sticky, Salamander Bow burn, Golden Bow heavy, Time Bow restore and the Mummy (plague) / Frozen (MP drain) / Poseidon (HP drain) pools, and doubles the charm, sticky, burn, heavy and plague durations. Paper Bow `happy3` (`lckAdjust(12)`), BD Bow heal (`lckAdjust(3)`) and Demonic Bow (flat 13%) are not multiplied.
- TTO: the Poseidon set HP Drain is a flat 20% (40% with Double Effect), see Server Balance Variations.

### chm_immunity1-2 (Immunity, #121-122) (verified 2026-10-01)

- MP 3/5, Lv/Bn 6/2, 12/4, instant, self. CD `agiAdjust(120)` (`Chameleon.cs:19009`).
- `RPC_immunity` (`Chameleon.cs:18689-19240`): `RPC_AddStatus("immunity", 2 × sLv + (SkinShift #421 ? 1 : 0), chaAdjust(12), 0, …)` (`:18876`) → level 2/4, 3/5 with Skin Shift learned. Status `immunity` is in [12Tails-Mechanics-Reference.md §4.2](12Tails-Mechanics-Reference.md#42-status-classification-cleanse-system-statusdatacs) (blocks statuses of level ≤ its own, buffs included).
- **Fatal Strike gate:** `doSkill` refuses Fatal Strike ("Cannot add fatalStrike while immune") and returns the MP/SP when `getStatusLv("immunity") >= FatalStrikeLv + (ExtraArrows #403 ? 1 : 0)` (`Chameleon.cs:7904`).
- **Tooltip:** Thai "Immunity2/4" matches; English "immune1 … lv2" is off by one rank.

### chm_skinShift5 (Skin Shift, #421) (verified 2026-10-01)

- MP 10, SP −10 (red), Lv 70/Bn 3, instant. Shares the `immunity` cooldown key: `addTimeOut("immunity", agiAdjust(120))` (`Chameleon.cs:34978`).
- `RPC_skinShift` (`:34709-35336`): collects every status in `mStatusList` that is **not** `isSystemStatus` (debuffs and buffs alike, including its own `immunity`) and removes them, then the owner client takes `RPC_AddDamage(1, CeilToInt(0.1 × hp), …)` (`:35150-35229`) — direct damage, so the target's `hitMod` applies. It gives no status of its own; the "+1 Immunity level" is the passive hook in `RPC_immunity` (`:18876`).

### chm_perfectBlend1-2 (Perfect Blend, #211-212) (verified 2026-10-01)

- SP −8/−12 (red), no MP, Lv/Bn 5/1, 11/3, instant, self. CD `agiAdjust(60)` (`Chameleon.cs:20780`). The card's former MP 12 / SP 8-14 were wrong.
- `RPC_perfectBlend` (`:20438-20960`): stops (`moveSpeed = 0`), then `RPC_AddStatus("blend", sLv, chaAdjust(2 × sLv + (EraseSenses #412 ? 4 : 0)), 0, …)` (`:20687`) and `isBlend = true`. `blend` is described under Charge Attack; it breaks on the next action.
- **Tooltip discrepancy:** "(3 sec)" at rank 2; code base 4 s.

### chm_trueInvisibility1-2 (True Invisibility, #213-214) (verified 2026-10-01)

- MP 12/20, Lv/Bn 17/5, 23/7, target ally. Cast `magAdjust(3 + sLv)` = 4/5 s, CD `agiAdjust(90)` (`RPC_cast1` dispatcher, `Chameleon.cs:18283-18294`, `:18368-18380`). The card's former cast 5 s and SP cost were wrong.
- `RPC_trueInvisibility_cast` (`:20960-21406`): the selected ally (or self) gets `RPC_AddStatus("invisible", sLv, chaAdjust(4 + 4 × sLv + (EraseSenses ? 4 : 0)), talAdjust(10 × sLv), …)` (`:21155`).
- **Status `invisible`** (Buff, Magical): apply removes `blend` (`CharacterControl.cs:36942-36950`); monster AI and the GUI target picker skip it (`GameGui.cs:3865`); it is not removed by attacking or casting (no `removeStatus("invisible")` in any attack path). It is removed by `hide`, `holyWolf`, `awareness`, `petrify`, `fireAvatar`, `earthForm`, `snowMan`, `cosmicRift`, `cosmicFriday` (`CharacterControl.cs:32825`–`:39054`) and by Thunder Dragon (`Chameleon.cs:38265`). The `talAdjust(10 × sLv)` status value has no reader in the decompiled source.

### chm_massInvisibility1-2 (Mass Invisibility, #261-262) (verified 2026-10-01)

- MP 28/36, Lv/Bn 24/15, 27/18, instant. Cast `magAdjust(4 + 2 × sLv)` = 6/8 s, CD `agiAdjust(300)` (`Chameleon.cs:18300-18311`). The card's former MP 28/38 and cast 8 s at rank 1 were wrong.
- `RPC_massInvisibility_cast` (`:24389-24837`): every child tagged `Player` of the caster's team container (`transform.parent`, no range limit, caster included; see [12Tails-Mechanics-Reference.md §4.6](12Tails-Mechanics-Reference.md#46-team-containers-and-team-wide-skills-gamecs)) gets `RPC_AddStatus("invisible", sLv, chaAdjust(4 × sLv + 4), talAdjust(20 × sLv), …)` (`:24575`). No Erase Senses term.

### chm_silentWalk5 (Silent Walk, #411) (verified 2026-10-01)

- Passive, Lv 60/Bn 1. While holding Charge Attack the Chameleon can walk, `moveSpeed` lerped toward 2 (`Chameleon.cs:16526-16600`), and every Charge Attack swing adds `floor(0.1 × Lv)` (`:16991-16997`). Its CharacterControl `hasSkill(411)` hits (`:4059`, `:30869`, `:30936`) are Bison/Whale code, not Chameleon.

### chm_eraseSenses5 (Erase Senses, #412) (verified 2026-10-01)

- Passive, Lv 60/Bn 1. `+4` s base duration for Perfect Blend (`Chameleon.cs:20687`) and True Invisibility (`:21155`), not Mass Invisibility. On `blend` apply, other teams' renderers of the Chameleon are switched off instead of the camouflage shader (`CharacterControl.cs:36665-36700`). The radar icon of an enemy Chameleon with #412 is not drawn while it has `blend` or `invisible` (`GameGui.cs:5466-5497`, `displayPlayerIcon`).
- **Tooltip discrepancy:** "+50%" duration; the code adds a flat 4 s (+200% / +100% for Perfect Blend, +50% / +33% for True Invisibility).

### chm_needlePrison1-2 (Needle Prison, #221, #223) (verified 2026-10-01)

- SP −14/−16 (red), no MP, Lv/Bn 7/2, 19/6, target enemy. CD `agiAdjust(60)` (`Chameleon.cs:21906`). The card's former SP 14/20 was wrong.
- `RPC_needlePrison` (`:21406-22195`): the selected target only, or with Mass House Lock (#422, `:22024-22033`) every enemy in `FindAreaTarget(target, 6, 3)` (`:21694-21700`); each gets `RPC_AddStatus("needlePrison", sLv, Damage.getDebuff(1 + sLv, cha, targetCha) + (MassHouseLock ? 2 : 0), 0, …)` (`:21745-21750`): 2/3 s contested, +2 s after the contest. No damage. `Chameleon_needlePrison.cs` is only the cage visual spawned by the status (`CharacterControl.cs:36641`).
- **Tooltip discrepancy:** English rank 2 "(2 sec)"; Thai and code 3 s.

### chm_massHouseLock5 (Mass House Lock, #422) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. Needle Prison: 6 m area around the target, +2 s (above). Mass Shot: radius `6 + 3` (`Chameleon.cs:22508`) and `hitDmg = (int)(1.5 × hitDmg)` (`:22518-22524`). The English tooltip's "lock enemies within 6m of its first target" is the Needle Prison part.

### chm_finalEntrapment1-2 (Final Entrapment, #271-272) (verified 2026-10-01)

- MP 20/30, SP −35/−45 (red), Lv/Bn 35/23, 40/25, target enemy. Cast `magAdjust(6)`, CD `agiAdjust(300)` (dispatcher `Chameleon.cs:18317-18328`).
- `RPC_finalEntrapment_cast` (`:24837-25269`): `mDuration = FloorToInt(chaAdjust(2 × sLv + 3))` (5/7 s base, `:24999`), then `RPC_finalEntrapment_hit(target position, …)` (`:9116-9251`): destroys the previous cage, instantiates `Effects/finalEntrapment` with `EffectControl.life = mDuration`, and calls `PositionEvent()` on every non-local character in `FindAreaTarget(pos, 8, 8)`. **No status and no damage** are applied in code; whatever traps the enemies is in the cage prefab, which the decompiled source does not show. The old card note "setting movement speed to 0" had no source.
- Torment Rain reads this cage (`OAQYXXtBCn`): cast only while it exists and the Chameleon is within 40 m (`sqrMagnitude < 1600`, `Chameleon.cs:6686-6703`), and the rain lands at its centre (`:25638-25644`).

### chm_clearArrow1 (Clear Arrow, #263) (verified 2026-10-01)

- Passive, Lv 30/Bn 21. `getClearArrow()` = learned and the Chameleon has `invisible` (`Chameleon.cs:8938-8981`); then Combo fires `RPC_clearArrow_fire` (`:8983-9108`), same `Chameleon_nAttack` damage with `nClearLv = 1`. `Init` keeps the arrow mesh for the owner's team and destroys it for others (`Chameleon_nAttack.cs:272-325`), so enemies do not see it.
- **Code vs tooltip:** the hit passes hate `floor(−0.5 × num)` (`Chameleon_nAttack.cs:688`), but `hit()` clamps it with `hateAdjust` to 0-999 (`CharacterControl.cs:3556`, `:20509-20511`) before `RPC_AddDamage` adds `damage + 10 × KO` (`:3771`), so a Clear Arrow makes the same hate as a normal arrow. The "no hate" tooltip is not achieved by this code.

### chm_tent5 (Tent, #433) (verified 2026-10-01)

- MP 40, SP −30 (red), Lv 75/Bn 4, instant. Cast `magAdjust(6)`, CD `agiAdjust(240)` (dispatcher `Chameleon.cs:18334-18345`).
- `RPC_tent_cast` (`:35950-36564`): channel `castTime = magAdjust(12)` with a cast bar and `RPC_AddStatus("tent", 5, (int)castTime, 0, …)` (`:36128-36151`). When the channel completes (`actionTime + castTime + 0.5`, `:36280`): `RPC_AddHeal(433, mhp, mmp, 0, 0, 0, …)` (full HP and MP, no SP/KO), `resetTimeOut()` (clears every cooldown, `CharacterControl.cs:20376-20378`) and `resetHate()` (`Chameleon.cs:36320-36335`).
- **Status `tent`:** Buff (`StatusData.cs:6692`) + State (`:4920`); only a Chameleon can receive it (`CharacterControl.cs:12436`). `moveSpeed = 0`, `myForce = 0` (`:2375-2386`); `sleep` is rejected (`:11406`); zzz emote every 3 s (`:9274`). **In the direct-damage coroutine every hit taken while in `tent` becomes `nDamage = mhp`** (`:31050-31060`), so any direct hit kills a full-HP Chameleon (Effect Damage is not affected).
- **Tooltip discrepancy:** "removing all negative status … refill hp mp and sp": no status is removed and SP is not restored in code; cooldowns are reset (Thai "CD").

### chm_campFire1-2 (Camp Fire, #331, #333) (verified 2026-10-01)

- MP 10/15, no SP, Lv/Bn 9/3, 21/7, instant. Cast `magAdjust(3 + sLv)` = 4/5 s, CD `agiAdjust(60)` (dispatcher `Chameleon.cs:18266-18277`). The card's former SP 24 and flat cast 5 s were wrong.
- `RPC_campFire_cast` (`:29212-29654`): `RPC_campFire_create(pos, …, chaAdjust(30), sLv)` (`:29360-29378`). `Chameleon_campFire.Update` (`Chameleon_campFire.cs:52-183`): every 4 s on the owner client, every character on the owner's layer in `FindAreaTarget(pos, 9, 3)` whose `actionState == "emotion"` gets `RPC_AddHeal(1, ceil(f × mhp), ceil(f × mmp), 0, ceil(f × mko), 0, …)` with `f = 0.01 + 0.02 × sLv` (3% / 5%): HP, MP **and KO**.

### chm_bloodBurn1-2 (Blood Burn, #332, #334) (verified 2026-10-01)

- **No MP or SP cost** (decoder MP 0, SP 0), Lv/Bn 15/5, 27/9, instant. CD `agiAdjust(12 + 3 × sLv)` = 15/18 s (`Chameleon.cs:29985`). The card's former MP 12/18, SP 24 and flat 18 s were wrong.
- `RPC_bloodBurn` (`:29654-30217`): refused with "Not enough hp" when `hp <= 40` (`:29963`); otherwise `RPC_AddDamage(1, 15 × sLv, …)` on itself (direct damage, `hitMod` applies) and `RPC_AddHeal(1, 0, 15 × sLv, 15 × sLv, 0, 0, …)` (MP and SP) (`:29841-29846`).

### chm_addedFire5 (Added Fire, #402) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. Quick Fire only: loop `4 × sLv` instead of `2 × sLv` (`Chameleon.cs:20061`) and loop shots `(0.25 + 0.1) × ATK` (`:19741`). See Quick Fire.

### chm_massShot1-2 (Mass Shot, #222, #224) (verified 2026-10-01)

- SP −10/−12 (red), no MP, Lv/Bn 13/4, 25/8, instant. CD `agiAdjust(30)` (`Chameleon.cs:22762`). The card's former SP 10/15 was wrong.
- `RPC_massShot` (`:22195-23037`): `moveSpeed = −2` (hops back); every enemy in `FindAreaTarget(self, 6 + (MassHouseLock ? 3 : 0), 3 × rangeMod)` (`:22508`) takes `hit(220 + 2 × sLv, t, (int)(0.5 × ATK + talAdjust(8 × sLv + 8)), KO 1, 0, …)` (`:22513-22558`), `(int)(1.5 × …)` with Mass House Lock. While the command is `massShot` every `hit()` against the Chameleon is dodged ([12Tails-Mechanics-Reference.md §2.8](12Tails-Mechanics-Reference.md#28-evasion-evade-only-inside-the-attackers-hit-verified-2026-09-23)).

### chm_tormentRain1 (Torment Rain, #273): arrow barrage (verified 2026-09-30, re-checked 2026-10-01)

- MP 15, SP −15 (red), Lv 45/Bn 27, instant. CD `agiAdjust(3)` (`Chameleon.cs:25659`). Cast only while the Chameleon's own Final Entrapment cage exists and it is within 40 m of it (`:6686-6703`); the target point is the cage centre (`:25638-25644`).
- `RPC_tormentRain_fire` (`Chameleon.cs:25872-26159`): after a 0.8 s wait, every enemy in `FindAreaTarget(hitPos, 8, 10, enemyLayer)` takes `hit(273, target, (int)(0.5 × ATK + talAdjust(60)), KO 1, 0, zero)` (`:26039-26067`), one hit per target.
- TTO: see Server Balance Variations below.

### chm_fatalStrike1-4 (Fatal Strike, #301-304) (verified 2026-10-01)

- MP 6/8/10/12, SP 6/8/10/12 **blue** (threshold), Lv/Bn 3/0, 9/1, 15/2, 21/3, instant. CD `agiAdjust(30)` (`Chameleon.cs:26400`).
- `RPC_fatalStrike` (`:26159-26607`): `RPC_AddStatus("fatalStrike", sLv + (ExtraArrows ? 1 : 0), chaAdjust(12), 5 + (ExtraArrows ? 5 : 0), …)` (`:26313`). The status value is an arrow counter: each `RPC_nAttack_fire` / `RPC_clearArrow_fire` reads the level, passes it to the arrow (`+6 × lv` damage) and decrements the value, removing the status at 0 (`:8494-8530`, `:9036-9077`). Left Stride arrows (and the Double Strider clone's) also use `RPC_nAttack_fire`, so they consume it too.
- **Status `fatalStrike`:** Buff (`StatusData.cs:6686`) + Magical (`:5717`); only a Chameleon can receive it (`CharacterControl.cs:12421`). No crit effect: the old card note "+5% Critical Rate" had no source.
- **Immunity gate:** see Immunity (`Chameleon.cs:7904`).

### chm_leftStride1-2 (Left Stride, #321, #323) (verified 2026-10-01)

- SP −12/−18 (red), no MP, Lv/Bn 7/2, 19/6, instant (needs a target closer than `18 + 4 × FR`, `Chameleon.cs:7834`). CD `agiAdjust(60)` (`:27097`). The card's former MP 4 / SP 12 were wrong.
- `RPC_leftStride` (`:26607-27821`): runs sideways at `runSpeed + 1` and fires `2 × sLv + 1` arrows (`:27058`) with `RPC_nAttack_fire` toward the target (`:26943-26982`), i.e. real Combo arrows: Combo damage at the learned Combo rank, crit, Fatal Strike, Piercing Venom, Poison Arrow, `sp++` and item procs all apply. Double Strider (#423) spawns a clone that fires the same arrow from its own position each time (`:26998-27043`).
- **Card:** `rawModel` = the Combo model with a Combo-rank dep; hit count `(2 × rank + 1) × 2` with Double Strider.

### chm_rightStride1-2 (Right Stride, #322, #324) (verified 2026-10-01)

- MP 4/6, SP −12/−18 (red), Lv/Bn 13/4, 25/8, instant (target closer than `18 + 4 × FR`, `Chameleon.cs:7754`). CD `agiAdjust(60)` (`:28471`). The card's former MP 4/8, SP 12/24 were wrong.
- `RPC_rightStride` (`:27821-29212`): `2 × sLv + 1` shots (`:28432`), each `Physics.RaycastAll` of `20 + 4 × FR` m that hits **every** target in line: `hit(301 + 2 × (sLv − 1), t, (int)(0.4 × ATK), KO 2, 0, …)` (`:28342-28370`), `sp + 1` and All Slain list on a landed hit. The Double Strider clone repeats each shot from its position (`:28386-28414`) without SP or All Slain.

### chm_doubleStrider5 (Double Strider, #423) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. Clone for Left and Right Stride (above); doubles the shots.

### chm_zeroShot5 (Zero Shot, #434) (verified 2026-10-01)

- MP 30, SP −30 (red), Lv 75/Bn 4, instant. CD `agiAdjust(60)` (`Chameleon.cs:37513`; also pre-set at mission start, `:86`).
- `RPC_zeroShot` (`:36976-37784`): pulls every enemy in `FindAreaTarget(pos + 2 × forward, 6, 3)` that is more than 1 m from that point toward it (`RPC_AddDamage(1, −1, 0, 0, dir)`, `:37441-37490`), and hits every target in `FindRecTarget(pos + 0.5 × forward, forward, 2, 2, 3, 3)` (4 m wide, 3 m long, 3 m tall) once with `hit(434, t, 3 × ATK + talAdjust(100), KO 10, 0, 6 × away)` (`:37399-37422`).

### chm_bugSlayer1 / chm_tailSlayer2 / chm_elementalSlayer3 / chm_machineSlayer4 (Slayer, #341-344) (verified 2026-09-27, re-checked 2026-10-01)

- MP 12, SP −24 (red), target enemy; Lv/Bn 16/4, 20/8, 24/12, 28/16. Each has its own cooldown key `"slayer" + sLv`, `agiAdjust(90)` (`Chameleon.cs:30820`), so the four can be chained. Cast `magAdjust(2 + 0.5 × ImprovedSlayerLv)` (`:30401-30422`), only when the target is closer than `24 + 4 × FR` (`:7571`).
- `RPC_slayer_fire` (`:31274-32144`): line `FindRecTarget(pos + forward, forward, 0.4 + 0.15 × Imp, 0.4 + 0.15 × Imp, 24 + 3 × FR, 10)` (`:31455`); per target `hitDmg = (int)((0.3 + 0.15 × Imp) × ATK + talAdjust(20 + 10 × Imp))`, KO 5 (`:31488-31493`, recomputed per target); `× 2` when the target's race matches `sLv` (1 Bugs/Plants, 2 Tails, 3 Elementals, 4 Robots) or it has `slayerMark` (`:31495-31610`), then `hit(320 + sLv, …)`; All Slain list on a landed hit.
- Details and the race table are in the 2026-09-27 section further down; unchanged.

### chm_improvedSlayer1-4 (Improved Slayer, #351-354) (verified 2026-10-01)

- Passive, Lv/Bn 20/12, 24/15, 28/18, 32/21. `getImprovedSlayerLv()` 0-4 (`Chameleon.cs:9501-9553`). Slayer: cast +0.5 s/lv, `(0.3 + 0.15 × lv) × ATK + talAdjust(20 + 10 × lv)`, line half-width `0.4 + 0.15 × lv`. All Slayer: cast +1 s/lv, `(0.6 + 0.3 × lv) × ATK + talAdjust(20 + 20 × lv)`, target cap `4 + lv`.
- **Tooltip discrepancy:** English "+50/100/150/200% damage" is close for the ATK term only; Thai "+10 dmg" at every rank does not match.

### chm_allBugSlayer1 / chm_allTailSlayer2 / chm_allElementalSlayer3 / chm_allMachineSlayer4 (All Slayer, #361-364) (verified 2026-09-27, re-checked 2026-10-01)

- MP 24, SP −36 (red), instant; Lv/Bn 24/15, 27/18, 30/21, 33/24. Own cooldown key `"allSlayer" + sLv`, `agiAdjust(240)` (`Chameleon.cs:32425`). Cast `magAdjust(4 + Imp)` (`:32381`); fires at `castTime + 0.7 s`.
- `RPC_allSlayer_fire` (`:32805-34044`): `FindAreaTarget(self, 40, 10)` (`:33216`); a target is hit only if its race matches `sLv` or it has `slayerMark`, it is on the caster's screen, and fewer than `4 + Imp` targets were hit (`:33259-33405`): `hit(360 + Imp, t, (int)((0.6 + 0.3 × Imp) × ATK + talAdjust(20 + 20 × Imp)), KO 5, …)` (`:33249-33303`). No ×2.

### chm_allSlain1-2 (All Slain, #371-372) (verified 2026-10-01)

- MP 32/40, SP −45/−50 (red), Lv/Bn 35/23, 40/25, instant. CD `agiAdjust(300)` (`Chameleon.cs:34480`). The card's former MP 32/45, SP 45/60 were wrong.
- **List (`addAllSlainList`, `:9983-10060`):** a target is added once (no duplicates, never a `Structure`) when hit by Charge Attack (`:17042`), Quick Fire (`:19628`, `:19747`, `:19920`), Mass Shot (`:22591`), Poison Volley (`:23350`), Torment Rain (`:26073`), Right Stride (`:28365`), Slayer (`:31538`), All Slayer (`:33309`), or a Combo / Clear Arrow when All Slain is learned (`Chameleon_nAttack.cs:791-799`, `hasSkill(371)`). Zero Shot, Thunder Dragon and the stride clone do not add.
- **Cast (`RPC_allSlain`, `:34044-34709`):** every object still in the list takes `hit(370 + sLv, t, talAdjust(100 × sLv), KO 0, …)` (`:34377`), no range limit, then the list is cleared (`:34393`).
- **Tooltip discrepancy:** rank 2 "150 damage"; code `talAdjust(200)`.

### chm_markOfSlayer5 (Mark of Slayer, #443) (verified 2026-10-01)

- MP 45, SP −45 (red), Lv 85/Bn 6, target enemy. Cast `magAdjust(7)`, CD `agiAdjust(150)` (dispatcher `Chameleon.cs:18351-18362`).
- `RPC_markOfSlayer_cast` (`:36564-36976`): the selected target gets `RPC_AddStatus("slayerMark", 5, Damage.getDebuff(30, cha, targetCha), 0, …)` (`:36792`). `slayerMark` (Debuff + Magical) is read only by the Slayer/All Slayer race checks (above).

### chm_thunderDragon5 (Thunder Dragon, #444) (verified 2026-10-01)

- MP 50, SP −50 (red), Lv 85/Bn 6, instant. CD `agiAdjust(90)` (`Chameleon.cs:38225`; also pre-set at mission start, `:89`). Removes the Chameleon's own `blend` and `invisible` (`:38260-38265`).
- `RPC_thunderDragon` (`:37784-38604`): 6 ticks 0.5 s apart (`:38305`); each tick every enemy in `FindAreaTarget(self, 3, 3)` takes `RPC_AddEffectDamage(444, 50, …)` and, on `lckAdjust(12) > Random.Range(0,100)`, `paralysis` 1 for `getDebuff(3, cha, targetCha)` (`:38441-38465`). The paralysis is on these ticks, not on the reflect.
- **Reflect:** in the Chameleon's `RPC_AddDamage`, while `myCommand == "thunderDragon2"` and `nDamage > 0`, the attacker takes `RPC_AddEffectDamage(444, 350, …)` (`CharacterControl.cs:4618-4627`), once per direct hit.
- **Tooltip:** "3 sec, 100 dps, 12% paralysis, 350 dmg/hit" matches.


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
| thunderDragon | 1 | 50 MP, 50 SP (red) | flat `50`/tick self-AoE, **real effect damage** (`RPC_AddEffectDamage`, ignores defense, floors hitMod) + separate flat-350 reflect, not merged | 0 | 6 | — | **12% paralyze/tick, caster-LCK only, unconditional** |

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

## Follow-up, 2026-09-27: Slayer / All Slayer split into 8 race cards; race logic re-verified

User: "Bug Slayer / Tail Slayer / Elemental Slayer / Machine Slayer and All Bug Slayer / All Tail Slayer / All Elemental Slayer / All Machine Slayer get their own separate cards." The two combined Max-Rank-4 cards (`chameleon_slayer`, `chameleon_allSlayer`) are replaced by 8 Max-Rank-1 cards: `chameleon_bugSlayer`, `chameleon_tailSlayer`, `chameleon_elementalSlayer`, `chameleon_machineSlayer`, `chameleon_allBugSlayer`, `chameleon_allTailSlayer`, `chameleon_allElementalSlayer`, `chameleon_allMachineSlayer`. They are separate skills in every respect that matters to a player: own reqLv/reqBn, own race, and **own cooldown key** (`addTimeOut("slayer" + sLv, …)`, `Chameleon.cs:30820`; `"allSlayer" + sLv`, `:32425`), so all four of a family can be cast back to back.

| Skill | reqLv / reqBn | Race (`eRace`) |
|---|---|---|
| `chm_bugSlayer1` | 16 / 4 | Bugs or Plants |
| `chm_tailSlayer2` | 20 / 8 | Tails |
| `chm_elementalSlayer3` | 24 / 12 | Elementals |
| `chm_machineSlayer4` | 28 / 16 | Robots |
| `chm_allBugSlayer1` | 24 / 15 | Bugs or Plants |
| `chm_allTailSlayer2` | 27 / 18 | Tails |
| `chm_allElementalSlayer3` | 30 / 21 | Elementals |
| `chm_allMachineSlayer4` | 33 / 24 | Robots |

Slayer: MP 12, SP 24 consumed, `mode = target`; All Slayer: MP 24, SP 36 consumed, `mode = instant` (`scripts/decode_skilldata.py`). Cast time `magAdjust(2 + 0.5×ImprovedSlayerLv)` / `magAdjust(4 + ImprovedSlayerLv)` (`:30406`, `:32381`).

- **Slayer race bonus** (`$RPC_slayer_fire`, `Chameleon.cs:31464-31610`, junk predicates evaluated): raw `hitDmg = floor((0.3 + 0.15×Imp)×ATK + talAdjust(20 + 10×Imp))`, KO 5; if the target's `Race` matches `sLv` (1 Bugs/Plants, 2 Tails, 3 Elementals, 4 Robots) **or** it has `slayerMark`, `hitDmg *= 2` before `hit(320 + sLv, …)`; otherwise the arrow still hits for the normal amount. App: `dmgMultDep: CHAMELEON_SLAYER_MATCH_DEP` (`mult: 2`, default on).
- **Slayer cast range:** the cast only starts if the target is closer than `24 + 4 × getFarReachLv()` m (`Chameleon.cs:7571`; Far Reach #131-#134 → level 0-4), i.e. 24-40 m. App: `descDep: CHAMELEON_FARREACH_DEP` makes the range in `desc` follow the Far Reach toggle.
- **All Slayer is a race filter, not a bonus** (correcting the summary table's "same as slayer"): `$RPC_allSlayer_fire` (`Chameleon.cs:32805+`, scan `FindAreaTarget(self, 40, 10)`, `:33216`) hits a target only if its `Race` matches `sLv` **or** it has `slayerMark` (`:33270-33405`), it is on the caster's screen (`Math.isOnScreen`), and fewer than `4 + ImprovedSlayerLv` targets have been hit so far (`:33259`). There is **no ×2**: the hit is `hit(360 + Imp, target, floor((0.6 + 0.3×Imp)×ATK + talAdjust(20 + 20×Imp)), 5, …)`. The cast also marks eligible on-screen targets with `RPC_allSlayer_mark` (`:32590-32645`).
- **`slayerMark`** (Debuff + Magical, `StatusData.cs:5723`, `:7430`) is read only by those three race checks (`Chameleon.cs:31602, 32630, 33399`); Mark of Slayer applies it at Lv 5 with `Damage.getDebuff(30, …)` duration (`:36792`). Added to `STATUS_CLASS_MAP` / `STATUS_DESC_MAP`.
- Compat: all 8 cards link to Improved Slayer and Mark of Slayer, and both link back.

## Follow-up, 2026-09-27: Far Reach verified; Slayer is a piercing line

### chm_farReach1-4 (#131-#134) — passive (verified 2026-09-27)

- **Metadata:** reqLv/reqBn 8/4, 16/6, 24/8, 32/10; MP 0, SP 0; `mode = passive` (`scripts/decode_skilldata.py`). `getFarReachLv()` returns 4/3/2/1/0 for `hasSkill(134/133/132/131)`/none (`Chameleon.cs:8716`).
- **Every read of `getFarReachLv()`:**

| Skill | Effect | Formula | Source |
|---|---|---|---|
| Combo (`RPC_nAttack_fire`), Clear Arrow (`RPC_clearArrow_fire`) | arrow `ProjectileControl.life` | `(0.4 + 0.1×FR) × rangeMod` s | `Chameleon.cs:8470`, `:9006` |
| Quick Fire | cast-range gate | `< 18 + 4×FR` m | `:8232` |
| Quick Fire | shot raycast distance | `20 + 4×FR` m | `:19467` (used `:19577`, `:19702`, `:19869`) |
| Right Stride | cast-range gate | `< 18 + 4×FR` m | `:7754` |
| Right Stride | shot / double-shot `RaycastAll` | `20 + 4×FR` m | `:28342`, `:28392` |
| Left Stride | cast-range gate only | `< 18 + 4×FR` m | `:7834` |
| Slayer (all 4) | cast-range gate | `< 24 + 4×FR` m | `:7571` |
| Slayer (all 4) | arrow line length | `24 + 3×FR` m | `:31455` |

- All Slayer does not read it (fixed 40 m scan). **Normal-attack / Clear Arrow range (verified):** both prefabs (`Effects/nAttack`, `Effects/clearArrow`) carry `Chameleon_nAttack`, whose `Awake()` sets `rigidbody.velocity = forward × 30` (`Chameleon_nAttack.cs:34`) and whose `Init()` raises it to **40** when the owner has Bow Mastery (`hasSkill(401)`, `:100`); `FixedUpdate()` destroys the arrow once its age reaches `ProjectileControl.life` (`:53-62`). Range = speed × life = `30 × (0.4 + 0.1×FR) × rangeMod` = **12 + 3×FR m** (12 / 15 / 18 / 21 / 24 m), or **16 + 4×FR m** with Bow Mastery (16 … 32 m); `rangeMod` is 1 unless a status changes it (`CharacterControl.cs:154`). The client's "+4/8/12/16 m" (`ChameleonSkill_eng.cs:136-169`) is only right with Bow Mastery. The Thai client text says "+4 m" at every rank (`ChameleonSkill_thai.cs:134-167`), a stale string.
- App: card `chameleon_farReach` (`passive: true`, per-skill `desc` lines, `compatSkills` to the 9 cards above, each linking back).

### Slayer hits every enemy in a line (correction)

`$RPC_slayer_fire` collects targets with `Damage.FindRecTarget(pos + forward, forward, 0.4 + 0.15×Imp, 0.4 + 0.15×Imp, 24 + 3×FR, 10, layer)` (`Chameleon.cs:31455`) and runs the race / `slayerMark` ×2 check and `hit(320 + sLv, …)` for **each** target in that list (`:31464-31610`): a piercing line of width `0.4 + 0.15×ImprovedSlayerLv` m, not a single-target shot (the summary table's "1/target" means one hit per target). Because the cast gate (`24 + 4×FR`) grows faster than the line (`24 + 3×FR`), at Far Reach ≥ 1 a target near the edge of cast range can be selected but not reached (at FR 4: cast ≤ 40 m, line 36 m). The Slayer card `desc` now says this.

## Open items / could not verify

None outstanding — every one of the 24 active skills was checked for damage/KO/hit-count/dep/lckProc and
reported above, either with a real citation or a confirmed "no damage" finding.

See `player-reference-tool/CLAUDE.md`'s own dated section for the full implementation narrative
(engine reuse, icon extraction, verification detail).

## Server Balance Variations

| Skill | Original BigBug baseline | TTO delta |
|---|---|---|
| Torment Rain | `(int)(0.5 × ATK + talAdjust(60))` per target (`Chameleon.cs:26039`). | Damage is plain 100% of ATK, no `talAdjust` term (user-reported 2026-09-30; card `servers.tto`: `dmg "0"`, `atkCoeff 1`). |
| Double Effect | Poseidon Bow +12% / Poseidon Helmet +8% HP Drain chance goes through `lckAdjust(doubleEffect × pool)` (`Chameleon.cs:47620-47630`). | Flat 20% for the full set, 40% with Double Effect, no `lckAdjust` (user-reported 2026-09-28, see [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md); card `servers.tto.changeNote`). |
