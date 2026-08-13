# Rabbit — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| statScan | Stat Scan | 1 | 30 | true | false | — | — |
| bounce | Bounce | 2 | 30 | true | false | — | — |
| maimShot | Maim Shot | 4 | 15 | true | false | — | — |
| mix | Mix | 4 | 30 | true | false | — | — |
| shake | Shake | 3 | 30 | true | false | — | — |
| miracleBlend | Miracle Blend | 1 | 60 | true | false | — | — |
| stickyGum | Sticky Gum | 2 | 60 | true | false | — | — |
| acidicField | Acidic Field | 2 | 60 | true | false | — | — |
| immuneShot | Immune Shot | 1 | 30 | true | false | 20 | true |
| boostShot | Boost Shot | 1 | 30 | true | false | 35 | true |
| heatShot | Heat Shot | 1 | 30 | true | false | 35 | true |
| lifeShot | Life Shot | 1 | 30 | true | false | 65 | true |
| rapidTrance | Rapid Trance | 1 | 120 | true | false | 12 | true |
| gorgonShot | Gorgon Shot | 2 | 180 | true | false | — | — |
| gilShot | Gil Shot | 4 | 30 | true | false | — | — |
| backpack | Backpack | 2 | 60 | true | false | — | — |
| fourShot | Four Shot | 2 | 60 | true | false | — | — |
| circleShot | Circle Shot | 2 | 90 | true | false | — | — |
| mall | Mall | 2 | 90 | true | false | — | — |
| truceTrading | Truce Trading & Co. | 2 | 240 | true | false | — | — |
| shootingArray | Shooting Array | 2 | 120 | true | false | — | — |
| millionaire | Millionaire | 2 | 300 | true | false | — | — |
| healingField | Healing Field | 1 | 120 | true | false | — | — |
| diamondShot | Diamond Shot | 1 | 300 | true | false | — | — |
| tenShot | Ten Shot | 1 | 120 | true | false | — | — |
| extravagance | Extravagance | 1 | 120 | true | false | 6 | true |
| contract | Contract | 1 | 180 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Rabbit's own thematic `replenishment`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Rabbit.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Rabbit.cs:12097`), `psalmOfEnergy`
  (`Rabbit.cs:12337`), `seaAegis` (`Rabbit.cs:12506`), `zephyrLore` (`Rabbit.cs:12700`), `replenishment`
  (`Rabbit.cs:12801`), `elementalBound` (`Rabbit.cs:12931`), `astralShift` (`Rabbit.cs:13083`),
  `bloodCarnage` (`Rabbit.cs:13274`), `obsidianFang` (`Rabbit.cs:41037`), `assassinate`
  (`Rabbit.cs:41492`), `mineWalker` (`Rabbit.cs:41871`), `divineChannel` (`Rabbit.cs:42245`) — all 12
  present, all bare-`600`. A direct grep of `RabbitSkill.cs` for `replenishment` (Rabbit's own
  thematically-named support skill) returns zero matches, confirming it isn't part of Rabbit's own
  learnable-skill roster (`getSkill()`). All 12 excluded.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.**
  `rab_nAttack1`/`rab_nAttack2` both `goto IL_358B` (`RabbitSkill.cs:44`, `:50`) and `rab_nAttack4` goes
  `goto IL_2D19` (`:67`), and `rab_nAttack3`'s own branch (`:54-60`) is empty (falls through the same
  cascade) — all four converge on the shared terminal `mode = eSkillMode.passive; cType = "nAttack"`
  (`RabbitSkill.cs:2257-2267`). `rab_cAttack1`/`rab_cAttack2` similarly converge on
  `cType = "cAttack"` (`:2231`, also `mode = passive`). Live cast sites include `Rabbit.cs:8903`
  (`addTimeOut("nAttack", 1f)`) and combo-stage variants (e.g. `:17815`, `:17823`, `:22247`, `:36483`).
  Excluded regardless of the passive/active metadata quirk, per the blanket rule.
- **`mount` is not a Rabbit class skill — excluded, not a judgment call.** `Rabbit.cs:46537` —
  `this.$self_$27590.mChar.addTimeOut("mount", (float)12);` — the universal ride-a-mount action shared
  by every class. `RabbitSkill.cs` has no `cType`/`getSkill()` entry for `"mount"` at all.
- **`hyperShot1`-`4` and `statPlus1`-`4` are confirmed passives** (ranged normal/charge-attack damage
  bonus past 16m / flat +2-all-stats, `RabbitSkill_eng.cs:147` etc., `:191` etc.), landing on shared
  passive tails with no `cType`: `hyperShot` → `IL_2107`/`IL_290C` → `IL_5EC`
  (`RabbitSkill.cs:2157-2172`: `setReq(32,10); mode=passive; target=all; break`); `statPlus` →
  `IL_277A`/`IL_2C47` (`:2133-2155`: `setReq(40,10); mode=passive; target=self; break`). No
  `addTimeOut`/`RPC_<name>` cast site exists for either in `Rabbit.cs`.
- **`alchemistLab1`-`4` are confirmed passives (town-vendor unlock + MiracleBlend duration extension),
  but rank 4 is a genuine `getSkill()` dead-code-fallthrough trap landing on `stickyGum`'s cType —
  matching the Mole `heavyBuilt`/`speedDrill`/`skyDrill` precedent.** Ranks 1-3 explicitly
  `goto IL_2159`/`IL_166F` (`RabbitSkill.cs:398`, `:406`, `:414`) → a shared passive tail
  (`IL_8FE`, `:1962-1973`: `setReq(27,9); mode=passive; break`), matching the eng description
  ("Enables Rabbit to use Alchemist Lab lv.X in towns. Also increases miracleBlend's duration to
  6/8/10/12 seconds", `RabbitSkill_eng.cs:367` etc.). `alchemistLab4`'s own branch (`:416-422`) is empty
  with no live goto — falling through skips past the alchemistLab-family's own passive tail (nested
  inside a sibling scope) and lands one level further out, on `stickyGum`'s real active-skill tail
  (`RabbitSkill.cs:1935-1960`: `mode=instant; target=self; cType="stickyGum"`) — despite `alchemistLab4`
  being just as clearly a passive town-unlock as ranks 1-3. No extra row needed since `stickyGum` is
  already reported from its own clean ranks 1-2.
- **`bunnyBargain1`-`4` are confirmed passives (NPC shop discount/bonus), and `herbFinder1`-`2`
  legitimately share the same passive tail via natural empty-fallthrough — not a trap.**
  `bunnyBargain1`/`2` explicitly `goto IL_A1A`(`RabbitSkill.cs:751`)/direct(`:757`) → `IL_435`
  (`:1785-1791`) → `IL_140A` (`:1799-1810`: `setReq(23,7); mode=passive; break`, no `cType`), matching
  "Passively gives Rabbit a 5% discount and a 5% bonus when buying and selling items from NPC"
  (`RabbitSkill_eng.cs:609` etc.). `bunnyBargain3` (empty) and `herbFinder1`/`herbFinder2` (empty, own
  branches at `RabbitSkill.cs:778-796`) all fall through the same way, landing on this identical
  passive/no-cType tail — matching herbFinder's own passive description ("Gives Rabbit the ability to
  gather herbs in the field with 30%/50% success rate", `RabbitSkill_eng.cs:653`, `:664`). This is the
  legitimate shared-tail-passive pattern (like Panda's `resistance`/`statPlus`), not a trap onto an
  active skill, since the landing spot itself carries no `cType`.
- **`medicalEnhancement1`-`3` are confirmed passives** (upgrade ImmuneShot/BoostShot/HeatShot/LifeShot's
  effective level and extend their duration, `RabbitSkill_eng.cs:499` etc.), landing on a shared passive
  tail with no `cType` (`IL_2873`, `RabbitSkill.cs:1895-1906`: `setReq(30,21); mode=passive; break`) via
  both empty-fallthrough (ranks 1-2) and explicit `goto IL_2873` (rank 3, `:634`). The mechanism is
  `Rabbit.cs:10381-10420`'s `getMedicalEnhancementLv()` (returns 0/1/2/3 based on which
  `medicalEnhancement` rank is learned), which feeds directly into the ImmuneShot/BoostShot/HeatShot/
  LifeShot duration formulas below — see the Duration citations note.
- **`customizedShotgun1`/`2` are confirmed passives, but their `getSkill()` entries are a dead-code-
  fallthrough trap landing on `millionaire`'s real active-skill tail — the clearest instance of the
  Mole/Panda-precedent bug in this file.** Both ranks (`RabbitSkill.cs:803-813`, note the file also has
  a duplicated/mis-suffixed `rab_customizedShotgun1` literal appearing twice for what are clearly ranks
  1 and 2) are empty with no live goto, matching the eng description ("Passively changes Rabbit's normal
  attack to a 2m/4m cone attack when she's holding a shotgun", `RabbitSkill_eng.cs:807`, `:818`).
  Falling through skips the entire nested `specialDeal`/`millionaire`/rank-5 cascade and lands on
  `RabbitSkill.cs:1556-1581` (`setReq(40,25); mode=instant; target=enemy; cType="millionaire"`). No
  extra row needed since `millionaire` is already reported from its own clean ranks 1-2.
- **`specialDeal1`-`4` are confirmed passives (party money/exp bonus), and the family splits across two
  different broken `getSkill()` landing spots depending on rank — neither is a real skill, so neither
  gets a row.** All four ranks read as clearly passive ("Passively increases money and exp received
  from missions to all party members by 5/10/15/20%", `RabbitSkill_eng.cs:829` etc.). `specialDeal1`/`2`
  (empty, `RabbitSkill.cs:966-984`) fall through the same cascade as `customizedShotgun` above, landing
  on `millionaire`'s active tail. `specialDeal3` (`goto IL_33C2`, `:991`) and `specialDeal4`
  (`goto IL_3021`, `:997`) instead reach a *different*, correctly-passive tail
  (`RabbitSkill.cs:1589-1600`: `setReq(33,24); mode=passive; break`, no `cType`) — internally
  inconsistent `getSkill()` metadata across one family, but no gameplay impact either way since
  `specialDeal` is passive per its own description regardless of which broken tail a given rank lands
  on. No extra row.
- **`gilShot4`'s `getSkill()` entry is a dead-code-fallthrough trap landing on `bunnyBargain`'s passive
  tail (no `cType`), but the skill itself is real — `Gil Shot` is reported at Max Rank 4 using its own
  cast site.** `gilShot1`/`2` reach the family's own active tail via `goto IL_1A85`
  (`RabbitSkill.cs:711`, `:719`) and `gilShot3` via `goto IL_2EF6` (`:729`), both converging on
  `IL_709` (`:1812-1838`: `mode=target; target=enemy; cType="gilShot"`). `gilShot4`'s own branch
  (`:731-737`) is empty with no live goto, falling through into `bunnyBargain`'s nested cascade and
  landing on its no-`cType` passive tail instead. The eng description confirms all 4 ranks are real,
  escalating attacks ("Perform a money shot that uses 1/2/3/4 gil and deals 10/20/30/40 extra damage and
  2/3/4/5 ko to a target", `RabbitSkill_eng.cs:565` etc.), and `Rabbit.cs` has a single shared cast site
  (`addTimeOut("gilShot", agiAdjust(30f))`, `:30530`) used for the ability regardless of rank — so the
  table reports Max Rank 4 with that real, rank-independent CD value rather than inventing a "Max Rank
  3" from the broken `getSkill()` metadata.
- **`maimShot4`'s `getSkill()` entry is likewise a dead-code-fallthrough trap, landing on `statPlus`'s
  passive tail (no `cType`), but `Maim Shot` is reported at Max Rank 4 for the same reason as GilShot.**
  `maimShot1`/`2` reach the family's own active tail via `goto IL_1C5A`(`RabbitSkill.cs:249`)/
  direct(`:259`) → `IL_101D`(`:267`) → `IL_7AC` (`:2076-2102`: `mode=target; target=enemy;
  cType="maimShot"`). `maimShot4`'s own branch (`:269-275`) is empty, falling through the entire
  `mix`/`shake`/`miracleBlend`/`alchemistLab`/`stickyGum`/`acidicField`/.../`millionaire` mega-cascade
  nested inside it and landing on `statPlus`'s no-`cType` passive tail (`RabbitSkill.cs:2139-2155`)
  instead. The eng description confirms 4 real escalating ranks ("Perform a quick shot at target's leg,
  dealing extra 5/10/15/20 damage and reducing its movement speed to 3.5/3.0/2.5/2.0 ts",
  `RabbitSkill_eng.cs:235` etc.), and `Rabbit.cs` has a single shared, rank-independent cast site
  (`addTimeOut("maimShot", agiAdjust(15f))`, `:23477`) — table reports Max Rank 4 with that value.
- **`immuneShot`/`boostShot`/`heatShot`/`lifeShot` are one escalating skill-tree family where each rank
  changes the `cType` name itself, rather than four independent skills — each still gets its own row
  since each is a genuinely distinct `cType`/tree unlock, matching how differently-`cType`'d family
  members were tabled individually in the Panda doc.** Each name has exactly one `getSkill()` instance
  (`rab_immuneShot1`, `rab_boostShot2`, `rab_heatShot3`, `rab_lifeShot4` — no sibling ranks), each with
  its own clean `setReq`/`mode=target`/`target=ally`/`cType` block (`RabbitSkill.cs:475-506`,
  `:508-539`, `:541-572`, `:574-605`). `Rabbit.cs:28561-28611` confirms all four are dispatched from one
  shared coroutine keyed on `sLv` (1/2/3/4), sharing one `PlayAnimation("medicalShot", ...)` call and an
  **identical CD of `agiAdjust(30f)`** each (`:28570`, `:28582`, `:28594`, `:28606`) — a legitimate
  shared-dispatcher pattern (like Monkey's `RPC_cast`), not a trap.
- **CHA-contested Duration exclusions, per the plan's contested-duration rule.** `maimShot`'s own
  `"maim"` status: `Rabbit.cs:23337` — `this.$mDuration$26983 = Damage.getDebuff((float)3,
  this.$self_$26988.mChar.cha, this.$tChar$26982.cha);`, applied at `Rabbit.cs:23348`. `gorgonShot`'s
  `"petrify"` status: `Rabbit.cs:29699` — `this.$mDuration$27141 = Damage.getDebuff((float)
  (this.$sLv$27148 * 3 + 3), this.$self_$27149.mChar.cha, this.$tChar$27140.cha);`, applied at
  `Rabbit.cs:29710`. Both skills report Duration `—`.
- **ImmuneShot/BoostShot/HeatShot/LifeShot durations are gated by the `medicalEnhancement` passive —
  base value reported assumes `medicalEnhancement` is unlearned (`getMedicalEnhancementLv() == 0`), per
  the "report the un-upgraded base value, cite the upgrade" rule.** `Rabbit.cs:28224` —
  `this.$mLv$27104 = 1 + this.$self_$27115.getMedicalEnhancementLv();` — `getMedicalEnhancementLv()`
  (`Rabbit.cs:10381-10421`) returns 0 with no `medicalEnhancement` rank learned, 1/2/3 with
  `medicalEnhancement1`/`2`/`3`. The floor value of `$mLv$27104` is therefore always `1` even unlearned
  (not `0`) — this is baked into the base formula, not itself part of the passive's contribution.
  Base durations reported (`$mLv$27104 = 1`): `immuneShot` = `chaAdjust(15 + 1*5)` = `chaAdjust(20)`
  (`Rabbit.cs:28287`); `boostShot`/`heatShot` = `chaAdjust(30 + 1*5)` = `chaAdjust(35)`
  (`:28341`, `:28400`); `lifeShot` (status name `"autoLife"`) = `chaAdjust(60 + 1*5)` = `chaAdjust(65)`
  (`:28459`). Each `medicalEnhancement` rank adds a further `+5` inside the `chaAdjust(...)` call by
  incrementing `$mLv$27104`.
- **`bounce`'s cooldown is conditionally re-armed to a longer value by a separate air-attack interaction
  — base value reported is from Bounce's own dedicated cast site, per the "cooldown conditionally
  modified by a separate mechanic" rule.** `Rabbit.cs:21229` —
  `this.$self_$26924.mChar.addTimeOut("bounce", this.$self_$26924.mChar.agiAdjust((float)30));` — is
  Bounce's own cast site (both ranks share it; `bounce1`/`bounce2` both fall through empty to the same
  clean active tail at `RabbitSkill.cs:2188-2213`). Separately, `Rabbit.cs:22250` —
  `this.$self_$26953.mChar.addTimeOut("bounce", this.$self_$26953.mChar.agiAdjust((float)36));` — sits
  inside the normal-attack (`nAttack`) handler's air-attack branch, gated by `hasSkill(421)` (the
  `fromTheAbove5` passive, "Enables Rabbit to attack while she bounced into the air...",
  `RabbitSkill_eng.cs:917`) — landing an air-attack under that passive re-arms Bounce's cooldown to `36`
  instead of `30` as a side effect, not Bounce's own base cast value. Table reports the unmodified `30`.
- **`contract`'s single addTimeOut value is confirmed by a matching preemptive call.** `Rabbit.cs:105`
  — `this.mChar.addTimeOut("contract", this.mChar.agiAdjust(180f));` — sits inside `Start()`, gated by
  `hasSkill(444)`, a state pre-arm on login (matching the Panda `fuujinKen`/`raijinKen` preemptive-
  `addTimeOut` precedent) — matches the real cast site exactly (`Rabbit.cs:40652`,
  `agiAdjust((float)180)`). Not a discrepancy.
- **No `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists for**: `statScan`, `bounce`, `mix`,
  `shake`, `miracleBlend`, `stickyGum`, `acidicField`, `gilShot`, `backpack`, `fourShot`, `circleShot`,
  `mall`, `truceTrading`, `shootingArray`, `millionaire`, `healingField`, `diamondShot`, `tenShot`,
  `contract` — confirmed by a full-file grep of every `RPC_AddStatus(` call in `Rabbit.cs` and
  cross-checking each hit against these skills' own coroutine bodies. `mix`/`shake`/`miracleBlend` throw
  consumable potions (picked up separately, off the skill's own cast-site duration path) and
  `stickyGum`/`acidicField`/`healingField` place a timed field object, but none of their own dedicated
  coroutines (`RPC_cast1`, `RPC_<name>_cast`) contain a citable `RPC_AddStatus`/field-lifetime constant —
  the remaining `RPC_AddStatus` hits in the file belong either to the 12 support skills, to the
  passive/excluded skills documented above, or to an unrelated shared minigame/consumable-item/flag-
  capture effect system (`wash`, `bless`, `ice`, `bubbleShield`, `iceShield`, `awareness`, `float`,
  `mpsap`, `burn`, `blind`, `plague`, `frost`, `awake`, `yellowFlag`, `cleanse`, `blueFlag`, `whiteFlag`,
  `redFlag`, `happy`, `charm`, `clear`, `poison`, `heavy`, `mpDrain`, `hpDrain`) — none tied to any
  `RabbitSkill.cs` roster entry, matching the same generic-effects block documented in the Monkey/Panda
  docs. Duration cells for all nineteen skills listed above are `—`.

### CD citations
- `statScan` CD: `Rabbit.cs:22746` — `this.$self_$26966.mChar.addTimeOut("statScan", this.$self_$26966.mChar.agiAdjust(30f));`
- `bounce` CD: `Rabbit.cs:21229` — `this.$self_$26924.mChar.addTimeOut("bounce", this.$self_$26924.mChar.agiAdjust((float)30));` (own base cast site, both ranks; see judgment-call note for the separate air-attack-passive re-arm to 36)
- `maimShot` CD: `Rabbit.cs:23477` — `this.$self_$26988.mChar.addTimeOut("maimShot", this.$self_$26988.mChar.agiAdjust(15f));` (single shared cast site for all 4 ranks; fixed literal, not rank-scaled)
- `mix` CD: `Rabbit.cs:20329` (branch: `this.$mTimeOut$26899 = 30;`) applied via the shared dispatcher call at `Rabbit.cs:20440` — `this.$self_$26909.mChar.addTimeOut(this.$sType$26904, this.$self_$26909.mChar.agiAdjust((float)this.$mTimeOut$26899));`
- `shake` CD: `Rabbit.cs:20346` (`$mTimeOut$26899 = 30`) via the same shared dispatcher (`:20440`)
- `miracleBlend` CD: `Rabbit.cs:20363` (`$mTimeOut$26899 = 60`) via the same shared dispatcher (`:20440`)
- `stickyGum` CD: `Rabbit.cs:20380` (`$mTimeOut$26899 = 60`) via the same shared dispatcher (`:20440`)
- `acidicField` CD: `Rabbit.cs:20397` (`$mTimeOut$26899 = 60`) via the same shared dispatcher (`:20440`)
- `immuneShot` CD: `Rabbit.cs:28570` — `this.$self_$27115.mChar.addTimeOut("immuneShot", this.$self_$27115.mChar.agiAdjust(30f));`
- `boostShot` CD: `Rabbit.cs:28582` — `this.$self_$27115.mChar.addTimeOut("boostShot", this.$self_$27115.mChar.agiAdjust(30f));`
- `heatShot` CD: `Rabbit.cs:28594` — `this.$self_$27115.mChar.addTimeOut("heatShot", this.$self_$27115.mChar.agiAdjust(30f));`
- `lifeShot` CD: `Rabbit.cs:28606` — `this.$self_$27115.mChar.addTimeOut("lifeShot", this.$self_$27115.mChar.agiAdjust(30f));`
- `rapidTrance` CD: `Rabbit.cs:29190` — `this.$self_$27126.mChar.addTimeOut("rapidTrance", this.$self_$27126.mChar.agiAdjust(120f));`
- `gorgonShot` CD: `Rabbit.cs:29850` — `this.$self_$27149.mChar.addTimeOut("gorgonShot", this.$self_$27149.mChar.agiAdjust((float)180));`
- `gilShot` CD (reported for all 4 ranks; see judgment-call note): `Rabbit.cs:30530` — `this.$self_$27169.mChar.addTimeOut("gilShot", this.$self_$27169.mChar.agiAdjust(30f));`
- `backpack` CD: `Rabbit.cs:31463` — `this.$self_$27209.mChar.addTimeOut("backpack", this.$self_$27209.mChar.agiAdjust((float)60));`
- `fourShot` CD: `Rabbit.cs:32057` — `this.$self_$27227.mChar.addTimeOut("fourShot", this.$self_$27227.mChar.agiAdjust((float)60));`
- `circleShot` CD: `Rabbit.cs:32966` — `this.$self_$27246.mChar.addTimeOut("circleShot", this.$self_$27246.mChar.agiAdjust((float)90));`
- `mall` CD: `Rabbit.cs:33474` — `this.$self_$27259.mChar.addTimeOut("mall", this.$self_$27259.mChar.agiAdjust((float)90));`
- `truceTrading` CD: `Rabbit.cs:34254` — `this.$self_$27277.mChar.addTimeOut("truceTrading", this.$self_$27277.mChar.agiAdjust((float)240));`
- `shootingArray` CD: `Rabbit.cs:35766` — `this.$self_$27311.mChar.addTimeOut("shootingArray", this.$self_$27311.mChar.agiAdjust((float)120));`
- `millionaire` CD: `Rabbit.cs:36869` — `this.$self_$27348.mChar.addTimeOut("millionaire", this.$self_$27348.mChar.agiAdjust((float)300));`
- `healingField` CD: `Rabbit.cs:20414` (branch: `$mTimeOut$26899 = 120`) via the shared dispatcher (`:20440`)
- `diamondShot` CD: `Rabbit.cs:38445` — `this.$self_$27381.mChar.addTimeOut("diamondShot", this.$self_$27381.mChar.agiAdjust(300f));`
- `tenShot` CD: `Rabbit.cs:39071` — `this.$self_$27406.mChar.addTimeOut("tenShot", this.$self_$27406.mChar.agiAdjust((float)120));`
- `extravagance` CD: `Rabbit.cs:39994` — `this.$self_$27416.mChar.addTimeOut("extravagance", this.$self_$27416.mChar.agiAdjust((float)120));`
- `contract` CD: `Rabbit.cs:40652` — `this.$self_$27432.mChar.addTimeOut("contract", this.$self_$27432.mChar.agiAdjust((float)180));` (matching preemptive call at `Rabbit.cs:105`)

### Duration citations
- `immuneShot` Duration: `Rabbit.cs:28287` — `this.$tChar$27103.RPC_AddStatus("immunity", this.$mImmunityLv$27106, this.$self_$27115.mChar.chaAdjust(15 + this.$mLv$27104 * 5), 0, ...);` — base with `$mLv$27104 = 1` (no `medicalEnhancement`, `Rabbit.cs:28224`) = `chaAdjust(20)`
- `boostShot` Duration: `Rabbit.cs:28341` — `this.$tChar$27103.RPC_AddStatus("boost", this.$mBoostLv$27107, this.$self_$27115.mChar.chaAdjust(30 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(35)`
- `heatShot` Duration: `Rabbit.cs:28400` — `this.$tChar$27103.RPC_AddStatus("heat", this.$mHeatLv$27108, this.$self_$27115.mChar.chaAdjust(30 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(35)`
- `lifeShot` Duration: `Rabbit.cs:28459` — `this.$tChar$27103.RPC_AddStatus("autoLife", this.$mAutoLifeLv$27109, this.$self_$27115.mChar.chaAdjust(60 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(65)`
- `rapidTrance` Duration: `Rabbit.cs:29119` — `this.$self_$27126.mChar.RPC_AddStatus("rapidTrance", 1, this.$self_$27126.mChar.chaAdjust(12), 0, ...);` (self, not target-contested)
- `extravagance` Duration: `Rabbit.cs:39902` — `this.$self_$27416.mChar.RPC_AddStatus("atkUp", 5, this.$self_$27416.mChar.chaAdjust(6), this.$mExtravaganceValue$27411, ...);` (self, not target-contested; 4th param is the money-derived attack-bonus value, not duration)
- `maimShot`, `gorgonShot`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `statScan`, `bounce`, `mix`, `shake`, `miracleBlend`, `stickyGum`, `acidicField`, `gilShot`,
  `backpack`, `fourShot`, `circleShot`, `mall`, `truceTrading`, `shootingArray`, `millionaire`,
  `healingField`, `diamondShot`, `tenShot`, `contract`: no usable Duration — no `RPC_AddStatus`/
  `addStatus`/field-effect-lifetime call exists in the skill's own coroutine class body; see the bulk
  judgment-call note above. Duration cells are `—`.
