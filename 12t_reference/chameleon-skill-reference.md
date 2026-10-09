# Chameleon — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| immunity | Immunity | 2 | 120 | true | false | 12 | true |
| skinShift | Skin Shift (shares the `immunity` key) | 1 | 120 | true | false | — | — |
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
| slayer1-4 | Bug Slayer / Tail Slayer / Elemental Slayer / Machine Slayer (one key each) | 1 each | 90 | true | false | — | — |
| allSlayer1-4 | All Bug / All Tail / All Elemental / All Machine Slayer (one key each) | 1 each | 240 | true | false | — | — |
| allSlain | All Slain | 2 | 300 | true | false | — | — |
| rustyDecay | Rusty Decay | 1 | 90 | true | false | — | — |
| tent | Tent | 1 | 240 | true | false | — | — |
| markOfSlayer | Mark of Slayer | 1 | 150 | true | false | — | — |
| zeroShot | Zero Shot | 1 | 60 | true | false | — | — |
| thunderDragon | Thunder Dragon | 1 | 90 | true | false | — | — |

## Citations

The judgment calls below are from the 2026-08-12 cooldown pass. Where they disagree with the per-skill entries under "# Damage & Mechanics" (Immunity and Skin Shift are separate cards; each Slayer has its own card and cooldown key; Thunder Dragon's paralysis comes from its area ticks, not from the reflect), the per-skill entries are current.

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
- **Arrow:** `ProjectileControl.life = (0.4 + 0.1 × FarReach) × rangeMod` (`:8482`); `Chameleon_nAttack.Awake` speed 30 m/s, 40 m/s with Bow Mastery (`Chameleon_nAttack.cs:34`, `:100`); destroyed on the first enemy it touches. Flight distance 12 + 3 × FR m (16 + 4 × FR with Bow Mastery). **The arrow does not start at the Chameleon (re-checked 2026-10-08, a user report that the range is longer than the card said):** `RPC_nAttack1` spawns it at `mPos + (0, 1.5, 0) + transform.forward` (`Chameleon.cs:15586`), i.e. **1 m in front of the body and 1.5 m up**, aimed at the target from there (`fireDir = tDir − (0, 1.5, 0) − forward`, `:15591`; Clear Arrow is the same call; Left Stride spawns at local `(−0.38, 1.2, 1)` and its second arrow at `(0.4, 1.2, 1)`, `:26949`, `:27010`: also 1 m forward), and the 1 m is not scaled by `rangeMod`. Reach from the Chameleon = `1 + (12 + 3 × FR) × rangeMod` m (`1 + (16 + 4 × FR) × rangeMod` with Bow Mastery), and the hit lands when the arrow's trigger touches the target's collider, so a big target is hit that much earlier (its CharacterController radius is on the monster stats page; the arrow prefab's own collider size is not in the decompiled code). The lifetime is counted in `FixedUpdate` steps (`age += Time.deltaTime`, `Chameleon_nAttack.cs:53-62`), so the flight can fall short of `speed × life` by up to one physics step, never beyond it; `ProjectileControl` has no lifetime logic of its own (`:72` only holds the field).
- **Damage (`Chameleon_nAttack.OnTriggerEnter`, `Chameleon_nAttack.cs:496-688`):** `num = FloorToInt((0.45 − 0.025 × Combo) × ATK) + 6 × fatalStrikeStatusLv + 6 × PiercingVenomLv × target poison lv` (`:502`); Bow Mastery (#401) `num += floor(0.1 × Lv)` (`:505-511`). Coefficient 0.425 / 0.4 / 0.375 / 0.35 ATK at Combo 1-4.
- **Crit (`:517-668`):** chance sum = weapon `w_chm43`/`w_chm44` (G.Marshal Bow B/R) +4, `w_chm48` (Mantis Bow R) +5; armor `a_chm48` (Mantis Suit R) +4; hat `c_chm48` (Mantis Hat R) +3; Critical Plus `4 × lv + 4`. The armor/hat checks list `a_chm43`/`c_chm43` twice, which are not items (no entry in `ArmorData.cs`/`AccessoryData.cs`). Champion gear (`w_chm58`, `a_all58`, `c_all58`) and Marshal armor/hat (`a_all43/44`, `c_all43/44`) are not in this table, and `Chameleon.getCritPlus` (`Chameleon.cs:14658`, the Marshal/Champion table other classes use) has no caller in any Chameleon file. Roll `Random.Range(0,100) < lckAdjust(sum)` → `CeilToInt(num × 1.8)`, or `CeilToInt(num × (1.8 + 0.15 × CriticalPlusLv))` with Bull's Eye (#413) (`:643-668`). Rounding is **up**, unlike the `getCritPlus` floor.
- **Hit:** `hit(1 + Combo, target, num, KO 1, hate floor(−0.5 × num × clearLv), 0.15 × forward)` (`:688`), force 1.5 × forward with `w_chm59` Power Bow (`:415-421`). On a landed hit: `onNormalAttackHit`, `sp++`, then the Poison Arrow roll (see Poison Arrow) and All Slain list (#371) (`:696-799`).
- **Tooltip:** "decrease its damage by 5/10/15/15%" (`ChameleonSkill_eng.cs:37-70`); the code is 0.45 → 0.425/0.4/0.375/0.35 (−5.6/−11/−17/−22%), the Thai rank 4 "20%" is closer.
- **Card:** `rawModel` (`chameleonComboParts`) with Bow Mastery, Fatal Strike 0-5 (rank 5 = Fatal Strike 4 + Extra Arrows, status level 5), Piercing Venom (rank 2 = Deadly Venom) × target poison level, Critical Plus 0-5 (rank 5 = Critical Plus 4 + Bull's Eye, ×2.4) and the crit gear as header deps (Combo and Left Stride; merged 2026-10-05, user request, since both Class C passives sit on top of rank 4); crit drawn as ⌈…⌉. The Fatal Strike card keeps its own Extra Arrows toggle.

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
- **Targeting (verified 2026-10-06, a fan report):** the skill data says `mode: instant`, `target: enemy`, but GameGui's ally / enemy layer check only runs for `eSkillMode.target` (`GameGui.cs:37884-37919`); an instant skill sends whatever is selected (`:37726-37752`), and the ally-cycle key selects the player first (`:2214`). So Venom Shock can be cast on an ally or on yourself as a 12 s poison block, but a target that already has `poison` with more than 1 s left takes the detonation (Effect Damage) first.

### chm_rustyDecay5 (Rusty Decay, #432) (verified 2026-10-01)

- MP 24, SP −30 (red), Lv 75/Bn 4, needs a target. CD `agiAdjust(90)` (`Chameleon.cs:35656`). `RPC_AddStatus("rustyDecay", 2, 12, 0, …)` (`:35523`).
- **Status `rustyDecay`** (Debuff `:7424` + Physical `:5475`), apply `CharacterControl.cs:37142-37200`: `CeilToInt(0.25 × 1.5 × 15 × rustLv × secondsLeft)` Effect Damage when `rust` has more than 1 s left, then `rust` is removed; blocks new `rust` for 12 s. The level is fixed at 2, so it is always 150%.
- **Passive part:** Poison Arrow adds 2 levels per proc instead of 1, and gives Robots `rust` (`Chameleon_nAttack.cs:741`, `:762-783`).

### chm_doubleEffect5 (Double Effect, #431) (verified 2026-10-01)

- Passive, Lv 75/Bn 4. In `onNormalAttackHit` (`Chameleon.cs:47330-47735`, called only from the Combo/Clear Arrow projectile, `Chameleon_nAttack.cs:702`) `doubleEffect = 2`: it multiplies the base chance (inside `lckAdjust`) of Heart Bow charm, Plunger Bow sticky, Salamander Bow burn, Golden Bow heavy, Time Bow restore and the Mummy (plague) / Frozen (MP drain) / Poseidon (HP drain) pools, and doubles the charm, sticky, burn, heavy and plague durations. Paper Bow `happy3` (`lckAdjust(12)`), BD Bow heal (`lckAdjust(3)`) and Demonic Bow (flat 13%) are not multiplied.
- TTO: the Poseidon set HP Drain is a flat 20% (40% with Double Effect), see Server Balance Variations.

### chm_immunity1-2 (Immunity, #121-122) (verified 2026-10-01)

- MP 3/5, Lv/Bn 6/2, 12/4, instant, self. CD `agiAdjust(120)` (`Chameleon.cs:19009`).
- `RPC_immunity` (`Chameleon.cs:18689-19240`): `RPC_AddStatus("immunity", 2 × sLv + (SkinShift #421 ? 1 : 0), chaAdjust(12), 0, …)` (`:18876`) → level 2/4, 3/5 with Skin Shift learned. Status `immunity` is in [12Tails-Mechanics-Reference.md §4.2](12Tails-Mechanics-Reference.md#42-status-classification-cleanse-system-statusdatacs) (blocks statuses of level ≤ its own, buffs included).
- **Fatal Strike gate:** `doSkill` refuses Fatal Strike ("Cannot add fatalStrike while immune") and returns the MP/SP when `getStatusLv("immunity") >= FatalStrikeLv + (ExtraArrows #403 ? 1 : 0)` (`Chameleon.cs:7904`).
- **Tooltip:** Thai "Immunity2/4" matches; English "immune1 … lv2" is off by one rank.

### chm_skinShift5 (Skin Shift, #421) (verified 2026-10-01)

- MP 10, SP −10 (red), Lv 70/Bn 3, instant. Shares the `immunity` cooldown key: `addTimeOut("immunity", agiAdjust(120))` (`Chameleon.cs:34978`).
- `RPC_skinShift` (`:34709-35336`): collects every status in `mStatusList` that is **not** `isSystemStatus` (debuffs and buffs alike, including its own `immunity`) and removes them, then the owner client takes `RPC_AddDamage(1, CeilToInt(0.1 × hp), …)` (`:35150-35229`) — direct damage, so the target's `hitMod` applies. It gives no status of its own; the "+1 Immunity level" is the passive hook in `RPC_immunity` (`:18876`).
- **State gate (verified 2026-10-06, a fan report):** `doSkill` checks Skin Shift **before** the usual standby/run gate and only refuses `actionState == "attack"` or `"dead"` (`Chameleon.cs:6387-6418`, junk predicates evaluated). So it fires while knocked down (`ko`), but pressed while casting / attacking it does nothing, and the MP/SP is still spent: GameGui sends `doSkill` and then deducts the cost with no refund (`GameGui.cs:37929-37980`, see [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md) §3.1). No cooldown starts in that case (it is set inside `RPC_skinShift`).
- **Knockdown restart (BB bug, verified 2026-10-06):** `RPC_ko` sets `ko = 0`, `actionState = "ko"` and plays `ko` (`:46325-46367`), waits 3 s, then **exits without getting up if the state is no longer `ko`** (`:46256-46262`); only the get-up path refills `ko = mko` (`:46305`). Skin Shift sets `actionState = "attack"` (`:34969`) and `standby` ~0.6 s later (`:34917`), so the knockdown aborts with `ko` still 0, and the Update check (`ko <= 0` and not `ko` / `dead` → `RPC_ko`, `:474-509`) starts a **fresh knockdown** (fall + 3 s + 1 s get-up). Statuses are still removed and the cooldown runs. Card: `bbBug`.

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
- **Pets (verified 2026-10-08):** Mass Invisibility does **not** reach cosmetic pets, and neither does any other source of `invisible` (Rabbit potion `Rabbit_potion.cs:378`, True Invisibility). The status apply hides only `gameObject.GetComponentsInChildren(Renderer)` of the target character (`CharacterControl.cs:32494-32672`, FX `Chameleon/Effects/invisible` at `:36942-36950`). The pet is instantiated unparented by `<Class>Equipment.EquipPet` (`RabbitEquipment.cs:4930`), is not a child of the character, has no `CharacterControl` and is not tagged `Player`, so it is outside both the renderer list and the team-container loop. Only the `hide` status hides the pet (`CharacterControl.cs:32861-32867` sends `OnParentHide`; unhide `:14581-14587`). Erase Senses (#412) changes nothing here: its `invisible` branch (`CharacterControl.cs:32515-32556`) only switches the Chameleon's own renderer list (for viewers on another layer than the local player) from the `FX/Camaflage` shader to `enabled = false`, the same as on `blend`; its other `hasSkill(412)` hits are the duration terms (`Chameleon.cs:20687`, `:21155`). A pet that vanishes with Mass Invisibility is not explained by the code.

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
- **Code vs tooltip:** the hit passes hate `floor(−0.5 × num)` (`Chameleon_nAttack.cs:688`), but `hit()` clamps it with `hateAdjust` to 0-999 (`CharacterControl.cs:3556`, `:20509-20511`) before `RPC_AddDamage` adds `damage + 10 × KO` (`:3771`), so a Clear Arrow makes the same hate as a normal arrow. The "no hate" tooltip is not achieved by this code (confirmed live by the user 2026-10-09).

### chm_tent5 (Tent, #433) (verified 2026-10-01)

- MP 40, SP −30 (red), Lv 75/Bn 4, instant. Cast `magAdjust(6)`, CD `agiAdjust(240)` (dispatcher `Chameleon.cs:18334-18345`).
- `RPC_tent_cast` (`:35950-36564`): channel `castTime = magAdjust(12)` with a cast bar and `RPC_AddStatus("tent", 5, (int)castTime, 0, …)` (`:36128-36151`). When the channel completes (`actionTime + castTime + 0.5`, `:36280`): `RPC_AddHeal(433, mhp, mmp, 0, 0, 0, …)` (full HP and MP, no SP/KO), `resetTimeOut()` (clears every cooldown, `CharacterControl.cs:20376-20378`) and `resetHate()` (`Chameleon.cs:36320-36335`).
- **Status `tent`:** Buff (`StatusData.cs:6692`) + State (`:4920`); only a Chameleon can receive it (`CharacterControl.cs:12436`). `moveSpeed = 0`, `myForce = 0` (`:2375-2386`); `sleep` is rejected (`:11406`); zzz emote every 3 s (`:9274`). **In the direct-damage coroutine every hit taken while in `tent` becomes `nDamage = mhp`** (`CharacterControl.cs:31050-31060`, the per-status switch), so any direct hit kills a full-HP Chameleon (Effect Damage is not affected). Confirmed live by the user 2026-10-09 (damage during the tent kills). **Which hits reach the rule (traced 2026-10-09, [12Tails-Mechanics-Reference.md §2.9](12t_reference/12Tails-Mechanics-Reference.md)):** it sits inside `if (nDamage > 0)` of the `AddDamage` coroutine, so by the code any hit that lands through `hit()` kills (`defAdjust` is floored at 1, so even a raw-0 skill arrives as 1), and so does any direct `RPC_AddDamage` with damage; it does **not** run for MISS / EVADE / RESIST / IMMUNE / DEFLECT / REFLECT / CONFUSE (action codes −81 to −87 end the coroutine before the status switch, `:30688-30766`), for `noDamage` / `recieveDamage == false`, or for Effect Damage (`RPC_AddEffectDamage`, a separate path). **Live vs code:** the user observed that a Whale's Honor taunt, a direct `RPC_AddDamage(-1, 0, 0, hate, …)` with damage 0 (`Whale.cs:23914`), also kills a tented Chameleon, which the `> 0` gate does not predict (live observation takes precedence; mechanism unknown, so resist / immune on a tented Chameleon is untested live). Re-checked 2026-10-09: the gate is a strict `nDamage > 0` (`CharacterControl.cs:30821`; its block, matched by braces, runs to `:31626` and holds the only status loop and the only `tent` case), so a 0 is excluded; and hate does not make a hit: `nHate` never touches `nDamage` and is only used at the end for `addHate` (`:32144-32200`), `RPC_AddDamage` only raises it from damage and KO (`:3771`), and a taunt such as Honor calls `RPC_AddDamage` directly, never `hit()` (only attackers call `hit()`).
- **If the `tent` status is removed, and knockdown (traced 2026-10-09, code only, not live-tested):**
  - **Kill rule needs the status:** the max-HP rewrite is a case of the `AddDamage` status loop over `mStatusList` (`CharacterControl.cs:30832`, `:31050`), so once the status is gone the Chameleon takes normal damage. The status can be removed by a **Dissolute** (apply-time purge of every `isBuff()` + `!isSystem()` status with `sLv <= d + 2`, State buffs included, `CharacterControl.cs:40160`; Tent is level 5, so `d >= 3`); **Dispell cannot**, it only purges Magical statuses and `tent` is only Buff + State (`StatusData.cs:4920`, `:6692`). Nothing in the engine removes `tent` by name.
  - **Completion does not read the status:** `Chameleon.cs` never calls `hasStatus` / `getStatus` for `tent`; the channel runs on `actionState == "attack"` and `myCommand == "tent"` (`:36053`, `:36118`, `:36166`, `:36217`) and the timer `actionTime + castTime + 0.5` (`:36280`), then `RPC_AddHeal(mhp, mmp)`, `resetTimeOut()`, `resetHate()` (`:36320-36335`). The status is added about 0.9 s into the channel (`Yield 0.4 s` + `0.5 s`, `:36535`, `:36526`) with `sTime = (int)castTime` (`:36139`), so it normally ends within about ±0.5 s of the completion. Removing it therefore leaves the reset intact. **The Chameleon cannot walk off after losing the status** (checked again 2026-10-09; an earlier note here said it could, which was wrong): the movement-input handler `PlayerControl()` only runs while `actionState` is `standby` or `run` (`Chameleon.cs:282-303`, the gate jumps over it otherwise), and the tent keeps `actionState == "attack"`, the same as any other cast, so input never reaches it. The status's own lock (`ApplyMovement`: `moveSpeed = 0`, `myForce = 0`, `CharacterControl.cs:2375-2386`) is therefore redundant for input; what it adds is cancelling **knockback force** (`myForce`) while it lasts.
  - **Knockdown is possible:** Tent is not in the list of statuses that zero KO (petrify, iceShield, snowMan, snowBall, cosmicRift, cosmicFriday, noKo, nemesisLarva, `:31068-31585`), and `ko` just drops by the accumulated `myKo` each frame (`ApplyKo`, `:2223`). At `ko <= 0` the Chameleon's own check starts `RPC_ko` unless it is already `ko` / `dead`, with no Tent exception (`Chameleon.cs:474-500`); `RPC_ko` sets `actionState = "ko"`, `myCommand = "none"`, `moveSpeed = 0` (`:46349`, `:46355`, `:46361`), which are exactly the channel's two conditions, so the tent is **cancelled with no HP / MP refill, cooldown reset or hate clear**. `RPC_ko` does not remove the status, so the Chameleon stays one-shot-able until the status ends. KO reaches it without killing through **Effect Damage** (`AddEffectDamage` adds `myKo` and `myForce`, has no Tent case, `CharacterControl.cs:6559`, `:6972`) and through direct calls with damage 0 and KO > 0 (they skip the `nDamage > 0` block). Knockback is blocked while the status is active (`myForce = 0` every frame).
- **Tooltip discrepancy:** the Thai tooltip says the tent cures abnormal status and restores HP, MP and CD (`ChameleonSkill_thai.cs:1021`); the English one says "removing all negative status … refill hp mp and sp" (`ChameleonSkill_eng.cs:1023`). In code no status is removed (the card's tooltip note), HP / MP / cooldowns are restored, and SP is not (English only, so not on the card).

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


---

## Earlier verified sections (still current)

Kept from the 2026-09-27 pass; the per-skill entries above point here. The 2026-08-21 summary table, "Notable findings" and the dated follow-up notes that stood here were removed on 2026-10-01: their mechanics are now in the per-skill entries, several of their values were wrong (Poison Volley, Venom Shock, Perfect Blend, True and Mass Invisibility, Needle Prison, Left/Right Stride, Camp Fire, Blood Burn and All Slain costs; Quick Fire, Blood Burn cooldowns; cast times), and the rest was app UI history, which lives in git.

### Slayer races and cooldown keys (verified 2026-09-27)

Each of the eight Slayer cards is its own skill: own reqLv/reqBn, own race, own cooldown key (`"slayer" + sLv`, `Chameleon.cs:30820`; `"allSlayer" + sLv`, `:32425`).

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

- `slayerMark` (Debuff + Magical, `StatusData.cs:5723`, `:7430`) is read only by the three race checks (`Chameleon.cs:31602`, `:32630`, `:33399`). All Slayer also marks eligible on-screen targets with `RPC_allSlayer_mark` (`:32590-32645`, visual).
- Slayer is a piercing line, not a single-target shot. Because the cast gate (`24 + 4 × FR`) grows faster than the line (`24 + 3 × FR`), at Far Reach ≥ 1 a target near the edge of cast range can be selected but not reached (FR 4: cast ≤ 40 m, line 36 m).

### Far Reach (#131-134) reads (verified 2026-09-27)

- Passive, Lv/Bn 8/4, 16/6, 24/8, 32/10.
- **Every read of `getFarReachLv()`:**

| Skill | Effect | Formula | Source |
|---|---|---|---|
| Combo (`RPC_nAttack_fire`), Clear Arrow (`RPC_clearArrow_fire`) | arrow `ProjectileControl.life` | `(0.4 + 0.1×FR) × rangeMod` s | `Chameleon.cs:8482`, `:9018` |
| Quick Fire | cast-range gate | `< 18 + 4×FR` m | `:8232` |
| Quick Fire | shot raycast distance | `20 + 4×FR` m | `:19467` (used `:19577`, `:19702`, `:19869`) |
| Right Stride | cast-range gate | `< 18 + 4×FR` m | `:7754` |
| Right Stride | shot / double-shot `RaycastAll` | `20 + 4×FR` m | `:28342`, `:28392` |
| Left Stride | cast-range gate only | `< 18 + 4×FR` m | `:7834` |
| Slayer (all 4) | cast-range gate | `< 24 + 4×FR` m | `:7571` |
| Slayer (all 4) | arrow line length | `24 + 3×FR` m | `:31455` |

- All Slayer does not read it (fixed 40 m scan). **Normal-attack / Clear Arrow range (verified):** both prefabs (`Effects/nAttack`, `Effects/clearArrow`) carry `Chameleon_nAttack`, whose `Awake()` sets `rigidbody.velocity = forward × 30` (`Chameleon_nAttack.cs:34`) and whose `Init()` raises it to **40** when the owner has Bow Mastery (`hasSkill(401)`, `:100`); `FixedUpdate()` destroys the arrow once its age reaches `ProjectileControl.life` (`:53-62`). Range = speed × life = `30 × (0.4 + 0.1×FR) × rangeMod` = **12 + 3×FR m** of flight (12 / 15 / 18 / 21 / 24 m) after a **1 m** spawn offset in front of the Chameleon (`Chameleon.cs:15586`), or **16 + 4×FR m** with Bow Mastery (16 … 32 m); `rangeMod` is 1 unless a status changes it (`CharacterControl.cs:154`). The client's "+4/8/12/16 m" (`ChameleonSkill_eng.cs:136-169`) is only right with Bow Mastery. The Thai client text says "+4 m" at every rank (`ChameleonSkill_thai.cs:134-167`), a stale string.

## Open items / could not verify

1. **Final Entrapment cage:** the code only spawns `Effects/finalEntrapment` with a lifetime and position-syncs characters within 8 m; what blocks enemies is in the prefab (colliders), which the decompiled source does not show. No status is applied.
2. ~~**`invisible` status value**~~ → resolved 2026-10-02: **the value has no effect.** True/Mass Invisibility store `talAdjust(10 × sLv)` / `talAdjust(20 × sLv)` as `sValue`, but a search of every file in `DecompiledSource/` finds no read of it: `getStatusValue(` is only called 3 times, all on other literal statuses (`CharacterControl.cs:19187` definition); `statusClass.isInvisible()` has no caller; `GameGui.cs`, `Damage.cs` and `StatusData.cs` never read `.sValue`; the `invisible` apply / remove handlers (`CharacterControl.cs:36942-36950`, `:16458+`) and the add gates (`:11280-11325`, refused under `fireAvatar` / `earthForm` / `cosmicRift` / `cosmicFriday`) only use the type. Every other reference (monster AI target checks, the equipment files' `removeStatus("invisible")`, `Chameleon.cs:8948` Clear Arrow's `getStatusLv`) checks presence or level.
3. ~~**Zero Shot pull timing**~~ → resolved 2026-10-02: **5 pulls, then 1 hit.** `$RPC_zeroShot` (`Chameleon.cs:37030-37784`): state 0 starts the skill and waits 0.5 s; state 2 sets `i = 0`, state 3 does `i++`, and both fall through (`break`) to `if (i >= 5)` (`:37338`). Below 5 it runs the pull (`FindAreaTarget(pos + 2·fwd, 6, 3)`, `RPC_AddDamage(1, −1, 0, 0, dir)` on targets more than 1 m from the point) and waits 0.1 s; at `i == 5` it fires the hit (`FindRecTarget(pos + 0.5·fwd, fwd, 2, 2, 3, 3)`, `hit(434, 3 × ATK + talAdjust(100), KO 10)`, Chameleon recoils at `moveSpeed −6`) and waits 0.2 s. So the pulls land at 0.5 / 0.6 / 0.7 / 0.8 / 0.9 s and the hit at about 1.0 s after the cast. Card updated.
4. ~~**Crit gear, code vs the Chameleon Simulator**~~ → decided 2026-10-02 (user): BB and TTO keep the code (G.Marshal Bow +4, Mantis Bow R +5, Mantis Suit R +4, Mantis Hat R +3; Champion and Marshal hat/armor nothing); ToT fixed the check, see Server Balance Variations → ToT. The Chameleon Simulator (`CHM_WEAPONS` / `CHM_HELMETS` / `CHM_ARMORS`, Champion +7 / +5 / +6) matches ToT.
5. **Clear Arrow hate:** the hate reduction is clamped to 0 by `hateAdjust`, so a Clear Arrow makes the same hate as a normal arrow, unlike the tooltip. **Confirmed live (user, 2026-10-09): same hate as a normal arrow**, so the code reading is right and the card's tooltip note stands.
6. **Tent:** in code a direct hit while in `tent` deals max-HP damage; finishing restores HP/MP, resets every cooldown and clears hate. **Confirmed live (user, 2026-10-09): taking damage during the tent kills the Chameleon.** Still code-only: the tooltip's status cure is not in code (nothing removes a status), and the English tooltip's SP restore is not in code either; the card's tooltip note lists only the status cure (the Thai tooltip has no SP claim).
7. **Tooltip mismatches (cards follow code; details in each skill entry; since 2026-10-02 each card shows a red `__คำอธิบายในเกม…__` line, rank-gated where only some ranks differ):** Piercing Venom (+4 vs 6), All Slain rank 2 (150 vs `talAdjust(200)`), Erase Senses (+50% vs +4 s), Bow Mastery (+50% vs +33% speed), Added Fire Thai (+30% vs +40%), Needle Prison rank 2 English (2 vs 3 s), Perfect Blend rank 2 (3 vs 4 s), Increased Poison Thai (+2 s every rank), Combo damage-loss percentages.
8. **Defaults:** the new Chameleon passive/gear toggles (Critical Plus, Bulls Eye, Fatal Strike, crit gear, Piercing Venom, …) start off, like every other dep, so Combo shows no crit until they are turned on.

## Server Balance Variations

| Skill | Original BigBug baseline | TTO delta |
|---|---|---|
| Torment Rain | `(int)(0.5 × ATK + talAdjust(60))` per target (`Chameleon.cs:26039`). | Damage is plain 100% of ATK, no `talAdjust` term (user-reported 2026-09-30; card `servers.tto`: `dmg "0"`, `atkCoeff 1`). Hit enemies also get `poison` per Increased Poison / Deadly Venom (user-reported 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tto`). |
| Double Effect | Poseidon Bow +12% / Poseidon Helmet +8% HP Drain chance goes through `lckAdjust(doubleEffect × pool)` (`Chameleon.cs:47717-47729`). | Flat 20% for the full set, 40% with Double Effect, no `lckAdjust` (user-reported 2026-09-28, see [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md); card `servers.tto.changeNote`). |
| Silent Walk | While charging, `moveSpeed = Lerp(moveSpeed, 2, 4 × Time.deltaTime)` (`Chameleon.cs:16579`): walk speed 2, easing rate 4. | Walk speed while charging 2 → 4.5 m/s (user-reported 2026-10-02 as "4 → 4.5"; the user confirmed it means the target speed, since the code's 4 is only the easing rate; server-side, card `servers.tto` on Silent Walk and Charge Attack). |
| Charge Attack | No poison on the volley. | Gets Poison Arrow, Increased Poison and Deadly Venom (user-reported 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tto`). |
| Quick Fire | No poison on the shots. | Gets Poison Arrow, Increased Poison and Deadly Venom (user-reported 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tto`). |
| Bow Mastery (Class C, rank 5 icon) | Combo fires one arrow per attack command (`doNormalAttack`, `Chameleon.cs:5996-6057`). | Holding the attack button keeps firing normal attacks (does not work once Charge Attack is learned), but there is **no auto lock**: the Chameleon keeps its direction and the player must attack again to change it (user-reported 2026-10-08; server-side, not in `DecompiledSource/`; card `servers.tto`). |

### ToT

| Skill | Original BigBug baseline | ToT delta |
|---|---|---|
| Combo crit gear | `Chameleon_nAttack.cs:517-668`: weapon `w_chm43` / `w_chm44` (G.Marshal Bow, Blue / Red) +4, `w_chm48` (Mantis Bow R) +5; armor `a_chm43` +3, `a_chm48` (Mantis Suit R) +4; hat `c_chm43` +2, `c_chm48` (Mantis Hat R) +3. `a_chm43` / `c_chm43` exist nowhere else in the client (the Marshal armor / hat are the shared `a_all43-44` / `c_all43-44`, `ArmorData_eng.cs:59-70`, `AccessoryData_eng.cs:288-299`), and Champion (`w_chm58`, `a_all58`) is never tested, so on BB only the G.Marshal bow and the Mantis R set give crit. | Fixed (user-reported 2026-10-02): Marshal bow +5, Marshal hat + armor +7; Champion bow +7, hat +5, armor +6 (the standard table, matching the Chameleon Simulator's Champion values); Mantis gives no crit. Card: `servers.tot` with `CHAMELEON_TOT_WEAPON_DEP` / `CHAMELEON_TOT_EQUIP_DEP`; `chameleonCritBase()` switches on `currentServer`. BB and TTO keep the code values. The Chameleon attack simulator follows its own server toggle the same way: per-item `crit` / `servers` in `CHM_WEAPONS` / `CHM_HELMETS` / `CHM_ARMORS` (ToT: Marshal 5 / 4 / 3, Champion 7 / 6 / 5; BB / TTO: G.Marshal Bow 4, Mantis Bow / Suit / Hat R 5 / 4 / 3), dropdowns rebuilt on switch. |
