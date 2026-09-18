# Bat — Skill Damage & Mechanics Reference

## Server Balance Variations (ToT & TTO)

Private-server values below are documented from the Bible skill-detail schema, not the BigBug decompile; the original-server column is the BigBug baseline represented by that card.

| Skill | Server | Original BigBug baseline | Server delta |
|---|---|---|---|
| Mass Cast | TTO | The buff lasts 6 / 9 seconds. | Replaced duration-based spreading with exactly 1 / 2 affected casts at ranks 1 / 2. |
| Mirage Orb | ToT | Allies in the orb receive no `hitMod` reduction. | Allies inside the orb receive `-0.1 hitMod`. |
| Dream Dazzle | TTO | Shattering Dream raises its effective skill level. | Shattering Dream no longer raises its level; the skill uses `talAdjust(10 + 20 × rank)`. |
| Phantasm Blast | TTO | Shattering Dream raises its effective skill level. | Shattering Dream no longer raises its level; the skill uses `talAdjust(10 + 20 × rank)`. |
| Shattering Dream | TTO | Raises Dream Dazzle and Phantasm Blast by one level. | No longer grants either level increase. |

Source of server deltas: `12t_projects/bible/index.html:8443,8516,8664,8696,8910`.
