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

**Skill icons render borderless (2026-08-13, user-requested):** the Skill Cooldown/Duration Lookup tool's large hero icon (`.sk-hero-icon`) and the revisedArt5 toggle icon (`.sk-revisedart`) both used to have a hairline `--line`/`--gold` border box around them; both were changed to `border:none`. Deliberate, not an oversight — don't reintroduce a border on either without being asked.

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
