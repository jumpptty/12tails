# ไกด์อาชีพจากชุมชน

The **ไกด์อาชีพ** tool replaces the Skill Simulator menu entry. Its link is `#class-guide`; an old `#skill-simulator` link forwards there. All twelve class grids, three servers, normal/C/EX point rules and original skill frames are reused.

## For guide authors

Choosing **เขียนไกด์** asks how to start: **เริ่มไกด์ใหม่** (an empty build), **เขียนต่อ** (the draft saved in this browser; greyed out when there is none) or **นำเข้าโค้ดไกด์** (paste a code). The editor then walks through six numbered steps, one at a time (the skill grid shows beside the step in 3, 4 and 5, where the step decides what a click on it does; the other steps take the whole page): 1 ข้อมูลไกด์, 2 สเตตัสและเซ็ต (the stats and sets editors right in the panel), 3 จัดบิลด์, 4 โน้ตสกิล, 5 หน้าปกและตรวจ (cover icons, preview), 6 บันทึกและส่ง (save the guide as a PNG and / or copy the guide code and send it to jumpptty on Discord for the Bible's archive; it lists anything still missing, and a missing title, author or date sends you back to step 1). Steps 2 and 4 are optional (marked ไม่บังคับ on their tabs), a finished step shows ✓ on its tab, and the tabs move between steps; the step is remembered.

1. Open ไกด์อาชีพ and choose **เขียนไกด์** (Write a guide). The top row has two page tabs, **ไกด์จากผู้เล่น** and **เขียนไกด์**; the page you are on is gold. To start from an existing code, choose **นำเข้าโค้ดไกด์** at the top of the editor.
2. Fill in the guide title, author name, the **date** you wrote the guide (typed as วัน/เดือน/ปี, e.g. 16/10/2026, or picked from the calendar icon) (required; it replaces the old free-text game patch) and the build description. To emphasise text, press **ไฮไลต์** in the editor toolbar so it lights up, then drag the mouse (or a finger) across the characters you want: they turn bold gold, and a space is added before and after them when they touch other text. Dragging across text that is already bold turns it back. Press **ไฮไลต์** again to stop. Formatting is stored as `**text**` in the code and shown in previews and published guides. Pasted text is kept as plain text; Ctrl+Z inside the editor undoes text edits.
3. Choose the server, class and level, then build using the existing skill grid. Normal learning and undo (Ctrl+Z) remain available in **จัดบิลด์** mode; the **จัดบิลด์ / เขียนโน้ตสกิล** switch sits in the bar right above the trees.
4. Optionally fill **สเตตัสแนะนำ** (recommended stats): any of ATK, DEF, TAL, AGI, VIT, CHA, INT, LCK, whole numbers 0-512. A blank field is not stored and not shown to readers. AGI, INT and CHA (with LCK) also drive the hover timings in the reader view.
   Both sit in a dialog behind the **สเตตัสและเซ็ตแนะนำ** button (the button says what is filled in, e.g. สเตตัส 3, 2 เซ็ต). Optionally fill **เซ็ตแนะนำ** (recommended sets): up to three sets, each a weapon, armor, hat, trinket, boot and pet (set 1 = the first choice of every slot, set 2 the second, set 3 the third). Each pick opens a searchable list of the game items your class can use (with their in-game icons, in game order); a new item not in the list can be typed instead. Weapon, armor and hat picks can also name the item they are a **Replica** of and one stat to put in (**ยัด**, e.g. ยัด INT). Only the item matters: no item stats are shown, since those get rebalanced.
5. Choose **เขียนโน้ตสกิล ★**, then click a skill to explain your choice. The note box opens where the description was (the description comes back when it closes). Notes can explain either selected or skipped skills. **ลบโน้ต** (or saving an empty note) removes its star, and Ctrl+Z brings it back. Each rank/cell has its own note.
   Choose **ไอคอนหน้าปก** (cover icons, required: คัดลอกโค้ดไกด์ asks for at least one first; the row shows three numbered circles that fill as you pick, in the same switch above the trees, or the ไอคอนหน้าปก row under the description): click up to three skills in the order you want them; the grid numbers them 1-3, clicking one again removes it, **ล้าง** clears them and Ctrl+Z undoes. They are the guide's picture on its gallery card, in the reader's title row and in the PNG (the class portrait is no longer used): one icon is one big circle, two sit side by side, three form a triangle (the note-icon ring).
6. Under the description, the finishing buttons are **ดูตัวอย่าง** (exactly what a visitor will see; **กลับไปแก้ไกด์** in the top row brings you back), **บันทึกเป็นรูป** (saves the guide as a picture, see Reader interactions) and **คัดลอกโค้ดไกด์**.
7. Choose **คัดลอกโค้ดไกด์** (copy icon) to copy the guide code to the clipboard, then send it to the site maintainer. The code is short: `TG2.` followed by the guide as compact binary (one bit per skill slot, Thai text at one byte per character), compressed when that helps, in URL-safe base64, usually around 150-250 characters. Choose **นำเข้าโค้ดไกด์**, paste a code (`TG2.`, an older `12TG1.` code, or an old JSON code) into the small text box and press Enter to resume editing. An old code that has a patch but no date opens fine; export then asks for the date.

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

**Every embedded guide needs a running number `"id"`** (a positive integer: 1, 2, 3 ... in the order guides were added; unique, never reused, never renumbered), written first in the object, e.g. `{"id":3,"format":"12t-class-guide",...}`. It is not part of the portable format (the importer ignores it); it makes the link `index.html#class-guide/<number>`, which opens that guide straight in the reader view, and the address bar already holds that link (click the guide title in the reader to copy it as a Discord heading). The reader's **คัดลอกโค้ดไกด์** button copies the guide's portable code instead; pasting it into **นำเข้าโค้ด** in the editor makes an editable copy. Never change a number after it was shared (a removed guide leaves a gap); the validator fails on a missing or duplicate number.

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
* `cover` (required, user 2026-10-16; drafts may lack it): 1-3 cell ids of the guide's grid (not placeholders), in the author's order; drafts drop ids the class or server no longer has. In the format 2 code it is an optional block (`0x49`, count, one slot byte each).
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
* **เซ็ตแนะนำ (recommended sets):** one row per set, numbered once at the left, the slots in game order as columns (no slot labels; the item name is the tooltip); a typed item's name is drawn as its icon. A Replica is a small icon on the item's bottom-right corner with a curved arrow up into the item, and the stat to put in shows under the icon as **ยัด** + the stat, in its colour. The PNG draws the same rows.
* **Hover:** a skill's name, then for a skill the author learned the timing lines (**คูลดาวน์** from AGI, **เวลาร่าย** from INT, the buff **ระยะเวลา** from CHA, each only if that stat is filled; LCK turns them into the same min-max range as skill-details). The numbers come from the skill's own card and rank on the guide's server, with the passives the build learned, and Revised Art (in the build) shortens cooldowns; debuffs and other contested durations, TAL-adjusted durations and summon-owned stats show nothing. Every skill with a card also shows **คลิกค้างเพื่อดูรายละเอียดเพิ่มเติม**: holding it for 0.5 s opens the skill card in a new tab (the builder and the author's note editor never do). Hover needs a mouse.
* **Author notes:** every note is shown as a chip (skill icon, name, note) as soon as the guide opens, beside the build (on phones under it). The stars on the noted skills stay plain gold; clicking a starred skill scrolls to its chip and flashes it. There is no pop-up. Clicking a note's skill icon opens that skill's card in skill details in a new tab.
* **ใช้ไกด์นี้เป็นต้นแบบ** copies the guide into the reader's own editor as a draft to change (it replaced the old copy-the-code-then-import route). Like importing a code, it asks before it replaces a draft that already has content. The address bar already holds the share link (click the guide title to copy it as a Discord heading).
* **บันทึกเป็นรูป** saves a 3840 x 2160 (16:9, 4K) PNG, the same on phone and desktop, in the same layout as the landscape reader (user 2026-10-16: one format to learn): the info panel (icons and level, title, author and date, one row of stat tiles, the sets) top left, the four trees beside it, every author note as a chip in a full-height column on the right, and the description under the info and the trees, all as one centred rectangle. An image cannot page or scroll, so a description that does not fit ends with "…", a long note is cut to fewer lines, and notes that still do not fit are counted. It is drawn in the current look (BB, ToT or TTO), with that look's backdrop and container surface. Phones with a share sheet share the file; everything else downloads it.
* **Landscape screens** (user 2026-10-16 layout): the guide name, author, stats and sets in a panel at the top left (only as tall as its content), the skill grid next to it, the author notes in a full-height column on the right, and the description under both the panel and the grid. Everything outside the grid scales in proportion to the grid's skill icons, and the columns sit centred together. The panels fit together as one rectangle with small, even gaps; until a reader opens a note, the notes panel shows a hint to click a ★ skill. A long description is split into pages (‹ 1 / 3 › in its corner); many notes step their font and lines per note down, then the notes column scrolls (a note cut short shows its whole text on hover). Every note's chip is placed (invisible) when the guide opens, so nothing moves when a star is clicked. The exported PNG uses the same layout.
* **Phones:** the reader is a normal scrolling page (title, stats and description, then the build at its natural size in two columns of equal-height trees, then the note chips); the builder's server / class / level / points bar and the work-in-progress label are hidden in the reader.

Readers cannot change the level, server, class, skills or points, reset the build or undo it. Unread stars pulse subtly until clicked. The star pulse and note animation play even when reduced motion is enabled.

Exports keep the selected server in `build.server`. Import restores this tag instead of using the browser's current server selection.
