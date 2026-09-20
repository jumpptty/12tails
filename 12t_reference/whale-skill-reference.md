# Whale — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.
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
  skills, to passive skills (`lastHope`, `hardenSkin`, `wallPuncture`), or to an unrelated
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
- `honor` stat gain: `CharacterControl.cs:35558` — `this.$self_$35977.deltaCha(10 * this.$sLv$35973);` on apply, reversed at `CharacterControl.cs:15890-15894` (`else if (sType == "honor") { this.deltaCha(-10 * sLv); }`). CHA only. `sLv` is the 1-indexed cast rank: `Whale.cs:4231-4285` calls `RPC_honor(..., 1..4)`, stored at `Whale.cs:23518` and passed to `RPC_AddStatus("honor", sLv, ...)` at `Whale.cs:23868`. Confirmed by the in-game text, `WhaleSkill_eng.cs:257-268` ("temporary adding 10 / 20 points to charisma", plus hate scaled from CHA). A separate `nKo` reduction keyed on the honor status level exists at `CharacterControl.cs:4387-4400` — not yet traced.
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

---

# Damage & Mechanics


Verified from decompiled source (`DecompiledSource/Whale.cs`, `DecompiledSource/WhaleSkill.cs`, `DecompiledSource/CharacterControl.cs`, and companion scripts) for the player-reference-tool (`12t_projects/player-reference-tool/index.html`).

---

## 1. Summary of Whale Mechanics

- **Resource System (MP, Red SP, Blue SP)**:
  - **MP (Mana Points)**: Consumed on cast by water/shamanic spells.
  - **Red SP (Stamina / Rage)**: `cSP < 0` in decompiled source (`GameGui.cs:37782`). Requires and **consumes** that amount of SP on cast (rendered in-game as Red SP: `new Color(1f, 0.2f, 0.2f)`). Almost all Whale weapon swings and physical maneuvers consume Red SP.
  - **Blue SP (Combo / Action Requirement)**: `cSP > 0` in decompiled source (`GameGui.cs:37609`). Requires minimum SP threshold to cast, but **does not consume SP** (rendered in-game as Blue SP: `new Color(0.2f, 0.6f, 1f)`). Only `whale_rejuvenate` uses Blue SP threshold at Ranks 3–4 (12 Blue SP).
- **Physical & Shield-Based Damage Scaling**:
  - **ATK Scaling**: `0.5 × ATK` on `whale_sweep`, `whale_javelin`, `whale_peninsulaImpale`, and `whale_peninsulaRound`; `0.7 × ATK` on `whale_bowlingWhale`; `1.0 × ATK` on `whale_grandTide`; and `0.2 × ATK` on `whale_12thKingdomKnight`.
  - **DEF Scaling (Unique to Whale)**:
    - `whale_shieldRush`: `Floor(0.5 × sLv × DEF) + talAdjust(10 × sLv)`.
    - `whale_flyingShield`: `Floor(0.5 × sLv × DEF) + talAdjust(10 × sLv)`.
    - `whale_homingShield`: `0.5 × DEF + talAdjust(20)`.
  - **Weight Scaling (Whale Wave & Hydro Blast)**:
    - `whale_whaleWave`: Ground smash dealing `talAdjust(WhaleWeight × (0.5 + 0.5×sLv))` scaled by distance from impact (100 / 150 TAL at base 100 weight).
    - `whale_hydroBlast`: Vertical water geyser dealing `talAdjust(10×sLv + 10) + TargetWeight`.
- **Healing & Protective Bubble Mechanics**:
  - `whale_rejuvenate`: Periodic regeneration ticking every 4s over 18s. Each tick restores `6×sLv + 6 + Floor(0.004 × sLv × TargetMaxHP)`.
  - `whale_revitalize`: Casts Rejuvenate Rank 3 on all allies within 12m radius, ticking every 4s for `24 + Floor(0.012 × TargetMaxHP)`.
  - `whale_bubbleShield`: Absorbs 50% of incoming damage up to `30 + 10×sLv` HP. When expired (12s) or broken, explodes in an 8m AoE dealing `talAdjust(10×sLv + 20)` magic damage.
  - `whale_bubbleBurst`: Passively adds +1 effective rank and +20 TAL burst damage to Bubble Shield; active trigger detonates all shields immediately.
  - `whale_salvation`: Grants 100% damage invulnerability to all allies in range for `chaAdjust(2×sLv + 2)` seconds (4s at R1, 6s at R2).
- **Passive Skill Hooks & Dependencies**:
  - **Knight of the Deep** (`whale_knightOfTheDeep1`, single-rank passive): Reduces weapon-skill cooldowns by skill-specific flat amounts:
    - Sweep: -10s (30s → 20s)
    - Javelin: -10s (30s → 20s)
    - Shield Rush: -15s (45s → 30s)
    - Flying Shield: -15s (45s → 30s)
    - Peninsula Impale: -30s (90s → 60s)
    - Peninsula Round: -40s (120s → 80s)
    - Homing Shield: -40s (120s → 80s)
  - **Tide Cutter** (`whale_tideCutter5`, single-rank passive, `hasSkill(402)`): Increases Sweep base damage by +20 TAL (`talAdjust(5 + 5×sLv + 20)`), extends Sweep range by 2m, and increases Javelin base damage by +10 TAL (`talAdjust(10×sLv + 10)`).
  - **Reduced Cast** (`whale_reducedCast1`, single-rank passive): Halves base cast time (post-multiply `× 0.5`) across all 8 cast-bar spells (`bubbleShield`, `heavyWeight`, `hydroBlast`, `rejuvenate`, `callToArm`, `salvation`, `megalodon`, `revitalize`).
  - **Wonder Belly** (`whale_wonderBelly1`, single-rank passive): Adds +3s base duration to `whale_swallow`.

---

## 2. Whale Skill Reference Table

| Skill ID | Name | Max Rank | Cost (Base) | Cooldown (Base) | Cast Time (Base) | Duration (Base) | Formula / Effect | KO | Notes |
| :--- | :--- | :---: | :---: | :---: | :---: | :---: | :--- | :---: | :--- |
| `whale_sweep` | Sweep | 2 | [0, 10] MP, [12, 8] SP (red) | 30s | 0s | — | `0.5×ATK + talAdjust(5 + 5×sLv + 20×depLv)` | 2 | 2 hits. Each hit deals 0.5×ATK + talAdjust(5 + 5×sLv + 20×depLv), KO=2 per hit. Knight of the Deep reduces CD by -10s. Tide Cutter adds +20 TAL. |
| `whale_javelin` | Javelin | 2 | 10 MP, [8, 12] SP (red) | 30s | 0s | — | `0.5×ATK + talAdjust(10×sLv + 10×depLv)` | 1 | Pierces enemies in a straight line dealing 0.5×ATK + talAdjust(10×sLv + 10×depLv), KO=1, applying puncture. Knight of the Deep reduces CD by -10s. Tide Cutter adds +10 TAL. |
| `whale_honor` | Honor | 4 | [10, 12, 14, 16] MP, no SP | 60s | 0s | 12s | Buff / Taunt (No Damage Formula) | — | Grants honor to all allies in 15m radius, adding +10×sLv to CHA only (no ATK/DEF; sLv is 1–4, so +10/20/30/40) for 12s (`chaAdjusted`). Taunts enemies in 18+6×sLv meters with hate `floor((0.5×sLv+0.5)×casterCHA)` (+500 with Honor Stand). See §3.13. |
| `whale_shieldRush` | Shield Rush | 2 | 0 MP, [15, 18] SP (red) | 45s | 0s | — | `Floor(0.5×sLv×DEF) + talAdjust(10×sLv)` | 10×sLv | Charging shield slam dealing 0.5×sLv×DEF + talAdjust(10×sLv), knocking targets down with KO=10×sLv. Knight of the Deep reduces CD by -15s. |
| `whale_flyingShield`| Flying Shield | 2 | 0 MP, [16, 20] SP (red) | 45s | 0s | — | `Floor(0.5×sLv×DEF) + talAdjust(10×sLv)` | 10×sLv | Throws boomerang shield dealing Floor(0.5×sLv×DEF) + talAdjust(10×sLv), KO=10×sLv to all targets in its path. Knight of the Deep reduces CD by -15s. |
| `whale_homingShield`| Homing Shield | 1 | 0 MP, 24 SP (red) | 120s | 0s | 3s | `0.5×DEF + talAdjust(20)` | 10 | Multi-hit homing projectile dealing 0.5×DEF + talAdjust(20), KO=10 per hit. Imposes 3s noShield status. Knight of the Deep reduces CD by -40s. |
| `whale_swallow` | Swallow | 2 | 0 MP, [10, 15] SP (red) | 90s | 0s | Contested (12s base) | Utility / Disable (No Damage Formula) | — | Pulls target (9m / 15m). Swallows smaller target, disabling it and adding 50% of its weight to Whale for 12s base (`chaAdjusted`, contested, +3s with Wonder Belly). |
| `whale_gobbleUp` | Gobble Up | 1 | 0 MP, 5 SP (red) | 60s | 0s | — | `talAdjust(30)` | 15 | Requires swallowed target in mouth. Spits target out dealing talAdjust(30), KO=15. |
| `whale_peninsulaImpale` | Peninsula Impale | 2 | 0 MP, [18, 24] SP (red) | 90s | 0s | — | `6 × [0.5×ATK + talAdjust(5×sLv + 5)]` | 1 | 6 strikes. Each strike deals 0.5×ATK + talAdjust(5×sLv + 5), KO=1. Knight of the Deep reduces CD by -30s. |
| `whale_peninsulaRound` | Peninsula Round | 2 | 0 MP, [20, 25] SP (red) | 120s | 0s | — | `5 × [0.5×ATK + talAdjust(5×sLv + 5)]` | 1 | 5 spins dealing 0.5×ATK + talAdjust(5×sLv + 5), KO=1 each. Redirects incoming projectiles. Knight of the Deep reduces CD by -40s. |
| `whale_12thKingdomKnight` | 12th Kingdom Knight | 2 | 0 MP, [45, 60] SP (red) | 600s | 0s | 60s | `0.2×ATK + talAdjust(5×sLv)` | 1 | Summons 4 Kingdom Knights for 60s. Each knight attacks dealing 0.2×ATK + talAdjust(5×sLv), KO=1. |
| `whale_bubbleShield`| Bubble Shield | 4 | [6, 8, 10, 12] MP, 0 SP | 30s | 4.5s | 12s | `talAdjust(10×sLv + 20)` (Burst) | — | Bubble shield absorbs 50% damage up to 30+10×sLv HP. Explodes upon breaking or after 12s dealing talAdjust(10×sLv + 20) in 8m AoE. Reduced Cast halves cast time. |
| `whale_heavyWeight` | Heavy Weight | 2 | [10, 14] MP, 0 SP | 60s | 4s | Contested (15s base) | Debuff (No Damage Formula) | — | Target weight increased by 15×sLv and run speed reduced by sLv for 15s base (`chaAdjusted`, contested). Reduced Cast halves cast time. |
| `whale_hydroBlast` | Hydro Blast | 4 | [8, 12, 16, 20] MP, 0 SP | 60s | 4.5s | — | `talAdjust(10×sLv + 10) + TargetWeight` | sLv | Launches target into the air dealing talAdjust(10×sLv + 10) + TargetWeight, KO=sLv. Reduced Cast halves cast time. |
| `whale_rejuvenate` | Rejuvenate | 4 | [10, 15, 20, 25] MP, [0, 0, 12, 12] SP (blue) | 90s | 5.5s | 18s | `6×sLv + 6 + Floor(0.004×sLv×MaxHP)` | 0 | Heals target every 4s for 18s. Each tick heals 6×sLv + 6 + Floor(0.004×sLv×TargetMaxHP). Reduced Cast halves cast time. |
| `whale_whaleWave` | Whale Wave | 2 | 0 MP, [12, 16] SP (red) | 60s | 0s | — | `talAdjust(WhaleWeight × (0.5 + 0.5×sLv))` | 1-3 | Ground smash AoE (6m radius). Deals talAdjust(WhaleWeight × (0.5 + 0.5×sLv)) scaled by distance (100 / 150 TAL at base 100 weight). |
| `whale_malStorm` | Mal Storm | 2 | 0 MP, [18, 24] SP (red) | 60s | 0s | — | `4 × talAdjust(20×sLv + 10)` | 1 | Storm AoE (8m radius). 4 lightning strikes, each dealing talAdjust(20×sLv + 10), KO=1. |
| `whale_callToArm` | Call To Arm | 1 | 15 MP, 0 SP | 120s | 5s | — | `talAdjust(30)` | 10 | Teleports to the ally with lowest HP, releasing a shockwave that deals talAdjust(30), KO=10, Hate=10. Reduced Cast halves cast time. |
| `whale_salvation` | Salvation | 2 | [24, 36] MP, 0 SP | 240s | 5s | [4, 6]s | Invulnerability (No Damage Formula) | — | Grants 100% damage invulnerability to all allies within area for chaAdjust(2×sLv + 2) seconds (4s / 6s). Reduced Cast halves cast time. |
| `whale_megalodon` | Megalodon | 2 | [30, 45] MP, [25, 35] SP (red) | 240s | 8s | — | `2 × talAdjust(100×sLv + 100)` | 1 | Ancient leviathan bites twice dealing talAdjust(100×sLv + 100) per bite (400 / 600 TAL total), KO=1 each. Reduced Cast halves cast time. |
| `whale_bubbleBurst` | Bubble Burst | 1 | Free (0 MP, 0 SP) | 60s | 0s | — | Active Detonation (No Damage Formula) | — | Passively adds +1 effective rank and +20 TAL burst to Bubble Shield. Active: instantly detonates all active Bubble Shields. |
| `whale_revitalize` | Revitalize | 1 | 60 MP, 0 SP | 180s | 6s | 18s | `24 + 1.2% Max HP` | 0 | Casts Rejuvenate Rank 3 on all allies in 12m radius, healing 24 + Floor(0.012×MaxHP) every 4s for 18s. Reduced Cast halves cast time. |
| `whale_bowlingWhale`| Bowling Whale | 1 | 0 MP, 25 SP (red) | 180s | 0s | — | `0.7×ATK + talAdjust(35)` | 1 | Curls into a ball and rolls through enemies dealing 0.7×ATK + talAdjust(35), KO=1, knocking targets away. |
| `whale_grandTide` | Grand Tide | 1 | 30 MP, 20 SP (red) | 300s | 0s | Channeled | `1.0×ATK + talAdjust(200)` (per tick) | 0 | Channeled tsunami sweeping forward. Drains 10 MP and 20 SP (10 SP with Revised Skill) per sec, dealing 1.0×ATK + talAdjust(200) per tick. |

---

## 3. Verified Code Citations

### 3.1 Sweep (`Whale.cs:20601–20610`, `Whale.cs:22879–22883`)
```csharp
case 1:
    this.mChar.cMp = ((this.skillSlot[0] != 0) ? 10 : 0);
    this.mChar.cSp = ((this.skillSlot[0] != 0) ? -8 : -12);
    this.mChar.addTimeOut(0, (float)(30 - (this.hasSkill(115) ? 10 : 0)));
    this.RPC_sweep(base.transform.position, this.skillSlot[0] + 1);
```
Damage dealing (`Whale.cs:22879–22883`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(5 + 5 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 2, 0, 1, 0, false, 0);
```

### 3.2 Javelin (`Whale.cs:20623–20632`, `Whale.cs:22960–22965`)
```csharp
case 2:
    this.mChar.cMp = 10;
    this.mChar.cSp = ((this.skillSlot[1] != 0) ? -12 : -8);
    this.mChar.addTimeOut(1, (float)(30 - (this.hasSkill(115) ? 10 : 0)));
    this.RPC_javelin(vector, this.skillSlot[1] + 1);
```
Damage dealing (`Whale.cs:22960–22965`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(10 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
characterControl.addStatus("puncture", this.mChar.chaAdjust(12f), 1, true);
```

### 3.3 Shield Rush (`Whale.cs:20658–20668`, `Whale.cs:23113–23118`)
```csharp
case 4:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[3] != 0) ? -18 : -15);
    this.mChar.addTimeOut(3, (float)(45 - (this.hasSkill(115) ? 15 : 0)));
    this.RPC_shieldRush(this.skillSlot[3] + 1);
```
Damage dealing (`Whale.cs:23113–23118`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(10 * sLv)));
num += (int)((float)this.mChar.def * (0.5f * (float)sLv));
damage.hit(characterControl, num, 10 * sLv, 0, 1, 0, false, 0);
```

### 3.4 Flying Shield (`Whale.cs:20677–20687`, `Whale_flyingShield.cs:51–56`)
```csharp
case 5:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[4] != 0) ? -20 : -16);
    this.mChar.addTimeOut(4, (float)(45 - (this.hasSkill(115) ? 15 : 0)));
    this.RPC_flyingShield(vector, this.skillSlot[4] + 1);
```
Damage dealing (`Whale_flyingShield.cs:51–56`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust((float)(10 * this.sLv)));
num += (int)((float)this.mWhale.mChar.def * (0.5f * (float)this.sLv));
damage.hit(characterControl, num, 10 * this.sLv, 0, 1, 0, false, 0);
```

### 3.5 Homing Shield (`Whale.cs:20696–20706`, `Whale_homingShield.cs:105–109`)
```csharp
case 6:
    this.mChar.cMp = 0;
    this.mChar.cSp = -24;
    this.mChar.addTimeOut(5, (float)(120 - (this.hasSkill(115) ? 40 : 0)));
    this.RPC_homingShield(this.mTarget.transform.position, this.skillSlot[5] + 1);
```
Damage dealing (`Whale_homingShield.cs:105–109`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust(20f));
num += (int)((float)this.mWhale.mChar.def * 0.5f);
damage.hit(characterControl, num, 10, 0, 1, 0, false, 0);
characterControl.addStatus("noShield", this.mWhale.mChar.chaAdjust(3f), 1, true);
```

### 3.6 Peninsula Impale (`Whale.cs:20743–20753`, `Whale.cs:23253–23258`)
```csharp
case 9:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[8] != 0) ? -24 : -18);
    this.mChar.addTimeOut(8, (float)(90 - (this.hasSkill(115) ? 30 : 0)));
    this.RPC_peninsulaImpale(this.skillSlot[8] + 1);
```
Damage dealing (`Whale.cs:23253–23258`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(5 + 5 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.7 Peninsula Round (`Whale.cs:20762–20772`, `Whale.cs:23293–23298`)
```csharp
case 10:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[9] != 0) ? -25 : -20);
    this.mChar.addTimeOut(9, (float)(120 - (this.hasSkill(115) ? 40 : 0)));
    this.RPC_peninsulaRound(this.skillSlot[9] + 1);
```
Damage dealing (`Whale.cs:23293–23298`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust((float)(5 + 5 * sLv)));
num += (int)((float)this.mChar.atk * 0.5f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.8 Whale Wave (`Whale.cs:20888–20898`, `Whale.cs:23447–23454`)
```csharp
case 16:
    this.mChar.cMp = 0;
    this.mChar.cSp = ((this.skillSlot[15] != 0) ? -16 : -12);
    this.mChar.addTimeOut(15, 60f);
    this.RPC_whaleWave(this.skillSlot[15] + 1);
```
Damage dealing (`Whale.cs:23447–23454`):
```csharp
num = this.mChar.talAdjust((float)this.mChar.weight * (0.5f + 0.5f * (float)sLv));
num = (int)((float)num * (1f - num2 / 6f));
num = this.mChar.dmgAdjust((float)num);
damage.hit(characterControl, num, UnityEngine.Random.Range(1, 4), 0, 1, 0, false, 0);
```

### 3.9 Rejuvenate (`Whale.cs:20857–20875`, `Whale.cs:23707–23712`, `CharacterControl.cs:9123–9136`)
```csharp
case 15:
    this.mChar.cMp = 10 + 5 * this.skillSlot[14];
    this.mChar.cSp = ((this.skillSlot[14] <= 1) ? 0 : 12);
    this.mChar.addTimeOut(14, 90f);
    base.StartCoroutine(this.DisplayCastBar(5.5f * (this.hasSkill(137) ? 0.5f : 1f)));
    this.RPC_rejuvenate(characterControl, this.skillSlot[14] + 1);
```
Status effect tick in `CharacterControl.cs:9123–9136`:
```csharp
case "rejuvenate":
    num = 6 * this.statusLevel[i] + 6;
    num += (int)((float)this.mhp * (0.004f * (float)this.statusLevel[i]));
    this.hp += num;
    this.RPC_AddHeal(num);
```

### 3.10 Megalodon (`Whale.cs:20947–20959`, `Whale_megalodon.cs:81–85`)
```csharp
case 20:
    this.mChar.cMp = 30 + 15 * this.skillSlot[19];
    this.mChar.cSp = ((this.skillSlot[19] != 0) ? -35 : -25);
    this.mChar.addTimeOut(19, 240f);
    base.StartCoroutine(this.DisplayCastBar(8f * (this.hasSkill(137) ? 0.5f : 1f)));
    this.RPC_megalodon(this.mTarget.transform.position, this.skillSlot[19] + 1);
```
Damage dealing (`Whale_megalodon.cs:81–85`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust((float)(100 + 100 * this.sLv)));
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.11 Bowling Whale (`Whale.cs:20986–20996`, `Whale.cs:23851–23856`)
```csharp
case 23:
    this.mChar.cMp = 0;
    this.mChar.cSp = -25;
    this.mChar.addTimeOut(22, 180f);
    this.RPC_bowlingWhale(vector, 1);
```
Damage dealing (`Whale.cs:23851–23856`):
```csharp
num = this.mChar.dmgAdjust(this.mChar.talAdjust(35f));
num += (int)((float)this.mChar.atk * 0.7f);
damage.hit(characterControl, num, 1, 0, 1, 0, false, 0);
```

### 3.12 Grand Tide (`Whale.cs:20999–21008`, `Whale_grandTide.cs:93–98`)
```csharp
case 24:
    this.mChar.cMp = 30;
    this.mChar.cSp = -20;
    this.mChar.addTimeOut(23, 300f);
    this.RPC_grandTide(1);
```
Damage dealing (`Whale_grandTide.cs:93–98`):
```csharp
num = this.mWhale.mChar.dmgAdjust(this.mWhale.mChar.talAdjust(200f));
num += (int)((float)this.mWhale.mChar.atk * 1f);
damage.hit(characterControl, num, 0, 0, 1, 0, false, 0);
```
Per-second drain (`Whale_grandTide.cs:72–79`):
```csharp
this.mWhale.mChar.cMp = 10;
this.mWhale.mChar.cSp = (this.mWhale.hasSkill(126) ? -10 : -20);
```

### 3.13 Honor (`Whale.cs:23500-23900`, `CharacterControl.cs:35558`, `:15894`, `:4370-4400`)
- **Cost:** `python scripts/decode_skilldata.py DecompiledSource/WhaleSkill.cs` → `whl_honor1-4`: MP 10/12/14/16, SP 0, `instant`, reqLv 5/11/17/23, reqBn 1/3/5/7. The cast site (`Whale.cs:7804`) deducts nothing itself. The earlier `[10, 15, 20, 25] MP + 15 SP (red)` row had no source and was removed (2026-09-20).
- **Cast:** `addTimeOut("honor", agiAdjust(60f))` (`Whale.cs:23695`); allies via `Damage.FindAreaTarget(pos, 15×rangeMod, 3×rangeMod, ownLayer)` (`:23844`) each get `RPC_AddStatus("honor", sLv, chaAdjust(12), 0, casterId)` (`:23868`).
- **CHA:** `deltaCha(10 × sLv)` on apply (`CharacterControl.cs:35558`), `deltaCha(-10 × sLv)` on removal (`:15894`). `sLv` is 1–4 (`Whale.cs:4231-4285`).
- **Hate on enemies:** `FindAreaTarget(pos, 18 + 6×sLv, 6, enemyLayers)` (`Whale.cs:23876`) then `RPC_AddDamage(-1, 0, 0, floor((sLv×0.5+0.5)×caster.cha) + (hasSkill(412) ? 500 : 0), …)` — 100/150/200/250% of the caster's CHA. No `talAdjust`/LCK spread. Client tooltips (`WhaleSkill_eng.cs:253-286`) agree on the 100–250%.
- **Honor Stand (`whl_honorStand5`, skill 412, `WhaleSkill.cs:3155`):** `RPC_AddDamage` reduces incoming KO on a receiver that has skill 412 and the `honor` status: `nKo = floor((1 − 0.1 × honorLv) × nKo)` (`CharacterControl.cs:4370-4400`). **Discrepancy:** both client tooltips say the extra hate is **+300** (`WhaleSkill_eng.cs:939`, `WhaleSkill_thai.cs:966`) but the code adds **+500** (`Whale.cs`, `hasSkill(412) ? 500 : 0`); the code value is used in the app, live observation takes precedence if it differs.
- **Classification:** `honor` is in `isBuffStatus` (`StatusData.cs:6590`) and `isMagicalStatus` (`:5651`) → Buff, Magical. The status-level merge rule for re-application is generic, see [12Tails-Mechanics-Reference.md §4.2.1](12t_reference/12Tails-Mechanics-Reference.md#421-re-applying-an-already-active-status--level-merge-rule-charactercontrolcs14017-14160-inside-rpc_addstatus).

## Server Balance Variations

Base engine (BigBug) values are documented above; this section lists private-server deltas.

### Tailstopia Online (TTO)
- **Honor Stand also adds +1 to Honor's `sLv`** (user-reported from live play, 2026-09-20; server-side change, not visible in `DecompiledSource/`). Base code (`Whale.cs:23500-23900`) uses the single cast `sLv` for the honor status level, so with the +1 all of these follow it: CHA `+10×sLv` (`CharacterControl.cs:35558`), KO reduction `10%×honorLv` (`:4400`), hate `floor((0.5×sLv+0.5)×CHA)` and taunt radius `18+6×sLv` (`Whale.cs:23876`). Example: rank 4 + Honor Stand → `[honor5]`, CHA +50, hate 300%, radius 48m. The bible card models this as `servers.tto` with an Honor Stand dependency toggle (default learned).
