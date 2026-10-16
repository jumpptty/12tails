# ไกด์อาชีพจากชุมชน

The **ไกด์อาชีพ** tool replaces the Skill Simulator menu entry. Its existing `#skill-simulator` link remains valid. All twelve class grids, three servers, normal/C/EX point rules and original skill frames are reused.

## For guide authors

1. Open ไกด์อาชีพ and choose **สร้างไกด์** (Create guide).
2. Fill in the guide title, author name, the **date** you wrote the guide (typed as วัน/เดือน/ปี, e.g. 16/10/2026, or picked from the calendar icon) (required; it replaces the old free-text game patch) and the build description. To emphasise text, press **ไฮไลต์** in the editor toolbar so it lights up, then drag the mouse (or a finger) across the characters you want: they turn bold gold, and a space is added before and after them when they touch other text. Dragging across text that is already bold turns it back. Press **ไฮไลต์** again to stop. Formatting is stored as `**text**` in the code and shown in previews and published guides. Pasted text is kept as plain text; Ctrl+Z inside the editor undoes text edits.
3. Choose the server, class and level, then build using the existing skill grid. Normal learning and undo remain available in **จัดบิลด์** mode.
4. Optionally fill **สเตตัสแนะนำ** (recommended stats): any of ATK, DEF, TAL, AGI, VIT, CHA, INT, LCK, whole numbers 0-512. A blank field is not stored and not shown to readers. AGI, INT and CHA (with LCK) also drive the hover timings in the reader view.
   Both sit behind the **สเตตัสและอุปกรณ์แนะนำ** button (folded for a new guide, open when the draft already has some). Optionally fill **อุปกรณ์แนะนำ** (recommended gear): for weapon, armor, hat, trinket, boot and pet, up to three ranked picks (1st, 2nd, 3rd). Each pick opens a searchable list of the game items your class can use (with their in-game icons, in game order); a new item not in the list can be typed instead. Weapon, armor and hat picks can also name the item they are a **Replica** of and one stat to put in (**ยัด**, e.g. ยัด INT). Only the item matters: no item stats are shown, since those get rebalanced.
5. Choose **เขียนโน้ตสกิล ★**, then click a skill to explain your choice. Notes can explain either selected or skipped skills. Save an empty note to remove its star. Each rank/cell has its own note.
6. Choose **ดูตัวอย่าง** to check the locked reader view, then **กลับไปแก้ไกด์** to resume your draft. **บันทึกเป็นรูป** saves the guide as a picture (see Reader interactions).
7. Choose **คัดลอกโค้ดไกด์** (copy icon) to copy the guide code to the clipboard, then send it to the site maintainer. The code is short: `TG2.` followed by the guide as compact binary (one bit per skill slot, Thai text at one byte per character), compressed when that helps, in URL-safe base64, usually around 150-250 characters. Choose **นำเข้าโค้ด**, paste a code (`TG2.`, an older `12TG1.` code, or an old JSON code) into the small text box and press Enter to resume editing. An old code that has a patch but no date opens fine; export then asks for the date.

The draft is saved only in the author's current browser. Export the code to keep a portable copy. Creating a guide from the reader view starts an independent empty build or resumes the author's own draft; it does not edit an embedded expert guide.

## For the maintainer: embed submitted guides

Locate `const CLASS_GUIDES = [...]` in [index.html](index.html). Submissions arrive as short codes: turn each into its JSON object with `node scripts/guide_code.js decode <code>` (it also accepts a file path, and `encode <json file>` goes the other way), then add the **JSON objects** to the array, separated by commas:

```js
const CLASS_GUIDES = [
  // Paste the first exported JSON object here.
  // Add a comma between objects, then paste the next exported JSON object.
];
```

Paste the object itself, not a quoted JSON string, and do not include an outer array from another source. The guide's skill icons already live in the HTML; no image files need to accompany submissions. The tool remains a single offline HTML file.

**Every embedded guide needs a running number `"id"`** (a positive integer: 1, 2, 3 ... in the order guides were added; unique, never reused, never renumbered), written first in the object, e.g. `{"id":3,"format":"12t-class-guide",...}`. It is not part of the portable format (the importer ignores it); it makes the link `index.html#skill-simulator/<number>`, which opens that guide straight in the reader view, and the address bar already holds that link (click the guide title in the reader to copy it as a Discord heading). The reader's **คัดลอกโค้ดไกด์** button copies the guide's portable code instead; pasting it into **นำเข้าโค้ด** in the editor makes an editable copy. Never change a number after it was shared (a removed guide leaves a gap); the validator fails on a missing or duplicate number.

Only real submitted guides belong in this array. The list contains user-submitted guides; do not invent experts or builds. Valid guides appear in the community list with title, class, server, author and date. Invalid entries are excluded and the page reports how many could not open. Imported author codes never add entries to this array automatically.

Before publishing, run `node scripts/validate_skills.js`. Every embedded entry must pass the schema and existing simulator allocation rules. Changes to `index.html` still need its usual backup/checkpoint and matching changelog entry.

## Portable format, version 1

```json
{
  "format": "12t-class-guide",
  "version": 1,
  "title": "Guide title",
  "author": "Author name",
  "date": "2026-10-16",
  "description": "Build description.\nMultiple lines are supported.",
  "build": {
    "server": "tot",
    "classKey": "wolf",
    "level": 100,
    "learned": [101, 102, 103, 451]
  },
  "stats": { "agi": 120, "int": 96, "cha": 60, "lck": 40 },
  "gear": { "weapon": [{ "item": "w_pgn10", "replica": { "item": "w_pgn11" }, "stat": "int" }, { "name": "Staff of Tomorrow" }], "pet": [{ "item": "p_lcr" }] },
  "notes": {
    "103": "Why this skill rank is selected.",
    "201": "Why this skill is skipped."
  }
}
```

* `stats` (optional): the author's recommended stats, any of `atk`, `def`, `tal`, `agi`, `vit`, `cha`, `int`, `lck`, each a whole number 0-512 (0 is a real value). Only filled stats are stored (fixed order), the key is left out when none is filled, and guides without it stay valid and export unchanged. An unknown key or a value outside 0-512 is rejected on import.
* `gear` (optional): `weapon`, `armor`, `hat`, `trinket`, `boot`, `pet`, each a list of 1-3 ranked picks. A pick is `{ "item": "<game id>" }` (from `GEAR_DATA`, read from WeaponData / ArmorData / AccessoryData / TrinketData / BootData / PetData; the item must be one the guide's class can use: its own, the shared `all` / `fem` / `mal` ones, every pet) or `{ "name": "<1-60 characters>" }` for an item not in the game data. Weapon / armor / hat picks may add `replica` (the item it is a Replica of, same two forms) and `stat` (one of the 8 stat keys). Empty slots are not stored. In the format 2 short code it is an optional block at the end, so codes without gear are unchanged.
* `server`: `og` (BB), `tot` or `tto`. `classKey`: lowercase class name.
* `learned`: unique numeric cell IDs, including every learned lower rank and prerequisite; export sorts them. Cell IDs use the existing tree/row/column scheme. ToT EX cells are legal only on ToT.
* `notes`: cell ID strings mapped to text with optional `**bold gold**` emphasis. A note may target an unselected skill, but never an unknown or unpublished placeholder cell.
* Required for export: title (up to 160 characters), author (120) and `date` (`YYYY-MM-DD`, a real calendar day from 2000 on). Description allows 12,000 characters; each note allows 3,000. The complete code allows 131,072 characters. Import never executes code or renders HTML from submissions.
* `date` is the day the author wrote the build; readers see it as `16 ต.ค. 2026`. It does not select historical mechanics; allocation validation uses the tool's current rules for that server. Update the rules and guide data together when a server changes requirements. A `patch` key from an old code is ignored.
* **Short code, format 2** (`TG2.`, what exports write): base64url of a flag byte (0 stored, 1 deflate-raw) + binary: server and class in one byte (class order rabbit mole bat bison cat chameleon monkey panda penguin sheep whale wolf; server og tot tto), level, the learned skills as 20 bytes (bit `(tree-1)*40 + row*4 + (col-1)`), the date as 2 bytes of days since 2000-01-01, a stats mask byte + 2 bytes per stat, then title, author, description and each note (slot byte + text) as length-prefixed text where ASCII and Thai (U+0E00-0E5B) take one byte and anything else is `0xDC` + its code point. The page (`classGuideBinary` / `classGuideFromBinary`, `classGuidePack` / `classGuideUnpack`) and `scripts/guide_code.js` write identical bytes; the validator checks it.
* **Short code, format 1** (`12TG1.`, earlier exports, still imported): the compact form `{t, a, d, x, s, c, l, k, v, n}` as minified JSON, deflate-raw, base64url (`node scripts/guide_code.js` decodes both; `encode1` writes it).

## Reader interactions

* **Title:** a row with the class icon, the server icon and `Lv.95`, then the guide name on its own line; under it the author in gold and the date.
* **Recommended stats:** one tile per stat the author filled, the stat name and a big number in the stat's colour. A reader can click a number and try another value: the hover timings follow at once, the tile gets a coloured edge, and **คืนค่าที่ผู้เขียนแนะนำ** brings the author's values back. Nothing a reader types is saved.
* **Recommended gear:** one row per slot (no slot label), the ranked picks as item icons; a typed item's name is drawn as its icon. The Replica's icon sits on the corner and the stat to put in shows as **ยัด** + the stat, in its colour. On phones the names show under the icons, on landscape screens they are the tooltip (compact rows, as in the PNG).
* **Hover:** a skill's name, then for a skill the author learned the timing lines (**คูลดาวน์** from AGI, **เวลาร่าย** from INT, the buff **ระยะเวลา** from CHA, each only if that stat is filled; LCK turns them into the same min-max range as skill-details). The numbers come from the skill's own card and rank on the guide's server, with the passives the build learned, and Revised Art (in the build) shortens cooldowns; debuffs and other contested durations, TAL-adjusted durations and summon-owned stats show nothing. Every skill with a card also shows **คลิกค้างเพื่อดูรายละเอียดเพิ่มเติม**: holding it for 0.5 s opens the skill card in a new tab (the builder and the author's note editor never do). Hover needs a mouse.
* **Author notes:** clicking a starred skill sends its star as a light ball into a new chip (skill icon, name, note) under the description (on phones under the build, and the page scrolls to it). The chip stays until the page reloads or another guide opens; clicking the skill again flashes its chip. There is no pop-up.
* **คัดลอกโค้ดไกด์** copies the guide's short code, so anyone can import it and edit their own copy. The address bar already holds the share link (click the guide title to copy it as a Discord heading).
* **บันทึกเป็นรูป** saves a 3840 x 2160 (16:9, 4K) PNG, the same on phone and desktop: the info column (icons and level, title, author and date, recommended stats, description) on the left, the four trees side by side, and every author note expanded as chips under the trees (a very long note is cut with "…", and notes that do not fit are counted). It is drawn in the current look (BB, ToT or TTO), with that look's backdrop and container surface. Phones with a share sheet share the file; everything else downloads it.
* **Landscape screens** lay the reader out like the exported PNG: the info panel on the left (23.5% of the width), the four skill trees filling the rest at equal height, and the author notes as two columns of chips under the trees. Every note's chip is placed (invisible) when the guide opens, so nothing moves when a star is clicked; the star still flies its light into the chip.
* **Phones:** the reader is a normal scrolling page (title, stats and description, then the build at its natural size in two columns of equal-height trees, then the note chips); the builder's server / class / level / points bar and the work-in-progress label are hidden in the reader.

Readers cannot change the level, server, class, skills or points, reset the build or undo it. Unread stars pulse subtly until clicked. The star pulse and note animation play even when reduced motion is enabled.

Exports keep the selected server in `build.server`. Import restores this tag instead of using the browser's current server selection.
