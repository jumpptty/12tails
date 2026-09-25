# Sheep — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

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
  support skills, to passive skills, or to an unrelated
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

---

# Damage & Mechanics


Verified from decompiled source (`DecompiledSource/Sheep.cs`, `DecompiledSource/SheepSkill.cs`) for the player-reference-tool (`12t_projects/player-reference-tool/index.html`).

---

## 1. Summary of Sheep Mechanics

- **Resource Costs & Mechanics (MP, Red SP, Blue SP)**:
  - **MP (Mana Points)**: Consumed on cast.
  - **Red SP (Stamina / Rage)**: `cSP < 0` in decompiled source (`GameGui.cs:37782`). Requires and **consumes** that amount of SP on cast (rendered in-game as Red SP: `new Color(1f, 0.2f, 0.2f)`).
  - **Blue SP (Combo / Action Requirement)**: `cSP > 0` in decompiled source (`GameGui.cs:37609`). Requires minimum SP threshold to cast, but **does not consume SP** (rendered in-game as Blue SP: `new Color(0.2f, 0.6f, 1f)`).
  - All active Sheep SP costs are Red SP (`cSP < 0`).
- **Healing & Benediction Scaling**:
  - Direct heals (`heal`, `quickHeal`, `allHeal`, `overHeal`, `revive`) scale directly with `TAL` via `mChar.talAdjust(...)`.
  - Scaled by the **Benediction** passive (+15% per rank, up to +45% at Rank 3). **The multiplier goes INSIDE `talAdjust`, on an integer-truncated base, in 32-bit floats** — `mChar.talAdjust((int)((1f + 0.15f × benedictionLv) × (float)base))` (verified 2026-09-19: `heal` `Sheep.cs:22284`, `allHeal` `:23284`, `overHeal` `:26334`, `revive` `:26864`), *not* `talAdjust(base) × (1 + 0.15×lv)`. The float32 arithmetic matters at the edges: `revive` sLv2 (base 100) at Benediction 1 truncates to **115**, whereas plain double arithmetic gives 114. Heal `sLv×15+10`, allHeal `sLv×15+10`, overHeal `sLv×30+20`, revive `sLv×50`.
  - Threat reduction via **Harmonic Diffuse** passive: `-0.15 × healAmount × harmonicDiffuseLv`.
- **Holy Arts & Divinity Damage**:
  - `holyLight`: Straight holy ray dealing `talAdjust(12 + 12×sLv)` with 1 KO knockback.
  - `overHeal`: Offensive opening strike targeting enemies at 100% full HP (`Sheep.cs:26334–26357`). Deals `talAdjust((int)((1f + 0.15f×benedictionLv) × (20 + 30×sLv)))` magic damage (`Sheep.cs:26334`) capped at `(20% + 10%×sLv) × target Max HP` (30% Max HP at R1, 40% at R2). Deals 0 damage if target is below max HP.
  - `lightBind`: Single-target root (`moveSpeed = 0`) dealing `6×sLv` flat Effect Damage every 1.0s (`CharacterControl.cs:2485-2494`, `:9345-9373`). The user confirms that the status also prevents knockback in live play (2026-09-25); the precise force-handling path has not been isolated in the decompiled client. No burst finisher.
  - `divinitySword`: Holy summon slash dealing `talAdjust(10 + 20×sLv)`, 1 KO.
  - `divinitySpear`: Piercing line thrust dealing `3 × talAdjust(10 + 15×sLv)` (3 hits), 1 KO.
  - `divinityAxe`: Divine battleaxe strike dealing `5 × talAdjust(45)` (5 hits), 2 KO.
- **Support, Blessings & Seals**:
  - `bless`: Increases all 8 core stats by `4 + 4×sLv` (+8/+12/+16/+20, or +12/+16/+20/+24 with Gospel) for 30s (`chaAdjusted`).
  - `illuminate`: Targeted restorative aura pulsing every 3s to restore `4×(sLv + 2×depLv)` HP and `sLv + 2×depLv` MP/SP for 12s (`chaAdjusted`). Grants +2 bonus ranks with Blinding Light passive (4/8/12/16 HP base, or 12/16/20/24 HP with Blinding Light).
  - `sleep` & `lullaby`: Single-target and area sleep crowd control (contested by target CHA).
  - `feather` & `allFeather`: Reduces character weight by -5/-10 (super jump/slow fall) and adds +0.25/+0.50 m/s flat run speed for 15s (`chaAdjusted`). (Does not grant AGI).
  - `seal`: Places Red / Blue ground seals for 60s.
  - `repel` & `reverse`: Tactical barriers lasting 6s / 3s (`chaAdjusted`).
  - `edenSanctuary`: 18m area field granting 50% damage reduction for 12s.
  - `worldEncarta`: Divine sanctuary for 9s (`chaAdjusted`), granting +20% of caster's ATK as flat DEF and absolute damage/debuff invulnerability.

---

## 2. Sheep Skill Reference Table

| Skill ID | Name | Max Rank | Cost (Base) | Cooldown (Base) | Cast Time (Base) | Duration (Base) | Formula / Effect | KO | Notes |
| :--- | :--- | :---: | :---: | :---: | :---: | :---: | :--- | :---: | :--- |
| `sheep_heal` | Heal | 4 | [6, 12, 18, 24] MP | [14, 16, 18, 20]s | [2, 3, 4, 5]s | — | `talAdjust(10 + 15×sLv)` | 0 | Single-target heal scaling with TAL and Benediction (+15%/rank). |
| `sheep_bless` | Bless | 4 | [8, 16, 24, 32] MP | [45, 60, 75, 90]s | [3, 4, 5, 6]s | 30s | +8/12/16/20 all stats | — | Buffs all 8 stats by `4 + 4×sLv` for 30s (`chaAdjusted`). Gospel passive fixes CD to 30s and grants +1 status level (+4 all stats). |
| `sheep_quickHeal` | Quick Heal | 2 | [12, 16] MP, [5, 8] SP (red) | 1s (unwrapped) | 0s | — | `talAdjust(10×sLv)` | 0 | Instant 3m AoE heal around caster scaling with TAL and Benediction (hits up to 5 allies, or 7 with KO Heal). |
| `sheep_allHeal` | All Heal | 2 | [34, 45] MP | [45, 60]s | [4, 5]s | — | `talAdjust(10 + 15×sLv)` | 0 | Map-wide party heal (unlimited range) scaling with TAL and Benediction. |
| `sheep_pacify` | Pacify | 2 | [10, 15] MP | [45, 60]s | [2, 3]s | — | Aggro reduction | — | Calms target enemy, reducing threat. |
| `sheep_sleep` | Sleep | 2 | [18, 21] MP | 90s | [6, 8]s | [15, 20]s | Sleep CC | — | Single-target sleep for (10 + 5×sLv)s (`chaAdjusted`, contested by target CHA). Breaks on damage. |
| `sheep_clear` | Clear | 2 | [12, 16] MP | [12, 18]s | [2, 3]s | — | Cleanse 1 debuff | — | Cleanses 1 negative status from target ally. |
| `sheep_cleanse` | Cleanse | 1 | 28 MP | 30s | 4s | — | Cleanse debuffs | — | Targeted status cleanse. |
| `sheep_allCleanse` | All Cleanse | 1 | 54 MP | 90s | 6s | — | Party cleanse | — | Cleanses debuffs from all party members. |
| `sheep_overHeal` | Over Heal | 2 | [26, 34] MP | [30, 45]s | [4, 6]s | — | `talAdjust(20 + 30×sLv)` | 0 | Offensive opening burst against full HP enemies (`hp == mhp`). Deals `talAdjust(20+30×sLv)` magic damage, capped at (20%+10%×sLv) of target Max HP (30% at R1, 40% at R2). Deals 0 damage if target `hp != mhp`. |
| `sheep_revive` | Revive | 2 | [28, 36] MP | [240, 180]s | [4, 5]s | — | `talAdjust(50×sLv)` | 0 | Resurrects fallen ally with HP scaling with TAL and Benediction. |
| `sheep_revert` | Revert | 1 | 50 MP, 50 SP (red) | 900s | 6s | — | 100% HP/MP/KO reset | — | Complete emergency recovery. |
| `sheep_holyLight` | Holy Light | 2 | [30, 40] MP, [30, 40] SP (red) | 60s | 6s | — | `talAdjust(12 + 12×sLv)` | 1 | Linear holy ray dealing magic damage with 1 KO knockback. |
| `sheep_lightBind` | Light Bind | 4 | [10, 14, 18, 22] MP | [18, 22, 26, 30]s | [2, 2.5, 3, 3.5]s | 3s | `6×(sLv+depLv)` (per 1.0s tick) | 0 | Roots target (0 moveSpeed) for 3s base (`chaAdjusted`, contested) + 1.0s fixed duration with Intense Bind. Deals 6×(sLv+depLv) effect damage/tick (up to 30 at Rank 4 with Intense Bind). |
| `sheep_illuminate` | Illuminate | 4 | [10, 14, 18, 22] MP | [15, 18, 21, 24]s | [2, 3, 4, 5]s | 12s | `+4×(sLv + 2×depLv) HP, +(sLv + 2×depLv) MP/SP` | — | Friendly HoT/MoT/SoT buff pulsing every 3s for 12s (`chaAdjusted`). +2 effective ranks with Blinding Light (12/16/20/24 HP, 3/4/5/6 MP/SP per tick). |
| `sheep_feather` | Feather | 2 | [6, 12] MP | [15, 18]s | [2, 3]s | 15s | -5/-10 weight, +0.25/0.50 spd | — | Reduces weight by -5/-10 (super jump) and increases run speed by +0.25/+0.50 m/s for 15s (`chaAdjusted`). |
| `sheep_allFeather` | All Feather | 2 | [18, 24] MP | 60s | [4, 5]s | 15s | -5/-10 weight, +0.25/0.50 spd | — | Party-wide weight reduction (-5/-10) and run speed buff (+0.25/+0.50 m/s) for 15s (`chaAdjusted`). |
| `sheep_divinitySword`| Divinity Sword | 2 | [16, 24] MP | 45s | [3, 4]s | — | `talAdjust(10 + 20×sLv)` | 1 | Forward holy slash summoned weapon strike. |
| `sheep_divinitySpear`| Divinity Spear | 2 | [24, 32] MP | 60s | [4, 5]s | — | `3 × talAdjust(10 + 15×sLv)` | 1 | Linear piercing spear thrust through enemies, striking 3 times. |
| `sheep_seal` | Seal | 1 | 10 MP | 12s | 0s | 60s | Red/Blue ground seal | — | Ground seal lasting 60s (`chaAdjusted`) for combo alignment. |
| `sheep_repel` | Repel | 2 | [14, 20] MP | 120s | [5, 4]s | 6s | Physical deflection | — | Deflection wall lasting 6s (`chaAdjusted`), absorbing 50/100 damage/hit and blocking projectiles. |
| `sheep_reverse` | Reverse | 2 | [24, 28] MP | 240s | [7, 5]s | 3s | Status inversion | — | Inversion seal lasting 3s (`chaAdjusted`), converting `50% × sLv` (50%/100%) of incoming damage to healing. |
| `sheep_soulOfArms` | Soul of Arms | 2 | [40, 55] MP, [40, 55] SP (red) | 300s | [6, 8]s | — | `6 × talAdjust(10 + 20×sLv) + talAdjust(50 + 50×sLv)` | 2 | Single-target 7-hit holy barrage: 6 rapid strikes dealing `talAdjust(10 + 20×sLv)` each (KO=2) followed by 1 heavy finisher strike dealing `talAdjust(50 + 50×sLv)` (KO=2). |
| `sheep_purifyingTear`| Purifying Tear | 1 | 25 MP, 50 SP (red) | 480s | 3s | — | Threat wipe (AoE) | — | 40m holy shockwave wiping all accumulated enemy threat/hate. |
| `sheep_lullaby` | Lullaby | 1 | 75 MP, 30 SP (red) | 60s | 9s | 6s | Area Sleep CC | — | Soothing area hymn sleeping all nearby targets for 6s (`chaAdjusted`, contested by target CHA). Breaks on damage. |
| `sheep_divinityAxe` | Divinity Axe | 1 | 54 MP | 150s | 7s | — | `5 × talAdjust(45)` | 2 | Summons a divine battleaxe, damaging enemies in the area 5 times. |
| `sheep_edenSanctuary`| Eden Sanctuary | 1 | 40 MP, 40 SP (red) | 240s | 0s | 12s | 50% dmg reduction | — | 18m sanctuary field reducing incoming damage by 50% for 12s. |
| `sheep_worldEncarta` | World Encarta | 1 | 50 MP, 50 SP (red) | 150s | 7s | 9s | Invulnerability + DEF | — | Target invulnerability barrier for 9s (`chaAdjusted`): adds +20% of caster's ATK as DEF and grants 100% immunity. |

---

## 3. Decompiled Source Citations

- **`heal`**:
  - Cast Time: `Sheep.cs:21224` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted at `:21588`).
  - Cooldown: `Sheep.cs:21229` — `this.$mTimeOut$27749 = 12 + 2 * this.$sLv$27762;` (agiAdjusted at `:21606`).
  - Healing: `Sheep.cs:22281–22290` — `talAdjust((10 + 15*sLv) * (1 + 0.15*benedictionLv))`, `RPC_AddHeal`.
- **`allHeal`**:
  - Cast Time: `Sheep.cs:21241` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21246` — `this.$mTimeOut$27749 = 30 + 15 * this.$sLv$27762;` (agiAdjusted).
  - Healing: `Sheep.cs:23850` — `talAdjust((10 + 15*sLv) * (1 + 0.15*benedictionLv))`.
- **`bless`**:
  - Cast Time: `Sheep.cs:21258` — `this.$mCastTime$27748 = (float)(2 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21263` — `this.$mTimeOut$27749 = ((!hasSkill(412)) ? (30 + 15 * sLv) : 30);` (agiAdjusted).
- **`pacify`**:
  - Cast Time: `Sheep.cs:21271` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21276` — `this.$mTimeOut$27749 = 30 + 15 * this.$sLv$27762;` (agiAdjusted).
- **`sleep`**:
  - Cast Time: `Sheep.cs:21288` — `this.$mCastTime$27748 = (float)(4 + 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21293` — `this.$mTimeOut$27749 = 90;` (agiAdjusted).
- **`clear`**:
  - Cast Time: `Sheep.cs:21305` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21310` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (agiAdjusted).
- **`quickHeal`**:
  - Cast Time: `0` (instant).
  - Cooldown: `Sheep.cs:10316` — `this.mChar.addTimeOut("quickHeal", (float)1);` (bare literal 1s).
  - Healing: `Sheep.cs:22800` — `talAdjust(10*sLv * (1 + 0.15*benedictionLv))`.
- **`overHeal`**:
  - Cast Time: `Sheep.cs:21356` — `this.$mCastTime$27748 = (float)(2 + 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21361` — `this.$mTimeOut$27749 = 15 + 15 * this.$sLv$27762;` (agiAdjusted).
  - Offensive Logic: `Sheep.cs:26334–26357` —
    - Target condition check: `if (this.$tChar$27882.hp != this.$tChar$27882.mhp) { mHeal = 0; } else { mHeal = Mathf.Min(talAdjust(...), Mathf.FloorToInt((0.2f + 0.1f * sLv) * target.mhp)); }`
    - Damage application: `RPC_AddDamage(250 + sLv, mHeal, 0, 0, Vector3.zero, caster.ActorNr)` (0 KO).
- **`revive`**:
  - Cast Time: `Sheep.cs:21373` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21378` — `this.$mTimeOut$27749 = 60 + 60 * this.$sLv$27762;` (agiAdjusted).
  - Healing: `Sheep.cs:28600` — `talAdjust(50*sLv * (1 + 0.15*benedictionLv))`.
- **`holyLight`**:
  - Cast Time: `Sheep.cs:21390` — `this.$mCastTime$27748 = (float)6;` (magAdjusted).
  - Cooldown: `Sheep.cs:21395` — `this.$mTimeOut$27749 = 60;` (agiAdjusted).
  - Damage: `Sheep.cs:29300` — `talAdjust(12 + 12*sLv)`, KO 1.
- **`lightBind`**:
  - Metadata: `shp_lightBind1-4`, skill IDs 301-304, target enemy, MP 10/14/18/22, SP 0, required Lv 3/11/19/27 and Bn 0/1/2/3 (`SheepSkill.cs:609-650`, `:2850-2892`; decoded with `scripts/decode_skilldata.py`).
  - Cast Time: `Sheep.cs:21407` — `this.$mCastTime$27748 = 1.5f + 0.5f * (float)this.$sLv$27762;` (magAdjusted).
  - Cooldown: `Sheep.cs:21412` — `this.$mTimeOut$27749 = 14 + 4 * this.$sLv$27762;` (agiAdjusted).
  - Duration: `Sheep.cs:28899` — `Damage.getDebuff(3f, casterCha, targetCha) + intenseBindLv` (3s base CHA-contested, +1s fixed uncontested from Intense Bind).
  - Intense Bind (#403, `shp_intenseBind5`) also adds 1 to the status level passed to `RPC_AddStatus` (`Sheep.cs:28898-28902`); its own metadata requires Lv 55, Bn 0, and Light Bind 4 (#304) (`SheepSkill.cs:1235-1252`, `:3291-3300`).
  - Status: `lightBind` is code 1106 (`StatusData.cs:1757-1763`), classified Debuff (`:7520`), Magical (`:5855`) and Lock (`:6166`, `:6220`); it is absent from the Buff, State, Physical and Shield predicates. The generic status tick only damages a living target and sends `RPC_AddEffectDamage(300 + sLv, 6 * sLv, 0, 0, Vector3.zero, sID)` (`CharacterControl.cs:9345-9373`), so the damage follows the Effect Damage path in [12Tails-Mechanics-Reference.md §2.9](12Tails-Mechanics-Reference.md#29-damage-routing-hit-vs-direct-rpc_adddamage-vs-rpc_addeffectdamage-verified-2026-09-24).
  - Root: `CharacterControl.cs:2491` — `this.moveSpeed = 0f;`.
  - Damage: `CharacterControl.cs:9369` — `RPC_AddEffectDamage(300 + sLv, 6 * sLv, 0, 0, Vector3.zero, sID)` (every 1.0s, deals 6×(sLv+depLv) true effect damage per tick, reaching 30 damage at Rank 4 + Intense Bind; no burst finisher).
  - **Live observation (2026-09-25):** Light Bind grants knockback immunity. Keep this player-observed behavior in the app status description; the exact force suppression route is not established by the local `moveSpeed = 0` assignment alone.
  - After cast, Sheep calls `getFreeCast("lightBind", sLv)` (`Sheep.cs:28832`). The shared Free Cast hook rolls `lckAdjust(12 × Free Cast rank)`; on success it refunds the skill's MP cost, or 125% of that cost when Return Cast (#431) is learned (`Sheep.cs:10046-10100`). These passive cards need their own `/sd` review before authoring their full descriptions.
- **`illuminate`**:
  - Cast Time: `Sheep.cs:21424` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21429` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (agiAdjusted).
  - Duration: `Sheep.cs:29411` — `this.$self_$27966.mChar.chaAdjust(12)`.
  - Status Level: `Sheep.cs:29411` — `sLv + ((!this.$self_$27966.mChar.hasSkill(413)) ? 0 : 2)` (Blinding Light passive grants +2 effective ranks).
  - Effect: `CharacterControl.cs:9402` — `this.RPC_AddHeal(1, 4 * sLv, sLv, sLv, 0, 0, sID)` pulsing every 3.0s (`global::Math.mod(2 * (sTime - sAge), 6) == 0`). Restores `4×(sLv + 2×depLv)` HP and `sLv + 2×depLv` MP/SP per tick (16 HP base at Rank 4, 24 HP with Blinding Light).
- **`feather`**:
  - Cast Time: `Sheep.cs:21441` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21446` — `this.$mTimeOut$27749 = 12 + 3 * this.$sLv$27762;` (agiAdjusted).
  - Effect: `CharacterControl.cs:39638–39644` — `weight -= 5 * sLv`, `sF2cOBZX7wK -= 5 * sLv` (jump gravity), `deltaRunSpeed(0.25f * sLv)`.
- **`allFeather`**:
  - Cast Time: `Sheep.cs:21458` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21463` — `this.$mTimeOut$27749 = 60;` (agiAdjusted).
  - Effect: `CharacterControl.cs:39638–39644` — party-wide weight reduction (-5/-10) and flat run speed (+0.25/+0.50 m/s).
- **`divinitySword`**:
  - Cast Time: `Sheep.cs:21475` — `this.$mCastTime$27748 = (float)(2 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21480` — `this.$mTimeOut$27749 = 45;` (agiAdjusted).
  - Damage: `Sheep.cs:30200` — `talAdjust(10 + 20*sLv)`, KO 1.
- **`divinitySpear`**:
  - Cast Time: `Sheep.cs:21492` — `this.$mCastTime$27748 = (float)(3 + this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21497` — `this.$mTimeOut$27749 = 60;` (agiAdjusted).
  - Damage: `Sheep.cs:31786` & `31840` — `3 × talAdjust(10 + 15*sLv)`, KO 1 per hit (3 hits).
- **`repel`**:
  - Cast Time: `Sheep.cs:21509` — `this.$mCastTime$27748 = (float)(6 - this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21514` — `this.$mTimeOut$27749 = 120;` (agiAdjusted).
- **`reverse`**:
  - Cast Time: `Sheep.cs:21526` — `this.$mCastTime$27748 = (float)(9 - 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21531` — `this.$mTimeOut$27749 = 240;` (agiAdjusted).
- **`soulOfArms`**:
  - Cast Time: `Sheep.cs:21543` — `this.$mCastTime$27748 = (float)(4 + 2 * this.$sLv$27762);` (magAdjusted).
  - Cooldown: `Sheep.cs:21548` — `this.$mTimeOut$27749 = 300;` (agiAdjusted).
  - Damage (Hits 1–6): `Sheep.cs:34255, 34305, 34355, 34405, 34455, 34505` — `talAdjust(10 + 20*sLv)`, KO 2 per hit (6 hits).
  - Damage (Hit 7 Finisher): `Sheep.cs:34555` — `talAdjust(50 + 50*sLv)`, KO 2 (1 hit).
  - Total Sequence: 7 hits, `6 × talAdjust(10 + 20×sLv) + talAdjust(50 + 50×sLv)`.
- **`divinityAxe`**:
  - Cast Time: `Sheep.cs:21560` — `this.$mCastTime$27748 = (float)7;` (magAdjusted).
  - Cooldown: `Sheep.cs:21565` — `this.$mTimeOut$27749 = 150;` (agiAdjusted).
  - Damage: `Sheep.cs:36612` & `36593` — `5 × talAdjust(45)`, KO 2 per hit (5 hits).
- **`worldEncarta`**:
  - Cast Time: `Sheep.cs:21577` — `this.$mCastTime$27748 = (float)7;` (magAdjusted).
  - Cooldown: `Sheep.cs:21582` — `this.$mTimeOut$27749 = 150;` (agiAdjusted).
  - DEF & Immunity: `Sheep.cs:38357` & `CharacterControl.cs:39883` — `deltaDef(Mathf.FloorToInt(0.2f * casterAtk))`.
- **`purifyingTear`**:
  - Cast Time: `Sheep.cs:34888` — `3.0s` (magAdjusted).
  - Cooldown: `Sheep.cs:35011` — `this.mChar.addTimeOut("purifyingTear", this.mChar.agiAdjust(480f));`.
- **`lullaby`**:
  - Cast Time: `Sheep.cs:35388` — `this.$mCastTime$28120 = this.$self_$28130.mChar.magAdjust((float)9);`.
  - Cooldown: `Sheep.cs:35500` — `60s` (agiAdjusted).
- **`edenSanctuary`**:
  - Cast Time: `0` (instant).
  - Cooldown: `Sheep.cs:36951` — `this.mChar.addTimeOut("edenSanctuary", this.mChar.agiAdjust(240f));`.
