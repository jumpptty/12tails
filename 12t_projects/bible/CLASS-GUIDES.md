# ไกด์แต่ละอาชีพจากชุมชน

The **ไกด์แต่ละอาชีพ** tool replaces the Skill Simulator menu entry. Its existing `#skill-simulator` link remains valid. All twelve class grids, three servers, normal/C/EX point rules and original skill frames are reused.

## For guide authors

1. Open ไกด์แต่ละอาชีพ and choose **สร้างไกด์** (Create guide).
2. Fill in the guide title, author name, game patch/version and build description. Select text in the description or a skill note and press **Ctrl+B** (Cmd+B on Mac) to toggle bold gold emphasis. Bold gold appears immediately in the editor; the **ตัวหนาสีทอง** toolbar button does the same. Formatting is stored as `**text**` in the portable code and shown in previews and published guides. Pasted text is kept as plain text; Ctrl+Z inside the editor undoes text edits.
3. Choose the server, class and level, then build using the existing skill grid. Normal learning and undo remain available in **จัดบิลด์** mode.
4. Choose **เขียนโน้ตสกิล ★**, then click a skill to explain your choice. Notes can explain either selected or skipped skills. Save an empty note to remove its star. Each rank/cell has its own note.
5. Choose **ดูตัวอย่าง** to check the locked reader view, then **กลับไปแก้ไกด์** to resume your draft.
6. Choose **ส่งออกไกด์** (link icon) to copy the guide code directly to the clipboard, then send it to the site maintainer. Choose **นำเข้าโค้ด**, paste the code into the small text box and press Enter to resume editing.

The draft is saved only in the author's current browser. Export the code to keep a portable copy. Creating a guide from the reader view starts an independent empty build or resumes the author's own draft; it does not edit an embedded expert guide.

## For the maintainer: embed submitted guides

Locate `const CLASS_GUIDES = [];` in [index.html](index.html). Replace the empty array with exported **JSON objects**, separated by commas:

```js
const CLASS_GUIDES = [
  // Paste the first exported JSON object here.
  // Add a comma between objects, then paste the next exported JSON object.
];
```

Paste the object itself, not a quoted JSON string, and do not include an outer array from another source. The guide's skill icons already live in the HTML; no image files need to accompany submissions. The tool remains a single offline HTML file.

Only real submitted guides belong in this array. It starts empty: no invented experts or example builds are published. Valid guides appear in the community list with title, class, server, author and patch. Invalid entries are excluded and the page reports how many could not open. Imported author codes never add entries to this array automatically.

Before publishing, run `node scripts/validate_skills.js`. Every embedded entry must pass the schema and existing simulator allocation rules. Changes to `index.html` still need its usual backup/checkpoint and matching changelog entry.

## Portable format, version 1

```json
{
  "format": "12t-class-guide",
  "version": 1,
  "title": "Guide title",
  "author": "Author name",
  "patch": "Game patch/version",
  "description": "Build description.\nMultiple lines are supported.",
  "build": {
    "server": "tot",
    "classKey": "wolf",
    "level": 100,
    "learned": [101, 102, 103, 451]
  },
  "notes": {
    "103": "Why this skill rank is selected.",
    "201": "Why this skill is skipped."
  }
}
```

* `server`: `og` (BB), `tot` or `tto`. `classKey`: lowercase class name.
* `learned`: unique numeric cell IDs, including every learned lower rank and prerequisite; export sorts them. Cell IDs use the existing tree/row/column scheme. ToT EX cells are legal only on ToT.
* `notes`: cell ID strings mapped to text with optional `**bold gold**` emphasis. A note may target an unselected skill, but never an unknown or unpublished placeholder cell.
* Required for export: title (up to 160 characters), author (120), patch (120). Description allows 12,000 characters; each note allows 3,000. The complete code allows 131,072 characters. JSON import never executes code or renders HTML from submissions.
* `patch` is the author's version label. It does not select historical mechanics; allocation validation uses the tool's current rules for that server. Update the rules and guide data together when a server changes requirements.

## Reader interactions

Readers cannot change the level, server, class, skills or points, reset the build, undo it or long-press into a skill card. Only starred skills open notes. Unread stars pulse subtly as soon as a guide opens, until clicked. The first reveal uses the same star-to-ball melt, arcing light ball with two trailing dots and text wipe as skill-details notes, then keeps its star dimmed but visible. Later clicks reopen the text immediately. Opening another guide resets the read-star state. The star pulse and first-note animation play even when reduced motion is enabled. Notes support keyboard activation, Escape to close and return focus to the skill.

Exports keep the selected server in `build.server`. Import restores this tag instead of using the browser’s current server selection.
