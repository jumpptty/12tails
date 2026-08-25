---
name: decode-character-stats
description: Use when a monster/structure/unit's base stats (hp, atk, def, agi, vit, mag, cha, tal, lck, ...) are needed but aren't reliable in the decompiled source — they're serialized CharacterControl fields baked into the live game's binary .assets/level files and must be hex-decoded directly.
---

# Decode Character Stats

## Why this exists

For most enemies/structures, `<Unit>.cs` in `DecompiledSource/` only sets placeholder stats (e.g.
`hp = 1`) and there is no `MonsterData.cs`/`EnemyData.cs` table anywhere in the decompiled
tree (see this repo's `CLAUDE.md`). The real base stats are plain public fields on
`CharacterControl`, serialized into the Unity prefab baked inside the game's binary
`.assets`/`level*` files (`12TailsOnline_Data/`). They are **not** visible in an AssetRipper
YAML `ExportedProject` export — that text exporter only resolves `[SerializeField]`-style
fields, and these are plain public fields, so the exported `MonoBehaviour` blocks come out
empty. You have to hex-decode the raw binary directly.

## Procedure

1. **Reconfirm the field order against `CharacterControl.cs` in `DecompiledSource/`** — it can
   drift between builds, and trusting a stale order silently produces plausible-but-wrong
   numbers (e.g. `def` read as `atk`). Grep that file for
   `public (int|string|eRace|Texture|float) (Name|Type|Lv|Skin|Race|hp|sp|mp|ko|mhp|msp|mmp|mko|atk|def|agi|vit|mag|cha|tal|lck|weight|runSpeed)` and
   read the declarations in order — no external DLL/`ilspycmd` needed here, the field order
   is plain text in this repo. Verified 2026-08-12 against this repo's `CharacterControl.cs`
   (~line 29675 on): `Name(str), Type(str), Lv, Skin, Race, hp, sp, mp, ko, mhp, msp, mmp,
   mko, atk, def, agi, vit, mag, cha, tal, lck, weight, runSpeed(float), weapon(str)...` — the
   8 main stats are `atk, def, agi, vit, mag, cha, tal, lck` (8 consecutive int32s). Note: the
   source also declares a `Texture mTargetAvartar` field between `Race` and `hp`, but it
   consumes **zero** serialized bytes — don't add a gap for it (confirmed by hex-dump: `hp`
   starts exactly 4 bytes after `Race`). If the order has changed from the above, update
   `scripts/decode_stats.ps1`'s `$FieldNames` array to match before trusting output.

2. **Find the right binary file.** `12TailsOnline_Data/` at the repo root (containing
   `resources.assets`, `level0`, `level1`, ... `sharedassets*.assets`). Do not use
   `RippedAssets/ExportedProject` (YAML text export, no stat fields present at all).

3. **Run the decoder**:
   ```
   powershell -File .claude\skills\decode-character-stats\scripts\decode_stats.ps1 -AssetPath <path-to-.assets-or-level-file> -Names Wolf,Bison,FrostTower
   ```
   Omit `-Names` to dump every valid decode found in the file (slower, useful for building a
   full ranking). The script implements the validation from step 4 below and dedupes cosmetic
   variant prefabs (e.g. `CoralBug2`, `GuardTower_i`) that share one underlying serialized
   `Name`/byte offset with the base unit.

4. **Never trust a single hit without validation** — a raw byte scan finds coincidental
   matches (a name substring inside unrelated binary data). The script already rejects:
   - `Name`/`Type` byte ranges that aren't all-printable-ASCII (0x20–0x7E)
   - any of the 18 non-`Lv` stat fields exceeding ~500,000 (real values top out in the low
     thousands; boss-tier `mp`/`hp` pools reach tens of thousands at most)
   - `Lv > 999` or `Race > 20`

   Symptom of a bad decode that slipped through: absurd values like `1701736302`,
   `1084227584`, `1073741824` — these are ASCII text bytes misread as int32, always in the
   ~1–2 billion range, unmistakable once seen. Sanity-check any new target's whole row shape
   against a known-good reference, e.g. `FrostTower`: Lv 50, mhp 300, atk 300, def 30, agi 60,
   vit 60, mag 60, cha 300, tal 60, lck 60.

## Toolchain

PowerShell only (`scripts/decode_stats.ps1`, byte-level decode) — field order comes straight
from grepping `CharacterControl.cs` in this repo, no DLL decompilation step needed here.
`Race = 6` means Structure (confirmed against `AncientBug`/tower units).
