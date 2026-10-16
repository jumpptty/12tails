#!/usr/bin/env node
// Class guide short codes (12t_projects/bible, ไกด์อาชีพ). Format 2 ("TG2.", what the page exports): the guide as compact binary
// (see classGuideBinary below; Thai is one byte per character), deflated when that is shorter, URL-safe base64. Format 1 ("12TG1.": one-letter-key
// JSON, deflate-raw) still decodes.
// The page makes them (classGuidePack) and reads them (classGuideUnpack); this decodes one outside the browser, to embed a submitted guide
// in CLASS_GUIDES as a JSON object (12t_projects/bible/CLASS-GUIDES.md).
//
//   node scripts/guide_code.js decode <code | file>     print the guide JSON (pretty)
//   node scripts/guide_code.js encode <json file>       print the short code
//   node scripts/guide_code.js --selftest
"use strict";
const fs = require("fs");
const zlib = require("zlib");

const PREFIX = "12TG1.", PREFIX2 = "TG2.";
// Guide code format 2 (user 2026-10-16: shorter codes): "TG2." + base64url of [flag byte (0 stored, 1 deflate-raw)] + the guide as compact binary:
//   byte  server index | class index << 2      (servers og tot tto; classes in CLASS_GUIDE_CLASS_KEYS order)
//   byte  level
//   20 bytes  learned skills, one bit per slot (tree-1)*40 + row*4 + (col-1)
//   2 bytes   date as days since 2000-01-01 (little endian), 0xFFFF = none
//   byte  stats mask (bit i = CLASS_GUIDE_STAT_KEYS[i] is set), then 2 bytes (little endian) per set stat
//   text  title, author, description   (text = varint byte length + bytes: ASCII as is, Thai U+0E00-0E5B as one byte 0x80-0xDB, anything else 0xDC + varint code point)
//   varint note count, then per note: slot byte + text
//   optional gear block (older codes end before it): 0x47, slot mask byte (bit i = CLASS_GUIDE_GEAR_KEYS[i]), then per slot a count byte (1-3) and per choice
//   a flag byte (bit 0 typed name, bit 1 has a Replica, bit 2 the Replica is a typed name, bits 4-7 stat index + 1) + text (item id or name) [+ Replica text]
const CLASS_GUIDE_GEAR_KEYS = ["weapon", "armor", "hat", "trinket", "boot", "pet"];
const CLASS_GUIDE_CLASS_KEYS = ["rabbit", "mole", "bat", "bison", "cat", "chameleon", "monkey", "panda", "penguin", "sheep", "whale", "wolf"];
const CLASS_GUIDE_SERVER_KEYS = ["og", "tot", "tto"];
const CLASS_GUIDE_STAT_KEYS = ["atk", "def", "tal", "agi", "vit", "cha", "int", "lck"];
function classGuideBinary(g){
  const out = [], slot = id => (Math.floor(id / 100) - 1) * 40 + Math.floor(id / 10) % 10 * 4 + (id % 10 - 1);
  const varint = n => { while (n >= 0x80){ out.push((n & 0x7F) | 0x80); n = Math.floor(n / 128); } out.push(n); };
  const text = str => {
    const body = [];
    for (const ch of String(str || "")){
      const cp = ch.codePointAt(0);
      if (cp < 0x80) body.push(cp);
      else if (cp >= 0x0E00 && cp <= 0x0E5B) body.push(0x80 + cp - 0x0E00);
      else { body.push(0xDC); let n = cp; while (n >= 0x80){ body.push((n & 0x7F) | 0x80); n = Math.floor(n / 128); } body.push(n); }
    }
    varint(body.length); for (const x of body) out.push(x);
  };
  out.push(CLASS_GUIDE_SERVER_KEYS.indexOf(g.build.server) | CLASS_GUIDE_CLASS_KEYS.indexOf(g.build.classKey) << 2, g.build.level);
  const bits = new Array(20).fill(0); for (const id of g.build.learned){ const k = slot(id); bits[k >> 3] |= 1 << (k & 7); }
  for (const x of bits) out.push(x);
  const days = g.date ? Math.round((Date.parse(g.date + "T00:00:00Z") - Date.UTC(2000, 0, 1)) / 864e5) : 0xFFFF;
  out.push(days & 255, days >> 8);
  const st = g.stats || {}; let mask = 0; CLASS_GUIDE_STAT_KEYS.forEach((k, i) => { if (k in st) mask |= 1 << i; }); out.push(mask);
  CLASS_GUIDE_STAT_KEYS.forEach(k => { if (k in st) out.push(st[k] & 255, st[k] >> 8); });
  text(g.title); text(g.author); text(g.description);
  const ids = Object.keys(g.notes || {}).map(Number).sort((a, b) => a - b);
  varint(ids.length); for (const id of ids){ out.push(slot(id)); text(g.notes[id]); }
  const gear = g.gear || {}, present = CLASS_GUIDE_GEAR_KEYS.filter(k => gear[k] && gear[k].length);
  if (present.length){
    let m = 0; CLASS_GUIDE_GEAR_KEYS.forEach((k, j) => { if (present.includes(k)) m |= 1 << j; }); out.push(0x47, m);
    for (const k of present){ out.push(gear[k].length); for (const c of gear[k]){ const r = c.replica; out.push((c.item ? 0 : 1) | (r ? 2 : 0) | (r && !r.item ? 4 : 0) | (c.stat ? CLASS_GUIDE_STAT_KEYS.indexOf(c.stat) + 1 : 0) << 4); text(c.item || c.name); if (r) text(r.item || r.name); } }
  }
  return Buffer.from(out);
}
function classGuideFromBinary(bytes){
  let i = 0;
  const need = n => { if (i + n > bytes.length) throw new Error("โค้ดไกด์ไม่ครบ กรุณาคัดลอกใหม่ทั้งหมด"); };
  const byte = () => { need(1); return bytes[i++]; };
  const varint = () => { let n = 0, mul = 1, b; do { b = byte(); n += (b & 0x7F) * mul; mul *= 128; } while (b & 0x80 && mul < 2 ** 35); return n; };
  const text = () => {
    const len = varint(); need(len); const end = i + len; let s = "";
    while (i < end){
      const b = bytes[i++];
      if (b < 0x80) s += String.fromCharCode(b);
      else if (b <= 0xDB) s += String.fromCharCode(0x0E00 + b - 0x80);
      else if (b === 0xDC){ let n = 0, mul = 1, c; do { if (i >= end) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); c = bytes[i++]; n += (c & 0x7F) * mul; mul *= 128; } while (c & 0x80); if (n > 0x10FFFF) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); s += String.fromCodePoint(n); }
      else throw new Error("โค้ดไกด์ไม่ถูกต้อง");
    }
    return s;
  };
  const head = byte(), server = CLASS_GUIDE_SERVER_KEYS[head & 3], classKey = CLASS_GUIDE_CLASS_KEYS[head >> 2], level = byte();
  if (!server || !classKey) throw new Error("โค้ดไกด์ไม่ถูกต้อง");
  need(20); const learned = [];
  for (let k = 0; k < 160; k++) if (bytes[i + (k >> 3)] & (1 << (k & 7))) learned.push((Math.floor(k / 40) + 1) * 100 + Math.floor(k % 40 / 4) * 10 + k % 4 + 1);
  i += 20;
  const days = byte() | byte() << 8;
  const date = days === 0xFFFF ? "" : new Date(Date.UTC(2000, 0, 1) + days * 864e5).toISOString().slice(0, 10);
  const mask = byte(), stats = {};
  CLASS_GUIDE_STAT_KEYS.forEach((k, j) => { if (mask & (1 << j)) stats[k] = byte() | byte() << 8; });
  const title = text(), author = text(), description = text();
  const count = varint(), notes = {};
  for (let n = 0; n < count; n++){ const k = byte(); if (k >= 160) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); notes[(Math.floor(k / 40) + 1) * 100 + Math.floor(k % 40 / 4) * 10 + k % 4 + 1] = text(); }
  let gear = null;
  if (i < bytes.length){
    if (byte() !== 0x47) throw new Error("โค้ดไกด์ไม่ถูกต้อง");
    const m = byte(); gear = {};
    for (let j = 0; j < CLASS_GUIDE_GEAR_KEYS.length; j++) if (m & (1 << j)){
      const n = byte(); if (n < 1 || n > 3) throw new Error("โค้ดไกด์ไม่ถูกต้อง");
      const list = [];
      for (let q = 0; q < n; q++){ const f = byte(), t = text(), c = f & 1 ? { name: t } : { item: t }; if (f & 2){ const rt = text(); c.replica = f & 4 ? { name: rt } : { item: rt }; } const st = f >> 4; if (st){ if (st > 8) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); c.stat = CLASS_GUIDE_STAT_KEYS[st - 1]; } list.push(c); }
      gear[CLASS_GUIDE_GEAR_KEYS[j]] = list;
    }
  }
  return { format: "12t-class-guide", version: 1, title, author, date, description, build: { server, classKey, level, learned }, ...(mask ? { stats } : {}), ...(gear ? { gear } : {}), notes };
}

// Same compact form as classGuideCompact / classGuideExpand in index.html: one-letter keys, learned skills as a 160-bit set (one bit per tree x row x column slot).
const b64u = buf => Buffer.from(buf).toString("base64").replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
const fromB64u = str => Buffer.from(str.replace(/-/g, "+").replace(/_/g, "/"), "base64");
const slot = id => (Math.floor(id / 100) - 1) * 40 + Math.floor(id / 10) % 10 * 4 + (id % 10 - 1);
function compact(g){
  const bits = Buffer.alloc(20);
  for (const id of g.build.learned){ const k = slot(id); bits[k >> 3] |= 1 << (k & 7); }
  const o = { t: g.title, a: g.author, d: g.date, x: g.description, s: g.build.server, c: g.build.classKey, l: g.build.level, k: b64u(bits), n: g.notes };
  if (g.stats) o.v = g.stats;
  if (g.gear) o.g = g.gear;
  return o;
}
function expand(o){
  if (!o || typeof o.k !== "string") return o;
  const bits = fromB64u(o.k), learned = [];
  for (let k = 0; k < bits.length * 8 && k < 160; k++) if (bits[k >> 3] & (1 << (k & 7))) learned.push((Math.floor(k / 40) + 1) * 100 + Math.floor(k % 40 / 4) * 10 + k % 4 + 1);
  const g = { format: "12t-class-guide", version: 1, title: o.t, author: o.a, date: o.d, description: o.x, build: { server: o.s, classKey: o.c, level: o.l, learned }, ...(o.v !== undefined ? { stats: o.v } : {}), ...(o.g !== undefined ? { gear: o.g } : {}), notes: o.n || {} };
  return g;
}
// encode = format 2 (what the page exports); encode1 = the older format 1
function encode(json){
  const g = typeof json === "string" ? JSON.parse(json) : json, raw = classGuideBinary(g), z = zlib.deflateRawSync(raw, { level: 9 });
  return PREFIX2 + b64u(Buffer.concat([Buffer.from([z.length < raw.length ? 1 : 0]), z.length < raw.length ? z : raw]));
}
function encode1(json){
  const text = JSON.stringify(compact(typeof json === "string" ? JSON.parse(json) : json));
  return PREFIX + b64u(zlib.deflateRawSync(Buffer.from(text, "utf8"), { level: 9 }));
}
function decode(code){
  const text = String(code).trim();
  if (text.startsWith(PREFIX2)){
    const all = fromB64u(text.slice(PREFIX2.length).replace(/\s+/g, ""));
    if (!all.length || all[0] > 1) throw new Error("not a guide code");
    const bytes = all[0] === 1 ? zlib.inflateRawSync(all.subarray(1), { maxOutputLength: 131072 }) : all.subarray(1);
    return classGuideFromBinary(bytes);
  }
  if (!text.startsWith(PREFIX)) return JSON.parse(text);   // already plain JSON
  const body = text.slice(PREFIX.length).replace(/\s+/g, "");
  if (!/^[A-Za-z0-9_-]+$/.test(body)) throw new Error("not a guide code");
  const out = zlib.inflateRawSync(fromB64u(body), { maxOutputLength: 131072 }).toString("utf8");
  return expand(JSON.parse(out));
}
module.exports = { PREFIX, PREFIX2, encode, encode1, decode, compact, expand, classGuideBinary, classGuideFromBinary };

if (require.main === module){
  const [op, arg] = process.argv.slice(2);
  const read = a => (a && fs.existsSync(a)) ? fs.readFileSync(a, "utf8") : a;
  try {
    if (op === "--selftest"){
      const g = { format: "12t-class-guide", version: 1, title: "ทดสอบ **ทอง**", author: "ผู้เขียน", date: "2026-10-16", description: "a\nb", build: { server: "tot", classKey: "wolf", level: 100, learned: [101, 102, 134, 211, 491, 494] }, stats: { agi: 120, lck: 40 }, gear: { weapon: [{ item: "w_wlf10", replica: { name: "ดาบใหม่ **ทดสอบ**" }, stat: "atk" }, { name: "Custom Blade" }], pet: [{ item: "p_lcr" }] }, notes: { "101": "โน้ต" } };
      const c = encode(g);
      if (JSON.stringify(decode(encode1(g))) !== JSON.stringify(g)) throw new Error("format 1 round trip failed");
      if (!c.startsWith(PREFIX2) || JSON.stringify(decode(c)) !== JSON.stringify(g) || JSON.stringify(decode(JSON.stringify(g))) !== JSON.stringify(g)) throw new Error("round trip failed");
      console.log("guide_code selftest: all checks passed (" + JSON.stringify(g).length + " chars of JSON -> " + c.length + " chars of code)");
    } else if (op === "decode" && arg) console.log(JSON.stringify(decode(read(arg)), null, 2));
    else if (op === "encode" && arg) console.log(encode(read(arg)));
    else { console.error("usage: see the header of scripts/guide_code.js"); process.exit(2); }
  } catch (e){ console.error("guide_code: " + e.message); process.exit(1); }
}
