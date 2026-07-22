# Penguin LCK-Range Display + revisedArt Toggle Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Replace the evaluator's single-number plug-in-view output with a true `[min-max]` range for every chip whose formula involves a randomized LCK-adjuster, add Enemy Stats (DEF/CHA/LCK) and DMG Mod inputs, rename the Lv label to "Player Level," and add a global grayscale/color revisedArt5 toggle that applies `ceil(0.88×x)` to every cooldown chip's range.

**Architecture:** The formula evaluator's `renderNumeric(ast, stats)` is replaced by `renderRange(ast, stats, enemyStats)`, which walks the AST once per extreme (`"min"`/`"max"` roll mode) reusing one shared per-node evaluator parameterized by roll mode, rather than duplicating formula logic. `chipHTML` and `substituteInlineChips` switch from single-value plug-in rendering to range rendering, with the `dmg` chip specifically wrapped in an additional attacker/defender mitigation step (`dmgAdjust` → `defAdjust`). `revisedArt` is a single top-level boolean (not per-card state, since the passive is class-wide), applied as a final step to CD-chip ranges only. Base (symbolic) view is untouched — no code path changes for it.

**Tech Stack:** Same as the file being modified — plain HTML/CSS/JS, no build step, no framework, self-contained (no external requests), no `eval`/`Function` constructor.

## Global Constraints

- No `eval()`/`Function()` constructor anywhere.
- The shipped HTML file must remain fully self-contained — no external stylesheet/script/font/image requests.
- Base (symbolic) view renders exactly as it does today — zero changes to `renderSymbolic` or any base-view chip text. All range/mitigation work is plug-in-view-only.
- Every adjuster's numeric formula and rounding must exactly replicate the verified source (`CharacterControl.cs`), not an approximation — exact values are given in each task below, sourced from `docs/superpowers/specs/2026-07-22-penguin-lck-range-and-revisedart-design.md`.
- `[min-max]` bracket format with the unit suffix once after the closing bracket (e.g. `CD [8.5-9.2]s`); if `min === max`, collapse to a single unbracketed number.
- Attacker-side rolls (a formula's own adjuster roll + `dmgAdjust`'s roll) move together in the same direction; the defender-side roll (`defAdjust`'s DEF roll) moves in the opposite direction, for true min/max bracketing.
- `revisedArt`'s `ceil(0.88×x)` step applies strictly AFTER a CD chip's own range is computed (both endpoints), never combined into the base formula.
- Do not implement `atkAdjust` unless Task 1's audit finds it's actually referenced by a Penguin formula on this sheet (the design doc flags it as likely unused).
- Do not add ranges to MP/SP chips — those are flat, non-randomized costs in source.

---

## File Structure

Single file, as established by all prior work on this sheet: `Mechanics-Infographics/12_Penguin_skill-sheet.html`. No new files — a separate .js/.css file could not be fetched at runtime by a published Artifact.

---

## Task 1: Replace renderNumeric with a range-capable evaluator core

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:678-708` (`renderNumeric` function)

**Interfaces:**
- Consumes: existing `parseFormula` AST shape (`num`, `stat`, `ceil`, `floor`, `bin`, `fn`, `clamp` node types) — unchanged, this task only touches how the AST is evaluated numerically, not parsed.
- Produces: `evalAdjuster(name, argValue, rollStat, rollMode)` — a new helper computing one adjuster function's output at a given LCK-roll extreme (`rollMode` is `"min"` (roll=0) or `"max"` (roll=`Math.ceil(0.2*rollStat)`)), and `renderRange(ast, stats, rollMode)` — walks an AST once, returning a single number for that specific `rollMode`, using `evalAdjuster` for every `fn` node's LCK-dependent stat. Later tasks call `renderRange(ast, stats, "min")` and `renderRange(ast, stats, "max")` as a pair to get the full range; `formatNumber` (unchanged, `:710-713`) still formats each endpoint's display text.

This task builds and unit-tests the core math in isolation (a scratch HTML/Node harness — this codebase has no test framework, verification is done via a headless Node `vm` harness or real browser console, per the pattern already used throughout this file's history) before Task 3 wires it into chip rendering.

- [ ] **Step 1: Read the current renderNumeric implementation**

Read `Mechanics-Infographics/12_Penguin_skill-sheet.html` lines 678-708 to see the exact current code (reproduced here for reference, but confirm against the live file since prior tasks may have shifted line numbers slightly):

```js
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
    case "clamp": {
      const [expr, lo, hi] = ast.args.map(a => renderNumeric(a, stats));
      return Math.min(Math.max(expr, lo), hi);
    }
  }
}
```

Note: the current `agiAdjust`/`magAdjust` formulas (`v×128/(AGI+128)`) are algebraically identical to the real source's roll=0 case (`v×(1−AGI/(AGI+128))` at roll=0 — verified by direct computation during design). This task generalizes them to accept any roll value, not fixes a bug — `renderRange(ast, stats, "min")`'s output for these two functions must exactly equal today's `renderNumeric` output, as a regression check.

- [ ] **Step 2: Replace renderNumeric with the range-capable version**

Replace the entire function (lines 678-708) with:

```js
// A "roll" is the random(0, ceil(0.2*LCK)) term every adjuster function
// draws from its own relevant character's LCK stat in the real game
// (CharacterControl.cs). rollMode "min" always evaluates the roll as 0;
// "max" evaluates it as its ceiling, ceil(0.2*rollStat). Exact per-function
// formulas and rounding below are transcribed verbatim from source, not
// approximated — see docs/superpowers/specs/2026-07-22-penguin-lck-range-and-revisedart-design.md.
function rollValue(rollStat, rollMode) {
  return rollMode === "max" ? Math.ceil(0.2 * rollStat) : 0;
}

// Evaluates one adjuster function's output at a specific roll extreme.
// `v` is the function's already-evaluated argument (nPower/nTimeout/nTimer/etc).
// `rollStat` is the LCK value belonging to whichever character the adjuster
// rolls against (attacker for talAdjust/agiAdjust/magAdjust/chaAdjust/dmgAdjust,
// defender for defAdjust — callers pass the correct stat object's LCK).
function evalAdjuster(name, v, rollStat, rollMode) {
  const roll = rollValue(rollStat, rollMode);
  switch (name) {
    case "agiAdjust": {
      // CharacterControl.cs:20575 — num = AGI+roll (no clamp), no internal rounding.
      // AGI must be passed as part of `rollStat`'s owning stats object; see
      // callers in Task 3 for how AGI itself (not just LCK) reaches this function.
      throw new Error("agiAdjust must be called via evalAgiAdjust (needs AGI, not just LCK)");
    }
    default: throw new Error(`evalAdjuster: unhandled ${name}`);
  }
}

// agiAdjust/magAdjust/chaAdjust/talAdjust each need TWO stats (the roll's own
// stat, e.g. AGI, AND LCK for the roll's ceiling) — a single-stat helper
// signature doesn't fit all of them cleanly, so each gets its own explicit
// function instead of forcing a shared shape that would obscure the exact
// per-function source formula. All four take (v, statValue, lckValue, rollMode).
function evalAgiAdjust(v, agi, lck, rollMode) {
  const num = agi + rollValue(lck, rollMode);
  return v * (1 - num / (num + 128));
}
function evalMagAdjust(v, intStat, lck, rollMode) {
  const num = Math.min(Math.max(intStat + rollValue(lck, rollMode), 1), 512);
  // CharacterControl.cs:20587 — num/32 is integer division (num and 32 both
  // int in source), truncating toward zero BEFORE the subtraction.
  const divided = Math.trunc(num / 32);
  return Math.min(Math.max(v - divided, 0.1), 600);
}
function evalChaAdjust(v, cha, lck, rollMode) {
  const num = Math.min(Math.max(cha + rollValue(lck, rollMode), 1), 512);
  const truncated = Math.trunc(v * (1 + 0.015 * num));
  // CharacterControl.cs:20593-20619 — ceil only applies in the t>0 branch;
  // a non-positive result returns as-is, un-ceil'd.
  return truncated > 0 ? Math.ceil(truncated) : truncated;
}
function evalTalAdjust(v, tal, lck, rollMode) {
  if (v <= 0) return 0;
  const num = Math.min(Math.max(tal + rollValue(lck, rollMode), 1), 512);
  const truncated = Math.trunc(v * (1 + 0.02 * num));
  return Math.ceil(truncated);
}
function evalLckAdjust(v, lck) {
  // lckAdjust has no random roll of its own (CharacterControl.cs:20658) —
  // it's a deterministic diminishing-returns curve on the caster's own LCK,
  // unaffected by min/max roll mode. Unchanged from the sheet's existing formula.
  const num = v * (1 + 0.01 * lck);
  return 100 * num / (num - v + 100);
}

// dmgAdjust and defAdjust are NOT reachable via the generic `fn` AST case —
// no Penguin skill formula string contains a literal "dmgAdjust(...)" or
// "defAdjust(...)" call (those two only ever apply to a dmg chip's ALREADY-
// evaluated final number, as a post-processing step — see Task 3's dmg-chip
// wrapper). They're defined here as plain functions, not evaluator cases,
// since they never appear inside a parsed formula AST.
function evalDmgAdjust(d, damageMod, attackerLck, rollMode) {
  const roll = rollValue(attackerLck, rollMode);
  const clampedMod = Math.min(Math.max(damageMod, 0), 5);
  return Math.ceil(clampedMod * d + roll);
}
function evalDefAdjust(d, def, defenderLck, rollMode) {
  const defRoll = rollValue(defenderLck, rollMode);
  const defPrime = Math.min(Math.max(def + defRoll, 1), 512);
  let flat = Math.trunc(d - 0.5 * defPrime);
  if (flat < 1) flat = 1;
  let pct = Math.trunc(d * (1 - defPrime / (defPrime + 64)));
  if (pct < 1) pct = 1;
  return Math.ceil(0.35 * flat + 0.65 * pct);
}

// Walks an AST once, evaluating every LCK-adjuster at the given roll extreme
// ("min" or "max"), using `stats` for the attacker-side values (ATK/INT/AGI/
// CHA/TAL/LCK/Lv/damageMod — the existing global `stats` object, extended in
// Task 2). Defender stats never appear inside a formula AST (no skill formula
// references enemy stats directly) — defAdjust is applied separately in
// Task 3's dmg-chip wrapper, not through this function.
function renderRange(ast, stats, rollMode) {
  switch (ast.type) {
    case "num": return ast.v;
    case "stat": return stats[ast.v] || 0;
    case "ceil": return Math.ceil(renderRange(ast.arg, stats, rollMode));
    case "floor": return Math.floor(renderRange(ast.arg, stats, rollMode));
    case "bin": {
      const l = renderRange(ast.left, stats, rollMode), r = renderRange(ast.right, stats, rollMode);
      if (ast.op === "+") return l + r;
      if (ast.op === "-") return l - r;
      if (ast.op === "×") return l * r;
      if (ast.op === "/") return l / r;
      throw new Error(`Unknown op ${ast.op}`);
    }
    case "fn": {
      const v = renderRange(ast.arg, stats, rollMode);
      switch (ast.name) {
        case "agiAdjust": return evalAgiAdjust(v, stats.AGI, stats.LCK, rollMode);
        case "magAdjust": return evalMagAdjust(v, stats.INT, stats.LCK, rollMode);
        case "chaAdjust": return evalChaAdjust(v, stats.CHA, stats.LCK, rollMode);
        case "talAdjust": return evalTalAdjust(v, stats.TAL, stats.LCK, rollMode);
        case "lckAdjust": return evalLckAdjust(v, stats.LCK);
        default: throw new Error(`Unknown fn ${ast.name}`);
      }
    }
    case "clamp": {
      const [expr, lo, hi] = ast.args.map(a => renderRange(a, stats, rollMode));
      return Math.min(Math.max(expr, lo), hi);
    }
  }
}
```

Delete the unused `evalAdjuster` stub written in this step — it was a false start superseded by the four explicit `eval*Adjust` functions; do not leave dead code. (Written above only to show the reasoning; the actual file edit should NOT include `evalAdjuster`, only `rollValue`, `evalAgiAdjust`, `evalMagAdjust`, `evalChaAdjust`, `evalTalAdjust`, `evalLckAdjust`, `evalDmgAdjust`, `evalDefAdjust`, and `renderRange`.)

- [ ] **Step 3: Write a scratch verification harness and confirm regression-safety**

Create `<scratchpad>/test_range_evaluator.js` (this repo's scratchpad directory, NOT committed):

```js
const fs = require('fs');
const html = fs.readFileSync(process.argv[2], 'utf8');
const script = html.match(/<script>([\s\S]*)<\/script>/)[1];
const Module = require('module');
const m = new Module('test');
m._compile(script.replace('mountAllCards();','') + '; module.exports = { parseFormula, renderRange, renderSymbolic };', 'test.js');
const { parseFormula, renderRange } = m.exports;

const stats = { ATK:200, INT:100, AGI:80, CHA:50, TAL:60, LCK:40, Lv:60 };

// Regression check: renderRange(..., "min") must equal the OLD renderNumeric
// output for agiAdjust/magAdjust (both algebraically roll=0 already).
const agiOld = 14 * 128 / (stats.AGI + 128);
const agiNew = renderRange(parseFormula("agiAdjust(14)"), stats, "min");
console.log("agiAdjust min matches old formula:", Math.abs(agiOld - agiNew) < 1e-9, agiOld, agiNew);

const magOld = 4 * 128 / (stats.INT + 128);
// magAdjust's real formula differs in shape from the old approximation
// (integer-divide by 32, not a 128-based ratio) — this is EXPECTED to NOT
// match; the old magAdjust implementation was never verified against source
// the way agiAdjust was. Print both for visual confirmation, do not assert equality.
const magNew = renderRange(parseFormula("magAdjust(4)"), stats, "min");
console.log("magAdjust old(approx):", magOld, " new(min, real source):", magNew);

// talAdjust sanity: at roll=0, TAL=60 -> num=60, truncated = trunc(15*(1+0.02*60)) = trunc(15*2.2) = trunc(33) = 33, ceil(33)=33
const talMin = renderRange(parseFormula("talAdjust(15)"), stats, "min");
console.log("talAdjust(15) min:", talMin, "expected 33:", talMin === 33);

// talAdjust max: LCK=40 -> roll=ceil(0.2*40)=8 -> num=clamp(60+8,1,512)=68 -> trunc(15*(1+0.02*68))=trunc(15*2.36)=trunc(35.4)=35 -> ceil(35)=35
const talMax = renderRange(parseFormula("talAdjust(15)"), stats, "max");
console.log("talAdjust(15) max:", talMax, "expected 35:", talMax === 35);

// dmgAdjust/defAdjust are plain functions, not in the evaluator switch — test directly.
console.log("evalDmgAdjust exported:", typeof m.exports.evalDmgAdjust);
```

Note: `evalDmgAdjust`/`evalDefAdjust` need to be added to the `module.exports` line in the harness too if testing them directly — extend the harness's export line to include every new function name for full coverage, not just `renderRange`.

- [ ] **Step 4: Run the harness and verify output**

Run: `node <scratchpad>/test_range_evaluator.js "Mechanics-Infographics/12_Penguin_skill-sheet.html"`
Expected: `agiAdjust min matches old formula: true ...`, `talAdjust(15) min: 33 expected 33: true`, `talAdjust(15) max: 35 expected 35: true`. The `magAdjust` line is informational only (documents the old approximation was never source-accurate to begin with — this is a genuine formula correction for magAdjust/CAST chips, not a regression, flag this finding in the task report).

- [ ] **Step 5: Confirm no other code in the file still calls the old `renderNumeric` name**

Run: `grep -n "renderNumeric" "Mechanics-Infographics/12_Penguin_skill-sheet.html"`
Expected: zero matches (Task 1 fully removes the old function; Task 3 updates every call site to use `renderRange` instead — if this grep finds remaining references, Task 3 hasn't been done yet, which is fine at this point in the plan, but note them for Task 3's implementer).

- [ ] **Step 6: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: replace renderNumeric with range-capable evaluator (min/max LCK rolls)"
```

Note: this commit intentionally leaves `chipHTML`/`substituteInlineChips` calling the now-deleted `renderNumeric` — the file will NOT run correctly in a browser until Task 3 completes. This is acceptable within this plan's task sequence (each task's own commit doesn't have to leave the whole file working end-to-end, only Task 1's own new code needs to be correct and tested in isolation via the Step 3-4 harness) — but flag this clearly in the task report so the next task's implementer isn't surprised the live page is temporarily broken.

---

## Task 2: Add Enemy Stats panel, DMG Mod field, Player Level relabel, persistence

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:260-274` (control bar HTML)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:824-827` (state block — `stats` object)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` persistence code (localStorage load/save, currently near the bottom of the `<script>` block — search for `STATS_STORAGE_KEY`)
- Modify: CSS (`<style>` block, near existing `.statpanel` rules, currently ~line 224-230)

**Interfaces:**
- Consumes: existing `.statpanel`/`.statpanel input` CSS pattern, existing `stats` object shape, existing localStorage persistence mechanism (`STATS_STORAGE_KEY`).
- Produces: `stats` object gains an 8th key, `damageMod` (default `1`). A new top-level `enemyStats` object: `{ DEF:0, CHA:0, LCK:0 }`, with its own localStorage key (`penguinSheetEnemyStats`) and its own input-panel wiring, following the exact same pattern as `stats`'s existing persistence code. Later tasks (3, 5) read both `stats` and `enemyStats` when computing dmg-chip ranges.

- [ ] **Step 1: Read the current control bar HTML and persistence code**

Read `Mechanics-Infographics/12_Penguin_skill-sheet.html` lines 260-274 (control bar) and search for `STATS_STORAGE_KEY` to find the exact current persistence code — confirm against the live file, since line numbers may have shifted since this plan was written.

- [ ] **Step 2: Update control bar HTML — label Player Stats, rename Lv, add DMG Mod, add Enemy Stats panel**

Replace the `.statpanel` div and add a new `.enemystatpanel` div:

```html
<div class="controlbar">
  <div class="viewtoggle" id="viewToggle">
    <button type="button" data-view="base" class="active">BASE</button>
    <button type="button" data-view="plugin">PLUG-IN STATS</button>
  </div>
  <div class="statgroup">
    <div class="statgrouplabel">Player Stats</div>
    <div class="statpanel disabled" id="statPanel">
      <label>ATK<input type="number" id="stat-ATK" value="0" min="0"></label>
      <label>INT<input type="number" id="stat-INT" value="0" min="0"></label>
      <label>AGI<input type="number" id="stat-AGI" value="0" min="0"></label>
      <label>CHA<input type="number" id="stat-CHA" value="0" min="0"></label>
      <label>TAL<input type="number" id="stat-TAL" value="0" min="0"></label>
      <label>LCK<input type="number" id="stat-LCK" value="0" min="0"></label>
      <label>Player Level<input type="number" id="stat-Lv" value="0" min="0"></label>
      <label>DMG Mod<input type="number" id="stat-damageMod" value="1" min="0" step="0.1"></label>
    </div>
  </div>
  <div class="statgroup">
    <div class="statgrouplabel">Enemy Stats</div>
    <div class="statpanel disabled" id="enemyStatPanel">
      <label>DEF<input type="number" id="enemystat-DEF" value="0" min="0"></label>
      <label>CHA<input type="number" id="enemystat-CHA" value="0" min="0"></label>
      <label>LCK<input type="number" id="enemystat-LCK" value="0" min="0"></label>
    </div>
  </div>
</div>
```

Note: `id="stat-damageMod"` (not `id="stat-DMG Mod"`) — the input `id` suffix must match the exact `stats` object key (`damageMod`), following the file's existing `inp.id.replace("stat-","")` convention; the visible `<label>` text ("DMG Mod") is independent of the `id`/key naming and can read however is most readable.

- [ ] **Step 3: Add matching CSS for the new `.statgroup`/`.statgrouplabel` wrapper**

Find the existing `.statpanel` CSS rules (search for `.statpanel{`) and add immediately before them:

```css
  .statgroup{display:flex;flex-direction:column;gap:3px;}
  .statgrouplabel{font-size:8px;font-weight:700;letter-spacing:.05em;text-transform:uppercase;color:var(--ink-soft);}
```

Confirm the existing `.statpanel label` rule already sizes labels reasonably for the longer "Player Level"/"DMG Mod" text (it uses `flex-direction:column`, so longer label text just wraps above its own input — no layout break expected, but visually confirm in Step 7).

- [ ] **Step 4: Extend the `stats` object with `damageMod`**

Find `const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0, Lv:0 };` and change to:

```js
const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0, Lv:0, damageMod:1 };
```

- [ ] **Step 5: Add the `enemyStats` object and its persistence, mirroring the existing `stats` pattern exactly**

Find the existing persistence block (search for `STATS_STORAGE_KEY`) — it currently looks like:

```js
const STATS_STORAGE_KEY = "penguinSheetStats";
try {
  const saved = JSON.parse(localStorage.getItem(STATS_STORAGE_KEY) || "{}");
  for (const key in stats) {
    if (typeof saved[key] === "number") {
      stats[key] = saved[key];
      const inp = document.getElementById("stat-" + key);
      if (inp) inp.value = saved[key];
    }
  }
} catch (e) { /* corrupt/inaccessible storage — fall back to defaults silently */ }

document.querySelectorAll(".statpanel input").forEach(inp => {
  inp.addEventListener("input", () => {
    stats[inp.id.replace("stat-","")] = parseFloat(inp.value) || 0;
    try { localStorage.setItem(STATS_STORAGE_KEY, JSON.stringify(stats)); } catch (e) {}
    if (currentView === "plugin") rerenderAll();
  });
});
```

Add the `enemyStats` object declaration near the existing `stats` declaration (Step 4's location):

```js
const enemyStats = { DEF:0, CHA:0, LCK:0 };
```

Then add a second persistence block immediately after the existing one (do not merge into one generic loop — keep them as separate, clearly-named blocks for readability, since they use different id-prefixes and storage keys):

```js
const ENEMY_STATS_STORAGE_KEY = "penguinSheetEnemyStats";
try {
  const savedEnemy = JSON.parse(localStorage.getItem(ENEMY_STATS_STORAGE_KEY) || "{}");
  for (const key in enemyStats) {
    if (typeof savedEnemy[key] === "number") {
      enemyStats[key] = savedEnemy[key];
      const inp = document.getElementById("enemystat-" + key);
      if (inp) inp.value = savedEnemy[key];
    }
  }
} catch (e) {}

document.querySelectorAll("#enemyStatPanel input").forEach(inp => {
  inp.addEventListener("input", () => {
    enemyStats[inp.id.replace("enemystat-","")] = parseFloat(inp.value) || 0;
    try { localStorage.setItem(ENEMY_STATS_STORAGE_KEY, JSON.stringify(enemyStats)); } catch (e) {}
    if (currentView === "plugin") rerenderAll();
  });
});
```

Note the existing `.statpanel input` selector in the FIRST persistence block would now ALSO match `#enemyStatPanel`'s inputs, since `#enemyStatPanel` itself has class `statpanel` (per Step 2's HTML). Change the first block's selector from `document.querySelectorAll(".statpanel input")` to `document.querySelectorAll("#statPanel input")` to scope it correctly to only the Player Stats panel — this is a required fix alongside adding the new block, not optional, since without it every Enemy Stats input change would incorrectly try to write into the `stats` object under whatever key `inp.id.replace("stat-","")` produces (e.g. `"enemystat-DEF".replace("stat-","")` incorrectly strips the wrong substring — confirm this bug by tracing it, then fix by scoping the selector).

- [ ] **Step 6: Also update the `#viewToggle` view-toggle handler to enable/disable BOTH stat panels together**

Find the click handler branch for `#viewToggle button` (search for `getElementById("statPanel")`) — it currently does:

```js
document.getElementById("statPanel").classList.toggle("disabled", currentView !== "plugin");
```

Change to also toggle the enemy panel:

```js
document.getElementById("statPanel").classList.toggle("disabled", currentView !== "plugin");
document.getElementById("enemyStatPanel").classList.toggle("disabled", currentView !== "plugin");
```

- [ ] **Step 7: Verify in a real browser (or headless Chrome, per the pattern used throughout this file's history)**

Open the file. Confirm: "Player Stats" and "Enemy Stats" labels are visible above their respective panels; the 7th Player Stats field reads "Player Level" (not "Lv"); an 8th "DMG Mod" field exists, defaulting to `1`; Enemy Stats shows DEF/CHA/LCK, all defaulting to `0`; switching to Plug-in Stats view enables BOTH panels (not just Player Stats); entering a value in Enemy Stats DEF persists after a simulated reload (reuse the localStorage round-trip test pattern from the original persistence commit — type a value, re-execute the script in a fresh Node `vm` context sharing the same mock `localStorage`, confirm the value comes back). Confirm zero console errors.

- [ ] **Step 8: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: add Enemy Stats panel, DMG Mod field, relabel Lv to Player Level"
```

---

## Task 3: Wire range rendering into chipHTML and substituteInlineChips, including the dmg mitigation pipeline

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — `chipHTML` function (currently ~line 716)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — `substituteInlineChips` function (currently ~line 736)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — `renderSkillCard`'s dmg-chip call site inside `substituteInlineChips` (the `case "dmg":` branch)

**Interfaces:**
- Consumes: Task 1's `renderRange(ast, stats, rollMode)`, `evalDmgAdjust`, `evalDefAdjust`; Task 2's `enemyStats` object.
- Produces: `chipHTML(cls, label, formulaOrConst, view, stats, suffix, enemyStats)` — SAME name, one new trailing parameter (`enemyStats`, optional/only meaningfully used for `cls === "dmg"`). `substituteInlineChips(text, r, view, stats, enemyStats)` — same addition. Every existing call site of both functions (rank-toggle chips, classC-toggle chips, ctrlrow, etc.) needs the new argument threaded through — grep for all call sites before starting, don't rely on this list being exhaustive from memory.

- [ ] **Step 1: Read the current chipHTML and substituteInlineChips implementations, and find every call site**

Run: `grep -n "chipHTML(\|substituteInlineChips(" "Mechanics-Infographics/12_Penguin_skill-sheet.html"`

This must find every place these two functions are DEFINED and every place they're CALLED (expect calls inside `renderSkillCard` for `cdChip`/`mpChip`/`spChip`/`castChip` and inside `substituteInlineChips`'s own token-switch body for `dmg`/`cd`/`mp`/`sp`/`cast`/`range`/`ko`). Read the full current bodies of both functions before editing.

- [ ] **Step 2: Rewrite `chipHTML` to use ranges in plug-in view**

Current shape (confirm against live file, may differ slightly):

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
```

Replace with:

```js
// Formats a computed {min,max} pair as "N" (if min===max after formatting)
// or "[min-max]" otherwise. Suffix (e.g. "s") is appended once, outside
// the brackets, per the design's display-format decision.
function formatRange(min, max, suffix) {
  const minS = formatNumber(min), maxS = formatNumber(max);
  return minS === maxS ? `${minS}${suffix}` : `[${minS}-${maxS}]${suffix}`;
}

function chipHTML(cls, label, formulaOrConst, view, stats, suffix, revisedArtOn) {
  suffix = suffix || "";
  if (typeof formulaOrConst === "number") {
    return `<span class="chip ${cls}">${label?`<span class="t">${label}</span> `:""}<b>${formulaOrConst}${suffix}</b></span>`;
  }
  const ast = parseFormula(formulaOrConst);
  let body;
  if (view === "plugin") {
    let min = renderRange(ast, stats, "min");
    let max = renderRange(ast, stats, "max");
    // revisedArt5: ceil(0.88 * cTime), applied strictly AFTER the base CD
    // range, to both endpoints independently — CD chips only (identified
    // by cls === "cd"). See Task 5 for how revisedArtOn is threaded in.
    if (cls === "cd" && revisedArtOn) {
      min = Math.ceil(0.88 * min);
      max = Math.ceil(0.88 * max);
    }
    body = `<b class="computed">${formatRange(min, max, suffix)}</b>`;
  } else {
    body = `<b>${renderSymbolic(ast)}${suffix}</b>`;
  }
  return `<span class="chip ${cls}">${label?`<span class="t">${label}</span> `:""}${body}</span>`;
}
```

Note: `formatRange` bakes the `suffix` into its own return value, so callers passing `suffix` into `chipHTML` should NOT also see it double-appended — confirm the base-view branch (`renderSymbolic(ast)}${suffix}`) is unchanged (suffix still appended there the old way) while the new plug-in branch routes suffix through `formatRange` instead. This is intentional asymmetry (base view's suffix placement was never in brackets to begin with, nothing to change there).

- [ ] **Step 3: Rewrite the `dmg` case inside `substituteInlineChips` for the full mitigation pipeline**

Read the current `substituteInlineChips` function in full (search for `function substituteInlineChips`). Its `dmg` case currently calls `chipHTML("dmg","",r.dmg,view,stats)` directly, same as every other token. Replace ONLY the `dmg` case with a dedicated branch that adds the `dmgAdjust`/`defAdjust` pipeline in plug-in view:

```js
function substituteInlineChips(text, r, view, stats, enemyStats, revisedArtOn) {
  return text.replace(INLINE_CHIP_RE, (_, token) => {
    switch (token) {
      case "dmg": {
        if (!r.dmg) return "";
        if (view !== "plugin") {
          // Base view: unchanged from today — plain symbolic chip, no
          // mitigation pipeline shown (design spec: base view is untouched).
          return chipHTML("dmg","",r.dmg,view,stats);
        }
        const ast = parseFormula(r.dmg);
        // Attacker-side rolls move together: "min" attacker roll pairs with
        // "max" defender roll (defAdjust's own internal roll direction is
        // inverted below), and vice versa, per the design's sync/invert rule.
        const baseMin = renderRange(ast, stats, "min");
        const baseMax = renderRange(ast, stats, "max");
        const afterDmgMin = evalDmgAdjust(baseMin, stats.damageMod, stats.LCK, "min");
        const afterDmgMax = evalDmgAdjust(baseMax, stats.damageMod, stats.LCK, "max");
        // Defender roll direction is INVERTED relative to the attacker's:
        // true minimum damage pairs the attacker's worst roll with the
        // defender's BEST (max DEF) roll; true maximum pairs attacker's
        // best roll with defender's WORST (min DEF) roll.
        const finalMin = evalDefAdjust(afterDmgMin, enemyStats.DEF, enemyStats.LCK, "max");
        const finalMax = evalDefAdjust(afterDmgMax, enemyStats.DEF, enemyStats.LCK, "min");
        return `<span class="chip dmg"><b class="computed">${formatRange(finalMin, finalMax, "")}</b></span>`;
      }
      case "cd": return r.cd ? chipHTML("cd","CD",r.cd,view,stats,"s",revisedArtOn) : "";
      case "mp": return r.mp ? chipHTML("mp","MP",r.mp,view,stats) : "";
      case "sp": return r.sp ? chipHTML(r.sp<0?"spr":"spb","SP",Math.abs(r.sp),view,stats) : "";
      case "cast": return r.cast ? chipHTML("cast","CAST",r.cast,view,stats,"s") : `<span class="chip instant">INSTANT</span>`;
      case "range": return r.range === "locked" ? `<span class="chip rng"><span class="t">Range</span> <b>Locked-on</b></span>`
        : r.range === "inf" ? `<span class="chip rng"><span class="t">Range</span> <b>∞</b></span>`
        : r.range ? `<span class="chip rng"><span class="t">Range</span> <b>${r.range}</b></span>` : "";
      case "ko": return (r.ko !== undefined) ? `<span class="chip ko"><span class="t">KO</span> ${r.ko}</span>` : "";
      default: return "";
    }
  });
}
```

Note: `mp`/`sp`/`range`/`ko` cases are UNCHANGED from before this task (MP/SP are flat costs per Global Constraints, `range`/`ko` have no formula to range-ify) — only `dmg` and `cd` change in this step. `cast`/`dur`-style tokens get range treatment via `chipHTML` itself (Step 2's change), so their case bodies here don't need their own special-casing beyond passing through to `chipHTML` as before — confirm `cast`'s existing call already flows through the updated `chipHTML` correctly (it does, no change needed to the `case "cast":` line itself).

- [ ] **Step 4: Thread `enemyStats` and `revisedArtOn` through every call site**

Run the Step 1 grep again on the now-edited file and update every remaining call to `chipHTML(...)`/`substituteInlineChips(...)` inside `renderSkillCard` to pass the two new parameters. `renderSkillCard`'s own signature must gain them too — find `function renderSkillCard(famId, fam, rankIdx, view, stats)` and change to:

```js
function renderSkillCard(famId, fam, rankIdx, view, stats, enemyStats, revisedArtOn) {
```

Then update its internal calls, e.g.:
```js
const cdChip = r.cd ? chipHTML("cd","CD",r.cd,view,stats,"s",revisedArtOn) : "";
```
(mp/sp/cast chips pass `undefined` for the trailing params they don't use — JS allows this, no need to pass explicit `undefined` literals, just omit trailing args that aren't needed for non-cd/non-dmg chips)

And the notes-rendering line:
```js
<ul class="notes">${(r.notes||[]).map(n=>`<li>${substituteInlineChips(n,r,view,stats,enemyStats,revisedArtOn)}</li>`).join("")}</ul>
```

- [ ] **Step 5: Update every CALLER of `renderSkillCard`** (mountAllCards, rerenderAll, and the click-handler's direct calls if any)

Run: `grep -n "renderSkillCard(" "Mechanics-Infographics/12_Penguin_skill-sheet.html"`

For each call site found (expect `mountAllCards` and `rerenderAll`, both defined after `renderSkillCard`), add `enemyStats` and a `revisedArtOn` reference. Since `revisedArtOn` doesn't exist as a variable yet (Task 5 adds it), temporarily use a literal `false` at each call site in THIS task, e.g.:

```js
const card = renderSkillCard(famId, fam, currentRank[famId], currentView, stats, enemyStats, false);
```

Task 5 will replace these `false` literals with the real `revisedArtOn` variable reference once it exists — this task's job is only to get the parameter threading correct and functional with a safe default, not to implement the toggle itself.

- [ ] **Step 6: Verify in a real browser (or headless Chrome)**

Open the file. Confirm: base view renders exactly as before this task (byte-for-byte — spot check a few cards' symbolic text against a pre-Task-1 git revision to confirm zero base-view regression). Switch to plug-in view, enter Player Stats (e.g. ATK=200/INT=100/AGI=80/CHA=50/TAL=60/LCK=40/Player Level=60/DMG Mod=1) and Enemy Stats (DEF=30/CHA=20/LCK=15) — confirm a dmg chip (e.g. on `nAttack1`, from the earlier migration) now shows a `[min-max]` bracket, not a single number, and that entering different Enemy Stats values changes the range. Confirm a CD chip (e.g. on `manaMissile1`) also shows a range. Confirm MP/SP chips still show a single flat number (unranged). Zero console errors.

- [ ] **Step 7: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: wire range rendering + dmg mitigation pipeline into chip rendering"
```

---

## Task 4: Migrate manaMissile's dmg field to the {{dmg}} inline convention (first real dmg-range card)

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — `SKILLS.manaMissile` data

**Interfaces:**
- Consumes: Task 3's dmg-chip range pipeline.
- Produces: no new interfaces — this is a data-only migration proving the mechanism end-to-end on a real multi-rank card, following the same `{{dmg}}` pattern already established on `nAttack1`/`nAttack2`.

manaMissile currently has its `dmg` field set but NOT yet referenced via `{{dmg}}` in its notes (confirmed during the original inline-chip mechanism work — it was left as a "not yet migrated" card, showing no damage number at all in its notes). This task is the first real multi-rank, formula-heavy card to go through the new range pipeline, serving as this plan's primary end-to-end verification.

- [ ] **Step 1: Read the current `SKILLS.manaMissile` data**

Run: `grep -n "manaMissile:" "Mechanics-Infographics/12_Penguin_skill-sheet.html"` and read the full family block (4 ranks) that follows.

- [ ] **Step 2: Add a `{{dmg}}`-referencing notes bullet to each of the 4 ranks**

For each rank, add a notes bullet describing the missile damage using `{{dmg}}`, e.g. for rank 1 (adjust exact missile-count wording to match whatever the current notes already say about missile count — do not invent a different count than what's already documented):

```js
"Each missile deals {{dmg}} damage."
```

Add this as a NEW bullet in the existing `notes` array (don't replace existing bullets about missile count/mechanics — this task only adds the damage-number bullet, consistent with how `nAttack` kept its projectile-description bullet and added dmg inline within it, though for manaMissile a separate dedicated bullet is fine too since its existing notes structure differs from nAttack's single-sentence style — use judgment matching the existing prose style on this specific card, the point is `{{dmg}}` appears somewwhere sensible, not a specific sentence template).

Also add the SAME bullet (or an equivalently adapted one) to each rank's `classC.notes` override array (the `moreMissile5` toggle's notes), so the damage number stays visible and correctly reflects the boosted `dmg` formula when that Class C toggle is ON too — check the existing `classC` override's `dmg` field (already present, e.g. `"talAdjust(15) + 0.1×Lv"`) renders correctly through `{{dmg}}` in that override's own notes array as well.

- [ ] **Step 3: Verify in a real browser (or headless Chrome)**

Confirm base view: manaMissile's 4 ranks show a plain symbolic dmg formula inline in notes (no brackets, no LCK mention). Confirm plug-in view with stats entered: each rank shows a `[min-max]` range. Confirm rank-toggling still works (switch between ranks 1-4, range updates each time). Confirm toggling the `moreMissile5` classC checkbox ON changes the range to reflect the boosted formula. Confirm toggling revisedArt-independent chips (CD) also range-display correctly on this card (manaMissile has a `cd` field).

- [ ] **Step 4: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "content: migrate manaMissile dmg field to {{dmg}} inline convention"
```

---

## Task 5: Add the global revisedArt toggle (control bar icon, grayscale/color, wired to CD ranges)

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — control bar HTML (near the `.viewtoggle`/`.statgroup` markup added in Task 2)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — state block (add `revisedArtOn`)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — event delegation (add a click branch)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — `mountAllCards`/`rerenderAll` (replace the `false` literals from Task 3 Step 5 with the real `revisedArtOn` variable)
- Modify: CSS — new `.revisedarttoggle` rule with grayscale filter

**Interfaces:**
- Consumes: Task 3's `revisedArtOn` parameter threading (currently hardcoded `false` at both `renderSkillCard` call sites); the `revisedArt5` icon, already present in `ICONS` (confirm via `grep -n '"revisedArt5"' "Mechanics-Infographics/12_Penguin_skill-sheet.html"` — it was dumped in the original icon-extraction pass even though never used in `SKILLS` data).
- Produces: `let revisedArtOn = false;` (module-level state, boolean, NOT a per-family map — this is genuinely global). No new functions — this task only wires existing pieces together.

- [ ] **Step 1: Confirm the `revisedArt5` icon exists in `ICONS`**

Run: `grep -c '"revisedArt5"' "Mechanics-Infographics/12_Penguin_skill-sheet.html"`
Expected: `1` (one occurrence, the `ICONS` object's own key — if this returns `0`, STOP and report BLOCKED, since Task 1 of the original icon-extraction plan claimed all 96 icons including `revisedArt5` were dumped; a missing icon here would mean that claim needs re-verification before this task can proceed).

- [ ] **Step 2: Add the toggle control to the control bar HTML**

In the `.controlbar` div (added/modified in Task 2), add a new element after the `.viewtoggle` div and before the `.statgroup` divs:

```html
<button type="button" id="revisedArtToggle" class="revisedarttoggle" title="revisedArt5 (12% cooldown reduction)">
  <img src="{{icon:revisedArt5}}" alt="revisedArt5">
</button>
```

Wait — this file does NOT use `{{icon:name}}` placeholders (that convention belongs to the ORIGINAL template before per-class icon embedding; this shipped file already has real base64 data URIs baked into its `ICONS` object, per the main plan's Task 2). Use JS to set the `src` at render time instead, matching how every other icon in this file is inserted (via `ICONS[name]` string interpolation in a template literal), NOT a static `<img src="{{icon:...}}">` in the raw HTML. Correct approach: leave the button empty in the static HTML and populate its icon via JS at startup:

```html
<button type="button" id="revisedArtToggle" class="revisedarttoggle" title="revisedArt5 (12% cooldown reduction)"></button>
```

Then in the `<script>` block, after the `ICONS`/`SKILLS` declarations (anywhere before `mountAllCards()` is called), add:

```js
document.getElementById("revisedArtToggle").innerHTML = `<img src="${ICONS["revisedArt5"]}" alt="revisedArt5">`;
```

- [ ] **Step 3: Add CSS for grayscale (off) / full-color (on) states**

Add near the other control-bar CSS rules (e.g. after `.viewtoggle button.active`):

```css
  .revisedarttoggle{
    border:1px solid var(--acc);border-radius:4px;background:var(--paper);
    padding:2px;cursor:pointer;line-height:0;
  }
  .revisedarttoggle img{width:28px;height:28px;display:block;filter:grayscale(100%);opacity:.5;}
  .revisedarttoggle.on img{filter:none;opacity:1;}
  .revisedarttoggle.on{border-color:#9A7B0A;}
```

(Reuses the same dark-gold accent, `#9A7B0A`, already established for the `.classctoggle.on` state elsewhere in this file, for visual consistency between "this passive/toggle is active" states sheet-wide.)

- [ ] **Step 4: Add the `revisedArtOn` state variable**

Near the existing `let currentView = "base";` declaration, add:

```js
let revisedArtOn = false;
```

- [ ] **Step 5: Wire the click handler**

Find the existing delegated `document.addEventListener("click", e => {...})` block (it currently has branches for `.ranktoggle button`, `.classctoggle`, `#viewToggle button`). Add a new branch:

```js
const ra = e.target.closest("#revisedArtToggle");
if (ra) {
  revisedArtOn = !revisedArtOn;
  document.getElementById("revisedArtToggle").classList.toggle("on", revisedArtOn);
  rerenderAll();
  return;
}
```

Add this branch in the same position/style as the existing `.classctoggle` branch (early in the handler, each branch ending with `return` after handling its case, matching the existing early-return pattern for click-target-specific branches).

- [ ] **Step 6: Replace the Task 3 `false` literals with the real `revisedArtOn` variable**

Find both call sites updated in Task 3 Step 5 (inside `mountAllCards` and `rerenderAll`) — change:

```js
const card = renderSkillCard(famId, fam, currentRank[famId], currentView, stats, enemyStats, false);
```
to:
```js
const card = renderSkillCard(famId, fam, currentRank[famId], currentView, stats, enemyStats, revisedArtOn);
```

(and the equivalent line inside `rerenderAll`, which has its own near-identical call to `renderSkillCard`).

- [ ] **Step 7: Verify in a real browser (or headless Chrome)**

Confirm: the revisedArt icon renders in the control bar, grayscale by default. Click it — confirm it switches to full color, and every visible CD chip's range on the page shrinks (both endpoints reduced by the `ceil(0.88×x)` factor — spot check one CD chip's numeric values before/after the click by hand: e.g. if a CD range was `[8.5-9.2]s` before, confirm it becomes `[ceil(0.88×8.5)-ceil(0.88×9.2)]s = [8-9]s` after — actual displayed values depend on `formatNumber`'s rounding, verify the exact displayed string matches a hand-computed expectation, not just "it changed"). Click again — confirm it reverts to grayscale and the original (unreduced) CD ranges. Confirm base view is completely unaffected by the toggle (no visual change when clicking it in base view — the toggle still flips state and its own icon still changes color, but no chip text changes until switching to plug-in view). Zero console errors.

- [ ] **Step 8: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: add global revisedArt5 toggle (grayscale/color icon, applies to CD ranges)"
```

---

## Self-Review Notes

- **Spec coverage**: range-capable evaluator core (Task 1), Enemy Stats + DMG Mod + Player Level relabel + persistence (Task 2), chip-rendering integration including the dmg mitigation pipeline (Task 3), a real end-to-end data migration proving the mechanism (Task 4), and the global revisedArt toggle applied to CD ranges (Task 5) — all design-doc sections covered. `atkAdjust` and MP/SP-range non-goals are respected (never implemented/referenced in any task). Base-view-untouched constraint is explicitly verified in Task 3 Step 6 and Task 5 Step 7.
- **Placeholder scan**: no TBD/TODO. Task 1's dead-code note (`evalAdjuster` stub) is explicitly called out as "write this to show reasoning, then DELETE it" rather than left ambiguous — the final file must not contain it.
- **Type consistency**: `renderRange(ast, stats, rollMode)` signature is established in Task 1 and used identically in Tasks 3-4; `chipHTML`'s new trailing `revisedArtOn` parameter and `substituteInlineChips`'s new `enemyStats`/`revisedArtOn` parameters are introduced in Task 3 and threaded through consistently in Tasks 3 (with temporary `false`) and 5 (replaced with the real variable) — no signature drift between tasks.
- **Task 1/Task 3 sequencing risk**: explicitly flagged in Task 1's own final step that the live page will not render correctly in a browser between Task 1's commit and Task 3's completion (since `chipHTML`/`substituteInlineChips` still reference the deleted `renderNumeric` until Task 3 updates them) — this is called out so whoever executes Task 2 (which doesn't touch chip rendering) isn't alarmed by a broken page if they happen to open it in a browser between Task 1 and Task 3, and so Task 2's own browser verification step (Step 7) is understood to be checking control-bar/panel behavior only, not full chip rendering (which won't work yet at that point in the sequence — Task 2 doesn't depend on Task 1's chip changes, only Task 3 does, so Task 2 can safely run before OR after Task 1/3 in principle, but this plan sequences them 1→2→3→4→5 for narrative clarity; note this if reordering is ever considered).
