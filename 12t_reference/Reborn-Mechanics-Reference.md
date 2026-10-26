# Reborn — Mechanics Reference

Verified 2026-10-25, first pass. This file covers the **Reborn client**, a separate build with its own codebase. It is kept apart from the original-client docs on purpose: the same file name exists in both codebases with different line numbers.

**Citation tags in this file:** `Reborn:X.cs:N` = `DecompiledSource_Reborn/Assembly-CSharp/X.cs` line N. `BB:X.cs:N` = the original client, `DecompiledSource/X.cs`. Every citation is tagged. Rules: [AGENTS.md](../AGENTS.md) §2 (citation build tags) and §4. Sections 1 to 6 hold only verified facts. Section 7 lists what the Reborn admin announced (evidence type: announcement, checked against the code only where marked). Anything only read, not traced, is in section 8.

**4th Bible server, in preparation (W.I.P.):** the app's infrastructure for it is in place (2026-10-25: server registry `SERVER_INFO`, W.I.P. logo, a server tab that shows only for cards with `servers.reborn`). When a skill's Reborn values are verified, give its card `servers.reborn` and move the finding into that class's `## Server Balance Variations (Reborn)` section.

**In the app since 2026-10-26:** the engine applies 2.1 (a player's MAG / CHA / TAL uncapped; a summon's own TAL, monsters and the other servers stay at 512), 2.2 (gear crit sums roll `ItemChance` with no LCK) and 2.4 (the +3 belts, a Reborn-only toggle on the crit cards), but only on a card that has Reborn data (`rebornOn`; the class guide follows the guide's own server). The Reborn Common notes state those rules and the SP ceiling once. **Not counted as Reborn changes (user 2026-10-26):** anything that exists only because of the open world (zone gates such as `RebornZone.Combat` / `CombatMap`, start-of-map cooldowns in the new combat maps; the open world counts as missions and arenas) and the party-roster rules outside missions (`UsePartyRoster`, 2.5): they are documented here, not shown on cards.

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
| TAL for heals | none (min 1) | none | `:11861` `talHealAdjust`: `max(tal + roll, 1)`, no `CapStat` at all; for a player the same number as `talAdjust` (2.6) |

The LCK roll `Random(0, ceil(0.2 × LCK))` is still inside every one of these, unlike TTO.

**Level growth has no cap (checked 2026-10-25):** `getTypeLevelStat` is the original formula unchanged, `floor((lv − 1) × (classBase + 3) × 0.083)` per stat (`Reborn:CharacterData.cs:155`-`:163`), and every player stat path passes the character's real level (`Reborn:CharacterDataClass.cs:247`, `Reborn:CharacterControl.cs:12608`). So the growth keeps rising linearly to the Lv 150 cap, unlike ToT's stop at Lv 95 ([12Tails-Mechanics-Reference.md §1.4](12Tails-Mechanics-Reference.md)). Per stat: class base 3 gives 46 / 54 / 74 at Lv 95 / 110 / 150, base 9 gives 93 / 108 / 148. The only fixed-level calls are Flame of Reggu's ATK buff (`+getTypeLevelStat(type, 50)[ATK]` on apply, `−getTypeLevelStat(type, 35)[ATK]` on removal, `Reborn:CharacterControl.cs:4149`, `:11172`), the same lines as the original (`BB:CharacterControl.cs:41659`, `:18659`). The only level-independent limits on the totals are the caps in the table above. The class base stats behind it are unchanged too: `getTypeStat` returns the original 12 rows exactly (`Reborn:CharacterData.cs:102`-`:153`, compared with [12Tails-Mechanics-Reference.md §1.4](12Tails-Mechanics-Reference.md)), and the character-creation roll is the same (`getNewRandomStat`: +1 on 4 random stats, −1 on 4, then +1 on all and clamp 3-12).

`defAdjust(nDamage, nPierce)` (`Reborn:CharacterControl.cs:11796`) is a Reborn overload: DEF is multiplied by `1 − 0.01 × clamp(nPierce, 0, 100)` (floored, minimum 1) and the result may not exceed 3 × the normal `defAdjust(nDamage)`. Whether the original has this overload was not checked.

### 2.2 Item effect chances: ×1.3 and no LCK

- `RebornBalance.ItemChance(n)` = `(n × 130 + 99) / 100` in integers, i.e. `ceil(1.3 × n)` (`Reborn:RebornBalance.cs:611`-`:618`). Examples: 3 → 4, 4 → 6, 6 → 8, 12 → 16, 14 → 19.
- It wraps the printed chance in the item data: `Reborn:WeaponData.cs` 180 calls (e.g. `:638` `"+" + ItemChance(14) + "% player charm1"`), `Reborn:AccessoryData.cs` 52 (`:175` `ItemChance(12) + "% disarm resist"`), `Reborn:ArmorData.cs` 27 (`:55` `"+" + ItemChance(4) + "% critical"`), `Reborn:PetData.cs` 16, `Reborn:TrinketData.cs` 3, `Reborn:CharacterControl.cs` 1.
- `CharacterControl.lckItemAdjust(n)` is just `RebornBalance.ItemChance(n)` (`Reborn:CharacterControl.cs:11882`): an item effect rolled through it gets ×1.3 and **no LCK**. The ordinary `lckAdjust` (`:11872`) is untouched. `LuckOnItemEffects = false` (`Reborn:RebornBalance.cs:74`) is the matching constant.
- So the printed number is the real chance: Poseidon Bow prints `ItemChance(12)` = **16%** (`Reborn:WeaponData.cs:1022`) and rolls `lckItemAdjust(12)` = 16% (BB prints 12% and rolls `lckAdjust(12)`).
- A weapon and a hat with the same effect add their raw chances first and roll once, so ×1.3 is taken of the sum: Poseidon Bow + Poseidon Helmet = `ItemChance(12 + 8)` = **26%**, not 16% + 11% = 27% (Chameleon Double Effect: `ItemChance(40)` = 52%). Seen in each class's on-hit item block: `Reborn:Chameleon.cs:10641`-`:10696`, `Reborn:Rabbit.cs:10758`-`:10773`, `Reborn:Bat.cs:11385`-`:11400`, `Reborn:Wolf.cs:10644`-`:10659`, `Reborn:Penguin.cs:10589`-`:10604`. Chameleon crit also rolls through `lckItemAdjust` (section 3.3).

### 2.3 Red-star gear ×1.5

`Reborn:ItemData.cs:73` calls `RebornBalance.ApplyRedStar(nCommand, itemClass)` for every item. For a red-star code it replaces each `item.att[i]` except `att[1]` with `RedStarScale` (`Reborn:RebornBalance.cs:106`-`:117`, `:153`-`:166`): positive `v` → `(3v + 1) / 2` (integer division, = `ceil(1.5 v)`), negative mirrored, 0 stays 0. `ItemClass.att` is an `int[8]` (`Reborn:ItemClass.cs:19`, `:42`, `:57`).

A code is red-star (`IsRedStarCode`, `:119`-`:151`) when it is 7 characters, the 2nd is `_`, the 1st is `w`, `a`, `c` or `t`, the 3rd to 5th are one of the 12 race codes (`wlf bsn pnd whl cat chm rab mol mnk shp pgn bat`), the 6th is `5` or `6` and the 7th is `2`. That is the R tier (the "ดด" nickname) of the 60 and 70 series, e.g. `a_rab52` Kalulu Gear R and `a_rab62` Mermaid Armor R; not Mantis (`…48`) or Poseidon (`…66`). `RedStarEnabled = true`, `RedStarNum/Den = 3/2` (`:10`-`:16`).

### 2.4 Belts

`t_all61`, `t_all62`, `t_all63` give +3 crit chance: `TrinketCritPlus` (`Reborn:RebornBalance.cs:543`-`:557`, codes at `:78`), called from 14 files, e.g. `Reborn:Chameleon_nAttack.cs:195`, `Reborn:Chameleon.cs:16033`.

### 2.5 Allies and party

`UsePartyRoster()` is `Game.mGameType <= 3` (`Reborn:RebornBalance.cs:192`). In that mode `Allies` (`:197`-`:251`) returns the caster, the party members' actors that pass `AllyAllowed`, and the caster's own mercenaries (`RebornMerc.AddMine`) unless the caster is charmed; in other modes it returns same-layer players found by `Damage.FindAreaTarget` plus own mercenaries. `AllyAllowed` (`:296`-`:342`): monsters are always allowed; a charmed or mind-controlled unit (`hasStatus("charm")`, `hasStatus("mindControl")`) on either side makes it false; otherwise a unit owned by another player is allowed only if that owner is in your party. `AllyNearRange = 12`, `AllyNearHeight = 3`; party name color green `(0, 1, 0.498)`, guild name `(1, 0, 0.482)`.

### 2.6 Heals: `HealTalCap` and `OverHealMaxHpCapEnabled` traced (2026-10-25)

`RebornBalance.HealTalCap = 0` and `OverHealMaxHpCapEnabled = true` (`Reborn:RebornBalance.cs:40`, `:52`) are `const`, so the compiler inlined them and no call site names them.

- **`HealTalCap = 0` means no cap.** The same convention as `CapStat(v, isPlayer, playerCap)` (`Reborn:RebornBalance.cs:182`: a cap of 0 or less only applies `max(v, 1)`). It is the cap behind `talHealAdjust` (`Reborn:CharacterControl.cs:11861`): `max(tal + Random(0, ceil(0.2 × LCK)), 1)`, power × `(1 + 0.02 × that)`, no 512 clamp for anyone.
- **The original has no `talHealAdjust`** (it was an open question): BB heals use the same `talAdjust` as damage, clamped to 1-512 (`BB:CharacterControl.cs:20640`). Reborn gave these heals their own function, but **for a player it returns exactly what `talAdjust` returns** (`Reborn:CharacterControl.cs:11849-11870`: the same `ceil(power × (1 + 0.02 × max(TAL + roll, 1)))`, since `CapStat(…, isPlayer, 0)` is only `max(…, 1)` for a player). The two differ only for a non-player (`talAdjust` clamps a monster's TAL + roll to 1-512, `talHealAdjust` never clamps) and in that `talAdjust` also stores its roll in `RebornDmgTrace.TalRoll` (a trace value, no effect). So the heal change is part of the player TAL cap removal, not a separate buff. Every caller found (all of `Reborn:*.cs`): Sheep `Sheep.cs:1674`, `:2013`, `:3215`, `:14008` (the `(1 + 0.15 × Benediction level) × (10 + 15 × lv)`-type heals; BB `Sheep.cs:10423` uses `talAdjust`), Bison `titanForm` `Bison.cs:5204` (`120 × lv + 80`; BB `Bison.cs:29797`), and the G. Marshal / G. Champion mounts `PvpMount.cs:3546`, `ChampionMount.cs:3594` (`10`; BB `PvpMount.cs:15341`). Other heals still call `talAdjust`, which for a player is uncapped as well (`CapStat(tal + roll, isPlayer, 0)`, section 2 above), so for players every TAL-scaled heal and damage is uncapped; the monster cap is 512 only.
- **Flat heals do not use TAL at all.** Rabbit's Heat / Boost / Life Shot (`RPC_AddHeal(251, 100 × lv)`, `(251, 0, 0, 10 × lv)`, autoLife `200 × lv` and `100 × lv`) are fixed numbers, so `HealTalCap` cannot touch them: those five Rabbit skills are the same as BB (compared 2026-10-25).
- **`OverHealMaxHpCapEnabled`:** no code reads it by name. `AddHeal` clamps HP to `mhp` in both builds (`BB:CharacterControl.cs:7444`, `Reborn:CharacterControl.cs:8256`, clamp `:8272`), so a heal never raises HP above max in either. The only overheal mechanic in Reborn is Sheep's: with skill 462, in a Combat zone, the part of a heal beyond the missing HP becomes a `benediction` shield, capped at `clamp(maxHP / 5, 1, 32000)` (`RebornC7Passive.ShpOverheal`, `Reborn:RebornC7Passive.cs:4561-4577`; the cap is `BenedictionCap` `:4552`). That 20% of max HP cap is the most likely meaning of the flag, but it is not proven, since the constant has no reader.
- **`RPC_AddHeal` / `AddHeal` otherwise match BB** (the `provoke` block that zeroes a heal, HP clamp to `mhp`, MP to `mmp`, KO to `mko`, hate `2 × (HP + MP + SP actually healed)`). Reborn adds: two C7 hooks (`RebornC7Passive.BatHunger`, `SeraphSpread`, `Reborn:CharacterControl.cs:8192-8193`), a `ShpHealHate` hook on the hate (`:8300`), and the SP clamp: `rbSpMax = max(msp, rbSpCeiling)` (`:5983`) instead of BB's fixed 100 (`BB:CharacterControl.cs:7564`, `if (sp > 100)`; Reborn `:8286`); `rbSpCeiling` is 100 plus the Panda bonuses of 5.1.

### 2.7 Status merge: no level bump from a second caster (traced 2026-10-26)

The generic merge inside `RPC_AddStatus` for a status the target already has (same `sType`):

| Existing vs incoming | BB (`BB:CharacterControl.cs:14017-14160`) | Reborn (`Reborn:CharacterControl.cs:9617-9669`) |
|---|---|---|
| same level, same caster (`sID`) | `sTime = max(remaining, sTime)` (`:14035`); `sValue` rules for comboPlus / hardenSkin / damagePlus, else max (`:14050-14103`) | identical (`:9632-9657`) |
| **same level, another caster** | **`sLv++`** unless hpDrain / mpDrain / spDrain (`:14115-14143`), the new caster's `sTime` kept, added at `sLv + 1` | **no level change**: `sTime = max(remaining, sTime)`, `sValue = max(old, new)` (`:9658-9663`) |
| same level, Cat Two Pair copy (`RebornC6.PairCopy`, Reborn only, `Reborn:Cat.cs:3169-3191`) | (n/a) | dropped when `sTime <= remaining`, else `sValue = max` (`:9623-9631`) |
| existing level higher | `return` (`:14153-14159`) | `break`, nothing added (`:9665-9668`) |
| existing level lower | replaced (`:14182`) | replaced (`:9677`) |

So on Reborn two casters can no longer push a status one level past what either gives (BB's "a second Rabbit's Heat Shot on [heat4] gives [heat5]"). The only Reborn level raises are skill-specific: Wolf Unyielding Oath +1 on every buff its holder receives (`Reborn:RebornC7Passive.cs:802-813`), Doomsayer `min(7, sLv + 4)` (`:835-846`) and Cat Grand Casino Arcade's doom `current + 1` (`Reborn:Cat.cs:3865`), which still reaches doom level 8. App: a Reborn Common note row; the four Rabbit medical shots' Reborn desc and change note.

### 2.8 Other global differences found by the 2026-10-26 review

- **Run speed:** the combat run-speed clamp is `Mathf.Clamp(speed, 0, 60)` in every hero file (`Reborn:Wolf.cs:11271`; BB 0-12, `BB:Wolf.cs:621`), and in towns / camps 4-20 (`Reborn:Bat.cs:11987`; BB 4-8, `BB:Bat.cs:1055`). Common note row.
- **Potion cooldown:** 50 s (`Reborn:GameGui.cs:2042`; BB 150 s, `BB:GameGui.cs:32659`). Common note row.
- **Hit boxes:** `Damage.FindAreaTarget` / `FindAngleTarget` / `FindRecTarget` / `FindDonutTarget` test the target's world-space bounds (`RebornHitBox.Radius / Bottom / Top`, `Reborn:RebornHitBox.cs`; `Reborn:Damage.cs:433-436`, `:480`, `:538`, `:551`, `:604-608`); BB uses the unscaled `CharacterController` radius and height (`BB:Damage.cs:1099`, `:1140`, `:1156`). Scaled targets are easier to hit. Common note row (reach popups do not model target size on any server).
- **AI target scan:** the faster scan (1-2 s → 0.3-0.7 s, 1 s → 0.5 s) is in the monster AIs too (171 of 186 `*AI.cs`, e.g. `Reborn:Alpaca_AI.cs:323` vs `BB:Alpaca_AI.cs:1110`); the Common note says all AI now.
- **KO cap:** `koAdjust` = `clamp(floor(koMod × KO), 0, 99)` in both builds and runs only inside `hit()` (`Reborn:CharacterControl.cs:7277`, `:11758`; `BB:CharacterControl.cs:20495`); Effect Damage KO is not clamped. The page clamps a card's KO at 99 unless the card or group is purple (several C6 / C7 cards had KO 100).
- **Stat caps follow `isPlayer`:** summons, Shadow Illusion clones and mercenaries (`Reborn:RebornMerc.cs:944`) stay at 512; mounts (`Reborn:CharacterControl.cs:5258`) and Bat Mimic copies (`Reborn:Bat.cs:6081`) count as players. Common note text fixed.
- **Open (user decision pending):** about 150 player cards have no `servers.reborn`, so they never offer the Reborn tab and show BB's 512 caps (55 TAL damage / heal cards, 48 CHA durations, 53 INT casts, the mounts).

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

### 3.4 Effect seals ("ผนึก", `RebornEffects`), traced 2026-10-25

A gear-effect system that exists only in Reborn (BB has no `RebornEffects`). Not to be confused with Sheep's Seal of Earth / Heaven or the Earth / Shadow Seal belt procs (`Reborn:CharacterControl.cs:7791`-`:7803`).

- **Data lives on the server.** The whole table arrives as one string under key 210 of the character-data hashtable, `RebornEffects.LoadTable(data[210])` (`Reborn:CharacterDataClass.cs:1765`-`:1768`). Rows are `id|label|status|statusLv|chance|magnitude|kind|slots`, split by `;` and `|` (`Reborn:RebornEffects.cs:78`-`:120`); the admin edits it at `/admin/effects` (warning text at `:113`-`:116`) and can change it at any time. Nothing in `12TailsReborn_Data` holds it, so **no seal value can be verified from the client**. The race table for the race kinds is key 212 (`Reborn:CharacterDataClass.cs:1773`-`:1776`).
- **Items.** Each equipment entry stores only an effect id, `%f<id>` (`Reborn:CharacterDataClass.cs:2046`-`:2048`, `Reborn:InventoryClass.cs:215`-`:217`), over 6 slots: weapon, armor, hat, boots, trinket, pet. Effect Seal Box `f_esb1` ("rolled at the server's rates", `Reborn:FieldData_eng.cs:700`-`:701`), Effect Seal Plate `m_esl1`, Gilded Sealing Ink `m_esk1`; the NPC Razan (Compound, `Reborn:RebornNpcMenu.cs:119`). The `slots` field is only displayed: no effect code checks it.
- **19 kinds** (`Reborn:RebornEffects.cs:36`-`:72`): `proc_hit`, `stat_flat`, `dmg_up`, `dmg_cut`, `race_up`, `race_cut`, `race_set`, `vit_bane`, `def_cut`, `def_skip_roll`, `salv_break`, `salv_break_roll`, `pure_cut`, `pure_stop_roll`, `strip_buff_hit_roll`, `strip_all_hit_roll`, `strip_buff_hurt_roll`, `strip_all_hurt_roll`, `hp_vit_pvp`. Only `proc_hit` applies a status.
- **`proc_hit`** (`ProcOnHit`, `Reborn:RebornEffects.cs:184`-`:269`): the same seal id on two slots counts once (`:207`-`:220`); different seals that name the same status add their chances (`:245`) and the strongest row (higher magnitude, then higher statusLv) gives the level and duration (`:226`-`:244`). One roll per status: `Random(0,100) < lckItemAdjust(nMult × sum)` = `ceil(1.3 × nMult × sum)` with no LCK (`:256`; section 2.2). Duration `nMult × Damage.getDebuff(magnitude, wearer CHA, target CHA)`, 1 s when magnitude ≤ 0 (`:259`-`:260`). The status goes on the hit target through the normal `RPC_AddStatus` path (resists, Immunity, Robots list, level merge all apply).
- **Drain seals** (hp/mp/sp/ko Drain and Sap): amount `floor(0.01 × statusLv × wearer max)` (max HP, max MP, the Reborn SP cap, max KO; `DrainAmountOf` `:308`-`:332`), applied once on apply, same branch as BB.
- **Chameleon Double Effect** (431) passes `nMult = 2` (`Reborn:Chameleon.cs:10575`, `:10581`): chance and duration ×2, drains chance only. No other class passes anything but 1.
- **Which hits roll seals:** only each hero's `onNormalAttackHit` (`Reborn:Wolf.cs:10544`, `Bison.cs:9235`, `Panda.cs:11966`, `Whale.cs:10253`, `Cat.cs:11114`, `Chameleon.cs:10581`, `Mole.cs:10992`, `Rabbit.cs:10658`, `Monkey.cs:10641`, `Sheep.cs:10072`, `Penguin.cs:10489`, `Bat.cs:11285`) and `Bat_illusion.cs:1386` (the owner's seals). These are the Combo stages and Combo projectiles plus the few skills that already rolled built-in weapon effects in BB (Rabbit From The Above and shotgun, Monkey Mike Blink, Sheep Homing Light and Book Bash, Bat Illusion fire). No C6/C7 skill and no mercenary calls it.
- **`stat_flat` keys the client reads** (stack across slots, `FlatOf` `:334`-`:350`): `maxhp`, `sp` (adds to the SP cap), `critical` (added to the gear crit sum, rolled with `lckItemAdjust`), `resist` (the equipment debuff-resist roll; not State or System statuses, `Reborn:CharacterControl.cs:9533`-`:9554`), `weight`.
- **Damage kinds** (`RebornCombat`): white damage only, after the victim's hitMod and the shield / item blocks: `ceil((1 + up%)(1 − cut%) × dmg)`, cut ≤ 80, up ≥ −80, minimum 1 (`Reborn:RebornCombat.cs:32`-`:84`, `Reborn:CharacterControl.cs:7341`, `:7824`-`:7830`). `vit_bane` capped 60 PvE / 100 PvP (`:86`-`:211`); `def_cut` sums to a DEF pierce capped at 100, `def_skip_roll` sets it to 100 (`:391`-`:412`). Purple damage gets only the victim's `pure_cut` (cap 80) or `pure_stop_roll` (`:443`-`:469`). `salv_break` ignores Salvation; strip rolls remove buffs (or all statuses) except System statuses and the flags (`:240`-`:343`, `:414`-`:440`).
- **Tooltip quirk:** on sealed gear the purple special line shows the seal label instead of the item's own special (`Reborn:Guix.cs:954`-`:959`), but the built-in effect still procs (e.g. `Reborn:Wolf.cs:10544`-`:10569`). A plate shows `ผนึก: label [slots]` (`Reborn:RebornEffects.cs:522`-`:606`).
- **Statuses:** no new ones. Reborn's 80 debuffs are BB's 80; 75 had Bible popups, and the other 5 (heavy, plague, inferno, loveBind, netherBane) are an all-server gap, not a Reborn change.
- **In the Bible:** seals are not Buff / Debuff popup rows (their values are server data). The Reborn Common notes give the rules only. A seal table would need live data (an export of `/admin/effects` or plate tooltips read in game).
- **Open:** the live table; whether labels show the chance before or after ×1.3 (the client never rescales a label, unlike built-in item text); whether Razan enforces `slots` or allows the same seal on two slots (`FlatOf` / `SumMag` / `SumChance` would count it twice); Seal Box rates; `vit_bane` a,b defaults (12, 0.5) and the race table; whether mercenaries carry seals.

### 3.5 Reborn-only equipment (on hold for the Bible, 2026-10-25)

**Status (user 2026-10-25):** these items are not usable in game yet, so none of them is in the Bible. Everything needed to add them is kept here (data) and in `D:\12tails-assets-archive\reborn-pending-gear-2026-10-25` (outside the repo): `add_seals.py` / `add_wing.py` put the Seals and Angel Wing into the class guide gear picker, `find.py` / `weapons.py` regenerate the lists from the client, and the viewers `reborn_gear.html` / `weapons.html` show them.

- **How they were found:** every item code in Reborn's `WeaponData` / `ArmorData` / `AccessoryData` (hats) / `BootData` / `TrinketData` / `PetData` that the original's data files do not have: 48 codes (28 weapons, 1 hat, 6 boots, 13 trinkets, no armor or pet). The Ignis series also redefines 8 original weapon codes, listed with the weapons.
- **Weapon stats** are the values the game ends up with: the item's block in `getData0`-`getData9`, then the Reborn override block at the top of `WeaponData.getData` (`Reborn:WeaponData.cs:24`-`:556`). `w_<class>70` is read as `w_<class>69` (`RebornModels.TimeBase`, `Reborn:RebornModels.cs:356`-`:380`) and gets " R" added to its name. No upgrade (+N) or seal included.
- **Planned Bible gear entries** (the user's names, 2026-10-25): Seals `t_all_reborn101`-`108`, nickname `แหวน <STAT> 25`, `GEAR_LV` 100; Angel Wing `t_all_reborn110` named **Angel Wing** (the game data spells it "Angle Wing"), nickname `ปีก ALL 12`, `GEAR_LV` 90; all `GEAR_SERVERS` `["reborn"]`; icons = the rip's 128 px `gamegui/icons/items/trinket/all101`-`110.png` as WebP (no upscale). Weapons have no planned ids or nicknames yet.

**Trinkets** (`Reborn:TrinketData.cs:1426`-`:1497`, weight 4 for the Seals, 1 for Angel Wing):

| Code | Name | Lv | Stats |
|---|---|---|---|
| `t_all101` | Bloodflare Seal | 100 | ATK +25 |
| `t_all102` | Deepfrost Seal | 100 | DEF +25 |
| `t_all103` | Lifebloom Seal | 100 | AGI +25 |
| `t_all104` | Dawnflare Seal | 100 | VIT +25 |
| `t_all105` | Soulheart Seal | 100 | INT +25 |
| `t_all106` | Voidshade Seal | 100 | CHA +25 |
| `t_all107` | Skysurge Seal | 100 | TAL +25 |
| `t_all108` | Sunforge Seal | 100 | LCK +25 |
| `t_all110` | Angel Wing ("Angle Wing" in the data) | 90 | all 8 stats +12; special text "Sometime it make you fly.." (no code behind it; the class equipment files only attach the wing model) |

**Zephyra (`w_<class>85`, all new codes):**

| Code | Name | Lv | ATK | DEF | AGI | VIT | INT | CHA | TAL | LCK | Total |
|---|---|---|---|---|---|---|---|---|---|---|---|
| `w_wlf85` | Zephyra Brand | 90 | 71 | - | 42 | - | 38 | - | - | 29 | 180 |
| `w_bsn85` | Zephyra Axe | 90 | 78 | - | 40 | - | 34 | - | - | 28 | 180 |
| `w_pnd85` | Zephyra Knuckle | 90 | 73 | - | 41 | - | 39 | - | - | 27 | 180 |
| `w_whl85` | Zephyra Spear | 90 | 70 | - | 37 | - | 43 | - | - | 30 | 180 |
| `w_cat85` | Zephyra Dagger | 90 | 67 | - | 45 | - | 34 | - | - | 34 | 180 |
| `w_chm85` | Zephyra Bow | 90 | 70 | - | 41 | - | 39 | - | - | 30 | 180 |
| `w_rab85` | Zephyra Rifle | 90 | 68 | - | 42 | - | 40 | - | - | 30 | 180 |
| `w_mol85` | Zephyra Cannon | 90 | 68 | - | 41 | - | 42 | - | - | 29 | 180 |
| `w_mnk85` | Zephyra Mike | 90 | 61 | - | 42 | - | 47 | - | - | 30 | 180 |
| `w_shp85` | Zephyra Codex | 90 | 63 | - | 41 | - | 47 | - | - | 29 | 180 |
| `w_pgn85` | Zephyra Staff | 90 | 62 | - | 39 | - | 50 | - | - | 29 | 180 |
| `w_bat85` | Zephyra Wand | 90 | 64 | - | 41 | - | 46 | - | - | 29 | 180 |

**Time … R (`w_<class>70`, the R version of the Lv 80 Time weapons; special "+2% revert" = `ItemChance(1)`):**

| Code | Name | Lv | ATK | DEF | AGI | VIT | INT | CHA | TAL | LCK | Total |
|---|---|---|---|---|---|---|---|---|---|---|---|
| `w_wlf70` | Time Swords R | 80 | 30 | 51 | 21 | 21 | - | 21 | - | - | 144 |
| `w_bsn70` | Time Hammer R | 80 | 40 | 54 | 13 | 24 | - | 13 | - | - | 144 |
| `w_pnd70` | Time Knuckle R | 80 | 34 | 47 | 23 | 18 | - | 22 | - | - | 144 |
| `w_whl70` | Time Lance R | 80 | 21 | 60 | 13 | 27 | - | 23 | - | - | 144 |
| `w_cat70` | Time Claws R | 80 | 28 | 45 | 34 | 15 | - | 22 | - | - | 144 |
| `w_chm70` | Time Bow R | 80 | 28 | 45 | 30 | 15 | - | 26 | - | - | 144 |
| `w_rab70` | Time Shotgun R | 80 | 30 | 45 | 23 | 17 | - | 29 | - | - | 144 |
| `w_mol70` | Time Cannon R | 80 | 32 | 48 | 21 | 22 | - | 21 | - | - | 144 |
| `w_mnk70` | Time Mike R | 80 | - | 40 | 15 | 17 | 21 | 28 | 23 | - | 144 |
| `w_shp70` | Time Codex R | 80 | - | 35 | 22 | 19 | 20 | 31 | 17 | - | 144 |
| `w_pgn70` | Time Staff R | 80 | - | 35 | 20 | 17 | 23 | 26 | 23 | - | 144 |
| `w_bat70` | Time Wand R | 80 | - | 36 | 19 | 17 | 18 | 38 | 16 | - | 144 |

**Ignis (`w_<class>81`; Wolf, Bison, Cat, Chameleon, Mole, Sheep, Penguin and Bat reuse the original Flaming weapon codes, renamed and re-statted):**

| Code | Name | Lv | ATK | DEF | AGI | VIT | INT | CHA | TAL | LCK | Total |
|---|---|---|---|---|---|---|---|---|---|---|---|
| `w_wlf81` | Ignis Brand (was Flaming Brand) | 90 | 128 | - | - | 31 | - | - | 21 | - | 180 |
| `w_bsn81` | Ignis Axe (was Flaming Axe) | 90 | 140 | - | - | 24 | - | - | 16 | - | 180 |
| `w_pnd81` | Ignis Knuckle | 90 | 130 | - | - | 30 | - | - | 20 | - | 180 |
| `w_whl81` | Ignis Spear | 90 | 121 | - | - | 35 | - | - | 24 | - | 180 |
| `w_cat81` | Ignis Dagger (was Flaming Dagger) | 90 | 117 | - | - | 28 | - | - | 35 | - | 180 |
| `w_chm81` | Ignis Bow (was Flaming Bow) | 90 | 117 | - | - | 28 | - | - | 35 | - | 180 |
| `w_rab81` | Ignis Rifle | 90 | 120 | - | - | 27 | - | - | 33 | - | 180 |
| `w_mol81` | Ignis Cannon (was Flaming Cannon) | 90 | 122 | - | - | 26 | - | - | 32 | - | 180 |
| `w_mnk81` | Ignis Mike | 90 | 104 | - | - | 27 | - | - | 49 | - | 180 |
| `w_shp81` | Ignis Codex (was Flaming Scroll) | 90 | 105 | - | - | 26 | - | - | 49 | - | 180 |
| `w_pgn81` | Ignis Staff (was Flaming Staff) | 90 | 100 | - | - | 28 | - | - | 52 | - | 180 |
| `w_bat81` | Ignis Wand (was Flaming Wand) | 90 | 108 | - | - | 25 | - | - | 47 | - | 180 |

**Other Reborn-only items** (name, level; no stats read): `c_allwht` Witch Hat Lv 61 (no icon in the client); `b_all4` Wing Boots Lv 0; `b_all34` Keroro Boots Lv 0; `b_all39` Sliper Boots Lv 39; `b_all67` Phantom Dash Boots Lv 65 (no icon in the client); `b_all68` Spiritweave Boots Lv 65 (no icon in the client); `b_all69` FireLord Boots Lv 69 (no icon in the client); `t_allGM` Aura For GM Lv 1 (no icon in the client); `t_allT1` Aura For Top 1 Lv 1 (no icon in the client); `t_all120` Wing of Light Lv 100 (no icon in the client); `t_all140` XiaFei Lv 99 (no icon in the client).

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

**C6 / C7 skills of every class are on cards since 2026-10-26** (`onlyServer: "reborn"`, the 451-454 / 461-464 skills, replacing the coming-soon stubs); each class reference holds them under `## Server Balance Variations (Reborn)` → `### C6 / C7 skills (Reborn only)`, with the original skills they change. Shared hooks the cards use:

- **`RebornC6Passive.OnHitOut`** (`Reborn:RebornC6Passive.cs:58-99`, called inside `hit()` at `Reborn:CharacterControl.cs:7261`): a C6 multiplier on the attacker's hit after the skill's own crit and multipliers, before `dmgAdjust`, `CeilToInt((float)dmg × mult)`, never on Effect Damage. App: card field `hitOutDep`.
- **`RebornC7Passive.FinalOut`** (`Reborn:RebornC7Passive.cs:538-596`, applied at `Reborn:CharacterControl.cs:7275`): a C7 factor after `dmgAdjust` and `defAdjust`, before the target's hitMod, `CeilToInt` in float32, normal hit path only. App: card field `finalOut` (helper `finalOutAdjust`).
- The C6 / C7 passive hooks run inside `hit()` / `RPC_AddDamage` only, so a hit that skips them (Effect Damage, a penetrating hit) gets none of these factors.

The sections below are the first-pass notes of 2026-10-25.

### 5.1 Panda

- **SP ceiling:** `RebornBalance.SpCeilingOf` (`Reborn:RebornBalance.cs:559`-`:571`): 100 for everyone; a Panda with skill 443 (`panda_heavenBreath` in the Bible) gets +40, with skill 462 an extra +50. `SpMaxBonusOf` (`:573`-`:580`): +10 with 443. Both are read in `Reborn:CharacterControl.cs:12306`-`:12308`. Skill 462 is **Spirit Overflow** (`panda_spiritOverflow`, resolved 2026-10-26; card and effects in [panda-skill-reference.md](panda-skill-reference.md)).
- **Sacred Sage heal:** `PandaSacredSageHeal(panda, power)` (`Reborn:RebornBalance.cs:582`-`:591`) = `(int)(power × (1 + t / 140))` with `t = max(tal + Random(0, ceil(0.2 × LCK)), 1)`, `0` if `power ≤ 0`. Called from `Reborn:Panda.cs:15657` as `RPC_AddHeal(352 + sLv, PandaSacredSageHeal(char, 50 + 50 × sLv), …)`. For comparison the normal heal scaling is `1 + 0.02 × tal` (`Reborn:CharacterControl.cs:11861`), i.e. `/50`; this one is `/140`.
- **Sage drain:** `PandaSageDrain(panda)` = `max(1, ceil(tal / 100))` (`Reborn:RebornBalance.cs:593`-`:600`), applied when `IsPandaSageAction(actionCode)` (action codes 300 to 372, `:602`-`:609`) at `Reborn:CharacterControl.cs:7294`-`:7296`. What it drains from whom is not traced.

### 5.2 Rabbit

- **Eagle Eye** (Class C row C6, skill 451): +35% reach, area, effect size and distance gates on the Rabbit's gun and acid skills, and the whole target lock (drop 40 to 54 m, Tab 36 to 48.6 m) through `RebornC6.RabEye` (`Reborn:RebornC6.cs:2208`). Full list with `file:line`: [rabbit-skill-reference.md, Server Balance Variations (Reborn)](rabbit-skill-reference.md#server-balance-variations-reborn). On a card since 2026-10-26 (`rabbit_eagleEye`), and a Reborn toggle on the 23 cards it scales.

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

### 7.3 Code check of the announced changes to original skills (2026-10-25)

Every announcement in 7.1 and 7.2 that touches a skill of the original game was traced in `Reborn:` against `BB:`. Shared ally list used below: `RebornBalance.AlliesWholeMap(self)` = `Allies(self, 100000, 100000)` (`Reborn:RebornBalance.cs:253-256`): in party mode (`Game.mGameType <= 3`) the caster, every party member that passes `AllyAllowed` and the caster's own mercenaries (unless charmed), at any distance; in other game types every same-layer player on the map plus own mercenaries (`:192-244`).

| Skill | Verdict | What the code does |
|---|---|---|
| Sheep **Bless** | Buff, announcement accurate | With Gospel (412) Bless goes to every ally on the list at level `sLv + 1`, `chaAdjust(30)`, and the cast needs no target (`Reborn:Sheep.cs:1829-1837`, `:13485`, `:1110`); without 412 it stays single-target at `sLv` (`:1839-1859`). BB: single target only, refused with no target (`BB:Sheep.cs:22788-22824`, `:8834`). Cooldown, cast time and the status (+`4·sLv + 4` all stats) unchanged (`Reborn:Sheep.cs:876-879`, `Reborn:CharacterControl.cs:3367-3379`). Not announced: with 412 a clicked player outside the party gets nothing; party members get it at any distance. |
| Sheep **Illuminate** | Buff, accurate | With Blinding Light (413) every ally on the list gets level `sLv + 2`, `chaAdjust(12)`, no target needed (`Reborn:Sheep.cs:4045-4053`, `:13429`, `:1289`); without 413 single target at `sLv` (`:4055-4057`). Tick unchanged: every 3 s HP `4·sLv`, MP `sLv`, SP `sLv` (`Reborn:CharacterControl.cs:8890-8896`). |
| Monkey **Summon Soul** | Buff, accurate | `RebornMonkeySoul.Apply` gives the soul to every ally on the list for 240 s (`Reborn:RebornMonkeySoul.cs:90-112`, from `Reborn:Monkey.cs:1460`), unconditionally (`PartyWideEnabled = true`, `:5`; no skill check); no target or player tag needed (`Reborn:Monkey.cs:13879-13889`). BB: one player target (`BB:Monkey.cs:8496-8538`, `:24189-24407`). Same: once per summon, 3 s cooldown. **Not announced: Gaos Soul is now +20 to all 8 stats** (`Reborn:CharacterControl.cs:3096-3105`) instead of BB's +40 ATK / +40 DEF (`BB:CharacterControl.cs:38289-38296`); Phoenix / Ja / Gadina / Buiten souls unchanged (+`10·sLv`, `Reborn:CharacterControl.cs:3044-3085`). The C7 skill 461 adds the second summon's soul party-wide too (`Reborn:RebornC7Passive.cs:2858-2869`). |
| Rabbit **Special Deal** | Buff on the tooltip, not verifiable in the client | The tooltip adds "exp from monsters in the dungeon" to the party's mission money / EXP bonus, same 5 / 10 / 15 / 20% (`Reborn:RabbitSkill_eng.cs:320-335`, `RabbitSkill_thai.cs:326-341`; BB `BB:RabbitSkill_eng.cs:829-862`). No client code reads skills 361-364 for EXP: EXP arrives as one number from the server (`Reborn:Dispatcher.cs:292-300`, `CharacterDataClass.cs:1292-1295`), so range, party rules and which maps count are server-side. |
| Penguin **Focus Intellect** with **Double / Triple Cast** | Buff (bug fix) | The Focus factor is unchanged (`×(1 + 0.01 × floor(MAG − 100))`). BB bug: Falling Stars / Comets (and the Giant versions) read a shared damage field when each star lands 0.6 s later, and the multiCast repeat recomputes that field without Focus, so the first cast lost its Focus bonus (`BB:Penguin.cs:25554`, `:26421`, `:25836`, `:26813`, `:25246`). Reborn snapshots the damage per star at spawn (`Reborn:Penguin.cs:2867`, `:2896`, `:3209`, `:6669`, `:6774`) and caches the Focus bonus per command (`getFocusBonus`, `:11046-11068`); every multiCast repeat clears the cache, so the 2nd and 3rd casts still get no Focus (`:14366` etc.). Other spells already read Focus per cast in BB. |
| Chameleon **Double Effect** (431) | Buff | The Reborn seal system (`RebornEffects.ProcOnHit`, not in BB) gets `nMult = hasSkill(431) ? 2 : 1` from Chameleon only (`Reborn:Chameleon.cs:10575`, `:10581`; from the Combo / Clear Arrow hit, `Chameleon_nAttack.cs:225`): seal chance `lckItemAdjust(nMult × chance)` and duration `nMult × getDebuff(…)` (`Reborn:RebornEffects.cs:256`, `:259`); drain seals (hp/mp/sp/ko drain and sap) double only the chance, not the amount (`:258-260`, `:308-330`). The seal values come from a server table (`CharacterDataClass.cs:1767`). |
| Chameleon **Clear Arrow** (263) | Buff (less aggro) | `RebornClearArrow.SilentHit` is set around the arrow's `hit()` (`Reborn:Chameleon_nAttack.cs:211-220`) and `RPC_AddDamage` then forces hate 0 (`Reborn:CharacterControl.cs:7832-7835`, effect path `:7927-7931`). That 0 replaces the whole hate of the hit, KO part included: `nHate = damage + nHate + nKo × 10` is built first (`:7345`, the arrow's KO is 1, `Reborn:Chameleon_nAttack.cs:215`), and the `AddDamage` coroutine only passes that value on (`addHate`, 20% to allies within 24 m, `:635`, `:652`); the KO itself still lands (checked 2026-10-26). BB: hate `dmg + 10` per arrow like a normal arrow (`BB:Chameleon_nAttack.cs:688`, `BB:CharacterControl.cs:3771`). Poison Arrow and weapon / seal effects still make hate (they run after the flag is reset). |
| Bat **Mimic** | Nerf | A target with a `RebornZoneBoss` component is refused with "Cannot mimic that target!" and a refund (`Reborn:Bat.cs:14691-14695`, `:5900`, `:5937-5939`). That component exists only on tiered spawns with boss skills, not escorts (`Reborn:RebornZoneTier.cs:286-303`; tier 1 = mini-boss, 2+ = boss, `RebornSpawnTool.cs:830-841`): the W-field maps and the Wave Arena (`M996_WaveArena.cs:475`). Ordinary dungeon and mission bosses can still be mimicked. Cooldown, duration and level caps unchanged. |

Not traced (not skills): the boss tier / HP / 20 s cooldown change of 7.1.

### 7.4 Unannounced changes to original skills, found by diffing skill data and tooltips (2026-10-25)

Every class's `<Class>Skill.cs` (setReq / setMPSP / mode / target / rSkill) and `<Class>Skill_eng.cs` were compared between the builds (string helpers decoded). Real differences, each then traced in code:

| Skill | Verdict | What the code does |
|---|---|---|
| Sheep **Bless** / **Illuminate** with Gospel (412) / Blinding Light (413) | Nerf on cost | `SkillData.rbShpPartyBuff` (`Reborn:SkillData.cs:142-152`, run for every skill at `:106`) makes the skill `instant` and its MP `ceil(1.5 × MP)`. The Reborn tooltips of Gospel / Blinding Light say the party cast reaches allies "within 12m around Sheep"; the code uses `AlliesWholeMap` (`Reborn:Sheep.cs:1831`), so the tooltip is out of date. |
| Mole **War Capital** | Nerf (audited 2026-10-25: code, prefab and global systems) | Cost MP 100 → **250**, SP 50 → **100**, a full default bar (`BB:MoleSkill.cs:1592`, `Reborn:MoleSkill.cs:506`); new 30-minute lifetime (`RebornLifeSeconds = 1800`, the base sets its HP to 0, `Reborn:Mole_warCapital.cs:175`, `:181`, `:198-207`); the 300 s cooldown the Mole starts with now also applies in the new combat zones (`RebornZone.CombatMap` = game type above 4, or type 3 on maps 58-69; `BB:Mole.cs:109-121`, `Reborn:Mole.cs:11622-11627`, `RebornZone.cs:28-38`). Skill tree: War Capital (444) is now required for Giga Drill (454) and so Total War (464). Identical: cast and cooldown formulas, fire loop (12 / 6 / 24 s, radius 36, height 10, 8 missiles 0.25 s apart), `talAdjust(50)` KO 3 1 m blast, the missile prefab (life 12 s, 12 m/s), Advance Repair's reset and repair, and the base prefab (`WarCapital`, Lv 85, Structure, HP 1500, all stats 150, collision capsule r 1 h 3; decoded from `resources.assets` in both builds and `reborn_manifest/C08_MoleAsset.txt:2857-2949`). Indirect, not War Capital's own: uncapped player TAL / MAG raise missile power past 562 and drop the 8 s cast floor; Reactor Core (461) heat counts its missile hits; PK zones, safe areas, gear effects and world-space hitboxes. Files: `Mole_warCapital.cs`, `Mole_warMissile.cs`, `Mole.cs`, `MoleSkill*.cs` (`RebornMoleTurret.cs` only borrows its sound and icon). |
| Cat **Finishing Blow** | Buff (small: an extra option, nothing lost) | Target `enemy` → `all` (`Reborn:CatSkill.cs:361-369`), so the GUI no longer refuses an ally (`Reborn:GameGui.cs:1294-1296`). The cast still needs a KO target (`Reborn:Cat.cs:13770-13792`): on a knocked-down ally the Cat teleports to it, starts the cooldown, and its hits use the enemy mask (`:7300-7304`), so the ally takes nothing and enemies on that spot are hit. Damage (799 × 3 + 199, KO 0), timing and Open Wound unchanged. Tooltips still say "enemy". |
| Panda **Heaven Breath** (443) | Rework | BB: Sacred Sage heal `50 + 50·sLv + 2·Lv` HP and `floor(0.1·Lv)` MP, SP Transfer `+floor(0.25·Lv)` (`BB:Panda.cs:9377`, `:36329`). Reborn: TAL +10 and current SP +10 on learning (`Reborn:CharacterControl.cs:12120-12124`; the TAL is not written into the stored stats by client code, `CharacterDataClass.cs:1447-1471`, so whether it persists is server-side), max SP +10 (`RebornBalance.cs:573-580`), SP cap 140 (`:559-571`); Sage-line hits (actions 300-372) take `max(1, ceil(TAL/100))` SP from the target and the Panda gains the full amount (`CharacterControl.cs:7291-7310`); Sacred Sage heal `(50 + 50·sLv) × (1 + (TAL + LCK roll)/140)`, no MP (`Panda.cs:15641-15657`); Shadow Fist ×2 vs a 0-SP target and an HP leech of 100% of its damage at full SP (`Panda.cs:6754-6766`). Also for every Panda: Sacred Sage now fires at `sp >= rbSpMax` (BB `sp > 100`, `Panda.cs:1380`), and every Panda skill hit gives +1 SP (`CharacterControl.cs:7293`). |
| Panda **SP Transfer** → **Sage Mind** | Rework | Both ranks are passive with no cost (`Reborn:PandaSkill.cs:213-225`), renamed `sageMind1/2` (`SkillData.cs:179-180`): TAL +5 per rank, +10 total, on learning (`CharacterControl.cs:12116-12119`), with the same not-stored caveat as Heaven Breath. BB: give an ally `15 × rank` SP, cooldown `agiAdjust(30)`. |

Parser artifacts ignored: Twin Resonance, Calamity Hammer, Raijin Ken, Grand Tide, Support Fire, Thunder Dragon, Summon Gaos, World Encarta, Cosmic Friday, Black Servant and New Order look different only because the obfuscated BB file runs into the next skill; their data is identical. This diff cannot see a formula change with an unchanged tooltip; that needs a per-skill code diff.

The section 7.2 rows about the new C6 / C7 skills have not been compared with the code (the original-skill rows are in 7.3). Each can be: find the skill in `Reborn:<Class>.cs` and its companion files and compare with the original (`BB:`).

## 8. Open questions (read, not traced)

1. **Constants that are inlined:** `LuckOnItemEffects`, `PandaShadowFistDrySpMultiplier = 2`, `PandaShadowFistLeechPercent = 100`, `PandaSpTransferTalPerLevel = 5`, `PandaSkillHitSp = 1` (action code 349), `PandaSageSpDrainEnabled = false`, `PandaHeavenBreathTal/Sp = 10`. Their exact effects need a trace of the literal values in `Panda.cs` and `CharacterControl.cs`.
2. ~~**`RebornEffects`:** where its entries come from.~~ Answered in 3.4: a server table (character-data key 210, `/admin/effects`); only its rules are in the client.
3. ~~**Which item procs use `lckItemAdjust`.**~~ Answered: every built-in `onNormalAttackHit` weapon / hat proc of the 12 classes, every seal roll and the equipment resist (sections 2.2, 3.4).
4. **`ItemClass.att[1]`:** why red-star scaling skips it (which stat it is).
5. **Whether the original has a pierce `defAdjust` overload.** (The original has no `talHealAdjust`: answered in 2.6.)
6. **Rebalanced skills in other classes:** only Panda constants were seen in code. The Discord channels were read (section 7): they name about 15 skills but give almost no numbers. Each named skill still needs a code comparison with the original (section 7.2), and the unnamed rebalances are only findable by a skill-by-skill diff.
7. ~~**Skill 462** (Panda): name.~~ Answered: Spirit Overflow (section 5.1).
8. **New content:** the `*_C6` / `RebornC6` / `RebornC7` systems, the Zr classes, missions M994-M996, battle pass, guild war, mercenaries.

9. **Rabbit charge release outside Combat zones:** Reborn only takes the hitting `cAttack2` path `if (RebornZone.Combat && ...)` (`Reborn:Rabbit.cs:15484`); BB has no such condition. Which zones count as `RebornZone.Combat` is not traced.
10. ~~**Where the Bible shows a Reborn-only reach change:**~~ Answered 2026-10-26: a card's `servers.reborn.reach` with a Reborn dep in `reachControls` (the range popup's server buttons draw it), first used for Eagle Eye, Tidal Reach and Charged Fang. (Item 9 is a zone gate: the user counts the open world as missions, so it is not a card change.)
## 9. Skill simulator on the Reborn website (read 2026-10-25, for the class guide editor)

Source: `https://www.12tails-reborn.com/skills` (Next.js; its page script `/_next/static/chunks/app/skills/page-*.js`, rules in the module exported there, data in `/skills/data/<race>.json`, public static files). The site says its conditions and points per level are the ones the game uses. Race codes: wlf bsn pnd whl cat chm mol rab mnk shp pgn bat. Level range **1-150**.

**Point pools (the site's `IE` and `GK`):**
- Normal pool (Basic + A + B tabs) = `max(0, min(lv, 50) - 1) + (lv >= 60 ? min(floor((lv - 60) / 10) + 1, 10) : 0)`: 49 at Lv 50, then +1 at 60, 70, ... 150, so 59 at Lv 150.
- C pool (tab 4, ids 4xx, including the new 45x / 46x) = `max(0, min(lv >= 55 ? floor((lv - 55) / 5) + 1 : 0, 80 - normalPool(lv)))`: +1 at 55, 60, ... (20 at Lv 150), capped so the two pools together never pass 80.

**Learn rules** (same as BB plus the composite requirement): Lv >= `lv`; at least `bn` skills already learned in the same tab (`floor(id / 100)`); `rq` is 0, one skill id (< 999), or two ids packed as `a * 1000 + b` (> 99999, both needed); a non-first rank (`id % 10 != 1`, id < 400) needs `id - 1`. Removing a skill also removes everything that no longer qualifies.

**Grid vs BB (compared cell by cell against the Bible's `SKILL_SIM`, all 12 classes):** identical Lv / bn / rq everywhere (names aside: Rabbit 341-344 are `rab_truceTrading&Co1`-`4` on Reborn, Mall is gone, in the site data and in `Reborn:RabbitSkill.cs` getSkillTree alike; the simulator patches their names and icons, `SKILL_SIM_SERVERS.reborn.patch.rabbit`, 2026-10-26) except (a) Panda Heaven Breath (443) needs 344 (the same patch as ToT and TTO), and (b) **8 new C-tab skills per class**, ids 451-454 (Lv 95, bn 8) and 461-464 (Lv 105, bn 8), all drawing from the C pool. Their `rq`: 451 = 401 + 411, 452 = 254, 453 = 354, 454 = 444; 461 = 122 + 421 (Cat 123 + 421, Mole 124 + 421, Bat 123 + 421, Monkey/Sheep/Penguin 124 + 421), 462 = 264, 463 = 364 (Whale and Bat 363, Chameleon 263 for 462), 464 = 454. Per-class names and modes are in the JSON (`n`, `md`, `ic`; mp / sp / cd are filled for the active ones, e.g. Wolf Alpha Howl 454: mp 50, sp -60). The new ids reuse the slots ToT uses for its EX skills.

The raw JSON of the 12 races was kept in the session scratch folder; re-fetch from the URL above when implementing `SKILL_SIM_SERVERS.reborn`.
