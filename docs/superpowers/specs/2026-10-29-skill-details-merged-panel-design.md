# Skill details: one toggle panel and collapsible stat panels (design, 2026-10-29)

This covers the skill details tool in `12t_projects/bible/index.html`. Rules that apply to every change there are in `12t_projects/bible/CLAUDE.md`, and the page's UI rules are in `.claude/skills/bible-skill-page-ui/SKILL.md`.

## Why

1. **Repeated toggle clicks miss.** Players click a dependency toggle again and again at the same spot, and the clicks start landing elsewhere. There are two causes:
   - Since 2026-10-28 a desc line shows only while its toggle is on (`hideOffDepLines`). Turning a toggle on adds lines, and the strip (`renderDepStrip`, `.sk-dep-strip`) sits under the description, so it moves down.
   - The desktop page never scrolls. `fitStageToScreen` scales the whole stage to fit the card height (`scale = availH / compH`, transform origin top centre). A taller card therefore shrinks everything and pulls it toward the centre, so even a control in a fixed place moves.
2. **Two panels repeat each other.** The related-skills rail (`.sk-compat-rail`, built from `compatSkills`) repeats links the description already has: 70% of all related-skill links (1,868 of 2,651) are already bold skill links in the card's own desc.
3. **The stat panels are cluttered.** The player and enemy stat panels take a lot of vertical space.

## Goals

1. On desktop, toggles sit in a fixed place. Neither a growing description nor a refit moves them while the player is using them.
2. One panel replaces two: the toggles and the related skills.
3. A related skill appears only when the text does not already link it.
4. The player stat panel and the enemy stat panel can each be collapsed.

## Non-goals and anti-goals

- No "just read" mode, and no hiding of the card's numbers (chips, damage rows, Test). The collapse is only about the two stat panels.
- No change to the data: `compatSkills`, the deps, `DEP_EXCLUSIVE`, the desc texts and the server overrides stay as they are.
- No change to what the toggles do. That covers: rank cycling, merged rank-5 toggles, views, effect tags, desc lines revealed by their toggle, the delta motion and its light balls.
- Desktop still never scrolls (an owner decision).
- Phones get no side panel.
- A failure, even if it technically works: a click on a toggle that can still land on a different control because something moved between two clicks. This guarantee is for desktop (wider than 900 px). Phones scroll, keep today's strip under the description, and get no scroll compensation (call made 2026-10-29, see "Calls made after the builder check").

## What the owner decided

### Desktop: the merged panel

- **It replaces both** the related-skills rail and the toggle strip.
- **It sits where the rail is now:** absolutely positioned to the right of the card, top aligned, about 260 px wide. This is option B of the 2026-10-29 mockups: `docs/superpowers/specs/2026-10-29-skill-details-merged-panel-mockups.html`.
- **Content, top to bottom:**
  1. Gear and condition toggles: everything `renderDepStrip` treats as non-skill today, such as `DEP_NOT_SKILL`, gear tiers, target conditions and modes.
  2. Skill toggles. Each row shows the skill's icon, its name (a click opens that skill's card), the rank pips and the toggle control, with the effect tags kept (`CD`, `CAST`, `DMG`, …). A related skill that is also a toggle appears once, as a toggle row.
  3. Related skills that the description does not already link, as plain rows. A click opens the card.
- **Toggles are grouped by function** (owner 2026-10-29: "grouped by function or topic, ordered by skill ID if it's a skill"). Each group gets a small Thai heading, and an empty group is hidden. Headings show only when the panel has two or more groups. The group comes from the effect tags the strip already computes for each toggle. Groups, top to bottom:
  1. **อุปกรณ์:** gear toggles (gear tiers, `item_` icons).
  2. **เงื่อนไข / โหมด:** target conditions and modes (`DEP_NOT_SKILL` and other non-skill, non-gear toggles).
  3. **ดาเมจ:** skill toggles tagged `DMG`, `HITS`, `KO`, `CHANCE`, `SHIELD` or `STATS`.
  4. **เวลา:** skill toggles tagged `CD`, `CAST` or `DUR`.
  5. **ระยะ:** skill toggles tagged `RANGE`.
  6. **คำอธิบาย:** skill toggles tagged only `INFO`.

  A toggle with several tags goes in the first group of this order that one of its tags matches. Inside a group, skill toggles are ordered by skill ID (`SKILL_INTERNAL_ID`, today's strip order), and gear / condition toggles keep their insertion order. Phones keep today's strip form but use the same grouped order, without headings.
- **"Already linked"** means the description of the server tab on screen already turns that skill into a skill link, by the page's own link rule (`findSkillByMention`, the same path that renders `.sk-desc-skill-link`). That covers English names, Thai names, the "ท่าโจมตีปกติ" wording, names with a rank number and card ids. It includes lines hidden because their toggle is off, since that toggle is on the panel anyway. Each server tab can therefore list slightly different skills. The counts in the table at the end were measured with exact English names only, so they are estimates, not acceptance numbers.
- **Long lists collapse into one row** that opens in place, e.g. "ใช้กับ 27 สกิล ▾". This covers the affected cards of a class-wide modifier (Formless Path 27, Runic Inferno 19, Omni Slayer 17, Reactor Core 17, Carron Gambit 14) and sibling sets (Black Servant's 12 zombies; the 12 Common support skills that list each other). Opening it grows the panel downward only, so nothing above it moves.
- **No panel when it would be empty.** That is 314 of 767 cards; those cards lay out as cards without a rail do today.
- **Scale lock.** While the pointer is inside the panel, or keyboard focus is in it, `fitStageToScreen` keeps the current scale. It refits when the pointer and focus leave, and on a window resize.

### Phones (900 px wide and below)

- The toggles stay where the strip is today: under the description, in today's strip form.
- The related skills the text does not link (with the same collapsing of long lists) move to the very bottom of the tool, after the enemy stat panel.

### Collapsible stat panels

- The player panel and the enemy panel each get a collapse control in their header row (the class badge row with PRESET, and the enemy badge row).
- Collapsed, a panel keeps its header row and hides the stat dials.
- Each panel collapses on its own. The state is remembered in `localStorage` (wrapped in try/catch, as everywhere on the page) and both start expanded.
- Collapsed panels still drive the numbers. Stats, presets, buffs, debuffs and the chosen enemy behave exactly as before.
- On desktop the collapse is about clutter, not card size. `fitStageToScreen` already measures the stats panel's height, so short windows gain a little. The fixed 820 px reference height that sets the scale on tall windows stays unchanged, because changing it would resize every card.

## Must keep working

- **Every strip behaviour now on the panel:**
  - `depSinkAdd` merging and its tags; views (`viewOf`); `DEP_EXCLUSIVE`;
  - the `SKILL_INTERNAL_ID` order, with non-skill toggles in insertion order;
  - `labelFor` / `iconFor`, the 20-letter name limit and the full label in the hover title;
  - `aria-pressed` and the rank `aria-label`;
  - `lineNeedsToggle`, `castDep2`, `cycleRanks`;
  - desc lines revealed by their toggle (`depLineDeps`);
  - the delta motion: pips (`pipPoint`), flips, light balls from the toggle, red balls back into it.
- **While a stat panel is collapsed:**
  - Typing a target value on a chip (`openTargetEdit` / `solveTarget`) still writes into the hidden stat input, and the toast says what changed.
  - A light ball that would start from a hidden stat ring starts from that panel's header.
- **`[PANEL ERROR]` says the enemy panel's show / hide toggle "must stay removed" (added 2026-09-19).** The owner has reversed that: both stat panels now get a collapse control, so update that check instead of tripping it.
- **The validator checks that read the strip move to the panel's markup.** These include `[DEP STRIP ERROR]` (its `splitStrip` looks for `<div class="sk-dep-strip">` and `<!--/sk-dep-strip-->`), `[DEP LINE ERROR]`, `[CAST TOGGLE ERROR]` and `[DEP ORDER ERROR]`. `[COMPAT ERROR]` checks the data and stays.
- **The page's own rules:** the large-file patching protocol and CRLF line endings, the changelog entry, the validator run, the two-font rule, no reduced-motion gates, `THEME_SURFACES` for the new surfaces, hover as a small lift (never a glow), and the server look tokens.
- **Untouched:** the range popup's own toggles and the in-game tooltip modal.
- **Rulebook:** update `.claude/skills/bible-skill-page-ui/SKILL.md` ("Dependency strip", "Phone layout", the stat-panel sections) and `.claude/skills/bible-card-fields/SKILL.md` ("Compatible Skills Navigation") to describe the new layout.

## Left to the builder

- The exact look, following mockup B and the Ledger design: row height, the toggle control (a switch, or the icon as today), and where the effect tags go.
- The size at which a list collapses (about 6 is a reasonable start) and the collapsed row's wording.
- Scale-lock details, including keyboard handling.
- How desktop places the panel on cards that today have toggles but no related skills.

## Calls made after the builder check (2026-10-29)

The owner said "just build it", so these were decided without asking again:

1. **The misclick guarantee is desktop only.** Phones keep the strip under the description (the owner: toggles "stay on similar location" on phones), the page scrolls there, and no scroll compensation is added.
2. **Mockup B is `docs/superpowers/specs/2026-10-29-skill-details-merged-panel-mockups.html`.** Skill rows show the related-skills ring icon, the name with the rank pips under it and a switch on the right. Related-only rows keep the ring icon and name.
3. **The stat-panel collapse does not change the fit rules.** The 820 px reference height stays; on large screens a collapsed panel frees space without enlarging the card.
4. **"Already linked" uses the page's own link rule** (`findSkillByMention`), not exact English names, so Thai names, "ท่าโจมตีปกติ", ranked names and ids count as linked.

## Numbers behind the decisions (rendered on BB, 2026-10-29)

| Item | Value |
|---|---|
| Toggles per card | none on 457 of 767; 1 on 180; 90th percentile 2; most 10 (Left Stride) |
| Related skills per card | median 2; 90th percentile 8; most 33 (Formless Path) |
| Related links already in the desc | 1,868 of 2,651 |
| Related links in no text and not a toggle | 736, on 236 cards |
| Panel size under the rule | empty on 314 cards; median 1 item; 90th percentile 4; most 27 |

## As built (2026-10-29)

Built from the plan `docs/superpowers/plans/2026-10-29-skill-details-merged-panel.md`; these calls refine or differ from the text above.

- **Placement (calls 1, 3):** one `aside.sk-side` in the strip's old slot, placed by CSS only: from 900 px it hangs in the old rail's box beside the card; below 900 px it stays under the description. The related rows render twice (the panel and `.sk-rel-phone`), and CSS shows one. 900 px and up is desktop; the ‹ › buttons now show below 900 px only.
- **Groups and headings (calls 6-8):** one group order everywhere (gear, conditions / modes, then ดาเมจ, เวลา, ระยะ, คำอธิบาย); a skill toggle joins the lowest group any of its tags names (HEAL counts as damage, an unknown tag as คำอธิบาย). Headings show only when the toggle rows span two or more groups (265 tabs), and phones hide them.
- **Rows (calls 9-10):** the toggle button itself is the ring (the Revised Art pattern) and a switch on the right mirrors it; the ring and the switch are the only toggle zones, the switch forwards to the button, and the name line never toggles. Changed after the build (user 2026-10-29): the rows lost their box and the switch (the ring is the only toggle zone), and the tags moved from the right end of the pip line to right after the pips.
- **Name links (calls 11-13):** skill rows and condition rows link the card their shown label names, else the card of their icon key. Every card a skill row can show at any rank counts as covered and leaves the desktop related list; a condition row links its card without covering it.
- **"Already linked" (calls 17-18):** `findSkillByMention` over every `**…**` in the raw desc of the tab on screen at the current rank and toggle rank, hidden lines included, plus the `liveCheck` note. A union over every toggle rank was not built: related rows sit below every toggle and the fold row, so a list change never moves a toggle.
- **Lists (calls 19-20):** phones list compat minus the desc's links (toggle cards included); desktop also drops covered cards. More than 6 rows fold into `ทั้งหมด N สกิล`, opened in place, per card for the visit; an opened list over 8 rows uses the compact 2-column grid.
- **Fit and scale lock (calls 22-27):** compH counts the panel's bottom; the hold region is the panel plus the two stat headers; the pointer is a hit-tested point, focus holds only after a keydown without Ctrl / Meta / Alt; release waits for the click and never runs while a button is down; window resize, tool zoom, tool switch and a new card force a refit; keyboard focus is restored by `data-dep-id`.
- **Stat panels (calls 28-31):** an 18 px chevron at the end of each header's second line, classes on `.sk-stats-panel` with `display:none`, one `localStorage` key; a hidden ring's light leaves from its header. Changed after the build (user 2026-10-29): no chevrons; a click on the header box itself folds and unfolds its panel, with a hover look; a visually hidden button keeps the keyboard path.
- **Found while building:** the desktop strip needed `align-items:stretch` (the base strip centred its items, which shrank the rows to their content).

Measured on the built page (non-stub tabs: 1,649; the oracle and the page agree on every tab):

| Item | Value |
|---|---|
| Tabs with a desktop panel / without | 1,135 / 514 (BB: 274 of 670 cards without) |
| Tabs with headings | 265 |
| Folded lists, desktop / phone | 54 / 55 |
| Most toggle rows | 12 (Bison Combo on Reborn) |
| Longest related list | 27 (Formless Path on Reborn) |
| Condition rows with / without a link | 191 / 27 |
| Related rows, desktop / phone | 1,423 / 1,670 |
| Tallest panel (estimate) | about 709 px (Chameleon Combo on Reborn) |
| Toggle drift over 6 clicks with the pointer on the panel | 0 px on 45 targets at three window sizes (before: up to 81 px) |
