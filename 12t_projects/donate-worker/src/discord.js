// Discord helpers shared by the Worker routes: the channel reader, the 60 s list cache, the footer meta, webhook edits.
// Pattern copied from the wardrobe Worker (site_worker.mjs).
export const SITE = "https://jumpptty.github.io";
export const ORIGINS = [SITE, "null"];   // "null": a double-clicked local copy of the page
export const META_TAG = "meta ";
const API = "https://discord.com/api/v10";
const LIST_SEC = 60;
// Discord wants a DiscordBot user-agent from bots
const UA = "DiscordBot (https://12tails-donate.workers.dev, 1)";

// backslash before Discord markdown characters; "@" gets a zero-width space so it can never read as a mention
export const escapeMd = (s) => s.replace(/[\\*_~`|>\[\]()#\-!<]/g, "\\$&").replace(/@/g, "@\u200b");

export async function readMessage(token, channelId, msgId, fetch){
  const r = await fetch(`${API}/channels/${channelId}/messages/${msgId}`, { headers: { authorization: "Bot " + token, "user-agent": UA } });
  if (!r.ok) throw new Error("discord " + r.status);
  return r.json();
}

export async function readChannel(token, channelId, fetch){
  const out = [];
  for (let before = ""; ;){
    const r = await fetch(`${API}/channels/${channelId}/messages?limit=100${before && "&before=" + before}`,
      { headers: { authorization: "Bot " + token, "user-agent": UA } });
    if (!r.ok) throw new Error("discord " + r.status);
    const page = await r.json();
    out.push(...page);
    if (page.length < 100) return out;
    before = page[page.length - 1].id;
  }
}

// 60 s copy per isolate first (a workers.dev host ignores caches.default), then the data centre's cache when there is one (not under node)
const memo = new Map();
export async function cachedList(key, make, now = Date.now){
  const m = memo.get(key);
  if (m && m.until > now()) return { value: m.value, hit: true };
  const c = typeof caches === "undefined" ? null : caches.default, req = new Request("https://donate.invalid/" + key);
  const hit = c && await c.match(req);
  let value, fromCache = false;
  if (hit){ value = await hit.json(); fromCache = true; }
  else {
    value = await make();   // a throw skips the memo below
    if (c) await c.put(req, new Response(JSON.stringify(value), { headers: { "cache-control": "max-age=" + LIST_SEC } }));
  }
  memo.set(key, { value, until: now() + LIST_SEC * 1000 });
  return { value, hit: fromCache };
}

export function footerMeta(m){
  for (const e of m.embeds || []){
    const t = (e.footer && e.footer.text) || "";
    if (t.startsWith(META_TAG)) try { return JSON.parse(t.slice(META_TAG.length)); } catch (x){ /* not ours */ }
  }
  return null;
}

// .../api/webhooks/<id>/<token>
export function webhookParts(url){
  const p = new URL(url).pathname.split("/").filter(Boolean);
  return { id: p[p.length - 2], token: p[p.length - 1] };
}

export async function editWebhookMessage(hookUrl, msgId, body, fetch){
  const { id, token } = webhookParts(hookUrl);
  const r = await fetch(`${API}/webhooks/${id}/${token}/messages/${msgId}`,
    { method: "PATCH", headers: { "content-type": "application/json" }, body: JSON.stringify(body) });
  return r.ok;
}

export function listAnswer(origin, value, hit){
  const headers = { "Content-Type": "application/json", "cache-control": "public, max-age=" + LIST_SEC, "x-list-cache": hit ? "hit" : "miss" };
  if (origin){ headers["Access-Control-Allow-Origin"] = origin; headers.Vary = "Origin"; }
  return new Response(JSON.stringify(value), { headers });
}
