# Mole — Skill Cooldown/Duration Reference

Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/bible/index.html`).
Scope: this table lists active skills (has a real cooldown), max rank only. Passive/no-cooldown skills have no row here because they have no cooldown to report, but they are not excluded from documentation — their mechanics belong in this file's "Damage & Mechanics" section below.

| Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
|---|---|---|---|---|---|---|---|
| reload | Reload | 2 | 240 | true | false | — | — |
| mine | Landmine | 4 | 15 | true | false | 60 | true |
| mortarShot | Mortar Shot | 2 | 30 | true | false | — | — |
| bunker | Bunker | 2 | 30 | true | false | — | — |
| tnt | TNT | 4 | 90 | true | false | — | — |
| stunMine | Stun Mine | 2 | 45 | true | false | 60 | true |
| stunGrenade | Stun Grenade | 2 | 60 | true | false | — | — |
| flameTurret | Flame Turret | 3 | 120 | true | false | 5 | true |
| fireBarrage | Fire Barrage | 2 | 120 | true | false | — | — |
| bombardment | Bombardment | 2 | 180 | true | false | — | — |
| timeNuke | Time Nuke | 2 | 360 | true | false | 60 | false |
| detonate | Detonate | 1 | 360 | true | false | — | — |
| autoGyroGun | Auto Gyro Gun | 4 | 30 | true | false | 120 | true |
| barrelBot | Barrel Bot | 4 | 240 | true | false | ∞ | — |
| megaPunch | Mega Punch | 2 | 30 | true | false | — | — |
| megaHammer | Mega Hammer | 2 | 30 | true | false | — | — |
| chopper | Chopper | 3 | 45 | true | false | — | — |
| missile | Missile | 4 | 60 | true | false | — | — |
| synchroMole | Synchro Mole | 2 | 300 | true | false | 30 | true |
| kingKaiser | King Kaiser | 1 | 999 | true | false | 240 | true |
| advanceRepair | Advance Repair | 1 | 30 | true | false | — | — |
| napalm | Napalm | 1 | 150 | true | false | — | — |
| grenadeCluster | Grenade Cluster | 1 | 120 | true | false | — | — |
| flameCarnival | Flame Carnival | 1 | 150 | true | false | 90 | true |
| megaDrill | Mega Drill | 1 | 30 | true | false | — | — |
| barrelCannon | Barrel Cannon | 1 | 120 | true | false | — | — |
| warFactory | War Factory | 1 | 180 | true | false | — | — |
| warCapital | War Capital | 1 | 300 | true | false | — | — |

## Citations

### Notes on judgment calls

- **Out of scope for this table:** the 12 shared support skills (`stunningGround` … `divineChannel`, flat `addTimeOut(…, 600)` handlers in `Mole.cs:14797-45722`; `mineWalker` is one of them, not a Mole skill), `mount` (`Mole.cs:50251`, universal), and the passives listed below. `nAttack`/`cAttack` have their own 1-1.5 s locks and are covered in Damage & Mechanics.
- **TNT** is four separate casts (#221-224) with their own keys `"tnt" + n` and the same `agiAdjust(90)` (`Mole.cs:26180`); one row, max rank 4.
- **Auto Gyro Gun, Barrel Bot and War Capital** share the assemble coroutine `$RPC_assemble1$23522` (`Mole.cs:22908-23596`): cast time `magAdjust(1 + sLv)` / `magAdjust(3 + sLv)` / `magAdjust(24)` and CD `agiAdjust(30 / 240 / 300)` (`Mole.cs:23353-23429`). No other Mole skill has a cast time.
- **Mine Lover** replaces the Landmine and Stun Mine base cooldowns (15 → 8, 45 → 23; `Mole.cs:23891-23905`, `:26680-26694`); the table shows the base.
- **Fire Barrage / Bombardment** also set `addTimeOut(key, 0.5)` inside their wait loops (`Mole.cs:28748`, `:29629`); that is a sequencing lock, not the cooldown.
- **Durations that are not `RPC_AddStatus`:** Flame Turret's channel `chaAdjust(5)` (`Mole.cs:27935`, checked at `:27984`); Time Nuke's fixed 60 s fuse (`Mole_timeNuke.cs:56`, `:241`); Auto Gyro Gun's life `chaAdjust(120)` (`Mole.cs:12235`); Landmine `chaAdjust(60)` (`Mole_mine.cs:60`); Flame Carnival's trap `chaAdjust(90)` (`Mole_flameCarnival.cs:53`) — the trap's wait time, not the 20-pulse fire. King Kaiser uses `addStatus("transform" / "hide", 1, chaAdjust(240))` (`Mole.cs:35789`, `:36023`, `:36135`); its cast-time `noForce` 5 s (`:35401`) is not the duration. Barrel Bot has no timer (∞; destroyed only on death or when its creator is gone, `BarrelBot.cs:179-260`). Advance Repair is a channel with no fixed length.
- **Stun Mine duration (live correction):** the decompile reads `talAdjust(60)` (`Mole_stunMine.cs:60`), but the live game uses `chaAdjust(60)` (user-confirmed 2026-08-14); the table follows live.
- **War Factory** is one cast that steps through five weapons in order (see `mol_warFactory5` below). The 180 s cooldown is armed only after Cart Bomb (`Mole.cs:43394`); the other four arm `agiAdjust(3)`.
- **No duration** (no status / prop lifetime of their own): Reload, Mortar Shot, Bunker (held until you move), TNT, Stun Grenade, Fire Barrage, Bombardment, Detonate, Mega Punch, Mega Hammer, Chopper, Missile, Napalm, Grenade Cluster, Mega Drill, Barrel Cannon, War Factory, War Capital.
- **Passives (no row):** Gadgeteer, Stat Plus, Super Stat Plus, Extra Powder, Smart Shell, Kaiser Cannon, Kaiser Beam, Cannon Expert, Super Dig, Genius Invention, Mine Lover, Super TNT, Hidden Turret, Sky Shaker, Double Bot, Revised Skill / Magic / Art, Heavy Built, Speed Drill, Sky Drill.

### CD citations
- `reload` CD: `Mole.cs:10316` — `this.mChar.addTimeOut("reload", this.mChar.agiAdjust((float)240));`
- `mine` CD: `Mole.cs:23905` — `this.$self_$23546.mChar.addTimeOut("mine", this.$self_$23546.mChar.agiAdjust((float)15));` (base; `Mole.cs:23897` sets `8` when `hasSkill(402)` — see judgment-call note)
- `mortarShot` CD: `Mole.cs:24792` — `this.$self_$23575.mChar.addTimeOut("mortarShot", this.$self_$23575.mChar.agiAdjust((float)30));`
- `bunker` CD: `Mole.cs:25319` — `this.$self_$23586.mChar.addTimeOut("bunker", this.$self_$23586.mChar.agiAdjust((float)30));`
- `tnt` CD: `Mole.cs:26180` — `this.$self_$23605.mChar.addTimeOut("tnt" + this.$sLv$23604, this.$self_$23605.mChar.agiAdjust((float)90));` (flat regardless of sLv 1-4; see judgment-call note)
- `stunMine` CD: `Mole.cs:26694` — `this.$self_$23614.mChar.addTimeOut("stunMine", this.$self_$23614.mChar.agiAdjust((float)45));` (base; `Mole.cs:26686` sets `23` when `hasSkill(402)`)
- `stunGrenade` CD: `Mole.cs:27516` — `this.$self_$23642.mChar.addTimeOut("stunGrenade", this.$self_$23642.mChar.agiAdjust((float)60));`
- `flameTurret` CD: `Mole.cs:28225` — `this.$self_$23661.mChar.addTimeOut("flameTurret", this.$self_$23661.mChar.agiAdjust((float)120));`
- `fireBarrage` CD: `Mole.cs:28602` — `this.$self_$23671.mChar.addTimeOut("fireBarrage", this.$self_$23671.mChar.agiAdjust((float)120));`
- `bombardment` CD: `Mole.cs:29483` — `this.$self_$23698.mChar.addTimeOut("bombardment", this.$self_$23698.mChar.agiAdjust((float)180));`
- `timeNuke` CD: `Mole.cs:30786` — `this.$self_$23734.mChar.addTimeOut("timeNuke", this.$self_$23734.mChar.agiAdjust((float)360));`
- `detonate` CD: `Mole.cs:31268` — `this.$self_$23743.mChar.addTimeOut("detonate", this.$self_$23743.mChar.agiAdjust((float)360));`
- `autoGyroGun` CD: `Mole.cs:23429` — `this.$self_$23536.mChar.addTimeOut(this.$sType$23532, this.$self_$23536.mChar.agiAdjust((float)this.$mTimeOut$23524));` with `$mTimeOut$23524 = 30` set at `Mole.cs:23364` (shared `assemble` coroutine — see judgment-call note)
- `barrelBot` CD: `Mole.cs:23429` (shared, see above) with `$mTimeOut$23524 = 240` set at `Mole.cs:23381`
- `megaPunch` CD: `Mole.cs:32662` — `this.$self_$23778.mChar.addTimeOut("megaPunch", this.$self_$23778.mChar.agiAdjust(30f));`
- `megaHammer` CD: `Mole.cs:33228` — `this.$self_$23794.mChar.addTimeOut("megaHammer", this.$self_$23794.mChar.agiAdjust(30f));`
- `chopper` CD: `Mole.cs:34019` — `this.$self_$23813.mChar.addTimeOut("chopper", this.$self_$23813.mChar.agiAdjust(45f));`
- `missile` CD: `Mole.cs:34777` — `this.$self_$23834.mChar.addTimeOut("missile", this.$self_$23834.mChar.agiAdjust((float)60));`
- `synchroMole` CD: `Mole.cs:13228` — `this.mChar.addTimeOut("synchroMole", this.mChar.agiAdjust((float)300));`
- `kingKaiser` CD: `Mole.cs:35380` — `this.$self_$23845.mChar.addTimeOut("kingKaiser", this.$self_$23845.mChar.agiAdjust((float)999));`
- `advanceRepair` CD: `Mole.cs:36716` — `this.$self_$23874.mChar.addTimeOut("advanceRepair", this.$self_$23874.mChar.agiAdjust((float)30));`
- `napalm` CD: `Mole.cs:37392` — `this.$self_$23891.mChar.addTimeOut("napalm", this.$self_$23891.mChar.agiAdjust((float)150));`
- `grenadeCluster` CD: `Mole.cs:38123` — `this.$self_$23917.mChar.addTimeOut("grenadeCluster", this.$self_$23917.mChar.agiAdjust((float)120));`
- `flameCarnival` CD: `Mole.cs:38662` — `this.$self_$23926.mChar.addTimeOut("flameCarnival", this.$self_$23926.mChar.agiAdjust((float)150));`
- `megaDrill` CD: `Mole.cs:39724` — `this.$self_$23959.mChar.addTimeOut("megaDrill", this.$self_$23959.mChar.agiAdjust(30f));`
- `barrelCannon` CD: `Mole.cs:40199` — `this.$self_$23971.mChar.addTimeOut("barrelCannon", this.$self_$23971.mChar.agiAdjust(120f));`
- `warFactory` CD: `Mole.cs:43394` — `this.$self_$24038.mChar.addTimeOut("warFactory", this.$self_$24038.mChar.agiAdjust((float)180));` (after the 5th weapon, Cart Bomb; steps 1-4 arm `agiAdjust(3)` at `Mole.cs:40814`, `41388`, `41900`, `42687`; spawn preset at `Mole.cs:118`)
- `warCapital` CD: `Mole.cs:23429` (shared `assemble` coroutine, see `autoGyroGun` above) with `$mTimeOut$23524 = 300` set at `Mole.cs:23398` (matching preemptive set at `Mole.cs:121`)

### Duration citations
- `flameTurret` Duration: `Mole.cs:27935` — `this.$mDuration$23650 = (float)this.$self_$23661.mChar.chaAdjust(5);` (channel-lifetime field gating `Mole.cs:27984`, not `RPC_AddStatus` — see judgment-call note)
- `timeNuke` Duration: `Mole_timeNuke.cs:56` — `this.DOBdTpEK5v = Time.time;`, fuse checked at `Mole_timeNuke.cs:241` — `if (this.DOBdTpEK5v + (float)60 <= Time.time + (float)1)` (flat literal `60`, confirmed NOT Adjust-wrapped — spawned-prop fuse timer, see judgment-call note)
- `synchroMole` Duration: `Mole.cs:13242` — `this.mChar.RPC_AddStatus("synchroMole", sLv, num, this.mChar.tal, this.mChar.ActorNr);` with `num = this.mChar.chaAdjust(30)` set at `Mole.cs:13237` (self-buff, not target-contested)
- `kingKaiser` Duration: `Mole.cs:36023` — `this.$tChar$23853.StartCoroutine_Auto(this.$tChar$23853.addStatus("transform", 1, this.$mDuration$23851, 0, this.$self_$23861.mChar.ActorNr));` and `Mole.cs:36135` — `this.$self_$23861.mChar.StartCoroutine_Auto(this.$self_$23861.mChar.addStatus("hide", 1, this.$mDuration$23851, 0, this.$self_$23861.mChar.ActorNr));`, with `$mDuration$23851 = this.$self_$23861.mChar.chaAdjust(240)` set at `Mole.cs:35789` (`addStatus`, not literally `RPC_AddStatus` — see judgment-call note)
- `autoGyroGun` Duration (summon lifetime, not `RPC_AddStatus`): `Mole.cs:12235` — `autoGyroGun.StartCoroutine_Auto(autoGyroGun.create(this.mChar, this.mChar.ActorNr, this.mChar.chaAdjust(120)));` — see the dedicated judgment-call note above.
- `barrelBot`: re-checked and confirmed to have no timed lifetime at all (HP/disconnect-based instead) — see the dedicated judgment-call note above. Duration cell is `∞`.
- `mine` Duration (prop lifetime, not `RPC_AddStatus`): `Mole.cs:24233` → `Mole_mine.cs:60` — `this.aO9boyDZyA = (int)((float)this.lwlbygsWTr.chaAdjust(60) + Time.time);` — see the dedicated judgment-call note above.
- `stunMine` Duration (prop lifetime, not `RPC_AddStatus`): decompiled source at `Mole.cs:27019` → `Mole_stunMine.cs:60` still reads `this.XYwd2vIXAX = (int)((float)this.MAZdRGaitt.talAdjust(60) + Time.time);` (`talAdjust`), but the live server has since been patched to `chaAdjust(60)` per user confirmation 2026-08-14 — reported as `chaAdjust`/`durWrapped:true` now. See the dedicated judgment-call note above.
- `reload`, `mortarShot`, `bunker`, `tnt`, `stunGrenade`, `fireBarrage`, `bombardment`,
  `detonate`, `megaPunch`, `megaHammer`, `chopper`, `missile`,
  `advanceRepair`, `napalm`, `grenadeCluster`, `megaDrill`, `barrelCannon`, `warFactory`,
  `warCapital`: no usable Duration — no `RPC_AddStatus`/`addStatus`/field-effect-lifetime call exists in
  the skill's own coroutine class body; see the bulk judgment-call notes above (`advanceRepair`'s channel
  mechanic has its own note). Duration
  cells are `—`.
- `flameCarnival` Duration (unarmed-trap arming window, not the fire's own burn time — see the dedicated
  judgment-call note above): `Mole.cs:38518,38559` → `Mole_flameCarnival.cs:53` —
  `this.X83bE9HJAd = (int)((float)this.wZxb0yFo8I.chaAdjust(90) + Time.time);`

---

# Damage & Mechanics

Per-skill entries (`### mol_<name>`) are the verified 2026-10-01 pass; they take precedence over anything older in this file. Command numbers come from `MoleSkill.cs` `getSkillTree()`; costs and requirements were decoded with `scripts/decode_skilldata.py`. Line numbers are `DecompiledSource/Mole.cs` unless another file is named.

### mol_nAttack1-4 (Combo, #101-104): one cannon shell per stage (verified 2026-10-01)

- Passive, Lv/Bn 1/0, 2/1, 3/2, 4/3. Stage `n + 1` needs #10n and a press within the stage window (`doNormalAttack`, `:9515-9800`); `addTimeOut("nAttack", 1.5)` (`:20602`, `:20901`). Up to 5 shells at Combo 4.
- Each stage fires one `RPC_nAttack_fire` shell (`:20473`, `:21235`), `ProjectileControl.life = 10 × rangeMod` (`:10089`), speed 15 (`Mole_nAttack.cs:20-34`). Star Cannon (`w_mol59`) fires two shells at ±9° instead (`:20419-20464`).
- **Hit (`Mole_nAttack.cs:90-175`):** on touching an enemy, `num = (int)((0.5 + 0.1 if Cannon Expert #401) × ATK)`, `floor(0.75 ×)` with `w_mol59`, then `mole.getCritPlus(num)` (standard Marshal 12 / Champion 18 table, `:19229-19378`); explosion `FindAreaTarget(point, (4 + ExtraPowderLv) × rangeMod, 4)`; each target takes `hit(1, t, floor(num × (1 − 0.5 × d / r)), KO 1, …)` (falloff `0.25` with Cannon Expert), `onNormalAttackHit`, `sp++`.
- **Card:** `atkCoeff` 0.5 / 0.6 with Cannon Expert, hit count Combo + 1, `critProc` with gear deps; value is the centre of the blast.

### mol_cAttack1-3 (Charge Attack, #111-113): burrow (verified 2026-10-01)

- Passive, Lv/Bn 4/1, 10/2, 16/3. `getChargeAttackLv()` 0-3 (`:10110`).
- `RPC_cAttack1` (`:21411-22647`): dig-in time `1.9 − 0.5 × SpeedDrill` s, `1 − 0.2 × SpeedDrill` with Super Dig #411 (`:21609`, `:22186`); underground `moveSpeed` lerps to `2 + 1.5 × SpeedDrill` (`:21818`), renderers hidden and collision with players ignored; every 0.2 s `removeLockStatus(2 × chargeLv − 1)` (`:21755-21769`); auto-surfaces after `4 × chargeLv` s (`digTimeOut`, `:21553`, `:21716`). Super Dig: `RPC_AddHeal(411, ceil(0.01 × mhp))` every 2 s while under and below max HP, real game modes only (`:21823-21860`). No damage immunity was found for the underground state (only hidden + no player collision).
- Release (`doReleaseCharge`, `:9938-10060`): Sky Drill when learned and underground for more than 3 s (see Sky Drill), else `RPC_cAttack0`.
- Tooltips: "max 4/8/12 sec" matches; English "lv2/3/4 lock" vs code levels 1/3/5 (`2 × rank − 1`), Thai "ต่ำกว่า 2/4/6" matches the code.

### mol_gadgeteer1-4 (Gadgeteer, #121-124) (verified 2026-10-01)

- Passive. Only read by the Workshop (`CompoundGui.cs:1190-1250`): each of #121-124 and Genius Invention #421 adds one tier to the Mole compound message index (`Language.getMessage("CompoundGui", 400 + n)`). Tooltip "toy lv 10/20/30/40". Not a combat skill. (`CharacterControl.cs` 121-124 hooks are Sheep/Penguin/Panda code.)

### mol_reload1-2 (Reload, #131-132) (verified 2026-10-01)

- MP 15/30, Lv/Bn 32/6, 40/10, instant. CD `agiAdjust(240)`.
- `RPC_reload` (`:10168-10300`): `removeTimeOut` on mine, mortarShot, bunker, tnt1-4, stunMine, stunGrenade, autoGyroGun, barrelBot, megaPunch, megaHammer; at rank 2 also flameTurret, fireBarrage, bombardment, timeNuke, detonate, chopper, missile, synchroMole, kingKaiser; with Advance Repair #431 also advanceRepair, grenadeCluster, napalm, flameCarnival, megaDrill, barrelCannon, warFactory, warCapital. Then `sp = Clamp(sp + ceil(0.5 × sLv × msp), 0, 100)`.

### mol_mortarShot1-2 (Mortar Shot, #211-212) (verified 2026-10-01)

- SP 12/15 **blue** (threshold), Lv/Bn 5/1, 11/3, target. CD `agiAdjust(30)` (`:24792`). The card's former SP 12/16 was wrong.
- `RPC_mortarShot` (`:24470-25102`): `2 × sLv + 1` shells (`:24927`), 0.1 s apart; shell speed 20, `life = 5 × rangeMod` (`Mole_mortarShot.cs:19-49`, `:10745-10803`).
- `RPC_mortarShot_hit` (`:10804-10946`): `FindAreaTarget(point, 4 + ExtraPowderLv, 4)`, `floor((1 − 0.5 × d / r) × (0.5 × ATK + talAdjust(15)))`, ×2 on `eRace.Structure`, `hit(1, t, …, KO 1)`, `sp + 1`.

### mol_bunker1-2 (Bunker, #213-214) (verified 2026-10-01)

- SP −5/−10 (red), Lv/Bn 17/5, 23/7, instant. CD `agiAdjust(30)` (`:25319`). Holds (`myCommand = "bunker" + sLv`) until a movement key is pressed (`:25509-25537`).
- In the Mole's `RPC_AddDamage` (`CharacterControl.cs:4636-4672`, after `hitMod`): `bunker1` `nDamage = ceil(0.5 ×)`, `bunker2` `ceil(0.25 ×)`, `nKo = 0`. Effect Damage is not reduced.

### mol_tnt1-4 (TNT, #221-224) (verified 2026-10-01)

- SP −10 (red) at every rank, Lv/Bn 7/2, 13/4, 19/6, 25/8. The card's former SP 10/15/20/25 was wrong. Each rank is its own cast with its own cooldown key `"tnt" + n`, `agiAdjust(90)` (`:26180`).
- `RPC_tnt` (`:25639-26390`): TNT at `8 × n` m ahead (`:25846`); `mTntLv` = highest TNT owned (`:25989-26013`); `hitDmg = talAdjust((int)(20 + 10 × mTntLv + (Super TNT #422 ? (0.1 × n + 0.1) × Lv : 0)))` (`:26048`), `n` = the TNT being cast; `FindAreaTarget(pos, (4 + ExtraPowderLv) × rangeMod, 3 × rangeMod)`; `hit(220 + mTntLv, t, (int)((1 − 0.5 × d / r) × hitDmg), KO 5, …)`, `sp + 1`.
- **Card correction:** Super TNT is inside `talAdjust` and uses the cast TNT's own `n` (0.2 / 0.3 / 0.4 / 0.5 × Lv), not a flat 0.5 Lv added afterwards.

### mol_superTNT5 (Super TNT, #422) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. The TNT term above. **Tooltip discrepancy:** "+40 damage and 2 m radius"; no radius change in code.

### mol_extraPowder1-3 (Extra Powder, #261-263) (verified 2026-10-01)

- Passive, Lv/Bn 24/15, 28/18, 30/21. `getExtraPowderLv()` 0-3 (`:11438-11480`). Radius `4 + lv`: Combo (`Mole_nAttack.cs:218`), Landmine (`:10575`), Mortar Shot (`:10850`), Stun Mine (`:11072`), Smart Shell (`:11535`), TNT (`:26033`), Bombardment (`:30323-30373`), Napalm (`:37669`); Time Nuke `20 + lv` (`Mole_timeNuke.cs:882`); Cart Bomb `6 + 1.5 × lv` (`:14177`); Grenade Cluster `(int)(4 + 0.5 × lv)` (`Mole_grenadeCluster.cs:179`).

Companion to `mole-skill-reference.md` (cooldown/duration/maxRank — trusted as-is below, not
re-derived here except where flagged). This doc backs the rank-selector + damage-formula fields
(`maxRank`, per-rank `cd`/`castTime`/`duration` arrays, `dmg`, `dmgDep`/`dmgMultDep`, `atkCoeff`,
`hitCount`/`hitCountDuration`) added to Mole's `SKILLS` entries in
`12t_projects/bible/index.html`, 2026-08-18 — the first class built out beyond the
original Penguin pilot (see that project's own `CLAUDE.md`, "Rank selector + damage formula — Penguin
pilot"). Researched via a `mechanics-researcher` subagent sweep of `DecompiledSource/Mole.cs`,
`DecompiledSource/MoleSkill.cs`, `DecompiledSource/MoleSkill_eng.cs`, and `Mole_<skill>.cs` companion
files. All citations are `file:line` against `DecompiledSource/Mole.cs` unless noted.

**A genuinely new formula shape found here, not seen in Penguin's damage skills**: several Mole skills
add a flat coefficient of the caster's own **ATK** stat on top of `talAdjust(...)` — e.g. Mega Punch's
`0.5×ATK + talAdjust(10×sLv)`. The tool's rendering/calc engine only understood `talAdjust(...)`-wrapped
or flat expressions before this pass; a new `atkCoeff` field (paired with the pre-existing but
previously-unexercised `--stat-atk` CSS token) was added to `renderDmgFormula`, `rollOneHit`, and the
Raw Damage calc chip to support it (the app's history is in git).

### mol_mine1-4 (Landmine, #201-204) (verified 2026-10-01)

- MP 3/5/7/9, Lv/Bn 3/0, 9/1, 15/2, 21/3, instant. CD `agiAdjust(15)`, `agiAdjust(8)` with Mine Lover #402 (`:23891-23905`).
- Mine prop `Mole_mine` lives `chaAdjust(60)` s (`Mole_mine.cs:38`) and triggers on a `Player`/`Enemy` collider of another layer (`:192-201`).
- `RPC_mine_hit` (`:10529-10738`): `FindAreaTarget(pos, 4 + ExtraPowderLv, 4)` (enemy layers); `num = talAdjust(10 × sLv + 10)`, `floor(1.25 ×)` with Mine Lover; every target **without `insight`** takes `hit(200 + sLv, t, num, KO 1, …)` — no distance falloff; then the triggered mine is destroyed. Smart Shell: `RPC_smartShell_hit` (see Smart Shell).
- Tooltip "10/20/30/40 dmg"; code base 20/30/40/50.

### mol_stunMine1-2 (Stun Mine, #231-232) (verified 2026-10-01)

- **MP 5/10, no SP**, Lv/Bn 9/3, 15/5. The card's former 5 MP + SP 10/15 was wrong. CD `agiAdjust(45)`, `agiAdjust(23)` with Mine Lover (`:26680-26694`).
- `RPC_stunMine_hit` (`:11026-11265`): `FindAreaTarget(pos, 4 + ExtraPowderLv, 4, 130816)` — **every character layer**, so allies and the Mole are included; KO `10 × (sLv + (Grenade Cluster #432 ? 1 : 0))`, `floor(1.25 ×)` with Mine Lover; `hit(242 + sLv, t, 0, KO, …)` on every target without `insight`; with Smart Shell a same-layer target gets `KO 5 × sLv` instead. **No status is applied** (no `RPC_AddStatus` in Mole for it; the old card note "3 s paralysis" had no source).

### mol_stunGrenade1-2 (Stun Grenade, #233-234) (verified 2026-10-01)

- MP 5/10, SP −10/−15 (red), Lv/Bn 21/7, 27/9. CD `agiAdjust(60)` (`:27516`).
- Projectile speed 15, `life = 3 × rangeMod` (`Mole_stunGrenade.cs:28-92`, `:11272-11345`), `mLv = sLv + GrenadeCluster`. On contact: `FindAreaTarget(point, 6 × rangeMod, 4, 130816)` (every layer, no `insight` check); `hit(242 + mLv, t, 0, KO 10 × mLv, …)`; with Smart Shell same-layer targets get `KO 5 × mLv` and enemy-layer targets also `RPC_AddEffectDamage(264, 30)` (`Mole_stunGrenade.cs:200-290`).

### mol_smartShell1 (Smart Shell, #264) (verified 2026-10-01)

- Passive, Lv 33/Bn 24. The +30 Effect Damage and same-layer halving are documented in the Class C passive sweep below (re-checked this pass). Flame Carnival: halving only (`:39113-39125`).

### mol_mineLover5 (Mine Lover, #402) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. Landmine damage `floor(1.25 ×)` (`:10614-10620`) and base CD 15 → 8; Stun Mine KO `floor(1.25 ×)` and base CD 45 → 23. Tooltip "+50% and −50%" vs code ×1.25 and the replaced cooldowns.

### mol_grenadeCluster5 (Grenade Cluster, #432) (verified 2026-10-01)

- MP 10, SP −40 (red), Lv 75/Bn 4, instant. CD `agiAdjust(120)` (`:38123`).
- `RPC_grenadeCluster` (`:37853-38333`): 8 grenades (`i < 8`, `:38002`), each `rotateH(forward + random tilt, 45 × i)` (`:38009`); speed 6, `life = 5 × rangeMod` (`Mole_grenadeCluster.cs:28-88`, `:13787-13841`). On the first enemy contact: radius `(int)(4 + 0.5 × ExtraPowderLv)` (`:179`), height 3; `floor((1 − 0.5 × d / r) × (ATK + talAdjust(30)))`, `hit(342, t, …, KO 10, …)`. No crit. A target is normally reached by one grenade.
- Passive part: Stun Mine / Stun Grenade KO level +1 (above).

### mol_timeNuke1-2 (Time Nuke, #271-272) (verified 2026-10-01)

- MP 45/60, SP −45/−60 (red), Lv/Bn 35/23, 40/25. CD `agiAdjust(360)` (`:30786`).
- `Mole_timeNuke` (993 lines): fixed 60 s countdown with an on-screen timer (`:29-75`); then `$detonate` (`:129-370`): `mDamage = talAdjust(100 × mLv + 50)` (`:334`), range `R = 20 + ExtraPowderLv` (`:882`), mask `130818` (every layer, `:892`); 4 rings 0.1 s apart (`i < 4`, `:279`), ring `i` = `FindAreaTarget(pos, floor(0.25 × (i + 1) × R), 5)`; each target without `insight` takes `hit(270 + mLv, t, floor(mDamage × (1 − 0.8 × d / R)), KO 3, …)` — halved for same-layer targets and `+ RPC_AddEffectDamage(264, 30)` for others when Smart Shell is learned (`:297-317`). Without Smart Shell allies and the Mole take the full hit. A target within `0.25 R` of the centre is in all 4 rings.

### mol_detonate1 (Detonate, #273) (verified 2026-10-01)

- MP 24, SP −24 (red), Lv 45/Bn 27. CD `agiAdjust(360)` (`:31268`). Refused with "Cannot find TimeNuke to detonate" and MP/SP returned when no Time Nuke exists (`doSkill`, `Mole.cs:6740-6750`). Detonating early: `mDamage = floor(mDamage × Clamp(elapsedWholeSeconds × 0.0166, 0.1, 0.99))` (`Mole_timeNuke.cs:185`, `:336`).

### mol_flameCarnival5 (Flame Carnival, #442) (verified 2026-10-01)

- **MP 35**, no SP, Lv 85/Bn 6. The card's former "free" cost was wrong. CD `agiAdjust(150)` (`:38662`).
- Trap prop lives `chaAdjust(90)` (`Mole_flameCarnival.cs:30`), fires `RPC_flameCarnival_fire` on an enemy-layer contact (`:69-79`). Fire (`:38844-39324`): 20 pulses (`i < 20`, `:39033`), `FindAreaTarget(pos, Clamp(2 + i, 3, 5), 2, 130816)` (every layer); each target without `insight` and not `Robots`/`Structure` takes direct `RPC_AddDamage(442, talAdjust(10), …)` (no `dmgAdjust`/`defAdjust`), halved for same-layer targets with Smart Shell (`:39102-39150`).

### mol_flameTurret1-3 (Flame Turret, #241-243) (verified 2026-10-01)

- SP −24/−28/−32 (red), Lv/Bn 16/4, 20/8, 24/12, instant self. CD `agiAdjust(120)` (`:28225`).
- `RPC_flameTurret` (`:27714-28462`): the Mole itself stands as the turret (`moveSpeed 0`) for `chaAdjust(5)` s (`:27935`); left/right input turns it 45° (`RPC_flameTurret_rotate`, `:28078-28130`). Every 0.25 s (`mUpdateTimer = Time.time + 0.25`) `FindRecTarget(pos + fwd, fwd, 1, 2, 12, 4, enemy layers)` (`:28144-28149`); each target that is not `Robots`/`Structure` takes direct `RPC_AddDamage(231 + sLv, talAdjust(5 × sLv), KO 0, …)` (`:28188-28200`) — no `dmgAdjust`/`defAdjust`, no `insight` check. Tooltip "5/10/15 × 20" matches.

### mol_fireBarrage1-2 (Fire Barrage, #251, #253) (verified 2026-10-01)

- **MP 10/15, SP 20/30 blue**, Lv/Bn 20/12, 28/18. The card's former MP 10/20, SP 20/35 was wrong. CD `agiAdjust(120)` (`:28602`).
- `RPC_fireBarrage_fire` (`:29181-29290`): rank 1 one aircraft effect, rank 2 three (±30°, `:29181-29204`) — visual only. 4 waves (`i >= 4` exit, `:29228`), all at the same point: `FindAreaTarget(mPos, 2 × sLv + 1, 3, enemy layers)` (`:29240`), `hit(250 + sLv, t, talAdjust(5 + 10 × sLv), KO 1, …)` (`:29259`), no falloff. **Card correction:** 4 hits at both ranks (was 4 × 3 at rank 2). Tooltip "15/25 × 4" matches.

### mol_bombardment1-2 (Bombardment, #252, #254) (verified 2026-10-01)

- **MP 20/30, SP 35/55 blue**, Lv/Bn 24/15, 32/21. The card's former MP 20/35, SP 35/50 was wrong. CD `agiAdjust(180)` (`:29483`), fired after a 4 s wait (`:29700`).
- `RPC_bombardment_fire` (`:29738-30110`): 5 strikes (`i >= 5` exit, `:29902`) at `mPos + tDir × (3i − 6)` (`:29912`), i.e. −6/−3/0/+3/+6 m along the line.
- `RPC_bombardment_hit` (`:30119-30490`): `FindAreaTarget(pos, 4 + ExtraPowderLv, 5, enemy layers)` (`:30333`); rank 2 adds two more areas at `(±3, 0, −3)` rotated to `tDir`, merged with `Math.combineArray` (de-duplicates, `Math.cs:335-420`), so one strike hits a target once (`:30338-30349`). `hit(252 + sLv, t, talAdjust(10 + 15 × sLv), KO 1, …)` (`:30383`); `hitDistance` is computed (`:30373`) but **not used** — no falloff.
- **Card:** hit count 3 (a target at the aim point is inside the 0 and ±3 m strikes; ±6 m needs radius ≥ 6, i.e. Extra Powder). Was 5 × 3. **Tooltip discrepancy:** "35/55 dmg × 5"; code base 25/40.

### mol_napalm5 (Napalm, #412) (verified 2026-10-01)

- SP −40 (red), Lv 60/Bn 1, target. CD `agiAdjust(150)` (`:37392`).
- `RPC_napalm` (`:36935-37520`): 5 shells (`i < 5`, `:37173`) aimed at the target and at the target + world offsets `(±5, 0, ±5)` (≈7.07 m diagonally, `:37190-37200`); mortar arc, `life = 5 × rangeMod` (`:13714-13750`); a shell bursts on any non-own-layer collider (`Mole_napalm.cs:42-70`).
- `RPC_napalm_hit` (`:37586-37800`): 6 ticks (`i >= 6` exit, `:37659`) 0.5 s apart (`:37798`); `FindAreaTarget(pos, 4 + ExtraPowderLv, 4, enemy layers)` (`:37669-37679`); tick 1 `talAdjust(30)`, ticks 2-6 `talAdjust(5)` (`:37684`); targets that are not `Robots`/`Structure` take direct `RPC_AddDamage(31, dmg, KO 0, …)` (`:37723-37735`).
- **Card (user decision 2026-10-01):** Napalm is used point-blank, so the card assumes all 5 shells burst on the target: 5 pools × 6 ticks = 30 hits (5 × `talAdjust(30)` + 25 × `talAdjust(5)`). At range the pools land ≈7 m apart (radius 4-7), so a target is in one pool (6 hits).

### mol_cannonExpert5 (Cannon Expert, #401) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. Combo only: damage `0.5 → 0.6 × ATK` (`Mole_nAttack.cs:161`) and falloff factor `0.5 → 0.25` (edge 75 %, `Mole_nAttack.cs:252-260`). Tooltip "+20 % and −50 % penalty" matches.

### mol_skyShaker5 (Sky Shaker, #413) (verified 2026-10-01)

- Passive, Lv 60/Bn 1. Sky Drill only (`:31974`, `:32085-32120`): `totalDigTime = FloorToInt(Time.time − actionTime)` (`:31795`); `FindAreaTarget(Mole pos, 5, 5 × rangeMod, enemy layers)`; `hit(413, t, 8 + totalDigTime, KO 8 + totalDigTime, …)` — normal `hit()` path (`dmgAdjust`/`defAdjust`). Tooltip matches.

### mol_autoGyroGun1-4 (Auto Gyro Gun, #301-304) (verified 2026-10-01)

- MP 10/15/20/25, SP −10 (red) at every rank, Lv/Bn 3/0, 9/1, 15/2, 21/3. Cast through `RPC_assemble1("autoGyroGun", …)` (`:8285`, `:22908-23440`): assemble time `magAdjust(1 + sLv)` = 2-5 s, CD `agiAdjust(30)` (`:23353-23429`); the build aborts if `myCommand` stops being `"assemble"` (`:23146`). Spawn point `getSpawnVector(pos + up, 0.7 × forward − up)` (`:23199`).
- `RPC_autoGyroGun_create` (`:11751-12160`): prefab `AutoGyroGun1-4`, `isSummon`, life `chaAdjust(120)` (`create(…, chaAdjust(120))`, `AutoGyroGun.cs:1610-1740`). Base stats from `Awake` (`AutoGyroGun.cs:42-140`): all eight stats `10 × sLv`, HP `50 × sLv`. Hidden Turret #403 overrides them (`:12141-12160`): ATK/DEF `(int)(0.25 × sLv × Lv)`, AGI/VIT/MAG/CHA/TAL/LCK `(int)(0.125 × sLv × Lv)`, MHP `ceil(10 × VIT)`. Heavy Built: MHP `ceil(MHP × (1 + 0.5 × lv))` (`:12203-12210`). No turret count limit in the client (ToT's 8/12 cap is server-side, see Server Balance Variations).
- Reload clears the `autoGyroGun` cooldown (`:10202`). The app model is `autoGyroGunOwnStats()`.

### mol_autoGyroGun_nAttack (Auto Gyro Gun attack) (verified 2026-10-01)

- `AutoGyroGun.AIControl` (`AutoGyroGun.cs:733-990`): in standby, once per second after the first 2 s, `findAttackTarget` picks a **random** enemy from `Hate.findEnemies(pos, 8 + 4 × mLv, layer)` (`:991-1030`) and `RPC_fire`s at it; each fire sets `addTimeOut("nAttack", 2)`, so one shot per 2 s.
- `RPC_fire` (`AutoGyroGun.cs:1100-1480`): `FindRecTarget(pos, dir, 0.2, 0.5, 8 + 4 × mLv, 2, enemy layers)` (half-widths: 0.4 → 1 m wide, `:1220`); every target in the line takes `hit(1, t, turret ATK, KO 1, …)` (`:1243`) — the normal `hit()` path with the turret's own stats.

### mol_hiddenTurret5 (Hidden Turret, #403) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. `getHiddenTurretLv()` (`:13651-13653`).
- Stats: see Auto Gyro Gun. Break-even: the Hidden Turret ATK `0.25 × sLv × Lv` equals the base `10 × sLv` at Mole level 40, so below level 40 it lowers ATK/DEF; LCK becomes `0.125 × sLv × Lv` (the turret's own LCK drives its `dmgAdjust` roll, `CharacterControl.cs:20489`).
- Hide (`AutoGyroGun.cs:832-848`): when the owner has #403 and `Time.time > hideTimer` (first set to spawn + 3 s, `AutoGyroGun.cs:61`; refreshed to `now + 6` on every shot, `:793`), the turret plays `RPC_hide` (`myCommand = "hide"`, `actionState = "attack"`, `AutoGyroGun.cs:1825-1941`). While hidden, the turret's `RPC_AddDamage` takes `ceil(0.3 × nDamage)` (`CharacterControl.cs:5225-5262`, types AutoGyroGun1-5). It unhides (`RPC_unhide`, 1 s) when a target is found again (`AutoGyroGun.cs:958-961`).

### mol_speedDrill1-2 (Speed Drill, #311-312) (verified 2026-10-01)

- Passive, Lv/Bn 5/1, 11/3. `getSpeedDrillLv()` (`:12251`). Charge Attack only (`:22463`): underground speed `2 + 1.5 × lv` (`:21818`); dig-in `1.9 − 0.5 × lv` s, `1 − 0.2 × lv` with Super Dig (`:21609`, `:22186`). Tooltip "3.5/5 ts, −25 %/−50 %": the speed matches; the dig-in time is −26 %/−53 % in code.

### mol_skyDrill1-2 (Sky Drill, #313-314) (verified 2026-10-01)

- Passive, Lv/Bn 17/5, 23/7. `getSkyDrillLv()` (`:12258`, `:9972`).
- Trigger (`doReleaseCharge`, `:9972-10012`): releasing Charge Attack (`myCommand == "cAttack1"`) after more than 3 s underground (`Time.time − actionTime > 3`) and only when `Game.mGameType > 4` (real game modes); otherwise the normal `RPC_cAttack0` surfacing.
- `RPC_skyDrill` (`:31496-32200`): `hitDmg = (int)(0.5 × ATK + talAdjust(10 + 10 × sLv))` (`:32080`); 2 rings (`i < 2`, `:32167`) 0.8 s / 0.1 s apart, ring `i` = `FindAreaTarget(pos, (1 + i) × rangeMod, 5 × rangeMod, enemy layers)` (`:31649`); `hit(312 + sLv, t, hitDmg, KO 4 × sLv, …)` (`:31672`). No de-duplication between rings, so a target within 1 m takes both. Sky Shaker hit: see Sky Shaker. Tooltip "20/30 × 2" is the TAL part only.

### mol_superDig5 (Super Dig, #411) (verified 2026-10-01)

- Passive, Lv 60/Bn 1. Charge Attack: dig-in `1 − 0.2 × SpeedDrill` s instead of `1.9 − 0.5 × SpeedDrill` (`:22186`); heal `RPC_AddHeal(411, ceil(0.01 × MHP))` every 2 s underground while below max HP, real game modes only (`:21823-21860`). `:22290`, `:22359`, `:22469` are animation/dust only. Tooltip matches.

### mol_megaDrill5 (Mega Drill, #433) (verified 2026-10-01)

- SP 36 **blue**, Lv 75/Bn 4, target. CD `agiAdjust(30)` (`:39724`).
- `RPC_megaDrill` (`:39324-39830`): brief `moveSpeed −5` wind-up, then 4 hits (`i < 4`, `:39761`): `FindRecTarget(pos, fwd, 1, 1, 3, 2, enemy layers)` (2 m wide, 3 m long, `:39563`); `hit(2, t, ATK + talAdjust(45), KO 2, …)` (`:39586`), `sp + 1` per target hit.
- Passive part: Mega Punch and Mega Hammer `floor(1.5 × hitDmg)` (`:32488`, `:33081`); Barrel Bot gets `drillLv = 1` (`RPC_barrelBot_create`, `:12939`). Card correction: hit count 4 (was 1).

### mol_barrelBot1-4 (Barrel Bot, #321-324) (verified 2026-10-01)

- MP 25/35/45/55, SP −10 (red) at every rank, Lv/Bn 7/2, 13/4, 19/6, 25/8. Cast through `RPC_assemble1("barrelBot", …)` (`:5130-5170`): assemble time `magAdjust(3 + sLv)` = 4-7 s, CD `agiAdjust(240)` (`:23370-23429`).
- `RPC_barrelBot_create` (`:12279-13040`): without Double Bot #423 the old bot is destroyed; with it the old bot is kept as the second bot (`yGTaGbALKi`) and any older second bot is destroyed (`:12415-12430`). Base stats from `BarrelBot.Awake` (`BarrelBot.cs:25-160`): HP `100 × sLv`, ATK/DEF `15 × sLv`, VIT/TAL/LCK `10 × sLv`, AGI/MAG/CHA 10. Double Bot: every stat `(int)(stat + 0.5 × Lv)`, then MHP `10 × VIT` (`:12708-12725`). Heavy Built: MHP `ceil(MHP × (1 + 0.5 × lv))` (`:12765-12770`). Weapon levels copied from the Mole: PunchLv #331-332, HammerLv #333-334, ChopperLv #341-343, MissileLv #351-354, DrillLv #433, CannonLv #443 (`:12940-13035`). No lifetime: the bot is destroyed only when it dies or its creator is gone (`BarrelBot.cs:179-260`).
- **AI (`BarrelBotAI.cs`):** targets come from `getHateTarget` after a `Hate.findEnemies(pos, 32, layer)` vision check (`:1347`). `AI_attack` picks the first ready weapon by distance to the target's edge (`:945-1215`): Missile < 16 m, Chopper < 4, Drill < 2, Hammer < 2, Punch < 3, normal attack < 1; otherwise it runs at the target and fires Cannon when < 20 m. Each weapon has its own cooldown on the bot (`agiAdjust` with the bot's AGI, except normal attack and drill).
- Revised Art does not shorten the bot's weapon cooldowns: they are armed on the bot's own `CharacterControl`, whose skill list is never filled (`readSkill` is never called for it, `CharacterControl.cs:20102-20110`, `:24135-24166`), so `hasSkill(424)` is false. The summon's 240 s cast cooldown is on the Mole and is reduced.
- The app model is `barrelBotOwnStats()`.

### mol_barrelBot_nAttack (Barrel Bot normal attack) (verified 2026-10-01)

- `BarrelBot.RPC_nAttack` (`BarrelBot.cs:2050-2540`): two swings (states 3 and 4), each `FindAreaTarget(pos + 0.25 fwd, 1.5, 3)` and `hit(1, t, (int)(0.5 × ATK), KO 1, …)` (`:2249-2272`, `:2341-2364`); `addTimeOut("nAttack", 3)` (`:2480`). Card correction: 2 hits (was 1).

### mol_barrelBot_punch (Barrel Bot Mega Punch) (verified 2026-10-01)

- `BarrelBot.RPC_punch` (`BarrelBot.cs:2588-2940`): `FindRecTarget(pos, fwd, 1, 1, 3.5, 3)` (2 m wide, `:2752`); `hit(2, t, (int)(0.4 × ATK + talAdjust(12 × PunchLv)), KO 5, …)` (`:2775`); CD `agiAdjust(12)` (`:2891`). No Mega Drill ×1.5 here (that is only in the Mole's own `RPC_megaPunch`).

### mol_barrelBot_hammer (Barrel Bot Mega Hammer) (verified 2026-10-01)

- `BarrelBot.RPC_hammer` (`BarrelBot.cs:2988-3340`): `FindRecTarget(pos, fwd, 2, 2, 2.5, 3)` (4 m wide, `:3147`); `hit(3, t, (int)(0.5 × ATK + talAdjust(10 × HammerLv)), KO 10 × HammerLv, …)` (`:3170`); CD `agiAdjust(15)` (`:3286`). No Mega Drill ×1.5.

### mol_barrelBot_chopper (Barrel Bot Chopper) (verified 2026-10-01)

- `BarrelBot.RPC_chopper` (`BarrelBot.cs:3383-3910`): moves forward (`moveSpeed` 3 → 5), 4 hits (`i >= 4` exit, `:3707`), each `FindRecTarget(pos, fwd, 1, 1, 3, 2)` (`:3728`) and `hit(4, t, (int)(0.3 × ATK + talAdjust(5 × ChopperLv)), KO 1, …)` (`:3751`); CD `agiAdjust(60)` (`:3825`).

### mol_barrelBot_missile (Barrel Bot Missile) (verified 2026-10-01)

- `BarrelBot.RPC_missile` (`BarrelBot.cs:3960-4420`): `MissileLv` missiles (`:4219`) fanned by rank (`:4105-4120`), each locked on a random living enemy from `FindAreaTarget(pos, 32, 10)` (`:4109`); CD `agiAdjust(60)` (`:4382`). Homing (`RotateTowards 0.3`, `BarrelBot_missile.cs:45`); on contact `nDamage = target.defAdjust(bot.talAdjust(30))`, `RPC_AddDamage(5, nDamage, KO 3, …)` (`BarrelBot_missile.cs:60-90`) — no `dmgAdjust`, DEF applied (card `dmgAdjustSkip`).

### mol_barrelBot_drill (Barrel Bot Mega Drill) (verified 2026-10-01)

- `BarrelBot.RPC_drill` (`BarrelBot.cs:4483-4980`), needs DrillLv (Mole has #433): 4 hits (`i < 4`, `:4944`), each `FindRecTarget(pos, fwd, 1, 1, 3, 2)` (`:4662`) and `hit(2, t, (int)(0.5 × ATK + talAdjust(15)), KO 2, …)` (`:4685`); `addTimeOut("drill", 9)` flat (`:4818`).

### mol_barrelBot_cannon (Barrel Bot Barrel Cannon, auto) (verified 2026-10-01)

- `BarrelBot.RPC_cannon` (`BarrelBot.cs:5030-5340`), needs CannonLv (Mole has #443): CD `agiAdjust(9)` (`:5278`); shell (`BarrelBot_cannon.cs`) bursts on a non-own-layer collider → `RPC_cannon_hit` (`BarrelBot.cs:1840-1910`): `FindAreaTarget(hitPos, 3, 4, enemy layers)`, `hit(1, t, floor(1.5 × ATK), KO 1, …)`.

### mol_barrelCannon5 (Barrel Cannon, #443) (verified 2026-10-01)

- SP 50 **blue**, Lv 85/Bn 6, target. CD `agiAdjust(120)` (`:40199`).
- `RPC_barrelCannon` (`:39835-40300`): starts `RPC_cannonForm` on the bot (`:39989-40038`) and on the Double Bot second bot (`:40053-40104`). `RPC_cannonForm` (`BarrelBot.cs:5377-5800`): the bot stands still and fires at the Mole's target every 0.5 s (`:5544`, `:5743`) until 10 shells (`mCannonCount >= 10`, `:5716`) or the target is gone; each shell is the cannon hit above. Passive part: CannonLv for the bot (`:13035`); the tooltip's "bombing attack on Mole's Chopper" is covered under Chopper.

### mol_megaPunch1-2 (Mega Punch, #331-332) (verified 2026-10-01)

- SP 15/18 **blue**, Lv/Bn 9/3, 15/5. CD `agiAdjust(30)` (`:32662`).
- `RPC_megaPunch` (`:32251-32700`): `hitDmg = floor(0.5 × ATK + talAdjust(10 × sLv))`, KO 5 (`:32478-32483`); Mega Drill #433: both `floor(1.5 ×)` (`:32488-32499`); `FindRecTarget(pos, fwd, 1, 1, 3, 3)` (2 m wide, `:32513`); `hit(330 + sLv, t, hitDmg, hitKo, …)` (`:32536`). Gives the Barrel Bot its punch (PunchLv, see Barrel Bot). Tooltip "10/20 dmg, 5 ko" matches the TAL part.

### mol_megaHammer1-2 (Mega Hammer, #333-334) (verified 2026-10-01)

- **SP 18/24 blue**, Lv/Bn 21/7, 27/9. The card's former SP 18/20 was wrong. CD `agiAdjust(30)` (`:33228`).
- `RPC_megaHammer` (`:32865-33260`): `hitDmg = floor(0.5 × ATK + talAdjust(12 × sLv))`, KO `10 × sLv` (`:33071-33076`); Mega Drill: both `floor(1.5 ×)` (`:33081-33092`); `FindRecTarget(pos, fwd, 1.5, 1.5, 3, 3)` (3 m wide, `:33106`); `hit(332 + sLv, …)` (`:33129`).

### mol_chopper1-3 (Chopper, #341-343) (verified 2026-10-01)

- SP 20/24/28 **blue**, Lv/Bn 16/4, 20/8, 24/12. CD `agiAdjust(45)` (`:34019`).
- `RPC_chopper` (`:33450-34180`): flies forward at `5 + sLv` m/s (`:33690`); `hitDmg = (int)(0.3 × ATK + talAdjust(5 × sLv))` (`:33749`); 10 ticks (`i >= 10` exit, `:33794`), each `FindRecTarget(pos, fwd, 1, 1, 3, 2)` (`:33890`) and `hit(340 + sLv, t, hitDmg, KO 1, …)` (`:33913`), `sp + 1` per target hit. **Barrel Cannon #443:** every tick also `FindAreaTarget(pos, 5, 1)` and `hit(443, t, talAdjust(20), KO 0, …)` (`:33957-33986`). Card: Barrel Cannon dep adds a 10-hit group (new `MOLE_BARRELCANNON_DEP`).

### mol_missile1-4 (Missile, #351-354) (verified 2026-10-01)

- MP 12/16/20/24, Lv/Bn 20/12, 24/15, 28/18, 32/21. CD `agiAdjust(60)` (`:34777`).
- `RPC_missile` (`:34236-34800`): `sLv` missiles (`:34614`) fanned like the bot's (`:34383-34504`), each locked on a random living enemy from `FindAreaTarget(pos, 32, 10)` (`:34604`). `Mole_missile.cs`: homing `RotateTowards 0.3` (`:162`); on contact `target.defAdjust(talAdjust(30))`, `RPC_AddDamage(1, …, KO 3, …)` (`:349-369`) — no `dmgAdjust`.

### mol_heavyBuilt1-2 (Heavy Built, #361-362) (verified 2026-10-01)

- Passive, Lv/Bn 24/15, 28/18. `getHeavyBuiltLv()` (`:13213`): MHP `ceil(MHP × (1 + 0.5 × lv))` after the other stat changes for Auto Gyro Gun (`:12203`), Barrel Bot (`:12765`) and King Kaiser (`:35925`). Thai tooltip rank 2 says 50 %; English and code say 100 %.

### mol_synchroMole1-2 (Synchro Mole, #363-364) (verified 2026-10-01)

- MP 15/25, **SP −25 (red) at both ranks**, Lv/Bn 30/21, 33/24. The card's former SP 25/35 was wrong. CD `agiAdjust(300)`.
- `RPC_synchroMole` (`:13220-13300`): `RPC_AddStatus("synchroMole", sLv, chaAdjust(30), value = Mole TAL)` on the Mole, and the same status for `chaAdjust(30) + 1` s on every own `AutoGyroGun1-5` / `BarrelBot1-5` summon present at cast (not King Kaiser / War Factory). Non-Mole, non-Robots targets refuse it (`CharacterControl.cs:12466-12470`).
- Effect (`CharacterControl.cs:37714-37777`): `deltaAtk/deltaDef(+floor(0.5 × sLv × value))` on the summons; removal subtracts the same (`:16978-17025`), and the Mole's own removal calls `RPC_synchroMole0`, which strips it from its summons (`Mole.cs:13514-13560`). Buff + State status (`StatusData.cs:4938`, `:6746`). A recast refreshes instead of stacking (`CharacterControl.cs:14103-14182`); summons made after the cast do not get it.
- **App fix:** the summon-stat toggle was Rank 2 only (`floor(TAL)`); it is now a 0-2 rank toggle (`floor(0.5 × rank × TAL)`), id `synchroMole`.

### mol_doubleBot5 (Double Bot, #423) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. Barrel Bot: keeps the previous bot as a second bot (`:12415-12430`) and adds `(int)(0.5 × Lv)` to every stat, MHP `10 × VIT` (`:12708-12725`); Barrel Cannon commands both bots (`:40053-40104`). Tooltip matches.

### mol_advanceRepair5 (Advance Repair, #431) (verified 2026-10-01)

- SP −10 (red), Lv 75/Bn 4, ally target. Cast check (`doSkill`, `:7048-7150`): the target must be `Robots` or `Structure` race and within 2 m (edge distance), else MP/SP returned. CD `agiAdjust(30)` (`:36716`).
- `RPC_advanceRepair` (`:36263-36900`): channel; every 1 s `sp − 1` and `target.hp = min(hp + 150, mhp)` (direct, no heal modifiers, `:36681-36689`); stops on movement input, target farther than 2 m, or SP below 5 (`:36573-36631`). Passive part: Reload's extra reset list (see Reload).

### mol_geniusInvention5 (Genius Invention, #421) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. Workshop tier 5 (`CompoundGui.cs:1249`, `:1852`). Item cooldowns for a Mole with #421 (`GameGui.cs:32730-32790`): firework 3 → 1 s, bomb 30 → 15 s. (`CharacterControl.cs:13421` and the other classes' #421 hooks are not Mole's.)

### mol_kingKaiser1 / mol_kaiserCannon1 / mol_kaiserBeam1 (King Kaiser #371, Kaiser Cannon #372, Kaiser Beam #373) (verified 2026-10-01)

- King Kaiser: MP 80, SP −80 (red), Lv 35/Bn 23, instant self. CD `agiAdjust(999)` (`:35380`). Kaiser Cannon (Lv 40/Bn 25) and Kaiser Beam (Lv 45/Bn 27) are passives; the card's rank 1-3 is `getKaiserLv()` (`:13607-13620`).
- `RPC_kingKaiser_create` (`:35536-36000`): lasts `chaAdjust(240)` (`:35789`); the Kaiser is not a summon (`isSummon = false`, `:35870`); Heavy Built MHP `ceil(× (1 + 0.5 × lv))` (`:35925-35936`); `summon(getKaiserLv())` (`:35995`) sets ATK `150 + 50 × lv`, DEF `100 + 50 × lv` (`KingKaiser.cs:3991-3997`). MHP 2000 from the prefab (see `kingKaiserOwnStats`; re-decoded 2026-10-01: `KingKaiser_b` `CharacterControl` @ `resources.assets` 45046984 → HP/MHP 2000, AGI 100, VIT 200, MAG 75, CHA 200, TAL 150, LCK 75; user confirmed 2000). **Tooltip discrepancy:** "1500 hp" (ToT's value; see Server Balance Variations). `KingKaiserAI.cs` is unreachable for the player's Kaiser (`isControlled = true`, `:35865`). Each cast uses one Kaiser Battery item `m_kbt1` (checked `:7007`, removed `:35684`). The Kaiser's own `CharacterControl` never calls `hasSkill`, so Revised Art does not reach its attack cooldowns.

### mol_kingKaiser_nAttack (King Kaiser normal attack) (verified 2026-10-01)

- `KingKaiser.doNormalAttack` (`KingKaiser.cs:900-930`): when `nAttack` is ready; at Kaiser level ≥ 2 and a target farther than 10 m (`sqrMagnitude > 100`) it fires Kaiser Cannon instead.
- `RPC_nAttack` (`KingKaiser.cs:1471-2270`): 3 swings, `addTimeOut("nAttack", 4)` (`:2179`): `FindRecTarget(pos + right, fwd, 2, 2, 5, 3)` → `hit(1, t, ATK, KO 1)` (`:1657-1680`), `FindRecTarget(pos, fwd, 1.5, 1.5, 4, 3)` → `hit(2, t, (int)(1.2 × ATK), KO 1)` (`:1862-1885`), `FindRecTarget(pos + (−1, 0.5, −2), fwd, 2.5, 2.5, 6, 2)` → `hit(3, t, (int)(1.3 × ATK), KO 1)` (`:2008-2031`); Kaiser `sp + 1` per target on swings 1 and 3 (`:1686`, `:2037`).

### mol_kingKaiser_missile (Kaiser Cannon) (verified 2026-10-01)

- `RPC_kaiserMissile` (`KingKaiser.cs:2321-2750`): two volleys of two shells (`:2462-2467`, `:2562-2567`); shares the `nAttack` 4 s lock (`:2711`). `RPC_kaiserMissile_hit` (`KingKaiser.cs:1280-1340`): `FindAreaTarget(hitPos, 5, 5, enemy layers)`, `hit(21, t, 100, KO 5, …)` (fixed 100 through `hit()`), Kaiser `sp + 1`.

### mol_kingKaiser_beam (Kaiser Beam) (verified 2026-10-01)

- `doBeginCharge` (`KingKaiser.cs:1017-1060`): needs Kaiser level 3 ("Need KaiserBeam Upgrade") and Kaiser SP ≥ 75 ("Kaiser Beam needs 75 sp"). `RPC_kaiserBeam1` charge (`addTimeOut("kaiserBeam", 2)`, `:3041`); releasing after 6.5 s fires `RPC_kaiserBeam2` (`:1177`), earlier releases abort with `RPC_kaiserBeam0` (no damage); `RPC_kaiserBeam2` fire (`:3118-3580`): `addTimeOut("kaiserBeam", 30)` (`:3426`); 5 pulses (`i >= 5` exit, `:3501`), each `sp = Clamp(sp − 15, 0, 100)` (`:3516`), `FindRecTarget(pos, fwd, 4, 4, 32, 6)` (8 m wide, `:3519`), `hit(21, t, 300, KO 1, hate 1, …)` (`:3538`). Tooltip "75 sp" matches. The `kaiserBeam` timeout is never checked (`isTimeOut` only reads `nAttack`, `:945`), so the 30 s is not enforced in the client; the card shows no cooldown (user decision 2026-10-01).

### mol_warFactory5 (War Factory, #434) (verified 2026-10-01)

- MP 15, SP −30 (red) per cast, Lv 75/Bn 4. `doSkill` (`:7382-7400`): a counter steps 1 → 5 and wraps; 1 Saw Machine, 2 Bazooka, 3 Tesla Coil, 4 Roller Machine, 5 Cart Bomb. Cooldown `agiAdjust(3)` after steps 1-4 (`:40814`, `:41388`, `:41900`, `:42687`) and `agiAdjust(180)` after Cart Bomb (`:43394`). `Start()` puts `warFactory` on `agiAdjust(180)` and `warCapital` on `agiAdjust(300)` at spawn in real game modes (`Game.mGameType > 4`, `:105-120`). Reload with Advance Repair clears it (`:10302`). **Card correction:** the units were "free / 180 s"; each costs MP 15 / SP 30 and steps 1-4 use the 3 s cooldown.

### mol_warFactory_sawMachine (Saw Machine) (verified 2026-10-01)

- `RPC_sawMachine` (`:40377-41015`): 4 swings (`i` 1-4, `:40671`), each its own box (`:40710-40746`): behind `FindRecTarget(pos, −fwd, 4, 4, 3, 2)`, then front `(4, 4, 2, 2)`, `(2, 2, 3, 2)`, `(4, 4, 2, 2)`; `hit(4341, t, (int)(1.5 × ATK + talAdjust(15)), KO 0, …)` (`:40770`). A target in front takes at most 3 (card hit count 3, was 4).

### mol_warFactory_bazooka (Bazooka) (verified 2026-10-01)

- `RPC_bazooka` (`:41015-41581`): 3 rockets (`i >= 3` exit, `:41308`), `life = 2 × rangeMod` (`:41361`); on contact (`Mole_bazooka.cs:46-73`): `FindAreaTarget(point, 1, 1, enemy layers)`, `hit(3442, t, ATK + talAdjust(50), KO 5, …)`. Card hit count 3 (was 1).

### mol_warFactory_teslaCoil (Tesla Coil) (verified 2026-10-01)

- `RPC_teslaCoil` (`:41581-42198`): 7 pulses (`i >= 7` exit, `:42034`), `FindAreaTarget(Mole pos, 5, 3)` (`:42046`), `hit(4343, t, talAdjust(30), KO 0, …)` (`:42065`); a hit target whose `actionState` is standby / run / emotion also gets `RPC_AddStatus("paralysis", 2, 3, …)` — level 2, fixed 3 s (`:42076-42109`).

### mol_warFactory_rollerMachine (Roller Machine) (verified 2026-10-01)

- `RPC_rollerMachine` (`:42198-42898`): one hit, then 10 more while rolling forward at `moveSpeed 1` (`i >= 10` exit, `:42597`); each `FindRecTarget(pos, fwd, 1.5, 1.5, 2, 2)` and `hit(4344, t, 3 × ATK, KO 0, …)` (`:42394-42430`, `:42620-42643`). 11 hits.

### mol_warFactory_cartBomb (Cart Bomb) (verified 2026-10-01)

- `RPC_cartBomb` (`:42898-43591`): the Mole steers the cart with the direction keys at 6 m/s (`:43267-43290`). `Mole_cartBomb.cs` (`:20-45`): explodes after 3 s or when the Mole leaves the `cartBomb` command. `RPC_cartBomb_hit` (`:14128-14160`): radius `6 + 1.5 × ExtraPowderLv` (height the same), `hit(3445, t, (int)((1 − 0.5 × d / r) × talAdjust(150)), KO 30, …)`.

### mol_warCapital5 (War Capital, #444) (verified 2026-10-01)

- MP 100, SP −50 (red), Lv 85/Bn 6. Assembled through `RPC_assemble1("warCapital")`: `magAdjust(24)` s, CD `agiAdjust(300)` (`:23387-23429`).
- `RPC_warCapital_create` (`:14239-14480`): destroys the previous War Capital, `isSummon`, starts `OnWarCapital`. It lives until destroyed or the Mole dies (`Mole_warCapital.cs:100-170`). No Heavy Built. **Own stats (prefab, decoded 2026-10-01):** `warCapital` `CharacterControl` @ `resources.assets` byte 44560960 (708 bytes; same field layout as King Kaiser, calibrated on Gaos @ 44478976 and King Kaiser_b @ 45046984): HP/MHP **1500**, ATK/DEF/AGI/VIT/MAG/CHA/TAL/LCK **150** each, MP/SP/KO 10. No runtime code overwrites them. The missiles use the Mole's `talAdjust`, not the base's TAL.
- `OnWarCapital` (`:43591-43930`): every 24 s, if `FindAreaTarget(Mole pos, 36, 10)` finds enemies (`:43842-43880`), `RPC_warCapital_fire` (`:43981-44270`) fires 8 missiles 0.15 s apart, each at a random target + up to 2 m random offset (`:43749-43806`). `RPC_warMissile_hit` (`:14589-14660`): `FindAreaTarget(point, 1, 1)`, `hit(−4444, t, talAdjust(50), KO 3, …)`. Tooltip "50 dmg × 8, Hp 1500" matches.
- **Whose stats (re-checked 2026-10-02):** `RPC_warMissile_hit` is a method of the Mole script and calls `this.mChar.hit(-4444, t, this.mChar.talAdjust(50), 3, …)` (`Mole.cs:14658`), so the damage uses the **Mole's** TAL and LCK; the base's own stats feed nothing. Card: reference-only "War Capital Stats" table (`warCapitalOwnStats()`), every cell shown as not used; the damage formula reads the player's TAL.

## Server Balance Variations (TTO)

Private-server values are documented from the Bible skill-detail schema; the BigBug decompile remains the original-server baseline.

| Skill | Original BigBug baseline | TTO delta |
|---|---|---|
| Auto Gyro Gun | No simultaneous-turret limit is represented on the original card. | Cap is 8 guns without Hidden Turret or 12 with Hidden Turret. |
| Smart Shell | Allies inside the blast take half: Stun Mine / Stun Grenade KO halved, Time Nuke / Flame Carnival damage halved (Smart Shell entry above). | Does not reduce damage dealt to allies (user-reported 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tto`). |
| King Kaiser; King Kaiser - Normal Attack / Kaiser Cannon / Kaiser Beam | MHP 2000, then Heavy Built applies `ceil(MHP×(1+0.5×rank))` → 2000 / 3000 / 4000. | **Nerf:** MHP is fixed at 1500 and Heavy Built does not apply. The server selector is present on the parent and all three child cards because their shared own-stat block changes. |

Source of server delta: `12t_projects/bible/index.html:9160`.

## Open items / could not verify

None open. Resolved 2026-10-01 (user decisions):

1. **Kaiser Beam cooldown:** the `kaiserBeam` timeout is never checked; the card shows no cooldown (75 Kaiser SP is the only limit).
2. **Napalm:** the card assumes point-blank use, with all 5 shells on the target (30 hits).
3. **King Kaiser HP:** 2000 confirmed (prefab re-decode above).
4. **War Capital HP:** decoded from the prefab: 1500 HP, all stats 150.
5. **Saw Machine:** the card counts the 3 front swings.
6. **Tooltip mismatches** are shown on the cards in red (`__…__`), with the code value used: Landmine, Bombardment, Mine Lover, Super TNT, Speed Drill, Heavy Built (Thai rank 2), Charge Attack (English lock levels), King Kaiser HP.

## Server Balance Variations (ToT patch notes, 2026)

Source: ToT Facebook patch notes (C6 intro post, 03/08/2026, 10/09/2026, hot fix 12/09/2026; latest value wins), read 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tot`.

| Skill | ToT change |
|---|---|
| Flame Turret | base cooldown −50% (120 → 60 s); can be cancelled with a normal attack or another Class A skill |
| Fire Barrage | cooldown −20% (120 → 96 s); damage range +20%; resets Blast Throw |
| Bombardment | cooldown −35% (180 → 117 s); damage range +20%; resets Blast Throw |
| Mine Lover | reworked into the active "Blast Throw" (bomb cooldown down, all damage +50%, throws a bomb that explodes on landing), 20 red SP / 10 MP |
| Napalm | can damage Machine / Structure targets; can no longer damage characters that are dodging |
