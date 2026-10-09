---
name: bible-card-fields
description: "Use when adding a new skill card or adding/changing fields on a SKILLS card in 12t_projects/bible/index.html: card schema (active/passive), stat chips (lckProc labels, secondary chips, chipCols), tooltipNote, bbBug, liveCheck, durAdjust, dmgGroups basics, card order, compatSkills links."
---

# Bible: skill card schema and card fields

Part of the Bible rulebook (core rules: [12t_projects/bible/CLAUDE.md](../../../12t_projects/bible/CLAUDE.md)).

## Card fields for notes and adjusters
* **Card notes fold into chips (2026-10-08, user: they cluttered the default view):** `tooltipNote` (`ⓘ คำอธิบายไม่ตรง`), `bbBug` (`🐞 บั๊ก`) and `unintended` (`⚡ ไม่ตั้งใจ`) render as one small chip each under the description (`.sk-note-chip`); the note itself sits in a hidden `.sk-note-panel` and opens when its chip is clicked (state in `noteOpenState`, kept across re-renders, reset when another card is picked). `liveCheck` stays inline. The note spans keep their old classes, so validators that read the rendered HTML still find them.
* **`liveCheck: "<Thai text>"`** (card field): a value nobody can derive from the code (e.g. a private-server patch that gave no numbers, `servers.tot.liveCheck` on Twin Resonance). Renders as the last line of the description box, `⚠ ยังไม่ยืนยันในเกม: …` (`.sk-live-check`, `--seal`). **A Thai tooltip that disagrees with the code is a `tooltipNote`, never a `liveCheck`** (all eight former tooltip liveChecks were converted 2026-10-02). `[LIVE CHECK ERROR]`.
* **`tooltipNote: "<Thai text>" | (rank) => string`** (card field): the in-game tooltip states a misleading value or rule (base duration, damage, chance, a missing or wrong effect) and the code is verified. Renders under the desc as `ⓘ คำอธิบายในเกมไม่ตรงกับโค้ด: …` (`.sk-tooltip-note`) in the **blue** signature colour `--tip` (user 2026-10-09; bug stays red `--seal`, unintended gold; `[NOTE COLOUR ERROR]`), also on the chip and the BB issues page; a rank-gated note returns `""` for ranks that match. Phrase it "บอกว่า … แต่โค้ดจริงคือ …" with `**values**`. **Compare against the Thai tooltip only** (`<Class>Skill_thai.cs`): players do not read the English one, so a mismatch that exists only in `<Class>Skill_eng.cs` is not listed, and the note quotes the Thai values. A mismatch never goes inline in the `desc` as a red `__คำอธิบายในเกม…__` line (all 50 were moved into `tooltipNote` 2026-10-02); `[TOOLTIP NOTE ERROR]` fails on an inline one and on a `tooltipNote` that renders at no rank. Mere omissions ("the tooltip omits the KO") stay in the class reference only.
* **`durAdjust: "tal"`** (card field, default CHA): the Duration chip runs `talAdjust` with the player's TAL instead of `chaAdjust`, wears the TAL colour (`.sk-stat-dur-tal`, value and accent bar) and makes TAL glow instead of CHA (`getUsedPlayerStatKeys`). Used by Stun Mine on BB (`Mole_stunMine.cs:60`, a BB bug: Landmine uses `chaAdjust`). `[DUR ADJUST ERROR]`.
* **`unintended: "<Thai text>"`** (card field, 2026-10-08): behaviour that follows from the code but cannot have been intended (side effects between two systems, an internal status that the generic purge can reach). Renders gold under the desc as `⚡ พฤติกรรมที่ไม่ตั้งใจ (BB): …` (`.sk-unintended`) and lists on the BB issues page as its own type. Use it instead of `bbBug` when no single line of code is "wrong" by itself. `[UNINTENDED ERROR]` (validator §3t) covers the page and the card note; first uses: `whale_swallow`, `whale_gourmetHeart`, `whale_autoShield`. A card holding two findings joins them with `<br>` in the one string, each with its own credit token.
* **`bbBug: "<Thai text>"`** (card field): the BigBug client code itself misbehaves (a cooldown that is never checked, a bonus that is never applied, a level table that stops growing). Renders red as `🐞 บั๊กของตัวเกม (BB): …` (`.sk-bb-bug`). Cite the source in the class reference.

## General card rules
* **No duration notes (`durNote`, abolished 2026-10-06, user):** the ℹ popup on Duration chips is gone (all 52 notes and the render code removed). Whatever a duration needs explaining goes in the skill `desc`; label the chip with `durLabel` / `secondaryDuration.label` (`"ระยะเวลา " + descriptor`, e.g. "ระยะเวลา Venom Shock").
* **Basic attacks, charge attacks and passives** get cards only when the user asks.
* **Vertical collapse:** never render an empty `.sk-hero-stats` or `.sk-dmg-row`, no artificial min-heights.
* **`dmgGroups`:** must also declare top-level `dmg`/`atkCoeff`/`ko` mirroring the primary group (else `evalArith("")` SyntaxError). Sequential groups' `hitCount`s must sum to the top-level `hitCount(rank, dmgDepOn, hitCountDepOn)` for every dep combination (`[DMGGROUPS HITCOUNT ERROR]`); `dmgModes:true` cards are exempt. Declare `ko` per group when groups differ (`getGroupKOInfo()` splits/merges chips).
* **Per-class `SKILLS` order** follows `<Class>Skill.cs` `getSkillTree()` `result = "<class>_<name><rank>"` order.

## Skill Card Schema & Authoring Standards

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

## Compatible Skills Navigation (`compatSkills`) Conventions

1. Every edge is reciprocated (A lists B ⇒ B lists A). Sibling mesh links allowed.
2. Header exactly `<p class="sk-compat-title">สกิลที่เกี่ยวข้อง</p>` (Prompt, gold 14px). No `LINK`/`MASS CAST`/`MOVES` badges.
3. `.sk-compat-item` 44px flex row; `img.sk-compat-icon` 42×42; `.sk-compat-name` `-webkit-line-clamp:2`.
4. Grids: many → `.sk-compat-grid` (`auto-fill, minmax(170px,1fr)`); 2–4 → `.sk-compat-few-grid` (`auto-fit`, one row); 1 → `.sk-compat-single-grid` (max 340px, `"คลิกเพื่อดูสกิล →"`).
