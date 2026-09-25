# Bible Deliverable Guidelines (`12t_projects/bible/`)

This document contains mandatory guidelines, UI conventions, card schemas, verification pipelines, and file-handling safety rules specifically for the **Bible multi-tool deliverable** (`12t_projects/bible/index.html`).

---

## 1. Large File Handling & Crash Prevention Protocol (>6.4 MB)

`12t_projects/bible/index.html` is **>6.4 MB** because it embeds 670+ game icons as raw Base64 data URIs (lines ~3,600 to ~9,600). Ingesting this into an AI chat context triggers token exhaustion, emergency context truncations, memory loss, and crash loops.

To permanently prevent session crashes and turn interruptions:

1. **Strict Zero-Base64 Ingestion:**
   * Never execute `view_file`, `grep_search`, or raw file dumps across the Base64 icon definitions (lines ~3,600 to ~9,600).
   * To inspect icon keys or definitions, run a small Node.js scratch script that tests keys with regex and prints only string names, never the Base64 payloads.

2. **Out-of-Process Patching via Scratch Scripts:**
   * Never use IDE editing tools (`replace_file_content` / `multi_replace_file_content`) to pass large sections of `index.html` through the context window.
   * All modifications to `index.html` must be applied using small Node.js patch scripts located in `<appDataDir>/brain/<conversation-id>/scratch/`.
   * The patch script loads `index.html`, replaces the targeted logic in memory, writes the file back, and prints only a 1-line confirmation (e.g., `SUCCESS: Patched Left Stride (42 lines)`). Exactly 0 KB of raw HTML or Base64 enters the agent context.

3. **Git Checkpoint Before Every Phase:**
   * Always verify a clean working tree (`git status`) or commit working states before applying edits. **A dirty `index.html` means uncommitted card work exists — make a local WIP commit of it before running any patch script.**
   * **Never run `git checkout`, `git restore`, `git reset` or `git stash` on `index.html` to undo a script.** On a dirty tree they silently destroy every uncommitted edit in the file (this is how the Penguin ToT/TTO card overrides were lost). Every patch script must first copy `index.html` to its scratch folder (e.g. `index.<timestamp>.bak`) and, if it misbehaves, restore from that copy or re-apply only the affected fields.
   * If the tree is dirty, inspect and preserve unrelated changes; do not commit or revert them.
   * **Never replace a whole card line.** Patch scripts change only the specific fields they mean to (insert/replace one `key:value`, or add one id to `compatSkills`). Rewriting a card from hand-typed text silently drops every field you forgot to retype (this is how Mana Missile, Falling Stars/Comets and Arctic Wind lost their damage formulas).
   * **`node scripts/validate_skills.js` enforces this**: with pending changes it errors (`[FIELD LOSS ERROR]`) if any card lost a field it had at `HEAD`. A deliberate removal must be named: `--allow-field-loss=<cardId:field,...>`. It also prints a `[DOC BACKLOG]` count of app skills with no entry in their class reference (`--list-doc-backlog` lists names).

4. **Mandatory Post-Edit Verification & Changelog Gate:**
   * Before committing, prepend a `CHANGELOG_DATA.entries` item in `index.html` using the **exact planned commit subject** and the current ISO timestamp.
   * Execute automated integrity test suite: `node scripts/validate_skills.js` (validates all skills, formula permutations across ranks 1..maxRank and dependencies, and icon assets).

---

## 2. Deliverable & Visual Design Conventions

* **Self-Contained Single File:** Must remain a self-contained HTML file (all CSS, JavaScript, data arrays, and inline SVGs/images embedded directly) that opens and runs immediately in any browser without a web server.
* **Preserve Design Integrity:** Adhere strictly to the "Ledger" visual design system (deep lacquer ground `#141311`, brass-gold ink `#d4af37`, oxblood-red accent `#8b1e1e`, high-contrast legible typography).
* **Inline Skill Description Container (`.sk-hero-desc`):**
  * Sits inline to the right of the skill icon and title in the card hero header (`flex: 1; min-width: 0; margin-left: 14px;`).
  * **Visual Style:** Gold Accent Bar (`background: var(--panel); border: 1px solid var(--line); border-left: 3px solid var(--gold); border-radius: 4px; box-shadow: 0 1px 3px rgba(0,0,0,0.3);`).
  * **Typography:** Google Fonts **Prompt** (`font-family: 'Prompt', -apple-system, sans-serif; font-size: 12px; line-height: 1.42; color: var(--muted);`). Height is unlimited (no line-clamp or max-height restriction).
  * **Responsive:** Stretches `100%` full width beneath the title on mobile viewports.
  * **`desc` Inline Markdown (added 2026-09-18):** Three independent bracket/asterisk conventions, all parsed by the same handful of `.replace()` calls scattered across `renderHero()`/the support-level popup/the changelog server-diff popup — when adding a 4th call site for any of these, wire all three, not just `**`:
    - **`**value**` → Brass Gold bold** (`<span class="sk-val">`). The original, oldest convention — dynamic rank/dependency-scaled numbers.
    - **`__value__` → Oxblood-red bold** (`<span class="sk-val-red">`, using `var(--seal)`). For downsides/debuff-flavored emphasis, added alongside `**` as a second color option since `~~` is awkward to type. Not currently used for anything structural — purely an authoring choice for what reads as a "warning" emphasis in a sentence.
    - **`[statusName]` → purple hoverable status keyword** (`<span class="sk-status">`, matching `sk-status`'s existing look). Optional trailing rank digits are literal typed text, not computed (`[frost]`, `[dissolute4]`) — see the next bullet for the popup content and how this interacts with a card's own `status:` field.
  * **Status Keyword Rendering (`STATUS_CLASS_MAP`, `STATUS_DESC_MAP`, `renderStatusKeywords()`, `renderStatusTip()`, added 2026-09-18):**
    - `STATUS_CLASS_MAP` (declared right before `const SKILLS = [`) is the **single source of truth** for a status name's classification string (e.g. `"Debuff, Magical, Lock"`), seeded from every classification already verified elsewhere in the file (a card's own `status.class` field, or a pre-existing hand-authored `sk-status` span). Add an entry only after verifying the real classification against `StatusData.cs`'s `isBuffStatus`/`isDebuffStatus`/`isStateStatus`/`isMagicalStatus`/`isPhysicalStatus`/`isLockStatus`/`isShieldStatus` functions (see Section 3.0's Dead Code Verification Gate in AGENTS.md) — never guess or copy the client tooltip's framing uncritically (concrete precedent: `frost` was nearly documented as "no slow effect" from checking only a local `moveMod` field; the real mechanic — a hard `moveSpeed = 0` lock, `isLockStatus() == true` — lived in `CharacterControl.cs`'s generic per-status-type switch and `StatusData.cs`'s classification functions, not the one call site that happened to grant it).
    - `STATUS_DESC_MAP` (same spot, sparse, same safe-fallback shape) supplies an optional plain-language 2nd line for the hover popup. An entry is either a plain string (status doesn't scale with level — `frost`'s hard stop is identical at every level) or a `(sLv) => string` function for one whose real effect scales with sLv (`ice`: `moveMod -= 0.1+0.1×sLv`, verified at `CharacterControl.cs:38604` — the actual apply-side call, not the `removeStatus()` mirror at `:17373`, which is a different line and easy to cite by mistake). `getStatusDesc(name, sLv)` calls it with `sLv = null` when `[name]` was typed with no trailing digits (shows the unsubstituted formula in words) and with the real number when `[name3]`/a card's own `status.sLv` resolved a level (shows the computed value, e.g. "40%") — same distinction the caller must apply consistently. A status with no entry here just shows the classification alone, no blank/broken 2nd line.
    - **No repetition between `STATUS_DESC_MAP` and the card `desc` (user rule 2026-09-24):** the status popup and the skill's own `desc` are read together, so a fact goes in exactly one of them. **What the status itself does goes in `STATUS_DESC_MAP`**; the card `desc` just names the status (`[ashura${rank}]`) and describes only what the skill does beyond it. Ashura: the SP gain, the 100 cap, the paused overflow decay and the `provoke` block all belong to the `ashura` status, so they live in its `STATUS_DESC_MAP` entry; the card `desc` keeps the transformation and Ashura Fist. Check both texts before adding either.
    - A status name not yet in `STATUS_CLASS_MAP` renders as **plain literal bracket text** (safe no-op fallback, not an error) — an easy visual signal that it still needs research before it'll show purple.
    - **Popup markup is a real nested `<span class="sk-status-tip">` child**, not CSS `content: attr()` — a first pass tried generating both lines from a single `::after` pseudo-element's `content`, but pseudo-element content is one plain text node: it can't color/weight two lines independently and can't insert a real divider between them. `renderStatusTip(cls, desc)` builds `<span class="sk-status-tip"><span class="sk-status-tip-type">…</span>[<span class="sk-status-tip-divider"></span><span class="sk-status-tip-desc">…</span> only if desc is non-empty]</span>`, shared by both the `[name]` shorthand and the `status:{}` auto-badge path so they never drift apart. Two CSS gotchas hit while building this, worth not re-learning: (1) `white-space:pre-line` on an absolutely-positioned element needs an explicit `width:max-content` alongside `max-width`, or it shrink-wraps to *minimum* content width — one character per line; (2) `.sk-status-tip-divider` is a `<span>`, and `<span>` is `display:inline` by default, so `height`/`width`/vertical `margin` are silently no-ops without `display:block` — the divider rendered completely invisible until that was added.
    - **Auto-badge vs. manual placement:** a card's own `status:{name, sLv, class}` field still auto-prepends a badge to the very start of `.sk-hero-desc` exactly as before (`sLv` can be a function that resolves the level per selected rank — `[name]` inline cannot do this, it's static text). The moment `[name]` (any/no trailing rank digits, case-insensitive — **name-only match**, deliberate choice) appears anywhere inside that same skill's `desc`, the auto-badge is suppressed entirely: you've taken manual control of where this status displays, full stop. A card that wants to show two different levels of its own status (e.g. a base badge plus a separately-cited escalated level, like `bat_dissolute`'s Shame-boosted +1 citation) must place **both** inline explicitly — it can no longer lean on the auto-badge for one of them once any `[name]` is present. (An earlier version of this rule matched exact name+level pairs instead, so the auto-badge would still fire for a non-matching level; that was reverted per direct user request — the rule is now "any `[name]` at all clears the default," and `bat_dissolute` was migrated to place both mentions explicitly to match.)
    - `renderStatusKeywords()` skips any `[name]` that's already hand-wrapped in its own `<span class="sk-status">` (legacy per-card authoring predating this convention, e.g. `bat_dissolute`'s old inline `kw2` template before it was migrated) — otherwise it double-wraps. New cards should use the bare `[name]` shorthand, not hand-rolled `<span>` HTML; no card in the file needs this fallback anymore, but it's cheap defensive coverage against a future regression.
  * **No Native Browser Tooltip:** Native `title` attribute is explicitly omitted from `.sk-hero-desc` to prevent unsightly default browser tooltip popups.
  * **Omit Wrapped Duration & Proc Chance from `desc`:** Never mention wrapped duration (e.g. `chaAdjust`) or wrapped proc chance (e.g. `lckAdjust`) as static numbers in the `desc` text. These dynamic scaling values are already dedicatedly rendered in the interactive stat chips (`duration`, `durWrapped`, `lckProc`).
  * **Dependency-line `desc` format (skills with `compatSkills` modifiers, user convention 2026-09-23):** when other skills change an active skill, write its `desc` as one base sentence followed by one `<br>`-separated line per modifier, each starting with the modifier's linked name and a colon, so the effect of each passive reads at a glance:
    ```
    ชาร์จ **${rank+1} วินาที** แล้วปล่อยหมัดตรงไปข้างหน้า ระยะ **1m** กว้าง **2m** สูง **2m** ทำดาเมจรุนแรงตามค่า ATK<br>**Delay Qi**: ค้างหมัดไว้แทนการปล่อยทันที แล้วปล่อยเมื่อกดโจมตีครั้งถัดไป<br>**Qi Burst**: หมัดยาวเป็นเส้นตรงระยะ **6m** (ปกติสั้นเพียง **1m**)<br>**Focused Art**: บวกดาเมจเพิ่มตามค่า SP ปัจจุบัน ณ ขณะโดนเป้าหมาย
    ```
    - Base sentence: what the skill does, plus its verified hit-box geometry (`ระยะ / กว้าง / สูง`, full width = `2×BaseWidth`, see [12Tails-Mechanics-Reference.md §4](../../12t_reference/12Tails-Mechanics-Reference.md#4-hidden-mechanics--special-interactions)).
    - Modifier lines: `**<Skill>**: <what it changes>`. A value already shown by a chip or a dependency toggle (e.g. a duration the Qi Burst toggle adds to) is not repeated in the line.
    - The modifier passive's own card mirrors it in one line: `ทำให้ **<Active Skill>** <what it changes>` (e.g. Qi Burst: `ทำให้ **Qi Strike** หมัดยาวเป็นเส้นตรงระยะ 6m (ปกติสั้นเพียง 1m)`; one passive affecting two skills names both: `ทำให้ **Pummel** และ **Tower Rush** ...`).
    - Both sides link each other in `compatSkills` (§6).
  * **Omit the on-hit +1 SP gain from `desc`:** Nearly every attack grants the caster +1 SP per landed hit (`mChar.sp = mChar.sp + 1`), so saying it on a card adds nothing (user decision, first applied to Cat Lucky Dice in `6c9536d`). Keep it in the class reference doc only. A skill whose SP gain is unusual (a different amount, or a gain not tied to a hit) is the exception and may say so.
  * **Mechanic-Glossary Links (`^^term^^`, `MECHANIC_DESC_MAP`, added 2026-09-22):** A 5th independent bracket/asterisk convention, for general game-engine mechanics that aren't tied to a status effect (e.g. how `moveSpeed`/`moveMod` combine, the damage pipeline) and are too multi-step for a small `[statusName]` hover tip.
    - **One renderer, global styles (2026-09-23):** all authored text (card `desc`, support formula results, server `changeNote`, glossary step titles/bodies/example captions) goes through `renderRichText(str, skill, lck)` = `renderStatusKeywords(formatDescTokens(...))`, so `**bold**` / `**Skill**` links, `__red__`, `^^term^^` and `[status]` work anywhere. Their CSS (`.sk-val`, `.sk-tip-red`, `.sk-desc-skill-link`, `.sk-mech-link`, `.sk-status` + popup) is **unscoped**, not tied to a container like `.sk-hero-desc`. Any new place that shows authored text just calls `renderRichText`; never re-add per-container copies of these rules. Stat names can take their signature colour inline with the formula-grid classes, e.g. `<span class='dmg-agi'>AGI</span>` (`.dmg-tal/atk/def/agi/vit/int/cha/lck`).
    - **Glossary deep links:** `#mech/<key>/<step>` (step is 1-based, e.g. `#mech/evasion/2`) opens that step via `route()`; closing the glossary clears the hash. Clicking the step title or the topic title copies `## [topic](link)` via `copyTitleLink()`, the same helper the skill-name click uses.
    - **`^^term^^` → teal clickable link** (`<button class="sk-mech-link">`, `--mech-link` token; the rest of the glossary modal keeps the gold `--mech-kw`) that opens a full 16:9-page modal (`#mechanicModal`). Unlike `**bold**`'s skill-link resolution, the literal text between `^^ ^^` is both the displayed text and (case-insensitive) the lookup key, unless `MECH_LINK_ALIASES` maps it to `[key, stepIndex]` — used for Thai player terms and for terms that live inside a bigger topic: `^^ดาเมจขาว^^` and `^^hit()^^` → `damagepipeline` (topic title "ดาเมจขาว", renamed from "ขั้นตอนคำนวณดาเมจ" 2026-09-25; white damage is exactly the damage that goes through `hit()`), `^^ดาเมจม่วง^^` / `^^Effect Damage^^` → `effectdamage`, `^^hitMod^^` → `damagepipeline` step 4. An unmapped key renders as plain literal text (safe no-op fallback).
    - No pre-masking needed against `**`/`__` (unlike triple-star, which was considered and rejected — it collides with the `**bold**` regex and leaves stray asterisks): `^` doesn't appear in either the `**` or `__` patterns, so `renderMechLinks()` can run independently of those passes, in any order. It's wired into both `formatDescTokens()` (as its first line) and `renderStatusTip()` (so `STATUS_DESC_MAP` text can also use `^^term^^`).
    - **`MECHANIC_DESC_MAP`** (declared right before `getStatusDesc()`) holds `{title, steps:[{label, body, examples?}]}` per key — a structured step-list, not a flowing paragraph, since these topics are inherently sequential (the damage pipeline especially). `body` is rendered through `formatDescTokens(renderMechCode(...))`: `` `term` `` (backtick) renders a real engine identifier as a monospace `.mech-code` chip via `renderMechCode()`, and the result then goes through the normal `**bold**`/`__red__`/`^^link^^` passes, so a step's own text can cross-link to another mechanic panel via `^^otherKey^^` the same way `**SkillName**` links to a skill card.
    - **One step = one full page (redesigned 2026-09-22, user-requested "center stage" treatment):** `renderMechSlide()` shows exactly one `steps[]` entry at a time — a giant translucent step-number watermark, the step label/body, and (if the step has one) a `step.examples` icon row — with borderless ‹ › nav buttons and a dot row to move between steps, plus `ArrowLeft`/`ArrowRight` keyboard support. `openMechanicPanel(key, stepIdx)` takes the step index; the index/step-count in a tile's meta line and the dots both read `entry.steps.length` live, so adding/removing steps needs no other code change.
    - **Phone layout (≤760px wide or ≤480px tall, polished 2026-09-24):** full-screen sheet; the slide content is top-aligned and scrolls (a centred flex column that overflows gets clipped *above* its scroll range, which used to hide the step title); ‹ › move into the bottom bar beside the dots, so the text uses the full width; examples stay a compact 3-column row (56px icons); the watermark is small, top-right and faint; `fitMechSlide()` skips its shrink-to-fit on these screens; opening the glossary adds `html.mech-open`, which scroll-locks the page behind it on phones. Index tiles are compact and top-aligned, with fainter backdrop art (12% opacity vs 14–16% on desktop).
    - **`step.examples: [{icon, name, caption}]`** (added 2026-09-22) — an optional 3-column row of real game icons (`renderMechExamples()`, reads `SKILL_ICONS[ex.icon]`, the same asset map every skill card icon draws from) below a step's body, each with a name and a caption stating that example's actual real value (e.g. a status's verified `moveMod`/`dmgMod`/`hitMod` delta). Icons render large (128px desktop / 72px on the mobile fallback) with **no card container** — just icon + name + caption, per user request. Always verify the example's value at its real **apply-site**, not the `removeStatus()` mirror (both contain a plausible same-named line with the opposite sign — see the `atkAdjust`/`hitMod` citation fixes in `12Tails-Mechanics-Reference.md` §2.6 the same day for the concrete trap).
    - **Index tile backdrop art (`renderMechTileBg()`, added 2026-09-22):** the index/overview tiles (`.mech-index-tile`) may carry per-topic backdrop art bled off the tile's right edge at low opacity (`.mech-index-tile-bg-img` for a user-supplied image constant, `.mech-index-tile-bg-digits` for the real in-game white damage-digit textures via `renderDamageDigits()`) — index-tile only, never the slide page. Add a new topic's art by extending the `if (key === ...)` chain in `renderMechTileBg()`.
    - **Entry points:** inline wherever `^^term^^` appears in any `desc`/`durNote`/status text, or via 📖 `#btnMechanicGlossary` in the hub-level `.hub-bar` (next to the changelog ↻ button, not scoped to any one tool) which opens the same modal on a browsable index (`renderMechanicIndex()`, a grid of un-numbered chapter tiles) of every mapped topic — `openMechanicPanel(null)` renders the index, `openMechanicPanel(key, stepIdx?)` renders one topic's step.
    - **Color choice:** gold (`--mech-kw`, reusing `--gold`'s own RGB), matching the rest of the app's brand accent — an earlier teal was tried first and replaced same-day per user request for hue consistency.
    - **Content tone:** Thai, player-friendly (same audience as `desc`), verified against decompiled source with the same rigor as any card field, but **no `file:line` citations shown in the visible panel** — this is a player-facing explainer, not a research document.
    - Retrofitting `^^term^^` into existing skill cards' `desc` text is a deliberately separate follow-up task, not done as part of shipping this infrastructure.
* **Basic Attacks & Passives as Cards Policy:** Basic attacks (Combo / `nAttack`), charge attacks (`cAttack`), and passive skills CAN be authored as full skill cards in `bible` (`skill-details`), but strictly when explicitly requested by the user.
* **Vertical Collapse Convention for Skill Cards:**
  * All skill cards must collapse vertically whenever a chip row is empty.
  * **Zero Preserved Blank Space:** Never render empty chip row containers (`<div class="sk-dmg-row"></div>` or empty `.sk-hero-stats`) or enforce artificial fixed min-heights.
  * If a skill has no cooldown/cast/duration/stats chips, omit `.sk-hero-stats` completely.
  * If a skill has no damage formula/shield chips, omit `.sk-dmg-row` completely.
* **`dmgGroups` Skills Mirroring Rule:** `dmgGroups` skills MUST declare a top-level `dmg`/`atkCoeff`/`ko` mirroring the primary group. `renderHero()`'s "Total LCK Variance" calc chip reads the top-level `dmg` unconditionally when `dmgGroups` is present; omitting it causes a fatal `SyntaxError` in `evalArith("")`.
* **`dmgGroups` Hit-Count Sum Rule (added 2026-09-23):** for sequential-hit groups, the groups' `hitCount`s must sum to the top-level `hitCount(rank, dmgDepOn, hitCountDepOn)` for every dependency on/off combination. Simulate rolls the top-level count and walks the groups by hit index, so a mismatch drops or repeats hits (Tiger Toss once simulated only the toss, not the Tiger Pounce hit, with `hitCount:()=>1` against groups summing to 2). When a dep adds hits, make the top-level count depend on it (`hitCount:(rank,dmgDepOn,hitCountDepOn)=>hitCountDepOn?2:1`). `dmgModes:true` cards (alternative modes/zones such as 12th Kingdom Knight, Planet Breaker) are exempt. Enforced by `scripts/validate_skills.js` (`[DMGGROUPS HITCOUNT ERROR]`).
* **KO Badge per Group:** When individual `dmgGroups` differ in KO value (e.g. `ko: "10"` vs `ko: "5"`), declare `ko` on each group. `getGroupKOInfo()` automatically splits into inline chips only when they differ, or collapses to a single `.sk-ko-badge` when uniform.
* **Phone / narrow layout (under 900px, 2026-09-24):** desktop uses `fitStageToScreen()` to scale the whole composition (card + absolutely-positioned side stats panel, ~1420px wide) into one no-scroll screen, which shrinks it to ~25% on a phone. Under 900px the Skill Details tool (`html.tool-wide-hero`) instead: drops the scale transform, re-enables page scroll, stacks one column (search + card + related skills first, stats panels after via `order:1`), shows the Test popup as a fixed overlay at `top:26vh`, and puts stat tooltips under their value, clamped on screen (`positionStatTooltips()` narrow branch). `.view`'s fade-in `animation-fill-mode` is set to `none` there, because its lingering identity transform would otherwise become the containing block for `position:fixed`. Under 560px the LCK-variance and Final chips go full width. Other `tool-fit-screen` tools are not affected.
* **Test button (`simulateBtnHtml()`, redesigned 2026-09-24):** every Test button (main, heal/hate, per-mode) comes from this one top-level helper. It's the card's one **filled gold pill** (`--gold` background, `--ink` text, which flips correctly in both themes), full width under the Final range. Label `ทดสอบดาเมจ` / `ทดสอบฮีล` / `ทดสอบ Hate`; icon a filled 8-point starburst, or a ✚ cross for heals. The hit count follows in smaller text: `×10 ฮิต`, a range `×3–5 ฮิต`, nothing for single-hit skills or Typhoon's HP pool (tooltip explains). Per-mode buttons use `small:true` (`.is-sm`). **First-time glow:** `.is-new` pulses until any Test is clicked anywhere (a capture listener calls `markSimSeen()`, stored under `localStorage["12t-bible-sim-seen"]` in try/catch); `prefers-reduced-motion` turns the animation off. No keyboard shortcut. Validator §3n (`[TEST BUTTON ERROR]`).
* **Skill Dependency Icon Sizing & Hover Glow (added 2026-09-25):**
  * **Size Standard (50% Increase):** Primary dependency toggle icons (`.sk-dep-toggle img, .sk-dep-rank-icon img`) render at **42×42px** (increased from original 28px) with `border-radius: 7px`. Nested `.sk-ko-badge` dependency icons render at **24×24px** (from 16px). Inline description toggle icons (`.sk-hero-desc-toggle img`) render at **40×40px** with `padding-right: 56px` on `.sk-hero-desc` to preserve text clearance.
  * **Invariant Chip Height & Offset Alignment Rule:** In `.sk-dmg-toggles`, button layout height is locked at `28px` with top alignment and `-2px` right margin (`.sk-dmg-toggles{display:flex; align-items:flex-start; gap:8px; height:28px; min-height:28px; margin-right:-2px}` and `.sk-dep-toggle{display:inline-flex; align-items:flex-start; justify-content:center; height:28px; flex:none;}`) so the 42px icon aligns to a visual 12px top offset and 12px right offset matching the chip's internal padding without expanding `.sk-dmg-head` or making the chip taller. In `.sk-stat`, absolute placement (`.sk-dep{position:absolute; right:12px; top:12px}`) matches uniform 12px top and right corner offsets, with `.sk-dep.sk-dep-secondary` shifted to `right: 60px` (12px right offset + 42px icon + 6px gap) to prevent overlapping the primary icon.
  * **Hover Glow (Borderless):** Adhering strictly to the borderless skill icon standard (no outer border or container box-shadow around the icon), hovering over any dependency toggle illuminates the icon from within via brightness and opacity scaling (`opacity: .85; filter: grayscale(80%) brightness(1.2);` when off, and `opacity: 1; filter: brightness(1.22);` when on) with a smooth `0.15s` transition and `outline: none` to avoid focus rectangles.
* **Cat Power Number Series Toggle (`CAT_POWER_DEP`, added 2026-09-25):**
  * **Engine Mechanics (`CharacterControl.cs:2838-3010`):** In the base BigBug engine, Cat's Power Number passives (`cat_powerOne`, `cat_powerTwo`, `cat_powerThree`, `cat_powerSeven`, `cat_superSeven`) execute in `CharacterControl.hit()` gated solely by `this.Type == "Cat"`, applying raw damage multipliers (`floor(raw × 1.1 / 1.2 / 1.3 / 1.7)`) globally across **all Cat damage skills**.
  * **Unified Cycle Dep:** Generalized from `CAT_COMBO_POWER_DEP` into `CAT_POWER_DEP` (`id: "catPower"`, ranks 0..4: Off, Power One `+10%`, Power Two `+20%`, Power Three `+30%`, Power Seven / Super Seven `+70%`). State is shared across all Cat damage cards so toggling on one syncs across the class.
  * **TTO Private Server Balance Delta (user-reported live observation, not in the decompiled client):** On Twelve Tails Online (`server=tto`), the Power Number series is nerfed and restricted strictly to **Cat Skill Tree A (Gambler branch)** skills (`cat_luckyCard`, `cat_luckyDice`, `cat_damageRoulette`, etc.) via `isCatPowerApplicable(skill, server)`. It is disabled/hidden on basic attacks/Combo (`cat_nAttack`) and Skill Tree B (Assassin branch) attacks when TTO is selected.
* **Per-Class `SKILLS` Ordering:** Within a class's block in the `SKILLS` array, order entries by that class's own internal skill ID sequence from `<Class>Skill.cs`'s `getSkillTree()` `result = "<class>_<name><rank>"` assignments.

---

### Class Badge in the Player Stat Panel (added 2026-09-19)

The player stat panel (`.sk-stats-panel`) opens with a `.sk-class-badge`: the selected skill's **class portrait**, its name and the caption "ค่าสถานะตัวละครของคุณ" ("your character's stats"), so a new user can tell those inputs are for their own character and not the skill or the enemy.

* **Art:** `CLASS_PORTRAITS` (a `const` right after `CLASS_ART`) holds full-colour 96×96 PNG data URIs, one per class. This is deliberately **not** `CLASS_ART`, which is the black line-art mask used as the faint card backdrop. Source: `minimal_class_icons/bg_removed/<Class>.png`, cropped to the character, padded square, downscaled (~170 KB for all 12).
* **Update path:** `updateClassBadge(cls)` is called from `renderHero()` beside the `CLASS_ART` backdrop update. A class with no portrait (shared `Common` skills) shows the caption only. The panel is hidden until a skill is selected, so the badge never shows an empty state.
* **Compact mode:** under `max-height: 820px` the portrait shrinks to 40px so the no-scroll screen still fits.
* **Validation:** `scripts/validate_skills.js` §3i requires a valid PNG portrait for every class that owns a skill (`[PORTRAIT ERROR]`). Adding a new class means adding its portrait here.
* **Revised Art button** lives at the right end of this badge (it used to sit in a separate button row between the two panels; that row no longer exists).
* **Enemy badge** (`.sk-class-badge.sk-enemy-badge`) is a **separate card** above the enemy stats, exactly like the player's badge above the player's stats (the red enemy panel is now two red cards with an 8px gap, not one box): a preset icon, the preset name and the caption "ค่าสถานะตัวละครเป้าหมาย" ("target character's stats"), with the immunities "i" button at its right. **Clicking the icon opens a preset picker** (2026-09-24, replaced forward-only cycling): a 3-column grid of every `ENEMY_PRESETS` entry (icon + name, current one in gold) that closes on a choice, a click elsewhere, or Esc. Choosing a preset always writes its values and clears "Custom". Each change is pushed on a small undo stack (20 deep) so **Ctrl+Z** (outside a text field, where the field's own undo wins) restores the previous enemy, hand-edited values included (`selectEnemyPreset` / `undoEnemyChange`). The ◂ ▸ arrows stay removed. The enemy panel stays red, the player badge gold. The old cycler row and name cell are gone; the enemy stat grid keeps an **empty first cell** so its 8 stats sit under the same columns as the player's (which starts with CHAR LV).
  * Long preset names shrink in steps (`fitEnemyName`: ≥9 / ≥12 / ≥14 characters → 13 / 12 / 10.5px) so they stay on one line.
  * After a hand-edit the badge shows a "?" icon and the name "Custom".
  * The enemy panel is **always visible** now: the show/hide toggle (`enemystat-toggle`) was removed.
* **Captions never wrap** (`white-space:nowrap`): Thai has no spaces, so a wrap splits a word mid-way.
* **Validation (panel structure):** §3j checks both captions exist once, Revised Art sits inside the player badge, the enemy badge is its own card with a clickable icon, the preset picker, plus name/info roles and no stat inputs inside it, and the toggle, the arrows and the `.sk-controls-actions` row never come back (`[PANEL ERROR]`).

---
## 3. Skill Verification & Quality Assurance Pipeline

Every skill authoring, formula update, or tooltip review must strictly follow this linear execution pipeline:

### 3.0. Dead Code Verification Gate (checked before declaring ANYTHING dead/unwired)

**Never declare a mechanic "dead code," "unwired," or "not found in code" from a single file's call sites.** A getter/setter or stored field with only one write-site and no read *inside the class's own primary `.cs` file* (`<Class>.cs`) is not proof the value is unused — it is proof the read lives somewhere else. Concrete precedent: `getFrostBiteLv()` in `Penguin.cs` (assigned once at `Penguin.cs:30793`, field declared at `30864`) looked like dead code by every grep scoped to `Penguin.cs` alone — the real read site was in the companion file `Penguin_nAttack.cs:321-359` (the normal-attack hit coroutine), which is where nearly all on-hit proc logic for a class actually lives, not in `<Class>.cs` itself.

Before concluding a finding "doesn't make sense," "has no call site," or "seems like dead code":
1. Search **every** `<Class>_*.cs` companion file (`Penguin_nAttack.cs`, `Penguin_manaMissile.cs`, `Penguin_tornado.cs`, `Penguin_typhoon.cs`, etc. — use the file browser or `Glob`/`Grep` across `DecompiledSource/<Class>_*.cs`, not just the one file you started in), plus `CharacterControl.cs`, `Damage.cs`, `StatusData.cs`, and `GameGui.cs` for the same identifier (function name, field name, or `hasSkill(ID)` number).
2. Only after that class-wide sweep comes up empty is it safe to report a mechanic as unverified/dead in the client code (and even then, phrase it as "not found after searching `<Class>.cs` + all `<Class>_*.cs` companion files" — cite the full search scope, not just the one file you happened to check).
3. This applies symmetrically to `12t_reference/*.md` reference docs — if an existing reference doc claims something is dead code, that claim is a prior finding, not ground truth; re-verify it against the full companion-file set the same way before trusting or repeating it in a new card's `desc`.
4. **The same "checked one local call site, missed the shared/generic one" failure applies to status effects, not just dead-code claims.** A status's mechanical strength is NOT fully determined by the local fields (e.g. `moveMod`) set on the one `RPC_AddStatus(...)` call you happened to trace — every status name also gets a **generic per-status-type handler** in `CharacterControl.cs` (a large `sType ==` switch that fires on application/removal/tick for that status name regardless of which skill granted it) that can set entirely different fields (e.g. hard `this.moveSpeed = 0` instead of a `moveMod` percentage), plus a classification in `StatusData.cs` (`isLockStatus`, `isStateStatus`, `isMagicalStatus`, etc.) and cross-references in resistance/immunity/cleanse logic (`removeLockStatus`, `float`-status immunity checks, etc.). Concrete precedent: `frost` was declared "purely cosmetic, no slow effect" from checking only the `moveMod` field on Arctic Wind's own status-apply call — the real mechanic (`CharacterControl.cs:2409-2424`, hard `moveSpeed=0`, identical to `groundLock`) lived in the shared switch, plus `frost` is independently classified `isLockStatus()==true` (`StatusData.cs:6160`) and appears in `float`'s CC-immunity list (`CharacterControl.cs:13156`) — three separate corroborating sites, none of which were checked before publishing the wrong claim. Before describing what a status "does" or "doesn't do" (especially before overriding what a client tooltip already claims), grep `CharacterControl.cs` and `StatusData.cs` for the exact status-name string, not just the one call site that grants it.

### 3.A. Active Skill Pipeline

#### Step A1: Pre-Flight Active Source Extraction (Zero Assumptions)
* **Approximations & Wiki Extrapolations Are Strictly Forbidden:** Never guess, linearly scale (e.g. assuming Rank 2 is +25%/+50% MP), or rely on unverified community wiki data. BigBug Studio authored irregular per-rank values directly into control-flow bytecode.
* Run a temporary scratch script (in `<appDataDir>/brain/<conversation-id>/scratch/`) or `view_file` to trace the full lifecycle across:
  0. **Cost/Mode/Req Table:** Run `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` for every skill's MP/SP/reqLv before reading `getSkill()`'s obfuscated fallthrough chain by eye. SP field sign indicates type (negative = red/consumed, positive = blue/threshold gate, `0` = no SP cost).
  1. **Cast Dispatch:** `<Class>.cs` (`RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust` wrappers, per-rank arrays).
  2. **Execution & Companion Logic:** `<Class>_<companion>.cs` (multi-hit loops, secondary triggers, collision handlers).
  3. **Status Effect Tracing (Name, Level, and Classification):**
     * **Status Name (`sType`) & ID (`nCode`):** Exact string and integer code from `StatusData.cs`.
     * **Status Level (`sLv`):** Exact level passed or calculated per rank.
     * **Status Classification (via `StatusData.cs`, see [12Tails-Mechanics-Reference.md §4.2](../../12t_reference/12Tails-Mechanics-Reference.md#42-status-classification-cleanse-system-statusdatacs)):** Verify `isBuffStatus`, `isDebuffStatus`, `isStateStatus`, `isMagicalStatus`, `isPhysicalStatus`, `isLockStatus`, `isShieldStatus`.
     * **Debuff Duration Contesting:** Any status calculated via `Damage.getDebuff(...)` requires `durWrapped: true` and `durContested: true`. For `Damage.getDebuffInvert(...)`, declare `durContestedInverted: true`.
  4. **Multi-Rank Icon Completeness:** For `maxRank > 1`, inspect and extract every rank variant icon (`<skill>1`..`<skill><maxRank>`) from `RippedAssets/`. Zero placeholders.
  5. **In-Game Tooltips:** Cite raw strings from `<Class>Skill_eng.cs` & `<Class>Skill_thai.cs`.
  6. **Passive Dependencies:** Trace all `hasSkill(ID)` / `get<Passive>Lv()` hooks (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).
  7. **Summons & Companions:** If the skill spawns an entity or commands a companion, adhere strictly to [Section 5](#5-summon-mechanics-companion-movesets--summon-stat-cards).

#### Step A2: Active Observable Proof Review Table
Present a structured review table to the user including:
1. **Identity Mapping:** Internal source key, user-facing name (EN & TH), planned ID, class, max rank.
2. **Cast Dispatch Excerpt (`<Class>.cs:line`):** Exact `addTimeOut`, `DisplayCastBar`, and `RPC_<skill>` snippets.
3. **Execution / Status Delta Excerpt (`CharacterControl.cs:line` or Companion):** Exact logic modifying stats, damage, or statuses.
4. **Status Profile:** Name (`sType`), Numeric ID (`nCode`), `sLv`, and full boolean classification breakdown.
5. **Client Tooltips:** Exact strings cited from `*Skill_thai.cs` and `*Skill_eng.cs`.
6. **Proposed Header Tooltip (`desc`):** Authentic client phrasing as baseline, qualitative over quantitative, dynamic highlights with `**bold**`, clear mention of geometries and cleanse thresholds.
7. **Proposed Card Schema:** Complete deliverable card definition (see [Section 4](#4-skill-card-schema--authoring-standards)).

---

### 3.B. Passive Skill Pipeline

#### Step B1: Pre-Flight Passive Source Extraction (Zero Assumptions)
* Systematically scan and trace across the **5 Passive Hook Categories**:
  1. **Stat Alteration Hook:** Modifies base or derived attributes (`CharacterControl.getTypeStat`, `calTotalStat`, `calHp`, `calMp`, `calAtk`, `calDef`, `calSpeed`).
  2. **Active Skill Dependency Hook:** Modifies cooldown, cast time, MP/SP consumption, hit count, or projectile patterns.
  3. **Status Application / Proc Hook:** Grants on-hit effects, debuff chances, or modifies status levels in `AttackHit`, `MagicHit`, or `mod`.
  4. **AI / Companion Hook:** Modifies summon pet stats or AI behaviors (e.g. `HeavyBuilt`, `SynchroMole`, `HiddenTurret`).
  5. **Attack Augmentation Hook:** Modifies normal attack combos or charge attack behaviors (`nAttack`, `cAttack`).
* **Multi-Rank Icon Completeness:** Verify all rank variant icons from `RippedAssets/`. **Enforced:** `node scripts/validate_skills.js` fails with `[ICON RANK ERROR]` when a `maxRank > 1` card lacks any `<icon base><rank>` key (the hero icon otherwise silently falls back to the max-rank icon, so a gap is invisible). The rank PNGs live in `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/<skill><rank>.png` and embed as their raw base64.
* **Cross-Linking Target Audit:** Identify and list every active skill altered by this passive.

#### Step B2: Passive Observable Proof Review Table
Present a structured review table including:
1. **Hook & Logic Excerpt (`file:line`):** Exact source line showing `hasSkill(...)` / `get<Name>Lv()` check and its execution branch.
2. **Mechanics & Derivation:** Precise arithmetic for stat additions, timer scaling, proc chances, or level calculations.
3. **Cross-Linked Active Skills & Dependency Mapping:** List all affected active skills and proposed dependency toggles.
4. **Status Profile:** Status details if granted/applied.
5. **Client Tooltips:** Exact raw strings from client files.
6. **Proposed Card Definition:** Schema block ready for `index.html` (see [Section 4](#4-skill-card-schema--authoring-standards)).

---

### 3.C. Shared Gates, Review & Verification

1. **Strict Single-Class User Gate:** Process strictly one class at a time and wait for explicit user approval before writing changes.
2. **Close the SkillDep Loop:** When a skill introduces a dependency on another skill that has no card yet, proactively surface those related skills to the user to implement next.
3. **Zero Silent Omissions & Numbered Remainder List:** Account for every verified finding in card fields or `desc`. Any verified finding that does not fit an existing field must be presented as a numbered remainder list for the user to review and decide upon.
4. **Validation & Integrity Pass:** After patching via out-of-process scratch scripts, run `node scripts/validate_skills.js` to ensure 100% integrity pass before committing.

---

## 4. Skill Card Schema & Authoring Standards

### Proposed Active Card Schema (`SKILLS` Object)
```javascript
{
  id: "class_skillName",
  name: "English Name",
  nameTha: "ชื่อไทย",
  class: "Class",
  icon: "iconKeyMaxRank",
  maxRank: 3,
  cost: { mp: [15, 30, 45], sp: [1, 2, 3], spType: "red" }, // "red" = consumed, "blue" = threshold
  cd: [10, 8, 6],
  cdWrapped: true, // true if agiAdjust/cd wrapped
  castTime: 1.5,
  castWrapped: true, // true if chaAdjust/cast wrapped
  duration: [10, 15, 20],
  durWrapped: true, // true if chaAdjust/dur wrapped
  durContested: true, // true if Damage.getDebuff contested
  status: { name: "statusName", sLv: [1, 2, 3], class: "Physical Debuff" },
  dmg: "100 + 20*rank",
  atkCoeff: 1.0,
  ko: "15",
  desc: (rank) => `คำอธิบายสกิลพร้อมตัวแปร **${value}**`
}
```

### Proposed Passive Card Schema

```javascript
// Minimal / Standard Passive (Stat modifier or pure passive hook)
{
  id: "class_passiveName",
  name: "English Name",
  nameTha: "ชื่อไทย",
  class: "Class",
  icon: "iconKeyMaxRank",
  maxRank: 3,
  passive: true,
  desc: (rank) => `เพิ่มความสามารถ **${rank * 10}%**`
}

// Feature-Rich Passive (with Status, Internal Cooldown, Duration, or Proc Rate)
{
  id: "class_procPassive",
  name: "English Name",
  nameTha: "ชื่อไทย",
  class: "Class",
  icon: "iconKeyMaxRank",
  maxRank: 3,
  passive: true,
  cd: [10, 8, 6], // Internal proc cooldown (if present in source)
  duration: [5, 5, 5], // Temporary buff duration (if applied)
  status: { name: "buffStatus", sLv: [1, 2, 3], class: "Buff Status" }, // Status badge & classification
  lckProc: [15, 20, 25], // Proc chance % (if probabilistic)
  desc: (rank) => `เมื่อโจมตีมีโอกาส **${15 + rank*5}%** มอบสถานะ...`
}
```

> **Chip Support on Passives Policy:**
> Passive cards *can and should* carry `status`, `cd`, `duration`, `lckProc`, `cost`, or `ko` whenever decompiled source code proves the passive genuinely possesses them (e.g. granted statuses, internal cooldowns, proc rates, or toggle costs). Do not omit verified mechanics under the false assumption that passives are restricted to text-only descriptions. Unused chip rows collapse automatically per the Vertical Collapse Convention.

> **Dual-Duration, Dual-LCK Proc & Chip Position Overrides (added 2026-09-19):**
> A skill whose passive/proc grants a status with a genuinely different duration than the card's own primary `duration` (e.g. Frost Bite's frost-vs-ice roll, `chaAdjust(2)` vs `chaAdjust(3)`) uses `secondaryDuration: {duration, durWrapped, durContested, label}` — renders as its own `.sk-stat-dur2` chip, same shape as the primary `duration`/`durWrapped`/`durContested` fields but scoped under one object with a required `label` to distinguish it (e.g. `"ระยะเวลา Ice"`).
>
> **Duration chip label standard (`durLabel` / `secondaryDuration.label`, standardized 2026-09-24):** Similar to `lckProc.label`, when distinguishing multiple durations on a card or customizing a duration chip title, labels use the Thai format `"ระยะเวลา " + <descriptor>` (e.g. `"ระยะเวลา Ice"`, `"ระยะเวลา Frost"`, `"ระยะเวลา Drunken"`, `"ระยะเวลา Drunk (ฮิต 1)"`). Avoid English suffixes like `"Duration"` or `"Lifetime"` since `"ระยะเวลา"` already communicates that.
>
> Similarly, a skill with distinct proc chances across multiple combo hits or modes (e.g. Spread Shot's 20% on hits 1-2 vs 40% on hit 3) uses `secondaryLckProc: {label, chance, applies, ...}` — renders as its own `.sk-stat-lck2` chip (grid-column 3 by default, override with `chipCols`; documented here since 2026-09-19 but the chip itself wasn't actually built/rendered until 2026-09-23 — see below).
>
> **Non-damage procs (`lckProc.simulate: false`, added 2026-09-22):** Retain the LCK-adjusted chance chip but exclude the mechanic from the outgoing-damage simulator when its roll is not caused by the skill's hit. Use this for defensive/reactive mechanics such as Panda Wind & Cloud's incoming-hit evasion; never show that roll as a proc label beside simulated outgoing damage.
>
> **`lckProc.label` / `secondaryLckProc.label` are mandatory (added 2026-09-23):** the chip's title is always the generic "โอกาส" (chance) unless `label` says what the chance is *for* — before this date `label` was accepted but silently never rendered, so 30 of 31 existing cards had a correct-looking field with zero visible effect. Pattern: `"โอกาส " + <descriptor>` — the descriptor is free text (usually the existing English identifier, e.g. `"โอกาส Frost"`, `"โอกาส Evasion"`, `"โอกาส SP/MP Restore"`), never re-add a redundant "Chance"/"Proc" suffix since "โอกาส" already says that. `scripts/validate_skills.js` hard-errors (`[LCK LABEL ERROR]`) on any `lckProc`/`secondaryLckProc` missing a `label` — this is the one lckProc field GEMINI.md now enforces mechanically rather than leaving to review, because a missing label used to be invisible on the rendered card (no fallback text told you it was missing).

> **Outcome-odds chip row (`lckOdds`, added 2026-09-25 for Grand Casino Arcade):** for a skill whose damage comes from a **direct LCK roll** with several outcomes (not an `lckAdjust` proc), `lckOdds: (LCK) => [{label, pct, base}]` renders one `.sk-stat-odds` chip per outcome in its own `.sk-hero-stats.sk-odds-row` (5 columns, 3 under 680px) below the normal stat chips. `pct` is the exact share (shown to 1 decimal; 0% is dimmed), `label` follows the `"โอกาส " + <descriptor>` rule, `base` names the roll band (`"เลข 5–49"`). It also makes LCK glow. Casino's helpers (`CASINO_OUTCOMES`, `casinoOdds`, `casinoRoll`, `casinoRawRange`, next to `CAT_POWER_DEP`) are the single source for the chips, the simulator and the range; a Doom spin never calls `hit()`, so the simulator returns 0 and the range's low end is a flat 0 (`range.zeroMin`, skipping `dmgAdjust(0)`). Validator: `[CASINO ERROR]`.

> **Dynamic LCK-chip base chance:** `lckProc.chance` may be `(rank, procDepRank) => number` when a separately rendered skill dependency changes the source chance. The chance function is resolved before `lckAdjust`; use it for Water Monkey/Water Crane's Time and Tide 50% → 100% evasion base so the chip follows the shared Time and Tide toggle while `simulate:false` still prevents an outgoing-damage proc.

> **Post-`talAdjust` passive multiplier (`dmgRankDep.postTal: true`, added 2026-09-22):** Set this alongside a numeric `dmgRankDep.mult` only when source multiplies the already-truncated `talAdjust(...)` result, before it is added to ATK (Panda Time and Tide: `0.5×ATK + talAdjust(10×sLv)×(1+0.5×passiveLv)`). The simulator and range path then apply the multiplier to the TAL term alone; do not use the default inside-`talAdjust` multiplier, which changes LCK rounding and is a different formula.
>
> `.sk-hero-stats`'s 4 chip slots (`cd`, `cast`, `dur`, `lck`, columns 1/2/3/4) have fixed CSS defaults so layout stays predictable when chips are conditionally present — but `dur2`, `lck`, and `lck2` default to column 4, which collide whenever a card genuinely has multiple. Rather than special-casing that in CSS (tried once, reverted — it broke `monkey_runicSand`, which pairs `castTime` with `secondaryDuration` and would have collided with a blanket "`dur2` → column 2" rule), the general fix is a per-card **`chipCols`** field: a sparse `{cd, cd2, cast, dur, dur2, lck, lck2: N}` map that renders as an inline `style="grid-column:N"` on that one chip, via a `chipColStyle(key)` helper in `renderHero()`. Every card without `chipCols` is completely unaffected — the class defaults are back to their plain, un-special-cased original form. `.sk-hero-stats` also has `grid-auto-flow:dense` so a chip moved to an earlier column via `chipCols` actually backfills that slot instead of wrapping to a phantom 2nd row (CSS Grid's default sparse packing cursor only moves forward, never backtracks, once a later-DOM-order chip has claimed a higher column).

---

### Purple Effect Damage mixed into normal hits (`effectProc`, added 2026-09-24)

For a card whose hits can also deal Effect Damage (purple, `RPC_AddEffectDamage`). The purple part always follows the real Effect Damage path: no dodge, no `damagePlus`, no `dmgAdjust`, no `defAdjust`, no direct-hit reduction, `hitMod` rounded **down** (see [12Tails-Mechanics-Reference.md §2.9](../../12t_reference/12Tails-Mechanics-Reference.md)). KO is not simulated.

* **`effectProc: { mode: "replace", chance: (rank) => base%, dmg? }`**: a roll makes the hit purple **instead of** white. `chance` is the base before `lckAdjust`; the roll is `floor(random×100) < lckAdjust(base)` (the game's `lckAdjust(c) > Random.Range(0,100)`). `dmg` overrides the purple formula when the source uses a different one (Javelin: `talAdjust(10×sLv)`, no Tide Cutter). Pair it with a display-only `lckProc` (`simulate:false`) for the chance chip. Used by Whale Sweep / Javelin / Peninsula Impale via the shared `WHALE_WALLPUNCTURE_DEP` (0–4) and `WHALE_WALLPUNCTURE_LCK`.
* **`effectProc: { mode: "bonus", amount: (rank, {LV}) => n, status?, preset?, controls? }`**: an extra purple amount **on top of** each white hit. `amount` returns 0 when the passive is off. `status` makes it depend on a status the card's own `lckProc.applies` puts on the target (Deadly Frost: `"frost"`); in the sim it is checked **before** that hit's own proc, so a hit's status only powers later hits, matching the source order. `preset` is a 0/1 dep meaning "the target already has it" (default 0). `controls` are deps rendered in the damage header (0/1 → toggle, wider → rank icon). Used by Penguin Arctic Wind (Deadly Frost), Frozen Blast (Frozen Break × `PENGUIN_TARGET_ICE_DEP`), and 9 Panda cards via the shared `PANDA_SHADOWFIST_PROC`.
* **`dmgGroups[i].effectDamage: true`**: every hit of that group is purple (Whale Megalodon's 4 pull ticks). `calcRangeFor` tags such a group's range `.purple` and `finalRangeForRange` sends it down the purple path.
* **Final range = one envelope per hit:** replace = `[min(white, purple), max(white, purple)]` (only when the chance is above 0); bonus = `[white min, white max + bonus]`. The total subtracts one bonus when a `status` bonus can't hit the first tick. The end that comes from purple is drawn with `.dmg-effect` (not done for `dmgGroups` cards, whose sums always hold both).
* **Sim totals:** any card with `effectProc` or a purple group shows a big **gold** total (`dmgdigit_y0–9`: the purple digit textures with the purple fill recoloured to `#d4af37`, white outline kept) with the white and purple totals under it (`.sk-mix-parts`; the purple one is hidden at 0). Each hit popup is white or purple (a bonus adds a purple number beside the white one). No "puncture" label.
* **Implementation:** `rollOneHit(..., opts)` does the replace roll and sets `lastRollPurple`; `revealMultiHit` adds the bonus and splits `group.white` / `group.purple`. **Validator:** `[RANGE/SIM]` covers replace rolls and purple groups automatically; §3m (`[EFFECTPROC ERROR]`) checks the proc rate, rank 0 = never, the purple groups, every bonus amount and the 10 gold digits.
* **To wire when each card gets its `/sd` pass** (found by a source survey, all confirmed white + purple in one cast): Whale Combo 1–3 (Wall Puncture, replace), ~~Wolf Combo 1–4~~ (done 2026-09-24 with `effectDamageDep`, see below), Cat Open Wound #443 (bonus `30×(disarm+bleed)` with an internal cooldown, 15 skills), Mole Smart Shell (bonus 30: Time Nuke, Stun Grenade, Mine, Stun Mine), the remaining Panda Shadow Fist users (Combo 1–5). Needing their own design: Bison Colossal Weapon (splash onto *other* targets) and Bat Merciless Drain (uncertain decompiled condition).

### Equipment crit, toggle-driven Effect Damage and header controls (`critProc` / `effectDamageDep` / `dmgControls`, added 2026-09-24 for Wolf Combo)

* **`dmgControls: [dep, ...]`**: deps rendered as icons in the damage header (0/1 → `renderDmgToggle`, wider → `renderDmgRankToggle`), for cards whose damage reads several deps directly in their functions (Wolf Combo: Feral Instinct 0–4, Wild Heart, Dark Edge, G. Marshal Sword, G. Champion Sword).
* **`DEP_EXCLUSIVE`** (global map, next to the Wolf deps): turning a toggle on switches off the ids it lists. Marshal and Champion list each other, since only one equipment set can be worn.
* **`critProc: { chance: (rank) => base, mult }`**: a crit roll on the truncated raw value, before `hit()` or Effect Damage: `floor(random×100) < lckAdjust(base)` → `floor(mult × raw)`. The range's max becomes the crit max whenever `base > 0`. The sim labels a crit hit `crit`. Pair it with a display-only `lckProc` (`simulate:false`) for the chance chip. Wolf Combo: `getCritPlus`, full Marshal set = 12, full Champion set = 18, `mult 1.8` ([wolf-skill-reference.md](../../12t_reference/wolf-skill-reference.md), "getCritPlus").
* **`effectDamageDep: dep`**: while the dep is on, the whole card takes the Effect Damage path (purple digits, no dmgAdjust/defAdjust/direct-hit reduction, `hitMod` rounded down, enemy DEF not highlighted). `skillEffectDamageOn(skill)` is the one check for "is this card purple right now"; use it instead of reading `skill.effectDamage` directly. KO is the card's own `ko` function (Wolf Combo: `0` under Dark Edge).
* **`effectLckRoll: true`**: on a purple hit, add the source's own `Random(0, ceil(0.2×LCK))` after the crit (Dark Edge's `hitDmg + Random.Range(...)`); the range adds `lckSpreadRange(LCK)[1]` to the max.
* **Validation:** §3f only runs deps at default/off (crit and Dark Edge are off by default), so §3o (`[WOLF COMBO ERROR]`) checks Wolf Combo across every Feral Instinct / Wild Heart / Dark Edge / gear combination at two stat profiles, plus the coefficients, hit counts, KO, crit rate and purple flag.

### LCK-Difference Damage (`lckDiffCoeff` / `lckDiffDep`, added 2026-09-19 for Cat Lucky Card)

For a skill whose raw damage depends on the **difference** between the attacker's LCK and the target's LCK (Lucky Card: `int(0.5×ATK + Random(0, k×max(LCK − targetLCK, 0)))`, `Cat.cs:20845`), the calculator reads the player LCK input and the **Enemy Stats LCK** input (default enemy: Carron, LCK 2):

* **`lckDiffCoeff: (rank) => k`** — adds a random roll `0 … k × max(LCK − enemyLCK, 0)` to raw damage. It extends the **maximum** of the raw range only and is clamped at 0. Shown as a `.dmg-lck` term in the formula grid whose big number is the range `0~max` (plain `0` when there is no LCK lead) with the caption `(k×ΔLCK)`.
* **`lckDiffDep: { …dep, coeff }`** — a dependency (e.g. `CAT_JOKER_DEP`) that adds `coeff × (LCK − enemyLCK)` **without clamping** (it can be negative), applied after the first integer truncation, shifting **both** ends of the range. In the formula grid it is a `.dmg-lck` term captioned `(coeff×ΔLCK Joker)`, drawn as `− n` (not `+ -n`) when it is negative. Its toggle renders in the damage header like other damage deps and shares state, by `dep.id`, with a `lckProc.dep` on the same card.
* **`lckDiffOwn: true` / `lckDiffExclusive: true` (added 2026-09-20 for Cat Lucky Dice):** for a roll on the caster's **own** LCK only (`Random.Range(0, sLv × LCK)`, `Cat.cs:23939`), `lckDiffOwn` makes the "target LCK" 0 (the Enemy Stats LCK is not read) and the caption reads `k×LCK` instead of `k×ΔLCK`; `lckDiffExclusive` lowers the displayed maximum by one because `Random.Range(int, int)` excludes its upper bound (the simulator's continuous roll, truncated, already tops out there). `lckDiffDep` works unchanged (Roll the Dice = `coeff:1`, an unclamped `+LCK` on both ends) and its toggle label/caption comes from the dep's `label`. `scripts/validate_skills.js` §3e-ii covers both flags.
* The `[LCK FLOOR]` validator check runs such a skill with the dep **off** (a deterministic LCK term legitimately moves the minimum); `scripts/validate_skills.js` §3e tests both fields through the real range code and the real `rollOneHit`, including the negative-difference cases.

### Range-vs-Simulator Consistency (`[RANGE/SIM]`, added 2026-09-19)

The Final Damage range on a card (`finalRangeForRange(calcRangeFor(text))`) and the Test/Simulate button (`rollOneHit`) are two separate implementations of the same pipeline, so they can drift. `scripts/validate_skills.js` §3f rolls the real simulator 2000 times for **every** single-hit skill rank with a computable damage formula and fails (`[RANGE/SIM ERROR]`) if any roll falls outside the displayed range. It runs each skill with dependencies at default **and** all off, and with the sandbox's zero player stats **and** a high-stat profile (ATK 200 / TAL 200 / LCK 150) — a range that only breaks once LCK is non-zero would otherwise hide.

* **When you change `rollOneHit`, change `calcRangeFor` / `afterDefForRange` the same way (and vice versa).** The simulator mirrors the game (`Mechanics-Reference` §2), so when they disagree the range is usually the one to fix — but not always: the Phoenix skills (Fire Ball / Sky Crimson / Instant Blaze) disagreed because `rollOneHit` fed `phoenixOwnStats()` a stale `LCK` (already overwritten with the Phoenix's own), so the *simulator* was wrong. Inside `rollOneHit`, `ATK`/`TAL`/`LCK` are reassigned for own-stats skills; anything that needs the player's real value must re-read `atkEl`/`talEl`/`lckEl`.
* **`range.foldedSpread`:** for an ATK skill, `calcRangeFor` folds the engine's own `dmgAdjust` attacker-LCK spread (`ceil(0.2×LCK)`) into the raw max, and `afterDefForRange` re-applies that spread when computing the final max. So the base for the final max is the raw max **minus exactly what was folded in** (`0` for a `talAdjust` skill, which folds nothing; `rMax` for a flat-ATK skill). Using the raw *min* instead (the old rule) dropped `talAdjust`'s own LCK spread and any skill-specific random term such as Lucky Card's, so hybrid `talAdjust + atkCoeff` skills (Wolf Cross Break, most Whale/Rabbit/Mole/Chameleon attacks, Barrel Bot moves) showed a max below what could be rolled.
* **`KNOWN_RANGE_SIM_MISMATCH`** in the validator lists skills that still disagree, each with a reason (currently none). It only suppresses; remove an entry as soon as its skill is consistent. Do not widen a range to make a skill pass.

### Panda Current SP Input & Focused Art Scaling (`hasCurrentSp`, added 2026-09-20)

Panda combat skills scale base attack damage using current SP via the Focused Art passive (`getFocusedArtDmg() = 0.5×SP×focusedArtLv`, `Panda.cs:10841`). In skills such as Three Steps (`0.4×(ATK + getFocusedArtDmg())`), this contributes `0.2×SP×focusedArtLv`:

* **Explicit consumer gate (`usesFocusedArt: true`, added 2026-09-22):** Focused Art is never inferred from `class:"Panda"`, `dmg`, or `atkCoeff`. Set `usesFocusedArt:true` only after the skill's own cast-site contains `getFocusedArtDmg()`; this gate controls the simulator, formula row, final range, and Current SP input together. Three Steps and Rushing Falcon are verified consumers. Wind & Cloud is not: all nine hit sites use `0.4×ATK + talAdjust(5×sLv)` with no Focused Art call (`Panda.cs:36791`, `:36900`, `:37061`, `:37165`, `:37269`, `:37373`, `:37504`, `:37608`, `:37693`).

* **`hasCurrentSp: true`** — renders an interactive `SP [ 50 ]` input control directly on the skill card in the formula header row alongside dependency toggles (default: 50). Changes dynamically re-evaluate the formula grid, final damage range, and simulator rolls in real time. The input shows for `usesFocusedArt` **or** `hasCurrentSp` (2026-09-24), so a skill that reads SP some other way can use it without the Focused Art term: Ashura Fist sets only `hasCurrentSp` and reads the global `pandaCurrentSp` inside a function `dmg` (`(rank)=>"talAdjust("+Math.floor(0.25*pandaCurrentSp*rank)+")"`).
* **`dmgSub` on a `talAdjust` base (2026-09-24):** `dmgSub` (string or `(rank)=>string`) now also captions the white base number of a `talAdjust(N)` formula (default term order), not only the flat-damage path. Use it when `N` is not a constant, e.g. Ashura's `0.25SP` / `0.5SP`.
* **Focused Art Term Separation:** Focused Art is rendered as an independent, explicit term outside the ATK bracket (`+ 0.2×SP`), colored with `.dmg-sp`.
* **Second `talAdjust` term (added 2026-09-23, Crushing Monolith):** a `dmg` text may hold two terms, `talAdjust(A) + talAdjust(B)`, when the source makes two separate `talAdjust` calls. Each rolls its own LCK spread and truncates on its own (never merge them into `talAdjust(A+B)`). `rollOneHit` rolls the second term independently, `calcRangeFor` adds its `[min, max]`, and the formula grid renders it as base + TAL terms captioned by `tal2Sub` (group or skill field). `validate_skills.js` §3f now checks `dmgGroups` cards group by group, so these rolls are range-checked.
* **Target HP input (`targetHpInput:true`, Death Blow, 2026-09-24):** an `HP` pill (global `pandaTargetHp`, default 1000, min 1) that feeds the card's `lckProc.calc` instead of a damage formula. Typing updates the LCK chip's value and base text in place. `lckProc.baseText` is now called as `baseText(rank, LCK)`, so it can show LCK-dependent text (Death Blow: "ตายแน่นอนเมื่อ HP ≤ lckAdjust(20×rank)").
* **Target weight / height inputs (Tiger Toss, Crumbling Mountain):** `targetWeightInput:true` shows a `น้ำหนัก` pill (0–59, var `tWeight`) while Tiger Pounce is on; `targetHeightInput:true` shows a `สูง` pill (metres, one decimal, var `tHeight10 = round(h×10)`) while Crushing Monolith is on. Both reuse the SP input's live refresh. The variables are substituted in `substituteDmgVars()`.
* **Nine Steps Sequence Escalation:** When the Nine Steps toggle (`PANDA_NINESTEPS_DEP`) is off, the formula displays as a single uniform row. When toggled on, it expands into 3 distinct formula rows (`Step 1 (1x)`, `Step 2 (2x)`, `Step 3 (3x)`), scaling base ATK, TAL, and the Focused Art bonus across the sequence via `stepMult`.


## 5. Summon Mechanics, Companion Movesets & Summon Stat Cards

When working with summon skills (Barrel Bot, King Kaiser, Auto Gyro Gun, Phoenix, etc.):

1. **Main Summon Card vs Child Moveset Cards:**
   * **Main Summon Card** (`mole_barrelBot`, `mole_kingKaiser`, `mole_autoGyroGun`):
     - Displays the full 9-stat Summon Status grid (`mhp`, `atk`, `def`, `agi`, `vit`, `mag`, `cha`, `tal`, `lck`).
     - All 9 stats colorize/accent when responsive to summon upgrade toggles (`heavyBuilt`, `synchroMole`, `doubleBot`, `hiddenTurret`).
     - Omits `.sk-dmg-row` when summon cast deals no direct damage.
   * **Child Moveset / Summon-Attack Cards** (`King Kaiser - Normal Attack`, `Barrel Bot - Mega Punch`, `Auto Gyro Gun - ยิงปกติ`):
     - Displays summon stat row with **selective glowing**: only stats actively used by this move's calculations glow. Inert stats are dimmed (`.sk-summon-stat-unused`).
     - Uses **summon's own stats** (`ownStats`, `ownStatsKaiser`, `ownStatsGyro`, `ownStatsDmgOnly`), not player's stats.
2. **LCK Stat Separation for Summons:**
   * Summon's own LCK (`agg.lck`, `bb.lck`, `kk.lck`) is strictly the **attacker's LCK** for hits (`dmgAdjust`).
   * Summon's **duration / channel variance** originates from the PLAYER. Always calculate duration variance using **Player CHA and Player LCK**, NEVER summon's LCK.
3. **Duration Chip Suppression on Sub-Attacks:**
   * Attacks defining duration strictly for simulation hit count math must declare `hideDurationChip: true`.
4. **Resource Badges / Cost Policy on Summon AI Moves:**
   * Automated summon pet attacks / AI moves must omit `cost` completely (never show "Free" or SP/MP badges).
5. **Stat Accent Tokens:**
   * Core stats use dedicated CSS variables (`--stat-atk`, `--stat-def`, `--stat-agi`, `--stat-vit`, `--stat-int`, `--stat-cha`, `--stat-tal`, `--stat-lck`, `--stat-lv`, `--stat-hp`).

---

## 6. Compatible Skills Navigation (`compatSkills`) Conventions

1. **Bidirectional Policy:** Every `compatSkills` edge must be reciprocated. If skill A lists skill B, skill B's own `compatSkills` must list A back. Sibling-to-sibling mesh links are allowed where beneficial for player navigation.
2. **Header & Typography:** Header is strictly `<p class="sk-compat-title">สกิลที่เกี่ยวข้อง</p>` (Google Fonts **Prompt**, Brass Gold `14px`). Redundant badges (`LINK`, `MASS CAST`, `MOVES`) are prohibited.
3. **Container & Chip Geometry:**
   * Button `.sk-compat-item`: `height: 44px; display: flex; align-items: center;`.
   * Icon `img.sk-compat-icon`: `width: 42px; height: 42px;` occupying full inner height.
   * Skill name `.sk-compat-name`: `-webkit-line-clamp: 2;` staying within 42px height boundary.
4. **Grid Layouts:**
   * Multi-item: `.sk-compat-grid` (`repeat(auto-fill, minmax(170px, 1fr))`).
   * Few-item (2–4): `.sk-compat-few-grid` (`repeat(auto-fit, minmax(170px, 1fr))` in 1 single row on desktop).
   * Single-item (1): `.sk-compat-single-grid` (`max-width: 340px;` with `"คลิกเพื่อดูสกิล →"`).

---

## 7. Player Stat Input Highlighting (Stat Signature Accents)

Controls the highlighting of the player's global stat inputs (`.sk-controls`: ATK/DEF/TAL/AGI/VIT/CHA/INT/LCK/CHAR LV) when the selected skill's chips read that input:

1. **`getUsedPlayerStatKeys(skill)`**: Reads `SKILLS` fields directly (`cdWrapped`, `castWrapped`, `durWrapped`, `dmg`, `atkCoeff`, `defCoeff`, `lckProc`, dep objects) and returns active stat keys.
2. **CSS Styling**: `.sk-stat-glow-<key>` classes apply `--sg-color` as input border, label color, number text color, and soft static `box-shadow` (no animation).
3. **CHAR LV (`lv`) Live-Toggle Gating**: LV only glows when its controlling dependency is actually toggled on (`getDepRank(dep) === dep.maxRank`).
4. **LCK Direct-Read Rule**: LCK only glows on a direct read (`lckProc`, literal `lckCoeff`, or `lckAdjust()` in formula text). Ambient LCK rolls inside `*Adjust` wrappers do NOT trigger LCK glowing.
5. **Own-Stat Exclusion Rules**: Summon sub-moves exclude player ATK/TAL/AGI according to summon ownership (`ownStats`, `ownStatsDmgOnly`, `ownStatsKaiser`, `ownStatsPhoenix`, `phoenixFireballCd`).
6. **Summon Stat-Feed Glow (added 2026-09-19):** a character input also glows when it **feeds a summon's own stat** that the selected skill's chips read. `getSummonFeedPlayerStatKeys(skill)` (called from `getUsedPlayerStatKeys`) glows a stat only when **both** hold: (a) the dependency that feeds it is switched on, and (b) the summon stat it feeds is in `getUsedOwnStatKeys(skill)` — the same "used" set that highlights the summon's own stat table. Feeds: Barrel Bot / Auto Gyro Gun — Double Bot / Hidden Turret: **CHAR LV** → all stats, Synchro Mole: **TAL** → ATK/DEF; Phoenix — Fire Soul: each stat → the Phoenix's same stat (**INT** → its MAG); Gadina — Earth Soul: the same 8-stat feed, Aegis of Earth: **VIT** → VIT. VIT also feeds the summon's MHP (`mhp = 10×vit`). King Kaiser, Gaos and Ja have fixed stats and feed nothing. This replaced the old ungated LV rules for `ownStats` / `ownStatsGyro`. Validated by `scripts/validate_skills.js` §3k (`[SUMMON FEED ERROR]`).

---

## 8. Interactive Skill Cross-Linking via Description (`desc`)

When authoring skill descriptions with `**bold**` formatting:

1. **Automatic Skill Name Detection (`findSkillByMention`):**
   * Any skill name enclosed in `**...**` (e.g. `**Frozen Blast**`, `**Fireball4**`, `**ท่าโจมตีปกติ**`, `**ไอซ์ ทวิสเตอร์**`) is automatically detected via an O(1) Pre-Indexed Map and converted into an interactive button (`.sk-desc-skill-link`).
   * Clicking the link immediately navigates to that skill card via `selectSkill(targetSkill)`.
2. **3-Tier Disambiguation Priority:**
   * **Tier 1 (CompatSkills):** Matches against the card's own `compatSkills` list first (highest fidelity).
   * **Tier 2 (Same Class):** Matches against all skills belonging to the current class. Note: the linked skill does **not** need to be in `compatSkills` to resolve.
   * **Tier 3 (Common & Global):** Matches against Common skills, then across all other classes globally.
3. **Fast Rejection of Non-Skill Terms:**
   * Numerical values, percentages, arithmetic terms, timers, and general bold phrases (`**+2m**`, `**50%**`, `**15 วินาที**`, `**ต่ำสุดเหลือ 50%**`, `**Shame:**`) are automatically rejected from being links and render as standard `<span class="sk-val">...</span>` gold highlights.
4. **Visual Styling ("Ledger" Aesthetic):**
   * `.sk-desc-skill-link` is a `<button>` using `--gold` text with a subtle ambient gold glow (`text-shadow: 0 0 7px rgba(245, 166, 35, 0.45);`), pointer cursor, and intensified hover radiance (`text-shadow: 0 0 12px rgba(245, 166, 35, 0.9), 0 0 4px rgba(255, 255, 255, 0.6); filter: brightness(1.2);`). No underline (user preference). Styles are scoped to `.sk-hero-desc`, `.sk-support-lv-result` and `.sk-server-popup-body`; all three render through `formatDescTokens(str, skill)`.


---

## 9. Deep Links to Skill Cards

Every skill card has a shareable URL on the GitHub Pages site (`https://jumpptty.github.io/12tails/12t_projects/bible/`; the repo-root `index.html` redirect already forwards the hash):

* **Format:** `#skill-details/<skillId>` with an optional server: `#skill-details/penguin_frozenBlast?server=tot` (`server` is `tot` or `tto`; a server the skill has no override for is dropped, the card opens on BB). `<skillId>` is the card's `id`. The legacy `#skill-cooldown-lookup` alias also accepts a skill id.
* **Opening:** `route()` splits the hash into tool / skill id / `server`, shows the tool, then calls `container._selectSkillById(id, server)` (defined next to `selectSkill()` in `mountSkillCooldownLookup`). An unknown id is ignored and leaves the empty search view. A deep link skips the search-box auto-focus.
* **Keeping the URL in sync:** `selectSkill()`, the server buttons and the two selection-clearing paths call `syncSkillHash()`, which rewrites the hash with `history.replaceState`. `replaceState` fires no `hashchange`, so browsing skills neither fills the back button nor produces GoatCounter hits.
* **GoatCounter stays at tool level:** `getGoatPath()` strips everything after the tool id (`/bible/#skill-details`), so per-skill or per-server paths never reach the counter. Do not add the skill id back to it without deciding that is wanted.
* **Not supported (static hosting):** path-style URLs (`/bible/penguin_frozenBlast`) and per-skill link previews (Open Graph titles/images), both of which would need generated per-skill pages.
* **Validation:** `node scripts/validate_skills.js` drives the real `route()` in its sandbox (section 3b): card opens and hash is rewritten to its canonical form, unknown server dropped, unknown id ignored, legacy alias, and GoatCounter path.

---

## 10. Panda Interactive Mechanics & SP Scaling

1. **Current SP Field (`hasCurrentSp: true`):**
   * Placed in the damage chip header (`.sk-dmg-head .sk-dmg-toggles`) as a single pill container (`.sk-current-sp-wrap`).
   * Displays `"SP"` label alongside a live `<input type="text" inputmode="numeric" pattern="[0-9]*" class="sk-current-sp-input" maxlength="3">` clamped to max 100 (0–100 range matching the 12Tails 100 SP bar limit) without browser spin steppers or inner border containers.
   * **Live Input Handling:** Keystrokes update `.sk-dmg-value`, `.sk-dmg-calc`, and `.sk-dmg-final` in place without recreating or un-focusing the `<input>` DOM node, allowing smooth continuous multi-digit typing. If typed value exceeds 100, it automatically clamps to 100 live.
   * Global state `let pandaCurrentSp = 50;` initializes default SP to 50.
2. **Formula Term Ordering for Panda Damage Skills:**
   * In `renderOneDmgFormula`, TAL terms (`base` + `talCoeff*TAL`) render first, followed by ATK terms (`atkItem`), followed by the independent Focused Art bonus term (`+ 0.2×stepMult×focusedArtLv×SP` in `.dmg-sp`).
3. **Dynamic Group Escalation (`dmgGroups` + `hitCountDep`):**
   * When Nine Steps is OFF, the single base group resolves with hitCount 3 and no label, collapsing into a single formula row and single raw damage number.
   * When Nine Steps is ON (`depRanks[PANDA_NINESTEPS_DEP.id] === 1`), `resolveGroupValue` resolves the base group to hitCount 0 and activates the 3 individual step groups (`Step 1 (1x)`, `Step 2 (2x)`, `Step 3 (3x)`), dynamically expanding the formula and raw damage chips into 3 distinct labeled rows.



## 11. Buff / Debuff Popup: Server Toggle & Quick Switches (added 2026-09-20)

1. **Popup-own server (`bdServer`, `og`/`tot`/`tto`):** the Buff and Debuff popups have their own server selector in the header (same `serverBtnHtml()` icon buttons as the skill-card row). It is **independent** of `currentServer`; it only decides which buff/debuff entries exist and what values they carry. Session-only (resets on reload).
2. **Per-entry server data:** any `STAT_BUFFS` entry or `MOD_DEFS` entry may carry `servers: { tto: { lck: 40, desc: "+40 LCK" }, tot: { hidden: true } }` (field overrides merged over the base entry; `hidden:true` = does not exist on that server) and/or `onlyServers: ["tto"]` (new skill: listed only on those servers). `bdResolve(entry, server?)` returns the effective entry or `null`; the popup lists, `statBonus()`, `playerDamageModCalc()`, `enemyHitModCalc()` and `finalMultCountCalc()` all go through it, so the maths always matches the popup server. Selections are keyed by id and survive server switches (an id that does not exist on the current server is ignored, not deleted). No entry carries overrides yet; add real ToT/TTO values only from verified data.
3. **Quick on/off switches (`buffsSuspended` / `debuffsSuspended`):** a small switch on each Buff/Debuff button (visible only while something is selected) suspends that whole side without clearing the selection: stat buffs, Damage Mod and Final Multiplier for Buff; Target Hit Mod for Debuff. Off dims the button/count and the popup shows an `Off` tag; popup readouts still show what the selection is worth (`force` argument). Purpose: flip between buffed and unbuffed results. Session-only.
4. **Out of scope:** the separate Character Hit Mod tool (`chm*` state) keeps its own sets and reads `MOD_DEFS` directly; it does not follow `bdServer` or the switches.
5. **Final multipliers and per-server overrides in use (2026-09-20):** a `STAT_BUFFS` entry may carry `mult: { int: 1.24 }` — a FINAL multiplier applied after all additive buffs on that stat (`total = floor((base + additive) × mult)`, epsilon-guarded against float error), surfaced through `statBonus()` as an ordinary `+N` addition (`total − base`) so the `+N = total` chip never shows a multiplication. First uses: `recurrentNova5` (ToT only, `onlyServers:["tot"]`, `mult:{int:1.24}`; not in the decompiled source, tooltip "+24% int") and the TTO override of `honor4` (Honor Stand → Lv.5, +50 CHA via `servers:{tto:{...}}`).
6. **Custom buffs / debuffs (2026-09-20):** every popup section header has a `+ Add` button that opens an inline form (name, stat where relevant, value). Entries are `{id, kind, name, stat?, value}` in `localStorage["12t-bible-custom-bd"]` (list only; ON/OFF is session state, and a freshly created entry starts ON). All servers. Kinds: `stat` (Buff, flat +N, integer >= 0, one stat or `all`, joins the additive sum in `statBonus()` before any `mult`), `dmgMod` (Buff, decimal in [-10, 10], added to `playerDamageModCalc()`), `finalMult` (Buff, percent 0-1000, one sequential `ceil` step after the built-in +5%% stacks), `hitMod` (Debuff, decimal in [-10, 10], added to `enemyHitModCalc()`), `enemyStat` (Debuff, flat +/-N, integer |N| <= 9999, one stat or `all`). Rules live in the global pure function `validateCustomBd()` (name required, max 24 chars; storage is re-validated on load and bad/corrupt data is dropped). Rows show a neutral inline glyph (no icon asset) with edit / delete controls; names are HTML-escaped.
7. **Enemy stat changes:** `enemyVal(el)` (typed value + net enemy stat change, input never modified; **not floored** -- the game's `deltaX` setters are plain `stat += n`, so the raw stat can go negative and the formulas clamp it themselves, e.g. `clamp(DEF + R, 1, 512)`) replaces every direct read of the enemy CHA / LCK / DEF inputs in the maths. The enemy panel shows the same `+N = total` chip as the player panel (`-N = total` in red, `.sk-stat-bonus.neg`). `finalMultiplierAdjust(dmg, x)` now accepts either the legacy step count (CHM tool) or an array of percent steps (5 = the verified 1.05 float path, anything else uses integer maths). `scripts/validate_skills.js` checks the validation rules and the final-multiplier maths (`Verified N custom buff/debuff checks`).
8. **Built-in enemy stat debuffs (2026-09-20):** `ENEMY_STAT_DEBUFFS` (same shape as `STAT_BUFFS`, read by `enemyStatBonus()`, listed first in Debuff > Enemy Stats; toggles via `bd-estat`, counted in the Debuff badge, suspended by the Debuff switch). First entry: `shame6` (Bat Shame Lv.6, -60 CHA; source in `bat-skill-reference.md`).
