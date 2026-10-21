#!/usr/bin/env node
// Class guide short codes (12t_projects/bible, ไกด์อาชีพ). Format 3 ("TG3", what the page exports since 2026-10-20): the format 2 bytes written as CJK
// characters, 14 bits each, plus a check character (see toCjk below), so Discord can't eat "_" pairs as italics and codes are about 2.3x shorter.
// Format 2 ("TG2."): the guide as compact binary (see classGuideBinary below; Thai is one byte per character), deflated when that is shorter, URL-safe
// base64; it still decodes, as does format 1 ("12TG1.": one-letter-key JSON, deflate-raw).
// The page makes them (classGuidePack) and reads them (classGuideUnpack); this decodes one outside the browser, to embed a submitted guide
// in CLASS_GUIDES as a JSON object (12t_projects/bible/CLASS-GUIDES.md).
//
//   node scripts/guide_code.js decode <code | file>     print the guide JSON (pretty)
//   node scripts/guide_code.js encode <json file>       print the short code
//   node scripts/guide_code.js --selftest
"use strict";
const fs = require("fs");
const zlib = require("zlib");

const PREFIX = "12TG1.", PREFIX2 = "TG2.", PREFIX3 = "TG3";
// Guide code format 2 (user 2026-10-16: shorter codes): "TG2." + base64url of [flag byte (0 stored, 1 deflate-raw)] + the guide as compact binary:
//   byte  server index | class index << 2      (servers og tot tto; classes in CLASS_GUIDE_CLASS_KEYS order)
//   byte  level
//   20 bytes  learned skills, one bit per slot (tree-1)*40 + row*4 + (col-1)
//   2 bytes   date as days since 2000-01-01 (little endian), 0xFFFF = none
//   byte  stats mask (bit i = CLASS_GUIDE_STAT_KEYS[i] is set), then 2 bytes (little endian) per set stat: a number 0-512 with bit 15 = "or more" (shown as 250+), or bit 14 + a share 1-100 ("N%"), or bit 13 + a word index (CLASS_GUIDE_STAT_WORDS: 0 ตัน, 1 ตาม) (user 2026-10-18)
//   text  title, author, description   (text = varint byte length + bytes: ASCII as is, Thai U+0E00-0E5B as one byte 0x80-0xDB, anything else 0xDC + varint code point)
//   varint note count, then per note: slot byte + text
//   optional gear block (older codes end before it): 0x47, slot mask byte (bit i = CLASS_GUIDE_GEAR_KEYS[i]), then per slot a count byte (1-3) and per choice
//   a flag byte (bit 0 typed name, bit 1 has a Replica, bit 2 the Replica is a typed name, bits 4-7 stat index + 1) + text (item id or name) [+ Replica text]
//   optional cover block (user 2026-10-16): 0x49, count byte (1-5 since 2026-10-17), then one slot byte per cover icon, in the author's order. The blocks may come in any order.
//   optional support block (user 2026-10-17): 0x53, count byte (1-2), then one byte per support skill (0-11 = COMMON_SUPPORT_SKILL_IDS order); a note or cover slot
//   byte 200-211 names a support skill (ids 901-912).
//   optional stat order block (user 2026-10-18): 0x4F, count byte, then one CLASS_GUIDE_STAT_KEYS index per stat in the author's order; written only when that order is not the fixed one, so older guides keep their exact code.
//   optional mode block (user 2026-10-20): 0x4D, one byte: bit 0 PVE, bit 1 PVP (CLASS_GUIDE_MODES); written whenever a mode is set (a finished guide always has one).
//   optional description columns block (user 2026-10-21): 0x43, one byte 2 or 3; a one-column description writes none, so older codes are unchanged.
const CLASS_GUIDE_GEAR_KEYS = ["weapon", "armor", "hat", "trinket", "boot", "pet"];
const CLASS_GUIDE_CLASS_KEYS = ["rabbit", "mole", "bat", "bison", "cat", "chameleon", "monkey", "panda", "penguin", "sheep", "whale", "wolf"];
const CLASS_GUIDE_SERVER_KEYS = ["og", "tot", "tto"];
const CLASS_GUIDE_STAT_KEYS = ["atk", "def", "tal", "agi", "vit", "cha", "int", "lck"];
const CLASS_GUIDE_MODES = ["pve", "pvp"];   // what a guide is for, both allowed (user 2026-10-20)
const CLASS_GUIDE_STAT_WORDS = ["ตัน", "ตาม"];   // the stat words by index (the page's CLASS_GUIDE_STAT_WORDS)
function classGuideBinary(g){
  const out = [], slot = id => id >= 901 ? 200 + id - 901 : (Math.floor(id / 100) - 1) * 40 + Math.floor(id / 10) % 10 * 4 + (id % 10 - 1);   // support skills 901-912 = slots 200-211
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
  if (g.date && !(days >= 0 && days < 0xFFFF)) throw new Error("date out of range: " + g.date);   // never wrap: 20/10/2569 (a Buddhist-era year) came out as 2031-07-05
  out.push(days & 255, days >> 8);
  const st = g.stats || {}; let mask = 0; CLASS_GUIDE_STAT_KEYS.forEach((k, i) => { if (k in st) mask |= 1 << i; }); out.push(mask);
  for (const [k, x] of Object.entries(st)) if (!(Number.isInteger(x) && x >= 0 && x <= 512) && !(typeof x === "string" && (/^(100|[1-9]\d?)%$/.test(x) || CLASS_GUIDE_STAT_WORDS.includes(x)))) throw new Error("invalid stat value for " + k + ": " + JSON.stringify(x));   // what the page would reject
  const plus = g.statsPlus || []; CLASS_GUIDE_STAT_KEYS.forEach(k => { if (k in st){ const x = st[k], v = typeof x === "number" ? x | (plus.includes(k) ? 0x8000 : 0) : /%$/.test(x) ? parseInt(x, 10) | 0x4000 : CLASS_GUIDE_STAT_WORDS.indexOf(x) | 0x2000; out.push(v & 255, v >> 8); } });   // bit 15 = "or more" (250+), bit 14 = a share, bit 13 = a word
  text(g.title); text(g.author); text(g.description);
  const ids = Object.keys(g.notes || {}).map(Number).sort((a, b) => a - b);
  varint(ids.length); for (const id of ids){ out.push(slot(id)); text(g.notes[id]); }
  const gear = g.gear || {}, present = CLASS_GUIDE_GEAR_KEYS.filter(k => gear[k] && gear[k].length);
  if (present.length){
    let m = 0; CLASS_GUIDE_GEAR_KEYS.forEach((k, j) => { if (present.includes(k)) m |= 1 << j; }); out.push(0x47, m);
    for (const k of present){ out.push(gear[k].length); for (const c of gear[k]){ const r = c.replica; out.push((c.item ? 0 : 1) | (r ? 2 : 0) | (r && !r.item ? 4 : 0) | (c.stat ? CLASS_GUIDE_STAT_KEYS.indexOf(c.stat) + 1 : 0) << 4); text(c.item || c.name); if (r) text(r.item || r.name); } }
  }
  const cover = g.cover || []; if (cover.length){ out.push(0x49, cover.length); for (const id of cover) out.push(slot(id)); }
  const support = g.build.support || []; if (support.length){ out.push(0x53, support.length); for (const id of support) out.push(id - 901); }
  const order = Object.keys(st); if (order.join() !== CLASS_GUIDE_STAT_KEYS.filter(k => k in st).join()){ out.push(0x4F, order.length); for (const k of order) out.push(CLASS_GUIDE_STAT_KEYS.indexOf(k)); }   // the author's stat order (user 2026-10-18)
  const modes = g.modes || []; if (modes.length){ let m = 0; CLASS_GUIDE_MODES.forEach((k, j) => { if (modes.includes(k)) m |= 1 << j; }); out.push(0x4D, m); }   // PVE / PVP (user 2026-10-20)
  if (g.descCols > 1) out.push(0x43, g.descCols);   // description columns (user 2026-10-21)
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
  const statsPlus = []; CLASS_GUIDE_STAT_KEYS.forEach((k, j) => { if (mask & (1 << j)){ const v = byte() | byte() << 8, low = v & 0x1FFF;
    if (v & 0x4000){ if (v & 0xA000 || low < 1 || low > 100) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); stats[k] = low + "%"; }   // a share (user 2026-10-18)
    else if (v & 0x2000){ if (v & 0x8000 || low >= CLASS_GUIDE_STAT_WORDS.length) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); stats[k] = CLASS_GUIDE_STAT_WORDS[low]; }   // ตัน / ตาม
    else { stats[k] = low; if (v & 0x8000) statsPlus.push(k); } } });
  const title = text(), author = text(), description = text();
  const unslot = k => { if (k >= 200 && k < 212) return 901 + k - 200; if (k >= 160) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); return (Math.floor(k / 40) + 1) * 100 + Math.floor(k % 40 / 4) * 10 + k % 4 + 1; };
  const count = varint(), notes = {};
  for (let n = 0; n < count; n++){ notes[unslot(byte())] = text(); }
  let gear = null, cover = null, support = null, order = null, modes = null, descCols = 0;
  while (i < bytes.length){
    const tag = byte();
    if (tag === 0x49 && !cover){ const n = byte(); if (n < 1 || n > 5) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); cover = []; for (let q = 0; q < n; q++){ cover.push(unslot(byte())); } continue; }
    if (tag === 0x53 && !support){ const n = byte(); if (n < 1 || n > 2) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); support = []; for (let q = 0; q < n; q++){ const k = byte(); if (k >= 12) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); support.push(901 + k); } continue; }
    if (tag === 0x4F && !order){ const n = byte(); order = []; for (let q = 0; q < n; q++){ const k = byte(); if (k >= CLASS_GUIDE_STAT_KEYS.length || order.includes(k)) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); order.push(k); } continue; }   // the author's stat order (user 2026-10-18)
    if (tag === 0x4D && !modes){ const m = byte(); if (!m || m > 3) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); modes = CLASS_GUIDE_MODES.filter((k, j) => m & (1 << j)); continue; }   // PVE / PVP (user 2026-10-20)
    if (tag === 0x43 && !descCols){ descCols = byte(); if (descCols < 2 || descCols > 3) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); continue; }   // description columns (user 2026-10-21)
    if (tag !== 0x47 || gear) throw new Error("โค้ดไกด์ไม่ถูกต้อง");
    const m = byte(); gear = {};
    for (let j = 0; j < CLASS_GUIDE_GEAR_KEYS.length; j++) if (m & (1 << j)){
      const n = byte(); if (n < 1 || n > 3) throw new Error("โค้ดไกด์ไม่ถูกต้อง");
      const list = [];
      for (let q = 0; q < n; q++){ const f = byte(), t = text(), c = f & 1 ? { name: t } : { item: t }; if (f & 2){ const rt = text(); c.replica = f & 4 ? { name: rt } : { item: rt }; } const st = f >> 4; if (st){ if (st > 8) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); c.stat = CLASS_GUIDE_STAT_KEYS[st - 1]; } list.push(c); }
      gear[CLASS_GUIDE_GEAR_KEYS[j]] = list;
    }
  }
  if (order){ const keys = order.map(k => CLASS_GUIDE_STAT_KEYS[k]); if (keys.length !== Object.keys(stats).length || keys.some(k => !(k in stats))) throw new Error("โค้ดไกด์ไม่ถูกต้อง"); for (const k of keys){ const v = stats[k]; delete stats[k]; stats[k] = v; } }   // re-insert in the author's order
  return { format: "12t-class-guide", version: 1, title, author, date, description, build: { server, classKey, level, learned, ...(support ? { support } : {}) }, ...(mask ? { stats } : {}), ...(statsPlus.length ? { statsPlus } : {}), ...(gear ? { gear } : {}), ...(cover ? { cover } : {}), ...(modes ? { modes } : {}), ...(descCols ? { descCols } : {}), notes };
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
  if (g.cover) o.i = g.cover;
  if (g.modes) o.m = g.modes;
  if (g.descCols) o.w = g.descCols;
  return o;
}
function expand(o){
  if (!o || typeof o.k !== "string") return o;
  const bits = fromB64u(o.k), learned = [];
  for (let k = 0; k < bits.length * 8 && k < 160; k++) if (bits[k >> 3] & (1 << (k & 7))) learned.push((Math.floor(k / 40) + 1) * 100 + Math.floor(k % 40 / 4) * 10 + k % 4 + 1);
  const g = { format: "12t-class-guide", version: 1, title: o.t, author: o.a, date: o.d, description: o.x, build: { server: o.s, classKey: o.c, level: o.l, learned }, ...(o.v !== undefined ? { stats: o.v } : {}), ...(o.g !== undefined ? { gear: o.g } : {}), ...(o.i !== undefined ? { cover: o.i } : {}), ...(o.m !== undefined ? { modes: o.m } : {}), ...(o.w !== undefined ? { descCols: o.w } : {}), notes: o.n || {} };
  return g;
}
// Format 3 text layer (the page's classGuideToCjk / classGuideFromCjk): bits in order, 14 per character as U+4E00 + n, zero-padded, then one check character
// (CRC-16/CCITT of the bytes, low 14 bits). Bit 1 of the flag byte says the padding held a whole extra byte, which the reader drops.
// Reading ignores everything outside U+4E00-U+8DFF (spaces, line breaks, backticks, the text of a chat message).
const CJK0 = 0x4E00, BAD3 = "โค้ดไกด์ไม่ถูกต้องหรือไม่ครบ กรุณาคัดลอกใหม่ทั้งหมด";
const crc14 = bytes => { let c = 0xFFFF; for (const b of bytes){ c ^= b << 8; for (let k = 0; k < 8; k++) c = c & 0x8000 ? ((c << 1) ^ 0x1021) & 0xFFFF : (c << 1) & 0xFFFF; } return c & 0x3FFF; };
function toCjk(all){   // all[0] = the flag byte (bit 1 is set here when needed)
  all = Buffer.from(all);
  if (Math.floor(Math.ceil(all.length * 8 / 14) * 14 / 8) > all.length) all[0] |= 2;
  let out = "", acc = 0, n = 0;
  for (const b of all){ acc = (acc << 8) | b; n += 8; while (n >= 14){ n -= 14; out += String.fromCharCode(CJK0 + ((acc >> n) & 0x3FFF)); } acc &= (1 << n) - 1; }
  if (n) out += String.fromCharCode(CJK0 + ((acc << (14 - n)) & 0x3FFF));
  return out + String.fromCharCode(CJK0 + crc14(all));
}
function fromCjk(text){
  const cs = [...String(text)].map(ch => ch.codePointAt(0) - CJK0).filter(v => v >= 0 && v < 0x4000);
  if (cs.length < 2) throw new Error(BAD3);
  const check = cs.pop(), out = []; let acc = 0, n = 0;
  for (const v of cs){ acc = (acc << 14) | v; n += 14; while (n >= 8){ n -= 8; out.push((acc >> n) & 255); } acc &= (1 << n) - 1; }
  const all = Buffer.from(out), bytes = all[0] & 2 ? all.subarray(0, all.length - 1) : all;
  if (!bytes.length || crc14(bytes) !== check) throw new Error(BAD3);
  return bytes;
}
const isCode3 = text => { const at = text.indexOf(PREFIX3); return at >= 0 && /[一-跿]/.test(text.slice(at)) ? at : -1; };
// encode = format 3 (what the page exports); encode2 / encode1 = the older formats, still read
function encode(json){
  const g = typeof json === "string" ? JSON.parse(json) : json, raw = classGuideBinary(g), z = zlib.deflateRawSync(raw, { level: 9 });
  return PREFIX3 + toCjk(Buffer.concat([Buffer.from([z.length < raw.length ? 1 : 0]), z.length < raw.length ? z : raw]));
}
function encode2(json){
  const g = typeof json === "string" ? JSON.parse(json) : json, raw = classGuideBinary(g), z = zlib.deflateRawSync(raw, { level: 9 });
  return PREFIX2 + b64u(Buffer.concat([Buffer.from([z.length < raw.length ? 1 : 0]), z.length < raw.length ? z : raw]));
}
function encode1(json){
  const text = JSON.stringify(compact(typeof json === "string" ? JSON.parse(json) : json));
  return PREFIX + b64u(zlib.deflateRawSync(Buffer.from(text, "utf8"), { level: 9 }));
}
function decode(code){
  const text = String(code).trim(), at3 = isCode3(text);
  if (at3 >= 0){
    const all = fromCjk(text.slice(at3 + PREFIX3.length));
    if (all[0] > 3) throw new Error("not a guide code");
    let bytes; try { bytes = all[0] & 1 ? zlib.inflateRawSync(all.subarray(1), { maxOutputLength: 131072 }) : all.subarray(1); } catch (e){ throw new Error(BAD3); }
    return classGuideFromBinary(bytes);
  }
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
module.exports = { PREFIX, PREFIX2, PREFIX3, CLASS_GUIDE_CLASS_KEYS, CLASS_GUIDE_SERVER_KEYS, encode, encode2, encode1, decode, toCjk, fromCjk, compact, expand, classGuideBinary, classGuideFromBinary };

if (require.main === module){
  const [op, arg] = process.argv.slice(2);
  const read = a => (a && fs.existsSync(a)) ? fs.readFileSync(a, "utf8") : a;
  try {
    if (op === "--selftest"){
      const g = { format: "12t-class-guide", version: 1, title: "ทดสอบ **ทอง**", author: "ผู้เขียน", date: "2026-10-16", description: "a\nb", build: { server: "tot", classKey: "wolf", level: 100, learned: [101, 102, 134, 211, 491, 494] }, stats: { agi: 120, lck: 40 }, gear: { weapon: [{ item: "w_wlf10", replica: { name: "ดาบใหม่ **ทดสอบ**" }, stat: "atk" }, { name: "Custom Blade" }], pet: [{ item: "p_lcr" }] }, cover: [134, 101, 494], notes: { "101": "โน้ต" } };
      const c = encode(g);
      if (JSON.stringify(decode(encode1(g))) !== JSON.stringify(g)) throw new Error("format 1 round trip failed");
      if (JSON.stringify(decode(encode2(g))) !== JSON.stringify(g)) throw new Error("format 2 round trip failed");
      if (!c.startsWith(PREFIX3) || !/^[一-跿]+$/.test(c.slice(PREFIX3.length)) || JSON.stringify(decode("ไกด์ `" + c.slice(0, 9) + " \n" + c.slice(9) + "` จบ")) !== JSON.stringify(g)) throw new Error("format 3 code or its forgiving paste failed");
      { const at = c.length - 2; let refused = false; try { decode(c.slice(0, at) + String.fromCharCode(c.charCodeAt(at) ^ 1) + c.slice(at + 1)); } catch (e){ refused = /คัดลอกใหม่/.test(e.message); } if (!refused) throw new Error("a changed TG3 character was not refused"); }
      if (!c.startsWith(PREFIX3) || JSON.stringify(decode(c)) !== JSON.stringify(g) || JSON.stringify(decode(JSON.stringify(g))) !== JSON.stringify(g)) throw new Error("round trip failed");
      { const f = { ...g, stats: { cha: "ตาม", agi: 250, atk: "ตัน", vit: "70%", lck: "30%" }, statsPlus: ["agi"] }, back = decode(encode(f)); if (JSON.stringify(back.stats) !== JSON.stringify(f.stats) || JSON.stringify(back.statsPlus) !== '["agi"]') throw new Error("stat shares / words / order round trip failed"); }
      console.log("guide_code selftest: all checks passed (" + JSON.stringify(g).length + " chars of JSON -> " + c.length + " chars of code)");
    } else if (op === "decode" && arg) console.log(JSON.stringify(decode(read(arg)), null, 2));
    else if (op === "encode" && arg) console.log(encode(read(arg)));
    else { console.error("usage: see the header of scripts/guide_code.js"); process.exit(2); }
  } catch (e){ console.error("guide_code: " + e.message); process.exit(1); }
}
