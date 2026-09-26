# Skill Details: one strip for all dependency icons

Date: 2026-09-26. Tool: Skill Details (`mountSkillCooldownLookup` in `12t_projects/bible/index.html`).

## Goal

Dependency icons (the toggles and rank-cycle buttons for passives, gear and target states) currently sit in several places on a card. Each one fights for space where it lands:

- the top-right corner of stat chips
- the damage formula header
- the right edge of the description
- the KO badge
- the shield header

This revamp moves every one of them into a single strip on the card, so the chips, headers and description keep only their own content.

## Decisions (agreed with the user)

1. **Location:** one strip between the hero header/description and the stat chip row.
2. **No title:** the strip has no heading such as "ตัวปรับสกิล". Players recognise the items from their icons.
3. **Item content:** each item shows the icon, the dep's short name, and a small tag for what it changes.
4. **Implementation:** the sink pattern (below), not a central field collector or a CSS-only move.

## Design

### Sink

- `renderHero()` creates one sink per render: an ordered map keyed by `dep.id`.
- Each existing render site calls `depSink.add(dep, tag)` in place of returning button HTML, and returns `""`. The site already knows what it modifies, so it passes the matching tag.
- A dep added twice keeps one entry and merges its tags. For example, Miracle Drop is on both golden-potion chips (`CHANCE`), and Open Wound changes damage and duration (`DMG · DUR`).
- The order in the strip is the order the sites add them: description, cooldown, cast, duration, chances, damage, KO, shield. This follows the card's reading order.

### Render sites that move into the sink

| Site | Today | Tag |
|---|---|---|
| `descDep` description toggle | `descDepToggle` (`.sk-hero-desc-toggle`) | `INFO` |
| Cooldown chip `cdDep`, `cdMultDep` | `renderDepBlock` (+ `.sk-dep-secondary`) | `CD` |
| Cast chip `castDep` | `renderDepBlock` | `CAST` |
| Duration chip `dep` | `renderDepBlock` | `DUR` |
| `lckProc.dep`, `secondaryLckProc.dep` | `renderDepBlock` | `CHANCE` |
| Summon stat-table header deps (Fire Soul, King Kaiser Lv, Heavy Built, Hidden Turret, Synchro Mole, Double Bot, Titan Sword, Aegis, Earth Soul) | `renderDmgToggle` / `renderDmgRankToggle` | `STATS` |
| Damage header: `effectProc.controls`, `dmgControls`, Focus Intellect, `dmgDep`, `dmgMultDep`, `lckDiffDep`, `dmgReplaceDep`, `dmgFlagDep`, `dmgRankDep`, own-stats deps, Cat Power, Cat Combo controls | `renderDmgToggle` / `renderDmgRankToggle` / `renderCatComboControls` / `renderCatPowerToggle` | `DMG` |
| `hitCountDep` | `renderDmgToggle` | `HITS` |
| `koDep`, `koMultDep` | `renderDmgToggle` in the KO badge | `KO` |
| Shield header: Focus Intellect, `shieldDep`, `shieldRankDep` | `renderDmgToggle` | `SHIELD` |

- A card that also shows another non-dep control in the damage header keeps that control where it is. This covers the SP, HP, weight and height inputs, and the Nine Steps rows. Only dependency buttons move.
- Cat Combo's controls (Hidden Blade, Power, Charge, No Chance) become four ordinary strip items.
- Cat Power keeps its TTO rule: when `isCatPowerApplicable` is false, nothing is added.

### Strip markup and style

- **Markup:** `<div class="sk-dep-strip">` containing one `.sk-dep-item` per entry.
  - Each item holds the existing button: `.sk-dep-toggle` for a 0/1 dep, or `.sk-dep-rank-icon` for a rank cycle.
  - The button keeps its current `data-dep-*` attributes, so the existing click handlers (`$$(".sk-dep-toggle", displayEl)` and the rank-icon handler) keep working unchanged.
  - After the button: the name (`dep.label`), then the tag pills.
- **Size and states:** the icon is 40px, the current standard. On/off and hover states are unchanged (grayscale when off). The name uses Prompt at 12px in the muted colour, and the tag pills use 10px uppercase in the stat colour tokens:

  | Tag | Colour token |
  |---|---|
  | `CD` | `--stat-agi` |
  | `CAST` | `--stat-int` |
  | `DUR` | `--stat-cha` |
  | `CHANCE` | `--stat-lck` |
  | `DMG` | `--stat-atk` |
  | `HITS` | `--stat-atk` |
  | `KO` | `--stat-atk` |
  | `SHIELD` | `--stat-def` |
  | `STATS` | `--stat-vit` |
  | `INFO` | muted |

- **Wrapping:** items wrap on narrow widths (`flex-wrap`, 8px gap).
- **Empty strip:** a card with no deps renders no strip at all (vertical collapse rule, GEMINI.md §2).
- **Layout:** the strip sits inside the hero card, so `fitStageToScreen()` still scales the whole composition. Under 900px it is one more block in the stacked column.

### CSS removed

These rules have no job once the icons leave their old homes:

- `.sk-dep` absolute corner positioning and `.sk-dep.sk-dep-secondary`
- the `stats5` dep-icon override added 2026-09-26
- `.sk-dmg-toggles`' fixed 28px height and negative margin
- `.sk-hero-desc` `padding-right:56px` / `.has-desc-toggle`
- the KO-badge dep icon sizing

### Unchanged behaviour

These do not change:

- dep ids, default ranks and rank cycling
- `descDep` text substitution
- `getDepRank` / `depRanks`
- `DEP_EXCLUSIVE` handling
- every damage, range, simulator, duration and chance calculation
- stat-glow rules (`getUsedPlayerStatKeys` reads card fields, not DOM)

Only the DOM location of the buttons changes.

## Validation

A new section in `scripts/validate_skills.js`, `[DEP STRIP ERROR]`, run on every selectable skill (the existing 594 hero renders):

1. No `.sk-dep-toggle` or `.sk-dep-rank-icon` exists outside `.sk-dep-strip`.
2. Each dep id appears at most once in the strip, and every item has at least one tag.
3. A card with no deps renders no `.sk-dep-strip`.
4. Clicking a strip button changes `depRanks` exactly as before, on a toggle card (Three Knives) and a rank card (Alchemist Lab).
5. Spot checks:
   - Open Wound on Disarm shows `DMG` and `DUR`.
   - Miracle Drop on Miracle Blend appears once with `CHANCE`.
   - The Cat Power item is absent on TTO for a Tree B card.

All existing validator sections must keep passing. This is a major layout change, so a visual check is allowed by AGENTS.md. The Playwright browser is currently disconnected, so the user will eyeball a sample of cards: Flying Dagger, Miracle Blend, Combo, King Kaiser, Arctic Wind, and one card with no deps.

## Documentation

- **GEMINI.md:** replace the "Skill Dependency Icon Sizing & Hover Glow" placement rules (§2) with the strip, and note that new deps go through `depSink.add(dep, tag)`.
- **Other GEMINI.md notes:** drop the `stats5` icon note. The `renderDmgToggle` / `renderDepBlock` references elsewhere become "adds to the sink".

## Out of scope

- Glowing the matching chip when a dep is on (possible later).
- Changing any dep's id, default or wording.
