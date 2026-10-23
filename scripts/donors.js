#!/usr/bin/env node
/* donors.js - the shared donation rules for the Bible's donor list (the coffee pop-up).
 *
 * One source for the limits and the pure helpers. The Cloudflare Worker bundles it, scripts/add_guide.js
 * uses it, and the validator checks the browser copies against it. So it stays pure: no fs, no Node-only
 * modules, only globals present in Node 24, Workers and browsers (crypto, TextEncoder, btoa, atob).
 *
 *   node scripts/donors.js --selftest
 *
 * Dates are Thailand time (UTC+7) written YYYY-MM-DDTHH:MM.
 */
"use strict";

const LIMITS = { name: 40, msg: 200, amountMax: 1000000, slipBytes: 5242880, slipTypes: ["image/jpeg", "image/png", "image/webp"], dateMin: "2020-01-01T00:00" };

const clean = (s) => String(s).replace(/\s+/g, " ").trim();
const len = (s) => [...s].length;   // code points, so an emoji counts once
const satang = (n) => Math.round(n * 100);
// "YYYY-MM-DDTHH:MM" read as Thailand time (UTC+7) -> epoch ms, or NaN when it is not a real date
function thaiMs(s){
  const m = typeof s === "string" && s.match(/^(\d{4})-(\d\d)-(\d\d)T(\d\d):(\d\d)$/);
  if (!m) return NaN;
  const [y, mo, d, h, mi] = m.slice(1).map(Number), t = new Date(Date.UTC(y, mo - 1, d, h, mi));
  const same = t.getUTCFullYear() === y && t.getUTCMonth() === mo - 1 && t.getUTCDate() === d && t.getUTCHours() === h && t.getUTCMinutes() === mi;
  return same ? t.getTime() - 7 * 3600000 : NaN;
}

function checkDonation(d, now = new Date()){
  d = d || {};
  const name = typeof d.name === "string" ? clean(d.name) : "", msg = typeof d.msg === "string" ? clean(d.msg) : (d.msg == null ? "" : null);
  if (!name) throw new Error("กรุณาใส่ชื่อ");
  if (len(name) > LIMITS.name) throw new Error("ชื่อยาวเกิน " + LIMITS.name + " ตัวอักษร");
  if (msg === null) throw new Error("ข้อความไม่ถูกต้อง");
  if (len(msg) > LIMITS.msg) throw new Error("ข้อความยาวเกิน " + LIMITS.msg + " ตัวอักษร");
  const a = d.amount;
  if (typeof a !== "number" || !isFinite(a) || a <= 0 || a > LIMITS.amountMax || Math.abs(a * 100 - satang(a)) > 1e-6)
    throw new Error("ยอดเงินต้องมากกว่า 0 และไม่เกิน " + LIMITS.amountMax.toLocaleString("en-US") + " บาท (ทศนิยมไม่เกิน 2 ตำแหน่ง)");
  const t = thaiMs(d.date);
  if (isNaN(t)) throw new Error("วันเวลาที่โอนไม่ถูกต้อง (รูปแบบ YYYY-MM-DDTHH:MM)");
  if (t < thaiMs(LIMITS.dateMin) || t > now.getTime() + 24 * 3600000) throw new Error("วันเวลาที่โอนอยู่นอกช่วงที่รับ (ตั้งแต่ 2020-01-01 ถึงไม่เกินพรุ่งนี้)");
  return { name, msg, amount: satang(a) / 100, date: d.date };
}

function newKey(){
  const b = new Uint8Array(4);
  globalThis.crypto.getRandomValues(b);
  return Array.from(b, (x) => x.toString(16).padStart(2, "0")).join("");
}

const donorLine = (x) => "  " + JSON.stringify({ k: x.k, id: x.id, name: x.name, msg: x.msg, amount: x.amount, date: x.date }).replace(/</g, "\\u003c") + ",";   // no "</script>" or "<!--" inside the page script

function parseDonors(html){
  const eol = html.includes("\r\n") ? "\r\n" : "\n";
  const open = "const DONORS = [" + eol, start = html.indexOf(open), from = start + open.length;
  const end = start < 0 ? -1 : html.indexOf(eol + "];", from - eol.length);   // from - eol: an empty block closes right after the opening eol
  if (end < 0) throw new Error("DONORS was not found");
  const inner = html.slice(from, Math.max(end, from)), lines = inner === "" ? [] : inner.split(eol), donations = [];
  lines.forEach((l, at) => { const t = l.trim(); if (t.startsWith("{")) donations.push({ at, x: JSON.parse(t.replace(/,$/, "")) }); });
  return { eol, head: html.slice(0, from), tail: html.slice(end < from ? from : end), lines, donations };
}

function groupDonors(donations){
  const by = new Map();
  donations.forEach((x) => {
    let r = by.get(x.id);
    if (!r) by.set(x.id, r = { id: x.id, name: x.name, msg: "", sat: 0, count: 0, date: x.date, first: x.date, msgDate: "" });
    r.sat += satang(x.amount); r.count++;
    if (x.date >= r.date){ r.date = x.date; r.name = x.name; }
    if (x.date < r.first) r.first = x.date;
    if (x.msg && x.date >= r.msgDate){ r.msgDate = x.date; r.msg = x.msg; }
  });
  return [...by.values()].sort((a, b) => b.sat - a.sat || (a.first < b.first ? -1 : a.first > b.first ? 1 : 0))
    .map((r) => ({ id: r.id, name: r.name, msg: r.msg, total: r.sat / 100, count: r.count, date: r.date, first: r.first }));
}

const donorFragment = (d) => {
  const bytes = new TextEncoder().encode(JSON.stringify({ name: d.name, msg: d.msg, amount: d.amount, date: d.date }));
  let bin = ""; bytes.forEach((b) => { bin += String.fromCharCode(b); });
  return "donor=" + btoa(bin).replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
};
function fromFragment(hash){
  const m = String(hash || "").replace(/^#/, "").match(/^donor=([A-Za-z0-9_-]+)$/);
  if (!m) return null;
  try {
    let b = m[1].replace(/-/g, "+").replace(/_/g, "/"); while (b.length % 4) b += "=";
    const bin = atob(b), d = JSON.parse(new TextDecoder("utf-8", { fatal: true }).decode(Uint8Array.from(bin, (c) => c.charCodeAt(0))));
    return d && typeof d === "object" && !Array.isArray(d) ? d : null;
  } catch (e){ return null; }
}

function selftest(){
  const assert = require("assert");
  const { LIMITS, checkDonation, newKey, donorLine, parseDonors, groupDonors, donorFragment, fromFragment } = module.exports;
  const now = new Date("2026-10-23T08:00:00Z");
  const base = { name: "A", msg: "", amount: 50, date: "2026-10-23T14:05" };
  const ok = (d) => checkDonation({ ...base, ...d }, now);
  const bad = (d, re) => assert.throws(() => ok(d), re || /./);
  const cases = {
    "checkDonation counts code points and collapses whitespace"(){
      assert.strictEqual(ok({ name: "  ก้อง\n 🐱 " }).name, "ก้อง 🐱");
      assert.strictEqual(ok({ name: "🐱".repeat(40) }).name.length, 80);
      bad({ name: "🐱".repeat(41) }, /40/);
      bad({ name: " \n " }, /ชื่อ/);
      assert.strictEqual([...ok({ msg: "ก".repeat(200) }).msg].length, 200);
      bad({ msg: "ก".repeat(201) }, /200/);
      assert.strictEqual(ok({ msg: "a\r\n\r\n b" }).msg, "a b");
    },
    "checkDonation amount"(){
      [50, 0.5, 1000000].forEach((a) => assert.strictEqual(ok({ amount: a }).amount, a));
      [0, -1, 1.234, 1000000.01, "50", NaN, Infinity].forEach((a) => bad({ amount: a }, /ยอดเงิน/));
    },
    "checkDonation date"(){
      assert.strictEqual(ok({}).date, "2026-10-23T14:05");
      ["2026-10-25T00:00", "2019-12-31T23:59", "2026-02-30T10:00", "2026-10-23 14:05", 5].forEach((t) => bad({ date: t }, /วันเวลาที่โอน/));
      assert.strictEqual(ok({ date: "2020-01-01T00:00" }).date, "2020-01-01T00:00");
    },
    'donorLine escapes "<"'(){
      const l = donorLine({ k: "ab12cd34", id: "i", name: "</script>", msg: "", amount: 1, date: "2026-10-23T14:05" });
      assert.ok(l.includes("\\u003c/script>") && !l.includes("</script>"));
      assert.ok(l.startsWith('  {"k":"ab12cd34","id":"i","name":') && l.endsWith("},"));
    },
    "parseDonors reads CRLF and LF blocks"(){
      const x = { k: "k1", id: "i", name: "n", msg: "", amount: 5, date: "2026-10-23T14:05" };
      ["\r\n", "\n"].forEach((eol) => {
        const html = "a" + eol + "const DONORS = [" + eol + donorLine(x) + eol + "];" + eol + "z";
        const p = parseDonors(html);
        assert.strictEqual(p.eol, eol);
        assert.deepStrictEqual(p.donations, [{ at: 0, x }]);
        assert.strictEqual(p.head + p.lines.join(eol) + p.tail, html);
        assert.strictEqual(parseDonors("const DONORS = [" + eol + "];").lines.length, 0);
      });
      assert.throws(() => parseDonors("nothing"), /DONORS was not found/);
    },
    "groupDonors merges by id and sorts"(){
      const d = (id, name, msg, amount, date) => ({ k: id + date, id, name, msg, amount, date });
      const g = groupDonors([d("A", "old", "hi", 100, "2026-10-02T10:00"), d("B", "bee", "", 150, "2026-10-01T10:00"), d("A", "new", "", 50, "2026-10-05T10:00")]);
      assert.deepStrictEqual(g.map((r) => r.id), ["B", "A"]);
      assert.deepStrictEqual(g[1], { id: "A", name: "new", msg: "hi", total: 150, count: 2, date: "2026-10-05T10:00", first: "2026-10-02T10:00" });
      assert.strictEqual(groupDonors([d("C", "c", "", 0.1, "2026-10-01T00:00"), d("C", "c", "", 0.2, "2026-10-02T00:00")])[0].total, 0.3);
    },
    "fragment round trip"(){
      const d = { name: "ก้อง 🐱 &#=", msg: "ขอบคุณ ?x=1&y=2 #", amount: 12.5, date: "2026-10-23T14:05" };
      const f = donorFragment(d);
      assert.ok(/^donor=[A-Za-z0-9_-]+$/.test(f));
      assert.deepStrictEqual(fromFragment("#" + f), d);
      assert.deepStrictEqual(fromFragment(f), d);
      assert.strictEqual(fromFragment("#donor=@@@"), null);
      assert.strictEqual(fromFragment("#x=1"), null);
      assert.strictEqual(fromFragment(""), null);
    },
    "newKey"(){
      const s = new Set();
      for (let i = 0; i < 1000; i++){ const k = newKey(); assert.ok(/^[0-9a-f]{8}$/.test(k)); s.add(k); }
      assert.strictEqual(s.size, 1000);
      assert.strictEqual(LIMITS.name, 40);
    },
  };
  let n = 0, failed = 0;
  for (const [name, fn] of Object.entries(cases)){
    try { fn(); n++; console.log("  ok   " + name); }
    catch (e){ failed++; console.log("  FAIL " + name + "\n       " + String(e && e.message || e).split("\n").join("\n       ")); }
  }
  if (failed){ console.log("donors selftest: " + failed + " failed"); process.exit(1); }
  console.log("donors selftest: all checks passed (" + n + ")");
}

module.exports = { LIMITS, checkDonation, newKey, donorLine, parseDonors, groupDonors, donorFragment, fromFragment };
if (require.main === module && process.argv.includes("--selftest")) selftest();
