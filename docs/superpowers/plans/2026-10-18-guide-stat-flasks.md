# Class Guide Stat Flasks Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Recommended stats in class guides can be a number, a share (`50%`) or ตัน / ตาม, shown as potion flasks in the author's order; the editor adds stats one at a time as flasks, and stats and gear can be dragged to reorder.

**Architecture:** Everything lives in the single-file hub `12t_projects/bible/index.html` (pure helpers near `classGuideStatsClean`, the reader in `classGuideStatTile` / `openGuide`, the editor inside `mountClassGuide`, the PNG in the image renderer), mirrored for codes in `scripts/guide_code.js`. Pure functions are tested in `scripts/validate_skills.js` (vm sandbox); DOM behaviour is checked with a throwaway Playwright script in the session scratch dir.

**Tech Stack:** vanilla JS/CSS in one HTML file, Node (validator, guide_code.js), Playwright for the UI checks.

**Spec:** [docs/superpowers/specs/2026-10-18-guide-stat-flasks-design.md](../specs/2026-10-18-guide-stat-flasks-design.md). Read it first; this plan does not repeat its look values (levels, gradients, wave timings, crown path, shadows).

## Global Constraints

- `index.html` is never edited with the Edit/Write tools: every change is a small Node script in the session scratch dir that backs the file up (`index.<timestamp>.bak`), replaces exact CRLF (`\r\n`) anchors, asserts each anchor matched once, and writes back ([12t_projects/bible/CLAUDE.md §1](../../../12t_projects/bible/CLAUDE.md)). Never `git checkout` / `restore` / `reset` / `stash` it.
- Fonts: Prompt only (numbers and % 700, ตัน / ตาม 600). No Chakra Petch anywhere (`[FONT BAN ERROR]`).
- No `prefers-reduced-motion` gates; no pulsing glow anywhere on the dials.
- Dial text white `#fffaf0`; number dials `text-shadow: 0 1px 2px rgba(0,0,0,.4)`; flask text adds `-webkit-text-stroke: 2.5px rgba(11,10,9,.45); paint-order: stroke fill; text-shadow: 0 1px 3px rgba(0,0,0,.45)`.
- Levels: `N%` → N/100, `"ตัน"` → 1 (full to the top, crown), `"ตาม"` → 0.2 (slow wave, no bubbles).
- Thai copy, exact: `สเตตัสแนะนำแบบ % ต้องรวมได้ 100`, `รวม % ทั้งหมด: N%`, `✓ ครบ 100`, `ยังขาด N`, `เกินมา N`, `เพิ่มสเตตัส`.
- One player-facing changelog entry for the whole feature. Subject (exact, used by every task):
  `feat(bible): class guide stats can be a share (50%) or ตัน / ตาม, shown as potion flasks in the author's order; the editor adds stats one at a time and stats and sets drag to reorder; dial text is white`
  Task 1 prepends `["<UTC ISO now>", "<subject>"]` to `CHANGELOG_DATA.entries` and makes the commit; every later task stages its files and runs `git commit --amend --no-edit`. Nothing is pushed until Task 8.
- `node scripts/validate_skills.js` passes at the end of every task.

## Review Focus

1. **Old draft in localStorage** (`12t-bible-class-guide-draft`, stats in the fixed order, numbers only): the new editor opens it with the same stats, in the same order, and nothing is lost. Pinned in Task 5, step 5.
2. **Reader clears a tried flask:** typing `200` into a `50%` flask and then clearing it brings the flask back (level and text), and the hover stops using 200. Pinned in Task 3, step 5.
3. **All 8 stats added:** the editor's + dial disappears; removing one brings it back with only that stat in the picker. Pinned in Task 5, step 5.
4. **Phone width (390 px):** a reader row of 5 flasks and the editor row wrap with no horizontal scroll, and the crown is not clipped. Pinned in Task 3, step 5 and Task 5, step 5.
5. **Click vs drag on the flask input:** a click without movement puts the caret in the input; a 6 px+ move drags instead and does not leave text selected. Pinned in Task 6, step 3.

---

### Task 1: Stat value kinds, author order and the % rule (data layer)

**Files:**
- Modify: `12t_projects/bible/index.html`: `classGuideStatsClean` (~29698) and new helpers right after it; the `statsPlus` line and the `classGuideStatsClean(...)` call in `classGuideNormalize` (~29856); `tipExtra` (~30991) and `viewStats` init in `openGuide` (~31349); `CHANGELOG_DATA.entries` (prepend)
- Modify: `scripts/validate_skills.js`: the "Recommended stats" block (~3283-3292)
- Modify: `12t_projects/bible/CLASS-GUIDES.md`: the `stats` bullet (~line 65) and the editor step 4 (~line 12)

**Interfaces:**
- Produces (global functions in index.html, used by every later task):
  - `const CLASS_GUIDE_STAT_WORDS = ["ตัน", "ตาม"]`
  - `classGuideStatKind(v) -> "num" | "pct" | "word" | null`: `"num"` for an integer 0-512; `"pct"` for a string matching `/^(100|[1-9]\d?)%$/`; `"word"` for a string in `CLASS_GUIDE_STAT_WORDS`; otherwise `null`
  - `classGuideStatLevel(v) -> number | null`: `"pct"` → N/100, `"ตัน"` → 1, `"ตาม"` → 0.2, otherwise `null`
  - `classGuideStatsProblem(stats) -> string | null`: `null` when no value is `"pct"` or their sum is exactly 100, else `"สเตตัสแนะนำแบบ % ต้องรวมได้ 100"`
  - `classGuideNumericStats(stats) -> object | null`: only the `"num"` entries, in key order; `null` when none
  - `classGuideStatsClean(raw, draft = false) -> object`: keeps the incoming key order; throws the existing errors for unknown keys or bad values; when `!draft`, throws `classGuideStatsProblem(...)`'s message
- `classGuideNormalize`: `statsPlus` keeps only keys whose value is `"num"`

- [ ] **Step 1: Write the failing tests** (replace the "fixed order" test in the Recommended stats block)

```js
const kind = vm.runInContext("classGuideStatKind", sandbox), level = vm.runInContext("classGuideStatLevel", sandbox);
const numeric = vm.runInContext("classGuideNumericStats", sandbox), problem = vm.runInContext("classGuideStatsProblem", sandbox);
ok(Object.keys(norm(change({stats:{lck:40,agi:77}})).stats).join() === "lck,agi", "recommended stats keep the author's order");
const mixed = {agi:250, atk:"ตัน", vit:"70%", lck:"30%", cha:"ตาม"};
ok(JSON.stringify(norm(change({stats:mixed})).stats) === JSON.stringify(mixed), "numbers, shares and ตัน / ตาม mix in one guide, order kept");
for (const bad of [{agi:"0%"},{agi:"101%"},{agi:"050%"},{agi:"ตัน "},{agi:"max"},{agi:"50"},{agi:513},{agi:1.5},{agi:null}]) rejects(()=>norm(change({stats:bad})), "reject stat value " + JSON.stringify(bad));
rejects(()=>norm(change({stats:{atk:"50%",vit:"30%"}})), "a finished guide's shares must total 100");
ok(norm(change({title:"",author:"",date:"",stats:{atk:"50%"}}),{draft:true}).stats.atk === "50%", "drafts keep shares that do not total 100 yet");
ok(!("statsPlus" in norm(change({stats:{atk:"ตัน",agi:250},statsPlus:["atk"]}))) && norm(change({stats:{agi:250},statsPlus:["agi"]})).statsPlus.join() === "agi", "250+ applies to numbers only");
ok(kind(0) === "num" && kind(512) === "num" && kind("100%") === "pct" && kind("ตาม") === "word" && kind("250") === null && kind(513) === null, "stat kinds");
ok(level("100%") === 1 && level("30%") === 0.3 && level("ตัน") === 1 && level("ตาม") === 0.2 && level(250) === null, "flask levels");
ok(JSON.stringify(numeric(mixed)) === '{"agi":250}' && numeric({atk:"ตัน"}) === null, "only numbers reach the hover timings");
ok(problem({atk:"ตัน",vit:"70%",lck:"30%"}) === null && problem({vit:"70%"}) === "สเตตัสแนะนำแบบ % ต้องรวมได้ 100" && problem({agi:250}) === null, "the % total ignores numbers and words");
```

- [ ] **Step 2: Run the validator to see them fail**

Run: `node scripts/validate_skills.js`
Expected: FAIL on the new checks (`classGuideStatKind is not defined`, "keep the author's order").

- [ ] **Step 3: Implement the helpers and the `classGuideStatsClean(raw, draft)` change** (scratch patch script). Pass `draft` from `classGuideNormalize`. In `tipExtra` and in `openGuide`'s `viewStats` init, use `classGuideNumericStats(current.stats)` instead of `current.stats`. Also update the two CLASS-GUIDES.md lines to the new value kinds and author order (copy the spec's JSON section).

- [ ] **Step 4: Prepend the changelog entry** (scratch script, the subject from Global Constraints).

- [ ] **Step 5: Run the validator**

Run: `node scripts/validate_skills.js`
Expected: `SUCCESS`, `CHANGELOG PENDING: '<subject>'`.

- [ ] **Step 6: Commit**

```bash
git add 12t_projects/bible/index.html scripts/validate_skills.js 12t_projects/bible/CLASS-GUIDES.md docs/superpowers/specs/2026-10-18-guide-stat-flasks-design.md docs/superpowers/plans/2026-10-18-guide-stat-flasks.md
git commit -F <file holding the subject + the Co-Authored-By trailer>
```

---

### Task 2: Short codes carry the new kinds and the order (TG2)

**Files:**
- Modify: `12t_projects/bible/index.html`: `classGuideBinary` (~29922, stats bytes ~29940-29941) and `classGuideFromBinary` (~29954, stats read ~29977-29978, block loop)
- Modify: `scripts/guide_code.js`: header comment (lines 16-27), `classGuideBinary`, `classGuideFromBinary`, `--selftest`
- Modify: `scripts/validate_skills.js`: the format 2 block (~3262-3270)
- Modify: `12t_projects/bible/CLASS-GUIDES.md`: the format 2 bullet (~line 73)

**Interfaces:**
- Consumes: `classGuideStatKind` (Task 1)
- Produces: the stat value word written per set stat = `n | plus << 15` for `"num"`, `N | 1 << 14` for `"pct"`, `index | 1 << 13` for `"word"` (`CLASS_GUIDE_STAT_WORDS` index); and optional block `0x4F`, count byte, then one `CLASS_GUIDE_STAT_KEYS` index byte per stat in display order, written only when `Object.keys(stats)` differs from the fixed order. The decoder rejects (`โค้ดไกด์ไม่ถูกต้อง`) bits 13+14 together, bit 15 with 13 or 14, a share outside 1-100, a word index above 1, and an order block whose indices are not exactly the set stats.

- [ ] **Step 1: Write the failing tests** (format 2 block)

```js
const OLD = "TG2.AdNNYWdAAwIMDJZqC3UYfzUwMHCF5-ekKaSXZqakMjoyMHgyMgAA";   // written by the pre-flask encoder: wolf, stats {atk:300,cha:250,lck:0}, statsPlus ["cha"]
const od = gc.decode(OLD);
ok(JSON.stringify(od.stats) === '{"atk":300,"cha":250,"lck":0}' && od.statsPlus.join() === "cha" && gc.encode(od) === OLD, "a pre-flask TG2 code decodes the same and re-encodes to the same string");
const flask = norm({...fixture, stats:{cha:"ตาม", agi:250, atk:"ตัน", vit:"70%", lck:"30%"}, statsPlus:["agi"]});
ok(same(Array.from(bin(flask)), Array.from(gc.classGuideBinary(flask))), "page and guide_code.js write the same bytes for shares, words and author order");
ok(same(norm(fromBin(bin(flask))), flask) && same(norm(gc.decode(gc.encode(flask))), flask), "shares, words, 250+ and the author's order round-trip through TG2");
ok(same(expand(compact(flask)), flask), "the compact (12TG1) form keeps shares, words and order");
const base = bin(norm({...fixture, stats:{agi:250}}));   // byte 24 = stats mask (checked 2026-10-18), bytes 25-26 = AGI's value
ok(base[24] === 1 << 3, "TG2 layout: the stats mask is byte 24");
ok([0x6001, 0xC032, 0x4000, 0x4065, 0x2002].every(v => { const b = Uint8Array.from(base); b[25] = v & 255; b[26] = v >> 8; try { fromBin(b); return false; } catch (e) { return true; } }), "invalid share / word bits in a TG2 code are rejected");
```

Put these inside the existing format 2 block (it defines `bin`, `fromBin`, `same`, `gc`, `compact`, `expand`).

- [ ] **Step 2: Run the validator to see them fail**

Run: `node scripts/validate_skills.js`
Expected: FAIL on the round-trip and invalid-bits checks (the pre-flask check already passes).

- [ ] **Step 3: Implement the encoder/decoder in both files**: the value bits above, plus the `0x4F` block (written last, read in the existing any-order block loop). Update the guide_code.js header comment and `--selftest` (add the `flask` guide round trip), and the CLASS-GUIDES.md format bullet.

- [ ] **Step 4: Run both checks**

Run: `node scripts/guide_code.js --selftest && node scripts/validate_skills.js`
Expected: selftest ok, validator `SUCCESS`.

- [ ] **Step 5: Amend the commit**

```bash
git add 12t_projects/bible/index.html scripts/guide_code.js scripts/validate_skills.js 12t_projects/bible/CLASS-GUIDES.md
git commit --amend --no-edit
```

---

### Task 3: Reader flasks, white dial text and the try input

**Files:**
- Modify: `12t_projects/bible/index.html`: CSS next to `.cg-stat-val` (~1825-1831); `classGuideStatTile` and `classGuideStatsHtml` (~30204-30212); the `[data-cg-try]` input handler (~31652-31662); `openGuide` (~31348) to start the fill animation
- Modify: `12t_projects/bible/CLASS-GUIDES.md`: the reader "Recommended stats" bullet (~line 79)

**Interfaces:**
- Consumes: `classGuideStatKind`, `classGuideStatLevel`, `classGuideNumericStats` (Task 1)
- Produces:
  - `classGuideFlaskInner(value) -> string`: the liquid + two waves + bubbles markup for a `"pct"` / `"word"` value (`""` otherwise). Bubble count: `round(level × 6)`, at least 2; ตัน 6; ตาม 0.
  - `classGuideStatTile(s, value, plus, own, attr = "data-cg-try") -> string`: same label/input structure as today (`input.cg-stat-try[<attr>="<key>"]`); `value` is the stored value (integer, `"N%"`, word) or `null` for a reader-added stat, `plus` shows `250+`. For a `"pct"` / `"word"` value it adds class `is-flask` to `.cg-stat-val`, `classGuideFlaskInner(value)` inside it, `data-cg-level="<level>"` (and `data-cg-word` for words) on the tile, and the crown `<svg class="cg-crown">` before `.cg-stat-val` for ตัน. Update both callers: `classGuideStatsHtml` and the reader's add-stat handler (~31725, `classGuideStatTile(st, null, false, true)`).
  - `classGuideStatsHtml(stats, plus)`: tiles in `Object.keys(stats)` order.
  - `classGuideFlaskFill(box) -> void`: animates every `.is-flask` liquid in `box` from 0 to its level (1.4 s, 260 ms stagger, count-up for `%`, crown drop after fill). Called by `openGuide` after `guideStats` renders.

- [ ] **Step 1: Write the failing test** (validator, after the Task 1 checks)

```js
const tile = vm.runInContext("classGuideStatTile", sandbox), S = {key:"atk", label:"ATK"};
ok(/is-flask/.test(tile(S, "70%", false, false)) && /data-cg-level="0.7"/.test(tile(S, "70%", false, false)) && !/is-flask/.test(tile(S, 250, true, false)), "shares and words render as flasks, numbers as dials");
ok(/class="cg-crown"/.test(tile(S, "ตัน", false, false)) && !/class="cg-crown"/.test(tile(S, "ตาม", false, false)), "only ตัน wears the crown");
ok(/value="250\+"/.test(tile(S, 250, true, false)), "250+ still shows its plus");
```

- [ ] **Step 2: Run to see it fail**

Run: `node scripts/validate_skills.js`. Expected: FAIL (`is-flask` missing, old signature).

- [ ] **Step 3: Implement the tile, CSS (spec "Guide view" section: liquid gradient, waves, bubbles, crown, white text, Prompt), `classGuideFlaskFill`, and the try behaviour**: typing a number into a flask's input removes `is-flask` styling for that tile (class `is-tried`, number dial), and the hover uses the number via `viewStats`; clearing restores the author's value, the flask class and its level (no re-animation needed), and deletes the key from `viewStats` when the author's value is not a number. Update the CLASS-GUIDES.md reader bullet.

- [ ] **Step 4: Run the validator.** Expected: `SUCCESS`.

- [ ] **Step 5: Browser check** (scratch Playwright script; this is a layout change, so a browser check is allowed). Seed `localStorage["12t-bible-class-guide-draft"]` with a valid TTO wolf draft whose `stats` are `{agi:250, atk:"ตัน", vit:"70%", lck:"30%", cha:"ตาม"}` and `statsPlus:["agi"]`, open `file:///D:/12tails/12t_projects/bible/index.html#class-guide/write`, click `[data-cg-act="preview"]`, wait 2.5 s, then assert:
  - the tiles' order is AGI, ATK, VIT, LCK, CHA, with 4 `.is-flask` and 1 plain dial;
  - the ATK liquid height is 100% and the crown is visible;
  - the input's computed `font-family` starts with `Prompt` and its `color` is `rgb(255, 250, 240)`;
  - typing `200` into VIT gives `is-tried` and no flask; clearing it brings the flask back at 70%.

  Repeat at a 390 px viewport: `document.documentElement.scrollWidth <= 390`. Save one screenshot to `.playwright-mcp/`, look at it, then delete it.

- [ ] **Step 6: Amend the commit** (`git add` the two files, `git commit --amend --no-edit`).

---

### Task 4: PNG draws the flasks

**Files:**
- Modify: `12t_projects/bible/index.html`: the stats section of the PNG renderer (~30498-30513)
- Modify: `12t_projects/bible/CLASS-GUIDES.md`: the PNG bullet (~line 84)

**Interfaces:**
- Consumes: `classGuideStatKind`, `classGuideStatLevel` (Task 1)
- Produces: nothing new. The PNG iterates `Object.keys(guide.stats)`, draws number dials with white text, and draws a `"pct"` / `"word"` stat as a still flask: the liquid clipped to the circle up to its level, one sine surface line, 3 bubbles (none for ตาม), the crown on ตัน, white text with the soft shadow.

- [ ] **Step 1: Implement** (no unit test: canvas output). Use the existing helpers inside the renderer (`font`, `alpha`, `v("--stat-" + key)`, `spaced`); the label text stays in the stat colour.
- [ ] **Step 2: Run the validator.** Expected: `SUCCESS`.
- [ ] **Step 3: Browser check**: with the Task 3 draft, run `บันทึกเป็นรูป` from the guide menu (Playwright: capture the download), open the PNG and look at the stats panel: 5 dials in author order, ATK full with crown, CHA at 20%, all text white and readable. Delete the PNG afterwards.
- [ ] **Step 4: Amend the commit.**

---

### Task 5: Editor adds stats one at a time, as flasks

**Files:**
- Modify: `12t_projects/bible/index.html`: `classGuideStatsEditorHtml` (~30198); CSS near `.cg-extras-panel .cg-stat-in` (~2010-2019); in `mountClassGuide`: `statInput` / `collectStats` / `collect` (~30920-30929), the `[data-cg-stat]` input handler (~31640), the draft load (~31267), `updateSteps` done check (~31041), the export guards (~31706, ~31755), click handling for the new buttons
- Modify: `scripts/validate_skills.js` (one pure-function test)
- Modify: `12t_projects/bible/CLASS-GUIDES.md`: editor step 4 (~line 12)

**Interfaces:**
- Consumes: `classGuideStatTile`, `classGuideFlaskInner` (Task 3); `classGuideStatKind`, `classGuideStatLevel`, `classGuideStatsProblem` (Task 1)
- Produces:
  - `classGuideStatParse(raw) -> { value, plus } | "" | null`: trims the input; `""` for empty; `"ตัน"` / `"ตาม"` as is; `N%` with leading zeros dropped (`"050%"` → `"50%"`, valid range 1-100); `N` or `N+` as an integer 0-512 (`plus` true for `N+`); `null` for anything else.
  - The editor keeps `draft.stats` (author order) and `draft.statsPlus` as the single source of truth. `collect()` reads them instead of 8 inputs.
  - Markup: the stats fieldset holds `[data-cg-role="statEd"]` (the flasks, each built with `classGuideStatTile(s, value, plus, false, "data-cg-stat")`, plus a `×` button `[data-cg-act="statDel"][data-key]` and ตัน / ตาม pills `[data-cg-act="statWord"][data-key][data-word]`), then the reader's + dial markup (`CLASS_GUIDE_STAT_ADD`, with its own act `addEdStat`), then `[data-cg-role="statSum"]`.

- [ ] **Step 1: Write the failing test**

```js
const parse = vm.runInContext("classGuideStatParse", sandbox);
ok(JSON.stringify([parse(""), parse(" 050% "), parse("250+"), parse("0"), parse("ตาม"), parse("101%"), parse("513"), parse("abc")]) === JSON.stringify(["", {value:"50%",plus:false}, {value:250,plus:true}, {value:0,plus:false}, {value:"ตาม",plus:false}, null, null, null]), "editor input parsing");
```

- [ ] **Step 2: Run to see it fail.** Expected: `classGuideStatParse is not defined`.

- [ ] **Step 3: Implement `classGuideStatParse` and the editor.**
  - **Adding:** + opens the pill picker (stats not yet in `draft.stats`) and appends `{key: ""}` to the editor's local order list; the input is focused. An empty stat is not written to `draft.stats`, so it is gone after a reload (spec).
  - **Inputs:** typing updates `draft.stats` / `draft.statsPlus` through `classGuideStatParse`. An invalid value gives a red ring plus the hint and is not saved.
  - **ตัน / ตาม pills:** toggle the word on that stat.
  - **×:** removes the stat.
  - **Flask level:** changes with a 0.7 s height transition, no count-up.
  - **`statSum` line:** uses the exact Thai copy.
  - **Export guard:** `export` and `exportImage` also refuse while `classGuideStatsProblem(draft.stats)` is not null. The status line shows that message, and the extras dialog opens.
  - **Done check:** `updateSteps` counts the stats step as not done while the problem exists.
  - **Docs:** update CLASS-GUIDES.md step 4.

- [ ] **Step 4: Run the validator.** Expected: `SUCCESS`.

- [ ] **Step 5: Browser check** (scratch Playwright).
  1. Seed an **old-style** draft: `stats:{atk:180,vit:120,lck:60}` in fixed order, no new kinds. Open `#class-guide/write` and the extras dialog. Assert: 3 flasks in order ATK, VIT, LCK showing 180, 120, 60.
  2. Add CHA, type `70%`, and add AGI with ตาม. Assert the sum line reads `รวม % ทั้งหมด: 70%` with `ยังขาด 30`.
  3. Click export. Assert the export is refused with `สเตตัสแนะนำแบบ % ต้องรวมได้ 100`.
  4. Add stats until all 8 are in. Assert the + dial is gone. Remove DEF; assert the + is back and its picker lists only DEF.
  5. Reload. Assert the order and values persisted.
  6. At 390 px, assert `scrollWidth <= 390`.

  Screenshot once, look at it, then delete it.

- [ ] **Step 6: Amend the commit.**

---

### Task 6: Drag to reorder stat flasks in the editor

**Files:**
- Modify: `12t_projects/bible/index.html`: `mountClassGuide` (pointer handlers on `[data-cg-role="statEd"]`), CSS (`cursor:grab`, `touch-action:none` on the flask tiles, `.is-dragging`)

**Interfaces:**
- Consumes: the Task 5 markup and `draft.stats`
- Produces: on drop, `draft.stats` is rebuilt in the new DOM order (same values) and `saveDraft()` runs.

- [ ] **Step 1: Implement** the pointer-event drag from the spec's "Drag to reorder" section, as in the approved mockup:
  - **Start:** any `pointerdown` inside a flask except the `×` and the ตัน / ตาม pills. Dragging starts after 6 px of movement. At that point, blur the input and clear the selection; `dragstart` is prevented.
  - **While dragging:** the lifted flask follows the pointer (`scale(1.08)`). The others FLIP-slide over 220 ms, and the + dial stays last.
  - **No grip icon.**
- [ ] **Step 2: Run the validator.** Expected: `SUCCESS`.
- [ ] **Step 3: Browser check** (scratch Playwright), with the Task 5 draft:
  1. Press the mouse on AGI's input and drag it past the last flask. Assert the DOM order and `JSON.parse(localStorage[...]).stats` key order both end in AGI.
  2. Click VIT's input without moving. Assert `document.activeElement` is VIT's input, then type `5` and assert the input's value changed.
  3. Assert no text is selected after the drag: `getSelection().toString() === ""`.
- [ ] **Step 4: Amend the commit.**

---

### Task 7: Drag gear within its slot column

**Files:**
- Modify: `12t_projects/bible/index.html`: `renderGearEditor` (~30935) markup hooks and a pointer drag in `mountClassGuide`
- Modify: `12t_projects/bible/CLASS-GUIDES.md`: the เซ็ตแนะนำ editor sentence (~line 13)

**Interfaces:**
- Consumes: `gearChange(fn)` (existing; pushes undo, saves, re-renders)
- Produces: `classGuideGearMove(list, from, to) -> array` (pure, global): returns a new array with `list[from]` moved to index `to`, the others shifted, and `to` clamped to `list.length - 1`.

- [ ] **Step 1: Write the failing test**

```js
const mv = vm.runInContext("classGuideGearMove", sandbox);
ok(JSON.stringify(mv(["a","b","c"], 0, 2)) === '["b","c","a"]' && JSON.stringify(mv(["a","b","c"], 2, 0)) === '["c","a","b"]' && JSON.stringify(mv(["a","b"], 0, 5)) === '["b","a"]', "gear moves within its column, others shift, no gaps");
```

- [ ] **Step 2: Run to see it fail.** Expected: `classGuideGearMove is not defined`.
- [ ] **Step 3: Implement** `classGuideGearMove` and the drag.
  - **Grab:** the `.cg-set-main` button of a filled cell, with the 6 px threshold; a click without movement still opens the picker.
  - **Drop:** only on a filled cell of the same slot column, or below the last filled one.
  - **Move:** apply `gearChange(gear => { gear[slot] = classGuideGearMove(gear[slot], from, to); })`. The Replica and ยัด stat move with the item because the whole object moves.
  - **Undo:** Ctrl+Z works through the existing gear undo.
  - **Docs:** update CLASS-GUIDES.md.
- [ ] **Step 4: Run the validator.** Expected: `SUCCESS`.
- [ ] **Step 5: Browser check.** Seed a draft with `gear:{weapon:[{item:<any valid id for the class>},{name:"Staff of Tomorrow"}]}`, open the extras dialog and drag set 1's weapon onto set 2. Assert the order swapped in `localStorage`. Press Ctrl+Z and assert it is restored. Assert a plain click on the icon still opens `[data-cg-role="gearPicker"]`.
- [ ] **Step 6: Amend the commit.**

---

### Task 8: Docs sweep, full checks and push

**Files:**
- Modify: `.claude/skills/bible-hub-tools/SKILL.md`: the class guide stats line (~line 60) and anything describing the stat editor or sets editor
- Modify: `.claude/skills/guide-draft/SKILL.md` only if it states the old stat format (it currently says to skip stats; leave that rule)

- [ ] **Step 1: Update the skill lines** to the new kinds, author order, flasks and drag.
- [ ] **Step 2: Run** `node scripts/guide_views.js` (if it fails, the reader snapshot keeps its old numbers; say so), then `node scripts/validate_skills.js --full`. Expected: `SUCCESS`, `CHANGELOG CURRENT` matching the subject.
- [ ] **Step 3: Amend the commit** with all remaining files, show the user `git show --stat HEAD`, and **push only after the user says so** (`git push`).
