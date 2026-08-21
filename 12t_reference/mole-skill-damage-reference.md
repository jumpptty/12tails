# Mole — Skill Damage/Rank Reference

Companion to `mole-skill-reference.md` (cooldown/duration/maxRank — trusted as-is below, not
re-derived here except where flagged). This doc backs the rank-selector + damage-formula fields
(`maxRank`, per-rank `cd`/`castTime`/`duration` arrays, `dmg`, `dmgDep`/`dmgMultDep`, `atkCoeff`,
`hitCount`/`hitCountDuration`) added to Mole's `SKILLS` entries in
`12t_projects/player-reference-tool/index.html`, 2026-08-18 — the first class built out beyond the
original Penguin pilot (see that project's own `CLAUDE.md`, "Rank selector + damage formula — Penguin
pilot"). Researched via a `mechanics-researcher` subagent sweep of `DecompiledSource/Mole.cs`,
`DecompiledSource/MoleSkill.cs`, `DecompiledSource/MoleSkill_eng.cs`, and `Mole_<skill>.cs` companion
files. All citations are `file:line` against `DecompiledSource/Mole.cs` unless noted.

**A genuinely new formula shape found here, not seen in Penguin's damage skills**: several Mole skills
add a flat coefficient of the caster's own **ATK** stat on top of `talAdjust(...)` — e.g. Mega Punch's
`0.5×ATK + talAdjust(10×sLv)`. The tool's rendering/calc engine only understood `talAdjust(...)`-wrapped
or flat expressions before this pass; a new `atkCoeff` field (paired with the pre-existing but
previously-unexercised `--stat-atk` CSS token) was added to `renderDmgFormula`, `rollOneHit`, and the
Raw Damage calc chip to support it — see `player-reference-tool/CLAUDE.md` for the code-level detail.

## Summary table

| Skill | maxRank | cd/castTime/duration rank-variance | dmg (`sLv`=rank) | dmgNote | dmgDep / dmgMultDep | hitCount |
|---|---|---|---|---|---|---|
| reload | 2 | none | no dmg — cooldown-reset/SP-restore utility | — | — | — |
| mine | 4 | none | `talAdjust(10×sLv+10)` | AoE, single hit per target | **mineLover** ×1.25 mult (hasSkill 402) | 1 |
| mortarShot | 2 | none (only shell *count* scales) | `0.5×ATK + talAdjust(15)` | per shell, `2×sLv+1` shells; falls off with distance; ×2 vs Structure race | none modeled | `2×sLv+1` |
| bunker | 2 | none | no dmg — self-status, −50%/−75% incoming dmg + KO immunity | — | — | — |
| tnt | 4 | none (uses highest TNT rank *owned*, not necessarily cast rank) | `talAdjust(20+10×sLv)` | falls off with blast distance | **superTNT** `(0.1×sLv+0.1)×LV` additive (hasSkill 422) | 1 |
| stunMine | 2 | none | no dmg — pure KO (`10×(sLv+[grenadeCluster5:+1])`, ×1.25 if mineLover) | — | — | — |
| stunGrenade | 2 | none | no dmg — pure KO (`10×(sLv+[grenadeCluster5:+1])`); +30 flat REAL damage vs enemy-layer targets if caster has Smart Shell (not modeled) | — | — | — |
| flameTurret | 3 | none | `talAdjust(5×sLv)` per tick, **penetrating — bypasses defAdjust entirely** (direct `RPC_AddDamage`, same mechanism as `napalm`) | organic-race-only; ticks = `chaAdjust(5)` duration ÷ 0.25s | none found | `duration/0.25` (`hitCountDuration:0.25`) |
| fireBarrage | 2 | none | `talAdjust(5+10×sLv)` | per volley-hit | none found | `4×(sLv≤1?1:3)` |
| bombardment | 2 | none | `talAdjust(10+15×sLv)` | per strike-hit; falls off with distance | none found | `5×(sLv≤1?1:3)` |
| timeNuke | 2 | none | `talAdjust(mLv×100+50)`, mLv=sLv | up to 4 ring pulses, falls off with ring distance | **smartShell1**: halves same-layer / +30 flat enemy-layer (not modeled) | up to 4 |
| detonate | 1 | none | shares timeNuke's base, scaled `clamp(elapsed×0.0166,0.1,0.99)` | manual early-trigger; damage grows 10%→99% with arm time — no Damage Formula chip at all in the tool (2026-08-19, removed entirely rather than shown as opaque text; see Time Nuke's own row for the shared base) | (inherits timeNuke's deps) | up to 4 |
| autoGyroGun | 4 | **castTime**: `magAdjust(1+sLv)` = [2,3,4,5] (corrected from a flat 5) | `10×sLv` (turret's own flat ATK stat, NOT Mole's TAL), KO=1 (flat, not rank-scaled — `AutoGyroGun.cs:1243`) | continuous turret AI, not a single cast; base is REPLACED (not added to) by hiddenTurret5, see below | **hiddenTurret5** (replace, see below); **synchroMole2** (additive `+TAL`, see below) | continuous |
| barrelBot | 4 | **castTime**: `magAdjust(3+sLv)` = [4,5,6,7] (corrected from a flat 7) | no dmg on the base summon entry itself — its 8 individual moves are modeled as their own `SKILLS` entries (see "Barrel Bot's own moveset" below) | Barrel Bot has its own independent `CharacterControl`/stat block (see below), not a proxy for Mole's | doubleBot5 (+0.5×LV to all stats) and synchroMole2 (+TAL to atk) both **confirmed** (see below) | continuous |
| megaPunch | 2 | none | `0.5×ATK + talAdjust(10×sLv)`, KO=5 | tooltip omits the ATK term | **megaDrill** ×1.5 mult on dmg (and KO, not shown) (hasSkill 433) | 1 |
| megaHammer | 2 | none | `0.5×ATK + talAdjust(12×sLv)`, KO=`10×sLv` | tooltip omits the ATK term | **megaDrill** ×1.5 mult on dmg (and KO, not shown) | 1 |
| chopper | 3 | none | `0.3×ATK + talAdjust(5×sLv)` per tick | forward-flight collision ticks | **barrelCannon5** adds a separate flat `talAdjust(20)` AoE bombing pass, once per tick (not modeled — different formula shape) | 10 |
| missile | 4 | none | `talAdjust(30)` flat, per missile | homing, random enemy within 32m | none found | `sLv` (1–4) |
| synchroMole | 2 | none | no dmg — self/ally buff, +50%/100% of Mole's TAL to summons' ATK/DEF | — | — | — |
| kingKaiser | 1 | none | no dmg by itself — 240s mech-transform buff; unlocks separate kaiserCannon1/kaiserBeam1 mech attacks (out of this 27-skill roster, not itemized) | — | — | — |
| advanceRepair | 1 | none | no dmg — heals 150hp/sec, drains 1sp/sec | — | — | — |
| napalm | 1 | none | 1st tick `talAdjust(30)`, ticks 2–6 `talAdjust(5)` each — modeled in the tool via `dmgGroups` (2026-08-19), the first skill whose own hits roll genuinely different base formulas rather than one formula×hitCount | organic-race-only; direct `RPC_AddDamage`, bypasses both `dmgAdjust` and `defAdjust` ("penetrating"); **each of the 5 fired projectiles independently starts its OWN full 6-pulse sequence on impact** (`Mole_napalm.cs:179`'s `OnTriggerEnter` -> `RPC_napalm_hit`, confirmed the ONLY trigger source — `Mole.cs`'s 2 other call sites, `:2831`/`:5671`, are both `if (this.mChar.isMine) break`-guarded Photon replication receivers, not independent triggers) — so a target all 5 projectiles connect with (reliable in practice: cast point-blank, large pulse hitbox) takes 5×6 = **30 total pulses**, not 6 | none found | 30 (`hitCount:()=>30`, `dmgGroups:[{hitCount:5},{hitCount:25}]`) |
| grenadeCluster | 1 | none | `ATK + talAdjust(30)`, KO=10, per grenade | self-centered ring burst; falls off with distance | none found | 8 |
| flameCarnival | 1 | none | `talAdjust(10)` per tick, organic-race-only | radius `clamp(2+i,3,5)`; Duration column is the unarmed trap's arming window, NOT the burn time | **smartShell1** halves same-layer dmg (not modeled) | 20 (hardcoded, not CHA-scaled) |
| megaDrill | 1 | none | `ATK + talAdjust(45)`, KO=2 | forward drill dash | none found | 1 |
| barrelCannon ("Barrel Cannon" — briefly renamed "Cannon Form" mid-session 2026-08-20, reverted back the same day since that's the skill's real skill-tree name) | 1 | none | `1.5×ATK`, Barrel Bot's OWN ATK/attacker-LCK (`ownStatsDmgOnly:true`) — **resolved** (was "unresolved" here; the shell-impact formula was found in the same session, see "Barrel Bot's own moveset" below and the Cannon Form merge note) | the ONLY Barrel Bot move Mole explicitly commands rather than the AI picking it — merged with the former `SKILLS` entry `mole_barrelBot_cannonForm` (2026-08-20); Cooldown is Mole's OWN 120s cast-side cooldown (`Mole.cs:40199`, Mole's own AGI/LCK, revisedArt-eligible) — NOT Barrel Bot's own 90s internal re-trigger timeout (`BarrelBot.cs:5639`, still real but not the one shown, see the merge note below) | (also enables chopper's bombing pass) | 10 |
| warFactory | 1 | none | itself deals no damage as a top-level entry — replaced by 5 separate `SKILLS` entries ("War Factory - X", 2026-08-20, see below), one per real sub-action | — | — | — |
| warCapital | 1 | **castTime**: `magAdjust(24)` flat, confirmed correct, unchanged | `talAdjust(50)` per missile, KO=3 | 8-missile volley | none found | 8 |

**warFactory's sub-actions (re-verified and split into 5 separate `SKILLS` entries, 2026-08-20)** — own
damage-dealing calls, dispatch codes 4341–4345 contiguous (`Mole.cs:5849-5966`'s network-replication
mirror table; each sub-action's OWN `hit()` call uses a separate, unrelated action-code namespace for its
damage-popup color, not these dispatch codes — confirmed by cross-referencing, e.g. bazooka dispatches on
4342 but its own `hit()` call passes `3442`):
- **sawMachine**: `1.5×ATK + talAdjust(15)`, KO=0 — `Mole.cs:40770`. **`hitCount:4`, not 1** — a real
  `for`-shaped loop (`this.$i$23977 = 1` init, `$i$23977++` increment, `if ($i$23977 > 4)` exit bound,
  `Mole.cs:40568/40594/40671`) cycles through 4 different rectangular hitbox shapes
  (`Damage.FindRecTarget`, `Mole.cs:40710-40746`), each its own scan-and-`hit()` pass — a real 4-swing
  combo, not a one-time random pick of one hitbox shape. Modeled as `mole_warFactory_sawMachine`
  (`hitCount:()=>4`), theoretical max assuming the target stays in every phase's hitbox.
- **bazooka**: `ATK + talAdjust(50)`, KO=5 — `Mole_bazooka.cs:228`. Single projectile
  (`ProjectileControl`), single small (1m/1m) point-blank splash on impact (`Mole_bazooka.cs:204-238`,
  read in full — no repeat-fire mechanism anywhere in the file). Modeled as `mole_warFactory_bazooka`,
  no `hitCount` (defaults to 1).
- **teslaCoil**: `talAdjust(30)` AoE (range 5), up to 7 pulses (loop bound `Mole.cs:42034`) — `Mole.cs:42065`.
  **Correction**: the `RPC_AddStatus("paralysis",2,3,...)` proc previously attributed to rollerMachine
  actually belongs to teslaCoil — `Mole.cs:42109` sits inside `$RPC_teslaCoil$24002`'s own class body
  (spans `Mole.cs:41581-42197`, confirmed by locating the enclosing `internal sealed class` declaration),
  well before `$RPC_rollerMachine$24015` even starts at `:42198`. Applies on every landed pulse unless the
  target's `actionState` is already `standby`/`run`/`emotion` — deterministic (state-exclusion gated),
  not an RNG roll, unlike every `lckAdjust`-based proc elsewhere in this tool. Not modeled (no status
  chip exists in this tool). Modeled as `mole_warFactory_teslaCoil` (`hitCount:()=>7`).
- **rollerMachine**: `3×ATK` melee (no `talAdjust` term at all — a new flat-shape-plus-atkCoeff engine
  case, `dmg:"0"`+`atkCoeff:3`), KO=0. **`hitCount:11`, not 2** — an earlier pass in this same session
  under-counted this by only grepping for literal `hit(4344,...)` call-site TEXT (2 occurrences) without
  tracing the actual control flow; the real structure is 1 initial hit-scan on roll-start
  (`Mole.cs:42394-42430`, state `case 3`) PLUS a genuine counter-bounded loop (`$i$24021 = 0` at
  `Mole.cs:42494`, `$i$24021++` at `:42520`, `if ($i$24021 >= 10)` exit at `:42597`) that re-runs the
  SAME hit-scan-and-hit block once per pass while `i<10` (`:42610-42643`) — a per-tick "rolling forward,
  hit whoever's in the path" mechanic, not 2 fixed swings. Compiler-generated coroutine state machines
  revisit the SAME case-label code text on every loop pass rather than duplicating it, which is exactly
  why grepping for distinct `hit()` call-site text undercounts a real loop — don't repeat that mistake.
  Modeled as `mole_warFactory_rollerMachine` (`hitCount:()=>11` — 1 initial + 10 looped), theoretical max
  assuming the same target stays in the small 1.5×1.5 rolling hitbox for the whole roll. The paralysis
  proc previously cited here was a misattribution (see teslaCoil above) — rollerMachine's own class
  carries no status-application call anywhere.
- **cartBomb**: `talAdjust(150)`, KO=30 — by far the largest single-hit base value of the 5.
  **Correction, same session**: an earlier pass in this exact investigation concluded Cart Bomb "carries
  no damage-dealing call anywhere" after reading only the first 80 lines of its ~192-line companion
  `Mole_cartBomb.cs` file — the real trigger is later in that same file, in `Update()`
  (`Mole_cartBomb.cs:52-161`): the summoned cart tracks the caster for up to 3 real seconds
  (`this.S0AbNCNuvS += Time.deltaTime; if (<= 3) {...}`), and while `actionState=="attack"` and
  `myCommand=="cartBomb"`, calls `mole.RPC_cartBomb_hit(...)` (`:127`) — whose own body
  (`Mole.cs:14128-14235`, a plain `void` method, not a coroutine, so no obfuscated state-machine wrapper
  to miss) does a real AoE `Damage.FindAreaTarget` scan, radius `6+1.5×getExtraPowderLv()`
  (`extraPowder1-3`, not modeled — no radius chip in this tool), with a real linear distance falloff
  (`1 - 0.5×(distance/radius)`, not modeled — no falloff chip either) applied to `talAdjust(150)`, KO=30
  flat, action code 3445 (`Mole.cs:14183-14213`). Single AoE burst, no repeat loop — `hitCount` left at
  default (1), same "no fixed cap, bounded only by however many enemies are physically in the blast" call
  already made for sawMachine's per-phase scans and bazooka's splash. Reconciled against
  `mole-skill-reference.md`'s own prior, independently-correct note: `RPC_cartBomb` really is War
  Factory's cast/deploy coroutine (its own `Mole.cs:43394` arms the skill's real 180s cooldown, vs. the
  other 4's short `agiAdjust(3)` internal attack-cadence re-arm) — that finding stands, it just doesn't
  mean "no damage," it means the cast action AND the first real hit are the same coroutine/prop lifecycle,
  not two separate things. Modeled as `mole_warFactory_cartBomb`.
  **Process lesson, worth repeating**: "checked the companion file" is not the same claim as "read the
  whole companion file" — this file is short (192 lines) and the miss was still real. Read a flagged
  companion file to its actual end before concluding it has no relevant logic, the same "read to the
  real return, not the first plausible stopping point" discipline this doc family already applies to
  obfuscated control flow within a single file.

## Class C passive sweep

CommandNum→passive mapping confirmed via `MoleSkill.cs`'s `getSkillTree` (lines 3242–3465): 401=cannonExpert5,
402=mineLover5, 403=hiddenTurret5, 404=revisedSkill5, 411=superDig5, 413=skyShaker5, 414=revisedMagic5,
421=geniusInvention5, 422=superTNT5, 423=doubleBot5, 424=revisedArt5, 432=grenadeCluster5 (base skill,
also buffs stunMine/stunGrenade), 433=megaDrill5 (base skill, also buffs megaPunch/megaHammer),
441=superStatPlus5, 442=flameCarnival5 (base skill), 443=barrelCannon5 (base skill, also adds chopper's
bombing pass), 444=warCapital5 (base skill).

| Passive | Damage-relevant? | Finding |
|---|---|---|
| **mineLover5** | Yes | ×1.25 dmg mult on `mine` (`Mole.cs:10614-10620`) and ×1.25 KO mult on `stunMine`'s `hit()` call inside `RPC_stunMine_hit` (`Mole.cs:11092-11103` — corrected 2026-08-19; an earlier pass mis-cited this as `Mole.cs:26680-26694`, which is actually where `mineLover5` gates `stunMine`'s COOLDOWN, not its KO value — same passive, two separate effects, two separate citations) — not purely a cooldown-reduction passive. **Tooltip claims +50%, code delivers +25%** (`Mathf.FloorToInt(1.25f*...)`) — flagged, code trusted over tooltip. Also confirmed (2026-08-19): the raw cooldown reduction itself is a REPLACE, not a clean half (`Mole.cs:23891-23905`: 15→8; `Mole.cs:26680-26694`: 45→23) — now modeled as `cdDep` on both `mine` and `stunMine`, sharing `id:"mineLover"` with the damage-side `dmgMultDep` so the tool's Cooldown-chip and Damage-Formula-chip toggle icons stay linked. |
| **smartShell1** | Yes | +30 flat `RPC_AddEffectDamage` on mine/stunMine (`RPC_smartShell_hit`, `Mole.cs:11489-11588`) and inline on stunGrenade/timeNuke/flameCarnival; halves damage/KO to same-layer (friendly) targets across all 5. **stunGrenade's own instance confirmed 2026-08-19**: `Mole_stunGrenade.cs:285`, `characterControl2.RPC_AddEffectDamage(264, 30, 0, 0, Vector3.zero, ...)`, gated on `getSmartShellLv()>0` (`hasSkill(264)`) AND the target being on a different collision layer than the caster — genuinely real damage on an otherwise pure-KO skill, previously undocumented for stunGrenade specifically (only the generic "inline on stunGrenade" note existed before). Not modeled as a toggle in the tool (too conditional/multi-skill) — noted in each affected skill's `dmgNote` instead. |
| **superTNT5** | Yes | Adds `(0.1×sLv+0.1)×LV` inside tnt's `talAdjust(...)` (`Mole.cs:26048`). **Tooltip claims a flat "+40 damage"; code is level-and-rank-scaled, not flat** — flagged. Modeled as `dmgDep` with a rank-dependent `term`/`calc` (new capability — the first Mole dep whose bonus depends on the skill's OWN rank, not just LV). |
| **grenadeCluster5** | Yes (on stunMine/stunGrenade) | +1-rank-equivalent to stunMine's/stunGrenade's KO formula (`Mole.cs:11092`, `Mole.cs:11319`). Not modeled (stunMine/stunGrenade have no `dmg` field — KO, not damage). |
| **megaDrill5** | Yes (on megaPunch/megaHammer) | ×1.5 mult on both dmg and KO for megaPunch (`Mole.cs:32488-32504`) and megaHammer (`Mole.cs:33081-33097`) — matches tooltip exactly. Modeled as a shared `dmgMultDep` (id `megaDrill`, same toggle state on both skills — intentional, matches source: learning Mega Drill buffs both). |
| **barrelCannon5** | Yes (on chopper, + a BarrelBot mode unlock) | Adds a flat `talAdjust(20)` AoE bombing hit per chopper tick (`Mole.cs:33957-33996`) — different formula shape from chopper's own per-tick value, not modeled as a toggle, noted in `dmgNote` instead. Also unlocks `RPC_cannonForm` on BarrelBot — that turret mode's own damage formula is unresolved (see Open items). |
| cannonExpert5 | No (out of scope) | Buffs `nAttack` (normal attack) — excluded per the blanket nAttack/cAttack policy. |
| hiddenTurret5 | Claimed, not verified | Tooltip claims "+Mole's level to autoGyroGun's basic stats" — only found gating the "hide underground" mechanic (`AutoGyroGun.cs:832`), no stat-addition line located. |
| doubleBot5 | Claimed, not verified | Same issue for BarrelBot — `hasSkill(423)` usage found (`Mole.cs:12415`) only gates a 2nd-BarrelBot-slot tracking flag, no stat-addition line found. |
| skyShaker5, superDig5, geniusInvention5, revisedSkill5, revisedMagic5, revisedArt5, superStatPlus5, kaiserCannon1, kaiserBeam1, extraPowder1-3, gadgeteer1-4, statPlus1-4 | No | Confirmed non-damage (utility/cooldown/cost/blast-radius/stat passives) — matches the cooldown doc's existing characterization. |

## Cast-time correction

The tool's pre-existing 3 castTime entries (`autoGyroGun`, `barrelBot`, `warCapital`) were only correct
at max rank. Re-derived from the shared `assemble` coroutine (`Mole.cs:23344-23417`, the same coroutine
the cooldown doc already documents for CD):
- `autoGyroGun`: `magAdjust(1+sLv)` → **[2,3,4,5]** by rank 1-4 (was flat 5) — `Mole.cs:23359`
- `barrelBot`: `magAdjust(3+sLv)` → **[4,5,6,7]** by rank 1-4 (was flat 7) — `Mole.cs:23376`
- `warCapital`: `magAdjust(24)` flat, confirmed correct (maxRank 1) — `Mole.cs:23393`

A whole-file grep of `Mole.cs` for `magAdjust` returns exactly 3 hits (the shared one above) plus two
more at `Mole.cs:50334`/`51883` belonging to the universal `RPC_useMount`/`RPC_activateIcon1` actions —
already excluded by the cooldown doc's blanket policy. **No other Mole skill has a real cast time.**

## Cooldown/duration rank-variance re-check

Beyond the already-documented `tnt` (flat CD regardless of sLv), no other Mole skill's cooldown or
duration varies by `sLv` — every `addTimeOut`/duration citation in the cooldown doc uses a literal
constant independent of `sLv`. No corrections needed there beyond the castTime fixes above.

## Icon-key corrections (pre-existing bug, same family as Penguin's 6 mislabeled keys)

**8 of Mole's maxRank:1 Class-C-tier skills had a wrong icon key already shipped in `SKILL_ICONS`** —
the key existed and had *some* image behind it, but no matching file exists on disk under that suffix;
the real files are all suffix `5` (matching the "Class-C-tier skills use a `5` suffix" convention this
repo's Penguin pilot already established), not `1`:

| Skill | Old (wrong) key | Corrected key | Real file |
|---|---|---|---|
| advanceRepair | `mole_advanceRepair1` | `mole_advanceRepair5` | `advanceRepair5.png` |
| napalm | `mole_napalm1` | `mole_napalm5` | `napalm5.png` |
| grenadeCluster | `mole_grenadeCluster1` | `mole_grenadeCluster5` | `grenadeCluster5.png` |
| flameCarnival | `mole_flameCarnival1` | `mole_flameCarnival5` | `flameCarnival5.png` |
| megaDrill | `mole_megaDrill1` | `mole_megaDrill5` | `megaDrill5.png` |
| barrelCannon | `mole_barrelCannon1` | `mole_barrelCannon5` | `barrelCannon5.png` |
| warFactory | `mole_warFactory1` | `mole_warFactory5` | `warFactory5.png` |
| warCapital | `mole_warCapital1` | `mole_warCapital5` | `warCapital5.png` |

Re-extracted fresh from the real `5`-suffix files (`RippedAssets/.../gamegui/icons/skills/mole/`) and
renamed both the `SKILL_ICONS` entry and the `SKILLS.icon` reference to match, same fix shape as
Penguin's original 6-key correction. `detonate1`/`kingKaiser1` were checked too and are genuinely
correct (those files exist on disk unlike the 8 above) — not part of this correction.

Also extracted: every missing `1..maxRank-1` rank icon for Mole's 18 multi-rank skills (the max-rank icon
was already present from the original cooldown-lookup build; only the lower ranks needed for rank-cycling
were missing), plus 2 new stand-alone Class C dep icons (`mole_mineLover5`, `mole_superTNT5`) not
previously in the roster at all.

## Tooltip-vs-code discrepancies (code trusted, tooltip cited for context only)

- **mine**: tooltip says 10/20/30/40 dmg for ranks 1-4 (`MoleSkill_eng.cs:224,235,246,257`); code gives
  `talAdjust(10×sLv+10)` = 20/30/40/50 — consistently +10 over tooltip.
- **bombardment**: tooltip says 35/55 dmg×5 (`MoleSkill_eng.cs:455,466`); code gives
  `talAdjust(10+15×sLv)` = 25/40 — consistently −10 vs tooltip.
- **napalm**: tooltip says "45 penetrating damage" total (`MoleSkill_eng.cs:950`); ONE projectile's own
  6-pulse sequence totals `talAdjust(30) + 5×talAdjust(5)` = 55 at baseline TAL (off by 10) — but that's not
  the real per-cast total: each of the 5 fired projectiles independently starts its own full 6-pulse sequence
  on impact (confirmed via `Mole_napalm.cs:179`, see the table row above), so a point-blank cast where all 5
  connect (the reliable real case) totals `5×55` = 275 at baseline TAL, ~25× the tooltip figure — the tooltip
  is almost certainly describing one representative pulse/tick, not the full multi-projectile cast.
- **mineLover5**: tooltip says "+50% landmine damage"; code applies ×1.25 (+25%).
- **superTNT5**: tooltip says a flat "+40 damage"; code adds a level-and-rank-scaled term, only ≈40 near
  level 80-100 at max sLv.
- **megaPunch/megaHammer**: tooltips (`MoleSkill_eng.cs:686-719`) state only the `talAdjust` component
  and omit the `0.5×ATK` flat addend the code always adds on top.

## Auto Gyro Gun's 2 real dependencies (resolved 2026-08-18, follow-up research pass)

The base "hiddenTurret5... not verified" flag above was resolved by a deeper, targeted 2nd research
pass — full trace below, both now wired into `index.html` as live toggles.

**1. `hiddenTurret5` (commandNum 403) — REPLACES the turret's base stats, does not add to them.**
Its own English tooltip (`MoleSkill_eng.cs:983`) reads "Also add Mole's level to alll thier basic
stats" — this wording is misleading. Actual mechanism:
- The turret prefab's `Awake()` sets its baseline flat stats on instantiation (e.g. rank 4:
  `AutoGyroGun.cs:126`, `atk=def=agi=vit=mag=cha=tal=lck=40`, matching the `10×sLv` figure already in
  this doc).
- `Mole.cs:13651-13654` — `getHiddenTurretLv()` returns 1 if `hasSkill(403)`, else 0.
- `Mole.cs:12141-12197`, inside `RPC_autoGyroGun_create`, runs AFTER the prefab's `Awake()` but BEFORE
  the turret starts acting: if `getHiddenTurretLv() > 0`, it **overwrites** (not `+=`) `atk`/`def` to
  `(int)(0.25f × sLv × mChar.Lv)` (`Mole.cs:12152`, `:12157` — `sLv` = turret rank, `mChar.Lv` = Mole's
  own character level), and similarly overwrites `agi`/`vit`/`mag`/`cha`/`tal`/`lck` to
  `0.125×sLv×MoleLv` each (`Mole.cs:12162-12187`), plus derived `mhp`/`hp` from the new `vit`.
- Confirmed end-to-end damage read-site: `AutoGyroGun.cs:1243`'s `RPC_fire` coroutine calls
  `mChar.hit(1, hitObject, mChar.atk, ...)` — the exact same `atk` field set above, no separate damage
  stat exists.
- **Break-even math**: baseline flat ATK = `10×rank`. Replacement = `0.25×rank×MoleLevel`. Equal at
  `MoleLevel = 40` (independent of rank). **Below Mole level 40, hiddenTurret5 actually LOWERS the
  turret's ATK/DEF relative to not having it at all** — the tooltip's "add Mole's level" phrasing
  implies a pure bonus, which it is not below that threshold. Modeled in `index.html` as a new
  `dmgReplaceDep` mechanism (distinct from the existing additive `dmgDep`/multiplicative `dmgMultDep`
  shapes) since it swaps the base term entirely rather than modifying it — see
  `player-reference-tool/CLAUDE.md`'s dated section for the engine-side detail.

**2. Synchro Mole (rank 2) — a genuine additive `+floor(Mole's TAL)` to both ATK and DEF, confirmed to
apply to Auto Gyro Gun specifically (not just BarrelBot).**
- Cast: `Mole.cs:13247-13402` sweeps the caster's own summons, explicitly matching type names
  `"AutoGyroGun1"`–`"AutoGyroGun5"` alongside `BarrelBot1-5` (`Mole.cs:13295-13329`), and calls
  `RPC_AddStatus("synchroMole", sLv, num+1, mChar.tal, mChar.ActorNr)` on each match (`Mole.cs:13370`) —
  `sLv` = Synchro Mole's own cast rank (1 or 2), `mChar.tal` = Mole's TAL at cast time.
- Eligibility gate (`CharacterControl.cs:12466-12487`): non-Mole receivers must be Robots-race — the
  turret qualifies.
- Apply site (`CharacterControl.cs:37760-37817`, the non-Mole branch of the `"synchroMole"` case inside
  the generated `addStatus` coroutine): `deltaAtk(floor(0.5×sLv×sValue))` and
  `deltaDef(floor(0.5×sLv×sValue))` where `sValue` = the stored `mChar.tal` from cast time. **At rank 2:
  `floor(0.5×2×TAL) = floor(TAL)`** — i.e. +100% of Mole's TAL added to both ATK and DEF. At rank 1 it's
  +50%.
- `deltaAtk`/`deltaDef` mutate the live `atk`/`def` fields directly (`CharacterControl.cs:20866-20881`)
  — the same fields `hiddenTurret5` overwrites and `RPC_fire` reads, so this bonus is real and additive
  on top of whichever base (flat `10×sLv` or hiddenTurret5's replacement) is currently active.
- Symmetric removal on status expiry (`CharacterControl.cs:16978-17049`) prevents permanent drift; a
  recast on an already-buffed turret refreshes rather than double-stacks
  (`CharacterControl.cs:14103-14182`).
- **Caveat**: only affects turrets that already exist at cast time — a turret summoned *after* Synchro
  Mole was cast does not retroactively receive the buff (`AutoGyroGun.cs:1649-1742`'s own creation
  coroutine never checks for the status). Not modeled in the tool (state-timing nuance, same "no
  dodge/reposition modeling" idealization this tool already accepts everywhere).

Combined formula while both are active: `atk = def = [10×rank, or 0.25×rank×MoleLv with hiddenTurret5] + floor(MoleTAL)` (Synchro Mole rank 2).

**3. The turret also has its own independent `lck` stat — separate from Mole's own LCK, and relevant to
this tool because `dmgAdjust`'s attacker-side roll (`ceil(0.2×this.lck)`) reads the ATTACKER's own field,
and the attacker for the turret's hit is the turret, not Mole.** Verified via a 3rd research pass:
- Baseline (no Hidden Turret): `AutoGyroGun.cs:77/92/107/126` — `lck` is set on the exact same
  chained-assignment line as `atk`/`def`/`agi`/`vit`/`mag`/`cha`/`tal` (`atk=def=agi=vit=mag=cha=tal=lck=10×rank`
  at every rank 1-4, not just the previously-cited rank 4), so baseline `lck` can never diverge from the
  already-modeled `atk` figure.
- With Hidden Turret (`hasSkill(403)`): `Mole.cs:12187` — `characterControl.lck = (int)(0.125f × sLv × mChar.Lv)`
  — **half** the `0.25` coefficient `atk`/`def` get (`Mole.cs:12152/12157`), grouped instead with
  `agi`/`vit`/`mag`/`cha`/`tal` at that same `0.125` rate (`Mole.cs:12162-12182`). So `atk` and `lck`
  diverge once Hidden Turret is active, even though they're identical at baseline.
- Synchro Mole re-confirmed to touch only `atk`/`def` (`deltaAtk`/`deltaDef`, both the apply site
  `CharacterControl.cs:37772/37777` and the expiry-negation site `CharacterControl.cs:17046/17049`) — `lck`
  is untouched by it in both directions.
- `dmgAdjust`'s exact line, confirming self-reference: `CharacterControl.cs:20489` —
  `Random.Range(0, CeilToInt(0.2f * this.lck))`.

Modeled in `index.html` via a new `ownLck:true` flag plus a 2nd coefficient (`dmgReplaceDep.lckCoeff:0.125`,
alongside the existing `coeff:0.25` for the ATK-equivalent base) — the Final Damage chip's `dmgAdjust` roll
for this one skill now reads the turret's own computed LCK instead of the tool's global LCK input (which
represents Mole's own stat, correct for every other skill in the tool, wrong for this one).

## KO — missed by both prior KO sweeps, added 2026-08-20

Both Mole KO research passes (the original 6-skill sweep and the follow-up 16-skill exhaustive sweep,
see `player-reference-tool/CLAUDE.md`'s 2026-08-19 entries) skipped Auto Gyro Gun entirely — it was
excluded from both hand-picked skill lists, likely because it's already special-cased everywhere else
(continuous turret AI, not a single cast) rather than a deliberate "checked, confirmed zero" finding.
User caught this directly by reading `AutoGyroGun.cs` itself: the turret's own auto-fire coroutine
(`RPC_fire`, `AutoGyroGun.cs:1243`) calls
`this.mChar.hit(1, hitObject, this.mChar.atk, 1, 0, Vector3.zero)` — matching `CharacterControl.hit`'s
real signature (`CharacterControl.cs:2807`,
`hit(int actionCode, GameObject tObject, int nDamage, int nKo, int nHate, Vector3 nForce)`), the 4th
positional argument (`nKo`) is a literal `1`, not derived from rank/level/any dep. So every turret hit
deals exactly 1 KO, flat, confirmed independent of Hidden Turret/Synchro Mole (neither touches this call
site at all). Added `ko:"1"` to `mole_autoGyroGun` in `index.html` — no new dep/mechanism needed, the
existing `getKOValue`/`.sk-ko-badge` machinery (already built for Mega Punch etc.) picks up a plain flat
`ko` string with no extra work.

## Barrel Bot's own moveset, split into 8 separate `SKILLS` entries (2026-08-20)

User asked to treat Barrel Bot's own AI-picked attacks as separate skills (mirroring War Factory's
treatment the same session), and specifically to re-verify whether each move's own cooldown/timeout key
is `agiAdjust`-wrapped, since it was suspected NOT to be. Full moveset found via a companion file
(`BarrelBotAI.cs`) never previously read for this tool — its own `AI_attack(...)` method
(`:900-1299`) is the real dispatch logic, picking a move by distance-to-target and checking
`M2scIFaHBGl.isTimeOut("<key>")` per move before firing. **7 real moves found, not the 5 the user
named** — `chopper` is real and verified but wasn't in the original request; included anyway per this
project's "check every field" policy (set 2026-08-19), flagged in its own `dmgNote` in case it wasn't
wanted. "Mega Drill" and "Missile" (the user's single "mega drill missiles" item) are two genuinely
separate mechanics — different timeout keys, different formulas, different upgrade trees — modeled as 2
entries. "Barrel Cannon" turned out to be TWO separate activations sharing one projectile formula (a
single reactive shot vs. a 10-shot burst mode), both real and separately cooldown-gated — modeled as 2
entries. **8 total**: Normal Attack, Mega Punch, Mega Hammer, Chopper, Missile, Mega Drill, Barrel
Cannon, Cannon Form.

**Cooldown-wrapping check, per skill (the user's own explicit ask) — 2 of 8 are flat, 6 are
`agiAdjust`-wrapped**, confirmed individually rather than assumed uniform either way:
- `nAttack`: flat `3`, NOT agiAdjust — `BarrelBot.cs:2480`.
- `punch`: `agiAdjust(12)` — `BarrelBot.cs:2891`.
- `hammer`: `agiAdjust(15)` — `BarrelBot.cs:3286`.
- `chopper`: `agiAdjust(60)` — `BarrelBot.cs:3825`.
- `missile`: `agiAdjust(60)` — `BarrelBot.cs:4382`.
- `drill`: flat `9`, NOT agiAdjust — `BarrelBot.cs:4818`.
- `cannon`: `agiAdjust(9)` — `BarrelBot.cs:5278`.
- `cannonForm`: `agiAdjust(90)` — `BarrelBot.cs:5639`.

**Formulas** (ATK/TAL/KO cited directly from `BarrelBot.cs` unless noted; `sLv` = the move's own
upgrade-tree level, distinct per move, NOT tied to Mole's currently-selected active-skill rank input):
- **nAttack**: `0.5×ATK` (flat, no talAdjust — `atkCoeff:0.5`, `dmg:"0"`), KO=1 — `BarrelBot.cs:2223`.
- **punch** ("Mega Punch"): `0.4×ATK + talAdjust(12×sLv)`, KO=5, `sLv`=PunchLv (1-2, hasSkill 331/332,
  Mole's own Mega Punch unlocks) — `BarrelBot.cs:2775`.
- **hammer** ("Mega Hammer"): `0.5×ATK + talAdjust(10×sLv)`, KO=`10×sLv`, `sLv`=HammerLv (1-2, hasSkill
  333/334) — `BarrelBot.cs:3170`.
- **chopper**: `0.3×ATK + talAdjust(5×sLv)`, KO=1, `hitCount:4` (real for-loop, `i>=4` bound,
  `BarrelBot.cs:3707`), `sLv`=ChopperLv (1-3, hasSkill 341/342/343) — `BarrelBot.cs:3751`. Own separate
  4-tick implementation from Mole's own personal Chopper (10 ticks) — don't conflate.
- **missile**: `talAdjust(30)` per missile, KO=3, `hitCount:(rank)=>rank` (real while-loop, `MissileLv`
  bound, `BarrelBot.cs:4124-4219`), rank=MissileLv (1-4, hasSkill 351-354 — BarrelBot's OWN separate
  missile unlock tree, distinct from Mole's personal Missile skill). Real formula found only on a
  follow-up full read of the companion `BarrelBot_missile.cs:349`, not the main coroutine — bypasses
  `hit()` entirely (`characterControl2.defAdjust(characterControl.talAdjust(30))` then
  `RPC_AddDamage` directly), so `dmgAdjust` never runs but `defAdjust` genuinely still does. New engine
  flag `dmgAdjustSkip:true` added to model this exactly (distinct from full `penetrating`, which skips
  both) — this is one of the "3 other skills that manually re-apply defAdjust after bypassing hit()"
  flagged but never identified back when Flame Turret/Carnival's `penetrating` flag was first verified.
- **drill** ("Mega Drill"): `0.5×ATK + talAdjust(15)`, KO=2, `hitCount:4` (real for-loop, `i<4` bound,
  `BarrelBot.cs:4624-4944`), requires Mole's own Mega Drill (hasSkill 433, boolean, no rank scaling on
  the formula) — `BarrelBot.cs:4685`.
- **cannon** ("Barrel Cannon"): `1.5×ATK` flat (no talAdjust — `atkCoeff:1.5`, `dmg:"0"`), KO=1, real AoE
  (radius 3, height 4), requires Barrel Cannon (barrelCannon5, hasSkill 443, boolean) — formula in
  `RPC_cannon_hit` (`BarrelBot.cs:1889`), fired via the shared `RPC_cannon_fire` projectile (its own
  companion `BarrelBot_cannon.cs` only spawns/tracks the shell, doesn't carry the hit payload). This
  **resolves this doc's own previously-open item** (used to be listed under "Open items" as "searched,
  no hits found" — the real call was reachable only by following `RPC_cannon`'s own dispatch into
  `RPC_cannon_fire` then the projectile's own `OnTriggerEnter` → `RPC_cannon_hit`, a longer chain than
  the direct grep first tried — now removed from that list since it's fully resolved).
- **cannonForm** ("Cannon Form"): the SAME `1.5×ATK` formula/projectile as `cannon` above, but a
  genuinely separate activation — once triggered (own `cannonForm` timeout, 90s base), auto-fires the
  shell once every real 0.5s at a locked target for up to 10 shots (`hitCount:10`, real counter loop
  `mCannonCount>=10`, `BarrelBot.cs:5716-5762`) or until the target's lost. Requires the same Barrel
  Cannon unlock. The `cannon`/`cannonForm` split wasn't visible from `AI_attack`'s own dispatch alone (it
  only ever checks the `cannon` timeout for its normal attack rotation) — found by locating BOTH
  `RPC_cannon` and `RPC_cannonForm`'s real class boundaries precisely (`BarrelBot.cs:5030-5376` and
  `:5377-6131` respectively) after an initial broad grep across their combined range conflated the two
  `addTimeOut` calls together.

All 8 share `icon:"mole_barrelBot4"` (confirmed via `ls RippedAssets/.../mole/` — only `barrelBot0-4.png`
exist, no dedicated per-move icons, matching War Factory's identical situation) and each move's shown
Cooldown is its own internal attack-cadence timeout, NOT the Barrel Bot summon's own 240s recast
cooldown (still shown on the base `mole_barrelBot` entry, unchanged).

Verified live (Playwright, local dev server): Missile at rank 4 — `30 + 76(0.6TAL)` at TAL=128, Raw
Damage `106-122`, Final Damage `114-132` (narrower spread than a normal skill would show, consistent
with `dmgAdjustSkip` correctly omitting the attacker-LCK-roll spread `dmgAdjust` would otherwise add),
Simulate "Test 4 hits"/4 items at rank 4, rank-cycled to 1 → "Test one hit" (hitCount correctly tracks
rank live). Normal Attack — Cooldown "3s / fixed 3s" (correctly unwrapped/muted, unlike every
agiAdjust-wrapped move's range display), `64(0.5ATK)` at ATK=128. Chopper — `15 + 38(0.3ATK) +
38(0.3TAL)` at rank 3/ATK=TAL=128, Cooldown `27.23-30s / base 60s`. Cannon Form — Simulate "Test 10
hits"/10 items, Cooldown `40.85-45s / base 90s`. Zero console errors across all checks.

## Barrel Bot has its own independent stat block — NOT a proxy for Mole's stats (2026-08-20)

User follow-up, same day: "agiAdjust-wrapped in this case use Mole or BarrelBot Agi", then "you might have
to find out Barrel Bot stats, doubleBotskillDep and synchromole skillDep" — closes this doc's own
previously-open `doubleBot5` item above and answers the AGI question directly: **BarrelBot's own AGI,
not Mole's.**

**BarrelBot is a fully separate `CharacterControl`, confirmed at the summon's own instantiation**
(`BarrelBot.cs:32`: `this.mChar = this.GetComponent<CharacterControl>()`) — every `agiAdjust`/`talAdjust`
call inside `BarrelBot.cs` (all 8 moves above) reads THIS component's own stat fields, never reaching back
into Mole's `CharacterControl` at all. Baseline stats are rank-gated by the summon's own prefab `type`
string (`"BarrelBot1"`..`"4"`, matching the skill's own `maxRank:4`), set at spawn
(`BarrelBot.cs:47-152`, one `if/else if` chain per rank):
- `atk`/`def` = `15×rank` (rank 4 → 60)
- `vit`/`tal`/`lck` = `10×rank` (rank 4 → 40 each)
- `agi`/`mag`/`cha` = flat `10`, **never scales with rank** — this is the direct answer to "use Mole or
  BarrelBot Agi": at any rank, BarrelBot's own AGI is a flat 10, dramatically lower than Mole's own
  typical AGI (this tool's default player input is 128) — a real, large difference, not a rounding
  nuance. Confirmed live: Mega Punch's Cooldown chip (base 12s, `agiAdjust`-wrapped) shows `7.46-8.17s`
  using BarrelBot's own rank-4 AGI/LCK (60/90 with Double Bot active), hand-verified bit-exact against
  `agiAdjustRange(12, 60, 90)` — a visibly narrower reduction than the same base would get from Mole's
  own 128 AGI.

**`doubleBot5` (`hasSkill(423)`) — resolves this doc's own previously-open item.** `Mole.cs:12708-12759`:
when active, adds `Mathf.FloorToInt(0.5×Mole's own character level)` to ALL 8 of BarrelBot's stats
(atk/def/vit/tal/agi/mag/cha/lck) at once — additive on top of the rank-gated baseline above, not an
overwrite (unlike `hiddenTurret5`'s Auto Gyro Gun mechanism, a different passive despite the superficially
similar "+level to stats" tooltip wording). At Mole LV 100: bonus = `floor(0.5×100) = 50` to every stat,
including AGI (10→60) and LCK (40→90) — this is why Double Bot measurably changes BOTH the damage terms
AND the Cooldown roll-spread, not just damage.

**`synchroMole` rank 2 — confirmed to ALSO sweep BarrelBot, not just Auto Gyro Gun.** `Mole.cs:13330-13368`
type-matches against BOTH `"AutoGyroGun1"`-`"5"` AND `"BarrelBot1"`-`"5"` prefab type strings in the same
sweep — adds `floor(Mole's own TAL)` to `atk` (and `def`, untracked by this tool) only, not to
tal/agi/lck. Reuses the exact same dep object AutoGyroGun's own `dmgDep` already used
(`id:"synchroMole2"`) rather than a new one, so toggling either skill's icon updates both in one render —
verified live: toggling OFF from Auto Gyro Gun's own card (`100+128(1LV)(TAL)` → `100(1LV)`) instantly
carried over to Barrel Bot Mega Punch's own Damage Formula on the next selection (ATK term dropped
128→0-contribution, `24+44+43(0.4ATK)(0.48TAL)` reflecting the OFF state) without needing to click
anything on BarrelBot's own card again.

**`mhp` correction (2026-08-21) — the earlier read of `Mole.cs:12708-12759` stopped one line too early.**
User: "fix barrelbot stat HP skillDep on HeavyBuilt and doubleBot skillDep." The 8-stat `doubleBot5`
additive block above is real and unchanged, but the SAME `hasSkill(423)` block continues one line further,
`Mole.cs:12754`: `characterControl.mhp = 10 * characterControl.vit;` — `doubleBot5` doesn't ADD to mhp the
way it does the other 8 stats, it OVERWRITES it as 10× the already-boosted `vit` (so at Mole LV 100,
vit=40+50=90 → mhp=900, not the rank-4 baseline 400). Immediately after, `Mole.cs:12765-12781` runs
`getHeavyBuiltLv()` UNCONDITIONALLY (not gated on `doubleBot5` at all) and scales whatever `mhp` currently
is: `ceil(mhp × (1+0.5×heavyBuiltLv))` — the exact same formula shape already used for King Kaiser's own
`mhp` (`Mole.cs:35936`), confirming Heavy Built (`hasSkill 361/362`, `mol_heavyBuilt1`/`2`) is a general
Mole passive scaling more than one summon's HP, not King-Kaiser-specific as first assumed. Neither
mechanism was modeled in the tool before this correction (no `mhp` field existed on `barrelBotOwnStats()`
at all until the same day's earlier "full visibility" pass, which then missed both of these).

**New `barrelBotOwnStats(doubleBotOn, synchroMoleOn, moleLV, moleTAL)` helper + `ownStats:true` flag**
(`index.html`) — overrides the tool's global ATK/TAL/AGI/LCK inputs with the computed values above for all
8 Barrel Bot `SKILLS` entries only; every other skill in the tool (including Mole's own moveset) is
unaffected, since the override only triggers when `skill.ownStats` is set. Both dep toggles
(`MOLE_DOUBLEBOT_DEP`/`MOLE_SYNCHROMOLE_BARRELBOT_DEP`) render in the Damage Formula chip header via the
same generic `renderDmgToggle`/`.sk-dep-toggle` mechanism every other dep in this tool already uses — both
default ON, matching this tool's standing "assume the passive is learned" convention.

## revisedArt5 does NOT reduce any Barrel Bot move's own cooldown (2026-08-20)

User question: "revisedArt affects BarrelBot cooldowns?" — direct answer: **no**, and this is a genuine
source-level fact, not a tool limitation.

`revisedArt5`'s 12% cooldown reduction is implemented INSIDE `CharacterControl.addTimeOut()` itself
(`CharacterControl.cs:20102-20110`), gated by a bare `this.hasSkill(424)` check at the very top of the
function — `this` is whichever `CharacterControl` instance the method is called ON, not necessarily the
player. Every one of Barrel Bot's 8 moves calls `addTimeOut` on `$self_.mChar` (confirmed at each call
site: `BarrelBot.cs:2480/2891/3286/3825/4382/4818/5278/5639`) — Barrel Bot's OWN separate
`CharacterControl` (`BarrelBot.cs:32`), the same instance already confirmed to carry its own independent
ATK/TAL/AGI/LCK block above, not a proxy for Mole's. `hasSkill()` checks `this.mSkillList`
(`CharacterControl.cs:21498-21506`), which is only ever populated via `readSkill(int[])`
(`CharacterControl.cs:24135-24166`, called when a character's learned-skill list syncs from the server) —
and `readSkill` is never called anywhere in `BarrelBot.cs`/`BarrelBotAI.cs`. Barrel Bot's own `mSkillList`
therefore stays permanently empty, so `hasSkill(424)` always evaluates `false` for its own moves,
regardless of whether the player Mole has actually learned Revised Art — the reduction can never apply.

**Contrast, confirmed rather than assumed**: the BASE `mole_barrelBot` summon entry's own 240s recast
timer IS correctly affected — its `addTimeOut` call (`Mole.cs:23429`, the shared "assemble" coroutine used
by `autoGyroGun`/`barrelBot`/`warCapital`) runs on `$self_.mChar`, and here `$self_` is the `Mole` class
instance itself (this coroutine lives directly in `Mole.cs`), so `.mChar` is Mole's own player
`CharacterControl` with a real, server-synced skill list. Same for War Factory's 5 sub-attacks — their
shared 180s structure-deploy cooldown is armed at `Mole.cs:43394`, also on `$self_.mChar` where `$self_` is
Mole itself, not a separate structure `CharacterControl` — so revisedArt correctly DOES reduce those.

**Fixed a real bug this exposed**: all 8 "Barrel Bot - X" `SKILLS` entries had shipped with
`revisedArtExempt:false` (copied from the tool's usual per-skill default), which let the revisedArt toggle
incorrectly shrink their displayed cooldowns by 12% when switched on. Flipped all 8 to
`revisedArtExempt:true`. Verified live (Playwright): toggling revisedArt changed War Factory Bazooka's
Cooldown chip `72-80s` (on) ↔ `81.7-90s` (off) — the expected `×0.88` ratio — while Barrel Bot Mega
Punch's Cooldown chip stayed fixed at `7.46-8.17s` regardless of the same toggle, confirming the fix
discriminates correctly rather than just suppressing the effect everywhere.

## Mole's own "Barrel Cannon" entry merged into Barrel Bot's "Cannon Form" (2026-08-20)

User: "remove Mole Barrel Cannon skill, use Barrel Bot - Cannon Form Skill in its place and rename the
skill to Cannon Form, use cannon form icon, this is the only move that mole can command and BarrelBot
didn't cast on their own will, so we will treat it like Mole is the caster but use BarrelBot own stats."

**Why these were two disconnected entries in the first place.** The original 27-skill Mole pass modeled
`mole_barrelCannon` as Mole's own cast (`RPC_barrelCannon`, `Mole.cs:39835-40208`) with a flat `cd:120,
ko:"1"` and no damage — at the time, the actual shell-impact formula BarrelBot fires when this cast
triggers couldn't be traced to a citable line (logged as "unresolved" in the Summary table above). That
gap was closed later the SAME session by the "Barrel Bot's own moveset" research pass, which found the
real formula (`1.5×ATK` flat, `RPC_cannon_hit`, `BarrelBot.cs:1889`) but attributed it to a NEW, separate
`SKILLS` entry (`mole_barrelBot_cannonForm`, "Barrel Bot - Cannon Form") rather than folding it back into
the original `mole_barrelCannon` row — leaving two entries describing the same real skill: one
(`mole_barrelCannon`) correctly attributed to Mole's own cast but with no damage data, the other
(`mole_barrelBot_cannonForm`) with the real damage data but framed as if Barrel Bot's AI picked it
autonomously, alongside its other 7 genuinely-autonomous moves.

**That framing was wrong for this one move specifically.** Every other Barrel Bot move (Normal Attack,
Mega Punch, Mega Hammer, Chopper, Missile, Mega Drill, the reactive single-shot Barrel Cannon) is picked
by `BarrelBotAI.cs`'s own `AI_attack(...)` dispatch — genuinely autonomous. Cannon Form is not: it only
ever starts because the PLAYER casts Mole's own "Barrel Cannon" skill (`RPC_barrelCannon`), which sets
`myCommand = "barrelCannon"` on Mole's own `mChar` and triggers the burst mode on the summon
(`Mole.cs:40196-40208`) — the AI never decides to enter Cannon Form on its own.

**Fix: deleted `mole_barrelCannon` (the empty-damage placeholder) entirely, and renamed/re-attributed
`mole_barrelBot_cannonForm` to take its place** — same `id` freed up and reused (`mole_barrelCannon`),
`name` changed to "Cannon Form" (dropping the "Barrel Bot -" prefix, matching how every other Mole-cast
skill in this roster is named — Mega Punch, Mega Hammer, Chopper, Missile, Mega Drill — even though most
of THOSE also reuse Barrel Bot's own separate move formulas for their summon-side effect), `icon` changed
from the generic shared `mole_barrelBot4` to the real, distinct skill-tree icon `mole_barrelCannon5`
(`barrelCannon5.png` — the only dedicated icon that exists for this skill; confirmed via `find
RippedAssets -iname "*cannonform*"` turning up only animation clips, no icon file, so `mole_barrelCannon5`
is genuinely the correct real asset, not a fallback). Repositioned in the `SKILLS` array to where
`mole_barrelCannon` used to sit (among Mole's own moveset, right after Mega Drill), not left among the
7 genuinely-autonomous Barrel Bot moves — array order drives the tool's arrow-key navigation.

**Immediate same-day correction, user-caught**: the first version of this merge kept the FULL `ownStats`
override (Cooldown AND damage both reading Barrel Bot's own AGI/LCK/ATK/TAL, `cd:90`,
`revisedArtExempt:true`) — copying the pattern from the other 7 genuinely-autonomous Barrel Bot moves
without re-examining it for this one case. User corrected: "since BarrelCannon skill is casted by the
Mole, revisedArt should has an effect on it, and cooldown use Mole AGI and LCK stat, but the damage
formula uses BarrelBot stat." Right call — Cannon Form's own cooldown-arming call
(`addTimeOut("barrelCannon", agiAdjust(120))`, `Mole.cs:40199`) genuinely runs on MOLE'S OWN
`CharacterControl`, not Barrel Bot's, so it should use Mole's own AGI/LCK and be revisedArt-eligible, same
as every other Mole-cast skill — only the shell's own damage payload (`RPC_cannon_hit`,
`BarrelBot.cs:1889`) runs on Barrel Bot's own `CharacterControl`.

**Fixed with a new, narrower `ownStatsDmgOnly:true` flag** (distinct from the existing `ownStats:true`
used by the other 7 Barrel Bot moves) — overrides ONLY ATK/TAL (and, via a new `bbOwnLCK` local, the
Final Damage chip's attacker-LCK `dmgAdjust` roll specifically) with Barrel Bot's own stat-block values;
AGI and the Cooldown chip's own LCK are deliberately left as the tool's normal global Mole inputs. `cd`
reverted to `120` (Mole's own cast-side cooldown) and `revisedArtExempt` flipped back to `false`. `rollOneHit`/
`renderOneDmgFormula` needed no equivalent split — neither function ever touches AGI/Cooldown at all, so
the same full TAL/LCK/ATK override `ownStats` already used remains correct for `ownStatsDmgOnly` too; only
`renderHero`'s stat-declaration block and its separate Final-Damage `attackerLCK` computation needed the
actual split.

Verified live (Playwright, local dev server) both before and after this correction: pre-correction, the
card matched the (wrong) fully-Barrel-Bot-stats version exactly — `357(1.5ATK)` formula, Cooldown
`55.92-61.28s / base 90s` (hand-verified against `agiAdjustRange(90, 60, 90)`, Barrel Bot's own rank-4
AGI/LCK), revisedArt toggle changing nothing. Post-correction: Cooldown now `54.47-60s / base 120s`
(hand-verified against `agiAdjustRange(120, 128, 128)`, the tool's own default Mole AGI/LCK inputs), and
toggling revisedArt now correctly changes it (`54.47-60s` → `48-53s`, the expected `×0.88` ratio) — while
Damage Formula/Raw Damage/Final Damage stayed byte-identical throughout every check (`357(1.5ATK)` /
`357` / `381-404`), confirming ATK and the attacker-LCK roll are still correctly reading Barrel Bot's own
stat block, unaffected by the Cooldown-side fix. Both `doubleBot`/`synchroMole2` toggle icons still
render and still drive the damage numbers. Zero console errors throughout.

## "Barrel Bot Stats" table replaces the "Exempt from revisedArt5" caption, and "Cannon Form" renamed back to "Barrel Cannon" (2026-08-20)

User: "All BarrelBot - XXXX skills, remove the text explaining revisedArt exempt, and design a stat table
displaying BarrelBot stat values, so it is more transparent for the user, this is a special case, feel
free to use the area for casttime, duration, and lckAdjust chips." Followed immediately by: "do this for
Cannon Form skill too, and also rename this skill to \"Barrel Cannon\"."

**The "text explaining revisedArt exempt" was the existing generic `<p class="sk-stat-exempt">Exempt from
revisedArt5</p>` caption** (`index.html`, rendered under the Cooldown chip whenever `revisedArtExempt:true`
— every one of the 7 remaining "Barrel Bot - X" entries has this set, per the earlier same-day
revisedArt-exemption fix) — it explained WHY the number wasn't changing, but never WHAT was actually being
used instead. Suppressed specifically for `selected.ownStats` skills (`${(selected.revisedArtExempt &&
!selected.ownStats) ? ... : ""}`) — confirmed via grep that all 7 `revisedArtExempt:true` entries in the
entire tool are exactly these 7 Barrel Bot moves, so this scoping doesn't silently affect anything else.

**New "Barrel Bot Stats" chip** fills the blank space columns 2-4 of `.sk-hero-stats` would otherwise
leave empty (no Barrel Bot move has Cast Time/Duration/LCK-proc data) — `.sk-stat-bb{grid-column:2 / span
3}`, a `.sk-stat` chip containing its own internal 4-column mini-grid (`.sk-bb-table`) of ATK/TAL/AGI/LCK
label+value pairs, sourced directly from the SAME `bb` object (`barrelBotOwnStats()`'s return value,
captured into a new `bbStatsTable` local) already driving the Cooldown/Damage chips — live-reflects the
current Double Bot/Synchro Mole toggle state for free, no separate computation to keep in sync. Verified
live (Playwright): Mega Punch's table shows `ATK 238 / TAL 90 / AGI 60 / LCK 90` at default toggle state,
matching every hand-derived value from the earlier `barrelBotOwnStats` verification passes exactly;
toggling Double Bot off live-updates to `ATK 188 / TAL 40 / AGI 10 / LCK 40`. A `getBoundingClientRect`
check on all 4 label/value pairs confirmed pixel-identical Y-alignment across columns — an apparent
misalignment in the first screenshot turned out to be the background Mole line-art (`.sk-art`) bleeding
through that region, not a real layout bug; worth remembering not to trust this tool's own decorative
backdrop art as a proxy for real layout — measure, don't eyeball, when the two might visually interact.

**Extended to "Cannon Form" (now renamed back to "Barrel Cannon")** — this skill's `ownStatsDmgOnly` only
sources ATK/TAL/attacker-LCK from Barrel Bot (AGI and the Cooldown chip's own LCK are Mole's own, per the
earlier same-day correction), so showing an AGI row would misrepresent it as Barrel-Bot-sourced. A new
`.sk-bb-table-3` CSS variant (`grid-template-columns:repeat(3, 1fr)`) renders just ATK/TAL/LCK, with a
caption spelling out the split explicitly ("Barrel Bot's own ATK/TAL/LCK for damage — Cooldown above uses
Mole's own AGI/LCK instead") rather than reusing the 4-stat caption. Verified live: `ATK 238 / TAL 90 /
LCK 90` (no AGI row), Cooldown unchanged at `54.47-60s / base 120s`, Damage Formula/Raw Damage unchanged
at `357(1.5ATK)`/`357`. `revisedArtExempt` is already `false` for this skill (Mole is the real caster for
Cooldown), so the exempt-caption suppression never applied to it anyway — no interaction with that fix.

**Rename**: `name:"Cannon Form"` → `name:"Barrel Cannon"` — "Cannon Form" was always just this tool's own
internal description of the burst-mode STATE the skill triggers, not the skill's real in-game name; the
`mole_barrelCannon5` icon this entry already uses is literally the "Barrel Cannon" skill-tree icon
(`mol_barrelCannon5`, `MoleSkill.cs`), confirming "Barrel Cannon" is the accurate name. Distinguishable
from the reactive single-shot "Barrel Bot - Barrel Cannon" entry by the missing "Barrel Bot -" prefix —
confirmed live that both appear as separate, non-colliding search suggestions.

Screenshots confirmed no clipping/overflow on either the 4-stat or 3-stat table variant at the tool's
standard viewport. Zero console errors throughout. Published to the same Artifact URL, same 🦊 favicon.

**Immediate same-day follow-up**: user asked to remove the 4-stat variant's own caption text ("Barrel
Bot's own stats, not Mole's") entirely — the "Barrel Bot Stats" chip label already says as much, making
the caption redundant. `bbCaption` now resolves to `""` for plain `ownStats` skills (the `<p
class="sk-stat-base">` element is only rendered when `bbCaption` is truthy) instead of that fixed string.
The `ownStatsDmgOnly` (Barrel Cannon) caption was deliberately left untouched — it explains a real,
non-obvious split (only some of the 3 shown stats are Barrel Bot's own; Cooldown above uses Mole's), not a
redundant restatement of the chip's own label. Verified live: Mega Punch's chip now shows just the 4-stat
table with no caption line beneath it, no leftover blank space. Published to the same Artifact URL, same
🦊 favicon.

## 2026-08-21: King Kaiser's moveset itemized — 3 new "King Kaiser - X" entries, and the 581-590 open item corrected

Resolves the open item below via a fresh `mechanics-researcher` sweep of `KingKaiser.cs` (4977 lines,
read to every method's actual end) and `KingKaiserAI.cs` (1324 lines), same "split into individual skills"
treatment already given to War Factory (5 entries) and Barrel Bot (8 entries).

**The action codes 581/582/585/589/590 cited in the open item below were a misattribution, not King
Kaiser.** `Mole.cs:46967` sits inside `$RPC_useItem$24121` (class body `Mole.cs:46782-49851`) — Mole's
generic consumable-item activation dispatcher (`f_ahb1`/`f_amb1`/`f_asb1`/`f_akb1` food/potion items,
`Mole.cs:16668-16715`), completely unrelated to King Kaiser. A full case-insensitive grep for `"kaiser"`
across the whole of `Mole.cs` returns matches only between lines 2783-36241 (all inside
`RPC_kingKaiser`/`RPC_kingKaiser_create`/`getKaiserLv`) — zero occurrences anywhere near
`RPC_useItem`'s own 46782-49851 range.

**King Kaiser's own combat entry points are the player-input handlers in `KingKaiser.cs` itself**
(`doNormalAttack`/`doBeginCharge`/`doReleaseCharge`, the same generic mount/mech input interface used by
other mount classes) — not `KingKaiserAI.cs`'s own `AI_attack`, which is **structurally unreachable**:
`Mole.cs:35865` sets `isControlled=true` unconditionally on the summoned mech, and `KingKaiserAI.cs`'s
`Update()` (`:69-72`) breaks out before ever calling `AIControl()` whenever `isControlled` is true. That
dead AI code also calls a `RPC_kaiserPunch` method that doesn't exist anywhere in `KingKaiser.cs`, and
checks an `isTimeOut("kaiserMissile")` key that `RPC_kaiserMissile`'s own cast never arms (it arms
`"nAttack"` instead) — doubly non-functional even if it were reachable. Likely vestigial from an earlier
NPC-boss iteration of this prefab; a completely separate, unrelated class pair,
`PrototypeKaiser.cs`/`PrototypeKaiserAI.cs` (spawned via `createActor` in `M705_InsideZappaBase.cs`), is
where the real `RPC_kaiserCannon`/`RPC_kaiserCannon_hit` methods live — confirming `mol_kaiserCannon1`'s
tooltip name has nothing to do with a hidden Mole-side method; it's purely the flavor name for
`kaiserMissile` (see below).

**Tier system, confirmed**: `getKaiserLv()` (`Mole.cs:13607-13646`) → `hasSkill(373)`→3
(`mol_kaiserBeam1`), `hasSkill(372)`→2 (`mol_kaiserCannon1`), `hasSkill(371)`→1 (`mol_kingKaiser1`), else
0. Own stat block, `summon(int nLv)` (`KingKaiser.cs:3991-3997`) — the ONLY 2 stats ever touched by any
code in `KingKaiser.cs`: `atk = 150+50×nLv`, `def = 100+50×nLv` (tier 1/2/3 → ATK 200/250/300, DEF
150/200/250). TAL/AGI/LCK (75/200/200, already in the tool's `kingKaiserOwnStats()`) are real,
hex-decoded prefab defaults from a prior pass — not re-derived or contradicted, just confirmed unused by
any King Kaiser formula (zero `talAdjust`/`agiAdjust`/`lckAdjust` calls anywhere in the file). Base HP
1500 (tooltip-confirmed, `MoleSkill_eng.cs:851`), scaled by Mole's Heavy Built passive
(`getHeavyBuiltLv()`, `Mole.cs:13213-13216`, hasSkill 361/362) — `hp = ceil(hp×(1+0.5×heavyBuiltLv))`,
matching the +50%/+100% tooltip text exactly. Cast consumes 1 Kaiser Battery item (`m_kbt1`,
`Mole.cs:7007`/`:35684`).

**3 new `SKILLS` entries, all `ownStatsKaiser:true`, all `revisedArtExempt:true`** (King Kaiser's own
`CharacterControl` never calls `hasSkill` at all — zero hits, full-file grep — so `revisedArt5` cannot
structurally reach any of its cooldowns, same "own empty skill list" gap already found for Barrel Bot):

- **King Kaiser - Normal Attack** (`mole_kingKaiser_nAttack`) — real 3-swing melee combo, each swing its
  own `hit()` call: 1.0×ATK / 1.2×ATK / 1.3×ATK (`KingKaiser.cs:1680/1885/2031`), KO=1 each. Modeled as a
  3-entry `dmgGroups` (the tool's first `dmgGroups` skill to also need a per-group `atkCoeff` — a small
  engine extension, `resolveHitDmgAtkCoeff`, added alongside the pre-existing per-group `dmg` lookup).
  Cooldown flat `4s`, NOT `agiAdjust`-wrapped (`KingKaiser.cs:2179`) — **shared with Kaiser Missile below**
  (same `"nAttack"` timeout key re-armed by both, `KingKaiser.cs:2711`), confirmed via a full-file
  `addTimeOut`/`isTimeOut` grep (only 2 distinct keys exist in the whole file: `"nAttack"`,
  `"kaiserBeam"`).
- **King Kaiser - Kaiser Missile** (`mole_kingKaiser_missile`) — real name per tooltip is "Kaiser Cannon"
  (`mol_kaiserCannon1`'s own text, `MoleSkill_eng.cs:862`: *"shoot cannons at target from a distance"*),
  the internal method is `kaiserMissile`. 4-missile volley (2 sequential volleys of 2,
  `KingKaiser.cs:2489-2604`), each impact an AoE scan (radius 5) hitting everyone in range for flat 100
  (no ATK/TAL scaling), KO=5 (`RPC_kaiserMissile_hit`, `KingKaiser.cs:1331`). Requires tier ≥2 — the
  player's attack-click handler routes to Missile instead of melee only when `mLv>1` AND target distance
  &gt;10 (`KingKaiser.cs:951-984`). Icon corrected from the shared generic `mole_kingKaiser1` to the real,
  distinct `mole_kaiserCannon4` (`RippedAssets/.../mole/kaiserCannon4.png`, byte-verified) — matches the
  in-game "Kaiser Cannon" display name exactly, unlike the internal `kaiserMissile` method name.
- **King Kaiser - Kaiser Beam** (`mole_kingKaiser_beam`) — charge-and-release, 3 RPC methods:
  `kaiserBeam1` (begin charge, no damage, `KingKaiser.cs:2796-3113`) → held ≥6.5s →
  `kaiserBeam2` (full release, real damage) or released early → `kaiserBeam0` (abort, confirmed zero
  damage by exhaustive absence of any `hit()`/`RPC_AddDamage` call in its own class body,
  `KingKaiser.cs:3624-3816`). Full release: a REAL loop, bound traced via state transitions (not textual
  occurrence count — same care already documented for Roller Machine's own loop-count correction) —
  `i=0` init (`:3269`), `i++` (`:3296`), exit `i>=5` (`:3501`) → exactly 5 forward-corridor pulses, flat
  300 damage each (no ATK/TAL scaling), KO=1, hate=1 (unusual — every other King Kaiser hit passes
  `nHate=0`) — `KingKaiser.cs:3538`. Requires tier ≥3 AND 75 SP. Cooldown shown (`30s` flat, re-armed on
  full release, `KingKaiser.cs:3426`) is genuinely never gated by `isTimeOut` anywhere in the file (only
  `"nAttack"` ever is) — flagged as likely vestigial in practice, with the 75 SP cost (naturally
  regenerating) acting as the real soft throttle. Icon corrected to the real, distinct
  `mole_kaiserBeam4` (byte-verified), same reasoning as Kaiser Missile above.

Verified: script-block syntax parse clean (`new Function(js)`), both new icon extractions byte-exact
against their `RippedAssets` source files (`Buffer.compare`), no stale `mole_kingKaiser1` icon reference
remaining on either Missile or Beam. Not yet visually verified live (no browser tool available this
session) — do a real visual pass (3-swing combo formula rendering, both new icons displaying, Final
Damage's dmgGroups-summed total for Normal Attack, Beam's "Test 5 hits" Simulate button) before treating
this as fully done, same standing caveat every no-browser session in this file already carries.

## Open items / could not verify

_(the King Kaiser open item previously listed here was resolved above, 2026-08-21)_

See `player-reference-tool/CLAUDE.md` for the full code-level detail across every dated pass in this
file (the `atkCoeff`/`dmgAdjustSkip`/`dmgReplaceDep`/`dmgGroups` engine extensions, every live-Playwright
verification, and remaining open TODOs).
