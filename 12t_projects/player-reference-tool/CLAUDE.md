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
  `12t_reference/monkey-skill-cooldown-reference.md` for the full reasoning.
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
  `12t_reference/whale-skill-cooldown-reference.md`'s `homingShield` note and
  `12t_reference/panda-skill-cooldown-reference.md`'s Tiger Toss family note for the full citations.
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
    `12t_reference/<class>-skill-cooldown-reference.md` to resolve rank-scaling formulas
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
  this tool has — check the research already done in `12t_reference/2026-07-21-penguin-skill-data-reference
  .md` for each skill's actual `lckAdjust`-gated mechanic first (e.g. arcticWind's is documented at
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
