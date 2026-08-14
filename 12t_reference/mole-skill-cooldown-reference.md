# Mole — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| reload | Reload | 2 | 240 | true | false | — | — |
| mine | Landmine | 4 | 15 | true | false | 60 | true |
| mortarShot | Mortar Shot | 2 | 30 | true | false | — | — |
| bunker | Bunker | 2 | 30 | true | false | — | — |
| tnt | TNT | 4 | 90 | true | false | — | — |
| stunMine | Stun Mine | 2 | 45 | true | false | 60 | false |
| stunGrenade | Stun Grenade | 2 | 60 | true | false | — | — |
| flameTurret | Flame Turret | 3 | 120 | true | false | 5 | true |
| fireBarrage | Fire Barrage | 2 | 120 | true | false | — | — |
| bombardment | Bombardment | 2 | 180 | true | false | — | — |
| timeNuke | Time Nuke | 2 | 360 | true | false | 60 | false |
| detonate | Detonate | 1 | 360 | true | false | — | — |
| autoGyroGun | Auto Gyro Gun | 4 | 30 | true | false | 120 | true |
| barrelBot | Barrel Bot | 4 | 240 | true | false | ∞ | — |
| megaPunch | Mega Punch | 2 | 30 | true | false | — | — |
| megaHammer | Mega Hammer | 2 | 30 | true | false | — | — |
| chopper | Chopper | 3 | 45 | true | false | — | — |
| missile | Missile | 4 | 60 | true | false | — | — |
| synchroMole | Synchro Mole | 2 | 300 | true | false | 30 | true |
| kingKaiser | King Kaiser | 1 | 999 | true | false | 240 | true |
| advanceRepair | Advance Repair | 1 | 30 | true | false | — | — |
| napalm | Napalm | 1 | 150 | true | false | — | — |
| grenadeCluster | Grenade Cluster | 1 | 120 | true | false | — | — |
| flameCarnival | Flame Carnival | 1 | 150 | true | false | 90 | true |
| megaDrill | Mega Drill | 1 | 30 | true | false | — | — |
| barrelCannon | Barrel Cannon | 1 | 120 | true | false | — | — |
| warFactory | War Factory | 1 | 180 | true | false | — | — |
| warCapital | War Capital | 1 | 300 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Mole's own thematic `mineWalker`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Mole.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Mole.cs:14797`), `psalmOfEnergy`
  (`Mole.cs:15037`), `seaAegis` (`Mole.cs:15206`), `zephyrLore` (`Mole.cs:15400`), `replenishment`
  (`Mole.cs:15501`), `elementalBound` (`Mole.cs:15631`), `astralShift` (`Mole.cs:15783`), `bloodCarnage`
  (`Mole.cs:15974`), `obsidianFang` (`Mole.cs:44521`), `assassinate` (`Mole.cs:44982`), `mineWalker`
  (`Mole.cs:45367`), `divineChannel` (`Mole.cs:45722`) — all 12 present, all bare-`600`. A direct grep of
  `MoleSkill.cs` for `mineWalker` (Mole's own thematically-named support skill) returns zero matches,
  confirming it isn't part of Mole's own learnable-skill roster (`getSkill()`). All 12 excluded.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.** Both
  carry their own cooldown handling in `Mole.cs` (e.g. `addTimeOut("nAttack", 1f)` at `Mole.cs:9542`,
  `20602`, `20901`; `addTimeOut("cAttack", 1f)` at `Mole.cs:22281`) and their own `getSkill()` entries
  (`mol_nAttack1`-`4`, `mol_cAttack1`-`3`), but are excluded regardless per the plan's blanket policy.
- **`mount` is not a Mole class skill — excluded, not a judgment call.** `Mole.cs:50251` —
  `this.$self_$24222.mChar.addTimeOut("mount", (float)12);` — sits inside `$RPC_useMount$24211`, the
  universal ride-a-mount action shared by every class. `MoleSkill.cs` has no `cType`/`getSkill()` entry
  for `"mount"` at all (see support-skill note above), confirming it isn't part of Mole's learnable roster.
- **`tnt1`-`tnt4` share one cast site, one command, and one cooldown key pattern — combined into a
  single row, following the Chameleon doc's `slayer`/`allSlayer` precedent.** `MoleSkill.cs` lists four
  separately-learnable entries, each setting its own literal `cType` (`"tnt1"` at `MoleSkill.cs:321`,
  `"tnt2"` at `:354`, `"tnt3"` at `:387`, `"tnt4"` at `:420`, req levels 7/13/19/25 respectively). At the
  source level all four route through the **same** `$RPC_tnt$23591` coroutine (`Mole.cs` — wrapper at
  `11005`, body class at `25639`), which takes a single `sLv` parameter (1-4) and sets cooldown via
  `addTimeOut("tnt" + sLv, agiAdjust((float)90))` (`Mole.cs:26180`) — a flat `90` regardless of which
  tier's `sLv` is passed in. This table reports it as one skill, **Max Rank 4**, Skill ID `tnt` standing
  in for the dynamic `tnt1`-`tnt4` keys.
- **`autoGyroGun`, `barrelBot`, and `warCapital` all cast through one shared "assemble" coroutine,
  `$RPC_assemble1$23522` (`Mole.cs:22908-23596`), following the Chameleon doc's shared-cast-site
  precedent for `trueInvisibility`/`massInvisibility`/`finalEntrapment`.** The coroutine switches on a
  `sType` string set per-caller and applies one shared `addTimeOut(sType, agiAdjust(mTimeOut))` call at
  `Mole.cs:23429`, with `mTimeOut` set per branch just above it: `"autoGyroGun"` → `mTimeOut = 30`
  (`Mole.cs:23364`), `"barrelBot"` → `mTimeOut = 240` (`Mole.cs:23381`), `"warCapital"` → `mTimeOut = 300`
  (`Mole.cs:23398`). `getSkill()` confirms `autoGyroGun1`-`4` (`MoleSkill.cs:1924`), `barrelBot1`-`4`
  (`MoleSkill.cs:1836`), and the Class-C `mol_warCapital5` (`MoleSkill.cs:1607`) as the three skills that
  actually call into this shared coroutine (`Mole.cs:23193`, `23243`, `23283` for the three `sType`
  branches).
- **`heavyBuilt1`/`heavyBuilt2`, `speedDrill1`/`speedDrill2`, and `skyDrill1`/`skyDrill2` all fall through
  `getSkill()`'s obfuscated tail to the *same* terminal block as `synchroMole` (`cType = "synchroMole"`,
  `MoleSkill.cs:1619-1644`) purely because none of their branches set a `cType`/`goto` of their own — this
  is a dead-code convergence artifact, not a real shared skill, and all six are excluded as separate
  passives.** Confirmed via `MoleSkill_eng.cs` descriptions and the absence of any dedicated
  `addTimeOut`/`RPC_<name>` cast site: `heavyBuilt1`/`2` = "Increases HP of all Mole's creations by
  50%/100%" (`MoleSkill_eng.cs:807`, `818`), a flat passive stat bonus (used via `getHeavyBuiltLv()`,
  `Mole.cs:13213`, not cast). `speedDrill1`/`2` = "Increases digging's movement speed... reduce the
  digging time" (`MoleSkill_eng.cs:598`, `609`), a passive movement modifier. `skyDrill1`/`2` = "Enables
  Mole to finish 3s or longer digging with an upward drill attack" (`MoleSkill_eng.cs:620`, `631`) — this
  one does have its own dedicated coroutine, `RPC_skyDrill` (`Mole.cs:12265`, body `31496`), but it is
  **auto-triggered** from inside the `cAttack1` (digging) action once `skyDrillLv > 0` and the dig has
  lasted 3+ seconds (`Mole.cs:9987-10005`) — it is never independently cast and has no `addTimeOut` of its
  own anywhere in `Mole.cs`. Only `synchroMole1`/`synchroMole2` (`MoleSkill.cs:952`, `969`, req levels
  30/33, the actual "Temporary adds 50%/100% of Mole's talent to his creations' attack and defense power"
  skill per `MoleSkill_eng.cs:829`, `840`) are genuinely cast via `RPC_synchroMole` — this table reports
  **Max Rank 2** for `synchroMole`, not 4.
- **`mine` and `stunMine`'s cooldowns are conditionally halved by a separate passive (`hasSkill(402)`,
  almost certainly `mineLover5`, "reduces their cooldowns by 50%" per `MoleSkill_eng.cs:939`) — this table
  reports the un-passived base value.** `mine`: `Mole.cs:23891-23905` —
  `if (this.$self_$23546.mChar.hasSkill(402)) { addTimeOut("mine", agiAdjust(8)); } else { addTimeOut("mine", agiAdjust(15)); }`
  — base `15` reported. `stunMine`: `Mole.cs:26680-26694`, identical pattern — base `45` reported
  (passived value `23`).
- **`fireBarrage` and `bombardment` each have a second, unrelated `addTimeOut` call using the same
  cooldown key with a trivial `0.5f` value — this is an internal multi-volley sequencing delay, not the
  skill's real cooldown, and is excluded.** `fireBarrage`: `Mole.cs:28748` —
  `addTimeOut("fireBarrage", 0.5f);` (bare, unwrapped) paired with `this.ww8gUcG76C = Time.time + 2f;`
  immediately after — throttles the interval between the 1-3 air-support volleys the skill calls in, not
  a re-castable cooldown. `bombardment`: `Mole.cs:29629`, identical pattern. The real cooldowns (120 and
  180 respectively) are set earlier in each coroutine (`Mole.cs:28602`, `29483`).
- **`flameTurret`'s duration is a channel-lifetime field, not `RPC_AddStatus` — reported as a genuine
  Duration value, following the Chameleon doc's `campFire`/`finalEntrapment` precedent that a
  hardcoded/computed value applied outside `RPC_AddStatus` is still usable.** `Mole.cs:27935` —
  `this.$mDuration$23650 = (float)this.$self_$23661.mChar.chaAdjust(5);` — gates how long the
  turret-operate channel state lasts, checked at `Mole.cs:27984` —
  `if (Time.time >= this.$self_$23661.mChar.actionTime + this.$mDuration$23650)` — to end the channel.
  chaAdjust-wrapped, non-contested, self-only.
- **`timeNuke`'s duration is a flat fuse-timer field in the spawned prop's own script
  (`Mole_timeNuke.cs`), not `RPC_AddStatus` — reported as a genuine Duration value, `Duration Wrapped =
  false`.** `Mole_timeNuke.cs:56` — `this.DOBdTpEK5v = Time.time;` (set on spawn) — then
  `Mole_timeNuke.cs:241` — `if (this.DOBdTpEK5v + (float)60 <= Time.time + (float)1)` — self-detonates
  the bomb 60 seconds after being placed, matching the eng description "explodes after 60 seconds"
  (`MoleSkill_eng.cs:521`). Bare literal `60`, confirmed not `chaAdjust`- or any-Adjust-wrapped.
- **`kingKaiser`'s duration is applied via `addStatus(...)`, not literally `RPC_AddStatus(...)` — same
  signature, reported as the skill's genuine Duration value.** `Mole.cs:35789` —
  `this.$mDuration$23851 = this.$self_$23861.mChar.chaAdjust(240);` — then applied twice in
  `$RPC_kingKaiser_create$23849`: to the summoned King Kaiser object (`Mole.cs:36023` —
  `this.$tChar$23853.StartCoroutine_Auto(this.$tChar$23853.addStatus("transform", 1,
  this.$mDuration$23851, 0, ...));`) and to Mole himself (`Mole.cs:36135` —
  `this.$self_$23861.mChar.StartCoroutine_Auto(this.$self_$23861.mChar.addStatus("hide", 1,
  this.$mDuration$23851, 0, ...));`, hiding Mole's model while the King Kaiser mech is active) — a
  240-second, chaAdjust-wrapped mech-transformation window, matching the huge 999s recast cooldown for
  what is effectively a per-match ultimate. A separate, smaller `RPC_AddStatus("noForce", 1, 5, 0, ...)`
  call also fires at cast time (`Mole.cs:35401`, flat literal `5`, not chaAdjust-wrapped) — a brief
  anti-knockback grace period on the transform itself, not the mech's active duration, so it is **not**
  used as this table's reported Duration value.
- **`warFactory`'s real cast site is `RPC_cartBomb`, not a dedicated `RPC_warFactory` — the "five secret
  weapons" (`sawMachine`, `bazooka`, `teslaCoil`, `rollerMachine`, plus the `cartBomb` deploy itself) are
  the deployed structure's own randomized sub-attacks, not separately learnable skills.** `getSkill()`
  has exactly one `mol_warFactory5` entry (`MoleSkill.cs:1539`, Class C); casting it plays the
  `"warFactory"` animation and sets `myCommand = "cartBomb"` inside `$RPC_cartBomb$24030`, with the real
  cooldown at `Mole.cs:43394` — `addTimeOut("warFactory", agiAdjust((float)180));` (matching a
  spawn-time preemptive `addTimeOut("warFactory", agiAdjust(180f))` at `Mole.cs:118`, same
  zeroShot/thunderDragon-style precedent from the Chameleon doc). `RPC_sawMachine`, `RPC_bazooka`,
  `RPC_teslaCoil`, and `RPC_rollerMachine` (`Mole.cs:13956`, `14006`, `14056`, `14063`) are the deployed
  factory's own randomly-cycled turret behaviors — each briefly re-uses the `"warFactory"` cooldown key
  with a bare `addTimeOut("warFactory", agiAdjust((float)3))` as an internal attack-cycle throttle
  (`Mole.cs:40814`, `41388`, `41900`, `42687`), not a re-castable player cooldown. `RPC_rollerMachine`
  also applies a flat, non-contested `RPC_AddStatus("paralysis", 2, 3, 0, ...)` proc to hit enemies
  (`Mole.cs:42109`) — excluded from this table as an incidental turret-attack side effect (not a duration
  tied to casting `warFactory` itself), the same reasoning the Chameleon doc used to exclude
  `thunderDragon`'s reflect-paralysis proc.
- **`advanceRepair` is a channeled heal with no fixed duration — Duration `—`.** `$RPC_advanceRepair$23866`
  (`Mole.cs:36263-37520`) heals the target 150 hp/sec and drains 1 sp/sec from Mole in a loop
  (`Mole.cs:36676-36699`) that continues until the target dies, Mole runs out of sp, moves too far, or
  moves at all — it is not gated by a fixed timer or `RPC_AddStatus` call, so it has no reportable
  Duration value, matching the eng description's "Restore 150hp/sec to any target friendly machines or
  structures" with no stated time limit.
- **No `RPC_AddStatus`/field-effect-lifetime/`addStatus` call exists for**: `reload`,
  `mortarShot`, `bunker`, `tnt`, `stunGrenade`, `fireBarrage`, `bombardment`, `detonate`,
  `barrelBot`, `megaPunch`, `megaHammer`, `chopper`, `missile`, `napalm`,
  `grenadeCluster`, `megaDrill`, `barrelCannon`, `warFactory`, `warCapital` — confirmed
  by cross-checking each skill's cast-site coroutine class body against the full-file `RPC_AddStatus`/
  `.addStatus(`/`.life = ` grep results. These are pure-damage, pure-utility, or summon-creation skills
  with no self/target buff-duration of their own. Duration cells are `—`.
- **`autoGyroGun` is no longer in the list above — it does have a real, verified summon lifetime, just
  not via `RPC_AddStatus`.** `Mole.cs:12235` — inside the summon-creation branch (immediately after the
  `AutoGyroGun` component lookup), `autoGyroGun.StartCoroutine_Auto(autoGyroGun.create(this.mChar,
  this.mChar.ActorNr, this.mChar.chaAdjust(120)));` — the turret's own `create(CharacterControl,
  int, float)` receives `chaAdjust(120)` as its lifetime directly, no companion-file `Init()` indirection
  needed for this one.
- **`mine` and `stunMine` are also no longer in the bulk list above — re-checked 2026-08-14 (user request)
  and each has a real, verified prop-lifetime via the `Init(nLife, ...)` companion-file pattern (same
  shape as Rabbit's `stickyGum`/`acidicField`/`healingField`), not `RPC_AddStatus`.** `mine`: spawn/`Init`
  at `Mole.cs:24233` → `Mole_mine.cs:60` — `this.aO9boyDZyA = (int)((float)this.lwlbygsWTr.chaAdjust(60) +
  Time.time);` — **`chaAdjust(60)`**, self-scaled off the placer's own CHA; enforced in
  `Mole_mine.cs:146-163`'s `Update()`, `Destroy` on expiry unless already detonated. `stunMine`: `Init` at
  `Mole.cs:27019` → `Mole_stunMine.cs:60` — `this.XYwd2vIXAX = (int)((float)this.MAZdRGaitt.talAdjust(60) +
  Time.time);` — **`talAdjust(60)`, not `chaAdjust`** (a genuinely different scaling stat — TAL, not CHA,
  independently re-confirmed 2026-08-14 by reading `Mole_stunMine.cs` directly and cross-checking
  `talAdjust` is a real `CharacterControl` method, `CharacterControl.cs:20624` — not a mis-citation);
  same `Update()`-gated `Destroy` pattern at `Mole_stunMine.cs:146-163`. Since this tool has no TAL
  input, `stunMine`'s reported `60` is the TAL-unadjusted base (`talAdjust`'s own baseline at TAL=0
  equals the raw value), and `Duration Wrapped` is reported `false` even though the value does genuinely
  scale in-game — same convention as Chameleon's `tent`/`magAdjust` case, flagged here so the lookup
  tool doesn't read `false` as "never scales, period."
- **`flameCarnival`'s reported `chaAdjust(90)` is the unarmed trap's own arming-window despawn timer,
  NOT the fire hazard's active/burn duration — flagged explicitly 2026-08-14 after the user correctly
  caught that 90s (~225s at 100 CHA) reads nothing like the skill's actual ~10s in-game hazard window,
  then asked to keep the trap-lifetime value once the distinction was clear.** `Mole_flameCarnival.cs:53`
  — `this.X83bE9HJAd = (int)((float)this.wZxb0yFo8I.chaAdjust(90) + Time.time);` governs how long the
  placed-but-unstepped-on trap prop sits before vanishing if nobody triggers it (an arming window, same
  category as a landmine's own sit-time) — this is genuinely what this table's Duration column reports
  for `mine`/`stunMine` too, so it's kept for consistency rather than excluded, but readers should not
  read it as "how long the fire burns." Once triggered (`Mole_flameCarnival.cs`'s `OnTriggerEnter`,
  cast site `Mole.cs:38659` `RPC_flameCarnival`), that trap object is destroyed almost immediately
  (`Mole.cs:39014`) and a **separate** coroutine, `RPC_flameCarnival_fire` (`Mole.cs:38844-39257`), takes
  over the actual damage/visual effect — a tick loop capped at `i >= 20` (`Mole.cs:39033`) with short
  yields (`WaitForSeconds(0.3f)`/`0.3f`/`0.5f` at the coroutine's entry states, then a
  `this.YieldDefault(1)` per subsequent tick, `Mole.cs:39020`) — clearly much shorter than 90s and
  consistent with the user's ~10s observation, but its exact total could not be pinned to one citable
  number: `YieldDefault`'s own implementation lives in the compiled `GenericGeneratorEnumerator<
  WaitForSeconds>` base class, which has no `.cs` source in this repo (only call sites), so its per-tick
  wait can't be independently confirmed the way every other citation in this doc-family is. This active-
  burn duration is NOT what the table's Duration column reports for this skill — only the arming window
  is, per the above.
- **`barrelBot` was specifically re-checked (user question, 2026-08-13) and confirmed to have no timed
  lifetime at all — unlike `autoGyroGun`, `flameTurret`, `synchroMole`, and `kingKaiser`, all of which
  do.** `barrelBot.create(int nCreatorID)` (`BarrelBot.cs:1920`, called `Mole.cs:13005`) takes only the
  creator's ActorNr — no life/duration parameter of any kind. A full-file grep of `BarrelBot.cs` (6660
  lines) for `chaAdjust` returns zero hits, and its only two `Destroy(this.gameObject)` calls are both
  conditional on death/disconnect state, not a timer: `:366` fires when `!this.mCreatorChar` (creator
  gone), `:6529` fires when `this.mChar.actionState == "dead"` (the bot itself was killed). Barrel Bot
  persists until it dies or its owner disconnects, not for a fixed duration. **Reported as `∞` (2026-08-14,
  at the user's request) rather than `—`** — the lookup tool now distinguishes "confirmed no timer,
  persists until death/unsummon/disconnect" (an infinity-icon Duration chip) from "no citable Duration
  data of any kind" (a plain `—`); this is the former, not the latter.
- **Confirmed-passive skills excluded from the table (no cooldown, `mode = eSkillMode.passive` in
  `getSkill()`, no `RPC_<name>` cast handler in `Mole.cs`):** `gadgeteer1`-`4` (Workshop crafting-tier
  unlock), `statPlus1`-`4` and `superStatPlus5` (flat stat bonuses), `extraPowder1`-`3` (blast-radius
  bonus), `smartShell1` (landmine/grenade damage bonus), `kaiserCannon1`/`kaiserBeam1` (King Kaiser
  stat/attack unlocks), `cannonExpert5`, `superDig5`, `geniusInvention5`, `mineLover5`, `superTNT5`,
  `hiddenTurret5`, `skyShaker5`, `doubleBot5`, `revisedSkill5`, `revisedMagic5`, `revisedArt5` (all flat
  stat/cost/cooldown modifiers for other skills) — plus `heavyBuilt1`/`2` and `speedDrill1`/`2`/
  `skyDrill1`/`2` covered in the `synchroMole` note above.

### CD citations
- `reload` CD: `Mole.cs:10316` — `this.mChar.addTimeOut("reload", this.mChar.agiAdjust((float)240));`
- `mine` CD: `Mole.cs:23905` — `this.$self_$23546.mChar.addTimeOut("mine", this.$self_$23546.mChar.agiAdjust((float)15));` (base; `Mole.cs:23897` sets `8` when `hasSkill(402)` — see judgment-call note)
- `mortarShot` CD: `Mole.cs:24792` — `this.$self_$23575.mChar.addTimeOut("mortarShot", this.$self_$23575.mChar.agiAdjust((float)30));`
- `bunker` CD: `Mole.cs:25319` — `this.$self_$23586.mChar.addTimeOut("bunker", this.$self_$23586.mChar.agiAdjust((float)30));`
- `tnt` CD: `Mole.cs:26180` — `this.$self_$23605.mChar.addTimeOut("tnt" + this.$sLv$23604, this.$self_$23605.mChar.agiAdjust((float)90));` (flat regardless of sLv 1-4; see judgment-call note)
- `stunMine` CD: `Mole.cs:26694` — `this.$self_$23614.mChar.addTimeOut("stunMine", this.$self_$23614.mChar.agiAdjust((float)45));` (base; `Mole.cs:26686` sets `23` when `hasSkill(402)`)
- `stunGrenade` CD: `Mole.cs:27516` — `this.$self_$23642.mChar.addTimeOut("stunGrenade", this.$self_$23642.mChar.agiAdjust((float)60));`
- `flameTurret` CD: `Mole.cs:28225` — `this.$self_$23661.mChar.addTimeOut("flameTurret", this.$self_$23661.mChar.agiAdjust((float)120));`
- `fireBarrage` CD: `Mole.cs:28602` — `this.$self_$23671.mChar.addTimeOut("fireBarrage", this.$self_$23671.mChar.agiAdjust((float)120));`
- `bombardment` CD: `Mole.cs:29483` — `this.$self_$23698.mChar.addTimeOut("bombardment", this.$self_$23698.mChar.agiAdjust((float)180));`
- `timeNuke` CD: `Mole.cs:30786` — `this.$self_$23734.mChar.addTimeOut("timeNuke", this.$self_$23734.mChar.agiAdjust((float)360));`
- `detonate` CD: `Mole.cs:31268` — `this.$self_$23743.mChar.addTimeOut("detonate", this.$self_$23743.mChar.agiAdjust((float)360));`
- `autoGyroGun` CD: `Mole.cs:23429` — `this.$self_$23536.mChar.addTimeOut(this.$sType$23532, this.$self_$23536.mChar.agiAdjust((float)this.$mTimeOut$23524));` with `$mTimeOut$23524 = 30` set at `Mole.cs:23364` (shared `assemble` coroutine — see judgment-call note)
- `barrelBot` CD: `Mole.cs:23429` (shared, see above) with `$mTimeOut$23524 = 240` set at `Mole.cs:23381`
- `megaPunch` CD: `Mole.cs:32662` — `this.$self_$23778.mChar.addTimeOut("megaPunch", this.$self_$23778.mChar.agiAdjust(30f));`
- `megaHammer` CD: `Mole.cs:33228` — `this.$self_$23794.mChar.addTimeOut("megaHammer", this.$self_$23794.mChar.agiAdjust(30f));`
- `chopper` CD: `Mole.cs:34019` — `this.$self_$23813.mChar.addTimeOut("chopper", this.$self_$23813.mChar.agiAdjust(45f));`
- `missile` CD: `Mole.cs:34777` — `this.$self_$23834.mChar.addTimeOut("missile", this.$self_$23834.mChar.agiAdjust((float)60));`
- `synchroMole` CD: `Mole.cs:13228` — `this.mChar.addTimeOut("synchroMole", this.mChar.agiAdjust((float)300));`
- `kingKaiser` CD: `Mole.cs:35380` — `this.$self_$23845.mChar.addTimeOut("kingKaiser", this.$self_$23845.mChar.agiAdjust((float)999));`
- `advanceRepair` CD: `Mole.cs:36716` — `this.$self_$23874.mChar.addTimeOut("advanceRepair", this.$self_$23874.mChar.agiAdjust((float)30));`
- `napalm` CD: `Mole.cs:37392` — `this.$self_$23891.mChar.addTimeOut("napalm", this.$self_$23891.mChar.agiAdjust((float)150));`
- `grenadeCluster` CD: `Mole.cs:38123` — `this.$self_$23917.mChar.addTimeOut("grenadeCluster", this.$self_$23917.mChar.agiAdjust((float)120));`
- `flameCarnival` CD: `Mole.cs:38662` — `this.$self_$23926.mChar.addTimeOut("flameCarnival", this.$self_$23926.mChar.agiAdjust((float)150));`
- `megaDrill` CD: `Mole.cs:39724` — `this.$self_$23959.mChar.addTimeOut("megaDrill", this.$self_$23959.mChar.agiAdjust(30f));`
- `barrelCannon` CD: `Mole.cs:40199` — `this.$self_$23971.mChar.addTimeOut("barrelCannon", this.$self_$23971.mChar.agiAdjust(120f));`
- `warFactory` CD: `Mole.cs:43394` — `this.$self_$24038.mChar.addTimeOut("warFactory", this.$self_$24038.mChar.agiAdjust((float)180));` (inside `RPC_cartBomb` — see judgment-call note; matching preemptive set at `Mole.cs:118`)
- `warCapital` CD: `Mole.cs:23429` (shared `assemble` coroutine, see `autoGyroGun` above) with `$mTimeOut$23524 = 300` set at `Mole.cs:23398` (matching preemptive set at `Mole.cs:121`)

### Duration citations
- `flameTurret` Duration: `Mole.cs:27935` — `this.$mDuration$23650 = (float)this.$self_$23661.mChar.chaAdjust(5);` (channel-lifetime field gating `Mole.cs:27984`, not `RPC_AddStatus` — see judgment-call note)
- `timeNuke` Duration: `Mole_timeNuke.cs:56` — `this.DOBdTpEK5v = Time.time;`, fuse checked at `Mole_timeNuke.cs:241` — `if (this.DOBdTpEK5v + (float)60 <= Time.time + (float)1)` (flat literal `60`, confirmed NOT Adjust-wrapped — spawned-prop fuse timer, see judgment-call note)
- `synchroMole` Duration: `Mole.cs:13242` — `this.mChar.RPC_AddStatus("synchroMole", sLv, num, this.mChar.tal, this.mChar.ActorNr);` with `num = this.mChar.chaAdjust(30)` set at `Mole.cs:13237` (self-buff, not target-contested)
- `kingKaiser` Duration: `Mole.cs:36023` — `this.$tChar$23853.StartCoroutine_Auto(this.$tChar$23853.addStatus("transform", 1, this.$mDuration$23851, 0, this.$self_$23861.mChar.ActorNr));` and `Mole.cs:36135` — `this.$self_$23861.mChar.StartCoroutine_Auto(this.$self_$23861.mChar.addStatus("hide", 1, this.$mDuration$23851, 0, this.$self_$23861.mChar.ActorNr));`, with `$mDuration$23851 = this.$self_$23861.mChar.chaAdjust(240)` set at `Mole.cs:35789` (`addStatus`, not literally `RPC_AddStatus` — see judgment-call note)
- `autoGyroGun` Duration (summon lifetime, not `RPC_AddStatus`): `Mole.cs:12235` — `autoGyroGun.StartCoroutine_Auto(autoGyroGun.create(this.mChar, this.mChar.ActorNr, this.mChar.chaAdjust(120)));` — see the dedicated judgment-call note above.
- `barrelBot`: re-checked and confirmed to have no timed lifetime at all (HP/disconnect-based instead) — see the dedicated judgment-call note above. Duration cell is `∞`.
- `mine` Duration (prop lifetime, not `RPC_AddStatus`): `Mole.cs:24233` → `Mole_mine.cs:60` — `this.aO9boyDZyA = (int)((float)this.lwlbygsWTr.chaAdjust(60) + Time.time);` — see the dedicated judgment-call note above.
- `stunMine` Duration (prop lifetime, not `RPC_AddStatus`, `talAdjust`-wrapped not `chaAdjust`): `Mole.cs:27019` → `Mole_stunMine.cs:60` — `this.XYwd2vIXAX = (int)((float)this.MAZdRGaitt.talAdjust(60) + Time.time);` — see the dedicated judgment-call note above.
- `reload`, `mortarShot`, `bunker`, `tnt`, `stunGrenade`, `fireBarrage`, `bombardment`,
  `detonate`, `megaPunch`, `megaHammer`, `chopper`, `missile`,
  `advanceRepair`, `napalm`, `grenadeCluster`, `megaDrill`, `barrelCannon`, `warFactory`,
  `warCapital`: no usable Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists in
  the skill's own coroutine class body; see the bulk judgment-call notes above (`advanceRepair`'s channel
  mechanic and `warFactory`'s excluded `rollerMachine` proc get their own dedicated notes). Duration
  cells are `—`.
- `flameCarnival` Duration (unarmed-trap arming window, not the fire's own burn time — see the dedicated
  judgment-call note above): `Mole.cs:38518,38559` → `Mole_flameCarnival.cs:53` —
  `this.X83bE9HJAd = (int)((float)this.wZxb0yFo8I.chaAdjust(90) + Time.time);`
