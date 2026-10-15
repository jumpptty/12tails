#!/usr/bin/env node
// Class guide short codes (12t_projects/bible, ไกด์แต่ละอาชีพ): "12TG1." + a compact form of the guide (one-letter keys, learned skills as a
// 160-bit set) as JSON, compressed with deflate-raw, URL-safe base64.
// The page makes them (classGuidePack) and reads them (classGuideUnpack); this decodes one outside the browser, to embed a submitted guide
// in CLASS_GUIDES as a JSON object (12t_projects/bible/CLASS-GUIDES.md).
//
//   node scripts/guide_code.js decode <code | file>     print the guide JSON (pretty)
//   node scripts/guide_code.js encode <json file>       print the short code
//   node scripts/guide_code.js --selftest
"use strict";
const fs = require("fs");
const zlib = require("zlib");

const PREFIX = "12TG1.";
// Same compact form as classGuideCompact / classGuideExpand in index.html: one-letter keys, learned skills as a 160-bit set (one bit per tree x row x column slot).
const b64u = buf => Buffer.from(buf).toString("base64").replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
const fromB64u = str => Buffer.from(str.replace(/-/g, "+").replace(/_/g, "/"), "base64");
const slot = id => (Math.floor(id / 100) - 1) * 40 + Math.floor(id / 10) % 10 * 4 + (id % 10 - 1);
function compact(g){
  const bits = Buffer.alloc(20);
  for (const id of g.build.learned){ const k = slot(id); bits[k >> 3] |= 1 << (k & 7); }
  const o = { t: g.title, a: g.author, d: g.date, x: g.description, s: g.build.server, c: g.build.classKey, l: g.build.level, k: b64u(bits), n: g.notes };
  if (g.stats) o.v = g.stats;
  return o;
}
function expand(o){
  if (!o || typeof o.k !== "string") return o;
  const bits = fromB64u(o.k), learned = [];
  for (let k = 0; k < bits.length * 8 && k < 160; k++) if (bits[k >> 3] & (1 << (k & 7))) learned.push((Math.floor(k / 40) + 1) * 100 + Math.floor(k % 40 / 4) * 10 + k % 4 + 1);
  const g = { format: "12t-class-guide", version: 1, title: o.t, author: o.a, date: o.d, description: o.x, build: { server: o.s, classKey: o.c, level: o.l, learned }, ...(o.v !== undefined ? { stats: o.v } : {}), notes: o.n || {} };
  return g;
}
function encode(json){
  const text = JSON.stringify(compact(typeof json === "string" ? JSON.parse(json) : json));
  return PREFIX + b64u(zlib.deflateRawSync(Buffer.from(text, "utf8"), { level: 9 }));
}
function decode(code){
  const text = String(code).trim();
  if (!text.startsWith(PREFIX)) return JSON.parse(text);   // already plain JSON
  const body = text.slice(PREFIX.length).replace(/\s+/g, "");
  if (!/^[A-Za-z0-9_-]+$/.test(body)) throw new Error("not a guide code");
  const out = zlib.inflateRawSync(fromB64u(body), { maxOutputLength: 131072 }).toString("utf8");
  return expand(JSON.parse(out));
}
module.exports = { PREFIX, encode, decode, compact, expand };

if (require.main === module){
  const [op, arg] = process.argv.slice(2);
  const read = a => (a && fs.existsSync(a)) ? fs.readFileSync(a, "utf8") : a;
  try {
    if (op === "--selftest"){
      const g = { format: "12t-class-guide", version: 1, title: "ทดสอบ **ทอง**", author: "ผู้เขียน", date: "2026-10-16", description: "a\nb", build: { server: "tot", classKey: "wolf", level: 100, learned: [101, 102, 134, 211, 491, 494] }, stats: { agi: 120, lck: 40 }, notes: { "101": "โน้ต" } };
      const c = encode(g);
      if (!c.startsWith(PREFIX) || JSON.stringify(decode(c)) !== JSON.stringify(g) || JSON.stringify(decode(JSON.stringify(g))) !== JSON.stringify(g)) throw new Error("round trip failed");
      console.log("guide_code selftest: all checks passed (" + JSON.stringify(g).length + " chars of JSON -> " + c.length + " chars of code)");
    } else if (op === "decode" && arg) console.log(JSON.stringify(decode(read(arg)), null, 2));
    else if (op === "encode" && arg) console.log(encode(read(arg)));
    else { console.error("usage: see the header of scripts/guide_code.js"); process.exit(2); }
  } catch (e){ console.error("guide_code: " + e.message); process.exit(1); }
}
