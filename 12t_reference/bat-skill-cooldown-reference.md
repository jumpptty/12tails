# Bat — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| nAttack | Normal Attack | 3 | 2 | false | true | — | — |
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
| mirageOrb | Mirage Orb | 4 | 30 | true | false | — | — |
| shadowIllusion | Shadow Illusion | 4 | 60 | true | false | — | — |
| blind | Blind | 2 | 30 | true | false | — | — |
| confusion | Confusion | 2 | 45 | true | false | — | — |
| hateTransfer | Hate Transfer | 2 | 60 | true | false | — | — |
| switch | Switch | 1 | 12 | true | false | — | — |
| swap | Swap | 1 | 30 | true | false | — | — |
| dreamDazzle | Dream Dazzle | 2 | 90 | true | false | — | — |
| phantasmBlast | Phantasm Blast | 2 | 90 | true | false | — | — |
| charm | Charm | 2 | 120 | true | false | — | — |
| mindControl | Mind Control | 2 | 120 | true | false | — | — |
| mimic | Mimic | 2 | 360 | true | false | — | — |
| shame | Shame | 1 | 60 | true | false | — | — |
| darkStalker | Dark Stalker | 1 | 120 | true | false | 999 | false |
| soulEater | Soul Eater | 1 | 150 | true | false | — | — |
| shadowSacrifice | Shadow Sacrifice | 1 | 120 | true | false | — | — |
| paranoia | Paranoia | 1 | 150 | true | false | — | — |
| shatteringDream | Shattering Dream | 1 | 130 | true | false | — | — |
| nefariousWhip | Nefarious Whip | 1 | 180 | true | false | — | — |
| blackServant | Black Servant | 1 | 180 | true | false | — | — |

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
- **`cAttack` excluded — no `addTimeOut`-based cooldown of its own.** Bat's charge attack is the
  "drainLife" ability (`doBeginCharge`/`doReleaseCharge`, `Bat.cs:10324`/`10588`). Its only cast-rate gate
  is a generic `this.mChar.actionTime + (float)1 > Time.time` check (`Bat.cs:10490`) — a flat 1s
  action-lockout shared by all actions, not a named `addTimeOut`/`isTimeOut` cooldown key. A repo-wide
  grep for `addTimeOut`/`isTimeOut` with `cAttack` in `Bat.cs` returns zero matches. This matches the
  precedent in the existing Penguin doc, where `pgn_cAttack1-4` are documented as "passive, charge-attack
  rank" with "No MP/SP/CD of their own." `bat_cAttack1/2/3` in `BatSkill.cs` are real cost-table entries
  (skill-point gated), but they gate *unlocking* charge-attack rank, not a cooldown — so `cAttack` has no
  row in this table.
- **`nAttack` included — unlike Penguin, Bat's normal-attack combo stages DO carry their own
  `addTimeOut("nAttack", …)` calls**, each a bare (non-`agiAdjust`-wrapped) literal:
  `RPC_nAttack1`/`RPC_nAttack2` set 1.5s (`Bat.cs:20367`, `Bat.cs:20659`), `RPC_nAttack3` (the deepest/
  max-rank combo stage, `bat_nAttack3` in `BatSkill.cs`) sets 2s (`Bat.cs:21074`). The table reports the
  max-rank (nAttack3) value, 2s, consistent with how every other multi-stage skill in this table reports
  its max-rank cast site. (A separate, unrelated `addTimeOut("nAttack", 1f)` exists at `Bat.cs:9861` inside
  a `Game.mGameCode == 967` branch — a special event-minigame mode, not the standard combat path — and is
  not used for this table.)
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
- **Passive/no-own-cast-site families excluded entirely** (confirmed via `BatSkill.cs`'s `getSkill()`: no
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
- `nAttack` CD: `Bat.cs:21074` — `this.$self_$19872.mChar.addTimeOut("nAttack", (float)2);` (max-rank/
  nAttack3 combo stage; bare literal, NOT `agiAdjust`-wrapped)
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
