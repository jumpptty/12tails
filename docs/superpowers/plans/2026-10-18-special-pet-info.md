# Special Pet Info Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Add the "Special Pet Info" hub tool (layout A, Codex) to the Bible, showing the 40 pets with real effects, live for pet level 1–9 and LCK.

**Architecture:** Everything lives in `12t_projects/bible/index.html`: a `PET_INFO` data table, pure render functions that return HTML strings (so the validator can call them in its stub-DOM sandbox), and a thin `mountPetInfo(root)` that sets `innerHTML` and wires one delegated click / change handler. `scripts/validate_skills.js` gets a `[PET INFO ERROR]` section that checks data against values transcribed from the reference and renders every pet.

**Tech Stack:** plain JS / CSS in the single-file hub; Node `vm` sandbox validator.

**Spec:** `docs/superpowers/specs/2026-10-18-special-pet-info-design.md` (facts: `12t_reference/12Tails-Mechanics-Reference.md` §4.9)

## Global Constraints

- `index.html` is ~15 MB and CRLF: every change is a Node patch script in the session scratch dir that backs the file up (`index.<timestamp>.bak` in scratch), replaces an anchor that must match exactly once (CRLF in anchors and inserted text), writes, prints one line. No editor tools on `index.html`, never read or print base64.
- No `git checkout` / `restore` / `reset` / `stash` on `index.html`; no commit unless the user asks (the commit then needs the `CHANGELOG_DATA` entry with the exact subject first).
- Two fonts only: Prompt; numbers `'JetBrains Mono','Prompt',monospace`. Colours from tokens; dark only. Hover = small lift / brightness, never a gold glow. No reduced-motion gates.
- Player text: Thai house style of bible-desc-writing (วินาที, เลเวล, `**…**` numbers, `[status]`, `^^ดาเมจขาว^^` / `^^ดาเมจม่วง^^`, no code names except `rangeMod`, one space around tokens). White damage is **ดาเมจขาว**, never ดาเมจตรง.
- Every number comes from reference §4.9. The page derives nothing beyond the stated "ดาเมจต่อนาที (คำนวณ)".

## Review Focus

1. A deep link to a variant id (`#pet-info/p_sky`) or an unknown id: the first opens the kite family on the yellow kite; the second falls back to the remembered or first pet and rewrites the address to `#pet-info`.
2. LCK typed as blank, negative, text or above 512: chances use the page's `lckAdjustChance` (clamps 1–512); the box shows what was used; nothing renders `NaN`.
3. A pet whose level does nothing (Kumo, Karazo, Bigbug Balloon, PirateFish): no level pills that pretend to change numbers.
4. `localStorage` blocked or holding stale ids: the page still opens on a valid pet (try / catch, id validated).
5. Phone width (390 px): the roster becomes a horizontal strip and nothing overflows sideways.

Each line has a test in the task that owns it (Task 3: 1, 2, 3; Task 4: 4; Task 5: 5 by the overflow check).

---

### Task 1: `PET_INFO` data and its fixture check

**Files:**
- Modify: `12t_projects/bible/index.html` (insert after the `const GEAR_NICKNAMES = …;` statement)
- Test: `scripts/validate_skills.js` (new section after the `[MONSTER STATS ERROR]` block)

**Interfaces:**
- Produces: `PET_INFO` (array, roster order); entry fields `id`, `role` (`"atk" | "buff" | "react" | "res"`), `req` (0 = any level), `vars?` `[{ id, label, stat? }]`, `every?(N)`, `trigger?(N)`, `area?` `{ r(N), h: "rm3" | 4, at: "you" | "pet" | "kite" | "spot" | "sphere", maxT, search?, blast? }`, `hit?` `{ color: "white" | "purple", dmg(N, k), ko?(N), hits?, tick?, delay?, up? }`, `chance?(N, L)`, `value(N, L)` (main number as text), `desc(N, L)` (markup), `tip` `{ special(N), th }`, `code?` (markup; absent = tooltip matches), `flags` `{ ally?, selfStrip?, dead?, noLv?, lvUnused? }`, `status?`, `base?`.
- Produces: `petInfoFind(id) → { entry, vi } | null` (accepts variant ids), `petInfoCount() → 40`, `petInfoPerMin(entry, N, crowd) → integer`, `petInfoFires(entry, N) → number[]`, `petInfoWindow(entry, N) → seconds`.

- [ ] **Step 1: Write the failing check** in `validate_skills.js`:

```js
// [PET INFO ERROR] fixture: values transcribed from 12Tails-Mechanics-Reference.md §4.9
const P = vm.runInContext("PET_INFO", sandbox), find = vm.runInContext("petInfoFind", sandbox);
const perMin = vm.runInContext("petInfoPerMin", sandbox), count = vm.runInContext("petInfoCount", sandbox);
const pf = (m) => { console.error(`[PET INFO ERROR] ${m}`); errorCount++; };
const E = id => (find(id) || {}).entry || pf(`no entry ${id}`);
const roles = ["atk", "buff", "react", "res"].map(r => P.filter(p => p.role === r).length).join("/");
if (roles !== "10/8/3/14") pf(`group sizes ${roles}, expected 10/8/3/14`);
if (count() !== 40) pf(`count ${count()}, expected 40`);
const FIX = [ // [id, N, every, dmg k=1, radius, ko]
  ["p_lmc",1,6,35,1], ["p_lmc",9,6,67,5], ["p_lmn",9,3,47,5], ["p_lmo",1,9,9,4], ["p_lmo",9,9,33,12],
  ["p_msb",1,20,14,12], ["p_msb",9,12,30,12], ["p_mcb",9,12,56,8,2], ["p_mab",9,12,60,24,5],
  ["p_mrb",1,60,60,6], ["p_mrb",9,60,220,6], ["p_mmb",1,20,5,6,5], ["p_mmb",9,12,13,6,13],
  ["p_mgb",1,20,20,18,2], ["p_mgb",9,12,52,18,2], ["p_mnb",1,59,20,9], ["p_mnb",9,51,60,9],
];
for (const [id, N, ev, d, r, ko] of FIX) { const e = E(id); if (!e) continue;
  if (e.every(N) !== ev) pf(`${id} N${N} every ${e.every(N)} != ${ev}`);
  if (e.hit.dmg(N, 1) !== d) pf(`${id} N${N} dmg ${e.hit.dmg(N, 1)} != ${d}`);
  const rr = e.area.blast || e.area.r(N); if (rr !== r) pf(`${id} N${N} radius ${rr} != ${r}`);
  if (ko !== undefined && (e.hit.ko ? e.hit.ko(N) : 0) !== ko) pf(`${id} N${N} ko != ${ko}`); }
if (E("p_mgb").hit.dmg(9, 4) !== 64) pf("MiniGolden 4th target at N9 != 64");
if (perMin(E("p_mnb"), 9, 1) !== 282 || perMin(E("p_mgb"), 9, 5) !== 1160 || perMin(E("p_lmn"), 9, 1) !== 940) pf("per-minute values");
const CH = { 0: { res3: [4, 12], res5: [6, 14], anubi: [5, 13], karazo: 30, pirate: 4 }, 156: { res3: [9, 25], res5: [14, 29], anubi: [10, 26], karazo: 52, pirate: 9 } };
for (const L of [0, 156]) { const c = CH[L];
  [[1, 0], [9, 1]].forEach(([N, i]) => {
    if (E("p_lcr").chance(N, L) !== c.res3[i]) pf(`L. Carron N${N} L${L}`);
    if (E("p_ldk").chance(N, L) !== c.res5[i]) pf(`L. Dead Pumpkon N${N} L${L}`);
    if (E("p_sab").chance(N, L) !== c.anubi[i]) pf(`S. Anubi N${N} L${L}`); });
  if (E("p_skz").chance(1, L) !== c.karazo) pf(`S. Karazo L${L}`);
  if (E("p_spf").chance(9, L) !== c.pirate) pf(`S. PirateFish L${L}`); }
const B = (id, N, ev) => { const e = E(id); if (e && e.every(N) !== ev) pf(`${id} N${N} every != ${ev}`); };
B("p_lcs", 1, 30); B("p_lcs", 9, 14); B("p_skm", 1, 15); B("p_sfb", 9, 60); B("p_sim", 9, 45); B("p_sam", 9, 120); B("p_skr", 1, 43); B("p_skr", 9, 27); B("p_all1", 1, 60);
if (find("p_sky").entry.id !== "p_skr" || find("p_sky").vi !== 2) pf("variant id p_sky does not open the kite family on index 2");
if (E("p_lcp") && !E("p_lcp").flags.dead) pf("L. Carron (P) must be flagged dead");
const GI = vm.runInContext("GEAR_ICONS", sandbox);
for (const p of P) for (const id of (p.vars ? p.vars.map(v => v.id) : [p.id])) if (!GI[id]) pf(`no icon for ${id}`);
```

- [ ] **Step 2: Run it to see it fail**

Run: `node scripts/validate_skills.js`
Expected: FAIL (`PET_INFO is not defined` inside the section; wrap the section in `try { … } catch (e) { pf(e.message); }` so the rest of the validator still runs).

- [ ] **Step 3: Add `PET_INFO` and the five helpers** with a patch script. Roster order and contents as the spec's list; tooltip strings from `PetData.cs` / `PetData_th.cs`; `chance` via the page's `lckAdjustChance(c, L)` (Anubi adds 1; Savers `4 + 2N` and Kumo `30` have no LCK); `petInfoPerMin` = Σ over the first `min(maxT, crowd)` targets of `dmg(N, k) × (hits || 1)`, times `60 / every(N)`, rounded; `petInfoFires` = multiples of `every(N)` up to `petInfoWindow` = `max(60, every(N))`.

- [ ] **Step 4: Run the validator**

Run: `node scripts/validate_skills.js`
Expected: no `[PET INFO ERROR]`; the error count is what it was before the task.

### Task 2: `wash` and `float` status popups

**Files:**
- Modify: `12t_projects/bible/index.html` (`STATUS_CLASS_MAP`, `STATUS_DESC_MAP`)
- Test: `scripts/validate_skills.js` (pet section)

**Interfaces:**
- Produces: `STATUS_CLASS_MAP.wash = "Magical"`, `STATUS_CLASS_MAP.float = "Buff, Magical"`, `STATUS_DESC_MAP.wash`, `STATUS_DESC_MAP.float` (both `(sLv) => string` like `bless`).

- [ ] **Step 1: Failing check:** `for (const s of ["wash", "float"]) if (!vm.runInContext("STATUS_CLASS_MAP", sandbox)[s] || !vm.runInContext("STATUS_DESC_MAP", sandbox)[s]) pf(\`no status popup for ${s}\`);`
- [ ] **Step 2:** `node scripts/validate_skills.js` → FAIL `no status popup for wash`.
- [ ] **Step 3: Add the entries.** wash: removes every Physical Buff of level ≤ its level, list them via `[status]` tokens is not needed (name the kinds: ค่าพลังขึ้น, Berserker Rush, blend …). float: on apply removes heavy / groundLock / needlePrison / sticky / frost / lightBind; while on, resists those and maim of level ≤ 2 × its level. Sources in the spec.
- [ ] **Step 4:** validator → no `[PET INFO ERROR]`, no new `[BOLD SPACING ERROR]`.

### Task 3: Pure renderers

**Files:**
- Modify: `12t_projects/bible/index.html` (after `PET_INFO`)
- Test: `scripts/validate_skills.js` (pet section)

**Interfaces:**
- Consumes: Task 1 helpers; `renderRichText(str)`, `lckAdjustChance`, `GEAR_ICONS`, `GEAR_DATA`.
- Produces: `petInfoState(raw) → { sel, vi: {}, N, L }` (validates a stored or hash state: unknown id → first entry, N clamped 1–9, L clamped 0–999, non-numbers → defaults 9 / 156); `petInfoRosterHtml(st) → string`; `petInfoDetailHtml(st) → string`; `petInfoRangeSvg(entry, N) → string`; `petInfoTimelineHtml(entry, N, L) → string`.

- [ ] **Step 1: Failing checks:**

```js
const st = vm.runInContext("petInfoState", sandbox), det = vm.runInContext("petInfoDetailHtml", sandbox), ros = vm.runInContext("petInfoRosterHtml", sandbox);
for (const p of P) for (const N of [1, 5, 9]) for (const L of [0, 156, 999]) {
  const h = det({ sel: p.id, vi: {}, N, L });
  if (/NaN|undefined|\*\*|\^\^|\[[a-z]+\d*\]/.test(h)) pf(`${p.id} N${N} L${L} has raw tokens or NaN`);
  if (/ดาเมจตรง|\d\s*วิ(?!นาที)|lckAdjust|chaAdjust/.test(h)) pf(`${p.id} wording`);
  if ((p.flags.noLv || p.flags.lvUnused) && /data-pet-lv=/.test(h)) pf(`${p.id} shows level pills`); }
const s1 = st({ sel: "p_sky", N: "x", L: -5 }); if (s1.sel !== "p_skr" || s1.vi.p_skr !== 2 || s1.N !== 9 || s1.L !== 0) pf("petInfoState variant / clamp");
const s2 = st({ sel: "nope", N: 12, L: 4000 }); if (s2.sel !== P[0].id || s2.N !== 9 || s2.L !== 999) pf("petInfoState fallback");
if ((ros(st({})).match(/data-pet-sel=/g) || []).length !== P.length) pf("roster rows");
```

- [ ] **Step 2:** validator → FAIL (`petInfoState is not defined`).
- [ ] **Step 3: Implement** the renderers to the spec's "The page" sections 1–8 (hero, description, four tiles, range SVG, timeline, anti-status matrix, เกมบอก vs โค้ดจริง strip, footer facts). Class prefix `pi-`. Data attributes the mount relies on: `data-pet-sel`, `data-pet-var="<familyId>:<i>"`, `data-pet-lv`, `data-pet-lck` (the LCK input).
- [ ] **Step 4:** validator → clean pet section.

### Task 4: Mount, styles, tool entry, routing

**Files:**
- Modify: `12t_projects/bible/index.html` (CSS block, `THEME_SURFACES`, `TOOLS`, `showTool` class toggle `tool-pets`, `route()`, launcher `artSrc` / `thumbOf`)
- Test: `scripts/validate_skills.js` (pet section)

**Interfaces:**
- Consumes: Task 3 renderers.
- Produces: `mountPetInfo(root)`, `root._petInfo.openById(id) → boolean`, `TOOLS` entry `{ id: "pet-info", title: "Special Pet Info", shortTitle: "Special Pet Info", category: "Reference", fact: () => [petInfoCount(), "ตัว"], art: ["gear:p_mnb", "gear:p_mgb", "gear:p_sab", "gear:p_skr", "gear:p_sam"], mount(root){ mountPetInfo(root); } }` placed after `monster-stats`; storage key `12t-bible-pets`.

- [ ] **Step 1: Failing checks:** the `TOOLS` entry exists with that id, title, category and five `gear:` art keys that all resolve in `GEAR_ICONS`; mounting on a stub root with `localStorage.getItem` throwing does not throw and leaves `root._petInfo.openById` defined; `openById("p_sky")` returns `true`, `openById("nope")` returns `false`.
- [ ] **Step 2:** validator → FAIL.
- [ ] **Step 3: Implement.** Mount renders `<div class="pi">` with roster and detail; one click handler on the root for the four data attributes, one `change` handler for the LCK box; every change re-renders the detail (and the roster's selection) and saves `{ sel, vi, N, L }` in try / catch; selecting writes `#pet-info/<id>` with `history.replaceState`. `route()`: for `pet-info` with a second segment call `openById`, and on `false` replace the hash with `#pet-info`. CSS: the `.pi` grid (300 px roster + detail, wide stage via `html.tool-pets`), phone rules at ≤ 760 px (roster → sticky horizontal strip), panels added to `THEME_SURFACES` (`panel`: roster, hero, desc, tiles, boxes; `raised`: roster rows, variant buttons, level pills; `field`: the LCK input). Launcher: `artSrc` maps `gear:<id>` to `GEAR_ICONS[id]` and `thumbOf` treats it as an icon fan like `skill:`.
- [ ] **Step 4:** validator → clean; `[FONT ERROR]`, `[BOLD SPACING ERROR]` unchanged.

### Task 5: Docs and full verification

**Files:**
- Modify: `.claude/skills/bible-hub-tools/SKILL.md` (new "Special Pet Info" section)
- Verify: `node scripts/validate_skills.js --full`

- [ ] **Step 1:** Add the section: purpose, data source (reference §4.9), `PET_INFO` shape, renderers, storage key, deep link, `[PET INFO ERROR]`, the user decisions (layout A, ดาเมจขาว, family variant row).
- [ ] **Step 2:** One Playwright look (this is a new page layout, so the browser rule allows it): desktop 1920×1080 and phone 390×844 at `#pet-info/p_mnb` and `#pet-info/p_sky`; check no horizontal overflow (`document.documentElement.scrollWidth <= innerWidth`) and no console errors.
- [ ] **Step 3:** `node scripts/validate_skills.js --full` → same result as before Task 1 plus a clean pet section.
- [ ] **Step 4:** Report to the user; propose the commit subject and leave committing to them.
