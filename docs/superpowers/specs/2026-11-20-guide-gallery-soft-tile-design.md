# Class guide gallery: Soft tile cards (2026-11-20)

## Intent

The gallery cards of ไกด์อาชีพ (ไกด์จากผู้เล่น) jump: the class / server / PVE row sits under the guide title, so a title of 2 or 3 lines pushes that row down and no two cards line up (user 2026-11-20). The user also wants the cards to look clean and modern. Of five mock-ups (the current card, three containerless designs and a light-container one) the user picked **design 4, Soft tile**.

## Goals

- The class / server / PVE row sits at the same height on every card, whatever the title's length.
- A modern, quiet card: thin glass instead of the gilded gold frame.
- The same look on every server (BB, ToT, TTO, Reborn), on the desktop, in the short-window compact mode and on phones.

## Non-goals

- The filter bar above the cards (user 2026-11-20: "this part is already clean, so no need to change").
- What a card shows. Cover, title, class and server icons, PVE / PVP, author, date, completeness stars and readers all stay; only their order and the card's frame change.
- The guide reader, the editor and their gilded frames (`.rsim-tree-body` keeps `--cg-gild`).

## Approaches considered

1. Containerless, info first: no frame or fill, the icon row under the cover. Fixes the jump everywhere, but containerless reads loose on the busy wallpapers.
2. Containerless, rows lined up (CSS subgrid): today's order, every card in a row shares the row's heights. Fixes the jump within a row only.
3. Containerless list: two columns of rows, cover on the left. Densest (about 7 guides a phone screen), but the biggest change.
4. **Soft tile (picked):** a thin glass card, with the icon row under the cover as in 1.

Mock-ups: real gallery DOM captured from the page and restyled (session scratch `mockcap/`, not kept in the repo).

## Design

- **Card:** 1 px hairline `rgba(255,255,255,.09)`, 14 px radius, a faint top-to-bottom white gradient (`.05` to `.015`), the look's own backdrop blur `var(--th-blur,none)` (built with it: the mock's fixed 8 px blur breaks the Popup performance rule, `[PERF ERROR]`), a soft drop shadow. No gilded border image. Hover / focus: lifts 3 px and the hairline turns gold at half strength (a lift and an edge colour, never a glow, per the hover rule).
- **Order:** cover, then the class / server / PVE row, then the title (free to wrap), then the foot pinned to the bottom (the card's last grid row is `1fr`).
- **Title box (desktop, user 2026-11-20: "standardizing and getting rid of the negative space"):** every title gets the same box, 3 lines of 13 px tall (built so: 2 lines of the 17 px title was planned, but the 87-character live title needs 3 lines even at 13 px and spilled over the icons). A small script picks the biggest size that fits, from 13 px up to **22 px**: a short title grows and stays on one line, a 2-line title reaches about 19.5 px, a long one shrinks (the 87-character title fits at 13 px in 3 lines). So every card's content is the same height and no space is left over. A title too long even at 13 px (over about 110 characters; the input allows 160) spills down out of the box (`align-items:safe center`), never over the icons. The mock compared caps of 17, 22 and 27 px: 27 shouted, 17 left space in short titles' boxes. It runs after each gallery render (after its zoom) and on resize, also on the step 6 card preview; phones keep today's titles. The wrapper inside the title (`.cg-guide .cg-title-in`) must outrank the old `.cg-guide span` rule (12 px grey), which broke the first mock and the first build.
- **Foot:** a hairline divider on top, then today's two centred lines (author · date, then stars and readers). A one-line foot was tried in the mock and cut author names to one letter.
- **Gap card** (the dashed "no guide yet" card): same radius, a dashed gold hairline and a faint gold fill.
- **Side arrows and page numbers:** the same glass (hairline, faint fill, the look's blur); the current page stays solid gold.
- **Server looks:** `.cg-guide` and `.cg-page-btn` leave `THEME_SURFACES` (the glass is neutral and reads on every wallpaper), and `.cg-guide` leaves the gilded frame rule.
- **Phones and compact mode:** the existing phone and short-window rules keep working; only the order and the frame change there.

## Left to the builder

Exact selectors, folding the old pre-Medallion `.cg-guide` base rule into the new one, and the step 6 card preview (`.cg-card-preview .cg-guide`), which must match the gallery card. Check in the browser at 1920 × 1080, 1366 × 768 and 390 × 844 on the BB, ToT and TTO looks (a CSS redesign, so a browser check is allowed).
