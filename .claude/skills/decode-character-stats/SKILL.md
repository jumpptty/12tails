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

2. **Find the right binary file first, don't brute-force every file.** `12TailsOnline_Data/` has
   `resources.assets`, `level0..level200+`, and 270+ `sharedassets*.assets` — running the decoder
   against all of them is slow. Instead grep for the raw ASCII name across the whole data dir to
   shortlist candidates before decoding:
   ```
   grep -rl --include="*.assets" -a "Gadina1" 12TailsOnline_Data/
   ```
   This can return more than one candidate file (e.g. `resources.assets` AND `sharedassets17.assets`
   both contained the literal string "Gadina1" for one real search) — a name substring appearing in
   a file is not proof that file holds a *valid* decode at that offset (could be an unrelated string,
   a UI/quest-text reference, etc.), so still run the decoder against each candidate and trust only
   the one(s) that pass validation. Do not use `RippedAssets/ExportedProject` (YAML text export, no
   stat fields present at all — confirmed by grepping an exported `.prefab` for `hp:`/`atk:`/etc.,
   which comes up empty; only Unity's built-in `CharacterController` physics component shows there,
   never the game's own `CharacterControl` script fields).

3. **Run the decoder**:
   ```
   powershell -File .claude\skills\decode-character-stats\scripts\decode_stats.ps1 -AssetPath <path-to-.assets-or-level-file> -Names Wolf,Bison,FrostTower
   ```
   Omit `-Names` to dump every valid decode found in the file (slower, useful for building a
   full ranking). The script implements the validation from step 4 below and dedupes cosmetic
   variant prefabs (e.g. `CoralBug2`, `GuardTower_i`) that share one underlying serialized
   `Name`/byte offset with the base unit.

   **Invoking from a non-native PowerShell caller (e.g. Git Bash's `Bash` tool, not the `PowerShell`
   tool):** `-Names Gadina1,Gadina2,Gadina3,Gadina4` gets passed through as ONE literal string
   (`"Gadina1,Gadina2,Gadina3,Gadina4"`) instead of a 4-element array — PowerShell only tokenizes
   comma-separated array literals when its own parser reads the command line, and an external
   process handing over pre-split argv bypasses that. Symptom: the warning says `tried:
   Gadina1,Gadina2,Gadina3,Gadina4, Gadina1,Gadina2,Gadina3,Gadina` (the whole blob treated as one
   name, with only its trailing digit stripped as if it were a single variant suffix), and 0 rows
   even though the data is really there. Fix: invoke once per name (a shell loop is fine), or call
   through `powershell -Command "& { ...script... -Names @('a','b','c') }"` so PowerShell's own
   parser builds the array before binding it.

   **Seeing every field, not just the truncated console table:** the script's last line pipes to
   `Format-Table -AutoSize`, which drops columns that don't fit the terminal width (19 stat fields
   won't fit) — piping the script's own output through `Format-List` or `Select-Object *`
   afterwards does nothing, since the table is already rendered to text inside the script before
   your pipe attaches. Simplest fix: once you have a validated hit's `ByteOffset` from the
   truncated table, re-decode directly at that offset in a throwaway scratch script (read the
   name/type length-prefixed strings the same way `Try-DecodeAt` does to find `statsOff`, then
   loop the 19 `$FieldNames` printing each with `Write-Host`) rather than trying to reformat the
   shipped script's output.

4. **Never trust a single hit without validation** — a raw byte scan finds coincidental
   matches (a name substring inside unrelated binary data). The script already rejects:
   - `Name`/`Type` byte ranges that aren't all-printable-ASCII (0x20–0x7E)
   - any of the 18 non-`Lv` stat fields exceeding ~500,000 (real values top out in the low
     thousands; boss-tier `mp`/`hp` pools reach tens of thousands at most)
   - `Lv > 999` or `Race > 20`

   **Fallback: the target string may be the `Type` field, not the `Name` field.** The decoder's
   default search treats every hit of your search string as the start of the `Name` string. If that
   comes back empty (`Find-Decodes` finds zero raw occurrences, or every occurrence fails the
   following `Type`-string printability check), the string you're searching for may actually be the
   **`Type`** value, with a different, more descriptive `Name` in front of it. Worked example —
   Monkey's **Ja** summon: searching for `Ja1` directly found only 2 raw occurrences in
   `resources.assets`, and both failed validation (the bytes right after them weren't a valid
   printable `Type` string) — because `Ja1` *is* the `Type`, and the real record's `Name` is `"Little
   Ja"` (ranks 2-4 are `"Medium Ja"`/`"Big Ja"`/`"Giant Ja"`, mirroring the "lesser/medium/large/great"
   phrasing pattern already seen in that unit's in-game tooltip — a naming-convention match like this
   is itself a good corroborating signal). To search in this direction: for each raw occurrence of
   your string, treat `idx - 4` as `typeOff` (read its `Read-Int32` length, confirm it equals your
   string's length), then scan a small window *backward* from `typeOff - 4` for plausible `Name`
   length-prefixes (try each candidate `nameLen` from 1..40, compute `namePad =
   ceil(nameLen/4)*4`, check whether `nameOff = typeOff - 4 - namePad` holds a stored length equal to
   `nameLen` with a printable string after it). This is exactly the reverse of the decoder's normal
   forward search and isn't built into `decode_stats.ps1` — do it as a one-off scratch script when
   the normal `-Names` search comes up empty on a name you know is really used as a `Resources.Load`
   prefab path (check the summon's own `<Class>.cs` for the exact path/`Type` string first, e.g.
   `Resources.Load("GameAssets/Characters/Elementals/Ja/Ja1", ...)`, so you know what to search for
   in the first place — don't guess).

   Symptom of a bad decode that slipped through: absurd values like `1701736302`,
   `1084227584`, `1073741824` — these are ASCII text bytes misread as int32, always in the
   ~1–2 billion range, unmistakable once seen. Sanity-check any new target's whole row shape
   against a known-good reference, e.g. `FrostTower`: Lv 50, mhp 300, atk 300, def 30, agi 60,
   vit 60, mag 60, cha 300, tal 60, lck 60.

   **For a player summon/pet (not a wild monster), cross-check against source before trusting any
   field** — its own `<Summon>.cs` may explicitly overwrite some stats at spawn/equip time (e.g. via
   an `EquipSword`/`EquipShield`-style function), which makes the *baked prefab's* value for exactly
   those fields meaningless leftover data, while fields the code never touches are the real baseline.
   Worked example — Monkey's **Gadina** summon (`Gadina.cs`): source already proved ATK/DEF are set
   at runtime to `10/20/30/40` by evolution form (`EquipSword`/`EquipShield`), and MHP is always
   `10×VIT` computed live. The decode for `Gadina1..4` came back `atk` flat at `10` for all 4 ranks
   and `def` as `100/10/10/100` — neither matches the known 10/20/30/40 progression, confirming those
   fields (plus `hp`/`mhp`) are dead placeholder data, not bugs in the decode. But `agi/vit/mag/cha/
   tal/lck` — fields `Gadina.cs` never initializes anywhere, only ever adds *deltas* onto — came back
   perfectly clean and internally consistent: all 6 stats equal within each rank, `15/30/50/75` for
   ranks 1-4. That number was independently cross-confirmed two ways: it matches `mhp=10×vit` against
   the Thai client tooltip's stated HP (150/300/500/750), and it's the same value across all 6
   unrelated stat slots rather than noise — two independent signals landing on one answer is what
   makes a decode trustworthy, not just "a name string matched somewhere."

## Toolchain

PowerShell only (`scripts/decode_stats.ps1`, byte-level decode) — field order comes straight
from grepping `CharacterControl.cs` in this repo, no DLL decompilation step needed here.
`Race = 6` means Structure (confirmed against `AncientBug`/tower units).
