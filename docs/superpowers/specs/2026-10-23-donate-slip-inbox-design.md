# Donations with a donor thank-you list: design (2026-10-23, approved by the user)

## Intent

The ☕ button at the top right of the Bible opens a pop-up that today says the AI costs are covered and nobody needs to transfer anything more (commit 8b950f0 replaced the old QR code with that note). Development costs are back, and hosting may cost money later as the user base grows, so the pop-up should take donations again. It stays as low-key as the ☕ button itself: a donor taps ☕, downloads the user's QR code, and pays in their own bank app, never leaving the Bible.

Donors who want to be thanked by name can also send their slip from the pop-up. The slip reaches the user privately on Discord, which they use all day. The user checks it against their bank app and approves it from their phone, and the donor's chosen name, message, amount and date appear in a thank-you list in the pop-up: one row per donor, repeat donations added up, biggest total first.

## Goals

- The ☕ pop-up: a thank-you text asking for support toward **development cost and future server cost**, the user's QR code, one **download** button for it, the optional slip form, and the donor list.
- Giving money takes three steps and stays inside the Bible: tap ☕, download the QR, pay in the bank app.
- Being listed is optional. The donor fills in a display name, a message, the amount and the date and time of the transfer, attaches the slip, and sends.
- Each slip pings the user in a private Discord channel with everything needed to check it, plus an **อนุมัติ** link.
- Approving takes one link and one tap: the link opens the guide manager (`12t_projects/guide-manager/`, which already works on the phone) with the donor filled in, and publishing goes through the same GitHub pipeline as a guide.
- The list in the pop-up shows name, amount, message and date, one row per donor (repeat donations merged into a total), biggest total first.
- Everything costs nothing: a Cloudflare Workers free plan, a Discord webhook, and the GitHub Actions the repo already uses.

## Non-goals

- Checking slips automatically (no bank API exists for a personal account; paid slip-check services are out). The user checks every slip by hand against their bank app.
- Easy Donate or any other payment platform. The user set up `ezdn.app/12tailsbible` during this conversation and decided against it: it sends donors away from the Bible. Nothing in this design uses it.
- A Discord bot with Approve / Reject buttons (it would need a Discord application and bot token; the link is enough).
- A reject action. To reject, the user ignores or deletes the Discord message (my call).
- Donor accounts, editing by donors, or a way for donors to see whether they were approved other than the list itself.
- Changing the credits pop-up (ผู้ช่วยเรียบเรียงคัมภีร์ไบเบิ้ล, `CONTRIBUTORS`).
- A spam CAPTCHA (Cloudflare Turnstile) in the first version. Add it later if spam shows up.

## Anti-goals

- **A slip, or a donor's real name from a slip, anywhere public:** not in the repo (it is public: `jumpptty/12tails`), not in the Bible, not in a commit or the changelog. Slips go only to the private Discord channel. Only what the donor typed as the display name reaches the Bible.
- **The Discord webhook address anywhere public.** It lives only as a secret in the Worker.
- **The word "AI" as the reason for donating** (user, 2026-10-23: "instead of explicitly AI, let's just say developing cost from now on"). The wording is ค่าพัฒนา, plus ค่าเซิร์ฟเวอร์ในอนาคต.
- **Anyone but the user publishing a name.** The อนุมัติ link only fills in the guide manager's form; publishing needs the GitHub key stored on the user's phone.
- **Donor text running as code:** name and message are untrusted wherever they show (pop-up, guide manager, Discord, commit subject, changelog).
- **The pop-up becoming loud:** the ☕ button stays exactly as it is.
- Project rules broken: a third font (Prompt for text, `'JetBrains Mono','Prompt',monospace` for numbers only), a soft gold glow on hover, a field silently lost from `index.html`.
- The bank account or PromptPay number typed anywhere by Claude. The QR image comes from the user as a file.

## Decided with the user

- **Money flow:** donors download the user's QR and transfer directly. No third party between donor and the user's account. The user supplies the QR image (exported from their bank app).
- **One download button** on phone and PC (not copy to clipboard).
- **Slip inbox:** the donor sends the slip from the pop-up to a **Cloudflare Worker** (free plan, checked: no charge, always on, 100,000 requests a day), which forwards it to a **private Discord channel** through a webhook. The user picked the Worker over posting to Discord straight from the page (that would put the webhook address in the page source), and Discord over a private GitHub inbox repo ("I use discord often, that sounds smoother").
- **Approve:** an อนุมัติ link in the Discord message opens the guide manager pre-filled; the user checks the bank app, then publishes.
- **List shows all four:** display name, message, amount and date.
- **Repeat donors are merged:** one row per donor with their total, a "×N" count, the latest message and the latest date. When a new slip's name matches an existing donor, the user chooses at approval: add to that donor, or list separately.
- **Order:** biggest total first. Equal totals: whoever first gave earlier comes first (my call).
- **Wording:** development cost and future server cost, never AI.
- **The user approves on Android** with the guide manager saved as a home-screen shortcut (Chrome). Discord on Android opens links in Chrome's custom tab, which shares Chrome's storage, so the อนุมัติ link should open the guide manager with the key already there. Verify this on the user's phone first; if it lands on the key screen, the README's fix is Discord's setting to open links in the external browser (my call: no paste-a-code fallback unless that fails).
- **Past donors are listed at launch:** donors from the earlier AI-cost round go on the list from day one. The user supplies each name as it should be shown, the amount and the date (no message needed), and they are added with the new-donor card (or Claude adds them from the user's list in the first data commit).

## How it works

### The ☕ pop-up (`12t_projects/bible/index.html`, `#donateModal`)

- The header stays ☕ สนับสนุนค่ากาแฟ. The body, top to bottom:
  1. **Thank-you text** replacing today's "no need to transfer more" note: why support helps (development cost, future server cost), and thanks. Keep the existing line with the Discord contact for reporting wrong data.
  2. **The QR image** and one **ดาวน์โหลด QR** button.
  3. **"อยากให้ชื่อขึ้นในรายชื่อผู้สนับสนุน?"** The optional slip form (below).
  4. **รายชื่อผู้สนับสนุน:** the donor list (below).
- **Download:** a plain download of the QR file (for example `12tails-bible-qr.png`). On iPhone, where downloads land in Files and bank apps pick images from Photos, the button opens the share sheet with the image instead (Web Share API with a file), so "Save Image" puts it in Photos (my call). Any other browser without file sharing falls back to the plain download.
- **The QR image** is the user's bank QR file, stored the way the Bible stores its other images (an `assets.js` container through `scripts/bible_assets.js`, or inline if it is small enough for the `ASSET_BUDGET`; builder's call).
- The pop-up stays one scrolling panel on a phone; the form and list must not push the QR off the first screen.

### The slip form

- Fields: **ชื่อที่จะแสดง** (required), **ข้อความ** (optional), **ยอดเงิน (บาท)** (required, a positive number), **วันและเวลาที่โอน** (required, defaults to now), **สลิป** (required, an image). Limits on lengths and file size are the builder's call; the same limits apply in the page and in the Worker.
- One line under the form says that the slip goes only to the Bible's maintainer, is never published, and that the name, message, amount and date appear after a check.
- **Send:** the page posts the form to the Worker. Success replaces the form with a thank-you and "ชื่อจะขึ้นหลังตรวจสลิป". A failure says what went wrong in Thai (too large, wrong file type, too many sends, network) and keeps what was typed.
- The page may shrink the slip image before sending (builder's call), as long as the slip stays readable.

### The Worker (new folder, for example `12t_projects/donate-worker/`)

- One endpoint that accepts the form, checks it, and forwards it to Discord. Nothing is stored.
- **Checks:** all required fields present; name and message within the limits; amount a positive number within a sane maximum; date valid; the file really an image of an allowed type and size. A per-visitor rate limit (for example a few sends an hour; the mechanism is the builder's call, verified on the free plan).
- **Allowed origins:** the Bible's GitHub Pages origin (`https://jumpptty.github.io`). Whether to also accept the `null` origin of a double-clicked local copy is the builder's call.
- **The Discord message:** one webhook post with the slip as an attached image and an embed with the display name, message, amount and date. Mentions are disabled (`allowed_mentions` empty) so donor text cannot ping anyone, and the donor text cannot break the embed. It also includes the **อนุมัติ** link (below).
- **Secrets:** the webhook URL is a Worker secret, set by the user. The Worker's code, `wrangler.toml` and README are in the public repo with no secrets in them.
- **Deploy:** with Wrangler from the repo or by pasting into the Cloudflare dashboard (builder's call). The README gives the user's setup steps in order.

### Approving: the guide manager (`12t_projects/guide-manager/index.html`, `scripts/add_guide.js`, `.github/workflows/guide-manager.yml`)

- **The อนุมัติ link** opens the guide manager on GitHub Pages with the donor's name, message, amount and date in the URL fragment (after `#`, so they are not sent to any server). The page shows a donor card filled in from it: every field editable, with **ใส่ในรายการ** like a guide.
- **Untrusted input:** the fragment is attacker-controllable (anyone can make such a link), so the page escapes every value, applies the same limits as the Worker, and publishes nothing by itself. The guide manager review of 2026-10-20 already treats pasted codes this way.
- **Repeat donor:** when the name matches an existing donor (trimmed, case-insensitive), the card says so with that donor's total and count, and asks **เพิ่มให้ "<name>" (รวม ฿Y)** or **แยกเป็นคนใหม่**. Adding reuses that donor's `id`; separate gets a new one. With no match, a new `id` is made. The user can also pick an existing donor by hand when a returning donor typed a different name (my call).
- **Publishing:** the queue gains a donor item type, for example `{ action: "donor-add", donor: { id, name, msg, amount, date } }`, sent through the existing workflow. `add_guide.js batch` gains the matching edit: add one entry to a new `DONORS` array in `index.html`, through the same stages (git, edit, check, commit, push), all or nothing, with undo as for guides.
- **Commit, no changelog:** a donor publish (add or remove) adds **no changelog entry** (user, 2026-10-23: "no need for changelog for donations"), unlike guides. A batch that mixes guides and donors still gets the guides' changelog entry, which must not mention the donors. The commit subject names the donor but **not the amount** (my call), for example `feat(bible): ขอบคุณผู้สนับสนุน <name>`. The name in a subject is sanitised (no line breaks, no workflow-command text).
- **Fixing a mistake (my call):** the guide manager lists every donor with each of their donations, and any **single donation** can be removed (a donor disappears when their last donation goes). Changing an amount or name is remove plus add again. Undo of the last publish works as for guides.
- **No tombstones (my call):** unlike guides, donor ids never appear in a public link, so nothing has to stop an id being reused. A removed donation leaves no line in `index.html`, so a name removed for privacy is gone from the shipped page. It stays in git history, which cannot be undone; the form's note tells donors their display name is public.
- **Adding by hand (my call):** a **new donor** card in the guide manager with the same fields and the same repeat-donor choice, with no อนุมัติ link needed. It covers slips that arrive by DM or LINE, and past donors.
- **Ids:** a new donor gets a short random id (builder's call how), so a removed donor's id can never be inherited by accident.

### The list (`DONORS` in `index.html`)

- `const DONORS = [ { id, name, msg, amount, date }, … ];` in `index.html`, **one entry per approved donation**; entries sharing an `id` are one donor. Keeping each donation (instead of a running total) keeps undo and removal simple and keeps the history. The project allows only `index.html` plus `assets.js` (AGENTS.md §5), and the guide manager already edits `index.html` from the phone. This replaces my earlier passing suggestion in chat of a separate file.
- **Grouped at render time**, one row per `id`: the name from the donor's latest donation (so a donor can change how they are shown), the **total** in baht (JetBrains Mono digits), "×N" when N > 1, the latest non-empty message, and the latest date in Thai. Sorted: biggest total first, then the donor whose first donation is earlier.
- Rendered with `textContent` only.
- Empty state: one short line inviting the first donor (only seen until the past donors are added).

## Constraints

- The repo and its GitHub Pages site are public; the default and Pages branch is `skill-cooldown-lookup`.
- `index.html` uses CRLF line endings and is about 4 MB. Patch it out of process per `12t_projects/bible/CLAUDE.md` §1; never `git checkout` / `restore` / `reset` / `stash` it.
- `node scripts/validate_skills.js` must pass; it gains a check of the `DONORS` shape. `--full` before a push.
- Phone publishes reach GitHub first; the user runs `git pull` before working on the PC (already their habit).
- Cloudflare Workers free plan: 10 ms CPU per request (waiting on Discord does not count).
- Claude does not enter tokens, webhook URLs or account numbers into any field. The user creates the Discord webhook, the Cloudflare account, the Worker secret and the QR file, following the README.

## What the user sets up

1. A private Discord server or channel, and a webhook for it (Server Settings → Integrations → Webhooks).
2. A free Cloudflare account; deploy the Worker; paste the webhook URL into the Worker's secret.
3. The QR image file from their bank app.
4. Nothing new for publishing: the guide manager key already has the permission the workflow needs.

## Docs to update

- `12t_projects/bible/CLASS-GUIDES.md` (the guide manager section: the donor item, the อนุมัติ link) or a short donation section in the topic skill that owns the hub tools (`bible-hub-tools`), builder's call.
- `CLAUDE.md` commands (the Worker folder and its deploy) and the `AGENTS.md` directory list.

## Left to the builder

Field and file-size limits; the rate-limit mechanism and numbers; whether to shrink the slip in the page; the Worker folder name and deploy method; the `null` origin; the QR file's storage; the pop-up's exact layout and the list's look; how the guide manager shows the donor card and the donor list; the Thai wording beyond what is fixed above; tests for the new batch action and the Worker.

## Verification

- `node scripts/validate_skills.js` passes, including the `DONORS` check; `--full` before the push.
- The Worker refuses a missing field, an over-size or non-image file, and repeat sends over the limit; a good send lands in the Discord channel with the slip, the details, no mentions, and a working อนุมัติ link.
- On the user's Android phone: the อนุมัติ link tapped in Discord opens the guide manager with the key and the donor filled in.
- In the guide manager: a crafted link with script in the name shows it as text; a dry run of a donor item passes; a real approve adds the donor, the list in the pop-up re-sorts, undo removes it; a second approve for the same name offers "add to" and the row shows the new total and ×2.
- This is a new pop-up layout, so one browser check at phone and desktop width is in order (the project's no-browser rule is for small changes).
