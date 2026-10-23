// donate-worker test: node 12t_projects/donate-worker/test.mjs
// Drives handleSlip with a fake fetch (records the Discord call) and a fake rate limiter.
import assert from "node:assert";
import { handleSlip } from "./src/handler.js";
import donors from "../../scripts/donors.js";

const { fromFragment, LIMITS } = donors;
const SITE = "https://jumpptty.github.io";
const WEBHOOK = "https://discord.test/api/webhooks/1/token";
const now = new Date("2026-10-23T08:00:00Z");
const JPEG = [0xff, 0xd8, 0xff, 0xe0, 0, 0, 0, 0, 0, 0, 0, 0];
const good = { name: "ก้อง 🐱", msg: "ขอบคุณครับ", amount: "50", date: "2026-10-23T14:05" };

function limiter(allowed){
  const seen = {};
  return { limit: async ({ key }) => ({ success: (seen[key] = (seen[key] || 0) + 1) <= allowed }) };
}
function setup({ allowed = 100, discordStatus = 200 } = {}){
  const calls = [];
  // like workerd, the global fetch refuses any receiver but the global (called as deps.fetch() it would throw)
  const fetch = async function (url, init){ if (this !== undefined && this !== globalThis) throw new TypeError("Illegal invocation"); calls.push({ url: String(url), init }); return new Response("{}", { status: discordStatus }); };
  return { calls, env: { DISCORD_WEBHOOK_URL: WEBHOOK, SLIP_LIMIT: limiter(allowed) }, deps: { fetch, now: () => now } };
}
function slipFile(bytes = JPEG, type = "image/jpeg", size){
  const data = new Uint8Array(size || bytes.length);
  data.set(bytes.slice(0, data.length));
  return new File([data], "x", { type });
}
function post({ origin = SITE, fields = good, slip = slipFile(), drop = [], method = "POST" } = {}){
  const form = new FormData();
  for (const [k, v] of Object.entries(fields)) if (!drop.includes(k)) form.append(k, v);
  if (slip && !drop.includes("slip")) form.append("slip", slip);
  const headers = { "CF-Connecting-IP": "1.2.3.4" };
  if (origin) headers.Origin = origin;
  return new Request("https://worker.test/slip", { method, headers, body: form });
}
const json = async (res) => res.json();

const cases = {
  async "good send forwards one Discord post"(){
    const s = setup(), res = await handleSlip(post(), s.env, s.deps);
    assert.strictEqual(res.status, 200);
    assert.deepStrictEqual(await json(res), { ok: true });
    assert.strictEqual(res.headers.get("Access-Control-Allow-Origin"), SITE);
    assert.strictEqual(res.headers.get("Content-Type"), "application/json");
    assert.strictEqual(s.calls.length, 1);
    assert.strictEqual(s.calls[0].url, WEBHOOK + "?wait=true");
    const body = s.calls[0].init.body, payload = JSON.parse(body.get("payload_json"));
    assert.deepStrictEqual(payload.allowed_mentions, { parse: [] });
    const m = payload.content.match(/^\*\*\[อนุมัติ\]\(https:\/\/jumpptty\.github\.io\/12tails\/12t_projects\/guide-manager\/#(donor=[A-Za-z0-9_-]+)\)\*\*$/);
    assert.ok(m, payload.content);
    assert.deepStrictEqual(fromFragment(m[1]), { name: "ก้อง 🐱", msg: "ขอบคุณครับ", amount: 50, date: "2026-10-23T14:05" });
    assert.strictEqual(payload.embeds.length, 1);
    assert.strictEqual(payload.embeds[0].title, "สลิปใหม่");
    assert.deepStrictEqual(payload.embeds[0].fields.map((f) => f.name), ["ชื่อ", "ยอด", "วันเวลาที่โอน", "ข้อความ"]);
    assert.strictEqual(payload.embeds[0].image.url, "attachment://slip.jpg");
    const file = body.get("files[0]");
    assert.strictEqual(file.name, "slip.jpg");
    assert.deepStrictEqual([...new Uint8Array(await file.arrayBuffer())], JPEG);
  },
  async "other origin is refused"(){
    const s = setup(), res = await handleSlip(post({ origin: "https://evil.example" }), s.env, s.deps);
    assert.strictEqual(res.status, 403);
    assert.deepStrictEqual(await json(res), { ok: false, error: "origin" });
    assert.strictEqual(s.calls.length, 0);
    const none = await handleSlip(post({ origin: "" }), s.env, s.deps);
    assert.strictEqual(none.status, 403);
    const local = await handleSlip(post({ origin: "null" }), s.env, s.deps);
    assert.strictEqual(local.status, 200);
    assert.strictEqual(local.headers.get("Access-Control-Allow-Origin"), "null");
  },
  async "missing slip"(){
    const s = setup(), res = await handleSlip(post({ drop: ["slip"] }), s.env, s.deps);
    assert.strictEqual(res.status, 400);
    assert.deepStrictEqual(await json(res), { ok: false, error: "missing" });
    assert.strictEqual(s.calls.length, 0);
  },
  async "name of 41 characters"(){
    const s = setup(), res = await handleSlip(post({ fields: { ...good, name: "ก".repeat(41) } }), s.env, s.deps);
    const b = await json(res);
    assert.strictEqual(res.status, 400);
    assert.deepStrictEqual([b.ok, b.error, b.field], [false, "invalid", "name"]);
    assert.ok(b.message.includes("40"));
    assert.strictEqual(s.calls.length, 0);
  },
  async "amount abc"(){
    const s = setup(), res = await handleSlip(post({ fields: { ...good, amount: "abc" } }), s.env, s.deps);
    const b = await json(res);
    assert.deepStrictEqual([b.ok, b.error, b.field], [false, "invalid", "amount"]);
    assert.ok(b.message.includes("ยอดเงิน"));
    const empty = await json(await handleSlip(post({ fields: { ...good, amount: "" } }), s.env, s.deps));
    assert.strictEqual(empty.error, "missing");
    const date = await json(await handleSlip(post({ fields: { ...good, date: "2019-01-01T00:00" } }), s.env, s.deps));
    assert.deepStrictEqual([date.error, date.field], ["invalid", "date"]);
    const msg = await json(await handleSlip(post({ fields: { ...good, msg: "ก".repeat(201) } }), s.env, s.deps));
    assert.deepStrictEqual([msg.error, msg.field], ["invalid", "msg"]);
    assert.strictEqual(s.calls.length, 0);
  },
  async "pdf slip"(){
    const s = setup(), pdf = slipFile([0x25, 0x50, 0x44, 0x46], "application/pdf");
    const res = await handleSlip(post({ slip: pdf }), s.env, s.deps);
    assert.deepStrictEqual(await json(res), { ok: false, error: "file-type" });
    // a lying content type with non-image bytes is refused too
    const liar = await handleSlip(post({ slip: slipFile([0x25, 0x50, 0x44, 0x46], "image/jpeg") }), s.env, s.deps);
    assert.deepStrictEqual(await json(liar), { ok: false, error: "file-type" });
    assert.strictEqual(s.calls.length, 0);
  },
  async "5 MB + 1 byte"(){
    const s = setup(), big = slipFile(JPEG, "image/jpeg", LIMITS.slipBytes + 1);
    const res = await handleSlip(post({ slip: big }), s.env, s.deps);
    assert.strictEqual(res.status, 413);
    assert.deepStrictEqual(await json(res), { ok: false, error: "file-size" });
    const edge = await handleSlip(post({ slip: slipFile(JPEG, "image/jpeg", LIMITS.slipBytes) }), s.env, s.deps);
    assert.strictEqual(edge.status, 200);
  },
  async "third send within a minute is refused with rate"(){
    const s = setup({ allowed: 2 });
    assert.strictEqual((await handleSlip(post(), s.env, s.deps)).status, 200);
    assert.strictEqual((await handleSlip(post(), s.env, s.deps)).status, 200);
    const third = await handleSlip(post(), s.env, s.deps);
    assert.strictEqual(third.status, 429);
    assert.deepStrictEqual(await json(third), { ok: false, error: "rate" });
    assert.strictEqual(s.calls.length, 2);
  },
  async "@everyone and a markdown link in the message stay inert"(){
    const s = setup(), msg = "@everyone [click](https://evil.example) **bold** <@123> `x`";
    const res = await handleSlip(post({ fields: { ...good, msg } }), s.env, s.deps);
    assert.strictEqual(res.status, 200);
    const payload = JSON.parse(s.calls[0].init.body.get("payload_json")), v = payload.embeds[0].fields.find((f) => f.name === "ข้อความ").value;
    assert.deepStrictEqual(payload.allowed_mentions, { parse: [] });
    assert.ok(!v.includes("@everyone"), v);
    assert.ok(v.includes("\\[click\\]\\(https://evil.example\\)"), v);
    assert.ok(v.includes("\\*\\*bold\\*\\*"), v);
    assert.ok(v.includes("\\<@\u200b123\\>"), v);
    assert.ok(payload.embeds[0].fields.every((f) => f.value.length > 0 && f.value.length <= 1024));
    // worst case: 200 characters that all need escaping stay under the embed limit
    await handleSlip(post({ fields: { ...good, msg: "*".repeat(200) } }), s.env, s.deps);
    const long = JSON.parse(s.calls[1].init.body.get("payload_json")).embeds[0].fields[3].value;
    assert.ok(long.length <= 1024);
  },
  async "Discord 500"(){
    const s = setup({ discordStatus: 500 }), logged = [], keep = console.error;
    console.error = (m) => logged.push(String(m));
    let res;
    try { res = await handleSlip(post(), s.env, s.deps); } finally { console.error = keep; }
    assert.ok(logged.length === 1 && logged[0].includes("500") && !logged[0].includes(WEBHOOK), logged.join("|"));
    assert.strictEqual(res.status, 502);
    assert.deepStrictEqual(await json(res), { ok: false, error: "discord" });
    assert.strictEqual(s.calls.length, 1);
  },
};

let n = 0, failed = 0;
for (const [name, fn] of Object.entries(cases)){
  try { await fn(); n++; console.log("  ok   " + name); }
  catch (e){ failed++; console.log("  FAIL " + name + "\n       " + String(e && e.message || e).split("\n").join("\n       ")); }
}
if (failed){ console.log("donate-worker test: " + failed + " failed"); process.exit(1); }
console.log("donate-worker test: all checks passed (" + n + ")");
