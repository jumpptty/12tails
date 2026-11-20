# Guide Gallery Soft Tile Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** The ไกด์อาชีพ gallery cards become thin glass tiles with the class / server / PVE row under the cover, and on the desktop every title fills the same 2-line box.

**Architecture:** CSS only for the card (order via CSS `order`, no DOM reorder, so the validator's card-code check stays true), plus one top-level function `classGuideFitTitles(boxes)` that sizes each title to its box with a lockstep bisection (all cards per pass, about 10 layouts per call). The title box has a fixed height, so a card's height no longer depends on its title and `renderGallery`'s rows-per-page and zoom fit are unaffected; the fit runs once at the end of `renderGallery` and after the step 6 preview card is built.

**Tech Stack:** plain CSS / JS in `12t_projects/bible/index.html`; the validator `scripts/validate_skills.js` (node `vm` sandbox).

**Spec:** `docs/superpowers/specs/2026-11-20-guide-gallery-soft-tile-design.md`

## Global Constraints

- Patch `index.html` out of process (a node scratch script, CRLF anchors, a backup first, every anchor matched exactly once); never the Edit tool on it (12t_projects/bible/CLAUDE.md §1).
- Work in a worktree of `skill-cooldown-lookup` outside the repo (`C:/tmp/gallery-tile`); commit there, **no push** until the user says.
- Fonts: Prompt only (numbers `'JetBrains Mono','Prompt',monospace`); hover = a few px lift and an edge colour, never a gold glow; no `prefers-reduced-motion` rules.
- Card values from the spec: hairline `rgba(255,255,255,.09)`, radius 14px, gradient `.05` to `.015` white, blur 8px; hover lift 3px, hairline gold at half strength.
- Title box: height `calc(2 * 1.3 * 17px)`, line-height 1.3, sizes 13px to 22px, desktop only (`min-width:761px`).
- Changelog entry with the exact commit subject; plain `node scripts/validate_skills.js` (no damage code touched, so no `--full`).

## Review Focus

- A title too long even at 13px (the input allows 160 characters): it stays at 13px and overflows its box; the card grows, nothing breaks.
- A short window (compact mode, zoom down to 0.7) and a window resized from desktop to phone: titles refit, and on a phone the inline sizes are cleared.
- Page change by the side arrows or the pager: the new page's titles are fitted (both go through `renderGallery(true)`).
- Web fonts arriving late: the existing `load` refit redraws the gallery, which refits the titles.
- The ToT / TTO / BB / Reborn looks: no theme paint or gilded frame left on the cards or page buttons.

---

### Task 1: `classGuideFitTitles` and its check

**Files:**
- Modify: `12t_projects/bible/index.html` (top level, right after `classGuideTitleInto`, about line 36719)
- Test: `scripts/validate_skills.js` (with the other class guide checks, near the `classGuideStatParse` check, about line 4400)

**Interfaces:**
- Produces: `classGuideFitTitles(boxes, lo = 13, hi = 22)`: `boxes` is an array of title elements (`strong`), each holding one `.cg-title-in` span. For each box it sets `box.style.fontSize` to the biggest size in `[lo, hi]` (rounded down to 0.5px) for which `inner.offsetHeight <= box.clientHeight + 0.5` and `inner.scrollWidth <= box.clientWidth + 0.5`; when even `lo` does not fit it sets `lo`. Returns nothing. All boxes advance together: set every box's size, then read every box (no read between writes).

- [ ] **Step 1: Write the failing check** in the validator: fake boxes with a text-wrap model, a box 300 wide and `2 * 1.3 * 17` tall, `inner.offsetHeight = lines * size * 1.3` where `lines = ceil(chars * size * 0.55 / 300)`, `scrollWidth` 0. Assert: 5 chars → `"22px"`; 40 chars → between `"16px"` and `"17.5px"`; 87 chars → between `"13px"` and `"15px"` and fitting (lines × size × 1.3 ≤ box height); 300 chars → `"13px"`. Failure text: `classGuideFitTitles must size a guide title to its 2-line box (13-22 px)`.
- [ ] **Step 2: Run `node scripts/validate_skills.js`** in the worktree. Expected: the new check fails (`classGuideFitTitles` is not defined).
- [ ] **Step 3: Implement `classGuideFitTitles`** as in Interfaces (10 bisection passes).
- [ ] **Step 4: Run the validator.** Expected: `SUCCESS`.

### Task 2: Soft tile cards, title box and hooks

**Files:**
- Modify: `12t_projects/bible/index.html`: `THEME_SURFACES` (line 32 drops `".cg-guide"`, line 34 drops `".cg-page-btn"`); the gilded frame rules (lines 2919, 2920, 2926: `.cg-guide` leaves them, `.rsim-tree-body` keeps its frame); the gallery card block after line 2931 (new Soft tile rules); `guideCard` (line 38667: the title text goes into a `span.cg-title-in` inside the `strong`); the end of `renderGallery` (after `if (wantPage){ … }`); the step 6 preview (line 38171).
- Test: the validator plus a browser check.

**Interfaces:**
- Consumes: `classGuideFitTitles(boxes)` from Task 1.
- Produces: CSS class `.cg-title-in` (`display:block; max-width:100%; font-size:inherit; color:inherit`, so the old `.cg-guide span` 12px grey rule cannot reach the title).

- [ ] **Step 1: CSS.** The card: the spec's hairline, radius, gradient, blur, `box-shadow:0 14px 30px -20px #000`, `border-image:none`; hover / focus lift and gold hairline; order cover 0, chips 1, title 2, foot 3 (rows `auto auto auto 1fr` stay); the foot gets `margin-top:4px; padding:9px 2px 11px; border-top:1px solid rgba(255,255,255,.07)`; the gap card: same radius, `1px dashed rgba(212,175,55,.45)`, fill `rgba(212,175,55,.04)`; `.cg-gallery-edge` and `.cg-page-btn`: hairline `rgba(255,255,255,.12)` / `.1`, fill `.04` / `.03`, blur 8px, page buttons radius 10px, the current page stays solid gold. Desktop title box: `height:calc(2 * 1.3 * 17px); width:100%; display:flex; align-items:center; justify-content:center; line-height:1.3`. Also `.cg-card-preview .cg-guide` must look the same as the gallery card.
- [ ] **Step 2: Hooks.** `guideCard` wraps the title; `renderGallery` ends with `classGuideFitTitles(desk ? [...list.querySelectorAll(".cg-guide > strong")] : [])` and clears inline sizes on phones; the step 6 preview calls the fit on its card on the desktop.
- [ ] **Step 3: Run the validator.** Expected: `SUCCESS`, no `[FONT ERROR]`, `[MOTION ERROR]` or theme errors.
- [ ] **Step 4: Browser check** (Playwright, the worktree served by a scratch `http.server`): 1920 × 1080, 1366 × 768 and 390 × 844, each on the BB, ToT and TTO looks. Expected: the class / server row on one line per card row, every title inside its box (short ones larger, the longest smaller), the gap card dashed, no gilded frame, nothing clipped; page 2 via the arrow is fitted too.

### Task 3: Docs, changelog, commit

**Files:**
- Modify: `.claude/skills/bible-hub-tools/SKILL.md` (the gallery card notes: Soft tile, info-first order, the title box and `classGuideFitTitles`, cards and page buttons out of `THEME_SURFACES`), `12t_projects/bible/index.html` (changelog entry).

- [ ] **Step 1: Update the skill** and prepend the changelog entry: `feat(bible): ไกด์อาชีพ การ์ดในหน้ารวมไกด์โฉมใหม่ การ์ดกระจกบาง ไอคอนอาชีพ เซิร์ฟ PVE อยู่ใต้รูปปกเท่ากันทุกใบ และชื่อไกด์ขยายหรือย่อให้พอดีกรอบสองบรรทัด`
- [ ] **Step 2: Run the validator.** Expected: `SUCCESS`.
- [ ] **Step 3: Commit** in the worktree with the spec and this plan; screenshots to the user; push only when asked.
