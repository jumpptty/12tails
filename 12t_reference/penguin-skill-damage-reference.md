# Penguin Skill Data Reference

Consolidated extraction from `Penguin.cs`, `PenguinSkill.cs`, `PenguinSkill_eng.cs`,
`CharacterControl.cs`, `CharacterDataClass.cs`, `GameGui.cs`, and companion files
(`Penguin_manaMissile.cs`, `Penguin_iceBlock.cs`, `Penguin_snowMan.cs`,
`Penguin_tornado.cs`, `Penguin_typhoon.cs`, `Penguin_arcticEmperor.cs`,
`Penguin_snowBall.cs`, `Penguin_cosmicFriday.cs`, `ManaVortex.cs`). This is the
source-of-truth data used to populate the `SKILLS` JS object for the interactive
sheet — see the design spec (`2026-07-21-penguin-interactive-infographic-design.md`)
and implementation plan for how it's consumed.

Global mechanics referenced throughout:
- `agiAdjust(base) = base × 128/(AGI+128)`, further `×0.88` if `hasSkill(424)` ("revisedArt5") — 424 excludes nAttack/cAttack/emoticon/consumable-item cooldowns.
- `magAdjust(base)` — cast-time reduction from INT (displayed as INT↓).
- `chaAdjust(v) = v × (1+0.015×CHA)` — buff/debuff duration.
- `talAdjust(n) = n + 0.02n×TAL`.
- `lckAdjust(n)` — diminishing-returns % curve.
- `focusIntellect` buff (from `pgn_focusIntellect5`, 421): consumed once by the caster's next damage spell as ×(1+0.01×(INT-100)), then removed.
- `multiCast` status: granted by `doubleCast1`(sLv1)/`tripleCast2`(sLv2) (Basic tier) and by a 12% `lckAdjust` roll on **blink** casts once `doubleSpell5` (431) is learned (NOT "any spell" despite tooltip). Consumed 1 stack per subsequent cast of a `isDoubleSpell`-flagged skill (manaMissile, manaVortex-family exceptions apply — see below), firing one free extra cast. `iceBlock` uses a different multiplicative model (`mBlockCount = sLv + sLv×multiCastLv`, single-shot consumption).
- Global Class C economy passives (apply to EVERY other active skill, not tier-scoped): `revisedSkill5` (404) = 50% SP cost reduction on cast; `revisedMagic5` (414) = 20% MP cost reduction on cast; `revisedArt5` (424) = 12% cooldown reduction (excludes basic attacks/consumables).
- No skill in the entire class has a coded cast-range gate (no "Target too far" check anywhere in Penguin.cs) — every targeted skill is `Range: Locked-on`; self/AoE-anchored skills are `Range: none` (radius stated separately, not as a Range chip).

---

## BASIC (1xx)

### pgn_nAttack1 (101) / pgn_nAttack2 (102) — passive, combo unlockers
- No MP/SP/CD of their own. nAttack1 unlocks combo hit 2, nAttack2 unlocks hit 3.
- All 3 combo stages share ONE damage formula: `hit(1, target, 0.5×ATK, 1, 0, 0.3×forward)` — no per-stage scaling.
- `hasSkill(401)` ("spreadShot5", Class C): 20% chance (hits 1-2) / 40% chance (hit 3, `lckAdjust`) to fire 3 spread projectiles instead of one.

### pgn_cAttack1-4 (111/112/113/114) — passive, charge-attack rank
- Gates `getChargeAttackLv()` = 1/2/3/4 (highest rank wins, not additive).
- Channel tick (every 1s while holding): `MP = clamp(⌈0.03×chargeLv×ATK⌉, chargeLv×3, chargeLv×6)`. **No direct damage on release ever** — pure MP-channel utility, confirmed no `hit()` call anywhere in the release coroutine.
- `hasSkill(411)` ("manaField5", Class C): adds `+chargeLv` to the MP tick and shares MP with allies in 8m radius.

### pgn_Intellect1-4 (121/122/123/124) — passive, +INT
- Each rank: **+10 INT, +30 current MP, +30 max MP** (tooltip only mentions +10 INT — the MP bonus is undocumented but confirmed at 3 separate code sites). All 4 ranks: +40 INT, +120 MP/+120 max MP.

### pgn_doubleCast1 (131) — active
- reqLv 32, MP 20, SP -20 (red), instant, cType "doubleCast"
- CD: `agiAdjust(240)` — **shared cooldown pool with tripleCast2** (casting either puts both on CD).
- Grants self status `multiCast` sLv=1, duration `chaAdjust(12)`s. Next qualifying spell cast fires twice (1 extra cast).
- No range (self-target, no distance check).

### pgn_tripleCast2 (132) — active
- reqLv 40, MP 40, SP -30 (red), instant, cType "tripleCast"
- CD: shared `agiAdjust(240)` pool with doubleCast1.
- Grants self status `multiCast` sLv=2, duration `chaAdjust(12)`s. Consumed 1 level per subsequent qualifying cast — practically "next 2 qualifying casts each fire twice" (up to 2 separate button-presses within the buff window), NOT one spell firing 3× in a single press despite tooltip wording. Using either doubleCast1/tripleCast2 overwrites (doesn't stack with) the other's pending buff.
- iceBlock exception: reads `multiCast` level as a direct multiplier (`sLv×3` for tripleCast2), not decrement-per-cast.

### pgn_statPlus1-4 (141/142/143/144) — passive, generic
- Each rank: flat **+2 to every basic stat** (class-generic mechanism, no hidden bonus, verified clean). All 4 ranks: +8 all stats.

---

## CLASS A (2xx)

### pgn_manaMissile1-4 (201-204) — active, RANK FAMILY
- reqLv 3/11/19/27, MP 9/15/21/27, SP 0, mode target, cType manaMissile
- CD: `agiAdjust(8+2×sLv)` → 10/12/14/16s. ×0.88 with revisedArt5.
- Cast: `magAdjust(1+sLv)` → 2/3/4/5s (NOT instant despite decoder mode).
- Damage per missile: `talAdjust(3×sLv+12) × (1+0.01×focusIntellect) + (hasSkill(402)?0.1×charLv:0)`. Missile count `sLv+1` (2/3/4/5), +2 more with `moreMissile5`(402). KO 1, Hate 0.
- Range: Locked-on. `isDoubleSpell=true` (multiCast-eligible).
- Class C mods: `moreMissile5`(402) adds +2 missiles and `+0.1×charLv` per-missile damage (tooltip says flat "+6," code is level-scaled).

### pgn_manaArc1-4 (211-214) — active, RANK FAMILY
- reqLv 5/13/21/29, MP 6/12/18/24, SP -4/-6/-8/-10 (red), mode instant, cType manaArc
- CD: flat `agiAdjust(1)` (unusually NOT sLv-scaled — confirmed no agiAdjust wrapper variance). ×0.88 with revisedArt5.
- Cast: instant.
- Damage: `talAdjust(10×sLv) × (1+0.01×focusIntellect) + (hasSkill(412)?0.5×charLv:0)` → base 10/20/30/40 (matches tooltip). KO 0, Hate 0.
- Range: AoE radius 3m/height 3m, self-centered. No cast-range gate.
- Class C mods: `penguinOfArc5`(412) adds `+0.5×charLv` damage (tooltip says "+level," code is half that) plus a cosmetic VFX swap.

### pgn_dispell1/2 (221/223) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 7/23, MP 14/22, SP 0, mode instant, cType dispell
- CD: `agiAdjust(3+sLv)` → 4s/5s. ×0.88 with revisedArt5.
- Cast: instant.
- No damage. Applies `RPC_AddStatus("dispell", 2×sLv+(hasSkill(422)?1:0), 1, 0)` to everyone in AoE — 2nd arg is the magic-status TIER stripped (matches tooltip lv.2/lv.4), not a duration.
- Range: AoE radius `5×rangeMod`/height `3×rangeMod`, self-centered.
- Side effect: also destroys mirageOrb/skyOrb items within 6m (undocumented).
- Class C mods: `parallelShift5`(422) adds +1 to dispell level.

### pgn_blink1/2 (222/224) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 15/31, MP 5/5, SP -10/-15 (red), mode instant, cType blink
- CD: flat `agiAdjust(12)` both ranks. ×0.88 with revisedArt5.
- Cast: instant.
- No damage. Teleport distance `3×sLv+2` = 5m/8m (matches tooltip). Removes `lockStatus` level ≤ `2×sLv`. Ignores collision along a forward cone (base3/top3/length6/height2) during the move.
- Range: n/a (self-movement, not a targeted skill).
- `isDoubleSpell=true` (multiCast-eligible — a full second teleport).
- **doubleSpell5(431)'s 12% multiCast-grant roll specifically triggers off blink casts**, not universally.

### pgn_mpTransfer1/2 (231/233) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 9/25, MP 30/60, SP 0, mode target, cType mpTransfer
- CD: flat `agiAdjust(30)` both ranks. ×0.88 with revisedArt5.
- Cast: effectively instant (no dispatcher cast-time entry).
- No damage — heal-style ally MP transfer: `amount = 30×sLv + ⌊0.1×casterMaxMP⌋ + (hasSkill(432)?⌊0.5×charLv⌋:0)` → 30+10%mmp / 60+10%mmp (matches tooltip).
- Range: Locked-on.
- Class C mods: `manaSurge5`(432) adds `+⌊0.5×charLv⌋` bonus heal (fully undocumented in tooltip).

### pgn_manaBurn1/2 (232/234) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 17/33, MP 15/30, SP 0, mode target, cType manaBurn
- CD: `agiAdjust(18+6×sLv)` → 24s/30s. ×0.88 with revisedArt5.
- Cast: `magAdjust(2+sLv)` → 3s/4s.
- Status-based, not direct hit: `RPC_AddStatus("manaBurn", sLv, 1, nValue)` where `nValue = 20×sLv+5` (→25/45, matches tooltip) — on consumption, drains target MP by `nValue` then deals damage = `defAdjust(% of max MP now missing)`.
- Range: Locked-on.
- Class C mods: `manaSurge5`(432) — same passive as mpTransfer — adds `sLv+=2` (status-level bump) and `+⌊0.1×casterMP⌋` to `nValue`. **manaSurge5 secretly buffs both manaBurn AND mpTransfer simultaneously.**

### pgn_fallingStars1/2 (241/242) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 12/20, MP 20/30, SP -10/-15 (red), mode instant, cType fallingStars
- CD: flat `agiAdjust(30)` both ranks. ×0.88 with revisedArt5.
- Cast: instant (own dedicated coroutine).
- Per-star damage: `talAdjust(15+15×sLv) × (1+0.01×focusIntellect)` → sLv1=30 (matches tooltip), **sLv2=45 (tooltip claims 40 — code wins, tooltip is stale)**. Delivered via secondary 2m-radius/4m-height impact burst per star.
- Range: AoE radius `(hasSkill(442)?1.5:1)×(8+sLv×4)` → 12m/16m (matches tooltip), height 6m, self-centered. Target cap 5 (10 with giantStar5).
- Has its own inline 12% multiCast-grant roll if doubleSpell5 learned (coded locally, not via shared dispatcher).
- Class C mods: `giantStar5`(442) — ×1.5 targeting radius (undocumented: ALSO doubles target cap 5→10, and bumps per-star explosion radius 2m→3m, undocumented), swaps to `RPC_giantStars_fire` entirely, ×1.25 damage (matches tooltip).

### pgn_fallingComets1/2 (243/244) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 28/36, MP 35/50, SP 0, mode target, cType fallingComets
- CD: shared dispatcher, flat `agiAdjust(60)`. `isDoubleSpell=true`. ×0.88 with revisedArt5.
- Cast: `magAdjust(2+4×sLv)` → 6s/10s.
- Per-comet center damage: `talAdjust(15+15×sLv)×(1+0.01×focusIntellect)` → 30/45, with linear falloff `1-0.5×(dist/6)` (100%→50% at 6m edge). Comet count `2+sLv×3` → 5/8 comets, scattered randomly within ±8m of locked target, each own 6m-radius/4m-height impact.
- Range: Locked-on (initial target), then random ±8m scatter for landing points.
- Class C mods: `giantStar5`(442) swaps to `RPC_giantComets_fire`, ±8m→±10m scatter (undocumented), explosion radius 6m→9m (+50%, matches tooltip), ×1.25 damage (matches tooltip).

### pgn_manaVortex1-3 (251/252/253) — active, RANK FAMILY
- reqLv 17/24/31, MP 40/55/70, SP 0, mode instant, cType manaVortex
- CD: shared dispatcher, flat `agiAdjust(120)` all 3 ranks. ×0.88 with revisedArt5. **NOT `isDoubleSpell`** — no multiCast interaction.
- Cast: `magAdjust(3+2×sLv)` → 5s/7s/9s.
- Not a direct hit — spawns a `ManaVortex` pet: HP `200×sLv`, max MP `100×sLv`, lifetime `chaAdjust(60)`s. Every 2s ticks: AoE radius `12+4×sLv` (16/20/24m) around ITS OWN position, `hit(1,...,sLv×12+12,...)` flat (24/36/48, no TAL/focusIntellect scaling), applies `mpSap` to hit targets with MP>`sLv×4`, heals itself `sLv×4` MP per such hit.
- Range: spawn position ~5m in front of caster; vortex itself is an independently-positioned, independently-killable summon.
- **Feeds directly into novaFlare1** (see below) — mechanically one combo, not two separate nukes.

### pgn_novaFlare1 (254) — active
- reqLv 38, MP 0, SP -30 (red), mode instant, cType novaFlare (internal cType string "novaFLare")
- CD: `agiAdjust(120)`. ×0.88 with revisedArt5.
- Cast: instant.
- **Detonates the caster's own active manaVortex** (no target of its own): damage = `0.5×vortex.HP + vortex.MP`, in AoE radius = vortex's own tick radius (`12+4×vortexLv`), then destroys the vortex and refunds the vortex's stored MP to caster (refund gated on `hasSkill(254)` i.e. itself being learned).
- **Whiff case**: if no active manaVortex exists, the skill still goes on CD and spends its SP, but deals zero damage — worth surfacing explicitly on the card.
- Vortex's natural timer-expiry death ALSO refunds MP (if novaFlare1 learned) but without the AoE burst.
- Range: n/a (acts on tracked vortex reference, not distance-based).

### pgn_astralTalent1-4 (261-264) — passive, RANK FAMILY
- Each rank: **+10 TAL, +2 max SP** (tooltip only says "+10 talent" — the +2 SP is undocumented and stacks ON TOP of the SP the +10 TAL itself yields via the game's TAL/5 formula). All 4 ranks: +40 TAL, +8 max SP (flat bonus, separate from TAL-derived SP).

### pgn_meteora1/2 (271/272) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 35/40, MP 120/160, SP -35/-45 (red), mode target, cType meteora
- CD: shared dispatcher, flat `agiAdjust(300)`. NOT doubleSpell-eligible. ×0.88 with revisedArt5.
- Cast: `magAdjust(6+6×sLv)` → 12s/18s.
- Damage: AoE radius `6+sLv×3` (9m/12m), height 6m, at locked target's landing position. `hitDmg = talAdjust(200+150×sLv)×(1+0.01×focusIntellect)` → 350/500. KO 0, Hate 0.
- Range: Locked-on (target position = landing point), impact AoE as above.

---

## CLASS B (3xx)

Shared dispatcher note: most Class B skills route cooldown/cast-time through the same `RPC_cast1` shared dispatcher as Class A. `isDoubleSpell=true` for: frozenBlast, arcticWind, iceBlock only (of this tier's skills).

### pgn_frozenBlast1-4 (301-304) — active, RANK FAMILY
- reqLv 3/11/19/27, MP 12/16/20/24, SP 0, mode target/enemy, cType frozenBlast
- CD: `9+3×sLv` base → 21s at max. ×0.88 with revisedArt5.
- Cast: flat `magAdjust(3)` all ranks.
- Damage: `talAdjust(sLv×12+18)×(1+0.01×focusIntellect)`, falloff-scaled by distance (`1-0.5×clamp(dist/hitRange,0,1)`). KO 1, Hate 0. On hit: +1 SP to caster.
- Applies `ice` status (slow, `moveMod -= 0.1+0.1×sLv`) level sLv, duration `chaAdjust(3)`.
- Range: AoE radius `2+sLv+(hasSkill(403)?2:0)` (6m→8m at max with frozenBreak5), self-centered, no cast-range gate, no target-lock required.
- Class C mods: `frozenBreak5`(403) — +2m radius, and if target already has `ice`, bonus defense-ignoring `RPC_AddEffectDamage(403, 15×iceLv)` "Frozen Break!" burst.
- `isDoubleSpell=true`.

### pgn_arcticWind1-3 (311-313) — active, RANK FAMILY
- reqLv 5/13/21, MP 20/26/32, SP 0, mode instant/enemy, cType arcticWind
- CD: `12+3×sLv` → 21s at sLv3. ×0.88 with revisedArt5.
- Cast: `1.5+0.5×sLv` → 3.0s at sLv3.
- Damage per tick: `talAdjust(sLv×10+5)×(1+0.01×focusIntellect)`. KO 1, Hate 0. Fired as 4 sequential ticks (8 with `deadlyFrost5`/413) walking forward, each a trapezoid (base2/top2.5/range4/height3). +1 SP to caster per hit.
- Status: normally applies `ice` (sLv level, `chaAdjust(3)`s) on hit; **if `arcticFrost1`(314) is learned, 20% (`lckAdjust`) chance instead applies `frost`** (level 1, `chaAdjust(2)`s, purely cosmetic — NO slow effect, confirmed no moveMod entry) INSTEAD of ice — reads as a downgrade on that roll, not an upgrade, verified directly in code.
- Range: shaped AoE (4-8 sequential trapezoid segments), no cast-range gate, no target-lock required.
- Class C mods: `deadlyFrost5`(413) doubles segment count 4→8 (matches tooltip "+100% range"); if target has `frost`, bonus flat defense-ignoring `RPC_AddEffectDamage(413, 50)` "Deadly Frost!" burst.
- `isDoubleSpell=true`.

### pgn_arcticFrost1 (314) — passive
- reqLv 29. Sole effect: enables the 20% `frost`-instead-of-`ice` roll on arcticWind hits (see above) — this is its entire coded effect, nothing else found. Reads as a downgrade (2s no-slow vs 3s slow), reported as coded.

### pgn_iceShield1-4 (321-324) — active, RANK FAMILY
- reqLv 7/15/23/31, MP 15/23/31/39, SP 0, mode target/ally, cType iceShield
- CD: `30+15×sLv` → 90s at max. ×0.88 with revisedArt5.
- Cast: `3+0.5×sLv` → 5.0s at max.
- No damage — ally shield buff. Duration `chaAdjust(30)` flat (not rank-scaled). Shield HP payload: `talAdjust(10+sLv×20)×(1+0.01×focusIntellect) + (hasSkill(423)?charLv:0)` → base 90 at max rank. **Confirmed genuinely consumed** as 1:1 damage absorb in the shared damage pipeline (not dead data) — depletes and auto-removes.
- Range: Locked-on (ally target), no AoE.
- NOT doubleSpell-eligible.
- Class C mods: `frostSpike5`(423) adds `+charLv` flat shield HP, AND separately gives a 12% chance on full-absorb to AoE-apply `frost` (5m radius, `chaAdjust(2)`s) to nearby enemies (undocumented secondary effect, found via `CharacterControl.cs`).

### pgn_iceBlock1/2 (331/333) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 9/25, MP 10/15, SP 0, mode instant/self (but NOT actually a self-buff — see mechanic), cType iceBlock
- CD: flat `90` both ranks (not sLv-scaled). ×0.88 with revisedArt5.
- Cast: `1+sLv` → 2s/3s.
- No direct hit. Fires `mBlockCount+1` ground ice-zones in a row (`mBlockCount = sLv+sLv×multiCastLv`), raycast-placed within 12m below caster's front, each zone `Init(mLife=chaAdjust(6)+6, mLv=sLv)`.
- Each zone: persists `chaAdjust(6)+6`s, ticks 1s, applies `ice` status (level sLv, duration flat 2s — NOT chaAdjust-scaled) to enemies within radius `6+3×mLv` (12m at rank2) lacking `ice` already.
- Range: no cast-range gate; placement bounded by 12m downward raycast near caster.
- `isDoubleSpell=true` — AND multiCast stacks directly multiply `mBlockCount` (different consumption model than other doubleSpell skills).

### pgn_snowMan1/2 (332/334) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 17/33, MP 20/27, SP 0, mode target/enemy, cType snowMan
- CD: flat `90` both ranks. ×0.88 with revisedArt5.
- Cast: `2+2×sLv` → 4s/6s.
- No direct damage from cast. Applies `snowMan` status: level sLv, duration `Damage.getDebuff(2+4×sLv, casterCHA, targetCHA)` (contested), shield payload `talAdjust(sLv×50)` (base 100 at rank2).
- **Simultaneously hard CC (target frozen in place, disarmed, model swapped to a literal snowman, all renderers disabled, immune to further blend/invis/paralysis/sleep/mindControl while active) AND a depletable damage shield** (1:1 absorb, confirmed via CharacterControl.cs, breaking removes the CC too). Mutually exclusive with charm/mindControl/nightmare; blocked by petrify; removed by fireAvatar.
- Range: Locked-on. NOT doubleSpell-eligible.

### pgn_tornado1-3 (341-343) — active, RANK FAMILY
- reqLv 12/20/28, MP 36/48/60, SP 0, mode instant/enemy, cType tornado
- CD: flat `120` all ranks. ×0.88 with revisedArt5.
- Cast (initial summon animation): `2+2×sLv` → 8.0s at sLv3. Then a separate channel/track window of `chaAdjust(6)`s before auto-destroy.
- Summons a mobile, player-steerable rigidbody pet: tick every 0.35s, AoE radius = `sLv` (1-3m), height 4m, damage per tick `talAdjust(10×sLv)×(1+0.01×focusIntellect)`. Velocity cap 30 (40 with `iceTwister5`/443). Auto-recentered if it strays >30m from caster.
- Range: no cast-range gate; AoE radius = sLv at the tornado's current (steerable) position, re-evaluated every tick.
- **If an enemy target is locked AND `typhoon1`(344) is learned, casting "tornado" redirects into casting typhoon instead** — tornado only fires when no valid locked enemy exists, or typhoon isn't learned.
- Class C mods: `iceTwister5`(443) — 9% chance per tick to apply `frost` (undocumented beyond "9% chance"), AND separately raises velocity cap 30→40 (fully undocumented "faster" effect) — applies to BOTH tornado and typhoon.
- +1 SP per hit. NOT doubleSpell-eligible.

### pgn_typhoon1 (344) — passive UNLOCK (decoder says "passive" but functionally reroutes an active cast — not literally passive-only)
- reqLv 36. No own MP/SP/CD — inherits tornado's dispatcher slot under `sType=="typhoon"` (same cast-time/cooldown formulas as tornado at whatever sLv is currently trained).
- Per-tick damage: identical formula to tornado (`talAdjust(sLv×10)×(1+0.01×focusIntellect)`) — NOT stronger per-tick.
- Mechanic: when tornado is cast onto a locked enemy target, becomes a target-orbiting summon (vs tornado's free-roam) with its OWN HP pool: `talAdjust(sLv×100)×(1+0.01×focusIntellect)`, decremented by its own damage output — functionally self-limits total lifetime damage to its own HP regardless of the timer. Same `chaAdjust(6)`s lifetime cap, same 0.35s tick, same iceTwister5 frost-proc/speed-boost as tornado.
- Companion file confirmed genuinely separate summon type (`Penguin_typhoon.cs`, not a `Penguin_tornado.cs` reskin) — distinct HP pool and target-locked-orbit behavior is the real differentiator, not raw damage.
- Range: Locked-on (requires resolved enemy target to trigger at all).

### pgn_frostBite1-4 (351-354) — passive, **CONFIRMED DEAD CODE**
- `getFrostBiteLv()` is computed but its only call site (inside arcticWind_fire) never reads the result afterward. Zero mechanical effect anywhere in the codebase, verified via exhaustive grep. Not a DoT/poison system — flag on the sheet as "no coded effect found" rather than inventing one; note this may be server-side or simply unwired.

### pgn_absoluteZero1/2 (361/362) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 22/28, MP 35/50, SP 30/40 (**positive → BLUE, gate-only, never deducted**), mode target/enemy, cType absoluteZero
- CD: flat `180` both ranks. ×0.88 with revisedArt5.
- Cast: `4+2×sLv` → 8.0s at sLv2.
- Damage: `talAdjust(sLv×40+55)×(1+0.01×focusIntellect)`. KO `10×sLv` (20 at max). Hate 0. Single-target only, no AoE.
- Applies `ice` level `sLv×2` (level 4 at max), duration `Damage.getDebuff(12, casterCHA, targetCHA)` (contested).
- Range: Locked-on only, no AoE. +1 SP to caster on hit (separate from blue-gate SP).
- No hasSkill() gates found — no Class C interaction.

### pgn_blizzard1/2 (363/364) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 34/40, MP 65/90, SP 0, mode target/all, cType blizzard
- CD: flat `240` both ranks. ×0.88 with revisedArt5.
- Cast: `6+3×sLv` → 12.0s at sLv2.
- Damage per tick: `talAdjust(sLv×20+20)×(1+0.01×focusIntellect)`. KO 0, Hate 0. **The locked target itself is explicitly excluded from every tick** — damages everyone else near the target, not the target itself. 6 ticks, 1s apart (6s total).
- No status applied — pure repeated AoE damage.
- Range: Locked-on (establishes storm center), AoE radius `6+3×sLv` (12m at max) around that center — radius is not a cast range, storm centers ON the target but excludes them.
- No hasSkill() gates found.

### pgn_arcticEmperor1/2 (371/372) — active, RANK FAMILY (sLv1/sLv2)
- reqLv 35/40, MP 60/80, SP 25/35 (**negative → RED, spent on cast**), mode instant/enemy, cType arcticEmperor
- CD: `agiAdjust(600)` — own dedicated `addTimeOut` call, NOT routed through shared dispatcher.
- Cast: instant (no castTime variable at all — animation plays but no commitment-window gate).
- **Two-phase mechanic, bundled in one skill** (companion file `Penguin_arcticEmperor.cs` is confirmed pure cosmetic VFX, zero gameplay logic):
  - Ticks 0-7 (8 ticks, 1s apart): self-centered AoE radius 8m/height 6m, applies `frost` status (level 1, `getDebuff(3,...)`s) to everyone caught — **no damage during these 8 ticks.**
  - Final tick: same AoE zone, deals burst damage `talAdjust(60+60×sLv)×(1+0.01×focusIntellect)` (180 at sLv2) to everyone in zone, KO 0, Hate 0, AND simultaneously strips `frost` from every target hit.
- Range: self-centered AoE radius 8m/height 6m (not sLv-scaled), no cast-range gate, no target-lock required — hits everyone in zone regardless of prior lock, filtered only by faction layer.
- No hasSkill() gates found.

---

## CLASS C (4xx) — all level-5 mastery passives (except snowBall5/433, cosmicRift5/434, cosmicFriday5/444 which are actives)

### pgn_spreadShot5 (401) — modifies Normal Attack
- 20% chance (combo hits 1-2) / 40% chance (hit 3 finisher, `lckAdjust`) to fire 3 spread projectiles (±15°/0°) instead of 1, each dealing normal attack damage. Tooltip's flat "40%" undersells hits 1-2.

### pgn_moreMissile5 (402) — modifies manaMissile
- +2 missile count (5→7 at max rank). +`0.1×charLv` per-missile damage (tooltip says flat "+6" — code is level-scaled, only equals 6 at level 60).

### pgn_frozenBreak5 (403) — modifies frozenBlast
- +2m AoE radius. If target has `ice`: bonus defense-ignoring `RPC_AddEffectDamage(403, 15×iceLv)` "Frozen Break!" burst. Matches tooltip.

### pgn_revisedSkill5 (404) — GLOBAL: 50% SP cost reduction on cast, for every active skill class-wide (via GameGui.cs's shared dispatch, not a Penguin.cs hasSkill check).

### pgn_manaField5 (411) — modifies Charge Attack
- +chargeLv to the MP-channel tick. Also shares MP with allies within 8m radius (flat `chargeLv` MP heal each). Matches tooltip.

### pgn_penguinOfArc5 (412) — modifies manaArc
- +`0.5×charLv` damage (tooltip says "+level" — code is half). Cosmetic VFX swap, no other mechanic.

### pgn_deadlyFrost5 (413) — modifies arcticWind
- Doubles segment count 4→8 (matches "+100% range"). If target has `frost`: bonus flat defense-ignoring `RPC_AddEffectDamage(413, 50)` "Deadly Frost!" burst.

### pgn_revisedMagic5 (414) — GLOBAL: 20% MP cost reduction on cast, for every active skill class-wide (via GameGui.cs's shared dispatch). Also reduces cosmicFriday5's own channel-tick MP drain 25→20 consistently.

### pgn_focusIntellect5 (421) — active
- reqLv 70, MP 30, SP -75 (red), instant, self. CD `agiAdjust(120)`.
- Self-buff: `focusIntellect` status, sLv5, duration `chaAdjust(6)`s, value = INT-100. Consumed by caster's next damage spell as ×(1+0.01×(INT-100)), then removed.
- **Undocumented secondary effect**: while learned, ALL incoming debuff-status durations against this Penguin are reduced 25% (`sTime = ⌈0.75×sTime⌉`) — zero tooltip mention, found only via cross-file grep.

### pgn_parallelShift5 (422) — active
- reqLv 70, MP 10, SP -20 (red), instant, self, cType "blink". CD shares with blink.
- Warps caster forward, removes lv.5 lock-status from self AND every player character (any faction) within 6m.
- Also: dispell's applied level becomes `2×sLv+1` instead of `2×sLv` (matches tooltip "+1 to dispell level").

### pgn_frostSpike5 (423) — modifies iceShield
- +charLv flat shield HP (matches tooltip). Secondary: 12% chance on full shield-absorb to AoE-apply `frost` (5m radius, `chaAdjust(2)`s) to nearby enemies — matches tooltip's "chance to unleash a freezing wind when hit."

### pgn_revisedArt5 (424) — GLOBAL: 12% cooldown reduction (`×0.88`) on every active skill's cooldown EXCEPT nAttack/cAttack/emoticon/consumable-item cooldowns — this IS the class-wide `agiAdjust(...) ×0.88` pattern referenced throughout this doc.

### pgn_doubleSpell5 (431) — modifies blink specifically (not "any spell" as tooltip implies)
- 12% (`lckAdjust`) chance on **blink cast** (not universal) to grant `multiCast` status (1 stack, 3s) — the resulting buff then doubles whatever spell is cast next (universal payoff, blink-specific trigger).

### pgn_manaSurge5 (432) — modifies BOTH manaBurn AND mpTransfer (undocumented dual-skill scope)
- manaBurn: `sLv+=2` (status-level bump, undocumented) and `+⌊0.1×currentMP⌋` to burn value (tooltip only mentions this half).
- mpTransfer: `+⌊0.5×charLv⌋` bonus heal — entirely undocumented in tooltip.

### pgn_snowBall5 (433) — active
- reqLv 75, MP 30, SP 0, mode target/enemy, cType snowBall.
- Converts an existing `snowMan` status on target into `snowBall` status (same level/remaining duration), shield payload `150×snowManLv`. Absorbs damage 1:1; on depletion, defense-ignoring burst `RPC_AddEffectDamage(1, 150×sLv, 15×sLv)`.
- **Confirmed zero secondary effects** after exhaustive search (companion file is an empty stub) — legitimate "nothing hidden," not incomplete research.

### pgn_cosmicRift5 (434) — active
- reqLv 75, MP 50, SP -50 (red), instant, self, cType cosmicRift. CD `agiAdjust(180)`.
- Self-buff `cosmicRift` sLv5, duration `chaAdjust(12)`s: caster takes ZERO incoming damage AND deals ZERO outgoing damage (fully bidirectional null) — matches tooltip exactly. Also disables special-form and pauses HP/MP regen ticks.
- **Cannot cast any other skill while active** (auto-refunds MP/SP if attempted). Mutually exclusive with `cosmicFriday` (434/444 don't stack).
- No hasSkill() gate exists — this skill is entirely self-contained status logic, not a modifier of anything else.

### pgn_superStatPlus5 (441) — **NOT FOUND IN CLIENT CODE**
- The tooltip string itself is broken in `PenguinSkill_eng.cs` (checks `"pnd_superStatPlus5"`, Panda's prefix — a copy-paste bug, so Penguin's client doesn't even show a matching tooltip). No `hasSkill(441)`, no stat-bonus field, anywhere in `Penguin.cs`/`CharacterControl.cs`/`GameGui.cs`/`SkillClass.cs`. Likely server-authoritative and outside this decompile. **Report as "not found in code, likely server-side" on the sheet — do not fabricate a formula.**

### pgn_giantStar5 (442) — modifies BOTH fallingStars AND fallingComets
- fallingStars: targeting radius ×1.5 (matches tooltip), ALSO doubles target cap 5→10 (undocumented), ALSO bumps per-star explosion radius 2m→3m (undocumented, separate from the targeting radius). Swaps to `RPC_giantStars_fire`, damage ×1.25 (matches tooltip).
- fallingComets: scatter radius ±8m→±10m (undocumented), explosion radius 6m→9m (matches "+50%"), damage ×1.25 (matches tooltip). Swaps to `RPC_giantComets_fire`.
- Three genuinely separate radius values change — tooltip only names one.

### pgn_iceTwister5 (443) — modifies BOTH tornado AND typhoon (undocumented dual scope)
- 9% (`lckAdjust`) chance per tick to apply `frost` (matches tooltip's "9% chance").
- **Undocumented**: also raises velocity cap 30→40 on the projectile pet (~33% faster travel) — found in the companion file's own `Init()`, not the main coroutine.
- Applies identically to typhoon (tornado's evolved form), not just base tornado — tooltip only says "Tornado."

### pgn_cosmicFriday5 (444) — active, class ultimate
- reqLv 85, MP 100, SP -50 (red), instant, self, cType cosmicFriday. CD `agiAdjust(300)`.
- Channeled party-invulnerability zone: every 2s drains `hasSkill(414)?20:25` MP from caster (confirms revisedMagic5 applies here too), pulses 3m-radius/3m-height AoE around caster, refreshing `cosmicFriday` status (sLv5, 3s duration, same bidirectional damage-null as cosmicRift) on every ally caught inside.
- Companion file confirmed pure trigger-collider logic (redundant/backup status-application path on player-tag collision) — no additional hidden mechanic.
- Shares mutual-exclusivity and full status-handling code with cosmicRift(434).
