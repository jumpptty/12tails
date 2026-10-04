# Bible Deliverable Guidelines (`12t_projects/bible/`)

Mandatory rules, UI conventions, card schemas, verification pipeline and file-safety rules for `12t_projects/bible/index.html`. History and rejected designs live in git, not here. Where a rule names a validator error (`[XYZ ERROR]`), `node scripts/validate_skills.js` enforces it.

---

## 1. Large File Handling & Crash Prevention Protocol (~15 MB)

`index.html` embeds every game icon as base64 (`SKILL_ICONS`, currently ~lines 7,500–10,300; `CLASS_ART` / `CLASS_PORTRAITS` near ~22,100). Line numbers drift; locate blocks with `grep -o`.

1. **Zero base64 ingestion:** never read, grep or dump the base64 blocks. Inspect icon keys with a small Node scratch script that prints key names only.
2. **Out-of-process patching:** every change to `index.html` is a small Node script in the scratch dir that loads the file, replaces the target in memory, writes it back and prints one confirmation line. No IDE edit tools on this file. For card fields use **`scripts/card_edit.js`** (`add-field` / `set-field` / `add-compat [--both]` / `replace`, `--dry-run`): it edits one card's top-level fields only (strings, template literals and `//` / `/* */` comments are skipped while scanning), backs the file up to `<os temp>/12t-bible-backups/` and refuses to save when the page script no longer parses (e.g. a raw line break inside a string). `node scripts/card_edit.js --selftest` checks it.
3. **Git checkpoint before every phase:**
   * A dirty `index.html` = uncommitted card work. Make a local WIP commit before running any patch script. Preserve unrelated changes; don't commit or revert them.
   * **Never run `git checkout` / `restore` / `reset` / `stash` on `index.html`.** Every patch script first copies the file to its scratch folder (`index.<timestamp>.bak`); recover from that copy.
   * **Never replace a whole card line.** Change only the specific fields (one `key:value`, one `compatSkills` id). Retyping a card silently drops fields.
   * `[FIELD LOSS ERROR]`: a card lost a field it had at `HEAD`. Deliberate removal: `--allow-field-loss=<cardId:field,...>`. `[DOC BACKLOG]` counts app skills with no class-reference entry (`--list-doc-backlog` lists them).
4. **Changelog gate & verification:** before committing, prepend a `CHANGELOG_DATA.entries` item with the current ISO timestamp and the **exact planned commit subject**, then run `node scripts/validate_skills.js` (skills, formula permutations per rank and dep, icons).

---

## 2. Deliverable & Visual Design Conventions

* **Self-contained single file** that runs by double-click, no server.
* **"Ledger" design system:** lacquer ground `#141311`, brass-gold `#d4af37`, oxblood `#8b1e1e`, high-contrast type.
* **`.sk-hero-desc`** (description box right of the hero icon/title): `flex:1; min-width:0; margin-left:14px`; gold accent bar (`background:var(--panel); border:1px solid var(--line); border-left:3px solid var(--gold); border-radius:4px; box-shadow:0 1px 3px rgba(0,0,0,.3)`); font **Prompt** 12px / 1.42, `var(--muted)`; no height limit; full width under the title on mobile; **no native `title` tooltip**.
* **Authored-text markup** (card `desc`, support results, server `changeNote`, glossary text). All of it renders through one function, `renderRichText(str, skill, lck)` = `renderStatusKeywords(formatDescTokens(...))`; any new text surface calls it. The styles (`.sk-val`, `.sk-val-red`/`.sk-tip-red`, `.sk-desc-skill-link`, `.sk-mech-link`, `.sk-status` + popup) are global, never per-container.
  * `**value**` → gold bold (`.sk-val`); a skill name inside `**…**` becomes a link (§8).
  * `__value__` → oxblood bold (`.sk-val-red`, `var(--seal)`) for downsides/warnings.
  * `[statusName]` / `[statusName3]` → purple hoverable status (trailing digits are literal text).
  * `^^term^^` → teal glossary link (see Mechanic glossary below).
  * Stat names may use `<span class='dmg-agi'>AGI</span>` (`.dmg-tal/atk/def/agi/vit/int/cha/lck`).
  * Server `changeNote` bullets start with a tag that `formatServerNote()` turns into a chip: `[Buff]` green, `[Nerf]` red, `[Adjust]` / `[Rework]` blue, `[Fix]` violet (a server bug fix, e.g. ToT Chameleon crit gear). Bullets are separated by `\n`, not `<br>`.
* **Status keywords (`STATUS_CLASS_MAP`, `STATUS_DESC_MAP`, declared just before `const SKILLS`):**
  * `STATUS_CLASS_MAP` is the single source for a status's classification string (e.g. `"Debuff, Magical, Lock"`). Add an entry only after checking `StatusData.cs`'s `is*Status` functions **and** the generic per-status switch in `CharacterControl.cs` (§3.0 item 4). An unmapped name renders as plain bracket text (= still needs research).
  * `STATUS_DESC_MAP` gives the optional 2nd popup line: a string, or `(sLv) => string` for level-scaled effects (`getStatusDesc(name, sLv)` passes `null` for `[name]` with no digits → formula in words; a number → computed value). Verify values at the **apply site**, not the `removeStatus()` mirror.
  * **Per-server popup text:** `STATUS_DESC_SERVER[server][name]` replaces the `STATUS_DESC_MAP` entry on that server (`getStatusDesc(name, sLv, lck, server)`, server defaults to the skill page's `currentServer`). Used for ToT `holywolf`.
  * **No repetition:** a fact goes in either the status popup or the card `desc`, never both. What the status does → `STATUS_DESC_MAP`; the card names it (`[ashura${rank}]`) and says only what the skill adds.
  * Status mentions inside `STATUS_DESC_MAP` link to other statuses; cycles stop at the repeated name. Popup is a real nested `<span class="sk-status-tip">` built by `renderStatusTip(cls, desc)` (shared by `[name]` and the `status:{}` badge). CSS gotchas: `white-space:pre-line` on the absolute popup needs `width:max-content`; the divider span needs `display:block`.
  * **Auto-badge vs inline:** a card's `status:{name, sLv, class}` auto-prepends a badge (`sLv` may be a per-rank function). Any `[name]` of that status in the `desc` (name-only, case-insensitive) suppresses the auto-badge entirely; a card showing two levels places both inline. Use bare `[name]`, never hand-written `<span class="sk-status">` (the renderer skips pre-wrapped spans as a fallback).
* **`liveCheck: "<Thai text>"`** (card field): a value nobody can derive from the code (e.g. a private-server patch that gave no numbers, `servers.tot.liveCheck` on Twin Resonance). Renders as the last line of the description box, `⚠ ยังไม่ยืนยันในเกม: …` (`.sk-live-check`, `--seal`). **A Thai tooltip that disagrees with the code is a `tooltipNote`, never a `liveCheck`** (all eight former tooltip liveChecks were converted 2026-10-02). `[LIVE CHECK ERROR]`.
* **`tooltipNote: "<Thai text>" | (rank) => string`** (card field): the in-game tooltip states a misleading value or rule (base duration, damage, chance, a missing or wrong effect) and the code is verified. Renders red under the desc as `ⓘ คำอธิบายในเกมไม่ตรงกับโค้ด: …` (`.sk-tooltip-note`); a rank-gated note returns `""` for ranks that match. Phrase it "บอกว่า … แต่โค้ดจริงคือ …" with `**values**`. **Compare against the Thai tooltip only** (`<Class>Skill_thai.cs`): players do not read the English one, so a mismatch that exists only in `<Class>Skill_eng.cs` is not listed, and the note quotes the Thai values. A mismatch never goes inline in the `desc` as a red `__คำอธิบายในเกม…__` line (all 50 were moved into `tooltipNote` 2026-10-02); `[TOOLTIP NOTE ERROR]` fails on an inline one and on a `tooltipNote` that renders at no rank. Mere omissions ("the tooltip omits the KO") stay in the class reference only.
* **`durAdjust: "tal"`** (card field, default CHA): the Duration chip runs `talAdjust` with the player's TAL instead of `chaAdjust`, wears the TAL colour (`.sk-stat-dur-tal`, value and accent bar) and makes TAL glow instead of CHA (`getUsedPlayerStatKeys`). Used by Stun Mine on BB (`Mole_stunMine.cs:60`, a BB bug: Landmine uses `chaAdjust`). `[DUR ADJUST ERROR]`.
* **`bbBug: "<Thai text>"`** (card field): the BigBug client code itself misbehaves (a cooldown that is never checked, a bonus that is never applied, a level table that stops growing). Renders red as `🐞 บั๊กของตัวเกม (BB): …` (`.sk-bb-bug`). Cite the source in the class reference.
* **Monster stats page (`mountMonsterStats`, TOOLS id `monster-stats`):** a searchable, race-filtered, column-sortable table of `MONSTER_STATS` (every `CharacterControl` decoded from the original client: Name, Type, race, Lv, max HP/MP/SP/KO, the 8 stats with `mag` shown as INT, weight, run speed, and whether the row is the Resources prefab or a map copy). Default sort is Lv ascending. English text uses Chakra Petch and numbers JetBrains Mono (both already loaded; Thai falls back to Prompt). Its own wide stage (`html.tool-monsters`, up to 1500px) and a window-height scroll box with a sticky header and name column. Data and method: [12Tails-Mechanics-Reference.md §5.2](../../12t_reference/12Tails-Mechanics-Reference.md). Filter, sort and search are remembered in `localStorage` (`12t-bible-monsters`). Regenerate the data from the raw files, never edit rows by hand. `[MONSTER STATS ERROR]`.
* **Boss guide page (`mountBossGuide`, TOOLS id `boss-guide`, data `BOSS_GUIDE`, tile `badge: "Experimental"`):** a boss picker (tabs, ←/→ keys, remembered in `localStorage` `12t-bible-boss`, deep link `#boss-guide/<id>`) and one page per boss: hero (name, stats, immune list, flat armor, HP bar marking where each move starts being used), a to-scale top-down **range map** (`mapR` metres; each move's `zone` list of `circle`/`donut`/`rect`/`rays`/`arrow`/`mark`, forward = up, `at` = metres in front, `side` = metres to the side), the AI cycle and priority ladder (first matching rung wins) and the move cards (no strategy section: removed 2026-10-04 at the user’s request). Hovering, focusing or tapping a move card or ladder rung lights its zone (tap pins it). Each boss has its own accent (`.bg-page[data-boss]`, light and dark values); display text in Chakra Petch, Thai headings in Kanit, numbers in JetBrains Mono. "ดาเมจตั้งต้น" is computed from the boss stats (`atk × ATK + talAdjust(tal)` over the TAL + LCK roll, or a flat value); for `kind: "white"` moves (`hit()`) the top end also adds the boss's `dmgAdjust` roll `R ≤ ceil(0.2 × LCK) − 1`, while Effect Damage (`purple`) shows the exact value. It is the damage before the player's DEF. Boss move names are never bolded in the text (a bolded name would link to a player skill with the same name, e.g. Nightmare). Optional boss fields: `hpNote` (an extra hero line, e.g. Ewiniar's five parts sharing one HP pool), move `kind: "move"` (movement-only moves, no damage, `cd: 0` shows as none) and `ship` (Ewiniar: a "กลไกบนเรือ" section with a to-scale top-down ship plan (bow up, data x already in screen space with the ship's right on the right), the cannon table, falloff tiles and expected damage computed from `ship.cannon`, and the armed-saw steps from `ship.saw`; hovering a cannon row or marker lights its trajectory and blast circle). Every value comes from [boss-reference.md](../../12t_reference/boss-reference.md); add a boss there first.
* **Menu tile backdrops (TOOLS `art`):** every menu tile shows the original full-colour portrait(s) from `TOOL_ART`, faded (`.entry-art`, opacity `.22` light / `.2` dark, `.38` / `.34` on hover) and feathered on its left edge so the title stays readable. `art` is a list of `"tool:<key>"` (`TOOL_ART`), `"skill:<cardId>"` (that card’s own icon from `SKILL_ICONS`, drawn square, tilted and fanned out by `--i`) or `CLASS_ART` names; phones show only the first. The skill details tile uses `collage: "skills"` instead: `skillIconCollage()` lays 72 real skill icons (one per card, reshuffled on every page load, from `SKILL_ICONS`, so no extra data) in a grid tilted −11° (`.entry-collage`), feathered on the left. The grid is rendered twice side by side (`.entry-collage-track`, two `.entry-collage-block`s) and slides left by exactly one block (810 px) in a 90 s linear infinite loop (`@keyframes entry-collage-scroll`); it keeps scrolling under `prefers-reduced-motion: reduce` too (user request 2026-10-04). No scale or dice art exists in the ripped assets (checked 2026-10-04), so those two come from Openclipart (public domain CC0), picked for the game’s outlined cartoon look: server balance “Balanza” (openclipart.org/detail/131899), stat roll “Five Colored Dice” (/detail/174804). `TOOL_ART` holds 240 px WebP portraits with alpha from `RippedAssets/.../gamegui/story/characters` (class tiles use the class story portraits) and `icons/targetavatar` (the Golden King Bug avatar is an opaque square, so it gets a radial fade). Current picks: skill details the icon collage, server balance the scale, BB issues Cyborg Mole, monster stats the Stat Scan icon, boss guide Shadow Italus, CHA/AGI optimizer the Lunar Eclipse, Rapid Trance and Immunity icons, stat gain the Super Stat Plus icon, stat roll the dice, Golden King Bug map the Golden King Bug. Chameleon simulator: the Chameleon portrait (its old line-art `.entry-chm-art` mask is no longer rendered, 2026-10-04). A new tool adds an `art` entry.
* **BB issues page (`mountBbIssues`, TOOLS id `bb-issues`, tile `.entry-bug`):** groups every `bbBug`, every `tooltipNote` (all ranks), every red `__…คำอธิบาย…__` / `__…tooltip…__` line found in a desc at any rank, every `liveCheck` (tagged "รอยืนยันในเกม") and `BB_ISSUES_EXTRA` (issues with no single card) by class, with a filter (all / bugs / tooltips). Rows open the card on the original server (`?server=og`). New notes appear there automatically; never hand-maintain a second list.
* **Every `desc` states its reach (verified from source):** a circle (`FindAreaTarget`, a `sqrMagnitude` radius, `findFriends`/`findEnemies`) is `รัศมี **Nm**` with its centre (รอบตัว / รอบเป้าหมาย); a straight-line distance (cast or target range, raycast length, travel) is `ระยะ **Nm**`; a box is `กว้าง / ยาว / สูง` (full width); a cone or fan gives its angle. Target-mode skills with no gate of their own say `ระยะ **40m**` (the target lock, [12Tails-Mechanics-Reference.md](../../12t_reference/12Tails-Mechanics-Reference.md)); self skills say ตัวเอง; skills with no distance check say `ไม่จำกัดระยะ`. A passive that only changes another skill names that skill (its card carries the geometry). When the size lives only in a prefab or animation, say so instead of guessing. A size the code multiplies by the caster's `rangeMod` is written `N×rangeMod m` (a lifetime `N×rangeMod วินาที`, a reach from speed × lifetime too); a plain-number size stays `Nm`, and one box may mix both ([12Tails-Mechanics-Reference.md](../../12t_reference/12Tails-Mechanics-Reference.md), `rangeMod`).
* **Omit from `desc`:** wrapped durations (`chaAdjust`) and wrapped proc chances (`lckAdjust`); chips show them. Also the standard on-hit **+1 SP** (unusual SP gains may be mentioned).
* **`desc` house style (Thai, adopted 2026-10-03).** A player who never read the code must be able to tell what happens, to whom, how often and for how long.
  * **Order:** base line = [เงื่อนไข/ตัวกระตุ้น] → การกระทำ → เป้าหมาย + reach → ผล + ตัวเลข → ความถี่/ระยะเวลา. Then `<br>• ` bullets for extra rules of the base effect, then one `<br>**Skill:** …` line per modifier skill, then `<br>__…__` downsides/limits last.
  * **Every effect says how often it happens:** `ครั้งเดียว` (once per cast/per death/per target), `ต่อฮิต`, `ทุก **N วินาที**` (a tick or periodic check), `ทุกครั้งที่ …` (an event trigger). When a periodic check grants a buff and also does something one-off, give each its own sentence or bullet (Last Hope: the buff is re-granted every check, the heal is once per death).
  * **A duration says what it is the duration of:** a flat duration written in the desc is attached to its status or effect (`[lastHope] นาน **12 วินาที**`). When the card has a Duration chip, the desc must make clear which effect the chip times (normally the status named in the base line). Wrapped durations stay out of the text (rule above).
  * **Who:** ตัวเอง (the caster; never ตนเอง, and use the class animal name only to contrast with a summon or a target, e.g. Phoenix vs ลิง), เพื่อนร่วมทีม (first mention; `เพื่อน` after), ศัตรู, เป้าหมาย (the selected target). Say `รวมตัวเอง` / `ไม่รวมตัวเอง` when allies are affected, and give caps: `สูงสุด **N** ตัว`, `สูงสุด **+N**`, `ซ้อนได้สูงสุด **N** ครั้ง`.
  * **Fixed terms:** วินาที (never วิ / sec / s), เลเวล (never Lv in prose; `[status3]` tokens are fine), ดาเมจ (not ความเสียหาย), ฮิต, ครั้ง, คูลดาวน์, ^^ดาเมจขาว^^ / ^^ดาเมจม่วง^^ via glossary links. Boxes are `กว้าง **N** ยาว **N** สูง **N**` (ยาว, not ลึก) and circles `รัศมี **N** รอบ…`.
  * **No code names in player text:** `talAdjust`, `lckAdjust`, `chaAdjust`, `getDebuff`, `sLv`, `hitMod`, variable names. Say it in words (`ดาเมจเพิ่มตามค่า TAL`, `โอกาสเพิ่มตามค่า LCK`, `เลเวลสกิล`). Allowed: `rangeMod` sizes (rule above), `^^term^^` glossary links, and formulas the card already shows in a chip.
  * **Markup:** numbers, percentages and timers in `**…**` (gold); skill names in `**…**` (they become links); statuses as `[name]` / `[name${rank}]`, never re-explaining what the status popup already says; `__…__` only for downsides and limits; modifier label `**Skill:**` (colon inside the bold, the link resolver strips it).
  * **Numbers never change in a rewrite.** Every claim comes from the class reference or `DecompiledSource/`; an unclear sentence stays as it is and goes on the open-questions list.
* **Dependency-line `desc` format** (skills changed by `compatSkills` modifiers): one base sentence (with verified hit-box `ระยะ / กว้าง / สูง`, full width = `2×BaseWidth`, see [12Tails-Mechanics-Reference.md §4](../../12t_reference/12Tails-Mechanics-Reference.md#4-hidden-mechanics--special-interactions)), then one `<br>` line per modifier `**<Skill>:** <what it changes>`, not repeating values a chip/toggle shows. Example:
  ```
  ชาร์จ **${rank+1} วินาที** แล้วปล่อยหมัดตรงไปข้างหน้า กว้าง **2m** ยาว **1m** สูง **2m** ทำดาเมจรุนแรงตามค่า ATK<br>**Delay Qi:** ค้างหมัดไว้แทนการปล่อยทันที แล้วปล่อยเมื่อกดโจมตีครั้งถัดไป<br>**Qi Burst:** หมัดยาวเป็นเส้นตรงระยะ **6m** (ปกติสั้นเพียง **1m**)<br>**Focused Art:** บวกดาเมจเพิ่มตามค่า SP ปัจจุบัน ณ ขณะโดนเป้าหมาย
  ```
  The modifier passive's card mirrors it: `ทำให้ **<Active Skill>** <what it changes>` (two actives: `ทำให้ **Pummel** และ **Tower Rush** ...`). Both link each other in `compatSkills` (§6).
* **Crit view ("ดูสูตรคริ"):** a card with `critProc` or `rawModel.critBase` (Wolf Combo, Bison Combo, Sheep Book Bash, Sheep Combo, Rabbit Combo) shows a toggle in the damage header (`data-role="crit-view"`, session-only top-level `critFormulaView`). While on, the card shows the crit-proc case: `renderOneDmgFormula` wraps the formula as `⌊1.8 × (…)⌋` (`rawModel` cards draw their own through `formulaItems` ctx `crit`, so the Rabbit shotgun closes the bracket before its Hyper Shot term), Raw and Final ranges are the crit case at both ends, and Test always rolls a crit. It works whatever the gear (the view is hypothetical); `critViewOn(skill)` is the single check. `[CRIT VIEW ERROR]` pins the card list, the formula text, the ranges and range-vs-simulator in the view.
* **`dmgMult: <number>`** (usually inside `servers.<srv>`): a whole-damage multiplier for patch notes that say "+X% base damage" with no formula, applied after the raw value like `dmgMultDep` (`Math.trunc`) in the Test roll, the range and the formula numbers. Used for ToT Panda Tiger Toss / Rising Dragons / Wind & Cloud / Rain & Storm.
* **`critProc.post(v, group)` / `critProc.postLabel(group)`** (Wolf Combo's Katana, `w_wlf59`): a monotonic step applied to the crit-rolled raw value, before `hit()` / Effect Damage (and before Dark Edge's `effectLckRoll`). `rollOneHit`, `calcRangeFor` (both ends and `noCritRange`) and `renderOneDmgFormula` all apply it; `postLabel` returns `[open, factor, close]` to wrap the formula (`⌊0.75 × (…)⌋`, `⌈0.5 × (…)⌉`), or `null` when off. Per-stage variants read a flag on the `dmgGroups` entry (`katana:"half"`).
* **Mechanic glossary (`^^term^^`, `MECHANIC_DESC_MAP`, `#mechanicModal`):**
  * The text between `^^` is the display text and the case-insensitive key, unless `MECH_LINK_ALIASES` maps it to `[key, stepIndex]` (Thai terms, sub-steps: `^^ดาเมจขาว^^`/`^^hit()^^` → `damagepipeline`; `^^ดาเมจม่วง^^`/`^^Effect Damage^^` → `effectdamage`; `^^hitMod^^` → `damagepipeline` step 4). Unmapped → plain text. Works inside status popups too.
  * Entry shape: `{title, steps:[{label, body, examples?:[{icon, name, caption}]}]}`. `body` goes through `renderMechCode` (`` `term` `` → `.mech-code` chip) then the normal markup. Examples use `SKILL_ICONS` keys and state the verified value (apply site, not `removeStatus()`); icons 128px desktop / 72px mobile, no card box.
  * One step per full page (`renderMechSlide()`), ‹ › + dots + ArrowLeft/Right. `openMechanicPanel(null)` = index grid (`renderMechanicIndex()`), `openMechanicPanel(key, stepIdx)` = one step. Deep link `#mech/<key>/<step>` (1-based); closing clears the hash; clicking a title copies `## [topic](link)` via `copyTitleLink()`. Entry point 📖 `#btnMechanicGlossary` in `.hub-bar`.
  * Index tile backdrop art: extend the `if (key === ...)` chain in `renderMechTileBg()` (index tiles only).
  * Phone (≤760px wide or ≤480px tall): full-screen sheet, top-aligned scrolling slide, nav in bottom bar, `fitMechSlide()` skipped, `html.mech-open` scroll-locks the page.
  * Content: Thai, player-friendly, verified, **no `file:line` in the panel**.
* **Basic attacks, charge attacks and passives** get cards only when the user asks.
* **Vertical collapse:** never render an empty `.sk-hero-stats` or `.sk-dmg-row`, no artificial min-heights.
* **`dmgGroups`:** must also declare top-level `dmg`/`atkCoeff`/`ko` mirroring the primary group (else `evalArith("")` SyntaxError). Sequential groups' `hitCount`s must sum to the top-level `hitCount(rank, dmgDepOn, hitCountDepOn)` for every dep combination (`[DMGGROUPS HITCOUNT ERROR]`); `dmgModes:true` cards are exempt. Declare `ko` per group when groups differ (`getGroupKOInfo()` splits/merges chips).
* **Phone layout (<900px, `html.tool-wide-hero`):** no `fitStageToScreen()` scaling; page scrolls; one column (search + card + related first, stats panels after via `order:1`); Test popup fixed at `top:26vh`; stat tooltips under the value (`positionStatTooltips()`); `.view` `animation-fill-mode:none` (its transform would break `position:fixed`). <560px: LCK-variance and Final chips full width.
* **Test uses the server card:** every Test entry point (`revealMultiHit`, the main and per-group Test buttons) starts with `const selected = activeSimSkill()` (= `getActiveSkill(selected, currentServer)`), so `servers.tto` / `servers.tot` damage overrides reach the roll. `[SERVER SIM ERROR]` rolls every server damage override inside its own range.
* **Test button (`simulateBtnHtml()`):** the only filled gold pill (`--gold` bg, `--ink` text), full width under Final. Labels `ทดสอบดาเมจ` / `ทดสอบฮีล` / `ทดสอบ Hate`; starburst icon (✚ for heals); hit count `×10 ฮิต` / `×3–5 ฮิต` / none for single-hit. Per-mode buttons `small:true`. `.is-new` pulses until any Test is clicked (`markSimSeen()`, `localStorage["12t-bible-sim-seen"]` in try/catch; off under reduced motion). `[TEST BUTTON ERROR]`.
* **Dependency strip (`depSink` / `renderDepStrip`, spec `docs/superpowers/specs/2026-09-26-dep-strip-design.md`):** every dep button lives in one `.sk-dep-strip` under the description.
  * Range exactly `0..1` → toggle; anything else → rank selector. `renderDmgToggle` on `0..N` jumps off ↔ max unless the dep sets `cycleRanks:true`.
  * Item = 40px icon (grayscale when off) + `label` + effect tags `CD CAST DUR CHANCE DMG HITS KO SHIELD STATS INFO`, coloured by stat. A dep used at several sites shows once with merged tags.
  * A rank dep may give `iconFor(rank)` / `labelFor(rank)` when its icon or label is not `<icon base><rank>` (Chameleon Piercing Venom / Deadly Venom, target poison level 0-6, crit bow). A duration/cd dep may give `addFor(rank)` for a non-linear addend (Increased Poison 0-3 / Deadly Venom: +2/4/6/10 s). Name a passive's dep id after its card (`increasedPoison` → `chameleon_increasedPoison`) so `[DEP BACKLOG]` resolves it.
  * **Order:** `renderDepStrip()` sorts skill toggles ascending by internal skill ID (`SKILL_INTERNAL_ID`, card id -> lowest `commandNum` of the family in `<Class>Skill.cs` `getSkillTree()`). A toggle is matched to a card by `<class>_<dep id>`, `common_<dep id>`, or its icon key without the rank digit. Gear, target-condition and mode toggles (`DEP_NOT_SKILL`, or no match, or the selected card itself) follow in insertion order. Each item carries `data-dep-order`; a new card needs a `SKILL_INTERNAL_ID` entry (`[DEP ORDER ERROR]`); a new condition toggle that borrows a skill icon goes in `DEP_NOT_SKILL`.
  * Add deps via `renderDmgToggle(dep, TAG)`, `renderDmgRankToggle(dep, TAG)`, `renderDepBlock(dep, rank, "", TAG)`, or `depSinkAdd(dep, TAG, html)`. Non-dep controls (SP/HP/weight/height inputs, Nine Steps rows) stay in the damage header. `[DEP STRIP ERROR]`.
* **Cat Power series (`CAT_POWER_DEP`, id `catPower`, 0..4 = Off / +10% / +20% / +30% / +70%):** base engine applies Power One/Two/Three/Seven/Super Seven to all Cat damage (`CharacterControl.cs:2838-3010`), shared state across Cat cards.
  * **TTO (user-reported):** only Tree A (Gambler) skills, via `isCatPowerApplicable(skill, server)`. Every non-Class-A Cat damage card carries `servers:{tto:{changeNote:"• [NERF] Power 1 2 3 7 and Super Seven มีผลกับแค่สาย Class A"}}` (add it to every new Tree B / Class C damage card); Combo drops Power Seven/Super Seven from `desc`/`compatSkills` on TTO and vice versa. `[CAT POWER TTO ERROR]`.
* **TTO: no LCK roll in `talAdjust`/`dmgAdjust`/`defAdjust` (user-reported):** implemented once as `tdlRoll(R)` (0 on TTO) inside `talAdjustAtRoll`, `dmgAdjustAtRoll`, `defAdjustAtRoll`. Always call these cores, never re-implement the formula. `agiAdjust`/`chaAdjust`/`magAdjust` and inline rolls (`effectLckRoll`) keep their roll. `usesTdlRoll(skill)` offers TTO automatically. The changes popup does not mention it (user decision). `[TTO NO-LCK ERROR]`; a new runtime formula variable needs adding to the sweep's `needsVars`.
* **Open Wound (`CAT_OPENWOUND_PROC`, id `openWound`, default off):** on = target assumed at Disarm 2 + Bleed 2 → `30×(2+2)` = 120 purple per landed hit; on Disarm/Bleed it also adds +3 s to the contested duration. `desc` ends with `**Open Wound:** ดาเมจม่วงเพิ่มเติมทุกฮิต`, or with `effectProc.hits`: `**Open Wound:** ดาเมจม่วงเพิ่มเติม__เฉพาะฮิตที่ x,y__`. Combo uses `catComboOpenWoundLine`.
* **Per-class `SKILLS` order** follows `<Class>Skill.cs` `getSkillTree()` `result = "<class>_<name><rank>"` order.

### Class Badge in the Player Stat Panel

* `.sk-class-badge` opens the player panel: class portrait + name + caption "ค่าสถานะตัวละครของคุณ". Portraits come from `CLASS_PORTRAITS` (96×96 colour PNGs from `minimal_class_icons/bg_removed/<Class>.png`), not `CLASS_ART` (the line-art backdrop). `updateClassBadge(cls)` is called from `renderHero()`; Common skills show the caption only; 40px portrait under `max-height:820px`. A new class needs a portrait (`[PORTRAIT ERROR]`). The Revised Art button sits at the badge's right end.
* **Enemy badge** (`.sk-class-badge.sk-enemy-badge`): its own red card above the enemy stats with preset icon, name, caption "ค่าสถานะตัวละครเป้าหมาย" and the immunities "i" button. Clicking the icon opens a 3-column `ENEMY_PRESETS` picker (closes on choice / outside click / Esc); choosing writes the values and clears "Custom". Hand-edits show "?" + "Custom". Ctrl+Z (outside text fields) undoes enemy changes, 20 deep (`selectEnemyPreset` / `undoEnemyChange`). Long names shrink via `fitEnemyName` (≥9/≥12/≥14 chars → 13/12/10.5px). Enemy panel is always visible; its stat grid keeps an empty first cell to align with the player's CHAR LV column.
* Captions never wrap (`white-space:nowrap`; Thai has no spaces). `[PANEL ERROR]` guards the structure (no toggle, arrows or `.sk-controls-actions` row).

---
## 3. Skill Verification & Quality Assurance Pipeline

### 3.0. Dead Code Verification Gate (checked before declaring ANYTHING dead/unwired)

Never call a mechanic dead, unwired or "not in code" from one file. A field written once in `<Class>.cs` with no read there is usually read elsewhere (precedent: `getFrostBiteLv()` in `Penguin.cs` is read in `Penguin_nAttack.cs:321-359`).

1. Search **every** `DecompiledSource/<Class>_*.cs` companion plus `CharacterControl.cs`, `Damage.cs`, `StatusData.cs`, `GameGui.cs` for the identifier (function, field or `hasSkill(ID)` number).
2. Only then report it as unverified, citing the full search scope.
3. Dead-code claims in `12t_reference/*.md` are prior findings, not ground truth; re-verify the same way.
4. **Statuses:** a status's effect is not fixed by the one `RPC_AddStatus` call you traced. Grep `CharacterControl.cs` (the generic `sType ==` switch) and `StatusData.cs` (classification, immunity/cleanse lists) for the exact status string before describing it. Precedent: `frost` looked cosmetic from its `moveMod`, but is a hard `moveSpeed=0` lock (`CharacterControl.cs:2409-2424`, `isLockStatus` at `StatusData.cs:6160`).

### 3.A. Active Skill Pipeline

#### Step A1: Pre-Flight Active Source Extraction (Zero Assumptions)
No guesses, linear extrapolations or wiki values. Trace:
0. **Cost/req table:** `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` (SP sign: negative = red/consumed, positive = blue/threshold, 0 = none).
1. **Cast dispatch** in `<Class>.cs`: `RPC_<name>`, `DisplayCastBar`, `addTimeOut`, `magAdjust`/`chaAdjust`/`agiAdjust`, per-rank arrays.
2. **Execution** in `<Class>_<companion>.cs`: hit loops, secondary triggers, collisions.
3. **Statuses:** `sType` and `nCode` (`StatusData.cs`), `sLv` per rank, classification (`isBuff/Debuff/State/Magical/Physical/Lock/ShieldStatus`, see [12Tails-Mechanics-Reference.md §4.2](../../12t_reference/12Tails-Mechanics-Reference.md#42-status-classification-cleanse-system-statusdatacs)). `Damage.getDebuff(...)` → `durWrapped:true, durContested:true`; `getDebuffInvert(...)` → `durContestedInverted:true`.
4. **Rank icons:** every `<skill>1..<maxRank>` icon from `RippedAssets/` (§3.B).
5. **Tooltips:** `<Class>Skill_eng.cs` and `<Class>Skill_thai.cs`.
6. **Passive deps:** every `hasSkill(ID)` / `get<Passive>Lv()` hook (`cdDep`, `castDep`, `dmgRankDep`, `durDep`, `koDep`).
7. **Summons:** follow §5.

#### Step A2: Active Review Table
Present to the user: identity (source key, EN/TH name, planned id, class, max rank); cast excerpt (`<Class>.cs:line`); execution/status excerpt; status profile (`sType`, `nCode`, `sLv`, classification); client tooltips; proposed `desc` (client phrasing as baseline, `**bold**` dynamic values, geometry, cleanse thresholds); proposed card schema (§4). Use the compact table format the user prefers.

### 3.B. Passive Skill Pipeline

#### Step B1: Pre-Flight Passive Source Extraction
Scan the 5 hook categories: (1) stat alteration (`getTypeStat`, `calTotalStat`, `calHp/Mp/Atk/Def/Speed`); (2) active-skill modifiers (cd, cast, MP/SP, hit count, projectiles); (3) status/proc hooks (`AttackHit`, `MagicHit`, `mod`); (4) AI/companion (`HeavyBuilt`, `SynchroMole`, `HiddenTurret`); (5) attack augmentation (`nAttack`, `cAttack`). List every active skill the passive alters.

**Rank icons:** a `maxRank > 1` card needs every `<icon base><rank>` key (`[ICON RANK ERROR]`). Source: `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/<skill><rank>.png`, embedded as raw base64.

#### Step B2: Passive Review Table
Hook excerpt (`file:line`), exact arithmetic, affected actives + proposed dep toggles, status profile, client tooltips, proposed card (§4).

### 3.C. Shared Gates, Review & Verification

1. One class at a time; wait for explicit user approval before writing.
2. When a skill depends on a skill with no card, surface that skill to do next.
3. Every verified finding goes into a card field or `desc`; anything that doesn't fit is listed as a numbered remainder for the user.
4. After patching, `node scripts/validate_skills.js` must pass before committing.

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
// Minimal passive
{ id: "class_passiveName", name: "English Name", nameTha: "ชื่อไทย", class: "Class",
  icon: "iconKeyMaxRank", maxRank: 3, passive: true,
  desc: (rank) => `เพิ่มความสามารถ **${rank * 10}%**` }

// Feature-rich passive: add any of these when source proves them
  cd: [10, 8, 6],        // internal proc cooldown
  duration: [5, 5, 5],   // temporary buff
  status: { name: "buffStatus", sLv: [1, 2, 3], class: "Buff Status" },
  lckProc: [15, 20, 25], // proc chance %
```

Passives carry `status`, `cd`, `duration`, `lckProc`, `cost` or `ko` whenever source proves them; empty rows collapse.

### Stat chips

* **Labels:** `lckProc.label` / `secondaryLckProc.label` / `tertiaryLckProc.label` are mandatory, format `"โอกาส " + <descriptor>` (`"โอกาส Frost"`), no "Chance"/"Proc" suffix (`[LCK LABEL ERROR]`). Duration labels (`durLabel`, `secondaryDuration.label`) use `"ระยะเวลา " + <descriptor>` (`"ระยะเวลา Ice"`), no English "Duration"/"Lifetime".
* **`secondaryDuration: {duration, durWrapped, durContested, label}`** → `.sk-stat-dur2`, for a genuinely different second duration (Frost Bite frost vs ice).
* **`secondaryLckProc: {label, chance, applies, ...}`** → `.sk-stat-lck2`, for distinct chances per hit/mode (Spread Shot). Accepts `dep` (gates: off = 0%) or `deps:[DEP, ...]` (toggles shown in the chip, not gating; `chance`/`calc` read them via `getDepRank`). **`tertiaryLckProc`** (`.sk-stat-lck3`, `lck3`) and **`quaternaryLckProc`** (`.sk-stat-lck4`, `lck4`) have the same shape. All three render through one helper, `extraLckChip()`, which also takes `show:()=>bool` to hide the chip (Bison Combo's crit chip without gear).
* **`<=` rolls:** the game sometimes rolls `Random.Range(0,100) <= lckAdjust(n)` (Bison spin, Over Pride), which is one point more than the usual `<`. Show it with `calc:(c,L)=>c>0?Math.min(100,lckAdjustChance(c,L)+1):0`.
* **`lckProc.simulate:false`:** keep the chance chip but don't roll it in the outgoing-damage simulator (defensive/reactive procs, e.g. Wind & Cloud evasion).
* **`lckProc.chance: (rank, procDepRank) => n`:** dep-driven base chance, resolved before `lckAdjust` (Time and Tide 50% → 100% evasion).
* **`lckProc.depGates:false`:** keeps the `dep` toggle as an input to `chance(rank, procDepRank)` without turning the chip or simulator chance to 0 while it is off (Herb Finder's Big Bag modifier).
* **`lckOdds: (LCK) => [{label, pct, base}]`:** one `.sk-stat-odds` chip per outcome of a direct LCK roll, in its own `.sk-odds-row` (5 cols, 3 under 680px); `pct` to 1 decimal, 0% dimmed; makes LCK glow. Grand Casino Arcade's `CASINO_OUTCOMES` / `casinoOdds` / `casinoRoll` / `casinoRawRange` are the single source for chips, sim and range (a Doom spin returns 0; `range.zeroMin`). `[CASINO ERROR]`.
* **`atkCoeffProc:{dep, chance, coeff, label}`:** a per-cast chance to replace the ATK coefficient; formula shows `min~max` with `xATK / yATK` (talAdjust and flat-ATK cards alike), ranges include both, Test rolls `lckAdjust(chance)` once per cast. Sharing `dep` with `lckProc.dep` merges `DMG` + `CHANCE` tags.
  * **Per stage (`perGroup:true`, Bison Combo):** each `dmgGroups` entry carries its own `atkCoeffProc: ()=>coeff`, and the Test rolls once per game stage instead of once per click. Groups that are one stage in the game share a roll through the same `procStage` key (Spin first/second). Helpers: `resolveGroupAtkCoeffProc`, `resolveGroupAtkCoeffDisplayRange`.
* **`groupVariant:{base:(rank)=>%, inclusive, forceDep}`** (Bison Combo's 3rd attack): groups tagged `variant:"base"` / `variant:"alt"` are two outcomes of one per-cast roll (normal hit vs spin). `resolveGroupHitCount` zeroes the groups of the other outcome. `forceDep` on = always `alt`; otherwise each Test click rolls once (`groupVariantAlt` holds the roll while its hits resolve) and the Final range spans both outcomes. The card rows show the `base` outcome while nothing is forced. The top-level `hitCount` must follow the same state (`bisonComboHits`); the `[DMGGROUPS HITCOUNT ERROR]` check skips the other outcome's groups. `[BISON COMBO ERROR]` covers the Bison card.
* **`dmgRankDep.postTal:true`** (with numeric `mult`): multiplier applied to the already-truncated `talAdjust(...)` result before adding ATK (Time and Tide: `0.5×ATK + talAdjust(10×sLv)×(1+0.5×passiveLv)`). Not the same as the default inside-`talAdjust` multiplier.
* **Chip layout:** by default chips left-pack in DOM order (`.sk-stats-packed`: cd, cd2, cast, dur, dur2, lck, lck2, lck3). `chipCols: {cd, cd2, cast, dur, dur2, lck, lck2, lck3: N}` sets explicit columns (`chipColStyle(key)`), only for a non-DOM order, and turns packing off for the whole card, so list every chip. `stats5:true` widens the row to 5 columns (cd/cast/dur/dur2 in 1–4, `lck` in 5; 3+2 under 680px), only for a card that truly needs all five (Arctic Wind).

---

### Purple Effect Damage mixed into normal hits (`effectProc`)

Purple = the Effect Damage path: no dodge, no `damagePlus`/`dmgAdjust`/`defAdjust`, no direct-hit reduction, `hitMod` rounded **down** ([12Tails-Mechanics-Reference.md §2.9](../../12t_reference/12Tails-Mechanics-Reference.md)). KO not simulated.

* **`effectProc: {mode:"replace", chance:(rank)=>base%, dmg?}`:** hit turns purple instead of white when `floor(random×100) < lckAdjust(base)`. `dmg` overrides the purple formula. Pair with a `lckProc` (`simulate:false`). Whale Sweep / Javelin / Peninsula Impale via `WHALE_WALLPUNCTURE_DEP` (0–4) / `WHALE_WALLPUNCTURE_LCK`.
* **`effectProc: {mode:"bonus", amount:(rank,{LV})=>n, status?, preset?, controls?}`:** extra purple on top of each white hit (0 when off). `status`: only while the target has that status (checked before the hit's own proc). `preset`: 0/1 dep "target already has it". `controls`: header deps. Used by Arctic Wind (Deadly Frost), Frozen Blast (Frozen Break × `PENGUIN_TARGET_ICE_DEP`), Panda via `PANDA_SHADOWFIST_PROC`.
* **`effectProc.hits: [n,...]` or `(rank)=>[...]`:** 1-based hit numbers (across all `dmgGroups`) that get the bonus; absent = all. Finishing Blow `[3]` (`Cat.cs:38923`); Combo skips hit 2 with Hidden Blade on (`Cat.cs:17390-17507`).
* **`dmgGroups[i].effectDamage:true`:** the whole group is purple (Megalodon pull ticks); its range is tagged `.purple`.
* **Final range:** replace = `[min(white,purple), max(white,purple)]` when chance > 0; bonus = `[white min, white max + bonus]` (minus one bonus if a `status` bonus can't hit the first tick). Purple ends drawn with `.dmg-effect` (not for `dmgGroups` cards).
* **Sim totals:** gold total (`dmgdigit_y0–9`) with white/purple sub-totals (`.sk-mix-parts`, purple hidden at 0); each popup white or purple.
* **Implementation:** `rollOneHit(..., opts)` sets `lastRollPurple`; `revealMultiHit` adds bonuses and splits totals. `[RANGE/SIM]` + `[EFFECTPROC ERROR]`.
* **`effectProc.noCrit:true`** (replace only, Whale Combo): the purple roll skips `critProc` and the purple range uses the raw range before the crit (`range.noCritRange`).
* **Mole Smart Shell** (`MOLE_SMARTSHELL_PROC`, bonus 30): Mine, Stun Mine, Stun Grenade, Time Nuke; enemies with [insight] are skipped.
* **rawModel per group** (Panda Combo): `parts(rank, {ATK, LV, group})` and `formulaItems(rank, {..., group})` receive the `dmgGroups` entry; `parts` may return `noCrit` (a hit without `getCritPlus`) or `critTotal` (the whole crit outcome when the crit wraps only part of the formula, e.g. Panda `(int)(c × (floor(1.8 ATK) + Focused Spirit))`).
* **Bat Merciless Drain** (`BAT_MERCILESS_PROC`, bonus 66 on Drain Life, one toggle = learned + the target has no SP/MP left to drain).
* **`splashLine: {label, pct(), stageName?(key)}`** (Bison Colossal Weapon): damage a stage sends to the *other* targets it did not hit, shown as a purple line under Final Damage (`data-role="splash-line"`), `ceil(pct × the stage's after-DEF range)` per stage (groups sharing `procStage` are one stage). It never enters Final or Test.

### Header controls, crit and toggle-driven purple (`dmgControls` / `critProc` / `effectDamageDep`)

* **`dmgControls:[dep,...]`:** deps rendered in the damage header (0/1 → toggle, wider → rank icon) for cards whose formulas read several deps (Wolf Combo).
* **`DEP_EXCLUSIVE`** (global): turning one on switches off the listed ids (G. Marshal ↔ G. Champion sets).
* **`critProc:{chance:(rank)=>base, mult}`:** crit on the truncated raw before `hit()`/Effect Damage, `floor(random×100) < lckAdjust(base)` → `floor(mult×raw)`; range max = crit max when base > 0. Pair with `lckProc` (`simulate:false`). Wolf Combo: Marshal 12 / Champion 18, `mult 1.8`.
* **`effectDamageDep: dep`:** while on, the whole card is purple. Always check purple via `skillEffectDamageOn(skill)`, not `skill.effectDamage`.
* **`effectLckRoll:true`:** purple hit adds `Random(0, ceil(0.2×LCK))` after the crit; range adds `lckSpreadRange(LCK)[1]`.
* `[WOLF COMBO ERROR]` checks Wolf Combo across every dep/gear combination.

### LCK-Difference Damage (`lckDiffCoeff` / `lckDiffDep`)

Reads player LCK and the enemy panel's LCK.
* **`lckDiffCoeff:(rank)=>k`:** adds `Random(0, k×max(LCK−enemyLCK, 0))`; raises the raw max only. Formula term `.dmg-lck`, shown `0~max`, caption `(k×ΔLCK)`.
* **`lckDiffDep:{...dep, coeff}`:** adds unclamped `coeff×(LCK−enemyLCK)` after the first truncation, shifting both ends; shown `− n` when negative; shares state by `dep.id` with a `lckProc.dep`.
* **`lckDiffOwn:true`:** roll on own LCK only (enemy LCK treated as 0, caption `k×LCK`). **`lckDiffExclusive:true`:** max lowered by one (`Random.Range(int,int)` excludes the top).
* `[LCK FLOOR]` runs these with the dep off.

### Range-vs-Simulator Consistency (`[RANGE/SIM]`)

The Final range (`finalRangeForRange(calcRangeFor(text))`) and the simulator (`rollOneHit`) must agree; the validator rolls 2000× per rank (deps default and all off, zero and high stat profiles).
* Change `rollOneHit` and `calcRangeFor`/`afterDefForRange` together. The simulator is usually right, but not always: inside `rollOneHit`, `ATK`/`TAL`/`LCK` are reassigned for own-stats skills, so re-read `atkEl`/`talEl`/`lckEl` for the player's value.
* **`range.foldedSpread`:** the final-max base is the raw max minus exactly what was folded in (`0` for `talAdjust`, `rMax` for flat ATK).
* `KNOWN_RANGE_SIM_MISMATCH` suppresses known cases (currently none). Never widen a range to pass.

### Panda Current SP, Focused Art & target inputs

* **`usesFocusedArt:true`** only after the cast site calls `getFocusedArtDmg()` (`0.5×SP×lv`, `Panda.cs:10841`); never inferred. Controls sim, formula row, range and SP input. Verified: Three Steps, Rushing Falcon. Not Wind & Cloud.
* **`hasCurrentSp:true`:** shows the SP input without Focused Art (Ashura Fist reads global `pandaCurrentSp` in a function `dmg`).
* **Current SP input:** one pill `.sk-current-sp-wrap` in `.sk-dmg-head .sk-dmg-toggles`, `<input type="text" inputmode="numeric" pattern="[0-9]*" class="sk-current-sp-input" maxlength="3">`, clamped 0–100 live, default `pandaCurrentSp = 50`. Keystrokes update `.sk-dmg-value` / `.sk-dmg-calc` / `.sk-dmg-final` in place without re-creating the input.
* **Term order** in `renderOneDmgFormula`: TAL terms, then ATK, then Focused Art `+ 0.2×SP` in `.dmg-sp` outside the ATK bracket.
* **`dmgSub`** (string or `(rank)=>string`) also captions a `talAdjust(N)` base when N is not constant.
* **Two `talAdjust` terms** (`talAdjust(A) + talAdjust(B)`, Crushing Monolith): each rolls and truncates separately, never merged; second captioned by `tal2Sub`.
* **Target inputs:** `targetHpInput:true` (global `pandaTargetHp`, default 1000) feeds `lckProc.calc`; `lckProc.baseText(rank, LCK)`. `targetWeightInput:true` (`tWeight`, 0–59, while Tiger Pounce is on). `targetHeightInput:true` (`tHeight10 = round(h×10)`, while Crushing Monolith is on). Substituted in `substituteDmgVars()`.
* **`backpackInputs:true`:** shows live `น้ำหนัก` and `ไอเทม` inputs for Backpack; `bagWeight` is substituted in its base `dmg` formula while `bagItemCount` drives Big Bag's linked `dmgDep` addend. Both update formula, raw damage, final damage, and Test simulation without re-rendering; `dmgRankDep` provides the shared Big Bag toggle.
* **`jaDetonateInputs:true`:** shows live `Ja HP` and `ระยะ` inputs for Ja - Detonate; `jaHp` and `jaDistance` are substituted in its flat base formula. Distance is live-clamped to that rank's `4 + 2×sLv` blast radius; the KO badge recalculates independently from current Ja HP.
* **Nine Steps (`PANDA_NINESTEPS_DEP`):** off = one row (base group hitCount 3); on = base group hitCount 0 and three step groups `Step 1 (1x)` / `Step 2 (2x)` / `Step 3 (3x)` via `stepMult`, resolved in `resolveGroupValue`.

### Exact raw damage from code: `rawModel` (Rabbit Combo / Charge Attack)

For a card whose raw damage mixes several separately truncated terms that the arithmetic-only `dmg` text can't express (Rabbit Combo: `floor(0.75 × floor(0.5 ATK)) + floor(distance × Hyper Shot)`, Charge Attack: float32 Dead Shot multiplier), set `dmg:"0"` and:
* **`rawModel.critMult()` / `rawModel.critRound: "ceil"`** (Chameleon Combo): the crit value is `rawCritValue(skill, crit)`, by default `floor(1.8 × crit)`; Chameleon's arrow is `CeilToInt(num × 1.8f)` or `× (1.8f + 0.15f × Critical Plus)` with Bulls Eye, in float32. Its `formulaItems` draws the crit as `⌈…⌉`; `[CRIT VIEW ERROR]` pins the goldens.
* **`rawModel: { parts(rank, {ATK, LV}), critBase?(), usedStats?() }`.** `parts` returns `{crit, plain}`: `crit` is the part `getCritPlus` wraps (a crit gives `floor(1.8 × crit)`), `plain` is added afterwards, untouched (the shotgun's reversed Hyper Shot). `critBase()` is the gear crit chance base before `lckAdjust`; omit it for a skill with no crit (Charge Attack). `usedStats()` lists the player inputs that should glow (`["atk"]`, plus `"lv"` for a live Bouncing Bullet). The range chip (`calcRangeForBase`), the Test roll (`rollOneHit`) and the formula grid all read the same `parts`, so they cannot drift; never re-derive the value in a second place. Remove `atkCoeff` when adding a `rawModel` (validate with `--allow-field-loss=<id>:atkCoeff`). A `rawModel` counts as damage for `usesTdlRoll`, so the card gets the TTO toggle and its range and Test roll go through the TTO no-LCK cores (`[TTO NO-LCK ERROR]` sweeps it).
* **`formulaItems(rank, {ATK, LV})`** now receives the live ATK/LV (existing cards ignore the second argument).
* **`rabbitShotInputs: "combo" | "charge"`** renders the header **distance** box (`data-role="rabbit-distance"`, metres from Rabbit to the hit point, clamped to the mode's range: Combo `16 + 5 × rank` m, Bouncing Bullet `20 + 5 × rank`, shotgun 13, Charge Attack `20 + 5 × Combo lv`), and for `"charge"` the Dead Shot **aim-time slider** (`data-role="rabbit-aim"`, 0–4 s, dimmed with `is-idle` unless head shot and Dead Shot are both on). State lives in top-level `rabbitComboDistance`, `rabbitChargeDistance`, `rabbitAimTime` (distance is per card so switching cards never clobbers the other); listeners refresh the formula, raw and final chips live through `refreshLiveDamage()`.
* **`sheepChargeInputs:true`** (Sheep Charge Attack) renders the header **charge-time slider** (`data-role="sheep-charge"`, 0 s to `sheepChargeMaxTime(rank, ATK)` = the first held time that reaches the cap, step 0.1; top-level `sheepChargeTime`, `null` = full charge that follows the max; dragging to the right end sets `null`). Under 2 s the release makes no attack, so the raw damage is 0. The card is a `rawModel` (`sheepChargeParts` / `sheepChargeFormulaItems`): `n = floor(held − 0.8)`, `(int)Clamp((1 + 0.2 × Benediction) × n × ATK, ATK, 100 × Lv)` + 100 with White Burst, both deps in `dmgControls`. `[SHEEP CHARGE ERROR]` pins the goldens.
* **Deps (model block before `effectDamageDep`; Combo shows them by internal skill ID: Hyper Shot + Snipe Mastery, Customized Shotgun, Bouncing Bullet, Extravagance, then gear and Gatling Gun):** `RABBIT_BOUNCING_DEP`, `RABBIT_HYPERSHOT_DEP` (one 0..5 icon: ranks 1-4 = Hyper Shot level, rank 5 = Hyper Shot 4 + Snipe Mastery, art key `rabbit_hyperShot5`; Charge Attack shares it and ignores rank 5), `RABBIT_SHOTGUN_DEP` (on/off, default off: Customized Shotgun rank 1 and 2 differ only in hit-box width, so Combo does not need the level), `RABBIT_W59_DEP` (the "Gatling Gun"), `RABBIT_WEAPON_DEP` (0..2: off / Marshal crossbow +5 / Champion golden shotgun +7 crit; icon keys `item_rabWeapon1` / `item_rabWeapon2`) and `RABBIT_EQUIP_DEP` (0..2: off / Marshal armor + hat +7 / Champion +11; `item_rabEquip1` / `item_rabEquip2`), so a full set is 12 / 18 and the equipment can be tested with the Gatling Gun, `RABBIT_COMBO_LV_DEP`, `RABBIT_HEADSHOT_DEP`, `RABBIT_DEADSHOT_DEP`, `RABBIT_EXTRAVAGANCE_DEP`. Gear, w_rab59, Customized Shotgun and Extravagance default off. `DEP_EXCLUSIVE` makes the crit weapon, w_rab59 (Gatling Gun) and the shotgun mode mutually exclusive (all three weapons are outside `isShotgun()` or are the shotgun itself); crit equipment (armor + hat) is not exclusive with anything; **rank-cycle buttons now honour `DEP_EXCLUSIVE` too** (Crit Weapon and Crit Equipment are 0..2 rank deps). The crit chip is `secondaryLckProc` with `show:()=>rabbitCritBase()>0`.
* **Rifle vs shotgun crit order differs in the game:** rifle Combo, ricochet and From the Above wrap `hitDmg + hyper` in `getCritPlus`; the shotgun wraps only `(int)(0.5 ATK)` and adds Hyper Shot after (so `plain`).
* **Validator `[RABBIT SHOT ERROR]`:** hand-computed golden values for both cards (worked out from the source expressions, not from the code under test), gear crit bases and rate, exclusivity symmetry, header markup, stat glow, and a range-vs-simulator sweep over toggle combinations, distances and aim times at two stat profiles.
* **Extravagance is a skill dependency, not a Buff popup entry:** a card with `extravagance:true` shows `RABBIT_EXTRAVAGANCE_DEP`; there is no amount input because every Rabbit build uses it at its cap. `statBonus("atk")` adds `RABBIT_EXTRAVAGANCE_ATK` (512) to the ATK input for the selected flagged card only (so it also shows as the usual `+N = total` chip and feeds every range, Test roll and `rawModel`). Flagged: Combo, Charge Attack, Maim Shot, Bounce, Gil Shot, Four Shot, Circle Shot, Shooting Array, Ten Shot; skills that never read ATK (Gorgon Shot, Acidic Field, Diamond Shot, Millionaire, Backpack) are not flagged. Flagged cards do not repeat it in their `desc` (the dependency strip already names it); they link to the Extravagance card in `compatSkills`.

### CHA / AGI Optimizer tool (`cha-agi-optimizer`)

Tile "อยากสกิลวน ใช้แต้มน้อยสุดเท่าไหร่" (`mountChaAgiOptimizer`): per skill, the cheapest CHA + AGI for no downtime (cooldown ≤ duration). Each card = target CHA (with base duration) and target AGI (with base cooldown); no extra text lines (user decision).
* **Skills:** `CAO_SKILL_IDS` (Dark Edge, Lunar Eclipse, Rapid Trance, Immunity), values read from their `SKILLS` cards. Add only skills with a plain `agiAdjust(cd)` cooldown and plain `chaAdjust(dur)` duration. Perseverance applies to cards whose `dep` is `WOLF_PERSEVERANCE_DEP`. Controls: Revised Art toggle, shared Perseverance 0/1/2, per-card rank.
* **Custom card:** user types base duration (integer) and base cooldown (decimal); own Perseverance (`state.custom.persev`); recomputes per keystroke, updating only the result numbers.
* **Per-card override:** CHA/AGI numbers are editable (`.cao-big`); typing one solves the other (`caoMinAgi`, `caoMinCha` 0–512, "–" if impossible). `state.overrides[cardId|"custom"] = {stat, value}` via `caoPair()`; "↺ ค่าต่ำสุด" clears it.
* **Math:** `caoDuration = floor(dur×(1+0.015×clamp(CHA,1,512)))`, then Perseverance `floor((1.1+0.2n)×d)`; `caoCooldown = cd×128/(AGI+128)`, Revised Art `ceil(0.88×c)`; LCK 0. `caoOptimal` brute-forces CHA 0–512.
* **Budget advice (not shown in UI):** uptime ∝ `(CHA+66.67)×(AGI+128)`, so keep CHA ~61 ahead of AGI until CHA hits target. "AGI first" was tested and is wrong.
* **Undo:** Ctrl+Z restores toggle/rank state (50 deep) only while visible (`root.hidden` guard). Text inputs: snapshot on focus, commit on blur/change; Ctrl+Z inside a field is the field's own.
* `[CAO ERROR]`.

## 5. Summon Mechanics, Companion Movesets & Summon Stat Cards

1. **Main summon card** (`mole_barrelBot`, `mole_kingKaiser`, `mole_autoGyroGun`): full 9-stat grid (`mhp atk def agi vit mag cha tal lck`), accented when upgrade toggles (`heavyBuilt`, `synchroMole`, `doubleBot`, `hiddenTurret`) affect them; no `.sk-dmg-row` if the summon cast deals no damage.
2. **Child move cards** (King Kaiser normal attack, Mega Punch, Gyro shot): summon stat row where only stats the move uses glow (others `.sk-summon-stat-unused`); use the summon's own stats (`ownStats`, `ownStatsKaiser`, `ownStatsGyro`, `ownStatsDmgOnly`).
3. **LCK:** summon LCK is the attacker LCK for hits (`dmgAdjust`); duration/channel variance always uses the **player's** CHA and LCK.
4. Duration used only for hit-count math: `hideDurationChip:true`.
5. Automated summon AI moves omit `cost` entirely.
6. Stat accent tokens: `--stat-atk/def/agi/vit/int/cha/tal/lck/lv/hp`.
7. **Rabbit Contract mercenaries** (`ownStatsMerc: "panther" | "leopard" | "golem"`, `contractOwnStats` / `mercOwnStats`): one stats card per unit (`mercParent: true`, full 9-stat grid, all accented, Contract level cast time and 300 s life, no cost or cooldown) plus move cards that attack with the mercenary's own ATK / TAL / LCK. The grid has a **New Order** toggle (`RABBIT_NEWORDER_DEP`, ×1.5 floored on every stat except SP). Move cards map to Contract's internal ID 434. The validator's own-stat render check (Gaos) also covers them.
8. **Mount items** (`mount: true`, e.g. Mole's Tank `mole_moleTank` and Giga Cannon `mole_gigaCannon` with their attack cards): no skill number, so the validator's SKILL_INTERNAL_ID check skips them. A mount copies the rider's base stats (`getNoDeltaStat`) plus its own bonuses, so its attack cards use the player's stat inputs directly (no own-stats flag); bonuses are stated in the mount card desc. Icons are the real item icons from `gamegui/icons/items/mount/`.

---

## 6. Compatible Skills Navigation (`compatSkills`) Conventions

1. Every edge is reciprocated (A lists B ⇒ B lists A). Sibling mesh links allowed.
2. Header exactly `<p class="sk-compat-title">สกิลที่เกี่ยวข้อง</p>` (Prompt, gold 14px). No `LINK`/`MASS CAST`/`MOVES` badges.
3. `.sk-compat-item` 44px flex row; `img.sk-compat-icon` 42×42; `.sk-compat-name` `-webkit-line-clamp:2`.
4. Grids: many → `.sk-compat-grid` (`auto-fill, minmax(170px,1fr)`); 2–4 → `.sk-compat-few-grid` (`auto-fit`, one row); 1 → `.sk-compat-single-grid` (max 340px, `"คลิกเพื่อดูสกิล →"`).

---

## 7. Player Stat Input Highlighting (Stat Signature Accents)

1. `getUsedPlayerStatKeys(skill)` reads `cdWrapped`, `castWrapped`, `durWrapped`, `dmg`, `atkCoeff`, `defCoeff`, `lckProc`, deps.
2. `.sk-stat-glow-<key>` uses `--sg-color` for border/label/number and a static glow.
3. CHAR LV glows only when its controlling dep is on (`getDepRank(dep) === dep.maxRank`).
4. LCK glows only on a direct read (`lckProc`, literal `lckCoeff`, `lckAdjust()` in formula text), not for rolls inside `*Adjust`.
5. Summon sub-moves exclude player ATK/TAL/AGI per ownership flags (`ownStats`, `ownStatsDmgOnly`, `ownStatsKaiser`, `ownStatsPhoenix`, `phoenixFireballCd`).
6. **Summon stat feed** (`getSummonFeedPlayerStatKeys`): a player stat glows when its feeding dep is on **and** the fed summon stat is in `getUsedOwnStatKeys(skill)`. Feeds: Double Bot / Hidden Turret: CHAR LV → all; Synchro Mole: TAL → ATK/DEF; Phoenix Fire Soul: each stat → same (INT → MAG); Gadina Earth Soul: same 8-stat feed; Aegis of Earth: VIT → VIT. VIT also feeds MHP (`10×vit`). King Kaiser, Gaos, Ja and the Rabbit Contract mercenaries feed nothing. `[SUMMON FEED ERROR]`.

---

## 8. Interactive Skill Cross-Linking via Description (`desc`)

1. A skill name in `**…**` (`**Frozen Blast**`, `**Fireball4**`, `**ท่าโจมตีปกติ**`) becomes a `.sk-desc-skill-link` button via `findSkillByMention` (pre-indexed map); click → `selectSkill()`.
2. Resolution order: the card's `compatSkills`, then same class, then Common, then all classes.
3. Numbers, percentages, timers and general phrases (`**+2m**`, `**50%**`, `**15 วินาที**`, `**Shame:**`) stay plain `.sk-val` gold.
4. Style: gold text with a soft glow, stronger on hover, pointer, no underline.

---

## 9. Deep Links to Skill Cards

* Site: `https://jumpptty.github.io/12tails/12t_projects/bible/` (repo-root `index.html` forwards the hash).
* Format `#skill-details/<skillId>[?server=tot|tto]`; a server the skill has no override for is dropped. Legacy `#skill-cooldown-lookup` also accepts an id.
* `route()` → `container._selectSkillById(id, server)`; unknown id → empty search view; deep link skips search auto-focus.
* `selectSkill()`, server buttons and selection clearing call `syncSkillHash()` (`history.replaceState`: no history entries, no GoatCounter hits).
* GoatCounter stays tool-level (`getGoatPath()` strips after the tool id).
* Not possible on static hosting: path-style URLs, per-skill link previews.
* Validator §3b drives the real `route()`.

---

## 11. Buff / Debuff Popup: Server Toggle & Quick Switches

1. **Popup server (`bdServer`: og/tot/tto):** own selector, independent of `currentServer`, session-only; decides which entries exist and their values.
2. **Per-entry server data:** `STAT_BUFFS` / `MOD_DEFS` entries may carry `servers:{tto:{...}, tot:{hidden:true}}` and/or `onlyServers:[...]`. `bdResolve(entry, server?)` returns the effective entry or `null`; the lists, `statBonus()`, `playerDamageModCalc()`, `enemyHitModCalc()`, `finalMultCountCalc()` all use it. Selections are kept by id across servers. Only verified values.
3. **Quick switches (`buffsSuspended` / `debuffsSuspended`):** suspend a whole side without clearing it; dims the button, popup shows `Off`; session-only.
4. **Character Hit Mod tool (`chm*`)** is separate: reads `MOD_DEFS` directly, has its own server toggle (`simState.server`, `#chmServerToggle`; `chmModOnServer()`; TTO opens `showChmServerPopup()` with `CHM_TTO_NOTE`). On TTO its inline `maxRAtk`/`maxRDef` rolls are 0 and the Poseidon HP Drain chance skips `chmLckAdjust`. **Its damage math does not use `tdlRoll`; mirror TTO changes by hand.**
5. **Final multipliers:** `STAT_BUFFS` `mult:{int:1.24}` = final multiplier after additive buffs (`floor((base+additive)×mult)`, epsilon-guarded), shown as `+N`. Uses: `recurrentNova5` (ToT only), TTO `honor4` (+50 CHA). **Final Multiplier section is ToT-only** (`finalMult1-3` `onlyServers:["tot"]`; custom `finalMult` via `finalMultOnServer()`; entries kept). Badges count only entries `bdResolve` keeps. `[FINAL MULT ERROR]`.
6. **Custom buffs/debuffs:** `+ Add` per section; `{id, kind, name, stat?, value}` in `localStorage["12t-bible-custom-bd"]` (ON/OFF is session state, new = ON). Kinds: `stat` (int ≥ 0, one stat or `all`, additive before `mult`), `dmgMod` ([-10,10]), `finalMult` (0–1000%, ToT only, one `ceil` step after the built-in 5% stacks), `hitMod` ([-10,10]), `enemyStat` (int, |N| ≤ 9999). Rules in `validateCustomBd()` (name required, ≤24 chars; storage re-validated on load). Names HTML-escaped.
7. **Enemy stat changes:** `enemyVal(el)` (typed value + net change, not floored; formulas clamp) replaces every direct enemy CHA/LCK/DEF read. Panel shows `+N = total` / red `-N = total` (`.sk-stat-bonus.neg`). `finalMultiplierAdjust(dmg, x)` takes a step count (CHM) or an array of percent steps.
8. **`ENEMY_STAT_DEBUFFS`** (same shape as `STAT_BUFFS`, `enemyStatBonus()`, toggles `bd-estat`): first entry `shame6` (Bat Shame Lv.6, -60 CHA).
