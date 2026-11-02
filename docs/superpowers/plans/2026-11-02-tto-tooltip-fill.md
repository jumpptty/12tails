# TTO tooltip fill: TTO's own in-game tooltip on every card with a TTO skill

Status: not started (planned 2026-11-02). Needs the updated `DecompiledSource_TTO_2026-11-02\` folder (CLAUDE.md's pending line says how to get it onto a PC).

**How to run it (user 2026-11-02):** mechanical work, done by one session with scratch scripts: no Workflow and no subagents (the user's usage is limited). Ask only if something is truly blocked.

## What exists

- TTO's client is decoded offline in `DecompiledSource_TTO_2026-11-02\` (git-ignored). Read its `BUILD.md` section "Tooltip texts" and `tooltips\FORMAT.md` first.
- `tooltips\<class>.json` (12 files) from `tools\skill_tooltips.py`: `skills[]` → `card` (the Bible card id) → `ranks[]` with `skill`, `displayName`, `desc_th` / `desc_en`, `header`, and for 369 of the 1,209 ranks a ready-made `ttoTip` object. Every skill maps to a card (668 cards).
- The field and its renderer exist: `.claude/skills/bible-card-fields/SKILL.md` (`ttoTip` entry: TTO-only cards carry it at the top level, original cards in `servers.tto`; any key may be `(rank) => value`) and `bible-skill-page-ui` ("TTO's own tooltip"). Putting `servers.tto` on a card that has none gives it a TTO tab: the user agreed to that.
- Already filled (commit `ca355f2`): the 36 TTO Lv 100 cards, plus 11 original cards (`wolf_secondWind`, `wolf_sublimeArt`, `bison_rageControl`, `panda_spiritFist`, `whale_reducedCast`, `cat_openWound`, `cat_supportFire`, `chameleon_clearArrow`, `sheep_worldEncarta`, `penguin_focusIntellect`, `bat_autoMass`). Leave those as they are. `totC6Toggle` merges into an existing `servers.tto`, so a literal `ttoTip` there survives.

## Steps

1. **Extractor.** 840 ranks have descriptions only, because their `SkillDetailData` builder takes the rank (e.g. `SkillDetailData::CatAwareness(int lv)`: radius `M(lv*12)`, a `Sec(<float>)` cooldown; registered in loops in `SkillDetailData::Add<Class>`; the pseudo-C is in `pseudo_tooltips\SkillDetailData.c`). Extend `tools\skill_tooltips.py` to run each such builder once per rank (`param_1` = rank, floats read with capstone like the rest), regenerate the 12 JSON files, and check: the output for builders that don't take a rank is byte-identical to today's, two runs match, and a few ranks are spot-checked by hand.
2. **Fill.** One scratch script (`card_edit.js` `findCard` / `scanCard` / `addField`, CRLF, dry run first, then one write) copies `ttoTip` from the JSON onto every remaining card; multi-rank cards get per-rank values. Skip and list:
   - cards whose rank count differs from TTO's (e.g. `mole_kingKaiser`: 3 ranks in the Bible, TTO has rank 1 only);
   - the five shared Common skills (Revised Art / Magic / Skill, Stat Plus, Super Stat Plus) if their 12 class texts differ (they are authored once);
   - cards whose existing BB `tooltipNote` would sit next to TTO's text: list them with both texts and decide each one (blank it on the TTO tab with `tooltipNote: ""` in `servers.tto`, rewrite it, or keep it), as was done for Second Wind, Clear Arrow and World Encarta.

   Labels the game stores double-encoded: follow the `ttoTip` entry's rule (Chain Lightning).
3. **Compare** (a script, no fixes): each tooltip's MP / SP and its cooldown, cast and duration rows against the card's own fields on the TTO tab. Write the differences to a list in the scratch dir and report the count; don't fix them in this session.
4. **Docs.** Update the `ttoTip` entry in bible-card-fields (coverage, how to refill after a TTO patch) and `BUILD.md` "Tooltip texts" (the per-rank builders).
5. **Finish.** `node scripts/validate_skills.js` (plain is enough, no damage code changes), add the `CHANGELOG_DATA` entry with the commit subject, commit, then ask the user before pushing. Mark this plan done.
