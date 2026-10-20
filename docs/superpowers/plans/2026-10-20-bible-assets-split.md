# Bible Assets Split Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Move the 24.4 MB of embedded images, 3D models and sounds out of `12t_projects/bible/index.html` into a versioned `12t_projects/bible/assets.js`. `index.html` drops from 29.9 MB to about 5 MB. A push then costs returning visitors about 2 MB instead of 19 MB, and the file stays far from GitHub's 50 / 100 MiB limits.

**Architecture:** `assets.js` defines one global, `var BIBLE_ASSETS = {}`, with one `BIBLE_ASSETS.<NAME> = <JSON>;` block per container. `index.html` loads it with `<script src="assets.js?v=<stamp>" id="bibleAssets"></script>`, placed just before the main `<script>`. In the main script, each moved declaration keeps its name and its place, but its value becomes `BIBLE_ASSETS_IN.<NAME> || {}`. The literal-only assignment lines that used to add to a container are merged into that container's JSON and deleted from the main script. A one-time `split` command does the migration from a fixed manifest, and proves that every container's value is identical before and after. The validator loads `assets.js` into its sandbox, checks the version stamp, and caps how much data-URI weight may creep back into `index.html`.

**Tech Stack:** Node (no npm dependencies: `fs`, `vm`, `crypto`, `assert`); playwright-core for the one browser smoke test (already on this PC, see Task 4).

**Spec:** the user's decisions in the 2026-10-20 session:
- Do the image split.
- Keep the same link and deep links.
- A downloaded single `index.html` without its images is fine.
- Start with the simple version: the app waits for `assets.js`. The "app loads first, icons fill in later" variant is a possible later step and is out of scope here.

## Global Constraints

- Same public URL and deep links: `index.html` stays at `12t_projects/bible/index.html`; `assets.js` sits next to it and is referenced by a relative path.
- Opening `index.html` by double-click (file://) from the folder must keep working: classic `<script src>` only, no `fetch`, no modules.
- The asset URL carries `?v=` + the first 10 hex characters of the SHA-256 of `assets.js`'s bytes. The validator fails with `[ASSET VERSION ERROR]` when the stamp in `index.html` is different.
- `index.html` may keep at most 400 KB of `data:` URI text in total (today 274 KB will remain, mostly CSS backgrounds). Over that, the validator fails with `[ASSET BUDGET ERROR]` and tells you to move the data to `assets.js`.
- `assets.js` holds data only: run in an empty `vm` context, it may define no global except `BIBLE_ASSETS`, and every value must survive a JSON round trip.
- Every extra `<script>` must carry an attribute (bible CLAUDE.md §2). The new tag has `id="bibleAssets"`.
- `index.html` is CRLF. Write every new line as CRLF, and back the file up to the scratchpad before each scripted edit (bible CLAUDE.md §1). Never `git checkout` / `restore` / `reset` / `stash` it.
- Never read or print base64. Scripts print key names and sizes only.
- Git writes run through PowerShell (the Bash sandbox cannot write `.git`). After a push, check `git ls-remote` and `git update-ref` the origin ref.
- Any commit that touches `index.html` gets a `CHANGELOG_DATA` entry with its exact subject (a habit, not a gate). Run `node scripts/validate_skills.js --full` before every push.
- The fixed manifest of containers (name, default when `assets.js` is missing):
  - `{}`: SKILL_ICONS, EASTER_EGG_IMAGES, REACH_MODELS, REACH_TEX, REACH_SCENES, CLASS_MINIMAL_ICONS, CHM_ICONS, CHM_AUDIO, TOOL_ART, CLASS_ART, CLASS_HERO_ICONS, CLASS_STORY_ART, GEAR_ICONS
  - `""`: REACH_BOLDAS_ICON, MECH_BG_EVADE, MECH_BG_MOVESPEED

## Review Focus

1. `assets.js` fails to load (blocked, 404, offline). The app must still open, with blank icons and a console warning, not a white page. Test: Task 4 Step 3 (Playwright aborts the request).
2. A visitor gets a new `index.html` but an old cached `assets.js`. The `?v=` stamp makes the new page request the new file. Test: the `[ASSET VERSION ERROR]` cases in the Task 1 selftest and in Task 2.
3. Later work puts new icons back into `index.html`. `[ASSET BUDGET ERROR]` catches it. Test: the Task 1 selftest (`dataUriBytes`), and the validator check in Task 2.
4. Moving an assignment earlier changes what code sees while the page loads. Example: `SKILL_ICONS["privateServer"]` used to be added at line 16521 and is now present from the start. Test: `split` lists every column-0 statement between a container's declaration and its last moved assignment that names the container. Task 3 Step 2 expects that list to show no reader that depends on the order.
5. Alias lines must stay in the main script, because they read from a container: `SKILL_ICONS["status_poison"] = CHM_ICONS["status_poison"];` and `SKILL_ICONS["cat_powerSeven3"] = SKILL_ICONS["cat_powerThree3"];`. Test: the alias case in the Task 1 selftest, and the grep in Task 3 Step 3.

---

### Task 1: The split / stamp tool

**Files:**
- Create: `scripts/bible_assets.js`

**Interfaces:**
- Produces (exported, used by Tasks 2 and 3):
  - `MANIFEST`: an array of `{ name, empty }`, with `empty` being `{}` or `""` as in Global Constraints.
  - `ASSETS_FILE`: the absolute path of `12t_projects/bible/assets.js`.
  - `TAG_RE`: `/<script src="assets\.js\?v=([0-9a-f]{10})" id="bibleAssets"><\/script>/`.
  - `stampOf(buf: Buffer) -> string`: 10 hex characters of SHA-256.
  - `dataUriBytes(text: string) -> number`: total length of all `data:<type>/<sub>;base64,<b64>` matches.
  - `ASSET_BUDGET = 400 * 1024`.
  - `loadAssets(file = ASSETS_FILE) -> object`: runs the file in an empty vm context; throws if any global other than `BIBLE_ASSETS` appears.
  - `split(html: string, manifest = MANIFEST) -> { html: string, assets: string, report: { moved: number, keptAliases: string[], readersBetween: string[] } }`: pure, no file writes.
  - `stamp(html: string, assetsBuf: Buffer) -> string`: returns the html with the tag's `v=` replaced; throws if there is not exactly one tag.
- CLI:
  - `node scripts/bible_assets.js split`: writes both files; refuses if `index.html` already has the tag.
  - `node scripts/bible_assets.js stamp`: rewrites the `v=`.
  - `node scripts/bible_assets.js --selftest`

**Rules `split` implements:**
- **Declarations:** each manifest name's declaration is the unique line that starts with `const <NAME> = ` at column 0. A declaration found anywhere else, more than once, or not at all throws.
- **Statement extent:** a declaration ending with `{` runs to the next line that is exactly `};`. Any other declaration is that single line. The extent must parse alone (`new vm.Script`).
- **Moved assignments:** a column-0 line that starts with `<NAME>.`, `<NAME>[` or `Object.assign(<NAME>, ` moves only if it contains a data URI. Any other such line is kept and reported in `keptAliases`.
- **Values:** evaluate the moved statements, in file order, in one vm context, with `const` turned into `var`. Each container's final value is what gets written.
- **`readersBetween`:** every kept column-0 line that lies between a container's declaration and its last moved assignment and names the container, as `"L<n>: <first 80 chars>"`.
- **assets.js layout:** a header comment, then `var BIBLE_ASSETS = {};`, then one block per container in manifest order.
  - Object containers are written one entry per line: `"key": <JSON>,`.
  - String containers are one line.
- **Main script:**
  - Insert `const BIBLE_ASSETS_IN = typeof BIBLE_ASSETS === "object" && BIBLE_ASSETS ? BIBLE_ASSETS : {};` as the first line after `<script>`, followed by one `if (!Object.keys(BIBLE_ASSETS_IN).length) console.warn("assets.js did not load: icons, art, 3D previews and sounds are missing");`.
  - Each declaration extent becomes `const <NAME> = BIBLE_ASSETS_IN.<NAME> || <empty>;`, with the comment lines above it untouched.
  - Moved assignment lines are deleted.
  - The tag goes on its own line just before `<script>`.
- **Self-check before returning:**
  - For every container, run assets plus the new main-script declarations in a fresh context. The JSON must equal the value computed from the old file.
  - The new main script must parse.

- [ ] **Step 1: Write the failing selftest** (inside the file, behind `--selftest`)

The fixture is a small HTML string. Its main script has:
- a multi-line `const S = {` … `};` holding two data URIs;
- a one-line `const B = "data:image/png;base64,QUJD";`;
- `const R = {};` followed by `R.a = {"tex":"data:image/png;base64,QUJD","v":"x"};`;
- `Object.assign(S, {"c":"data:image/png;base64,QUJD"});`;
- the alias `S["d"] = S["a"];`;
- a line `function f(){ const T = {"k":"data:image/png;base64,QUJD"}; }`.

It uses its own manifest, `[{name:"S",empty:{}},{name:"B",empty:""},{name:"R",empty:{}}]`. `split` accepts a manifest as a second argument; the default is `MANIFEST`.

```js
const out = split(fixture, testManifest);
const box = {}; vm.runInNewContext(out.assets, box);
assert.deepStrictEqual(Object.keys(box), ["BIBLE_ASSETS"]);
assert.deepStrictEqual(box.BIBLE_ASSETS.S, { a: URI, b: URI, c: URI });   // the merged Object.assign is included, the alias is not
assert.strictEqual(box.BIBLE_ASSETS.B, URI);
assert.deepStrictEqual(box.BIBLE_ASSETS.R, { a: { tex: URI, v: "x" } });
assert.ok(out.html.includes('const S = BIBLE_ASSETS_IN.S || {};') && out.html.includes('const B = BIBLE_ASSETS_IN.B || "";'));
assert.ok(out.html.includes('S["d"] = S["a"];') && out.report.keptAliases.length === 1);
assert.ok(out.html.includes('function f(){ const T = {"k":"data:image/png;base64,QUJD"}; }'));   // not in the manifest: untouched
assert.strictEqual(dataUriBytes(out.html), dataUriBytes('{"k":"data:image/png;base64,QUJD"}'));
// running assets + new main gives the old main's final values
const oldBox = runMain(fixture), newBox = runMain(out.html, out.assets);
assert.deepStrictEqual(JSON.parse(JSON.stringify(newBox.S)), JSON.parse(JSON.stringify(oldBox.S)));
// missing assets: the page still runs, containers are empty
assert.doesNotThrow(() => runMain(out.html, ""));
// stamp
const h = stamp(out.html.replace(TAG_RE, '<script src="assets.js?v=0000000000" id="bibleAssets"></script>'), Buffer.from(out.assets));
assert.ok(TAG_RE.exec(h)[1] === stampOf(Buffer.from(out.assets)));
assert.throws(() => split(out.html, testManifest), /already/);
assert.throws(() => split(fixture.replace("const B =", "  const B ="), testManifest), /column 0|not found/);
```

`runMain(html, assets?)` is a test helper. It evaluates `assets` (when given) plus the html's main script in one vm context, with a stub `console`, and returns the context.

- [ ] **Step 2: Run the selftest and check that it fails**

Run: `node scripts/bible_assets.js --selftest`
Expected: FAIL. `split` is not defined.

- [ ] **Step 3: Implement the exports and the CLI** in `scripts/bible_assets.js`, following the Rules above. Match the header-comment style of the other scripts (purpose and date first, then usage lines).

- [ ] **Step 4: Run the selftest and check that it passes**

Run: `node scripts/bible_assets.js --selftest`
Expected: `bible_assets: selftest passed`

- [ ] **Step 5: Commit**

```powershell
git add -- scripts/bible_assets.js
git commit -m "feat(tools): scripts/bible_assets.js splits the Bible's embedded images into a versioned assets.js (split, stamp, selftest)"
```

### Task 2: The validator loads assets.js and guards it

**Files:**
- Modify: `scripts/validate_skills.js`:
  - the script extraction at `:68-76`;
  - the sandbox run at `:219`;
  - the CLASS_STORY_ART read at `:1020`;
  - the REACH reads at `:4290-4420`.

**Interfaces:**
- Consumes from Task 1: `TAG_RE`, `stampOf`, `dataUriBytes`, `ASSET_BUDGET`, `loadAssets`, `ASSETS_FILE`.

This task must be backward compatible: with no `bibleAssets` tag in `index.html`, the validator behaves exactly as today. Task 3 can then switch over in a single commit.

- [ ] **Step 1: Prepare a split copy to validate against**

Run `split` (from Task 1) into the scratchpad. Write `index.split.html` and `assets.js` there, without touching the repo. Add a validator option `--index <path>` that reads that html instead, with `assets.js` beside it.

Run: `node scripts/validate_skills.js --index <scratch>/index.split.html`
Expected: FAIL. Today's validator ignores the tag and finds no icons ("FATAL: SKILLS or SKILL_ICONS not exported correctly" or icon errors).

- [ ] **Step 2: Implement**
- When `TAG_RE` matches:
  - read `assets.js` next to the html;
  - prepend its text to `scriptCode` before `vm.runInNewContext` at `:219`;
  - fail with `[ASSET VERSION ERROR] index.html asks for assets.js?v=<a> but the file is <b>; run node scripts/bible_assets.js stamp` when the stamps differ;
  - fail with `[ASSET FORMAT ERROR]` when `loadAssets` throws;
  - log `Verified assets.js: <n> containers, stamp <v>`.
- Also when the tag is present, fail with `[ASSET BUDGET ERROR] index.html embeds <n> KB of data: URIs (limit 400 KB); move them into assets.js (scripts/bible_assets.js)` when `dataUriBytes(html) > ASSET_BUDGET`. Without the tag, today's single file (about 25 MB of data URIs) is not checked.
- Replace the html-text reads with values from the sandbox:
  - `:1020` becomes `vm.runInContext("CLASS_STORY_ART", sandbox)`.
  - `:4290` iterates `Object.entries(vm.runInContext("REACH_MODELS", sandbox))`.
  - The `new RegExp("REACH_MODELS\\." + k + " = ").test(html)` tests (`:4294`, `:4307`, `:4390`) become `k in REACH_MODELS`.
  - Change the same way any REACH_SCENES / REACH_TEX reads in `:4396-4420` that match against `html`.
  - Keep each check's message unchanged.

- [ ] **Step 3: Check that both shapes pass**

Run: `node scripts/validate_skills.js --index <scratch>/index.split.html --full`
Expected: SUCCESS, with the same skill / formula / icon counts as today (670 skills, 831 permutations, 1472 icons), plus `Verified assets.js`.

Run: `node scripts/validate_skills.js --full`
Expected: SUCCESS, unchanged from today (no tag, old path).

Then, in the scratch copy, change one byte of `assets.js`. Run: `node scripts/validate_skills.js --index <scratch>/index.split.html`
Expected: `[ASSET VERSION ERROR]`.

- [ ] **Step 4: Commit**

```powershell
git add -- scripts/validate_skills.js
git commit -m "feat(tools): the validator reads assets.js when index.html loads it (version stamp, data-only format and a 400 KB data-URI budget)"
```

### Task 3: Run the split on the real files

**Files:**
- Modify: `12t_projects/bible/index.html` (via `split` only)
- Create: `12t_projects/bible/assets.js`
- Modify: `scripts/add_guide.js:213`. The page faces become `loadAssets().CLASS_HERO_ICONS`, with `{}` on error.
- Modify: `.claude/hooks/guard-index-git.sh:17`. The protected path pattern becomes `(index\.html|assets\.js)`.

**Interfaces:**
- Consumes: `split`, `stamp`, `loadAssets` (Task 1); the validator from Task 2.

- [ ] **Step 1: Backup and run**

Copy `index.html` to the scratchpad as `index.<timestamp>.bak`.
Run: `node scripts/bible_assets.js split`
Expected:
- about `moved: 1577 lines`;
- `assets.js` at about 24.5 MB;
- `index.html` at about 5 MB;
- `dataUriBytes(index.html)` at about 274 KB;
- `keptAliases` listing exactly the two aliases from Review Focus 5.

- [ ] **Step 2: Review the readers-between report**

The command prints `readersBetween`. For each line, check that it only defines code (a function or a `const` of other data) and does not read the container's keys while the page loads.
Expected: no reader that depends on the order. If one does depend on it, stop and report it to the user before going on.

- [ ] **Step 3: Verify**
- Run: `node scripts/validate_skills.js --full`. Expected: SUCCESS with the Task 2 Step 3 counts, `Verified assets.js`, and no budget or version error.
- Run: `node scripts/card_edit.js --selftest`. Expected: pass.
- Run: `node scripts/guide_draft.js --selftest`. Expected: pass. Its `SKILL_SIM` slice no longer holds the `Object.assign(SKILL_ICONS, …)` line, which is fine because its sandbox gives an empty `SKILL_ICONS`.
- Run: `git diff --stat`. Expected:
  - `index.html` about −1577 lines, +19 lines (16 declarations, 2 header lines, 1 tag);
  - `assets.js` new.
- Run: `rg -n 'SKILL_ICONS\["(status_poison|cat_powerSeven3)"\] = ' 12t_projects/bible/index.html`. Expected: 2 lines, still in the main script.

- [ ] **Step 4: Point the guide manager and the git guard at the new file**

Make the two small edits listed under Files.
Run: `node -e "console.log(Object.keys(require('./scripts/bible_assets.js').loadAssets().CLASS_HERO_ICONS).length)"`. Expected: `12`.
Run the guard hook with `git restore 12t_projects/bible/assets.js` on stdin. Expected: a deny decision.

- [ ] **Step 5: Commit** (not pushed yet: Task 4 checks the pages in a browser first)

First add the `CHANGELOG_DATA` entry with this exact subject. It edits `index.html`, so back it up first. The stamp depends only on `assets.js`, so it stays valid.

```powershell
git add -- 12t_projects/bible/index.html 12t_projects/bible/assets.js scripts/add_guide.js .claude/hooks/guard-index-git.sh
git commit -m "perf(bible): the embedded images, 3D models and sounds move to assets.js (24.4 MB); index.html drops to about 5 MB, so a push costs returning visitors about 2 MB instead of 19 MB"
```

### Task 4: Browser smoke test, docs, push

**Files:**
- Modify the rule docs:
  - `AGENTS.md:14,71`: self-contained single file becomes `index.html` plus `assets.js` for the Bible (user 2026-10-20).
  - `12t_projects/bible/CLAUDE.md:18-23,33`:
    - the base64 blocks now live in `assets.js`;
    - "zero base64 ingestion" applies to it;
    - icon edits go to `assets.js`, followed by `node scripts/bible_assets.js stamp`;
    - the two-file deliverable.
  - `CLAUDE.md`: the commands list gains `node scripts/bible_assets.js stamp | --selftest`.
  - Every `SKILL_ICONS` / base64 mention in `.claude/skills/bible-*/SKILL.md`:
    - `bible-desc-writing:49`
    - `bible-hub-tools:79,86,125`
    - `bible-skill-page-ui:67,123`
    - `bible-skill-research:42`

    Where a line says icons live in, or are added to, `index.html`, it now says `assets.js` plus stamp.
- Test: the Playwright smoke script in the scratchpad (never in the repo):
  - playwright-core at `C:/Users/Jump/AppData/Local/npm-cache/_npx/423231821c231c73/node_modules/playwright-core`;
  - Chromium at `C:/Users/Jump/AppData/Local/ms-playwright/chromium_headless_shell-1234/chrome-headless-shell-win64/chrome-headless-shell.exe`.

This is a structural change to how the page loads, which a broken push would break for every visitor. That's why it gets the one browser check that the "no browser for small changes" rule otherwise reserves for big changes.

- [ ] **Step 1: Write the smoke script.** It runs these assertions on both `file:///…/12t_projects/bible/index.html` and `http://127.0.0.1:<port>/12t_projects/bible/` (a node static server on the repo root):
  - no `pageerror`;
  - `typeof BIBLE_ASSETS === "object"`;
  - the launcher shows class or tool art (`document.querySelectorAll('img[src^="data:image"]').length > 20`);
  - `#skill-details` renders skill icons;
  - `#class-guide` renders the gallery's 12 class faces.

- [ ] **Step 2: Run it.** Expected: all assertions pass on both URLs.

- [ ] **Step 3: The missing-assets case.** Add one run with `page.route("**/assets.js*", r => r.abort())`.
Expected:
  - no `pageerror`;
  - the launcher's tool names are visible;
  - the console warning "assets.js did not load" appears.

- [ ] **Step 4: Update the docs listed under Files.**
Run: `node scripts/validate_skills.js --full`. Expected: SUCCESS.

- [ ] **Step 5: Commit the docs, then push after the user says to**

```powershell
git add -- AGENTS.md CLAUDE.md 12t_projects/bible/CLAUDE.md .claude/skills
git commit -m "docs: the Bible is index.html plus a versioned assets.js; icons go to assets.js, then node scripts/bible_assets.js stamp"
git push -q origin skill-cooldown-lookup
```

After the push:
- Expected: `git ls-remote origin refs/heads/skill-cooldown-lookup` equals `HEAD`.
- Then run `git update-ref refs/remotes/origin/skill-cooldown-lookup <sha>`.
- About 2 minutes later, run `curl -sI https://jumpptty.github.io/12tails/12t_projects/bible/assets.js?v=<stamp>`. Expected: `200`, with `Content-Encoding: gzip` when requested with `Accept-Encoding: gzip`.
- Fetch the live page with `Accept-Encoding: gzip`. Expected: about 2 MB transfer (was 19.3 MB).
