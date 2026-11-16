# Status Effect Glossary: design (2026-11-16)

## Intent

A new Bible hub tool that lists every status effect in the game, server-only ones included. A player looks a status up and sees four things (user 2026-11-16): **its type** (the classification), **where it comes from**, **what it does**, and **how strong each level is**. Today a player only meets a status as a `[name]` popup on a skill card. Nothing lists them all, nothing says which skills inflict one, and nothing shows one level next to another.

## Goals

- Every status of every server in one searchable, filterable page: 261 known on 2026-11-16 (BB's table 205, 48 more on TTO, 8 more on Reborn; ToT has no table of its own, see Servers).
- For each status: its classification chips, its effect at any level (pills 1 to max), the formula in words, and its sources with the level each one gives.
- The same text as the skill page popups, so the glossary and the popups can never disagree.
- Sources found from the data the page already has wherever possible, so a new card shows up without a second list to maintain.

## Non-goals (first version)

- Monster, boss, map and mission sources (164 BB call sites in 91 monster / boss files and 14 in maps, plus the servers' own). They are the second pass (user 2026-11-16: "try first version first") and can fill the boss guide at the same time.
- A per-level table of every level at once, or bars (user picked the level pills; option 2 / 3 of the mock were not chosen).
- Links from the skill page's status popups into the glossary (a natural follow-up, not asked for).
- Re-wording existing `STATUS_DESC_MAP` popups. The glossary shows them as they are; a wrong popup is fixed in the popup.

## Anti-goals

- A value or effect that is not traced to code (AGENTS.md §4: no approximations, no wiki values). A status whose effect is not researched yet does not ship with an invented line.
- A second copy of any status text (bible-desc-writing "No repetition").
- A source list that calls a mention a source (Immunity *removes* `[poison]`; it does not inflict it).
- Hub start-up cost: the tool builds on first open only.
- A third font, a gold glow on hover, a reduced-motion gate.

## Decided with the user (2026-11-16)

- **Layout C** of three mocks ("Type C"): a type rail on the left, a grid of status icons in the middle, the chosen status in a side panel on the right.
- **Levels: option 1** of three ("Pick a level: pills, then the full popup sentence for that level, with the formula underneath").
- **First version's sources:** skills, gear and pets. Monsters, bosses and maps come later.
- **Icons upscaled** like the skill icons (Real-ESRGAN 60/40 recipe, 128 px WebP).
- **The grid's icons sit in round frames whose colours hint at the status type** (user: "a layer of circle frames border with different colors that hints the type of the status").
- Every status of every server, server-only ones included.

## Approaches considered

**Layout** (mocked, user picked C):
- A, Codex (list + one status): familiar from Special Pet Info, but a long text list hides the icons players recognise.
- B, Ledger table: dense, best for scanning formulas, but the expanded row pushes the table around and phones get a wide table.
- **C, rail + icon grid + side panel (picked):** browses by the icon players know, filters by type in one click.

**Levels** (mocked, user picked 1):
- **1, pills + sentence (picked):** exactly the popup text at one level; always correct, one level at a time.
- 2, a table of only the changing numbers (found by rendering every level and diffing): shows all levels and which source gives which, but its blanks (A, B) read harder.
- 3, bars: shows growth at a glance, needs one "main" number per status.

**Where sources come from** (my call):
- Hand-written table per status: complete control, but a second list that drifts from the cards.
- A generated block written into the page by a script: no drift if re-run, but one more "regenerate before commit" step.
- **Derived in the page from `SKILLS` at first open (picked),** with a small correction table and a validator gate that fails when a status mention is left unclassified. New cards and rank changes flow in by themselves; the corrections are the only hand list.

## Data

### The status list

- **Keys** are the game's own status keys, lower-cased as the page already does (`STATUS_CLASS_MAP` keys). The list is the union of `STATUS_CLASS_MAP` and `STATUS_DESC_MAP` (the page already has 217) plus the 44 statuses found in a game table but not on the page (2026-11-16 scan):
  - BB (23): darkRitual, eraseBoost, flameOfReggu, happy, hpRegen, inferno, lifeBoost, livingDead, loveBind, magicBoost, mount, mpRegen, nemesisLarva, netherBane, noHate, plague, reflect, rejuvenate, revive, sad, speedBoost, whiteFlag, yellowFlag.
  - TTO only (18): abyssDoom, abyssExposure, abyssFreeze, abyssOrbMark, abyssPetrify, abyssShackle, airPoison, airPoisonImmune, crimsonBrand, crystalFrozen, crystalFrozenImmune, dealersMark, gmDropBoost, gmExpBoost, magicWall, spireLink, tempestDance, weak.
  - Reborn only (3): carronGambit, cookFeast, reactorOverdrive.
- Each of the 44 gets the normal research pass before it ships: classification from that build's `StatusData.is*Status` lists, effect from the apply / remove switch and its readers (bible-skill-research, Dead Code Verification Gate). Findings go to `12Tails-Mechanics-Reference.md` (BB and engine-wide), `Reborn-Mechanics-Reference.md` (Reborn only) and the TTO engine section of the mechanics reference (TTO only), then to `STATUS_CLASS_MAP` / `STATUS_DESC_MAP` / `STATUS_DESC_SERVER` like any status.
- **Display name** (my call): the key split at capitals with a capital first letter (`snowMan` → "Snow Man", `hpRegen` → "Hp Regen"), with an override map for awkward ones (`IMMUNITY_LABELS` already names some, e.g. "Art Cancel"). The panel also shows the key as players see it on cards (`[snowMan]`). Search matches the name, the key and the Thai effect text.
- **Engine-only statuses** (my call): statuses no player can see or that only switch an engine flag (e.g. `none`, `mount`, `noHate`) still get a tile, classified System, so the list matches the game's table. `none` is left out.

### Servers

- The rail has a server switch, BB / ToT / TTO / Reborn, remembered with the page's other settings, and following `setToolServer` like the server-balance page.
- A server shows the statuses in its own table: BB the 205, TTO the 253 (all of BB's plus 48), Reborn 213 (BB's plus 8). **ToT** shows BB's set (AGENTS.md: on ToT the BB code applies unless ToT's own data says otherwise; ToT's client is encrypted and its team's excerpts name no status outside BB's table).
- The text on a server is `getStatusDesc(key, lv, lck, server)`, so `STATUS_DESC_SERVER` overrides apply with no new code.
- The panel lists the servers that have the status ("มีบน BB · ToT · TTO · Reborn"); a server-only status says so.

### Icons

- New `assets.js` container `STATUS_ICONS` (in `MANIFEST`, then `node scripts/bible_assets.js stamp`), one 128 px WebP per status key, made with the Real-ESRGAN recipe (×4 from the games' 32 px PNGs, 0.6 anime_6B + 0.4 x4plus, alpha Lanczos, WebP q90). Originals and a manifest are archived in a dated folder under `D:\12tails-assets-archive\`, as for every batch.
- Sources: BB's 218 PNGs in `RippedAssets/.../gamegui/icons/status/` (Reborn's rip has the same 218, lower-cased); TTO-only icons from TTO's decrypted client bundles (`DecompiledSource_TTO_2026-11-02/tools/bundle_decrypt.js` + `aa_catalog.py`); Reborn-only from the Reborn client data. BB's own file names have quirks (`magDdown.png` for `magDown`): map by a small alias table, never by renaming the originals.
- A status with no icon in any client gets a plain round placeholder with its first letter (no invented art).
- The 9 `SKILL_ICONS["status_*"]` entries stay as they are (other tools use them).

### Sources

A source is something that **puts the status on a character**. Everything else that names a status (removes it, blocks it, reads it, needs it) is not a source.

- **Skills** (derived at first open): for every card and server tab (`servers.<srv>` merged over the card) and every rank, with dependency ranks at their minimum and maximum:
  - the card's `status: { name, sLv }` field is a source at that level;
  - each `[nameN]` / bare `[name]` in the desc is classified by its Thai context: **applies** (ทำให้…ติด, ให้ / ได้ [x], ติด [x] at the start of a line or bullet, บัฟ [x] ให้, สุ่มให้), **mentions** (ลบ, ล้าง, กัน / ป้องกัน, ยกเว้น, ระหว่างมี / ระหว่างติด, ที่ติด, หาก…ติด…อยู่, แม้ติด, ไม่ติด, นับรวมเลเวล), or **unsure**;
  - `STATUS_SOURCE_FIX` (`"<cardId>:<status>": "apply" | "mention"`, with an optional server) settles the exceptions and every unsure case. The validator fails while any pair is unsure, so a new card's mention must be classified once.
  - The level shown for a skill source is the min–max level over its ranks (and dependency range), e.g. Typhoon "Lv 2–8"; a source with no level in the data shows no level.
- **Code cross-check** (BB only): a card classified as a source must belong to a class whose code applies that status (`RPC_AddStatus(` / `.addStatus(` with that key in the class's `<Class>*.cs` files or its summons). A miss fails the validator unless `STATUS_SOURCE_FIX` marks the pair as checked (a key passed in a variable).
- **Gear** (hand table `STATUS_SOURCES_GEAR`, researched): the item procs in `CharacterControl.cs` / `GameGui.cs` (44 BB call sites: Poseidon `hpDrain`, Frozen `mpDrain`, Mummy plague, Boxing Glove `ko`, …), each `{ item ids, status, level, chance, cite }`. Item names and icons come from `GEAR_DATA` / `GEAR_ICONS`. Known server deltas (TTO: some procs lose `lckAdjust`, user-reported 2026-09-28 / 10-25) show as that server's note.
- **Pets** (hand table `STATUS_SOURCES_PET` from `12Tails-Mechanics-Reference.md` §4.9): pets that put a status on someone (not the anti-status pets, which block). Each row links to `#pet-info/<id>`.
- **Max level** of a status on a server = the highest level any of its sources gives there. A status whose text does not depend on level (a string entry) shows no pills.

## Page

- **Tool entry:** `TOOLS` id `status-glossary`, title **สารานุกรมสถานะ**, short title **สถานะ** (my call; ค่าสถานะ already means stats on the monster page), category `Reference`, `fact: () => [count, "สถานะ"]`, art a fan of status icons as a placeholder until the user picks art (as Special Pet Info did). Deep link `#status-glossary/<key>` with `?server=<srv>`; `route()` opens it.
- **Desktop (layout C):** one screen, no page scroll; the grid and the panel scroll inside themselves.
  - **Rail (left):** the server switch, then ทั้งหมด and one row per type with its count: Buff, Debuff, then Physical, Magical, State, System, Lock, Shield, Crowd Control (TTO's list). Each row carries the colour its ring uses (the legend). Facet rule of the server-balance page: a count follows the search and the server but not its own pick; a choice that would show nothing is greyed; clicking the picked row again goes back to all.
  - **Grid (middle):** a search box (status name, key or effect text, 150 ms after typing), then the tiles, A to Z: the icon in its type rings and the name under it. A tile is a button; the chosen one is outlined.
  - **Type rings (the user's frame layer; colours my call):** two concentric rings round each icon. The **outer ring is the status's nature**: Physical orange, Magical violet, State blue, System grey; Shield cyan and Lock / Crowd Control teal / pink replace the nature colour where they apply. The **inner ring is its side**: Buff green, Debuff red, both = half and half. The rail rows use the same colours, so they double as the legend, and the chips in the panel say it in words (colour is never the only cue).
  - **Panel (right):** the big icon in its rings, the name, the `[key]`, the classification chips, the servers that have it; then **เลเวล** pills 1 to max (levels no source gives are dimmed but still pickable); **ผลที่เลเวล N**: the popup sentence for that level, rendered by the popup's own renderer (`renderStatusTip`'s pipeline, so `**`, `__`, `^^term^^` and `[status]` work; a `[status]` inside the text opens that status in the glossary); under it **สูตร**: the same entry with no level (the words-formula the popups already have); an LCK box only for entries that take LCK; **แหล่งที่มา · N**: skills first (round skill icon, name, class face, "Lv a–b", link to `#skill-details/<card>?server=<srv>`), then gear (item icon, name, chance), then pets (link to Special Pet Info).
- **Phones (≤ 760 px):** the rail turns into a horizontal strip of chips (server switch first), the grid is 4-5 tiles wide, and the panel opens below the grid when a tile is picked (scrolls into view). The page scrolls normally.
- **Remembered** in `localStorage` `12t-bible-status`: server, type filter, picked status, picked level. Search is not saved. Every read and write in try / catch; stale values fall back to defaults.
- **Surfaces and fonts:** panels in `THEME_SURFACES` (panel / raised / popup / field as the core rules say); Prompt for text, JetBrains Mono + Prompt for numbers; hover = a small lift or brightness only.

## Checks (`[STATUS GLOSSARY ERROR]` in `scripts/validate_skills.js`)

- Every status of the game tables (BB 205, TTO 253, Reborn 213) has a classification and an icon (or is in the short placeholder list) and a description entry or a researched "no effect of its own" line.
- Every status renders on every server it exists on, at every level 1 to its max and with no level, with no raw markup, `NaN`, `undefined` or code names.
- Every `[status]` mention on every card and server tab resolves to apply or mention (no unsure pair left); every BB apply passes the code cross-check or is marked checked; every `STATUS_SOURCE_FIX` key names a real card and status.
- Gear and pet rows name real items / pets; the `TOOLS` entry, the deep link, storage cleaning (blocked, empty, stale), the facet counts and a mount on stubs.

## Docs to update

- `.claude/skills/bible-hub-tools/SKILL.md`: a "Status glossary" section (layout, data, sources rule, checks).
- `.claude/skills/bible-desc-writing/SKILL.md`: one line that the glossary shows `STATUS_DESC_MAP` / `STATUS_DESC_SERVER` as they are, so a popup's wording also reaches the glossary.
- `12Tails-Mechanics-Reference.md`, `Reborn-Mechanics-Reference.md`: the 44 statuses' findings.
- `CHANGELOG_DATA` entry per commit (Thai commit subjects).

## Left to the builder

- Exact colours of the rings (dark tokens only, in step with the chip colours already used by the popups).
- The Thai-context patterns of the source classifier (start from the list above, extend while classifying).
- Tile and panel sizes, the phone breakpoints inside the ≤ 760 px rule.
- The placeholder art for the menu.
