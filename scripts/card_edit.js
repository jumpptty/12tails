#!/usr/bin/env node
// Safe, field-level edits to SKILLS cards in 12t_projects/bible/index.html (GEMINI.md §1: never retype a whole card).
//
//   node scripts/card_edit.js add-field   <cardId> <key> <js-source>        add a top-level field (fails if present)
//   node scripts/card_edit.js set-field   <cardId> <key> <js-source>        replace a top-level field's value
//   node scripts/card_edit.js add-compat  <cardId> <otherId>... [--both]    append to compatSkills (--both: and back)
//   node scripts/card_edit.js replace     <cardId> <old-text> <new-text>    replace text that occurs once in the card
//   node scripts/card_edit.js --selftest
//
// Add --dry-run to print the edited card without writing. Every write first copies index.html to
// <os temp>/12t-bible-backups/ and refuses to save if the page script no longer parses.
"use strict";
const fs = require("fs");
const os = require("os");
const path = require("path");
const vm = require("vm");

const FILE = path.resolve(__dirname, "../12t_projects/bible/index.html");

// ---- tokenizer: one card's extent and its top-level (depth 1) fields ----
function escapeRe(s) { return s.replace(/[.*+?^${}()|[\]\\&]/g, "\\$&"); }

function findCard(src, id) {
  const ms = [...src.matchAll(new RegExp(`\\{\\s*id:\\s*"${escapeRe(id)}"`, "g"))];
  if (ms.length !== 1) throw new Error(`card "${id}": ${ms.length} matches`);
  return scanCard(src, ms[0].index);
}

// Walks from the card's "{" to its matching "}", skipping strings, template literals (with ${} nesting) and comments.
// Returns { start, end, fields: [{ key, keyStart, valueStart, valueEnd }] } for depth-1 "key: value" pairs.
function scanCard(src, start) {
  let depth = 0, q = null;
  const tpl = [], fields = [];
  let cur = null;
  const closeField = (i) => { if (cur) { let e = i; while (/\s/.test(src[e - 1])) e--; cur.valueEnd = e; fields.push(cur); cur = null; } };
  for (let i = start; i < src.length; i++) {
    const c = src[i];
    if (q) {
      if (c === "\\") { i++; continue; }
      if (q === "`" && c === "$" && src[i + 1] === "{") { tpl.push(depth); depth++; q = null; i++; continue; }
      if (c === q) q = null;
      continue;
    }
    if (c === '"' || c === "'" || c === "`") { q = c; continue; }
    // Comments may contain quotes or backticks (mole_tnt), so skip them whole.
    if (c === "/" && src[i + 1] === "/") { const e = src.indexOf("\n", i); i = e < 0 ? src.length : e; continue; }
    if (c === "/" && src[i + 1] === "*") { const e = src.indexOf("*/", i + 2); i = e < 0 ? src.length : e + 1; continue; }
    if (depth === 1 && !cur) {
      const m = /^([A-Za-z_$][\w$]*)\s*:/.exec(src.slice(i, i + 64));
      if (m && /[\s,{]/.test(src[i - 1])) { cur = { key: m[1], keyStart: i, valueStart: i + m[0].length }; i += m[0].length - 1; continue; }
    }
    if (c === "{" || c === "[" || c === "(") depth++;
    else if (c === "}" || c === "]" || c === ")") {
      depth--;
      if (tpl.length && depth === tpl[tpl.length - 1]) { tpl.pop(); q = "`"; continue; }
      if (depth === 0) { closeField(i); return { start, end: i, fields }; }
    } else if (c === "," && depth === 1) closeField(i);
  }
  throw new Error("unclosed card at offset " + start);
}

// ---- operations (pure: src in, src out) ----
function addField(src, id, key, value) {
  const card = findCard(src, id);
  if (card.fields.some(f => f.key === key)) throw new Error(`${id}: field "${key}" already exists (use set-field)`);
  let p = card.end; while (/\s/.test(src[p - 1])) p--;
  const sep = src[p - 1] === "," || src[p - 1] === "{" ? " " : ", ";
  return src.slice(0, p) + `${sep}${key}:${value}` + src.slice(p);   // keeps the card's own whitespace before "}"
}

function setField(src, id, key, value) {
  const card = findCard(src, id);
  const f = card.fields.filter(x => x.key === key);
  if (f.length !== 1) throw new Error(`${id}: field "${key}" found ${f.length} times`);
  return src.slice(0, f[0].valueStart) + value + src.slice(f[0].valueEnd);
}

function addCompat(src, id, others) {
  const card = findCard(src, id);
  const f = card.fields.find(x => x.key === "compatSkills");
  if (!f) return addField(src, id, "compatSkills", "[" + others.map(o => JSON.stringify(o)).join(", ") + "]");
  const val = src.slice(f.valueStart, f.valueEnd);
  const have = new Set([...val.matchAll(/"([^"]+)"/g)].map(m => m[1]));
  const extra = others.filter(o => !have.has(o));
  if (!extra.length) return src;
  const close = f.valueStart + val.lastIndexOf("]");
  let p = close; while (/\s/.test(src[p - 1])) p--;
  const sep = src[p - 1] === "[" ? "" : ", ";
  return src.slice(0, p) + sep + extra.map(o => JSON.stringify(o)).join(", ") + src.slice(p);
}

function replaceInCard(src, id, oldText, newText) {
  const card = findCard(src, id);
  const body = src.slice(card.start, card.end + 1);
  const n = body.split(oldText).length - 1;
  if (n !== 1) throw new Error(`${id}: text found ${n} times in the card`);
  return src.slice(0, card.start) + body.replace(oldText, () => newText) + src.slice(card.end + 1);
}

// The inline script that defines SKILLS must still compile.
function assertParses(src) {
  const i = src.indexOf("const SKILLS");
  const s = src.lastIndexOf("<script", i), e = src.indexOf("</script>", i);
  if (i < 0 || s < 0 || e < 0) throw new Error("could not locate the SKILLS script block");
  const body = src.slice(src.indexOf(">", s) + 1, e);
  try { new vm.Script(body, { filename: "index.html <script>" }); }
  catch (err) { throw new Error("edit breaks the page script: " + err.message); }
}

function writeSafely(before, after) {
  assertParses(after);
  const dir = path.join(os.tmpdir(), "12t-bible-backups");
  fs.mkdirSync(dir, { recursive: true });
  const bak = path.join(dir, `index.${new Date().toISOString().replace(/[:.]/g, "-")}.bak`);
  fs.writeFileSync(bak, before);
  fs.writeFileSync(FILE, after);
  return bak;
}

// ---- self-test on a small fixture ----
function selftest() {
  const assert = require("assert");
  const fx = `<script>
const SKILLS = [
  { id:"a_one", name:"One", desc:(rank)=>\`x \${rank > 1 ? "{" : "}"} y\`, cost:{mp:[1,2]}, compatSkills:["a_two"] },
  { id:"a_two", name:"Two", desc:"t, u", servers:{ tto:{ compatSkills:["zz"] } } },
];
</script>`;
  let s = addField(fx, "a_two", "cd", "30");
  assert.ok(/name:"Two", desc:"t, u", servers:\{ tto:\{ compatSkills:\["zz"\] \} \}, cd:30 \}/.test(s), "add-field");
  assert.throws(() => addField(s, "a_two", "cd", "1"), /already exists/);
  s = setField(s, "a_one", "cost", "{mp:[3,4]}");
  assert.ok(s.includes("cost:{mp:[3,4]}"), "set-field");
  s = addCompat(s, "a_one", ["a_three", "a_two"]);
  assert.ok(s.includes('compatSkills:["a_two", "a_three"]'), "add-compat appends only new ids");
  s = addCompat(s, "a_two", ["a_one"]);
  assert.ok(/compatSkills:\["zz"\] \} \}, cd:30, compatSkills:\["a_one"\] \}/.test(s), "add-compat ignores nested servers.compatSkills");
  s = replaceInCard(s, "a_two", '"t, u"', '"v"');
  assert.ok(s.includes('desc:"v"'), "replace");
  assertParses(s);
  assert.throws(() => assertParses(s.replace('desc:"v"', 'desc:"v\nw"')), /breaks the page script/);
  const cm = `{ id:"c_one", dmg:"1", // a \`sLv\` note with a backtick
    /* and a "quote */ ko:"2", desc:"d" }`;
  const card = findCard(cm, "c_one");
  assert.deepStrictEqual(card.fields.map(f => f.key), ["id", "dmg", "ko", "desc"], "comments are skipped");
  assert.ok(setField(cm, "c_one", "desc", '"e"').includes('desc:"e" }'), "set-field after a comment");
  console.log("card_edit selftest: all checks passed");
}

// ---- CLI ----
if (require.main === module) {
  const args = process.argv.slice(2);
  if (args[0] === "--selftest") { selftest(); process.exit(0); }
  const dry = args.includes("--dry-run"), both = args.includes("--both");
  const [op, id, ...rest] = args.filter(a => a !== "--dry-run" && a !== "--both");
  const before = fs.readFileSync(FILE, "utf8");
  let after;
  try {
    if (op === "add-field" && rest.length === 2) after = addField(before, id, rest[0], rest[1]);
    else if (op === "set-field" && rest.length === 2) after = setField(before, id, rest[0], rest[1]);
    else if (op === "add-compat" && rest.length) {
      after = addCompat(before, id, rest);
      if (both) for (const o of rest) after = addCompat(after, o, [id]);
    } else if (op === "replace" && rest.length === 2) after = replaceInCard(before, id, rest[0], rest[1]);
    else { console.error("usage: see the header of scripts/card_edit.js"); process.exit(2); }
    if (dry) { const c = findCard(after, id); console.log(after.slice(c.start, c.end + 1)); process.exit(0); }
    if (after === before) { console.log("no change"); process.exit(0); }
    const bak = writeSafely(before, after);
    console.log(`${op} ${id}: written (backup ${bak})`);
  } catch (err) { console.error("card_edit: " + err.message); process.exit(1); }
}

module.exports = { findCard, scanCard, addField, setField, addCompat, replaceInCard, assertParses };
