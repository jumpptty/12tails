# Bat — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| massCast | Mass Cast | 2 | 180 | true | false | 9 | true |
| phantomBane | Phantom Bane | 4 | 30 | true | false | — | — |
| shadowGaze | Shadow Gaze | 4 | 30 | true | false | — | — |
| dissolute | Dissolute | 2 | 60 | true | false | — | — |
| corruption | Corruption | 2 | 60 | true | false | — | — |
| curse | Curse | 4 | 120 | true | false | — | — |
| echoes | Echoes | 2 | 60 | true | false | — | — |
| nightmare | Nightmare | 2 | 180 | true | false | — | — |
| doom | Doom | 2 | 180 | true | false | — | — |
| guardianOfTheNight | Guardian of the Night | 2 | 600 | true | false | 60 | true |
| mirageOrb | Mirage Orb | 4 | 30 | true | false | 30 | true |
| shadowIllusion | Shadow Illusion | 4 | 60 | true | false | 60 | true |
| blind | Blind | 2 | 30 | true | false | — | — |
| confusion | Confusion | 2 | 45 | true | false | — | — |
| hateTransfer | Hate Transfer | 2 | 60 | true | false | — | — |
| switch | Switch | 1 | 12 | true | false | — | — |
| swap | Swap | 1 | 30 | true | false | — | — |
| dreamDazzle | Dream Dazzle | 2 | 90 | true | false | — | — |
| phantasmBlast | Phantasm Blast | 2 | 90 | true | false | — | — |
| charm | Charm | 2 | 120 | true | false | — | — |
| mindControl | Mind Control | 2 | 120 | true | false | — | — |
| mimic | Mimic | 2 | 360 | true | false | 60 | true |
| shame | Shame | 1 | 60 | true | false | — | — |
| darkStalker | Dark Stalker | 1 | 120 | true | false | 999 | false |
| soulEater | Soul Eater | 1 | 150 | true | false | — | — |
| shadowSacrifice | Shadow Sacrifice | 1 | 120 | true | false | — | — |
| paranoia | Paranoia | 1 | 150 | true | false | — | — |
| shatteringDream | Shattering Dream | 1 | 130 | true | false | — | — |
| nefariousWhip | Nefarious Whip | 1 | 180 | true | false | — | — |
| blackServant | Black Servant | 1 | 180 | true | false | 90 | true |

## Citations

### Notes on judgment calls
- **Support-skill exclusion confirmed.** `SkillData.cs`'s 12 shared `getSupportSkill()` skills (including
  `bloodCarnage`, Bat's own thematic one) all appear in `Bat.cs` as `RPC_<name>` handlers with a flat,
  unwrapped `addTimeOut("<name>", (float)600)` — e.g. `Bat.cs:16056` —
  `this.mChar.addTimeOut("bloodCarnage", (float)600);`. None of the 12 names (`obsidianFang`,
  `stunningGround`, `psalmOfEnergy`, `seaAegis`, `assassinate`, `zephyrLore`, `mineWalker`,
  `replenishment`, `elementalBound`, `divineChannel`, `astralShift`, `bloodCarnage`) appear anywhere as a
  `bat_<name>` entry in `BatSkill.cs`'s `getSkill()` cost table (verified with a direct grep, zero matches)
  — confirming they are not part of Bat's own learnable skill roster and are correctly excluded from this
  table.
- **`nAttack`/`cAttack` excluded — blanket plan-level scope rule, not a per-skill judgment call.** The
  plan's Global Constraints now exclude basic-attack (`nAttack`) and charge-attack (`cAttack`) skills from
  every class's table entirely, regardless of whether either has a real cooldown at its own cast site.
  This applies uniformly: `cAttack` (Bat's "drainLife" charge attack, `doBeginCharge`/`doReleaseCharge`,
  `Bat.cs:10324`/`10588`) has no `addTimeOut`-based cooldown of its own anyway — its only cast-rate gate is
  a generic `this.mChar.actionTime + (float)1 > Time.time` check (`Bat.cs:10490`), a flat 1s action-lockout
  shared by all actions, not a named cooldown key (a repo-wide grep for `addTimeOut`/`isTimeOut` with
  `cAttack` in `Bat.cs` returns zero matches) — matching the Penguin doc's precedent where `pgn_cAttack1-4`
  are "passive, charge-attack rank" with no CD of their own. `nAttack` is different: **it does have a
  genuine named cooldown**, unlike Penguin's. Bat's normal-attack combo stages carry their own
  `addTimeOut("nAttack", …)` calls, each a bare (non-`agiAdjust`-wrapped) literal — `RPC_nAttack1`/
  `RPC_nAttack2` set 1.5s (`Bat.cs:20367`, `Bat.cs:20659`), `RPC_nAttack3` (the max-rank combo stage,
  `bat_nAttack3` in `BatSkill.cs`) sets 2s (`Bat.cs:21074`). It is excluded from this table purely by the
  blanket policy above, not because it lacks a real cooldown — anyone re-deriving this table from scratch
  should not rediscover `nAttack` and add it back in. (A separate, unrelated `addTimeOut("nAttack", 1f)`
  also exists at `Bat.cs:9861` inside a `Game.mGameCode == 967` branch — a special event-minigame mode, not
  the standard combat path — irrelevant either way now that `nAttack` is out of scope.)
- **`phantomBane`/`dissolute`/`corruption`/`doom` cooldowns are conditionally zeroed by the `shadowMastery`
  passive.** All four are set via a ternary in the shared cast dispatcher, e.g.
  `Bat.cs:24474` — `this.$mTimeOut$19914 = ((this.$mShadowMastery$19915 <= 0) ? 30 : 0);` — where
  `$mShadowMastery$19915 = this.$self_$19931.getShadowMasteryLv()` (a separate passive skill family,
  `bat_shadowMastery1/2`, out of scope for this table — no `cType`/cast site of its own). This table
  reports the un-passived (`shadowMastery` not learned) value — 30/60/60/180 respectively — as the skill's
  own base cooldown, matching the existing Penguin doc's precedent of using the default/guaranteed value
  when a separate passive can conditionally alter a skill's own CD.
- **`shadowGaze`'s cooldown is conditionally reduced by the `demonGaze5` passive** (`hasSkill(412)`,
  confirmed `412` = `bat_demonGaze5` via `BatSkill.cs:3231`'s `getSkillTree` mapping): `Bat.cs:11325` sets
  20s if `demonGaze5` is learned, `Bat.cs:11333` sets 30s otherwise. This table uses the default
  (`demonGaze5` not learned) value, 30s, for the same reason as the `shadowMastery` note above.
- **Contested-duration skills excluded per the brief's rule.** Twelve skills apply their debuff via
  `Damage.getDebuff(base, casterCha, targetCha)` — the target's own CHA affects the final duration, not
  just the caster's — so both Duration cells are `—` for: `phantomBane` (`Bat.cs:25438`), `dissolute`
  (`Bat.cs:26116`), `corruption` (`Bat.cs:26778`), `curse` (`Bat.cs:27440`), `nightmare` (`Bat.cs:28600`),
  `blind` (`Bat.cs:32208`), `confusion` (`Bat.cs:32823`, applies a status literally named `"confuse"`),
  `charm` (`Bat.cs:36511`), `mindControl` (`Bat.cs:37054`), `shame` (`Bat.cs:39690`), and `blackServant`
  (`Bat.cs:45206`). `doom` (`Bat.cs:29394`) uses the same `Damage.getDebuff` formula but with the two CHA
  arguments in reversed order (`Damage.getDebuff((float)60, this.$tChar$20070.cha,
  this.$self_$20079.mChar.cha)` — target's CHA passed first) — still both-stat-dependent, so it is
  excluded on the same basis.
- **`massCast`'s Duration citation uses its primary player-cast site, not a secondary auto-cast
  variant.** `Bat.cs:11164` (inside `RPC_massCast`, the direct skill-cast handler) sets
  `chaAdjust(3 + 3 * sLv)`, scaling with the caster's own rank/CHA only (not target-contested). A second,
  unrelated `RPC_AddStatus("massCast", 1, 3, 0, …)` at `Bat.cs:23360` uses a flat unwrapped `sLv=1`/
  duration=3 — this is inside the auto-trigger path for the `autoMass5` passive (a separate skill, out of
  scope), not massCast's own cast, so it is not used for this table's Duration value.
- **Passive/no-own-cast-site families have no row in this table** (confirmed via `BatSkill.cs`'s `getSkill()`: no
  `cType` assigned, and confirmed via `Bat.cs`: no `addTimeOut`/`isTimeOut` call under their own name):
  `drainMana` (drainLife charge-attack lifesteal-tier passive), `statPlus`, `amplifyDamage`,
  `shadowMastery` (the CD-zeroing passive referenced above), `dreamBurst`, `allMimic`, `illusionEffect5`,
  `darkIntention5`, `mercilessDrain5`, `autoMass5`, `superStatPlus5`, `demonBane5`, `demonGaze5` (the
  shadowGaze CD-reducing passive referenced above), `distantOrb5`, `chiroptophobia5`, `revisedSkill5`
  (global SP-cost reduction), `revisedMagic5` (global MP-cost reduction), `revisedArt5` (global 12%
  cooldown reduction, excludes `nAttack`/`cAttack`/consumables — the same convention documented in the
  existing Penguin doc for `pgn_revisedArt5`). This mirrors the existing Penguin doc's `typhoon` exclusion
  precedent: skill-point-costed entries in the cost table that are not independently castable.

### CD citations
- `massCast` CD: `Bat.cs:11131` — `this.mChar.addTimeOut("massCast", this.mChar.agiAdjust((float)180));`
- `phantomBane` CD: `Bat.cs:24474` — `this.$mTimeOut$19914 = ((this.$mShadowMastery$19915 <= 0) ? 30 : 0);`, wrapped at `Bat.cs:24812` — `addTimeOut(this.$sType$19926, agiAdjust((float)this.$mTimeOut$19914))`
- `shadowGaze` CD: `Bat.cs:11333` — `this.mChar.addTimeOut("shadowGaze", this.mChar.agiAdjust((float)30));` (default/`demonGaze5`-not-learned branch)
- `dissolute` CD: `Bat.cs:24487` — `this.$mTimeOut$19914 = ((this.$mShadowMastery$19915 <= 0) ? 60 : 0);`, wrapped at `Bat.cs:24812`
- `corruption` CD: `Bat.cs:24500` — `this.$mTimeOut$19914 = ((this.$mShadowMastery$19915 <= 0) ? 60 : 0);`, wrapped at `Bat.cs:24812`
- `curse` CD: `Bat.cs:24513` — `this.$mTimeOut$19914 = ((this.$mShadowMastery$19915 <= 0) ? 120 : 0);`, wrapped at `Bat.cs:24812`
- `echoes` CD: `Bat.cs:28202` — `this.$self_$20042.mChar.addTimeOut("echoes", this.$self_$20042.mChar.agiAdjust((float)60));`
- `nightmare` CD: `Bat.cs:24526` — `this.$mTimeOut$19914 = 180;`, wrapped at `Bat.cs:24812`
- `doom` CD: `Bat.cs:24543` — `this.$mTimeOut$19914 = ((this.$mShadowMastery$19915 <= 0) ? 180 : 0);`, wrapped at `Bat.cs:24812`
- `guardianOfTheNight` CD: `Bat.cs:30200` — `this.$self_$20094.mChar.addTimeOut("guardianOfTheNight", this.$self_$20094.mChar.agiAdjust((float)600));`
- `mirageOrb` CD: `Bat.cs:24556` — `this.$mTimeOut$19914 = 30;`, wrapped at `Bat.cs:24812`
- `shadowIllusion` CD: `Bat.cs:24573` — `this.$mTimeOut$19914 = 60;`, wrapped at `Bat.cs:24812`
- `blind` CD: `Bat.cs:24590` — `this.$mTimeOut$19914 = 30;`, wrapped at `Bat.cs:24812`
- `confusion` CD: `Bat.cs:24607` — `this.$mTimeOut$19914 = 45;`, wrapped at `Bat.cs:24812`
- `hateTransfer` CD: `Bat.cs:24624` — `this.$mTimeOut$19914 = 60;`, wrapped at `Bat.cs:24812`
- `switch` CD: `Bat.cs:13279` — `this.mChar.addTimeOut("switch", this.mChar.agiAdjust((float)12));`
- `swap` CD: `Bat.cs:24641` — `this.$mTimeOut$19914 = 30;`, wrapped at `Bat.cs:24812`
- `dreamDazzle` CD: `Bat.cs:24658` — `this.$mTimeOut$19914 = 90;`, wrapped at `Bat.cs:24812`
- `phantasmBlast` CD: `Bat.cs:24675` — `this.$mTimeOut$19914 = 90;`, wrapped at `Bat.cs:24812`
- `charm` CD: `Bat.cs:24692` — `this.$mTimeOut$19914 = 120;`, wrapped at `Bat.cs:24812`
- `mindControl` CD: `Bat.cs:24709` — `this.$mTimeOut$19914 = 120;`, wrapped at `Bat.cs:24812`
- `mimic` CD: `Bat.cs:24726` — `this.$mTimeOut$19914 = 360;`, wrapped at `Bat.cs:24812`
- `shame` CD: `Bat.cs:24743` — `this.$mTimeOut$19914 = 60;`, wrapped at `Bat.cs:24812`
- `darkStalker` CD: `Bat.cs:24760` — `this.$mTimeOut$19914 = 120;`, wrapped at `Bat.cs:24812`
- `soulEater` CD: `Bat.cs:41007` — `this.$self_$20380.mChar.addTimeOut("soulEater", this.$self_$20380.mChar.agiAdjust((float)150));`
- `shadowSacrifice` CD: `Bat.cs:14110` — `this.mChar.addTimeOut("shadowSacrifice", this.mChar.agiAdjust((float)120));`
- `paranoia` CD: `Bat.cs:24777` — `this.$mTimeOut$19914 = 150;`, wrapped at `Bat.cs:24812`
- `shatteringDream` CD: `Bat.cs:24794` — `this.$mTimeOut$19914 = 130;`, wrapped at `Bat.cs:24812`
- `nefariousWhip` CD: `Bat.cs:43044` — `this.$self_$20435.mChar.addTimeOut("nefariousWhip", this.$self_$20435.mChar.agiAdjust((float)180));`
- `blackServant` CD: `Bat.cs:44579` — `this.$self_$20474.mChar.addTimeOut("blackServant", this.$self_$20474.mChar.agiAdjust((float)180));`

### Duration citations
- `massCast` Duration: `Bat.cs:11164` — `this.mChar.RPC_AddStatus("massCast", sLv, this.mChar.chaAdjust(3 + 3 * sLv), 0, this.mChar.ActorNr);` (self-buff, scales with caster's own rank/CHA only; max rank sLv=2 → `chaAdjust(9)`)
- `guardianOfTheNight` Duration: `Bat.cs:30592` — `this.$mDuration$20102 = this.$self_$20106.mChar.chaAdjust(30 * this.$sLv$20105);`, applied at `Bat.cs:30603` — `RPC_AddStatus("guardianOfTheNight", sLv, mDuration, 0, ActorNr)` (not contested — only the caster's own CHA/rank; max rank sLv=2 → `chaAdjust(60)`)
- `darkStalker` Duration: `Bat.cs:40263` — `this.$hitChar$20358.RPC_AddStatus("darkStalker", 9, 999, 0, this.$self_$20362.mChar.ActorNr);` (flat literal `999`, confirmed NOT `chaAdjust`-wrapped and not stat-contested — applied to the enemy target but the value itself is a hardcoded constant)
- `mirageOrb` Duration: `Bat.cs:31265` — `this.$nLife$20114 = this.$self_$20118.mChar.chaAdjust(30);`, passed into `RPC_mirageOrb_fire(firePos, fireDir, nLife, sLv)` as the orb's own lifetime (self-cast, not target-contested). Matches the flavor text exactly ("Cast an invisible orb... 30 sec", `BatSkill_eng.cs:530`).
- **`shadowIllusion` Duration is verified in code at `chaAdjust(60)`, not the `chaAdjust(30)` all four ranks' own flavor text claims ("...deal 50%/50%/75%/100% dmg and receive 160% dmg. (30 sec)", `BatSkill_eng.cs:574` etc.) — a genuine flavor-text/code mismatch, reported at the verified code value per this doc's standing rule.** `Bat.cs:13115`, inside `RPC_shadowIllusion_create`'s own body — `bat_illusion.summon(this.gameObject, nDamageMod, nHitMod, (float)this.mChar.chaAdjust(60));` — `Bat_illusion.summon(GameObject, float, float, float nTimer)` (`Bat_illusion.cs:60`) stores `nTimer + Time.time` as the illusion clone's own despawn deadline (`Bat_illusion.cs:73`), checked against `Time.time` at `Bat_illusion.cs:669` and destroyed at `Bat_illusion.cs:487`. A full-file grep of `Bat.cs` for `.summon(` returns exactly this one call site, confirming it's shadowIllusion's own (not shared with another skill). `nDamageMod = 0.25 + num*0.25` (`Bat.cs:13105`, `num` = `sLv` capped/wrapped past rank 3) does correctly match the flavor text's 50/75/100% damage scaling, so only the duration figure itself is the mismatch.
- **`mimic` Duration is verified in code at a flat `chaAdjust(60)` for both ranks — not the per-rank
  `bat_mimic1`/`bat_mimic2` flavor text, which claims "(60 sec)"/"(90 sec)" respectively
  (`BatSkill_eng.cs:827`, `:838`) — another genuine flavor-text/code mismatch, same class as
  `shadowIllusion` above, reported at the verified code value (max rank = `60`, not `90`).**
  `RPC_mimic_create(Vector3, Vector3, int tID, int nID)` (`Bat.cs:38696`) receives no `sLv`/rank
  parameter at all — confirmed at both real cast sites, `Bat.cs:38226`/`:38266` — so the duration
  literally cannot vary by rank in code, regardless of what the tooltip claims per rank. Duration itself:
  `Bat.cs:38936` — `this.$mDuration$20318 = this.$self_$20330.mChar.chaAdjust(60);`, applied to the
  targeted ally's clone as the actual `"mimic"` status at `Bat.cs:39132` — `addStatus("mimic", 1,
  this.$mDuration$20318, 0, ...)` (caster's own CHA, not target-contested — `mimic` targets/reanimates a
  friendly character as a stand-in double, not an enemy). The caster's own concurrent `"hide"`
  invisibility uses the same base plus a flat `+12`: `Bat.cs:39312` — `addStatus("hide", 1,
  this.$mDuration$20318 + 12, 0, ...)`, not surfaced as its own row (same skill's own effect, not a
  separate cooldown-bearing skill).
- `blackServant` Duration: `Bat.cs:45206` — `this.$hitChar$20481.RPC_AddStatus("blackServant", 5, Damage.getDebuff((float)90, this.$self_$20486.mChar.cha, this.$hitChar$20481.cha), 0, this.$self_$20486.mChar.ActorNr);` (contested debuff against target player's CHA; base duration 90s, sLv=5). Only targets dead enemy player characters (`Bat.cs:8468-8488`); converts target to Bat's team layer (`CharacterControl.cs:41447`) with `Shadow<Hero>_AI` attached until duration expires, servant dies, or Bat dies (`Bat.cs:295-301`).

---

# Damage & Mechanics


## Server Balance Variations (ToT & TTO)

Private-server values below are documented from the Bible skill-detail schema, not the BigBug decompile; the original-server column is the BigBug baseline represented by that card.

| Skill | Server | Original BigBug baseline | Server delta |
|---|---|---|---|
| Mass Cast | TTO | The buff lasts 6 / 9 seconds. | Replaced duration-based spreading with exactly 1 / 2 affected casts at ranks 1 / 2. |
| Mirage Orb | ToT | Allies in the orb receive no `hitMod` reduction. | Allies inside the orb receive `-0.1 hitMod`. |
| Dream Dazzle | TTO | Shattering Dream raises its effective skill level. | Shattering Dream no longer raises its level; the skill uses `talAdjust(10 + 20 × rank)`. |
| Phantasm Blast | TTO | Shattering Dream raises its effective skill level. | Shattering Dream no longer raises its level; the skill uses `talAdjust(10 + 20 × rank)`. |
| Shattering Dream | TTO | Raises Dream Dazzle and Phantasm Blast by one level. | No longer grants either level increase. |

Source of server deltas: `12t_projects/bible/index.html:8443,8516,8664,8696,8910`.

### bat_shame — `shame` status on the target (enemy stat debuff)
- **Level applied:** `5 + ((!target.hasStatus("shame")) ? 0 : 1)` (`Bat.cs:39685`) — Lv.5 on a fresh target, **Lv.6 when the target already has Shame** (a recast); the escalated level is then re-applied with `RPC_AddStatus("shame", lv, ...)`.
- **Effect:** on add `deltaCha(-10 * sLv)` (`CharacterControl.cs:40938`), on removal `deltaCha(10 * sLv)` (`CharacterControl.cs:18460`) — the target's CHA drops by **50 (Lv.5) / 60 (Lv.6)**. Classified Debuff, Magical.
- **App modeling:** Debuff panel > Enemy Stats has a built-in `shame6` toggle (`ENEMY_STAT_DEBUFFS`, -60 CHA) that feeds the enemy CHA used by every duration/debuff formula, shown as the `-60 = total` chip under the enemy CHA input.

### Bat status effects (popup text in the Bible `STATUS_DESC_MAP`)
Values verified in `CharacterControl.cs` (per-tick handler / add site / removal site). `sLv` = status level.

| Status | Effect | Source |
|---|---|---|
| `phantomBane` | every 2 s `RPC_AddEffectDamage(200+sLv, 6×sLv+3)` (purple) | `CharacterControl.cs:9443-9450` |
| `corruption` | once per target attack (`actionState=="attack"`, latched by `sValue`): Effect Damage `15+15×sLv`, SP `−5×sLv` | `CharacterControl.cs:9508-9530` |
| `curse` | on add `deltaAtk/Def/Agi/Vit/Mag/Cha/Tal/Lck(−3×sLv−3)` (all 8 stats); reversed on removal | `CharacterControl.cs:40254-40300`, `:18079-18085` |
| `nightmare` | `RPC_AddDamage(242+sLv, 22×sLv+22)` every 2 s; on add removes `paralysis`/`sleep`/`snowMan`/`mindControl`, `actionState="nightmare"`, `moveSpeed=0`; while active `paralysis`/`sleep`/`charm`/`mindControl`/`nightmare` cannot be added | `:9643-9650`, `:40352-40420`, `:11256`, `:11466`, `:11676`, `:11781`, `:11841` |
| `amplifyDamage` | on add `hitMod += 0.05×sLv` | `CharacterControl.cs:40476-40478` |
| `blind` | basic/charge attacks (`actionCode < 10`) miss when `Random.Range(0,100) < 10×sLv+10` (no LCK) | `CharacterControl.cs:3481-3486` |
| `confuse` | on skill use `Random.Range(0,100) < 6×sLv+6` → `RPC_AddDamage(-87)` (skill fails, 30 s cooldown) | `Bat.cs:7356-7362` |
| `blackServant` | on add (dead player): `hp = floor(0.5×mhp)`, `ko = floor(0.5×mko)`, layer switched to the caster's team; on removal `hp = 0`, dead. Hero types only | `CharacterControl.cs:41338-41420`, `:18511-18520`, `:11850` |
| `guardianOfTheNight` | marker for the summoned boss; `RPC_RemoveStatus` is issued together with `RPC_guardian_unsummon` | `Bat.cs:12436-12437` |
| `massCast` | Mass Cast spread hook reads `getStatusLv("massCast")` | `Bat.cs:11447` |

Open item: `nightmare` blocks on `snowMan`/`snowBall`/`petrify` (`CharacterControl.cs:11790-11835`) look like the *reverse* of the add-site `removeStatus("snowMan")`. Not resolved; the popup states only the add-site behaviour.

Additional Bat statuses (same popup pass):

| Status | Effect | Source |
|---|---|---|
| `shame` | on add `deltaCha(-10×sLv)` (Lv.5 = −50, Lv.6 = −60); caster-side `sLv + (target.hasStatus("shame") ? 1 : 0)` for Blind/Confusion | `CharacterControl.cs:40934-40940`, `Bat.cs:32213`, `Bat.cs:32828` |
| `charm` | on add target layer = `sValue` (caster team), `addHate(sID,100)`; removal restores `mOriginalLayer`; cannot be added while `mindControl`/`nightmare`/`snowMan`/`snowBall` | `CharacterControl.cs:40664-40730`, `:18236-18245`, `:11655-11710` |
| `mindControl` | on add removes `paralysis`/`sleep`/`charm`, layer = owner's `mOriginalLayer`, `isMine = owner.isMine`, `addHate(sID,100)`; removal restores layer/ownership; cannot be added while `petrify`/`snowMan`/`snowBall`/`mindControl`/`nightmare` | `CharacterControl.cs:40760-40850`, `:18270-18290`, `:11715-11785` |
| `darkStalker` | every 4.5 s (`mod(2k,9)==3`) `RPC_AddEffectDamage(432, floor(0.3×target.cha))`; hero types only | `CharacterControl.cs:9770-9780`, `:12638-12645` |
| `chiroptophobia` | every 1.5 s (`mod(2k,3)==1`) `RPC_AddEffectDamage(422, 7×sLv+7)`; listed only in `isStateStatus` (no Debuff/Magical flag) | `CharacterControl.cs:9660-9690`, `StatusData.cs:5070` |

Follow-up verification:
- **Guardian of the Night:** status duration is `chaAdjust(30×sLv)` (`Bat.cs:30600-30603`); the same value sets the boss timer `xMnv4YLKcX` (`:30609`). The AI loop (`Bat.cs:12275-12440`) runs the search/attack branch only while the timer has not expired and the Bat is alive; otherwise it falls through to `RPC_RemoveStatus("guardianOfTheNight")` + `RPC_guardian_unsummon`. Boss AI: 2.5 s scan, 32 m × 12 m area, attack when `sqrMagnitude < 256` (16 m), else 50 % cast.
- **Curse on monsters:** for `!isPlayer`, `vit = ceil(0.1×mhp)` is set before `deltaVit(-3×sLv-3)` (`CharacterControl.cs:40258-40264`); removal only adds the delta back (`:18079-18090`). Same pattern exists for `bless` (`:39134-39140`).
- **Mass Cast:** with `getStatusLv("massCast") == 0` the spell hits only the target; otherwise `FindAreaTarget(target, 18, 12)` with `hitCount < 6`. Consumers: phantomBane, dissolute, corruption, curse, doom, blind, confusion, dreamDazzle, phantasmBlast, charm, shame, paranoia, shatteringDream, Demon/Shadow Gaze (`Bat.cs:11447`, `:25354`, `:26032`, `:26694`, `:27356`, `:29305`, `:32129`, `:32744`, `:34488`, `:35449`, `:36397`, `:39605`, `:41417`, `:42044`). **Soul Eater (`Bat.cs:40834-40850`) uses the same 18 m × 12 m area with no 6-target cap.**

### bat_mercilessDrain5 (Merciless Drain, #421) (verified 2026-10-01)

- Passive. `getMercilessDrainLv() = hasSkill(421) ? 3 + DarkIntentionLv : 0` (`Bat.cs:14093-14095`). Each Drain Life tick (every 1 s, `Bat.cs:21990-22000`) applies `hpDrain`, `mpDrain` (with Drain Mana) and `spDrain` with level and value `3 + DarkIntention` (`:22185-22205`); then, when the passive is learned and the target holds **neither `mpDrain` nor `spDrain`**, it takes `RPC_AddEffectDamage(421, 66, 0, 0, …)` (`:22233-22257`, junk predicates evaluated).
- `mpDrain` / `spDrain` drain at once on apply and are not kept when the target's MP / SP is 0 after the drain (`isAdd = false`, `CharacterControl.cs:33543-33610`), so the 66 lands on a target left with 0 SP and 0 MP (or 0 SP when Drain Mana is not learned).
- **Bible:** `effectProc: BAT_MERCILESS_PROC` (bonus 66) on Drain Life, one toggle meaning "learned and the target has nothing left to drain".

### bat_nAttack1-3 (Combo, #101-#103) (verified 2026-10-01)

- Passive ranks, reqLv/Bn 1/0, 2/1, 3/2 (`decode_skilldata.py`). `doNormalAttack` (`Bat.cs:10020-10300`): stage 2 needs #101 (pressed 0.3-0.6 s after stage 1), stage 3 needs #102 (after 0.9 s); otherwise stage 1 when the `nAttack` lock is free. Locks: stage 1 and 2 `addTimeOut("nAttack", 1.5)` (`:20367`, `:20659`), stage 3 `2` s (`:21074`), all flat.
- **Each stage fires a bolt** (`RPC_nAttack_fire1`, `Bat.cs:10746`): one `nAttack_fire` projectile from 1.3 m up / 1 m ahead, `life = 1.25 × rangeMod` s (`:10762`). With #103, stage 3 calls `RPC_nAttack_fire2` instead: three bolts, offset ±1 m sideways and turned ±15° (`:10836-10868`). Bolts home on the locked target only with the `w_bat59` weapon (`:10765-10788`; `Bat_nAttack.InitHoming`, turn 0.1 rad every 0.1 s).
- **Hit** (`Bat_nAttack.OnTriggerEnter`, `Bat_nAttack.cs:138-366`, on the Bat's own client): first enemy collider touched; `num = (int)(0.5 × ATK)`, `floor(0.75 ×)` with `w_bat59`, then `getCritPlus` (gear crit, standard table, `Bat.cs:19389`), `hit(1, t, num, KO 1, 0, …)`. On a landed hit: `onNormalAttackHit` (weapon procs), +1 SP, and with Amplify Damage (#251-#254) `amplifyDamage` at that level for `getDebuff(3)` s (`:276-363`).
- Shadow Illusion clones repeat every stage from their own position (`Bat.cs:10086-10112`, `:10191-10217`, `:10266-10290`); with #103 their stage 3 also fires three bolts (`Bat_illusion.cs:3895-3914`, the clone has the Bat's skill list). A clone copies the Bat's ATK / LCK / gear at summon (`Bat_illusion.cs:60-120`), its `damageMod` is `clamp(0.25 + 0.25n, 0.5, 1)` (`Bat_illusion.cs:151`), and its bolt (`Bat_illusionFire.cs`) has no `w_bat59` cut and only crits with Illusion Effect.
- **Card (2026-10-06, user):** a `BAT_COMBO_ILLUSION_DEP` rank toggle (0-4 = Shadow Illusion level; 1 clone at rank 1, 2 from rank 2) adds a `Shadow Illusion` group with `stage hits × clones` hits, `damageMod` 0.5 / 0.5 / 0.75 / 1 instead of the player's buffs, and `critOff` unless `BAT_COMBO_ILLUSIONEFFECT_DEP` is on.
- **Card (2026-10-06):** `BAT_COMBO_GEAR` controls: crit Wand (G. Marshal +5 / G. Champion +7), crit armor + hat (+7 / +11) and Homing Wand (`w_bat59`, "A wand that is precise in striking…", `WeaponData_eng.cs:5764`; `floor(0.75x)` before the crit, exclusive with the crit Wand).
- Client tooltips: EN "…ability to use her normal attack's second [third] strike." / "Changes Bat's third combo into a three-way projectile attack." (`BatSkill_eng.cs:31-53`). Matches.

### bat_cAttack1-3 (Drain Life, #111-#113) (verified 2026-10-01)

- Passive ranks, reqLv/Bn 4/1, 10/3, 16/5. Level `eLv` = rank + Dark Intention (#411) (`getDrainLifeLv`, `Bat.cs:11036-11075`).
- **Charge** (`$RPC_cAttack1$19877`, `Bat.cs:21410-22646`): needs the locked target within `16 + 12 × DarkIntention` m (16 / 28 m, `:21612`, "Target is too far" `:21690`, `:21994`). Every **1 s** (`:22066-22074`), on the Bat's client:
  - `hpDrain` Lv `eLv` for 1 s with value `ceil(damageMod × clamp(ceil((0.03 + 0.03 × eLv) × ATK), eLv, 9 × eLv))` (`:21792`, `:22152`). `hpDrain` deals that as Effect Damage and heals the Bat by the same amount (mechanics reference, status catalogue).
  - with Drain Mana: `mpDrain` Lv / value from the same formula at Drain Mana's level (`:21802`, `:22164`);
  - with Merciless Drain: `spDrain` and the 66 bonus (see the Merciless Drain entry above);
  - `RPC_cAttack_hit` effect, +1 SP (`:22199`);
  - with Amplify Damage: `amplifyDamage` Lv for `getDebuff(3)` s (`:22204-22215`);
  - with Dream Burst: the burst (see its entry below).
- Clones channel the same drain (`RPC_cAttack1`/`0` on each clone).
- Client tooltips: EN "…charge and drain HP from the target. (6% [9% / 12%] atk, 1~9 [2~18 / 3~27] dmg)" (`BatSkill_eng.cs:64-86`). Matches `0.03 + 0.03 × eLv` and the clamp.

### bat_drainMana1-3 (Drain Mana, #121-#123) (verified 2026-10-01)

- Passive ranks, reqLv/Bn 8/2, 16/4, 24/6. Level = rank + Dark Intention (`getDrainManaLv`, `Bat.cs:11080-11119`). Each Drain Life tick also applies `mpDrain` Lv with value `clamp(ceil((0.03 + 0.03 × lv) × ATK), lv, 9 × lv)` for 1 s (`Bat.cs:21797-21802`, `:22164`); `mpDrain` takes that MP from the target at once and gives it to the Bat (`CharacterControl.cs:33543-33610`).
- Client tooltips: EN "Gives 'drain life' the ability to also drain MP from the target. (6% [9% / 12%] atk, 1~9 [2~18 / 3~27] dmg)" (`BatSkill_eng.cs:97-119`). Matches.

### bat_shadowGaze1-4 (Shadow Gaze, #211-#214) (verified 2026-10-01)

- reqLv/Bn 5/1, 13/3, 21/5, 29/7; MP **11 / 15 / 19 / 23**; target, enemy; instant (`decode_skilldata.py`).
- `RPC_shadowGaze` (`Bat.cs:11281-11620`): cooldown `agiAdjust(30)`, `agiAdjust(20)` with Demon Gaze #412 (`:11319-11333`). Without `massCast` only the target; with it every enemy in `FindAreaTarget(target, 18, 12)`, at most 6 (`:11447-11513`). Each takes `hit(210 + rank, t, talAdjust(12 + 12 × rank + (Demon Gaze ? 12 : 0)), KO 0, 0, …)` (`:11614`).
- Client tooltips: EN "Instantly deal some damage to the target. (24 [36 / 48 / 60] dmg)" (`BatSkill_eng.cs:240-273`). Matches the `talAdjust` base.

### bat_echoes1-2 (Echoes, #241/#242) (verified 2026-10-01)

- reqLv/Bn 12/4, 20/8; MP 17 / 21; SP **−13** (red); instant, enemy (`decode_skilldata.py`). Cooldown `agiAdjust(60)` (`Bat.cs:28202`).
- **Cast** (`$RPC_echoes$20030`, `Bat.cs:27814-28220`): living enemies in `FindAreaTarget(Bat, 20, 10)` are listed (`:28029`); **three orbs** are fired 120° apart, each homing on a **random** enemy from that list (`:28039-28098`), or flying straight when the list is empty. Orb life `5 × rangeMod` s (`:11844`).
- **Hit** (`Bat_echoes.OnTriggerEnter`, `Bat_echoes.cs:190-530`): `hit(1, t, talAdjust(20 + 20 × echoLv), KO 1, 0, …)` (`:357`), `echoLv` starting at the rank. After a landed hit with `echoLv > 0`, the orb re-fires from the hit point at the **nearest other** enemy in `FindAreaTarget(target, 30, 10)` with `echoLv − 1` (`:369-530`). So rank 2 deals `talAdjust(60)`, then `talAdjust(40)`, then `talAdjust(20)` per orb. The action code is 1 (the normal-attack code), so `blind` on the Bat can make the orbs miss.
- Client tooltips: EN "Shoot three magic balls that bounce between targets once [twice]. (40 [60] dmg)" (`BatSkill_eng.cs:372-383`). The figure is the first hit; each bounce is 20 lower.

### bat_shadowMastery1-2 (Shadow Mastery, #263/#264) (verified 2026-10-01)

- Passive, reqLv/Bn 34/20, 40/24. Level 1 / 2 (`getShadowMasteryLv`, `Bat.cs:12219`).
- **Cooldowns:** Phantom Bane, Dissolute, Corruption, Curse and Doom get cooldown **0** while it is learned (`Bat.cs:24457-24543`).
- **Stacking:** when the new cast's level is ≤ the level already on the target, the applied level becomes `clamp(targetLv + SM, castLv, cap)` (`Bat.cs:25465-25482` and the matching sites). Caps: Phantom Bane **6** (`:25482`), Dissolute **4** (`:26138`), Corruption / Curse / Doom **cast rank + SM** (`:26800`, `:27462`, `:29416`), Shame **4 + SM** with a floor of 4 (`:39712`).
- Client tooltips: EN "Give Bat the ability to increase her curses by 1 [2] level when she stacks it on the same target." (`BatSkill_eng.cs:482-493`). They omit the cooldown removal and the caps.

### bat_mirageOrb1-4 (Mirage Orb, #301-#304) (verified 2026-10-01)

- reqLv/Bn 3/0, 11/1, 19/2, 27/3; MP 11 / 15 / 19 / 23; instant (`decode_skilldata.py`). Cooldown `agiAdjust(30)` via the cast dispatcher (`Bat.cs:24556`). Life `chaAdjust(30)` (`:31265`).
- **Placement** (`Bat.cs:31235-31268`): 1 m up / 1 m ahead of the Bat, or at the locked target's position with Distant Orb (#403). Four slots used round-robin; a fifth orb replaces the oldest (`Bat.cs:12688-12778`).
- **Orb** (`Bat_mirageOrb.cs`): level `L = rank + (Distant Orb ? 2 : 0)` (`Bat.cs:12799`). `OnTriggerStay` with an enemy (other layer, Player/Enemy tag, alive), **one shared 0.5 s timer per orb**: `RPC_AddEffectDamage(300 + L, 6L − 1)` (`:263-349`). So an orb hurts at most one enemy per 0.5 s. It adds the damage to a running total and is destroyed when the total **exceeds** `60L − 10` (`:185`), i.e. after **11** ticks, or when its life ends.
- Client tooltips: EN "Cast an invisible orb that deals effect damage to any target inside. (5 [11 / 17 / 23] dmg, 30 sec)" (`BatSkill_eng.cs:526-559`). Matches `6L − 1`. ToT change: see Server Balance Variations above.

### bat_shadowIllusion1-4 (Shadow Illusion, #311-#314) (verified 2026-10-01)

- reqLv/Bn 5/1, 13/3, 21/5, 29/7; MP 21 / 29 / 37 / 45; instant, self. Cooldown `agiAdjust(60)` (`Bat.cs:24573`); duration `chaAdjust(60)` (see the Duration citations above).
- **Clones** (`$RPC_shadowIllusion`, `Bat.cs:31430-31560`): clone 1 always, clone 2 from rank 2. `RPC_shadowIllusion_create` (`Bat.cs:12924-13125`) gives each clone `damageMod = 0.25 + 0.25 × n` (n = 1 / 1 / 2 / 3 for ranks 1-4 → **50 / 50 / 75 / 100%**) and `hitMod = 2.0 − 0.2 × Dream Burst level` (`:13088-13115`).
- `Bat_illusion.summon` (`Bat_illusion.cs:60-154`) copies the Bat's current HP/MP/SP/KO and maxima, all stats, gear, weight, run speed and skill list; `damageMod` is clamped to 0.5-1 and `hitMod` to 1.4-2.
- Clones repeat the Bat's Combo stages, Drain Life channel, emotes and KO (`Bat.cs` calls on `bat_illusion*`); spells are not repeated.
- Client tooltips: EN "Create one [two] illusion cop(y/ies) that deal 50% [50 / 75 / 100%] dmg and receive 160% dmg. (30 sec)" (`BatSkill_eng.cs:570-603`). Code wins: they take **200%** (hitMod 2.0) without Dream Burst and last `chaAdjust(60)`.

### bat_hateTransfer1-2 (Hate Transfer, #331/#332) (verified 2026-10-01)

- reqLv/Bn 9/3, 17/5; MP 13 / 17; target, any. Cooldown `agiAdjust(60)` (`Bat.cs:24624`).
- **Effect** (`$RPC_hateTransfer_cast$20176`, `Bat.cs:33161-33700`): every character in `FindAreaTarget(target, 40, 6)` on any layer (`130816`, `:33343`) has its hate entry for the Bat lowered by `remove = max(talAdjust(20 × rank), floor(hate − Time.time))` and gets `addHate(target, remove)` (`:33376-33420`). So the Bat's hate on each is moved to the chosen target, at least `talAdjust(20 / 40)`.
- Client tooltips: EN "Transfer 40 [80] hate point from Bat to any target." (`BatSkill_eng.cs:658-669`). The code's floor is `talAdjust(20 / 40)`, and it moves the whole entry when that is larger.

### bat_switch1 (Switch, #333) (verified 2026-10-01)

- reqLv 25, reqBn 7; MP 0; SP **−10** (red); instant. Refused with "No Illusion to switch place with" (cost refunded) when no clone exists (`Bat.cs:7870-7893`).
- `RPC_switch` (`Bat.cs:13272-13410`): cooldown `agiAdjust(12)`; the Bat and the clone exchange positions; the Bat clears lock statuses up to Lv **4** (**5** with Paranoia #433) and releases its target; each clone also clears locks up to Lv 4 and releases its target (`:13300-13356`).
- Client tooltips: EN "Instantly switch locations between Bat and one illusion." (`BatSkill_eng.cs:680`). They omit the lock cleanse.

### bat_swap1 (Swap, #334) (verified 2026-10-01)

- reqLv 33, reqBn 9; MP 15; SP **−15** (red); target, any. Only targets whose `recieveForce` is true can be chosen (`Bat.cs:7987`). Cooldown `agiAdjust(30)` (`:24641`).
- At the end of the cast (`$RPC_swap_cast$20196`, `Bat.cs:33757-34245`), if the target is within **32 m** (flat distance, `:33930-33935`), `RPC_swap_hit` moves the target to the Bat's position and the Bat to the target's (`:33947-33970`, `:13537-13553`); otherwise "Swap failed: target is too far away" (`:33979`).
- Client tooltips: EN "Instantly switch locations between Bat and the target." (`BatSkill_eng.cs:691`).

### bat_dreamBurst1-3 (Dream Burst, #361-#363) (verified 2026-10-01)

- Passive, reqLv/Bn 22/15, 28/18, 34/21.
- **Clone defence:** each Shadow Illusion clone's `hitMod` is `2.0 − 0.2 × level` (1.8 / 1.6 / 1.4) (`Bat.cs:13110`).
- **Burst:** during Drain Life, the first burst comes `8 − level` s after the first tick and repeats every `8 − level` s (7 / 6 / 5 s) (`Bat.cs:21817-21833`, `:22087-22099`). Each burst is `hit(360 + level, drainTarget, talAdjust(16 + 4 × level), KO 1 + level, 0, …)` (`:22112`): a normal `hit()` on **the drained target only**, plus the `dreamBurst_hit` visual (`:13952`, effect only).
- Client tooltips: EN "Decrease damage taken by illusion by 20% [40 / 60%] and enable drainLife to explode every 7 [6 / 8] seconds. (20 [24 / 28] dmg, 2 [3 / 4] ko)" (`BatSkill_eng.cs:790-812`). Code wins: rank 3 is every 5 s (the "8 seconds" is a tooltip error), and the reduction is 0.2 hitMod per level from a base of 2.0.

### bat_mimic1-2 (Mimic, #371/#372) (verified 2026-10-01)

- reqLv/Bn 35/23, 40/25; MP 50 / 70; SP **−25 / −35** (red); target, any. Cooldown `agiAdjust(360)` (`Bat.cs:24726`); duration flat `chaAdjust(60)` for both ranks (Duration citations above).
- **Dispatch:** structures are refused ("Cannot mimic structure"), and so are `SmashBall` / `GenesisSeed` and summons (`Bat.cs:8855-8900`).
- **Cast checks** (`$RPC_mimic_cast$20301`, `Bat.cs:37871-38440`): dead target refused; hero types need `target Lv <= Bat Lv`; other types need `target Lv <= 15 × rank + 20` (**35 / 50**) (`:38203`, `:38243`), else "Target's level is too high".
- **Copy** (`RPC_mimic_create`, `Bat.cs:38696-39312`): the double copies the target's skills with ID < 200 (Basic tree); with All Mimic also IDs 200-399 (Trees A and B); Class-C IDs (≥ 400) are never copied (`:39067-39114`). It receives `mimic` Lv 1 for the duration; the Bat itself gets `hide` for duration + 12 s.
- Client tooltips: EN "Transform and copy all active skills and stats from target that has 15 level lower than Bat's level. (60 sec)" / rank 2 "…level lower or equal to Bat's level. (90 sec)" (`BatSkill_eng.cs:823-834`). Code wins on the level rule (fixed 35 / 50 for non-heroes, Bat's level for heroes) and on the duration (60 for both ranks).

### bat_allMimic1 (All Mimic, #373) (verified 2026-10-01)

- Passive, reqLv 45, reqBn 27.
- **Skills:** Mimic also copies the target's Tree A / B skills (IDs 200-399, active and passive) (`Bat.cs:39102-39114`; same filter for clones at `Bat_illusion.cs:2612-2624`).
- **Clones:** instead of disappearing on Mimic, each clone transforms too (`RPC_allMimic`, `Bat.cs:39202-39292`) and gets `allMimic` Lv 1 for `chaAdjust(60)` (`Bat_illusion.cs:2642`). `Bat_allMimic` forwards the Bat's `doNormalAttack` / `doBeginCharge` / `doReleaseCharge` to both transformed clones (`Bat_allMimic.cs:21-128`).
- Client tooltips: EN "Enable Bat to copy all passive skills with mimic and give illusions the ability to use mimic as well." (`BatSkill_eng.cs:845`).

### bat_illusionEffect5 (Illusion Effect, #401) (verified 2026-10-01)

- Passive, reqLv 55, reqBn 0. Three gates in the clone bolt (`Bat_illusionFire.cs`), each on the clone's copied skill list:
  - **Homing:** the bolt homes on the locked target (`:103-124`);
  - **Gear crit:** the bolt's `(int)(0.5 × ATK)` goes through the clone's `getCritPlus` (`:282-291`, `:407-560`);
  - **Weapon procs:** after a landed hit, `Bat_illusion.onNormalAttackHit` (`:360-366`), which handles `w_bat15` charm (`lckAdjust(6)`, `getDebuff(6)`), `w_bat39` illuminate Lv 2 on the clone (`lckAdjust(12)`, `chaAdjust(12)`), `w_bat46` plague (`lckAdjust(12)`, `getDebuff(30)`), `w_bat49` heavy Lv 2 (`lckAdjust(6)`, `getDebuff(15)`), `w_bat56` mpDrain Lv 2 and `w_bat66` hpDrain Lv 2 (`lckAdjust(12)`, value `floor(0.02 × clone max MP / HP)`), plus accessory bonuses to those chances (`c_all46` plague +8, …) (`Bat_illusion.cs:7360-7590`).
- Without it, a clone bolt still deals `(int)(0.5 × ATK)` with no crit and gives the clone's owner character +1 SP (`Bat_illusionFire.cs:354-372`; the projectile's owner is the clone, `Bat_illusion.cs:2016`).
- Client tooltips: EN "Gives illusion's normal attack the effect from Bat's weapon and the ability to give SP back to Bat." (`BatSkill_eng.cs:856`).

### bat_autoMass5 (Auto Mass, #431) (verified 2026-10-01)

- Passive, reqLv 75, reqBn 4.
- **Proc** (cast dispatcher, `Bat.cs:23247-23360`): when the Bat casts Phantom Bane, Dissolute, Corruption, Curse, Doom, Blind, Confusion, Dream Dazzle, Phantasm Blast, Charm or Shame without `massCast` active, `Random.Range(0,100) < lckAdjust(12)` gives `massCast` Lv 1 for a flat **3 s** (`:23360`), which the spell then spreads with.
- **Class-C unlock:** Shame, Soul Eater, Paranoia and Shattering Dream read `massCast` only when #431 is learned (`Bat.cs:39599`, `:40828`, `:41411`, `:42038`); otherwise they hit only their target.
- Client tooltips: EN "Gives 13% chance for any spell to be mass cast. Enable C skills to be mass cast." (`BatSkill_eng.cs:889`). Code wins: base 12, LCK-scaled, and only for the eleven spells above.

### bat_demonBane5 (Demon Bane, #402) (verified 2026-10-01)

- Passive, reqLv 55, reqBn 0. In Phantom Bane's hit (`Bat.cs:25428-25489`): level +1 (on top of the +1 from `shame` on the target) and duration `getDebuff(12) + getDebuff(6)` (two separately contested parts) (`:25443-25454`), message "Demon Bane".
- Client tooltips: EN "Increase the effect of phantomBane by 1 level and increase its duration by 6 sec." (`BatSkill_eng.cs:911`).

### bat_demonGaze5 (Demon Gaze, #412) (verified 2026-10-01)

- Passive, reqLv 60, reqBn 1. Shadow Gaze: cooldown `agiAdjust(20)` instead of 30 (`Bat.cs:11319-11333`) and `+12` inside its `talAdjust` (`:11614`).
- Client tooltips: EN "Add 12 damage to shadow gaze and reduce its cooldown by one third." (`BatSkill_eng.cs:922`). Matches.

### bat_soulEater5 (Soul Eater, #442) (verified 2026-10-01)

- reqLv 85, reqBn 6; MP 40; SP **−40** (red); target, enemy. Cooldown `agiAdjust(150)` (`Bat.cs:41007`).
- Targets: only the target, or with Auto Mass and `massCast` active every enemy in `FindAreaTarget(target, 18, 12)` with no target cap (`Bat.cs:40828-40857`).
- **Damage** (`RPC_soulEater_hit`, `Bat.cs:14375-14538`): `n` = sum of the levels of every debuff on the target (`isDebuff()`); with `n > 0`, `RPC_AddEffectDamage(442, clamp(39 × n, 39, 1333))`. Debuffs are not removed.
- Client tooltips: EN "Deal damage equal to the total level of debuff on the target. (33 dmg per lv, max 1333)" (`BatSkill_eng.cs:955`). Code wins: 39 per level.

### bat_distantOrb5 (Distant Orb, #403) (verified 2026-10-01)

- Passive, reqLv 55, reqBn 0. Mirage Orb level +2 (`Bat.cs:12799`; `6L − 1` → +12 damage per tick and a higher destroy threshold) and placement at the locked target's position, message "DistantOrb" (`Bat.cs:9279-9309`, `:31241-31258`).
- Client tooltips: EN "Add 12 damage to mirageOrb and enable bat to create it at target location." (`BatSkill_eng.cs:966`). Matches.

### bat_shadowSacrifice5 (Shadow Sacrifice, #413) (verified 2026-10-01)

- reqLv 60, reqBn 1; MP 30; SP **−30** (red); instant, self. Refused with "Required shadow illusion" when no clone exists (`Bat.cs:8164-8187`). Cooldown `agiAdjust(120)` (`:14110`).
- `RPC_shadowSacrifice` (`Bat.cs:14100-14342`): for each clone, `ceil(0.2 × clone HP)` is added up and the clone disappears; the Bat then gets `RPC_AddHeal(413, total)`.
- Client tooltips: EN "Sacrifice all illusions to give 20% of their remaining hp back to Bat." (`BatSkill_eng.cs:977`). Matches.

### bat_nefariousWhip5 (Nefarious Whip, #434) (verified 2026-10-01)

- reqLv 75, reqBn 4; MP 70; SP **−35** (red); target, enemy. Cooldown `agiAdjust(180)` (`Bat.cs:43044`).
- After the cast (`$RPC_nefariousWhip_cast$20440`), `RPC_nefariousWhip_hit` (`Bat.cs:43783-44075`) ticks **8** times, 0.5 s apart (`i < 8`): each tick every enemy in `FindAreaTarget(hitPos, 4, 6)` takes `RPC_AddEffectDamage(434, (int)(0.5 × CHA), 0, 0, …)` (`:43918-43957`).
- Client tooltips: EN "Summon shadow vines that deal damage equal to Bat's charisma." (`BatSkill_eng.cs:1054`). Code wins: half of CHA per tick.

### bat_guardianOfTheNight1-2 (#271/#272) — active, rank family (verified 2026-10-01)

- reqLv/Bn 35/23, 40/25; MP **70 / 90**; SP **−35 / −45** (red); instant, self (`decode_skilldata.py`). Cooldown `agiAdjust(600)` (`Bat.cs:30200`); status duration `chaAdjust(30 × rank)` (60 at rank 2).
- **Tooltip mismatch (found 2026-10-03):** TH "(60 sec)" / "(90 sec)" (`BatSkill_thai.cs:532`, `:543`); the code is `chaAdjust(30 / 60)` (`Bat.cs:30592`). Card `tooltipNote`.
- **Cast time:** `magAdjust(3 × rank + 7)` = **10 / 13 s** (`Bat.cs:30052`), then `RPC_guardianOfTheNight_cast` summons the boss (`:30163`).
- **Boss melee** (`Bat_guardianOfTheNight.cs:848-1333`): `FindAreaTarget(boss, 4, 3)`, `hit(270 + rank, t, 66 × rank + 33, KO 3, 0, …)` = 99 / 165. Its AI loop, search radius and cast chance are in "Follow-up verification" above. Its other attack animations were not traced (no further `hit()` or Effect Damage call exists in that file).

### bat_darkStalker5 (Dark Stalker, #432) — Class-C active (verified 2026-10-01)

- reqLv 75, reqBn 4; MP **45**; SP **−20** (red); target, enemy (`decode_skilldata.py`). Cooldown `agiAdjust(120)` (`Bat.cs:24760`). Only a hero-type target is accepted ("Can only cast on player", `Bat.cs:8252-8277`).
- Applies `darkStalker` Lv 9 for a flat 999 s to a living target that does not already have it (`Bat.cs:40234-40263`). The status deals `floor(0.3 × target CHA)` Effect Damage every 4.5 s (status table above).

### bat_chiroptophobia5 (Chiroptophobia, #423) — Class-C passive (verified 2026-10-01)

- reqLv 70, reqBn 3; no cost. `Chiroptophobia()` runs from the Bat's own `Update`, at most once per **1 s** (`Bat.cs:13166-13241`): every enemy within `FindAreaTarget(Bat, 12, 5)` gets `chiroptophobia` at level `blind Lv + confuse Lv` for 60 s, only when that is higher than the level it already holds.
- The status ticks every 1.5 s for `RPC_AddEffectDamage(422, 7 × Lv + 7)`, attributed to the Bat, and is removed when the target has neither `blind` nor `confuse`, when the Bat is gone, or when the Bat is more than 13 m away (`CharacterControl.cs:9674-9759`).

### bat_blackServant5 (Black Servant, #444) — Class-C active (verified 2026-10-01)

- reqLv 85, reqBn 6; MP **66**; SP **−66** (red); target, enemy. Cooldown `agiAdjust(180)` (`Bat.cs:44579`).
- Target must be a **dead hero-type player** (`isHeroType`, `isPlayer`, `actionState == "dead"`, else "Can only cast on player", `Bat.cs:8468-8511`). The cast adds the matching `Shadow<Class>_AI` component (Wolf, Bison, Panda, Whale, Cat, Chameleon, … `:44954-45055`) and applies `blackServant` Lv 5 for `getDebuff(90)`; status effects are in the table above.
- **Zombie AI (verified 2026-10-06):** `Bat.cs:44954-45175` adds `Shadow<Type>_AI` by `hitChar.Type` and sends `AddAISummoner(Bat)`; the AI runs from its own `Update` unless `isControlled` (`ShadowWolf_AI.cs:50-86`). All 12 files share the same frame (the constants are identical in every file):
  - **Idle:** if the Bat is more than **6 m** away (`sqrMagnitude > 36`) it runs to the Bat, else `AI_idle(3, 1)` / `AI_patrol(1, 0.25)` (`ShadowWolf_AI.cs:125-160`). `AI_visionCheck` once per second: `Hate.findEnemies(pos, 40, layer)`, skipping Plants / Structure for a Tails-race body, dead targets, `invisible` and `blend` (`:821-1075`); a hit sets `isAlert` and `addHate(5)`.
  - **Alert:** drops the fight when the Bat is more than **30 m** away (`sqrMagnitude > 900`, `:192-202`); else `getHateTarget(5, 50)` (`:689`) and `AI_attack(10, 0)`.
  - **Decision:** distance = flat distance − target `collider.bounds.extents.x`. A fixed priority list of `sp > N` → `hasSkill(<exact rank ID>)` → range → `isTimeOut(key) == 0` → `StartCoroutine(RPC_<skill>(…, sLv))` with a **hard-coded `sLv`**; otherwise the basic attack, otherwise run to the target. `hasSkill` is an exact `mSkillList` match (`CharacterControl.cs:21498`).
  - **No cost:** MP / SP are only deducted by the player input path (`GameGui.cs:37780-37830`), so AI casts pay nothing and SP stays above the threshold; cooldowns are set inside each `RPC_` coroutine (e.g. `Wolf.cs:26381`, `RPC_cast1` `Penguin.cs:19869`), and `RPC_cast1` keeps its cast bar (`Penguin.cs:19475`). The combo chain never checks the Combo ranks (no `hasSkill(10x)` in any AI file).
  - Priority lists below: `sp >` threshold, skill, cast sLv, [condition; requirement when it differs from the cast rank].

#### bat_zombieWolf — Zombie Wolf (`ShadowWolf_AI.cs:1395-2028`)
60 Lunar Eclipse 1 [needs #372 = rank 2]; 55 Grand Cross 1 [reads `mGrandCrossMark`]; 50 Blade Song 3 [<4 m]; 45 Cross Break 3 [<3]; 40 Feral Strike 4 [<4]; 35 Armor Break 2 [<2]; 30 Counter 2 [<2]; 25 Power Break 2 [<3]; 20 Art Cancel 2 [<3]; 15 Crusader 4 [<2]; 10 Blade Fang 3 [<2; needs #304, which Wolf does not have, so never]; 5 Brave Spirit 4; else Combo 1 → 2 (0.8 s) → 3 (0.6 s) at <2 m.
- **BB bug:** the Grand Cross gate is `UnityRuntimeServices.GetProperty(wolf, "mGrandCrossMark")` (`:1445`); Wolf's public field is `mGrandMark` (`Wolf.cs:14427`) and no `mGrandCrossMark` exists anywhere in the source, so the duck-typed lookup throws and ends that decision pass. Whenever SP > 55 and Lunar Eclipse is not taken, the Wolf zombie does nothing (no lower skill, no Combo, no movement).

#### bat_zombieBison — Zombie Bison (`ShadowBison_AI.cs:1415-2023`)
60 Titan Form 2; 55 Over Power 2; 50 Earth Smasher 2 [<3]; 45 Trample 2 [<4; needs #212 = Slam 2]; 40 Earth Rupture 2 [<9]; 35 Far Stun 2 [8-32]; 30 Iron Shield 1; 25 Knock Down 4 [<1]; 20 Warcry 2; 15 Slam 2 [<1]; 10 Power Cleave 2 [<1]; 5 Enrage 4 [no `enrage`]; else Combo at <1 m, hit 3 = `Random.Range(0,100) < 60` ? `nAttack3` : spin `nAttack4` (flat, no LCK).

#### bat_zombiePanda — Zombie Panda (`ShadowPanda_AI.cs:1571-2200`)
90 Heaven Palm 2 [12-24]; 55 Ashura 2; 50 Rain & Storm 2 [<3]; 45 Rising Dragons 2 [<2]; 40 Stasis Blow 2 [<3]; 35 Rising Vortex 2 [<3]; 30 Stasis Blow 2 [<3] (listed twice); 25 Pummel 2 [<2]; 20 Water Crane 2 [<2]; 15 Rushing Falcon 2 [<4]; 10 Drunken Fist 2 [<1]; 5 Three Steps 2 [<2]; else Combo at <1 m, up to 5 stages while the centre distance stays ≤ 1 m.
- **BB bug:** Three Steps checks `isTimeOut("threeStep")`; the skill sets `"threeSteps"` (`Panda.cs:21519`), so its cooldown never blocks the AI.

#### bat_zombieWhale — Zombie Whale (`ShadowWhale_AI.cs:1392-2028`)
90 Megalodon 2 [<32]; 85 12th Kingdom Knight 2 [<32, self]; 50 Mal Storm 2 [<2]; 45 Peninsula Round 2 [<2]; 40 Whale Wave 2 [<2]; 35 Peninsula Impale 2 [<2]; 30 Rejuvenate 4 [self, no `rejuvenate`]; 25 Shield Rush 2 [<2]; 20 Hydro Blast 4 [>4]; 15 Javelin 2 [4-12]; 10 Bubble Shield 4 [self, no `bubbleShield`]; 5 Sweep 2 [<2]; else Combo 3 stages at <1 m.

#### bat_zombieCat — Zombie Cat (`ShadowCat_AI.cs:1504-2119`)
90 Grand Casino Arcade 2; 60 Delta Strike 2 [<3]; 50 Moon Storm 2 [<4]; 45 Damage Roulette 2 [<4]; 40 Bleed 2 [<1]; 35 Lucky Dice 2 [<4]; 30 Reverse Thrust 2 [<1]; 25 Life Gamble (sLv 2) [hp < floor(0.6 mhp); needs #223]; 20 Forward Lunge 2 [<3]; 15 Fate Draw 4 [<18]; 10 Flying Dagger 4 [<18]; 5 Lucky Card 4; else Combo at <2 m, up to 4 stages while the centre distance stays ≤ 2 m.

#### bat_zombieChameleon — Zombie Chameleon (`ShadowChameleon_AI.cs:1374-2096`)
All inside `distance < 18`, else run. 65 Final Entrapment 2; 60 All Slain 2; 55 Venom Shock 2 [target `poison` Lv ≥ 4]; 40 All Tail Slayer [#362]; 45 Poison Volley 2 [<5]; 40 Tail Slayer [#342]; 35 Mass Shot 2 [<4]; 30 Right Stride 2; 25 Needle Prison 2 [target without `needlePrison`]; 20 Left Stride 2; 15 True Invisibility 2 [self, no `invisible`]; 10 Fatal Strike 4; 5 Quick Fire 4; else an `nAttack1` volley when `nAttack` is free (stands facing the target while it is not).

#### bat_zombieRabbit — Zombie Rabbit (`ShadowRabbit_AI.cs:859-1540`)
A plain method, not a coroutine. All inside `distance < 18`, else run. 90 Millionaire 2 [<6]; 85 Gorgon Shot 2; 50 Shooting Array 2; 45 Rapid Trance 1; 40 Circle Shot 2 [<7]; 35 Acidic Field 2; 30 Four Shot 2; 25 Sticky Gum 2; 20 Backpack 2 [<2]; 15 Mix 4; 10 Gil Shot 4; 5 Maim Shot 4; else one `RPC_nAttack` shot when free, standing still while it is not.
- **BB bug:** Millionaire and Shooting Array check `isTimeOut("RPC_millionaire")` / `("RPC_shootingArray")` (`:889`, `:978`); the skills set `"millionaire"` / `"shootingArray"` (`Rabbit.cs:36869`, `:35766`), so neither cooldown ever blocks the AI.

#### bat_zombieMole — Zombie Mole (`ShadowMole_AI.cs:1443-1970`)
55 Time Nuke 2; 45 Flame Turret 2 [2-8; needs #243 = rank 3]; 40 Missile 4 [<12]; 35 Stun Grenade 2 [6-12]; 30 Chopper 3 [<7]; 25 TNT 2 [14-18; needs #224 = TNT 4; key `"tnt2"` matches `Mole.cs:26180`]; 20 Mega Hammer 2 [<2]; 15 `RPC_mortarShot` sLv **4** [needs #214 = Bunker 2; `2 × sLv + 1` = 9 shells]; 10 Mega Punch 2 [<2]; 5 Mine 4; else Combo at <2 m: `nAttack1`, then `RPC_nAttack2` twice while ≤ 12 m (stage 3 replays stage 2).

#### bat_zombieMonkey — Zombie Monkey (`ShadowMonkey_AI.cs:1355-1687`)
All inside `distance < 5`, else run. 55 World Ignition 2; 50 Runic Sand [#364]; 45 Runic Flame [#264]; 40 Stone Hammer 4; 35 Flash Fire 4 [<4]; 10 Ground Lock 4; 5 Fireball 4; else Combo 2 stages.

#### bat_zombiePenguin — Zombie Penguin (`ShadowPenguin_AI.cs:1401-1975`)
All inside `distance < 32`, else run. 60 Arctic Emperor 2 [<4]; 55 Meteora 2; 50 Absolute Zero 2 [<3]; 45 Falling Comets 2; 40 Tornado 3 [<12; needs #344 = Typhoon]; 35 Falling Stars 2; 30 Ice Shield 4 [self]; 25 Mana Burn 2; 20 Arctic Wind 3 [<3; needs #314 = Arctic Frost]; 15 Mana Arc 4 [<3]; 10 Frozen Blast 4; 5 Mana Missile 4; else Combo 3 stages.
- **BB bug:** Ice Shield checks `isTimeOut("arcticWind")` instead of `"iceShield"`, so its own cooldown never blocks it; it repeats whenever Arctic Wind is off cooldown.

#### bat_zombieSheep — Zombie Sheep (`ShadowSheep_AI.cs:1373-1968`)
All inside `distance < 24`, else run. 60 Soul of Arms 2; 55 Holy Light 2 [mp > 100]; 50 Reverse 2 [self, no `reverse`]; 45 Over Heal 2 [on the enemy target, when `tChar.hp == tChar.mhp`]; 40 Divinity Spear 2; 35 Sleep 2 [target without `sleep`]; 30 Divinity Sword 2; 25 All Heal 2 [self hp < floor(0.4 mhp)]; 20 Feather 2 [self, no `feather`]; 15 Bless 4 [self, no `bless`]; 10 Light Bind 4; 5 Heal 4 [self, hp < floor(0.8 mhp)]; else Combo 2 stages. Every heal / buff goes on the zombie itself, never the Bat.

#### bat_zombieBat — Zombie Bat (`ShadowBat_AI.cs:1401-1852`)
All inside `distance < 32`, else run. 55 Doom 2; 45 Echoes 2; 40 Phantasm Blast 2; 35 Curse 2 [needs #234 = Curse 4]; 30 Dream Dazzle 2; 25 Corruption 2; 20 Confusion 2; 15 Shadow Gaze 4; 10 Blind 2; 5 Phantom Bane 4; else Combo 3 stages.

## Open questions & card mismatches (2026-10-01)

**Card mismatches** (cards in `index.html` vs the entries above):
1. ~~`bat_shadowGaze` `cost.mp` rank 2 was 13~~ → fixed to 15 (2026-10-01).
2. ~~`bat_echoes` `ko:"0"`~~ → fixed to `"1"`, and the `desc` now says each bounce deals `talAdjust(20 + 20 × levels left)` (2026-10-01). Still open: `dmg` / `hitCount` model only the first hit of each orb.
3. ~~`bat_dreamBurst` / `bat_cAttack` `desc` described an area burst of true magic damage~~ → fixed: an explosion on the drained target (2026-10-01).
4. ~~`bat_mirageOrb` `desc` "10 hits"~~ → fixed to 11 in the base and ToT `desc` (2026-10-01).
5. ~~`bat_mimic` `duration: [60, 90]`~~ → fixed to `60` (2026-10-01).
6. ~~`bat_allMimic` `desc` "copies Basic, A and B passives"~~ → fixed: copies every Tree A / B skill; Basic is already copied by Mimic (2026-10-01).

**Open questions (need a live check):**
1. Illusion Effect: whether HP / MP drained by a clone's `w_bat56` / `w_bat66` proc reaches the real Bat. `sID` is the clone (`Bat_illusion.cs:7565`, `:7589`); the card says the Bat receives it.
2. Illusion Effect: the tooltip says clones give SP back to the Bat; the code's `sp++` is on the clone's own character and is not gated by #401.

### Geometry notes (verified 2026-10-02)

- **Shadow Illusion spawn:** clone 1 at `getSpawnVector(Bat + up, TransformDirection(−1.5, −1, 2.6))`, clone 2 at `(+1.5, −1, 2.6)`, each passed through `getExpandPos(…, 1, 0.5)` (`Bat.cs:31511-31559`): 2.6 m in front, 1.5 m to each side.
- **Switch / Shadow Sacrifice:** no distance check; Switch picks an existing clone (`Bat.cs:7861-7951`, `RPC_switch` `:13272-13410`), Shadow Sacrifice drains every clone (`:14100-14350`).
- **Target spells:** the local cast switch (`Bat.cs:7000-9600`) has no distance gate besides Mirage Orb's 6 m spacing (`:9349`), so curses, Dream spells, Charm, Mimic, Dark Stalker, Soul Eater, Paranoia and Nefarious Whip reach the 40 m target lock ([12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md)). Nightmare and Mind Control check `sqrMagnitude > 1600` / `<= 1600` themselves (`:28939`, `:37491`).
- **Paranoia ally count:** `Hate.findFriends(target, 24, target.layer)` (`Bat.cs:14627`), a 24 m radius around the target (flat, no height limit); every living character found counts, the target included. Damage: `RPC_AddEffectDamage(434, Mathf.Clamp(num × 100, 100, 1000))` (`Bat.cs:14692`), so **100 minimum** (the target alone) and **1000 maximum** (10 or more).

## Server Balance Variations (ToT patch notes, 2026)

Source: ToT Facebook patch notes (C6 intro post, 03/08/2026, 10/09/2026, hot fix 12/09/2026; latest value wins), read 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tot`.

| Skill | ToT change |
|---|---|
| Mirage Orb | allies inside the orb take 4 / 6 / 8 / 10% less damage by rank (replaces the earlier "−0.1 hitMod" note) |
