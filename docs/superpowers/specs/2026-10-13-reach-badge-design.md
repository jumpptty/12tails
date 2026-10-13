# Skill Details: range badge with a 3D hit box

Date: 2026-10-13. Tool: Skill Details (`mountSkillCooldownLookup` in `12t_projects/bible/index.html`).

## Goal

Every skill with a verified reach gets a small badge on its card showing the headline size. Opening the badge shows a rotatable 3D hit box beside a player marker, with the dimensions labelled. The reach wording moves out of each `desc` into a structured `reach` field, so the badge and popup are the only place the numbers appear.

Today about 370 desc lines carry reach text (`รัศมี **Nm**`, `ระยะ **Nm**`, `กว้าง / ยาว / สูง`, cone angles). The rule that requires it is in `.claude/skills/bible-desc-writing/SKILL.md` ("Every `desc` states its reach"); this feature replaces that rule.

## Decisions (agreed with the user, 2026-10-13)

1. **Display:** a small badge (like the KO badge, not a big chip) plus a popup with a live, rotatable 3D shape next to a player marker, dimensions labelled.
2. **Data:** a structured `reach` field per card. The reach clause is removed from the desc.
3. **Extraction:** a scratch script proposes a `reach` object per card from the desc patterns; the user reviews a table per class before anything is applied.
4. **Renderer:** a small custom canvas renderer (about 150 lines), not Three.js. The hub must stay one self-contained file and inlining Three.js would add roughly 600 KB for shapes this simple.
5. **Rollout:** Panda first, review with the user, then the other 11 classes.

## Non-goals

- Lock time / animation time (dropped for now; the scratch decode is not kept).
- Hit boxes the code does not give. A size that lives only in a prefab or animation is marked `unknown`, never drawn from a guess.
- Moving projectiles' paths or timing. The shape is the hit volume at the moment it applies.

## Design

### `reach` field

A card gets `reach`: an array of parts (usually one). Each part:

| Key | Meaning |
|---|---|
| `shape` | `sphere`, `cylinder`, `box`, `cone`, `line` |
| `r`, `h`, `w`, `l`, `angle` | metres (degrees for `angle`); full width / length, not half. Any value may be a function of rank |
| `anchor` | `self`, `target`, `fist`, `projectile`; where the volume is centred or starts |
| `label` | short Thai name when a card has several parts (e.g. a blast and a splash) |
| `rangeMod` | true when the code multiplies the size by the caster's `rangeMod` |
| `src` | `file:line` citation from `DecompiledSource/` |
| `unknown` | true when the size is only in a prefab; no shape is drawn, the badge says so |

A cast or target distance (not a volume) is a `line` part with `anchor:"self"`. Self skills use `{shape:"self"}` with no dimensions and show a plain badge.

The Bible's 3D rule holds: a `FindAreaTarget` circle is a cylinder (radius plus the `TargetHeight` argument), a flat `findEnemies` / `findFriends` range is a cylinder with `h:"inf"` (drawn tall, labelled `ไม่จำกัดความสูง`), and a `SphereCollider` or full-3D distance check is a sphere. See [12Tails-Mechanics-Reference.md](../../../12t_reference/12Tails-Mechanics-Reference.md) §4.

### Badge

A small `.sk-reach-badge` beside the KO badge: a tiny shape icon and the headline number (`r 5m`, `6×2×3`, `40m`). It is a button; click or hover opens the popup. Cards with `unknown` show `?`.

### Popup

A canvas with:

- a player marker (a small capsule at the origin, 1 m grid under it),
- the shape as translucent faces and edges, projected with a simple rotation matrix,
- drag to rotate, wheel or pinch to zoom, double-click to reset,
- dimension labels in metres, `rangeMod` noted when set, multiple parts in separate colours with a legend.

No dependency. Uses `prefers-reduced-motion` (no auto-spin) and works with touch.

### Extraction pipeline

1. A scratch script (never in `scripts/`) reads the SKILLS cards and matches the common reach patterns in each desc, producing a proposed `reach` plus the exact sentence it would remove.
2. Output is a review table per class: card, proposed `reach`, sentence to remove, confidence. Unmatched or ambiguous cards are listed separately for manual handling.
3. After the user approves a class, edits go in through `scripts/card_edit.js` (`add-field` for `reach`, `replace` for the desc), with a scratch-dir backup of `index.html` first and one dry-run per batch.
4. **Every skill is reviewed one by one against `DecompiledSource/` (user decision, 2026-10-13).** The script's proposal is only a starting point and is never applied in bulk. For each skill I read the source, confirm the shape and every number, and decide whether the size is rank-dependent (function form) or scaled by the caster's `rangeMod`. The citation goes in `src`, and the class reference's reach notes are updated where they disagree.

### Validator (`scripts/validate_skills.js`)

- `[REACH ERROR]`: a part has a shape without its required dimensions, a non-positive size, an unknown `anchor`, or a missing `src` (unless `unknown`).
- `[REACH DESC ERROR]`: a card with a `reach` field still contains a reach clause (`รัศมี **`, `ทรงกลมรัศมี`, `กว้าง **`) in its desc. A card with no `reach` and no `unknown` gets a `[REACH BACKLOG]` count (not an error until the roll-out finishes).
- Field-loss gate: unchanged; the desc change is a deliberate removal covered by the normal diff.

### Docs

- `bible-desc-writing`: replace the "Every `desc` states its reach" rule with "reach lives in `reach`; the desc never states a size".
- `bible-card-fields`: document `reach` and the badge.
- `bible-skill-page-ui`: the badge and popup.
- Changelog entry on every commit touching `index.html` (existing gate).

## Pilot: Panda

Panda is first because its boxes are already documented (`panda-skill-reference.md`, "Geometry notes"). The pilot delivers the renderer, the badge, the validator checks and Panda's cards. Roll-out to the other classes follows once the user approves the pilot.

## Testing

- `node scripts/validate_skills.js` covers the schema and desc checks.
- One browser check of the popup is allowed because this is a new UI component (the rule against routine visual checks is for small fixes): rotate, zoom, multi-part card, `unknown` card, phone width.
- Golden test per shape type in the validator: projected bounds of a known box and sphere.

## Risks

- `index.html` is multi-MB: all edits go through `card_edit.js` with backups, never the Edit tool.
