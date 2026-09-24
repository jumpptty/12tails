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
| fuujinKen | Fuujin Ken | 1 | 240 | true | false | 9 | false |
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
  excluded from this table, same reasoning as Monkey's `blazingForm`/`sentinalGuard`.** A grep of both
  `PandaSkill.cs` and `PandaSkill_eng.cs` for `ashuraFist` returns zero matches: no
  `getSkill()`/`getSkillTree()` entry and no description. It's an internal state of the `ashura`
  transformation, not a roster skill. Its `addTimeOut("ashuraFist", (float)12)` (`Panda.cs:31272`) is
  **written but never checked** (corrected 2026-09-24; this note used to call it a working cooldown). See
  the Ashura section under Damage & Mechanics.
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
- `fuujinKen` Duration: `Panda.cs:41159` — `this.$self_$25701.mChar.StartCoroutine_Auto(this.$self_$25701.mChar.addStatus("noForce", 1, 9, 0, this.$self_$25701.mChar.ActorNr));` (self-applied knockback-immunity during tornado spin; `addStatus` flat literal `9`, `durWrapped:false`, `durLabel:"ระยะเวลากันแรงผลัก"`)
- `roll`, `threeSteps`, `rushingFalcon`, `qiStrike`, `pummel`, `towerRush`, `tigerToss`, `risingVortex`,
  `waterMonkey`, `waterCrane`, `spTransfer`, `wind&cloud`, `rain&storm`, `lotusPalm`, `heavenPalm`,
  `raijinKen`: no usable Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime
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

### Stasis Blow (`panda_stasisBlow`, skill IDs #321/#322)

- **Cost / requirements (`decode_skilldata.py`):** MP **10, 15**, SP **10, 15** (positive = blue threshold, not consumed), Lv 7/13, Bn 2/4, mode target, target enemy (`PandaSkill.cs:681-715`, tree ids `:2858-2869`).
- **Tooltips:** TH `"กระโดดพุ่งเข้าสะกัดจุดหยุด การเคลื่อนไหวของเป้าหมาย (+10dmg, 3sec)"` / `(+15dmg, 5sec)` (`PandaSkill_thai.cs:660-682`), which match the code. EN gives `"(10 dmg, 3 sec.)"` for **both** ranks (`PandaSkill_eng.cs:638-660`); rank 2 is a client copy error.
- **Dispatch (`doSkill`, `Panda.cs:6851-6936`):** `tDir` = normalized flat direction to the target (`:5648`). With **Wind Walker (#423)**: distance > **6 m** (`sqrMagnitude > 36`) → if > **16 m** (`> 256`) shows `"Too far to use WindWalker"`, `returnMPSP(text)` and cancels; otherwise `tDir = getSpawnPos(target − 3·dir) − pos`, i.e. a spot **3 m in front of the target** (`:6861-6914`). The coroutine warps there in state 2 when `tDir.sqrMagnitude > 36` (`:34192-34200`).
- **Coroutine `$RPC_stasisBlow$25527` (`Panda.cs:34040-34789`):** `addTimeOut("stasisBlow", agiAdjust(30))` (`:34603`), `moveSpeed = 3` (`:34621`) → 0.2 s → state 2 (warp check, effect) → 0.1 s → state 3 `moveSpeed = 10`, `IgnoreCollision(self, target, true)` (`:34260`) → 0.2 s → state 4 **hit** → 0.1 s → state 5 `moveSpeed = 4`, collision restored (`:34453`) → 0.2 s → state 6 stop (`:34519`). Distance: `3·0.3 + 10·0.3 + 4·0.2 =` **4.7 m**, hit after 2.9 m, passing through the target (at `moveMod = 1`).
- **Hit (state 4):** `FindRecTarget(pos − 2·forward, forward, 1+sf, 1+sf, (4+sf)·rangeMod, 2·rangeMod)` with `sf = hasSkill(433)` (Spirit Fist) (`:34298-34312`): full width **2 m** (4 m), length **4 m** (5 m) starting **2 m behind** the Panda, height **2 m**. Per target: `hit(320 + sLv, target, (int)(0.4·ATK + talAdjust(5 + 5·sLv)), 1, 0, zero)` (`:34335`), KO **1**, no Focused Art term. On a landed hit: `getDebuff(1 + 2·sLv, cha, target.cha)` = **3 / 5 s** contested (`:34361`); `paralysis` level 1 is applied **only if the target's `actionState` is `standby`, `run` or `emotion`** (`:34372-34394`); then the hit effect, `sp += 1`, `ShadowFist(target)` (`:34401-34423`).
- **`paralysis` status:** code **306** (`StatusData.cs:833`), **Debuff + Physical** (`isDebuffStatus` `:7334`, `isPhysicalStatus` `:5385`; not in `isLockStatus` or `isMagicalStatus`). Apply: `actionState = "paralysis"`, `moveSpeed = 0`, animation stopped (`CharacterControl.cs:35427-35440`); per frame `moveSpeed = 0` (`:2317`); removal returns `actionState` to `standby` (`:15812`). Removed by `removeDebuff()` (`:19627`) and by the apply handlers of `petrify`/`snowMan`/`sleep`/`nightmare`/`mindControl` (`:37542`, `:38660`, `:39228`, `:40356`, `:40726`). No damage-break removal was found.
- ⚠️ **Not traced:** `RPC_AddStatus` starts with two status-name lists that include `paralysis`, one guarded by `isChild` (summons) and one by `Race == eRace.Robots` (`CharacterControl.cs:10653-10960`), with an IMMUNE (−84) path. Whether a match means immune or allowed has not been read.

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
    - Step 1: `FindRecTarget(pos − 0.5·forward, forward, 1.6·rangeMod, 1·rangeMod, 2·rangeMod, 2·rangeMod)` (`Panda.cs:22102`) — a trapezoid **3.2 m wide at the start narrowing to 2 m**, 2 m long, 2 m tall, starting 0.5 m behind Panda (width args are half-widths, see [Mechanics Reference §4](12Tails-Mechanics-Reference.md#4-hidden-mechanics--special-interactions)).
    - Step 2: `FindRecTarget(pos, forward, 1·rangeMod, 1·rangeMod, 1·rangeMod, 2·rangeMod)` (`Panda.cs:22240`) — **2 m wide, 1 m long, 2 m tall**.
    - Step 3: same box as step 2 (`Panda.cs:22390`).
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


### Qi Strike (`panda_qiStrike`, skills #211-#213)

- **Cost / requirements (`decode_skilldata.py`):** MP 0, SP **−15/−18/−21** (negative = consumed, red), Lv 5/11/17, Bn 1/3/5, instant, target enemy (`PandaSkill.cs:261-266`). CD `addTimeOut("qiStrike", agiAdjust(90))`, fixed for all ranks (`Panda.cs:23123`).
- **Tooltip:** "Charge up and unleash a destructive forward punch. (1.0 / 2.0 / 3.0 x atk.)" (`PandaSkill_eng.cs:268/279/290`; Thai `PandaSkill_thai.cs:290/301/312`).
- **Charge (`$RPC_qiStrike1$25279`, `Panda.cs:22845-23291`):** sets `actionState="attack"`, `myCommand="qiStrike1"`, `moveSpeed=0` (`:23114-23141`); no `DisplayCastBar` in the path. Waits until `Time.time >= actionTime + 1 + sLv` (`:23028`) = **2/3/4 s**, not wrapped in any adjuster, then auto-releases: `RPC_qiStrike2`, or `RPC_delayQi` when `hasSkill(214)` (Delay Qi) (`:23036-23064`). No other release path exists in `Panda.cs`, `CharacterControl.cs`, `Damage.cs`, `StatusData.cs` (searched; `PandaCult*.cs` not read).
- **Punch (`$RPC_qiStrike2$25291`, `Panda.cs:23328-23932`):** 0.2 s wind-up (`:23929`), one hit check, 0.4 s tail (`:23927`).
  - Box: `FindRecTarget(pos, forward, 1·rangeMod, 1·rangeMod, 1·rangeMod + 5·getQiBurstLv(), 2·rangeMod)` (`:23503`), i.e. **2 m wide** (half-width 1 m, see [Mechanics Reference §4](12Tails-Mechanics-Reference.md#4-hidden-mechanics--special-interactions)), **2 m tall** (band −1 m…+2 m around the caster's feet), **1 m long, 6 m with Qi Burst** (`getQiBurstLv() = hasSkill(412)`, `:9702`). Width, height and the 1 m base length scale with `rangeMod`; Qi Burst's +5 m does not.
  - Damage: `hit(210+sLv, obj, (int)(sLv·(ATK + getFocusedArtDmg())), 10·sLv, 0, 3·forward)` (`:23526`). **No `talAdjust` term**; KO `10·sLv`; goes through `hit()` so it can be dodged/blocked (Mechanics Reference §2).
  - Per target hit: `sp += 1` (`:23559`) inside the target loop, so each later target in the same punch reads a 1-higher SP for Focused Art. `ComboPlus()` fires once if anything was hit (`:23578`).
- **Delay Qi hold:** `RPC_delayQi` grants status `delayQi` (nCode 301; `isStateStatus` + `isBuffStatus`, `StatusData.cs:778/4890/6560`; Panda-only handler `CharacterControl.cs:12259`) for `chaAdjust(3) + 3·getQiBurstLv()` s at the cast rank (`Panda.cs:24255`). The next attack press releases `RPC_qiStrike2` at the status level (`:7897-7904`), which removes the status (`:23742-23748`).

### Pummel (`panda_pummel`, skills #221/#223)

- **Cost / requirements (`decode_skilldata.py`):** MP 0, SP **−12/−16** (consumed, red), Lv 7/19, Bn 2/6, instant, target enemy. CD `addTimeOut("pummel", agiAdjust(30))`, fixed for both ranks (`Panda.cs:24895`).
- **Tooltip:** "Instantly perform a series of quick forward jabs. (5x5 dmg.)" / "(10x5 dmg.)" (`PandaSkill_eng.cs:308/319`; Thai `PandaSkill_thai.cs:330/341`).
- **Coroutine `$RPC_pummel$25313` (`Panda.cs:24301-25120`):** lunge forward at `moveSpeed = 16` (`:24448`), stop (`:24475`), then **5 jabs** (`i < 5`, `:24743`; `i++` `:25077`), then step back at `moveSpeed = −6` (`:24637`) and return to standby (`:24690`).
- **Per jab:**
  - Base: `FindRecTarget(pos, forward, 1·rangeMod, 1·rangeMod, 1·rangeMod, 3·rangeMod)` (`:24783`) = **2 m wide, 1 m long, 3 m tall**; damage `(int)(0.25·(ATK + getFocusedArtDmg()) + talAdjust(5·sLv))` (`:24788`).
  - Ogre Impact (`hasSkill(422)`, `:24759`): `FindRecTarget(pos, forward, 2, 2, 3, 3)` (`:24765`) = **4 m wide, 3 m long, 3 m tall, not scaled by `rangeMod`**; damage `(int)(0.35·(ATK + getFocusedArtDmg()) + talAdjust(5·sLv + 5))` (`:24770`); also spawns the `pummel_ogre` / `pummel_ogreArm1/2` visuals (`:24480-24601`).
  - `hit(219 + 2·sLv, obj, dmg, sLv, 0, Vector3.zero)` (`:24812`): KO `sLv`, no knockback, dodgeable (`hit()` path). `sp += 1` per target (`:24845`); `ComboPlus()` once per jab that hit anything (`:24862`). No status.

### Tower Rush (`panda_towerRush`)

- **Cost / requirements (`decode_skilldata.py`):** MP 0, SP **−15/−20** (consumed, red), Lv 13/25, Bn 4/8, instant, target enemy. CD `addTimeOut("towerRush", agiAdjust(30))`, fixed for both ranks (`Panda.cs:25632`).
- **Tooltip:** "Instantly perform a quick back attack that deal 15 damage and 10 ko." / "…30 damage and 20 ko." (`PandaSkill_eng.cs`; Thai "กระโดดเอาหลังกระแทกเพื่อทำ ko เป้าหมาย (+15dmg, 10ko)" / "(+30dmg, 20ko)", `PandaSkill_thai.cs`).
- **Coroutine `$RPC_towerRush$25329` (`Panda.cs:25172-25800`):** lunge at `moveSpeed = 16` (`:25319`) for 0.1 s (`:25799`), stop (`:25346`), **one hit**, then step back at `moveSpeed = −4` (`:25545`) for 0.3 s (`:25797`) and return to standby (`:25571`).
- **Hit:**
  - Base: `FindRecTarget(pos, forward, 1·rangeMod, 1·rangeMod, 1·rangeMod, 3·rangeMod)` (`:25437`) = **2 m wide, 1 m long, 3 m tall** in front; damage `(int)(0.5·(ATK + getFocusedArtDmg()) + talAdjust(15·sLv))` (`:25442`).
  - Ogre Impact (`hasSkill(422)`, `:25418`): `FindAreaTarget(pos, 4, 6)` (`:25424`) = **circle of radius 4 m around Panda (front and back), 6 m tall, not scaled by `rangeMod`**; damage `(int)(0.75·(ATK + getFocusedArtDmg()) + talAdjust(15·sLv + 15))` (`:25429`); also spawns the `towerRush_ogre` visual (`:25371-25395`).
  - `hit(220 + 2·sLv, obj, dmg, 10·sLv, 0, Vector3.zero)` (`:25466`): KO `10·sLv`, no knockback, dodgeable (`hit()` path). `sp += 1` per target (`:25499`); `ComboPlus()` once if anything was hit (`:25518`). No status.

### Tiger Toss (`panda_tigerToss`) and Tiger Pounce (`panda_tigerPounce`, skill #232)

- **Tiger Toss cost / requirements (`decode_skilldata.py`):** single rank, Lv 9 / Bn 3, MP 0, **SP +12 (threshold, blue — not consumed)**, `mode = target`, target enemy.
- **Tooltips:** "Instantly grab and toss target with small or medium size, dealing 15 damage and 3 ko." / Thai "ท่าจับทุ่มของแพนด้า ใช้ได้กับ เป้าหมายขนาดเล็กและขนาดกลาง (+15 dmg, 3ko)"; Tiger Pounce "Adds a second hit to TigerToss, dealing target's weight and 10 ko to all nearby enemies." / Thai "ทำให้เป้าหมายที่โดนทุ่มทำ ความเสียหายให้รอบตัว ตาม น้ำหนัก (0.5 x weight, 10ko)". **Both tooltips disagree with source:** Tiger Toss KO is **5**, not 3; Pounce damage is `0.5·(ATK+FA) + talAdjust(weight)`, not `0.5 × weight`.
- **Cast = `$RPC_grab$25344` (`Panda.cs:25862-26400`, dispatch `:7174`):** dash at `moveSpeed = 16` (`:26009`), stop (`:26036`), then `FindRecTarget(pos, forward, 1·rangeMod, 1·rangeMod, 1·rangeMod, 3·rangeMod)` (`:26073`, 2 m wide × 1 m × 3 m tall) must contain the selected target. Then:
  - target `CharacterController.height × localScale.y < 3` (`:26113`) **and** `weight < 60` (`:26130`) **and** `recieveForce` (`:26136`) → `RPC_tigerToss` (`:26142`); height OK but too heavy / force-immune → toast "Target too heavy!" (`:26168`);
  - height ≥ 3 → with Climbing Cliff: `sp >= 40` and Crumbling Mountain learned → `RPC_crumblingMountain`, else `RPC_climbingCliff`; without Climbing Cliff → "Target too large!" (`:26178-26260`).
  - `RPC_grab` has **no `addTimeOut`**: a grab that fails starts no cooldown.
- **Toss (`$RPC_tigerToss$25362`, `Panda.cs:26452-27190`):** `addTimeOut("tigerToss", agiAdjust(30))` (`:26950`), `moveSpeed = 3`, self `addStatus("noForce", 1, 1, …)` (`:26971`); collision with the target ignored and target gets `addStatus("grab", sLv, 1, …)` (`:27089-27101`). After 0.6 s (`:27127`): `removeStatus("grab")` (`:26653`), then `hit(230 + sLv, target, (int)(0.5·(ATK+FA) + talAdjust(15·sLv)), 5, 0, 5·forward + 2·up)` (`:26675`) — single target, thrown; `sp += 1`, `ComboPlus()`.
- **`grab` status:** nCode 304 (`StatusData.cs:811`), `isDebuffStatus` + `isStateStatus` (`:7328`, `:4896`); handler sets `moveSpeed = 0`, `myForce = zero` (`CharacterControl.cs:2300`).
- **Tiger Pounce** (`getTigerPounceLv() = hasSkill(232)`, `Panda.cs:8670`), 0.1 s later: `FindAreaTarget(thrown target position, 3·rangeMod, 6·rangeMod)` (`:26805`) → `hit(232 + lv, obj, (int)(0.5·(ATK+FA) + talAdjust(tChar.weight)), 10, 0, Vector3.zero)` (`:26828`) on every enemy in the circle; `ComboPlus()` once, **no SP gain** in this loop. Weight is the thrown target's `CharacterControl.weight` (character data weight + bonuses, `CharacterControl.cs:1455`), so it is always < 60 here. The app models it with a `น้ำหนัก` input (0–59, default 30) on the Tiger Toss card.

### Climbing Cliff (`panda_climbingCliff`)

- **Requirements (`decode_skilldata.py`):** Lv 21 / Bn 7, `mode = passive`, 0 MP / 0 SP in skill data; no SP check of its own (the Tiger Toss cast needs SP ≥ 12).
- **Tooltip:** "Enables Panda to use TigerToss on any large target and change it to a climbing attack." / Thai "เปลี่ยนให้ไทเกอร์ทอสเป็นท่า โจมตีต่อเนื่องสำหรับเป้าหมาย" (`PandaSkill_eng.cs`, `PandaSkill_thai.cs`).
- **Trigger:** Tiger Toss's `$RPC_grab` on a target with height × scale ≥ 3 while Climbing Cliff is learned, unless Crumbling Mountain takes over (`sp >= 40` and learned) (`Panda.cs:26178-26260`).
- **Coroutine `$RPC_climbingCliff$25380` (`Panda.cs:27194-27750`):** `addTimeOut("tigerToss", agiAdjust(240))` (`:27598`, Tiger Toss's key), self `addStatus("noForce", 1, 2, …)` (`:27619`, 2 s fixed), toast "ClimbingCliff!" (`:27687`). 18 ticks of 0.1 s (`:27347`, `:27750`); hits the **selected target** (`ActorNrList[tID]`, `:27500`) on ticks **1, 3, 5, …, 15 = 8 hits** (`:27442-27484`); step back at `moveSpeed = −4` from tick 12 to 16 (`:27566-27580`).
- **Per hit:** `hit(260 + sLv, target, (int)(0.3·(ATK + getFocusedArtDmg()) + talAdjust(10)), 1, 0, Vector3.zero)` (`:27516`): KO 1, no force, dodgeable; `sp += 1` and `ComboPlus()` per hit. Crushing Monolith does not apply here.

### Crumbling Mountain (`panda_crumblingMountain`) and Crushing Monolith (`panda_crushingMonolith`, skill #432)

- **Requirements (`decode_skilldata.py`):** Crumbling Mountain Lv 27 / Bn 9, Crushing Monolith Lv 75 / Bn 4; both `mode = passive`, 0 MP / 0 SP in skill data.
- **Tooltips:** Crumbling Mountain "Gives Climbing Cliff its final attack when Panda uses it with more than 40 sp." / Thai "เพิ่มการโจมตีพิเศษหลังจากท่า ClimblingCliff ถ้า sp มากกว่า 40"; Crushing Monolith Thai "แยกร่างเพิ่มความเสียหายให้ ClimbingMountain ตามความสูงของเป้าหมาย" (no English string found). The source check is **`sp >= 40`**, and SP is checked, not spent.
- **Trigger:** only through Tiger Toss's `$RPC_grab` (see Tiger Toss): target height×scale ≥ 3, Climbing Cliff learned, `sp >= 40` and Crumbling Mountain learned → `RPC_crumblingMountain`; otherwise Climbing Cliff.
- **Coroutine `$RPC_crumblingMountain$25394` (`Panda.cs:27796-28670`):** `addTimeOut("tigerToss", agiAdjust(300))` (`:28383`, Tiger Toss's key), self `addStatus("noForce", 1, 3, …)` (`:28404`, 3 s fixed). 28 ticks of 0.1 s (`:27949`, `:28611`); hits the **selected target only** on ticks **2, 5, 9, 10, 11, 15–22 = 13 hits** (`:28044-28119`); toast "Crumbling Mountain!" at tick 16 (`:28279`); step back at `moveSpeed = −4` on ticks 24–27 (`:28351`).
- **Per hit:** `mDmg = (int)(0.3·(ATK + getFocusedArtDmg()) + talAdjust(10))` (`:28153`), KO 1, no force; `sp += 1` and `ComboPlus()` per hit.
  - Without Crushing Monolith: `hit(262 + sLv, …)` (`:28223`).
  - With Crushing Monolith (`hasSkill(432)`, `:28158`): `mDmg += talAdjust((int)(target CharacterController.height × 10))` (`:28175`) — a **second, separately rolled** `talAdjust` using the **raw** collider height (the grab gate uses height × scale) — then `hit(432, …)` (`:28181`). Also spawns 3 `crushingMonolith` visuals around the target (`:28513-28577`).
- **Compared with Climbing Cliff** (`$RPC_climbingCliff$25380`, `Panda.cs:27194-27750`): 18 ticks, hits on 1, 3, …, 15 = **8 hits**, same per-hit formula, CD 240, noForce 2 s. Crushing Monolith does not apply to Climbing Cliff.
- **`noForce` status:** nCode 5 (`StatusData.cs:111`), `isBuffStatus` only (`:6356`); handler sets `myForce = zero` (`CharacterControl.cs:2266`).
- **App modelling:** the Monolith group's text is `talAdjust(10) + talAdjust(tHeight10)`, rolled as two independent `talAdjust` calls; `tHeight10 = round(height × 10)` from the card's `สูง` input (default 3.0 m).

### Rising Vortex (`panda_risingVortex`, skills #251/#252)

- **Cost / requirements (`decode_skilldata.py`):** MP **5, 5** (consumed), SP **+16/+18** (threshold gate, blue — not consumed, `cSP > 0`), Lv 20/24, Bn 12/15, mode instant, target enemy (`PandaSkill.cs:466-489`, `:1868-1893`). CD `addTimeOut("risingVortex", agiAdjust(60f))`, fixed for both ranks (`Panda.cs:29127`).
- **Tooltips:** "Perform a spinning uppercut punch that pull nearby enemies toward Panda (10 dmg)." / "…(20 dmg)." (`PandaSkill_eng.cs:444`, `:455`; Thai "ท่าหมัดอัพเปอร์คัทที่ก่อให้เกิด ช่องว่างอากาศดูดเป้าหมาย โดยรอบเข้าหาตัว (+10dmg)" / "(+20dmg)", `PandaSkill_thai.cs:466`, `:477`). "(10 dmg)" and "(20 dmg)" correspond to `talAdjust(10·sLv)`.
- **Coroutine `$RPC_risingVortex$25412` (`Panda.cs:28672-29351`, dispatch `:7136`):** sets `actionState = "attack"`, `myCommand = "risingVortex"`, plays animation and effect (`:29124-29261`). 0.4 s wind-up (`:29303`) -> **Hit 1** (`:28832`) -> 0.2 s wait (`:29288`) -> **Hit 2** (`:28947`) -> 0.1 s + 0.3 s recovery tail (`:29294`, `:29299`), action ends at t = 1.0 s (`moveSpeed = 0`, `actionState = "standby"`, `:29061-29066`). Total: **2 hits**.
- **Area & Geometry:** `FindAreaTarget(pos, 3·rangeMod, 3·rangeMod, hitLayer)` (`:28832`, `:28947`) = cylinder centered on Panda with **radius 3 m (diameter 6 m)** and **height 3 m**, both scaling with `rangeMod`.
- **Force / Knockback Vector:** `(pos - target.pos).normalized` (`:28855`, `:28970`) = pull vector pointing inwards towards Panda's center (vacuum effect).
- **Per-Hit Damage:** `hit(250 + sLv, obj, (int)(0.5·(ATK + getFocusedArtDmg()) + talAdjust(10·sLv)), 1, 0, pullVector)` (`:28855`, `:28970`):
  - ATK coefficient: `0.5·(ATK + FA)`
  - TAL term: `talAdjust(10·sLv)` (Rank 1: `talAdjust(10)`, Rank 2: `talAdjust(20)`)
  - KO: `1` per hit (total `2` KO across 2 hits)
  - Focused Art synergy (`usesFocusedArt: true`): `0.5 · getFocusedArtDmg() = 0.25 · SP · focusedArtLv` (`Panda.cs:10841`)
  - SP generation: `sp += 1` per target connected per hit (`:28888`, `:29003`)
  - `ComboPlus()` fires on each hit if any target was hit (`:28907`, `:29022`). No status inflicted.

### Rising Dragons (`panda_risingDragons`, skills #253/#254)

- **Cost / requirements (`decode_skilldata.py`):** MP **10, 10** (consumed), SP **−45, −60** (consumed, red — negative in `cSP`), Lv 28/32, Bn 18/21, mode instant, target enemy (`PandaSkill.cs:498-508`, `:1841-1851`).
- **Cooldown:** Base **240s** before AGI adjustment (`addTimeOut("risingDragons", agiAdjust(240f))`, `Panda.cs:30103`), `cdWrapped: true`, `revisedArtExempt: false`.
- **Buff / CC Setup on Cast (`Panda.cs:29356-30282`):**
  - **Self Buff:** Panda immediately receives status `noForce` Level 1 for **3s** unwrapped (`addStatus("noForce", 1, 3, 0)`, `:30124`).
  - **Pre-attack CC (t = 0.3s):** Target area scan `Damage.FindAreaTarget(pos, 3·rangeMod, 6·rangeMod, hitLayer)` (`:29580`) inflicts status `lock` Level 1 for **2s** unwrapped (`RPC_AddStatus("lock", 1, 2, 0)`, `:29625`) on all targets in Radius **3m**, Height **6m**.
    - `lock` status mechanics: `StatusData.cs:437` (nCode 41, `isDebuffStatus: true`, `isSystemStatus: true`). `CharacterControl.cs:2284`: zeroes movement and horizontal velocity (`moveSpeed = 0`, `myForce.x = 0`, `myForce.z = 0`).
- **Phase 1: Uppercut Jabs (8 Hits, `Panda.cs:29726-30092`):**
  - Loop of 8 ticks at 0.15s intervals (`i = 0..7`).
  - Area: Radius **3m**, Height **6m** (`FindAreaTarget`).
  - Formula: `(int)(0.35·(ATK + getFocusedArtDmg()) + talAdjust(5·sLv))` (`Panda.cs:30033`).
    - Rank 1: `0.35·(ATK + FA) + talAdjust(5)`
    - Rank 2: `0.35·(ATK + FA) + talAdjust(10)`
  - KO: **1** per hit. Force: `2 * Vector3.up` (launches targets upwards). `sp += 1` per connected target.
- **Phase 2: Finishing Dragon Smash (1 Hit, `Panda.cs:29759-29875`):**
  - Spawns `ashuraFist` prefab at impact point.
  - Area: Radius **4m**, Height **3m** (`FindAreaTarget`, `:29821`).
  - Formula: `(int)(0.5·(ATK + getFocusedArtDmg()) + talAdjust(40·sLv))` (`Panda.cs:29844`).
    - Rank 1: `0.5·(ATK + FA) + talAdjust(40)`
    - Rank 2: `0.5·(ATK + FA) + talAdjust(80)`
  - KO: **1**. Force: `3 * (target.pos - caster.pos).normalized` (knocks targets away). `sp += 1` per connected target.
  - ⚠️ **Tooltip Discrepancy:** In-game client tooltips (`PandaSkill_eng.cs:466`, `:477`; `PandaSkill_thai.cs:488`, `:499`) claim `(5x8 dmg, 60 dmg)` / `(10x8 dmg, 90 dmg)`. While the 8 jabs accurately deal `talAdjust(5·sLv)` (5 / 10), the finisher in actual decompiled code is **`talAdjust(40·sLv)`** (40 / 80), NOT 60 / 90.
- **Total Hits & KO:** 8 + 1 = **9 hits**, **9 KO**.
- **Focused Art Synergy:** Both phases add `getFocusedArtDmg() = 0.5 * sp * rank` inside the ATK bracket (`usesFocusedArt: true`, `hasCurrentSp: true`).

### Ashura (`panda_ashura`, skills #271/#272)

- **Cost / requirements (`decode_skilldata.py`):** MP **25, 35**, SP **−90, −90** (consumed, red), Lv 35/40, Bn 23/25, mode instant, target self (`PandaSkill.cs:556-590`, tree ids `:2748-2759`).
- **Cast (`$RPC_ashura`, `Panda.cs:30470-30680`):** `addTimeOut("ashura", agiAdjust(300))` (`:30659`); self `RPC_AddStatus("ashura", sLv, chaAdjust(24), 0, ActorNr)` (`:30572`, self buff, not contested). `sLv` = rank (`pnd_ashura2` → `num2++`, `:5916`).
- **`ashura` status:** code **303** (`StatusData.cs:800`), classified **Buff + State only** (`isBuffStatus` `:6572`, `isStateStatus` `:4902`; absent from the Magical/Physical/Lock/System/Shield lists). Only a Panda can hold it (`RPC_AddStatus` type gate, `CharacterControl.cs:12274`). Red tint + `ashuraFx` on apply (`:35484-35510`), reverted in `removeStatus` (`:15830`).
  - **SP gain:** in `StatusUpdate` (whose body runs at most once per **0.5 s**, `CharacterControl.cs:8659` `kNtcObrGvdk > Time.time - 0.5f`), `ashura` has no extra per-status gate (unlike `holyWolf`/`afterShock`), so every cycle: `if (hp > 0 && isMine && !hasStatus("provoke")) sp = Clamp(sp + 5·sLv, 0, 100)` (`:8841-8866`) = **+5 / +10 SP per 0.5 s**. Clamped to **100**, not to max SP. **`provoke` blocks the gain.**
  - **No overflow decay:** the global SP-above-max decay (see [12Tails-Mechanics-Reference.md §1.2](12Tails-Mechanics-Reference.md#12-derived-values-charactercontrolcs14641479)) is skipped for a Panda while `getStatusLv("ashura") != 0` (`CharacterControl.cs:1976-1990`).
  - Tooltip "ฟื้นคืน sp เป็นร้อยเท่า" (`PandaSkill_thai.cs:550`) is flavour; the real rate is above.
- **Ashura Fist (charge attack replacement):** in `doBeginCharge` (`Panda.cs:8166`), `if (getStatusLv("ashura") > 0)` starts `RPC_ashuraFist(pos, dir, 0, statusLv)` (`:8215-8231`) instead of `RPC_cAttack1`. That branch has **no `isTimeOut("cAttack")` check and no `hasSkill(111)` check**, unlike the normal charge path (`:8242`).
  - Coroutine `$RPC_ashuraFist$25457` (`Panda.cs:30843-31420`): sets `myCommand="ashuraFist"`, `addTimeOut("ashuraFist", 12)` (`:31272`), `moveSpeed = 0`, then yields **0.3 s** (`:31398`); state 2 sets `moveSpeed = 6` (`:30987`) and yields **0.6 s** (`:31416`) → lunge of `6 × 0.6 = ` **3.6 m** at `moveMod = 1` (movement = `vMovement·moveSpeed·clamp(moveMod,0.1,2)·dt`, `CharacterControl.cs:2722`); state 3 stops (`:31009`), spawns the effect, snapshots `hitSp = sp`, then **2 hits** (`i < 2`) 0.2 s apart (`:31414`).
  - Each hit: `FindAreaTarget(pos, 3, 3)` (radius **3 m**, height **3 m**), `hit(272 + sLv, target, (int)(0.5·ATK + talAdjust((int)(0.25·hitSp·sLv))), 5, 0, dir)` (`:31230`); KO **5**; `sp += 1` per landed target; `ComboPlus()` if anything was hit. **No Focused Art term** (`getFocusedArtDmg()` not called). Both hits use the same `hitSp` snapshot.
  - After the 2nd hit: **`sp = 0`** (`:31118+`).
  - ⚠️ **Cooldown never enforced:** `isTimeOut("ashuraFist")` appears nowhere in `DecompiledSource/` (only `Panda.cs` mentions `ashuraFist` at all). User-confirmed in-game 2026-09-24: Ashura Fist can be used back-to-back. The 12 s lock is the intended behaviour; the card shows this as a red note.
- **Card modelling:** `dmg:(rank)=>"talAdjust(floor(0.25·SP·rank))"` reads the card's SP input (`hasCurrentSp:true`, no `usesFocusedArt`), `dmgSub` captions the base `0.25SP` / `0.5SP`, `atkCoeff:0.5`, `ko:"5"`, `hitCount:2`.

### Ogre Impact (`panda_ogreImpact`, skill #422)

- **Passive, Lv 70 / Bn 3, 0 MP / 0 SP** (`decode_skilldata.py`; `PandaSkill.cs:3173`).
- **Tooltip:** "Increases Pummel and Tower Rush's damage and range with a red ogre effect." (`PandaSkill_eng.cs:957`; Thai `PandaSkill_thai.cs:979`).
- **Hooks:** Pummel — larger fixed box and `0.35·(ATK+FA) + talAdjust(5·sLv+5)` (see above). Tower Rush — `hasSkill(422)` branch uses `0.75·(ATK+FA) + talAdjust(15·sLv+15)` instead of `0.5·(ATK+FA) + talAdjust(15·sLv)` (`Panda.cs:25429`, `:25442`), and swaps the 2 m × 1 m front box for a 4 m-radius circle around Panda (`:25424`, see Tower Rush above).

### Delay Qi (`panda_delayQi`, skill #214)

- **Req Lv 23 / Bn 7, SP −24, `mode = passive` in `getSkill()`** (`PandaSkill.cs:288-304`, `decode_skilldata.py`).
- **Tooltip:** "Enables Panda to hold his QiStrike and release it later when you press attack (max 3 sec)." (`PandaSkill_eng.cs:301`; Thai `PandaSkill_thai.cs:323`).
- **Hook:** at the end of Qi Strike's charge, `hasSkill(214)` diverts to `RPC_delayQi` instead of the punch (`Panda.cs:23036-23055`), which grants status `delayQi` (nCode 301, State + Buff) at the Qi Strike rank for `chaAdjust(3) + 3·getQiBurstLv()` s (`:24255`). The next attack press fires `RPC_qiStrike2` at that level (`:7897-7913`), which removes the status (`:23742-23748`). Full detail under Qi Strike above.

### Qi Burst (`panda_qiBurst`, skill #412)

- **Passive Class-C, Lv 60 / Bn 1, 0 MP / 0 SP** (`PandaSkill.cs:1099-1110`).
- **Tooltip:** "Enables QiStrike to unleash a giant fist that deals its damage in 6m line. Also extend delayQi by 3 sec." (`PandaSkill_eng.cs:950`; Thai `PandaSkill_thai.cs:972`).
- **Hook:** `getQiBurstLv() = hasSkill(412) ? 1 : 0` (`Panda.cs:9700-9703`). Adds `+5·lv` m to Qi Strike's hit-box length (1 m → 6 m, `:23503`), `+3·lv` s to the `delayQi` hold (`:24255`), and swaps in the `qiBurst` effect prefab (`:23786-23798`).

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

  (`FA` = `getFocusedArtDmg()`. Only Three Steps, Rushing Falcon, Qi Strike, Pummel, Tower Rush, Tiger Toss (+ Tiger Pounce), Climbing Cliff, Crumbling Mountain (+ Crushing Monolith) and Rising Vortex cards are fully verified in the app so far; the rest are recorded here for their future cards.)

### Nine Steps (`panda_nineSteps`, skill #402)

- **Passive Class-C, Lv 55 / Bn 0, 0 MP / 0 SP, no cooldown** (`decode_skilldata.py`).
- **Tooltip:** "Passively increases damage of ThreeStep and RushingFalcon by the number of its own hit." (`PandaSkill_eng.cs:935-943`; Thai `PandaSkill_thai.cs:957`).
- **Hook:** `getNineStepsLv() = hasSkill(402) ? 1 : 0` (`Panda.cs:9693`); each step does `if (getNineStepsLv() > 0) hitDmg *= 1 + hitCount;` (`Panda.cs:21118-21124`, `:21332`, `:22250`, `:22400`). Steps therefore deal 100% / 200% / 300% (6× total vs 3×), scaling ATK, TAL and Focused Art terms alike.
- The `getNineStepsLv() != 0` check at `Panda.cs:21569` only chooses between the `nineStep1` / `nineStep2` voice clips (50% each) — no damage effect.

### Drunken Plus (`panda_drunkenPlus`, skills #303/#304)

- **Passive, 0 MP / 0 SP, no cooldown.** Rank 1 = Lv 28 / Bn 18, rank 2 = Lv 32 / Bn 21 (`decode_skilldata.py`; `PandaSkill.cs:522-542`, `:1804-1825`).
- **Tooltip:** "Gives Panda a chance to dodge any incoming attacks while using DrunkenFist and grants drunken status." (`PandaSkill_eng.cs:534-547`; Thai `PandaSkill_thai.cs:556`, `:567`).
- **Hook:** `getDrunkenPlusLv() = hasSkill(304) ? 2 : (hasSkill(303) ? 1 : 0)` (`Panda.cs:9011-9014`).
  - At the end of Drunken Fist cast (`Panda.cs:32591`), grants self status `drunken` at Level `getDrunkenPlusLv()` for `chaAdjust(12)` seconds.
  - While under status `drunken`, evasion chance is `lckAdjust(5 * sLv)` % (`CharacterControl.cs:3076-3079`).

### Drunken Spin (`panda_drunkenSpin`, skill #423)

- **Passive Class-C, Lv 55 / Bn 0, 0 MP / 0 SP, no cooldown** (`PandaSkill.cs:1206-1218`, `decode_skilldata.py`).
- **Tooltip:** "Passively gives DrunkenFist an extra 6 damage and inflicts drunk status on all targets." (`PandaSkill_eng.cs:964`; Thai `PandaSkill_thai.cs:986`).
- **Hook:** `getDrunkenSpinLv() = hasSkill(423) ? 1 : 0` (`Panda.cs:9721-9724`).
  - When learned, connecting hits of Drunken Fist inflict status `drunk` at Level 1 with contested duration (`Panda.cs:31817`, `:32039`, `:32214`, `:32362`): base 12s on hit 1, base 6s on hits 2–4 (`Damage.getDebuff(base, caster.cha, target.cha)`).
  - ⚠️ **Tooltip Discrepancy:** The tooltip claims Drunken Spin grants "+6 damage" to Drunken Fist, but decompiled source tracing confirms no damage modifier or `+6` bonus exists for `hasSkill(423)` in `Panda.cs`.

### Fuujin Ken (`panda_fuujinKen`, skill #434)

- **Class-C Active Skill, Lv 75 / Bn 4, 50 MP / 70 SP (consumed)** (`decode_skilldata.py`; `PandaSkill.cs:1381-1406`).
- **Cooldown & Timing:**
  - Base Cooldown: `240s` (`Panda.cs:86`, `Panda.cs:41124`: `addTimeOut("fuujinKen", agiAdjust(240f))`).
  - Cast Time: `0s` (Instant cast, `mode = eSkillMode.instant`).
  - Animation & Ticks: Coroutine `$RPC_fuujinKen$25688` (`Panda.cs:40786-41481`). Startup 1.0s (0.5s + 0.5s) -> Tornado spin 8.0s (20 ticks at 0.4s interval) -> Recovery 0.7s (total 9.7s).
- **Buff & Status:**
  - Grants self status `[noForce]` at Level 1 for 9 seconds fixed upon initiation (`Panda.cs:41159`: `mChar.StartCoroutine_Auto(mChar.addStatus("noForce", 1, 9, 0, mChar.ActorNr))`).
- **AoE & Pull Mechanic:**
  - Scans enemies in a 12m radius and 9m height around Panda (`Panda.cs:41352`: `Damage.FindAreaTarget(pos, 12f, 9f, hitLayer)`).
  - Enemies with `sqrMagnitude > 4` (distance > 2m) are pulled inward towards Panda: `hitForce = 0.5f * Math.vFlat(-hitDir)` (`Panda.cs:41402`).
  - Enemies within 2m (`sqrMagnitude <= 4`) are lifted slightly (`Vector3.up`) and spawn `fuujinKen_hit` effect (`Panda.cs:41391`, `:41420`).
- **Damage Formula:**
  - `hitDmg = Mathf.Clamp(0.004f * (225f - hitDistance), 0.25f, 1f) * (ATK + talAdjust(15))` (`Panda.cs:41386`).
  - Distance scaling: scales from 90% at 0m (`0.004 * 225 = 0.90`) down to ~32.4% at 12m (`0.004 * (225 - 144) = 0.324`), clamped to minimum 25% (0.25) and maximum 100% (1.0).
  - KO: `0` (`Panda.cs:41408`).
  - Focused Art: does not apply (no SP scaling in formula).

### Raijin Ken (`panda_raijinKen`, skill #444)

- **Class-C Active Skill, Lv 85 / Bn 6, 70 MP / -90 SP (generates 90 red SP)** (`decode_skilldata.py`; `PandaSkill.cs:1422-1448`).
  - Requires Fuujin Ken (`rSkill: 434`).
  - Target Mode: `eSkillMode.target`, `eSkillTarget.enemy` (`PandaSkill.cs:1432-1437`).
  - Targeting Range: Target lock range on screen up to **35m** (`vector.sqrMagnitude < 1225` in `GameGui.cs:11285`, `:21120`; Tab cycle max 36m in `GameGui.cs:2168`). No distance cap once target is locked.
- **Cooldown & Timing:**
  - Base Cooldown: `300s` (`Panda.cs:89`, `Panda.cs:42057`: `addTimeOut("raijinKen", agiAdjust(300f))`).
  - Cast Time: `0s` (Instant cast bar).
  - Animation Coroutines: `$RPC_raijinKen$25705` (`Panda.cs:41542-42245`) and `$RPC_raijinKen_hit$25717` (`Panda.cs:42290-42595`).
    - Charge-up 1: 0.7s (`cAttack1`).
    - Charge-up 2: 0.5s (`cAttack2`, looping charge). Total charge: 1.2s.
    - Leap: Panda receives `[hide]` (Lv 1, 1s duration, mid-air invulnerability frame, `Panda.cs:41732`).
    - Impact dispatch: Dispatches `$RPC_raijinKen_hit$25717` at target's front boundary (`fPos = target.bounds.center - bounds.extents.x * fDir`).
    - Recovery: 0.8s (`raijinKen2`). Total sequence: ~2.4s.
- **AoE & Visuals:**
  - Impact delay: 0.4s (`Panda.cs:42587`).
  - AoE Area: Scans enemies in **8m radius and 8m height** around impact position (`Panda.cs:42421`: `Damage.FindAreaTarget(hitPos, 8f, 8f, hitLayer)`).
  - Visual: Spawns `raijinKen_hit` effect, activates cinematic camera `Camera/effectCamera` (`Panda.cs:42546-42554`), and adds full-screen `whiteRamp` flash (`Panda.cs:42464`).
- **Damage & Knockout Formula:**
  - `mChar.hit(444, hitObject, 4 * atk + talAdjust(180), 60, 0, Vector3.zero)` (`Panda.cs:42444`).
  - Damage Formula: `4.0 × ATK + talAdjust(180)`
  - Knockout (KO): `60` (instant knockdown)
  - Hit Count: `1`
  - Focused Art: does not apply (no SP scaling in formula).
