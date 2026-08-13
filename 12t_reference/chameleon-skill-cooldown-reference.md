# Chameleon — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| immunity | Immunity / Skin Shift | 3 | 120 | true | false | 12 | true |
| quickFire | Quick Fire | 4 | 60 | true | false | — | — |
| perfectBlend | Perfect Blend | 2 | 60 | true | false | 4 | true |
| trueInvisibility | True Invisibility | 2 | 90 | true | false | 12 | true |
| needlePrison | Needle Prison | 2 | 60 | true | false | — | — |
| massShot | Mass Shot | 2 | 30 | true | false | — | — |
| poisonVolley | Poison Volley | 2 | 60 | true | false | — | — |
| venomShock | Venom Shock | 2 | 90 | true | false | 12 | false |
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
| rustyDecay | Rusty Decay | 1 | 90 | true | false | 12 | false |
| tent | Tent | 1 | 240 | true | false | 12 | false |
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
- **`tent`'s duration is wrapped by `magAdjust`, not `chaAdjust` — reported `false` in the literal
  chaAdjust column, but it is not a bare/unwrapped literal either.** `Chameleon.cs:36128` —
  `this.$castTime$23070 = this.$self_$23071.mChar.magAdjust((float)12);` — is then reused directly as
  the duration argument at `Chameleon.cs:36139` — `this.$self_$23071.mChar.RPC_AddStatus("tent", 5,
  (int)this.$castTime$23070, 0, this.$self_$23071.mChar.ActorNr);`. The value (`12`) is genuine and
  self-applied (not contested), it just scales with the caster's MAG stat instead of CHA — flagged here
  so the lookup tool doesn't mistake `Duration Wrapped = false` for "flat literal, never scales."
- **`rustyDecay` and `venomShock` use flat literal (non-`chaAdjust`) duration arguments — genuine
  values, `Duration Wrapped = false`.** `rustyDecay`: `Chameleon.cs:35523` —
  `this.$tChar$23053.RPC_AddStatus("rustyDecay", 2, 12, 0, this.$self_$23064.mChar.ActorNr);` (bare `12`,
  confirmed not `chaAdjust`-wrapped). `venomShock`: `Chameleon.cs:23956` —
  `this.$tChar$22726.RPC_AddStatus("venomShock", this.$sLv$22737, 12, 0,
  this.$self_$22738.mChar.ActorNr);` (bare `12`, confirmed not `chaAdjust`-wrapped).
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
- `rustyDecay` Duration: `Chameleon.cs:35523` — `this.$tChar$23053.RPC_AddStatus("rustyDecay", 2, 12, 0, this.$self_$23064.mChar.ActorNr);` (flat literal `12`, confirmed NOT chaAdjust-wrapped)
- `tent` Duration: `Chameleon.cs:36128` — `this.$castTime$23070 = this.$self_$23071.mChar.magAdjust((float)12);`, applied at `Chameleon.cs:36139` — `this.$self_$23071.mChar.RPC_AddStatus("tent", 5, (int)this.$castTime$23070, 0, this.$self_$23071.mChar.ActorNr);` (magAdjust-wrapped, not chaAdjust — see judgment-call note)
- `venomShock` Duration: `Chameleon.cs:23956` — `this.$tChar$22726.RPC_AddStatus("venomShock", this.$sLv$22737, 12, 0, this.$self_$22738.mChar.ActorNr);` (flat literal `12`, confirmed NOT chaAdjust-wrapped)
- `needlePrison`, `poisonVolley`, `markOfSlayer`, `thunderDragon`: target-CHA-contested via `Damage.getDebuff` — see judgment-call notes above for each skill's specific citation. Duration cells are `—`.
- `quickFire`, `massShot`, `tormentRain`, `leftStride`, `rightStride`, `bloodBurn`, `slayer`, `allSlayer`,
  `allSlain`, `zeroShot`: no usable Duration — no `RPC_AddStatus` call exists in the skill's own coroutine
  class body (or its downstream `_fire` coroutine, where applicable); see the bulk judgment-call note
  above for the exact class-range bounds checked. Duration cells are `—`.
