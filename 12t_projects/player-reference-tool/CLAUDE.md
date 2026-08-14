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
