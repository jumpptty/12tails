# Wolf — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| braveSpirit | Brave Spirit | 4 | 30 | true | false | 15 | true |
| crusader | Crusader | 4 | 30 | true | false | — | — |
| powerBreak | Power Break | 2 | 30 | true | false | — | — |
| armorBreak | Armor Break | 2 | 30 | true | false | — | — |
| secondWind | Second Wind | 1 | 300 | true | false | — | — |
| crossBreak | Cross Break | 3 | 60 | true | false | — | — |
| grandCross | Grand Cross | 1 | 120 | true | false | — | — |
| massResurrection | Mass Resurrection | 2 | 600 | true | false | — | — |
| bladeFang | Blade Fang | 3 | 30 | true | false | — | — |
| provoke | Provoke | 2 | 60 | true | false | — | — |
| artCancel | Art Cancel | 2 | 60 | true | false | — | — |
| counter | Counter | 2 | 30 | true | false | — | — |
| feralStrike | Feral Strike | 4 | 30 | true | false | — | — |
| bladeSong | Blade Song | 3 | 120 | true | false | — | — |
| darkEdge | Dark Edge | 4 | 120 | true | false | 8 | true |
| lunarEclipse | Lunar Eclipse | 2 | 300 | true | false | 15 | true |
| thirdRend | Third Rend | 1 | 30 | true | false | — | — |
| holySword | Holy Sword | 1 | 240 | true | false | 24 | true |
| holyArmor | Holy Armor | 1 | 240 | true | false | 24 | true |
| mirrorBlade | Mirror Blade | 1 | 120 | true | false | — | — |
| feralAssault | Feral Assault | 1 | 180 | true | false | — | — |
| dualBrand | Dual Brand | 1 | 120 | true | false | — | — |
| twinResonance | Twin Resonance | 1 | 240 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Wolf's own thematic `obsidianFang`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Wolf.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Wolf.cs:9613`), `psalmOfEnergy`
  (`:9856`), `seaAegis` (`:10025`), `zephyrLore` (`:10219`), `replenishment` (`:10320`),
  `elementalBound` (`:10450`), `astralShift` (`:10599`), `bloodCarnage` (`:10790`), `obsidianFang`
  (`:37982`), `assassinate` (`:38438`), `mineWalker` (`:38835`), `divineChannel` (`:39195`) — all 12
  present, all bare-`600`. A direct grep of `WolfSkill.cs` for `obsidianFang` (Wolf's own
  thematically-named support skill) returns zero matches, confirming it isn't part of Wolf's own
  learnable-skill roster (`getSkill()`). All 12 excluded.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.**
  `wlf_nAttack1`/`wlf_nAttack2` `goto IL_25A8` (`WolfSkill.cs:45`, `:53`) → `IL_1E88`
  (`:2198-2219`: `mode = passive; target = enemy; cType = "nAttack"`); `wlf_cAttack1`/`wlf_cAttack2`
  `goto IL_2797` (`:73`, `:81`) → `IL_D34` (`:2168-2189`: same shape, `cType = "cAttack"`). Live cast
  sites: `Wolf.cs:7506` (`addTimeOut("nAttack", 1f)`) plus per-combo-stage `1.5f` variants
  (`:15435`, `:15760`, `:16482`, `:17179`), and `Wolf.cs:18727` (`addTimeOut("cAttack", 1f)`). Excluded
  regardless of the `mode=passive` metadata quirk, per the blanket rule.
- **`mount` is not a Wolf class skill — excluded, not a judgment call.** `Wolf.cs:43639` —
  `this.$self_$29901.mChar.addTimeOut("mount", (float)12);` — the universal ride-a-mount action shared
  by every class. `WolfSkill.cs` has no `cType`/`getSkill()` entry for `"mount"` at all.
- **Wolf active cooldowns use the class-wide `getDoubleArt()` proc check, with a Class-C exception.**
  `getDoubleArt()` (`Wolf.cs:8235-8349`) rolls `Random(0,100)` against
  `lckAdjust(learnedRank * 6)`: the proc fires `RPC_doubleArt` and returns `false`; the ordinary
  path returns `true`. Most active casts skip `addTimeOut` on a proc. **Feral Assault and Dual Brand
  require Sublime Art (#431) as well**: on a Double Art proc, their cooldown still starts if
  `hasSkill(431)` is false (`Wolf.cs:35400-35412`, `:36665-36680`). Twin Resonance needs no
  Sublime Art check (`Wolf.cs:37207-37213`). The cooldown table reports the normal base values.
- **`doubleArt1`-`4`, `statPlus1`-`4`, `weaponPlus1`-`4`, `armorPlus1`-`4`, `noKo1`-`3`, `perseverance1`-`2`,
  `feralInstinct1`-`4`, `impulse1`-`2`, `lastBlade1`, `finalEclipse1` are confirmed passives** (self-buff/
  chance-proc/equipment-scaling flavor text, `WolfSkill_eng.cs:99-120` (perseverance), `:165-208`
  (statPlus), `:341-384` (weaponPlus), `:385-428` (armorPlus), `:429-461` (noKo), `:572-615`
  (feralInstinct), `:682-703` (impulse — "automatically use Counter1..."), `:781-791` (lastBlade),
  `:858-868` (finalEclipse)), landing on shared `mode = eSkillMode.passive` tails with no `cType` in
  `WolfSkill.cs` (`doubleArt` → `IL_2D01`, `:2143-2154`; `statPlus` → `IL_F84`, `:2097-2113`;
  `weaponPlus` → `IL_2981`, `:1918-1929`; `armorPlus` → `IL_33B0`, `:1898-1909`; `noKo` → `IL_3425`,
  `:1879-1890`; `lastBlade1` own body, `:816-821`; `finalEclipse1` own body, `:902-907`), and no
  `addTimeOut`/`RPC_<name>` cast handler of their own in `Wolf.cs`. `perseverance1`/`2` do have a real,
  verified gameplay effect despite the no-`cType` classification — see the dedicated note below on why
  it's a Duration modifier for this doc's other rows rather than a skill of its own.
- **Class-C (Lv.5) passive-only skills have no row in this table** (no cooldown, duration or cast time to report), but they are *not* excluded from documentation — their mechanics belong in [wolf-skill-reference.md](wolf-skill-reference.md#class-c-passives) (`fortitude5`, `lawBringer5`, and `bloodFang5` are now written up): `continuousBlade5`, `skySlasher5`, `fortitude5`,
  `sublimeArt5`, `superStatPlus5`, `gloriousSpirit5`, `lawBringer5`, `bloodFang5`, `wildHeart5`,
  `revisedSkill5`, `revisedMagic5`, `revisedArt5` — all `mode = eSkillMode.passive` directly in their
  own `getSkill()` body (`WolfSkill.cs:920`, `:943`, `:966`, `:989`, `:1012`, `:1040`, `:1063`, `:1200`,
  `:1223`, `:1360`, `:1378`, `:1396`) with matching passive flavor text (`WolfSkill_eng.cs:869-1065`).
  `skySlasher5` does have its own `RPC_skySlasher` handler (`Wolf.cs:9113`) and its own `ActionName`
  entry, but it modifies the charge-attack (`cAttack`) combo tier via `getChargeAttackLv()`/
  `getSkySlasherLv()` (`Wolf.cs:8382-8419`), not an independently cast skill — no `wlf_skySlasher`
  entry exists in the `a2 == "wlf_..."` per-name cast dispatcher (unlike every genuine active skill
  below), confirming it's not an independently cast skill, like the rest of this group. `revisedArt5`'s own description
  ("Reduces all skills' cooldown by 12%.", `WolfSkill_eng.cs:1060`) is the mechanic the table's
  `revisedArt Exempt` column exists to model — none of Wolf's 23 active rows are exempt from it.
- **Two harmless `getSkill()` dead-code-fallthrough traps (empty rank branch landing on an unrelated
  active skill's `cType`), matching the Mole/Panda/Rabbit precedent — neither needs its own row since
  both landing skills are confirmed passive by their own flavor text.** `feralInstinct1`/`2`'s own
  bodies (`WolfSkill.cs:593-611`) are empty with no live `goto`; falling through the entire nested
  `provoke`/`artCancel`/`counter`/`impulse`/`feralStrike`/`bladeSong`/`darkEdge`/`lunarEclipse` chain
  lands on `bladeFang`'s own tail (`cType = "bladeFang"`, `WolfSkill.cs:1790`) — moot since
  `feralInstinct` is passive regardless (see above) and `bladeFang` is already correctly reported from
  its own clean ranks. `impulse1`/`2`'s own bodies (`:708-726`) are similarly empty; falling through the
  nested `feralStrike`/`bladeSong`/`darkEdge`/`lunarEclipse` chain lands on `counter`'s own tail
  (`cType = "counter"`, `:1682`) — thematically apt, since Impulse's own flavor text is literally
  "automatically use Counter1" — but still moot for the same reason; `counter` is already reported from
  its own clean ranks.
- **`lunarEclipse1`/`2` is the one genuine novel pattern found in this file: `getSkill()`'s own `cType`
  metadata is completely broken/unreachable for this skill, but the real, independent per-rank cast
  dispatch in `Wolf.cs` works correctly and has its own dedicated cooldown key — so it gets its own
  row using the real cast-site values, not folded into `darkEdge`.** Tracing `WolfSkill.cs`: both
  `lunarEclipse1` (`:867-882`, sets only `setReq`/`setMPSP`, no `goto`) and `lunarEclipse2` (`:884-889`,
  empty) fall through the entire `finalEclipse1`...`twinResonance5` chain to its final `else`
  (`:1441-1482`), which is itself gated by `if (!(skillname == "wlf_twinResonance5")) { break; }`
  (`:1443-1446`) — meaning that final `else`'s body (`:1451-1481`, `cType = "twinResonance"`) can only
  ever execute for `wlf_twinResonance5`, and *every other* name reaching this `else` (including
  `lunarEclipse1`/`2`) hits the unconditional `break` at `:1445` first and returns immediately — so the
  code visually sitting right after this construct closes (`:1483-1508`, `cType = "lunarEclipse"`) is
  itself dead/unreachable, and `lunarEclipse1`/`2` in fact resolve to whatever `darkEdge`'s own family
  resolves to one level further out (`WolfSkill.cs:1510-1552`, `cType = "darkEdge"`) via ordinary
  if/else-if exit-and-fall-through. **Despite this, `Wolf.cs` dispatches Lunar Eclipse through a
  completely separate, hardcoded per-name mechanism independent of `getSkill()`'s `cType`**: both
  `ActionName == "RPC_lunarEclipse1"`/`"RPC_lunarEclipse2"` (`Wolf.cs:2908`, `:2920`, each with their own
  network-sync ID, parallel to `RPC_darkEdge1`-`4`'s own IDs at `:2848-2895`) and
  `a2 == "wlf_lunarEclipse1"`/`"wlf_lunarEclipse2"` (`:6011`, `:6023`) route to a dedicated
  `RPC_lunarEclipse(mPos, tDir, tID, sLv)` coroutine (`Wolf.cs:9099`, class body `:31084-31554`) with its
  own `addTimeOut("lunarEclipse", ...)` (`:31326`) and `RPC_AddStatus("lunarEclipse", ...)`
  (`:31238`) — fully independent of Dark Edge's own key. Since the plan's own guidance is to verify every
  cast site independently rather than trust `getSkill()` metadata, and this skill's real, player-facing
  behavior clearly does not borrow Dark Edge's cooldown, it is reported as its own row.
- **`artCancel1`/`2` and the separately-unlocked `artBreaker5` (a Class-C skill, `rSkill = 324`,
  `WolfSkill.cs:1266`) share the same `"artCancel"` cooldown key by design — one row, reporting
  `artCancel1`/`2`'s own clean rank-2 value, matching the Panda `tigerToss`/`climbingCliff`/
  `crumblingMountain` precedent exactly.** `artCancel1`/`2` set their own `cType = "artCancel"` directly
  (`WolfSkill.cs:1709`, reached via natural fallthrough of both ranks, own `setReq`/`setMPSP`, no
  metadata bug); `artBreaker5` independently and directly sets the identical `cType = "artCancel"` in
  its own clean, unbroken branch (`:1261`, own `break` at `:1268`) — not a fallthrough trap, a real,
  intentional convergence (matching its own description, "Increase level of ArtCancel by 1",
  `WolfSkill_eng.cs:1005` — note the raw skillname there has a stray space, `"wlf_artBreaker 5"`, a typo
  in the source itself). `Wolf.cs` confirms both are separately, fully implemented: `artCancel1`/`2`'s
  own `RPC_artCancel` class re-arms `"artCancel"` at `agiAdjust(60f)` (`Wolf.cs:27623`), while
  `artBreaker5`'s own, separately-dispatched `RPC_artBreaker` class (own `ActionName`/`a2` entries,
  `:2980`, `:6165`) re-arms the *same* `"artCancel"` key at a longer `agiAdjust(120f)`
  (`Wolf.cs:34161`) once learned — i.e. learning Art Breaker swaps in a stronger, longer-recast version of
  the same action, exactly like Panda's TigerToss chain. `artCancel1`/`2` is the only member of this
  family with clean, internally-consistent `getSkill()` data, so this table reports that value; the
  120s upgrade tier is preserved here rather than invented into a second row with the same Skill ID.
- **CHA-contested Duration exclusions, per the plan's contested-duration rule.** `powerBreak`'s own
  `"powerBreak"` status: `Wolf.cs:21995` — `this.$mDuration$29392 = Damage.getDebuff((float)15,
  this.$self_$29398.mChar.cha, this.$tChar$29391.cha);`, applied at `:22005`. `armorBreak`'s own
  `"armorBreak"` status: `:22732` — `this.$mDuration$29409 = Damage.getDebuff((float)15,
  this.$self_$29415.mChar.cha, this.$tChar$29408.cha);`, applied at `:22742`. `provoke`'s own
  `"provoke"` status: `:27177` — `this.$mDuration$29492 = Damage.getDebuff((float)(6 + 3 *
  this.$sLv$29496 + 3 * this.$self_$29497.getWildHeartLv()), this.$self_$29497.mChar.cha,
  this.$tChar$29491.cha);`, applied at `:27186`. All three report Duration `—`.
- **`artCancel`'s (and `artBreaker`'s) `RPC_AddStatus("artCancel", 1, 1, 0, ...)` calls are an incidental
  target-side interrupt/stun flag, not the skill's own reportable Duration.** `Wolf.cs:27529`
  (`artCancel1`/`2`'s own cast site) and `:34036` (`artBreaker5`'s own cast site) both apply a flat,
  unwrapped 1-second `"artCancel"` status to the *target* (`this.$tChar$....RPC_AddStatus(...)`),
  matching the flavor text ("...interrupts target's action.", `WolfSkill_eng.cs:642`) — a technical
  action-cancel flag, not a duration a player experiences as a buff/debuff. Same reasoning as Panda's
  excluded `"lock"`/`"death"` incidental statuses. Duration `—`.
- **No `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists for**: `crusader`, `secondWind`,
  `crossBreak`, `grandCross`, `massResurrection`, `bladeFang`, `counter`, `feralStrike`, `bladeSong`,
  `thirdRend`, `mirrorBlade`, `feralAssault`, `dualBrand`, `twinResonance` — confirmed by a full-file
  grep of every `addTimeOut(`/`RPC_AddStatus(` call in `Wolf.cs` (90 total occurrences, all
  individually reviewed) and cross-checking each hit against these skills' own coroutine bodies; the
  remaining hits belong either to the 12 support skills, the Class-C passives above, or an unrelated
  generic minigame/consumable-item/flag-capture effects system (`wash`, `bless`, `ice`, `bubbleShield`,
  `iceShield`, `awareness`, `float`, `mpsap`, `burn`, `paralysis`, `blind`, `plague`, `frost`, `awake`,
  `yellowFlag`, `redFlag`, `cleanse`, `blueFlag`, `whiteFlag`, `happy`, `charm`, `bleed`, `heavy`,
  `mpDrain`, `hpDrain`) — none tied to any `WolfSkill.cs` roster entry, matching the same generic-effects
  block documented in the Sheep/Panda/Rabbit docs. Duration cells for all fourteen skills listed above
  are `—`.
- **`perseverance1`/`2`'s flavor text ("Passively extends the duration of all possitive status on Wolf
  by 30%/50%", `WolfSkill_eng.cs:103`, `:114`) is independently verified in code — not in `Wolf.cs` at
  all (zero hits for `perseverance` or `hasSkill(121)`/`hasSkill(122)` there), but in the shared base
  class `CharacterControl.cs`, inside `RPC_AddStatus` itself.** `CharacterControl.cs:13379-13419`:
  `if (this.Type == "Wolf") { if (this.hasSkill(121)) { int num = 1; if (this.hasSkill(122)) { num = 2; }
  if (StatusData.isBuffStatus(sType)) { sTime = Mathf.FloorToInt((1.1f + 0.2f * num) * sTime); } } }` —
  `this` is the character *receiving* the status (`RPC_AddStatus` is always invoked as
  `target.RPC_AddStatus(...)`), so this fires for any Wolf holding Perseverance who receives a buff,
  regardless of which skill (their own or an ally's) produced it. `hasSkill(121)` = `wlf_perseverance1`,
  `hasSkill(122)` = `wlf_perseverance2` (`WolfSkill.cs:2313-2333`'s `commandNum` switch) — **note IDs 121/
  122 are reused by unrelated Sheep/Penguin mechanics elsewhere in this same file
  (`CharacterControl.cs:3828-3862` gated `Type=="Sheep"`, `:23063-23098` gated `Type=="Penguin"`); only
  the `Type=="Wolf"`-gated occurrence above is Perseverance.** Multiplier: rank 1 → `1.1+0.2*1 = 1.3`
  (matches "+30%"), rank 2 → `1.1+0.2*2 = 1.5` (matches "+50%"); unlearned, the whole block is skipped
  (×1, no change). Applies via `Mathf.FloorToInt` (floor, not `chaAdjust`'s `Ceil`) to `sTime`, which is
  the duration value the caller already computed (typically already `chaAdjust`-wrapped) — i.e. this is a
  **second, later multiplicative step on top of the fully-adjusted duration**, not a change to the raw
  base fed into `chaAdjust`. Confirmed applicable to all five of this table's Duration-bearing skills by
  checking `StatusData.isBuffStatus()` (`StatusData.cs:6323-7171`) for each of their status names:
  `"valor"` (`:6464`), `"darkEdge"` (`:6470`), `"lunarEclipse"` (`:6476`), `"holySword"` (`:6482`),
  `"holyArmor"` (`:6488`) — all five `break` (return `true`). This relationship is encoded in the lookup
  tool's data as a `dep` with `kind:"postMultiply"` (`12t_projects/player-reference-tool/index.html`),
  distinct from Rabbit's `medicalEnhancement`/`alchemistLab` `dep`s (which add to the pre-`chaAdjust` raw
  value instead) — see that spec's addendum for why the two need different `kind`s.
- **`grandMark` (`Wolf.cs:8578`, `RPC_grandMark`) and `wlf_resurrect1`-`3` (a leftover/legacy name in the
  `a2 == "wlf_..."` per-name dispatcher, `Wolf.cs:6032-6058`) are not independent skills — excluded, not
  judgment calls.** `grandMark` is Cross Break's own ground-marker visual effect (placed by Cross Break,
  consumed by Grand Cross), with no `addTimeOut`/`getSkill()` roster entry of its own. `wlf_resurrect1`-
  `3` appears only in the `a2==` combo-counter table (a `num2++` increment, no matching `addTimeOut`,
  `RPC_resurrect` handler, or `WolfSkill.cs` roster entry anywhere in either file) — a naming
  inconsistency/vestigial leftover from an earlier revision of what is now `massResurrection`, not a
  separately castable skill.

### CD citations
- `braveSpirit` CD: `Wolf.cs:20582` — `this.$self_$29365.mChar.addTimeOut("braveSpirit", this.$self_$29365.mChar.agiAdjust(30f));` (flat, all 4 ranks share this cast site)
- `crusader` CD: `Wolf.cs:21350` — `this.$self_$29381.mChar.addTimeOut("crusader", this.$self_$29381.mChar.agiAdjust(30f));`
- `powerBreak` CD: `Wolf.cs:22099` — `this.$self_$29398.mChar.addTimeOut("powerBreak", this.$self_$29398.mChar.agiAdjust(30f));`
- `armorBreak` CD: `Wolf.cs:22836` — `this.$self_$29415.mChar.addTimeOut("armorBreak", this.$self_$29415.mChar.agiAdjust(30f));`
- `secondWind` CD: `Wolf.cs:23366` — `this.$self_$29423.mChar.addTimeOut("secondWind", this.$self_$29423.mChar.agiAdjust(300f));` (single-rank `wlf_secondWind1`)
- `crossBreak` CD: `Wolf.cs:24066` — `this.$self_$29436.mChar.addTimeOut("crossBreak", this.$self_$29436.mChar.agiAdjust(60f));`
- `grandCross` CD: `Wolf.cs:24599` — `this.$self_$29449.mChar.addTimeOut("grandCross", this.$self_$29449.mChar.agiAdjust(120f));` (single-rank `wlf_grandCross1`)
- `massResurrection` CD: `Wolf.cs:25260` — `this.$self_$29463.mChar.addTimeOut("massResurrection", this.$self_$29463.mChar.agiAdjust(600f));`
- `bladeFang` CD: `Wolf.cs:26381` — `this.$self_$29482.mChar.addTimeOut("bladeFang", this.$self_$29482.mChar.agiAdjust(30f));`
- `provoke` CD: `Wolf.cs:27017` — `this.$self_$29497.mChar.addTimeOut("provoke", this.$self_$29497.mChar.agiAdjust(60f));`
- `artCancel` CD (reported, `artCancel1`/`2`'s own value; see judgment-call note for `artBreaker5`'s shared-key 120s upgrade): `Wolf.cs:27623` — `this.$self_$29514.mChar.addTimeOut("artCancel", this.$self_$29514.mChar.agiAdjust(60f));`; `artBreaker5`'s own re-arm: `Wolf.cs:34161` — `this.$self_$29667.mChar.addTimeOut("artCancel", this.$self_$29667.mChar.agiAdjust(120f));`
- `counter` CD: `Wolf.cs:28686` — `this.$self_$29545.mChar.addTimeOut("counter", this.$self_$29545.mChar.agiAdjust(30f));` (inside the dedicated `RPC_counter2` handler — the rank-2/max-rank cast site; `counter1`/`counter2` are separate coroutines, not one sLv-parameterized class)
- `feralStrike` CD: `Wolf.cs:29452` — `this.$self_$29566.mChar.addTimeOut("feralStrike", this.$self_$29566.mChar.agiAdjust(30f));`
- `bladeSong` CD: `Wolf.cs:30311` — `this.$self_$29585.mChar.addTimeOut("bladeSong", this.$self_$29585.mChar.agiAdjust(120f));`
- `darkEdge` CD: `Wolf.cs:30893` — `this.$self_$29595.mChar.addTimeOut("darkEdge", this.$self_$29595.mChar.agiAdjust(120f));`
- `lunarEclipse` CD: `Wolf.cs:31326` — `this.$self_$29605.mChar.addTimeOut("lunarEclipse", this.$self_$29605.mChar.agiAdjust(300f));` (own dedicated cast site — see judgment-call note on why this isn't folded into `darkEdge`)
- `thirdRend` CD: `Wolf.cs:32529` — `this.$self_$29635.mChar.addTimeOut("thirdRend", this.$self_$29635.mChar.agiAdjust(30f));` (single-rank `wlf_thirdRend5`)
- `holySword` CD: `Wolf.cs:33235` — `this.$self_$29645.mChar.addTimeOut("holySword", this.$self_$29645.mChar.agiAdjust(240f));` (single-rank `wlf_holySword5`)
- `holyArmor` CD: `Wolf.cs:33750` — `this.$self_$29655.mChar.addTimeOut("holyArmor", this.$self_$29655.mChar.agiAdjust(240f));` (single-rank `wlf_holyArmor5`)
- `mirrorBlade` CD: `Wolf.cs:34991` — `this.$self_$29682.mChar.addTimeOut("mirrorBlade", this.$self_$29682.mChar.agiAdjust(120f));` (single-rank `wlf_mirrorBlade5`)
- `feralAssault` CD: `Wolf.cs:35492` — `this.$self_$29704.mChar.addTimeOut("feralAssault", this.$self_$29704.mChar.agiAdjust(180f));` (single-rank `wlf_feralAssault5`)
- `dualBrand` CD: `Wolf.cs:36680` — `this.$self_$29722.mChar.addTimeOut("dualBrand", this.$self_$29722.mChar.agiAdjust(120f));` (single-rank `wlf_dualBrand5`; matches the preemptive pre-arm at `Wolf.cs:90`)
- `twinResonance` CD: `Wolf.cs:37213` — `this.$self_$29730.mChar.addTimeOut("twinResonance", this.$self_$29730.mChar.agiAdjust(240f));` (single-rank `wlf_twinResonance5`; matches the preemptive pre-arm at `Wolf.cs:93`)

### Duration citations
- `braveSpirit` Duration: `Wolf.cs:20489` — `this.$tChar$29360.RPC_AddStatus("valor", this.$sLv$29364 + ((!this.$self_$29365.mChar.hasSkill(402)) ? 0 : 2), this.$self_$29365.mChar.chaAdjust(15), 0, this.$self_$29365.mChar.ActorNr);` (applied to allies in range using the caster's own `chaAdjust`, not target-contested; flat `15` regardless of rank — only the status *level* param scales with rank/`gloriousSpirit5`). Post-`chaAdjust`, further multiplied by `Perseverance` if the *receiving* ally is a Wolf with it learned — see the dedicated note above.
- `darkEdge` Duration: `Wolf.cs:30805` — `this.$self_$29595.mChar.RPC_AddStatus("darkEdge", this.$sLv$29594, this.$self_$29595.mChar.chaAdjust(this.$sLv$29594 * 2), 0, this.$self_$29595.mChar.ActorNr);` (self-cast; at max rank `sLv=4` → `chaAdjust(8)`, matching the rank-4 flavor text "for 8 seconds", `WolfSkill_eng.cs:829`). Perseverance-eligible (self-cast, so the caster's own rank applies).
- `lunarEclipse` Duration: `Wolf.cs:31238` — `this.$self_$29605.mChar.RPC_AddStatus("lunarEclipse", this.$sLv$29604, this.$self_$29605.mChar.chaAdjust(9 + 3 * this.$sLv$29604), 0, this.$self_$29605.mChar.ActorNr);` (self-cast; at max rank `sLv=2` → `chaAdjust(15)`). Perseverance-eligible.
- `holySword` Duration: `Wolf.cs:32969` — `this.$self_$29645.mChar.RPC_AddStatus("holySword", 5, this.$self_$29645.mChar.chaAdjust(24), (int)this.$nValue$29642, this.$self_$29645.mChar.ActorNr);` (self-cast; 4th param is the weapon-atk-bonus value, not duration). Perseverance-eligible.
- `holyArmor` Duration: `Wolf.cs:33484` — `this.$self_$29655.mChar.RPC_AddStatus("holyArmor", 5, this.$self_$29655.mChar.chaAdjust(24), (int)this.$nValue$29652, this.$self_$29655.mChar.ActorNr);` (self-cast; 4th param is the armor-def-bonus value, not duration). Perseverance-eligible.
- `powerBreak`, `armorBreak`, `provoke`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `artCancel`: incidental flat target-side interrupt/stun flag (`RPC_AddStatus("artCancel", 1, 1, 0, ...)`), not the skill's own duration — see judgment-call note; Duration cell is `—`
- `crusader`, `secondWind`, `crossBreak`, `grandCross`, `massResurrection`, `bladeFang`, `counter`,
  `feralStrike`, `bladeSong`, `thirdRend`, `mirrorBlade`, `feralAssault`, `dualBrand`, `twinResonance`:
  no usable Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists in the skill's
  own coroutine class body; see the bulk judgment-call note above. Duration cells are `—`.

---

# Damage & Mechanics

### wlf_powerBreak1-2 (221/223) — Power Break

- **Metadata:** Instant enemy-target attack. Rank 1 requires Lv 7/Bn 2, rank 2 Lv 19/Bn 6; MP 0, consumed red SP 10/14 (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`; ID mapping `WolfSkill.cs:2511-2537`). The normal cooldown is `agiAdjust(30)` after `getDoubleArt()` (`Wolf.cs:22093-22099`), so a successful Double Art roll skips it.
- **Area and hit:** One hit per target via `FindRecTarget` from `Wolf.position − rangeMod × forward`, half-width `1 × rangeMod`, forward range `(2 × sLv + 2) × rangeMod`, height `3 × rangeMod` (`Wolf.cs:21936`; parameter meanings `Damage.cs:1416`). At default `rangeMod = 1`, that is 2m full width, 3/5m in front, 3m high. The hit is `int(0.5 × ATK + talAdjust(15 × sLv))`, 0 KO, and `0.5 × forward` force (`Wolf.cs:21959`).
- **Status:** Only a nonzero `hit()` result reaches `RPC_AddStatus("powerBreak", ...)` (`Wolf.cs:21959-22005`). Duration is `Damage.getDebuff(15, caster.CHA, target.CHA)`; there is no `chaAdjust` wrapper (`Wolf.cs:21995`). Level is `sLv + (hasSkill(422) ? 1 : 0)` (`Wolf.cs:22000`). Application snapshots `sValue = clamp(floor(0.1 × target.ATK), 0, 15)` (`Wolf.cs:22005`); the shared handler subtracts `statusLevel × sValue` ATK and removes `atkUp`, `valor`, `enrage`, `comboPlus`, `damagePlus` (`CharacterControl.cs:34000-34019`). Removal restores that saved stat delta (`CharacterControl.cs:15083-15092`). Status code 102 is a **Physical Debuff**, not State, Magical, Lock, Buff or Shield (`StatusData.cs:547-551,5343-5345,7292-7294`; classification functions `StatusData.cs:4809,5220,5582,6133,6241,6323,7175`).
- **Client text:** EN/TH describe weapon damage and −10/20% ATK, capped at 15/30 (`WolfSkill_eng.cs:297-312`; `WolfSkill_thai.cs:330-345`). The exact calculation snapshots 10% of the target's ATK **once**, caps that snapshot at 15, then multiplies it by the applied status level; Third Rend can raise the rank-2 cap to 45.

### wlf_armorBreak1-2 (222/224) — Armor Break

- **Metadata:** Instant enemy-target attack. Rank 1 requires Lv 13/Bn 4, rank 2 Lv 25/Bn 8; MP 0, consumed red SP 10/14 (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`; ID mapping `WolfSkill.cs:2522-2548`). The normal cooldown is `agiAdjust(30)` after `getDoubleArt()` (`Wolf.cs:22830-22836`).
- **Area and hit:** One hit per target via `FindRecTarget` from `Wolf.position − rangeMod × forward`, half-width `sLv × rangeMod`, forward range `(2 × sLv + 1) × rangeMod`, height `3 × rangeMod` (`Wolf.cs:22673`; `Damage.cs:1416`). At default `rangeMod = 1`, that is 2/4m full width, 2/4m in front, 3m high. The hit is `int(0.4 × ATK + talAdjust(20 × sLv))`, 0 KO, and `0.5 × forward` force (`Wolf.cs:22696`).
- **Status:** Only a nonzero `hit()` result reaches `RPC_AddStatus("armorBreak", ...)` (`Wolf.cs:22696-22742`). Duration is `Damage.getDebuff(15, caster.CHA, target.CHA)`, without `chaAdjust` (`Wolf.cs:22732`). Level is `sLv + (hasSkill(422) ? 1 : 0)` (`Wolf.cs:22737`). Application snapshots `sValue = clamp(floor(0.1 × target.DEF), 0, 15)` (`Wolf.cs:22742`); the shared handler subtracts `statusLevel × sValue` DEF and removes `defUp`, `ironShield`, `diamondShield`, `perfectShield`, `bubbleShield`, `hardenSkin`, `salvation`, `iceShield`, `reverse`, `repel` (`CharacterControl.cs:34031-34068`). Removal restores the saved DEF delta (`CharacterControl.cs:15094-15103`). Status code 103 is a **Physical Debuff** only (`StatusData.cs:558-562,5349-5351,7298-7300`; classification functions above).
- **Client text:** EN/TH describe armor damage and −10/20% DEF, capped at 15/30 (`WolfSkill_eng.cs:319-334`; `WolfSkill_thai.cs:352-367`). The same snapshot-then-level multiplication applies; Third Rend can raise the rank-2 cap to 45.

### wlf_thirdRend5 (422) — Third Rend

- **Metadata:** Single-rank active attack, Lv 70/Bn 3, MP 10 and consumed red SP 20, prerequisite Armor Break rank 2 (`rSkill = 224`; `WolfSkill.cs:1075-1106`, decoded skill data; `WolfSkill.cs:2544-2548`). The normal cooldown is `agiAdjust(30)` after `getDoubleArt()` (`Wolf.cs:32523-32529`).
- **Active hit:** One hit per target in a forward rectangle with half-width `2 × rangeMod`, range `4 × rangeMod`, height `3 × rangeMod`, starting at Wolf's position (`Wolf.cs:32317`). At default `rangeMod = 1`: 4m wide, 4m in front, 3m high. Raw damage is:

  ```csharp
  int(0.5f * atk + talAdjust(40 + 10 *
      (target.getStatusLv("powerBreak") + target.getStatusLv("armorBreak"))))
  ```

  (`Wolf.cs:32350-32361`). It passes 0 KO and `0.5 × forward` force. Each target's **current** two status levels are read independently when hit; the cast does not itself apply either status.
- **Passive hook:** Owning skill 422 raises the level that **future** Power Break and Armor Break hits apply by one (`Wolf.cs:22000,22737`). It does not directly change their hit damage or retroactively raise existing target statuses. The Thai/English client tooltips describe both the passive status-level increase and the active hit bonus (`WolfSkill_thai.cs:979-983`; `WolfSkill_eng.cs:946-950`).

### wlf_crusader1-4 (211/212/213/214) — Crusader

- **Metadata:** Instant enemy-target attack. Ranks 1-4 require Lv 5/Bn 1, Lv 11/Bn 3, Lv 17/Bn 5, and Lv 23/Bn 7; MP costs 6/8/10/12 and blue SP thresholds 10/12/14/16 (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`; `WolfSkill.cs:233-272`). Base cooldown is `agiAdjust(30)` when `getDoubleArt()` returns true (`Wolf.cs:21344-21350`); a successful Double Art roll skips the timeout (`Wolf.cs:8310-8349`).
- **Area:** One hit per target in `Damage.FindRecTarget` with start position `Wolf.position − rangeMod × forward`, base/top half-width `2 × rangeMod`, forward `TargetRange = 4 × rangeMod`, and height `2 × rangeMod` (`Wolf.cs:21179`; argument meanings `Damage.cs:1416,1437-1464`). At default `rangeMod = 1` (`CharacterControl.cs:154`), the rectangle is 4m wide and 2m high, from 1m behind to 3m ahead of Wolf.
- **Damage and heal:** The attack passes the following to `hit()` (`Wolf.cs:21207`):

  ```csharp
  hit(210 + sLv, target,
      (int)(0.4f * atk + talAdjust(10 + 10 * sLv) + getLawBringerLv()),
      0, 0, 0.5f * forward);
  ```

  KO is 0. `getLawBringerLv()` returns 0 without Law Bringer or Wolf's current `Lv` with skill 412 (`Wolf.cs:9120-9123`), so the passive adds a flat level term **after** `talAdjust` but before the outer truncation and shared hit pipeline. For every target the coroutine retains the highest nonzero `hit()` return (`Wolf.cs:21217-21243`; `CharacterControl.cs:3673`). That return is **`netDmg` before the target's `hitMod`**, not `finalDmg` (`CharacterControl.cs:3566-3571,3765`; [global combat pipeline](12Tails-Mechanics-Reference.md#2-combat--damage-pipeline)). If the maximum is positive, Wolf receives one self-heal of `ceil(0.25 × sLv × maxDamage)` HP: 25/50/75/100% by rank, rounded up (`Wolf.cs:21254-21262`). The heal does not sum damage across targets. A target's later `hitMod` can change final HP loss without changing this returned value.
- **Client text:** EN says +25/35/45/55 damage and HP restored by the same amount (`WolfSkill_eng.cs:253-295`); TH says holy cross attack, HP restoration, and those same flat damage numbers (`WolfSkill_thai.cs:286-328`). The source instead uses `talAdjust(20/30/40/50)` plus `0.4 × ATK` and an optional Wolf-level term, while healing scales by rank from the highest `netDmg` return.

### wlf_lawBringer5 (412) — Law Bringer

- **Metadata and prerequisite:** Passive, Lv 60/Bn 1, MP/SP 0, requires Crusader rank 4 (`rSkill = 214`; `WolfSkill.cs:1052-1068`, decoded skill data; skill ID mapping `WolfSkill.cs:3149-3153`).
- **Only damage hook:** `getLawBringerLv()` returns Wolf's current level when `hasSkill(412)` (`Wolf.cs:9120-9123`), and Crusader adds it once to each target's raw hit (`Wolf.cs:21207`). It can also increase Crusader's self-heal indirectly by raising the strongest actual damage result. The passive switches Crusader's attack and hit effects (`Wolf.cs:8447-8495,21036-21085`). Both client tooltips describe a Crusader damage bonus equal to Wolf's level (`WolfSkill_eng.cs:935-939`; `WolfSkill_thai.cs:968-972`).

### wlf_bladeFang1-3 (301/302/303) — Blade Fang

- **Metadata:** Instant enemy-target attack, rank requirements Lv 3/Bn 0, Lv 9/Bn 1, Lv 15/Bn 2; MP 0 and consumed red SP 6/9/12 (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`; `WolfSkill.cs:558-590`). The cooldown is `agiAdjust(30)` only when `getDoubleArt()` returns true (`Wolf.cs:26375-26381`). Double Art's successful roll returns false and skips that timeout (`Wolf.cs:8310-8349`).
- **Hits and damage:** 2/3/4 slashes (the first hit precedes the `bladeFang_count = 0` loop; further slashes stop once the counter reaches `sLv`, `Wolf.cs:25789-25827,25933,26055,26174,26627`). Each target hit uses:

  ```csharp
  mChar.hit(300 + sLv, target,
      (int)(0.5f * mChar.atk + mChar.talAdjust(6 + sLv * 6 + (mChar.hasSkill(403) ? 6 : 0))),
      0, 0, force);
  ```

  (`Wolf.cs:25789,25996,26237`). The outer cast truncates the sum after `talAdjust`. KO is 0. Every successful hit on each target restores 1 SP (`Wolf.cs:25815,26022,26263`).
- **Blood Fang (403):** Passive, requires Lv 55/Bn 0 and Blade Fang rank 3 (`rSkill = 303`), with MP/SP 0 (`WolfSkill.cs:1189-1205`, decoded skill data). `hasSkill(403)` adds 6 **inside** the `talAdjust` term on every slash (`Wolf.cs:25789,25996,26237`). The same check changes `Damage.FindRecTarget`'s base and top half-widths from 1 to 2 and `TargetRange` from 4 to 5; `TargetHeight` stays `2 × rangeMod` (`Wolf.cs:25766,25973,26214`; parameter names `Damage.cs:1416`). Its `rangeMod`-offset starting position is unchanged. Blood Fang also selects different slash and hit visual effects (`Wolf.cs:8669-8695,25646-25716`).
- **Client text:** Blade Fang says `+12×2`, `+18×3`, `+24×4` in Thai and English (`WolfSkill_thai.cs:572-604`, `WolfSkill_eng.cs:539-571`). Blood Fang says it doubles Blade Fang's range and adds 6 damage (`WolfSkill_thai.cs:1012-1016`, `WolfSkill_eng.cs:979-983`); the source's forward-range argument is **4 → 5**, while full target-finder width doubles **2 → 4**.


## Server Balance Variations (ToT)

Private-server values are documented from the Bible skill-detail schema; BigBug source remains the original-server baseline.

| Skill | Original BigBug baseline | ToT delta |
|---|---|---|
| Cross Break | KO is 5 / 10 / 15 by rank. | KO increased to 10 / 20 / 30. |
| Grand Cross | 120s base cooldown. | Base cooldown reduced to 60s. |

Source of server deltas: `12t_projects/bible/index.html:10761,10769`.

### wlf_crossBreak1-3 (261/262/263) — active, rank family

- **Metadata:** three ranks; rank 3 is Lv 30/Bn 18, MP 35, SP -40 (red/consumed), target-enemy, `cType crossBreak` (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`). Base cooldown is `agiAdjust(60)` (`Wolf.cs:24066`).
- **Exact damage:** every target in the 5m area receives one direct hit with:
  ```csharp
  mChar.hit(260 + sLv, target,
      (int)(0.4f * mChar.atk + mChar.talAdjust(45 * sLv)),
      5 * sLv, 0, Vector3.zero);
  ```
  (`Wolf.cs:23960-23973`). The `0.4 × ATK` term is a plain float multiplication and is combined with the already-rounded `talAdjust` result before the outer C# `(int)` truncation. **It does not call `atkAdjust()`**, therefore it has no second ATK-side LCK roll. The only attacker LCK rolls are inside `talAdjust` and later `dmgAdjust` in the shared hit pipeline.
- **Rank 3 raw formula:** `int(0.4 × ATK + talAdjust(135))`; KO = 15. It continues through the shared `dmgAdjust → defAdjust → hitMod` pipeline after the `hit(...)` call.

### wlf_nAttack1-3 (Combo, skills #101-#103) — passive, 4-stage normal attack (verified 2026-09-24)

- **Metadata:** reqLv/Bn 1/0, 2/1, 3/2; MP 0, SP 0; `mode = passive`, `cType = "nAttack"` (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`).
- **Stage gating:** Combo rank `r` unlocks stage `r+1`. The dispatcher starts `RPC_nAttack2`/`3`/`4` only when `hasSkill(101)`/`(102)`/`(103)` (`Wolf.cs:7562`, `:7634`, `:7706`). Hits per full combo: rank 1 = 2, rank 2 = 3, rank 3 = 5 (stage 4 swings twice). `hasSkill(401)` (Continuous Blade) changes the direction/loop branches in the same dispatcher.
- **Damage per swing** (Feral Instinct level `F`, see below), each truncated with `(int)` and passed through `getCritPlus`:

| Stage | Raw damage | Line | `hit()` KO |
|---|---|---|---|
| 1 | `getCritPlus((int)((0.5 + 0.05·F) × ATK))` | `Wolf.cs:15144` | 1 (`:15218`) |
| 2 | same | `:15975` | 1 (`:16049`) |
| 3 | same | `:16678` | 1 (`:16752`) |
| 4, first swing | `getCritPlus((int)((0.4 + 0.04·F) × ATK))` | `:17386` | 1 (`:17468`) |
| 4, second swing | `getCritPlus((int)((0.6 + 0.06·F) × ATK))` | `:17717` | 1 (`:17786`) |

  Every swing is `mChar.hit(stage, target, hitDmg, 1, 0, ...)`, i.e. the normal `dmgAdjust → defAdjust → hitMod` pipeline (dodgeable), unless Dark Edge is on (below).
- **Hit-boxes** (`Damage.FindRecTarget`, all four numbers × `rangeMod`): stages 1, 2 and 4 start 1m behind Wolf with `BaseWidth 2, TopWidth 2, TargetRange 3, TargetHeight 2` (`:15178`, `:16009`, `:17746`), i.e. 4m wide reaching 2m ahead; stage 3 starts 1.5m behind with range 3.5 (`:16712`, also 2m ahead); stage 4's first swing has `TargetHeight 4` (`:17428`). `rangeMod` is raised by Lunar Eclipse (`+0.4×sLv`, `CharacterControl.cs:34248`).
- **SP:** a swing that lands through `hit()` gives +1 SP once per swing (not per target), or the Feral Instinct amount instead (below).
- **Weapon `w_wlf59`** (not modelled in the Bible): stages use a longer 8m box and scale damage by `FloorToInt(0.75×)` (stage 2: `CeilToInt(0.5×)`) (`:15159-15175`, `:15990-16001`).
- **`onNormalAttackHit`** (`Wolf.cs:46424+`, started only on the `hit()` path) holds item on-hit procs (happy, charm, blind, bleed, heavy, plague, heals, 666 effect damage), not skill mechanics.

### getCritPlus — equipment crit on every Combo swing (verified 2026-09-24)

`Wolf.cs:14044-14188`. Adds up a crit chance `n` from the equipped weapon, armor and accessory, then `if (Random.Range(0,100) < lckAdjust(n)) return FloorToInt(1.8 × nDmg)`, else `nDmg` (junk predicates evaluated with a script):

| Slot | Marshal ("supreme commander", Blue 43 / Red 44) | Champion (58) |
|---|---|---|
| Weapon | `w_wlf43` / `w_wlf44`: +5 | `w_wlf58`: +7 |
| Armor | `a_all43` / `a_all44`: +4 | `a_all58`: +6 |
| Accessory (hat) | `c_all43` / `c_all44`: +3 | `c_all58`: +5 |
| **Full set** | **12 → `lckAdjust(12)`** | **18 → `lckAdjust(18)`** |

The crit multiplies the truncated raw value before `hit()` (or before Dark Edge's Effect Damage). Item names: `WeaponData_eng.cs`, `ArmorData_eng.cs`, `AccessoryData_eng.cs`. The Bible's Combo card has G. Marshal Sword / G. Champion Sword toggles that assume the full set.

### wlf_feralInstinct1-4 (skills #311-#314) — passive (verified 2026-09-24)

- **Metadata:** reqLv/Bn 5/1, 11/3, 17/5, 23/7; MP 0, SP 0; passive.
- **Level:** `getFeralInstinctLv()` = Feral Instinct rank + `getWildHeartLv()` (0/1), or 0 if Feral Instinct is not learned (`Wolf.cs:8800-8848`).
- **Damage:** every Combo coefficient is `base × (1 + 0.1·F)` (`0.5+0.05F`, `0.4+0.04F`, `0.6+0.06F`), i.e. **+10% per level**: +10/20/30/40%, +50% with Wild Heart. The client tooltip says +10/15/20/25% and "+5%" for Wild Heart (`WolfSkill_eng.cs:572-615`, `:994`); the code value is what the Bible shows.
- **SP:** after a swing lands through `hit()`, `if (Random.Range(0,100) < lckAdjust(4·F)) sp += F` and the normal `+1` is skipped (`:15311-15339`, junk jump to `Block_36 → IL_225`); otherwise `sp += 1`. So the base chance is 4/8/12/16% (20% with Wild Heart; tooltip says 5-20%) and a proc gives `F` SP in place of 1 (no gain at level 1). Dark Edge swings never roll it.

### wlf_wildHeart5 (skill #413) — Class-C passive (verified 2026-09-24)

- **Metadata:** reqLv 60, reqBn 1, requires `rSkill = 314` (Feral Instinct 4) (`WolfSkill.cs:1227-1228`); MP 0, SP 0; passive.
- `getWildHeartLv() = hasSkill(413) ? 1 : 0` (`Wolf.cs:9127-9130`), used in two places:
  - Feral Instinct level +1 (above).
  - Provoke: contested duration base `6 + 3·sLv + 3·WH` (`Damage.getDebuff`, `Wolf.cs:27177`) and hate `talAdjust(60·sLv + 60·WH)` (`:27186`).

### wlf_darkEdge1-4 (Dark Edge, skills #361-#364): normal attacks become Effect Damage (verified 2026-09-24)

- **Metadata:** reqLv/Bn 24/15, 27/18, 30/21, 33/24; MP 12/19/26/33, SP 0; instant, self.
- **Cast:** `RPC_AddStatus("darkEdge", sLv, chaAdjust(2·sLv), 0, ...)` on self (`Wolf.cs:30805`), cooldown `agiAdjust(120)` behind `getDoubleArt()` (`:30887-30893`). Rank only sets the duration: `getDarkEdgeLv()` (`:8984`) is read at every Combo stage but never used.
- **Status `darkEdge`:** code 106 (`StatusData.cs:591`), `isBuffStatus` (`:6470`) and `isMagicalStatus` (`:5597`) → "Buff, Magical". Applying it removes `holySword` (`CharacterControl.cs:34159+`); applying `holySword` removes it (`:34268`); `holyWolf` (Holy Sword + Holy Armor) removes it (`:34402`). Perseverance lengthens it as a buff.
- **Branch:** each normal-attack stage reads `getStatusLv("darkEdge")` (`Wolf.cs:15074`, `:15913`, `:16616`, `:17327`). With the status off (`<= 0`) the swing is an ordinary `mChar.hit(stage, target, hitDmg, 1, 0, ...)` (`:15218`, `:16049`, `:16752`, `:17468`, `:17786`). With it on, the same swing skips `hit()` and instead calls `tChar.RPC_AddEffectDamage(363, hitDmg + Random.Range(0, CeilToInt(0.2 × LCK)), 0, 0, ...)` (`:15267`, `:16098`, `:16801`; stage 4 uses code 364 at `:17517`, `:17835`), then plays `RPC_darkEdge_hit`. `hitDmg` is the same Combo value (Feral Instinct and `getCritPlus` included).
- **Consequences of skipping `hit()`:** the swing cannot be dodged by the target's `drunken` evasion or the Water Monkey/Water Crane evasion (both live only inside `hit()`, `CharacterControl.cs:3076-3079`, `:3134-3167`), and it gets none of the target-side `hit()` checks. As Effect Damage it takes no `dmgAdjust`/`defAdjust`: only the attacker's LCK roll added here, then `hitMod` (rounded down) on the target (see the `RPC_AddEffectDamage` notes in the Mechanics Reference). KO is 0. The `hit()`-path follow-ups (`onNormalAttackHit`, `isHit`, the Feral Instinct SP roll) sit in the `<= 0` branch, so they don't run for Dark Edge swings.
- **SP under Dark Edge:** +1 per target hit instead of +1 per swing; stage 4's first swing adds +1 twice per target (`:17522` and `:17547`).
- **Blocked under `holyWolf`:** `RPC_AddStatus` refuses `darkEdge` while the receiver has `holyWolf` (see Holy Wolf block below).

### Holy Wolf (`holyWolf5`, status #110) — Fusion Status (Holy Sword + Holy Armor) (verified 2026-09-25)

- **Fusion Trigger (`CharacterControl.cs:11925-11971`):**
  - Applied when Holy Sword is used while Holy Armor is already active, OR when Holy Armor is used while Holy Sword is already active:
    ```csharp
    if (sType == "holySword")
    {
        if (this.hasStatus("holyArmor"))
        {
            sType = "holyWolf";
            sValue = (int)((float)(sValue * 1000) + this.getStatusValue("holyArmor"));
        }
    }
    if (sType == "holyArmor")
    {
        if (this.hasStatus("holySword"))
        {
            sType = "holyWolf";
            sValue = (int)(this.getStatusValue("holySword") * (float)1000 + (float)sValue);
        }
    }
    ```
- **Level & Metadata:**
  - Status Level: always **`sLv = 5`** (both Holy Sword and Holy Armor are cast at `sLv = 5`, `Wolf.cs:32969, 33484`). Displayed in-game as **`holyWolf5`** (`[holyWolf5]`).
  - Code 110 (`StatusData.cs:635`), `isBuffStatus` (`:6494`) and `isStateStatus` (`:4830`) → **"Buff, State"**.
- **Stat & Regeneration Effects (`CharacterControl.cs:34424-34427`, `:8787-8800`):**
  - **Combined ATK & DEF:** Grants `deltaAtk(Mathf.FloorToInt(sValue / 1000))` (Holy Sword bonus) and `deltaDef(Mathf.FloorToInt(sValue % 1000))` (Holy Armor bonus) simultaneously. Reversed on expiry (`:15238-15241`).
  - **Periodic Regeneration:** Every 8 seconds (`Math.mod(2f * (sTime - kNtcObrGvdk), 16f) == 0f`):
    ```csharp
    this.RPC_AddHeal(1,
        Mathf.FloorToInt(0.1f * (float)this.hp),
        Mathf.FloorToInt(0.1f * (float)this.mp),
        Mathf.FloorToInt(0.1f * (float)this.sp),
        0, 0, sID);
    ```
    Heals **+10% HP**, **+10% MP**, and **+10% SP** every 8 seconds.
- **Visuals & Model Changes (`CharacterControl.cs:34430-34616`, `:15244-15290`):**
  - Dual swords: `holyWolfSword1Fx` on `mount_Hand_L` and `holyWolfSword2Fx` on `mount_Hand_R`.
  - Armor: `holyWolfArmorFx` on `Spine1`.
  - Aura: `holyWolfFx` on Wolf root object.
  - Glowing body: swaps all mesh renderers to `Self-Illumin/Diffuse` material.
- **Exclusions & Status Blocks (`CharacterControl.cs:34406-34421`, `:11001-11053`):**
  - Upon fusion, immediately cleanses: `darkEdge`, `lunarEclipse`, `blend`, `invisible`, `holySword`, and `holyArmor`.
  - While under `holyWolf`, `RPC_AddStatus` unconditionally rejects receiving: `darkEdge`, `lunarEclipse`, `holySword`, and `holyArmor`:
    ```csharp
    if (sType == "darkEdge")     { if (this.hasStatus("holyWolf")) { break; } }   // :10995-11007
    if (sType == "lunarEclipse") { if (this.hasStatus("holyWolf")) { break; } }   // :11010-11022
    if (sType == "holySword")    { if (this.hasStatus("holyWolf")) { break; } }   // :11025-11037
    if (sType == "holyArmor")    { if (this.hasStatus("holyWolf")) { break; } }   // :11040-11052
    ```


### wlf_provoke1-2 (skills #321/#322) — active, single target (verified 2026-09-24)

- **Metadata:** reqLv/Bn 7/2, 13/4; MP 4/6, SP -4/-6 (consumed); `mode = target`, enemy.
- **Cast** (`RPC_provoke`, `Wolf.cs:26760+`): cooldown `agiAdjust(60)` behind `getDoubleArt()` (`:27011-27017`); the status lands **0.8s** after the cast (`mProvokeTime = Time.time + 0.8f`, `:27140`), on the one target:
  ```csharp
  mDuration = Damage.getDebuff(6 + 3*sLv + 3*getWildHeartLv(), mChar.cha, tChar.cha);          // :27177
  tChar.RPC_AddStatus("provoke", sLv, mDuration, mChar.talAdjust(60*sLv + 60*getWildHeartLv()), ...); // :27186
  ```
  Contested base 9 / 12s (+3 Wild Heart); hate `talAdjust(60 / 120)` (+60 Wild Heart). Client tooltips say 6/9s (both languages) and 60/90 hate (EN; TH says 60/120).
- **Status `provoke`:** `isPhysicalStatus` (`StatusData.cs:5355`) and `isDebuffStatus` (`:7310`) → "Debuff, Physical". Effects on the holder:
  - Apply: `addHate(casterID, sValue)` once (`CharacterControl.cs:34082`); `addHate` adds the raw value to the caster's hate entry (`:7746`).
  - No natural MP regen (`CharacterUpdate`, `:1923`) and no idle SP recovery toward the resting level (`:2059`).
  - `RPC_AddHeal` zeroes `nHp`, `nMp` and `nSp` (KO and hate still pass) (`:7161-7170`).
  - Pauses Panda Ashura's SP gain (`StatusUpdate`, `:8859`).

### wlf_continuousBlade5 (skill #401) — Class-C passive (verified 2026-09-24)

- **Metadata:** reqLv 55, reqBn 0; MP 0, SP 0; passive (`WolfSkill.cs:915-920`).
- **Effect** (combo dispatcher, `Wolf.cs:7540-7805`): with `hasSkill(401)` each next stage is started toward the input direction (`vector2`) instead of `HwwoC6K6XP.forward`, and after stage 4 the dispatcher starts `RPC_nAttack5`, which only restarts `RPC_nAttack1` (`:18219`), so the combo loops. No damage change.

### wlf_lunarEclipse1-2 (skills #371/#372) — active, self (verified 2026-09-24)

- **Metadata:** reqLv/Bn 35/23, 40/25; MP 20, SP -45/-60 (consumed); instant, self. (See the judgment-call note above on its broken `getSkill()` `cType`; the cast itself dispatches through `RPC_lunarEclipse`.)
- **Cast** (`Wolf.cs:31084+`): `RPC_AddStatus("lunarEclipse", sLv, chaAdjust(9 + 3*sLv), 0, ...)` on self (`:31238`) → 12 / 15s; cooldown `agiAdjust(300)` behind `getDoubleArt()` (`:31320-31326`). Client tooltips say 12/17s (EN) and 14/17s (TH).
- **Status `lunarEclipse`:** code 107 (`StatusData.cs:602`), `isBuffStatus` (`:6476`) and `isStateStatus` (`:4824`) → "Buff, State"; Wolf only (`CharacterControl.cs:12094`); Perseverance-eligible; blocked and removed by `holyWolf` (above).
  - Apply (`:34241`): `moveMod += 0.4·sLv`, `rangeMod += 0.4·sLv`, colour black. Removal (`:15143`) reverses both.
  - `rangeMod` multiplies the `FindRecTarget`/area sizes of: Combo stages 1-4, Charge Attack (`RPC_cAttack2`), Counter (`RPC_counter2`), Armor Break, Power Break, Art Cancel, Blade Fang, Blade Song, Brave Spirit, Crusader, Cross Break, Feral Strike, Sky Slasher, Third Rend (every `rangeMod` read in `Wolf.cs`, the rest being item/pet code).

### wlf_weaponPlus1-4 (#231-#234) and wlf_armorPlus1-4 (#241-#244) — passive, equipment stat bonus (verified 2026-09-25)

- **Where:** `CharacterDataClass.updateData()` (`CharacterDataClass.cs:272`), inside `if (this.Type == "Wolf")` (`:431`), right after every equipped item's `att[i]` is added to `statList` (`:384-423`). `updateData()` writes `statList` back with `setStatString(statList)` (`:982`), which is the `stat` string `getStat()` reads (`:1216-1256`) for the in-combat stats, so the bonus is a real stat gain. The IDs 231-234 / 241-244 are reused by other classes (e.g. Cat's Power One-Seven are 241-244), which is why the check sits behind the Wolf type test.
- **Weapon Plus** (`:442-519`): `n` = highest rank learned (4/3/2/1). If `equipment[0]` (weapon) is not `"none"`, each of the 8 stats gets `+floor(0.1 × n × (itemData.att[i] + equipment[0].att[i]))`.
- **Armor Plus** (`:536-613`): the same, reading **only `equipment[1]` (armor)**: `+floor(0.1 × n × (itemData.att[i] + equipment[1].att[i]))`, i.e. +10/20/30/40% of the armor's stats.
- **Accessory, boots, trinket and pet get nothing** from either passive: no other slot index is read here, and no other `hasSkill(231-234)`/`hasSkill(241-244)` in the source is Wolf-gated (the rest are other classes' skills sharing those IDs). Slot indices: `[0]` weapon, `[1]` armor, `[2]` accessory, `[3]` boot, `[4]` trinket, `[5]` pet ([12Tails-Mechanics-Reference.md §5.2](12Tails-Mechanics-Reference.md#52-equipment-slots-6--charactercontrolcs14821497)).
- **What counts:** the 8 base stats only (`att[0..7]`), from both the item's own stats (`ItemData.getItemData(name).att`) and that equipped copy's extra `att` (`equipment[1].att`). The item's flat `hp`/`mp`/`sp`/`ko` bonuses are not scaled. Each stat is floored separately, e.g. armor DEF +7 at rank 4 → `floor(0.4 × 7) = 2`.
- **Tooltip:** EN "Passively increases all basic stats of any equiped armor by 10/20/30/40%." (`WolfSkill_eng.cs:385-428`), which matches the code.

### wlf_perseverance1-2 (#121/#122) — passive, rank family (verified 2026-09-25)

- **Metadata:**
  - Rank 1 (`wlf_perseverance1`, commandNum 121): reqLv 6, reqBn 2, MP 0, SP 0, mode passive, no cType (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`, `WolfSkill.cs:94-105`, `:2313-2323`).
  - Rank 2 (`wlf_perseverance2`, commandNum 122): reqLv 12, reqBn 4, MP 0, SP 0, mode passive, no cType (`WolfSkill.cs:106-112`, `:2324-2334`).
- **Hook & Mechanics (`CharacterControl.cs:13379-13420`):**
  - Perseverance is not handled in `Wolf.cs` (no cast coroutine or timeout); it is implemented directly inside `CharacterControl.RPC_AddStatus(string sType, int sLv, int sTime, int sValue, int sID)`:
    ```csharp
    if (this.Type == "Wolf")
    {
        if (this.hasSkill(121))
        {
            int num = 1;
            if (this.hasSkill(122))
            {
                num = 2;
            }
            if (StatusData.isBuffStatus(sType))
            {
                sTime = Mathf.FloorToInt((1.1f + 0.2f * (float)num) * (float)sTime);
            }
        }
        if (this.hasSkill(421))
        {
            if (StatusData.isDebuffStatus(sType))
            {
                sTime = Mathf.CeilToInt(0.75f * (float)sTime);
            }
        }
    }
    ```
  - **Receiver-side trigger:** `this` is the character receiving the status. When a Wolf possessing Perseverance receives any status where `StatusData.isBuffStatus(sType) == true` (`StatusData.cs:6323-7171`), its incoming duration `sTime` is multiplied:
    - Rank 1 (`num = 1`): `Mathf.FloorToInt(1.3f * sTime)` (+30% duration).
    - Rank 2 (`num = 2`): `Mathf.FloorToInt(1.5f * sTime)` (+50% duration).
  - **Post-CHA multiplication:** The multiplier runs after caller-side duration adjustments (such as `chaAdjust`) have already executed, and truncates via `Mathf.FloorToInt` (floor, not ceil).
  - **Universal Buff Scope:** Applies to all incoming buff statuses on the Wolf, whether cast by the Wolf itself (e.g. Brave Spirit `valor`, Dark Edge `darkEdge`, Lunar Eclipse `lunarEclipse`, Holy Sword `holySword`, Holy Armor `holyArmor`) or applied by allies (e.g. Sheep's shields/buffs, Penguin's buffs, Cat's `fortune`).
  - **Numeric ID note:** Skill IDs 121 and 122 are reused by other classes (Sheep's hate passive at `CharacterControl.cs:3839`, Penguin's skill at `:23075`); only the `this.Type == "Wolf"` block governs Perseverance.
- **Client Tooltips:**
  - EN: *"Passively extends the duration of all possitive status on Wolf by 30%."* / *"50%."* (`WolfSkill_eng.cs:99-120`).
  - TH: *"เพิ่มระยะเวลาของสถานะทางบวกขึ้น 30%"* / *"50%"* (`WolfSkill_thai.cs:99-120`).
- **App Modeling (`12t_projects/bible/index.html`):**
  - Card: `wolf_perseverance` (`passive: true`, `compatSkills: ["wolf_braveSpirit", "wolf_darkEdge", "wolf_lunarEclipse", "wolf_holySword", "wolf_holyArmor"]`).
  - Dependency toggle: `WOLF_PERSEVERANCE_DEP` (`kind: "postMultiply"`, `multipliers: [1, 1.3, 1.5]`) embedded on the five Wolf self-buff cards.

### wlf_feralStrike1-4 (#341-#344) — active, rank family (verified 2026-09-25)

- **Metadata:**
  - Ranks 1–4: reqLv 16 / 20 / 24 / 28, reqBn 4 / 8 / 12 / 16 (`scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`, `WolfSkill.cs:645-680`, `:2550-2580`).
  - MP: **0** across all ranks.
  - SP: **+15 / +18 / +21 / +24** (Blue SP: required gate to cast, **not consumed**, [12Tails-Mechanics-Reference.md §Red/Blue SP](12Tails-Mechanics-Reference.md#redblue-sp-gauge-system-charactercontrolcs2829-2834-gameguics37609)).
  - Target: `enemy`, mode: `instant`, cType: `feralStrike`.
- **Cooldown & Cast Time:**
  - Cooldown: `addTimeOut("feralStrike", agiAdjust(30f))` (30 seconds, scaled by AGI; subject to `getDoubleArt()` free-recast proc, `Wolf.cs:29452`). Revised Art applies.
  - Cast Time: **0s** (instant animation, no `magAdjust` wait).
- **Movement & Collision Pass-Through (`Wolf.cs:29081-29270`):**
  - Upon cast, Wolf accelerates forward at `moveSpeed = 16` during animation state 2 (~0.4s duration, dashing ~6.4m forward).
  - Applies `Physics.IgnoreCollision` against targets in a 2m wide × 10m forward box (`:29172`), allowing Wolf to pass straight through enemies without getting blocked.
  - Re-enables collision in state 3 (`:29258`) with `moveSpeed = 5`, then stops in state 4 (`moveSpeed = 0`, `:29366`).
- **Cleanse Lock Statuses (`Wolf.cs:29479`, `CharacterControl.cs:19456-19524`):**
  - On cast start, calls `mChar.removeLockStatus(sLv)`.
  - Removes all 5 lock statuses in the engine (`StatusData.isLockStatus`) whose status level is `<= sLv` (Rank 1–4 cleanses Lock Lv 1–4):
    - `groundLock` (Ground Lock)
    - `needlePrison` (Needle Prison)
    - `sticky` (Sticky)
    - `frost` (Frost)
    - `lightBind` (Light Bind)
- **Hitbox Geometry (`Damage.FindRecTarget`, `Wolf.cs:29288`):**
  - Origin: `position - 6 * rangeMod * forward` (starts 6m behind Wolf's destination, sweeping the entire dash path).
  - Dimensions: `BaseWidth 2 * rangeMod`, `TopWidth 2 * rangeMod` (Full width = `2 × BaseWidth = 4m`), `TargetRange 8 * rangeMod` (length 8m), `TargetHeight 3 * rangeMod` (height 3m).
  - All dimensions scale dynamically with `rangeMod` (e.g. raised by Lunar Eclipse).
- **Damage Formula & Pipeline (`Wolf.cs:29311`):**
  - Hit call:
    ```csharp
    mChar.hit(340 + sLv, hitObject,
        (int)(0.5f * mChar.atk + mChar.talAdjust(15 * sLv)),
        0, 0, 0.5f * forward);
    ```
  - **Raw damage:** `floor(0.5 × ATK + talAdjust(15 × sLv))`.
    - Rank 1: `floor(0.5 × ATK + talAdjust(15))`
    - Rank 2: `floor(0.5 × ATK + talAdjust(30))`
    - Rank 3: `floor(0.5 × ATK + talAdjust(45))`
    - Rank 4: `floor(0.5 × ATK + talAdjust(60))`
  - **KO:** `0` (deals no KO damage).
  - **Push force:** `0.5 × forward`.
  - **Pipeline:** Continues through normal `dmgAdjust → defAdjust → hitMod`.
  - **Resource gain:** Grants `+1 SP` per target hit (`Wolf.cs:29337`).
- **Synergies:**
  - **Final Eclipse (`wlf_finalEclipse1`, #373):** When Wolf is under `lunarEclipse` and performs a dodge dash, it automatically casts `RPC_feralStrike` at `sLv = statusLv * 2` (Rank 2 or Rank 4 Feral Strike, `Wolf.cs:7937`).
  - **Lunar Eclipse (`wlf_lunarEclipse`):** `rangeMod += 0.4 × sLv` widens and lengthens the dash hit box by 40% (Rank 1) or 80% (Rank 2).
- **Client Tooltips:**
  - EN: *"Quickly plunge forward and pierce through targets in a straight line, dealing extra 15/30/45/60 damage."* (`WolfSkill_eng.cs:704-747`).
  - TH: *"พุ่งทะลุฉีกผ่านเป้าหมายเพื่อทำความเสียหายเป็นแนวตรง และสลัดตัวเองจากการถูกขังที่ต่ำกว่าระดับ 2/3/4/5 (15/30/45/60 dmg)"* (`WolfSkill_thai.cs:737-775`).
  - Code differences: Tooltips omit the `0.5 × ATK` base, state the TAL bonus as a flat number rather than `talAdjust`, and omit the 0 KO, the pass-through collision mechanics, and the +1 SP per target hit.
- **App Modeling (`12t_projects/bible/index.html`):**
  - Card: `wolf_feralStrike` (`maxRank: 4`, `cost: { mp: 0, sp: [15, 18, 21, 24], spType: "blue" }`, `cd: 30`, `cdWrapped: true`, `atkCoeff: 0.5`, `dmg: "talAdjust(15×sLv)"`, `ko: "0"`, `compatSkills: ["wolf_finalEclipse", "wolf_lunarEclipse"]`).

### wlf_feralAssault5 (#443) — Feral Assault

- **Metadata:** `setReq(85, 6)`, `setSP(-45)` (45 SP consumed, 0 MP), `mode = instant`, target `enemy`, `cType = "feralAssault"` (`WolfSkill.cs:1311-1337`; `scripts/decode_skilldata.py DecompiledSource/WolfSkill.cs`). One rank. No cast bar or applied status in its coroutine.
- **Cooldown and passive:** `addTimeOut("feralAssault", agiAdjust(180f))` (`Wolf.cs:35492`), with the Double Art/Sublime Art exception described above (`Wolf.cs:35400-35412`). Revised Art applies.
- **Dash and cleanse:** `removeLockStatus(5)` at cast start (`Wolf.cs:35452`), removing `groundLock`, `needlePrison`, `sticky`, `frost`, and `lightBind` only when their level is at most 5 (`CharacterControl.cs:19456-19524`). Four movement stages (`Wolf.cs:35282,35306,35498-35503`), with pass-through collision enabled during the dash and restored at its end (`Wolf.cs:35250-35255,35506`).
- **Damage:** On each of four movement stages, `FindRecTarget(position + 2×forward, -forward, 3, 6, 8, 3, layer)` selects a trapezoid 8m deep, 3m high, widening from 6m to 12m across (`Wolf.cs:35633`; `Damage.cs:1416,1437-1446`). Each stage calls `hit(443, target, (int)(0.5f*atk + talAdjust(60)), 6, 0, 0.5f*forward)` (`Wolf.cs:35652`): raw damage `floor(0.5×ATK + talAdjust(60))`, KO 6, force 0.5 forward. The finish combines all path targets with a radius-6m, height-3m area (`Wolf.cs:35547`; path list: `:35682`) and calls `hit(443, target, atk + talAdjust(90), 6, 0, 0.5f*forward)` (`:35566`). Thus a target caught throughout can receive four path hits and one stronger finish. Both routes use the normal direct-hit pipeline.
- **Client text:** EN says it zooms through enemies in a straight line and removes level-5 Lock statuses (`WolfSkill_eng.cs:1023-1030`); TH says it escapes confinement below level 6 (`WolfSkill_thai.cs:1056-1063`).

### wlf_dualBrand5 (#434) — Dual Brand

- **Metadata:** `setReq(75, 4)`, `setMPSP(24, -36)` (24 MP and 36 SP consumed), `mode = instant`, target `enemy`, `cType = "dualBrand"` (`WolfSkill.cs:1403-1429`; decoded with `scripts/decode_skilldata.py`). One rank, no cast bar or applied status.
- **Cooldown and passive:** `addTimeOut("dualBrand", agiAdjust(120f))` (`Wolf.cs:36680`); a Double Art proc skips it only if Sublime Art is learned (`Wolf.cs:36665-36680`). Revised Art applies.
- **Four hits:** The first two independently scan radius 5m, height 3m (`Wolf.cs:36019,36169`); the next two independently scan a forward rectangle 5m deep, 4m wide, 4m high (`:36319,36496`; `Damage.cs:1416,1437-1446`). All four call `hit(434, target, atk + talAdjust(24), 0, 0, Vector3.zero)` (`Wolf.cs:36042,36192,36342,36519`): raw `ATK + talAdjust(24)`, KO 0, no force, normal direct-hit pipeline. A target inside every scan can receive four hits.
- **SP branch caution:** Each slash contains `sp = sp + 1` after a `hit(...) != 0` branch (`Wolf.cs:36042-36068,36192-36218,36342-36368,36519-36545`). The first branch's junk predicate sends a nonzero `hit()` result back to the iterator (`:36044-36046`); the SP increment is reached through the zero-return path. `hit()` ordinarily returns nonzero mitigated damage for a successful direct hit (`CharacterControl.cs:3566-3573,3672-3675`). Do not describe this as +1 SP on a landed hit without live confirmation.
- **Client text:** TH describes continuous wide-area sword slashes (`WolfSkill_thai.cs:1100-1107`). The EN text is attached to misspelled key `wlf_dualBand5`, so it does not match the real `wlf_dualBrand5` metadata key (`WolfSkill_eng.cs:1067-1075`; `WolfSkill.cs:1403`).

### wlf_twinResonance5 (#444) — Twin Resonance

- **Metadata:** `setReq(85, 6)`, `setMPSP(60, -60)` (60 MP and 60 SP consumed), `mode = instant`, target `enemy`, `cType = "twinResonance"` (`WolfSkill.cs:1443-1471`; decoded with `scripts/decode_skilldata.py`). One rank, no cast bar or applied status.
- **Cooldown and passive:** `addTimeOut("twinResonance", agiAdjust(240f))` (`Wolf.cs:37213`), skipped on a Double Art proc (`:37207-37213`); no Sublime Art gate. Revised Art applies.
- **Expanding repeated hits:** The cast launches `RPC_twinResonance_fire` (`Wolf.cs:37110-37115`). Its counter starts at 0 and ends before 40 (`:37616,37622`); each cycle waits 0.4s (`:37714`). On each cycle it scans a 190-degree sector, height 2m, with search range `3 + 0.8×i` meters (`:37644`), then admits only targets whose transform is within `1 + 0.8×i` meters (`:37663-37668`). Every qualifying cycle calls `hit(444, target, (int)(0.75f*atk + talAdjust(50)), 2, 0, Vector3.zero)` (`:37674`): raw `floor(0.75×ATK + talAdjust(50))`, KO 2, no force, normal direct-hit pipeline. A nearby stationary target can be hit repeatedly, up to 40 times; a target farther than 32.2m from the fire origin fails the distance gate. Damage totals depend on distance, movement, and whether the channel ends early when the caster has no HP/KO (`:37543-37558`). A fixed 40-hit total would misrepresent most targets.
- **Client text:** EN describes expanding waves that damage a wide area for a short period (`WolfSkill_eng.cs:1080-1089`); TH describes wide-area sword waves (`WolfSkill_thai.cs:1113-1122`).

## Class-C Passives

Class-C (Lv.5) passive-only skills are documented here even though they have no cooldown row in [wolf-skill-reference.md](wolf-skill-reference.md). Fortitude, Law Bringer, and Blood Fang are written up here, and Wild Heart above (next to Feral Instinct); `continuousBlade5`, `skySlasher5`, `sublimeArt5`, and `gloriousSpirit5` still need their own entries.

### wlf_fortitude5 (421) — passive

- `WolfSkill.cs:955-` (`mode = eSkillMode.passive`, no `cType`), `setReq(70, 3)` → reqLv 70, reqBn 3, MP 0, SP 0. Flavor text: "Passively decreases the duration of the all negative status on Wolf by 25%." (`WolfSkill_eng.cs:895`).
- Effect lives in the shared base class, not `Wolf.cs` (the only `hasSkill(421)` in the source is here): `CharacterControl.cs:13421-13434`, inside `RPC_AddStatus`, in the same `if (this.Type == "Wolf")` block (L13379) as Perseverance:

```csharp
if (this.hasSkill(421))
{
    if (StatusData.isDebuffStatus(sType))
    {
        sTime = Mathf.CeilToInt(0.75f * (float)sTime);
    }
}
```

- `this` is the character *receiving* the status, so every debuff applied to a Wolf who knows Fortitude has its duration cut to `⌈0.75×sTime⌉`, whichever skill or source applied it. The check is nested in the Wolf-only block, so other classes' slot-421 skills (e.g. Penguin's Focus Intellect) do not get it.
- Order within `RPC_AddStatus`: the Perseverance buff-duration bonus (`hasSkill(121/122)`, `L13385-13419`, buffs only) runs first, then Fortitude; Perseverance is gated on `isBuffStatus` and Fortitude on `isDebuffStatus`.
