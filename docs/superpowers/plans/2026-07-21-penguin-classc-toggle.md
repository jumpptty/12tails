# Penguin Class C Synergy Toggle Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Replace the 7 existing static "needs X" prose bullets in `Mechanics-Infographics/12_Penguin_skill-sheet.html` with a per-card, per-passive interactive toggle that live-recomputes chips/notes in both base and plug-in view, per `docs/superpowers/specs/2026-07-21-penguin-classc-toggle-design.md`.

**Architecture:** A new optional `classC` array on each rank object holds override sub-objects (`{passiveId, ...fieldOverrides}`). `renderSkillCard` merges any currently-ON override into the base rank before building chips/notes, so no chip-building code needs to know toggles exist. A new `classCToggle[famId][passiveId]` state map (default `false`) drives which overrides are active, flipped by a small per-card checkbox control matching the existing rank-toggle/view-toggle visual language. A 7th stat, Character Level (`Lv`), is added to the global stat panel and evaluator stat-token set.

**Tech Stack:** Same as the file it modifies — plain HTML/CSS/JS, no build step, no framework, self-contained (no external requests), no `eval`/`Function` constructor.

## Global Constraints

- No `eval()`/`Function()` constructor anywhere in the formula evaluator.
- The shipped HTML file must remain fully self-contained — no external stylesheet/script/font/image requests.
- Every override value must trace back to `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md` — no invented numbers. Exact source values for all 7 conversions are given in Task 3 below; do not re-derive from scratch.
- Each `classC` toggle is independent per card, even when two cards reference the same passive (e.g. `manaBurn` and `mpTransfer` both reference `manaSurge5` — their toggles do NOT sync). This was an explicit design decision, not an oversight — do not "fix" it.
- Toggle default state is OFF (`false`) for every entry on page load.
- `notes` overrides REPLACE the entire notes array when ON, they do not append to the base notes.
- Fields not named in an override object keep their base (OFF-state) value when merging.

---

## File Structure

Single file, as established by the main plan: `Mechanics-Infographics/12_Penguin_skill-sheet.html`. This plan only modifies it further — no new files, consistent with the file's self-contained-artifact requirement (a separate .js/.css file could not be fetched at runtime by a published Artifact).

---

## Task 1: Add Character Level to the global stat panel and evaluator

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:246-253` (stat panel HTML)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:687` (`stats` object)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` tokenizer regex and `renderNumeric`'s `case "stat"` (wherever the 6-stat token list is enumerated)

**Interfaces:**
- Consumes: existing `stats` object shape (currently `{ATK,INT,AGI,CHA,TAL,LCK}`), existing tokenizer stat-token regex group `(ATK|INT|AGI|CHA|TAL|LCK)`.
- Produces: `stats` object gains a 7th key `Lv`; formula strings can now use the bare token `Lv` (e.g. `"0.1×Lv"`) and it parses/evaluates like any other stat token.

- [ ] **Step 1: Add the Lv token to the tokenizer**

Find the tokenizer's stat-token regex group (currently `(ATK|INT|AGI|CHA|TAL|LCK)` inside `tokenizeFormula`'s main regex). Add `Lv` to the alternation:

```js
// before:
/\s*(?:(\d+\.?\d*)|(ATK|INT|AGI|CHA|TAL|LCK)|(agiAdjust|magAdjust|chaAdjust|talAdjust|lckAdjust|clamp)|([()+\-×*/⌈⌉⌊⌋,])\s*)/g
// after:
/\s*(?:(\d+\.?\d*)|(ATK|INT|AGI|CHA|TAL|LCK|Lv)|(agiAdjust|magAdjust|chaAdjust|talAdjust|lckAdjust|clamp)|([()+\-×*/⌈⌉⌊⌋,])\s*)/g
```

(Copy the exact current regex from the file first — the above is the pattern shape, not necessarily byte-identical to what's currently there after prior edits; find the real current regex and add `|Lv` to its stat-token alternation group specifically, in the same position as the other 6 names.)

- [ ] **Step 2: Add `Lv` to the global `stats` object**

```js
// before:
const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0 };
// after:
const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0, Lv:0 };
```

- [ ] **Step 3: Add the Lv input field to the stat panel HTML**

Find the `.statpanel` div (currently lines 246-253) and add a 7th `<label>` matching the exact pattern of the other 6:

```html
<div class="statpanel disabled" id="statPanel">
  <label>ATK<input type="number" id="stat-ATK" value="0" min="0"></label>
  <label>INT<input type="number" id="stat-INT" value="0" min="0"></label>
  <label>AGI<input type="number" id="stat-AGI" value="0" min="0"></label>
  <label>CHA<input type="number" id="stat-CHA" value="0" min="0"></label>
  <label>TAL<input type="number" id="stat-TAL" value="0" min="0"></label>
  <label>LCK<input type="number" id="stat-LCK" value="0" min="0"></label>
  <label>Lv<input type="number" id="stat-Lv" value="0" min="0"></label>
</div>
```

No JS wiring change needed for the input itself — the existing input-listener code (`document.querySelectorAll(".statpanel input").forEach(inp => {...})`, currently around line 735) already generically reads `inp.id.replace("stat-","")` as the stats-object key and writes `stats[key] = parseFloat(inp.value) || 0`, so it picks up the new `Lv` input automatically with zero changes to that block.

- [ ] **Step 4: Verify `renderNumeric`'s `case "stat"` needs no change**

`renderNumeric`'s stat case is `case "stat": return stats[ast.v] || 0;` — this is already generic over any key in `stats`, so `Lv` works automatically once Steps 1-2 are done. Confirm this by reading the current code; if it's NOT already generic (e.g. if a prior edit changed it to an explicit `ATK|INT|...` switch), adapt it back to the generic `stats[ast.v]` form.

- [ ] **Step 5: Verify in a real browser (or equivalent headless harness if unavailable)**

Open the file. Confirm: the stat panel now shows 7 inputs (ATK/INT/AGI/CHA/TAL/LCK/Lv) in plug-in view. Enter a value in the Lv field, confirm no console errors. Manually test the evaluator: in the browser console, run `renderNumeric(parseFormula("0.1×Lv"), {ATK:0,INT:0,AGI:0,CHA:0,TAL:0,LCK:0,Lv:50})` and confirm it returns `5`. Also confirm `parseFormula("0.1×Lv")` does NOT throw (this proves the tokenizer change worked — before this task, `Lv` would have been an unrecognized token and thrown "Bad formula token").

- [ ] **Step 6: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: add Character Level (Lv) as a 7th stat token and panel input"
```

---

## Task 2: Add `classC` override merging to `renderSkillCard`, toggle state, and toggle UI wiring

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:636-683` (`renderSkillCard`)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:685-687` (state block, add `classCToggle`)
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html:719-733` (event delegation)
- Modify: CSS (`<style>` block, add `.classctoggle` rules near the existing `.ranktoggle` rules, currently ~line 228-234)

**Interfaces:**
- Consumes: Task 1's `stats.Lv`; the existing `SKILLS[id].ranks[i]` schema (unchanged — `classC` is a new OPTIONAL key, absent on every rank that has no synergy).
- Produces:
  - `classCToggle: {[famId]: {[passiveId]: boolean}}` — module-level state, mirrors `currentRank`'s per-family map shape but keyed two levels deep.
  - `renderSkillCard(famId, fam, rankIdx, view, stats)` — SAME signature as before (no new parameters; the function reads `classCToggle` as a closure-captured module-level variable, exactly like it already reads `stats`/`currentRank` implicitly via `rerenderAll`'s call site — actually check: `stats`/`view` ARE passed as params already, `currentRank` is NOT passed as a param but read via the caller passing `rankIdx` directly. Follow that same pattern: `classCToggle` is read directly inside `renderSkillCard` via `classCToggle[famId]`, not passed as a new parameter, keeping the signature stable for any future caller).
  - A new CSS class `.classctoggle` (and `.classctoggle input`/`.classctoggle.on` or similar — implementer's call on exact sub-selectors, follow the existing `.ranktoggle button.active` pattern for how "on" state is visually indicated).

- [ ] **Step 1: Add `classCToggle` state alongside the other state variables**

```js
// before:
const currentRank = {};
let currentView = "base";
const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0, Lv:0 };
// after:
const currentRank = {};
let currentView = "base";
const stats = { ATK:0, INT:0, AGI:0, CHA:0, TAL:0, LCK:0, Lv:0 };
const classCToggle = {};
```

- [ ] **Step 2: Add override-merging logic at the top of `renderSkillCard`**

Immediately after the existing line `const r = fam.ranks[rankIdx];`, insert:

```js
function renderSkillCard(famId, fam, rankIdx, view, stats) {
  const baseRank = fam.ranks[rankIdx];
  // Merge any currently-ON classC overrides onto the base rank. Later
  // array entries win if two overrides somehow touch the same field
  // (doesn't occur in current data, but keeps the merge well-defined).
  const onToggles = classCToggle[famId] || {};
  const r = (baseRank.classC || [])
    .filter(entry => onToggles[entry.passiveId])
    .reduce((merged, entry) => ({ ...merged, ...entry }), { ...baseRank });
  // ... rest of function unchanged, using `r` exactly as before ...
```

Note: `{ ...entry }` spread would also copy `passiveId` onto `r`, which is harmless (it's just an unused extra key on the merged object — `renderSkillCard`'s existing code never reads `r.passiveId`), so no special-casing needed to strip it.

- [ ] **Step 3: Build the classC toggle control markup inside `renderSkillCard`**

After computing `r` (Step 2) and before/alongside the existing `rankButtons` construction, add:

```js
const classCToggles = (baseRank.classC || []).map(entry => {
  const isOn = !!onToggles[entry.passiveId];
  return `<label class="classctoggle${isOn ? " on" : ""}" data-fam="${famId}" data-passive="${entry.passiveId}">
    <input type="checkbox" ${isOn ? "checked" : ""}> ${entry.passiveId}
  </label>`;
}).join("");
```

Add `${classCToggles}` to the template literal inside `el.innerHTML`, placed right after `${rankButtons}` (before the `<h3>` title) so it reads as part of the card's control row, matching the design spec's "placed near the card's rank-toggle row" requirement:

```js
el.innerHTML = `
  <img class="ic" src="${iconSrc}" alt="">
  <div class="body">
    ${rankButtons}
    ${classCToggles}
    <h3>${r.id.replace("pgn_","")}</h3>
    ${chipsBlock}
    <ul class="notes">${(r.notes||[]).map(n=>`<li>${n}</li>`).join("")}</ul>
  </div>`;
```

- [ ] **Step 4: Add CSS for `.classctoggle`, matching the existing `.ranktoggle` visual language**

Find the existing `.ranktoggle` CSS block (currently lines 228-234):
```css
.ranktoggle{display:flex;gap:3px;margin:0 0 3px;}
.ranktoggle button{
  font-family:Consolas,monospace;font-size:9px;font-weight:700;
  width:18px;height:18px;line-height:1;border:1px solid var(--acc);border-radius:2px;
  background:var(--paper);color:var(--acc);cursor:pointer;padding:0;
}
.ranktoggle button.active{background:var(--acc);color:#fff;}
```

Add immediately after it:
```css
.classctoggle{
  display:inline-flex;align-items:center;gap:3px;margin:0 0 3px 6px;
  font-family:Consolas,monospace;font-size:8.5px;font-weight:700;
  padding:2px 6px;border:1px solid var(--acc);border-radius:2px;
  background:var(--paper);color:var(--acc);cursor:pointer;
}
.classctoggle input{margin:0;cursor:pointer;}
.classctoggle.on{background:var(--acc);color:#fff;}
```

- [ ] **Step 5: Wire the toggle's click handling into the existing delegated listener**

Find the existing `document.addEventListener("click", e => {...})` block (currently lines 719-733). Add a new branch, following the exact pattern of the existing `.ranktoggle button` branch:

```js
document.addEventListener("click", e => {
  const rb = e.target.closest(".ranktoggle button");
  if (rb) {
    currentRank[rb.closest(".ranktoggle").dataset.fam] = parseInt(rb.dataset.rank, 10);
    rerenderAll();
    return;
  }
  const cc = e.target.closest(".classctoggle");
  if (cc) {
    const famId = cc.dataset.fam, passiveId = cc.dataset.passive;
    classCToggle[famId] = classCToggle[famId] || {};
    classCToggle[famId][passiveId] = !classCToggle[famId][passiveId];
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
```

Note: clicking directly on the `<input type="checkbox">` inside `.classctoggle` would normally toggle the checkbox's own native `checked` state independently of this handler's logic; since `e.target.closest(".classctoggle")` matches whether the click landed on the `<label>` or the `<input>` inside it (labels wrapping inputs is standard HTML and native browser behavior already toggles the checkbox on label-click too), and `rerenderAll()` immediately replaces the whole card (including the checkbox element) with a freshly-built one reflecting the NEW state from `classCToggle`, any transient native-checkbox-toggle visual state is immediately overwritten by the correct re-render — this is safe, not a bug, but worth understanding when verifying (don't be confused if the checkbox briefly flickers before settling on the correct rendered state).

- [ ] **Step 6: Add a synthetic test entry and verify the full toggle cycle in a real browser (or headless harness)**

Temporarily add a minimal test `classC` entry to `SKILLS.manaMissile.ranks[0]` (rank 1) to verify the mechanism before Task 3 adds the real data:
```js
// TEMPORARY for this step's verification only — Task 3 replaces this with real data
classC: [{ passiveId: "testPassive", dmg: "999", notes: ["TEST OVERRIDE ACTIVE"] }]
```
Open the file, confirm: rank 1 of manaMissile now shows a `[ ] testPassive` toggle. Click it — confirm the DMG chip changes to `999` and the notes list changes to show only "TEST OVERRIDE ACTIVE" (replacing, not appending to, the base notes). Click it again — confirm it reverts to the original rank-1 dmg/notes. Confirm switching to plug-in view while the toggle is ON still shows `999` (a bare number formula, so both symbolic and numeric mode show `999` identically — this confirms the override participates in the existing `chipHTML` pipeline correctly, not a special-cased shortcut).

Remove the temporary `classC` entry once verified — it must not be present in the commit for this task.

- [ ] **Step 7: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: add classC override merging, toggle state, and toggle UI"
```

---

## Task 3: Convert the 7 existing synergy prose bullets to real `classC` entries

**Files:**
- Modify: `Mechanics-Infographics/12_Penguin_skill-sheet.html` — `SKILLS.nAttack`, `SKILLS.cAttack`, `SKILLS.manaMissile`, `SKILLS.manaArc`, `SKILLS.dispell`, `SKILLS.manaBurn`, `SKILLS.mpTransfer`, `SKILLS.fallingStars`, `SKILLS.fallingComets`

**Interfaces:**
- Consumes: Task 2's `classC` schema and merge logic; Task 1's `Lv` stat token.
- Produces: no new interfaces — this is pure data population using the schema Task 2 already built and verified.

Source values (already extracted, do not re-derive):
- `spreadShot5` → `nAttack`: 20%/40% proc chance for 3 spread projectiles; no clean chip override (proc-chance mechanic), notes-only.
- `manaField5` → `cAttack`: `+chargeLv` MP/tick, shares MP with allies in 8m; no clean chip override (the `mp` field is already a `clamp(...)` formula per-rank and the bonus is `+chargeLv` which varies by WHICH cAttack rank — not reducible to one override value valid at every rank without per-rank entries), notes-only.
- `moreMissile5` → `manaMissile`: +2 missiles, `+0.1×Lv` damage per missile. HAS a clean `dmg` override (add the `+0.1×Lv` term to each rank's existing collapsed `dmg` constant) and a notes override (updated missile count).
- `penguinOfArc5` → `manaArc`: `+0.5×Lv` damage, cosmetic VFX swap. HAS a clean `dmg` override.
- `parallelShift5` → `dispell`: dispell level +1. No chip to override (dispell's "level" isn't a rendered chip field — it's described in `notes` prose only), notes-only.
- `manaSurge5` → `manaBurn` AND `mpTransfer` (two separate cards, two separate `classC` entries, same `passiveId`, independently toggled per Global Constraints): manaBurn gets a notes-only override (status-level bump is prose, not a chip); mpTransfer's healing amount is ALSO prose (not a `dmg`/chip field — mpTransfer has no `dmg` chip at all, its heal amount lives in `notes`), so notes-only for both.
- `giantStar5` → `fallingStars` AND `fallingComets` (two separate cards, two separate `classC` entries): both have clean `dmg` overrides (×1.25 the existing collapsed dmg constant) plus notes-only changes for radius/target-cap (those live in `range`/`notes`, not a dedicated numeric chip).

- [ ] **Step 1: Convert `nAttack` (spreadShot5) — notes-only**

Find `SKILLS.nAttack`'s two ranks. Each currently has a `notes` bullet mentioning `spreadShot5` (per Design Correction 4, this should already be present on BOTH ranks, not just one — verify that's still true before proceeding). Add a `classC` entry to EACH rank:

```js
// rank 1 (pgn_nAttack1):
classC: [{ passiveId: "spreadShot5", notes: [
  "Unlocks normal-attack combo hit 2.",
  "All 3 combo stages share <b>one</b> damage formula: <b>0.5×ATK</b>, KO 1 — no per-stage bonus.",
  "<b>\"spreadShot5\" ON:</b> 20% (hits 1-2) / 40% (hit 3, LCK↑) chance to fire 3 spread projectiles instead of 1."
] }]
// rank 2 (pgn_nAttack2):
classC: [{ passiveId: "spreadShot5", notes: [
  "Unlocks normal-attack combo hit 3 (finisher).",
  "Same shared <b>0.5×ATK</b> formula as hits 1-2 — no damage bonus for reaching the 3rd hit.",
  "<b>\"spreadShot5\" ON:</b> 20% (hits 1-2) / 40% (hit 3, LCK↑) chance to fire 3 spread projectiles instead of 1."
] }]
```
(Read the CURRENT exact base-note text first — the above reproduces what should already be there per Correction 4, adjust to match whatever the actual current text is verbatim, only changing the synergy bullet's phrasing from a `<span class="syn">needs...</span>` conditional statement to a `<b>"X" ON:</b>` declarative statement matching the ON-state convention, since with a real toggle it's no longer a hypothetical "if you have X" — it's describing the actual current toggled state.)

- [ ] **Step 2: Convert `cAttack` (manaField5) — notes-only, per-rank**

`cAttack` has 4 ranks, each with a different base `mp` clamp formula. `manaField5`'s bonus (`+chargeLv` MP/tick, ally-sharing) applies at every rank but the exact "+chargeLv" numeric meaning differs per rank (chargeLv 1-4). Add per-rank `classC` entries with rank-correct notes (no `mp` override — the `+chargeLv` bonus isn't reducible to a single replacement formula for chargeLv without a per-rank formula, and the design's stated fallback for non-clean-chip cases is notes-only):

```js
// rank 1 (pgn_cAttack1):
classC: [{ passiveId: "manaField5", notes: [
  "Channel: 3% of ATK into <b>3~6 MP</b>/sec while holding.",
  "<b>No direct damage on release</b> — pure MP-channel utility.",
  "<b>\"manaField5\" ON:</b> +1 MP/tick (chargeLv 1), and shares MP with allies within 8m."
] }]
// rank 2:
classC: [{ passiveId: "manaField5", notes: [
  "Channel: 6% of ATK into <b>6~12 MP</b>/sec while holding.",
  "<b>\"manaField5\" ON:</b> +2 MP/tick (chargeLv 2), and shares MP with allies within 8m."
] }]
// rank 3:
classC: [{ passiveId: "manaField5", notes: [
  "Channel: 9% of ATK into <b>9~18 MP</b>/sec while holding.",
  "<b>\"manaField5\" ON:</b> +3 MP/tick (chargeLv 3), and shares MP with allies within 8m."
] }]
// rank 4:
classC: [{ passiveId: "manaField5", notes: [
  "Channel: 12% of ATK into <b>12~24 MP</b>/sec while holding (max rank).",
  "<b>\"manaField5\" ON:</b> +4 MP/tick (chargeLv 4), and shares MP with allies within 8m."
] }]
```
(Preserve any OTHER existing base notes on each rank not shown above — read the current file first, these examples show the manaField5-related bullet specifically; keep every other bullet on each rank unchanged, per Correction 4's "self-contained per rank" requirement, and note that Correction 4 previously already had this synergy on ranks 1-3 too — confirm your notes text is consistent with whatever Correction 4 already established rather than reverting it.)

- [ ] **Step 3: Convert `manaMissile` (moreMissile5) — has a `dmg` override**

`manaMissile` has 4 ranks with collapsed `dmg` constants (`talAdjust(15)`, `talAdjust(18)`, `talAdjust(21)`, `talAdjust(24)` per Correction 3/7). `moreMissile5` adds `+0.1×Lv` to each. Add:

```js
// rank 1 (pgn_manaMissile1), base dmg is talAdjust(15):
classC: [{ passiveId: "moreMissile5", dmg: "talAdjust(15) + 0.1×Lv", notes: [
  "<b>4 missiles</b> (2 base + 2 from \"moreMissile5\"), each hits independently."
] }]
// rank 2, base dmg talAdjust(18):
classC: [{ passiveId: "moreMissile5", dmg: "talAdjust(18) + 0.1×Lv", notes: [
  "<b>5 missiles</b> (3 base + 2 from \"moreMissile5\"), each hits independently."
] }]
// rank 3, base dmg talAdjust(21):
classC: [{ passiveId: "moreMissile5", dmg: "talAdjust(21) + 0.1×Lv", notes: [
  "<b>6 missiles</b> (4 base + 2 from \"moreMissile5\"), each hits independently."
] }]
// rank 4, base dmg talAdjust(24):
classC: [{ passiveId: "moreMissile5", dmg: "talAdjust(24) + 0.1×Lv", notes: [
  "<b>7 missiles</b> (5 base + 2 from \"moreMissile5\"), each hits independently."
] }]
```
Read the CURRENT exact `dmg` field value on each rank first (Correction 3/7 may have produced a slightly different exact string than the example above — use the REAL current value as the base you append `+ 0.1×Lv` to, don't retype it from this plan's memory of what it should be).

- [ ] **Step 4: Convert `manaArc` (penguinOfArc5) — has a `dmg` override**

4 ranks, base dmg `talAdjust(10)`/`talAdjust(20)`/`talAdjust(30)`/`talAdjust(40)` (read current exact values first, same caveat as Step 3):

```js
// rank 1:
classC: [{ passiveId: "penguinOfArc5", dmg: "talAdjust(10) + 0.5×Lv" }]
// rank 2:
classC: [{ passiveId: "penguinOfArc5", dmg: "talAdjust(20) + 0.5×Lv" }]
// rank 3:
classC: [{ passiveId: "penguinOfArc5", dmg: "talAdjust(30) + 0.5×Lv" }]
// rank 4:
classC: [{ passiveId: "penguinOfArc5", dmg: "talAdjust(40) + 0.5×Lv" }]
```
No `notes` override needed here since penguinOfArc5's only OTHER effect (cosmetic VFX swap) doesn't change any displayed fact worth restating — the base notes already mention the synergy per Correction 4; leave base notes as-is and only override `dmg`. (This demonstrates a `classC` entry doesn't have to override every field — only `dmg` changes here, `notes` stays at its base value automatically since it's not named in the override object.)

- [ ] **Step 5: Convert `dispell` (parallelShift5) — notes-only**

2 ranks. Per Design Correction 4's own work, rank 1 should already say `lv.2→lv.3` and rank 2 `lv.4→lv.5` (verify current exact text first):

```js
// rank 1:
classC: [{ passiveId: "parallelShift5", notes: [
  "Strips all lv.2 magical status from everyone in the AoE.",
  "<b>\"parallelShift5\" ON:</b> dispell level +1 (lv.2→lv.3).",
  "Also destroys mirageOrb/skyOrb items within 6m (undocumented)."
] }]
// rank 2:
classC: [{ passiveId: "parallelShift5", notes: [
  "Strips all lv.4 magical status from everyone in the AoE.",
  "<b>\"parallelShift5\" ON:</b> dispell level +1 (lv.4→lv.5).",
  "Also destroys mirageOrb/skyOrb items within 6m (undocumented)."
] }]
```

- [ ] **Step 6: Convert `manaBurn` (manaSurge5) — notes-only**

2 ranks:
```js
// rank 1:
classC: [{ passiveId: "manaSurge5", notes: [
  "Drains <b>25 MP</b> from target, deals damage = that % of their max MP now missing.",
  "<b>\"manaSurge5\" ON:</b> status level +2, and +0.1×your current MP to the drain amount."
] }]
// rank 2:
classC: [{ passiveId: "manaSurge5", notes: [
  "Drains <b>45 MP</b> from target, deals damage = that % of their max MP now missing.",
  "<b>\"manaSurge5\" ON:</b> status level +2, and +0.1×your current MP to the drain amount."
] }]
```

- [ ] **Step 7: Convert `mpTransfer` (manaSurge5) — notes-only, INDEPENDENT toggle from manaBurn's**

2 ranks. This is the SAME `passiveId` string as Step 6 but a SEPARATE card/entry — per Global Constraints, toggling this does NOT affect manaBurn's toggle state, and vice versa:
```js
// rank 1:
classC: [{ passiveId: "manaSurge5", notes: [
  "Heals target ally's MP: <b>30 + 0.1×your max MP</b>.",
  "<b>\"manaSurge5\" ON:</b> +0.5×character level bonus heal."
] }]
// rank 2:
classC: [{ passiveId: "manaSurge5", notes: [
  "Heals target ally's MP: <b>60 + 0.1×your max MP</b>.",
  "<b>\"manaSurge5\" ON:</b> +0.5×character level bonus heal."
] }]
```

- [ ] **Step 8: Convert `fallingStars` (giantStar5) — has a `dmg` override**

2 ranks, base dmg `talAdjust(30)`/`talAdjust(45)` (read current exact values first):
```js
// rank 1:
classC: [{ passiveId: "giantStar5", dmg: "talAdjust(30) × 1.25", notes: [
  "5 stars (target cap 10 with \"giantStar5\"), 2m-radius impact each (3m with \"giantStar5\").",
  "<b>\"giantStar5\" ON:</b> ×1.5 targeting radius, target cap 5→10, impact radius 2m→3m, ×1.25 damage."
] }]
// rank 2:
classC: [{ passiveId: "giantStar5", dmg: "talAdjust(45) × 1.25", notes: [
  "8 stars (target cap 10 with \"giantStar5\"), 2m-radius impact each (3m with \"giantStar5\").",
  "<b>\"giantStar5\" ON:</b> ×1.5 targeting radius, target cap 5→10, impact radius 2m→3m, ×1.25 damage."
] }]
```
Also override `range` to reflect the ×1.5 targeting radius (check the current base `range` string, e.g. `"12m radius, self-centered"` → override to `"18m radius, self-centered"` for rank 1 at ×1.5; compute the real ×1.5 value from whatever the current base radius actually is for each rank).

- [ ] **Step 9: Convert `fallingComets` (giantStar5) — has a `dmg` override**

2 ranks, base dmg `talAdjust(30)`/`talAdjust(45)` (same base values as fallingStars, confirm from current file):
```js
// rank 1:
classC: [{ passiveId: "giantStar5", dmg: "talAdjust(30) × 1.25", notes: [
  "5 comets scatter within ±10m of target (±8m base), 9m-radius impact each (6m base), linear falloff to 50% at edge.",
  "<b>\"giantStar5\" ON:</b> ±10m scatter, 9m impact radius, ×1.25 damage."
] }]
// rank 2:
classC: [{ passiveId: "giantStar5", dmg: "talAdjust(45) × 1.25", notes: [
  "8 comets scatter within ±10m of target (±8m base), 9m-radius impact each (6m base), linear falloff to 50% at edge.",
  "<b>\"giantStar5\" ON:</b> ±10m scatter, 9m impact radius, ×1.25 damage."
] }]
```

- [ ] **Step 10: Verify all 9 converted cards in a real browser (or headless harness)**

For each of the 9 cards (nAttack×2 ranks, cAttack×4 ranks, manaMissile×4, manaArc×4, dispell×2, manaBurn×2, mpTransfer×2, fallingStars×2, fallingComets×2 — 24 individual rank entries total across 9 families):
- Confirm a toggle checkbox appears, labeled with the correct `passiveId`.
- Toggle ON: confirm chips (where overridden) and notes update correctly; toggle OFF: confirm it reverts.
- For `manaMissile` and `manaArc` specifically, switch to plug-in view with `Lv` set to a nonzero value (e.g. 60) and confirm the `+0.1×Lv`/`+0.5×Lv` term is actually included in the computed damage number (e.g. manaMissile rank 1 ON at Lv=60: `talAdjust(15) + 0.1×60` symbolically, compute the numeric value by hand with some TAL value and confirm the chip matches).
- For `manaBurn` and `mpTransfer`, confirm toggling `manaSurge5` ON on ONE of the two cards does NOT turn it on on the other card (open both, toggle one, confirm the other's checkbox is still unchecked) — this is the explicit independent-toggle requirement, worth a dedicated check since it's easy to accidentally implement as shared state.
- Confirm base view still renders symbolic formulas correctly with the override active (e.g. manaMissile rank 1 ON in base view should show something like `"15 + 0.3×TAL + 0.1×Lv"` — the existing talAdjust pre-multiply logic (Correction 7) should still fire correctly even though the formula now has an extra `+0.1×Lv` term appended after the `talAdjust(...)` call; verify this actually renders legibly and not as broken/mismatched HTML).

- [ ] **Step 11: Commit**

```bash
git add "Mechanics-Infographics/12_Penguin_skill-sheet.html"
git commit -m "feat: convert 7 existing Class C synergy notes to interactive toggles"
```

---

## Self-Review Notes

- **Spec coverage**: Character Level stat token (Task 1), `classC` schema + merge + toggle UI (Task 2), all 7 named conversions from the design spec's table (Task 3, expanded to 9 cards since manaSurge5 and giantStar5 each touch 2 cards) — all covered.
- **Independent-toggle requirement**: explicitly re-verified in Task 3 Step 10 as its own dedicated check, since it's the one requirement most likely to be silently violated by an implementer who assumes "same passiveId" should mean "same state" (a natural but incorrect assumption given how `moreMissile5` etc. work as single-card entries) — flagging this prominently in the task's own verification steps rather than leaving it as only a Global Constraint statement.
- **Placeholder scan**: no TBD/TODO; Task 3's code blocks are marked "read the current exact value first" rather than inventing exact current strings, because Tasks 1-2 (schema/merge logic) will land before Task 3 and this plan cannot know the CURRENT byte-exact base `dmg`/`notes` strings after all of Tasks 5-8 and the 7 design corrections' edits — this is intentional, not a placeholder omission, since the underlying VALUES (which passive, which bonus, which numbers) are all fully specified from the data reference doc, only the exact base-string-to-append-to is deferred to "read the file," which is unavoidable for a plan targeting a file that keeps changing under prior tasks.
- **Type consistency**: `classCToggle[famId][passiveId]` shape is introduced in Task 2 and consumed identically in Task 3's verification steps; `renderSkillCard`'s signature is explicitly confirmed UNCHANGED across both tasks (no new parameter), matching how `currentRank` is already handled by closure rather than parameter-passing.
