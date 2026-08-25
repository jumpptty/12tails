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
| manaVortex | Mana Vortex | 3 | 120 | true | false | 60 | true |
| novaFlare | Nova Flare | 1 | 120 | true | false | — | — |
| meteora | Meteora | 2 | 300 | true | false | — | — |
| frozenBlast | Frozen Blast | 4 | 21 | true | false | — | — |
| arcticWind | Arctic Wind | 3 | 21 | true | false | — | — |
| iceShield | Ice Shield | 4 | 90 | true | false | 30 | true |
| iceBlock | Ice Block | 2 | 90 | true | false | 6 | true |
| snowMan | Snow Man | 2 | 90 | true | false | 10 (contested: 6/10) | true (Damage.getDebuff) |
| tornado | Tornado | 3 | 120 | true | false | 6 | true |
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
- `parallelShift` CD: the existing data-reference doc (`penguin-skill-damage-reference.md`) only
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
- **`manaVortex` and `tornado` grant a timed pet/summon whose own lifetime is now reported as Duration
  (corrected 2026-08-14, user request) — an earlier pass here had excluded object/summon lifetimes as
  out of the Duration column's scope, but the user confirmed they want the summoned object's own
  lifetime cited whenever one exists, same as this tool already does for Mole's mines/turrets and
  Rabbit's field effects, not just character-applied buff/debuff statuses.** `manaVortex`:
  `Penguin.cs:10513` — `manaVortex.create(sLv, this.mChar.chaAdjust(60), this.mChar.ActorNr)` inside
  `RPC_manaVortex_create` — the vortex object's own lifetime is `chaAdjust(60)`, flat across all 3 ranks
  (only `sLv` and `ActorNr` vary by rank/caster, not the lifetime argument). `tornado`:
  `Penguin.cs:32839` — inside `RPC_tornado_cast` (sLv 1-3), `this.$channelTime$26393 = Time.time +
  (float)this.mChar.chaAdjust(6);` — `chaAdjust(6)`, also flat across ranks. `typhoon` (tornado's
  target-locked evolved form, see the note above) reroutes into this same cast path rather than having
  an independent one, so it shares the identical `chaAdjust(6)` lifetime — confirmed by this same
  citation, not a separate one.
- **`iceBlock`'s Duration is corrected (2026-08-14, user request) to the placed block's own ground-
  lifetime, not the `"ice"` debuff it applies to whoever walks into it.** `Penguin.cs:10744` —
  `penguin_iceBlock.Init(this.mChar.chaAdjust(6) + 6, sLv, this.gameObject);` — this is a **compound**
  formula, `chaAdjust(6)` plus a flat `+6` applied *after* the CHA-scaling, not `chaAdjust(12)` — the
  lookup tool's `durPostAdd` field (added 2026-08-14) represents this shape generically now.
  `Penguin_iceBlock.cs:44,51` — `Init(int nLife, int nLv, GameObject nOwner)` sets
  `this.mLife = (int)((float)nLife + Time.time);`, checked in `Update()` (`:116`,
  `(float)this.mLife < Time.time`) to despawn the block once expired. The previously-cited
  `Penguin_iceBlock.cs:211` value (`RPC_AddStatus("ice", mLv, 2, 0, ...)`, a flat `2`) is a separate
  thing entirely — the freeze debuff applied to whichever character steps into the block, not the
  block's own lifespan.
- `manaBurn`'s `RPC_AddStatus("manaBurn", sLv, 1, nValue, ActorNr)` 3rd argument (`1`) is the same
  argument slot that `dispell`'s call uses for its non-duration magic-status tier value (see existing doc:
  "2nd arg is the magic-status TIER stripped... not a duration"). The existing doc never claims manaBurn
  has a duration, so this table treats it the same way: excluded, not guessed.
- **`frozenBlast` and `arcticWind` are excluded (corrected 2026-08-14 — user caught that both still
  showed a Duration after the enemy-applied-debuff exclusion rule was already established elsewhere
  this session).** Both apply `"ice"` via `RPC_AddStatus` on `$hitChar$` — the enemy hit by the attack,
  not the caster — `Penguin.cs:29536` (`frozenBlast`) and `:30647` (`arcticWind`):
  `this.$hitChar$26306.RPC_AddStatus("ice", sLv, this.$self_$26311.mChar.chaAdjust(3), 0, ActorNr);`.
  **Not CHA-contested** — `chaAdjust(3)` uses only the caster's own CHA, not `Damage.getDebuff(base,
  casterCha, targetCha)` — so the value itself is a stable, real, citable `chaAdjust(3)`; it's excluded
  purely because it lands on the wrong side of the cast for this column, same reasoning already applied
  to Cat's `grandCasinoArcade`/`moonBlade`/`moonStorm`/`deltaStrike` and Chameleon's `venomShock`/
  `rustyDecay`. `arcticWind`'s guaranteed/default proc is this same `ice` (`chaAdjust(3)`s) — a learned
  `arcticFrost1`(314, a separate passive skill, out of scope for this table) can redirect 20% of casts to
  `frost` (`chaAdjust(2)`s) instead, also enemy-applied, same exclusion reasoning.
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
- `iceShield` Duration: `Penguin.cs:31124` — `this.$mDuration$26350 = this.$self_$26356.mChar.chaAdjust(30);`, applied at `Penguin.cs:31146` — `RPC_AddStatus("iceShield", sLv, mDuration, mIceShieldHp, ActorNr)`
- `iceBlock` Duration (ground field-lifetime, not the on-hit `ice` debuff): `Penguin.cs:10744` — `penguin_iceBlock.Init(this.mChar.chaAdjust(6) + 6, sLv, this.gameObject);`, applied at `Penguin_iceBlock.cs:51` — `this.mLife = (int)((float)nLife + Time.time);`. Corrected 2026-08-14 (user request) — the previously-cited `Penguin_iceBlock.cs:211` value (flat `2`) is the `"ice"` debuff applied to whoever triggers the block, not how long the block itself sits on the ground; see the dedicated judgment-call note above for the `chaAdjust(6) + 6` compound formula.
- `frozenBlast`, `arcticWind`: excluded — the only citable value (`chaAdjust(3)`, `Penguin.cs:29536`/`:30647`) is the `"ice"` debuff applied to `$hitChar$`, the enemy hit by the attack, not the caster's own duration; see the dedicated judgment-call note above.
- `focusIntellect` Duration: `Penguin.cs:35867` — `RPC_AddStatus("focusIntellect", 5, this.$self_$26485.mChar.chaAdjust(6), ..., ActorNr)`
- `cosmicRift` Duration: `Penguin.cs:38793` — `RPC_AddStatus("cosmicRift", 5, this.$self_$26562.mChar.chaAdjust(12), 0, ActorNr)`
- `cosmicFriday` Duration: `Penguin.cs:39449` — `RPC_AddStatus("cosmicFriday", 5, 3, 0, this.$self_$26576.mChar.ActorNr)` (flat literal `3`, confirmed NOT `chaAdjust`-wrapped)
- `manaVortex` Duration (summon lifetime, not `RPC_AddStatus`): `Penguin.cs:10513` — `manaVortex.create(sLv, this.mChar.chaAdjust(60), this.mChar.ActorNr)`, inside `RPC_manaVortex_create` — see the dedicated judgment-call note above.
- `tornado` Duration (channel/track-window lifetime, not `RPC_AddStatus`): `Penguin.cs:32839` — `this.$channelTime$26393 = Time.time + (float)this.mChar.chaAdjust(6);`, inside `RPC_tornado_cast` — see the dedicated judgment-call note above.
