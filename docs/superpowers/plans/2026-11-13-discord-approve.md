# Discord ✅ approval for class guides and ☕ donations: implementation plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** A ✅ on the Worker's Discord post puts a donation or a class guide on the Bible within ~60 s, and removing the ✅ takes it off, with no commit or deploy per item.

**Architecture:** The existing `12tails-donate` Cloudflare Worker gains `POST /guide`, `GET /api/donors`, `GET /api/guides` and a preview redirect. It reads two private Discord channels with a bot token and keeps guide numbers in its own posts' footers, edited through the webhook. The static Bible page fetches both lists after first paint and merges them into `DONORS` / `CLASS_GUIDES` in place. The embedded data stays as the fallback.

**Tech Stack:** Cloudflare Workers (free plan, `nodejs_compat`), Discord REST API v10, plain JS in the single-file page, Node `assert` tests (`test.mjs`), `scripts/validate_skills.js`.

**Spec:** [docs/superpowers/specs/2026-11-13-discord-approve-design.md](../specs/2026-11-13-discord-approve-design.md). Read it first; its section "Calls made after the builder check" overrides earlier lines.

## Global Constraints

- `12t_projects/bible/index.html` is multi-MB. Patch it out-of-process with a Node script in the session scratch dir, after a backup there, per [12t_projects/bible/CLAUDE.md](../../../12t_projects/bible/CLAUDE.md) §1. Never use `git checkout` / `restore` / `stash` on it. Change only the lines you mean to.
- Every commit that touches `index.html` prepends a `CHANGELOG_DATA.entries` item `["<UTC ISO now>", "<exact commit subject>"]`.
- After each `index.html` change run `node scripts/validate_skills.js`. The ☕ pop-up and guide sections of the validator are regex- and vm-based (lines ~4490-4880 and ~7080-7200). When a check pins old behaviour this plan changes, update the check in the same task. Never delete a check without replacing it.
- Every rule in `scripts/donors.js` has word-for-word copies in the page (`DONOR_LIMITS`, `donorSlipCheck`, `donorRows`) and the guide manager (`GM_DONOR_LIMITS`, `gmCheckSlipDetails`, `gmCheckDonation`, …). Change them together.
- Donor and guide text is untrusted. Escape it with `escapeMd` in Discord posts and send it with `allowed_mentions: { parse: [] }`. Write it only through `textContent` on the page, or `esc()` in the guide manager.
- Every on-screen word is Thai. Load the `bible-desc-writing` and `bible-hub-tools` skills before writing page text.
- Worker vars (`wrangler.toml [vars]`, not secrets): `SLIP_CHANNEL`, `GUIDE_CHANNEL`, `OWNER_ID`, `GUIDE_NUM_FLOOR = "106"`. Secrets: `DISCORD_WEBHOOK_URL` (exists), `DISCORD_GUIDE_WEBHOOK_URL`, `DISCORD_BOT_TOKEN`. Claude never sets secrets or deploys; the owner does.
- List cache: 60 s, `caches.default`. Response header `x-list-cache: hit|miss`.
- No browser checks (repo rule). Proof comes from the tests, the validator and the owner's live check.

## Review Focus

1. **A guide post whose footer meta cannot be parsed** (an older post, or a hand-edited one) must be skipped by `listGuides`. Its number must still count towards the max if `num` can be read. It must not throw. Test in Task 3.
2. **The live fetch failing or timing out** (Discord 429, Worker 502, offline) must leave the page exactly as today, with no console error left uncaught and no "missing guide" message for a live number. Validator case in Tasks 5 and 6 (`classGuideMergeLive` / `donorMergeLive` with `null`).
3. **The owner's amount reply holds something other than a plain number** ("150 บาท", "1,500", "0", "-5"). Accept digits with an optional `,` thousands separator and up to 2 decimals, passed through `checkAmount`. Ignore anything else, which keeps the previous amount. Test in Task 2.
4. **Two ✅'d posts with the same `num`**, as with an update. The newest by message id wins, and the older one is hidden, not listed twice. Test in Task 3.
5. **A double tap on ส่งไกด์** must send once, like `donateSubmit`'s `ui.busy`. Validator regex in Task 7.

---

### Task 1: `donors.js` amount rule

**Files:**
- Modify: `scripts/donors.js` (LIMITS stays; add `checkAmount`; `checkDonation` uses it; selftest cases)

**Interfaces:**
- Produces: `checkAmount(a: number|string) -> number`. It accepts a number, or a string matching `/^\d{1,3}(,\d{3})*(\.\d{1,2})?$|^\d+(\.\d{1,2})?$/`. It returns baht rounded to satang. Otherwise it throws the existing Thai message `"ยอดเงินต้องมากกว่า 0 และไม่เกิน 1,000,000 บาท (ทศนิยมไม่เกิน 2 ตำแหน่ง)"`. Exported in `module.exports`.

- [ ] **Step 1: Add selftest case `"checkAmount"`.** `checkAmount(50) === 50`, `checkAmount("1,500") === 1500`, `checkAmount("12.5") === 12.5`. Each of `0, -1, 1.234, "150 บาท", "1,50", "", "abc", 1000000.01, NaN` throws `/ยอดเงิน/`. The existing `"checkDonation amount"` cases still pass.
- [ ] **Step 2:** `node scripts/donors.js --selftest`. Expect a FAIL, because `checkAmount` is not defined.
- [ ] **Step 3: Implement `checkAmount`** and make `checkDonation` call it. `checkDonation` keeps today's behaviour exactly: it still refuses a string such as `"50"`, by its own `typeof a === "number"` check before calling `checkAmount`, because the validator compares the guide manager's `gmCheckDonation` copy against it.
- [ ] **Step 4:** `node scripts/donors.js --selftest` passes, and `node scripts/validate_skills.js` passes with no donor-copy errors.
- [ ] **Step 5: Commit:** `feat(donors): checkAmount, the amount rule shared by the slip form and the owner's amount reply`

### Task 2: Worker, the Discord reader and the ☕ list

**Files:**
- Create: `12t_projects/donate-worker/src/discord.js`, `12t_projects/donate-worker/src/donors_live.js`, `12t_projects/donate-worker/test_lists.mjs`
- Modify: `12t_projects/donate-worker/src/handler.js` (the `/slip` amount, footer meta, no อนุมัติ link), `src/index.js` (routing), `wrangler.toml` (`[vars]`, `compatibility_flags = ["nodejs_compat"]`), `test.mjs` (import and run `test_lists.mjs`'s cases; update the slip cases)

**Interfaces:**
- Consumes: `checkAmount`, `checkSlipDetails` from Task 1.
- Produces, in `discord.js`:
  - `readChannel(token: string, channelId: string, fetch) -> Promise<Message[]>`: pages `GET /channels/{id}/messages?limit=100&before=`. Throws `Error("discord <status>")` on a non-OK answer.
  - `cachedList(key: string, make: () => Promise<any>) -> Promise<{ value, hit: boolean }>`: uses 60 s `caches.default` when `caches` exists.
  - `footerMeta(m: Message) -> object|null`: reads `"meta " + JSON` from an embed footer, the wardrobe's `META_TAG` rule.
  - `webhookParts(url: string) -> { id, token }`.
  - `editWebhookMessage(hookUrl, msgId, body, fetch) -> Promise<boolean>`: `PATCH /webhooks/{id}/{token}/messages/{msgId}`.
  - `listAnswer(origin, value, hit) -> Response`: JSON with CORS, `cache-control: public, max-age=60` and `x-list-cache`.
- Produces, in `donors_live.js`:
  - `listDonors(messages: Message[], { webhookId, ownerId }) -> [{ k, name, msg, amount, date }]` (pure).
  - `handleDonors(request, env, deps) -> Response` (GET only, the same `ORIGINS` as `/slip`).

- [ ] **Step 1: Write the failing tests in `test_lists.mjs`.**
  - `listDonors` keeps only messages with `webhook_id === webhookId` and a `✅` reaction. It reads name, msg, amount and date from the footer meta, and never returns a URL or the slip.
  - It uses the latest reply from `ownerId` whose `message_reference.message_id` is the post and whose content passes `checkAmount` ("1,500" → 1500). Replies "150 บาท" and "0" are ignored.
  - It skips a ✅'d post whose amount is `null` and has no valid reply.
  - `readChannel` pages twice when the first page has 100 messages.
  - `/slip`: a post with `amount: "50"` puts `{ v:1, name, msg, amount:50, date:"YYYY-MM-DDTHH:MM" }` (Thailand time) in the footer. A post without an amount is still forwarded with `amount: null`, and its content has "ไม่มียอด". `amount: "abc"` → 400 `invalid` with `field: "amount"`. The content has no `อนุมัติ` link.
  - `GET /api/donors` with a fake fetch answers `{ donors: [...] }`. With the secrets missing it answers 503 `closed`; on Discord 500 it answers 502 `upstream`.
- [ ] **Step 2:** `node 12t_projects/donate-worker/test.mjs`. Expect FAILs.
- [ ] **Step 3: Implement** `discord.js`, `donors_live.js`, the `/slip` changes and the `index.js` routes: `/slip` → `handleSlip`, `/api/donors` → `handleDonors`. Task 3 adds the others. Move `ORIGINS` into `discord.js` (exported) and import it in `handler.js`, so it is defined once. Add `[vars]` and `nodejs_compat` to `wrangler.toml`. The `date` field is the send time as `Asia/Bangkok` `YYYY-MM-DDTHH:MM`.
- [ ] **Step 4:** `node 12t_projects/donate-worker/test.mjs` passes. `cd 12t_projects/donate-worker && npx wrangler deploy --dry-run` bundles without error.
- [ ] **Step 5: Commit:** `feat(donate-worker): GET /api/donors lists the ✅'d slips live from Discord; /slip takes the amount`

### Task 3: Worker, guides

**Files:**
- Create: `12t_projects/donate-worker/src/guides.js`
- Modify: `src/index.js`, `test_lists.mjs`

**Interfaces:**
- Consumes: Task 2's `discord.js`. `decode` from `scripts/guide_code.js`, imported like `donors.js`. It needs `nodejs_compat` for `zlib` / `Buffer` / `fs`. If `--dry-run` cannot bundle it, stop and report; do not rewrite the decoder.
- Produces:
  - `listGuides(messages, { webhookId, floor: number }) -> { guides: [{ num, replaces, guide, published, msg }], assign: [{ msg, num }] }` (pure). `guide` = the code decoded by `guide_code.js` `decode`, plus `id = num`, `published`, and `date` = the Thailand (UTC+7) calendar day of `published` (as `add_guide.js` `stampGuide` does). The page's own decoder is async, so the Worker decodes; the code itself is not returned. A post whose code does not decode is skipped. Numbering: `replaces` → `num = replaces`; else the footer `num`; else `next = max(floor, every footer num, every replaces) + 1`, handed out to unnumbered ✅'d posts oldest first. When nums collide, the newest message id wins. Posts whose meta cannot be read are skipped, but their `num` still counts if it can be read. `published` is the message timestamp as `YYYY-MM-DDTHH:MM:SSZ`.
  - `handleGuidePost(request, env, deps)` (`POST /guide`, form fields `code`, `replaces`).
  - `handleGuides(request, env, deps)` (`GET /api/guides` → `{ floor, guides }`; after `listGuides`, it calls `editWebhookMessage` for each `assign`, writing the footer `num` and the visible line `"#<num> · อย่าลบโพสต์นี้ ถ้าจะเอาออกให้เอา ✅ ออก"`). Mark the race with `// ponytail: two data centres can assign at once; a Durable Object counter if it ever happens`.
  - `previewLink(env, msgId) -> string` = `<worker origin>/g/<msgId>.<sig>`. `sig` is the first 16 hex characters of HMAC-SHA256(key = `DISCORD_GUIDE_WEBHOOK_URL`, `msgId`).
  - `handlePreview(request, env, deps)` (`GET /g/<msgId>.<sig>`). It checks `sig`, reads the message with the bot, and answers a tiny HTML page that runs `location.replace("https://jumpptty.github.io/12tails/12t_projects/bible/#class-guide/code/" + encodeURIComponent(code))`. A bad `sig` → 404.
  - The post (webhook, `wait=true`):
    - embed with title, author, server, class, level, modes, and "แทนที่ #N" plus a link to `#class-guide/N` when `replaces` is set;
    - footer `meta {"v":1,"code","replaces","num":null}`, or the code as an attached `guide.txt` with `"code":"@file"` when the footer would pass 2048 characters;
    - then a PATCH that adds the ดูตัวอย่าง preview link, which needs the message id.

- [ ] **Step 1: Write the failing tests.**
  - `listGuides` numbering: floor 106, two new ✅'d posts → 107 and 108, oldest first.
  - A footer `num` is kept, and a ✅ removed then re-added keeps it.
  - `replaces: 50` → num 50, and the newer of two `replaces: 50` posts wins.
  - `replaces: 150` lifts the next new number to 151.
  - Broken meta is skipped without throwing.
  - `POST /guide`: a good TG3 code → one webhook post plus one PATCH with the `/g/` link. Garbage, an unknown class, or a `replaces` that is not a positive integer → 400 `invalid`. 3 sends from one IP with limit 2 → 429.
  - `GET /api/guides` makes PATCH calls only for unnumbered ✅'d posts, and on a second call (warm cache) makes none.
  - `/g/` with a wrong sig → 404; with the right one → 200 HTML containing `#class-guide/code/`.
- [ ] **Step 2:** Tests FAIL.
- [ ] **Step 3: Implement `guides.js` and add the routes.**
- [ ] **Step 4:** `node 12t_projects/donate-worker/test.mjs` passes, and `npx wrangler deploy --dry-run` bundles.
- [ ] **Step 5: Commit:** `feat(donate-worker): POST /guide, GET /api/guides (numbers kept in the post footers) and the ดูตัวอย่าง redirect`

### Task 4: Worker docs and owner setup steps

**Files:**
- Modify: `12t_projects/donate-worker/README.md`

- [ ] **Step 1:** Document the routes, vars and secrets. Write the owner's one-time setup as numbered steps:
  1. Create the guide channel and its webhook.
  2. Let the bot into both channels, with Message Content Intent on. Reuse the wardrobe's "12 Tails Skins" bot, or make a new one.
  3. Copy the channel ids and the owner's user id into `wrangler.toml`.
  4. Run `npx wrangler secret put DISCORD_GUIDE_WEBHOOK_URL` and `npx wrangler secret put DISCORD_BOT_TOKEN`.
  5. Run `npx wrangler deploy`.
  6. Do the live check: send a slip and a guide, ✅ both, see each on the site, check `x-list-cache` turns to `hit` on a second request within 60 s, then remove the ✅ and see each leave.

  Add the rules: never delete a numbered post; delete rejected posts. If `x-list-cache` never hits, the upgrade is a Durable Object.
- [ ] **Step 2: Commit:** `docs(donate-worker): the ✅ approval routes and the owner's setup`

### Task 5: Bible page, the ☕ form amount and live donors

**Files:**
- Modify: `12t_projects/bible/index.html` (☕ section around `const DONATE_WORKER_URL`, the slip form markup, `openDonateModal`), `scripts/validate_skills.js` (☕ checks)

**Interfaces:**
- Consumes: `checkAmount` (Task 1), `GET /api/donors` (Task 2).
- Produces:
  - `donorAmountCheck(a) -> number`, a word-for-word copy of `checkAmount`. The validator compares them on Task 1's cases.
  - `donorMergeLive(donors: Donation[], live: {k,name,msg,amount,date}[]|null) -> Donation[]`. It returns `donors` unchanged for `null`. Live rows whose `k` is already present are skipped. A live row's `id` is the id of the donor, embedded or an earlier live row, whose latest name matches (trimmed, case-insensitive), else `"m" + k`.
  - `DONATE_API = DONATE_WORKER_URL.replace(/\/slip$/, "")`.
  - `donateLoadLive()`: one fetch of `DONATE_API + "/api/donors"` after first paint. On success it runs `DONORS.splice(0, DONORS.length, ...donorMergeLive(DONORS, live))` once per page load, then refreshes `renderDonorThanks` and the list if the pop-up is open. Every failure is swallowed.

- [ ] **Step 1: Add validator cases.**
  - `donorAmountCheck` agrees with `checkAmount`.
  - `donorMergeLive`:
    - `null` → same array;
    - a new name → `id "m"+k`;
    - the same name as an embedded donor (different case and spaces) → that donor's id;
    - two live rows with the same new name → one id;
    - a duplicate `k` is skipped.
  - `donateSend` appends `amount`.
  - `donateSubmit` checks the amount before sending.
  - The form has an amount input with `inputmode="decimal"`.
- [ ] **Step 2:** `node scripts/validate_skills.js` fails on the new cases.
- [ ] **Step 3: Patch the page.**
  - Add the amount field (label ยอดเงิน (บาท)) and `donorAmountCheck`.
  - Make `donateSend` send `amount`.
  - Change the sent-slip text to `"ได้รับแล้ว ขอบคุณครับ ชื่อจะขึ้นในรายชื่อผู้สนับสนุนหลังตรวจสลิป"`; it stays.
  - Add `donorMergeLive` and `donateLoadLive`, started once at page start.
  - Update the old comments that say "the amount and date are read off the slip by the user".
  - Add the changelog entry.
- [ ] **Step 4:** The validator passes.
- [ ] **Step 5: Commit:** `feat(bible): the ☕ slip form asks the amount, and ✅'d slips show in the donor list live from Discord`

### Task 6: Bible page, live guides and the code preview link

**Files:**
- Modify: `12t_projects/bible/index.html` (near `classGuideId` / `classGuideNormalize`; the hash router that opens `#class-guide/<id>`), `scripts/validate_skills.js`

**Interfaces:**
- Consumes: `GET /api/guides` → `{ floor, guides }` (Task 3), `decode` logic already in the page (the editor's import reads TG3).
- Produces:
  - `classGuideMergeLive(embedded: object[], live: {num,replaces,guide,published}[]|null, floor: number) -> object[]` (pure, sync). For `null` it returns `embedded`. Each live item's `guide` is the Worker-decoded guide object, already carrying `id = num`, `published` and `date`. It hides the embedded guide with `id === num`. It skips a live guide whose `replaces` ≤ `floor` when no embedded guide has that id (a removed number), and skips one that fails `classGuideNormalize`.
  - `classGuideLoadLive() -> Promise<void>`: fetch once; then `CLASS_GUIDES.splice(0, CLASS_GUIDES.length, ...merged)` and re-render the open guide view. `classGuideLiveReady` (a Promise) settles either way.
  - The deep link `#class-guide/<N>` for an id not embedded awaits `classGuideLiveReady` before showing missing.
  - The new deep link `#class-guide/code/<encoded TG3>` opens the decoded guide read-only in the reader view. It never touches the author's saved draft. A code that does not decode shows the usual Thai "damaged code" text.

- [ ] **Step 1: Add validator cases for `classGuideMergeLive`.**
  - `null` → same;
  - a live num 107 is added with id 107;
  - a live num 50 replaces embedded 50 (one entry, the live one);
  - a live `replaces` 40 where no embedded 40 exists and the floor is 106 is skipped;
  - a garbage code is skipped.

  Also check that the router has a `code/` branch that does not write the draft key.
- [ ] **Step 2:** The validator FAILs.
- [ ] **Step 3: Patch the page and add the changelog entry.**
- [ ] **Step 4:** The validator passes, and all 105 embedded guides still validate.
- [ ] **Step 5: Commit:** `feat(bible): ✅'d class guides show live from Discord, numbered from 107, and #class-guide/code/<code> previews a code`

### Task 7: Bible page, ส่งไกด์ in the editor

**Files:**
- Modify: `12t_projects/bible/index.html` (step 6 send panel `cg-send`, the `act === "export"` checks), `scripts/validate_skills.js`

**Interfaces:**
- Consumes: `POST /guide` (Task 3), the merged `CLASS_GUIDES` (Task 6).
- Produces:
  - `classGuideFindSame(guides: object[], draft) -> number|null`: the id of a guide whose title and author match the draft (trimmed, case-insensitive).
  - `classGuideSendCode(code: string, replaces: number|null) -> Promise<void>`: posts form fields `code` and `replaces` and resolves on `{ ok: true }`. Otherwise it throws Thai text mapped like `donateErrorText`.
  - The ส่งไกด์ button runs the same readiness checks as the export action, then:
    - fills อัปเดตไกด์เดิม #N from `classGuideFindSame` with the hint `"พบไกด์ชื่อและผู้เขียนเดียวกัน #N จะส่งเป็นการอัปเดต ลบเลขออกถ้าจะส่งเป็นไกด์ใหม่"`;
    - warns `"ไกด์นี้เหมือน #N ทุกอย่าง"` when the guide equals #N by the guide manager's `gmSameGuide` rule (copy the rule; the validator compares the two);
    - sends once (a `busy` guard);
    - on success says `"ส่งแล้ว ไกด์จะขึ้นหลังตรวจ"`.

    The old "send the code to jumpptty on Discord" text becomes the second option.

- [ ] **Step 1: Add validator cases.**
  - `classGuideFindSame` finds by title and author, ignoring case and spaces, and returns null otherwise.
  - The page's same-guide copy agrees with `gmSameGuide` on fixed pairs.
  - The ส่งไกด์ handler returns early while busy.
- [ ] **Step 2:** The validator FAILs.
- [ ] **Step 3: Patch the page and add the changelog entry.**
- [ ] **Step 4:** The validator passes.
- [ ] **Step 5: Commit:** `feat(bible): ส่งไกด์ in the guide editor sends the guide for ✅ approval, as an update when its title and author match`

### Task 8: Guide manager and docs

**Files:**
- Modify: `12t_projects/guide-manager/index.html` (CSP `connect-src` adds `https://12tails-donate.jumpthai.workers.dev`; a ส่งเข้า Discord button beside `#go`), `scripts/add_guide.js` (`add` and the batch `add` action refuse with `"ไกด์ใหม่ส่งผ่าน Discord แล้ว (ส่งเข้า Discord ในหน้าจัดการไกด์)"`; replace and remove unchanged; `--selftest` updated), `12t_projects/donate-worker/src/handler.js` (ORIGINS gains `http://127.0.0.1:4782`), `scripts/validate_skills.js`, `12t_projects/bible/CLASS-GUIDES.md`, `.claude/skills/bible-hub-tools/SKILL.md`, the `CLAUDE.md` commands list (add_guide `add` line)

**Interfaces:**
- Consumes: `POST /guide` (Task 3).

- [ ] **Step 1: Add the tests.**
  - `node scripts/add_guide.js --selftest` gets a case: `add` refuses.
  - The validator gets a check that every `CLASS_GUIDES` id ≤ `GUIDE_NUM_FLOOR` read from `12t_projects/donate-worker/wrangler.toml`, with the message "a new embedded guide number would collide with live numbers".
  - The validator gets a regex that the guide manager's CSP allows the Worker host.
- [ ] **Step 2:** Both FAIL.
- [ ] **Step 3: Implement.** ส่งเข้า Discord sends the pasted code, with `replaces = mode.id` in replace mode, and shows the result through `esc()`. ใส่ในรายการ for a new guide is hidden; replace mode keeps it. Update the docs: the ✅ flow, the numbers, never deleting a numbered post, and `add` retired.
- [ ] **Step 4:** `node scripts/add_guide.js --selftest`, `node 12t_projects/donate-worker/test.mjs` and `node scripts/validate_skills.js` all pass.
- [ ] **Step 5: Commit:** `feat(guide-manager): new guides go through ส่งเข้า Discord for ✅ approval; add_guide.js add is retired`

### Task 9: Owner's turn (not Claude)

- [ ] The owner does the README setup (Task 4), runs `npx wrangler deploy`, and does the live check. Only then `git push`: the page changes call routes that do not exist until the deploy.
