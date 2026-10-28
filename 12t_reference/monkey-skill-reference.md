# Monkey — Skill Cooldown/Duration Reference

> **Scope (2026-10-25):** this file documents the original BB client (`DecompiledSource/`); a citation without a tag is BB. ToT and TTO changes are live changes reported by the user and sit in the `## Server Balance Variations` sections. The Reborn client has its own file: [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) (Reborn citations are tagged `Reborn:`).

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
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
- **`mnk_damageCast1`/`mnk_damageCast2` (#102/#103) are a real 2-rank passive, not a castable skill
  (corrected 2026-10-02).** The `getSkill()` branch sets `setReq(...)` without assigning `mode`/`cType`
  (`MonkeySkill.cs:48-66`) because it is never cast. An earlier note here called it dead code after a
  grep for `RPC_damageCast`/`"damageCast"` found nothing; that grep missed `getDamageCastLv()`
  (`Monkey.cs:10820-10823`, `hasSkill(103) ? 2 : hasSkill(102) ? 1 : 0`), which is read by the HP Transfer
  channel (`:20986`), the shared spell-cast coroutine `RPC_cast` (`:25122`) and the Lavu `RPC_upheaval`
  command (`:35415`). Matches the eng tooltip "when he is charging or casting spell"
  (`MonkeySkill_eng.cs:48`, `59`). Mechanics in `# Damage & Mechanics` §1.
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
- **`fireBall`'s cooldown is conditionally halved by a separate passive (`hasSkill(402)` =
  `mnk_fireKeep5`, `MonkeySkill.cs:3231`; Rapid Fire is #221-#223, see §4.5a) when cast without a target lock — this table reports the un-passived base
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
  `mnk_damageCast1`/`2` (passive, no cooldown — see dedicated note above) and `mnk_nAttack1`/
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

### Monkey status effects (verified 2026-09-30, for the Bible status popups)

- **Souls** (`summonSoul`, 240 s, applied to the target): `phoenixSoul` ATK, `jaSoul` TAL, `gadinaSoul` DEF, `buitenSoul` VIT `+10 × sLv` (sLv 1-4 = summon form); `gaosSoul` sLv 5, `deltaAtk` and `deltaDef(8 × sLv)` = **+40 ATK / +40 DEF** (`CharacterControl.cs:38149-38289`, removal mirror `:17213-17257`). The ToT "+40 ATK/AGI/TAL" is a server change (see Server Balance below).
- **`buiten`** (Buiten statue aura, `Buiten.cs:183-289`): friends within `20 + 5 × lv` m (height `9 × rangeMod`) get `buiten` level lv for 5 s, refreshed while inside; sValue is `10 × lv` for the summoner only (0 for everyone else), applied as `deltaDef(sValue)` (`CharacterControl.cs:38048`). In `RPC_AddDamage`, a holder that is not itself a Buiten passes every `nDamage > 0` hit to the statue (`status.sID`) as `RPC_AddDamage(1, nDamage, 0, 0, …)` and takes 0 itself, while the statue has `hp > 0` (`:4925-4990`). KO is not redirected.
- **`instantCast`**: while it is active, a cast whose `canInstantCast` is true gets `castTime = 0`, and each such cast runs `reduceStatusLv("instantCast", 1)` (`Monkey.cs:25002-25062`), so the status level is the number of instant casts. Fire Avatar and Earth Form set `canInstantCast = false` (`:25336`, `:25365`). Without the status, skill #431 gives a `lckAdjust(12)` chance of the same instant cast (`:25008-25016`).
- **`runicFlame` / `runicSand`**: each removes the other on apply (`CharacterControl.cs:37847`, `:38059`). Trail segments act in `OnTriggerEnter`, once per target per segment: a flame segment does `hit(1, target, talAdjust(24), 0, 0)` (`Monkey_runicFlame.cs:207`); a sand segment applies `groundLock` lv 1 for `Damage.getDebuff(2, ownCha, targetCha)` only to a target without `groundLock` (`Monkey_runicSand.cs:215-225`).
- **`fireKeep`**: sValue = stored Fireballs; a non-targeted Fireball with #402 stores 1 (`chaAdjust(24)`) or, at the same level, 2 (`chaAdjust(30)`) (`Monkey.cs:25735-25743`); the next normal attack fires one and decrements, removing the status at 0 (`Monkey.cs:10039-10055`). The engine cap is **2**; the 3-stack cap is ToT-only (Server Balance below, user-confirmed 2026-09-30), and the Fire Keep card already shows 2 base / 3 under `servers.tot`. **Release replaces the normal attack (traced 2026-10-28):** out of a form, from standby / run, `getStatusLv("fireKeep") > 0` runs `RPC_fireKeep_cast` at the stored level before the `nAttack` timeout check and before the Mike Blink warp / Combo stage 1 choice (`Monkey.cs:10020-10064` vs `:10065-10150`). The Fire Avatar ball (`$RPC_phoenixArmor_nAttack`) gets Fire Keep's +20 (`Monkey_fireBall.cs:200`) but is never stored: only the `RPC_cast` fireBall branch stores (`Monkey.cs:25705-25748`).
- **`lavu`**: no effect in the apply switch (`CharacterControl.cs:38111`) and no reader anywhere; it only marks the `chaAdjust(60)` summon window (`Monkey.cs:34579-34594`). The 15/25% damage reduction is ToT-only (Server Balance below).
- **`ignite`**: `hitMod += 0.1 × sLv` (`:37899`). **`fireAvatar`**: `isSpecialForm`, `Race = Elementals`, `+100` AGI/TAL, removes `invisible` (`:38328`). **`earthForm`**: same but `+100` ATK/DEF (`:38443`).
- **Transformation immunities (verified 2026-10-14, all in `CharacterControl.cs`, nothing else outside `Monkey.cs` attack sets / item logic and `GameGui.cs` UI reads these statuses):** a Monkey with **`fireAvatar`** ignores the statuses **`burn`** (`RPC_AddStatus` :11376), **`snowMan`** (:11586) and **`snowBall`** (:11616), and takes **KO 0** from every hit (`RPC_AddDamage` :4697-4701 and `RPC_AddEffectDamage` :6178-6182: `if (Type == "Monkey" && hasStatus("fireAvatar")) nKo = 0`). A Monkey with **`earthForm`** ignores **`petrify`** (:11361) and takes **KO 0** the same way (:4709-4713, :6190-6194). Both forms also reject `invisible` (:11286, :11301). Fire Avatar is **not** protected from petrify and Earth Form is **not** protected from burn / snowMan / snowBall. Cards: Fire Avatar "ภูมิคุ้มกัน: Burn, Snowman, Snowball และ KO", Earth Form "ภูมิคุ้มกัน: Petrify และ KO" (ToT variant keeps its own wording of the KO immunity, "ไม่กระเด็นจากการโจมตีทางกายภาพทุกรูปแบบ"; the ToT server's own overrides were not checked, so Petrify there follows the BB code).


Companion to `monkey-skill-reference.md` (Cooldown/Duration, cite that for CD/Duration citations — not re-derived here).
Consolidated ground-truth reference for Monkey skill damage formulas, status profiles, companion/summon scaling, and dependencies verified against `DecompiledSource/Monkey.cs`, `MonkeySkill.cs`, `Monkey_*.cs`, and `CharacterControl.cs`.

---

## 1. Active Skills Summary (re-verified 2026-10-01)

Costs from `scripts/decode_skilldata.py DecompiledSource/MonkeySkill.cs` (negative SP = red / consumed); damage, KO and hit counts from the cited code. The earlier version of this table had wrong costs, damage or KO on most rows (e.g. Fireball MP, Flash Fire, World Ignition, Lavu, Volcanic Eruption, Summon Gaos). Server changes are in §3; summon commands and passives are in §4.

| Skill | Ranks | Cost (MP / SP) | Damage / effect | KO | Hits | Notes |
|---|---|---|---|---|---|---|
| **Combo** (`nAttack`, #101) | 1 | — | `(int)((0.5 + 0.1 Mike Blink) × ATK)` through `getCritPlus` (`floor(0.75 ×)` with `w_mnk59`) | 1 (+1 with Earth Form #433 learned, in the form or not: `Monkey.cs:19967-19983`, `:20586`; the Mike Blink strikes do not read it; +2 `w_mnk59`) | 2 | Two chained stages (`Monkey.cs:19962`, `:20576`); lock 1.5 s each. One learnable rank, not three. `w_mnk59` (Heavy Armor Mike, `WeaponData_eng.cs:4312`) floors 0.75 × the raw **and** adds KO +2 before `getCritPlus` (`:19984`, `:20598`; standard table, `Monkey.cs:19061`). Card: `MNK_COMBO_GEAR` (crit Mike ↔ Heavy Armor Mike exclusive, crit armor + hat). |
| **HP Transfer** (`cAttack`, #111-#114) | 4 | costs HP, not MP/SP: `2·lv − 1` HP per second (9 with Mike Circle) | heals the target `floor((1 + 0.02×ATK) × 2·lv)` per second (doubled when the target is the Monkey's own summon) | 0 | per second | Target within 30 m; needs HP above the cost and a target below max HP (`Monkey.cs:21084-21275`). |
| **Damage Cast** (`damageCast`, #102/#103) | 2 | passive | while channelling HP Transfer, every 0.4 s enemies within 2 m take `hit(2 + lv, getCritPlus((int)(0.25·lv·ATK)))` | 1 | per 0.4 s | Not a buff and costs nothing (`Monkey.cs:21299-21339`); the same hit also fires while casting any `RPC_cast` spell (`:25644`) and during the Lavu Upheaval command (`:35102`, there **without** `getCritPlus`). |
| **Instant Cast** (`instantCast`) | 2 | 25, 40 / −15, −20 | buff: casts become instant, one level spent per cast (§ status notes) | — | — | |
| **Fireball** (`fireBall`) | 4 | 9, 14, 19, 24 / 0 | `talAdjust(20 + 20·sLv (+20 Fire Keep))` (`Monkey_fireBall.cs:200`) | 1 | 1 | `hit(200 + lv)`; `burn` Lv = Intense Fire level, or Lv 5 once Fire Avatar #432 is learned (§4.6). |
| **Phoenix** (`phoenix`) | 4 | 25, 40, 55, 70 / 0 | summon | — | — | Own stats (`ownStatsPhoenix`). |
| **Phoenix - Fireball** | — | — | `Phoenix talAdjust(40) + floor((0.1·IF + 0.1) × Monkey talAdjust(40))` | 1 | 1 | Interval §4.5. |
| **Phoenix - Sky Crimson** (#224) | 1 | 0 / −36 | radius 5 m, height 3 m: same base as Phoenix's Fireball, `hit(1, num, KO 1)` (`Phoenix_skyCrimson_fire.cs:167-251`) | 1 | 1 | Monkey-side lock `agiAdjust(120)`; Phoenix's own `agiAdjust(60)` (`Monkey.cs:27427`, `Phoenix.cs:3899`). |
| **Blazing Arrow** (`blazingArrow`, #234) | 1 | 24 / −48 | 12 circles of radius 3.5 m (3 m apart along the line, `i < 12`), `hit(234, talAdjust(120))`; `burn` Lv 4 (`Monkey.cs:28161-28259`) | 0 | up to 12 | |
| **Flash Fire** (`flashFire`) | 4 | 24, 32, 40, 48 / −12, −16, −20, −24 | radius 5 m, height 3 m: `talAdjust(8 + 8·sLv (+10 Blazing Fire))` (`Monkey.cs:28593-28621`), fresh area scan each tick | 0 | `2·sLv` | Ticks 0.3 s apart while `i < sLv × 2` (`Monkey.cs:28718`, wait `:28854`); corrected 2026-10-03 from 1 hit. |
| **Ja** (`ja`) | 4 | 15, 30, 45, 60 / 0 | summon; explodes on command or expiry: `trunc(HP × (1 − 0.5 × distance/radius))` (§2.1) | `floor(0.1 × Ja HP)` | 1 | No `talAdjust` damage (the old `talAdjust(25×sLv)` was wrong). |
| **Runic Flame** (`runicFlame`) | 1 | 30 / all SP | `talAdjust(24)` per segment touched | 0 | variable | §2.5. |
| **World Ignition** (`worldIgnition`, #271/#272) | 2 | 40, 60 / −30, −35 | applies `ignite` Lv sLv (`getDebuff(60)`, `hitMod +0.1·sLv`) with a pool of `400 + 400·sLv`; when damage taken drains the pool, the target takes Effect Damage `400 + 400·sLv` (800 / 1200) (`Monkey.cs:29907`, `:30257`; `CharacterControl.cs:31074-31113`) | 0 | 1 | Single locked target; not a radial hit. |
| **Ground Lock** (`groundLock`) | 4 | 8, 12, 16, 20 / 0 | `talAdjust(12 + 8·sLv)`; `groundLock` Lv sLv (+2 Second Stone), contested `3 (+Aegis rank)` s | 1 | 1 | `Monkey.cs:30608-30625`. |
| **Gadina** (`gadina`) | 4 | 25, 45, 65, 85 / 0 | summon | — | — | Own stats (`ownStatsGadina`). |
| **Gadina - Normal Attack** | — | — | `(int)(0.5 × (Gadina ATK + floor((0.1·sword + 0.1) × Monkey ATK)))` | = sword rank | 1 / 2 / 3 / 3 | §4.8. |
| **Gadina - Planet Breaker** | 1 | 0 / −35 | 3 pulses: inner 5 m `Gadina ATK + sword share` (KO 10), outer 5-12 m flat 5 (KO 5) | 10 / 5 | 3 | §4.9. |
| **Gadina - Titanic Earth Pulse** | 1 | 40 / −60 | `clamp(floor(0.35 × Gadina4 HP), 1, 1999)` per tick | 10 | 5 | §2.3. |
| **Stone Hammer** (`stoneHammer`) | 4 | 12, 20, 28, 36 / 0 | `talAdjust(20 + 25·sLv (+30 Stone Sentinel))`, radius `1 + 0.5·sLv` m, height 6 m | `10 + 10·sLv` (+10) | 1 | `Monkey.cs:33453-33463`. |
| **Buiten Hou Hou** (`buiten`) | 4 | 24, 38, 52, 66 / 0 | summon: statue aura (status notes) | — | — | |
| **Runic Sand** (`runicSand`) | 1 | 30 / all SP | `groundLock` Lv 1 on touch (status notes) | — | variable | |
| **Lavu** (`lavu`) | 2 | 100, 150 / −75, −75 | summons the snake Lavu (`chaAdjust(60)` window); its attacks use Lavu's own ATK: `hit(1, ATK, KO 10)` and `hit(1, 0.5×ATK, KO 5)` (`Lavu.cs:805`, `:869`) | 10 / 5 | — | Not a "hazard field"; no `talAdjust` damage. |
| **Volcanic Eruption** (`volcanicEruption`) | 1 | 150 / −50 | `i < 22` iterations 0.5 s apart, each `hit(344, talAdjust(99))` to everything within 12 m (height 6) of the cast point (`Monkey.cs:43326-43861`) | 1 | up to 22 | |
| **Summon Gaos** (`summonGaos`) | 1 | 300 / −50 | summon (moves in §4.22) | — | — | |

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

#### Ja TAL aura vs. Ja Soul

* **Normal Ja is a status buff:** while Ja and its summoner are alive, Ja reapplies `[ja]` to the summoner every 3 seconds at Ja's summon rank, with a 4-second duration (`Ja.cs:250-286`). Applying `[ja]` calls `deltaTal(10*sLv)`, so Ja rank 4 gives the Monkey **+40 TAL** (`CharacterControl.cs:37836-37840`). It is not Ja's own serialized TAL stat.
* **Summon Soul is separate:** Summon Soul applies `[jaSoul]` to its friendly target for 240 seconds (`Monkey.cs:24241-24286`). `[jaSoul]` also calls `deltaTal(10*sLv)` (`CharacterControl.cs:38184-38188`), but normal Ja does not require Summon Soul to give its own `[ja]` aura.

#### Ja - Detonate

* Ja's explosion searches targets in a radius of `4 + 2×Ja rank` m and a height of 3 m (`Ja.cs:1561`).
* Per target, raw damage is `trunc(currentJaHP × (1 − 0.5 × distance / radius))`: it is 100% of Ja's **current** HP at the blast centre and 50% at the outer edge (`Ja.cs:1581`, `Ja.cs:1594`).
* KO is independently `floor(0.1 × currentJaHP)`, so it does not fall off with distance; Ja then self-destructs (`Ja.cs:1594`, `Ja.cs:1609`).

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

### 2.6 Volcanic Eruption: where the volcano appears (verified 2026-10-09)

- **Skill mode:** `mnk_volcanicEruption5` is `eSkillMode.target` / `eSkillTarget.enemy`, cType `volcanicEruption` (`MonkeySkill.cs:1548-1574`), so the cast needs a selected enemy.
- **Position (`Monkey.cs:24942-24978`):** when the cast starts, the centre `dQs7x5UeNh` is set to the selected target's `transform.position` (`:24954`), and the target reference and `tID` are then cleared (`:24959`, `:24964`). Only if there is no target object is the centre `caster position + forward × 20` (`:24972`). The centre is never updated afterwards, so the volcano stays where the target stood when casting began, even if the target walks away while it is being cast.
- **Ground-target gate (`Monkey.cs:8665-8725`, in the skill-use dispatcher, before the cast starts; found 2026-10-09 after the user reported the red warning):** with no target (`num == 0`) nothing is cast. With a target whose `Race` is not `Structure` and whose `recieveGravity` is false, the game shows the red message `"Can only used on ground target"` and calls `returnMPSP` (MP/SP refunded), no cast (`:8687-8703`). A `Structure` target skips the check, so it always works. `recieveGravity` is a per-unit flag (`CharacterControl.cs:29942`, true by default `:190`, read by `MovementUpdate` `:2637`): a unit with it false does not fall, i.e. is airborne. Code that clears it: the `DeathMount` / `MupoMount` leap moves (`DeathMount.cs:2159`, `MupoMount.cs:1801`, upward `vMovement` loops) and the `M906_ShadowGodZera1` boss script (`:1046`). Flying monsters most likely carry the flag in their serialized prefab data, which `DecompiledSource/` cannot show. So the gate is a flag test, not a height above ground in metres.
- **Cast itself (`$RPC_volcanicEruption_cast`, `:43326-43861`):** no further ground test. The volcano effect is created at the stored position with `Quaternion.identity` (`:43506`) and the hits use `FindAreaTarget(centre, 12, 6, 130816)` (`:43589`). The in-game Thai tooltip says "...รอบฟื้นที่เป้าหมาย (channel)" (`MonkeySkill_thai.cs:1104`; "ฟื้น" reads as a typo of "พื้น", the target's area).
- **Which units have `recieveGravity = false` (decoded 2026-10-09 from the serialized `CharacterControl` prefabs, every `12TailsOnline_Data` file, 327 distinct records; no script of these bosses writes the flag, only `DeathMount`, `MupoMount` and `M906_ShadowGodZera1` do):** after the six equipment strings the record continues with 7 `GameObject` + 2 object PPtrs (8 bytes each), `isPlayer` / `isControlled` / `isMine` (4 bytes each), `ActorNr`, `ownerName`, `ownerID`, `ownerGuild`, `actionState`, `actionTime`, `myCommand`, the movement / direction / force / position vectors, `mColor`, the 7 mods and `hpRegen` / `mpRegen`, then the ten `recieve*` bools as 4-byte words (`recieveTarget` … `recieveRevive`, `recieveGravity`) and `isChild`. Check: ordinary units (Carron, Coral Bug, Crystal Bug, Golden King Bug, Vizie King) read all ten as 1; the layout was accepted only for records where all ten words are 0 or 1.
  - **Targetable, flag false, not `Structure` → Volcanic Eruption refuses them (red message, MP / SP back):** Sky Bug head and tail (and Hi Sky Bug tail), Reef Bug body and head (and Hi Reef Bug), Mok Bug head / leg / tail, Ancient Bug head / both hands / body (and Hi Ancient Bug body), Nemesis Bug body and head (first form), Genesis Seed, Sting Nest, Ewiniar head / body / both tails, Earth Avatar base / body, King Rodinia, Foul Element, Lavu, Hammer Stone, Auto Gallon Gun.
  - **Flag false but allowed:** every `Structure`-race unit (Guard / Life / Frost / Victory towers, Mana Cores, War Gate / War Capital, King Column, Frost Crystal, Shadow Crystal, Target Practice dummies and so on): the gate skips them.
  - **Ground units, flag true, allowed:** Coral Bug, Hi Coral Bug, all Crystal Bug colours (normal and Hi), Golden King Bug (both), Nemesis Bug 2nd form (both), King Fuda Bug, King Kaiser, Pumpkon King, Vizie King.
  - **Not targetable at all (all `recieve*` 0 except hate):** the invisible controller records Sky Bug / Hi Sky Bug, Mok Bug / Mok Bug 2, Nemesis (first form and A), Ewiniar and Earth Avatar; the player always targets their parts instead.
  - Caveat: these are serialized prefab defaults. Nothing found in `DecompiledSource/` flips the flag for these bosses at runtime, so they hold unless a scene overrides them (the scan includes the level files, which showed the same values).
- The card says where the volcano appears (the chosen target's position when casting starts, not following it) and the ground-target rule with the red message.

## 4. Summon commands, passives and summon moves (verified 2026-10-01)

Requirements and costs from `scripts/decode_skilldata.py DecompiledSource/MonkeySkill.cs`; skill IDs from `MonkeySkill.cs`'s skill tree. Server deltas are in §3 below.

### 4.1 Summon Attack (`monkey_summonAttack`, #121)
- reqLv 6, reqBn 2; SP **−1** (red); target, enemy. Lock `addTimeOut("summonAttack", 3)`, flat (`Monkey.cs:22321`).
- `$RPC_summonAttack` (`Monkey.cs:22000-22330`) forwards `RPC_summonAttack(target)` to the active Phoenix, Gadina, Ja or Gaos, which clears its hate list and adds **1200** hate on the target (`Phoenix.cs:1890-1910`, `Gadina.cs:2082-2110`, `Ja.cs:1117-1137`, `Gaos.cs:1823-1851`). Buiten shows "Buiten try to attack but it has no arms!" and Lavu "Lavu can only attack by holding attack button" (`Monkey.cs:22162-22181`).
- Client tooltip: EN "Order Monkey's summon to attack the target." (`MonkeySkill_eng.cs:110`).

### 4.2 Summon Defense (`monkey_summonDefense`, #122)
- reqLv 12, reqBn 4; SP **−1** (red); instant, self. Lock `addTimeOut("summonDefense", 3)` (`Monkey.cs:22838`).
- Forwarded only to Phoenix, Gadina and Ja (`Monkey.cs:22641-22736`); there is no Gaos branch, Buiten shows "Buiten is trying its best!", Lavu "Lavu cannot defense" (`:22743-22766`). The summon, if standing or running, clears its hate list and sets its AI to `defense` (`Phoenix.cs:1941-1993`, `Gadina.cs:2162-2210`, `Ja.cs:1168-1220`).
- Client tooltip: EN "Order Monkey's summon to stop and return to him." (`MonkeySkill_eng.cs:121`).

### 4.3 Unsummon (`monkey_unsummon`, #123)
- reqLv 18, reqBn 6; SP **−10** (red); instant, self. Lock `addTimeOut("unSummon", 3)` (`Monkey.cs:23449`).
- `$RPC_unsummon` (`Monkey.cs:22987-23460`): Lavu returns `25 × Lavu level + 50` MP regardless of state (`:23130-23136`); any other summon returns MP only while its `hp > 0` (`:23149`): Phoenix 12 / 20 / 27 / 35, Ja 7 / 15 / 22 / 30, Gadina 13 / 23 / 33 / 43, Buiten 12 / 19 / 26 / 33, Gaos 75 (`:23166-23358`). Then the summon gets `SendMessage("unsummon")`.
- Client tooltip: EN "Recall Monkey's summon from the field, returning half of its mp summoning cost." (`MonkeySkill_eng.cs:132`).

### 4.4 Summon Release (`monkey_summonRelease`, #124)
- reqLv 24, reqBn 8; SP **−30** (red); instant, self. Lock `addTimeOut("summonRelease", 3)` (`Monkey.cs:23826`).
- Buiten and Lavu are simply unsummoned (no MP back). Phoenix, Gadina, Ja and Gaos get `summonRelease` (`Monkey.cs:23720-23743`): `isSummon = false`, layer and original layer **15**, and +1200 hate on the Monkey (`Phoenix.cs:2028-2056`, `Gadina.cs:2259-2295`, `Ja.cs:1244-1272`, `Gaos.cs:2002-2041`).
- Client tooltip: EN "Release Monkey's bond with his summon, making it a neutral enemy." (`MonkeySkill_eng.cs:143`).

### 4.5 Phoenix - Fireball (`monkey_phoenix_fireBall`, Phoenix's normal attack)
- Interval (`Phoenix.cs:2540-2582`): with Rapid Fire (#221-#223), `mag = clamp((0.1 × RF + 0.1) × Monkey MAG, 1, 512)` and `addTimeOut("nAttack", clamp(5 − mag / 32, 0.1, 5))` (integer division); without it 5 s. Monkey MAG is the summoner's `CharacterControl.mag` (`getStat(4)` + bonus, `CharacterControl.cs:1443`).
- **That timer is only a minimum: the AI cycle sets a floor of about 1.8 s with Rapid Fire 3 (traced 2026-10-16; live play saw "around 2 s, never 0.1 s").** The Phoenix's AI is a separate component, `Phoenix_AI.cs`, not `Phoenix.cs`. While alert it runs one cumulative-timer cycle each frame (`Phoenix_AI.cs:221-230`): `AI_selectTarget(1, 0)` → `AI_idle(1, 3 − RF)` → `AI_attack(10, 0)` → `AI_resetTimer()`. Each phase owns the window `[sum of earlier lengths, + its own length)` of `t = Time.time − T0` (`GFAtwULm1A` accumulates, `ztutLDwPy9` = T0).
  1. **The attack locks the Phoenix for 0.8 s.** `RPC_nAttack` sets `actionState = "attack"`, fires at `actionTime + 0.5` (`Phoenix.cs:2354`), then `Yield(3, WaitForSeconds(0.3))` (`:2634`) before `actionState = "standby"` (`:2301`). `AIControl` does nothing unless the state is `standby` or `run` (`Phoenix_AI.cs:101-114`), so the AI is frozen meanwhile.
  2. **Starting an attack jumps to the end of the cycle.** When the `nAttack` timer is ready, `AI_attack` sets `T0 = Time.time − 10 − 2` (`:1084`), i.e. `t = 12`. The first frame back in standby, `AI_resetTimer` sees `t > 12` and restarts the cycle at `t = 0` (`:1221-1228`).
  3. **Select target costs no time.** On entry it sets `T0 = Time.time − 1` (`:842`) and picks `getHateTarget(15, 40)`, so the same frame enters idle.
  4. **Idle lasts `1 − r` s, where `r = Random.Range(0, 3 − RF)`.** On entry it does `T0 −= r` (`:670`), which moves the cycle forward. A draw of 1 or more skips idle. **Rapid Fire 3 makes `r` always 0, so idle is always the full 1 s.** RF 2: `r` is in [0, 1), idle averages 0.5 s. RF 1: `r` is in [0, 2), idle is 0 half the time, 0.25 s on average.
  5. **Attack window `[2, 12)`:** fires the moment the `nAttack` timer is ready. Until then it backs off from targets closer than 5 m, otherwise it stands. Instant Blaze (#412, target < 5 m, its own timer) goes first.
  - **Interval between fireballs ≈ max(timer, 0.8 + idle) + about 3–5 frames** (reset frame, select / idle entry frame, plus rounding at each wait).

  | Rapid Fire | Timer reaches 0.1 s at | Timer at MAG 512 | Idle | Fastest real interval |
  |---|---|---|---|---|
  | 1 | MAG 800 (out of reach) | 2 s (mag 102) | 0–1 s, mean 0.25 s | about 2 s, set by the timer |
  | 2 | MAG 534 | 1 s (mag 153) | 0–1 s, mean 0.5 s | 0.8–1.8 s, mean about 1.3 s once MAG ≥ 534 |
  | 3 | MAG 400 | 0.1 s (mag 204) | always 1 s | **about 1.85 s, fixed** (0.8 + 1.0 + frames) |

  So with enough MAG, Rapid Fire 3 is slower on average than Rapid Fire 2: `3 − RF` shrinks the random idle skip as the level rises. It looks like a sign slip (`AI_idle(1, 3 − lv)` was probably meant to shorten the idle). It is the client code as shipped, so treat it as unintended behaviour, not a typo in this doc. Other entries into the cycle: `RPC_summonAttack` (Monkey's attack command) calls `AI_setTimer(3)` (`Phoenix.cs:1925`) → `t = 3`, straight into the attack window, so the first shot after a command skips select and idle.
- Hit (`Phoenix_fireBall.cs:189-290`): `num = Phoenix talAdjust(40)`; with Intense Fire `+ floor((0.1 × IF + 0.1) × Monkey talAdjust(40))`; `hit(1, t, num, KO 1, …)`; with Intense Fire, `burn` Lv IF for `getDebuff(4, Phoenix CHA, target CHA)`. A landed hit also calls the Monkey's Fire Rune (`:317`).

### 4.5a Rapid Fire (`monkey_rapidFire`, #221-#223)
- Passive, reqLv/Bn 7/2, 15/4, 23/6 (`decode_skilldata.py`). `getRapidFireLv()` returns 3 / 2 / 1 / 0 for #223 / #222 / #221 / none (`Monkey.cs:11763-11800`); the level is passed to Phoenix on summon (`Monkey.cs:11724`, `Phoenix.cs:4788`).
- **Phoenix attack speed:** see §4.5 interval — `mag = clamp((0.1 × lv + 0.1) × Monkey MAG, 1, 512)` = 20 / 30 / 40% of Monkey MAG (`Phoenix.cs:2562-2568`).
- **Monkey's Fireball:** cast time `4 + sLv − lv` and cooldown `18 + 3·sLv − 3·lv`, i.e. −1 / −2 / −3 s cast and **−3 / −6 / −9 s** cooldown (`Monkey.cs:25148`, `:25153`).
- Client tooltips: EN "Makes phoenix attack 20% [30 / 40%] faster (increases with Monkey's int.) Reduces fireballs' casting and cooldown by 1 [2 / 3] and 2 [4 / 6] seconds." (`MonkeySkill_eng.cs:308-340`). Code wins: cooldown −3 / −6 / −9, not −2 / −4 / −6.

### 4.6 Intense Fire (`monkey_intenseFire`, #231-#233)
- Passive, reqLv/Bn 9/3, 17/5, 25/7. Level passed to Phoenix on summon (`Monkey.cs:11729-11740`).
- Phoenix Fireball and Sky Crimson add `floor((0.1 × lv + 0.1) × Monkey talAdjust(40))` = 20 / 30 / 40% (`Phoenix_fireBall.cs:241`, `Phoenix_skyCrimson_fire.cs:219`); both Fireballs apply `burn` at level lv (Monkey's Fireball: `Monkey_fireBall.cs:203-255`; level 5 whenever Fire Avatar #432 is **learned**, `hasSkill(432)` at `:203-217`, not only in the form, so the cast Fireball and Fire Keep's released ball also apply `burn` 5, even with no Intense Fire; the old wording "level 5 in Fire Avatar" was corrected 2026-10-28), duration `getDebuff(4)`.
- Client tooltips: EN "Add 20% [30 / 40%] to phoenix damage (increases with Monkey's tal.) Also enables Monkey's and phoenix' fireball to inflict burn1 [2 / 3] status." (`MonkeySkill_eng.cs:352-374`). Matches.

### 4.7 Fire Rune (`monkey_fireRune`, #261-#263)
- Passive, reqLv/Bn 22/12, 28/16, 34/20.
- `FireRune()` (`Monkey.cs:12273-12320`, owner only): with level lv > 0, at most once per **1 s**, `Random.Range(0,100) < lckAdjust(12)` restores `4 × lv` MP and SP (`RPC_AddHeal(260 + lv, 0, 4lv, 4lv)`), "FireRune!". The 1 s lockout (`nRiHXQ83cT = Time.time + 1`) is set only after a successful roll, so a failed roll does not block the next one.
- **Every call site (all 18, re-traced 2026-10-26; replaces the shorter list here before):**
  - **Per landed hit** (inside `if (hit(...) != 0)`): Combo stages 1 and 2 (`$RPC_nAttack1` `Monkey.cs:20060`, `$RPC_nAttack2` `:20674`), Mike Blink strikes 1 and 2 (`$RPC_mikeBlink1` `:36086`, `$RPC_mikeBlink2` `:36692`), Damage Cast hits while channelling HP Transfer (`$RPC_cAttack1` `:21370`) and during Lavu's Upheaval (`$RPC_upheaval` `:35133`), Blazing Arrow (`$blazingArrow_fire` `:28199`), Flash Fire (`$RPC_flashFire` `:28632`), the Monkey's Fireball projectile (`Monkey_fireBall.cs:261`, so Fireball, Fire Keep's released shot and Fire Avatar's Fireball) and Phoenix's Fireball (`Phoenix_fireBall.cs:317`, the summoner's roll).
  - **Once at the end of the action, hit or miss** (in the closing `case` that checks `actionState == "attack"` and the command, then sets `standby`): the Fireball cast (`$RPC_fireBall_cast` `:26569`, command `fireBall`), Fire Keep's release (`$RPC_fireKeep_cast` `:37127`), the Fire Avatar transformation (`$RPC_phoenixArmor_cast` `:38557`) and each Fire Avatar normal attack (`$RPC_phoenixArmor_nAttack` `:38963`), the Earth Form transformation (`$RPC_gadinaArmor_cast` `:40817`) and each of the three Earth Form normal attacks (`$RPC_gadinaArmor_nAttack1-3` `:41299`, `:42007`, `:42530`). Earth Form's attacks roll **Fire** Rune, not Earth Rune.
  - **Not called:** the Damage Cast hit during a spell's cast bar (`$RPC_cast`, `Monkey.cs:25644`, only `sp + 1`), Instant Blaze, Sky Crimson and every other Phoenix move (`Phoenix.cs`, `Phoenix_skyCrimson_fire.cs` have no call), Ja, Gadina, Mike Circle, Blazing Fire's Blazing Form, World Ignition, Runic Flame, Volcanic Eruption and the earth skills. Reborn has the same 18 call sites (`Reborn:Monkey.cs:142` … `:7205`, `Reborn:Monkey_fireBall.cs:87`, `Reborn:Phoenix_fireBall.cs:97`; its Damage Cast hits `:564` HP Transfer and `:4888` Upheaval roll, `:1818` cast bar does not).
- Client tooltips: EN "Gives Monkey 20% chance to restore 4 [8 / 12] sp and 4 [8 / 12] mp everytime he or his fire summon deals damage to any target." (`MonkeySkill_eng.cs:484-506`). Code wins: base 12, LCK-scaled, 1 s lockout.

### 4.8 Gadina - Normal Attack (`monkey_gadina_nAttack`) and Titan Sword (`monkey_titanSword`, #321-#323)
- **Titan Sword:** passive, reqLv/Bn 7/2, 15/4, 23/6. On summon `EquipSword(rank)` adds **+20 / +35 / +50** to Gadina ATK (`Gadina.cs:544-601`); `getSwordLv()` returns the rank (0-3) (`:338-403`).
- **Gadina's attack** (`$RPC_nAttack1-4`, by Gadina form, `Gadina.cs:2540-4910`): 1 / 2 / 3 / 3 hits for forms 1-4, interval `agiAdjust(3 / 3 / 4 / 4)` on Gadina's AGI (`:2780`, `:3394`, `:4139`, `:4901`). Each hit `hit(1, t, (int)(0.5 × hitAtk), KO = sword rank, hate = same, …)` with `hitAtk = Gadina ATK + floor((0.1 × sword + 0.1) × Monkey ATK)` from sword rank 1 (`:2605-2665`).
- **Hit timing and steps (traced 2026-10-16, the reach playback uses them):** every hit is the same box; Gadina moves between hits. Form 1: wait 0.2 s, `moveSpeed 4` for 0.2 s, hit at **0.4 s** (`Gadina.cs:2563`, `:2642`, `:2816-2825`). Form 2: wait 0.5 s, `6` for 0.2 s, stop 0.1 s, `6` for 0.3 s; hits at **0.6 s / 1.0 s** (`:3010-3448`). Forms 3-4 (identical routines): wait 0.4 s, `6` for 0.3 s, stop 0.2 s, `6` for 0.3 s, stop 0.2 s, `−3` for 0.1 s; hits at **0.6 s / 1.1 s / 1.5 s**, Gadina 1.2 / 3.0 / 3.3 m from where it started (`:3643-4207`, `:4405-4964`).
- Client tooltips: EN "Upgrades Gadina's sword to lv.2 [3 / 4]. Gives +20 [40 / 60] atk and makes it deal 2 [3 / 4] ko." (`MonkeySkill_eng.cs:638-660`). Code wins: +20 / 35 / 50 ATK and KO 1 / 2 / 3.
- **Without Titan Sword (traced 2026-10-28):** the Monkey-ATK share is added only when `mSwordLv > Lv1` and the hit's KO is `getSwordLv()`, so a slash without Titan Sword has no Monkey ATK share and KO 0 (`Gadina.cs:2605-2628`, `:2665`).

### 4.9 Gadina - Planet Breaker (`monkey_planetBreaker`, #324)
- reqLv 31, reqBn 8; SP **−35** (red). Needs Gadina4 ("Planet Breaker can only be used with Gadina4", `Monkey.cs:31755-31761`). Gadina's `addTimeOut("planetBreaker", agiAdjust(60))` (`Gadina.cs:5802`).
- `$RPC_planetBreaker` (`Gadina.cs:5403-5885`): **3 pulses** (`i < 3`); each pulse, enemies in `FindAreaTarget(Gadina, 5 × rangeMod, 3 × rangeMod)` take `hit(11, t, Gadina ATK + Titan Sword share, KO 10, …)` pulled toward Gadina; enemies within 12 m but outside that circle take `hit(12, t, 5, KO 5, …)` with a stronger pull (`:5589-5698`).
- Client tooltip: EN "Command Forth form Gadina to use ultimate sowrd attack. Deal damage to adjacent area." (`MonkeySkill_eng.cs:671`).

### 4.10 Aegis of Earth (`monkey_aegisOfEarth`, #331-#333)
- Passive, reqLv/Bn 9/3, 17/5, 25/7.
  - Gadina DEF **+20 / +35 / +50** (`EquipShield`, `Gadina.cs:715-772`);
  - Gadina VIT `+floor((0.1 × rank + 0.1) × Monkey base VIT)` (`Gadina.cs:6154-6160`);
  - Ground Lock's contested base `3 → 3 + rank` s (`Monkey.cs:30608`).
- Client tooltips: EN "Upgrades Gadina's shield to lv.2 [3 / 4]. Gives +20 [40 / 60] def and increases Monkey's ground lock duration to 4 [5 / 6] seconds." (`MonkeySkill_eng.cs:682-704`). Code wins on DEF (20 / 35 / 50); the duration is the CHA-contested base.

### 4.11 Earth Rune (`monkey_earthRune`, #361-#363)
- Passive, reqLv/Bn 22/12, 28/16, 34/20. `EarthRune()` (`Monkey.cs:13539-13584`): same roll as Fire Rune (`lckAdjust(12)`, 1 s lockout, `4 × lv` MP and SP), but it runs from the owner's `Update` when the **Monkey takes damage** (`myDamage == −1`, `Monkey.cs:236-242`). No summon calls it.
- Client tooltips: EN "Gives Monkey a 20% chance to restore 4 [8 / 12] SP and 4 [8 / 12] MP everytime he or his earth summon gets hit." (`MonkeySkill_eng.cs:814-836`). Code wins: LCK-scaled 12 base, and only the Monkey's own hits taken.

### 4.12 Mike Blink (`monkey_mikeBlink`, #401)
- Passive, reqLv 55, reqBn 0.
  - Combo stages 1 and 2 and both blink strikes use `(int)((0.5 + 0.1) × ATK)` instead of `0.5 × ATK` (`Monkey.cs:19962`, `:20576`, `:36000`, `:36606`).
  - In real game modes, a normal attack on a locked enemy more than **12 m** away runs `RPC_mikeBlink1` instead of stage 1 (`Monkey.cs:10073-10139`). Blink strike 1 box `FindRecTarget(mPos + tDir − 3·hitDir, tDir, 1, 1, 4, 2)` (2 m × 4 m); strike 2 `FindAreaTarget(…, 1, 3)` (`:35995`, `:36601`).
- Client tooltip: EN "Enables Mike to attack enemy from a distance. Also increases its damage by 20%." (`MonkeySkill_eng.cs:880`). Matches (+0.1 ATK on 0.5).

### 4.13 Mike Circle (`monkey_mikeCircle`, #411)
- Passive, reqLv 60, reqBn 1. HP Transfer's charge level becomes **5** (`getChargeAttackLv`, `Monkey.cs:10827-10848`): the Monkey pays `2 × 5 − 1` = 9 HP per tick and the target heals `floor((1 + 0.02 × ATK) × 10)` (`:21084-21094`). Every 0.5 s while channelling, enemies in `FindAreaTarget(target, 3 × rangeMod, 2 × rangeMod)` take `hit(411, t, (int)(0.5 × ATK), KO 1, …)` (`:21383-21435`), with a Mike effect on the target.
- Client tooltip: EN "Increases HpTransfer to 8:10 hp and call out Mikes to circle around its target, dealing damage to nearby enemies." (`MonkeySkill_eng.cs:891`). Code: 9 HP cost.

### 4.14 Auto Instant (`monkey_autoInstant`, #431)
- Passive, reqLv 75, reqBn 4. In the cast routine (`Monkey.cs:25002-25062`): without `instantCast`, `Random.Range(0,100) < lckAdjust(12)` sets the cast time to 0. Fire Avatar, Earth Form, Volcanic Eruption and Summon Gaos have `canInstantCast = false` unless #431 is learned (`:25330-25423`), so only with it can `instantCast` or the proc skip their cast bars.
- Client tooltip: EN "Gives Monkey a 12% chance to instantly cast any spell. Also enables 'Instant Cast' to be used with any C skills." (`MonkeySkill_eng.cs:913`). Matches (LCK-scaled).
- **The four gated skills (re-traced 2026-10-28):** Fire Avatar (cast 9 s, `Monkey.cs:25314-25342`), Earth Form (9 s, `:25343-25371`), Volcanic Eruption (15 s, `:25372-25400`) and Summon Gaos (24 s, `:25401-25429`) are the only C skills with a cast bar. Without #431 neither `instantCast` nor the proc touches them, and no `instantCast` level is spent on them (`:24994-25064`).

### 4.15 Instant Blaze (`monkey_instantBlaze`, #412)
- reqLv 60, reqBn 1; MP 12; SP **−12** (red); instant. Needs Phoenix4 ("That skill need Phoenix4", `Monkey.cs:8376-8420`). Monkey lock `agiAdjust(30)` (`:37601`); a Phoenix4 summoned with #412 also gets skill 412 and uses the move by itself (`Monkey.cs:11669-11681`, `Phoenix_AI.cs:1057`), with its own `agiAdjust(30)` lock (`Phoenix.cs:3231`).
- `$RPC_instantBlaze` (`Phoenix.cs:2685-3170`): 4 waves; each hits `FindRecTarget(Phoenix − forward, forward, 2, 2, 3, 3)` (4 m wide, 3 m long from 1 m behind, 3 m high) with `hit(21, t, Phoenix talAdjust(80), KO 1)` and `burn` Lv 4 for `getDebuff(8, Phoenix CHA, target CHA)`; after the last wave Phoenix heals 200 HP.
- **Wave timing (traced 2026-10-16):** the Phoenix stands for 0.5 s (`:3275`), then dashes at `moveSpeed 12` (`:2826`) and hits once every 0.2 s while `i < 4` (`:3281`, `:3148`): waves at **0.7 / 0.9 / 1.1 / 1.3 s**, 2.4 / 4.8 / 7.2 / 9.6 m along the dash. Then `moveSpeed 6`, the 200 HP heal (`:3167`), 0.2 s, stop, 0.1 s, standby.
- Client tooltip: EN "Enables phoenix's new blazing attack. Activate this to use it instantly." (`MonkeySkill_eng.cs:946`).
- **Phoenix AI use (traced 2026-10-28):** a Phoenix created at level 4 while the Monkey has #412 gets skill 412 (`Monkey.cs:11669-11687`); its AI then uses Instant Blaze when the target (collider edge) is under 5 m and its own `instantBlaze` lock is free (`Phoenix_AI.cs:1034-1069`; lock `Phoenix.cs:3231`). ToT reworked Instant Blaze (§3); on ToT the cards describe the reworked skill only (decided 2026-10-28, §4.23 item 2).

### 4.16 Fire Soul (`monkey_fireSoul`, #422) and Earth Soul (`monkey_earthSoul`, #423)
- Passives, reqLv 70, reqBn 3. On summon, Phoenix (Fire Soul, `Phoenix.cs:4902-4953`) or Gadina (Earth Soul, `Gadina.cs:6171-6218`) adds `floor(0.1 × form × Monkey base stat)` to each of its 8 stats (form 1-4; Phoenix forms 5 / 6 use 5 / 6) and recomputes MHP as `10 × VIT`. The other `hasSkill` sites only draw the soul rings (`Monkey.cs:11365`, `:12588`, `:14375`).
- Client tooltips: EN "Passively adds 40% of Monkey's level to the summoned Phoenix [Gadina] basic stats." (`MonkeySkill_eng.cs:957`, `:1012`). Code wins: 10% per form level, of each Monkey base stat.

### 4.17 Fire Avatar - Fireball (`monkey_fireAvatar_fireBall`) and Blazing Fire (`monkey_blazingFire`, #442)
- **Fire Avatar Fireball** (`$RPC_phoenixArmor_nAttack`, `Monkey.cs:38728-39198`): level = 1, +1 for each of 3 / 6 / 9 s since the Monkey's last action (max 4), fired through `RPC_fireBall_fire`; the hit is the Monkey Fireball (`talAdjust(20 + 20 × lv (+20 Fire Keep))`, KO 1, `burn` Lv 5 for `getDebuff(4)`, Fire Rune). Lock `addTimeOut("nAttack", 1)`. The Lv 5 is the `hasSkill(432)` rule of §4.6, so it holds for every Monkey Fireball once Fire Avatar is learned.
- **Blazing Fire:** passive, reqLv 85, reqBn 6.
  - Flash Fire gets `+10` inside `talAdjust(8 + 8 × rank)` (`Monkey.cs:28598`).
  - Charging in Fire Avatar (needs #442, ≥ 6 MP and 6 SP, `:10208-10238`) runs Blazing Form (`Monkey.cs:39351-40035`): every 0.3 s it costs 3 SP / 3 MP (2 with Revised Skill / Revised Magic) and hits `FindRecTarget(pos − forward, forward, 2, 3, 3, 3)` (4 m → 6 m wide, 3 m long, 3 m high) with `hit(442, t, talAdjust(100), KO 0)`; `burn` Lv 4 for `getDebuff(8)` only on a target without `burn`. Release: `addTimeOut("blazingForm", 6)`.
- Client tooltip: EN "Enables FireAvartar to perform its charging attack. Also increases damage of all FlashFire spells." (`MonkeySkill_eng.cs:979`).

### 4.18 Second Stone (`monkey_secondStone`, #403)
- Passive, reqLv 55, reqBn 0. Ground Lock's `groundLock` level becomes rank **+ 2** (`Monkey.cs:30619`). 3 s after the Ground Lock hit, if the target still has `groundLock`, a stone strikes the hit point: `hit(403, t, talAdjust(48), KO 10)` on everything in `FindAreaTarget(hitPos, 0.5, 1)` (`$RPC_groundLock_hit`, `Monkey.cs:30858-31168`).
- Client tooltip: EN "Add 2 seconds to 'groundlock' duration and adds a second impact that deals 10 ko to it." (`MonkeySkill_eng.cs:990`). Code wins: +2 status levels, not +2 s.

### 4.19 Earth Guard (`monkey_earthGuard`, #413)
- reqLv 60, reqBn 1; MP 15; SP **−15** (red); instant. Needs Gadina4 (`Monkey.cs:8439`). Gadina's lock `agiAdjust(60)` (`Gadina.cs:5304`); a Gadina4 summoned with #413 also gets skill 413 and its AI can use it (`Monkey.cs:12892-12904`, `Gadina_AI.cs:1115`).
- With a locked target, the target gets `RPC_AddDamage(-1, 0, 0, 1000, …)` from Gadina: **+1000 hate**, no damage (`Monkey.cs:37919-37958`). Gadina (`$RPC_earthGuard`, `Gadina.cs:5028-5370`) stops (`moveSpeed 0`) in its guard pose and **6 times, 2 s apart**, heals `ceil(0.2 × (MHP − HP))` (skipped at full HP).
- Client tooltip: EN "Enables Gadina4 to guard and restore its hp. Activate this to use it instantly." (`MonkeySkill_eng.cs:1001`).
- **Gadina AI use (traced 2026-10-28):** a Gadina created at level 4 while the Monkey has #413 gets skill 413 (`Monkey.cs:12892-12910`); its AI uses Earth Guard when `hp < 0.25 × mhp` and its `earthGuard` lock is free (`Gadina_AI.cs:1092-1134`). The AI calls Gadina's `RPC_earthGuard` directly, so that use costs the Monkey no MP / SP and gives no +1000 hate: the hate is only on the Monkey's own cast path (`Monkey.cs:37958`, then Gadina's routine at `:37971`). ToT reworked Earth Guard (§3); on ToT the cards describe the reworked skill only (decided 2026-10-28, §4.23 item 2).

### 4.20 Earth Form - Normal Attack (`monkey_earthForm_nAttack`)
- `$RPC_gadinaArmor_nAttack1-3` (`Monkey.cs:40994-42595`), each with a flat `addTimeOut("nAttack", 1)`:
  - stage 1: two punches, each `FindAreaTarget(pos ± 0.5 right + 1.5 forward, 2, 3)`, `hit(1 / 4331, t, ATK, KO 5, hate ATK)`;
  - stage 2: two hits (`i < 2`) in `FindAreaTarget(pos, 4, 3)`, `hit(4332, t, ATK, KO 3)`;
  - stage 3: one hit in `FindAreaTarget(pos + 3 × forward, 3, 3)`, `hit(4333, t, 2 × ATK, KO 20)`.

### 4.21 Stone Sentinel (`monkey_stoneSentinel`, #443)
- Passive, reqLv 85, reqBn 6.
  - **Stone Hammer:** `+30` inside `talAdjust` and `+10` KO (`Monkey.cs:33458-33463`).
  - **Sentinel Guard:** charging in Earth Form needs #443 ("Require Stone Sentinal Skill"), ≥ 10 MP and 10 SP and no `sentinalGuard` lock (`Monkey.cs:10282-10327`). While held (`$RPC_gadinaArmor_sentinalGuard`, `:42635-43066`): every 3 s, MP −10 (−8 with Revised Magic #414) and `RPC_AddHeal(ceil(0.2 × MHP))`. While `myCommand == "sentinalGuard"`, direct hits are halved and KO is 0 (`CharacterControl.cs:4721-4738`). Release: `addTimeOut("sentinalGuard", 6)` (`Monkey.cs:42872`, `:43264`).
- Client tooltip: EN "Enables EarthForm to charge, reducing damage by half and gradually restoring its hp. Also adds 30 damage and 10 ko to StoneHammer" (`MonkeySkill_eng.cs:1034`). Matches.

### 4.22 Gaos moves (`monkey_gaos_nAttack1`, `monkey_gaos_nAttack2`, `monkey_gaos_tailSpin`, `monkey_gaos_fire`, `monkey_gaos_rampage`)
All use Gaos's own stats (§2.2). AI choice (`Gaos_AI.cs:840-1030`, `num` = distance to the target's collider edge):
- **Rampage:** `num > 9`, HP < 50% and `rampage` free.
- **Fire:** `num > 12` and `goasFire` free.
- **Tail Spin:** `num < 6` and `cAttack` free.
- **Normal attacks:** `num < 5` and `nAttack` free, 50/50 between I and II.

| Move | Area | Hit | Lock |
|---|---|---|---|
| Normal Attack I (`$RPC_nAttack1`) | `FindRecTarget(pos, fwd, 2, 3, 7, …)` = 4 → 6 m wide, 7 m long | `hit(1, ATK, KO 3)` | `nAttack` 3 s (`Gaos.cs:2318-2450`) |
| Normal Attack II (`$RPC_nAttack2`) | `FindAreaTarget(pos + (1.2 right, 2 forward), 5, 3)` | `hit(1, (int)(0.6 × ATK), KO 3)` | `nAttack` 3 s (`:2718-2833`) |
| Tail Spin (`$RPC_tailSpin`) | 4 waves, `FindAngleTarget(pos, dir, 6 + i, 120°, 4)` (6 → 9 m) | `hit(1, (int)(0.8 × ATK), KO 10)` per wave | `cAttack` 15 s (`:3183-3332`) |
| Fire (`$RPC_gaosFire`) | impact `FindAreaTarget(hitPos, 8, 4)` | `hit(1, talAdjust(140), KO 5)` | `goasFire` 9 s (`:1765-1785`, `:3700`) |
| Rampage (`$RPC_rampage`) | **14 hits**: first at 2.5 s (1.8 s + 0.2 s waits, then `mHitUpdate = now + 0.5`, `:4515`, `:4511`, `:4088`), then every 0.4 s while `actionTime + 8 > now` (`:4390`, `:4290`): 2.5 … 7.7 s; `FindAreaTarget(pos + 5 × fwd, 5, 3)` | `hit(31, ATK, KO 10)` | `rampage` 30 s (`:4400-4450`) |

### 4.23 Open questions & card mismatches (2026-10-01)

**Card mismatches** (cards in `index.html` vs the entries above):
1. ~~`monkey_blazingFire` `desc` Blazing Form box "2→3m"~~ → fixed to "กว้าง 4→6m" (4 → 6 m wide; `FindRecTarget` half-widths 2, 3) (2026-10-01).

**Doc corrections made in this pass:** §1 rows for Ground Lock (`talAdjust(12 + 8×sLv)`, KO 1) and Planet Breaker (see §4.9). The other §1 rows were not re-verified in this pass.

**Open questions:** none from this pass.

**Open questions from the dependency-line pass (2026-10-28):**
1. **Per-spell lines for cast-bar modifiers (wording call):** Instant Cast (`instantCast`, one level per cast), Auto Instant's `lckAdjust(12)` proc, Damage Cast's cast-bar hit (`hit(2 + lv, getCritPlus(0.25 × lv × ATK))`, KO 1, every 0.4 s, `Monkey.cs:25644`) and, on Reborn, Elemental Sovereign's instant cast reach all 13 cast-bar spells (Fireball, Phoenix, Ja, World Ignition, Ground Lock, Gadina, Stone Hammer, Buiten Hou Hou, Lavu, Fire Avatar, Earth Form, Volcanic Eruption, Summon Gaos; `Monkey.cs:25142-25429`, `:25002-25062`, `Reborn1027:Monkey.cs:1778-1796`). Fire Rune's 18 call sites (§4.7) and Fire Soul / Earth Soul on the summon move cards are the same case. Only the specific gates got lines (Auto Instant on the four C skills, Damage Cast on HP Transfer and Lavu, Sovereign's 14 refunds); does every such card get its own line, or do the modifier cards' lists stay the record? **Decided 2026-10-28:** the class-wide modifier rule applies to Instant Cast only. The nine spells whose `canInstantCast` stays true (`Monkey.cs:25132`; `Reborn1027:Monkey.cs:1598`) carry the Instant Cast toggle (`castDep2: MONKEY_INSTANT_CAST_DEP`, cast 0 while on) and one standard line, `MNK_INSTANT_CAST_LINE` (casts at once, no cast bar, uses 1 `instantCast` level: `Monkey.cs:24994-25062`, `reduceStatusLv` at `:25062`; `Reborn1027:Monkey.cs:1778-1796`). The four C skills carry the Auto Instant toggle (`MONKEY_AUTO_INSTANT_CAST_DEP`, cast 0 while on), which now reveals their existing Auto Instant line. No Damage Cast, Fire Rune or Fire Soul / Earth Soul lines, and no new related-skill links.
2. **ToT summon AI (live check):** ToT reworked Instant Blaze (a 10 s Phoenix buff) and Earth Guard (Gadina's 10 s aura). Does a ToT Phoenix4 / Gadina4 still use them by itself (BB: target under 5 m, Gadina HP under 25 %, `Phoenix_AI.cs:1034-1069`, `Gadina_AI.cs:1092-1132`)? The ToT Phoenix and Gadina tabs and the ToT Earth Guard tab have no AI line until then. **Decided 2026-10-28 (ToT rule, user 2026-10-28: the BB code applies on ToT / TTO unless a balance change overrides it, and then the balance change is trusted as written):** the ToT change notes rework both skills (Instant Blaze: a 10 s Phoenix buff that turns its fireball hits into area damage; Earth Guard: a 10 s Gadina aura of damage and KO while it moves and attacks, with no heals), so on ToT the cards describe the reworked skill only and carry no BB AI-use line. Checked on every ToT tab: the ToT Instant Blaze, Earth Guard, Phoenix and Gadina tabs name no AI use (the BB lines sit only on the BB, TTO and Reborn tabs), so no card changed.
3. **ToT Mike Circle on HP Transfer (live check):** ToT turned Mike Circle into a 3 s-cooldown active command, but HP Transfer has no ToT tab, so ToT still shows the BB line (charge level 5, 9 HP, heal base 10, `Monkey.cs:10827-10848`). Does the ToT Mike Circle still raise HP Transfer's charge level? **Decided 2026-10-28:** the Mike Circle line is the BB rule. HP Transfer got a ToT tab built from the base desc without that line (`descSwap`); the tab also drops the Mike Circle toggle and its charge level 5 (`dmgControls: []`, cost and heal from the rank), so ToT shows no BB Mike Circle effect anywhere on the card. The class file gives no ToT wording for HP Transfer, so no ToT line replaces it. Still not confirmed in game.
4. **ToT Auto Instant on Instant Cast and the C skills (wording call / live check):** ToT raises Instant Cast to level 4 with two C-skill casts (user-reported). The ToT tabs of Instant Cast, Fire Avatar, Earth Form, Volcanic Eruption and Summon Gaos got no Auto Instant line; what wording fits, and does a ToT Instant Cast rank 2 (unlimited casts for 12 s) still reach the four C skills? **Decided 2026-10-28:** the ToT Auto Instant card already gives the whole user-reported rule. The ToT Instant Cast tab now ends its rank-2 text (the note speaks of InstantCast2) with `**Auto Instant:**` [instantCast] at level 4, usable on C skills 2 times then gone, MP -40 %, ATK / DEF / VIT / TAL +40 and 1 % of max HP every 1 s, taken from the ToT Auto Instant change note only. The ToT tabs of the four C skills were left as they are (no Auto Instant line; their Auto Instant toggle still sets the cast to 0 there). Whether a ToT rank 2 Instant Cast without Auto Instant reaches the C skills stays open.
5. **TTO summon slots (live check):** Fire Soul and Earth Soul each add one summon slot on TTO (user-reported), but the Phoenix, Ja, Gadina and Buiten cards have no TTO tab, so their replace rules (Ja: "replaces Phoenix, Gadina or Ja") may be out of step there. Which summon replaces which on TTO, and should each summon card name Fire Soul / Earth Soul? **Decided 2026-10-28:** Phoenix, Ja, Gadina and Buiten got TTO tabs built from the base desc with one shared bullet, `MNK_TTO_SUMMON_SLOTS` (one summon at a time, Fire Soul and Earth Soul add one each, at most 3: the TTO Fire Soul / Earth Soul change notes, "Default 1 + Fire Soul 1 + Earth Soul 1"); on Ja it replaces the BB replace bullet, on the other three it follows the lead. No new related-skill links. Which summon a new one replaces when every slot is taken is not in the report, so no card states it (still a live check).
6. **BB form skill lock (wording call):** in Fire Avatar / Earth Form the BB skill dispatcher refuses every skill ("Cannot use skill with Phoenix Armor" / "Gadina Armor") and refunds MP / SP (`Monkey.cs:7511-7539`). The base cards never state this limit, while their TTO tabs say skills can be cast. Should the base cards get a `__limit__` line? (Not a modifier line, so it was left out.) **Decided 2026-10-28:** yes. Fire Avatar and Earth Form carry `MNK_FORM_SKILL_LOCK` (`• การร่ายสกิล: __ใช้สกิลไม่ได้ขณะอยู่ในร่างนี้ (คืน MP / SP)__`) after the stats bullet, the spot where their TTO tabs say skills can be cast. BB and ToT show it (no ToT report lifts the lock); Reborn keeps the refusal (see the Reborn section) and inherits the base line; TTO keeps its own bullet. Traced: the check sits in `doSkill` (`Monkey.cs:7366`), after the standby / run / emotion test, and refunds through `returnMPSP` (`Monkey.cs:9535`).
7. **ToT Earth Soul on Titanic Earth Pulse (applied 2026-10-28):** the ToT patch note reads "Cooldown สกิล PlanetBreaker (หรือ TitanicEarthPulse) ลดลงเหลือ 60 วิ". The ToT catalog (§3) and the ToT Earth Soul card read it as Titanic Earth Pulse 60 s, and the ToT Titanic Earth Pulse compat links Earth Soul, but its ToT desc has no line (Planet Breaker's has its 12 s line). If that reading is right, the line is `**Earth Soul:** คูลดาวน์เหลือ **60 วินาที**` after the ดาเมจ bullet. **Decided 2026-10-28 (ToT rule, as item 2):** applied as the class file (§3) and the ToT Earth Soul card read the balance change: the ToT Titanic Earth Pulse tab ends with `**Earth Soul:** คูลดาวน์เหลือ **60 วินาที**` after the ดาเมจ bullet. The two cards already linked each other on ToT. The card's cooldown chip still shows 240 s, since it has no Earth Soul cooldown toggle (Planet Breaker has one, `MONKEY_PLANETBREAKER_EARTHSOUL_CD_DEP`).

- **Bible (2026-10-28):** the cards now name the skills that change them: Fire Keep on the normal attack (fires a stored ball instead of the Combo or the Mike Blink warp) and on both Fireballs; Rapid Fire, Intense Fire and Fire Avatar (learned: burn 5 on every Fireball) on Fireball; Fire Avatar and Fire Keep mirror them; the Earth Form KO +1 (learned) and Auto Instant on Earth Form; Auto Instant on Fire Avatar, Volcanic Eruption, Summon Gaos and Instant Cast, and its own card names the four skills; Stone Sentinel on Stone Hammer; Titan Sword (KO only with it) on the Gadina slash; Damage Cast on HP Transfer and Lavu; Fire Soul and Instant Blaze (the Phoenix4 AI use) on Phoenix, Earth Guard (the Gadina4 AI use) on Gadina and the AI use on Earth Guard; Rapid Fire on Phoenix - Fireball; on ToT Ja on Phoenix and Buiten Hou Hou on Gadina; Runic Flame and Runic Sand link each other. Reborn: see the 2026-10-28 note in Server Balance Variations (Reborn).
- **[instantCast] popup (found 2026-10-28, not changed):** the Bible popup (`STATUS_DESC_MAP.instantcast`) says the status skips "Fire Avatar and Earth Form", but the code gates all four C skills with a cast bar (Volcanic Eruption and Summon Gaos too) and only without Auto Instant (`Monkey.cs:25314-25429`). Outside this pass's decisions, so the popup text is unchanged.
- **Bible (2026-10-28, open-decision pass):** the nine cast-bar spells (Fireball, Phoenix, Ja, World Ignition, Ground Lock, Gadina, Stone Hammer, Buiten Hou Hou, Lavu) have an Instant Cast toggle on the cast chip (cast 0 while on; Fireball keeps Rapid Fire too) and the standard **Instant Cast:** line on every server (on Reborn Buiten inside its สกิลเสริม topic); Fire Avatar, Earth Form, Volcanic Eruption and Summon Gaos have an Auto Instant toggle that reveals their Auto Instant line; Ja, Ground Lock and Lavu group their modifier lines under a สกิลเสริม topic (their ToT / Reborn texts pass about 500 characters); Fire Avatar and Earth Form state the form skill lock on BB, ToT and Reborn; ToT HP Transfer drops the BB Mike Circle line and toggle; the ToT Instant Cast rank 2 names the ToT Auto Instant rule; the TTO Phoenix, Ja, Gadina and Buiten give the TTO summon slots.

### Geometry notes (verified 2026-10-02)

- **Fireball (Monkey, Fire Avatar):** `Monkey_fireBall` sets `velocity = (0, 0, 30)` (`Monkey_fireBall.cs:26`, `:51`), no homing, and `RPC_fireBall_fire` gives `life = 2 × rangeMod` (`Monkey.cs:11278`): 30 m/s, 60 m.
- **Phoenix fireball:** same 30 m/s (`Phoenix_fireBall.cs:26`) and `life = 2 × rangeMod` (`Phoenix.cs:1661`, `:1822`). The AI fires whenever `nAttack` is off cooldown at its current target, at any distance (`Phoenix_AI.cs:1078-1100`).
- **Summon AI radii:** Phoenix, Ja and Gadina scan `Hate.findEnemies(pos, 24)` once a second and take a target within 12 m (`sqrMagnitude < 144`) (`Phoenix_AI.cs:1260`, `:1393`; `Ja_AI.cs:1208`, `:1341`; `Gadina_AI.cs:1365`, `:1498`).
- **Phoenix spawn burst:** `FindAreaTarget(Phoenix, 3 + 0.5 × summonLv, 3)` (`Phoenix.cs:5014`).
- **Runic Flame / Runic Sand:** checked every 0.2 s; a new segment drops once the Monkey is `sqrMagnitude ≥ 2.5` (≈ 1.58 m) from the previous one (`Monkey.cs:12413`, `:13679`); the segment's hit size is its prefab trigger collider.
- **Titanic Earth Pulse:** `$i` starts at 0 (`Monkey.cs:32840`), each tick hits `FindAreaTarget(hitPos, i + 1, 6)` (`:32710`) and loops while `i < 5` (`:32762`) with a 0.2 s wait: five rings of radius 1-5 m.
- **Summon commands** (Summon Defense, Unsummon, Summon Release) forward to the summon with no distance check (§4.2-4.4); Summon Soul has no gate, so 40 m target lock.

## Skill Tree Layout & Learn Requirements

Verified 2026-10-12 for the Skill Simulator (rules: [12Tails-Mechanics-Reference.md §3.6](12t_reference/12Tails-Mechanics-Reference.md#36-skill-learning-rules-class-skill-window-verified-2026-10-12)). Each cell is `name Lv/points`: required level / skills already learned in the same tree. Cell number = `tree*100 + row*10 + column` (trees 1-4 = Summoner, Pyromancer, Geomancer, Diablo). Source: `MonkeySkill.getSkill` (`setReq`, `rSkill`) and `MonkeySkill.getSkillTree`.

**Summoner** (tree 1)

| Row | Cells |
|---|---|
| 1 | N Attack 1/0 · Damage Cast 1 2/1 · Damage Cast 2 3/2 · — |
| 2 | C Attack 1 4/1 · C Attack 2 10/2 · C Attack 3 16/3 · C Attack 4 22/4 |
| 3 | Summon Attack 6/2 · Summon Defense 12/4 · Unsummon 18/6 · Summon Release 24/8 |
| 4 | Instant Cast 1 32/6 · Instant Cast 2 40/10 · — · — |
| 5 | Stat Plus 1 10/4 · Stat Plus 2 20/6 · Stat Plus 3 30/8 · Stat Plus 4 40/10 |

**Pyromancer** (tree 2)

| Row | Cells |
|---|---|
| 1 | Fire Ball 1 3/0 · Fire Ball 2 11/1 · Fire Ball 3 19/2 · Fire Ball 4 27/3 |
| 2 | Phoenix 1 5/1 · Phoenix 2 13/3 · Phoenix 3 21/5 · Phoenix 4 29/7 |
| 3 | Rapid Fire 1 7/2 · Rapid Fire 2 15/4 · Rapid Fire 3 23/6 · Sky Crimson 31/8 |
| 4 | Intense Fire 1 9/3 · Intense Fire 2 17/5 · Intense Fire 3 25/7 · Blazing Arrow 33/9 |
| 5 | Flash Fire 1 12/4 · Flash Fire 2 20/8 · Flash Fire 3 28/12 · Flash Fire 4 36/16 |
| 6 | Ja 1 17/6 · Ja 2 24/10 · Ja 3 31/14 · Ja 4 38/18 |
| 7 | Fire Rune 1 22/12 · Fire Rune 2 28/16 · Fire Rune 3 34/20 · Runic Flame 40/24 |
| 8 | World Ignition 1 35/23 · World Ignition 2 40/25 · — · — |

**Geomancer** (tree 3)

| Row | Cells |
|---|---|
| 1 | Ground Lock 1 3/0 · Ground Lock 2 11/1 · Ground Lock 3 19/2 · Ground Lock 4 27/3 |
| 2 | Gadina 1 5/1 · Gadina 2 13/3 · Gadina 3 21/5 · Gadina 4 29/7 |
| 3 | Titan Sword 1 7/2 · Titan Sword 2 15/4 · Titan Sword 3 23/6 · Planet Breaker 31/8 |
| 4 | Aegis Of Earth 1 9/3 · Aegis Of Earth 2 17/5 · Aegis Of Earth 3 25/7 · Titanic Earth Pulse 33/9 |
| 5 | Stone Hammer 1 12/4 · Stone Hammer 2 20/8 · Stone Hammer 3 28/12 · Stone Hammer 4 36/16 |
| 6 | Buiten Hou Hou 1 17/6 · Buiten Hou Hou 2 24/10 · Buiten Hou Hou 3 31/14 · Buiten Hou Hou 4 38/18 |
| 7 | Earth Rune 1 22/12 · Earth Rune 2 28/16 · Earth Rune 3 34/20 · Runic Sand 40/24 |
| 8 | Lavu 1 35/23 · Lavu 2 40/25 · — · — |

**Diablo** (tree 4)

| Row | Cells |
|---|---|
| 1 | Mike Blink 55/0 (needs Damage Cast 2) · Fire Keep 55/0 (needs Fire Ball 4) · Second Stone 55/0 (needs Ground Lock 4) · Revised Skill 55/0 |
| 2 | Mike Circle 60/1 (needs C Attack 4) · Instant Blaze 60/1 (needs Phoenix 4) · Earth Guard 60/1 (needs Gadina 4) · Revised Magic 60/1 |
| 3 | Summon Soul 70/3 (needs Summon Release) · Fire Soul 70/3 (needs Sky Crimson) · Earth Soul 70/3 (needs Planet Breaker) · Revised Art 70/3 |
| 4 | Auto Instant 75/4 (needs Instant Cast 2) · Fire Avatar 75/4 (needs Blazing Arrow) · Earth Form 75/4 (needs Titanic Earth Pulse) · Volcanic Eruption 75/4 (needs Fire Rune 1 + Earth Rune 1) |
| 5 | Super Stat Plus 85/6 (needs Stat Plus 4) · Blazing Fire 85/6 (needs Flash Fire 4) · Stone Sentinel 85/6 (needs Stone Hammer 4) · Summon Gaos 85/6 (needs Volcanic Eruption) |

- **Class C prerequisites** (`rSkill`, each is a single skill from the trees above or from Class C itself): Mike Blink needs Damage Cast 2; Fire Keep needs Fire Ball 4; Second Stone needs Ground Lock 4; Mike Circle needs C Attack 4; Instant Blaze needs Phoenix 4; Earth Guard needs Gadina 4; Summon Soul needs Summon Release; Fire Soul needs Sky Crimson; Earth Soul needs Planet Breaker; Auto Instant needs Instant Cast 2; Fire Avatar needs Blazing Arrow; Earth Form needs Titanic Earth Pulse; Volcanic Eruption needs Fire Rune 1 + Earth Rune 1; Super Stat Plus needs Stat Plus 4; Blazing Fire needs Flash Fire 4; Stone Sentinel needs Stone Hammer 4; Summon Gaos needs Volcanic Eruption.
- **Checked against the 2014 community simulator** (Rain Niar's Monkey SkillSimulator V.3) **and TailsTailsSimulator.online/monkey**: 97 of 97 cells have the same Lv / points in all three.
- The blog's simulator caps at Lv 95, the site at Lv 100 (its extra Class C row is ignored: there are no EX skills). Tree names come from the site.

---

## 3. Server Balance Variations (ToT)

### Complete skill-detail catalog (ToT)

The existing Titanic Earth Pulse notes below are retained. This catalog is the complete private-server inventory from the Bible tool. BigBug is the baseline; these values are server-only observations maintained in `12t_projects/bible/index.html:9337-10461`, not decompiled behavior.

#### ToT — Fire branch

- **Instant Cast:** cooldown 240s → 180s; Rank 2 becomes unlimited instant casts during its 12s buff.
- **Fireball:** a hit reduces all A-branch cooldowns by 1s.
- **Phoenix:** cooldown 45s → 60s; can coexist with Gadina; hits reduce A-branch cooldowns by 1s; rebirth becomes guaranteed (100%, still 120s rebirth cooldown) instead of 12–30%.
- **Phoenix Fireball / Rapid Fire / Intense Fire:** Phoenix attack-speed INT scaling 20/30/40% → 40/60/80%; Intense Fire bonus 20/30/40% → 60/80/100% of Monkey `talAdjust(40)`.
- **Sky Crimson:** Intense Fire bonus becomes 60/80/100%; Fire Soul reduces cooldown to 12s.
- **Blazing Arrow:** red SP 48 → 45; Phoenix charges from the caster, can aim until fired, skips mount/skill animation, rebirth becomes 100%, and Fire Soul reduces cooldown to 60s.
- **Flash Fire:** base damage 16/24/32/40 → 8/16/24/32; radius 5m → 6.5m (`5×rangeMod` → `6.5×rangeMod`). Height assumed unchanged at `3×rangeMod` (user 2026-10-07: "likely unchanged", not confirmed in game).
- **Ja:** resets Phoenix cooldown on cast.
- **Fire Rune:** proc base chance 12% (`lckAdjust(12)`; the tooltip says 20%) → 45/60/75%; SP/MP restoration 4/4, 8/8, 12/12 → 16/4, 22/6, 28/8.
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
- **Earth Rune:** proc base chance 12% (`lckAdjust(12)`; the tooltip says 20%) → 45/60/75%; SP/MP restoration 4/4, 8/8, 12/12 → 16/4, 22/6, 28/8.
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

### Gadina - Titanic Earth Pulse (ToT)
* **Tales of Tail (ToT):**
  - SP cost reduced from 60 to 45 SP.
  - Projectile speed increased by +33% (15 m/s → 19.95 m/s).
  - Damage coefficient reduced by -20% (from 35% HP to 28% HP of Gadina4).
  - Gadina automatically warps to Monkey and tracks facing angle until fired.

## 3b. Server Balance Variations (TTO)

### Complete skill-detail catalog (TTO)

- **Titanic Earth Pulse:** animation 4s → 2s; structure damage is 2×; pulse hitboxes 1/2/3/4/5m → 3/4/5/6/7m (5th wave 7m: user 2026-10-07, the patch note listed only 4); projectile hitbox 0.25m² → 0.5m².
- **Fire Soul / Earth Soul:** each adds one summon slot.
- **Fire Avatar / Earth Form:** normal skill casting is allowed while transformed.

The BigBug-side skill formulas, status logic, and geometry remain documented in the preceding sections and the cited decompiled source. Server-only changes above should be revised in step with the Bible schema.

### Gadina - Titanic Earth Pulse (TTO)
* **Tailstopia Online (TTO):**
  - Animation reduced from 4.0s to 2.0s.
  - Structure damage multiplier increased to `2.0×`.
  - Detonation hitboxes expanded to 3m / 4m / 5m / 6m.

## Thai tooltip mismatches (scan 2026-10-27)

Every number in the BB Thai tooltip (`MonkeySkill_thai.cs`) was compared with the app card, then each suspect with the code. Each row is a card `tooltipNote`.

| Skill | Thai tooltip says | Code says | Source |
|---|---|---|---|
| World Ignition (level 2) | +10% damage taken | `hitMod += 0.1 × sLv` = **+20%** | `CharacterControl.cs:37903`; `Monkey.cs:29907` |
| Ground Lock | 24 / 32 / 40 / 48 dmg | `talAdjust(8×sLv + 12)` = **20 / 28 / 36 / 44** | `Monkey.cs:30625` |

## Server Balance Variations (Reborn)

Reborn client (`DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/`), verified 2026-10-26. Citation tags as in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md): `Reborn:X.cs:N` = that build, `BB:X.cs:N` = `DecompiledSource/`. Cards: `servers.reborn`. Summon Soul (party-wide, Gaos Soul +20 all stats; already on the card) is in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §7.3. Neither change below is in the in-game tooltips.

- **Buiten Hou Hou: the statue drops Stone Hammers (Buff):** on the owner's client `RPC_buiten_create` starts `RebornBuitenTurretLoop` (`Reborn:Monkey.cs:15624-15627`). Every 5 s, while that statue is the current summon and alive, it takes the nearest unit with HP > 0 that is not `Robots` / `Structure` in `FindAreaTarget(statue, 12, 6, enemy layers)` (`RebornC6.Area`, `Reborn:RebornC6.cs:871-890`) and runs `RPC_stoneHammer_fire` there with sLv = the Buiten level (`Reborn:Monkey.cs:15632-15680`). That is the unchanged Stone Hammer drop: lands after 1 s, `FindAreaTarget(spot, 1 + 0.5·Lv, 6)`, `talAdjust(25·Lv + 20, +30 with Stone Sentinel 443)`, KO `10·Lv + 10` (+10 with 443), `hit(340 + Lv)` (`Reborn:Monkey.cs:4297-4346` = `BB:Monkey.cs:33312-33608`). No MP / SP, no cooldown set, Stone Hammer need not be learned. BB has no such loop: the only callers of `RPC_stoneHammer_fire` are Stone Hammer's own cast (`BB:Monkey.cs:6277-6331`) and the network relay (`:3372-3408`). Card: Reborn desc, changeNote, `reach` (+ the 12 m search and the hammer circle) and a Reborn-only Stone Hammer link.
- **Summon Gaos: ride and control Gaos (Buff):** the owner's Gaos gets `RebornGaosMerge` (`Reborn:Monkey.cs:16089-16092`). Clicking it (`OnMouseDown`, once per summon, Gaos HP > 0) makes Gaos a controlled player unit with `mount` 9999, gives the Monkey `hide` 9999 and switches `Game.mPlayer` and the camera to Gaos (`Reborn:RebornGaosMerge.cs:38-80`). `RebornGaosMergeLink` keeps the Monkey on Gaos and ejects it after 180 s or when Gaos dies or disappears, Gaos back to summon AI, Monkey HP at least 1 (`Reborn:RebornGaosMergeLink.cs:16`, `:26`, `:30-95`). While controlled, Gaos AI is off (`Reborn:Gaos_AI.cs:36`); normal attack = random Normal Attack I / II, charge = Rampage if Gaos SP > 50 and off cooldown, else Tail Spin if the target point is within 12 m (`sqrMagnitude <= 144`, its cooldown permitting), else Gaos Fire (`Reborn:Gaos.cs:1506-1603`). `hide` blocks white and purple damage (`Reborn:CharacterControl.cs:7107`, `:7991`, `:8004`). BB's Gaos is AI only (`isControlled = false`, `BB:Monkey.cs:14509`). Card: Reborn desc and changeNote.
- **Gear crit (Adjust; `monkey_nAttack`):** BB `getCritPlus` rolls `lckAdjust(gear sum)` (`BB:Monkey.cs:19061`). Reborn adds `RebornBalance.TrinketCritPlus` (+3 for `t_all61`-`63`) and the seal `critical` (`RebornEffects.CritPlus`, server data, not modelled) and rolls `lckItemAdjust(sum)` = `ceil(1.3 × sum)` with no LCK (`Reborn:Monkey.cs:17534`, belt `:17564`, roll `:17566`). Damage Cast and Mike Blink call the same function, but their cards have no crit model. In the app: the shared Reborn rule (`critChance`, `procChance`, `itemChance`) and the belt toggle `REBORN_BELT_DEP`; [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §2.2, §2.4.

### Review corrections (2026-10-26)

- `[gaosSoul]` on Reborn = +20 to all 8 stats (`Reborn:CharacterControl.cs:3096-3105`; BB ATK / DEF `+8 × sLv`): Reborn popup.
- Ja Detonate with Ja Overdrive at full HP: KO `floor(0.1 × 1600)` = 160 is capped at 99 by `koAdjust`; Elemental Sovereign's slam KO 100 → 99 too. Sovereign's Combo hit-2 splash is a new `hit()` (dmgAdjust and each target's DEF again, `Reborn:RebornC7Passive.cs:682`).
- Buiten with Soul Pact: the turret runs only while the statue is the current summon (`Reborn:Monkey.cs:15635-15638`), so summoning Phoenix / Ja after it stops the hammer drops for good; the `[buiten]` aura stays.
- Runic Inferno's ×1.3 also lands on Mike Circle, Mike Blink, Second Stone and the Buiten turret hammers (`Reborn:Monkey.cs:588`, `:5192`, `:3578`, `:4340`): desc line and link on each (no damage model there).
- `[runicflame]` popup: no code names (all servers); Reborn adds the fixed 15 s with Runic Inferno.
- Soul Pact: Summon Attack / Defense and the Phoenix4 / Gadina4 skills (Blazing Arrow, Fire Avatar, Planet Breaker, Titanic Earth Pulse, Earth Guard, Earth Form) act on the latest summon only (`Reborn:Monkey.cs:13556-13608`, `:13665-13925`): a Reborn line and a Soul Pact link on each.

### C6 / C7 skills (Reborn only)

Verified 2026-10-26 in `DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/` (string helpers decoded with the Reborn string table). Skill data: every C6 / C7 row is one rank (`mnk_*5`), C6 `setReq(95, 8)`, C7 `setReq(105, 8)`, prerequisites 451 = 401 + 411, 452 = 254, 453 = 354, 454 = 444, 461 = 124 + 421, 462 = 264, 463 = 364, 464 = 454 (`Reborn:MonkeySkill.cs:435-480`, tree slots `:1031-1068`). No Thai names in the client. Cards are `onlyServer: "reborn"`; dep toggles on the original cards live in their `servers.reborn` (`REBORN_MNK_*_DEP`).

- **Soul Link (`monkey_soulLink`, 451, passive):** `RebornC6Passive.OnTakeDamage`: a Monkey with 451 whose `actionState == "attack"` takes KO 0 from a hit with damage > 0 (`Reborn:RebornC6Passive.cs:278-293`), called only from `RPC_AddDamage` after the hitMod scaling (`Reborn:CharacterControl.cs:7337-7343`), so Effect Damage (`RPC_AddEffectDamage`) and 0-damage hits still KO; the damage itself is untouched and the hit's hate loses its `KO × 10` part (`:7345`). `actionState` is `"attack"` during every Monkey action: Combo stages (`Reborn:Monkey.cs:57`, `:227`), HP Transfer (`:447`), every cast bar (`:1676`), Unsummon (`:1078`), Summon Soul (`:1404`), Mike Blink (`:5090`), Twin Souls' pose (`:17580`), Sovereign's finisher lock and Sovereign Flash (`Reborn:RebornC7Act.cs:3271`, `:3372`). Thai tooltip says only "while casting / charging" (card `tooltipNote`). Changes no other card.
- **Lower ranks stay castable (Ja Overdrive and Gaia Bulwark need Ja 4 / Buiten 4, so their form +1 matters only for ranks 1-3):** each rank is its own skill id (Ja 251-254, Buiten Hou Hou 351-354, `Reborn:MonkeySkill.cs` `getSkillTree`). `upgradeSkill` writes the new id into a free slot of `skill[]` and removes nothing (`Reborn:CharacterDataClass.cs:1378-1390`), so a Monkey with rank 4 still holds ranks 1-3. The skill window draws every held rank as learned (state 3, `Reborn:GameGui.cs:8955-9002`); a learned active button casts its own command on click (`selectCommand(command)`, `Reborn:GameGui.cs:9364-9367`) and can be dragged to the hotbar (`:9395-9400`). The cast looks the name up from that command (`Reborn:GameGui.cs:313`) and only checks `hasSkill(command)` (`:1245`); nothing remaps a lower rank to the highest. So Ja 1-3 / Buiten 1-3 can be cast after rank 4 is learned, and both cards model every rank.
- **Ja Overdrive (`monkey_jaOverdrive`, 452, passive):** `RPC_ja_create` first sets `sLv = RebornC6.MonkeySummonLv(monkey, 452, sLv)` = `min(4, sLv + 1)` (`Reborn:Monkey.cs:15029-15031`, `Reborn:RebornC6.cs:1571-1578`) and loads that Ja prefab; `Ja.summon` sets `mSummonLv` from the prefab type (`Reborn:Ja.cs:174-198`) and then `RebornC6.JaOverdrive` adds 1 level, sets `mhp = hp = 1600` and `followDistance + 0.5` (`Reborn:Ja.cs:199`, `Reborn:RebornC6.cs:1580-1590`); blue recolour and a `jaSoul` effect are visual (`:1591-1608`). Net level for Ja 1 / 2 / 3 / 4: 3 / 4 / 5 / 5 (2026-10-25 build; in bible3 every rank is 5, see the bible3 Summon Soul item below). Effects: the `[ja]` TAL aura uses `mSummonLv` (`Reborn:Ja.cs:500`, +50 TAL at level 5), Detonate radius `4 + 2 × level` (14 m at level 5) and damage `(int)((1 − 0.5 d / r) × Ja HP)`, KO `floor(0.1 × Ja HP)` (`Reborn:Ja.cs:83-95`; up to 1600 / 160 from a full Ja); the Ja's LCK is its prefab form's. Prefab-type effects for Ja 1-3 only: Summon Soul's `jaSoul` level (`Reborn:RebornMonkeySoul.cs:33-48`) and the Unsummon refund (`Reborn:Monkey.cs:1138-1152`). Cards changed: `monkey_ja` (Reborn `descDep`, `[ja]` level, stat grid via `ownStatsTable`), `monkey_ja_detonate` (Reborn `dmg` / `formulaItems` / `jaRadius` / `ownStatsTable` / `reach` with the toggle), `monkey_summonSoul`, `monkey_unsummon` (desc lines).
- **Gaia Bulwark (`monkey_gaiaBulwark`, 453, passive):** `RPC_buiten_create` sets `sLv = min(4, sLv + 1)` with 453 (`Reborn:Monkey.cs:15521-15523`), no extra level (Buiten's level comes from the prefab type, `Reborn:Buiten.cs:289-302`), so Buiten 4 stays level 4 (in bible3 every rank spawns as Buiten 4, see the bible3 Summon Soul item below). `RebornC6.BuitenBulwark` (called at `Reborn:Monkey.cs:15623`): `target = 3 × max(1, Monkey mhp)`; if the statue's `mhp` is lower it becomes `target` and HP rises by the difference (full), re-checked once 0.6 s later without the heal (`Reborn:RebornC6.cs:1692-1722`); `localScale × 1.5` and a violet / gold look (`:1734-1750`). The statue's HP pool is what absorbs the `[buiten]` holders' white damage (`Reborn:CharacterControl.cs:7620-7650`). For Buiten 1-3 the form +1 also raises the aura radius `20 + 5 × level`, `[buiten]` level and the summoner's DEF `+10 × level` (`Reborn:Buiten.cs:322-357`), the turret's Stone Hammer level (`Reborn:Monkey.cs:15626`), the `buitenSoul` level (`Reborn:RebornMonkeySoul.cs:65-80`) and the Unsummon refund (`Reborn:Monkey.cs:1170-1184`). Thai tooltip "+1 ระดับ" never applies to Buiten 4 (`tooltipNote`). Cards changed: `monkey_buiten` (Reborn `descDep`, `[buiten]` level, `reach`, stat grid via `ownStatsTable` with MHP = max(prefab, 3 × 10 × VIT)), `monkey_summonSoul`, `monkey_unsummon`.
- **Twin Souls (`monkey_twinSouls`, 454, instant):** MP 80, SP 80 consumed (`Reborn:MonkeySkill.cs:473-480`). `RPC_twinSouls` (`Reborn:Monkey.cs:17578-17648`, dispatch `:13952-13959`): cooldown `agiAdjust(300)` at once (`:17583`), Revised Art applies (`Reborn:CharacterControl.cs:11681-11686`); the Monkey stands 0.5 s, then (owner) `instantCast` Lv 3, `talUp` Lv 4 value `floor(0.25 × tal)` and `mpRegen` Lv 4 value 0, all 15 s fixed (`:17601-17607`); 12 + 3 s later one blast at the Monkey's position then: `RebornC6.Area(pos, 10, 5, EnemyMask)`, each enemy once `hit(454, floor(1.5 × talAdjust(150)), KO 50)`, pushed outward (`:17641-17646`). `instantCast` gives 3 instant casts (one level per cast, `Reborn:Monkey.cs:1764-1782`, `Reborn:CharacterControl.cs:11429-11454`); Fire Avatar, Earth Form, Volcanic Eruption and Summon Gaos accept it only with Auto Instant 431 (`Reborn:Monkey.cs:1639-1674`). Status levels: a higher level replaces a lower one, a lower one is refused (`Reborn:CharacterControl.cs:9606-9677`, old copy removed `:1435`), so Twin Souls replaces Instant Cast Lv 1-2 and makes a later Instant Cast useless while it lasts. **Bug:** `mpRegen` heals its value every ~2 s (`Reborn:CharacterControl.cs:9118-9125`) and the value is 0, so it restores nothing, and at Lv 4 it replaces a lower item regen (e.g. `f_dem2` Lv 1, 100 MP, `Reborn:GameGui.cs:2374-2377`) for 15 s (card `bbBug` until bible3, fixed below). The blast is not World Ignition (no `[ignite]`, a plain hit). Start cooldown on combat maps (`Reborn:Monkey.cs:11145-11149`). Cards changed: `monkey_instantCast`, `monkey_autoInstant` (desc lines).
- **Soul Pact (`monkey_soulPact`, 461, passive):** every summon create calls `C7Dismiss(incoming)` (`Reborn:Monkey.cs:14863`, `:15037`, `:15335`, `:15529`, `:16036`): with 461 and a non-Gaos summon of the other element than the current one, the current is kept as the "second" (an older second unsummoned); otherwise the current is unsummoned and the second only when it is the same element; Gaos clears both (`Reborn:Monkey.cs:15152-15178`; element test `Reborn:RebornC7Passive.cs:2834-2846`; a dead second counts as none, `:2800-2817`). Phoenix and Gadina take `tal = max(own, Monkey getNoDeltaStat(6))` after Fire Soul / Earth Soul (`Reborn:Phoenix.cs:918-921`, `Reborn:Gadina.cs:1190-1193`); no Gadina move reads TAL. Summon Soul then gives the second summon's soul to the same ally list, once per summon (`Reborn:Monkey.cs:1458-1461`, `Reborn:RebornC7Passive.cs:2858-2871`; every 120 s in bible3, below), not if the current summon's soul was already used (`Reborn:Monkey.cs:1439-1442`). Commands and Phoenix4 / Gadina4 skills see only the current summon (`Reborn:Monkey.cs:13556-13608`, `:13665-13925`); Unsummon refunds only the current and drops the second (`:1108-1197`, `Reborn:RebornC7Passive.cs:2848-2856`); Summon Release releases only the current (`Reborn:Monkey.cs:1296-1309`); Lavu needs the current summon to be Gadina / Buiten and unsummons only it (`:14076-14088`, `:4669-4672`). The Thai tooltip's "TAL 100%" and "party-wide" are wrong / already true (`tooltipNote`; Summon Soul is party-wide for everyone, `Reborn:RebornMonkeySoul.cs:5`). Cards changed: `monkey_phoenix` (Reborn `descDep`, stat grid), `monkey_phoenix_fireBall`, `monkey_skyCrimson`, `monkey_instantBlaze` (Reborn `dmgControls`: the Phoenix TAL max in `phoenixOwnStats`), `monkey_ja`, `monkey_gadina`, `monkey_buiten`, `monkey_summonSoul`, `monkey_unsummon`, `monkey_summonRelease`, `monkey_lavu`, `monkey_summonGaos` (desc lines).
- **Runic Inferno (`monkey_runicInferno`, 462, passive):** Runic Flame pieces live a fixed 15 s instead of `chaAdjust(5)` (`Reborn:Monkey.cs:15247`), their BoxCollider `size.x × 2` (0.3 → 0.6 m; `RebornC6.Scale` only scales particles) and their drop point is recorded (`Reborn:RebornC7Passive.cs:2890-2909`). Every 1 s (`MonkeyTick`, `:2941-2960`) `dmg = talAdjust(50)` once; each enemy in `RebornC6.Area(Monkey, 40, 6)` within 1.6 m (flat) of a live drop point takes `ProcHit(462, dmg, KO 0)` (a normal `hit()`, `:470-485`) and, if it has no burn, `burn` Lv 1 for 3 s. `FinalOut`: a Monkey attacker with 462 within 1.6 m of its own drop point gets `CeilToInt(dmg × 1.3)` after DEF on every `hit()` (`:553-557`, `:591-594`, `Reborn:CharacterControl.cs:7275`), its own hits only (summons hit as themselves, Lavu Upheaval is penetrating). Fire Rune: `MnkRune` returns 20 MP + 20 SP at a flat `Random(0, 100) < 40`, any rune level, 1 s lockout kept (`Reborn:RebornC7Passive.cs:2994-3013`, `Reborn:Monkey.cs:15200-15215`). Cards changed: `monkey_runicFlame` (Reborn `duration` / `durWrapped` 15 s fixed, `reach` 0.6 m box + the 1.6 m and 40 m gates, `descDep`), `monkey_fireRune` and `monkey_fireAvatar_fireBall` (rune `lckProc` 40%, `noLck`), and the on-own-fire `finalOut` toggle on `monkey_nAttack`, `monkey_damageCast`, `monkey_fireBall`, `monkey_blazingArrow`, `monkey_flashFire`, `monkey_runicFlame`, `monkey_groundLock`, `monkey_titanicEarthPulse`, `monkey_stoneHammer`, `monkey_fireAvatar_fireBall`, `monkey_blazingFire`, `monkey_earthForm_nAttack`, `monkey_volcanicEruption` and the new `monkey_twinSouls`, `monkey_elementalSovereign`, `monkey_elementalSovereign_flash` (all `hit()` calls on the Monkey's own CharacterControl, `Reborn:Monkey.cs:133`, `:306`, `:564`, `:1818`, `:2607`, `:2792`, `:3419`, `:4099`, `:4340`, `:6358`, `:6825-7189`, `:7580`, `Reborn:Monkey_fireBall.cs:79`, `Reborn:Monkey_runicFlame.cs:57`). Not on a card: Second Stone (`:3578`), Mike Circle (`:588`), Mike Blink hits and the Buiten turret's hammer also get it.
- **Runic Bastion (`monkey_runicBastion`, 463, passive):** a Runic Sand piece touching an enemy without `groundLock` first calls `MnkSandGrab` (`Reborn:Monkey_runicSand.cs:50-64`): per target once per 5 s (`Gate`), a flat distance above 1.5 m pulls it with `forceAdjust(dir × min(12, 1.5 × distance))` (no damage), and 0.5 s later `groundLock` Lv 3 for a fixed 4 s (`Reborn:RebornC7Passive.cs:3015-3042`); otherwise the normal `groundLock` Lv 1 `getDebuff(2, CHA, CHA)`. While the Monkey has `[runicSand]` it takes `FloorToInt(dmg × 0.7f)` white damage (C7 `OnTakeDamage`, `:725-729`, after Soul Link's C6 hook, `Reborn:CharacterControl.cs:7343-7344`) and no push (`Unpushable`, `Reborn:RebornC7Passive.cs:1546-1565`); KO and Effect Damage are untouched; no position check (Thai tooltip "standing on the sand", `tooltipNote`). Earth Rune: 40% flat, 20 MP + 20 SP (`Reborn:Monkey.cs:15699-15714`, `MnkRune`). Cards changed: `monkey_runicSand` (desc line), `monkey_earthRune` (rune `lckProc`).
- **Elemental Sovereign (`monkey_elementalSovereign`, 464, instant):** MP 110, SP 95 consumed (`Reborn:MonkeySkill.cs:450-457`). `MonkeySovereign` (`Reborn:RebornC7Act.cs:3205-3311`): cooldown `agiAdjust(600)` (`Begin`, `:808-816`); `C7Absorb` unsummons the current and the second summon with no refund (`Reborn:Monkey.cs:15180-15198`); after 0.5 s the form is on for 20 s (`SovereignUntil`, `:3245`) and `vitUp` Lv 1 for 21 s with value `max(1, ceil(0.03 × mhp))` (`:3233`; `deltaVit` adds VIT and 10 × that MHP, `Reborn:CharacterControl.cs:1579-1583`, `:11980-11991`); pulses at 5.5 / 10.5 / 15.5 s `Hit(r 6, h 4, floor(0.6 × ATK) + talAdjust(60), KO 10)`, at 19.8 s a standby / run Monkey is locked, at 20.5 s `Hit(r 16, h 6, floor(3 × ATK) + talAdjust(250), KO 100)` (`:3247-3298`; `Hit` `:851-872`). In the form every cast bar is 0 with no `instantCast` spent (`Reborn:Monkey.cs:1764`, `:1779`), 14 fire / earth skills are refunded (`MnkSovereignCast`, `Reborn:RebornC7Passive.cs:3044-3071`, `Reborn:Monkey.cs:13574-13584`; Runic Flame / Sand still zero the SP themselves), Fire Avatar / Earth Form are refused with a refund, Combo hit 2 (code 2; hit 1 is code 99 and fails the `code < 10` gate; bible3 lets it through, below) splashes its final damage on the other enemies within `Area(target, 5, 4)` through their own `hit()` (`Reborn:RebornC7Passive.cs:663-687`), and the charge becomes Sovereign Flash (`Reborn:Monkey.cs:14416-14426`). **Unintended:** a summon-gated skill refused for a missing Phoenix4 / Gadina4 (or Volcanic Eruption on an airborne target) is refunded twice in the form (`Reborn:Monkey.cs:13581-13583` plus `:13675-13679` etc.) while the GUI deducts once (`Reborn:GameGui.cs:1259-1281`): a net MP / SP gain per press (fixed in bible3, below). Start cooldown `agiAdjust(360)` on combat maps (`Seed`, `Reborn:RebornC7Act.cs:615-633`). No KO immunity (only `fireAvatar` / `earthForm` give it, `Reborn:CharacterControl.cs:7564-7573`). Thai tooltip: the free list and "charge = Flash Fire" are wrong (`tooltipNote`). Cards changed: `monkey_nAttack` (Reborn `reach` splash with the form toggle), `monkey_cAttack`, `monkey_instantCast`, `monkey_autoInstant`, `monkey_fireAvatar`, `monkey_earthForm` (desc lines).
- **Elemental Sovereign - Sovereign Flash (`monkey_elementalSovereign_flash`, the 464 charge):** `SovereignCharge` (`Reborn:RebornC7Act.cs:3313-3344`): in the form, from standby / run, with the `sovFlash` lock (0.5 s, `addTimeOut`, so Revised Art makes it 1 s) free and MP, SP ≥ 6: pays 6 / 6 directly (no Revised Skill / Magic), holds up to 3 s; `SovFlash` (`:3370-3444`) stands still and hits `Hit(r 6, h 3, floor(0.35 × ATK) + talAdjust(40), KO 5)` every 0.3 s from t = 0, at least 2 and at most 10 times, 3 MP + 3 SP for every tick after the first, stopping on release (after tick 2), at 3 s or when MP / SP < 3.

### Build 2026.10.27.1936-bible3 behaviour fixes (verified 2026-10-27)

`Reborn1027:X.cs:N` = `DecompiledSource_Reborn_2026-10-27/Assembly-CSharp/X.cs` line N (build 2026.10.27.1936-bible3; readable copies with the strings resolved in `D:\12tails-assets-archive\reborn-diff-2026-10-25_to_2026-10-27\new\`, same line numbers). Each item names the 2026-10-25 line (`Reborn:`) it replaces. Original cards change in `servers.reborn` (a `[Fix]` line in the change note when BB differs); Reborn-only cards change their own fields.

- **Phoenix idle between fireballs (Fix; `monkey_phoenix_fireBall`, `monkey_rapidFire`):** the alert cycle calls `AI_idle(1, 3)` (`Reborn1027:Phoenix_AI.cs:84`); was `AI_idle(1, 3 − mRapidFireLv)` (`Reborn:Phoenix_AI.cs:84`, `BB:Phoenix_AI.cs:224`). On entry `AI_idle` still moves the cycle start back by `Random.Range(0, rTimer)` (`Reborn1027:Phoenix_AI.cs:212-233`), so the idle is `max(0, 1 − r)` with `r` in [0, 3): 0 two times in three, else 0-1 s (mean 1/6 s), at every Rapid Fire level. Rapid Fire 3 no longer waits the full 1 s. Unchanged: the Rapid Fire timer `clamp(5 − mag / 32, 0.1, 5)`, `mag = clamp((0.1 × RF + 0.1) × Monkey MAG, 1, 512)` (`Reborn1027:Phoenix.cs:64-71`) and the 0.8 s attack lock (fire at `actionTime + 0.5`, `:86`, then 0.3 s, `:131`). Interval `max(timer, 0.8 + idle)`: 0.8-1.8 s once the timer is low. App: `phoenixIdleFlat: true` on the Fireball's Reborn tab makes `phoenixFireballInterval(…, flatIdle)` drop the Rapid Fire 3 floor (page chip and guide hover); Rapid Fire gets a Reborn tab whose rank-3 limit line is the 0-1 s one; both change notes; the Fireball's `unintended` is cleared on Reborn.
- **Twin Souls MP regen (`monkey_twinSouls`):** after the 0.5 s pose, on the owner's client, `num = max(1, floor(0.03 × mmp))` and `mpRegen` Lv 4 for 15 s with value `num` only when the Monkey has no `mpRegen` or its value is below `num` (`Reborn1027:Monkey.cs:17770-17776`); was `RPC_AddStatus("mpRegen", 4, 15, 0)` every time (`Reborn:Monkey.cs:17606`). The status heals its value in MP every 2 s (`Reborn1027:CharacterControl.cs:9185-9191`). The only other `mpRegen` source is the MP item at `Reborn1027:GameGui.cs:2395` (Lv 1, 100 per tick), which now stays when it is the stronger one. Thai tooltip `Reborn1027:MonkeySkill_thai.cs:30`. Card: desc line (now with topics), `bbBug` removed.
- **Elemental Sovereign (`monkey_elementalSovereign`):** the Combo splash gate is `code >= 10 && code != 99` (`Reborn1027:RebornC7Passive.cs:700`); was `code >= 10` (`Reborn:RebornC7Passive.cs:665`), so Combo hit 1 (`hit(99, …)`, `Reborn1027:Monkey.cs:134`) now splashes like hit 2 (`hit(2, …)`, `:308`): `ProcHit(464, dmg, KO 0)` on every other living enemy in `Area(target, 5, 4)` (`Reborn1027:RebornC7Passive.cs:707-716`). Refund: when `MnkSovereignCast` refunds a skill in the form it sets `rbSovRefundFrame = Time.frameCount` after `returnMPSP` (`Reborn1027:Monkey.cs:13671-13674`), and `returnMPSP` skips a second refund in that frame (`:14367-14371`; the summon-gated failure paths check the same frame, `:13686`, `:13702`, `:13718`, `:13734`), so a refused summon-gated skill in the form now costs nothing and gains nothing (was refunded twice, `Reborn:Monkey.cs:13581-13583` + `:13675-13679`). Cards: Sovereign desc ("ทั้ง 2 ครั้ง"), `unintended` removed; the Combo card's Reborn Sovereign line and splash reach label.
- **Summon Soul: level-5 souls, their extras and a 120 s re-use (Buff; `monkey_summonSoul`, `monkey_jaOverdrive`, `monkey_gaiaBulwark`, `monkey_soulPact`):**
  - **Level 5:** `RebornMonkeySoul.Apply` now passes the soul level through `Rank5Soul` (`Reborn1027:RebornMonkeySoul.cs:183`, `:116-124`): a level-4 soul becomes level 5 when the Monkey holds the matching skill, `Rank5SkillFor` (`:101-114`): 452 Ja Overdrive for `phoenixSoul` / `jaSoul`, 453 Gaia Bulwark for `gadinaSoul` / `buitenSoul`; not in the 2026-10-25 build (`Reborn:RebornMonkeySoul.cs`, `Apply` without it). The level comes from the summon's Type (`SoulStatusFor`, `:22-99`). The stat stays `+10 × sLv` (`deltaAtk` / `deltaTal` / `deltaDef` / `deltaVit`, apply `Reborn1027:CharacterControl.cs:3050-3100`, removal `:10744-10756`), so level 5 = +50. Every soul goes to the whole-map ally list for 240 s (`SoulDuration`, `Apply` `:172-198`).
  - **Which summons are level 4:** with 452 / 453 every rank's create call asks for prefab 5 (`Rank5Prefab`, `Reborn1027:RebornMonkeySoul.cs:126-133`; calls `Reborn1027:Monkey.cs:2262`, `:2650` Phoenix, `:2943` Ja with 452, `:3709` Gadina, `:4474` Buiten with 453), and the create functions turn `sLv >= 5` into level 4 with the `<Name>4_R5` body (`Reborn1027:Monkey.cs:14971-14975`, `:15169-15174`, `:15463-15468`, `:15681-15686`; `R5Body` `Reborn1027:RebornMonkeySoul.cs:135-148`); was the cast rank (`Reborn:Monkey.cs:4446` and the like). So with the skill every Phoenix / Ja / Gadina / Buiten cast gives a level-5 soul. The R5 prefabs are not ripped for this build; the code (`Rank5Up` wants rank 4, `Reborn1027:RebornMonkeySoul.cs:150-157`, `Reborn1027:Phoenix.cs:905`, `Reborn1027:Gadina.cs:1194`) and the Thai tooltips (`Reborn1027:MonkeySkill_thai.cs:26`, `:28`) expect them to keep the `<Name>4` type. Phoenix / Gadina R5 bodies also get ×1.25 ATK / MAG / TAL / VIT / MHP (`Rank5BodyStats`, `Reborn1027:RebornMonkeySoul.cs:159-169`); Ja still gets Ja Overdrive's +1 level (level 5, `Reborn1027:Ja.cs:199`), Buiten stays level 4. The rank-5 bodies themselves are the next item.
  - **Level-5 extras** (`RebornSoulExtra`, `ExtraLevel = 5`, `On(lv) = lv >= 5`, `Reborn1027:RebornSoulExtra.cs`; new file): **Phoenix soul:** in `RebornC7Passive.AfterHit`, after every `hit()` (white or purple path, `Reborn1027:CharacterControl.cs:7354`) by a local non-summon player holding it, with code < 10 (normal attack codes; Monkey Combo hit 1 is code 99 and does not count, negative codes such as War Capital's `hit(-4444)` do), damage > 0, a living target and not nested: `Random.value < 0.15` (no LCK) → `burn` Lv 2 for a fixed 5 s on the target (`Reborn1027:RebornC7Passive.cs:629-638`). **Ja soul:** `SoulJaTick` from the local-player `Tick` (`Reborn1027:RebornC7Passive.cs:985`, `:1009`, `:1059-1078`): every 3 s, while MP < max MP, `RPC_AddHeal(1, 0, max(1, floor(0.02 × mmp)), …)`; mercenaries (not `isPlayer`) never run it. **Gadina soul:** KO × 0.8 (floor), **Buiten soul:** damage × 0.9 (floor, at least 1), both in `RebornC7Passive.OnTakeDamage` (`Reborn1027:RebornC7Passive.cs:745-746`), called from `RPC_AddDamage` after the `hitMod` scaling (`Reborn1027:CharacterControl.cs:7400-7406`) and only for a hit with damage > 0 (`:729-732`), so Effect Damage and 0-damage hits are untouched; every holder (mercenaries too) on the client that applies the damage.
  - **Re-use:** the summon's own lock is `addTimeOut("summonSoul", 120)` (`Reborn1027:Monkey.cs:1455`; `RecastLock = 120f`), also for Soul Pact's second summon (`Reborn1027:RebornC7Passive.cs:2976-2989`); was 999 s (`Reborn:Monkey.cs:1445`, `Reborn:RebornC7Passive.cs:2866`, `BB:Monkey.cs:24139`). While locked: "SummonSoul has already been used" (`Reborn1027:Monkey.cs:1449-1452`). The Monkey's own cooldown stays 3 s. Thai tooltip `Reborn1027:MonkeySkill_thai.cs:16`.
  - App: Summon Soul's Reborn tab: desc lines (re-use, the two C6 lines, Soul Pact), `status` levels 5 behind the info toggles `REBORN_MNK_JAOVERDRIVE_DEP` / `REBORN_MNK_GAIABULWARK_DEP`, change note; the four extras are the Reborn popups `STATUS_DESC_SERVER.reborn.phoenixsoul` / `jasoul` / `gadinasoul` / `buitensoul` (shown for level 5 and for a token with no level); Summon Soul lines on Ja Overdrive / Gaia Bulwark; Soul Pact's line says every 120 s.
- **Rank-5 bodies with Ja Overdrive / Gaia Bulwark (Buff; `monkey_phoenix`, `monkey_phoenix_fireBall`, `monkey_skyCrimson`, `monkey_instantBlaze`, `monkey_blazingArrow`, `monkey_fireSoul`, `monkey_ja`, `monkey_ja_detonate`, `monkey_gadina`, `monkey_gadina_nAttack`, `monkey_planetBreaker`, `monkey_titanicEarthPulse`, `monkey_buiten`, `monkey_unsummon`, `monkey_jaOverdrive`, `monkey_gaiaBulwark`):**
  - **Spawn:** with 452 every Phoenix and Ja create, with 453 every Gadina and Buiten create asks for prefab 5 whatever the cast rank (`Rank5Prefab`, `Reborn1027:RebornMonkeySoul.cs:126-133`; Phoenix `Reborn1027:Monkey.cs:2262`, Blazing Arrow's re-summon `:2650`, Ja `:2943`, Gadina `:3709`, Buiten `:4474`). The create functions turn `sLv >= 5` into level 4 and load `<Name>4_R5` (`R5Body`, `Reborn1027:RebornMonkeySoul.cs:135-148`, falling back to `<Name>4` when the prefab is missing; `Reborn1027:Monkey.cs:14971-14975`, `:15169-15174`, `:15463-15468`, `:15681-15686` and each `case 4`). Ja and Buiten still pass `MonkeySummonLv` (`min(4, 4 + 1)` = 4, `Reborn1027:RebornC6.cs:1571-1578`). The 2026-10-25 build used the cast rank, Ja / Buiten 1-3 one step up (`Reborn:Monkey.cs:15031`, `:15523`); Phoenix and Gadina were not touched.
  - **The R5 prefabs** (decoded 2026-10-28 with UnityPy from `12TailsReborn_Data_2026-10-27/resources.assets`, GameObject pathIDs `Phoenix4_R5` 47099, `Ja4_R5` 45107, `Gadina4_R5` 47126, `Buiten4_R5` 48846 against `Phoenix4` 45133, `Ja4` 49712, `Gadina4` 45697, `Buiten4` 47631): the `CharacterControl` data equals the rank-4 prefab's byte for byte except the owner pointer (Name, Type `Phoenix4` / `Ja4` / `Gadina4` / `Buiten4`, Lv and the nine stats; e.g. Phoenix4 MHP 360, ATK 46, DEF 42, AGI 64, VIT 36, MAG 72, CHA 48, TAL 84, LCK 32), and the summon components keep the rank-4 type enum (Phoenix / Ja / Buiten identical but for pointers; Gadina differs only in its sword / shield model pointers, `sword4_R5` / `shield4_R5`). Root scale 1.2 (Phoenix, Ja), 1.35 (Gadina), 1.8 (Buiten), against 1.0; `CharacterController` sizes unchanged. So the `Type` gates (`Type != "Phoenix4"` / `"Gadina4"`, `Reborn1027:Monkey.cs:2369`, `:3828`, `:5633`, `:5783`, `:13774-14020`), Summon Soul (`SoulStatusFor`) and Unsummon (`Reborn1027:Monkey.cs:1129-1193`) see a rank-4 summon whatever rank was cast.
  - **Phoenix (452):** `Rank5Up(summoner, 452, level 4)` sets level 5 and `Rank5BodyStats` floors ×1.25 of ATK, MAG, TAL, VIT and MHP, HP = MHP (`Reborn1027:Phoenix.cs:905-909`, `Reborn1027:RebornMonkeySoul.cs:150-169`), before Fire Soul (`0.1 × level × Monkey stat` = 50 %, MHP = 10 × VIT, `Reborn1027:Phoenix.cs:910-921`) and Soul Pact's TAL max (`:923-926`). Summon blast at level 5: `FindAreaTarget(3 + 0.5 × 5, 3)`, `hit(115, talAdjust(75), KO 1)` (`:946-956`). Rebirth: chance by `PhoenixType` = Phoenix4, 30 % (`Reborn1027:Phoenix.cs:1325-1348`); the rebirth blast keeps level 4 (`:711-761`, no `Rank5Up` there).
  - **Gadina (453):** after EquipSword / EquipShield (by type, Gadina4 base 40, `Reborn1027:Gadina.cs:1652-1736`), the Aegis VIT, Earth Soul (`getGadinaLv()` = 4, `:1178-1189`, `:1613-1624`) and Soul Pact's TAL max (`:1190-1193`), `Rank5Up(453, Gadina4 ? 4 : 0)` → `Rank5BodyStats` (`:1194-1198`), then MHP = 10 × VIT (`:1199`). Summon blast at level 5 (`:1232`): `FindAreaTarget(4 × 5 + 8 = 28, 2)`, `hit(40, 25, KO 25, hate 250)` (`:1237-1247`), with the Gadina's own LCK (Gadina4: 75). Gadina's moves read the Gadina4 type, so the normal attack's hits, cooldown and box are rank 4's at every cast rank.
  - **Ja (452):** `JaOverdrive` still adds 1 level and sets HP / MHP 1600 (`Reborn1027:Ja.cs:199`, `Reborn1027:RebornC6.cs:1580-1590`): level 5 at every rank, Detonate radius 4 + 2 × 5 = 14. **Buiten (453):** level 4 (type) at every rank, `BuitenBulwark`'s HP rule unchanged (`Reborn1027:RebornC6.cs:1660-1690`); the old `localScale × 1.5` of `BuitenLook` is gone (`diff/RebornC6.cs.diff`, hunk at 1739), so the size is the R5 prefab's 1.8× while the Reborn Thai tooltip still says 1.5× (`Reborn1027:MonkeySkill_thai.cs:28`; Gaia Bulwark `tooltipNote`).
  - **Unsummon:** refunds by `Type`, so Phoenix 35, Ja 30 (452) and Gadina 43, Buiten 33 (453) at every cast rank (`Reborn1027:Monkey.cs:1142`, `:1158`, `:1174`, `:1190`).
  - **App:** `phoenixOwnStats` / `gadinaOwnStats` use the rank-4 stats ×1.25 (and Fire Soul at level 5) on Reborn while the Ja Overdrive / Gaia Bulwark toggle is on (`mnkPhxR5`, `mnkGadinaR5`); `mnkJaLv` = 5, `mnkJaStats` = Ja4 with MHP 1600, `mnkBuitenForm` = 4, `mnkPhxLv` / `mnkGadinaLv` = 5; a card's `ownLck` may be `(rank) => n`. The toggle sits on every card whose numbers change (Phoenix: INFO + reach, Rebirth chip 30 %; Fireball, SkyCrimson, Instant Blaze: DMG; Gadina: DMG, KO 25, reach 28 m; Gadina normal attack, Planet Breaker, Titanic Earth Pulse: DMG) with a desc line, and text lines on Blazing Arrow, Fire Soul (50 %), Ja, Ja - Detonate, Buiten (1.8×) and Unsummon; compat links both ways.
- **Rapid Fire tooltip (issue-list check 2026-10-28; card `monkey_rapidFire`):** the new tooltip gives the Fireball cooldown cut as 3 / 6 / 9 s (`(-1,-3 sec)` … `(-3,-9 sec)`), matching the code, so the Reborn tab clears the inherited BB tooltip note.

### Cross-skill interactions on the cards (verified 2026-10-28)

`Reborn1027:` = build 2026.10.27.1936-bible3. The BB rules above hold on Reborn at these lines:
- **Fireball:** Fire Keep's +20 inside `talAdjust` (`Reborn1027:Monkey_fireBall.cs:68`), the burn level with Fire Avatar #432 learned (`:69-73`, applied `:81-86`), Rapid Fire's cast / cooldown cut (`Reborn1027:Monkey.cs:1597-1603`); Fire Keep's release runs before the Combo / Mike Blink choice (`Reborn1027:Monkey.cs:14496-14512` vs `:14513-14527`). Combo KO +1 with Earth Form #433 learned (`Reborn1027:Monkey.cs:116`, `:290`); Titan Sword's KO on the Gadina slash (`Reborn1027:Gadina.cs:82`); Stone Sentinel on Stone Hammer (`Reborn1027:Monkey.cs:4356-4357`); Fire Soul on Phoenix (`Reborn1027:Phoenix.cs:910-921`); the Phoenix fire timer with Rapid Fire (`Reborn1027:Phoenix.cs:64-71`).
- **Auto Instant gate:** Fire Avatar, Earth Form, Volcanic Eruption and Summon Gaos set `canInstantCast = false` without 431 (`Reborn1027:Monkey.cs:1649-1684`); cast routine `:1778-1796`.
- **Form skill lock (traced 2026-10-28):** `doSkill` still refuses every skill in Fire Avatar or Earth Form ("Cannot use skill with Phoenix Armor" / "Gadina Armor", string keys `fireAvatar` / `earthForm` decoded from the string table) and refunds through `returnMPSP` (`Reborn1027:Monkey.cs:13652-13663`), before the Elemental Sovereign refund switch (`:13665`). `returnMPSP` gives back the MP cost and a red-SP cost, after the Revised Magic (414, MP x0.8) and Revised Skill (404, SP x0.5) cuts (`Reborn1027:Monkey.cs:14366-14389`). The Reborn Fire Avatar and Earth Form tabs take the base lock line.
- **Damage Cast hit sites:** HP Transfer `Reborn1027:Monkey.cs:568` and the cast bar `:1832` with `getCritPlus`, Lavu's Upheaval `:4919` without it (BB `Monkey.cs:21339`, `:25644`, `:35102`).
- **Runic Flame / Runic Sand** remove each other as in BB (`Reborn1027:CharacterControl.cs:2957-2959` / `:3018-3020`, string-encoded keys, the same case order as BB `CharacterControl.cs:37847-37851` / `:38059-38063`).
- **Summon AI moves:** the Phoenix 412 / Gadina 413 grants run after the `sLv >= 5` → 4 rank-5 conversion (`Reborn1027:Monkey.cs:14971-14975` then `:15086-15089`; Gadina `:15578`), so with Ja Overdrive / Gaia Bulwark every cast rank gets the AI move (`Reborn1027:Phoenix_AI.cs:310`, `Reborn1027:Gadina_AI.cs:316`).
- **Phoenix4 / Gadina4 gates:** Phoenix - SkyCrimson `Reborn1027:Monkey.cs:13774`, Blazing Arrow `:13791`, Instant Blaze `:13950`, Fire Avatar `:14002-14016`; Gadina - Planet Breaker `:13869`, Gadina - Titanic Earth Pulse `:13890`, Earth Guard `:13964-13983`, Earth Form `:14018-14029` (all `Type` tests). The R5 bodies keep the Type Phoenix4 / Gadina4, so with 452 / 453 all eight work after a summon of any cast rank (Fire Avatar, Earth Form and Earth Guard were not yet named on the cards or in the Ja Overdrive / Gaia Bulwark links).
- **Elemental Sovereign in the form:** every cast bar is 0 and no `instantCast` is spent whatever `canInstantCast` says, so Volcanic Eruption and Summon Gaos need no Auto Instant (`Reborn1027:Monkey.cs:1778-1796`). `MnkSovereignCast` refunds exactly 14 skills: Blazing Arrow, Fireball, Flash Fire, Instant Blaze, Phoenix - SkyCrimson, Volcanic Eruption, World Ignition, Ground Lock, Stone Hammer, Gadina - Titanic Earth Pulse, Gadina - Planet Breaker, Earth Guard, Runic Flame, Runic Sand (`Reborn1027:RebornC7Passive.cs:3176-3187`, refund `Reborn1027:Monkey.cs:13665-13675`); Runic Flame / Runic Sand still use all SP (`:13832-13840`, `:13933-13940`). Summon Gaos is not refunded (MP / SP paid). It returns 2 for Fire Avatar / Earth Form ("The elementals are already inside you", plus a refund).
- **Bible (2026-10-28):** the Reborn tabs of those 14 cards and Summon Gaos name Elemental Sovereign (linked both ways); Fire Avatar, Earth Form and Earth Guard name Ja Overdrive / Gaia Bulwark, and those two cards name the four skills each opens (links both ways); Volcanic Eruption and Summon Gaos keep Auto Instant inside their สกิลเสริม topic; Runic Flame and Runic Sand link each other on Reborn too.

## Server Balance Variations (ToT patch notes, 2026)

Source: ToT Facebook patch notes (C6 intro post, 03/08/2026, 10/09/2026, hot fix 12/09/2026; latest value wins), read 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tot`.

| Skill | ToT change |
|---|---|
| Fire Avatar | biggest fireball every 2nd attack (12/09 hot fix; 10/09 said every 3rd) |
| Earth Form | punch animation +25% (12/09; 10/09 said +20%) |
| Stone Sentinel | charge cooldown 10 s (6 → 5 on 10/09, then 10 on 12/09) |


### ToT EX learning requirements (published simulator, 2026-10-13)

Source: [ToT monkey simulator dataset](https://talesoftails.net/data/skill-simulator/monkey.json), with learning rules from [ToT simulator client](https://talesoftails.net/_next/static/chunks/673.2ecb414e00f7368e.js). These are server-specific published simulator requirements, not BigBug decompiled mechanics or verified damage formulas. Icons were extracted from the site’s `/gamegui/skill-simulator/skills/` assets and embedded in the hub.

| Cell | Published skill name | Level | Ordinary C skills required | Explicit prerequisite cells | Type / availability |
|---|---|---|---|---|---|
| 451 | UpdamageMonter | 95 | 0 | None | Passive |
| 452 | JaBurst5 | 100 | 6 | 254, 402, 432 | Active |
| 453 | BuitenGuard5 | 100 | 6 | 354, 433 | Active |
| 454 | RumBling5 | 100 | 6 | 372, 403 | Active |
| 461 | DowndamageMonter | 95 | 0 | None | Passive |

Each learned EX skill costs one point from a separate EX pool: 0 below Lv 95, 1 at Lv 95–99, 2 at Lv 100. Cells 451 and 461 exclude each other. At most one of cells 452–454 may be learned. EX skills never count toward ordinary C point requirements. All explicit prerequisites and the six ordinary C skills must remain learned; refunds and tree resets enforce this. See [shared ToT EX rules](12Tails-Mechanics-Reference.md#tot-ex-skills-published-simulator-2026-10-13).

### Projectile travel (decoded 2026-10-16)

- **Gaos fire** (`gaosFire.cs:26`): from Gaos's mouth (local (0, 4, 6), `Gaos.cs:3595-3600`) straight toward the target at 30 m/s, no gravity, `ProjectileControl.life` **3 s** (not set in code; the `gaosFire` prefab in the original client data, `sharedassets17.assets`), so at most **90 m**.
- **Phoenix Sky Crimson** (`Phoenix.cs:3645-3665`): not a shot from the Phoenix. For each enemy hit, `fireDir = (enemy centre − Phoenix − 20 × up).normalized` and the fireball spawns at `enemy centre − 12 × fireDir`, i.e. 12 m back along a line coming down from 20 m above the Phoenix, then flies 16 m/s (`Phoenix_skyCrimson_fire.cs:28`, no gravity) into the enemy, arriving after 0.75 s. Its `life = 2 × rangeMod` (`Phoenix.cs:1822`, 32 × rangeMod m) is never the limit.

### Riding mounts: mountAttack and mountDash (G. Marshal / G. Champion mount, verified 2026-10-17)
Both mounts run the same attack code for this class (`PvpMount.cs` and `ChampionMount.cs` differ only in the +20 / +50 stat bonus, the ride speed 8 / 9 and the Champion's charge; the shared rules are in [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md#riding-mounts-g-marshal-and-g-champion-verified-2026-10-17)). ATK, TAL and LCK are the mount's own (rider's base stats + bonus). Line numbers are `PvpMount.cs`; `ChampionMount.cs` has the same code a few hundred lines later.
- **mountAttack** (normal attack while moving at no more than 40% of the run speed): `FindRecTarget(pos, fwd, 1, 1, 3, 3)`, `hit(1, (int)(0.7 × ATK), KO 1)`, cooldown 1.5 s (`:14038-14061, :14185`).
- **mountDash** (normal attack while moving faster): `FindAreaTarget(pos, 6, 3)`, `hit(1, talAdjust(30), KO 1)`, cooldown 5 s (`:14504-14527, :14632`).
