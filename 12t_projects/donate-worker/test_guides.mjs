// Cases for the class guide routes (POST /guide, GET /api/guides, GET /g/...). Run through test.mjs.
import assert from "node:assert";
import { createRequire } from "node:module";
import { listGuides, handleGuidePost, handleGuides, handlePreview, previewLink } from "./src/guides.js";
import worker from "./src/index.js";

const { encode } = createRequire(import.meta.url)("../../scripts/guide_code.js");
const SITE = "https://jumpptty.github.io";
const HOOK = "https://discord.test/api/webhooks/777/tok";
const guideObj = (o = {}) => ({ format: "12t-class-guide", version: 1, title: "ไกด์ **หมาป่า**", author: "ผู้เขียน", description: "d", build: { server: "tot", classKey: "wolf", level: 100, learned: [101, 102] }, ...o });
const CODE = encode(guideObj());
const meta = (o) => ({ embeds: [{ footer: { text: "meta " + JSON.stringify({ v: 1, code: CODE, replaces: null, num: null, ...o }) } }] });
const OK = [{ emoji: { name: "✅" }, count: 1 }];
const gp = (id, o = {}, extra = {}) => ({ id, webhook_id: "777", reactions: OK, ...meta(o), ...extra });
let seed = 7;   // deterministic Thai noise that deflate cannot shrink, so the TG3 code outgrows a footer
const noise = (n) => Array.from({ length: n }, () => String.fromCharCode(0x0e01 + (seed = (seed * 1103515245 + 12345) % 2147483648) % 80)).join("");
const LONG = encode(guideObj({ description: noise(12000) }));
const ctx = { webhookId: "777", floor: 106 };
const nums = (r) => r.guides.map((g) => [g.msg, g.num]);

function limiter(allowed){
  const seen = {};
  return { limit: async ({ key }) => ({ success: (seen[key] = (seen[key] || 0) + 1) <= allowed }) };
}
// fake Discord: webhook POST -> id 500, PATCH -> ok, channel read -> `channel`, message read -> `byId`
function discord({ channel = [], byId = {}, files = {} } = {}){
  const calls = [];
  const fetch = async function (url, init = {}){
    if (this !== undefined && this !== globalThis) throw new TypeError("Illegal invocation");
    url = String(url); calls.push({ url, init });
    if (init.method === "POST") return Response.json({ id: "500", attachments: [{ id: "9" }] });
    if (init.method === "PATCH") return Response.json({});
    if (files[url]) return new Response(files[url]);
    const one = url.match(/\/messages\/(\d+)$/);
    if (one) return byId[one[1]] ? Response.json(byId[one[1]]) : new Response("", { status: 404 });
    return Response.json(channel);
  };
  return { calls, fetch, patches: () => calls.filter((c) => c.init.method === "PATCH") };
}
const envOf = (o = {}) => ({ DISCORD_GUIDE_WEBHOOK_URL: HOOK, DISCORD_BOT_TOKEN: "T", GUIDE_CHANNEL: "G1", GUIDE_NUM_FLOOR: "106", SLIP_LIMIT: limiter(100), ...o });
const form = (fields, origin = SITE, ip = "1.2.3.4") => new Request("https://worker.test/guide", { method: "POST", headers: { Origin: origin, "CF-Connecting-IP": ip }, body: new URLSearchParams(fields) });
const quiet = async (f) => { const keep = console.error; console.error = () => {}; try { return await f(); } finally { console.error = keep; } };
const payload = (call) => JSON.parse(call.init.body.get ? call.init.body.get("payload_json") : call.init.body);

export const guideCases = {
  async "listGuides: floor 106, two new ✅'d posts get 107 and 108, oldest first; no code in the result"(){
    const r = listGuides([gp("30"), gp("20"), gp("10", {}, { reactions: [] })], ctx);
    assert.deepStrictEqual(nums(r), [["20", 107], ["30", 108]]);
    assert.deepStrictEqual(r.assign.map((a) => [a.msg.id, a.num]), [["20", 107], ["30", 108]]);
    const g = r.guides[0];
    assert.deepStrictEqual([g.num, g.guide.id, g.guide.title, g.guide.build.classKey], [107, 107, "ไกด์ **หมาป่า**", "wolf"]);
    assert.ok(!JSON.stringify(r.guides).includes(CODE));
  },
  async "listGuides: published and the Bangkok day come from the message timestamp"(){
    const g = listGuides([gp("20", {}, { timestamp: "2026-11-13T20:30:00.123000+00:00" })], ctx).guides[0].guide;
    assert.deepStrictEqual([g.published, g.date], ["2026-11-13T20:30:00Z", "2026-11-14"]);
  },
  async "listGuides: a footer num is kept, also after the ✅ was removed and re-added"(){
    const r = listGuides([gp("20", { num: 110 }), gp("30")], ctx);
    assert.deepStrictEqual(nums(r), [["20", 110], ["30", 111]]);
    assert.deepStrictEqual(r.assign.map((a) => a.num), [111]);
    const off = listGuides([gp("20", { num: 110 }, { reactions: [] }), gp("30", { num: 111 })], ctx);   // ✅ off: gone, number stays taken
    assert.deepStrictEqual(nums(off), [["30", 111]]);
    assert.deepStrictEqual(nums(listGuides([gp("20", { num: 110 }), gp("30", { num: 111 }), gp("40")], ctx)).pop(), ["40", 112]);
  },
  async "listGuides: replaces N takes number N and the newer post of two wins"(){
    const r = listGuides([gp("20", { replaces: 50 }), gp("30", { replaces: 50 })], ctx);
    assert.deepStrictEqual(nums(r), [["30", 50]]);
    assert.deepStrictEqual(r.assign, []);
  },
  async "listGuides: replaces 150 lifts the next new number to 151"(){
    const r = listGuides([gp("20", { replaces: 150 }), gp("30")], ctx);
    assert.deepStrictEqual(nums(r), [["20", 150], ["30", 151]]);
  },
  async "listGuides: broken meta or a code that does not decode is skipped without throwing, its num still counts"(){
    const broken = { id: "20", webhook_id: "777", reactions: OK, embeds: [{ footer: { text: 'meta {"v":1,"num":200,' } }] };
    const junk = gp("25", { code: "not a code" });
    assert.deepStrictEqual(nums(listGuides([broken, junk, gp("30")], ctx)), [["30", 201]]);
  },
  async "listGuides: a replaces 150 post whose ✅ is off still lifts the next number to 151, so a re-✅ never collides"(){
    const off = gp("20", { replaces: 150 }, { reactions: [] });
    assert.deepStrictEqual(nums(listGuides([off, gp("30")], ctx)), [["30", 151]]);
    assert.deepStrictEqual(nums(listGuides([gp("20", { replaces: 150 }), gp("30", { num: 151 })], ctx)), [["20", 150], ["30", 151]]);
  },
  async "listGuides: a @file post takes its code from the codes map"(){
    const m = gp("20", { code: "@file" });
    assert.deepStrictEqual(listGuides([m], ctx).guides, []);
    assert.deepStrictEqual(nums(listGuides([m], { ...ctx, codes: { 20: CODE } })), [["20", 107]]);
  },
  async "POST /guide: a good code makes one webhook post and one PATCH with the /g/ link and the guide summary"(){
    const d = discord(), env = envOf();
    const res = await handleGuidePost(form({ code: CODE, replaces: "" }), env, { fetch: d.fetch });
    assert.strictEqual(res.status, 200);
    assert.deepStrictEqual(await res.json(), { ok: true });
    assert.strictEqual(d.calls.length, 2);
    assert.strictEqual(d.calls[0].url, HOOK + "?wait=true");
    const first = payload(d.calls[0]);
    assert.deepStrictEqual(first.allowed_mentions, { parse: [] });
    const m = JSON.parse(first.embeds[0].footer.text.slice(5));
    assert.deepStrictEqual([m.v, m.code, m.replaces, m.num], [1, CODE, null, null]);
    assert.ok(first.embeds[0].title.includes("หมาป่า") && !first.embeds[0].title.includes("**"), first.embeds[0].title);
    const p = d.patches()[0], body = JSON.parse(p.init.body);
    assert.strictEqual(p.url, "https://discord.com/api/v10/webhooks/777/tok/messages/500");
    assert.strictEqual(body.content.match(/https:\/\/worker\.test\/g\/500\.[0-9a-f]{16}/)[0], await previewLink(env, "500", "https://worker.test"));
    assert.ok(body.content.includes("ดูตัวอย่าง"), body.content);
    assert.deepStrictEqual(body.embeds[0].footer, first.embeds[0].footer);
    assert.deepStrictEqual(body.allowed_mentions, { parse: [] });
  },
  async "POST /guide: the local guide manager (http://127.0.0.1:4782, ส่งเข้า Discord) is an accepted origin"(){
    const d = discord(), res = await handleGuidePost(form({ code: CODE, replaces: "" }, "http://127.0.0.1:4782"), envOf(), { fetch: d.fetch });
    assert.strictEqual(res.status, 200);
    assert.strictEqual(res.headers.get("Access-Control-Allow-Origin"), "http://127.0.0.1:4782");
  },
  async "POST /guide: replaces N shows 'แทนที่ #N' with a link to #class-guide/N"(){
    const d = discord();
    await handleGuidePost(form({ code: CODE, replaces: "12" }), envOf(), { fetch: d.fetch });
    const e = JSON.parse(d.patches()[0].init.body).embeds[0], text = JSON.stringify(e);
    assert.ok(text.includes("แทนที่ #12") && text.includes("#class-guide/12"), text);
    assert.strictEqual(JSON.parse(e.footer.text.slice(5)).replaces, 12);
  },
  async "POST /guide: a code too long for the footer goes in guide.txt as @file and the PATCH keeps the attachment"(){
    const d = discord(), long = LONG;
    const res = await handleGuidePost(form({ code: long }), envOf(), { fetch: d.fetch });
    assert.strictEqual(res.status, 200);
    const body = d.calls[0].init.body, first = payload(d.calls[0]);
    assert.strictEqual(JSON.parse(first.embeds[0].footer.text.slice(5)).code, "@file");
    assert.ok(first.embeds[0].footer.text.length <= 2048);
    assert.strictEqual(body.get("files[0]").name, "guide.txt");
    assert.strictEqual(await body.get("files[0]").text(), long);
    assert.deepStrictEqual(JSON.parse(d.patches()[0].init.body).attachments, [{ id: "9" }]);
  },
  async "POST /guide: garbage, an unknown class or server, no title or author, a bad replaces are 400 invalid; origin 403; no secret 503; Discord 500 502"(){
    const d = discord(), env = envOf();
    for (const fields of [
      { code: "garbage" }, { code: JSON.stringify(guideObj()) }, { code: "12TG1." + CODE }, { code: "" }, {},
      { code: JSON.stringify(guideObj({ build: { server: "tot", classKey: "dragon", level: 1, learned: [] } })) },
      { code: JSON.stringify(guideObj({ build: { server: "x", classKey: "wolf", level: 1, learned: [] } })) },
      { code: JSON.stringify(guideObj({ title: "" })) }, { code: JSON.stringify(guideObj({ author: " " })) },
      { code: CODE, replaces: "0" }, { code: CODE, replaces: "-3" }, { code: CODE, replaces: "1.5" }, { code: CODE, replaces: "abc" },
    ]){
      const r = await handleGuidePost(form(fields), env, { fetch: d.fetch }), b = await r.json();
      assert.deepStrictEqual([r.status, b.error, typeof b.message], [400, "invalid", "string"], JSON.stringify(fields));
    }
    assert.strictEqual(d.calls.length, 0);
    assert.strictEqual((await handleGuidePost(form({ code: CODE }, "https://evil.example"), env, { fetch: d.fetch })).status, 403);
    const closed = await handleGuidePost(form({ code: CODE }), envOf({ DISCORD_GUIDE_WEBHOOK_URL: "" }), { fetch: d.fetch });
    assert.deepStrictEqual([closed.status, (await closed.json()).error], [503, "closed"]);
    const down = await quiet(() => handleGuidePost(form({ code: CODE }), env, { fetch: async () => new Response("", { status: 500 }) }));
    assert.deepStrictEqual([down.status, (await down.json()).error], [502, "upstream"]);
  },
  async "POST /guide: 3 sends from one IP with limit 2 -> 429; OPTIONS preflight is 204"(){
    const d = discord(), env = envOf({ SLIP_LIMIT: limiter(2) }), st = [];
    for (let i = 0; i < 3; i++) st.push((await handleGuidePost(form({ code: CODE }), env, { fetch: d.fetch })).status);
    assert.deepStrictEqual(st, [200, 200, 429]);
    const pre = await worker.fetch(new Request("https://worker.test/guide", { method: "OPTIONS", headers: { Origin: SITE } }), env);
    assert.strictEqual(pre.status, 204);
  },
  async "GET /api/guides: PATCHes only the unnumbered ✅'d posts, none on the warm second call; { floor, guides }"(){
    const d = discord({ channel: [gp("20", { num: 110 }), gp("30"), gp("10", {}, { reactions: [] })] }), env = envOf({ GUIDE_CHANNEL: "G2" });
    const req = () => new Request("https://worker.test/api/guides", { headers: { Origin: SITE } });
    const res = await handleGuides(req(), env, { fetch: d.fetch }), out = await res.json();
    assert.strictEqual(res.status, 200);
    assert.strictEqual(out.floor, 106);
    assert.deepStrictEqual(out.guides.map((g) => [g.msg, g.num]), [["20", 110], ["30", 111]]);
    assert.strictEqual(d.patches().length, 1);
    const p = d.patches()[0], body = JSON.parse(p.init.body);
    assert.ok(p.url.endsWith("/messages/30"), p.url);
    assert.strictEqual(JSON.parse(body.embeds[0].footer.text.slice(5)).num, 111);
    assert.ok(body.content.includes("#111 · อย่าลบโพสต์นี้ ถ้าจะเอาออกให้เอา ✅ ออก") && body.content.includes("/g/30."), body.content);
    const again = await handleGuides(req(), env, { fetch: d.fetch });
    assert.strictEqual(again.headers.get("x-list-cache"), "hit");
    assert.strictEqual(d.patches().length, 1);
  },
  async "GET /api/guides: a failed numbering PATCH keeps that guide out of the answer; the next build numbers it again"(){
    const channel = [gp("20"), gp("30")], d = discord({ channel }), env = envOf({ GUIDE_CHANNEL: "G5" });
    let n = 0;
    const flaky = async (url, init = {}) => init.method === "PATCH" && ++n === 1 ? new Response("", { status: 500 }) : (0, d.fetch)(url, init);
    const req = () => new Request("https://worker.test/api/guides", { headers: { Origin: SITE } });
    const first = await quiet(async () => (await handleGuides(req(), env, { fetch: flaky })).json());
    assert.deepStrictEqual(first.guides.map((g) => [g.msg, g.num]), [["30", 108]]);
    const later = envOf({ GUIDE_CHANNEL: "G5b" });   // fresh cache
    const second = await (await handleGuides(req(), later, { fetch: flaky })).json();
    assert.deepStrictEqual(second.guides.map((g) => [g.msg, g.num]), [["20", 107], ["30", 108]]);
  },
  async "GET /api/guides: a @file post is read from its guide.txt attachment; 503 without a channel; 502 on Discord 500"(){
    const url = "https://cdn.test/guide.txt";
    const d = discord({ channel: [gp("20", { code: "@file" }, { attachments: [{ id: "9", url }] })], files: { [url]: CODE } });
    const req = () => new Request("https://worker.test/api/guides", { headers: { Origin: SITE } });
    const res = await handleGuides(req(), envOf({ GUIDE_CHANNEL: "G3" }), { fetch: d.fetch });
    assert.deepStrictEqual((await res.json()).guides.map((g) => g.num), [107]);
    assert.deepStrictEqual(JSON.parse(d.patches()[0].init.body).attachments, [{ id: "9" }]);
    assert.strictEqual((await handleGuides(req(), envOf({ GUIDE_CHANNEL: "" }), { fetch: d.fetch })).status, 503);
    const bad = await quiet(() => handleGuides(req(), envOf({ GUIDE_CHANNEL: "G4" }), { fetch: async () => new Response("", { status: 500 }) }));
    assert.strictEqual(bad.status, 502);
  },
  async "GET /g/<id>.<sig>: a wrong sig is 404; the right one is 200 HTML that redirects to #class-guide/code/"(){
    const d = discord({ byId: { 500: gp("500") } }), env = envOf();
    const sig = (await previewLink(env, "500", "https://worker.test")).split(".").pop();
    const get = (path) => handlePreview(new Request("https://worker.test" + path), env, { fetch: d.fetch });
    assert.strictEqual((await get("/g/500.0000000000000000")).status, 404);
    assert.strictEqual((await get("/g/501." + sig)).status, 404);
    assert.strictEqual(d.calls.length, 0);
    const res = await get("/g/500." + sig);
    assert.strictEqual(res.status, 200);
    assert.strictEqual(res.headers.get("Content-Type"), "text/html; charset=utf-8");
    const html = await res.text();
    assert.ok(html.includes('name="robots" content="noindex"') && html.includes("#class-guide/code/"), html);
    assert.ok(html.includes(JSON.stringify(SITE + "/12tails/12t_projects/bible/#class-guide/code/" + encodeURIComponent(CODE))), html);
    const routed = await worker.fetch(new Request("https://worker.test/g/500.0000000000000000"), env);
    assert.strictEqual(routed.status, 404);
  },
};
