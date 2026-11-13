// GET /api/donors: the ☕ list, read live from the private slip channel. A slip counts once the owner reacts ✅.
import { checkAmount } from "../../../scripts/donors.js";
import { ORIGINS, readChannel, cachedList, footerMeta, webhookParts, listAnswer } from "./discord.js";

const big = (id) => BigInt(id);

// pure: the donors among a channel's messages (any order)
export function listDonors(messages, { webhookId, ownerId }){
  // the owner's replies per post: the latest one whose text is a valid amount wins
  const replies = new Map();
  for (const m of messages){
    const to = m.message_reference && m.message_reference.message_id;
    if (!to || m.webhook_id || !m.author || m.author.id !== ownerId) continue;
    let amount;
    try { amount = checkAmount(String(m.content || "").trim()); } catch (e){ continue; }
    const cur = replies.get(to);
    if (!cur || big(m.id) > big(cur.id)) replies.set(to, { id: m.id, amount });
  }
  const out = [];
  for (const m of messages){
    if (m.webhook_id !== webhookId || !(m.reactions || []).some((r) => r.emoji && r.emoji.name === "✅")) continue;
    const meta = footerMeta(m);
    if (!meta) continue;
    const rep = replies.get(m.id), amount = rep ? rep.amount : meta.amount;
    if (typeof amount !== "number") continue;
    out.push({ k: m.id, name: String(meta.name || ""), msg: String(meta.msg || ""), amount, date: String(meta.date || "") });
  }
  return out.sort((a, b) => (big(a.k) > big(b.k)) - (big(a.k) < big(b.k)));
}

const err = (status, error, origin) => {
  const headers = { "Content-Type": "application/json" };
  if (origin){ headers["Access-Control-Allow-Origin"] = origin; headers.Vary = "Origin"; }
  return new Response(JSON.stringify({ ok: false, error }), { status, headers });
};

export async function handleDonors(request, env, deps){
  const origin = request.headers.get("Origin");
  if (!ORIGINS.includes(origin)) return err(403, "origin", null);
  if (request.method !== "GET") return err(405, "method", origin);
  const token = String(env.DISCORD_BOT_TOKEN || "").trim(), channel = String(env.SLIP_CHANNEL || "").trim();
  let webhookId;
  try { webhookId = webhookParts(env.DISCORD_WEBHOOK_URL).id; } catch (e){ webhookId = ""; }
  if (!token || !channel || !webhookId) return err(503, "closed", origin);
  try {
    const { value, hit } = await cachedList("donors", async () => ({
      donors: listDonors(await readChannel(token, channel, deps.fetch), { webhookId, ownerId: String(env.OWNER_ID || "").trim() }),
    }));
    return listAnswer(origin, value, hit);
  } catch (e){
    console.error("donors: " + (e && e.message));
    return err(502, "upstream", origin);
  }
}
