# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

@AGENTS.md

## Claude Code specifics

AGENTS.md above is the source of truth; this section only maps it onto Claude Code.

- **Scratch dir:** wherever AGENTS.md / GEMINI.md say `<appDataDir>/brain/<conversation-id>/scratch/`, use the session scratchpad directory instead. Never put one-off scripts in `scripts/` or anywhere in the repo.
- **Edit guard:** `.claude/hooks/guard-decompiled-and-data.sh` denies Edit/Write on any `*.cs` file and anything under `RippedAssets/` or `12TailsOnline_Data/`. A denial there is intended, so don't work around it.
- **Root `index.html`** is only a redirect to `12t_projects/bible/`. The real hub is `12t_projects/bible/index.html` (multi-MB). Patch it out-of-process per [12t_projects/bible/CLAUDE.md §1](12t_projects/bible/CLAUDE.md), not with the Edit tool.
- **Bible rulebook:** `12t_projects/bible/CLAUDE.md` holds the core rules (loaded when working in that folder); the topic rules are the `bible-*` project skills below. When a convention changes, update the skill that owns the topic. `GEMINI.md` there is only an index for Gemini / Antigravity, the user's fallback agent (Claude is used ~95% of the time); never put rules in it.
- **Git guard:** `.claude/hooks/guard-index-git.sh` denies `git checkout` / `restore` / `reset --hard` / `stash` commands that would touch `12t_projects/bible/index.html` (recover from the scratch-dir backup instead).

### Commands

```sh
node scripts/validate_skills.js                         # the only "test suite": formulas, icons, rank arrays, changelog gate, field loss, doc backlog
node scripts/validate_skills.js --list-doc-backlog      # also name every app skill missing from its <class>-skill-reference.md
node scripts/validate_skills.js --allow-field-loss=<cardId:field,...>   # only for deliberate field removals

node scripts/card_edit.js set-field <cardId> <key> <js-source> [--dry-run]   # also: add-field, add-compat [--both], replace
node scripts/card_edit.js --selftest

python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs   # decode cd/castTime/MP/SP/reqLv per skill
```

### Project skills and agents

- `/sd`: skill-detail research and implementation workflow (`.claude/commands/sd.md`).
- `publish-player-reference-tool`: publishes the bible hub to its live Artifact URL.
- `decode-character-stats`: hex-decodes monster/unit base stats from the binary game data.
- `mechanics-researcher` agent: read-only tracing of formulas in `DecompiledSource/`.
- Bible topic skills (auto-loaded by task): `bible-desc-writing`, `bible-card-fields`, `bible-damage-model`, `bible-skill-page-ui`, `bible-hub-tools`, `bible-skill-research`.
