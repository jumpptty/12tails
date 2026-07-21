# Penguin Interactive Skill Infographic Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Build a browser-first, interactive HTML skill sheet for the Penguin class: aqua-themed, with per-card rank toggles (merging rank-family skills like `manaMissile1-4` into one card) and a dual view mode (symbolic base view / live character-stat plug-in view) driven by a small formula-evaluation engine.

**Architecture:** One self-contained HTML file (`penguin-sheet.html`) following the existing `12tails-class-infographic` template's card/chip visual conventions, but with card markup generated at load time from a centralized JS `SKILLS` data object (one entry per merged card, each holding one or more rank rows with formula strings) rather than hand-authored per-card HTML. A hand-rolled (no `eval`) expression evaluator renders each formula in either symbolic mode (today's `0.5×ATK + 60 + 1.2×TAL` text) or numeric mode (a computed number, using values from a global stat-input panel). Icons are pre-embedded as base64 data URIs in a JS lookup table (not `<img src="file://...">`, since the final target is a self-contained Artifact) and swapped via `img.src` when a card's rank selection changes.

**Tech Stack:** Plain HTML/CSS/JS, no build step, no framework, no external requests (self-contained for Artifact publishing). Python 3 (`py` launcher) only for one-time data-extraction/icon-embedding helper scripts, not part of the shipped page.

## Design Corrections (added after Task 6, apply to all remaining/prior data)

These three corrections were raised by the user after Tasks 5-6 were already
merged. They are retroactive: Task 4's renderer and Tasks 5-6's already-written
data must be fixed (tracked as a dedicated fix task before Task 7 begins), and
Tasks 7-8's briefs below have been updated to follow these conventions from
the start.

1. **Passive skills must not render a CAST/INSTANT chip.** A card is
   "passive" (no chip row at all — just icon, title, notes) when its rank has
   NONE of `cd`/`mp`/`sp`/`cast`/`dmg` set. `renderSkillCard`'s current logic
   unconditionally renders either a `CAST` chip or a synthesized `INSTANT`
   chip whenever `r.cast` is falsy — this incorrectly fires for pure passives
   too. Fix: only render the CAST/INSTANT/Range chip row at all if the rank
   has at least one of `cd`/`mp`/`sp`/`cast`/`dmg` set (i.e. is actually an
   active skill in some form); a pure passive gets zero chip rows.
2. **Cumulative-display families show the running total through the selected
   rank, not that rank's own incremental contribution.** Applies to
   `intellect`, `statPlus`, `astralTalent`, and any other flat-stat-bonus
   passive family: selecting rank 3 of `intellect` must show the sum through
   rank 3 (`+30 INT, +90 MP, +90 max MP`), not rank 3's own isolated `+10
   INT, +30 MP, +30 max MP`. This is because a player who has trained up to
   rank 3 has all 3 ranks' effects simultaneously — the rank toggle
   represents "highest rank owned," not "which single rank's tooltip am I
   reading." The rank-4 "all ranks combined" summary lines already written in
   Tasks 5-6 become redundant under this convention (every rank now shows
   its own cumulative total) and should be removed once the per-rank note
   text itself states the running total directly.
3. **Cooldown, cast-time, damage, and buff/debuff-duration formulas collapse
   the rank-dependent (`sLv`) arithmetic into a single pre-computed number
   once a rank is selected**, since the rank toggle already fixes `sLv` — no
   need to show `talAdjust(3×sLv+12)`-style arithmetic when rank 3 is
   selected; show `talAdjust(21)` directly (`3×3+12` pre-computed to `21` at
   authoring time, per rank, in the data itself — not computed by extending
   the evaluator to support an `sLv` token). Every existing formula string of
   the form `"...×N..."` (where N is the literal rank multiplier already
   baked in per-rank, e.g. `"agiAdjust(8+2×3)"` at rank 3) should become
   `"agiAdjust(14)"` (the arithmetic pre-solved). This applies uniformly to
   `cd`, `cast`, `dmg` formula fields, and any duration figure mentioned in
   `notes` prose (e.g. `chaAdjust(2+4×sLv)`-style mentions in note text
   should also collapse to `chaAdjust(14)`-style at the selected rank's
   value). Range/AoE-radius numbers already collapse this way in the existing
   data (e.g. `"9m radius"` not `"3×sLv radius"`) — this correction brings
   cd/cast/dmg/duration in line with that same already-established
   convention, it does not introduce a new pattern.
4. **Rank-invariant facts must appear on every rank's `notes`, not only on
   whichever rank they were first written on.** Two recurring instances of
   this bug: (a) a base mechanical description (e.g. "applies ice status on
   hit") written only in rank 1's notes, silently absent from ranks 2-4 even
   though the mechanic still applies at every rank; (b) a Class C synergy
   call-out (e.g. `needs "moreMissile5"`) written only on the highest rank's
   notes, even though that synergy applies at whatever rank the base skill
   is currently trained to, not only at max rank. Fix: any note bullet that
   is true regardless of which rank is selected must be repeated verbatim
   across every rank's `notes` array — each rank's notes list must be a
   self-contained, complete description of that rank, not require the reader
   to check a different rank's card to learn a still-applicable fact. Only
   genuinely rank-VARYING bullets (a stat number that changes per rank) are
   allowed to differ between ranks.
6. **Default view mounts every multi-rank family at its highest rank, not
   its lowest.** `mountAllCards()` currently sets `currentRank[famId] = 0`
   uniformly; change this to `fam.ranks.length - 1` uniformly instead. A
   completed-character reference sheet is more useful showing the fully-
   trained state by default — a reader can still toggle down to an earlier
   rank if they want it, but shouldn't have to click through to rank 4 on
   every single card just to see the sheet's "normal" reference state.
   Single-rank families are unaffected (index 0 is already both the lowest
   and highest rank for them).
7. **`renderSymbolic` must pre-multiply two adjacent numeric constants
   instead of displaying the arithmetic.** Concretely: `talAdjust`'s
   pre-expansion currently renders `n + 0.02×n×TAL` (e.g. for `n=15`:
   `"15 + 0.02×15×TAL"`) — since `0.02` and `n` are both fixed numbers (not
   stat tokens) once a rank is selected, they should be pre-multiplied into
   one coefficient: `n + (0.02n)×TAL` (e.g. `"15 + 0.3×TAL"`). This is a
   general rule for the symbolic renderer, not a `talAdjust`-only special
   case: wherever `renderSymbolic` would otherwise multiply two numeric
   literals together with no stat token involved, compute the product and
   show one number instead of the arithmetic. (As of this writing,
   `talAdjust`'s coefficient term is the only place this pattern occurs —
   `agiAdjust`/`magAdjust`/`chaAdjust`/`lckAdjust`'s formulas don't have an
   adjacent numeric-literal multiplication in their symbolic form — but the
   rule should be implemented generally so it also applies automatically to
   any future formula, including Class B/C data not yet added, that has the
   same shape.) This is purely a *symbolic display* change — `renderNumeric`
   already computes the mathematically identical value either way and needs
   no change.

## Global Constraints

- No `eval()` or `Function()` constructor anywhere in the formula evaluator (security default — untrusted-input-shaped code path even though inputs are actually static).
- The shipped HTML file must be fully self-contained: no external stylesheet/script/font/image requests (required for Artifact publishing — a strict CSP blocks all of them).
- Every card's displayed value must trace back to a formula/constant recorded in `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md` — no invented numbers.
- Follow the existing template's visual conventions exactly except where this plan's tasks explicitly change them (chip color coding, 3-row chip layout, bullet-only notes, bold+quoted skill cross-references, INT not MAG, etc. — see `C:\Users\Jump\.claude\skills\12tails-class-infographic\SKILL.md`'s "Visual design conventions" and "Common Mistakes" sections).
- Base view is the default state on page load (per design spec).
- `pgn_superStatPlus5` (441) and `pgn_frostBite1-4` (351-354) have **no discoverable client-side mechanic** — render them as passive cards stating this explicitly, do not fabricate formulas.
- Rank-family merge: a merged card sits at the tier of its **lowest** rank's `commandNum` (confirmed no family crosses a tier boundary — see design spec).

---

## File Structure

- **Create:** `Mechanics-Infographics/12_Penguin_skill-sheet.html` — the shipped single-file sheet (styles + engine + data + generated markup). Placed alongside the existing `Mechanics-Infographics/11_Penguin_stat-gain-table.svg` per this repo's existing numbering convention for Penguin mechanics docs.
- **Create (scratch, not shipped):** `<scratchpad>/penguin_icons_b64.json` — one-time base64 dump of every needed Penguin icon, generated by a small Python helper, consumed by hand when building the JS `ICONS` table (or pasted wholesale — see Task 2).
- **Reference only (no edits):** `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md` (all formula/mechanic data), `docs/superpowers/specs/2026-07-21-penguin-interactive-infographic-design.md` (design decisions), `C:\Users\Jump\.claude\skills\12tails-class-infographic\example-template.html` (visual conventions to port).

Everything lives in one HTML file by necessity (self-contained Artifact requirement — no separate .js/.css files can be fetched at runtime). Internally the `<script>` block is organized top-to-bottom as: `ICONS` data → `SKILLS` data → evaluator → render functions → event wiring, so it reads like separate modules stacked in one file.

---

## Task 1: Extract and stage all Penguin icon base64 data

**Files:**
- Create: `<scratchpad>/dump_penguin_icons.py`
- Create: `<scratchpad>/penguin_icons_b64.json`

**Interfaces:**
- Produces: a JSON file mapping icon base name (e.g. `"manaMissile1"`, `"astralTalent0"`) → base64 PNG data-URI string, for every Penguin icon needed by Task 2's `ICONS` table.

- [ ] **Step 1: Write the icon-dumping script**

```python
# <scratchpad>/dump_penguin_icons.py
import base64, json, os

ICON_DIR = r"C:\Users\Jump\Desktop\Assembly-UnityScript\RippedAssets\ExportedProject\Assets\Resources\gamegui\icons\skills\penguin"
OUT_PATH = r"C:\Users\Jump\AppData\Local\Temp\claude\c--Users-Jump-Desktop-Assembly-UnityScript\290fdda7-f77e-454a-81f6-2b3239f85942\scratchpad\penguin_icons_b64.json"

# Only the exact icon files the sheet will reference (base cType + rank suffix).
# Populated from the skill-tree/rank-family mapping in the data reference doc.
NEEDED = [
    "nAttack1","nAttack2","cAttack1","cAttack2","cAttack3","cAttack4",
    "intellect1","intellect2","intellect3","intellect4",
    "doubleCast1","tripleCast2","statPlus1","statPlus2","statPlus3","statPlus4",
    "manaMissile1","manaMissile2","manaMissile3","manaMissile4",
    "manaArc1","manaArc2","manaArc3","manaArc4",
    "dispell1","dispell2","blink1","blink2",
    "mpTransfer1","mpTransfer2","manaBurn1","manaBurn2",
    "fallingStars1","fallingStars2","fallingComets1","fallingComets2",
    "manaVortex1","manaVortex2","manaVortex3","novaFlare1",
    "astralTalent1","astralTalent2","astralTalent3","astralTalent4",
    "meteora1","meteora2",
    "frozenBlast1","frozenBlast2","frozenBlast3","frozenBlast4",
    "arcticWind1","arcticWind2","arcticWind3","arcticFrost1",
    "iceShield1","iceShield2","iceShield3","iceShield4",
    "iceBlock1","iceBlock2","snowMan1","snowMan2",
    "tornado1","tornado2","tornado3","typhoon1",
    "frostBite1","frostBite2","frostBite3","frostBite4",
    "absoluteZero1","absoluteZero2","blizzard1","blizzard2",
    "arcticEmperor1","arcticEmperor2",
    "spreadShot5","moreMissile5","frozenBreak5","revisedSkill5",
    "manaField5","penguinOfArc5","deadlyFrost5","revisedMagic5",
    "focusIntellect5","parallelShift5","frostSpike5","revisedArt5",
    "doubleSpell5","manaSurge5","snowBall5","cosmicRift5",
    "superStatPlus5","giantStar5","iceTwister5","cosmicFriday5",
]

out = {}
missing = []
for name in NEEDED:
    path = os.path.join(ICON_DIR, name + ".png")
    if not os.path.exists(path):
        missing.append(name)
        continue
    with open(path, "rb") as f:
        out[name] = "data:image/png;base64," + base64.b64encode(f.read()).decode()

if missing:
    raise SystemExit("Missing icon files:\n  " + "\n  ".join(missing))

with open(OUT_PATH, "w", encoding="utf-8") as f:
    json.dump(out, f)

print(f"OK: {len(out)} icons dumped, {os.path.getsize(OUT_PATH)//1024} KB -> {OUT_PATH}")
```

- [ ] **Step 2: Run it**

Run: `py "<scratchpad>/dump_penguin_icons.py"`
Expected: `OK: 80 icons dumped, NNNN KB -> ...penguin_icons_b64.json` (80 = count of `NEEDED` list above; adjust the printed count check if the list above was edited during writing — the important thing is zero `Missing icon files` errors).

- [ ] **Step 3: Sanity-check the output**

Run: `py -c "import json; d=json.load(open(r'<scratchpad>/penguin_icons_b64.json')); print(len(d)); print(d['manaMissile1'][:40])"`
Expected: prints `80` then `data:image/png;base64,iVBORw0KGgo...` (PNG magic bytes after the base64 header).

No commit for this step — it's scratch data feeding Task 2, not part of the shipped file.

---

## Task 2: Build the page skeleton, aqua theme, and icon/skill data tables

**Files:**
- Create: `Mechanics-Infographics/12_Penguin_skill-sheet.html`

**Interfaces:**
- Produces: `<title>`, `<style>` block (ported + aqua-themed), and two `<script>`-embedded JS objects: `const ICONS = {...}` (from Task 1's JSON, pasted in verbatim) and `const SKILLS = {}` (empty shell — populated by Tasks 5-8). Also produces the accent-variable convention documented for future class reuse.
- Consumes: nothing (first file-creating task).

- [ ] **Step 1: Create the file with document shell + aqua-themed style block**

Start from `C:\Users\Jump\.claude\skills\12tails-class-infographic\example-template.html`'s `<style>` block (lines 1-210) verbatim, then apply these changes:

1. Retitle: `<title>12 Tails — Penguin Skill Sheet</title>`
2. Replace the `:root` accent block (lines 3-16 of the source template) with an aqua palette, formalized as a clearly-commented swappable block:

```css
:root{
  --backdrop:#DCE7EA;
  --paper:#FBFDFE;
  --ink:#1D2A2E;
  --ink-soft:#526169;
  --line:#CBDEE3;
  --chip-bg:#EAF4F6;
  /* ==== PER-CLASS ACCENT — swap these 2 lines for a new class, nothing
     else in this stylesheet should need to change. Penguin = aqua. ==== */
  --acc:#1387A8;    --acc-tint:#E4F4F7;
}
@media (prefers-color-scheme: dark){
  :root{ --backdrop:#162326; }
}
:root[data-theme="dark"]{ --backdrop:#162326; }
:root[data-theme="light"]{ --backdrop:#DCE7EA; }
```

3. Keep every other CSS rule byte-for-byte identical to the source template (chip colors, `.sk`/`.pv` card layout, `.grid` multi-column, `.aoefig`, etc.) — none of those are class-specific.
4. Append new CSS for the two toggle controls and rank selector (after the existing `.wnote` rule, before `</style>`):

```css
  /* ---------- view toggle + stat panel ---------- */
  .controlbar{
    padding:8mm 10mm 4mm;display:flex;gap:16px;flex-wrap:wrap;align-items:center;
    font-family:'Trebuchet MS',sans-serif;font-size:11px;
  }
  .viewtoggle{display:inline-flex;border:1px solid var(--acc);border-radius:4px;overflow:hidden;}
  .viewtoggle button{
    font:inherit;font-size:11px;font-weight:700;letter-spacing:.04em;
    padding:5px 12px;border:none;background:var(--paper);color:var(--acc);cursor:pointer;
  }
  .viewtoggle button.active{background:var(--acc);color:#fff;}
  .statpanel{display:flex;gap:8px;flex-wrap:wrap;align-items:center;}
  .statpanel.disabled{opacity:.4;pointer-events:none;}
  .statpanel label{display:flex;flex-direction:column;font-size:8.5px;color:var(--ink-soft);gap:2px;}
  .statpanel input{
    width:52px;font:inherit;font-size:11px;padding:3px 5px;border:1px solid var(--line);
    border-radius:3px;background:var(--paper);color:var(--ink);
  }
  /* ---------- rank selector ---------- */
  .ranktoggle{display:flex;gap:3px;margin:0 0 3px;}
  .ranktoggle button{
    font-family:Consolas,monospace;font-size:9px;font-weight:700;
    width:18px;height:18px;line-height:1;border:1px solid var(--acc);border-radius:2px;
    background:var(--paper);color:var(--acc);cursor:pointer;padding:0;
  }
  .ranktoggle button.active{background:var(--acc);color:#fff;}
  .computed{font-weight:700;}
  .computed.prob{font-weight:400;}
```

- [ ] **Step 2: Add the control bar markup**

Immediately after `<div class="doc">` (before the Basic-tier `<table class="pagewrap">`), add:

```html
<div class="controlbar">
  <div class="viewtoggle" id="viewToggle">
    <button type="button" data-view="base" class="active">BASE</button>
    <button type="button" data-view="plugin">PLUG-IN STATS</button>
  </div>
  <div class="statpanel disabled" id="statPanel">
    <label>ATK<input type="number" id="stat-ATK" value="0" min="0"></label>
    <label>INT<input type="number" id="stat-INT" value="0" min="0"></label>
    <label>AGI<input type="number" id="stat-AGI" value="0" min="0"></label>
    <label>CHA<input type="number" id="stat-CHA" value="0" min="0"></label>
    <label>TAL<input type="number" id="stat-TAL" value="0" min="0"></label>
    <label>LCK<input type="number" id="stat-LCK" value="0" min="0"></label>
  </div>
</div>
```

- [ ] **Step 3: Paste in the icon data table**

At the end of the file, add a `<script>` block. Paste the full contents of `<scratchpad>/penguin_icons_b64.json` (from Task 1) in as a JS object literal:

```html
<script>
const ICONS = /* paste JSON content here verbatim — valid JS since JSON is a JS object literal subset */;

const SKILLS = {}; // populated in later tasks
</script>
```

- [ ] **Step 4: Verify the file opens cleanly in a browser with no console errors**

Open `Mechanics-Infographics/12_Penguin_skill-sheet.html` directly in a browser (e.g. `start` the file on Windows, or drag into a browser tab). Open DevTools console.

Expected: page renders the aqua-tinted empty shell (control bar visible, no skill cards yet since `SKILLS` is empty and no render call exists yet), zero console errors. If `ICONS` fails to parse, DevTools will show a syntax error at the exact line — fix any trailing-comma/quoting issue from the paste.

- [ ] **Step 5: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: scaffold Penguin skill sheet with aqua theme and icon data"
```

(If this directory is not yet a git repo, run `git init` first and confirm with the user before committing — per this session's git safety rules. Skip commit steps entirely if the user has not set up version control here.)

---

## Task 3: Build the formula evaluator (symbolic + numeric render modes)

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` (append to the existing `<script>` block)

**Interfaces:**
- Consumes: nothing external — pure functions operating on formula strings and a stats object.
- Produces:
  - `parseFormula(expr: string) -> AST` — parses a formula string into a small AST. Grammar: numbers, the 6 stat tokens (`ATK`,`INT`,`AGI`,`CHA`,`TAL`,`LCK`), `+ - × / ⌈⌉ ⌊⌋`, parens, and 5 named adjuster function calls (`agiAdjust(expr)`, `magAdjust(expr)`, `chaAdjust(expr)`, `talAdjust(expr)`, `lckAdjust(expr)`).
  - `renderSymbolic(ast: AST) -> string` — returns HTML string, e.g. stat tokens render as bare names, `magAdjust(x)` renders as `x` immediately followed by an `INT↓` superscript-style tag (matching the existing template's `CAST 5s INT↓` chip convention).
  - `renderNumeric(ast: AST, stats: {ATK,INT,AGI,CHA,TAL,LCK}) -> number` — evaluates to a plain number using the 5 documented adjuster formulas (see Global Constraints / data reference doc's "Global mechanics" section for exact formulas).
  - `formatNumber(n: number) -> string` — rounds to a sensible display precision (whole numbers for damage/HP/MP, 1 decimal for seconds) — used by `renderNumeric` callers, not by `renderNumeric` itself (keeps the evaluator returning raw numbers for testability).

- [ ] **Step 1: Write the tokenizer + parser**

```js
function tokenizeFormula(expr) {
  const re = /\s*(?:(\d+\.?\d*)|(ATK|INT|AGI|CHA|TAL|LCK)|(agiAdjust|magAdjust|chaAdjust|talAdjust|lckAdjust)|([()+\-×*/⌈⌉⌊⌋,]))\s*/g;
  const tokens = [];
  let m, pos = 0;
  while (pos < expr.length) {
    re.lastIndex = pos;
    m = re.exec(expr);
    if (!m || m.index !== pos) throw new Error(`Bad formula token at "${expr.slice(pos)}"`);
    if (m[1]) tokens.push({t:"num", v:parseFloat(m[1])});
    else if (m[2]) tokens.push({t:"stat", v:m[2]});
    else if (m[3]) tokens.push({t:"fn", v:m[3]});
    else if (m[4]) tokens.push({t:"op", v:m[4]});
    pos = re.lastIndex;
  }
  return tokens;
}

// Recursive-descent parser: expr := term (('+'|'-') term)*
//                            term := factor (('×'|'*'|'/') factor)*
//                            factor := num | stat | fn '(' expr ')' | '(' expr ')' | '⌈' expr '⌉' | '⌊' expr '⌋'
function parseFormula(expr) {
  const tokens = tokenizeFormula(expr);
  let i = 0;
  function peek() { return tokens[i]; }
  function next() { return tokens[i++]; }

  function parseExpr() {
    let node = parseTerm();
    while (peek() && peek().t === "op" && (peek().v === "+" || peek().v === "-")) {
      const op = next().v;
      node = { type: "bin", op, left: node, right: parseTerm() };
    }
    return node;
  }
  function parseTerm() {
    let node = parseFactor();
    while (peek() && peek().t === "op" && (peek().v === "×" || peek().v === "*" || peek().v === "/")) {
      const op = next().v === "*" ? "×" : next.v;
      const opActual = tokens[i-1].v === "/" ? "/" : "×";
      node = { type: "bin", op: opActual, left: node, right: parseFactor() };
    }
    return node;
  }
  function parseFactor() {
    const tok = next();
    if (tok.t === "num") return { type: "num", v: tok.v };
    if (tok.t === "stat") return { type: "stat", v: tok.v };
    if (tok.t === "fn") {
      if (next().v !== "(") throw new Error(`Expected ( after ${tok.v}`);
      const arg = parseExpr();
      if (next().v !== ")") throw new Error(`Expected ) closing ${tok.v}`);
      return { type: "fn", name: tok.v, arg };
    }
    if (tok.t === "op" && tok.v === "(") {
      const node = parseExpr();
      if (next().v !== ")") throw new Error("Expected )");
      return node;
    }
    if (tok.t === "op" && tok.v === "⌈") {
      const node = parseExpr();
      if (next().v !== "⌉") throw new Error("Expected ⌉");
      return { type: "ceil", arg: node };
    }
    if (tok.t === "op" && tok.v === "⌊") {
      const node = parseExpr();
      if (next().v !== "⌋") throw new Error("Expected ⌋");
      return { type: "floor", arg: node };
    }
    throw new Error(`Unexpected token ${JSON.stringify(tok)}`);
  }

  const ast = parseExpr();
  if (i !== tokens.length) throw new Error(`Trailing tokens in "${expr}"`);
  return ast;
}
```

- [ ] **Step 2: Write a scratch test page to verify the parser**

Create `<scratchpad>/test_parser.html`:

```html
<script>
// paste tokenizeFormula + parseFormula from Task 3 Step 1 here
const cases = [
  "0.5×ATK + 60 + 1.2×TAL",
  "talAdjust(sLv×12+18)",
  "agiAdjust(8+2×sLv)",
];
// sLv isn't a stat token — this case is intentionally expected to THROW,
// confirming the parser rejects unknown identifiers rather than silently
// treating them as 0. Rank substitution happens BEFORE parsing (Task 5),
// by string-substituting the rank's own sLv value into the formula string.
for (const c of cases) {
  try {
    const ast = parseFormula(c);
    console.log("OK:", c, "->", JSON.stringify(ast));
  } catch (e) {
    console.log("THROW (expected for sLv cases):", c, "->", e.message);
  }
}
</script>
```

- [ ] **Step 3: Run it and verify expected behavior**

Open `<scratchpad>/test_parser.html` in a browser, check console.
Expected: first case (`0.5×ATK + 60 + 1.2×TAL`) logs `OK:` with a nested `bin` AST. Second and third cases (containing `sLv`, not a recognized stat token) log `THROW (expected...)` — confirming Task 5's design decision that rank-specific coefficients get substituted into the formula string BEFORE parsing, not treated as a 7th stat token.

- [ ] **Step 4: Write `renderSymbolic` and `renderNumeric`**

```js
const ADJUSTER_TAGS = { agiAdjust: null, magAdjust: "INT↓", chaAdjust: "CHA↑", talAdjust: null, lckAdjust: "LCK↑" };

function renderSymbolic(ast) {
  switch (ast.type) {
    case "num": return String(ast.v);
    case "stat": return ast.v;
    case "ceil": return `⌈${renderSymbolic(ast.arg)}⌉`;
    case "floor": return `⌊${renderSymbolic(ast.arg)}⌋`;
    case "bin": return `${renderSymbolic(ast.left)} ${ast.op} ${renderSymbolic(ast.right)}`;
    case "fn": {
      const inner = renderSymbolic(ast.arg);
      const tag = ADJUSTER_TAGS[ast.name];
      // talAdjust/agiAdjust fold into the surrounding formula's own displayed
      // tag (CD chip already says agiAdjust; TAL(n) is pre-expanded per the
      // template's documented convention) rather than adding a redundant tag.
      if (ast.name === "talAdjust") return `${inner} + 0.02×${inner}×TAL`;
      return tag ? `${inner} <span class="adj">${tag}</span>` : inner;
    }
  }
}

function renderNumeric(ast, stats) {
  switch (ast.type) {
    case "num": return ast.v;
    case "stat": return stats[ast.v] || 0;
    case "ceil": return Math.ceil(renderNumeric(ast.arg, stats));
    case "floor": return Math.floor(renderNumeric(ast.arg, stats));
    case "bin": {
      const l = renderNumeric(ast.left, stats), r = renderNumeric(ast.right, stats);
      if (ast.op === "+") return l + r;
      if (ast.op === "-") return l - r;
      if (ast.op === "×") return l * r;
      if (ast.op === "/") return l / r;
      throw new Error(`Unknown op ${ast.op}`);
    }
    case "fn": {
      const v = renderNumeric(ast.arg, stats);
      switch (ast.name) {
        case "agiAdjust": return v * 128 / (stats.AGI + 128);
        case "magAdjust": return v * 128 / (stats.INT + 128); // same shape as agiAdjust, on INT
        case "chaAdjust": return v * (1 + 0.015 * stats.CHA);
        case "talAdjust": return v + 0.02 * v * stats.TAL;
        case "lckAdjust": { const num = v * (1 + 0.01 * stats.LCK); return 100 * num / (num - v + 100); }
        default: throw new Error(`Unknown fn ${ast.name}`);
      }
    }
  }
}

function formatNumber(n) {
  if (Math.abs(n - Math.round(n)) < 0.05) return String(Math.round(n));
  return n.toFixed(1);
}
```

- [ ] **Step 5: Add numeric-mode test cases to the scratch test page**

Append to `<scratchpad>/test_parser.html`:

```html
<script>
const stats = { ATK: 200, INT: 100, AGI: 80, CHA: 50, TAL: 60, LCK: 40 };
const numCases = [
  ["0.5×ATK + 60 + 1.2×TAL", 0.5*200 + 60 + 1.2*60],
  ["talAdjust(24)", 24 + 0.02*24*60],
  ["chaAdjust(12)", 12 * (1 + 0.015*50)],
];
for (const [expr, expected] of numCases) {
  const ast = parseFormula(expr);
  const got = renderNumeric(ast, stats);
  const ok = Math.abs(got - expected) < 0.001;
  console.log(ok ? "PASS" : "FAIL", expr, "->", got, "expected", expected);
}
console.log("symbolic check:", renderSymbolic(parseFormula("talAdjust(24)")));
</script>
```

- [ ] **Step 6: Run and verify**

Reload `<scratchpad>/test_parser.html`, check console.
Expected: all three numeric cases print `PASS`. Symbolic check line prints `24 + 0.02×24×TAL`.

- [ ] **Step 7: Move the verified evaluator code into the shipped file and commit**

Append the final (verified) `tokenizeFormula`, `parseFormula`, `ADJUSTER_TAGS`, `renderSymbolic`, `renderNumeric`, `formatNumber` functions into `Mechanics-Infographics/12_Penguin_skill-sheet.html`'s `<script>` block, after the `SKILLS = {}` line from Task 2.

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: add formula evaluator with symbolic and numeric render modes"
```

---

## Task 4: Build the card renderer and one worked example (manaMissile)

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html`

**Interfaces:**
- Consumes: `ICONS`, `parseFormula`, `renderSymbolic`, `renderNumeric`, `formatNumber` (Tasks 2-3).
- Produces:
  - `SKILLS.manaMissile` data entry — the schema every later data-entry task (5-8) must match exactly.
  - `renderSkillCard(id, skill, rankIdx, view, stats) -> HTMLElement` — builds one `.sk` card DOM node from a `SKILLS` entry.
  - `currentRank: {[id]: number}` — module-level state tracking each card's selected rank index (default 0 = lowest rank).
  - `currentView: "base"|"plugin"` — module-level state.
  - `rerenderAll()` — re-renders every mounted card (called on any toggle/input change).

- [ ] **Step 1: Define the `SKILLS` entry schema using manaMissile as the worked example**

Append to the `<script>` block, replacing the placeholder `const SKILLS = {}`:

```js
const SKILLS = {
  manaMissile: {
    tier: "classA",
    title: r => r.id, // e.g. "pgn_manaMissile1" -> shown as "manaMissile1" (strip pgn_ prefix at render time)
    icon: r => r.id.replace("pgn_", ""),
    ranks: [
      { id:"pgn_manaMissile1", sLv:1, reqLv:3,  cd:"agiAdjust(8+2×1)",  cast:"magAdjust(1+1)", mp:9,  sp:0,
        dmg:"talAdjust(3×1+12)", ko:1, hate:0, range:"locked", targets:"2 missiles",
        notes:["<b>2 missiles</b>, each hits independently.","<span class=\"syn\">needs <b>\"moreMissile5\"</b></span>: +2 missiles, +<b>0.1×character level</b> dmg each."] },
      { id:"pgn_manaMissile2", sLv:2, reqLv:11, cd:"agiAdjust(8+2×2)",  cast:"magAdjust(1+2)", mp:15, sp:0,
        dmg:"talAdjust(3×2+12)", ko:1, hate:0, range:"locked", targets:"3 missiles",
        notes:["<b>3 missiles</b>, each hits independently."] },
      { id:"pgn_manaMissile3", sLv:3, reqLv:19, cd:"agiAdjust(8+2×3)",  cast:"magAdjust(1+3)", mp:21, sp:0,
        dmg:"talAdjust(3×3+12)", ko:1, hate:0, range:"locked", targets:"4 missiles",
        notes:["<b>4 missiles</b>, each hits independently."] },
      { id:"pgn_manaMissile4", sLv:4, reqLv:27, cd:"agiAdjust(8+2×4)",  cast:"magAdjust(1+4)", mp:27, sp:0,
        dmg:"talAdjust(3×4+12)", ko:1, hate:0, range:"locked", targets:"5 missiles",
        notes:["<b>5 missiles</b>, each hits independently.","<span class=\"syn\">needs <b>\"moreMissile5\"</b></span>: +2 missiles (7 total), +<b>0.1×character level</b> dmg each."] },
    ],
  },
};
```

Note: `cd`/`cast`/`dmg` formula strings have the rank's own `sLv` value already substituted in as a literal number (e.g. `"agiAdjust(8+2×2)"` for rank 2) — this matches the tokenizer's design from Task 3 Step 3, which intentionally does NOT support a live `sLv` token. Substitution happens when the data is authored (this task and Tasks 5-8), not at render time.

- [ ] **Step 2: Write `renderSkillCard`**

```js
function chipHTML(cls, label, formulaOrConst, view, stats, suffix) {
  suffix = suffix || "";
  if (typeof formulaOrConst === "number") {
    return `<span class="chip ${cls}">${label?`<span class="t">${label}</span> `:""}<b>${formulaOrConst}${suffix}</b></span>`;
  }
  const ast = parseFormula(formulaOrConst);
  const body = view === "plugin"
    ? `<b class="computed">${formatNumber(renderNumeric(ast, stats))}${suffix}</b>`
    : `<b>${renderSymbolic(ast)}${suffix}</b>`;
  return `<span class="chip ${cls}">${label?`<span class="t">${label}</span> `:""}${body}</span>`;
}

function renderSkillCard(famId, fam, rankIdx, view, stats) {
  const r = fam.ranks[rankIdx];
  const el = document.createElement("div");
  el.className = "sk";
  const iconSrc = ICONS[fam.icon(r)] || "";
  const rankButtons = fam.ranks.length > 1
    ? `<div class="ranktoggle" data-fam="${famId}">${fam.ranks.map((_,i)=>
        `<button type="button" data-rank="${i}" class="${i===rankIdx?"active":""}">${i+1}</button>`).join("")}</div>`
    : "";
  const cdChip = r.cd ? chipHTML("cd","CD",r.cd,view,stats,"s") : "";
  const mpChip = r.mp ? chipHTML("mp","MP",r.mp,view,stats) : "";
  const spChip = r.sp ? chipHTML(r.sp<0?"spr":"spb","SP",Math.abs(r.sp),view,stats) : "";
  const castChip = r.cast
    ? chipHTML("cast","CAST",r.cast,view,stats,"s")
    : `<span class="chip instant">INSTANT</span>`;
  const rangeChip = r.range === "locked" ? `<span class="chip rng"><span class="t">Range</span> <b>Locked-on</b></span>`
    : r.range === "inf" ? `<span class="chip rng"><span class="t">Range</span> <b>∞</b></span>`
    : r.range ? `<span class="chip rng"><span class="t">Range</span> <b>${r.range}</b></span>` : "";
  const dmgChip = r.dmg ? chipHTML("dmg","",r.dmg,view,stats) : "";
  const koChip = (r.ko !== undefined) ? `<span class="chip ko"><span class="t">KO</span> ${r.ko}</span>` : "";

  el.innerHTML = `
    <img class="ic" src="${iconSrc}" alt="">
    <div class="body">
      ${rankButtons}
      <h3>${r.id.replace("pgn_","")}</h3>
      <div class="chips">
        <div class="chiprow">${cdChip}${mpChip}${spChip}</div>
        <div class="chiprow">${castChip}${rangeChip}</div>
        <div class="chiprow">${dmgChip}${koChip}</div>
      </div>
      <ul class="notes">${(r.notes||[]).map(n=>`<li>${n}</li>`).join("")}</ul>
    </div>`;
  return el;
}
```

- [ ] **Step 3: Write state + mount/rerender logic and wire the control bar**

```js
const currentRank = {};
let currentView = "base";
const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0 };

function mountAllCards() {
  // Grouped by tier for Task-2's existing per-tier .grid containers.
  const tierGrids = {
    basic: document.querySelector(".tier.basic .grid"),
    classA: document.querySelector(".tier.classA .grid"),
    classB: document.querySelector(".tier.classB .grid"),
    classC: document.querySelector(".tier.classC .grid"),
  };
  for (const famId in SKILLS) {
    const fam = SKILLS[famId];
    currentRank[famId] = 0;
    const grid = tierGrids[fam.tier];
    if (!grid) { console.error(`No .tier.${fam.tier} .grid found for ${famId}`); continue; }
    const card = renderSkillCard(famId, fam, 0, currentView, stats);
    card.dataset.fam = famId;
    grid.appendChild(card);
  }
}

function rerenderAll() {
  for (const famId in SKILLS) {
    const fam = SKILLS[famId];
    const old = document.querySelector(`.sk[data-fam="${famId}"]`);
    if (!old) continue;
    const fresh = renderSkillCard(famId, fam, currentRank[famId], currentView, stats);
    fresh.dataset.fam = famId;
    old.replaceWith(fresh);
  }
}

document.addEventListener("click", e => {
  const rb = e.target.closest(".ranktoggle button");
  if (rb) {
    currentRank[rb.closest(".ranktoggle").dataset.fam] = parseInt(rb.dataset.rank, 10);
    rerenderAll();
    return;
  }
  const vb = e.target.closest("#viewToggle button");
  if (vb) {
    currentView = vb.dataset.view;
    document.querySelectorAll("#viewToggle button").forEach(b => b.classList.toggle("active", b === vb));
    document.getElementById("statPanel").classList.toggle("disabled", currentView !== "plugin");
    rerenderAll();
  }
});

document.querySelectorAll(".statpanel input").forEach(inp => {
  inp.addEventListener("input", () => {
    stats[inp.id.replace("stat-","")] = parseFloat(inp.value) || 0;
    if (currentView === "plugin") rerenderAll();
  });
});

mountAllCards();
```

Note: this relies on `.tier.basic .grid` etc. existing in the DOM already (from the ported template shell in Task 2, which has empty `.grid` divs per tier from the source template's tier tables). If Task 2's Step 1 port didn't retain the four `.tier.<name> .grid` containers, add them now as empty `<div class="grid"></div>` inside each tier's existing `.content > .tier` wrapper before proceeding.

- [ ] **Step 4: Verify manaMissile renders and both toggles work in a real browser**

Open `Mechanics-Infographics/12_Penguin_skill-sheet.html` in a browser.

Expected:
- One card appears in the Class A tier area, titled `manaMissile1`, rank buttons `1 2 3 4` with `1` active.
- CD chip shows `agiAdjust(8+2×1) INT↓`-style... actually verify it reads as symbolic text like `8+2×1 s` — inspect visually and confirm it's legible (not raw AST text, not `[object Object]`).
- Clicking rank button `3` updates the title to `manaMissile3`, chips update, notes update, icon image changes.
- Clicking "PLUG-IN STATS" enables the stat panel; entering `ATK=200, INT=100, AGI=80, CHA=50, TAL=60, LCK=40` recomputes the CD/CAST/DMG chips to plain numbers (spot-check the damage chip against `talAdjust(3×3+12)` at TAL=60 by hand: `21 + 0.02×21×60 = 46.2` → chip should show `46`).
- Switching back to "BASE" restores symbolic text.
- Zero console errors throughout.

- [ ] **Step 5: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: add card renderer, rank/view toggles, worked manaMissile example"
```

---

## Task 5: Populate Basic tier (1xx) skill data

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html`

**Interfaces:**
- Consumes: `SKILLS` schema established in Task 4.
- Produces: `SKILLS.nAttack`, `SKILLS.cAttack`, `SKILLS.intellect`, `SKILLS.doubleCast`, `SKILLS.tripleCast`, `SKILLS.statPlus` entries.

Source every value from `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md`'s "BASIC (1xx)" section — do not re-derive from source files, that extraction is already done and verified.

- [ ] **Step 1: Add the 6 Basic-tier entries**

```js
SKILLS.nAttack = {
  tier: "basic",
  icon: r => r.id.replace("pgn_",""),
  ranks: [
    { id:"pgn_nAttack1", reqLv:1, notes:[
        "Unlocks normal-attack combo hit 2.",
        "All 3 combo stages share <b>one</b> damage formula: <b>0.5×ATK</b>, KO 1 — no per-stage bonus.",
        "<span class=\"syn\">needs <b>\"spreadShot5\"</b></span>: 20% (hits 1-2) / 40% (hit 3, LCK↑) chance to fire 3 spread projectiles instead of 1." ] },
    { id:"pgn_nAttack2", reqLv:2, notes:[
        "Unlocks normal-attack combo hit 3 (finisher).",
        "Same shared <b>0.5×ATK</b> formula as hits 1-2 — no damage bonus for reaching the 3rd hit." ] },
  ],
};

SKILLS.cAttack = {
  tier: "basic",
  icon: r => r.id.replace("pgn_",""),
  ranks: [
    { id:"pgn_cAttack1", reqLv:4,  mp:"clamp(⌈0.03×1×ATK⌉, 3, 6)", notes:["Channel: 3% of ATK into <b>3~6 MP</b>/sec while holding.","<b>No direct damage on release</b> — pure MP-channel utility."] },
    { id:"pgn_cAttack2", reqLv:10, mp:"clamp(⌈0.03×2×ATK⌉, 6, 12)", notes:["Channel: 6% of ATK into <b>6~12 MP</b>/sec while holding."] },
    { id:"pgn_cAttack3", reqLv:16, mp:"clamp(⌈0.03×3×ATK⌉, 9, 18)", notes:["Channel: 9% of ATK into <b>9~18 MP</b>/sec while holding."] },
    { id:"pgn_cAttack4", reqLv:22, mp:"clamp(⌈0.03×4×ATK⌉, 12, 24)", notes:[
        "Channel: 12% of ATK into <b>12~24 MP</b>/sec while holding (max rank).",
        "<span class=\"syn\">needs <b>\"manaField5\"</b></span>: +<b>chargeLv</b> MP/tick, and shares MP with allies within 8m." ] },
  ],
};

SKILLS.intellect = {
  tier: "basic",
  icon: r => r.id.replace("pgn_",""),
  ranks: [
    { id:"pgn_Intellect1", reqLv:8,  notes:["<b>+10 INT</b>, <b>+30 current MP</b>, <b>+30 max MP</b> — the MP bonus is undocumented in the in-game tooltip."] },
    { id:"pgn_Intellect2", reqLv:16, notes:["<b>+10 INT</b>, <b>+30 current MP</b>, <b>+30 max MP</b>."] },
    { id:"pgn_Intellect3", reqLv:24, notes:["<b>+10 INT</b>, <b>+30 current MP</b>, <b>+30 max MP</b>."] },
    { id:"pgn_Intellect4", reqLv:32, notes:["<b>+10 INT</b>, <b>+30 current MP</b>, <b>+30 max MP</b>.","All 4 ranks combined: <b>+40 INT, +120 MP, +120 max MP</b>."] },
  ],
};

SKILLS.doubleCast = {
  tier: "basic",
  icon: r => r.id.replace("pgn_",""),
  ranks: [
    { id:"pgn_doubleCast1", reqLv:32, cd:"agiAdjust(240)", mp:20, sp:-20, range:null, notes:[
        "Grants self <b>multiCast lv1</b>, <b>chaAdjust(12)</b>s. Next qualifying spell cast fires twice.",
        "<span class=\"warn\">Shares its cooldown with <b>\"tripleCast2\"</b></span> — casting either puts both on CD." ] },
  ],
};
SKILLS.tripleCast = {
  tier: "basic",
  icon: r => r.id.replace("pgn_",""),
  ranks: [
    { id:"pgn_tripleCast2", reqLv:40, cd:"agiAdjust(240)", mp:40, sp:-30, range:null, notes:[
        "Grants self <b>multiCast lv2</b>, <b>chaAdjust(12)</b>s — consumed 1 level per subsequent qualifying cast (practically: next 2 casts each fire twice, not one spell firing 3× in one press).",
        "<span class=\"warn\">Shares its cooldown with <b>\"doubleCast1\"</b></span>; using either overwrites the other's pending buff rather than stacking." ] },
  ],
};

SKILLS.statPlus = {
  tier: "basic",
  icon: r => r.id.replace("pgn_",""),
  ranks: [
    { id:"pgn_statPlus1", reqLv:10, notes:["<b>+2</b> to every basic stat."] },
    { id:"pgn_statPlus2", reqLv:20, notes:["<b>+2</b> to every basic stat."] },
    { id:"pgn_statPlus3", reqLv:30, notes:["<b>+2</b> to every basic stat."] },
    { id:"pgn_statPlus4", reqLv:40, notes:["<b>+2</b> to every basic stat.","All 4 ranks combined: <b>+8</b> to every basic stat."] },
  ],
};
```

Note: passive-only families (nAttack, intellect, statPlus, and cAttack which has no cast-mechanic cooldown/damage) omit `cd`/`cast`/`dmg`/`range`/`ko` keys entirely — `renderSkillCard` (Task 4) already treats absent keys as "omit this chip" via its truthy checks. cAttack's `mp` field uses a `clamp(...)` function not yet in the Task 3 grammar — **add `clamp(lo, hi, expr)` support to the parser now** (3-arg function, evaluates all 3 sub-expressions, `Math.min(Math.max(expr,lo),hi)` in numeric mode, symbolic mode renders as `"clamp("+lo+","+hi+","+renderSymbolic(expr)+")"`). Extend `tokenizeFormula`'s function-name alternation and `parseFactor`'s function-call branch to accept `clamp` with comma-separated args (reuse the existing single-arg fn parsing, generalized to read args until `)`, splitting on top-level commas).

- [ ] **Step 2: Add `clamp` support to the evaluator (extends Task 3's parser)**

In the `<script>` block, locate the tokenizer regex from Task 3 Step 1 and widen the function-name group to include `clamp`:

```js
// change: (agiAdjust|magAdjust|chaAdjust|talAdjust|lckAdjust)
// to:     (agiAdjust|magAdjust|chaAdjust|talAdjust|lckAdjust|clamp)
```

In `parseFactor`'s function-call branch, generalize to multi-arg:

```js
if (tok.t === "fn") {
  if (next().v !== "(") throw new Error(`Expected ( after ${tok.v}`);
  const args = [parseExpr()];
  while (peek() && peek().t === "op" && peek().v === ",") { next(); args.push(parseExpr()); }
  if (next().v !== ")") throw new Error(`Expected ) closing ${tok.v}`);
  return tok.v === "clamp" ? { type:"clamp", args } : { type:"fn", name:tok.v, arg:args[0] };
}
```

In `renderSymbolic` and `renderNumeric`, add a `"clamp"` case:

```js
// renderSymbolic:
case "clamp": return `clamp(${ast.args.map(renderSymbolic).join(", ")})`;
// renderNumeric:
case "clamp": {
  const [expr, lo, hi] = ast.args.map(a => renderNumeric(a, stats));
  return Math.min(Math.max(expr, lo), hi);
}
```

- [ ] **Step 2b: Update the scratch parser test for `clamp` and re-verify**

Append to `<scratchpad>/test_parser.html`:

```js
console.log(renderSymbolic(parseFormula("clamp(0.03×1×200, 3, 6)")));
console.log(renderNumeric(parseFormula("clamp(0.03×1×200, 3, 6)"), {ATK:200,INT:0,AGI:0,CHA:0,TAL:0,LCK:0}));
```

Run: open the scratch page, check console.
Expected: symbolic line prints `clamp(0.03 × 1 × 200, 3, 6)`; numeric line prints `6` (since `0.03×1×200=6`, clamped to `[3,6]` stays `6`).

- [ ] **Step 3: Mount Basic-tier cards and verify in browser**

Reload `Mechanics-Infographics/12_Penguin_skill-sheet.html`.
Expected: Basic tier now shows 6 cards (nAttack, cAttack, intellect, doubleCast, tripleCast, statPlus) in tree order, each with correct rank-button counts (2/4/4/1/1/4). Toggle a few ranks and the plug-in view on cAttack specifically (its `mp` chip should recompute using the new `clamp` support) to confirm no console errors.

- [ ] **Step 4: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: populate Basic tier skill data, add clamp() to formula evaluator"
```

---

## Task 6: Populate Class A tier (2xx) skill data

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html`

**Interfaces:**
- Consumes: `SKILLS` schema (Task 4), `clamp` evaluator support (Task 5).
- Produces: `SKILLS.manaArc`, `SKILLS.dispell`, `SKILLS.blink`, `SKILLS.mpTransfer`, `SKILLS.manaBurn`, `SKILLS.fallingStars`, `SKILLS.fallingComets`, `SKILLS.manaVortex`, `SKILLS.novaFlare`, `SKILLS.astralTalent`, `SKILLS.meteora` (manaMissile already done in Task 4).

Source every value from the data reference doc's "CLASS A (2xx)" section.

- [ ] **Step 1: Add the 11 Class A entries**

```js
SKILLS.manaArc = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_manaArc1", reqLv:5,  cd:"agiAdjust(1)", cast:null, mp:6,  sp:-4,  dmg:"talAdjust(10×1)", ko:0, range:"3m radius, self-centered", notes:["Self-centered burst, 3m radius/3m height."] },
  { id:"pgn_manaArc2", reqLv:13, cd:"agiAdjust(1)", cast:null, mp:12, sp:-6,  dmg:"talAdjust(10×2)", ko:0, range:"3m radius, self-centered", notes:["Self-centered burst, 3m radius/3m height."] },
  { id:"pgn_manaArc3", reqLv:21, cd:"agiAdjust(1)", cast:null, mp:18, sp:-8,  dmg:"talAdjust(10×3)", ko:0, range:"3m radius, self-centered", notes:["Self-centered burst, 3m radius/3m height."] },
  { id:"pgn_manaArc4", reqLv:29, cd:"agiAdjust(1)", cast:null, mp:24, sp:-10, dmg:"talAdjust(10×4)", ko:0, range:"3m radius, self-centered", notes:["Self-centered burst, 3m radius/3m height.","<span class=\"syn\">needs <b>\"penguinOfArc5\"</b></span>: +<b>0.5×character level</b> damage, plus a cosmetic VFX swap."] },
]};

SKILLS.dispell = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_dispell1", reqLv:7,  cd:"agiAdjust(3+1)", cast:null, mp:14, sp:0, range:"5m radius (rangeMod), self-centered", notes:["Strips all lv.2 magical status from everyone in the AoE.","Also destroys mirageOrb/skyOrb items within 6m (undocumented)."] },
  { id:"pgn_dispell2", reqLv:23, cd:"agiAdjust(3+2)", cast:null, mp:22, sp:0, range:"5m radius (rangeMod), self-centered", notes:["Strips all lv.4 magical status from everyone in the AoE.","<span class=\"syn\">needs <b>\"parallelShift5\"</b></span>: dispell level +1 (lv.4→lv.5).","Also destroys mirageOrb/skyOrb items within 6m (undocumented)."] },
]};

SKILLS.blink = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_blink1", reqLv:15, cd:"agiAdjust(12)", cast:null, mp:5, sp:-10, range:"5m self-teleport", notes:["Teleports <b>5m</b> forward, ignoring collision along the path.","Removes lock-status level ≤2.","12% (LCK↑) chance <span class=\"syn\">with <b>\"doubleSpell5\"</b></span> to grant <b>multiCast</b> (1 stack, 3s) — this is the skill doubleSpell5 actually procs from, not \"any spell\"."] },
  { id:"pgn_blink2", reqLv:31, cd:"agiAdjust(12)", cast:null, mp:5, sp:-15, range:"8m self-teleport", notes:["Teleports <b>8m</b> forward, ignoring collision along the path.","Removes lock-status level ≤4.","Same 12% <b>\"doubleSpell5\"</b> multiCast-grant roll as rank 1."] },
]};

SKILLS.mpTransfer = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_mpTransfer1", reqLv:9,  cd:"agiAdjust(30)", cast:null, mp:30, sp:0, range:"locked", notes:["Heals target ally's MP: <b>30 + 0.1×your max MP</b>.","<span class=\"syn\">needs <b>\"manaSurge5\"</b></span>: +<b>0.5×character level</b> bonus heal (undocumented)."] },
  { id:"pgn_mpTransfer2", reqLv:25, cd:"agiAdjust(30)", cast:null, mp:60, sp:0, range:"locked", notes:["Heals target ally's MP: <b>60 + 0.1×your max MP</b>.","<span class=\"syn\">needs <b>\"manaSurge5\"</b></span>: +<b>0.5×character level</b> bonus heal (undocumented)."] },
]};

SKILLS.manaBurn = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_manaBurn1", reqLv:17, cd:"agiAdjust(18+6×1)", cast:"magAdjust(2+1)", mp:15, sp:0, range:"locked", notes:["Drains <b>25 MP</b> from target, deals damage = that % of their max MP now missing.","<span class=\"syn\">needs <b>\"manaSurge5\"</b></span>: status level +2, and +<b>0.1×your current MP</b> to the drain amount."] },
  { id:"pgn_manaBurn2", reqLv:33, cd:"agiAdjust(18+6×2)", cast:"magAdjust(2+2)", mp:30, sp:0, range:"locked", notes:["Drains <b>45 MP</b> from target, deals damage = that % of their max MP now missing.","<span class=\"syn\">needs <b>\"manaSurge5\"</b></span>: status level +2, and +<b>0.1×your current MP</b> to the drain amount."] },
]};

SKILLS.fallingStars = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_fallingStars1", reqLv:12, cd:"agiAdjust(30)", cast:null, mp:20, sp:-10, dmg:"talAdjust(15+15×1)", ko:0, range:"12m radius, self-centered", notes:["5 stars, 2m-radius impact each. Target cap 5.","<span class=\"syn\">needs <b>\"giantStar5\"</b></span>: ×1.5 targeting radius, target cap→10, impact radius 2m→3m, ×1.25 damage — swaps to a distinct \"giant stars\" effect."] },
  { id:"pgn_fallingStars2", reqLv:20, cd:"agiAdjust(30)", cast:null, mp:30, sp:-15, dmg:"talAdjust(15+15×2)", ko:0, range:"16m radius, self-centered", notes:["8 stars, 2m-radius impact each. Target cap 5.","<span class=\"syn\">needs <b>\"giantStar5\"</b></span>: ×1.5 targeting radius, target cap→10, impact radius 2m→3m, ×1.25 damage."] },
]};

SKILLS.fallingComets = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_fallingComets1", reqLv:28, cd:"agiAdjust(60)", cast:"magAdjust(2+4×1)", mp:35, sp:0, dmg:"talAdjust(15+15×1)", ko:0, range:"locked, ±8m scatter", notes:["5 comets scatter within ±8m of target, 6m-radius impact each, linear falloff to 50% at edge.","<span class=\"syn\">needs <b>\"giantStar5\"</b></span>: ±10m scatter, 9m impact radius, ×1.25 damage."] },
  { id:"pgn_fallingComets2", reqLv:36, cd:"agiAdjust(60)", cast:"magAdjust(2+4×2)", mp:50, sp:0, dmg:"talAdjust(15+15×2)", ko:0, range:"locked, ±8m scatter", notes:["8 comets scatter within ±8m of target, 6m-radius impact each, linear falloff to 50% at edge.","<span class=\"syn\">needs <b>\"giantStar5\"</b></span>: ±10m scatter, 9m impact radius, ×1.25 damage."] },
]};

SKILLS.manaVortex = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_manaVortex1", reqLv:17, cd:"agiAdjust(120)", cast:"magAdjust(3+2×1)", mp:40, sp:0, range:"16m tick radius (at vortex position)", notes:["Summons a pet: 200 HP, 100 max MP, chaAdjust(60)s lifetime. Ticks every 2s: 24 flat dmg + mpSap in radius.","<span class=\"syn\">Feeds <b>\"novaFlare1\"</b></span> — see its card."] },
  { id:"pgn_manaVortex2", reqLv:24, cd:"agiAdjust(120)", cast:"magAdjust(3+2×2)", mp:55, sp:0, range:"20m tick radius (at vortex position)", notes:["Summons a pet: 400 HP, 200 max MP, chaAdjust(60)s lifetime. Ticks every 2s: 36 flat dmg + mpSap in radius."] },
  { id:"pgn_manaVortex3", reqLv:31, cd:"agiAdjust(120)", cast:"magAdjust(3+2×3)", mp:70, sp:0, range:"24m tick radius (at vortex position)", notes:["Summons a pet: 600 HP, 300 max MP, chaAdjust(60)s lifetime. Ticks every 2s: 48 flat dmg + mpSap in radius."] },
]};

SKILLS.novaFlare = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_novaFlare1", reqLv:38, cd:"agiAdjust(120)", cast:null, mp:0, sp:-30, range:"= active manaVortex's own tick radius", notes:[
      "Detonates your own active <b>\"manaVortex\"</b>: damage = <b>0.5×vortex HP + vortex MP</b>, in the vortex's own AoE radius, then destroys it and refunds its MP.",
      "<span class=\"warn\">Whiffs for 0 damage (but still costs SP and goes on CD) if no manaVortex is currently active.</span>" ] },
]};

SKILLS.astralTalent = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_astralTalent1", reqLv:22, notes:["<b>+10 TAL</b>, <b>+2 max SP</b> — the +2 SP is on top of (not instead of) the SP the +10 TAL itself yields via the TAL/5 formula; undocumented in tooltip."] },
  { id:"pgn_astralTalent2", reqLv:28, notes:["<b>+10 TAL</b>, <b>+2 max SP</b>."] },
  { id:"pgn_astralTalent3", reqLv:34, notes:["<b>+10 TAL</b>, <b>+2 max SP</b>."] },
  { id:"pgn_astralTalent4", reqLv:40, notes:["<b>+10 TAL</b>, <b>+2 max SP</b>.","All 4 ranks combined: <b>+40 TAL, +8 max SP</b> flat (separate from TAL-derived SP)."] },
]};

SKILLS.meteora = { tier:"classA", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_meteora1", reqLv:35, cd:"agiAdjust(300)", cast:"magAdjust(6+6×1)", mp:120, sp:-35, dmg:"talAdjust(200+150×1)", ko:0, range:"locked, 9m impact radius", notes:["Lands on target's position, 9m-radius/6m-height impact."] },
  { id:"pgn_meteora2", reqLv:40, cd:"agiAdjust(300)", cast:"magAdjust(6+6×2)", mp:160, sp:-45, dmg:"talAdjust(200+150×2)", ko:0, range:"locked, 12m impact radius", notes:["Lands on target's position, 12m-radius/6m-height impact."] },
]};
```

Note: `range` here is sometimes a free-text descriptive string (e.g. `"3m radius, self-centered"`) rather than the `"locked"`/`"inf"`/numeric-meters sentinel from Task 4's `renderSkillCard`. **Extend `renderSkillCard`'s range-chip branch** (in this task, since it's needed for these entries) to fall through to rendering any other truthy string verbatim as the chip's bold text:

```js
// in renderSkillCard, replace the rangeChip ternary chain's final branch:
: r.range ? `<span class="chip rng"><span class="t">Range</span> <b>${r.range}</b></span>` : "";
// (already the fallback in Task 4's code — confirm it's present; if Task 4 used a stricter
// check, loosen it now so any non-empty r.range string renders directly.)
```

- [ ] **Step 2: Mount and verify in browser**

Reload the file. Expected: Class A tier shows 12 cards total (manaMissile + these 11) in tree order (manaMissile, manaArc, dispell, blink, mpTransfer, manaBurn, fallingStars, fallingComets, manaVortex, novaFlare, astralTalent, meteora). Spot-check manaVortex's range chip renders the descriptive text correctly (not `[object Object]` or blank). Toggle plug-in view with nonzero stats and confirm no console errors across all 12 cards.

- [ ] **Step 3: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: populate Class A tier skill data"
```

---

## Task 7: Populate Class B tier (3xx) skill data

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html`

**Interfaces:**
- Consumes: `SKILLS` schema (Task 4).
- Produces: `SKILLS.frozenBlast`, `SKILLS.arcticWind`, `SKILLS.arcticFrost`, `SKILLS.iceShield`, `SKILLS.iceBlock`, `SKILLS.snowMan`, `SKILLS.tornado` (incl. typhoon note), `SKILLS.frostBite`, `SKILLS.absoluteZero`, `SKILLS.blizzard`, `SKILLS.arcticEmperor`.

Source every value from the data reference doc's "CLASS B (3xx)" section. Special handling: `frostBite` has no coded mechanic (report as such, no formulas); `tornado` needs a note cross-referencing `typhoon1` since typhoon isn't its own card (it's a passive unlock with no independent cost row — fold its description into tornado's rank-4-equivalent notes, per the data reference doc's "typhoon1 is a passive UNLOCK" finding, since typhoon has no `commandNum` sibling cost row of its own to build a 4th rank from — instead add it as an extra bullet on tornado's highest rank explaining the hijack behavior).

- [ ] **Step 1: Add the 11 Class B entries**

```js
SKILLS.frozenBlast = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_frozenBlast1", reqLv:3,  cd:"agiAdjust(9+3×1)", cast:"magAdjust(3)", mp:12, sp:0, dmg:"talAdjust(1×12+18)", ko:1, range:"3m radius, self-centered, falloff to edge", notes:["Applies <b>ice lv1</b> (slow), chaAdjust(3)s, on hit.","On hit: +1 SP."] },
  { id:"pgn_frozenBlast2", reqLv:11, cd:"agiAdjust(9+3×2)", cast:"magAdjust(3)", mp:16, sp:0, dmg:"talAdjust(2×12+18)", ko:1, range:"4m radius, self-centered, falloff to edge", notes:["Applies <b>ice lv2</b> (slow), chaAdjust(3)s, on hit.","On hit: +1 SP."] },
  { id:"pgn_frozenBlast3", reqLv:19, cd:"agiAdjust(9+3×3)", cast:"magAdjust(3)", mp:20, sp:0, dmg:"talAdjust(3×12+18)", ko:1, range:"5m radius, self-centered, falloff to edge", notes:["Applies <b>ice lv3</b> (slow), chaAdjust(3)s, on hit.","On hit: +1 SP."] },
  { id:"pgn_frozenBlast4", reqLv:27, cd:"agiAdjust(9+3×4)", cast:"magAdjust(3)", mp:24, sp:0, dmg:"talAdjust(4×12+18)", ko:1, range:"6m radius, self-centered, falloff to edge", notes:["Applies <b>ice lv4</b> (slow), chaAdjust(3)s, on hit.","On hit: +1 SP.","<span class=\"syn\">needs <b>\"frozenBreak5\"</b></span>: +2m radius; if target already has <b>ice</b>, bonus defense-ignoring \"Frozen Break!\" burst = <b>15×ice level</b>."] },
]};

SKILLS.arcticWind = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_arcticWind1", reqLv:5,  cd:"agiAdjust(12+3×1)", cast:"1.5+0.5×1", mp:20, sp:0, dmg:"talAdjust(1×10+5)", ko:1, range:"4× forward trapezoid segments (4m each)", notes:["4 sequential hit-zones walking forward. On hit: +1 SP, applies <b>ice lv1</b> (chaAdjust(3)s).","<span class=\"syn\">needs <b>\"arcticFrost1\"</b></span>: 20% (LCK↑) chance to apply <b>frost</b> (2s, no slow) instead of ice — a downgrade on that roll."] },
  { id:"pgn_arcticWind2", reqLv:13, cd:"agiAdjust(12+3×2)", cast:"1.5+0.5×2", mp:26, sp:0, dmg:"talAdjust(2×10+5)", ko:1, range:"4× forward trapezoid segments (4m each)", notes:["4 sequential hit-zones walking forward. On hit: +1 SP, applies <b>ice lv2</b> (chaAdjust(3)s)."] },
  { id:"pgn_arcticWind3", reqLv:21, cd:"agiAdjust(12+3×3)", cast:"1.5+0.5×3", mp:32, sp:0, dmg:"talAdjust(3×10+5)", ko:1, range:"4× forward trapezoid segments (4m each)", notes:["4 sequential hit-zones walking forward. On hit: +1 SP, applies <b>ice lv3</b> (chaAdjust(3)s).","<span class=\"syn\">needs <b>\"deadlyFrost5\"</b></span>: doubles segments 4→8 (+100% range); if target has <b>frost</b>, bonus flat defense-ignoring \"Deadly Frost!\" burst = <b>50</b>."] },
]};

SKILLS.arcticFrost = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_arcticFrost1", reqLv:29, notes:["Sole effect: enables the 20% <b>frost</b>-instead-of-<b>ice</b> roll on <b>\"arcticWind\"</b> hits (see that card) — reads as a downgrade (2s no-slow vs 3s slow), reported exactly as coded."] },
]};

SKILLS.iceShield = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_iceShield1", reqLv:7,  cd:"agiAdjust(30+15×1)", cast:"3+0.5×1", mp:15, sp:0, range:"locked", notes:["Ally shield: <b>chaAdjust(30)</b>s duration (flat), absorbs <b>talAdjust(10+1×20)</b> damage 1:1 before depleting."] },
  { id:"pgn_iceShield2", reqLv:15, cd:"agiAdjust(30+15×2)", cast:"3+0.5×2", mp:23, sp:0, range:"locked", notes:["Ally shield: <b>chaAdjust(30)</b>s duration (flat), absorbs <b>talAdjust(10+2×20)</b> damage 1:1 before depleting."] },
  { id:"pgn_iceShield3", reqLv:23, cd:"agiAdjust(30+15×3)", cast:"3+0.5×3", mp:31, sp:0, range:"locked", notes:["Ally shield: <b>chaAdjust(30)</b>s duration (flat), absorbs <b>talAdjust(10+3×20)</b> damage 1:1 before depleting."] },
  { id:"pgn_iceShield4", reqLv:31, cd:"agiAdjust(30+15×4)", cast:"3+0.5×4", mp:39, sp:0, range:"locked", notes:["Ally shield: <b>chaAdjust(30)</b>s duration (flat), absorbs <b>talAdjust(10+4×20)</b> damage 1:1 before depleting.","<span class=\"syn\">needs <b>\"frostSpike5\"</b></span>: +<b>character level</b> flat shield HP, and a 12% chance on full-absorb to AoE-apply <b>frost</b> (5m radius, chaAdjust(2)s) to nearby enemies."] },
]};

SKILLS.iceBlock = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_iceBlock1", reqLv:9,  cd:90, cast:"1+1", mp:10, sp:0, range:"forward-placed ground zones, 12m below caster", notes:["Drops <b>2</b> ground ice-zones in a row. Each: chaAdjust(6)+6s life, 1s tick, applies <b>ice lv1</b> (2s flat) in a 9m radius.","MultiCast stacks directly multiply the zone count."] },
  { id:"pgn_iceBlock2", reqLv:25, cd:90, cast:"1+2", mp:15, sp:0, range:"forward-placed ground zones, 12m below caster", notes:["Drops <b>3</b> ground ice-zones in a row. Each: chaAdjust(6)+6s life, 1s tick, applies <b>ice lv2</b> (2s flat) in a 12m radius.","MultiCast stacks directly multiply the zone count."] },
]};

SKILLS.snowMan = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_snowMan1", reqLv:17, cd:90, cast:"2+2×1", mp:20, sp:0, range:"locked", notes:["Applies <b>snowMan lv1</b> to target: contested duration, shield payload <b>talAdjust(1×50)</b>.","<b>Both hard CC</b> (frozen, disarmed, model swapped) <b>and a depletable damage shield</b> — breaking the shield ends the CC too."] },
  { id:"pgn_snowMan2", reqLv:33, cd:90, cast:"2+2×2", mp:27, sp:0, range:"locked", notes:["Applies <b>snowMan lv2</b> to target: contested duration, shield payload <b>talAdjust(2×50)</b>.","<b>Both hard CC and a depletable damage shield</b> simultaneously.","<span class=\"syn\">needs <b>\"snowBall5\"</b></span>: can convert an active snowMan into a <b>snowBall</b> shield on the same target — see that card."] },
]};

SKILLS.tornado = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_tornado1", reqLv:12, cd:120, cast:"2+2×1", mp:36, sp:0, dmg:"talAdjust(10×1)", ko:0, range:"1m tick radius, player-steerable", notes:["Summons a steerable pet: 0.35s tick, chaAdjust(6)s channel window. On hit: +1 SP."] },
  { id:"pgn_tornado2", reqLv:20, cd:120, cast:"2+2×2", mp:48, sp:0, dmg:"talAdjust(10×2)", ko:0, range:"2m tick radius, player-steerable", notes:["Summons a steerable pet: 0.35s tick, chaAdjust(6)s channel window. On hit: +1 SP."] },
  { id:"pgn_tornado3", reqLv:28, cd:120, cast:"2+2×3", mp:60, sp:0, dmg:"talAdjust(10×3)", ko:0, range:"3m tick radius, player-steerable", notes:[
      "Summons a steerable pet: 0.35s tick, chaAdjust(6)s channel window. On hit: +1 SP.",
      "<span class=\"syn\">needs <b>\"iceTwister5\"</b></span>: 9% (LCK↑) chance per tick to apply <b>frost</b>; also raises velocity cap 30→40 (undocumented).",
      "<b class=\"warn\">If an enemy is locked and \"typhoon1\" is learned, casting this instead casts typhoon</b>: a target-orbiting summon with its own HP pool (talAdjust(sLv×100)) that self-limits total lifetime damage — same per-tick damage formula as tornado, not stronger." ] },
]};

SKILLS.frostBite = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_frostBite1", reqLv:17, notes:["<span class=\"warn\">No coded mechanical effect found</span> — its only computed value is read nowhere else in the codebase. Possibly server-side or unwired; not a DoT/poison system despite the name."] },
  { id:"pgn_frostBite2", reqLv:24, notes:["<span class=\"warn\">No coded mechanical effect found</span> (see rank 1)."] },
  { id:"pgn_frostBite3", reqLv:31, notes:["<span class=\"warn\">No coded mechanical effect found</span> (see rank 1)."] },
  { id:"pgn_frostBite4", reqLv:38, notes:["<span class=\"warn\">No coded mechanical effect found</span> (see rank 1)."] },
]};

SKILLS.absoluteZero = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_absoluteZero1", reqLv:22, cd:180, cast:"4+2×1", mp:35, sp:30, dmg:"talAdjust(1×40+55)", ko:10, range:"locked, single-target only", notes:["Applies <b>ice lv2</b> (contested duration). On hit: +1 SP (separate from the blue SP gate)."] },
  { id:"pgn_absoluteZero2", reqLv:28, cd:180, cast:"4+2×2", mp:50, sp:40, dmg:"talAdjust(2×40+55)", ko:20, range:"locked, single-target only", notes:["Applies <b>ice lv4</b> (contested duration). On hit: +1 SP (separate from the blue SP gate)."] },
]};

SKILLS.blizzard = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_blizzard1", reqLv:34, cd:240, cast:"6+3×1", mp:65, sp:0, dmg:"talAdjust(1×20+20)", ko:0, range:"9m radius around locked target (target itself excluded)", notes:["6 ticks, 1s apart (6s total). <span class=\"warn\">The locked target itself is never hit</span> — only everyone else near it."] },
  { id:"pgn_blizzard2", reqLv:40, cd:240, cast:"6+3×2", mp:90, sp:0, dmg:"talAdjust(2×20+20)", ko:0, range:"12m radius around locked target (target itself excluded)", notes:["6 ticks, 1s apart (6s total). <span class=\"warn\">The locked target itself is never hit</span> — only everyone else near it."] },
]};

SKILLS.arcticEmperor = { tier:"classB", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_arcticEmperor1", reqLv:35, cd:"agiAdjust(600)", cast:null, mp:60, sp:25, dmg:"talAdjust(60+60×1)", ko:0, range:"8m radius, self-centered", notes:[
      "<b>8 ticks (1s apart) apply <b>frost</b> with zero damage</b>, then a <b>final burst tick</b> deals the listed damage to everyone still in the zone and strips their frost.",
      "No target-lock needed — hits everyone in the zone by faction layer." ] },
  { id:"pgn_arcticEmperor2", reqLv:40, cd:"agiAdjust(600)", cast:null, mp:80, sp:35, dmg:"talAdjust(60+60×2)", ko:0, range:"8m radius, self-centered", notes:[
      "Same 8-tick frost-then-burst structure as rank 1.",
      "No target-lock needed — hits everyone in the zone by faction layer." ] },
]};
```

Note: `arcticWind`'s `cast` field uses a plain arithmetic string (`"1.5+0.5×1"`) with no adjuster wrapper — per the data reference doc, this skill's cast time is NOT `magAdjust`-wrapped (verified directly from source). Same for `tornado`'s `cast` field. Confirm `renderSkillCard`'s cast-chip branch (Task 4) doesn't hard-require a `magAdjust(...)` wrapper — it should already work since it just calls `parseFormula`/`renderSymbolic` on whatever string is given, but double check no `INT↓` tag is incorrectly appended for these two (it shouldn't be, since `renderSymbolic` only adds the tag inside the `"fn"` case, not for plain `"bin"` arithmetic).

- [ ] **Step 2: Mount and verify in browser**

Reload. Expected: Class B tier shows 11 cards in tree order. Confirm `frostBite`'s 4 ranks render with no chips at all (no CD/MP/formula fields set) — just the warning note, matching the "no coded effect" finding. Confirm `arcticWind`/`tornado`'s cast chips show plain numbers (e.g. `2s`) with no stray `INT↓` tag. Toggle plug-in view, spot check `absoluteZero1`'s SP chip renders **blue** (not red) since its data has `sp:30` (positive).

- [ ] **Step 3: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: populate Class B tier skill data"
```

---

## Task 8: Populate Class C tier (4xx) skill data

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html`

**Interfaces:**
- Consumes: `SKILLS` schema (Task 4).
- Produces: `SKILLS.spreadShot`, `SKILLS.moreMissile`, `SKILLS.frozenBreak`, `SKILLS.revisedSkill`, `SKILLS.manaField`, `SKILLS.penguinOfArc`, `SKILLS.deadlyFrost`, `SKILLS.revisedMagic`, `SKILLS.focusIntellect`, `SKILLS.parallelShift`, `SKILLS.frostSpike`, `SKILLS.revisedArt`, `SKILLS.doubleSpell`, `SKILLS.manaSurge`, `SKILLS.snowBall`, `SKILLS.cosmicRift`, `SKILLS.superStatPlus`, `SKILLS.giantStar`, `SKILLS.iceTwister`, `SKILLS.cosmicFriday`.

Source every value from the data reference doc's "CLASS C (4xx)" section. Most of these are single-rank passive cards describing what they modify on OTHER skills (already cross-referenced by name on those skills' own cards in Tasks 5-7) — per the design spec's rule, a passive's card documents the FULL delta, the base skill's card states the value at the passive's unlearned/zero state (already done that way in Tasks 5-7's `talAdjust`/formula baselines, which never assumed any Class C bonus).

- [ ] **Step 1: Add the 20 Class C entries**

```js
SKILLS.spreadShot = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_spreadShot5", reqLv:55, notes:["Modifies <b>Normal Attack</b>: 20% chance (combo hits 1-2) / 40% chance (hit 3 finisher, LCK↑) to fire <b>3 spread projectiles</b> (±15°/0°) instead of 1, each dealing normal-attack damage."] },
]};
SKILLS.moreMissile = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_moreMissile5", reqLv:55, notes:["Modifies <b>\"manaMissile\"</b>: <b>+2</b> missile count (5→7 at max rank), <b>+0.1×character level</b> damage per missile (not a flat +6 as the tooltip implies)."] },
]};
SKILLS.frozenBreak = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_frozenBreak5", reqLv:55, notes:["Modifies <b>\"frozenBlast\"</b>: <b>+2m</b> AoE radius. If target already has <b>ice</b>: bonus defense-ignoring \"Frozen Break!\" burst = <b>15×ice level</b>."] },
]};
SKILLS.revisedSkill = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_revisedSkill5", reqLv:55, notes:["<b class=\"warn\">Global</b>: reduces the SP cost of every active skill's cast by <b>50%</b> (applies class-wide via the shared cast pipeline, not per-skill)."] },
]};
SKILLS.manaField = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_manaField5", reqLv:60, notes:["Modifies <b>\"cAttack\"</b>: <b>+chargeLv</b> MP per channel tick, and shares MP with allies within 8m radius (flat <b>chargeLv</b> MP heal each)."] },
]};
SKILLS.penguinOfArc = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_penguinOfArc5", reqLv:60, notes:["Modifies <b>\"manaArc\"</b>: <b>+0.5×character level</b> damage (tooltip implies a full +level — code is half that), plus a cosmetic VFX swap."] },
]};
SKILLS.deadlyFrost = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_deadlyFrost5", reqLv:60, notes:["Modifies <b>\"arcticWind\"</b>: doubles segment count 4→8 (+100% range). If target has <b>frost</b>: bonus flat defense-ignoring \"Deadly Frost!\" burst = <b>50</b>."] },
]};
SKILLS.revisedMagic = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_revisedMagic5", reqLv:60, notes:["<b class=\"warn\">Global</b>: reduces the MP cost of every active skill's cast by <b>20%</b> (applies class-wide). Also reduces <b>\"cosmicFriday5\"</b>'s own channel-tick MP drain 25→20."] },
]};
SKILLS.focusIntellect = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_focusIntellect5", reqLv:70, cd:"agiAdjust(120)", cast:null, mp:30, sp:-75, range:null, notes:[
      "Self-buff <b>focusIntellect lv5</b>, <b>chaAdjust(6)</b>s: consumed by your <b>next</b> damage spell as ×(1+0.01×(INT-100)), then removed.",
      "<b class=\"warn\">Undocumented</b>: while learned, all incoming debuff-status durations against you are reduced <b>25%</b> — found only via cross-file search, zero tooltip mention." ] },
]};
SKILLS.parallelShift = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_parallelShift5", reqLv:70, cd:"agiAdjust(12)", cast:null, mp:10, sp:-20, range:null, notes:[
      "Warps you forward (shares <b>\"blink\"</b>'s cooldown pool), removes lv.5 lock-status from yourself and every player character within 6m.",
      "Modifies <b>\"dispell\"</b>: dispell level <b>+1</b>." ] },
]};
SKILLS.frostSpike = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_frostSpike5", reqLv:70, notes:["Modifies <b>\"iceShield\"</b>: <b>+character level</b> flat shield HP. Secondary: 12% chance on full-absorb to AoE-apply <b>frost</b> (5m radius, chaAdjust(2)s) to nearby enemies."] },
]};
SKILLS.revisedArt = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_revisedArt5", reqLv:70, notes:["<b class=\"warn\">Global</b>: reduces the cooldown of every active skill by <b>12%</b> (×0.88) class-wide, excluding basic attacks and consumable-item cooldowns. This is the ×0.88 term baked into every other card's CD chip."] },
]};
SKILLS.doubleSpell = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_doubleSpell5", reqLv:75, notes:["12% (LCK↑) chance <b>specifically on a \"blink\" cast</b> (not universal, despite the tooltip saying \"any spell\") to grant <b>multiCast</b> (1 stack, 3s) — the resulting buff then doubles whatever spell you cast next."] },
]};
SKILLS.manaSurge = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_manaSurge5", reqLv:75, notes:[
      "Modifies <b>\"manaBurn\"</b>: status level <b>+2</b> (undocumented), and <b>+0.1×your current MP</b> to the drain value.",
      "<b class=\"warn\">Also modifies \"mpTransfer\"</b> (undocumented dual scope): <b>+0.5×character level</b> bonus heal." ] },
]};
SKILLS.snowBall = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_snowBall5", reqLv:75, cd:null, cast:null, mp:30, sp:0, range:"locked (must already have snowMan on target)", notes:[
      "Converts an active <b>\"snowMan\"</b> status on the target into a <b>snowBall</b> shield (same level/remaining duration), payload <b>150×snowMan level</b>.",
      "On depletion: defense-ignoring burst = <b>150×level</b>, KO <b>15×level</b>.",
      "Confirmed <b>zero</b> secondary effects after exhaustive search — a genuine \"nothing hidden\" case." ] },
]};
SKILLS.cosmicRift = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_cosmicRift5", reqLv:75, cd:"agiAdjust(180)", cast:null, mp:50, sp:-50, range:null, notes:[
      "Self-buff <b>cosmicRift lv5</b>, <b>chaAdjust(12)</b>s: you take <b>zero</b> incoming damage AND deal <b>zero</b> outgoing damage — fully bidirectional.",
      "<span class=\"warn\">Cannot cast any other skill while active</span> (auto-refunds if attempted). Mutually exclusive with <b>\"cosmicFriday5\"</b> — the two never stack." ] },
]};
SKILLS.superStatPlus = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_superStatPlus5", reqLv:85, notes:["<b class=\"warn\">Not found in client code.</b> The tooltip string itself is broken in the client (checks the wrong class prefix), and no matching stat-bonus logic exists anywhere in the decompile. Likely server-authoritative — reported as not-found rather than guessed."] },
]};
SKILLS.giantStar = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_giantStar5", reqLv:85, notes:[
      "Modifies <b>\"fallingStars\"</b>: ×1.5 targeting radius, target cap 5→10 (undocumented), impact radius 2m→3m (undocumented), ×1.25 damage.",
      "Modifies <b>\"fallingComets\"</b>: scatter radius ±8m→±10m (undocumented), impact radius 6m→9m (+50%), ×1.25 damage.",
      "Three separate radius values change across the two skills — the tooltip only names one." ] },
]};
SKILLS.iceTwister = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_iceTwister5", reqLv:85, notes:[
      "Modifies <b>\"tornado\"</b> (and its typhoon upgrade): 9% (LCK↑) chance per tick to apply <b>frost</b>.",
      "<b class=\"warn\">Undocumented</b>: also raises the pet's velocity cap 30→40 (~33% faster travel) — found in its own Init(), not the tooltip." ] },
]};
SKILLS.cosmicFriday = { tier:"classC", icon:r=>r.id.replace("pgn_",""), ranks:[
  { id:"pgn_cosmicFriday5", reqLv:85, cd:"agiAdjust(300)", cast:null, mp:100, sp:-50, range:"3m radius, self-centered", notes:[
      "Channeled party buff: every 2s drains <b>20-25 MP</b> from you (20 with <b>\"revisedMagic5\"</b>) and pulses a 3m-radius zone, refreshing <b>cosmicFriday lv5</b> (3s, same bidirectional damage-null as <b>\"cosmicRift5\"</b>) on every ally caught inside.",
      "Mutually exclusive with <b>\"cosmicRift5\"</b> — the two never stack." ] },
]};
```

- [ ] **Step 2: Mount and verify in browser**

Reload. Expected: Class C tier shows all 20 cards. Confirm `superStatPlus`'s card renders with just its warning note and no chips (no cd/mp/sp/dmg fields set). Confirm the two GLOBAL passives (`revisedSkill`, `revisedMagic`, `revisedArt`) each render as a plain warning-note-only passive card, not miscategorized as active. Confirm `focusIntellect`, `parallelShift`, `cosmicRift`, `snowBall`, `cosmicFriday` (the 5 actual actives in this tier) show full chip rows.

- [ ] **Step 3: Full-sheet visual QA pass**

With all 68 skill-tree entries now represented across ~40 merged cards:
- Scroll the whole page in base view; confirm every tier's `.grid` packs without huge dead gaps (per the template's Common Mistakes — multi-column, not CSS Grid, should already prevent this since Task 2 ported the CSS as-is).
- Toggle plug-in view with all 6 stats set to a nonzero value (e.g. 200/100/80/50/60/40); scroll the whole page; confirm no card shows `NaN`, `undefined`, or a raw `[object Object]`.
- Toggle every card's rank selector at least once (a quick loop is fine — click through each visible rank button) and confirm no console error appears at any point.
- Check both `prefers-color-scheme: dark` (via browser DevTools rendering emulation) and light mode render the aqua accent legibly.

- [ ] **Step 4: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: populate Class C tier skill data, complete full skill sheet"
```

---

## Task 9: Publish as an Artifact

**Files:** none modified — this is a delivery step, not a code change.

**Interfaces:** none (terminal task).

- [ ] **Step 1: Verify the file is fully self-contained**

Search the completed file for any external reference that would violate the Artifact CSP:

Run: `grep -n "http://\|https://\|file:///" "Mechanics-Infographics/12_Penguin_skill-sheet.html"`
Expected: no matches (all icons are base64 data URIs from Task 1/2, no external fonts/scripts/stylesheets were added in any task).

- [ ] **Step 2: Publish**

Use the Artifact tool with `file_path` pointing at `Mechanics-Infographics/12_Penguin_skill-sheet.html`, `favicon` set to a penguin/snowflake emoji (e.g. `❄️`), and a `description` summarizing it as an interactive Penguin skill sheet with rank toggles and a live stat calculator.

- [ ] **Step 3: Open the published URL and re-run the Task 8 Step 3 QA checklist against the live Artifact** (not just the local file), since Artifact's CSP sandbox is stricter than a local file:// open and could surface an issue Task 8 didn't catch (e.g. an inline event handler blocked by CSP — this plan already avoids that by using `addEventListener`, not `onclick=` attributes, but verify no console errors appear in the published version regardless).

No commit for this task (publishing is not a file change).

---

## Self-Review Notes

- **Spec coverage**: aqua theme (Task 2), rank merge (Task 4 schema + Tasks 5-8 data), base/plug-in dual view with global stat panel (Tasks 2-4), chips-recompute-in-place with formula replaced by number (Task 4's `chipHTML`), centralized JS data object over per-chip DOM attributes (Task 4's `SKILLS` schema) — all covered.
- **Probabilistic-term display** (design spec: "show % chance plus both outcome values"): the current `SKILLS` schema (Tasks 5-8) expresses probabilistic effects as prose notes (e.g. "20% chance... instead of...") rather than a dedicated computed chip, since none of Penguin's probabilistic terms live in the primary damage/CD/duration chips the way Chameleon's crit multiplier did — they're all secondary procs (frost-instead-of-ice, spreadShot's extra projectile, doubleSpell5's multiCast grant). If a future pass wants these as live-computed `lckAdjust`-driven chips rather than static prose percentages, that's a follow-up, not a gap in this plan's own scope — flagging here rather than silently deviating from the design spec's letter.
- **Placeholder scan**: no TBD/TODO strings in any task; every formula/number in Tasks 5-8 is sourced directly from the data reference doc, not invented.
- **Type consistency**: `SKILLS[id].ranks[i]` field names (`id, reqLv, cd, cast, mp, sp, dmg, ko, hate, range, notes`) are established in Task 4 and used identically in Tasks 5-8; `renderSkillCard`'s signature (`famId, fam, rankIdx, view, stats`) and `chipHTML`'s signature stay fixed from Task 4 onward with one additive extension (Task 5's `clamp`, Task 6's free-text `range` fallback) — both extensions are backward-compatible with Task 4's original card.
