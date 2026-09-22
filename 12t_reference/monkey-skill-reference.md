# Monkey — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| summonAttack | Summon Attack | 1 | 3 | false | false | — | — |
| summonDefense | Summon Defense | 1 | 3 | false | false | — | — |
| summonRelease | Summon Release | 1 | 3 | false | false | — | — |
| unsummon | Unsummon | 1 | 3 | false | false | — | — |
| instantCast | Instant Cast | 2 | 240 | true | false | 12 | true |
| fireBall | Fireball | 4 | 30 | true | false | — | — |
| phoenix | Phoenix | 4 | 45 | true | false | ∞ | — |
| skyCrimson | Sky Crimson | 1 | 120 | true | false | — | — |
| blazingArrow | Blazing Arrow | 1 | 120 | true | false | — | — |
| flashFire | Flash Fire | 4 | 60 | true | false | — | — |
| ja | Ja | 4 | 90 | true | false | ∞ | — |
| runicFlame | Runic Flame | 1 | 180 | true | false | 5 | true |
| worldIgnition | World Ignition | 2 | 300 | true | false | — | — |
| instantBlaze | Instant Blaze | 1 | 30 | true | false | — | — |
| fireAvatar | Fire Avatar | 1 | 600 | true | false | 120 | true |
| groundLock | Ground Lock | 4 | 30 | true | false | — | — |
| gadina | Gadina | 4 | 45 | true | false | ∞ | — |
| planetBreaker | Planet Breaker | 1 | 60 | true | false | — | — |
| titanicEarthPulse | Titanic Earth Pulse | 1 | 240 | true | false | — | — |
| stoneHammer | Stone Hammer | 4 | 60 | true | false | — | — |
| buiten | Buiten Hou Hou | 4 | 120 | true | false | ∞ | — |
| runicSand | Runic Sand | 1 | 180 | true | false | 5 | true |
| earthGuard | Earth Guard | 1 | 60 | true | false | — | — |
| earthForm | Earth Form | 1 | 600 | true | false | 120 | true |
| lavu | Lavu | 2 | 600 | true | false | 60 | true |
| volcanicEruption | Volcanic Eruption | 1 | 240 | true | false | — | — |
| summonGaos | Summon Gaos | 1 | 300 | true | false | ∞ | — |
| summonSoul | Summon Soul | 1 | 3 | false | false | 240 | false |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Monkey's own thematic `elementalBound`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Monkey.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Monkey.cs:14681`), `psalmOfEnergy`
  (`Monkey.cs:14924`), `seaAegis` (`Monkey.cs:15093`), `zephyrLore` (`Monkey.cs:15287`), `replenishment`
  (`Monkey.cs:15388`), `elementalBound` (`Monkey.cs:15518`), `astralShift` (`Monkey.cs:15670`),
  `bloodCarnage` (`Monkey.cs:15861`), `obsidianFang` (`Monkey.cs:44447`), `assassinate`
  (`Monkey.cs:44903`), `mineWalker` (`Monkey.cs:45298`), `divineChannel` (`Monkey.cs:45658`) — all 12
  present, all bare-`600`. A direct grep of `MonkeySkill.cs` for `elementalBound` (Monkey's own
  thematically-named support skill) returns zero matches, confirming it isn't part of Monkey's own
  learnable-skill roster (`getSkill()`). All 12 excluded.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.** Both
  carry their own cooldown handling in `Monkey.cs` (e.g. `addTimeOut("nAttack", 1f)` at `Monkey.cs:9630`,
  `1.5f` variants at `20148`/`20407`/`36196`/`36481`, `(float)1` variants at `39198`/`41348`/`41825`/
  `42359`) and their own `getSkill()` entries (`mnk_nAttack1`, `mnk_cAttack1`-`4`), but are excluded
  regardless per the plan's blanket policy.
- **`mount` is not a Monkey class skill — excluded, not a judgment call.** `Monkey.cs:49951` —
  `this.$self_$25037.EOxsb7GTOK.addTimeOut("mount", (float)12);` — sits inside the universal
  ride-a-mount action shared by every class. `MonkeySkill.cs` has no `cType`/`getSkill()` entry for
  `"mount"` at all, confirming it isn't part of Monkey's learnable roster.
- **`mnk_damageCast1`/`mnk_damageCast2` are dead/unused entries in `getSkill()` — excluded, not
  passives, not real active skills.** Each sets `setReq(...)` but the branch falls out of the
  if/elseif chain without ever assigning `mode`/`cType` (`MonkeySkill.cs:48-66`), and a full-file grep
  of `Monkey.cs` for `RPC_damageCast` and the literal `"damageCast"` returns zero matches — there is no
  cast site anywhere. The eng description ("Makes Mike circle around Monkey when he is charging or
  casting spell, dealing 50%/100% normal attack damage", `MonkeySkill_eng.cs:48`, `59`) describes the
  same "Mike circling" mechanic that the Class-C passive `mnk_mikeCircle5` later upgrades
  (`MonkeySkill_eng.cs:895`: "call out Mikes to circle around its target") — `damageCast1`/`2` are the
  base tier of that passive proc chain, not a standalone castable skill. Excluded entirely.
- **Thirteen skills — `fireBall`, `phoenix`, `ja`, `worldIgnition`, `groundLock`, `gadina`,
  `stoneHammer`, `buiten` (buitenHouHou), `lavu`, `fireAvatar`, `earthForm`, `volcanicEruption`,
  `summonGaos` — all cast through one shared coroutine, `RPC_cast(string sType, Vector3 mPos, Vector3
  tDir, int tID, int sLv)` (`Monkey.cs:11049`, body class `$RPC_cast$24449` at `24676`).** Unlike the
  Mole `heavyBuilt`/`speedDrill`/`skyDrill` precedent (a dead-code fallthrough artifact), this is
  confirmed **intentional, functioning** shared architecture: a real `switch` on `sType`
  (`Monkey.cs:25142-25429`) explicitly sets a per-skill `$mTimeOut$24451` value for every branch, then
  one shared call applies it: `Monkey.cs:25450` —
  `this.$self_$24474.EOxsb7GTOK.addTimeOut(this.$sType$24469, this.$self_$24474.EOxsb7GTOK.agiAdjust((float)this.$mTimeOut$24451));`
  — matching the Mole `autoGyroGun`/`barrelBot`/`warCapital` "assemble"-coroutine precedent for a
  legitimate shared cast site, not a convergence bug. `getSkill()` confirms each family's own numbered
  roster entries independently (`fireBall1`-`4`, `phoenix1`-`4`, `ja1`-`4`, `worldIgnition1`-`2`,
  `groundLock1`-`4`, `gadina1`-`4`, `stoneHammer1`-`4`, `buitenHouHou1`-`4`, `lavu1`-`2`, and the
  single-rank Class-C `fireAvatar5`/`earthForm5`/`volcanicEruption5`/`summonGaos5`), each landing on its
  own distinct `cType` assignment — no cross-family identity confusion. `volcanicEruption`'s
  (`Monkey.cs:86`) and `summonGaos`'s (`Monkey.cs:89`) shared-dispatcher values are also confirmed by a
  matching preemptive `addTimeOut` set outside the coroutine, same zeroShot/warFactory-style precedent
  from the Mole doc.
- **Checked specifically for the classic `getSkill()` dead-code-fallthrough trap (Mole's
  `heavyBuilt`/`speedDrill`/`skyDrill` pattern) across all six of Monkey's passive skill families —
  none found; each passive family lands on its own distinct terminal label, not an active skill's
  `cType` block.** Traced every rank chain to its actual terminal label: `rapidFire1`-`3` → `IL_3223`
  (`MonkeySkill.cs:2088`, own passive-only tail, no `cType`); `intenseFire1`-`3` → `IL_133C`
  (`:2070`); `fireRune1`-`3` → `IL_3695`→`IL_1836` (`:1953`→`:1941`); `titanSword1`-`3` → `IL_926`
  (`:1798`); `aegisOfEarth1`-`3` → `IL_29EE`→`IL_1FA8` (`:1785`→`:1773`); `earthRune1`-`3` →
  `IL_348C`→`IL_2FF8` (`:1667`→`:1655`). `fireRune`'s and `earthRune`'s terminal tails coincidentally
  set identical `setReq(34, 20)` values, but they are two separately-defined labels reached by two
  separate branches — not a shared jump target — so this is not a convergence artifact, just duplicate
  literal constants. All six families set `mode = eSkillMode.passive` with no `cType`, no `RPC_<name>`
  cast handler, and no `addTimeOut` anywhere in `Monkey.cs`. No table row, as confirmed passives.
- **`earthRune` is the inverse case worth flagging: it looks passive in `getSkill()` (confirmed above)
  but Monkey.cs *does* contain real, working `RPC_earthRune`/`RPC_earthPulse` handlers — these are an
  automatic proc, not a player-cast skill, so the exclusion still holds.** `Monkey.cs:13554` —
  `int earthRuneLv = this.getEarthRuneLv();` — reads how many ranks of the passive are learned, then
  `Monkey.cs:13572` triggers `RPC_AddHeal(360 + earthRuneLv, ...)` automatically whenever a qualifying
  hit lands, matching the eng description "Gives Monkey a 20% chance to restore 4/8/12 SP and MP
  everytime he or his earth summon gets hit" (`MonkeySkill_eng.cs:818`, `829`, `840`) — a passive
  proc-trigger, never directly cast by the player, no `addTimeOut` of its own. Excluded, consistent
  with `getSkill()`.
- **`upheaval`, `blazingForm`, and `sentinalGuard` are summoned-companion sub-attack commands, not
  entries in Monkey's own learnable-skill roster — excluded, same reasoning as Mole's `mineWalker`.**
  All three carry real `addTimeOut` calls in `Monkey.cs` (`upheaval`: `Monkey.cs:35310`,
  `agiAdjust(60f)`, gated by `myCommand == "upheaval"` and `this.jmCs4Gf9TZ == eMonkeySummonType.lavu`
  at `Monkey.cs:10364`/`35037` — the summoned `lavu` creature's own special attack, triggered while that
  companion is active; `blazingForm`: `Monkey.cs:39948`/`40302`, flat `(float)6`, tied to the
  `phoenixArmor_blazingForm` RPCs — the `fireAvatar` transformation's charge-attack sub-state;
  `sentinalGuard`: `Monkey.cs:42872`/`43264`, flat `(float)6`, tied to `gadinaArmor_sentinalGuard` — the
  `earthForm` transformation's guard-charge sub-state), but a direct grep of `MonkeySkill.cs` for all
  three names returns zero matches. None of them have their own `getSkill()`/`getSkillTree()` entry;
  they are internal states of the `phoenix`/`gadina`/`lavu`/`fireAvatar`/`earthForm` summon-and-transform
  system, not independently learnable/castable skills. Excluded.
- **`phoenix`, `ja`, `gadina`, `buiten`, and `summonGaos` each summon a real `CharacterControl`-bearing
  pet with no despawn timer anywhere — confirmed by reading each pet's own class file in full
  (2026-08-14, user request) — reported as `∞` (infinite-duration chip), not `—`.** Each skill's
  `RPC_<name>_create` spawns its pet fresh, calling `SendMessage("unsummon")` on any existing one first
  (recasting replaces, doesn't stack): `phoenix`/`ja`/`gadina`/`buiten` create `Phoenix`/`Ja`/`Gadina`/
  `Buiten`-typed GameObjects (`isSummon = true` set on each, e.g. `Monkey.cs:11624` for `phoenix`);
  `summonGaos` mirrors the pattern (`Monkey.cs:14444`, `Resources.Load(".../Gaos/Gaos")`). A full read of
  `Phoenix.cs`, `Ja.cs`, `Gadina.cs`, `Buiten.cs`, and `Gaos.cs` found zero `chaAdjust`/`talAdjust`/
  `Time.time`-based despawn deadlines in any of them — every `Destroy(this.gameObject)` call sits inside
  that pet's own `unsummon()` coroutine (explicit dismiss or implicit replace-on-recast) or its death
  sequence (`hp <= 0`), never a timer. This is the "confirmed no timer, persists until death/unsummon/
  disconnect" case, distinct from a skill with no citable Duration data at all — the lookup tool
  surfaces the distinction as an `∞` chip rather than a plain `—`.
- **Bat's `guardianOfTheNight` and Whale's `12thKingdomKnight` were checked for the same pattern
  (2026-08-14) and are NOT included above — they're a different, ambiguous case, flagged for the user
  rather than resolved here.** Both spawn a persistent escort `MonoBehaviour` with no despawn timer of
  its own (matching the `phoenix`-family pattern), but neither is `CharacterControl`-bearing — each only
  holds a reference to the *owner's* `CharacterControl` and attacks via the owner's own `hit()`
  (`Bat_guardianOfTheNight.cs:154`/`893`; `whale_kingdomKnight.cs:36`/`439`), more like a stat-borrowing
  turret than an independent pet. Both classes' own docs already report a real, separately-verified
  `chaAdjust(60)` **status** duration tied to the same skill name (`bat-skill-reference.md`'s
  `guardianOfTheNight`, `whale-skill-reference.md`'s `12thKingdomKnight`'s `"kingdomKnight"`
  buff) — whether that status expiring actually despawns the escort, or the escort structurally outlives
  it (matching this session's earlier `flameCarnival` miscite, where a real `chaAdjust` value turned out
  to gate the wrong thing), has not been independently re-verified. Not changed pending that check —
  `bat-skill-reference.md`'s and `whale-skill-reference.md`'s own citations for those
  two skills stand as-is for now.
- **`fireBall`'s cooldown is conditionally halved by a separate passive (`hasSkill(402)`, almost
  certainly `rapidFire3`, "Reduces fireballs' casting and cooldown by 3 and 6 seconds" per
  `MonkeySkill_eng.cs:334`) when cast without a target lock — this table reports the un-passived base
  value.** `Monkey.cs:25153` — `this.$mTimeOut$24451 = 18 + this.$sLv$24473 * 3 - this.$mRapidFireLv$24453 * 3;`
  (base formula, `$mRapidFireLv$24453` from `getRapidFireLv()` at `Monkey.cs:25127`) — at max rank
  (`sLv=4`, unpassived `rapidFireLv=0`): `18 + 12 - 0 = 30`, reported. `Monkey.cs:25158-25170` then
  further halves the already-computed value via `Mathf.CeilToInt(0.5f * mTimeOut)` when
  `hasSkill(402)` is true **and** `tID == 0` (no target lock) — this passive-conditional halving is
  excluded from the reported base, matching the Mole `mine`/`stunMine` `hasSkill(402)` precedent.
- **`skyCrimson`, `worldIgnition`, and `groundLock` all apply a genuine debuff status via
  `RPC_AddStatus`, but each duration is computed through `Damage.getDebuff(base, casterCha, targetCha)`
  — CHA-contested, so both Duration cells are `—` per the plan's contested-duration rule.** `skyCrimson`
  (`burn` status): `Monkey.cs:28177` —
  `this.$mDuration$24522 = Damage.getDebuff((float)8, this.$self_$24527.EOxsb7GTOK.cha, this.$tChar$24521.cha);`
  applied at `Monkey.cs:28188`. `worldIgnition` (`ignite` status): `Monkey.cs:29902` —
  `this.$mDuration$24564 = Damage.getDebuff((float)60, this.$self_$24567.EOxsb7GTOK.cha, this.$tChar$24563.cha);`
  applied at `Monkey.cs:29907` (the 4th param, `sLv*400+400`, is the explosion damage threshold from the
  eng description "explode after 800/1200 damage" — not a duration). `groundLock` (`groundLock` lock
  status): `Monkey.cs:30608` —
  `this.$mDuration$24585 = Damage.getDebuff((float)(3 + this.$self_$24588.getAegisOfEarthLv()), this.$self_$24588.EOxsb7GTOK.cha, this.$tChar$24584.cha);`
  applied at `Monkey.cs:30619` — the base `3` is separately extended by two passives, `aegisOfEarth1`-`3`
  (`+1`/`+2`/`+3`, matching the eng description "increases Monkey's ground lock duration to 4/5/6
  seconds") and `secondStone5` ("Add 2 seconds to 'groundlock' duration"), neither of which changes the
  fact that the final value is CHA-contested and thus unreportable as a fixed base.
- **`runicFlame` and `runicSand` are sp-scaled self-channels with no fixed Duration of their own, but
  each periodically drops a fire/sand-trail segment on the ground whose own lingering lifetime — a
  `chaAdjust(5)` value, reported 2026-08-14 at the user's request — is what this table's Duration column
  reports, per the "cite the object's own on-the-ground lifetime, not just character-applied statuses"
  convention established for Mole's mines/Rabbit's fields.** The channel-gating self-status
  (`RPC_AddStatus("runicFlame"/"runicSand", 1, Mathf.FloorToInt(sp*0.2f), 0, ...)`, `Monkey.cs:29442`/
  `:34130`) scales with the caster's **current SP pool** at cast time, not a fixed learnable value, so it
  has no reportable Duration Base of its own (same "channeled, no fixed duration" reasoning as the Mole
  `advanceRepair` precedent) — that status is NOT what this table's Duration cell reports. What it
  reports instead is each trail segment's own ground-lifetime: while the channel status is active,
  `Monkey.cs:12431` — `int tID = this.EOxsb7GTOK.chaAdjust(5);` (inside `RunicFlame()`, called every
  `0.2f`s while `hasStatus("runicFlame")`) — computes a **chaAdjust-wrapped value of `5`** and passes it
  through `RPC_runicFlame_fire(tPos, tDir, tID)` → `Monkey_runicFlame.Init(gameObject, mChar, nLife)`
  where `Monkey_runicFlame.cs:27` sets `this.mLife = Time.time + (float)nLife;` — the parameter is
  literally named `tID` at the call site (matching the standard `(Vector3 mPos, Vector3 tDir, int tID)`
  RPC signature convention) but is actually reused to carry the individual fire-trail segment's 5-second
  lifetime, not a real target actor ID. `runicSand` mirrors this exactly at `Monkey.cs:13697` /
  `Monkey_runicSand.cs:27`. Every segment dropped during the channel shares this same fixed 5s
  (`chaAdjust`-scaled) lifetime, so it's a stable, citable Duration despite the channel itself having
  none.
- **`summonSoul` sets `addTimeOut("summonSoul", ...)` twice, on two different characters — only the
  self-cast is the player's real recast cooldown.** `Monkey.cs:24139` —
  `this.$mSummonChar$24439.addTimeOut("summonSoul", (float)999);` — applied to the **summoned
  companion object itself** (a near-permanent lockout preventing that specific summon instance from
  being soul-called again), not the caster's cooldown, and excluded from CD Base. `Monkey.cs:24510` —
  `this.$self_$24444.EOxsb7GTOK.addTimeOut("summonSoul", (float)3);` — applied to **Monkey himself**,
  the real player-facing recast cooldown, reported as CD Base `3` (bare, unwrapped — same short
  pet-command-throttle pattern as `summonAttack`/`summonDefense`/`summonRelease`/`unsummon`, all `3`,
  all unwrapped). `summonSoul`'s Duration is a separate mechanic: a themed buff applied to a **friendly
  target**, switched on Monkey's current summon type (`Monkey.cs:24184-24413`,
  `phoenixSoul`/`jaSoul`/`gadinaSoul`/`buitenSoul`/`gaosSoul`), every branch using the identical bare
  literal `RPC_AddStatus("<type>Soul", sLv, 240, 0, ...)` — flat `240`, confirmed not chaAdjust-wrapped,
  applied to the target ally with no `Damage.getDebuff` involved (not contested — it's a beneficial buff
  to a friendly, not a resisted debuff). Duration Base `240`, Duration Wrapped `false`.
- **`unsummon`'s cooldown key is literally `"unSummon"` (capital S) in `Monkey.cs`, while `getSkill()`'s
  `cType` is lowercase `"unsummon"` — a casing mismatch, not a different skill.** `Monkey.cs:23449` —
  `this.$self_$24425.EOxsb7GTOK.addTimeOut("unSummon", (float)3);` vs. `MonkeySkill.cs:196` —
  `skillClass.cType = "unsummon";`. This table uses the lowercase `cType` spelling as the Skill ID for
  consistency with the roster convention, matching every other row.
- **`fireAvatar` and `earthForm` are transformation ultimates with a genuine chaAdjust-wrapped
  self-duration, applied via `RPC_AddStatus` under the transformation's own name (not a generic
  `"transform"` key like Mole's `kingKaiser`).** `fireAvatar`: `Monkey.cs:38371` —
  `this.$self_$24776.EOxsb7GTOK.RPC_AddStatus("fireAvatar", 5, this.$self_$24776.EOxsb7GTOK.chaAdjust(120), 0, ...);`
  `earthForm`: `Monkey.cs:40671` — identical pattern with `"earthForm"`. Both self-only, non-contested,
  Duration Base `120`, Duration Wrapped `true`, matching each transformation's huge `600`s recast
  cooldown (a per-fight ultimate, same shape as Mole's `kingKaiser`). A `burn` proc via
  `Damage.getDebuff((float)8, ...)` also fires from `fireAvatar`'s charge-attack sub-state
  (`Monkey.cs:39810`, tied to the excluded `blazingForm` command) — CHA-contested and an incidental
  attack side effect, not `fireAvatar`'s own duration, so it is **not** used as this table's reported
  value (same reasoning the Mole doc used to exclude `warFactory`'s `rollerMachine` paralysis proc).
- **`lavu`'s Duration is a self-buff applied at the same cast site as the summon, chaAdjust-wrapped, not
  contested.** `Monkey.cs:34579` — `this.$mDuration$24678 = this.$self_$24681.EOxsb7GTOK.chaAdjust(60);`
  — applied at `Monkey.cs:34590` — `this.$self_$24681.EOxsb7GTOK.RPC_AddStatus("lavu", this.$sLv$24680, this.$mDuration$24678, 0, ...);`
  Duration Base `60`, Duration Wrapped `true`.
- **No `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists for**: `fireBall`, `phoenix`,
  `skyCrimson` (excluded above as contested), `blazingArrow`, `flashFire`, `ja`, `worldIgnition`
  (excluded above as contested), `instantBlaze`, `groundLock` (excluded above as contested), `gadina`,
  `planetBreaker`, `titanicEarthPulse`, `stoneHammer`, `buiten`, `earthGuard`, `volcanicEruption`,
  `summonGaos`, `summonAttack`, `summonDefense`, `unsummon`, `summonRelease` — confirmed by a full-file
  grep of every `RPC_AddStatus`/`.addStatus(` call in `Monkey.cs` (65 total hits) and cross-checking
  each against these skills' own coroutine bodies; the remaining hits belong either to the 12 support
  skills, to unrelated minigame/consumable-item effects (`wash`, `bless`, `ice`, `bubbleShield`,
  `iceShield`, `awareness`, `float`, `mpsap`, `paralysis`, `blind`, `plague`, `frost`,
  `whiteFlag`/`blueFlag`/`redFlag`/`yellowFlag`, `noDamage`, `happy`, `charm`, `needlePrison`, `heavy`,
  `mpDrain`, `hpDrain` — none tied to any `MonkeySkill.cs` roster entry), or to the excluded `noForce`
  side-effect (`titanicEarthPulse`'s cast, `Monkey.cs:32403`, flat `7`, anti-knockback grace period —
  same `noForce` pattern the Mole doc excluded from `kingKaiser`) and `fireKeep` charge-stack status
  (tied to the passive `fireKeep5`, which has no table row, `Monkey.cs:25735`/`25743`). Duration cells for the twenty
  skills listed above are `—`.
- **Confirmed-passive skills have no row in this table (no cooldown, `mode = eSkillMode.passive` in
  `getSkill()`, no `RPC_<name>` cast handler in `Monkey.cs`):** `statPlus1`-`4` and `superStatPlus5`
  (flat stat bonuses), `rapidFire1`-`3` (phoenix attack-speed/fireball-cost passive), `intenseFire1`-`3`
  (phoenix damage/burn-status passive), `fireRune1`-`3` (fire-summon sp/mp-on-hit passive),
  `titanSword1`-`3` (gadina sword-upgrade passive), `aegisOfEarth1`-`3` (gadina shield/groundLock-duration
  passive), `earthRune1`-`3` (earth-summon sp/mp-on-hit passive, see dedicated note above),
  `mikeBlink5`/`mikeCircle5` (charge-attack "Mike" upgrades), `autoInstant5` (instant-cast-chance
  passive), `fireKeep5` (fireball-hold passive), `fireSoul5`/`earthSoul5` (summon stat-scaling
  passives), `blazingFire5` (FireAvatar charge-attack unlock), `secondStone5` (groundLock/stoneHammer
  upgrade), `stoneSentinel5` (EarthForm charge/guard unlock), `revisedSkill5`/`revisedMagic5`/
  `revisedArt5` (flat sp/mp/cooldown-reduction modifiers for other skills). Also excluded:
  `mnk_damageCast1`/`2` (dead/unused entries, see dedicated note above) and `mnk_nAttack1`/
  `mnk_cAttack1`-`4` (blanket exclusion).

### CD citations
- `summonAttack` CD: `Monkey.cs:22321` — `this.$self_$24404.EOxsb7GTOK.addTimeOut("summonAttack", (float)3);`
- `summonDefense` CD: `Monkey.cs:22838` — `this.$self_$24416.EOxsb7GTOK.addTimeOut("summonDefense", (float)3);`
- `summonRelease` CD: `Monkey.cs:23826` — `this.$self_$24432.EOxsb7GTOK.addTimeOut("summonRelease", (float)3);`
- `unsummon` CD: `Monkey.cs:23449` — `this.$self_$24425.EOxsb7GTOK.addTimeOut("unSummon", (float)3);` (key literal is `"unSummon"`, capital S — see judgment-call note)
- `instantCast` CD: `Monkey.cs:10945` — `this.EOxsb7GTOK.addTimeOut("instantCast", this.EOxsb7GTOK.agiAdjust((float)240));`
- `fireBall` CD: `Monkey.cs:25153` — `this.$mTimeOut$24451 = 18 + this.$sLv$24473 * 3 - this.$mRapidFireLv$24453 * 3;` (base at max rank `sLv=4`, unpassived: `30`), applied via shared dispatcher at `Monkey.cs:25450`
- `phoenix` CD: `Monkey.cs:25189` — `this.$mTimeOut$24451 = 45;` (shared dispatcher, see note)
- `skyCrimson` CD: `Monkey.cs:27427` — `this.$self_$24504.EOxsb7GTOK.addTimeOut("skyCrimson", this.$self_$24504.EOxsb7GTOK.agiAdjust(120f));`
- `blazingArrow` CD: `Monkey.cs:27869` — `this.$self_$24512.EOxsb7GTOK.addTimeOut("blazingArrow", this.$self_$24512.EOxsb7GTOK.agiAdjust(120f));`
- `flashFire` CD: `Monkey.cs:28735` — `this.$self_$24542.EOxsb7GTOK.addTimeOut("flashFire", this.$self_$24542.EOxsb7GTOK.agiAdjust(60f));`
- `ja` CD: `Monkey.cs:25206` — `this.$mTimeOut$24451 = 90;` (shared dispatcher, see note)
- `runicFlame` CD: `Monkey.cs:29571` — `this.$self_$24557.EOxsb7GTOK.addTimeOut("runicFlame", this.$self_$24557.EOxsb7GTOK.agiAdjust(180f));`
- `worldIgnition` CD: `Monkey.cs:25223` — `this.$mTimeOut$24451 = 300;` (shared dispatcher, see note)
- `instantBlaze` CD: `Monkey.cs:37601` — `this.$self_$24755.EOxsb7GTOK.addTimeOut("instantBlaze", this.$self_$24755.EOxsb7GTOK.agiAdjust(30f));`
- `fireAvatar` CD: `Monkey.cs:25325` — `this.$mTimeOut$24451 = 600;` (shared dispatcher, see note; matches preemptive intent seen for `volcanicEruption`/`summonGaos`)
- `groundLock` CD: `Monkey.cs:25240` — `this.$mTimeOut$24451 = 18 + this.$sLv$24473 * 3;` (base at max rank `sLv=4`: `30`; shared dispatcher, see note)
- `gadina` CD: `Monkey.cs:25257` — `this.$mTimeOut$24451 = 45;` (shared dispatcher, see note)
- `planetBreaker` CD: `Monkey.cs:31888` — `this.$self_$24616.EOxsb7GTOK.addTimeOut("planetBreaker", this.$self_$24616.EOxsb7GTOK.agiAdjust(60f));`
- `titanicEarthPulse` CD: `Monkey.cs:32379` — `this.$self_$24626.EOxsb7GTOK.addTimeOut("titanicEarthPulse", this.$self_$24626.EOxsb7GTOK.agiAdjust(240f));`
- `stoneHammer` CD: `Monkey.cs:25274` — `this.$mTimeOut$24451 = 60;` (shared dispatcher, see note)
- `buiten` CD: `Monkey.cs:25291` — `this.$mTimeOut$24451 = 120;` (shared dispatcher, see note)
- `runicSand` CD: `Monkey.cs:34259` — `this.$self_$24672.EOxsb7GTOK.addTimeOut("runicSand", this.$self_$24672.EOxsb7GTOK.agiAdjust(180f));`
- `earthGuard` CD: `Monkey.cs:38056` — `this.$self_$24769.EOxsb7GTOK.addTimeOut("earthGuard", this.$self_$24769.EOxsb7GTOK.agiAdjust(60f));`
- `earthForm` CD: `Monkey.cs:25354` — `this.$mTimeOut$24451 = 600;` (shared dispatcher, see note)
- `lavu` CD: `Monkey.cs:25308` — `this.$mTimeOut$24451 = 600;` (shared dispatcher, see note)
- `volcanicEruption` CD: `Monkey.cs:25383` — `this.$mTimeOut$24451 = 240;` (shared dispatcher, see note; matches preemptive `Monkey.cs:86` — `this.EOxsb7GTOK.addTimeOut("volcanicEruption", this.EOxsb7GTOK.agiAdjust(240f));`)
- `summonGaos` CD: `Monkey.cs:25412` — `this.$mTimeOut$24451 = 300;` (shared dispatcher, see note; matches preemptive `Monkey.cs:89` — `this.EOxsb7GTOK.addTimeOut("summonGaos", this.EOxsb7GTOK.agiAdjust(300f));`)
- `summonSoul` CD: `Monkey.cs:24510` — `this.$self_$24444.EOxsb7GTOK.addTimeOut("summonSoul", (float)3);` (self, real player-facing cooldown; a second, unrelated `addTimeOut("summonSoul", (float)999)` at `Monkey.cs:24139` applies to the summoned companion object, not the caster — see judgment-call note)
- Shared dispatcher call site (applies `agiAdjust` to all thirteen `RPC_cast`-routed skills above): `Monkey.cs:25450` — `this.$self_$24474.EOxsb7GTOK.addTimeOut(this.$sType$24469, this.$self_$24474.EOxsb7GTOK.agiAdjust((float)this.$mTimeOut$24451));`

### Duration citations
- `instantCast` Duration: `Monkey.cs:10954` — `this.EOxsb7GTOK.RPC_AddStatus("instantCast", sLv, this.EOxsb7GTOK.chaAdjust(12), 0, this.EOxsb7GTOK.ActorNr);` (self, not target-contested)
- `fireAvatar` Duration: `Monkey.cs:38371` — `this.$self_$24776.EOxsb7GTOK.RPC_AddStatus("fireAvatar", 5, this.$self_$24776.EOxsb7GTOK.chaAdjust(120), 0, this.$self_$24776.EOxsb7GTOK.ActorNr);` (self-only transformation window)
- `earthForm` Duration: `Monkey.cs:40671` — `this.$self_$24822.EOxsb7GTOK.RPC_AddStatus("earthForm", 5, this.$self_$24822.EOxsb7GTOK.chaAdjust(120), 0, this.$self_$24822.EOxsb7GTOK.ActorNr);` (self-only transformation window)
- `lavu` Duration: `Monkey.cs:34579` — `this.$mDuration$24678 = this.$self_$24681.EOxsb7GTOK.chaAdjust(60);`, applied at `Monkey.cs:34590` — `this.$self_$24681.EOxsb7GTOK.RPC_AddStatus("lavu", this.$sLv$24680, this.$mDuration$24678, 0, this.$self_$24681.EOxsb7GTOK.ActorNr);`
- `summonSoul` Duration: `Monkey.cs:24195` (Phoenix1) through `24407` (Gaos) — every summon-type branch, e.g. `this.$tChar$24438.RPC_AddStatus("phoenixSoul", 1, 240, 0, this.$self_$24444.EOxsb7GTOK.ActorNr);` — bare literal `240` in all branches (`phoenixSoul`/`jaSoul`/`gadinaSoul`/`buitenSoul`/`gaosSoul`), applied to a friendly target, not contested
- `skyCrimson`, `worldIgnition`, `groundLock`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `runicFlame` Duration (trail-segment ground-lifetime, not the channel status): `Monkey.cs:12431,12436` — `int tID = this.EOxsb7GTOK.chaAdjust(5); this.RPC_runicFlame_fire(this.S3vsdQ4mPv.position, vector, tID);` → `Monkey_runicFlame.cs:20,27` — `Init(GameObject nOwner, CharacterControl nOwnerChar, int nLife)` sets `this.mLife = Time.time + (float)nLife;` — see the dedicated judgment-call note above.
- `runicSand` Duration (trail-segment ground-lifetime): `Monkey.cs:13697` — same pattern via `Monkey_runicSand.cs:20,27`.
- `fireBall`, `blazingArrow`, `flashFire`, `instantBlaze`, `planetBreaker`,
  `titanicEarthPulse`, `stoneHammer`, `earthGuard`, `volcanicEruption`,
  `summonAttack`, `summonDefense`, `unsummon`, `summonRelease`: no usable Duration — no
  `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists in the skill's own coroutine class body;
  see the bulk judgment-call note above. Duration cells are `—`.
- `phoenix`, `ja`, `gadina`, `buiten`, `summonGaos`: Duration cells are `∞` (confirmed no despawn timer
  — see the dedicated judgment-call note above), not `—`.

---

# Damage & Mechanics


Companion to `monkey-skill-reference.md` (Cooldown/Duration, cite that for CD/Duration citations — not re-derived here).
Consolidated ground-truth reference for Monkey skill damage formulas, status profiles, companion/summon scaling, and dependencies verified against `DecompiledSource/Monkey.cs`, `MonkeySkill.cs`, `Monkey_*.cs`, and `CharacterControl.cs`.

---

## 1. Active Skills Summary

| Skill | Max Rank | Cost (Base) | Base Damage / Formula | KO | Hit Count | Key Dependencies & Mechanics |
|---|---|---|---|---|---|---|
| **Combo** (`nAttack`) | 3 | — | `0.5×ATK` (all ranks) | 1 | 2 / 3 / 5 | R1: 2 hits, R2: 3 hits, R3: 3 hits + 3-way spread (5 hits total). Grants +1 SP per hit. |
| **HP Transfer** (`cAttack`) | 4 | [10, 15, 20, 25] HP | None (Utility) | 0 | 1 | Channels HP from Monkey into active summon pet. |
| **Damage Cast** (`damageCast`) | 4 | 50 SP (red) | Buffs next magic cast | 0 | 1 | Triggers Fire Rune check; consumes SP. |
| **Instant Cast** (`instantCast`) | 2 | [16, 24] MP, [16, 24] SP (red) | None (Buff) | 0 | — | Grants instant cast buff for duration. |
| **Fireball** (`fireBall`) | 4 | [9, 13, 17, 21] MP | `talAdjust(20 + 20×sLv)` | 0 | 1 | Single-target magic projectile. Gated by INT for cast time. |
| **Phoenix** (`phoenix`) | 4 | [30, 45, 60, 75] MP | Summon Entity | 0 | — | Spawns Phoenix companion. Uses own 9-stat array (`ownStatsPhoenix`). |
| **Phoenix - Fireball** | 1 | — | `talAdjust(20)` | 0 | 1 | Phoenix automated AI attack. Scales with Phoenix's own TAL; CD scales with Monkey's INT via `rapidFire`. |
| **Phoenix - SkyCrimson** | 1 | 35 MP, 30 SP (red) | `talAdjust(120)` | 5 | 1 | Commanded Phoenix AoE dive attack. |
| **Blazing Arrow** (`blazingArrow`) | 1 | 35 MP, 30 SP (red) | `talAdjust(120)` | 5 | 1 | Ground-target AoE pillar. |
| **Flash Fire** (`flashFire`) | 4 | [12, 16, 20, 24] MP, [12, 16, 20, 24] SP (red) | `talAdjust(15 + 15×sLv)` | 5 | 1 | Cone fire burst. |
| **Ja** (`ja`) | 4 | [15, 30, 45, 60] MP | `talAdjust(25×sLv)` | 0 | 1 | Spawns floating Ja entity. Detonates via command or on expiration. |
| **Ja - Detonate** | 1 | — | `talAdjust(25×sLv)` | 5 | 1 | Commanded manual explosion of Ja. |
| **Runic Flame** (`runicFlame`) | 1 | 30 MP, all SP | `talAdjust(24)` | 0 | Variable | Leaves flame trail while running. Duration = `floor(sp × 0.2)` sec. |
| **World Ignition** (`worldIgnition`) | 2 | [40, 50] MP, [30, 40] SP (red) | `talAdjust(80 + 40×sLv)` | 10 | 1 | Massive radial firestorm. Ignites all targets hit. |
| **Ground Lock** (`groundLock`) | 4 | [12, 16, 20, 24] MP | `talAdjust(25 + 25×sLv)` | 0 | 1 | Earth projectile rooting enemies in area. |
| **Gadina** (`gadina`) | 4 | [30, 45, 60, 75] MP | Main Summon | 0 | — | Spawns Gadina golem mount/companion (`ownStatsGadina`). Base HP/ATK/DEF scale with rank. |
| **Gadina - Normal Attack** | 1 | — | `1.0×Gadina ATK` | 2 | 1 | Automated Gadina melee slam. |
| **Gadina - Planet Breaker** | 1 | 40 MP, 60 SP (red) | Inner: `talAdjust(150)`<br>Outer: `talAdjust(50)` | 10 (Inner)<br>5 (Outer) | 1 | Gadina ground slam with two damage rings (Inner circle 4m, Outer ring 10m). |
| **Gadina - Titanic Earth Pulse** | 1 | 40 MP, 60 SP (red) | `0.35 × Gadina4 Current HP` | 10 | 5 | Sacrifices Gadina4. Gravity pulse expanding 1m to 5m over 5 ticks (max 1999/tick). |
| **Stone Hammer** (`stoneHammer`) | 4 | [12, 20, 28, 36] MP | `talAdjust(20 + 25×sLv)`<br>*(+30 with Stone Sentinel)* | 20 / 30 / 40 / 50<br>*(+10 with Sentinel)* | 1 | Cylinder AoE (radius `1 + 0.5×sLv` m, height 6m). Channel interruptible. |
| **Buiten Hou Hou** (`buiten`) | 4 | [20, 30, 40, 50] MP | Summon Totem | 0 | — | Deploys Buiten totem buffing allies / attacking nearby targets. |
| **Runic Sand** (`runicSand`) | 1 | 30 MP, all SP | `talAdjust(24)` | 0 | Variable | Earth-element trail counterpart to Runic Flame. |
| **Lavu** (`lavu`) | 2 | [35, 45] MP, [30, 40] SP (red) | `talAdjust(30 + 30×sLv)` | 0 | Continuous | Creates quicksand / lava hazard field slowing enemies. |
| **Volcanic Eruption** (`volcanicEruption`)| 1 | 50 MP, 50 SP (red) | `talAdjust(150)` | 10 | 6 | Erupts ground in 6 successive volcanic shocks. |
| **Summon Gaos** (`summonGaos`) | 1 | 100 MP, 50 SP (red) | Ultimate Summon | 0 | — | Deploys Gaos dragon summon (`ownStatsGaos`). |

---

## 2. Deep Mechanic Analyses & Source Citations

### 2.1 Ja own stats (`monkey_ja` / `monkey_ja_detonate`)

Ja's own stats are serialized in the live `12TailsOnline_Data/level16` `CharacterControl` records, rather than assigned by the readable Ja scripts. The correct record layout has `Lv`, `Skin`, and `Race`, then the eight-byte `mTargetAvartar` PPtr, followed by HP/resources and the eight combat stats: `CharacterControl.cs:29681-29738`. A previous decoder did not skip that PPtr, shifting every scalar after Race by two `int32` values; the four rank records below supersede those values.

| Ja rank | Serialized name / type | Byte offset | Current HP / MHP | ATK | DEF | AGI | VIT | MAG | CHA | TAL | LCK |
|---|---|---:|---:|---:|---:|---:|---:|---:|---:|---:|---:|
| 1 | Little Ja / `Ja1` | 438592 | 100 / 200 | 10 | 10 | 10 | 20 | 10 | 10 | 10 | 10 |
| 2 | Medium Ja / `Ja2` | 439408 | 200 / 400 | 20 | 20 | 20 | 20 | 20 | 20 | 20 | 20 |
| 3 | Big Ja / `Ja3` | 440224 | 300 / 600 | 30 | 30 | 30 | 60 | 30 | 30 | 30 | 30 |
| 4 | Giant Ja / `Ja4` | 441032 | 400 / 800 | 40 | 40 | 40 | 80 | 40 | 40 | 40 | 40 |

All four records have `Lv` 8/16/24/32 respectively, `Skin=0`, `Race=5`, PPtr `fileID=1, pathID=243`, and SP/MP/KO plus their maxima of 10/20/30/40. The app's Ja stat helper uses MHP 200/400/600/800; `Ja.cs` assigns current HP 100/200/300/400 when summoning, which is why current HP and MHP must not be conflated.

### 2.2 Gaos own stats (`monkey_summonGaos` and Gaos attacks)

Gaos's `resources.assets` `CharacterControl` record is at byte offset `44479000`; decoding after the
`mTargetAvartar` PPtr gives `MHP=24000, ATK=480, DEF=240, AGI=240, VIT=2400, MAG=120, CHA=120, TAL=120,
LCK=120`. `Gaos.cs:71` sets current/max HP to 24000 and `Gaos.cs:74` sets KO to 450, but it does not
overwrite any of those eight combat stats. These supersede the previous shifted-field mapping in the tool.

### 2.3 Gadina & Titanic Earth Pulse (`monkey_titanicEarthPulse`)
* **Source:** `Monkey.cs:33100–33250`, `Monkey_earthPulse.cs:1–150`.
* **Requirement:** Requires Gadina at Rank 4 (`gadinaLv == 4`). Consumes/sacrifices Gadina immediately upon cast.
* **Damage Mechanics:**
  - Base damage is **NOT** calculated from Monkey's own ATK/TAL.
  - Base formula: `nDamage = Mathf.Clamp(Mathf.FloorToInt(gadina.hp * 0.35f), 1, 1999)`.
  - Fires a straight-line gravity projectile (~15 m/s, ~45m max travel).
  - On first contact, creates an expanding pulse over 5 consecutive ticks with expanding hitboxes:
    - Tick 1: 1m radius
    - Tick 2: 2m radius
    - Tick 3: 3m radius
    - Tick 4: 4m radius
    - Tick 5: 5m radius (fixed 6m cylinder height).
  - Targets caught within 1m of the epicenter suffer all 5 damage ticks.

### 2.4 Stone Hammer (`monkey_stoneHammer`)
* **Source:** `Monkey.cs:33448–33492`, `MonkeySkill.cs:680–720`.
* **Targeting Geometry:** Ground-targeted cylinder AoE centered on landing zone:
  - Radius: `1.0 + 0.5 * sLv` meters (1.5m / 2.0m / 2.5m / 3.0m).
  - Height: 6.0 meters.
* **Base Damage & Scaling:**
  - Base formula: `talAdjust(20 + 25 * sLv)` (Ranks: 45 / 70 / 95 / 120).
  - **Stone Sentinel Capstone Synergy (`hasSkill(443)`):** Adds flat `+30` damage to the base formula across all ranks (75 / 100 / 125 / 150).
* **KO Knockout Pool:**
  - Base KO: `10 + 10 * sLv` (20 / 30 / 40 / 50).
  - **Stone Sentinel Capstone Synergy (`hasSkill(443)`):** Adds flat `+10` KO across all ranks (30 / 40 / 50 / 60).
* **Channeling Vulnerability:**
  - Carries a ~0.8s local animation channel after cast completion. Re-verifies `actionState == "attack"` and `myCommand == "stoneHammer"`. If interrupted (stunned, staggered, moved), cast aborts with 0 damage dealt.

### 2.5 Runic Flame & Fire Rune
* **Source:** `Monkey.cs:12229–12457`, `Monkey_runicFlame.cs:207`.
* **Duration Formula:** Consumes all banked player SP on cast:
  `duration = Mathf.FloorToInt(sp * 0.2f)` seconds.
* **Trail Segment Spawning:** While moving, drops a flame segment every 1.58 units.
  Segment lifetime is governed by caster CHA: `tID = chaAdjust(5f)`.
* **Damage:** `talAdjust(24)` per touch.
* **Fire Rune Passive Hook:**
  - Internal cooldown: 1.0s.
  - Proc roll: `Random(0, 100) < lckAdjust(12)`. At LCK 0, base chance is 12% (rises to ~21% at LCK 100).
  - Grants `4 * fireRuneLv` MP and `4 * fireRuneLv` SP on successful damage triggers.

---

## 3. Server Balance Variations (ToT & TTO)

### Complete skill-detail catalog

The existing Titanic Earth Pulse notes below are retained. This catalog is the complete private-server inventory from the Bible tool. BigBug is the baseline; these values are server-only observations maintained in `12t_projects/bible/index.html:9337-10461`, not decompiled behavior.

#### ToT — Fire branch

- **Instant Cast:** cooldown 240s → 180s; Rank 2 becomes unlimited instant casts during its 12s buff.
- **Fireball:** a hit reduces all A-branch cooldowns by 1s.
- **Phoenix:** cooldown 45s → 60s; can coexist with Gadina; hits reduce A-branch cooldowns by 1s; rebirth becomes guaranteed (100%, still 120s rebirth cooldown) instead of 12–30%.
- **Phoenix Fireball / Rapid Fire / Intense Fire:** Phoenix attack-speed INT scaling 20/30/40% → 40/60/80%; Intense Fire bonus 20/30/40% → 60/80/100% of Monkey `talAdjust(40)`.
- **Sky Crimson:** Intense Fire bonus becomes 60/80/100%; Fire Soul reduces cooldown to 12s.
- **Blazing Arrow:** red SP 48 → 45; Phoenix charges from the caster, can aim until fired, skips mount/skill animation, rebirth becomes 100%, and Fire Soul reduces cooldown to 60s.
- **Flash Fire:** base damage 16/24/32/40 → 8/16/24/32; radius 5m → 6.5m.
- **Ja:** resets Phoenix cooldown on cast.
- **Fire Rune:** proc chance 20% → 45/60/75%; SP/MP restoration 4/4, 8/8, 12/12 → 16/4, 22/6, 28/8.
- **Fire Keep:** maximum stored Fireballs 2 → 3.
- **Instant Blaze:** a 10s activation causes Phoenix Fireball impacts to deal AoE.
- **Fire Soul:** Phoenix stat inheritance 10/20/30/40% → 30/40/50/60%; Sky Crimson / Blazing Arrow cooldowns become 12s / 60s.
- **Fire Avatar:** all potions usable; replace time-charged large Fireball with one on every third normal attack.
- **Blazing Fire:** charge cooldown 6s → 2.5s; forward movement reduced 66%.

#### ToT — Earth, Gadina, and other branch changes

- **Ground Lock:** root 3s → 4s; damage 24/32/40/48 → 20/40/60/80; Second Stone adds 10 first-hit KO and +1s root.
- **Gadina:** cooldown 45s → 60s; Rank 4 KO 20 → 40; attacks 50% faster; can coexist with Phoenix; KO range is limited around Gadina.
- **Gadina normal attack / Titan Sword:** attack interval 4.0s/5.33s → 2.0s/2.67s; Titan Sword ATK 20/40/60 → 40/80/120 and KO 2/3/4 → 6/8/10.
- **Planet Breaker:** pull/damage range +25%; Earth Soul reduces cooldown to 12s.
- **Aegis of Earth:** Gadina DEF 20/35/50 → 30/55/80; Ground Lock duration extension removed.
- **Titanic Earth Pulse:** red SP 60 → 45; damage 35% → 28% Gadina4 HP; projectile speed 15 → 19.95 m/s; charge behavior gains the same warp/aim/no-animation treatment as Blazing Arrow.
- **Buiten Hou Hou:** resets Gadina cooldown on cast.
- **Earth Rune:** proc chance 20% → 45/60/75%; SP/MP restoration 4/4, 8/8, 12/12 → 16/4, 22/6, 28/8.
- **Lavu:** base damage 30/50 → 50/100; entry animation 50% faster; its buff reduces incoming damage 15/25%; cooldown and MP/SP costs reduced.
- **Mike Circle:** becomes a 3s-cooldown active retargetable ally-protection damage/heal command.
- **Summon Soul:** red SP 30 → 10; Gaos Soul +40 ATK/DEF → +40 ATK/AGI/TAL.
- **Auto Instant:** Instant Cast Lv.2 → Lv.4; grants 40% MP reduction, +40 ATK/DEF/VIT/TAL, 1% max HP/s healing, and two C-branch casts.
- **Earth Guard:** Gadina deals surrounding damage/KO for 10s, can move/attack, and cannot be healed.
- **Earth Soul:** Gadina stat inheritance 10/20/30/40% → 30/40/50/60%; Planet Breaker / Titanic Earth Pulse cooldowns become 12s / 60s.
- **Earth Form:** all potions usable; punch animation +20%; immune to physical knockback.
- **Stone Sentinel:** charge cooldown 6s → 5s.
- **Volcanic Eruption:** MP 150 → 100; enemies only; caster can move/use skills after 2s; requirement Fire Rune1/Earth Rune1 → Ja1/Buiten Hou Hou1.
- **Summon Gaos:** MP 300 → 150; no ally burn; Gaos Soul +40 ATK/DEF → +40 ATK/AGI/TAL.

#### TTO changes

- **Titanic Earth Pulse:** animation 4s → 2s; structure damage is 2×; pulse hitboxes 1/2/3/4m → 3/4/5/6m; projectile hitbox 0.25m² → 0.5m².
- **Fire Soul / Earth Soul:** each adds one summon slot.
- **Fire Avatar / Earth Form:** normal skill casting is allowed while transformed.

The BigBug-side skill formulas, status logic, and geometry remain documented in the preceding sections and the cited decompiled source. Server-only changes above should be revised in step with the Bible schema.

### Gadina - Titanic Earth Pulse
* **Tailstopia Online (TTO):**
  - Animation reduced from 4.0s to 2.0s.
  - Structure damage multiplier increased to `2.0×`.
  - Detonation hitboxes expanded to 3m / 4m / 5m / 6m.
* **Tales of Tail (ToT):**
  - SP cost reduced from 60 to 45 SP.
  - Projectile speed increased by +33% (15 m/s → 19.95 m/s).
  - Damage coefficient reduced by -20% (from 35% HP to 28% HP of Gadina4).
  - Gadina automatically warps to Monkey and tracks facing angle until fired.
