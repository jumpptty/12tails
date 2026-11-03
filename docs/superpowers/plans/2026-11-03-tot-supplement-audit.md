# ToT supplement (2026-11-03) vs the Bible: audit results

Companion of `2026-11-03-tot-supplement-handoff.md`. Paths are relative to `ToT_Skillsim_2026-11-03_supplement/supplement-20261103/methods/References/` (git-ignored; on the flash drive). Values are the ToT client's local defaults (its README: not checked against the live server). Two read-only agents produced these on 2026-11-03; spot-checked by hand: the Bat cast-helper cooldowns, the Rum Bling balance phases, Fire Avatar 600 → 120, the Tails Neverdie list, Lotus Palm's cooldown / KO and Fire Rune's MP / SP order. Re-check each line against the code before changing a card. **Nothing below is applied yet** (the 12 cost fixes of the handoff's item 7 are, 8858e2a).

## A. The C6 cards built 2026-11-03 (Wolf, Bat, Penguin, Bison, Monkey)

No number on these 17 cards is contradicted. Newly answered:
- **Start-of-mission cooldowns, all `agiAdjust`, only when `Game.mGameType > 4`:** `Start_Wolf.cs:16` voidBreaker 60; `Start_Bat.cs:20` darkImpulse 180; `Start_Penguin.cs:14` blackHole 300; `Start_Bison.cs:19` desTroyer 225; `Start_Monkey.cs:14` rumBling 240.
- **Bat cooldowns are AGI-adjusted:** `TimingCalls_Bat.cs` `RunBatEndgameLongCast` (BatEndgameSkillActions.cs:698) `addTimeOut(cooldownName, agiAdjust(cooldown))`, `RunBatMaintainedLongCast` (:762-763) `addTimeOut("cast", adjustedCast + 0.7f)` + `addTimeOut(skill, agiAdjust(cooldown))`. Still not shown: what adjusts the cast, whether it must be held.
- **Penguin:** `RPC_cast1` `addTimeOut(sType, agiAdjust(finalTimeout))` (`TimingCalls_Penguin.cs:27`); Recurrent Nova sets both `manaVortex` and `recurrentNova` (`:30`, `:33`, `:99` 120). Base `finalTimeout` and the cast times still missing.
- **Shadow Realm tick:** `Balance_DefaultValues.cs:859-870` formula "40", interval 4.0, `effectDamage`, action 439, KO 0 (the tick code itself still missing).
- **Rum Bling:** `Balance_DefaultValues.cs:771-806` wavePulse dmg "50", KO 15, hate 0, radius 12, interval 3, buffValue 4; flashFire interval 0.5; hammerStone radius 43.2, interval 4. By name: damage pulse 0.5 s, Ground Lock 3 s, stones 4 s (matches the team). Still missing: Duration, AuraPhaseDuration, TargetHeight, HammerCount, CasterReleaseDelay, PillarRadius, GroundTouchDelay. Lavu: `Balance_MonkeyEarth.cs:824-845` `IsLavuIndependentEnabled()` (body missing).
- **Buiten Guard:** `Balance_DefaultValues.cs:352-366` buffDuration 10, buffValue 200, action 453 (tick count and the Effect Damage absorb caller still missing).
- **Fire Avatar:** `Balance_MonkeyFire.cs:1319-1327` `hasSkill(452) ? 120 : 600`, used as `agiAdjust(GetFireAvatarCooldown())` (`TimingCalls_Monkey.cs:20-22`): Ja Burst's team note is now code.
- **Tails Neverdie** (`Sheep_ReviveAndReflect.cs:25-73`, `TailsNeverdieInitialCooldownTypes`): resets learned cooldowns except 30 types (darkImpulse, desTroyer, rumBling, blackHole, voidBreaker, shadowExecution, zeroShot, warCapital, DivineFist, grandTide …). So Shadow Realm, Soul Capture, Blade Symphony, Reincarnation, Ja Burst, Buiten Guard, Recurrent Nova are reset by it. `TailsNeverdieMaxTargets` missing.
- **Berserker Rush heal:** `Balance_Bison.cs:957-969` `ceil(min((0.04 lv + 0.04) × maxDamage, 8 lv))`, lv = status level, so RageKing's +1 level raises it: check the card.
- Blade Symphony's balance block says KO 0 / hate 0 (`Balance_DefaultValues.cs:46-47`) but the code hard-codes 5 / 1 on the lanes; the card follows the code (correct).
- Still missing: Reincarnation's cut list, VoidBreaker flat 45 vs %, Shadow Realm +30% / Amplify Damage, `FindBatAreaTargets` cap, Soul Capture's CHA tick / immunity / Drain Life, Dark Impulse +30 stats, Frost Nova's caller and the Arctic Wind / Deadly Frost cuts, Recurrent Nova tower HP, Black Hole pull height / core / Meteora, the DesTroyer wave constants, rageKing +60 AGI, Ja 4 HP 800 + aura, Buiten 4 HP 1200 / DEF +200.

## B. Older ToT items and the 2026-11-02 C6 classes (contradictions first)

**Panda**
- **Lotus Palm:** cooldown `agiAdjust(sLv == 2 ? 47 : 67)` (`Panda_RisingDragonAndStatuses.cs:68`), KO `sLv == 2 ? 15 : 5` (`:111`), plus `noForce` 1 for a flat 2 s on the Panda (`:69-74`); damage as BB. Bible ToT: `cd:52.5`, `ko:"20"` (panda class file ~1063). The `LotusPalm` status is only read (`:203`, 20% dodge), never applied: its liveCheck stays.
- **Heaven Palm:** cooldown `agiAdjust(sLv == 2 ? 94 : 135)` (`Balance_Panda.cs:642`), KO `2 : 1` (`:748`). Bible ToT: `cd:105`, `ko:"3"`.
- **Rising Dragons' 8 jabs (answers the liveCheck):** `HitRisingDragonPulse` radius `(sLv == 2 ? 4.5 : 3) × rangeMod`, height `(9 : 6) × rangeMod`, damage `(int)((0.35 × (ATK + FocusedArt) + talAdjust(5 sLv)) × (sLv == 2 ? 1.1 : 1))`, KO 1 (`:11-17`). Bible ToT: ×1.1 at both ranks and BB 3 / 6 size.
- **Heaven Breath:** `RPC_heavenBreath5` active, cooldown `agiAdjust(300)` (`:138`), `heavenBreath` for `chaAdjust(20)` (`:186-191`); while on, a pulse gives +10% max MP and SP (`Balance_Panda.cs:905-927`) and the flat 20% dodge (`ToT1103:Shared/gameplay_math.cs:167`). Which key casts it is not shown. Bible ToT keeps the BB passive.
- **Absolute Control (453):** Wind & Cloud cooldown `84 : 120`, Rain & Storm `88.2 : 180`, area ×1.3 (`Balance_Panda.cs:318`, `:468`, `:335`, `:460`). Not in the Bible (Panda C6 not built yet).
- **Tiger Toss / Tiger Pounce:** the ToT `ko:"6"` does not override the dmgGroups' KO 5 / 10; code 6 / 12 (`Balance_Panda.cs:126`, `:290`).

**Whale**
- **SpiralShield5 (answers the liveCheck):** `addTimeOut("steelSkin", agiAdjust(90))`, `RPC_RemoveStatus("hardenSkin")`, `steelSkin` 5 for `chaAdjust(CeilToInt(2))` value 50 (`Whale_SteelSkinAndBubbleBurst.cs:29-33`). The card has `durWrapped:false` (wrong: CHA applies); pressing it removes Harden Skin and its stacked DEF.
- **Bubble Burst with 453:** own cooldown `agiAdjust(60) × (1 − 0.4)`, unrounded (`:46-53`); not on `whale_bubbleBurst`'s ToT tab.

**Mole**
- **MissileBot5 (answers the liveCheck):** Missile fires `lv == 4 ? 5 : lv + 1` (`Mole_MissileBotLinks.cs:59-60`); Barrel Bot `MissileLv = MissileCount (5)` (`:79-80`, read at cast `:89-90`). The toggle's `rank + 1` matches.
- **Mine Lover:** Landmine keeps `hasSkill(402) ? agiAdjust(8) : agiAdjust(15)` and `floor(1.5 × dmg)` (`Balance_Mole.cs:170-177`, `:275-279`); Stun Mine 23 / 45 and KO ×1.5. Bible ToT on `mole_mine` / `mole_stunMine` removes the bonus ("x1.25 → x1", mole class file ~622): contradicted.

**Chameleon / Rabbit (MP discount, answers both liveChecks)** (`Shared_MpDiscountAndCSkillCap.cs:35-73`): Revised Magic first `ceil(0.8 × MP)`, then ApexPredator5 `ceil(× 0.5)` on commands 341-344 and 361-364 (Slayers, All Slayers) when `hasSkill(453) && hasSkill(354)`; MiracleShot5 `ceil(× 0.5)` on 251-254 (Immune, Boost, Heat, Life Shot) when `hasSkill(452) && hasSkill(254)`. Example: Slayer MP 12 + Revised Magic → ceil(9.6) = 10 → 5.

**Sheep**
- **ReflectEncounter5 (answers the liveCheck):** `ApplyRepelReverseShield`: the target gets the full duration, then every living ally on its layer within **8 m (3D) of the target** gets the same level for `max(1, ceil(duration × 50%))` (`Sheep_ReviveAndReflect.cs:88-112`); which shields call it is not shown.
- **EternalSalvation5:** the Tails Neverdie skip list above; max targets missing.

**Cat**
- **ShadowExecution5 evasion:** `IsShadowExecutionEvading` only in phase `strike` or `held`, needs 454 + 431 + 364 + 371 (`Cat_ShadowExecution.cs:4-16`); `strike` starts at the warp arrival (`:23-24`). So no evasion during the throw, the hide or the 4 pulses: only from arrival to the end of the 0.5 s hold. The card says "ระหว่างท่า".

**Monkey**
- **Instant Cast rank 2:** cooldown 180 confirmed; duration `InstantCast2BaseDuration = 13` with `chaAdjust` (`Monkey_InstantAndFireRune.cs:7-8`, `:101-107`). Bible ToT says 12.
- **Auto Instant:** level 4, value 2 (`:91-94`); MP `ceil(0.6 ×)` after Revised Magic (`Shared_MpDiscountAndCSkillCap.cs:64-70`); +40 ATK / DEF / VIT / TAL (`:223-226`); heal `max(1, floor(1% MHP))` every 1 s (`:279-287`); NEW: removed on the 2nd C spell (`:193`); the four C spells never use rank-1 Instant Cast (`:146-162`).
- **Fire Rune / Earth Rune restore (swapped on the cards):** `RPC_AddHeal(260 + lv, 0, 10 + 6 lv, 2 + 2 lv)` = (hp, MP, SP) (`:37-44`; Earth `Balance_MonkeyEarth.cs:756-757`; argument order as Reincarnation's `RPC_AddHeal(255, 0, 160, 50, …)` MP 160 / SP 50) → **MP 16 / 22 / 28, SP 4 / 6 / 8**; both ToT descs and change notes say SP 16 / 22 / 28 and MP 4 / 6 / 8. Chances 45 / 60 / 75% and Intense Fire 0.6 / 0.8 / 1.0 confirmed (`:16`, `:55`).
- **Titanic Earth Pulse** cap `floor(0.8 × 1999)` = 1599 (`Balance_MonkeyEarth.cs:406-407`), card 1999. Only Gadina form 4 attacks faster (`:109-110`). Volcanic Eruption releases the Monkey at 0.3 + 6 × 0.5 = 3.3 s, not 2 s (`Balance_MonkeyFire.cs:1345-1383`). Second Stone always strikes after 3 s (`Balance_MonkeyEarth.cs:57-67`).

**Wolf / Bison**
- Double Art `lckAdjust(level × 5)` confirmed (`Wolf_DoubleArt.cs:26`), also for a Wolf ShadowCopy.
- **Over Power:** cooldown `agiAdjust(225)` (`Balance_Bison.cs:1081`); Bible ToT `cd:300` (the class file's ToT table says 420): contradicted.
- Hold Charge hit count `floor(clamp(t − 2, 1, 4) × 2)` (`Balance_Bison.cs:559-567`).

**Shared**
- C-point cap `max(0, clamp(floor(0.2 (lv − 50)), 0, 14) − ceil(max(0, bonus − 2 (lv − 1)) / 5))`, ids 451-474 not counted (`Shared_MpDiscountAndCSkillCap.cs:76-82`, `:102`): matches the Mechanics reference's ToT note. Lv 100, 203 bonus points → 10 − 1 = 9.
- Still missing: the Lv 95 stat-growth cap, Royal Card `koPercent`, the MissileBot lifetime, Wall Puncture's level-5 effect.
