# Discord ✅ approval for class guides and ☕ donations (design, 2026-11-13)

## Intent

Today a donation or a class guide reaches the Bible through the guide manager: the owner opens the อนุมัติ link (donation) or
pastes a code that came by Discord DM (guide), queues it, presses อัปขึ้น GitHub, and a GitHub Actions run commits it into
`index.html`. The owner wants the wardrobe's flow instead (user 2026-11-13): **a ✅ reaction on the bot's Discord post is
the whole approval**, and **taking the ✅ away removes it from the site** within about a minute. No commit, no queue, no
deploy per item; it must work from the phone.

The wardrobe does this in `C:/work/12tails-wardrobe/pipeline/site_worker.mjs` (home PC: `D:/12tails-wardrobe/...`):
`/api/submit` posts a submission to a private channel through a webhook with its data as JSON in the embed footer
(`meta {...}`), and `GET /api/community` reads the channel with a bot token, keeps the Worker's own messages that carry a
✅, and caches the list 60 s per data centre. Read it before building; this design copies its shape.

## Goals

1. **Donations:** the ☕ slip form asks for the amount too. The owner checks the slip against the bank app and ✅s the
   post; the donor shows in the ☕ donor list (totals, order, "ขอบคุณ" text) within ~60 s. Un-✅ = gone within ~60 s.
2. **Guides:** the guide editor (step 6, บันทึกและส่ง) gets a **ส่งไกด์** button that posts the guide to a private channel.
   The post has a **ดูตัวอย่าง** link that opens the guide in the Bible exactly as readers will see it. ✅ = the guide is
   in ไกด์จากผู้เล่น with its number; un-✅ = gone.
3. **Stable guide numbers:** a guide gets the next number (107 onward) the first time it is seen with a ✅, and keeps it
   when the ✅ comes off and back. An update names the guide it replaces (embedded or live) and, once ✅'d, takes over
   that number; the older version is hidden while the newer one is ✅'d, and comes back if that ✅ is removed.
4. **Typo fix for an amount:** a reply from the owner to a slip post whose text is only a number replaces that donation's
   amount (the latest such reply wins).
5. The embedded `CLASS_GUIDES` and `DONORS` in `index.html` keep working unchanged and are the fallback when the live
   list cannot be read.

## Non-goals

- Writing live items into `index.html` (an "archive into the repo" button in the guide manager may come later).
- Changelog entries for live guides (the ใหม่ badge, 24 h from `published`, stands in).
- Auto-reading amounts from slips (OCR).
- Removing the guide manager: it keeps replacing and removing **embedded** guides and donors, and its อนุมัติ card keeps
  working for old links.

## Anti-goals (a failure even if it works)

- The slip image, or any unapproved post's data, reachable from the public site.
- A post shown without the owner's ✅, or one still shown a few minutes after the ✅ is gone.
- Two different guides showing under one number, or an embedded number handed out again.
- A broken live list breaking the page: no live data must look exactly like today.

## Constraints

- The Bible is static on GitHub Pages (`12t_projects/bible/index.html`, multi-MB): patch it out-of-process per
  `12t_projects/bible/CLAUDE.md` §1, validator after (`node scripts/validate_skills.js`), changelog entry by habit.
- The Worker is the existing `12tails-donate` (`12t_projects/donate-worker/`, Cloudflare free plan: **50 outgoing calls
  per request**, so 1 call per 100 channel messages plus rare edits; no KV). It imports `scripts/donors.js`; the page
  keeps word-for-word copies of its rules (`DONOR_LIMITS`, `donorSlipCheck`, `donorRows`, and the guide manager's `gm*`
  copies) that the validator compares, so any rule change goes to `donors.js` and every copy together.
- Accepted origins today: `https://jumpptty.github.io` and `null`. Rate limit `SLIP_LIMIT` 2 / min / IP.
- Donor and guide text is typed by strangers: Discord markdown escaped (`escapeMd`), never through `innerHTML` on the
  page, `allowed_mentions: { parse: [] }`.
- The owner deploys (`npx wrangler deploy`) and sets secrets; Claude's safety check refuses secret writes.
- Discord's Android in-app browser drops `#...` fragments (donate README "Android note"); the ดูตัวอย่าง link has the same
  limit.

## Approaches considered (where the guide number lives)

- **A. In the Discord post itself (picked, user 2026-11-13: "go with your pick").** When the list build meets a ✅'d guide
  post with no number, it takes the next number and writes it into that post's footer meta by editing the message through
  the webhook (`PATCH /webhooks/{id}/{token}/messages/{message_id}`; a bot cannot edit a webhook's message). Nothing new to
  set up; Discord stays the only store. Ceiling: two data centres rebuilding the list in the same second could hand out
  two numbers for two new guides at once, or one guide twice; rare with one approver. Mark it with a `ponytail:` comment
  (upgrade path: a Durable Object counter).
- **B. Cloudflare KV** (message id → number, plus a counter): one more resource to bind, eventually consistent, so the
  same race. Rejected: setup for nothing gained.
- **C. Durable Object:** no race, most code and setup. Rejected for a one-approver channel.

## Design

### Discord (owner setup, once)

- Slip channel: the existing private channel and webhook (`DISCORD_WEBHOOK_URL`).
- New private channel for guides with its own webhook (secret `DISCORD_GUIDE_WEBHOOK_URL`).
- A bot that can read both channels with Message Content Intent on (secret `DISCORD_BOT_TOKEN`). Builder's call
  (proposed): reuse the wardrobe's "12 Tails Skins" bot by allowing it into the two channels, so no new token to carry.
- Channel ids and the owner's Discord user id as plain `[vars]` in `wrangler.toml` (`SLIP_CHANNEL`, `GUIDE_CHANNEL`,
  `OWNER_ID`); they are not secrets.
- Only the Worker's own webhook posts count (`webhook_id` set and equal to that channel's webhook). Any ✅ counts, as in
  the wardrobe: the channels are private to the owner.

### Worker routes (`12tails-donate`)

- `POST /slip` (changed): also takes `amount` (checked by `donors.js` like `checkDonation`'s amount rule). The post shows
  name, message, amount and the send time, the slip as before, and a footer `meta {"v":1,"name","msg","amount","date"}`
  (`date` = send time in Thailand time, `YYYY-MM-DDTHH:MM`, the `DONORS` format). The อนุมัติ link to the guide manager is
  dropped from new posts (✅ replaces it); the content line says to check the slip against the bank app, then ✅.
- `POST /guide` (new): the TG3 code, plus optional `replaces` (a guide number). Same origin rules and rate limit. Decodes
  the code with `scripts/guide_code.js` and refuses one that does not decode or names an unknown class / server (as
  `decodeCode` does). The post shows title, author, server, class, level, modes, "แทนที่ #N" when given (with a link to
  the current `#class-guide/N` on the site, so the owner can compare it with the new version and its author before ✅),
  and the **ดูตัวอย่าง** link. `replaces` must be a positive integer; it is not checked against existing numbers (the
  owner's ✅ is the check). Footer `meta {"v":1,"code","replaces","num":null}`; if the code makes the footer pass Discord's
  2048-character limit, the code goes as an attached `guide.txt` instead (builder's call on the exact cut-off).
- `GET /api/donors` (new): the slip channel's ✅'d Worker posts → `[{ k, name, msg, amount, date }]`, `k` = message id,
  the amount taken from the owner's latest number-only reply (message from `OWNER_ID` whose `message_reference` is that
  post) when there is one. Never the slip URL.
- `GET /api/guides` (new): the guide channel's ✅'d Worker posts → `[{ num, replaces, code, published, msg }]`.
  `published` = the post's time (UTC ISO), so the ใหม่ badge works; `msg` = message id. Number rule: `replaces` set →
  `num = replaces`; else the footer's `num`; else assign `max(GUIDE_NUM_FLOOR, every num in the channel's footers, ✅'d or
  not) + 1` and write it back. `GUIDE_NUM_FLOOR` is a `[vars]` value = the highest number ever given to an embedded guide,
  tombstones included (106 on 2026-11-13). When two ✅'d posts share a `num`, the newest wins.
- Both lists: one pass of `GET /channels/{id}/messages?limit=100&before=…`, cached 60 s per data centre
  (`caches.default`), `Access-Control-Allow-Origin` for the Bible's origins, `cache-control: public, max-age=60`. Discord
  down or secrets missing → an error answer; the page then shows only the embedded lists.

### Bible page (`12t_projects/bible/index.html`)

- ☕ ส่งสลิป form: an amount field (บาท) with the `donors.js` rule and its Thai message; the copies the validator compares
  updated together.
- Donor list: `DONORS` plus the live list. A live row's donor `id` (which groups a returning donor) = the `id` of the
  donor whose latest name matches (trimmed, case-insensitive, as the guide manager's `gmDonorMatches`), else `"m" + k`.
  A live `k` already in `DONORS` is skipped (so a later archive never shows twice).
- Guides: `CLASS_GUIDES` plus the live list. A live guide with `num` N hides embedded guide N (a replace); otherwise
  numbers never collide because live numbers start above the floor. Live guides go through the same normalize / check as
  embedded ones, and one that fails is skipped like an invalid embedded entry. `#class-guide/<N>` for a live number waits
  for the live list before it says the guide is missing. Views (`CLASS_GUIDE_VIEWS`, GoatCounter) work by number as now.
- Editor step 6: **ส่งไกด์** (sends the current code, after the same "ready" checks as คัดลอกโค้ดไกด์), with an optional
  "อัปเดตไกด์เดิม #N" field; the existing copy-code path stays. Result messages in Thai.
- **Updates (user 2026-11-13: "there's also update / replace existing guide cases"):** when the guide's title and author
  match a guide on the site (embedded or live; trimmed, case-insensitive), the editor fills #N and says so (the author can
  clear it to send as new); when the guide is identical to #N (the guide manager's `sameGuide` rule: key order, id and the
  date stamps ignored) it warns before sending. The author can also type #N by hand. Removing a guide for good stays
  manual: un-✅ every post of a live guide; ลบ in the guide manager for an embedded one.
- **ดูตัวอย่าง** deep link: opens a code read-only in the reader view (builder's call on the exact fragment form; it must
  not save anything into the author's draft).
- Fetching: one request per list after the page has drawn, never blocking the first paint; the page re-renders the guide
  list / donor list when it arrives.

### Guide manager (`12t_projects/guide-manager/`, `scripts/add_guide.js`)

- A pasted code for a **new** guide gets **ส่งเข้า Discord** (posts it through `POST /guide`, so the owner ✅s it like any
  other) in place of queueing an embedded add; this keeps one authority over new numbers. Replace / remove of embedded
  guides and donors stay as they are. The page's CSP gains the Worker's host; the Worker accepts the local manager's
  origin (`http://127.0.0.1:4782`) too.
- `add_guide.js add` (embedded add) must never hand out a number above `GUIDE_NUM_FLOOR`; builder's call whether it is
  retired or kept only for an explicit archive.

### Tests and checks

- `12t_projects/donate-worker/test.mjs` (fake Discord fetch): `/slip` with amount, `/guide` accept / refuse, both lists
  (✅ filter, webhook filter, paging, owner amount reply, number assign + write-back, replaces, newest wins, slip URL never
  returned), errors fall back cleanly.
- `node scripts/donors.js --selftest` for the amount rule; the validator's donor-copy and gm-core checks updated.
- `node scripts/validate_skills.js` on the page.
- No browser check (repo rule) except one live check by the owner after deploy: send a test slip and a test guide, ✅,
  see them on the site, un-✅, see them go.

### Docs

`12t_projects/donate-worker/README.md` (routes, secrets, vars, setup steps for the owner), `12t_projects/bible/CLASS-GUIDES.md`
(the ✅ flow, numbering, ส่งไกด์), the `bible-hub-tools` skill (☕ pop-up section), and `scripts/donors.js` comments where
the 2026-10-23 "name + message + slip only" rule is reversed.

## Calls made after the builder check (2026-11-13, Claude's, for the owner to check)

1. **Deleting posts:** a post that has a number is never deleted (un-✅ it instead); a post never ✅'d has no number and
   may be deleted freely (spam, mistakes). Once a number is assigned, the Worker also writes it into the post's visible
   text ("#108 · อย่าลบโพสต์นี้ ถ้าจะเอาออกให้เอา ✅ ออก") so the owner can see which posts carry numbers. The max also counts
   every `replaces` value in the channel.
2. **Spam:** no Turnstile for now (the ☕ form has run since 2026-10-23 with only the origin check and 2 / min / IP);
   rejected posts get deleted (no number, so safe). Add Turnstile (the wardrobe's pattern) when spam shows up. The
   50-call ceiling is ~4,900 messages per channel, far away; the README says to keep the channels tidy.
3. **Cache on `*.workers.dev`:** Cloudflare's docs do not say the Cache API is off there (they only name custom domains
   and Pages as working, and describe workers.dev cache keys), so it is expected to work per data centre but is
   unproven. The list routes answer an `x-list-cache: hit|miss` header; checking it after the first deploy is part of
   the owner's live check. If it never hits, the upgrade is a SQLite-backed Durable Object (works on the Free plan) that
   holds the list and hands out numbers, which also removes the race in Approach A. On a Discord error or 429 the route
   answers an error and the page shows the embedded lists only (as planned).
4. **Live donors group together:** a live row's donor `id` = the id of the donor (embedded **or an earlier live row**)
   whose latest name matches, else `"m" + k`; the same matching the guide manager uses.
5. **`replaces`:** the page skips a live guide whose `replaces` is at or below `GUIDE_NUM_FLOOR` (sent by
   `/api/guides` as `floor`) while no embedded guide has that number, which is a removed number (the `// #N removed`
   comments cannot be read at runtime), so a removed number never comes back. A `replaces` above every assigned number is allowed and counted in the max.
6. **Amount:** required on the new ☕ form. A post without an amount (a page cached from before) is still forwarded, its
   text says "ไม่มียอด ตอบกลับโพสต์นี้ด้วยยอดเงิน", and `/api/donors` skips it until the owner's number reply exists.

7. **ดูตัวอย่าง link (decided while planning):** a signed Worker link `/g/<message id>.<sig>` (HMAC keyed by the guide
   webhook URL, no new secret) that redirects to the Bible's `#class-guide/code/<code>`. Unapproved guides stay
   private, the link fits Discord's 2,000-character content limit, and the opened link carries no `#` for Android's
   in-app browser to drop.

## Left to the builder

The exact Thai wording; the footer cut-off for long codes; the ดูตัวอย่าง fragment form; whether `add_guide.js add` is
retired; reuse of the wardrobe bot vs a new one (ask the owner at setup time).
