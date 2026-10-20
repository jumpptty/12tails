# Guide Manager on the Phone Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** The class guide manager works from a phone with the PC off: one page served both by `scripts/add_guide.js` (PC) and by GitHub Pages (phone), the phone side publishing through a GitHub Actions workflow that runs the same pipeline.

**Architecture:** The page moves out of `add_guide.js` into `12t_projects/guide-manager/index.html`. It picks a backend from where it runs (the local API when `add_guide.js` filled in its key, GitHub otherwise) and a layout from the window width (today's layout, or bottom tabs at ≤ 760 px). `add_guide.js`'s `apply()` is split into stages that a `batch` command can run one per workflow step; the workflow reports its outcome as check-run annotations the page reads back.

**Tech Stack:** Node 24 (no npm dependencies), plain HTML/CSS/JS in one file, GitHub Actions (`actions/checkout@v4`, `actions/setup-node@v4`), GitHub REST API from the browser (`api.github.com`, API version `2022-11-28`).

**Spec:** [docs/superpowers/specs/2026-10-20-guide-manager-mobile-design.md](../specs/2026-10-20-guide-manager-mobile-design.md)

## Global Constraints

- Repo `jumpptty/12tails`, branch `skill-cooldown-lookup` (default, served by Pages, protected against force-push). Page URL `https://jumpptty.github.io/12tails/12t_projects/guide-manager/`. Guide links `https://jumpptty.github.io/12tails/12t_projects/bible/#class-guide/<id>`.
- The page is one self-contained file; fonts: Prompt for text, `'JetBrains Mono','Prompt',monospace` for numbers, Google Fonts loads exactly `Prompt` and `JetBrains Mono`; no soft gold glow on hover (hover = border/brightness only, as the current page).
- Key: a fine-grained token limited to `12tails` with **Actions: Read and write**; stored only in `localStorage` key `12t-gm-key`; sent only to `https://api.github.com`; CSP `connect-src 'self' https://api.github.com`; `<meta name="robots" content="noindex">`.
- Workflow dispatch inputs total at most 65,535 characters.
- Workflow: `workflow_dispatch` only, `TZ: Asia/Bangkok`, Node 24, `fetch-depth: 1`, `permissions: contents: write`, `concurrency: { group: guide-manager, cancel-in-progress: false }`; commits authored by the latest commit's author (Jump), committed as `github-actions[bot] <41898282+github-actions[bot]@users.noreply.github.com>`.
- Step texts, exactly as the desktop: ส่งงานให้ GitHub, ตรวจสถานะ git, แก้ไฟล์ index.html, ตรวจด้วย validator, commit, อัปขึ้น GitHub. All other Thai copy reuses the current page's wording.
- The desktop manager behaves exactly as today: `add_guide.cmd`, the "12Tails Add Guide" shortcut, `127.0.0.1:4782`, the CLI (`add`, `replace`, `delete`, `--dry-run`, `--no-push`, `--yes`, `--modes`, `--port`, `--no-open`).
- `index.html` is CRLF; never `git checkout` / `restore` / `reset` / `stash` it. Stage only the files a task names (`12t_reference/*.md` belong to another session). One-off scripts go in the scratch dir, never `scripts/`.
- Ask the user before every `git push`. Run `node scripts/validate_skills.js` after each task, `--full` before a push.

## Review Focus

- **The phone sleeps, or the tab is killed, mid-run:** reopening shows the run's progress or outcome, never a blank card and never a second dispatch. Test: Task 6, step "reload mid-run".
- **The key expired, was revoked, or lacks Actions write:** the key screen comes back with the reason, the queue is kept. Test: Task 5, `gmRunOutcome` / `gmKeyProblem` cases; Task 6, a bogus key.
- **A guide was published elsewhere between loading the list and publishing:** the result links use the numbers the workflow reports, not the planned ones, and the list reloads. Test: Task 5, `gmRunOutcome` builds links from `gm-result` items.
- **A queue too long for one dispatch:** refused before sending, with a message, queue kept. Test: Task 5, `gmPayloadFits`.
- **A run cancelled by the concurrency group, or failing before the pipeline (checkout, setup):** a plain message and a link to the run, not "ไม่ได้รับผลลัพธ์". Test: Task 5, `gmRunOutcome` cancelled / failure-without-annotation cases.

---

### Task 1: Verify GitHub assumptions (spike, gate for Tasks 3 and 6)

Prove, from a desktop browser holding only the user's key, that the GitHub side works as the spec assumes. Stop and report to the user if any probe fails; the fallback for the result channel is a results branch (a design change, not an improvisation).

**Files:**
- Create: `.github/workflows/guide-manager.yml` (skeleton; Task 3 replaces its steps)
- Create (scratch, not in repo): `<scratchpad>/gm-probe.html`
- Modify: the spec, a new section `## Verified on GitHub (<date>)` at the end

- [ ] **Step 1: Write the skeleton workflow.** `name: guide-manager`; `run-name: guide manager ${{ inputs.request }}`; inputs `request` (string, required), `payload` (string, required), `dry` (boolean, default false), `spike_push` (boolean, default false); the permissions, concurrency and `TZ` from Global Constraints. Steps: `ส่งงานให้ GitHub` (checkout, `fetch-depth: 1`), `ส่งงานให้ GitHub` (setup-node 24), `ตรวจสถานะ git` (`sleep 5`), `ตรวจด้วย validator` which prints one `::error title=gm-error::` whose message is two lines joined by `%0A`, and one `::notice title=gm-result::` whose message is a 6,000-character JSON string; then, only `if: inputs.spike_push`, a step `อัปขึ้น GitHub` that sets the author from `git log -1 --format=%an / %ae`, the bot committer, runs `git commit --allow-empty -q -m "chore(tools): guide manager push test"` and `git push origin HEAD:skill-cooldown-lookup`.
- [ ] **Step 2: Commit, ask the user, push.** `git add .github/workflows/guide-manager.yml && git commit -m "chore(tools): guide manager workflow skeleton (spike)"`. A workflow can only be dispatched once it is on the default branch.
- [ ] **Step 3: The user makes the key.** Ask the user to create a fine-grained token at `https://github.com/settings/personal-access-tokens/new`: repository access "Only select repositories" → `12tails`, permission Actions → Read and write. They paste it into the probe page themselves; never ask for it in chat.
- [ ] **Step 4: Write `gm-probe.html`.** A key box and a Run button; each probe prints PASS/FAIL with details: (P1) `GET /repos/jumpptty/12tails/contents/12t_projects/bible/index.html?ref=skill-cooldown-lookup` with `Accept: application/vnd.github.raw+json`, `cache: "no-cache"`: status 200, length > 1,000,000, and `x-ratelimit-used` does not rise on a second identical call (the revalidation hit the cache); (P2) `POST /repos/jumpptty/12tails/actions/workflows/guide-manager.yml/dispatches` `{ref, inputs:{request, payload:"{}", dry:"true"}}` → 204; (P3) the run whose `display_title` is `guide manager <request>` appears in `GET …/actions/workflows/guide-manager.yml/runs?event=workflow_dispatch&per_page=10` within 30 s; (P4) poll `GET …/actions/runs/<id>/jobs` every 3 s and log each step's name/status/conclusion transition; (P5) after completion `GET …/check-runs/<job.id>/annotations` holds both annotations, with the gm-error newline intact and the gm-result message's full length; (P6, informational) `GET …/actions/jobs/<job.id>/logs` readable or blocked by CORS; (P7, with a second dispatch `spike_push: "true"`, run only after the user agrees to one empty commit on the branch) the empty commit is the branch head and a `pages-build-deployment` run with that `head_sha` starts within 2 minutes (`GET …/actions/runs?head_sha=<sha>`).
- [ ] **Step 5: Run the probe in the user's Chrome** (Claude in Chrome), the user pasting the key. Expected: P1–P5 and P7 PASS.
- [ ] **Step 6: Record the findings** in the spec's new section: each probe's outcome, the longest gm-result message that survived intact, whether the Pages build started by itself (if not, Task 3 adds the Pages request step), and the key's final permission list. Commit the spec with this plan: `git add docs/superpowers/specs/2026-10-20-guide-manager-mobile-design.md docs/superpowers/plans/2026-10-20-guide-manager-mobile.md && git commit -m "docs: guide manager on the phone, design, plan and GitHub checks"`.

### Task 2: Split the pipeline into stages, add `batch` and undo-from-commit (`add_guide.js`)

**Files:**
- Modify: `scripts/add_guide.js` (pipeline section lines 116–191, `/api/run` handler lines 243–270, exports line 618, header comment)

**Interfaces:**
- Produces (exported with the existing `planAll`, `readGuides`):
  - `ROOT` honours `process.env.GM_ROOT` (tests only).
  - `opsFromItems(items: {action, id?, code?, modes?}[]) -> Op[]`: today's `/api/run` item loop (decode, `fixDate`, modes, Thai errors prefixed `รายการที่ N: `); the server uses it too.
  - `undoText(entries) -> string`: today's inline text (one entry: its `text`; several: `ย้อนกลับชุดล่าสุด K รายการ (#a, #b)`).
  - `validatorErrorLines(out: string) -> string[]`: today's filter in `apply()` (tagged `[… ERROR]` lines, else lines with ERROR/Error, else the last 12; at most 14).
  - `stageGit(ops, {fetch: boolean}) -> {branch, doc, p}`; `stageEdit(doc, p) -> void` (writes `index.html` + changelog entry); `async stageCheck(ui) -> void` (throws `Error` with `.lines`); `async stageCommit(subject, ui) -> void`; `stagePush(branch, ui) -> sha`. `apply()` composes them with today's backup/rollback and identical `ui.step` calls.
  - `undoOpsFromCommit(sha: string) -> Op[]`: for every `CLASS_GUIDES` id whose line differs between `sha^` and `sha`, an `{action: "undo", entry: {id, before, g, text}}` (`before` = the parent's line or `null`; `g` = the guide from the new line, or from the parent line when the new one is a tombstone), in reverse id order of the commit's items. Fetches `sha` with `--depth=2` when it is not present.
  - CLI `node scripts/add_guide.js batch <request.json> --stage git|edit|check|commit|push [--dry-run]`; request `{"items":[…]}` (the `/api/run` item shape) or `{"undo":{"sha":"<40 hex>"}}`. When `GITHUB_ACTIONS=true` a failing stage prints `::error title=gm-error::<message>%0A<lines…>` (escape `%`→`%25`, CR→`%0D`, LF→`%0A`) and exits 1; the last stage (`push`, or `check` with `--dry-run`) prints `::notice title=gm-result::{"ok":true,"dry":<bool>,"subject":…,"sha":<sha|null>,"items":[{"action","id"}],"undoText":<string|null>}`. Stages re-plan from the request (deterministic within one run); `stageGit` in batch mode uses `fetch: false`; a rejected push says `มีการเปลี่ยนแปลงบน GitHub ระหว่างทำงาน ลองใหม่อีกครั้ง`.
  - `node scripts/add_guide.js --selftest`.

- [ ] **Step 1: Write the self-test** (runs before the CLI dispatch in the start-up section). It builds a throwaway fixture in `os.tmpdir()`: a git repo with a bare `origin`, a CRLF `12t_projects/bible/index.html` holding `<script>`, `const CLASS_GUIDES = [` with guides #1 and #2 as `guideLine` output, `];`, `const CHANGELOG_DATA = {`, `  entries: [` with one entry, a stub `scripts/validate_skills.js` that prints `[CLASS GUIDE ERROR] fixture refuses FAILME` and exits 1 when `index.html` contains `FAILME`, else exits 0; then spawns this script with `GM_ROOT=<fixture>` for each case and asserts:
  - add (code from `guide_code.encode` of a ToT Wolf guide "T3" by "A3"): new line `{"id":3,…`, newest changelog entry and HEAD subject both `feat(bible): class guide #3 ToT Wolf T3 by A3`, `origin` head equals local HEAD.
  - batch `[add, replace #1, delete #2]`: ids 3 (new), 1 (kept), line for #2 becomes `  // #2 removed <today>: <title> by <author>`; subject `feat(bible): class guides #3 ToT Wolf T3 by A3; #1 is updated: …; #2 is removed (…)`.
  - a FAILME guide: `index.html` byte-identical afterwards, HEAD unchanged, message contains `ไกด์ไม่ผ่านการตรวจ`, lines contain `[CLASS GUIDE ERROR] fixture refuses FAILME`.
  - `--dry-run`: file unchanged, no commit.
  - dirty `index.html`: refused with `index.html มีงานค้าง`.
  - `undoOpsFromCommit(<batch sha>)` applied through `apply()` restores the pre-batch `CLASS_GUIDES` lines exactly.
  - the five `batch --stage …` runs on a second fixture give the same `CLASS_GUIDES` lines and subject as `apply()` on the first; with `GITHUB_ACTIONS=true` the final notice parses as JSON with `items` `[{action:"add",id:3},…]`, and a FAILME run's stdout has one `::error title=gm-error::` line containing `%0A[CLASS GUIDE ERROR]`.
- [ ] **Step 2: Run it, expect failure.** `node scripts/add_guide.js --selftest` → fails (no `--selftest` / `batch` / `GM_ROOT` yet).
- [ ] **Step 3: Implement** the interfaces above, moving code rather than rewriting it; `serve()` uses `opsFromItems` and `undoText`.
- [ ] **Step 4: Run** `node scripts/add_guide.js --selftest` → `add_guide selftest: all checks passed`; `node scripts/validate_skills.js` → SUCCESS.
- [ ] **Step 5: Desktop smoke.** Make guide #1's code (`guide_code.encode` of its `CLASS_GUIDES` object without `id`, in a scratch script), then `node scripts/add_guide.js add <that code> --dry-run --yes` on the real repo → `passed every check (dry run …)`, `git status` shows `index.html` untouched.
- [ ] **Step 6: Commit.** `git add scripts/add_guide.js && git commit -m "feat(tools): add_guide.js pipeline runs in stages (batch command for GitHub Actions, undo from a commit) with a self-test"`

### Task 3: The real workflow

**Files:**
- Modify: `.github/workflows/guide-manager.yml`

**Interfaces:**
- Consumes: Task 2's `batch` CLI and annotation format; Task 1's findings.
- Produces: inputs `request` (string), `payload` (string, JSON request), `dry` (boolean); run name `guide manager <request>`; step names exactly as Global Constraints, `commit` and `อัปขึ้น GitHub` skipped when `dry`.

- [ ] **Step 1: Replace the skeleton steps** (drop `spike_push`): checkout + setup-node both named `ส่งงานให้ GitHub`; `ตรวจสถานะ git` writes the payload to `$RUNNER_TEMP/request.json` from an `env:` variable (never `${{ inputs.payload }}` inside `run:`), then `--stage git`; `แก้ไฟล์ index.html` `--stage edit`; `ตรวจด้วย validator` `--stage check`; `commit` (`if: ${{ !inputs.dry }}`) exports `GIT_AUTHOR_NAME/EMAIL` from `git log -1` and the bot as `GIT_COMMITTER_*`, then `--stage commit`; `อัปขึ้น GitHub` (`if: ${{ !inputs.dry }}`) `--stage push`. Pass `--dry-run` to every stage when `inputs.dry`. Only if Task 1 found no automatic Pages build: a last step `POST /repos/${{ github.repository }}/pages/builds` with `GITHUB_TOKEN` and `permissions: pages: write`.
- [ ] **Step 2: Commit, ask the user, push.** `git add .github/workflows/guide-manager.yml && git commit -m "feat(tools): guide-manager workflow publishes a guide batch from the phone (same pipeline as add_guide.js)"`
- [ ] **Step 3: Verify with the probe page**, extended with a payload box. (a) A dry run adding guide #1's code (Task 2 step 5) → `ตรวจสถานะ git`…`ตรวจด้วย validator` succeed, `commit` / `อัปขึ้น GitHub` skipped, gm-result `dry: true` with the planned id. (b) `{"items":[{"action":"delete","id":999}]}` → `ตรวจสถานะ git` fails, gm-error `ไม่มีไกด์ #999`. (c) Guide #1 with `build.level` set to 1, encoded (first confirm locally that `add <code> --dry-run --yes` fails with a `[CLASS GUIDE ERROR]` line) → `ตรวจด้วย validator` fails, gm-error carries `ไกด์ไม่ผ่านการตรวจ` and that line. Expected: all three as described, nothing committed.

### Task 4: Move the page into its own file (local mode unchanged)

**Files:**
- Create: `12t_projects/guide-manager/index.html` (the current `PAGE` markup, CSS and script)
- Modify: `scripts/add_guide.js` (drop the `PAGE` string; `serve()` reads the file per request and replaces `__KEY__`; `pageData()` stops sending `faces`)
- Modify: `scripts/validate_skills.js` (new section "Guide manager page", before the AUDIT SUMMARY; the font check becomes a function used for both pages)

**Interfaces:**
- Produces: in the page, `const FACES = {Bat: "data:…", …}` (all 12 `CLASS_HERO_ICONS`, keys capitalised as in `assets.js`); `const LOCAL = KEY !== "__" + "KEY__"`; the existing `api()`, `load()`, `run()` wrapped as `localBackend` with the `backend` interface: `state() -> Promise<State>`, `check(code, replaceId) -> Promise<Check>`, `run(items, dryRun, on) -> Promise<Done>`, `undo(on) -> Promise<Done>`, `resume(on) -> Promise<Done|null>` (State/Check/Done = today's `/api/state`, `/api/check` and NDJSON `done` shapes; `on` receives the `step` / `log` messages).
- Head additions: the CSP and robots metas from Global Constraints, `<meta name="theme-color" content="#150f0c">`, `apple-mobile-web-app-capable`, and `apple-touch-icon` + `icon sizes="192x192"` using the 256 px PNG inside `scripts/add_guide.ico` as a data URI.

- [ ] **Step 1: Write the validator checks** (prefix `[GUIDE MANAGER ERROR]`): the page exists; `FACES` deep-equals `loadAssets().CLASS_HERO_ICONS`; the CSP meta has `connect-src 'self' https://api.github.com`; the robots meta is present; the two-font rule passes on the page.
- [ ] **Step 2: Run** `node scripts/validate_skills.js` → `[GUIDE MANAGER ERROR] … not found`.
- [ ] **Step 3: Move the page and wire `serve()`**; faces come from `FACES`; behaviour otherwise identical.
- [ ] **Step 4: Run** the validator → SUCCESS; `node scripts/add_guide.js --selftest` → passes.
- [ ] **Step 5: Local smoke.** `node scripts/add_guide.js --no-open --port 4799` in the background; `GET /` returns the page with a 36-hex key in place of `__KEY__`; `GET /api/state` with that key → JSON with `guides.length` equal to `CLASS_GUIDES`' guide count; stop the server.
- [ ] **Step 6: Commit.** `git add 12t_projects/guide-manager/index.html scripts/add_guide.js scripts/validate_skills.js && git commit -m "refactor(tools): the guide manager page is its own file (12t_projects/guide-manager), served by add_guide.js as before"`

### Task 5: The page's GitHub core (pure functions + validator equivalence)

**Files:**
- Modify: `12t_projects/guide-manager/index.html` (a `<script>` block between the lines `// gm-core start` and `// gm-core end`, no DOM access)
- Modify: `scripts/validate_skills.js` (the "Guide manager page" section; runs the gm-core block in a `vm` context)
- Modify: `scripts/add_guide.js` (export `findCode`, `fixDate`, `localToday`, `nextId`, `parse` for the checks)

**Interfaces (gm-core):**
- `gmFindCode(text) -> string|undefined` (same regex as `findCode`).
- `gmUnpack(code) -> {format: "tg3"|"tg2"|"tg1"|"json", deflated: boolean, bytes: Uint8Array, text?: string}`; throws `guide_code.js`'s messages (the TG3 copy-again message on a bad check character).
- `gmFinish(u, raw: Uint8Array) -> guide` (format 1: UTF-8 JSON then the port of `expand`; formats 2/3: the port of `classGuideFromBinary`); `gmInflate(bytes) -> Promise<Uint8Array>` (`DecompressionStream("deflate-raw")`, refuse past 131,072 bytes); `async gmDecode(code)` = unpack, inflate when `deflated`, finish.
- `async gmDecodeCode(text) -> guide`: `decodeCode`'s three Thai errors, word for word.
- `gmFixDate(g, today) -> string|null`; `gmLocalToday() -> "YYYY-MM-DD"`.
- `gmParseGuides(html) -> {guides: {id, g}[], removed: {id, text}[], next, views}` (CRLF or LF; `views` from `CLASS_GUIDE_VIEWS.counts`).
- `gmSummary(g, views) -> {id, modes, title, author, classKey, server, level, date, views}` (the `pageData` guide shape).
- `gmPayloadFits(inputs) -> boolean` (`JSON.stringify(inputs).length <= 65535`).
- `gmStepsFromJobs(jobsJson) -> {key, text, state}[]`: the run's job steps mapped by name (`ส่งงานให้ GitHub`→`send`, `ตรวจสถานะ git`→`git`, `แก้ไฟล์ index.html`→`edit`, `ตรวจด้วย validator`→`check`, `commit`, `อัปขึ้น GitHub`→`push`); the two `send` steps merge; GitHub's own steps and skipped steps are left out; a queued run is `[{key:"send", state:"run"}]`; states `run|ok|fail`.
- `gmRunOutcome(run, annotations, site) -> Done|null`: `null` until `run.status === "completed"`; `gm-result` → `{ok:true, dry, subject, sha, undoText, items:[{action, id, url: site + "#class-guide/" + id}]}`; `gm-error` → `{ok:false, error: first line, log: the other lines}`; `cancelled` → `{ok:false, error: "งานถูกยกเลิก (มีงานอื่นรออยู่บน GitHub) ลองอัปใหม่"}`; failure without annotations → `{ok:false, error: "GitHub ทำงานไม่สำเร็จก่อนถึงขั้นตอนของไกด์ ดูรายละเอียดใน GitHub", runUrl: run.html_url}`.
- `gmKeyProblem(status) -> string|null`: 401 → `กุญแจใช้ไม่ได้ (หมดอายุหรือถูกลบ) ใส่กุญแจใหม่`; 403/404 on dispatch → `กุญแจนี้ยังไม่มีสิทธิ์ Actions: Read and write ของ 12tails`; else `null`.

- [ ] **Step 1: Write the validator checks.** For every guide in `CLASS_GUIDES` and each of `gc.encode`, `gc.encode2`, `gc.encode1`: `gmFinish(u, u.deflated ? zlib.inflateRawSync(u.bytes) : u.bytes)` deep-equals `gc.decode(code)`; a TG3 code wrapped as ``ไกด์ `<code>` จบ`` with a line break decodes; one changed TG3 character throws a message containing `คัดลอกใหม่`; `gmFindCode` equals `findCode` on those strings and on `"no code here"`; `gmParseGuides(index.html)` ids, removed ids and `next` equal `readGuides()` / `nextId`; `gmFixDate(g, <add_guide's localToday()>)` equals `fixDate(g)` for today, tomorrow, `""` and `2031-07-05` (export `localToday` too); `gmPayloadFits` true at 65,535 and false at 65,536 characters; `gmStepsFromJobs` and `gmRunOutcome` on recorded JSON from Task 1/3 (queued, mid-check, dry success, failure with gm-error, cancelled, failure without annotations); `gmKeyProblem(401)`, `(403)`, `(200)`.
- [ ] **Step 2: Run** the validator → the new checks fail (`gm-core block not found`).
- [ ] **Step 3: Implement gm-core**, porting from `scripts/guide_code.js` with `Uint8Array` / `atob` / `TextDecoder` in place of `Buffer`.
- [ ] **Step 4: Run** the validator → SUCCESS.
- [ ] **Step 5: Commit.** `git add 12t_projects/guide-manager/index.html scripts/validate_skills.js scripts/add_guide.js && git commit -m "feat(tools): guide manager page reads guide codes and the guide list itself (checked against guide_code.js and add_guide.js)"`

### Task 6: The GitHub backend and key screen

**Files:**
- Modify: `12t_projects/guide-manager/index.html`

**Interfaces:**
- Consumes: gm-core (Task 5), the `backend` interface (Task 4), the workflow (Task 3).
- Produces: `githubBackend` with the same interface; `localStorage` `12t-gm-key` (the key), `12t-gm-pending` (`{request, kind: "run"|"undo", dry, at}`), `12t-gm-last` (`{sha, text}`).

- [ ] **Step 1: Implement `githubBackend`.** `state()`: the raw `index.html` via the contents API (`cache: "no-cache"`), `gmParseGuides`, `gmSummary`, `undo` from `12t-gm-last`. `check()`: `gmDecodeCode`, `gmFixDate`, duplicate and next id as `/api/check`. `run()`: build inputs, refuse with `รายการยาวเกินกว่าที่ส่งให้ GitHub ได้ในครั้งเดียว แบ่งอัปเป็นสองชุด` unless `gmPayloadFits`, dispatch, save pending, then poll (every 3 s while `document.visibilityState === "visible"`, paused while hidden) runs → jobs → `gmStepsFromJobs` → `on({type:"step"})`, and on completion annotations → `gmRunOutcome`; clear pending; a successful non-dry result stores `12t-gm-last` `{sha, text: undoText}` and, for a run (not an undo), clears the queue and its history, also when the run ends inside `resume()` (today the page clears it only for `/api/run`; key this on the kind instead). `undo()`: the same with payload `{"undo":{"sha":…}}`, clearing `12t-gm-last` on success. `resume()`: continues a stored pending run. A failure's `log` goes to the log box; `runUrl` becomes a link "เปิดใน GitHub".
- [ ] **Step 2: Implement the key screen and pill** as the spec and mock describe (three steps, the token link, บันทึกในเครื่องนี้, the stays-on-this-phone line); `gmKeyProblem` reasons show on it; in GitHub mode the pill is a button opening the existing modal with **ลืมกุญแจ** (danger); no `index.html มีงานค้าง` banner.
- [ ] **Step 3: Verify in the user's Chrome at desktop width** (the user pastes the key): the list matches the Bible's guides; a pasted code previews; a ตรวจอย่างเดียว of one add ticks every step and shows the dry result; a bogus key shows the 401 reason; **reload mid-run** resumes the step list and ends on the result. Expected: all as described; the repo unchanged (`git fetch` shows no new commit).
- [ ] **Step 4: Commit.** `git add 12t_projects/guide-manager/index.html && git commit -m "feat(tools): guide manager page publishes through GitHub when it is not on this PC (key screen, progress, resume, undo)"`

### Task 7: Phone layout B

**Files:**
- Modify: `12t_projects/guide-manager/index.html`

**Interfaces:**
- Produces: `.app[data-tab="editor"|"queue"|"list"]`; `#tabs` (three buttons); `#pubBar`; `showTab(name)`.

- [ ] **Step 1: Implement** at `@media (max-width:760px)`: header without the subtitle, compact pill, undo as `↶` with its text in `title`; bottom tabs ＋ วางโค้ด / ☰ รายการที่จะอัป (red count badge when the queue is not empty) / ▦ ไกด์ทั้งหมด; opens on วางโค้ด; only the active tab's cards show (`#progress` belongs to รายการที่จะอัป); `#pubBar` above the tabs whenever the queue has items ("รอ N รายการ" + the gold button using `#publish`'s label and handler); แทนที่ in the list → `showTab("editor")` in replace mode; confirming a publish → `showTab("queue")`; guide rows as the mock (title, author · class · server · modes, date · 👁 views, แทนที่ / ลบ stacked); buttons at least 40 px tall; `env(safe-area-inset-bottom)` under the tabs; no sideways page scroll. Wider than 760 px: exactly today's layout.
- [ ] **Step 2: Verify with Playwright** at 390 × 844 and 1440 × 900, local mode (`add_guide.js --no-open`): screenshots of each tab, replace mode and the publish bar match the mock; the wide layout is unchanged. Then the validator → SUCCESS.
- [ ] **Step 3: Commit.** `git add 12t_projects/guide-manager/index.html && git commit -m "feat(tools): guide manager on phones: bottom tabs (วางโค้ด, รายการที่จะอัป, ไกด์ทั้งหมด) and a publish bar"`

### Task 8: Docs, push, first use

**Files:**
- Modify: `12t_projects/bible/CLASS-GUIDES.md` (the guide manager paragraph), `CLAUDE.md` (Commands: `add_guide.js batch`, `--selftest`; drop "views" from the `add_guide.js` line), `AGENTS.md` (directory list: `guide-manager/`)

- [ ] **Step 1: Update the three docs**: the phone address, the one-time key (Actions: Read and write on `12tails` only, plus anything Task 1 added), the workflow and its step names, undo from the phone, `git pull` before PC work.
- [ ] **Step 2: Run** `node scripts/validate_skills.js --full` and `node scripts/add_guide.js --selftest` → both pass.
- [ ] **Step 3: Commit, ask the user, push.** `git add 12t_projects/bible/CLASS-GUIDES.md CLAUDE.md AGENTS.md && git commit -m "docs: the guide manager on the phone"`
- [ ] **Step 4: Phone check with the user**: the Pages URL opens on their phone, the key is saved, a ตรวจอย่างเดียว passes; the next real guide is published from the phone while they watch, and the Bible shows it within a few minutes.
