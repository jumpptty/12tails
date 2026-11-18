# Handoff (home PC → office PC, 18/11/2026 evening)

Read this after `git pull` (everything below is pushed; last commit `4b10ae6`). Delete items as they get done, and delete the file when it is empty.

## What changed today (all pushed, all documented)

- **TTO 1.7.0 finished:** the `tto170-cards` branch was re-reviewed, merged and deleted; the `tto-1.7.0` patch pop-up (37 lines) is live. Shared fix: `dmgAdjust` / `hitMod` round in float32 like the game (1.1 × 100 = 110, not 111).
- **Skill details landing, reworked many times at the user's direction.** The rules are in `.claude/skills/bible-skill-page-ui/SKILL.md` (Class gate, Halo cards, Grid, Fade-scroll grid, One-click presets); read those before touching this area. In short:
  - class gate: 6 + 7 rings, Common is the 13th ring (the ⊞ glyph);
  - roster: header and tabs on one row, card size and balanced rows by tab size, a fixed-height grid that scrolls inside and fades;
  - keys: Esc goes skill → class list → gate; A / D and the arrows switch tabs;
  - presets: five one-click numbers, and the face shows the preset's colour.
- **Icon art:** rank-0 art only where the game has it (276 icons), else the rank-1 icon; C skills keep their C. The painted-out numerals (inpainting) were tried and **rejected by the user**, so don't bring them back. Upscaled today: class faces, gate ring / hover, mount icons, Bat zombies (= greyed class faces).
- **Class guide:** TTO trinket **Bloom Pulse** (`t_all_tto_bloompulse`, TTO 1.7.0, exchanged at Pedo).

## Bring to the office PC

- **`DecompiledSource_TTO_2026-11-18/BUILD.md`:** the office copy still says the Drug / Potion / Flag 80 s cooldown is "not in the client". The flash drive copy (`H:\DecompiledSource_TTO_2026-11-18\BUILD.md`) is corrected; copy it over.
- **Home-only archives (not needed unless you rebuild the art):** `D:\12tails-assets-archive\class-gate-upscale-2026-11-18\` (the upscales, the rank-0 inputs for `scripts/build_skill_icons_r0.py --r0-dir`, the rejected inpaint set, old images and revert scripts) and `D:\12tails-assets-archive\tto-1.7.0-item-icons-2026-11-18\` (all 47 item icons new in 1.7.0).

## Waiting on the user

- **More TTO 1.7.0 items for the class guide:** the 47 new icons include more Loy Krathong trinkets (`alllkt1`, `alllkt3`, `mallkt1`), quiz trinkets (`allqiz1/2`), a Krathong accessory, the Krathong cart mount and materials. Names are server-side, so only Bloom Pulse is named. Add others the same way once the user names them.
- **TTO gear naming page:** `C:\Users\Jump\Desktop\TTO-Gear-Icons.html` (292 items from 7 Nov) was rebuilt on the home PC today. Its progress lives in each PC's browser; it does not cover the 1.7.0 items.

## Wardrobe (separate repo, not this session)

- The **6-7 emote** clips (`gameassets/characters/heroes/<cls>/animations/sixseven`) are in the updated TTO install's class bundles; the bundle names changed today. The wardrobe session `12tails-wardrobe-ae` (home PC) got the exact map and queued it after its **pet slot** work. On the office PC, redo the map from that PC's TTO install with `aa_catalog.py --grep sixseven`.

## Watch

- **Skill view counts:** they started on 18/11/2026. GoatCounter's free plan has a monthly cap, so check the dashboard's monthly hits after a week (about 25/11/2026).

## Open decisions (the user's call; nothing is broken without them)

- **Bat Mass Cast, BB side:** BB skips the clicked target with more than 6 enemies around it (`Bat.cs:25376`), which TTO 1.7.0 fixed. Add a `bbBug` to the BB card and a row on the BB issues page?
- **Cat Swift Pace, BB side:** BB has no wall or height check (`Cat.cs:6557-6600`); TTO now blocks warps through walls. Count it as a BB bug or leave BB as is?
- **Penguin Ice Block (TTO 1.7.0):** characters standing where a block spawns now pass through it. Whether BB behaved differently depends on prefab physics; only a live check settles the pop-up's "bug" tag.
- **Potion cooldown row:** add a `COMMON_SERVER_NOTES.tto` row like Reborn's potion row?
- **Guild pet statuses:** status-glossary / Special Pet Info entries for `pandoraStrike` (9119), `resistSleep`..`resistAcid` (9102-9116), `hpUp` / `mpUp` / `mkoUp` (9117, 9118, 9101)? Their values come from the server.
- **Panda Wind & Cloud / Rain & Storm:** a TTO desc line for the auto-aim fix, or keep it in the pop-up only?
- **Not settled offline:**
  - the 7v7 tower damage line (`GuardTower` code changed, not traced);
  - what `RPC_mimic_over` does;
  - the War Capital "lock target" claim.
  - The Mole / Bison 6-7 emote claim **can now be checked**: their `sixseven` clips are local since today's update, so diff them against the 14 Nov bundles.
