// Discord helpers shared by the Worker routes: the channel reader, the 60 s list cache, the footer meta, webhook edits.
// Pattern copied from the wardrobe Worker (site_worker.mjs).
export const SITE = "https://jumpptty.github.io";
export const ORIGINS = [SITE, "null"];   // "null": a double-clicked local copy of the page
export const META_TAG = "meta ";
const API = "https://discord.com/api/v10";
const LIST_SEC = 60;
// Discord wants a DiscordBot user-agent from bots
const UA = "DiscordBot (https://12tails-donate.workers.dev, 1)";

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

// the data centre's cache when there is one (not under node)
export async function cachedList(key, make){
  const c = typeof caches === "undefined" ? null : caches.default, req = new Request("https://donate.invalid/" + key);
  const hit = c && await c.match(req);
  if (hit) return { value: await hit.json(), hit: true };
  const value = await make();
  if (c) await c.put(req, new Response(JSON.stringify(value), { headers: { "cache-control": "max-age=" + LIST_SEC } }));
  return { value, hit: false };
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
