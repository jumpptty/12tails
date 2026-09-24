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
- **Every single active skill's live `addTimeOut` call is gated behind the class-wide `getDoubleArt()`
  proc-chance check — a Wolf-specific mechanic, not a bug, and it does not change the reported base
  value.** `getDoubleArt()` (`Wolf.cs:8235-8339`) rolls `Random(0,100) >= lckAdjust(learnedRank * 6)`;
  on success it returns `true` (the normal path — `addTimeOut` fires as usual) and on the `learnedRank*6`%
  failure roll it instead fires `RPC_doubleArt` and returns `false` (the free-recast proc from the
  `doubleArt1`-`4` passive — "Gives Wolf a 6/12/18/24% chance to use his skill without any cooldown",
  `WolfSkill_eng.cs:125` etc. — skipping `addTimeOut` entirely for that cast). Confirmed present at
  every one of the 23 active-skill cast sites reported in this table (e.g. `Wolf.cs:20576`, `:21344`,
  `:31320`, `:37207`); the CD values reported here are the normal (non-proc) path, matching how every
  prior class doc reports the un-modified base value and cites the modifier separately.
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
- **Class-C (Lv.5) passive-only skills have no row in this table** (no cooldown, duration or cast time to report), but they are *not* excluded from documentation — their mechanics belong in [wolf-skill-reference.md](wolf-skill-reference.md#class-c-passives) (only `fortitude5` is written up so far): `continuousBlade5`, `skySlasher5`, `fortitude5`,
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

## Class-C Passives

Class-C (Lv.5) passive-only skills are documented here even though they have no cooldown row in [wolf-skill-reference.md](wolf-skill-reference.md). Fortitude is written up here and Wild Heart above (next to Feral Instinct); `continuousBlade5`, `skySlasher5`, `sublimeArt5`, `gloriousSpirit5`, `lawBringer5` and `bloodFang5` still need their own entries.

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
