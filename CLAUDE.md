# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

@AGENTS.md

## Claude Code specifics

AGENTS.md above is the source of truth; this section only maps it onto Claude Code.

- **Scratch dir:** wherever AGENTS.md / GEMINI.md say `<appDataDir>/brain/<conversation-id>/scratch/`, use the session scratchpad directory instead. Never put one-off scripts in `scripts/` or anywhere in the repo.
- **No browser checks for small changes:** AGENTS.md's "Strict Ban on Routine Visual Checks" (written for Gemini's `browser_subagent`) covers Playwright and Claude in Chrome too. Verify data, formula, text and small fixes with `node scripts/validate_skills.js` and the diff only; open a browser only for a major layout / CSS redesign or when the user asks (user 2026-10-06: too time-consuming).
- **Edit guard:** `.claude/hooks/guard-decompiled-and-data.sh` denies Edit/Write on any `*.cs` file and anything under `RippedAssets/` or `12TailsOnline_Data/`. A denial there is intended, so don't work around it.
- **Root `index.html`** is only a redirect to `12t_projects/bible/`. The real hub is `12t_projects/bible/index.html` (multi-MB). Patch it out-of-process per [12t_projects/bible/CLAUDE.md §1](12t_projects/bible/CLAUDE.md), not with the Edit tool.
- **Bible rulebook:** `12t_projects/bible/CLAUDE.md` holds the core rules (loaded when working in that folder); the topic rules are the `bible-*` project skills below. When a convention changes, update the skill that owns the topic. `GEMINI.md` there is only an index for Gemini / Antigravity, the user's fallback agent (Claude is used ~95% of the time); never put rules in it.
- **No Artifact publishing:** this project is never published as an Artifact (user rule, 2026-10-06). "Push" means `git push` only.
- **Git guard:** `.claude/hooks/guard-index-git.sh` denies `git checkout` / `restore` / `reset --hard` / `stash` commands that would touch `12t_projects/bible/index.html` or its `assets.js` (recover from the scratch-dir backup instead).

### Commands

```sh
node scripts/validate_skills.js                         # the only "test suite": formulas, icons, rank arrays, field loss, doc backlog (no changelog check since 2026-10-20; the entry is still added by habit)
node scripts/validate_skills.js --full                  # also runs the slow range-vs-simulator check (+~35 s); skipped by default unless the index.html diff touches damage code. Run it before every `git push`
node scripts/validate_skills.js --list-doc-backlog      # also name every app skill missing from its <class>-skill-reference.md
node scripts/validate_skills.js --index <copy>/index.html   # validate another copy of the page (its assets.js beside it)

node scripts/bible_assets.js stamp                      # after any change to 12t_projects/bible/assets.js: re-stamp index.html's assets.js?v= (also: split, --selftest)
node scripts/validate_skills.js --allow-field-loss=<cardId:field,...>   # only for deliberate field removals

node scripts/card_edit.js set-field <cardId> <key> <js-source> [--dry-run]   # also: add-field, add-compat [--both], replace
node scripts/card_edit.js --selftest

python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs   # decode cd/castTime/MP/SP/reqLv per skill
node scripts/guide_code.js decode <12TG1.code | file>          # turn a submitted class guide short code into the JSON object to embed (also: encode <json>, --selftest)
node scripts/guide_draft.js layout <class> [server]            # a class's skill-sim rows with cell ids (also: build <draft.json> [out.json] -> checked guide + TG2 code, --selftest)
node scripts/guide_views.js                                     # refresh CLASS_GUIDE_VIEWS (guide readers for ad-blocked browsers) from GoatCounter; by hand only, NOT before commits since 2026-10-20 (user: the live API does the work) (--dry-run: print only)
node scripts/add_guide.js                                       # class guide manager page (queue adds / replaces / removes, publish the batch in one go: views, changelog, --full validator, one commit, push; undo reverses the last batch); double-click scripts/add_guide.cmd
node scripts/add_guide.js add <code> | replace <N> <code> | delete <N>  [--dry-run | --no-push | --yes]   # the same pipeline on the command line
```

### Project skills and agents

- `/sd`: skill-detail research and implementation workflow (`.claude/commands/sd.md`).
- `decode-character-stats`: hex-decodes monster/unit base stats from the binary game data.
- `guide-draft`: drafts a class guide (build, description, skill notes, TG2 code) from a Skill Simulator screenshot and the author's post.
- `mechanics-researcher` agent: read-only tracing of formulas in `DecompiledSource/`.
- Bible topic skills (auto-loaded by task): `bible-desc-writing`, `bible-card-fields`, `bible-damage-model`, `bible-skill-page-ui`, `bible-hub-tools`, `bible-skill-research`.
