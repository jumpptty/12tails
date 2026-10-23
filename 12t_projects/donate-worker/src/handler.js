// The ☕ slip Worker: checks a donor's form and forwards it to a private Discord channel. Nothing is stored.
// The webhook URL lives only in the Worker secret DISCORD_WEBHOOK_URL.
// The form is the display name, an optional message and the slip (user 2026-10-23): the owner reads the amount and the transfer time off
// the slip and types them into the guide manager. An "amount" or "date" field (a page cached from before) is ignored.
import { LIMITS, checkSlipDetails, donorFragment } from "../../../scripts/donors.js";

const SITE = "https://jumpptty.github.io";
const MANAGER = SITE + "/12tails/12t_projects/guide-manager/";
const ORIGINS = [SITE, "null"];   // "null": a double-clicked local copy of the page
const FIELDS = ["name", "msg"];   // the order checkSlipDetails looks at them
// file extensions only; which types are allowed comes from LIMITS.slipTypes
const TYPES = { "image/jpeg": "jpg", "image/png": "png", "image/webp": "webp" };

const ascii = (b, at, s) => [...s].every((c, i) => b[at + i] === c.charCodeAt(0));
function sniff(b){
  if (b[0] === 0xff && b[1] === 0xd8 && b[2] === 0xff) return "image/jpeg";
  if (b[0] === 0x89 && ascii(b, 1, "PNG")) return "image/png";
  if (ascii(b, 0, "RIFF") && ascii(b, 8, "WEBP")) return "image/webp";
  return null;
}

// backslash before Discord markdown characters; "@" gets a zero-width space so it can never read as a mention
const escapeMd = (s) => s.replace(/[\\*_~`|>\[\]()#\-!<]/g, "\\$&").replace(/@/g, "@\u200b");

function answer(status, body, origin){
  const headers = { "Content-Type": "application/json" };
  if (origin){ headers["Access-Control-Allow-Origin"] = origin; headers.Vary = "Origin"; }
  return new Response(JSON.stringify(body), { status, headers });
}

// which field checkSlipDetails refused: test each one alone against known-good values
function badField(d){
  const ok = { name: "a", msg: "" };
  for (const f of FIELDS){
    try { checkSlipDetails({ ...ok, [f]: d[f] }); } catch (e){ return f; }
  }
  return FIELDS[0];
}

export async function handleSlip(request, env, deps){
  const origin = request.headers.get("Origin");
  if (!ORIGINS.includes(origin)) return answer(403, { ok: false, error: "origin" }, null);
  const url = new URL(request.url);
  if (request.method === "OPTIONS")
    return new Response(null, { status: 204, headers: { "Access-Control-Allow-Origin": origin, "Access-Control-Allow-Methods": "POST, OPTIONS", "Access-Control-Allow-Headers": "Content-Type", "Access-Control-Max-Age": "86400", Vary: "Origin" } });
  if (request.method !== "POST" || url.pathname !== "/slip") return answer(405, { ok: false, error: "method" }, origin);

  // the limit comes before the body is read
  let allowed = false;
  try { allowed = (await env.SLIP_LIMIT.limit({ key: request.headers.get("CF-Connecting-IP") || "unknown" })).success; } catch (e){ console.error("rate limiter failed (refusing): " + (e && e.name) + ": " + (e && e.message)); }
  if (!allowed) return answer(429, { ok: false, error: "rate" }, origin);

  if (Number(request.headers.get("Content-Length")) > LIMITS.slipBytes + 65536) return answer(413, { ok: false, error: "file-size" }, origin);
  let form;
  try { form = await request.formData(); } catch (e){ return answer(400, { ok: false, error: "missing" }, origin); }

  const text = (k) => { const v = form.get(k); return typeof v === "string" ? v : null; };
  const slip = form.get("slip");
  if (text("name") === null || !slip || typeof slip === "string") return answer(400, { ok: false, error: "missing" }, origin);

  const raw = { name: text("name"), msg: text("msg") || "" };
  let d;
  try { d = checkSlipDetails(raw); }
  catch (e){ return answer(400, { ok: false, error: "invalid", field: badField(raw), message: e.message }, origin); }

  if (!LIMITS.slipTypes.includes(slip.type)) return answer(400, { ok: false, error: "file-type" }, origin);
  if (slip.size > LIMITS.slipBytes) return answer(413, { ok: false, error: "file-size" }, origin);
  const bytes = new Uint8Array(await slip.arrayBuffer()), type = sniff(bytes);
  if (!type || !LIMITS.slipTypes.includes(type)) return answer(400, { ok: false, error: "file-type" }, origin);
  const filename = "slip." + TYPES[type];

  const payload = {
    content: "**[อนุมัติ](" + MANAGER + "#" + donorFragment(d) + ")**",
    embeds: [{
      title: "สลิปใหม่",
      description: "ดูยอดและวันเวลาที่โอนจากสลิป แล้วกรอกเองในหน้าอนุมัติ",
      fields: [
        { name: "ชื่อ", value: escapeMd(d.name) },
        { name: "ข้อความ", value: d.msg ? escapeMd(d.msg) : "-" },
      ],
      image: { url: "attachment://" + filename },
    }],
    allowed_mentions: { parse: [] },
    attachments: [{ id: 0, filename }],
  };
  const out = new FormData();
  out.append("payload_json", JSON.stringify(payload));
  out.append("files[0]", new Blob([bytes], { type }), filename);

  let hook;
  try { hook = new URL(env.DISCORD_WEBHOOK_URL); }
  catch (e){ console.error("discord: DISCORD_WEBHOOK_URL is not a valid URL (secret missing or mistyped)"); return answer(502, { ok: false, error: "discord" }, origin); }
  hook.searchParams.set("wait", "true");
  const send = deps.fetch;   // called unbound: workerd throws "Illegal invocation" when the global fetch gets another `this`
  try {
    const res = await send(hook.toString(), { method: "POST", body: out });
    if (!res.ok){
      let body = "";
      try { body = (await res.text()).slice(0, 200); } catch (e2){ /* no body */ }
      console.error("discord: HTTP " + res.status + " " + body);
      return answer(502, { ok: false, error: "discord" }, origin);
    }
  } catch (e){
    console.error("discord: fetch failed " + (e && e.name) + ": " + String(e && e.message).split(env.DISCORD_WEBHOOK_URL).join("<webhook>"));
    return answer(502, { ok: false, error: "discord" }, origin);
  }
  return answer(200, { ok: true }, origin);
}
