# Bison — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

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

---

# Damage & Mechanics

### bsn_solidHold5 (Solid Hold, #411): KO immunity while charging (verified 2026-09-28)

- **KO block:** in `RPC_AddDamage`, inside `if (this.Type == "Bison")` (`CharacterControl.cs:4011-4298`): `if (hasSkill(411) && actionState == "attack" && myCommand == "cAttack1") nKo = 0;` (`:4059-4075`), for direct hits (Effect Damage never reaches `RPC_AddDamage`). Sits inside the same `if (nDamage > 0)` as the #363/#364 retaliation, so it only applies to hits that deal damage (a 0-damage hit that carries KO is not blocked; not live-tested). Damage itself is not reduced here.
- **Tooltip:** `"Blocks all ko to Bison during its charged action. Increases HoldCharge's duration equal to charged time beyond 8 sec. (+12s max)"` (`BisonSkill_eng.cs:889`); code name `getSolidChangeLv()` = `hasSkill(411) ? 1 : 0` (`Bison.cs:9042`). The duration part is not traced here.
- Previously misattributed to Whale Shield Reflect (also #411) in [whale-skill-reference.md](whale-skill-reference.md).

### bsn_overPower1-2 (Over Power, #271-272): capped ATK self-buff (verified 2026-09-28)

- **Metadata:** ranks 1-2 require Lv 35/Bn 23 and Lv 40/Bn 25, respectively. Both cost 20 MP; SP costs are 60/80. The cast is instant and targets self (`BisonSkill.cs`; decoded with `scripts/decode_skilldata.py`).
- **Applied value:** casting adds `overPower` at the learned rank for `chaAdjust(9)` seconds. Its stored value is `min(ceil(0.5 × rank × current ATK), 256 × rank)` (`Bison.cs:24764`). Therefore rank 1 adds 50% current ATK capped at +256, while rank 2 adds 100% capped at +512.
- **ATK mutation:** status application calls `deltaAtk(sValue)` and creates the horn/ring effects (`CharacterControl.cs:35003-35013`); removal calls `deltaAtk(-num)` and destroys those effects (`CharacterControl.cs:15519-15535`). The value is thus a flat ATK delta captured when cast, not a persistent multiplier.
- **Titan Form exclusion:** Over Power refuses to cast while `titanForm` is active (`Bison.cs:6666-6681`), and Titan Form likewise refuses while `overPower` is active (`Bison.cs:6473-6479`).
- **Over Swing interaction:** while Over Power is active, owning Over Swing replaces the beginning of Charge Attack with Over Swing (`Bison.cs:5169-5280`).
- **Tooltip discrepancy:** the English tooltip claims rank 1 doubles ATK and rank 2 triples it (`BisonSkill_eng.cs:515-530`), but the executed formula only produces 1.5×/2× total ATK before the +256/+512 caps.
- **Cooldown:** `agiAdjust(600)` seconds in the original engine (`Bison.cs:24846`).

### bsn_overSwing1 (Over Swing, #273): Over Power charge replacement (verified 2026-09-28)

- **Metadata:** `bsn_overSwing1` is a single-rank passive requiring Lv 45/Bn 27, with no intrinsic MP/SP metadata cost (`BisonSkill.cs:538-554`; decoded with `scripts/decode_skilldata.py`). Its tooltip describes a special charged attack available during Over Power and states a 20 SP cost (`BisonSkill_eng.cs:537-545`).
- **Trigger and replacement:** `doBeginCharge()` checks that Bison is standing/running, has an `overPower` status level above 0, owns Over Swing (#273), and has no `overSwing` timeout; it then launches `RPC_overSwing` instead of the ordinary Charge Attack branch (`Bison.cs:5169-5280`, ordinary fallback at `:5282-5304`). Thus the move is activated by beginning Charge Attack while Over Power is active, not from a separate hotbar cast.
- **SP gate:** the trigger rejects activation when current SP is below 20, then deducts 20 SP normally or 10 SP with Revised Skill (#404) (`Bison.cs:5233-5255`). Consequently Revised Skill reduces the payment but does not reduce the minimum-SP activation requirement: the player still needs at least 20 SP before use.
- **Timing and cooldown:** the coroutine assigns a flat, unadjusted 1-second `overSwing` timeout (`Bison.cs:25445-25464`), waits 0.5 seconds before advancing (`:25622-25623`), then performs two hit scans 0.2 seconds apart (`:25287-25364`, `:25628-25629`). During the moving phase it sets `moveSpeed = 3` and ends by setting it to 0 before returning to standby (`:25219-25240`, `:25431-25439`, `:25367-25418`).
- **Hit areas:** hit 1 uses `FindAreaTarget(position, 6 × rangeMod, 3 × rangeMod, ...)`; hit 2 expands to radius `8 × rangeMod` with the same `3 × rangeMod` height (`Bison.cs:25287-25303`). Each scan builds a fresh target list, so a target inside both areas can be hit twice.
- **Damage per hit:** `((1 + 0.05 × BruteStrengthLv) × ATK) + talAdjust(10 × OverPowerLv)`, KO 1, force 0.5 (`Bison.cs:25241-25251`, `:25316-25342`). `getBruteStrengthLv()` counts learned Brute Strength ranks 1-4 (`Bison.cs:7302-7360`).
- **Raw Strength interaction:** with Raw Strength (#431), each `getBruteStrengthLv()` evaluation has one `lckAdjust(12)` roll; success multiplies the returned Brute Strength level by 5 (`Bison.cs:7361-7393`). Over Swing evaluates and stores this value once before either area scan (`Bison.cs:25241-25246`), so both hits share the same proc result. This changes the ATK contribution from `1 + 0.05 × rank` to `1 + 0.25 × rank` on a proc; the `talAdjust(10 × OverPowerLv)` term is unchanged. The tooltip's broad claim that Raw Strength increases normal/charged attack damage by 100% is not the literal executed formula (`BisonSkill_eng.cs:911-915`).


### bsn_bruteStrength1-4 (Brute Strength, #131-134): normal/charge ATK coefficient passive (verified 2026-09-29)

- **Metadata:** four passive ranks with no MP/SP cost. Requirements are Lv 8/Bn 4, Lv 16/Bn 6, Lv 24/Bn 8, and Lv 32/Bn 10 (`BisonSkill.cs`, decoded with `scripts/decode_skilldata.py`).
- **Resolved level:** `getBruteStrengthLv()` counts each learned rank #131 through #134, returning 0-4 (`Bison.cs:7302-7359`).
- **Consumers:** the resolved level is read once per execution by Combo stages 1-5 (`Bison.cs:14741`, `:15574`, `:16385`, `:17173`, `:18270`), Charge Attack 1 (`:20110`), and Over Swing (`:25241`). It is not a universal Bison damage multiplier.
- **ATK coefficients:** Combo stages 1/2 use `0.5 + 0.025×level` (`Bison.cs:14776`, `:15612`); stage 3 uses `0.6 + 0.03×level` (`:16423`); stages 4/5 each have their own `0.02×level` and `0.025×level` terms (`:17221`, `:17511`, `:18318`, `:18608`). Charge Attack 1 uses `0.5 + 0.025×level` plus its separate Controlled Swing term (`:20054`). Over Swing uses `1 + 0.05×level` (`:25326`).
- **Tooltip:** claims +5/+10/+15/+20% normal and charged damage (`BisonSkill_eng.cs:130-174`); the executable behavior is the move-specific coefficient additions above.

### bsn_rawStrength5 (Raw Strength, #431): fivefold Brute Strength proc (verified 2026-09-29)

- **Metadata:** single-rank passive, Lv 75/Bn 4, with no MP/SP cost (`BisonSkill.cs`, decoded with `scripts/decode_skilldata.py`).
- **Proc:** when Raw Strength is learned, every `getBruteStrengthLv()` evaluation rolls `lckAdjust(12)`; on success, the resolved Brute Strength level is multiplied by 5 (`Bison.cs:7361-7393`). This scales only the Brute Strength contribution, not the full attack damage.
- **Per-attack resolution:** because consumers cache the getter result at the start of their execution, multi-hit Combo stages and Over Swing reuse one proc result across their hits (`Bison.cs:17173`, `:18270`, `:25241-25326`).
- **Tooltip discrepancy:** the English tooltip says it has a 12% chance to increase normal/charged damage by 100% (`BisonSkill_eng.cs:911-919`); the real chance is LCK-adjusted and the real effect is a fivefold Brute Strength level.

### bsn_cAttack1-2 (Charge Attack, #111-112): spinning charged attack (verified 2026-09-29)

- **Metadata:** passive, no MP/SP cost, no cooldown. Rank 1 Lv 4/Bn 1, rank 2 Lv 10/Bn 3 (`BisonSkill.cs`, decoded with `scripts/decode_skilldata.py`).
- **Release gate:** `doReleaseCharge()` only spins when released at least 2 s after the charge began; earlier releases run `RPC_cAttack0`, which only returns Bison to standby and deals no damage (`Bison.cs:5372`, `:5455`, `:20554-20700`).
- **Hit count:** `num = floor(clamp(chargeSeconds, 2, 4 + (hasSkill(112) ? 4 : 0)))` (`Bison.cs:5378`), passed to `RPC_cAttack2` as `mChargeCount`; the loop performs one area scan per count (`:19893`, `:20016-20054`). Rank 1 = 2-4 hits, rank 2 = 2-8. The Bible card assumes a full charge (4 / 8).
- **Damage per hit:** `hit(11, target, (int)((0.5 + 0.025×BruteLv + (hasSkill(432) ? 0.1 : 0)) × ATK), KO 1, 0, force 0.5)` (`Bison.cs:20054`). `getBruteStrengthLv()` is cached once per release (`:20110`), so Raw Strength rolls once per spin. `getChargeAttackLv()` is read (`:20107`) but not used in the formula.
- **Area:** radius `5×rangeMod` (+2 with Spin Hack #432), height `3×rangeMod`, fresh target scan each hit (`Bison.cs:20016-20021`).
- **Rhythm:** each hit is followed by two waits of `0.2 − 0.033×ImprovedSwingLv` s (`Bison.cs:20464`, `:20468`) → 0.4 / 0.334 / 0.268 / 0.202 s per hit. `getImprovedSwingLv()` = 0-3 from #232-234 (`Bison.cs:7571-7620`). Improved Swing changes speed only, not hit count. The Thai tooltip's "2 hit/sec" is a rounding of 2.5 hits/s.
- **Movement:** `moveSpeed = 3` forward while spinning (`Bison.cs:20370`); with Controlled Swing (#231) the owner steers with camera-relative input (`:19943-19997`).
- **Hold Charge (#113):** a ≥2 s release stores `holdCharge` (sLv 1, sValue = hit count, duration `chaAdjust(3 + ControlledSwingLv) + floor(clamp(chargeSeconds − 8, 0, 12)) × SolidHoldLv`) instead of spinning (`Bison.cs:5383-5405`); the next attack press spins with the stored count (`:5089-5120`).
- **Spin Hack tooltip:** "range +40%, damage +10%" (`BisonSkill_eng.cs:970`); code is radius 5→7 and ATK coefficient +0.1 (0.5→0.6 base).
- **Tooltips:** `BisonSkill_eng.cs:79`, `:90`; `BisonSkill_thai.cs:81`, `:92`.

### bsn_holdCharge1 (Hold Charge, #113): stored charge status (verified 2026-09-29)

- **Metadata:** passive, Lv 16/Bn 5, no cost (`BisonSkill.cs`, decoded).
- **Store:** with #113, a release after ≥2 s calls `RPC_AddStatus("holdCharge", 1, sTime, hitCount)` and plays `RPC_cAttack0` instead of spinning (`Bison.cs:5388-5424`). `sTime = chaAdjust(3 + ControlledSwingLv) + floor(clamp(chargeSeconds − 8, 0, 12)) × SolidHoldLv` (`:5383`, `:5400`): Controlled Swing adds inside `chaAdjust`, Solid Hold's up-to-12 s is added after it, unscaled.
- **Release:** `doNormalAttack()` checks `getStatusLv("holdCharge") > 0` and, if `sValue ≥ 2`, starts `RPC_cAttack2` with `(int)sValue` hits (`Bison.cs:5089-5120`); `RPC_cAttack2` removes the status (`:20263-20269`). Beginning a new charge also removes it (`:19425`).
- **Status:** `holdCharge` = nCode 201 (`StatusData.cs:646`, `:2932`), classified State (`isStateStatus`, `:4836`) and Buff (`isBuffStatus`, `:6500`); no magical/physical/lock entry. Apply/remove only create/destroy the `holdChargeFx` effect (`CharacterControl.cs:34666`, `:15390`); `:12154` is a `Type != "Bison"` guard.
- **Tooltip:** `BisonSkill_eng.cs:101`, `BisonSkill_thai.cs:103` ("(3sec)").

### bsn_controlledSwing1 (Controlled Swing, #231): steering + Hold Charge time (verified 2026-09-29)

- **Metadata:** passive, Lv 9/Bn 3, no cost. `getControlledSwingLv()` = `hasSkill(231) ? 1 : 0` (`Bison.cs:7541-7560`).
- **Steering:** during `RPC_cAttack2` the owner's movement vector becomes camera-relative `Vertical/Horizontal` input added to the current direction (`Bison.cs:19943-19980`); without it Bison moves straight forward.
- **Hold Charge:** `chaAdjust(3 + 1)` (`Bison.cs:5400`). Matches the tooltip's "+1 sec" (`BisonSkill_eng.cs:354`).

### bsn_improvedSwing1-3 (Improved Swing, #232-234): spin speed + Combo spin chance (verified 2026-09-29)

- **Metadata:** passive, Lv 15/21/27, Bn 5/7/9, no cost. `getImprovedSwingLv()` = 0-3 (`Bison.cs:7571-7620`).
- **Charge Attack speed:** per-hit wait `2 × (0.2 − 0.033×lv)` s (`Bison.cs:20464`, `:20468`); hit count unchanged.
- **Combo 3rd attack:** after `nAttack2`, with Combo #103 learned, `num = 25 + 5×lv` (+15 with #104); `Random.Range(0,100) <= lckAdjust(num)` starts `RPC_nAttack4` (the spin) instead of `RPC_nAttack3` (`Bison.cs:4947-5004`). The `<=` makes the real chance `lckAdjust(num) + 1` %; the Bible chip shows `lckAdjust(40 + 5×rank)` (Combo max rank assumed) without the +1.
- **Tooltip discrepancy:** English says +5/+10/+15% (`BisonSkill_eng.cs:365`, `:376`, `:387`); Thai rank 3 says "5%" (`BisonSkill_thai.cs:422`), a client typo.

### bsn_spinHack5 (Spin Hack, #432): Charge Attack range and damage (verified 2026-09-29)

- **Effect:** Charge Attack radius `5×rangeMod + 2` and ATK coefficient `+0.1`, plus the `spinHack_ring` visual (`Bison.cs:20016`, `:20054`, `:20405-20429`). Other `hasSkill(432)` hits belong to Whale (`CharacterControl.cs:8951`, gobble) and Rabbit (`GameGui.cs:32679`).
- **Tooltip:** "range +40%, damage +10%" (`BisonSkill_eng.cs:970`): radius 5→7 is +40%; +0.1 ATK is +20% of the 0.5 base.

### bsn_solidHold5 Hold Charge extension (see Solid Hold above)

- Adds `floor(clamp(chargeSeconds − 8, 0, 12))` seconds to `holdCharge`, after `chaAdjust` (`Bison.cs:5383`, `:5400`), matching the tooltip's "+12s max". It also spawns `solidCharge_ring` when a charge begins (`Bison.cs:19346`). The KO block covers only `myCommand == "cAttack1"` (charging), not the spin (`cAttack2`).

## Server Balance Variations (ToT)

Private-server values are documented from the Bible skill-detail schema; BigBug source remains the original-server baseline.

| Skill | Original BigBug baseline | ToT delta |
|---|---|---|
| Over Power | 600s base cooldown. | Base cooldown reduced to 420s. |

Source of server delta: `12t_projects/bible/index.html:8972`.
