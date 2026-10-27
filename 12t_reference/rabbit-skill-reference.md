# Rabbit — Skill Cooldown/Duration Reference

> **Scope (2026-10-25):** this file documents the original BB client (`DecompiledSource/`); a citation without a tag is BB. ToT and TTO changes are live changes reported by the user and sit in the `## Server Balance Variations` sections. The Reborn client has its own file: [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) (Reborn citations are tagged `Reborn:`).

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
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
  rank rather than only CHA/LCK — see `12t_projects/bible/index.html`'s `dep` field on
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
  (`12t_projects/bible/index.html`): `rawAtRank(R) = duration + perRank*(R - minRank)`,
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
- **`bounce` keeps Rabbit airborne for a fixed 4s (Rank 1) / 8s (Rank 2)** (`Rabbit.cs:21068-21073`). The `hide` status itself is set to `4×sLv + 1` (5 / 9 s), but `mBounceTimer = Time.time + 4×sLv` (`:21073`) triggers `RPC_bounce0` (landing, `:21114`), and landing calls `removeStatus("hide")` (`:21566`), so the effective duration is 4 / 8 s. **Tooltip mismatch (found 2026-10-03):** TH "(5 sec)" / "(10 sec)" (`RabbitSkill_thai.cs:114`, `:125`); card `tooltipNote`. Status call:
  `this.$self_$26924.mChar.StartCoroutine_Auto(this.$self_$26924.mChar.addStatus("hide", 1, 4 * this.$sLv$26923 + 1, 0, this.$self_$26924.mChar.ActorNr));` (`hide` = Buff, System; what it does: Mechanics Reference §4.2)
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
- `heatShot` stat gain / level stacking: `Rabbit.cs:28375-28399` — `mHeatLv = tChar.getStatusLv("heat"); if (mHeatLv < mLv) mHeatLv++; else mHeatLv = mLv;` with `mLv = 1 + getMedicalEnhancementLv()` (`Rabbit.cs:28224`). Status effect: `CharacterControl.cs:37506` `deltaTal(10 * sLv)` on apply, reversed at `CharacterControl.cs:16834` `deltaTal(-10 * sLv)`. Cast-time SP: `Rabbit.cs:28405` `RPC_AddHeal(251, 0, 0, 10 * mHeatLv, 0, 0, ...)` (`nSp` is the 4th argument, `CharacterControl.cs:7130`). Classification: `StatusData.cs:6722` (`isBuffStatus`) and `:5735` (`isMagicalStatus`) → Buff, Magical. No other source reads `"heat"` (no burn/fire effect). Client tooltip (`RabbitSkill_eng.cs:473`) says "+10 tal, 30 seconds" — it omits the stacking and the 35s base. The Thai tooltips say the same (Immune 15 s, Boost / Heat 30 s, Life Shot no duration, `RabbitSkill_thai.cs:473-516`; the Reborn Thai text is identical), so all four shot cards carry a `tooltipNote` for the duration and the per-shot level stacking (2026-10-26). The `medicalEnhancement` tooltips (`RabbitSkill_eng.cs:499-521`) say 40/50/60s, but the code adds +5s per rank (40/45/50s for heat) — unresolved discrepancy; live observation takes precedence.
- `heatShot` cross-caster over-cap: a second Rabbit whose cap equals the target's current level bumps it to `cap + 1` (empirically heat4 → heat5 with two Medical Enhancement 3 Rabbits), and shots then stop refreshing the duration because `RPC_AddStatus` drops any application below the existing level — generic rule documented in [12Tails-Mechanics-Reference.md §4.2.1](12t_reference/12Tails-Mechanics-Reference.md#421-re-applying-an-already-active-status--level-merge-rule-charactercontrolcs14017-14160-inside-rpc_addstatus) (`CharacterControl.cs:14115-14159`).
- `heatShot` Duration: `Rabbit.cs:28400` — `this.$tChar$27103.RPC_AddStatus("heat", this.$mHeatLv$27108, this.$self_$27115.mChar.chaAdjust(30 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(35)`
- `lifeShot` Duration: `Rabbit.cs:28459` — `this.$tChar$27103.RPC_AddStatus("autoLife", this.$mAutoLifeLv$27109, this.$self_$27115.mChar.chaAdjust(60 + this.$mLv$27104 * 5), 0, ...);` — base = `chaAdjust(65)`
- `miracleBlend` Duration: `Rabbit_potion.cs:432-438` — `characterControl2.RPC_AddStatus("miracleDrop", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 50, this.gbbNPxW0WH);` — `num` is set from `hasSkill(231/232/233/234)` (`rab_alchemistLab1`-`4`, `Rabbit_potion.cs:223-270`), floored to 1 by the `Mathf.Clamp`; base with no `alchemistLab` (`num = 0`) = `chaAdjust(4)`; Lab 1-4 = `chaAdjust(6/8/10/12)`. Verified outside `Rabbit.cs` — see the dedicated judgment-call note above.
- `stickyGum` Duration (field lifetime, not `RPC_AddStatus`): `Rabbit.cs:26621` — `this.$mDuration$27071 = this.$self_$27075.mChar.chaAdjust(12);`, passed into `RPC_stickyGum_create(...)` → `Rabbit_stickyGum.Init(sLv, nLife, ownerID)`, which stores `nLife + Time.time` as the field's own despawn deadline. See the dedicated judgment-call note above.
- `acidicField` Duration (field lifetime): `Rabbit.cs:27128` — `this.$mDuration$27083 = this.$self_$27087.mChar.chaAdjust(12);`, same `Init()`-deadline pattern via `Rabbit_acidicField.cs`.
- `healingField` Duration (field lifetime): `Rabbit.cs:37831` — `this.$mDuration$27360 = this.$self_$27363.mChar.chaAdjust(12);`, same pattern via `Rabbit_healingField.cs`.
- `rapidTrance` Duration: `Rabbit.cs:29119` — `this.$self_$27126.mChar.RPC_AddStatus("rapidTrance", 1, this.$self_$27126.mChar.chaAdjust(12), 0, ...);` (self, not target-contested); the `rapidTrance` status is Buff, State (`StatusData.cs:4926` isStateStatus, `:6734` isBuffStatus; `CharacterControl.cs:12451` keeps it on Rabbit only, `:16848` / `:37520` only tint the model)
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


Companion to `rabbit-skill-reference.md` (cooldown/duration/maxRank — trusted as-is below, not re-derived here except where flagged). This doc backs the rank-selector + damage/heal-formula fields (`maxRank`, per-rank `cd`/`castTime`/`duration` arrays, `dmg`, `dmgDep`/`dmgMultDep`, `atkCoeff`, `hitCount`, `dmgGroups`) added to Rabbit's `SKILLS` entries in `12t_projects/bible/index.html`, 2026-08-25 — the 3rd class built out beyond Penguin (1st) and Mole (2nd). Researched via decompiled source analysis of `DecompiledSource/Rabbit.cs`, `DecompiledSource/RabbitSkill.cs`, `DecompiledSource/RabbitSkill_eng.cs`, and companion files (`Rabbit_potion.cs`, `Rabbit_acidicField.cs`, `Rabbit_healingField.cs`, `Rabbit_stickyGum.cs`). All citations are `file:line` against `DecompiledSource/Rabbit.cs` unless noted.

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

* **KO interactions (verified 2026-10-08, user report; details in [12Tails-Mechanics-Reference.md §4.2.2](12Tails-Mechanics-Reference.md)):** a petrified target takes **no KO damage** (`nKo = 0` for the `petrify` status, `CharacterControl.cs:31062-31068`, and for Effect Damage `:6691-6697`). Petrify can still be applied to a target that is already knocked down (`RPC_AddStatus` has no `"ko"` check); it overwrites `actionState` (no second knock-down animation plays, user live report), and the target **moves and acts normally with the petrify status still on** (movement path not traced).


### 13. Immune Shot (`immuneShot1`) — active, ally target (verified 2026-09-24)
* **Source:** `Rabbit.cs:6828-6916` (cast dispatch), `Rabbit.cs:28234-28292` (execution) inside `$RPC_medicalShot$27092`
* **Metadata:** reqLv 20, reqBn 12; MP 10, SP 10 (blue threshold); `mode = target`, ally (`RabbitSkill.cs:475-502`).
* **Target Restrictions:** Cannot target self (`num == mChar.ActorNr`, `:6848`), machines (`Race == eRace.Robots`, `:6874`), or structures (`Race == eRace.Structure`, `:6887`).
* **Range & Cooldown:** Range `16 + 5 * getNormalAttackLv()` (21m base at Combo Lv.1, up to 36m at Combo Lv.4, `:28183`). Cooldown `agiAdjust(30)` (`:28570`). Instant cast.
* **Instant Remedy Cleanse:** Cast immediately applies `[remedy]` Lv.1 for 1s on target (`tChar.RPC_AddStatus("remedy", 1, 1, 0, ...)`, `:28282`). `remedy` iterates all statuses on target and calls `reduceStatusLv(sType, 1)` on all non-State, non-System debuffs (`CharacterControl.cs:37397-37485`), reducing each by 1 level (all Lv.1 debuffs are fully cleansed).
* **Status `immunity`:** Target receives `[immunity]` with level `mImmunityLv` and duration `chaAdjust(15 + mLv * 5)` where `mLv = 1 + getMedicalEnhancementLv()` (1–4) (`Rabbit.cs:28287`). Duration: 20s (base), 25s, 30s, 35s. **Tooltip mismatch (found 2026-10-03):** TH "immunity1 (15 sec)" (`RabbitSkill_thai.cs:477`); card `tooltipNote`. Classification: `isBuffStatus` and `isMagicalStatus` (`StatusData.cs:5705`, `:6668`) — Buff, Magical.
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
  * Lv.4: 400 HP
  * **Heal level = the caster's own level, never 5 (re-checked 2026-10-26):** the shooter computes `mBoostLv = getStatusLv("boost")`, `+1` only while it is below its own cap `mLv = 1 + Medical Enhancement`, otherwise `= mLv` (`Rabbit.cs:28316-28335`), and heals `100 * mBoostLv` (`:28346`). The Lv.5 bump from a 2nd Rabbit happens later inside the target's `RPC_AddStatus`, so it never reaches the heal: the instant heal is at most `100 × (1 + Medical Enhancement)` = 400 HP, also on a target that already has `[boost5]`. Heat Shot is the same (`mHeatLv`, `:28375-28405`): at most 40 SP. So the card's "100 + 100 × (level before the shot), at most 100 × (1 + ME)" is exact.
* **Status `boost`:** Applies `[boost]` with level `mBoostLv` and duration `chaAdjust(30 + mLv * 5)` (35s, 40s, 45s, 50s) (`Rabbit.cs:28341`). Classification: `isBuffStatus` and `isMagicalStatus` (`StatusData.cs:5729`, `:6716`) — Buff, Magical.
  * **Effect:** Grants `+10 * sLv VIT` (`deltaVit(10 * sLv)`, `CharacterControl.cs:37495`; removed via `deltaVit(-10 * sLv)`, `:16823`).
* **Level Stacking & Multi-Rabbit Stacking:** Identical to Immune Shot and Heat Shot: increases level by 1 on repeated casts up to `mLv` (Lv.4 with Medical Enhancement 3). A 2nd Rabbit escalates to Lv.5 (+50 VIT; the instant heal stays 400 HP, see above), after which duration cannot be refreshed until expiration.

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
  * **Tooltip mismatch (found 2026-10-03):** TH "(lv.2, +10 sec)" / "(lv.3, +10 sec)" / "(lv.4, +10 sec)" (`RabbitSkill_thai.cs:521-543`); the code adds +5 / +10 / +15 s. The levels match. Card `tooltipNote` (ranks 1 and 3).


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
- Damage goes through `getCritPlus(...)` (`:16471`): weapon `w_rab43`/`w_rab44` +5, `w_rab58` +7; armor `a_all43`/`a_all44` +4, `a_all58` +6; accessory `c_all43`/`c_all44` +3, `c_all58` +5. `Random.Range(0,100) < lckAdjust(sum)` gives `floor(1.8 × raw)` (same shape as Wolf/Bison gear crit). Item names (`WeaponData_eng.cs`, `ArmorData_eng.cs`, `AccessoryData_eng.cs`): `w_rab43`/`w_rab44` supreme commander crossbow (Blue/Red), `w_rab58` champion golden shotgun, `a_all43`/`a_all44`/`a_all58` armor, `c_all43`/`c_all44`/`c_all58` hat; a full Marshal set is `5 + 4 + 3 = 12`, a full Champion set `7 + 6 + 5 = 18`. Modeled on the Combo card since 2026-09-29 as two icons: crit weapon (crossbow +5 / golden shotgun +7) and crit equipment armor + hat (+7 / +11), so equipment can be combined with the Gatling Gun.
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
- **Damage: `+0.5 × character Lv` flat per hit** (`Lv` is `mChar.Lv`, `:18259`), added to `hitDmg`. The client tooltip (`RabbitSkill_thai.cs:913`, "dmg อีก 50% ตามระดับเลเวลกระต่าย") means 50% of the rabbit's level, i.e. this same `0.5 × Lv` (Lv 100 = +50): it matches (not a mismatch; corrected 2026-10-27).
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
- **Gil Shot** and **Diamond Shot** read the Bunny Bargain ranks only when Skill Bargain is owned (the `hasSkill(311-314)` checks are nested inside `hasSkill(413)`, tab depth checked): Gil Shot pays `max(0, Gil - ceil(sLv × (1 - 0.2 × pennySaverLv)))`, `pennySaverLv` = Bunny ranks learned 0-4 (`:30654-30714`); Diamond Shot pays `1000 - 100 × (Bunny ranks learned)` (`:38472-38532`). So "-40%" is only the Bunny 4 + Skill Bargain case for Diamond Shot; Gil Shot's cost is rounded up to whole Gil, so rank 1 is never reduced and the floor is 1 Gil (reached only at rank 4 with all four Bunny ranks, at best -75%): 0-4 Bunny ranks cost 1/1/1/1/1, 2/2/2/1/1, 3/3/2/2/1, 4/4/3/2/1 Gil for ranks 1-4.
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

**Contract mercenaries (`lightPanther`, `lightLeopard`, `lightGolem`, verified 2026-10-04)**
- **Stats:** prefab stats, from the `MONSTER_STATS` decode in the Bible; no `Light*.cs` overwrites them.

  | Unit | HP | ATK | DEF | AGI | VIT | MAG | CHA | TAL | LCK | SP |
  |---|---|---|---|---|---|---|---|---|---|---|
  | LightPanther | 1,100 | 112 | 54 | 52 | 110 | 22 | 25 | 32 | 16 | 22 |
  | LightLeopard | 2,400 | 204 | 45 | 43 | 240 | 30 | 49 | 42 | 70 | 20 |
  | LightGolem | 10,000 | 176 | 115 | 65 | 2,000 | 80 | 45 | 88 | 24 | 10 |

- **New Order:** multiplies every stat except SP by 1.5, floored (see New Order below). Every move is a `hit()` from the mercenary's own CharacterControl: its own ATK / TAL / LCK, then `dmgAdjust` / `defAdjust`.
- **AI:** all three target `Hate.findClosestEnemy(pos, 20)`, the closest enemy within 20 m (`LightPantherAI.cs:1031`, `LightLeopardAI.cs:1139`, `LightGolemAI.cs:1027`). With no move in range they run to the target. Lifespan is 300 s (`Light*.cs:44`).
- **`lightPanther_nAttack`** (`LightPanther.cs:1695-1844`):
  - Hits 3 times, at loop steps 3, 6 and 10. Every other step skips the hit (raw guard `if (i != 3) if (i != 6) if (i != 10) goto skip`).
  - Each hit: `FindRecTarget(pos, forward, 1, 1, 3, 2)` (2 m wide, 3 m long, 2 m tall) and `hit(1, (int)(0.5 × ATK), KO 1)`.
  - Cooldown `2.5 + 0.1 × Random.Range(0, 10)` = 2.5–3.4 s.
  - Used when the target is within 3 m (`sqrMagnitude − extents² < 9`, `LightPantherAI.cs:1320`).
- **`lightPanther_javelin`** (`LightPanther.cs:2278`, `Panther_javelin.cs:188`):
  - The spear is thrown on a trajectory at speed 24 toward the target's bounds centre, with a life of `3 × rangeMod` s.
  - On every enemy collider it touches: `hit(11, (int)(0.5 × ATK + talAdjust(20)), KO 5)`. The projectile is not destroyed on a hit, so it pierces. It stops at layer 0 (the ground).
  - Cooldown 12 s. Used when the target is 6–30 m away (`36 < d² < 900`, `LightPantherAI.cs:1276-1282`).
- **`lightLeopard_nAttack`** (`LightLeopard.cs:1524-1656`): one `FindRecTarget(pos, forward, 2, 2, 2, 2)` (4 m wide, 2 m long), `hit(1, ATK, KO 2)`. Cooldown 3 s. Used within 2 m (`d² < 4`).
- **`lightLeopard_leoSmash`** (`LightLeopard.cs:1898-2051`):
  - One `FindRecTarget(pos, forward, 1, 1, 3, 3)` (2 m wide, 3 m long), `hit(1, ATK + talAdjust(20), KO 20)`.
  - Spends `sp − 10` on cast. Cooldown 6 s.
  - Checked before the normal attack, within 2 m and only while `sp > 20` (`LightLeopardAI.cs:1282`).
  - The Leopard starts at SP 20 (New Order does not raise SP). It only gains SP from damage taken (+1 per instance). So it needs one hit before the first Smash, and 10 more before each one after.
- **`lightGolem_nAttack`** (`LightGolem.cs:1326-2247`): one of three picks by `Random.Range(0, 100)` (`LightGolemAI.cs:1189-1213`), used within 3 m. Each is one `hit(1, ATK, KO 1)` per target, and the Golem gets `sp + 1` per target hit.
  - `> 60` (39%), `RPC_nAttack1`: `FindRecTarget(pos − 1 up, forward, 2·rangeMod, 2·rangeMod, 4·rangeMod, 3·rangeMod)`. Cooldown 1 s.
  - `31-60` (30%), `RPC_nAttack2`: the same box at `pos + 1 up`. Cooldown 0.5 s.
  - `0-30` (31%), `RPC_nAttack3`: `FindAreaTarget(pos + 2.5 forward, 2, 3)`. Cooldown 0.5 s.

**New Order (`newOrder5`, `hasSkill(444)`)**
- Every summon a Rabbit owner spawns gets `floor(1.5 ×)` on `hp, mhp, mp, mmp, atk, def, agi, vit, mag, cha, tal, lck` (Contract units, `Rabbit.cs:11798-11837`; generic summon event `CharacterControl.cs:29517-29584`).
- Coin items: the code means a coin whose `lv <= ceil(0.5 × PlayerData.Rank)` to be used without being consumed (mana still costs 5, `GameGui.cs:36780-36803`). **BB bug (verified 2026-10-19):** every NPC coin stores its level as a negative number (`CoinData.cs`: 54 coins, `itemClass.lv = -1 … -40`, e.g. Boldas Coin `-40`), and this check compares the raw value while the Rank check before it uses `Mathf.Abs(lv) > PlayerData.Rank`. So it always passes: a Rabbit with New Order never consumes an NPC coin (card `bbBug` on `newOrder` and on the four coin summon cards, each with the Rank its coin was meant to need: `2 × |lv| − 1` = 49 Dwukphu, 69 Razan, 79 Boldas / Italus). The "mana" is the stage's shared pool `Game.mGameMana` ("Require 5 mana"), not the player's MP, and `PlayerData.Rank` is the account Rank (the value item levels are checked against, `CharacterDataClass.cs:3306`), not the character level. The Thai tooltip adds "use new coins when Rabbit returns to the scene" (not traced).

**Truce Trading (`truceTrading1-2`, `RPC_truceTrading1`)**
- Both ranks cast for `magAdjust(12)` seconds with a cast bar (one assignment, `Rabbit.cs:34425-34437`), not `6 / 12`; MP `20 / 30` (decode). The attempt succeeds when `LCK × sLv > Random.Range(0, target.hp)` (`:34105-34111`, needs `!target.isTraded`), i.e. the chance is `min(1, LCK × rank / target HP)`. On success it fires `RPC_truceTrading_fire<rank>` (`:34123`).
- The purchase itself (item, 150% / 100% price) is not in the client: `truceTrading` appears only in `Rabbit*.cs`, `RabbitSkill*.cs` and the client tooltips (English: rank 1 "150% price and 15% success", rank 2 "100% price and 20% success"; Thai: "real price, 10% / 20%", `RabbitSkill_thai.cs`). The two languages disagree and neither number is in the code. **Resolves the earlier table conflict:** Truce Trading is a negotiation to buy an item from a non-player target, not an invulnerable trading zone (no status or invulnerability code exists for it).

**Mall (`mall1-2`, `RPC_mall_setup` / `RPC_mall_open`)**
- MP 0, SP 0 (decode), cooldown 90 s. Opens a shop object (`Rabbit_mall.cs`, `Init(owner, ownerID, sellerID)`) that other players click within 2 m (`sqrMagnitude <= 4`, `:194`) to buy through `MallGui` (`Rabbit.cs:5626-5644`, `MallGui.cs:4885-4960`). `MallGui` holds 8 item slots (`while (i < 8)`, `MallGui.cs:1126`, `:4594`). No rank check for the tooltip's 4 / 8 sellable items was found in `Rabbit.cs`, `Rabbit_mall.cs`, `MallGui.cs` or `CharacterControl.cs`; `hasSkill(341-343)` at `CharacterControl.cs:4206-4251` is Bison's block (`Type == "Bison"`, `:4011`).

**Shake (`shake1-3`)**
- SP potion amounts are `4 / 8 / 12` SP per bottle for ranks 1-3 (`Rabbit_potion.cs:342-366`), 3 bottles, matching the card; the HP potions of Mix are `20 / 40 / 60 / 80 + floor(0.3 × ExtraPotion × Lv)` (`:294-330`), where `ExtraPotion` is 0 / 1 from `hasSkill(412)` (`:271-277`) and `Lv` is the **Rabbit's** character level (`characterControl.Lv` of the bottle's owner, not the drinker's).
- **Who gets a Mix / Shake bottle (checked 2026-10-26):** the same `Rabbit_potion.OnTriggerEnter` as Miracle Blend: only the Rabbit's own client (`characterControl.isMine`, owner = `PhotonClient.ActorNrList[nOwnerID]`) applies it, to any character whose layer equals the Rabbit's layer (`Rabbit_potion.cs:141-207`, layer stored in `Init` `:67`), so the Rabbit itself and its allies, never an enemy. Reborn changes: see "Mix, Shake, Miracle Blend bottles" in the Reborn section.

**Extravagance (`extravagance5`)** — Lv 85 (Bn 6), MP 20, SP 40 red, cooldown `agiAdjust(120)`. The fee is `clamp(floor(0.01 × Gil), 1, 512)` (`Rabbit.cs:40056`); the ATK bonus value is copied from the fee **before** Skill Bargain applies its `floor(0.6 × fee)` (`:40059` copies, `:40068` discounts), so with Skill Bargain the caster still gets the full `+fee ATK` while paying 60% of it. The bonus is `RPC_AddStatus("atkUp", 5, chaAdjust(6), value)` (`:39902`), applied as `deltaAtk(sValue)` (`CharacterControl.cs:33180`, removed at `:14695`), i.e. a flat `+value ATK` for `chaAdjust(6)` seconds.

**Sticky Gum (`stickyGum1-2`) status `sticky`** — apply side `moveMod -= 0.8` regardless of level (`CharacterControl.cs:37375-37379`, remove `:16801`); `StatusData.cs` lists `sticky` in `isDebuffStatus` (`:7442`), `isPhysicalStatus` (`:5505`) and `isLockStatus` (`:6154`): Debuff, Physical, Lock.

**Stat Scan (`statScan1`)** — Lv 22 (Bn 4), SP 6 red, `target` mode, cooldown `agiAdjust(30)` (`Rabbit.cs:22746`). The caster's client posts three `eChatMode.area` chat lines about the target (`Rabbit.cs:22590-22675`): `statScan@ <Name> weigth:<weight>`, then `atk def agi vit`, then `mag cha tal lck`. It shows no HP, level or status.

**Rapid Trance (`rapidTrance1`)** — with the `rapidTrance` status, `doSkill` skips `RPC_cast1` (the mixing cast bar and the cooldown assignment) for Miracle Blend (`Rabbit.cs:6737`), Healing Field (`:7422`), Acidic Field (`:8481`), Sticky Gum (`:8530`), Shake (`:8585`) and Mix (`:8635`), the `_cast` coroutines of Mix, Shake, Miracle Blend, Sticky Gum and Acidic Field switch voice lines (`:24001`, `:24878`, `:25792`, `:26698`, `:27200`) and `RPC_medicalShot` takes its no-cooldown branch (`:27617`, `:28548`). Covers Mix, Shake, Miracle Blend, Sticky Gum, Acidic Field, Healing Field and the four medical shots. `RPC_healingField_cast` has no `rapidTrance` check of its own.

### NPC coin summons: Dwukphu, Razan, Boldas, Italus (verified 2026-10-19)

Any class can use these coins; the Bible lists them under Rabbit "อื่น ๆ" (user 2026-10-19) because Contract and New Order change them. Cards: `coinDwukphu` + `coinDwukphu_millionaire`, `coinRazan` + `coinRazan_nAttack` / `coinRazan_cAttack`, `coinBoldas` + `coinBoldas_nAttack` / `coinBoldas_leapingLion` / `coinBoldas_ligerSwing` / `coinBoldas_crushingTiger`, `coinItalus` + `coinItalus_pointBlank` / `coinItalus_backDraw` / `coinItalus_bulletRain` / `coinItalus_thousandShot` (summon cards `mercParent`, moves on the NPC's own stats through `ownStatsMerc`, internal ID 444).

**Using a coin (all four)**
- Items: Razan Coin `n_npc15` (lv −35), Dwukphu Coin `n_npc20` (−25), Boldas Coin `n_npc26` (−40), Italus Coin `n_npc27` (−40) (`CoinData.cs:502`, `:612`, `:744`, `:766`); type (prefab) `Crocodile`, `Catfish`, `Liger`, `Falcon` (`CoinData.getType`, `:1040-1410`); icons `GameGui/Icons/Items/Coin/npc15 / 20 / 26 / 27` (`IconButton.cs:469`). Thai tooltips: "เหรียญที่ใช้เพื่อเรียก ช่างตีเหล็กราซาน / คุณดุกฟู / แม่ทัพโบลดาส / อินทรีอิทารุส มาช่วย ใช้ 5 Mana" (`CoinData_th.cs`).
- Checks in order (`GameGui.cs:36600-36835`): `Game.canUseCoin` (mission allows coins), `!Game.useCoin` ("Can only use one coin per stage"), actionState standby / run / emotion, known type, not `getNotDone`, not `CoinData.getMissionNpc(gameCode, type)` (Liger is blocked in missions 303 Snow Pass, 602 Highway Blockade, 802 Boldas Final Test, 936 Crossing Destiny; Falcon in 305 Italus Acceptance, 702 Eastern World Divide, 936; Catfish and Crocodile nowhere, `CoinData.cs:1642-2310`), not already in `Game.useCoinList` (each NPC once per mission), `Mathf.Abs(lv) <= PlayerData.Rank`, `Game.mGameMana >= 5`. Then the Rabbit New Order / Contract no-consume branches (above), else the coin is consumed; mana −5 either way.
- `RPC_useCoin` (each class has a copy; `Rabbit.cs:46724-47010`): stands still (`moveSpeed 0`), sets `Game.useCoin = true`, adds the type to `useCoinList`, a fixed **3 s** cast (`Time.time + 3`, `DisplayCastBar(3)`, not `magAdjust`), then `SummonEvent(type, getSpawnVector(…, TransformDirection(0, −1, 3)), forward)` (3 m ahead).
- `onSummonEvent` (`CharacterControl.cs:29269-29640`): instantiates `Game.getPrefab(type)` (`Resources/GameAssets/Characters/Tails/<Type>/<Type>`, `Game.cs:4888-5130`), `isSummon = true`, `mSummoner` = the caster, and the New Order ×1.5 when the owner is a Rabbit with skill 444.
- **No lifetime:** the only `Destroy` is in each NPC's `RPC_dead`; the unit stays until it dies or the stage ends.
- **Stats** (the Resources prefab rows of `MONSTER_STATS`; no NPC script writes them): Dwukphu HP 1700, ATK 54, DEF 54, AGI 14, VIT 170, MAG 32, CHA 24, TAL 104, LCK 54, SP 10; Razan 5000 / 200 / 100 / 50 / 500 / 40 / 45 / 50 / 45, SP 30; Boldas 6900 / 164 / 112 / 56 / 690 / 32 / 94 / 64 / 48, SP 10; Italus 4500 / 120 / 65 / 200 / 450 / 100 / 100 / 150 / 45, SP 30. Boldas's `mLigerType` decodes to `normal` (0) on the `Liger` prefab, pathID 81033 of `resources.assets`; `mallet` (1) is the separate `Liger_mallet` prefab.
- **AI (every NPC):** with no target and the summoner farther than 6 m it follows him (`*_AI.cs`, `sqrMagnitude > 36`: Catfish_AI `:141`, Crocodile_AI `:137`, Liger_AI `:158`, Falcon_AI `:141`). Vision every 1-2 s: `Hate.findEnemies(pos, 32)`, then a target within 12 m (`sqrMagnitude < 144`) or within 60° of the facing (`Vector3.Angle < 60`) (Catfish_AI `:996`, `:1215`, `:1249`; Crocodile_AI `:1033`, `:1250`, `:1284`; Liger_AI `:1452`, `:1671`, `:1705`). Italus: `findEnemies(pos, 50)` and `sqrMagnitude < 2500`, i.e. 50 m all round (`Falcon_AI.cs:1215`, `:1442`, `:1486`). Ranges below are `distance − target bounds.extents.x`. All cooldowns are fixed `addTimeOut` values (no `agiAdjust`).
- **SP gates (Razan, Italus):** units start at `sp = msp` (`CharacterControl.cs:1135`), gain `sp++` per damage instance taken (`ApplyDamage`, `:2096-2122`), and above `msp` lose 1 about every second once 2 s have passed since the last action while standing or running (`:1945-2017`). The AI never spends SP for these moves (the −45 in `Falcon.cs:1226` is the player-controlled `doBeginCharge` path).
- Hit action codes ≥ 10 (Leaping Lion 11, Bullet Rain / Thousand Shot 10, Back Draw 99) skip the attacker-Blind miss roll (`CharacterControl.cs:3492`); not modelled on the cards.

**Dwukphu (`Catfish`)**
- `coinDwukphu_millionaire` (`Catfish.cs:1170-1421`): used within 3 m (`Catfish_AI.cs:799`). Ring effect at 0.2 s, then two hits 0.5 s apart (0.7 / 1.2 s): `FindAreaTarget(pos, 7, 2)`, `hit(1, talAdjust(300), KO 1)` — TAL only. Cooldown 9 s (`:1379`). Its only move.

**Razan (`Crocodile`)**
- `coinRazan_nAttack` (`Crocodile.cs:1295-1700`): within 2 m, first in the AI order (`Crocodile_AI.cs:797`). Hit 1 at 0.5 s `FindAreaTarget(pos + forward, 2, 3)`, hit 2 at 0.9 s `FindAreaTarget(pos + forward, 3, 3)`, each `hit(1, ATK, KO 3)`. Cooldown 6 s (`:1613`).
- `coinRazan_cAttack` (`Crocodile.cs:1870-2140`): within 3 m and `sp > 35` (`Crocodile_AI.cs:834-857`); one hit at 0.9 s, `FindAreaTarget(pos + forward, 4, 3)`, `hit(1, 3 × ATK, KO 30, force Vector3.up)`. Cooldown 24 s (`:2070`). Razan starts at SP 30, so it needs 6 hits taken first.

**Boldas (`Liger`, normal type)** — AI order (`Liger_AI.cs:1105-1300`): Crushing Tiger (within 6 m, `hp < 0.5 × mhp`), Leaping Lion (4-6 m), Normal Attack (within 3 m), Liger Swing (within 9 m), else run to the target.
- `coinBoldas_nAttack` (`Liger.cs:1604-2372`): speed 14 from 0.7 s, 3 at 0.9 s, stop at 1.0 s, 6 at 1.5 s, stop at 1.7 s. Hits at 0.9 s and 1.5 s `FindRecTarget(pos, forward, 2rm, 2rm, 5rm, 3rm)` (KO 3, then 2) and at 1.7 s `FindAreaTarget(pos, 5rm, 3rm)` (KO 2), all `hit(1, ATK)`. Cooldown 2 s (`:2183`).
- `coinBoldas_leapingLion` (`Liger.cs:2543-2870`): speed 12 for 0.5 s, then one `hit(11, ATK, KO 20)` in `FindRecTarget(pos − 2 × forward, forward, 2, 2, 5, 2)`. Cooldown 9 s (`:2716`).
- `coinBoldas_ligerSwing` (`Liger.cs:2916-3620`): 2 s wind-up, two `FindAreaTarget(pos, 3rm, 3rm)` hits at 2.2 / 2.4 s, then a spin at speed 5 toward the target until 6 s after the start, hitting `FindAreaTarget(pos, 4rm, 3rm)` whenever `actionTime + 0.3 × n + 2 < Time.time` (2.42, 2.44, 2.6 … 5.9 s: 14 hits). All `hit(1, ATK, KO 2)`; up to 16 per target. Cooldown 30 s (`:3488`).
- `coinBoldas_crushingTiger` (`Liger.cs:3690-4250`): self `noForce` for 2 s (`:4102`), hits at 1.8 / 1.9 s, `FindAreaTarget(pos, 16rm, 4rm)`, `hit(1, ATK + talAdjust(45), KO 2, force away from Boldas)`. Cooldown 30 s (`:4067`).

**Italus (`Falcon`)** — AI order (`Falcon_AI.cs:948-1095`): Thousand Shot (within 20 m and `sp > 45`), Bullet Rain (within 16 m, `hp < 0.5 × mhp`), Back Draw (within 6 m), Point Blank (within 18 m); Back Draw and Point Blank share the `nAttack` cooldown.
- `coinItalus_pointBlank` (`Falcon.cs:1477-2016`): four shots at 0.4 / 0.5 / 0.6 / 0.7 s, each `Physics.Raycast(…, 40)` (first collider only), `hit(1, ATK, KO 1)`. Cooldown 2 s (`:1885`). The 0.35 × ATK branch is only for mission 305, where coins cannot call him.
- `coinItalus_backDraw` (`Falcon.cs:2082-2690`): backs off at speed 10 from 0.2 s, fires at 0.6 s: `FindRecTarget(pos, forward, rm, rm, 15rm, 3rm)`, `hit(99, 3 × ATK, KO 1)` (ATK only in mission 305). Cooldown 2 s (`:2552`).
- `coinItalus_bulletRain` (`Falcon.cs:2756-3210`): `hide` on himself (level 1, 1 s) at 1.5 s, then ten hits every 0.15 s (1.5 … 2.85 s), `FindAreaTarget(pos, 16, 6)`, `hit(10, 0.5 × ATK + talAdjust(10), KO 1)`. Cooldown 20 s (`:3017`).
- `coinItalus_thousandShot` (`Falcon.cs:3252-3680`): ten hits every 0.1 s from 0.8 s, `FindRecTarget(pos, forward, 2, 2, 24, 3)`, `hit(10, ATK + talAdjust(30), KO 1)`. Cooldown 30 s (`:3581`). Italus starts at SP 30, so it needs 16 hits taken first.
- Models (range preview): `REACH_MODELS.Dwukphu` / `Razan` / `Italus` from each Resources prefab on the first key of its default clip (Italus with his four `WEP_Italus` pistols, all shown on the prefab); Boldas reuses `REACH_MODELS.Boldas`.

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
- **Former open questions, decided 2026-10-01 (user):**
  1. **Special Deal** (+5/10/15/20% mission money and EXP): searched again (Rabbit files, `CharacterControl.cs`, `Game.cs`, `GameGui.cs`, mission files; #361-364 hooks elsewhere belong to Cat, Bison and Sheep) and still no reader; it is presumably server-side. The card keeps the tooltip value with no disclaimer.
  2. **Snipe Mastery:** the card follows the code (no 16 m offset, no 40 m cap, shotgun bonus x1.5); the tooltip's "+2 Hyper Shot levels" / "6 damage per metre" are not used.
  3. **Mall:** 8 item slots at every rank (`MallGui`); no rank-gated limit.
  4. **Truce Trading:** the success rate is in the code, `mChar.lck × sLv > Random.Range(0, target.hp)` with raw LCK (no `lckAdjust`), checked once when the 12 s channel ends; a target with `isTraded` set is skipped (`Rabbit.cs:34105-34146`; `isTraded` is never set in the client). Only the price is not in the client.
  5. **Contract** no-coin-loss: the card follows the code, `Random.Range(0,100) <= lckAdjust(30)` (`GameGui.cs` coin dispatch, `hasSkill(434)`).
- **Modeled on the Combo and Charge Attack cards since 2026-09-29 (`rawModel`, see GEMINI.md):** `w_rab59` (x0.75 damage), gear crit (Combo only; Charge Attack has no `getCritPlus`), the Hyper Shot distance input (rifle, Bouncing Bullet path, shotgun reversed, Charge Attack), Snipe Mastery, Bouncing Bullet, Customized Shotgun mode, the Charge Attack head-shot toggle and the Dead Shot aim-time slider, and Extravagance as a skill dependency (fixed +512 ATK, the cap) on the nine ATK-based offensive skills (Combo, Charge Attack, Maim Shot, Bounce, Gil Shot, Four / Circle / Ten Shot, Shooting Array).
- **Not modeled on the cards (verified findings with no card field):** From the Above's air shot (same Hyper Shot rule, not a separate card mode); a single target being hit by several ricochet segments of Bouncing Bullet (needs wall geometry); the `w_rab59` faster attack as damage per second; Ten Shot per-angle hit count; Bunny Bargain in `ArenaShopGui` ignoring Skill Bargain; New Order's `Game.useCoin = false` in `Start()` (`Rabbit.cs:114-120`, traced 2026-10-01: `Game.useCoin` is the "one NPC coin per stage" lock, set when a coin is used (`Rabbit.cs:46916`, every class has the same line), checked in the coin dispatch ("Can only use one coin per stage.", `GameGui.cs:36636`) and already cleared by `Game.nextGame()` at every stage change (`Game.cs:295-323`); the Rabbit's own reset only runs when its player object is created in a mission, so in normal play it changes nothing); Alchemist Lab recipe lists per level; Contract unit stats (Light Panther / Leopard / Golem base stats are not decoded).
- **Resolved 2026-09-29:** Truce Trading is a purchase negotiation (see the economy section above); the old "invulnerable trading zone" table row was wrong.

### Geometry notes (verified 2026-10-02)

- **Mix / Shake potions:** `Rabbit + rotateH(1.5 × dir, i × angle)`, angle 120° (72° for 5 Mix potions with Extra Potion) (`Rabbit.cs:23886-23925`, Shake `:24802`): 1.5 m from the Rabbit, evenly spaced.
- **Contract spawn:** Panthers and Leopards at `getSpawnVector(pos + up, TransformDirection(∓1.5, −1, 2.6))`, the Golem at `(0, −1, 3)` (`Rabbit.cs:40423-40464`).
- **Diamond Shot** uses the same `16 + 5 × getNormalAttackLv()` raycast as Maim Shot (`Rabbit.cs:38258-38263`). Truce Trading has no distance gate (40 m target lock).

## Skill Tree Layout & Learn Requirements

Verified 2026-10-12 for the Skill Simulator (rules: [12Tails-Mechanics-Reference.md §3.6](12t_reference/12Tails-Mechanics-Reference.md)). Each cell is `name Lv/points`: required level / skills already learned in the same tree. Cell number = `tree*100 + row*10 + column`. Source: `RabbitSkill.getSkill` (`setReq`, `rSkill`) and `RabbitSkill.getSkillTree`.

**Sharp Shooter** (tree 1)

| Row | Cells |
|---|---|
| 1 | Long Shot 1 1/0 · Long Shot 2 2/0 · Long Shot 3 3/0 · Long Shot 4 4/0 |
| 2 | Aimed Shot 1 4/1 · Aimed Shot 2 10/2 · Aimed Shot 3 16/3 · Stat Scan 22/4 |
| 3 | Bunny Bounce 1 6/2 · Bunny Bounce 2 12/4 · — · — |
| 4 | Hyper Shot 1 8/4 · Hyper Shot 2 16/6 · Hyper Shot 3 24/8 · Hyper Shot 4 32/10 |
| 5 | Stat Plus 1 10/4 · Stat Plus 2 20/6 · Stat Plus 3 30/8 · Stat Plus 4 40/10 |

**Alchemist Doctor** (tree 2)

| Row | Cells |
|---|---|
| 1 | Maim Shot 1 3/0 · Maim Shot 2 9/1 · Maim Shot 3 15/2 · Maim Shot 4 21/3 |
| 2 | Mix 1 5/1 · Mix 2 11/3 · Mix 3 17/5 · Mix 4 23/7 |
| 3 | Shake 1 7/2 · Shake 2 13/4 · Shake 3 19/6 · Miracle Blend 25/8 |
| 4 | Alchemist Lab 1 9/3 · Alchemist Lab 2 15/5 · Alchemist Lab 3 21/7 · Alchemist Lab 4 27/9 |
| 5 | Sticky Gum 1 16/4 · Sticky Gum 2 20/8 · Acidic Field 1 24/12 · Acidic Field 2 28/16 |
| 6 | Immune Shot 20/12 · Boost Shot 24/15 · Heat Shot 28/18 · Life Shot 32/21 |
| 7 | Medical Enhancement 1 24/15 · Medical Enhancement 2 27/18 · Medical Enhancement 3 30/21 · Rapid Trance 33/24 |
| 8 | Gorgon Shot 1 35/23 · Gorgon Shot 2 40/25 · — · — |

**Merchant** (tree 3)

| Row | Cells |
|---|---|
| 1 | Gil Shot 1 3/0 · Gil Shot 2 9/1 · Gil Shot 3 15/2 · Gil Shot 4 21/3 |
| 2 | Bunny Bargain 1 5/1 · Bunny Bargain 2 11/3 · Bunny Bargain 3 17/5 · Bunny Bargain 4 23/7 |
| 3 | Herb Finder 1 7/2 · Backpack 1 13/4 · Herb Finder 2 19/6 · Backpack 2 25/8 |
| 4 | Four Shot 1 9/3 · Four Shot 2 15/5 · Circle Shot 1 21/7 · Circle Shot 2 27/9 |
| 5 | Mall 1 16/4 · Mall 2 20/8 · Truce Trading & Co. 1 24/12 · Truce Trading & Co. 2 28/16 |
| 6 | Shooting Array 1 20/12 · Shooting Array 2 24/15 · Customized Shotgun 1 28/18 · Customized Shotgun 2 28/22 |
| 7 | Special Deal 1 24/15 · Special Deal 2 27/18 · Special Deal 3 30/21 · Special Deal 4 33/24 |
| 8 | Millionaire 1 35/23 · Millionaire 2 40/25 · — · — |

**Magistrate** (tree 4)

| Row | Cells |
|---|---|
| 1 | Bouncing Bullet 55/0 (needs 104) · Knee Shot 55/0 (needs 204) · Diamond Shot 55/0 (needs 304) · Revised Skill 55/0 |
| 2 | Dead Shot 60/1 (needs 114) · Extra Potion 60/1 (needs 214) · Skill Bargain 60/1 (needs 314) · Revised Magic 60/1 |
| 3 | From The Above 70/3 (needs 122) · Miracle Drop 70/3 (needs 224) · Big Bag 70/3 (needs 324) · Revised Art 70/3 |
| 4 | Snipe Mastery 75/4 (needs 134) · Med Research 75/4 (needs 234) · Ten Shot 75/4 (needs 334) · Contract 75/4 (needs 243 + 343) |
| 5 | Super Stat Plus 85/6 (needs 144) · Healing Field 85/6 (needs 244) · Extravagance 85/6 (needs 344) · New Order 85/6 (needs 434) |

- **Skill names:** `nAttack` is shown as Long Shot (range +5 m per rank), `cAttack` as Aimed Shot; the first three cAttack ranks and Stat Scan share row 2.
- **Class C prerequisites** are single skill numbers (`rSkill`): each C skill needs the last skill of its row in the tree above it (Bouncing Bullet 104, Dead Shot 114, From The Above 122, Snipe Mastery 134, Super Stat Plus 144, Knee Shot 204, Extra Potion 214, Miracle Drop 224, Med Research 234, Healing Field 244, Diamond Shot 304, Skill Bargain 314, Big Bag 324, Ten Shot 334, Extravagance 344); Contract needs Acidic Field I + Truce Trading I (243 + 343); New Order needs Contract (434). The four Revised / Stat skills of column 4 (404, 414, 424) have none.
- **Checked against the 2014 community simulator** (Rain Niar's Rabbit SkillSimulator v3): 92 of 97 cells equal; the differences, where the game code wins: Long Shot II-IV need 0 points (the simulator said 1/2/3), Life Shot needs 21 points (22), Customized Shotgun II shows Lv 28 / 22 pts (32 / 22). **Needs a live check:** Customized Shotgun II has an empty `getSkill` branch (`RabbitSkill.cs:957`) that falls into a shared tail, so its Lv 28 is the decoder's result, not an explicit `setReq`; it breaks the row's +4 level pattern (20, 24, 28, **32**).

## Thai tooltip mismatches (scan 2026-10-27)

Every number in the BB Thai tooltip (`RabbitSkill_thai.cs`) was compared with the app card, then each suspect with the code. Each row is a card `tooltipNote`.

| Skill | Thai tooltip says | Code says | Source |
|---|---|---|---|
| Shooting Array | +6~30 / +12~60 dmg ×4 | 3 hits `talAdjust(15×sLv)` = **+15 / +30**, last hit `talAdjust(30×sLv)` = +30 / +60 | `Rabbit.cs:35331`, `:35630` |
| Miracle Drop | ×2 damage dealt and taken | `damageMod` and `hitMod` each `+(0.1×sLv + 0.1)`, sLv = `clamp(lab, 1, 4)`: **×1.2 to ×1.5** | `CharacterControl.cs:37671`, `:37674`; `Rabbit_potion.cs:432-438` |

## Server Balance Variations (TTO)

| Skill | Original BigBug baseline | TTO delta |
|---|---|---|
| Contract | Mercenaries (Light Panther / Light Leopard / Light Golem) stand still where summoned. | They follow the owner and warp back beside the owner beyond 35 m, like coin-summoned characters (user-reported 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tto`). |


### ToT EX learning requirements (published simulator, 2026-10-13)

Source: [ToT rabbit simulator dataset](https://talesoftails.net/data/skill-simulator/rabbit.json), with learning rules from [ToT simulator client](https://talesoftails.net/_next/static/chunks/673.2ecb414e00f7368e.js). These are server-specific published simulator requirements, not BigBug decompiled mechanics or verified damage formulas. Icons were extracted from the site’s `/gamegui/skill-simulator/skills/` assets and embedded in the hub.

| Cell | Published skill name | Level | Ordinary C skills required | Explicit prerequisite cells | Type / availability |
|---|---|---|---|---|---|
| 451 | UpdamageMonter | 95 | 0 | None | Passive |
| 452 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 453 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 454 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 461 | DowndamageMonter | 95 | 0 | None | Passive |

Each learned EX skill costs one point from a separate EX pool: 0 below Lv 95, 1 at Lv 95–99, 2 at Lv 100. Cells 451 and 461 exclude each other. At most one of cells 452–454 may be learned. EX skills never count toward ordinary C point requirements. All explicit prerequisites and the six ordinary C skills must remain learned; refunds and tree resets enforce this. See [shared ToT EX rules](12Tails-Mechanics-Reference.md#tot-ex-skills-published-simulator-2026-10-13).

The three Lv 100 slots currently have placeholder names/art in the published dataset. The hub shows them as unavailable and does not invent skills or permit spending points on them.

### Riding mounts: mountAttack and mountDash (G. Marshal / G. Champion mount, verified 2026-10-17)
Both mounts run the same attack code for this class (`PvpMount.cs` and `ChampionMount.cs` differ only in the +20 / +50 stat bonus, the ride speed 8 / 9 and the Champion's charge; the shared rules are in [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md#riding-mounts-g-marshal-and-g-champion-verified-2026-10-17)). ATK, TAL and LCK are the mount's own (rider's base stats + bonus). Line numbers are `PvpMount.cs`; `ChampionMount.cs` has the same code a few hundred lines later.
- **mountAttack** (normal attack while moving at no more than 40% of the run speed): `Physics.Raycast` 32 m (`:11627`), `hit(1, ATK, KO 1)` on the first collider, cooldown 2 s (`:11657, :11923`).
- **mountDash** (normal attack while moving faster): the same 32 m raycast (`:12389`), `hit(1, 2 × ATK, KO 1)`, cooldown 2 s (`:12419, :12687`).

## Server Balance Variations (Reborn)

Build tag: every citation here is `Reborn:` (`DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/`), see [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) section 1. Reborn is a W.I.P. server in the Bible. The eight C6 / C7 skills are Reborn-only cards (Mix Shot since 2026-10-25, the other seven since 2026-10-26, see "C6 / C7 skills (Reborn only)" below), and the original skills listed under "Original skills changed on Reborn" below carry their changes in `servers.reborn` (2026-10-26).

### Mix Shot (`rab_mixshot`, Class C row C6, skill id 452; verified 2026-10-25, card `rabbit_mixshot`)

**Learning and cost** (`Reborn:RabbitSkill.cs:527-535`): Lv 95, 8 skills in the C tab, requires skill 254 (Life Shot 4); `setMPSP(10, -30)` = MP 10 and **30 SP consumed** (a negative SP is refunded by `returnMPSP` when the cast fails, `Reborn:Rabbit.cs:15337`); mode `target`, target `ally`.

**Client tooltip** (`Reborn:RabbitSkill_eng.cs:23`): "fires HeatShot + LifeShot + BoostShot at rank 5 into an ally (24 m range, 60 s cooldown)".

**Cast** (`Reborn:Rabbit.cs:14885-14935`): no target returns silently; yourself, an unknown target, a Robot or a Structure give a message and refund; a target farther than `24 m × RabEye` (3D `Vector3.Distance`, 32.4 m with Eagle Eye, `:14915`) gives "Target is too far for mixshot" and refunds. Cooldown `addTimeOut("mixshot", agiAdjust(60))` only without the `rapidTrance` status (`:14919-14921`). Then the visual shot `RPC_medicalShot(…, 5)` and, with skill 452, `RebornC6.MixshotBuff(target, caster)` (`:14926-14929`).

**Effect** (`Reborn:RebornC6.cs:2420-2428`): `n = 1 + Medical Enhancement level` (skills 261 / 262 / 263); on the target `heat` level 5 and `boost` level 5 for `chaAdjust(30 + 5n)`, `autoLife` level 5 for `chaAdjust(60 + 5n)`. It runs at cast, so the statuses land even if the bullet misses. The sLv 5 shot itself matches none of the medical-shot branches 1-4 (`Rabbit.cs:3630-3733`): no remedy, no Boost HP heal (`100 × lv`), no Heat SP (`10 × lv`); it only gives the usual +1 SP on hit, and the Field Pharmacy hook returns at once for it (`RebornC7Passive.RabPharmacy` accepts kinds 2-4 only, `:4361`).

**Related skills** (all compared with BB 2026-10-25 and identical apart from Reborn's Eagle Eye and Field Pharmacy hooks): Medical Enhancement (durations), Heat / Boost / Life Shot (the statuses; Life Shot 4 is the requirement), Rapid Trance (no cooldown), Eagle Eye (24 m to 32.4 m). In the Bible their links to Mix Shot sit in `servers.reborn.compatSkills`; the card has Eagle Eye (desc + range popup), Rapid Trance (cooldown 0) and Medical Enhancement (both durations) toggles.

### Eagle Eye (`rab_eagleEye5`, Class C row C6, skill id 451; verified 2026-10-25, re-verified 2026-10-26, card `rabbit_eagleEye`)

**Learning:** Lv 95, 8 skills already learned in the C tab, requires skills 401 and 411 (the Reborn simulator data, Reborn-Mechanics-Reference.md section 9). Passive: no MP, SP, cooldown, cast or status. The only patch note is the 2026-09-27 fix "Eagle Eye did not work" (section 7 there).

**Client tooltip** (`Reborn:RabbitSkill_eng.cs:21`): "Gun and acid skills: reach, area, effect size and target range +35%. Not Backpack or potions." Thai (`Reborn:RabbitSkill_thai.cs:22`, complete; the file writes the Thai combining marks with a stray `\` before them): "สกิลปืนและกรด ยิงไกลขึ้น วงกว้างขึ้น เอฟเฟกต์ใหญ่ขึ้น และเลือกเป้าได้ไกลขึ้น +35% (ไม่รวม Backpack และยา)". It ties the longer target range to gun and acid skills, but the lock change below has no skill check (card `tooltipNote`).

**Mechanism:** one constant, `RebornC6.EagleEye = 1.35f` (`Reborn:RebornC6.cs:61`), read through three helpers (`:2208-2225`): `RabEye(cc)` = 1.35 when `cc.Type == "Rabbit"` and `cc.hasSkill(451)`, else 1; `RabEyeSq` = `RabEye²`; `RabReach(cc, reach)` = `RoundToInt(reach × RabEye)`. It only multiplies geometry (reach, radius, scale, distance gates). No damage formula, KO, chance or duration is changed, but the longer Combo and Charge Attack rays let a hit land farther away, so the reachable Hyper Shot distance bonus grows (Combo 4 rifle up to 49 m, `Clamp(dist − 16, 0, 40)` at `Reborn:Rabbit.cs:206-216`; Charge Attack up to 54 m, unclamped `floor((dist − 16) × Hyper level)` at `:714-719`). Besides `Rabbit.cs`, `Rabbit_stickyGum.cs`, `Rabbit_acidicField.cs` and `GameGui.cs`, the only caller is the C7 Bullet Rain (`R = 28 × RabEye`, `Reborn:RebornC7Act.cs:5566`, used by its hit at `:5609`; grep of every Reborn `*.cs` for `RabEye`, 2026-10-26).

**Skills scaled ×1.35** (the `$RPC_…` names are the iterator classes in `Reborn:Rabbit.cs`; BB has the same skills under the same names):

| Skill (coroutine) | What is multiplied | Reborn:Rabbit.cs |
|---|---|---|
| Combo `nAttack` | raycast reach `20 + 5×normalAttackLv` and `16 + 5×normalAttackLv` (`RabReach`) | `:163`, `:184` |
| Charge Attack, release `cAttack2` | raycast reach `20 + 5×normalAttackLv` | `:689` |
| Bounce (`bounce0`) | effect scale; hit radius `3 m × rangeMod` (8 m, effect ×2.6 with skill 461) | `:1405`, `:1447` |
| From The Above, Maim Shot, Medical Shots (Immune, Boost, Heat, Life; Mix Shot injection), Gil Shot, Diamond Shot | raycast reach `16 + 5×normalAttackLv` | `:1581`, `:1975`, `:3639`, `:4389`, `:6977` |
| Sticky Gum | landing point 2 m ahead; field radius `(lv + 0.5)`; effect scale | `:3052`, `Rabbit_stickyGum.cs:57`, `:15789` |
| Acidic Field | landing point 2 m ahead; field radius 12 m; effects | `:3206`, `Rabbit_acidicField.cs:57`, `:15816`, `:15829` |
| Gorgon Shot | `SphereCastAll` radius 1, length 36 | `:4138` |
| Four Shot | cone length `24 m × rangeMod` (angle 70° and height `2 m × rangeMod` unchanged) | `:4962` |
| Circle Shot | effect scale; radius `8 m × rangeMod` | `:5112`, `:5157` |
| Shooting Array | hit radius `6 m × rangeMod` (four hit sites); ground-target limit 20 m, i.e. 27 m (`RabEyeSq` on `400`); effects | `:5996`, `:6038`, `:6061`, `:6095`, `:15100`, `:16137`, `:16153` |
| Customized Shotgun | effect scale; trapezoid half-widths `(0.5 × sLv + 0.5)` / `(sLv + 2)` and length `12`, each × rangeMod (the height `4 × rangeMod` is unchanged) | `:6241`, `:6254` |
| Millionaire | effect scales; area `8 m × rangeMod` | `:6415`, `:6492`, `:6543`, `:6559` |
| Ten Shot | cone length 24 m; effects | `:7131`, `:7283-7284`, `:7293-7294` |
| Thousand Shot | effect scale; beam rectangle `2 × 2 × 24` | `:18038`, `:18068` |
| Mix Shot target limit (`doSkill`) | ally distance gate 24 m, i.e. 32.4 m | `:14915` |

**Not scaled** (no `RabEye` call): Backpack, Mall, the potions (`Rabbit_potion.cs`), Healing Field, Truce Trading. The charge release `cAttack0` and the charge start `cAttack1` have no raycast to scale. The numbers in `cAttack0/1/2` are coroutine names, not ranks.

**Target selection (global to a Rabbit with 451, not only gun skills),** `Reborn:GameGui.cs`, with the BB values from [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md) section 4 ("Target-skill range"):

| Distance | BB | Reborn + Eagle Eye | Code |
|---|---|---|---|
| Mouse hover ray | 30 m | 40 m (`RoundToInt(30 × 1.35 = 40.5)`; the rounding of the .5 is by hand, not run) | `:4922`, `RabEye` |
| Right-click lock ray | 40 m | 54 m | `:4931`, `RabEye` |
| Target drop (flat XZ distance from the camera target) | 40 m (`1600`) | 54 m | `:4967`, `1600 × RabEyeSq` |
| Tab cycling (enemies `cycleEnemyTarget`, allies `cycleAllyTarget`; 3D distance, target must be on screen) | 36 m (`1296`) | 48.6 m (`1296 × 1.35² = 2361.96`, no rounding) | `:4379`, `:4383`, `:4398`; `:4815-4880` |

So every target-mode skill a Rabbit casts can reach 54 m instead of 40 m, whatever the skill. The camera ray still starts at the camera, so the practical click range also depends on zoom and angle (BB note in the Mechanics Reference).

**Open:** (1) the hover ray's `.5` rounding; (2) `RebornZone.Combat` gates the charge release: BB takes `cAttack2` whenever the aiming object exists (`DecompiledSource/Rabbit.cs:9309`), Reborn only `if (RebornZone.Combat && (bool)_2002)` (`Reborn:Rabbit.cs:15484`), otherwise the no-hit `cAttack0`; which maps count as Combat is not traced (an open-world zone rule, not shown on cards). The Reborn reach of every scaled card is now `servers.reborn.reach` with the Eagle Eye toggle (2026-10-26, "C6 / C7 skills (Reborn only)" below).

### Original skills changed on Reborn (verified 2026-10-26, on the cards as `servers.reborn`)

`BB:` = `DecompiledSource/`. The C6 / C7 rows (Eagle Eye, Skyfall Sniper, Field Pharmacy) and the open-world zone rules are not covered here.

* **Mall (`rab_mall1-2`) cannot be learned.** BB `getSkillTree`: cells 341 / 342 = `rab_mall1` / `rab_mall2`, 343 / 344 = `rab_truceTrading&Co1` / `Co2` (`BB:RabbitSkill.cs:3002-3039`). Reborn: 341-344 = `rab_truceTrading&Co1-4` (`Reborn:RabbitSkill.cs:979-990`) and no cell returns Mall; its code is still in the client but unreachable. Lv / points per cell are the same as BB, so the "identical Lv / bn / rq" line of [Reborn-Mechanics-Reference.md §9](Reborn-Mechanics-Reference.md#9-skill-simulator-on-the-reborn-website-read-2026-10-25-for-the-class-guide-editor) holds per cell, but the skill in 341-344 changed. Card: a change note only. Not done: the Bible's Reborn skill simulator (`SKILL_SIM_SERVERS.reborn`) still shows Mall in 341 / 342.
* **Truce Trading & Co. (`rab_truceTrading&Co1-4`): 4 ranks, MP 30 at every rank.** BB: 2 ranks, MP 20 / 30 (`BB:RabbitSkill.cs:893-910`); success `lck × sLv > Random(0, target.hp)` (`BB:Rabbit.cs:34105`), result event `RPC_truceTrading_fire + sLv`. Reborn: one `getSkill` case for ranks 1-4, `setReq({16, 20, 24, 28}[n − 1], {4, 8, 12, 16}[n − 1])`, `setMP(30)` (`Reborn:RabbitSkill.cs:13-26`); `doSkill` reads rank 1-4 (`Reborn:Rabbit.cs:14447-14465`) and passes it as sLv (`Reborn:Rabbit.cs:15130-15134`); the roll is `lck × sLv > Random(0, hp)` (`Reborn:Rabbit.cs:5623`), and both result events are `RPC_truceTrading_fire + Mathf.Min(sLv, 2)` (`Reborn:Rabbit.cs:5627`, `:5632`), so ranks 3-4 send the rank-2 purchase (the price stays server-side). Unchanged: cast `magAdjust(12)` (`Reborn:Rabbit.cs:5583`), cooldown `agiAdjust(240)` (`Reborn:Rabbit.cs:5526`), the player / structure refusals (`Reborn:Rabbit.cs:15118-15128`). Ranks 3-4 have no tooltip in either language. Card: `servers.reborn` `maxRank: 4`, `cost: {mp:30}`, a desc line for ranks 3-4, the tooltip note for ranks 1-2 only; the skill page reads the rank range from the server-merged card (`getSkillRank`, hero icon, pips and rank cycle).
* **Mix, Shake, Miracle Blend bottles (`Rabbit_potion.cs`): an ally standing on a bottle gets it, and one bottle serves one character.** BB: pickup only through `OnTriggerEnter` on the Rabbit's client (`BB:Rabbit_potion.cs:141`); its used flag `fRiN0Squkp` is read (`BB:Rabbit_potion.cs:121`, `:150`, declared `:525`) but never set, so characters touching a bottle before `RPC_potion_hit` removes it (`BB:Rabbit_potion.cs:455`, `BB:Rabbit.cs:9754`) can each get it. Reborn: every 0.1 s the Rabbit's client (`Reborn:Rabbit_potion.cs:76-77`) runs `Damage.FindAreaTarget(bottle, max(collider extents x / z) or 1.5, 3, Rabbit's layer)` and gives the bottle to the first living character there other than the Rabbit (`Reborn:Rabbit_potion.cs:81-112`); `OnTriggerEnter` still works for everyone, the Rabbit included (`Reborn:Rabbit_potion.cs:114-137`); `_ApplyPotion` sets the used flag first (`Reborn:Rabbit_potion.cs:139-145`). Effects and amounts are unchanged; Reborn mercenaries may refuse a bottle (`RebornMerc.Refuses`, `Reborn:Rabbit_potion.cs:105`, `:133`). Card: a `[Fix]` note on the three cards; a Reborn desc on Miracle Blend, the only desc that states the pickup.
- **Gear crit (Adjust; `rabbit_nAttack`):** BB `getCritPlus` rolls `lckAdjust(gear sum)` (`BB:Rabbit.cs:16471`). Reborn adds `RebornBalance.TrinketCritPlus` (+3 for `t_all61`-`63`) and the seal `critical` (`RebornEffects.CritPlus`, server data, not modelled) and rolls `lckItemAdjust(sum)` = `ceil(1.3 × sum)` with no LCK (`Reborn:Rabbit.cs:17924`, belt `:17952-17962`, trinket and seal `:17963-17964`, roll `:17965`; line numbers corrected 2026-10-26). In the app: the shared Reborn rule (`critChance`, `procChance`, `itemChance`) and the belt toggle `REBORN_BELT_DEP`; [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §2.2, §2.4.

### Review corrections (2026-10-26)

- Heat / Boost / Life / Immune Shot: Reborn has no same-level bump from a second caster (Reborn-Mechanics-Reference.md §2.7), so a second Rabbit no longer pushes `[X4]` to `[X5]`: Reborn desc lines replaced and a `[Nerf]` note on each. Mix Shot: while its level-5 statuses last, normal shots cannot refresh them (existing level higher, nothing added).
- Trading With Wind, Field Pharmacy and the Field Pharmacy lines reach every same-team player on the map plus own mercenaries in missions / PvP (`RebornBalance.AlliesWholeMap` → `Allies`, `Reborn:RebornBalance.cs:197-252`): "เพื่อนร่วมทีมทุกคน", not "เพื่อนในปาร์ตี้" (the party roster applies only in towns, scope rule 2).
- Shooting Array (BB fix, all servers): BB also needs the target within a flat 20 m (`vFlat sqrMagnitude < 400`, `BB:Rabbit.cs:8120`); the BB card's reach is that ring now (it showed the 40 m lock, which made the Reborn tab look like a change).
- Bounce / Skyfall Sniper: the fixed 65 / 45 s is AGI-free, but Revised Art still applies (`ceil(0.88 × …)`, 58 / 40 s).
- Start-of-map cooldown (every combat map: missions, PvP and combat zones, `RebornZone.CombatMap`, `Reborn:RebornZone.cs:28-38`; Revised Art applies, `Reborn:CharacterControl.cs` `addTimeOut`; card bullet on each): Thousand Shot 100 s flat, Trading With Wind 120 s flat (`Reborn:Rabbit.cs` `Start`), Bullet Rain `agiAdjust(360)` (`Seed`).
- Mix Shot and the Eagle Eye lock line no longer state sizes (they live in the reach field). Bullet Rain keeps firing its 20 volleys after a knock-down (`Reborn:RebornC7Act.cs:5585-5611`).

### C6 / C7 skills (Reborn only)

Verified 2026-10-26 in `DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/` (string helpers decoded with the string table). Learning (all `setReq(95, 8)` for C6, `setReq(105, 8)` for C7) is not on the cards. Not shown on cards (user rule 2026-10-26, open-world only): the full cooldowns that `Rabbit.Start` sets on a combat map (`RebornZone.CombatMap`: Contract `agiAdjust(180)`, Thousand Shot 100, Trading With Wind 120, Bullet Rain `agiAdjust(360)` through `RebornC7Act.Seed`; `Reborn:Rabbit.cs:12316-12328`, `Reborn:RebornC7Act.cs:615-651`) and the party-roster ally list outside missions (`RebornBalance.UsePartyRoster`). The shared ally list of Trading With Wind and Field Pharmacy is `RebornBalance.AlliesWholeMap` = `Allies(self, 100000, 100000)` (`Reborn:RebornBalance.cs:197-256`): the caster, the allied players on the map (party members in party-roster mode) and the caster's own Reborn mercenaries (`RebornMerc.AddMine`; Contract units and coin NPCs are not on it).

* **`rabbit_eagleEye`** (451, passive): the mechanism, the 18 scaled skills and the target lock are in the Eagle Eye section above. Card: desc, a `tooltipNote` for the Thai tooltip's "gun and acid skills" scope of the target range, links to every card it changes. Wiring (`servers.reborn`, toggle `REBORN_EAGLE_EYE_DEP`): a `reach` override built from the base parts (`rbEyeFrom`: sizes × 1.35, raycast lengths through `rbEyeRound` = float32 `RoundToInt`, .5 to even) and an `**Eagle Eye:**` desc line on Combo, Charge Attack, Stat Scan, Bounce, From the Above, Maim Shot, Sticky Gum, Acidic Field, the four medical shots, Gorgon Shot, Gil Shot, Four Shot, Circle Shot, Truce Trading & Co., Shooting Array, Customized Shotgun, Millionaire, Diamond Shot, Ten Shot (desc only on Bouncing Bullet, a passive); Combo and Charge Attack also carry the toggle in `dmgControls`, because their distance boxes (`rabbitComboMaxDistance`, `rabbitChargeMaxDistance`) use the Reborn reach on Reborn (Combo 4 rifle 49 m, shotgun box 1 + 16.2 m, Charge Attack at Combo 4 54 m). Shooting Array's Reborn reach also shows its real gate, a flat 20 m (27 m) ring (`Reborn:Rabbit.cs:15100`) instead of the 40 m lock; the BB card still shows the lock although BB has the same 20 m gate (BB card issue, not changed).
* **`rabbit_mixshot`** (452): see the Mix Shot section above; re-checked 2026-10-26 against `Reborn:Rabbit.cs:14885-14935` and `Reborn:RebornC6.cs:2420-2428`, nothing to correct. Now also linked to Field Pharmacy (a level 6 status from Field Pharmacy refuses Mix Shot's level 5 of the same status until it ends: `RPC_AddStatus` breaks on an existing higher level, `Reborn:CharacterControl.cs:9665-9667`).
* **`rabbit_thousandShot`** (453, target enemy): `setMPSP(60, -75)` = MP 60, 75 SP consumed (`Reborn:RabbitSkill.cs:438-447`, the names decode to `rab_thousandShot5` / `thousandShot`). Cast: only a selected target is needed, no distance gate (`Reborn:Rabbit.cs:14836-14846`), so the 40 m lock (54 m with Eagle Eye) is the limit. `RPC_thousandShot` (`Reborn:Rabbit.cs:18022-18097`): cooldown `addTimeOut("thousandShot", 100f)`, fixed (Revised Art still applies in `addTimeOut`, `Reborn:CharacterControl.cs:11683-11686`), faces the target, `moveSpeed 0`; after `WaitForSeconds(0.6f)`, if the Rabbit is still attacking (`actionState == "attack" || myCommand == "thousandShot"`), 9 volleys 0.1 s apart (hits at 0.6, 0.7 … 1.4 s), no state check inside the loop; each volley `Damage.FindRecTarget(position, forward, 2 × RabEye, 2 × RabEye, 24 × RabEye, 3)` (half-widths: a 4 m × 24 m beam, 5.4 m × 32.4 m with Eagle Eye) and `hit(453, target, FloorToInt(0.4f × (atk + talAdjust(40))), KO 1)` on every target in it (`:18068-18072`). Card: `dmg talAdjust(40)`, `atkCoeff 1`, `dmgMult 0.4` (the Bible truncates the sum, then × 0.4, the same number), 9 hits, KO 1, `extravagance:true` (it reads `mChar.atk`), Carron Gambit `finalOut`. No onNormalAttackHit, no crit.
* **`rabbit_tradingWithWind`** (454, target ally): `setMPSP(90, -70)` (`Reborn:RabbitSkill.cs:517-526`). Cast (`Reborn:Rabbit.cs:14847-14884`): refused with a refund without at least 1 Suntide (`m_spm3`, `getItemTotalNum < 1`), for an unknown target, a Robot or a Structure; no self check and no distance gate. The client never removes the Suntide; the 2026-09-24 patch note says 1 is used per cast (server-side). `RPC_tradingWithWind` (`:18099-18200`): cooldown `addTimeOut("tradingWithWind", 120f)` fixed, `moveSpeed 0`, 1.5 s flag animation, then if not interrupted `RebornC6.TradingWindParty` (`Reborn:RebornC6.cs:2431-2449`): every living unit on `AlliesWholeMap` gets `cleanse` level 20 for 6 s and `zephyrLore` level 9 for 6 s with value 60 (constants `TradingWindValue = 60`, `TradingWindTime = 6`, `:67-69`); the selected target gets `spiritOfWind` level 5 for 10 s (`:18178`), then 1 s more of animation. Statuses: `cleanse` (Buff, Magical) removes and blocks Physical or Magical debuffs of level ≤ 20 (`Reborn:CharacterControl.cs:3474-3504`, `:9429-9433`); `zephyrLore` (Buff, State) gives run speed `+0.08 × 60 = +4.8` and removes every non-System debuff once (`:4096-4127`); `spiritOfWind` (Buff, State; new Bible popup) gives run speed `+sLv`, LCK `+30 × sLv` (`:4292-4306`, removal `:11275-11284`) and heals HP `100 × sLv`, MP `30 × sLv`, SP `10 × sLv` every 2 s on the holder's clock (`mod(2 × now, 4) == 1`, `:9103-9108`). The 2026-09-27 fix "hit only one target" is in: the whole list gets the buffs. `tooltipNote`: the Thai tooltip says it blocks new statuses for 6 s; State debuffs such as `petrify`, `artCancel`, `grab`, `cut` and the System ones still land (decoded `Reborn:StatusData.cs:1564-1653`).
* **`rabbit_skyfallSniper`** (461, passive): `RebornC7Passive.RabAir` = 20 s on both Bounce ranks instead of `4 × sLv` (`Reborn:RebornC7Passive.cs:4319-4326`; `hide` for 21 s and the landing timer, `Reborn:Rabbit.cs:1262-1263`); `RabBounceCd`: Bounce cooldown 20 + 45 = 65 s at takeoff (`Reborn:Rabbit.cs:1198`), 45 s after every air shot (`:1558`) and at landing (`RabLanded`, `:1374`, `RebornC7Passive.cs:4341-4347`), all fixed (no `agiAdjust`); the From the Above landing hit becomes `hit(421, atk + talAdjust(60), KO 40)` in `FindAreaTarget(8 × RabEye, 3)`, no rangeMod (`Reborn:Rabbit.cs:1444-1457`; BB `atk`, KO 20, `3 × rangeMod`); the air shot (`code 1` while `myCommand == "bounce"`) × 1.4 after DEF in `FinalOut` (`Reborn:RebornC7Passive.cs:573-578`). Wiring on `rabbit_bounce` (`servers.reborn`, toggle `REBORN_RABBIT_SKYFALL_DEP` on the Duration chip as `dep` and in `dmgControls`): duration 20, landing `dmg talAdjust(60)` and KO 40 (with From the Above), reach 8 m, desc line. On `rabbit_fromTheAbove`: desc line and reach. With the toggle on, Bounce's cooldown chip shows the fixed 45 s left after landing (`servers.reborn.cd` / `cdWrapped` as functions, read through `cdWrappedOn`; Revised Art still applies, `ceil(0.88 × 45)` = 40, `Reborn:CharacterControl.cs` `addTimeOut`); the 65 s at takeoff is in the desc. Not on a chip: the × 1.4 air shot (the air shot at `Reborn:Rabbit.cs:1599` has no card on any server).
* **`rabbit_fieldPharmacy`** (462, passive): `RabPharmacy` from `RPC_medicalShot` on a hit of an ally on the Rabbit's layer, after the shot's own effect (`Reborn:Rabbit.cs:3725-3728`), only for kinds 2-4 = Boost / Heat / Life Shot (`Reborn:RebornC7Passive.cs:4361`; Immune Shot and Mix Shot never trigger it). Once per 60 s per kind, its own timer (`_pharmNext`, `:4366-4370`, not `addTimeOut`, so Revised Art and Rapid Trance do not touch it). Every unit of `AlliesWholeMap` plus the shot target (if allowed), skipping dead units and summons (`:4373-4383`): Boost `boost` level 6 for `chaAdjust(30 + 5n)` and 600 HP to everyone but the target; Heat `heat` 6 for `chaAdjust(30 + 5n)` and 60 SP to everyone but the target; Life `autoLife` 6 for `chaAdjust(60 + 5n)`; `n = 1 + Medical Enhancement level` (`:4371-4423`). Card: cooldown 60 fixed (`revisedArtExempt`), the two duration chips with the Medical Enhancement toggle. Wiring: an `**Field Pharmacy:**` desc line and a `REACH_UNLIMITED` part (toggle `REBORN_RABBIT_FIELD_PHARMACY_DEP`) on Boost / Heat / Life Shot; links on Medical Enhancement, Rapid Trance and Mix Shot.
* **`rabbit_carronGambit`** (463, instant self): `setMPSP(40, -40)` (`Reborn:RabbitSkill.cs:460-467`). `RebornC7Act.Cast` (`Reborn:RebornC7Act.cs:466-527`): needs 3 Carron coins in the inventory (`PickCoins` takes the best tier first, k_gld4 down to k_gld1, `:5162-5194`; fewer than 3 = message and refund, no cooldown); each coin `Random.value < 0.4 / 0.5 / 0.6 / 0.75` (Gold / Platinum / Daimond / Emerald, `:5196-5206`), no LCK. `RabbitGambit` (`:5219-5292`): cooldown 90 s fixed (`CdGambitFixed`, `fixedCd: true`), status `carronGambit` level = heads for 30 s at 1.45 s, 0 heads gives nothing. The client never removes the coins. `FinalOut` multiplies every `hit()` of the Rabbit by `GambitMul(heads)` = 1.15 / 1.35 / 1.6 after `dmgAdjust` and `defAdjust`, before the target's `hitMod`, `CeilToInt` in float32, one product with Skyfall's 1.4 (`Reborn:RebornC7Passive.cs:538-596`, `Reborn:CharacterControl.cs:7275`); with 3 heads `AfterHit` sends `max(1, floor(0.2 × dmg))` Effect Damage (code 463) to every other living enemy within `FindAreaTarget(victim, 3, 3)` for every non-C7 hit (`Reborn:RebornC7Passive.cs:639-644`, `Reborn:RebornC7Act.cs:5535-5559`). The status is in no `StatusData` list (no popup). Wiring: a new card field `finalOut` (engine: `finalOutAdjust` in `rollOneHit` and the Final range, normal `hit()` path only) with the 0-3 heads toggle `REBORN_RABBIT_CARRON_GAMBIT_DEP` in `dmgControls` and the `**Carron Gambit:**` desc line on Combo, Charge Attack, Bounce (landing), Maim Shot, Gorgon Shot, Gil Shot, Backpack, Four Shot, Circle Shot, Shooting Array, Millionaire, Ten Shot, Thousand Shot, Bullet Rain (desc line only on From the Above, whose air shot has no damage model). Not multiplied: Diamond Shot and Acidic Field (direct `RPC_AddEffectDamage`), item / pet / weapon effects, mercenaries and coin NPCs. Multiplied but not wired: the Common support skills a Rabbit casts (`hit(171-177)` in `Reborn:Rabbit.cs`), which have no damage model. The gold shards are not modelled (Final / Test are single-target).
* **`rabbit_bulletRain`** (464, instant self): `setMPSP(90, -90)` (`Reborn:RabbitSkill.cs:468-475`). `RabbitBulletRain` (`Reborn:RebornC7Act.cs:5561-5622`): cooldown `agiAdjust(600)` (`Cd464Base`, `Begin` without `fixedCd`, `:150`, `:808-816`), `moveSpeed 0`, centre = the cast position, `R = 28 × RabEye` (37.8 m with Eagle Eye); at 0.5 s `hide` (removed after the 20th volley, 3.0 s), then 20 volleys 0.15 s apart (0.5 … 3.35 s), each `Hit(cc, 464, c, R, 6, 0.6, 60, KO 10)` = `FloorToInt(0.6f × atk) + talAdjust(60)` rolled once per volley on every living enemy in `FindAreaTarget(c, R, 6)` with the enemy mask (`:851-872`, `Reborn:RebornC6.cs:871-918`; the 2026-09-27 "enemies only" fix is in). No crit. Carron Gambit multiplies it, but code 464 is C7, so no shards. Card: `dmg talAdjust(60)`, `atkCoeff 0.6`, 20 hits, KO 10, `extravagance:true`, `finalOut`, reach 28 m × 6 m with 20 timed hits.
