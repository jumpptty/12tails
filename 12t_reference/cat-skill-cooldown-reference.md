# Cat — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| awareness | Awareness | 2 | 1 | false | false | 1 | false |
| evenOdds | Even Odds | 1 | 90 | true | false | — | — |
| luckyCard | Lucky Card | 4 | 24 | true | false | — | — |
| fateDraw | Fate Draw | 4 | 30 | true | false | 15 | true |
| powerShuffle | Power Shuffle | 2 | 45 | true | false | 30 | true |
| lifeGamble | Life Gamble | 1 | 30 | true | false | — | — |
| skillGamble | Skill Gamble | 1 | 30 | true | false | — | — |
| luckyDice | Lucky Dice | 2 | 60 | true | false | — | — |
| doubleDown | Double Down | 2 | 30 | true | false | — | — |
| twoPair | Two Pair | 2 | 120 | true | false | — | — |
| copycat | Copycat | 2 | 120 | true | false | — | — |
| damageRoulette | Damage Roulette | 2 | 60 | true | false | 12 | true |
| nineLives | Nine Lives | 2 | 60 | true | false | — | — |
| grandCasinoArcade | Grand Casino Arcade | 2 | 600 | true | false | 60 | false |
| flyingDagger | Flying Dagger | 4 | 24 | true | false | — | — |
| forwardLunge | Forward Lunge | 2 | 30 | true | false | — | — |
| reverseThrust | Reverse Thrust | 2 | 45 | true | false | — | — |
| backflip | Backflip | 2 | 15 | true | false | — | — |
| heartRipper | Heart Ripper / Finishing Blow | 3 | 120 | true | false | — | — |
| disarm | Disarm | 2 | 33 | true | false | — | — |
| bleed | Bleed | 2 | 66 | true | false | — | — |
| moonBlade | Moon Blade | 2 | 90 | true | false | 1 | false |
| moonStorm | Moon Storm | 2 | 120 | true | false | 1 | false |
| deltaStrike | Delta Strike | 2 | 180 | true | false | 3 | false |
| swiftPace | Swift Pace | 1 | 90 | true | false | — | — |
| pillagePlunge | Pillage Plunge | 1 | 120 | true | false | — | — |
| supportFire | Support Fire | 1 | 240 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed.** `SkillData.cs`'s 12 shared `getSupportSkill()` skills — including
  `assassinate`, Cat's own thematic one — all appear in `Cat.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Cat.cs:10984`), `psalmOfEnergy`
  (`Cat.cs:11224`), `seaAegis` (`Cat.cs:11393`), `zephyrLore` (`Cat.cs:11587`), `replenishment`
  (`Cat.cs:11688`), `elementalBound` (`Cat.cs:11818`), `astralShift` (`Cat.cs:11970`), `bloodCarnage`
  (`Cat.cs:12161`), `obsidianFang` (`Cat.cs:41606`), `assassinate` (`Cat.cs:42065`), `mineWalker`
  (`Cat.cs:42440`), `divineChannel` (`Cat.cs:42817`) — all 12 present, all bare-`600`. A direct grep of
  `CatSkill.cs` for `cat_<name>` variants of all 12 names returns zero matches, confirming none are part of
  Cat's own learnable skill roster. All 12 excluded from this table.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.** Both do
  have their own named cooldowns in `Cat.cs`: `nAttack`'s combo stages carry bare (non-`agiAdjust`)
  `addTimeOut("nAttack", 1.5f)` calls (`Cat.cs:16848`, `17091`, `17801`, `18740`), and — unlike Bat's/Bison's
  `cAttack`, which has none — Cat's charge attack does carry its own bare `addTimeOut("cAttack", 1f)`
  (`Cat.cs:19792`). A separate, unrelated `addTimeOut("nAttack", 1f)` also exists at `Cat.cs:7972` inside a
  special-event-minigame branch, irrelevant either way. Both excluded from this table regardless, per the
  plan's blanket policy.
- **`mount` is not a Cat class skill — excluded, not a judgment call.** `Cat.cs:47019` —
  `this.$self_$22392.mChar.addTimeOut("mount", (float)12);` — sits inside `$RPC_useMount$22385`
  (`Cat.cs:46868-47305`), the universal ride-a-mount action shared by every class. A full-file grep of
  `CatSkill.cs` for `"mount"` returns zero matches — it has no `cType`/`getSkill()` entry at all, confirming
  it isn't part of Cat's learnable skill roster.
- **A generic confused-random-cast cooldown call at `Cat.cs:5819` is not a specific skill's own cooldown —
  excluded as noise.** `characterControl.addTimeOut(SkillData.getSkillCD((string)obj2), (float)30);` fires
  when the Cat itself is under the `"confuse"` status and randomly re-triggers an arbitrary skill from
  `skillArray[0]` — a shared confusion-status mechanic present identically in other classes' files, not a
  named cast site for any one skill.
- **`heartRipper`'s Class-C evolution shares its cooldown key with a differently-named skill —
  `finishingBlow5`.** `CatSkill.cs` shows three distinct learnable entries sharing `cType = "heartRipper"`:
  `cat_heartRipper1` (`CatSkill.cs:732`, req level 19/6 SP), `cat_heartRipper2` (`CatSkill.cs:749`), and
  `cat_finishingBlow5` (`CatSkill.cs:1258`, req level 70, `setMPSP(20, -45)`, `mode = eSkillMode.target`,
  `cType = "heartRipper"` at `CatSkill.cs:1284`) — the Class-C tier, which the game's own naming convention
  labels "5" (the tier slot, not a literal rank-5) rather than "3". A direct grep for `cat_heartRipper3`/`4`
  or `cat_finishingBlow1-4` returns zero matches, confirming no gap-filling ranks exist. This table treats
  the family as **3 distinct investable tiers → Max Rank 3**, following the same "count of learnable
  entries, not the literal numeric suffix" rule that explains every existing single-`5`-entry skill in the
  Penguin/Bison docs (e.g. Penguin's `tripleCast` has only a `pgn_tripleCast2` entry yet is Max Rank 1). At
  the source level, `RPC_heartRipper1` (`Cat.cs:9975`) sets the cooldown for ranks 1-2 (flat `agiAdjust(60)`,
  `Cat.cs:32986`) and internally chains into `RPC_heartRipper2` (`Cat.cs:32891`) as a same-cast second hit —
  not an independent player input. Once `finishingBlow5` is learned, the same button instead casts
  `RPC_finishingBlow1` (`Cat.cs:10383`), which sets the same `"heartRipper"` cooldown key to
  `agiAdjust(120)` (`Cat.cs:38418`) and chains into `RPC_finishingBlow2` (`Cat.cs:38323`) as its own second
  hit. This table uses the max-rank (`finishingBlow5`) cast site's value, `120`, and reports the Display
  Name as "Heart Ripper / Finishing Blow" so the CD value's source is not mistaken for `heartRipper`'s own
  base-rank cast site (`60`).
- **`awareness`'s conditional `insight` bonus comes from a separate passive — excluded, default value
  used.** `Cat.cs:8848` gates `RPC_AddStatus("insight", 1, chaAdjust(3), 0, ActorNr)` (`Cat.cs:8854`) behind
  `this.mChar.hasSkill(421)` — a separate passive, out of scope. `awareness`'s own guaranteed status
  (`Cat.cs:8837`) is unconditional and is what this table reports.
- **`luckyCard`'s `doom` proc is both passive-gated and target-contested — excluded on two independent
  grounds.** `Cat.cs:20870` gates the `RPC_AddStatus("doom", 1, Damage.getDebuff(...), 0, ActorNr)` call
  (`Cat.cs:20888`) behind `this.$self_$21749.mChar.hasSkill(402)` (a separate passive) *and* the debuff
  amount itself is computed via `Damage.getDebuff(base, targetCha, casterCha)` — target-CHA-dependent
  regardless of the passive gate. Duration is `—`/`—`.
- **`fateDraw`'s `fortune` duration has a passive-boosted branch — this table uses the default (no-passive)
  value.** `Cat.cs:21447` branches on `hasSkill(412)` (a separate passive): the boosted branch applies
  `chaAdjust(30)` at `sLv + 1` (`Cat.cs:21453`), the default branch applies `chaAdjust(15)` at `sLv`
  (`Cat.cs:21461`, the `else`). This table reports `15`, matching the `shadowMastery`/`demonGaze5` precedent
  of using the un-passived value.
- **`powerShuffle` applies one of 16 possible stat up/down statuses, all sharing one duration variable.**
  `Cat.cs:22082` — `this.$mDuration$21772 = this.$self_$21778.mChar.chaAdjust(30);` — is shared by every
  branch (`atkUp`/`defUp`/`agiUp`/.../`lckDown`, `Cat.cs:22110-22306`); a conditional `sLv++`
  (`Cat.cs:22087`, gated behind a separate passive `hasSkill(422)`) affects only the applied *magnitude*,
  not this duration. Self-buff/debuff, not target-contested.
- **`disarm`/`bleed` durations are target-contested via `Damage.getDebuff`** — `disarm` (`Cat.cs:34183`),
  `bleed` (`Cat.cs:35015`) — both also carry a conditional `+3`s bonus from a separate passive
  (`hasSkill(443)`) baked into the pre-contest base value, irrelevant to the exclusion since the formula is
  contested either way. Both Duration cells are `—`.
- **`twoPair` copies an existing status's own remaining duration — not a fixed, independently-computable
  value, excluded per the existing Penguin doc's `snowBall` precedent.** `Cat.cs:25900` —
  `this.$tChar$21859.RPC_AddStatus(this.$mStatus$21866.sType, this.$mStatus$21866.sLv, (int)
  (this.$mStatus$21866.sTime - Time.time), (int)this.$mStatus$21866.sValue, this.$mStatus$21866.sID);` —
  re-applies whatever status object is being processed (excluding a hardcoded list: `charm`, `mindControl`,
  `nightmare`, `mimic`, `allMimic`, `transform`) using that status's own remaining time, not a value
  `twoPair` itself defines. (Note: this status-copy mechanic lives in `twoPair`'s own coroutine range,
  `Cat.cs:25518-26413` — despite the thematic name fit, `copycat`'s own range, `Cat.cs:26413-26940`, has no
  `RPC_AddStatus` call at all.)
- **`grandCasinoArcade`'s `doom` proc uses a flat literal duration, not contested — a genuine value.**
  `Cat.cs:28048` — `this.$doomChar$21916.RPC_AddStatus("doom", this.$doomChar$21916.getStatusLv("doom") +
  1, 60, 0, this.$self_$21925.mChar.ActorNr);` — the duration argument is the bare literal `60` (confirmed
  NOT `chaAdjust`-wrapped and NOT `Damage.getDebuff`), applied to enemies hit by the AoE, mirroring the
  existing Bat doc's `darkStalker` precedent (hardcoded constant applied to a target is still usable).
- **`moonBlade`/`moonStorm`'s `cut` and `deltaStrike`'s `lock` are guaranteed on-hit procs with flat literal
  durations.** `moonBlade`: `Cat.cs:35739` — `RPC_AddStatus("cut", sLv * 2, 1, 0, ActorNr)`. `moonStorm`:
  `Cat.cs:36475` — same shape. `deltaStrike`: `Cat.cs:37186` — `RPC_AddStatus("lock", 1, 3, 0, ActorNr)`.
  All three durations are bare literals (`1`, `1`, `3`), confirmed NOT `chaAdjust`-wrapped, and are not
  gated behind any separate passive or `hasSkill` check — genuine values.
- **No `RPC_AddStatus` call exists anywhere in the coroutine class body** (confirmed by bounding each
  skill's class definition range in `Cat.cs` via `internal sealed class $RPC_<name>` markers, then
  cross-checking against the full-file `RPC_AddStatus` grep) for: `evenOdds` (`Cat.cs:9335-9378`,
  plain-method, not coroutine-classed), `lifeGamble` (`Cat.cs:22625-23147`), `skillGamble`
  (`Cat.cs:23147-23682`), `luckyDice` (`Cat.cs:23682-24447`), `doubleDown`/`doubleDown_hit`
  (`Cat.cs:24447-25518`), `copycat` (`Cat.cs:26413-26940`), `nineLives` (`Cat.cs:27238-27674`),
  `flyingDagger` (`Cat.cs:28901-29924`), `forwardLunge` (`Cat.cs:29924-31011`), `reverseThrust`
  (`Cat.cs:31011-32024`), `backflip` (`Cat.cs:32024-32652`), `heartRipper1`/`heartRipper2`/`finishingBlow1`/
  `finishingBlow2` (`Cat.cs:32652-33800`, `38095-39462`), `swiftPace` (`Cat.cs:39462-39906`), `supportFire`
  (`Cat.cs:40696-41392`) — pure-damage or pure-utility skills with no buff/debuff duration of their own.
  Duration cells are `—`. (`pillagePlunge`'s own `pillage` status, `Cat.cs:40217`, uses `Damage.getDebuff`
  and is excluded as contested, addressed separately above via the general contested-duration rule.)

### CD citations
- `awareness` CD: `Cat.cs:8574` — `this.mChar.addTimeOut("awareness", (float)1);` (bare literal, not agiAdjust-wrapped)
- `evenOdds` CD: `Cat.cs:9342` — `this.mChar.addTimeOut("evenOdds", this.mChar.agiAdjust(90f));`
- `luckyCard` CD: `Cat.cs:21090` — `this.$self_$21749.mChar.addTimeOut("luckyCard", this.$self_$21749.mChar.agiAdjust(12f + (float)(this.$sLv$21748 * 3)));` (sLv4 → 24)
- `fateDraw` CD: `Cat.cs:21554` — `this.$self_$21764.mChar.addTimeOut("fateDraw", this.$self_$21764.mChar.agiAdjust(30f));`
- `powerShuffle` CD: `Cat.cs:22394` — `this.$self_$21778.mChar.addTimeOut("powerShuffle", this.$self_$21778.mChar.agiAdjust(45f));`
- `lifeGamble` CD: `Cat.cs:22940` — `this.$self_$21786.mChar.addTimeOut("lifeGamble", this.$self_$21786.mChar.agiAdjust(30f));`
- `skillGamble` CD: `Cat.cs:23472` — `this.$self_$21793.mChar.addTimeOut("skillGamble", this.$self_$21793.mChar.agiAdjust(30f));`
- `luckyDice` CD: `Cat.cs:24162` — `this.$self_$21819.mChar.addTimeOut("luckyDice", this.$self_$21819.mChar.agiAdjust((float)60));`
- `doubleDown` CD: `Cat.cs:24684` — `this.$self_$21828.mChar.addTimeOut("doubleDown", this.$self_$21828.mChar.agiAdjust((float)30));`
- `twoPair` CD: `Cat.cs:26168` — `this.$self_$21874.mChar.addTimeOut("twoPair", this.$self_$21874.mChar.agiAdjust(120f));`
- `copycat` CD: `Cat.cs:26723` — `this.$self_$21887.mChar.addTimeOut("copycat", this.$self_$21887.mChar.agiAdjust(120f));`
- `damageRoulette` CD: `Cat.cs:27071` — `this.$self_$21895.mChar.addTimeOut("damageRoulette", this.$self_$21895.mChar.agiAdjust((float)60));`
- `nineLives` CD: `Cat.cs:27390` — `this.$self_$21901.mChar.addTimeOut("nineLives", this.$self_$21901.mChar.agiAdjust((float)60));`
- `grandCasinoArcade` CD: `Cat.cs:28612` — `this.$self_$21925.mChar.addTimeOut("grandCasinoArcade", this.$self_$21925.mChar.agiAdjust(600f));`
- `flyingDagger` CD: `Cat.cs:29750` — `this.$self_$21951.mChar.addTimeOut("flyingDagger", this.$self_$21951.mChar.agiAdjust(12f + (float)(this.$sLv$21950 * 3)));` (sLv4 → 24)
- `forwardLunge` CD: `Cat.cs:30787` — `this.$self_$21972.mChar.addTimeOut("forwardLunge", this.$self_$21972.mChar.agiAdjust(30f));`
- `reverseThrust` CD: `Cat.cs:31896` — `this.$self_$21991.mChar.addTimeOut("reverseThrust", this.$self_$21991.mChar.agiAdjust(45f));`
- `backflip` CD: `Cat.cs:32411` — `this.$self_$22006.mChar.addTimeOut("backflip", this.$self_$22006.mChar.agiAdjust((float)15));`
- `heartRipper` CD (max rank, `finishingBlow5`): `Cat.cs:38418` — `this.$self_$22173.mChar.addTimeOut("heartRipper", this.$self_$22173.mChar.agiAdjust(120f));` (rank1-2's own cast site sets `agiAdjust(60)` instead, `Cat.cs:32986` — see judgment-call note)
- `disarm` CD: `Cat.cs:34345` — `this.$self_$22066.mChar.addTimeOut("disarm", this.$self_$22066.mChar.agiAdjust(27f + (float)(this.$sLv$22065 * 3)));` (sLv2 → 33)
- `bleed` CD: `Cat.cs:35177` — `this.$self_$22096.mChar.addTimeOut("bleed", this.$self_$22096.mChar.agiAdjust(54f + (float)(this.$sLv$22095 * 6)));` (sLv2 → 66)
- `moonBlade` CD: `Cat.cs:35957` — `this.$self_$22114.mChar.addTimeOut("moonBlade", this.$self_$22114.mChar.agiAdjust(90f));`
- `moonStorm` CD: `Cat.cs:36699` — `this.$self_$22133.mChar.addTimeOut("moonStorm", this.$self_$22133.mChar.agiAdjust(120f));`
- `deltaStrike` CD: `Cat.cs:37715` — `this.$self_$22163.mChar.addTimeOut("deltaStrike", this.$self_$22163.mChar.agiAdjust((float)(60 + this.$sLv$22162 * 60)));` (sLv2 → 180)
- `swiftPace` CD: `Cat.cs:39712` — `this.$self_$22201.mChar.addTimeOut("swiftPace", this.$self_$22201.mChar.agiAdjust(90f));`
- `pillagePlunge` CD: `Cat.cs:40444` — `this.$self_$22220.mChar.addTimeOut("pillagePlunge", this.$self_$22220.mChar.agiAdjust(120f));`
- `supportFire` CD: `Cat.cs:40879` — `this.$self_$22235.mChar.addTimeOut("supportFire", this.$self_$22235.mChar.agiAdjust(240f));`

### Duration citations
- `awareness` Duration: `Cat.cs:8837` — `characterControl.RPC_AddStatus("awareness", sLv, 1, 0, this.mChar.ActorNr);` (flat literal `1`, confirmed NOT chaAdjust-wrapped; applied to nearby characters in an AoE loop — the value itself is a hardcoded constant, not target-CHA-dependent)
- `fateDraw` Duration: `Cat.cs:21461` — `this.$tChar$21759.RPC_AddStatus("fortune", this.$sLv$21763, this.$self_$21764.mChar.chaAdjust(15), 0, this.$self_$21764.mChar.ActorNr);` (default/no-passive branch; see judgment-call note re: `hasSkill(412)`)
- `powerShuffle` Duration: `Cat.cs:22082` — `this.$mDuration$21772 = this.$self_$21778.mChar.chaAdjust(30);`, applied at `Cat.cs:22110` (e.g. `RPC_AddStatus("atkUp", 1, mDuration, ..., ActorNr)`, one of 16 shared branches) (self-buff, not target-contested)
- `damageRoulette` Duration: `Cat.cs:27052` — `this.$self_$21895.mChar.RPC_AddStatus("damageRoulette", this.$sLv$21894, this.$self_$21895.mChar.chaAdjust(12), 0, this.$self_$21895.mChar.ActorNr);` (self-buff, not target-contested)
- `grandCasinoArcade` Duration: `Cat.cs:28048` — `this.$doomChar$21916.RPC_AddStatus("doom", this.$doomChar$21916.getStatusLv("doom") + 1, 60, 0, this.$self_$21925.mChar.ActorNr);` (flat literal `60`, confirmed NOT chaAdjust-wrapped)
- `moonBlade` Duration: `Cat.cs:35739` — `this.$hitChar$22106.RPC_AddStatus("cut", this.$sLv$22113 * 2, 1, 0, this.$self_$22114.mChar.ActorNr);` (flat literal `1`, confirmed NOT chaAdjust-wrapped)
- `moonStorm` Duration: `Cat.cs:36475` — `this.$hitChar$22123.RPC_AddStatus("cut", this.$sLv$22132 * 2, 1, 0, this.$self_$22133.mChar.ActorNr);` (flat literal `1`, confirmed NOT chaAdjust-wrapped)
- `deltaStrike` Duration: `Cat.cs:37186` — `this.$tChar$22142.RPC_AddStatus("lock", 1, 3, 0, this.$self_$22163.mChar.ActorNr);` (flat literal `3`, confirmed NOT chaAdjust-wrapped)
- `evenOdds`, `luckyCard`, `lifeGamble`, `skillGamble`, `luckyDice`, `doubleDown`, `twoPair`, `copycat`,
  `nineLives`, `flyingDagger`, `forwardLunge`, `reverseThrust`, `backflip`, `heartRipper`, `disarm`,
  `bleed`, `swiftPace`, `pillagePlunge`, `supportFire`: no usable Duration — either no `RPC_AddStatus` call
  exists in the skill's own coroutine class body, or the only call present is contested
  (`Damage.getDebuff`) or a dynamic status-copy (`twoPair`'s inherited `sTime - Time.time`); see the
  judgment-call notes above for the specific reason per skill.
