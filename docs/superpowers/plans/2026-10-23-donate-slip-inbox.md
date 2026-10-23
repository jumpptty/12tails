# Donations with a donor thank-you list: Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** The Bible's ☕ pop-up takes donations by QR download, lets donors send a slip to the user's private Discord through a Cloudflare Worker, and shows a merged, biggest-first donor list that the user approves from the guide manager on their phone.

**Architecture:** One pure CommonJS module, `scripts/donors.js`, holds the donation rules, the `DONORS` line format, grouping and the approve-link fragment. The Worker bundles it, `scripts/add_guide.js` uses it in the existing guide pipeline, and the two self-contained pages carry copies that the validator checks against it (the existing gm-core pattern). Donations are stored one line each in a `const DONORS = [ … ];` block in `12t_projects/bible/index.html`, edited only by the guide pipeline.

**Tech Stack:** Node 24 (PC and GitHub Actions), plain browser JS in self-contained HTML, Cloudflare Workers (Wrangler, ESM, Rate Limiting binding), Discord webhooks, GitHub Actions (existing `guide-manager.yml`).

**Spec:** [docs/superpowers/specs/2026-10-23-donate-slip-inbox-design.md](../specs/2026-10-23-donate-slip-inbox-design.md)

## Global Constraints

- Donation wording: ค่าพัฒนา and ค่าเซิร์ฟเวอร์ในอนาคต; never "AI" / ค่า AI.
- A slip, or a real name from a slip, never reaches the repo, the Bible, a commit or the changelog. Only the donor's typed display name does.
- The Discord webhook URL exists only as the Worker secret `DISCORD_WEBHOOK_URL`. No secret in any tracked file.
- Claude never types a token, webhook URL, password or account number into any field or file; the user does those steps.
- Donor publishes (`donor-add`, `donor-remove`) add **no** `CHANGELOG_DATA` entry. Every other commit touching `index.html` keeps the changelog habit (12t_projects/bible/CLAUDE.md §1.4).
- A donor-remove commit subject never contains the donor's name: `fix(bible): remove a donation`.
- Limits (one source: `LIMITS` in `scripts/donors.js`): name 1–40 characters, message 0–200 characters (counted as code points, whitespace collapsed to single spaces, trimmed), amount > 0 and ≤ 1,000,000 baht with at most 2 decimals, date `YYYY-MM-DDTHH:MM` (Thailand time) from 2020-01-01 to now + 1 day, slip ≤ 5 MB of `image/jpeg`, `image/png` or `image/webp`.
- `index.html` is CRLF and about 4 MB: patch it with a scratch Node script that backs it up first; never `git checkout` / `restore` / `reset` / `stash` it.
- Fonts: Prompt for text, `'JetBrains Mono','Prompt',monospace` for numbers. No soft gold glow on hover. Dark theme tokens only; new panels join `THEME_SURFACES`. Every extra `<script>` carries an id.
- `node scripts/validate_skills.js` passes after every task; `--full` before every push. Default branch `skill-cooldown-lookup`, repo public.

## Review Focus

1. **Thai, emoji and line breaks in name or message.** Counted per code point, so an emoji is never split. Line breaks collapse to one space. Over-long text is refused with the limit in the message, never cut silently. → Task 1 test `checkDonation counts code points and collapses whitespace`.
2. **A slip straight from a phone camera** (a 12 MB Android JPEG, an iPhone HEIC). The page redraws it as a JPEG of at most 1600 px on the long side at quality 0.85. If the browser cannot decode it, the page says so in Thai and keeps the form. → Task 7 test `shrinkSlip turns a big image into a small JPEG` (validator sandbox with a canvas stub) and the browser check.
3. **Amounts typed the Thai way** ("1,000", "฿50", "50.5", " 20 "). The form strips `฿`, commas and spaces before checking. "abc", "0" and "-5" are refused with a message. → Task 7 test `parseAmountInput`.
4. **A double tap on send, or the same slip sent twice.** The send button is disabled while a send runs. The Worker's per-IP limit answers `rate`, which the page shows as "ส่งถี่เกินไป รอสักครู่แล้วลองใหม่". → Task 5 test `third send within a minute is refused with rate`.
5. **The same อนุมัติ link opened twice.** If a donation with the same name, amount and date is already in the list or the queue, the manager says so and keeps the card unqueued until the user confirms. → Task 4 test `gmDuplicateDonation finds the same donation in list or queue`.

---

### Task 1: `scripts/donors.js`, the shared donation rules

**Files:**
- Create: `scripts/donors.js`

**Interfaces:**
- Produces (CommonJS, no `fs`, no Node-only APIs, so the Worker can bundle it):
  - `LIMITS = { name: 40, msg: 200, amountMax: 1000000, slipBytes: 5242880, slipTypes: ["image/jpeg", "image/png", "image/webp"], dateMin: "2020-01-01T00:00" }`
  - `checkDonation(d: { name, msg, amount, date }, now = new Date()) -> { name, msg, amount, date }` normalised (see Global Constraints), or throws `Error` with a Thai message naming the field.
  - `newKey() -> string`, 8 lowercase hex characters from `globalThis.crypto.getRandomValues`.
  - `donorLine(x: { k, id, name, msg, amount, date }) -> string`: `"  " + JSON.stringify({ k, id, name, msg, amount, date }).replace(/</g, "\\u003c") + ","` (keys in that order).
  - `parseDonors(html: string) -> { eol, head, tail, lines: string[], donations: [{ at, x }] }`. Mirrors `parseDoc` in `add_guide.js` for the block that opens `const DONORS = [<eol>` and closes `<eol>];`; throws `Error("DONORS was not found")`.
  - `groupDonors(donations: x[]) -> [{ id, name, msg, total, count, date, first }]`: one row per `id`. `name` and `date` come from the latest donation by `date`, `msg` from the latest non-empty one, `total` is summed in satang so there are no float errors, `first` is the earliest date. Sorted by `total` descending, then `first` ascending.
  - `donorFragment(d) -> string`: `"donor=" + base64url(UTF-8 JSON of { name, msg, amount, date })`. `fromFragment(hash: string) -> d | null` reverses it (it accepts a leading `#`; null for anything else).
  - `module.exports = { LIMITS, checkDonation, newKey, donorLine, parseDonors, groupDonors, donorFragment, fromFragment }`, and `node scripts/donors.js --selftest`.

- [ ] **Step 1: Write the self-test (fails: the module does not exist)** with these cases, in the style of `add_guide.js selftest` (named cases, `ok`/`FAIL` lines, exit 1 on failure):
  - `checkDonation counts code points and collapses whitespace`: `name: "  ก้อง\n 🐱 "` gives `"ก้อง 🐱"`. A 40-emoji name passes, 41 throws `/40/`. A message of 200 Thai characters passes, 201 throws `/200/`.
  - `checkDonation amount`: `50`, `0.5` and `1000000` pass; `0`, `-1`, `1.234`, `1000000.01`, `"50"` (a string) and `NaN` throw.
  - `checkDonation date`: `"2026-10-23T14:05"` passes with `now = 2026-10-23T08:00Z`; `"2026-10-25T00:00"` (more than a day ahead), `"2019-12-31T23:59"`, `"2026-02-30T10:00"` and `"2026-10-23 14:05"` throw.
  - `donorLine escapes "<"`: a name `"</script>"` gives a line containing `</script>`.
  - `parseDonors reads CRLF and LF blocks`, and throws when the block is missing.
  - `groupDonors merges by id and sorts`: A gives 100 then 50 (row total 150, count 2, latest name and message); B gives 150 once, earlier than A's first. Expect B before A (tie on 150, B first gave earlier). `0.1 + 0.2` sums to exactly `0.3`.
  - `fragment round trip`: Thai, emoji and `&#=` survive `fromFragment(donorFragment(d))`; `fromFragment("#donor=@@@")` and `fromFragment("#x=1")` are `null`.
  - `newKey`: 8 hex characters; 1,000 keys have no repeat.
- [ ] **Step 2: Run** `node scripts/donors.js --selftest`. Expected: fails (module missing).
- [ ] **Step 3: Implement `scripts/donors.js`** to the Interfaces above. Base64url uses `btoa` / `atob` over UTF-8 bytes (`TextEncoder` / `TextDecoder`), so it runs unchanged in Node 24, Workers and browsers.
- [ ] **Step 4: Run** `node scripts/donors.js --selftest`. Expected: `donors selftest: all checks passed (8)`.
- [ ] **Step 5: Commit** `scripts/donors.js`: `feat(scripts): donors.js, the shared donation rules for the ☕ donor list`.

### Task 2: the `DONORS` block in the Bible and its validator check

**Files:**
- Modify: `12t_projects/bible/index.html` (a new block right after `CLASS_GUIDE_VIEWS`, about line 27549; plus a changelog entry)
- Modify: `scripts/validate_skills.js` (a new check after the CLASS_GUIDES checks)

**Interfaces:**
- Consumes: `parseDonors`, `checkDonation`, `donorLine` (Task 1).
- Produces: `const DONORS = [` + CRLF + `];` in `index.html`, empty for now, with a one-line comment above it pointing to `scripts/donors.js` and saying the guide manager edits it. Validator lines tagged `[DONOR ERROR]`.

- [ ] **Step 1: Add the validator check first.** For every DONORS line: it parses; `k` and `id` are 8 hex characters; `k` is unique; `checkDonation(x)` accepts it (default `now`); and the line equals `donorLine(x)`, so hand-edited spacing or key order is caught. It also reports a missing block. On success it logs `Verified N donation(s) in DONORS.`
- [ ] **Step 2: Run** `node scripts/validate_skills.js`. Expected: `[DONOR ERROR] DONORS was not found` and a failing exit.
- [ ] **Step 3: Add the empty block** with a scratch script (backup, CRLF). Add a changelog entry equal to the commit subject.
- [ ] **Step 4: Check the fixtures:** in a scratch copy of `index.html`, put in one valid line and one with `"amount":0`, and run `node scripts/validate_skills.js --index <copy>/index.html`. Expected: one `[DONOR ERROR]` naming amount; the real file passes.
- [ ] **Step 5: Commit** both files: `feat(bible): empty DONORS list for the ☕ donor thanks, checked by the validator`.

### Task 3: donor items in the guide pipeline (`scripts/add_guide.js`)

**Files:**
- Modify: `scripts/add_guide.js`

**Interfaces:**
- Consumes: Task 1 exports; the `DONORS` block (Task 2).
- Produces:
  - Queue items: `{ action: "donor-add", donor: { id, name, msg, amount, date } }`, where `id` is the existing donor's id or a new 8-hex id made by the page, and `{ action: "donor-remove", k }`. `opsFromItems` turns them into `{ action: "donor-add", x: { k: newKey(), id, ...checkDonation(donor) } }` and `{ action: "donor-remove", k }`. A bad item fails as `รายการที่ N: <reason>`.
  - `planAll(ops, doc)` keeps its return shape and adds `donorLines: string[]` and `changelog: string | null`. `doc` gains `donors` from `parseDonors(doc.html)`.
  - Subjects: add gives `feat(bible): ขอบคุณผู้สนับสนุน <name>` (the name through `subj`, line breaks already gone via `checkDonation`). Remove gives `fix(bible): remove a donation`. A batch joins all subjects with `; `. `changelog` is the guide-only subject when the batch has guide ops (exactly what the subject would be without the donor parts), else `null`.
  - Result `items` for donors: `{ action: "donor-add", k }` and `{ action: "donor-remove", k }`.
  - Undo entries: `{ kind: "donor", k, before: line | null, after: line | null, text }` (texts `เอาการสนับสนุนที่เพิ่งเพิ่มออก` and `คืนการสนับสนุนที่เพิ่งเอาออก`). `plan`'s `"undo"` handles `kind === "donor"`, and refuses with `การสนับสนุนนี้ถูกแก้หลังจากนั้นแล้ว ย้อนกลับไม่ได้` when the current line differs from `after`. `undoOpsFromCommit(sha)` also diffs DONORS by `k`.
  - `stageEdit` writes both blocks and prepends a changelog entry only when `p.changelog` is set. `batch`'s plan file stores `changelog`.
  - `pageData()` gains `donations: [{ k, id, name, msg, amount, date }]` (file order). Export `parseDonors` again for tests.

- [ ] **Step 1: Extend the self-test fixture** with a `const DONORS = [`…`];` block holding one donation (`k: "aaaaaaaa"`, `id: "11111111"`, name `"Old"`, amount 100), and add the failing cases:
  - `donor-add alone: a DONORS line, subject names the donor, no changelog entry`: the newest changelog entry is still `"init"`, `subject(dir)` is `feat(bible): ขอบคุณผู้สนับสนุน New`, and the new line matches `donorLine`.
  - `donor-remove: the line goes, subject has no name`: subject `fix(bible): remove a donation`, and the html no longer contains `"Old"`.
  - `mixed batch: guide add + donor add`: the commit subject has both parts; the changelog entry equals only `feat(bible): class guide #3 ToT Wolf T3 by A3`.
  - `a bad donor item names its position`: `[guide add, donor-add with amount 0]` rejects with `/รายการที่ 2:/`, and index.html is unchanged.
  - `undo from a commit reverses donor add and remove`: add one, remove "Old" in one batch, then `undoOpsFromCommit(head)`. After `apply`, the DONORS lines equal the fixture's.
  - `batch stages: a donor-only request passes git→push`: `notice(r.stdout).items` deep-equals `[{ action: "donor-add", k }]` with the `k` read back from the file, and there is no changelog entry.
  - `a name with </script> stays escaped through the batch`.
- [ ] **Step 2: Run** `node scripts/add_guide.js --selftest`. Expected: the new cases FAIL; the old ones still pass.
- [ ] **Step 3: Implement** the Interfaces above in `add_guide.js`, keeping guide behaviour byte-identical. Guide ops plan on CLASS_GUIDES lines and donor ops on DONORS lines, both in queue order.
- [ ] **Step 4: Run** `node scripts/add_guide.js --selftest` and `node scripts/validate_skills.js`. Expected: `add_guide selftest: all checks passed (24)` (17 existing + 7 new), and the validator passes.
- [ ] **Step 5: Commit** `scripts/add_guide.js`: `feat(scripts): guide pipeline adds and removes ☕ donations (no changelog entry for them)`.

### Task 4: the guide manager's donor tab and the อนุมัติ link

**Files:**
- Modify: `12t_projects/guide-manager/index.html` (gm-core block, a 4th tab, queue rendering, `publish`, `qsig`, `githubBackend.state`)
- Modify: `scripts/validate_skills.js` (gm-core agreement checks)
- Modify: `12t_projects/bible/CLASS-GUIDES.md` (the guide manager section: the donor tab, the link, no changelog)

**Interfaces:**
- Consumes: the queue item shapes and `pageData().donations` (Task 3); `donorFragment` (Task 1) for the link's format.
- Produces, inside `// gm-core start … // gm-core end`:
  - `GM_DONOR_LIMITS` (same values as `LIMITS`)
  - `gmCheckDonation(d, now)` (same rules and messages as `checkDonation`)
  - `gmParseDonors(html) -> donations[]`
  - `gmFromFragment(hash) -> d | null`
  - `gmGroupDonors(donations)` (same as `groupDonors`)
  - `gmDonorMatches(rows, name) -> rows[]` (trimmed, case-insensitive match on the latest name)
  - `gmDuplicateDonation(d, donations, queue) -> boolean` (same name, amount and date)
  - `gmNewId() -> string` (8 hex)
- UI:
  - A 4th bottom tab **♥ ผู้สนับสนุน** (`data-tab="donors"`). It holds the donor card (fields name, message, amount, date; a select **ผู้สนับสนุนเดิม** listing existing donors; **ใส่ในรายการ**) and the donor list: each donor row expands to its donations, each with **ลบ**, which queues a `donor-remove`.
  - When the name matches an existing donor, the card shows **เพิ่มให้ "<name>" (รวม ฿Y)** and **แยกเป็นคนใหม่**, and nothing is queued until one is picked.
  - When `gmDuplicateDonation` is true, the card says `รายการนี้มีอยู่แล้ว (ชื่อ ยอด และวันเวลาเดียวกัน)` and queues only after a second tap on **ใส่ซ้ำ**.
  - Queue rows: `ACT` gains `"donor-add": "ขอบคุณ"` and `"donor-remove": "เอาออก"`. Donor rows show the name, amount and date instead of the class face.
  - On load, `#donor=…` in `location.hash` fills the card, switches to the donor tab, and is then removed with `history.replaceState`.

- [ ] **Step 1: Add the failing validator checks** (in the gm-core block's checks): `gmCheckDonation` gives the same result or message as `checkDonation` on Task 1's cases; `gmParseDonors(html)` equals `parseDonors(html).donations.map((d) => d.x)` on the real page and on a fixture; `gmGroupDonors` equals `groupDonors` on the Task 1 data; `gmFromFragment(donorFragment(d))` equals `d` for the Thai/emoji case. The new Review Focus case `gmDuplicateDonation finds the same donation in list or queue` gives true for a list match and a queue match, and false when only the amount differs. The CSP check stays as it is.
- [ ] **Step 2: Run** `node scripts/validate_skills.js`. Expected: `[GUIDE MANAGER ERROR] gm-core: gmCheckDonation is not defined` (or similar), failing.
- [ ] **Step 3: Implement** the gm-core functions, then the tab, card, list, queue changes and fragment handling. Every donor value goes through `esc()`. `qsig` includes the donor's `k` or its fields. `publish()` sends donor items as Task 3's shapes. `githubBackend.state()` and `localBackend` both return `donations`.
- [ ] **Step 4: Run** `node scripts/validate_skills.js` and `node scripts/add_guide.js --selftest`. Expected: both pass. Then a local check: `node scripts/add_guide.js --no-open`, open `http://127.0.0.1:4782/#donor=<fragment for a test donor>`, queue it, tick ตรวจอย่างเดียว, publish (dry run). Expected: the steps tick, ok, and index.html is unchanged.
- [ ] **Step 5: Update CLASS-GUIDES.md**, then commit the page, the validator and the doc: `feat(guide-manager): ♥ ผู้สนับสนุน tab, approve a donation from its Discord link`.

### Task 5: the Worker

**Files:**
- Create: `12t_projects/donate-worker/src/index.js`, `12t_projects/donate-worker/src/handler.js`, `12t_projects/donate-worker/test.mjs`, `12t_projects/donate-worker/wrangler.toml`, `12t_projects/donate-worker/README.md`
- Modify: `CLAUDE.md` (Commands: `node 12t_projects/donate-worker/test.mjs`, deploy), `AGENTS.md` (directory list)

**Interfaces:**
- Consumes: `LIMITS`, `checkDonation`, `donorFragment` (Task 1), imported from `../../../scripts/donors.js` (Wrangler bundles it).
- Produces:
  - `handleSlip(request: Request, env: { DISCORD_WEBHOOK_URL, SLIP_LIMIT }, deps: { fetch, now }) -> Promise<Response>`. `POST /slip` with multipart fields `name`, `msg`, `amount` (string, turned into a number with `Number()`; empty means `missing`), `date`, `slip` (file).
  - JSON answers: `{ ok: true }`, or `{ ok: false, error }` with `error` one of `origin`, `method`, `missing`, `invalid` (plus `field` and the Thai `message` from `checkDonation`), `file-type`, `file-size`, `rate`, `discord`.
  - CORS: `Access-Control-Allow-Origin` echoes `https://jumpptty.github.io` or `null` (a double-clicked local copy). Any other origin gets 403 `origin`.
  - Rate limit: `env.SLIP_LIMIT.limit({ key: CF-Connecting-IP })`, a Workers Rate Limiting binding of 2 requests per 60 s.
  - Discord: one `POST <webhook>?wait=true` multipart with `payload_json`. Its content is `**[อนุมัติ](https://jumpptty.github.io/12tails/12t_projects/guide-manager/#<donorFragment>)**`. It has one embed (title `สลิปใหม่`; fields ชื่อ / ยอด / วันเวลาที่โอน / ข้อความ, with donor text escaped for Discord markdown; `image.url = "attachment://slip.<ext>"`), `allowed_mentions: { parse: [] }`, and the slip as `files[0]`. Non-2xx gives `discord`.
  - `src/index.js`: `export default { fetch: (req, env) => handleSlip(req, env, { fetch, now: () => new Date() }) }`.
  - `wrangler.toml`: name `12tails-donate`, main `src/index.js`, a current `compatibility_date`, and the `[[ratelimits]]` binding `SLIP_LIMIT` (namespace id `1001`, `simple = { limit = 2, period = 60 }`). No secrets.
  - README: the user's setup in order. (1) Make a private Discord channel and its webhook. (2) Make a free Cloudflare account. (3) `npx wrangler login` (in their browser). (4) `npx wrangler deploy` from the folder. (5) `npx wrangler secret put DISCORD_WEBHOOK_URL` (they paste it). (6) Note the `*.workers.dev` URL. Plus the Android note: if the อนุมัติ link opens without the key, turn off Discord's in-app browser.

- [ ] **Step 1: Write `test.mjs`** with a fake `fetch` that records the Discord call, a fake `SLIP_LIMIT` that allows N calls, and these failing cases:
  - `good send forwards one Discord post`: one call; its `payload_json` has `allowed_mentions.parse` = `[]`, and an อนุมัติ link whose fragment `fromFragment` decodes to the sent donation; `files[0]` is the slip; the answer is `{ ok: true }` with ACAO `https://jumpptty.github.io`.
  - `other origin is refused`: `Origin: https://evil.example` gives 403 `origin`, and no Discord call.
  - `missing slip` gives `missing`; `name of 41 characters` gives `invalid` with `field: "name"`; `amount "abc"` gives `invalid`.
  - `pdf slip` gives `file-type`; `5 MB + 1 byte` gives `file-size`.
  - `third send within a minute is refused with rate` (the limiter fake allows 2).
  - `@everyone and a markdown link in the message stay inert`: the embed field shows them escaped, and `allowed_mentions` stays empty.
  - `Discord 500` gives `{ ok: false, error: "discord" }`.
- [ ] **Step 2: Run** `node 12t_projects/donate-worker/test.mjs`. Expected: fails (handler missing).
- [ ] **Step 3: Implement** `handler.js`, `index.js`, `wrangler.toml` and the README to the Interfaces.
- [ ] **Step 4: Run** `node 12t_projects/donate-worker/test.mjs` (expected: `donate-worker test: all checks passed (10)`) and `npx wrangler deploy --dry-run` in the folder (expected: it bundles with no error, and `scripts/donors.js` is included).
- [ ] **Step 5: Update CLAUDE.md and AGENTS.md**, then commit the folder and both docs: `feat(donate-worker): Cloudflare Worker that forwards ☕ slips to the user's Discord`.

### Task 6: the user's setup and deploy (with the user, live)

**Files:** none tracked. The Worker URL is noted for Task 7.

- [ ] **Step 1:** The user makes the private Discord channel and its webhook (README step 1). Claude only guides.
- [ ] **Step 2:** The user makes the Cloudflare account and runs `npx wrangler login`. Claude runs `npx wrangler deploy` in `12t_projects/donate-worker/`. Expected: a `https://12tails-donate.<sub>.workers.dev` URL. If the deploy refuses the `[[ratelimits]]` binding on the free plan, stop and ask the user. The fallback is an in-memory per-isolate limit; the spec requires the rate limit to be verified on the free plan.
- [ ] **Step 3:** The user runs `npx wrangler secret put DISCORD_WEBHOOK_URL` and pastes the webhook.
- [ ] **Step 4: Live check:** `curl -s -X POST -H "Origin: https://jumpptty.github.io" -F name=ทดสอบ -F msg=test -F amount=1 -F date=<now> -F slip=@<small test.png> <url>/slip`. Expected: `{"ok":true}`, and a message in the user's channel with the image and the อนุมัติ link. Tapping the link on the user's Android in Discord opens the guide manager's ♥ tab with the card filled in and the key present. If it shows the key screen, follow the README's Discord setting, then retry.

### Task 7: the ☕ pop-up

**Files:**
- Modify: `12t_projects/bible/index.html` (`#donateModal` markup, the donate CSS at about lines 1486–1525, the donate wiring at about line 32382, new constants near `DONORS`, a changelog entry)
- Modify: `12t_projects/bible/assets.js` and `scripts/bible_assets.js` (`MANIFEST` gains `{ name: "DONATE_QR", empty: "" }`, holding the user's QR file as a data URI), then run `node scripts/bible_assets.js stamp`
- Modify: `scripts/validate_skills.js` (pop-up agreement checks)
- Modify: `.claude/skills/bible-hub-tools/SKILL.md` (a ☕ pop-up section: data in DONORS, edited only by the guide manager, no changelog for donations, the wording rule)

**Interfaces:**
- Consumes: `DONORS` (Task 2); the Worker URL (Task 6); `LIMITS` and `groupDonors` (Task 1) for the validator checks.
- Produces, in the main script:
  - `const DONATE_WORKER_URL = "<Task 6 URL>/slip";`
  - `const DONOR_LIMITS = {…};` on one line, equal to `LIMITS`
  - `function donorRows(donations)`, equal to `groupDonors`
  - `function parseAmountInput(text) -> number | null`
  - `async function shrinkSlip(file) -> Blob` (JPEG, ≤1600 px long side, quality 0.85; throws `Error("อ่านรูปสลิปไม่ได้ ลองถ่ายหน้าจอสลิปแล้วส่งใหม่")`)
  - `function downloadQr()` (Web Share with a file where `navigator.canShare({ files })` is true on iOS, otherwise an `<a download="12tails-bible-qr.png">`)
  - `const DONATE_ERRORS`, mapping the Worker's error codes to Thai:
    - `missing`: `กรอกให้ครบทุกช่องและแนบสลิป`
    - `invalid`: the Worker's `message`
    - `file-type`: `สลิปต้องเป็นรูป JPG, PNG หรือ WebP`
    - `file-size`: `รูปสลิปใหญ่เกิน 5 MB`
    - `rate`: `ส่งถี่เกินไป รอสักครู่แล้วลองใหม่`
    - `origin` / `method` / `discord` / a network failure: `ส่งไม่สำเร็จ ลองใหม่อีกครั้ง`

    The form keeps what was typed on any error.
- Pop-up content, top to bottom:
  1. Text: `ร่วมสนับสนุนค่าพัฒนา 12 Tails Bible และค่าเซิร์ฟเวอร์ในอนาคต ขอบคุณทุกการสนับสนุนครับ 🙏`, plus the existing Discord error-report line.
  2. The QR image and **ดาวน์โหลด QR**.
  3. A collapsed `<details>` **อยากให้ชื่อขึ้นในรายชื่อผู้สนับสนุน?** holding the form (Review Focus 3 and 4 behaviours). Under it: `สลิปจะส่งถึงผู้ดูแลเท่านั้น ไม่เผยแพร่ ชื่อที่แสดง ข้อความ ยอด และวันที่จะขึ้นในรายชื่อหลังตรวจสลิป ชื่อที่แสดงเป็นข้อมูลสาธารณะ`. On success it shows `ได้รับแล้ว ขอบคุณครับ ชื่อจะขึ้นหลังตรวจสลิป`.
  4. **รายชื่อผู้สนับสนุน**: `donorRows(DONORS)` rendered with `textContent` only (name, amount in JetBrains Mono, ×N when N > 1, message, Thai date). The empty state is `ยังไม่มีรายชื่อ มาเป็นคนแรกกันครับ`.
- The `.donate-msg{white-space:nowrap}` rule goes. On a phone the QR stays on the first screen. The new panels join `THEME_SURFACES`.

- [ ] **Step 1: Add the failing validator checks:** `DONOR_LIMITS` deep-equals `LIMITS`; `donorRows` equals `groupDonors` on Task 1's data and on `DONORS`; `parseAmountInput` maps `"1,000"`→1000, `"฿50"`→50, `" 20 "`→20, `"50.5"`→50.5 and `"abc"`, `"0"`, `"-5"`→null; `shrinkSlip turns a big image into a small JPEG` with a canvas and `createImageBitmap` stub (a 4000×3000 input gives a 1600×1200 draw and `toBlob` type `image/jpeg`, quality 0.85); the pop-up text contains ค่าพัฒนา and not `AI`; `DONATE_QR` is a non-empty `data:image/` string.
- [ ] **Step 2: Run** `node scripts/validate_skills.js`. Expected: the new checks fail.
- [ ] **Step 3: The QR asset is the Bible-styled card** the user approved on 2026-10-23: 1080×1519 PNG, the bank's QR rebuilt module by module, checked to decode to the same payload as the bank original. It was made in the planning session's scratch dir (`12tails-bible-qr-styled.png`, built by `qr_card_build.py`). If that file is gone, ask the user for the bank QR image again and rebuild it the same way: 33×33 modules sampled from the original, the Thai QR centre logo and PromptPay badge kept, the account-holder name line, exactly as the bank card shows it, and the payload checked against the original with OpenCV without printing it. Add it to `assets.js` as `DONATE_QR` with a scratch script, then run `node scripts/bible_assets.js stamp`. The download button saves this card.
- [ ] **Step 4: Implement** the markup, CSS and script (scratch-script patches, backup first), then add the changelog entry.
- [ ] **Step 5: Run** `node scripts/validate_skills.js --full` and `node scripts/bible_assets.js --selftest`. Expected: both pass.
- [ ] **Step 6: Browser check** at 390×844 and 1440×900 (this is a new layout, so it's allowed): the pop-up opens from ☕; the QR is on the first screen on the phone; the download saves a PNG; the form shows the Review Focus messages; the list renders the test donations.
- [ ] **Step 7: Update the skill doc**, then commit `index.html`, `assets.js`, `bible_assets.js`, the validator and the skill: `feat(bible): ☕ pop-up takes donations again: QR download, optional slip for the thank-you list, donor list`.

### Task 8: end to end, past donors, push

- [ ] **Step 1:** Push (after `node scripts/validate_skills.js --full`) and wait for Pages.
- [ ] **Step 2: Live run:**
  1. From the live Bible on a phone, send a ฿1 test slip.
  2. The user gets the Discord ping and taps อนุมัติ.
  3. ตรวจอย่างเดียว passes, then a real publish.
  4. After Pages updates, the ☕ list shows the test donor.
  5. Remove the test donation from the ♥ tab; the list is empty again.

  Expected: the commits are `feat(bible): ขอบคุณผู้สนับสนุน ทดสอบ` and `fix(bible): remove a donation`, with no changelog entries.
- [ ] **Step 3: Past donors:** the user gives each one's display name, amount and date. Add them through the ♥ tab's new-donor card in one batch, or with a `donor-add` request through `node scripts/add_guide.js batch <request.json>` on the PC. Expected: one commit, rows sorted by total.
- [ ] **Step 4:** Update the memory file `project_donate-slip-inbox.md`: built, and where the Worker lives.
