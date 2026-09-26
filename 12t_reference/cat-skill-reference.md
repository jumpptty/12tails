# Cat — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

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
| grandCasinoArcade | Grand Casino Arcade | 2 | 600 | true | false | — | — |
| flyingDagger | Flying Dagger | 4 | 24 (rank 1-4: 15/18/21/24) | true | false | — | — |
| forwardLunge | Forward Lunge | 2 | 30 | true | false | — | — |
| reverseThrust | Reverse Thrust | 2 | 45 | true | false | — | — |
| backflip | Backflip | 2 | 15 | true | false | — | — |
| heartRipper | Heart Ripper (60, ranks 1-2) / Finishing Blow (120) | 3 | 120 | true | false | — | — |
| disarm | Disarm | 2 | 33 (rank 1-2: 30/33) | true | false | — | — |
| bleed | Bleed | 2 | 66 (rank 1-2: 60/66) | true | false | — | — |
| moonBlade | Moon Blade | 2 | 90 | true | false | — | — |
| moonStorm | Moon Storm | 2 | 120 | true | false | — | — |
| deltaStrike | Delta Strike | 2 | 180 | true | false | — | — |
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
- **`luckyCard`'s `doom` proc is both passive-gated and target-contested — has no Duration cell in this table, on two independent
  grounds (documented in full under `cat_luckyCard` / `cat_joker5` in Damage & Mechanics below).** `Cat.cs:20870` gates the `RPC_AddStatus("doom", 1, Damage.getDebuff(...), 0, ActorNr)` call
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
- **`grandCasinoArcade`'s `doom` proc, and `moonBlade`/`moonStorm`'s `cut`/`deltaStrike`'s `lock` procs,
  are excluded (2026-08-14, at the user's request) — all four are on-hit debuffs the skill inflicts on
  an enemy target, not a duration on the caster's own skill/buff, and the lookup tool's Duration column
  is scoped to the latter.** `grandCasinoArcade`: `Cat.cs:28048` —
  `this.$doomChar$21916.RPC_AddStatus("doom", this.$doomChar$21916.getStatusLv("doom") + 1, 60, 0,
  this.$self_$21925.mChar.ActorNr);` (bare literal `60`, applied to the Cat's **own side**, itself and its allies, on a Doom spin; corrected 2026-09-25, it is not applied to enemies — see the `cat_grandCasinoArcade1-2` entry). `moonBlade`:
  `Cat.cs:35739` — `RPC_AddStatus("cut", sLv * 2, 1, 0, ActorNr)`. `moonStorm`: `Cat.cs:36475` — same
  shape. `deltaStrike`: `Cat.cs:37186` — `RPC_AddStatus("lock", 1, 3, 0, ActorNr)`. All four durations
  (`60`, `1`, `1`, `3`) are bare literals, confirmed NOT `chaAdjust`-wrapped, and not gated behind any
  separate passive/`hasSkill` check — genuinely real values, just for the wrong side of the cast (enemy-
  applied, not self/ally-applied), which is why they're reported here but not carried into the tool's
  Duration cells. Distinct from this doc's CHA-contested-duration exclusions above (`Damage.getDebuff`-
  based): these four are flat literals, not contested — excluded on scope grounds, not a contested-value
  technicality.
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
- `evenOdds`, `luckyCard`, `lifeGamble`, `skillGamble`, `luckyDice`, `doubleDown`, `twoPair`, `copycat`,
  `nineLives`, `flyingDagger`, `forwardLunge`, `reverseThrust`, `backflip`, `heartRipper`, `disarm`,
  `bleed`, `swiftPace`, `pillagePlunge`, `supportFire`: no usable Duration — either no `RPC_AddStatus` call
  exists in the skill's own coroutine class body, or the only call present is contested
  (`Damage.getDebuff`) or a dynamic status-copy (`twoPair`'s inherited `sTime - Time.time`); see the
  judgment-call notes above for the specific reason per skill.
- `grandCasinoArcade`, `moonBlade`, `moonStorm`, `deltaStrike`: excluded on scope grounds (enemy-applied
  on-hit debuff, not the caster's own duration), not because no citable value exists — see the dedicated
  judgment-call note above for the exact citations (`doom`/`cut`/`cut`/`lock`).

---

# Damage & Mechanics

Entries are being written skill by skill; every skill shown in the app needs one (no exclusions).

### cat_joker5 (402) — passive, Class C
- reqLv 55, reqBn 0, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`). The only two `hasSkill(402)` checks in the Cat source are inside `RPC_luckyCard` (`Cat.cs:20850`, `:20870`) — Joker modifies **Lucky Card only**.
- **Damage bonus:** `hitDamage = (int)(hitDamage + 0.5 × (casterLCK − targetLCK))` (`Cat.cs:20856`). Unlike the base random roll, which is floored with `Mathf.Max(…, 0)` (`:20845`), this term is **not clamped**: against a target with higher LCK than the Cat it is negative and **reduces** Lucky Card's damage. The Joker card carries a red warning for this.
- **Doom proc:** only after a real hit (`hit() != 0`, `Cat.cs:20862`), if the target does not already have `doom` (`:20876`) and `Random.Range(0,100) < lckAdjust(6)` (`:20882`): `RPC_AddStatus("doom", 1, Damage.getDebuff(30, target.cha, caster.cha), 0, casterActor)` (`:20888`) and the client message "Joker Card!" (`:20893`). The duration is CHA-contested with the **target's CHA passed first**, the same reversed order as Bat's Doom, hence `durContested` + `durContestedInverted`. The 6 is a base chance that `lckAdjust` scales with the caster's LCK, so it is shown as a chip, not typed in the desc.
- Client tooltips: TH "ทำให้การปา LuckyCard มีโอกาส 5% ทำให้เป้าหมายติด Doom1และเพิ่มความแสียหายของ LuckyCard เป็น 1.0-3.0"; EN "Increases LuckyCard's damge to 1.0~3.0 and gives it a 5% chance to inflict 'doom1' status." (`CatSkill_thai.cs` / `CatSkill_eng.cs`). Code wins: the chance is `lckAdjust(6)` not a flat 5%, and the damage change is the flat `0.5×(LCK − targetLCK)` above, not a 1.0–3.0 multiplier.

### cat_luckyCard1-4 — active, RANK FAMILY
- reqLv 3 / 9 / 15 / 21, reqBn 0 / 1 / 2 / 3, MP 2 / 3 / 4 / 5, SP **+5 / +8 / +11 / +14** (`decode_skilldata.py`). Positive SP is **blue**: a gate that is not consumed (`12Tails-Mechanics-Reference.md` §Red/Blue SP, `GameGui.cs:37609`). Mode target, enemy, `cType luckyCard`.
- **Cooldown:** `addTimeOut("luckyCard", agiAdjust(12 + 3×sLv))` → 15 / 18 / 21 / 24s (`Cat.cs:21090`). Revised Art applies. **No cast time** — the coroutine is animation only (`:21059`, no `magAdjust`).
- **Range:** the cast is refused unless the target is within 20m (`sqrMagnitude < 400`, `Cat.cs:7804`). The attack is a **hitscan**, not a projectile: one ray of length 20 from 1.2m above the caster toward the target collider's centre (`:20593-20609`, `:20790`), ignoring the caster's own layer and layers 1 and 2 (`:20780`). A collider without a `CharacterControl` takes no damage (`:20837`).
- **Damage:** `hitDamage = (int)(0.5×ATK + Random.Range(0, max((0.5×sLv + 0.5) × (casterLCK − targetLCK), 0)))` (`Cat.cs:20845`) — the random ceiling is 1.0 / 1.5 / 2.0 / 2.5 times the LCK lead, floored at 0 (`Mathf.Max`). It then goes through `hit(200+sLv, target, dmg, KO 1, Hate 0, forward)` (`:20862`), i.e. the normal `dmgAdjust` → `defAdjust` → `hitMod` pipeline.
- **On a real hit only** (`hit() != 0`, `Cat.cs:20862-20865`, otherwise `goto IL_69C`): the caster gains **+1 SP** (`:20901`) and the Joker roll below runs.
- **Joker (`hasSkill(402)`):** adds `(int)(hitDamage + 0.5×(casterLCK − targetLCK))` (`:20856`) — **not clamped**, so it *reduces* damage when the target has more LCK than the Cat — and rolls `Random(0,100) < lckAdjust(6)` for `doom` level 1 (`:20870-20893`). Full detail in the `cat_joker5` entry above.
- **Cosmetic only:** a coin flip (`Random.Range(0,2)`, `:20683`) picks one of two card effect variants.
- **Tooltips:** ranks 1–4 say "random damage based on lck (0 ~ 1.0 / 1.5 / 2.0 / 2.5 x lck)" (`CatSkill_thai.cs` / `_eng.cs`). The code differs in three ways the tooltip omits: there is a hidden base of `0.5×ATK`; the LCK term is the **difference** from the target's LCK, not the caster's raw LCK; and it is floored at 0.
- **App modeling:** `dmg:"0"` + `atkCoeff:0.5`, `lckDiffCoeff` (the random ceiling) and `lckDiffDep` (Joker), read against the **Enemy Stats LCK** input. The default enemy preset is Carron with LCK 2, so out of the box the difference is roughly the player's own LCK − 2. See `GEMINI.md` §4 (LCK-difference fields).

### cat_fateDraw1-4 — active, RANK FAMILY
- reqLv 5 / 11 / 17 / 23, reqBn 1 / 3 / 5 / 7, MP 4 / 6 / 8 / 10, SP 0, mode instant, target ally (`decode_skilldata.py`).
- **Cooldown:** `addTimeOut("fateDraw", agiAdjust(30f))` (`Cat.cs:21554`), Revised Art applies. **No cast time** — the coroutine does no `magAdjust` wait, animation only.
- **Area:** `Damage.FindAreaTarget(position, 15 × rangeMod, 3 × rangeMod, 1 << caster.layer)` (`Cat.cs:21405-21413`) — a 15m-radius, 3m-high cylinder (horizontal distance measured to the collider edge, vertical overlap check, `Damage.cs:963-1120`). `(layerMask & 1 << target.layer) != 0` (`Damage.cs:1052`) keeps only the caster's own layer: the Cat and its allies.
- **Effect:** `RPC_AddStatus("fortune", sLv, chaAdjust(15), 0, ActorNr)` (`Cat.cs:21461`). Duration is the caster's CHA-based `chaAdjust(15)`, not contested by the target.
- **`fortune` status:** add `deltaLck(sLv × 10)` (`CharacterControl.cs:36235-36247`), removal `deltaLck(−sLv × 10)` (`CharacterControl.cs:16212`) → LCK +10 / +20 / +30 / +40. Classified **Buff, Magical**: in `isMagicalStatus` (`StatusData.cs:5693`) and `isBuffStatus` (`StatusData.cs:6650`).
- **Lady Luck (`hasSkill(412)`)** branch: `RPC_AddStatus("fortune", sLv + 1, chaAdjust(30), …)` (`Cat.cs:21447-21453`) — status level +1 (rank 4 → +50 LCK) and doubled duration. The second `hasSkill(412)` check (`Cat.cs:21575`) only selects the `ladyLuck_ring` VFX — cosmetic.
- **Tooltips:** EN "Perform a move that gives Cat and nearby allies 'fortune1' status, increasing luck by 10. (15 sec)" (`CatSkill_eng.cs:264-297`); TH "สกิลที่ทำให้แมวและเพื่อนใน ระยะติดสถานะ fortune1 ชั่วขณะหนึ่ง (+10 lck, 15 sec)" (`CatSkill_thai.cs:286-319`). The tooltip's 15 sec is the base `chaAdjust(15)`; the 15m ally-only area is not mentioned.
- **App modeling:** `CAT_LADYLUCK_DEP` toggle (`kind:"replace"`, `replaceValue:30`) swaps the duration base 15 → 30 (still `chaAdjust`-wrapped) and bumps the `fortune` status level by +1 via `descDep`/`status.sLv`; `status:{name:"fortune"}` badge, `STATUS_CLASS_MAP` / `STATUS_DESC_MAP` entries for `fortune`.

### cat_ladyLuck5 (412) — passive, Class C
- reqLv 60, reqBn 1, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`). Both `hasSkill(412)` checks in `Cat.cs` are inside `RPC_fateDraw` (`:21447`, `:21575`): it modifies **Fate Draw only** (status level +1, duration `chaAdjust(30)` instead of `chaAdjust(15)`; the second check is only the `ladyLuck_ring` VFX).
- Tooltips: EN "Increses the effect of FateDraw for by 1 level and doubles its duration." (`CatSkill_eng.cs:950`); TH "เพิ่มผลของ FateDraw ขึ้น 1 เลเวลและยืดระยะเวลาขึ้น สองเท่า" (`CatSkill_thai.cs:972`).

### cat_luckyDice1-2 — active, RANK FAMILY
- reqLv 9 / 15, reqBn 3 / 5, MP 8 / 12, SP **-12 / -16** (`decode_skilldata.py`). Negative SP is **red**: consumed on cast. Mode target, enemy, `cType luckyDice`.
- **Cooldown:** `addTimeOut("luckyDice", agiAdjust(60))` (`Cat.cs:24162`), Revised Art applies. **No cast time** — animation only; damage resolves ~0.5s after the throw starts (0.4s + 0.1s waits, `Cat.cs:23682-24447`).
- **Area:** `Damage.FindAreaTarget(mPos, 6, 5, 130816 - (1 << caster.layer))` (`Cat.cs:23929-23934`) — radius 6, height 5, centred on the cat, every layer except the caster's own (enemies). Radius is a flat 6: no `rangeMod`.
- **Damage:** `hitDmg = Random.Range(0, sLv × mChar.lck) + (hasSkill(432) ? mChar.lck : 0)` (`Cat.cs:23939`). No ATK term. `Random.Range(int, int)` **excludes the upper bound**, so the real range is `0 … sLv×LCK − 1` (tooltip says `0 ~ 1.0 / 2.0 × lck`). `mChar.lck` is the live LCK including buffs (e.g. `fortune`). The roll is made **once, before the target loop** — every enemy in range takes the same number. It then goes through `hit(230+sLv, target, dmg, KO 1, Hate 0, forward)` (`:23962`), the normal `dmgAdjust → defAdjust → hitMod` pipeline; the Cat gains **+1 SP per target hit** (`:23968`).
- **Tooltips:** EN "Perform a move that deals random damage to nearby enemies (0 ~ 1.0 x lck)." / `(0 ~ 2.0 x lck)` (`CatSkill_eng.cs:352`, `:363`); TH "โยนลูกเต๋าออกไปทำความ เสียหายแบบสุ่มตัวเลข รอบๆ ตัวแมว (0 ~ 1.0 x lck)" / `(0 ~ 2.0 x lck)` (`CatSkill_thai.cs:374`, `:385`). Omitted by the tooltip: the 6m radius, the shared roll, the exclusive maximum, the +1 SP per hit.
- **App modeling:** reuses Lucky Card's LCK-difference mechanism with two flags — `lckDiffOwn` (the roll reads the caster's own LCK; target LCK = 0) and `lckDiffExclusive` (displayed max one lower) — and `CAT_ROLLTHEDICE_DEP` (`coeff:1`) as the `lckDiffDep`. Range at LCK 128: rank 1 `0-127`, rank 2 `0-255`; with Roll the Dice `128-255` / `128-383`.

### cat_rollTheDice5 (432) — passive, Class C
- reqLv 75, reqBn 4, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`). The only two `hasSkill(432)` consumers are Lucky Dice and Double Down.
- **Lucky Dice:** adds a flat `+LCK` to the roll (`Cat.cs:23939`) — both ends move, so the range becomes `LCK … (sLv+1)×LCK − 1` (tooltip: "1.0~3.0", the rank 2 result).
- **Double Down:** the range/size variable `mRange` goes 1 → 2 (`Cat.cs:25389-25396`) and the hit's KO becomes `sLv×3 + 2 + (hasSkill(432) ? 2 : 0)` (`Cat.cs:25358`) — "Doubles the size of DoubleDown and its ko damage". The Thai tooltip calls Double Down "Cacton".
- Tooltips: EN "Increases the damage of LuckyDices to 1.0~3.0. Doubles the size of DoubleDown and its ko damage." (`CatSkill_eng.cs:972`); TH "เพิ่มความเสียหายของ LuckyDices เป็น 1.0~3.0 ขยายขนาดของ Cacton ขึ้น 2 เท่าและเพิ่ม ko ขึ้นอีก 2" (`CatSkill_thai.cs:990`).

### cat_nAttack1-3 — Combo, normal-attack rank family
- **Rank meaning:** the three learnable entries unlock the 2nd / 3rd / 4th combo stage; Combo rank 1 therefore performs stages 1–2, rank 2 adds stage 3, and rank 3 adds stage 4 (`CatSkill_eng.cs:33-64`, `Cat.cs:8022-8183`). The shared normal-attack timeout is a flat 1.5 seconds (`Cat.cs:16848`, `17091`, `17801`, `18740`).
- **Raw strike sequence:** stage 1 = `floor(0.5×ATK)` (`Cat.cs:16502`); stage 2 = `floor(0.5×ATK)` (`:17300`); stage 3 has two hit passes, `floor(0.3×ATK)` then `floor(0.4×ATK)` (`:17978`, `:18239`); stage 4 has two, `floor(0.2×ATK)` then `floor(0.6×ATK)` (`:18949`, `:19208`). Each pass calls the normal `hit()` pipeline, so it independently consumes one Charge stack when present.
- **KO value:** Every landed Combo hit deals a flat **1 KO** (`nKo = 1`, `Cat.cs:16694`, `17447`, `18135`, `18378`, `19111`, `19352`). Hidden Blade replacement hits also deal **1 KO** (`:16622`, `:17390`, `:18068`, `:18313`, `:19047`, `:19288`).
- **Hidden Blade replacement:** `getHiddenBladeDmg()` is `talAdjust(10×hiddenBladeLv)` (`Cat.cs:10051-10055`). Its ordinary ranks are skills 331–334; Class-C **Jagged Knife** (skill 433) makes `getHiddenBladeLv()` return 5 (`Cat.cs:9996-10046`, `CatSkill.cs:3311`) and widens the facing check from <45° to <75°. On a non-structure target meeting that check, the corresponding normal pass calls action 331–334 with `raw + hiddenBladeDamage` and skips the ordinary normal hit (`Cat.cs:16618-16694`, `:17386-17447`, `:18064-18135`, `:19039-19111`). Thus it is a **replacement strike**, not an additional strike. Its actions are >=10, so No Chance does not affect it.
- **Power / Charge / No Chance order:** Cat Power effects floor the raw hit first in `CharacterControl.hit()` (`CharacterControl.cs:2850-3014`); the `damagePlus` status then adds `10×status.sLv` and spends one `sValue` stack (`:3447-3474`); finally No Chance applies only to action codes <10 as `ceil(damageMod×nDamage + 0.3×LCK)`, otherwise ordinary `dmgAdjust` runs (`:3513-3546`). This means Charge is not multiplied by Power, and Hidden Blade uses ordinary random `dmgAdjust` even when No Chance is learned.

### cat_cAttack1-3 / cat_doubleFocus5 — Charge Attack and Double Focus
- `getChargeLv()` resolves charge ranks 1/2/3 from skills 111/112/113 (`Cat.cs:8505-8544`). Charge lasts `chaAdjust(12)` seconds and supplies `damagePlus` at that rank (`Cat.cs:19723`, `:19733`, `:20031`). Each stack gives `+10×chargeRank` raw damage to the next `hit()` call and is consumed there (`CharacterControl.cs:3447-3474`).
- Without Double Focus, each one-second charge tick adds one stack, capped at `chargeRank+1`: rank 1/2/3 gives +10/+20/+30 on a maximum 2/3/4 hits. With Double Focus (skill 411), the effective charge level is +2 and each tick adds two stacks (`Cat.cs:19733`, `:19976`, `:20031`), producing +30/+40/+50 on a maximum 4/5/6 hits.

### cat_noChance5 (401) — passive, Class C
- reqLv 55, reqBn 0, MP 0, SP 0, mode passive, required skill 103 (Combo Lv 3, `cat_nAttack3`), no cType (`decode_skilldata.py`, `CatSkill.cs:962-984`, `3172`).
- **Normal Attack LCK Damage Override:** The only `hasSkill(401)` check in the game engine is in `CharacterControl.cs:3513-3537` inside `CharacterControl.hit(int actionCode, ...)`:
  ```csharp
  if (this.Type == "Cat")
  {
      if (this.hasSkill(401))
      {
          if (actionCode < 10)
          {
              nDamage = Mathf.CeilToInt(Mathf.Clamp(this.damageMod, 0f, 5f) * (float)nDamage + 0.3f * (float)this.lck);
              goto IL_1549; // jumps directly to defAdjust, skipping dmgAdjust!
          }
      }
  }
  nDamage = this.dmgAdjust(nDamage);
  IL_1549:
  nDamage = characterControl.defAdjust(nDamage);
  ```
- **Mechanics Breakdown:**
  - **Normal behavior without No Chance:** Outgoing damage goes through `CharacterControl.dmgAdjust` (`CharacterControl.cs:20487-20491`), which adds `(float)Random.Range(0, Mathf.CeilToInt(0.2f * (float)this.lck))`. This is a random roll from 0 up to `0.2 × LCK` (exclusive integer ceiling).
  - **With No Chance:** For basic combo strikes (`actionCode < 10`: Cat's `nAttack1`..`nAttack4` pass action codes 1, 2, 3, 4; `Cat.cs:16694`, `17447`, `18135`, `18378`, `19111`, `19352`), the code explicitly adds a flat **`+ 0.3 × LCK`** and immediately executes `goto IL_1549`, completely **bypassing `dmgAdjust`**.
  - **Zero Variance:** Eliminates all RNG from the LCK roll on normal attacks.
  - **Scope Limitation:** Special procs such as Hidden Blade pass `actionCode = 333` (`Cat.cs:18068`, `18313`, `19047`), which is `>= 10` and therefore does **not** receive this bonus.
- **Client Tooltips:**
  - EN: *"Gives Cat's normal attack the ability to always deals maximum luck damage."* (`CatSkill_eng.cs:884`).
  - TH: *"ทำให้การโจมตีปกติของแมวให้ผลสุ่มสูงสุดจากค่า Lck เสมอ "* (`CatSkill_thai.cs:906`).
  - Note: Code gives `+0.3 × LCK`, which actually exceeds the normal `0.2 × LCK` random ceiling and is completely deterministic.
- **App modeling:** `cat_noChance` (`passive: true`, `compatSkills: ["cat_nAttack"]`), cross-linked with `cat_nAttack` (`compatSkills: ["cat_noChance"]`). Mentions and links Hidden Blade for clarification.

### cat_powerOne1 / cat_powerTwo2 / cat_powerThree3 / cat_powerSeven4 / cat_superSeven5 (241/242/243/244/442) — passive family
- **Metadata:** all are single-rank passive skills with no MP/SP cost or `cType`. Requirements: Power One Lv16/Bn4, Power Two Lv20/Bn8, Power Three Lv24/Bn12, Power Seven Lv28/Bn16, Super Seven Lv85/Bn6 (`scripts/decode_skilldata.py DecompiledSource/CatSkill.cs`). Every matching icon is present in the Cat asset folder and embedded as `cat_powerOne1`, `cat_powerTwo2`, `cat_powerThree3`, `cat_powerSeven4`, and `cat_superSeven5` in the Bible.
- **Single shared hook:** the mechanics are not in `Cat.cs`; `CharacterControl.hit(...)` applies them to any Cat hit against another Player/Enemy before the ordinary attacker-side `dmgAdjust` step (`CharacterControl.cs:2807-3014`). Each matching condition replaces raw `nDamage` with `floor(nDamage × multiplier)`:
  ```csharp
  if (this.hp % 10 == 7 && this.hasSkill(244)) nDamage = Mathf.FloorToInt(nDamage * 1.7f);
  if (this.hp % 10 == 3 && this.hasSkill(243)) nDamage = Mathf.FloorToInt(nDamage * 1.3f);
  if (this.hp % 10 == 2 && this.hasSkill(242)) nDamage = Mathf.FloorToInt(nDamage * 1.2f);
  if (this.hp % 10 == 1 && this.hasSkill(241)) nDamage = Mathf.FloorToInt(nDamage * 1.1f);
  ```
  The modified hit then continues through the normal `dmgAdjust → target.defAdjust → hitMod` pipeline. The floor occurs **before** outgoing LCK spread and defense mitigation, so this is not the generic `damageMod` multiplier.
- **Super Seven override:** `hasSkill(442)` is checked *before* the four exact-last-digit checks. It tests digit positions 0-3 individually; any is 7 gives `floor(nDamage × 1.7)` (`CharacterControl.cs:2850-2912`). `Math.getDigit(num, pos)` first takes `abs(num) / 10^pos`, floors it, then returns `% 10`, so Super Seven matches 7 in the ones, tens, hundreds, or thousands place only (`Math.cs:656-660`). It does **not** check `hasSkill(244)`: Super Seven independently grants the 1.7× effect whenever one of those four HP digits is 7. Its tooltip understates this as merely enabling Power Seven.
- **Priority:** Super Seven wins and jumps past every normal Power check; otherwise Power Seven, Three, Two, then One are mutually exclusive because a number has one final digit. At raw damage 1-9, `floor` can make the displayed increase smaller than the nominal percentage.
- **Client tooltips:** EN: Power One “Passively increases Cat's damage by 10% when last digit of its hp is equal to 1.” (`CatSkill_eng.cs:396-405`); Two 20% (`:407-416`); Three 30% (`:418-427`); Seven 70% (`:429-438`); Super Seven “Passively enables PowerSeven to activate when there's a number 7 in Cat's hp.” (`:979-988`). Thai equivalents are at `CatSkill_thai.cs:418-461` and `:1001-1010`.
- **App modeling:** use five passive cards with no cost, cooldown, duration, or status chips. Each description must state its exact HP-digit condition and `floor(raw × multiplier)` ordering; Super Seven needs a reciprocal `compatSkills` link to Power Seven and an explicit note that it triggers from any 7 among the last four HP digits without requiring Power Seven.

### cat_nineLives1-2 (263, 264) — passive, RANK FAMILY
- reqLv 30 / 35, reqBn 21 / 23, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`, `CatSkill.cs:565-583`, `:2794-2815`).
- **Trigger Logic:** Located in `Cat.cs:207-366` inside `Cat.Update()` when `hp <= 0` and `actionState != "dead"`:
  ```csharp
  int nineLivesLv = this.getNineLivesLv(); // returns 1 if hasSkill(263), 2 if hasSkill(264)
  // Evaluated after blackServant, autoLife, and Small Anubi pet (p_sab):
  if (UnityEngine.Random.Range(0, 100) < this.mChar.lckAdjust(nineLivesLv * 6))
  {
      if (this.mChar.getStatus("death") == null)
      {
          this.StartCoroutine_Auto(this.RPC_nineLives(this.KOIRnET4pM.position, this.KOIRnET4pM.forward, 0, nineLivesLv));
          if (PhotonClient.IsInitialized())
          {
              this.ActionEvent("RPC_nineLives" + nineLivesLv, this.KOIRnET4pM.position, this.KOIRnET4pM.forward, 0);
          }
          break; // prevents RPC_dead
      }
  }
  ```
- **Base Chance & LCK Scaling:**
  - Rank 1 (`nineLivesLv = 1`): Base chance = `1 × 6 = 6%`
  - Rank 2 (`nineLivesLv = 2`): Base chance = `2 × 6 = 12%`
  - Scaled by `mChar.lckAdjust(nineLivesLv * 6)` using the character's LCK:
    `num = baseChance × (1 + 0.01 × Clamp(LCK, 1, 512))`
    `Proc% = Floor(100 × num / (num - baseChance + 100))`
- **Revive Sequence & Effects (`Cat.cs:27238-27645`, `$RPC_nineLives$21898`):**
  1. Cat collapses to the ground (`hp = 0`, `actionState = "dead"`, plays animation `"ko"` with `deadEffect`) and lies motionless for **3.0 seconds** (`Yield(2, WaitForSeconds(3f))`).
  2. At 3.0s, Cat revives with:
     - `hp = 99` (revives with flat 99 HP).
     - `ko = mChar.mko` (fully restores KO bar).
     - `mChar.actionState = "attack"`, `myCommand = "nineLives"`.
     - Status: `addStatus("noDamage", 1, 3, 0, ActorNr)` gives **3.0 seconds of invulnerability** (`noDamage`).
     - Plays animation `"getUp"` (1.0s wait) with randomized voice line (`nineLives1` or `nineLives2`).
  3. Returns to `actionState = "standby"`.
- **Internal Cooldown (Bug / Missing Check):**
  - In `RPC_nineLives` (`Cat.cs:27390`), the code calls:
    `this.$self_$21901.mChar.addTimeOut("nineLives", this.$self_$21901.mChar.agiAdjust((float)60));`
    intending a 60-second cooldown scaled by AGI (`agiAdjust(60)`).
  - **However, `Cat.cs:334` NEVER checks `isTimeOut("nineLives")` before proccing!** There is not a single `isTimeOut("nineLives")` check anywhere in the game codebase.
  - **Net Result:** There is **NO functional internal cooldown**. Once the 3-second `noDamage` invulnerability ends, if the Cat suffers lethal damage again, Nine Lives can proc again immediately if the LCK roll succeeds.
- **Client Tooltips:**
  - EN: *"Passively gives Cat a 6% change to revive when it dies."* / *"12% change"* (`CatSkill_eng.cs:510`, `:521` — source has typo "change" for "chance").
  - TH: *"ทักษะติดตัวที่ทำให้แมวมีโอกาส 6% ที่จะฟื้นคืนชีพ เมื่อตาย"* / *"12%"* (`CatSkill_thai.cs:532`, `:543`).

### cat_grandCasinoArcade1-2 (235, 236) — active, RANK FAMILY
- **Classification & Requirements:**
  - Cat Skill Tree A (Gambler branch), commandNum 235 (Rank 1) and 236 (Rank 2) (`CatSkill.cs:2820-2831`).
  - Target: `enemy`, mode: `instant`, cType: `grandCasinoArcade`.
  - Rank 1 (`cat_grandCasinoArcade1`): Lv 35, Bn 23, MP 30, SP 55 (`SP: -55`) (`CatSkill.cs:586-602`).
  - Rank 2 (`cat_grandCasinoArcade2`): Lv 40, Bn 25, MP 50, SP 75 (`SP: -75`) (`CatSkill.cs:603-610`).
- **Cooldown:**
  - 600 seconds (10 minutes) across both ranks (`Cat.cs:28612` — `this.$self_$21925.mChar.addTimeOut("grandCasinoArcade", this.$self_$21925.mChar.agiAdjust(600f));`).
  - Scales with AGI (`agiAdjust(600)`). Not exempt from Revised Art.
- **Channel / Invulnerability Window (`Cat.cs:28633-28636`):**
  - Upon cast, Cat enters an arcade machine animation lockout and receives two simultaneous self-buffs:
    - `addStatus("noDamage", 1, sLv * 5 + 7, 0, ActorNr)`: no damage taken. Checked in `RPC_AddDamage` (`CharacterControl.cs:3724`) and `RPC_AddEffectDamage` (`:6122`), so it blocks Effect Damage too.
    - `addStatus("noForce", 1, sLv * 5 + 7, 0, ActorNr)`: complete immunity to knockback/push forces.
  - Duration: `sLv * 5 + 7` seconds (Rank 1: **12 seconds**; Rank 2: **17 seconds**). A literal, not `chaAdjust`.
  - Both statuses appear only in `isSystemStatus` (`StatusData.cs:4630`, `:4648`) and `isBuffStatus` (`:6338`, `:6356`): **Buff, System**.
- **Spins & Hit Count (`Cat.cs:27956`, `:28303`, `:28507`, `:28596`):**
  - Loop index `$i$21911` runs from `0` to `sLv * 2`:
    - Rank 1 (`sLv = 1`): `i = 0, 1, 2` -> **3 spins / 3 hits** (`sLv * 2 + 1 = 3`).
    - Rank 2 (`sLv = 2`): `i = 0, 1, 2, 3, 4` -> **5 spins / 5 hits** (`sLv * 2 + 1 = 5`).
  - Timing (`Cat.cs:28779-28809`): 0.4 s + 1.3 s of set-up, then each spin waits 2.0 s before its roll and 0.7 s after it (0.4 s after the last one).
- **Slot RNG & Damage Breakdown (`Cat.cs:27993-28265`):**
  - On each spin, independent RNG roll:
    `mCasinoResult = UnityEngine.Random.Range(0, Mathf.Clamp(mChar.lck, 0, 255));`
    Note: `Random.Range(int, int)` is upper-bound exclusive, so range is `0 .. Clamp(LCK, 0, 255) - 1`.
  - Outcomes:
    1. **Roll `< 5` ("Casino Doom!"):**
       - No damage: `hitDamage` stays 0, so the `hit()` loop is skipped entirely (`Cat.cs:28209`).
       - Every character on the Cat's **own layer** (itself and its allies) within `radius 24m, height 12m` gets `RPC_AddStatus("doom", target.getStatusLv("doom") + 1, 60, 0, ActorNr)`: one Doom level above what that target already has, for a flat 60 s (`Cat.cs:28009-28048`, `Damage.FindAreaTarget(position, 24, 12, 1 << Cat.gameObject.layer)`).
       - The 60 s is not contested and not `chaAdjust`ed. The only change is on the receiving side inside `RPC_AddStatus`: a Wolf with Fortitude (#421) gets `⌈0.75 × 60⌉ = 45 s` (`CharacterControl.cs:13421-13434`). What Doom does on expiry is in [12Tails-Mechanics-Reference.md §4.1](12Tails-Mechanics-Reference.md#41-status-effect-catalog-statusdatagetstatuscode-statusdatacs): Casino Doom's owner is the Cat, so it only explodes if the Cat is alive when it runs out.
       - If Cat's LCK is **≤ 5**, every roll is `< 5` (`Random.Range(0, 5)` tops out at 4; `Range(0, 0)` returns 0), so 100% of spins are Doom.
    2. **Roll `5 .. 49` ("Casino 111"):**
       - Raw damage = `111`.
       - Every non-structure enemy within `radius 24m, height 12m` takes `hit(270 + d, target, 111 × d, 1, 0, Vector3.zero)` with `d` = 1 / 2 / 3 / 7 for 111 / 222 / 333 / 777 (`Cat.cs:28215-28265`; enemy mask `130816 − (1 << layer)`).
    3. **Roll `50 .. 89` ("Casino 222"):**
       - Raw damage = `222`.
       - Inflicts `hit(272, target, 222, KO: 1, Hate: 0, Vector3.zero)` to all enemies within 24m.
    4. **Roll `90 .. 119` ("Casino 333"):**
       - Raw damage = `333`.
       - Inflicts `hit(273, target, 333, KO: 1, Hate: 0, Vector3.zero)` to all enemies within 24m.
    5. **Roll `≥ 120` ("Casino 777" - Jackpot!):**
       - Raw damage = `777`.
       - Inflicts `hit(277, target, 777, KO: 1, Hate: 0, Vector3.zero)` to all enemies within 24m. Requires `LCK ≥ 121` to be rolled.
- **Outcome odds:** with `n = clamp(LCK, 0, 255)`, each outcome's chance is (rolls in its band that are `< n`) / `n`. Example at LCK 150: Doom 5/150 = 3.3%, 111 45/150 = 30%, 222 40/150 = 26.7%, 333 30/150 = 20%, 777 30/150 = 20%. The cap of 255 gives a best case of 777 = 135/255 = 52.9% and Doom = 5/255 = 2.0%.
- **Power Number Synergy (`CharacterControl.cs:2838-3010`):**
  - Every Casino hit goes through `hit()`, so the Power Number passives (`Power One` `1.1×`, `Power Two` `1.2×`, `Power Three` `1.3×`, `Power Seven / Super Seven` `1.7×`) apply whenever the Cat's HP digit matches. On TTO this still holds, because Grand Casino Arcade is a Tree A skill (see Server Balance Variations).
  - For the same reason each hit also consumes one Cat Charge (`damagePlus`) stack and adds its `10 × level` (`CharacterControl.cs:3447-3474`). The tool does not model Charge on this card.
  - When Power Seven is active (`1.7×`):
    - 111 -> 188
    - 222 -> 377
    - 333 -> 566
    - 777 -> 1,320
- **KO & Defense Pipeline:**
  - Each hit inflicts `KO = 1`.
  - Raw hit proceeds through standard `dmgAdjust → defAdjust → hitMod`.
- **Client Tooltips:**
  - EN: *"Summon a grand casino that randomly deals 111~777x3 damage to all nearby enemies."* / *"111~777x5"* (`CatSkill_eng.cs:528-545`).
  - TH: *"เรียกคาสิโนขนาดยักษ์ขึ้นมา สุ่มทำความเสียหายเป้าหมาย ในระยะ (111~777 dmg x3)"* / *"(111~777 dmg x5)"* (`CatSkill_thai.cs:550-567`).

### cat_deltaStrike1-2 — active, RANK FAMILY
- **Skill data:** rank1 reqLv 35/reqBn 23, rank2 reqLv 40/reqBn 25, MP 30 both ranks, SP **-45 / -60** (red, consumed) (`decode_skilldata.py`, `CatSkill.cs`). Mode `instant` (no cast bar), target `enemy`, `cType deltaStrike`. Skill Tree B (Assassin/dagger branch) — not in the app's `CAT_TREE_A_SKILLS` set, so it is correctly excluded from the TTO Power Number restriction automatically.
- **Cast/CD:** `Cat.cs:37715` — `addTimeOut("deltaStrike", agiAdjust(60 + sLv×60))` → 120 / 180. The Cat teleports to a pre-computed landing position near the target (`KOIRnET4pM.position = mPos`, `Cat.cs:37720`) — a gap-closer/blink strike, not a stationary AoE.
- **Hit-box geometry (`Cat.cs:37136`, re-run at `:37220`, `:37385`, `:37574`):** `Damage.FindRecTarget(pos, forward, BaseWidth=1, TopWidth=(3×sLv+3), TargetRange=(2×sLv+4), TargetHeight=6, hitLayer)`. Per the verified `FindRecTarget` convention (§4 of `12Tails-Mechanics-Reference.md`, width args are half-widths), this is a literal triangle widening from **2m** full width at the caster to **12m** (rank1) / **18m** (rank2) at the far end, reaching **6m** (rank1) / **8m** (rank2), height **6m** — matches the skill's own name and both client tooltips ("cut a dimensional rift... triangle shape").
- **Damage — 7 hits per target across a real ~2.9s timed sequence, corrected 2026-09-26 (initially miscited as a single hit; the coroutine's `return this.Yield(state, new WaitForSeconds(x))` calls are real per-state waits, not same-frame fallthrough — every state below is its own timed step, not an instant):**
  - `Cat.cs:37700-37850` (state 0): teleport to target, play cast animation/VFX/voice.
  - → 0.3s (`Yield(2,0.3f)` `:37963`) → state 2: apply `lock` #1 (`:37186`).
  - → 0.5s (`Yield(3,0.5f)` `:37969`) → state 3: apply `lock` #2 (`:37265`).
  - → 0.5s (`Yield(4,0.5f)` `:37954`) → state 4: apply `lock` #3, spawn dual afterimages (`:37430`).
  - → 0.2s (`Yield(5,0.2f)` `:37986`) → state 5: spawn the main triangle VFX (1.5× scale at rank 2).
  - → 0.6s (`Yield(6,0.6f)` `:37980`) → state 6: `$i=0` (`:37532`), enters the tick loop at label `IL_D65` (`:37871-37878`, exits when `i>=6`).
  - **6× tick loop, 0.1s apart** (state 7 increments `$i` at `:37541`, `Yield(7,0.1f)` `:37967`): each iteration re-runs `FindRecTarget` fresh (so a target can leave/enter the zone between ticks) and calls `hit(370+sLv, target, (int)(0.5×ATK), nKo=1, nHate=0, Vector3.up)` (`:37921`) — **no `talAdjust` term at all: this tick's damage does not scale with rank.**
  - → 0.2s (`Yield(8,0.2f)` `:37988`) → state 8: **finishing hit** `hit(372+sLv, target, (int)(0.5×ATK + talAdjust(90×sLv+90)), nKo=1, nHate=0, Vector3.up)` (`:37597`) — the only rank-scaling hit, and the only one matching the client tooltip's flat `+135`/`+180` framing.
  - → 0.1s (`Yield(9,0.1f)` `:37992`) → state 9: wrap up, end action.
  - Total: **6× `0.5×ATK` ticks + 1× `0.5×ATK + talAdjust(90×sLv+90)` finisher = 7 hits**, all requiring the target to still be inside the (re-computed each tick) triangle zone. The `lock` root's own 3s duration (see below) almost exactly spans this whole sequence, releasing right as the finisher lands. `nHate=0` on both hit calls is **not** a distinguishing trait of this skill — every other `.mChar.hit(...)` call across `Cat.cs` also passes `0` for that argument, and `CharacterControl.cs:3771` recomputes the real hate as `nDamage + nHate + nKo×10` regardless, so Delta Strike generates ordinary damage-based hate like any other Cat skill.
- **`lock` status — root, but NOT the same list as `isLockStatus`/`removeLockStatus` (verified via the full Dead Code Verification Gate sweep, same class of quirk as `frost`):**
  - Applied 3 times during the ~1.3s windup, before any damage lands (`Cat.cs:37186`, `:37265`, `:37430`, redundant/harmless re-application — see the corrected 7-hit timeline above): `RPC_AddStatus("lock", 1, 3, 0, ActorNr)` — bare literal duration `3`, confirmed not `chaAdjust`-wrapped.
  - `StatusData.isDebuffStatus("lock")` → true (`StatusData.cs:7286`). Not present in `isBuffStatus`, `isPhysicalStatus`, `isMagicalStatus`, `isStateStatus`, `isShieldStatus`, **or `isLockStatus`** (whose full list is `{groundLock, needlePrison, sticky, frost, lightBind}` — `"lock"` itself is a different, unlisted string despite the near-identical name). Classification used on the card: **`Debuff`** only.
  - **Real apply-site** (`CharacterControl.cs:2278-2298`, the generic per-status-type switch, checked per the same precedent this doc's `frost` note already establishes): `sType=="lock"` hard-sets `moveSpeed=0` and zeroes `myForce.x`/`myForce.z` — mechanically an identical root to `frost`/`groundLock`.
  - **Provably uncleansable by the game's own lock-cleanse mechanic:** `removeLockStatus(nLv)` (`CharacterControl.cs:19456-19519`) only ever checks/removes `groundLock`, `needlePrison`, `sticky`, `frost`, `lightBind` — never `"lock"`, at any level. This function is not theoretical/dead — it's called by Cat's own Backflip on itself (`Cat.cs:32432` — `removeLockStatus(sLv×2 + (hasSkill(423)?1:0))`, confirmed by the `PlayAnimation("backflip")` two lines above). So a Cat rooted by an enemy's Delta Strike who casts Backflip to escape will not have the `lock` status removed by that call, regardless of Backflip's rank — the root only ends when its flat 3s duration expires.
- **Client tooltips:** TH (`CatSkill_thai.cs:884`/`:895`): *"ตัดห้วงมิติด้านหน้าเป็นรูปสามเหลี่ยม หยุดและทำร้ายเป้าหมายในพื้นที่ (+135 dmg)"* / *"(+180 dmg)"*. EN (`CatSkill_eng.cs:862`/`:873`): *"Cut out a triangle dimention, trapping and dealing damage to targets inside (135 dmg)."* / *"(180 dmg)."* The flat `+135`/`+180` figures are the client's own approximate baseline (do not match `talAdjust(90×sLv+90)` at base TAL) — code wins per repo convention.
- **No dependency wiring:** no passive in `CatSkill.cs`/`Cat.cs` references `deltaStrike` as a `hasSkill` check, and it has no `rSkill` prerequisite of its own (`CatSkill.cs` shows `rSkill` set for `supportFire` only, not `deltaStrike`) — no `compatSkills` links.

### cat_supportFire5 (#444) — Support Fire, Class C
- **Skill data:** One rank; level 85, bonus requirement 6, MP 60, SP **+60** (`CatSkill.cs:1436-1464`; `decode_skilldata.py`). The positive SP value is a blue threshold, not an up-front payment. Mode `instant`, target `enemy`, `cType supportFire`.
- **Cooldown and cast:** `addTimeOut("supportFire", agiAdjust(240f))` (`Cat.cs:40879`), with Revised Art scaling. No cast bar; the animation/channel begins immediately and locks movement (`Cat.cs:40864-40909`).
- **Cannons and channel:** The cast attempts to place up to six cannons, subject to ground raycasts (`Cat.cs:41043-41099`). While channeled, a firing cycle occurs every `0.01 × Random.Range(24,36)` seconds, i.e. **0.24–0.35 s** (`Cat.cs:41174`). Each cycle picks a random placed cannon and launches a projectile if one exists (`Cat.cs:41179-41228`, `:10636-10753`). The counter advances even if no cannon was placed (`Cat.cs:41244`). Every sixth cycle consumes **12 SP**, reduced to **6 SP** with Revised Skill #404 (`Cat.cs:41249-41255`). The channel stops on movement input or when SP falls below 6 (`Cat.cs:41134-41157`). There is no fixed shot or hit count; SP regeneration and collisions affect the total.
- **Projectile and impact:** The firing point is 3 m ahead and 1 m above the selected cannon. `getTrajectoryVector` aims at a point **24–47 m forward from that firing point** (`24 + Random.Range(0,24)`, integer upper bound exclusive; `Cat.cs:41208-41216`, `Math.cs:885-965`). This is an aim distance, not a guaranteed impact distance: a projectile can collide earlier. It moves at 30 units/s, expires after 10 s, and triggers one explosion on a valid collision (`Cat_supportFire.cs:29-206`). The explosion checks enemy targets within **8 m radius and 3 m height** and calls `hit(444, target, talAdjust(50) + 200, KO 3, Hate 0, Vector3.zero)` once per target (`Cat.cs:10776-10845`). Thus **per explosion per target**, raw damage is `talAdjust(50) + 200`, then the normal `dmgAdjust → defAdjust → hitMod` pipeline applies. The calculator's single-hit Test and range represent one such impact, not an entire channel.
- **Power Number:** In the base BigBug engine, this `hit()` call qualifies for Cat Power Number raw-damage multipliers (`CharacterControl.cs:2838-3010`). See the TTO restriction below.
- **Client tooltip:** EN describes a repeating cannon barrage in the area ahead (`CatSkill_eng.cs:1091-1097`); TH explicitly labels it a channel (`CatSkill_thai.cs:1113-1119`).

---

## Server Balance Variations

### Twelve Tails Online (TTO)
- **Power Number Series Restriction to Skill Tree A:**
  - **Base BigBug Engine:** In `CharacterControl.cs:2838-3010`, the Power Number series (`cat_powerOne`, `cat_powerTwo`, `cat_powerThree`, `cat_powerSeven`, `cat_superSeven`) checks `if (this.Type == "Cat")` inside `CharacterControl.hit()`, applying raw damage multipliers (`floor(raw × 1.1 / 1.2 / 1.3 / 1.7)`) globally to **all Cat damage skills** (Combo, Charge Attack, Skill Tree A Gambler skills, and Skill Tree B Assassin skills).
  - **TTO Server Balance Delta (live-server observation reported by the user, 2026-09-25; not in the decompiled client):** On TTO, the Power Number series buff is nerfed and restricted to **Cat Skill Tree A (Gambler branch)** damage skills only (e.g. Lucky Card, Lucky Dice, Damage Roulette). It no longer applies to basic attacks/Combo or Skill Tree B (Assassin branch) attacks.
  - **Support Fire (#444):** This Class C skill receives the Power Number raw-damage multiplier in the base BigBug `hit()` pipeline, but does not receive it on TTO under the observed Tree A restriction.




### cat_flyingDagger1-4 (301–304) — active, RANK FAMILY
- reqLv 3 / 9 / 15 / 21, reqBn 0 / 1 / 2 / 3, MP 0, SP **+10 / +14 / +18 / +22** (positive = blue gate, not consumed), mode target/enemy, `cType flyingDagger` (`decode_skilldata.py`).
- **Cooldown:** `agiAdjust(12 + sLv×3)` = 15 / 18 / 21 / 24 s (`Cat.cs:29750`). No cast bar (`RPC_flyingDagger`, `Cat.cs:28901-29924`, has no `DisplayCastBar`); the hit lands ~0.6 s after the command (yields 0.2 s → 0.3 s → 0.1 s, then hit; 0.2 s + 0.15 s recovery, `:29791-29833`).
- **Range / delivery:** cast only when the target is within `sqrMagnitude < 400` = 20 m (`Cat.cs:7519`). The knife is a hitscan `Physics.Raycast(firePos, dir, 20, ~(ownLayer + 2 + 4))` aimed at the target collider's bounds centre (`:29135`, `:29455`), so the first collider on the line takes the hit (any body in the way absorbs it).
- **Damage (per knife):** `hit(300+sLv, obj, (int)(0.5×ATK + talAdjust(6×sLv)), nKo=1, nHate=0, dir)` (`Cat.cs:29483`, `:29537`, `:29585`). +1 SP per landed hit (`:29489`) and every landed knife calls `OpenWound(hitObject)`, which only acts when the caster has #443 (`Cat.cs:10404+`).
- **Status:** none.
- Client tooltips: EN "Throw a flying knife at target enemy, dealing extra 6/12/18/24 damage." / TH "ปามีดบินออกไปทำร้ายเป้าหมายด้วยความเร็วสูง (+6/12/18/24 dmg)" (`CatSkill_eng.cs:550-583`, `CatSkill_thai.cs:572-605`). Code wins: the "extra" is the `talAdjust(6×sLv)` term on top of `0.5×ATK`.

### cat_threeKnives5 (403) — passive, Class C
- reqLv 55, reqBn 0, MP 0, SP 0, mode passive. All three `hasSkill(403)` checks in `Cat.cs` sit inside `RPC_flyingDagger` (`:29168` extra fire effects + voice, `:29483` center bonus, `:29501` side knives); no other Cat companion file references it (searched `Cat.cs` + `Cat_grandCasinoArcade.cs` + `Cat_supportFire.cs`).
- **Effect:** Flying Dagger throws **3 knives** in the same frame: the center knife (`talAdjust(6×sLv + 6)`) and two side knives whose raycasts start at `TransformDirection(∓0.6, 0, −0.3)` and fire parallel to the center one (`:29509`, `:29555`); each side knife is `int(0.5×ATK + talAdjust(6×sLv))` (`:29537`, `:29585`), gives its own +1 SP and its own `OpenWound`. A side knife can hit a different body than the center knife.
- **Tooltip mismatch:** EN "adds 6 damage to them" / TH "เพิ่มความเสียหายขึ้นอีก 6 Dmg" (`CatSkill_eng.cs:990`, `CatSkill_thai.cs:1012`) — the +6 is inside the center knife's `talAdjust` only, not on the side knives.

### cat_disarm1-2 — active, RANK FAMILY
- reqLv 16 / 20, reqBn 4 / 8, MP 0, SP **+18 / +24** (blue gate), mode target/enemy, `cType disarm` (`decode_skilldata.py`). Status `disarm`: nCode 505 (`StatusData.cs:1075`), Debuff + Physical (`:7376`, `:5427`), not lock/magical/shield.
- **Cooldown:** `agiAdjust(27 + sLv×3)` = 30 / 33 (`Cat.cs:34345`). No cast bar; hitscan raycast 20 m; hit ~0.6 s after the command (yields 0.2 / 0.3 / 0.1 s, `:34512-34538`). One `hit()` per cast.
- **Damage:** `hit(99, obj, (int)(0.5×ATK + talAdjust(10×sLv)), nKo=1, 0, dir)` (`Cat.cs:34176`), then `OpenWound(hitObject)`, then the status, then +1 SP.
- **Status:** `RPC_AddStatus("disarm", sLv, Damage.getDebuff(6 + (hasSkill(443) ? 3 : 0), casterCHA, targetCHA), 10×sLv, caster)` (`:34183-34188`). The Open Wound +3 is **inside** `getDebuff`'s base (6 → 9), so it is CHA-contested with the rest, not a flat add. `getDebuff` (`Damage.cs:317`): `t ≤ 0 diff → floor(base × (1 + diff/(|diff|+64)))`, else `floor(base × (1 + 0.01×diff))` with `diff = casterCHA − targetCHA`.
- **Effect** (apply site `CharacterControl.cs:36285`): `addTimeOut("nAttack", sTime)` locks the target's normal attack for the whole status time; MP and SP each drop by `sValue = 10×sLv` once (`clamp(x − sValue, 0, max)`). Skills stay usable. Tick (`:9107`) only plays the disarm emoticon.
- Client tooltips: EN "Throw a dagger at target enemy, temporary disabling its normal attack and reducing 10 [20] mp and 10 [20] sp." / TH "… (+10/+20 dmg, -10/-20 mpsp)" (`CatSkill_eng.cs:726-737`, `CatSkill_thai.cs:748-759`). The "+10/+20 dmg" is the `talAdjust(10×sLv)` term on top of `0.5×ATK`.
- Accessory-gated block `CharacterControl.cs:13848` (`accessory == "c_all16"`, `lckAdjust(12)`, `RPC_AddDamage(-83…)`) sits in the status-apply path; not traced, not shown on the card.

### cat_bleed1-2 — active, RANK FAMILY
- reqLv 24 / 28, reqBn 12 / 16, MP **14 / 20**, SP **+18 / +24** (blue gate), `cType bleed`. Status `bleed`: nCode 506 (`StatusData.cs:1086`), Debuff + Physical (`:7382`, `:5433`).
- **Cooldown:** `agiAdjust(54 + sLv×6)` = 60 / 66 (`Cat.cs:35177`). Same cast shape as Disarm (hitscan 20 m, ~0.6 s, one `hit()`).
- **Damage:** `hit(99, obj, (int)(0.5×ATK + talAdjust(10×sLv + 5)), 1, 0, dir)` (`Cat.cs:35013`) = +15 / +25 on the TAL term, then `OpenWound`, the status, +1 SP.
- **Status:** `RPC_AddStatus("bleed", sLv, Damage.getDebuff(12 + (hasSkill(443) ? 3 : 0), casterCHA, targetCHA), 0, caster)` (`:35015-35020`); the Open Wound +3 is inside the contested base, as for Disarm.
- **Tick** (`CharacterControl.cs:9126-9200`, in `StatusUpdate`, which runs at most every 0.5 s): while `hp > 0 && actionState == "run"` and `Math.mod(2×tickTime, 2) == 0` (`Math.mod` floors its input, so it passes on about every other 0.5 s tick, ≈ once per second), the target takes `RPC_AddEffectDamage(1, 5×sLv, …)` (purple, undodgeable), MP −`3×sLv`, SP −`1×sLv`. The ~1 s interval is derived from that gate and matches the client's "5/10 dps"; a live measurement would override it.
- Client tooltips: EN "…'bleed1' [bleed2] status that reduces target's hp, mp and sp when it moves (5dps [10dps])" / TH "… (+15/+25 dmg, 5/10dps, 12 sec)" (`CatSkill_eng.cs:748-759`, `CatSkill_thai.cs:770-781`).
- Accessory-gated block `CharacterControl.cs:13875` (`c_all26`) not traced (same as Disarm's).

### cat_openWound5 (#443) — passive, Class C
- reqLv 85, reqBn 6, MP 0, SP 0, mode passive.
- **Duration:** adds 3 to the base passed to `Damage.getDebuff` for `disarm` (6 → 9, `Cat.cs:34183`) and `bleed` (12 → 15, `:35015`), i.e. CHA-contested, not a flat add.
- **Bonus damage:** `OpenWound(hitObject)` (`Cat.cs:10404-10470`) runs after each landed `hit() != 0`, only for the local caster with #443: `num = 30 × (target disarm Lv + target bleed Lv)`; if `num > 0`, `RPC_AddEffectDamage(443, num, 0, 0, Vector3.zero, caster)`. Purple Effect Damage: no dodge, no dmgAdjust/defAdjust. The 0.1 s timer `mB7xG0SpKp` only throttles the red camera flash and the "OpenWound!" message, **not** the damage.
- **Order matters:** inside Disarm and Bleed the call precedes `RPC_AddStatus`, so the bonus only counts statuses already on the target.
- **Skills that call it** (per landed hit, `Cat.cs`): Combo `nAttack1-4` (`:16672-19340`, with Hidden Blade / crit branches), Flying Dagger ×3 (`:29494/29548/29598`), Forward Lunge (`:30457`, `:30704`), Reverse Thrust (`:31539`, `:31776`), Heart Ripper 2 (`:33416`, `:33528`), Disarm (`:34178`), Bleed (`:35010`), Moon Blade (`:35713`, `:35815`), Moon Storm (`:36449`, `:36555`), Delta Strike (`:37603` finisher, `:37927` ticks), Finishing Blow 2 (`:38923`). Lucky Card / Dice / Double Down / Grand Casino / Pillage Plunge / Support Fire never call it.
- Client tooltips: EN "Adds 3 sec to 'disarm' and 'bleed' status and deals special damage when Cat uses normal attack on them." / TH "เพิ่ม effect dmg ให้ n.atk และสกิลสาย B ของแมว … (30x lv skill)" (`CatSkill_eng.cs:1034`, `CatSkill_thai.cs:1056`). The "30×lv" is the target's disarm Lv + bleed Lv, not the skill rank.

### cat_forwardLunge1-2 — active, RANK FAMILY
- reqLv 5 / 17, reqBn 1 / 5, MP 0, SP **−15 / −18** (red, consumed), mode instant/enemy, `cType forwardLunge` (`decode_skilldata.py`). Cooldown `agiAdjust(30)` (`Cat.cs:30787`).
- **Sequence** (`$RPC_forwardLunge`, `Cat.cs:29924-31011`): 0.3 s wind-up, then a counter `i` steps 0→4 with 0.1 s waits (`:30132`, `:30236`, `:30915-30941`); `i < 4` = 4 small hits, `i == 4` = the finisher, then 0.1 s + 0.2 s recovery. Five hits total (matches the tooltip's "x5"). Every landed hit gives +1 SP and calls `OpenWound`.
- **Small hits (4):** `hit(309 + 2·sLv, obj, (int)(0.3×ATK + talAdjust(4·sLv)), nKo 1, 0, 0.5·forward)` (`:30541`, `:30634`); area `FindRecTarget(pos, forward, 1, 1, 3, 2)×rangeMod` = 2 m wide, 3 m long, 2 m high (`:30518`).
- **Finisher (1):** `hit(99, obj, (int)(0.5×ATK + talAdjust(5·sLv)), nKo 3, 0, forward)` (`:30294`, `:30387`); range 4 m (`:30271`, `moveSpeed 12`).
- **Backstab (#413):** both hit types run `hitDmg *= 2` when `hasSkill(413)` and `Quaternion.Angle(casterRot, targetRot) < 45` (`:30304-30368`, `:30551-30615`).
- Client tooltips: EN "Thrust the knife forward and deals 4x5 damage to the enemies in front." / TH "วิ่งแทงมีดไปข้างหน้าอย่าง รวดเร็ว (+4 dmg x5)" (`CatSkill_eng.cs:594-605`, `CatSkill_thai.cs`). The 4/8 is the small hits' TAL term; the tooltip omits the `0.3×ATK`, the finisher and KO 3.

### cat_reverseThrust1-2 — active, RANK FAMILY
- reqLv 11 / 23, reqBn 3 / 7, MP 0, SP **−16 / −20** (red). Cooldown `agiAdjust(45)` (`Cat.cs:31896`).
- Two hit sites, each once (no loop, `Cat.cs:31469`, `:31706`): `hit(312 + sLv, obj, (int)(0.5×ATK + talAdjust(10·sLv)), nKo 5·sLv, 0, 0)`; area `FindRecTarget(pos, −forward, 1, 1, 3, 2)×rangeMod` (3 m *behind* the caster, 2 m wide, 2 m high). Each landed hit: +1 SP, `OpenWound`.
- **Backstab (#413):** `hitDmg *= 2` when `hasSkill(413)` and `Quaternion.Angle(casterRot, targetRot) > 135` (`:31386-31450`, `:31623-31687`), the opposite test to Forward Lunge because the thrust goes backwards.
- Client tooltips: EN "Thrust the knife backward, dealing 15x2 damage and 10 ko." (`CatSkill_eng.cs:616-627`). Code wins: the TAL term is `10·sLv` (10 / 20, not 15 / 25); KO is `5·sLv` per hit, 10 / 20 across both hits.

### cat_heartRipper1-2 — active, RANK FAMILY
- reqLv 19 / 25, reqBn 6 / 8, MP 0, SP **−3 / −5** (red). Cooldown flat `agiAdjust(60)` (`Cat.cs:32986`, see the note above about the shared `heartRipper` cooldown key).
- The target must be in the `"ko"` action state, otherwise "Can only use on ko opponent" and `returnMPSP` refunds the cost (`Cat.cs:7340-7373`).
- `RPC_heartRipper1` (`:32652`) only teleports, then chains into `RPC_heartRipper2` (`:32891`, `:33169`), area `FindAreaTarget(pos, 1×rangeMod, 5)` (radius 1 m, height 5 m). Two hits, both `nKo 0`: hit 1 `hit(322 + sLv, …, 0.5×ATK + talAdjust(20·sLv + 10))` (`:33378`), hit 2 `talAdjust(10·sLv + 10)` (`:33490`). Each landed hit: +1 SP, `OpenWound`.
- Client tooltips: EN "Instanly jump over a knocked down enemy and deal 20x2 damage." (`CatSkill_eng.cs:660-671`); the code gives 30 / 50 on hit 1 and 20 / 30 on hit 2.

### cat_finishingBlow5 (#423) — active, Class C
- reqLv 70, reqBn 3, MP **20**, SP **−45** (red), mode target/enemy, `cType heartRipper` (shares Heart Ripper's cooldown key). Cooldown `agiAdjust(120)` (`Cat.cs:38418`). Same KO-target requirement as Heart Ripper (`Cat.cs:6440-6497`).
- `RPC_finishingBlow1` (`:38095`) teleports and chains into `RPC_finishingBlow2` (`:38531`); area `FindAreaTarget(pos, 1×rangeMod, 5)`. Four hit sites, each once: `hit(423, obj, 799, 0, 0, 0)` ×3 (`:38717`, `:38817`, `:38917`) and `hit(423, obj, 199, 0, 0, 0)` (`:39031`), **fixed raw damage** (no ATK, TAL or skill rank), KO 0. Total raw 2,596.
- **Open Wound fires on hit 3 only** (`:38923`); hits 1, 2 and 4 never call `OpenWound`.
- Also gives Backflip +1 lock-cleanse level (`Cat.cs:32432`, `hasSkill(423)`; Backflip has no card yet).
- Client tooltips: EN "Perform a finishing blow on knocked down enemy. Enables Backflip to remove lv5 lock." (`CatSkill_eng.cs:1012`).

### cat_moonBlade1-2 — active, RANK FAMILY
- reqLv 20 / 24, reqBn 12 / 15, MP **10**, SP **−20 / −25** (red). Cooldown `agiAdjust(90)` (`Cat.cs:35957`).
- Two hit sites (`:35702`, `:35804`): area `FindAreaTarget(pos, 3×rangeMod, 3)` then `4×rangeMod` (a target within 3 m takes both, one at 3-4 m takes one). Each `hit(350 + sLv, obj, (int)(0.5×ATK + talAdjust(15 + 10·sLv)), nKo 1, 0, 0)` = TAL term 25 / 35. Each landed hit: +1 SP, `OpenWound`, then `RPC_AddStatus("cut", 2·sLv, 1, 0, caster)` (`:35739`, `:35841`). The status is applied inside the landed-hit block (indentation-checked), so a dodged hit does not apply it.
- Client tooltips: EN "…(25x2 dmg)" / "(45x2 dmg)" (`CatSkill_eng.cs:770-781`). Code wins: rank 2 is 35, not 45.

### cat_moonStorm1-2 — active, RANK FAMILY
- reqLv 28 / 32, reqBn 18 / 21, MP **20**, SP **−30 / −40** (red). Cooldown `agiAdjust(120)` (`Cat.cs:36699`).
- Eight hits: counter `i` 0→5 with 0.1 s waits, each at `mPos + i×1.5 m×forward`, `FindAreaTarget(…, 2, 2)` (`:36415`, `:36675`); then counter `j` 0→1 with 0.1 s waits (`:36609`), each at `mPos + 12 m×forward`, `FindAreaTarget(…, 3, 2)` (`:36521`). Every hit `hit(350 + sLv, obj, (int)(0.5×ATK + talAdjust(10·sLv + 5)), nKo 1, 0, 0)` (`:36438`, `:36544`), then +1 SP, `OpenWound`, and `cut` (`2·sLv`, 1 s), all inside the landed-hit block.
- Client tooltips: EN "…(10x8 dmg)" / "(15x8 dmg)" (`CatSkill_eng.cs:792-803`). The hit count of 8 is right; the TAL term is `10·sLv + 5` = 15 / 25.

### cut (status, nCode via `StatusData.cs:1097`)
- Debuff (`isDebuffStatus`, `StatusData.cs:7388`) and State (`isStateStatus`, `:4914`); not physical, magical, lock or shield. It is **not** a damage-over-time (the §4.1 catalog lists it as one; that grouping is by name only).
- Apply handler (`CharacterControl.cs:36308`): removes every status on the target that is **Shield and Magical** with `sLv ≤ cut's sLv`. Cat applies it at `sLv = 2 × skill rank` for a flat 1 s (Moon Blade `Cat.cs:35739`, Moon Storm `:36475`).

### cat_backstab5 (#413) — passive, Class C
- All `hasSkill(413)` sites in `Cat.cs` are Forward Lunge and Reverse Thrust (`:30304`, `:30551`, `:31386`, `:31623`): the whole `hitDmg` (ATK and TAL parts) is doubled before `hit()`, so Power Numbers, dmgAdjust and defAdjust apply afterwards. (`hasSkill(412)` is Lady Luck and `(414)` is Revised Magic, not Backstab.)
- Client tooltip: EN "Double the damage of forwardLunge and reverseThrust when they are striked from behind."

### Open Wound wiring per skill (2026-09-26)
- Calls `OpenWound` on every landed hit of: Flying Dagger ×3, Forward Lunge ×5, Reverse Thrust ×2, Heart Ripper ×2, Disarm, Bleed, Moon Blade ×2, Moon Storm ×8, Delta Strike ×7, and Finishing Blow **hit 3 only**.
- **Combo (`nAttack1-4`, `Cat.cs:16500-19500`):** each strike has a Hidden Blade branch (`hit(331-334, …, hitDmg + hiddenBladeDmg)`, only when `mHiddenBladeDmg != 0` and the target is behind: angle `< 45 (+30 with Jagged Knife #433)`) and a normal branch (`hit(1-4, …, getCritPlus(hitDmg))`). Both branches call `OpenWound` **except stage 2's Hidden Blade hit** (`hit(332)`, `:17390`), whose landed block ends without it (the only `OpenWound` in that class is after the normal `hit(2)`, `:17507`). Stage 4 shares one `OpenWound` tail (`IL_8E7`, `:19099`) between both branches.
- Encoded in `index.html` as `effectProc.hits` (1-based hit numbers; absent = every hit): Finishing Blow `[3]`; Combo `[1,3,4,5,6]` while Hidden Blade is on, otherwise all six.
