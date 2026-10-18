# Class guide: recommended stats as potion flasks (% and ตัน / ตาม), author order, drag to reorder

Date: 2026-10-18. Tool: ไกด์อาชีพ (class guides) in `12t_projects/bible/index.html`, plus `scripts/guide_code.js` and `12t_projects/bible/CLASS-GUIDES.md`.

## Why

Guide authors often think about stats as priorities rather than exact numbers: "ATK 50% VIT 30% AGI 20%", "max ATK", "the rest as needed". Today a recommended stat can only be a number (0-512, optionally `250+`). Authors also want their stats shown in the order they think of them, not the fixed ATK DEF TAL AGI VIT CHA INT LCK order, and want to reorder stats and gear without deleting and re-entering them.

## Decisions (agreed with the user, 2026-10-18, from browser mockups)

1. **Four value kinds per stat:** a number `0-512` (with optional `+` = "or more", as today), a share `1-100%`, or one of two words: **ตัน** (max it out) and **ตาม** (as needed). Only these two words for now.
2. **Any mix in one guide**, e.g. AGI `250+`, ATK ตัน, VIT `70%`, LCK `30%`, CHA ตาม.
3. **Shares add up to exactly 100** across the % stats of a guide (numbers, ตัน and ตาม are outside the count). The editor shows the running total, and a guide cannot be exported while it is not 100.
4. **Display: the potion flask.** A % or word stat is a round flask in the stat's colour, filled with liquid up to its level, with a moving wavy surface and rising bubbles. A number stat keeps today's ring dial.
5. **Levels:** N% fills to N/100; **100% and ตัน fill the flask to the very top**, no gap. **ตาม** fills about 20% with a slower wave and no bubbles.
6. **ตัน wears a gold crown** above the flask (borrowed from the "weighted medallions" mockup). **No pulsing glow** on anything.
7. **White text in every dial**, including the existing number dials (this changes every published guide's look), with a soft shadow. The stat colour stays on the ring, the liquid and the stat name under the dial.
8. **Order = the author's order:** stats show in the order the author added them, and the author can drag to reorder. Existing guides keep the order they show today.
9. **Editor: add stats one at a time.** The 8 always-visible boxes go away. The author presses the same dashed **+** dial readers use, picks a stat, and gets a flask with the value typed straight into it (the editor renders the same flask as the guide view), with **ตัน / ตาม** toggles under it and **×** to remove.
10. **Drag to reorder** stat flasks in the editor, and **gear items within their slot column** across the set rows (the column stays fixed).
11. **Readers:** % and word stats never feed the skill hover timings (accepted by the user). A reader may still type a number into any flask to try it; the dial becomes today's glowing "try" number dial and the hovers use it. A refresh brings the author's flask back.
12. **PNG:** the flasks are drawn still, at their final level, crown included, white text.

## Non-goals

- More words than ตัน and ตาม.
- Readers adding % or word stats (the reader's own **+** stat stays numbers only).
- Turning % or words into numbers for the hover timings.
- Reordering in the guide view (only the editor reorders).
- Moving a gear item to a different slot column.
- Any change to the gallery cards.

## Anti-goals

- An existing embedded guide or an old short code that reads differently (values or order) after the change.
- Dial text that is hard to read over the liquid.
- Any `prefers-reduced-motion` gate (house rule: every animation always plays).

## Design

### Guide JSON (`stats`)

- `stats` stays an object keyed by stat (`atk def tal agi vit cha int lck`). **Its key order is the display order.** `classGuideStatsClean` must stop rebuilding it in the fixed order and keep the incoming key order instead. Embedded guides already list their keys in the fixed order, so they keep showing as today.
- A value is an integer `0-512` (unchanged), a string `"N%"` with N an integer `1-100` written without leading zeros (the editor normalises `050%` to `50%`), or the string `"ตัน"` or `"ตาม"`. Anything else is rejected with a Thai error, as now. *(Representation: my call. It keeps today's integers valid as they are and keeps the schema in CLASS-GUIDES.md readable.)*
- `statsPlus` is unchanged and only valid on integer values.
- A finished guide (not a draft) whose `%` values do not total 100 is rejected: `สเตตัสแนะนำแบบ % ต้องรวมได้ 100`. Drafts keep whatever was entered.
- A stat that was added but left empty is not stored (same as a blank box today), so it is gone after a reload. *(My call.)*
- ตัน may be used on more than one stat. *(My call: no rule against it.)*
- Every consumer that computes from stats (hover timings via `classGuideTimings`, `viewStats`) uses **only integer values**; a % or word stat counts as not given.

### Short code (TG2), `classGuideBinary` / `classGuideUnpack` and `scripts/guide_code.js`

- **Values:** each set stat is 2 bytes little-endian. Today bits 0-9 hold the number (max 512) and bit 15 is "or more". New: **bit 14 = share** (the low bits hold N, 1-100), **bit 13 = word** (low bits 0 = ตัน, 1 = ตาม). Old codes never set bits 13-14, so they decode as before. Bits 13 and 14 together, bit 15 on a share or word, or an out-of-range low value is an invalid code (`โค้ดไกด์ไม่ถูกต้อง`).
- A code that uses the new kinds or the order block needs the updated page; a page cached from before the change may misread it. This is accepted, as with the earlier format additions.
- **Order:** a new optional block **`0x4F` ('O')**: count byte, then one stat index byte (`CLASS_GUIDE_STAT_KEYS` order) per stat, in display order. Written only when the order differs from the fixed order; a code without it reads in the fixed order. Blocks may already come in any order (gear `0x47`, cover `0x49`, support `0x53`); `0x4F` is unused today.
- `12TG1.` (JSON, decode only) is unchanged. The compact JSON form (`classGuideCompact`, `o.v`) carries `stats` as is, and JSON keeps its key order.
- `scripts/guide_code.js` mirrors the format (header comment, encode, decode, `--selftest`).

### Guide view (reader)

- One dial per stat in `stats` key order, then the existing **+** dial (unchanged).
- **Number dial:** today's ring, value text white `#fffaf0` with `text-shadow: 0 1px 2px rgba(0,0,0,.4)`. The tried / own states keep their glow.
- **Flask:** today's dial size and ring (stat-colour border, round, clipped). Inside it:
  - **Liquid:** a vertical gradient from `color-mix(in srgb, var(--c) 78%, transparent)` to `color-mix(in srgb, var(--c) 55%, #000)`.
  - **Surface:** two wave layers sliding sideways forever, an SVG sine path at 200% width: the front one at 78% stat colour over 2.4 s, the back one at 35% over 3.4 s, reversed. ตาม uses 4.2 s / 5.6 s.
  - **Bubbles:** small white dots (60% opacity) rising from the bottom to the surface over 2.6 s with staggered delays. The count is `round(level × 6)`, at least 2; ตัน has 6, ตาม has 0.
- **Opening motion:** when the stats panel renders, each flask fills from empty to its level over 1.4 s (`cubic-bezier(.3,.7,.2,1)`), staggered 260 ms in display order. A % value counts up from 0 as it fills, and ตัน's crown drops in (about 0.6 s) after its flask is full.
- **Flask text:** white `#fffaf0`, with `-webkit-text-stroke: 2.5px rgba(11,10,9,.45); paint-order: stroke fill; text-shadow: 0 1px 3px rgba(0,0,0,.45)`. **Font: Prompt everywhere on the dials** (the guide page's own font, inherited from `.cg-page` as today's number dials already do; user 2026-10-18: the angular Chakra Petch looks wrong on round dials, and it is now banned site-wide, see `12t_projects/bible/CLAUDE.md` §2). Numbers and `%` use Prompt 700, ตัน / ตาม use Prompt 600, and the stat name under the dial stays Prompt 600. The editor's flasks use the same font; no Chakra Petch or Kanit on any dial.
- **Crown:** a 26 × 15 SVG centred about 15 px above the flask: path `M2 13L4 3l5.5 5L13 1l3.5 7L22 3l2 10z`, a gold vertical gradient (`#fbe7a1` → `#d4af37` → `#8a6a10`) and `drop-shadow(0 0 4px rgba(212,175,55,.8))`. It does not move after it lands.
- **Try input:** the flask's value is the same `cg-stat-try` input as today, and the input rules are unchanged (digits and a final `+`). Typing a number turns that dial into a tried number dial, and the hover uses the number. Clearing the input brings the author's flask back. Nothing is saved.

### PNG (`บันทึกเป็นรูป`)

Same order and dials as the guide view. A flask is drawn still: the liquid at its final level with a gentle wave line on the surface, a few bubbles, the crown on ตัน, and white text with the soft shadow. Number dials get white text too.

### Editor (สเตตัสแนะนำ in the stats-and-sets dialog)

- **Layout:** the fixed 8-box grid is replaced by the author's stats as flasks, in their order, followed by the dashed **+** dial captioned เพิ่มสเตตัส (the same dial readers use).
- **Adding:** the + dial opens the existing pill picker listing the stats not yet added. Picking one appends its flask and focuses its input. The + disappears once all 8 stats are added.
- **Each flask** is drawn exactly like the guide view:
  - **Input:** typed straight into the flask; it accepts `0-512`, `N+` and `1-100%`.
  - **ตัน / ตาม pills** sit under the stat name. Pressing one sets the word and makes the input read-only; pressing it again clears it.
  - **×** removes the stat.
  - **Invalid value:** a red ring and a short hint.
  - **Live updates:** while typing, the level changes with a 0.7 s height transition. There is no count-up in the editor.
- **% total:** a line under the flasks reads `รวม % ทั้งหมด: N%`. It shows green with `✓ ครบ 100` at 100, and red with `ยังขาด N` / `เกินมา N` otherwise. While any % stat exists and the total is not 100, export is blocked the same way a build that breaks a rule cannot be exported today (the expert-mode rule check, `buildProblems()`), and the step's done check treats the stats as unfinished.
- **Drag to reorder:**
  - **Grabbing:** grab a flask anywhere on it, **the value input included** (only the × and the ตัน / ตาม pills don't start a drag). There is no grip icon. Pointer events, so a finger works too, and the browser's native text drag out of the input is suppressed (`dragstart` prevented).
  - **Start:** dragging starts after 6 px of movement, so a plain click on the input still places the caret and types. When a drag starts, the input loses focus and any text selection is cleared.
  - **While dragging:** the lifted flask follows the pointer (scale 1.08, stronger glow), the others slide aside (FLIP, 220 ms), and the + dial stays last.
  - **Drop:** the drop saves the new order to the draft.
- **Carried over:** drafts save on every change, and `syncExtrasSum` (`สเตตัส N`) keeps working.

### Gear editor: drag within a slot column

In `renderGearEditor`, the main item icon of a filled cell can be dragged up or down within its own column:
- **Drop targets:** another filled cell in that column, or below the last filled one.
- **Result:** the item moves to that position in `gear[slot]` and the others shift (insert, not swap). Its Replica and its upgrade stat (ยัด) travel with it. Sets never get a gap.
- **Undo:** the move goes through `gearChange`, so Ctrl+Z undoes it.
- **Click vs drag:** the same 6 px threshold as the stat drag; a click without movement still opens the item picker.
- The guide view's set rows are unchanged.

### Checks and docs

- **`scripts/validate_skills.js`:**
  - Replace the "fixed order" stats test (around line 3285) with author-order tests.
  - Add round trips (JSON and TG2) for every kind and for the order block.
  - Add rejections: `"0%"`, `"101%"`, `"ตัน "`, `"max"`, `513`, `"50"`, and a finished guide whose % values total anything but 100.
  - Prove an existing TG2 code from before this change decodes to the same guide.
- **`scripts/guide_code.js --selftest`:** the same round trips.
- **`12t_projects/bible/CLASS-GUIDES.md`:** the editor steps, the JSON `stats` schema, the TG2 format, and the reader and PNG descriptions.
- **`.claude/skills/bible-hub-tools/SKILL.md`:** update wherever it describes the class guide stats.
- **Changelog entry** per the gate.

## Left to the builder

- DOM structure and class names, following the existing `cg-stat-*` naming.
- How the PNG draws the wave and bubbles (any still frame that matches the look).
- Phone sizes: follow today's dial sizes per breakpoint.
- Whether the flask markup is shared between the editor and the guide view (preferred) or built twice.

## Reference mockups (not in the repo)

The final mockups from the brainstorm, served by the visual companion, live in the session scratch folder `.superpowers/brainstorm/1556-1792289667/content/`:
- `stat-editor-v7.html`: the editor in Prompt, with white text, drag from anywhere on a flask (no grip) and the % total. (The other two mockups below still use Chakra Petch / Kanit, which the user rejected; the font rule above wins.)
- `stat-dial-flask-v3.html`: the guide view flask combinations.
- `stat-dial-variants.html`: the five original variants.

All values the build needs are written out above, so the doc stands without them.
