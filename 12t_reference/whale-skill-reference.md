# Whale — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.
`homingShield` added 2026-08-14 — see its judgment-call note below for why it was initially left out and
then given its own row.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| sweep | Sweep | 2 | 30 | true | false | — | — |
| javelin | Javelin | 2 | 30 | true | false | — | — |
| honor | Honor | 4 | 60 | true | false | 12 | true |
| shieldRush | Shield Rush | 2 | 45 | true | false | — | — |
| flyingShield | Flying Shield | 2 | 45 | true | false | — | — |
| homingShield | Homing Shield | 1 | 120 | true | false | 3 | true |
| swallow | Swallow | 2 | 90 | true | false | — | — |
| gobbleUp | Gobble Up | 1 | 60 | true | false | — | — |
| peninsulaImpale | Peninsula Impale | 2 | 90 | true | false | — | — |
| peninsulaRound | Peninsula Round | 2 | 120 | true | false | — | — |
| 12thKingdomKnight | 12th Kingdom Knight | 2 | 600 | true | false | 60 | true |
| bubbleShield | Bubble Shield | 4 | 30 | true | false | 12 | true |
| heavyWeight | Heavy Weight | 2 | 60 | true | false | — | — |
| hydroBlast | Hydro Blast | 4 | 60 | true | false | — | — |
| rejuvenate | Rejuvenate | 4 | 90 | true | false | 18 | true |
| whaleWave | Whale Wave | 2 | 60 | true | false | — | — |
| malStorm | Mal Storm | 2 | 60 | true | false | — | — |
| callToArm | Call To Arm | 1 | 120 | true | false | — | — |
| salvation | Salvation | 2 | 240 | true | false | 6 | true |
| megalodon | Megalodon | 2 | 240 | true | false | — | — |
| bubbleBurst | Bubble Burst | 1 | 60 | true | false | — | — |
| revitalize | Revitalize | 1 | 180 | true | false | 18 | true |
| bowlingWhale | Bowling Whale | 1 | 180 | true | false | — | — |
| grandTide | Grand Tide | 1 | 300 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Support-skill exclusion confirmed, including Whale's own thematic `seaAegis`.** All 12 shared
  `SkillData.cs`/`getSupportSkill()` names appear in `Whale.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)`: `stunningGround` (`Whale.cs:10688`), `psalmOfEnergy`
  (`:10931`), `seaAegis` (`:11100`), `zephyrLore` (`:11294`), `replenishment` (`:11395`),
  `elementalBound` (`:11525`), `astralShift` (`:11677`), `bloodCarnage` (`:11868`), `obsidianFang`
  (`:38453`), `assassinate` (`:38894`), `mineWalker` (`:39272`), `divineChannel` (`:39648`) — all 12
  present, all bare-`600`. A direct grep of `WhaleSkill.cs` for `seaAegis` (Whale's own thematically-named
  support skill) returns zero matches, confirming it isn't part of Whale's own learnable-skill roster
  (`getSkill()`). All 12 excluded. A grep of `WhaleSkill.cs` for `"whl_mount"`/`== "mount"` also returns
  zero matches — the universal ride-a-mount action isn't a Whale class skill either.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.**
  `whl_nAttack1`/`whl_nAttack2` fall through (no live goto) all the way to the outermost default tail
  (`WhaleSkill.cs:2223-2231`: `setReq(2, 1); mode = eSkillMode.passive;`), and `whl_cAttack1`/`2`/`3`
  converge on a separate passive tail at `IL_230F` (`:2210-2221`: `setReq(16, 3); mode = passive;`,
  reached directly by `cAttack1`/`2`'s fallthrough and by `cAttack3`'s explicit `goto IL_230F` at `:79`).
  Excluded regardless of the passive metadata, per the blanket rule.
- **The following named `getSkill()` entries are genuinely passive** (own explicit
  `mode = eSkillMode.passive`, confirmed against `WhaleSkill_eng.cs` flavor text) and excluded outright,
  no row: `shieldBash1` (charge-shield-bash unlock, `:81-98`), `culinaryTongue1/2` (food-effect boost,
  `:2193-2204`), `superSize1-4` (stat/weight boost, `:2180-2191`), `statPlus1-4` (stat boost,
  `:2148-2164`), `wallPuncture1-4` (armor-penetration chance, `:1866-1877`), `autoShield1-3` (passive
  block chance, `:1846-1857`), `lastHope1` (`:522-538`), `12thKingdomKnight`'s sibling
  `knightOfTheDeep1` (`:566-583`), `hardenSkin1-4` (`:1729-1739`), `reducedCast1` (`:927-944`),
  `entendedWave5` (`:945-967`), `shieldReflect5` (`:968-990`), `gourmetHeart5` (`:991-1013`),
  `megaSize5` (`:1014-1036`), `superStatPlus5` (`:1037-1064`), `tideCutter5` (`:1065-1087`),
  `honorStand5` (duplicated verbatim at `:1088-1110` and `:1111-1133` — dead-code duplication, both
  identical, not a discrepancy), `wonderBelly5` (`:1172-1194`, matches its own "every 5 seconds" auto-tick
  flavor text — an automatic property of the `swallow`/`gobbleUp` mechanic, not a separately cast skill),
  `peninsulaAsunder5` (`:1195-1217`), `overWeight5` (`:1256-1278`), `spiralBlast5` (`:1279-1301`),
  `divingPress5` (`:1340-1362`), `revisedSkill5` (`:1363-1380`), `revisedMagic5` (`:1381-1398`), and
  `revisedArt5` (`:1399-1416`, "Reduces all skills' cooldown by 12%" — confirms Whale has the class's own
  `revisedArt5` toggle skill used by the lookup tool's global toggle; it is not itself a table row).
- **One dead-code-fallthrough trap landing on an *unrelated active* skill's cType** (the
  Mole/Panda/Rabbit-precedent bug): `overPresence1`/`overPresence2` (`WhaleSkill.cs:655-673`) both have
  empty branches with no own `goto`/`cType`/`mode` assignment, so they fall through the entire nested
  `hydroBlast`/`rejuvenate`/`.../grandTide5` tree and land on `heavyWeight`'s shared tail
  (`:1741-1766`: `setReq(11, 3); setMP(14); mode = target; target = all; cType = "heavyWeight";`).
  Confirmed as a genuine bug, not real behavior: `WhaleSkill_eng.cs:609/620` describes overPresence as
  "passively reduce running speed of enemies within 6 m range by 5%/10%", and `Whale_overPresence.cs` is
  a dedicated collider component that applies the `"overPresence"` status automatically on
  `OnTriggerEnter` (`Whale_overPresence.cs:56-130`, status applied at `:120`) and removes it on
  `OnTriggerExit` (`:134-187`, removed at `:177`), with no cooldown or cast of its own; `Whale.cs`'s
  `Start()` even spawns it directly via `this.createOverPresence()` when `hasSkill(313)`
  (`Whale.cs:86-92`), independent of any `getSkill()`/cast pathway. `heavyWeight` is already reported
  cleanly from its own 2-rank progression, so `overPresence` gets no row.
- **`homingShield` gets its own row (added 2026-08-14, user override) — it is a genuinely separate active
  skill from `flyingShield`, not a footnote on it.** An earlier pass on this doc treated
  `homingShield5` (`WhaleSkill.cs:1134-1171`: `setReq(70, 3); setSP(-24); mode = target; target = enemy;
  cType = "flyingShield"; rSkill = 224;`) as a level-70 "evolution" of `flyingShield` and folded its
  higher cooldown into a citation note instead of giving it a row, reasoning that the two share one
  cooldown-lock name (`cType = "flyingShield"`). The user explicitly corrected this: they're two
  different active skills in-game (distinct action code `422` vs. `flyingShield`'s own, distinct
  `RPC_homingShield`/`RPC_homingShield_fire` coroutines, distinct multi-hit homing-projectile mechanic
  per `WhaleSkill_eng.cs:950` — *"Whale cannot use shield while the shield is still flying"*, itself
  proof they're not simultaneously-castable variants of one ability) and should be reported as such. The
  shared `cType` string is just how the two coroutines happen to reuse one cooldown-timer *key* in the
  engine, not evidence they're one skill: the base ability arms
  `addTimeOut("flyingShield", agiAdjust((float)(45 - 15 * getKnightOfTheDeepLv())))` (`Whale.cs:25005`)
  from its own cast site (`myCommand == "flyingShield"`), while `homingShield` arms the same-keyed timer
  but with `addTimeOut("flyingShield", agiAdjust((float)(120 - 40 * getKnightOfTheDeepLv())))`
  (`Whale.cs:35293`) from its own separate cast site (`myCommand == "homingShield"`,
  `Whale.cs:35176-35293`). Duration: `homingShield`'s own coroutine applies a self-targeted `"noShield"`
  recast-lockout status at `Whale.cs:35211` —
  `RPC_AddStatus("noShield", 1, chaAdjust(3), 40, ActorNr)` — base `3`, `chaAdjust`-wrapped; corroborated
  by the homing projectile's own object lifetime using the identical `chaAdjust(3)` value
  (`Whale.cs:10431` → `Whale_homingShield.cs:31`, self-destructs at `:225-254`). Not exempt from
  revisedArt5: the reduction is centralized in `CharacterControl.cs:20102`'s `addTimeOut`, gated on an
  explicit `cType` exemption list (`:20116-20224`, e.g. `nAttack`/`potion`/`bomb`/...) that
  `"flyingShield"` isn't part of, so both rows get the same 0.88× multiplier
  (`CharacterControl.cs:20227`). Single-rank (only `whl_homingShield5` exists — no `1-4` variants).
- **`getKnightOfTheDeepLv()` is a passive CD-reduction modifier (from the passive `knightOfTheDeep1`
  skill) affecting seven skills' cooldowns — base values reported assume it unlearned.**
  `Whale.cs:9813-9816`: `return (!this.mChar.hasSkill(273)) ? 0 : 1;` — 0 unless `knightOfTheDeep1`
  is learned. It reduces `sweep`/`javelin` by `10 * lv`, `shieldRush`/`flyingShield`/base by `15 * lv`,
  `peninsulaImpale`/`peninsulaRound` by `30`/`40 * lv`, and (2026-08-14) `homingShield` by `40 * lv`
  (its own separate cast site, `Whale.cs:35293`, happens to match `peninsulaRound`'s magnitude)
  respectively (all at the cast sites cited below). `knightOfTheDeep1`'s own flavor text only mentions
  Javelin/FlyingShield (`WhaleSkill_eng.cs:532`: "reduces cooldown of Jevalin and FlyingShield by 18
  sec"), but the code applies it more broadly to all seven weapon-swing-style skills (an omission that
  now also covers `homingShield`, undocumented in-game same as the other five); none of this changes the
  base (lv-0) numbers reported here. Encoded structurally in the lookup tool's data (2026-08-14) via a
  `cdDep` field on each of the seven affected `SKILLS` entries
  (`12t_projects/player-reference-tool/index.html`): `knightOfTheDeep1` is single-rank (`minRank:0,
  maxRank:1`), so each skill's own `perRank` is just its cited reduction as a negative
  (`sweep`/`javelin`: `-10`, `shieldRush`/`flyingShield`: `-15`, `peninsulaImpale`: `-30`,
  `peninsulaRound`/`homingShield`: `-40`) — all seven share one `id` (`"knightOfTheDeep"`) so toggling
  it on one skill carries over to the others, matching the passive being one single learned/not-learned
  state in-game. Rendered as a single icon toggle (`.sk-dep-toggle`), not a rank stepper, since there's
  no middle rank.
- **CD-wrapped status verified individually at every one of the 24 skills' own cast sites, per the
  plan's `manaArc`/`quickHeal`-precedent warning — no bare-literal trap found for Whale.** All 24 use
  `agiAdjust(...)`, either directly at their own dedicated cast site (`sweep`, `javelin`, `honor`,
  `shieldRush`, `flyingShield`, `homingShield`, `swallow`, `gobbleUp`, `peninsulaImpale`,
  `peninsulaRound`, `12thKingdomKnight`, `whaleWave`, `malStorm`, `bubbleBurst`, `bowlingWhale`,
  `grandTide`) or via the one shared `"cast"`-mode dispatcher's single wrap point (`bubbleShield`,
  `heavyWeight`, `hydroBlast`, `rejuvenate`, `callToArm`, `salvation`, `megalodon`, `revitalize`, all
  wrapped at `Whale.cs:21261`: `addTimeOut(this.$sType$28566, agiAdjust((float)this.$mTimeOut$28554))`)
  — no exceptions found.
- **CHA-contested Duration exclusions, per the plan's contested-duration rule.** `swallow`'s own duration:
  `Whale.cs:25811` — `this.$mDuration$28700 = Damage.getDebuff((float)(12 + ((!hasSkill(432)) ? 0 : 3)),
  this.$self_$28706.mChar.cha, this.$tChar$28694.cha);`, applied at `:25816`. `heavyWeight`'s `"heavy"`
  status, in the (normal, opposing-team) enemy-target branch: `Whale.cs:30237` —
  `this.$mDuration$28817 = Damage.getDebuff((float)15, this.$self_$28820.mChar.cha,
  this.$tChar$28816.cha);`, applied at `:30250`. (A same-team/ally branch at `:30228` uses a flat,
  non-contested `chaAdjust(15)` instead, but the practical enemy-targeting case is contested — reported
  Duration `—` for `heavyWeight`.)
- **`revitalize` reuses `rejuvenate`'s own status/duration formula at a fixed level, not a new one.**
  `Whale.cs:36236` — `this.$hitChar$28958.RPC_AddStatus("rejuvenate", 3, this.$self_$28960.mChar.
  chaAdjust(18), 0, ...);`, inside `revitalize`'s own `myCommand == "revitalize"` coroutine
  (`:36168-36326`), matching its own flavor text ("Cast 'rejuvenate3' on all allied players...",
  `WhaleSkill_eng.cs:1016`) and `rejuvenate`'s own unmodified `chaAdjust(18)` (`:31356`) — Duration 18,
  `chaAdjust`-wrapped, for both rows.
- **`bubbleShield`, `heavyWeight`, `hydroBlast`, `rejuvenate`, `callToArm`, `salvation`, `megalodon`,
  `revitalize` all route through one shared `"cast"`-mode dispatcher for their cooldown** (rather than
  each having its own dedicated `addTimeOut` call), keyed on `this.$sType$28566` /
  `this.$mTimeOut$28554` (`Whale.cs:21098-21261`) — confirmed by direct `Read`, not just grep. Each
  branch sets its own flat `$mTimeOut$28554` value with no `sLv`-scaling (`Whale.cs:21101-21236`); the
  actual per-skill cast bodies (`RPC_bubbleShield_cast`, `RPC_heavyWeight_cast`, etc.) are reached via a
  separate `RPC_cast1(...)` routing call and don't re-arm their own timer.
- **No `RPC_AddStatus`/field-effect-lifetime call exists for**: `sweep`, `javelin`, `shieldRush`,
  `flyingShield`, `gobbleUp`, `peninsulaImpale`, `peninsulaRound`, `hydroBlast`, `whaleWave`, `malStorm`,
  `callToArm`, `megalodon`, `bubbleBurst`, `bowlingWhale`, `grandTide` — confirmed by a full-file grep
  of every `RPC_AddStatus(` call in `Whale.cs` and cross-checking each hit against these skills' own
  coroutine bodies. The remaining `RPC_AddStatus` hits in the file belong either to the 12 support
  skills, to passive/excluded skills (`lastHope`, `hardenSkin`, `wallPuncture`), or to an unrelated
  generic minigame/consumable-item/hit-reaction effects system clustered separately in the file (`wash`,
  `ice`, `iceShield`, `awareness`, `float`, `bless`, `burn`, `paralysis`, `blind`, `plague`, `frost`,
  `awake`, `whiteFlag`/`blueFlag`/`redFlag`/`yellowFlag`, `cleanse`, `happy`, `charm`, `defDown`,
  `mpDrain`, `hpDrain`, plus a second `"bubbleShield"`/`"heavy"` pair at `:47115`/`:47151` tied to a
  different caster variable (`$self_$29239`/`$hitChar$29231`) than `bubbleShield`'s/`heavyWeight`'s own
  skill coroutines) — none tied to any of these 14 skills' own `getSkill()` roster entries, matching the
  same generic-effects block documented in the Panda/Mole/Rabbit/Sheep docs. Duration cells for all 14
  skills above are `—`.

### CD citations
- `sweep` CD: `Whale.cs:22278` — `addTimeOut("sweep", agiAdjust((float)(30 - 10 * getKnightOfTheDeepLv())))` (lv0 baseline → 30)
- `javelin` CD: `Whale.cs:23188` — `addTimeOut("javelin", agiAdjust((float)(30 - 10 * getKnightOfTheDeepLv())))` (→ 30)
- `honor` CD: `Whale.cs:23695` — `addTimeOut("honor", agiAdjust(60f))` (flat, all 4 ranks share it)
- `shieldRush` CD: `Whale.cs:24436` — `addTimeOut("shieldRush", agiAdjust((float)(45 - 15 * getKnightOfTheDeepLv())))` (→ 45)
- `flyingShield` CD (base ability, own cast site): `Whale.cs:25005` — `addTimeOut("flyingShield", agiAdjust((float)(45 - 15 * getKnightOfTheDeepLv())))` (→ 45); see judgment-call note re: `homingShield5`'s separate 120-base cast site at `:35293`
- `homingShield` CD (own cast site, `myCommand == "homingShield"`): `Whale.cs:35293` — `addTimeOut("flyingShield", agiAdjust((float)(120 - 40 * getKnightOfTheDeepLv())))` (→ 120); shares `flyingShield`'s cooldown-lock key but is a distinct skill with its own cast site — see judgment-call note
- `swallow` CD: `Whale.cs:25528` — `addTimeOut("swallow", agiAdjust((float)90))` (flat, both ranks share it)
- `gobbleUp` CD: `Whale.cs:26375` — `addTimeOut("gobbleUp", agiAdjust((float)60))` (flat, single-rank `whl_gobbleUp1`)
- `peninsulaImpale` CD: `Whale.cs:27265` — `addTimeOut("peninsulaImpale", agiAdjust((float)(90 - 30 * getKnightOfTheDeepLv())))` (→ 90)
- `peninsulaRound` CD: `Whale.cs:27819` — `addTimeOut("peninsulaRound", agiAdjust((float)(120 - 40 * getKnightOfTheDeepLv())))` (→ 120)
- `12thKingdomKnight` CD: `Whale.cs:28631` — `addTimeOut("12thKingdomKnight", agiAdjust(600f))` (flat, both ranks share it)
- `bubbleShield` CD: `Whale.cs:21112` (`$mTimeOut$28554 = 30;`) wrapped at `:21261`
- `heavyWeight` CD: `Whale.cs:21129` (`$mTimeOut$28554 = 60;`) wrapped at `:21261`
- `hydroBlast` CD: `Whale.cs:21146` (`$mTimeOut$28554 = 60;`) wrapped at `:21261`
- `rejuvenate` CD: `Whale.cs:21163` (`$mTimeOut$28554 = 90;`) wrapped at `:21261`
- `whaleWave` CD: `Whale.cs:32099` — `addTimeOut("whaleWave", agiAdjust(60f))` (flat, both ranks share it)
- `malStorm` CD: `Whale.cs:32763` — `addTimeOut("malStorm", agiAdjust(60f))` (flat, both ranks share it)
- `callToArm` CD: `Whale.cs:21180` (`$mTimeOut$28554 = 120;`) wrapped at `:21261` (single-rank `whl_callToArm1`)
- `salvation` CD: `Whale.cs:21197` (`$mTimeOut$28554 = 240;`) wrapped at `:21261`
- `megalodon` CD: `Whale.cs:21214` (`$mTimeOut$28554 = 240;`) wrapped at `:21261`
- `bubbleBurst` CD: `Whale.cs:35644` — `addTimeOut("bubbleBurst", agiAdjust(60f))` (flat, single-rank `whl_bubbleBurst5`)
- `revitalize` CD: `Whale.cs:21231` (`$mTimeOut$28554 = 180;`) wrapped at `:21261` (single-rank `whl_revitalize5`)
- `bowlingWhale` CD: `Whale.cs:37004` — `addTimeOut("bowlingWhale", agiAdjust((float)180))` (single-rank `whl_bowlingWhale5`); matches the preemptive pre-arm at `Whale.cs:98` — `addTimeOut("bowlingWhale", agiAdjust(180f))`
- `grandTide` CD: `Whale.cs:37772` — `addTimeOut("grandTide", agiAdjust((float)300))` (single-rank `whl_grandTide5`); matches the preemptive pre-arm at `Whale.cs:101` — `addTimeOut("grandTide", agiAdjust(300f))`

### Duration citations
- `honor` Duration: `Whale.cs:23868` — `this.$tChar$28641.RPC_AddStatus("honor", this.$sLv$28650, this.$self_$28651.mChar.chaAdjust(12), 0, ...);` (caster's own `chaAdjust`, not target-contested; flat `12` regardless of rank)
- `bubbleShield` Duration: `Whale.cs:29722` — `this.$tChar$28806.RPC_AddStatus("bubbleShield", this.$sLv$28808 + (...bubbleBurst bonus...), this.$self_$28809.mChar.chaAdjust(12), this.$self_$28809.mChar.talAdjust(...), ...);` (caster's own `chaAdjust`; the 4th arg is a `talAdjust`-wrapped explosion-damage value, not duration) — matches the "explodes after 12 seconds" flavor text (`WhaleSkill_eng.cs:543`)
- `rejuvenate` Duration: `Whale.cs:31356` — `this.$tChar$28835.RPC_AddStatus("rejuvenate", this.$sLv$28837, this.$self_$28838.mChar.chaAdjust(18), 0, ...);` (caster's own `chaAdjust`; flat `18` regardless of rank, matching "over 18 seconds" in every `rejuvenate1-4` description)
- `12thKingdomKnight` Duration: `Whale.cs:28527` — `this.$mDuration$28776 = this.$self_$28780.mChar.chaAdjust(60);`, applied at `:28538` — `RPC_AddStatus("kingdomKnight", this.$sLv$28779, this.$mDuration$28776, 0, ...);` (caster's own `chaAdjust`, matching "for 60 seconds" in both `12thKingdomKnight1`/`2` descriptions)
- `salvation` Duration: `Whale.cs:33788` — `this.$tChar$28891.RPC_AddStatus("salvation", this.$sLv$28893, this.$self_$28894.mChar.chaAdjust(2 * this.$sLv$28893 + 2), 0, ...);` (caster's own `chaAdjust`; base `2*sLv+2` evaluated at max rank sLv=2 → 6)
- `revitalize` Duration: `Whale.cs:36236` — see judgment-call note; reuses `rejuvenate`'s own `chaAdjust(18)` formula at a fixed status level of 3
- `homingShield` Duration: `Whale.cs:35211` — `this.$self_$28931.mChar.RPC_AddStatus("noShield", 1, this.$self_$28931.mChar.chaAdjust(3), 40, this.$self_$28931.mChar.ActorNr);` (self-targeted, caster's own `chaAdjust`, not target-contested; a recast-lockout gate rather than a combat buff — see judgment-call note. Corroborated by the homing projectile's own object lifetime sharing the identical `chaAdjust(3)` value: `Whale.cs:10431` → `Whale_homingShield.cs:31`)
- `swallow`, `heavyWeight`: CHA-contested via `Damage.getDebuff(...)` — see judgment-call note; Duration cells are `—`
- `sweep`, `javelin`, `shieldRush`, `flyingShield`, `gobbleUp`, `peninsulaImpale`, `peninsulaRound`,
  `hydroBlast`, `whaleWave`, `malStorm`, `callToArm`, `megalodon`, `bubbleBurst`, `bowlingWhale`,
  `grandTide`: no usable Duration — no `RPC_AddStatus`/field-effect-lifetime call exists in the skill's
  own coroutine class body; see the bulk judgment-call note above. Duration cells are `—`.
