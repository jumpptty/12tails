# Penguin — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| doubleCast | Double Cast | 1 | 240 | true | false | 12 | true |
| tripleCast | Triple Cast | 1 | 240 | true | false | 12 | true |
| manaMissile | Mana Missile | 4 | 16 | true | false | — | — |
| manaArc | Mana Arc | 4 | 1 | false | false | — | — |
| dispell | Dispell | 2 | 5 | true | false | — | — |
| blink | Blink | 2 | 12 | true | false | — | — |
| mpTransfer | MP Transfer | 2 | 30 | true | false | — | — |
| manaBurn | Mana Burn | 2 | 30 | true | false | — | — |
| fallingStars | Falling Stars | 2 | 30 | true | false | — | — |
| fallingComets | Falling Comets | 2 | 60 | true | false | — | — |
| manaVortex | Mana Vortex | 3 | 120 | true | false | — | — |
| novaFlare | Nova Flare | 1 | 120 | true | false | — | — |
| meteora | Meteora | 2 | 300 | true | false | — | — |
| frozenBlast | Frozen Blast | 4 | 21 | true | false | 3 | true |
| arcticWind | Arctic Wind | 3 | 21 | true | false | 3 | true |
| iceShield | Ice Shield | 4 | 90 | true | false | 30 | true |
| iceBlock | Ice Block | 2 | 90 | true | false | 2 | false |
| snowMan | Snow Man | 2 | 90 | true | false | — | — |
| tornado | Tornado | 3 | 120 | true | false | — | — |
| absoluteZero | Absolute Zero | 2 | 180 | true | false | — | — |
| blizzard | Blizzard | 2 | 240 | true | false | — | — |
| arcticEmperor | Arctic Emperor | 2 | 600 | true | false | — | — |
| focusIntellect | Focus Intellect | 1 | 120 | true | false | 6 | true |
| parallelShift | Parallel Shift | 1 | 30 | true | false | — | — |
| snowBall | Snow Ball | 1 | 120 | true | false | — | — |
| cosmicRift | Cosmic Rift | 1 | 180 | true | false | 12 | true |
| cosmicFriday | Cosmic Friday | 1 | 300 | true | false | 3 | false |

## Citations

### Notes on judgment calls (read before Tasks 2-12 reuse this schema)
- `parallelShift` CD: the existing data-reference doc (`2026-07-21-penguin-skill-data-reference.md`) only
  says "CD shares with blink" without a numeric value. Direct verification found parallelShift5's own
  cast site sets the shared `"blink"` cooldown key to `agiAdjust(30)`, not blink's own `agiAdjust(12)` —
  "shares with blink" means the two skills share the same cooldown-timer *key*, not the same *value*. The
  table above uses the source-verified 30, not blink's 12.
- `snowBall` CD: the existing doc's Class C section header lists `snowBall5`(433) as one of the tier's 3
  active (non-passive) skills, but the per-skill body text never states a CD value for it. Verified
  directly from `Penguin.cs`'s shared cast dispatcher (same mechanism backing every other Class B/C CD in
  this table) to fill the gap rather than drop an active skill from the table.
- `typhoon`(344) is excluded as its own row. Per the existing doc it's a passive unlock that reroutes an
  in-progress `tornado` cast when a locked enemy target exists — same cast button, same trained rank,
  identical CD formula to `tornado` (confirmed identical `mCastTime`/`mTimeOut` in the shared dispatcher).
  Not an independently castable skill, so not a separate lookup row.
- `manaVortex` and `tornado` grant a timed pet/summon (`chaAdjust(60)`s vortex lifetime, `chaAdjust(6)`s
  tornado track window) — excluded from the Duration columns because the task brief's Step 4 scopes
  Duration to a **buff/debuff duration** applied to a character, not an object/summon lifetime.
- `manaBurn`'s `RPC_AddStatus("manaBurn", sLv, 1, nValue, ActorNr)` 3rd argument (`1`) is the same
  argument slot that `dispell`'s call uses for its non-duration magic-status tier value (see existing doc:
  "2nd arg is the magic-status TIER stripped... not a duration"). The existing doc never claims manaBurn
  has a duration, so this table treats it the same way: excluded, not guessed.
- `arcticWind`'s guaranteed/default proc is `ice` (`chaAdjust(3)`s); its row uses that value. A learned
  `arcticFrost1`(314, a separate passive skill, out of scope for this table) can redirect 20% of casts to
  `frost` (`chaAdjust(2)`s) instead — a per-cast RNG branch on a *different* skill's unlock, not a second
  value for arcticWind's own row.
- `snowMan`, `absoluteZero`, `arcticEmperor`'s frost tick both use `Damage.getDebuff(base, casterCHA,
  targetCHA)` — target-contested — so both duration cells are `—` per the brief's contested-duration rule.
  `snowBall`'s duration is inherited from the target's existing (contested) `snowMan` remaining time, so
  it is likewise excluded rather than treated as a stable, independently-computable value.

### CD citations
- `doubleCast` CD: `Penguin.cs:9826` — `this.mChar.addTimeOut("doubleCast", this.mChar.agiAdjust((float)240))`
- `tripleCast` CD: `Penguin.cs:9829` — `this.mChar.addTimeOut("tripleCast", this.mChar.agiAdjust((float)240))` (shares the `doubleCast`/`tripleCast` cooldown pool per the existing doc)
- `manaMissile` CD: `Penguin.cs:19541` — `this.$mTimeOut$26059 = 8 + 2 * this.$sLv$26071;` (sLv4 → 16), wrapped at `Penguin.cs:19869` — `addTimeOut(this.$sType$26067, agiAdjust((float)this.$mTimeOut$26059))`
- `manaArc` CD: `Penguin.cs:21756` — `mChar.addTimeOut("manaArc", (float)1)` (bare literal, not agiAdjust-wrapped)
- `dispell` CD: `Penguin.cs:22280` — `addTimeOut("dispell", agiAdjust((float)(3 + this.$sLv$26117)))` (sLv2 → 5)
- `blink` CD: `Penguin.cs:23004` — `addTimeOut("blink", agiAdjust((float)12))`
- `mpTransfer` CD: `Penguin.cs:23624` — `addTimeOut("mpTransfer", agiAdjust((float)30))`
- `manaBurn` CD: `Penguin.cs:19563` — `this.$mTimeOut$26059 = 18 + 6 * this.$sLv$26071;` (sLv2 → 30), wrapped at `Penguin.cs:19869`
- `fallingStars` CD: `Penguin.cs:25330` — `addTimeOut("fallingStars", agiAdjust((float)30))`
- `fallingComets` CD: `Penguin.cs:19585` — `this.$mTimeOut$26059 = 60;`, wrapped at `Penguin.cs:19869`
- `manaVortex` CD: `Penguin.cs:19607` — `this.$mTimeOut$26059 = 120;`, wrapped at `Penguin.cs:19869`
- `novaFlare` CD: `Penguin.cs:27607` — `addTimeOut("novaFLare", agiAdjust((float)120))` (source cType string is `"novaFLare"`, capital-L; display name kept as "Nova Flare" per the existing doc)
- `meteora` CD: `Penguin.cs:19624` — `this.$mTimeOut$26059 = 300;`, wrapped at `Penguin.cs:19869`
- `frozenBlast` CD: `Penguin.cs:19641` — `this.$mTimeOut$26059 = 9 + 3 * this.$sLv$26071;` (sLv4 → 21), wrapped at `Penguin.cs:19869`
- `arcticWind` CD: `Penguin.cs:19663` — `this.$mTimeOut$26059 = 12 + 3 * this.$sLv$26071;` (sLv3 → 21), wrapped at `Penguin.cs:19869`
- `iceShield` CD: `Penguin.cs:19685` — `this.$mTimeOut$26059 = 30 + 15 * this.$sLv$26071;` (sLv4 → 90), wrapped at `Penguin.cs:19869`
- `iceBlock` CD: `Penguin.cs:19702` — `this.$mTimeOut$26059 = 90;`, wrapped at `Penguin.cs:19869`
- `snowMan` CD: `Penguin.cs:19724` — `this.$mTimeOut$26059 = 90;`, wrapped at `Penguin.cs:19869`
- `tornado` CD: `Penguin.cs:19741` — `this.$mTimeOut$26059 = 120;`, wrapped at `Penguin.cs:19869`
- `absoluteZero` CD: `Penguin.cs:19775` — `this.$mTimeOut$26059 = 180;`, wrapped at `Penguin.cs:19869`
- `blizzard` CD: `Penguin.cs:19792` — `this.$mTimeOut$26059 = 240;`, wrapped at `Penguin.cs:19869`
- `arcticEmperor` CD: `Penguin.cs:35147` — `addTimeOut("arcticEmperor", agiAdjust((float)600))` (own dedicated call, not routed through the shared dispatcher — matches the existing doc's note)
- `focusIntellect` CD: `Penguin.cs:35939` — `addTimeOut("focusIntellect", agiAdjust((float)120))`
- `parallelShift` CD: `Penguin.cs:36824` — `addTimeOut("blink", agiAdjust((float)30))` (see judgment-call note above)
- `snowBall` CD: `Penguin.cs:19809` — `this.$mTimeOut$26059 = 120;`, wrapped at `Penguin.cs:19869` (see judgment-call note above)
- `cosmicRift` CD: `Penguin.cs:19831` — `this.$mTimeOut$26059 = 180;`, wrapped at `Penguin.cs:19869`
- `cosmicFriday` CD: `Penguin.cs:19853` — `this.$mTimeOut$26059 = 300;`, wrapped at `Penguin.cs:19869`

### Duration citations
- `doubleCast`/`tripleCast` Duration: `Penguin.cs:9862` — `RPC_AddStatus("multiCast", sLv, this.mChar.chaAdjust(12), 0, this.mChar.ActorNr)` (self-buff, not target-contested)
- `frozenBlast` Duration: `Penguin.cs:29536` — `RPC_AddStatus("ice", this.$sLv$26310, this.$self_$26311.mChar.chaAdjust(3), 0, ...)` (not contested — `chaAdjust` uses only the caster's own CHA)
- `arcticWind` Duration: `Penguin.cs:30647` — `RPC_AddStatus("ice", this.$sLv$26340, this.$self_$26341.mChar.chaAdjust(3), 0, ...)` (default/guaranteed proc; see judgment-call note re: `arcticFrost1`)
- `iceShield` Duration: `Penguin.cs:31124` — `this.$mDuration$26350 = this.$self_$26356.mChar.chaAdjust(30);`, applied at `Penguin.cs:31146` — `RPC_AddStatus("iceShield", sLv, mDuration, mIceShieldHp, ActorNr)`
- `iceBlock` Duration: `Penguin_iceBlock.cs:211` — `characterControl.RPC_AddStatus("ice", this.mLv, 2, 0, this.FfDfs0XLxG.ActorNr)` (flat literal `2`, confirmed NOT `chaAdjust`-wrapped)
- `focusIntellect` Duration: `Penguin.cs:35867` — `RPC_AddStatus("focusIntellect", 5, this.$self_$26485.mChar.chaAdjust(6), ..., ActorNr)`
- `cosmicRift` Duration: `Penguin.cs:38793` — `RPC_AddStatus("cosmicRift", 5, this.$self_$26562.mChar.chaAdjust(12), 0, ActorNr)`
- `cosmicFriday` Duration: `Penguin.cs:39449` — `RPC_AddStatus("cosmicFriday", 5, 3, 0, this.$self_$26576.mChar.ActorNr)` (flat literal `3`, confirmed NOT `chaAdjust`-wrapped)
