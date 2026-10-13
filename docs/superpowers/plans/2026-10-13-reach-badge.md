# Range Badge with 3D Hit Box Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Skill cards show a small reach badge that opens a rotatable 3D hit-box popup, driven by a structured `reach` field that replaces the reach sentence in each desc. Panda first.

**Architecture:** Pure functions in the Bible page script (`reachNormalize`, `reachBadgeText`, `reachMesh`, `reachProject`) are shared by the badge, the canvas popup and the validator (the validator already evaluates page functions through its sandbox, like `_getKOValue`). The badge sits in the hero header; the popup is a custom canvas renderer with no dependency. Card data goes in only through `scripts/card_edit.js`.

**Tech Stack:** Single-file HTML/JS/CSS (`12t_projects/bible/index.html`), Node validator (`scripts/validate_skills.js`), `scripts/card_edit.js`.

**Spec:** [docs/superpowers/specs/2026-10-13-reach-badge-design.md](../specs/2026-10-13-reach-badge-design.md)

## Global Constraints

- The hub stays one self-contained file: no Three.js, no CDN, no new files shipped with it.
- Never edit `index.html` with the Edit tool: card fields via `node scripts/card_edit.js` (`add-field`, `set-field`, `replace`) with `--dry-run` first; page-code edits via an out-of-process patch per `12t_projects/bible/CLAUDE.md` §1, with a scratch-dir backup before each. Never `git checkout/restore/reset/stash` on `index.html`.
- Scratch scripts live in the session scratchpad, never in `scripts/` or the repo.
- Every value comes from `DecompiledSource/` with a `file:line` in `src`; no guesses. A size that exists only in a prefab is `unknown:true`, never drawn.
- Every skill is reviewed one by one against the source (user decision 2026-10-13); the extraction script is a starting point, never applied in bulk.
- Commit that touches `index.html`: first prepend `CHANGELOG_DATA.entries` item `["<UTC ISO>", "<exact commit subject>"]` (newest first), then run `node scripts/validate_skills.js`. Commit messages end with `Co-Authored-By: Claude Sonnet 5.5 <noreply@anthropic.com>`.
- No browser checks except the single allowed check of the new popup (Task 3); everything else is verified with the validator and diffs.
- Thai UI text; the badge is small (like `.sk-ko-badge`), not a chip.

## Review Focus

- A card with several parts (blast plus splash): each part its own colour and legend entry; the badge shows the largest part.
- Rank-dependent size: the badge and popup follow the selected rank (function form).
- `unknown` card: badge shows `?`, popup says the size is only in the prefab, no shape drawn.
- Self skills (`shape:"self"`): plain badge `ตัวเอง`, popup shows only the player marker.
- Phone width (390 px): popup fits, touch drag rotates, no page scroll.

## File Structure

- Modify `12t_projects/bible/index.html`: reach functions (next to `getKOValue`), CSS (`.sk-reach-badge`, popup), hero-header markup, card `reach` fields and desc edits.
- Modify `scripts/validate_skills.js`: `[REACH ERROR]`, `[REACH DESC ERROR]`, `[REACH BACKLOG]`, golden geometry tests.
- Modify `.claude/skills/bible-desc-writing/SKILL.md`, `bible-card-fields/SKILL.md`, `bible-skill-page-ui/SKILL.md`.
- Modify `12t_reference/panda-skill-reference.md` where a reach note disagrees with the source.

---

### Task 1: Reach functions and schema validation

**Files:**
- Modify: `12t_projects/bible/index.html` (new block right after `getKOValue`)
- Modify: `scripts/validate_skills.js`

**Interfaces:**
- Produces (page globals):
  - `reachNormalize(reach, rank) -> Part[]` where `Part = {shape, r, h, w, l, angle, anchor, label, rangeMod, src, unknown}` with every function value resolved to a number (`h:"inf"` stays the string `"inf"`).
  - `reachBadgeText(parts) -> string` (`"r 5m"`, `"6×2×3"`, `"40m"`, `"ตัวเอง"`, `"?"`).
  - `reachMesh(part) -> {verts:[[x,y,z]], edges:[[i,j]], faces:[[i,j,k,...]]}`; units metres, +y up, +z the player's facing, anchor offset applied (`self` origin, `fist` 1 m ahead, `target` 6 m ahead for display only, `projectile` origin).
  - `reachProject(v, yaw, pitch, zoom, w, h) -> [px, py, depth]`.

- [ ] **Step 1: Find how the validator reaches page functions**

Run: `grep -n "_getKOValue" scripts/validate_skills.js 12t_projects/bible/index.html | head`
Expected: shows where `getKOValue` is exported to the sandbox (a `window._getKOValue = ...` style line). Add `reachNormalize`, `reachBadgeText`, `reachMesh`, `reachProject` to the same export in Step 4.

- [ ] **Step 2: Write the failing validator tests**

Add to `scripts/validate_skills.js` (before the final error summary), using `sandbox._reachNormalize` etc.:

```js
// ---- reach (spec 2026-10-13) ----
(function checkReach() {
  const REACH_SHAPES = ["sphere", "cylinder", "box", "cone", "line", "self"];
  const REACH_ANCHORS = ["self", "target", "fist", "projectile"];
  const dim = { sphere: ["r"], cylinder: ["r", "h"], box: ["w", "l", "h"], cone: ["r", "angle"], line: ["l"], self: [] };
  let backlog = 0;
  for (const sk of sandbox.SKILLS) {
    const maxRank = sk.maxRank || 1;
    if (!sk.reach) {
      if (/รัศมี \*\*|ทรงกลมรัศมี|กว้าง \*\*/.test(typeof sk.desc === "function" ? sk.desc(maxRank) : String(sk.desc || ""))) backlog++;
      continue;
    }
    for (let r = 1; r <= maxRank; r++) {
      let parts;
      try { parts = sandbox._reachNormalize(sk.reach, r); } catch (e) { console.error(`[REACH EXCEPTION] ${sk.id} rank ${r}: ${e.message}`); errorCount++; continue; }
      for (const p of parts) {
        const bad = (m) => { console.error(`[REACH ERROR] ${sk.id} rank ${r}: ${m}`); errorCount++; };
        if (!REACH_SHAPES.includes(p.shape)) { bad(`unknown shape ${p.shape}`); continue; }
        if (p.anchor && !REACH_ANCHORS.includes(p.anchor)) bad(`unknown anchor ${p.anchor}`);
        if (!p.unknown && !p.src) bad("missing src");
        if (!p.unknown) for (const k of dim[p.shape]) {
          const v = p[k];
          if (!(v === "inf" && k === "h") && !(typeof v === "number" && v > 0)) bad(`${k} must be > 0, got ${v}`);
        }
      }
      const desc = typeof sk.desc === "function" ? sk.desc(r) : String(sk.desc || "");
      if (/รัศมี \*\*|ทรงกลมรัศมี|กว้าง \*\*/.test(desc)) { console.error(`[REACH DESC ERROR] ${sk.id} rank ${r}: desc still states a size`); errorCount++; }
    }
  }
  if (backlog) console.log(`[REACH BACKLOG] ${backlog} cards still state reach in desc`);
  // golden geometry
  const box = sandbox._reachMesh({ shape: "box", w: 2, l: 4, h: 1, anchor: "self" });
  const xs = box.verts.map(v => v[0]), zs = box.verts.map(v => v[2]), ys = box.verts.map(v => v[1]);
  const ext = (a) => +(Math.max(...a) - Math.min(...a)).toFixed(6);
  if (ext(xs) !== 2 || ext(zs) !== 4 || ext(ys) !== 1) { console.error(`[REACH GOLDEN ERROR] box extents ${ext(xs)}x${ext(zs)}x${ext(ys)}`); errorCount++; }
  const sph = sandbox._reachMesh({ shape: "sphere", r: 3, anchor: "self" });
  if (Math.abs(Math.max(...sph.verts.map(v => Math.hypot(v[0], v[1], v[2]))) - 3) > 1e-6) { console.error("[REACH GOLDEN ERROR] sphere radius"); errorCount++; }
  if (sandbox._reachBadgeText([{ shape: "sphere", r: 5 }]) !== "r 5m") { console.error("[REACH GOLDEN ERROR] badge text sphere"); errorCount++; }
  if (sandbox._reachBadgeText([{ shape: "box", w: 6, l: 2, h: 3 }]) !== "6×2×3") { console.error("[REACH GOLDEN ERROR] badge text box"); errorCount++; }
})();
```

- [ ] **Step 3: Run it to verify it fails**

Run: `node scripts/validate_skills.js`
Expected: FAIL with `TypeError: sandbox._reachMesh is not a function` (functions not yet defined).

- [ ] **Step 4: Implement the functions in `index.html` and export them**

Patch out of process (scratch script, backup first) to insert after `getKOValue`:

```js
// ---- reach (spec 2026-10-13): structured hit-box data for the range badge ----
function reachNormalize(reach, rank){
  const parts = Array.isArray(reach) ? reach : [reach];
  return parts.map(p => {
    const o = Object.assign({}, p);
    for (const k of ["r", "h", "w", "l", "angle"]) if (typeof o[k] === "function") o[k] = o[k](rank);
    return o;
  });
}
function reachBadgeText(parts){
  if (!parts.length) return "";
  if (parts.some(p => p.unknown)) return "?";
  const p = parts.slice().sort((a, b) => reachSize(b) - reachSize(a))[0];
  if (p.shape === "self") return "ตัวเอง";
  if (p.shape === "sphere" || p.shape === "cylinder") return `r ${p.r}m`;
  if (p.shape === "box") return `${p.w}×${p.l}×${p.h}`;
  if (p.shape === "cone") return `${p.r}m ${p.angle}°`;
  return `${p.l}m`;
}
function reachSize(p){ return Math.max(p.r || 0, p.l || 0, p.w || 0, typeof p.h === "number" ? p.h : 0); }
function reachMesh(p){
  const off = p.anchor === "fist" ? [0, 1, 1] : p.anchor === "target" ? [0, 0, 6] : [0, 0, 0];
  const verts = [], edges = [], faces = [];
  const add = (x, y, z) => verts.push([x + off[0], y + off[1], z + off[2]]) - 1;
  if (p.shape === "box"){
    const hw = p.w / 2, hh = typeof p.h === "number" ? p.h : 6;
    for (const y of [0, hh]) for (const [x, z] of [[-hw, 0], [hw, 0], [hw, p.l], [-hw, p.l]]) add(x, y, z);
    for (let i = 0; i < 4; i++){ edges.push([i, (i + 1) % 4], [4 + i, 4 + (i + 1) % 4], [i, 4 + i]); }
    faces.push([0, 1, 2, 3], [4, 5, 6, 7], [0, 1, 5, 4], [1, 2, 6, 5], [2, 3, 7, 6], [3, 0, 4, 7]);
  } else if (p.shape === "sphere" || p.shape === "cylinder" || p.shape === "cone"){
    const N = 24, rings = p.shape === "sphere" ? 9 : 2;
    const hh = p.shape === "cylinder" ? (typeof p.h === "number" ? p.h : 6) : p.shape === "cone" ? p.r : 0;
    for (let j = 0; j < rings; j++){
      const t = p.shape === "sphere" ? -Math.PI / 2 + Math.PI * j / (rings - 1) : j / (rings - 1);
      const y = p.shape === "sphere" ? p.r * Math.sin(t) : t * hh;
      let rad = p.shape === "sphere" ? p.r * Math.cos(t) : p.r;
      if (p.shape === "cone") rad = p.r * t * Math.tan((p.angle / 2) * Math.PI / 180);
      for (let i = 0; i < N; i++){ const a = 2 * Math.PI * i / N; add(rad * Math.cos(a), y, rad * Math.sin(a)); }
      for (let i = 0; i < N; i++) edges.push([j * N + i, j * N + (i + 1) % N]);
      if (j) for (let i = 0; i < N; i += 4) edges.push([(j - 1) * N + i, j * N + i]);
    }
  } else if (p.shape === "line"){
    add(0, 0.5, 0); add(0, 0.5, p.l); edges.push([0, 1]);
  }
  return { verts, edges, faces };
}
function reachProject(v, yaw, pitch, zoom, w, h){
  const cy = Math.cos(yaw), sy = Math.sin(yaw), cp = Math.cos(pitch), sp = Math.sin(pitch);
  const x1 = v[0] * cy + v[2] * sy, z1 = -v[0] * sy + v[2] * cy;
  const y2 = v[1] * cp - z1 * sp, z2 = v[1] * sp + z1 * cp;
  return [w / 2 + x1 * zoom, h * 0.65 - y2 * zoom, z2];
}
```

Then add the four functions to the same sandbox export used by `_getKOValue` (as `_reachNormalize`, `_reachBadgeText`, `_reachMesh`, `_reachProject`).

- [ ] **Step 5: Run the validator to verify it passes**

Run: `node scripts/validate_skills.js`
Expected: PASS for reach goldens; `[REACH BACKLOG] N cards...` printed (not an error).

- [ ] **Step 6: Commit**

Prepend the changelog entry (`feat(bible): reach schema, geometry functions and validator checks for the range badge`), run the validator, then:

```bash
git add 12t_projects/bible/index.html scripts/validate_skills.js docs/superpowers/specs/2026-10-13-reach-badge-design.md docs/superpowers/plans/2026-10-13-reach-badge.md
git commit -m "feat(bible): reach schema, geometry functions and validator checks for the range badge"
```

---

### Task 2: Badge in the hero header

**Files:**
- Modify: `12t_projects/bible/index.html` (CSS near `.sk-ko-badge` rule ~line 4688; hero-head markup in `renderHeroNow`, find with `grep -n "sk-hero-title" index.html`)

**Interfaces:**
- Consumes: `reachNormalize`, `reachBadgeText` (Task 1).
- Produces: `<button class="sk-reach-badge" data-role="reach-badge">` in `.sk-hero-title`, and a global `openReachPopup(skill, rank)` that Task 3 defines (stub for now: `function openReachPopup(){}`).

- [ ] **Step 1: Write the failing check**

Add to the validator a markup check that renders nothing (static): assert `index.html` contains `class="sk-reach-badge"` and `.sk-reach-badge{`:

```js
for (const needle of ['sk-reach-badge', 'data-role="reach-badge"']) {
  if (!html.includes(needle)) { console.error(`[REACH UI ERROR] missing ${needle}`); errorCount++; }
}
```

Run `node scripts/validate_skills.js` → FAIL `[REACH UI ERROR]`.

- [ ] **Step 2: Add the CSS**

```css
.sk-reach-badge{display:inline-flex; align-items:center; gap:3.75px; padding:1.25px 5px; border-radius:2.5px; background:var(--gold-soft); border:1px solid var(--gold); font:inherit; font-size:11.25px; font-weight:700; color:var(--gold); font-family:ui-monospace,monospace; cursor:pointer; flex:0 0 auto}
.sk-reach-badge:hover{box-shadow:0 0 8px var(--gold)}
.sk-reach-badge svg{width:11px; height:11px; fill:none; stroke:currentColor; stroke-width:1.5}
```

- [ ] **Step 3: Render it in the hero header**

In the hero title block, after the skill name, when `activeSelected.reach`:

```js
const reachParts = activeSelected.reach ? reachNormalize(activeSelected.reach, rank) : [];
const reachBadge = reachParts.length ? `<button type="button" class="sk-reach-badge" data-role="reach-badge" title="ระยะโจมตี (ดูรูปทรง 3 มิติ)"><svg viewBox="0 0 16 16"><path d="M8 1 14 4.5v7L8 15 2 11.5v-7z"/><path d="M2 4.5 8 8l6-3.5M8 8v7"/></svg><span>${reachBadgeText(reachParts)}</span></button>` : "";
```

Wire the click once in the hero's existing delegated handler: `if (e.target.closest('[data-role="reach-badge"]')) openReachPopup(activeSelected, rank);`. Add `.sk-reach-badge` to the same `.remove()` / `DELTA_GROUPS` lists as `.sk-ko-badge` (lines ~19290-19297) so the badge animates on change and is skipped when the card is copied as text.

- [ ] **Step 4: Run the validator**

Run: `node scripts/validate_skills.js`
Expected: PASS.

- [ ] **Step 5: Commit** with changelog `feat(bible): range badge in the skill card header`.

---

### Task 3: Popup with the 3D canvas

**Files:**
- Modify: `12t_projects/bible/index.html` (CSS, `openReachPopup`, `drawReach`)

**Interfaces:**
- Consumes: `reachNormalize`, `reachMesh`, `reachProject`.
- Produces: `openReachPopup(skill, rank)` and `closeReachPopup()`.

- [ ] **Step 1: Write the failing check** (validator): the page must define `openReachPopup` and a `.sk-reach-pop` rule.

- [ ] **Step 2: Implement the popup**

Behaviour (all in `index.html`, one function block):
- Overlay `.sk-reach-pop` (fixed, centred, dark panel, `max-width:min(92vw,520px)`), a 4:3 `<canvas>` sized by `devicePixelRatio`, a legend row, a close button, Esc and outside-click close.
- State `{yaw:-0.6, pitch:0.5, zoom:28}`; `pointerdown/move/up` on the canvas rotates (yaw += dx*0.01, pitch clamped 0.1..1.4), `wheel` and two-finger pinch change `zoom` (clamped 8..80), `dblclick` resets.
- `drawReach(ctx, parts, state)`: clear; 1 m grid (21×21 lines, y=0) through `reachProject`; player capsule (a 0.5 m radius, 1.8 m tall wireframe) at the origin; each part's `faces` filled `rgba(color,0.15)` sorted back-to-front by mean depth, `edges` stroked; a label per dimension (`r 5m`, `h 3m`, `กว้าง 2m`, `ยาว 6m`, `มุม 90°`), `rangeMod` noted in the legend as `× rangeMod`. Part colours cycle through `--stat-tal`, `--gold`, `--stat-hp` read with `getComputedStyle`.
- `unknown` parts draw no shape; the legend line says `ขนาดอยู่ใน prefab ยังไม่มีค่าที่ยืนยันได้`.
- No auto-spin (respects reduced motion by default).

- [ ] **Step 3: Run the validator** → PASS.

- [ ] **Step 4: One browser check (allowed: new UI component)**

Open a card that has a `reach` (after Task 5's first cards, or temporarily add one in the scratch copy): rotate, zoom, close; multi-part; `unknown`; 390 px width. Report what was seen.

- [ ] **Step 5: Commit** with changelog `feat(bible): range popup draws the hit box in 3D`.

---

### Task 4: Docs and rules

**Files:**
- Modify: `.claude/skills/bible-desc-writing/SKILL.md` (replace the "Every `desc` states its reach" bullet with: reach lives in `reach`, the desc never states a size, a modifier line may still say that a skill *changes* a size in words only when the number is in `reach`)
- Modify: `.claude/skills/bible-card-fields/SKILL.md` (add `reach`: the part keys from the spec, anchor meanings, `unknown`, the 3D cylinder / sphere rules)
- Modify: `.claude/skills/bible-skill-page-ui/SKILL.md` (badge and popup)

- [ ] **Step 1:** Make the three edits.
- [ ] **Step 2:** Run `node scripts/validate_skills.js` → PASS.
- [ ] **Step 3: Commit** `docs(bible): reach moves from desc text to the reach field`. (No `index.html` change, so no changelog entry needed; if the validator's doc-only rule complains, amend the changelog entry in per the existing memory.)

---

### Task 5: Panda, one skill at a time

**Files:**
- Modify: `12t_projects/bible/index.html` (cards via `card_edit.js`)
- Modify: `12t_reference/panda-skill-reference.md` (only where a reach note disagrees with the source)

Panda cards: `panda_ashura panda_auraBlast panda_auraField panda_cAttack panda_climbingCliff panda_comboLink panda_comboPlus panda_crumblingMountain panda_crushingMonolith panda_deathBlow panda_delayQi panda_drunkenFist panda_drunkenPlus panda_drunkenSpin panda_focusedArt panda_focusedSpirit panda_fuujinKen panda_heavenBreath panda_heavenPalm panda_lotusPalm panda_mysticSage panda_nAttack panda_nineSteps panda_ogreImpact panda_pummel panda_qiBurst panda_qiStrike panda_raijinKen panda_rain&storm panda_resistance panda_risingDragons panda_risingVortex panda_roll panda_rollAround panda_rushingFalcon panda_sacredSageTechnique panda_safeGuard panda_shadowFist panda_spTransfer panda_spiritFist panda_stasisBlow panda_threeSteps panda_tigerPounce panda_tigerToss panda_timeAndTide panda_towerRush panda_waterCrane panda_waterMonkey panda_wind&cloud panda_windWalker`.

**Interfaces:** Consumes the `reach` schema from Task 1.

- [ ] **Step 1: Scratch proposal script** (scratchpad only): read the Panda cards from `index.html`, print for each: card id, the desc sentence(s) with `รัศมี / ระยะ / กว้าง / ยาว / สูง / องศา`, and a proposed `reach`. Output a table, no writes.

- [ ] **Step 2: Per-skill source review.** For each card, in the order above: read the `Panda.cs` cast site and any `Panda_<skill>.cs` companion, plus the `Geometry notes` in `panda-skill-reference.md`. Decide shape, every number, rank dependence, `rangeMod`, anchor, and the `src` citation. Follow the obfuscation rules (junk predicates, companion files). Note any disagreement with the existing desc.

- [ ] **Step 3: Review table for the user.** Present the full Panda table (card, proposed `reach` with `src`, the desc sentence to remove, disagreements found, passives with no reach). Wait for the user's corrections and approval before any write.

- [ ] **Step 4: Apply after approval, in one batch.** Back up `index.html` to the scratch dir; for each card:

```bash
node scripts/card_edit.js add-field <cardId> reach '<js-source>' --dry-run
node scripts/card_edit.js add-field <cardId> reach '<js-source>'
node scripts/card_edit.js replace <cardId> '<reach sentence>' ''
```

Run the dry-runs for the whole batch first and read all anchor errors together; fix, then apply once.

- [ ] **Step 5: Reference updates.** Where a verified reach differs from `panda-skill-reference.md` or `12Tails-Mechanics-Reference.md`, update the reference (class-specific vs global rule from AGENTS.md §4).

- [ ] **Step 6: Validate.** `node scripts/validate_skills.js` → no `[REACH ERROR]`, no `[REACH DESC ERROR]` for Panda, `[FIELD LOSS ERROR]` clear (the desc edit changes text, not fields).

- [ ] **Step 7: Commit** `feat(panda): reach badge data for every Panda skill, reach text moves out of the descs` (changelog entry first).

---

### Task 6: Hand-off for the other classes

- [ ] **Step 1:** Report the Panda results and anything in the schema that needed to change.
- [ ] **Step 2:** Ask the user which class is next; each class repeats Task 5 with its own review table.

---

## Self-Review

- **Spec coverage:** schema (Task 1), badge (2), popup (3), extraction pipeline and per-skill review (5), validator (1), docs (4), Panda pilot (5), roll-out (6). The `reach` clause removal from desc is in Task 5 step 4.
- **Placeholders:** none; the popup behaviour is specified in full but its code is written during the task because it is canvas drawing that depends on the live page's variables.
- **Type consistency:** `reachNormalize`, `reachBadgeText`, `reachMesh`, `reachProject` keep the same names and signatures in Tasks 1-3 and the validator (`_`-prefixed in the sandbox).
