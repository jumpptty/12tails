// Cases for the Discord reader, the ☕ list and the /slip amount. Run through test.mjs, which passes in its helpers.
import assert from "node:assert";
import { listDonors, handleDonors } from "./src/donors_live.js";
import { readChannel } from "./src/discord.js";
import worker from "./src/index.js";

const SITE = "https://jumpptty.github.io";
const HOOK = "https://discord.test/api/webhooks/777/tok";
const OWNER = "42";
const meta = (o) => ({ embeds: [{ footer: { text: "meta " + JSON.stringify({ v: 1, name: "ก้อง", msg: "hi", amount: 50, date: "2026-11-13T10:00", ...o }) } }] });
const post = (id, o = {}, extra = {}) => ({ id, webhook_id: "777", reactions: [{ emoji: { name: "✅" }, count: 1 }], ...meta(o), ...extra });
const reply = (id, to, content, author = OWNER) => ({ id, content, author: { id: author }, message_reference: { message_id: to } });
const ctx = { webhookId: "777", ownerId: OWNER };

export function listCases({ setup, post: slipReq, payloadOf, json, handleSlip }){
  return {
    async "listDonors: only webhook posts with a ✅, no url or slip in the result"(){
      const msgs = [
        post("1", {}, { attachments: [{ url: "https://cdn/slip.jpg" }] }),
        post("2", {}, { reactions: [] }),
        post("3", {}, { webhook_id: "999" }),
        post("4", {}, { reactions: [{ emoji: { name: "❌" }, count: 1 }] }),
      ];
      assert.deepStrictEqual(listDonors(msgs, ctx), [{ k: "1", name: "ก้อง", msg: "hi", amount: 50, date: "2026-11-13T10:00" }]);
    },
    async "listDonors: latest valid owner reply sets the amount; junk, strangers and other posts are ignored"(){
      const msgs = [
        post("10", { amount: null }),
        reply("11", "10", "150 บาท"), reply("12", "10", "0"), reply("13", "10", "1,500"),
        reply("14", "10", "99", "7"),                      // not the owner
        reply("15", "10", "abc"),                          // later but invalid: the 1,500 stays
        reply("16", "99", "5"),                            // another post
      ];
      assert.deepStrictEqual(listDonors(msgs, ctx).map((d) => [d.k, d.amount]), [["10", 1500]]);
      const later = [...msgs, reply("17", "10", "2000")];
      assert.strictEqual(listDonors(later, ctx)[0].amount, 2000);
    },
    async "listDonors: a ✅'d post with amount null and no valid reply is skipped"(){
      assert.deepStrictEqual(listDonors([post("20", { amount: null }), reply("21", "20", "150 บาท")], ctx), []);
    },
    async "readChannel pages twice when the first page has 100 messages"(){
      const urls = [], page = (from, n) => Array.from({ length: n }, (_, i) => ({ id: String(from - i) }));
      const fetch = async (url, init) => { urls.push(url); assert.ok(init.headers.authorization === "Bot T" && init.headers["user-agent"]); return Response.json(urls.length === 1 ? page(500, 100) : page(400, 3)); };
      const all = await readChannel("T", "C1", fetch);
      assert.strictEqual(all.length, 103);
      assert.strictEqual(urls.length, 2);
      assert.ok(urls[0].endsWith("/channels/C1/messages?limit=100") && urls[1].endsWith("limit=100&before=401"), urls.join(" "));
      await assert.rejects(readChannel("T", "C1", async () => new Response("", { status: 500 })), /discord 500/);
    },
    async "GET /api/donors answers { donors }, 503 closed without secrets, 502 upstream on Discord 500"(){
      const env = { DISCORD_WEBHOOK_URL: HOOK, DISCORD_BOT_TOKEN: "T", SLIP_CHANNEL: "C1", OWNER_ID: OWNER };
      const req = (path = "/api/donors", origin = SITE) => new Request("https://worker.test" + path, { headers: { Origin: origin } });
      const ok = async () => Response.json([post("1"), post("2", {}, { reactions: [] })]);
      const good = await handleDonors(req(), env, { fetch: ok });
      assert.strictEqual(good.status, 200);
      assert.strictEqual(good.headers.get("Access-Control-Allow-Origin"), SITE);
      assert.strictEqual(good.headers.get("cache-control"), "public, max-age=60");
      assert.deepStrictEqual(await good.json(), { donors: [{ k: "1", name: "ก้อง", msg: "hi", amount: 50, date: "2026-11-13T10:00" }] });
      const closed = await handleDonors(req(), { DISCORD_WEBHOOK_URL: HOOK }, { fetch: ok });
      assert.strictEqual(closed.status, 503);
      assert.deepStrictEqual(await closed.json(), { ok: false, error: "closed" });
      const keep = console.error; console.error = () => {};
      let bad; try { bad = await handleDonors(req(), env, { fetch: async () => new Response("", { status: 500 }) }); } finally { console.error = keep; }
      assert.strictEqual(bad.status, 502);
      assert.deepStrictEqual(await bad.json(), { ok: false, error: "upstream" });
      assert.strictEqual((await handleDonors(req("/api/donors", "https://evil.example"), env, { fetch: ok })).status, 403);
      assert.strictEqual((await handleDonors(new Request("https://worker.test/api/donors", { method: "POST", headers: { Origin: SITE } }), env, { fetch: ok })).status, 405);
    },
    async "index routes: unknown path is a 404 JSON"(){
      const res = await worker.fetch(new Request("https://worker.test/nope"), {});
      assert.strictEqual(res.status, 404);
      assert.deepStrictEqual(await res.json(), { ok: false, error: "not-found" });
    },
    async "/slip with amount 50: the footer meta carries it, Thailand time, no อนุมัติ link"(){
      const s = setup(), res = await handleSlip(slipReq({ fields: { name: "ก้อง 🐱", msg: "ขอบคุณครับ", amount: "50" } }), s.env, s.deps);
      assert.strictEqual(res.status, 200);
      const p = payloadOf(s.calls[0]), footer = p.embeds[0].footer.text;
      assert.ok(footer.startsWith("meta "), footer);
      const m = JSON.parse(footer.slice(5));
      assert.deepStrictEqual(Object.keys(m), ["v", "name", "msg", "amount", "date"]);
      assert.deepStrictEqual([m.v, m.name, m.msg, m.amount], [1, "ก้อง 🐱", "ขอบคุณครับ", 50]);
      assert.ok(/^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}$/.test(m.date), m.date);
      const bkk = new Date(Date.now() + 7 * 3600e3).toISOString().slice(0, 16);
      assert.ok(Math.abs(Date.parse(m.date + "Z") - Date.parse(bkk + "Z")) <= 120e3, m.date + " vs " + bkk);
      assert.ok(!p.content.includes("อนุมัติ") && !p.content.includes("ไม่มียอด"), p.content);
    },
    async "/slip without amount: forwarded with amount null and 'ไม่มียอด'; a bad amount is 400 on field amount"(){
      const s = setup(), res = await handleSlip(slipReq(), s.env, s.deps);
      assert.strictEqual(res.status, 200);
      const p = payloadOf(s.calls[0]);
      assert.strictEqual(JSON.parse(p.embeds[0].footer.text.slice(5)).amount, null);
      assert.ok(p.content.includes("ไม่มียอด"), p.content);
      const blank = await handleSlip(slipReq({ fields: { name: "a", amount: "" } }), s.env, s.deps);
      assert.strictEqual(blank.status, 200);
      const bad = await handleSlip(slipReq({ fields: { name: "a", amount: "abc" } }), s.env, s.deps);
      const b = await json(bad);
      assert.strictEqual(bad.status, 400);
      assert.deepStrictEqual([b.error, b.field], ["invalid", "amount"]);
      assert.ok(b.message.includes("ยอดเงิน"), b.message);
      assert.strictEqual(s.calls.length, 2);
    },
  };
}
