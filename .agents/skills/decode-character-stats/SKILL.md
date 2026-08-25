---
name: decode-character-stats
description: Use when a monster/structure/unit's base stats (hp, atk, def, agi, vit, mag, cha, tal, lck, ...) are needed but aren't reliable in the decompiled source — they're serialized CharacterControl fields baked into the live game's binary .assets/level files and must be hex-decoded directly.
---

# Decode Character Stats

## Why this exists

For most enemies/structures, `<Unit>.cs` in `DecompiledSource/` only sets placeholder stats (e.g. `hp = 1`) and there is no `MonsterData.cs`/`EnemyData.cs` table anywhere in the decompiled tree. The real base stats are plain public fields on `CharacterControl`, serialized into the Unity prefab baked inside the game's binary `.assets`/`level*` files (`12TailsOnline_Data/`). They are **not** visible in an AssetRipper YAML `ExportedProject` export. You have to hex-decode the raw binary directly.

## Procedure

1. **Reconfirm the field order against `CharacterControl.cs` in `DecompiledSource/`** (verified against `CharacterControl.cs` around line ~29675+):
   `Name(str), Type(str), Lv, Skin, Race, hp, sp, mp, ko, mhp, msp, mmp, mko, atk, def, agi, vit, mag, cha, tal, lck, weight, runSpeed(float)...`
   The 8 main stats are `atk, def, agi, vit, mag, cha, tal, lck` (8 consecutive int32s).

2. **Find the right binary file:** `12TailsOnline_Data/` at the repo root (containing `resources.assets`, `level0`, `level1`, ... `sharedassets*.assets`).

3. **Run the decoder:**
   ```powershell
   powershell -File .agents\skills\decode-character-stats\scripts\decode_stats.ps1 -AssetPath <path-to-.assets-or-level-file> -Names Wolf,Bison,FrostTower
   ```
