# Bible on Cloudflare Pages: Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Status (19/11/2026):** recorded only. The user asked for the plan first; no step has been started. Start only when the user says so.

**Goal:** serve the 12 Tails Bible from Cloudflare Pages (free, `<project>.pages.dev`) while the GitHub Pages site stays up, and switch GitHub to a redirect only when the user decides.

**Architecture:** the repo stays on GitHub. Cloudflare Pages connects to it through its Git integration and deploys the folder `12t_projects/bible/` on every push to the production branch, so one `git push` updates both sites. Every change in Phase 1 must keep the GitHub site working. Phase 2 (path URLs, link previews, own view counter) gets its own plans later.

**Tech Stack:** static `index.html` + `assets*.js`; Cloudflare Pages (`_headers`, later `_redirects` and Pages Functions); the existing Cloudflare Worker `12t_projects/donate-worker` (deployed by the user with `npx wrangler deploy`).

**Spec:** no separate design doc. The decisions came from the conversation of 19/11/2026 and are listed under Decisions below.

## Decisions (user, 19/11/2026)

- Move the hosting only; the code stays on GitHub. Step 1 = move and keep GoatCounter. Step 2 (own counter) only after the new address is settled.
- The GitHub site stays up during the whole transfer; at the end the user chooses: GitHub becomes a redirect that keeps the `#…` part, or both stay up with the canonical link on the new site.
- Free address only: Cloudflare Pages `<project>.pages.dev` (no account part, unlike `<worker>.<account>.workers.dev`). Project name: `12tails`, else `12tails-bible`. A paid domain (about US$10 a year) is not planned.
- Do not rename the `jumpthai` workers.dev account subdomain as part of this work: it would change the donate Worker's address (`12tails-donate.jumpthai.workers.dev`), which the Bible calls.

## Facts measured (19/11/2026)

- `assets.js` is 37,243,086 bytes (35.5 MiB): over the 25 MiB per-file limit of Pages and Workers static assets (all plans). Biggest containers: SKILL_ICONS 14.97 MiB, GEAR_ICONS 6.09, REACH_MODELS 4.84, SKILL_ICONS_R0 2.29, STATUS_ICONS 2.06, the other 19 together about 5.3 MiB.
- `index.html` is 7.7 MB. The repo publishes 257 files (about 60 MB); the Bible links to no sibling project, so publishing `12t_projects/bible/` alone is enough.
- First visit downloads about 27.4 MB compressed (2.1 + 25.3 MB gzip). GitHub Pages: soft limit 100 GB a month, `Cache-Control: max-age=600`. Cloudflare: static asset requests free and unlimited; only requests that run a Function count toward 100,000 a day.
- GitHub addresses hard-coded today: `index.html` (canonical link, the copy-notice host check at the top of `<head>`, the share-link fallback), `scripts/add_guide.js` (`SITE`), `12t_projects/donate-worker/src/discord.js` (`SITE`, CORS `ORIGINS = [SITE, "null"]`), `src/guides.js` (`PAGE`, links in Discord), the worker tests.

## Global Constraints

- Every Phase 1 change keeps the GitHub site fully working (both hosts serve the same files until the switch).
- `index.html` edits only through out-of-process scripts with a scratch backup ([12t_projects/bible/CLAUDE.md](../../../12t_projects/bible/CLAUDE.md) §1); CRLF kept; no whole-card retypes.
- `node scripts/validate_skills.js` passes before every commit; `node scripts/bible_assets.js stamp` after any change to an asset file.
- Commit and push only when the user asks; a changelog entry with each commit that touches `index.html` (habit).
- The page still opens by double-click (file://) with all its pictures.
- No Cloudflare secrets or tokens in the repo; anything that needs the user's Cloudflare login (Pages project, Worker deploy, D1) is the user's step, written as a checklist for them.

## Review Focus

- Double-clicked local copy (file://): both asset files load and every container is filled (Task 1 test: the validator loads the page with both files).
- A Cloudflare preview deployment (`<hash>.<project>.pages.dev`, `<branch>.<project>.pages.dev`) and Google Translate's proxy for the new host must not show the "this is a copy" banner (Task 2 test).
- The donate Worker answers both origins during the parallel period, and still `null` (Task 2 test in `donate-worker/test.mjs`).
- Old shared links `…/12tails/12t_projects/bible/#skill-details/<id>?server=tto` land on the same card after the switch (Task 4 test: the redirect keeps hash and query).
- A visitor with the old cached `assets.js` and the new `index.html`: the stamp (`?v=`) per file forces the new files (Task 1 test: each script tag carries its own file's stamp).

---

### Task 1: Split `assets.js` under the 25 MiB limit

**Files:**
- Modify: `scripts/bible_assets.js` (MANIFEST gains a file per container; `stamp`, `split`, `--selftest`)
- Create: `12t_projects/bible/assets-2.js` (written by the tool, not by hand)
- Modify: `12t_projects/bible/assets.js`, `12t_projects/bible/index.html` (one `<script>` per asset file), `scripts/validate_skills.js`, `scripts/build_move_icons.py` and `scripts/build_skill_icons_r0.py` (they read / write SKILL_ICONS: stay on the file that holds it)

**Interfaces:**
- Produces: asset files `assets.js` (SKILL_ICONS, SKILL_ICONS_R0, STATUS_ICONS: about 19.3 MiB) and `assets-2.js` (every other container: about 16.2 MiB); each file starts with `var BIBLE_ASSETS = BIBLE_ASSETS || {};` (a second file must not reset the first); tags `<script src="assets.js?v=<stamp>" id="bibleAssets">` and `<script src="assets-2.js?v=<stamp2>" id="bibleAssets2">`, both before the main script; `BIBLE_ASSETS_IN` unchanged for the page code.

- [ ] **Step 1:** validator tests first: `[ASSET SIZE ERROR]` when any asset file is over 24 MiB (25,165,824 bytes; a 1 MiB margin under the limit); `[ASSET VERSION ERROR]` checks each tag's stamp against its own file; `[ASSET FORMAT ERROR]` accepts the new first line and checks every MANIFEST container is in exactly one file; the validator's sandbox loads every asset file in the tags' order and fails when a container ends up empty. Run the validator: the size check fails on today's 35.5 MiB file.
- [ ] **Step 2:** `bible_assets.js`: MANIFEST maps each container to `assets.js` or `assets-2.js`; `split` moves the blocks, `stamp` writes one stamp per file; `--selftest` covers a two-file round trip and the size guard.
- [ ] **Step 3:** run `node scripts/bible_assets.js split`, then `stamp`; check the two Python builders still find SKILL_ICONS / SKILL_ICONS_R0 in `assets.js`.
- [ ] **Step 4:** `node scripts/bible_assets.js --selftest` and `node scripts/validate_skills.js` pass; open the page by double-click and on the GitHub site after push: icons, 3D previews, sounds, QR all present, no "assets.js did not load" warning.
- [ ] **Step 5:** update the core rule ([12t_projects/bible/CLAUDE.md](../../../12t_projects/bible/CLAUDE.md) §1 and §2: "index.html plus its asset files") and commit when the user asks.

Ceiling: one container (SKILL_ICONS) may itself pass 24 MiB one day; then the tool needs a container split across files (`Object.assign` into the same container). Not built now.

### Task 2: Make the page and the donate Worker accept both hosts; Cloudflare cache headers

**Files:**
- Modify: `12t_projects/bible/index.html` (copy-notice host check), `12t_projects/donate-worker/src/discord.js` (`ORIGINS`), `12t_projects/donate-worker/test.mjs` (+ `test_lists.mjs`, `test_guides.mjs` where they pin the origin), `scripts/validate_skills.js`
- Create: `12t_projects/bible/_headers`

**Interfaces:**
- Produces: `OFFICIAL_HOSTS` in the copy-notice script = `jumpptty.github.io`, `jumpptty-github-io.translate.goog`, `<project>.pages.dev`, its translate host (`<project>-pages-dev.translate.goog`), and any host ending in `.<project>.pages.dev` (previews); `ORIGINS = [SITE, "https://<project>.pages.dev", "null"]` (previews are not allowed to submit).
- `_headers`: `/` and `/index.html` → `Cache-Control: no-cache` (always revalidate, so an update shows at once); `/assets*.js` → `Cache-Control: public, max-age=31536000, immutable` (safe: every new file has a new `?v=` stamp).

- [ ] **Step 1:** tests first: validator `[COPY NOTICE ERROR]` runs the copy-notice host check for each official host (no banner) and for `example.com` (banner); `donate-worker/test.mjs` sends both origins (allowed) and a third one (refused). Both fail now.
- [ ] **Step 2:** implement the host list and `ORIGINS`; write `_headers`.
- [ ] **Step 3:** `node scripts/validate_skills.js` and `node 12t_projects/donate-worker/test.mjs` pass.
- [ ] **Step 4:** user step: `cd 12t_projects/donate-worker && npx wrangler deploy`. Then commit (both sites keep working: GitHub ignores `_headers`).

### Task 3: Cloudflare Pages project (user, in the dashboard; Claude checks)

**Files:** none (dashboard settings, written down in [12t_projects/bible/CLAUDE.md](../../../12t_projects/bible/CLAUDE.md) "Hosting" when done).

- [ ] **Step 1 (user):** Workers & Pages → Create → Pages → Connect to Git → the GitHub repo; project name `12tails` (else `12tails-bible`); production branch `skill-cooldown-lookup` (or `main` if the planned rename is done first); framework preset None; build command empty; build output directory `12t_projects/bible`.
- [ ] **Step 2 (Claude):** check a preview deployment of a test branch, then production: the page loads, both asset files answer 200 with the `_headers` values (`curl -sI`), no copy banner, the ☕ donor list and guide list load (CORS), a skill open records a GoatCounter hit, the hash deep link `/#skill-details/monkey_ja_detonate?server=tto` opens the card.
- [ ] **Step 3:** write the setup and the address into the hosting notes (CLAUDE.md, AGENTS.md §2 "Bible Hub") and into memory; GitHub stays the canonical site for now.

### Task 4: The switch (only when the user decides)

**Files:**
- Modify: `12t_projects/bible/index.html` (canonical link, the "original" link in the copy notice and the header comment), `scripts/add_guide.js` (`SITE`), `12t_projects/donate-worker/src/guides.js` (`PAGE`)
- Create: branch `github-redirect` with `index.html` and `12t_projects/bible/index.html`, each a tiny page doing `location.replace("https://<project>.pages.dev/" + location.search + location.hash)` plus a plain link

**Interfaces:**
- Consumes: the project address from Task 3.

- [ ] **Step 1:** test first: a scratch Node check runs the redirect page's script with sample `location` values (`#skill-details/monkey_ja_detonate?server=tto`, `#class-guide/12`, empty) and asserts the target keeps hash and query.
- [ ] **Step 2:** user chooses: (a) GitHub Pages source → branch `github-redirect` (GitHub then serves only the redirect; pushes to the main branch update Cloudflare only), or (b) keep both up and only move the canonical link.
- [ ] **Step 3:** update canonical, `SITE`, `PAGE`; validator passes; user redeploys the donate Worker; commit.

## Phase 2: separate plans when the user starts them (decisions so far)

- **Path URLs** (`/skill/<id>`): `_redirects` line `/* /index.html 200` (Pages also treats a site with no top-level `404.html` as a single-page app); the router reads the path and the old `#skill-details/<id>`, writes paths only on the Cloudflare host (GitHub cannot serve them). About 2-3 h.
- **Per-skill link previews:** a Pages Function on `/skill/*` puts the skill's name, description and icon into the `<meta>` tags (Discord / LINE bots do not run JavaScript); `_redirects` rules do not apply to Function routes, so the app fallback for those paths lives in the Function. Icons as static files built at deploy (a build command). About half a day.
- **Own view counter (replacing GoatCounter):** Pages Functions on the same address (`/api/view`, `/api/count`, not blocked by ad blockers like `gc.zgo.at` is) with a D1 table of counts per path; free limits 100,000 writes and 5 million reads a day (enforced since 01/09/2026); answers cached at the edge for 10 minutes; GoatCounter totals imported once; `CLASS_GUIDE_VIEWS` and `scripts/guide_views.js` retired; `estimatedReaders` (×5.0-7.0) kept. About a day.
