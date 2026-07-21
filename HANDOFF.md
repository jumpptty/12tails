# Penguin Interactive Skill Infographic — Handoff

Session paused 2026-07-21. Everything below is committed to git; nothing lives only in
conversation history. This doc is the single entry point to resume from a different
machine.

## ⚠️ No remote configured

This repo (`C:\Users\Jump\Desktop\Assembly-UnityScript`) is **local-only** — `git remote -v`
returns nothing. To continue on another machine, either:
- Copy the whole `Assembly-UnityScript` folder (including `.git`) to the other machine, or
- Push to a remote first (GitHub/GitLab/etc.) from this machine, then clone there.

The repo also has **no `.git` history before this session** — it was `git init`'d partway
through (see "Repo setup notes" below). The huge decompiled-game-source tree and ripped
assets (~9.8GB) are **git-ignored** (`RippedAssets/`, `12TailsOnline_Data/`) — only copy
those too if the other machine needs to re-run extraction scripts; they're not needed to
just continue editing the shipped HTML file.

## What this project is

An interactive, single-file HTML skill infographic for the "Penguin" class in a decompiled
Unity MMORPG client (12 Tails Online). Built using the `12tails-class-infographic` skill's
conventions (card layout, chip color coding) but extended with new interactive features:
rank toggles (pick which skill rank to view), a base/plug-in view toggle (symbolic formulas
vs. live-computed numbers from entered character stats), and — newest — Class C passive
synergy toggles (see current work below).

**The shipped file:** `Mechanics-Infographics/12_Penguin_skill-sheet.html` — self-contained,
no build step, no external requests (icons are embedded base64). Open it directly in any
browser.

## Current state (HEAD = `b329dc6`)

Two work streams, both tracked in `.superpowers/sdd/progress.md`:

### 1. Main infographic build — **COMPLETE**
Plan: `docs/superpowers/plans/2026-07-21-penguin-interactive-infographic.md`
Design: `docs/superpowers/specs/2026-07-21-penguin-interactive-infographic-design.md`
Data reference (source of truth for every formula/number): `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md`

All 9 tasks done: icon extraction, page skeleton (aqua theme), formula evaluator, card
renderer, and all 68 skill-tree entries populated across Basic/Class A/Class B/Class C
tiers. Plus 7 retroactive "design corrections" the user requested after reviewing the first
pass (passive cards show no chip row, cumulative stat-bonus display, collapsed rank
arithmetic, rank-invariant notes repeated per rank, default-to-max-rank, talAdjust
coefficient pre-multiplication) — all applied and reviewed clean.

**Task 9 (publish as Artifact) was never done** — the plan's last task, publishing the
sheet via the Artifact tool, was not reached. Do this whenever the sheet is considered
final; it's a delivery step, not a code change (see plan Task 9 for the exact steps —
mainly: grep for external references, then call the Artifact tool).

### 2. Class C synergy toggle feature — **DONE, review interrupted**
Plan: `docs/superpowers/plans/2026-07-21-penguin-classc-toggle.md`
Design: `docs/superpowers/specs/2026-07-21-penguin-classc-toggle-design.md`

Replaces static "needs X" prose bullets with real per-card checkboxes that live-recompute
chips when a Class C passive is toggled ON. All 3 plan tasks done and individually
reviewed/approved, plus 3 follow-up fixes (all reviewed or self-verified):
- `renderSymbolic` parenthesization bug (a formula like `talAdjust(30) × 1.25` displayed
  ambiguously) — fixed, verified against all 48 existing formulas.
- Synergy text now fully hidden until toggled ON (was always showing a "needs X" hint);
  ON-state text is now dark-gold + bold via new `.classc-on` CSS class.
- Rank-toggle buttons and the Class C toggle now share one control row (`.ctrlrow`)
  instead of stacking on separate lines.

**What's NOT done:** a final whole-branch code review was dispatched (covering all 6
commits of this feature) but was **manually stopped mid-run** at the user's request before
finishing — it had gotten partway through verification with no findings yet reported. This
is the very next thing to do if you want a review-gated "done": re-run it (see below).

## Exact next steps

1. **Re-run the Class C toggle final review** (was interrupted, not failed — no findings
   exist yet, good or bad). Base commit `c192d76` (right after the design spec was first
   committed), head `91ae571` (last commit of that feature, before the doc-commit
   `b329dc6`). The full reviewer-dispatch prompt used is reconstructable from this
   conversation's history if using the same tooling, or just manually smoke-test the
   feature: open `Mechanics-Infographics/12_Penguin_skill-sheet.html` in a browser, toggle
   a few Class C checkboxes (e.g. on the manaArc or manaMissile cards) and confirm chips/
   notes update correctly in both Base and Plug-in Stats view, and that OFF state shows no
   synergy text at all (only the checkbox label).
2. **Task 9 of the main plan**: publish `Mechanics-Infographics/12_Penguin_skill-sheet.html`
   via the Artifact tool once satisfied with the Class C toggle feature.
3. Nothing else is blocking — both plans' data population is complete and every skill in
   the class is represented.

## Key files to re-read on resume

- `.superpowers/sdd/progress.md` — the authoritative task-by-task ledger for both plans.
  Trust this + `git log` over any memory of what was done.
- `docs/superpowers/plans/2026-07-21-penguin-interactive-infographic.md` — main plan (9 tasks, all done).
- `docs/superpowers/plans/2026-07-21-penguin-classc-toggle.md` — Class C toggle plan (3 tasks, all done).
- `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md` — every verified
  formula/mechanic for the whole Penguin class, extracted from decompiled source. This is
  the ground truth if any future edit needs to double-check a number.
- `Mechanics-Infographics/12_Penguin_skill-sheet.html` — the actual deliverable.

## Repo setup notes

- Git identity is set locally (not global) to `Jump <jumpthai@gmail.com>` — only affects
  this repo.
- `.gitignore` excludes `RippedAssets/` and `12TailsOnline_Data/` (huge, ~9.8GB) — do not
  remove this exclusion; a stray `git add -A`/`git add .` in this directory would try to
  stage the entire decompiled game.
- The working directory has hundreds of untracked loose `.cs` decompiled source files at
  the repo root (pre-existing, part of the original decompile dump, never intended to be
  tracked) — this is expected and not something to clean up or worry about; only the
  `Mechanics-Infographics/`, `docs/`, and `.superpowers/` paths matter for this project.
