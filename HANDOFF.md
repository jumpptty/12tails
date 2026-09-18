# HANDOFF: Per-class skill completion (stub cards + skill-ID reorder)

Written for: whichever agent (Codex or otherwise) picks up this task next. This
file is self-contained — you should not need the original conversation that
started this work, but `AGENTS.md` (repo root) is required background and its
rules (especially Section 4's "Per-Class `SKILLS` Ordering" entry, and Section
6's large-file handling rules for `index.html`) still apply on top of everything
below.

## What this task is

`12t_projects/bible/index.html` has a `SKILLS` array with one entry per learnable
skill, grouped by class. For most classes, only some of the class's real skills
(per the decompiled game source) have a card. This task:

1. Adds a bare icon-only stub card — `{ id, name, class, icon, maxRank }`, nothing
   else — for every skill that exists in the decompiled source but has no card yet.
2. Reorders each class's entire block (existing cards + new stubs) to match the
   game's own internal skill-ID order.
3. (Already done, applies globally, no further action needed) The Browse-by-Class
   roster view flags any card with `!skill.desc` with a red border — this is a
   structural check, not a manual flag, so new stubs are automatically caught.

**Do not add `desc`, `cd`, `cost`, `dmg`, or any other mechanical field to a new
stub.** That's separate, much heavier work (the full AGENTS.md Section 5
pipeline) done later, one skill at a time, with user review. This task is
scaffolding only.

## Progress so far

| Class | Status |
|---|---|
| Monkey | Already complete before this task started (0 missing) |
| Bat | Done (stubs + `compatSkills` wiring + reorder) — completed in an earlier, separate pass |
| Wolf | Done — reorder + 20 stubs |
| Bison | Done — reorder + 30 stubs |
| Cat | Done — reorder + 23 stubs |
| Chameleon | Done — reorder + 19 stubs |
| Mole | Done — reorder + 19 stubs |
| Panda | Done — reorder + 25 stubs |
| Penguin | Done — reorder + 18 stubs |
| Rabbit | Done — reorder + 20 stubs |
| **Sheep** | **Not started — this is the next class.** Research already done, see below. |
| Whale | Not started at all (not even researched) |

Current file state (after Rabbit): 559 skills, 1102 icons in `SKILL_ICONS`,
`node scripts/validate_skills.js` passes 100% clean. Nothing has been committed
to git this whole task — every step just edits `index.html` directly and leaves
the working tree dirty. Do not commit unless the user explicitly asks.

## The method (repeat exactly, per class)

### 1. Get the class's true skill-ID order

Grep `DecompiledSource/<Class>Skill.cs` for its `getSkillTree()` function:

```
result = "<prefix>_[a-zA-Z0-9&]+"
```

**Use a character class that includes `&`** — some skill names contain a literal
`&` (e.g. Panda's `pnd_wind&cloud1`, Rabbit's `rab_truceTrading&Co1`). A plain
`[a-zA-Z0-9]+` silently skips these lines entirely (no match, no error), which
under-counts the roster without any obvious sign something's wrong. This bit
me twice (Panda, and nearly Sheep/Rabbit) — always use the wider class.

The **internal prefix is not the full class name** for 11 of 12 classes. Known
mapping so far: Bat→`bat_`, Bison→`bsn_`, Cat→`cat_`, Chameleon→`chm_`,
Mole→`mol_`, Monkey→`mnk_`, Panda→`pnd_`, Penguin→`pgn_`, Rabbit→`rab_`,
Sheep→`shp_`, Wolf→`wlf_`. **Whale's prefix is not yet confirmed — check it
fresh**, don't guess (likely `whl_` by the established pattern, but verify).

The literal sequence of `result = "..."` lines **is** the ID order — you don't
need the actual numeric skill IDs, just the order they appear in the file. The
obfuscated `if (68549 - 287643 != -219094)` conditions wrapping each one are
junk predicates (see `AGENTS.md` Section 3) — ignore them, only the sequence of
assignments matters.

Collapse rank-suffixed variants (`shp_heal1`, `shp_heal2`, ...) to one family
per skill name in first-appearance order. **Exclude the 5 universal Common
skills** if present (`statPlus`, `superStatPlus`, `revisedSkill`, `revisedMagic`,
`revisedArt`) — these are authored once under the `class: "Common"` tile, not
per-class.

### 2. Get the class's already-authored card ids

```js
const re = /id:\s*"sheep_[a-zA-Z0-9_&]+"/g;  // wide char class here too
```

Run this as a small Node script against `index.html` (see Section 6 of
AGENTS.md — never grep/read raw ranges of this file broadly, it's >6MB with
~1100 embedded base64 icons; only ever pull short matches via `-o` grep or a
Node script that prints small results).

**Also independently sanity-check the total count**: `roster families − authored
cards' family-coverage = missing count`. If your missing-family list's length
doesn't match `total − authored`, something was miscounted — recheck before
proceeding. This caught real errors every single time it was done (Panda,
Sheep's merge accounting, etc).

**Watch for "merge" cards**: a single existing card can cover multiple tree
families. Confirmed cases so far:
- Chameleon: `chameleon_slayer` = `bugSlayer`+`tailSlayer`+`elementalSlayer`+`machineSlayer` (4→1). `chameleon_allSlayer` = the 4 `all*Slayer` variants (4→1).
- Rabbit: `rabbit_truceTrading` = the `truceTrading&Co` family (NOT `bunnyBargain` — that's a genuinely separate, still-missing family; an earlier automated survey conflated these two, wrongly).
- **Sheep: `sheep_seal` = `sealOfAttack`+`sealOfDefense`+`sealOfEarth`+`sealOfHeaven` (4→1).** Already confirmed correct via direct extraction — see the precomputed data below.
- Mole has a different wrinkle: summon skills (`barrelBot`, `kingKaiser`, `autoGyroGun`, `warFactory`) have **moveset child cards** with underscored ids (`mole_barrelBot_punch`, etc.) that are NOT separate tree families at all — they're sub-cards of one summon. Keep each summon's children immediately after their parent's slot in the target order; don't try to place them by ID (they have none of their own).

When reconciling, if a family looks "missing" but you can't find its icon or it
seems off, **double check the actual authored-id list with a script that
prints results, don't trust a mental tally** — every miscount so far was caught
this way, not by a supposedly-authoritative summary.

### 3. Determine `maxRank` per missing family

From the same `getSkillTree()` grep: count how many rank-suffixed variants
appear (`shp_karma1`...`shp_karma4` → maxRank 4). Single-rank "tier5 advanced"
skills use the literal suffix `5` in both the id and the icon key (not
`family1`) — e.g. `shp_homingLight5` → `maxRank: 1`, icon `sheep_homingLight5`.

**Don't infer `maxRank` from how many files exist in `RippedAssets`** — ripped
icon folders often have extra numbered variants (a `0` "locked/gray" icon, or
leftover unused higher-rank art) that don't correspond to the skill's real rank
count. `getSkillTree()` is the only source of truth for `maxRank`.

### 4. Check icon availability, embed missing ones

```
Glob: RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class-lowercase>/{fam1,fam2,...}*.png
```

Every missing family across all classes checked so far (Bison through Rabbit,
213+ families) had at least one real ripped PNG — no placeholder policy has
been needed yet. Watch for case drift in filenames (confirmed: Cat's
`powertwo2.png`/`backStab5.png`, Whale's likely `KnightOfTheDeep*.png` per an
earlier survey, Panda's `qistrike*.png`, Mole's `autoGyrogun1.png` typo,
Penguin's `intellect*.png` lowercase for the `Intellect` family whose id/icon
key is capitalized). The **SKILL_ICONS key always uses proper camelCase**
regardless of the disk filename's casing — only the file *read* path needs to
match disk exactly.

**Before embedding, check if the icon is already sitting unused in
`SKILL_ICONS`** — grep `"<class>_[a-zA-Z0-9]+":` across the whole file (again,
`-o` only, never dump content). Several classes had some/all of their missing
families' icons already embedded from earlier work (Rabbit: 100%, all 19 files
of its own missing-family icons pre-existed). **Search the WHOLE file for the
exact key before assuming it's absent** — Rabbit's `skillBargain5` was
accidentally re-embedded as a duplicate because an initial grep for the
authored cluster (~7100-7800 range) missed a legitimate copy sitting alone at
byte offset ~6.4M. If you find a duplicate after the fact, remove the one you
just added (keep the pre-existing one), then re-validate.

Verify every PNG's header magic bytes (`89 50 4E 47 0D 0A 1A 0A`) before
embedding — every embed script so far has asserted this per AGENTS.md's Zero
Placeholders / authentic-icon requirement.

### 5. Reorder + insert stubs — the script template

All 9 classes done so far used the same Node script pattern: a brace-depth
tokenizer that extracts each class's existing `SKILLS` objects verbatim (so
their content is never altered, only reordered), then reassembles them
interleaved with new bare stub objects in the target order.

**Critical fix already baked into the template below**: the tokenizer must
treat `//` as a line comment (skip to next `\n`) *before* checking for quotes.
Without this, an inline comment containing an English apostrophe (e.g. "TNT's
formula...", found inside `mole_tnt`'s card) gets misread as opening a
single-quoted string, and the tokenizer runs off the end of the file
unbalanced. This is caught safely (the script throws before writing anything)
but costs a debugging round trip — the fix is already in the template, don't
remove it.

```js
const fs = require("fs");

const resolvedFile = "c:/Users/Jump/Desktop/12tails/12t_projects/bible/index.html";
const html = fs.readFileSync(resolvedFile, "utf8");

function extractObjects(src, startIdx, endIdx) {
  const objects = [];
  let i = startIdx;
  let stack = [{ type: "code", braceDepth: 0, isInterp: false, objStart: -1 }];
  while (i < endIdx) {
    const top = stack[stack.length - 1];
    const ch = src[i];
    if (top.type === "code") {
      if (ch === "/" && src[i + 1] === "/") {
        const nl = src.indexOf("\n", i);
        i = nl === -1 ? endIdx : nl + 1;
        continue;
      }
      if (ch === '"') { stack.push({ type: "dquote" }); i++; continue; }
      if (ch === "'") { stack.push({ type: "squote" }); i++; continue; }
      if (ch === "`") { stack.push({ type: "template" }); i++; continue; }
      if (ch === "{") {
        if (top.braceDepth === 0 && !top.isInterp) top.objStart = i;
        top.braceDepth++;
        i++; continue;
      }
      if (ch === "}") {
        top.braceDepth--;
        i++;
        if (top.braceDepth === 0) {
          if (top.isInterp) { stack.pop(); }
          else if (top.objStart !== -1) {
            objects.push({ start: top.objStart, end: i, text: src.slice(top.objStart, i) });
            top.objStart = -1;
          }
        } else if (top.braceDepth < 0) {
          throw new Error("FAIL: unbalanced braces near index " + i);
        }
        continue;
      }
      i++; continue;
    }
    if (top.type === "dquote" || top.type === "squote") {
      const q = top.type === "dquote" ? '"' : "'";
      if (ch === "\\") { i += 2; continue; }
      if (ch === q) { stack.pop(); i++; continue; }
      i++; continue;
    }
    if (top.type === "template") {
      if (ch === "\\") { i += 2; continue; }
      if (ch === "`") { stack.pop(); i++; continue; }
      if (ch === "$" && src[i + 1] === "{") {
        stack.push({ type: "code", braceDepth: 1, isInterp: true, objStart: -1 });
        i += 2;
        continue;
      }
      i++; continue;
    }
  }
  if (stack.length !== 1) throw new Error("FAIL: tokenizer ended with unbalanced stack depth " + stack.length);
  return objects;
}

// 1) Find the class's segment boundaries via unique id-string anchors (NOT
//    line numbers -- they shift after every prior class's edit). Check the
//    exact quoting style first (`id:"x"` vs `id: "x"` both occur in this
//    file) with a quick search before hardcoding the anchor string.
const firstMarker = 'id:"sheep_heal"'; // first existing card's id, exact quoting
const firstIdx = html.indexOf(firstMarker);
if (firstIdx === -1) throw new Error("FAIL: could not find first anchor");
const objStart = html.lastIndexOf("{", firstIdx);

const lastMarker = 'id:"whale_XXXX"'; // first id of the NEXT class in the file
const lastIdx = html.indexOf(lastMarker);
if (lastIdx === -1) throw new Error("FAIL: could not find next-class anchor");
const segEnd = html.lastIndexOf("{", lastIdx);

// 2) Extract + verify.
const objects = extractObjects(html, objStart, segEnd);
console.log("Extracted " + objects.length + " top-level objects");
const byId = {};
const idOrder = [];
for (const obj of objects) {
  const m = obj.text.match(/id:\s*"([^"]+)"/);
  if (!m) throw new Error("FAIL: object with no id field: " + obj.text.slice(0, 120));
  const id = m[1];
  if (byId[id]) throw new Error("FAIL: duplicate id: " + id);
  byId[id] = obj.text;
  idOrder.push(id);
}
console.log("Current order (" + idOrder.length + "):\n" + idOrder.join(", "));
// Assert idOrder.length matches the known authored count BEFORE proceeding.

// 3) Define new stubs (bare: id/name/class/icon/maxRank only).
const newStubs = {
  // sheep_nAttack: { name: "Combo", icon: "sheep_nAttack2", maxRank: 2 },
  // ...
};
// Assert newStubs count matches the known missing count, and that none of
// its ids already exist in byId (would mean a mistaken "missing" family).

// 4) Target order = full getSkillTree() family sequence, using each
//    existing card's id where authored, else the new stub. Assert its
//    length matches (authored + new), and that every id in idOrder/newStubs
//    appears exactly once in targetOrder (bidirectional coverage check).
const targetOrder = [ /* ... */ ];
if (targetOrder.length !== idOrder.length + Object.keys(newStubs).length) {
  throw new Error("FAIL: target order length mismatch");
}
const allKnown = new Set([...idOrder, ...Object.keys(newStubs)]);
for (const id of targetOrder) if (!allKnown.has(id)) throw new Error("FAIL: unknown id in target: " + id);
for (const id of allKnown) if (!targetOrder.includes(id)) throw new Error("FAIL: id missing from target: " + id);

function buildStubText(id, def) {
  return `{ id:"${id}", name:"${def.name}", class:"Sheep", icon:"${def.icon}", maxRank:${def.maxRank} }`;
}

const reassembled = targetOrder
  .map((id) => "  " + (byId[id] || buildStubText(id, newStubs[id])) + ",")
  .join("\n");

// IMPORTANT: use "\n" + (whatever whitespace originally preceded lastMarker's
// own object) after segEnd -- check this per-class, it varies (some classes'
// next-door neighbor uses 2-space indent, Sheep/Rabbit's neighbor used 4).
const newHtml = html.slice(0, objStart) + reassembled + "\n  " + html.slice(segEnd);
fs.writeFileSync(resolvedFile, newHtml, "utf8");
console.log("SUCCESS: reordered " + idOrder.length + " existing + inserted " + Object.keys(newStubs).length + " new stubs = " + targetOrder.length + " total");
```

**Known cosmetic artifact**: the very first reassembled line always ends up
with 4-space indent instead of 2 (the original file's pre-existing indent
before the splice point stacks with the reassembly's own indent). After
running, grep the new first entry's line and fix it to 2-space indent with a
one-line `Edit`. Harmless if left, but every prior class fixed it for
consistency — do the same.

Put this script in the OS scratch directory per AGENTS.md Section 6, never in
`scripts/`. Run it, and if it throws, **the file is never written** (the
`throw` happens before `fs.writeFileSync`) — fix the script and rerun, don't
worry about partial corruption.

### 6. Verify and record

After every class:
```
node scripts/validate_skills.js
```
Confirm the skill count went up by exactly the new-stub count, and the icon
count went up by exactly the newly-embedded count (0 if all were
pre-embedded). Check the `[DEP BACKLOG]` section too — if a missing family you
just added a stub for was previously flagged there (a `*_DEP` object pointing
at it with no card), it should now disappear from the list, confirming the
new stub's id matches what the dep object expected.

Before validating, update the pending changelog entry (required by AGENTS.md's
Bible Changelog Freshness Gate, or `validate_skills.js` refuses to run):
```js
const fs = require('fs');
const f = 'c:/Users/Jump/Desktop/12tails/12t_projects/bible/index.html';
let html = fs.readFileSync(f, 'utf8');
const m = html.match(/entries:\s*\[\s*\[\"([^\"]+)\",\"([^\"]+)\"\]/);
const oldEntry = '[\"' + m[1] + '\",\"' + m[2] + '\"]';
const newEntry = '[\"' + new Date().toISOString() + '\",\"feat(sheep): reorder by skill ID, add N stub cards\"]';
html = html.replace(oldEntry, newEntry);
fs.writeFileSync(f, html, 'utf8');
```

## Precomputed data for Sheep (verified, ready to use)

Internal prefix: `shp_`. Total roster: 48 families (excl. 5 Common). Currently
authored: 28 cards (one of which, `sheep_seal`, covers 4 families). True
missing count: 17.

**Already-authored ids** (28): `sheep_heal, sheep_bless, sheep_quickHeal,
sheep_allHeal, sheep_pacify, sheep_sleep, sheep_clear, sheep_cleanse,
sheep_allCleanse, sheep_overHeal, sheep_revive, sheep_revert, sheep_holyLight,
sheep_lightBind, sheep_illuminate, sheep_feather, sheep_allFeather,
sheep_divinitySword, sheep_divinitySpear, sheep_seal, sheep_repel,
sheep_reverse, sheep_soulOfArms, sheep_purifyingTear, sheep_lullaby,
sheep_divinityAxe, sheep_edenSanctuary, sheep_worldEncarta` — verified via
direct extraction, matches `getSkillTree()` exactly once `sheep_seal`'s 4-family
coverage is accounted for.

**Missing families (17), with `maxRank` from `getSkillTree()`**:

| Family | maxRank | Icon key to use | Notes |
|---|---|---|---|
| nAttack | 2 | `sheep_nAttack2` | |
| cAttack | 4 | `sheep_cAttack4` | |
| harmonicDiffuse | 4 | `sheep_harmonicDiffuse4` | |
| freeCast | 2 | `sheep_freeCast2` | Active (`RPC_freeCast`, `Sheep.cs:1835`, per an earlier survey) |
| benediction | 3 | `sheep_benediction3` | Icon already embedded (verify before extracting) |
| karma | 4 | `sheep_karma4` | |
| homingLight | 1 (tier5) | `sheep_homingLight5` | Active (`RPC_homingLight_fire`) |
| whiteBurst | 1 (tier5) | `sheep_whiteBurst5` | Active (`RPC_whiteBurst_hit`) |
| returnCast | 1 (tier5) | `sheep_returnCast5` | Active (`RPC_returnCast`) |
| radiantHeal | 1 (tier5) | `sheep_radiantHeal5` | |
| gospel | 1 (tier5) | `sheep_gospel5` | Icon already embedded (verify); closes an existing DEP BACKLOG entry (`sheep_bless` references it) |
| koHeal | 1 (tier5) | `sheep_koHeal5` | |
| purify | 1 (tier5) | `sheep_purify5` | |
| intenseBind | 1 (tier5) | `sheep_intenseBind5` | Icon already embedded (verify); closes a DEP BACKLOG entry (`sheep_lightBind` references it) |
| blindingLight | 1 (tier5) | `sheep_blindingLight5` | Icon already embedded (verify); closes a DEP BACKLOG entry (`sheep_illuminate` references it) |
| floatingWing | 1 (tier5) | `sheep_floatingWing5` | |
| bookBash | 1 (tier5) | `sheep_bookBash5` | Active (`RPC_bookBash`/`RPC_bookBash_hit`) |

**Target order (45 entries: 28 authored + 17 stubs)**:
```
nAttack, cAttack, harmonicDiffuse, freeCast, heal, bless, quickHeal, allHeal,
pacify, sleep, clear, cleanse, allCleanse, overHeal, revive, benediction,
revert, holyLight, lightBind, illuminate, feather, allFeather, divinitySword,
divinitySpear, seal, repel, reverse, karma, soulOfArms, homingLight,
whiteBurst, purifyingTear, returnCast, radiantHeal, gospel, koHeal, lullaby,
purify, intenseBind, blindingLight, floatingWing, divinityAxe, edenSanctuary,
bookBash, worldEncarta
```
(map each bare name to `sheep_<name>` for the real id, except the merge slot
which is `sheep_seal`.)

**Still to do for Sheep**: verify which of the 17 missing families' icons are
already embedded vs need `RippedAssets` extraction (check `benediction`,
`gospel`, `intenseBind`, `blindingLight` first — flagged above as likely
pre-embedded from earlier passive-dep work, but confirm with a grep before
trusting this note), then run steps 4-6 above.

## Whale (not started, not researched)

Nothing has been done for Whale — not even the `getSkillTree()` extraction.
Confirm its internal prefix first (don't assume `whl_`). Repeat the full
method from step 1. An earlier automated survey (not independently verified,
treat with the same skepticism as the Sheep/Panda/Bison surveys above — several
of its per-class family lists were incomplete or wrong until manually
rechecked) suggested ~23 missing families with names like `shieldBash`,
`culinaryTongue`, `superSize`, `wallPuncture`, `autoShield`, `lastHope`,
`knightOfTheDeep`, `overPresence`, `hardenSkin`, `reducedCast`, `entendedWave`,
`shieldReflect`, `gourmetHeart`, `megaSize`, `tideCutter`, `honorStand`,
`wonderBelly`, `peninsulaAsunder`, `overWeight`, `spiralBlast`, `divingPress`,
plus `nAttack`/`cAttack` — but re-derive this from `WhaleSkill.cs` directly
before trusting any of it, the same way Sheep's data above was independently
confirmed.

## Order after Sheep and Whale

Once both are done, all 12 classes are complete and reordered. At that point
this file has served its purpose and can be deleted (matches this repo's own
past practice — a prior `HANDOFF.md` used for a similar cross-session handoff
was removed once no longer needed; see `git log -- HANDOFF.md`).
