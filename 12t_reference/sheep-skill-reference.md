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

Per-skill entries (`### shp_<name>`) are the verified 2026-09-30 pass; they take precedence over the older summary sections further down. Command numbers come from `SheepSkill.cs` `getSkillTree()`; costs and requirements were decoded with `scripts/decode_skilldata.py`.

### shp_nAttack1-2 (Combo, #101-102): light-ball projectile per stage (verified 2026-09-30)

- **Metadata:** passive, no cost; Lv 1/Bn 0 and Lv 2/Bn 0. Tooltips: #101 unlocks the 2nd attack, #102 the 3rd (`SheepSkill_eng.cs:35`, `:46`).
- **Flow (`doNormalAttack`, `Sheep.cs:9016-9280`):** `RPC_nAttack1` from standby/run; `RPC_nAttack2` needs #101, `RPC_nAttack3` needs #102, each chained from the previous stage by a timed press. Each stage coroutine (`Sheep.cs:17230`, `:17656`, `:18101`) fires **one** projectile: `RPC_homingLight_fire` with Homing Light (#401), otherwise `RPC_nAttack_fire` (`:17400`, `:17422` for stage 1), and sets `addTimeOut("nAttack", 2)`.
- **Projectile:** `RPC_nAttack_fire` sets `ProjectileControl.life = 1.7 × rangeMod` (`Sheep.cs:9303-9390`). The prefab's `ProjectileControl.velocity` is (0, 0, 12), decoded with UnityPy from the live `resources.assets` (GameObject 6065, the same 0.3 m-radius `SphereCollider` + 12 m/s layout as the Sheep-only `homingLight` prefab, GameObject 3581), so the ball travels about **20.4 m** at rangeMod 1.
- **Damage (`Sheep_nAttack.OnTriggerEnter`, `Sheep_nAttack.cs:91-330`):** `num = (int)(0.5 × ATK)`; `w_shp59` (**Holy Orb**) → `floor(0.75 × num)`; then `num = sheep.getCritPlus(num)`; `hit(1, target, num, KO 1, hate 0, 0.3 × forward)`. The projectile is destroyed on the first enemy it touches (single target). On a landed hit: `onNormalAttackHit(target)` (item on-hit effects) and `sp++`.
- **Holy Orb ally heal:** with `w_shp59`, a ball touching a same-layer character other than the Sheep is destroyed and heals it `RPC_AddHeal(1, (int)(0.35 × ATK), …)` (`Sheep_nAttack.cs:156-205`).
- **Gear crit (`getCritPlus`, `Sheep.cs:16494-16640`):** same table as Book Bash (full Marshal 12, full Champion 18) → `floor(1.8 × num)`.
- **Card:** `atkCoeff 0.5`, KO 1, hit count = rank + 1 (1 stage + one per Combo rank), `critProc` with the gear deps. Holy Orb is described, not modelled.

### shp_cAttack1-4 (Charge Attack, #111-114): charged homing ball (verified 2026-09-30)

- **Metadata:** passive, no cost; Lv 4/10/16/22, Bn 1/2/3/4. `getChargeAttackLv()` counts #111-114 (0-4) (`Sheep.cs:9693-9757`).
- **Charge / release (`Sheep.cs:9440-9757`):** `doBeginCharge` needs #111 and starts `RPC_cAttack1` (sets `actionTime = Time.time`, `myCommand = "cAttack1"`, `addTimeOut("cAttack", 1)`, `Sheep.cs:18770-18815`). `doReleaseCharge` starts `RPC_cAttack2` only when `actionTime + 2 <= Time.time`, otherwise `RPC_cAttack0` (no attack). In missions (`Game.mGameType > 4`) the clicked Player/Enemy becomes the homing target.
- **Fire (`RPC_cAttack2`, `Sheep.cs:19025-19447`):** state 2 runs 0.5 s after the release and calls `RPC_cAttack(pos + 3·up, dir, tID)`; `actionTime` is still the charge start at that moment (it is only reset in state 3).
- **Damage (`RPC_cAttack`, `Sheep.cs:9780-9900`):** `n = floor(Time.time − actionTime − 1.3)` = `floor(held − 0.8)` s; `cDmg = (int)Clamp((1 + 0.2 × BenedictionLv) × n × ATK, ATK, 100 × (Lv + OverLimit × Lv))`. `OverLimit = hasSkill(462)`, which is not a Sheep roster skill, so the cap is **100 × Lv**. A legal release (held ≥ 2 s) has n ≥ 1, so the minimum is `(1 + 0.2b) × ATK`.
- **Ball (`Sheep_cAttack.cs`):** `ProjectileControl.life = 5 × rangeMod`, speed (0, 0, 8) set in the component, turns toward the target by 0.1 rad every 0.1 s. On the first enemy: without White Burst `hit(11, target, cDmg, KO 1, 0, 0.3 × forward)`. No `getCritPlus`, so gear crit never applies.
- **Tooltip:** "(100%atk/sec, max 100/200/300/400 dmg)" (`SheepSkill_thai.cs:59-92`) matches.
- **Card:** full charge, `dmg = 100×sLv + 100×depLv` (White Burst dep), KO 1, one hit.

### shp_whiteBurst5 (White Burst, #411): Charge Attack +100 and splash (verified 2026-09-30)

- **Metadata:** passive, Lv 60/Bn 1. The decoder reports `setMPSP(… )` leftovers from a shared fall-through tail; the skill is passive and costs nothing to own.
- **Effect (`Sheep_cAttack.cs:268-330`):** on impact, the main target takes `hit(11, target, cDmg + 100, 1, 0, 0.3 × forward)`, and every other target from `FindAreaTarget(impact, 6, 6, enemyMask)` takes `hit(411, t, floor(0.4 × (cDmg + 100)), 1, 0, zero)`.
- **Tooltip discrepancy:** "Increases the limit of Sheep's charge attack to 500" (`SheepSkill_eng.cs:882`): the code adds a flat +100 to the damage at every Charge Attack rank (400 cap + 100 = 500 only at rank 4); the Thai text ("+100") is accurate.

### shp_homingLight5 (Homing Light, #401): homing Combo ball + MP (verified 2026-09-30)

- **Metadata:** passive, Lv 55/Bn 0.
- **Effect:** each Combo stage fires `RPC_homingLight_fire(pos, dir, tID)` instead of the plain ball (`Sheep.cs:17400`, `:17929`, `:18374`); `life = 1.7 × rangeMod` (`:11432-11490`). `Sheep_homingLight.cs`: speed (0, 0, 12), every 0.1 s `RotateTowards(target, 0.15 rad)`. Same damage/crit/Holy Orb code as the plain ball, plus `mp += floor(0.05 × Lv)` on a landed hit (not clamped in this code).
- **Tooltip:** "Restores 5% of Sheep's level to her mp" (`SheepSkill_eng.cs:871`) matches.

### shp_harmonicDiffuse1-4 (Harmonic Diffuse, #121-124): hate reduction (verified 2026-09-30)

- **Metadata:** passive, Lv 6/12/18/24, Bn 2/4/6/8. `getHarmonicDiffuseLv()` counts #121-124 (`Sheep.cs:9981`).
- **Attacks:** in the receiver's `RPC_AddDamage`, after `nHate = ceil(nDamage + nHate + 10 × nKo)`, a Sheep attacker with the skill gets `nHate = ceil(nHate × (1 − 0.15 × lv))` (`CharacterControl.cs:3828-3898`, junk predicates evaluated). Applies to every direct hit the Sheep lands.
- **Heals:** only Heal (`Sheep.cs:22287`) and Quick Heal (`:10440`) pass `nHate = −ceil(0.15 × heal × lv)` to `RPC_AddHeal`. `AddHeal` then adds `2 × (hp + mp + sp restored)` and, if the result is positive, gives it as hate toward the healer to every enemy within 24 m of the healed character (`CharacterControl.cs:7593-7654`). At a full restore that is `2h − 0.15·lv·h`, i.e. 7.5%/15%/22.5%/30% less heal hate. All Heal, Revive, Illuminate etc. pass 0.
- **Tooltip discrepancy:** "decreases all hate generated from Sheep by 15-60%" (`SheepSkill_eng.cs:101-134`): exact for attacks, about half that for Heal/Quick Heal, none for other heals.

### shp_karma1-4 (Karma, #361-364): damage reflection (verified 2026-09-30)

- **Metadata:** passive, Lv 22/28/34/40, Bn 12/16/20/24.
- **Effect (`CharacterControl.cs:30449-30530`, direct-damage coroutine, owner client):** `karmaLv` = highest of #361-364; if `floor(0.05 × lv × nDamage) > 0` and there is an attacker, the attacker takes `RPC_AddEffectDamage(360 + lv, floor(0.06 × lv × nDamage), 0, 0, zero, SheepActorNr)`: **6/12/18/24%** of the damage received as Effect Damage, no KO. The 5% gate only suppresses the reflect on tiny hits.
- **Tooltip:** "returns 6/12/18/24% of Sheep's receiving damage" (`SheepSkill_eng.cs:805-838`) matches.

### shp_bookBash5 (Book Bash, #434), shp_freeCast1-2 (Free Cast, #131-132), shp_returnCast5 (Return Cast, #431) (verified 2026-09-28, re-checked 2026-09-30)

- Verified in the dedicated `bookBash`, `## Free Cast` and `## Return Cast` sections below; values unchanged. The Book Bash card no longer repeats the standard +1 SP or the mission lock value (both are shown elsewhere).

### Shared cast dispatcher (verified 2026-09-30)

Heal, All Heal, Bless, Pacify, Sleep, Clear, Cleanse, All Cleanse, Over Heal, Revive, Revert, Light Bind, Illuminate, Feather, All Feather, Divinity Sword, Divinity Spear, Repel, Reverse, Soul of Arms, Divinity Axe and World Encarta go through one dispatcher that sets `castTime` and `timeOut` per skill, then `castTime = magAdjust(castTime)` and `addTimeOut(name, agiAdjust(timeOut))` (`Sheep.cs:21200-21610`). All the card cast times and cooldowns match it (checked for every skill above). Quick Heal, Holy Light, Seal, Purifying Tear, Lullaby, Eden Sanctuary and Book Bash have their own sites. Every heal coroutine below finishes with a 0.5 s recovery (`Yield(2, 0.5 s)`).

### shp_heal1-4 (Heal, #201-204): single-target heal (verified 2026-09-30)

- MP 6/12/18/24, Lv 3/11/19/27, Bn 0/1/2/3, mode target, ally. Cast `1 + sLv` s, CD `12 + 2·sLv` s.
- `RPC_heal_cast` (`Sheep.cs:21837-22435`): `mHeal = talAdjust((int)((1 + 0.15 × BenedictionLv) × (10 + 15·sLv)))`, `mHate = −ceil(0.15 × mHeal × HarmonicDiffuseLv)`, `tChar.RPC_AddHeal(1, mHeal, 0, 0, 0, mHate, …)` (`:22281-22290`). Tooltip 25/40/55/70 HP matches.
- **Radiant Heal (#402):** `FindAreaTarget(target, 8, 3, allyLayer)`; every hit other than the primary target gets `RPC_AddHeal(1, ceil(0.4 × mHeal), 0, 0, 0, ceil(mHate), …)` (`:22300-22337`).

### shp_quickHeal1-2 (Quick Heal, #221-222): instant area heal (verified 2026-09-30)

- MP 12/16, SP −5/−8 (red), Lv 7/15, Bn 2/4, mode instant. CD `addTimeOut("quickHeal", 1)`, unwrapped (`Sheep.cs:10316`); no cast time.
- `RPC_quickHeal` (`Sheep.cs:10201-10445`): `FindAreaTarget(self, 5 + (KoHeal ? 2 : 0), 3 × rangeMod, 1 << ownLayer)` (the Sheep and her allies), heal `talAdjust((int)((1 + 0.15b) × 10·sLv))`, KO `sLv` with KO Heal, hate `−ceil(0.15 × heal × HarmonicDiffuseLv)` (`:10414-10440`). Tooltip 10/20 HP matches. The old card note's "3m" was wrong.

### shp_allHeal1-2 (All Heal, #223-224): team heal (verified 2026-09-30)

- MP 34/45, Lv 23/31, Bn 6/8, mode instant. Cast `3 + sLv`, CD `30 + 15·sLv`.
- `RPC_allHeal_cast` (`Sheep.cs:22889-23361`): iterates the Sheep's team container (`transform.parent`, see [12Tails-Mechanics-Reference.md §4.6](12Tails-Mechanics-Reference.md#46-team-containers-and-team-wide-skills-gamecs)), `RPC_AddHeal(1, talAdjust((int)((1 + 0.15b) × (10 + 15·sLv))), 0, 0, KoHeal ? 10·sLv : 0, 0, …)` (`:23280-23290`). No range limit; no Harmonic Diffuse term.

### shp_overHeal1-2 (Over Heal, #251-252): full-HP penetrating strike (verified 2026-09-30)

- MP 26/34, Lv 17/24, Bn 6/10, mode target, enemy. Cast `2 + 2·sLv`, CD `15 + 15·sLv`.
- `RPC_overHeal_cast` (`Sheep.cs:25902-26431`): `mHeal = talAdjust((int)((1 + 0.15b) × (20 + 30·sLv)))`; if `tChar.hp != tChar.mhp` → 0, else `min(mHeal, floor((0.2 + 0.1·sLv) × tChar.mhp))`; `tChar.RPC_AddDamage(250 + sLv, mHeal, 0, 0, zero, …)` (`:26331-26357`) — direct damage: no `dmgAdjust`, no DEF, no KO (card flag `penetrating`). Tooltip "50/80 dmg, max 30/40% mhp" matches.

### shp_revive1-2 (Revive, #253-254) (verified 2026-09-30)

- MP 28/36, Lv 31/38, Bn 14/18, mode target, ally. Cast `3 + sLv`, CD `300 − 60·sLv` (240/180).
- `RPC_revive_cast` (`Sheep.cs:26432-26941`): `tChar.ReviveEvent(252 + sLv, talAdjust((int)((1 + 0.15b) × 50·sLv)), …)` (`:26861-26867`) → 50/100 HP. **Tooltip discrepancy:** English rank 2 says 80 HP (`SheepSkill_eng.cs:464`); code and Thai say 100.

### shp_revert1 (Revert, #264) (verified 2026-09-30)

- MP 50, SP −50 (red), Lv 40/Bn 24, mode target, ally. Cast 6 s, CD 900 s.
- `RPC_revert_cast` (`Sheep.cs:26942-27436`): `tChar.RPC_AddHeal(1, tChar.mhp, tChar.mmp, 0, tChar.mko, 0, …)` (`:27371`) — full HP, MP **and KO**, no SP. The tooltip mentions only HP and MP; the old card note ("restores the caster") was wrong — it targets an ally.

### shp_pacify1-2 (Pacify, #231, #233): hate reduction on an ally (verified 2026-09-30)

- MP 10/15, Lv 9/25, Bn 3/7, mode target, ally. Cast `1 + sLv`, CD `30 + 15·sLv`.
- `RPC_pacify_cast` (`Sheep.cs:23362-23949`): every character from `FindAreaTarget(target, 40, 6, enemyLayer)`; for its hate entry whose `ID` is the target ally, `clearHate(target, floor((0.15·sLv + 0.05) × (hate − Time.time)))` (`:23789-23842`) → **20% / 35%** of the remaining hate. Tooltip matches.

### shp_purifyingTear5 (Purifying Tear, #421): drop the Sheep's aggro (verified 2026-09-30)

- MP 25, SP −50 (red), Lv 70/Bn 3, mode instant, self. CD `agiAdjust(480)` (`Sheep.cs:35011`). **No cast time:** the input dispatch starts `RPC_purifyingTear` directly (`Sheep.cs:7461-7480`) and the coroutine has no `magAdjust`; the card's former 3 s cast time was removed.
- `RPC_purifyingTear` (`Sheep.cs:34699-35224`): state 3, 0.4 s after the press (`Yield(2, 0.2)`, `Yield(3, 0.2)`), `FindAreaTarget(self, 40, 3, enemyLayer)` → `removeHate(SheepActorNr)` on each (`:34895-34934`). Free Cast only with Return Cast (`:35014-35026`). Tooltip "removes all Sheep's hate from targets within 40m" matches.

### shp_benediction1-3 (Benediction, #261-263) (verified 2026-09-30)

- Passive, Lv 22/28/34, Bn 12/16/20. `getBenedictionLv()` (`Sheep.cs:10551`).
- Heal, Quick Heal, All Heal, Revive and **Over Heal (damage)** multiply their base by `1 + 0.15·lv` inside `talAdjust` (sites above); Illuminate does not. Charge Attack multiplies its per-second damage by `1 + 0.2·lv` (`Sheep.cs:9790-9800`), which is the tooltip's "charge attack 20/40/60% faster" (the cap is unchanged).

### shp_radiantHeal5 (Radiant Heal, #402) and shp_koHeal5 (KO Heal, #422) (verified 2026-09-30)

- Radiant Heal: Lv 55/Bn 0; the Heal splash above. Tooltip "40% within 8m around its primary target" matches (height 3, primary target excluded).
- KO Heal: see the dedicated `koHeal` section below (Quick Heal radius 7 m and KO `sLv`, All Heal KO `10·sLv`); re-checked, unchanged.

### shp_bless1-4 (Bless, #211-214) and shp_gospel5 (Gospel, #412) (verified 2026-09-30)

- Bless: MP 8/16/24/32, Lv 5/13/21/29, Bn 1/3/5/7, mode target, ally. Cast `2 + sLv`, CD `Gospel ? 30 : 30 + 15·sLv` (`Sheep.cs:21258-21263`).
- `RPC_bless_cast` (`Sheep.cs:22436-22888`): `tChar.RPC_AddStatus("bless", sLv + (Gospel ? 1 : 0), chaAdjust(30), 0, …)` (`:22824`).
- Status `bless`: code 1102 (`StatusData.cs:1702`), Buff (`:6872`) + Magical (`:5831`). Apply (`CharacterControl.cs:39130-39175`): `deltaAtk/Def/Agi/Vit/Mag/Cha/Tal/Lck(4·sLv + 4)`; for a non-player target it first sets `vit = ceil(0.1 × mhp)`. Tooltip +8/12/16/20 matches.
- Gospel: passive, Lv 60/Bn 1 (the decoder's MP 12/SP −12 is a leftover from a shared metadata tail; it is passive). **Tooltip discrepancy:** "decreases their cooldown by 70%" (`SheepSkill_eng.cs:937`): the cooldown is a flat 30 s (a 33% cut at rank 1, 67% at rank 4).

### shp_illuminate1-4 (Illuminate, #311-314) and shp_blindingLight5 (Blinding Light, #413) (verified 2026-09-30)

- Illuminate: MP 10/14/18/22, Lv 5/13/21/29, Bn 1/3/5/7, mode target, ally. Cast `1 + sLv`, CD `12 + 3·sLv`.
- `RPC_illuminate_cast` (`Sheep.cs:28975-29478`): `RPC_AddStatus("illuminate", sLv + (BlindingLight ? 2 : 0), chaAdjust(12), 0, …)` (`:29411`).
- Status `illuminate`: code (`StatusData.cs:1779`), Buff (`:6902`) + Magical (`:5867`). Tick (`CharacterControl.cs:9378-9395`): while alive, when `mod(2 × (sTime − t), 6) == 0` (every 3 s), the owner client calls `RPC_AddHeal(1, 4·sLv, sLv, sLv, 0, 0, sID)`: HP `4·sLv`, MP and SP `sLv`. No Benediction term.
- **Tooltip discrepancy:** "(15 sec)" (`SheepSkill_eng.cs:585-618`); code `chaAdjust(12)`.
- Blinding Light: passive, Lv 60/Bn 1 (decoder MP 15/SP −15 is the same leftover). Adds +2 to the Illuminate status level; tooltip matches.

### shp_feather1-2 (Feather, #321-322), shp_allFeather1-2 (All Feather, #323-324), shp_floatingWing5 (Floating Wing, #423) (verified 2026-09-30)

- Feather: MP 6/12, Lv 7/15, Bn 2/4, mode target, ally. Cast `1 + sLv`, CD `12 + 3·sLv`. All Feather: MP 18/24, Lv 23/31, Bn 6/8, mode instant. Cast `3 + sLv`, CD 60.
- Feather applies to the target (`Sheep.cs:29876-29889`); All Feather to every ally in `FindAreaTarget(self, 12 × rangeMod, 3 × rangeMod, allyLayer)` (`Sheep.cs:30306-30349`). Both: `"wing"` if Floating Wing (#423) else `"feather"`, level `sLv`, `chaAdjust(15)`.
- Status `feather` (`StatusData.cs:1768`, Buff `:6896`, Magical `:5861`): apply `weight −= 5·sLv`, jump gravity `−= 5·sLv`, `deltaRunSpeed(0.25·sLv)` (`CharacterControl.cs:39634-39644`).
- Status `wing` (`StatusData.cs:1867`, Buff `:6950`, Magical `:5891`): removes `feather` and `float`, same weight/gravity, `deltaRunSpeed(0.25·sLv + 0.25)` (`:39821-39840`). `RPC_AddStatus` rejects `feather` / `float` while `wing` is active (`:11481-11500`), and while `getStatusLv("wing") × 2 >= sLv` rejects `heavy`, `groundLock`, `needlePrison`, `sticky`, `ice`, `frost`, `lightBind`, `maim` (`:13191-13290`, `RPC_AddDamage(-83)` on block).
- **Tooltip discrepancy (Floating Wing):** English "preventing all lv.5 negative movement status" (`SheepSkill_eng.cs:992`); the block reaches level 2 × wing level (2 / 4), matching the Thai "ต่ำกว่า 5".

### shp_sleep1-2 (Sleep, #232, #234) (verified 2026-09-30)

- MP 18/21, Lv 17/33, Bn 5/9, mode target, enemy. Cast `4 + 2·sLv` (6/8), CD 90.
- `RPC_sleep_cast` (`Sheep.cs:23950-24451`): `mDuration = Damage.getDebuff(3 + 3·sLv, ownCha, targetCha)` (CHA-contested, **6 / 9 s** base), `RPC_AddStatus("sleep", sLv, mDuration, 0, …)` (`:24379-24382`). Tooltip 6/9 s matches; the card's former 15/20 s was wrong.
- Status `sleep`: code (`StatusData.cs:1713`), Debuff (`:7514`) + Magical (`:5837`). Apply (`CharacterControl.cs:39224-39240`): removes `paralysis` / `snowMan`, `actionState = "sleep"`, `moveSpeed = 0`, zzz emote. `RPC_AddStatus` rejects it while the target has `awake`, `tent`, `snowMan`, `snowBall`, `petrify` or `nightmare` (`:11385-11470`); a target wearing the Chinese Dragon Head (`c_mal37` / `c_fem37`) resists on `Random.Range(0,100) < lckAdjust(12)` (`:13758-13775`).
- **Waking:** a hit with `nDamage >= 6 × (sleepLv − 1)` removes `sleep` and gives `awake` (same level, 6 s) (Effect Damage path `CharacterControl.cs:7014-7036`; direct path `:30575-30595`). So level 1 wakes on any hit, level 2 needs 6+ damage. `awake` is Buff + System (`StatusData.cs:459`, `:4732`, `:6446`) and blocks sleep for its 6 s.

### shp_lullaby5 (Lullaby, #432): channelled area sleep (verified 2026-09-30)

- MP 75, SP −30 (red) up front, Lv 75/Bn 4, mode instant. CD `agiAdjust(60)` (`Sheep.cs:35759`).
- `RPC_lullaby` (`Sheep.cs:35225-35974`): channel `mCastTime = magAdjust(9)` with a cast bar (`:35388-35400`); it ends at `actionTime + mCastTime + 0.6` (`:35643`) or when the owner moves (`Input.GetAxisRaw` Vertical/Horizontal, `:35449-35456`).
- **Tick (`:35486-35583`):** while `mp >= 12` and `sp >= 3`, once per second: `sp −= Revised Skill ? 2 : 3`, `mp −= Revised Magic ? 9 : 12`, then `FindAreaTarget(self, 12, 6, 130816)` — every character layer, so **allies are hit too** — and each target other than the Sheep without `sleep` gets `RPC_AddStatus("sleep", 1, getDebuff(6, ownCha, targetCha), 0, …)`. The MP/SP gate uses the unreduced 12/3.
- Free Cast only with Return Cast (`:35659-35671`). Tooltip "put all friendly and hostile targets within 12m to sleep" matches.

### shp_lightBind1-4 (Light Bind, #301-304), shp_intenseBind5 (Intense Bind, #403), shp_clear1-2 (Clear, #241-242), shp_cleanse1 (Cleanse, #243), shp_allCleanse1 (All Cleanse, #244), shp_purify5 (Purify, #442) (verified 2026-09-25/28, re-checked 2026-09-30)

- Verified in the dedicated `lightBind`, `clear`, `cleanse`, `allCleanse` and `purify` sections below; cast times and cooldowns re-checked against the dispatcher. Intense Bind: +1 status level (+6 damage per tick) and +1 s after `getDebuff` (`Sheep.cs:28898-28902`). The Clear/Cleanse/All Cleanse cards no longer repeat the Purify level and duration (the status badge and duration chip show them).

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
  - `lightBind`: Single-target root (`moveSpeed = 0`) dealing `6×sLv` flat Effect Damage every 1.0s (`CharacterControl.cs:2485-2494`, `:9345-9373`). The user confirms that the status also prevents knockback in live play (2026-09-25), although its decompiled branch does not clear `myForce`; see [12Tails-Mechanics-Reference.md §4.4](12Tails-Mechanics-Reference.md#44-knockback-force-versus-movement-roots-charactercontrolcs). No burst finisher.
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
| `sheep_quickHeal` | Quick Heal | 2 | [12, 16] MP, [5, 8] SP (red) | 1s (unwrapped) | 0s | — | `talAdjust(10×sLv)` | 0 | Instant AoE heal around caster scaling with TAL and Benediction. Radius 5m (7m with KO Heal), height `3 × rangeMod`, no target cap (`Sheep.cs:10418`, `Damage.FindAreaTarget(pos, radius, height, mask)`). With KO Heal also restores `+sLv` KO. |
| `sheep_allHeal` | All Heal | 2 | [34, 45] MP | [45, 60]s | [4, 5]s | — | `talAdjust(10 + 15×sLv)` | 0 | Map-wide party heal (unlimited range) scaling with TAL and Benediction. |
| `sheep_pacify` | Pacify | 2 | [10, 15] MP | [45, 60]s | [2, 3]s | — | Aggro reduction | — | Calms target enemy, reducing threat. |
| `sheep_sleep` | Sleep | 2 | [18, 21] MP | 90s | [6, 8]s | [15, 20]s | Sleep CC | — | Single-target sleep for (10 + 5×sLv)s (`chaAdjusted`, contested by target CHA). Breaks on damage. |
| `sheep_clear` | Clear | 2 | [12, 16] MP | [12, 18]s | [2, 3]s | — | Cleanse 1 debuff | — | Cleanses 1 negative status from target ally. |
| `sheep_cleanse` | Cleanse | 1 | 28 MP | 30s | 4s | — | Cleanse debuffs | — | Targeted status cleanse. |
| `sheep_allCleanse` | All Cleanse | 1 | 54 MP | 90s | 6s | — | Team cleanse | — | Applies `cleanse` Lv4 (Purify Lv5) to every player on the caster's team, no range limit. |
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
| `sheep_bookBash` | Book Bash | 1 | 1 MP, 5 SP (red; 2 with Revised Skill) | none (mission-spawn lock `agiAdjust(60)`) | 0s | — | `getCritPlus(0.5×ATK + talAdjust(10))` | 3 | Front box 2m wide × 2m deep × 2m tall, all targets, dodgeable `hit()`. +1 SP and `onNormalAttackHit` per target hit. No Free Cast. |

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
  - **Live observation (2026-09-25):** Light Bind grants knockback immunity. Keep this player-observed behavior in the app status description. In the decompiled `ApplyMovement()` branch, `lightBind` sets only `moveSpeed = 0` (`CharacterControl.cs:2485-2495`), whereas `needlePrison` and `groundLock` also clear `myForce` (`:2358-2372`, `:2392-2406`); `MovementUpdate()` adds `myForce` independently of `moveSpeed` (`:2722`). The additional live suppression path remains unverified; see [12Tails-Mechanics-Reference.md §4.4](12Tails-Mechanics-Reference.md#44-knockback-force-versus-movement-roots-charactercontrolcs).
  - After cast, Sheep calls `getFreeCast("lightBind", sLv)` (`Sheep.cs:28832`). See the verified Free Cast and Return Cast mechanics below.
- **`bookBash`** (verified 2026-09-28):
  - Metadata: `shp_bookBash5`, skill #434, Lv 75 / Bn 4, `setMPSP(1, -5)`, instant, target enemy (`SheepSkill.cs:1441-1465`; decoded with `scripts/decode_skilldata.py`). Tooltips: `SheepSkill_eng.cs:1069`, `SheepSkill_thai.cs:1093`.
  - SP cost with Revised Skill: the generic GameGui deduction is `sp += CeilToInt(0.5 × cSP)` when `hasSkill(404)` (`GameGui.cs:37788-37797`, `:37945-37954`); its only exemptions are Mole Bombardment/Fire Barrage. So `CeilToInt(0.5 × −5) = CeilToInt(−2.5) = −2` → **2 SP**.
  - Cooldown: none per cast. `RPC_bookBash` has no `addTimeOut`; the only lock is `Start()`'s `addTimeOut("bookBash", agiAdjust(60f))` inside `while (Game.mGameType > 4)` (mission spawn, `Sheep.cs:82-86`).
  - Timing: action starts, waits 0.3s (`Sheep.cs:37893`), hits (owner client only, `:37360`), waits 0.2s (`:37896`), returns to standby (`:37470-37490`).
  - Hitbox: `Damage.FindRecTarget(pos, forward, 1, 1, 2, 2, hitLayer)` (`Sheep.cs:37373`) → 2m wide, 2m deep, 2m tall; every target in it.
  - Damage: `getCritPlus((int)(0.5f × atk + talAdjust(10)))` (`Sheep.cs:37378`), `hit(434, target, dmg, 3, 0, 0.5 × forward)` (`:37401`) → KO 3, dodgeable.
  - Per landed hit (`hit() != 0`): `RPC_bookBash_hit` VFX, `onNormalAttackHit(target)` (item on-hit effects, `:37427`), `sp += 1` (`:37437`).
  - `getCritPlus` (`Sheep.cs:16494-16640`): weapon `w_shp43/44` +5, `w_shp58` +7; armor `a_all43/44` +4, `a_all58` +6; hat `c_all43/44` +3, `c_all58` +5; `Random.Range(0,100) < lckAdjust(n)` → `FloorToInt(1.8 × nDmg)`. Same table as Wolf.

## Free Cast

- **Metadata:** `shp_freeCast1/2` are passive skills requiring Lv 32/Bn 6 and Lv 40/Bn 10 respectively, with no MP or SP cost (`SheepSkill.cs:129-147`, `:2226-2241`; decoded with `scripts/decode_skilldata.py`).
- **Proc chance:** `getFreeCastLv()` returns rank 1 for skill #131 and rank 2 for #132 (`Sheep.cs:10047-10049`). Each eligible completed cast rolls `Random.Range(0, 100) < lckAdjust(12 × rank)`, giving base values 12/24 before LCK adjustment (`Sheep.cs:10054-10076`). The English tooltip's 6%/12% values are stale and do not match the executed 12/24 inputs (`SheepSkill_eng.cs:141-156`).
- **Refund:** On success without Return Cast, the hook looks up the exact cast skill metadata and restores `skill.cMP`, making the cast's net MP cost zero (`Sheep.cs:10076-10082`, `:10111-10125`).
- **Eligible casts:** The normal hook is called after Quick Heal, Heal, Bless, All Heal, Pacify, Sleep, Clear, Cleanse, All Cleanse, Over Heal, Revive, Revert, Holy Light, Light Bind, Illuminate, Feather, All Feather, Divinity Sword, Divinity Spear, Seal, Repel and Reverse (`Sheep.cs:10402`, `:22044`, `:22779`, `:23085`, `:23694`, `:24281`, `:24783`, `:25277`, `:25738`, `:26233`, `:26763`, `:27273`, `:28044`, `:28832`, `:29306`, `:29810`, `:30279`, `:30827`, `:31544`, `:32749`, `:33143`, `:33570`). Eden Sanctuary and World Encarta also call the hook directly (`Sheep.cs:37069-37075`, `:38348-38354`).
- **Excluded MP skills:** Soul of Arms and Book Bash never call `getFreeCast`, so neither can proc Free Cast even when Return Cast is learned. Soul of Arms dispatches into its cast coroutine without a refund hook (`Sheep.cs:7975-8005`, `:33696-34588`); Book Bash likewise dispatches directly into `RPC_bookBash` (`Sheep.cs:7586-7633`, `:37224-37857`). A full-file search finds no `getFreeCast("soulOfArms", ...)` or `getFreeCast("bookBash", ...)` call. Book Bash is the special no-cooldown Lv 75/Bn 4 active documented above, not a normal skill-table entry.

## Return Cast

- **Metadata:** `shp_returnCast5` is a passive requiring Lv 75/Bn 4 and Free Cast rank 2 (#132), with no MP or SP cost (`SheepSkill.cs:1049-1069`; decoded with `scripts/decode_skilldata.py`).
- **Enhanced refund:** When Return Cast (#431) is learned, a successful Free Cast restores `FloorToInt(1.25 × skill.cMP)` instead of the exact cost, for a net MP gain of 25% subject to integer truncation (`Sheep.cs:10085-10101`).
- **Class-C access:** Purifying Tear, Lullaby and Divinity Axe only call `getFreeCast(..., 5)` when Return Cast is learned (`Sheep.cs:35014-35026`, `:35659-35671`, `:36356-36368`). This matches the tooltip's stated Class-C unlock (`SheepSkill_eng.cs:900-904`).
- **Later skills:** Eden Sanctuary and World Encarta call Free Cast without a Return Cast gate, so they remain eligible even without this passive (`Sheep.cs:37069-37075`, `:38348-38354`).
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

- **`clear`**:
  - Cast Time: `Sheep.cs:21305` — `this.$mCastTime$27748 = (float)(1 + this.$sLv$27762);` (Rank 1: 2.0s, Rank 2: 3.0s, magAdjusted via `:21588`).
  - Cooldown: `Sheep.cs:21310` — `this.$mTimeOut$27749 = 6 + 6 * this.$sLv$27762;` (Rank 1: 12.0s, Rank 2: 18.0s, agiAdjusted via `:21606`).
  - Resource Cost: Rank 1: 12 MP / 0 SP (`SheepSkill.cs:388`), Rank 2: 16 MP / 0 SP (`SheepSkill.cs:395`).
  - Requirements: Rank 1: Lv 12 / Bn 4 (`SheepSkill.cs:383`), Rank 2: Lv 20 / Bn 8 (`SheepSkill.cs:1652`).
  - Status Effect: `Sheep.cs:24881` — `RPC_AddStatus("clear", 2 * sLv + ((!hasSkill(442)) ? 0 : 1), 1 + ((!hasSkill(442)) ? 0 : 5), 0, casterActorNr)`.
    - Classification: `StatusData.cs:6036` & `6203` — `"Buff, Magical"` (`isBuffStatus == true`, `isMagicalStatus == true`, nCode `1103`).
    - Base Status Level: Rank 1 = Lv. 2, Rank 2 = Lv. 4 (with Purify: Rank 1 = Lv. 3, Rank 2 = Lv. 5).
    - Base Duration: Flat 1.0s uncontested (with Purify: flat 6.0s uncontested, unwrapped).
  - Mechanics on Target:
    - **On-Cast Cleanse:** `CharacterControl.cs:39387-39405` immediately iterates `mStatusList` and removes all active Physical Debuffs (`isPhysical() && isDebuff()`) with `status.sLv <= clear.sLv`.
    - **Active Immunity Ward:** `CharacterControl.cs:12997-13023` checks `if (getStatusLv("clear") >= sLv)` when any new status is added. If `StatusData.isPhysicalStatus(sType) && StatusData.isDebuffStatus(sType)`, it calls `RPC_AddDamage(-83, ...)` to block/immunize the target against the incoming debuff for the duration.
  - Free Cast hook: `Sheep.cs:24783` — `this.getFreeCast("clear", this.$sLv$27851);`.

- **`cleanse`**:
  - Cast Time: `Sheep.cs:21321` — `this.$mCastTime$27748 = (float)4;` (magAdjusted via `:21588`).
  - Cooldown: `Sheep.cs:21327` — `this.$mTimeOut$27749 = 30;` (agiAdjusted via `:21606`).
  - Resource Cost: 28 MP / 0 SP, Lv 28 / Bn 12, `mode: target`, `target: ally` (`shp_cleanse1`, decoded from `SheepSkill.cs`).
  - Tooltip: `SheepSkill_eng.cs:406` — "Cast a spell that removes all lv.4 negative status from a taget." (Thai `SheepSkill_thai.cs:430`: "รักษาอาการผิดปกติที่เลเวลต่ำ กว่า 5 ทั้งหมดของเป้าหมาย").
  - Status Effect: `Sheep.cs:25375` — `RPC_AddStatus("cleanse", 4 + ((!hasSkill(442)) ? 0 : 1), 1 + ((!hasSkill(442)) ? 0 : 5), 0, casterActorNr)`.
    - Classification: `StatusData.cs:5849` (`isMagicalStatus`) & `:6884` (`isBuffStatus`) — `"Buff, Magical"`, nCode `1104` (`:1735`, `:4021`).
    - Status Level: Lv. 4 (with Purify: Lv. 5). Duration: flat 1.0s (with Purify: flat 6.0s), uncontested, unwrapped.
  - Mechanics on Target (differs from Clear: covers **Physical and Magical** debuffs, Clear covers Physical only):
    - **On-Cast Cleanse:** `CharacterControl.cs:39458-39545` iterates `mStatusList` and removes every status with `status.sLv <= cleanse.sLv` that is `(isPhysical() || isMagical()) && isDebuff()`.
    - **Active Immunity Ward:** `CharacterControl.cs:13024-13050` — while `getStatusLv("cleanse") >= sLv`, any incoming status that is `(isPhysicalStatus || isMagicalStatus) && isDebuffStatus` is blocked with `RPC_AddDamage(-83, ...)`.
  - Free Cast hook: `Sheep.cs:25277` — `this.getFreeCast("cleanse", this.$sLv$27864);`.
  - Other source: War Flag's area pulse (`Sheep.cs:42709`) also applies `RPC_AddStatus("cleanse", 4, 1, ...)` to allied players hit by its `Damage.FindAreaTarget` pulse (fixed values, no Purify bonus).

- **`allCleanse`**:
  - Cast Time: `Sheep.cs:21333-21338` — `this.$mCastTime$27748 = (float)6;` (magAdjusted via `:21588`).
  - Cooldown: `Sheep.cs:21344` — `this.$mTimeOut$27749 = 90;` (agiAdjusted via `:21606`).
  - Resource Cost: 54 MP / 0 SP, Lv 36 / Bn 16, `mode: instant`, `target: ally` (`shp_allCleanse1`, decoded from `SheepSkill.cs`).
  - Tooltip: `SheepSkill_eng.cs:417` — "Cast a spell that removes all lv.4 negative status from all players in the same team." (Thai `SheepSkill_thai.cs:441`: "รักษาอาการผิดปกติที่เลเวลต่ำ กว่า 5 ทั้งหมดของเพื่อนในทีม").
  - Dispatch: `Sheep.cs:20364` — `RPC_allCleanse_cast(...)`. Free Cast hook: `Sheep.cs:25738` — `getFreeCast("allCleanse", sLv)`.
  - Targets: `Sheep.cs:25756-25775` iterates `self.gameObject.transform.parent` and keeps children tagged `"Player"`. Characters are parented under `"Team" + (layer - 7)` (`Game.cs:2924-2926`), so this reaches **every player on the caster's team, caster included, with no range or party limit** (see [12Tails-Mechanics-Reference.md §4.6](12Tails-Mechanics-Reference.md#46-team-containers-and-team-wide-skills-gamecs)).
  - Status Effect: `Sheep.cs:25835` — the same `"cleanse"` status as Cleanse, applied per target from the caster's client only (`isMine`): Lv. 4 (Purify: Lv. 5), flat 1.0s (Purify: flat 6.0s), unwrapped. Removal and immunity behavior: see `cleanse` above.

- **`koHeal`**:
  - Metadata: `shp_koHeal5`, skill #422 (`SheepSkill.cs:3262`), passive, Lv 70 / Bn 3, 0 MP / 0 SP. Prerequisite `rSkill: 224` = All Heal Lv 2 (`SheepSkill.cs:1151-1165`, `:2642`).
  - Tooltip: `SheepSkill_eng.cs:945` — "Increases range of QuickHeal by 2m. Also makes QuickHeal and AllHeal able to remove some ko damage from targets." (Thai `SheepSkill_thai.cs:969`: "เพิ่มระยะให้ quickHeal และทำให้ quickHeal และ allHeal ช่วยรักษาค่า ko ตามระดับเลเวล").
  - Passive Hooks (`hasSkill(422)`, the only two in `Sheep.cs`):
    - **Quick Heal (`Sheep.cs:10319-10440`):** radius `5 + 2` = 7m in `Damage.FindAreaTarget(pos, 5 + (flag ? 2 : 0), 3 × rangeMod, layerMask)` (`:10418`); `nKo = sLv` (+1 / +2 KO) passed to `RPC_AddHeal` (`:10423-10440`); swaps the cast effect to the `koHeal` prefab (`:10320-10330`).
    - **All Heal (`Sheep.cs:23289`):** `RPC_AddHeal(1, mHeal, 0, 0, hasSkill(422) ? 10 * sLv : 0, 0, ...)` → +10 / +20 KO per target.
  - KO restore: `CharacterControl.AddHeal` does `ko += nKo` capped at `mko` (`CharacterControl.cs:7576-7580`), refilling the KO pool (`mko = floor(DEF/3) + 10`, see [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md)).
  - `Damage.FindAreaTarget` (`Damage.cs:963`): 2nd arg is the horizontal radius measured to the target's collider edge (`sqrMagnitude < TargetRange²`), 3rd arg is the vertical band height; only the height carries `rangeMod` at this call site.

- **`purify`**:
  - Metadata: `shp_purify5` is a passive requiring Lv 85 / Bn 6 and All Cleanse (`rSkill: 244`, `SheepSkill.cs:1218, 1228`), with 0 MP / 0 SP cost (`mode = eSkillMode.passive;`, `:1223`).
  - Tooltip: `SheepSkill_eng.cs:892` — "Increases Clear and Cleanse's level by 1 and prolongs their effects to 6 seconds." (Thai: "เพิ่มระยะเวลาของ Clear กับ Cleanse เป็น 6วิ และ เพิ่มระดับการรักษาขึ้น 1 ระดับ").
  - Passive Hooks (`hasSkill(442)`):
    - **Clear (`Sheep.cs:24881`):** Increases status level by +1 (`sLv = 2*rank + 1`) and extends duration to flat 6s (`1 + 5`).
    - **Cleanse (`Sheep.cs:25375`):** Increases status level by +1 (`sLv = 4 + 1 = 5`) and extends duration to flat 6s (`1 + 5`).
    - **All Cleanse (`Sheep.cs:25835`):** Increases status level by +1 (`sLv = 4 + 1 = 5`) and extends duration to flat 6s (`1 + 5`).

