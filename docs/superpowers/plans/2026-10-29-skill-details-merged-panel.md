# Skill details: side panel, scale lock and collapsible stat panels (implementation plan, 2026-10-29)

- **Spec:** `docs/superpowers/specs/2026-10-29-skill-details-merged-panel-design.md` (owner-approved). **Mockup B:** `docs/superpowers/specs/2026-10-29-skill-details-merged-panel-mockups.html`.
- **Rules:** `12t_projects/bible/CLAUDE.md` §1-§2 (large-file protocol, CRLF, changelog, validator, two fonts, no reduced-motion gates, hover = lift), `.claude/skills/bible-skill-page-ui/SKILL.md`, `.claude/skills/bible-card-fields/SKILL.md` ("Compatible Skills Navigation"), `.claude/skills/bible-desc-writing/SKILL.md`.
- **Line numbers** are `12t_projects/bible/index.html` and `scripts/validate_skills.js` at `b11dfc4`. They drift once a step lands, so every patch finds its text by anchor (with a dry-run match count), never by line number.
- **Paths** are repo-relative, because the repo lives in different folders on the owner's two PCs. `<scratch>` is the build session's scratchpad directory; nothing temporary goes into the repo.
- **Spine:** the judges' winner (the risk-first plan), with grafts from the other two plans (noted in "Calls made") and every gap the judges listed fixed.

## Status and handoff (2026-10-29, 17:30, workplace PC)

- **Step 1 is done (commit A, pushed 2026-10-29 before 18:00); Steps 2-9 are not started.** Commit A has the stat panel collapse, its 6 new `[PANEL ERROR]` checks and the rulebook text (`bible-skill-page-ui` "Stat dials", delta motion, `[PANEL ERROR]` line). Its hover adds the house lift (`translateY(-1px)`) to the plan's CSS. Checked in the browser at 1920×1080 on BB (`monkey_fireBall`): each chevron hides only its own grid, the header and Buff / Debuff rows stay, the state survives a reload, the dials fit after expanding, and with the player panel collapsed a raised AGI sends its light from the header centre. **Not run yet from browser pass A:** 1280×720 and 390×844, the Reborn look, the chip-target case (b), the enemy case (c), the typing case (d) and Ctrl+Z; run them during Step 7's browser pass. Next: Step 0 (harness only), then Step 2.
- **HEAD:** commit A sits on this plan's commit, which sits on `de6926a` (spec and mockups) and `b11dfc4`. Commit A moved the page's line numbers by a few lines (patches anchor on text, so nothing breaks), and Step 0's baseline now reads `35 stat panel structure checks` (29 + Step 1's 6); every other plan-time number still holds. Step 1's "Also stage this plan file (untracked)" is moot: the plan is already committed.
- **Scratch:** `<scratch>` is the scratchpad of the session that builds this. Nothing from the planning session's scratchpad (on the workplace PC) is needed, because Step 0 creates every helper. The one exception is Step 0 item 4's "existing scratch helper" `changelog_add.js`, which is not on the home PC: write it fresh. It prepends `["<current UTC ISO>", "<subject>"],` to `CHANGELOG_DATA.entries` at the anchor given there.
- **Revision done:** a completeness critic checked this plan against the page at `b11dfc4` and found 8 gaps (1 high, 3 medium, 4 low). The revise pass re-ran the critic's probes, confirmed all 8 and fixed them in the text below. "Revision notes" at the end lists each change.

## Goal

Make the dependency toggles on the desktop skill details page stay in one fixed place while the player clicks them again and again. One side panel beside the card replaces both the related-skills rail and the toggle strip. In the panel, toggles are grouped by function, and each row shows the ring icon, a name that opens that skill's card, rank pips, tags and a switch. Below the toggles come only the related skills that the description does not already link, with long lists folded. While the pointer or keyboard focus is on the panel (or on a stat panel's header), the page keeps its scale. The player and enemy stat panels can each collapse to their header row. Phones keep today's strip under the description and get the leftover related skills at the very bottom of the tool. Nothing about what the toggles do, the card data or the fit rules changes.

## Architecture

### A. Where the panel lives (one aside, placed by CSS only)

`renderHeroNow` calls `renderSidePanel(act, linkText)` once per render. The call comes after every `depSinkAdd` registration and before `heroDescHtmlFor(depLineDeps)` (today's `renderDepStrip()` call at 25491). It returns two strings:

- **`side`:** `<aside class="sk-side" aria-label="ตัวเลือกและสกิลที่เกี่ยวข้อง">`, which holds:
  - the toggle strip, still wrapped in `<div class="sk-dep-strip">…</div><!--/sk-dep-strip-->` (the wrapper `splitStrip` looks for);
  - then the desktop related list `<div class="sk-compat-chip sk-rel">`.

  It is written into the hero at the strip's old slot, `${depStripHtml}` at 25516, right after `${supportLvBlock}`. It is `""` when both parts are empty.
- **`phone`:** `<div class="sk-compat-chip sk-rel sk-rel-phone">`, written into the rail's old slot (25540-25544, after `.sk-detail-main`).

The tree is the same at every width:

```
[data-role=display]
  .sk-detail-layout                       (the --has-compat modifier is gone)
    .sk-detail-main
      .sk-hero
        nav ‹ ›, .sk-hero-head (+ .sk-hero-desc), supportLvBlock,
        aside.sk-side  [ .sk-dep-strip (headings + rows) | .sk-rel (desktop related list) ]
        summon row, chips, odds, damage rows
    .sk-rel-phone                         (phone related list)
```

- **Desktop (from 900 px):**
  - `.sk-side{position:absolute; left:calc(100% + 20px); top:0; width:260px; z-index:4}` is exactly the rail's old box.
  - Its containing block is `.sk` (position:relative, 3083), because nothing between them is positioned or creates a containing block there:
    - the only rule that positions `.sk-hero` is the ‹ › block at 6598, which moves from `max-width:900px` to `max-width:899px`;
    - `.sk-detail-main`, `.sk-detail-layout` and the display element have no rules at all;
    - none of them is in `THEME_SURFACES`, so none gets a backdrop-filter. This was checked with grep.
  - `.sk-rel-phone{display:none}`.
  - The panel's top lines up with the stats panel and the search row, as the rail did.
- **Phones (899 px and below):**
  - The aside stays in flow, so the strip stays under the description in today's 3-column (761-899 px) or 2-column (up to 760 px) form.
  - The headings, the switch and the desktop related list are `display:none`, and the names are inert (`pointer-events:none`).
  - `.sk-rel-phone` moves after the enemy panel: `html.tool-wide-hero .sk > [data-role="display"]` and `.sk-detail-layout` become `display:contents`, so `.sk-detail-main` and `.sk-rel-phone` become flex items of `.sk`. The stats panel has `order:1`, and `.sk-rel-phone{order:2}` puts the list after it.
- **What this keeps working:**
  - Every dep button is rendered once, inside the display element. So these keep working untouched:
    - the per-render click binders (25640 / 25661);
    - `depStates` (22876) and `depClicked` (23210);
    - the pip memory (`depPipSeen`; `depPipsHtml` is still called once per dep);
    - `fitDepLabels`;
    - the validator, which reads only `displayEl.innerHTML`.
  - Tab order stays desc → toggles → related rows → chips.
  - Only the related rows are written twice: the desktop list and the phone list differ by design, and CSS shows one of them.
- **Code that read the rail now reads `.sk-side`:**
  - `positionCombatLedger` (22630);
  - `fitStageToScreen`: compW (37233), compH (37238-37240) and the zoomed left edge (37263);
  - `DELTA_POPUPS` (22866) and `deltaText` (22872), where `.sk-dep-strip` becomes `.sk-side`.
- **Stacking does not change:**
  - panel 4;
  - desc 3, and 5 while a status is hovered or open (464-469);
  - stats panel 10;
  - Test layer 15.

  One rule is added: a hovered `.sk-stat` chip lifts to 5, so its odds tooltip (which opens in the panel's column) shows above the panel.

### B. Toggle rows

- **Groups, top to bottom:**
  1. `gear` อุปกรณ์: a non-skill toggle (`depOrderKey` is Infinity) whose `dep.icon` starts with `item_`.
  2. `cond` เงื่อนไข / โหมด: every other non-skill toggle (`DEP_NOT_SKILL`, no card match, the open card itself).
  3. `dmg` ดาเมจ: DMG HEAL HITS KO CHANCE SHIELD STATS.
  4. `time` เวลา: CD CAST DUR.
  5. `range` ระยะ: RANGE.
  6. `info` คำอธิบาย: INFO, or an unknown tag.

  A skill toggle goes to the lowest group any of its tags maps to.
- **Order within a group:**
  - Skill rows ascend by `SKILL_INTERNAL_ID`.
  - Gear and condition rows keep their registration order. `Infinity - Infinity` is `NaN`, so the comparator falls through to the insertion index, as it does today.
- **Headings:** `<p class="sk-dep-group-h" data-dep-group="gear">อุปกรณ์</p>` before the first row of each group, only when the toggle rows span two or more groups. The related list always has its own title, สกิลที่เกี่ยวข้อง.
- **Row markup:** the unchanged parts are the wrapper, the button with its pips, the name span and the tags.

  ```
  <div class="sk-dep-item" data-dep-order="K" title="FULL LABEL" data-dep-group="G">
    <span class="sk-dep-btncol">BUTTON (img inside, unchanged)  PIPS</span>
    <span class="sk-dep-item-text">NAME<span class="sk-dep-item-tags">TAGS</span></span>
    <i class="sk-dep-sw" aria-hidden="true"></i>
  </div>
  ```

  - `NAME` is `<span class="sk-dep-item-name">LABEL</span>`.
  - On a row with a card link, `NAME` is that same span wrapped in `<button type="button" class="sk-dep-link" data-skill-id="ID">…</button>`. The link has no `title`, so hovering it shows the row's full-label title.
- **Name link card (`depLinkCard(dep, r, act)`):** at rank r, the link opens the first match of:
  1. the card that the shown label names (`findSkillByMention(labelFor(r) cut at " (", act)`, the desc's own link rule);
  2. else the card whose id is the icon key at r without its digits (`depLineIcon(iconFor(r) || icon)`).

  It never opens the open card or a `soon` stub. Icon keys starting with `item_`, `mount_` or `status_` never link. Gear rows never link. Condition rows do link.
- **Covered cards:** every card that a *skill-group* row (ดาเมจ to คำอธิบาย) can open at any of its ranks from max(1, minRank) to maxRank. On desktop a covered card appears once, as that toggle row, and is left out of the related list. Condition rows cover nothing.
- **Desktop look (mockup B):**
  - The row is a fixed 40 px CSS grid: `32px | 1fr | 34px` columns, rows 17 px and 11 px.
  - **Ring:** the button itself is the ring: 32 px, round, ink fill, 1 px gold edge. Its img is zoomed 1.3x and centred by `centreRingImg`. The grey/colour state and the flip pop run on the ring, the same pattern as Revised Art (3218-3226, 6473-6477).
  - **Name and pips:** the name sits on the first line, with the pips under it.
  - **Tags:** on the pip line, aligned right.
  - **Switch:** on the right; it mirrors `.on`.
  - `.sk-dep-btncol` and `.sk-dep-item-text` are `display:contents`, so the DOM (and `pipPoint`) does not change.
- **Clicks:**
  - The ring is the real button.
  - A click on the switch is forwarded to the row's button with `btn.click()`, so `depClicked`, `DEP_EXCLUSIVE`, kaiserLv and amplifyDamage all run as today.
  - The name line never toggles. Its text opens the card, and the rest of the line does nothing. So a label that grows at rank 5 (Hyper Shot → Snipe Mastery) cannot turn a toggle click into a link click.
  - Phones keep today's behaviour: only the icon toggles.
- **Motion:**
  - `flipStart` also writes `--flip-delay` on the row, so the ring and the switch both wait for the red comets. The img keeps its old picture during that delay, as today.
  - The light leaves from the clicked toggle first, then from the first one that went up, then from the first flip. Before this change, DOM order decided, and gear now comes before skills in the DOM.

### C. The related lists

1. **What counts as linked:** `linked` = every card that `findSkillByMention(t, act)` returns for each `**t**` in `linkText`. `linkText` is two pieces of text:
   - the raw desc of the server tab on screen (`descStr` at the current rank and heroDep rank). That means:
     - all lines, including the ones `hideOffDepLines` hides;
     - bold text inside `__…__`;
   - plus the `liveCheck` note, which renders inside the desc box with the same gold links.
2. **The compat list:**
   - `compat = act.compatSkills || selected.compatSkills`, where a server override replaces the base list;
   - unique ids, known cards only, never the open card;
   - in the authored order.
3. **The two lists:**
   - **Phone list** = compat − linked.
   - **Desktop list** = the phone list − covered.
4. **Folding:**
   - More than 6 rows fold into one row: `<button class="sk-rel-more">ทั้งหมด N สกิล</button>` with an SVG chevron.
   - The row opens in place: a class toggle on both copies, with no rebuild.
   - The open state is `relOpen`, a Set of card ids kept for the visit.
   - An opened list with more than 8 rows uses the existing compact 2-column grid.
5. **Example, Chameleon Combo on BB (measured):**
   1. compat has 13 cards.
   2. 10 are linked by the desc, which leaves 3 for the phone list.
   3. 1 of those is covered by a toggle row.
   4. That leaves 2 on the desktop list: Left Stride and All Slain.

### D. Scale lock

There is one guard in `fitStageToScreen(force)`, placed right after `const isSkillLookup`:

```js
if (isSkillLookup && !force && fitHoldOn()){ fitHeld = true; return; }
```

- **The hold region:** `.sk-side` plus the two stat headers (`.sk-stats-panel .sk-class-badge`). The headers hold the collapse chevrons, PRESET, Revised Art and the enemy picker.
- **When the region is held:**
  - **Pointer half:** the last pointer position, hit-tested with `document.elementFromPoint`. Every toggle click replaces the panel under a still pointer, so enter and leave events are lost; a position test still works.
  - **Keyboard half:** focus is in the region, the focused element has client rects, and the last input was the keyboard. A `keydown` without Ctrl, Meta or Alt sets `fitHoldKey`; `pointerdown` clears it. A mouse click also focuses a button, so mouse focus must never hold. A shortcut moves no focus, so it must not arm the hold either: after a mouse click on a chevron, Ctrl+Z (the page's preset / enemy / Buff-Debuff undo, 19893) would otherwise hold its refit through the focus half until the next click or Tab, and on a desktop page that cannot scroll a card that grew would stay clipped.
- **Release:**
  - A content refit that was skipped (`fitHeld`) runs once the region is no longer held. This is checked on `pointermove`, on `pointerup`/`pointercancel` (deferred with `setTimeout(…, 0)`, so a tap elsewhere first lands its click), on the pointer leaving the window, and on `focusout` (deferred).
  - It never runs while a pointer button is down (`fitPtrDown`), so no refit can happen between mousedown and mouseup.
- **Forced refits:**
  - the skill page's window resize handler (26627);
  - `setToolZoom` (37174);
  - `showTool` (37354);
  - `renderHeroNow` on a new card (`skillSwitched = idSeen !== selected.id`, computed before the sync fit at 25629 and reused by the rAF fit at 25635; `idSeen` still holds the previous card there).

  The ResizeObserver, `renderPickerView`, the target solver's probe renders and the other tools all call it plainly and so respect the lock.
- **Focus restore:**
  - When the last input was the keyboard and focus was on a `button[data-dep-id]` inside the display element, `renderHeroNow` refocuses the same `data-dep-id` with `preventScroll`. This happens right after the `displayEl.innerHTML` rebuild and before the first fit.
  - The row shows a 2 px gold ring through `:has(button[data-dep-id]:focus-visible)`.
  - The `displayEl.contains` guard keeps focus away from the reach popup's toggles, which can share the same id.
- **In the validator sandbox:** `fitStageToScreen` returns early (the page is not a fit-screen tool there) before the guard. `document.activeElement` is undefined, and the listeners attach to the stub, which does nothing.

### E. Stat-panel collapse

- **Control:** an 18 px chevron button at the end of each header's second text line:
  - player: wrapped with the PRESET button in `<span class="sk-badge-line">`;
  - enemy: wrapped with the caption ค่าสถานะตัวละครเป้าหมาย.

  Each chevron carries `data-role="stats-collapse"`, `data-panel="player|enemy"` and `aria-expanded`.
- **State and storage:**
  - The state is a class on `.sk-stats-panel`: `is-player-collapsed` / `is-enemy-collapsed`.
  - `display:none` rules hide `.sk-stats-panel > .sk-controls` and `.sk-enemystat-controls > .sk-controls`. A class is used rather than the `hidden` attribute, because `[hidden]` loses to `.sk-controls{display:grid}` (3142).
  - The state is saved in `localStorage["12t-bible-stat-collapse"]` as `"player"`, `"enemy"` or `"player,enemy"`, inside try/catch. There is one state for every width, and both panels start expanded.
- **What stays visible:** the header rows and the Buff / Debuff row. The inputs stay in the DOM, so every reader of `.value`, the target solver, presets, enemy picks and Ctrl+Z work as before.
- **After a click:**
  - `fitStatDials()` runs on expand, because hidden rings measure 0.
  - Then `positionCombatLedger()` and `fitStageToScreen()` run. The stats panel is absolute, so the `.tool-shell` ResizeObserver never sees it change.
  - The light ball of a single changed stat whose ring is hidden starts from that panel's header (`classBadgeEl` / `.sk-enemy-badge`).
  - The chevron's `data-role` is excluded from `deltaClick`, so it is never a light source.

### F. Contracts that stay as they are

- **Toggle buttons and their markup:**
  - `depSinkAdd` merging and tag order; views draw nothing;
  - the first site wins the button kind; descDep registers first with INFO;
  - `cycleRanks`, `castDep2`, `lineNeedsToggle`, `hideOffDepLines` and `depLineDeps`;
  - every registration call that now returns `""` (descDepToggle and the cd / cast / dep / lck / bbToggles / ko / shield blocks);
  - the button markup itself: class first, `data-dep-id` before the rank / toggle attributes, the img inside, `aria-pressed` / `aria-label "… ระดับ r/max"`.
- **Labels:** `labelFor` / `iconFor`; the 20-letter shown name; the full label in the item `title`; `fitDepLabels()` right after `renderHeroNow();`; no `text-overflow` on the first `.sk-dep-item-name` rule.
- **Delta motion:** the flips, the old-picture hold, `WORSE_WHEN_ON`, comets from the pips, light toward revealed desc lines, `deltaValue` with its 4-space indent.
- **The rest of the page:**
  - the related-row look (ring, shadowed name, hover lift, focus outline);
  - `selectSkill` (server kept, onlyServer switch and restore, hash sync);
  - `compatSkills` data and `[COMPAT ERROR]`;
  - findSkillByMention's tiers;
  - the range popup's own toggles; the in-game tooltip modal;
  - the 820 px reference height, the 1.6x upscale cap, the tool zoom, `  stageScaleNow = scale;`, the `fitGameTipModal();` calls.

## Calls made

The owner will not be asked; each call has a one-line reason.

**Layout**

1. **One aside in the strip's old slot, placed by CSS only, with no render-time viewport branch.** This is grafted from the clean-component plan; it replaces the spine's `matchMedia` slot switch.
   - Reason: every dep button stays once in the display element; Tab order stays desc → toggles; the validator sees the shipped markup in every section; there is no re-render when the window crosses 900 px.
2. **The related rows are written twice:** inside the aside for desktop and as `.sk-rel-phone` for phones, with CSS showing one.
   - Reason: CSS cannot put one node both beside the card and after the enemy panel, and the two lists differ by design. Measured cost (rule C.1, at `b11dfc4`): 1,423 desktop rows and 1,670 phone rows over 1,649 tabs (about 1 each); 27 at worst.
3. **900 px and up is desktop; 899 px and below is phones.** The `.sk-hero{position:relative}` / ‹ › block (6598) moves to `max-width:899px`.
   - Reason: the JS already treats `innerWidth >= 900` as desktop and the phone block is `max-width:899px`; at exactly 900 px the panel would otherwise anchor to `.sk-hero`. Side effect: the ‹ › buttons now show below 900 px only, consistent with the rest of the desktop layout.
4. **Stacking:** the panel keeps the rail's z-index 4, and a hovered chip lifts to 5.
   - Reason: desc status pop-ups (lifted to 5), the stats panel (10) and Test results (15) keep their order, and the chips' odds tooltips open in the panel's column.
5. **No box on the panel. Rows get mockup B's faint gold wash over an ink mix and a 1 px gold edge, made with `color-mix` of `--gold` / `--ink`. No `THEME_SURFACES` entry.**
   - Reason: mockup B; the rows paint no `--panel`; the related rows keep the open layout of 2026-10-18.

**Toggle rows**

6. **One group order everywhere:** gear, then conditions, then ดาเมจ, เวลา, ระยะ, คำอธิบาย. Skill rows go by `SKILL_INTERNAL_ID`; gear and conditions keep insertion order. Phones hide the headings. `[DEP ORDER ERROR]` and `[RABBIT SHOT ERROR]` are rewritten for it.
   - Reason: this is the spec's order, and one DOM means one order.
7. **A toggle's group is the lowest group any of its tags maps to.** HEAL goes to ดาเมจ; an unknown tag goes to คำอธิบาย. Gear = non-skill with an `item_` icon.
   - Reason: the spec's first-match rule; HEAL is DMG's twin on heal cards; measured: no toggle changes group with a rank or a toggle state (0 of 3,788 renders).
8. **Headings show only when the toggle rows span two or more groups (265 tabs). The related list always keeps its title สกิลที่เกี่ยวข้อง.**
   - Reason: headings then depend only on the toggle list, which never changes with a rank or a toggle state, so a related-list change can never add or remove a heading above a toggle.
9. **The ring icon stays the real toggle button: img inside, pips in `.sk-dep-btncol`.** It is drawn as a ring (the Revised Art pattern: the pop and grey on the ring, the img zoomed 1.3x). A decorative switch on the right mirrors `.on` and waits for the flip through `--flip-delay`.
   - Reason: mockup B (spec call #2) without touching the button markup that `depStates`, `flipStart`, `pipPoint` and the validator read; this also fixes the spine's clipped pop.
10. **Toggle zones are the ring and the switch only.** The switch forwards with `btn.click()`. Pips and tags stay inert. The name line never toggles.
    - Reason: mockup B says "switch = toggle, name = go to that card"; with fixed toggle columns, a label that changes width can never move the toggle/link boundary. A pip that acted as a rank picker is backlog §5.4, not this change.
11. **Name links go on skill rows and condition rows.** The card is the one the shown label names, else the one whose id is the icon key. Never gear, the open card, a stub, or an `item_` / `mount_` / `status_` key.
    - Reason: the name opens what it says. Condition links close the hidden-line hole (Formless Path on 27 Reborn Panda cards, Reactor Core, Runic Inferno, Heaven Breath, Crown of Stars, Poison Arrow, Mark of Slayer, Power / Armor Break).
    - Measured at plan time: every skill row gets a link; 191 condition rows link, across 10 condition toggles; label and icon never disagree.
12. **Merged rank-5 toggles:** the name opens the card shown at the current rank. Every card the row can show at any rank counts as covered. Cat Power links Power Seven. kaiserLv on King Kaiser is a condition with no link.
    - Reason: the spec's "a related skill that is also a toggle appears once, as a toggle row"; the related list then cannot change with a rank.
13. **Condition rows link to their card but do not cover it.**
    - Reason: a condition names a state, not the skill, so its card keeps its own related row when the desc does not link it (avoids hiding Mark of Slayer / Runic Inferno behind a differently named row).
14. **The light source is the clicked toggle first, then the first rising one, then the first.**
    - Reason: gear now comes first in the DOM, so DOM order must not pick the source (Rabbit Combo: Customized Shotgun on while the Gatling Gun is on).
15. **No RANGE tag colour and no extra gear caption.**
    - Reason: neither is in the spec (YAGNI); the group headings already caption gear and conditions.
16. **Size for 12 toggle rows plus 4 headings** (Bison Combo and Left Stride on Reborn), with 40 px rows.
    - Reason: those are the measured maxima (the spec's 10 was BB only). The tallest panel is Chameleon Combo on Reborn (11 rows, 4 headings, 2 related rows). Its height, step by step:
      1. rows: 11 × 40 = 440
      2. headings: 4 × 18 + 3 × 6 = 90 (18 px each, plus a 6 px top margin on every heading but the first)
      3. gaps: the strip is a flex column with a 4 px gap, and its 15 items (11 rows + 4 headings) have 14 gaps between them: 14 × 4 = 56
      4. related list: 14 + 25 + 2 × 40 + 4 = 123
      5. total: 440 + 90 + 56 + 123 = 709 px

**Related list**

17. **"Already linked" = `findSkillByMention(t, act)` over every `**t**` in the raw desc of the tab on screen, plus the `liveCheck` note.** Hidden lines count; status pop-ups and the in-game tooltip notes do not.
    - Reason: spec call #4 and its hidden-lines rule; `liveCheck` renders the same gold links inside the desc box.
18. **The union of the desc over every heroDep rank (suggested by two judges) is not built.**
    - Reason: measured over 3,788 toggle-state renders, it still leaves 12 Reborn toggle cases changing the lists. Related rows sit below every toggle and below the fold row, so a list change never moves anything under a repeated click; the stable part (rows and headings) is guarded by a check instead.
19. **Lists: the phone list is compat minus desc links, so toggle cards are included; the desktop list also drops covered cards.**
    - Reason: the spec's phone wording; phone names stay inert, so the list is their only touch path to those cards.
20. **More than 6 rows fold into "ทั้งหมด N สกิล" with an SVG chevron, opened in place.** The open state is per card for the visit (`relOpen`, shared by both copies). An opened list of more than 8 rows uses the compact 2-column grid. Rows stay in authored compat order.
    - Reason: the spec suggests about 6; "ใช้กับ" reads wrong for sibling sets (Black Servant's zombies); opening in place avoids a rebuild and a stray heroDelta pass; the SVG keeps the two-font rule; authored order is today's rail order.
21. **The Reborn change-note hint (19122) becomes location-free: `" (เปิดสวิตช์ของสกิลนั้นเพื่อดูผล)"`. Black Servant's desc ("การ์ด Zombie ในสกิลที่เกี่ยวข้อง") stays.**
    - Reason: the toggles sit beside the card on desktop and under the desc on phones; the title สกิลที่เกี่ยวข้อง is kept on both.

**Fit and scale lock**

22. **compH counts the panel's bottom (`offsetTop + offsetHeight`) when it is visible. compW keeps 1500 / 1220 with a visible panel and 1420 / shell width without. The panel is measured by `offsetHeight`, so a hidden skill page no longer widens Stat Roll. The 820 px reference does not change.**
    - Reason: desktop never scrolls, so no row may sit off screen; the spec says no-panel cards lay out as today; this fixes the latent leak at 37233.
    - Worked example, step by step (the panel rarely sets the scale):
      - At 1366 × 768:
        1. availH = 768 − 42 − 24 = 702
        2. scaleH = 702 / 709 = 0.990
        3. scaleW = (1366 − 24) / 1500 = 0.895
        4. The width limits the scale to 0.895.
      - At 1280 × 720:
        1. availH = 720 − 42 − 24 = 654
        2. scaleH = 654 / 709 = 0.922
        3. scaleW = 1256 / 1500 = 0.837
        4. The width limits the scale to 0.837.
23. **The hold region is `.sk-side` plus `.sk-stats-panel .sk-class-badge`.** The dials do not hold.
    - Reason: the collapse chevrons, the enemy picker and Revised Art are click targets that a refit could move; typing a stat should still refit.
24. **The pointer is a hit-tested point; focus holds only after keyboard input. Release is deferred until after the click, and never runs while a button is down.** These are grafts from the minimal-DOM plan, plus the button-down guard.
    - Reason: rebuilt nodes lose enter / leave events; mouse focus would hold the scale after the pointer left; a refit between mousedown and mouseup could split a click.
25. **Forced refits:** window resize, tool zoom, tool switch, and a new card (`idSeen !== selected.id`).
    - Reason: the spec's resize rule; zoom and tool switch are explicit user actions; a new card must fit even with the pointer on the panel.
26. **Keyboard focus is restored by `data-dep-id` after a keyboard-driven rebuild.**
    - Reason: otherwise every Enter drops focus to `<body>` and releases the lock (backlog §6.1).
27. **The opened list stays under the lock while the pointer is on it.** Rows that fall below the window are reached after the pointer leaves the panel and the page refits to fit them. There is no inner scroll and no downward-only refit.
    - Reason: the spec says "opening grows the panel downward only"; any refit rescales from the top centre and would move the panel.

**Stat panels**

28. **An 18 px chevron sits at the end of each header's second text line** (after PRESET, after the enemy caption). It joins `THEME_SURFACES.raised`.
    - Reason: it takes no width from the class name (about 103 px) or Revised Art and stays clear of the enemy's ⓘ; it paints `--panel-2` like `.sk-enemy-info-btn`.
29. **The state is classes on `.sk-stats-panel` with `display:none` rules. One `localStorage` key for every width; both panels start expanded. The Buff / Debuff row stays visible.**
    - Reason: the glow pass rewrites the dial wrappers' `className`; `[hidden]` loses to `display:grid`; the spec gives one state per panel; Buff / Debuff is not a dial and is a light source.
30. **A hidden stat ring's light starts from the centre of its header** (`classBadgeEl` for the 9 player inputs, `.sk-enemy-badge` for the enemy).
    - Reason: the spec's "that panel's header"; both headers stay visible.
31. **`[PANEL ERROR]` keeps the `enemystat-toggle` ban (the old whole-panel hide) with a reworded message, and gains checks for the new controls.**
    - Reason: the owner reversed the ban on collapsing, not on the old toggle.

**Process and validation**

32. **No Ctrl+Z for the panel, the list fold or the collapse; the toggle clicks are unchanged.**
    - Reason: the spec's non-goal ("no change to what the toggles do"); the same control reverses view state; putting view state on the preset / enemy / Buff-Debuff stacks would make Ctrl+Z skip the stat changes it should undo.
33. **The `compatSkills` data rules and the listing rule stay in bible-card-fields. The panel's layout and behaviour go in bible-skill-page-ui, which points back to it.**
    - Reason: this is today's split; the data and the display change for different reasons.
34. **Validator:**
    - **Kept:** the strip wrapper and the button markup (one regex is loosened for `data-dep-group`).
    - **New in the plain run:**
      - count guards on labels and order;
      - the grouped-order and heading check;
      - side-panel invariants on every server tab, inside the universal render loop, which now renders every tab (the render-throw check). Measured cost: about 0.4 s;
      - spot checks;
      - `[PHONE LAYOUT ERROR]` and `[SCALE LOCK ERROR]` source pins.
    - **New under `--full`:** a row-and-heading skeleton stability check inside the existing BB dep sweep, at no extra renders.
    - Reason: every new branch gets one check that fails if it breaks, and the guards stop silent loss of coverage.
35. **Two local commits:**
    - A: stat collapse, the smaller and independent change.
    - B: the panel, groups, related list, placement and lock together.

    Each commit gets its own changelog entry. No push.
    - Reason: no commit ships a panel without its lock or with an interim layout; one changelog entry per feature (fixes the spine's six commits).
36. **Two browser passes only** (after A, and after the panel is complete), with Playwright on a local http server.
    - Reason: owner rule (browser checks are slow; allowed for a major layout change); `file://` is blocked.
37. **Delete:**
    - the `.sk-compat-name` shrink loop (25601-25621, dead since the 2026-10-18 open layout);
    - the rail CSS (4885-4900) and `.sk-compat-row` (4907-4908);
    - the `-single` / `-few` item classes, which have no CSS.

    **Keep** every registration call that returns `""`.
    - Reason: the deleted code is unused, while those registration calls are what register the descDep, infoDeps and other toggles.

## Steps

Global rules for every step:

- **Patching:**
  - One patch script per step, `<scratch>/panel/stepN.js`, written with the Write tool; it lists every edit for every file the step touches. Run it with `--dry`, then for real, then run the validator.
  - Never `git checkout` / `restore` / `reset --hard` / `stash` `index.html`; recover from the script's `.bak` copy.
- **Reading the page:** never open `assets.js`, never read `index.html` whole (grep, then read line ranges), and never read base64.
- **Guide manager:** do not run `scripts/add_guide.js` until commit B is done; it commits and pushes.
- **Commits:**
  - Commit locally on the current branch, as every recent commit does, only when the build session has the owner's go-ahead to commit; otherwise stop with everything validated.
  - Never stage `+15 acc/`, `+20 boots/`, `RB_icon*.png`, `Reborn/`, `image.png`, `novice.png` or `sea.png`.

### Step 0. Baseline, harness, oracle (no repo edits)

**Changes:** none in the repo.

1. **Starting point:**
   - `git status --short` and `git log -1`: HEAD is `de6926a` (the spec and mockups, committed on top of `b11dfc4` without touching the page or the validator, so the line numbers here still hold) or the owner's later commit, and `index.html`, `validate_skills.js` and the rule files are unmodified.
   - If `index.html` is dirty, make a WIP commit first (CLAUDE.md §1.3).
2. **Baselines:**
   - `node scripts/validate_skills.js > <scratch>/panel/base_plain.txt`. Expected (measured at plan time):
     - exit 0, about 13 s;
     - `Verified 787 hero render checks`, `6733 dependency strip checks`, `29 stat panel structure checks`, `20 Chiroptophobia checks`, `12 toggle-revealed desc line checks`, `13 toggle-only line and second cast toggle checks`.
   - The same with `--full` into `base_full.txt`.
3. **`<scratch>/panel/patch_lib.js`** exports `apply(file, edits, { dry })`, where each edit is `{ name, find, replace, count = 1, marker }`. It:
   - reads UTF-8 and refuses a file with any lone LF or lone CR (`/(?<!\r)\n/`, `/\r(?!\n)/`);
   - turns `find` and `replace` into CRLF;
   - requires the count of `find` to equal `count`, and the count of `marker` (a distinctive piece of the replacement) to be 0 before applying;
   - lists **every** problem before stopping;
   - copies the file to `<scratch>/panel/<base>.<Date.now()>.bak`;
   - replaces with `split(find).join(replace)`, never `String.replace`, so `$` stays literal;
   - re-checks CRLF and parses: for `index.html`, `new vm.Script()` over the text from `indexOf('<script>')` to `lastIndexOf('</script>')`, sliced exactly as `validate_skills.js` 71-73 does; for `.js`, the whole file;
   - writes once and prints one line.

   `--selftest` runs on a temporary copy and proves:
   - a 1-match edit applies;
   - 0-match and 2-match anchors are refused;
   - a re-run is refused because its marker is present;
   - a replacement that breaks the script fails the parse check and leaves the file untouched.
4. **`<scratch>/panel/changelog_add.js "<subject>"`:** the existing scratch helper plus a backup. It refuses `"` and `\`, and anchors on `const CHANGELOG_DATA = {\r\n  recent30Days: CHANGELOG_ARCHIVE.recent30Days,\r\n  entries: [\r\n` (36560).
5. **`<scratch>/panel/oracle.js`:** an independent model of the final rules, run once against HEAD.
   - It loads the validator prelude, cut at the ``console.log(`Auditing`` line, with `new Function` (the pattern of the session's earlier probes).
   - It injects two hooks:
     - `const depStripHtml = renderDepStrip();` is replaced with a capture of `[...depSink.entries()]`, `descStr`, `activeSelected` and `rank`;
     - `window.__depOrderKey / __getDepRank / __depLineIcon` are exposed before `function onSearchInput(){`.
   - It renders every non-`soon` card on every `getAvailableServers` tab at max rank with default deps. It selects twice, `_setServer(srv); _selectSkill(sk); _setServer(srv); _selectSkill(sk)`, so a server-exclusive card before it cannot pull the server back.
   - It applies the rules of Architecture B and C in its own code, with C.1 exactly as `renderSidePanel` codes it: the desc at the current rank and heroDep rank, plus `liveCheck`. It never merges the desc over every heroDep rank (the rule call #18 rejects), or the Step 3 / Step 7 parity runs would disagree with the page on the tabs whose lists change with a toggle.
   - It writes `<scratch>/panel/oracle.json`, one record per tab: `order` (`id:group>link`), `heads`, `desk`, `phone`, `foldDesk`, `foldPhone`.
6. **`<scratch>/panel/peek.js <cardId> [server]`** (debug aid): prints one render's strip, aside and phone-list slices.
7. **Local server:**
   - `py -m http.server 8765 --bind 127.0.0.1` from the repo root, run in the background.
   - Pages: `http://127.0.0.1:8765/12t_projects/bible/index.html#skill-details/<id>[?server=reborn|tot|tto]`.
   - Load the Playwright MCP tools with ToolSearch: `browser_navigate`, `browser_resize`, `browser_run_code_unsafe`, `browser_evaluate`, `browser_console_messages`, `browser_take_screenshot`.

**Checks:**

- Both baselines exit 0 with the counts above.
- `node <scratch>/panel/patch_lib.js --selftest` passes.
- The oracle summary matches the plan-time numbers below. A difference means the card data changed since `b11dfc4`; explain it before going on.

| Oracle figure (plan time, 1,649 non-stub tabs) | Value |
|---|---|
| Tabs with a desktop panel / without | 1,135 / 514 (BB: 274 of 670 cards without) |
| Tabs with headings | 265 |
| Folded lists: desktop / phone | 54 / 55 |
| Most toggle rows | 12 (`bison_nAttack` on Reborn) |
| Longest related list | 27 (`panda_formlessPath` on Reborn) |
| Condition rows with / without a link | 191 / 27 (10 toggles: chmTargetPoison, slayerRaceMatch, reactorOverdrive, runicInfernoFire, rebornHbNoSp, formlessRoll, crownX2, targetPowerBreak, targetArmorBreak, mountType) |
| Skill rows without a link | 0 |
| Related rows: desktop / phone | 1,423 / 1,670 (rule C.1, measured at `b11dfc4`; 1,419 / 1,613 belongs to the merged-desc rule that call #18 rejects, so getting those numbers means the oracle merged the desc) |
| Tallest panel (estimate at 40 px rows) | about 709 px (`chameleon_nAttack` on Reborn: 11 rows, 4 headings, 2 related; call #16) |

### Step 1. Collapsible stat panels (commit A)

**Changes in `index.html`:**

- **Mount template (18627-18666).** Player badge text column (18629-18632): keep the name span, and wrap PRESET with the chevron:

  ```html
  <span class="sk-badge-line"><button type="button" class="sk-preset-open" data-role="preset-open" title="ชุดสเตตัส" aria-haspopup="dialog">PRESET 1</button><button type="button" class="sk-stats-collapse" data-role="stats-collapse" data-panel="player" aria-expanded="true" aria-label="ย่อ / ขยายค่าสถานะของคุณ" title="ย่อ / ขยาย"><svg viewBox="0 0 24 24" aria-hidden="true"><path d="M6 9l6 6 6-6"/></svg></button></span>
  ```

  Enemy caption (18658): `<span class="sk-badge-line"><span class="sk-class-badge-sub">ค่าสถานะตัวละครเป้าหมาย</span>` followed by the same button with `data-panel="enemy"` and `aria-label="ย่อ / ขยายค่าสถานะเป้าหมาย"`, closed by `</span>`.

  What this keeps:
  - the enemy caption still appears exactly once;
  - neither label contains ค่าสถานะตัวละครของคุณ or `enemystat-toggle`;
  - both grids still open with an exact `<div class="sk-controls">` and keep 9 cells;
  - nothing new sits between `.sk-stats-panel` and `.sk-multihit-layer` except inside the badges.
- **CSS.** After the class-badge block (it ends with the `@media (max-height: 820px)` badge rules at 3137-3141), with a comment pointing to the spec:

  ```css
  .sk-badge-line{display:flex; align-items:center; gap:4px; min-width:0}
  .sk-badge-line .sk-preset-open{min-width:0}
  .sk-stats-collapse{flex:none; width:18px; height:18px; padding:0; display:flex; align-items:center; justify-content:center; border-radius:50%; border:1px solid var(--line); background:var(--panel-2); color:var(--muted); cursor:pointer}
  .sk-stats-collapse svg{width:11px; height:11px; fill:none; stroke:currentColor; stroke-width:2.4; stroke-linecap:round; stroke-linejoin:round; transition:transform .15s ease}
  .sk-stats-collapse:hover{color:var(--gold); border-color:var(--gold)}
  .sk-stats-collapse:focus-visible{outline:2px solid var(--gold); outline-offset:2px}
  .sk-stats-panel.is-player-collapsed [data-panel="player"] svg, .sk-stats-panel.is-enemy-collapsed [data-panel="enemy"] svg{transform:rotate(-90deg)}
  .sk-stats-panel.is-player-collapsed > .sk-controls, .sk-stats-panel.is-enemy-collapsed .sk-enemystat-controls > .sk-controls{display:none}
  ```
- **`THEME_SURFACES.raised` (line 35):** `".sk-enemy-info-btn", ` becomes `".sk-enemy-info-btn", ".sk-stats-collapse", `.
- **Mount JS**, right after `if (statsPanelEl) statsPanelEl.addEventListener("input", fitStatDials);` (18958):

  ```js
  // Stat panel collapse (spec 2026-10-29): each header's chevron hides that panel's dials; view state, remembered per browser, never an undo step.
  const STATS_COLLAPSE_KEY = "12t-bible-stat-collapse", statsCollapse = { player: false, enemy: false };
  try { String(localStorage.getItem(STATS_COLLAPSE_KEY) || "").split(",").forEach(k => { if (k === "player" || k === "enemy") statsCollapse[k] = true; }); } catch (e) {}
  function applyStatsCollapse(){
    if (!statsPanelEl) return;
    statsPanelEl.classList.toggle("is-player-collapsed", statsCollapse.player);
    statsPanelEl.classList.toggle("is-enemy-collapsed", statsCollapse.enemy);
    $$('[data-role="stats-collapse"]', statsPanelEl).forEach(b => b.setAttribute("aria-expanded", String(!statsCollapse[b.dataset.panel])));
  }
  applyStatsCollapse();
  if (statsPanelEl) statsPanelEl.addEventListener("click", (e) => {
    const b = e.target.closest && e.target.closest('[data-role="stats-collapse"]'); if (!b) return;
    const k = b.dataset.panel; statsCollapse[k] = !statsCollapse[k];
    try { localStorage.setItem(STATS_COLLAPSE_KEY, ["player", "enemy"].filter(x => statsCollapse[x]).join(",")); } catch (e2) {}
    applyStatsCollapse();
    if (!statsCollapse[k]) fitStatDials();   // the rings measured 0 while hidden
    positionCombatLedger(); fitStageToScreen();   // the stats panel is absolute: the shell's ResizeObserver never sees it change
  });
  ```
- **After `const classBadgeEl = …` (19041):** `const enemyBadgeEl = $(".sk-enemy-badge", root);`
- **`deltaClick` exclusion (23252):** append `, [data-role='stats-collapse']` to the `el.matches(…)` list.
- **`heroDelta` single-stat branch (23455-23457):** replace `volley(centerOf(el), …)` with:

  ```js
  const from = el.getClientRects().length ? el : (idx >= 9 ? enemyBadgeEl : classBadgeEl);   // a collapsed panel hides its rings: the light leaves from its header
  volley(centerOf(from), idx >= 9 ? !higher : higher, { tone: color });   // statInputs(): 9 player inputs, then the enemy's
  ```

  `statColorFor` / `getComputedStyle(el)` keep reading the hidden input; `--stat-*` comes from `:root`.

**Changes in `scripts/validate_skills.js` (`[PANEL ERROR]`, 1006-1044):**

- Reword the 1018 message to: "the old whole-panel enemy show/hide toggle (enemystat-toggle, removed 2026-09-19) stays removed; since 2026-10-29 each panel collapses its dials from its header". The count stays 0.
- Add six `check(…)` calls:
  - `playerBadge` includes `data-role="stats-collapse" data-panel="player"`;
  - `enemyBadge` includes `data-role="stats-collapse" data-panel="enemy"`;
  - `html` includes the exact `display:none` rule text above;
  - `html` includes `"12t-bible-stat-collapse"`;
  - `html` includes `[data-role='stats-collapse']`;
  - `html` includes `getClientRects().length ? el : (idx >= 9 ? enemyBadgeEl : classBadgeEl)`.

**Docs (same commit),** written through `patch_lib` (the Markdown files are CRLF), in `.claude/skills/bible-skill-page-ui/SKILL.md`:

- **"Stat dials" bullet (33):** collapse chevrons; dials `display:none` while collapsed; inputs kept; `fitStatDials` on expand; key `12t-bible-stat-collapse`; the Buff / Debuff row stays.
- **Delta-motion bullet (36):** a stat whose ring is collapsed sends its light from its panel header.
- **"Class Badge in the Player Stat Panel" (105-112):**
  - "Enemy panel is always visible" becomes "the enemy header is always visible; its dials collapse".
  - The keyboard grid bullet adds: a collapsed grid takes no focus.
  - The `[PANEL ERROR]` line separates the old show/hide toggle (still banned) from the collapse chevrons (required).
- **"Target value on a stat chip" (182):** works while a panel is collapsed; the hidden input is written and the light starts at the header.

Also stage this plan file (untracked) in commit A. The spec and the mockups are already committed (`de6926a`).

**Patch:** `<scratch>/panel/step1.js` (`index.html` + validator) and `<scratch>/panel/docs1.js`.

**Checks:**

- Dry runs list every anchor at count 1 with its marker at 0; parse and CRLF pass.
- `node scripts/validate_skills.js`: exit 0; `stat panel structure checks` goes from 29 to 35; every other count is unchanged; `[ENEMY PICKER ERROR]` and `[CHIP TARGET ERROR]` are silent. There is no FATAL at mount, because the `localStorage` read is inside try/catch.
- **Browser pass A** (Playwright, local server) at 1920×1080, 1280×720 and 390×844, on the BB and Reborn looks:
  - Each chevron hides only its own grid (its `offsetHeight` becomes 0). The header row and the Buff / Debuff row stay; the enemy header moves up when the player panel collapses.
  - At 1280×720 (compact density), `.sk-badge-line` does not overflow (`scrollWidth <= clientWidth`) and PRESET still ends in "…".
  - A reload keeps the state. Tab never reaches a hidden input. After expanding, every dial has `scrollWidth <= clientWidth`.
  - With both panels collapsed, on `monkey_fireBall` (a cooldown chip and a damage row on BB and Reborn; it reads the player's AGI and the enemy's DEF), record every `.sk-shot` the next volley adds (a MutationObserver on `document.body`):
    - (a) raise AGI with a scripted untrusted `input`;
    - (b) a chip target edit on the cooldown chip that asks for a shorter cooldown; the toast reads `ปรับ AGI old → new`;
    - (c) set the enemy's DEF to 50 with a scripted untrusted `input` (this sets `enemyStatsCustom`; its own volley is not measured), then pick Carron again in the enemy picker, which moves only DEF back to 2. Carron, the default target, has every stat at 2 and the other 8 presets have all eight far above it, so a plain pick moves several stats at once; re-picking Carron without the hand edit does nothing (`selectEnemyPreset`, 19824).

    Read each shot's path from its animation, not from its rectangle: the `translate(Xpx, Ypx)` of the first and the last frame of `shot.getAnimations()[0].effect.getKeyframes()` (viewport points, since `.sk-shot` is `position:fixed` at 0,0). A field that got better sends its light out of the source (the first frame); one that got worse sends a red comet (`.is-red`) from its chip back into the source (the last frame), so the first shot's rectangle can sit on a chip. Every shot must have one end of its path inside its header's rectangle grown by 30 px: the player header (`classBadgeEl`) for a and b, `.sk-enemy-badge` for c.
  - (d) Type in a dial, then click its chevron within 800 ms: no end of any shot's path lies within 40 px of (0,0).
  - Ctrl+Z after (b) restores the stat (expand to read it). Presets and buffs still change the chips. 0 console errors.
- `node <scratch>/panel/changelog_add.js "<subject A>"`, then the plain validator again, then commit A. Subject A:

  `feat(bible): skill details: the player and enemy stat panels each collapse to their header row (a chevron beside PRESET and beside the enemy caption, remembered per browser); collapsed dials still drive every number and their light balls start from the header`

### Step 2. Toggle rows: groups, headings, name links, switch element, light source

**Before patching (BEFORE probe).**

- Run the drift probe from Step 7 on the current page (the strip under the desc), with the selector `.sk-dep-strip button[data-dep-id]`, at 1366×768 on `bat_cAttack` (BB) and at 1920×1080 on `bison_nAttack` (Reborn).
- Save the results to `<scratch>/panel/before.json`.
- At least one click must drift more than 0.5 px; this proves the probe can see today's problem. If none does, choose a card whose toggle reveals a desc line until one does.
- **Timing (for Step 7 item 13):** at 1920×1080 on Reborn, click one toggle 20 times by its id, `[data-role="display"] button[data-dep-id="runicInfernoFire"]` on `monkey_runicInferno` and `…="fatalStrike"` on `chameleon_nAttack`, timing each click with `performance.now()` around `btn.click()` plus 2 frames. Runic Inferno is the card with a toggle and the longest related lists (19 rows, which the panel writes twice: 19 desktop + 19 phone); Chameleon Combo has 11 toggle rows. Save the median and the slowest click of each card to `before.json`.

**Changes in `index.html`:**

- **After `DEP_TAG_COLORS` (22316):**

  ```js
  // Toggle groups (spec 2026-10-29): gear, then conditions / modes (both in insertion order), then the skill toggles by what they change, each
  // group by internal skill ID. A skill toggle joins the first group one of its tags names (HEAL = damage on heal cards; an unknown tag = info).
  // Measured 2026-10-29: no toggle changes group with a rank or a toggle state, so the rows never reorder between two clicks.
  const DEP_GROUPS = [["gear", "อุปกรณ์"], ["cond", "เงื่อนไข / โหมด"], ["dmg", "ดาเมจ"], ["time", "เวลา"], ["range", "ระยะ"], ["info", "คำอธิบาย"]];
  const DEP_TAG_GROUP = { DMG: 2, HEAL: 2, HITS: 2, KO: 2, CHANCE: 2, SHIELD: 2, STATS: 2, CD: 3, CAST: 3, DUR: 3, RANGE: 4, INFO: 5 };
  const depGroupOf = (e, k) => k !== Infinity ? Math.min(...e.tags.map(t => DEP_TAG_GROUP[t] || 5)) : (String(e.dep.icon || "").startsWith("item_") ? 0 : 1);
  // The card a toggle row's name opens at rank r: the card its label names (findSkillByMention, the desc's own link rule), else the card whose
  // id is the key of the picture it shows; never the open card, a stub, gear, a mount or a status picture.
  function depLinkCard(dep, r, act){
    const ok = (sk) => sk && sk.id !== selected.id && !sk.soon ? sk : null;
    const named = ok(findSkillByMention(String(dep.labelFor ? dep.labelFor(r) : dep.label).replace(/ \(.*$/, ""), act));
    if (named) return named;
    const stem = depLineIcon(dep.iconFor ? dep.iconFor(Math.max(1, r)) : dep.icon);
    return /^(item|mount|status)_/.test(stem) ? null : ok(SKILLS.find(s => s.id === stem));
  }
  ```
- **`renderDepStrip` (22363-22370)** becomes `renderDepStrip(act)`:

  ```js
  function renderDepStrip(act){
    const rows = [...(depSink ? depSink.values() : [])].filter(e => !Array.isArray(e)).map((e, i) => { const k = depOrderKey(e.dep); return { e, i, k, g: depGroupOf(e, k) }; })
      .sort((a, b) => (a.g - b.g) || (a.k - b.k) || (a.i - b.i));   // Infinity - Infinity is NaN: gear and condition rows keep insertion order
    if (!rows.length) return "";
    const heads = new Set(rows.map(x => x.g)).size > 1;
    return `<div class="sk-dep-strip">` + rows.map(({ e, k, g }, n) => {
      const name = `<span class="sk-dep-item-name">${e.label}</span>`, link = g ? depLinkCard(e.dep, getDepRank(e.dep), act) : null;   // gear rows never link
      return (heads && (!n || rows[n - 1].g !== g) ? `<p class="sk-dep-group-h" data-dep-group="${DEP_GROUPS[g][0]}">${DEP_GROUPS[g][1]}</p>` : "")
        + `<div class="sk-dep-item" data-dep-order="${k === Infinity ? "" : k}" title="${e.full}" data-dep-group="${DEP_GROUPS[g][0]}"><span class="sk-dep-btncol">${e.button}${depPipsHtml(e.dep)}</span>`
        + `<span class="sk-dep-item-text">${link ? `<button type="button" class="sk-dep-link" data-skill-id="${link.id}">${name}</button>` : name}<span class="sk-dep-item-tags">${e.tags.map(tg => `<span class="sk-dep-tag" style="--tag-c:var(${DEP_TAG_COLORS[tg] || "--muted"})">${tg}</span>`).join("")}</span></span>`
        + `<i class="sk-dep-sw" aria-hidden="true"></i></div>`;
    }).join("") + `</div><!--/sk-dep-strip-->`;
  }
  ```
- **Call site (25491):** `renderDepStrip()` becomes `renderDepStrip(activeSelected || selected)`.
- **`heroDelta` (23358-23378):**
  - `flips.push({ b, up: …` becomes `flips.push({ b, id, up: …`;
  - `const src = flips.find(f => f.up) || flips[0];` becomes `const src = flips.find(f => f.id === prev.clicked) || flips.find(f => f.up) || flips[0];   // the clicked toggle first: DOM order (gear before skills) must not pick the light's source`.
- **Comments:**
  - depSink (22279-22281): "drawn once in the side panel's toggle strip (beside the card on desktop, under the description on phones)";
  - depOrderKey (22337-22339): "inside its group".
- **CSS after the strip block** (after `.sk-dep-tag{…}`, 6541; must sit after the base `.sk-dep-item-name` rule at 6535 so `[DEP LABEL ERROR]`'s first match stays the base rule):

  ```css
  .sk-dep-group-h, .sk-dep-sw{display:none}   /* desktop side panel only (below) */
  .sk-dep-link{display:flex; min-width:0; max-width:100%; margin:0; padding:0; border:0; background:none; color:inherit; font:inherit; text-align:left; cursor:pointer}
  .sk-dep-link > .sk-dep-item-name{min-width:0}   /* fitDepLabels still measures the name inside the link */
  @media (max-width:899px){ .sk-dep-link{pointer-events:none; cursor:default} }   /* phones keep today's strip: only the icon reacts */
  ```

**Changes in `scripts/validate_skills.js`:**

- **3r header comment (2992-2993):** point to the 2026-10-29 spec; every dep button lives once in `.sk-dep-strip`, inside the side panel.
- **Label check (3032-3039):**
  - the regex becomes `/<div class="sk-dep-item" data-dep-order="\d*" title="([^"]*)" data-dep-group="[a-z]+"><span class="sk-dep-btncol">[\s\S]*?<span class="sk-dep-item-name">([^<]*)<\/span>/g`;
  - add a guard: if the number of matches is not the item count, fail `label check matched N of M items`;
  - the comment's "136 px column" rationale becomes "the panel's name column (about 166 px at 13 px) on desktop; phones wrap at 760 px and below".
- **Order check (3041-3045)** is rewritten to understand groups:
  - `GROUPS = ["gear","cond","dmg","time","range","info"]`;
  - entries come from `/<div class="sk-dep-item" data-dep-order="(\d*)" title="[^"]*" data-dep-group="([a-z]+)"/g`.

  It fails (`[DEP ORDER ERROR]`) when:
  - the number of entries is not the item count;
  - an entry has an unknown group, or a group and key that disagree (groups 0-1 have no key, skill groups have one);
  - the groups go backwards, or keys descend inside a skill group;
  - the headings (`/<p class="sk-dep-group-h" data-dep-group="([a-z]+)">/g`) are not exactly the distinct groups in order, when there are 2 or more (none otherwise);
  - a heading does not come right before its group's first row. To check this, walk the heading and row tokens in order and require each row's group to equal the last heading's group.
- **Spot checks after 3155,** using `stripOf` / `itemOf` plus two helpers:
  - `headsOf(strip)` = the heading texts joined with `|`;
  - `groupOf(strip, depId)` = the `data-dep-group` of the item that holds that button.

  Expected results:
  - `bison_nAttack`: headings `อุปกรณ์|เงื่อนไข / โหมด|ดาเมจ`, and `itemOf(…,"bruteStrength")` includes `class="sk-dep-link" data-skill-id="bison_bruteStrength"`;
  - `monkey_fireBall`: `rapidFire` and `instantCast` are both in group `time`;
  - `rabbit_nAttack`: headings `อุปกรณ์|ดาเมจ`;
  - `chameleon_leftStride`: `itemOf(…,"chmTargetPoison")` includes `data-skill-id="chameleon_poisonArrow"` (a condition link).
- **`[RABBIT SHOT ERROR]` (2213-2218, `--full`):** the expected list becomes `["rabWeapon","rabEquip","rabW59","rabHyperShot","rabShotgun","rabBouncing","rabExtravagance"]`, with the message "gear in insertion order, then the damage toggles by internal skill ID (#131, #353, #401, #443)".
- **`--full` BB dep sweep (6131-6146):** keep the warm-up render's HTML (`const h1 = render();`). Compare its skeleton with the default state's skeleton:

  ```js
  const skel = (h) => [...h.matchAll(/<p class="sk-dep-group-h" data-dep-group="([a-z]+)">|data-dep-group="([a-z]+)"><span class="sk-dep-btncol"><button[^>]*? data-dep-id="([^"]+)"/g)].map(m => m[1] ? "h:" + m[1] : m[3] + ":" + m[2]).join(" ");
  ```

  On a mismatch, push `[SIDE PANEL ERROR] <card> with <dep> <max>: the panel's rows or headings changed with a toggle`. This adds no renders.

**Patch:** `<scratch>/panel/step2.js`.

**Checks:**

- Dry run all counts 1; parse and CRLF pass.
- Plain validator:
  - exit 0;
  - `dependency strip checks` at or above 6733 plus the new spot checks;
  - `[DEP LINE ERROR]`, `[CAST TOGGLE ERROR]`, `[CHIROPTOPHOBIA ERROR]` (its exact `<span class="sk-dep-item-name">Blind 1</span>` still matches inside the link), `[DEP LABEL ERROR]` and `[CAT POWER TTO ERROR]` all silent.
- `--full` exits 0 (Rabbit order, LCK glow, the dep glow sweep with the skeleton check).
- `peek.js rabbit_nAttack` shows the อุปกรณ์ heading before the ดาเมจ heading.

### Step 3. The side panel markup: related lists, fold, phone list, readers

**Changes in `index.html`:**

- **After Step 2's helpers:**

  ```js
  // Related skills (spec 2026-10-29): only those the desc does not already link; a list over 6 folds into one row that opens in place.
  const relOpen = new Set();   // cards whose long related list the player opened, for this visit
  function relListHtml(list, cls){
    if (!list.length) return "";
    const n = list.length, fold = n > 6, open = fold && relOpen.has(selected.id), many = n > 8;
    const grid = n === 1 ? " sk-compat-single-grid" : n <= 4 ? " sk-compat-few-grid" : many ? " sk-compat-many-grid" : "";
    return `<div class="sk-compat-chip sk-rel${cls}${fold ? " is-fold" : ""}${open ? " is-open" : ""}"><p class="sk-compat-title">สกิลที่เกี่ยวข้อง</p>`
      + (fold ? `<button type="button" class="sk-rel-more" aria-expanded="${open}"><span>ทั้งหมด ${n} สกิล</span><svg viewBox="0 0 24 24" aria-hidden="true"><path d="M6 9l6 6 6-6"/></svg></button>` : "")
      + `<div class="sk-compat-grid${grid}">` + list.map(sk => `<button type="button" class="sk-compat-item${many ? " sk-compat-item-many" : ""}" data-skill-id="${sk.id}" title="${sk.name}"><span class="sk-compat-ring"><img src="${SKILL_ICONS[sk.icon] || ""}" alt="" class="sk-compat-icon"></span><span class="sk-compat-name">${sk.name}</span></button>`).join("") + `</div></div>`;
  }
  // Side panel: the toggle strip, then the related skills this server tab's desc does not link (findSkillByMention over the raw desc, lines hidden
  // by an off toggle included, plus the liveCheck note). Desktop also leaves out a card a skill toggle row can open at any of its ranks (it appears
  // once, as that row); phones keep it, since their strip names stay inert. Called after every depSinkAdd, before the desc is built.
  // ponytail: related rows render twice (panel + phone list, CSS shows one); render the hidden copy lazily if the 27-row cards ever feel slow.
  function renderSidePanel(act, linkText){
    const strip = renderDepStrip(act), covered = new Set(), linked = new Set();
    for (const e of depSink.values()) if (!Array.isArray(e) && depGroupOf(e, depOrderKey(e.dep)) > 1)
      for (let r = Math.max(1, e.dep.minRank || 0); r <= (e.dep.maxRank || 0); r++){ const c = depLinkCard(e.dep, r, act); if (c) covered.add(c.id); }
    String(linkText).replace(/\*\*([^*]+)\*\*/g, (m, t) => { const sk = findSkillByMention(t, act); if (sk) linked.add(sk.id); return m; });
    const phone = [...new Set(act.compatSkills || selected.compatSkills || [])].map(id => SKILLS.find(s => s.id === id)).filter(sk => sk && sk.id !== selected.id && !linked.has(sk.id));
    const desk = phone.filter(sk => !covered.has(sk.id));
    return {
      side: strip || desk.length ? `<aside class="sk-side" aria-label="ตัวเลือกและสกิลที่เกี่ยวข้อง">${strip}${relListHtml(desk, "")}</aside>` : "",
      phone: relListHtml(phone, " sk-rel-phone")
    };
  }
  ```
- **`renderHeroNow` (25459-25494):**
  - delete the `compatBlock` code (25459-25489);
  - replace `const depStripHtml = renderDepStrip(activeSelected || selected);` with `const panel = renderSidePanel(activeSelected || selected, descStr + "<br>" + String(liveCheck || ""));   // after every toggle is drawn, before the desc`;
  - keep `heroDescHtmlFor(depLineDeps)`, then `depLineDeps = null; depSink = null;`.
- **Template:**
  - 25496 becomes `<div class="sk-detail-layout">`;
  - 25516 `${depStripHtml}` becomes `${panel.side}`;
  - the rail block (25540-25544, from `${compatBlock ? \`` through `\` : ""}`) becomes `${panel.phone}`.
- **Delete the dead `.sk-compat-name` shrink loop** (25601-25621, from `// Related-skill chip names shrink to fit` through its closing `});`).
- **Bindings:**
  - 25990: `$$(".sk-compat-item", displayEl)` becomes `$$(".sk-compat-item, .sk-dep-link", displayEl)`;
  - in the `if (!displayEl._skillLinkBound)` block (25998), after the desc-link listener:

    ```js
    // Long related lists (spec 2026-10-29): "ทั้งหมด N สกิล" opens in place (no rebuild, so no delta pass), both copies at once.
    displayEl.addEventListener("click", (e) => {
      const more = e.target.closest && e.target.closest(".sk-rel-more");
      if (!more || !displayEl.contains(more) || !selected) return;
      const open = !relOpen.has(selected.id);
      if (open) relOpen.add(selected.id); else relOpen.delete(selected.id);
      $$(".sk-rel.is-fold", displayEl).forEach(r => { r.classList.toggle("is-open", open); const b = r.querySelector(".sk-rel-more"); if (b) b.setAttribute("aria-expanded", String(open)); });
      positionCombatLedger(); fitStageToScreen();   // grows downward only; the fit waits while the pointer is on the panel
    });
    ```

    The fold row, the name links and the switch carry no `data-role`. A click on them makes `deltaClick` record the display element, which is harmless because a dep source or a card switch wins and the fold row does not rebuild.
- **Readers:**
  - `positionCombatLedger` (22630): `$(".sk-compat-rail", displayEl)` becomes `$(".sk-side", displayEl)`, and its comment says "side panel".
  - `fitStageToScreen` (37233-37240) becomes:

    ```js
    const side = isSkillLookup && window.innerWidth >= 900 ? document.querySelector(".sk-side") : null;
    const sideH = side && side.offsetHeight ? side.offsetTop + side.offsetHeight : 0;   // 0 while the skill page is hidden (Stat Roll shares tool-wide-hero)
    const hasSideCompatRail = sideH > 0;
    ```

    and `const compH = Math.max(shellH, statsH, sideH, 460);`. The zoomed left-edge list (37263) becomes `".tool-shell, .sk-stats-panel, .sk-side"`.
  - `DELTA_POPUPS` (22866) and `deltaText` (22872): `.sk-dep-strip` becomes `.sk-side`.
- **Reborn hint (19122):** `" (เปิดสวิตช์ของสกิลนั้นในแถบใต้คำอธิบายเพื่อดูผล)"` becomes `" (เปิดสวิตช์ของสกิลนั้นเพื่อดูผล)"`.
- **CSS (after Step 2's block):**

  ```css
  .sk-rel.is-fold:not(.is-open) > .sk-compat-grid{display:none}
  .sk-rel-more{display:flex; align-items:center; gap:8px; width:100%; min-height:34px; padding:0 2px; box-sizing:border-box; border:0; background:none; color:var(--text); font:500 13px 'Prompt',sans-serif; text-shadow:0 1px 3px rgba(0,0,0,.8); cursor:pointer; text-align:left}
  .sk-rel-more > span{transition:transform .15s ease, color .15s ease}
  .sk-rel-more:hover > span{transform:translateY(-1px); color:var(--gold)}
  .sk-rel-more svg{width:14px; height:14px; fill:none; stroke:currentColor; stroke-width:2.2; stroke-linecap:round; stroke-linejoin:round; transition:transform .15s ease}
  .sk-rel.is-open .sk-rel-more svg{transform:rotate(180deg)}
  .sk-rel-more:focus-visible{outline:2px solid var(--gold); outline-offset:2px}
  .sk-rel-more + .sk-compat-grid{margin-top:6px}
  ```

**Changes in `scripts/validate_skills.js`:**

- **`exposeInjection` (100-138):** add `window._relOpen = relOpen;`. `relOpen` is declared at about 22320, before `function onSearchInput(){` (26488), so there is no TDZ.
- **The universal render loop (2576-2592)** now renders every card on every `_getAvailableServers` tab, selecting twice as in the oracle and setting `og` back afterwards. This is the render-throw check over every desc on every tab: about 1,669 renders, measured at about 0.8 s against 0.45 s for BB alone. Per tab it checks the following (`[SIDE PANEL ERROR]`; print `Verified N side panel checks.`):
  - no `sk-compat-rail` and no `sk-detail-layout--has-compat`;
  - the strip, if any, lies inside `<aside class="sk-side"` … `</aside>`;
  - an aside holds a strip or a desktop related list (never empty);
  - the desktop and phone related ids (`/class="sk-compat-item[^"]*" data-skill-id="([^"]+)"/g`, read from the aside and from the `sk-rel-phone` slice) are each unique, are part of the tab's `compatSkills` (`sandbox._getActiveSkill(sk, srv).compatSkills || sk.compatSkills`) in its order, and never the open card;
  - every desktop id is also in the phone list;
  - no related id is a desc link shown in the desc box. To find those links:
    - cut the box `<div class="sk-hero-desc…">` out with a balanced-`<div>` scan;
    - remove its `<span class="sk-status-tip">` elements with a balanced-`<span>` scan, and any `<template>`;
    - then collect `class="sk-desc-skill-link" data-skill-id="X"`;
  - no desktop related id equals the link (`class="sk-dep-link" data-skill-id`) of a strip item whose `data-dep-group` is `dmg`, `time`, `range` or `info`. Only those rows cover cards. A `cond` row links its card without covering it (call #13), so that card can also be a desktop related row: at plan time 15 of 1,649 tabs have one (the four Chameleon slayers, whose slayerRaceMatch links Mark of Slayer, on BB, TTO and Reborn; Reborn `monkey_twinSouls`, `monkey_elementalSovereign` and `monkey_elementalSovereign_flash`, whose runicInfernoFire links Runic Inferno), and comparing with every strip link would fail on them. To read the links, split the strip at each `<div class="sk-dep-item"` and take the link from the pieces in those four groups. With this rule there are 0 hits on all 1,649 tabs;
  - a list longer than 6 shows `<span>ทั้งหมด N สกิล</span>`, and a shorter one has no `sk-rel-more`.
- **Spot checks after Step 2's** (helpers `heroOf(id, server)`, `asideOf(h)`, `relOf(slice)`):
  - (a) `rabbit_rapidTrance` (BB): no `<aside class="sk-side"` and no `sk-rel-phone`, because its desc links all 10 related skills.
  - (b) `bat_dreamDazzle`:
    - on BB the `shatteringDream` item links `bat_shatteringDream`, and the aside has no related row for it;
    - on TTO there is no `data-dep-id="shatteringDream"`, and the aside's related ids are exactly `bat_shatteringDream`.
  - (c) `chameleon_nAttack` (BB): the aside's related ids are exactly `chameleon_leftStride,chameleon_allSlain`, and the phone list has 3 ids.
  - (d) `bat_blackServant` (BB):
    - before opening: `sk-rel is-fold"`, `aria-expanded="false"><span>ทั้งหมด 12 สกิล</span>` and 12 related items in the aside;
    - after `sandbox._relOpen.add("bat_blackServant")`: `is-fold is-open"` and `aria-expanded="true"`;
    - then delete the id from the set.
  - (e) `panda_formlessPath` (Reborn): `<span>ทั้งหมด 27 สกิล</span>`.
  - (f) `chameleon_bugSlayer` (BB), which pins call #13: `itemOf(…,"slayerRaceMatch")` includes `class="sk-dep-link" data-skill-id="chameleon_markOfSlayer"`, and the aside's related ids are still exactly `chameleon_markOfSlayer,chameleon_allSlain`.

**Patch:** `<scratch>/panel/step3.js`.

**Checks:**

- Dry run, parse and CRLF pass.
- Plain validator:
  - exit 0;
  - `hero render checks` goes from 787 to about 1,669; `side panel checks` equals it;
  - the new spot checks pass.
- `grep -c "compatBlock\|depStripHtml" 12t_projects/bible/index.html` prints 0.
- `grep -n "sk-compat-rail\|sk-detail-layout--has-compat" 12t_projects/bible/index.html` lists exactly 6 lines, all of which Step 4 replaces: the z-index comment (466 at `b11dfc4`) and the rail CSS (4885, 4890, 4897, 4898, 4899). The full grep reaches 0 only in Step 4's checks.
- **Parity:**
  - `<scratch>/panel/parity.js` renders every non-stub tab like the oracle and reads only the HTML:
    - the items' `data-dep-id`, `data-dep-group` and link `data-skill-id`;
    - the headings;
    - the aside and phone related ids;
    - the fold numbers.
  - It compares them with `oracle.json`: **0 mismatches.**
  - A mismatch is a bug in the page or in the oracle; never edit the oracle to agree.

### Step 4. Placement (CSS only)

**Changes in `index.html`:**

- **Replace the rail block** (4879-4900, from `/* Skill detail + related skills (2026-09-15)` to the closing `}` of `@media (min-width:900px)`), and delete `.sk-compat-row` / `.sk-compat-row:empty` (4907-4908):

  ```css
  /* Side panel (2026-10-29, spec docs/superpowers/specs/2026-10-29-skill-details-merged-panel-design.md, mockup B): renderSidePanel writes one
     aside.sk-side into the hero right under the description (the toggles, then the related skills the desc does not link). From 900 px it hangs
     in the old rail's place, 20 px right of .sk and level with the stats panel: nothing between it and .sk may be positioned or transformed
     there (.sk-hero is position:relative below 900 px only). Phones keep the strip under the description and get the related skills as
     .sk-rel-phone after the enemy panel (phone block). */
  .sk-detail-layout{display:block}
  .sk-rel-phone{margin-top:14px}
  @media (min-width:900px){
    .sk-side{position:absolute; left:calc(100% + 20px); top:0; width:260px; margin:0; z-index:4}
    .sk-rel-phone{display:none}
    .sk-has-compat-left-ledger .sk-multihit-layer{left:auto; right:calc(100% + 20px)}
    .sk-side .sk-rel{margin-top:14px}
    .sk-side > .sk-rel:first-child{margin-top:0}
    .sk-side .sk-compat-grid{grid-template-columns:1fr}
    .sk-side .sk-compat-single-grid{max-width:none}
    .sk-side .sk-compat-many-grid{grid-template-columns:repeat(2, 1fr)}
  }
  ```
- **6598:** the anchor `  @media(max-width:900px){\r\n    .sk-hero{position:relative}` becomes `  @media(max-width:899px){\r\n    .sk-hero{position:relative}`. Leave the strip's 3-column rule (6538) and the `.tool-shell` width rule (6663) alone: the panel's own rules override the first at exactly 900 px, and the second is shared with Stat Roll.
- **Phone block** (`@media (max-width: 899px)` at 6772-6782), add:

  ```css
  /* the side panel's related list goes to the very bottom (after the stats panel, order:1): the card's two wrappers step aside */
  html.tool-wide-hero .sk > [data-role="display"], html.tool-wide-hero .sk-detail-layout{display:contents}
  html.tool-wide-hero .sk-rel-phone{order:2; margin:16px 0 0}
  .sk-side .sk-rel{display:none}
  ```
- **464-469:**
  - the comment names "the side panel (z-index 4, .sk-side)";
  - add `html:is([data-sk-server="og"],[data-sk-server="tto"],[data-sk-server="tot"],[data-sk-server="reborn"]) .sk-stat:hover{ z-index:5; }` with a one-line comment: the chip is its odds tooltip's stacking context, and the tooltip opens in the panel's column.

**Changes in `scripts/validate_skills.js`:** add a `[PHONE LAYOUT ERROR]` block after `[DEP LABEL ERROR]` (1522-1528). It reads the source and requires:

- `/@media \(min-width:900px\)\{\s*\.sk-side\{position:absolute; left:calc\(100% \+ 20px\); top:0; width:260px/`;
- no `/@media\(max-width:900px\)\{\s*\.sk-hero\{position:relative\}/`;
- the exact `display:contents` line;
- `html.tool-wide-hero .sk-rel-phone{order:2`.

It prints `Verified the side panel placement rules.`

**Patch:** `<scratch>/panel/step4.js`.

**Checks:**

- Plain validator exit 0, including `[FONT ERROR]`, `[FONT BAN ERROR]`, `[PERF ERROR]`, `[MOTION ERROR]`, `[DEP LABEL ERROR]` and the `stageScaleNow` / `fitGameTipModal` pins.
- `grep -c "sk-compat-rail\|sk-detail-layout--has-compat\|compatBlock\|depStripHtml\|sk-compat-row" 12t_projects/bible/index.html` prints 0, now that the rail block is replaced and the z-index comment (464-469) is reworded.

### Step 5. Desktop row look and row clicks

**Changes in `index.html`:**

- **CSS,** a `@media (min-width:900px)` block after Step 2's base rules (so every new `.sk-dep-item-name` rule follows the base one at 6535), opened by a comment that explains the row anatomy and the Revised Art pop pattern:

  ```css
  @media (min-width:900px){
    .sk-side .sk-dep-strip{display:flex; flex-direction:column; gap:4px; margin:0; padding:0; border:0}
    .sk-side .sk-dep-group-h{display:flex; align-items:center; gap:8px; height:18px; margin:6px 0 0; font:600 11px 'Prompt',sans-serif; letter-spacing:.04em; color:var(--gold); text-shadow:0 1px 3px rgba(0,0,0,.8)}
    .sk-side .sk-dep-group-h::after{content:""; flex:1; height:1px; background:linear-gradient(90deg, rgba(212,175,55,.55), transparent)}
    .sk-side .sk-dep-group-h:first-child{margin-top:0}
    .sk-side .sk-dep-item{display:grid; grid-template-columns:32px minmax(0,1fr) 34px; grid-template-rows:17px 11px; column-gap:10px; row-gap:4px; align-content:center; height:40px; box-sizing:border-box; padding:0 4px; border-radius:6px; border:1px solid color-mix(in srgb, var(--gold) 25%, transparent); background:linear-gradient(color-mix(in srgb, var(--gold) 7%, transparent), color-mix(in srgb, var(--gold) 7%, transparent)), color-mix(in srgb, var(--ink) 55%, transparent)}
    .sk-side .sk-dep-btncol, .sk-side .sk-dep-item-text{display:contents}
    .sk-side .sk-dep-item :is(.sk-dep-toggle, .sk-dep-rank-icon){grid-column:1; grid-row:1 / span 2; align-self:center; position:relative; width:32px; height:32px; border-radius:50%; overflow:hidden; background:var(--ink); box-shadow:0 0 0 1px rgba(212,175,55,.75); filter:grayscale(100%); opacity:.5; transition:opacity .15s ease, filter .15s ease}
    .sk-side .sk-dep-item :is(.sk-dep-toggle, .sk-dep-rank-icon).on{filter:none; opacity:1}
    .sk-side .sk-dep-item :is(.sk-dep-toggle, .sk-dep-rank-icon):hover{opacity:.85; filter:grayscale(80%) brightness(1.2)}
    .sk-side .sk-dep-item :is(.sk-dep-toggle, .sk-dep-rank-icon).on:hover{opacity:1; filter:brightness(1.22)}
    .sk-side .sk-dep-item :is(.sk-dep-toggle, .sk-dep-rank-icon) img{position:absolute; inset:0; width:100%; height:100%; border-radius:0; filter:none; opacity:1; transition:none; animation:none !important; transform:scale(1.3) translate(var(--ring-x,0%), var(--ring-y,0%))}
    .sk-side .sk-dep-item[data-dep-group="gear"] :is(.sk-dep-toggle, .sk-dep-rank-icon) img{transform:scale(.8) translate(var(--ring-x,0%), var(--ring-y,0%))}
    .sk-side .sk-dep-item .sk-dep-flip-on{animation:skDepFlipOn .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item .sk-dep-flip-off{animation:skDepFlipOff .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item .sk-dep-flip-swap{animation:skDepFlipSwap .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item-text > .sk-dep-item-name, .sk-side .sk-dep-link{grid-column:2; grid-row:1; justify-self:start; align-self:end; min-width:0; max-width:100%}
    .sk-side .sk-dep-item-name{font-size:13px; line-height:17px; color:var(--text); text-shadow:0 1px 3px rgba(0,0,0,.8)}
    .sk-side .sk-dep-link .sk-dep-item-name{transition:transform .15s ease, color .15s ease}
    .sk-side .sk-dep-link:hover .sk-dep-item-name{transform:translateY(-1px); color:var(--gold)}
    .sk-side .sk-dep-link:focus-visible{outline:2px solid var(--gold); outline-offset:2px; border-radius:3px}
    .sk-side .sk-dep-pips{grid-column:2; grid-row:2; justify-self:start; align-self:center}
    .sk-side .sk-dep-item-tags{grid-column:2; grid-row:2; justify-self:end; align-self:center; gap:6px}
    .sk-side .sk-dep-tag{font-size:9px; letter-spacing:.5px; text-shadow:0 1px 2px rgba(0,0,0,.8)}
    .sk-side .sk-dep-sw{display:block; grid-column:3; grid-row:1 / span 2; align-self:stretch; position:relative; cursor:pointer}
    .sk-side .sk-dep-sw::before{content:""; position:absolute; right:4px; top:50%; width:26px; height:14px; margin-top:-7px; border-radius:7px; background:color-mix(in srgb, var(--muted) 35%, transparent)}
    .sk-side .sk-dep-sw::after{content:""; position:absolute; right:18px; top:50%; width:10px; height:10px; margin-top:-5px; border-radius:50%; background:var(--muted)}
    .sk-side .sk-dep-sw:hover::before{filter:brightness(1.15)}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > .on) .sk-dep-sw::before{background:var(--gold)}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > .on) .sk-dep-sw::after{transform:translateX(12px); background:var(--ink)}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > .sk-dep-flip-on) .sk-dep-sw::before{animation:skSwTrackOn .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > .sk-dep-flip-on) .sk-dep-sw::after{animation:skSwKnobOn .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > .sk-dep-flip-off) .sk-dep-sw::before{animation:skSwTrackOff .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > .sk-dep-flip-off) .sk-dep-sw::after{animation:skSwKnobOff .3s ease-out var(--flip-delay,0ms) backwards}
    .sk-side .sk-dep-item:has(.sk-dep-btncol > [data-dep-min-rank]:not([data-dep-min-rank="0"])) .sk-dep-sw{visibility:hidden}   /* no off state: no switch */
    .sk-side .sk-dep-item:has(button[data-dep-id]:focus-visible){outline:2px solid var(--gold); outline-offset:1px}
  }
  @keyframes skSwTrackOn{0%{background:color-mix(in srgb, var(--muted) 35%, transparent)}}
  @keyframes skSwTrackOff{0%{background:var(--gold)}}
  @keyframes skSwKnobOn{0%{transform:translateX(0); background:var(--muted)}}
  @keyframes skSwKnobOff{0%{transform:translateX(12px); background:var(--ink)}}
  ```

  None of the shared `.sk-dep-toggle` / `.sk-pip` / `.sk-dep-flip-*` rules (6467-6530) is edited, so the 3D reach popup keeps its look. The keyframes hold only a 0% frame and fill `backwards`, so during `--flip-delay` the switch shows its old state, as the ring does.
- **`flipStart` (23369):** after `const cls = flipCls(f), img = f.b.querySelector("img");`, add `const row = f.b.closest(".sk-dep-item"); if (row) row.style.setProperty("--flip-delay", delay + "ms");   // the side panel's ring and switch wait with the old picture`.
- **`centreRingImg` load listener (31249):** add `, .sk-side .sk-dep-btncol > button > img` to its selector list.
- **Switch clicks,** in the `displayEl._skillLinkBound` block:

  ```js
  // Side panel rows on desktop (mockup B: "switch = toggle"): the switch clicks the row's own button, so depClicked, DEP_EXCLUSIVE and every
  // per-dep rule run exactly as for a click on the ring. The name line never toggles; phones keep icon-only.
  displayEl.addEventListener("click", (e) => {
    if (window.innerWidth < 900) return;
    const sw = e.target.closest && e.target.closest(".sk-side .sk-dep-sw");
    const btn = sw && sw.closest(".sk-dep-item").querySelector("button[data-dep-id]");
    if (btn) btn.click();
  });
  ```

**Changes in `scripts/validate_skills.js`:** none. `[DEP LABEL ERROR]` still reads the base rule first.

**Patch:** `<scratch>/panel/step5.js`.

**Checks:**

- Plain validator exit 0, including `[FONT ERROR]`, `[PERF ERROR]` and `[MOTION ERROR]`.
- `grep -n "\.sk-dep-item-name{" 12t_projects/bible/index.html`: the first hit is still the base rule.

### Step 6. Scale lock and keyboard focus

**Changes in `index.html`:**

- **A global block** right before `// The page's current fit-screen scale` / `let stageScaleNow = 1;` (37198):

  ```js
  // Scale lock (2026-10-29, spec docs/superpowers/specs/2026-10-29-skill-details-merged-panel-design.md): while the pointer or keyboard focus is on
  // the skill page's side panel or a stat panel header (collapse chevron, PRESET, Revised Art, enemy picker), a content refit keeps the current
  // scale, so nothing there moves between two clicks; it refits once both have left. A window resize, tool zoom, tool switch or a new card always
  // refit (fitStageToScreen(true)). The pointer is kept as a point and hit-tested, because each toggle click rebuilds the panel under a still
  // pointer; focus counts only after keyboard input (a mouse click focuses buttons too). var: fitStageToScreen can run before this line.
  var fitHoldPt = null, fitHoldKey = false, fitPtrDown = false, fitHeld = false;
  function fitHoldOn(){
    if (window.innerWidth < 900) return false;
    const sel = ".sk-side, .sk-stats-panel .sk-class-badge";
    let el = null;
    try { el = fitHoldPt && document.elementFromPoint(fitHoldPt[0], fitHoldPt[1]); } catch (e) {}
    if (el && el.closest && el.closest(sel)) return true;
    const f = fitHoldKey ? document.activeElement : null;
    return !!(f && f.closest && f.closest(sel) && f.getClientRects().length);
  }
  function fitHoldRelease(){ if (fitHeld && !fitPtrDown && !fitHoldOn()) fitStageToScreen(); }
  document.addEventListener("pointerdown", (e) => { fitHoldPt = [e.clientX, e.clientY]; fitHoldKey = false; fitPtrDown = true; }, true);
  document.addEventListener("pointermove", (e) => { fitHoldPt = [e.clientX, e.clientY]; if (fitHeld) fitHoldRelease(); }, { passive: true });
  ["pointerup", "pointercancel"].forEach(t => document.addEventListener(t, () => { fitPtrDown = false; setTimeout(fitHoldRelease, 0); }, true));   // after the click lands
  document.addEventListener("mouseout", (e) => { if (!e.relatedTarget){ fitHoldPt = null; fitHoldRelease(); } });   // the pointer left the window
  document.addEventListener("keydown", (e) => { if (!e.ctrlKey && !e.metaKey && !e.altKey) fitHoldKey = true; }, true);   // a shortcut (Ctrl+Z) moves no focus: a mouse-focused chevron must not hold
  document.addEventListener("focusout", () => setTimeout(fitHoldRelease, 0));
  ```
- **`fitStageToScreen`:**
  - `function fitStageToScreen(){` becomes `function fitStageToScreen(force){`, with `fitHeld = false;` as its first statement;
  - right after `const isSkillLookup = document.documentElement.classList.contains("tool-wide-hero");` add `if (isSkillLookup && !force && fitHoldOn()){ fitHeld = true; return; }   // scale lock (above)`. Stat Roll shares `tool-wide-hero` but has no panel, so it is never held.
- **Forced callers:**
  - the mount's resize handler (26627): `…positionDmgInfoPopup(); fitStageToScreen(true); } });`;
  - `setToolZoom` (37174): `  fitStageToScreen(true);` (anchor with the following `if (z > 1){` line);
  - `showTool` (37354): `  fitStageToScreen(true);` (anchor with the closing `}` and the `function getGoatPath(){` that follows).
- **`renderHeroNow`, before `positionStatsPanel();` (25623):** `const skillSwitched = idSeen !== (selected && selected.id);   // a new card always fits at once, even under the scale lock`. The sync fit (25629) and the rAF fit (25635) become `fitStageToScreen(skillSwitched);`. Leave `setupStatTooltipInteractions();` and `setupStatTarget();` next to each other (`[CHIP TARGET ERROR]`).
- **Focus capture,** in `renderHeroNow` right after `depLineDeps = new Map();` (23661):

  ```js
  const keepAe = fitHoldKey ? document.activeElement : null;   // a keyboard toggle keeps its focus across the rebuild (scale lock; backlog §6.1)
  const keepDep = keepAe && keepAe.matches && keepAe.matches("button[data-dep-id]") && displayEl.contains(keepAe) ? keepAe.dataset.depId : "";
  ```

  **Focus restore,** right after the `displayEl.innerHTML = \`…\`;` template (anchor on its last line plus the following `// Long ranges` comment):

  ```js
  if (keepDep){ const f = displayEl.querySelector(`button[data-dep-id="${keepDep}"]`); if (f) f.focus({ preventScroll: true }); }
  ```

  `renderHeroNow();` stays directly followed by `fitDepLabels();` in `renderHero` (`[DEP LABEL ERROR]`).

**Changes in `scripts/validate_skills.js`:** a `[SCALE LOCK ERROR]` block next to `[PHONE LAYOUT ERROR]`. It requires:

- `function fitStageToScreen(force){`;
- the guard text, located after that header and before `  stageScaleNow = scale;`;
- at least 3 matches of `fitStageToScreen(true)`;
- exactly 2 of `fitStageToScreen(skillSwitched)`;
- `const sel = ".sk-side, .sk-stats-panel .sk-class-badge";`;
- `if (!e.ctrlKey && !e.metaKey && !e.altKey) fitHoldKey = true;` (shortcuts never arm the keyboard half);
- ``displayEl.querySelector(`button[data-dep-id="${keepDep}"]`)``.

**Patch:** `<scratch>/panel/step6.js`. Anchor the repeated `fitStageToScreen();` calls (12 in the file) with their unique neighbouring text.

**Checks:**

- Plain validator exit 0 with no FATAL at load. The top-level listeners attach to the sandbox's stub `document`, and the guard sits after `fitStageToScreen`'s early return.
- `grep -c "fitStageToScreen(true)"` is at least 3, and `grep -c "fitStageToScreen(skillSwitched)"` is 2.

### Step 7. Probes and browser pass B

**Scratch probes** (read-only, against the patched page):

1. **`parity.js` again:** 0 mismatches against `oracle.json`.
2. **`<scratch>/panel/stability.js`:** for every non-stub tab and every drawn dep at its `minRank` and its `maxRank`, the skeleton (row ids, groups, headings; the same regex as the `--full` check) equals the default render's. **Expect 0 changes** (plan time: 0 of 3,788 renders).
3. **`<scratch>/panel/ranks.js`:** every non-stub tab at every rank from 1 to maxRank renders without throwing, with at most one `<aside class="sk-side"` and the strip inside it. This is the render-throw check over every desc at every rank.
4. **`<scratch>/panel/worst_rows.js`:** the 5 rows with the most pips and tag letters. At plan time:
   - `monkey_groundLock` on ToT: secondStone, INFO DUR RANGE HITS;
   - `chameleon_allBugSlayer` on TTO: improvedSlayer, 4 pips, INFO CAST DMG;
   - `monkey_groundLock` on TTO: INFO RANGE HITS;
   - `bison_nAttack` on TTO: bruteStrength, 5 pips, DMG CHANCE.

**Browser pass B** (Playwright with `browser_run_code_unsafe`, local server; report the numbers, not impressions):

1. **Fixed toggles, with the pointer inside the panel.**
   - **Sizes:** 1920×1080, 1366×768 and 1280×720.
   - **Cards:** `bison_nAttack` (BB, Reborn), `chameleon_leftStride` (BB, Reborn), `bat_cAttack`, `wolf_nAttack` and `monkey_fireBall` (Reborn).
   - **Per card:** the first 6 `.sk-side button[data-dep-id]`, plus the switch of the first row.
   - **Method:**
     1. Move the mouse to the target's centre.
     2. Click 6 times at that exact point, with gaps alternating 700 ms and 120 ms. After each click, wait 2 frames + 50 ms.
     3. Read:
        - the button's centre;
        - `.stage` `style.transform`;
        - `document.elementFromPoint` at the click point (`.closest(".sk-dep-item")` must be the same row);
        - the state (`aria-pressed`, `aria-label` or `title`).
   - **Pass:**
     - drift of at most 0.5 px on every click;
     - one transform string for the whole burst;
     - always the same row;
     - the state changed on every click.

     Compare with `before.json`.
2. **Release:** move the mouse to the card's padding. Within 2 frames `.stage` `style.transform` equals the value `fitStageToScreen(true)` then produces. A window resize while hovering refits. Ctrl+wheel over the panel zooms, and the zoom pill appears.
3. **Keyboard (1366×768, mouse parked at 2,2):**
   - Tab into the panel; press Enter 4 times and Space 2 times. `document.activeElement.dataset.depId` stays the same, `:focus-visible` matches, the row ring is visible and the transform is unchanged.
   - Tab out of the panel: the page refits.
   - A shortcut never holds: pick an enemy (an undo step), click the player chevron twice with the mouse (it keeps focus), move the pointer to the card's padding and press Ctrl+Z. After 2 frames `fitHeld` is false and `.stage` `style.transform` equals what `fitStageToScreen(true)` then produces.
4. **Name links:**
   - Clicking "Fatal Strike" on Chameleon Combo opens that card on the same server, and the page refits at once even though the pointer is still on the panel.
   - Clicking the empty part of the name line does nothing.
5. **Folded lists:**
   - Formless Path on Reborn: `ทั้งหมด 27 สกิล` opens in place. Every row above it keeps its rectangle. After the pointer leaves, the opened list's bottom is at most `innerHeight`.
   - Black Servant: the same with 12 rows.
6. **Overlays:**
   - Hover a chip whose odds tooltip overlaps the panel: `elementFromPoint` at the tooltip's centre is the tooltip.
   - A desc status pop-up shows over the panel.
   - The Test result lane never covers a panel row.
   - An open `.sk-dmg-info` popover is not covered. If it is, lift `.sk-dmg` while its `details[open]`, the same way as the chip.
7. **Motion:**
   - Comets leave from the panel's pips. Red comets fly back on turn-off, and the ring and the switch change as the last comet lands.
   - Rabbit Combo: switching Customized Shotgun on while the Gatling Gun is on sends the light from the Shotgun.
   - Switching Crit Weapon on while the Gatling Gun is on sends it from the Weapon.
8. **Worst rows** (from `worst_rows.js`): no overlap between pips and tags (`pips.right <= tags.left`), and every name has `scrollWidth <= clientWidth` after `fitDepLabels`.
9. **The 900 px boundary:**
   - At 900×900: `.sk-side` is absolute, its left edge is 20 px (times the scale) right of `.sk`, and the ‹ › buttons are hidden.
   - At 899×900: the strip is under the desc, `.sk-rel-phone` comes after the enemy panel, and the ‹ › buttons show.
10. **Phone 390×844 (BB and Reborn):**
    - The strip lies between the desc's bottom and the first chip's top, with no switch and no headings.
    - Tapping a name changes nothing (same card, same hash); tapping an icon toggles.
    - `.sk-rel-phone` top is at or below the enemy panel's bottom, and its fold opens in place.
    - `scrollWidth <= innerWidth`, and there is no stage transform.
11. **Looks:** with `#btnServerTheme` on BB, ToT, TTO and Reborn, take screenshots of the panel on Bison Combo and Left Stride. Names, tags and headings must be readable on the wallpaper. Contrast fixes go only in `.sk-side` rules.
12. **Unchanged:** the 3D reach popup's toggles (look and clicks), the in-game tooltip modal, and Stat Roll's fit (open it after hovering the panel).
13. **Speed:** repeat Step 2's timing (20 clicks of `runicInfernoFire` on `monkey_runicInferno` and of `fatalStrike` on `chameleon_nAttack`, Reborn, 1920×1080) and compare the median and the slowest click with `before.json`. Flag anything over 2x. (Formless Path has no toggles, so it cannot be timed this way.)
14. **0 console errors** throughout.

**Checks:** all of the above hold. A CSS fix found here goes back through a patch script, followed by the plain validator.

### Step 8. Rule files, backlog, spec

All edits go through `patch_lib`, because the Markdown is CRLF. Links stay repo-relative.

- **`.claude/skills/bible-skill-page-ui/SKILL.md`:**
  - **Frontmatter description (3):**
    - "the dependency strip and dep toggles (depSink, DEP_EXCLUSIVE, ordering)" becomes "the side panel (dep toggles grouped by function, related skills the desc does not link, depSink, DEP_EXCLUSIVE, ordering, scale lock)";
    - "the player/enemy stat panels and class badge" becomes "the player/enemy stat panels (collapsible) and class badge".
  - **"Phone layout" (13-14):**
    - the Tool zoom bullet gains the scale lock: hold region, release, forced refits;
    - the phone bullet becomes: search, then the card with the toggle strip under the description (grouped order, no headings, inert names), then the stat panels (`order:1`), then `.sk-rel-phone` (`order:2`, with `[data-role=display]` and `.sk-detail-layout` set to `display:contents`); the ‹ › buttons show below 900 px.
  - **"Card look" (21, 23):**
    - the side panel has no box, and its desktop rows carry mockup B's wash and edge (no THEME_SURFACES entry);
    - "dependency strip = no box, gold hairlines" now applies to phones.
  - **"Delta motion and dependency strip" (35-36):**
    - rename the heading to "Delta motion and the side panel";
    - the ring pop and the switch wait through `--flip-delay`;
    - the light leaves from the clicked toggle first.
  - **"Dependency strip" (65-78)** becomes **"Side panel (`renderSidePanel`)"**:
    - placement at each width and the containing-block rule;
    - the groups, their order and the heading rule;
    - row anatomy and click zones;
    - the name-link rule;
    - covered cards;
    - the related-list rule, its fold and the phone list;
    - focus restore;
    - markup and checks (`data-dep-group`, `[DEP STRIP ERROR]`, `[DEP ORDER ERROR]`, `[SIDE PANEL ERROR]`, `[PHONE LAYOUT ERROR]`, `[SCALE LOCK ERROR]`).

    Keep sub-bullets 66-72 (revealed lines, `lineNeedsToggle`, `castDep2`, merged rank-5 toggles, pips, first-site rule), with "strip" reworded. Replace "Columns" (74) with the phone columns plus the desktop row. In "Order" (77), groups come first.
  - **"Server themes" 151:** "the related-skills panel `.sk-compat-chip` has no box" becomes "the side panel `.sk-side` has no box".
  - **"No scrolling on desktop" (187+):** the side panel counts in compH; long related lists fold; the scale lock.
- **`.claude/skills/bible-card-fields/SKILL.md`:**
  - **32 (server-specific compatSkills):** each server tab's panel follows that tab's list and that tab's desc.
  - **"Compatible Skills Navigation" (112-117):**
    - #1 reciprocity and #2 header: kept;
    - #3: the look is kept, with "rail" replaced by "related rows";
    - #4: the grids, with the stale single-grid caption dropped;
    - **new #5:** a compat entry is listed only when the tab's desc does not link it; on desktop it is also left out when a skill toggle row can open it, and phones list it anyway. More than 6 rows fold into "ทั้งหมด N สกิล". Keep every edge in the data anyway, because findSkillByMention's tier 1 and `[COMPAT ERROR]` use it. Point to bible-skill-page-ui "Side panel" for the layout.
- **`.claude/skills/bible-desc-writing/SKILL.md`:**
  - **48:** after "Both link each other in compatSkills", add: "On the skill page a related skill the desc already bolds (findSkillByMention, hidden lines included) is not listed again in the side panel; keep the compatSkills edge."
  - **64-65 (cross-linking):** the same resolver decides which related skills the panel repeats.
- **`12t_projects/bible/GEMINI.md` 9:** mirror the new page-ui description (index only).
- **`docs/superpowers/plans/2026-10-28-skill-details-review-backlog.md`:**
  - §3.7: drop "the compat names", because the loop is gone.
  - §5.4: keep only English tags, clickable pips (a rank picker) and the DEP_EXCLUSIVE toast.
  - §5.5: on desktop the toggles left the card and the stat panels collapse.
  - §6.1: dep buttons keep keyboard focus since 2026-10-29; server tabs, the rank icon and Buff / Debuff remain.
  - §6.8: on desktop the switch toggles too; phones are unchanged.
  - §6.10: the desktop switch adds an on / off mark that is not colour alone.
- **The spec:** append "As built (2026-10-29)", listing the calls that differ from or refine it (1, 3, 8-13, 17-20, 22-31) and the oracle figures from Step 0.

**Checks:**

- 0 lone LF in every edited file.
- Read the changed sections back against the built behaviour.
- The plain validator no longer prints `[RULEBOOK REMINDER]` for this commit.

### Step 9. Changelog, full validation, commit B

1. `node <scratch>/panel/changelog_add.js "<subject B>"`. Subject B (no `"` or `\`):

   `feat(bible): skill details: one side panel beside the card replaces the related-skills rail and the toggle strip (toggles grouped by function with name links and a switch, then the related skills the desc does not link, long lists folded), and the page keeps its scale while the pointer or keyboard focus is on it; phones keep the strip under the description and list the related skills at the bottom`
2. Run `node scripts/validate_skills.js --full`. It is required here, because this change touches the Rabbit order, the LCK glow and the dep sweep.
3. Run `git diff --stat`, then stage only:
   - `12t_projects/bible/index.html`
   - `scripts/validate_skills.js`
   - the three skill files
   - `12t_projects/bible/GEMINI.md`
   - the backlog
   - the spec
4. Re-check `git log -1`, then commit with the session's Co-Authored-By line. No push.

**Checks:**

- `--full` exits 0.
- The first `CHANGELOG_DATA.entries` item equals subject B exactly.
- `git show --stat HEAD` lists only the intended files.
- `index.html` is CRLF only (`[CHIP TARGET ERROR]` checks it too).

## Verification

### Cards to test (validator spot checks and browser pass B)

| Card | Tab(s) | What it proves (plan-time figures) |
|---|---|---|
| `bison_nAttack` (Bison Combo) | BB, Reborn | BB: 9 rows with headings อุปกรณ์ / เงื่อนไข / โหมด / ดาเมจ, no desktop related rows. Reborn: 12 rows and 4 headings (+ คำอธิบาย for Savage Momentum), 2 phone-only related rows. Tallest toggle list. Brute Strength's name opens its card. |
| `chameleon_leftStride` (Left Stride) | BB, Reborn | BB: 10 toggles in 4 groups (gear, condition, ดาเมจ, ระยะ). The chmTargetPoison condition links Poison Arrow. 0 desktop related rows, 5 on phones. Reborn: 12 toggles. |
| `panda_formlessPath` (Formless Path) | Reborn | No toggles; 27 related rows fold into `ทั้งหมด 27 สกิล` (compat 33). Opens in place; nothing above moves; refits after leaving. |
| `bat_blackServant` (Black Servant) | BB | 12 zombies folded. Its desc still points to "สกิลที่เกี่ยวข้อง", the title kept on both layouts. |
| `rabbit_rapidTrance` | BB | No toggles and every related skill linked by the desc: no panel, layout as a card without a rail (compW 1420). `bat_massCast` is a second such card. |
| `chameleon_cAttack` (passive) | BB | A passive with a panel: 3 rows (condition → Poison Arrow; Piercing Venom; Silent Walk) and related All Slain and Increased Poison. |
| `cat_broadside` and `mole_airStrike` (Reborn-only C6 / C7) | Reborn | Broadside: the Power row links Power Seven; related Support Fire and Ghost Galleon. Air Strike: the reactorOverdrive condition links Reactor Core; related Bombardment. |
| `bat_dreamDazzle` | BB, TTO | The toggle list differs per server. BB: Shattering Dream is a toggle row (its name opens the card). TTO: no toggle, and Shattering Dream is a related row instead. |
| `cat_reverseThrust` | BB, TTO | Cat Power present on BB, absent on TTO (`[CAT POWER TTO ERROR]` still passes). |
| `cat_pillagePlunge` | BB | Toggles but no related skills: a one-row panel on a card that had no rail. |
| `monkey_fireBall` | BB, Reborn | Two CAST toggles (Instant Cast, Rapid Fire) in เวลา. Reborn adds the Runic Inferno condition with a link. |
| `rabbit_nAttack` (Rabbit Combo) | BB | Gear first. DEP_EXCLUSIVE light source (Shotgun vs Gatling; Weapon vs Gatling). |
| `bat_cAttack`, `wolf_nAttack` | BB | Desc lines revealed by a toggle: the drift cases of the BEFORE / AFTER measurement. |

Plus: the stat collapse with the target edit, presets, an enemy pick and Ctrl+Z (Step 1), at 1920×1080, 1366×768, 1280×720, 900 / 899 px and 390×844, on all four looks.

### Rule-file sections to rewrite

- **`.claude/skills/bible-skill-page-ui/SKILL.md`:**
  - frontmatter description (3);
  - Phone layout: Tool zoom and phone bullets (13-14);
  - Card look: "One level of boxes" (21), strip hairlines (23), Stat dials (33);
  - "Delta motion and dependency strip": heading and motion bullet (35-36);
  - "Dependency strip", rewritten as "Side panel" (65-78);
  - "Class Badge in the Player Stat Panel" (105-112);
  - "Server themes", the skill details look line (151);
  - "Target value on a stat chip" (182);
  - "No scrolling on desktop" (187+).
- **`.claude/skills/bible-card-fields/SKILL.md`:** server-specific `compatSkills` (32); "Compatible Skills Navigation" #2-#5 (112-117).
- **`.claude/skills/bible-desc-writing/SKILL.md`:** the modifier mirror note (48); "Interactive Skill Cross-Linking" (64-65).
- **`12t_projects/bible/GEMINI.md`:** line 9 (index mirror only).
- **`12t_projects/bible/CLAUDE.md`:** no change. Its core rules apply as written.
- **Also:** the backlog items §3.7, §5.4, §5.5, §6.1, §6.8 and §6.10, and the spec's "As built" section.

### Risks and the check that catches each

| Risk | Caught by |
|---|---|
| A positioned or filtered ancestor at 900 px or wider anchors the aside to the card instead of `.sk` | `[PHONE LAYOUT ERROR]` pin; browser B item 9 |
| A dep button rendered twice or outside the panel (dead clicks, comets from 0,0) | `[DEP STRIP ERROR]` 1-2; side panel check "strip inside the aside" |
| A changed regex quietly matches nothing | count guards in the label and order checks; the `--full` skeleton check |
| The related filter hides a card that can then be reached from nowhere | parity against the oracle (Steps 3 and 7) and the exact-list spot checks (`chameleon_nAttack`, `bat_dreamDazzle`, `chameleon_bugSlayer`), which catch a dropped card; Step 3's per-tab `[SIDE PANEL ERROR]` checks (related ids within the tab's `compatSkills` in order, every desktop id also in the phone list, no related id the desc box already links, no desktop id equal to a skill-group row's link), which pin the lists' shape; condition links |
| Rows or headings move with a toggle | the `--full` skeleton check; stability probe (0 of 3,788 at plan time); browser B item 1 |
| The lock sticks, or blocks zoom and resize | forced callers and the shortcut filter on `keydown`, pinned by `[SCALE LOCK ERROR]`; browser B items 2, 3 (Ctrl+Z after a chevron click) and 12 (Stat Roll) |
| A refit splits a click (mousedown and mouseup on different targets) | `fitPtrDown` guard; release deferred after pointerup |
| Focus lost or stolen after a rebuild | keyboard-only restore with the `displayEl.contains` guard; browser B item 3 |
| A hidden stat ring sends comets from (0,0) | header fallback (pinned in `[PANEL ERROR]`); browser A items a-d |
| Odds tooltips or the damage info popover painted under the panel | chip hover lift; browser B item 6 |
| An opened 27-row list runs below the window while the lock holds | compH counts the panel; the 2-column compact grid; refit on leave (browser B item 5) |
| Panel text hard to read on the ToT / TTO / Reborn wallpapers | ink-mixed row wash and text shadows; browser B item 11 |
| Related rows rendered twice cost render time on long lists | browser B item 13 (`ponytail:` note: render the hidden copy lazily if it is ever slow) |
| Patching a 6 MB CRLF file goes wrong | `patch_lib` counts, markers, backups, parse and CRLF checks, selftest |

## Revision notes (2026-10-29, after the completeness critic)

Each gap was checked against `b11dfc4`: the critic's probes were rerun and the cited code was read. All eight hold, so every one is fixed and none is left as is.

1. **Step 3, `[SIDE PANEL ERROR]` (high).** The desktop-versus-strip-link check now compares only with the links of `dmg` / `time` / `range` / `info` items. The old wording contradicted call #13 and failed on 15 of 1,649 tabs (the Chameleon slayers' Mark of Slayer; Reborn Twin Souls and Elemental Sovereign's Runic Inferno). The new rule has 0 hits. New spot check (f) on BB `chameleon_bugSlayer` pins call #13.
2. **Related-row figures (medium).** Step 0's oracle row and call #2 now read 1,423 desktop / 1,670 phone rows: rule C.1 as `renderSidePanel` codes it. 1,419 / 1,613 came from the merged-desc rule that call #18 rejects, and Step 0 now says the oracle must not merge. The other oracle figures reproduced unchanged: 1,135 / 514 panels, 265 headings, 54 / 55 folds, 12 rows on `bison_nAttack` (Reborn), 27 related rows.
3. **Greps (medium).** Step 3 now greps only `compatBlock\|depStripHtml` (expect 0) and expects the 6 rail and comment lines that Step 4 replaces. The full grep, with `sk-compat-row` folded in, moved to Step 4's checks.
4. **Browser pass A (medium).** Shots are now read from their keyframes, and one end of each path must be at the header, because a field that got worse sends a red comet that starts at its chip. The cases run on `monkey_fireBall` (an AGI cooldown chip and damage against the enemy's DEF) and make the fields better. Case (c) is now a concrete recipe (hand-edit DEF, then re-pick Carron), because from Carron's all-2 stats a plain pick moves several stats at once. Case (d) checks both ends too.
5. **Scale lock, keyboard half (low).** A `keydown` with Ctrl, Meta or Alt no longer sets `fitHoldKey`. This is updated in Architecture D, the Step 6 code and a new `[SCALE LOCK ERROR]` pin, and browser pass B item 3 adds the chevron + Ctrl+Z case.
6. **Timing (low).** Step 2's BEFORE run now records the HEAD timings. Browser pass B item 13 times `monkey_runicInferno` and `chameleon_nAttack` on Reborn, because Formless Path has no toggles.
7. **Panel height (low).** Call #16 now counts the 14 flex gaps, so the tallest panel is 709 px, not 697. Call #22's scaleH values become 0.990 / 0.922, and the oracle row says about 709 px. The width still sets the scale.
8. **Risk table (low).** "R1-R3" is replaced by the checks that exist: parity against the oracle, the exact-list spot checks and Step 3's per-tab checks.

Also corrected while checking (not from the critic): HEAD is now `de6926a`, a docs-only commit that added the spec and the mockups on top of `b11dfc4`. So Step 0 names it, and Step 1 stages only this plan file. Line numbers are unaffected, because `de6926a` does not touch `index.html` or `validate_skills.js`.
