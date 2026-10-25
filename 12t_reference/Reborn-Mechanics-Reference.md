# Reborn — Mechanics Reference

Verified 2026-10-25, first pass. This file covers the **Reborn client**, a separate build with its own codebase. It is kept apart from the original-client docs on purpose: the same file name exists in both codebases with different line numbers.

**Citation tags in this file:** `Reborn:X.cs:N` = `DecompiledSource_Reborn/Assembly-CSharp/X.cs` line N. `BB:X.cs:N` = the original client, `DecompiledSource/X.cs`. Every citation is tagged. Rules: [AGENTS.md](../AGENTS.md) §2 (citation build tags) and §4. Sections 1 to 6 hold only verified facts. Section 7 lists what the Reborn admin announced (evidence type: announcement, checked against the code only where marked). Anything only read, not traced, is in section 8.

**Not a Bible server (yet):** the app has BB, ToT and TTO. Nothing here is shown in it. If Reborn becomes a server, move each verified class finding into that class's `## Server Balance Variations` section.

## 1. Build and method

- **Build verified against:** `12TailsReborn_Data/Managed/Assembly-CSharp.dll`, 18,263,552 bytes, SHA-256 `b1f31a4b9e878167a8b22b5342b70dcefbbf45b5c06e2026660fe057d4c5baf8`, dated 2026-10-25. `app.info` only names the studio and game (no version number), so this hash is the build id. Reborn updates often: re-check the hash before trusting a finding after an update.
- **Engine:** Mono (not IL2CPP). `Managed/` holds `Assembly-CSharp.dll`, `Assembly-CSharp-firstpass.dll`, `Assembly-UnityScript-firstpass.dll`, `Boo.Lang.dll` and the usual libraries.
- **Decompile:** `ilspycmd` 10.1.0.8386, `-p -r Managed`, into `DecompiledSource_Reborn/<assembly>/` (one compilable project per assembly): `Assembly-CSharp` 1,735 `.cs`, `Assembly-CSharp-firstpass` 41, `Assembly-UnityScript-firstpass` 18. By file name, 1,729 class files against the original's 1,455: 279 exist only in Reborn, 5 only in the original (`Assembly-CSharp/*.cs` compared with `DecompiledSource/*.cs`).
- **No junk predicates:** unlike the original ([AGENTS.md](../AGENTS.md) §3), the Reborn code has none (`Reborn:Mole.cs` has 0 matches of the `if (N - N != N)` pattern). Class and field names are intact.
- **Rip:** AssetRipper 2.0.0 (`AssetRipper_win_x64.zip`, SHA-256 `9a7ef0e7c5c3ea5b90b4e6d855e2d98d5f7ec8c3f9e26fccbc194c6a7b01baf7`), 47,338 collections, 97,787 files, 12 GB, into `RippedAssets_Reborn/ExportedProject`. Its `Scripts` are empty stubs: read code only from the decompile. Folders `Resources` 37,858 files, `Texture2D` 13,004, `Mesh` 12,096, `Scene` 1,326, `_reborn_models` 1,292 (Reborn-specific).
- **String table:** many string literals, including every item code, are not in the code. They are helper calls such as `_6A503372_...._204F_2054()` into one class, `Reborn:_003CPrivateImplementationDetails_003E_007B82CE874B_...007D/_6A503372_002DE9D7_002D4DF1_002D9C3B_002D31CE6FD018B6.cs`. Each helper is `UTF8.GetString(blob, offset, length)` (`:16`, the shape `return _5[n] ?? _6(n, offset, len);`). The blob is `StreamingAssets/strblob.bytes` (1,985,110 bytes, SHA-256 prefix `ddf5fdae59fcd386`); the class's static constructor (`:200338`-`:200350`) reads it and undoes it with `byte[i] ^ (i & 0xFF) ^ 0xAA`. To read a string: parse the helper's offset and length with a regex, decode the blob with that XOR, slice. 40,055 helpers parse. It is an obfuscation layer, not encryption (the key is the formula in the game's own code). Decoded start: `standbynoneHeadCannot find Head GameObject…`.
- **StreamingAssets:** `reborn_manifest/` = 281 text files, one per scene or asset group (`A01` login, `C01`-`C50` class assets, equipment, textures, pets, effects, sounds, mounts, `T51`-`T57` towns, `W01`-`W10` worlds), tab-separated `<prefab path> <script> 0 <field> <value>`. Most lines are visual component values (particle emitters and so on). They also hold the serialized `CharacterControl` stats of 339 units (section 4). Read by `Reborn:RebornSceneFix.cs:264`, `:470`, `:1259`. `reborn_ui/` = HUD art (KO bar under MP/SP, teammate MP bars, ping and turret score bar) loaded by `Reborn:GameGui.cs:10296`, `Reborn:RebornPingHud.cs:70`, `Reborn:RebornTurretHud.cs:24`; nothing about skills.

## 2. Global balance sheet (`RebornBalance.cs`)

`Reborn:RebornBalance.cs` (619 lines) is one static class of balance constants and helpers. C# inlines `const` values, so most constants have no call site by name; the helper functions do.

### 2.1 Stat caps

The original clamps DEF, MAG, CHA and TAL, each with its LCK roll `Random(0, ceil(0.2 × LCK))` already added, to **1 to 512 for everyone**: `BB:CharacterControl.cs:20533` (def), `:20586` (mag), `:20600` (cha), `:20640` (tal). Reborn goes through `RebornBalance.CapStat(v, isPlayer, playerCap)` (`Reborn:RebornBalance.cs:182`): a player cap of 0 or less means "no upper limit, minimum 1"; monsters are always clamped to 1-512 (`:50`, `:184`).

| Stat | Reborn player cap | Monster cap | Call site |
|---|---|---|---|
| DEF (with the LCK roll) | **1024** | 512 | `Reborn:CharacterControl.cs:11778` `defAdjust(int)` (`CapStat(def + num, isPlayer, 1024)` at `:11782`); the pierce overload `:11796` (`:11803`) |
| MAG | none (min 1) | 512 | `:11831` `magAdjust` (`:11833`) |
| CHA | none (min 1) | 512 | `:11838` `chaAdjust` (`:11840`) |
| TAL | none (min 1) | 512 | `:11849` `talAdjust` (`:11856`) |
| TAL for heals | none (min 1) | none | `:11861` `talHealAdjust`: `max(tal + roll, 1)`, no `CapStat` at all |

The LCK roll `Random(0, ceil(0.2 × LCK))` is still inside every one of these, unlike TTO.

`defAdjust(nDamage, nPierce)` (`Reborn:CharacterControl.cs:11796`) is a Reborn overload: DEF is multiplied by `1 − 0.01 × clamp(nPierce, 0, 100)` (floored, minimum 1) and the result may not exceed 3 × the normal `defAdjust(nDamage)`. Whether the original has this overload was not checked.

### 2.2 Item effect chances: ×1.3 and no LCK

- `RebornBalance.ItemChance(n)` = `(n × 130 + 99) / 100` in integers, i.e. `ceil(1.3 × n)` (`Reborn:RebornBalance.cs:611`-`:618`). Examples: 3 → 4, 4 → 6, 6 → 8, 12 → 16, 14 → 19.
- It wraps the printed chance in the item data: `Reborn:WeaponData.cs` 180 calls (e.g. `:638` `"+" + ItemChance(14) + "% player charm1"`), `Reborn:AccessoryData.cs` 52 (`:175` `ItemChance(12) + "% disarm resist"`), `Reborn:ArmorData.cs` 27 (`:55` `"+" + ItemChance(4) + "% critical"`), `Reborn:PetData.cs` 16, `Reborn:TrinketData.cs` 3, `Reborn:CharacterControl.cs` 1.
- `CharacterControl.lckItemAdjust(n)` is just `RebornBalance.ItemChance(n)` (`Reborn:CharacterControl.cs:11882`): an item effect rolled through it gets ×1.3 and **no LCK**. The ordinary `lckAdjust` (`:11872`) is untouched. `LuckOnItemEffects = false` (`Reborn:RebornBalance.cs:74`) is the matching constant. Which item procs use `lckItemAdjust` was only traced for Chameleon crit (section 3.3).

### 2.3 Red-star gear ×1.5

`Reborn:ItemData.cs:73` calls `RebornBalance.ApplyRedStar(nCommand, itemClass)` for every item. For a red-star code it replaces each `item.att[i]` except `att[1]` with `RedStarScale` (`Reborn:RebornBalance.cs:106`-`:117`, `:153`-`:166`): positive `v` → `(3v + 1) / 2` (integer division, = `ceil(1.5 v)`), negative mirrored, 0 stays 0. `ItemClass.att` is an `int[8]` (`Reborn:ItemClass.cs:19`, `:42`, `:57`).

A code is red-star (`IsRedStarCode`, `:119`-`:151`) when it is 7 characters, the 2nd is `_`, the 1st is `w`, `a`, `c` or `t`, the 3rd to 5th are one of the 12 race codes (`wlf bsn pnd whl cat chm rab mol mnk shp pgn bat`), the 6th is `5` or `6` and the 7th is `2`. That is the R tier (the "ดด" nickname) of the 60 and 70 series, e.g. `a_rab52` Kalulu Gear R and `a_rab62` Mermaid Armor R; not Mantis (`…48`) or Poseidon (`…66`). `RedStarEnabled = true`, `RedStarNum/Den = 3/2` (`:10`-`:16`).

### 2.4 Belts

`t_all61`, `t_all62`, `t_all63` give +3 crit chance: `TrinketCritPlus` (`Reborn:RebornBalance.cs:543`-`:557`, codes at `:78`), called from 14 files, e.g. `Reborn:Chameleon_nAttack.cs:195`, `Reborn:Chameleon.cs:16033`.

### 2.5 Allies and party

`UsePartyRoster()` is `Game.mGameType <= 3` (`Reborn:RebornBalance.cs:192`). In that mode `Allies` (`:197`-`:251`) returns the caster, the party members' actors that pass `AllyAllowed`, and the caster's own mercenaries (`RebornMerc.AddMine`) unless the caster is charmed; in other modes it returns same-layer players found by `Damage.FindAreaTarget` plus own mercenaries. `AllyAllowed` (`:296`-`:342`): monsters are always allowed; a charmed or mind-controlled unit (`hasStatus("charm")`, `hasStatus("mindControl")`) on either side makes it false; otherwise a unit owned by another player is allowed only if that owner is in your party. `AllyNearRange = 12`, `AllyNearHeight = 3`; party name color green `(0, 1, 0.498)`, guild name `(1, 0, 0.482)`.

## 3. Gear findings

### 3.1 Red star and item chance

See 2.2 and 2.3.

### 3.2 Belts

See 2.4.

### 3.3 Chameleon Combo crit bug: still present

The Bible documents it for BB and TTO ([chameleon-skill-reference.md](chameleon-skill-reference.md) §Crit, `BB:Chameleon_nAttack.cs:517-668`); ToT fixed it. In Reborn the arrow's crit sum is in `Reborn:Chameleon_nAttack.cs:168`-`:199`. The item codes are string-table helpers; decoded:

| Slot | Helper | Code | Adds |
|---|---|---|---|
| Weapon | `_204F_2054`, `_204F_2055` | `w_chm43`, `w_chm44` (G. Marshal Bow B / R) | +4 |
| Weapon | `_2050_206A` | `w_chm48` (Mantis Bow R) | +5 |
| Armor | `_2054_206D` (named twice) | `a_chm43` | +3 |
| Armor | `_2052_00A0` | `a_chm48` (Mantis Suit R) | +4 |
| Hat | `_2054_206E` (named twice) | `c_chm43` | +2 |
| Hat | `_2053_2049` | `c_chm48` (Mantis Hat R) | +3 |

This is the original's table, line for line (`a_chm43` and `c_chm43` do not exist as items; the real Marshal armor and hat are `a_all43/44` and `c_all43/44`). So the Marshal and Champion armor and hat, and the Champion bow `w_chm58`, still give Combo no crit. Then `num3 += TrinketCritPlus(trinket)` (`:195`), `+= RebornEffects.CritPlus(char)` (`:196`, the flat `"critical"` bonus of the Reborn effect system), `+= 4 × Critical Plus level + 4` when learned (`:197`-`:200`), and the roll is `Random(0, 100) < lckItemAdjust(sum)` (`:202`), i.e. **`ceil(1.3 × sum)` with no LCK** instead of the original's `lckAdjust`. Crit damage `ceil(1.8 × dmg)`, or `1.8 + 0.15 × Critical Plus level` with skill 413 (`:204`).

`Reborn:Chameleon.getCritPlus` (`:16003`-`:16038`) has the correct codes (`w_chm43/44` +5, `w_chm58` +7, `a_all43/44` +4, `a_all58` +6, `c_all43/44` +3, `c_all58` +5) but nothing calls it: a search of all `*.cs` for `.getCritPlus(` finds only other classes' own `getCritPlus` (Bat, Bison, Cat, Mole, Monkey, Panda, Penguin, Rabbit, Sheep, Whale), as in the original.

## 4. Units

The 281 `reborn_manifest` files hold the serialized `CharacterControl` stats of 339 units (14 class templates, 60 Tails, 21 plants, 126 bugs, 26 robots, 71 elementals, 21 structures) as plain text, no hex decoding needed (fields `Name`, `Type`, `Race`, `Lv`, `mhp`, `mmp`, `msp`, `mko`, `atk`, `def`, `agi`, `vit`, `mag`, `cha`, `tal`, `lck`, `weight`, `runSpeed`). Checked against the Bible's `MONSTER_STATS` (decoded from the original client): of the 325 non-class units, **322 are identical** (same name and level, same nine stats), none differ. Reborn did not rebalance existing monsters.

Three are new (`reborn_manifest/C17_Elementals.txt`, prefabs `Gods/…`):

| Name | Prefab | Lv | MHP | MMP | MSP | MKO | ATK | DEF | AGI | VIT | MAG | CHA | TAL | LCK | weight | runSpeed |
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
| Baberock | `Gods/EarthGod` | 846 | 890,000 | 10 | 30 | 890 | 520 | 760 | 310 | 890 | 410 | 236 | 320 | 480 | 100 | 3.0 |
| FireGod | `Gods/FireGod` | 845 | 670,000 | 6000 | 100 | 4000 | 970 | 650 | 570 | 67,000 | 460 | 520 | 630 | 300 | 80 | 5.0 |
| FireGod (GM) | `Gods/FireGod_gm` | 845 | identical to FireGod | | | | | | | | | | | | | |

Related Reborn-only code: `Reborn:M994_FightFireGod.cs`, `M995_CelestialSanctum.cs`, `M996_WaveArena.cs`, `FireGod_gm_AI.cs`. Not read yet.

## 5. Classes

Only Panda has been traced, and only the parts below.

### 5.1 Panda

- **SP ceiling:** `RebornBalance.SpCeilingOf` (`Reborn:RebornBalance.cs:559`-`:571`): 100 for everyone; a Panda with skill 443 (`panda_heavenBreath` in the Bible) gets +40, with skill 462 an extra +50. `SpMaxBonusOf` (`:573`-`:580`): +10 with 443. Both are read in `Reborn:CharacterControl.cs:12306`-`:12308`. The name of skill 462 is not resolved.
- **Sacred Sage heal:** `PandaSacredSageHeal(panda, power)` (`Reborn:RebornBalance.cs:582`-`:591`) = `(int)(power × (1 + t / 140))` with `t = max(tal + Random(0, ceil(0.2 × LCK)), 1)`, `0` if `power ≤ 0`. Called from `Reborn:Panda.cs:15657` as `RPC_AddHeal(352 + sLv, PandaSacredSageHeal(char, 50 + 50 × sLv), …)`. For comparison the normal heal scaling is `1 + 0.02 × tal` (`Reborn:CharacterControl.cs:11861`), i.e. `/50`; this one is `/140`.
- **Sage drain:** `PandaSageDrain(panda)` = `max(1, ceil(tal / 100))` (`Reborn:RebornBalance.cs:593`-`:600`), applied when `IsPandaSageAction(actionCode)` (action codes 300 to 372, `:602`-`:609`) at `Reborn:CharacterControl.cs:7294`-`:7296`. What it drains from whom is not traced.

## 6. Reborn code that is new (file list only, not read)

`RebornBalance`, `RebornEffects`, `RebornParty`, `RebornMerc`, `RebornBattlePass`, `RebornChatUi`, `RebornClearArrow`, `RebornC6*` and `RebornC7*` (with `*_C6` files for Bat, Bison, Cat, Chameleon, Mole, Monkey, Panda, Penguin), `Panda_Zr`, `Rabbit_Zr`, `RebornWaveGatePlaque` (676 KB), `MissionGui` (807 KB), guild war and mercenary classes.

## 7. Patch notes and announcements (Discord, read 2026-10-25)

**Source:** the `Tails Reborn` Discord server, information category: `#📢┃ประกาศ` (announcements, Aug 9 to Oct 24), `#📰┃อัพเดท` (updates, Aug 4 to Oct 13) and `#🔧┃patch-notes` (Aug 6 to Oct 19, build ids such as `2026.09.27.1115-c7r13b`). All posts are by the server admins, in Thai. The beta ended 2026-08-17 and the open beta started 2026-08-18 18:00 with a full data wipe. These are the admin's own descriptions: **no numbers for most changes**, so each needs a code check before it is a fact. `#📰┃อัพเดท` is almost only economy, drops, EXP and inventory (nothing on skills except below).

### 7.1 The balance statement (`#📢┃ประกาศ`, 2026-08-17, "ปรับสมดุล")

| Announced | Code check |
|---|---|
| The LUK stat no longer multiplies the chance of **item effects**: the item text now equals the real chance (before, "16% HP drain" could proc 50%+ with high LUK). Skill chances are not touched; LUK still works on skills as before. | **Confirmed in code:** `lckItemAdjust(n)` = `ItemChance(n)` with no LCK (`Reborn:CharacterControl.cs:11882`), `lckAdjust` unchanged (`:11872`); section 2.2. The announcement does not mention the ×1.3 that `ItemChance` also applies. |
| Stats of the **red-star 60/70 items** changed. | **Confirmed in code:** `ApplyRedStar` ×1.5 on every `att` except `att[1]` (`Reborn:ItemData.cs:73`, `Reborn:RebornBalance.cs:106`-`:166`); section 2.3. The announcement gives no factor. |
| Bosses: level by tier, HP, and skill cooldown set to 20 seconds. | Not checked. |
| Merchant skill **SpecialDeal** now affects open-world EXP, for the user and the party. | Not checked (class of "Merchant" not stated). |
| **Sheep** buffs **Bless / Illuminate** become party-wide once Class C is upgraded. | Not checked; consistent with the party-roster ally system, section 2.5. |
| **Monkey** **Summon Soul** becomes a party-wide skill. | Not checked. |

### 7.2 Skill changes in `#🔧┃patch-notes` (class as stated by the admin)

Most entries are bug fixes. Changes that touch skill behavior (Thai text paraphrased):

| Date | Build id | Class | Skill | Announced |
|---|---|---|---|---|
| 2026-09-19 | `2026.09.19.1725-rootpincrash0919` | not stated | Focus | Focus now also adds damage to Double Cast / Triple Cast (only one skill benefits after Focus). |
| 2026-09-19 | same | Bat | Mimic | Can no longer be used on open-world bosses and mini-bosses. |
| 2026-09-24 | `2026.09.24.0800-doubleeffect-seal` | Rabbit | Trading With Wind | Uses 1 Suntide per cast as its text says; the text was corrected. |
| 2026-09-24 | same | Chameleon | ClearArrow | Damage from the clear arrow no longer adds hate (poison and other skills still do). |
| 2026-09-24 | same | Chameleon | Double Effect | Also raises the chance and the duration of Effects from sealing. |
| 2026-09-27 | `2026.09.26.2103-machineid` | Sheep | Heaven's Verdict | "Balance": knockdown force and damage reduced (no numbers). |
| 2026-09-27 | same | Rabbit | Eagle Eye, Trading With Wind | Fixes: Eagle Eye did not work; Trading With Wind hit only one target. |
| 2026-09-27 | `2026.09.27.1115-c7r13b` | Mole | Iron Overdrive | The turret explosion now hits everyone within 6 m: enemies, party, non-party and the Mole (before, non-party players were not hit). |
| 2026-09-27 | same | Rabbit | Bullet Rain | No longer hits friends, enemies only. |
| 2026-09-27 | same | Cat | Shadow Upon Shadow | The clone's explosion now does normal damage, at both the shadow and the Cat's pre-swap position; each enemy is hit once. |
| 2026-09-27 | same | Sheep | Divine Benediction | The overheal shield no longer appears in towns and camps, only in stages and combat zones. |
| 2026-09-27 | same | Panda | Asura Trinity | Gets an initial cooldown. |
| 2026-09-27 | `2026.09.27.2130-venom` | not stated | Veil of the Hunt | Becomes an active skill: party buff "หายตัวล่า" for 20 s; mole turrets do not attack holders of the buff. |
| 2026-09-27 | same | not stated | Venom Apocalypse (poison rain) | At most 4 consecutive rains per press. |
| 2026-09-27 | same | Penguin | HeatDeath | The ice shield no longer disappears when HeatDeath ends. |
| 2026-09-27 | `2026.09.27.2219-reactor` | Mole | Reactor Core 5 | Bug and description fixed. |

Other combat-relevant announcements: party size up to 8 (2026-08-19); open-world monsters reduced 20-50% (2026-08-19); open world always gives EXP, no level-gap rule, monster EXP adjusted instead (2026-09-10); starting max level set to 100 after a vote on 100 against 150 (2026-09-05, patch 2026-09-10); max RP 119,999 → 219,999 (2026-09-04); ranked PvP buff All Status +25 (2026-09-12). Class C row 6 (`C6`) skills went live 2026-09-10 and `C7` on 2026-09-27 (`...-c7r12`); the `RebornC6*` / `RebornC7*` and `*_C6` code files in section 6 are that content.

None of the section 7.2 rows has been compared with the code yet. Each can be: find the skill in `Reborn:<Class>.cs` and its companion files and compare with the original (`BB:`).

## 8. Open questions (read, not traced)

1. **Constants that are inlined:** `LuckOnItemEffects`, `OverHealMaxHpCapEnabled`, `HealTalCap`, `PandaShadowFistDrySpMultiplier = 2`, `PandaShadowFistLeechPercent = 100`, `PandaSpTransferTalPerLevel = 5`, `PandaSkillHitSp = 1` (action code 349), `PandaSageSpDrainEnabled = false`, `PandaHeavenBreathTal/Sp = 10`. Their exact effects need a trace of the literal values in `Panda.cs` and `CharacterControl.cs`.
2. **`RebornEffects`:** the data-driven item-effect table behind `CritPlus`, `ResistPlus`, `SumMag`; where its entries come from is not read.
3. **Which item procs use `lckItemAdjust`:** only Chameleon crit is traced; the other 12 classes' gear procs are not.
4. **`ItemClass.att[1]`:** why red-star scaling skips it (which stat it is).
5. **Whether the original has a pierce `defAdjust` overload,** and the original `talHealAdjust` cap.
6. **Rebalanced skills in other classes:** only Panda constants were seen in code. The Discord channels were read (section 7): they name about 15 skills but give almost no numbers. Each named skill still needs a code comparison with the original (section 7.2), and the unnamed rebalances are only findable by a skill-by-skill diff.
7. **Skill 462** (Panda): name.
8. **New content:** the `*_C6` / `RebornC6` / `RebornC7` systems, the Zr classes, missions M994-M996, battle pass, guild war, mercenaries.
