# Skill Cooldown/Duration Lookup Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Add a mounted "Skill Cooldown/Duration Lookup" tool to the "12 Tails Tools" hub
(`12t_projects/player-reference-tool/index.html`) covering every active skill's max-rank cooldown and
buff/debuff duration across all 12 classes, adjusted live for the player's AGI/CHA/LCK and an optional
`revisedArt5` toggle.

**Architecture:** Research first (12 independent, parallelizable tasks — one verified reference doc per
class, extracted straight from the decompiled source), then build (icon extraction, pure adjusted-value
math functions, data population, UI, final verification). The UI task only starts once all 12 reference
docs exist.

**Tech Stack:** Vanilla JS/CSS/HTML, no build step, no dependencies — matches every other deliverable in
this repo. Data extraction uses grep/Read against the decompiled `.cs` source; icon extraction uses a
Python script (Node is not available in this environment — confirmed this session).

## Global Constraints

- Every extracted cooldown/duration fact must cite `file:line`, no invented numbers — spec:
  "Research plan".
- Scope per class: **active skills only** (has a real cooldown), **max rank only**, **cooldown +
  duration only** — no damage formulas, no per-rank breakdown. Passive/no-cooldown skills are excluded
  entirely, not just hidden.
- Skills with a **CHA-contested** duration (target's stat affects final duration) get no duration field
  at all — indistinguishable from a skill with no duration.
- `cdWrapped`/`durWrapped` must be verified at each skill's own cast site — never assumed from
  `<Class>Skill.cs` metadata alone (Penguin's `manaArc` looked `agiAdjust`-wrapped and wasn't).
- `revisedArtExempt` must be recorded per skill (basic-attack/charge-attack/consumable-type skills are
  exempt from the 12% CD reduction) — spec: "Tool architecture — Data shape".
- The shipped file must remain a single self-contained HTML file — no external requests, all icons/CSS/
  JS inline. No `eval()`/`Function()` constructor for the adjusted-value math.
- New CSS uses a `.sk-` class prefix (isolation convention already established by `.sg-`/`.gk-` in this
  same file).
- No Node or browser is available in this environment this session — verification is Python hand-
  computation + structural (brace/tag balance) checks + manual review, not automated test execution.
  Never claim "verified in a browser" without actually having done it.
- **Exclude the 12 shared "support skills"** — added mid-execution (2026-08-12), after Task 1 was
  already committed (Task 1's doc is clean, verified). `SkillData.cs`'s `getSupportSkill()` defines a
  separate `eSkillType.support` system, one skill thematically tied to each of the 12 classes:
  `obsidianFang` (Wolf), `stunningGround` (Bison), `psalmOfEnergy` (Panda), `seaAegis` (Whale),
  `assassinate` (Cat), `zephyrLore` (Chameleon), `mineWalker` (Mole), `replenishment` (Rabbit),
  `elementalBound` (Monkey), `divineChannel` (Sheep), `astralShift` (Penguin), `bloodCarnage` (Bat).
  **Every class's own `.cs` file duplicates all 12 of these `RPC_<name>` handlers verbatim** (confirmed
  in both `Penguin.cs` and `Bat.cs`), each with a flat, unwrapped `addTimeOut("<name>", (float)600)` —
  a dead giveaway signature (bare `600`, never `agiAdjust`-wrapped). Tasks 2-12's `grep -n
  "RPC_<skillName>" <Class>.cs` step WILL match all 12 of these in every class file — they are not that
  class's own skills and must be excluded from that class's table, not just deduplicated.
- **Exclude `nAttack`/`cAttack` (basic/charge-attack) entirely from every class's table** — added
  mid-execution (2026-08-12), after Task 2 was already reviewed-approved with an `nAttack` row for Bat
  (that row is being removed via a fix round; see ledger). Even when a class's basic-attack combo has a
  genuine per-stage named cooldown at its own cast site (confirmed true for Bat's `nAttack3`, `Bat.cs:21074`,
  `addTimeOut("nAttack", (float)2)`) — user decision: never give it a row, in any class's doc. This
  narrows `revisedArtExempt`'s practical scope: it can still be `true` for a consumable-item cooldown if
  one appears in a class's active-skill list, but never for `nAttack`/`cAttack` since those no longer get
  rows at all.

---

## Task 1: Penguin skill-cooldown-reference doc (establishes the schema)

**Files:**
- Create: `12t_reference/penguin-skill-cooldown-reference.md`
- Read: `12t_reference/2026-07-21-penguin-skill-data-reference.md` (source of truth — Penguin's data is
  already verified, this task extracts/reformats, it does not re-derive from raw `.cs` source)

**Interfaces:**
- Produces: the reference-doc **schema** every other class's doc (Tasks 2-12) and the data-population
  task (Task 15) must follow exactly:
  ```markdown
  # <Class> — Skill Cooldown/Duration Reference

  Verified 2026-08-12 for the skill-cooldown-lookup tool (`12t_projects/player-reference-tool/index.html`).
  Scope: active skills only (has a real cooldown), max rank only. Passive/no-cooldown skills excluded.

  | Skill ID | Display Name | Max Rank | CD Base | CD Wrapped (agiAdjust) | revisedArt Exempt | Duration Base | Duration Wrapped (chaAdjust) |
  |---|---|---|---|---|---|---|---|
  | manaArc | Mana Arc | 4 | 1 | false | false | — | — |
  | ... | ... | ... | ... | ... | ... | ... | ... |

  ## Citations
  - `manaArc` CD: `Penguin.cs:21756` — `mChar.addTimeOut("manaArc", (float)1)` (bare literal, not agiAdjust-wrapped)
  - ...
  ```
  `Duration Base`/`Duration Wrapped` cells are literally `—` for skills with no applicable duration (not
  blank, not "N/A" — use the em-dash consistently so later parsing/scanning is unambiguous).

- [ ] **Step 1: List every active skill Penguin's existing doc documents**

Read `12t_reference/2026-07-21-penguin-skill-data-reference.md` fully. For every skill family with a
`cd` field (active skills), note its id, display name, and max rank (highest rank number that family
reaches).

- [ ] **Step 2: For each active skill, determine CD base + wrapped status at max rank**

The existing doc already states this per skill (e.g. the `manaArc` entry: "CD: flat `1`s, a bare
literal — NOT wrapped in `agiAdjust` at all... Still gets revisedArt5's ×0.88"). Transcribe the max-rank
CD value and `cdWrapped` (true if `agiAdjust(...)` appears in the source formula, false if it's a bare
literal).

- [ ] **Step 3: For each active skill, determine `revisedArtExempt`**

True only for `nAttack`/`cAttack`-type basic/charge-attack skills and consumable-item cooldowns (per the
existing doc's global-mechanics note: "424 excludes nAttack/cAttack/emoticon/consumable-item
cooldowns"). All other active skills default to `false`.

- [ ] **Step 4: For each active skill, determine duration base + wrapped status (or omit)**

If the skill grants a buff/debuff duration that is NOT contested by the target, transcribe its max-rank
duration value and whether it's `chaAdjust`-wrapped. If contested, or no duration exists, both cells are
`—`.

- [ ] **Step 5: Write `12t_reference/penguin-skill-cooldown-reference.md`**

Using the exact schema above. Every row's CD/duration/wrapped/exempt values must trace back to a
citation in the "## Citations" section pointing at the ORIGINAL source (`Penguin.cs:LINE` or
`PenguinSkill.cs:LINE`) — copy these citations from the existing data-reference doc rather than
re-deriving them; do not cite the data-reference doc itself as the source.

- [ ] **Step 6: Verify citations**

For every citation in the new doc, confirm the cited line actually exists and says what's claimed:

```bash
grep -n "addTimeOut(\"manaArc\"" Penguin.cs
```

Repeat for a spot-check of at least 5 citations. All must match.

- [ ] **Step 7: Commit**

```bash
git add "12t_reference/penguin-skill-cooldown-reference.md"
git commit -m "docs: add Penguin skill-cooldown reference (schema baseline)"
```

---

## Task 2: Bat skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/bat-skill-cooldown-reference.md`
- Read: `BatSkill.cs`, `Bat.cs`

**Interfaces:**
- Consumes: Task 1's schema (reproduced exactly, `Bat` substituted for `Class`).
- Produces: `12t_reference/bat-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1: List every active skill in `BatSkill.cs`**

```bash
grep -n "getSkill\|SkillClass\|cType" BatSkill.cs | head -80
```
For each skill family, note its id and max rank (highest numbered rank entry). A skill counts as
"active" only if it has a real cooldown at its cast site (checked in Step 2) — do not assume from
`BatSkill.cs` metadata alone, some entries there are cost tables for passives too.

- [ ] **Step 2: For each candidate skill, find its cast site and determine CD base + wrapped status**

```bash
grep -n "RPC_<skillName>" Bat.cs
```
Read the matched handler. Find the `addTimeOut(...)` call. Record the literal value passed and whether
it's wrapped in `agiAdjust(...)` — do not assume wrapping from `BatSkill.cs`'s cost-table shape.

- [ ] **Step 3: For each active skill, determine `revisedArtExempt`**

True for `nAttack`/`cAttack`-type basic/charge-attack skills only (check via `RPC_nAttack`/`RPC_cAttack`
in `Bat.cs`), false otherwise.

- [ ] **Step 4: For each active skill, determine duration base + wrapped status (or omit)**

```bash
grep -n "RPC_AddStatus" Bat.cs
```
For each cast site calling `RPC_AddStatus(...)`, check whether the duration argument is wrapped in
`chaAdjust(...)` and whether it's contested by the target (e.g. the target's own stat modifies the
final duration, not just the caster's CHA) — if contested, omit duration entirely for that skill.

- [ ] **Step 5: Write `12t_reference/bat-skill-cooldown-reference.md`**

Following Task 1's exact schema (table + "## Citations" section, `file:line` for every cell).

- [ ] **Step 6: Verify citations**

Spot-check at least 5 citations with `grep -n` against `Bat.cs`/`BatSkill.cs`, confirming each cited
line says what's claimed.

- [ ] **Step 7: Commit**

```bash
git add "12t_reference/bat-skill-cooldown-reference.md"
git commit -m "docs: add Bat skill-cooldown reference"
```

---

## Task 3: Bison skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/bison-skill-cooldown-reference.md`
- Read: `BisonSkill.cs`, `Bison.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/bison-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1: List every active skill in `BisonSkill.cs`**

```bash
grep -n "getSkill\|SkillClass\|cType" BisonSkill.cs | head -80
```

- [ ] **Step 2: For each candidate skill, find its cast site and determine CD base + wrapped status**

```bash
grep -n "RPC_<skillName>" Bison.cs
```
Read each matched handler, find `addTimeOut(...)`, record value + `agiAdjust`-wrapped status.

- [ ] **Step 3: For each active skill, determine `revisedArtExempt`**

True for `nAttack`/`cAttack`-type skills only.

- [ ] **Step 4: For each active skill, determine duration base + wrapped status (or omit)**

```bash
grep -n "RPC_AddStatus" Bison.cs
```
Check `chaAdjust`-wrapping and target-contested status per hit; omit if contested.

- [ ] **Step 5: Write `12t_reference/bison-skill-cooldown-reference.md`** following Task 1's schema.

- [ ] **Step 6: Verify citations** — spot-check at least 5 against `Bison.cs`/`BisonSkill.cs`.

- [ ] **Step 7: Commit**

```bash
git add "12t_reference/bison-skill-cooldown-reference.md"
git commit -m "docs: add Bison skill-cooldown reference"
```

---

## Task 4: Cat skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/cat-skill-cooldown-reference.md`
- Read: `CatSkill.cs`, `Cat.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/cat-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" CatSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Cat.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Cat.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/cat-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Cat.cs`/`CatSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/cat-skill-cooldown-reference.md"
git commit -m "docs: add Cat skill-cooldown reference"
```

---

## Task 5: Chameleon skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/chameleon-skill-cooldown-reference.md`
- Read: `ChameleonSkill.cs`, `Chameleon.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/chameleon-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" ChameleonSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Chameleon.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Chameleon.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/chameleon-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Chameleon.cs`/`ChameleonSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/chameleon-skill-cooldown-reference.md"
git commit -m "docs: add Chameleon skill-cooldown reference"
```

---

## Task 6: Mole skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/mole-skill-cooldown-reference.md`
- Read: `MoleSkill.cs`, `Mole.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/mole-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" MoleSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Mole.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Mole.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/mole-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Mole.cs`/`MoleSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/mole-skill-cooldown-reference.md"
git commit -m "docs: add Mole skill-cooldown reference"
```

---

## Task 7: Monkey skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/monkey-skill-cooldown-reference.md`
- Read: `MonkeySkill.cs`, `Monkey.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/monkey-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" MonkeySkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Monkey.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Monkey.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/monkey-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Monkey.cs`/`MonkeySkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/monkey-skill-cooldown-reference.md"
git commit -m "docs: add Monkey skill-cooldown reference"
```

---

## Task 8: Panda skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/panda-skill-cooldown-reference.md`
- Read: `PandaSkill.cs`, `Panda.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/panda-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" PandaSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Panda.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Panda.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/panda-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Panda.cs`/`PandaSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/panda-skill-cooldown-reference.md"
git commit -m "docs: add Panda skill-cooldown reference"
```

---

## Task 9: Rabbit skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/rabbit-skill-cooldown-reference.md`
- Read: `RabbitSkill.cs`, `Rabbit.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/rabbit-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" RabbitSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Rabbit.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Rabbit.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/rabbit-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Rabbit.cs`/`RabbitSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/rabbit-skill-cooldown-reference.md"
git commit -m "docs: add Rabbit skill-cooldown reference"
```

---

## Task 10: Sheep skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/sheep-skill-cooldown-reference.md`
- Read: `SheepSkill.cs`, `Sheep.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/sheep-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" SheepSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Sheep.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Sheep.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/sheep-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Sheep.cs`/`SheepSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/sheep-skill-cooldown-reference.md"
git commit -m "docs: add Sheep skill-cooldown reference"
```

---

## Task 11: Whale skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/whale-skill-cooldown-reference.md`
- Read: `WhaleSkill.cs`, `Whale.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/whale-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" WhaleSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Whale.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Whale.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/whale-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Whale.cs`/`WhaleSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/whale-skill-cooldown-reference.md"
git commit -m "docs: add Whale skill-cooldown reference"
```

---

## Task 12: Wolf skill-cooldown-reference doc

**Files:**
- Create: `12t_reference/wolf-skill-cooldown-reference.md`
- Read: `WolfSkill.cs`, `Wolf.cs`

**Interfaces:**
- Consumes: Task 1's schema.
- Produces: `12t_reference/wolf-skill-cooldown-reference.md`, consumed by Task 15.

- [ ] **Step 1:** `grep -n "getSkill\|SkillClass\|cType" WolfSkill.cs | head -80` — list active skills + max ranks.
- [ ] **Step 2:** `grep -n "RPC_<skillName>" Wolf.cs` per skill; read handler, record `addTimeOut` value + `agiAdjust`-wrapped status.
- [ ] **Step 3:** Determine `revisedArtExempt` (true only for `nAttack`/`cAttack`-type).
- [ ] **Step 4:** `grep -n "RPC_AddStatus" Wolf.cs`; record duration + `chaAdjust`-wrapped status, omit if target-contested.
- [ ] **Step 5:** Write `12t_reference/wolf-skill-cooldown-reference.md` following Task 1's schema.
- [ ] **Step 6:** Spot-check at least 5 citations against `Wolf.cs`/`WolfSkill.cs`.
- [ ] **Step 7: Commit**

```bash
git add "12t_reference/wolf-skill-cooldown-reference.md"
git commit -m "docs: add Wolf skill-cooldown reference"
```

---

## Task 13: Icon extraction (all 12 classes)

**Files:**
- Create: `.superpowers/sdd/dump_skill_cooldown_icons.py`
- Create (script output, scratchpad): base64 icon JSON

**Interfaces:**
- Consumes: the 12 reference docs from Tasks 1-12 (their "Skill ID"/"Max Rank" columns determine which
  icon files are needed).
- Produces: a base64-encoded icon map keyed by `<class>_<skillId><maxRank>`, consumed by Task 15.

- [ ] **Step 1: Build the needed-icon list from all 12 reference docs**

For each of the 12 `12t_reference/*-skill-cooldown-reference.md` files, read its table and build a list
of `(class, skillId, maxRank)` triples — one per row.

- [ ] **Step 2: Write the generalized dump script**

Adapt `.superpowers/sdd/dump_penguin_icons.py`'s pattern (base path + `NEEDED` list + base64 dump) to
loop over all 12 classes:

```python
import base64, json, os

ICON_ROOT = r"g:\My Drive\Claude\projects\12tails\RippedAssets\ExportedProject\Assets\Resources\gamegui\icons\skills"
# OUT_PATH: use whatever scratchpad directory your current session provides
# (stated in your system prompt as "Scratchpad Directory") — this is
# per-session and cannot be hardcoded here; do not invent a path, read it
# from your own session context.
OUT_PATH = r"REPLACE_WITH_YOUR_SESSION_SCRATCHPAD_DIR/skill_cooldown_icons_b64.json"

# (class_folder, skillId, maxRank) triples gathered from the 12 reference docs in Step 1
NEEDED = [
    ("wolf", "howl", 3),
    # ... one entry per row across all 12 reference docs
]

out = {}
missing = []
for cls, skill_id, max_rank in NEEDED:
    fname = f"{skill_id}{max_rank}.png"
    path = os.path.join(ICON_ROOT, cls, fname)
    if not os.path.exists(path):
        missing.append(path)
        continue
    with open(path, "rb") as f:
        out[f"{cls}_{skill_id}{max_rank}"] = "data:image/png;base64," + base64.b64encode(f.read()).decode()

if missing:
    raise SystemExit("Missing icon files:\n  " + "\n  ".join(missing))

with open(OUT_PATH, "w", encoding="utf-8") as f:
    json.dump(out, f)

print(f"OK: {len(out)} icons dumped, {os.path.getsize(OUT_PATH)//1024} KB -> {OUT_PATH}")
```

- [ ] **Step 3: Run the script**

```bash
python .superpowers/sdd/dump_skill_cooldown_icons.py
```
Expected: `OK: <N> icons dumped, <size> KB -> <path>` with no `Missing icon files` error. If any file is
missing, re-check that row's `Skill ID`/`Max Rank` against the source reference doc — the filename
pattern is `<skillId><maxRank>.png`, exactly as `dump_penguin_icons.py` already established.

- [ ] **Step 4: Commit the script (not the generated JSON — that's consumed directly by Task 15, not tracked)**

```bash
git add ".superpowers/sdd/dump_skill_cooldown_icons.py"
git commit -m "feat: add icon-extraction script for the skill-cooldown-lookup tool"
```

---

## Task 14: Adjusted-value math functions

**Files:**
- Modify: `12t_projects/player-reference-tool/index.html` (add functions inside the `<script>` block,
  above the `TOOLS` registry)

**Interfaces:**
- Consumes: nothing (pure functions).
- Produces:
  - `agiAdjustRange(base, AGI, LCK) → [min, max]`
  - `chaAdjustRange(base, CHA, LCK) → [min, max]`
  - `applyRevisedArt(range, on, exempt) → [min, max]` (range may be a 2-element array or, for an
    unwrapped value, a 1-element array `[value]` — callers normalize)
  Consumed by Task 16's table-rendering code.

- [ ] **Step 1: Write the functions**

```js
// R = Random(0, ceil(0.2*LCK)) — modeled as its own [min,max] range (0 to the roll's ceiling),
// not a single roll, since this tool shows the full possible spread, not one outcome.
function lckSpreadRange(LCK) {
  const rMax = Math.ceil(0.2 * Math.max(LCK, 0));
  return [0, rMax];
}

// agiAdjust(t) = t * (1 - n/(n+128)), n = AGI + R — higher n = shorter CD, so max R gives the
// MIN of the range and min R (=0) gives the MAX of the range.
function agiAdjustRange(base, AGI, LCK) {
  const [rMin, rMax] = lckSpreadRange(LCK);
  const nMin = AGI + rMin, nMax = AGI + rMax;
  const shortest = base * (1 - nMax / (nMax + 128));
  const longest  = base * (1 - nMin / (nMin + 128));
  return [shortest, longest];
}

// chaAdjust(t) = ceil(t * (1 + 0.015*clamp(CHA+R,1,512))) — higher R = longer duration, so
// min R gives the MIN of the range and max R gives the MAX of the range.
function chaAdjustRange(base, CHA, LCK) {
  const [rMin, rMax] = lckSpreadRange(LCK);
  const clampedMin = Math.min(Math.max(CHA + rMin, 1), 512);
  const clampedMax = Math.min(Math.max(CHA + rMax, 1), 512);
  const shortest = Math.ceil(base * (1 + 0.015 * clampedMin));
  const longest  = Math.ceil(base * (1 + 0.015 * clampedMax));
  return [shortest, longest];
}

// Applies revisedArt5's 12% CD reduction (×0.88, ceil) to each endpoint of a CD range, AFTER
// agiAdjust has already run — matches the Penguin sheet's chipHTML order exactly. No-op if the
// toggle is off or the skill is exempt (basic attacks/consumables never get this reduction).
function applyRevisedArt(range, on, exempt) {
  if (!on || exempt) return range;
  return range.map(v => Math.ceil(0.88 * v));
}
```

- [ ] **Step 2: Verify with hand-computed cases (no Node available — use Python)**

```bash
python3 -c "
def lck_spread(lck):
    import math
    return 0, math.ceil(0.2*max(lck,0))

def agi_adjust_range(base, agi, lck):
    import math
    r_min, r_max = lck_spread(lck)
    n_min, n_max = agi+r_min, agi+r_max
    shortest = base*(1 - n_max/(n_max+128))
    longest  = base*(1 - n_min/(n_min+128))
    return shortest, longest

def cha_adjust_range(base, cha, lck):
    import math
    r_min, r_max = lck_spread(lck)
    c_min = min(max(cha+r_min,1),512)
    c_max = min(max(cha+r_max,1),512)
    shortest = math.ceil(base*(1+0.015*c_min))
    longest  = math.ceil(base*(1+0.015*c_max))
    return shortest, longest

# base=10s CD, AGI=80, LCK=40 -> R range [0, ceil(0.2*40)=8] -> n in [80,88]
print('agi case 1:', agi_adjust_range(10, 80, 40))
# base=12s duration, CHA=50, LCK=20 -> R range [0, ceil(0.2*20)=4] -> CHA+R in [50,54]
print('cha case 1:', cha_adjust_range(12, 50, 20))
"
```
Trace the JS functions by hand against this same Python output for at least these 2 cases — the numbers
must match exactly (both are direct transcriptions of the same formula, so any mismatch means a typo in
one of the two, find and fix it before proceeding).

- [ ] **Step 3: Commit**

```bash
git add "12t_projects/player-reference-tool/index.html"
git commit -m "feat: add adjusted-value math functions for skill-cooldown-lookup tool"
```

---

## Task 15: SKILLS data population

**Files:**
- Modify: `12t_projects/player-reference-tool/index.html` (add a `SKILL_ICONS` object and a `SKILLS`
  array, above the `TOOLS` registry, below Task 14's functions)
- Read: all 12 `12t_reference/*-skill-cooldown-reference.md` files, Task 13's icon JSON output

**Interfaces:**
- Consumes: Tasks 1-12's reference docs, Task 13's icon data.
- Produces:
  ```js
  const SKILL_ICONS = { "wolf_howl3": "data:image/png;base64,...", ... };
  const SKILLS = [
    { id:"wolf_howl", name:"Howl", class:"Wolf", icon:"wolf_howl3",
      cd:12, cdWrapped:true, revisedArtExempt:false,
      duration:8, durWrapped:true },   // duration/durWrapped omitted (not present as keys) if not applicable
    ...
  ];
  ```
  Consumed by Task 16's table-rendering/filtering code. `icon` is a **key into `SKILL_ICONS`**, not the
  raw data URI, to avoid repeating large base64 strings across skills that happen to share art.

- [ ] **Step 1: Merge the 12 reference docs' tables into the `SKILLS` array**

For every row across all 12 `12t_reference/*-skill-cooldown-reference.md` files, produce one `SKILLS`
entry with the exact field shape above. `id` is `<class-lowercase>_<skillId>` to guarantee uniqueness
across classes even if two classes happen to reuse a skill id string.

- [ ] **Step 2: Paste Task 13's icon JSON into `SKILL_ICONS`**

Keys already match the `class_skillIdMaxRank` scheme Task 13 produced; `SKILLS[i].icon` values must be
exactly those same keys.

- [ ] **Step 3: Verify row count**

```bash
grep -c "^|" 12t_reference/*-skill-cooldown-reference.md
```
Sum the per-file counts (minus each file's 1 header + 1 separator row) and confirm it matches
`SKILLS.length` (spot-check via a quick `grep -c "id:" ` on the pasted array, or count entries visually
if the array is short enough).

- [ ] **Step 4: Commit**

```bash
git add "12t_projects/player-reference-tool/index.html"
git commit -m "feat: populate SKILLS data for skill-cooldown-lookup tool (all 12 classes)"
```

---

## Task 16: Tool UI — mount, search/filter, table, revisedArt toggle

**Files:**
- Modify: `12t_projects/player-reference-tool/index.html`
  - Add `.sk-*` CSS rules to the `<style>` block (new section, following the `.gk-*`/`.sg-*` pattern)
  - Add `mountSkillCooldownLookup(root)` function (below Task 15's data, above the `TOOLS` registry)
  - Add a new entry to the `TOOLS` array

**Interfaces:**
- Consumes: Task 14's `agiAdjustRange`/`chaAdjustRange`/`applyRevisedArt`, Task 15's `SKILLS`/
  `SKILL_ICONS`, the existing `$`/`$$` DOM helpers.
- Produces: a working mounted tool, no further consumers (final task before verification).

- [ ] **Step 1: Add the `revisedArt5` icon to `SKILL_ICONS`**

Extract Penguin's copy the same way Task 13 did (one more file, not a new script — this one icon isn't
tied to any `SKILLS` row so it's added directly): read
`RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/penguin/revisedArt5.png`, base64
it, add as `SKILL_ICONS["revisedArt5"]`.

- [ ] **Step 2: Add CSS**

```css
/* ================= skill cooldown lookup tool ================= */
.sk{padding:26px 24px}
.sk h2{font-size:21px; margin:0 0 18px}
.sk-controls{
  background:var(--panel-2); border:1px solid var(--line); border-radius:3px;
  padding:16px; display:flex; flex-wrap:wrap; gap:14px; align-items:end; margin-bottom:14px;
}
.sk-controls label{display:block; font-size:10.5px; color:var(--muted); margin:0 0 6px; letter-spacing:.7px; text-transform:uppercase}
.sk-controls input[type=number]{
  width:80px; background:var(--panel); color:var(--text); border:1px solid var(--line);
  border-radius:2px; padding:9px 10px; font-size:15px; outline:none; font-family:inherit;
}
.sk-controls input[type=text]{
  width:200px; background:var(--panel); color:var(--text); border:1px solid var(--line);
  border-radius:2px; padding:9px 10px; font-size:15px; outline:none; font-family:inherit;
}
.sk-revisedart{
  border:1px solid var(--gold); border-radius:4px; background:var(--panel);
  padding:4px; cursor:pointer; line-height:0; align-self:end;
}
.sk-revisedart img{width:28px; height:28px; display:block; filter:grayscale(100%); opacity:.5}
.sk-revisedart.on img{filter:none; opacity:1}
.sk-revisedart.on{border-color:var(--gold)}
.sk-classfilter{display:flex; flex-wrap:wrap; gap:6px; margin-bottom:14px}
.sk-classchip{
  background:var(--panel-2); border:1px solid var(--line); border-radius:2px; padding:6px 12px;
  color:var(--text); font-size:12px; cursor:pointer; font-family:inherit;
}
.sk-classchip.on{border-color:var(--gold); color:var(--gold); background:var(--gold-soft)}
.sk-results{border:1px solid var(--line); border-radius:3px; overflow:hidden}
.sk-results table{width:100%; border-collapse:collapse; font-size:13.5px}
.sk-results thead th{
  background:var(--panel-2); color:var(--gold); font-weight:700; text-align:right;
  padding:9px 12px; border-bottom:1px solid var(--gold); font-size:10px; letter-spacing:.6px; text-transform:uppercase;
}
.sk-results thead th:first-child,.sk-results thead th:nth-child(2){text-align:left}
.sk-results tbody td{padding:9px 12px; text-align:right; border-bottom:1px solid var(--line); font-size:13px}
.sk-results tbody td:first-child,.sk-results tbody td:nth-child(2){text-align:left}
.sk-results tbody tr:last-child td{border-bottom:none}
.sk-results tbody tr:hover td{background:var(--gold-soft)}
.sk-skillcell{display:flex; align-items:center; gap:8px}
.sk-skillcell img{width:22px; height:22px; border-radius:3px; flex:none}
.sk-empty{padding:20px; text-align:center; color:var(--muted); font-size:13px}
```

- [ ] **Step 3: Add `mountSkillCooldownLookup(root)`**

```js
function mountSkillCooldownLookup(root){
  const CLASSES = [...new Set(SKILLS.map(s => s.class))].sort();

  root.innerHTML = `
    <div class="sk">
      <h2>Skill Cooldown/Duration Lookup</h2>
      <div class="sk-controls">
        <div><label>AGI</label><input type="number" data-role="agi" min="0" value="0"></div>
        <div><label>CHA</label><input type="number" data-role="cha" min="0" value="0"></div>
        <div><label>LCK</label><input type="number" data-role="lck" min="0" value="0"></div>
        <div><label>Search</label><input type="text" data-role="search" placeholder=""></div>
        <button type="button" class="sk-revisedart" data-role="revisedart" title="revisedArt5 (12% cooldown reduction)"></button>
      </div>
      <div class="sk-classfilter" data-role="classfilter"></div>
      <div class="sk-results"><table>
        <thead><tr>
          <th>Skill</th><th>Class</th><th>CD (base)</th><th>CD (adjusted)</th><th>Duration (base)</th><th>Duration (adjusted)</th>
        </tr></thead>
        <tbody data-role="rows"></tbody>
      </table></div>
    </div>
  `;

  const agiEl = $('[data-role="agi"]', root);
  const chaEl = $('[data-role="cha"]', root);
  const lckEl = $('[data-role="lck"]', root);
  const searchEl = $('[data-role="search"]', root);
  const raBtn = $('[data-role="revisedart"]', root);
  const classFilterEl = $('[data-role="classfilter"]', root);
  const rows = $('[data-role="rows"]', root);

  raBtn.innerHTML = `<img src="${SKILL_ICONS["revisedArt5"]}" alt="revisedArt5">`;
  let revisedArtOn = false;
  let activeClass = null; // null = All

  const allChip = document.createElement("button");
  allChip.type = "button"; allChip.className = "sk-classchip on"; allChip.textContent = "All";
  allChip.addEventListener("click", () => { activeClass = null; syncChips(); render(); });
  classFilterEl.appendChild(allChip);

  const classChips = {};
  CLASSES.forEach(cls => {
    const chip = document.createElement("button");
    chip.type = "button"; chip.className = "sk-classchip"; chip.textContent = cls;
    chip.addEventListener("click", () => { activeClass = cls; syncChips(); render(); });
    classFilterEl.appendChild(chip);
    classChips[cls] = chip;
  });

  function syncChips(){
    allChip.classList.toggle("on", activeClass === null);
    CLASSES.forEach(cls => classChips[cls].classList.toggle("on", activeClass === cls));
  }

  function fmt(range){
    if (range.length === 1) return range[0].toFixed(1).replace(/\.0$/,"");
    const [a,b] = range;
    const fa = a.toFixed(1).replace(/\.0$/,""), fb = b.toFixed(1).replace(/\.0$/,"");
    return fa === fb ? fa : `${fa}–${fb}`;
  }

  function render(){
    const AGI = parseFloat(agiEl.value) || 0;
    const CHA = parseFloat(chaEl.value) || 0;
    const LCK = parseFloat(lckEl.value) || 0;
    const q = searchEl.value.trim().toLowerCase();

    const filtered = SKILLS.filter(s =>
      (activeClass === null || s.class === activeClass) &&
      (q === "" || s.name.toLowerCase().includes(q))
    );

    if (filtered.length === 0){
      rows.innerHTML = `<tr><td colspan="6" class="sk-empty">No matches</td></tr>`;
      return;
    }

    rows.innerHTML = filtered.map(s => {
      let cdRange = s.cdWrapped ? agiAdjustRange(s.cd, AGI, LCK) : [s.cd];
      cdRange = applyRevisedArt(cdRange, revisedArtOn, s.revisedArtExempt);
      const cdAdjusted = fmt(cdRange);

      let durBase = "—", durAdjusted = "—";
      if (s.duration !== undefined){
        durBase = s.duration;
        const durRange = s.durWrapped ? chaAdjustRange(s.duration, CHA, LCK) : [s.duration];
        durAdjusted = fmt(durRange);
      }

      return `<tr>
        <td><span class="sk-skillcell"><img src="${SKILL_ICONS[s.icon]}" alt="">${s.name}</span></td>
        <td>${s.class}</td>
        <td class="num">${s.cd}s</td>
        <td class="num">${cdAdjusted}s</td>
        <td class="num">${durBase === "—" ? "—" : durBase + "s"}</td>
        <td class="num">${durAdjusted === "—" ? "—" : durAdjusted + "s"}</td>
      </tr>`;
    }).join("");
  }

  agiEl.addEventListener("input", render);
  chaEl.addEventListener("input", render);
  lckEl.addEventListener("input", render);
  searchEl.addEventListener("input", render);
  raBtn.addEventListener("click", () => { revisedArtOn = !revisedArtOn; raBtn.classList.toggle("on", revisedArtOn); render(); });

  render();
}
```

- [ ] **Step 4: Register the tool in `TOOLS`**

```js
{
  id: "skill-cooldown-lookup",
  title: "Skill Cooldown/Duration Lookup",
  category: "Lookup",
  icon: '<svg width="18" height="18" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><circle cx="12" cy="12" r="9"/><path d="M12 7v5l3 3"/></svg>',
  mounted: false,
  mount(root){ mountSkillCooldownLookup(root); }
}
```
Add this entry to the `TOOLS` array (mounted, per this tool's exception to the link-out default —
matches Stat-Gain's existing exception).

- [ ] **Step 5: Structural verification (no Node/browser — static checks only)**

```bash
python3 -c "
path = '12t_projects/player-reference-tool/index.html'
with open(path, encoding='utf-8') as f:
    c = f.read()
s = c.index('<style>') + len('<style>'); e = c.index('</style>')
print('css brace balance:', c[s:e].count('{') - c[s:e].count('}'))
start = c.index('\"use strict\";'); end = c.rindex('</script>')
js = c[start:end]
depth = 0
in_str = None
i = 0
while i < len(js):
    ch = js[i]
    if in_str:
        if ch == '\\\\': i += 2; continue
        if ch == in_str: in_str = None
        i += 1; continue
    if ch in '\"\\'\`': in_str = ch; i += 1; continue
    if ch == '{': depth += 1
    elif ch == '}': depth -= 1
    i += 1
print('js brace balance (crude, ignores // comments):', depth)
"
```
Expected: both balances print `0`. This is a coarser check than the one used earlier this session (no
comment-stripping) — treat any non-zero result as a real signal to investigate, not a false positive to
ignore.

- [ ] **Step 6: Commit**

```bash
git add "12t_projects/player-reference-tool/index.html"
git commit -m "feat: add Skill Cooldown/Duration Lookup tool to the hub"
```

---

## Task 17: Final verification and docs

**Files:**
- Modify: `12t_projects/player-reference-tool/CLAUDE.md`, root `CLAUDE.md`, `HANDOFF.md`

**Interfaces:**
- Consumes: everything from Tasks 1-16.
- Produces: nothing further (terminal task).

- [ ] **Step 1: Full structural re-check**

Re-run Task 16 Step 5's balance check on the final state of `index.html` after all prior tasks'
commits, to catch any drift introduced by later tasks.

- [ ] **Step 2: Manual smoke-test instructions (for whoever has a browser available)**

Open `12t_projects/player-reference-tool/index.html` locally. Confirm: the new "Skill Cooldown/Duration
Lookup" entry appears in the ledger; opening it shows all 12 classes' skills; entering AGI/CHA/LCK
updates the adjusted columns live; the class filter chips and search box narrow the table; the
revisedArt toggle visibly grays/colors its icon and changes adjusted CD values (except for
`revisedArtExempt` skills, which shouldn't change); switching back to the menu and into Stat-Gain still
works (regression check on the existing mounted tool alongside this new one).

- [ ] **Step 3: Update `12t_projects/player-reference-tool/CLAUDE.md`**

Add "Skill Cooldown/Duration Lookup" to the list of mounted tools (currently only Stat-Gain is
documented there as the mounted exception) — note it's the 2nd mounted tool, so the shared-`#toolMount`
bug documented there now has a real, not just hypothetical, second occupant. Flag whether that bug needs
fixing now (it will if this tool's `mount()` and Stat-Gain's `mount()` both write into the same
container — check the current `showTool()` implementation before assuming; it may already have been
fixed in a later session than this plan's context, or may still need the container-reuse fix).

- [ ] **Step 4: Update root `CLAUDE.md` and `HANDOFF.md`**

Update the `player-reference-tool` bullets in both to reflect 3 tools total (Stat-Gain, GoldenKingBug
Spawn Map link-out, Skill Cooldown/Duration Lookup) and the new `12t_reference/*-skill-cooldown-reference.md`
docs (12 new files).

- [ ] **Step 5: Commit**

```bash
git add "12t_projects/player-reference-tool/CLAUDE.md" "CLAUDE.md" "HANDOFF.md"
git commit -m "docs: record Skill Cooldown/Duration Lookup tool across project docs"
```
