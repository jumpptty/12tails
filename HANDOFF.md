# Handoff (updated on the home PC, 18/11/2026)

Read this after `git pull`. Delete items as they get done, and delete the file when it is empty.

Done on 18/11/2026 (home PC): the four upscales, the numeral-free art for 612 of 616 card icons (373 painted out), the TTO 1.7.0 cards merged with both re-reviews, the critic's gaps, the Sheep open points and the `tto-1.7.0` patch pop-up. Inputs and redo recipe for the art: `D:\12tails-assets-archive\class-gate-upscale-2026-11-18\README.md` (home PC).

## Bring to the office PC

- `DecompiledSource_TTO_2026-11-18/BUILD.md` there still says the Drug / Potion / Flag cooldown is "not in the client". The home copy is corrected; copy its last "Engine" bullets over, or fix the line by hand.

## Watch

- **Skill view counts:** they started on 18/11/2026. GoatCounter's free plan has a monthly cap, so check the dashboard's monthly hits after a week (about 25/11/2026). Each skill counts once per browser session.

## Open decisions (the user's call; nothing is broken without them)

- **Bat Mass Cast, BB side:** BB skips the clicked target when more than 6 enemies stand around it (`Bat.cs:25376` takes the first 6 alive in `FindAreaTarget` order), which TTO 1.7.0 fixed. Add a `bbBug` to the BB card and a row on the BB issues page?
- **Cat Swift Pace, BB side:** BB has no wall or height check (`Cat.cs:6557-6600`), so it warps through thin walls; TTO now blocks that. Count it as a BB bug (`bbBug`) or leave BB as is?
- **Penguin Ice Block (TTO 1.7.0):** characters standing where a block spawns now pass through it. How BB behaved there depends on prefab physics, not code, so only a live check settles whether the pop-up line should also carry "bug".
- **Potion cooldown row:** no TTO page shows potion or flag cooldowns. Add a `COMMON_SERVER_NOTES.tto` row like Reborn's potion row?
- **Guild pet statuses:** status-glossary / Special Pet Info entries for `pandoraStrike` (9119), `resistSleep`..`resistAcid` (9102-9116), `hpUp` / `mpUp` / `mkoUp` (9117, 9118, 9101)? Their values come from the server.
- **Panda Wind & Cloud / Rain & Storm:** a TTO desc line for the auto-aim fix ("• เปิด **Auto Skill** และเลือกเป้าไว้ จะหันไปทางเป้าก่อนออกท่า"), or keep it in the pop-up only (the Whale aim-option precedent)?
- **Not settled offline:** the 7v7 tower damage line (`GuardTower` code changed, not traced), what `RPC_mimic_over` does (no receiver in the client), the War Capital "lock target" claim (no War Capital method changed), the Mole / Bison 6-7 emote (animation bundles are on the CDN).
