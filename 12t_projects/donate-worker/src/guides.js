// Class guides approved with a ✅ in a private Discord channel. POST /guide posts a submitted code through the guide webhook,
// GET /api/guides lists the ✅'d posts (numbers kept in the post footers), GET /g/<msgId>.<sig> is the owner's ดูตัวอย่าง link.
// The code is decoded here (scripts/guide_code.js), because the page's own decoder is async; the code itself is never returned.
import guideCode from "../../../scripts/guide_code.js";
import { SITE, answer, gate, META_TAG, escapeMd, readChannel, readMessage, cachedList, footerMeta, webhookParts, editWebhookMessage, listAnswer } from "./discord.js";

const { decode, CLASS_GUIDE_CLASS_KEYS, CLASS_GUIDE_SERVER_KEYS } = guideCode;
const PAGE = SITE + "/12tails/12t_projects/bible/";
const FOOTER_MAX = 2048;
const big = (id) => BigInt(id);
const byId = (a, b) => (big(a.id) > big(b.id)) - (big(a.id) < big(b.id));
const posInt = (v) => Number.isInteger(v) && v > 0 ? v : null;
// a code as scripts/add_guide.js's decodeCode reads it: TG3 or TG2. only, and the guide's own format field
function readCode(code){
  const text = String(code).trim();
  if (!/^(TG3|TG2.)/.test(text)) throw new Error("not a guide code");
  const g = decode(text);
  if (!g || g.format !== "12t-class-guide") throw new Error("not a guide");
  return g;
}
const clip = (s, n) => s.length > n ? s.slice(0, n - 1) + "…" : s;

// the one builder of the post body: a webhook PATCH replaces content and embeds wholesale, so the first post and both edits go through here
export function guidePostBody(meta, guide, { previewUrl = "", num = null, fileId = null } = {}){
  const b = guide.build || {}, replaces = posInt(meta.replaces), shown = num || meta.num;
  const fields = [
    { name: "ผู้เขียน", value: escapeMd(clip(String(guide.author), 200)), inline: true },
    { name: "เซิร์ฟเวอร์", value: String(b.server).toUpperCase(), inline: true },
    { name: "อาชีพ", value: String(b.classKey), inline: true },
    { name: "เลเวล", value: String(Number(b.level) || 0), inline: true },
    { name: "โหมด", value: (Array.isArray(guide.modes) ? guide.modes : []).join(" / ").toUpperCase() || "-", inline: true },
  ];
  const body = {
    content: [previewUrl && "ดูตัวอย่าง: " + previewUrl, num && `#${num} · อย่าลบโพสต์นี้ ถ้าจะเอาออกให้เอา ✅ ออก`].filter(Boolean).join("\n"),
    embeds: [{
      title: escapeMd(clip(String(guide.title), 200)),
      ...(replaces ? { description: `แทนที่ #${replaces} ([ดูไกด์เดิม](${PAGE}#class-guide/${replaces}))` } : {}),
      fields,
      footer: { text: META_TAG + JSON.stringify({ ...meta, num: shown || null }) },
    }],
    allowed_mentions: { parse: [] },
  };
  if (fileId !== null) body.attachments = [{ id: fileId }];
  return body;
}

// HMAC of the message id keyed by the guide webhook URL: only the owner's posts have a preview link
export async function previewLink(env, msgId, origin){
  const key = await crypto.subtle.importKey("raw", new TextEncoder().encode(env.DISCORD_GUIDE_WEBHOOK_URL), { name: "HMAC", hash: "SHA-256" }, false, ["sign"]);
  const mac = new Uint8Array(await crypto.subtle.sign("HMAC", key, new TextEncoder().encode(String(msgId))));
  return `${origin}/g/${msgId}.${[...mac.slice(0, 8)].map((x) => x.toString(16).padStart(2, "0")).join("")}`;
}

const stamp = (m) => new Date(m.timestamp || Number(big(m.id) >> 22n) + 1420070400000).toISOString().slice(0, 19) + "Z";
const hasCheck = (m) => (m.reactions || []).some((r) => r.emoji && r.emoji.name === "✅");
// a footer whose JSON is broken can still show its number
const rawNum = (m) => { for (const e of m.embeds || []){ const x = /"num":\s*(\d+)/.exec((e.footer && e.footer.text) || ""); if (x) return Number(x[1]); } return null; };

// pure: the ✅'d guides among a channel's messages (any order), and the posts still waiting for a number.
// codes: { <msgId>: code } for posts whose footer says "@file" (the caller fetched the attachments)
export function listGuides(messages, { webhookId, floor, codes = {} }){
  let top = floor;
  const rows = [];
  for (const m of messages.filter((x) => x.webhook_id === webhookId).sort(byId)){
    const meta = footerMeta(m), footerNum = meta ? posInt(meta.num) : rawNum(m);
    if (footerNum) top = Math.max(top, footerNum);
    const replaces = meta && posInt(meta.replaces);
    if (replaces) top = Math.max(top, replaces);   // also on a post whose ✅ is off: it may be re-✅'d
    if (!meta || !hasCheck(m)) continue;
    let guide;
    try { guide = readCode(meta.code === "@file" ? codes[m.id] : meta.code); } catch (e){ continue; }
    if (!guide || typeof guide !== "object") continue;
    rows.push({ m, meta, num: replaces || footerNum, guide });
  }
  const assign = [];
  for (const r of rows) if (!r.num) assign.push({ msg: r.m, num: r.num = ++top });
  const newest = new Map();   // two posts on one number: the newer one wins
  for (const r of rows) newest.set(r.num, r);
  const live = new Set(newest.values());
  const guides = rows.filter((r) => live.has(r)).map((r) => {
    const published = stamp(r.m);
    return { num: r.num, replaces: posInt(r.meta.replaces), guide: { ...r.guide, id: r.num, date: new Date(Date.parse(published) + 7 * 36e5).toISOString().slice(0, 10), published }, published, msg: r.m.id };
  });
  return { guides, assign: assign.filter((a) => live.has(rows.find((r) => r.m === a.msg))) };
}

const err = (status, error, origin, extra = {}) => answer(status, { ok: false, error, ...extra }, origin);
const bad = (origin, message) => err(400, "invalid", origin, { message });
const textOf = (v) => typeof v === "string" ? v : "";

export async function handleGuidePost(request, env, deps){
  const refused = await gate(request, env, { method: "POST", preflight: true, limit: true });
  if (refused) return refused;
  const origin = request.headers.get("Origin");

  let hook;
  try { hook = new URL(env.DISCORD_GUIDE_WEBHOOK_URL); webhookParts(hook.href); } catch (e){ return err(503, "closed", origin); }
  if (Number(request.headers.get("Content-Length")) > 400000) return err(413, "size", origin);
  let form;
  try { form = await request.formData(); } catch (e){ return bad(origin, "ส่งข้อมูลไม่ครบ"); }

  const code = textOf(form.get("code")).trim(), rawReplaces = textOf(form.get("replaces")).trim();
  let guide;
  try { guide = readCode(code); } catch (e){ return bad(origin, "โค้ดไกด์อ่านไม่ได้"); }
  const b = (guide && guide.build) || {};
  if (!code || !CLASS_GUIDE_CLASS_KEYS.includes(b.classKey) || !CLASS_GUIDE_SERVER_KEYS.includes(b.server)) return bad(origin, "โค้ดไกด์อ่านไม่ได้");
  if (!textOf(guide.title).trim() || !textOf(guide.author).trim()) return bad(origin, "ไกด์ต้องมีชื่อเรื่องและชื่อผู้เขียน");
  if (rawReplaces && !/^[1-9]\d{0,8}$/.test(rawReplaces)) return bad(origin, "เลขไกด์ที่จะแทนที่ต้องเป็นจำนวนเต็มบวก");

  const meta = { v: 1, code, replaces: rawReplaces ? Number(rawReplaces) : null, num: null };
  let body = guidePostBody(meta, guide), payload;
  const file = META_TAG.length + JSON.stringify(meta).length > FOOTER_MAX - 20;   // too long for a footer: the code travels as guide.txt
  if (file){
    body = guidePostBody({ ...meta, code: "@file" }, guide);
    body.attachments = [{ id: 0, filename: "guide.txt" }];
    payload = new FormData();
    payload.append("payload_json", JSON.stringify(body));
    payload.append("files[0]", new Blob([code], { type: "text/plain" }), "guide.txt");
  }
  hook.searchParams.set("wait", "true");
  const send = deps.fetch;   // called unbound (workerd)
  try {
    const res = await send(hook.toString(), file ? { method: "POST", body: payload } : { method: "POST", headers: { "content-type": "application/json" }, body: JSON.stringify(body) });
    if (!res.ok) throw new Error("HTTP " + res.status);
    const posted = await res.json();
    // the link needs the message id, so a PATCH follows the post
    const fileId = file ? String((posted.attachments && posted.attachments[0] && posted.attachments[0].id) ?? "") : null;
    const edited = await editWebhookMessage(hook.href, posted.id, guidePostBody(file ? { ...meta, code: "@file" } : meta, guide, { previewUrl: await previewLink(env, posted.id, new URL(request.url).origin), fileId }), send);
    if (!edited) throw new Error("preview link PATCH failed");
  } catch (e){
    console.error("guide: " + String(e && e.message).split(env.DISCORD_GUIDE_WEBHOOK_URL).join("<webhook>"));
    return err(502, "upstream", origin);
  }
  return answer(200, { ok: true }, origin);
}

export async function handleGuides(request, env, deps){
  const refused = await gate(request, env, { method: "GET" });
  if (refused) return refused;
  const origin = request.headers.get("Origin");
  const token = String(env.DISCORD_BOT_TOKEN || "").trim(), channel = String(env.GUIDE_CHANNEL || "").trim(), floor = Number(env.GUIDE_NUM_FLOOR);
  let webhookId;
  try { webhookId = webhookParts(env.DISCORD_GUIDE_WEBHOOK_URL).id; } catch (e){ webhookId = ""; }
  if (!token || !channel || !webhookId || !Number.isFinite(floor)) return err(503, "closed", origin);
  const send = deps.fetch, base = new URL(request.url).origin;
  try {
    const { value, hit } = await cachedList("guides:" + channel, async () => {
      const messages = await readChannel(token, channel, send), codes = {};
      for (const m of messages){
        const meta = m.webhook_id === webhookId && footerMeta(m), att = m.attachments && m.attachments[0];
        if (meta && meta.code === "@file" && att) try { codes[m.id] = await (await send(att.url)).text(); } catch (e){ /* skipped as undecodable */ }
      }
      const { guides, assign } = listGuides(messages, { webhookId, floor, codes });
      // ponytail: two data centres can assign at once; a Durable Object counter if it ever happens
      const unsaved = new Set();   // a number is shown only once it is in a footer
      for (const { msg, num } of assign){
        const meta = footerMeta(msg), g = guides.find((x) => x.msg === msg.id);
        const fileId = meta.code === "@file" ? String(msg.attachments[0].id) : null;
        if (!await editWebhookMessage(env.DISCORD_GUIDE_WEBHOOK_URL, msg.id, guidePostBody(meta, g.guide, { previewUrl: await previewLink(env, msg.id, base), num, fileId }), send)) { unsaved.add(msg.id); console.error("guides: numbering PATCH failed for " + msg.id); }
      }
      return { floor, guides: guides.filter((g) => !unsaved.has(g.msg)) };
    });
    return listAnswer(origin, value, hit);
  } catch (e){
    console.error("guides: " + (e && e.message));
    return err(502, "upstream", origin);
  }
}

export async function handlePreview(request, env, deps){
  const m = /^\/g\/(\d+)\.([0-9a-f]{16})$/.exec(new URL(request.url).pathname);
  const notFound = () => new Response("not found", { status: 404 });
  if (!m || !env.DISCORD_GUIDE_WEBHOOK_URL) return notFound();
  const want = (await previewLink(env, m[1], "")).slice(-16);
  let diff = 0;   // constant time
  for (let i = 0; i < 16; i++) diff |= want.charCodeAt(i) ^ m[2].charCodeAt(i);
  if (diff) return notFound();
  const token = String(env.DISCORD_BOT_TOKEN || "").trim(), channel = String(env.GUIDE_CHANNEL || "").trim();
  if (!token || !channel) return new Response("closed", { status: 503 });
  try {
    const msg = await readMessage(token, channel, m[1], deps.fetch), meta = footerMeta(msg);
    if (!meta) return notFound();
    const att = msg.attachments && msg.attachments[0];
    const code = meta.code === "@file" ? await (await deps.fetch(att.url)).text() : meta.code;
    // JSON.stringify and encodeURIComponent: nothing in the code can break out of the string
    const to = JSON.stringify(PAGE + "#class-guide/code/" + encodeURIComponent(String(code).trim()));
    return new Response(`<!doctype html><meta charset="utf-8"><meta name="robots" content="noindex"><title>ดูตัวอย่างไกด์</title><script>location.replace(${to})</script>`, { headers: { "Content-Type": "text/html; charset=utf-8" } });
  } catch (e){
    console.error("preview: " + (e && e.message));
    return new Response("upstream", { status: 502 });
  }
}
