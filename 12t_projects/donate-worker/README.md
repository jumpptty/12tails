# 12tails-donate: the ☕ slip Worker

A tiny Cloudflare Worker. A donor fills in the form in the Bible's ☕ pop-up (display name, message, amount, date, slip image). The page sends it to this Worker (`POST /slip`), the Worker checks it and posts it to your private Discord channel through a webhook. The post carries the slip, the details and an **อนุมัติ** link that opens the guide manager with the donation already filled in. Nothing is stored anywhere.

The Discord webhook URL is a secret: it exists only as the Worker secret `DISCORD_WEBHOOK_URL`, never in a file of this repo.

Runs on the Workers free plan. Free plan limits do not matter here (a handful of slips a day).

## Setup (you do every step; it takes about 10 minutes)

1. **Discord:** create a private text channel (only you can see it). Open the channel's **Edit Channel** (gear icon) > **Integrations** > **Webhooks** > **New Webhook**, then **Copy Webhook URL**. Keep it in the clipboard; do not paste it into any file.
2. **Cloudflare:** create a free account at https://dash.cloudflare.com/sign-up (no card needed for Workers).
3. Open a terminal in this folder (`12t_projects/donate-worker`) and log in:

   ```sh
   npx wrangler login
   ```

   A browser tab opens; press **Allow**.
4. Deploy the Worker:

   ```sh
   npx wrangler deploy
   ```

   The first time it asks you to pick a `*.workers.dev` subdomain; choose any name.
5. Give the Worker the webhook (paste it when asked; the text stays hidden):

   ```sh
   npx wrangler secret put DISCORD_WEBHOOK_URL
   ```
6. Note the URL that `deploy` printed, `https://12tails-donate.<your-subdomain>.workers.dev`. The page posts to `<that URL>/slip`.

To change the code later, run `npx wrangler deploy` again; the secret stays.

## Check it

- `node 12t_projects/donate-worker/test.mjs` runs the tests (no network, no account).
- `npx wrangler deploy --dry-run` bundles without deploying (needs no login).

## What it accepts

- Only requests from `https://jumpptty.github.io` (and `null`, a double-clicked local copy of the page); any other origin gets 403 `origin`.
- 2 requests per minute per IP (Workers Rate Limiting binding `SLIP_LIMIT`, set in `wrangler.toml`), otherwise 429 `rate`.
- The limits in `scripts/donors.js`: name 1-40 characters, message up to 200, amount above 0 and up to 1,000,000 baht, date from 2020-01-01 to tomorrow, slip a JPEG, PNG or WebP up to 5 MB (the file's first bytes are checked too).
- Answers are JSON: `{ "ok": true }` or `{ "ok": false, "error": ... }` with `error` one of `origin`, `method`, `missing`, `invalid` (plus `field` and a Thai `message`), `file-type`, `file-size`, `rate`, `discord`.

## Android note

If the **อนุมัติ** link in Discord opens the guide manager without the donation (no card shows up), Discord's in-app browser dropped the `#...` part. Turn it off: Discord > **User Settings** > **App Settings** > **Web Browser** (or **Appearance** > **Use in-app browser**) and open links in Chrome instead.
