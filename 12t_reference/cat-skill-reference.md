# Cat — Skill Cooldown/Duration Reference

> **Scope (2026-10-25):** this file documents the original BB client (`DecompiledSource/`); a citation without a tag is BB. ToT and TTO changes are live changes reported by the user and sit in the `## Server Balance Variations` sections. The Reborn client has its own file: [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) (Reborn citations are tagged `Reborn:`).

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
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
- `damageRoulette` Duration: `Cat.cs:27052` — `this.$self_$21895.mChar.RPC_AddStatus("damageRoulette", this.$sLv$21894, this.$self_$21895.mChar.chaAdjust(12), 0, this.$self_$21895.mChar.ActorNr);` (self-buff, not target-contested); the `damageRoulette` status is Buff, Magical (`StatusData.cs` is*Status lists, checked 2026-10-16)
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

### cat_awareness1-2 (#121-122) — active, Tree A
- reqLv **6 / 12**, reqBn **2 / 4**, MP **0 / 0**, red SP **−3 / −5**; instant, self-targeted (`decode_skilldata.py`, `CatSkill.cs:100-124`). Cooldown is a bare **1 s**, without `agiAdjust` (`Cat.cs:8574`).
- The actual radius is `12 × sLv` = **12 / 24 m** (`Cat.cs:8674`). `Damage.FindAreaTarget` applies `awareness` at the matching level for a flat **1 s** to nearby characters outside the Cat's own layer (`Cat.cs:8792-8837`). The status removes existing `blend` and `invisible` on application, with no level comparison; it does not block a new application while active (`CharacterControl.cs:36204-36227`; no `awareness` reader in the invisibility-application paths). The cast also reveals nearby hidden item renderers and triggers `TreasureFound` for treasure boxes within that radius (`Cat.cs:8922-9041`).
- With **Treasure Hunt** #123, it additionally collects every loaded `treasureBox` tagged `Item` (no radius check in this collection) and calls `displayTreasure(..., chaAdjust(5))` to show them on the minimap (`Cat.cs:8867-8916`, `GameGui.cs:5606-5625`). With **Insight** #421, it gives the Cat `insight` Lv 1 for `chaAdjust(3)` (`Cat.cs:8848-8854`).
- Client tooltip: EN says **12 / 18 m** (`CatSkill_eng.cs:99-114`); the rank-2 **18 m** conflicts with the cast's `12 × sLv` and is not used on the card. TH says it reveals invisible things (`CatSkill_thai.cs:99-115`).

### cat_treasureHunt1 (#123) — passive, Tree A
- reqLv **18**, reqBn **6**, MP/SP **0**, passive (`decode_skilldata.py`, `CatSkill.cs:124-135`). Its hook is `hasSkill(123)` inside Awareness (`Cat.cs:8890-8916`): when Awareness is cast, treasure-box locations appear on the minimap for **`chaAdjust(5)` seconds**. The minimap list is assembled before the cast's radius check, so the locations are not limited to Awareness's 12 / 24 m reveal radius. Physical treasure-box reveal still follows the radius check (`Cat.cs:8922-8945`).
- Client TH and EN tooltips describe the minimap effect (`CatSkill_thai.cs:121-125`, `CatSkill_eng.cs:121-125`; the EN key is misspelled `cat_teasureHunt1`).

### cat_insight5 (#421) — passive, Class C
- reqLv **70**, reqBn **3**, prerequisite skill **#123 Treasure Hunt**, MP/SP **0**, passive (`decode_skilldata.py`, `CatSkill.cs:1008-1024`). On every Awareness cast, the Cat receives `insight` Lv 1 for **`chaAdjust(3)` seconds** (`Cat.cs:8848-8854`).
- `insight` is **Buff + State** (`StatusData.cs:4908`, `:6662`). Trap and structure handlers explicitly check `hasStatus("insight")` before damaging the target; examples include Cactun Trap (`CactunTrap.cs:63-69`), Guard Tower (`GuardTower.cs:1236`), Flying Cacton (`FlyingCacton.cs:218-229`), and Mole traps (`Mole.cs:10636`, `:11138`, `:11577`). The checks neither remove nor decrement Insight, so every covered hit is prevented while the status remains active; the generic status timer removes it on expiry (`CharacterControl.cs:19043-19085`, `:10658`). This is protection at those handlers, not a universal damage-immunity status.
- Client TH and EN tooltips describe trap/structure protection on Awareness use (`CatSkill_thai.cs:924-928`, `CatSkill_eng.cs:902-906`).

### cat_joker5 (402) — passive, Class C
- reqLv 55, reqBn 0, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`). The only two `hasSkill(402)` checks in the Cat source are inside `RPC_luckyCard` (`Cat.cs:20850`, `:20870`) — Joker modifies **Lucky Card only**.
- **Damage bonus:** `hitDamage = (int)(hitDamage + 0.5 × (casterLCK − targetLCK))` (`Cat.cs:20856`). Unlike the base random roll, which is floored with `Mathf.Max(…, 0)` (`:20845`), this term is **not clamped**: against a target with higher LCK than the Cat it is negative and **reduces** Lucky Card's damage. The Joker card carries a red warning for this.
- **Doom proc:** only after a real hit (`hit() != 0`, `Cat.cs:20862`), if the target does not already have `doom` (`:20876`) and `Random.Range(0,100) < lckAdjust(6)` (`:20882`): `RPC_AddStatus("doom", 1, Damage.getDebuff(30, target.cha, caster.cha), 0, casterActor)` (`:20888`) and the client message "Joker Card!" (`:20893`). The duration is CHA-contested with the **target's CHA passed first**, the same reversed order as Bat's Doom, hence `durContested` + `durContestedInverted`. The 6 is a base chance that `lckAdjust` scales with the caster's LCK, so it is shown as a chip, not typed in the desc.
- **Doom only on a target without Doom (verified 2026-10-28):** `hasStatus` matches the status name alone, with no level or caster test (`CharacterControl.cs:19043-19083`), so a `doom` of any level from any caster makes `!hitChar.hasStatus("doom")` (`Cat.cs:20876`) false and skips the roll: Joker neither raises nor refreshes an existing Doom. **Bible (2026-10-28):** the Joker card and Lucky Card's **Joker:** line say the target must not have [doom] yet.
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
- **Power Number and Super Seven (verified 2026-10-28):** the damage goes through `hit(230 + sLv, …)` (`Cat.cs:23962`), so the Cat's Power One / Two / Three / Seven and Super Seven floors in `hit()` apply to it (`CharacterControl.cs:2838-3011`), as on Lucky Card (`Cat.cs:20862`), Double Down (`:25358`) and Grand Casino Arcade (`:28215-28265`). Lucky Dice is Tree A, so it keeps them on TTO (Server Balance Variations, TTO). **Bible (2026-10-28):** Lucky Dice links Power Seven and Super Seven.
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
- **Gear crit and Huge Shuriken (`w_cat59`, verified 2026-10-06):** each normal pass is `hit(1-4, …, getCritPlus(hitDmg))` (standard table, `Cat.cs:15410`: weapon `w_cat43`/`44` +5, `w_cat58` +7; armor + hat Marshal +7, Champion +11). `w_cat59` ("Huge shuriken. Increases SP charging rate…", `WeaponData_eng.cs:2376`) first sets `hitDmg = floor(0.75 × hitDmg)` (`Cat.cs:16525`, same at every stage and pass) and gives +1 extra SP per landed hit (`:16742`). Full order of a normal hit: `floor(0.75x)` (weapon) → `getCritPlus` → Power (`hit()`) → Charge `damagePlus` → No Chance / `dmgAdjust`. The Hidden Blade hit adds its bonus to the 0.75-scaled raw and never crits.
- **Card (2026-10-06):** `CAT_COMBO_GEAR` controls (crit Dagger, crit armor + hat, Huge Shuriken; the shuriken and the crit Dagger switch each other off). The crit wraps only the normal raw term, so with Hidden Blade on the card shows no crit.

### cat_hiddenBlade1-4 (#331–334) — passive, RANK FAMILY
- reqLv 9 / 15 / 21 / 27, reqBn 3 / 5 / 7 / 9, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`, `CatSkill.cs:758-795`, tree keys `:2974-3007`).
- **Level:** `getHiddenBladeLv()` returns the highest learned of 334 / 333 / 332 / 331 → 4 / 3 / 2 / 1, or **5** when Jagged Knife (#433) is learned (`Cat.cs:9989-10047`). Bonus = `getHiddenBladeDmg()` = `talAdjust(10 × level)` (`:10051-10055`).
- **One roll per stage:** the bonus is rolled once at the start of each Combo stage (`Cat.cs:16537`, `:17335`, `:17988`, `:18959`), before the target loop, so every target of that stage and both passes of stages 3 and 4 (`:18068`/`:18313`, `:19047`/`:19288`) share the same `talAdjust` result. It is added **after** the `w_cat59` weapon's `0.75×` scaling of the raw strike (`:16531`), so the weapon does not shrink the bonus.
- **Trigger** (`Cat.cs:16570-16618`, same shape at every stage): the hit target has a `CharacterControl`, is not `Race == Structure`, is not `Buiten1-4` or `ManaVortex`, and `Quaternion.Angle(catRotation, targetRotation) < 45` (`+30` with #433). The angle compares the two **facings**, so the Cat must face the same way as the target (a 90° cone, 150° with Jagged Knife), not merely stand behind it. Every other target takes the ordinary `hit(1-4, …, getCritPlus(raw))` instead.
- **Replacement hit:** `hit(331-334, target, raw + bonus, nKo 1, 0, …)` (`:16622`, `:17390`, `:18068`, `:18313`, `:19047`, `:19288`). It **never calls `getCritPlus`**, so gear crit cannot proc on a Hidden Blade hit, and its action code is ≥ 10, so No Chance's flat `+0.3×LCK` does not apply (ordinary `dmgAdjust` runs; see the Combo entry above). A landed hit plays `RPC_hiddenBlade_hit` (VFX + voice, `:10059`), gives +1 SP (`:16655`), shows "HiddenBlade!" for the local player (`:16666`) and calls `OpenWound`, except stage 2 (see "Open Wound wiring per skill").
- Client tooltips: EN "Add 10 [20 / 30 / 40] damage to normal attack when the enemy is striked from behind." / TH "เพิ่มค่าความเสียหายของการ โจมตีปกติเมื่อแมวโจมตีจาก ด้านหลังศัตรู (+10 [+20 / +30 / +40] dmg)" (`CatSkill_eng.cs:682-725`, `CatSkill_thai.cs:704-747`). The "+N" is the `talAdjust(10×level)` base; the tooltip does not mention the facing cone, the excluded targets or the missing crit.

### cat_jaggedKnife5 (#433) — passive, Class C
- reqLv 75, reqBn 4, MP 0, SP 0, mode passive, prerequisite **#334 Hidden Blade 4** (`CatSkill.cs:1296-1312`, tree key `:3315`).
- Two effects, both inside the Hidden Blade path: `getHiddenBladeLv()` returns **5** (`Cat.cs:9996`, checked before the Hidden Blade ranks) → bonus `talAdjust(50)`; and the facing check becomes `< 75°` (`45 + 30`, `Cat.cs:16618`, `:17386`, `:18064`, `:18307`, and the stage 4 sites). No other `hasSkill(433)` consumer in `Cat.cs`.
- Client tooltips: EN "Increases HiddenBlade's damage by 10 and gives it a 30 degree wider activation angle." / TH "เพิ่มระดับของ HiddenBlade 1 ระดับและเพิ่มองศาของการติดทักษะอีก 30 องศา" (`CatSkill_eng.cs:1023-1033`, `CatSkill_thai.cs:1045-1055`). Both match the code: +1 level = +10 on the `talAdjust` base, and +30° on each side of the 45° half-angle.

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
- **Bible (2026-10-28):** Super Seven links the four Tree A damage cards it raises (Lucky Card, Lucky Dice, Double Down, Grand Casino Arcade; `hit()` at `Cat.cs:20862`, `:23962`, `:25358`, `:28265`) on its base and TTO lists, Power Seven adds Lucky Dice to both lists, and each of those cards links back. Their descs carried no Power line until the open-decision pass (Open items, 1).
- **Which cards the floors reach (verified 2026-10-28):** the block runs for every `hit()` whose attacker `Type` is Cat against a Player or Enemy other than herself, with no action-code filter (`CharacterControl.cs:2838-3011`); Reborn bible3 has the same block (`Reborn1027:CharacterControl.cs:7103-7133`). Every Cat damage card calls her own `hit()`: Lucky Card (`Cat.cs:20862`), Lucky Dice (`:23962`), Double Down (`:25358`), Grand Casino Arcade (`:28265`), Flying Dagger (`:29483-29585`), Forward Lunge (`:30387`, `:30634`), Reverse Thrust (`:31469`, `:31706`), Heart Ripper (`:33378`, `:33490`), Disarm (`:34170`), Bleed (`:35002`), Moon Blade (`:35702`, `:35804`), Moon Storm (`:36438`, `:36544`), Delta Strike (`:37597`, `:37921`), Finishing Blow (`:38717-39031`, so its fixed 799 / 199 raw is multiplied too), Pillage Plunge (`:40195`) and Support Fire (`:10845`); on Reborn also Broadside (`Reborn1027:RebornC6.cs:2335`), the Shadow Upon Shadow swap blast (`Reborn1027:RebornC7Act.cs:2105`) and the Ghost Galleon guns and salute (`Reborn1027:RebornC7Act.cs:2433`, `:2446`). Charge Attack and Hidden Blade have no damage card of their own (Hidden Blade's hits are on the Combo), and a mount hits as its own character (`Type` none). **Bible (2026-10-28):** each of these cards carries the standard **Power Seven:** line (Open items, 1).

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
  - **Tooltip mismatch:** TH "(+135 dmg)" / "(+180 dmg)" (`CatSkill_thai.cs:884`, `:895`), but `sLv` is 1 / 2 (`RPC_deltaStrike(…, 1)` / `(…, 2)`, `Cat.cs:5285`, `:5303`), so the finisher's bonus is `talAdjust(180)` / `talAdjust(270)`, and it is on the finishing hit only (the six ticks have no bonus). Card `tooltipNote` (2026-10-27).
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
- **Projectile and impact:** The firing point is 3 m ahead and 1 m above the selected cannon. `getTrajectoryVector` aims at a point **24–47 m forward from that firing point** (`24 + Random.Range(0,24)`, integer upper bound exclusive; `Cat.cs:41208-41216`, `Math.cs:885-965`). This is an aim distance, not a guaranteed impact distance: a projectile can collide earlier. **Where it really lands (traced 2026-10-16):** the target point is at the firing height, so `getTrajectoryVector` takes its `y < 0.1` branch, which lowers the low-arc angle by `0.1 × distance / 30` rad (`Math.cs:885-965`); with the prefab rigidbody gravity (9.8, `supportFire_fire.prefab`) the shell, fired 1 m above the ground, comes down 19.1–27.1 m past the firing point after 0.64–0.91 s, i.e. **about 20–28 m ahead of the Cat**, in its cannon lane (cannons at x = 3i − 10.5 m, 2 m behind the Cat, `Cat.cs:41043-41099`). The firing loop starts after a 1 s wait (`Cat.cs` state 2). It moves at 30 units/s, expires after 10 s, and triggers one explosion on a valid collision (`Cat_supportFire.cs:29-206`). The explosion checks enemy targets within **8 m radius and 3 m height** and calls `hit(444, target, talAdjust(50) + 200, KO 3, Hate 0, Vector3.zero)` once per target (`Cat.cs:10776-10845`). Thus **per explosion per target**, raw damage is `talAdjust(50) + 200`, then the normal `dmgAdjust → defAdjust → hitMod` pipeline applies. The calculator's single-hit Test and range represent one such impact, not an entire channel.
- **Power Number:** In the base BigBug engine, this `hit()` call qualifies for Cat Power Number raw-damage multipliers (`CharacterControl.cs:2838-3010`). See the TTO restriction below.
- **Client tooltip:** EN describes a repeating cannon barrage in the area ahead (`CatSkill_eng.cs:1091-1097`); TH explicitly labels it a channel (`CatSkill_thai.cs:1113-1119`).

---

### Geometry notes (verified 2026-10-02)

- **Combo boxes:** every stage uses `FindRecTarget(pos − rangeMod·forward, forward, w, w, 3·rangeMod, 2·rangeMod)` with half-width `w = 1·rangeMod` for stages 1-3 (`Cat.cs:16520`, `:17318`, `:18001`, `:18244`) and `2·rangeMod` for stage 4 (`:18972`, `:19213`): 3 m long starting 1 m behind the Cat, 2 m wide (4 m on stage 4), 2 m high.

## Geometry notes (traced 2026-10-13, for the Bible `reach` field)

- **Origin:** `KOIRnET4pM = this.transform` (`Cat.cs:57`), the Cat's own transform, so every `FindAreaTarget` / `FindRecTarget` below is measured from the Cat herself. `rM` = `mChar.rangeMod`.
- **Combo** (`FindRecTarget(pos − rM·forward, forward, 1rM, 1rM, 3rM, 2rM)`): stages 1-3 = 2 × 3 × 2 rM starting 1 rM behind (`:16520`, `:17318`, `:18001`, `:18244`); stage 4 `(2rM, 2rM, 3rM, 2rM)` = 4 × 3 × 2 rM (`:18972`, `:19213`). Combo rank 1 / 2 / 3 reaches stage 2 / 3 / 4.
- **Awareness** `FindAreaTarget(pos, 12 × sLv, 3rM)` (`:8774`, `:8797`); **Fate Draw** `(15rM, 3rM)` (`:21414`); **Lucky Dice** `(6, 5)` (`:23934`); **Double Down** scan `(6 × sLv + 12, 10)` (`:25047`) and a blast `(mRange, 2)` with `mRange` 1, or 2 with Roll the Dice #432 (`:25335`, `:25389-25396`); **Damage Roulette** `(24, 12)` around the Cat (`CharacterControl.cs:4849`); **Grand Casino Arcade** `(24, 12)` for both the hit list and the Doom list (`:28220`, `:28009`).
- **Raycast knives, 20 m:** Lucky Card (`:20790`), Flying Dagger (three rays, `:29455`, `:29509`, `:29555`, the side ones 0.6 m out and 0.3 m back), Disarm (`:34127`), Bleed (`:34959`). Copycat and Swift Pace have no distance gate of their own; they use the 40 m target lock ([12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md) §4).
- **Forward Lunge:** the four flat hits are `(1rM, 1rM, 3rM, 2rM)` (`hit(309 + 2·sLv, …, KO 1)`, `:30518`); the finisher `(1rM, 1rM, 4rM, 2rM)` (`hit(99, …, KO 3)`, `:30271`). **Reverse Thrust** `(1rM, 1rM, 3rM, 2rM)` along `−transform.forward` (`:31353`, `:31590`). **Heart Ripper / Finishing Blow** `FindAreaTarget(pos, 1rM, 5)` after the jump onto the target (`:33355`, `:38694`).
- **Moon Blade** `(3rM, 3)` then `(4rM, 3)` (`:35679`, `:35781`). **Moon Storm:** 6 rings `(2, 2)` at `mPos + i · 1.5 · forward`, i = 0..5 (`:36415`, `:36675`), then a blast `(3, 2)` at 12 m (`:36521`). **Delta Strike** `FindRecTarget(pos, forward, 1, 3·sLv + 3, 2·sLv + 4, 6)`: widths 2 → 12 / 18, length 6 / 8, height 6 (`:37136`).
- **Pillage Plunge:** the hit box is `(pos − 2·forward, forward, 2, 2, 4, 2)` = 4 × 4 × 2 (`:40172`); a second `FindRecTarget(pos, forward, 1, 1, 6, 2)` (2 × 6 × 2, `:40052`) feeds `Physics.IgnoreCollision` only, so the Cat passes through whoever stands on her dash path. **Backflip**'s `(1, 1, 4, 2)` box (`:32208`) is the same kind of collision-ignore list, not a hit box.
- **Support Fire:** each shell is thrown to `24 + Random.Range(0, 24)` m (24..47) ahead with `getTrajectoryVector` (`:41212`) and bursts in `FindAreaTarget(hitPos, 8, 3)` (`:10825`). The cannons stand in a row 3 m apart (`(i × 3) − 10.5`, `:41060`); the Bible card draws only the near and far blast circles on the Cat's axis.
- **Hidden Blade / Jagged Knife are not volumes:** the 45° (75° with #433) is `Quaternion.Angle` between the Cat's and the target's facings, so the cards keep it as desc text and have no `reach`.

## Movement timelines (read 2026-10-15, for the range preview; nominal `moveMod` 1, not live-tested)

The Cat moves by `vMovement × moveSpeed × clamp(moveMod, 0.1, 2) × dt` (`CharacterControl.cs:2722`); the speed set in a state runs until the next `Yield` returns. Distance moved from the cast point at each hit (forward is the facing; negative = backwards):

| Skill | Legs (speed m/s × seconds) | Hit at (m) | Source |
|---|---|---|---|
| Forward Lunge | 9 until the finisher (a 0.3 s wind-up at 0 first); 4 small hits 0.1 s apart, finisher at 0.4 s (sets 12 only at the hit) | 0, 0.9, 1.8, 2.7; finisher 3.6 | `Cat.cs:30071`, `:30132`, `:30236`, `:30260`, `:30518`, `:30271` |
| Reverse Thrust | −10 × 0.2, then 0 | −2.0 (both hits) | `Cat.cs:31158`, `:31315`, `:31353`, `:31577`, `:31590` |
| Backflip | 4 × 0.25, then 6 + 4×rank (pass-through strip checked at the start of this leg) | 1.0 (strip only) | `Cat.cs:32171`, `:32198`, `:32208` |
| Pillage Plunge | 24 × 0.1 (pass-through strip checked at 0, before the dash) | 2.4 (damage box) | `Cat.cs:40042`, `:40052`, `:40172`, `:40278` |
| Heart Ripper | 2 × 0.2, then 0 | 0.4 (both hits) | `Cat.cs:33684`, `:33327`, `:33355`, `:33467` |
| Moon Blade | 0.5 × 0.2, 2 × 0.1 per hit | 0.3, 0.5 | `Cat.cs:35975`, `:35611`, `:35679`, `:35781` |

No movement before the hits (speed 0): Finishing Blow (it jumps back −8 × 0.2 only after its fourth hit, `Cat.cs:38995`), Delta Strike. Moon Storm's hit positions are fixed at `mPos + i × 1.5 m` and `mPos + 12 m` (the cast point, not the Cat; `Cat.cs:36415`, `:36521`).

### Normal attack combo (hit times are seconds from the start of stage 1; stage k > 1 waits for its anchor, see the mechanics reference §4.8)

| Stage | Starts at | Own waits and movement (m/s × s) | Hit at (s) | Moved at the hit (m) | Source |
|---|---|---|---|---|---|
| 1 | 0 | 3 × 0.2, then 9 × 0.2 | 0.4 | 2.4 | `Cat.cs:16866`, `:16361`, `:16520` |
| 2 | 0.6 | wait 0.1, then 7 × 0.3 | 1.0 | 2.1 | `Cat.cs:17186`, `:17318`, `:17609` |
| 3 | 1.2 | wait 0.1, then 4 (hits every 0.2 s) | 1.5, 1.7 | 0.8, 1.6 | `Cat.cs:17896`, `:18001`, `:18244`, `:18538` |
| 4 | 1.7 | wait 0.1, then 6 (hits every 0.2 s) | 2.0, 2.2 | 1.2, 2.4 | `Cat.cs:18867`, `:18972`, `:19213`, `:19511` |

Chained start offsets: stage 2 at 2.4, stage 3 at 4.5, stage 4 at 6.1.

## Skill Tree Layout & Learn Requirements

Verified 2026-10-12 for the Skill Simulator (rules: [12Tails-Mechanics-Reference.md §3.6](12t_reference/12Tails-Mechanics-Reference.md#36-skill-learning-rules-class-skill-window-verified-2026-10-12)). Each cell is `name Lv/points`: required level / skills already learned in the same tree. Cell number = `tree*100 + row*10 + column` (trees 1-4 = Treasure Hunter, Gambler, Assassin, Pirate King). Source: `CatSkill.getSkill` (`setReq`, `rSkill`) and `CatSkill.getSkillTree`.

**Treasure Hunter** (tree 1)

| Row | Cells |
|---|---|
| 1 | N Attack 1 1/0 · N Attack 2 2/1 · N Attack 3 3/2 · — |
| 2 | C Attack 1 4/1 · C Attack 2 10/2 · C Attack 3 16/3 · — |
| 3 | Awareness 1 6/2 · Awareness 2 12/4 · Treasure Hunt 18/6 · — |
| 4 | Feline Agility 1 8/4 · Feline Agility 2 19/6 · Feline Agility 3 24/8 · Feline Agility 4 32/10 |
| 5 | Stat Plus 1 10/4 · Stat Plus 2 20/6 · Stat Plus 3 30/8 · Stat Plus 4 40/10 |

**Gambler** (tree 2)

| Row | Cells |
|---|---|
| 1 | Lucky Card 1 3/0 · Lucky Card 2 9/1 · Lucky Card 3 15/2 · Lucky Card 4 21/3 |
| 2 | Fate Draw 1 5/1 · Fate Draw 2 11/3 · Fate Draw 3 17/5 · Fate Draw 4 23/7 |
| 3 | Power Shuffle 1 7/2 · Power Shuffle 2 13/4 · Life Gamble 19/6 · Skill Gamble 25/8 |
| 4 | Lucky Dice 1 9/3 · Lucky Dice 2 15/5 · Double Down 1 21/7 · Double Down 2 27/9 |
| 5 | Power One 16/4 · Power Two 20/8 · Power Three 24/12 · Power Seven 28/16 |
| 6 | Two Pair 1 20/12 · Two Pair 2 24/15 · Copycat 1 28/18 · Copycat 2 32/21 |
| 7 | Damage Roulette 1 24/15 · Damage Roulette 2 27/18 · Nine Lives 1 30/21 · Nine Lives 2 33/24 |
| 8 | Grand Casino Arcade 1 35/23 · Grand Casino Arcade 2 40/25 · — · — |

**Assassin** (tree 3)

| Row | Cells |
|---|---|
| 1 | Flying Dagger 1 3/0 · Flying Dagger 2 9/1 · Flying Dagger 3 15/2 · Flying Dagger 4 21/3 |
| 2 | Forward Lunge 1 5/1 · Reverse Thrust 1 11/3 · Forward Lunge 2 17/5 · Reverse Thrust 2 23/7 |
| 3 | Backflip 1 7/2 · Backflip 2 13/4 · Heart Ripper 1 19/6 · Heart Ripper 2 25/8 |
| 4 | Hidden Blade 1 9/3 · Hidden Blade 2 15/5 · Hidden Blade 3 21/7 · Hidden Blade 4 27/9 |
| 5 | Disarm 1 16/4 · Disarm 2 20/8 · Bleed 1 24/12 · Bleed 2 28/16 |
| 6 | Moon Blade 1 20/12 · Moon Blade 2 24/15 · Moon Storm 1 28/18 · Moon Storm 2 32/21 |
| 7 | Evasion 1 24/15 · Evasion 2 27/18 · Evasion 3 30/21 · Vendetta 33/24 |
| 8 | Delta Strike 1 35/23 · Delta Strike 2 40/25 · — · — |

**Pirate King** (tree 4)

| Row | Cells |
|---|---|
| 1 | No Chance 55/0 (needs N Attack 3) · Joker 55/0 (needs Lucky Card 4) · Three Knives 55/0 (needs Flying Dagger 4) · Revised Skill 55/0 |
| 2 | Double Focus 60/1 (needs C Attack 3) · Lady Luck 60/1 (needs Fate Draw 4) · Backstab 60/1 (needs Reverse Thrust 2) · Revised Magic 60/1 |
| 3 | Insight 70/3 (needs Treasure Hunt) · Even Odds 70/3 (needs Skill Gamble) · Finishing Blow 70/3 (needs Heart Ripper 2) · Revised Art 70/3 |
| 4 | Swift Pace 75/4 (needs Feline Agility 4) · Roll The Dice 75/4 (needs Double Down 2) · Jagged Knife 75/4 (needs Hidden Blade 4) · Pillage Plunge 75/4 (needs Two Pair 1 + Moon Blade 1) |
| 5 | Super Stat Plus 85/6 (needs Stat Plus 4) · Super Seven 85/6 (needs Power Seven) · Open Wound 85/6 (needs Bleed 2) · Support Fire 85/6 (needs Pillage Plunge) |

- **Class C prerequisites** (`rSkill`, each is a single skill from the trees above or from Class C itself): No Chance needs N Attack 3; Joker needs Lucky Card 4; Three Knives needs Flying Dagger 4; Double Focus needs C Attack 3; Lady Luck needs Fate Draw 4; Backstab needs Reverse Thrust 2; Insight needs Treasure Hunt; Even Odds needs Skill Gamble; Finishing Blow needs Heart Ripper 2; Swift Pace needs Feline Agility 4; Roll The Dice needs Double Down 2; Jagged Knife needs Hidden Blade 4; Pillage Plunge needs Two Pair 1 + Moon Blade 1; Super Stat Plus needs Stat Plus 4; Super Seven needs Power Seven; Open Wound needs Bleed 2; Support Fire needs Pillage Plunge.
- **Checked against the 2014 community simulator** (Rain Niar's Cat SkillSimulator V.3) **and TailsTailsSimulator.online/cat**: 94 of 97 cells have the same Lv / points in all three; the differences (game code first):
  - `felineAgility2` (Basic): game **19/6**, both simulators 18/6. The game value comes from an explicit jump to a shared `setReq`; the simulators may show an older server value. **Needs a live check.**
  - `felineAgility3` (Basic): game **24/8**, both simulators 28/8. The game value comes from an explicit jump to a shared `setReq`; the simulators may show an older server value. **Needs a live check.**
  - `felineAgility4` (Basic): game **32/10**, both simulators 38/10. **Needs a live check:** the cell is an empty `getSkill` branch (no `setReq`), so the decoder's value comes from the shared tail it falls into.
- The blog's simulator caps at Lv 95, the site at Lv 100 (its extra Class C row is ignored: there are no EX skills). Tree names come from the site (it spells the second tree "Glambler"; the game's item names say Gambler, so Gambler is used).

## Thai tooltip mismatches (scan 2026-10-27)

Every number in the BB Thai tooltip (`CatSkill_thai.cs`) was compared with the app card, then each suspect with the code. Each row is a card `tooltipNote`.

| Skill | Thai tooltip says | Code says | Source |
|---|---|---|---|
| Moon Storm | +10 / +15 dmg | `talAdjust(10×sLv + 5)` = **+15 / +25**, sLv 1 / 2 | `Cat.cs:36438`; calls `:5249`, `:5267` |
| Awareness (level 2) | 18 m | `12 × sLv` = **24 m** | `Cat.cs:8674`; calls `:3719`, `:3737` |
| Delta Strike, Three Knives | see their sections |  |  |

## Open items / could not verify

Open (dependency-line audit 2026-10-28; each needs a user decision or a live check). The Reborn item is under Server Balance Variations (Reborn), "Dependency-line audit".

1. **Power Number lines on every damage card:** should the class-wide `hit()` modifiers (Power One / Two / Three / Seven, Super Seven, and Charge Attack's `[damagePlus]`, +10 × level per hit for any attacker; `CharacterControl.cs:2838-3011`, `:3447-3479`) get a line on every damage card? Only Combo (nAttack) has Power Seven / Super Seven lines, and Charge Attack has the order line. Lucky Card, Double Down, Grand Casino Arcade (and since 2026-10-28 Lucky Dice) link Power Seven with no desc line. Flying Dagger, Forward Lunge, Reverse Thrust, Heart Ripper, Finishing Blow, Disarm, Bleed, Moon Blade, Moon Storm, Delta Strike, Pillage Plunge and Support Fire, plus Reborn's Broadside, Ghost Galleon and Shadow Upon Shadow, also go through `hit()` and get all three on BB / ToT / Reborn, with no line. On TTO only Tree A keeps Power. The page already shows the Power toggle on every Cat card (`isCatPowerApplicable`, `12t_projects/bible/index.html:11594-11600`); the Chameleon Mark of Slayer precedent is a toggle on several cards and a line on one. If lines are wanted, every Tree B / Class C card also needs a TTO desc without them.
   - **Decided 2026-10-28:** one standard line, no `[damagePlus]` lines and no new ring links. Every Cat card that draws the Power toggle carries the shared `CAT_POWER_LINE` (labelled **Power Seven:**, Super Seven folded in: HP ending in 1 / 2 / 3 / 7 gives raw damage +10 / 20 / 30 / 70%, and with Super Seven a 7 in any of the last four digits gives +70%); the Combo's Power Seven and Super Seven lines became that one line. Lucky Dice joins the list (`hit(230 + sLv)`, `Cat.cs:23962`). The page shows the line only while the card's Power toggle is on and hides it where the toggle is not drawn (`lineNeedsToggle`: TTO outside Class A), so no TTO desc copies were added. Cards and citations: the Power family section, "Which cards the floors reach".
2. **Two Pair: what it hands over and brings back, and the System clause:** should the card list them? The copy filter is only `sLv <= 2 × rank` plus the 13 names (`Cat.cs:25716-25900`, `:25960-26032`). Handed to an enemy: `[damagePlus]` up to level 4 with its stacks (Charge Attack without Double Focus, or Charge 1-2 with it), which gives the enemy +10 × level per hit (`CharacterControl.cs:3447-3479`); `[damageRoulette]` 1-2, so the enemy then redirects the Cat's hits to a random character within 24 m, the Cat included (`CharacterControl.cs:4832-4893`); `[fortune4]`; the Power Shuffle up / down pair. Brought back from the target: the Cat's own `[disarm2]`, which locks her normal attack and takes 20 MP / SP (`CharacterControl.cs:36285`); `[bleed2]`; Joker `[doom1]`; `[cut4]`; Delta Strike `[lock1]`. The Reborn tab with Jackpot Pair on already names the `damagePlus5` case; BB and the Reborn tab without it name none. Separately, the card's "ยกเว้นสถานะที่เป็น System" has no filter in the BB loop (`isSystemStatus` is read only for immunity, `CharacterControl.cs:12677`, and the debuff-resist roll, `:13660-13690`): should that clause stay?
   - **Decided 2026-10-28:** no change. The card keeps the rule it states (the level cap and the 13 excluded names), which already covers every status listed above, and the System clause stays; the per-status list and the missing System filter stay recorded here.
3. **Open Wound and the Iron + Diamond merge (BB / ToT / TTO):** any holder of skill 443, which includes a Cat with Open Wound, who has both Iron Shield and Diamond Shield gets them merged into `perfectArmor` instead of `perfectShield` (`CharacterControl.cs:11973-12029`); Reborn bible3 limits the merge to `Type == "Bison"` (Server Balance Variations (Reborn), bible3 list). Should the Open Wound card say so, and as which chip (`unintended`)? What `perfectArmor` does differently for a Cat was not traced.
   - **Decided 2026-10-28 (from the code):** closed, no card change. The merge never reaches a Cat: `RPC_AddStatus` refuses `ironShield`, `diamondShield`, `perfectShield` and `perfectArmor` on any character whose `Type != "Bison"` (`CharacterControl.cs:12184-12258`; the `break` leaves the method's `for (;;)`, `:10689`, `:14339`, so the status is dropped), so a Cat never holds the shield the merge checks for (`hasStatus("diamondShield")` / `hasStatus("ironShield")`, `:11979`, `:12013`), and a merged `perfectArmor` would be dropped by the same gate. The four are read only in the Bison block of `RPC_AddDamage` (`this.Type == "Bison"`, `:4011`, `:4085-4290`), as [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md) already states ("Non-Bisons can never hold any of the four"). ToT and TTO run the BB code here (no balance change touches the shields or Open Wound). Reborn keeps the same gate after the merge (`Reborn1027:CharacterControl.cs:9458`), so its bible3 `Type == "Bison"` check (`:9444`, `:9448`) changes nothing for a Cat either.

**Bible (2026-10-28, open-decision pass):** 20 Cat damage cards carry the one standard **Power Seven:** line (`CAT_POWER_LINE`): the Combo (its Power Seven and Super Seven lines merged into it), Lucky Card, Lucky Dice, Double Down, Grand Casino Arcade, Flying Dagger, Forward Lunge, Reverse Thrust, Heart Ripper, Disarm, Bleed, Moon Blade, Moon Storm, Delta Strike, Finishing Blow, Pillage Plunge, Support Fire, and on Reborn Broadside, Shadow Upon Shadow and Ghost Galleon. The Combo's TTO desc drops the merged line as it dropped the two before; the Reborn Pillage Plunge keeps its [salvation] bullet before the line. No `compatSkills` change and no `liveCheck` (Two Pair, the shield merge and the Reborn pillage copy-back are stated on no card).

**Bible (2026-10-28, follow-up pass):** the Reborn Two Pair tab with Jackpot Pair on gets a second limit line for the `[pillage5]` copy-back (Server Balance Variations (Reborn), "Dependency-line audit"), and Two Pair and Pillage Plunge link each other on Reborn only (`servers.reborn.compatSkills`). Item 3 (the shield merge) is closed from the code with no card change.

## Server Balance Variations

### Twelve Tails Online (TTO)
- **Feline Agility (#131–#134) Weight Reduction Removed:**
  - **Base BigBug Engine:** Each rank reduces Cat weight by −3 tg (`CharacterDataClass.cs:778, 795, 812, 829`), granting `+0.12` runspeed per rank (+0.48 at max rank) in addition to +5 AGI per rank (+0.10 runspeed per rank).
  - **TTO Server Balance Delta (live-server observation reported by user):** On TTO, Feline Agility no longer reduces weight. It only grants **+5 AGI per rank** (+20 AGI at max rank), yielding only `+0.10` moveSpeed per rank (+0.40 at max rank).

- **Power Number Series Restriction to Skill Tree A:**
  - **Base BigBug Engine:** In `CharacterControl.cs:2838-3010`, the Power Number series (`cat_powerOne`, `cat_powerTwo`, `cat_powerThree`, `cat_powerSeven`, `cat_superSeven`) checks `if (this.Type == "Cat")` inside `CharacterControl.hit()`, applying raw damage multipliers (`floor(raw × 1.1 / 1.2 / 1.3 / 1.7)`) globally to **all Cat damage skills** (Combo, Charge Attack, Skill Tree A Gambler skills, and Skill Tree B Assassin skills).
  - **TTO Server Balance Delta (live-server observation reported by the user, 2026-09-25; not in the decompiled client):** On TTO, the Power Number series buff is nerfed and restricted to **Cat Skill Tree A (Gambler branch)** damage skills only (e.g. Lucky Card, Lucky Dice, Damage Roulette). It no longer applies to basic attacks/Combo or Skill Tree B (Assassin branch) attacks.
  - **Support Fire (#444):** This Class C skill receives the Power Number raw-damage multiplier in the base BigBug `hit()` pipeline, but does not receive it on TTO under the observed Tree A restriction.

- **Swift Pace (#431) cooldown reset on player kill:**
  - **Base BigBug Engine:** the only cooldown write is `addTimeOut("swiftPace", agiAdjust(90f))` at cast (`Cat.cs:39712`); nothing in `Cat.cs` or `CharacterControl.cs` clears it early.
  - **TTO Server Balance Delta (reported by the user, 2026-09-28; not in the decompiled client):** killing a Player resets Swift Pace's cooldown.

- **Copycat (#243-244) clears the target's last damage in PvE:**
  - **Base BigBug Engine:** Copycat reads `tChar.mLastDamage` (`Cat.cs:26602-26608`) but never clears it; the only write is `RPC_AddDamage` (`CharacterControl.cs:31686`), so repeated casts can copy the same hit.
  - **TTO Server Balance Delta (reported by the user, 2026-09-28; not in the decompiled client):** in PvE, using Copycat clears the target's last damage immediately, so the next Copycat needs a new white-damage hit first.




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
- **Bible (2026-10-28):** the card's **Disarm:** / **Bleed:** lines say the extra 3 s comes before the CHA contest (ก่อนแข่งค่า CHA), like the Disarm and Bleed cards; they read as a flat 3 s before.
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
- **Finishing Blow takes over the button (verified 2026-10-28):** Finishing Blow (`cat_finishingBlow5`) has the same cType `heartRipper` as `heartRipper1` / `heartRipper2` (`CatSkill.cs:1284`, `:1684`); once it is learned the dispatcher's `cat_finishingBlow5` branch starts `RPC_finishingBlow1` after the same KO-target gate (`Cat.cs:6448-6495`). Both skills write the cooldown key `heartRipper` (`agiAdjust(60)` at `Cat.cs:32986`, `agiAdjust(120)` at `:38418`), which GameGui reads through `isTimeOut(skill.cType)`. Finishing Blow's four hits are fixed raw damage (`:38717`, `:38817`, `:38917`, `:39031`). **Bible (2026-10-28):** the Heart Ripper card names Finishing Blow (its 4 fixed-damage stabs replace this move, shared cooldown) on every server.

### cat_finishingBlow5 (#423) — active, Class C
- reqLv 70, reqBn 3, MP **20**, SP **−45** (red), mode target/enemy, `cType heartRipper` (shares Heart Ripper's cooldown key). Cooldown `agiAdjust(120)` (`Cat.cs:38418`). Same KO-target requirement as Heart Ripper (`Cat.cs:6440-6497`).
- `RPC_finishingBlow1` (`:38095`) teleports and chains into `RPC_finishingBlow2` (`:38531`); area `FindAreaTarget(pos, 1×rangeMod, 5)`. Four hit sites, each once: `hit(423, obj, 799, 0, 0, 0)` ×3 (`:38717`, `:38817`, `:38917`) and `hit(423, obj, 199, 0, 0, 0)` (`:39031`), **fixed raw damage** (no ATK, TAL or skill rank), KO 0. Total raw 2,596.
- **Open Wound fires on hit 3 only** (`:38923`); hits 1, 2 and 4 never call `OpenWound`.
- Also gives Backflip +1 lock-cleanse level (`Cat.cs:32432`, `hasSkill(423)`; see the Backflip entry).
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
- **Facing test per skill (verified 2026-10-28):** Forward Lunge doubles when `Quaternion.Angle(Cat, target) < 45` (`Cat.cs:30310`, `:30557`); Reverse Thrust thrusts along `-forward` and doubles only when the angle is `> 135`, i.e. Cat and target back to back (`:31392`, `:31629`). Both skip Structure, Buiten1-4 and ManaVortex targets (`:31414-31450`). **Bible (2026-10-28):** the Backstab card gave the 45° rule for both skills; it now gives each skill its own test.

### Open Wound wiring per skill (2026-09-26)
- Calls `OpenWound` on every landed hit of: Flying Dagger ×3, Forward Lunge ×5, Reverse Thrust ×2, Heart Ripper ×2, Disarm, Bleed, Moon Blade ×2, Moon Storm ×8, Delta Strike ×7, and Finishing Blow **hit 3 only**.
- **Combo (`nAttack1-4`, `Cat.cs:16500-19500`):** each strike has a Hidden Blade branch (`hit(331-334, …, hitDmg + hiddenBladeDmg)`, only when `mHiddenBladeDmg != 0` and the target is behind: angle `< 45 (+30 with Jagged Knife #433)`) and a normal branch (`hit(1-4, …, getCritPlus(hitDmg))`). Both branches call `OpenWound` **except stage 2's Hidden Blade hit** (`hit(332)`, `:17390`), whose landed block ends without it (the only `OpenWound` in that class is after the normal `hit(2)`, `:17507`). Stage 4 shares one `OpenWound` tail (`IL_8E7`, `:19099`) between both branches.
- **App toggle:** one Open Wound icon (default off). On assumes the target already has Disarm Lv 2 and Bleed Lv 2, so each carrying hit adds `30 × (2 + 2)` = 120 purple damage; on Disarm and Bleed it also adds the +3 s to their contested duration. Each card's description ends with an "Open Wound" line saying every hit, or which hits.
- Encoded in `index.html` as `effectProc.hits` (1-based hit numbers; absent = every hit): Finishing Blow `[3]`; Combo `[1,3,4,5,6]` while Hidden Blade is on, otherwise all six.

### cat_backflip1-2 — active, RANK FAMILY
- reqLv 7 / 13, reqBn 2 / 4, MP 0, SP **−3 / −5** (red, consumed), mode instant/self, `cType backflip` (`decode_skilldata.py`). Cooldown `agiAdjust(15)` for both ranks (`Cat.cs:32411`).
- **Cast** (`$RPC_backflip`, `Cat.cs:32024-32652`, `:32395-32432`): `actionState = "attack"`, `myCommand = "backflip"`, then `LookAt(mPos − flat(tDir))` turns the Cat around and `vMovement = forward` makes the jump go backwards; `removeLockStatus(2·sLv + (hasSkill(423) ? 1 : 0))` runs immediately. `hasSkill(423)` is Finishing Blow.
- **Timeline** (`:32582-32600`): waits 0.15 s → 0.25 s → 0.4 s → 0.1 s, then `actionState = "standby"` (`:32350`) = 0.9 s of `attack`/`backflip` state. `moveSpeed` is 0 for the first 0.15 s, 4 for 0.25 s (`:32171`), `6 + 4·sLv` = 10 / 14 for 0.4 s (`:32198`), then 0 (`:32329`).
- **Distance:** the client moves the Cat by `vMovement × moveSpeed × clamp(moveMod, 0.1, 2) × deltaTime` every frame (`CharacterControl.cs:2722`, same formula as the movement note in the mechanics reference), so the nominal jump is `4×0.25 + (6+4·sLv)×0.4` = **5.0 m (rank 1) / 6.6 m (rank 2)** at `moveMod = 1`. It scales with the Cat's `moveMod`, and each coroutine resume can add up to one frame to a wait, so treat the figures as nominal.
- **Pass-through** (`:32208-32294`): when the fast phase starts, characters found by `FindRecTarget(pos, forward, 1, 1, 4, 2)` (2 m wide, 4 m long, 2 m high, in the new facing direction) get `Physics.IgnoreCollision(cat, them, true)`; collision is restored when the fast phase ends. Only characters inside that strip at that moment are ignored, so a character beyond 4 m is not.
- **Evade** (`CharacterControl.cs:3207-3225`; mechanics reference §2.8): while `actionState == "attack"` and `myCommand == "backflip"`, any `hit()` against the Cat is evaded with 100% chance (no LCK roll) and returns 0. It is not limited to physical damage: the check is on the state, not the damage type. Effect Damage and status ticks never pass through `hit()`, so Backflip does not stop them (§2.8 "Not dodgeable"). Vendetta (#364) gives +10 SP per dodge (`:3230-3241`).
- **Bible (2026-10-28):** the Backflip card names Vendetta (`RPC_AddHeal(364, 0, 0, 10, …)` on each Backflip evade, `CharacterControl.cs:3219-3238`): +10 SP per dodge during the move, on every server.
- **Lock cleanse:** `removeLockStatus(nLv)` (`CharacterControl.cs:19456-19519`) removes `groundLock`, `needlePrison`, `sticky`, `frost` and `lightBind` whose level is ≤ `nLv` (the `lightBind` line is written as `> nLv → break`, the same rule). `nLv` = 2 / 4, or 3 / 5 with Finishing Blow. It never removes `lock` (Delta Strike's root).
- Client tooltips: EN "Perform a backflip, evading all physical damage. Removes all lv2 [lv4] lock status." / TH "กระโดดกลับตัวหลบการโจมตี ไปด้านหลัง แก้สถานะผิดปกติทางการเคลื่อนไหวที่ต่ำกว่า 3 [5]" (`CatSkill_eng.cs`, `CatSkill_thai.cs`). Code wins on "physical": the evade covers every `hit()`; the TH "lower than 3 / 5" equals the code's "≤ 2 / 4".
- Not traced: whether Backflip can be cast while rooted (the dispatcher, `Cat.cs:7395-7420`, has no extra gate), so the card does not claim it.

### cat_skillGamble2 (#224) — active, Tree A
- reqLv 25, reqBn 8, MP 0, Blue SP 5 (`decode_skilldata.py`). SP 5 is positive, so it is a threshold requirement, not consumed on cast (`GameGui.cs:37609`). Mode instant, target self, `cType skillGamble`.
- **Cooldown:** flat `agiAdjust(30f)` (`Cat.cs:23472`). Revised Art applies. Instant cast (no `DisplayCastBar`).
- **Roll & Evaluation:** `Random.Range(0, 100) < lckAdjust(50)` (`Cat.cs:23290`).
- **Success:** `mp = Min(FloorToInt(1.5f * mp), mmp)` and `sp = Min(FloorToInt(1.5f * sp), 100)` (`Cat.cs:23296-23306`), increasing current MP and SP by +50% (capped at max MP and 100 SP).
- **Failure:** if `hasSkill(422)` (Even Odds) and `isTimeOut("evenOdds") == 0f`, Even Odds intercepts (`Cat.cs:23328-23340`), putting Even Odds on cooldown for `agiAdjust(90f)` and skipping all loss (`goto IL_770`). Otherwise, current MP and SP are halved: `mp = CeilToInt(mp * 0.5f)` and `sp = CeilToInt(sp * 0.5f)` (`Cat.cs:23361-23371`).
- Client tooltips: TH "สุ่มเพิ่มหรือลด sp และ mp ของ แมว ครึ่งหนึ่งของที่มีอยู่ (50% success)" (`CatSkill_thai.cs:367`); EN "Instantly doubles Cat's mp and sp or reduces them by half (50% success)." (`CatSkill_eng.cs:345`). Code wins on success amount: it adds +50% of current (1.5x), matching the Thai text, not "doubles".

### cat_lifeGamble1 (#223) — active, Tree A
- reqLv 19, reqBn 6, MP 5, SP 0 (`decode_skilldata.py`). Mode instant, target self, `cType lifeGamble`.
- **Cooldown:** flat `agiAdjust(30f)` (`Cat.cs:22940`). Revised Art applies. Instant cast (no `DisplayCastBar`).
- **Roll & Evaluation:** `lckAdjust(50) > Random.Range(0, 100)` (`Cat.cs:22768`).
- **Success:** `RPC_AddHeal(223, FloorToInt(0.5f * hp), 0, 0, 0, 0, ActorNr)` (`Cat.cs:22774`), healing Cat for +50% of current HP.
- **Failure:** if `hasSkill(422)` (Even Odds) and `isTimeOut("evenOdds") == 0f`, Even Odds intercepts (`Cat.cs:22801-22813`), putting Even Odds on cooldown for `agiAdjust(90f)` and skipping all self-damage (`goto IL_578`). Otherwise, inflicts self-damage equal to 50% of current HP via `RPC_AddDamage(223, FloorToInt(0.5f * hp), 0, 0, Vector3.zero, ActorNr)` (`Cat.cs:22834`). Because the loss is 50% of current HP, it does not kill Cat outright if HP > 1.
- Client tooltips: TH "สุ่มเพิ่มหรือลด hp ของแมว ครึ่งหนึ่งของที่มีอยู่ (50% success)" (`CatSkill_thai.cs:356`); EN "Instantly doubles Cat's hp or reduces it by half (50% success)." (`CatSkill_eng.cs:334`). Code wins: heals +50% of current HP (1.5x), matching Thai text, not "doubles".

### cat_evenOdds5 (#422) — passive, Tree A, Class C
- reqLv 70, reqBn 3, MP 0, SP 0, mode passive, no cType (`decode_skilldata.py`, `CatSkill.cs:1143-1155`).
- **Gamble Protection:** When either Life Gamble (`Cat.cs:22801`) or Skill Gamble (`Cat.cs:23328`) fails, checks `hasSkill(422) && isTimeOut("evenOdds") == 0f`. If ready, fires `RPC_evenOdds` (`Cat.cs:9335`), which puts Even Odds on internal cooldown for `addTimeOut("evenOdds", agiAdjust(90f))` (`Cat.cs:9342`), plays `evenOdds_hit` VFX, and completely nullifies the failure penalty (no HP/MP/SP loss).
- **Power Shuffle Boost:** In `Cat.cs:22087-22093`, `if (hasSkill(422)) sLv++`. Power Shuffle's stat modifier formula is `FloorToInt(sLv * 0.2f * baseStat)`. Rank 1 (normally sLv 1 = 20%) becomes sLv 2 = 40%; Rank 2 (normally sLv 2 = 40%) becomes sLv 3 = 60%.
- Client tooltips: TH "ป้องกันความเสียหายจาก lifeGamble และ skillGamble หนึ่งครั้งทุก 90 วิ เพิ่มเลเวลของ powerShuffle ขึ้น 1เลเวล" (`CatSkill_thai.cs:983`); EN "Prevents loss from lifeGamble and skillGamble once every 90 sec. Increases level of powerShuffle by 1." (`CatSkill_eng.cs:961`). Code matches tooltips exactly.

### cat_powerShuffle1-2 (#221, #222) — active, Tree A, RANK FAMILY
- reqLv 7 / 13, reqBn 2 / 4, MP 0, Red SP **−5 / −10** (`decode_skilldata.py`, `CatSkill.cs:305-328`). Negative SP consumes SP (`GameGui.cs:37782`, rendered in red text at `:22032`). Mode instant, target self, `cType powerShuffle`.
- **Cooldown & Cast:** flat `agiAdjust(45f)` (`Cat.cs:22394`). Revised Art applies. Instant cast (`mode: instant`).
- **Reset Existing Power Buffs:** `removePowerStatus()` (`Cat.cs:22415`) cleanses any current `atkUp`/`atkDown` or related stat statuses before applying new ones, preventing overlapping stacks.
- **Stat Selection & Guaranteed Disjoint:** `mPowerPlus = UnityEngine.Random.Range(1, 9)` selects 1 of 8 stats to buff (1=ATK, 2=DEF, 3=AGI, 4=VIT, 5=MAG, 6=CHA, 7=TAL, 8=LCK). Then `mPowerMinus = (mPowerPlus + UnityEngine.Random.Range(0, 7)) % 8 + 1` mathematically guarantees the debuffed stat is never identical to the buffed stat (`Cat.cs:22072-22077`). Duration is `chaAdjust(30)` (`Cat.cs:22082`).
- **Even Odds Synergy:** `if (hasSkill(422)) sLv++` (`Cat.cs:22087-22093`). Power Shuffle's stat bonus formula is `FloorToInt(sLv * 0.2f * baseStat)`. Normally Rank 1 = 20% (sLv 1) and Rank 2 = 40% (sLv 2); with Even Odds learned, sLv increases by +1, boosting Rank 1 to **40%** (sLv 2) and Rank 2 to **60%** (sLv 3).
- Client tooltips: TH "สุ่มเพิ่มและลดค่าพลัง stat สองค่า (20%, 30 sec)" / "(40%, 30 sec)" (`CatSkill_thai.cs:30-32`); EN "Instantly increases and decreases Cat's 2 stat at random by 20% / 40% (30 sec)." (`CatSkill_eng.cs:30-32`).

### cat_doubleDown1-2 (#233, #234) — active, Tree A, RANK FAMILY
- reqLv 21 / 27, reqBn 7 / 9, MP **16 / 20**, Red SP **−20 / −24** (`decode_skilldata.py`, `CatSkill.cs:423-446`). Mode instant, target enemy, `cType doubleDown`.
- **Cooldown & Cast:** flat `agiAdjust(30f)` (`Cat.cs:24684`). Revised Art applies. Instant cast.
- **Target Detection & On-Screen Requirement:** Searches entities via `Damage.FindAreaTarget(pos, sLv * 6 + 12, 10, 130816)` (`Cat.cs:25047`), covering radius **18m** (Rank 1) and **24m** (Rank 2) with height 10m. Layer `130816` targets both enemies and allies. Targets must be visible on screen (`Math.isOnScreen`, `:25075`).
- **Hits & Selection:** Dispatches `sLv * 3 + 2` hits (**5 hits** at Rank 1, **8 hits** at Rank 2) via `doubleDown_fire` (`Cat.cs:25027`). Each hit picks a random on-screen target (`:25106`) and spawns `RPC_doubleDown_hit`.
- **Damage, KO, and SP Generation:** In `RPC_doubleDown_hit` (`Cat.cs:25358`), each hit executes `hit(232 + sLv, obj, talAdjust(sLv * 5 + 5), sLv * 3 + 2 + (hasSkill(432) ? 2 : 0), 0, Vector3.zero)`.
  - Base damage term: `talAdjust(10)` (Rank 1) / `talAdjust(15)` (Rank 2), with `atkCoeff: 0.5` through `dmgAdjust`.
  - Base KO: **5 KO** (Rank 1) / **8 KO** (Rank 2).
  - SP Gain: Every hit that connects (`!= 0`) grants Cat **+1 SP** (`this.mChar.sp = this.mChar.sp + 1`, `:25364`).
- **Roll the Dice Synergy:** `hasSkill(432)` (`Cat.cs:25358`, `:25392-25396`):
  - Adds **+2 KO** per hit (total 7 KO at Rank 1, 10 KO at Rank 2).
  - Doubles the hit explosion radius from **1m** (`mRange = 1`) to **2m** (`mRange = 2`).
- **Power Seven Synergy:** Affects Double Down through `hit()` (`CharacterControl.cs:2850-2924`), granting a **+70%** (x1.7) damage multiplier when Cat's HP ends with the digit 7.
- Client tooltips: TH "สุ่มทำความเสียหายแก่ศัตรู หรือเพื่อนในจอภาพ ระยะ 18 m รอบตัวแมว (10 dmg, 5 ko, x5hit)" / "24 m … (15 dmg, 8 ko, x8hit)" (`CatSkill_thai.cs:44-46`); EN "Repetitively deals damage to random enemies and allies within 18m / 24m area (10/15 dmg, 5/8 ko, 5/8 hit)." (`CatSkill_eng.cs:44-46`).

### cat_damageRoulette1-2 (#261, #262) — active, Tree A, RANK FAMILY
- reqLv 24 / 27, reqBn 15 / 18, MP **12 / 15**, Red SP **−12 / −15** (`decode_skilldata.py`, `CatSkill.cs:539-562`). Mode instant, target self, `cType damageRoulette`.
- **Cooldown & Duration:** Cooldown is flat `agiAdjust(60f)` (`Cat.cs:27071`). Applies buff `damageRoulette` at `sLv` for duration `chaAdjust(12)` (`Cat.cs:27052`).
- **Damage Redirection Mechanics:** In `CharacterControl.cs:4832-4913`, whenever Cat takes damage (`nDamage > 0`) while having `damageRoulette`:
  - Proc check: `Random.Range(0, 100) < lckAdjust(10 * statusLv + 10)` (`:4843`), giving base **20%** (Rank 1) / **30%** (Rank 2) chance, scaling with LCK.
  - On proc: Scans entities within 24m radius and 12m height (`Damage.FindAreaTarget(pos, 24, 12, 130816)`, `:4849`). One entry is picked at random from that list (`array[Random.Range(0, length)]`, `:4851`). If the pick is a different character (enemy or ally), it deals `RPC_AddEffectDamage(261, nDamage, 0, 0, Vector3.zero, ActorNr)` (`:4888`) to a randomly chosen target.
  - Complete damage nullification: Cat's incoming damage, KO, and hate are completely zeroed out (`nActionCode = -85; nDamage = 0; nKo = 0; nHate = 0;`, `:4893-4908`). **If the random pick is the Cat itself** (`gameObject3 == this.gameObject`, `:4856`), or the list is empty, nothing happens: no redirect and no nullification, so the Cat takes the hit normally (corrected 2026-10-03; an earlier version said the Cat was excluded from the pick).
- Client tooltips: TH "ทำให้มีโอกาสสะท้อนความเสียหายที่แมวได้รับไปยังศัตรูหรือ เพื่อน (20% chance, 12 sec)" / "(30% chance, 12 sec)" (`CatSkill_thai.cs:58-60`); EN "Temporary gives Cat a 20% / 30% chance to redirect its taken damage to other target (12 sec)." (`CatSkill_eng.cs:58-60`).
### cat_twoPair1-2 (#251, #252) — active, Tree A, RANK FAMILY
- reqLv 20 / 24, reqBn 12 / 15, MP 0, Red SP **12 / 18** (`decode_skilldata.py`, `CatSkill.cs:487-510`). SP is positive, consumed on cast (`GameGui.cs:37782`). Mode target, target all (`eSkillTarget.all`, `:1929`), `cType twoPair`.
- **Cooldown & Cast:** flat `agiAdjust(120f)` (`Cat.cs:26168`). Revised Art applies. Cast time instant.
- **Bidirectional Status Synchronization (Cross-Copy):** In `Cat.$RPC_twoPair$21857` (`Cat.cs:25716-26058`):
  - Checks all statuses on Cat (`mStatusList`) and Target (`tStatusList`).
  - Level filter: `sLv <= rank * 2` (Rank 1: `sLv <= 2` / "ต่ำกว่า 3"; Rank 2: `sLv <= 4` / "ต่ำกว่า 5").
  - Copies eligible statuses from Cat to Target, and from Target to Cat.
  - Duration: Remaining time is preserved exactly via `(int)(status.sTime - Time.time)`.
  - Blacklist (13 excluded statuses): `noDamage`, `noForce`, `overPresence`, `overLord`, `lastHope`, `swallow`, `gobble`, `charm`, `mindControl`, `nightmare`, `mimic`, `allMimic`, `transform`.
- **Damage & KO:** 0 damage, 0 KO.
- Client tooltips: TH "ทำให้แมวและเป้าหมายติด สถานะขั้นต่ำกว่า 3 [5] ที่ทั้งคู่มี อยู่ทั้งหมด" (`CatSkill_thai.cs:48-50`); EN "Both Cat and target share all status effects that are lower than level 3 [5]." (`CatSkill_eng.cs:48-50`).
- **No System-status filter (verified 2026-10-28):** both copy loops check only `sLv <= 2 × rank` and the 13 names (`Cat.cs:25816-25900`, `:25960-26032`); `StatusData.isSystemStatus` is read only for immunity (`CharacterControl.cs:12677`) and the debuff-resist roll (`:13672`). The card's "ยกเว้นสถานะที่เป็น System" clause has no filter behind it in this loop (Open items, 2).
- **Copied Cat statuses work for any holder (verified 2026-10-28):** `damagePlus` adds `+10 × level` in `hit()` and spends a stack with no Type gate (`CharacterControl.cs:3447-3479`), and `damageRoulette` redirects the holder's incoming white damage with no Type gate (`CharacterControl.cs:4832-4893`), so a copy handed to an enemy works for that enemy (Open items, 2).

### cat_swiftPace5 (#431) — active, Tree B, Class C
- reqLv 75, reqBn 4, MP 0, Red SP **−10** (`decode_skilldata.py`, `CatSkill.cs:1031-1054`). Mode target, target enemy, `cType swiftPace`.
- **Cooldown & Cast:** flat `agiAdjust(90f)` (`Cat.cs:39712`). Revised Art applies. Cast time instant.
- **Target Conditions:** Target must receive movement and gravity (`target.recieveMovement && target.recieveGravity`, `Cat.cs:6542-6548`); otherwise fails with `"Cannot use on that target"`.
- **Teleport Mechanics:** Computes spawn position behind target: `Math.getSpawnPos(target.position - (target.collider.bounds.extents.x + 0.5f) * target.forward)` (`:6557`). If obstructed (`Vector3.zero`), cancels with `"Not enough space."` and refunds MP/SP (`returnMPSP`). On success, warps Cat behind target (`KOIRnET4pM.position = spawnPos + 0.1f * Vector3.up`, `:39597`) and turns to face target (`LookAt`, `:39715`).
- **Tactical Synergy:** Instantly positions Cat for backstab angle checks on **Hidden Blade** (`mHiddenBladeDmg`) and **Backstab** (x2 multiplier on Forward Lunge and Reverse Thrust).
- **Range:** no distance gate in `Cat.cs:6528-6600`; the limit is the client's 40 m target lock (`GameGui.cs:4339`, see Mechanics Reference). Card desc: "ในระยะ **40m**".
- **Damage & KO:** 0 damage, 0 KO.
- Client tooltips: TH "วาร์ปแมวไปข้างหลังเป้าหมาย" (`CatSkill_thai.cs:104`); EN "Instantly teleports Cat to behind the target." (`CatSkill_eng.cs:104`).

### cat_pillagePlunge5 (#434) — active, Tree B, Class C
- reqLv 75, reqBn 4, MP 15, Red SP **−30** (`decode_skilldata.py`, `CatSkill.cs:1396-1419`). Mode instant, target enemy, `cType pillagePlunge`.
- **Cooldown & Mobility:** flat `agiAdjust(120f)` (`Cat.cs:40444`). Revised Art applies. Dashes forward with `moveSpeed = 24` (`:40042`) and temporarily ignores character collision (`Physics.IgnoreCollision`, `:40087`).
- **Damage & KO:** Hits in a rectangular box centred on the Cat: `FindRecTarget(position − 2×forward, forward, 2, 2, 4, 2)` (`:40172`) = 4m long (2m behind to 2m ahead), 4m wide (half-width 2), 2m tall via `hit(434, target, (int)(1.5f * atk + talAdjust(45)), 0, 0, 0.5f * Vector3.up)` (`:40195`).
  - Scaling: **1.5 × ATK + talAdjust(45)** (`atkCoeff: 1.5`, `talAdjust(45)`).
  - KO: 0 (slight knock-up `0.5 * Vector3.up`).
- **Status Application (`pillage` Lv 5):** `RPC_AddStatus("pillage", 5, Damage.getDebuff(30f, caster.cha, target.cha), 0, ActorNr)` (`:40217`). Base duration 30s, contested by target CHA.
- **Pillage Status Effects (`CharacterControl.cs:36450-36579`):**
  1. **Purges 8 Shields:** Immediately cleanses `ironShield`, `diamondShield`, `perfectShield`, `bubbleShield`, `salvation`, `iceShield`, `reverse`, `repel` (`:36454-36475`).
  2. **Player Target (Forcible Armor Strip):** If target is a player and has an empty inventory slot (`getEmptyInventorySlot()`), forcibly un-equips body armor into inventory (`equipment[1]`, `SendMessage("EquipArmor", "none")`, `:36508-36530`) and displays `"You got pillaged!"`.
  3. **Monster / NPC Target (Permanent DEF Reduction):** `target.def = Mathf.Max(target.def - sLv * 2, 1)` (`:36574`). With `sLv 5`, reduces monster base DEF by **10** (minimum 1 DEF) permanently for the monster's lifespan.
- **While the status lasts (verified 2026-09-27), the duration does matter:**
  1. **Shield block:** `RPC_AddStatus` rejects any incoming `isShieldStatus` with `sLv <= getStatusLv("pillage")` (`RPC_AddDamage(-83)` + `break`, `CharacterControl.cs:13061-13078`). Shield statuses: `bubbleShield`, `diamondShield`, `iceShield`, `ironShield`, `perfectArmor`, `perfectShield`, `repel`, `reverse`, `salvation` (`StatusData.isShieldStatus`, `:6241`) — so Pillage Lv 5 blocks re-shielding for its whole duration, including `perfectArmor`, which the initial purge does not remove.
  2. **No re-equipping armor:** equipping into the armor slot, from the inventory (`GameGui.cs:13119`) or the equip command path (`:35394`), is refused with "You have been pillaged!" while `hasStatus("pillage")`. Armor slot only: the accessory (`GameGui.cs:13204`, `:35487`), boots (`:13266`, `:35556`) and weapon branches of the same handlers have no Pillage check.
  - `removeStatus("pillage")` has no reversal (`CharacterControl.cs:16278`, empty branch), so the monster DEF loss stays.
- Client tooltips: TH "พุ่งเข้าลอกคราบเป้าหมาย ทำให้ armor หลุดออกจากตัว player หรือลด 10Def ถาวรเมื่อใช้กับ NPC (12 Sec)" (`CatSkill_thai.cs:115`); EN "Dashes and strips enemy armor or permanently reduces NPC's DEF by 10 (12 Sec)." (`CatSkill_eng.cs:115`). Note: Code wins over tooltip's "(12 Sec)" note: base duration is `Damage.getDebuff(30f, caster.cha, target.cha)`.

### cat_felineAgility1-4 (#131, #132, #133, #134) — passive, Tree B, RANK FAMILY
- reqLv 8 / 19 / 24 / 32, reqBn 4 / 6 / 8 / 10, MP 0, SP 0 (`decode_skilldata.py`, `CatSkill.cs:2420-2463`). Mode passive, target null, `cType null`.
- **Stat Modifications (`CharacterDataClass.cs:767-834`, `CharacterControl.cs:23001-23060`):**
  - **AGI:** Each rank adds **+5 AGI** to `statList[2]` (Rank 1: +5, Rank 2: +10, Rank 3: +15, Rank 4: +20).
  - **Weight Reduction:** Each rank subtracts **3 tg** from `this.weight` (Rank 1: −3 tg, Rank 2: −6 tg, Rank 3: −9 tg, Rank 4: −12 tg). Cat base weight is 35 tg (`CharacterData.cs:175`).
- **Effect on Runspeed (`CharacterDataClass.cs:979`):**
  - Formula: `runspeed = 0.01f * ((400 + 2 * AGI) - 4 * Mathf.Max(weight + reducedWeight, 0))`
  - Decreasing weight by 3 tg adds `0.01 * 4 * 3 = +0.12` to `runspeed` per rank (+0.12 / +0.24 / +0.36 / +0.48).
  - Increasing AGI by 5 adds `0.01 * 2 * 5 = +0.10` to `runspeed` per rank (+0.10 / +0.20 / +0.30 / +0.40).
  - Total runspeed increase: **+0.22** per rank (+0.22 / +0.44 / +0.66 / +0.88).
- Client tooltips: TH "ลดน้ำหนักตัวลงเพื่อเพิ่มความเร็วให้กับแมว (-3 tg, +5 agi)" (`CatSkill_thai.cs:136`); EN "Reduces Cat's weight to increase move speed (-3 tg, +5 agi)." (`CatSkill_eng.cs:136`).
- **Server Balance Variations (TTO):** Weight reduction is removed on TTO. Only the +5 AGI per rank applies (+0.10 moveSpeed per rank). See Server Balance Variations above.

### cat_copycat1-2 (#243, #244) — active, Tree A, RANK FAMILY
- reqLv 28 / 32, reqBn 18 / 21, MP **18 / 24**, SP 0 (`decode_skilldata.py`, `CatSkill.cs:513-535`, `:2754-2765`). Mode target, target enemy (`CatSkill.cs:1904-1905`), `cType copycat`.
- **Cooldown & Cast:** flat `agiAdjust(120f)` (`Cat.cs:26723`). Revised Art applies. Cast time instant (plays animation `pointTarget`, `Cat.cs:26732`).
- **Target Lock & Execution:** Targets an enemy within target lock range (up to 40m, `GameGui.cs:4339`). Checks target's `mLastDamage` (`Cat.cs:26602`).
- **Damage Formula & Effect Damage Pathway (`Cat.cs:26608`):**
  - Executes: `tChar.RPC_AddEffectDamage(252 + sLv, (int)((0.25f * sLv + 0.5f) * tChar.mLastDamage), 0, 0, Vector3.zero, caster.ActorNr)`.
  - Multiplier:
    - Rank 1: `(0.25 * 1 + 0.5) = 0.75` (**75% of target's mLastDamage**).
    - Rank 2: `(0.25 * 2 + 0.5) = 1.00` (**100% of target's mLastDamage**).
  - Damage Type: **Effect Damage (ดาเมจม่วง)** — bypasses target DEF (`defAdjust`), bypasses `dmgMod`, cannot be dodged or blocked (`hit()` bypassed), and scales with target's `hitMod` (Floor after `hitMod`).
  - KO: 0 (`nKo: 0`).
- **Engine Mechanic — `mLastDamage` Filter:**
  - In `CharacterControl.cs:31686`, `mLastDamage` is ONLY written by regular damage (`RPC_AddDamage`). `RPC_AddEffectDamage` (`:6209, :6559-7000`) does NOT write to `mLastDamage`.
  - Thus, Copycat only replicates **Regular Damage (white damage)**. Effect damage (such as Poison DoT, Dark Edge, or another Copycat) is ignored and will not overwrite the target's `mLastDamage`.
  - If `mLastDamage <= 0` (target has not yet taken regular damage), Copycat fails and alerts: `"Copycat fail: no damage to copy"` (`Cat.cs:26635`).
- Client tooltips: TH "ทำความเสียหายที่เป้้าหมาย ได้รับครั้งสุดท้ายอีกครั้ง (75% dmg)" / "(100% dmg)" (`CatSkill_thai.cs:488, 499`); EN "Instantly deals damage equal to 75% / 100% of the last damage that its has received." (`CatSkill_eng.cs:466, 477`).

### cat_evasion1-3 (#361, #362, #363) — passive, Tree B, RANK FAMILY
- reqLv 24 / 27 / 30, reqBn 15 / 18 / 21, MP 0, SP 0 (`decode_skilldata.py`, `CatSkill.cs:3106-3128`). Mode passive, target null, `cType null`.
- **Evasion Chance & Multiplier (`CharacterControl.cs:3246-3359`):**
  - Base chance: `rank * 4%` (Rank 1: **4%**, Rank 2: **8%**, Rank 3: **12%**).
  - Running Bonus: When moving/running (`actionState == "run"`), base chance is doubled (`num2 *= 2` → Rank 1: **8%**, Rank 2: **16%**, Rank 3: **24%**).
  - Scaling: `UnityEngine.Random.Range(0, 100) < characterControl.lckAdjust(chance)` (scaled by Cat's own LCK).
- **Execution & Status Restrictions:**
  - Hard CC Check: the `sleep`, `snowMan`, `snowBall`, `petrify`, `paralysis` checks read `this.getStatus(...)` (`CharacterControl.cs:3252-3276`), and in `hit()` (`:2807`) `this` is the **attacker**, `characterControl` the Cat: so on BB the Cat's own statuses do not stop the dodge (an attacker under those statuses blocks it instead). The card's limit line states the intended rule, which Reborn build bible3 implements (Server Balance Variations (Reborn) below). Corrected 2026-10-27 (this line said the Cat's statuses).
  - On Successful Evade: Dispatches `RPC_AddDamage(-82)` (displays `EVADE` combat popup), cancels incoming damage and KO entirely (returns 0 damage).
  - Synergy with `cat_vendetta`: Automatically triggers `characterControl.RPC_AddHeal(364, 0, 0, 10, 0, 0, characterControl.ActorNr)` to restore **+10 SP** if `cat_vendetta1` is learned.
- Client tooltips: TH "ทำให้แมวมีโอกาสหลบการโจมตี และเพิ่มเป็นสองเท่าหากวิ่งอยู่ (4% / 8% / 12%)" (`CatSkill_thai.cs:836-867`); EN "Gives Cat a chance to evade attacks and doubles the chance when running (4% / 8% / 12%)." (`CatSkill_eng.cs:836-867`).

### cat_vendetta1 (#364) — passive, Tree B, Class C
- reqLv 33, reqBn 24, MP 0, SP 0 (`decode_skilldata.py`, `CatSkill.cs:3139`). Mode passive, target null, `cType null`. Requires `cat_evasion3`.
- **Mechanics (`CharacterControl.cs:3238, 3347`):**
  - Triggers on every successful Evade performed by Cat.
  - Compatible with all Cat evasion sources: passive `cat_evasion` and active iframe during `cat_backflip`.
  - Effect: Dispatches `characterControl.RPC_AddHeal(364, 0, 0, 10, 0, 0, characterControl.ActorNr)`, instantly restoring **+10 SP** (Blue SP).
- Client tooltips: TH "เพิ่ม 10 sp ให้แมวทุกครั้งที่แมว evade สำเร็จ" (`CatSkill_thai.cs:869`); EN "Restores 10 SP every time Cat successfully evades an attack." (`CatSkill_eng.cs:869`).

### cat_nineLives1-2 (#263, #264) — passive, Tree A, RANK FAMILY
- reqLv 30 / 33, reqBn 21 / 24, MP 0, SP 0 (`decode_skilldata.py`, `CatSkill.cs:2798-2809`). Mode passive, target null, `cType null`.
- **Trigger & Activation (`Cat.cs:207-350`):**
  - Fires upon receiving lethal damage (`hp <= 0`, `actionState != "dead"`, and `getStatus("death") == null`).
  - Priority Order on Death:
    1. `blackServant` (revives / consumes status).
    2. `autoLife` (revives with `sLv * 100` HP).
    3. Small Anubi Pet (`p_sab`).
    4. `cat_nineLives` proc check.
  - Proc Chance: `UnityEngine.Random.Range(0, 100) < this.mChar.lckAdjust(nineLivesLv * 6)` → Base **6%** (Rank 1) / **12%** (Rank 2), scales with Cat's LCK via `lckAdjust`.
  - **Death Status Check vs Doom:** `getStatus("death") == null` checks specifically for the `death` status (applied by Panda's Instant Death / arena hazards). `doom` deals 330 Effect Damage upon expiration rather than applying `death`, so Nine Lives can still trigger when killed by `doom` damage.
- **Revival Effects (`Cat.cs:27238-27674`, `$RPC_nineLives$21898`):**
  - Revives Cat with **HP 99** (`mChar.hp = 99`).
  - Resets KO to full max KO (`mChar.ko = mChar.mko`).
  - Grants **3 seconds of Invincibility (noDamage)**: `mChar.StartCoroutine_Auto(mChar.addStatus("noDamage", 1, 3, 0, ActorNr))`.
  - Sets client visual cooldown bar: `mChar.addTimeOut("nineLives", mChar.agiAdjust(60f))` (**60s base cooldown**, reduced by Cat's AGI via `agiAdjust`). Note: `Cat.cs:334` does not check `getTimeOut("nineLives")`, so the revival proc check executes whenever lethal damage is received.
  - Plays animation `getUp` and character voice line (`nineLives1` / `nineLives2`).
- Client tooltips: TH "ทำให้แมวมีโอกาสฟื้นคืนชีวิตเมื่อตาย (6% / 12%)" (`CatSkill_thai.cs:528-548`); EN "Gives Cat a chance to revive upon death (6% / 12%)." (`CatSkill_eng.cs:528-548`).


### ToT EX learning requirements (published simulator, 2026-10-13)

Source: [ToT cat simulator dataset](https://talesoftails.net/data/skill-simulator/cat.json), with learning rules from [ToT simulator client](https://talesoftails.net/_next/static/chunks/673.2ecb414e00f7368e.js). These are server-specific published simulator requirements, not BigBug decompiled mechanics or verified damage formulas. Icons were extracted from the site’s `/gamegui/skill-simulator/skills/` assets and embedded in the hub.

| Cell | Published skill name | Level | Ordinary C skills required | Explicit prerequisite cells | Type / availability |
|---|---|---|---|---|---|
| 451 | UpdamageMonter | 95 | 0 | None | Passive |
| 452 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 453 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 454 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 461 | DowndamageMonter | 95 | 0 | None | Passive |

Each learned EX skill costs one point from a separate EX pool: 0 below Lv 95, 1 at Lv 95–99, 2 at Lv 100. Cells 451 and 461 exclude each other. At most one of cells 452–454 may be learned. EX skills never count toward ordinary C point requirements. All explicit prerequisites and the six ordinary C skills must remain learned; refunds and tree resets enforce this. See [shared ToT EX rules](12Tails-Mechanics-Reference.md#tot-ex-skills-published-simulator-2026-10-13).

The three Lv 100 slots currently have placeholder names/art in the published dataset. The hub shows them as unavailable and does not invent skills or permit spending points on them.

## Server Balance Variations (Reborn)

Reborn client (`DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/`, build and tags in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §1) against BB, traced 2026-10-26; card `servers.reborn`. `Reborn:` = the Reborn decompile, `BB:` = `DecompiledSource/`. Finishing Blow's Reborn change is in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §7.4.

- **Moon Blade / Moon Storm: cut on a Salvation block (Buff):** BB applies `cut 2 × sLv` (1 s) only inside the landed-hit branch (`BB:Cat.cs:35739`, `:35841`; `:36475`, `:36581`), and `hit()` returns 0 on a `salvation` target (`BB:CharacterControl.cs:3067`). Reborn adds `else if (RebornCombat.SalvationBlocked)` with the same `cut 2 × sLv` (`Reborn:Cat.cs:6280-6288`, `:6322-6330`; `:6546-6554`, `:6588-6596`), no skill gate (the `CatMoonStripOnSalvation` call there is the C6 Lunar Tempest hook). The flag is cleared at the start of every `hit()` and set only on the salvation branch (`Reborn:CharacterControl.cs:7049`, `:7119-7123`); `cut` removes Magical Shield statuses of level ≤ its own (`Reborn:CharacterControl.cs:2497-2527`), and Whale Salvation (level 1-2, `Reborn:Whale.cs:12523`, `:12529`) is one (`Reborn:StatusData.cs:1591`, `:1618`).
- **Pillage Plunge on a Salvation block (Buff):** BB applies `pillage 5` (`getDebuff(30, CHA, target CHA)`) only after `hit(434, …) != 0` (`BB:Cat.cs:40195-40217`). Reborn applies the same status on a Salvation-blocked hit (`Reborn:Cat.cs:7809-7815`); the pillage handler removes `salvation` with the other shields (`Reborn:CharacterControl.cs:2545-2554`).
- **Gear crit (Adjust; `cat_nAttack`):** BB `getCritPlus` rolls `lckAdjust(gear sum)` (`BB:Cat.cs:15410`). Reborn adds `RebornBalance.TrinketCritPlus` (+3 for `t_all61`-`63`) and the seal `critical` (`RebornEffects.CritPlus`, server data, not modelled) and rolls `lckItemAdjust(sum)` = `ceil(1.3 × sum)` with no LCK (`Reborn:Cat.cs:16803`, belt `:16833`, roll `:16835`). In the app: the shared Reborn rule (`critChance`, `procChance`, `itemChance`) and the belt toggle `REBORN_BELT_DEP`; [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §2.2, §2.4.

### Review corrections (2026-10-26)

- Night Eye blocks white damage and KO only (its hook is in `RPC_AddDamage`, `Reborn:CharacterControl.cs:7343`); Guard Tower strikes are Effect Damage (`Reborn:GuardTower.cs:75-109`) and still land (desc and limit fixed).
- Awareness: a `**Veil Of Hunt:**` line (strips `[huntVeil]` from every enemy it reaches, `Reborn:RebornC7Passive.cs:858-861`). Ninth Life: the +50% speed lasts 3.5 s, `[invisible3]` its own 4 s.
- **Modelled since 2026-10-26 (`hitPurple`, user decision):** Lunar Tempest's 20% DEF-skipping purple hits on Moon Blade / Moon Storm (`Reborn:RebornC6Passive.cs:88-92`, `:109-112`, then `RPC_AddEffectDamage` after dmgAdjust, `Reborn:CharacterControl.cs:7265-7283`) and Shadow Upon Shadow's `max(1, floor(0.3 × dmg))` purple per shade on every Combo hit (`Reborn:RebornC7Passive.cs:645-661`): Moon Blade / Moon Storm roll the 20% purple outcome per hit (no LCK, after dmgAdjust and FinalOut, no DEF, hitMod rounded down; Moon Blade rank 2 at ATK / TAL 300, DEF 100: 285-315 white, 514-550 purple per hit), and Combo has a 0-3 shade toggle (`REBORN_CAT_SHADOW_DEP` in its damage header) adding the shades' purple to each white hit except Hidden Blade's backstab.
- Start-of-map cooldown (every combat map: missions, PvP and combat zones, `RebornZone.CombatMap`, `Reborn:RebornZone.cs:28-38`; Revised Art applies, `Reborn:CharacterControl.cs` `addTimeOut`; card bullet on each): Broadside `agiAdjust(300)`, Ghost Galleon `agiAdjust(360)`.
- Two Pair copies (`RebornC6.PairCopy`, `Reborn:Cat.cs:3169-3191`) skip Unyielding Oath's +1 level and Doomsayer's doom boost (`pairCopy`, `Reborn:RebornC7Passive.cs:800-812`, `:835`): limit line and links on Two Pair.

### C6 / C7 skills (Reborn only)

Traced 2026-10-26 against the build in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §1. All eight are one rank (`<name>5` keys), learned at Lv 95 (C6) / Lv 105 (C7) with 8 Class C skills (`setReq`, not on cards); data `Reborn:CatSkill.cs:387-435`, tree ids `Reborn:CatSkill.cs:1026-1036` (451-454), `:1053-1064` (461-464); tooltips `Reborn:CatSkill_thai.cs:13-28`, `Reborn:CatSkill_eng.cs:13-28`. No Thai names in the code (`rbNameOverride`, `Reborn:SkillData.cs:197-200`, only names the C6 four). Hooks: `RebornC6Passive.OnHitOut` / `SkipDef` / `AfterHit` run inside `hit()` (`Reborn:CharacterControl.cs:7240-7290`: `damagePlus` +10 × sLv first, then C6 / C7 `OnHitOut`, `dmgAdjust` (No Chance only for codes < 10), `SkipDef`, `defAdjust`, C7 `FinalOut`, then `RPC_AddEffectDamage` when `SkipDef` is true, else `RPC_AddDamage`, then both `AfterHit`s). Card wiring: Reborn-only dep toggles `REBORN_CAT_PREDATOR_DEP`, `REBORN_CAT_JACKPOT_DEP`, `REBORN_CAT_LUNAR_DEP`, `REBORN_CAT_NIGHTEYE_DEP`, `REBORN_CAT_NINTHLIFE_DEP`, `REBORN_CAT_SHADOW_DEP` in the BB cards' `servers.reborn`.

- **`cat_predatorFocus` (451, passive; needs No Chance 401 + Double Focus 411, `Reborn:CatSkill.cs:413-417`):** on every landed hit with action code < 10 (the six Combo passes `hit(1..4)`, `Reborn:Cat.cs:179`, `:405`, `:621`, `:693`, `:919`, `:989`; Hidden Blade's replacement hits are 331-334 and never roll in the 2026-10-25 build; bible3 rolls them too, see the bible3 list below), `Random(0,100) < lckAdjust(20)` calls `RebornC6.CatPredatorFocus` (`Reborn:RebornC6Passive.cs:168-172`). That adds `damagePlus` at level `getChargeLv() + 2` (Double Focus) with `level + 1` stacks for `chaAdjust(12)` (`Reborn:RebornC6.cs:1872-1889`; `getChargeLv` `Reborn:Cat.cs:14412-14427`): with the learn chain (411 needs Charge Attack 3) always `[damagePlus5]` × 6, a full Double Focus charge. A re-proc refills to 6 stacks and resets the time (`Reborn:CharacterControl.cs:9632-9651`). It rolls after the hit's own damage, so the bonus starts on the next `hit()`; a dodged, blocked or blind-missed hit never reaches `AfterHit` (`Reborn:CharacterControl.cs:7099-7258`), and a blind miss still spends a stack (`:7242-7258`). No zone gate (Charge Attack's tick needs `RebornZone.Combat`, `Reborn:Cat.cs:1160`). Changes: Combo (`servers.reborn.secondaryLckProc` with the dep, desc line), Charge Attack and Double Focus (Reborn `descDep` lines). `damagePlus` is Buff + Physical in both builds (`Reborn:StatusData.cs:1584`, `:1629`; `BB:StatusData.cs:5421`, `:6644`); the page's `STATUS_CLASS_MAP` and the Charge Attack card said Magical and were corrected on every server.
- **`cat_jackpotPair` (452, passive; needs Copycat 2, `Reborn:CatSkill.cs:418-422`):** Two Pair's level filter in both copy loops is `sLv <= RebornC6.CatPairCap(cat, rank)` (`Reborn:Cat.cs:3167`, `:3187`) = `2 × rank` without 452, `max(7, 2 × rank)` = 7 with it (`Reborn:RebornC6.cs:1847-1854`). Copycat's damage `(int)((0.25 × rank + 0.5) × target.mLastDamage)` goes through `CatCopyDmg` = `ceil(1.25 × x)` with 452 (`Reborn:Cat.cs:3367`, `Reborn:RebornC6.cs:1863-1870`), still Effect Damage `RPC_AddEffectDamage(252 + rank, …)` (`Reborn:Cat.cs:3369`); with 254 learned that is 125% of the last white hit. Side effect of the cap 7: the Cat's own `[damagePlus5]` (Predator Focus, or Charge Attack 3 + Double Focus) is copied to the target with its stacks, and `hit()` gives any attacker +10 × level per hit from it (`Reborn:CharacterControl.cs:7242-7251`). The Thai tooltip's `สลับ` (swap) is a copy in the code (the source keeps its status), the same as BB Two Pair. Changes: Two Pair (Reborn `descDep`: level `2 / 4` → 7, line, damagePlus limit) and Copycat (Reborn `descDep` line ×1.25).
- **`cat_lunarTempest` (453, passive; needs Moon Storm 2, `Reborn:CatSkill.cs:423-427`):** for action codes 351-354 (Moon Blade and Moon Storm both `hit(350 + rank)`, `Reborn:Cat.cs:6268`, `:6310`, `:6534`, `:6576`) `dmg = ceil((float)dmg × 1.3f)` after Power and `damagePlus`, before `dmgAdjust` / DEF (`Reborn:RebornC6Passive.cs:87-92`), and a flat `Random(0,100) < 20` (no LCK) marks the hit for `SkipDef` (`:91`, `:109-112`): no `defAdjust`, sent as `RPC_AddEffectDamage` (floor `hitMod`, gear `pure_cut` / `pure_stop_roll` instead of `dmg_up` / `race_up` / `vit_bane` / `dmg_cut` / `race_cut` / HP-VIT, `Reborn:CharacterControl.cs:7922-7925`, `Reborn:RebornCombat.cs:32-84` vs `:443-469`), still dodgeable, KO 1, +1 SP, Open Wound and `[cut]` as a landed hit; it does not set `mLastDamage`. After every landed hit `AfterHit` strips every `isShieldStatus` status of any level (`Reborn:RebornC6Passive.cs:173-176`, `:261-276`; list `Reborn:StatusData.cs:1620`: ironShield, diamondShield, perfectShield, perfectArmor, bubbleShield, salvation, iceShield, reverse, repel, benediction), and on a Salvation-blocked hit too (`CatMoonStripOnSalvation`, `Reborn:Cat.cs:6286`, `:6328`, `:6552`, `:6594`; `Reborn:RebornC6Passive.cs:246-259`); the stripping hit itself was already absorbed; a shield the server's wave buff locks survives (`removeStatus` refuses `RebornWaveBuff.Blocks`, `Reborn:CharacterControl.cs:9768-9773`). "+25% wide" is visual only (`CatMoonFx` scales particles, `Reborn:RebornC6.cs:1891-1899`, `:636-660`; also Delta Strike's ring, `Reborn:Cat.cs:6793`); the hit areas are unchanged in the 2026-10-25 build (bible3 widens them ×1.25, see the bible3 list below). Changes: Moon Blade / Moon Storm (`servers.reborn.dmgPostScale` = `fround(1.3)` while the toggle is on, ceil after Power, `dmgControls`, desc line). The 20% DEF-skipping purple is not simulated (Final range and Test show white hits only).
- **`cat_broadside` (454, instant, MP 70, SP 70 consumed, `setMPSP(70, -70)`, needs Support Fire 444, `Reborn:CatSkill.cs:428-435`):** `RPC_broadside` (`Reborn:Cat.cs:16847-16957`, dispatched `:13849-13855`, peers via `Cat_C6.onActionEvent`): `addTimeOut("broadside", agiAdjust(300))` at the press (`:16852`), no target read (mode instant, so the GUI needs none, `Reborn:GameGui.cs:1286-1330` gates only target-mode skills). Eight visual cannons 2.5-4.0 m behind (`:16874-16896`); after 0.8 s two volleys of 8, 0.12 s apart (cannons 0 → 7, then 7 → 0 after a 0.9 s pause; the Cat is released after the first, 1.76 s, `:16898-16945`, `Reborn:RebornC6.cs:2410-2418`). Each shell lands at `origin + dir × Random(6, 22) + right × (−8 + 16 × (c + 0.5) / 8 + Random(−1.2, 1.2))` (`Reborn:Cat.cs:16922-16929`) after `0.7 + 0.025 d` s; on the owner's client `RebornC6.Area(point, 5, 4)` hits each living enemy with `hit(454, floor(0.8 × ATK + talAdjust(60)), KO 30)` while its per-cast counter is below 5 (`BroadsideMayHit` counts before `hit()`, so a dodged shell counts; `Reborn:RebornC6.cs:2356-2408`). An ordinary `hit()`: Cat Power, `damagePlus`, `dmgAdjust`, DEF; no Open Wound, no +1 SP. Every client rolls its own landing points, but only the owner's deal damage (`Reborn:Cat_C6.cs:30-41`, `Reborn:RebornC6.cs:2394-2397`). `Cat.Start` also sets the cooldown on spawn when `RebornZone.CombatMap` (`Reborn:Cat.cs:11679-11683`; game type > 4 or the type-3 combat maps), not on the card (same as Pillage Plunge / Support Fire). Linked with Support Fire (prerequisite, shared art) and Ghost Galleon (needs 454).
- **`cat_nightEye` (461, passive; needs Treasure Hunt 123 + Insight 421, `Reborn:CatSkill.cs:387-391`):** `SkillData.rbCatNightEyeSp` sets Awareness's `cSP = -20` for a local Cat with 461 (`Reborn:SkillData.cs:108`, `:155-165`): 20 SP consumed at both ranks (BB 3 / 5). `AwarenessReach` = 36 with 461, else `12 × sLv` (`Reborn:RebornC7Passive.cs:2019-2026`), used for the status search `FindAreaTarget(pos, num, 3 × rangeMod)` (`Reborn:Cat.cs:14479`, `:14517`) and the hidden-item reveal distance (`:14557`); Treasure Hunt's minimap list stays unlimited. `NightEyeMark` draws an eye over found `invisible` / `blend` targets and pings 4616 (`Reborn:Cat.cs:14530`, `Reborn:RebornC7Passive.cs:2028-2048`). Always on: `OnTakeDamage` zeroes white damage and KO from a turret attacker (`Reborn:RebornC7Passive.cs:731-737`; `IsTurret` = Structure race or an `AutoGyroGun*` / `BarrelBot*` summon, `:2115-2134`), and projectiles of Barrel Bot cannon / missile, Frost Tower and the Reborn Mole turrets are destroyed inside a 3 m sphere around the Cat's position + 1 m (`NightEyeNear`, `:2064-2099`; callers `Reborn:BarrelBot_cannon.cs:29`, `Reborn:BarrelBot_missile.cs:30-34`, `Reborn:FrostTower_frostStrike.cs:41-45`, `Reborn:RebornTurretShot.cs:73-77`), shots aimed at an ally inside that sphere too; War Capital missiles (fired by the Mole) are not covered. Frost Tower's Frost Strike also skips a `TurretImmune` target in its hit loop (a Cat with 461, or a `huntVeil` holder): no hit and no `ice` 3 (`Reborn:FrostTower_frostStrike.cs:97-100`; `TurretImmune` `Reborn:RebornC7Passive.cs:2374-2388`). Card desc line added 2026-10-26. Changes: Awareness (`servers.reborn.cost` SP 20, `reach` r 36 at both ranks, `infoDeps` / `reachControls` toggle, desc line) and Treasure Hunt (Reborn `descDep` swaps its `12/24m` to `36m`).
- **`cat_ninthLife` (462, passive; needs Nine Lives 2, `Reborn:CatSkill.cs:392-396`):** in the death chain after blackServant, autoLife and the Small Anubi pet, before Nine Lives (`Reborn:Cat.cs:11717-11766`): with 462, no `death` status and `CatNinthReady` (a flat 300 s stamp per actor, no `addTimeOut`, so no AGI, no Revised Art, no HUD timer; cleared on `Cat.Start`, on a real death and on a scene change, `Reborn:RebornC7Passive.cs:2191-2232`, `Reborn:Cat.cs:11678`, `:11761`) the Cat is set to HP 1, `NinthShieldOn` 0.5 s and `CatNinthFx` starts (`Reborn:Cat.cs:11744-11750`). The shield blocks white and Effect Damage, KO and force (`Reborn:CharacterControl.cs:435-440`, `:6802-6807`, `:7321`, `:7893`) and debuffs from others (`Reborn:RebornC7Passive.cs:791-794`); debuffs are cleansed at survival and at 0.5 s (`:2261-2280`, `:2305`, `:2317`); `invisible` 3 for `ceil(3.5)` = 4 s at survival, `moveMod` +0.5 for 3.5 s, then `RPC_AddHeal(462, ceil(0.4 × maxHP))` if alive (`:2306-2338`). The Thai tooltip's "invisible 3 s after the 0.5 s" is 4 s from the survival in the code. Changes: Nine Lives (Reborn `descDep` line: it only rolls while Ninth Life is on its 300 s).
- **`cat_shadowUponShadow` (463, instant, MP 30, SP 30 consumed, needs Vendetta 364, `Reborn:CatSkill.cs:397-404`):** every `-82` evade on the Cat (Evasion, Backflip's dodge, `drunken`; `Reborn:CharacterControl.cs:137-141`, `:7126-7204`) runs `RebornC7Act.CatEvaded`: a shade at the Cat's position for 6 s, at most 3 (the oldest goes) (`Reborn:RebornC7Act.cs:1987-2031`). Echo: each landed hit with code < 10 makes every living shade deal `RPC_AddEffectDamage(463, max(1, floor(0.3 × dmg)))`, `dmg` = the hit after `dmgAdjust` and DEF, before the target's `hitMod` (`Reborn:RebornC7Passive.cs:645-662`); Hidden Blade (331-334) gets none. Cast: the nearest shade (no distance limit, `:2034-2054`), none → refused with MP / SP refunded (`:474-481`, `Reborn:Cat.cs:13837-13842`); `Begin` sets `agiAdjust(45)` (`Reborn:RebornC7Act.cs:2115`, `:808-816`), warp after 0.12 s, then 0.3 s later `hit(463, floor(1.0 × ATK) + talAdjust(60), KO 30)` to every enemy in `Area(r 5, h 4)` around the shade spot and the old spot, each once (`:2080-2151`). The patch note of 2026-09-27 (Reborn-Mechanics-Reference.md §7.2) on the clone blast at both positions matches this build. Changes: Combo (Reborn `descDep` line for the echo; the echo is not added to Combo's numbers), Evasion (Reborn `descDep` line), Backflip (an always-shown Reborn line, its `descDep` is Finishing Blow).
- **`cat_ghostGalleon` (464, instant, MP 100, SP 90 consumed, needs Broadside 454, `Reborn:CatSkill.cs:405-412`):** `RebornC7Act.CatGalleon` (`Reborn:RebornC7Act.cs:2463-2529`): a 1.3 s rise with the Cat locked, then `moveMod −0.45` while riding (`:2525`, restored `:2640-2644`); the ship is a collider-less mannequin. Ride up to 15 s (`:2578-2580`): from 0.3 s, every 1 s, `Area(Cat, r 30, h 8)` and the first 8 living targets each get a shell after `Random(0, 0.8)` s that hits that target with `hit(464, floor(0.7 × ATK) + talAdjust(60), KO 25)` (radius 0: no distance check at landing, `:2605-2634`, `:2401-2435`, `:2451-2461`). A second press ends the ride and refunds the cost (`:514-518`, `Reborn:Cat.cs:13843-13848`). At the end, alive: a salute of 3 waves × 8 ports (`:248-258`), 0.35 s apart, landing `Random(6, 24)` m out to each side and `Random(−6, 6)` m along (`:2649-2678`), each `Area(r 5, h 4)` with the same hit, at most 5 per target over the salute (`:2436-2448`). Cooldown `agiAdjust(600)` when the ride ends (`:2647`); `RebornC7Act.Seed` gives `agiAdjust(360)` on spawn in a combat map (`:615-633`, `Reborn:Cat.cs:11684`; not on the card). The card shows the per-target maximum, 15 + 5 hits.

### Build 2026.10.27.1936-bible3 behaviour fixes (verified 2026-10-27)

`Reborn1027:` = `DecompiledSource_Reborn_2026-10-27/Assembly-CSharp/` (build `2026.10.27.1936-bible3`, [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §1.1); each item names the 2026-10-25 line it replaces. The Reborn team's patch note claims were checked against this build (archive `reborn-diff-2026-10-25_to_2026-10-27/fixes/g2.json`); "not in the team's list" = a change found in the diff only. Cards: `servers.reborn` of the cards named; a BB / ToT / TTO note stays.

- **Combo: Open Wound on the stage-2 backstab (Fix):** the stage-2 Hidden Blade hit `hit(332, …)` (`Reborn1027:Cat.cs:391`) now calls `OpenWound` on a landed hit (`:405`), like the other five backstab passes (`:176`, `:621`, `:693`, `:917`, `:988`) and every ordinary Combo hit (`:196`, `:424`, `:641`, `:713`, `:936`, `:1007`); the 2026-10-25 build had no call there (`Reborn:Cat.cs:389`), the same gap as BB (`Cat.cs:17390-17507`). `OpenWound` itself is unchanged: `30 × (target disarm lv + bleed lv)` as Effect Damage 443 (`Reborn1027:Cat.cs:15240-15255`). App: Combo's Reborn `effectProc` is `CAT_OPENWOUND_PROC` with no `hits` list; `unintended` cleared on Combo and Open Wound (new Reborn tab).
- **Finishing Blow: Open Wound on all four hits (Fix):** `if (hit(423, …) != 0) OpenWound(…)` on hits 1-4 (`Reborn1027:Cat.cs:7347-7349`, `:7385-7387`, `:7423-7425`, `:7462-7464`); 2026-10-25: bare `hit(423, …)` on hits 1, 2 and 4 (`Reborn:Cat.cs:7314`, `:7349`, `:7423`), the call only on hit 3 (`:7384-7386`). App: Reborn `effectProc: CAT_OPENWOUND_PROC` (every hit), `unintended` cleared.
- **Hidden Blade backstab: gear crit and No Chance (Fix):** all six replacement hits pass `getCritPlus(_1680 + _2000)` (`Reborn1027:Cat.cs:162`, `:391`, `:607`, `:679`, `:907`, `:978`; 2026-10-25: `_1680 + _2000` with no roll, `Reborn:Cat.cs:161`, `:389`, `:603`, `:675`, `:903`, `:973`), so the crit `FloorToInt(1.8f × nDmg)` (`Reborn1027:Cat.cs:16871-16905`) multiplies the base and the Hidden Blade bonus together, after Huge Shuriken's 0.75 on the base alone (`:140-143`). No Chance: `hit()` takes the fixed branch `CeilToInt(clamp(damageMod, 0, 5) × dmg + 0.3 × LCK)` for a Cat with 401 when `code < 10` or `331 ≤ code ≤ 334` (`Reborn1027:CharacterControl.cs:7315`); 2026-10-25: any `code >= 10` went to `dmgAdjust` (`Reborn:CharacterControl.cs:7265`). This build's `getCritPlus` also adds `RebornArti.CritPlus` (+10 while the `p_drunk` potion state is on, `Reborn1027:RebornArti.cs:841-852`; new for every class, not modelled). App: card flag `hiddenBladeFixed` on Combo's Reborn tab (`rollOneHit`, the range and the crit-view formula `⌊1.8 × (base + bonus)⌋`, No Chance on the backstab); Hidden Blade (`bbBug` cleared, lines for No Chance and the gear crit) and No Chance (limit replaced) get Reborn tabs.
- **Predator Focus rolls on the backstab (C6 change):** `(code < 10 || 331 ≤ code ≤ 334) && hasSkill(451) && Random(0,100) < lckAdjust(20)` (`Reborn1027:RebornC6Passive.cs:220`; 2026-10-25 `code < 10`, `Reborn:RebornC6Passive.cs:169`). App: Predator Focus desc (limit removed), Combo's Reborn Predator Focus line.
- **Shadow Upon Shadow skips the backstab (unchanged; app corrected):** the echo still returns for `code >= 10` (`Reborn1027:RebornC7Passive.cs:682`), so Combo's Reborn `hitPurple.hits` is empty while the Hidden Blade toggle is on (it listed hits 1 and 3-6, copied from Open Wound's stage-2 gap).
- **Lucky Card: Joker bonus floored at 0 (Fix):** `_1680_u2 = (int)(_1680_u2 + Mathf.Max(0f, 0.5f × (LCK − target LCK)))` (`Reborn1027:Cat.cs:1508`; unclamped in 2026-10-25, `Reborn:Cat.cs:1498`, and BB, `Cat.cs:20856`). App: card flag `lckDiffDepFloor` on Lucky Card's Reborn tab (`lckDiffDepTerm` in the roll, the range and the formula); `unintended` cleared on Lucky Card and Joker; Lucky Card's `tooltipNote` cleared there too (the bible3 tooltip states the 0.5 × ATK base and the LCK difference).
- **Joker: Doom contested the normal way (Fix, not in the team's list):** `Damage.getDebuff(30f, cat CHA, target CHA)` (`Reborn1027:Cat.cs:1514`; 2026-10-25 `getDebuff(30f, target CHA, cat CHA)`, `Reborn:Cat.cs:1504`, the reversed order BB also has, `Cat.cs:20888`), so a CHA lead now lengthens Doom (`Reborn1027:Damage.cs:163-170`). App: Joker's Reborn `durContestedInverted: false` (the duration chip reads this flag from the server-merged card).
- **Evasion: the disabling statuses are read on the Cat (Fix, not in the team's list):** `characterControl.hasSkill(361) && characterControl.getStatus("sleep" / "snowMan" / "snowBall" / "petrify" / "paralysis") == null` (`Reborn1027:CharacterControl.cs:7227`; `characterControl` is the hit target, `:7134`); 2026-10-25 and BB read them on `this`, the attacker (`Reborn:CharacterControl.cs:7178`, `CharacterControl.cs:3252-3276`). App: Evasion Reborn change note; its desc already states the rule as Reborn now runs it.
- **Lunar Tempest widens the hit areas (C6 change):** with skill 453, Moon Blade `FindAreaTarget(pos, 3 × rangeMod × 1.25, 3)` and `4 × rangeMod × 1.25` (`Reborn1027:Cat.cs:6287`, `:6329`), Moon Storm `2 × 1.25` and `3 × 1.25` (height 2, `:6554`, `:6596`); the 2026-10-25 radii had no factor (`Reborn:Cat.cs:6258`, `:6300`, `:6524`, `:6566`). App: `catLunarReach` (Moon Blade / Moon Storm Reborn `reach`, the Lunar Tempest toggle in `reachControls`), their Reborn desc lines and a Lunar Tempest bullet.
- **Iron + Diamond shields on a Cat with Open Wound (Fix, not in the team's list):** `RPC_AddStatus` merges iron + diamond into `perfectArmor` only for `hasSkill(443) && Type == "Bison"`, else `perfectShield` (`Reborn1027:CharacterControl.cs:9444`, `:9448`); before, any holder of skill 443, so also a Cat with Open Wound, got `perfectArmor` (`Reborn:CharacterControl.cs:9376`, `:9380`; BB `CharacterControl.cs:11985`, `:12019`). No Cat card mentions it (BB neither).
  - **Decided 2026-10-28 (from the code):** this fix changes nothing for a Cat: the type gate after the merge drops all four shield statuses on a non-Bison in both builds (`Reborn1027:CharacterControl.cs:9458`; BB `CharacterControl.cs:12184-12258`), so a Cat never held the pair (Open items, item 3).

### Dependency-line audit (verified 2026-10-28)

`Reborn1027:` = bible3, as above. Each item: what Reborn does and what the card now names.

- **Backflip + Vendetta:** the Backflip state evade calls `RPC_AddHeal(364, 0, 0, 10, …)` with Vendetta, as in BB (`Reborn1027:CharacterControl.cs:7217-7220`). The Reborn Backflip desc is built from the base, so the **Vendetta:** line shows before **Shadow Upon Shadow:**.
- **Heart Ripper / Finishing Blow:** one cooldown key, 60 and 120 (`Reborn1027:Cat.cs:5276`, `:7103`), so the base **Finishing Blow:** line holds on Reborn.
- **Backstab:** the same per-skill tests, Forward Lunge `!(angle >= 45f)` (`Reborn1027:Cat.cs:4583`, `:4652`), Reverse Thrust `!(angle <= 135f)` (`:4878`, `:4938`).
- **Joker:** the same `!hasStatus("doom")` check before the roll (`Reborn1027:Cat.cs:1512`), so the base wording (a target without [doom]) holds on Reborn.
- **Open Wound:** the +3 sits inside the `getDebuff` base for disarm and bleed (`Reborn1027:Cat.cs:5816`, `:6091`), CHA-contested as in BB.
- **Predator Focus on Hidden Blade:** the roll takes `331 <= code <= 334` too (`Reborn1027:RebornC6Passive.cs:220`; Hidden Blade's hits `Reborn1027:Cat.cs:162`, `:391`, `:607`, `:679`, `:907`, `:978`) and gives `[damagePlus5]` × 6 for `chaAdjust(12)` (`Reborn1027:RebornC6.cs:1802-1818`), from the next hit. Card: the Hidden Blade Reborn desc has a **Predator Focus:** line, and Hidden Blade's `servers.reborn.compatSkills` and Predator Focus's list link each other.
- **Power Number:** Lucky Dice goes through `hit()` like Lucky Card, Double Down and Grand Casino Arcade, so the base links to Power Seven and Super Seven hold on Reborn.
- **Two Pair:** the copy loops add `RebornWaveBuff.IsLocked` and `CatPairCap` (`Reborn1027:Cat.cs:3184`, `:3204`); still no System-status filter.
- **Lunar Tempest on Delta Strike:** only the VFX is resized (`RebornC6.CatMoonFx`, `Reborn1027:Cat.cs:6824`); the hit box `FindRecTarget` (`:6831`) is unchanged, so Delta Strike gets no line.

**Open (needs a decode):** Jackpot Pair raises the copy cap to 7, so Two Pair on a target holding `[pillage5]` (from the Cat's Pillage Plunge) would copy it back onto the Cat: her shields purged, her armor unequipped if she has a free inventory slot, and shields blocked. The pillage handler has no own-caster check (`Reborn1027:RebornC6.cs:1777-1784`, `Reborn1027:CharacterControl.cs:2551-2577`), and its status string helper `_2035_2015` is not among the 13 exclusion helpers (`Reborn1027:Cat.cs:3184`, `:3204`). It needs the strblob decode to confirm `_2035_2015` = `"pillage"`, and the copy can still be refused by `RPC_AddStatus`'s debuff-resist roll. If confirmed, Two Pair's Reborn tab with Jackpot Pair on needs a limit line (modifier Pillage Plunge).

**Decided 2026-10-28 (decoded):** `_2035_2015` is `"pillage"`. The helper returns `_6(2461, 56892, 7)` (`Reborn1027:_6A503372_002DE9D7_002D4DF1_002D9C3B_002D31CE6FD018B6.cs:12328-12331`, the string-helper class of [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §1), and bytes 56892-56898 of `StreamingAssets/strblob.bytes` (SHA-256 prefix `ddf5fdae59fcd386`, the same file in both builds) undone with `b[i] ^ i ^ 0xAA` (`:200338-200350`) read `pillage`. The 13 exclusion helpers (`Reborn1027:Cat.cs:3184`, `:3204`) decode to exactly the card's 13 names (`noDamage`, `noForce`, `overPresence`, `overLord`, `lastHope`, `swallow`, `gobble`, `charm`, `mindControl`, `nightmare`, `mimic`, `allMimic`, `transform`), so `pillage` passes. Two Pair is rank 2, so the cap is 4 without Jackpot Pair and 7 with it (`Reborn1027:RebornC6.cs:1777-1784`): only with Jackpot Pair does a target's `[pillage5]` come back onto the Cat (`Reborn1027:Cat.cs:3206-3208`, with its remaining time, level 5 and the original applier's `sID`). On the Cat it purges her eight shields and, on her own client with a free inventory slot, unequips her armor (`Reborn1027:CharacterControl.cs:2551-2577`), and blocks shields up to level 5 while it lasts (`:9503`). It can still be refused like any physical debuff: `immunity` 5+ (`:9462`), `clear` / `cleanse` 5+ (`:9492`, `:9497`), `RebornArti.ResistStatus` (`:9619`) and the gear resist roll (`num3`, `:9601-9625`). BB, ToT and TTO cap Two Pair at 4 (`Cat.cs:25716-26032`), so the copy-back is Reborn-only. Card: the Reborn Two Pair tab with Jackpot Pair on has a second limit line under ข้อจำกัด (`__ใช้กับเป้าหมายที่ติด [pillage5] จาก **Pillage Plunge** ตัวเองจะติด [pillage5] ไปด้วย (โล่ของตัวเองถูกลบ และถูกถอดชุดเกราะ) เว้นแต่จะต้านทานได้__`), and Two Pair and Pillage Plunge link each other on Reborn (`servers.reborn.compatSkills`).

## Hit timing for the reach playback (traced 2026-10-16)

Seconds from the start of the move (or of the child routine named), read from the coroutine waits in order; every hit uses the box / circle already documented above. The Bible reach preview replays exactly these times.

- **Reverse Thrust:** `moveSpeed −10` for 0.2 s from 0.1 s, then hits at 0.3 s (`Cat.cs:31353`) and 0.7 s (`:31590`), both 2 m behind the cast point.
- **Heart Ripper:** `moveSpeed 2` for 0.2 s, hits at 0.2 s (`:33355`) and 0.6 s (`:33467`) at the same spot.
- **Moon Storm:** 6 storms 0.1 s apart (`:36415`, `i < 6`), then the 12 m blast twice, 0.1 s apart (`:36521`, `j < 2`).
- **Delta Strike:** the 0.3 / 0.8 / 1.3 s area checks deal no damage; 6 hits every 0.1 s from 2.1 s (`:37902`, `i < 6`) and the finisher at 2.9 s (`:37597`).
- **Finishing Blow:** 0.3 / 0.6 / 1.1 / 1.4 s at the caster (`:38694`, `:38794`, `:38894`, `:39008`).

### Riding mounts: mountAttack and mountDash (G. Marshal / G. Champion mount, verified 2026-10-17)
Both mounts run the same attack code for this class (`PvpMount.cs` and `ChampionMount.cs` differ only in the +20 / +50 stat bonus, the ride speed 8 / 9 and the Champion's charge; the shared rules are in [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md#riding-mounts-g-marshal-and-g-champion-verified-2026-10-17)). ATK, TAL and LCK are the mount's own (rider's base stats + bonus). Line numbers are `PvpMount.cs`; `ChampionMount.cs` has the same code a few hundred lines later.
- **mountAttack** (normal attack while moving at no more than 40% of the run speed): `FindAreaTarget(pos, 7, 3)`, `hit(1, (int)(0.75 × ATK), KO 1)`, cooldown 1.5 s (`:9102-9125, :9229`).
- **mountDash** (normal attack while moving faster): `Physics.Raycast` 40 m to the first collider (`:9642`; the `cat_rAttack` prefab is visual only, no collider), `hit(25, (int)(1.5 × ATK), KO 3)`, cooldown 1.5 s (`:9610, :9680, :9786`).
