# Guide manager on the phone: design (2026-10-20)

## Intent

Class guides arrive while the user is out, with the PC at home switched off. Today the guide manager ([scripts/add_guide.js](../../../scripts/add_guide.js), opened by `scripts/add_guide.cmd` / the "12Tails Add Guide" Desktop shortcut) runs only on the PC: it serves a page on `127.0.0.1:4782`, edits `CLASS_GUIDES` in `12t_projects/bible/index.html`, runs the full validator, commits and pushes. The phone version lets the user do all of that from a phone browser, anywhere, with no PC involved: GitHub's servers run the same pipeline. It should look and work as close to the desktop page as possible.

## Goals

- From a phone: add, replace and delete guides; the live preview of a pasted code; the queue (batch publish in one commit); ตรวจอย่างเดียว; undo of the last publish; the guide list with search, views and the removed list. Everything the desktop page does today.
- The repo ends up exactly as if the desktop manager had done it: the same `CLASS_GUIDES` lines and tombstones, one changelog entry equal to the commit subject, the full validator, one commit, push, all or nothing.
- The same look as the desktop page (header, logo, colours, cards, Thai wording).
- Works with the PC off.

## Non-goals

- Carrying a queue between devices (a queue lives in the browser it was made in).
- Anyone but the user publishing; no accounts or sharing (my call).
- Refreshing view counts (`scripts/guide_views.js`) as part of a publish (the desktop pipeline does not either).
- A link from the Bible to the manager.
- A notification when a run finishes (my call): the page shows the outcome when it is next open.

## Anti-goals

- Two copies of the page, or of the pipeline, that can drift apart.
- Any way for someone without the user's key to change the repo.
- The key going anywhere except `api.github.com`.
- A heavy page on mobile data: `assets.js` (27 MB) is never loaded.
- A batch that goes up half done.
- Any change in how the desktop manager behaves (shortcut, `add_guide.cmd`, page, CLI).
- Project design rules broken: a third font (Prompt for text, `'JetBrains Mono','Prompt',monospace` for numbers only), a soft gold glow on hover.

## Decided with the user

- **The PC is off and the user is away from home**, so the work runs on GitHub (the repo `jumpptty/12tails` is public; the Bible is served from GitHub Pages).
- **Add, replace and delete** are all needed on the phone.
- **As close to the desktop app as possible**: every extra (preview, queue, ตรวจอย่างเดียว, undo, list) comes along.
- **Played back and agreed:** the page lives on the GitHub Pages site and is saved to the phone's home screen; a GitHub key is pasted once per phone and remembered there; pressing อัปขึ้น GitHub makes GitHub run the same steps (about 2 minutes) with the same ticking step list; one page serves both PC and phone (on the PC it talks to `add_guide.js` as now, on the phone to GitHub); undo covers the last publish made from that phone; the user runs `git pull` at home before working on the PC.
- **Layout B, bottom tabs** (picked from three phone mocks: one long page, bottom tabs, list first), with the detail screens below agreed as described.

## How it works

### One page, two backends

- The page moves out of the `PAGE` string in `add_guide.js` into its own self-contained file, `12t_projects/guide-manager/index.html` (my call for the location; AGENTS.md: every deliverable in `12t_projects/` is its own folder and one self-contained file). `add_guide.js` serves that file on `127.0.0.1` with the start-up key put in exactly as today. GitHub Pages serves the same file at `https://jumpptty.github.io/12tails/12t_projects/guide-manager/`.
- **The backend follows where the page runs:** on `127.0.0.1` / `localhost` it uses today's local API (`/api/state`, `/api/check`, `/api/run`, `/api/undo`, the NDJSON progress stream), unchanged. Anywhere else it uses GitHub ("GitHub mode").
- **The layout follows the window width:** wide windows get today's two-column layout, narrow ones get layout B. Both work with either backend (a PC browser on the Pages address gets GitHub mode in the wide layout).
- The desktop manager must keep working exactly as it does now; moving the page is the only change it sees.

### The phone screen (layout B)

- **Header:** logo, **จัดการไกด์อาชีพ** (the subtitle line hidden on narrow screens), the status pill (พร้อม / กำลังอัป / ยังไม่มีกุญแจ / a short error such as ต่อ GitHub ไม่ได้), and the ↶ ย้อนกลับ button when there is a publish to undo.
- **Tabs at the bottom:** ＋ **วางโค้ด**, ☰ **รายการที่จะอัป** (with a red count badge when the queue is not empty), ▦ **ไกด์ทั้งหมด**. The page opens on วางโค้ด (my call: pasting a new code is the usual reason to open it).
- **Publish bar:** whenever the queue has items, a bar sits just above the tabs on every tab: "รอ N รายการ" and the gold **อัปขึ้น GitHub (N)** button (its label follows ตรวจอย่างเดียว as on the desktop). It opens the same confirm dialog as the desktop, then switches to the รายการที่จะอัป tab where the steps run.
- **วางโค้ด:** the desktop editor card: the code box, the preview (class face, title, author, chips "จะได้เลข #N" or "แทนที่ #N", class, server, Lv, date with the "(แก้จาก …)" / "(โค้ดไม่มีวันที่ ใช้วันนี้)" note), the PVE / PVP buttons and hint, the same-title warning with "หรือแทนที่ #N ด้วยโค้ดนี้", the unreadable-code message (Discord italics hint), and **ใส่ในรายการ**. Tapping แทนที่ on a guide in ไกด์ทั้งหมด jumps here in replace mode: the card gets a gold edge, the title "แทนที่ไกด์ #N <title>", a ยกเลิก button, and the button reads "ใส่การแทนที่ #N ในรายการ".
- **รายการที่จะอัป:** the queue card (action badge, planned number, face, title, author · class · server · modes, ✕ per row, ↶ ย้อน, ล้าง, ตรวจอย่างเดียว), then the progress card once a run starts: the step rows with the running timer, then the result (the commit subject and เปิดไกด์ #N links, or the error in red with the validator's error lines in the log box). In GitHub mode the step list starts with ส่งงานให้ GitHub, then the desktop's ตรวจสถานะ git, แก้ไฟล์ index.html, ตรวจด้วย validator, commit, อัปขึ้น GitHub. A line under it says the phone can be locked or the page closed and the run carries on.
- **ไกด์ทั้งหมด:** the search box, then one row per guide (number, face, title, author · class · server · modes, date · 👁 views, แทนที่ and ลบ stacked on the right, or "ในรายการ: …" when the guide is queued), and ไกด์ที่ลบแล้ว at the bottom.
- Touch targets big enough for a thumb, room for the phone's home bar at the bottom (safe-area insets), the app shell fills the screen without the page itself scrolling sideways.
- The desktop-only "index.html มีงานค้าง" banner never shows in GitHub mode (GitHub always starts clean).

### GitHub mode: the key

- A GitHub fine-grained personal access token, limited to the `12tails` repo, with **Actions: Read and write** (plus the Metadata read every token has). It is saved in that browser only (localStorage) and sent only to `api.github.com`. The page limits where it may connect (a Content-Security-Policy `connect-src` for `api.github.com` and, in local mode, its own server) and asks search engines not to index it.
- **First visit, no key, or a key GitHub rejects:** the key screen ("ใส่กุญแจ GitHub (ครั้งแรกครั้งเดียว)"): three short steps with a link to `https://github.com/settings/personal-access-tokens/new`, a box to paste the key, **บันทึกในเครื่องนี้**, and a line saying the key stays on this phone and nobody can change anything without it. A quiet **ลืมกุญแจ** removes it (where it lives is the builder's call).
- The address is public. Without the key the page can read only what the public repo already shows.
- If the verified result channel (below) needs another permission on the key, it may only be a read permission (for example Contents or Checks: Read); the key screen's steps list exactly what the key needs. Calls should not fall back to no key at all: the 60-requests-an-hour limit is shared by everyone on the same mobile network address.

### GitHub mode: reading the guides

- The guide list, removed list, next id and view counts come from the **current** `index.html` on the default branch, read through the GitHub API (raw file content). Not from GitHub Pages or `raw.githubusercontent.com`, which lag minutes behind a push. Parsing follows `readGuides` / `parse` / `nextId` exactly.
- `index.html` is about 4 MB; repeat loads should be cheap (conditional requests or similar; builder's call). `assets.js` is never loaded.
- **Class faces:** the 12 `CLASS_HERO_ICONS` (about 55 KB) are embedded in the page (my call), and the validator gains a check that they still equal the ones in `assets.js`, so a portrait repaint cannot leave the manager stale.
- **The live preview runs in the browser** in GitHub mode: find the code (TG3 / TG2 / 12TG1, as `findCode`), decode, the format checks of `decodeCode`, `fixDate`, the same-title-and-author check, the next number. The decoder must not drift from [scripts/guide_code.js](../../../scripts/guide_code.js): either one implementation both can load, or a validator check that the page's decoder reads every current guide's code exactly as `guide_code.js` does (builder's call). Browsers decompress with `DecompressionStream("deflate-raw")`, which the Bible already relies on.

### GitHub mode: publishing

- **A new workflow** `.github/workflows/guide-manager.yml`, started only by `workflow_dispatch`. Its inputs: the queue as JSON in the same shape the desktop page posts to `/api/run` (`[{ action, id, code, modes }]`), the dry-run flag, a request id, and for an undo the undo entries instead of a queue. GitHub caps a dispatch at 65,535 characters of inputs; today's codes are 31 to 957 characters, so dozens of items fit. The page refuses a queue that would not fit, with a message.
- **The same pipeline code as the desktop:** `add_guide.js` gets a non-interactive batch entry (for example `node scripts/add_guide.js batch <file> [--dry-run]`, or an undo form) that calls the existing `planAll` / `apply`. One pipeline, two callers; nothing about guide editing is written twice.
- **The job:** Ubuntu, a current Node (the PC runs v24), a shallow checkout of the default branch (`skill-cooldown-lookup`; the tracked files are about 39 MB, the 575 MB history must not be fetched; the validator reads `HEAD` through `git show`), `TZ=Asia/Bangkok` so `fixDate`'s "today" is the user's day, then the batch entry. Permission `contents: write` for the push. One run at a time (a concurrency group). GitHub keeps one waiting run and cancels an older waiting one when a newer one arrives; the page shows that as cancelled, with a link to the run.
- **Commits** carry the user as author, as the history does (`Jump`), with the workflow as committer (my call), and the same subject rules as the desktop.
- **The steps** (ส่งงานให้ GitHub, ตรวจสถานะ git, แก้ไฟล์ index.html, ตรวจด้วย validator, commit, อัปขึ้น GitHub) must be visible to the page as the run progresses, so it can tick the same rows; for example one workflow step per pipeline step, read through the run's jobs API. The page polls while it is visible. Splitting the pipeline across workflow steps is fine: on GitHub, all or nothing holds by construction, since nothing reaches the repo before the push step and a failed run leaves only a throwaway checkout.
- **Finding the run:** the request id goes into the run's name, so the page can find its run among the workflow's runs. The pending request id is kept in localStorage, so a reload, a sleeping phone or a closed tab picks the run up again and shows how it ended.
- **The result must reach the page:** on success, the commit subject, the real numbers (for the เปิดไกด์ #N links) and the undo entries; on failure, the pipeline's Thai error message and the validator's error lines, as the desktop shows them. **Verify the channel first, before the UI work**, from a phone browser holding only the key above. Candidates: derive success from the repo itself (the new commit's subject; the before and after `CLASS_GUIDES` lines give the numbers and undo entries); error lines as workflow annotations (`::error::`), which the check-runs annotations API returns for a public repo; the job log API (check that its redirect can be read from a browser).
- **Branch protection:** `skill-cooldown-lookup` is protected (force-pushes are refused; plain pushes from the PC go through). Verify the workflow's own token may push to it too; if a rule blocks it, the fix is a rule exception for the workflow, never a force-push.
- **GitHub Pages:** the site is built by GitHub's "Deploy from a branch" (`pages-build-deployment`). Verify that a push made with the workflow's own token starts a Pages build; if it does not, the workflow requests one (`POST /repos/{owner}/{repo}/pages/builds`, permission `pages: write`).
- After a successful real publish the queue is cleared, as on the desktop; a dry run leaves it.

### Undo in GitHub mode

- ↶ ย้อนกลับ reverses the last publish made from this phone, the whole batch, through the same workflow (the desktop's undo entries, `{ entries, text }`, kept in localStorage). On the desktop, undo stays as it is (since start-up, Ctrl+Z as now).
- If those guide lines changed since, the pipeline's existing errors apply (for example "ไม่พบไกด์ #N ในไฟล์") and nothing goes up.

### Working with the PC

- Phone commits reach GitHub first; the user runs `git pull` before working on the PC (already their habit). The desktop manager already fast-forwards before a push and refuses when the two sides differ.
- The desktop shortcut, `add_guide.cmd` and the CLI (`add`, `replace`, `delete`, `--dry-run`, `--no-push`, `--yes`, `--modes`) stay as they are.

## Constraints

- Everything in the repo is public: no secrets in the workflow or the page.
- The default branch, and the one Pages serves, is `skill-cooldown-lookup`.
- `index.html` uses CRLF line endings; never `git checkout` / `restore` / `reset` / `stash` it (hook-guarded on the PC).
- The full validator takes about 38 s on the PC; it only reads tracked files, so it runs the same on GitHub.
- Self-contained single file for the page; Prompt and JetBrains Mono only; no soft gold glow on hover.

## Docs to update

- [12t_projects/bible/CLASS-GUIDES.md](../../../12t_projects/bible/CLASS-GUIDES.md): the guide manager paragraph (the phone version, the key setup, the workflow, the `git pull` note).
- [CLAUDE.md](../../../CLAUDE.md) commands (the batch entry; its `add_guide.js` line still lists "views" in the pipeline, which the current code no longer refreshes) and [AGENTS.md](../../../AGENTS.md) directory list (`12t_projects/guide-manager/`).

## Left to the builder

The narrow-width breakpoint; the tab icons; the polling interval; how the decoder is shared or checked; the result channel (once verified); where ลืมกุญแจ lives; caching of `index.html`; the workflow's exact YAML; tests for the batch entry.

## Verification

- `node scripts/validate_skills.js` passes, including the new face and decoder checks.
- Local mode unchanged: the Desktop shortcut opens the page, a dry run of a queued change passes.
- In GitHub mode: a ตรวจอย่างเดียว run from the phone end to end (steps tick, result shows), a failing code shows its error lines, a reload mid-run resumes.
- The first real publish from the phone is the user's next real guide, watched.
- This is a new layout, so one browser check at phone width is in order (the project's no-browser rule is for small changes).

## Verified on GitHub (2026-10-20)

Probed from the user's Chrome with the key (fine-grained, `12tails` only, Actions: Read and write, Metadata: Read-only, expires 2027-10-20) against the skeleton workflow:

- **Reading `index.html`:** the contents API returns the raw file (3.66 M characters); a second read with `cache: "no-cache"` is a free revalidation (rate limit unchanged).
- **Starting a run:** `POST …/dispatches` with `return_run_details: true` answers 200 with `workflow_run_id`, so the page knows its run at once; the run-name search (`guide manager <request>`) also finds it within 5 s.
- **Progress:** the jobs API shows each step's status; steps not started yet are `pending`, a run goes `pending` → `queued` → `in_progress` → `completed`.
- **Results:** check-run annotations are readable with the key; titles and line breaks survive, **but a message is cut at 4,096 characters**, so `add_guide.js batch` keeps its reports under 4,000 (a long batch subject is shortened with "…"). The job log is also readable from a browser (a fallback channel, unused).
- **Push and Pages:** a push made with the workflow's own token is accepted on the protected branch (author Jump, committer github-actions[bot]; test commit `ee65805`), and it starts "pages build and deployment" by itself, so the workflow needs no Pages step.
- GitHub flags `actions/checkout@v4` / `actions/setup-node@v4` as Node 20; the workflow uses `@v5`.

## After the final review (2026-10-20)

A fresh reviewer read the whole change. Fixed:

- **Pasted codes are untrusted.** A legacy `12TG1.` code could carry any class or server text, which the page put into its HTML (a crafted code could run script and read the key). Both `add_guide.js decodeCode` and the page's `gmCheckGuide` refuse a class or server that is not a real one, and the page escapes every value it puts into HTML, including what comes back from its saved queue.
- **A dropped connection never ends a run.** The run is recorded before GitHub is asked; a failed request is retried with backoff (the pill says "ต่อ GitHub ไม่ได้ กำลังลองใหม่…"); every successful load follows a recorded run again; publish and undo stay off while one is recorded. Only GitHub's own answer ends it: a result, an error note, a cancelled run, a deleted run (404), or a finished run without a readable result ("ตรวจใน GitHub ก่อนอัปซ้ำ", with the link). A finished publish takes out of the queue only what it sent. The progress card says the phone can be locked.
- **A result note counts only from a run that succeeded**, and `batch` indents the validator's raw lines, so nothing a guide contains can pass as a GitHub workflow command.
- **Undo from the phone refuses when a guide changed after that publish** ("ไกด์ #N ถูกแก้หลังจากนั้นแล้ว ย้อนกลับไม่ได้"), and the lines it puts back are rebuilt in the standard form, never copied raw.

Open (the user's call): **the key is stored for the whole `https://jumpptty.github.io` site**, which also serves the Bible with its GoatCounter script (`gc.zgo.at`). The manager's own CSP does not cover those pages, so a script there could read the key. The key can only start the guide job on `12tails` (Actions), which limits the damage. A short PIN that locks the stored key would close this.

Deferred: GitHub's 4,096 cut may count bytes rather than characters (Thai is 3 bytes); only a very large batch could reach it, and the page then says to check GitHub. A 403 from a secondary rate limit is reported as a key without Actions write.
