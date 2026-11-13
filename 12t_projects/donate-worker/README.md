# 12tails-donate: the ☕ slip and class guide Worker

A small Cloudflare Worker with two jobs. Both use private Discord channels as the inbox, and the owner's **✅** as the approval. Nothing is stored in the Worker.

1. **☕ slips.** A donor fills in the form in the Bible's ☕ pop-up (display name, optional message, optional amount, the slip image). The page sends it to `POST /slip`; the Worker checks it and posts it to your private **slip channel** through a webhook. You check the slip against your bank app and react ✅. The list of donors (`GET /api/donors`) is read live from that channel.
2. **Class guides.** A guide author sends a guide code to `POST /guide`; the Worker posts it to your private **guide channel** through a second webhook, with a **ดูตัวอย่าง** (preview) link. You open the preview, and if the guide is good you react ✅. The list of guides (`GET /api/guides`) is read live from that channel, and each approved guide gets its number.

Secrets exist only as Worker secrets, never in a file of this repo. Runs on the Workers free plan (a handful of posts a day).

## Routes

| Route | What it does |
| --- | --- |
| `POST /slip` | Donor form: fields `name` (required), `msg`, `amount` (both optional) and `slip` (required image). Posts it to the slip channel. |
| `GET /api/donors` | The ✅'d slips as `{ "donors": [{ k, name, msg, amount, date }] }`, oldest first. |
| `POST /guide` | Fields `code` (a guide code, TG3 or TG2.) and `replaces` (optional guide number to replace). Posts it to the guide channel with a ดูตัวอย่าง link. |
| `GET /api/guides` | The ✅'d guides as `{ "floor", "guides": [...] }`. |
| `GET /g/<msgId>.<sig>` | The ดูตัวอย่าง link: opens the guide in the Bible. Only a link the Worker made itself works (the `<sig>` is checked). |

Any other path answers 404 `not-found`.

## Variables and secrets

Variables go in `wrangler.toml` under `[vars]` (not secret; they are Discord ids). **Fill them in the file itself.** Every `npx wrangler deploy` overwrites values typed in the Cloudflare dashboard with the file's, so a dashboard-only value is lost on the next deploy.

| Var | Meaning |
| --- | --- |
| `SLIP_CHANNEL` | Id of the private slip channel. |
| `GUIDE_CHANNEL` | Id of the private guide channel. |
| `OWNER_ID` | Your Discord user id. Only your replies count as amount replies. |
| `GUIDE_NUM_FLOOR` | Guide numbers are given from this number up (already `"106"` in the file; the next new guide gets at least 107). |

Secrets (set with `npx wrangler secret put <NAME>`):

| Secret | Meaning |
| --- | --- |
| `DISCORD_WEBHOOK_URL` | Webhook of the slip channel. |
| `DISCORD_GUIDE_WEBHOOK_URL` | Webhook of the guide channel. It also signs the ดูตัวอย่าง links. |
| `DISCORD_BOT_TOKEN` | The bot that reads both channels. |

Also in `wrangler.toml`: the rate-limit binding `SLIP_LIMIT` (2 requests per minute per IP).

## Setup (you do every step; first time about 20 minutes)

Slips only (`DISCORD_WEBHOOK_URL`) were set up before; steps 1 to 5 add the guide side and the ✅ reading.

1. **Guide channel and webhook.** In Discord create a second private text channel (only you can see it). Open **Edit Channel** (gear icon) > **Integrations** > **Webhooks** > **New Webhook** > **Copy Webhook URL**. Keep it in the clipboard; do not paste it into any file.
2. **The bot.** The Worker reads the channels as a bot. Reuse the wardrobe's **12 Tails Skins** bot, or make a new one at https://discord.com/developers/applications. Then:
   - In the bot's **Bot** page, turn **Message Content Intent** on (it is needed to read your amount replies).
   - Invite the bot to your server if it is not there yet, and give it access to **both** private channels (channel settings > **Permissions**): **View Channel** and **Read Message History**.
3. **Ids.** In Discord turn on **User Settings** > **Advanced** > **Developer Mode**. Right-click each private channel > **Copy Channel ID**, and right-click your own name > **Copy User ID**. Put the three ids into `wrangler.toml`: `SLIP_CHANNEL`, `GUIDE_CHANNEL`, `OWNER_ID`.
4. **Secrets.** In this folder (`12t_projects/donate-worker`), run both and paste the value when asked (the text stays hidden):

   ```sh
   npx wrangler secret put DISCORD_GUIDE_WEBHOOK_URL
   npx wrangler secret put DISCORD_BOT_TOKEN
   ```

   (`DISCORD_WEBHOOK_URL` is already set from before; run `npx wrangler secret put DISCORD_WEBHOOK_URL` only if you made a new slip webhook.)
5. **Deploy:**

   ```sh
   npx wrangler deploy
   ```

   The first time ever, it asks you to log in (`npx wrangler login`, press **Allow** in the browser tab) and to pick a `*.workers.dev` subdomain. The Worker address is `https://12tails-donate.<your-subdomain>.workers.dev`.
6. **Live check.**
   1. Send a slip from the ☕ pop-up and a guide from the guide page.
   2. In Discord, react ✅ on both posts.
   3. Open the site: the slip shows in the donor list and the guide in the guide list.
   4. Open `<Worker address>/api/donors` from the Bible page's origin (or check the site twice): the **second** request within 60 seconds must show the response header `x-list-cache: hit` (the first shows `miss`). The same for `/api/guides`.
   5. Remove the ✅ from both posts. After up to 60 seconds each one leaves the site.

If `x-list-cache` never turns to `hit`, the 60-second copy is not holding, and every page view reads Discord. The upgrade is a Durable Object that keeps the copy (not needed unless this happens).

## Owner rules

- **The ✅ is the approval.** Any ✅ in the channel counts, from anyone who can see it, so keep both channels private.
- **Amount reply.** A slip without an amount says so in the post. Reply to that post with just the number, e.g. `150` or `1,500`. A reply that is not a valid amount is ignored; the latest valid reply wins. A slip with no amount at all (no reply, none in the form) does not show.
- **Never delete a numbered guide post.** The guide's number is written into its post (the footer); deleting the post loses the number. To take a guide off the site, remove its ✅ instead.
- **Delete rejected posts** (slips or guides you will never ✅); they are only clutter and cost nothing to remove.

## Check it

- `node 12t_projects/donate-worker/test.mjs` runs the tests for all routes (no network, no account; the lists and guides are in `test_lists.mjs` and `test_guides.mjs`).
- `npx wrangler deploy --dry-run` bundles without deploying (needs no login).

## What it accepts

Common to all routes:

- Only requests from `https://jumpptty.github.io` (and `null`, a double-clicked local copy of the page); any other origin gets 403 `origin`.
- Wrong HTTP method: 405 `method`.
- `POST /slip` and `POST /guide` share the limit of 2 requests per minute per IP (binding `SLIP_LIMIT`), otherwise 429 `rate`.

`POST /slip`:

- `name` (required), `msg` (optional), `amount` (optional, in baht, e.g. `150` or `1,500`, more than 0 up to 1,000,000, at most 2 decimals) and `slip` (required).
- The limits in `scripts/donors.js` (`checkSlipDetails`): name 1-40 characters, message up to 200, slip a JPEG, PNG or WebP up to 5 MB (the file's first bytes are checked too).
- Answers are JSON: `{ "ok": true }` or `{ "ok": false, "error": ... }` with `error` one of `origin`, `method`, `missing`, `invalid` (plus `field`: `name`, `msg` or `amount`, and a Thai `message`), `file-type`, `file-size`, `rate`, `discord`.

`POST /guide`:

- `code` must be a TG3 or TG2. guide code that decodes to a class guide with a known class and server, a title and an author. `replaces`, if given, is a positive whole number.
- Errors: `origin`, `method`, `rate`, `invalid` (plus a Thai `message`), `size` (413, body over about 400 KB), `closed` (503, the guide webhook secret is missing), `upstream` (502, Discord refused).
- A code too long for a Discord footer travels as an attached `guide.txt` instead; this is invisible to the author.

`GET /api/donors` and `GET /api/guides`:

- Answer `closed` (503) until the secrets and vars they need are set (`DISCORD_BOT_TOKEN` and the channel id; for guides also `DISCORD_GUIDE_WEBHOOK_URL` and `GUIDE_NUM_FLOOR`), and `upstream` (502) if Discord fails.
- The answer is kept for 60 seconds (`x-list-cache: hit` or `miss`), so Discord is read at most about once a minute per Worker copy, however many people open the page.

## Android note

The old **อนุมัติ** link is gone: slip posts no longer carry one, and the ✅ replaces it. The guide manager's old `#donor=...` links in older Discord messages still work. If one of those opens the guide manager without the donation (no card shows up), Discord's in-app browser dropped the `#...` part. Turn it off: Discord > **User Settings** > **App Settings** > **Web Browser** (or **Appearance** > **Use in-app browser**) and open links in Chrome instead. The new **ดูตัวอย่าง** link has no `#` in it, so it is not affected.
