# Bison — Skill Cooldown/Duration Reference

> **Scope (2026-10-25):** this file documents the original BB client (`DecompiledSource/`); a citation without a tag is BB. ToT and TTO changes are live changes reported by the user and sit in the `## Server Balance Variations` sections. The Reborn client has its own file: [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) (Reborn citations are tagged `Reborn:`).

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
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
- `overPower` Duration: `Bison.cs:24764` — `this.$self_$21208.mChar.RPC_AddStatus("overPower", this.$sLv$21207, this.$self_$21208.mChar.chaAdjust(9), Mathf.Min(...), this.$self_$21208.mChar.ActorNr);` (self-buff, not target-contested); the `overPower` status is Buff, State (`StatusData.cs` is*Status lists, checked 2026-10-16)
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
- **Bible card (2026-10-05, user request):** Combo, Charge Attack and Over Swing have one Brute Strength toggle 0-5; rank 5 = Brute Strength 4 + Raw Strength (the Brute level in every formula stops at 4, and the 12% `lckAdjust` chance turns on only at rank 5). Raw Strength without all four Brute Strength ranks is not modelled.
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

### bsn_nAttack1-4 (Combo, #101-104): stages, spin and Added Swing (verified 2026-09-29)

- **Metadata:** passive, no cost; Lv 1/2/3/4, Bn 0/1/2/3 (`BisonSkill.cs`, decoded). Tooltips: #101 unlocks hit 2, #102 hit 3, #103/#104 give a 25%/40% spin on hit 3 (`BisonSkill_eng.cs:35-68`, `BisonSkill_thai.cs:37-70`).
- **Flow (`doNormalAttack`, `Bison.cs:4781-5125`):** hit 2 (`RPC_nAttack2`) needs #101 and a press 0.3-0.7 s after hit 1 (`:4858-4903`). Hit 3 needs #102 and a press more than 1 s after hit 2 (`:4918-4934`); with #103, `num = 25 + 5×ImprovedSwingLv` (+15 with #104) and `Random.Range(0,100) <= lckAdjust(num)` starts the spin `RPC_nAttack4`, else `RPC_nAttack3` (`:4947-5004`). The `<=` makes the chance `lckAdjust(num) + 1` %. Added Swing (#401) starts `RPC_nAttack5` after either `nAttack3` or `nAttack4`, press more than 2 s later, no roll (`:5034-5067`). A stored `holdCharge` releases on the next press instead (`:5089-5120`).
- **Stages:** each coroutine caches `getBruteStrengthLv()` and `getOverPride()` once (`:14741-14746`, `:15574-15579`, `:16385-16390`, `:17173-17178`, `:18270-18275`), so Raw Strength and Over Pride roll once per stage.

| Stage | Raw per hit | Area | KO |
|---|---|---|---|
| 1 | `getCritPlus(floor((0.5 + 0.025×Brute)×ATK))` (`:14776`) | `FindAngleTarget(pos − 0.5·fwd, fwd, 5×rangeMod, 35°, 2×rangeMod)` (`:14801`; 35° is the full width, halved inside `Damage.cs:1232`) | `1 + OverPride` (`:14824`) |
| 2 | same as 1 (`:15612`) | `FindRecTarget(…, base 1, top 2, range 5, height 2)` ×rangeMod (`:15607`) | `1 + OverPride` |
| 3 | `getCritPlus(floor((0.6 + 0.03×Brute)×ATK))` (`:16423`) | `FindRecTarget(…, 1, 1.5, 4, 3)` ×rangeMod (`:16418`) | `1 + OverPride` |
| Spin 1st | `getCritPlus(floor((0.4 + 0.02×Brute)×ATK))` (`:17221`) | radius `5×rangeMod`, height 3 (`:17216`) | `OverPride` (0 base, `:17256`) |
| Spin 2nd | `getCritPlus(floor((0.5 + 0.025×Brute)×ATK))` (`:17511`, `:17546`) | radius `6×rangeMod`, height 3 (`:17506`) | `1 + OverPride` |
| Added 1st / 2nd | same as the spin (`:18318`, `:18353`, `:18608`, `:18643`) | 5 / 6 radius (`:18313`, `:18603`) | `OverPride` / `1 + OverPride` |

- **Gear crit (`getCritPlus`, `Bison.cs:13801-13950`):** weapon `w_bsn43`/`w_bsn44` +5, `w_bsn58` +7; armor `a_all43`/`a_all44` +4, `a_all58` +6; accessory `c_all43`/`c_all44` +3, `c_all58` +5. `Random.Range(0,100) < lckAdjust(sum)` → `floor(1.8 × raw)`. Full supreme-commander set = 12, full champion set = 18 (same shape as Wolf). Names: `WeaponData_eng.cs:796`, `:807`, `:917`.
- **Weapon `w_bsn59` Vacuum Hammer** ("a hammer that can create such void…", `WeaponData_eng.cs:928`), modelled on Combo since 2026-10-06 (`BSN_W59_DEP`, `critProc.post`, exclusive with the crit axe): every stage first pulls enemies within 6 m (`RPC_AddDamage(1, -1, …, 5×direction)`, `Bison.cs:14669-14720`) and scales the damage by `floor(0.75×)` (`:14780-14787`) **after** `getCritPlus` (`hitDmg = getCritPlus(…)` at `:14776`).
- **Colossal Weapon (#361-362, `getColossalWeaponLv()` 0-2, `Bison.cs:8947`):** after each stage, every target within 8 m (height 4; 6 for spin/Added Swing) of a point 1 m ahead that the stage did **not** hit takes Effect Damage `ceil(0.2 × lv × highest damage dealt by that stage)` (`:14930-15029`, `:17362-17461`, `:17652-17749`).
- **SP:** +1 per stage that hits (`:14896` etc.).

### bsn_overPride1-4 (Over Pride, #321-324): per-stage KO/hate proc (verified 2026-09-29)

- **Level:** counts learned #321-#324 (0-4). With level > 0, `Random.Range(0,100) > lckAdjust(20)` returns 0, so the success chance is `lckAdjust(20) + 1` % (`Bison.cs:8532-8611`).
- **Effect:** read once per Combo stage; a success adds `+level` KO and `level×10` hate to every hit of that stage (`hit(…, 1 + op, op×10, …)`, `Bison.cs:14824`). `onOverPride()` only shows a message and plays a voice (`:8615`).

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

### bsn_bloodRage1-2 (Blood Rage, #121-122): SP on being hit (verified 2026-09-29)

- reqLv/reqBn 6/2 and 12/4, MP 0, SP 0, mode passive (`decode_skilldata.py`). Tooltip: "20%/40% chance to gain 2/4 sp when it gets hit" (`BisonSkill_eng.cs`).
- **Trigger** `getBloodRage()` (`Bison.cs:7180-7290`): a per-frame loop on the owning client. `num` = 1 if `hasSkill(121)`, 2 if `hasSkill(122)` (`:7211-7229`). It only runs on the frame after damage was applied (`myDamage == -1`, set by `ApplyDamage` once `myDamage > 0` removed HP, `CharacterControl.cs:2103-2128`), so Effect Damage that also goes through `ApplyDamage` counts and 0-damage hits do not.
- **Roll:** `Random.Range(0,100) < lckAdjust(num*20)` (`:7235`), i.e. 20% / 40% base, raised by LCK. Only a **successful** roll starts the 1-second internal cooldown (`gdH1UrOpsL = Time.time + 1`, `:7241`); a failed roll does not, so every hit rolls again until one succeeds.
- **Gain:** `sp = Min(sp + num*2, 100)` (`:7258`); with skill 421 (Blood Bath) `Min(sp + num*4, 100)` (`:7250`). Capped at the literal **100**, not `msp`. The separate engine rule "+1 SP whenever damage is taken" (`CharacterControl.cs:2122`, [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md)) stacks with this.
- Tooltip matches the code (2/4 SP, 20/40%).

### bsn_bloodBath5 (Blood Bath, #421): doubles Blood Rage SP (verified 2026-09-29)

- reqLv/reqBn 70/3, mode passive. Code: the `hasSkill(421)` branch of `getBloodRage()` (`Bison.cs:7244-7250`) uses `num*4` instead of `num*2` (see Blood Rage above): **+4 SP** at Blood Rage 1 and **+8 SP** at Blood Rage 2. Chance and cooldown are unchanged. Tooltip "Double the sp returned from bloodRage" (`BisonSkill_eng.cs`) matches.

### bsn_enrage1-4 (Enrage, #201-204): damage self-buff (verified 2026-09-29)

- MP 4/6/8/10, SP 0, reqLv 3/9/15/21, reqBn 0/1/2/3, mode instant, cooldown 30 (`decode_skilldata.py`; `addTimeOut("enrage", agiAdjust(30f))`, `Bison.cs:21055`).
- **Cast** `RPC_enrage` (`Bison.cs:20759-21252`): the status is applied in the state after `Yield(2, 0.2s)` + `Yield(3, 0.3s)` (`:21207`, `:21211`), i.e. **0.5 s** after the cast starts, then a further **0.3 s** (`:21213`) before the Bison can act (`actionState == "attack"` until then).
- **Status** `RPC_AddStatus("enrage", sLv + getRageControlLv(), chaAdjust(12 + 12*getRageControlLv()), 0, ActorNr)` (`:20968-20973`). `StatusData.cs`: Buff (`:6506`) and Magical (`:5615`) — `nStatus == "enrage"`.
- **Apply effect** (`CharacterControl.cs:34713-34738`): `damageMod += 0.04 + 0.04*sLv` (outgoing damage 8/12/16/20%, 24% with Rage Control), `forceMod += 0.1`, `rangeMod += 0.1`, body scale `+ sLv*0.05`. **Remove** (`:15412-15416`) reverses the scale. `damageMod` enters every hit through `dmgAdjust` ([12Tails-Mechanics-Reference.md §2.2](12Tails-Mechanics-Reference.md)).
- **Tooltip discrepancy:** `"Temporary increases Bison's attack power by 8% (15 sec)"` (`BisonSkill_eng.cs`). The % values match `damageMod` (a damage multiplier, not ATK). The duration is **12 s** in code (15 in the tooltip); the card follows the code.
- Rage Control (#402) adds +1 status level and doubles the base duration before `chaAdjust` (12 → 24) — see below.

### bsn_rageControl5 (Rage Control, #402): Enrage / Berserker Rush level and duration (verified 2026-09-29)

- reqLv/reqBn 55/0, mode passive. `getRageControlLv()` = `hasSkill(402) ? 1 : 0` (`Bison.cs:9047-9049`).
- Enrage: status level `sLv + 1`, duration `chaAdjust(12 + 12)` (`:20968-20973`). Berserker Rush: status level `rank + 1`, duration `chaAdjust(3 + 3)` (`:7821-7824`). The extra level is not capped at the skill's max rank (Enrage 4 + 1 = Lv.5 → damageMod +24%).
- Tooltip: "Increases enrage and berserkerRush's level by 1 and double their durations" (`BisonSkill_eng.cs`) matches; the Thai tooltip mentions only the duration.

### bsn_berserkerRush1-4 (Berserker Rush, #251-254): on-hit speed and lifesteal status (verified 2026-09-29)

- reqLv/reqBn 20/12, 24/15, 28/18, 32/21, MP 0, SP 0, mode passive (`BisonSkill.cs:1749-1760`).
- **Trigger** `getBerserkerRush()` (`Bison.cs:7740-7830`): on the frame after damage was applied (`myDamage == -1`), `num` = number of owned ranks (251-254); `Random.Range(0,100) < lckAdjust(4*num)` → **4/8/12/16%** (`:7812`); status `RPC_AddStatus("berserkerRush", num + getRageControlLv(), chaAdjust(3 + 3*getRageControlLv()), 0, ActorNr)` (`:7821-7824`). No internal cooldown. StatusData: Buff (`StatusData.cs:6512`), Physical (`:5361`).
- **Apply** (`CharacterControl.cs:34752-34885`): removes heavy, groundLock, needlePrison, sticky, ice, snowMan, frost, lightBind, sleep and maim whose level is <= sLv, then `moveMod += 0.1` (remove: `:15477-15481`).
- **Immunity** (`CharacterControl.cs:13282-13353`): while `berserkerRush` level >= the incoming status level, those same ten statuses are refused.
- **Lifesteal** (Combo only): every `RPC_nAttack1..5` stage (`Bison.cs:14751/14919`, `15584/15742`, `16395/16553`, `17183/17351`, `18280/18448`) heals `RPC_AddHeal(250+lv, ceil(min((0.04*lv + 0.04) * maxDamage, 8*lv)), …)` on itself, where `maxDamage` is the largest `hit()` return in the stage and the heal is skipped when it is <= 0. Stages 4 and 5 have a second hit pass and a second heal (`:17641`, `:18743`, `mBerserkerRushHeal2`). At sLv 1-4 that is 8/12/16/20% of the biggest hit, capped at **8/16/24/32 HP** per heal; the cap is not mentioned in the tooltip. Only Combo heals; Charge Attack and skills do not.
- **Tooltip:** "(+10% spd, 8% life steal)" (`BisonSkill_eng.cs`) matches `moveMod +0.1` and the percentage; the tooltip omits the HP cap and the crowd-control immunity. The Thai tooltip ("+10% spd, 8 / 12 / 16 / 20% hp return", `BisonSkill_thai.cs:462-505`; the same text in Reborn) omits them too; the card carries a `tooltipNote` (2026-10-26).
- **Counter-trinket (traced 2026-09-30):** against a target wearing `t_mal66` Calmar Wing or `t_fem66` Nageoire Wing, every Combo hit made while `berserkerRush` is active has a `target.lckAdjust(24)` % chance to be nullified entirely: no damage, KO or hate, and therefore no heal from it (`CharacterControl.cs:3430-3445`, `:3573-3633`; see [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md) "Calmar Wing"). The roll uses the target's LCK and happens per hit. Charge Attack and skills are not affected.

### bsn_furyTrance1-3 (Fury Trance, #262-264): low-HP ATK status (verified 2026-09-29)

- reqLv/reqBn 27/18, 30/21, 33/24, MP 0, SP 0, mode passive.
- **Trigger** `getFuryTrance()` (`Bison.cs:7920-8110`): a check every **3 seconds** (`:7984`). For i = 3 down to 1 with `hasSkill(261+i)`: if `hp/mhp < 1 - (0.2*i + 0.2)` (Lv.1 < 60%, Lv.2 < 40%, Lv.3 < 20%, `:7960`) and the current `furyTrance` level is below i, apply `furyTrance` level i for `chaAdjust(12)` (`:7966-7979`). An existing status at the same or higher level is not refreshed. Removed when the status level reaches 0 (`:8098-8104`).
- **Apply** `deltaAtk(sLv * 20)` (`CharacterControl.cs:34956-34960`): **+20/+40/+60 ATK**. StatusData: Buff (`StatusData.cs:6518`), Physical (`:5367`).
- Tooltip "+atk 20/40/60 when Hp lower than 60/40/20%" (`BisonSkill_eng.cs`) matches; duration 12 s is not in the tooltip.

### bsn_restingGlory1 (Resting Glory, #261): heal on death (verified 2026-09-29)

- reqLv/reqBn 24/15, mode passive. Fired from the death coroutine (`Bison.cs:41227-41248`, owner only, `hasSkill(261)`), which calls `RPC_restingGlory` locally and via `ActionEvent`.
- `RPC_restingGlory` (`Bison.cs:7841-7900`): iterates every child of `gameObject.transform.parent` tagged `"Player"` other than the Bison and calls `RPC_AddHeal(1, (int)(0.35 * mChar.mhp), 0, 0, 0, 0, ActorNr)` — **floor(35% of the Bison's max HP)**, no range check. `RPC_AddHeal` zeroes the heal on a `provoke` target (`CharacterControl.cs:7161-7167`).
- **Team only (resolved 2026-09-30):** the `parent` is the Bison's team container. When a character is created, `Game.cs` parents it under `GameObject.Find("Team" + (layer - 7))`, creating that object if missing (`Game.cs:2908-2926`, `:4395-4407`). The children of that transform are therefore exactly the players spawned on the Bison's team layer, so PvP opponents (other layer, other `TeamN` object) are never healed. Charm / Mind Control / Black Servant change `gameObject.layer` (`CharacterControl.cs:40680`, `:40782`, `:41447`) but never re-parent, so a charmed teammate is still healed and a charmed enemy is not. Only objects tagged `"Player"` count (no summons).
- Tooltip "Returns 35% of Bison's max hp to all teammates when Bison is dead" matches.

### bsn_slam1-2 (Slam, #211-212): short dash strike (verified 2026-09-29)

- SP +10/+14 (blue threshold), MP 0, reqLv/reqBn 5/1, 11/3, mode instant, cooldown 30 (`decode_skilldata.py`; `addTimeOut("slam", agiAdjust(30))`, `Bison.cs:21667`). Tooltip: "Do a slam attack that deals damage in short range and remove all lv3 (lv5) lock status" (`BisonSkill_eng.cs`).
- **Timeline** `RPC_slam` (`Bison.cs:21253-21887`): cast start removes locks (`removeLockStatus(sLv*2 + getAspectOfTheHordeLv())`, `:21688`), `Yield(2, 0.2 s)` windup (`:21835`), then `moveSpeed = 7` (`:21400`) and a 0.1 s tick loop (`Yield(3, 0.1 s)`, `:21839`). Each tick does `i++` and, while `i < 2 + sLv`, one hit round; at `i >= 2 + sLv` the dash stops (`:21516-21534`). So **sLv + 1 hit rounds** (2 at Lv.1, 3 at Lv.2) over (2 + sLv) x 0.1 s = 0.3/0.4 s, about **2.1/2.8 m** of dash.
- **Hit** per round per target (`:21600-21623`): `Damage.FindRecTarget(pos, forward, 1 + 3*aspect, 1 + 3*aspect, 3*rangeMod, 2*rangeMod, layer)` (half-widths, so **2 m** wide, **8 m** with Aspect of the Horde; 3 x rangeMod long; 2 x rangeMod high; the box travels with the Bison). `hit(99, target, (int)(0.3*ATK + talAdjust(5 + 5*sLv + 5*aspect)), sLv, 0, forward)`: damage uses DEF and `dmgAdjust`; KO = sLv per hit; hate 0. Nothing rejects a target that was hit on the previous tick, so a target that stays in the box takes every round.
- `removeLockStatus(n)` (`CharacterControl.cs:19456-19500`) removes `groundLock`, `needlePrison`, `sticky`, `frost` and `lightBind` whose level is <= n: n = 2 (Lv.1) / 4 (Lv.2), +1 with Aspect of the Horde. Matches the tooltip ("lower than 3 / 5", "lower than 6").

### bsn_aspectOfTheHorde5 (Aspect of the Horde, #412): Slam and Trample widening (verified 2026-09-29)

- reqLv/reqBn 60/1, mode passive. `getAspectOfTheHordeLv()` = `hasSkill(412) ? 1 : 0` (`Bison.cs:9061-9063`; the other `hasSkill(412)` hits in other class files are those classes' own #412).
- Uses: Slam hit box half-widths `1 + 3` (`:21600`), Slam and Trample `talAdjust(5 + 5*sLv + 5)` (`:21623`, `:22316`, `:22609`), Slam lock removal +1 level (`:21688`), Trample forward-phase half-widths `1 + 3` (`:22293`; the first-phase box at `:22586` is unchanged). Trample's `removeLockStatus(sLv*2)` (`:22406`) has **no** Aspect term.
- **Tooltip discrepancy:** "Widen Bison's slam and trample's damage area and gives them ability to remove lv.6 lock status" (`BisonSkill_eng.cs`): the lock-level bonus is Slam only (Trample keeps 2/4), and the +5 base damage is not mentioned.

### bsn_trample1-2 (Trample, #213-214): long charge (verified 2026-09-29)

- SP -30/-40 (red), MP 0, reqLv/reqBn 17/5, 23/7, mode instant, cooldown 120 (`addTimeOut("trample", agiAdjust(120f))`, `Bison.cs:22371`).
- **Timeline** `RPC_trample` (`Bison.cs:21888-22760`): cast start: `moveSpeed = -2` (a back-step), `removeLockStatus(sLv*2)` (`:22401-22406`), `Yield(2, 0.3 s)` (`:22696`). Phase 1 (`moveSpeed = 7`, `:22035`): three passes at `Yield(4, 0.2 s)` (`:22686`), each with the box `FindRecTarget(pos - forward, forward, 2*rangeMod, 2*rangeMod, 4*rangeMod, 2*rangeMod)` (`:22586`), i.e. 4 x rangeMod wide, 4 x rangeMod long starting 1 m behind the Bison. When `i >= 3` (`:22511`) the animation switches to `trample2`, `moveSpeed = 9` (`:22521`) and phase 2 runs `2 + 5*sLv` passes at `Yield(3, 0.2 s)` (`:22703`) with the box `FindRecTarget(pos, forward, 1 + 3*aspect, 1 + 3*aspect, 3*rangeMod, 2*rangeMod)` (`:22293`), then stops (`:22197`). Distance: 7 x 0.6 = 4.2 m, then 9 x 0.2 x (2 + 5*sLv) = 12.6 m (Lv.1) / 21.6 m (Lv.2).
- **Hit:** both phases `hit(212 + sLv, target, (int)(0.4*ATK + talAdjust(5 + 5*sLv + 5*aspect)), 3, 0, forward)` (`:22316`, `:22609`): KO 3 per hit, hate 0. Upper bound per target: 3 + (2 + 5*sLv) = **10 (Lv.1) / 15 (Lv.2)** hits if the target stays in every box; the KO push usually moves it out, so the card's hit count is that ceiling.
- Tooltip "Trample forward and deal damage in a long straight line" (`BisonSkill_eng.cs`) gives no numbers.

### bsn_knockDown1-4 (Knock Down, #221-224): pure-ATK ground smash (verified 2026-09-29)

- SP -5/-8/-12/-15 (red), MP 0, reqLv/reqBn 7/2, 13/4, 19/6, 25/8, mode instant, cooldown 30 (`addTimeOut("knockDown", agiAdjust(30f))`, `Bison.cs:23269`).
- **Timeline** `RPC_knockDown` (`Bison.cs:22761-23531`): `Yield(2, 0.3 s)` at `moveSpeed = 1`, `Yield(3, 0.4 s)` at `moveSpeed = 4`, `Yield(4, 0.2 s)`; the single hit happens in state 4 (`:22962-23126`), **0.9 s** after the cast starts, then a `Yield(5, 0.2 s)` recovery.
- **Hit** (`:23064-23126`): `FindAreaTarget(pos + 2*forward, (2 + 2*aftershock)*rangeMod, 2*rangeMod)`; `hitDmg = (int)((0.4 + 0.2*aftershock) * ATK)` (**no talAdjust**), `hitKo = 10*sLv + 10*aftershock`, hate 0, force `Vector3.up`, one `hit(220 + sLv, …)` per target. Every target that takes damage (`hit() != 0`) also gives the Bison **+1 SP** (`:23152`).
- **Aftershock** (#422, `hasSkill(422)`, `:22967`) changes: radius 4, ATK coefficient 0.6, KO +10; for targets more than 2 m from the box centre (`(target - pos - 2*forward).sqrMagnitude > 4`, `:23108`) `hitDmg` and `hitKo` are halved with `FloorToInt(0.5 * x)` (`:23114-23119`); and each target gets `afterShock` (below).
- Tooltip "(10/20/30/40 ko)" (`BisonSkill_eng.cs`) matches `10*sLv`. The damage formula has no tooltip.

### bsn_aftershock5 (Aftershock, #422): Knock Down shockwave and status (verified 2026-09-29)

- reqLv/reqBn 70/3, mode passive. Effects listed under Knock Down above. Status `RPC_AddStatus("afterShock", sLv, Damage.getDebuff(15, ownCha, targetCha), 0, ActorNr)` (`Bison.cs:23179`): duration `getDebuff(15, …)` = `floor(15 * (1 + 0.01*(ownCha - targetCha)))` when the Bison's CHA is higher, else `floor(15 * (1 + (ownCha - targetCha)/(|diff| + 64)))` (`Damage.cs:317-319`), i.e. contested by CHA. `sLv` is the Knock Down rank.
- **Status tick** (`CharacterControl.cs:8808-8832`): while `hp > 0` and `mod(2*t, 6) == 3` (every 3 s), the owner client calls `RPC_AddDamage(220, 0, sLv, 0, Vector3.zero, ActorNr)` — 0 damage and **KO = sLv**. StatusData: Debuff (`StatusData.cs:7322`), Physical (`:5373`).
- **Tooltip discrepancy:** "…deals half damage in 5m range…" (`BisonSkill_thai.cs`): code radius is 4 x rangeMod with the half-strength ring beyond 2 m; the +0.2 ATK coefficient is not mentioned.

### bsn_farStun1-2 (Far Stun, #241-242): distance-scaled stomp (verified 2026-09-29)

- SP -14/-18 (red), MP 0, reqLv/reqBn 16/4, 20/8, mode **target**, cooldown 120 (`addTimeOut("farStun", agiAdjust(120f))`, `Bison.cs:23938`). No distance check in the dispatch (`Bison.cs:5733-5752`), unlike Instant Rush.
- **Timeline** `RPC_farStun` (`Bison.cs:23532-24135`): `Yield(2, 0.4 s)`, `Yield(3, 0.3 s)`; the fire step (`:23788-23855`) runs **0.7 s** after the cast starts, then `Yield(4, 0.3 s)`.
- **Damage** `RPC_farStun_fire` (`Bison.cs:7632-7730`): `num = (int)(0.5 * sLv * Mathf.CeilToInt(flatDistance(bison, tPos)))`; every target inside `FindAreaTarget(tPos, 1, 3)` (radius 1 m, height 3 m, around the **target's position**) takes `hit(240 + sLv, t, talAdjust(num), num, num, Vector3.up)`, i.e. talAdjust(num) damage, **KO num**, hate num. The Bison also hits itself: `hit(240 + sLv, self, talAdjust(num), 0, 0, Vector3.zero)` (`:7715-7725`), which is why the tooltip says it damages the Bison too (its own DEF applies). One hit per target.
- Tooltip: "damage and ko equal to half / the target's distance" (`BisonSkill_eng.cs`) matches (Lv.1 50%, Lv.2 100% of the rounded-up distance).

### bsn_massStun5 (Mass Stun, #442): Far Stun area (verified 2026-09-29)

- reqLv/reqBn 85/6, mode passive. `hasSkill(442)` (`Bison.cs:23797`) replaces `RPC_farStun_fire` with `RPC_massStun_fire` (`:9082-9160`): `FindAreaTarget(tPos, 5, 3)` (radius **5 m**), `hit(4420 + sLv, t, talAdjust(num), num + FloorToInt(0.5*Lv), num, Vector3.up)` (KO gains **floor(0.5 x Bison Lv)**), and the same self hit. `num` is unchanged. Tooltip matches (Lv means Bison's character level).

### bsn_instantRush1 (Instant Rush, #243): gap closer (verified 2026-09-29)

- SP +12 (blue), MP 0, reqLv/reqBn 24/12, mode **target**, cooldown 30 (`addTimeOut("instantRush", agiAdjust(30f))`, `Bison.cs:24358`).
- **Cast condition** (`Bison.cs:5752-5799`): the flat distance to the target must satisfy `sqrMagnitude > 144`, i.e. **more than 12 m**; otherwise `newGameMessage("Target too close")`. **Tooltip discrepancy:** "must be more than 16m away" (`BisonSkill_eng.cs`); the card follows the code (12 m).
- **Motion** `RPC_instantRush` (`Bison.cs:24136-24609`): `Yield(2, 0.1 s)` then `moveSpeed = 24` for `Yield(3, 0.5 s)` = **12 m**, then stop (`:24271-24292`). No damage, KO or status.

### bsn_powerCleave1-2 (Power Cleave, #301/#303): heavy single strike (verified 2026-09-29)

- SP -10/-15 (red), MP 0, reqLv/reqBn 3/0 and 15/2, mode instant, cooldown 30 (`addTimeOut("powerCleave", agiAdjust(30f))`, `Bison.cs:26237`).
- **Hit** `RPC_powerCleave` (`Bison.cs:25688-26714`), one `hit()` per target (`:25893-26010`): box `FindRecTarget(pos - forward, forward, 2*rangeMod, 2*rangeMod, 5*rangeMod, 2*rangeMod)` = **4 x rangeMod** wide, 5 x rangeMod long starting 1 m behind the Bison, 2 x rangeMod high.
  - No hammer (`mPowerHammerLv == 0`, `:25922`): `hit(300 + sLv, t, (int)((1 + 0.5*reel) * (ATK + talAdjust(15*sLv))), 1, talAdjust(15*(sLv + reel)), forward)`: damage = (ATK + talAdjust) truncated after the Power Reel multiplier, **KO 1**, hate talAdjust(15 x (sLv + reel)). Afterwards `sp += 1` (`:25948`) and, with Power Reel, `RPC_AddStatus("cut", 5, 1, …)` on the target (`:25953-25975`).
  - Hammer (`:25984`): `hit(301 + sLv, t, (int)((1 + 0.5*reel) * ATK), (mPowerHammerLv + reel) * 10, 0, 3*forward)`: **no talAdjust, no hate**, KO `10 x (mPowerHammerLv + reel)`, knock force x3. `mPowerHammerLv = min(getPowerHammerLv(), sLv)` (`:26272-26283`). `sp += 1` per damaged target (`:26010`).
- **Stage waits** (`Bison.cs:26608-26628`): `Yield(3, 0.6 s)`, `Yield(4, 0.1 s)`, hit stage, `Yield(5, 0.3 s)`, `Yield(6, 0.2 s)`; the Power Reel pull passes use `Yield(2, 0.2 s)` three times before the cast continues (`:26539-26545`, `:26627`). Without Power Reel the hit lands about 0.7 s after the cast starts. The decompiled jump order of the reel loop is not cleanly recoverable, so the cast length with Power Reel is deliberately not stated (dropped by the user 2026-09-30).
- **Tooltip discrepancy:** "…dealing extra damage and 30 (60) hate" (`BisonSkill_eng.cs`); the code hate is `talAdjust(15 x lv)` = 15 / 30 (extra damage +15 / +30 matches). Not resolved as a live observation.

### bsn_powerHammer1-2 (Power Hammer, #302/#304): hammer conversion (verified 2026-09-29)

- reqLv/reqBn 9/1 and 21/3, mode passive. `getPowerHammerLv()` (`Bison.cs:8192-8236`): 0 unless `isHammer()` (weapon is one of `w_bsn5` Stone Hammer, `w_bsn15` Toy Hammer, `w_bsn19` BD Hammer, `w_bsn22` Defender Hammer, `w_bsn24` Defender Hammer V, `w_bsn25` Champion Barbell, `:8284-8327`; names from `WeaponData.cs`), then 1 with #302, 2 with #304. Effect described under Power Cleave: hammer branch, KO `10 x min(hammerLv, cleaveLv)`, no talAdjust, no hate, force x3.

### bsn_powerReel5 (Power Reel, #403): Power Cleave +50%, hate, cut and pull (verified 2026-09-29)

- reqLv/reqBn 55/0, mode passive. `getPowerReelLv()` = `hasSkill(403) ? 1 : 0` (`Bison.cs:9054`).
- Effects: damage multiplier `1 + 0.5*reel` on both Power Cleave branches, hate `talAdjust(15*(sLv + reel))`, hammer KO `+10`, `cut` status 5 for 1 s on axe hits (StatusData `cut`, removes magical shields of level <= 5), and a pull: `FindAreaTarget(pos, 8, 5)` then `RPC_AddDamage(403, -1, 0, 0, 2 * dirToBison, ActorNr)` (0 damage, force 2 toward the Bison) in three passes (`:26554-26593`).
- Tooltip matches (+50%, reels nearby enemies); the Thai text also names Power Hammer.

### bsn_warcry1-2 (Warcry, #311-312): mass hate and fear (verified 2026-09-29)

- MP 5/10, SP 0, reqLv/reqBn 5/1, 11/3, mode instant, cooldown 60 (`addTimeOut("warcry", agiAdjust(60))`, `Bison.cs:27087`).
- `RPC_warcry` (`Bison.cs:26715-27286`): `Yield(2, 0.3 s)`, `Yield(3, 0.3 s)`; the effect runs **0.6 s** after the cast starts, then `Yield(4, 0.2 s)`. Targets: `FindAreaTarget(pos, 18 + 6*sLv, 6, layerMask)` (radius **24 / 30 m**, no rangeMod, height 6, own layer excluded). Each: `RPC_AddDamage(1, 0, 0, talAdjust(15*sLv), 0, ActorNr)` (pure hate, no damage, no KO) and `RPC_AddStatus("fear", sLv, chaAdjust(15), ceil(0.1 * target.atk), ActorNr)` (`:26994-26999`); the duration uses the Bison's CHA only, not the target's.
- `fear` apply (`CharacterControl.cs:35312-35319`): `deltaAtk(-sLv * sValue)` and `deltaTal(-sLv * sValue)`, `sValue = ceil(0.1 * target ATK)`: ATK **and** TAL are reduced by the same amount, 10% / 20% **of the target's ATK**. StatusData: Debuff (`StatusData.cs:7316`), Magical (`:5645`).
- **Tooltip discrepancy:** "20 (40) hate … decreasing their attack and talent by 10% (20%)" (`BisonSkill_eng.cs`): hate is `talAdjust(15/30)`; the TAL reduction is the ATK-based amount, not 10% of TAL.

### bsn_overlord1-2 (Overlord, #313-314): DEF aura (verified 2026-09-29)

- reqLv/reqBn 17/5, 23/7, mode passive. `createOverLord()` (`Bison.cs:8480-8517`) spawns the `Bison_overLord` trigger volume as a child, level 2 with `hasSkill(314)`, else 1.
- `Bison_overLord.OnTriggerEnter` (`Bison_overLord.cs:56-118`): needs the owner alive and not `hide`; the entering object must be tagged `Player`, on the Bison's layer (same team) and `Race == Tails`; it gets `addStatus("overLord", nLv, 999, ceil(0.05 * Bison.def * nLv), ownerID)`. `overLord` apply is `deltaDef(sValue)` (`CharacterControl.cs:35327-35331`), so **DEF +5% / +10% of the Bison's DEF**, fixed at the moment of entry. `OnTriggerExit` removes it (`:126-173`). `StatusData.cs` has no classification for `overLord`.
- **Tooltip discrepancy:** the English tooltip says "10/20 def", the Thai says "+5%/+10% def" (`BisonSkill_eng.cs`, `BisonSkill_thai.cs`); code matches the Thai on the %. **Radius (verified 2026-10-07):** the trigger is a `SphereCollider` with `m_Radius: 10` (`gameassets/characters/heroes/bison/effects/overLord.prefab`, scale 1), parented to the Bison's transform (`Bison.cs:8487-8490`), so the sphere is **10 m × the Bison's body scale** (root scale 1 in `Bison.prefab`). Body scale changes with `titanForm` `+(0.3×sLv + 0.2)` (`CharacterControl.cs:35219`), `enlarge` `+0.1×sLv` (`:37311`), `enrage` `+0.05×sLv` (`:34717`) and `reduce` `−0.1×sLv` (`:37231`), reversed on removal (`:15416-16727`). It does **not** follow `rangeMod` (different amounts, and `lunarEclipse` changes `rangeMod` only). **Thai tooltip mismatch:** it says "เพื่อนทุกคนที่อยู่ในระยะ 12 m" (`BisonSkill_thai.cs:649-670`), but the code gives a **10 m** sphere and only to **Tails**-race teammates; the card carries a `tooltipNote`.

### bsn_ironSkin1-3 / bsn_diamondSkin1-3 (Iron Skin #331-333, Diamond Skin #341-343): range-based damage reduction (verified 2026-09-29)

- reqLv/reqBn 16/4, 20/8, 24/12 (both skins), MP 0, SP 0, mode passive. Tooltips: Iron Skin "Decreases Bison's damage taken from enemies within 6m range by 8/16/24%", Diamond Skin "…farer than 12m range by 8/16/24%" (`BisonSkill_eng.cs`).
- Both live in the Bison damage-received block of `RPC_AddDamage` (`CharacterControl.cs:4011-4298`), so they apply to direct hits only (Effect Damage never reaches it).
  - **Iron Skin** (`:4116-4181`, gate `hasSkill(331)`): `d2 = ceil(|attacker - bison|^2)` (3-D positions, includes height); when `d2 < 16 + (hasSkill(433) ? 65 : 0)` (**4 m**, **9 m** with Steel Skin) `nDamage = ceil(nDamage * (1 - 0.08 * n))`. `n` is chosen by rank: `hasSkill(332)` false -> **2**, `hasSkill(333)` false -> **3**, else **3** (`:4149-4177`, junk predicates evaluate to false), i.e. **16% / 24% / 24%** reduction for Lv.1/2/3.
  - **Diamond Skin** (`:4206-4290`, gate `hasSkill(341)`): applies when `ceil(d2) > 144 - (hasSkill(443) ? 63 : 0)` (**more than 12 m**, **9 m** with Mythril Skin), the same `ceil(nDamage * (1 - 0.08 * n))`, `n` 2 / 3 / 3 by the same #342/#343 test.
- **Discrepancies (code is authoritative, re-checked 2026-09-30):** the tooltip range is 6 m (code 4 m), and the tooltip percentages 8/16/24 correspond to `n = 1/2/3` while the decompiled literals are 2/3/3, so Lv.3 gives no gain over Lv.2. Re-reading `CharacterControl.cs:4149-4180` / `:4239-4270` confirms every junk predicate on the path (`269164 - 204650 != 64514` false → `num5 = 2`; `73816 - 190594 == -116777` false and `116998 - 413897 != -296899` false → `num5 = 3`). The user ruled the code values correct (16/24/24%, 4 m).
- **Range edge:** the test is on `CeilToInt(sqrMagnitude)`, so Iron Skin applies while `d² ≤ 15` (about **3.87 m**, `≤ 80` = 8.94 m with Steel Skin), and Diamond Skin while `d² > 144` (more than 12 m; `> 81` with Mythril Skin).
- **Shields depend on the skins:** the `ironShield` / `diamondShield` block checks sit *inside* the `hasSkill(331)` / `hasSkill(341)` range branches (`:4186`, `:4276`), so Iron Shield blocks nothing unless Iron Skin is learned, and Diamond Shield nothing unless Diamond Skin is learned. `perfectShield` / `perfectArmor` (`:4085-4113`) are checked before and do not need either skin.

### bsn_ironShield1 / bsn_diamondShield1 (Iron Shield #334, Diamond Shield #344): timed range blocks (verified 2026-09-29)

- MP 10, SP -10 (red), reqLv/reqBn 28/18, mode instant, cooldown 90 (`addTimeOut("ironShield", agiAdjust(90))`, `Bison.cs:27790`; `"diamondShield"`, `:28377`).
- **Timeline** (`Bison.cs:27287-27873`, `:27874-28460`): `Yield(2, 0.3 s)`, `Yield(3, 0.3 s)`; the status is applied at **0.6 s**, then `Yield(4, 0.2 s)`. Duration `mDuration = chaAdjust(6)`, `+= 2` **after** `chaAdjust` with Steel Skin (#433, `:27691-27708`) or Mythril Skin (#443, `:28278-28295`) for the matching shield; status level 1.
- **Effect** (`CharacterControl.cs:4186-4197`, `:4276-4290`): while `getStatusLv("ironShield") > 0` (or `"diamondShield"`) and the attacker is inside the same range test as the matching skin, `nDamage = 0` and `nKo = 0`. StatusData: Buff, Magical, Shield (`StatusData.cs:6530`/`5621`/`6250` and `6536`/`5627`/`6256`).
- **Both shields:** applying one while the other is active converts the applied status to `perfectShield`, or to `perfectArmor` when `hasSkill(443)` (`CharacterControl.cs:11973-12033`; guards `:11085-11155`). `perfectShield` sets `nDamage = 0` for any attacker (KO still passes), `perfectArmor` sets `nDamage = 0` and `nKo = 0` (`:4085-4110`). Both are Buff/Magical/Shield (`StatusData.cs:6542`, `:6554`).
- **Duration and order (resolved 2026-09-30):** the conversion only rewrites `sType`; `sTime` is untouched, so the combined status lasts for the **second** shield's duration (its own `chaAdjust(6)`, plus 2 s if that shield's Steel/Mythril Skin is learned). Applying `perfectShield` / `perfectArmor` removes `ironShield`, `diamondShield` and the other perfect status (`CharacterControl.cs:35116-35126`, `:35151-35161`), so the first shield's remaining time is discarded. With Mythril Skin (#443) the result is `perfectArmor` in either cast order (`:11985`, `:12019`).
- **Re-application:** while `perfectShield` or `perfectArmor` is active, a new `ironShield` / `diamondShield` status is rejected (`CharacterControl.cs:11085-11144`; the guard `break` exits the same loop as the `!recieveStatus` reject at `:10692-10697`), and `perfectShield` is rejected while `perfectArmor` is active (`:11145-11158`). The shield's cast still runs and still puts that shield on its 90 s cooldown (`addTimeOut` at `Bison.cs:27790` / `:28377` is not conditioned on the status). A single shield cast after the perfect status expires applies normally; applying a single `ironShield` / `diamondShield` itself removes any perfect status (`:35054-35061`, `:35085-35092`).
- **Tooltip discrepancy:** "blocking all damage taken from enemies within 6m (6 sec)" (`BisonSkill_eng.cs`): code range is 4 m (Iron) / more than 12 m (Diamond), 6 s base.

### bsn_steelSkin5 (Steel Skin, #433) / bsn_mythrilSkin5 (Mythril Skin, #443) (verified 2026-09-29)

- reqLv/reqBn 75/4 and 85/6, mode passive. Steel Skin: Iron Skin / Iron Shield range 4 m -> 9 m (`16 + 65 = 81`, `CharacterControl.cs:4142`) and Iron Shield duration +2 s after `chaAdjust` (`Bison.cs:27696-27702`). Mythril Skin: Diamond Skin / Diamond Shield minimum range 12 m -> 9 m (`144 - 63 = 81`, `:4276` block) and Diamond Shield +2 s (`Bison.cs:28283-28289`), plus `perfectArmor` for the dual-shield case above.
- **Tooltip discrepancy:** "Increases range effect of IronSkin/Shield to 9m" and the Thai "+3 m" (`BisonSkill_*.cs`): consistent with 9 m, not with a 6 m base.

### bsn_earthRupture1-2 (Earth Rupture, #351-352): axe shockwave(s) (verified 2026-09-29)

- SP -15/-20 (red), MP 0, reqLv/reqBn 20/12, 24/15, mode instant, cooldown 60 (`addTimeOut("earthRupture", agiAdjust(60))`, `Bison.cs:28730`).
- **Timeline** `RPC_earthRupture` (`Bison.cs:28466-28934`): `Yield(2, 0.8 s)`, then the fire step (`:28620-28648`), then `Yield(3, 0.7 s)`. The wave spawns at `pos + (0, 0.2, 0.4)` in the Bison's frame.
- **Waves** `RPC_earthRupture_fire1` (`Bison.cs:8762`): one projectile (`ProjectileControl.life = 2`). `RPC_earthRupture_fire2` (`:8829`, Lv.2): three projectiles at `i * 25` degrees for `i = -1, 0, 1`, same life. **Speed and range (resolved 2026-09-30):** `Bison_earthRupture.FixedUpdate` sets `rigidbody.velocity = TransformDirection(ProjectileControl.velocity)` every physics step and destroys the wave once its timer reaches `ProjectileControl.life` (`Bison_earthRupture.cs:96-127`). `velocity` is a prefab value that the AssetRipper YAML leaves empty, so it was decoded from the live `12TailsOnline_Data/resources.assets` with UnityPy: GameObject `earthRupture` (pathID 7208), MonoBehaviour pathID 78478, 56-byte payload = header 20 bytes + `m_Name` length, then `life 0, dmg 0, velocity (0, 0, 12)`, `OwnerID 0`, two padded bools. The layout was cross-checked against other `ProjectileControl` prefabs in the same file (`clearArrow` / `poisonSpit` life 2, velocity 30; `bubbleGun` 12 / 24; `warMissile` 12 / 12). So each wave moves **12 m/s** straight ahead; with `life = 2` set by the fire RPC it travels **24 m** (plus the 0.4 m spawn offset). For Lv.2 the centres of adjacent waves (25° apart) are `2·d·sin 12.5° ≈ 0.43·d` apart, so the 2 m-wide waves overlap out to about **4.6 m** from the spawn point (further for targets with a large collider); beyond that a target is crossed by one wave only. **Width:** the prefab's collider is a `CapsuleCollider` radius 1, height 1 (`RippedAssets/.../bison/effects/earthRupture.prefab:215-227`); a capsule whose height is below 2 × radius is a sphere, so each wave is a **1 m-radius sphere (2 m wide)** centred 1 m above its origin, with a non-kinematic, gravity-free Rigidbody (mass 0.01).
- **Hit** `Bison_earthRupture.OnCollisionEnter` (`Bison_earthRupture.cs:131-190`): `IgnoreCollision(wave, target)` first, so each wave hits each target once and passes through; `hit(203, target, (int)(0.5*ATK + talAdjust(30)), 5, 0, zero)` (isMine only). **Not rank-scaled**: Lv.2 only adds waves. The waves start from one point, so a target close to the Bison can be crossed by more than one of the three.

### bsn_earthSmasher1-2 (Earth Smasher, #353-354): jump slam (verified 2026-09-29)

- SP -45/-55 (red), MP 0, reqLv/reqBn 28/18, 32/21, mode instant, cooldown 180 (`addTimeOut("earthSmasher", agiAdjust(180))`, `Bison.cs:29381`).
- **Timeline** `RPC_earthSmasher` (`Bison.cs:28935-29637`): `Yield(2, 0.8 s)`, `moveSpeed = 2`, `Yield(3, 0.6 s)`; the hit happens in state 3, **1.4 s** after the cast starts, then `Yield(4, 1.2 s)` and `Yield(5, 0.6 s)` of recovery.
- **Hit** (`:29193-29242`): `FindAreaTarget(pos, 7*rangeMod, 2*rangeMod)`, `hit(332 + sLv, t, (int)((0.5*sLv + 0.5)*ATK + talAdjust(50*sLv)), 20 + 20*sLv, 0, 3*up)`: **1.0 x ATK + talAdjust(50)** at Lv.1, **1.5 x ATK + talAdjust(100)** at Lv.2, KO **40 / 60**; +1 SP per damaged target. The radius is 7 at both ranks, although the tooltips say "medium" / "large" (`BisonSkill_eng.cs`).

### bsn_magmaClutter5 (Magma Clutter, #434): lift and gore (verified 2026-09-29)

- MP 20, SP -20 (red), reqLv/reqBn 75/4, mode instant, cooldown 90 (`addTimeOut("magmaClutter", agiAdjust(90))`, `Bison.cs:31715`).
- **Timeline** `RPC_magmaClutter` (`Bison.cs:31242-31958`): `moveSpeed = 5` at the start, `Yield(2, 0.3 s)`, first hit, `Yield(3, 0.5 s)`, dash (`moveSpeed = 5`), `Yield(4, 0.2 s)`, second hit at **1.0 s**, `Yield(5, 0.3 s)`.
- **Hit 1** (`:31413-31457`): `FindAreaTarget(pos + forward, 2*rangeMod, 3*rangeMod)`, `hitDmg = (int)(0.5*ATK + talAdjust(100 - target.weight))`, `hit(434, t, hitDmg, floor(0.1*hitDmg), 0, 4*up)`: lighter targets take more (the tooltip's "target's lightness"); KO is 10% of that pre-DEF damage.
- **Hit 2** (`:31568-31627`): `FindRecTarget(pos, forward, 2, 2, 2*rangeMod, 3*rangeMod)` (4 m wide, 2 x rangeMod long), `hit(434, t, (int)(1.5*ATK + talAdjust(50)), 5, 0, flatDirAwayFromBison)`, +1 SP per damaged target. The target launched by hit 1 can still be inside hit 2's box.

### bsn_calamityHammer5 (Calamity Hammer, #444): ground slam and lava strikes (verified 2026-09-29)

- MP 50, SP -50 (red), reqLv/reqBn 85/6, mode **target**, cooldown 150 (`addTimeOut("calamityHammer", agiAdjust(150))`, `Bison.cs:32264`).
- **Cast** `RPC_calamityHammer` (`Bison.cs:31959-32443`): `Yield(2, 2.1 s)` windup; at the end `FindAreaTarget(pos + 3.5*forward, 3, 3)` and `hit(444, t, ATK + talAdjust(45), 10, 0, zero)` on everything in that circle (**impact**, not in the tooltip), then `OnCalamityHammer(tID)` starts (`:32156`).
- **Lava loop** `OnCalamityHammer` (`Bison.cs:32444-32660`): ten passes (`i < 10`) every `Yield(2, 1.5 s)` while the Bison is alive and the chosen target object exists; each pass runs `RPC_calamityHammer_fire(target.position, …)` (position sampled **at the moment of the pass**). `RPC_calamityHammer_fire` (`:32671-32934`) waits `Yield(2, 0.3 s)`, then `FindAreaTarget(hitPos, 1, 3)` and `hit(444, t, ATK + talAdjust(45), 10, 0, up)` on every enemy in radius **1 m** of that spot. Passes run at t = 0, 1.5, … 13.5 s after the windup.
- Upper bound per target: 1 impact + 10 lava strikes. Tooltip: "(45dmg x 10)" (`BisonSkill_thai.cs`); the +ATK term and the impact are not mentioned.

### bsn_onslaught5 (Onslaught, #413): hate-to-damage roar (verified 2026-09-29)

- MP 50, SP -50 (red), reqLv/reqBn 60/1, mode instant, cooldown 300 (`addTimeOut("onslaught", agiAdjust(300))`, `Bison.cs:30606`).
- **Timeline** `RPC_onslaught` (`Bison.cs:30086-30709`): `Yield(2, 0.3 s)`, `Yield(3, 0.3 s)`; the effect runs at **0.6 s**, then `Yield(4, 0.2 s)`.
- **Effect** (`:30424-30518`): every active entry of the Bison's own `mHateList` (`hate > ceil(Time.time)`, hate is stored as an expiry time so it decays 1 per second, see `getHate`, `CharacterControl.cs:7687`) adds `ceil(0.1 * (hate - Time.time))` to `mDmg`; every entry is then zeroed. Every target in `FindAreaTarget(pos, 30, 6, layer)` (radius **30 m**, no rangeMod, own layer excluded) gets `RPC_AddDamage(413, clamp(mDmg, 0, 1999), 0, 0, zero, ActorNr)`: **direct damage, no DEF, no `dmgAdjust`, no LCK roll, no KO**, capped at **1999**.
- The card models one hate source (input = its current hate); with several entries each is rounded up separately, so the sum can be a little higher. Tooltip: "10% of Bison's total hate (Max 1999 Dmg)" (`BisonSkill_eng.cs`).
- **What the list holds (resolved 2026-09-30):** `mHateList` is the *victim-side* aggro table that every character keeps (`recieveHate` defaults to `true`, `CharacterControl.cs:184`, and is never cleared). So for a player Bison it holds the hate that **attackers built against the Bison**, not the aggro the Bison holds on monsters (that lives in each monster's own list and is what Pride Crusher reads via `target.getHate`).
  - On every direct hit the receiver recomputes `nHate = ceil(nDamage + nHate + 10 × nKo)` (`CharacterControl.cs:3771`, before Iron/Diamond Skin and shields), so monster attacks (which pass `hate 0`) still create entries. The damage coroutine then calls `addHate(attacker, nHate)` on the Bison (`:32138-32150`; Effect Damage path `:7045-7057`); self-hits are skipped. `noHate` on the attacker forces the value to 1 (`:3816-3822`).
  - Every same-layer character within **24 m** of a hit victim also gets `ceil(0.2 × nHate)` toward that attacker (`Hate.findFriends(pos, 24, layer)`, `:32155`, `:7060-7102`), so hits on nearby teammates add 20% to the Bison's list.
  - `addHate` stacks onto an unexpired entry, or restarts it at `ceil(Time.time) + hate` (`:7780-7815`), so each entry decays 1 per second.
  - Net effect: Onslaught deals **10% of the recent damage + 10 × KO the Bison took** (plus 20% of what teammates within 24 m took), after decay, capped at 1999. The status-driven `addHate` calls (`:34086`, `:40056`, `:40110`, `:40294`) add to a character's *own* list while it carries those statuses.

### bsn_prideCrusher5 (Pride Crusher, #423): hate-scaled ground smash (verified 2026-09-29)

- MP 5, SP -25 (red), reqLv/reqBn 70/3, mode instant, cooldown 60 (`addTimeOut("prideCrusher", agiAdjust(60))`, `Bison.cs:31023`).
- **Timeline** `RPC_prideCrusher` (`Bison.cs:30710-31241`): `moveSpeed = 1`, `Yield(2, 0.6 s)`, hit at **0.6 s**, `Yield(3, 0.2 s)`.
- **Hit** (`:30881-30930`): `FindRecTarget(pos, forward, 1*rangeMod, 1*rangeMod, 8*rangeMod, 3*rangeMod)` (2 x rangeMod wide, 8 x rangeMod long, 3 x rangeMod high); `hitDmg = (int)((ATK + talAdjust(30)) + clamp(0.2 * target.getHate(BisonActorNr), 0, 999))`, `hit(422, t, hitDmg, 10, 0, 0.5*up)`. `getHate` is `floor(hate - Time.time)` (0 when expired). So **ATK + talAdjust(30) + up to 999**, and the hate part goes through DEF like the rest.

### bsn_titanForm1-2 (Titan Form, #371-372): giant form (verified 2026-09-29)

- MP 30/40, SP -55/-70 (red), reqLv/reqBn 35/23, 40/25, mode instant, cooldown 300 (`addTimeOut("titanForm", agiAdjust(300))`, `Bison.cs:29879`).
- **Cast** `RPC_titanForm` (`Bison.cs:29638-30085`): `Yield(2, 0.3 s)`, then `RPC_AddStatus("titanForm", sLv, chaAdjust(60), …)` and `RPC_AddHeal(370 + sLv, talAdjust(sLv*120 + 80), …)` (`:29792-29797`), `Yield(3, 0.5 s)`.
- **Status** `titanForm` (State `StatusData.cs:4848`, Buff `:6548`); apply (`CharacterControl.cs:35209-35240`): removes `enrage` and `enlarge`, scale `+ (0.3*sLv + 0.2)`, `deltaDef(30*sLv + 20)`, `deltaVit(30*sLv + 20)`, `rangeMod += 0.3*sLv`, `weight += 15*sLv`; removal reverses all (`:15675-15706`). `rangeMod` scales every `rangeMod` skill area.
- **Tooltip discrepancy:** the English tooltip says "restores 250 / 400 hp", the Thai "200 / 320" (`BisonSkill_eng.cs`, `BisonSkill_thai.cs`); code is `talAdjust(120*sLv + 80)` = 200 / 320 base, matching the Thai. DEF/VIT +50 / +80 match.

### bsn_colossalWeapon1-2 (Colossal Weapon, #361-362): Combo splash (verified 2026-09-29)

- reqLv/reqBn 24/15, 27/18, mode passive. The splash after each Combo stage is documented in the Combo entry above (`Bison.cs:14930-15029`, `:17362-17461`, `:17652-17749`, `getColossalWeaponLv()` `:8947`): Effect Damage `ceil(0.2 * lv * highestStageDamage)` (20% / 40%) to every target within 8 m (height 4; 6 for spin and Added Swing) of a point 1 m ahead that the stage did not hit. Bible (2026-10-01, user-chosen design): the Combo card has a Colossal Weapon 0-2 toggle and, while it is on, a purple line under Final Damage per stage: `ceil(0.2 × lv × that stage's after-DEF range)` against the selected enemy (`hit()` returns the post-`dmgAdjust`/`defAdjust`, pre-`hitMod` value, `CharacterControl.cs:3566-3571`), before the splashed target's own `hitMod`. Final and Test stay single-target.
- Tooltip "splash 20% (40%) of its damage to all enemies within 8m" matches; it omits that already-hit targets are excluded.

### bsn_colossalArmor1-2 (Colossal Armor, #363-364): damage retaliation (verified 2026-09-29)

- reqLv/reqBn 30/21, 33/24, mode passive. In the Bison damage-received block (`CharacterControl.cs:4011-4052`), on every direct hit with `nDamage > 0`: `num3 = 1` (+1 with #364) and the attacker takes `RPC_AddEffectDamage(364, num3, num3, 0, zero, ActorNr)`: **1 / 2 Effect Damage and 1 / 2 KO** (no DEF). Tooltip matches.

### bsn_addedSwing5 (Added Swing, #401): fifth Combo stage (verified 2026-09-29)

- reqLv/reqBn 55/0, mode passive. See the Combo entry: `RPC_nAttack5` starts after `nAttack3` or the spin, on a press more than 2 s later, with no roll (`Bison.cs:5034-5067`); it is a two-hit spin (radius 5 then 6 x rangeMod, height 3; first hit 0 base KO) with the spin's damage coefficients (`:18313-18643`), and it also triggers Berserker Rush, Colossal Weapon and Over Pride like other stages.

## Movement timelines (read 2026-10-15, for the range preview; nominal `moveMod` 1, not live-tested)

Movement is `vMovement × moveSpeed × clamp(moveMod, 0.1, 2) × dt` (`CharacterControl.cs:2722`); a speed set in a state runs until the next `Yield` returns. Legs are speed m/s × seconds; the exact lines are the coroutines named in each skill's section above (`Bison.cs`, `Bison_*.cs` companions).

| Skill | Timeline | Hits |
|---|---|---|
| Combo stage 1 | 1 × 0.5 s | sector at 0.5 s |
| Combo stage 2 | starts 0.7 s after cast; 2 × 0.5 s | box at +0.5 s |
| Combo stage 3 | starts 1.4 s; 0 × 0.1 s then 4 × 0.5 s | box at +0.6 s |
| Combo spin (rank 3+) | starts 1.4 s; 0 × 0.7 s then 5 × 0.3 s | circles at +0.7 s and +1.0 s |
| Added Swing | starts 2.2 s; 0 × 1 s then 5 × 0.3 s | circles at +1.0 s and +1.3 s |
| Charge Attack | 3 m/s throughout; 4 hits (8 with Spin Hack) every `2 × (0.2 − 0.033 × Improved Swing)` s | |
| Slam | 0 × 0.2 s then 7 m/s | hits at 0.3 + 0.1 i s, rank + 1 hits |
| Trample | −2 × 0.3 s, 7 × 0.6 s, then 9 m/s | phase 1 at 0.5 / 0.7 / 0.9 s, phase 2 at 1.1 + 0.2 i s |
| Knock Down | 0 × 0.3 s, 1 × 0.4 s, 4 × 0.2 s | hit at 0.9 s |
| Over Swing | 0 × 0.5 s then 3 × 0.2 s | circles at 0.5 s and 0.7 s |
| Earth Smasher | 0 × 0.8 s then 2 × 0.6 s | hit at 1.4 s |
| Magma Clutter | 5 × 0.3 s, 0 × 0.5 s, 5 × 0.2 s | circle at 0.3 s, box at 1.0 s |
| Pride Crusher | 1 × 0.6 s | hit at 0.6 s |
| Calamity Hammer | stands still | slam at 2.1 s, lava at 2.4 s |

## Skill Tree Layout & Learn Requirements

Verified 2026-10-12 for the Skill Simulator (rules: [12Tails-Mechanics-Reference.md §3.6](12t_reference/12Tails-Mechanics-Reference.md#36-skill-learning-rules-class-skill-window-verified-2026-10-12)). Each cell is `name Lv/points`: required level / skills already learned in the same tree. Cell number = `tree*100 + row*10 + column` (trees 1-4 = Berserker, Gladiator, Warlord, Molten Axe). Source: `BisonSkill.getSkill` (`setReq`, `rSkill`) and `BisonSkill.getSkillTree`.

**Berserker** (tree 1)

| Row | Cells |
|---|---|
| 1 | N Attack 1 1/0 · N Attack 2 2/1 · N Attack 3 3/2 · N Attack 4 4/3 |
| 2 | C Attack 1 4/1 · C Attack 2 10/3 · Hold Charge 16/5 · — |
| 3 | Blood Rage 1 6/2 · Blood Rage 2 12/4 · — · — |
| 4 | Brute Strength 1 8/4 · Brute Strength 2 16/6 · Brute Strength 3 24/8 · Brute Strength 4 32/10 |
| 5 | Stat Plus 1 10/4 · Stat Plus 2 20/6 · Stat Plus 3 30/8 · Stat Plus 4 40/10 |

**Gladiator** (tree 2)

| Row | Cells |
|---|---|
| 1 | Enrage 1 3/0 · Enrage 2 9/1 · Enrage 3 15/2 · Enrage 4 21/3 |
| 2 | Slam 1 5/1 · Slam 2 11/3 · Trample 1 17/5 · Trample 2 23/7 |
| 3 | Knock Down 1 7/2 · Knock Down 2 13/4 · Knock Down 3 19/6 · Knock Down 4 25/8 |
| 4 | Controlled Swing 9/3 · Improved Swing 1 15/5 · Improved Swing 2 21/7 · Improved Swing 3 27/9 |
| 5 | Far Stun 1 16/4 · Far Stun 2 20/8 · Instant Rush 24/12 · — |
| 6 | Berserker Rush 1 20/12 · Berserker Rush 2 24/15 · Berserker Rush 3 28/18 · Berserker Rush 4 32/21 |
| 7 | Resting Glory 24/15 · Fury Trance 1 27/18 · Fury Trance 2 30/21 · Fury Trance 3 33/24 |
| 8 | Over Power 1 35/23 · Over Power 2 40/25 · Over Swing 45/27 · — |

**Warlord** (tree 3)

| Row | Cells |
|---|---|
| 1 | Power Cleave 1 3/0 · Power Hammer 1 9/1 · Power Cleave 2 15/2 · Power Hammer 2 21/3 |
| 2 | Warcry 1 5/1 · Warcry 2 11/3 · Overlord 1 17/5 · Overlord 2 23/7 |
| 3 | Over Pride 1 7/2 · Over Pride 2 13/5 · Over Pride 3 19/7 · Over Pride 4 25/9 |
| 4 | Iron Skin 1 16/4 · Iron Skin 2 20/8 · Iron Skin 3 24/12 · Iron Shield 28/18 |
| 5 | Diamond Skin 1 16/4 · Diamond Skin 2 20/8 · Diamond Skin 3 24/12 · Diamond Shield 28/18 |
| 6 | Earth Rupture 1 20/12 · Earth Rupture 2 24/15 · Earth Smasher 1 28/18 · Earth Smasher 2 32/21 |
| 7 | Colossal Weapon 1 24/15 · Colossal Weapon 2 27/18 · Colossal Armor 1 30/21 · Colossal Armor 2 33/24 |
| 8 | Titan Form 1 35/23 · Titan Form 2 40/25 · — · — |

**Molten Axe** (tree 4)

| Row | Cells |
|---|---|
| 1 | Added Swing 55/0 (needs N Attack 4) · Rage Control 55/0 (needs Enrage 4) · Power Reel 55/0 (needs Power Hammer 2) · Revised Skill 55/0 |
| 2 | Solid Hold 60/1 (needs Hold Charge) · Aspect Of The Horde 60/1 (needs Trample 2) · Onslaught 60/1 (needs Overlord 2) · Revised Magic 60/1 |
| 3 | Blood Bath 70/3 (needs Blood Rage 2) · Aftershock 70/3 (needs Knock Down 4) · Pride Crusher 70/3 (needs Over Pride 4) · Revised Art 70/3 |
| 4 | Raw Strength 75/4 (needs Brute Strength 4) · Spin Hack 75/4 (needs Improved Swing 3) · Steel Skin 75/4 (needs Iron Shield) · Magma Clutter 75/4 (needs Berserker Rush 1 + Earth Rupture 1) |
| 5 | Super Stat Plus 85/6 (needs Stat Plus 4) · Mass Stun 85/6 (needs Instant Rush) · Mythril Skin 85/6 (needs Diamond Shield) · Calamity Hammer 85/6 (needs Magma Clutter) |

- **Class C prerequisites** (`rSkill`, each is a single skill from the trees above or from Class C itself): Added Swing needs N Attack 4; Rage Control needs Enrage 4; Power Reel needs Power Hammer 2; Solid Hold needs Hold Charge; Aspect Of The Horde needs Trample 2; Onslaught needs Overlord 2; Blood Bath needs Blood Rage 2; Aftershock needs Knock Down 4; Pride Crusher needs Over Pride 4; Raw Strength needs Brute Strength 4; Spin Hack needs Improved Swing 3; Steel Skin needs Iron Shield; Magma Clutter needs Berserker Rush 1 + Earth Rupture 1; Super Stat Plus needs Stat Plus 4; Mass Stun needs Instant Rush; Mythril Skin needs Diamond Shield; Calamity Hammer needs Magma Clutter.
- **Checked against the 2014 community simulator** (Rain Niar's Bison SkillSimulator V.3) **and TailsTailsSimulator.online/bison**: 97 of 97 cells have the same Lv / points in all three.
- The blog's simulator caps at Lv 95, the site at Lv 100 (its extra Class C row is ignored: there are no EX skills). Tree names come from the site.

## Server Balance Variations (ToT)

Private-server values are documented from the Bible skill-detail schema; BigBug source remains the original-server baseline.

| Skill | Original BigBug baseline | ToT delta |
|---|---|---|
| Over Power | 600s base cooldown. | Base cooldown reduced to 420s. |

Source of server delta: `12t_projects/bible/index.html:8972`.

## Server Balance Variations (ToT patch notes, 2026)

Source: ToT Facebook patch notes (C6 intro post, 03/08/2026, 10/09/2026, hot fix 12/09/2026; latest value wins), read 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tot`.

| Skill | ToT change |
|---|---|
| Brute Strength | base 5 / 10 / 15 / 20 → 10 / 15 / 20 / 25. The code adds 5% per level to the ATK coefficient, so ToT is modelled as one extra level: `bisonBruteEff(lv)` = lv + 1 on ToT (Raw Strength ×5 applies to that), used by Combo, Charge Attack and Over Swing (which carry a ToT note) |
| Fury Trance | triggers below 80 / 60 / 40% HP (was 60 / 40 / 20) |
| Over Power | base cooldown −50% (600 → 300 s); replaces the earlier −30% |
| Iron Shield / Diamond Shield | base duration 6 → 4 s |
| Spin Hack | charge range bonus 40% → 50%: on the BB base radius `5×rangeMod` (`Bison.cs:20016`, +2 = +40%) that is 5 → 7.5 m, +2.5 m instead of +2 m; Charge Attack's ToT reach and Spin Hack's ToT desc (2026-10-26) use it |
| Hold Charge | charge time reduced to 4 s / 8 hits. The note does not say which value moves (BB: hits = `floor(clamp(charge s, 2, 8))` at Charge Attack 2, `Bison.cs:5378`; Solid Hold's separate `charge s − 8` threshold, `:5383`), so the card has no ToT desc (2026-10-26) |


### ToT EX learning requirements (published simulator, 2026-10-13)

Source: [ToT bison simulator dataset](https://talesoftails.net/data/skill-simulator/bison.json), with learning rules from [ToT simulator client](https://talesoftails.net/_next/static/chunks/673.2ecb414e00f7368e.js). These are server-specific published simulator requirements, not BigBug decompiled mechanics or verified damage formulas. Icons were extracted from the site’s `/gamegui/skill-simulator/skills/` assets and embedded in the hub.

| Cell | Published skill name | Level | Ordinary C skills required | Explicit prerequisite cells | Type / availability |
|---|---|---|---|---|---|
| 451 | UpdamageMonter | 95 | 0 | None | Passive |
| 452 | RageKing5 | 100 | 6 | 204, 402, 431, 254 | Active |
| 453 | EarthQuake5 | 100 | 6 | 354 | Active |
| 454 | DesTroyer5 | 100 | 6 | 354 | Active |
| 461 | DowndamageMonter | 95 | 0 | None | Passive |

Each learned EX skill costs one point from a separate EX pool: 0 below Lv 95, 1 at Lv 95–99, 2 at Lv 100. Cells 451 and 461 exclude each other. At most one of cells 452–454 may be learned. EX skills never count toward ordinary C point requirements. All explicit prerequisites and the six ordinary C skills must remain learned; refunds and tree resets enforce this. See [shared ToT EX rules](12Tails-Mechanics-Reference.md#tot-ex-skills-published-simulator-2026-10-13).

## Server Balance Variations (Reborn)

Reborn client (`DecompiledSource_Reborn/Assembly-CSharp/`, build and tags in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §1) against BB, traced 2026-10-26; card `servers.reborn`. `Reborn:` = the Reborn decompile, `BB:` = `DecompiledSource/`.

- **Blood Rage SP clamp (Adjust):** BB `sp = Mathf.Min(sp + gain, 100)` (`BB:Bison.cs:7250`, `:7258`); Reborn `Mathf.Min(sp + gain, rbSpMax)` (`Reborn:Bison.cs:12027`, `:12031`), `rbSpMax = max(msp, rbSpCeiling)` (`Reborn:CharacterControl.cs:5983-5993`), ceiling 100 for a Bison (`Reborn:RebornBalance.cs:559-571`). So it passes 100 only when max SP does (TAL ≥ 455 or an SP seal). This is the Common SP-ceiling rule; the card gets its own note because its desc states "(ไม่เกิน 100)".
- **Berserker Rush, Calmar / Nageoire Wing counter (Adjust):** BB rolls `Random.Range(0, 100) >= target.lckAdjust(24)` (`BB:CharacterControl.cs:3573`); Reborn `>= target.lckItemAdjust(24)` (`Reborn:CharacterControl.cs:7222`) = `ItemChance(24)` = (24 × 130 + 99) / 100 = **32%**, no LCK (`Reborn:CharacterControl.cs:11882`, `Reborn:RebornBalance.cs:611-618`). The Bison condition (`berserkerRush`, action code ≤ 9) is unchanged (`Reborn:CharacterControl.cs:7232`).
- **Power Reel: cut on a Salvation block (Buff):** BB applies `cut 5` only after the axe hit lands (`BB:Bison.cs:25975`), and `hit()` returns 0 on a `salvation` target (`BB:CharacterControl.cs:3067`). Reborn: when the axe hit returns 0 because of Salvation (`RebornCombat.SalvationBlocked`, cleared at the start of every `hit()` and set only on the salvation branch, `Reborn:CharacterControl.cs:7049`, `:7119-7123`) and Power Reel (403) is learned, the target still gets `cut 5` for 1 s (`Reborn:Bison.cs:3988-3999`). `cut` removes every Magical Shield status of level ≤ its own (`Reborn:CharacterControl.cs:2497-2527`); Salvation is one (`Reborn:StatusData.cs:1591`, `:1618`) at level 1-2 (`Reborn:Whale.cs:12523`, `:12529`), so the blocked swing strips it (the swing itself still does no damage). Cards: Power Reel and Power Cleave.
- **Gear crit (Adjust; `bison_nAttack`):** BB `getCritPlus` rolls `lckAdjust(gear sum)` (`BB:Bison.cs:13801`). Reborn adds `RebornBalance.TrinketCritPlus` (+3 for `t_all61`-`63`) and the seal `critical` (`RebornEffects.CritPlus`, server data, not modelled) and rolls `lckItemAdjust(sum)` = `ceil(1.3 × sum)` with no LCK (`Reborn:Bison.cs:14192`, belt `:14222`, roll `:14224`). In the app: the shared Reborn rule (`critChance`, `procChance`, `itemChance`) and the belt toggle `REBORN_BELT_DEP`; [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §2.2, §2.4.

### Review corrections (2026-10-26)

- Crimson Engine: the SP gain stops at `max(100, max SP)` (`Reborn:Bison.cs:12015`, `Reborn:CharacterControl.cs:5983-5993`), worded like Blood Rage's Reborn desc.
- Undying Fury: `[furyTrance5]` ends at the first check where no learned Fury Trance threshold holds (HP 60% or more), and an ally Bison loses Resting Glory's Fury2 at its own next check (`Reborn:Bison.cs:12250-12330`): limit lines on both cards.
- Crimson Thirst needs Berserker Rush 4 (`SKILL_SIM_REBORN_EXTRA` 452 → 254), so its cap is 160 HP (200 with Rage Control).
- Start-of-map cooldown (every combat map: missions, PvP and combat zones, `RebornZone.CombatMap`, `Reborn:RebornZone.cs:28-38`; Revised Art applies, `Reborn:CharacterControl.cs` `addTimeOut`; card bullet on each): Stampede `agiAdjust(240)` (`Reborn:Bison.cs` `Start`), Ragnarok Quake `agiAdjust(360)` (`RebornC7Act.Seed`, `Reborn:RebornC7Act.cs:615-627`).

### C6 / C7 skills (Reborn only)

Class C rows 6 (ids 451-454, Lv 95) and 7 (461-464, Lv 105), 8 Class C skills learned, one rank each (`Reborn:BisonSkill.cs:369-414`, tree cells `:973-1011`). The C6 names come from `SkillData.rbNameOverride` (`Reborn:SkillData.cs:185-188`); the C7 four have none, so the game shows `CrimsonEngine5` etc. No Thai names. Cards are `onlyServer: "reborn"`; each original card they change carries a Reborn-only toggle (`REBORN_BISON_<NAME>_DEP`) and a modifier line in its `servers.reborn.desc`. Open-world gates (`RebornZone.Combat` / `CombatMap`, start-of-map cooldowns) are noted here only (Reborn-Mechanics-Reference.md, top).

- **`bison_savageMomentum`** (Savage Momentum, #451, passive; needs Added Swing 401 + Solid Hold 411, `rSkill 401411`, `Reborn:BisonSkill.cs:392-396`).
  - Proc: `RebornC6Passive.AfterHit`, Bison case (`Reborn:RebornC6Passive.cs:150-167`), called once per `hit()` right after `RPC_AddDamage` (`Reborn:CharacterControl.cs:7287-7289`), attacker's own client only (`Reborn:RebornC6Passive.cs:116`): action code 4 and `Random.Range(0, 100) < lckAdjust(10)` start `RPC_overSwing(position, flat forward, 0)` and send `RPC_overSwing1`. Code 4 = the first hit of the Combo spin (`Reborn:Bison.cs:1003`) and of Added Swing (`:1391`); both second hits are code 99 (`:1097`, `:1485`). One roll per enemy hit and no check for an Over Swing already running, so several procs in one swing start parallel Over Swings.
  - The triggered Over Swing skips every manual gate: the `overPower` status, skill 273, the `overSwing` timeout, SP ≥ 20 and the 20 / 10 SP cost (`Reborn:Bison.cs:11364-11376`). Damage `(int)((1 + 0.05 × Brute) × ATK + talAdjust(10 × overPower level))`, KO 1, circles 6 / 8 m × rangeMod (`:3709`, hit `:3721`); with no Over Power the TAL term is `talAdjust(0)` = 0 (`:3697`). It sets `myCommand = "overSwing"`, `actionTime` and a 1 s `overSwing` timeout (`:3628-3631`), so a proc on the spin blocks that round's Added Swing (the chain needs `nAttack3` / `nAttack4`, `:11316`); the running stage's second hit still lands (its state checks only `actionState`, `:1075-1076`, `:1463-1464`). No SP gain.
  - Damage taken: `RebornC6Passive.OnTakeDamage`, Bison case (`Reborn:RebornC6Passive.cs:294-298`): while `IsCharging` (`actionState` attack and `myCommand` `cAttack` / `cAttack1` / `cAttack2`, `:36-47`) `dmg = CeilToInt(0.9 × dmg)`, after the victim's hitMod and before the hate recompute (`Reborn:CharacterControl.cs:7339-7345`); returns at `dmg <= 0` (`Reborn:RebornC6Passive.cs:280`). `cAttack1` = charging (`Reborn:Bison.cs:1630`), `cAttack2` = the spin (`:1840`), also the Hold Charge release (`:11330`); an early release (`cAttack0`, `:2126`) is not covered. Effect Damage is not reduced (`RPC_AddEffectDamage`, `Reborn:CharacterControl.cs:7891`, never calls it).
  - Thai tooltip (`Reborn:BisonSkill_thai.cs:21-22`): "ตีปกติครั้งที่ 4" is Added Swing (its own tooltip, `:352`); the code also rolls on the spin's first hit and once per enemy (tooltipNote).
  - Cards changed (`REBORN_BISON_SAVAGE_MOMENTUM_DEP`, `descDep` + desc line): nAttack, Added Swing, Over Swing (its Reborn desc reads Over Power with `getDepRank`, because the Reborn `descDep` takes the desc's dep slot), Charge Attack.
- **`bison_crimsonThirst`** (Crimson Thirst, #452, passive; needs Berserker Rush 4, `Reborn:BisonSkill.cs:397-401`). `RebornC6.BisonDrain(cc, lv, dmg)` (`Reborn:RebornC6.cs:1421-1428`): with 452 `CeilToInt(Min(0.28f × dmg, 40 × Max(1, lv)))`, without it the BB value `CeilToInt(Min((0.04 lv + 0.04) × dmg, 8 lv))`. Called only by the Combo stages while `berserkerRush` is active (`Reborn:Bison.cs:197`, `:467`, `:742`, spin `:1028`, `:1122`, Added Swing `:1416`, `:1510`), heal `RPC_AddHeal(250 + lv, heal)` on the Bison (`:198`), `lv` = the status level (ranks + Rage Control), `dmg` = the largest `hit()` return of the pass (`:182-185`). So 28% at every level, cap 40 / 80 / 120 / 160 / 200 HP at status level 1-5. Trigger and duration unchanged. Card changed: Berserker Rush (`REBORN_BISON_CRIMSON_THIRST_DEP` as `descDep`; its Reborn `status.sLv` and desc read Rage Control with `getDepRank`). The berserkerRush status popup keeps the BB numbers (the change follows the skill, not the server).
- **`bison_gaiaFissure`** (Gaia Fissure, #453, passive; needs Earth Smasher 2, so Earth Rupture 2 by the previous-rank rule, `Reborn:BisonSkill.cs:402-406`, `Reborn:GameGui.cs:8990`).
  - Earth Smasher: `RebornC6.BisonSmasher` = `CeilToInt((float)raw × 1.3f)` around the truncated raw `(int)((0.5 sLv + 0.5) × ATK + talAdjust(50 sLv))`, before `hit()` (`Reborn:RebornC6.cs:1438-1445`, `Reborn:Bison.cs:5040`); KO and area unchanged. Card: Reborn `dmgPostScale` = `Math.fround(1.3)` with the toggle.
  - Earth Rupture: `RebornC6.BisonRuptureFan` (`Reborn:RebornC6.cs:1474-1497`), called from `RPC_earthRupture_fire1` / `fire2` (`Reborn:Bison.cs:12526`, `:12555`), adds 2 `earthRupture` projectiles at ±30° (rank 1) or ±50° (rank 2), life 2 s, the same per-target hit `(int)(0.5 × ATK + talAdjust(30))`, KO 5 (`Reborn:Bison_earthRupture.cs:59`). Rank 2 = 5 waves (0°, ±25° `:12546-12553`, ±50°).
  - Chain: `MarkSmasher` stores `Time.time` at Earth Smasher's slam, inside the uninterrupted slam state 1.4 s after the cast (`Reborn:Bison.cs:5015`). `BisonRupture` runs at Earth Rupture's cast start, before its 0.8 s windup (`:4807`, `:4813`): with a mark at most 6 s old it removes the mark and starts `BisonWaveCo` (`Reborn:RebornC6.cs:1447-1463`), so one set per slam, and it fires even if Earth Rupture is interrupted.
  - Detonations `BisonWaveCo` (`Reborn:RebornC6.cs:1499-1525`): start point and flat direction fixed at the cast; after 0.5 s, for n = 0..3, centre start + dir × (4 + 4n) m, `Area(centre, 3.5, 4, EnemyMask)` (`Damage.FindAreaTarget`, no rangeMod, `:871-890`), `FloorToInt(0.9f × ATK + talAdjust(50))` rolled once per detonation, `hit(453, …, KO 60, hate 0, force 3·dir + 2·up)`, owner only, 0.2 s apart (0.5 / 0.7 / 0.9 / 1.1 s). A still target is inside at most 2 circles; the forward knock can carry it into more, so the card's 4 hits are the ceiling. No SP.
  - Thai tooltip "5 แนว 15 หนาม": the code has 5 projectiles, each hitting a target once; whether the prefab draws 3 spikes per wave was not checked, so no tooltipNote.
  - Cards changed (`REBORN_BISON_GAIA_FISSURE_DEP`): Earth Smasher (`dmgControls`, `dmgPostScale`, desc line), Earth Rupture (`descDep`, desc line, Reborn `reach` with the wider fan, `reachControls`).
- **`bison_stampede`** (Stampede, #454; needs Calamity Hammer 444): `setMPSP(60, -70)`, instant, target all, cType `stampede` (`Reborn:BisonSkill.cs:407-414`). Cast along the facing, the target id is unused (`Reborn:Bison.cs:11641-11648`); peers replay it through `Bison_C6` (`Reborn:Bison_C6.cs:15-42`). `RPC_stampede` (`Reborn:Bison.cs:14236-14340`): cooldown `agiAdjust(240)` (`:14241`, Revised Art applies, `Reborn:CharacterControl.cs:11681-11686`); roar 0.5 s, no hit (`:14254`); 16 steps, each breaking unless still `attack` / `stampede` (`:14261-14268`): `moveSpeed = 28` (`:14270`), owner `Area(pos + dir, 3, 3, EnemyMask)` (`:14285`): first contact `sticky` Lv 3 for 3 s flat (`:14294`), then `hit(454, FloorToInt(0.2f × ATK), KO 15, force 1.5·dir)` (`:14296`), wait 0.05 s (`:14300`): hits at 0.5 … 1.25 s, 1.4 m apart, 22.4 m in all at moveMod 1. Then with no state check (`:14302-14326`): `Area(pos + 1.5·dir, 5, 4)`, `hit(454, FloorToInt(1.8f × ATK + talAdjust(120)), KO 100, force 3·dir + 2·up)` and `paralysis` Lv 1 for 4 s flat whatever `hit()` returned (`:14323-14324`), at 1.3 s; stand-by at 1.8 s. So an interrupted dash still blasts where it stopped. Thai tooltip "พุ่ง 20m" vs about 22.4 m (tooltipNote). Start-of-map cooldown `agiAdjust(240)` on a CombatMap (`:9729-9734`, open world). No original card changed; Ragnarok Quake needs it (tree only).
- **`bison_crimsonEngine`** (Crimson Engine, #461, passive; needs Blood Rage 2 + Blood Bath, `rSkill 122421`, `Reborn:BisonSkill.cs:369-373`). `getBloodRage` (`Reborn:Bison.cs:11995-12037`): runs on the frame after HP loss (`myDamage != -1`) behind the `_1680_u2` gate (`:11997`); with 461 the `lckAdjust(num × 20)` roll is skipped, every trigger sets the 1 s gate (`:12012`) and gives `Max(3, 3 × (Blood Bath ? num × 4 : num × 2))` = **+24 SP** (`:12013`), capped at `rbSpMax` (`:12015`), then `RebornC7Passive.BisonEngine(gain)` (`Reborn:RebornC7Passive.cs:1394-1430`): refreshes `_bsnLastHit` on every call (even at 0 gain, `:1400`), adds the gain to a pool, +1 tier and `deltaAtk(20)` per 50 up to 10 tiers (**+200 ATK**), pool capped at 50 at tier 10. `BisonTick` (`:1432-1441`, local Bison with HP > 0, `:909-912`, `:976-977`): 8 s without a trigger → `deltaAtk(-20 × tier)`, reset. The ATK is a plain stat delta, no status. `_bsnPool` / `_bsnTier` / `_bsnLastHit` are static (`:120-124`): changing map with tiers > 0 gives the new character −20 × tier 8 s later, kept for that map (`deltaAtk` writes `atk` and `_2005_u1`, `loadCharacterData` rebuilds `atk` from `_2005_u1`, `Reborn:CharacterControl.cs:11954-11958`, `:6571-6575`) (card `unintended`). Thai tooltip "โดนตีได้ SP ทุกครั้ง" vs the 1 s gate (tooltipNote). Triggers only inside `RebornZone.Combat` (`Reborn:Bison.cs:9760-9781`, open world). Cards changed (`REBORN_BISON_CRIMSON_ENGINE_DEP`): Blood Rage (Reborn `lckProc` 100% with the toggle, `depGates: false`; desc line), Blood Bath (`descDep`, desc line).
- **`bison_undyingFury`** (Undying Fury, #462, passive; needs Fury Trance 3, `Reborn:BisonSkill.cs:374-378`). `getFuryTrance` (`Reborn:Bison.cs:12254-12328`): with 462 and `hp × 10 < mhp`, when furyTrance is below 5, `RPC_AddStatus("furyTrance", 5, chaAdjust(12))`, 3 s lockout, return before the rank loop (`:12260-12269`); a Lv 5 in place is not refreshed. furyTrance = `deltaAtk(20 × level)` → +100 (`Reborn:CharacterControl.cs:2093-2095`, removal `:10097-10099`). Leech: `RebornC7Passive.AfterHit`, Bison (`Reborn:RebornC7Passive.cs:633-638`): 462, local, furyTrance ≥ 4, 0.2 s gate → `RPC_AddHeal(462, Max(1, dmg / 5))`, `dmg` = the `hit()` value before the target's hitMod; skipped at `dmg <= 0` or inside a C7 proc hit (`:598-602`); Effect Damage the Bison deals never reaches it. KO: `OnTakeDamage` (`:712-717`) sets `ko = 0` at furyTrance ≥ 4, only in `RPC_AddDamage` (`Reborn:CharacterControl.cs:7343-7344`) and only when `dmg > 0` after hitMod (`Reborn:RebornC7Passive.cs:692-697`); Effect Damage KO still lands. Level 5 is the only level ≥ 4 any source grants (Fury Trance 1-3, Fury2). Resting Glory (`Reborn:Bison.cs:12234-12252`): heal `(int)(0.6 × mhp)` instead of 0.35, and each healed unit that passes `AllyAllowed` gets furyTrance Lv 2 for 20 s flat (+40 ATK). The Bison's own Lv 5 is removed at the first check where no learned Fury Trance threshold holds (HP back at 60% or more with all three ranks; `:12320-12326`), so it can end before its duration (card limit line, 2026-10-26). Cross-class: an ally Wolf with Unyielding Oath (461) gets every incoming buff one level higher (`Reborn:RebornC7Passive.cs:800-813`), so Lv 3 (+60); an ally Bison in a combat zone loses Fury2 at its next check unless one of its own Fury Trance thresholds holds (`Reborn:Bison.cs:12270-12279`, `:12323-12326`). Thai "ขั้น 4" vs status Lv 5 (ATK +100 matches; numbering only, no tooltipNote). Cards changed (`REBORN_BISON_UNDYING_FURY_DEP`, `descDep` + desc line): Fury Trance, Resting Glory.
- **`bison_colossusUnbound`** (Colossus Unbound, #463, passive; needs Colossal Armor 2, `Reborn:BisonSkill.cs:379-383`). `getColossalWeaponLv` returns 4 with 463 (`Reborn:Bison.cs:12568-12584`): splash `CeilToInt(0.2f × 4 × the stage's largest hit())` = 80% to the targets the stage missed (`:233`, `:503`, `:778`, `:1064`, `:1158`, `:1452`, `:1546`), area `FindAreaTarget(pos + forward, hasSkill(463) ? 12 : 8, h)`, h 4 for stages 1-3 (`:202`, `:472`, `:747`), 6 for the spin and Added Swing (`:1033`, `:1127`, `:1421`, `:1515`). Colossal Armor (`Reborn:CharacterControl.cs:7420-7437`): `num3 = 3` with 463, i.e. 3 Effect Damage and 3 KO to the attacker; this runs on the attacker's client against its copy of the Bison, so it needs skill 463 in that copy's list (server spawn data, not verifiable from the client). Unpushable (`Reborn:RebornC7Passive.cs:1546-1555`): `nForce` zeroed in `RPC_AddDamage` (`Reborn:CharacterControl.cs:7325-7328`) and the `AddDamage` coroutine (`:114-118`); Effect Damage force still applies (`:8132`). Size: `localScale + 0.2` (`Reborn:RebornC7Passive.cs:1567-1579`), no rangeMod change. Cards changed (`REBORN_BISON_COLOSSUS_UNBOUND_DEP`): Colossal Weapon (`descDep`, desc line, Reborn `reach` r 12), Colossal Armor (`dmgControls`, dmg / KO 3), nAttack (`dmgControls`, Reborn `splashLine` pct 0.8, desc line; its base reach draws the 12 m splash only when `reachSrv()` is reborn and the toggle is on).
- **`bison_ragnarokQuake`** (Ragnarok Quake, #464; needs Stampede 454): `setMPSP(100, -90)`, instant, target all, cType `ragnarokQuake` (`Reborn:BisonSkill.cs:384-391`); cast `RebornC7Act.Cast(…, 464, position, forward, …)` (`Reborn:Bison.cs:11634-11640`). `BisonRagnarok` (`Reborn:RebornC7Act.cs:1390-1553`): `Begin(cc, "ragnarokQuake", 600)` = `addTimeOut(agiAdjust(600))` (`:808-816`, Revised Art applies); wait 0.8 s, `moveSpeed 2` only while still attacking (`:1417-1426`), 0.6 s; slam at 1.4 s at the ground point 1.4 m ahead (`:1431-1437`; 2.6 m from the cast point at moveMod 1): `Hit(cc, 464, c, 20, 6, 2.5, 200, 100, 3)` = `FloorToInt(2.5f × ATK) + talAdjust(200)` once for every target, KO 100, outward force (`:851-870`, `:1461`); `atkUp` Lv 1 for 10 s, sValue 40 to every ally in `AllyArea(c, 20, 6)` and the Bison itself (`:1462-1473`), atkUp = `deltaAtk(sValue)` (`Reborn:CharacterControl.cs:1564-1567`). Cracks: `FractureNet(c, 4.4, 20, 8, seed, 2.6)` (`:1476`; 8 random spokes from 4.4 m out to 78-100% of 20 m, `Reborn:RebornC7Fx.cs:1905-1997`); after `End` at 2.6 s, 10 flares 1 s apart (2.6 … 11.6 s): every enemy in `Area(c, 21, 4)` within half the local width + 0.9 m of a crack (`OnRibbon`, `Reborn:RebornC7Fx.cs:1399-1428`) takes `RPC_AddEffectDamage(464, talAdjust(60), KO 0)` (`:1524-1547`). Nothing checks the Bison's state or HP after the step: an interrupted or killed Bison still slams (without the step), buffs and flares; the loop stops only when the Bison object is destroyed. Start-of-map cooldown `agiAdjust(360)` on a CombatMap (`RebornC7Act.Seed`, `:615-623`, open world). No original card changed. The `[atkUp]` popup's no-level text was made generic (flat sValue grants such as this one).

## Hit timing for the reach playback (traced 2026-10-16)

Seconds from the start of the move (or of the child routine named), read from the coroutine waits in order; every hit uses the box / circle already documented above. The Bible reach preview replays exactly these times.

- **Calamity Hammer lava:** `OnCalamityHammer` fires `RPC_calamityHammer_fire` at the target 10 times, 1.5 s apart (`Bison.cs:32564` `i < 10`, `Yield 1.5`): with the first lava at 2.4 s, 2.4 … 15.9 s.

### Riding mounts: mountAttack and mountDash (G. Marshal / G. Champion mount, verified 2026-10-17)
Both mounts run the same attack code for this class (`PvpMount.cs` and `ChampionMount.cs` differ only in the +20 / +50 stat bonus, the ride speed 8 / 9 and the Champion's charge; the shared rules are in [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md#riding-mounts-g-marshal-and-g-champion-verified-2026-10-17)). ATK, TAL and LCK are the mount's own (rider's base stats + bonus). Line numbers are `PvpMount.cs`; `ChampionMount.cs` has the same code a few hundred lines later.
- **mountAttack** (normal attack while moving at no more than 40% of the run speed): `FindRecTarget(pos, fwd, 3, 3, 3, 3)`, `hit(2, ATK, KO 1)`, cooldown 1.5 s (`:6198-6221, :6342`).
- **mountDash** (normal attack while moving faster): `FindAreaTarget(pos, 8, 3)`, `hit(22, (int)(1.6 × ATK), KO 1)`, cooldown 1.5 s (`:6707-6730, :6839`).
