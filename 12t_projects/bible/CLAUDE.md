# Bible hub core rules (`12t_projects/bible/`)

Mandatory rules, UI conventions, card schemas, verification pipeline and file-safety rules for `12t_projects/bible/index.html`. History and rejected designs live in git, not here. Where a rule names a validator error (`[XYZ ERROR]`), `node scripts/validate_skills.js` enforces it.

These core rules apply to every change here. Topic rules live in Claude skills under `.claude/skills/` (Claude Code loads them automatically when a task matches; other agents read the files directly):

| Topic | File |
|---|---|
| player text (desc, change notes, status popups, glossary) | [.claude/skills/bible-desc-writing/SKILL.md](../../.claude/skills/bible-desc-writing/SKILL.md) |
| skill card schema and card fields | [.claude/skills/bible-card-fields/SKILL.md](../../.claude/skills/bible-card-fields/SKILL.md) |
| damage formulas, ranges and the Test simulator | [.claude/skills/bible-damage-model/SKILL.md](../../.claude/skills/bible-damage-model/SKILL.md) |
| skill details page UI and behaviour | [.claude/skills/bible-skill-page-ui/SKILL.md](../../.claude/skills/bible-skill-page-ui/SKILL.md) |
| other hub tools (menu, monster stats, boss guide, BB issues, CHA/AGI optimizer) | [.claude/skills/bible-hub-tools/SKILL.md](../../.claude/skills/bible-hub-tools/SKILL.md) |
| skill research and verification pipeline | [.claude/skills/bible-skill-research/SKILL.md](../../.claude/skills/bible-skill-research/SKILL.md) |

After adding or changing a convention, update the file that owns that topic (not this core, unless it applies to every change).

## 1. Large File Handling & Crash Prevention Protocol (~15 MB)

`index.html` embeds every game icon as base64 (`SKILL_ICONS`, currently ~lines 7,500–10,300; `CLASS_ART` / `CLASS_PORTRAITS` near ~22,100). Line numbers drift; locate blocks with `grep -o`.

1. **Zero base64 ingestion:** never read, grep or dump the base64 blocks. Inspect icon keys with a small Node scratch script that prints key names only.
2. **Out-of-process patching:** every change to `index.html` is a small Node script in the scratch dir that loads the file, replaces the target in memory, writes it back and prints one confirmation line. No IDE edit tools on this file. For card fields use **`scripts/card_edit.js`** (`add-field` / `set-field` / `add-compat [--both]` / `replace`, `--dry-run`): it edits one card's top-level fields only (strings, template literals and `//` / `/* */` comments are skipped while scanning), backs the file up to `<os temp>/12t-bible-backups/` and refuses to save when the page script no longer parses (e.g. a raw line break inside a string). `node scripts/card_edit.js --selftest` checks it.
3. **Git checkpoint before every phase:**
   * A dirty `index.html` = uncommitted card work. Make a local WIP commit before running any patch script. Preserve unrelated changes; don't commit or revert them.
   * **Never run `git checkout` / `restore` / `reset` / `stash` on `index.html`.** Every patch script first copies the file to its scratch folder (`index.<timestamp>.bak`); recover from that copy.
   * **Never replace a whole card line.** Change only the specific fields (one `key:value`, one `compatSkills` id). Retyping a card silently drops fields.
   * `[FIELD LOSS ERROR]`: a card lost a field it had at `HEAD`. Deliberate removal: `--allow-field-loss=<cardId:field,...>`. `[DOC BACKLOG]` counts app skills with no class-reference entry (`--list-doc-backlog` lists them).
4. **Changelog gate & verification:** before committing, prepend a `CHANGELOG_DATA.entries` item with the current ISO timestamp and the **exact planned commit subject**, then run `node scripts/validate_skills.js` (skills, formula permutations per rank and dep, icons).

## 2. Deliverable basics

* **Self-contained single file** that runs by double-click, no server.
* **"Ledger" design system:** lacquer ground `#141311`, brass-gold `#d4af37`, oxblood `#8b1e1e`, high-contrast type.
* **Theme (2026-10-05, user):** dark by default. `<script id="themeBoot">` in `<head>` sets `data-theme` before first paint from `localStorage["12t-bible-theme"]` (only `"light"` overrides) and wires the sun / moon button `#btnTheme` at the right end of the hub bar. Style every colour for both `:root[data-theme="dark"]` and `[data-theme="light"]`; the `prefers-color-scheme` blocks stay for completeness but the attribute is always set. Every extra `<script>` must carry an attribute (an id): the validator runs the main app script as the text from the first plain `<script>` tag to the last closing tag, so a bare script tag, or that literal tag text in a comment, breaks it.
