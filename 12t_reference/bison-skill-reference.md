# Bison — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| enrage | Enrage | 4 | 30 | true | false | 12 | true |
| slam | Slam | 2 | 30 | true | false | — | — |
| trample | Trample | 2 | 120 | true | false | — | — |
| knockDown | Knock Down | 4 | 30 | true | false | — | — |
| farStun | Far Stun | 2 | 120 | true | false | — | — |
| instantRush | Instant Rush | 1 | 30 | true | false | — | — |
| overPower | Over Power | 2 | 600 | true | false | 9 | true |
| powerCleave | Power Cleave | 2 | 30 | true | false | — | — |
| warcry | Warcry | 2 | 60 | true | false | 15 | true |
| ironShield | Iron Shield | 1 | 90 | true | false | 6 | true |
| diamondShield | Diamond Shield | 1 | 90 | true | false | 6 | true |
| earthRupture | Earth Rupture | 2 | 60 | true | false | — | — |
| earthSmasher | Earth Smasher | 2 | 180 | true | false | — | — |
| titanForm | Titan Form | 2 | 300 | true | false | 60 | true |
| onslaught | Onslaught | 1 | 300 | true | false | — | — |
| prideCrusher | Pride Crusher | 1 | 60 | true | false | — | — |
| magmaClutter | Magma Clutter | 1 | 90 | true | false | — | — |
| calamityHammer | Calamity Hammer | 1 | 150 | true | false | — | — |

## Citations

### Notes on judgment calls
- **Support-skill exclusion confirmed.** `SkillData.cs`'s 12 shared `getSupportSkill()` skills — including
  `stunningGround`, Bison's own thematic one — all appear in `Bison.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` at `Bison.cs:9369`, plus `psalmOfEnergy`
  (`Bison.cs:9609`), `seaAegis` (`Bison.cs:9778`), `zephyrLore` (`Bison.cs:9972`), `replenishment`
  (`Bison.cs:10073`), `elementalBound` (`Bison.cs:10203`), `astralShift` (`Bison.cs:10352`), `bloodCarnage`
  (`Bison.cs:10543`), `obsidianFang` (`Bison.cs:33149`), `assassinate` (`Bison.cs:33604`), `mineWalker`
  (`Bison.cs:33982`), `divineChannel` (`Bison.cs:34358`) — all 12 present, all bare-`600`. A direct grep of
  `BisonSkill.cs` for `bsn_<name>` variants of all 12 names returns zero matches, confirming none are part of
  Bison's own learnable skill roster. All 12 excluded from this table.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.** `nAttack`
  does have a genuine named cooldown: Bison's normal-attack combo stages carry their own bare (non-`agiAdjust`)
  `addTimeOut("nAttack", 1.5f)` calls at multiple combo-stage sites (e.g. `Bison.cs:15119`, `Bison.cs:15408`,
  `Bison.cs:16200`, `Bison.cs:16993`, `Bison.cs:18997`). A separate, unrelated `addTimeOut("nAttack", 1f)` also
  exists at `Bison.cs:4808` inside a special-event-minigame branch, irrelevant either way. `cAttack` has no
  cooldown at all — a repo-wide grep of `Bison.cs` for `cAttack` combined with `addTimeOut`/`isTimeOut` returns
  zero matches (its only cast-rate gate is the generic action-lockout shared by all actions). Both are excluded
  from this table regardless, per the plan's blanket policy.
- **`berserkerRush`/`furyTrance`/`restingGlory` are passive, not active, despite calling `RPC_AddStatus` of
  their own.** `BisonSkill.cs`'s `getSkill()` sets `mode = eSkillMode.passive` for all three families' final
  (max-rank) fall-through blocks — `bsn_berserkerRush4` (`BisonSkill.cs:1749-1760`, via `goto IL_1CF1`),
  `bsn_furyTrance3`/`bsn_restingGlory1` (`BisonSkill.cs:1730-1741`, via `goto IL_287D`) — and none of the three
  ever gets a `skillClass.cType` assignment anywhere in the file (confirmed: a full-file grep for `cType = "`
  returns exactly 18 matches, and none of these three names is among them). `Bison.cs` never calls
  `addTimeOut("berserkerRush", …)` or `addTimeOut("furyTrance", …)` anywhere (confirmed via grep) — their
  `RPC_AddStatus("berserkerRush", …)` (`Bison.cs:7824`) and `RPC_AddStatus("furyTrance", …)` (`Bison.cs:7979`)
  calls fire from some other passive-triggered code path, not from an independently-cast, cooldown-gated
  skill. Excluded from this table on the "active = has a real cooldown at its own cast site" rule.
- **`knockDown`'s `afterShock` status is a conditional bonus from a separate passive, not knockDown's own
  effect — excluded, default (no-passive) value used.** `Bison.cs:23157` gates the
  `RPC_AddStatus("afterShock", …, Damage.getDebuff((float)15, casterCha, hitChar.cha), …)` call
  (`Bison.cs:23179`) behind `this.$hasAftershock$21165`, which is set at `Bison.cs:22967` to
  `this.$self_$21176.mChar.hasSkill(422)` — the separate `aftershock5` passive (out of scope). With that
  passive not learned, knockDown's own cast applies no status at all, so its Duration cells are `—` (this
  status would also be excluded on contested-duration grounds even if it fired unconditionally, since
  `Damage.getDebuff` factors in the target's own CHA).
- **`powerCleave`'s `cut` status is likewise a conditional bonus from a separate passive.**
  `Bison.cs:25953` gates `RPC_AddStatus("cut", 5, 1, 0, …)` (`Bison.cs:25975`) behind
  `this.$self_$21247.mChar.hasSkill(403)` — the separate `powerReel5` passive (out of scope, same skill ID
  referenced by `getPowerReelLv()` at `Bison.cs:9054-9057`). With that passive not learned, powerCleave's own
  cast applies no status, so its Duration cells are `—`.
- **`ironShield`/`diamondShield` each carry a conditional `+2`s bonus from a separate passive — excluded,
  default (no-passive) value used.** `ironShield`'s base duration is `chaAdjust(6)` (`Bison.cs:27691`), with a
  `+= 2` gated behind `hasSkill(433)` (`Bison.cs:27696-27702`) before the `RPC_AddStatus` call at
  `Bison.cs:27708`. `diamondShield` mirrors this exactly: base `chaAdjust(6)` (`Bison.cs:28278`), `+= 2` gated
  behind `hasSkill(443)` (`Bison.cs:28283-28289`), applied at `Bison.cs:28295`. Both gating skill IDs are
  distinct from ironShield's/diamondShield's own skill IDs, confirming they're separate passives (out of
  scope) — this table uses the un-bonused base value (6) for both, matching the `shadowMastery`/`demonGaze5`
  precedent in the existing Bat doc.
- **`enrage`'s duration scales with a separate passive (`rageControl5`), not with enrage's own rank.**
  `Bison.cs:20968` sets `$mDuration$21122 = chaAdjust(12 + 12 * getRageControlLv())`, where
  `getRageControlLv()` (`Bison.cs:9047-9050`) returns `1` only if `hasSkill(402)` (the separate `rageControl5`
  passive) is learned, else `0`. This table uses the default (`rageControl5` not learned) value: `chaAdjust(12)`.
- **CD values in this table are flat per-skill constants, not per-rank formulas.** Unlike Penguin's/Bat's
  shared `$mTimeOut$`-accumulator dispatcher (which scales CD by `sLv` inline), every Bison active skill's
  ranks (1 through however many it has) all funnel into a single shared `RPC_<name>` coroutine class that
  calls `addTimeOut` exactly once, unconditioned on the `sLv` parameter passed in — confirmed by inspecting
  each cast site (e.g. `Bison.cs:21055` for `enrage`, called identically whether the coroutine was started at
  rank 1 or rank 4, per the dispatch sites at `Bison.cs:3711-3765`). So the "max rank" CD value in this table
  is the same value that applies at every learned rank of that skill.
- **`onslaught`/`prideCrusher`/`magmaClutter`/`calamityHammer` are single-rank Class-C ultimates.** Each only
  has a `bsn_<name>5` entry in `BisonSkill.cs` (no `1`-`4` variants) — confirmed via grep, zero matches for
  `bsn_onslaught1` etc. — so Max Rank is `1` for all four, matching Penguin's precedent for its own single-cast
  Class C ultimates (`arcticEmperor`, `meteora`, etc.).

### CD citations
- `enrage` CD: `Bison.cs:21055` — `this.$self_$21126.mChar.addTimeOut("enrage", this.$self_$21126.mChar.agiAdjust(30f));`
- `slam` CD: `Bison.cs:21667` — `this.$self_$21140.mChar.addTimeOut("slam", this.$self_$21140.mChar.agiAdjust((float)30));`
- `trample` CD: `Bison.cs:22371` — `this.$self_$21157.mChar.addTimeOut("trample", this.$self_$21157.mChar.agiAdjust(120f));`
- `knockDown` CD: `Bison.cs:23269` — `this.$self_$21176.mChar.addTimeOut("knockDown", this.$self_$21176.mChar.agiAdjust(30f));`
- `farStun` CD: `Bison.cs:23938` — `this.$self_$21189.mChar.addTimeOut("farStun", this.$self_$21189.mChar.agiAdjust(120f));`
- `instantRush` CD: `Bison.cs:24358` — `this.$self_$21199.mChar.addTimeOut("instantRush", this.$self_$21199.mChar.agiAdjust(30f));`
- `overPower` CD: `Bison.cs:24846` — `this.$self_$21208.mChar.addTimeOut("overPower", this.$self_$21208.mChar.agiAdjust((float)600));`
- `powerCleave` CD: `Bison.cs:26237` — `this.$self_$21247.mChar.addTimeOut("powerCleave", this.$self_$21247.mChar.agiAdjust(30f));`
- `warcry` CD: `Bison.cs:27087` — `this.$self_$21262.mChar.addTimeOut("warcry", this.$self_$21262.mChar.agiAdjust((float)60));`
- `ironShield` CD: `Bison.cs:27790` — `this.$self_$21273.mChar.addTimeOut("ironShield", this.$self_$21273.mChar.agiAdjust((float)90));`
- `diamondShield` CD: `Bison.cs:28377` — `this.$self_$21284.mChar.addTimeOut("diamondShield", this.$self_$21284.mChar.agiAdjust((float)90));`
- `earthRupture` CD: `Bison.cs:28730` — `this.$self_$21293.mChar.addTimeOut("earthRupture", this.$self_$21293.mChar.agiAdjust((float)60));`
- `earthSmasher` CD: `Bison.cs:29381` — `this.$self_$21309.mChar.addTimeOut("earthSmasher", this.$self_$21309.mChar.agiAdjust((float)180));`
- `titanForm` CD: `Bison.cs:29879` — `this.$self_$21318.mChar.addTimeOut("titanForm", this.$self_$21318.mChar.agiAdjust((float)300));`
- `onslaught` CD: `Bison.cs:30606` — `this.$self_$21335.mChar.addTimeOut("onslaught", this.$self_$21335.mChar.agiAdjust((float)300));`
- `prideCrusher` CD: `Bison.cs:31023` — `this.$self_$21349.mChar.addTimeOut("prideCrusher", this.$self_$21349.mChar.agiAdjust(60f));`
- `magmaClutter` CD: `Bison.cs:31715` — `this.$self_$21365.mChar.addTimeOut("magmaClutter", this.$self_$21365.mChar.agiAdjust(90f));`
- `calamityHammer` CD: `Bison.cs:32264` — `this.$self_$21378.mChar.addTimeOut("calamityHammer", this.$self_$21378.mChar.agiAdjust(150f));`

### Duration citations
- `enrage` Duration: `Bison.cs:20968` — `this.$mDuration$21122 = this.$self_$21126.mChar.chaAdjust(12 + 12 * this.$self_$21126.getRageControlLv());`, applied at `Bison.cs:20973` — `RPC_AddStatus("enrage", sLv + getRageControlLv(), mDuration, 0, ActorNr)` (self-buff, not target-contested; default `rageControl5`-not-learned value used, see judgment-call note)
- `overPower` Duration: `Bison.cs:24764` — `this.$self_$21208.mChar.RPC_AddStatus("overPower", this.$sLv$21207, this.$self_$21208.mChar.chaAdjust(9), Mathf.Min(...), this.$self_$21208.mChar.ActorNr);` (self-buff, not target-contested)
- `warcry` Duration: `Bison.cs:26999` — `this.$tChar$21257.RPC_AddStatus("fear", this.$sLv$21261, this.$self_$21262.mChar.chaAdjust(15), Mathf.CeilToInt(0.1f * (float)this.$tChar$21257.atk), this.$self_$21262.mChar.ActorNr);` (applied to the enemy target, but the duration argument itself uses only the caster's own CHA via `chaAdjust` — not `Damage.getDebuff` — so not target-contested)
- `ironShield` Duration: `Bison.cs:27691` — `this.$mDuration$21269 = (float)this.$self_$21273.mChar.chaAdjust(6);`, applied at `Bison.cs:27708` — `RPC_AddStatus("ironShield", sLv, (int)mDuration, 0, ActorNr)` (self-buff; the conditional `+2`s bonus at `Bison.cs:27702` is excluded, see judgment-call note)
- `diamondShield` Duration: `Bison.cs:28278` — `this.$mDuration$21280 = (float)this.$self_$21284.mChar.chaAdjust(6);`, applied at `Bison.cs:28295` — `RPC_AddStatus("diamondShield", sLv, (int)mDuration, 0, ActorNr)` (self-buff; the conditional `+2`s bonus at `Bison.cs:28289` is excluded, see judgment-call note)
- `titanForm` Duration: `Bison.cs:29792` — `this.$self_$21318.mChar.RPC_AddStatus("titanForm", this.$sLv$21317, this.$self_$21318.mChar.chaAdjust(60), 0, this.$self_$21318.mChar.ActorNr);` (self-buff, not target-contested)
- `slam`, `trample`, `knockDown`, `farStun`, `instantRush`, `powerCleave`, `earthRupture`, `earthSmasher`,
  `onslaught`, `prideCrusher`, `magmaClutter`, `calamityHammer`: no `RPC_AddStatus` call exists anywhere in
  their respective `RPC_<name>` coroutine class bodies (confirmed by bounding each skill's class definition
  range in `Bison.cs` — e.g. `trample` spans `Bison.cs:21888-22760`, `earthSmasher` spans
  `Bison.cs:28935-29637` — and cross-checking against a full-file `RPC_AddStatus` grep) — these are pure-damage
  or pure-utility skills with no buff/debuff duration of their own. Duration cells are `—`. (`knockDown`'s and
  `powerCleave`'s conditional passive-gated bonus statuses are addressed separately above.)
