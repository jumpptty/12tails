# Bible Deliverable Guidelines (`12t_projects/bible/`)

Mandatory rules, UI conventions, card schemas, verification pipeline and file-safety rules for `12t_projects/bible/index.html`. History and rejected designs live in git, not here. Where a rule names a validator error (`[XYZ ERROR]`), `node scripts/validate_skills.js` enforces it.

---

## 1. Large File Handling & Crash Prevention Protocol (~15 MB)

`index.html` embeds every game icon as base64 (`SKILL_ICONS`, currently ~lines 7,500–10,300; `CLASS_ART` / `CLASS_PORTRAITS` near ~22,100). Line numbers drift; locate blocks with `grep -o`.

1. **Zero base64 ingestion:** never read, grep or dump the base64 blocks. Inspect icon keys with a small Node scratch script that prints key names only.
2. **Out-of-process patching:** every change to `index.html` is a small Node script in the scratch dir that loads the file, replaces the target in memory, writes it back and prints one confirmation line. No IDE edit tools on this file.
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
* **Status keywords (`STATUS_CLASS_MAP`, `STATUS_DESC_MAP`, declared just before `const SKILLS`):**
  * `STATUS_CLASS_MAP` is the single source for a status's classification string (e.g. `"Debuff, Magical, Lock"`). Add an entry only after checking `StatusData.cs`'s `is*Status` functions **and** the generic per-status switch in `CharacterControl.cs` (§3.0 item 4). An unmapped name renders as plain bracket text (= still needs research).
  * `STATUS_DESC_MAP` gives the optional 2nd popup line: a string, or `(sLv) => string` for level-scaled effects (`getStatusDesc(name, sLv)` passes `null` for `[name]` with no digits → formula in words; a number → computed value). Verify values at the **apply site**, not the `removeStatus()` mirror.
  * **No repetition:** a fact goes in either the status popup or the card `desc`, never both. What the status does → `STATUS_DESC_MAP`; the card names it (`[ashura${rank}]`) and says only what the skill adds.
  * Status mentions inside `STATUS_DESC_MAP` link to other statuses; cycles stop at the repeated name. Popup is a real nested `<span class="sk-status-tip">` built by `renderStatusTip(cls, desc)` (shared by `[name]` and the `status:{}` badge). CSS gotchas: `white-space:pre-line` on the absolute popup needs `width:max-content`; the divider span needs `display:block`.
  * **Auto-badge vs inline:** a card's `status:{name, sLv, class}` auto-prepends a badge (`sLv` may be a per-rank function). Any `[name]` of that status in the `desc` (name-only, case-insensitive) suppresses the auto-badge entirely; a card showing two levels places both inline. Use bare `[name]`, never hand-written `<span class="sk-status">` (the renderer skips pre-wrapped spans as a fallback).
* **Omit from `desc`:** wrapped durations (`chaAdjust`) and wrapped proc chances (`lckAdjust`); chips show them. Also the standard on-hit **+1 SP** (unusual SP gains may be mentioned).
* **Dependency-line `desc` format** (skills changed by `compatSkills` modifiers): one base sentence (with verified hit-box `ระยะ / กว้าง / สูง`, full width = `2×BaseWidth`, see [12Tails-Mechanics-Reference.md §4](../../12t_reference/12Tails-Mechanics-Reference.md#4-hidden-mechanics--special-interactions)), then one `<br>` line per modifier `**<Skill>**: <what it changes>`, not repeating values a chip/toggle shows. Example:
  ```
  ชาร์จ **${rank+1} วินาที** แล้วปล่อยหมัดตรงไปข้างหน้า ระยะ **1m** กว้าง **2m** สูง **2m** ทำดาเมจรุนแรงตามค่า ATK<br>**Delay Qi**: ค้างหมัดไว้แทนการปล่อยทันที แล้วปล่อยเมื่อกดโจมตีครั้งถัดไป<br>**Qi Burst**: หมัดยาวเป็นเส้นตรงระยะ **6m** (ปกติสั้นเพียง **1m**)<br>**Focused Art**: บวกดาเมจเพิ่มตามค่า SP ปัจจุบัน ณ ขณะโดนเป้าหมาย
  ```
  The modifier passive's card mirrors it: `ทำให้ **<Active Skill>** <what it changes>` (two actives: `ทำให้ **Pummel** และ **Tower Rush** ...`). Both link each other in `compatSkills` (§6).
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
* **Test button (`simulateBtnHtml()`):** the only filled gold pill (`--gold` bg, `--ink` text), full width under Final. Labels `ทดสอบดาเมจ` / `ทดสอบฮีล` / `ทดสอบ Hate`; starburst icon (✚ for heals); hit count `×10 ฮิต` / `×3–5 ฮิต` / none for single-hit. Per-mode buttons `small:true`. `.is-new` pulses until any Test is clicked (`markSimSeen()`, `localStorage["12t-bible-sim-seen"]` in try/catch; off under reduced motion). `[TEST BUTTON ERROR]`.
* **Dependency strip (`depSink` / `renderDepStrip`, spec `docs/superpowers/specs/2026-09-26-dep-strip-design.md`):** every dep button lives in one `.sk-dep-strip` under the description.
  * Range exactly `0..1` → toggle; anything else → rank selector. `renderDmgToggle` on `0..N` jumps off ↔ max unless the dep sets `cycleRanks:true`.
  * Item = 40px icon (grayscale when off) + `label` + effect tags `CD CAST DUR CHANCE DMG HITS KO SHIELD STATS INFO`, coloured by stat. A dep used at several sites shows once with merged tags.
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
* **Still to wire at each card's `/sd` pass:** Whale Combo 1–3 (replace), Mole Smart Shell (bonus 30: Time Nuke, Stun Grenade, Mine, Stun Mine), Panda Combo 1–5 (Shadow Fist). Need their own design: Bison Colossal Weapon (splash onto other targets), Bat Merciless Drain (uncertain condition).

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
* **Nine Steps (`PANDA_NINESTEPS_DEP`):** off = one row (base group hitCount 3); on = base group hitCount 0 and three step groups `Step 1 (1x)` / `Step 2 (2x)` / `Step 3 (3x)` via `stepMult`, resolved in `resolveGroupValue`.

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
6. **Summon stat feed** (`getSummonFeedPlayerStatKeys`): a player stat glows when its feeding dep is on **and** the fed summon stat is in `getUsedOwnStatKeys(skill)`. Feeds: Double Bot / Hidden Turret: CHAR LV → all; Synchro Mole: TAL → ATK/DEF; Phoenix Fire Soul: each stat → same (INT → MAG); Gadina Earth Soul: same 8-stat feed; Aegis of Earth: VIT → VIT. VIT also feeds MHP (`10×vit`). King Kaiser, Gaos, Ja feed nothing. `[SUMMON FEED ERROR]`.

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
