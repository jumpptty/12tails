# Sheep — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| heal | Heal | 4 | 20 | true | false | — | — |
| bless | Bless | 4 | 90 | true | false | 30 | true |
| quickHeal | Quick Heal | 2 | 1 | false | false | — | — |
| allHeal | All Heal | 2 | 60 | true | false | — | — |
| pacify | Pacify | 2 | 60 | true | false | — | — |
| sleep | Sleep | 2 | 90 | true | false | — | — |
| clear | Clear | 2 | 18 | true | false | 1 | false |
| cleanse | Cleanse | 1 | 30 | true | false | 1 | false |
| allCleanse | All Cleanse | 1 | 90 | true | false | 1 | false |
| overHeal | Over Heal | 2 | 45 | true | false | — | — |
| revive | Revive | 2 | 180 | true | false | — | — |
| revert | Revert | 1 | 900 | true | false | — | — |
| holyLight | Holy Light | 2 | 60 | true | false | — | — |
| lightBind | Light Bind | 4 | 30 | true | false | — | — |
| illuminate | Illuminate | 4 | 24 | true | false | 12 | true |
| feather | Feather | 2 | 18 | true | false | 15 | true |
| allFeather | All Feather | 2 | 60 | true | false | 15 | true |
| divinitySword | Divinity Sword | 2 | 45 | true | false | — | — |
| divinitySpear | Divinity Spear | 2 | 60 | true | false | — | — |
| seal | Seal | 1 | 12 | true | false | 60 | true |
| repel | Repel | 2 | 120 | true | false | 6 | true |
| reverse | Reverse | 2 | 240 | true | false | 3 | true |
| soulOfArms | Soul of Arms | 2 | 300 | true | false | — | — |
| purifyingTear | Purifying Tear | 1 | 480 | true | false | — | — |
| lullaby | Lullaby | 1 | 60 | true | false | — | — |
| divinityAxe | Divinity Axe | 1 | 150 | true | false | — | — |
| edenSanctuary | Eden Sanctuary | 1 | 240 | true | false | 12 | false |
| worldEncarta | World Encarta | 1 | 150 | true | false | 9 | true |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Sheep's own thematic `divineChannel`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Sheep.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Sheep.cs:12059`), `psalmOfEnergy`
  (`Sheep.cs:12302`), `seaAegis` (`Sheep.cs:12471`), `zephyrLore` (`Sheep.cs:12665`), `replenishment`
  (`Sheep.cs:12766`), `elementalBound` (`Sheep.cs:12896`), `astralShift` (`Sheep.cs:13045`),
  `bloodCarnage` (`Sheep.cs:13236`), `obsidianFang` (`Sheep.cs:38944`), `assassinate`
  (`Sheep.cs:39399`), `mineWalker` (`Sheep.cs:39787`), `divineChannel` (`Sheep.cs:40158`) — all 12
  present, all bare-`600`. A direct grep of `SheepSkill.cs`/`SheepSkill_eng.cs` for `divineChannel`
  (Sheep's own thematically-named support skill) returns zero matches, confirming it isn't part of
  Sheep's own learnable-skill roster (`getSkill()`). All 12 excluded.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.**
  `shp_nAttack1`/`shp_nAttack2` both fall through (no live goto) to the shared terminal
  `setReq(2, 0); mode = eSkillMode.passive;` tail (`SheepSkill.cs:2315-2323`), and `shp_cAttack1`-`4`
  converge on a separate passive tail with no `cType` at all (`SheepSkill.cs:2295-2306`,
  `IL_198E: mode = passive`). Live cast sites include `Sheep.cs:9043` (`addTimeOut("nAttack", 1f)`) and
  `Sheep.cs:18812` (`addTimeOut("cAttack", 1f)`). Excluded regardless of the passive/active metadata
  quirk, per the blanket rule.
- **`mount` is not a Sheep class skill — excluded, not a judgment call.** `Sheep.cs:44361` —
  `this.$self_$28356.mChar.addTimeOut("mount", (float)12);` — the universal ride-a-mount action shared
  by every class. `SheepSkill.cs` has no `cType`/`getSkill()` entry for `"mount"` at all.
- **No classic Mole/Panda/Rabbit-style dead-code-fallthrough trap (an empty rank branch landing on an
  *unrelated* active skill's `cType`) was found in Sheep.** Every family's higher/lower ranks that fall
  through with no live `goto` land either on their own family's correct active tail (e.g. `heal4` falls
  through the entire `bless1`-`4` nested block to land cleanly on `IL_9C4`'s `cType = "heal"`,
  `SheepSkill.cs:2167-2193`) or on a legitimately shared *passive* tail with no `cType` at all
  (`harmonicDiffuse1`-`4` → `IL_1FC2`, `SheepSkill.cs:2262-2273`; `statPlus1`-`4` → `IL_219C`,
  `:2225-2241`; `benediction1`-`3` → `IL_28E4`, `:1913-1924`; `karma1`-`4` → `IL_CB7`, `:1546-1557`) —
  none of these landing spots belong to a different, unrelated active skill, so none needed an extra row.
- **The four `sealOf*` skills (`sealOfAttack1`, `sealOfDefense2`, `sealOfEarth1`, `sealOfHeaven2`) are a
  distinct structural pattern from the classic trap: four differently-named, non-sequentially-ranked
  skills that all deliberately converge on ONE shared `cType`, not four independent abilities — reported
  as a single row (`seal`, Max Rank 1), not four rows.** Unlike Rabbit's `immuneShot`/`boostShot`/
  `heatShot`/`lifeShot` family (each rank got its own distinct `cType`, so each got its own row), all
  four `sealOf*` names here funnel into the identical `cType = "seal"` tail
  (`SheepSkill.cs:1643-1668`: `setReq(20, 8); setMP(10); mode = instant; target = ally;
  cType = "seal"`). `sealOfAttack1`'s own block sets `setReq(12, 4); setMP(10)` (`:805-810`) then falls
  through with no goto, past `sealOfDefense2` AND the entire nested `sealOfEarth1`/`sealOfHeaven2`/
  `repel`-mega-tree, landing on the shared tail — whose own `setReq(20, 8)` call *overwrites* the
  earlier `setReq(12, 4)`, so `getSkill("shp_sealOfAttack1")` actually reports level 20/skillpoint 8,
  not its own declared 12/4. `sealOfDefense2` (empty body, `:816-822`), `sealOfEarth1`
  (`setReq(28, 12); setMPSP(10, -10)`, `:831-836`), and `sealOfHeaven2` (empty, `:842-848`) all fall
  through the same way to the identical tail. Eng descriptions confirm these are four different ground-
  seal *types* (attack/defense/earth/heaven combo-bonus), not four power ranks of one spell
  (`SheepSkill_eng.cs:713-756`), but since the actual `Sheep.cs` cast site is a single shared
  `RPC_seal`/`addTimeOut("seal", ...)` regardless of which variant is learned (`Sheep.cs:10782-10790`,
  `:32722`), the cooldown-lookup tool only needs the one shared value — hence one row.
- **Only two of the four `sealOf*` names are actually live-castable — Earth/Heaven are combo-triggered
  VFX with no ground-lifetime of their own, not two more independently-placeable seal types (re-checked
  2026-08-14, user request).** The player-input dispatch (`Sheep.cs:7379-7397`) only recognizes
  `shp_sealOfAttack1` (routes `sLv=1`) and `shp_sealOfDefense2` (`sLv=2`) — a full-file grep for
  `shp_sealOfEarth1`/`shp_sealOfHeaven2` returns zero hits outside `SheepSkill.cs`'s metadata tree.
  Inside `RPC_seal` (`Sheep.cs:31985-32826`), `sLv` picks which prefab to place — `sLv==1` loads
  `redSeal` (`:32191`), else `blueSeal` (`:32226`) — and **both converge on one shared lifetime**:
  `Sheep.cs:32284` — `this.$mSealControl$28058.life = (float)this.$self_$28064.mChar.chaAdjust(60);` —
  a real ground-despawn timer (`EffectControl.cs:164,179-183` accumulates `Time.deltaTime` and
  self-destroys once `life` elapses; the `afterLife` grace period is untouched, keeping its `1f`
  constructor default). "Earth"/"Heaven" are a separate, automatic combo-proc: `RPC_seal` itself tracks
  the caster's last three placed seals and, on a matching RRR/BBB/mixed pattern, fires
  `RPC_seal_create(pos, dir, tID, 1..4)` (`Sheep.cs:10789`, `:32402-32656`) — that coroutine only
  `Instantiate`s a visual-effect prefab and `Destroy`s the prior one on the next trigger
  (`Sheep.cs:10796-10802`); no `EffectControl`, no `.life` field, no despawn timer of its own to cite.
  Ground-lifetime is therefore one shared `chaAdjust(60)` regardless of red/blue type, and there is no
  Earth/Heaven lifetime to report because those aren't independently-placed ground objects in this build.
- **`edenSanctuary`'s field-lifetime is a genuine, citable value in its own companion class — a bare
  literal, not `chaAdjust`-wrapped (found 2026-08-14, user request).** `RPC_edenSanctuary`
  (`Sheep.cs:11787-11789`, generator `Sheep.cs:36772-37219`) requires an already-placed seal (gated at
  `Sheep.cs:7545-7551`, matching "Required 3 seals in placed," `SheepSkill_eng.cs:1025`), instantiates
  the `edenSanctuary` prefab at the seal's position (`Sheep.cs:37133`), and calls
  `SendMessage("InitEdenSanctuary", ActorNr)` on `Sheep_edenSanctuary` (`Sheep.cs:37142`). That
  component's own deadline: `Sheep_edenSanctuary.cs:73` — `this.rKABs8tDiX = Time.time + (float)12;` —
  checked in `Update()` (`:129`), then `DestroySanctuary()` (`:135`) plays a 1s destroy animation before
  the actual `Destroy` (`:372`, `:409-423`) — so real on-screen persistence is `12`s active + `1`s
  destroy-animation grace; this table reports the citable `12`. While active, every 2s it separately
  re-applies a `"sanctuary"` buff to allies in range (`Sheep_edenSanctuary.cs:160-205`,
  `RPC_AddStatus("sanctuary", 5, 3, 0, ...)`) — also a bare literal `3`, distinct from the field's own
  `12`s lifetime and not what this row reports.
- **`bookBash5` is excluded — a genuinely active-mode skill (`mode = instant`, `cType = "bookBash"`,
  `SheepSkill.cs:1455-1465`) that has no real, reusable per-cast cooldown, matching its own flavor text
  verbatim.** `SheepSkill_eng.cs:1069` — "Perform a book bashing attack that has no cooldown." The only
  `addTimeOut("bookBash", ...)` call in the entire file is a one-time pre-arm in `Start()`
  (`Sheep.cs:86` — `this.mChar.addTimeOut("bookBash", this.mChar.agiAdjust(60f));`, gated only by
  `Game.mGameType > 4`); the live `RPC_bookBash` coroutine (`Sheep.cs:11794-11796`, class body
  `:37224-37283` and following) contains no `addTimeOut` call of its own, so the ability is never
  re-locked after the initial spawn-time lock expires. Since the table's scope is explicitly "active
  skills only (**has a real cooldown**)," and this skill functionally does not, it gets no row — this is
  different from a `getSkill()` metadata bug; the code and the flavor text agree the ability really has
  no cooldown.
- **`quickHeal`'s cooldown is a bare, unwrapped literal — flagged per the plan's `manaArc`-precedent
  warning, not assumed `agiAdjust`-wrapped from its neighbors.** `Sheep.cs:10316` —
  `this.mChar.addTimeOut("quickHeal", (float)1);` — inside the live `RPC_quickHeal` handler (runs on
  every actual cast, not a one-time pre-arm), a flat `1` with no `agiAdjust(...)` wrapper, unlike every
  other Sheep active skill checked.
- **`clear`/`cleanse`/`allCleanse`'s Duration is a bare integer expression, not `chaAdjust`-wrapped —
  verified at each cast site individually, not assumed.** `Sheep.cs:24881` (`clear`), `:25375`
  (`cleanse`), `:25835` (`allCleanse`) all read `1 + ((!hasSkill(442)) ? 0 : 5)` as the third
  `RPC_AddStatus` argument — a bare integer, no `chaAdjust(...)` call anywhere in the expression.
- **CHA-contested Duration exclusions, per the plan's contested-duration rule.** `sleep`'s own `"sleep"`
  status: `Sheep.cs:24379` — `this.$mDuration$27834 = Damage.getDebuff((float)(3 + this.$sLv$27838 * 3),
  this.$self_$27839.mChar.cha, this.$tChar$27833.cha);`, applied at `Sheep.cs:24382`. `lightBind`'s own
  `"lightBind"` status: `Sheep.cs:28899` — `this.$mDuration$27948 = Damage.getDebuff((float)3,
  this.$self_$27953.mChar.cha, this.$tChar$27946.cha) + this.$mIntenseBindLv$27947;`, applied at
  `Sheep.cs:28902`. `lullaby` applies the `"sleep"` status to targets in range using the same
  target-contested formula: `Sheep.cs:35581` —
  `this.$hitChar$28126.RPC_AddStatus("sleep", 1, Damage.getDebuff((float)6, this.$self_$28130.mChar.cha,
  this.$hitChar$28126.cha), 0, this.$self_$28130.mChar.ActorNr);`. All three report Duration `—`.
- **`bless`'s cooldown is capped at a flat 30s by the `gospel5` passive — base value reported assumes
  `gospel5` unlearned, per the "report the un-upgraded base value, cite the upgrade" rule. `gospel5`'s
  own flavor text is only half-accurate: the "+1 level" claim is verified exactly, but "decreases
  cooldown by 70%" is a flavor-text gloss on the max-rank case, not the real mechanism.**
  `Sheep.cs:21263` — `this.$mTimeOut$27749 = ((!this.$self_$27763.mChar.hasSkill(412)) ?
  (30 + 15 * this.$sLv$27762) : 30);` — commandNum `412` maps to `shp_gospel5` per `SheepSkill.cs`'s own
  `getSkillTree()` table (`:3247-3256`: `commandNum == 412` → `result = "shp_gospel5"`).
  `gospel5`'s own description ("Increases level of all bless skills by 1 and decreases their cooldown by
  70%.", `SheepSkill_eng.cs:937`) is right about the level (`+1` to `bless`'s `RPC_AddStatus` level
  argument, confirmed at `:22824` — see the Duration citation), but the cooldown isn't actually a 70%
  reduction of anything: it's a hardcoded flat `30`, independent of `sLv`. At Bless's own max rank
  (unlearned base `30+15*4=90`), a flat `30` happens to read as a ~66.7% cut — close enough to "70%" to
  be the obvious source of the flavor text — but the real rule has no percentage in it at all; at rank 1
  (base `45`), the same flat `30` is only a 33% cut, nothing like "70%". Base (unlearned, `sLv = 4`) =
  `30 + 15*4` = `90`, the value reported.
  This is the first Sheep case of a skill whose Cooldown (not Duration) depends on a *different* skill's
  learned rank — encoded structurally in the lookup tool's data via a `cdDep` field (2026-08-14) on the
  `sheep_bless` `SKILLS` entry (`12t_projects/player-reference-tool/index.html`): `gospel5` is single-
  rank (learned or not, `minRank:0, maxRank:1`), so `rawAtRank(R) = 90 + (-60)*R` gives the correct `90`
  unlearned / `30` learned (matching this note's own two cited values) despite only being a 2-point
  linear fit — the tool renders this as a single icon toggle (`.sk-dep-toggle`), not a rank stepper,
  since there's no middle rank to select.
- **`clear`/`cleanse`/`allCleanse`'s Duration is extended from 1s to 6s by the `purify5` passive — base
  value reported assumes `purify5` unlearned.** `Sheep.cs:24881`/`:25375`/`:25835` all gate on
  `hasSkill(442)`; commandNum `442` maps to `shp_purify5` per `SheepSkill.cs:3280-3289`, matching
  `purify5`'s description ("Increases Clear and Cleanse's level by 1 and prolongs their effects to 6
  seconds.", `SheepSkill_eng.cs:970`). Base (unlearned) = `1`, the value reported for all three skills.
- **`illuminate`'s effect level (not its duration) is boosted by `blindingLight5`; `feather`'s status
  name (not its duration) is swapped to `"wing"` by `floatingWing5`; `lightBind`'s target-contested
  duration gets a flat `+1` from `intenseBind5` — none of these change the Duration *values* reported
  here beyond what's already cited.** `illuminate`: `Sheep.cs:29411` gates the status *level* argument on
  `hasSkill(413)` (= `blindingLight5`, `SheepSkill.cs:3302-3311`) but the duration argument itself is the
  unconditional `chaAdjust(12)` — reported as-is. `feather`/`allFeather`: `Sheep.cs:29876`/`:30335` gate
  which status *name* (`"wing"` vs `"feather"`) is applied on `hasSkill(423)` (= `floatingWing5`,
  `SheepSkill.cs:3313-3322`), but both branches use the identical `chaAdjust(15)` duration
  (`:29880`/`:29889`, `:30341`/`:30349`) — reported as-is. `lightBind`: `intenseBind5`
  (`hasSkill(403)` = commandNum `403`, `SheepSkill.cs:3291-3300`) adds `+1` inside the already
  target-contested `Damage.getDebuff(...)` sum (`Sheep.cs:28899`) — moot since `lightBind`'s Duration is
  already `—` regardless.
- **`divinitySword`, `divinitySpear`, `allFeather`, `repel`, `reverse`, `soulOfArms`, `divinityAxe`,
  `worldEncarta`, `cleanse`, `allCleanse`, `revert`, `sleep`, `holyLight`, `seal`, `purifyingTear`,
  `lullaby`, `edenSanctuary` all have flat, non-rank-scaled cooldowns despite several being multi-rank
  skills — confirmed directly at each `$mTimeOut$`/`addTimeOut` assignment, not an oversight.** E.g.
  `divinitySword` (2 ranks) always resolves `$mTimeOut$27749 = 45;` regardless of `$sLv$27762`
  (`Sheep.cs:21480`); `allFeather` (2 ranks) always `= 60;` (`:21463`); `soulOfArms` (2 ranks) always
  `= 300;` (`:21548`). Only `heal`, `bless`, `allHeal`, `pacify`, `clear`, `overHeal`, `revive`,
  `lightBind`, `illuminate`, and `feather` have a per-`sLv` cooldown term.
- **No `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists for**: `heal`, `quickHeal`,
  `allHeal`, `pacify`, `overHeal`, `revive`, `revert`, `holyLight`, `divinitySword`, `divinitySpear`,
  `soulOfArms`, `purifyingTear`, `divinityAxe` — confirmed by a full-file grep
  of every `RPC_AddStatus(` call in `Sheep.cs` and cross-checking each hit against these skills' own
  coroutine bodies. `overHeal` is actually a penetrating-damage attack against a full-HP enemy despite
  its "heal" name (`SheepSkill_eng.cs:431`: "deals 50 penetrating damage to a target with full hp"), and
  `holyLight` is a channel mechanic whose "temporary" flavor text has no citable duration constant in
  its own cast-site coroutine — the remaining `RPC_AddStatus` hits in the file belong either to the 12
  support skills, to passive/excluded skills, or to an unrelated
  generic minigame/consumable-item/flag-capture effects system (`wash`, `ice`, `bubbleShield`,
  `iceShield`, `awareness`, `float`, `mpsap`, `burn`, `paralysis`, `blind`, `plague`, `frost`,
  `whiteFlag`, `redFlag`, `blueFlag`, `yellowFlag`, `awake`, `happy`, `charm`, `artCancel`, `heavy`,
  `mpDrain`, `hpDrain`) — none tied to any `SheepSkill.cs` roster entry, matching the same generic-
  effects block documented in the Panda/Mole/Rabbit docs. Duration cells for all thirteen skills listed
  above are `—`. **`seal` and `edenSanctuary` are no longer in this list** — each has a real,
  citable field-lifetime, verified separately below (not via `RPC_AddStatus`).

### CD citations
- `heal` CD: `Sheep.cs:21229` — `this.$mTimeOut$27749 = 12 + 2 * this.$sLv$27762;` (sLv4 → 20), wrapped at `Sheep.cs:21606` — `this.$self_$27763.mChar.addTimeOut(this.$sType$27758, this.$self_$27763.mChar.agiAdjust((float)this.$mTimeOut$27749));`
- `bless` CD: `Sheep.cs:21263` — `this.$mTimeOut$27749 = ((!hasSkill(412)) ? (30 + 15 * this.$sLv$27762) : 30);` (sLv4, `gospel5` unlearned → 90), wrapped at `:21606` (see judgment-call note re: `gospel5`)
- `quickHeal` CD: `Sheep.cs:10316` — `this.mChar.addTimeOut("quickHeal", (float)1);` (own dedicated cast site; bare literal, not `agiAdjust`-wrapped)
- `allHeal` CD: `Sheep.cs:21246` — `this.$mTimeOut$27749 = 30 + 15 * this.$sLv$27762;` (sLv2 → 60), wrapped at `:21606`
- `pacify` CD: `Sheep.cs:21276` — `this.$mTimeOut$27749 = 30 + 15 * this.$sLv$27762;` (sLv2 → 60), wrapped at `:21606`
- `sleep` CD: `Sheep.cs:21293` — `this.$mTimeOut$27749 = 90;`, wrapped at `:21606`
- `clear` CD: `Sheep.cs:21310` — `this.$mTimeOut$27749 = 6 + 6 * this.$sLv$27762;` (sLv2 → 18), wrapped at `:21606`
- `cleanse` CD: `Sheep.cs:21327` — `this.$mTimeOut$27749 = 30;`, wrapped at `:21606`
- `allCleanse` CD: `Sheep.cs:21344` — `this.$mTimeOut$27749 = 90;`, wrapped at `:21606`
- `overHeal` CD: `Sheep.cs:21361` — `this.$mTimeOut$27749 = 15 + 15 * this.$sLv$27762;` (sLv2 → 45), wrapped at `:21606`
- `revive` CD: `Sheep.cs:21378` — `this.$mTimeOut$27749 = 300 - 60 * this.$sLv$27762;` (sLv2 → 180), wrapped at `:21606`
- `revert` CD: `Sheep.cs:21395` — `this.$mTimeOut$27749 = 900;`, wrapped at `:21606` (single-rank skill, `shp_revert1` only, `SheepSkill.cs:548-578`)
- `holyLight` CD: `Sheep.cs:28256` — `this.$self_$27939.mChar.addTimeOut("holyLight", this.$self_$27939.mChar.agiAdjust(60f));` (own dedicated cast site, flat, both ranks share it)
- `lightBind` CD: `Sheep.cs:21412` — `this.$mTimeOut$27749 = 14 + 4 * this.$sLv$27762;` (sLv4 → 30), wrapped at `:21606`
- `illuminate` CD: `Sheep.cs:21429` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (sLv4 → 24), wrapped at `:21606`
- `feather` CD: `Sheep.cs:21446` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (sLv2 → 18), wrapped at `:21606`
- `allFeather` CD: `Sheep.cs:21463` — `this.$mTimeOut$27749 = 60;`, wrapped at `:21606`
- `divinitySword` CD: `Sheep.cs:21480` — `this.$mTimeOut$27749 = 45;`, wrapped at `:21606`
- `divinitySpear` CD: `Sheep.cs:21497` — `this.$mTimeOut$27749 = 60;`, wrapped at `:21606`
- `seal` CD (reported once for all 4 `sealOf*` variants; see judgment-call note): `Sheep.cs:32722` — `this.$self_$28064.mChar.addTimeOut("seal", this.$self_$28064.mChar.agiAdjust((float)12));`
- `repel` CD: `Sheep.cs:21514` — `this.$mTimeOut$27749 = 120;`, wrapped at `:21606`
- `reverse` CD: `Sheep.cs:21531` — `this.$mTimeOut$27749 = 240;`, wrapped at `:21606`
- `soulOfArms` CD: `Sheep.cs:21548` — `this.$mTimeOut$27749 = 300;`, wrapped at `:21606`
- `purifyingTear` CD: `Sheep.cs:35011` — `this.$self_$28113.mChar.addTimeOut("purifyingTear", this.$self_$28113.mChar.agiAdjust((float)480));` (own dedicated cast site, flat, single-rank `shp_purifyingTear5`)
- `lullaby` CD: `Sheep.cs:35759` — `this.$self_$28130.mChar.addTimeOut("lullaby", this.$self_$28130.mChar.agiAdjust(60f));` (own dedicated cast site, flat, single-rank `shp_lullaby5`)
- `divinityAxe` CD: `Sheep.cs:21565` — `this.$mTimeOut$27749 = 150;`, wrapped at `:21606` (single-rank `shp_divinityAxe5`)
- `edenSanctuary` CD: `Sheep.cs:36951` — `this.$self_$28162.mChar.addTimeOut("edenSanctuary", this.$self_$28162.mChar.agiAdjust(240f));` (own dedicated cast site, flat, single-rank `shp_edenSanctuary5`)
- `worldEncarta` CD: `Sheep.cs:21582` — `this.$mTimeOut$27749 = 150;`, wrapped at `:21606` (single-rank `shp_worldEncarta5`); matches the preemptive pre-arm at `Sheep.cs:89` — `this.mChar.addTimeOut("worldEncarta", this.mChar.agiAdjust(150f));`

### Duration citations
- `bless` Duration: `Sheep.cs:22824` — `this.$tChar$27789.RPC_AddStatus("bless", this.$sLv$27793 + ((!hasSkill(412)) ? 0 : 1), this.$self_$27794.mChar.chaAdjust(30), 0, ...);` (caster's own `chaAdjust`, not target-contested; flat `30` regardless of rank)
- `clear` Duration: `Sheep.cs:24881` — `this.$tChar$27847.RPC_AddStatus("clear", 2 * this.$sLv$27851 + ((!hasSkill(442)) ? 0 : 1), 1 + ((!hasSkill(442)) ? 0 : 5), 0, ...);` — base (unlearned `purify5`) = `1`, bare literal, NOT `chaAdjust`-wrapped
- `cleanse` Duration: `Sheep.cs:25375` — `this.$tChar$27860.RPC_AddStatus("cleanse", 4 + ((!hasSkill(442)) ? 0 : 1), 1 + ((!hasSkill(442)) ? 0 : 5), 0, ...);` — base = `1`, not wrapped
- `allCleanse` Duration: `Sheep.cs:25835` — `this.$tChar$27874.RPC_AddStatus("cleanse", 4 + ((!hasSkill(442)) ? 0 : 1), 1 + ((!hasSkill(442)) ? 0 : 5), 0, ...);` (AoE loop applies the same `"cleanse"` status/formula per target) — base = `1`, not wrapped
- `illuminate` Duration: `Sheep.cs:29411` — `this.$tChar$27961.RPC_AddStatus("illuminate", this.$sLv$27965 + ((!hasSkill(413)) ? 0 : 2), this.$self_$27966.mChar.chaAdjust(12), 0, ...);` (caster's own `chaAdjust`, not target-contested; flat `12` regardless of rank)
- `feather` Duration: `Sheep.cs:29889` — `this.$tChar$27974.RPC_AddStatus("feather", this.$sLv$27978, this.$self_$27979.mChar.chaAdjust(15), 0, ...);` (single-target cast; `"wing"` variant at `:29880` uses the identical `chaAdjust(15)` when `floatingWing5` is learned)
- `allFeather` Duration: `Sheep.cs:30349` — `this.$tChar$27989.RPC_AddStatus("feather", this.$sLv$27993, this.$self_$27994.mChar.chaAdjust(15), 0, ...);` (AoE cast; identical formula to `feather`, `"wing"` variant at `:30341`)
- `repel` Duration: `Sheep.cs:33209` — `this.$tChar$28072.RPC_AddStatus("repel", this.$sLv$28074, this.$self_$28075.mChar.chaAdjust(6), 0, ...);` (caster's own `chaAdjust`, not target-contested)
- `reverse` Duration: `Sheep.cs:33636` — `this.$tChar$28081.RPC_AddStatus("reverse", this.$sLv$28083, this.$self_$28084.mChar.chaAdjust(3), 0, ...);` (caster's own `chaAdjust`, not target-contested)
- `worldEncarta` Duration: `Sheep.cs:38357` — `this.$tChar$28182.RPC_AddStatus("worldEncarta", 5, this.$self_$28186.mChar.chaAdjust(9), this.$self_$28186.mChar.atk, ...);` (caster's own `chaAdjust`; 4th param is an attack-derived value, not duration)
- `sleep`, `lightBind`, `lullaby`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `heal`, `quickHeal`, `allHeal`, `pacify`, `overHeal`, `revive`, `revert`, `holyLight`, `divinitySword`,
  `divinitySpear`, `soulOfArms`, `purifyingTear`, `divinityAxe`: no usable
  Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists in the skill's own
  coroutine class body; see the bulk judgment-call note above. Duration cells are `—`.
- `seal` Duration (ground field-lifetime, not `RPC_AddStatus`): `Sheep.cs:32284` — `this.$mSealControl$28058.life = (float)this.$self_$28064.mChar.chaAdjust(60);` — see the dedicated judgment-call note above.
- `edenSanctuary` Duration (field-lifetime, bare literal): `Sheep.cs:37142` → `Sheep_edenSanctuary.cs:73` — `this.rKABs8tDiX = Time.time + (float)12;` — see the dedicated judgment-call note above.
