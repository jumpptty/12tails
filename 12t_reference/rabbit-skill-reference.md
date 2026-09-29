# Rabbit — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| statScan | Stat Scan | 1 | 30 | true | false | — | — |
| bounce | Bounce | 2 | 30 | true | false | 4 / 8 | false (fixed) |
| maimShot | Maim Shot | 4 | 15 | true | false | 3 (contested) | Damage.getDebuff |
| mix | Mix | 4 | 30 | true | false | 60 | true |
| shake | Shake | 3 | 30 | true | false | 60 | true |
| miracleBlend | Miracle Blend | 1 | 60 | true | false | 4 (Alchemist Lab 1-4: 6/8/10/12) | true |
| stickyGum | Sticky Gum | 2 | 60 | true | false | 12 | true |
| acidicField | Acidic Field | 2 | 60 | true | false | 12 | true |
| immuneShot | Immune Shot | 1 | 30 | true | false | 20 | true |
| boostShot | Boost Shot | 1 | 30 | true | false | 35 | true |
| heatShot | Heat Shot | 1 | 30 | true | false | 35 | true |
| lifeShot | Life Shot | 1 | 30 | true | false | 65 | true |
| rapidTrance | Rapid Trance | 1 | 120 | true | false | 12 | true |
| gorgonShot | Gorgon Shot | 2 | 180 | true | false | 6 / 9 (contested) | Damage.getDebuff |
| gilShot | Gil Shot | 4 | 30 | true | false | — | — |
| backpack | Backpack | 2 | 60 | true | false | — | — |
| fourShot | Four Shot | 2 | 60 | true | false | — | — |
| circleShot | Circle Shot | 2 | 90 | true | false | — | — |
| mall | Mall | 2 | 90 | true | false | — | — |
| truceTrading | Truce Trading & Co. | 2 | 240 | true | false | — | — |
| shootingArray | Shooting Array | 2 | 120 | true | false | — | — |
| millionaire | Millionaire | 2 | 300 | true | false | — | — |
| healingField | Healing Field | 1 | 120 | true | false | 12 | true |
| diamondShot | Diamond Shot | 1 | 300 | true | false | — | — |
| tenShot | Ten Shot | 1 | 120 | true | false | — | — |
| extravagance | Extravagance | 1 | 120 | true | false | 6 | true |
| contract | Contract | 1 | 180 | true | false | 300 | false |

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
- **`alchemistLab`'s MiracleBlend-duration-extension claim (eng description above) is independently
  verified in code — not in `Rabbit.cs` at all, but in `Rabbit_potion.cs`, the thrown potion's own
  pickup-effect class.** A full-file grep of `Rabbit.cs` for `alchemistLab` returns zero hits; the real
  mechanism is `Rabbit_potion.cs:223-270`, where the potion's pickup handler checks
  `hasSkill(231)`/`hasSkill(232)`/`hasSkill(233)`/`hasSkill(234)` (confirmed as
  `rab_alchemistLab1`-`4` via `RabbitSkill.cs:2628-2671`'s `commandNum` switch) to set a local rank
  variable `num` to 1/2/3/4 (default 0). `Mathf.Clamp(num,1,4)` only limits the status **level** (so 0 acts as level 1); the duration term `4 + 2 * num` uses the raw `num`, so it is **4 s** with no Alchemist Lab.
  That rank feeds the `"miracleDrop"` status duration at `Rabbit_potion.cs:432-438`:
  `this.chaAdjust(4 + 2 * num)` → 6/8/10/12s, exactly matching the flavor text. `miracleBlend`'s Duration
  is `4` s unlearned and 6/8/10/12 s at Alchemist Lab 1-4 (corrected 2026-09-26; it was reported as `6`); the previous "no usable Duration"
  judgment call was correct for `Rabbit.cs` alone but missed this per-skill companion file. This is also
  the first case in this doc of a skill whose Duration is a function of a *different* skill's learned
  rank rather than only CHA/LCK — see `12t_projects/player-reference-tool/index.html`'s `dep` field on
  the `SKILLS` entry, which encodes this relationship structurally for the lookup tool
  (`rawAtRank(R) = duration + perRank*(R - minRank)`, `minRank:1, maxRank:4, perRank:2` here).
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
  LifeShot duration formulas below — see the Duration citations note. This relationship is encoded
  structurally in the lookup tool's data via each of those four `SKILLS` entries' `dep` field
  (`12t_projects/player-reference-tool/index.html`): `rawAtRank(R) = duration + perRank*(R - minRank)`,
  `minRank:0, maxRank:3, perRank:5`, letting the tool live-recompute Duration for any learned rank
  instead of only reporting the unlearned base.
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
  — `this.mChar.addTimeOut("contract", this.mChar.agiAdjust(180f));` — sits inside `Start()`
  (unconditional in real game modes; the `hasSkill(444)` check after it only guards `Game.useCoin = false`,
  `Rabbit.cs:114-120`), a state pre-arm on login (matching the Panda `fuujinKen`/`raijinKen` preemptive-
  `addTimeOut` precedent) — matches the real cast site exactly (`Rabbit.cs:40652`,
  `agiAdjust((float)180)`). Not a discrepancy.
- **`bounce` applies a fixed `hide` status buff for 4s (Rank 1) / 8s (Rank 2)** (`Rabbit.cs:21068-21073`):
  `this.$self_$26924.mChar.StartCoroutine_Auto(this.$self_$26924.mChar.addStatus("hide", 1, 4 * this.$sLv$26923 + 1, 0, this.$self_$26924.mChar.ActorNr));`
  and sets `mBounceTimer = Time.time + 4 * sLv`. Fixed duration (not CHA-adjusted).
- **No `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists for**: `statScan`,
  `gilShot`, `backpack`, `fourShot`, `circleShot`,
  `mall`, `truceTrading`, `shootingArray`, `millionaire`, `diamondShot`, `tenShot` — confirmed by a
  full-file grep of every `RPC_AddStatus(` call in `Rabbit.cs` and cross-checking each hit against these
  skills' own coroutine bodies. The remaining `RPC_AddStatus` hits in the file belong either to the 12
  support skills, to the passive skills documented above, or to an unrelated shared
  minigame/consumable-item/flag-capture effect system (`wash`, `bless`, `ice`, `bubbleShield`,
  `iceShield`, `awareness`, `float`, `mpsap`, `burn`, `blind`, `plague`, `frost`, `awake`, `yellowFlag`,
  `cleanse`, `blueFlag`, `whiteFlag`, `redFlag`, `happy`, `charm`, `clear`, `poison`, `heavy`, `mpDrain`,
  `hpDrain`) — none tied to any `RabbitSkill.cs` roster entry, matching the same generic-effects block
  documented in the Monkey/Panda docs. Duration cells for all twelve skills listed above are `—`.
  **`mix`, `shake`, `miracleBlend`, `stickyGum`, `acidicField`, `healingField`, `contract` are no longer
  in this list** — each is verified separately below, none via `RPC_AddStatus` (thrown potions and field
  objects have their own on-the-ground lifetime; `contract` summons a real character with its own
  lifespan field).
- **`mix` and `shake` throw potions whose ground lifetime (re-checked 2026-08-14, user request) uses the
  exact same `Rabbit_potion` companion-class mechanism `miracleBlend` already established, not a
  distinct system.** `mix` (`RPC_mix_create`): spawn `Rabbit.cs:24530`
  (`GetComponent(typeof(Rabbit_potion))`), lifetime at `Rabbit.cs:24535` —
  `this.$mPotionControl$27010.Init(this.$self_$27014.mChar.chaAdjust(60), this.$tID$27012,
  this.$self_$27014.mChar.ActorNr);`. `shake` (`RPC_shake_create`): spawn `Rabbit.cs:25362`, lifetime at
  `Rabbit.cs:25367` — `this.$mPotionControl$27033.Init(this.$self_$27037.mChar.chaAdjust(60),
  this.$tID$27035, this.$self_$27037.mChar.ActorNr);`. Both `chaAdjust(60)`, matching `miracleBlend`'s
  own create-coroutine, which calls the identical `Rabbit_potion.Init(chaAdjust(60), ...)` pattern — all
  three skills share one prop class and one lifetime constant. Despawn logic lives in
  `Rabbit_potion.cs`, not `Rabbit.cs`: `Init(int nLife, int nID, int nOwnerID)` at `Rabbit_potion.cs:45`
  stores a deadline at `:70` (`this.AEGNULYSjg = (int)((float)nLife + Time.time);`); `Update()`
  (`:88-137`) checks that deadline (`:115`) and falls through to `Destroy(this.gameObject)` (`:130`) once
  it passes — a genuine ground-despawn timer, distinct from the pickup-triggered `Destroy` inside
  `OnTriggerEnter` (`:141-270`). This is "how long the potion sits on the ground before vanishing if
  nobody picks it up," not the drinker's own buff duration (already covered separately by each potion's
  own on-pickup status, e.g. `miracleBlend`'s `"miracleDrop"`).
- **`contract` summons a real character (a Light Panther/Leopard/Golem elemental, by rank) with its own
  bare-literal 300s lifespan — not `RPC_AddStatus`, and not in `Rabbit.cs` at all.** `RPC_contract_create`
  (`Rabbit.cs:11542`) instantiates the rank-specific elemental (`sLv==1`→`LightPanther`, `Rabbit.cs:11572`;
  `sLv==2`→`LightLeopard`, `:11584`; `sLv==3`→`LightGolem`, `:11596`; `Instantiate` at `:11611`,
  `isSummon = true` at `:11766`). Each elemental's own `Awake()` sets its despawn deadline as a **bare
  literal**, not wrapped in any Adjust function: `LightPanther.cs:44` — `this.iLbtx364rH = Time.time +
  (float)300;` — identically `LightLeopard.cs:44` and `LightGolem.cs:44`. Checked each `Update()`
  (`LightPanther.cs:286`, `LightLeopard.cs:286`, `LightGolem.cs:183`): while `Time.time` hasn't passed the
  deadline the unit stays alive; once it has, execution falls into the same death-sequence branch used for
  `hp <= 0` (e.g. `LightPanther.cs:295-305`, `RPC_dead`) — timeout is treated identically to being killed.
  **Caution for future citation:** `Rabbit.cs:40729` sets `$mContractTime$27422 =
  mChar.magAdjust(3 + 3*sLv)`, checked at `:40359` and fed to `DisplayCastBar` at `:40738` — this is the
  pre-summon **cast/channel gate**, not the summoned elemental's lifespan; do not conflate the two if
  re-deriving this citation later.
- **`stickyGum`/`acidicField`/`healingField` each place a timed field object whose lifetime is set by its
  own dedicated companion `.cs` file, not by anything in `Rabbit.cs`'s `RPC_AddStatus` calls — same
  "verified outside the class-name file" pattern as `alchemistLab`/`miracleBlend`.** Each companion file
  (`Rabbit_stickyGum.cs`, `Rabbit_acidicField.cs`, `Rabbit_healingField.cs`) defines an `Init(int nLv,
  int nLife, int nOwnerID)` (or, for `healingField`'s single-rank case, `Init(int nLife, int nOwnerID)`)
  that stores a deadline `nLife + Time.time`; its own `Update()` calls
  `UnityEngine.Object.Destroy(this.gameObject)` once `Time.time` passes that deadline — confirmed
  identical in all three files (`Rabbit_stickyGum.cs:28,50,91,113`, `Rabbit_acidicField.cs:50,100,213`,
  `Rabbit_healingField.cs:47,96,204`). `Rabbit.cs` computes `nLife` in each skill's own cast coroutine
  before calling `RPC_<name>_create(...)` → `Init(...)`, all three landing on the identical
  `chaAdjust(12)`: `stickyGum` at `Rabbit.cs:26621`, `acidicField` at `Rabbit.cs:27128`, `healingField`
  at `Rabbit.cs:37831`.

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
- `heatShot` stat gain / level stacking: `Rabbit.cs:28375-28399` — `mHeatLv = tChar.getStatusLv("heat"); if (mHeatLv < mLv) mHeatLv++; else mHeatLv = mLv;` with `mLv = 1 + getMedicalEnhancementLv()` (`Rabbit.cs:28224`). Status effect: `CharacterControl.cs:37506` `deltaTal(10 * sLv)` on apply, reversed at `CharacterControl.cs:16834` `deltaTal(-10 * sLv)`. Cast-time SP: `Rabbit.cs:28405` `RPC_AddHeal(251, 0, 0, 10 * mHeatLv, 0, 0, ...)` (`nSp` is the 4th argument, `CharacterControl.cs:7130`). Classification: `StatusData.cs:6722` (`isBuffStatus`) and `:5735` (`isMagicalStatus`) → Buff, Magical. No other source reads `"heat"` (no burn/fire effect). Client tooltip (`RabbitSkill_eng.cs:473`) says "+10 tal, 30 seconds" — it omits the stacking and the 35s base. The `medicalEnhancement` tooltips (`RabbitSkill_eng.cs:499-521`) say 40/50/60s, but the code adds +5s per rank (40/45/50s for heat) — unresolved discrepancy; live observation takes precedence.
- `heatShot` cross-caster over-cap: a second Rabbit whose cap equals the target's current level bumps it to `cap + 1` (empirically heat4 → heat5 with two Medical Enhancement 3 Rabbits), and shots then stop refreshing the duration because `RPC_AddStatus` drops any application below the existing level — generic rule documented in [12Tails-Mechanics-Reference.md §4.2.1](12t_reference/12Tails-Mechanics-Reference.md#421-re-applying-an-already-active-status--level-merge-rule-charactercontrolcs14017-14160-inside-rpc_addstatus) (`CharacterControl.cs:14115-14159`).
- `heatShot` Duration: `Rabbit.cs:28400` — `this.$tChar$27103.RPC_AddStatus("heat", this.$mHeatLv$27108, this.$self_$27115.mChar.chaAdjust(30 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(35)`
- `lifeShot` Duration: `Rabbit.cs:28459` — `this.$tChar$27103.RPC_AddStatus("autoLife", this.$mAutoLifeLv$27109, this.$self_$27115.mChar.chaAdjust(60 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(65)`
- `miracleBlend` Duration: `Rabbit_potion.cs:432-438` — `characterControl2.RPC_AddStatus("miracleDrop", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 50, this.gbbNPxW0WH);` — `num` is set from `hasSkill(231/232/233/234)` (`rab_alchemistLab1`-`4`, `Rabbit_potion.cs:223-270`), floored to 1 by the `Mathf.Clamp`; base with no `alchemistLab` (`num = 0`) = `chaAdjust(4)`; Lab 1-4 = `chaAdjust(6/8/10/12)`. Verified outside `Rabbit.cs` — see the dedicated judgment-call note above.
- `stickyGum` Duration (field lifetime, not `RPC_AddStatus`): `Rabbit.cs:26621` — `this.$mDuration$27071 = this.$self_$27075.mChar.chaAdjust(12);`, passed into `RPC_stickyGum_create(...)` → `Rabbit_stickyGum.Init(sLv, nLife, ownerID)`, which stores `nLife + Time.time` as the field's own despawn deadline. See the dedicated judgment-call note above.
- `acidicField` Duration (field lifetime): `Rabbit.cs:27128` — `this.$mDuration$27083 = this.$self_$27087.mChar.chaAdjust(12);`, same `Init()`-deadline pattern via `Rabbit_acidicField.cs`.
- `healingField` Duration (field lifetime): `Rabbit.cs:37831` — `this.$mDuration$27360 = this.$self_$27363.mChar.chaAdjust(12);`, same pattern via `Rabbit_healingField.cs`.
- `rapidTrance` Duration: `Rabbit.cs:29119` — `this.$self_$27126.mChar.RPC_AddStatus("rapidTrance", 1, this.$self_$27126.mChar.chaAdjust(12), 0, ...);` (self, not target-contested)
- `extravagance` Duration: `Rabbit.cs:39902` — `this.$self_$27416.mChar.RPC_AddStatus("atkUp", 5, this.$self_$27416.mChar.chaAdjust(6), this.$mExtravaganceValue$27411, ...);` (self, not target-contested; 4th param is the money-derived attack-bonus value, not duration)
- `mix` Duration (potion ground-lifetime, not `RPC_AddStatus`): `Rabbit.cs:24530,24535` — `this.$mPotionControl$27010.Init(this.$self_$27014.mChar.chaAdjust(60), this.$tID$27012, this.$self_$27014.mChar.ActorNr);`, same `Rabbit_potion.cs` despawn-deadline pattern as `miracleBlend`/`stickyGum`/etc. See the dedicated judgment-call note above.
- `shake` Duration (potion ground-lifetime): `Rabbit.cs:25362,25367` — `this.$mPotionControl$27033.Init(this.$self_$27037.mChar.chaAdjust(60), this.$tID$27035, this.$self_$27037.mChar.ActorNr);`, same pattern.
- `contract` Duration (summoned-elemental lifespan, bare literal, not `RPC_AddStatus`): `Rabbit.cs:11542,11572/11584/11596` (rank-specific `LightPanther`/`LightLeopard`/`LightGolem`) → each unit's own `Awake()`, e.g. `LightPanther.cs:44` — `this.iLbtx364rH = Time.time + (float)300;`. See the dedicated judgment-call note above (and its caution re: not conflating this with `Rabbit.cs:40729`'s unrelated `magAdjust` cast-gate value).
- `maimShot`, `gorgonShot`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `statScan`, `bounce`, `gilShot`,
  `backpack`, `fourShot`, `circleShot`, `mall`, `truceTrading`, `shootingArray`, `millionaire`,
  `diamondShot`, `tenShot`: no usable Duration — no `RPC_AddStatus`/
  `addStatus`/field-effect-lifetime call exists in the skill's own coroutine class body; see the bulk
  judgment-call note above. Duration cells are `—`.

---

# Damage & Mechanics


Companion to `rabbit-skill-reference.md` (cooldown/duration/maxRank — trusted as-is below, not re-derived here except where flagged). This doc backs the rank-selector + damage/heal-formula fields (`maxRank`, per-rank `cd`/`castTime`/`duration` arrays, `dmg`, `dmgDep`/`dmgMultDep`, `atkCoeff`, `hitCount`, `dmgGroups`) added to Rabbit's `SKILLS` entries in `12t_projects/player-reference-tool/index.html`, 2026-08-25 — the 3rd class built out beyond Penguin (1st) and Mole (2nd). Researched via decompiled source analysis of `DecompiledSource/Rabbit.cs`, `DecompiledSource/RabbitSkill.cs`, `DecompiledSource/RabbitSkill_eng.cs`, and companion files (`Rabbit_potion.cs`, `Rabbit_acidicField.cs`, `Rabbit_healingField.cs`, `Rabbit_stickyGum.cs`). All citations are `file:line` against `DecompiledSource/Rabbit.cs` unless noted.

---

## Summary table

| Skill | maxRank | Cost (Base) | cd/castTime/duration rank-variance | dmg (`sLv`=rank) | dmgNote | dmgDep / dmgMultDep | hitCount |
|---|---|---|---|---|---|---|---|
| statScan | 1 | 6 SP (red) | none | no dmg — reveals target stats | — | — | — |
| bounce | 2 | [5, 8] SP (red) | none | `ATK`, KO=20 (`Rabbit.cs:21652`) | melee leap attack; if `fromTheAbove5` owned, triggers ground stomp | **fromTheAbove5** (stomp effect) | 1 |
| maimShot | 4 | [12, 13, 14, 15] SP (blue) | none | `0.5×ATK + talAdjust(5×sLv)` (`Rabbit.cs:23280`) | restores +1 SP; applies `"maim"` status (`Damage.getDebuff(3, cha, target.cha)`) | **kneeShot5** (hasSkill 402, +20 to talAdjust base) | 1 |
| mix | 4 | [6, 9, 12, 15] MP | none | no direct dmg — creates HP/SP/MP potion pickups (`Rabbit_potion.cs`) | HP potion heals `20×sLv` (`[20, 40, 60, 80]`) | **extraPotion5** (hasSkill 412, `+0.3×LV` HP heal) | — |
| shake | 3 | [6, 10, 14] MP | none | no direct dmg — creates compound potions on ground (lifetime 60s) | — | — | — |
| miracleBlend | 1 | 18 MP | none | no direct dmg — spawns miracle potion (`Rabbit_potion.cs:438`) | status `"miracleDrop"` duration = `chaAdjust(4 + 2×num)` (4/6/8/10/12s), `damageMod` and `hitMod` each `+0.1×sLv+0.1` (`CharacterControl.cs:37667`; the `50` passed as `sValue` is never read) | **alchemistLab** (hasSkill 231-234, ranks 1..4, +2s/rank) | — |
| stickyGum | 2 | [6, 10] MP, [10, 10] SP (red) | none | no dmg — slows movement in radius `1.5m / 2.5m` (`Rabbit_stickyGum.cs:140`) | status `"sticky"` (lv `sLv`) for `chaAdjust(12)` | — | — |
| acidicField | 2 | [8, 12] MP, [15, 15] SP (red) | none | `10×sLv` flat true effect damage per tick (`[10, 20]`) (`Rabbit_acidicField.cs:198`) | penetrating (direct `RPC_AddEffectDamage`), pulses every 2s (6 ticks over 12s) + `"acid"` debuff | — | 6 |
| immuneShot | 1 | 10 MP, 10 SP (blue) | none | no dmg — cures debuffs (`"remedy"`), grants `"immunity"` (`Rabbit.cs:28287`) | duration `chaAdjust(15 + 5×[medEnhanceLv+1])` (20s to 35s) | **medicalEnhancement** (ranks 0..3, +5s/rank) | — |
| boostShot | 1 | 10 MP, 10 SP (blue) | none | no dmg — heals `100×(1+medEnhanceLv)` HP (`100–400`) (`Rabbit.cs:28346`) | grants `"boost"` for `chaAdjust(30 + 5×[medEnhanceLv+1])` (35s to 50s) | **medicalEnhancement** (ranks 0..3, +5s/rank, +100 HP/rank) | — |
| heatShot | 1 | 10 MP, 10 SP (blue) | none | no dmg — grants `"heat"` status (`Rabbit.cs:28400`): TAL `+10×heatLv` (`CharacterControl.cs:37506`) and an immediate `+10×heatLv` SP heal (`Rabbit.cs:28405`); `heatLv = min(currentHeatLv + 1, 1 + medEnhanceLv)` (`Rabbit.cs:28375-28399`), so recasting on the same target stacks the level | duration `chaAdjust(30 + 5×[medEnhanceLv+1])` (35s to 50s) | **medicalEnhancement** (ranks 0..3: +5s/rank and level cap 1..4, i.e. TAL/SP `+10..+40`) | — |
| lifeShot | 1 | 10 MP, 10 SP (blue) | none | no dmg — grants `"autoLife"` revive buff (`Rabbit.cs:295`) | duration `chaAdjust(60 + 5×[medEnhanceLv+1])` (65s to 80s) | **medicalEnhancement** (ranks 0..3, +5s/rank) | — |
| rapidTrance | 1 | 20 MP, 30 SP (red) | none | no dmg — grants `"rapidTrance"` action speed buff for `chaAdjust(12)` (`Rabbit.cs:28846`) | — | — | — |
| gorgonShot | 2 | [20, 30] MP, [35, 50] SP (red) | none | `talAdjust(50×sLv)` (`[50, 100]`) (`Rabbit.cs:29671`) | petrifies target (`"petrify"`) for `3×sLv+3`s (`[6s, 9s]` contested) | — | 1 |
| gilShot | 4 | [10, 12, 14, 16] SP (blue) | none | `(0.6 + 0.1×sLv)×ATK + talAdjust(10×sLv)` (`Rabbit.cs:30399`) | KO=`sLv+1` (`[2, 3, 4, 5]`), restores +1 SP | **diamondShot5** (hasSkill 403, +20 to talAdjust base) | 1 |
| backpack | 2 | Free / 0 | none | `floor(0.5×sLv×InventoryWeight + bigBag?0.25×ItemCount:0)` per hit (`Rabbit.cs:31593`) | 3 AoE pulses every 0.2s; radius 2m (3m with Big Bag), KO=`10×sLv`, 0.3m knockback | **bigBag5** (hasSkill 423, +1m radius and `+0.25×ItemCount`) | 3 |
| herbFinder | 2 | Passive / 0 | none | no damage — enables field-herb gathering | base chance `20×sLv`% is LCK-adjusted; the inclusive `<=` roll gives one additional integer outcome | **bigBag5** (hasSkill 423, guarantees success) | — |
| bigBag | 1 | Passive / 0 | none | no direct damage — upgrades Backpack and Herb Finder | Backpack gains range and `+0.25×ItemCount`; Herb Finder succeeds automatically | — | — |
| fourShot | 2 | [12, 15] SP (red) | none | `0.5×ATK + talAdjust(15×sLv)` per shot (`Rabbit.cs:32374`) | 4 shots in 4 directions (70° cones, 24m), one target takes at most 1 hit, KO=1/hit | **tenShot5** (hasSkill 433, +10 to talAdjust base) | 1 per target (4 shots) |
| circleShot | 2 | [24, 27] SP (red) | none | `0.5×ATK + talAdjust(15×sLv)` (`Rabbit.cs:32732`) | 360-degree AoE spray (radius `8×rangeMod`, 3 rapid pulses, `Rabbit.cs:32690-32872, 33141`), KO=1/hit | **tenShot5** (hasSkill 433, +10 to talAdjust base) | 3 |
| mall | 2 | Free / 0 | none | no dmg — opens a player shop (8-slot `MallGui`, no client rank check on slot count) | — | — | — |
| truceTrading | 2 | [20, 30] MP | none | no dmg — negotiation to buy an item from a non-player target (success `LCK × rank > Random(0, target HP)`, `Rabbit.cs:34111`) | — | — | — |
| shootingArray | 2 | [24, 30] SP (red) | none | 3 hits of `0.5×ATK + talAdjust(15×sLv)` + 1 finisher of `1.0×ATK + talAdjust(30×sLv)` (`Rabbit.cs:35331`, `:35630`) | modeled via `dmgGroups` (4 hits total), KO=1/hit | — | 4 (`dmgGroups`) |
| millionaire | 2 | [50, 75] SP (red) | none | `ceil(0.005×sLv×min(Gil+Jil, 99999))` per pulse (`Rabbit.cs:37212`) | 6-pulse AoE burst (radius 8m, max 500/hit @ R1, max 1000/hit @ R2, `Rabbit.cs:37035`), KO=1/hit | — | 6 |
| healingField | 1 | 30 MP, 30 SP (red) | none | no dmg — area healing field, radius 12m (`Rabbit_healingField.cs:189`) | heals **70 flat HP** per tick, pulses every 2s (6 ticks over 12s) | — | 6 |
| diamondShot | 1 | 20 SP (red) | none | **1000 flat true effect damage** (`Rabbit.cs:38322`) | direct `RPC_AddEffectDamage`, penetrating vs monsters | — | 1 |
| tenShot | 1 | 20 SP (red) | none | `0.5×ATK + talAdjust(60)` per bullet (`Rabbit.cs:39499`, `:39552`) | 10 bullets in 5 volleys (70° cones, 24m), 1-3 hits per target (about 2), KO=1/hit | — | 10 bullets, ~2 per target |
| extravagance | 1 | 20 MP, 40 SP (red) | none | no dmg — spends `1% Gil` (capped at 512) to grant `+GilSpent` ATK buff for `chaAdjust(6)` (`Rabbit.cs:39902`, `:40056`) | — | **skillBargain5** (hasSkill 413, reduces cost by 40%) | — |
| contract | 1 | 50 MP, 30 SP (red) | none | no dmg — hires mercenaries by current SP after cost: Lv1 2 Light Panther / Lv2 2 Light Leopard (SP >= 35) / Lv3 1 Light Golem (SP >= 65), 300s (`Rabbit.cs:7602-7631`, `:40376-40475`) | — | — | — |

---

## Detailed Citations & Mechanics Notes

### 1. Maim Shot (`maimShot1-4`)
* **Source:** `Rabbit.cs:23280` inside `$RPC_maimShot$26971`
* **Formula:** `(int)(0.5f * atk + talAdjust(sLv * 5 + (hasSkill(402) ? 20 : 0)))`
* **KO:** Base `1` (`Rabbit.cs:23246`). With `hasSkill(402)` (Knee Shot), rolls an independent `lckAdjust(20)` percentage chance to deal `40` KO (`Rabbit.cs:23262-23273`).
* **On Hit:** Restores `+1 SP` (`Rabbit.cs:23354`) and applies `"maim"` status for duration `Damage.getDebuff(3f, caster.cha, target.cha)` (`Rabbit.cs:23337`).
* **Maim Status Effect:** A per-frame clamp inside `CharacterUpdate()` (not the one-time `RPC_AddStatus`/`removeStatus` apply sites, both of which are empty for `maim`): while the target is on its own client (`isMine`) and `actionState == "run"`, if `moveSpeed` exceeds `4 - 0.5×sLv` it is set down to that cap every frame — `CharacterControl.cs:2509-2546` (2527-2533 is the clamp line itself). Rank 1: 3.5 m/s, Rank 2: 3.0 m/s, Rank 3: 2.5 m/s, Rank 4: 2.0 m/s. Only gates running (matches the tooltip "จำกัดความเร็ววิ่ง"); does not touch `moveMod` or walking speed. See `12Tails-Mechanics-Reference.md`'s hitMod catalog note, corrected 2026-09-23.
* **Dependency:** `rab_kneeShot5` (Skill ID 402, `RabbitSkill.cs:3215`) adds a flat `+20` inside the `talAdjust` base and enables the 20% LCK-scaled chance for 40 KO.

### 2. Four Shot (`fourShot1-2`)
* **Source:** `Rabbit.cs:32374` inside `$RPC_fourShot$27214`
* **Formula:** `(int)(0.5f * atk + talAdjust(15 * sLv + (hasSkill(433) ? 10 : 0)))` per shot.
* **Hit Count:** 4 shots in four directions; one target takes at most 1 hit (see the multi-hit geometry section).
* **KO:** 1 per hit.
* **Dependency:** `rab_tenShot5` (Skill ID 433, `RabbitSkill.cs:3303`) adds `+10` to `talAdjust` base.

### 3. Circle Shot (`circleShot1-2`)
* **Source:** `Rabbit.cs:32732` inside `$RPC_circleShot$27232`
* **Formula:** `(int)(0.5f * atk + talAdjust(15 * sLv + (hasSkill(433) ? 10 : 0)))` per pulse.
* **Hit Count:** 3 rapid AoE pulses (`Rabbit.cs:32690-32872`, `this.$i$27236 < 3` yielding `WaitForSeconds(0.133f)` at `Rabbit.cs:33141`).
* **Radius:** `8 * rangeMod` meters.
* **KO:** 1 per hit (3 KO total across all 3 hits).
* **Dependency:** Shares `rab_tenShot5` (+10 to talAdjust base).

### 4. Shooting Array (`shootingArray1-2`)
* **Source:** `Rabbit.cs:35331` (ticks 1–3) and `Rabbit.cs:35630` (final tick) inside `$RPC_shootingArray$27293`
* **Ticks 1–3:** `(int)(0.5f * atk + talAdjust(15 * sLv))` (3 hits).
* **Tick 4 (Finisher):** `atk + talAdjust(30 * sLv)` (1 hit).
* **Total Hits:** 4 hits. Modeled with `dmgGroups`.

### 5. Gil Shot (`gilShot1-4`)
* **Source:** `Rabbit.cs:30399` inside `$RPC_gilShot$27155`
* **Formula:** `(int)((0.6f + 0.1f * sLv) * atk + talAdjust(10 * sLv + (hasSkill(403) ? 20 : 0)))`
  * Rank 1: `0.7×ATK + talAdjust(10 + dep)`
  * Rank 2: `0.8×ATK + talAdjust(20 + dep)`
  * Rank 3: `0.9×ATK + talAdjust(30 + dep)`
  * Rank 4: `1.0×ATK + talAdjust(40 + dep)`
* **KO:** `sLv + 1` (2, 3, 4, 5).
* **On Hit:** Restores `+1 SP`.
* **Dependency:** `rab_diamondShot5` (Skill ID 403, `RabbitSkill.cs:3271`) adds `+20` inside `talAdjust`.

### 6. Backpack (`backpack1-2`)
* **Source:** `Rabbit.cs:31588-31616` inside `$RPC_backpack$27175`.
* **Attack:** Three pulses, 0.2s apart (`Rabbit.cs:31568`, `:31666`), targeting enemies in a radius of `2×rangeMod` (or `3×rangeMod` with Big Bag), height 3 (`Rabbit.cs:31588`). Each landed hit deals `floor(0.5×sLv×InventoryWeight + BigBag?0.25×ItemCount:0)`, KO=`10×sLv`, and pushes outward 0.3m (`Rabbit.cs:31593`, `:31616`).
* **Inventory inputs:** `InventoryWeight` adds each occupied slot's item-type weight once when positive; it does not multiply by that stack's quantity (`Rabbit.cs:31145-31177`). `ItemCount` does sum every stack quantity (`Rabbit.cs:31153`) and is used only by Big Bag's damage bonus.
* **Passive burden reduction:** Rabbit's occupied inventory slots contribute `0.5 - 0.25×BackpackRank` to carried weight (`CharacterDataClass.cs:2248-2285`): 0.25 per slot at rank 1 (50% reduction) and 0 at rank 2 (100% reduction).
* **Dependency:** `rab_bigBag5` (Skill ID 423, `RabbitSkill.cs:31024`) adds 1m radius and `0.25×ItemCount` damage per hit.

### 6.1 Herb Finder (`herbFinder1-2`) and Big Bag (`bigBag5`)
* **Herb access:** A Rabbit needs Herb Finder rank 1 or 2 before the field-herb interaction is available (`Herb.cs:184`).
* **Chance:** Without Big Bag, `getHerbFinder()` resolves the learned rank as `1` or `2`, then succeeds when `Random.Range(0, 100) <= lckAdjust(20×rank)` (`Rabbit.cs:10636-10666`). The actual base chances are therefore **20% / 40%**, LCK-adjusted with an inclusive comparison—not the 30% / 50% stated in the client tooltip (`RabbitSkill_eng.cs:653`, `:664`).
* **Big Bag:** Owning Skill ID 423 returns success immediately before any roll (`Rabbit.cs:10624-10630`), so Herb Finder is **100%** successful. The same passive expands Backpack's area and adds `0.25×ItemCount` damage (`Rabbit.cs:31024`, `:31588`, `:31593`).

### 7. Millionaire (`millionaire1-2`)
* **Source:** `Rabbit.cs:37212` inside `$RPC_millionaire$27336`
* **Formula:** `Mathf.CeilToInt(0.005f * sLv * Mathf.Clamp(PlayerData.Gil + PlayerData.Jil, 0, 99999))`
  * Rank 1: `0.005 * Money` (Max 500 base damage).
  * Rank 2: `0.010 * Money` (Max 1000 base damage).
* **KO:** 1.

### 8. Diamond Shot (`diamondShot`)
* **Source:** `Rabbit.cs:38322` inside `$RPC_diamondShot$27367`
* **Formula:** `RPC_AddEffectDamage(403, 1000, 0, 0, ...)`
* **Mechanic:** Flat 1,000 true effect damage (penetrating, bypasses defAdjust).

### 9. Ten Shot (`tenShot`)
* **Source:** `Rabbit.cs:39499`, `:39552` inside `$RPC_tenShot$27386`
* **Formula:** `(int)(0.5f * atk + talAdjust(60))` per bullet.
* **Hit Count:** 10 bullets (5 from left launcher, 5 from right launcher).
* **KO:** 1 per hit.

### 10. Acidic Field (`acidicField1-2`)
* **Source:** `Rabbit_acidicField.cs:198`, `Rabbit.cs:10159`, `Rabbit.cs:27128`
* **Formula:** `RPC_AddEffectDamage(242 + effectiveLv, 10 * effectiveLv, 0, 0, ...)` where `effectiveLv = sLv + (hasSkill(442) ? 1 : 0)`.
  * Without Healing Field: 10 true effect damage/tick (Rank 1), 20 (Rank 2).
  * With Healing Field (`rab_healingField5`, Skill ID 442): 20 true effect damage/tick (Rank 1), 30 (Rank 2).
* **Damage Type:** True Effect Damage (`effectDamage: true`, purple damage font in formula and purple digit popup `dmgdigit_p<N>` in simulation, bypasses DEF and damageMod).
* **Duration & Pulse Cadence:** `chaAdjust(12)` seconds total duration, pulsing once every 2.0s (`Rabbit_acidicField.cs:131`).
* **Hit Count Scaling:** Dynamic pulse count $= \lfloor\text{chaAdjust}(12) / 2\rfloor$ (6 pulses at base CHA, scaling with CHA).
* **Area:** Each pulse calls `Damage.FindAreaTarget(transform.position, 12, 3, layerMask)` (`Rabbit_acidicField.cs:141`) — a fixed 12m radius / 3m height cylinder, identical at both ranks and **not** multiplied by `rangeMod` (the field object isn't the caster). The Thai client tooltip claims "8 m" for Rank 1 vs "12 m" for Rank 2 (`RabbitSkill_thai.cs:455`, `:465`); the code shows one constant radius for both ranks, so the tooltip's per-rank figure is stale/inaccurate.
* **Status:** Applies/refreshes `"acid"` (duration 3s, re-applied every pulse) on each hit target — `deltaDef(-10 * effectiveLv)` (`RPC_AddStatus` call `Rabbit_acidicField.cs:193`; apply-side DEF delta at `CharacterControl.cs:16820`). Classification: `isDebuffStatus` and `isPhysicalStatus` both true (`StatusData.cs:7448`, `:5499`) — Debuff, Physical.
* **Dependency:** `rab_healingField5` (Skill ID 442, `RabbitSkill.cs:3255`) adds `+1` effective skill level.

### 11. Healing Field (`healingField1`)
* **Source:** `Rabbit.cs:37831`, `Rabbit_healingField.cs:189`
* **Formula:** `RPC_AddHeal(442, 70, 0, 0, ...)`
* **Duration & Pulse Cadence:** `chaAdjust(12)` seconds total duration, pulsing once every 2.0s.
* **Hit Count Scaling:** Dynamic pulse count $= \lfloor\text{chaAdjust}(12) / 2\rfloor$ (6 pulses at base CHA $\rightarrow$ 420 total HP, scaling with CHA).
* **Healing Output:** 70 flat HP restored per pulse to all allies in a 12m radius.

### 12. Gorgon Shot (`gorgonShot1-2`)
* **Source:** `Rabbit.cs:29638` (`Physics.SphereCastAll`) through `:29726` inside `$RPC_gorgonShot$27149`
* **Formula:** `talAdjust(sLv * 50)` (no ATK term), KO `0` (`Rabbit.cs:29671`).
* **Piercing beam, not a single-target shot:** `Physics.SphereCastAll(firePos, 1, fireDir, 36, hitLayer)` (`Rabbit.cs:29638`) collects every collider along a 36m, 1m-radius line, and the hit-processing `while` loop that follows never `break`s after a successful hit (`Rabbit.cs:29666-29726`) — it increments and keeps going. Every enemy pierced by the beam is hit, damaged, petrified, and grants the caster `+1 SP`, not just the first target struck.
* **Status:** `"petrify"` applied per pierced target, duration `Damage.getDebuff(sLv*3+3, caster.cha, target.cha)` (`Rabbit.cs:29698`, `[6s, 9s]` base, CHA-contested). Apply-side effect (`CharacterControl.cs:37536-37568`): `deltaDef(-(sLv*20+20))` (DEF −40/−60), cleanses `paralysis`/`sleep`/`snowMan`/`blend`/`invisible`/`mindControl`, sets `actionState = "petrify"` and `moveSpeed = 0` (full stone lock, not merely slowed). Classification: `isDebuffStatus` and `isStateStatus` both true (`StatusData.cs:7454`, `:4932`); **not** in `isLockStatus`'s explicit name list (`groundLock`/`needlePrison`/`sticky`/`frost`/`lightBind` only, `StatusData.cs:6133-6178`) despite the hard movement/action lock — Debuff, State (matches the game's own classification, not the mechanical lock behavior).

### 13. Immune Shot (`immuneShot1`) — active, ally target (verified 2026-09-24)
* **Source:** `Rabbit.cs:6828-6916` (cast dispatch), `Rabbit.cs:28234-28292` (execution) inside `$RPC_medicalShot$27092`
* **Metadata:** reqLv 20, reqBn 12; MP 10, SP 10 (blue threshold); `mode = target`, ally (`RabbitSkill.cs:475-502`).
* **Target Restrictions:** Cannot target self (`num == mChar.ActorNr`, `:6848`), machines (`Race == eRace.Robots`, `:6874`), or structures (`Race == eRace.Structure`, `:6887`).
* **Range & Cooldown:** Range `16 + 5 * getNormalAttackLv()` (21m base at Combo Lv.1, up to 36m at Combo Lv.4, `:28183`). Cooldown `agiAdjust(30)` (`:28570`). Instant cast.
* **Instant Remedy Cleanse:** Cast immediately applies `[remedy]` Lv.1 for 1s on target (`tChar.RPC_AddStatus("remedy", 1, 1, 0, ...)`, `:28282`). `remedy` iterates all statuses on target and calls `reduceStatusLv(sType, 1)` on all non-State, non-System debuffs (`CharacterControl.cs:37397-37485`), reducing each by 1 level (all Lv.1 debuffs are fully cleansed).
* **Status `immunity`:** Target receives `[immunity]` with level `mImmunityLv` and duration `chaAdjust(15 + mLv * 5)` where `mLv = 1 + getMedicalEnhancementLv()` (1–4) (`Rabbit.cs:28287`). Duration: 20s (base), 25s, 30s, 35s. Classification: `isBuffStatus` and `isMagicalStatus` (`StatusData.cs:5705`, `:6668`) — Buff, Magical.
  * **Level Stacking:** Shooting a target with current `immunity` level `< mLv` increments status level by +1 (`mImmunityLv++`); capped at `mLv`.
  * **Mechanics:** While active, `RPC_AddStatus` intercepts any incoming status where `this.getStatusLv("immunity") >= sLv` (`CharacterControl.cs:12671`), displays `-84` (Immune text), and aborts application.
  * **Exemptions:** Does not block `death`, `remedy`, `immunity`, or system statuses (`isSystemStatus`). Does not block direct damage or heals (`RPC_AddHeal`).
* **Multi-Rabbit Stacking Quirk:** In `RPC_AddStatus` (`CharacterControl.cs:14029-14160`), if another Rabbit (`sID != this.sID`) casts on a target already having Lv.4, `sLv` increments to **5**. However, once at Lv.5, subsequent shots with `sLv <= 4` hit line 14159 (`statusClass.sLv > sLv -> return;`), failing to refresh duration until the status expires.

### 14. Boost Shot (`boostShot2`) — active, ally target (verified 2026-09-24)
* **Source:** `Rabbit.cs:6917-7005` (cast dispatch), `Rabbit.cs:28293-28351` (execution) inside `$RPC_medicalShot$27092`
* **Metadata:** reqLv 24, reqBn 15; MP 10, SP 10 (blue threshold); `mode = target`, ally (`RabbitSkill.cs:508-535`).
* **Target Restrictions:** Cannot target self (`:6937`), machines (`:6963`), or structures (`:6976`).
* **Range & Cooldown:** Range `16 + 5 * getNormalAttackLv()`. Cooldown `agiAdjust(30)` (`:28582`). Instant cast.
* **Instant HP Heal:** Heals target immediately for `100 * mBoostLv` HP via `tChar.RPC_AddHeal(251, 100 * mBoostLv, 0, 0, 0, 0, ...)` (`Rabbit.cs:28346`).
  * Lv.1: 100 HP
  * Lv.2: 200 HP
  * Lv.3: 300 HP
  * Lv.4: 400 HP (500 HP if stacked to Lv.5 by a 2nd Rabbit)
* **Status `boost`:** Applies `[boost]` with level `mBoostLv` and duration `chaAdjust(30 + mLv * 5)` (35s, 40s, 45s, 50s) (`Rabbit.cs:28341`). Classification: `isBuffStatus` and `isMagicalStatus` (`StatusData.cs:5729`, `:6716`) — Buff, Magical.
  * **Effect:** Grants `+10 * sLv VIT` (`deltaVit(10 * sLv)`, `CharacterControl.cs:37495`; removed via `deltaVit(-10 * sLv)`, `:16823`).
* **Level Stacking & Multi-Rabbit Stacking:** Identical to Immune Shot and Heat Shot: increases level by 1 on repeated casts up to `mLv` (Lv.4 with Medical Enhancement 3). A 2nd Rabbit escalates to Lv.5 (+50 VIT, 500 HP heal), after which duration cannot be refreshed until expiration.

### 15. Heat Shot (`heatShot3`) — active, ally target (verified 2026-09-24)
* **Source:** `Rabbit.cs:7006-7094` (cast dispatch), `Rabbit.cs:28352-28410` (execution) inside `$RPC_medicalShot$27092`
* **Metadata:** reqLv 28, reqBn 18; MP 10, SP 10 (blue threshold); `mode = target`, ally (`RabbitSkill.cs:541-568`).
* **Target Restrictions:** Cannot target self (`:7026`), machines (`:7052`), or structures (`:7065`).
* **Range & Cooldown:** Range `16 + 5 * getNormalAttackLv()`. Cooldown `agiAdjust(30)` (`:28594`). Instant cast.
* **Instant SP Restore:** Restores `10 * mHeatLv` SP to target immediately via `tChar.RPC_AddHeal(251, 0, 0, 10 * mHeatLv, 0, 0, ...)` (`Rabbit.cs:28405`).
  * Lv.1: 10 SP
  * Lv.2: 20 SP
  * Lv.3: 30 SP
  * Lv.4: 40 SP
* **Status `heat`:** Applies `[heat]` with level `mHeatLv` and duration `chaAdjust(30 + mLv * 5)` (35s, 40s, 45s, 50s) (`Rabbit.cs:28400`). Classification: `isBuffStatus` and `isMagicalStatus` (`StatusData.cs:5735`, `:6722`) — Buff, Magical.
  * **Effect:** Grants `+10 * sLv TAL` (`deltaTal(10 * sLv)`, `CharacterControl.cs:37506`; removed via `deltaTal(-10 * sLv)`, `:16834`).
* **Level Stacking & Multi-Rabbit Stacking:** Level increases by +1 on consecutive shots up to `mLv` (max Lv.4). 2nd Rabbit escalates to Lv.5 (+50 TAL, 40 SP heal), after which duration cannot be refreshed until expiration.

### 16. Life Shot (`lifeShot4`) — active, ally target (verified 2026-09-24)
* **Source:** `Rabbit.cs:7095-7180` (cast dispatch), `Rabbit.cs:28411-28464` (execution) inside `$RPC_medicalShot$27092`
* **Metadata:** reqLv 32, reqBn 21; MP 10, SP 10 (blue threshold); `mode = target`, ally (`RabbitSkill.cs:574-601`).
* **Target Restrictions:** Cannot target self (`:7115`), machines (`:7141`), or structures (`:7154`).
* **Range & Cooldown:** Range `16 + 5 * getNormalAttackLv()`. Cooldown `agiAdjust(30)` (`:28606`). Instant cast.
* **Status `autoLife`:** Target receives `[autoLife]` with level `mAutoLifeLv` and duration `chaAdjust(60 + mLv * 5)` (65s, 70s, 75s, 80s) (`Rabbit.cs:28459`). Classification: `isBuffStatus` and `isMagicalStatus` (`StatusData.cs:5741`, `:6728`) — Buff, Magical.
  * **Heal on Death vs Expiration:**
    - **On Death (ตาย):** Target revives restoring `100 * sLv` HP (50% effectiveness: 100, 200, 300, 400 HP; 500 HP if stacked to Lv.5 by a 2nd Rabbit).
    - **On Duration Expiration (หมดเวลา):** Target heals `200 * sLv` HP (full 2x effectiveness: 200, 400, 600, 800 HP; 1,000 HP at Lv.5) via `RPC_AddHeal(264, 200 * statusClass.sLv, 0, 0, 0, 0, statusClass.sID)` in `StatusUpdate()` (`CharacterControl.cs:10347`).
* **Level Stacking & Multi-Rabbit Stacking:** Increases level by 1 on consecutive shots up to `mLv` (max Lv.4). 2nd Rabbit escalates to Lv.5 (500 HP revive / 1,000 HP expiration heal), after which duration cannot be refreshed until expiration.

### 17. Medical Enhancement (`medicalEnhancement1-3`) — passive (verified 2026-09-24)
* **Source:** `RabbitSkill.cs:2728-2760`, `Rabbit.cs:10381-10420` (`getMedicalEnhancementLv()`)
* **Metadata:** reqLv/Bn 24/15, 27/18, 30/21; MP 0, SP 0; passive (Skills #261, #262, #263).
* **Effect:** Returns rank 1, 2, or 3 based on highest learned tier. Used exclusively by `mLv = 1 + getMedicalEnhancementLv()` in `RPC_medicalShot`:
  * Increases maximum status level cap for Immune Shot, Boost Shot, Heat Shot, and Life Shot from Lv.1 to Lv.2, Lv.3, or Lv.4.
  * Extends status duration by `+5s` per rank (`chaAdjust(base + mLv * 5)`).


### rab_miracleBlend1 — active, single rank
- reqLv 25, reqBn 8, MP 18, SP 0, mode instant/self, `cType miracleBlend` (`decode_skilldata.py`). Cooldown `agiAdjust(60)` (`Rabbit.cs:20363`, dispatcher `:20440`); cast time `magAdjust(5)` (`:20409`, `:20420`).
- **Potions** (`$RPC_miracleBlend_cast`, `Rabbit.cs:25435-26024`): without Miracle Drop, 3 potions 1.5 m from the Rabbit at 0° / 120° / 240°, each a uniform type from 1-4 (`Random.Range(1,5)`, `:25698-25744`). With Miracle Drop (#422 = `rab_miracleDrop5`, `RabbitSkill.cs:3233`; `hasSkill(422)`, `:25603`): 4 potions at 90° steps (`:25614-25673`), each `lckAdjust(5)`% to be type 6 (the golden / miracle potion), otherwise uniform from 1-5 (`Random.Range(1,6)`). Every potion lasts `chaAdjust(60)` (`Rabbit.cs:26353`).
- **Pickup** (`Rabbit_potion.OnTriggerEnter`, `Rabbit_potion.cs:223-450`): the owner's client applies it to a character on the Rabbit's own layer (self and allies). `num` = Alchemist Lab rank (`hasSkill(231-234)` → 1-4, highest wins, none = 0). Type 1 `invisible`, 2 `reduce`, 3 `enlarge`, 4 `poison`, 5 MP heal `clamp(10·num, 10, 40)`, 6 `miracleDrop`. The four statuses and `miracleDrop` all use level `clamp(num,1,4)` and duration `chaAdjust(4 + 2·num)` of the **Rabbit's** CHA (4 s unlearned, 6/8/10/12 s at Lab 1-4). The type-number → status mapping is by prefab (`randomPot1..6`) and is not visible in the code; types 1-4 match the tooltip's four statuses.
- **Probabilities:** per bottle with Miracle Drop = `lckAdjust(5)`% golden; at least one golden in 4 = `1 − (1 − p)^4`. Without Miracle Drop there is no golden potion (types 1-4 only). Both chips are shown on the card.
- **Statuses** (`StatusData.cs`, apply sites in `CharacterControl.cs`): `miracleDrop` (712, Buff + Magical): `damageMod` and `hitMod` each `+0.1·sLv + 0.1` (`:37667`, remove `:16955`). `reduce` (703, Buff + Physical): `damageMod` / `hitMod` `+0.05·sLv`, `rangeMod −0.1·sLv` (`:37215`). `enlarge` (702, Buff + Physical): `damageMod` / `hitMod` `−0.05·sLv`, `rangeMod +0.1·sLv` (`:37295`). `invisible` (603, Buff + Magical, also `isInvisibleStatus`): monster AI vision checks do not acquire an invisible target (`AI_visionCheck`, e.g. `Alpaca_AI.cs:1093-1345`, same pattern in the other monster AI files; blend is treated the same way); `RPC_AddStatus` refuses it while the target has `fireAvatar`, `earthForm`, `cosmicRift` or `cosmicFriday` (`CharacterControl.cs:11274-11335`). `poison` (605, Debuff + Physical) is documented in the mechanics reference §4.
- Client tooltips: EN "Randomly mix up three random potions that give 'invisible1', 'enlarge1', 'shrink1' or 'poison1' status for 4 seconds." / TH "สุ่มเสก ยาหายตัว ยาตัวเล็ก ยาขยายร่าง หรือยาพิษ 3 ขวด ลงพื้น (lv.1 potion x3, 4 sec)" (`RabbitSkill_eng.cs:352`, `RabbitSkill_thai.cs`). The tooltip does not mention Miracle Drop's 4th potion or the MP potion.

### Shot range = Combo rank (verified 2026-09-27)

- **No cast-range gate:** `doSkill` aims at the selected target with a flattened direction (`Rabbit.cs:6453-6455`) and starts the shot without checking distance (`:8709`), so the cast works on any locked target (client target lock ≤ 40 m, see [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md) "Target-skill range").
- **The hit is a single raycast** of length `16 + 5 × getNormalAttackLv()` m (`Physics.Raycast`, first collider on the hit layer), where `getNormalAttackLv()` = Combo rank 0-4 (`hasSkill(101-104)`, `Rabbit.cs:9494`): **16 / 21 / 26 / 31 / 36 m**. A target beyond that is out of reach even though the cast went off. The same `mRange` formula is used by:

| Skill | Source |
|---|---|
| Combo (`RPC_nAttack`) | `Rabbit.cs:17581` (ricochet bounce `20 + 5×Combo`, `:17512`) |
| Charge Attack 2 (`RPC_cAttack2`) | `:19392` (`20 + 5×Combo`) |
| From the Above | `:22129` |
| **Maim Shot** | `:23211` (raycast `:23216`) |
| Medical Shot | `:28183` |
| Gil Shot | `:30364` |
| Diamond Shot | `:38258` |

### Shooting kit: Combo, Charge Attack, Hyper Shot, Snipe Mastery, Bouncing Bullet, Dead Shot, Customized Shotgun, From the Above (verified 2026-09-29)

Requirements from `python scripts/decode_skilldata.py DecompiledSource/RabbitSkill.cs`: Combo `nAttack1-4` Lv 1/2/3/4, Charge Attack `cAttack1-3` Lv 4/10/16 (Bn 1/2/3), Hyper Shot Lv 8/16/24/32 (Bn 4/6/8/10), Customized Shotgun Lv 28 (Bn 18/22), Bouncing Bullet Lv 55, Dead Shot Lv 60 (Bn 1), From the Above Lv 70 (Bn 3), Snipe Mastery Lv 75 (Bn 4). All passive, no MP/SP. IDs: Combo 101-104, Charge Attack 111-113, Hyper Shot 131-134, Customized Shotgun 353/354, Bouncing Bullet 401, Dead Shot 411, From the Above 421, Snipe Mastery 431.

**Combo (`RPC_nAttack`)**
- Dispatch (`Rabbit.cs:9042-9087`): `getCustomizedShotgunLv() > 0` starts `RPC_shotgun`, otherwise `RPC_nAttack`.
- Base hit: `hitDmg = (int)(0.5 × ATK)` (`:17409`); with weapon `w_rab59` ("A custom made rifle. Designed for even more rapid shooting.", `WeaponData_eng.cs:3344`) `hitDmg = floor(0.75 × hitDmg)` (`:17414-17420`) and the `nAttack` timeout is `1 s` instead of `1.5 s` (`:17809-17823`).
- Range: one `Physics.Raycast` of `16 + 5 × Combo rank` m (`:17581`), first collider only. KO `1`, hate `0`, `+1 SP` per landed hit (`:17685-17698`).
- Damage goes through `getCritPlus(...)` (`:16471`): weapon `w_rab43`/`w_rab44` +5, `w_rab58` +7; armor `a_all43`/`a_all44` +4, `a_all58` +6; accessory `c_all43`/`c_all44` +3, `c_all58` +5. `Random.Range(0,100) < lckAdjust(sum)` gives `floor(1.8 × raw)` (same shape as Wolf/Bison gear crit). Item names (`WeaponData_eng.cs`, `ArmorData_eng.cs`, `AccessoryData_eng.cs`): `w_rab43`/`w_rab44` supreme commander crossbow (Blue/Red), `w_rab58` champion golden shotgun, `a_all43`/`a_all44`/`a_all58` armor, `c_all43`/`c_all44`/`c_all58` hat; a full Marshal set is `5 + 4 + 3 = 12`, a full Champion set `7 + 6 + 5 = 18`. Modeled on the Combo card since 2026-09-29 as one gear icon (off / Marshal set / Champion set).
- Hyper Shot term: `mDistance = flat(caster - hit point)`. Without Snipe Mastery `mDistance = clamp(mDistance - 16, 0, 40)`; with Snipe Mastery (`hasSkill(431)`) the raw distance is used (`:17651-17662`). `hyper = floor(mDistance × hyperLv)` (`:17679`), added to `hitDmg` before `getCritPlus`.

**Hyper Shot (`hyperShot1-4`, `getHypershotLv`, `Rabbit.cs:9421-9470`)**
- Level 1-4 from `hasSkill(131-134)`; it multiplies distance in metres (tooltip "1/2/3/4 dmg per 1m beyond 16 m", `RabbitSkill_eng.cs:143-176`).
- Read by: Combo (`:17431`, `:17679`), the Bouncing Bullet loop (`:18253`), Charge Attack 2 (`:19416`, `:19513`: `(distance - 16) × lv`, only when `distance > 16`, no 40 m cap), From the Above's air shot (`:22173-22195`, same `(distance - 16) × lv`, distance measured flat from the firing point 12 m above), and the shotgun attack (`:36293-36308`, reversed, see below).
- Snipe Mastery only changes the Combo and ricochet term and the shotgun term; Charge Attack and From the Above ignore it (`hasSkill(431)` appears only at `:17594`, `:17656`, `:18235`, `:18265`, `:36313` in Rabbit's files; `CharacterControl.cs:13467` is Panda's).

**Snipe Mastery (`snipeMastery5`, `hasSkill(431)`)**
- Rifle Combo / ricochet: hyper distance starts from `0 m` with no `-16` offset and no `40 m` cap (`:17656`, `:18235`), so short shots also get `distance × lv`. Also swaps the hit effect to `RPC_snipeShot_hit` (`:17594`).
- Shotgun: `hyper = floor(1.5 × hyper)` when `hyper > 0` (`:36313-36325`).
- **Discrepancy:** the client tooltips promise "+2 levels" (Thai, `RabbitSkill_thai.cs:950`) and "6 damage per 1m" (English, `RabbitSkill_eng.cs:928`, i.e. level 4 + 2). No `+2` exists anywhere in the decompiled Rabbit path: `getHypershotLv()` returns 0-4 only and `mHyperShotLv` is never adjusted by `hasSkill(431)`. The card follows the code; a live test would settle whether a server patched it.

**Bouncing Bullet (`bouncingBullet5`, `hasSkill(401)`)**
- With the passive, `RPC_nAttack` skips the single raycast and enters the ricochet loop (`:17459-17520` then `goto IL_F77`). Path budget `bounceRange = 20 + 5 × Combo` (`:17512`); each segment is `Physics.Raycast(..., bounceRange, layer 1)` against walls (`:18123`), `bounceRange -= segment length` (`:18166`), at most 3 segments (`bounceCount < 3`, `:18076`) and it stops once `bounceRange <= 12` (`:18082`). The direction reflects off the wall normal (`:18370`) and there is a `0.3 s` wait between segments (`:18385`).
- Every segment uses `Physics.RaycastAll` and loops over all colliders with no `break` (`:18197-18345`): each target on the segment is hit, not only the first (`:18259`, `hit(1, ..., getCritPlus((int)(hitDmg + 0.5 × Lv + hyper)), 1, 0, ...)`).
- **Damage: `+0.5 × character Lv` flat per hit** (`Lv` is `mChar.Lv`, `:18259`), added to `hitDmg`. The client tooltip (`RabbitSkill_thai.cs:913`, "+50% per rabbit level") reads as a percentage; the code is a flat `0.5` per character level (Lv 100 = +50).
- `+1 SP` per landed hit (`:18314`). The "Bouncing Bullet" message appears only after a real ricochet (`bounceCount > 1`, `:18331-18337`).

**Charge Attack (`RPC_cAttack1/2/0`)**
- `cAttack1` starts aiming with the sniper camera (needs `hasSkill(111)`, `:9204-9234`), `cAttack2` fires on release (`:9285-9322`), `cAttack0` cancels (`:9330`). Level = `getChargeAttackLv()` from `hasSkill(111-113)` (`:9547-9570`).
- Ray length `20 + 5 × Combo` (`:19392`). Damage (`:19413-19520`): `chargeDmg = (int)(0.3 × lv × ATK)`; head zone (`hit.point.y - collider.bounds.center.y > 0.5 × bounds.extents.y`, `:19434`) adds `headShotDmg = (int)(0.3 × lv × ATK)`; `dmg = floor(deadShot × (0.5 × ATK + chargeDmg + headShotDmg) + hyper)`. KO `2 × lv` (`:19523`), `+1 SP` on hit.
- So body shot = `0.5 + 0.3×lv` × ATK and head shot = `0.5 + 0.6×lv` × ATK, i.e. the tooltip's "+60~120% × lv" relative to the `0.5 ATK` base.
- Crosshair range readout uses `25/30/35/40 m` per Combo rank (`Rabbit_sniperCamera.cs:121-163`, display only).

**Dead Shot (`deadShot5`, `hasSkill(411)`)**
- Lives inside the head-zone branch only (`:19434-19486`, nesting checked). `Rabbit_sniperCamera.cs:335-452` starts `mDeadShotTimer = Time.time` when the crosshair is on a head zone and resets it to 0 otherwise. Multiplier `1 + 0.5 × clamp(t, 0, 4)` (`:19486`): x1 to x3 at 4 s (tooltip "max 4 sec, 300%" = final multiplier x3). It multiplies `(0.5 ATK + chargeDmg + headShotDmg)`, not the Hyper Shot term. A "Dead Shot!" message shows when the multiplier is above 1 (`:19529-19535`).

**Customized Shotgun (`customizedShotgun1-2`, `RPC_shotgun`, `getCustomizedShotgunLv`)**
- Level 1/2 needs `isShotgun()` (weapon check, `Rabbit.cs:11136`) plus `hasSkill(353)`/`(354)` (`:11087-11131`). Replaces Combo with an area attack. `isShotgun()` accepts only `w_rab22`, `24`, `32`, `34`, `39`, `47`, `48`, `50`, `51`, `52`, `55` and `69`; the champion "golden shotgun" `w_rab58`, the crossbows `w_rab43`/`44` and the custom rifle `w_rab59` are not in it, so they always use the rifle Combo.
- Hit box: `Damage.FindRecTarget(pos + forward, forward, (0.5×sLv + 0.5)×rangeMod, (sLv + 2)×rangeMod, 12×rangeMod, 4×rangeMod)` (`:36270`): a trapezoid 12 m long, base half-width 1.0 / 1.5 m widening to 3 / 4 m, 4 m high. The tooltip says "2m / 4m cone" (`RabbitSkill_thai.cs:829`, `:840`); only rank 2's far half-width matches.
- **Crit order differs from the rifle:** the crit wraps only the base (`hitDmg = getCritPlus((int)(0.5 × ATK))`), Hyper Shot is added after it, whereas rifle Combo, the ricochet and From the Above wrap `hitDmg + hyper` together. Damage `hitDmg = getCritPlus((int)(0.5 × ATK))` for every target, `hit(350 + sLv, ..., hitDmg + hyper, 1, 0, ...)`, KO 1 (`:36260-36332`). One `+1 SP` per cast if anything was hit (`:36386-36394`).
- Hyper Shot is reversed: `distance = clamp(16 - flat distance, 0, 16)`, `hyper = (int)(distance × hyperLv)`, x1.5 with Snipe Mastery (`:36298-36325`): the closer the target, the larger the bonus, up to `16 × lv`.

**From the Above (`fromTheAbove5`, `hasSkill(421)`)**
- Lets Rabbit use the normal attack while Bounce is airborne (`:8944` blocks it without the passive). Air shot (`:22100-22260`): fired from `position + 12 m up` downward, `hit(1, ..., getCritPlus((int)(0.5 × ATK + hyper)), 1, ...)`, range `16 + 5 × Combo`, and it re-arms Bounce's cooldown to `agiAdjust(36)` (`:22250`, see the Bounce judgment call above).
- Landing stomp (`:21608`, `:21629-21652`): `FindAreaTarget(position, 3 × rangeMod, 3)` then `hit(421, target, ATK, 20, 0, ...)`: **1.0 × ATK, KO 20**, radius 3 m (x rangeMod), height 3. This is the Bounce card's damage; the old card entry (`0.5 ATK`, KO `1 + 20`) merged the air shot into it.
- The `hasSkill(421)` debuff-time reduction at `CharacterControl.cs:13421` sits in Wolf's block (`Type == "Wolf"`, `:13379`), not Rabbit.

**Resource-cost audit (2026-09-29):** the summary table's older costs for these skills disagreed with `decode_skilldata.py`, which simulates `getSkill()`'s fall-through: Bounce SP `5 / 8`, Sticky Gum MP `6 / 10` SP `10 / 10`, Acidic Field MP `8 / 12` SP `15 / 15`, Gorgon Shot MP `20 / 30` SP `35 / 50`, Four Shot SP `12 / 15` (no MP), Circle Shot SP `24 / 27` (no MP), Shooting Array SP `24 / 30`, Mall no MP/SP, Truce Trading MP `20 / 30` (no SP). The card costs and the summary table now follow the decode.

### Economy, mercenary and utility skills: Bunny Bargain, Skill Bargain, Special Deal, Med Research, Contract, New Order, Truce Trading, Mall, Shake (verified 2026-09-29)

Requirements (decode): Bunny Bargain Lv 5/11/17/23 (Bn 1/3/5/7), Special Deal Lv 24/27/30/33 (Bn 15/18/21/24), Skill Bargain Lv 60 (Bn 1), Med Research Lv 75 (Bn 4), New Order Lv 85 (Bn 6), Contract Lv 75 (Bn 4; MP 50, SP 30 red), Mall Lv 16/20 (Bn 4/8; MP 0, SP 0), Truce Trading Lv 24/28 (Bn 12/16; MP 20/30, SP 0; target enemy), Shake Lv 7/13/19 (MP 6/10/14). IDs: Bunny Bargain 311-314, Special Deal 361-364, Mall 341/342, Truce Trading 343/344, Skill Bargain 413, Med Research 432, Contract 434, New Order 444.

**Bunny Bargain (`bunnyBargain1-4`, `ShopGui.cs`, `ArenaShopGui.cs`)**
- Level = number of Bunny Bargain ranks learned (`hasSkill(311)`..`(314)` each `+1`, so 0-4), only for `Type == "Rabbit"` (`ShopGui.cs:2164-2227`, `ArenaShopGui.cs:930-972`). Skill Bargain (`hasSkill(413)`) adds a further `+1` in `ShopGui` (`:2221-2227`) but is not counted in `ArenaShopGui`.
- Buy price: `floor((1 - 0.05 × lv) × price)` for every shop except the Panther shop, price above 0 (`ShopGui.cs:2251-2269`; Arena shop `ArenaShopGui.cs:1010`). Sell price: `ceil(price × (0.3 + 0.015 × lv))` (`ShopGui.cs:4080`): the base sale value is 30% of the item price and each level adds 1.5 points (= +5% of that base), matching the tooltip's "5% discount and 5% bonus" per level, 25% at level 5.

**Skill Bargain (`skillBargain5`, `hasSkill(413)`)**
- Millionaire fee `sLv × 250` becomes `floor(0.6 × fee)` (`Rabbit.cs:36880-36891`). Extravagance fee `clamp(floor(0.01 × Gil), 1, 512)` becomes `floor(0.6 × fee)` (`:40056-40068`). Contract fee ×0.6 floor, both the affordability check (`:7677-7683`) and the payment (`:11671-11677`).
- **Gil Shot** and **Diamond Shot** read the Bunny Bargain ranks only when Skill Bargain is owned (the `hasSkill(311-314)` checks are nested inside `hasSkill(413)`, tab depth checked): Gil Shot pays `max(0, Gil - ceil(sLv × (1 - 0.2 × pennySaverLv)))`, `pennySaverLv` = Bunny ranks learned 0-4 (`:30654-30714`); Diamond Shot pays `1000 - 100 × (Bunny ranks learned)` (`:38472-38532`). So "-40%" is only the Bunny 4 + Skill Bargain case for Diamond Shot; Gil Shot's limit is 80% off (cost `ceil(sLv × 0.2)`).
- Discount to shop prices: see Bunny Bargain (+1 level, 25% at most). Tooltip: "Increases BunnyBargain's discount and bonus to 25%. Also reduces money used in Rabbit's skills by 40%" (`RabbitSkill_eng.cs`).

**Special Deal (`specialDeal1-4`, `hasSkill(361-364)`)**
- Tooltip: +5/10/15/20% money and EXP from missions for all party members. **Not found in the decompiled client** after searching every `*.cs` for `specialDeal` (only `RabbitSkill*.cs`), and every `hasSkill(361-364)` hit (Bat, Bison, Mole, Monkey, Wolf, Sheep's Karma at `CharacterControl.cs:30462`, shadow AI files) belongs to another class. Mission reward code (`MissionGui.cs`, `MissionData.cs`, `MissionClass.cs`, `Game.cs`) has no skill check. The reward is either applied server-side or not implemented; the card states the tooltip and flags it.

**Med Research (`medResearch5`, `hasSkill(432)`)**
- Alchemist Lab level 5 in town (`CompoundGui.cs:1137`, `:1775`): `AlchemistData.getRecipe(5)` adds four recipes `f_ahb1`, `f_amb1`, `f_asb1`, `f_akb1` to the level-4 list (16 recipes at Lab 4: `f_hpb1-3`, `f_mpb1-3`, `f_spb1-3`, `f_slb1-3`, `f_kob1`, `f_htb1`, `f_rmb1`, `f_stb1`; Lab 1 has 4, Lab 2 has 8, Lab 3 has 12, Lab 5 has 20; `AlchemistData.cs:20-155`).
- Rabbit's lab items (`FieldData.cs:3320`, `cType "drug"`) use a `75 s` shared cooldown instead of `150 s` when the user is a Rabbit with Med Research (`GameGui.cs:32665-32694`). The `potion` (150 s) and `boost` (180 s) item types are unchanged, so the tooltip's "all Rabbit-type items" means the lab drugs. `CharacterControl.cs:8951` (`gobble` status) also reads `hasSkill(432)` but belongs to another class's passive.

**Contract (`contract5`, `RPC_contract`, `hasSkill(434)`)**
- Contract level is picked from current SP **after** the skill's 30 SP is paid (`returnMPSP` refunds it on failure, `Rabbit.cs:8808`): level 1 by default, level 2 at SP >= 35, level 3 at SP >= 65 (`:7602-7631`). Cast time `magAdjust(3 + 3 × level)` = 6 / 9 / 12 s (`:40729`).
- Level 1 summons 2 `LightPanther`, level 2 summons 2 `LightLeopard`, level 3 summons 1 `LightGolem` (`:40376-40475`, `RPC_contract_create` `:11566-11611`). Each spawned unit costs `200 / 600 / 6000` Gil (`:11635-11683`), so the total is `400 / 1200 / 6000` Gil, the same as the affordability check (`:7641-7671`), each ×0.6 (floor) with Skill Bargain. Casting is refused with "Too many contracts!" when `getContractCount() > 6` (`:7689`) and with "not enough money!" when Gil is short (`:7702`).
- Units live 300 s (Light* `Awake()`, see the Duration citations above). The pre-arm `addTimeOut("contract", agiAdjust(180))` in `Start()` (`:105`) runs unconditionally in real game modes (`Game.mGameType > 4`); the `hasSkill(444)` check after it only guards `Game.useCoin = false` (`:114-120`), so the older note that the pre-arm is "gated by `hasSkill(444)`" was wrong.
- **Coins:** with Contract, using an NPC coin item has a `Random.Range(0,100) <= lckAdjust(30)` chance to not consume the coin (`GameGui.cs:36812-36835`); the tooltip says 50%. Using a coin always costs 5 game mana (`Game.mGameMana >= 5`, `:36735-36835`) and needs `|coin.lv| <= PlayerData.Rank`.

**New Order (`newOrder5`, `hasSkill(444)`)**
- Every summon a Rabbit owner spawns gets `floor(1.5 ×)` on `hp, mhp, mp, mmp, atk, def, agi, vit, mag, cha, tal, lck` (Contract units, `Rabbit.cs:11798-11837`; generic summon event `CharacterControl.cs:29517-29584`).
- Coin items: a coin whose `lv <= ceil(0.5 × PlayerData.Rank)` is used without being consumed (mana still costs 5, `GameGui.cs:36780-36803`). The Thai tooltip adds "use new coins when Rabbit returns to the scene" (not traced).

**Truce Trading (`truceTrading1-2`, `RPC_truceTrading1`)**
- Both ranks cast for `magAdjust(12)` seconds with a cast bar (one assignment, `Rabbit.cs:34425-34437`), not `6 / 12`; MP `20 / 30` (decode). The attempt succeeds when `LCK × sLv > Random.Range(0, target.hp)` (`:34105-34111`, needs `!target.isTraded`), i.e. the chance is `min(1, LCK × rank / target HP)`. On success it fires `RPC_truceTrading_fire<rank>` (`:34123`).
- The purchase itself (item, 150% / 100% price) is not in the client: `truceTrading` appears only in `Rabbit*.cs`, `RabbitSkill*.cs` and the client tooltips (English: rank 1 "150% price and 15% success", rank 2 "100% price and 20% success"; Thai: "real price, 10% / 20%", `RabbitSkill_thai.cs`). The two languages disagree and neither number is in the code. **Resolves the earlier table conflict:** Truce Trading is a negotiation to buy an item from a non-player target, not an invulnerable trading zone (no status or invulnerability code exists for it).

**Mall (`mall1-2`, `RPC_mall_setup` / `RPC_mall_open`)**
- MP 0, SP 0 (decode), cooldown 90 s. Opens a shop object (`Rabbit_mall.cs`, `Init(owner, ownerID, sellerID)`) that other players click within 2 m (`sqrMagnitude <= 4`, `:194`) to buy through `MallGui` (`Rabbit.cs:5626-5644`, `MallGui.cs:4885-4960`). `MallGui` holds 8 item slots (`while (i < 8)`, `MallGui.cs:1126`, `:4594`). No rank check for the tooltip's 4 / 8 sellable items was found in `Rabbit.cs`, `Rabbit_mall.cs`, `MallGui.cs` or `CharacterControl.cs`; `hasSkill(341-343)` at `CharacterControl.cs:4206-4251` is Bison's block (`Type == "Bison"`, `:4011`).

**Shake (`shake1-3`)**
- SP potion amounts are `4 / 8 / 12` SP per bottle for ranks 1-3 (`Rabbit_potion.cs:342-366`), 3 bottles, matching the card; the HP potions of Mix are `20 / 40 / 60 / 80 + floor(0.3 × ExtraPotion × Lv)` (`:294-330`).

**Extravagance (`extravagance5`)** — Lv 85 (Bn 6), MP 20, SP 40 red, cooldown `agiAdjust(120)`. The fee is `clamp(floor(0.01 × Gil), 1, 512)` (`Rabbit.cs:40056`); the ATK bonus value is copied from the fee **before** Skill Bargain applies its `floor(0.6 × fee)` (`:40059` copies, `:40068` discounts), so with Skill Bargain the caster still gets the full `+fee ATK` while paying 60% of it. The bonus is `RPC_AddStatus("atkUp", 5, chaAdjust(6), value)` (`:39902`), applied as `deltaAtk(sValue)` (`CharacterControl.cs:33180`, removed at `:14695`), i.e. a flat `+value ATK` for `chaAdjust(6)` seconds.

**Sticky Gum (`stickyGum1-2`) status `sticky`** — apply side `moveMod -= 0.8` regardless of level (`CharacterControl.cs:37375-37379`, remove `:16801`); `StatusData.cs` lists `sticky` in `isDebuffStatus` (`:7442`), `isPhysicalStatus` (`:5505`) and `isLockStatus` (`:6154`): Debuff, Physical, Lock.

**Stat Scan (`statScan1`)** — Lv 22 (Bn 4), SP 6 red, `target` mode, cooldown `agiAdjust(30)` (`Rabbit.cs:22746`). The caster's client posts three `eChatMode.area` chat lines about the target (`Rabbit.cs:22590-22675`): `statScan@ <Name> weigth:<weight>`, then `atk def agi vit`, then `mag cha tal lck`. It shows no HP, level or status.

**Rapid Trance (`rapidTrance1`)** — with the `rapidTrance` status, `doSkill` skips `RPC_cast1` (the mixing cast bar and the cooldown assignment) for Miracle Blend (`Rabbit.cs:6737`), Healing Field (`:7422`), Acidic Field (`:8481`), Sticky Gum (`:8530`), Shake (`:8585`) and Mix (`:8635`), the `_cast` coroutines of Mix, Shake, Miracle Blend, Sticky Gum and Acidic Field switch voice lines (`:24001`, `:24878`, `:25792`, `:26698`, `:27200`) and `RPC_medicalShot` takes its no-cooldown branch (`:27617`, `:28548`). Covers Mix, Shake, Miracle Blend, Sticky Gum, Acidic Field, Healing Field and the four medical shots. `RPC_healingField_cast` has no `rapidTrance` check of its own.

### Multi-hit geometry: Four Shot, Ten Shot, Circle Shot, Shooting Array (verified 2026-09-29)

Hit counts per **target**, checked by listing every `hit()` call, its `Find*Target` and the state machine that drives it. The tooltips ("15 dmg x 4", "60 dmg x 10") count shots, not hits on one target.

- **Four Shot (`fourShot1-2`)** — `RPC_fourShot` runs four states, each firing in one direction: forward, backward, left, right (`fireDir` at `Rabbit.cs:32251`, `:32268`, `:32285`, `:32302`), waiting `0.3-0.4 s` between shots (`:32436-32442`). Every shot is one `Damage.FindAngleTarget(position, fireDir, 24 × rangeMod, 70, 2 × rangeMod)` (`:32355`); `TargetAngle` is halved inside (`Damage.cs:1232`), so each cone is **70° wide** (35° each side), **24 m** long, **2 m** high. The four cones are 90° apart and never overlap (20° gaps), so **one target takes at most 1 hit** (0 in a gap). `hit(320 + sLv, ..., (int)(0.5 × ATK + talAdjust(15 × sLv + 10 × TenShot)), 1, ...)` (`:32374`), KO 1. The old card `hitCount` of 4 was the shot count.
- **Ten Shot (`tenShot5`)** — five states (`switch` on `i`, `:39262`), each with two launchers firing one cone apiece: `+45°/-45°`, `-135°/+135°`, `+90°/-90°`, `-180°/+180°` and `0°/0°` relative to the facing (`:39286-39419`), waiting `0.1-0.2 s` between volleys. Each cone is `FindAngleTarget(position, dir, 24, 70, 3)` (`:39477-39480`, no `rangeMod`), 10 cones in total, `hit(433, ..., (int)(0.5 × ATK + talAdjust(60)), 1, ...)` (`:39499`, `:39552`). Because the forward pair and the backward pair fire the same direction twice, hits on one target by its angle `θ` from the facing: `|θ|` 0-10° = 2, 10-35° = 3, 35-55° = 1, 55-80° = 2, 80-100° = 1, 100-125° = 2, 125-145° = 1, 145-170° = 3, 170-180° = 2 (average about 2 hits over all angles). The old card `hitCount` of 10 was the shot count.
- **Circle Shot (`circleShot1-2`)** — 3 pulses, each `FindAreaTarget(position, 8 × rangeMod, 3)` (`:32727`), `0.133 s` apart (`:33141`), so **3 hits on every target within 8 m** (height 3 m). `hit(332 + sLv, ...)`, KO 1 (`:32755`).
- **Shooting Array (`shootingArray1-2`)** — a `target`-mode skill: the centre is the selected target's position (`tPos = tObject.transform.position`, `:35754`). Three hits of `0.5 × ATK + talAdjust(15 × sLv)` (`:35331`, `:35459`, `:35527`) then a finisher `ATK + talAdjust(30 × sLv)` (`:35630`), each on `FindAreaTarget(tPos, 6 × rangeMod, 3)` (`:35308`, `:35436`, `:35504`, `:35607`): **4 hits on every enemy within 6 m of the selected target**. KO 1.
- **Millionaire (`millionaire1-2`)** — 6 pulses on `FindAreaTarget(position, 8 × rangeMod, 3)` (`:37189`), waits `0.7 - 0.1 × floor(i/5)` s (`:37266`); tooltip says "half of Rabbit's money" but the code is `ceil(0.005 × sLv × min(Gil + Jil, 99999))` (`:37212`).

### Card `desc` provenance and open questions (updated 2026-09-29)

Every Rabbit card description was first written from the client tooltips, then traced in source in three passes (shooting kit, economy and mercenary skills, multi-hit geometry; see the sections above). Basis per skill now:
- **Source-verified with citations in this file:** Combo, Charge Attack, Hyper Shot, Snipe Mastery, Bouncing Bullet, Dead Shot, Customized Shotgun, From the Above, Bounce, Stat Scan, Maim Shot, Knee Shot, Mix, Extra Potion, Shake, Miracle Blend, Miracle Drop, Alchemist Lab, Sticky Gum, Acidic Field, Healing Field, Immune / Boost / Heat / Life Shot, Medical Enhancement, Rapid Trance, Gorgon Shot, Gil Shot, Diamond Shot, Bunny Bargain, Skill Bargain, Herb Finder, Backpack, Big Bag, Four / Circle / Ten Shot, Shooting Array, Millionaire, Extravagance, Contract, New Order, Med Research, Truce Trading (client-side roll only) and Mall (client-side only). Resource costs of every skill were re-checked against `decode_skilldata.py`.
- **Open questions (not resolvable from the decompiled client):**
  1. **Special Deal** (+5/10/15/20% mission money and EXP): no reader in any `*.cs` file, see the economy section. The card shows the tooltip and says so.
  2. **Snipe Mastery "+2 Hyper Shot levels" / "6 damage per metre"** (tooltips): not in the code; the code only removes the 16 m offset and 40 m cap and gives the shotgun bonus x1.5. A live test would show whether a server changed it.
  3. **Mall item slots 4 / 8** (tooltip): no rank-gated limit found in the client (`MallGui` has 8 slots).
  4. **Truce Trading price (150% / 100%) and the fixed 15% / 20% (English) or 10% / 20% (Thai) success rates**: the purchase is not in the client; only the `LCK × rank > Random(0, target HP)` roll is.
  5. **Contract, 50% no-coin-loss** (tooltip) versus code `lckAdjust(30)` with `<=`: the card follows the code.
- **Modeled on the Combo and Charge Attack cards since 2026-09-29 (`rawModel`, see GEMINI.md):** `w_rab59` (x0.75 damage), gear crit (Combo only; Charge Attack has no `getCritPlus`), the Hyper Shot distance input (rifle, Bouncing Bullet path, shotgun reversed, Charge Attack), Snipe Mastery, Bouncing Bullet, Customized Shotgun mode, the Charge Attack head-shot toggle and the Dead Shot aim-time slider, and Extravagance as a skill dependency (`+ATK` input, cap 512) on the nine ATK-based offensive skills (Combo, Charge Attack, Maim Shot, Bounce, Gil Shot, Four / Circle / Ten Shot, Shooting Array).
- **Not modeled on the cards (verified findings with no card field):** From the Above's air shot (same Hyper Shot rule, not a separate card mode); a single target being hit by several ricochet segments of Bouncing Bullet (needs wall geometry); the `w_rab59` faster attack as damage per second; Ten Shot per-angle hit count; Bunny Bargain in `ArenaShopGui` ignoring Skill Bargain; the unresolved meaning of `Game.useCoin = false` under New Order (`Rabbit.cs:114-120`); Alchemist Lab recipe lists per level; Contract unit stats (Light Panther / Leopard / Golem base stats are not decoded).
- **Resolved 2026-09-29:** Truce Trading is a purchase negotiation (see the economy section above); the old "invulnerable trading zone" table row was wrong.
