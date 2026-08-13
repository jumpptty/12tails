# Wolf — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

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
  `addTimeOut`/`RPC_<name>` cast handler of their own in `Wolf.cs`.
- **All Class-C (Lv.5) passive-only skills excluded**: `continuousBlade5`, `skySlasher5`, `fortitude5`,
  `sublimeArt5`, `superStatPlus5`, `gloriousSpirit5`, `lawBringer5`, `bloodFang5`, `wildHeart5`,
  `revisedSkill5`, `revisedMagic5`, `revisedArt5` — all `mode = eSkillMode.passive` directly in their
  own `getSkill()` body (`WolfSkill.cs:920`, `:943`, `:966`, `:989`, `:1012`, `:1040`, `:1063`, `:1200`,
  `:1223`, `:1360`, `:1378`, `:1396`) with matching passive flavor text (`WolfSkill_eng.cs:869-1065`).
  `skySlasher5` does have its own `RPC_skySlasher` handler (`Wolf.cs:9113`) and its own `ActionName`
  entry, but it modifies the charge-attack (`cAttack`) combo tier via `getChargeAttackLv()`/
  `getSkySlasherLv()` (`Wolf.cs:8382-8419`), not an independently cast skill — no `wlf_skySlasher`
  entry exists in the `a2 == "wlf_..."` per-name cast dispatcher (unlike every genuine active skill
  below), confirming it's excluded like the rest of this group. `revisedArt5`'s own description
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
  remaining hits belong either to the 12 support skills, the excluded passives above, or an unrelated
  generic minigame/consumable-item/flag-capture effects system (`wash`, `bless`, `ice`, `bubbleShield`,
  `iceShield`, `awareness`, `float`, `mpsap`, `burn`, `paralysis`, `blind`, `plague`, `frost`, `awake`,
  `yellowFlag`, `redFlag`, `cleanse`, `blueFlag`, `whiteFlag`, `happy`, `charm`, `bleed`, `heavy`,
  `mpDrain`, `hpDrain`) — none tied to any `WolfSkill.cs` roster entry, matching the same generic-effects
  block documented in the Sheep/Panda/Rabbit docs. Duration cells for all fourteen skills listed above
  are `—`.
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
- `braveSpirit` Duration: `Wolf.cs:20489` — `this.$tChar$29360.RPC_AddStatus("valor", this.$sLv$29364 + ((!this.$self_$29365.mChar.hasSkill(402)) ? 0 : 2), this.$self_$29365.mChar.chaAdjust(15), 0, this.$self_$29365.mChar.ActorNr);` (applied to allies in range using the caster's own `chaAdjust`, not target-contested; flat `15` regardless of rank — only the status *level* param scales with rank/`gloriousSpirit5`)
- `darkEdge` Duration: `Wolf.cs:30805` — `this.$self_$29595.mChar.RPC_AddStatus("darkEdge", this.$sLv$29594, this.$self_$29595.mChar.chaAdjust(this.$sLv$29594 * 2), 0, this.$self_$29595.mChar.ActorNr);` (self-cast; at max rank `sLv=4` → `chaAdjust(8)`, matching the rank-4 flavor text "for 8 seconds", `WolfSkill_eng.cs:829`)
- `lunarEclipse` Duration: `Wolf.cs:31238` — `this.$self_$29605.mChar.RPC_AddStatus("lunarEclipse", this.$sLv$29604, this.$self_$29605.mChar.chaAdjust(9 + 3 * this.$sLv$29604), 0, this.$self_$29605.mChar.ActorNr);` (self-cast; at max rank `sLv=2` → `chaAdjust(15)`)
- `holySword` Duration: `Wolf.cs:32969` — `this.$self_$29645.mChar.RPC_AddStatus("holySword", 5, this.$self_$29645.mChar.chaAdjust(24), (int)this.$nValue$29642, this.$self_$29645.mChar.ActorNr);` (self-cast; 4th param is the weapon-atk-bonus value, not duration)
- `holyArmor` Duration: `Wolf.cs:33484` — `this.$self_$29655.mChar.RPC_AddStatus("holyArmor", 5, this.$self_$29655.mChar.chaAdjust(24), (int)this.$nValue$29652, this.$self_$29655.mChar.ActorNr);` (self-cast; 4th param is the armor-def-bonus value, not duration)
- `powerBreak`, `armorBreak`, `provoke`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `artCancel`: incidental flat target-side interrupt/stun flag (`RPC_AddStatus("artCancel", 1, 1, 0, ...)`), not the skill's own duration — see judgment-call note; Duration cell is `—`
- `crusader`, `secondWind`, `crossBreak`, `grandCross`, `massResurrection`, `bladeFang`, `counter`,
  `feralStrike`, `bladeSong`, `thirdRend`, `mirrorBlade`, `feralAssault`, `dualBrand`, `twinResonance`:
  no usable Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists in the skill's
  own coroutine class body; see the bulk judgment-call note above. Duration cells are `—`.
