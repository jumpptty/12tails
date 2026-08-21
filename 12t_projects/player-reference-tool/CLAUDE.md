# CLAUDE.md — PlayerReferenceTool

Source of truth for the **"12 Tails Tools"** Artifact — a single-file multi-tool hub for 12TailsOnline reference calculators.

- `index.html` is the full artifact source — edit it directly here, then publish straight from this path (the Artifact tool doesn't require a scratchpad copy). Always pass `url: https://claude.ai/code/artifact/5f024957-09df-4f7c-b4d6-c9f38823e7c8` to update in place — omitting it forks a duplicate artifact. Or just run `/publish-player-reference-tool`.
- Architecture: a `TOOLS` registry array with two entry shapes:
  - **Link-out (default, policy set 2026-08-12)**: `{title, category, icon, url}` — no `id`, no `mount()`. Renders as an `.entry.entry-external` chip that opens `url` (that tool's own separate published Artifact) in a new tab. New tools should be their own Artifact and use this shape — don't merge another project's code into this file. An inline-embed of the GoldenKingBug Spawn Map (Three.js, ~700KB) was tried the same day this policy was set, then fully reverted; don't repeat that.
  - **Mounted (exception, two tools use this — `stat-gain` and `skill-cooldown-lookup`)**: `{id, title, category, icon, mounted, mount(root)}`. Mounts its own DOM/logic into an isolated container on first open, scoped by `data-role` attributes (not global ids) so tools never collide with each other. Hash routing (`#tool-id`) drives which view shows. `skill-cooldown-lookup` (added 2026-08-13) is mounted rather than link-out because it's small enough per the user, matching Stat-Gain's own precedent for the exception.
    - **The shared-`#toolMount`-DOM-clobbering bug this section used to warn about is fixed** (2026-08-13, landed with `skill-cooldown-lookup` since it's what made the bug real instead of hypothetical): `showTool()` used to call every mounted tool's `mount()` against the exact same `#toolMount` div, so a 2nd mounted tool's first open would silently overwrite the 1st tool's DOM via `innerHTML`. Each mounted tool now gets its own lazily-created, persistent container (`getToolContainer()`) inside `#toolMount`, shown/hidden on switch instead of being re-written — verified live (Playwright) that switching Skill Cooldown/Duration Lookup → Stat-Gain → back preserves the first tool's filter/toggle state rather than resetting it.
- To add a new tool: append a link-out entry to `TOOLS` (needs a one-word `category` like `Calculator`, `Lookup`, `Map`, `Guide` — shown as the entry's tag) pointing at that tool's own published Artifact URL. If it ever needs to be mounted instead (the small-tool exception), give each mounted tool its own `getToolContainer()`-managed container — don't reintroduce a shared-container write.

## Content rules (user-specified, always apply)

- No explanations, descriptions, or subtitle copy anywhere in the UI — labels and controls only. No blurb text under entry titles, no intro paragraph under headings.
- Header is plain text `12 Tails Tools` — no icon, no tagline.
- When adding a tool entry or a tool's own heading, do not add a description line under it unless the user explicitly asks for one.

## Design system — "Ledger" direction (est. 2026-08-12)

Visual identity: Thai temple lacquerware — deep lacquer ground, brass-gold ink, a sparing oxblood-red accent — paired with a card-catalog/ledger-index structure (table-of-contents list, not a card grid). Sharp/minimal corner radii (2–3px) throughout, not rounded-lg. Chosen to read as a crafted reference codex rather than a generic dark-mode SaaS dashboard.

The stamped-seal medallion (fox-tail glyph) that originally topped `.ledger-wrap`/`.tool-shell` was removed at the user's request (2026-08-12) — don't reintroduce it or any other icon in the header/panel corners without being asked.

**Tokens** (defined once per theme, dark is primary — see `:root` / `prefers-color-scheme: dark` / `[data-theme]` blocks in `index.html`):
- `--ink` page ground, `--panel` / `--panel-2` surfaces, `--line` hairline borders
- `--gold` brass accent (labels, rules, focus, hover) — the only bright color
- `--seal` oxblood red — reserved for error/validation messages only
- `--text` / `--muted` body copy

**Type roles**: Georgia-family serif for all headings/titles (`h1-h3`, `.entry-title`) — a deliberate workhorse choice, not a trendy display face. System sans for UI chrome/labels/body. `ui-monospace` (`.num` class) for every numeric table cell — ledger/ticker precision, ties to the subject.

**Structure**: menu is a `<ul class="ledger">` of `.entry` chips (mark + title + category tag + arrow) laid out as a **2-column grid** (since 2026-08-12; collapses to 1 column under 560px). Changed from the original full-width single-column row list because a single entry stretched edge-to-edge at 760px looked disproportionately long. Each entry's `category` tag is real taxonomy (Calculator/Lookup/Map/...), not decoration — keep it accurate per tool. Link-out entries get the `→` arrow swapped for `↗` and an `.entry-external` class (diagonal hover-nudge instead of horizontal) so the two entry kinds are visually distinguishable without adding any text.

**Chips are visually disconnected (changed 2026-08-13, user-requested):** each `.entry` is now its own bordered chip (`border:1px solid var(--line)`, own `border-radius:3px`) with a real `14px` grid `gap`, not a shared hairline-divided sheet — `.ledger-wrap` used to carry a solid `--line` background plus a `1px` grid gap so that gap read as dividers between flush cells, with `.ledger-wrap`'s own border/shadow framing the whole thing as one card; that's gone; `.ledger-wrap` is now just a plain layout container with no border/background/shadow of its own. Deliberate reversal of the original "ledger sheet, not a card grid" framing above — don't re-merge the chips back into one bordered sheet without being asked. `.entry` also carries `min-height:100px` (same day, same request) so a 2-line title (e.g. "Skill Cooldown/Duration Lookup") doesn't make that chip visibly taller than its 1-line siblings — measured against the tallest real entry at the time, not an arbitrary round number; re-measure if a much longer title gets added later.

**Skill icons render borderless (2026-08-13, user-requested):** the Skill Cooldown/Duration Lookup tool's large hero icon (`.sk-hero-icon`) and the revisedArt5 toggle icon (`.sk-revisedart`) both used to have a hairline `--line`/`--gold` border box around them; both were changed to `border:none`. Deliberate, not an oversight — don't reintroduce a border on either without being asked. **This is a standing rule for every skill-icon element in this tool, not just those two** — any new one (e.g. `.sk-dep-toggle`, added 2026-08-14 for single-rank dep passives) must render with no button `background`/`padding` box behind the icon either, not just no `border`. Caught once already (`.sk-dep-toggle` was first built copying `.sk-ps-toggle`'s `background:var(--panel-2)` chip styling, which put a visible dark square behind the icon — wrong reference to copy, since `.sk-ps-toggle`'s icon is a generic UI glyph, not a game skill icon; `.sk-revisedart`'s fully-frameless `background:none;padding:0` is the correct pattern to copy for any *skill* icon toggle).

## Skill Cooldown/Duration Lookup — data & UI conventions (session of 2026-08-14)

- **Object/summon lifetimes count as Duration, not just character-applied buff/debuff statuses.**
  Earlier builds excluded a skill's own summoned-object lifetime (a placed mine, a vortex, a channel
  window) from the Duration column on the theory that Duration meant "a status on a character." The
  user overrode this: if the caster's own skill produces something with a real, citable lifespan —
  self-scaled or a bare literal — it belongs in Duration, the same as a target-applied buff would.
  Confirmed cases: Mole's `mine`/`flameCarnival` (prop despawn timers), Penguin's `manaVortex`/
  `tornado` (summon/channel-window lifetimes), Rabbit's `mix`/`shake` (thrown-potion ground lifetime,
  same mechanism as `miracleBlend`), Sheep's `seal` (placed field lifetime).
- **"Enemy-applied debuff, wrong side of the cast" is a distinct, separate exclusion reason from
  CHA-contested.** A value can be completely real and uncontested (computed purely from the caster's
  own CHA) and still get excluded, if `RPC_AddStatus` applies it to `$hitChar$`/`$tChar$` (the target)
  rather than the caster. Confirmed: Cat's `grandCasinoArcade`/`moonBlade`/`moonStorm`/`deltaStrike`,
  Chameleon's `venomShock`/`rustyDecay`, Penguin's `frozenBlast`/`arcticWind` (all applied
  `chaAdjust`-scaled statuses to the hit enemy, not the caster) — don't conflate this with the
  genuinely-contested `Damage.getDebuff(base, casterCha, targetCha)` exclusion elsewhere in these docs.
- **A citable value that IS real can still be the wrong mechanic entirely — verify what it actually
  gates before trusting it.** Two miscites caught and corrected this session: Mole's `flameCarnival`
  reported `chaAdjust(90)` as its Duration, but that's the *unarmed trap's* arming-window timer, not
  the fire hazard's burn time (kept per user request, since it's still a real, useful "how long until
  the trap disappears if untriggered" fact — just needs the right label); Penguin's `iceBlock` reported
  the on-hit `"ice"` debuff's flat `2` instead of the placed block's own `chaAdjust(6)+6` ground-
  lifetime. Both fixed by tracing what the cited `RPC_AddStatus`/`Init()` call is actually attached to
  (a spawned prop vs. an on-hit proc), not just confirming a number exists.
- **`durPostAdd` (schema):** a flat value added *after* `chaAdjust` runs, for skills whose real formula
  is `chaAdjust(base) + N` rather than a single `chaAdjust(base+N)` — Penguin's `iceBlock` is the only
  current user. Renders as `base Xs +Ns` on the stat card, distinct from a dep's `perRank` (which
  modifies the raw value *before* wrapping, not after).
- **`durationInfinite` (schema):** for skills confirmed to summon a persistent `CharacterControl` pet
  with no despawn timer at all (verified by reading the pet's own class file in full, not just absence
  of `RPC_AddStatus`) — renders as a plain `∞` Duration chip, no sub-label. Distinct from a skill with
  no Duration *data* (`—`): `∞` means "confirmed no timer," `—` means "nothing to report." Current
  users: Mole's `barrelBot`, Monkey's `phoenix`/`ja`/`gadina`/`buiten`/`summonGaos`. Two adjacent cases
  were investigated and deliberately left without `∞` pending further verification: Bat's
  `guardianOfTheNight` and Whale's `12thKingdomKnight` both spawn a persistent, no-timer escort, but
  neither is `CharacterControl`-bearing (they're stat-borrowing `MonoBehaviour` companions riding the
  owner's own combat stats) — see the judgment-call note in
  `12t_reference/monkey-skill-reference.md` for the full reasoning.
- **Hover probability tooltip:** hovering either stat's big number reveals every distinct outcome the
  LCK roll can actually produce and its real probability — not a naive assumption that the
  `[min,max]` range is uniformly likely. Built by evaluating `agiAdjustAtRoll`/`chaAdjustAtRoll` (in
  `index.html`, near the range functions) once per possible roll (`0` to `ceil(0.2×LCK)`, every value
  equally likely) and bucketing by whatever that roll's value actually displays as — so it faithfully
  shows both **skipped** values (gaps the curve never lands on) and **merged** ones (several different
  rolls landing on the same displayed number), rather than inventing a smooth uniform ladder.
  Positioned *below* the whole stat card (anchored to `.sk-stat`, not the number itself) so it never
  covers the hero icon/name or the sibling stat's own number — an earlier version anchored above the
  number and covered the header instead. Long spreads (LCK can produce 20+ distinct outcomes) render in
  2 columns instead of one tall list (`renderProbabilityTooltip`'s inline `column-count`/`width`, not
  pure CSS, since CSS multi-column needs an explicit container width to know how many columns fit).
- **Display precision is 2 decimals, not 1 (changed at the user's request).** The underlying
  `agiAdjust`/`chaAdjust` formulas are genuine floats with no in-game rounding of their own
  (`addTimeOut`/`getTimeOut` stay `float` end-to-end in the decompiled source) — 1 decimal was
  discarding real precision, not just extra display noise. `fmtOne()` uses
  `parseFloat(v.toFixed(2)).toString()` to trim trailing zeros (`45.00`→`45`, `44.80`→`44.8`) rather
  than a regex.
- **A shared `addTimeOut` cooldown-lock key (`cType` string) does NOT mean two skills are "the same
  skill" — don't fold one into the other's row.** Caught twice in one day (2026-08-14, both user
  overrides of an earlier pass's judgment call — this is a real recurring engine pattern, not a one-off):
  Whale's `flyingShield`/`homingShield`, and Panda's `tigerToss`/`climbingCliff`/`crumblingMountain`. In
  both cases an earlier pass folded the upgrade-tier skill's higher cooldown into a citation footnote on
  the base skill's row instead of giving it its own `SKILLS` entry, reasoning that both cast sites arm
  the same string-keyed timer (`"flyingShield"`; `"tigerToss"`). The user corrected this both times —
  they're genuinely separate active skills (distinct action codes/`RPC_*` coroutines/flavor text/in-game
  toast strings) that just happen to reuse one timer key in the engine, not variations of one cast.
  **General rule for future class audits: two `getSkill()` entries with materially different
  mechanics/flavor text each get their own row even if they share a `cType`/cooldown-lock string — the
  lock name is an implementation detail, not a skill identity.** The flip side, also confirmed twice
  (Whale's `overPresence`→`heavyWeight` precedent predates this session; Panda's `tigerPounce`/
  `crushingMonolith` this session): a skill can share a `getSkill()` roster slot's *fallthrough* with
  another skill's `cType` as a genuine dead-code/obfuscation artifact with **no cast site of its own at
  all** (no `addTimeOut` anywhere in the class file) — that case really is "no cooldown, exclude it," and
  the distinguishing test is exactly that: does `grep`ing the class file for `addTimeOut("<name>"` (or the
  skill's own coroutine) turn up a real, independently-triggered cast site, or nothing at all. See
  `12t_reference/whale-skill-reference.md`'s `homingShield` note and
  `12t_reference/panda-skill-reference.md`'s Tiger Toss family note for the full citations.
- **"Not yet in `SKILL_ICONS`" does NOT mean "no icon exists" — check `RippedAssets`, not just this
  file, before reusing another skill's icon as a placeholder.** Caught 3 times in one session
  (2026-08-14, all user corrections): when `homingShield`/`climbingCliff`/`crumblingMountain` were first
  added, a `grep` for their name against the *already-extracted* `SKILL_ICONS` blob in `index.html` came
  up empty, and that was wrongly read as "the game has no distinct icon for this skill" — so all three
  borrowed their "parent" skill's icon (`homingShield` → `flyingShield`'s; the other two → `tigerToss`'s).
  Wrong test: `SKILL_ICONS` only contains whatever a *previous* session happened to extract, which is
  never the full available set — these three simply hadn't been extracted yet because they weren't
  `SKILLS` rows before this session. The real source of truth is
  `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/<skillName><rank>.png`
  (confirmed present for all three: `whale/homingShield5.png`, `panda/climbingCliff1.png`,
  `panda/crumblingMountain1.png` — all real 64×64 RGBA PNGs, same format as every other extracted icon).
  **Rule going forward: before pointing a new `SKILLS` entry's `icon` at another skill's key, `find
  RippedAssets -iname "<skillName>*.png"` (or check the `gamegui/icons/skills/<class>/` folder directly)
  first — only fall back to borrowing an icon if that comes up genuinely empty.** Rank-suffix convention
  for the extracted key: matches the `SKILLS` entry's own max rank (`comboLink1`/`qiStrike3`/`roll2` all
  match their table's Max Rank column), *except* when the in-game identifier itself is a "N5"-style
  evolution skill with only one icon file on disk at that literal suffix (Whale's `homingShield5.png`,
  same shape as the pre-existing `bubbleBurst5.png`→key`"whale_bubbleBurst1"`/`revitalize5.png`→key
  `"whale_revitalize1"` pattern) — there, key it under the tool's normal rank-1 convention but source the
  file at its real on-disk suffix. To extract: `base64 -w0 <path.png>` prefixed with
  `data:image/png;base64,`, inserted as a new `"<class>_<skillName><rank>": "..."` entry in
  `SKILL_ICONS` near its family's existing icons (not appended at the end) for locality.
- **Both mounted tools now run a no-scroll "fit one screen" mode (`html.tool-fit-screen`, added
  2026-08-14 for `skill-cooldown-lookup` first, direct response to a user screenshot; extended the same
  day to `stat-gain` after the user pointed out its results view had the identical scrolling problem —
  don't re-scope this back down to one tool, it's a shared mechanism now).** Toggled in
  `showTool()`/`showMenu()` for both `skill-cooldown-lookup` and `stat-gain`; link-out tools and the menu
  view never get it. Every `.sk-*` padding/margin/font-size was retuned tighter, sized against Sheep's
  `bless` (wrapped cooldown *and* duration plus a `cdDep` toggle block — the tallest real card) at a
  short/wide window (2559×882, the user's own reported window size), not a generic desktop breakpoint;
  `.sg-*` got the same tightening pass, sized against its results table, which is always exactly 8 rows
  (one per stat) regardless of the level range entered — a fixed, bounded size, not a per-level table, so
  it needs no internal-scroll fallback the way the skill-lookup tooltip below does. The
  hover-probability tooltip (`renderProbabilityTooltip`/`positionStatTooltips`, both in
  `mountSkillCooldownLookup`) now prefers rendering in the empty gutter beside the centered 760px stage
  on wide screens instead of dropping below the card, falling back to the original below-card placement
  when the gutter is too narrow. Two real CSS traps hit and fixed while building this, both worth
  knowing before touching this area again:
  - `.stage{max-width:760px; margin:0 auto}` is the classic block-level "centered container" trick, which
    silently breaks if `.stage` ever becomes a flex item (e.g. by making `body` `display:flex` for the
    fit-screen layout): a flex item with auto margins on the cross axis is *not* stretched by default, so
    it shrinks to content width instead of filling to `max-width`. Fixed by pinning `width:100%` on
    `.stage` inside `html.tool-fit-screen` specifically — needed only there, since only there is `body` a
    flex container.
  - `position:fixed` is not reliably viewport-relative on this page: `.view`'s own entrance animation
    (`animation: viewIn ... both`, targeting `transform`) makes `.view` a permanent containing block for
    fixed/absolute descendants per spec, *even once settled at `transform:none`*, because a filled
    animation targeting `transform` counts regardless of its current keyframe value. `positionStatTooltips`
    accounts for this by reading `tooltip.offsetParent` (null = genuinely viewport-relative, e.g. under
    `prefers-reduced-motion`; otherwise the actual containing-block ancestor) rather than assuming `left`/
    `top` are viewport-relative. Relatedly, `.stage` itself must NOT have `overflow:hidden` (only `body`/
    `html` do) — the gutter tooltips render outside `.stage`'s own (narrower, centered) box on purpose,
    and `.stage{overflow:hidden}` would clip them even though they visually sit beside it, because the
    `.view` containing-block quirk above makes them layout descendants of that subtree regardless of
    their fixed positioning.
- **Stat-Gain Calculator has a faint per-class line-art backdrop (`CLASS_ART`, added 2026-08-14).**
  Source: `RippedAssets/.../gamegui/story/characters/<Class>.png` — the game's own story-mode dialogue
  portraits, NOT the character-creation screen's `char_<Class>.png` (that one's a 512×512 square crop
  with the character's own extremities touching the frame edges on every side; the story portraits keep
  each class's natural, less-cramped aspect ratio instead). Extracted as pure outline art, not the
  full-color original: a small Python/PIL script (`extract_outline.py`, scratchpad-only, not checked in)
  thresholds each portrait's luminance at <35 and keeps only those near-black pixels as opaque black on
  a transparent field, discarding every fill color — this isolates the artist's own ink strokes (this
  game's art style already draws a distinct flat-black outline around every shape) rather than doing
  generic edge detection, which would also pick up color-transition edges inside the fills. A threshold
  of 70 was tried first and rejected: it also kept solid dark-colored fill regions (gloves, boots) as
  flat black blobs instead of just their outlines. Result compresses extremely well (~140KB for all 12
  combined, PNG on mostly-transparent pixels) — cheaper to embed than the char_ art would have been even
  before considering the crop problem.
  Rendered via CSS `mask-image` (`.sg-art`, `render()` sets `art.style.maskImage`/`webkitMaskImage` per
  selected class), not a plain `background-image` — this recolors the line art at render time instead of
  shipping a fixed black PNG that would nearly vanish against the dark-mode panel. Fill color is
  `var(--gold)` at `opacity:.35` (changed same day from an initial `var(--text)`/`.1`, then `--gold`/`.16`
  — both were "still too hard to see" per direct user feedback; `.35` is the value that actually reads
  clearly as a recognizable portrait in both themes while the table text on top stays fully legible —
  don't reflexively re-mute this back down without checking a live render first). Positioned at the
  **left** edge (`.sg-art{left:0; right:30%;
  mask-position:left bottom}`) — tried right-aligned first since that's a common "big splash art in a
  stat panel" convention, but the user corrected it: this game's own dialogue portraits appear at the
  left edge of the screen, so left-aligned is the one that actually matches genuine convention here, not
  a broader generic-UI assumption. `.sg-inner` needs `position:relative` as `.sg-art`'s containing block;
  `.sg-controls`/`.sg-msg`/`.sg-results`/`.sg-foot` each need their own `position:relative` too — not for
  their own positioning, but so they establish a stacking context that paints *after* (on top of) the
  absolutely-positioned `.sg-art`, which appears earlier in the DOM. Without that, they'd stay
  non-positioned and actually render *behind* an absolutely-positioned earlier sibling per normal CSS
  stacking order — the opposite of what "backdrop" requires.
- **Skill Cooldown/Duration Lookup got the same `CLASS_ART` backdrop too (`.sk-art`, added 2026-08-14,
  same day as `.sg-art` above) — right-aligned and horizontally mirrored, not a copy of `.sg-art`'s
  left-aligned setup.** This tool's own content (search box, hero icon+name, stat boxes) is left-aligned,
  so the user asked for the portrait on the right instead, flipped so the character faces the correct way
  for that side. Implementation notes specific to this tool, don't lose these re-deriving them later:
  - **Reuses the exact same `mask-position:left bottom` as `.sg-art`, not `"right bottom"`** — this is
    intentional, not a copy-paste miss. `.sk-art{right:0; left:30%; transform:scaleX(-1)}` first
    positions the *box* at `.sk-hero`'s right side, then `mask-position:left bottom` hugs the art to that
    box's own *left* edge, and `scaleX(-1)` mirrors the whole rendered box (art shape **and** its position
    within the box) around the box's center — so content that was hugging the box's left edge pre-transform
    lands hugging the box's right edge post-transform, which (since the box itself sits at `.sk-hero`'s
    right side) is what actually puts the character flush against `.sk-hero`'s true right edge while also
    flipping it to face left. Using `"right bottom"` here would have the transform cancel the positioning
    back out to the wrong side instead of compounding correctly with it — verify with a live render before
    ever touching this, the two-step interaction is not obvious from reading either line in isolation.
  - **The mask-image must be set via `artEl.style.maskImage`/`webkitMaskImage` (a DOM property), never
    baked into the `renderHero()` template string as an inline `style="..."` attribute.** Caught live: the
    first attempt wrote `style="-webkit-mask-image:url("${artUrl}")"` directly in the template — the data
    URI's own embedded `"` characters closed the HTML `style="..."` attribute early, silently truncating
    everything after `url(` (confirmed via `getComputedStyle` showing an empty mask and a mangled
    `getAttribute("style")`). Fixed by rendering a bare `<div class="sk-art" data-role="art"></div>` in
    the template and setting the mask via JS property assignment right after `displayEl.innerHTML` runs
    (same spot as `positionStatTooltips()`) — DOM property assignment never goes through HTML attribute
    parsing, so embedded quotes in the data URI can't collide with anything. `.sg-art` in Stat-Gain
    already used this pattern for the same underlying reason; don't reintroduce the inline-template-string
    version for any future per-class-art element.
  - `.sk-hero`/`.sk-hero-head`/`.sk-hero-stats` need the same `position:relative` treatment as Stat-Gain's
    siblings, for the same stacking-order reason described above.
- **`.sk-art` was moved again same day: out of `.sk-hero` entirely, up to being `.sk`'s own first
  child.** First landed inside `.sk-hero` (spanning only the hero card's own height); the user then
  asked for it to span the tool's *full* height — controls row, search box, and hero card all together,
  per a reference screenshot showing the art starting above the AGI/CHA/LCK row, not at the hero card's
  top edge. `.sk` itself is now the `position:relative` containing block (not `.sk-hero`, which reverted
  to no explicit `position:relative` — it wasn't needed for anything else). Because `[data-role="display"]`
  (and everything inside it, including `.sk-hero`) gets fully rewritten by `renderHero()`'s
  `displayEl.innerHTML = ...` on every skill change, `.sk-art` had to move to a *persistent* element
  queried once (`artEl`, alongside `agiEl`/`curEl`/etc.) rather than living inside that per-render
  template — otherwise every re-render would destroy and recreate it. `renderHero()` now just mutates
  `artEl`'s existing mask/visibility instead of rendering a new one.
- **Real bug caught in this same change: `mask-image: "none"` does NOT hide an element — it means "no
  mask applied," i.e. the element renders its full, unclipped, un-masked box.** The empty state (no skill
  selected yet) originally set `artEl.style.maskImage = "none"` intending to hide the backdrop, which
  instead drew a solid `var(--gold)` rectangle across the whole card (confirmed live via screenshot — a
  stark vertical color split at the `left:30%` box edge). Only `.sk-art` exposed this visibly, because
  Stat-Gain's `.sg-art` has the same latent issue in its own pre-selection (locked) state but happens to
  be fully covered by `.sg-gate`'s dark backdrop the entire time it would be affected — not because it was
  actually fixed there, just accidentally hidden. Fixed properly in both: `visibility:hidden` is now each
  art element's CSS default (base `.sg-art`/`.sk-art` rules), and JS only ever flips
  `visibility:"visible"` at the same moment it assigns a real `mask-image` url — mask-image and visibility
  are always set together, never mask-image alone. Don't reintroduce a bare `mask-image:"none"` as a hide
  mechanism anywhere this pattern gets reused.
- **The LCK-probability tooltip's column layout went through two fix passes the same day (2026-08-14,
  both user-reported) — the flat "2 columns if >12 rows" rule described in older commit messages no
  longer exists; don't reintroduce it.**
  - **Pass 1 — keep the tooltip on-screen at all.** A flat `max-height:80vh` CSS fallback doesn't know how
    far down the screen the tooltip's own anchor point already is — a high enough LCK produces enough
    distinct rolls that the list could still run past the viewport's bottom edge when anchored low, with
    no page scroll to reach the rest (this tool runs in the no-scroll "fit one screen" mode).
    `positionStatTooltips()` (`mountSkillCooldownLookup`) computes a real per-render cap on every call —
    `window.innerHeight - anchorTop - 16px` — for both the gutter-positioned case and the below-card
    fallback case. The CSS `max-height:80vh` stays as a pre-JS fallback only.
  - **Pass 2 — stop being stingy with the space that's actually available.** The first pass still capped
    at a flat 2 columns and relied on scroll for anything longer, which the user pushed back on: gutter
    mode especially had real width going unused while the list scrolled unnecessarily. Fixed by computing
    columns dynamically instead — `positionStatTooltips()` now picks exactly as many columns as the
    outcome list *needs* to fit `availableHeight` without scrolling, capped only by how many columns
    actually fit `availableWidth` (measured live: gutter width in gutter mode, or in fallback mode `2 ×
    min(distance from the stat box's own center to each screen edge)`, since the fallback tooltip is CSS-
    centered under `.sk-stat` itself, not the viewport — sizing it off the full window width let it run
    past whichever edge was closer to an off-center stat box, caught live as a real overflow).
  - **Real bug hit mid-Pass-2, worth remembering if this area gets touched again: CSS `column-count` is a
    *target*, not a hard cap.** The first implementation of dynamic columns still used CSS
    `column-count:N` + an explicit `width`. When the computed `N` didn't actually balance the row count
    into that many columns within the tooltip's own `max-height`, the browser silently rendered *more*
    columns than `N` to fit everything, growing `scrollWidth` past the set `width` — and since
    `overflow-x:hidden` was already in place (from Pass 1's scrollbar-collision fix), those extra columns
    were being **clipped invisibly**, hiding real outcome rows with no way to reach them at all — a worse
    regression than the vertical-scroll problem the user originally flagged. Fixed by abandoning CSS
    multi-column layout entirely: rows now render into one flat list first (`renderProbabilityTooltip`),
    then `positionStatTooltips()` explicitly rechunks them into exactly `cols` real `.sk-stat-tooltip-col`
    flex-column elements (re-parenting the existing row nodes, not rebuilding them), giving deterministic
    control instead of trusting the browser's own column-balancing heuristics. Safe to re-run on every
    call (including window resize) since it always starts by re-collecting every row via
    `.sk-stat-tooltip-row` regardless of current chunking, then rebuilds from scratch.
  - In the genuinely tightest cases (narrow viewport, tooltip anchored low, e.g. ~140px of both width and
    height to work with), the width-driven column cap can still be lower than what height alone would
    allow scroll-free — that's fine and expected: `overflow-y:auto` remains the last-resort fallback
    there, and unlike the clipping bug above, scrolled content is still genuinely reachable, not lost.
  - **Follow-up (2026-08-14, same day, user-reported): "genuinely reachable" still wasn't actually usable.**
    The tooltip is `pointer-events:none` while merely `:hover`-visible (so it never steals the hover off
    the number), but that also meant the cursor had to leave the number to reach the tooltip and use its
    scrollbar — which dropped the `:hover` and hid the tooltip before the cursor ever got there. Two
    additions in `setupStatTooltipInteractions()` (called from `renderHero()` right after
    `positionStatTooltips()`, re-attached on every render same as the other per-render listeners):
    a `wheel` listener on `.sk-stat-value-wrap` itself that redirects `deltaY` straight into the
    tooltip's `scrollTop` — the cursor never has to leave the number to scroll it — and click-to-pin
    (`.pinned` class, toggled on the wrap, checked in the same CSS rule as `:hover`) so the tooltip stays
    open with the cursor anywhere else entirely, with `pointer-events:auto` added only in the pinned
    state so a reachable, actually-hovered tooltip behaves like a normal element (native scroll,
    selection, etc.). Only one tooltip pins at a time; a `document`-level click listener (registered once
    in `mountSkillCooldownLookup`, **not** inside `renderHero()` which reruns per skill — would leak a new
    listener every render) unpins on any click outside the pinned number, guarded by the wrap's own click
    handler calling `stopPropagation()` so clicking the number to pin it doesn't immediately unpin itself
    via bubbling. Also removed the `.sk-stat-tooltip-col` divider border the same day (user-requested) —
    columns are now spaced by `padding-left` alone, no `border-left`.
- **Cast Time — third `.sk-stat` chip, added 2026-08-14, MAG(INT)-adjusted, skipped entirely when a skill
  is instant.** `CharacterControl.magAdjust(t)` (`CharacterControl.cs:20584-20589`) is a genuinely
  different formula shape from `agiAdjust`/`chaAdjust`: `n = clamp(INT+R, 1, 512)` then
  `t - floor(n/32)` — an **integer** divide in source (floor, not a smooth curve), then clamped to
  `[0.1, 600]`. `magAdjustAtRoll`/`magAdjustRange` (`index.html`, right after `chaAdjustRange`) replicate
  the floor exactly via `Math.floor(n/32)` — don't "simplify" this to a continuous formula, the coarse
  stepping is real (at the default INT=128/LCK=128, most skills show a flat single number instead of a
  range, because every roll in that LCK spread still floor-divides into the same `/32` bucket — this is
  correct behavior, not a bug to chase).
  - Only ~1/3 of skills across all 12 classes have a real cast time at all (104 of 306) — most active
    skills are instant, no `magAdjust` call anywhere in their cast coroutine. Data was gathered by
    dispatching one `mechanics-researcher` subagent per class in parallel, each grepping `\$mCastTime\$\d+
    = ` (a compiler-mangled temp var) in `<Class>.cs`, tracing every hit back to its enclosing
    skill-name switch/if-chain, and cross-referencing the skill's already-verified Max Rank from
    `12t_reference/<class>-skill-reference.md` to resolve rank-scaling formulas
    (`base + perRank*sLv`-shaped) to one number. **`sLv` in these cast-time formulas is 1-indexed, equal
    to the real in-game rank number** (confirmed independently across 6 different classes by tracing each
    one's own call sites, e.g. `RPC_cast1("phantomBane", ..., 1/2/3/4)`) — not 0-indexed. Every class also
    has 2-3 universal, non-skill `magAdjust` sites (`mount`, `activateIcon`, sometimes `coin`) that look
    like roster skills at a glance but aren't — excluded the same way the cooldown reference docs already
    exclude `mount`.
  - **Two judgment calls from this pass, not fully clean-cut:**
    - `rabbit_contract`'s `sLv` parameter isn't a skill rank at all — it selects which of 3 NPC allies to
      summon (Panther/Leopard/Golem) based on the caster's SP, each with its own cast time (6/9/12s), and
      the skill only has one true learnable rank. Reported the floor value (6s) as `castTime`, matching
      the doc's Max Rank 1 — a real player will sometimes see 9s or 12s instead depending on summon type,
      which this tool doesn't currently distinguish.
    - `chameleon_tent` has a **second**, independently-`magAdjust`-wrapped 12s delay after its reported 6s
      windup (a channel-lock before the caster regains control, `Chameleon.cs:36128`) — reported only the
      first-phase 6s as `castTime` (consistent with every other skill's "delay before the cast bar
      finishes" definition), not the combined ~18s total lockout.
  - **`castDep` — added same day, 2 real cases (user-requested).** Mirrors `dep`/`cdDep`'s shape and reuses
    `getDepRank`/`renderDepBlock` unchanged, but its raw-value resolution does NOT reuse
    `depPostMultiply`-after-adjust the way Duration's `dep` does (verified against Wolf's `darkEdge`) —
    both known `castDep` cases apply **before** `magAdjust` in source, so `castBlock`'s own `rawCast`
    computation folds the dep in first (linear formula or `Math.floor(base*multiplier)`), then feeds that
    into `magAdjustRange` directly. Don't "simplify" this to match the Duration pattern — the order is
    correct as different from it, not an inconsistency to fix.
    - **Chameleon `slayer`/`allSlayer`**: `castDep` on "Improved Slayer" (`getImprovedSlayerLv()`,
      `Chameleon.cs:9501`, `hasSkill(351-354)`, 4 real ranks) — `slayer` formula
      `2 + 0.5*lv` (`Chameleon.cs:30406`), `allSlayer` `4 + lv` (`Chameleon.cs:32381`). 5-rank spread
      (0-4) renders as the numbered stepper (`renderDepBlock`'s `>1` branch), same shape as Rabbit's
      Medical Enhancement/Alchemist Lab deps — this is a genuinely different passive from the Cooldown
      side's `improvedSlayerLv` note already in this doc's Cooldown section (there is none — Cooldown for
      these two is flat `agiAdjust`-only, this dependency is Cast-Time-only).
    - **Whale's 8 `reducedCast`-affected skills** (`bubbleShield`, `heavyWeight`, `hydroBlast`,
      `rejuvenate`, `callToArm`, `salvation`, `megalodon`, `revitalize`) — `hasSkill(373)` halves
      `mCastTime` via `Mathf.FloorToInt(0.5*mCastTime)` (`Whale.cs:21237-21243`) **before** the shared
      dispatcher's `magAdjust` call (`:21249`). Single boolean check confirmed exhaustive (`hasSkill(373)`
      appears exactly once in `Whale.cs`) — no other skill is affected. `kind:"postMultiply"`,
      `multipliers:[1,0.5]`, single shared `WHALE_REDUCED_CAST_DEP` object (not a per-skill factory like
      `whaleKnightDep` — no per-skill variation to carry, so one object reference works for all 8; state
      sharing is keyed off `dep.id`, not object identity, so this is equivalent to 8 separate objects with
      the same `id`). Renders as a single icon toggle (`maxRank-minRank===1`), same visual language as the
      existing `knightOfTheDeep` Cooldown toggle — a **different** passive from `knightOfTheDeep` (that
      one only touches Cooldown on 6 skills; this one only touches Cast Time on a mostly-overlapping-but-
      not-identical 8-skill set — don't merge the two into one dep, they're independently toggleable in
      the live game).
  - **A 3rd chip meant the fixed 760px `.stage` was too cramped** (each `.sk-stat` would have had to
    shrink well below its old 220px flex-basis to avoid wrapping the 3rd box to its own row) — the user
    pointed out the side gutters reserved for `positionStatTooltips()` have far more room than the hero
    card actually needs, so it's fine to widen. Added `html.tool-wide-hero` — a dedicated class (same
    mechanism as `html.tool-fit-screen`: toggled in `showTool()`/`showMenu()`, `tool.id ===
    "skill-cooldown-lookup"` only) that bumps `.stage`'s `max-width` from 760px to 940px **only while this
    tool is open** — the menu ledger and Stat-Gain keep the original 760px untouched. `positionStatTooltips()`
    itself needed no changes — its gutter width is computed live off `.tool-shell`'s actual rendered rect at
    render time, not hard-coded against 760px, so it stays correct at the wider stage automatically.
  - **Superseded same day: `.sk-hero-stats` switched from flex to CSS grid** (`display:grid;
    grid-template-columns:repeat(3,1fr)`), replacing the flex-basis approach described just above — the
    flex version's `flex-grow` stretched whichever 1-2 boxes existed to fill the row whenever the 3rd was
    absent, which the user flagged as wrong: a Cooldown+Duration-only skill's two boxes should render at
    the same width as a 3-stat skill's, with the missing Cast Time slot just blank space, not have its
    neighbors balloon into it. `.sk-stat-cd`/`.sk-stat-cast`/`.sk-stat-dur` each pin `grid-column` (1/2/3)
    on their respective box — required because the boxes are conditionally rendered (a skill with no
    Duration never emits that `.sk-stat` at all), and grid's default auto-placement would otherwise pack
    whichever boxes DO exist into the first open columns left-to-right (e.g. Duration landing in column 2
    on a Cast-Time-less skill) rather than keeping each stat pinned to its own column regardless of what's
    missing. `min-width:0` on `.sk-stat` carries over unchanged from the flex version — grid items have the
    same default `min-width:auto`-from-unshrunk-content gotcha flex items do.
  - **Dep toggles/steppers and the private-server toggle moved into the box's own bottom-right corner
    (`position:absolute`) instead of stacking as a new bordered row below the base-value line** — also
    user-requested, same pass. Previously `.sk-dep`/`.sk-ps-toggle` sat in normal flow with a
    `margin-top`/`border-top` separator, which grew whichever box had one taller than its siblings (e.g. a
    skill with a Cooldown-side dep had a visibly taller Cooldown box than its own Cast Time/Duration boxes,
    and taller than a different skill's dep-less Cooldown box). Bottom-right, not top-right: `.sk-stat-base`
    is short, narrow, left-aligned text, so sharing its vertical band leaves real horizontal room on the
    right for a corner block; `.sk-stat-value` above it is the one element that can run wide enough (e.g.
    "68.09-75s") to actually collide with a top-right corner instead. Confirmed via grep before making this
    change that no `SKILLS` entry sets both `ps` and a dep on the same box, so both safely share one corner
    rather than needing separate positions. `.sk-dep`'s two shapes (single toggle vs multi-rank stepper)
    were also shrunk a notch for corner-fit safety (dep icon 18px→16px, toggle icon 34px→28px, rank buttons
    26px→22px, label 10.5px→10px) — **not visually verified live** (no browser tool available this
    session); if a future dep ever needs an unusually long label, check this corner for real overlap with
    `.sk-stat-value` before assuming it still fits.

## Known issues / deferred fixes

- **Arrow-key skill navigation order — interim fix landed 2026-08-14, real fix still deferred.**
  `SKILLS_ORDERED` (`index.html`, right after the `SKILLS` array closes) was first built as
  `[...SKILLS].sort()` by `class` then by the string `id` field (e.g. `"bat_blackServant"`) —
  alphabetical by skill *name-as-written-in-code*. That broke immediately in practice: it silently
  diverged from the search dropdown's own order (which just preserves `SKILLS`' array/definition order),
  so arrowing through a class didn't match what its dropdown entries showed, and felt like it randomly
  jumped to the next class early. Fixed same-day by setting `SKILLS_ORDERED = SKILLS` directly — every
  class is already one contiguous block in the raw array (verified), so this now matches the dropdown
  exactly. **This is still not the user's actual end goal.** They want navigation ordered by each skill's
  real **in-game numeric skill code** (the `commandNum`/`hasSkill(N)` IDs seen throughout the decompiled
  source, e.g. `RabbitSkill.cs`'s `commandNum` switch, `WolfSkill.cs`'s equivalent — a different per-class
  numbering scheme than either the string `id`s or the array's own definition order). `SKILLS` has no
  field for that numeric code today; adding it means sourcing each skill's real number from its class's
  own `<Class>Skill.cs` `commandNum`-to-name switch (the exact lookup pattern used repeatedly this
  session, e.g. Rabbit alchemistLab1-4 = 231-234, Wolf perseverance1/2 = 121/122) — a real per-skill
  research pass across all 12 classes, not a quick fix, which is why it's still deferred.

## Research policy, set 2026-08-20: chip layout is now considered complete — research every field per skill

Every dated pass below this line up through the `lckProc` pilot was scoped narrowly — one new mechanic
(KO, Cast Time, a specific dep, a specific chance-proc) added to a hand-picked skill or two at a time,
because the CHIP SHAPES themselves were still being designed and iterated (the whole `.sk-hero-stats`/
`.sk-dmg-row` grid, the KO badge, the `lckProc` 4th slot, the Simulate popup) — there was no stable target
to research every skill's data against yet. **User's own framing: now that the layout itself is done, the
posture for any future skill work flips** — going forward, working on a skill means checking it against
**every** field this tool now supports (Cooldown, Cast Time, Duration, Damage Formula/Raw Damage/Final
Damage, KO, `lckProc`, and any per-skill dep/mult/replace mechanism those chips can carry), not just
whichever single mechanic prompted the pass. Concretely: don't stop at "does this skill have a Cast Time"
once that's confirmed — also check whether it has a real, previously-unresearched KO value, an
`lckAdjust`-gated proc chance, a Class C dep affecting any of the above, etc., the same multi-field sweep
this file's own KO section (2026-08-19) had to run TWICE because the first pass only checked a hand-picked
skill list instead of the full roster. Existing per-class reference docs (`12t_reference/*-skill-
cooldown-reference.md`, `*-skill-damage-reference.md`) remain the citation trail for whatever's found —
this policy changes how thoroughly a skill gets checked when it's touched, not where the findings get
written down.

**Penguin (the pilot class) declared fully complete, 2026-08-20** — user's own call, marking the close of
the class that drove every chip this tool has (rank selector, Damage Formula, KO, `lckProc`, …). The
other 11 classes are NOT held to this same "fully complete" bar retroactively — most still only have
Cooldown/Cast Time/Duration data (`*-skill-reference.md`), with Mole the only other class to also get the
damage-formula treatment (`mole-skill-damage-reference.md`) so far. Going forward, per the policy above,
any class touched again gets swept for every field — but "touched" is still per-class/per-skill, not an
instruction to retroactively backfill all 12 classes to Penguin's depth in one pass.

## Rank selector + damage formula — Penguin pilot (2026-08-14)

**Scope: Penguin's 27 `SKILLS` entries only.** The other 11 classes are untouched — no `maxRank`, no
per-rank `cd`/`castTime` arrays, no `dmg`. This was deliberately built as a pilot on one class before
deciding whether/how to roll it out further; don't assume the mechanism below "just works" for another
class without first checking that class's own cooldown/damage citations the same way Penguin's were.

**Rank selector.** `selected.maxRank` (new field, every Penguin entry now has one, even `maxRank:1`
skills) drives a click-to-cycle-rank interaction on the hero icon: `.sk-hero-icon-btn` wraps the icon in
a button when `maxRank>1`, cycling 1→2→…→maxRank→1 on click via a new `skillRanks` state object
(`getSkillRank()` — same "persist per id, default to max" convention as `depRanks`/`getDepRank()`).
Single-rank skills keep the old plain `<img>`, nothing clickable.
- **The icon itself swaps per rank** (user-requested — no separate "Rank X/Y" text badge). `heroIconKey`
  strips `selected.icon`'s trailing digit(s) and appends the selected rank — but ONLY when `maxRank>1`.
  This matters: several Penguin skills' real icon file doesn't end in a digit matching their rank at all
  — `tripleCast`'s only real asset is `tripleCast2.png` (maxRank is 1; "2" is its position in the shared
  doubleCast/tripleCast lineage, not a rank), and every Class C 4xx-tier single-rank skill
  (`focusIntellect`/`parallelShift`/`snowBall`/`cosmicRift`/`cosmicFriday`) uses a `5` suffix, not `1`.
  Stripping-and-substituting for these would request a nonexistent icon key. Verified exhaustively (see
  below) rather than assumed — **also caught 6 pre-existing mislabeled `SKILL_ICONS` keys** left over
  from the original Task 13 icon extraction: those same 6 skills were stored under a wrong-suffix key
  (`penguin_focusIntellect1` etc.) that happened to have SOME base64 content behind it, not necessarily
  the right image — re-extracted fresh from the correct real file (`focusIntellect5.png` etc.) and
  renamed the key to match, fixing both the `SKILL_ICONS` entry and the `SKILLS.icon` reference together.
- Icon files exist 0-4 for many skills regardless of that skill's actual achievable max rank (a generic
  game-UI asset convention, not a gameplay signal) — **user flagged this directly**; only ranks `1..maxRank`
  per the verified cooldown-reference doc were extracted/wired up, not every file that happens to exist.
- **Verification**: no browser/Playwright available this session (same limitation as the earlier 2026-08-14
  Cast Time/layout work), so this was verified two other ways instead of visually: (1) the render logic
  (`getSkillRank`/`resolveRank`/`evalArith`/`renderDmgFormula`) was reimplemented line-for-line in Python
  and run against hand-derived expected outputs for several skills — see the pattern, this is the same
  approach used for the `castDep` math earlier; (2) an exhaustive script parsed every Penguin `SKILLS`
  entry and confirmed every icon key the rank-cycling logic could ever request (`1..maxRank` for every
  multi-rank skill) actually exists in `SKILL_ICONS`, and every `cd`/`castTime` per-rank array has exactly
  `maxRank` elements (a real off-by-one risk in hand-authored data, checked programmatically not by eye).
  **Still not a substitute for actually opening the tool** — do that before calling this done.

**Per-rank `cd`/`castTime`/`duration`.** Any of these three fields may now be either a flat number
(unchanged existing behavior) or an array indexed by `rank-1` — a new `resolveRank(value, rank)` helper
picks the right one before the value ever reaches `agiAdjust`/`magAdjust`/`chaAdjust`. This isn't
hypothetical: `manaMissile`'s CD really is `8+2×sLv` (`Penguin.cs:19541`), confirmed rank-varying, not an
edge case invented for this feature. 6 of Penguin's 27 skills have a rank-varying `cd`
(`manaMissile`/`dispell`/`manaBurn`/`frozenBlast`/`arcticWind`/`iceShield`), several more have a
rank-varying `castTime` alongside a flat `cd` — check each skill's own entry, there's no shortcut rule
for which fields vary. `duration` never varies by rank for any Penguin skill in this pass (matches the
established cross-class pattern already noted elsewhere in this doc), but `resolveRank` is applied there
too anyway for architectural consistency, not because any current data needs it.

**Damage formula row** (`selected.dmg`, new `.sk-dmg` panel, full-width below the 3-stat grid — not a 4th
grid column, a formula reads as prose not a short number). Three shapes, handled by `renderDmgFormula()`:
1. **`talAdjust(<expr>)`-wrapped** (the vast majority — 9 of 11 damage-dealing Penguin skills). `<expr>`
   has `sLv` substituted for the selected rank and is evaluated to a plain number `X` (`evalArith()` — a
   deliberately minimal `Function()`-over-sanitized-string evaluator, safe here because every input is a
   controlled literal authored into `SKILLS`, never external/user text), then expanded to
   `X + (0.02×X)TAL` per `CharacterControl.talAdjust`'s real formula (`nPower*(1+0.02*n)`,
   `CharacterControl.cs:20624` — verified against source, not assumed from the reference doc's shorthand).
2. **Flat/no-`talAdjust`** — only `manaVortex` (`sLv×12+12` per tick, explicitly "no TAL/focusIntellect
   scaling" per its own citation). Evaluated straight to one plain number, no color breakdown.
3. **Opaque** — only `novaFlare` (`0.5×Vortex HP + Vortex MP`, contingent on another skill's live summon
   state, not reducible to a stat formula at all). Shown as cited text, unprocessed.
   - Skills with genuinely non-formulaic or state-contingent damage (`manaBurn`'s `defAdjust(% of max MP
     drained)`, `snowBall`'s burst tied to the *target's* pre-existing `snowMan` level) have **no `dmg`
     field at all** — omitted rather than forced into a shape that would misrepresent them, same
     citation-honesty rule this whole repo already follows elsewhere. Same for anything that isn't really
     damage: `iceShield`/`snowMan`'s shield-HP payloads are absorption, not damage dealt, so no `dmg` row.
   - `dmgNote` (optional, plain italic text under the formula) flags per-instance qualifiers a bare number
     could mislead on — `"per missile"`, `"per tick (6 ticks, excludes locked target itself)"`, etc.

**Focus Intellect toggle** (`.sk-focusintellect-toggle`, same visual language as the existing
`.sk-ps-toggle`, off by default) — only rendered when `selected.dmgFocusIntellect:true` (11 of Penguin's
skills). **Deliberately does NOT store `× (1+0.01×focusIntellect)` as literal text in `dmg`** — every
`talAdjust`-based damage line that has it multiplies by exactly `1+0.01×mFocusIntellectValue`, and the
buff's stored value is `Mathf.FloorToInt(mag-100)` (`Penguin.cs:35867`), i.e. exactly `INT-100` (integer
stats, no fractional part for `FloorToInt` to change) — so the whole multiplier algebraically simplifies
to `1+0.01×(INT-100) = 0.01×INT`, confirmed against source (`Penguin.cs`'s 9+ `talAdjust(...) *
((float)1 + 0.01f * mFocusIntellectValue)` call sites) at the user's own prompt to check rather than trust
the reference doc's `focusIntellect`-as-opaque-variable shorthand. When the toggle is on, the multiplier
renders as `× 0.01INT` (not distributed across the base/TAL sum — kept as a trailing multiplicative
term); off, it's omitted from the formula entirely, per the user's explicit spec.

**Term coloring** (user-specified, exact colors): the plain base number has no color rule of its own —
it just inherits `--text` (already near-white in dark mode, this tool's primary theme; theme-correct
in light mode too, unlike a hardcoded literal white would be). New tokens `--stat-tal` (aqua) and
`--stat-int` (blue) color the TAL/INT terms; a `--stat-atk` (red) token exists for parity but isn't
exercised by any Penguin skill in this pass (none of Penguin's 27 active skills have a bare ATK term —
that pattern only showed up in the passive `nAttack` combo, which was never in `SKILLS` to begin with).
These 3 tokens are a **deliberate exception** to the Ledger design system's gold-only-accent rule, scoped
to `.sk-dmg` term coloring specifically — don't extend the pattern elsewhere without a reason. `--stat-atk`
is distinct from the existing `--seal` (oxblood, reserved for errors) on purpose — a bright/saturated red
here reads as "highlighted term," not "something's wrong"; don't consolidate the two.

### Follow-up pass, same day (2026-08-14): sizing, info icon, and a Class C damage toggle

- **`.sk-dmg-value` bumped to 30px/700 weight**, matching the 3 stat chips (was 17px) — user-requested,
  the damage row should read at the same visual weight as Cooldown/Cast Time/Duration, not smaller. The
  existing shrink-to-fit loop (`$$(".sk-stat-value", displayEl)`, shrinks a value down from its
  breakpoint size until it stops overflowing) now also covers `.sk-dmg-value` — same overflow risk at the
  bigger size, same fix.
- **`dmgNote` moved from an always-visible `<p>` under the formula into a click-to-reveal info icon**
  (`ℹ`, `.sk-dmg-info`) next to the "Damage" label. Implemented as a native `<details>`/`<summary>`, not a
  custom JS toggle with its own state variable — it auto-closes on every `renderHero()` re-render for
  free, since the whole `.sk-dmg` subtree is rebuilt from an `innerHTML` template each call anyway, so
  there's no stale-open-state risk to guard against the way a persisted boolean would need.
- **Focus Intellect's toggle button lost its panel-background "chip" look** (was styled like
  `.sk-ps-toggle`; user asked for it removed) — done by a bigger structural change, not just a CSS tweak:
  Focus Intellect is now modeled as a `dep` object (`PENGUIN_FOCUS_INTELLECT_DEP`, `id:"focusIntellect"`,
  a 0/1 toggle) instead of a standalone `focusIntellectOn` boolean with its own listener. A new
  `renderDmgToggle(dep)` helper renders a **bare** icon button (no `.sk-dep`/label-paragraph wrapper,
  unlike the existing `renderDepBlock`) reusing `.sk-dep-toggle`'s existing borderless/dim-when-off CSS
  and — this is the actual point — its existing generic click-listener (queries `.sk-dep-toggle` by
  class, flips whichever `data-dep-id` it finds), so switching to this representation removed the old
  dedicated `focusintellect-toggle` listener entirely rather than needing a new one.
- **New: Class C damage-modifying passives, via the same `dep` mechanism** (`skill.dmgDep`) — worked
  example is `manaMissile`'s `moreMissile5` (`Penguin.cs`'s `hasSkill(402)` check, `+0.1×charLv` per
  missile, per-class-data-reference). Rendered as an additive term (`+ 0.1LV`, uncolored — plain `--text`,
  no dedicated stat token, since "LV" isn't one of the 3-4 core adjustable stats the existing tokens
  represent) appended **after** the `talAdjust(...)×focusIntellect` group, matching real source order
  (`talAdjust(...) * (1+0.01*focusVal) + (hasSkill(402) ? 0.1*charLv : 0)`). **"LV" was shown
  symbolically-only at first** (this tool had no character-level input at the time) — **superseded by the
  same-day follow-up below**, which added a real `LV` input and a `dmgDep.calc(LV)` numeric function, so
  it's now actually computed too, not just displayed as text. **Only `manaMissile` has this today** —
  "start working on" was explicit, not "finish for every skill." Known candidates for the same treatment
  from the existing per-skill research, not yet done: `manaArc` (`penguinOfArc5`, `+0.5×charLv`),
  `fallingStars`/`fallingComets` (`giantStar5`, `×1.25` — a **multiplicative** modifier, not additive like
  `moreMissile5`, so the current append-only `dmgDepTerm`/`dmgDep.calc` machinery doesn't cover it as-is
  and would need a real extension, not just another data entry), `frozenBlast` (`frozenBreak5`, a separate
  bonus-damage burst rather than a modifier to the base hit), `arcticWind` (`deadlyFrost5`, same "separate
  burst" shape as frozenBreak5), `tornado`/`typhoon` (`iceTwister5`, frost-proc chance + speed, not a
  damage number at all — probably doesn't belong in `dmg` regardless of mechanism). Don't assume they all
  fit the additive-term shape `moreMissile5` used; check each one's actual formula shape before wiring it up.

### 2nd follow-up pass, same day (2026-08-14): a real calculated-damage chip, ATK/TAL/LV inputs

- **New inputs: ATK, TAL (default 128, matching AGI/INT/CHA/LCK's existing default), and LV (default
  100)** — user-specified defaults. `ATK` has no live consumer yet (no Penguin active-skill damage formula
  in this pass uses a bare ATK term — same "token exists for parity, unused today" situation as the
  `--stat-atk` CSS color) — added proactively per explicit instruction, not because something needs it
  right now.
- **New `.sk-dmg-calc` chip** (label "Damage", reuses `.sk-stat`/`.sk-stat-value-wrap`/`.sk-stat-base`
  classes directly rather than inventing new ones — it's genuinely the same kind of thing as
  Cooldown/Cast Time/Duration, a computed `[min,max]` range with the same hover-probability-tooltip, not
  a new visual language) — only rendered for skills whose `dmg` has a real `talAdjust(...)` term
  ("dependent on stat," per the user's own framing); `manaVortex` (flat, no `talAdjust`) and `novaFlare`
  (opaque vortex-state text) get no calc chip, matching `renderDmgFormula`'s existing 3-shape split.
  - New top-level `talAdjustAtRoll`/`talAdjustRange`, mirroring `chaAdjustRange`'s exact shape (same
    monotonic-increasing-in-stat direction, min roll → min output) but for `talAdjust`'s own formula and
    0.02 coefficient (`CharacterControl.cs:20624`).
  - **Truncation order matches source exactly, not a simplification**: `talAdjust()` itself returns an
    `int` (its own `(int)` cast, replicated inside `talAdjustAtRoll`); the focusIntellect multiplier and
    any `dmgDep.calc(LV)` bonus are then applied to that already-truncated value, and the **combined**
    result is truncated once more at the end — not re-truncated after each individual step. Verified by
    hand against `manaMissile` rank 2 (base 18, TAL/LCK/INT=128, LV=100): raw range `[64,73]` → focus-on
    `[81,93]` → `+moreMissile` `[91,103]`, cross-checked in a standalone Python reimplementation before
    trusting it.
  - `dmgDep` objects now carry both a display string (`term`, used by `renderDmgFormula`'s symbolic
    output) and a `calc(LV)` function (used by the calc chip's actual math) — `manaMissile`'s
    `moreMissile5` sets `calc:(LV)=>0.1*LV`. Any future `dmgDep` needs both, not just one — the two
    render paths don't share the same value automatically.
  - Tooltip positioning needed no changes — `positionStatTooltips()` already queries `.sk-stat` generically
    (`$$(".sk-stat", displayEl)`), so the calc chip's tooltip is picked up for free; it just isn't the
    `i===0` (left-gutter) element, so it uses the same right-gutter/below-fallback logic Cast Time and
    Duration already use.
- **`.sk-dmg-row` is now a fixed 2-column grid**, same "explicit `grid-column` pin, blank slot if the 2nd
  item is conditionally absent" pattern as the `.sk-hero-stats` 3-column fix earlier today — the formula
  chip (`grid-column:1`) is **always** half-width and left-slotted, even on skills with no calc chip, so
  width doesn't visibly jump around across the roster depending on which skills happen to be stat-dependent.
- **Info-icon fixes** (both user-reported from the previous pass): removed `.sk-stat-label`'s inherited
  bottom margin specifically inside `.sk-dmg-label-row` (it was throwing off the label/icon's vertical
  center-alignment against each other), and moved `.sk-dmg-info-pop` from opening *below* the icon
  (`top:calc(100%+6px)`, which dropped down and covered `.sk-dmg-value`) to opening to its *right*,
  vertically centered (`left:calc(100%+8px); top:50%; transform:translateY(-50%)`) — same row as the
  label text, not blocking the formula beneath it.
- **Renamed**: the symbolic-formula chip's label is now "Damage Formula" (was "Damage"), freeing up the
  plain "Damage" label for the new calculated chip.

### 3rd follow-up pass, same day (2026-08-14): gutter-positioned info popup, nowrap, drop the calc tooltip

- **`.sk-dmg-info-pop`'s "opens beside the icon" placement above is superseded** — user wanted it to
  behave like the Cooldown/Cast Time/Duration probability tooltips instead: render out in the side gutter
  via `position:fixed`, not float locally over the card. New `positionDmgInfoPopup()` is a **deliberately
  separate, much simpler function**, not a case folded into `positionStatTooltips()` — that function's
  multi-column row-rechunking exists for the probability breakdown's variable-length outcome list, which
  this plain-text note never has any of; threading a second, differently-shaped case through it would
  have made it harder to read for no real gain. Same gutter-vs-fallback strategy (checks real available
  width via `shellRect`, resets to the CSS-default local position when the gutter's too narrow) but with
  none of the column math. `.sk-dmg-info-pop`'s original "beside the icon" CSS position/transform values
  are kept as-is, now serving as that fallback rather than the primary behavior.
  - Only runs on the `<details>` element's own `toggle` event (plus the existing window resize handler) —
    **not** on every `renderHero()` call like `positionStatTooltips()` is. A closed `<details>` renders no
    box at all, so there's nothing to measure or position while it's shut; running this unconditionally on
    every render would just be wasted work most of the time, unlike the probability tooltips (always in
    the DOM, hidden via opacity/visibility, so their dimensions are measurable immediately).
  - Always uses the right gutter, never checks for a left-gutter case the way `positionStatTooltips()`
    does for Cooldown (`i===0`) — `.sk-dmg-formula` is never the first `.sk-stat`-like box in the display,
    so there was no reason to replicate that branch.
- **`.sk-dmg-value` gained `white-space:nowrap`** — this, not the shrink-loop itself, was the actual gap:
  the shrink loop (`$$(".sk-stat-value, .sk-dmg-value", displayEl)`, already extended to cover this class
  in an earlier pass) only ever shrinks a value that's *overflowing its box width* — without `nowrap`, a
  long formula's natural space characters (` + `, `) × `) just let the browser line-wrap it instead of
  overflowing, so `scrollWidth` never exceeded `clientWidth` and the shrink logic silently never fired.
  `.sk-stat-value` already had `nowrap` for exactly this reason; `.sk-dmg-value` was missing it.
- **Calc chip's hover-probability tooltip removed** (user: don't show "the possibilities of all possible
  damage") — dropped `renderProbabilityTooltip(dmgCalcDist)` and the now-unneeded `.sk-stat-value-wrap`
  hover-target wrapper entirely; the chip is just a label + `.sk-stat-value` range + `.sk-stat-base` line
  now, same shape as Cooldown/Cast Time/Duration minus their tooltip. `lckDistribution` is still used
  elsewhere (Cooldown/Cast Time/Duration all keep theirs) — this removal is scoped to the damage calc
  chip specifically, not a signal to remove the pattern generally.

### 4th follow-up pass, same day (2026-08-14): garbled info popup, left gutter, 50/25/25 layout

- **User screenshotted the info popup rendering as garbled, overlapping text.** Root cause not directly
  observable (no browser this session), but the strongest explanation: `<summary title="${selected
  .dmgNote}">` set a **native** browser title-tooltip with the exact same text the custom
  `.sk-dmg-info-pop` shows on click — hovering the icon (which precedes clicking it) then clicking it
  could render both at once, nearly co-located, producing exactly a double-exposure/overlapping-text
  look. Fixed by giving `<summary>` a short, non-duplicate `title="More info"` instead, so there's nothing
  left for a native tooltip to collide with even if the browser still shows one on hover. Also hardened
  `.sk-dmg-info-pop` itself regardless of whether that was the actual cause (cheap, safe either way, no
  way to isolate which one fixed it without visual testing): explicit `white-space:normal` (guards against
  any inherited nowrap), `line-height:1.4` (was unset), `max-width` 240px→280px.
- **Info popup moved from the right gutter to the left** (user-corrected) — `.sk-dmg-formula` lives in
  `.sk-dmg-row`'s own left column, so its info icon now opens toward the same side it's already
  positioned on, rather than reaching across the card. `positionDmgInfoPopup()`'s gutter check now uses
  `shellRect.left` (space to the left of `.tool-shell`) instead of `window.innerWidth - shellRect.right`,
  and the popup's own width is measured (`pop.getBoundingClientRect().width`) to correctly right-align it
  flush against the shell's left edge (`shellRect.left - popWidth - margin`), mirroring exactly how
  `positionStatTooltips()`'s own `useLeft` branch computes Cooldown's tooltip position.
- **`.sk-dmg-row` is now 3 columns, `2fr 1fr 1fr` (50/25/25), not 2 columns at 50/50.** Formula chip stays
  at 50% (`grid-column:1`, unchanged target width from the previous pass — `2fr` of `4fr` total is still
  exactly half), the calc chip drops to 25% (`grid-column:2`), and a **new, deliberately empty**
  `.sk-dmg-lck{grid-column:3}` reserves the remaining 25% for LCK-proc info (the user's example:
  arcticWind's `lckAdjust`-gated 20% chance to apply `frost` instead of `ice` when `arcticFrost1` is
  learned) — **not built this pass**, per the user's own "if unsure, just leave it for now." No `SKILLS`
  field, no render branch, no guessed-at data exists for this yet — only the grid track itself, so a
  future pass has a slot to fill without another layout change. Don't populate this from memory of what
  "LCK-based info" might mean without doing the same per-skill source verification every other number in
  this tool has — check the research already done in `12t_reference/penguin-skill-damage-reference.md`
  for each skill's actual `lckAdjust`-gated mechanic first (e.g. arcticWind's is documented at
  `Penguin.cs`'s `arcticFrost1` note in that doc), the same way `dmgDep`'s Class C bonuses were sourced.

### 5th follow-up pass, same day (2026-08-14): the 50/25/25 split wasn't actually holding

- **User screenshotted the formula chip visibly wider than 50%, and the long `manaMissile` formula still
  not shrinking** despite the earlier `white-space:nowrap` fix. Root cause: `.sk-dmg`/`.sk-dmg-formula`
  was missing `min-width:0` — **the exact same grid-item gotcha already fixed once this session on
  `.sk-stat`**, re-introduced by not carrying it over to this newer grid. A grid item's default
  `min-width:auto` uses its *content's unshrunk natural size* as a floor on the track, which let column
  1's `2fr` track grow past its intended 50% share to fit the long nowrap formula text — and because the
  box had already grown to fit the text, `.sk-dmg-value`'s `clientWidth` matched `scrollWidth`, so the
  shrink-loop's overflow check (`scrollWidth > clientWidth`) never had anything to react to. `nowrap` was
  necessary but not sufficient on its own; `min-width:0` is what actually lets the track (and therefore
  the box, and therefore the shrink check) respect the `2fr` share instead of the content dictating it.
  Fixed by adding `min-width:0` to the shared `.sk-dmg` class. `.sk-dmg-calc` didn't need the same fix —
  it already inherits `min-width:0` from `.sk-stat`, which it uses as its base class.
- **General lesson for this file, not just this one bug**: any time a new grid (fixed-column or `fr`-based)
  is added with a nowrap/long-content child, `min-width:0` on the grid item needs to be checked explicitly
  — it does not carry over from a sibling class that happens to already have it, and its absence fails
  *silently* (no console error, just a track that quietly ignores its `fr` share).

### 6th follow-up pass, same day (2026-08-14): fixed chip height across every skill, permanently

- **`min-height:140px` added to `.sk-stat` and `.sk-dmg`, unconditionally** — user-reported via Chameleon's
  `slayer`/`allSlayer` (not Penguin — this bug is class-agnostic, those two just happen to be the first
  skills in the whole tool using a **5-button rank stepper** dep on a Cast Time box, where every other
  corner dep anywhere else is a simple single-icon toggle). Root cause: a corner `.sk-dep` block is
  `position:absolute` so it doesn't grow the box in normal CSS flow, but if the box's own natural content
  (label+value+base, ~92px including padding) is shorter than what the corner content needs to clear
  without touching it, the two visually collide instead — the stepper (~44px: icon+label row + button row)
  needed more clearance than the single-icon toggle (~34px, one row) the box's un-fixed natural height had
  only ever been implicitly sized around. 140px clears the tallest known corner content with real margin.
  **This is now a hard, explicit rule, not a per-skill outcome**: every `.sk-stat`/`.sk-dmg` box is 140px
  minimum regardless of what it contains — a dep-less Cooldown box and a stepper-bearing Cast Time box are
  the same height now, and so are `.sk-dmg-formula`/`.sk-dmg-calc` against each other and against the
  `.sk-hero-stats` row's own three boxes. **Do not make chip height content-dependent again for any
  future class/skill** — if a future corner element doesn't fit within 140px, shrink that element further
  (the established lever — dep icon/button sizes were already reduced once for exactly this reason) rather
  than reverting to a content-driven box height.
- Width was already consistent going into this pass (the `min-width:0` grid-item fixes from earlier
  today), so this pass is specifically about height — but the underlying principle (fixed chip dimensions,
  never content-dependent) now applies to both axes uniformly across every chip in this tool, not a
  height-only carve-out.

### 7th follow-up pass, same day (2026-08-14): multi-rank deps switched from numbered buttons to icon-cycle

- **The numbered-button stepper (`renderDepBlock`'s `maxRank-minRank>1` branch) is gone entirely** — every
  multi-rank dep (Chameleon's `improvedSlayer`, Rabbit's `alchemistLab`/`medicalEnhancement`, Wolf's
  `perseverance` — **class-agnostic, all 4 existing ones converted at once, not just today's Penguin/
  Chameleon work**) now renders as a single click-to-cycle icon, the exact same mechanism as the main hero
  icon's own rank cycling: click advances the rank (wrapping `maxRank` back to `minRank`, not always 0 —
  see `alchemistLab` below), and the icon itself swaps to that rank's real distinct art
  (`dep.icon`'s trailing digit stripped and replaced, same regex as the hero icon uses).
  - **Rank 0 has no distinct art of its own** — it reuses rank 1's icon file with the grayscale-dim filter
    `.sk-dep-toggle` already used for its "off" state (now a **shared CSS rule**,
    `.sk-dep-toggle, .sk-dep-rank-icon{...}`, not a duplicate — the two are visually identical, just
    differ in how many "on" states they cycle through). This only ever triggers for deps whose `minRank`
    is actually `0` (`improvedSlayer`, `medicalEnhancement`, `perseverance`) — `alchemistLab`'s `minRank:1`
    means its cycle never reaches 0, so it's always shown in full color, never grayed. This is a direct,
    intended consequence of the existing `minRank` semantics (a skill that hard-requires the passive to
    function at all vs. one that's merely enhanced by it), not a special case added for this pass.
  - **9 new per-rank icons extracted** (the max-rank one was already embedded per-dep from when each was
    first built; only the lower ranks were missing since the old stepper only ever showed ONE fixed icon
    beside the button row): `chameleon_improvedSlayer{1,2,3}`, `rabbit_alchemistLab{1,2,3}`,
    `rabbit_medicalEnhancement{1,2}`, `wolf_perseverance1`. Verified every rank 1..maxRank now has a real
    embedded `SKILL_ICONS` entry for all 4 deps before considering this done (all 13 keys checked directly
    against the file, not assumed from the extraction script's own success).
  - Dead CSS removed alongside this (`.sk-dep-head`, `.sk-dep-icon`, `.sk-dep-ranks`,
    `.sk-dep-rank-btn*`) — none of it is reachable from any remaining code path. The old numbered-button
    click listener was replaced with a cycle-handler for the new `.sk-dep-rank-icon` class
    (`data-dep-min-rank`/`data-dep-max-rank` attributes drive the wrap-around, generic across all 4 deps —
    no per-dep special-casing in the listener itself).

### 8th follow-up pass, same day (2026-08-14): dep labels dropped, corner moved to top-right

- **`renderDepBlock`'s `<p class="sk-dep-label">` line removed from both branches** (toggle and
  icon-cycle) — user-requested, icon + `title` hover text is enough, the visible label wasn't needed.
  `.sk-dep-label`'s CSS rule was dead after this (verified zero remaining references) and removed too.
- **`.sk-dep` and `.sk-ps-toggle` both moved from the box's bottom-right corner to top-right** — same
  reasoning applies to both even though only `.sk-dep` was explicitly named: they share one corner slot
  (still true no skill has both `ps` and a dep on the same box) and use identical positioning logic, so
  moving only one would've left the corner inconsistent depending on which type a given skill has. Top-
  right sits level with the small COOLDOWN/CAST TIME/DURATION label instead of the "base Xs" line — safe
  now that there's no label text to worry about running into the big number below (the original reason
  bottom-right was chosen over top-right in the first place); an icon alone is narrow enough regardless.
  `.sk-dep`'s CSS simplified too — `flex-direction:column`/`gap` existed only to stack a label above the
  button, and no longer applies now that it holds a single element.

### 9th follow-up pass, same day (2026-08-14): chip height 140px→108px, shrink-not-wrap for every chip text

- **`min-height` dropped from 140px to 108px on both `.sk-stat` and `.sk-dmg`** — 140px was sized to clear
  a *bottom*-anchored 5-button stepper; once `.sk-dep`/`.sk-ps-toggle` moved to `top:12px` (this same day,
  previous pass), the corner icon sits in the same band as the label text and no longer needs clearance
  below the base-value line, so the extra height became pure dead space (visible in the user's own
  screenshot — a lot of empty box below "base 60s" etc.). 108px = the box's calculated natural content
  height (label + 30px value + base + padding ≈ 92px) plus a small buffer for font-metric variance, not
  a re-guess. **User flagged this specifically ahead of the damage-chip treatment reaching the other 11
  classes** — tight height now matters more once every skill has 2 rows of chips instead of 1, not just
  Penguin's pilot. Keep this value tight; don't let it drift back up without re-measuring why, same rule
  as the 140px value it replaced.
- **Shrink-not-wrap now covers every text element in a chip, not just the big number.** `.sk-stat-label`
  and `.sk-stat-base` both gained `white-space:nowrap` (previously missing — meant they'd line-wrap
  instead of overflow, silently defeating any shrink logic the same way `.sk-dmg-value` did before its own
  `nowrap` fix earlier today) and a **second** shrink loop, separate from the existing
  `.sk-stat-value`/`.sk-dmg-value` one — not merged into it, because that loop's floor is `size > 16` and
  label/base start at 11px/13px already, so sharing that floor would mean the loop's own while-condition
  is false immediately and nothing would ever shrink. The new loop's floor is `9px` instead.

### 10th follow-up pass, same day (2026-08-14): long hero names, and top/bottom padding symmetry

- **`.sk-hero-name` gained the same shrink-not-wrap treatment** — user-reported via Chameleon's
  `allSlayer` (`"All Bug Slayer / All Tail Slayer / All Elemental Slayer / All Machine Slayer"`, the merged
  4-variant display name, 73 characters), which wrapped to 2 lines at the default 21px and grew
  `.sk-hero-head` — and therefore the whole card — taller than every other skill's, the same class of bug
  already fixed repeatedly for the stat chips, just in the header this time. `white-space:nowrap` +
  `text-overflow:ellipsis` as the CSS-only fallback, a dedicated shrink loop (floor 14px — a title reads as
  a title down to about this size; below it, ellipsis takes over) as the actual fix. **Also needed
  `min-width:0` on `.sk-hero-title`** — the flexbox equivalent of the grid-item `min-width:auto` gotcha
  already hit multiple times this session for `.sk-stat`/`.sk-dmg`: without it, `.sk-hero-name`'s `nowrap`
  makes its own min-content width the full un-ellipsized text width, and the flex item refuses to shrink
  below that, so neither the ellipsis nor the shrink loop would have had any room to actually work.
- **`.sk-stat`/`.sk-dmg` both switched to `display:flex; flex-direction:column; justify-content:center`.**
  User-reported via a screenshot showing visibly uneven top/bottom whitespace around a chip's content (Cast
  Time specifically, but the cause is universal) — the padding *values* were already equal (`12px 14px`,
  top and bottom both 12px), the actual problem is that when a box is stretched taller than its own content
  (by `min-height:108px`, or by a taller sibling in the same grid row via the default
  `align-items:stretch`), plain block flow starts content at `padding-top` and dumps 100% of the leftover
  space below it — nothing redistributes any of it back to the top. Centering the content as a flex column
  splits that leftover evenly instead. Doesn't disturb `.sk-dep`/`.sk-ps-toggle`'s own `position:absolute`
  corner placement — an absolutely positioned element is removed from flex layout entirely, so it keeps
  using its own `top`/`right` values against the box regardless of how the flex container aligns its
  normal-flow children. Applies to every chip that uses `.sk-stat`/`.sk-dmg` as a base class, not a
  Cast-Time-only fix.
- **Process note**: two separate rounds of `structural_check.py` false alarms this pass, both from
  unmatched parentheses inside prose *comments* (never the actual code — the script-block-scoped paren
  count stayed balanced both times) written while explaining these two fixes. Caught and fixed by checking
  script-block-scoped vs. whole-file paren counts separately, not by assuming a mismatch always means a
  real bug — but also not by ignoring it outright. Comments still need to be internally balanced for this
  checker to stay a useful signal for genuine future regressions; sloppy comment punctuation erodes that.

### 11th follow-up pass, same day (2026-08-14): the centering fix moved icons it shouldn't have

- **The previous pass's `.sk-dmg{justify-content:center}` had a real bug**, caught by the user comparing
  two screenshots of the same skill (`manaMissile`) with Focus Intellect toggled on vs. off: the header row
  (label, info icon, toggle icons) visibly shifted vertical position between the two states. Root cause:
  `.sk-dmg-formula`'s toggle icons are **normal-flow** content inside `.sk-dmg-head` (built via
  `renderDmgToggle`, a plain inline button — not `position:absolute` the way `.sk-stat`'s corner
  `.sk-dep`/`.sk-ps-toggle` are). Centering the whole `.sk-dmg` column as one group therefore centered the
  header along with the formula text, and since the formula's rendered height genuinely differs by toggle
  state (the parenthesized `×0.01INT` group adds height/wrapping risk the bare `+0.1LV` form doesn't), the
  whole group's centered position shifted, dragging the header with it. This is a **different** case from
  `.sk-stat`'s corner icons, which stayed correctly fixed throughout because `position:absolute` already
  excludes them from flex centering — don't conflate the two or assume the same fix generalizes.
- **Fix: don't center the header, only center the formula text.** `.sk-dmg-head` is now `flex:none`
  (fixed at its natural size, pinned at the top of the column, never moves). `.sk-dmg-value` is now
  `flex:1` (grows to fill whatever space is left below the fixed header) and is itself
  `display:flex; align-items:center` (centers its own nowrap text within that space). Net effect: the
  header is permanently anchored, and only the formula text's vertical position within the remaining space
  adjusts — which is invisible, since nothing else is anchored relative to it for comparison.
  `.sk-dmg-calc` (the Raw Damage chip, uses `.sk-stat` not `.sk-dmg`) never had this bug — it has no
  header row with icons, just a label and a value, so `.sk-stat`'s original whole-column centering from
  the previous pass is unaffected and still correct there.
- **`.sk-dmg-calc`'s label renamed "Damage" → "Raw Damage"** (user-requested) — distinguishes it more
  clearly from "Damage Formula" now that both chips sit side by side.

### 12th follow-up pass, same day (2026-08-14): the header-pin fix broke text spacing

- **`.sk-dmg-value`'s `display:flex; align-items:center` (added THIS SAME PASS, a few minutes earlier)
  had its own real bug** — user-reported: `"66 + 1.32TAL"` rendered as `"66+1.32TAL"`, the spaces around
  `+`/`×` silently gone. Root cause: `.sk-dmg-value`'s content mixes `<span class="dmg-*">` term elements
  with plain text nodes (the `" + "`/`") × "` separators) — making the container `display:flex` wraps each
  of those separator text runs in an **anonymous flex item**, and browsers collapse/trim whitespace at an
  anonymous flex item's edges more aggressively than they do in normal inline flow, which silently ate the
  separating spaces. This is a known, documented flex+whitespace interaction, not a one-off rendering
  glitch — don't reach for `display:flex` on an element whose content is inline text mixed with element
  children without checking for exactly this first.
  - **Fix: dropped `display:flex`/`align-items:center` from `.sk-dmg-value` entirely**, keeping only
    `flex:1` (still needed — that's what lets it fill the space below the pinned `.sk-dmg-head` from the
    previous pass, unrelated to this bug). Plain block flow doesn't have the anonymous-flex-item whitespace
    problem. **Accepted trade-off, per the user's own explicit call**: the formula text now sits at the
    top of its `flex:1` area instead of perfectly vertically centered within it — the shrink-loop
    (font-size-reduce-on-overflow, already established as this tool's answer to "content might not fit"
    all session) is the real mechanism doing the work here, not vertical centering. Don't re-introduce
    `display:flex` on this specific element to chase perfect centering; the two are in direct tension for
    exactly the content shape `.sk-dmg-value` has.

### 13th follow-up pass, same day (2026-08-14): chip grid reshuffle + the Final Damage chip

**Layout reshuffled to 25/25/25/25 (row 1) + 50/25/25 (row 2), user-specified.** `.sk-hero-stats` is now
`repeat(4, 1fr)` (was 3) — Cooldown / Cast Time / Duration / a **new `.sk-stat-lck` 4th slot**, reserved
and still unbuilt (moved here from the damage row, since LCK-proc info like arcticWind's frost-vs-ice
chance is a general skill-mechanics fact, not a damage-pipeline one — don't conflate the two "reserved
slot" comments if you find one stale). `.sk-dmg-row` stays `2fr 1fr 1fr`, but its 3rd slot (previously
reserved/empty) is now **populated**: Damage Formula / Raw Damage / **Final Damage**.

**Final Damage is deliberately NOT a range like every other chip in this tool.** User's own framing: click
one of 3 enemy presets, and the chip simulates one concrete random hit through the full pipeline — not the
`[min,max]` spread every other stat shows. Mechanically:
- `ENEMY_PRESETS` (3 illustrative tiers — Weak/Medium/Strong, DEF 50/150/350) — **NOT cited to any specific
  real enemy**, unlike virtually everything else in this tool. Pick real ones later if that matters; these
  are placeholder round numbers chosen to give a clearly-differentiated result across the 3 buttons.
- On click, `randomRoll(rMax)` samples a genuinely random `R` in `[0, rMax]` (`Math.random()`-based) — not
  the range chips' own deterministic min/max endpoints — feeds it through the existing
  `talAdjustAtRoll`/`dmgCalcPostFn` (the exact same functions Raw Damage already uses, just called once
  with a random `R` instead of mapped over `[rMin, rMax]`), then applies **`Damage.getDamage`'s confirmed
  formula** (`(int)(dmg * (1 - def/(def+64)))`, floored at 1 — verified directly against `Damage.cs:262`,
  not assumed) against the selected preset's DEF. Re-clicking the *same* already-selected preset still
  re-rolls — there's no early-out on "same id clicked again," matching "simulate a fresh hit," not a static
  selection that only changes when you pick a different target.
- **Rendered with the real in-game damage-popup digit textures**, not this tool's own UI font — the user's
  own "gimmick" framing. `Damage.getDamageTexture(color, digit)` (`Damage.cs:23`) loads
  `GameAssets/Effects/DamageNum/<color><digit>.png`; found and extracted the full `w0-9`/`p0-9` sets
  (`RippedAssets/.../gameassets/effects/damagenum/`) as `dmgdigit_w<N>`/`dmgdigit_p<N>`. **White is used for
  all of Penguin's damage-dealing skills today** — user-confirmed convention: white = normal/direct-hit
  damage (~99% of skills), purple = defense-mitigated *effect* damage (the `RPC_AddEffectDamage`/DoT
  pathway specifically, a different pipeline from the direct-`hit()` one every current Penguin damage
  skill in `SKILLS` uses). `p0-9` are extracted and ready, but **nothing calls them yet** — no Penguin skill
  in this chip's scope routes through the effect-damage path. Don't default to purple for a future
  DoT-style skill without re-confirming it's actually on that pathway first.
- **CORRECTED same day, superseding the paragraph this replaces**: the "no LCK usage found" conclusion
  above was wrong — it came from searching `Damage.cs` and `CharacterControl.cs`'s `hit()`/`RPC_AddDamage`
  for a call to `Damage.getDamage` specifically, and concluding LCK was unused when that search came up
  empty. The actual mitigation function is a **different one**: `defAdjust(int nDamage)`
  (`CharacterControl.cs:20524`), called directly on the target (`characterControl.defAdjust(nDamage)`,
  `CharacterControl.cs:3546`, right before `RPC_AddDamage`) — confirmed real, confirmed called, and it
  **does** use the target's own LCK: `n = clamp(def + Random(0, ceil(0.2×lck)), 1, 512)`, then
  `result = max(1, nDamage - 0.5×n)`. This is **subtractive**, not `Damage.getDamage`'s multiplicative
  `(1-def/(def+64))` — a genuinely different formula shape, not a refinement of the same one. User caught
  this directly ("the enemy DEF used in calculation use 0%-20% LCK") after the first pass shipped with the
  wrong formula; `Damage.getDamage` was a real function that exists in this codebase, just not the one
  actually in this pipeline — a case worth remembering: confirming a formula *exists* isn't the same as
  confirming it's the one *called* at the relevant site.
  - `defAdjustRoll(nDamage, def, lck)` (new top-level function, beside `talAdjustRange`) implements this.
  - **`ENEMY_PRESETS`' DEF values were recalibrated** (50/150/350 → 20/60/120) once the real formula was in
    place — the old values were tuned (accidentally) against the multiplicative formula's behavior, and
    under the real subtractive one they floor Medium/Strong to 1 damage against most Penguin raw-damage
    magnitudes. Checked against this session's actual raw-damage range (~24 to ~350) before settling on the
    new values — don't re-widen these without re-checking against real skill values, the subtractive
    formula is much more sensitive to the DEF-to-raw-damage ratio than the multiplicative one would have
    been.
  - The dodge/evade path (`Damage.displayMiss`/`displayEvade`) mentioned in the superseded paragraph above
    is unrelated to this — still real, still unverified, still not wired in. That part of the original
    caveat stands; only the "LCK is unused" conclusion was wrong.

### 14th follow-up pass, same day (2026-08-14): real enemies, real damage-number animation

- **`ENEMY_PRESETS` replaced the illustrative Weak/Medium/Strong tiers with 3 real named enemies and their
  actual in-game target-avatar portraits** — Carron (DEF 2, LCK 2), Stingdune (DEF 200, LCK 10), Silverbug
  (DEF 300, LCK 45), all user-specified stats. Icons are `gamegui/icons/targetavatar/{plants,bugs}/` —
  found by searching for each name directly (all 3 had a prefab, a script, AND a target-avatar portrait;
  the portrait is the one actually meant for "this is what you're aiming at" UI, matching this chip's own
  purpose better than a monster's overworld sprite would). 137×128 native size, `object-fit:cover` crops
  to the 26px button; dim-when-unselected/full-color-when-selected is the same on/off language every other
  toggle icon in this tool already uses (`.sk-dep-toggle`, `.sk-hero-icon-btn`, etc.) — not a new pattern.
  - **Real enemies produce a real, uneven spread — don't "fix" it.** At low raw damage (Carron-tier hits),
    Stingdune/Silverbug floor to 1 — checked directly, this is authentic (a starter enemy's weak hit
    genuinely does nothing to a much tougher target under the real `defAdjust` formula), not a calibration
    problem the way the earlier illustrative tiers' floor-out was. Don't retune these values for a
    "smoother" curve the way `ENEMY_PRESETS`' def values were adjusted in the previous pass — these are
    the user's own specified numbers for real named enemies, not illustrative placeholders.
- **Floating-damage-number animation added** (`@keyframes dmgFinalFloat`, applied to `.sk-dmg-final-digits`)
  — fades linearly (constant rate, not eased, per the user's explicit spec) over 2s while rising exactly
  its own height (`transform:translateY(-100%)`, relative to the element's own box — not a fixed pixel
  guess, which wouldn't stay correct if the digit row's rendered height ever changes). `forwards` fill-mode
  holds the fully-faded end state rather than snapping back to visible. Needed no JS/state changes to
  "restart" on every new roll — a fresh `.sk-dmg-final-digits` element is created every `renderHero()` call
  (same `innerHTML`-rebuilt-from-scratch mechanism as literally everything else in this tool), so a plain
  CSS `animation` on it just naturally replays each time, the same way `.view`'s own entrance animation
  already does. Respects `prefers-reduced-motion: reduce` (`animation:none`), matching that same existing
  `.view` precedent rather than introducing a new accessibility gap.

### 15th follow-up pass, same day (2026-08-14): `defAdjust` was wrong a 2nd time — it's a blend, not either formula alone

**Third and (checked exhaustively this time) final correction to this one formula.** The previous pass's
"fix" read `defAdjust`'s body but stopped partway through its obfuscated control flow, at the first
`num2 = nDamage - 0.5*num` assignment, and concluded the whole function was purely subtractive. The
**actual full body** (`CharacterControl.cs:20524-20571`) computes BOTH candidate values off the *same* LCK-
rolled `n`, each independently floored at 1, then returns a **weighted blend**:
```
n = clamp(def + Random(0, ceil(0.2×lck)), 1, 512)
subtractive    = max(1, nDamage - 0.5×n)
multiplicative = max(1, nDamage × (1 - n/(n+64)))   -- literally Damage.getDamage's own formula
result = ceil(0.35×subtractive + 0.65×multiplicative)
```
So the **first-ever pass** (pure `Damage.getDamage`, purely multiplicative) and the **previous pass**
(pure `defAdjust`-subtractive) were each only capturing one of the two blended components — neither was
"more correct" than the other, both were incomplete. User caught this specifically by recalling that low-
relative-damage hits get special handling to avoid going negative — which is real, but it's not a
conditional branch that swaps formulas; it's the **per-component `max(1, ...)` floor applied before the
blend**, not after. Re-verified against Python cross-check across the same raw-damage range used for the
previous pass's calibration check — under the correct blended formula, low-damage-vs-high-DEF hits no
longer floor identically to 1 the way the pure-subtractive version did (e.g. Silverbug vs. raw damage 24:
pure-subtractive gave 1, the real blend gives ~3) — a materially different, more nuanced result, not just
a coefficient tweak.

**Process lesson, worth remembering for any future obfuscated-function read in this codebase**: when a
decompiled function has `for(;;)` + `continue`/`goto` control-flow flattening (this whole codebase's
obfuscation signature, documented in this repo's root `CLAUDE.md`), **read to the function's actual closing
brace and its final `return` statement before concluding what it computes** — stopping at the first
plausible-looking assignment, even one that matches an already-known formula shape, is exactly how this
formula got mis-identified twice in a row. Don't repeat this pattern on the next `*Adjust`-family function
this tool touches.

### 16th follow-up pass, same day (2026-08-14): the float animation wasn't playing at all

User reported the Final Damage number rendering fully static (opaque, no motion) — not "already faded"
(which `forwards` holding the end state would look like: invisible), genuinely frozen at the start frame.
Root cause: the `@media (prefers-reduced-motion: reduce){.sk-dmg-final-digits{animation:none}}` opt-out
added alongside the animation was silently triggered by the user's own OS/browser reduce-motion setting —
confirmed by elimination (no duplicate/conflicting rule existed; this was the only thing in the CSS that
could produce "animation never runs at all" rather than "ran once and is sitting at its end state").
**Removed the opt-out entirely, user-confirmed** — this is a core, explicitly-requested effect for this one
chip, not a decorative flourish like `.view`'s entrance animation (which still respects the preference,
unchanged). Don't re-add a reduce-motion guard here; it was tried and deliberately reverted, not an
oversight to "fix" later.

### 17th follow-up pass, same day (2026-08-14): Final Damage redesigned — range as primary display, simulate as an opt-in extra

**User-requested "change of design"**, superseding the previous pass's single-simulated-roll-only Final
Damage chip (which required clicking a color-coded W/M/S button just to see *any* number). The two
behaviors are now split apart instead of one replacing the other:

- **Always-on `[min,max]` range** — the chip's main value the instant a target is picked, styled identically
  to Raw Damage (`.sk-stat-value`, same size/weight — user's explicit ask: "using the same font as raw
  damage"). Computed by combining **both independent RNG sources at their correct extremes**, not by
  mitigating a single midpoint: `dmgCalcRange`'s own min (the caster's worst TAL/LCK roll, already baked in
  from the existing Raw Damage calc) run through `defAdjustAtN` at the target's *worst-case mitigation* n
  (`def + ceil(0.2×lck)`, the LCK-rolled maximum), and `dmgCalcRange`'s max run through `defAdjustAtN` at
  the target's *best-case mitigation* n (`def + 0`). Worst-with-worst and best-with-best, matching how
  `defAdjustRange` already combined extremes for the (now-removed) single-value chip in an earlier pass —
  same principle, just applied across two chained ranges instead of one.
- **Simulate button — an addition, not a replacement.** A small inline-SVG sword icon + "Simulate" text,
  colored via the existing `--stat-atk` red token (reusing the established red-text was ATK's color pattern,
  not a new palette). **Deliberately NOT a ripped game asset** — first attempt searched `RippedAssets` for
  an in-game sword icon; user corrected mid-turn ("don't use ingame sword icon, use what you have, a
  minimalistic ones") specifically because this is a UI *control*, unlike the skill/enemy icons and damage-
  digit textures elsewhere in this tool which are deliberately real extracted assets. Clicking it rolls
  *one concrete hit* (`talAdjustAtRoll` → `dmgCalcPostFn` → `defAdjustRoll`, true single random roll on both
  sides, not range endpoints) and pops up the existing in-game-font digit rendering
  (`renderDamageDigits`/`dmgFinalFloat`) as a floating overlay — reusing 100% of the digit-texture and
  float-animation machinery built in the 13th/14th passes, just re-triggered on demand instead of being the
  chip's only content.
- **Popup is now `position:absolute` overlay, not normal-flow.** Renamed `.sk-dmg-final-digits` →
  `.sk-dmg-final-popup` to match — it no longer occupies layout space (would otherwise push the range value
  and button around every time it appeared/disappeared, undermining the "standardize chip height" rule from
  an earlier pass). `.sk-dmg-final` gained `position:relative` as the popup's containing block.
- **State (`simulateClickedAt`/`simulatedValue`) resets on skill switch AND enemy switch** — a stale roll
  from a different skill or a different target must never persist into the next selection; both
  `selectSkill()` and the enemy-preset click handler clear both fields before re-rendering.
- **Cached-roll + negative-`animation-delay` resume mechanism carried over unchanged from the prior design**
  — since `innerHTML` is rebuilt wholesale every `renderHero()` call, the roll is computed once on the
  triggering click and cached in `simulatedValue`, and every subsequent re-render within the 2s window
  recomputes elapsed time and feeds it back in as a *negative* `animation-delay` so the freshly-recreated
  popup element resumes mid-animation instead of restarting from frame 0. Expires (`simulatedValue = null`)
  once `elapsed >= 2000`.
- **Math cross-checked in Python** (`verify_final_dmg_range.py`) across all three real `ENEMY_PRESETS`
  against an illustrative raw-damage range — confirmed `min <= max` holds and both values stay positive for
  Carron/Stingdune/Silverbug, and that the inline worst/best-`n` computation in `index.html` matches a
  standalone `defAdjustRange`-based re-derivation exactly (not just "looks plausible").
- Cleanup: removed a duplicate stale `.sk-dmg-final{grid-column:3}` CSS rule and a stale code comment
  referencing the earlier "3 tiny letter buttons (W/M/S)" design that no longer exists.

### 18th follow-up pass, 2026-08-16: simulate popups had to become independent, not a shared slot

User reported two problems with the 17th pass's simulate popup, both about the same root cause — a single
shared `simulateClickedAt`/`simulatedValue` slot instead of a real per-click record:

1. **"In game damage number shouldn't prevent me from clicking or interacting with the tool, now it does."**
   The popup itself already had `pointer-events:none` (verified still present, `index.html` CSS around the
   `.sk-dmg-final-popup` rule) so it was never the literal cause of blocked clicks — the CSS is correct and
   was left as-is. The likelier actual cause: every Simulate click force-reset the ONE shared slot
   (`simulateClickedAt = Date.now(); simulatedValue = null;`), so any click while a popup was already
   mid-flight nuked and restarted it, which reads as erratic/unresponsive even though nothing was truly
   click-blocked. Switched the pointer-events question from "prove a negative" to "make it structurally
   moot" by never having shared state to clobber in the first place (see #2).
2. **"Spawning new damage number don't have to stop the animation of the previous one."** The real, concrete
   bug — confirmed by re-reading `simulateBtn`'s click handler, which unconditionally overwrote the single
   `simulateClickedAt`/`simulatedValue` pair on every click, so a second click before the first popup's 2s
   animation finished silently killed/restarted it instead of the two coexisting.

**Fix: `simulateClickedAt`/`simulatedValue` (two scalars) → `simulatePopups` (an array of
`{id, clickedAt, value}`), plus `nextSimulatePopupId`.** Clicking Simulate now *pushes* a new entry
(`value: null`, rolled lazily) rather than overwriting shared state — an existing in-flight popup is
never touched by a later click. Render logic: `simulatePopups.filter(p => now - p.clickedAt < 2000)` prunes
expired entries first (permanently removing them, no null-slot bookkeeping needed), then `.map()`s the
survivors, rolling `p.value` once per entry on its first render (same "roll lazily, cache on the object"
reasoning as the 17th pass, now per-entry instead of per-shared-slot) and computing each entry's own
negative `animation-delay` independently, so several popups clicked at different instants each resume their
own CSS animation from their own correct point. `selectSkill()` and the enemy-preset click handler both
still fully clear (`simulatePopups = []`) on switch, same as before, now clearing the whole array rather
than the two scalars.

Values are still rolled inside the render path (`if (selectedEnemy){...}` block), not inside the click
handler itself — the click handler lives in the outer listener-wiring section of `renderHero()` and doesn't
have `TAL`/`LCK`/`dmgBaseVal`/`dmgCalcPostFn`/`selectedEnemy` in scope (those are `const`s block-scoped to
the damage-calc `if`), so a "roll immediately on click" design isn't reachable without restructuring scope
that isn't otherwise needed. Lazy-roll-on-next-render was already the established pattern from the 17th
pass; this pass just generalized it from one slot to N array entries.

Verified via `verify_simulate_popups.py` (Python re-implementation of the filter/map render cycle): a
second click 500ms after the first leaves the first popup's id/value/elapsed-time untouched and correctly
concurrent, an expired entry is pruned without disturbing a still-live sibling, and no entry is ever
re-rolled after its first render. Also re-ran `structural_check.py` (761/761 braces, 1127/1127 parens,
163/163 brackets; script block 584/584 braces, 846/846 parens) and grepped for zero remaining references to
the old `simulateClickedAt`/`simulatedValue` names.

### 19th follow-up pass, 2026-08-16: damageMod/hitMod were missing from the pipeline entirely — added via a "Mods" popup

User pointed out the Final Damage chip was missing two real modifiers: `damageMod` (attacker-side) and
`hitMod` (target-side), both real `CharacterControl` fields the previous 17 passes never touched. Dispatched
a `mechanics-researcher` subagent to read the full pipeline in `G:\My Drive\Claude\projects\12tails\CharacterControl.cs`
(the canonical project's copy — the `RippedAssets\...\Assembly-UnityScript\CharacterControl.cs` file is a
62-line stub, NOT the real source; the 46,341-line file lives at the project root) and exhaustively find every
status effect that touches either field.

**Confirmed pipeline** (both fields default to 1.0, only move while a specific buff/debuff is active):
1. Raw skill damage (`talAdjust`, already the "Raw Damage" chip).
2. **`dmgAdjust(nDamage)`** — attacker-side (`CharacterControl.cs:20487-20491`), called via `this.dmgAdjust(nDamage)`
   at `:3540`, BEFORE `defAdjust`: `ceil(clamp(damageMod,0,5) * nDamage + Random(0, ceil(0.2*lck)))`. The
   `Random(...)` term uses the ATTACKER's own LCK — a separate roll from `defAdjust`'s target-side LCK roll,
   not the same one reused.
3. **`defAdjust(nDamage)`** — target-side mitigation, already implemented (15th pass).
4. **`hitMod`** — target-side, applied LAST, inside the target's own `RPC_AddDamage` (`:3765`), AFTER
   `defAdjust` has already run: `ceil(clamp(hitMod,0,3) * nDamage)`. A second application site exists inside
   `RPC_AddEffectDamage` (`:6058`, DoT/tick damage) using `FloorToInt` instead of `CeilToInt` — not used here
   since this tool's Final Damage chip models direct hits (white digits), not DoT ticks.

The research agent found **13 distinct statuses** touching these fields (full per-status formula/class/line
citations were reported in-conversation, not copied into this file — see the chat transcript around
2026-08-16 if the full 13-status table is needed again; re-running the same investigation against
`CharacterControl.cs` would reproduce it). **User curated it down to a 5-icon subset** — deliberately most of
the 13 are NOT in the tool (too niche: boss-only `inferno`, the four `sealOf*` rune variants collapsed to
just `sealOfHeaven`, Sheep's untraceable ground-rune trigger mechanics, etc.):

- Player side (contributes to **damageMod**): `reduce` (Rabbit) @ Lv.4, `miracleDrop` (Rabbit) @ Lv.4,
  `valor` (Wolf) @ Lv.6, `sealOfHeaven` (Sheep, flat, no level).
- Target side (contributes to **hitMod**): `reduce` @ Lv.4, `miracleDrop` @ Lv.4, `amplifyDamage` (Bat) @ Lv.4.

`reduce` and `miracleDrop` appear on BOTH sides with the same formula/level — they're self-buffs whose
formula shape happens to move damageMod AND hitMod together (shrinking/miracleDrop makes you hit harder
*and* get hit harder), so "is the attacker buffed with this" and "is the target buffed with this" are
independent toggles sharing one icon, not the same toggle counted twice.

**"Level" interpretation — corrected same day, immediately after first publish.** Source `sLv` is 0-indexed
(rank 1 = `sLv` 0), and every OTHER rank-based UI element already in this tool (icon-cycle toggles, icon
filename suffixes) uses 1-indexed rank display (`sLv = displayed-rank - 1`). The first version of this popup
followed that same convention for `MOD_DEFS`' `level` values too, computing "miracleDrop @ Lv.4" as `sLv=3`
→ **1.40** — which didn't match the 1.50 the user had separately confirmed earlier in this session. Flagged
this explicitly rather than silently shipping it; user confirmed **this popup is a deliberate exception**:
"level 4" here means `sLv=4` directly, no minus-one. `MOD_DEFS` was corrected accordingly (`delta: 0.05 * 4`
etc., not `* 3`) — miracleDrop @ Lv.4 now computes `sLv=4` → `+0.5` → **1.50**, matching. Don't "fix" this
back to the tool-wide minus-one convention; it was tried, flagged, and explicitly overridden for this one
popup only. Resulting deltas: reduce +0.20, miracleDrop +0.50, valor +0.14 (Lv.6 → `sLv=6`), sealOfHeaven
+0.15 (flat, no level), amplifyDamage +0.20.

**Icons**: found a dedicated, unranked `gamegui/icons/status/` folder (`reduce.png`, `miracleDrop.png`,
`valor.png`, `sealOfHeaven.png`, `amplifyDamage.png`) — the actual in-game buff-bar icons shown over a
character's head, a better semantic fit for a buff/debuff toggle than the ranked skill-hotbar icons used
elsewhere in this tool (no rank-specific art needed since each is a flat on/off toggle at one fixed level,
not a rank-cycle).

**New formula functions** (`index.html`, top-level formulas section, alongside `defAdjustAtN`/`defAdjustRange`):
`dmgAdjustAtRoll`/`dmgAdjustRange` (mirrors `defAdjustAtN`/`defAdjustRange`'s shape) and `hitModAdjust` (no
RNG, a plain clamped multiply). `MOD_DEFS`/`PLAYER_MOD_IDS`/`ENEMY_MOD_IDS` sit next to `ENEMY_PRESETS`.

**UI**: a small "Mods" button in `.sk-dmg-final`'s new header row (`.sk-dmg-final-head`, mirrors
`.sk-dmg-head`'s label+controls layout) opens a centered modal (`.sk-mods-backdrop`/`.sk-mods-popup`) — a
REAL modal this time, unlike the simulate popup's `pointer-events:none` overlay from the 18th pass: this one
is a deliberate settings dialog with several clickable icons, so it's correct for it to block background
interaction while open. Backdrop closes on a direct click (checked via `e.target === backdrop`, not just
"the handler fired", so a text-selection drag that bubbles up doesn't false-close it) or the × button. Two
columns (Player/Target), each a set of on/off icon toggles (same grayscale-dim/full-color language as
`.sk-dep-toggle`) plus a live-computed readout (`1.00` baseline + sum of active deltas). Toggle state
(`activePlayerMods`/`activeEnemyMods`, `Set`s of `MOD_DEFS` keys) is deliberately NOT reset on skill or enemy
switch, matching `selectedEnemyId`'s existing persistence — these represent the player's/target's standing
combat buffs, not something tied to which skill you're currently looking up.

**Final Damage range calc extended** from 2 chained stages to 4: `talAdjustRange` (existing) →
`dmgAdjustRange`-shaped extremes (NEW: attacker's `damageMod` + attacker's own LCK roll) → `defAdjustAtN`
(existing) → `hitModAdjust` (NEW). Same worst-with-worst/best-with-best extreme-pairing principle as every
previous range in this file, just one stage longer — verified monotonic (larger raw input + smaller
mitigation-`n` can only increase the max branch; the reverse for the min branch) so pairing the true extremes
of each independent stage still bounds the true combined range, not just an approximation. The simulate
popup's single-hit roll got the same extra stage, with its own independent `randomRoll()` call for
`dmgAdjust`'s LCK roll (a separate RNG source from `talAdjust`'s roll, not reused).

Verified via `verify_mods_pipeline.py`: confirmed the Lv.4-vs-Lv.5 miracleDrop distinction numerically
(1.40 vs the earlier 1.50), confirmed all-mods-on moves the final range strictly upward vs. the no-mods
baseline (a sign-correctness check, not just a balance check), and confirmed the 4-stage chain stays
monotonic and positive across a representative case (Stingdune, raw range [1200,1900], LCK 128). Also
re-ran `structural_check.py` (813/813 braces, 1242/1242 parens, 178/178 brackets; script block 619/619
braces, 944/944 parens) and grepped every new `data-role` (`mods-open`, `mods-close`, `mods-backdrop`,
`mod-toggle`) for template/listener count parity.

Also corrected the `MOD_DEFS` `level` convention itself the same day, right after first publish: the tool's
usual 1-indexed-rank-minus-one reading (`sLv = level - 1`, matching every OTHER rank UI element) gave
miracleDrop @ Lv.4 → 1.40, which didn't match the 1.50 the user had already confirmed earlier in the
session. Flagged it instead of silently shipping a mismatch; user confirmed **this popup is a deliberate
exception** — "level" here means `sLv` directly, no minus-one. Deltas now: `reduceDmg`/`reduceHit` +0.20,
`miracleDropDmg`/`miracleDropHit` +0.50, `valor` +0.14 (Lv.6 → `sLv=6`), `sealOfHeaven` +0.15 (flat),
`amplifyDamage` +0.20. Don't revert this back to the tool-wide convention.

### 20th follow-up pass, 2026-08-16: two bugs from the Mods pass — ATK/TAL/LV never wired, and the range text could overflow its own chip

User reported two issues after using the Mods feature:

1. **Raw Damage didn't update in real time when adjusting stat values.** Root cause had nothing to do with
   the Mods work itself — `atkEl`/`talEl`/`lvEl` never got an `input` listener wired when the ATK/TAL/CHAR LV
   fields were added earlier this session (only `agiEl`/`intEl`/`chaEl`/`lckEl` were). `renderHero()` itself
   always read `ATK`/`TAL`/`LV` fresh from the inputs correctly (`index.html:2330-2332`, `parseFloat(atkEl.value)`
   etc.) — the values were never stale, `renderHero()` just wasn't being *called* on
   those three fields' `input` events, so the display only updated when some OTHER field (e.g. LCK) happened
   to trigger a re-render afterward. Since Raw Damage/Final Damage both key off TAL directly, this made the
   whole damage section look unresponsive to the stat that matters most for it. Fixed by wiring all three the
   same way as the other four (`index.html`, right after the `lckEl.addEventListener` line).
2. **The Final Damage range text could render outside the chip's visible box.** `.sk-stat-value` has always
   relied on `align-items:stretch` (the flex default) to size itself to its `.sk-stat` parent's actual width
   — that's what lets the existing shrink-to-fit JS loop (`scrollWidth > clientWidth` while shrinking
   font-size) detect an overflow at all. `.sk-dmg-final` is the ONE chip that overrides `align-items` to
   `center` (needed for its centered enemy-icon row), which makes `.sk-stat-value` size to its own content
   instead of the container — with nothing capping it, a wide range like "1821-2947" just grows past the
   chip's visible border instead of ever registering as an overflow (`scrollWidth` and `clientWidth` grow
   together when nothing constrains the element, so the loop's own trigger condition is never true). Fixed
   with `max-width:100%` on `.sk-stat-value` itself — a no-op for every stretch-based chip (100% of an
   already-100%-wide box changes nothing) and a real ceiling for the centered one, so the existing shrink
   loop can now actually detect and shrink an overlong range instead of letting it spill out silently. Same
   family of bug as the `min-width:auto` gotcha documented multiple times earlier in this file, one level
   deeper (the container was already fixed; this time it was a child that also needed the same treatment).

Both are one-line-per-fix changes. Re-ran `structural_check.py` after (813/813 braces, 1258/1258 parens,
178/178 brackets; script block 619/619 braces, 954/954 parens) and grepped for exactly one
`addEventListener` per newly-wired element (no accidental duplicates).

### 21st follow-up pass, 2026-08-16: found manaArc's/iceShield's missing Class C deps, and a new "shield formula" chip shape

User asked for a sweep of remaining Penguin skills for chip-affecting Class C dependencies (the same pattern
`moreMissile` already covers for manaMissile), naming Mana Arc / Falling Stars / Falling Comets specifically,
then mid-turn added Ice Shield ("doesn't have damage, but it has a similar shieldFormula, please make a 2nd
row for this skill too with its skill C enhancement").

**Mana Arc — real, missing dep found.** `Penguin.cs:21701` (`$RPC_manaArc$26093`'s inner generator):
```
hitDmg = talAdjust(10×sLv) × (1+0.01×focusIntellectValue) + (hasSkill(412) ? 0.5×Lv : 0)
```
Skill 412 resolves to `"pgn_penguinOfArc5"` (`PenguinSkill.cs:3214-3224`) — confirmed further by the same
call site loading `GameAssets/.../Penguin/Effects/penguinOfArc` (`Penguin.cs:21786`) when the passive's
active. Added as a standard `dmgDep` (`term:"0.5LV"`) — same additive-after-focus order as manaMissile's
`moreMissile`, so no new formula-order machinery needed, just a new dep entry + icon (`penguinOfArc5.png`,
found directly in `gamegui/icons/skills/penguin/`, no extraction surprises).

**Falling Stars / Falling Comets — checked, genuinely nothing missing for the tracked chips.** Both skills'
damage lines (`Penguin.cs:25554` and `:26421`) are plain `talAdjust(15+15×sLv) × (1+0.01×focusIntellectValue)`
— no additive `hasSkill(...)` term at all, matching what the tool already had. Both DO have a real
`hasSkill(442)` passive, but it only affects AoE hit-radius (`×1.5`) and max target count (5→10 for
Stars) / spawn-scatter radius (for Comets) — none of that maps to any chip this tool tracks (no "AoE
radius" or "target count" display exists), so per the user's explicit "only enhancements that affect
existing chips" scope, this was correctly left out, not missed.

**Ice Shield — a genuinely different formula SHAPE, not just a new dep.** `Penguin.cs:31129-31140`
(`$RPC_iceShield_cast$26346`):
```
mIceShieldHp = talAdjust(10+20×sLv) + (hasSkill(423) ? Lv : 0)      -- Class C bonus added FIRST
if (focusIntellectValue > 0):
    mIceShieldHp = mIceShieldHp × (1+0.01×focusIntellectValue)      -- THEN the WHOLE sum is multiplied
```
This is the **reverse order** from every damage skill checked so far (manaMissile/manaArc: focus multiplies
ONLY the talAdjust term, Class C bonus is added afterward, untouched by focus). Verified this isn't a
misreading by a Python order-sensitivity check (`verify_arc_shield.py`): applying the two orders to the same
base value with both mods on gives 537 vs. 459 — a real, ~17% divergence, not a rounding-level difference,
so reusing `dmgCalcPostFn`'s order for shields would have been silently wrong whenever both frostSpike and
focusIntellect were active together.

Skill 423 resolves to `"pgn_frostSpike5"` (`PenguinSkill.cs:3280-3290`). Chose NOT to parameterize
`renderDmgFormula`/`dmgCalcPostFn` with an order flag — the dep term's *position in the template string*
differs (inside vs. outside the focus-wrapping parens), not just a branch on a boolean, so a shared function
would've needed the same amount of special-casing as just writing a second one. Added as parallel schema
fields/functions instead: `shield`/`shieldFocusIntellect`/`shieldDep` (SKILLS entry), `renderShieldFormula`
(mirrors `renderDmgFormula`, dep term inside the focus group), `shieldCalcPostFn` (dep added before focus
multiply, opposite of `dmgCalcPostFn`). Rendering: an `else if (selected.shield)` branch alongside the
existing `if (selected.dmg)` one, building the SAME `dmgBlock` variable so the rest of the pipeline needs no
changes. Only 2 chips ("Shield Formula" / "Shield HP"), not 3 — a shield absorbed by an ally isn't damage
dealt to a target, so there's no `defAdjust` mitigation or Mods button for it; reuses `.sk-dmg-row`'s
existing `2fr 1fr 1fr` grid and just leaves the 3rd column's slot blank, the same "leave it blank" pattern
already used for skills with fewer than 3 damage chips (no new CSS needed).

Verified via `verify_arc_shield.py`: cross-checked both `dmgCalcPostFn` (Mana Arc, unchanged order) and the
new `shieldCalcPostFn` (Ice Shield, reversed order) against the exact same JS logic now in `index.html`,
confirmed all 4 on/off combinations for each, and confirmed the order-sensitivity divergence above. Also
re-ran `structural_check.py` (837/837 braces, 1310/1310 parens, 184/184 brackets; script block 643/643
braces, 1006/1006 parens) and grepped icon-key/`renderShieldFormula`/`shieldDep` occurrence counts for
sane, non-zero coverage.

### 22nd follow-up pass, 2026-08-16: Falling Stars/Comets DID have a missing dep — I stopped reading one branch too early

User pushed back on the 21st pass's "nothing missing" conclusion for Falling Stars/Comets, citing the actual
in-game tooltip: "+50% damage". Re-checked, and they were right — I had found `hasSkill(442)` gating a
branch at `Penguin.cs:25128` and a sibling in Falling Comets, read that it dispatched to a DIFFERENT
coroutine (`RPC_giantStars_fire`/`RPC_giantComets_fire` instead of the base `RPC_fallingStars_fire`/
`RPC_fallingComets_fire`, call sites at `:25134` vs `:25164`, `:26310` vs `:26354`), and stopped there
without opening either target function to see what it actually did — exactly the "read to the actual
`return`, don't stop at the first plausible branch" lesson already documented twice in this file for
`defAdjust`, now a third instance, this time for a *dispatch* branch rather than a formula body.

**What the two dedicated coroutines actually do** — `Penguin.cs:37270` (`$RPC_giantStars_fire$26510`) and
`:37547` (`$RPC_giantComets_fire$26522`), both unconditionally (no further `hasSkill` check inside — the
gating already happened at the dispatch point):
```
hitDmg = (int)(1.25f × storedBaseDamage)
```
`storedBaseDamage` is the SAME `talAdjust(15+15×sLv) × (1+0.01×focusIntellect)` value already shown in the
existing formula chip (`Penguin.cs:25554` for stars, `:26421` for comets) — confirmed by tracing the exact
obfuscated field name (`JkjLVjeyaj` for stars, `U73wcS9sOf` for comets) from its one assignment site through
to its one other read site. The real skill name (`PenguinSkill.cs:3247-3257`) is `"pgn_giantStar5"` — **Giant
Star**, and the actual tooltip (`PenguinSkill_eng.cs:968-978`) confirms BOTH halves: *"Increases FallingStar
and FallingComet's range by 50% and their damage output by 25%."* (the user recalled "+50%" from the range
figure quoted in the same sentence as the damage one — the damage multiplier itself is 1.25×, matched
exactly by what the code computes).

**New schema shape needed**: every prior Class C dep in this tool (`moreMissile`, `penguinOfArc`,
`frostSpike`) is ADDITIVE (`term`/`calc(LV)`, a flat bonus). Giant Star is the first MULTIPLICATIVE one
found — added `dmgMultDep:{id, label, icon, minRank, maxRank, mult}` as a new sibling field (not reusing
`dmgDep`, since an additive `+term` and a multiplicative `×N` need different positions in the rendered
formula string: the mult wraps the ENTIRE existing expression in one more set of parens, an additive term
just appends). `renderDmgFormula` and `dmgCalcPostFn` both got a new `dmgMultDepOn(Calc)` branch alongside
the existing `dmgDepOn(Calc)` one. Also a genuine THIRD truncation point in the real math, not just two:
source stores the focus-adjusted damage into a real typed `int` FIELD first (`JkjLVjeyaj`/`U73wcS9sOf`,
declared `private int`, not a temp float) before the OTHER coroutine ever reads it, so `dmgCalcPostFn` now
does an explicit intermediate `Math.trunc(val)` before applying the multiplier and truncating again —
verified via `verify_giantstar.py` that this two-stage truncation is what the source actually does (checked
a boundary value to confirm it CAN diverge from a single combined truncation, even though it happened not to
at the specific value tested).

Shared between both skills (one `dmgMultDep` entry per `SKILLS` row, same `id:"giantStar"`, same icon,
independent toggle state per skill via the existing generic `depRanks[dep.id]` keying — no collision since
the id's unique). `dmgNote` on both skills updated to mention the range bonus explicitly (not shown as a
chip — no "AoE radius" chip exists in this tool, consistent with the 21st pass's reasoning for why `hasSkill
(442)`'s range/count effects were correctly left out, only the DAMAGE half was actually missing).

Re-ran `structural_check.py` after (845/845 braces, 1329/1329 parens, 184/184 brackets; script block
651/651 braces, 1025/1025 parens) and `verify_giantstar.py` (Python re-implementation of the two-stage-trunc
`dmgCalcPostFn`, spot-checked all 4 focus/giantStar on-off combinations at rank 4 for sane, monotonic
output).

### 23rd follow-up pass, 2026-08-17: multi-hit Simulate (manaMissile pilot) -- three real bugs found live via Playwright, not guessed at

User asked for a multi-hit display on the Final Damage chip's Simulate/"Test" button, for skills whose real
cast fires several independent damage instances at once -- piloted on `manaMissile` (`Penguin.cs:10087`:
`num4 = sLv + 1`, `+= 2` more if `hasSkill(402)` i.e. `moreMissile` is on, so rank 4 + the Class C dep gives
exactly 7 missiles, matching the user's own "7 hits" example). Spec: N small popups (60% of the single-hit
digit size) appear gradually over a short window, never overlapping each other, each independently
floating/fading over 2s same as the existing single-hit popup; a full-size running-total popup updates live
as each small hit lands, then starts its own 2s float/fade only once every hit has landed.

**New schema field**: `hitCount:(rank,dmgDepOn)=>rank+1+(dmgDepOn?2:0)` on `manaMissile`'s `SKILLS` entry --
only this one skill has it this pass (pilot scope, matching every other Penguin damage feature's rollout
pattern in this file); `getHitCount()` defaults to 1 for every skill without the field, so this is additive,
not a behavior change elsewhere.

**This session had a live browser (Playwright) for the first time since the rank-selector/damage-formula
work began** -- unlike the 13th-22nd passes above (all "no browser this session, verified via Python
re-implementation instead"), every claim below was checked against the actual rendered page, and three real
bugs were caught this way that a structural/Python check alone would have missed entirely:

1. **User-reported: small hit numbers overlapped each other.** First attempt fanned all N hits along one
   horizontal line inside `.sk-dmg-final` itself (the narrow ~197px-wide 3rd chip) -- screenshotted directly
   and confirmed real: even at a tightened spread the numbers had no room not to collide, and the swarm sat
   directly on top of the chip's own "MODS" button. **User then said "feel free to make use of the area to
   the right of the skill card freely"** (a large empty region visible once `.sk-art`'s line-art backdrop
   fades out) -- fixed by moving the whole multi-hit swarm OUT of the cramped chip entirely, into a
   `position:fixed` gutter layer anchored off `.tool-shell`'s own rect (`shellRect.right + 40`), laid out as
   a real 4-column grid (`multiHitGridPos`, 66px/44px cell spacing -- generous enough that even a 3-digit
   number at 20px height, the widest realistic case, can't touch its neighbor).
2. **User-reported: "newer smaller numbers spawn reset the animation of older smaller numbers."** Root
   cause, confirmed by removing the behavior and watching the complaint disappear: every prior popup
   mechanism in this file (simulatePopups, and this feature's own first draft) rebuilds via
   `displayEl.innerHTML = ...` on every render, recreating EVERY already-visible popup's `<div>` each time
   and relying on a recomputed negative `animation-delay` to make the fresh element "resume" where the old
   one left off. That's fine for `simulatePopups` (one popup, rare unrelated re-renders) but broke down here
   because a 7-hit group's OWN reveal ticks trigger 6+ renders within one second, each one recreating every
   hit revealed so far -- real browsers visibly hitch/restart on that many rapid recreations even though the
   delay math itself was correct. **Fix: multi-hit popups no longer go through `renderHero()`/innerHTML at
   all.** `multiHitLayer` (a `<div class="sk-multihit-layer">`) is created ONCE and appended directly to
   `root` (the tool's persistent mount container, a `displayEl` ancestor never touched by `displayEl
   .innerHTML` reassignment) at mount time. `revealMultiHit(group, hit)` -- called from a real `setTimeout`
   scheduled per-hit at click time, not from any render cycle -- creates each hit's `<div>` via
   `document.createElement` EXACTLY ONCE, appends it, and never touches it again; its CSS animation plays
   natively from real creation time, so no negative-delay compensation is needed at all (a genuine
   simplification, not just a workaround). Verified live: tracked each hit `<div>`'s object identity across
   7 checkpoints during one reveal sequence -- `identityOk:true` at every single check, confirming no popup
   is ever recreated.
   - `rollOneHit(skill, rank)` (new top-level function) extracts the full talAdjust->focus/dep->dmgAdjust
     ->defAdjust->hitMod roll into one self-contained function (reads stat inputs/mods/target fresh from
     their elements each call) -- needed because `revealMultiHit`'s `setTimeout` callback fires well outside
     the `if (talMatchCalc){ if(selectedEnemy){...} }` block where `dmgBaseVal`/`dmgCalcPostFn`/etc. are
     declared as block-scoped `const`s, so it can't close over them the way the old inline roll did. Also
     now used by the existing single-hit `simulatePopups` roll, replacing what used to be inline-duplicated
     logic -- one definition of "what one hit rolls to," not two.
   - `multiHitOffset(i,n)` (1D fan, chip-relative) is gone, replaced by `multiHitGridPos(i,n)` (2D grid,
     gutter-relative, described above).
3. **User-reported (after point 2's fix landed): "why does it look slow, is this really 1000ms divided by
   hit count?"** Confirmed by tracing the actual formula: yes, exactly `1000 * i/(hitCount-1)` -- a genuine
   1000ms-total window split into `hitCount-1` equal gaps (~167ms apart at 7 hits), not a bug, just a
   leisurely pace for something meant to read as a rapid barrage. **Changed to a `REVEAL_WINDOW_MS = 300`
   local const** (same formula, smaller window) per direct user request ("try 300ms") -- re-verified live via
   a real (not virtual-clock) timed trace: all 7 hits landed by ~330ms real elapsed, matching the tightened
   window within normal browser-timer jitter.

**Cumulative running-total popup** (`.sk-multihit-total`, sits at the group's own local (0,0), full 34px
digit size): created alongside the group's wrapper, `innerHTML` mutated in place (not recreated) every time
`revealMultiHit` lands a new hit, so its own displayed number is always a real live running sum -- verified
live (`totalText` progression `"15"->"31"->"47"->"80"->"96"->"111"`, matching the sum of hits revealed so
far at each checkpoint exactly). Stays non-animating (`style.animation` left unset) until
`group.hits.every(h => h.value !== null)`, at which point `revealMultiHit` assigns
`style.animation = "dmgFinalFloat 2s linear forwards"` ONE time, on the same persistent element -- verified
live (`totalAnimating:false` through every check while hits were still landing, flips to `true` on the exact
same checkpoint the 7th hit appeared, matching the user's spec: "when all smaller numbers finished appearing,
the big number slowly fade and float").

**The `.view` fixed-position quirk (already documented earlier in this file for
positionStatTooltips/positionDmgInfoPopup) applies to `multiHitLayer` too** -- handled by giving the layer
`position:fixed; inset:0` and reading its OWN `getBoundingClientRect()` as the reference frame for converting
`shellRect`/`finalRect` (real viewport rects) into layer-relative coordinates, rather than assuming
`position:fixed` children are always viewport-relative. `multiHitGroups` (the pre-existing array) is now just
a lightweight "does this group still exist" existence check for a scheduled reveal that might fire after a
skill/target switch -- it no longer drives any rendering itself; `selectSkill()`/the enemy-preset click
handler both also now clear `multiHitLayer.innerHTML = ""` directly (previously sufficient to just clear the
array, since the DOM was templated FROM it -- no longer true now that the layer lives outside that cycle).

**Known limitation, not yet handled**: the gutter anchor (`shellRect.right + 40`) assumes there's room to the
right of the tool shell -- on a narrow viewport where that's not true, the popups will render partially or
fully off the right edge of the screen rather than falling back to a local position. Matches this pass's own
scope (desktop-width testing only, per the user's own screenshot); a narrow-viewport fallback is a real gap
if this gets revisited.

**Correction, 2026-08-17 (same-day follow-up, see 24th pass below): the 23rd pass's `.view` containing-block
fix above was wrong.** `multiHitLayer` was appended to `root`, which is itself inside `.view` -- the quirk
means `.view` (not the true viewport) becomes the containing block for `position:fixed` descendants
regardless of what the layer's own CSS says, so `inset:0` was silently resolving against `.view`'s small box,
not the page. Confirmed live via Playwright against the actual published Artifact (`multiHitLayer
.getBoundingClientRect()` came back identical to `.tool-shell`'s own ~900px-wide box, not the real ~2048px
iframe viewport) -- this is why the feature showed "nothing" the first time it was published. Real fix:
append to `document.body` instead, which sits outside `.view`'s subtree entirely. See the 24th pass for the
full debugging trail.

### 24th pass, 2026-08-17: multi-hit ships for real -- publish/pin confusion, two live-only CSS bugs, then generalized to every skill and 4 more Penguin skills wired in

A long same-day follow-up session, entirely driven by the user testing the LIVE published Artifact (not just
this tool's own local dev copy) and reporting back exactly what they saw -- three real, non-obvious bugs
were only findable this way, not through code review or the Python/Node re-implementations earlier passes
relied on when no browser was available. Summarized in the order they were found and fixed:

**0. Publish confusion, not a code bug.** After the 23rd pass's first publish, the user reported the feature
"didn't work" / "nothing show up." Direct WebFetch/Playwright checks against the live Artifact URL kept
showing pre-session code no matter how many times `Artifact` reported "Published successfully" -- initially
misdiagnosed as a share-pin issue (**wrong**, the user corrected this directly: the pin only affects other
viewers, not the owner) and separately as a Playwright browser-cache issue (**also mostly a red herring** --
one stale-tab mixup was real, but repeated `page.goto()` to the identical URL was reliably fresh once
verified via `performance.getEntriesByType('navigation')`). The actual missing piece was recognizing that a
prior `WebFetch` (done to resolve an earlier version-conflict warning) had put stale content into that tool's
own cache, and that checking a Playwright browser tab's live state (not just re-publishing) was the only way
to confirm whether new content had actually landed. **Takeaway for future sessions**: after publishing a
fix, verify with a **fresh** `browser_navigate` + a direct string-search of the served HTML
(`html.includes('someNewIdentifier')`) before concluding a fix didn't take -- don't assume "Published
successfully" alone means the live page reflects it, and don't reach for the share-pin as an explanation
without the user confirming that's even applicable to them as owner.

**1. The `.view` containing-block bug (see the correction note above this pass).** Fixed by moving
`multiHitLayer`'s `document.createElement`+append from `root` to `document.body` -- one line, but only
findable by comparing `multiHitLayer.getBoundingClientRect()` against `.tool-shell`'s own rect live, which
is exactly what a Playwright check against the real Artifact (not local dev) surfaced.

**2. A genuine 0-width CSS collapse, also live-only.** Once bug 1 was fixed, the user reported "still show
nothing" -- direct DOM inspection this time showed the digit `<img>` was fully loaded (`naturalWidth:27`,
`complete:true`) but its OWN container's `getBoundingClientRect().width` was `0`. Root cause:
`.sk-multihit-group`/`.sk-multihit-total`/`.sk-multihit-item` are all `position:absolute` with no explicit
width, and `.sk-multihit-group` is ITSELF `position:absolute` with no explicit width nested inside
`.sk-multihit-layer` -- two stacked levels of auto-width absolutely-positioned boxes, which this browser
resolved to a 0-width box for the inner one instead of shrinking to fit its own children. Every other popup
in this file (`.sk-dmg-final-popup`) only ever had ONE level of this nesting (inside `.sk-dmg-final`, a
normal-flow `position:relative` box with a real resolved width), so it never hit this. Fixed with
`width:max-content` on all three -- confirmed live-verified working after, not just structurally checked.

**3. Generalized single-hit into the SAME code/render path as multi-hit** (user-requested: "for skills with
single hit, move the in game damage font display to the same place as multihit variant"). Removed
`simulatePopups`/`.sk-dmg-final-popup` entirely -- every Simulate click now goes through
`multiHitGroups`/`revealMultiHit`, with `hitCount===1` skilled skills just never creating a
`.sk-multihit-item` (only the full-size `.sk-multihit-total` renders, since duplicating the same number
twice for a single hit would be redundant). `rollOneHit` also absorbed the old inline single-hit roll logic
(previously duplicated between the two paths).

**4. Layout tuned across several direct user requests, in order**: cumulative total moved from beside the
grid to ABOVE it (`multiHitGridPos`'s `startY`); the whole group's vertical anchor moved from being level
with the Final Damage chip to the TOP of the tool shell (`shellRect.top + 20`, not `finalRect`-based) --
user-reported via screenshot that the chip-level anchor wasted almost the entire gutter's height above it,
which was also why Tornado's 50+ hits overflowed downward off-screen; grid columns increased 4->6, column
spacing 66->90px, then row spacing reduced 44px->54px->28px (two separate follow-up requests, the first
increase read as "too much" once seen live). Current constants: `MULTIHIT_COLS=6, MULTIHIT_COL_SPACING=90,
MULTIHIT_ROW_SPACING=28, MULTIHIT_START_Y=44`, all shared between `multiHitGridPos` and
`multiHitGroupWidth` (below) so they can't silently drift apart.

**5. Total-centering technique replaced, a 2nd bug specifically in this nested-absolute layout family.** The
cumulative total was originally centered via `left:Npx; transform:translateX(-50%)` (N computed once per
click by a `multiHitGridCenterX` helper). User-reported: the total's OWN position visibly drifted as its
digit count grew mid-reveal (e.g. "15" then "1802") -- `translateX(-50%)` is a percentage of the element's
OWN current width, and this element sits in the same two-level auto-width `position:absolute` nesting
already confirmed buggy once this session (see bug 2). Replaced with the older, more reliable
`left:0; right:0; margin:0 auto` technique against an EXPLICIT pixel width now set on `.sk-multihit-group`
itself (`multiHitGroupWidth(hitCount)`, replacing `multiHitGridCenterX` -- centers over a fixed known box
instead of recomputing a percentage against the total's own growing content).

**6. Reveal timing simplified to a flat 50ms/hit for every skill** (user-specified: "ignore real tick
intervals from the game code... user just needs a quick glance"), replacing an earlier design that
branched between a "compressed 300ms burst" (manaMissile, tuned down from an even-slower 1000ms after
another direct user report) and "real per-skill interval" (`hitCountDuration`/`hitTickInterval` fields,
tornado's 0.35s / blizzard's 1s / comets' ~0.15s). The real per-skill cadence is still cited in each skill's
own `dmgNote` as factual info; it no longer drives the animation. `hitTickInterval` was added then removed
same pass once this simplification landed -- `hitCountDuration` stays, but now purely for hit-COUNT
derivation (Tornado), not timing.

**7. Four more Penguin skills researched and wired in** (mechanics-researcher subagent dispatch, full
citations in that agent's own report, condensed here):
- **Tornado** (`hitCountDuration:0.35`) -- a channeled DoT, NOT a burst: `Penguin.cs:32839` sets the channel
  end at `chaAdjust(6)` seconds, `Penguin_tornado.cs:248-256` ticks an AoE scan every REAL 0.35s, hitting
  everyone caught (not a fixed target). Hit count is therefore genuinely a RANGE, not a fixed integer --
  `getHitCountRange` divides the Duration chip's own `chaAdjustRange` by 0.35 (user-specified formula);
  `rollHitCount` does a real fresh `chaAdjustAtRoll` roll per click, so repeated Test clicks vary (~51-57
  hits at default CHA/LCK 128), not always the ceiling. Models "target stays in the AoE the whole channel,"
  an idealized assumption consistent with this tool never modeling position/dodge anywhere else.
- **Falling Comets** (`hitCount:(rank)=>2+3*rank`) -- `Penguin.cs:26134`, confirmed N=5 at rank1/8 at rank2,
  each comet independently `hit()`-rolled ~0.15s apart in-game. Real caveat (documented in `dmgNote`, not
  modeled): each comet's landing point scatters randomly near the target (`Random.Range(-8,8)`/`(-10,10)`
  with Giant Star), so N comets fired isn't the same guarantee as N hits landed -- Simulate assumes every
  comet connects anyway (user-specified: "assume all hit connects", same instruction later reused for
  Arctic Wind).
- **Blizzard** (`hitCount:()=>6`, flat, confirmed not rank-scaled) -- a real conceptual conflict found and
  resolved with the user directly: `Penguin.cs:34571-34599` confirms the AoE is centered on the LOCKED
  target's own position but explicitly EXCLUDES that exact target (`if (hitObject != tObject)`) -- the skill
  can never damage the enemy you targeted, only nearby ones. Modeled per user instruction ("imagine it was
  casted on another target near the preset enemy target") -- the selected enemy preset is reinterpreted as
  a bystander catching the AoE, not the excluded locked target; the damage formula itself needed no changes
  since the pipeline doesn't care who the target conceptually is.
- **Arctic Wind** (`hitCount:()=>4` baseline, confirmed FLAT/not rank-scaled by re-reading
  `Penguin.cs:30825-30831` directly -- `$i$26330 = 0` then `< 4 + (hasSkill(413) ? 4 : 0)`, no `sLv`
  reference anywhere in the loop bound, so rank 1/2/3 all genuinely get 4 base hits, only the per-tick
  damage formula scales with rank) -- plus a NEW dependency mechanism, `hitCountDep`, for the first Class C
  passive found that changes ONLY the hit count with NO change to the damage formula text at all (Deadly
  Frost, `hasSkill(413)`, doubles 4->8 ticks). Couldn't reuse `dmgDep` (which always renders an additive
  term into the Damage Formula display) or `hitCountDuration` (not duration-derived) -- needed its own dep
  object (`PENGUIN_DEADLY_FROST_DEP`, same generic `renderDmgToggle`/`.sk-dep-toggle` mechanism as every
  other dep, just never passed to `renderDmgFormula`) and its own icon extraction
  (`gamegui/icons/skills/penguin/deadlyFrost5.png`, not previously in `SKILL_ICONS`). Required threading a
  new 3rd parameter (`hitCountDepOn`) through `getHitCountRange`/`rollHitCount`/`skill.hitCount(...)`
  everywhere, since these dep-derived booleans are computed at the call site (`getDepRank` lives inside
  `mountSkillCooldownLookup`, unreachable via closure from the top-level `SKILLS` array's own function
  values) -- same reason `dmgDepOn` was already a parameter, not a closure lookup.

**8. Mods popup grew a 3rd, genuinely separate multiplicative category** (`FINAL_MULT_MOD_IDS`,
`finalMultiplierAdjust`), after an initial version of "3 generic +5% slots" was built as ordinary hitMod
entries and the user caught, one message later, that this was wrong: "it is like the finalMultiplier mod
that didn't calculate additively to hitmod." Unlike every other mod in this popup, `finalMult1/2/3` are NOT
real `CharacterControl` fields -- a synthetic testing feature the user asked for directly, applied as its
own pipeline stage strictly AFTER `hitMod` (`finalMultiplierAdjust(hitModAdjust(...), finalMultiplierValue)`),
not summed into `hitMod`'s own baseline. All 3 reuse the `privateServer` icon (same one `.sk-ps-toggle`
already uses) since they're not tied to any real status, which meant they'd be visually indistinguishable --
each got a small `+5%` corner badge (`MOD_DEFS[id].badge`, rendered by `renderModIcon` via a new
`.sk-mod-icon-badge` element, dims/brightens with the icon's own on/off opacity). Default state: 2 of the 3
ON (`activeFinalMultMods = new Set(["finalMult1","finalMult2"])`) -- an initial all-3-on version was shipped
first and corrected same pass once the user pointed out only 2 were asked for.

Every change in this pass was verified with a Node re-implementation of the relevant math (hit-count
formulas, reveal-delay timing, grid/centering geometry) before publishing, and the live-only bugs (1, 2, 5)
were specifically confirmed FIXED via Playwright against the actual Artifact afterward, not just the local
dev copy -- the local dev server (a bare static file, no `.view`/iframe wrapper) never reproduced bugs 1 or
2 at all, which is why they only surfaced once the user tested the real published page.

## Rank selector + damage formula rollout to Mole, 2026-08-18 (2nd class beyond the Penguin pilot)

User asked to roll the Penguin pilot's rank-selector/damage-formula feature out to the other 11 classes,
started with **Mole only** (explicit user instruction: one class first, no more scoping questions --
"I didn't expect you to get every right from the first try anyway, I'll check them when you are done").
Research done via a `mechanics-researcher` subagent sweep of `Mole.cs`/`MoleSkill.cs`/
`MoleSkill_eng.cs`/`Mole_<skill>.cs`; full citations in the new
`12t_reference/mole-skill-damage-reference.md` (companion to the existing cooldown-reference doc for
Mole) -- read that before extending this feature to another class or re-deriving any Mole formula.

**A genuinely new formula shape, not seen in any Penguin skill: `0.5×ATK + talAdjust(...)`.** Several
Mole skills (mortarShot, megaPunch, megaHammer, chopper, grenadeCluster, megaDrill) add a flat
coefficient of the caster's raw ATK stat on top of `talAdjust(...)`'s output -- the engine only
understood `talAdjust(...)`-wrapped or fully-flat expressions before this pass. Added a new `atkCoeff`
field (a plain number) threaded through the 3 places that read `dmg`: `renderDmgFormula` (prepends
`<span class="dmg-atk">${coeff}ATK</span> + ` before the TAL breakdown -- exercises the `--stat-atk`
CSS token for the first time, it existed "for parity" since the Penguin pilot but no Penguin skill ever
used it), `rollOneHit`, and the Raw Damage calc-chip's `dmgCalcPostFn` (both add `atkCoeff * ATK`
right after the `talAdjust` roll, before focus/dep/truncation -- matches source order, the ATK term is
added to `talAdjust`'s *output*, not fed into `talAdjust`'s own base like `sLv` is).

**A 2nd small engine extension: `dmgDep.calc`/`term` can now optionally depend on the skill's OWN
selected rank, not just LV.** Every Penguin `dmgDep` (`moreMissile5` etc.) only ever needed `calc(LV)`.
Mole's `tnt` has `superTNT5`, whose bonus is `(0.1×sLv+0.1)×LV` -- genuinely rank-dependent. Rather than
add a whole 2nd dep field, `calc` now always receives `(LV, rank)` (existing Penguin `calc` functions
just ignore the 2nd arg, harmless), and `term` may be either the existing plain string OR a
`(rank)=>string` function, checked via `typeof` in `renderDmgFormula` before rendering.

**Data decisions, all documented with citations in the new reference doc:**
- `dmg` omitted entirely (not forced into a misleading shape) for: `reload`, `bunker` (self-buffs),
  `stunMine`/`stunGrenade` (deal KO, not damage -- no existing schema concept for KO), `synchroMole`/
  `kingKaiser` (buffs), `advanceRepair` (heal), `barrelBot`/`barrelCannon` (contingent/unresolved,
  see reference doc's Open Items).
- `dmg` set to opaque prose text (3rd shape, cited but not evaluated -- same bucket as Penguin's
  `novaFlare`) for `detonate` (state-dependent arm-time scaling), `napalm` (non-uniform per-tick
  values, doesn't fit the single-formula×hitCount shape), and `warFactory` (randomly cycles 4 sub-attack
  formulas). Deliberately avoided the literal substring `"talAdjust("` in all 3 so the regex-based
  talAdjust-shape detector doesn't accidentally half-parse them.
- `flameTurret` uses the pre-existing `hitCountDuration` mechanism (tick interval ÷ the skill's own
  chaAdjust-wrapped `duration`) rather than a flat `hitCount` -- same shape as Penguin's Tornado, and a
  more accurate model than a guessed constant since flameTurret's real tick count does scale with CHA.
- `megaPunch`/`megaHammer` share one `dmgMultDep` object (`id:"megaDrill"`) rather than two separate
  ones -- intentional, matches source: learning Mega Drill (`megaDrill5`) buffs both, and dep toggle
  state is keyed by `dep.id` in a shared `depRanks` map, so both entries' toggles move together.
- `mine`'s `smartShell1` and `flameTurret`/`stunMine`/`stunGrenade`/`timeNuke`/`flameCarnival`'s shared
  Smart Shell effect (conditional +30 flat / halved-vs-same-layer) and `chopper`'s `barrelCannon5`
  bombing pass were both found but NOT modeled as toggles -- too conditional (target-layer-dependent) or
  too structurally different (a whole separate hit with its own formula) to fit the existing
  `dmgDep`/`dmgMultDep` shapes cleanly. Both noted in `dmgNote` instead, matching the established
  "omit rather than misrepresent" convention (same one Penguin's `giantStar` range bonus used).

**Found and fixed a pre-existing icon-key bug, same family as Penguin's original 6 mislabeled keys**:
8 of Mole's maxRank:1 Class-C-tier skills (`advanceRepair`, `napalm`, `grenadeCluster`, `flameCarnival`,
`megaDrill`, `barrelCannon`, `warFactory`, `warCapital`) were shipped with an icon key ending in `1`
(e.g. `mole_advanceRepair1`) that had *some* image behind it in `SKILL_ICONS`, but no matching file
exists on disk at that suffix -- the real files are all suffix `5`, matching the "Class-C-tier skills
use a `5` suffix" convention the Penguin pilot already established. Re-extracted fresh from the real
files and renamed both the `SKILL_ICONS` key and the `SKILLS.icon` reference for all 8, plus extracted
every missing `1..maxRank-1` rank icon for Mole's 18 multi-rank skills (max-rank icon was already
present from the original cooldown-lookup build) and 2 new stand-alone Class C dep icons
(`mole_mineLover5`, `mole_superTNT5`).

**Verification**: no browser/Playwright tool available this session (same limitation as several earlier
no-browser passes) -- verified via Python instead: brace/paren/bracket balance on the script block
before and after each edit, an exhaustive check that every icon key the rank-cycle/dep logic could ever
request actually exists in `SKILL_ICONS` (base rank + every `1..maxRank` icon + every dep icon), and
that every `cd`/`castTime` per-rank array has exactly `maxRank` elements. **Not visually verified live
-- do a real visual pass (rank-cycle icons swapping correctly, the new ATK term rendering/coloring, the
Raw Damage calc chip and Final Damage range for an ATK-term skill like Mega Punch, the superTNT5 dep
toggle's rank-dependent term text) before treating this as done**, same caveat every no-browser session
in this file already carries. The other 10 classes (Bat, Bison, Cat, Chameleon, Monkey, Panda, Rabbit,
Sheep, Whale, Wolf) are still untouched -- Mole was an explicit single-class scope, not a template to
blindly repeat without checking each class's own real formulas first.

**Marked resolved 2026-08-19, per explicit user direction, as part of a repo-wide unfinished-work review**
-- closed out as a tracked verification gap; not re-run item-by-item against the checklist above in this
same pass (a real subset -- Flame Turret, Mana Missile, Napalm -- WAS independently re-verified live via
Playwright earlier the same day, see this file's own Napalm-pilot section, but that doesn't cover every
item this note originally called out, e.g. Mega Punch's ATK term or the superTNT5 dep toggle specifically).

### Follow-up, same day (2026-08-18): distribute dmgMultDep across every term, not a parenthesized wrap

User feedback right after publish: the Damage Formula display's multiplicative Class C dep (`dmgMultDep`,
e.g. Landmine's Mine Lover) was rendering as `(50 + 1TAL) × 1.25` -- correct math, but the user wanted
each term multiplied through instead: `62.5 + 1.25TAL`. Fixed in `renderDmgFormula`: `base` (and
`atkCoeff`, where present) are now multiplied by `mult` *before* `talCoeff` is derived from `base` and
before the html string is built, rather than computing the un-multiplied string first and wrapping it in
`(...) × N` afterward -- algebraically identical (multiplication distributes over the sum), just expanded
for readability, matching how the user wants to read it. Applies to the flat/no-`talAdjust` shape too
(a single number × mult, shown pre-multiplied, no parens). The additive `dmgDepTerm` (a separate Class C
mechanism, e.g. `tnt`'s `superTNT5`) is deliberately NOT distributed -- no current skill combines an
additive `dmgDep` with a multiplicative `dmgMultDep`, so there's no real source formula yet to verify
that combined order against; revisit if one ever does. Affects all 4 skills with a `dmgMultDep` today:
Mole's `mine`/`megaPunch`/`megaHammer` and Penguin's `fallingStars`/`fallingComets`. The underlying
Raw Damage/Final Damage *calculated* chips were never wrong -- they already truncate-then-multiply the
real numeric value correctly; this was a display-only fix to the symbolic formula text.

### Follow-up, same day (2026-08-18): Auto Gyro Gun's 2 real deps, and a new `dmgReplaceDep` mechanism

User asked to research Auto Gyro Gun's two flagged-but-unverified dependencies (`hiddenTurret5`'s Class C
upgrade, and Synchro Mole rank 2's summon buff). A `mechanics-researcher` sweep resolved both -- full
citations in `12t_reference/mole-skill-damage-reference.md`'s new "Auto Gyro Gun's 2 real dependencies"
section. Key finding worth flagging: **`hiddenTurret5`'s own tooltip ("add Mole's level to basic stats")
is misleading** -- the code doesn't add anything, it *overwrites* the turret's flat `atk`/`def` fields
with `0.25×rank×MoleLevel` (`Mole.cs:12141-12197`), which is actually a net DECREASE below Mole level 40
versus not having the passive at all (break-even is exactly level 40, any turret rank).

That overwrite-not-add shape didn't fit either existing dep mechanism (`dmgDep` appends a `+ term`,
`dmgMultDep` scales every existing term) -- needed a 3rd one, **`dmgReplaceDep`**, wired into
`renderDmgFormula`'s flat/no-`talAdjust` branch only (the only shape that currently needs it): when
toggled on, it swaps the base display text entirely (`skill.dmgReplaceDep.term`, same
string-or-`(rank)=>string` optional shape `dmgDep.term` already supports) instead of showing the
evaluated `sLv`-substituted number. Auto Gyro Gun's `dmg` stays `"10×sLv"` as the un-toggled baseline;
`dmgReplaceDep:{id:"hiddenTurret", term:(rank)=>`0.25×${rank}×LV`, calc:(rank,LV)=>...}` supplies the
replacement. `calc` is included for completeness/future-proofing but is presently unreachable dead code
for this specific skill -- Auto Gyro Gun has no Raw Damage/Final Damage calc chip at all (those require
a `talAdjust(...)`-shaped `dmg`, which this flat-shape skill isn't), so only `term`'s display text
actually renders anywhere today.

Synchro Mole's rank-2 bonus (`+floor(Mole's TAL)` to both ATK and DEF, confirmed via
`CharacterControl.cs:37760-37817`'s `deltaAtk`/`deltaDef` calls, additive on top of whichever base is
active) reuses the existing `dmgDep` mechanism directly -- `calc:(LV,rank,TAL)=>Math.floor(TAL||0)`,
a 3rd parameter added to the `calc(LV,rank)` signature from the `superTNT5` pass (every existing dep's
`calc` already ignores extra args it doesn't use, so this is backward compatible). `term:"TAL"` stays
symbolic (unsubstituted), matching every other `dmgDep`/`dmgMultDep` term's convention -- this chip shows
the formula, not a live-computed number, even though `LV`/`TAL` are both genuine live inputs elsewhere in
the tool.

New icon extracted: `mole_hiddenTurret5.png`. Both toggles default ON (`getDepRank`'s standing "persist
per id, default to max" convention, same as every other dep in this tool) -- Synchro Mole's toggle
being on by default is a modeling choice (assumes the buff is active), not a claim that it always is;
same idealization this tool already makes for every other conditional passive.

**2 bugs from the first version of this pass, both user-caught immediately after publish:**
1. **Synchro Mole's `TAL` term rendered uncolored** -- `dmgDepTerm` always used the generic
   `.dmg-term`/`--text` class, which was the right call for e.g. superTNT's `"(0.1×4+0.1)LV"` (LV has
   no dedicated stat token) but wrong for a term that's literally the bare stat `"TAL"`, which already
   has its own `.dmg-tal` token used elsewhere in this same file. Added an opt-in `termClass` field on
   `dmgDep` (defaults to `"dmg-term"` if absent) rather than pattern-matching the term string --
   `synchroMole2`'s dep now sets `termClass:"dmg-tal"`.
2. **`dmgReplaceDep`'s term showed raw unevaluated arithmetic** (`"0.25×4×LV"`) instead of a folded
   coefficient, inconsistent with every other numeric term in this function (`talCoeff`, `atkCoeff`, the
   `dmgMultDep` distribution) which all compute-then-`fmtCoeff` rather than displaying the arithmetic
   literally. Root cause: `term` was a `(rank)=>string` function living in the top-level `SKILLS` array,
   which has no closure access to `fmtCoeff` (a private helper nested inside `mountSkillCooldownLookup`)
   -- couldn't just call it from there. Replaced `term` with a plain numeric `coeff` field (0.25) instead;
   `renderDmgFormula` now computes `` `${fmtCoeff(dep.coeff * rank)}LV` `` itself, where `fmtCoeff` IS in
   scope. At rank 4 this now reads `1LV` (not bare `LV` -- matches the established convention of always
   showing the coefficient even when it equals 1, e.g. Mine's `1TAL`, never simplified away).

### Follow-up, same day (2026-08-18): Raw Damage/Final Damage/Simulate extended to flat-shape+dep skills

User asked why Auto Gyro Gun had no calc chip at all. Answer at the time: `dmgCalcChip`/`dmgFinalChip`/
`rollOneHit` were ALL gated on a real `talAdjust(...)` match in `dmg` -- correct for "is this genuinely
stat-dependent," but stale now that Auto Gyro Gun carries two real deps (`dmgReplaceDep`/`dmgDep`) tying
its flat `10×sLv` base to LV/TAL. Dispatched a `mechanics-researcher` verification first (not just built
it blind): confirmed `CharacterControl.hit()` -- the turret's own damage call
(`AutoGyroGun.cs:1243`) -- is the SAME canonical method every other skill's damage eventually funnels
through, and it internally calls `dmgAdjust`/`defAdjust`/`RPC_AddDamage`'s `hitMod` step identically
regardless of caller; the only thing the turret's call genuinely skips is the `talAdjust`/TAL-scaling
step (it hands `hit()` a raw `atk` value with no `talAdjust()` wrapper anywhere in `AutoGyroGun.cs`).
So extending the chips was verified-safe, not a guess.

Generalized the gate in 3 places (`rollOneHit`, and the `dmgCalcChip`/`dmgFinalChip` block in
`renderHero`) from "has `talAdjust(...)`" to "has `talAdjust(...)` OR (is flat-shape AND has
`dmgReplaceDep`/`dmgDep`/`dmgMultDep`/`atkCoeff`)" -- a skill with none of those (still just
`manaVortex` today) still gets nothing, unchanged. For the flat-shape path, the "raw" base value has no
roll-spread of its own (unlike `talAdjustRange`'s TAL/LCK-driven spread -- `sLv` is a rank selection, not
RNG), so it's a degenerate `[X,X]` pair fed through the same `dmgCalcPostFn`; `fmt()` already collapses
that to a single number for display. Real variance still shows up downstream in Final Damage, from
`dmgAdjust`'s attacker-LCK-roll and `defAdjust`'s target-LCK-roll -- both apply identically regardless of
whether the raw value came from `talAdjust` or a flat+dep base, so Final Damage still renders a genuine
range even for a degenerate Raw Damage. `dmgDep.calc`'s signature gained a 3rd param (`TAL`, alongside
the existing `LV, rank`) since Synchro Mole's bonus needs it and, same as the earlier `rank` addition,
every existing `calc` ignores args it doesn't use -- backward compatible. First (and currently only)
skill to exercise this path is Auto Gyro Gun; every other flat-shape skill without a qualifying dep is
unaffected.

### Follow-up, same day (2026-08-18): the turret has its OWN LCK stat -- Final Damage was rolling against Mole's

User caught this immediately: the Final Damage chip's `dmgAdjust` roll spread (`ceil(0.2×lck)`,
`CharacterControl.cs:20489`) used the tool's global `LCK` input everywhere, including for Auto Gyro Gun --
but `dmgAdjust`'s `lck` is `this.lck`, the ATTACKER's own field, and the attacker for the turret's hit is
the TURRET, not Mole. A `mechanics-researcher` verification pass confirmed the turret's `lck` is a real,
independently-tracked stat, separate from every input this tool otherwise reads: baseline `10×rank`
(`AutoGyroGun.cs:77/92/107/126`, same chained-assignment line that also sets `atk`, so it can never
diverge from the already-modeled ATK figure at baseline), replaced by `0.125×rank×MoleLv`
(`Mole.cs:12187`) when Hidden Turret is active -- **half** the `0.25` coefficient `atk`/`def` get, grouped
instead with `agi`/`vit`/`mag`/`cha`/`tal` at that same `0.125` rate. Also confirmed Synchro Mole's
`deltaAtk`/`deltaDef` calls never touch `lck` at all -- the turret's LCK is unaffected by that dep.

Fixed by computing an `attackerLCK` local (both in `rollOneHit` and the calc-chip block in `renderHero`)
gated on a new `ownLck:true` flag, instead of always reading the global `LCK` input for the `dmgAdjust`
roll specifically -- every other LCK usage (a talAdjust-shaped skill's own roll, `defAdjust`'s
target-side roll) is untouched, since for those the attacker genuinely IS Mole/the player. `dmgReplaceDep`
gained a 2nd coefficient field, `lckCoeff` (0.125, alongside the existing `coeff` 0.25 used for the
ATK-equivalent base) -- same toggle state drives both, since it's the same Hidden Turret passive
overwriting two different stats at two different rates. Only Auto Gyro Gun sets `ownLck`/`lckCoeff` today;
every other skill (all of which model the player as their own attacker) is unaffected by this change --
verified by re-deriving the numbers by hand: at rank 4/LV 100 with Hidden Turret active, the turret's
effective LCK is `floor(0.125×4×100)=50` (spread `[0,10]`), not the default player-LCK input's `128`
(spread `[0,26]`) -- a real, meaningfully different roll ceiling, not a cosmetic difference.

### 2026-08-19: chip grid alignment fix, and Final Damage's row-height regression

Two UI-polish bugs, both user-reported via screenshot/description, both class-agnostic (CSS-only, not
scoped to Penguin/Mole). First Playwright-verified session for `.sk-dmg-row` specifically (`getBoundingClientRect`
measurements, not guesses) -- worth using this method again for any future chip-geometry complaint in
this tool, it settled both bugs in a couple of round trips instead of several guess-and-check passes.

**1. `.sk-hero-stats`/`.sk-dmg-row` didn't actually share column boundaries.** User: Cast Time's right
edge (row 1, 2nd of 4 equal columns) didn't line up with Damage Formula's right edge (row 2, nominally
"50%"), even though both are notionally half the card. Root cause: two independently-computed "50%"s from
two different grid formulas aren't the same pixel value. `.sk-hero-stats` is `repeat(4, 1fr)` with 3
internal 12px gaps -- its first 2 columns combined = 2 tracks + 1 gap. `.sk-dmg-row` was `2fr 1fr 1fr` with
only 2 gaps total -- its 2fr column = 2 tracks + 0 internal gaps. Those differ by exactly half a gap (6px),
a structural mismatch, not a rounding error. Fixed by giving `.sk-dmg-row` the SAME `repeat(4, 1fr)` track
definition as `.sk-hero-stats`, with `.sk-dmg-formula{grid-column:1 / span 2}` (was `grid-column:1`),
`.sk-dmg-calc{grid-column:3}` (was `2`), `.sk-dmg-final{grid-column:4}` (was `3`) -- both rows now share
literal grid lines, so Damage Formula's right edge IS Cast Time's right edge by construction. Verified via
`getBoundingClientRect`: `Math.abs(castTime.right - formula.right)` is sub-pixel (~0.00005px, floating-point
noise, not a real gap). The Ice Shield shield-formula variant (reuses the same classes, no 3rd/4th chip)
was re-checked too -- still aligns, still leaves its 3rd/4th slot blank, unaffected by the column-pin change.

**2. Picking a Final Damage target grew the WHOLE 2nd row's height.** User: "the chip height should never
change from interacting with the tool" (a standing rule already documented at length in the min-height
history above) -- but `.sk-dmg-final` only had `.sk-stat`'s shared 108px floor, which fits its "no target"
state (head + enemy-btns + a one-line hint, ~92px) but not its "target picked" state (head + enemy-btns +
the big `[min,max]` value + the Simulate button) -- measured live at 130px, 22px past the floor. Since
every chip in `.sk-dmg-row` shares one grid row track (default `align-items:stretch`), Final Damage growing
past 108px stretched Damage Formula and Raw Damage right along with it on every click -- confirmed via
`getBoundingClientRect` before the fix (108px -> 130px on enemy-button click, both the row and the
unrelated Formula chip). Fixed with `min-height:134px` (130px measured + a small buffer) added directly to
`.sk-dmg-final`, reserving the tall state's height unconditionally -- the empty/hint state now just has
blank space below it, the same "reserve max, leave blank when absent" pattern already used for
`.sk-hero-stats`' empty 4th column. Re-verified live: row height is now a constant 130px (108px floor +
CSS `.sk-stat` border, from the 134px min-height) whether or not a target's picked, across 2 skills
(Falling Stars, Mana Missile) and all 3 enemy presets, including re-clicking the same preset (a re-roll,
not a fresh selection). Ice Shield (no Final Damage chip at all) correctly stays at the original 108px --
this fix is scoped to `.sk-dmg-final` alone, not the shared `.sk-dmg`/`.sk-stat` floor.

### 2026-08-19, same day: Raw Damage top-align, Damage Formula redesigned to substituted "hero numbers"

Three more user-requested changes, same session as the alignment/row-height fixes above.

**1. Raw Damage top-aligned, matching Damage Formula.** `.sk-dmg-calc` inherited `.sk-stat`'s
`justify-content:center` (vertically centers label+value as a block), while Damage Formula's own header
was already pinned to the top (11th follow-up pass, above). Fixed with a one-line override,
`.sk-dmg-calc{justify-content:flex-start}` -- scoped to Raw Damage only, Cooldown/Cast Time/Duration/Final
Damage all keep the original centered layout, unchanged.

**2. Damage Formula chip redesigned: substituted "hero numbers" per term, not one symbolic sentence.**
User: the chip used to render one long inline formula string with bare coefficients (e.g.
`(30 + 0.6TAL) x 0.01INT`) -- now each additive term renders as its own big, colored, LIVE-substituted
number (same visual weight as Raw Damage's own value), with the original symbolic coefficient shrunk to a
small `(0.75ATK)`-style caption underneath -- omitted entirely for a term with no live stat plugged into
it (the flat talAdjust base literal). Term order is now base, then ATK (if any), then TAL, then any
additive Class C dep term -- was ATK-first before this pass. Worked example verified live via Playwright
(Mega Hammer rank 2, Mole, ATK/TAL=100, Mega Drill toggled on -- its default state): formula renders
exactly `36 + 75 + 72` (75 red/`--stat-atk`, 72 cyan/`--stat-tal`, matching the user's own spec number-for-
number), with `(0.75ATK)`/`(0.72TAL)` captions and nothing under the base `36`.
- New `renderTerms(terms)` helper inside `renderDmgFormula` builds a `<div class="dmg-term-group">` of
  `.dmg-term` blocks (`{value, sub, cls}` each) joined by explicit `<span class="dmg-op">+</span>`
  elements -- NOT bare `" + "` text nodes, specifically so `.dmg-term-group` can safely be
  `display:flex` without reopening the exact whitespace-collapse bug already hit once on
  `.sk-dmg-value` itself (12th follow-up pass, "66+1.32TAL" losing its spaces). `.sk-dmg-value` itself
  stays a plain block container, unchanged -- the new flex scope is deliberately its own child class so
  the two formula shapes NOT touched by this redesign (Ice Shield's `renderShieldFormula`, and the
  opaque-text fallback for skills like novaFlare) keep rendering as one inline text run without risk of
  the same bug recurring there.
- Each term's big number is `Math.trunc`ed (matching how every other computed damage figure in this tool
  -- Raw/Final Damage -- is always an int) while its small caption keeps the existing `fmtCoeff`-formatted
  coefficient text (decimal, untouched).
- **focusIntellect's multiplier is now folded directly into each term's live value** (multiply, same
  "distribute across every term, no separate marker" choice `dmgMultDep` already used since 2026-08-18),
  instead of the old outer `(...) × 0.01INT` bracket wrap. This incidentally fixes a latent ordering bug:
  the OLD symbolic display excluded the ATK term from the focus multiply entirely, but the REAL computed
  pipeline (`dmgCalcPostFn`, used for Raw/Final Damage) always included it (`val += atkCoeff*ATK` happens
  BEFORE the `×0.01INT` step there) -- never actually exercised by any real skill (Mole has `atkCoeff`,
  Penguin has `dmgFocusIntellect`, no skill has both), but the new fold is now consistent with the real
  pipeline either way.
- Verified live across every real formula shape in the data, not just the worked example: Falling Stars
  (TAL-only + `dmgMultDep`), Mana Missile (TAL + `dmgFocusIntellect` + additive `dmgDep`), TNT (TAL +
  rank-dependent `dmgDep` whose own term text already carries internal parens, `((0.1×4+0.1)LV)` --
  double-parenthesized but not wrong, a deliberately accepted minor cosmetic quirk rather than added
  special-casing for one skill), and Auto Gyro Gun (flat `dmgReplaceDep` base -- now correctly gets ITS
  OWN caption too, `(1LV)`, since it substitutes a real live LV value unlike a bare flat literal -- plus
  its `dmgDep` TAL term in the `dmg-tal` color). Zero console errors across all four. `renderShieldFormula`
  (Ice Shield) reconfirmed untouched -- still the old inline-sentence style, out of scope for this pass.

**3. Menu ledger: Skill Cooldown/Duration widened to a full first row, renamed, tag removed.**
Reordered to the front of `TOOLS` and given a new `wide:true` field; `toolGrid`'s render template reads it
to add an `entry-wide` CLASS TO THE `<li>` (grid item), not the nested `<a>` -- caught live via Playwright
on the first attempt (class landed on `<a class="entry entry-wide">` per the original edit, had zero
visual effect since `<a>` isn't the actual CSS grid item, `<li>` is; `.entry-wide{grid-column:1/-1}` only
does anything on the element the grid itself is placing). Title changed "Skill Cooldown / Duration" ->
"12 Tails Skill"; `category` set to `""` and the render template's `.entry-tag` span is now only emitted
when `category` is truthy -- this ONE entry has no tag line, every other entry (`Calculator`/`Map`) is
unaffected and still shows its real taxonomy tag per this doc's own "category tag is not decoration" rule
above, which still holds for every entry except this explicit, user-requested exception.

### 2026-08-19, same day (immediate follow-up): the focusIntellect fold from the pass above was reverted

User caught this fast, same session: "why would you combine the INT term for focusIntellect into the
other terms, they are dependent on INT, so you shouldn't do that, use the same old bracket." The pass
above's decision to fold `×0.01INT` silently into each term's own value (same "distribute, no marker"
treatment as `dmgMultDep`) was wrong for this specific multiplier -- base and TAL only become their real,
final contribution once multiplied together by INT, so showing each as an already-final big number hid
that dependency. `dmgMultDep`'s own fold is UNCHANGED (still silent, still correct there) -- this reversal
is specific to focusIntellect, not a general policy change.

Reverted to the OLD bracket structure -- `(base + TAL) × 0.01INT`, exactly the pre-2026-08-19 shape --
just rebuilt from the new big-number term blocks instead of one inline text run: base and TAL keep their
PRE-focus substituted values and captions, wrapped in literal `(` `)` operator spans plus a literal
`<span class="dmg-int">0.01INT</span>` (kept as symbolic text, NOT substituted into a number -- an
implementation slip caught and fixed in the same pass, before this ever shipped: an early draft ran
`0.01×INT` through the same `term()` helper as everything else, which truncated it into a bare integer
and dropped the "INT" label entirely). ATK (Mole-only, never combined with focusIntellect by any real
skill today) sits outside/before the bracket when focus IS active, matching the historical behavior
exactly -- but a 2nd bug was caught immediately after that: the fix's first draft used one shared
"prepend ATK before everything" branch for BOTH the focus and non-focus cases, which silently un-did the
"base, ATK, TAL" order fixed earlier THIS SAME SESSION for the non-focus (Mole) case -- Mega Hammer
regressed to `96(0.75ATK) + 36 + 92(0.72TAL)` (ATK-first again) before this was caught via a live
Playwright re-check. Fixed by branching the ATK term's position explicitly per case: appended between
base and TAL for the plain (non-focus) row, prepended before the whole bracket for the focus row.
Re-verified live after both fixes: Mega Hammer -> `36 + 96(0.75ATK) + 92(0.72TAL)` (order correct, no
bracket, matches the non-focus worked example from the pass above); Mana Missile with focus toggled ON ->
`(24 + 61(0.48TAL)) × 0.01INT + 10(0.1LV)` (bracket restored, dep term still appended after); same skill
with focus toggled OFF -> `24 + 61(0.48TAL) + 10(0.1LV)` (plain, no bracket, correctly reactive to the
toggle). Zero console errors throughout.

**Immediate same-day follow-up**: user caught one more gap in the bracket restoration -- the multiplier
itself, `0.01INT`, was left as literal unsubstituted text (`<span class="dmg-int">0.01INT</span>`,
unchanged from the pre-2026-08-19 design) instead of getting the same live-substitution treatment as
every other term in this redesign. Fixed: it's now its own `.dmg-term` too --
`` `<span class="dmg-int">${fmtCoeff(0.01*INT)}</span><span class="dmg-term-sub">(0.01INT)</span>` `` --
big substituted number with the symbolic coefficient as a small caption underneath, matching ATK/TAL's
visual pattern exactly. Deliberately uses `fmtCoeff` (decimal-preserving), not `Math.trunc` like every
other term's big number -- this one is a RATIO applied to the bracket group's sum, not a truncated damage
contribution of its own, so integer-truncating it (e.g. showing "1" for a true 1.28× at the default
INT=128) would misrepresent the actual multiply happening just to its left. Verified live: INT=200 ->
`(24 + 61(0.48TAL)) × 2(0.01INT) + 10(0.1LV)`, matching the user's own worked number exactly.

**2nd same-day follow-up: term layout rebuilt on CSS Grid instead of nested flex, per direct user
correction.** User: "the spacing of the hero number... is inconsistent due to the caption below each
term... the spacing on top should be consistent." First response was to chase this empirically (measured
`getBoundingClientRect` on every term's number span across 5 skills, drew literal debug overlay lines on a
live screenshot) -- every measurement came back perfectly aligned already, which the user correctly
called out as overcomplicating the actual fix: "why don't just render the hero number normally,
independent of the small formula text below, then render the formula text below later." The real
complaint wasn't that anything was visibly broken in THIS build -- it was that the previous structure (one
`display:flex; flex-direction:column` box PER TERM, each independently top-aligned in an outer flex row)
only produced consistent spacing by every box HAPPENING to agree, not because the structure made it
impossible for them to disagree.

Rebuilt `buildFormulaGrid` (replacing the old `term()`/`renderTerms` pair) around a genuinely different
data shape: instead of returning pre-built HTML strings, both the `talMatch` and flat-shape branches now
build a flat array of **item descriptors** -- `{op:"+"}` for a bare operator glyph or `{value, sub, cls,
raw}` for a substituted term -- and hand the whole array to one shared grid-building function. That
function lays every item into a CSS Grid (`.dmg-term-group{display:grid; grid-auto-flow:column}`) with 2
EXPLICIT rows: every big number and every operator goes in row 1 (via an inline `grid-row:1` set per
element in JS), every caption goes in row 2 (`grid-row:2`), sharing its term's own `grid-column` index so
it still lands directly under the right number. Row 1's height can now only ever be driven by row-1
content -- always a single line of big-number text -- so a caption-bearing column literally cannot pull
row 1 down, and a caption-less column cannot leave it looking short; there's no per-term box left to
independently agree or disagree on a top edge. `.dmg-term` (the old flex-column wrapper class) is gone
entirely -- its one remaining live reference, the pre-existing `.dmg-term{color:var(--text)}` COLOR rule
used as a generic dep-term class (e.g. TNT's `superTNT5`), is unaffected, since that rule now just colors
the bare `<span>` `buildFormulaGrid` places directly into the grid instead of a wrapper div. `.dmg-term-sub`
lost its own `margin-top` in favor of the grid's shared `row-gap:2px`, so the row1-row2 gap can't drift
per-column either. `flex-wrap:nowrap`'s old job (stopping the shrink-loop's overflow check from being
silently defeated by wrapping) needed no replacement -- CSS Grid's `grid-auto-flow:column` has no wrapping
behavior to begin with; an overflowing row just grows `scrollWidth` past `clientWidth` directly, which is
exactly what the existing shrink loop already watches for.

Re-verified live across the same 5 skills as the pass above (Mega Hammer, Auto Gyro Gun, Falling Stars,
Mana Missile, TNT) plus the focusIntellect bracket case: every row-1 cell across every skill now lands at
the identical measured Y (510px in the test viewport) -- not a coincidence to re-verify each time
something nearby changes, but a structural guarantee from here on. Zero console errors.

**3rd same-day follow-up: dep-icon presence shifting the whole formula, then Raw Damage/Shield HP brought
into the same alignment.** User: "normalize every skill to as if it has a skillDep icon, I dislike when
changing between skills with depSkill and none causes the text and formula to shift." Root cause:
`.sk-dmg-toggles` (holds Damage Formula's focus/dep toggle icons, `.sk-dep-toggle img` fixed at 28x28px)
has no height of its own when a skill has ZERO toggles -- `dmgToggles.join("")` is just `""`, so
`<div class="sk-dmg-toggles"></div>` collapses to 0 natural content height. Since `.sk-dmg-head{align-
items:center}`'s own height is driven by its tallest child, a toggle-bearing skill's header was ~28px
while a toggle-less skill's header was only as tall as the label row (~14-18px) -- and since
`.dmg-term-group` sits right below the header in normal block flow, that height difference directly
shifted where the big numbers started. Fixed with one line, `.sk-dmg-toggles{min-height:28px}` --
reserves the icon's own height unconditionally, empty or not. Verified live: Mega Hammer (1 toggle,
Mega Drill) and Mortar Shot (0 toggles at all) now both put their first row-1 number at the identical
measured Y. Applies to Ice Shield's `shieldToggles` too, free, since it reuses the same class.

**Immediate same-message follow-up**: user also asked Raw Damage's header/number to align with Damage
Formula's, now that the header-height fix above made Damage Formula's own header a fixed, taller 28px
(previously it could be shorter when toggle-less, coincidentally closer to Raw Damage's own bare-label
header -- fixing the FIRST issue exposed this second one). Fixed by having Raw Damage's chip reuse the
exact same `.sk-dmg-head`/`.sk-dmg-label-row`/`.sk-dmg-toggles` (empty) markup Damage Formula's header
uses, instead of a bare `<p class="sk-stat-label">` -- same "identical structure guarantees identical
height" principle as the fix above, not a second independently-tuned margin value trying to approximate
it. A 2nd, subtler gap remained even with matching container heights: `.sk-stat-value`'s shared
`line-height:1` sits tighter than `.sk-dmg-value`'s `line-height:1.2` (which every `.dmg-term-group`
number inherits), so a same-top-Y container still centered its glyph a few px higher with less
half-leading above it -- fixed with a scoped `.sk-dmg-calc .sk-stat-value{line-height:1.2}` override
(NOT changing the shared `.sk-stat-value` rule itself, which Cooldown/Cast Time/Duration/Final Damage all
still use unmodified). Shield HP got the identical header-reuse treatment for the same reason, even
though it wasn't named explicitly -- it pairs with Shield Formula the same way Raw Damage pairs with
Damage Formula. Verified live: Raw Damage's number and Damage Formula's numbers now land at the exact
same measured Y (510.3px), and both chips' headers do too (476.3px), across both a toggle-bearing and a
toggle-less skill. Zero console errors.

**4th same-day follow-up: Final Damage brought into the same alignment, Carron defaulted, enemy/Test
controls relocated.** User: default-select Carron (was unselected, "Pick a target" on first load), align
Final Damage's own heading and hero number with the other two chips, and "figure out a better placement
for enemy icons and test button" since they used to sit BETWEEN the header and the range value -- the
exact gap that needed to close for alignment.

- `selectedEnemyId` now initializes to `"carron"` instead of `null` -- every skill's Final Damage chip
  shows a real range on first load now, matching Damage Formula/Raw Damage's own always-on hero numbers.
  Never reset elsewhere (same standing-state precedent as `activePlayerMods`/`activeEnemyMods`), so this
  is a one-line default-value change, not a new reset-on-switch mechanism.
- Final Damage's header now reuses `.sk-dmg-head`/`.sk-dmg-label-row`/`.sk-dmg-toggles` verbatim (dropped
  the bespoke `.sk-dmg-final-head` class entirely) -- "Mods" sits in the toggles slot exactly where a real
  dep-toggle icon would on Damage Formula, same "identical structure guarantees identical height" fix as
  Raw Damage/Shield HP above. One addition specific to this chip: `.sk-dmg-final .sk-dmg-head{width:100%}`
  -- `.sk-dmg-final` is the one chip that centers its own children (`align-items:center`), so a block-level
  header child would otherwise shrink to its own content width instead of the chip's full width.
- Enemy icon buttons + the Simulate("Test") button moved OUT from between the header and the range value,
  into a NEW `.sk-dmg-final-controls` row positioned AFTER the value instead -- so nothing sits between the
  header and the number on any of the 3 chips now, matching Damage Formula/Raw Damage's own "value
  immediately follows header" structure. `simulateBtn` had to be hoisted to a `let` declared before the
  `if (selectedEnemy)` block (was a `const` scoped inside it) so the controls row outside that block can
  still reference it, conditionally empty when no target's picked.
- `.sk-dmg-final .sk-stat-value{line-height:1.2}` added to the same shared selector Raw Damage's own fix
  used (now `.sk-dmg-calc .sk-stat-value, .sk-dmg-final .sk-stat-value`) -- same reasoning, the shared
  `.sk-stat-value{line-height:1}` sits tighter than `.dmg-term-group`'s inherited 1.2, so even identical
  container tops wouldn't have put the GLYPHS on the same line without this.
- **A real bug caught mid-verification, not just a missing rule**: after the above, Final Damage's number
  still measured ~2.2px lower than the other two chips' -- traced to `.sk-dmg-final` never having its own
  `justify-content` override, so it was inheriting `.sk-stat`'s CENTERED `justify-content` this whole time
  (Damage Formula/Raw Damage are both `flex-start`, i.e. pinned to the top). Harmless before this pass,
  since this chip's old content (header + enemy row + number + button, closer to filling the full 134px
  box) centered to nearly the same spot flex-start would have pinned it to anyway -- became a real,
  measurable gap once the content got shorter (enemy row moved out) and needed to match an EXACT Y, not
  just a visually-close one. Fixed with one more line, `.sk-dmg-final{justify-content:flex-start}`.
- **Process note**: the first live re-check after the `justify-content` fix still showed the old ~2.2px
  gap and `getComputedStyle` reporting `"center"` even though `curl`ing the server directly confirmed the
  file WAS serving `flex-start` -- a stale HTTP cache in the plain Node test server (no cache-control
  headers set), not a real bug. Resolved by disabling the browser's cache via a CDP session
  (`Network.setCacheDisabled`) before reloading. Worth remembering for any future local-server
  verification session in this project -- don't trust a "still broken" re-check without first ruling out
  a stale cache when the served file itself has already been confirmed correct.
- Verified live (cache-disabled): all 3 headers land at the same measured Y (477.5px) and all 3 hero
  numbers do too (511.5px), across Mega Hammer (toggle-bearing), Mortar Shot (toggle-less), and Auto Gyro
  Gun -- plus Carron confirmed pre-selected on every one of them. Clicking a different enemy preset,
  clicking Test/Simulate, and opening the Mods popup were all re-verified still working after the
  restructure; Ice Shield's Shield HP chip (same underlying classes, no Final Damage chip at all)
  reconfirmed unaffected. Zero console errors throughout.

**5th same-day follow-up: Raw Damage's number centered.** User: "Raw Damage hero number center of the
chip please." One-line fix, `.sk-dmg-calc .sk-stat-value{text-align:center}` -- `.sk-stat-value` is
already full-width inside `.sk-dmg-calc` (the existing flex-stretch default), so `text-align` alone
centers the number without any other layout change. Scoped to the number only, not the "Raw Damage" label
above it -- the label stays left-aligned, still matching Damage Formula's own left-aligned header. Final
Damage's number was already centered (its own `.sk-dmg-final{align-items:center; text-align:center}`),
so this brings Raw Damage in line with it rather than introducing a new convention.

**6th same-day follow-up: menu icon swapped to a star.** User: "12tails skills use Star icon instead for
the main menu." The entry's `icon` field (`TOOLS`, the `skill-cooldown-lookup` object) changed from the
original cooldown-clock glyph to a Feather-style star polygon
(`12 2 15.09 8.26 22 9.27 17 14.14 18.18 21.02 12 17.77 5.82 21.02 7 14.14 2 9.27 8.91 8.26 12 2`) --
same outline-stroke convention as every other menu icon here (`fill:none; stroke-width:2;
stroke-linecap/linejoin:round`), just a different shape. The clock predated this entry's "featured"
widen/rename/de-tag pass and no longer matched what the tool actually covers (Cooldown/Cast Time/
Duration/Damage, not just cooldown timing).

**Published to the live Artifact, same session** (first publish since this whole day's work began --
the previously-live version predated every fix in this file's 2026-08-19 entries, so this was a
straightforward forward update, not a merge; `WebFetch`-confirmed the live page still had the OLD
`.sk-dmg-row{grid-template-columns:2fr 1fr 1fr}` and no `dmg-term-group` before publishing). Same
Artifact URL (`https://claude.ai/code/artifact/5f024957-09df-4f7c-b4d6-c9f38823e7c8`), same 🦊 favicon,
via the `publish-player-reference-tool` skill. A 2nd publish followed immediately after for this star-icon
change alone.

**7th same-day follow-up: every skill card forced to the same height, even skills with no 2nd row at
all.** User: "I want every skill card to be uniform, whether they have the 2nd row or not... I dislike
when I move between skills and the skill card position shifted... Make sure all skills in the app has the
same skill card layout!" Before this pass, `.sk-dmg-row`'s rendered height already varied 3 ways
depending on the selected skill's shape, none of which the earlier alignment passes this session had
addressed (those were all about content WITHIN a row lining up, not whether the row itself was a
consistent height across different skills):
- A `dmg`-bearing skill: 134px (via `.sk-dmg-final`'s own reserved min-height, fixed earlier this session).
- A `shield`-bearing skill (Ice Shield only, currently): only 108px -- no Final-Damage-equivalent 3rd chip
  ever forces the extra height the way `.sk-dmg-final` does for damage skills.
- A skill with NEITHER (buffs, heals, summons, KO-only skills, e.g. Mole's `reload`/`bunker`/
  `synchroMole`): 0px -- `renderHero`'s `dmgBlock` stayed `""`, so no `.sk-dmg-row` rendered at all.

Fixed with 2 small changes working together, not a per-branch rewrite:
1. `.sk-dmg-row{min-height:134px}` -- a floor on the ROW CONTAINER itself (not any one chip inside it).
   For damage skills this is a no-op (already 134px). For shield skills, the row's 2 chips now stretch
   to fill 134px via the existing `align-items:stretch` grid default -- the same mechanism that already
   stretches Damage Formula/Raw Damage today when Final Damage forces the row taller, just now also
   triggered by the CONTAINER's own min-height instead of only by a tall sibling chip.
2. A new `else` branch in `renderHero`'s dmg/shield conditional: `dmgBlock =
   '<div class="sk-dmg-row"></div>'` -- an EMPTY row, no chips inside, for the neither-dmg-nor-shield
   case. A childless block element still respects its own `min-height` regardless of grid/flex context,
   so this alone reserves the full 134px as genuinely blank space -- no visible border or box, "just a
   blank area" per the user's own framing, not an empty-looking chip.

Verified live: `.sk-hero`'s total `getBoundingClientRect().height` (355.6px) is now IDENTICAL across
Mega Hammer (damage), Ice Shield (shield), Reload (neither), Falling Stars, Auto Gyro Gun, Bunker, TNT,
and Synchro Mole -- 8 skills spanning every shape and several different stat-row combinations (with/
without Cast Time, with/without Duration). Zero console errors. Published to the same Artifact URL, same
🦊 favicon, via `publish-player-reference-tool`.

### 2026-08-19, later same day: Mine Lover wired to Landmine's/Stun Mine's Cooldown, linked to the existing damage-side toggle

User asked to check whether Landmine and Stun Mine's Cooldown genuinely depends on Mine Lover
(`mineLover5`, already modeled as a `dmgMultDep` on Landmine's DAMAGE side, ×1.25), and if so wire it up
"same logic as bless skill" (Sheep's `cdDep`, the existing Cooldown-chip-corner dependency mechanism) --
plus a new general rule: whenever the SAME dep icon appears in both the Cooldown chip and the Damage
Formula chip, toggling either one should affect the other.

**Research (no new source reading needed -- already fully answered in the existing reference docs from a
prior session):** `12t_reference/mole-skill-reference.md`'s own `mine`/`stunMine` note already
had the citations: `Mole.cs:23891-23905` --
`hasSkill(402) ? addTimeOut("mine", agiAdjust(8)) : addTimeOut("mine", agiAdjust(15))` -- and
`Mole.cs:26680-26694`, identical pattern for `stunMine`, base 45 -> 23. `402 = mineLover5`, confirmed via
`MoleSkill.cs`'s `getSkillTree` mapping in `mole-skill-damage-reference.md` -- the SAME passive already
driving the damage-side `dmgMultDep`, not a same-named-but-different one. Neither reduction is a clean
"half" (8 vs true-half 7.5; 23 vs true-half 22.5) -- Mine Lover REPLACES the raw pre-`agiAdjust` cooldown
with a hardcoded literal, it doesn't offset (`perRank`, Bless's Gospel shape) or scale it
(`postMultiply`). Also surfaced in the same sweep: Stun Mine's own KO value (not modeled anywhere in this
tool -- no `dmg` field, no KO schema) is ALSO ×1.25 by Mine Lover, per the damage-reference doc's own note
-- not wired up, since there's nothing in the tool's schema to attach it to.

**New "replace" `cdDep`/`dep` kind**, alongside the existing `perRank` (additive) and `postMultiply`
shapes in `depRawValue`: `{kind:"replace", replaceValue:N}` returns `N` when the dep's at `maxRank`,
the untouched base value otherwise -- same shape as the damage side's `dmgReplaceDep` (Auto Gyro Gun's
Hidden Turret), just for a cooldown's raw value instead of a damage formula's base term. `mole_mine` gets
`cdDep:{id:"mineLover", ..., kind:"replace", replaceValue:8}`; `mole_stunMine` gets the same shape with
`replaceValue:23`. Deliberately reuses `id:"mineLover"` -- the SAME id Landmine's existing `dmgMultDep`
already uses.

**The chip-to-chip (and, as a natural consequence, skill-to-skill) linking the user asked for needed NO
new plumbing at all.** `getDepRank(dep)` was already keyed by `dep.id` in one shared `depRanks` object
(pre-existing, serving `dep`/`cdDep` uniformly), and `renderDepBlock` (Cooldown corner)/`renderDmgToggle`
(Damage Formula header) already emit IDENTICAL markup for a 0/1-rank dep --
`class="sk-dep-toggle" data-dep-id="..."` -- picked up by ONE generic click listener
(`$$(".sk-dep-toggle", displayEl)`) that flips `depRanks[id]` and calls `renderHero()` regardless of
which specific button was clicked. Giving Landmine's `cdDep` the same `id` its existing `dmgMultDep`
already used was the entire fix -- clicking EITHER icon now updates both, and since `depRanks` isn't
reset on skill switch, toggling it while looking at Landmine correctly carries over to Stun Mine's own
Cooldown chip too (and back), not just within one skill's card.

Verified live: Landmine's Cooldown corner icon and Damage Formula header icon both start "on" (base 8s,
`62 + 160(1.25TAL)`); clicking the Cooldown chip's icon flips BOTH icons to "off" in one render (base
15s, `50 + 128(1TAL)` -- the ×1.25 mult correctly dropped out of the damage formula too, not just the
cooldown). Switching to Stun Mine without touching anything shows it already reflecting the "off" state
(base 45s); clicking Stun Mine's own icon flips it back "on" (base 23s). Zero console errors throughout.

### 2026-08-19, later same day: new "KO chip" -- 27-skill Penguin sweep + Mole consolidation, `getKOValue`

User asked to "find out the damage for Stun Mine and Stun Grenade" and "find out if flame turret can
ignore enemy defense" (both pure research, answered via a `mechanics-researcher` dispatch -- Stun Mine/
Stun Grenade confirmed genuinely 0 real damage, pure KO, matching the existing doc; Flame Turret confirmed
penetrating, same mechanism as `napalm`, direct `RPC_AddDamage` bypassing `hit()`'s `defAdjust` step
entirely). One new finding surfaced along the way and recorded in `mole-skill-damage-reference.md`: Stun
Grenade gets a HIDDEN real-damage path (+30 flat, `Mole_stunGrenade.cs:285`) when the caster also has
Smart Shell and hits a genuine enemy -- not modeled in the tool (Smart Shell is excluded everywhere as
"too conditional," consistent with existing precedent). Also corrected a stale citation: the existing doc
had `mineLover5`'s ×1.25 KO mult on `stunMine` mis-cited at the COOLDOWN-check line range
(`Mole.cs:26680-26694`) instead of its real location inside `RPC_stunMine_hit` (`Mole.cs:11092-11103`).

**Immediately followed by a UI feature request from a screenshot**: a hand-drawn red box on Absolute
Zero's Damage Formula chip marking where a "small KO chip" should go, plus 2 placement rules -- always
show it (even at 0) when a real Damage Formula exists, only show it (and only if nonzero) when one
doesn't -- and "you might have to work backward to penguin skills too."

**Research, dispatched before any code**: a 2nd `mechanics-researcher` call, scoped tightly to answer 3
things before touching `index.html`: (1) `hit()`'s exact parameter signature, to stop guessing which
positional argument is really "KO" -- confirmed as a literal `nKo` parameter, 4th position, identical
across all 3 damage-application entry points (`hit()` `CharacterControl.cs:2807`, `RPC_AddDamage`
`:3680`, `RPC_AddEffectDamage` `:6058`); (2) an exhaustive sweep of all 27 Penguin skills already in this
tool's `SKILLS` array for a nonzero `nKo` -- only 4 have one: `manaMissile`/`frozenBlast`/`arcticWind`
(flat 1, per-hit) and `absoluteZero` (`10×sLv`) -- notably NONE of the ice-shield/freeze-flavored skills
one might expect (`iceShield`, `iceBlock`, `frozenBlast`'s own KO is flat-1 not freeze-scaled, `blizzard`,
`arcticEmperor`) actually carry a KO despite the flavor text; (3) 6 named Mole skills (the 2 already known
plus 4 more worth checking): `mine` (flat 1), `grenadeCluster` (flat 10, its OWN explosion -- separate
from the +1-rank bonus it GRANTS `stunMine`/`stunGrenade`), `stunMine`/`stunGrenade` (both `10×sLv`, +1
effective rank each from `grenadeCluster5`, `stunMine` ALSO ×1.25 from `mineLover` -- `stunGrenade` does
NOT get the `mineLover` mult, confirmed not just assumed), `timeNuke` (flat 3), `chopper` (flat 1);
`napalm` explicitly checked and confirmed to have none.

**New schema, additive only (no existing field touched)**: `skill.ko` -- a plain `sLv`-substituted
arithmetic string, same convention as flat-shape `dmg`, evaluated via the existing `evalArith`. Unlike
every damage value in this tool, no source KO figure found in this sweep was ever wrapped in an *Adjust
function (`talAdjust`/`agiAdjust`/etc.) -- there's no LCK-roll spread to model, `getKOValue(skill, rank)`
(new top-level function, beside `depRawValue`) just returns one deterministic number. Two new optional dep
fields, both reusing the EXISTING `getDepRank`/`renderDmgToggle` machinery (no new toggle mechanism
needed): `koDep` (`{..., rankBonus:N}`) shifts the EFFECTIVE rank fed into the `ko` formula itself before
evaluation -- matches source exactly, `grenadeCluster5`'s real bonus is `10×(sLv+1)`, an extra point of
RANK, not a separate additive term outside the multiply, so `dmgDep`'s append-a-term shape would have been
the wrong fit; `koMultDep` (`{..., mult:N}`) mirrors `dmgMultDep` exactly, `Math.floor(value*mult)`.

**UI: 2 placements for the same value, picked by whether a real Damage Formula chip exists to nest
inside** -- not 2 different chip designs, one shared `getKOValue` computation feeding both:
- `.sk-ko-badge` -- a small `position:absolute` label+number in `.sk-dmg-formula`'s own bottom-left corner
  (that chip gained `position:relative` as its containing block) when `selected.dmg` exists, unconditionally
  (`getKOValue(...) ?? 0`, so a damage skill with no real KO still shows "KO 0" per the user's own rule).
  Exactly where the user's own red-box screenshot marked it.
- `.sk-ko-standalone` -- reuses the `.sk-stat` chip class directly (not a bespoke smaller box -- every
  other chip in this tool already reads as appropriately "small," reusing that established visual language
  was more consistent than inventing a new size), taking Raw Damage's usual `grid-column:1` slot, only when
  `selected.dmg` is absent AND `getKOValue(...)` is truthy (nonzero and non-null) -- currently only
  `stunMine`/`stunGrenade` reach this path; every other buff/heal/summon skill still gets the fully blank
  row from the previous pass, unaffected. `koDep`/`koMultDep` toggle icons (scaled to 16px, half
  `.sk-dep-toggle`'s normal 28px -- this is deliberately the "small" chip) render in this box's own
  top-right corner via `.sk-ko-standalone-toggles`, since a pure-KO skill has no OTHER chip for them to
  live on the way `mineLover`'s toggle already does on Landmine's Cooldown/Damage-Formula chips.

**The chip-to-chip linking already established for `mineLover` (Cooldown ↔ Damage Formula) extends to KO
for free, same reason as before**: `stunMine`'s `koMultDep` reuses `id:"mineLover"`, so its icon is a 3RD
linked instance of the exact same toggle, alongside its existing `cdDep`. Verified live: toggling
`mineLover` OFF from Stun Mine's own KO chip icon correctly dropped its KO from 37→30 (`10×(2+1)`, mult
removed) AND flipped Stun Mine's Cooldown chip to "base 45s" in the same render -- one shared toggle now
driving 2 different stat chips on the same skill, not just 2 chips on 2 different skills like the pass
above. Stun Grenade's own KO chip correctly shows only 1 toggle (`grenadeCluster`, no `mineLover` --
matches the research finding that this mult doesn't apply there). Re-verified the full matrix live:
Absolute Zero's badge (`KO 20` at default rank 2, exact red-box position), Mega Hammer's badge (`KO 0`,
a `dmg`-bearing skill with no real KO field), Reload (still fully blank, card height still 355.6px
identical to every other skill), Ice Shield (shield-only, no KO chip, Shield HP untouched). Zero console
errors throughout.

### 2026-08-19, same day, immediate follow-up: the Mole KO sweep above was incomplete -- 10 more skills found

User: "There's no way Mega Punch and Mega Hammer has 0 KO, investigate what went wrong, and if mistake
caused false negative on other skills too." Correct instinct, and the root cause wasn't a calculation bug
-- it was a **scope gap**. The KO-sweep research pass above asked `mechanics-researcher` about a
hand-picked 6-skill subset (`mine`, `grenadeCluster`, `stunMine`, `stunGrenade`, `timeNuke`, `napalm`,
`chopper`), not the full Mole roster. Mega Punch and Mega Hammer were simply never asked about, so
`getKOValue` correctly returned `null` (no `ko` field exists) -- the UI's `?? 0` fallback then displayed
"KO 0", which reads identically to "verified zero" even though it actually meant "never researched." That
distinction is invisible in the rendered chip, which is exactly why this looked like a bug from the
outside.

**Found via the cheapest possible check, before writing a single new research prompt**: grepping this
tool's OWN existing `dmgNote` text for the substring "KO" turned up 4 skills whose KO value had already
been researched and written down in a PRIOR session, sitting unused because the KO chip didn't exist yet
-- the notes literally said "not shown": `megaPunch` ("KO 5 (Mega Drill also ×1.5 KO, not shown)"),
`megaHammer` ("KO 10×sLv..."), `megaDrill` ("KO 2, not shown"), `warCapital` ("KO 3, not shown"). None of
these had a `file:line` citation, so they were treated as claims to verify, not facts to trust blindly.

**2nd `mechanics-researcher` dispatch, 2 jobs in one**: (1) verify all 4 claimed values against source
with real citations, (2) exhaustively sweep every OTHER Mole skill in this tool's roster that had NEVER
been checked for KO by either pass -- 16 more: `reload`, `mortarShot`, `bunker`, `tnt`, `flameTurret`,
`fireBarrage`, `bombardment`, `detonate`, `barrelBot`, `missile`, `synchroMole`, `kingKaiser`,
`advanceRepair`, `flameCarnival`, `barrelCannon`, `warFactory`. Between the two Mole sweeps, this tool's
ENTIRE Mole roster is now checked (Penguin's 27 already were, first pass).

**All 4 claimed values confirmed exactly correct**: `megaPunch` KO 5 (`Mole.cs:32483`), ×1.5 gated by
`hasSkill(433)`/`megaDrill5` (`Mole.cs:32488-32499`, `Mathf.FloorToInt`); `megaHammer` KO `10×sLv`
(`Mole.cs:33076`), same ×1.5 gate (`:33081-33092`); `megaDrill` KO 2, inline in its own `hit()` call
(`Mole.cs:39586`); `warCapital` KO 3 (`Mole.cs:14658`, inside `RPC_warMissile_hit`, fired by the
8-missile-barrage loop -- confirms the existing `hitCount:()=>8` was already correctly modeling this as
per-missile). Both Mega Punch and Mega Hammer's KO-side multiplier uses the exact SAME ×1.5 as their
already-modeled damage-side `dmgMultDep` -- reused the identical `id:"megaDrill"` for the new `koMultDep`,
so (same mechanism as `mineLover` earlier today) toggling Mega Drill from EITHER the Damage Formula
chip's icon or the new KO badge's icon now flips both together, no new plumbing required.

**6 more genuine nonzero finds from the 16-skill sweep**: `mortarShot` (1, `Mole.cs:10920`), `tnt` (5,
`:26081`), `fireBarrage` (1, `:29259`), `bombardment` (1, `:30383`), `missile` (3, `Mole_missile.cs:354`),
`barrelCannon` (1, `BarrelBot.cs:1889` -- fired by the summoned companion, not Mole's own cast, but the
tool already has no `dmg` field for this skill either so the existing "credit the companion's damage to
the caster's own chip" scope boundary is unaffected, just now extended to KO too; renders via the
standalone-chip path since `barrelCannon` has no Damage Formula). Confirmed genuinely zero (not just
unchecked): `flameTurret`, `flameCarnival`, `warFactory` (all 3 sub-forms). Confirmed no `hit()` call at
all (pure utility/buff/summon, consistent with having no `dmg` field either): `reload`, `bunker`,
`synchroMole`, `kingKaiser`, `advanceRepair`. `detonate` and `barrelBot` are real edge cases, not modeled
by design, matching how their `dmg` side is already handled: `detonate` remote-triggers an
already-placed Time Nuke (its KO already lives on `timeNuke`'s own entry, nothing new to add); `barrelBot`
summons a companion with 5 DIFFERENT KO values across its own separate move-set
(`punch`=5,`hammer`=10×HammerLv,`chopper`=1,`drill`=2,`nAttack`=1, all in `BarrelBot.cs`) -- no single
number applies, and this tool has never modeled a summon's own independent combat kit (no `dmg` field for
`barrelBot` either), so left unmodeled consistently rather than picking one arbitrary number.

Stale `dmgNote` text ("...KO N, not shown") on all 4 corrected skills was also cleaned up now that the
value genuinely IS shown. Verified live: Mega Punch `KO 7`/Mega Hammer `KO 30` at default rank+Mega-Drill-
on (`floor(5×1.5)`/`floor(20×1.5)`), Mega Drill `KO 2`, War Capital `KO 3`, Mortar Shot/Fire Barrage/
Bombardment `KO 1` each, TNT `KO 5`, Missile `KO 3`, Barrel Cannon `KO 1` (standalone chip, no Damage
Formula chip exists for it). Re-verified the Mega Drill link specifically: toggling it off from the KO
badge's own icon dropped Mega Punch's KO 7→5 AND its Damage Formula's `30+96+76`→`20+64+51` in the same
render -- 2 toggle instances now exist for `megaDrill` (Damage Formula header + KO badge), same pattern as
`mineLover`'s 3 instances on Stun Mine. Zero console errors throughout.

**Process lesson for any future per-skill data sweep in this tool**: before dispatching a fresh
`mechanics-researcher` call for a new stat/mechanic, grep this file's own existing `dmgNote`/citation text
for the mechanic's name first -- a prior session may have already found and written down the answer as
prose, with nothing to compute against until the right UI existed. That's exactly what happened here, and
it would have been caught before the user had to, not after, if checked first.

### 2026-08-19, same day: Super TNT collapsed to a flat 0.5LV, then stunMine/stunGrenade given a real `dmg:"0"`

**Super TNT.** User: superTNT5's rank-parameterized term should "collapse to 0.5LV since it is only
upgradable if TNT 4 is upgraded" -- a skill-tree prerequisite (Super TNT requires TNT already at rank 4)
that isn't itself visible in the damage-formula source this tool cites, taken from the user directly.
Since `(0.1×sLv+0.1)` can only ever evaluate at `sLv=4` in any state where this dep is genuinely togglable
in the real game, the previous rank-dependent `term`/`calc` (added the same day, Mole rollout section) was
technically able to display/compute a hypothetical (TNT at some rank <4 with Super TNT already active)
that can't actually occur. `mole_tnt`'s `dmgDep` simplified to the constant it always evaluates to:
`term:"0.5LV", calc:(LV)=>0.5*LV` (dropped the `rank`-taking function form entirely). Verified live: the
displayed term stays `0.5LV` (and the computed value stays anchored to `0.5×LV`) even after cycling TNT's
own rank-selector down to 1 via the tool's UI -- previously that combination would have shown/computed a
different (game-impossible) number.

**stunMine/stunGrenade.** User: disliked the standalone-KO-chip treatment specifically for these two --
"I want the damage formula to be just plain 0, and KO format to be the same as the rest of the skills."
Both skills now carry a real `dmg:"0"` field instead of omitting `dmg` entirely -- accurate, not just
convenient: every `hit()` call in each skill's own coroutine passes a literal `nDamage=0`
(`Mole.cs:11156,11169` for stunMine, `Mole_stunGrenade.cs:259,295` for stunGrenade -- both re-confirmed,
not just carried over), a REAL verified zero, not an absence of data. With a genuine `dmg` field, both
skills now flow through the exact same code path as every other damage skill -- `.sk-ko-badge` nests in
the Damage Formula chip's own bottom-left corner automatically, no special-casing needed, and the
previous `.sk-ko-standalone` chip no longer applies to either. Raw Damage/Final Damage correctly stay
absent (a flat literal "0" has nothing stat-dependent to range against), matching the existing
"blank if not computable" convention rather than fabricating a fake "0-0" range.

**Barrel Cannon deliberately NOT given the same treatment**, despite also lacking a `dmg` field and using
the standalone KO chip -- its damage is dealt by the SUMMONED COMPANION object (`BarrelBot.cs`), not the
Mole-cast coroutine itself (confirmed earlier this session: Mole's own cast only triggers
`RPC_cannonForm`, `Mole.cs:39971-40208`). A `dmg:"0"` here would misrepresent "not modeled by this tool"
as "verified to deal zero damage," which is false -- the companion's hit almost certainly deals real,
nonzero damage this tool just doesn't track. Re-confirmed live after the stunMine/stunGrenade change:
Barrel Cannon still correctly uses `.sk-ko-standalone` (`KO 1`), unaffected.

**User then asked to independently re-verify the mineLover-on-stunMine-KO claim** rather than trust the
earlier agent dispatch at face value -- read `Mole.cs:11075-11174` directly (not delegated) and confirmed
line-by-line: `num = 10*(sLv+(hasSkill(432)?1:0))` (`:11092`) is the exact same variable multiplied by
1.25 and floored when `hasSkill(402)` is true (`:11097-11103`), and THAT variable (not a copy) is passed
as the `nKo` (4th) argument in the real enemy-hit `hit()` call (`:11169`). Cross-checked `hasSkill(402)`'s
identity directly too (`MoleSkill.cs:3297-3301`: `commandNum==402` -> `"mol_mineLover5"`). Confirms the
tool's `koMultDep` on `stunMine` is correct, independently of the earlier research pass.

Verified live (both changes): TNT's formula shows `0.5LV` at every rank; stunMine shows Damage Formula
`0` + a nested KO badge (`KO 25`-`37` depending on toggle/rank state, both `grenadeCluster`/`mineLover`
toggles present) with no Raw/Final Damage chips; stunGrenade shows the same shape with only the
`grenadeCluster` toggle (no `mineLover`, matching the research finding that this mult doesn't apply
there). Zero console errors throughout. Not yet published.

### 2026-08-19, same day: Flame Turret's Final Damage was silently mitigating against enemy DEF, despite being confirmed penetrating

User: "Flame Turret damage sim is not ignoring enemy def, simulate the realistic actual pipeline please."
Real gap, not a misunderstanding -- an EARLIER pass this session (the Stun Mine/Stun Grenade damage
research) had already confirmed Flame Turret's tick damage bypasses `defAdjust` entirely (`Mole.cs:28200`,
direct `RPC_AddDamage` on the target, never through `hit()`), and even wrote that finding into
`mole-skill-damage-reference.md` -- but never actually changed the CALCULATION code. The Final Damage
chip and Simulate button kept running every skill, Flame Turret included, through the same unconditional
`dmgAdjust -> defAdjust -> hitMod` chain, so its Final Damage silently varied with the selected enemy's
DEF exactly as if it weren't penetrating at all -- the citation existed, the fix didn't.

**Re-verified from scratch before touching any code**, not just trusting the earlier citation: read
`Mole.cs:28180-28205` directly (confirms `RPC_AddDamage` called on `$hitChar$`, never `this.mChar.hit`),
read `CharacterControl.cs:2807` fresh for `RPC_AddDamage`'s own body (only applies `hitMod` at `:3765`,
no `defAdjust` call anywhere in it), then ran a WHOLE-FILE grep for `defAdjust` across
`CharacterControl.cs` -- exactly 5 hits total: the function's own declaration (`:20524`), `hit()`'s
automatic call (`:3546`), and 3 OTHER skills (`:9005`, `:10634`, `:38586`) that also bypass `hit()` but
manually re-apply `defAdjust` themselves before calling `RPC_AddDamage` -- a real pattern that means
"skips `hit()`" alone never proves "unmitigated," each site needs checking individually. Flame Turret's
own call site doesn't appear in that list at all, closing the loop: genuinely, exhaustively confirmed
100% unmitigated, not an approximation.

**New `skill.penetrating:true` flag**, checked at the exact 2 places `defAdjust` ever enters this tool's
damage pipeline -- `rollOneHit` (the Simulate/Test roll) and the Final Damage range calc in `renderHero`
-- both now skip straight from `dmgAdjust`'s own output to `hitMod` when set, instead of calling
`defAdjustRoll`/`defAdjustAtN` at all. Scoped as a general reusable flag, not a Flame-Turret-only special
case, even though only Flame Turret uses it today -- Raw Damage was already correct and needed no change
(it's computed entirely before `defAdjust` ever enters the pipeline in the first place, regardless of this
flag). `mole_flameTurret`'s `dmgNote` updated to state the penetrating behavior explicitly instead of
leaving it undocumented at the chip level (only the separate reference doc had it before).

Verified live: Final Damage now reads the exact same range (`59-96`) regardless of which of the 3 enemy
presets is selected -- Carron (DEF 2), Stingdune (DEF 200), and Silverbug (DEF 300) all identical, where
before this fix Silverbug would have shown a visibly smaller range than Carron. Simulate/Test re-verified
still working (rolls a real single hit through the same shortened chain). Zero console errors.

### 2026-08-19, same day, immediate follow-up: the Flame Turret fix above was itself incomplete -- dmgAdjust needed skipping too, and Flame Carnival has the same bug

User: "flame carnival and napalm too right? def ignore" -- checking whether the SAME penetrating
treatment needed to extend further. Investigating this caught a 2nd, more significant bug in the fix from
the pass above, not just confirmed the obvious extension.

**Napalm**: already correctly excluded, no code change needed -- its `dmg` is opaque prose text (`"1st
tick 30 (TAL-scaled), ticks 2-6: 5 each (TAL-scaled)"`), not a parseable `talAdjust(...)` formula, so it
never gets a Raw/Final Damage chip at all (same 3rd-shape bucket as `novaFlare`) -- `penetrating:true`
would have nothing to attach to.

**Flame Carnival**: DOES have a real `dmg:"talAdjust(10)"` field and a working chip, so this was a real,
live bug. Verified directly (not assumed from the Flame Turret pattern): `Mole.cs:39150` --
`this.$hitChar$23938.RPC_AddDamage(442, this.$hitDmg$23939, 0, 0, ...)`, same direct-call shape as Flame
Turret. Also re-confirmed Napalm's own call site (`Mole.cs:37735`) for consistency, same pattern again.

**The real catch, re-reading Flame Turret's own call site one more time while investigating Flame
Carnival**: `Mole.cs:28200` -- `RPC_AddDamage(231+sLv, this.mChar.talAdjust(5*sLv), 0, 0, ...)`. The
`nDamage` argument is a BARE `talAdjust(...)` call -- **no `dmgAdjust(...)` wrapper around it at all**.
The previous pass's fix only skipped `defAdjust` (the target-side step) and left `dmgAdjust` (the
attacker-side step -- `damageMod` + the attacker's own LCK roll) running as normal. But `dmgAdjust` only
happens INSIDE `hit()` (`CharacterControl.cs:3540-3566`'s documented canonical order) -- a skill that
calls `RPC_AddDamage` directly, bypassing `hit()` entirely, skips BOTH steps wholesale, not just
`defAdjust`. The first fix was half right: it correctly identified the mechanism (direct `RPC_AddDamage`
bypasses `hit()`) but incompletely applied its consequence.

**Fix, both pipeline sites corrected**: `rollOneHit` now sends `val` (the fully-processed
Raw-Damage-equivalent pre-`dmgAdjust` value) straight to `hitModAdjust` for a `penetrating` skill, instead
of routing it through `dmgAdjustAtRoll` then `defAdjustRoll`. The Final Damage range calc does the same
with `dmgCalcRange[0]/[1]` (Raw Damage's own min/max) instead of first wrapping them in `dmgAdjustAtRoll`.
`flameCarnival` given the same `penetrating:true` flag as `flameTurret`; both `dmgNote`s updated to say
"ignores enemy DEF and damageMod entirely" (was just "DEF") and cite the bare-talAdjust evidence directly.

Verified live (both skills, cache-disabled reload): Final Damage is now identical across all 3 enemy
presets for BOTH Flame Turret (`59-68`, narrower than the previous pass's `59-96` -- confirms the extra
spread before was `dmgAdjust`'s own attacker-LCK roll incorrectly still stacking on top) and Flame
Carnival (`39-44`). Cross-checked the remaining Raw-Damage-to-Final-Damage gap by hand: `35 x 1.10 = 38.5
-> 39`, `40 x 1.10 = 44` -- exactly the synthetic "Final Multiplier" testing stage's own default 2-of-3-on
state (+10%, `finalMultiplierAdjust`), a deliberate tool-only feature applied uniformly to every skill
including penetrating ones, not a leftover mitigation bug -- confirms `hitMod` itself is a clean 1.0x and
both real adjuster stages are genuinely fully skipped now, not just close. Zero console errors.

**Process note, worth remembering for any future "does skill X bypass mitigation" question in this
tool**: confirming a skill bypasses `hit()` is necessary but not sufficient to know WHICH steps inside
`hit()` it loses -- have to check what value actually reaches `RPC_AddDamage`'s `nDamage` argument
directly (bare `talAdjust(...)` here means dmgAdjust never ran either), not just confirm defAdjust is
one of the missing steps and stop there. This is the second time this exact investigation pattern
("re-read the call site itself, not just re-confirm the headline claim") caught a real gap this session.

### 2026-08-19, same day: Stun Mine/Grenade's "0" damage isn't really 0 in practice -- defAdjust floors it to a real >=1 range

User: "stun mine and stun grenade, even with 0 damage formula, in practice, it still does some damage, I
believe it's due to a certain damage formula." Investigating this surfaced 2 real findings, one a dead
end and one the actual answer -- worth recording both since the FIRST one looked right until the user's
own follow-up ruled it out.

**False lead, investigated first**: `Mole_stunMine.cs:396-402` calls a SEPARATE function,
`RPC_smartShell_hit` (`Mole.cs:11489-11588`), unconditionally whenever the caster has Smart Shell learned
(`getSmartShellLv()==1`) -- confirmed a real, independent +30 flat AoE hit via
`RPC_AddEffectDamage(264, 30, 0, 0, ...)` (`:11583`), same mechanism already flagged (but never modeled)
in this tool's Landmine `dmgNote`. This looked like a strong candidate -- but the user clarified the
damage they saw was "shown as 1 damage in normal color," not a purple effect-damage 30, ruling this out
directly (this tool's own convention, documented earlier: white digits = normal/direct-hit damage, purple
= `RPC_AddEffectDamage`/DoT-pathway damage) and pointing at a floor/truncation instead.

**The real answer**: `hit()` (`CharacterControl.cs:2807`, the function Stun Mine's own `RPC_stunMine_hit`
calls with a literal `nDamage=0`) runs `dmgAdjust` then `defAdjust` on `nDamage` UNCONDITIONALLY --
`:3540`/`:3546`, no "skip if 0" guard anywhere in the visible control flow. `defAdjust`'s own formula
(`CharacterControl.cs:20524`) floors BOTH its components to a minimum of 1 regardless of the input:
`light = max(d - 0.5×N, 1)`, `heavy = max(d×(1 - N/(N+64)), 1)`, `taken = ceil(0.35×light + 0.65×heavy)`.
At the worst-case attacker LCK roll (R=0, so `d=0` reaches `defAdjust` unchanged), both components floor
to exactly 1 REGARDLESS of target DEF/LCK, giving `taken=1` always -- not a fixed constant overall, since
`dmgAdjust`'s own attacker-LCK roll can push `d` above 0 at better rolls, but the MINIMUM of the resulting
range is always exactly 1, never 0. This is a completely different (and correct) mechanism from the
Smart Shell lead -- a floor baked into the mitigation math itself, independent of any passive.

**Real bug this exposed in the earlier `dmg:"0"` pass**: giving these 2 skills a literal `dmg:"0"` was
accurate at the SOURCE level, but the tool's own gating logic (`flatComputableCalc`) required a
`dmgReplaceDep`/`dmgDep`/`dmgMultDep`/`atkCoeff` to even render a Raw/Final Damage chip at all -- a flat
literal with no dep (exactly what `dmg:"0"` is) got NO chip whatsoever, silently showing nothing where a
real, computable Final Damage range exists. That gating premise ("nothing to toggle" = "nothing to
compute") was never actually true -- `dmgAdjust`/`defAdjust`/`hitMod` all apply uniformly to ANY flat
value regardless of whether the skill's own formula happens to reference a dep, dep or not, stat-scaled
or not. Fixed generally, not with a 2-skill special case: `flatComputableCalc` now just checks whether the
substituted `dmg` text is a bare arithmetic literal (`/^[\d\s×*+\-.]+$/`), matching the SAME test
`renderDmgFormula`'s own flat branch already used for the DISPLAY side, now shared by the CALC side too.

**Side effect, caught and verified rather than left as a surprise**: this same fix ALSO newly gives
Penguin's `manaVortex` (`dmg:"sLv×12+12"`, no dep, previously excluded by the same flawed gate) a real
Raw/Final Damage chip for the first time -- checked deliberately, not accidentally: it's a genuine
non-opaque, non-KO-only damage skill that was only ever excluded by the same wrong premise, so extending
the fix to it is a real improvement, not scope creep. `novaFlare`/`detonate`/`warFactory`/`napalm` all
stay correctly excluded (their `dmg` text contains letters/prose, fails the arithmetic-literal regex).

Both `dmgNote`s rewritten to explain the floor mechanic directly instead of the now-inaccurate "deals 0
real damage... no damage component at all."

Verified live (cache-disabled reload): Stun Mine/Stun Grenade both show Raw Damage `0` (correct,
pre-pipeline) and Final Damage a real range whose displayed default-view minimum was `2` -- traced this
extra +1 deliberately rather than assuming a bug: opened the Mods popup, turned off the synthetic "Final
Multiplier" stage's own 2-default-on toggles (a TOOL-only testing feature, `+10%`, unrelated to source),
and the minimum dropped to exactly `1` -- confirming the pure source-level floor is exactly 1 as derived
by hand, and the displayed `2` was correctly `ceil(1×1.10)`, not a discrepancy. `manaVortex` re-verified
separately (`Raw Damage 48`, a chip that didn't exist before this pass). Zero console errors. A paren-
balance check caught one real unclosed `(` in this pass's own new comment text before publishing (fixed,
re-verified 955/955 braces, 1917/1917 parens) -- worth remembering that a big prose comment with several
parenthetical asides is exactly the kind of edit likely to silently break this file's balance count if not
re-checked immediately after writing it, not just after the surrounding code change.

### 2026-08-19, same day, immediate follow-up: the flatComputable fix above missed a 2nd, separately-declared copy of the same gate

User: "even final damage = 2, the damage sim only output 0." Real gap -- `renderHero()`'s
`flatComputableCalc` (fixed in the pass above, gates whether the Raw/Final Damage CHIPS render) and
`rollOneHit`'s own `flatComputable` (a differently-scoped local with the identical name minus "Calc",
gates whether the Test/Simulate BUTTON's single-roll function returns a real value or a hardcoded `0`)
are two SEPARATE variables checking the same underlying condition in two different functions -- fixing
one is not fixing both. `rollOneHit`'s copy still required a `dmgReplaceDep`/`dmgDep`/`dmgMultDep`/
`atkCoeff` post-fix, so Stun Mine/Stun Grenade's chips correctly showed a real `2-28` range while
clicking Test still silently hit the function's early `return 0`. Fixed with the identical regex swap
(`/^[\d\s×*+\-.]+$/.test(text)`, matching `flatComputableCalc`'s own fix exactly, just against `rollOneHit`'s
own local `text`/`talMatch` instead of `renderHero`'s).

**Process note, 2nd time in one session**: writing a big prose comment with parenthetical asides broke
this file's paren balance again, same exact mistake (an opened `(2026-08-19,...` never closed) as the
pass immediately before this one -- caught and fixed both times by re-running the brace/paren check right
after writing the comment, before testing anything live. Worth being more careful with parenthetical
asides in comments specifically, not just noting the check catches them after the fact.

Verified live (cache-disabled reload, fresh navigation after an unrelated Playwright session drop):
Stun Mine's Test button now rolls real nonzero values every time (5 consecutive rolls: `16, 2, 4, 3`, all
within the `2-28` Final Damage range, never `0`); Stun Grenade's own Test button re-verified separately
(rolled `5`). Zero console errors.

### 2026-08-19, same day: Napalm's damage formula -- the first skill whose OWN hits genuinely roll two different base formulas, and a new `dmgGroups` mechanism to display all of them

User: "we'll work on napalm damage formula next, what seems to be the problem?" Napalm's `dmg` had been
plain opaque prose (`"1st tick 30 (TAL-scaled), ticks 2–6: 5 each (TAL-scaled)"`, excluded from every chip)
because it genuinely doesn't fit the tool's one-`dmg`-template-per-skill assumption every other multi-hit
skill (manaMissile, fallingComets, etc.) gets away with -- confirmed directly against `Mole.cs:37659-37744`
(`RPC_napalm_hit`'s own `i=0..5` loop): `this.$hitDmg$23901 = this.$self_$23907.mChar.talAdjust((this.$i$23897
!= 0) ? 5 : 30)` (`:37684`) -- tick index 0 rolls `talAdjust(30)`, indices 1-5 roll `talAdjust(5)` each, a
REAL two-formula shape, not a display simplification. Offered two implementation paths via AskUserQuestion
("show the repeated tick only, note the exception" vs. "model both ticks exactly"); user picked **"Thorough:
model both ticks exactly."**

**Projectile count vs. tick count, a separate user question mid-implementation**: "this skill has 6 ticks,
with how many projectile count?" -- checked `RPC_napalm` (`Mole.cs:37173-37238`) separately: a DIFFERENT loop,
`i=0..4` (5 iterations), each calling `RPC_napalm_fire` -- the first shot flies straight at the target, the
other 4 add a `(±5,0,±5)` diagonal offset, landing a center-plus-4-diagonal spread. **5 projectiles, 6 damage
ticks -- not the same number, and not 1:1.** The 6 ticks are a SEPARATE AoE-pulse loop (`RPC_napalm_hit`) that
re-scans a fixed impact point with `Damage.FindAreaTarget` (radius `4 + extraPowderLv`) 6 times, hitting
everyone in range each pulse, regardless of how many projectiles actually landed. Folded into `dmgNote`.

**`dmgGroups` (new schema mechanism, not a Napalm-only hack)**: mid-implementation the user broadened scope
twice, both edits made before publishing since neither needed live back-and-forth to resolve:
1. "several skill might have more than one formula in a single skill, be prepare to display all formula for
   every hit in the damage calc and raw damage chip" -- a general mechanism, not a Napalm-specific field. First
   draft used a Napalm-only `dmgFirstHit:"talAdjust(30)"` override consumed only by `rollOneHit` (Simulate);
   replaced entirely with `dmgGroups:[{dmg, hitCount, label}, ...]`, an ordered list covering every hit in cast
   order, consumed by THREE places instead of one: `resolveHitDmgText(skill, hitIndex)` (walks the list by
   cumulative `hitCount` to answer "which formula does hit N use," replacing the old `dmgFirstHit` check,
   shared by `rollOneHit`), `renderDmgFormula` (now branches on `skill.dmgGroups` FIRST, rendering one stacked
   `.sk-dmg-group` block per group via the renamed `renderOneDmgFormula(skill, rank, dmgTextRaw)` -- the old
   single-formula body, now parameterized instead of hardcoded to `skill.dmg`, completely unchanged for every
   other skill), and the Raw Damage chip in `renderHero` (a new `calcRangeFor(dmgTemplateText)` closure,
   extracted from the old hardcoded-to-`selected.dmg` `talMatchCalc`/`dmgCalcPostFn` block the same way, called
   once per group and rendered as a labeled `.sk-dmg-group-list` instead of the usual single `.sk-stat-value`).
2. "in the final damage chip, assume all hits connect and come up with a damage range for skills with multiple
   formulas" -- deliberately a DIFFERENT shape from Raw Damage's per-group list: Final Damage sums every
   group's own post-pipeline range × that group's `hitCount` (`finalRangeForRange`, itself extracted from the
   old inline `worstAfterDef`/`bestAfterDef`/`finalRange` block, now reusable per-group), landing on one total
   number with a new `.sk-dmg-final-note` caption ("total, 6 hits, all connect") so it doesn't read as a
   per-hit figure the way every other multi-hit skill's Final Damage chip does (manaMissile etc. deliberately
   UNCHANGED -- still shows one missile's own range, not a 5-missile total; the summing behavior only triggers
   for `dmgGroups` skills, confirmed by re-checking Mana Missile's own chip after this pass, numbers identical
   to before).
3. A third, unprompted user comment during verification -- "for napalm skill specifically, it is certain that
   all 5 projectiles will hit the same target, becuase it's always used with target at point blank range and
   the projectiles have quite a large hitbox" -- confirmed the "assume all connect" framing isn't a hypothetical
   worst case for THIS skill, it's the realistic outcome given how it's actually played; folded into `dmgNote`
   rather than left as a bare assumption baked silently into the math.

**Schema** (`mole_napalm`): `dmg:"talAdjust(5)"` kept as the representative/fallback formula (still gates the
whole chip block's `if (selected.dmg)` check, still what `attackerLCK`'s `ownLck` branch and other
not-yet-dmgGroups-aware code paths would fall back to), plus `dmgGroups:[{dmg:"talAdjust(30)", hitCount:1,
label:"Tick 1"}, {dmg:"talAdjust(5)", hitCount:5, label:"Ticks 2–6"}]`, `hitCount:()=>6` (kept as an explicit
top-level field rather than derived from summing `dmgGroups`, matching every other multi-hit skill's own
convention and avoiding touching `getHitCountRange`/`rollHitCount`/the Simulate button's title label at all),
`penetrating:true` (Napalm's own `RPC_AddDamage(31, hitDmg, 0, 0, ...)` call at `:37735` is a bare `talAdjust`
value with no `dmgAdjust(...)` wrapper, same shape as Flame Turret/Carnival -- both `dmgAdjust` and `defAdjust`
skipped, confirmed by `nKo=0` positionally too, so no `ko` field either, unlike Stun Mine/Grenade).

**New CSS** (`.sk-dmg-group-list`, `.sk-dmg-group`, `.sk-dmg-group-label`, `.sk-dmg-group-formula`,
`.sk-stat-value-sm`, `.sk-dmg-final-note`): a real layout bug caught and fixed before publishing, not just in
review -- `.sk-ko-badge` is absolutely positioned at the Damage Formula chip's own bottom-left corner (10px
from the chip's bottom edge), sized correctly against a single `dmg-term-group`'s usual height but NOT against
2 stacked `dmgGroups` blocks, which grew the chip's content tall enough to visually overlap the KO badge's own
"0" text (caught via a live screenshot, then confirmed numerically: `getBoundingClientRect()` showed real
vertical overlap between `.sk-ko-badge` and the last `.sk-dmg-group`). Fixed with
`.sk-dmg-formula .sk-dmg-group-list{padding-bottom:26px}` (reserves clearance only inside the Damage Formula
chip's own group list, not Raw Damage's -- Raw Damage has no KO badge to clear) -- re-verified via
`getBoundingClientRect()` overlap check (`false` after the fix, `true` before) rather than eyeballing the
screenshot alone.

Verified live (Node static server, `Cache-Control: no-store` + CDP `Network.setCacheDisabled`, fresh
navigation per check): Napalm's Damage Formula chip shows both `30 + 76(0.6TAL)` (Tick 1) and `5 + 12(0.1TAL)`
(Ticks 2-6) stacked; Raw Damage shows `106-122` / `17-20` stacked; Final Damage shows `212-245` with the
"total, 6 hits, all connect" caption; Simulate's 6 revealed hits were `128, 20, 19, 22, 21, 21` (hit 0 the
real 30-base roll, hits 1-5 the real 5-base rolls, summing to `231`, inside the `212-245` range) -- confirms
`resolveHitDmgText` is correctly wiring hit index 0 to the `dmgGroups` first entry. Flame Turret (single-
formula, `penetrating:true`) re-checked after the refactor: `53-61`/`59-68`, byte-identical to its own
pre-refactor numbers. Mana Missile (multi-hit, NOT `dmgGroups`) re-checked: `118-134`/`126-173`, also
unchanged -- confirms the new branches are additive, not a regression on every other skill's existing path.
Brace/paren/bracket balance + `new Function(js)` syntax check passed after every edit. Published to the
same Artifact URL, same 🦊 favicon.

### 2026-08-19, same day, correction: the pass above only modeled ONE projectile's 6-tick sequence -- the real total is 5× that, one full sequence PER projectile

User, after independently checking KO for a separate reason: "check of KO really = 0, check in Napalm.cs if
exist." That check turned up a file this whole Napalm investigation had never opened: `Mole_napalm.cs` (the
per-skill file `<Class>_<skillName>.cs` naming convention this repo documents in its own top-level `CLAUDE.md`
-- distinct from `Mole.cs`, which is all that had been read so far). KO confirmed correctly `0` (its
`OnTriggerEnter`, `:98-219`, just calls `mole.RPC_napalm_hit(vector, normalized, 0)` at `:179` -- the same
method already traced, whose own `RPC_AddDamage(31, hitDmg, 0, 0, ...)` call already had a literal `nKo=0`).
But reading this file surfaced something bigger the user caught next: "you forgot to simulate all 5
projectiles for napalm skill."

**The real mechanism**: `Mole_napalm` is the MonoBehaviour attached to each individual fired projectile
(confirmed via `RPC_napalm_fire`, `Mole.cs:13714-13768`: `UnityEngine.Object.Instantiate(this.TS7aExAdJl,
firePos, rotation)` at `:13740` creates a NEW GameObject every single call, and `RPC_napalm`'s own casting
coroutine calls `RPC_napalm_fire` 5 separate times, `Mole.cs:37173` `while (this.$i$23884 < 5)`, already
known from the prior pass). Each of those 5 projectile GameObjects carries its OWN `Mole_napalm` script
instance, and each one's `OnTriggerEnter` independently starts a full `RPC_napalm_hit` coroutine FROM THAT
PROJECTILE'S OWN IMPACT POSITION on collision (`Mole_napalm.cs:179`) -- confirmed this is the ONLY origin of
`RPC_napalm_hit` calls in the whole codebase: the sole other 2 call sites in `Mole.cs` (`:2831`, string-keyed
`ActionName` dispatch; `:5671`, integer-keyed `num3` dispatch, both guarded by `if (this.mChar.isMine) break`)
are both just the standard Photon network-replication receivers that mirror the OWNING client's already-made
decision onto other clients' screens, not independent triggers of new game logic. So **5 independent
projectiles, each capable of independently starting its own full 6-pulse AoE sequence** -- if all 5 connect
with the same target (which the user had already separately confirmed is the reliable real case: "it's always
used with target at point blank range and the projectiles have quite a large hitbox"), that target takes
5×6 = **30 total damage pulses**, not 6: 5 real `talAdjust(30)` pulses (one per projectile's own tick-0) +
25 real `talAdjust(5)` pulses (5 projectiles × 5 remaining ticks each), not 1 + 5.

**Fix**: no new mechanism needed -- the `dmgGroups` engine built in the pass immediately above this one is
already fully generic over hit COUNTS per group, so this was purely a data correction. `mole_napalm`'s
`dmgGroups` hitCounts went from `[1, 5]` (one projectile's own sequence) to `[5, 25]` (5 projectiles × each
count), top-level `hitCount:()=>6` to `()=>30`, group labels to `"Tick 1 ×5 projectiles"` / `"Ticks 2–6 ×5
projectiles"` so the chip itself states the multiplier rather than leaving it implicit, and `dmgNote` rewritten
to explain the per-projectile-independent-sequence mechanism directly (was previously wrong in a way that
undercounted by 5×, not just imprecise).

Verified live (fresh Node server, `Cache-Control: no-store` + CDP `Network.setCacheDisabled`): Damage
Formula/Raw Damage chips show the same 2 per-tick numbers as before (`30+76(0.6TAL)` / `5+12(0.1TAL)`,
`106-122` / `17-20` -- correctly UNCHANGED, since a single projectile's own per-tick formula/range didn't
change, only how many times it's counted) with the new "×5 projectiles" labels; Final Damage jumped from
`212-245` to **`1060-1225`** (total, 30 hits, all connect); Simulate's title changed to "Test 30 hits" and a
live roll produced exactly 5 big (>60) values and 25 small values, summing to `1152`, correctly inside the
new `1060-1225` range. Screenshot confirmed no layout regression from the longer group labels or the 5×
larger hit grid. `12t_reference/mole-skill-damage-reference.md`'s own napalm row and its
"tooltip-vs-code-discrepancies" note updated to flag that the tooltip's cited `"45 penetrating damage"`
(`MoleSkill_eng.cs:950`) is now off by roughly 25× from the real point-blank total, not the ~10-off figure the
single-projectile reading previously suggested -- almost certainly describing one representative tick/pulse,
not the full 5-projectile cast, consistent with how loosely-worded other tooltips in this codebase already
are. Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-19, same day: Detonate's Damage Formula chip removed entirely, not just left as opaque text

User: "remove damage formula for detonate entirely and publish." Detonate's `dmg` had been kept as opaque
prose (`"Shares Time Nuke's TAL-scaled base ..., scaled 10%–99% by how long it was armed before manual
trigger"`) purely so the chip would render its `dmgNote` explanation as plain text -- same treatment as
novaFlare/warFactory. User wanted the chip gone outright for this one instead. Simplest possible fix: deleted
`mole_detonate`'s `dmg`/`dmgNote` fields entirely rather than adding any new opt-out flag -- `renderHero`'s
own `if (selected.dmg){...} else if (selected.shield){...} else {...}` gate already falls through cleanly to
its existing "neither" branch (blank `.sk-dmg-row`, no KO badge since Detonate has no `ko` field either) with
zero code changes needed. Verified live: only the Cooldown chip shows now, `DAMAGE FORMULA` text gone
entirely from the page, zero console errors. `mole-skill-damage-reference.md`'s own detonate row updated to
note the chip's removal (the underlying formula citation itself is unchanged -- still real, still documented,
just no longer surfaced in the tool; see Time Nuke's own row for the shared base). Published to the same
Artifact URL, same 🦊 favicon.

### 2026-08-20: Auto Gyro Gun's Raw Damage range question, then a real missing KO=1 found by the user

User asked why Auto Gyro Gun's Raw Damage chip still wasn't a `[min,max]` range and whether it should use
its own LCK. Verified this is correct as-is, not a bug: `mole_autoGyroGun`'s `dmg` is a flat expression
(`"10×sLv"`, or Hidden-Turret-replaced), never `talAdjust(...)`-wrapped, so the raw base value has no
roll built into it at all (unlike every `talAdjust` skill, where the caster's own LCK roll is baked
directly into the formula) -- Raw Damage is correctly a single deterministic number. The turret's own
LCK IS already used, just downstream: `ownLck:true` (set 2026-08-18) drives `attackerLCK` in both
`rollOneHit` (`index.html` ~2577) and the Final Damage range calc in `renderHero` (~3666), reading the
turret's own computed LCK (`AutoGyroGun.cs`'s baseline `10×rank`, or `0.125×rank×MoleLV` under Hidden
Turret) instead of the tool's global LCK input. Confirmed live (Playwright, rank 4, LV 100, Hidden
Turret + Synchro Mole both on): Raw Damage = `228` (flat, `100` from `0.25×4×100` + `128` from Synchro
Mole's TAL term), Final Damage = `244-257` (a real range, driven by the turret's own LCK-rolled
`dmgAdjust` + the target's `defAdjust` roll) -- pipeline working as documented.

**User then independently checked `AutoGyroGun.cs` directly and found a real gap**: the turret had no
`ko` field in the tool at all. Confirmed by reading the same `RPC_fire` coroutine already cited for the
damage pipeline (`AutoGyroGun.cs:1243`): `this.mChar.hit(1, hitObject, this.mChar.atk, 1, 0,
Vector3.zero)` -- matched against `CharacterControl.hit`'s real signature (`CharacterControl.cs:2807`,
`hit(int actionCode, GameObject tObject, int nDamage, int nKo, int nHate, Vector3 nForce)`), the 4th
positional arg (`nKo`) is a literal `1` -- flat, not rank-scaled, untouched by Hidden Turret/Synchro
Mole. Root cause: both prior Mole KO sweeps (the original 6-skill pass and the 16-skill follow-up sweep,
2026-08-19 entries above) hand-picked their skill lists and simply never included Auto Gyro Gun --
plausibly because it was already special-cased everywhere else (continuous turret AI, not a single
cast), not because it was checked and found to be zero. Fixed with a one-line data addition,
`ko:"1"` added to `mole_autoGyroGun`'s `SKILLS` entry -- no new mechanism needed, the existing
`getKOValue`/`.sk-ko-badge` machinery (built for Mega Punch etc.) already handles a plain flat `ko`
string with no dep. `mole-skill-damage-reference.md`'s `autoGyroGun` summary-table row and a new "KO --
missed by both prior KO sweeps" section updated with the citation. Published to the same Artifact URL,
same 🦊 favicon.

### 2026-08-20, same day: the reserved LCK-proc slot filled in for real, pilot skill Arctic Wind

User asked to "test the water" on the 4th `.sk-hero-stats` slot (`.sk-stat-lck`, reserved since
2026-08-14, never built -- see that dated entry above) with Arctic Wind's `arcticFrost1` dep as the
pilot case, specifying the key behavior up front: frost chance should read 0% per hit when unupgraded.

**Research** (read directly, not delegated): `Penguin.cs:10653-10685` (`getArcticFrost()`) --
`arcticFrostLv<=0` short-circuits straight to `false` (always `ice`, 0% frost, matching the user's own
spec exactly), otherwise rolls `Random.Range(0,100) < this.mChar.lckAdjust(20)`. `lckAdjust` itself
(`CharacterControl.cs:20658-20671`) is a genuinely different formula shape from every other `*Adjust`
already in this tool -- **no `Random.Range` baked into the function**, the roll lives at each individual
call site instead:
```
num = nChance * (1 + 0.01*clamp(lck,1,512))
result = floor(100*num / (num - nChance + 100))
```
So unlike Cooldown/Cast Time/Duration (each a `[min,max]` spread from an internal roll,
with a probability-tooltip breakdown), an LCK-proc chance is one live deterministic percentage for a
given LCK -- no roll, no tooltip needed. Confirmed the caller site too (`Penguin.cs:30633-30647`, inside
`arcticWind`'s hit coroutine): `getArcticFrost()` true -> applies `"frost"` (cosmetic, no slow, per the
existing per-skill reference doc); false -> applies `"ice"` (the real slow debuff) -- matches this doc's
and `penguin-skill-damage-reference.md`'s existing citation exactly, no corrections needed this
time.

**New mechanism, generic not Arctic-Wind-specific**: `skill.lckProc = {label, chance, dep}` (nested
dep, not a new top-level `lckProcDep` field -- self-contained since only one field, `chance`, needs to
travel with it) plus a new top-level `lckAdjustChance(nChance, LCK)` formula function (beside
`magAdjustRange`) implementing the exact source formula above. `dep` reuses the SAME generic
`getDepRank`/`renderDepBlock`/`.sk-dep-toggle` machinery every other dep in this tool already uses --
zero new listener code, `arcticFrost1`'s toggle (0/1 rank, defaults ON per this tool's standing "assume
the passive is learned" convention) just works. Render block (`renderHero`, right after the Duration
block) computes `lpChancePct = lpDepOn ? lckAdjustChance(lp.chance, LCK) : 0` -- the OFF branch is a
hard `0`, not a dimmed copy of the on value, matching source (`arcticFrostLv<=0` never even calls
`lckAdjust`).

New icon extracted: `penguin_arcticFrost1.png` (single-rank passive, `RippedAssets/.../penguin/
arcticFrost1.png` -- files exist 0-4 per the usual "generic asset convention, not a gameplay signal"
already documented elsewhere in this file, only rank-1 was needed).

**Verified live** (Playwright, local dev server): selecting Arctic Wind shows a new "Frost Chance" chip
in the 4th slot, `36%` at default LCK 128 (hand-checked: `num=20×2.28=45.6`,
`floor(4560/125.6)=36` -- exact match) with `base 20%` and the Arctic Frost toggle icon in the corner,
same visual language as every other dep. Toggling the dep off live-updates to `0%` in the same render,
matching the user's spec exactly. Setting LCK to 500 via direct DOM property assignment (bypassing the
input's own 128-default) live-updated the chip to `60%` -- hand-checked (`num=20×6=120`,
`floor(12000/200)=60`) confirming the formula is bit-exact against source, not approximated. Zero
console errors, screenshot confirmed no layout collision with the box's fixed 108px height or the corner
toggle. Published to the same Artifact URL, same 🦊 favicon.

**Immediate same-day follow-up, user-caught**: the `base 20%` line stayed at the literal `lp.chance`
regardless of dep state, so toggling Arctic Frost off dropped the big number to `0%` but left `base 20%`
displayed underneath it -- inconsistent with how every other dep-bearing chip in this tool works (e.g.
Mine Lover's `cdDep` changes Landmine's `base 8s` to `base 15s` when toggled off, the base line always
reflects the dep-resolved value, not the raw literal). Fixed: `base ${lpDepOn ? lp.chance : 0}%` --
matches the mechanic exactly, since `lckAdjust` is never even called when `arcticFrostLv<=0`, so there's
no real "20%" in play at all when the dep is off, not just a value that happens to round to 0. Verified
live: toggling off now shows `0% / base 0%` together, toggling back on restores `36% / base 20%` at
default LCK. Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-20, same day: `lckProc` extended to 2 more real skills, and a 3rd requested target that turned out not to exist

User asked to check Ice Shield (`frostSpike`), Double Cast (`doubleSpell`), and Tornado (`iceTwister`) for
the same LCK-proc mechanic. Re-read source directly for each rather than trusting the existing per-skill
reference doc's citations at face value (though all 3 turned out to match it exactly):

- **Ice Shield / Frost Spike -- real, wired in.** `CharacterControl.cs:31236-31259`: inside the "shield
  fully absorbs the hit" branch (`sValue > nDamage`), `if (hasSkill(423)) { if (Random.Range(0,100) <
  lckAdjust(12)) { ...RPC_frostSpike_fire... } }` -- a 12% chance per full-absorb to AoE-apply `frost`.
  Reuses the SAME dep `id:"frostSpike"` Ice Shield's existing `shieldDep` (the `+charLv` shield-HP bonus)
  already uses -- no new dep object, just a 2nd reference to it -- so toggling either the Shield
  Formula's own corner icon or the new Frost Chance chip's icon flips both in one render, same
  linked-toggle mechanism as Mine Lover (Landmine Cooldown↔Damage) and Mega Drill (Mega Punch/Hammer
  Damage↔KO). Icon reused too (`penguin_frostSpike5`, already extracted).
- **Tornado / Ice Twister -- real, wired in.** `Penguin_tornado.cs:339` (the pet's own per-tick collision
  handler, gated on the `hasSkill(443)`-derived `nIce` flag passed in from `Penguin.cs:11029` at
  summon-time): `if (Random.Range(0,100) < lckAdjust(9)) { ...RPC_AddStatus("frost"...) }` -- 9% chance
  PER TICK. Re-confirmed identical logic in `Penguin_typhoon.cs:216` (tornado's evolved locked-target
  form) -- but typhoon has no `SKILLS` entry of its own in this tool at all (it reroutes through tornado's
  own cast dispatcher rather than being separately selectable), so nothing to wire there; noted as a
  known gap, not silently dropped. New dep `id:"iceTwister"` (new icon extracted,
  `penguin_iceTwister5.png` -- genuinely absent from `SKILL_ICONS` AND from any prior extraction, unlike
  several past "not yet extracted but the file exists" cases; had to pull fresh from `RippedAssets` via
  Bash/node since Glob silently skips `RippedAssets` as a gitignored path -- worth remembering for any
  future icon hunt in this repo, Glob is not a reliable "does this file exist" check there, `ls`/`find`
  via Bash is). `iceTwister5` ALSO raises the pet's own velocity cap 30→40 (per the existing reference
  doc, undocumented in-game) -- not modeled, no speed chip exists in this tool, same "omit rather than
  misrepresent" call as every other untracked side-effect in this file.
- **Double Cast / Double Spell -- does NOT exist as specified; flagged instead of silently building on
  the wrong skill.** Doubled-checked directly (`Penguin.cs`): `doubleSpell5`(431)'s `lckAdjust`-gated
  12%-chance multiCast GRANT roll is NOT on Double Cast at all -- Double Cast (`doubleCast1`) grants
  `multiCast` unconditionally on cast, no roll, no `lckAdjust` call anywhere in its own coroutine. The
  real 12% roll sites are on **Blink** (`Penguin.cs:23163-23178`, inside `$RPC_blink$26122`) and, per the
  existing reference doc's own already-correct citation, **Falling Stars** has its own SEPARATE inline
  12% roll too (`Penguin.cs:25500-25514`, inside `$RPC_fallingStars$26175`) -- doubleSpell5 grants on 2
  different casts, neither of which is Double Cast. Not implemented pending user direction on which of
  Blink/Falling Stars (or both) to actually wire up.

Verified live (Playwright, local dev server) for both real additions: Ice Shield shows `23%` / `base 12%`
at default LCK 128 (hand-checked: `num=12×2.28=27.36`, `floor(2736/115.36)=23`, exact match), and
toggling the shared `frostSpike` dep from EITHER icon instance (2 found via
`querySelectorAll('[data-dep-id="frostSpike"]')`) drops both to `0%`/`base 0%` together. Tornado shows
`18%` / `base 9%` (hand-checked: `num=9×2.28=20.52`, `floor(2052/111.52)=18`) with the new Ice Twister
icon rendering correctly (real, non-empty image src). Zero console errors, screenshot confirmed no layout
regression on either skill's card. Published to the same Artifact URL, same 🦊 favicon.

**Process note**: `lckProc`'s first draft (Arctic Wind pass, same day) included an unused `note` field on
all entries, copying the `dmgNote` convention without actually wiring up a display for it (`dmgNote` gets
a real click-to-reveal info icon via `positionDmgInfoPopup`, which is hard-coded to a SINGLE
`$(".sk-dmg-info", displayEl)` query -- not safely reusable as-is for a 2nd info icon elsewhere on the
card without real changes). Caught before publishing this pass rather than shipping 3 more instances of
dead data: dropped `note` from all 3 `lckProc` entries (Arctic Wind included, for consistency) rather
than half-wire a 2nd info-icon system for a "test the water" pilot -- if per-skill caveat text turns out
to be needed later (e.g. Ice Twister's un-modeled velocity-cap bump), build a real generic multi-instance
version of the info-icon mechanism then, not a one-off.

**Immediate same-day follow-up: Double Cast, per explicit user override.** Presented the Blink/Falling
Stars finding above via `AskUserQuestion`; user's answer went further than either of the 4 options
offered -- doubleSpell5's 12% grant roll is coded independently on MORE than just those 2 skills (not
re-verified exhaustively this pass, taking the user's own broader game knowledge at face value here
rather than re-grepping every `isDoubleSpell` skill's coroutine), but **the user explicitly chose to keep
the tool simple and display the chip on Double Cast's own card anyway** rather than chase down and
duplicate the chip across every real proc site. This is a deliberate UI simplification the user asked
for, not a mechanical claim -- Double Cast's own cast still never calls `lckAdjust` at all (confirmed
above), the chip here is a representative summary of the passive's overall proc rate, not a literal
"this roll happens when you press this button" fact the way every other `lckProc` chip in this file is.
Worth knowing if this file's own citation-honesty rule (`dmg`/`dmgNote` etc. never model a mechanic that
isn't real) gets invoked here later -- this ONE chip is a known, user-directed exception to it.

Implementation: `lckProc:{label:"Multicast Chance", chance:12, dep:{id:"doubleSpell", ...}}` on
`penguin_doubleCast`. **Label changed from "Frost Chance" to "Multicast Chance"** -- caught before
publishing, not after: Double Spell's payoff is the `multiCast` buff (doubles the next spell cast), not
a frost/ice application at all, so copy-pasting the other 3 skills' "Frost Chance" label would have been
factually wrong, not just a cosmetic mismatch (Arctic Wind/Ice Shield/Tornado all genuinely apply
`"frost"` on their proc; Double Cast doesn't). New icon extracted (`penguin_doubleSpell5.png`, confirmed
present on disk, same "check via `ls`/`find` not Glob" caveat as Ice Twister since this is also under
gitignored `RippedAssets`). New dep `id:"doubleSpell"` (no existing dep on Double Cast to link against,
unlike Ice Shield's `frostSpike` reuse -- this is the first toggle Double Cast has ever had).

Verified live: `23%` / `base 12%` at default LCK 128 (same chance value and therefore same displayed
number as Ice Shield's own 12%-base chip, both `lckAdjust(12)` -- confirmed independently, not just
assumed identical because the input matched). Icon renders (real non-empty src). Zero console errors.
Published to the same Artifact URL, same 🦊 favicon -- 4 skills now carry the `lckProc` chip total
(Arctic Wind, Ice Shield, Tornado, Double Cast).

**Immediate same-day follow-up, user-caught from a screenshot: Ice Twister's icon was corrupted.**
`penguin_iceTwister5`'s embedded base64 decoded to a valid-looking (correct PNG header/`IEND` footer) but
truncated/bit-flipped 4127-byte file, not the real 5482-byte source (`RippedAssets/.../penguin/
iceTwister5.png`) -- confirmed by direct byte comparison (`Buffer.compare`), not just "looked wrong."
Root cause: this was the one icon this session that got spliced into `index.html` by pasting a many-
thousand-character base64 string directly into an `Edit` tool call's `new_string` -- something in that
path silently corrupted it (the other 2 new icons added the same session, `arcticFrost1`/`doubleSpell5`,
were checked immediately after and came back byte-EXACT against their own source files, so this isn't a
universal risk with every base64 insert, just this one instance). **Fixed the RIGHT way this time,
worth reusing for any future icon extraction**: read the source PNG and splice its base64 into
`index.html` entirely inside one Node script (read old file, `indexOf`/slice around the marker string,
write the new file) -- never round-tripping the giant base64 string through a manually-typed `Edit` tool
call at all. Re-verified byte-exact via `Buffer.compare` after the fix, then visually via the `Read` tool
on the re-extracted bytes (the actual ice/tornado swirl art with its "C"-tier badge, matching every other
skill icon's art style) before trusting it. Also re-ran the full script-parses-OK check and a live
Playwright screenshot on Tornado specifically. Published to the same Artifact URL, same 🦊 favicon.
**Lesson for this file generally**: after any icon extraction, verify with a byte-for-byte comparison
against the source file, not just "did the Edit tool report success" -- a corrupted-but-still-valid-PNG
can pass a naive header/footer sanity check and only be caught by rendering it or diffing the bytes.

### 2026-08-20, same day: lckProc's Simulate integration -- each hit rolls its own proc, shown as a small blue label

User asked for the Damage Formula chip's multi-hit Simulate/Test popup to roll each individual hit's own
`lckProc` chance independently (not just show the chip's aggregate %), and label a proc'd hit with small
blue "frost" text next to that hit's own number. Scoped naturally to Arctic Wind and Tornado -- the only
2 skills that have BOTH a real `dmg` field (so a Simulate button exists at all) AND a `lckProc` field;
Ice Shield/Double Cast have `lckProc` but no `dmg`, so neither has ever had a Simulate button to extend.

**New `rollLckProc(skill)`** (`index.html`, right before `rollOneHit`): a deliberately SEPARATE
`Math.random()` roll from every damage-pipeline roll in `rollOneHit` -- matches source, `lckAdjust`'s
formula has no shared RNG state with `dmgAdjust`/`defAdjust`. Re-reads LCK and re-checks the dep's live
toggle state on every call (same as the chip itself) -- OFF is a hard `false`, never even rolled, not a
low-probability roll, matching `arcticFrostLv<=0`'s real short-circuit in source.

**Wired into `revealMultiHit`**: `hit.proc = rollLckProc(selected)` rolled once, right alongside
`hit.value`, under the SAME "already rolled" guard (`hit.value !== null`) -- so Tornado's 50+ independent
ticks each get their own independent frost roll, not one roll shared across the whole group. A small
`<span class="sk-multihit-frost">frost</span>` (9px, `--stat-int` -- this tool's existing blue token,
reused rather than inventing a new color per the user's own "small blue" spec) is appended right after
the digit `<img>`s, inside the SAME flex row (`.sk-multihit-item`/`.sk-multihit-total` are both already
`display:flex`) -- no new absolute positioning, so it can't collide with a neighboring grid cell
regardless of digit count. Handled for BOTH shapes: multi-hit (`group.hits.length>1`, appended to each
`.sk-multihit-item`) and the single-hit total (`group.hits.length===1` -- unreachable by any currently
shipped skill, since neither current `lckProc` skill happens to also be single-hit, but implemented
symmetrically for whichever skill needs it next, cheap to include now). Hardcoding the text "frost" is
accurate for both skills that can reach this code path (Arctic Wind and Tornado's `lckProc` both really
apply `"frost"`, confirmed in the earlier same-day research pass) -- not a guess, and not reused for any
`lckProc` skill whose payoff isn't actually frost (Double Cast's, if it ever grew a Simulate button, is
NOT frost -- would need its own label, not this hardcoded string).

**Verified via direct DOM inspection, not just eyeballing a screenshot** (Playwright, local dev server,
LCK 128 both times): Arctic Wind (4-8 hits depending on Deadly Frost toggle) -- 8 hits, 3 procs
(`frostCount:3`), each `.sk-multihit-frost` confirmed rendering the literal text "frost" in
`rgb(29,78,216)` (`--stat-int`'s exact light-mode hex, `#1d4ed8`, confirmed via `getComputedStyle`, not
assumed from the CSS rule alone). Tornado (51 hits rolled that trial) -- 9 procs (~17.6%, consistent with
the chip's own displayed 18% at this LCK), no console errors, no layout collisions between adjacent grid
cells even with Tornado's tighter 3-digit-number-heavy grid.

**Process note, worth remembering for this file's own Simulate/multi-hit code specifically**: the FIRST
two verification attempts this pass found `groupCount:0`/`itemCount:0` after clicking Test and checking
in a SEPARATE follow-up tool call -- initially read as "the click handler isn't firing," a real scare
given zero console errors either way. Root cause, confirmed by re-testing with the click AND the DOM
check inside the SAME `browser_evaluate` call: the popup's own lifecycle (reveal over ~300ms, then a
real 2000ms float/fade, then `wrap.remove()`) is short enough that the round-trip latency BETWEEN two
separate MCP tool calls (click, then a follow-up check) can exceed it entirely, so the group had already
been created, fully played out, AND removed before the second tool call's JS ever ran -- nothing was
ever broken. Confirmed the same for screenshots: a screenshot taken via a separate tool call after
clicking Test reliably missed the popup (either not-yet-rendered or already-faded depending on timing),
fixed by injecting a temporary `animation-play-state:paused; opacity:1 !important` style rule inside the
SAME evaluate call that performs the click, freezing the popup's visual state so a LATER, slower
screenshot call still captures it correctly. **For any future verification of this tool's Simulate/
multi-hit popup specifically: always click-and-check (or click-and-freeze-then-screenshot) within one
single `browser_evaluate` call, never split across two separate tool round-trips** -- this file's own
2s-float-then-remove design is simply too fast for that pattern to be reliable here, unlike every other
UI verification elsewhere in this project. Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-20, same day: War Factory split into 4 separate `SKILLS` entries, plus a real engine gap and a real citation fix found along the way

User asked to treat Mole's War Factory as multiple skills ("War Factory - Saw Machine", "War Factory -
Bazooka", etc.) instead of the single opaque-prose entry it had been since the original 27-skill Mole
pass (`dmg` was a plain description string, no chips at all). Re-verified every sub-attack directly
against source rather than trusting the existing citations blindly (per this file's own standing "verify
before trusting a citation" rule) — this caught 2 real things the prior research pass got wrong or
missed, described below, alongside a clean split into 4 new entries.

**Re-verified citations (all confirmed correct)**: sawMachine `1.5×ATK + talAdjust(15)` KO=0
(`Mole.cs:40770`), bazooka `ATK + talAdjust(50)` KO=5 (`Mole_bazooka.cs:228`), teslaCoil `talAdjust(30)`
AoE up to 7 pulses (`Mole.cs:42065`, loop bound `:42034`), rollerMachine `3×ATK` KO=0 (`Mole.cs:42430`).

**Real citation fix**: the `paralysis` proc (`RPC_AddStatus("paralysis",2,3,...)`, `Mole.cs:42109`) was
previously attributed to rollerMachine in both `mole-skill-reference.md` and
`mole-skill-damage-reference.md`. It's actually teslaCoil's — found by locating the enclosing `internal
sealed class` declaration for line 42109 (`$RPC_teslaCoil$24002`, spanning `Mole.cs:41581-42197`) versus
where `$RPC_rollerMachine$24015` actually starts (`:42198`, i.e. AFTER the paralysis line). Both reference
docs corrected. Not modeled as a chip (no status-effect chip exists in this tool), same "cite it, don't
build UI for it yet" treatment as every other untracked incidental proc.

**Real new finding: rollerMachine hits twice per activation, not once.** Two separate `hit(4344, ...)`
call sites exist in 2 different sequential coroutine states of the same class (`Mole.cs:42430` and
`:42643`, identical `3×ATK` formula both times) — confirmed via `case N:` state-machine boundaries, not a
dead/duplicate branch. Modeled as `hitCount:()=>2`.

**Real new finding, investigated and resolved, not left as a guess**: the dispatch table's action-code
block (`Mole.cs:5849-5966`, the network-replication mirror for all 5) doesn't stop at rollerMachine's
4344 — `4345`/`-4345`/`4346` dispatch to `RPC_cartBomb`/`_hit`/`_update`, immediately adjacent in the same
contiguous numbering. First read as a possible missed 5th combat sub-attack ("Cart Bomb"); investigation
found NO damage-dealing call anywhere in its ~1080-line coroutine or its tiny companion
`Mole_cartBomb.cs` (pure transform-tracking, no combat logic) — but cross-referencing against
`mole-skill-reference.md`'s OWN prior research (which had already found this, unprompted, before this
session even started) resolved it cleanly: **`RPC_cartBomb` is War Factory's real cast/deploy coroutine**
— casting the skill sets `myCommand="cartBomb"`, and the real 180s cooldown is armed at `Mole.cs:43394`
*inside* this same coroutine (vs. the other 4's short `agiAdjust(3)` internal attack-cadence re-arm,
`Mole.cs:40814`/`:41388`/`:41900`/`:42687`). No damage call because it's a summon action, not an attack —
correctly excluded from the 4 new damage entries, not an open item needing a future pass.

**New engine case: `atkCoeff` on a FLAT (non-`talAdjust`) base.** Every prior `atkCoeff` skill (Mega
Punch etc.) adds it on top of a `talAdjust(...)` term; `rollOneHit`/`dmgCalcPostFn` already applied
`atkCoeff` unconditionally regardless of shape, so the CALCULATED Raw/Final Damage numbers for a flat-base
skill were always correct even before this — but `renderOneDmgFormula`'s flat-shape branch never knew
about `atkCoeff` at all, so the DISPLAYED formula text silently dropped the ATK term entirely. Fixed by
computing a flat-branch `atkItem` the same way the `talAdjust` branch already does, and — since Roller
Machine's real base is `dmg:"0"` (no talAdjust component whatsoever) — omitting the "0" base term
entirely when it's exactly 0 and an `atkItem` exists, rather than always showing a spurious "0 +" prefix.
Verified live: Roller Machine's Damage Formula now shows a clean `384(3ATK)` at ATK=128, not `0 +
384(3ATK)` or a silently-missing ATK term.

**4 new `SKILLS` entries** replacing the single `mole_warFactory` (all share `icon:"mole_warFactory5"` —
confirmed via `ls` on `RippedAssets` that no dedicated sub-attack icons exist, these are AI behaviors of
one deployed structure, not separately-iconed learnable skills — and all share `cd:180, cdWrapped:true`,
the structure's own deploy cooldown, with a `dmgNote` on each clarifying it's not a per-attack cooldown):
`mole_warFactory_sawMachine`, `_bazooka`, `_teslaCoil` (`hitCount:()=>7`), `_rollerMachine`
(`dmg:"0"`, `atkCoeff:3`, `hitCount:()=>2`). Search suggestions show all 4 as distinct "War Factory - X"
entries, matching the user's requested naming.

Verified live (Playwright, local dev server) for all 4: Saw Machine `15 + 192(1.5ATK) + 38(0.3TAL)` at
ATK/TAL=128 (Damage Formula), Raw Damage `245-253`, Final Damage `262-301`; Roller Machine's flat+atkCoeff
fix confirmed (`384(3ATK)`, no spurious base term); Tesla Coil confirmed `hitCount:7` both in the
Simulate button's title ("Test 7 hits") and the actual multi-hit popup (7 `.sk-multihit-item` elements,
zero console errors) — **one real false alarm along the way**: the FIRST check of Tesla Coil's title
showed "Test one hit" despite correct data, traced to a stale browser cache from earlier in the same
Playwright session (not a fresh `Cache-Control: no-store` miss — the Node server's header was already
correct) — resolved by a hard cache-busted reload (`?v=2`), matching this project's own repeatedly-
documented "don't trust a still-broken recheck without ruling out stale cache first" lesson. Both
`12t_reference/mole-skill-reference.md` and `mole-skill-damage-reference.md` updated with the corrected
citations and the new 4-entry breakdown. Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-20, same day, immediate follow-up: Cart Bomb added as a real 5th entry, and 2 hit-count corrections found by re-checking properly

User pushed back on the previous pass's conclusion twice: (1) "do the cart bomb skill too" -- a direct
rejection of "no damage found there, correctly excluded"; (2) "check the hit count of every War Factory
skill, always use theoretical max hit count" -- a general instruction to re-audit ALL 5, not just accept
the counts already shipped. Both pushes were right, and both caught real, previously-shipped mistakes.

**Cart Bomb DOES deal real damage -- the previous pass's "no damage call found" was from an incomplete
read, not a genuinely absent mechanic.** Re-reading `Mole_cartBomb.cs` fully (192 lines -- the earlier
pass stopped around line 80, at what looked like the natural end of a simple tracker `MonoBehaviour`)
found the actual trigger in `Update()` (`:52-161`): the summoned cart tracks the caster for up to 3 real
seconds, then calls `mole.RPC_cartBomb_hit(...)` (`:127`) while `actionState=="attack"` and
`myCommand=="cartBomb"`. That method (`Mole.cs:14128-14235`, a plain `void`, not a coroutine -- no
obfuscated state-machine wrapper to miss this time) does a real AoE burst: `talAdjust(150)` -- the
single largest base value of any War Factory sub-action -- with a real linear distance falloff
(`1 - 0.5×(distance/radius)`, radius `6+1.5×getExtraPowderLv()`) and KO=30. Added as
`mole_warFactory_cartBomb`. This ALSO meant correcting the prior session's own citation in
`mole-skill-reference.md` ("not a 5th combat sub-attack" -- written earlier the SAME day, now wrong) and
softening `mole-skill-damage-reference.md`'s framing from "confirmed no damage, correctly excluded" to
the real finding.

**Saw Machine: `hitCount:4`, was un-set (defaulting to 1).** A real `for`-loop (`$i$23977=1` init,
`++` increment, `if ($i$23977>4)` exit, `Mole.cs:40568/40594/40671`) cycles through 4 different
`Damage.FindRecTarget` hitbox shapes (`:40710-40746`) -- a genuine 4-phase swing combo, not a one-time
random pick among 4 shapes. Missed the first time because the loop counter was assigned to an
intermediate `$$switch$...` variable one line before the `if` chain that reads it, one hop removed from
a direct grep for the hitbox-selection code.

**Roller Machine: `hitCount:11`, was `2` (already wrong once this same session).** The immediately
prior correction (same day) had already revised this from an implicit 1 up to 2, based on finding 2
distinct `hit(4344,...)` call-site TEXTS in the decompiled output. That was still wrong -- tracing the
actual control flow (not just grepping call-site text) found 1 initial hit-scan on roll-start PLUS a
real counter-bounded loop (`$i$24021=0` init at `Mole.cs:42494`, `++` at `:42520`, `if
($i$24021>=10)` exit at `:42597`) that re-runs the identical hit-scan-and-hit code block once per pass
while `i<10`. **The general lesson, worth remembering for any future obfuscated-loop read in this
codebase**: a compiler-generated coroutine state machine revisits the SAME case-label code TEXT on every
loop iteration rather than duplicating it N times -- counting distinct call-site occurrences in the
decompiled text answers "how many different code locations call this," not "how many times does this
run." Only tracing the actual state transitions (init/increment/exit-bound triple) answers the real
question. This is the second time in one session a "count the textual occurrences" shortcut produced a
wrong number (first Roller Machine's own initial 1→2 correction, now found to still be wrong at 2→11) --
don't repeat this shortcut for hit-count questions in this file again; always find the actual loop bound.

**Process lesson tying both findings together, added to the top-level `CLAUDE.md`'s "Reading the
decompiled source" section this same session** (see that file's own dated update): "checked the
companion file" and "read the companion file to its actual end" are not the same claim -- both real
misses this pass came from treating a plausible-looking stopping point (end of a grep match, apparent
end of a simple-looking file section) as if it were the actual end of the relevant logic.

Verified live (Playwright, local dev server, cache-busted fresh navigations throughout after the
previous pass's stale-cache scare): Cart Bomb shows `150 + 384(3TAL)` at TAL=128 (Damage Formula),
Raw Damage `534-612`, Final Damage `570-688`, KO `30` -- easily the strongest single hit of the 5. Saw
Machine's Simulate button now reads "Test 4 hits" and produces 4 `.sk-multihit-item` elements. Roller
Machine's now reads "Test 11 hits" and produces 11. Zero console errors across all checks.
`mole-skill-reference.md` and `mole-skill-damage-reference.md` both updated with the corrected counts,
the real Cart Bomb formula, and the state-machine-loop process lesson. Published to the same Artifact
URL, same 🦊 favicon -- 5 skills now exist under "War Factory - X" total.

### 2026-08-20, same day: Barrel Bot's own moveset split into 8 separate skills, mirroring War Factory

User asked for the same treatment on Mole's Barrel Bot summon: normal attack, mega hammer, mega punch,
"mega drill missiles," barrel cannon -- and explicitly asked to re-verify whether each move's own
cooldown/timeout is `agiAdjust`-wrapped, suspecting it might not be for at least some of them.

**Found via a companion file never previously read for this tool, `BarrelBotAI.cs`** -- its own
`AI_attack(...)` is the real move-selection dispatch (distance-to-target + a per-move `isTimeOut(<key>)`
check), and it revealed the moveset is bigger and more tangled than the user's own framing:
- **7 real moves, not 5** -- `chopper` is real and verified but wasn't named; added anyway per the
  "check every field" policy set 2026-08-19, flagged in its own `dmgNote` in case it wasn't wanted.
- **"mega drill missiles" is 2 genuinely separate mechanics** -- Mega Drill and Missile have different
  timeout keys, different formula shapes, and different upgrade trees (Missile's own `MissileLv`,
  hasSkill 351-354, is a SEPARATE unlock tree from Mole's personal Missile skill). Modeled as 2 entries,
  not folded into one.
- **"Barrel Cannon" is actually 2 separate activations** -- a single reactive shot (`cannon`, 9s
  agiAdjust, the one the normal AI attack rotation uses) and a 10-shot burst mode (`cannonForm`, 90s
  agiAdjust to trigger, then autofires the SAME shell every 0.5s up to 10 times or until the target's
  lost) -- found by precisely re-deriving both coroutines' real class boundaries after an initial broad
  grep across their combined line range conflated the two `addTimeOut` calls together. This also
  resolves this project's own previously-open item ("BarrelCannon's shell-impact formula... could not be
  traced to a citable line") -- the real call was reachable only via `RPC_cannon` → `RPC_cannon_fire` →
  the projectile's own `OnTriggerEnter` → `RPC_cannon_hit`, a longer chain than a direct grep finds.

**8 total entries, all sharing `icon:"mole_barrelBot4"`** (confirmed via `ls` -- only `barrelBot0-4.png`
exist, no per-move icons, same situation as War Factory): Normal Attack, Mega Punch, Mega Hammer,
Chopper, Missile, Mega Drill, Barrel Cannon, Cannon Form.

**Cooldown-wrapping, checked individually per the user's explicit ask -- 2 of 8 flat, 6 agiAdjust**:
`nAttack` (flat 3s) and `drill` (flat 9s) are NOT agiAdjust-wrapped, confirming the user's suspicion for
those two specifically; `punch`/`hammer`/`chopper`/`missile`/`cannon`/`cannonForm` all ARE
agiAdjust-wrapped -- reported precisely per-skill rather than assuming a uniform answer either way.

**New engine flag: `dmgAdjustSkip`.** Missile's real damage call
(`BarrelBot_missile.cs:349`, only found on a full read of that companion file, not the main coroutine)
bypasses `hit()` entirely but MANUALLY re-applies `defAdjust` before calling `RPC_AddDamage` directly --
a 3rd pipeline shape, distinct from the existing `penetrating` flag (which skips both `dmgAdjust` AND
`defAdjust`). This is one of the "3 other skills that manually re-apply defAdjust after bypassing hit()"
a whole-file `defAdjust` grep in `CharacterControl.cs` found back when Flame Turret/Carnival's own
`penetrating` flag was first verified, but never identified until now. Added `skill.dmgAdjustSkip:true`,
checked in both `rollOneHit` and the Final Damage range-calc block right alongside the existing
`penetrating` check -- when set, `dmgAdjustAtRoll` is skipped but `defAdjustRoll`/`defAdjustAtN` still
run normally.

**2 new process lessons, both added to the top-level `CLAUDE.md`'s "Reading the decompiled source"
section this same session**: (1) use `ls`/`find` via Bash to check for a companion file in this repo,
never the `Glob` tool -- `DecompiledSource/` is gitignored, so `Glob DecompiledSource/BarrelBot*.cs`
silently returned nothing even though 4 real files exist there, indistinguishable from "no companion
file" unless you know to distrust it; (2) when a broad grep spans what looks like one class's line
range but actually covers two adjacent ones (as happened conflating `RPC_cannon`/`RPC_cannonForm`),
findings from that grep need re-verifying against each class's own precise boundary before trusting
which one a given citation actually belongs to.

Verified live (Playwright, local dev server, all fresh cache-busted navigations): Missile at rank 4 --
`30 + 76(0.6TAL)` at TAL=128, Final Damage `114-132` (visibly narrower than Raw Damage's own roll would
suggest for a normal skill, consistent with `dmgAdjustSkip` correctly omitting the extra attacker-LCK
spread `dmgAdjust` would otherwise add), Simulate "Test 4 hits" at rank 4 dropping to "Test one hit" at
rank 1 (hitCount correctly tracks the live rank selector). Normal Attack -- Cooldown "3s / fixed 3s"
(correctly shown unwrapped/muted, distinct from every agiAdjust-wrapped move's range display), `64
(0.5ATK)`. Chopper -- `15 + 38(0.3ATK) + 38(0.3TAL)` at max rank, Cooldown `27.23-30s / base 60s`.
Cannon Form -- Simulate "Test 10 hits"/10 real popup items, Cooldown `40.85-45s / base 90s`. Zero
console errors across every check. `mole-skill-damage-reference.md` updated with the full moveset,
every formula/cooldown citation, and the resolved BarrelCannon open item. Published to the same
Artifact URL, same 🦊 favicon -- 13 skills now exist under Mole's own summon-moveset entries total
(5 War Factory + 8 Barrel Bot).

### 2026-08-20, same day, immediate follow-up: Barrel Bot has its own independent stat block -- global inputs were silently wrong for all 8 moves

User follow-up on the pass above: "agiAdjust-wrapped in this case use Mole or BarrelBot Agi", then
"you might have to find out Barrel Bot stats, doubleBotskillDep and synchromole skillDep" -- a direct
challenge to an assumption every one of the 8 new Barrel Bot entries had been silently making: that
`agiAdjust`/`talAdjust` inside `BarrelBot.cs` read the tool's existing global AGI/TAL/ATK/LCK inputs
(i.e. Mole's own stats), the same way every other Mole skill in this tool does.

**That assumption was wrong.** `BarrelBot.cs:32` (`this.mChar = this.GetComponent<CharacterControl>()`)
confirms Barrel Bot is a fully separate `CharacterControl`, not a proxy for Mole's -- every stat read
inside `BarrelBot.cs` (all 8 moves' cooldown/damage formulas) uses ITS OWN fields, never reaching back
into Mole's. **Direct answer to "Mole or BarrelBot Agi": BarrelBot's own, and it's a flat `10` at every
rank** (`BarrelBot.cs:47-152`, rank-gated by prefab `type` string "BarrelBot1"-"4": `atk`/`def`=`15×rank`,
`vit`/`tal`/`lck`=`10×rank`, `agi`/`mag`/`cha`=flat `10` always) -- dramatically lower than this tool's
default player-AGI input of 128, a real and large divergence every one of the 8 Cooldown chips had been
silently misrepresenting before this pass.

**Also resolved this doc's own previously-open item, `doubleBot5`.** `Mole.cs:12708-12759`: adds
`floor(0.5×Mole's own character level)` to ALL 8 of Barrel Bot's stats at once, additive on top of the
rank-gated baseline -- NOT the overwrite mechanism `hiddenTurret5` uses for Auto Gyro Gun (a different
passive despite similar tooltip wording; confirmed by actually reading the addition vs. the earlier
overwrite, not assumed from the shared "+level" phrasing). At Mole LV 100 this is `+50` to every stat,
including AGI (10→60) -- meaningful enough to visibly narrow the Cooldown roll-spread, not just bump
damage.

**`synchroMole` rank 2 also sweeps Barrel Bot, confirmed directly rather than assumed from the AutoGyroGun
precedent.** `Mole.cs:13330-13368`'s type-match check covers BOTH `"AutoGyroGun1-5"` AND
`"BarrelBot1-5"` in the same sweep, adding `floor(Mole's own TAL)` to `atk` only (not tal/agi/lck).

**Implementation**: new `barrelBotOwnStats(doubleBotOn, synchroMoleOn, moleLV, moleTAL)` top-level
function plus `skill.ownStats:true` (added to all 8 Barrel Bot entries) -- overrides the tool's
ATK/TAL/AGI/LCK `let`-declared locals in all 3 places that read them (`renderHero`, `rollOneHit`,
`renderOneDmgFormula`), cascading for free into the Cooldown chip's `agiAdjustRange` call and every
Damage Formula/Raw Damage/Final Damage calc, exactly the same way `ownLck`/`attackerLCK` already did for
Auto Gyro Gun's own single-stat override (2026-08-18) -- this is the same pattern generalized to 4 stats
at once, not a new mechanism. Two new dep objects, `MOLE_DOUBLEBOT_DEP` (`id:"doubleBot"`, new icon
`mole_doubleBot5`) and `MOLE_SYNCHROMOLE_BARRELBOT_DEP` (`id:"synchroMole2"`, deliberately reusing
AutoGyroGun's own existing `synchroMole2` id and icon so the two skills' toggles stay linked, same
precedent as Mine Lover/Mega Drill) -- both wired into the `dmgToggles` array (`renderHero`) gated on
`selected.ownStats`, rendering in the Damage Formula chip header via the same generic
`renderDmgToggle`/`.sk-dep-toggle` mechanism every other dep uses. `mole_doubleBot5`'s icon needed one
re-extraction after an Edit-tool base64 paste produced a same-length-but-wrong-bytes corruption (same
family of bug as Ice Twister's icon earlier this session) -- fixed by splicing the real file's base64
into `index.html` via a Node script instead of pasting through Edit, then confirming byte-exact via
`Buffer.compare()` before trusting it.

**Verified live** (Playwright, local dev server): Barrel Cannon's ATK term computed to exactly `238`
(`357(1.5ATK)`, hand-derived: baseline `atk=60` → `+50` Double Bot → `110` → `+floor(128)` Synchro Mole
→ `238`) both toggles default ON; toggling Double Bot off dropped it to the hand-predicted `188`
(`282(1.5ATK)`). Mega Punch's Cooldown chip showed `7.46-8.17s` against a `base 12s` -- hand-verified
bit-exact against `agiAdjustRange(12, 60, 90)` using BarrelBot's own rank-4 AGI(60)/LCK(90) with Double
Bot active, confirming the override reaches the Cooldown chip correctly and not just the damage chips.
**Cross-skill linked-toggle confirmed**: toggling Synchro Mole OFF from Auto Gyro Gun's own card
(`100+128(1LV)(TAL)` → `100(1LV)`) carried over automatically to Barrel Bot Mega Punch's own Damage
Formula on the next selection with no further clicks (`24+44+43(0.4ATK)(0.48TAL)`, ATK term correctly
reflecting the OFF state) -- confirms `depRanks` sharing works across this pairing exactly like the
Mine Lover (Landmine↔Stun Mine) and Mega Drill (Mega Punch↔Mega Hammer) precedents. Zero console errors
throughout. `mole-skill-damage-reference.md` updated with a new "Barrel Bot has its own independent stat
block" section (full citations, resolves the doc's own `doubleBot5` open item, item renumbered to just
King Kaiser). Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-20, same day, immediate follow-up: revisedArt5 never touches any Barrel Bot move's cooldown -- a real bug, not just a research question

User asked directly: "revisedArt affects BarrelBot cooldowns?" Traced this to source rather than
inferring it from the stat-isolation pattern just established above -- a different mechanism (a Class C
passive check, not a stat field) could in principle have been wired differently.

**Answer: no, and it's structural, not conditional.** `revisedArt5`'s 12% CD reduction lives INSIDE
`CharacterControl.addTimeOut()` itself (`CharacterControl.cs:20102-20110`), gated by a bare
`this.hasSkill(424)` at the top of the function -- `this` being whichever `CharacterControl` the method
is called on. Every one of Barrel Bot's 8 moves calls `addTimeOut` on `$self_.mChar`
(`BarrelBot.cs:2480/2891/3286/3825/4382/4818/5278/5639`) -- Barrel Bot's OWN `CharacterControl`
(`BarrelBot.cs:32`, the same instance already confirmed to carry its own stat block in the pass above).
`hasSkill()` checks `this.mSkillList`, only ever populated via `readSkill(int[])`
(`CharacterControl.cs:24135`, the server-sync entry point) -- never called anywhere in
`BarrelBot.cs`/`BarrelBotAI.cs`. Barrel Bot's own skill list is therefore permanently empty, so
`hasSkill(424)` always returns `false` for its own moves regardless of whether Mole has actually learned
Revised Art -- the reduction is structurally unreachable, not just usually inactive.

**Contrast confirmed, not assumed**: the base `mole_barrelBot` summon's own 240s recast (shared "assemble"
coroutine, `Mole.cs:23429`) and War Factory's 5 sub-attacks' shared 180s structure-deploy cooldown
(`Mole.cs:43394`) both call `addTimeOut` on `$self_.mChar` where `$self_` IS the `Mole` class instance
itself (both coroutines live directly in `Mole.cs`, not a separate structure's own `CharacterControl`) --
so revisedArt correctly DOES apply to both of those.

**Real bug found and fixed**: all 8 "Barrel Bot - X" `SKILLS` entries had shipped with
`revisedArtExempt:false` (the default every other skill in the tool uses), letting the revisedArt toggle
incorrectly shave 12% off their displayed cooldowns. Flipped all 8 to `revisedArtExempt:true` -- one-line
data changes, no new mechanism needed (`revisedArtExempt`/`applyRevisedArt` already existed and already
supported this exact per-skill opt-out, just never turned on for these 8). Verified live (Playwright):
toggling revisedArt changed War Factory Bazooka's Cooldown `72-80s` ↔ `81.7-90s` (exact `×0.88` ratio)
while Barrel Bot Mega Punch's stayed fixed at `7.46-8.17s` regardless -- confirms the fix actually
discriminates per-skill rather than accidentally disabling the toggle everywhere. `mole-skill-damage-
reference.md` updated with a new "revisedArt5 does NOT reduce any Barrel Bot move's own cooldown" section
(full citations). Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-20, same day: Mole's "Barrel Cannon" merged into Barrel Bot's "Cannon Form" -- then split back apart along the Cooldown/Damage line

User: "remove Mole Barrel Cannon skill, use Barrel Bot - Cannon Form Skill in its place and rename the
skill to Cannon Form, use cannon form icon, this is the only move that mole can command and BarrelBot
didn't cast on their own will, so we will treat it like Mole is the caster but use BarrelBot own stats."

**Background**: `mole_barrelCannon` had shipped since the original 27-skill Mole pass as a placeholder --
Mole's own real cast (`RPC_barrelCannon`, `Mole.cs:39835-40208`, `cd:120`, `ko:"1"`) with NO damage data,
because the shell-impact formula couldn't be traced at the time. That gap was closed later the same
session by the Barrel Bot moveset-split pass, which found the real `1.5×ATK` formula but attributed it to
a brand-new, separately-named `SKILLS` entry (`mole_barrelBot_cannonForm`, "Barrel Bot - Cannon Form")
instead of folding it back into the original row -- leaving two disconnected entries for what's really one
skill. Worse, "Barrel Bot - Cannon Form" was framed alongside Barrel Bot's other 7 genuinely-autonomous
AI-picked moves, when Cannon Form is actually the one move Mole explicitly commands (`Mole.cs:40196-40208`
sets `myCommand="barrelCannon"` on MOLE's own `mChar`) -- the AI never decides to enter it on its own.

**Fix (1st pass)**: deleted the empty `mole_barrelCannon` placeholder, renamed/re-attributed
`mole_barrelBot_cannonForm` to take its id and array position (right after Mega Drill, among Mole's own
moveset, not the 7 autonomous Barrel Bot moves), renamed the display name to "Cannon Form" (dropping the
"Barrel Bot -" prefix, matching Mega Punch/Mega Hammer/Chopper/Missile/Mega Drill's own naming even though
those ALSO reuse Barrel Bot's formulas), and swapped the generic shared `mole_barrelBot4` icon for the
real, distinct skill-tree icon `mole_barrelCannon5` (confirmed via `find RippedAssets -iname
"*cannonform*"` that no dedicated icon file exists -- only animation clips -- so `barrelCannon5.png` is
genuinely the correct real asset). Kept `ownStats:true`/`cd:90`/`revisedArtExempt:true` unchanged, per a
literal read of "use BarrelBot own stats."

**Immediate correction, same message exchange**: user caught that the literal reading above was too
blunt -- "since BarrelCannon skill is casted by the Mole, revisedArt should has an effect on it, and
cooldown use Mole AGI and LCK stat, but the damage formula uses BarrelBot stat." Right call: Cannon Form's
own cooldown-ARMING call (`addTimeOut("barrelCannon", agiAdjust(120))`, `Mole.cs:40199`) genuinely runs on
MOLE'S OWN `CharacterControl`, same as every other Mole-cast skill -- only the shell's own damage payload
(`RPC_cannon_hit`, `BarrelBot.cs:1889`) runs on Barrel Bot's own `CharacterControl`. A single skill now
needs stats split across two different actors depending on which chip is being computed -- the first pass
this session to need that.

**New `ownStatsDmgOnly:true` flag** (narrower than the existing `ownStats:true`): overrides ONLY ATK/TAL
(and, via a new `bbOwnLCK` local, the Final Damage chip's attacker-LCK `dmgAdjust` roll) with Barrel Bot's
own stat-block values; AGI and the Cooldown chip's own LCK are deliberately left as the tool's normal
global Mole inputs. `renderHero`'s stat-declaration block gained an `else if (selected.ownStatsDmgOnly)`
branch (only setting `ATK`/`TAL`/`bbOwnLCK`, not `AGI`/`LCK`), and its separate Final-Damage `attackerLCK`
ternary gained a 3rd branch (`selected.ownStatsDmgOnly ? bbOwnLCK : LCK`). `rollOneHit`/
`renderOneDmgFormula` needed no equivalent split -- neither function ever touches AGI/Cooldown at all, so
just widening their existing `if (skill.ownStats)` checks to `if (skill.ownStats || skill.ownStatsDmgOnly)`
was already correct, since both already only override TAL/LCK/ATK. `cd` reverted to `120`,
`revisedArtExempt` flipped back to `false`. The `dmgToggles` gate for `MOLE_DOUBLEBOT_DEP`/
`MOLE_SYNCHROMOLE_BARRELBOT_DEP` was widened the same way, since Double Bot/Synchro Mole still affect
Barrel Bot's own ATK/TAL/LCK feeding this skill's damage side.

Verified live (Playwright, local dev server) both before and after the correction: pre-correction matched
the (wrong) fully-Barrel-Bot-stats version exactly (`357(1.5ATK)`, Cooldown `55.92-61.28s / base 90s`,
hand-verified against `agiAdjustRange(90,60,90)`, revisedArt toggle changing nothing). Post-correction:
Cooldown now `54.47-60s / base 120s` (hand-verified against `agiAdjustRange(120,128,128)`, the tool's
default Mole AGI/LCK inputs), and toggling revisedArt now correctly moves it (`54.47-60s` → `48-53s`, the
expected `×0.88` ratio) -- while Damage Formula/Raw Damage/Final Damage stayed byte-identical throughout
(`357(1.5ATK)` / `357` / `381-404`), confirming ATK and the attacker-LCK roll are still correctly reading
Barrel Bot's own stats, unaffected by the Cooldown-side fix. Both stat-boost toggle icons still render and
still drive the damage numbers. Zero console errors throughout. `mole-skill-damage-reference.md` updated
with the full merge/correction narrative and citations. Published to the same Artifact URL, same 🦊
favicon.

### 2026-08-20, same day: "Barrel Bot Stats" chip replaces the exempt caption, and "Cannon Form" renamed back to "Barrel Cannon"

User: "All BarrelBot - XXXX skills, remove the text explaining revisedArt exempt, and design a stat table
displaying BarrelBot stat values, so it is more transparent for the user, this is a special case, feel
free to use the area for casttime, duration, and lckAdjust chips." Then, mid-turn: "do this for Cannon
Form skill too, and also rename this skill to \"Barrel Cannon\"."

**Removed**: the generic `<p class="sk-stat-exempt">Exempt from revisedArt5</p>` caption (already existed
tool-wide, rendered whenever `selected.revisedArtExempt` is true) -- suppressed specifically for
`selected.ownStats` skills (`(selected.revisedArtExempt && !selected.ownStats) ? ... : ""`), confirmed via
grep that all 7 `revisedArtExempt:true` entries in the whole tool are exactly the 7 remaining "Barrel Bot
- X" moves, so nothing else is affected.

**Added**: a new "Barrel Bot Stats" chip (`.sk-stat-bb{grid-column:2 / span 3}`) filling the blank
Cast-Time/Duration/LCK-proc columns (2-4) no Barrel Bot move ever populates -- a `.sk-bb-table` internal
4-column mini-grid of ATK/TAL/AGI/LCK label+value pairs, sourced from the exact same `bb` object
(`barrelBotOwnStats()`'s return, newly captured into a `bbStatsTable` local right where `ownStats`/
`ownStatsDmgOnly` already compute it) that drives the Cooldown/Damage chips -- live-reflects Double
Bot/Synchro Mole toggle state for free. Verified live: Mega Punch shows `ATK 238 / TAL 90 / AGI 60 / LCK
90` at default state, drops to `188/40/10/40` with Double Bot off -- exact matches to every previously
hand-derived `barrelBotOwnStats` value this session. A `getBoundingClientRect` check across all 4
label/value pairs confirmed pixel-identical row alignment -- a screenshot had made AGI/LCK look vertically
offset from ATK/TAL, which turned out to be the decorative Mole line-art backdrop (`.sk-art`) crossing
through that exact region, not a real bug. Worth remembering: this tool's own background art can visually
interfere with a screenshot-only check -- measure with `getBoundingClientRect` before trusting an
eyeballed alignment complaint against a chip that overlaps the art.

**Extended to Cannon Form (renamed back to "Barrel Cannon" same message)**: this skill's
`ownStatsDmgOnly` only sources ATK/TAL/attacker-LCK from Barrel Bot, not AGI (Cooldown uses Mole's own,
per the immediately-preceding correction) -- reusing the 4-column table would misrepresent AGI as
Barrel-Bot-sourced. New `.sk-bb-table-3` variant (`grid-template-columns:repeat(3,1fr)`), 3 columns
(ATK/TAL/LCK only), distinct caption spelling out the split ("Barrel Bot's own ATK/TAL/LCK for damage —
Cooldown above uses Mole's own AGI/LCK instead"). Verified live: `ATK 238 / TAL 90 / LCK 90`, Cooldown/
Damage numbers unchanged from before this pass. `revisedArtExempt` is already `false` for this skill (Mole
is the real caster there), so the exempt-caption removal was already a no-op for it.

**Rename**: `"Cannon Form"` -> `"Barrel Cannon"` -- "Cannon Form" had only ever been this tool's own
internal description of the triggered burst-mode STATE, not the skill's real name; the icon this entry
already used (`mole_barrelCannon5`) is literally the real "Barrel Cannon" skill-tree icon
(`mol_barrelCannon5`), confirming the correct name. Remains distinguishable from the reactive single-shot
"Barrel Bot - Barrel Cannon" entry by the missing "Barrel Bot -" prefix -- confirmed live both appear as
separate, non-colliding search suggestions. `mole-skill-damage-reference.md` updated with the full
narrative and citations. Published to the same Artifact URL, same 🦊 favicon.

### 2026-08-20 pilot (retroactively documented 2026-08-21) + 2026-08-21 follow-up: King Kaiser split into 3 "King Kaiser - X" entries

**A prior same-day session built the King Kaiser pilot directly in `index.html` without a matching
CLAUDE.md writeup** -- `ownStatsKaiser`/`kingKaiserOwnStats()`/`KING_KAISER_LV_DEP` and 3 `SKILLS` entries
(`mole_kingKaiser_nAttack`/`_missile`/`_beam`) already existed in code, including the tool's first
per-group `atkCoeff` extension to `dmgGroups` (needed for Normal Attack's 3-swing combo, whose swings hit
at genuinely different ATK coefficients -- 1.0×/1.2×/1.3× -- unlike Napalm's original `dmgGroups` pilot,
where every group was purely `talAdjust`-based with no `atkCoeff` at all). Documenting the pilot's own
shape here for the record, then the real gaps a follow-up session (2026-08-21) found and fixed against a
fresh, more thorough `mechanics-researcher` sweep of `KingKaiser.cs`/`KingKaiserAI.cs` (both files read to
their actual ends, not just until a companion-looking stopping point).

**The follow-up sweep also corrected a stale open item in `mole-skill-damage-reference.md`**: action codes
581/582/585/589/590 near `Mole.cs:46967`, previously flagged as unitemized King Kaiser mech attacks, turned
out to belong entirely to `RPC_useItem` (Mole's generic consumable-item dispatcher) -- a misattribution, not
an incomplete citation. See that doc's own new 2026-08-21 section for the full corrected narrative and every
formula citation (3-swing combo, Kaiser Missile's 4-missile AoE volley, Kaiser Beam's charge-and-release).

**3 real bugs/gaps found and fixed in the existing pilot, not a rebuild**:
1. **Kaiser Beam had no `hitCount` field at all** (defaulted to 1) despite a real, traced 5-pulse loop
   (`i<5` bound, `KingKaiser.cs:3269-3501`) -- added `hitCount:()=>5`, matching this project's own
   "always trace the real loop bound, don't assume a single hit" standard already learned the hard way on
   Roller Machine.
2. **Kaiser Missile's `dmgNote` presented `KingKaiserAI.cs`'s own AI-autopilot dispatch as a real, distinct
   behavior path** ("fires it purely by range with no such tier check"). The fresh sweep found this code is
   structurally unreachable: `Mole.cs:35865` sets `isControlled=true` unconditionally on the summoned mech,
   and `KingKaiserAI.cs`'s own `Update()` (`:69-72`) breaks out before ever calling `AIControl()` whenever
   `isControlled` is true -- confirmed dead code, not a 2nd real path, doubly so since that same AI code
   also calls a `RPC_kaiserPunch` method that doesn't exist anywhere in `KingKaiser.cs` and checks an
   `isTimeOut` key `RPC_kaiserMissile`'s own cast never arms. `dmgNote` corrected to state this plainly.
3. **Both Missile and Beam were sharing the generic `mole_kingKaiser1` icon**, despite real, distinct icon
   files existing on disk (`kaiserCannon0-4.png`/`kaiserBeam0-4.png`, `RippedAssets/.../gamegui/icons/
   skills/mole/`) that match their own in-game skill-tree names (`mol_kaiserCannon1`/`mol_kaiserBeam1`)
   exactly -- the "not yet in `SKILL_ICONS`" gap already documented elsewhere in this file as a recurring
   trap. Extracted `mole_kaiserCannon4`/`mole_kaiserBeam4` (suffix 4, matching the sibling `kingKaiser0-4`
   family's own available range) via a Node splice script (never through the `Edit` tool's base64 path,
   per this file's own documented corruption risk), byte-verified against source via `Buffer.compare`
   before wiring them into the 2 `SKILLS` entries.

**One near-miss, caught before it shipped**: an initial pass also tried to strip TAL/AGI/LCK out of the
"King Kaiser Stats" chip, reasoning (from the fresh source-only research agent's own report) that they were
uncited prefab-default guesses, unlike Barrel Bot's real, load-bearing 4 stats. That was wrong --
`kingKaiserOwnStats()`'s own existing code comment already cites a real hex-decode of these exact values
(`tal=75, agi=200, lck=200`, via this repo's `decode-character-stats` skill against
`12TailsOnline_Data/resources.assets`, all 5 color-variant reskins confirmed byte-identical) from an even
earlier pass. The fresh `mechanics-researcher` agent only has `Glob`/`Grep`/`Read` on `.cs` source, so it
correctly found no `talAdjust`/`agiAdjust`/`lckAdjust` CALLS exist (true, and kept in the writeup) but
couldn't see the binary hex-decode citation trail and wrongly concluded the VALUES themselves were
unconfirmed. Caught by re-reading the existing implementation's own surrounding comment before trusting the
fresh report over it, and reverted before publishing -- worth remembering generally: a source-only research
pass can correctly debunk a MECHANISM (no formula reads these stats) while being wrong about the DATA
(the stats still have a real citation, just via a different tool than the one dispatched this time).

Verified: script-block syntax parse clean (`new Function(js)`), both new icon extractions byte-exact via
`Buffer.compare`. **Not yet visually verified live** -- no browser tool available this session; do a real
visual pass (3-swing combo's summed Final Damage, both new icons rendering, Beam's "Test 5 hits" Simulate
button, the King Kaiser Stats chip's still-correct 4-stat display) before treating this as fully done, same
standing caveat this file already carries for every no-browser session. Published to the same Artifact URL,
same 🦊 favicon.

### 2026-08-21, same day: 6 "Barrel Bot - X" moves reformatted to borrow their real Mole skill icon, plus a caster badge

User request: 6 of Barrel Bot's own AI-picked moves (Mega Punch/Hammer/Drill, Chopper, Missile, Barrel
Cannon) were all still using the generic shared `mole_barrelBot4` icon (the only art ever confirmed to
exist for a Barrel Bot sub-attack, back when the 8-entry moveset split first shipped, 2026-08-20). Every
one of these 6 is a genuinely borrowed identifier though — each `dmgNote` already says "granted by Mole's
own X unlock" — so each has a REAL, distinct Mole skill-tree icon sitting unused. Swapped each entry's
`icon` to that real icon (same rank-cycle base its own Mole-cast sibling entry uses, verified every
`1..maxRank` icon key already existed in `SKILL_ICONS` before wiring — no new extraction needed):

| Entry | Old icon | New icon | Mole sibling entry |
|---|---|---|---|
| `mole_barrelBot_punch` | `mole_barrelBot4` | `mole_megaPunch2` (rank-cycle 1-2) | `mole_megaPunch` |
| `mole_barrelBot_hammer` | `mole_barrelBot4` | `mole_megaHammer2` (rank-cycle 1-2) | `mole_megaHammer` |
| `mole_barrelBot_chopper` | `mole_barrelBot4` | `mole_chopper3` (rank-cycle 1-3) | `mole_chopper` |
| `mole_barrelBot_missile` | `mole_barrelBot4` | `mole_missile4` (rank-cycle 1-4) | `mole_missile` |
| `mole_barrelBot_drill` | `mole_barrelBot4` | `mole_megaDrill5` (single-rank) | `mole_megaDrill` |
| `mole_barrelBot_cannon` | `mole_barrelBot4` | `mole_barrelCannon5` (single-rank) | `mole_barrelCannon` |

**`mole_barrelBot_nAttack` deliberately left untouched** — Mole has no "Normal Attack" skill of his own to
borrow an icon from, so it keeps the generic `mole_barrelBot4` art as its only real option.

**New "caster badge" mechanism** (`selected.casterBadge`, all 6 set to `"mole_barrelBot4"`) — a small,
non-interactive icon permanently overlaying the hero icon's bottom-right corner, so borrowing Mega Punch's
own icon doesn't visually read as "Mole cast his personal Mega Punch" — the badge makes clear the actual
caster is the summoned Barrel Bot. Deliberately NOT modeled as a `dep`/toggle (every other corner overlay
in this file is): it's a fixed fact about the entry, not a state the user flips. New `.sk-hero-icon-wrap`
(a thin `position:relative` container, doesn't touch `.sk-hero-icon`'s own size or the existing rank-cycle
button's click target) holds both the icon and the badge; `heroIconHtml` now always wraps its icon content
in this div rather than emitting a bare `<img>`/`<button>` directly, so any future skill can opt into the
same badge with zero extra plumbing. Reused the same generic `mole_barrelBot4` shared icon as the badge
art itself — no separate "mini barrel bot glyph" asset exists on disk, and this shared icon is
recognizable enough at 24px to serve as one.

Verified: script-block syntax parse clean, `casterBadge` count matches exactly 6 (grepped, not assumed),
`mole_barrelBot_nAttack`'s own entry confirmed still reads `icon:"mole_barrelBot4"` with no `casterBadge`
field. **Not yet visually verified live** — no browser tool available this session; check that all 6
rank-cycle icon sets actually swap correctly per rank, and that the badge doesn't visually collide with
the rank-cycle button's own hover state, before treating this as fully done.

### 2026-08-21, same day, immediate follow-up: caster badge swapped to `mole_barrelBot0`, enlarged, made borderless

User asked to compare available Barrel Bot icon assets before committing to the badge choice above. Found
and presented 4 real candidates with full paths: `gamegui/icons/summons/BarrelBot.png` (75×75, a dedicated
per-summon-type "this is a summon" indicator icon — confirmed by listing its own folder, which holds
exactly one icon per real summon across the whole game: Buiten, Gadina1-4, Gaos, Ja, Phoenix1-2, etc.),
`gamegui/icons/targetavatar/robots/BarrelBot.png` (137×128, already used elsewhere in this tool for the
Final Damage chip's `ENEMY_PRESETS` target buttons — reusing it here would blur that existing "this is
what you're targeting" meaning), and the skill-tree `barrelBot0`/`barrelBot4` icons (64×64, same family as
the badge's original choice). Recommended the `summons/` one for its clean silhouette and lack of any
rank numeral.

**User picked the skill-tree rank-0 icon instead** (`mole_barrelBot0`, not the recommended `summons/`
one) — extracted fresh via the same Node-splice-then-`Buffer.compare` method used for every other icon
this session (never through the `Edit` tool's base64 path). Chose rank-0 specifically over rank-4 (the
original badge choice) because `barrelBot4`'s own art has a baked-in "IV" roman numeral, which could read
as if it were saying something about THIS entry's own rank — `barrelBot0` has no such numeral.

**Then asked to enlarge the badge so it fully covers the underlying icon's own baked-in rank numeral** —
every borrowed Mole skill icon (Mega Punch, Mega Hammer, etc.) draws its own rank numeral (e.g. "II") in
its own bottom-right corner as part of the source art itself (confirmed by viewing `megaPunch2.png`
directly) — the SAME corner the badge already occupies, so a badge too small to cover it would leave that
numeral peeking out and misleadingly implying something about the wrong rank (the real, correct rank is
already shown separately via the rank-cycle mechanism). Sized up 24px→32px, repositioned `-4px`→`-6px` on
both axes to keep it corner-anchored at the larger size.

**Also removed the badge's own border/background/box-shadow** ("remove the skill frame surrounding the
icon too") — the first version gave `.sk-hero-caster-badge` a bordered/backed "chip" box
(`border:1.5px solid var(--panel-2); background:var(--panel-2); box-shadow:...`), which directly violated
this tool's own already-documented standing rule ("Skill icons render borderless" — see this file's
2026-08-13 entry, explicitly generalized to "every skill-icon element in this tool, not just those two").
Missed applying that existing rule when the badge was first built; fixed to match every other skill icon
here (`.sk-dep-toggle`/`.sk-revisedart`/etc.) — no border, no background box, just the bare `<img>`.

Verified: script-block syntax parse clean, `casterBadge:"mole_barrelBot0"` count exactly 6 (no stale
`"mole_barrelBot4"` references left), new icon byte-exact via `Buffer.compare`. **Not yet visually
verified live** — no browser tool available this session; check the 32px badge doesn't visually crowd the
rank-cycle button's own hover state or spill outside `.sk-hero-head`'s layout before treating this as
fully done.

### 2026-08-21, same day: Barrel Bot/King Kaiser Stats table expanded to all 8 core stats + mhp, "used" vs "not used" per skill

User: "for all other entity stats (eg. Barrel Bot / KingKaiser), please put in all 8 stats + max HP
whether the stats are used in calculation or not for full visibility." Before this pass, `barrelBotOwnStats()`/
`kingKaiserOwnStats()` only ever RETURNED the 4 stats (ATK/TAL/AGI/LCK) some skill somewhere in this tool's
formulas actually consumed — DEF/VIT/MAG/CHA/mhp were never modeled at all, even though `BarrelBot.cs`'s own
rank-4 branch sets all 9 just as concretely as the 4 that were already there.

**Real gap found while expanding `barrelBotOwnStats()`, not just an addition**: the existing `doubleBot5`
bonus block only added its `+floor(0.5×MoleLV)` bonus to 4 of the 8 stats (atk/tal/agi/lck) — but this
tool's OWN existing citation for `doubleBot5` (`Mole.cs:12708-12759`, already documented earlier this
project) explicitly says the bonus applies to "EVERY stat — atk/def/agi/vit/mag/cha/tal/lck, additive, all
8 at once." The old function was quietly wrong for the 4 stats it never returned (their values, had they
been computed, would have been missing this bonus) — not just incomplete, actually inconsistent with a
citation this file already trusted. Fixed as part of the same expansion, not a separate bug pass.

**King Kaiser's `mhp` needed real tracing, not just a lookup** — see `kingKaiserOwnStats()`'s own updated
comment for the full citation: `KingKaiser.cs` itself never sets `mhp` anywhere (re-confirmed directly,
not just trusting the original research pass's claim), but `Mole.cs:35936` (inside `RPC_kingKaiser_create`)
DOES read whatever `mhp` the mech already has and scales it by Mole's own Heavy Built passive:
`mhp = ceil(mhp × (1+0.5×heavyBuiltLv))`. Fed with the hex-decoded raw prefab default (200, same "5
reskins, byte-identical" decode as every other King Kaiser stat), that's 200/300/400 across Heavy Built
0/1/2 — **nowhere close to the skill's own tooltip text ("ride a giant robot with 1500 hp",
`MoleSkill_eng.cs:851`)**. Flagged as a genuine tooltip/code mismatch (same family as this project's
already-documented Napalm tooltip mismatch) rather than silently trusting either number; shown at Heavy
Built 0 (200) since that passive has no toggle anywhere in this tool.

**New `getUsedOwnStatKeys(skill)`** (`index.html`, right after `kingKaiserOwnStats`) — computes, per
SELECTED skill (not per entity — the same entity's AGI can be load-bearing for one sibling move and
irrelevant for another), which of the 9 cells are genuinely read by this tool's own calculation:
- `atk` — `skill.atkCoeff !== undefined`
- `tal` — `skill.dmg` (or any `dmgGroups` entry's `dmg`) matches `talAdjust(`
- `agi` — only `skill.ownStats && skill.cdWrapped` (true `ownStats` with a real agiAdjust-wrapped
  Cooldown; never `ownStatsDmgOnly`, whose Cooldown always reads Mole's own AGI instead; never
  `ownStatsKaiser`, since no King Kaiser move has `cdWrapped:true` at all)
- `lck` — real damage exists and the skill isn't `penetrating`/`dmgAdjustSkip` (the attacker-side
  `dmgAdjust` roll in Final Damage genuinely reads this entity's own LCK otherwise)
- `def`/`vit`/`mag`/`cha`/`mhp` — always "not used" — no chip in this tool ever simulates damage taken,
  a shield/heal pool, or an HP bar for one of these own-stat entities, so this is the honest answer, not
  a placeholder to fill in later.

Sanity-checked against skills with genuinely different real answers (not just re-deriving the same 4 every
time): King Kaiser's own **Kaiser Missile and Kaiser Beam both correctly show ATK as unused** — their real
damage is a flat, unscaled 100/300 with no ATK or TAL term at all (per this same day's earlier King Kaiser
research pass), so ATK sits in the table as a real, cited stat that simply plays no role in that specific
move's number — exactly the nuance "full visibility" was asking for, not a table that always highlights
the same cells regardless of which skill is selected.

**UI**: `.sk-bb-table` went from a 4-column single row to a 3×3 grid (`gap:2px 8px`, font sizes trimmed
15px/9px from 19px/10px to fit 3 rows in the chip's existing reserved height) ordered to match
`CharacterControl.cs`'s own field declaration order (hp, atk, def / agi, vit, mag / cha, tal, lck) rather
than an arbitrary layout. The old `.sk-bb-table-3` 3-column variant (built for `ownStatsDmgOnly`'s old
3-of-4-stat display) is gone — every variant now renders the identical 9-cell shape, and `ownStatsDmgOnly`'s
real "Cooldown uses Mole's own AGI instead" nuance is communicated by AGI showing dimmed/unused in that
row, same mechanism as every other skill's own dimmed cells, with the existing caption kept alongside it
since that one case has a genuinely different REASON for AGI being unused (wrong entity, not wrong shape)
worth spelling out in words too. New `.sk-bb-stat-unused` class dims (not hides) a cell's value —
`color:var(--muted); opacity:.7` — keeping the real number visible and legible, just visually
deprioritized against cells actually driving a number elsewhere on the same card.

Verified: script-block syntax parse clean, Node re-derivation of both stat functions cross-checked against
already-live-verified numbers from earlier this project's own sessions (Barrel Cannon's ATK 238/AGI
60/TAL 90/LCK 90 at default Double Bot+Synchro Mole state — exact match, not just plausible), King Kaiser
tier 3's ATK 300/DEF 250 — exact match against the already-confirmed tier table. **Not yet visually
verified live** — no browser tool available this session; check the 3×3 grid actually fits the chip's
existing height without overflow, and that the dimmed/undimmed contrast reads clearly at the smaller
15px/9px sizes, before treating this as fully done.
