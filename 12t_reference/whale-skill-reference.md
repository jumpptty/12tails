# Whale — Skill Cooldown/Duration Reference

Verified 2026-08-13 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
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
  (`12t_projects/bible/index.html`): `knightOfTheDeep1` is single-rank (`minRank:0,
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


Verified from decompiled source (`DecompiledSource/Whale.cs`, `DecompiledSource/WhaleSkill.cs`, `DecompiledSource/CharacterControl.cs`, and companion scripts) for the Bible skill-details tool (`12t_projects/bible/index.html`).

---

## 1. Summary of Whale Mechanics

- **Resource System (MP, Red SP, Blue SP)**:
  - **MP (Mana Points)**: Consumed on cast by water/shamanic spells.
  - **Red SP (Stamina / Rage)**: `cSP < 0` in decompiled source (`GameGui.cs:37782`). Requires and **consumes** that amount of SP on cast (rendered in-game as Red SP: `new Color(1f, 0.2f, 0.2f)`). Almost all Whale weapon swings and physical maneuvers consume Red SP.
  - **Blue SP (Combo / Action Requirement)**: `cSP > 0` in decompiled source (`GameGui.cs:37609`). Requires a minimum SP threshold to cast but **does not consume SP**. In `WhaleSkill.cs` the positive values are Sweep (+12 / +16), Shield Rush (+15 / +18), Flying Shield (+16 / +20) and Grand Tide (+60 to start, then it drains while channelled). Rejuvenate has **no** SP cost (an earlier version of this note said 12 blue SP at ranks 3-4; `decode_skilldata.py` shows 0).
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
  - `whale_revitalize`: casts `rejuvenate` level 3 on every Player-tagged member under the Whale's team parent (no distance check in the coroutine, `Whale.cs:36191-36236`), `chaAdjust(18)` s; each tick heals `6·3 + 6 + floor(0.004·3·MaxHP)` = `24 + floor(0.012 × MaxHP)`. While learned, the Whale's own Rejuvenate casts get +1 level (`Whale.cs:31336-31342`).
  - `whale_bubbleShield`: the status carries a pool `talAdjust(10·sLv + 20 (+20 with Bubble Burst))`; each direct hit is cut by 50% and the pool loses that half, until the pool is empty (`CharacterControl.cs:30996-31042`). The status level is `sLv` (+1 with Bubble Burst). **Nothing explodes when it expires or breaks** (the removal handler only destroys the effect, `CharacterControl.cs:16085-16101`); the tooltip's explosion only exists as Bubble Burst's active cast.
  - `whale_bubbleBurst`: passive part: Bubble Shield +1 level and +20 inside its `talAdjust` (`Whale.cs:29653`, `:29722`). Active cast: every Bubble Shield cast by this Whale within 200 m detonates, dealing `RPC_AddEffectDamage(1, remaining pool)` to enemies within 12 m (height 3) of that shield, then the shield is removed (`Whale.cs:35811-35932`).
  - `whale_salvation`: gives `salvation` (Lv = rank) for `chaAdjust(2·sLv + 2)` s (4 / 6 s base) to every living Player-tagged member under the Whale's team parent **except the Whale itself** (`Whale.cs:33749-33788`; no distance check in the coroutine). It removes incoming hits entirely; `puncture` strips it.
    - **Tooltip mismatch (found 2026-10-03):** TH "ทำให้เพื่อนทุกคนในระยะนอก จาก ปลาวาฬเป็นอมตะชั่วขณะ หนึ่ง (5sec)" / "(8sec)" (`WhaleSkill_thai.cs:849`, `:860`). The code gives `chaAdjust(4 / 6)` and has no range check. Card `tooltipNote`.
- **Passive Skill Hooks & Dependencies**:
  - **Knight of the Deep** (`whale_knightOfTheDeep1`, single-rank passive): Reduces weapon-skill cooldowns by skill-specific flat amounts:
    - Sweep: -10s (30s → 20s)
    - Javelin: -10s (30s → 20s)
    - Shield Rush: -15s (45s → 30s)
    - Flying Shield: -15s (45s → 30s)
    - Peninsula Impale: -30s (90s → 60s)
    - Peninsula Round: -40s (120s → 80s)
    - Homing Shield: -40s (120s → 80s)
    - **Round Table (charge hook, verified 2026-09-24):** Whale's charge coroutine (`cAttack1`, shield stance: self `shield` status, SP −1 per second, auto-release `RPC_cAttack2` at SP 0) starts `RPC_roundTable()` whenever `hasSkill(273)` (`Whale.cs:18849-18855`). `$RPC_roundTable$28794` (`Whale.cs:29121-29460`): first wait 0.5 s (ring effect + voice), then every **0.5 s** while the summoned-knight list `zcKmUWwWZx` is non-empty (re-read each tick; empty → coroutine ends) and Whale is still `attack`/`cAttack1`: `FindAreaTarget(pos, 4, 3)` (**radius 4 m, height 3 m** around Whale), `hit(276, floor(0.2·ATK + 15·knights), KO 1)` on each target, then `sp = clamp(sp − 1, 0, 100)`. So the charge drains **3 SP/s** in total while Round Table runs. Knights = `2 + 2·sLv` of 12th Kingdom Knight (`Whale.cs:28414`) → flat part 60 / 90 at full count, which is exactly the 12th Kingdom Knight card's `Charge` group `30 + 30×sLv`.
    - **Knight side:** each knight starts `knightGuard()` while its owner is in `cAttack1` with #273 (`whale_kingdomKnight.cs:214`), which is movement/pose only (no `hit`). Each Round Table tick also sets `xGymEi83FK = now + 3` (`:29447`), the same gate as the knights' 3 s auto-attack in `KingdomKnight()` (`Whale.cs:9650-9720`, nearest target within 8 m, skipped while Whale is in `cAttack1`), so auto-attacks resume up to 3 s after the last tick.
    - **Tooltip mismatch:** EN `"Enables summoned knights to perform a special attack when Whale is charging. Also reduces cooldown of Jevalin and FlyingShield by 18 sec."` (`WhaleSkill_eng.cs:528`) / TH `"ปลดล๊อกท่าชาร์จของ kingdomKnights และลด cd ท่า Jevalin และ FlyingShield ลง 18 วินาที"` (`WhaleSkill_thai.cs:559`). The code reduces seven skills by the amounts above (none by 18 s), and the "special attack" is Whale's own `hit(276)` from Whale's position, scaled by Whale's ATK plus 15 per knight.
  - **Tide Cutter** (`whale_tideCutter5`, single-rank passive, `hasSkill(402)`): Increases Sweep base damage by +20 TAL (`talAdjust(5 + 5×sLv + 20)`), extends Sweep range by 2m, and increases Javelin base damage by +10 TAL (`talAdjust(10×sLv + 10)`).
  - **Reduced Cast** (`whale_reducedCast1`, #373, single-rank passive): in the cast dispatcher the base cast time becomes `floor(0.5 × base)` **before** `magAdjust` (`Whale.cs:21245-21260`), for Bubble Shield, Heavy Weight, Hydro Blast, Rejuvenate, Call To Arm, Salvation, Megalodon and Revitalize. Because of the floor, a 3 s cast becomes 1 s, a 3.5 s one becomes 1 s, a 4.5 s one 2 s.
  - **Wonder Belly** (`whale_wonderBelly5`, #432, passive): Swallow's contested base duration is 15 instead of 12 and its pull force is +1 (`Whale.cs:25811`, `:25894`). The Whale's `gobble` status also ticks every 5 s: an allied swallowed target is healed `0.05 × Whale MaxHP`; an enemy takes `RPC_AddDamage(342, defAdjust(0.05 × Whale MaxHP))`, a direct hit that its DEF reduces (`CharacterControl.cs:8939-9005`).

---

## 2. Whale Skill Reference Table (re-verified 2026-10-01)

Costs from `scripts/decode_skilldata.py DecompiledSource/WhaleSkill.cs` (negative SP = red / consumed, positive = blue threshold); cooldowns, casts and effects from the cited coroutines in `Whale.cs`. "KotD" = Knight of the Deep (§1). Cast times are base values per rank, before Reduced Cast and `magAdjust`. The previous version of this table and §3.1-3.12 quoted code that does not exist in the decompile (`skillSlot`, `cMp`, `damage.hit`) and has been removed.

| Skill | Ranks | Cost (MP / SP) | Cooldown | Cast | Duration | Formula / effect | KO |
| :--- | :---: | :--- | :---: | :---: | :---: | :--- | :---: |
| Sweep | 2 | 0 / +12, +16 | 30 (−10 KotD) | 0 | — | 2 hits (areas in §3.15), each `0.5×ATK + talAdjust(5 + 5·sLv (+20 Tide Cutter))` (`Whale.cs:21914`, `:22163`) | 2 |
| Javelin | 2 | 0 / −8, −12 | 30 (−10) | 0 | — | `0.5×ATK + talAdjust(10·sLv (+10 Tide Cutter))` (`Whale_javelin.cs:314`) | 5 |
| Honor | 4 | 10 / 12 / 14 / 16 / 0 | 60 | 0 | `chaAdjust(12)` | CHA buff and taunt (§3.13) | — |
| Shield Rush | 2 | 0 / +15, +18 | 45 (−15) | 0 | — | `0.5·sLv·DEF + talAdjust(10·sLv)` (`Whale.cs:24295`) | 10·sLv |
| Flying Shield | 2 | 0 / +16, +20 | 45 (−15) | 0 | — | `floor(0.5·sLv·DEF) + talAdjust(10·sLv)` (`Whale_flyingShield.cs:210`) | 5·sLv |
| Homing Shield (#422) | 1 | 0 / −24 | 120 (−40) | 0 | `chaAdjust(3)` | `0.5×DEF + talAdjust(20)` per pass (§3.15) | 10 |
| Swallow | 2 | 0 / −10, −15 | 90 | 0 | contested 12 (15 Wonder Belly) | `FindRecTarget(pos, fwd, 1, 1, 2, 3)` (2 m wide × 2 m); needs `recieveForce` and a target **shorter than the Whale** (else RESIST); pulls toward the Whale with force `sLv (+1)`, `swallow` on the target, `gobble` (sValue = `ceil(0.5 × target weight)`) on the Whale (`Whale.cs:25726-25894`) | — |
| Gobble Up (`gobbleUp`) | 1 | 0 / −5 | 60 | 0 | — | needs a swallowed target ("mouth is empty!"); `FindAreaTarget(target, 3, 3)`, `hit(233, talAdjust(30), KO 15)` (`Whale.cs:26263-26286`) | 15 |
| Peninsula Impale | 2 | 0 / −18, −24 | 90 (−30) | 0 | — | `2 + 4·sLv` stabs (6 / 10), each `0.5×ATK + talAdjust(5·sLv + 5 (+10 Asunder))` (`Whale.cs:27000`) | 1 |
| Peninsula Round | 2 | 10, 15 / −21, −30 | 120 (−40) | 0 | — | 5 / 7 hits (every 4th step of `12 + 8·sLv`), each `0.5×ATK + talAdjust(5·sLv + 5)` (`Whale.cs:28129`) | 1 |
| 12th Kingdom Knight | 2 | 0 / −45, −65 | 600 | 0 | `chaAdjust(60)` | `2 + 2·sLv` knights (4 / 6); knight hit `(int)(0.2×ATK + 10·sLv)` (§3.15) | 1 |
| Bubble Shield | 4 | 6 / 10 / 14 / 18 / 0 | 30 | 3 / 3.5 / 4 / 4.5 | `chaAdjust(12)` | pool `talAdjust(10·sLv + 20 (+20 Bubble Burst))`, cuts each hit by 50% (§1) | — |
| Heavy Weight | 2 | 10 / 14 / 0 | 60 | 3 / 4 | enemy: contested 15; ally: `chaAdjust(15)` | `heavy` Lv sLv (+1 Over Weight): weight +15·Lv, `moveMod` −0.1·Lv, run speed capped at `runSpeed − Lv` (`CharacterControl.cs:35924-35955`, `:2341-2347`) | — |
| Hydro Blast | 4 | 8 / 12 / 16 / 20 / 0 | 60 | 3 / 3.5 / 4 / 4.5 | — | `hit(320 + sLv, talAdjust(10·sLv + 10 (+20 Spiral Blast)) + target weight)`, area radius 1 m (2 Spiral Blast) × 6 m (`Whale.cs:9975-10060`) | sLv |
| Rejuvenate | 4 | 10 / 14 / 18 / 22 / 0 | 90 | 4 / 4.5 / 5 / 5.5 | `chaAdjust(18)` | every 4 s `6·Lv + 6 + floor(0.004·Lv·MaxHP)`, Lv = rank (+1 with Revitalize) (`CharacterControl.cs:8874-8898`) | — |
| Whale Wave | 2 | 0 / −12, −15 | 60 | 0 | — | radius 6 m, `ceil(talAdjust(floor(weight × (0.5 + 0.5·sLv))) × (1 − 0.05 × distance))` (`Whale.cs:31973`) | 5·sLv |
| Mal Storm | 2 | 16, 24 / −20, −20 | 60 | 0 | — | 4 strikes (`i < 4`), radius 8 m, each `talAdjust(20·sLv + 10)` (`Whale.cs:32663-32736`) | 1 |
| Call To Arm (`callToArm`) | 1 | 0 / 0 (reqLv 24, reqBn 15) | 120 | 5 | — | teleports to the lowest-HP ally; then `FindAreaTarget(Whale, 12, 3)`, `hit(361, talAdjust(30), KO 10, hate 10)` (`Whale.cs:33198-33221`) | 10 |
| Salvation | 2 | 24 / 32 / 0 | 240 | 5 | `chaAdjust(2·sLv + 2)` = 4 / 6 | invulnerability to every living teammate except the Whale (§1) | — |
| Megalodon | 2 | 45 / 65 / −20, −30 | 240 | 6 / 8 | — | 4 pull ticks + 2 bites `talAdjust(100·sLv + 100)` (§3.15) | 1 |
| Bubble Burst (#403) | 1 | 10 / −10 | 60 | 0 | — | detonates the Whale's Bubble Shields (§1) | — |
| Revitalize (#433) | 1 | 60 / 0 | 180 | 6 | `chaAdjust(18)` | `rejuvenate` Lv 3 on the team (§1) | — |
| Bowling Whale (#434) | 1 | 45 / −45 | 180 | 0 | 6 s | steerable roll at `moveSpeed 7`; every 0.25 s (up to 24 ticks) enemies within 3 m (height 3): `hit(434, 0.7×ATK + talAdjust(35), KO 1)`; `removeLockStatus(5)` every 0.5 s (`Whale.cs:36706-36867`) | 1 |
| Grand Tide (#434) | 1 | 30 / +60 | 300 | 0 | channel | needs MP ≥ 10 and SP ≥ 20 each second; each second −10 MP (−8 with Revised Magic) and −20 SP (−10 with Revised Skill); `hit(444, ATK + talAdjust(200), KO 0)` in `FindRecTarget(pos − 4×fwd, fwd, 8, 8, 7, 4)` (`Whale.cs:37589-37655`) | 0 |

---

## 3. Verified Code Citations

(§3.1-3.12 were removed 2026-10-01: they quoted code that does not exist in `DecompiledSource/`. Their verified content is in the §2 table above and §3.15 below.)


### 3.13 Honor (`Whale.cs:23500-23900`, `CharacterControl.cs:35558`, `:15894`, `:4370-4400`)
- **Cost:** `python scripts/decode_skilldata.py DecompiledSource/WhaleSkill.cs` → `whl_honor1-4`: MP 10/12/14/16, SP 0, `instant`, reqLv 5/11/17/23, reqBn 1/3/5/7. The cast site (`Whale.cs:7804`) deducts nothing itself. The earlier `[10, 15, 20, 25] MP + 15 SP (red)` row had no source and was removed (2026-09-20).
- **Cast:** `addTimeOut("honor", agiAdjust(60f))` (`Whale.cs:23695`); allies via `Damage.FindAreaTarget(pos, 15×rangeMod, 3×rangeMod, ownLayer)` (`:23844`) each get `RPC_AddStatus("honor", sLv, chaAdjust(12), 0, casterId)` (`:23868`).
- **CHA:** `deltaCha(10 × sLv)` on apply (`CharacterControl.cs:35558`), `deltaCha(-10 × sLv)` on removal (`:15894`). `sLv` is 1–4 (`Whale.cs:4231-4285`).
- **Hate on enemies:** `FindAreaTarget(pos, 18 + 6×sLv, 6, enemyLayers)` (`Whale.cs:23876`) then `RPC_AddDamage(-1, 0, 0, floor((sLv×0.5+0.5)×caster.cha) + (hasSkill(412) ? 500 : 0), …)` — 100/150/200/250% of the caster's CHA. No `talAdjust`/LCK spread. Client tooltips (`WhaleSkill_eng.cs:253-286`) agree on the 100–250%.
- **Honor Stand (`whl_honorStand5`, skill 412, `WhaleSkill.cs:3155`):** `RPC_AddDamage` reduces incoming KO only when the receiver is a **Whale** (the whole block sits inside `if (this.Type == "Whale")`, `CharacterControl.cs:4299`), has skill 412 and has the `honor` status: `nKo = floor((1 − 0.1 × honorLv) × nKo)` (`CharacterControl.cs:4371-4400`). Other classes' own 412 passives do not trigger it. (A first read of this block missed the class gate and wrongly concluded it was class-agnostic; corrected 2026-09-20.) **Discrepancy:** both client tooltips say the extra hate is **+300** (`WhaleSkill_eng.cs:939`, `WhaleSkill_thai.cs:966`) but the code adds **+500** (`Whale.cs`, `hasSkill(412) ? 500 : 0`); the code value is used in the app, live observation takes precedence if it differs.
- **Classification:** `honor` is in `isBuffStatus` (`StatusData.cs:6590`) and `isMagicalStatus` (`:5651`) → Buff, Magical. The status-level merge rule for re-application is generic, see [12Tails-Mechanics-Reference.md §4.2.1](12t_reference/12Tails-Mechanics-Reference.md#421-re-applying-an-already-active-status--level-merge-rule-charactercontrolcs14017-14160-inside-rpc_addstatus).

### 3.14 Honor Stand (`WhaleSkill.cs:1088-1133`, `:3155`, `Whale.cs:23914`, `CharacterControl.cs:4299-4400`)
- **Identity/requirements:** `whl_honorStand5`, skill command **412**, `mode = passive`, reqLv 60, reqBn 1, `rSkill = 214` (Honor rank 4) — `python scripts/decode_skilldata.py DecompiledSource/WhaleSkill.cs`. Single rank; the block is duplicated verbatim at `WhaleSkill.cs:1088` and `:1111` (dead-code duplication). Each class has its own skill 412 (Bat Demon Gaze, Sheep Gospel, Penguin Penguin of Arc, …); only Whale's is this one.
- **Extra hate on Honor:** `+ (hasSkill(412) ? 500 : 0)` added to the taunt hate (`Whale.cs:23914`), on top of `floor((0.5×sLv+0.5)×CHA)`. Client tooltips (`WhaleSkill_eng.cs:939`, `WhaleSkill_thai.cs:966`) say **300**; the code value is 500.
- **KO reduction:** the receiver must be a Whale (`if (this.Type == "Whale")`, `CharacterControl.cs:4299`), have skill 412 and the `honor` status; `nKo = floor((1 − 0.1 × honorLv) × nKo)` (`CharacterControl.cs:4371-4400`), so a hit with `nKo == 1` becomes 0.
- **No stat gain, no cost, no cooldown.** TTO: adds +1 to Honor's `sLv` (see Server Balance Variations below).

### 3.15 Weapon / charge skill geometry & behaviour (verified 2026-09-24)

- **Charge (`$RPC_cAttack1$28521`, `Whale.cs:18669-19247`):** self `RPC_AddStatus("shield", sLv, 1200, …)` (`:18843`, sLv = charge rank from `hasSkill(111/112/113)`), SP −1 every 1 s while held, auto `RPC_cAttack2` at SP 0; `cAttack2`/`cAttack0` contain no `hit`. Blocked by `noShield` in `doBeginCharge` (`:8432`).
- **`shield` status:** code per `StatusData.cs:866`, **Buff + Physical** (`isBuffStatus` `:6584`, `isPhysicalStatus` `:5397`); Whale-only (`RPC_AddStatus` gate `CharacterControl.cs:12289`). In the direct-damage `AddDamage` coroutine (`CharacterControl.cs:30855-30960`): `nDamage = max(0, nDamage − 10 − 10·sLv)` and `nForce = zero`. With **Shield Reflect (#411)**: additionally `nDamage −= 0.25·Lv`, and `min(nDamage_before, floor(10 + 10·sLv + 0.25·Lv))` is sent back to the attacker as `RPC_AddEffectDamage(411, …)` (if the attacker accepts effect damage). The reflect is computed **before** the reductions and **includes the base shield amount** (`10 + 10·sLv`, e.g. 40 at `shield3`), not just the Shield Reflect `0.25·Lv` part (`CharacterControl.cs:30869`). **Order:** `RPC_AddDamage` applies `hitMod` first (`:3765`), then starts `AddDamage` (`:5822`/`:6035`, class `$AddDamage$35579` at `:30142`) where this `shield` branch runs, so the flat reduction and the reflect cap act on the post-`hitMod` damage. Effect Damage (`RPC_AddEffectDamage`) never reaches this branch, so the shield does not reduce it.
- **Sweep:** hit 1 `FindAreaTarget(pos, 4 + (Tide Cutter ? 2 : 0), 3·rangeMod)` (`:21743`), hit 2 `FindAreaTarget(pos, 5·rangeMod, 3·rangeMod)` (`:21992`; Tide Cutter does not enlarge it). Each target: `getWallPuncture()` roll → `RPC_AddEffectDamage(251, …)` + `puncture` (`:21809-21814`), else `hit(200+sLv, …, KO 2)` (`:21914`, `:22163`).
- **Javelin (`Whale_javelin.cs`):** a single projectile. `OnTriggerEnter` with layer 0 (terrain) sets it stuck and stops gravity (`:186-205`); `OnTriggerStay` returns immediately once stuck, so it hits only in flight, piercing, at most once per 0.1 s per contact (`:208-314`). Hit: `hit(202+sLv, …, (int)(0.5·ATK + talAdjust(10·sLv + (Tide Cutter ? 10 : 0))), 5, …)` → **KO 5** (card previously said 1).
- **Shield Rush:** dash `moveSpeed = 6·sLv` (`:24179`), `FindRecTarget(pos, fwd, 1·rangeMod, 1·rangeMod, 2·rangeMod, 3·rangeMod)` = **2 m wide × 2 m deep × 3 m tall** (`:24252`), `hit(222+sLv, …, (int)(0.5·sLv·DEF + talAdjust(10·sLv)), 10·sLv, …)` (`:24295`).
- **Flying Shield (`Whale_flyingShield.cs`):** `OnTriggerEnter` hit `hit(222+lv, …, floor(0.5·lv·DEF) + talAdjust(10·lv), 5·lv, 0, 2·up)` (`:210`) → **KO 5×sLv** (card previously 10×sLv; tooltip R2 "10 ko" agrees). The flight path has no code in the class (prefab/animation); tooltip says "in a circle".
- **Peninsula Impale:** `2 + 4·sLv` stabs (`:27039`, `:27076`); box `FindRecTarget(pos, fwd, 1, 1, 6, 3)` = **2 × 6 × 3 m**, with **Peninsula Asunder (#442)** `(1.5, 1.5, 12, 3)` = **3 × 12 m** (`:26830-26838`) and `+10` inside `talAdjust` (`:27000`).
- **Peninsula Round:** loop `i < 12 + 8·sLv`, hit on `i % 4 == 0` (`:27986`, `:28081`) → **5 / 7** hits; box `(1.5, 1.5, 4, 3)` = **3 × 4 × 3 m**, with #442 `FindRecTarget(pos − fwd, fwd, 3, 3, 5, 3)` = **6 m wide × 5 m, starting 1 m behind** (`:28093-28107`); `hit(240+sLv, …, (int)(0.5·ATK + talAdjust(5·sLv + 5)), 1, …)` (`:28129`). **Redirect:** in `RPC_AddDamage` (`CharacterControl.cs:4299-4350`), a Whale in `attack`/`peninsulaRound` sends `nDamage` as `RPC_AddEffectDamage(253, …)` to `FindClosestTarget(pos, 20)` and sets its own `nActionCode = −85` (DEFLECT), `nDamage = nKo = nHate = 0`. Applies to direct damage only. The zeroing is nested inside `if (target found && has CharacterControl)` (`CharacterControl.cs:4323-4367`), so **with no enemy in range the Whale takes the hit normally**. The redirected amount is the post-`hitMod` `nDamage` (`hitMod` at `:3765` runs first). **No status** is granted by the redirect or anywhere in `$RPC_peninsulaRound$28754` (0 `AddStatus`/`addStatus` calls in `Whale.cs:27523-28261`). **`Damage.FindClosestTarget(pos, 20, 130816 − (1 << ownLayer))`** (`Damage.cs:1976`): scans every object tagged `Enemy` or `Player`, keeps those on layers 8–16 other than the Whale's own layer, measures full 3D distance from the Whale (`pos − target.position`, not flattened, no line-of-sight test), and returns the nearest one under 20 m. It has **no dead/HP check** (its sibling `FindClosestNonDeadTarget` does), so the nearest target may be one at 0 HP, in which case the redirected damage is wasted but the Whale still takes 0. The target is simply the nearest enemy, not necessarily the attacker.
- **Homing Shield:** self `RPC_AddStatus("noShield", 1, chaAdjust(3), 40, …)` (`:35211`); projectile `Init(chaAdjust(3), owner, target)` (`Whale.cs:10431`) → lifetime = the same `chaAdjust(3)`; flies 12 m/s, turning toward the target at 4 rad/s (`Whale_homingShield.cs` `Update`), `hit(422, …, (int)(0.5·DEF + talAdjust(20)), 10, 0, up)` on every `OnTriggerEnter` (`:409`), i.e. every pass. `noShield` (**State**, `StatusData.cs:4878`) blocks Flying Shield (`Whale.cs:7655`), Shield Rush (`:7728`) and the charge (`:8432`) with "Whale has no shield!" + MP/SP refund.
- **Combo (verified 2026-10-01, `$RPC_nAttack1-3`, `Whale.cs:15863-18669`):** stage 1 `(int)(0.5·ATK)` (`:16149`), stage 2 two swings `(int)(0.35·ATK)` (`:17016`, `:17418`), stage 3 `(int)(0.6·ATK)` (`:18221`); stage 2 needs #101, stage 3 #102 (`doNormalAttack`, `:8130-8212`); `addTimeOut("nAttack", 1.5)` per stage. Box `FindRecTarget(pos, fwd, 1.5, 1.5, 4 + (Entended Wave #401 ? 3 : 0), 2)` → **3 m wide × 4 m (7 m) × 2 m**, stage 3 half-width 2 → **4 m** (`:16444`, `:17334`, `:17698`, `:18509`). White hit `hit(99, t, getCritPlus(hitDmg), KO 1, …)` (`:16394`, `:17284`, `:17648`, `:18459`) then `onNormalAttackHit` and `sp + 1`. `getCritPlus` (`:15117-15230`) is the standard Marshal 12 / Champion 18 table. **Wall Puncture is rolled once per swing**, before the target loop: a proc sends every target in that swing `RPC_AddEffectDamage(251, hitDmg, KO 0)` + `puncture` and `sp + 1`, with no `getCritPlus` and no item procs (`:16238-16329`). Star Spear (`w_whl59`): with a selected target within `9 m` (`12 m` with #401) only that target is hit, `hitDmg = floor(0.75 × hitDmg)` (`:16169-16229`). Bible: `dmgGroups` + `critProc` + `effectProc` replace with `noCrit`.
- **Wall Puncture proc (verified 2026-09-24):** `getWallPuncture()` (`Whale.cs:9196`) = `lckAdjust(10·wallPunctureLv) > Random.Range(0,100)`, rolled once per swing for Combo (above) and per target per hit elsewhere, at 8 sites: Combo `nAttack1-3` (`:16238`, `:17128`, `:17492`, `:18310`), Sweep (`:21763`, `:22012`), Peninsula Impale (`:26844`), Javelin (`Whale_javelin.cs:276`). A proc **replaces** the hit with `RPC_AddEffectDamage(251, <raw>, KO 0)` + `puncture` (level = rank, 1 s; strips iron/diamond/perfect/bubble/ice shields and salvation, `CharacterControl.cs:35859+`). Javelin's purple raw is `talAdjust(10·lv)` **without** Tide Cutter's +10 (`Whale_javelin.cs:299` vs `:314`). Bible: `effectProc` replace on Sweep/Javelin/Impale.
- **Megalodon pull (verified 2026-09-24, `$RPC_megalodon_fire`):** 4 pull ticks 1 s apart (`i < 4`, `Whale.cs:34778`), each `RPC_AddEffectDamage(370+sLv, 5·sLv, …, pull vector)` within radius 5 / height 5 (`:34897-34952`), then 2 bites `hit(370+sLv, talAdjust(100·sLv+100))` within radius `2·sLv+3` (`:34692`, `:34846`), 1.5 s apart. Bible: `dmgGroups` Pull ×4 (`effectDamage:true`) + Bite ×2.
- **Shield Reflect (#411, Lv 60 / Bn 1, passive):** two effects, both only while the Whale holds the charge (`shield` status): (1) extra `nDamage −= 0.25·Lv`; (2) reflect `min(nDamage_before, floor(10 + 10·sLv + 0.25·Lv))` as Effect Damage (both in the `shield` branch above). Tooltips: EN `"…reflect 40 damage back to attacker."` (the rank-3 charge value, ignoring the `0.25·Lv` part), TH `"…สะท้อนดาเมจที่ถูกหักกลับใส่ศัตรูและเพิ่มอัตราการหักดาเมจเท่ากับ 25% ของเลเวลวาฬ"`; **No KO protection (corrected 2026-09-28):** an earlier version of this entry said Shield Reflect zeroes KO during the charge, citing `CharacterControl.cs:4059-4075`. That `hasSkill(411)` / `cAttack1` → `nKo = 0` block sits inside `if (this.Type == "Bison")` (`:4011-4298`, brace-matched), so it is Bison #411 **Solid Hold**, not Whale. The Whale `RPC_AddDamage` block (`:4299-4601`) zeroes KO only for the Peninsula Round redirect (`:4358`) and scales it with `honor` (#412, `:4371-4400`). The `shield` case of `AddDamage` (`:30855-30960`) sets `nForce = zero` (no knockback) but never touches `nKo`; the `AddDamage` statuses that zero KO are petrify, iceShield, snowMan, snowBall, cosmicRift, cosmicFriday, noKo and nemesisLarva. So a charging Whale takes KO normally, with or without Shield Reflect.
- **Tide Cutter (#402, Lv 55, passive):** Sweep hit-1 radius +2 m, `+20` inside Sweep's `talAdjust`, `+10` inside Javelin's (sites above), plus a `tideCutter_ring` effect (`Whale.cs:22299`). EN tooltip says Javelin +20; TH says +10, which matches the code.
- **Peninsula Asunder (#442, Lv 85 / Bn 6, passive):** the Impale/Round boxes and Impale `+10` above; also Impale reads the locked target (`Whale.cs:26768-26780`) and `LookAt`s it before each stab (`:27183-27199`). Visual swaps `asunderImpale` / `asunderRound` (`:27145`, `:28001`). The `hasSkill(442)` at `CharacterControl.cs:2850` is Cat-only (`Type == "Cat"`), unrelated.
- **12th Kingdom Knight:** `2 + 2·sLv` knights (`:28414`); `KingdomKnight()` (`Whale.cs:9650-9720`) every 3 s picks `FindClosestTarget(Whale pos, 8)` and all knights attack it; skipped while Whale is in `cAttack1`. Knight hit: `hit(270+sLv, …, (int)(0.2·Whale ATK + 10·sLv), 1, …)` (`whale_kingdomKnight.cs:439`).

## 4. Passive skills (verified 2026-10-01)

All sixteen below are `mode = passive` with no MP/SP (`scripts/decode_skilldata.py DecompiledSource/WhaleSkill.cs`). Skill IDs from `WhaleSkill.cs`'s skill tree.

### 4.1 Shield Bash (`whale_shieldBash`, #114)
- reqLv 22, reqBn 4.
- **Trigger** (`doReleaseCharge`, `Whale.cs:8486-8560`): releasing the charge (`myCommand == "cAttack1"`, needs #111) after holding it **≥ 3 s**, with #114 and `Game.mGameType > 4`, starts `RPC_shieldBash(…, 1)` instead of the plain `RPC_cAttack2` release. Under 1 s nothing happens; between 1 and 3 s it is the plain release.
- **Hit** (`$RPC_shieldBash`, `Whale.cs:19653-20180`): after 0.2 s, every enemy in `FindAreaTarget(pos, 3 × rangeMod, 3 × rangeMod)` takes `hit(221, t, DEF, KO 10, 0, 3 × push away)` (`:19850-19893`): raw damage = Whale's **DEF**, no TAL term. Each landed hit: `RPC_shieldBash_hit` effect and +1 SP (`:19909-19919`).
- Client tooltips: EN "Enables Whale to bash his shield after charging for more then 3 seconds, dealing damage based on his defense." / TH "… คำนวนค่าความ เสียหายจากค่า def (10 ko)" (`WhaleSkill_eng.cs:88`, `WhaleSkill_thai.cs:86`). Matches the code.

### 4.2 Culinary Tongue (`whale_culinaryTongue`, #121/#122)
- reqLv/Bn 6/2, 12/4. Level = number of ranks learned (`GameGui.cs:34844-34878`, inside `Type == "Whale"`).
- On eating (`GameGui.cs` item use, `:34700-35083`): every food stat buff (`atkUp` … `lckUp`, level 1) gets value **and** duration × `(1 + 0.5 × level)` (duration base 120 s → 180 / 240 s), and the food's HP / MP / SP / KO restore is multiplied the same way (`:34936-35020`, `:35083`). The food's own extra status (`status` field) is not scaled.
- Client tooltips: EN "Increases the resulting effect and duration from food and drink by 50% [100%]." / TH "เพิ่มผลและระยะเวลาจากอาหารและเครื่องดื่มขึ้น 50% [100%]" (`WhaleSkill_eng.cs:99-110`, `WhaleSkill_thai.cs:97-108`). Matches.

### 4.3 Super Size (`whale_superSize`, #131-#134)
- reqLv/Bn 8/4, 16/6, 24/8, 32/10.
- Each learned rank adds, in `CharacterDataClass.updateData()` (`CharacterDataClass.cs:650-735`, `Type == "Whale"`): **+15 VIT** (`statList[3]`), **+150 max HP** (the HP that 15 VIT gives, since base HP was already computed as `10 × VIT` at `:626`) and **+2 weight**. All four ranks stack: +60 VIT / +600 HP / +8 weight at rank 4. The status window's base VIT (`getBaseStat(12)`) shows the same +15 per rank (`CharacterControl.cs:22951-22990`).
- Client tooltips: EN "… adds 15 [30 / 45 / 60] vitality and increases his weight by 2 [4 / 6 / 8]." / TH "(+15 vit, +2w)" on every rank (`WhaleSkill_eng.cs:121-154`, `WhaleSkill_thai.cs:119-152`). EN matches; TH shows the per-rank step.

### 4.4 Wall Puncture (`whale_wallPuncture`, #251-#254)
- reqLv/Bn 20/12, 24/15, 28/18, 32/21. Fully traced in §3.15 ("Wall Puncture proc"): `getWallPuncture()` = `lckAdjust(10 × level) > Random.Range(0,100)` (`Whale.cs:9196-9215`); a proc replaces the hit with `RPC_AddEffectDamage(251, raw)` + `puncture` (level = rank, 1 s) on Combo, Sweep, Peninsula Impale and Javelin.
- **`puncture`** apply (`CharacterControl.cs:35859-35875`): removes `ironShield`, `diamondShield`, `perfectShield`, `bubbleShield`, `salvation` and `iceShield` from the target, with no level comparison.
- Client tooltips: EN "Gives normal attack, PeninsulaImpale, and Javelin a 10% [20 / 30 / 40%] chance to penetrate enemy's defense." / TH "… ทำลายบาเรียและทำความ เสียหายทะลุ def (10% …)" (`WhaleSkill_eng.cs:418-451`, `WhaleSkill_thai.cs:449-482`). They omit Sweep and the LCK scaling.

### 4.5 Auto Shield (`whale_autoShield`, #261-#263)
- reqLv/Bn 24/15, 27/18, 30/21.
- **Hook** (`RPC_AddDamage`, receiver side, `CharacterControl.cs:4407-4520`, `Type == "Whale"`, after `hitMod`): on a direct hit while the Whale is **not** holding the charge (`shield` status absent) and has none of `sleep` / `snowMan` / `snowBall` / `petrify` / `paralysis`, roll `Random.Range(0,100) < lckAdjust(6 × lv + 6)` (base **12 / 18 / 24**). On success: `RPC_AddHeal(264, 0, 0, 2 × lv SP)` (+2 / +4 / +6 SP), `nDamage = max(0, nDamage − 10 − 10 × chargeRank)` where `chargeRank` = Charge Attack rank 0-3 (#111-#113), and a shield effect toward the attacker. KO is not changed. Not checked while Peninsula Round is redirecting (that branch skips it).
- Client tooltips: EN "Gives Whale a 12% [18 / 24%] chance to passively block any attack with his shield. Also gives 2 [4 / 6] sp …" / TH "(12% [18 / 24%])" (`WhaleSkill_eng.cs:462-484`, `WhaleSkill_thai.cs:493-515`). The "block" is the flat `10 + 10 × Charge rank` reduction, not a full block; the chance is LCK-scaled.

### 4.6 Last Hope (`whale_lastHope`, #264)
- reqLv 33, reqBn 24.
- **Check** (`LastHope()`, `Whale.cs:9371-9625`, called from the owner's `Update`, `:278`): skipped when `Game.mGameType < 4`, the Whale is dead, or the previous check was under **6 s** ago. It scans every `Player`-tagged character on the Whale's original layer with `hp <= 0`: `n` = their count, capped at **4**. Each of those whose `actionState == "dead"` and whose death (`actionTime`) is within the last 6 s adds **400** to a heal pool.
- **Effect:** with `n > 0`, `RPC_AddStatus("lastHope", n, 12, 0, self)` (flat 12 s, `:9516`); `lastHope` gives `deltaAtk(15 × n)` and `deltaDef(15 × n)` (`CharacterControl.cs:35898-35905`, removal `:16118`), **+15 / 30 / 45 / 60 ATK and DEF**. State + Buff (`StatusData.cs:4860`, `:6602`); only a Whale (or the CrystalBug monsters) can hold it (`CharacterControl.cs:12356`). Then, if the pool is > 0, `RPC_AddHeal(264, pool)`: **+400 HP per ally who died in the last 6 s** (`Whale.cs:9617-9621`), so each death heals once.
- Client tooltips: EN "Passively increases Whale's attack and defense power by 15 per one dead allies in range (60 max)." / TH "ฟื้นฟูและเพิ่มพลังปลาวาฬขึ้นตามจำนวนเพื่อนที่ตาย (10% M.Hpวาฬ ,+15 atk, +15 def, 60 max)" (`WhaleSkill_eng.cs:495`, `WhaleSkill_thai.cs:526`). Code wins on the heal: a flat 400 per fresh death, not 10% of max HP. Neither tooltip's "in range" exists in the code: allies anywhere in the instance count.

### 4.7 Over Presence (`whale_overPresence`, #313/#314)
- reqLv/Bn 17/5, 23/7. (The `getSkill()` fallthrough to `heavyWeight` is a metadata artifact; see the judgment-call note above.)
- **Aura:** `Whale.Start()` creates the `overPresence` child object when #313 is learned (`Whale.cs:86-92`, `createOverPresence` `:9905-9952`) and calls `Init(level, owner)` with level = 1 + #314 + Over Weight #413. The trigger collider's size is set in the prefab, not in code.
- `Whale_overPresence.cs`: `OnTriggerEnter` of a Player/Enemy on another layer, while the game state is normal and the Whale is alive and not hidden, runs `addStatus("overPresence", level, 60, 0, owner)` directly (`:56-130`; the local `addStatus`, not `RPC_AddStatus`, so no CHA contest or resist check); `OnTriggerExit` removes it (`:134-187`).
- **`overPresence`** apply: `moveMod −= 0.1 × level` (`CharacterControl.cs:35951-35955`, removal `:16074`) = **−10 / −20%** move speed (−30% with Over Weight). State + Debuff (`StatusData.cs:4872`, `:7364`).
- Client tooltips: EN "… reduce running speed of enemies within 6 m range by 5% [10%]." / TH "… ระยะ 10 เมตร … (-5% [-10%])" (`WhaleSkill_eng.cs:605-616`, `WhaleSkill_thai.cs:636-647`). Code wins on the amount (10% per level); the two tooltips disagree on the radius (6 m vs 10 m), and the code does not set it.

### 4.8 Harden Skin (`whale_hardenSkin`, #351-#354)
- reqLv/Bn 20/12, 24/15, 28/18, 32/21. Level = highest learned (`getHardenSkinLv`, `Whale.cs:10285-10320`).
- **Trigger** (`HardenSkin()`, `Whale.cs:10230-10250`, owner's `Update` `:290`): right after damage is applied to HP (`myDamage` is set to −1 at `CharacterControl.cs:2128`), at most every 0.5 s: `RPC_AddStatus("hardenSkin", level, chaAdjust(5), 0, self)`.
- **Stacking** (`RPC_AddStatus` refresh, `CharacterControl.cs:14067-14072`): re-applying the same status raises `sValue` by `level`, up to `15 × level`, and keeps the longer remaining time. `hardenSkin` adds `deltaDef(sValue)` (`:35913`). So the first hit gives +0 and each later hit +level DEF, up to **+15 / 30 / 45 / 60 DEF**, lasting `chaAdjust(5)` s after the last hit. Physical + Buff (`StatusData.cs:5415`, `:6626`).
- Client tooltips: EN "Temporary increases Whale's defense by 1 [2 / 3 / 4] everytime he gets hit (15 [30 / 45 / 60] max)." / TH "(+1 def/hit, 15max)" … (`WhaleSkill_eng.cs:759-792`, `WhaleSkill_thai.cs:790-823`). Matches, except that the first hit only starts the status at +0.

### 4.9 Entended Wave (`whale_entendedWave`, #401)
- reqLv 55, reqBn 0. Combo only (see §3.15 Combo): the swing box length goes `4 → 7` m (`Whale.cs:16444`, `:17334`, `:17698`, `:18509`; the extra 3 m is not scaled by `rangeMod`). With the `w_whl59` weapon and a locked target, each swing instead hits that target alone if it is within **9 m → 12 m** (`sqrMagnitude < 81 + 63`, `:16169-16223`, `:17107`, `:17471`, `:18289`). In real game modes it also swaps in the `extendedWave` swing effects (`:16536`, `:16828`, `:18027`).
- Client tooltips: EN "Increases Whale's normal attack range by 3m." / TH "ยืดระยะของการโจมตีปกติทั้งหมดขึ้นอีก 3 m" (`WhaleSkill_eng.cs:869`, `WhaleSkill_thai.cs:900`). Matches.

### 4.10 Shield Reflect (`whale_shieldReflect`, #411)
- reqLv 60, reqBn 1. Fully traced in §3.15 ("`shield` status" and "Shield Reflect"): while holding the charge, `nDamage −= 0.25 × Lv` on top of the stance's `10 + 10 × sLv`, and `min(damage before reductions, floor(10 + 10 × sLv + 0.25 × Lv))` is reflected to the attacker as Effect Damage (`CharacterControl.cs:30855-30960`).

### 4.11 Gourmet Heart (`whale_gourmetHeart`, #421)
- reqLv 70, reqBn 3. Two effects in the item-use path (`GameGui.cs`, `Type == "Whale"`):
  - **Cooldowns halved:** `food` 120 → **60 s**, `desert` 60 → **30 s**, `drink` 30 → **15 s** (`:34757-34800`).
  - **Flat bonus** on every food heal: **+100 HP, +40 MP, +10 SP**, added after Culinary Tongue's multiplier (`:35083`).
- Client tooltips: EN "Gives additional 100 hp 40 mp 10 sp to Whale everytime he eats food. Also reduces cooldown of food by 50%." / TH matches (`WhaleSkill_eng.cs:891`, `WhaleSkill_thai.cs:922`).

### 4.12 Mega Size (`whale_megaSize`, #431)
- reqLv 75, reqBn 4. `CharacterDataClass.updateData()` (`CharacterDataClass.cs:738-750`): **+40 VIT, +400 max HP, +10 weight**, on top of Super Size. The status window's base-VIT display (`getBaseStat(12)`) only adds Super Size, not Mega Size (`CharacterControl.cs:22951-22990`).
- Client tooltips: EN "Makes Whale even bigger in size. Adds 40 vitality and increases his weight by 10." / TH "เพิ่ม 40Vit และ 10Weight ให้กับวาฬ" (`WhaleSkill_eng.cs:902`, `WhaleSkill_thai.cs:933`). Matches.

### 4.13 Peninsula Asunder (`whale_peninsulaAsunder`, #442)
- reqLv 85, reqBn 6. Fully traced in §3.15 ("Peninsula Asunder", "Peninsula Impale", "Peninsula Round"): Impale box `3 × 12 m` (from `2 × 6`) with `+10` inside `talAdjust` and auto-turn toward the locked target before each stab; Round box `6 m wide × 5 m` from 1 m behind (from `3 × 4`).
- Client tooltips: EN "Doubles the range of peninsula skills. Also enables PeninsulaImpale to automatically turns toward a locked target." / TH adds "+Dmg อีก 10" (`WhaleSkill_eng.cs:968`, `WhaleSkill_thai.cs:999`). TH matches the code better.

### 4.14 Over Weight (`whale_overWeight`, #413)
- reqLv 60, reqBn 1. Two `hasSkill(413)` sites:
  - **Heavy Weight:** the `heavy` status level is `rank + 1` in both the ally and the enemy branch (`Whale.cs:30228`, `:30250`).
  - **Over Presence:** the aura level is +1 (`Whale.cs:9940`), i.e. −20 / −30% move speed.
- Client tooltips: EN "Increases the resulting effect of HeavyWeight and OverPresence by 1 level." / TH matches (`WhaleSkill_eng.cs:990`, `WhaleSkill_thai.cs:1021`).

### 4.15 Spiral Blast (`whale_spiralBlast`, #423)
- reqLv 70, reqBn 3. All in `RPC_hydroBlast_fire` (`Whale.cs:9975-10060`):
  - area `FindAreaTarget(mPos, 1 → 2, 6)` (radius 1 m → 2 m, height 6 m, no `rangeMod`);
  - damage `hit(320 + rank, t, talAdjust(10 × rank + 10 + 20) + target weight, KO rank, 0, 5 × up)`: **+20 inside `talAdjust`**, not +50%;
  - on a landed hit, `RPC_AddStatus("wash", rank, 1, 0, …)` on the target. `wash` removes every **Physical Buff** on the target whose level is ≤ the wash level (`CharacterControl.cs:36103-36140`).
  - It also adds the `spiralBlast` effect and voice (`:9982-9995`, `:30859`).
- Client tooltips: EN "Increases the damage of HydroBlast by 50% and gives it an ability to remove all positive physical status from the target." / TH same (`WhaleSkill_eng.cs:1001`, `WhaleSkill_thai.cs:1032`). Code wins: +20 TAL base (not 50%), and the cleanse only reaches status levels ≤ the Hydro Blast rank.

### 4.16 Diving Press (`whale_divingPress`, #443)
- reqLv 85, reqBn 6.
  - **Whale Wave** (`$RPC_whaleWave`, `Whale.cs:31853-32111`): radius `6 → 9` m (`:31940`); per target the damage `ceil(talAdjust((int)(weight × (0.5 + 0.5 × rank))) × (1 − 0.05 × distance))` and KO `5 × rank` are each multiplied by 1.5 and floored (`:31973-31999`), so KO 5 / 10 → 7 / 15. Swaps to the `divingWave` animation and effect.
  - **Mal Storm** (`$RPC_malStorm`, `Whale.cs:32686-32775`): radius `8 → 12` m (`:32686`), damage `floor(1.5 × talAdjust(20 × rank + 10))`, KO `1 → 2` (`:32701-32710`), `divingStorm` animation, and a second bolt effect per strike (`createMalstormBolt`, `:10206`, visual only).
  - The `hasSkill(443)` checks in `CharacterControl.cs` (`:4232`, `:11985`, `:12019`) are other classes' branches.
- Client tooltips: EN "Increases damage, ko, and range of WhaleWave and MalStorm by 50%." / TH same (`WhaleSkill_eng.cs:1023`, `WhaleSkill_thai.cs:1054`). Matches (Mal Storm's KO goes 1 → 2).
- Whale Wave's base KO is `5 × rank` (`Whale.cs:31983`); §2 was corrected from "1-3" on 2026-10-01.

### 4.17 Open questions & card mismatches (2026-10-01)

**Card mismatches:** fixed 2026-10-02. Every Whale card now has `desc` (passives also `passive:true`), and the costs that disagreed with `decode_skilldata.py` were corrected: Bubble Shield MP 6/10/14/18, Rejuvenate MP 10/14/18/22 with no SP, Whale Wave SP 12/15, Mal Storm MP 16/24 + 20 red SP, Call To Arm free, Salvation MP 24/32, Megalodon MP 45/65 + 20/30 red SP, Bubble Burst 10 MP + 10 red SP, Bowling Whale 45 MP + 45 red SP, Grand Tide 30 MP + 60 blue SP. Reduced Cast is already modelled with the code's floor: the cast chip computes `Math.floor(castTimeBase × 0.5)` before `magAdjustRange` (`index.html`, cast block of the hero render).

**Open questions (need a live check):**
1. Over Presence radius: set by the prefab's trigger collider (EN tooltip 6 m, TH 10 m).

### Geometry notes (verified 2026-10-02)

- **Flying Shield:** `$RPC_flyingShield` spawns the `flyingShield` effect at the Whale (`createEffect`, `Whale.cs:24642-25213`) and the hit comes from `Whale_flyingShield.OnTriggerEnter` (`Whale_flyingShield.cs:126`); the flight path is the effect's animation, with no distance in code.
- **Homing Shield** lives `chaAdjust(3)` s (`Whale.cs:10431`); Bubble Shield and Homing Shield have no distance gate (40 m target lock).

## Server Balance Variations

Base engine (BigBug) values are documented above; this section lists private-server deltas.

### Tailstopia Online (TTO)
- **Honor Stand also adds +1 to Honor's `sLv`** (user-reported from live play, 2026-09-20; server-side change, not visible in `DecompiledSource/`). Base code (`Whale.cs:23500-23900`) uses the single cast `sLv` for the honor status level, so with the +1 all of these follow it: CHA `+10×sLv` (`CharacterControl.cs:35558`), KO reduction `10%×honorLv` (`:4400`), hate `floor((0.5×sLv+0.5)×CHA)` and taunt radius `18+6×sLv` (`Whale.cs:23876`). Example: rank 4 + Honor Stand → `[honor5]`, CHA +50, hate 300%, radius 48m. The bible card models this as `servers.tto` with an Honor Stand dependency toggle (default learned).
