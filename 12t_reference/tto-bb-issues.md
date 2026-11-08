# BB issues on TTO (TTO1102 check, 2026-11-08)

The state on TTO (Tailstopia Online) of every issue on the Bible's BB issues page (บั๊ก & คำอธิบายผิด), checked against TTO's client of 2026-11-02 (`DecompiledSource_TTO_2026-11-02/`, tag `TTO1102:`; how to read it: its `BUILD.md`). User request 2026-11-08: "for TTO, check against the latest decompiled code we have, 2 November; for ToT, just leave it be". The page reads these states from `BB_ISSUE_TTO` in `12t_projects/bible/index.html` (rule: `.claude/skills/bible-hub-tools/SKILL.md`, "BB issues: state on TTO / ToT / Reborn").

**States.** *fixed*: TTO's code no longer behaves that way, or (tooltip issues) TTO's tooltip states what TTO's code does. *open*: still there. *unsure*: the code that decides it was not readable.

**Tooltip rule (user 2026-11-08: "count those as fixed").** TTO rebuilt every skill tooltip: the detail rows and effect lines are built in code (`SkillDetailData.<Class><Skill>()`), but BB's old description sentence is still printed under them, wrong number included. A tooltip issue counts as *fixed* when every wrong claim has a correct row or line, even though the old sentence is still there; it is *open* when at least one wrong claim has no correcting row (the rows are silent or wrong). Of the 223 lines checked, 121 tooltip lines are fixed this way.

**Method.** Six read-only research passes (two classes each) read each skill's TTO pseudo-C (`pseudo/<Class>.c`, `pseudo_c6_extra/`) and its TTO tooltip (`tooltips/<class>.json`, `pseudo_tooltips/SkillDetailData.c`); the Common and Boss lines and the status window were decompiled for this check (`GameGui::RenderItemMenu@0x202ED20`, `Germanotta_AI::AI_attack@0x267F5F0`, `Germanotta::ActionEvent@0x23D1A10`, `Germanotta.<RPC_paranoia>d__22::MoveNext@0x23E1C90`) and `atkAdjust`'s callers were counted by a scan of the game code for direct calls (0; `talAdjust` 459 and `lckAdjust` 119 as controls). Lines the card's TTO tab already settled (it clears the note, has a `[Fix]` line, or has its own note) were not re-checked.

**Read-but-assumed.** Some values sit in code Ghidra could not decompile or whose float arguments it drops; there the BB value is assumed where TTO's own tooltip and every readable part agree with it (AGENTS.md: BB code applies on TTO unless a change is shown): `CharacterControl.<addStatus>d__481` (the ignite, valor, drunken and seal multipliers), Gadina's `EquipSword` / `EquipShield`, Ice Block's radius, Pillage Plunge's 30 s, Lucky Card's roll, Awareness's reveal radius, Dark Intention's range. Each line says so.

**Traced last (2026-11-08, user: "Trace all ไม่แน่ใจ").** Seven lines first came back unsure; these methods were then decompiled for them: `ShadowWolf_AI` / `ShadowPanda_AI` / `ShadowRabbit_AI` / `ShadowPenguin_AI` (TTO rebuilt them on an `EnemyAI` base whose `EnemyAI::Learned@0x2487EE0` is `hasSkill(id)` for a unit with no `mShadowOf`, i.e. Bat's zombies, and a by-name skill lookup only for Echo Room shadow copies), `Phoenix_AI::AIControl@0x190CD40` with `EnemyAI::AI_idle@0x2485AB0`, `GameGui.<HandleFoodCommand>d__1146::MoveNext@0x206CD30`, `FoodData::getData@0x20FA9B0` and `MountData::getData@0x2244620`. Six became open. **Still unsure (1):** Mole Tank's English text, which lives only in the item table the server sends at login (`GameData::RequestAll@0x2241310` → `OnResponse@0x2240F80`, gzip), like every item row on TTO (the herbs' type too: their line is open because the handler is BB's, per the 2026-11-06 rule that no client change means no fix).

**Counts (250 lines).** fixed 139, open 110, unsure 1.

## Found along the way (applied 2026-11-08, user: "Implement all Found along the way according to our convention")

* **Getting up from a knock-down keeps lock statuses (TTO engine fix; applied: `[Fix]` lines and cleared notes on the TTO tabs of Nightmare and Gorgon Shot, worded like their Reborn tabs, and a TTO Common row on the server balance page, "ลุกจากล้มขณะติดสถานะล็อก"):** `TTO1102:BaseHero.<RPC_ko>d__157::MoveNext@0x1AE8000` sets `actionState = RestoreActionState()` (`TTO1102:CharacterControl::RestoreActionState@0x24C2F50`), which returns the first held status of `CharacterControl.StateLockStatuses` (`TTO1102:CharacterControl::.cctor@0x24CC270`: petrify, nemesisLarva, snowMan, snowBall, swallow, paralysis, sleep, nightmare, abyssFreeze, abyssPetrify, abyssShackle), else "standby"; also on revive (`BaseHero.<RPC_revive>d__159`) and for Bat clones (`Bat_illusion.<RPC_ko>d__47`). BB sets "standby" (12Tails-Mechanics-Reference.md §4.2.2). Monsters' `BaseEnemy::RPC_ko` was not decompiled.
* **Whale Call To Arm target (TTO change; applied: TTO tab `[แอบ Buff]` locked teammate first, `[Fix]` the 9,999 cut, a TTO desc, and a TTO-tab note in TTO's own words for what remains):** `TTO1102:Whale.<RPC_cast1>d__164::MoveNext@0x1ED4700` warps to the locked teammate if there is one, else the lowest-HP teammate with the search starting at int.MaxValue (BB: lowest HP below 9999, `Whale.cs:20819`); the fallback still has no hp > 0 test and no landing spot still cancels. TTO's tooltip says so.
* **New TTO tooltip mismatches (applied: a TTO-tab `tooltipNote` on Bubble Burst, and one on the Kaiser Beam card `mole_kingKaiser_beam`, since no Bible card shows TTO's Kaiser Beam tooltip):** Bubble Burst's line says it pops "our" Bubble Shields, but the code still removes every ally's (only the caster's deal damage; `TTO1102:Whale.<RPC_bubbleBurst>d__213::MoveNext@0x1ED06D0`); King Kaiser Beam's row says cooldown 30 s, which the client never checks (`TTO1102:KingKaiser::doBeginCharge@0x1CB3180`).
* **Soul of Arms timing:** TTO paces its hits on a timer (4.6, 5.1, 5.3, 5.5, 5.7, 6.2 s after the recorded start, the final hit at 9.5 s, end 9.8 s) instead of BB's animation events; the damage values are BB's (`TTO1102:Sheep.<RPC_soulOfArms_cast>d__193::MoveNext@0x1E9CCD0`). BB's event times cannot be compared: the ripped `soulOfArms.anim` has an empty `m_Events`. No card line (no difference shown); noted in the Sheep reference.
* **Bat Nightmare "can move":** BB's `ApplyMovement` (`LateUpdate`) sets moveSpeed 0 every frame under nightmare (`CharacterControl.cs:2497-2503`, the move itself at `:2722`), which contradicts the live check (user, 2026-10-08) that a target getting up under nightmare moves and acts; the live observation stands (AGENTS.md §3.4), the card is unchanged, and §4.2.2 of the mechanics reference records the discrepancy. Petrify and sleep have no such line, so Gorgon Shot's "moves" matches the code.
* **Reference errors spotted (BB, not TTO; fixed):** `panda-skill-reference.md` gave Drunken Plus "Lv 28 / Bn 18, Lv 32 / Bn 21" (`decode_skilldata.py`: Lv 15 / Bn 2, Lv 21 / Bn 3; the card already had 15) and `getDrunkenSpinLv()` as `hasSkill(423)` (`Panda.cs:9707-9709`: 403).
* **Cards' `ttoTip` (false alarm):** the research passes saw empty rows because the dump they were given flattened the cards' rank functions (`JSON.stringify` drops `fx: (r) => …`); a per-rank comparison of all 588 cards with `tooltips/<class>.json` finds no card with empty rows or lines where the JSON has them (19 cards differ in wording or ranks, outside this check). Nothing re-filled.

## Per class

### Bat

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Nightmare | unintended | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Guardian of the Night (1) | tooltip | fixed | Row 30 s + CHA = code chaAdjust(30×sLv); description still ends (60 sec). `TTO1102:SkillDetailData::BatGuardianOfTheNight@0x21DF100`, `TTO1102:Bat.<RPC_guardianOfTheNight_cast>d__174::MoveNext@0x1B04B00` |
| Guardian of the Night (2) | tooltip | fixed | Row 60 s + CHA = code; description still (90 sec). `TTO1102:SkillDetailData::BatGuardianOfTheNight@0x21DF100` |
| Shadow Illusion | tooltip | fixed | Rows: damage taken 200%, 60 s + CHA = code; description still 160% (30sec). `TTO1102:SkillDetailData::BatShadowIllusion@0x21E24C0`, `TTO1102:Bat::RPC_shadowIllusion_create@0x1ACB9C0` |
| Hate Transfer (1) | tooltip | fixed | Row Hate 20 = code floor talAdjust(20×sLv); description still 40 hate. `TTO1102:SkillDetailData::BatHateTransfer@0x21DF680`, `TTO1102:Bat.<RPC_hateTransfer_cast>d__190::MoveNext@0x1B05800` |
| Hate Transfer (2) | tooltip | fixed | Row Hate 40 = code; description still 80 hate. `TTO1102:SkillDetailData::BatHateTransfer@0x21DF680` |
| Switch | bug | open | Target = (!clone1 \|\| Random(0,2)==0) ? clone2 : clone1: a lone clone in clone1 is missed half the time, as in BB. `TTO1102:Bat::doSkill@0x1AD6BA0` |
| Dream Dazzle (1) | tooltip | fixed | Row SP 3 × 6 = code; description still -9sp. `TTO1102:SkillDetailData::BatDreamDazzle@0x21DE470`, `TTO1102:Bat.<RPC_dreamDazzle_hit>d__195::MoveNext@0x1B01770` |
| Dream Dazzle (2) | tooltip | fixed | Row SP 3 × 8 = code; description still -15sp. `TTO1102:SkillDetailData::BatDreamDazzle@0x21DE470` |
| Phantasm Blast | tooltip | fixed | Row MP 3 × 4% = code; description still -15%mp. `TTO1102:SkillDetailData::BatPhantasmBlast@0x21E1BE0`, `TTO1102:Bat.<RPC_phantasmBlast_hit>d__197::MoveNext@0x1B1DDC0` |
| Dream Burst (1) | tooltip | open | Code bursts every 8 − lv + ... = 8 s at rank 1; no interval row, description still every 7 s. `TTO1102:Bat.<RPC_cAttack1>d__151::MoveNext@0x1AF1670`, `TTO1102:SkillDetailData::BatDreamBurst@0x21DE1A0` |
| Dream Burst (2) | tooltip | open | Every 7 s at rank 2 in code; no row, description still 6 s. `TTO1102:Bat.<RPC_cAttack1>d__151::MoveNext@0x1AF1670` |
| Dream Burst (3) | tooltip | open | Every 6 s at rank 3 in code; no row, description still 5 s. `TTO1102:Bat.<RPC_cAttack1>d__151::MoveNext@0x1AF1670` |
| Mimic | tooltip | fixed | Row 60 s + CHA = code flat chaAdjust(60); description still (90sec). `TTO1102:SkillDetailData::BatMimic@0x21E00C0`, `TTO1102:Bat.<RPC_mimic_create>d__206::MoveNext@0x1B07780` |
| Dark Intention | tooltip | fixed | Row range +12 m (16 → 28); code shape as BB (argument dropped by Ghidra); description still 50%. `TTO1102:SkillDetailData::BatDarkIntention@0x21DCEA0`, `TTO1102:Bat.<RPC_cAttack1>d__151::MoveNext@0x1AF1670` |
| Soul Eater | tooltip | fixed | Rows 39-1333, 39 per debuff level = code clamp(39n, 39, 1333); description still 33*lv. `TTO1102:SkillDetailData::BatSoulEater@0x21E30C0`, `TTO1102:Bat::RPC_soulEater_hit@0x1ACCBE0` |
| Zombie Wolf | bug | open | Settled by the card's TTO tab (it carries its own note). |
| Zombie Panda | bug | open | Still checks isTimeOut('threeStep') while Three Steps sets 'threeSteps'. `TTO1102:ShadowPanda_AI.<AI_attack>d__5::MoveNext@0x1C11BE0`, `TTO1102:Panda (addTimeOut 'threeSteps')` |
| Zombie Rabbit | bug | open | Still checks 'RPC_millionaire' and 'RPC_shootingArray'; the skills set 'millionaire' and 'shootingArray'. `TTO1102:ShadowRabbit_AI::AI_attack@0x1CF5830`, `TTO1102:Rabbit (addTimeOut 'millionaire', 'shootingArray')` |
| Zombie Penguin | bug | open | The Ice Shield branch (Learned 0x144 'iceShield') still checks isTimeOut('arcticWind') before casting Ice Shield. `TTO1102:ShadowPenguin_AI.<AI_attack>d__6::MoveNext@0x1D02450` |

### Bison

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Enrage | bug | open | ATK row = base ATK × damageMod (field 0x298), as in BB (decompiled 2026-11-08). `TTO1102:GameGui::RenderItemMenu@0x202ED20` |
| Enrage | tooltip | fixed | Rows damage +8%, 12 s + CHA = code; description still attack +8% (15 sec). `TTO1102:SkillDetailData::BisonEnrage@0x21E5CE0`, `TTO1102:Bison.<RPC_enrage>d__139::MoveNext@0x1B63A10` |
| Instant Rush | tooltip | fixed | Row minimum range 12 m = code sqrMagnitude > 144; description still 16 m. `TTO1102:SkillDetailData::BisonInstantRush@0x21E66C0`, `TTO1102:Bison::doSkill@0x1B4AC80` |
| Berserker Rush (1) | tooltip | open | Rows give 8% (max 8) and the cleanse, but not that only Combo hits heal, nor the CC immunity. `TTO1102:SkillDetailData::BisonBerserkerRush@0x21E4090`, `TTO1102:Bison.<RPC_nAttack1>d__125::MoveNext@0x1B6A540` |
| Berserker Rush (2) | tooltip | open | Same at rank 2: Combo-only healing and the immunity still unstated. `TTO1102:SkillDetailData::BisonBerserkerRush@0x21E4090` |
| Berserker Rush (3) | tooltip | open | Same at rank 3. `TTO1102:SkillDetailData::BisonBerserkerRush@0x21E4090` |
| Berserker Rush (4) | tooltip | open | Same at rank 4. `TTO1102:SkillDetailData::BisonBerserkerRush@0x21E4090` |
| Power Cleave | tooltip | fixed | Hate row 15 / 30 = code talAdjust(15×(sLv+reel)); description still 30/60. `TTO1102:SkillDetailData::BisonPowerCleave@0x21E88B0`, `TTO1102:Bison.<RPC_powerCleave>d__154::MoveNext@0x1B74C30` |
| Warcry (1) | tooltip | open | Hate row right, but '-10% ATK/tal' still reads as 10% of TAL; code takes ceil(0.1 × target ATK) off both. `TTO1102:SkillDetailData::BisonWarcry@0x21EB7F0`, `TTO1102:Bison.<RPC_warcry>d__159::MoveNext@0x1B7C860` |
| Warcry (2) | tooltip | open | Same at rank 2: '-20% ATK/tal' vs 2 × ceil(0.1 × target ATK). `TTO1102:SkillDetailData::BisonWarcry@0x21EB7F0` |
| Overlord | unintended | open | OnTriggerExit still returns while the Bison has hp < 1 and death never removes overLord (999 s). `TTO1102:Bison_overLord::OnTriggerExit@0x1B9CCA0` |
| Overlord | tooltip | open | No radius row; the lines still say everyone in the circle; code gives it to Tails-race player allies only. `TTO1102:SkillDetailData::BisonOverlord@0x21E8750`, `TTO1102:Bison_overLord::OnTriggerEnter@0x1B9CA90` |
| Iron Skin | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Iron Skin (1) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Iron Skin (2) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Iron Skin (3) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Iron Shield | tooltip | fixed | Row range < 4 m = code ceil(d²) < 16; description still 6 m. `TTO1102:SkillDetailData::BisonIronShield@0x21E67C0`, `TTO1102:CharacterControl::RPC_AddDamage@0x24B8150` |
| Diamond Skin | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Diamond Skin (1) | tooltip | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Diamond Skin (2) | tooltip | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Diamond Skin (3) | tooltip | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Earth Smasher | tooltip | fixed | Radius row 7 m at both ranks = code; description still medium / large circle. `TTO1102:SkillDetailData::BisonEarthSmasher@0x21E5A70`, `TTO1102:Bison.<RPC_earthSmasher>d__168::MoveNext@0x1B62470` |
| Aftershock | tooltip | fixed | Rows radius 4 m, +20% ATK, KO +10, half damage past 2 m = code; description still 5 m. `TTO1102:SkillDetailData::BisonAftershock@0x21E39F0`, `TTO1102:Bison.<RPC_knockDown>d__142::MoveNext@0x1B67270` |
| Steel Skin | tooltip | fixed | Row < 9 m (was 4 m) = code 16 → 81; description still +3 m. `TTO1102:SkillDetailData::BisonSteelSkin@0x21EA4C0`, `TTO1102:CharacterControl::RPC_AddDamage@0x24B8150` |

### Cat

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| nAttack | unintended | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Awareness | tooltip | fixed | Rows radius 12 / 24 m = code 12×sLv; description still 18 m. `TTO1102:SkillDetailData::CatAwareness@0x21EBAC0`, `TTO1102:Cat::RPC_awareness@0x1B84ED0` |
| Lucky Card | unintended | open | Joker branch still adds 0.5×(caster LCK − target LCK) unclamped. `TTO1102:Cat.<RPC_luckyCard>d__182::MoveNext@0x1BB6D00` |
| Lucky Card | tooltip | fixed | Rows 50% ATK + LCK roll on your LCK above the target's = code; description still old. `TTO1102:SkillDetailData::CatLuckyCard@0x21EFBE0`, `TTO1102:Cat.<RPC_luckyCard>d__182::MoveNext@0x1BB6D00` |
| Nine Lives | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Reverse Thrust | tooltip | fixed | Rows 50% ATK + 10 / 20, 2 hits, KO = code; description still 15dmg x2. `TTO1102:SkillDetailData::CatReverseThrust@0x21F1780`, `TTO1102:Cat.<RPC_reverseThrust>d__211::MoveNext@0x1BC5A90` |
| Heart Ripper | tooltip | fixed | Rows = code talAdjust values; description still 20 x2. `TTO1102:SkillDetailData::CatHeartRipper@0x21EEFA0`, `TTO1102:Cat.<RPC_heartRipper2>d__215::MoveNext@0x1BB4D10` |
| Hidden Blade | bug | open | Hidden Blade branches still skip getCritPlus; No Chance still needs actionCode < 10. `TTO1102:Cat.<RPC_nAttack1>d__172::MoveNext@0x1BBBCB0`, `TTO1102:CharacterControl::hit@0x24D57E0` |
| Moon Blade | tooltip | fixed | Rank-2 row 50% ATK + 35 ×2 = code; description still +45 x2. `TTO1102:SkillDetailData::CatMoonBlade@0x21F00E0`, `TTO1102:Cat.<RPC_moonBlade>d__223::MoveNext@0x1BB97F0` |
| Moon Storm (1) | tooltip | fixed | Rank-1 row 50% ATK + 15, 6+2 hits = code; description still +10 x8. `TTO1102:SkillDetailData::CatMoonStorm@0x21F0440`, `TTO1102:Cat.<RPC_moonStorm>d__224::MoveNext@0x1BBAAC0` |
| Moon Storm (2) | tooltip | fixed | Rank-2 row 50% ATK + 25 = code; description still +15 x8. `TTO1102:SkillDetailData::CatMoonStorm@0x21F0440` |
| Evasion | bug | open | The sleep / petrify / paralysis checks still read the attacker's statuses, as in BB. `TTO1102:CharacterControl::hit@0x24D57E0` |
| Delta Strike (1) | tooltip | fixed | Rows 6 × 50% ATK ticks + finisher 50% ATK + 180 = code; description still +135. `TTO1102:SkillDetailData::CatDeltaStrike@0x21ED090`, `TTO1102:Cat.<RPC_deltaStrike>d__225::MoveNext@0x1BA5400` |
| Delta Strike (2) | tooltip | fixed | Rank-2 finisher + 270 = code; description still +180. `TTO1102:SkillDetailData::CatDeltaStrike@0x21ED090` |
| Joker | unintended | open | Same unclamped Joker add as Lucky Card. `TTO1102:Cat.<RPC_luckyCard>d__182::MoveNext@0x1BB6D00` |
| Joker | tooltip | fixed | Rows chance 6% and LCK +0.5× = code lckAdjust(6) and the 0.5×LCK lead; description still 5% and 1.0-3.0. `TTO1102:SkillDetailData::CatJoker@0x21EF680` |
| Three Knives | tooltip | fixed | Line: three daggers, the middle one +6 = code. `TTO1102:SkillDetailData::CatThreeKnives@0x21F2F50`, `TTO1102:Cat.<RPC_flyingDagger>d__207::MoveNext@0x1BAE0D0` |
| Finishing Blow | unintended | open | Only the third of four hits calls OpenWound, as in BB. `TTO1102:Cat.<RPC_finishingBlow2>d__229::MoveNext@0x1BAC780` |
| Open Wound | unintended | open | Settled by the card's TTO tab (it carries its own note). |
| Pillage Plunge | tooltip | fixed | Row 30 s (BB's 30 assumed; Ghidra drops the float); description still 12 Sec. `TTO1102:SkillDetailData::CatPillagePlunge@0x21F0FB0`, `TTO1102:Cat.<RPC_pillagePlunge>d__232::MoveNext@0x1BC3180` |

### Chameleon

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| nAttack | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Far Reach | tooltip | fixed | Rows +4/8/12/16 m and arrow flight +0.1×lv s = code; description still +4 m at every rank. `TTO1102:SkillDetailData::ChameleonFarReach@0x21F62B0`, `TTO1102:Chameleon_nAttack::Init@0x1C53E50` |
| Perfect Blend | tooltip | fixed | Rank-2 row 4 s + CHA = code; description still 3 sec. `TTO1102:SkillDetailData::ChameleonPerfectBlend@0x21F7F40`, `TTO1102:Chameleon.<RPC_perfectBlend>d__155::MoveNext@0x1C1A300` |
| True Invisibility | bug | open | Still stores talAdjust(10×sLv) in invisible's value, which nothing reads. `TTO1102:Chameleon.<RPC_trueInvisibility_cast>d__156::MoveNext@0x1C57820` |
| Increased Poison (1) | tooltip | fixed | Rank-2 row +4 s = code getDebuff(8 + 2×lv); description still +2 sec. `TTO1102:SkillDetailData::ChameleonIncreasedPoison@0x21F6FE0`, `TTO1102:Chameleon_nAttack::OnTriggerEnter@0x1C54740` |
| Increased Poison (2) | tooltip | fixed | Rank-3 row +6 s = code; description still +2 sec. `TTO1102:SkillDetailData::ChameleonIncreasedPoison@0x21F6FE0` |
| Piercing Venom | unintended | open | Bonus still counts poison only; Robots get rust, never counted. `TTO1102:Chameleon_nAttack::OnTriggerEnter@0x1C54740` |
| Piercing Venom | tooltip | fixed | Row +6 per poison level = code; description still +4. `TTO1102:SkillDetailData::ChameleonPiercingVenom@0x21F8140` |
| Venom Shock | bug | open | Still instant on any selected actor with no side check. `TTO1102:Chameleon::doSkill@0x1BDAD20`, `TTO1102:Chameleon.<RPC_venomShock>d__163::MoveNext@0x1C58CC0` |
| Mass Invisibility | bug | open | Still stores talAdjust(20×sLv) in invisible's value, which nothing reads. `TTO1102:Chameleon.<RPC_massInvisibility_cast>d__164::MoveNext@0x1C04070` |
| Clear Arrow | tooltip | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Critical Plus | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Improved Slayer | tooltip | fixed | Rows scale per level = code; description still +10. `TTO1102:SkillDetailData::ChameleonImprovedSlayer@0x21F6BE0`, `TTO1102:Chameleon.<RPC_slayer_fire>d__185::MoveNext@0x1C25640` |
| All Slain | tooltip | fixed | Rank-2 row 200 = code talAdjust(100×sLv); description still 150. `TTO1102:SkillDetailData::ChameleonAllSlain@0x21F3810`, `TTO1102:Chameleon.<RPC_allSlain>d__191::MoveNext@0x1BF0960` |
| Bow Mastery | tooltip | fixed | Row 30 > 40 m/s = code; description still 50%. `TTO1102:SkillDetailData::ChameleonBowMastery@0x21F4700`, `TTO1102:Chameleon_nAttack::Init@0x1C53E50` |
| Skin Shift | bug | open | Skin Shift still runs during a knock-down and the knock-down restarts. `TTO1102:Chameleon::doSkill@0x1BDAD20`, `TTO1102:BaseHero.<RPC_ko>d__157::MoveNext@0x1AE8000` |
| Added Fire | tooltip | fixed | Row +10% ATK = code; description still 30%. `TTO1102:SkillDetailData::ChameleonAddedFire@0x21F35C0`, `TTO1102:Chameleon.<RPC_quickFire>d__154::MoveNext@0x1C1CE00` |
| Erase Senses | tooltip | fixed | Row +4 s for Perfect Blend and True Invisibility = code; description still 50%. `TTO1102:SkillDetailData::ChameleonEraseSenses@0x21F5EF0` |
| Deadly Venom | unintended | open | With Deadly Venom the bonus still counts poison only (Robots 0). `TTO1102:Chameleon_nAttack::OnTriggerEnter@0x1C54740` |
| Tent | unintended | open | Tent still sets damage = max HP as a status-name case. `TTO1102:CharacterControl.<AddDamage>d__46::MoveNext@0x2508720`, `TTO1102:Chameleon.<RPC_tent_cast>d__196::MoveNext@0x1C26BB0` |
| Tent | tooltip | fixed | Rows list full HP / MP, cooldown reset, hate clear and no cure; description still claims a cure. `TTO1102:SkillDetailData::ChameleonTent@0x21F9D80` |

### Mole

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Landmine | tooltip | fixed | Rows 20/30/40/50 = code talAdjust(10×sLv+10); description still 10/20/30/40. `TTO1102:SkillDetailData::MoleMine@0x22012E0`, `TTO1102:Mole::RPC_mine_hit@0x1C345B0` |
| Mortar Shot | tooltip | fixed | Row 50% ATK + 15 = code; description still +10 dmg. `TTO1102:SkillDetailData::MoleMortarShot@0x22019E0`, `TTO1102:Mole::RPC_mortarShot_hit@0x1C35BE0` |
| Stun Mine | bug | open | Lifetime still talAdjust(60); TTO's tooltip even says 60 s + TAL. `TTO1102:Mole_stunMine::Init@0x1CA30A0`, `TTO1102:SkillDetailData::MoleStunMine@0x2203580` |
| Bombardment (1) | tooltip | fixed | Row 25 = code talAdjust(15×sLv+10); description still 35. `TTO1102:SkillDetailData::MoleBombardment@0x21FCEB0`, `TTO1102:Mole.<RPC_bombardment_hit>d__240::MoveNext@0x1C65720` |
| Bombardment (2) | tooltip | fixed | Row 40, 55 with War Area = code; description says 55. `TTO1102:SkillDetailData::MoleBombardment@0x21FCEB0` |
| Detonate | bug | open | A press within 1 s still deals 100% (the falloff skips elapsed 0). `TTO1102:Mole_timeNuke.<doExplode>d__14::MoveNext@0x1CAAD60` |
| Barrel Bot - Mega Punch (1) | tooltip | open | Bot punch 0.4×ATK + talAdjust(12×lv); the tooltip gives the Mole's 50% ATK + 10 and says the bot uses it. `TTO1102:BarrelBot.<RPC_punch>d__50::MoveNext@0x1CBEC40`, `TTO1102:SkillDetailData::MoleMegaPunch@0x2200CE0` |
| Barrel Bot - Mega Punch (2) | tooltip | open | Bot +24 at rank 2; the tooltip still 50% ATK + 20. `TTO1102:BarrelBot.<RPC_punch>d__50::MoveNext@0x1CBEC40` |
| Barrel Bot - Mega Hammer (1) | tooltip | open | Bot hammer talAdjust(10×lv); the tooltip gives the Mole's 50% ATK + 12. `TTO1102:BarrelBot.<RPC_hammer>d__52::MoveNext@0x1CB6850`, `TTO1102:SkillDetailData::MoleMegaHammer@0x2200A60` |
| Barrel Bot - Mega Hammer (2) | tooltip | open | Bot +20 at rank 2; the tooltip still 50% ATK + 24. `TTO1102:BarrelBot.<RPC_hammer>d__52::MoveNext@0x1CB6850` |
| King Kaiser | tooltip | open | No HP row; description still 1500 hp against the prefab's 2000. `TTO1102:SkillDetailData::MoleKingKaiser@0x22003F0` |
| King Kaiser - Normal Attack | tooltip | open | Same tooltip: 1500 hp vs 2000. `TTO1102:SkillDetailData::MoleKingKaiser@0x22003F0` |
| King Kaiser - Kaiser Beam | bug | open | The 30 s Kaiser Beam timeout is still never checked. `TTO1102:KingKaiser::doBeginCharge@0x1CB3180` |
| Mole's Tank | tooltip | unsure | The mount's text and mana live only in the item table the server sends at login (gzip, GameData::OnResponse@0x2240F80); not in the client. `TTO1102:MountData::getData@0x2244620 (GameData.Mount)`, `TTO1102:GameData::RequestAll@0x2241310` |
| Mine Lover | tooltip | fixed | Rows +25% and KO +25% = code ×1.25; description still 50%. `TTO1102:SkillDetailData::MoleMineLover@0x2200F60`, `TTO1102:Mole::RPC_mine_hit@0x1C345B0` |
| Super TNT | tooltip | open | Radius still (4 + Extra Powder)×rangeMod; the description still claims more range. `TTO1102:SkillDetailData::MoleSuperTnt@0x2203AD0`, `TTO1102:Mole.<RPC_tnt>d__221::MoveNext@0x1C90C70` |

### Monkey

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Phoenix - Fireball | unintended | open | After each shot the AI still calls AI_idle(1, 3 − mRapidFireLv) and AI_idle shortens the 1 s idle by Random(0, 3 − RF): 0 at Rapid Fire 3. `TTO1102:Phoenix_AI::AIControl@0x190CD40`, `TTO1102:EnemyAI::AI_idle@0x2485AB0` |
| Rapid Fire | tooltip | fixed | Line cooldown −3/−6/−9 s = code; description still −2/−4/−6. `TTO1102:Monkey.<RPC_cast>d__178::MoveNext@0x1CE8830`, `TTO1102:SkillDetailData::MonkeyRapidFire@0x220B910` |
| Fire Rune | tooltip | fixed | Rows chance 12%, +4/8/12, 1 s rest = code; description still 20%. `TTO1102:Monkey::FireRune@0x1CC69E0`, `TTO1102:SkillDetailData::MonkeyFireRune@0x2208480` |
| World Ignition | tooltip | fixed | Row damage taken +10%×lv = BB code (addStatus not decompiled); description still 10%. `TTO1102:Monkey.<RPC_worldIgnition_cast>d__199::MoveNext@0x1D23A40`, `TTO1102:SkillDetailData::MonkeyWorldIgnition@0x220F000` |
| Ground Lock (1) | tooltip | fixed | Rank-1 damage row 20 = code talAdjust(8×sLv+12); description still 24. `TTO1102:Monkey.<RPC_groundLock_cast>d__201::MoveNext@0x1D06C00`, `TTO1102:SkillDetailData::MonkeyGroundLock@0x2208FC0` |
| Ground Lock (2) | tooltip | fixed | Rank-2 row 28 = code; description still 32. `TTO1102:SkillDetailData::MonkeyGroundLock@0x2208FC0` |
| Ground Lock (3) | tooltip | fixed | Rank-3 row 36 = code; description still 40. `TTO1102:SkillDetailData::MonkeyGroundLock@0x2208FC0` |
| Ground Lock (4) | tooltip | fixed | Rank-4 row 44 = code; description still 48. `TTO1102:SkillDetailData::MonkeyGroundLock@0x2208FC0` |
| Titan Sword | tooltip | fixed | Rows +20/35/50 ATK, KO 1/2/3 = BB code (Gadina::EquipSword not decompiled); description still 40/60, 2/3/4. `TTO1102:SkillDetailData::MonkeyTitanSword@0x220E3D0` |
| Aegis of Earth | tooltip | fixed | Rows +20/35/50 DEF, Ground Lock +1/2/3 s = code; description still 20/40/60 and 4/5/6 s. `TTO1102:SkillDetailData::MonkeyAegisOfEarth@0x2205BC0` |
| Earth Rune | tooltip | fixed | Rows chance 12%, 1 s rest = code; description still 20%. `TTO1102:Monkey::EarthRune@0x1CC6280`, `TTO1102:SkillDetailData::MonkeyEarthRune@0x2207840` |
| Fire Avatar - Fireball | unintended | open | FireRune still rolls at the end of every Fire Avatar attack, hit or miss, and again on a hit. `TTO1102:Monkey.<RPC_phoenixArmor_nAttack>d__234::MoveNext@0x1D11170`, `TTO1102:Monkey_fireBall::OnTriggerEnter@0x1D1B270` |

### Panda

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Rising Dragons | tooltip | fixed | Row finisher 50% ATK + 40 / 80 = code talAdjust(40×sLv); description still +60/+90. `TTO1102:Panda.<RPC_risingDragons>d__195::MoveNext@0x1D91630`, `TTO1102:SkillDetailData::PandaRisingDragons@0x22145D0` |
| Ashura | bug | open | Ashura Fist still starts without an isTimeOut check (the key is written, never read). `TTO1102:Panda::doBeginCharge@0x1D5F8D0`, `TTO1102:Panda.<RPC_ashuraFist>d__202::MoveNext@0x1D710D0` |
| Drunken Fist | bug | open | ATK row still base ATK × damageMod, and drunken is still applied. `TTO1102:GameGui::RenderItemMenu@0x202ED20`, `TTO1102:Panda.<RPC_drunkenFist>d__203::MoveNext@0x1D79800` |
| Drunken Fist | tooltip | open | No +6 in code; no row mentions it and the description still claims +6. `TTO1102:Panda.<RPC_drunkenFist>d__203::MoveNext@0x1D79800`, `TTO1102:SkillDetailData::PandaDrunkenSpin@0x22115F0` |
| Death Blow | tooltip | open | Kill roll has no skill-423 term; the lines mention only the warp and the description still says double chance. `TTO1102:Panda.<RPC_deathBlow>d__211::MoveNext@0x1D775E0`, `TTO1102:SkillDetailData::PandaWindWalker@0x2217640` |
| Mystic Sage | tooltip | fixed | Row heal 50% of damage at full SP = code; description still old. `TTO1102:CharacterControl.<AddDamage>d__46::MoveNext@0x2508720`, `TTO1102:SkillDetailData::PandaMysticSage@0x22124E0` |
| Aura Field | tooltip | fixed | Rows SP 1~3 per second by ATK and charge level = code; description still 20%. `TTO1102:Panda.<RPC_cAttack1>d__167::MoveNext@0x1D730E0`, `TTO1102:SkillDetailData::PandaAuraField@0x220F9F0` |
| Drunken Spin | bug | open | No hit reads Drunken Spin; it only gates the drunk status. `TTO1102:Panda.<RPC_drunkenFist>d__203::MoveNext@0x1D79800`, `TTO1102:Panda::getDrunkenSpinLv@0x1B4EED0` |
| Drunken Spin | tooltip | open | Code has no +6; the lines are silent and the description still says +6. `TTO1102:SkillDetailData::PandaDrunkenSpin@0x22115F0` |
| Wind Walker | tooltip | open | Skill 423 only gives the warp; the description still says it doubles Death Blow's chance. `TTO1102:Panda::doSkill@0x1D60F00`, `TTO1102:SkillDetailData::PandaWindWalker@0x2217640` |

### Penguin

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Falling Stars (1) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Falling Stars (2) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Falling Comets | unintended | open | Still FindAreaTarget(pos, 6, 4) from the edge point: landings inside a big body still miss. `TTO1102:Penguin.<RPC_fallingComets_fire>d__192::MoveNext@0x1DECD20` |
| Falling Comets | tooltip | fixed | Line Falling Comets 9 m blasts = code; range +50% holds for Stars (scatter growth still unstated). `TTO1102:SkillDetailData::PenguinGiantStar@0x221C0D0`, `TTO1102:Penguin.<RPC_giantComets_fire>d__235::MoveNext@0x1DF2450` |
| Frozen Blast | tooltip | fixed | Row slow 20-50%, 3 s + CHA = code; description still (30dmg, 2sec). `TTO1102:SkillDetailData::PenguinFrozenBlast@0x221BBD0`, `TTO1102:Penguin.<RPC_frozenBlast_fire>d__201::MoveNext@0x1DF1900` |
| Ice Shield (1) | tooltip | fixed | Row shield 50 = code talAdjust(20×sLv+10); description still 45 hp. `TTO1102:SkillDetailData::PenguinIceShield@0x221CA30`, `TTO1102:Penguin.<RPC_iceShield_cast>d__207::MoveNext@0x1DF4A30` |
| Ice Shield (2) | tooltip | fixed | Row 70 = code; description still 60 hp. `TTO1102:SkillDetailData::PenguinIceShield@0x221CA30` |
| Ice Shield (3) | tooltip | fixed | Row 90 = code; description still 75 hp. `TTO1102:SkillDetailData::PenguinIceShield@0x221CA30` |
| Ice Block | tooltip | fixed | Rank-1 row radius 9 m (BB 6+3×lv assumed; argument dropped); description still 8m. `TTO1102:SkillDetailData::PenguinIceBlock@0x221C5A0` |
| Frost Bite | tooltip | fixed | Rows freeze 8-20%, slow 3 s, freeze else slow = code; description keeps the old ice text. `TTO1102:SkillDetailData::PenguinFrostBite@0x221B220`, `TTO1102:Penguin_nAttack::OnTriggerEnter@0x1E23B50` |
| Spread Shot | tooltip | fixed | Rows chance 20%, combo hit 3 40% = code; description still a flat 40%. `TTO1102:SkillDetailData::PenguinSpreadShot@0x221F8C0`, `TTO1102:Penguin.<RPC_nAttack1>d__162::MoveNext@0x1DFBB50` |
| Double Spell | tooltip | open | Tooltip still says any spell may repeat; code rolls only with isDoubleSpell + skill 431. `TTO1102:Penguin.<RPC_cast1>d__170::MoveNext@0x1DE4D00`, `TTO1102:SkillDetailData::PenguinDoubleSpell@0x221A180` |
| More Missile | tooltip | fixed | Row damage +0.1×lv = code; description still +6 dmg. `TTO1102:SkillDetailData::PenguinMoreMissile@0x221E030`, `TTO1102:Penguin::RPC_manaMissile_fire@0x1DAAE10` |
| Parallel Shift | bug | open | Double / Triple Cast still repeat Parallel Shift without Double Spell. `TTO1102:Penguin.<RPC_parallelShift>d__232::MoveNext@0x1DFE4B0` |
| Mana Surge | tooltip | fixed | Line MP Transfer +0.5×lv = code; description still 40% of level. `TTO1102:SkillDetailData::PenguinManaSurge@0x221D800`, `TTO1102:Penguin.<RPC_mpTransfer>d__182::MoveNext@0x1DFABE0` |
| Giant Star | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Giant Star | tooltip | open | Settled by the card's TTO tab (it carries its own note). |

### Rabbit

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Bounce (1) | tooltip | fixed | Row 4 s = code landing timer; description still (5 sec). `TTO1102:SkillDetailData::RabbitBounce@0x2221490`, `TTO1102:Rabbit.<RPC_bounce>d__178::MoveNext@0x1E2F6E0` |
| Bounce (2) | tooltip | fixed | Row 8 s = code; description still (10 sec). `TTO1102:SkillDetailData::RabbitBounce@0x2221490` |
| Miracle Blend | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Immune Shot | tooltip | fixed | Rows 20 s + CHA, +1 level per shot = code; description still 15 sec. `TTO1102:SkillDetailData::RabbitImmuneShot@0x2225600`, `TTO1102:Rabbit.<RPC_medicalShot>d__196::MoveNext@0x1E42830` |
| Boost Shot | tooltip | fixed | Rows 35 s + CHA, heal 100×lv, +1 level per shot = code; description still 30 seconds. `TTO1102:SkillDetailData::RabbitBoostShot@0x22211B0` |
| Heat Shot | tooltip | fixed | Rows 35 s + CHA, SP 10×lv, +1 level per shot = code; description still 30 sec. `TTO1102:SkillDetailData::RabbitHeatShot@0x2224FD0` |
| Life Shot | tooltip | open | No HP row; text still 100 hp, double on expiry; code revives 100×lv and heals 200×lv. `TTO1102:SkillDetailData::RabbitLifeShot@0x2225AB0`, `TTO1102:CharacterControl::StatusUpdate@0x24C5A90` |
| Medical Enhancement (1) | tooltip | fixed | Row +5 s = code; description still +10 sec. `TTO1102:SkillDetailData::RabbitMedicalEnhancement@0x2226870` |
| Medical Enhancement (2) | tooltip | fixed | Rank-3 row +15 s = code; description still +10 sec. `TTO1102:SkillDetailData::RabbitMedicalEnhancement@0x2226870` |
| Gorgon Shot | unintended | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Herb Finder | tooltip | fixed | Row chance 20% + LCK = code; description still 30%. `TTO1102:SkillDetailData::RabbitHerbFinder@0x22252B0`, `TTO1102:Rabbit::getHerbFinder@0x1E18EC0` |
| Truce Trading & Co. (1) | tooltip | fixed | Line LCK × 1 beats a roll of target HP = code; description still 10%. `TTO1102:SkillDetailData::RabbitTruceTrading@0x2229540`, `TTO1102:Rabbit.<RPC_truceTrading1>d__224::MoveNext@0x1E78CD0` |
| Truce Trading & Co. (2) | tooltip | fixed | Rank-2 line LCK × 2 = code; description still 20%. `TTO1102:SkillDetailData::RabbitTruceTrading@0x2229540` |
| Shooting Array (1) | tooltip | fixed | Rows 50% ATK + 15 ×3, final 100% ATK + 30 = code; description still +6~30. `TTO1102:SkillDetailData::RabbitShootingArray@0x2228560`, `TTO1102:Rabbit.<RPC_shootingArray>d__226::MoveNext@0x1E4E110` |
| Shooting Array (2) | tooltip | fixed | Rank-2 rows = code; description still +12~60. `TTO1102:SkillDetailData::RabbitShootingArray@0x2228560` |
| Customized Shotgun | tooltip | fixed | Row reach 12 × 6 m = code; description still 2m/4m cone. `TTO1102:SkillDetailData::RabbitCustomizedShotgun@0x22232C0`, `TTO1102:Rabbit.<RPC_shotgun>d__229::MoveNext@0x1E50250` |
| Millionaire | tooltip | fixed | Rows 0.5% / 1% of gil, up to 99,999 = code; description still half / all money. `TTO1102:SkillDetailData::RabbitMillionaire@0x2226A40`, `TTO1102:Rabbit.<RPC_millionaire>d__233::MoveNext@0x1E45120` |
| Snipe Mastery | bug | open | getHypershotLv still 0-4; the description still promises +2 levels. `TTO1102:Rabbit::getHypershotLv@0x1E18FB0`, `TTO1102:SkillDetailData::RabbitSnipeMastery@0x2228A90` |
| Miracle Drop | tooltip | fixed | Line golden potion dealt and taken +20~50% = code level; description still ×2. `TTO1102:SkillDetailData::RabbitMiracleDrop@0x2227180`, `TTO1102:Rabbit_potion::OnTriggerEnter@0x1E70FB0` |
| New Order | bug | open | Free check still raw lv <= ceil(0.5×Rank) (machine-code read 2026-11-03). `TTO1102:GameGui.<HandleCoinCommand>d__1149::MoveNext@0x206A6B0` |
| Dwukphu | bug | open | Same raw-lv free check: free if the coin's server-side level is still negative. `TTO1102:GameGui.<HandleCoinCommand>d__1149::MoveNext@0x206A6B0` |
| Razan | bug | open | Same raw-lv free check. `TTO1102:GameGui.<HandleCoinCommand>d__1149::MoveNext@0x206A6B0` |
| Boldas | bug | open | Same raw-lv free check. `TTO1102:GameGui.<HandleCoinCommand>d__1149::MoveNext@0x206A6B0` |
| Italus | bug | open | Same raw-lv free check. `TTO1102:GameGui.<HandleCoinCommand>d__1149::MoveNext@0x206A6B0` |

### Sheep

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Harmonic Diffuse (1) | tooltip | open | Only Heal and Quick Heal cut hate; the blanket row Hate −15% and the description are still wrong for heals. `TTO1102:Sheep.<RPC_heal_cast>d__165::MoveNext@0x1E89AB0`, `TTO1102:SkillDetailData::SheepHarmonicDiffuse@0x222C4E0` |
| Harmonic Diffuse (2) | tooltip | open | Same at rank 2 (row Hate −30%). `TTO1102:SkillDetailData::SheepHarmonicDiffuse@0x222C4E0` |
| Harmonic Diffuse (3) | tooltip | open | Same at rank 3 (row Hate −45%). `TTO1102:SkillDetailData::SheepHarmonicDiffuse@0x222C4E0` |
| Harmonic Diffuse (4) | tooltip | open | Same at rank 4 (row Hate −60%). `TTO1102:SkillDetailData::SheepHarmonicDiffuse@0x222C4E0` |
| Free Cast | bug | open | Seals still look up 'shp_seal1/2', a skill with no row, so the refund is 0 MP. `TTO1102:Sheep.<RPC_seal>d__189::MoveNext@0x1E9A880`, `TTO1102:Sheep::getFreeCast@0x1E64E40` |
| Free Cast | unintended | open | Neither coroutine calls getFreeCast; the refund is still the table MP, not the charged one. `TTO1102:Sheep.<RPC_soulOfArms_cast>d__193::MoveNext@0x1E9CCD0`, `TTO1102:BaseHero::returnMPSP@0x1AB73B0` |
| Free Cast (1) | tooltip | fixed | Row chance 12% = code lckAdjust(12); description still 6%. `TTO1102:Sheep::getFreeCast@0x1E64E40`, `TTO1102:SkillDetailData::SheepFreeCast@0x222B910` |
| Free Cast (2) | tooltip | fixed | Row 24% = code; description still 12%. `TTO1102:SkillDetailData::SheepFreeCast@0x222B910` |
| Holy Light | unintended | open | A target without the effect child still takes no hit that tick. `TTO1102:Sheep.<RPC_holyLight>d__178::MoveNext@0x1E8AA90` |
| Illuminate | tooltip | fixed | Row 12 s = code chaAdjust(12); description still 15 sec. `TTO1102:Sheep.<RPC_illuminate_cast>d__181::MoveNext@0x1E90310`, `TTO1102:SkillDetailData::SheepIlluminate@0x222CD80` |
| Seal of Attack | bug | open | ATK row still × damageMod and the seal refund is still 0 MP. `TTO1102:GameGui::RenderItemMenu@0x202ED20`, `TTO1102:Sheep::getFreeCast@0x1E64E40` |
| Seal of Attack | tooltip | fixed | Row damage dealt +10% = BB's damageMod +0.1; description still ATK. `TTO1102:SkillDetailData::SheepSealOfAttack@0x222F6D0`, `TTO1102:Sheep_seal::Update@0x1EB5220` |
| Seal of Defense | bug | open | Seal of Defense still looks up 'shp_seal2' (no row): refund 0. `TTO1102:Sheep.<RPC_seal>d__189::MoveNext@0x1E9A880`, `TTO1102:Sheep::getFreeCast@0x1E64E40` |
| Seal of Defense | tooltip | fixed | Row damage taken −10% = BB's hitMod −0.1; description still DEF. `TTO1102:SkillDetailData::SheepSealOfDefense@0x222F900` |
| Seal of Earth | bug | open | ATK row still × damageMod while Seal of Earth is applied. `TTO1102:GameGui::RenderItemMenu@0x202ED20`, `TTO1102:Sheep_seal::Update@0x1EB5220` |
| Seal of Earth | tooltip | fixed | Rows damage dealt +5%, taken −15% = BB's multipliers; description still ATK / DEF. `TTO1102:SkillDetailData::SheepSealOfEarth@0x222FB30` |
| Seal of Heaven | bug | open | ATK row still × damageMod while Seal of Heaven is applied. `TTO1102:GameGui::RenderItemMenu@0x202ED20`, `TTO1102:Sheep_seal::Update@0x1EB5220` |
| Seal of Heaven | tooltip | fixed | Rows damage dealt +15%, taken −5% = BB's multipliers; description still ATK / DEF. `TTO1102:SkillDetailData::SheepSealOfHeaven@0x222FCE0` |
| Repel (1) | tooltip | fixed | Row shield 50 per hit = code (not used up); description still 50 dmg. `TTO1102:CharacterControl.<AddDamage>d__46::MoveNext@0x2508720`, `TTO1102:SkillDetailData::SheepRepel@0x222EA80` |
| Repel (2) | tooltip | fixed | Row 100 per hit = code; description still 100 dmg. `TTO1102:SkillDetailData::SheepRepel@0x222EA80` |
| Soul of Arms | unintended | open | Soul of Arms never calls getFreeCast: Free Cast never procs. `TTO1102:Sheep.<RPC_soulOfArms_cast>d__193::MoveNext@0x1E9CCD0`, `TTO1102:Sheep::doSkill@0x1E60CA0` |
| Soul of Arms (1) | tooltip | fixed | Rows 6 × 30 and final 100 = code; description still 30~60×7. `TTO1102:Sheep.<RPC_soulOfArms_cast>d__193::MoveNext@0x1E9CCD0`, `TTO1102:SkillDetailData::SheepSoulOfArms@0x222FFF0` |
| Soul of Arms (2) | tooltip | fixed | Rank-2 rows 6 × 50 and 150 = code; description still 60~100×7. `TTO1102:SkillDetailData::SheepSoulOfArms@0x222FFF0` |
| Return Cast | unintended | open | Return Cast still unlocks Free Cast only on Purifying Tear, Lullaby and Divinity Axe. `TTO1102:Sheep.<RPC_bookBash>d__204::MoveNext@0x1E7CE90`, `TTO1102:Sheep::getFreeCast@0x1E64E40` |
| Gospel | tooltip | fixed | Line Bless cooldown 30 s = code; description still 30%. `TTO1102:Sheep.<RPC_cast1>d__159::MoveNext@0x1E7FD20`, `TTO1102:SkillDetailData::SheepGospel@0x222BD80` |
| Eden Sanctuary | tooltip | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Book Bash | unintended | open | Book Bash never calls getFreeCast. `TTO1102:Sheep.<RPC_bookBash>d__204::MoveNext@0x1E7CE90` |
| World Encarta | tooltip | open | Settled by the card's TTO tab (it carries its own note). |

### Whale

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| nAttack | bug | open | The Wall Puncture proc still passes raw damage, skipping getCritPlus. `TTO1102:Whale.<RPC_nAttack1>d__153::MoveNext@0x1EE3150`, `TTO1102:Whale::WallPunctureStrike@0x1EC2540` |
| Javelin | bug | open | The Wall Puncture branch still has no Tide Cutter term. `TTO1102:Whale_javelin::OnTriggerStay@0x1F04230` |
| Javelin | unintended | open | One timer for the whole javelin and no per-target memory: every pass hits again. `TTO1102:Whale_javelin::OnTriggerStay@0x1F04230` |
| Honor | unintended | open | KO cut floor((1 − 0.1×honorLv) × KO) still turns KO 1 into 0. `TTO1102:CharacterControl::RPC_AddDamage@0x24B8150` |
| Honor | tooltip | fixed | Line Honor +1 level, Hate +500 = code; description still 300 hate. `TTO1102:SkillDetailData::WhaleHonorStand@0x2233550`, `TTO1102:Whale.<RPC_honor>d__170::MoveNext@0x1EDB5A0` |
| Swallow | bug | open | Settled by the card's TTO tab (it carries its own note). |
| Swallow | unintended | open | gobble is still a plain Buff that Dissolute strips. `TTO1102:Whale.<RPC_swallow>d__175::MoveNext@0x1EF03A0`, `TTO1102:StatusData::isBuffStatus@0x224FAD0` |
| Gobble Up | bug | open | The swallowed target is still freed on the Whale's knock-down while the Whale keeps 'mouth is full'. `TTO1102:CharacterControl::StatusUpdate@0x24C5A90`, `TTO1102:Whale::doSkill@0x1EC4430` |
| Wall Puncture | bug | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Auto Shield | unintended | open | Every resist is still a zero-damage hit that rolls Auto Shield. `TTO1102:CharacterControl::RPC_AddStatus@0x24BDE80`, `TTO1102:CharacterControl::RPC_AddDamage@0x24B8150` |
| Last Hope | tooltip | fixed | Lines per fallen teammate (max 4), 400 HP per ally fallen in 6 s = code; description still 10% M.Hp. `TTO1102:SkillDetailData::WhaleLastHope@0x2234620`, `TTO1102:Whale::LastHope@0x1EBA7D0` |
| Knight of the Deep | tooltip | fixed | Line spear and shield cooldowns −1/3 = code; description still 18 s. `TTO1102:SkillDetailData::WhaleKnightOfTheDeep@0x2234300` |
| Over Presence | unintended | open | Only OnTriggerExit removes the aura status; enemies keep it after the Whale dies. `TTO1102:Whale_overPresence::OnTriggerExit@0x1F04A10` |
| Over Presence | tooltip | open | Slow row 10 / 20% now right, but no radius row and the description still says 10 m, -5/-10%. `TTO1102:SkillDetailData::WhaleOverPresence@0x2235F30` |
| Mal Storm (1) | tooltip | fixed | Row 30 × 4 = code; description still 25x4. `TTO1102:SkillDetailData::WhaleMalStorm@0x2234FD0`, `TTO1102:Whale.<RPC_malStorm>d__201::MoveNext@0x1EE09E0` |
| Mal Storm (2) | tooltip | fixed | Row 50 × 4 = code; description still 40x4. `TTO1102:SkillDetailData::WhaleMalStorm@0x2234FD0` |
| Call To Arm | unintended | open | Settled by the card's TTO tab (it carries its own note). |
| Salvation (1) | tooltip | fixed | Rows 4 s + CHA, every teammate = code; description still (5sec) in range. `TTO1102:SkillDetailData::WhaleSalvation@0x2237440`, `TTO1102:Whale.<RPC_salvation_cast>d__206::MoveNext@0x1EED4B0` |
| Salvation (2) | tooltip | fixed | Row 6 s + CHA, every teammate = code; description still (8sec). `TTO1102:SkillDetailData::WhaleSalvation@0x2237440` |
| Gourmet Heart | unintended | open | Handler unchanged: Gourmet Heart's +100 / +40 / +10 on every eaten item with no type check, a cooldown only for food / desert / drink. Herb types come from the item table the server sends at login; no client change, so not fixed (rule 2026-11-06). `TTO1102:GameGui.<HandleFoodCommand>d__1146::MoveNext@0x206CD30`, `TTO1102:GameData::RequestAll@0x2241310` |
| Honor Stand | unintended | open | KO cut with skill 412 still turns KO 1 into 0. `TTO1102:CharacterControl::RPC_AddDamage@0x24B8150` |
| Honor Stand | tooltip | fixed | Line Hate +500 = code; description still 300 hate. `TTO1102:SkillDetailData::WhaleHonorStand@0x2233550` |
| Bubble Burst | bug | open | Still removes every ally's Bubble Shield; only the caster's deal damage. `TTO1102:Whale.<RPC_bubbleBurst>d__213::MoveNext@0x1ED06D0` |
| Spiral Blast | tooltip | fixed | Lines +20 damage, cleanse physical buffs = code; description still +50%. `TTO1102:SkillDetailData::WhaleSpiralBlast@0x2238110`, `TTO1102:Whale::RPC_hydroBlast_fire@0x1EBDD70` |
| Revitalize | tooltip | fixed | Line Rejuvenate Lv 3 to every teammate = code (no range); description still 12 m. `TTO1102:SkillDetailData::WhaleRevitalize@0x2237080`, `TTO1102:Whale.<RPC_revitalize_cast>d__214::MoveNext@0x1EEBF60` |

### Wolf

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Brave Spirit | bug | open | ATK row = base ATK × damageMod (decompiled 2026-11-08), as in BB. `TTO1102:GameGui::RenderItemMenu@0x202ED20` |
| Brave Spirit (1) | tooltip | open | No speed row; only the description's 3% speed claim remains. `TTO1102:SkillDetailData::WolfBraveSpirit@0x223AC90` |
| Brave Spirit (2) | tooltip | open | Same at rank 2 (4%). `TTO1102:SkillDetailData::WolfBraveSpirit@0x223AC90` |
| Brave Spirit (3) | tooltip | open | Same at rank 3 (5%). `TTO1102:SkillDetailData::WolfBraveSpirit@0x223AC90` |
| Brave Spirit (4) | tooltip | open | Same at rank 4 (6%). `TTO1102:SkillDetailData::WolfBraveSpirit@0x223AC90` |
| Crusader (1) | tooltip | fixed | Rank-1 row 40% ATK + 20 = code; description still +25. `TTO1102:SkillDetailData::WolfCrusader@0x223B940`, `TTO1102:Wolf.<RPC_crusader>d__195::MoveNext@0x1F269F0` |
| Crusader (2) | tooltip | fixed | Rank-2 row + 30 = code; description still +35. `TTO1102:SkillDetailData::WolfCrusader@0x223B940` |
| Crusader (3) | tooltip | fixed | Rank-3 row + 40 = code; description still +45. `TTO1102:SkillDetailData::WolfCrusader@0x223B940` |
| Crusader (4) | tooltip | fixed | Rank-4 row + 50 = code; description still +55. `TTO1102:SkillDetailData::WolfCrusader@0x223B940` |
| No KO | tooltip | fixed | Rows 20/40/60% = code lckAdjust(20×lv); description still 30/45/60%. `TTO1102:SkillDetailData::WolfNoKo@0x223E2D0`, `TTO1102:CharacterControl::RPC_AddDamage@0x24B8150` |
| Second Wind | tooltip | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |
| Feral Instinct (1) | tooltip | fixed | Rank-1 rows +10%, 4% = code; description still 5%. `TTO1102:SkillDetailData::WolfFeralInstinct@0x223C4E0`, `TTO1102:Wolf.<RPC_nAttack1>d__182::MoveNext@0x1F33DB0` |
| Feral Instinct (2) | tooltip | fixed | Rank-2 rows +20%, 8% = code. `TTO1102:SkillDetailData::WolfFeralInstinct@0x223C4E0` |
| Feral Instinct (3) | tooltip | fixed | Rank-3 rows +30%, 12% = code. `TTO1102:SkillDetailData::WolfFeralInstinct@0x223C4E0` |
| Feral Instinct (4) | tooltip | fixed | Rank-4 rows +40%, 16% = code. `TTO1102:SkillDetailData::WolfFeralInstinct@0x223C4E0` |
| Provoke (1) | tooltip | fixed | Rank-1 row 9 s = code; description still 6Sec. `TTO1102:SkillDetailData::WolfProvoke@0x223EB90`, `TTO1102:Wolf.<RPC_provoke>d__208::MoveNext@0x1F3B570` |
| Provoke (2) | tooltip | fixed | Rank-2 row 12 s = code; description still 9Sec. `TTO1102:SkillDetailData::WolfProvoke@0x223EB90` |
| Dark Edge | unintended | open | No holyWolf gate or refund: the cooldown starts, then RPC_AddStatus drops Dark Edge under Holy Wolf. `TTO1102:Wolf::doSkill@0x1F11460`, `TTO1102:Wolf.<RPC_darkEdge>d__222::MoveNext@0x1F28270` |
| Lunar Eclipse | unintended | open | Same for Lunar Eclipse. `TTO1102:Wolf::doSkill@0x1F11460`, `TTO1102:Wolf.<RPC_lunarEclipse>d__224::MoveNext@0x1F30F60` |
| Lunar Eclipse (1) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Lunar Eclipse (2) | tooltip | open | Settled by the card's TTO tab (it carries its own note). |
| Final Eclipse | bug | open | Revised Skill still makes Feral Strike take 2L SP instead of L. `TTO1102:Wolf::doBeginCharge@0x1F0FBD0` |
| Continuous Blade | unintended | open | Combo 5 still keeps the aim of the click that started it. `TTO1102:Wolf::doNormalAttack@0x1F101D0`, `TTO1102:Wolf.<RPC_nAttack5>d__186::MoveNext@0x1F3A120` |
| Holy Sword | tooltip | fixed | Row 24 s = code chaAdjust(24); description still 30 Sec. `TTO1102:SkillDetailData::WolfHolySword@0x223D3F0`, `TTO1102:Wolf.<RPC_holySword>d__230::MoveNext@0x1F301F0` |
| Holy Armor | tooltip | fixed | Row 24 s = code; description still 30 Sec. `TTO1102:SkillDetailData::WolfHolyArmor@0x223D210`, `TTO1102:Wolf.<RPC_holyArmor>d__231::MoveNext@0x1F2F480` |
| Blood Fang | tooltip | fixed | Rows range 5 m (+1), width 4 m (×2) = code; description still both doubled. `TTO1102:SkillDetailData::WolfBloodFang@0x223AAB0`, `TTO1102:Wolf.<RPC_bladeFang>d__206::MoveNext@0x1F1AFF0` |
| Wild Heart | tooltip | fixed | Row Feral Instinct +1 level = code; description still +5%. `TTO1102:SkillDetailData::WolfWildHeart@0x2240300`, `TTO1102:Wolf::getFeralInstinctLv@0x1F15740` |
| Twin Resonance | bug | open | Twin Resonance still sets the cooldown on a Double Art proc with no skill-431 check. `TTO1102:Wolf.<RPC_twinResonance>d__240::MoveNext@0x1F50510` |

### Common

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| ATK ในหน้าต่างสเตตัส (บั๊กการแสดงผล) | bug | open | Settled by the card's TTO tab (it carries its own note). |
| atkAdjust (ระบบคำนวณ) | bug | open | Settled by the card's TTO tab (it carries its own note). |
| สัตว์เลี้ยงทำงานถี่ขึ้นตามเฟรมเรต | unintended | fixed | Settled by the card's TTO tab (it clears the note or has a [Fix] line). |

### Boss

| Skill / issue | Type | TTO | Evidence |
|---|---|---|---|
| Germanotta: Paranoia ไม่ขึ้นที่เครื่องคนอื่น | bug | open | Settled by the card's TTO tab (it carries its own note). |
| Germanotta: Paranoia ไม่จำกัดจำนวนเป้า | bug | open | Settled by the card's TTO tab (it carries its own note). |
