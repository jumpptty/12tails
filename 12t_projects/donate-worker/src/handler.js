// The ☕ slip Worker: checks a donor's form and forwards it to a private Discord channel. Nothing is stored.
// The webhook URL lives only in the Worker secret DISCORD_WEBHOOK_URL.
// The form is the display name, an optional message, an optional amount and the slip. The owner checks the slip against the bank app and
// reacts ✅ in Discord; a post without an amount asks the owner to reply with it. The embed footer carries the "meta {json}" the list reads.
import { LIMITS, checkSlipDetails, checkAmount } from "../../../scripts/donors.js";
import { META_TAG, escapeMd, answer, gate } from "./discord.js";

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

// which field checkSlipDetails refused: test each one alone against known-good values
function badField(d){
  const ok = { name: "a", msg: "" };
  for (const f of FIELDS){
    try { checkSlipDetails({ ...ok, [f]: d[f] }); } catch (e){ return f; }
  }
  return FIELDS[0];
}

export async function handleSlip(request, env, deps){
  const refused = await gate(request, env, { method: "POST", path: "/slip", preflight: true, limit: true });
  if (refused) return refused;
  const origin = request.headers.get("Origin");

  if (Number(request.headers.get("Content-Length")) > LIMITS.slipBytes + 65536) return answer(413, { ok: false, error: "file-size" }, origin);
  let form;
  try { form = await request.formData(); } catch (e){ return answer(400, { ok: false, error: "missing" }, origin); }

  const text = (k) => { const v = form.get(k); return typeof v === "string" ? v : null; };
  const slip = form.get("slip");
  if (text("name") === null || !slip || typeof slip === "string") return answer(400, { ok: false, error: "missing" }, origin);

  const raw = { name: text("name"), msg: text("msg") || "" };
  let d, amount = null;
  try { d = checkSlipDetails(raw); }
  catch (e){ return answer(400, { ok: false, error: "invalid", field: badField(raw), message: e.message }, origin); }
  const rawAmount = (text("amount") || "").trim();
  if (rawAmount){
    try { amount = checkAmount(rawAmount); }
    catch (e){ return answer(400, { ok: false, error: "invalid", field: "amount", message: e.message }, origin); }
  }

  if (!LIMITS.slipTypes.includes(slip.type)) return answer(400, { ok: false, error: "file-type" }, origin);
  if (slip.size > LIMITS.slipBytes) return answer(413, { ok: false, error: "file-size" }, origin);
  const bytes = new Uint8Array(await slip.arrayBuffer()), type = sniff(bytes);
  if (!type || !LIMITS.slipTypes.includes(type)) return answer(400, { ok: false, error: "file-type" }, origin);
  const filename = "slip." + TYPES[type];

  const payload = {
    content: "ตรวจสลิปกับแอปธนาคาร แล้วกด ✅ เพื่อขึ้นรายชื่อ" + (amount === null ? "\nไม่มียอด ตอบกลับโพสต์นี้ด้วยยอดเงิน" : ""),
    embeds: [{
      title: "สลิปใหม่",
      description: "ดูยอดและวันเวลาที่โอนจากสลิป",
      fields: [
        { name: "ชื่อ", value: escapeMd(d.name) },
        { name: "ข้อความ", value: d.msg ? escapeMd(d.msg) : "-" },
        { name: "ยอด", value: amount === null ? "-" : String(amount) },
      ],
      footer: { text: META_TAG + JSON.stringify({ v: 1, name: d.name, msg: d.msg, amount, date: new Date(Date.now() + 7 * 3600e3).toISOString().slice(0, 16) }) },   // Thailand time
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
