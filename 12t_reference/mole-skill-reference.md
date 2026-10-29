# Mole — Skill Cooldown/Duration Reference

> **Scope (2026-10-25):** this file documents the original BB client (`DecompiledSource/`); a citation without a tag is BB. ToT and TTO changes are live changes reported by the user and sit in the `## Server Balance Variations` sections. The Reborn client has its own file: [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) (Reborn citations are tagged `Reborn:`).

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
- **Stun Mine duration:** the code reads `talAdjust(60)` (`Mole_stunMine.cs:60`), where Landmine uses `chaAdjust(60)` for the same lifetime (`Mole_mine.cs:60`). This is a BB client bug (user, 2026-10-02); the card follows the code: its duration chip runs `talAdjust(60)` with the TAL accent (`durAdjust:"tal"`) and the `bbBug` note explains it. The earlier report that the live game uses `chaAdjust(60)` (2026-08-14) was a mistake and is withdrawn (user, 2026-10-02).
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
- `stunMine` Duration (prop lifetime, not `RPC_AddStatus`): `Mole.cs:27019` → `Mole_stunMine.cs:60` reads `this.XYwd2vIXAX = (int)((float)this.MAZdRGaitt.talAdjust(60) + Time.time);` (`talAdjust`, a BB bug); the card uses `talAdjust` (`durAdjust:"tal"`). The 2026-08-14 "patched to chaAdjust" report was withdrawn as a mistake. See the note above.
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
- Each stage fires one `RPC_nAttack_fire` shell (`:20473`, `:21235`), `ProjectileControl.life = 10 × rangeMod` (`:10089`), speed 15 (`Mole_nAttack.cs:20-34`). Double Cannon (`w_mol59`, `WeaponData.cs:15046`; the card once called it Star Cannon) fires two shells at ±9° instead (`:20419-20464`). Modelled on Combo (`MOL_W59_DEP`, `critProc.pre`): the chip shows one shell.
- **Hit (`Mole_nAttack.cs:90-175`):** on touching an enemy, `num = (int)((0.5 + 0.1 if Cannon Expert #401) × ATK)`, `floor(0.75 ×)` with `w_mol59`, then `mole.getCritPlus(num)` (standard Marshal 12 / Champion 18 table, `:19229-19378`); explosion `FindAreaTarget(point, (4 + ExtraPowderLv) × rangeMod, 4)`; each target takes `hit(1, t, floor(num × (1 − 0.5 × d / r)), KO 1, …)` (falloff `0.25` with Cannon Expert), `onNormalAttackHit`, `sp++`.
- **Card:** `atkCoeff` 0.5 / 0.6 with Cannon Expert, hit count Combo + 1, `critProc` with gear deps; value is the centre of the blast.

### mol_cAttack1-3 (Charge Attack, #111-113): burrow (verified 2026-10-01)

- Passive, Lv/Bn 4/1, 10/2, 16/3. `getChargeAttackLv()` 0-3 (`:10110`).
- `RPC_cAttack1` (`:21411-22647`): dig-in time `1.9 − 0.5 × SpeedDrill` s, `1 − 0.2 × SpeedDrill` with Super Dig #411 (`:21609`, `:22186`); underground `moveSpeed` lerps to `2 + 1.5 × SpeedDrill` (`:21818`), renderers hidden and collision with players ignored; every 0.2 s `removeLockStatus(2 × chargeLv − 1)` (`:21755-21769`); auto-surfaces after `4 × chargeLv` s (`digTimeOut`, `:21553`, `:21716`). Super Dig: `RPC_AddHeal(411, ceil(0.01 × mhp))` every 2 s while under and below max HP, real game modes only (`:21823-21860`). No damage immunity was found for the underground state (only hidden + no player collision).
- Release (`doReleaseCharge`, `:9938-10060`): Sky Drill when learned and underground for more than 3 s (see Sky Drill), else `RPC_cAttack0`.
- Tooltips: "max 4/8/12 sec" matches; English "lv2/3/4 lock" vs code levels 1/3/5 (`2 × rank − 1`), Thai "ต่ำกว่า 2/4/6" matches the code.

### mol_gadgeteer1-4 (Gadgeteer, #121-124) (verified 2026-10-01)

- Passive. Only read by the Workshop (`CompoundGui.cs:1190-1250`): each of #121-124 and Genius Invention #421 adds one tier to the Mole compound message index (`Language.getMessage("CompoundGui", 400 + n)`). Tooltip "toy lv 10/20/30/40": the numbers are toy levels (user 2026-10-29), so the cards say Gadgeteer reaches toy level 10 × rank and Genius Invention reaches the highest toy level, with no tier number. Not a combat skill. (`CharacterControl.cs` 121-124 hooks are Sheep/Penguin/Panda code.)

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

- Passive, Lv/Bn 24/15, 28/18, 30/21. `getExtraPowderLv()` 0-3 (`:11438-11480`). Radius `4 + lv`: Combo (`Mole_nAttack.cs:218`), Landmine (`:10575`), Mortar Shot (`:10850`), Stun Mine (`:11072`), Smart Shell (`:11535`), TNT (`:26033`), Bombardment (`:30323-30373`), Napalm (`:37669`); Time Nuke `20 + lv` (`Mole_timeNuke.cs:882`); Cart Bomb `6 + 1.5 × lv`, radius and height (`FindAreaTarget(hitPos, num, num)`, `:14177-14180`); Grenade Cluster `(int)(4 + 0.5 × lv)` (`Mole_grenadeCluster.cs:179`).

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
- **When the damage is computed (traced 2026-10-25).** `talAdjust(10 × sLv + 10)` is read inside `RPC_mine_hit` (`:10609`), which `Mole_mine.cs:379` calls when something triggers the mine, so it uses the Mole's TAL **at detonation**. Only the skill level (`mLv`, passed to the call) and the position are fixed at deploy. The card carries a Pro Tip.
- Tooltip "10/20/30/40 dmg"; code base 20/30/40/50.

### mol_stunMine1-2 (Stun Mine, #231-232) (verified 2026-10-01)

- **MP 5/10, no SP**, Lv/Bn 9/3, 15/5. The card's former 5 MP + SP 10/15 was wrong. CD `agiAdjust(45)`, `agiAdjust(23)` with Mine Lover (`:26680-26694`).
- `RPC_stunMine_hit` (`:11026-11265`): `FindAreaTarget(pos, 4 + ExtraPowderLv, 4, 130816)` — **every character layer**, so allies and the Mole are included; KO `10 × (sLv + (Grenade Cluster #432 ? 1 : 0))`, `floor(1.25 ×)` with Mine Lover; `hit(242 + sLv, t, 0, KO, …)` on every target without `insight`; with Smart Shell a same-layer target gets `KO 5 × sLv` instead. **No status is applied** (no `RPC_AddStatus` in Mole for it; the old card note "3 s paralysis" had no source).

### mol_stunGrenade1-2 (Stun Grenade, #233-234) (verified 2026-10-01)

- MP 5/10, SP −10/−15 (red), Lv/Bn 21/7, 27/9. CD `agiAdjust(60)` (`:27516`).
- Projectile speed 15, `life = 3 × rangeMod` (`Mole_stunGrenade.cs:28-92`, `:11272-11345`), `mLv = sLv + GrenadeCluster`. On contact: `FindAreaTarget(point, 6 × rangeMod, 4, 130816)` (every layer, no `insight` check); `hit(242 + mLv, t, 0, KO 10 × mLv, …)`; with Smart Shell same-layer targets get `KO 5 × mLv` and enemy-layer targets also `RPC_AddEffectDamage(264, 30)` (`Mole_stunGrenade.cs:200-290`).

### mol_smartShell1 (Smart Shell, #264) (verified 2026-10-01)

- Passive, Lv 33/Bn 24. The +30 Effect Damage and same-layer halving are documented in the Class C passive sweep below (re-checked this pass). Flame Carnival: halving only (`:39113-39125`).
- **Burst radius (verified 2026-10-28):** `RPC_smartShell_hit` takes `FindAreaTarget(hitPos, 4 + getExtraPowderLv(), 4, enemy layers)` and gives each target without `insight` `RPC_AddEffectDamage(264, 30)` (`Mole.cs:11535-11583`). Landmine and Stun Mine call it from their trigger when `getSmartShellLv() == 1` (`Mole_mine.cs:396-413`, `Mole_stunMine.cs:396-413`), and their own blasts are `4 + ExtraPowderLv` too (`Mole.cs:10575`, `:11072`), so the burst covers the mine's own circle: 4 m, +1 m per Extra Powder level. Flame Carnival's fire loop has no other Smart Shell hook (`Mole.cs:39102-39150`).
- **Stun Mine ally KO (re-checked 2026-10-28):** with Smart Shell a same-layer target gets a flat `KO 5 × sLv` (`Mole.cs:11092-11156`), not raised by Grenade Cluster or Mine Lover, so the card's "KO แค่ 10" is right.
- **Bible (2026-10-28):** the Smart Shell card names Extra Powder (burst +1 m per level, base 4 m) on every server; its TTO desc now drops only the ally bullet, so the Extra Powder line stays there too.

### mol_mineLover5 (Mine Lover, #402) (verified 2026-10-01)

- Passive, Lv 55/Bn 0. Landmine damage `floor(1.25 ×)` (`:10614-10620`) and base CD 15 → 8; Stun Mine KO `floor(1.25 ×)` and base CD 45 → 23. Tooltip "+50% and −50%" vs code ×1.25 and the replaced cooldowns.

### mol_grenadeCluster5 (Grenade Cluster, #432) (verified 2026-10-01)

- MP 10, SP −40 (red), Lv 75/Bn 4, instant. CD `agiAdjust(120)` (`:38123`).
- `RPC_grenadeCluster` (`:37853-38333`): 8 grenades (`i < 8`, `:38002`), each `rotateH(forward + random tilt, 45 × i)` (`:38009`); speed 6, `life = 5 × rangeMod` (`Mole_grenadeCluster.cs:28-88`, `:13787-13841`). On the first enemy contact: radius `(int)(4 + 0.5 × ExtraPowderLv)` (`:179`), height 3; `floor((1 − 0.5 × d / r) × (ATK + talAdjust(30)))`, `hit(342, t, …, KO 10, …)`. No crit.
- **One explosion per grenade, several grenades per target (traced 2026-10-19):** the grenade (`grenadeCluster_fire.prefab`: 0.25 m trigger box, rigidbody with gravity, layer 1) explodes in `OnTriggerEnter` on the first collider that is not on the owner's layer or layer 1 / 2, so an enemy's body **or the ground** (`Mole_grenadeCluster.cs:100-266`); the area is centred on `ClosestPointOnBounds` of what it touched (`FindAreaTarget`, `:206`), every target in it takes one `hit(342)`, and the grenade is destroyed (`:266`). It never hits in flight and again on landing. But the 8 grenades land about 4.5-5.5 m out, 45° apart, so neighbouring landing points are ~3.5-4 m apart, less than the 4 m radius (measured to the target's collider edge): a target near the ring or inside it is usually reached by its own grenade plus the two beside it (~3 hits, the side ones at roughly 55-60% from the falloff), and more with Extra Powder 2-3 (radius 5). There is no "already exploded" flag, and Unity runs `Destroy` at the end of the frame, so a grenade that touches two colliders in the same physics step (an enemy and the ground) could explode twice; that is engine behaviour, not something the code does on purpose.
- Passive part: Stun Mine / Stun Grenade KO level +1 (above).

### mol_timeNuke1-2 (Time Nuke, #271-272) (verified 2026-10-01)

- MP 45/60, SP −45/−60 (red), Lv/Bn 35/23, 40/25. CD `agiAdjust(360)` (`:30786`).
- `Mole_timeNuke` (993 lines): fixed 60 s countdown with an on-screen timer (`:29-75`); then `$detonate` (`:129-370`): `mDamage = talAdjust(100 × mLv + 50)` (`:334`), range `R = 20 + ExtraPowderLv` (`:882`), mask `130818` (every layer, `:892`); 4 rings 0.1 s apart (`i < 4`, `:279`), ring `i` = `FindAreaTarget(pos, floor(0.25 × (i + 1) × R), 5)`; each target without `insight` takes `hit(270 + mLv, t, floor(mDamage × (1 − 0.8 × d / R)), KO 3, …)` — halved for same-layer targets and `+ RPC_AddEffectDamage(264, 30)` for others when Smart Shell is learned (`:297-317`). Without Smart Shell allies and the Mole take the full hit. A target within `0.25 R` of the centre is in all 4 rings.
- **When the damage is computed (traced 2026-10-25).** `mDamage = talAdjust(100 × mLv + 50)` is evaluated inside `$detonate` (`Mole_timeNuke.cs:865`), on the owner's client only (`mChar.isMine`, `:848`), i.e. **at detonation** (fuse end or Detonate), with the Mole's TAL at that moment. Only `mLv` and the fuse start time are fixed at deploy. The card carries a Pro Tip.

### mol_detonate1 (Detonate, #273) (verified 2026-10-01)

- MP 24, SP −24 (red), Lv 45/Bn 27. CD `agiAdjust(360)` (`:31268`). Refused with "Cannot find TimeNuke to detonate" and MP/SP returned when no Time Nuke exists (`doSkill`, `Mole.cs:6740-6750`). Detonating early: `mDamage = floor(mDamage × Clamp(elapsedWholeSeconds × 0.0166, 0.1, 0.99))` (`Mole_timeNuke.cs:185`, `:336`).
- **First second (verified 2026-10-28):** placing sets the start time (`Mole_timeNuke.cs:56-59`), the press stores `elapsed = FloorToInt(Time.time − placed)` (`:472-481`), and `$detonate` applies the clamp only when `elapsed != 0` (`:865-876`), so a Detonate within 1 s of placing deals the full 100 %, like the natural fuse, which never sets it. ToT and TTO report no change, so they follow BB; Reborn bible3 floors `elapsed` at 1 (Reborn section, "Detonate in the first second").
- **Bible (2026-10-28):** the base desc (BB / ToT / TTO) names the first-second exception; the Reborn desc keeps the plain 10-99 % wording. (Superseded the same day, next bullet.)
- **Bible (2026-10-28, open-decision pass):** the first-second full damage is a code defect, so it moved out of the desc into a `bbBug` chip (BB / ToT / TTO; `Mole_timeNuke.cs:478`, `:870-876`). The desc is the plain 10-99 % wording on every server, and the Reborn tab has no desc of its own and clears the chip (`bbBug: ""`), because bible3 floors the elapsed time at 1 (`Reborn1027:Mole_timeNuke.cs:49`, `:162-164`).

### mol_flameCarnival5 (Flame Carnival, #442) (verified 2026-10-01)

- **MP 35**, no SP, Lv 85/Bn 6. The card's former "free" cost was wrong. CD `agiAdjust(150)` (`:38662`).
- Trap prop lives `chaAdjust(90)` (`Mole_flameCarnival.cs:30`), fires `RPC_flameCarnival_fire` on an enemy-layer contact (`:69-79`). Fire (`:38844-39324`): 20 pulses (`i < 20`, `:39033`), `FindAreaTarget(pos, Clamp(2 + i, 3, 5), 2, 130816)` (every layer); each target without `insight` and not `Robots`/`Structure` takes direct `RPC_AddDamage(442, talAdjust(10), …)` (no `dmgAdjust`/`defAdjust`), halved for same-layer targets with Smart Shell (`:39102-39150`).

### mol_flameTurret1-3 (Flame Turret, #241-243) (verified 2026-10-01)

- SP −24/−28/−32 (red), Lv/Bn 16/4, 20/8, 24/12, instant self. CD `agiAdjust(120)` (`:28225`).
- `RPC_flameTurret` (`:27714-28462`): the Mole itself stands as the turret (`moveSpeed 0`) for `chaAdjust(5)` s (`:27935`); left/right input turns it 45° (`RPC_flameTurret_rotate`, `:28078-28130`). Every 0.25 s (`mUpdateTimer = Time.time + 0.25`) `FindRecTarget(pos + fwd, fwd, 1, 2, 12, 4, enemy layers)` (`:28144-28149`); each target that is not `Robots`/`Structure` takes direct `RPC_AddDamage(231 + sLv, talAdjust(5 × sLv), KO 0, …)` (`:28188-28200`) — no `dmgAdjust`/`defAdjust`, no `insight` check. Tooltip "5/10/15 × 20" matches.

### mol_fireBarrage1-2 (Fire Barrage, #251, #253) (verified 2026-10-01)

- **MP 10/15, SP 20/30 blue**, Lv/Bn 20/12, 28/18. The card's former MP 10/20, SP 20/35 was wrong. CD `agiAdjust(120)` (`:28602`).
- `RPC_fireBarrage_fire` (`:29181-29290`): rank 1 one aircraft effect, rank 2 three (±30°, `:29181-29204`) — visual only. 4 waves (`i >= 4` exit, `:29228`), all at the same point: `FindAreaTarget(mPos, 2 × sLv + 1, 3, enemy layers)` (`:29240`), `hit(250 + sLv, t, talAdjust(5 + 10 × sLv), KO 1, …)` (`:29259`), no falloff. **Card correction:** 4 hits at both ranks (was 4 × 3 at rank 2). Tooltip "15/25 × 4" matches.

- **Where it lands (traced 2026-10-16).** `mode instant`, `target enemy` (`decode_skilldata.py`); for an instant skill the UI still passes the current selection (`targetObject`, `GameGui.cs:37715-37735`). With a target, `mPos = target − (unit direction Mole → target)`, i.e. **1 m in front of the target** on the Mole's side, with no distance check of its own, so the reach is the **40 m target lock** (`Mole.cs:8539`, `:8552`). With no target and the cursor in the top 80 % of the screen, the cursor's ground point by a **40 m raycast from the camera** (`Math.getScreenPosition`, layer mask 5; a miss refunds with "Cannot find target position", `:8571`); otherwise **12 m straight ahead** (`:8596`). Bombardment uses the same three branches (`:8373`, `:8384`, `:8450`, `:8480`), so its 5-strike line also starts from the point 1 m in front of the target.
- **Timeline and when the damage is computed (traced 2026-10-25).** After the skill resolves, `RPC_fireBarrage` waits `WaitForSeconds(2)` (`Mole.cs:28819`) before it starts `RPC_fireBarrage_fire` (`:28612`); that coroutine spawns the aircraft and waits `1.3` s (`:29281`), then runs the 4 waves 0.1 s apart (`:29285`). Each wave runs `FindAreaTarget` (`:29240`) and `hit(…, talAdjust(5 + 10 × sLv), …)` (`:29259`) itself, owner's client only (`isMine`). Hits land **3.3 / 3.4 / 3.5 / 3.6 s after the cast**, each with the Mole's TAL and the targets in the area **at that wave**; only `sLv` and the aim point are fixed at the cast. The card carries a Pro Tip.

### mol_bombardment1-2 (Bombardment, #252, #254) (verified 2026-10-01)

- **MP 20/30, SP 35/55 blue**, Lv/Bn 24/15, 32/21. The card's former MP 20/35, SP 35/50 was wrong. CD `agiAdjust(180)` (`:29483`), fired after a 4 s wait (`:29700`).
- `RPC_bombardment_fire` (`:29738-30110`): 5 strikes (`i >= 5` exit, `:29902`) at `mPos + tDir × (3i − 6)` (`:29912`), i.e. −6/−3/0/+3/+6 m along the line.
- `RPC_bombardment_hit` (`:30119-30490`): `FindAreaTarget(pos, 4 + ExtraPowderLv, 5, enemy layers)` (`:30333`); rank 2 adds two more areas at `(±3, 0, −3)` rotated to `tDir`, merged with `Math.combineArray` (de-duplicates, `Math.cs:335-420`), so one strike hits a target once (`:30338-30349`). `hit(252 + sLv, t, talAdjust(10 + 15 × sLv), KO 1, …)` (`:30383`); `hitDistance` is computed (`:30373`) but **not used** — no falloff.
- **Card:** hit count 3 (a target at the aim point is inside the 0 and ±3 m strikes; ±6 m needs radius ≥ 6, i.e. Extra Powder). Was 5 × 3. **Tooltip discrepancy:** "35/55 dmg × 5"; code base 25/40.
- **Timeline and when the damage is computed (traced 2026-10-25).** After the skill resolves, `RPC_bombardment` waits `WaitForSeconds(4)` (`Mole.cs:29700`) before it starts `RPC_bombardment_fire` (`:29493`); that coroutine spawns the effects, waits `1.2` s (`:30071`), then starts one `RPC_bombardment_hit` per strike every 0.1 s (`:30073`, `:29929`). Each hit coroutine waits `0.2` s + `0.4` s (`:30447-30449`) and only then runs `FindAreaTarget` (`:30333`) and `hit(…, talAdjust(10 + 15 × sLv), …)` (`:30383`), owner's client only. Hits land **5.8 / 5.9 / 6.0 / 6.1 / 6.2 s after the cast**, each with the Mole's TAL and the targets in the area **at that strike**; only `sLv`, the aim point and the line direction are fixed at the cast. The card's "about 4 s" counts only the first wait. The card carries a Pro Tip.

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
- `RPC_autoGyroGun_create` (`:11751-12160`): prefab `AutoGyroGun1-4`, `isSummon`, life `chaAdjust(120)` (`create(…, chaAdjust(120))`, `AutoGyroGun.cs:1610-1740`). Base stats from `Awake` (`AutoGyroGun.cs:42-140`): all eight stats `10 × sLv`, HP `50 × sLv`. Hidden Turret #403 overrides them (`:12141-12160`): ATK/DEF `(int)(0.25 × sLv × Lv)`, AGI/VIT/MAG/CHA/TAL/LCK `(int)(0.125 × sLv × Lv)`, MHP `ceil(10 × VIT)`. Heavy Built: MHP `ceil(MHP × (1 + 0.5 × lv))` (`:12203-12210`). No turret count limit in the client (TTO's 8/12 cap is server-side, see Server Balance Variations (TTO); this line said ToT until 2026-10-28).
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
- Passive part: Mega Punch and Mega Hammer damage **and KO** `floor(1.5 ×)` (`hitDmg` `:32494` / `:33087`, `hitKo` `:32499` / `:33092`, inside `hasSkill(433)` `:32488` / `:33081`; re-checked 2026-10-26, the Mega Drill card had said damage only); Barrel Bot gets `drillLv = 1` (`RPC_barrelBot_create`, `:12939`). Card correction: hit count 4 (was 1).

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

- `BarrelBot.RPC_cannon` (`BarrelBot.cs:5030-5340`), needs CannonLv (Mole has #443): CD `agiAdjust(9)` (`:5278`); shell (`BarrelBot_cannon.cs`) bursts on a non-own-layer collider → `RPC_cannon_hit` (`BarrelBot.cs:1840-1910`): `FindAreaTarget(hitPos, 3, 4, enemy layers)`, `hit(1, t, floor(1.5 × ATK), KO 1, …)`. **Shell travel (decoded 2026-10-16):** the shell flies straight at 15 m/s (`BarrelBot_cannon.cs:26`, prefab rigidbody without gravity) for `ProjectileControl.life` = **3 s** (not set in code; read from `cannon_fire` in the original client data, `sharedassets16.assets`), so it reaches at most **45 m** from the bot. Same shell for Barrel Cannon #443.

### mol_barrelCannon5 (Barrel Cannon, #443) (verified 2026-10-01)

- SP 50 **blue**, Lv 85/Bn 6, target. CD `agiAdjust(120)` (`:40199`).
- `RPC_barrelCannon` (`:39835-40300`): starts `RPC_cannonForm` on the bot (`:39989-40038`) and on the Double Bot second bot (`:40053-40104`). `RPC_cannonForm` (`BarrelBot.cs:5377-5800`): the bot stands still and fires at the Mole's target every 0.5 s (`:5544`, `:5743`) until 10 shells (`mCannonCount >= 10`, `:5716`) or the target is gone; each shell is the cannon hit above. Passive part: CannonLv for the bot (`:13035`); the tooltip's "bombing attack on Mole's Chopper" is covered under Chopper.
- **Bible (2026-10-28):** the Barrel Cannon card mirrors the Chopper blast (`Mole.cs:33957-33986`, learned check `:33695`) with a **Chopper:** line: every one of the 10 ticks also blasts around the Mole, `talAdjust(20)`, KO 0. The line leaves out the 5 m size, which the Chopper card carries (a radius in this desc would need a matching `reach`).

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

- Passive, Lv/Bn 24/15, 28/18. `getHeavyBuiltLv()` (`:13213`): MHP `ceil(MHP × (1 + 0.5 × lv))` after the other stat changes for Auto Gyro Gun (`:12203`), Barrel Bot (`:12765`) and King Kaiser (`:35925`). The Thai tooltip is one line for both levels, "อีก 50%": one more +50% per level, which matches the code (not a mismatch, corrected 2026-10-27).

### mol_synchroMole1-2 (Synchro Mole, #363-364) (verified 2026-10-01)

- MP 15/25, **SP −25 (red) at both ranks**, Lv/Bn 30/21, 33/24. The card's former SP 25/35 was wrong. CD `agiAdjust(300)`.
- `RPC_synchroMole` (`:13220-13300`): `RPC_AddStatus("synchroMole", sLv, chaAdjust(30), value = Mole TAL)` on the Mole, and the same status for `chaAdjust(30) + 1` s on every own `AutoGyroGun1-5` / `BarrelBot1-5` summon present at cast (not King Kaiser / War Factory). Non-Mole, non-Robots targets refuse it (`CharacterControl.cs:12466-12470`).
- Effect (`CharacterControl.cs:37714-37777`): `deltaAtk/deltaDef(+floor(0.5 × sLv × value))` on the summons; removal subtracts the same (`:16978-17025`), and the Mole's own removal calls `RPC_synchroMole0`, which strips it from its summons (`Mole.cs:13514-13560`). Buff + State status (`StatusData.cs:4938`, `:6746`). A recast refreshes instead of stacking (`CharacterControl.cs:14103-14182`); summons made after the cast do not get it.
- **Status value (verified 2026-10-28):** `value = mChar.tal` at the cast, for the Mole (`Mole.cs:13242`) and for every own summon present (`:13267-13370`); the summons apply `deltaAtk` / `deltaDef(floor(0.5 × sLv × value))` (`CharacterControl.cs:37772-37777`): +50 % / +100 % of the Mole's TAL at level 1 / 2, fixed at the cast.
- **Bible (2026-10-28):** the Auto Gyro Gun and Barrel Bot cards name Synchro Mole on every server (the hand-written TTO Auto Gyro Gun desc too).
- **App fix:** the summon-stat toggle was Rank 2 only (`floor(TAL)`); it is now a 0-2 rank toggle (`floor(0.5 × rank × TAL)`), id `synchroMole`.

### mol_doubleBot5 (Double Bot, #423) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. Barrel Bot: keeps the previous bot as a second bot (`:12415-12430`) and adds `(int)(0.5 × Lv)` to every stat, MHP `10 × VIT` (`:12708-12725`); Barrel Cannon commands both bots (`:40053-40104`). Tooltip matches.

### mol_advanceRepair5 (Advance Repair, #431) (verified 2026-10-01)

- SP −10 (red), Lv 75/Bn 4, ally target. Cast check (`doSkill`, `:7048-7150`): the target must be `Robots` or `Structure` race and within 2 m (edge distance), else MP/SP returned. CD `agiAdjust(30)` (`:36716`).
- `RPC_advanceRepair` (`:36263-36900`): channel; every 1 s `sp − 1` and `target.hp = min(hp + 150, mhp)` (direct, no heal modifiers, `:36681-36689`); stops on movement input, target farther than 2 m, or SP below 5 (`:36573-36631`). Passive part: Reload's extra reset list (see Reload).

### mol_geniusInvention5 (Genius Invention, #421) (verified 2026-10-01)

- Passive, Lv 70/Bn 3. Workshop tier 5 (`CompoundGui.cs:1249`, `:1852`). Item cooldowns for a Mole with #421 (`GameGui.cs:32730-32790`): firework 3 → 1 s, bomb 30 → 15 s. (`CharacterControl.cs:13421` and the other classes' #421 hooks are not Mole's.)
- **Giga Cannon (verified 2026-10-28):** the `o_mol3` mount is refused without #421 ("Require geniusInvention skill.", `GameGui.cs:36371-36377`; see the mounts section). **Bible (2026-10-28):** the Genius Invention card names Giga Cannon.

### mol_kingKaiser1 / mol_kaiserCannon1 / mol_kaiserBeam1 (King Kaiser #371, Kaiser Cannon #372, Kaiser Beam #373) (verified 2026-10-01)

- King Kaiser: MP 80, SP −80 (red), Lv 35/Bn 23, instant self. CD `agiAdjust(999)` (`:35380`). Kaiser Cannon (Lv 40/Bn 25) and Kaiser Beam (Lv 45/Bn 27) are passives; the card's rank 1-3 is `getKaiserLv()` (`:13607-13620`).
- `RPC_kingKaiser_create` (`:35536-36000`): lasts `chaAdjust(240)` (`:35789`); the Kaiser is not a summon (`isSummon = false`, `:35870`); Heavy Built MHP `ceil(× (1 + 0.5 × lv))` (`:35925-35936`); `summon(getKaiserLv())` (`:35995`) sets ATK `150 + 50 × lv`, DEF `100 + 50 × lv` (`KingKaiser.cs:3991-3997`). MHP 2000 from the prefab (see `kingKaiserOwnStats`; re-decoded 2026-10-01: `KingKaiser_b` `CharacterControl` @ `resources.assets` 45046984 → HP/MHP 2000, AGI 100, VIT 200, MAG 75, CHA 200, TAL 150, LCK 75; user confirmed 2000). **Tooltip discrepancy:** "1500 hp" (TTO's value, not BB's; see Server Balance Variations). Card `tooltipNote` on King Kaiser and King Kaiser - Normal Attack, cleared on TTO. `KingKaiserAI.cs` is unreachable for the player's Kaiser (`isControlled = true`, `:35865`). Each cast uses one Kaiser Battery item `m_kbt1` (checked `:7007`, removed `:35684`). The Kaiser's own `CharacterControl` never calls `hasSkill`, so Revised Art does not reach its attack cooldowns.

### mol_kingKaiser_nAttack (King Kaiser normal attack) (verified 2026-10-01)

- `KingKaiser.doNormalAttack` (`KingKaiser.cs:900-930`): when `nAttack` is ready; at Kaiser level ≥ 2 and a target farther than 10 m (`sqrMagnitude > 100`) it fires Kaiser Cannon instead.
- `RPC_nAttack` (`KingKaiser.cs:1471-2270`): 3 swings, `addTimeOut("nAttack", 4)` (`:2179`): `FindRecTarget(pos + right, fwd, 2, 2, 5, 3)` → `hit(1, t, ATK, KO 1)` (`:1657-1680`), `FindRecTarget(pos, fwd, 1.5, 1.5, 4, 3)` → `hit(2, t, (int)(1.2 × ATK), KO 1)` (`:1862-1885`), `FindRecTarget(pos + (−1, 0.5, −2), fwd, 2.5, 2.5, 6, 2)` → `hit(3, t, (int)(1.3 × ATK), KO 1)` (`:2008-2031`); Kaiser `sp + 1` per target on swings 1 and 3 (`:1686`, `:2037`).
- **Kaiser Cannon branch (verified 2026-10-28):** `doNormalAttack` checks `nAttack` off timeout, `mLv > 1` (`getKaiserLv`: 2 with #372, 3 with #373, `Mole.cs:13607-13634`) and a flat target vector with `sqrMagnitude > 100`, then starts `RPC_kaiserMissile` instead of `RPC_nAttack` (`KingKaiser.cs:949-984`); both arm `addTimeOut("nAttack", 4)` (`:2179`, `:2711`), so the swing and the cannon share one 4 s lock.
- **Bible (2026-10-28):** King Kaiser - Normal Attack names Kaiser Cannon, Kaiser Cannon names the swing it replaces, and the two cards link each other.

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
- `RPC_warCapital_create` (`:14239-14480`): destroys the previous War Capital, `isSummon`, starts `OnWarCapital`. It lives until destroyed or the Mole dies (`Mole_warCapital.cs:100-170`). No Heavy Built. **Own stats (prefab, decoded 2026-10-01):** `warCapital` `CharacterControl` @ `resources.assets` byte 47655048 (corrected 2026-10-25, the earlier 44560960 held unrelated data; 708 bytes; same field layout as King Kaiser, calibrated on Gaos @ 44478976 and King Kaiser_b @ 45046984): HP/MHP **1500**, ATK/DEF/AGI/VIT/MAG/CHA/TAL/LCK **150** each, MP/SP/KO 10. No runtime code overwrites them. The missiles use the Mole's `talAdjust`, not the base's TAL.
- `OnWarCapital` (`:43591-43930`): every 24 s, if `FindAreaTarget(Mole pos, 36, 10)` finds enemies (`:43842-43880`), `RPC_warCapital_fire` (`:43981-44270`) fires 8 missiles 0.25 s apart (`BB:Mole.cs:43927`; 0.15 s is the muzzle-flash loop, `:44267`), each at a random target + up to 2 m random offset (`:43749-43806`). `RPC_warMissile_hit` (`:14589-14660`): `FindAreaTarget(point, 1, 1)`, `hit(−4444, t, talAdjust(50), KO 3, …)`. Tooltip "50 dmg × 8, Hp 1500" matches.
- **Whose stats (re-checked 2026-10-02):** `RPC_warMissile_hit` is a method of the Mole script and calls `this.mChar.hit(-4444, t, this.mChar.talAdjust(50), 3, …)` (`Mole.cs:14658`), so the damage uses the **Mole's** TAL and LCK; the base's own stats feed nothing. Card: reference-only "War Capital Stats" table (`warCapitalOwnStats()`), every cell shown as not used; the damage formula reads the player's TAL.

### Mole-only mounts: moleTank (Mole's Tank, `o_mol2`) and gigaCannon (Giga Cannon, `o_mol3`) (verified 2026-10-04)
These are mount items, not skills: no skill number, no MP/SP cost.
- **Items** (`MountData.cs:421-460`): `o_mol2` "Mole's Tank" is item Lv 35; `o_mol3` "Giga Cannon" is item Lv 60.
- **Using the item** (`GameGui.cs:36296-36377`):
  - Both refuse a non-Mole ("Only moles can use this mount.").
  - Stage mana is `5` for the tank and `50` for the Giga Cannon, charged only when `Game.mGameType > 3` (`:36500-36560`).
  - The English tooltip's "Uses 20 mana" for the tank is wrong (`MountData_eng.cs:191`). The Thai string says 5.
  - Giga Cannon also needs `hasSkill(421)` Genius Invention ("Require geniusInvention skill."), is refused when `mGameType <= 3` ("Cannot use mount here"), and allows one per team: any `GigaCannon` already on the player's layer blocks it ("Only one GagaCannon is allowed per team.", also re-checked in `Mole.cs:50128-50182`).
- **Cast:** `Mole.RPC_useMount` casts `magAdjust(6)` for every Mole mount (`Mole.cs:50331-50337`). `CharacterControl` then loads `MoleTank` / `GigaCannon` (`:45450-45462`) as a player-controlled `isTransform` character and calls `onMount(rider)`.
- **Stats** (`MoleTank.cs` / `GigaCannon.cs` `onMount`):
  - Each stat is the rider's `getNoDeltaStat` (base, no buff deltas).
  - Tank: DEF +50, VIT +50. Giga Cannon: DEF +50, VIT +500.
  - `mhp = 10 × vit`, `mmp = 3 × mag`, `msp = floor(0.2 × tal) + 10`.
  - `mko = floor(def / 3) + 10` (tank) or `+ 150` (Giga Cannon).
  - Current HP / MP / SP / KO copy the rider's fractions.
  - So every hit uses the Mole's base ATK and LCK.
- **moleTank_cannon** (`MoleTank.cs` `RPC_nAttack`, `MoleTank_nAttack.cs`):
  - Normal attack while `moveSpeed <= 2`, disabled when `Game.mGameType < 4`. Cooldown `addTimeOut("nAttack", 0.5)`.
  - The shell flies at 36 for `2 × rangeMod` s and explodes on the first collider not on the tank's layer.
  - Explosion: `FindAreaTarget(hit − 0.5 up, 5, 3)`, `hit(1, ATK, KO 1)` per target.
- **moleTank_ram** (`RPC_rAttack`):
  - Triggered by a normal attack while `moveSpeed > 2`, or by any charge. Shares the `nAttack` timeout and sets it to 2 s.
  - Dashes at speed 6. Six checks 0.15 s apart, each `FindRecTarget(pos, forward, 1, 1, 3, 3)` (2 m wide, 3 m long) with `hit(1, (int)(0.75 × ATK), KO 4)`, so up to 6 hits on a target that stays in front.
- **gigaCannon_shot** (`GigaCannon.cs` `RPC_nAttack` / `RPC_nAttack_hit`):
  - The turret never moves. Horizontal input turns `cannon1` at 12°/s; vertical input sets `cannon2` elevation, clamped to 30-90°.
  - Cooldown `addTimeOut("nAttack", 6)`, with an on-screen countdown (`OnGUI`). `RPC_create` sets the same 6 s timeout, so the first shot also waits.
  - Projectile: `mVelocity (0, 0, 30)` with a gravity Rigidbody (prefab `nAttack_fire`), life 6 s. On a 45° shot over flat ground that is about 92 m.
  - Explosion: `FindAreaTarget(hit − up, 24, 6)`, `hit(1, floor(1200 × (1 − 0.5 × dist / 24)), KO 10)`, i.e. 1,200 at the centre down to 600 at 24 m, then the usual `dmgAdjust` / `defAdjust`.
  - Charging only shows "GigaCannon doesn't need charge attack!".

## Skill Tree Layout & Learn Requirements

Verified 2026-10-12 for the Skill Simulator (rules: [12Tails-Mechanics-Reference.md §3.6](12t_reference/12Tails-Mechanics-Reference.md#36-skill-learning-rules-class-skill-window-verified-2026-10-12)). Each cell is `name Lv/points`: required level / skills already learned in the same tree. Cell number = `tree*100 + row*10 + column` (trees 1-4 = Engineer, Bomber, Machinist, War Machine). Source: `MoleSkill.getSkill` (`setReq`, `rSkill`) and `MoleSkill.getSkillTree`.

**Engineer** (tree 1)

| Row | Cells |
|---|---|
| 1 | N Attack 1 1/0 · N Attack 2 2/1 · N Attack 3 3/2 · N Attack 4 4/3 |
| 2 | C Attack 1 4/1 · C Attack 2 10/2 · C Attack 3 16/3 · — |
| 3 | Gadgeteer 1 6/2 · Gadgeteer 2 12/4 · Gadgeteer 3 18/6 · Gadgeteer 4 24/8 |
| 4 | Reload 1 32/6 · Reload 2 40/10 · — · — |
| 5 | Stat Plus 1 10/4 · Stat Plus 2 20/6 · Stat Plus 3 30/8 · Stat Plus 4 40/10 |

**Bomber** (tree 2)

| Row | Cells |
|---|---|
| 1 | Mine 1 3/0 · Mine 2 9/1 · Mine 3 15/2 · Mine 4 21/3 |
| 2 | Mortar Shot 1 5/1 · Mortar Shot 2 11/3 · Bunker 1 17/5 · Bunker 2 23/7 |
| 3 | Tnt 1 7/2 · Tnt 2 13/4 · Tnt 3 19/6 · Tnt 4 25/8 |
| 4 | Stun Mine 1 9/3 · Stun Mine 2 15/5 · Stun Grenade 1 21/7 · Stun Grenade 2 27/9 |
| 5 | Flame Turret 1 16/4 · Flame Turret 2 20/8 · Flame Turret 3 24/12 · — |
| 6 | Fire Barrage 1 20/12 · Bombardment 1 24/15 · Fire Barrage 2 28/18 · Bombardment 2 32/21 |
| 7 | Extra Powder 1 24/15 · Extra Powder 2 28/18 · Extra Powder 3 30/21 · Smart Shell 33/24 |
| 8 | Time Nuke 1 35/23 · Time Nuke 2 40/25 · Detonate 45/27 · — |

**Machinist** (tree 3)

| Row | Cells |
|---|---|
| 1 | Auto Gyro Gun 1 3/0 · Auto Gyro Gun 2 9/1 · Auto Gyro Gun 3 15/2 · Auto Gyro Gun 4 21/3 |
| 2 | Speed Drill 1 5/1 · Speed Drill 2 11/3 · Sky Drill 1 17/5 · Sky Drill 2 23/7 |
| 3 | Barrel Bot 1 7/2 · Barrel Bot 2 13/4 · Barrel Bot 3 19/6 · Barrel Bot 4 25/8 |
| 4 | Mega Punch 1 9/3 · Mega Punch 2 15/5 · Mega Hammer 1 21/7 · Mega Hammer 2 27/9 |
| 5 | Chopper 1 16/4 · Chopper 2 20/8 · Chopper 3 24/12 · — |
| 6 | Missile 1 20/12 · Missile 2 24/15 · Missile 3 28/18 · Missile 4 32/21 |
| 7 | Heavy Built 1 24/15 · Heavy Built 2 28/18 · Synchro Mole 1 30/21 · Synchro Mole 2 33/24 |
| 8 | King Kaiser 35/23 · Kaiser Cannon 40/25 · Kaiser Beam 45/27 · — |

**War Machine** (tree 4)

| Row | Cells |
|---|---|
| 1 | Cannon Expert 55/0 (needs 104) · Mine Lover 55/0 (needs 204) · Hidden Turret 55/0 (needs 304) · Revised Skill 55/0 |
| 2 | Super Dig 60/1 (needs 113) · Napalm 60/1 (needs 214) · Sky Shaker 60/1 (needs 314) · Revised Magic 60/1 |
| 3 | Genius Invention 70/3 (needs 124) · Super TNT 70/3 (needs 224) · Double Bot 70/3 (needs 324) · Revised Art 70/3 |
| 4 | Advance Repair 75/4 (needs 132) · Grenade Cluster 75/4 (needs 234) · Mega Drill 75/4 (needs 334) · War Factory 75/4 (needs 243 + 343) |
| 5 | Super Stat Plus 85/6 (needs 144) · Flame Carnival 85/6 (needs 243) · Barrel Cannon 85/6 (needs 343) · War Capital 85/6 (needs 434) |

- **Class C prerequisites** (`rSkill`, the last skill of the row above it): Cannon Expert 104, Super Dig 113, Genius Invention 124, Advance Repair 132, Super Stat Plus 144, Mine Lover 204, Napalm 214, Super TNT 224, Grenade Cluster 234, Flame Carnival 243, Hidden Turret 304, Sky Shaker 314, Double Bot 324, Mega Drill 334, Barrel Cannon 343; War Factory needs Flame Carnival's tree skill 243 and Barrel Cannon's 343 together (`rSkill 243343`); War Capital needs War Factory (434).
- **Checked against the 2014 community simulator** (Rain Niar's Mole SkillSimulator V.3; the 3.1 versions are offline) **and TailsTailsSimulator.online/mole**: 95 of 97 cells have the same Lv / points in all three. The two differences: Extra Powder II and Heavy Built II are **Lv 28 / 18 pts in the game code and Lv 27 / 18 pts in both simulators** (the row pattern 24, 27, 30 fits their value). **Needs a live check:** both cells are empty `getSkill` branches (`MoleSkill.cs:580`, `:943`) with no `setReq` of their own, so the decoder's 28 comes from the shared tail they fall into, the same situation as Rabbit's Customized Shotgun II. Both outside simulators' grids are otherwise the same as the code (17 / 30 / 30 / 20 cells; the site's extra Class C row is ignored, the user says there are no EX skills).
- **SP / MP cost differences** (decoder vs both simulators; the Bible cards already follow the decoder): Detonate 24 SP + 24 MP, Napalm SP 40, Mega Drill SP 36 and Barrel Cannon SP 50 are missing or different in the simulators (they list Mega Drill none, Barrel Cannon 36); King Kaiser SP 80 / MP 80 (simulators SP 55 / MP 80); Flame Carnival MP 35 (simulators SP 10); War Capital MP 100 + SP 50 (simulators SP 50 only); Kaiser Cannon is SP 70 in the simulators and has no cost in the decoder output. The simulator tool shows no costs, so none of these changed it.

## Thai tooltip mismatches (scan 2026-10-27)

Every number in the BB Thai tooltip (`MoleSkill_thai.cs`) was compared with the app card, then each suspect with the code. Each row is a card `tooltipNote`.

| Skill | Thai tooltip says | Code says | Source |
|---|---|---|---|
| Mortar Shot | +10 dmg per shell | `talAdjust(15)` = **+15** | `Mole.cs:10886` |
| Barrel Bot - Mega Punch | +10 / +20 dmg | bot `talAdjust(12 × PunchLv)` = **+12 / +24**; the tooltip gives the Mole's own Mega Punch (`10×sLv`, `Mole.cs:32478`) | `BarrelBot.cs:2775` |
| Barrel Bot - Mega Hammer | +12 / +24 dmg | bot `talAdjust(10 × HammerLv)` = **+10 / +20**; the tooltip gives the Mole's own Mega Hammer (`12×sLv`, `Mole.cs:33071`) | `BarrelBot.cs:3170` |
| King Kaiser, King Kaiser - Normal Attack | 1500 hp | BB **2000** (prefab); 1500 is TTO's | see `RPC_kingKaiser_create` above |

## Server Balance Variations (TTO)

Private-server values are documented from the Bible skill-detail schema; the BigBug decompile remains the original-server baseline.

| Skill | Original BigBug baseline | TTO delta |
|---|---|---|
| Auto Gyro Gun | No simultaneous-turret limit is represented on the original card. | Cap is 8 guns without Hidden Turret or 12 with Hidden Turret. |
| Flame Turret | The Mole stays a turret for its full `chaAdjust(5)` s (`Mole.cs:27935`). | **Buff:** pressing the skill again during it ends it early (user-reported TTO patch, 2026-10-23; server-side, not in `DecompiledSource/`; card `servers.tto`). |
| Smart Shell | Allies inside the blast take half: Stun Mine / Stun Grenade KO halved, Time Nuke / Flame Carnival damage halved (Smart Shell entry above). | Does not reduce damage dealt to allies (user-reported 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tto`). |
| King Kaiser; King Kaiser - Normal Attack / Kaiser Cannon / Kaiser Beam | MHP 2000, then Heavy Built applies `ceil(MHP×(1+0.5×rank))` → 2000 / 3000 / 4000. | **Nerf:** MHP is fixed at 1500 and Heavy Built does not apply. The server selector is present on the parent and all three child cards because their shared own-stat block changes; since 2026-10-26 Heavy Built has a TTO tab too, whose desc drops King Kaiser from its list. |

Source of server delta: `12t_projects/bible/index.html:9160`.

On the cards (2026-10-28): Hidden Turret has a TTO desc that names the 12-gun cap (8 without it), the mirror of the Auto Gyro Gun TTO desc. Time Nuke and Flame Carnival have TTO descs without the Smart Shell ally halving (BB halving `Mole_timeNuke.cs:732-767`, `Mole.cs:39113-39125`): Time Nuke keeps only the +30 Effect Damage on enemies, and Flame Carnival loses its Smart Shell line (the halving was its only effect there). Both rest on the user report in the Smart Shell row. **Decided 2026-10-28** (Open items, 2): only the damage halving is gone; the ally KO cut on Stun Mine / Stun Grenade stays as BB on TTO.

**Bible (2026-10-28, open-decision pass):** the TTO tabs of Time Nuke and Flame Carnival carry a change note taken from the Smart Shell TTO note (allies in the blast take full damage, not half), and Hidden Turret's carries the Auto Gyro Gun TTO cap (no cap → 12 guns with Hidden Turret, 8 without). On TTO, Smart Shell and Flame Carnival no longer list each other (`servers.tto.compatSkills`): the halving was Smart Shell's only effect on Flame Carnival (`Mole.cs:39102-39150`), so on TTO neither card's desc names the other. The base and Reborn lists keep the link.

## Server Balance Variations (Reborn)

Reborn client (`DecompiledSource_Reborn_2026-10-25/Assembly-CSharp/`), checked 2026-10-26. Citation tags as in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md). Cards: `servers.reborn`.

- **War Capital (Nerf, already on the card):** MP 100 → 250, SP 50 → 100 (`BB:MoleSkill.cs:1592`, `Reborn:MoleSkill.cs:506`); the base lives at most 30 minutes (`Reborn:Mole_warCapital.cs:175`, `:181`, `:198-207`). Full audit: [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §7.4.
- No other original Mole skill has a Reborn card change: the remaining differences are open-world zone gates, global rules (gear crit, item chances, stat caps, SP ceiling, faster AI target scans) or C6 / C7 hooks, all kept off the cards by the user's decisions of 2026-10-26.
- **Gear crit (Adjust; `mole_nAttack`):** BB `getCritPlus` rolls `lckAdjust(gear sum)` (`BB:Mole.cs:19229`). Reborn adds `RebornBalance.TrinketCritPlus` (+3 for `t_all61`-`63`) and the seal `critical` (`RebornEffects.CritPlus`, server data, not modelled) and rolls `lckItemAdjust(sum)` = `ceil(1.3 × sum)` with no LCK (`Reborn:Mole.cs:18041`, belt `:18071`, roll `:18073`). In the app: the shared Reborn rule (`critChance`, `procChance`, `itemChance`) and the belt toggle `REBORN_BELT_DEP`; [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §2.2, §2.4.

### Review corrections (2026-10-26)

- ICBM: the blast is a normal `hit(453, …, KO = within 5 m ? 100 : 50)` (`Reborn:RebornC6.cs:2265-2266`), so `koAdjust` caps it at 99: card KO "50–99". The KO 100 Effect Damage at `Reborn:RebornIcbm.cs:1088` is the launch pad's own destruction.
- Start-of-map cooldown (every combat map: missions, PvP and combat zones, `RebornZone.CombatMap`, `Reborn:RebornZone.cs:28-38`; Revised Art applies, `Reborn:CharacterControl.cs` `addTimeOut`; card bullet on each): Air Strike `agiAdjust(180)`, ICBM `agiAdjust(240)`, Giga Drill `agiAdjust(300)`, Iron Overdrive `agiAdjust(300)` (longer than its own 240), Total War `agiAdjust(360)` (`Reborn:Mole.cs:11622-11632`, `Seed`).
- Cast caption: on Reborn the "INT for no cast bar" footnote uses the uncapped INT (`intForZeroCast` reads `statHi(false)`), e.g. a 24 s cast reaches 0.1 s at INT 768.
- Turrets vs Veil Of Hunt / Night Eye (cross-class): `OnTakeDamage` zeroes damage and KO of an Auto Gyro Gun / Barrel Bot hit on a `[huntVeil]` holder or a Cat with Night Eye (`Reborn:RebornC7Passive.cs:698-703`, `:730-736`, `IsTurret` `:2115-2128`); their target lists drop veiled enemies (`Reborn:AutoGyroGun.cs:835`, `Reborn:BarrelBot.cs:701`) and Barrel Bot shells stop within 3 m of a Night-Eye Cat (`Reborn:BarrelBot_cannon.cs:29`, `Reborn:BarrelBot_missile.cs:30`). Limit lines and links on the Gyro Gun shot and Barrel Bot cards.
- Reactor Core Overdrive (TAL +120 for 30 s, `Reborn:RebornC7Passive.cs:3073-3086`): a battle-state toggle `REBORN_MOLE_OVERDRIVE_TAL_DEP` (`reactorOverdrive`) on the 26 Mole cards whose damage reads the Mole's own TAL (not the Barrel Bot / Gyro Gun own-stat cards); `statBonus` adds the +120 on Reborn, with a desc line and links. ICBM no longer links War Capital (no code connects them).

### C6 / C7 skills (Reborn only)

Traced 2026-10-26 against the build in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §1. All eight are one rank (`<name>5` keys), learned at Lv 95 (C6) / Lv 105 (C7) with 8 Class C skills (`setReq`, not on cards); data `Reborn:MoleSkill.cs:423-477`, tree ids `Reborn:MoleSkill.cs:1040-1050` (451-454), `:1067-1077` (461-464); tooltips `Reborn:MoleSkill_thai.cs:13-28`, `Reborn:MoleSkill_eng.cs:13-28`. English names: `rbNameOverride` names only the C6 four (`Reborn:SkillData.cs:209-212`, 454 = "Giga Drill" although its key is `mol_overclockCore5`); no Thai names in the code. Casts: `Reborn:Mole.cs:14061-14135` (452-454 in `Mole.cs`, 463 / 464 through `RebornC7Act.Cast`); peers replay through `Mole_C6` (`Reborn:Mole_C6.cs:16-77`), and only the owner's client deals damage. Every hit below except the ICBM pad blast and Iron Overdrive goes through the normal `hit()` (`Reborn:CharacterControl.cs:7047-7317`). None of the four cooldowns is reset by **Reload** (list `Reborn:Mole.cs:14915-14956`); Revised Art applies to all of them (`addTimeOut`, `Reborn:CharacterControl.cs:11683-11686`). Start-of-map cooldowns on `RebornZone.CombatMap` (open-world rule, not on the cards): Air Strike `agiAdjust(180)`, ICBM `agiAdjust(240)`, Giga Drill `agiAdjust(300)`, Iron Overdrive `agiAdjust(300)`, Total War `agiAdjust(360)` (`Reborn:Mole.cs:11622-11633`; `RebornC7Act.Seed`, `Reborn:RebornC7Act.cs:615-628`). App wiring: Reborn-only deps `REBORN_MOLE_SMARTWARHEAD_DEP` / `REBORN_MOLE_IRONOVERDRIVE_DEP` inside `servers.reborn` of the cards listed below (constants after `MOLE_SMARTSHELL_PROC` in `index.html`).

- **`mole_burrowRegen` (451, passive; needs Cannon Expert 401 + Super Dig 411, `Reborn:MoleSkill.cs:449-453`):** `RebornC6Passive.Tick` (called every frame, `Reborn:CharacterControl.cs:6733`; local living non-summon Mole with 451, `Reborn:RebornC6Passive.cs:330-336`) wants `actionState == "attack"` and `myCommand` `"burrow"` or `"superDig"` (`:340`); then every 2 s `RPC_AddHeal(451, max(1, floor(0.02 × MHP)))` (`:342-346`) and every 0.5 s it removes each `isLockStatus` status below level 8 (groundLock, needlePrison, sticky, frost, lightBind; `:347-364`, `Reborn:StatusData.cs:1600-1607`). **Dead in the 2026-10-25 build (fixed in bible3, below):** the burrow sets `myCommand = "cAttack1"` for the whole underground phase (`Reborn:Mole.cs:504`); `"superDig"` is only an animation name (`:510`, `:11874`, `:18235`), and the `"burrow"` string helper is used only by `AncientBug.cs` / `AncientBugAI.cs` (string table searched over all of `Assembly-CSharp`). The only real effect of 451 is the shared network tweak (position every 0.07 s, `Reborn:CharacterControl.cs:13498-13501`). Changes no original card; Reborn compat links with Charge Attack and Super Dig.
- **`mole_airStrike` (452, instant, target enemy, MP 120, SP 60 consumed, `setMPSP(120, -60)`; needs Bombardment 2 (254), `Reborn:MoleSkill.cs:454-461`):** aim = the locked target's position (if not the Mole), else the cursor point (`Math.getScreenPosition`, top 80 % of the screen, flat distance clamped to 60 m), else 12 m ahead (`Reborn:Mole.cs:14061-14101`, `:18097-18104`). `RPC_airStrike` (`:18085-18215`): `addTimeOut("airStrike", agiAdjust(180))` (`:18090`), `RevealAround(mark, 14)` (`:18122-18125`: every enemy in `Area(mark, 14, 6)` loses every `isInvisibleStatus` status = blend, invisible, sticky, frost, lightBind, `Reborn:RebornC6.cs:2271-2317`, `Reborn:StatusData.cs:1609-1616`; the three lock statuses until bible3, below), released after 0.5 s (`:18126-18127`). After 0.7 s a jet crosses 96 m in 3 s; missiles start when it is 14 m before the lane (about 1.06 s, `:18129-18155`). Aims (`:18156-18187`): up to 8 living enemies in `Area(mark, 14, 6)` at that moment, then the mark, then a spiral at 51° × n, radius 4 + 1.1 n (world axes). 8 missiles 0.1 s apart, flight 0.75 + 0.04 m s (`:18188-18201`), impacts at about 3.01 + 0.14 m s. Each impact (`Reborn:RebornC6.cs:2318-2354`): `hit(452, t, floor(talAdjust(120)), KO 25)` on every living enemy in `Area(impact, 5, 4)`, TAL read at impact, then `RevealAround` again. Card: `hitCount` 3 = a lone target on the flare (own aim, mark, first spiral point 5.1 m away: `FindAreaTarget` measures to the collider edge, `Reborn:Damage.cs:388-433`, `Reborn:RebornHitBox.cs:5-13`). With 452 learned Bombardment only changes its plane model and draws it 10 m further on (`RebornC6.BombardFx` / `BombardPlanePos`, `Reborn:RebornC6.cs:1161-1222`, `Reborn:Mole.cs:3244-3249`); strikes and `BombardCd = agiAdjust(180)` (`Reborn:RebornC6.cs:1152-1159`) unchanged, so Bombardment gets only a Reborn compat link.
- **`mole_ICBM` (453, instant, MP 300, `setMPSP(300, 0)`; needs Missile 4 (354), `Reborn:MoleSkill.cs:462-469`):** `RebornIcbm.PressCode` (`Reborn:RebornIcbm.cs:168-187`): no pad → build (MP paid); a pad → `returnMPSP` (free, MP still checked) and either a notice (not fuelled) or the target list. Build and fuel channels are `max(2, 2 × magAdjust(24))` (`ChannelSeconds :162-166`; card `castTime 24` + desc "2 เท่า"), each sets `addTimeOut("ICBM", 2)` (`:322`); the pad goes 6 m ahead (`PadSpot :752-763`), one per Mole, `Destroy(pad, 600)` (`:861`); its body is an `AutoGyroGun3` prefab with AI removed, MHP 5000, ATK 1, VIT 1, other stats 0 (`MakeBody :946-1030`). Fuel: the owner within 6.8 m (3D) presses the pad's USE, needs 1 `f_rkf1` (Rocket Fuel, price 10000, `Reborn:FieldData.cs:1274-1278`), consumed when the channel ends (`:226-255`, `:437-449`). Boarding: in a combat zone the owner's party only, elsewhere the owner's layer (`MayBoard :1408-1433`); riders get `invisible` 1 for 120 s and are put off after 120 s (`ClickPad :1435-1488`, `:1540-1560`); `MaxRiders = 4` (`:12`) is never read (bible3 adds the cap, below). Launch (`:455-734`): `addTimeOut("ICBM", agiAdjust(600))` (`:467`), 1.2 s lock, climb 2 s to +35 m, cruise 40 m/s up to 20 s homing on the target, 1.2 s dive; a `SphereCast` r 0.9 against world geometry only explodes it early (`:568-578`, `:624-635`, `:671-677`). Target list: living non-own-layer characters except Structures, summoned Robots and `RebornZoneBoss` (`Rescan :1587-1606`). Impact `RebornC6.IcbmDamage` (`Reborn:RebornC6.cs:2257-2269`): `hit(453, t, floor(2.5 × ATK + talAdjust(300)), KO 100 within 5 m flat of the centre else 50)` on every enemy in `Area(aim, 10, 5)` (no boss filter here); the Thai tooltip's "วง 5m" is the KO split only (card `tooltipNote`). Pad destroyed by damage (`RebornIcbmBody`, `Reborn:RebornIcbmBody.cs:19-34`; `PadBoom`, `Reborn:RebornIcbm.cs:1054-1127`): `RPC_AddEffectDamage(4530, max(1, floor(talAdjust(250) × (1 − 0.8 × clamp01(flatDist / 20)))), KO 30)` on every character in `Area(pad, 20, 8, 130816)`, the Mole and allies included; a rider on that pad takes `hp + 999`. Changes no original card; Reborn compat link with War Capital (the channel is twice its cast).
- **`mole_overclockCore` "Giga Drill" (454, instant, MP 60, SP 70 consumed, `setMPSP(60, -70)`, cType `gigaDrill`; needs War Capital 444, `Reborn:MoleSkill.cs:470-477`):** `RPC_gigaDrill` (`Reborn:Mole.cs:18222-18475`): `addTimeOut("gigaDrill", agiAdjust(300))` (`:18227`), `noDamage` 1 for 3 s on the Mole (`:18246-18249`, removed when it surfaces `:18413-18416`), 0.35 s wind-up (`:18250`), then 20 m at 18.18 m/s (1.1 s, cap 1.5 s), stopped by a wall raycast (`:18268-18287`). Every 0.1 s (`:18291-18296`) `Area(head = pos + 1 m, 3, 3, 130816)` (`:18329`): each living non-summon character except the Mole is hooked once and carried at the head (`:18332-18397`); enemies only, owner's client: on hooking `sticky` 3 for 3 s + `hit(454, floor(0.5 × ATK + talAdjust(40)), KO 20)` (`:18364-18368`), on later ticks `hit(454, max(1, floor(0.1 × ATK)), KO 5)` (`:18370-18373`). Interrupted → no eruption (`:18417-18421`); else `Area(pos, 7, 5)` enemies take `hit(454, floor(2 × ATK + talAdjust(160)), KO 100)` and `paralysis` 1 for 3 s (`:18446-18459`), then a 0.9 s hold. Card: 1 hook + 10 bites + 1 eruption = 12 hits (10-11 ticks, frame-rate dependent). Changes no original card (War Capital is only the prerequisite).
- **`mole_reactorCore` (461, passive; needs Gadgeteer 4 (124) + Genius Invention (421), `Reborn:MoleSkill.cs:423-427`):** `RebornC7Passive.OnHitOut` (`Reborn:RebornC7Passive.cs:502-513`, called in `hit()` after the target-side refusals and `damagePlus`, before `dmgAdjust`, `Reborn:CharacterControl.cs:7263`): attacker Type Mole, local player, action code not 461-464, no `reactorOverdrive`, 461 learned, `dmg > 0` → `MolAddHeat` +2 (`MolHeatPerHit`, `:244`) per `hit()` call, i.e. per target. At 100: heat 0 and `RPC_AddStatus("reactorOverdrive", 1, 30 s, 120)` (`:3107-3116`). `MolTalSync` applies `deltaTal(±120)` while the status is on (`:3073-3086`): TAL +120 and max SP +24 (`deltaTal`, `Reborn:CharacterControl.cs:12016-12021`). Heat is one static counter, reset only when the local character instance changes (`:3097-3105`). Counts: Combo, Landmine, Mortar Shot, TNT, Bombardment, Time Nuke, War Capital missiles (`hit(-4444)`, `Reborn:Mole.cs:16567`), Cart Bomb, Bazooka, Grenade Cluster, Air Strike, ICBM, Giga Drill. Not: summons and mounts (other `CharacterControl`), Effect Damage (Smart Shell `:15493`, Smart Warhead), direct `RPC_AddDamage` (Missile `Reborn:Mole_missile.cs:110`, Napalm `Reborn:Mole.cs:5837`, Flame Turret `:2690`, Flame Carnival `:6330`), base-0 hits (Stun Mine, Stun Grenade: they still land at least 1 after the LCK roll and DEF floor, `CharacterControl.cs:3540`, `:3546`, `:20524-20570`, but the heat check runs before the LCK roll, `Reborn1027:CharacterControl.cs:7313`), Iron Overdrive and Total War (codes 463 / 464). `reactorOverdrive` (code 1461, `Reborn:StatusData.cs:899`, `:1549`) is in none of the `is*Status` lists (`:1564-1653`), so it has no `STATUS_CLASS_MAP` entry (bold name on the card). `[immunity]` can refuse the status after the heat was reset (`Reborn:CharacterControl.cs:9394-9399`). Changes no original card's numbers (a TAL buff); not wired.
- **`mole_smartWarhead` (462, passive; needs Smart Shell (264), `Reborn:MoleSkill.cs:428-432`):** `BlastPlus` = 6 with 462 (`Reborn:RebornC7Passive.cs:3261-3268`), its only call sites: TNT (`Reborn:Mole.cs:1955-1957`, × rangeMod), Bombardment (`:3401-3407`), Napalm (`:5820-5822`), Landmine (`:15105-15107`), Mortar Shot (`:15208-15219`, falloff on the new radius), Stun Mine (`:15283-15285`), the Smart Shell burst (`:15478-15480`), Cart Bomb (`:16408-16409`, radius and height), Time Nuke (`R = 20 + EP + 6`, rings `floor(0.25 × k × R)`, `Reborn:Mole_timeNuke.cs:166`, `:193`). `BlastMask` drops the Mole's own layer (`:3270-3277`) only on Stun Mine (`Reborn:Mole.cs:15285`) and Time Nuke (`Reborn:Mole_timeNuke.cs:168`), so Smart Shell's same-layer halving there can no longer happen. `TrapBonus` `RPC_AddEffectDamage(462, 100, KO 0)` per enemy (`:3279-3290`) after each Landmine / Stun Mine hit outside `[insight]` (`Reborn:Mole.cs:15126`, `:15312`). Chain: 0.15 s after a Landmine / Stun Mine explosion `C7ChainTraps` fires every other own mine within 8 m (3D, `sqrMagnitude > 64` skipped) that has not chained in 5 s (`Reborn:Mole.cs:15030-15087`, `:15131-15139`, `:15318-15326`; `TrapMayChain`, `Reborn:RebornC7Passive.cs:3292-3304`); chained mines skip the Smart Shell burst (it lives in the trigger path, `Reborn:Mole_mine.cs:51-57`, `Reborn:Mole_stunMine.cs:51-57`). Not affected: Combo, Stun Grenade, Grenade Cluster, Flame Carnival (all three added in bible3, below), Fire Barrage, War Capital, Bazooka, Sky Drill, the C6 skills (card `tooltipNote`: the Thai "ทุกชนิด" / "ไม่โดนพวกเดียวกันเลย"). Wiring (all `servers.reborn`): Landmine and Stun Mine `effectProc: REBORN_MOLE_TRAP_PROC` (Smart Shell 30 + Smart Warhead 100), `reach` (+6, plus the 8 m chain sphere), `reachControls`, desc line; Mortar Shot, TNT, Napalm, Cart Bomb `reach` +6, `reachControls`, desc line; Bombardment the same plus `hitCountDep` (5 strikes reach a target at the aim point: radius ≥ 10 > 6 m); Time Nuke `reach` (R 26: 6 / 13 / 19 / 26 m; like the base card it leaves Extra Powder out), desc line; Smart Shell and Extra Powder `descDep` lines; compat both ways.
- **`mole_ironOverdrive` (463, instant, MP 60, SP 50 consumed, `setMPSP(60, -50)`; needs Synchro Mole 2 (364), `Reborn:MoleSkill.cs:433-440`):** `MoleOverdrive` (`Reborn:RebornC7Act.cs:3605-3690`): `Begin(cc, "ironOverdrive", 240)` = `agiAdjust(240)` (`:3607`, `:808-816`), 0.6 s lock; gear = own living summons on the Mole's layer whose Type starts with `AutoGyroGun` / `BarrelBot` within 30 m 3D (`MoleGear :3526-3554`), charged at the cast and every 1 s until 11.2 s (`:3619-3645`): `noDamage` 1 for `ceil(life) + 2` s (`OdCharge :3709-3730`). While charged, `OverdriveCooldown` halves (exact `t × 0.5f`) the cTypes nAttack, punch, hammer, chopper, missile, drill, cannon (`:3487-3510`), applied inside `addTimeOut` (`Reborn:CharacterControl.cs:11688`): Gyro shot 2 → 1 s (`Reborn:AutoGyroGun.cs:61`), Barrel Bot nAttack 3 → 1.5 (`Reborn:BarrelBot.cs:58`), punch `agiAdjust(12)` (`:231`), hammer `agiAdjust(15)` (`:361`), chopper / missile `agiAdjust(60)` (`:494`, `:686`), drill 9 → 4.5 (`:851`), cannon `agiAdjust(9)` (`:1012`); not cannonForm `agiAdjust(90)` (`:1131`) or the Gyro hide timer. `OverdriveReach` 1.5 (`:3512-3519`): Gyro target search `(8 + 4 × lv) × 1.5` (`Reborn:AutoGyroGun.cs:835`) while its bullet box stays `8 + 4 × lv` (`:111`; ×1.5 too in bible3, below); Barrel Bot vision 32 → 48 m (`Reborn:BarrelBotAI.cs:381`). At 12 s, if the Mole lives, each charged gear blasts nearest first, 0.14 s apart (`:3657-3686`); `GearBlast` (`:3856-3921`) removes `noDamage`, `PurpleEveryone(463, r 6, h 4, floor(1.2 × ATK) + talAdjust(90), KO 30)` (`:3556-3579`: enemies, every non-summon on the Mole's layer with no party filter, and the Mole itself; matches the 2026-09-27 patch note in [Reborn-Mechanics-Reference.md](Reborn-Mechanics-Reference.md) §7.2), then kills the gear. The Thai "ระยะ +50%" is search only (card `tooltipNote`). Wiring (`servers.reborn`): Auto Gyro Gun `reach` ×1.5 + `reachControls` + desc line; Auto Gyro Gun shot `descDep` + an extra faint search ring; Barrel Bot `descDep`; the seven Barrel Bot move cards `cdDep` (kind replace, half the base: `agiAdjust` is linear in its argument) + desc line; compat both ways. Not affected: King Kaiser, War Capital, War Factory machines, the ICBM pad body (Type check). The tester-only Reborn turrets (`RebornMoleTurret.cs`, gated by `RebornMoleBeta.On`, `Reborn:RebornMoleTurret.cs:169-184`) also use `AutoGyroGun` bodies and are charged too; not in the app.
- **`mole_totalWar` (464, instant, MP 110, SP 95 consumed, `setMPSP(110, -95)`; needs Giga Drill (454), `Reborn:MoleSkill.cs:441-447`):** `MoleTotalWar` (`Reborn:RebornC7Act.cs:3965-4052`): `agiAdjust(600)` (`:3967`), 0.8 s lock, zone centre `c` = ground 6 m ahead (`:3975`), raid capped at 21 s; it only checks `cc == null`, so it keeps going after the Mole dies (`:4020`). Every damage call is `Hit(cc, 464, at, r, h, atkMul, tal, ko)` = `floor(atkMul × ATK) + talAdjust(tal)` on enemies only (`:851-872`). Stun bombs: 18 spots in rings of 3 / 6 / 9 at 2.5-5.5 / 9-15 / 18-26 m (`TwLayout :4074-4090`), live at about 4.3-4.5 s; one blows when a living enemy is within 3.2 m flat (`TwTrip :4258-4290`): `hit(464, talAdjust(60), KO 10)` in `Area(spot, 4.5, 4)` and `paralysis` 1 for 3 s whatever the hit returned (`TwBlow :4292-4332`). Jets from 3 s every 1.8 s while under 16.2 s, 8 passes alternating gun / rockets at a random enemy within 30 m of `c` (else a random point within 22.5 m; `:4016-4036`, `TwPass :4362-4372`): gun 24 rounds along 26 m, `Hit(r 2.5, h 3, tal 55, KO 6)` (`TwGunCo :4438-4465`, `:4490`); rockets 12, the first on the aim, the rest 1-5.5 m away, `Hit(r 3.5, h 4, tal 110, KO 15)` (`TwRocketCo :4494-4523`, `:4546`). Finale: the remaining bombs blow (`:4342-4360`), then about 20.2 s after the cast one `Hit(c, r 30, h 10, 3 × ATK + tal 250, KO 100)` (`:4575-4591`). Card: `dmgModes`, one row per attack kind (hits per target depend on random aim). No Reactor Core heat (code 464). Changes no original card.
- **Bible (2026-10-28, C6 / C7 limit review):** Reactor Core: the immunity clause left the red line for `unintended`: at 100 heat `MolAddHeat` zeroes the heat before `RPC_AddStatus("reactorOverdrive", …)` (`Reborn1027:RebornC7Passive.cs:3225-3233`), which an `immunity` holder refuses (`Reborn1027:CharacterControl.cs:9462-9468`; `RebornSelfBuff` is never armed for it, `Reborn1027:RebornC7Act.cs:1472`, `:3234`). "No heat during the buff" stays red (`Reborn1027:RebornC7Passive.cs:538`), and the "ไม่นับ:" bullet (turrets, bots, King Kaiser, mounts, Effect Damage, damage outside `hit()`, base-0 hits (they still land at least 1 after the LCK roll and DEF floor), Iron Overdrive / Total War) is now a red limit line at the end of its topic, same wording (the hook runs only inside `hit()` with damage > 0, `:532-540`, checked before the LCK roll, `Reborn1027:CharacterControl.cs:7313`). Smart Warhead: the limit names the blasts it skips (nAttack, War Factory Bazooka, the tank gun, the Barrel Bot moves) instead of "other skills" (`BlastPlus` call sites, `Reborn1027:RebornC7Passive.cs:3379`). Iron Overdrive: the empty-cast limit adds that MP / SP are spent too and that gear arriving within the 12 s is still charged (rescan every 1 s, `Reborn1027:RebornC7Act.cs:3636-3667`).
- **Owner's calls (2026-10-28, C6 / C7 limit review):** Reactor Core: the [immunity] case is a red limit again (no ⚡). Iron Overdrive: "dies before the time is up, no explosion" is removed from the red line.

### Build 2026.10.27.1936-bible3 behaviour fixes (verified 2026-10-27)

`Reborn1027:X.cs:N` = `DecompiledSource_Reborn_2026-10-27/Assembly-CSharp/X.cs` line N (build 2026.10.27.1936-bible3; readable copies with the strings resolved in `D:\12tails-assets-archive\reborn-diff-2026-10-25_to_2026-10-27\new\`, same line numbers). Each item names the 2026-10-25 line (`Reborn:`) it replaces. Original cards change in `servers.reborn` (a `[Fix]` line in the change note when BB differs); Reborn-only cards change their own fields.

- **Stun Mine lifetime (Fix; `mole_stunMine`):** the mine lives `chaAdjust(60)` s (`Reborn1027:Mole_stunMine.cs:154`), like Landmine (`Reborn1027:Mole_mine.cs:154`); was `talAdjust(60)` (`Reborn:Mole_stunMine.cs:154`, = `BB:Mole_stunMine.cs:60`). Thai tooltip "อยู่ได้ 60 วิ (เพิ่มตาม CHA)" (`Reborn1027:MoleSkill_thai.cs:166`, `:170`). Card: Reborn `durAdjust: "cha"` (CHA chip and glow), `bbBug: ""`, change note.
- **Burrow Regen works (`mole_burrowRegen`):** `RebornC6Passive.Tick` now also accepts `myCommand == "cAttack1"` (`Reborn1027:RebornC6Passive.cs:425`), the command the Charge Attack keeps for its whole underground phase (`Reborn1027:Mole.cs:506`); was `"burrow"` / `"superDig"` only (`Reborn:RebornC6Passive.cs:340`). While burrowed: `RPC_AddHeal(451, max(1, floor(0.02 × MHP)))` every 2 s (`Reborn1027:RebornC6Passive.cs:427-431`; the timer restarts at 2 s while not burrowed, `:453`) and every 0.5 s each `isLockStatus` status below level 8 is removed (`:432-449`). Card: `bbBug` and the "does not work" limit line removed.
- **Air Strike reveal (`mole_airStrike`):** `RebornC6.Reveal` removes only `blend` and `invisible` (`Reborn1027:RebornC6.cs:2213`); was every `isInvisibleStatus` status, sticky / frost / lightBind included (`Reborn:RebornC6.cs:2283`). Callers: the flare's `RevealAround(mark, 14)` (`Reborn1027:Mole.cs:18180`) and every missile impact (`Reborn1027:RebornC6.cs:2283`; `RevealAround` `:2237-2246`). Card: `unintended` removed (the desc already named only invisible / blend).
- **ICBM rider cap (`mole_ICBM`):** boarding is refused with "จรวดเต็มแล้ว (ขึ้นได้ 4 คน)" when `RidersOn(pad) >= 4` (`Reborn1027:RebornIcbm.cs:1475-1479`); `RidersOn` counts the other living non-summon players (not the boarding player, not the pad owner) with `invisible` within 1.5 m flat of the pad (`:1495-1520`). The 2026-10-25 build had no check. Blast unchanged: `Area(aim, 10, 5)`, KO 100 within 5 m flat else 50 (`Reborn1027:RebornC6.cs:2191-2196`), still 99 after `koAdjust`. Card: desc "ขึ้นได้สูงสุด 4 คน".
- **Smart Warhead on Grenade Cluster, Stun Grenade and Flame Carnival (`mole_smartWarhead`):** `BlastPlus` (6 with 462, `Reborn1027:RebornC7Passive.cs:3379-3386`) now also widens Grenade Cluster (`r + BlastPlus`, `Reborn1027:Mole_grenadeCluster.cs:72`), Stun Grenade (`(6 + BlastPlus) × rangeMod`, `Reborn1027:Mole_stunGrenade.cs:63`) and Flame Carnival (`clamp(2 + i, 3, 5) + BlastPlus`, `Reborn1027:Mole.cs:6335`), and `BlastMask` (drops the Mole's own layer, `Reborn1027:RebornC7Passive.cs:3388-3395`) now also applies to Stun Grenade and Flame Carnival; was the plain radius and mask 130816 (`Reborn:Mole_grenadeCluster.cs:72`, `Reborn:Mole_stunGrenade.cs:63`, `Reborn:Mole.cs:6309`). Grenade Cluster already skipped its own layer (`130816 − (1 << layer)`, `Reborn1027:Mole_grenadeCluster.cs:71`). The 12 `BlastPlus` sites: TNT `Reborn1027:Mole.cs:1965`, Bombardment `:3415`, Napalm `:5844`, Flame Carnival `:6335`, Landmine `:15164`, Mortar Shot `:15267`, Stun Mine `:15342-15344`, the Smart Shell burst `:15537`, Cart Bomb `:16467`, Grenade Cluster, Stun Grenade, Time Nuke (`Reborn1027:Mole_timeNuke.cs:166-168`); `BlastMask` sites: Flame Carnival, Stun Mine, Stun Grenade, Time Nuke. The Thai tooltip names the same 12 (`Reborn1027:MoleSkill_thai.cs:16`). Cards: Smart Warhead desc, limit line and compat; Grenade Cluster, Flame Carnival and Stun Grenade (new Reborn tab) get a Reborn `reach` +6 with the toggle, `reachControls`, a desc line and the compat link; the Smart Warhead lines on Extra Powder and Smart Shell.
- **Grenade Cluster falloff floor (Fix; patch-note extra; `mole_grenadeCluster`):** `num2 = clamp(1 − 0.5 × d / (r + BlastPlus), 0.5, 1)` scales both the damage and the push (`Reborn1027:Mole_grenadeCluster.cs:83-85`); was `1 − 0.5 × d / r` with no clamp (`Reborn:Mole_grenadeCluster.cs:83`, `BB:Mole_grenadeCluster.cs:240`). `d` is the 3D distance from the grenade to the target's centre, while `FindAreaTarget` takes a target by its collider edge within a height band, so on BB a large, raised or lowered target at the edge took under 50 % (and a weaker push); with Smart Warhead's wider area the old formula would have reached 0 or a reversed push. Card: Reborn change note (the desc already says 50 % at the edge).
- **Detonate in the first second (Fix; patch-note extra; `mole_detonate`):** elapsed = `max(1, floor(Time.time − placed))` (`Reborn1027:Mole_timeNuke.cs:49`); was `floor(…)` (`Reborn:Mole_timeNuke.cs:49`, `BB:Mole_timeNuke.cs:478`). The blast skips the scaling `clamp(elapsed × 0.0166, 0.1, 0.99)` when elapsed is 0 (`Reborn1027:Mole_timeNuke.cs:162-164`, `BB:Mole_timeNuke.cs:870-876`), so on BB a Detonate within 1 s of placing deals the full Time Nuke damage (the BB card desc does not say so); now the 10 % floor applies. Card: Reborn change note; since 2026-10-28 the Reborn tab also clears the BB `bbBug` chip that states it.
- **War Capital searches around the base (Fix; patch-note extra; `mole_warCapital`):** the 36 m / 10 m enemy check, whose list also feeds the 8 random missile targets, is centred on the base (`Reborn1027:Mole.cs:7793`, targets `:7816-7833`); was the Mole's position (`Reborn:Mole.cs:7760`, `BB:Mole.cs:43874`). The base stands about 2 m ahead of where the Mole cast (`getSpawnVector(pos + up, 2 × forward − up)`, `Reborn1027:Mole.cs:1051`). Card: Reborn desc ("รอบฐาน"), `reach` centred 2 m ahead, change note.
- **Iron Overdrive on the Gyro bullet (`mole_ironOverdrive`):** the Gyro Gun's bullet box is now `(8 + 4 × lv) × OverdriveReach` long (`Reborn1027:AutoGyroGun.cs:111`), the same as its target search (`:835`) and its keep-target check (`:802`, also new); was `8 + 4 × lv` (`Reborn:AutoGyroGun.cs:111`, `:802`). `OverdriveReach` = 1.5 while charged (`Reborn1027:RebornC7Act.cs:3517-3524`). Barrel Bot: vision `32 × OverdriveReach` only (`Reborn1027:BarrelBotAI.cs:381`), its moves keep their range (Thai `Reborn1027:MoleSkill_thai.cs:18`). Cards: Iron Overdrive desc; the Gyro shot's Reborn `reach` (box ×1.5 with the toggle) and desc line; the Auto Gyro Gun desc line.
- **One-use mount cost (patch-note extra, no card):** one-use mounts are charged their own mana (`Reborn1027:GameGui.cs:1800`): WormBug `o_bug2` 5 (`:953-954`), `o_all9` 90 (`:821-822`); was a flat 90 for both (`Reborn:GameGui.cs:1782`). Mole's Tank (`o_mol2`, 5) is not a one-use mount and is unchanged. No Bible card shows these mounts.
- **King Kaiser beam timeout deleted (issue-list check 2026-10-28; card `mole_kingKaiser_beam`):** the 2026-10-25 build set `addTimeOut("kaiserBeam", 2f)` and `addTimeOut("kaiserBeam", 30f)` (`Reborn:KingKaiser.cs:457`, `:571`; BB `KingKaiser.cs:3041`, `:3426`) and nothing read them; in 2026-10-27 the string `"kaiserBeam"` (helper `_2005_2004_2004`, decoded with the string table, identical in both builds) is used nowhere, and the only timeouts left are `addTimeOut("nAttack", 4f)` (`Reborn1027:KingKaiser.cs:62`, `:313`, helper `_206B`), which the normal attack checks with `isTimeOut("nAttack")` (`:1448`); the beam is still gated by the robot's 75 SP alone, which the new tooltip states (ไม่มีคูลดาวน์). App: the card's Reborn tab clears its `bbBug`, so the Reborn issue list leaves it out.

### Dependency-line audit (verified 2026-10-28)

Same tags as above (`Reborn1027:` = bible3). A line goes into `servers.reborn` only where Reborn alone has the effect.

- **Burrow Regen on the Charge Attack card:** the tick wants `actionState == "attack"` and `myCommand` `"cAttack1"` / `"burrow"` / `"superDig"` (`Reborn1027:RebornC6Passive.cs:421-453`); the Charge Attack sets `cAttack1` at the dive (`Reborn1027:Mole.cs:504-506`, a string helper; the BB literal is the same, `BB:Mole.cs:22278`) and keeps it for its loop (`:577-582`). Unlike Super Dig's heal (`BB:Mole.cs:21823-21860`, real game modes only) it has no game-mode check. Card: Charge Attack Reborn desc **Burrow Regen:** line (2 % HP every 2 s, lock statuses up to level 7 removed every 0.5 s).
- **Smart Shell burst:** `4 + ExtraPowderLv + BlastPlus` (`Reborn1027:Mole.cs:15537-15539`), so Smart Warhead's +6 adds to the Extra Powder radius. Card: the Reborn desc shows the Extra Powder line before the Smart Warhead line.
- **Synchro Mole:** same code as BB (`Reborn1027:Mole.cs:16132-16158`, `Reborn1027:CharacterControl.cs:2931-2934`).
- **Reactor Core → Synchro Mole:** the status value is `mChar.tal` at the cast (`Reborn1027:Mole.cs:16138` for the Mole, `:16154` for the summons), and during Reactor Overdrive `MolTalSync` has applied `deltaTal(+120)` (`Reborn1027:RebornC7Passive.cs:3191-3201`; granted for 30 s at 100 heat, `:3225-3233`), which adds to `tal` (`Reborn1027:CharacterControl.cs:12093-12097`). A cast during Overdrive gives the summons `floor(0.5 × sLv × (TAL + 120))` = `floor(0.5 × sLv × TAL) + 60 × sLv` ATK and DEF: +60 / +120 more at level 1 / 2, fixed at the cast. Card: Synchro Mole Reborn desc **Reactor Core:** line (`+60 × rank`) and Reborn `compatSkills` both ways. **Decided 2026-10-28 (leftover 5), modelled:** on Reborn the Barrel Bot and Auto Gyro Gun stat cards (the two summon cards and their move cards) draw the Reactor Core (Overdrive) toggle `REBORN_MOLE_OVERDRIVE_TAL_DEP` beside Synchro Mole in their summon stats chip, and `statBonus` adds the +120 to the Mole's TAL on them (`moleSynchroStatCard`), so `barrelBotOwnStats` / `autoGyroGunOwnStats` give the summons `floor(0.5 × sLv × (TAL + 120))` ATK and DEF while it is on (+60 / +120 at Synchro Mole 1 / 2). The +120 reaches nothing else on those cards (the summons' own TAL replaces the Mole's after the Synchro term). The Mole-commanded Barrel Cannon card has no Reborn tab, so it shows the BB stats there. The 2026-10-26 Review corrections line (no toggle on the own-stat cards) is superseded.
- **Chopper + Barrel Cannon:** the same blast as BB, `FindAreaTarget(Mole, 5, 1)` and `hit(443, talAdjust(20), KO 0)` each tick (`Reborn1027:Mole.cs:4662-4674`).
- **King Kaiser normal attack → Kaiser Cannon:** the same branch as BB (`Reborn1027:KingKaiser.cs:1446-1462`).
- **Giga Cannon gate:** the same refusal without #421 (string helper, `Reborn1027:GameGui.cs:908-910`).
- **Detonate:** the Reborn desc keeps the plain 10-99 % wording (it drops the BB first-second exception); see "Detonate in the first second" above. Since the open-decision pass (2026-10-28) the base desc has the same wording and the BB exception is a `bbBug` chip, which the Reborn tab clears.
- **Re-checked, no change:** the Reborn `Mole.cs` reads the same skill ids as BB plus the known C7 hooks (`BlastPlus`, `BlastMask`, `TrapBonus`, `TrapMayChain`); Iron Overdrive does not halve the Mole-commanded Barrel Cannon (`cannonForm`), so the Barrel Cannon card needs no Iron Overdrive line.

## Open items / could not verify

Open (dependency-line audit 2026-10-28; each needs a live check or a user decision):

1. **ToT Mine Lover on the mines:** ToT turned Mine Lover into the active Blast Throw ("ลดคูลดาวน์ของระเบิดและเพิ่มดาเมจทั้งหมด 50%"). Do Landmine and Stun Mine still get the BB passive part there (damage / KO ×1.25, base cooldown 15 → 8 s and 45 → 23 s; `Mole.cs:10614-10620`, `:23891-23905`, `:26680-26694`, `:11097-11103`)? Their cards have no ToT tab and keep the BB Mine Lover lines. The patch note's "50%" matches the original BB tooltip ("+50% and −50%"), not the code's ×1.25. Needs a live ToT check before anything changes. **Decided 2026-10-28 (ToT / TTO rule, user 2026-10-28: on ToT and TTO the BB code applies unless a user-reported balance change overrides it, and then the balance change is trusted as written; replaces the earlier "no change" of the same day):** the ToT balance change turned Mine Lover into the active Blast Throw, so the BB passive part (`Mole.cs:10614-10620`, `:11097-11103`, `:23891-23905`, `:26680-26694`) is gone there. Landmine and Stun Mine have ToT tabs without the Mine Lover toggles (cooldown, damage / KO), line and link, each with a change note taken from the Mine Lover one (Landmine damage ×1.25 → ×1 and base cooldown 8 → 15 s; Stun Mine KO ×1.25 → ×1 and base cooldown 23 → 45 s). The Mine Lover ToT tab no longer links them and clears the BB ×1.25 tooltip note; Blast Throw's own effect stays as the balance note words it.
2. **TTO Smart Shell and the KO cut:** TTO Smart Shell "does not reduce damage dealt to allies" (user-reported 2026-10-02). Does that also remove the same-layer KO cut on Stun Mine (allies get `KO 5 × sLv` = 10 instead of the full KO, `Mole.cs:11144-11156`) and Stun Grenade (half KO, `Mole_stunGrenade.cs:200-290`)? The TTO Smart Shell card drops the whole halving bullet, but the report and the change note only say damage. If the KO cut is gone too, Stun Mine and Stun Grenade need TTO descs like Time Nuke's. **Decided 2026-10-28 (ToT / TTO rule, user 2026-10-28: on ToT and TTO the BB code applies unless a user-reported balance change overrides it, and then the balance change is trusted as written; replaces the earlier "no change" of the same day):** the balance change names damage only, so only damage changed; the ally KO cut on Stun Mine (`KO 5 × sLv`, `Mole.cs:11144-11156`) and Stun Grenade (half KO, `Mole_stunGrenade.cs:200-290`) stays as BB on TTO. Stun Mine and Stun Grenade keep their BB text there (no TTO tab). The Smart Shell TTO desc keeps the Stun Mine / Stun Grenade KO half in its ally bullet, drops only the Time Nuke / Flame Carnival damage half, and its red line says allies take full damage; the Time Nuke and Flame Carnival TTO change notes already name damage only.
3. **Reload targets:** Reload resets 19 skills (27 with Advance Repair; `Mole.cs:10168-10300`, `:10266`), and none of their cards has a **Reload:** line or link. That follows the house precedent: no class gives cooldown-reset targets a line, and Swift Pace, Phoenix, Gadina and Double Art state the reset only on the resetting card. Should reset-type skills keep this exemption from the one-line-per-modifier rule? **Decided 2026-10-28: no change**: reset-type skills keep the exemption (house precedent for cooldown resets), so the targets get no **Reload:** line or link and the Reload card's own list stays the one place that names them.

Resolved 2026-10-01 (user decisions):

1. **Kaiser Beam cooldown:** the `kaiserBeam` timeout is never checked; the card shows no cooldown (75 Kaiser SP is the only limit).
2. **Napalm:** the card assumes point-blank use, with all 5 shells on the target (30 hits).
3. **King Kaiser HP:** 2000 confirmed (prefab re-decode above).
4. **War Capital HP:** decoded from the prefab: 1500 HP, all stats 150.
5. **Saw Machine:** the card counts the 3 front swings.
6. **Tooltip mismatches** are shown on the cards in red (`__…__`), with the code value used: Landmine, Bombardment, Mine Lover, Super TNT, Charge Attack (English lock levels), King Kaiser HP.

## Server Balance Variations (ToT patch notes, 2026)

Source: ToT Facebook patch notes (C6 intro post, 03/08/2026, 10/09/2026, hot fix 12/09/2026; latest value wins), read 2026-10-02; server-side, not in `DecompiledSource/`; card `servers.tot`.

| Skill | ToT change |
|---|---|
| Flame Turret | base cooldown −50% (120 → 60 s); can be cancelled with a normal attack or another Class A skill |
| Fire Barrage | cooldown −20% (120 → 96 s); damage range +20%; resets Blast Throw |
| Bombardment | cooldown −35% (180 → 117 s); damage range +20%; resets Blast Throw |
| Mine Lover | reworked into the active "Blast Throw" (bomb cooldown down, all damage +50%, throws a bomb that explodes on landing), 20 red SP / 10 MP |
| Napalm | can damage Machine / Structure targets; can no longer damage characters that are dodging |

On the cards (2026-10-26): every row above has a ToT desc built from the base desc (`servers.tot.desc`); the Fire Barrage / Bombardment +20% damage range lives in their `reach` (radius × 1.2 when the ToT tab is on), so their ToT descs add only the Blast Throw reset. The BB Napalm skips `Robots` / `Structure` targets (`Mole.cs:37723`, `:37729`), which is what the ToT change lifts.

On the cards (2026-10-28): the Mine Lover ToT desc names Fire Barrage and Bombardment (each resets Blast Throw, the mirror of their ToT descs), with ToT-only `compatSkills` both ways (`servers.tot.compatSkills`). **Decided 2026-10-28** (Open items, 1): the BB Mine Lover passive part is gone on ToT; Landmine and Stun Mine have ToT tabs without it (change notes from the Mine Lover row), and the Mine Lover ToT tab no longer links them.


### ToT EX learning requirements (published simulator, 2026-10-13)

Source: [ToT mole simulator dataset](https://talesoftails.net/data/skill-simulator/mole.json), with learning rules from [ToT simulator client](https://talesoftails.net/_next/static/chunks/673.2ecb414e00f7368e.js). These are server-specific published simulator requirements, not BigBug decompiled mechanics or verified damage formulas. Icons were extracted from the site’s `/gamegui/skill-simulator/skills/` assets and embedded in the hub.

| Cell | Published skill name | Level | Ordinary C skills required | Explicit prerequisite cells | Type / availability |
|---|---|---|---|---|---|
| 451 | UpdamageMonter | 95 | 0 | None | Passive |
| 452 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 453 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 454 | Unpublished EX slot | 100 | 6 | None | Unavailable |
| 461 | DowndamageMonter | 95 | 0 | None | Passive |

Each learned EX skill costs one point from a separate EX pool: 0 below Lv 95, 1 at Lv 95–99, 2 at Lv 100. Cells 451 and 461 exclude each other. At most one of cells 452–454 may be learned. EX skills never count toward ordinary C point requirements. All explicit prerequisites and the six ordinary C skills must remain learned; refunds and tree resets enforce this. See [shared ToT EX rules](12Tails-Mechanics-Reference.md#tot-ex-skills-published-simulator-2026-10-13).

The three Lv 100 slots currently have placeholder names/art in the published dataset. The hub shows them as unavailable and does not invent skills or permit spending points on them.

## Hit timing for the reach playback (traced 2026-10-16)

Seconds from the start of the move (or of the child routine named), read from the coroutine waits in order; every hit uses the box / circle already documented above. The Bible reach preview replays exactly these times.

- **Time Nuke:** the four rings r 5 / 10 / 15 / 20 one every 0.1 s (`Mole_timeNuke.cs:673-683`).
- **Barrel Bot Chopper:** 4 swings (not 3), at 0.8 / 1.2 / 1.6 / 2.0 s: the loop runs while `i < 4` and only the last skips the 0.4 s wait (`BarrelBot.cs:3707`, `:3791`).
- **King Kaiser Beam:** backs off 0.4 m (`moveSpeed −2` for 0.2 s), then 5 beams 0.3 s apart from 0.2 s (`KingKaiser.cs:3501-3538`).
- **War Factory Roller Machine:** one crush at 0.6 s (`Mole.cs:42394`), then `moveSpeed 1` and a crush every 0.2 s while `i < 10` from 1.0 s (`:42597-42643`): 11 hits.
- **Chopper + Barrel Cannon:** the blast (`:33963`) fires in the same frame as each slash (`:33913`), so 20 hits at 10 times.

### Riding mounts: mountAttack and mountDash (G. Marshal / G. Champion mount, verified 2026-10-17)
Both mounts run the same attack code for this class (`PvpMount.cs` and `ChampionMount.cs` differ only in the +20 / +50 stat bonus, the ride speed 8 / 9 and the Champion's charge; the shared rules are in [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md#riding-mounts-g-marshal-and-g-champion-verified-2026-10-17)). ATK, TAL and LCK are the mount's own (rider's base stats + bonus). Line numbers are `PvpMount.cs`; `ChampionMount.cs` has the same code a few hundred lines later.
- **mountAttack** (normal attack while moving at no more than 40% of the run speed): shell launched at 15 m/s (`PvpMount_mole_nAttack.cs:28`) under gravity (the prefab Rigidbody `m_UseGravity: 1`), life 10 × rangeMod s (`PvpMount.cs:3884`), box trigger 0.25 × 0.25 × 0.5; explodes on contact, `FindAreaTarget(hit, 4, 4)` and `hit(1, ATK, KO 1)` (`:229-253`), cooldown 1 s (`PvpMount.cs:13148`).
- **mountDash** (normal attack while moving faster): drops a bomb at its own position (`RPC_rAttack_mole_fire`) that explodes after 1 s: `FindAreaTarget(pos − 0.5 up, 4, 3)`, `hit(1, (int)(1.5 × ATK), KO 1)`, cooldown 0.5 s (`:13463, :13666-13689, :13751`).
