#!/usr/bin/env node
// Class guide drafts (12t_projects/bible, ไกด์อาชีพ; user 2026-10-17): turn a Skill Simulator screenshot read as a lit / dim grid into a guide, checked
// with the page's own learn rules (SKILL_SIM, skillSimCells, skillSimValid, the point pools, loaded from index.html), and print its TG3 import code.
// Used by the guide-draft project skill (.claude/skills/guide-draft/SKILL.md).
//
//   node scripts/guide_draft.js layout <class> [server]     every tree, row by row: cell ids, names, Lv, tree points needed, required skills
//   node scripts/guide_draft.js build <draft.json> [out.json]   check the draft, print the summary and the TG3 code (and write the guide JSON)
//   node scripts/guide_draft.js --selftest
//
// Draft JSON: { server, classKey, level, grid: [Basic rows, A rows, B rows, C rows], title, author, description?, notes?, cover?, modes }
//   grid rows are strings of 1 (lit) / 0 (dim), one character per cell, left to right, top to bottom, exactly as the simulator draws them;
//   on ToT the C tree's EX rows follow its 5 rows (row 6 = 451-454, row 7 = 461); on TTO row 6 = 452-454 (three characters).
//   notes / cover keys may be cell ids or skill names ("Volcano", or "Volcano 2" for one rank; a bare name means its highest learned rank).
"use strict";
const fs = require("fs");
const path = require("path");
const vm = require("vm");
const { encode } = require("./guide_code.js");

const INDEX = path.join(__dirname, "..", "12t_projects", "bible", "index.html");
function loadSim(){
  const s = fs.readFileSync(INDEX, "utf8");
  const a = s.indexOf("const SKILL_SIM = {"), b = s.indexOf("// Clearing a tree prunes", a);
  if (a < 0 || b < 0) throw new Error("index.html: SKILL_SIM block not found (anchors: 'const SKILL_SIM = {', '// Clearing a tree prunes')");
  const box = {};   // the block also adds the EX icons to SKILL_ICONS, so the sandbox gets an empty one
  const cap = (s.match(/^const LEVEL_CAP = [^\r\n]*/m) || [""])[0];   // the block reads LEVEL_CAP (the server caps), defined elsewhere in index.html
  vm.runInNewContext(cap + "\n" + s.slice(a, b) + "\n;Object.assign(box, { SKILL_SIM, SKILL_SIM_NAMES, SKILL_SIM_EX, SKILL_SIM_SERVERS, skillSimCells, skillSimValid, skillSimCellsFor, skillSimPools });", { box, SKILL_ICONS: {}, SKILLS: [], SERVER_SHORT: {}, SERVER_FULL: {} });
  return box;
}
const TREE_NAMES = ["Basic", "A", "B", "C"];
function cellsFor(sim, classKey, server){
  if (!sim.SKILL_SIM[classKey]) throw new Error("unknown class " + classKey + " (one of " + Object.keys(sim.SKILL_SIM).join(", ") + ")");
  if (!sim.SKILL_SIM_SERVERS[server]) throw new Error("unknown server " + server + " (og, tot, tto)");
  const trees = sim.SKILL_SIM[classKey];
  return { trees, cells: sim.skillSimCellsFor(server, classKey) };
}
const rowsOf = (cells, tree) => {
  const rows = [];
  for (const id in cells){ const c = cells[id]; if (c.tree !== tree) continue; const r = Math.floor(id / 10) % 10; (rows[r] = rows[r] || []).push(c); }
  return rows.map(r => r ? r.sort((x, y) => x.id - y.id) : []);
};

function layout(classKey, server = "tto"){
  const sim = loadSim(), { cells } = cellsFor(sim, classKey, server), out = [];
  out.push(sim.SKILL_SIM_NAMES[classKey] + " on " + sim.SKILL_SIM_SERVERS[server].name + ": a cell is 'id name (Lv, needs N tree points[, req ids])'");
  for (let t = 0; t < 4; t++){
    out.push("", "== " + TREE_NAMES[t] + " ==");
    rowsOf(cells, t).forEach((row, r) => {
      if (!row.length) return;
      out.push("row " + (r + 1) + " (" + row.length + " cells): " + row.map(c => c.id + " " + c.name + " (Lv" + c.lv + ", " + c.bn + (c.req.length ? ", req " + c.req.join("+") : "") + (c.ex ? ", EX" : "") + ")").join(" | "));
    });
  }
  return out.join("\n");
}

// Why a learned set breaks the rules, one line per problem (the page's skillSimValid only says yes / no).
function problems(sim, cells, set, lv){
  const out = [];
  let used = 0, usedC = 0, usedEx = 0;
  for (const id of set){
    const c = cells[id];
    if (!c){ out.push(id + ": no such cell"); continue; }
    if (lv < c.lv) out.push(id + " " + c.name + ": needs Lv " + c.lv);
    if (id < 400 && id % 10 !== 1 && !set.has(id - 1)) out.push(id + " " + c.name + ": the cell before it (" + (id - 1) + ") is not learned");
    for (const r of c.req) if (!set.has(r)) out.push(id + " " + c.name + ": needs " + r + " " + (cells[r] ? cells[r].name : "?"));
    if (c.ex) usedEx++; else if (id < 400) used++; else usedC++;
  }
  const PL = sim.skillSimPools(cells);
  if (used > PL.normal(lv)) out.push("normal points: " + used + " used, Lv " + lv + " gives " + PL.normal(lv));
  if (usedC > PL.c(lv)) out.push("Class C points: " + usedC + " used, Lv " + lv + " gives " + PL.c(lv));
  if (usedEx > PL.ex(lv)) out.push("EX points: " + usedEx + " used, Lv " + lv + " gives " + PL.ex(lv));
  for (let t = 0; t < 4; t++){
    const bns = [...set].filter(id => cells[id] && !cells[id].ex && cells[id].tree === t).map(id => cells[id].bn).sort((x, y) => x - y);
    const k = bns.findIndex((bn, i) => bn > i);
    if (k >= 0) out.push(TREE_NAMES[t] + " tree: a skill needs " + bns[k] + " points in the tree before it, only " + k + " others are learned");
  }
  return out;
}

function resolve(cells, learned, key){
  if (/^\d+$/.test(String(key))){ const id = +key; if (!cells[id]) throw new Error("no cell " + id); return id; }
  const want = String(key).trim().toLowerCase(), all = Object.values(cells);
  const exact = all.filter(c => c.name.toLowerCase() === want);
  if (exact.length === 1) return exact[0].id;
  const base = all.filter(c => c.name.replace(/\s+\d+$/, "").toLowerCase() === want).sort((x, y) => y.id - x.id);
  if (!base.length) throw new Error("no skill named '" + key + "' (run: layout <class> <server>)");
  return (base.find(c => learned.has(c.id)) || base[base.length - 1]).id;
}

function build(draft){
  const sim = loadSim(), { trees, cells } = cellsFor(sim, draft.classKey, draft.server), lv = draft.level;
  if (!Number.isInteger(lv) || lv < 1 || lv > sim.SKILL_SIM_SERVERS[draft.server].cap) throw new Error("level " + lv + " is outside 1-" + sim.SKILL_SIM_SERVERS[draft.server].cap);
  if (!Array.isArray(draft.grid) || draft.grid.length !== 4) throw new Error("grid needs 4 trees (Basic, A, B, C)");
  const learned = new Set(), report = [];
  draft.grid.forEach((rows, t) => {
    const layoutRows = rowsOf(cells, t).filter(r => r.length);
    if (rows.length !== layoutRows.length) throw new Error(TREE_NAMES[t] + ": the grid has " + rows.length + " rows, the tree has " + layoutRows.length + " (row lengths " + layoutRows.map(r => r.length).join(",") + ")");
    let lit = 0;
    rows.forEach((mask, r) => {
      const row = layoutRows[r];
      if (!/^[01]+$/.test(mask) || mask.length !== row.length) throw new Error(TREE_NAMES[t] + " row " + (r + 1) + ": '" + mask + "' must be " + row.length + " characters of 0 / 1");
      [...mask].forEach((ch, k) => { if (ch === "1"){ learned.add(row[k].id); lit++; } });
    });
    report.push(TREE_NAMES[t] + " " + lit + "/" + layoutRows.reduce((n, r) => n + r.length, 0));
  });
  const bad = problems(sim, cells, learned, lv);
  if (bad.length || !sim.skillSimValid(cells, trees.length, learned, lv)) throw new Error("the build breaks the learn rules (re-read the screenshot):\n  " + (bad.length ? bad.join("\n  ") : "skillSimValid says no"));
  let used = 0, usedC = 0, usedEx = 0;
  for (const id of learned){ if (cells[id].ex) usedEx++; else if (id < 400) used++; else usedC++; }
  const PL = sim.skillSimPools(cells), pools = "normal " + used + "/" + PL.normal(lv) + ", C " + usedC + "/" + PL.c(lv) + (draft.server === "tot" ? ", EX " + usedEx + "/" + PL.ex(lv) : "");
  const notes = {};
  for (const [k, text] of Object.entries(draft.notes || {})){
    const id = resolve(cells, learned, k), body = String(text).trim();
    if (!body) continue;
    if (body.length > 3000) throw new Error("note on " + id + " is " + body.length + " characters (max 3000)");
    notes[id] = notes[id] ? notes[id] + "\n" + body : body;
  }
  const cover = (draft.cover || []).map(k => resolve(cells, learned, k));
  if (!cover.length || cover.length > 5 || new Set(cover).size !== cover.length) throw new Error("cover needs 1-5 different skills");
  const modes = ["pve", "pvp"].filter(m => (draft.modes || []).includes(m));   // what the guide is for, both allowed (user 2026-10-20)
  if (!modes.length) throw new Error("modes needs pve and/or pvp: what the guide is for, from the author’s post");
  for (const [k, max] of [["title", 160], ["author", 120], ["description", 12000]]) if (String(draft[k] || "").length > max) throw new Error(k + " is longer than " + max + " characters");
  if (!String(draft.title || "").trim()) throw new Error("title is empty");
  const guide = {
    format: "12t-class-guide", version: 1, title: draft.title.trim(), author: String(draft.author || "").trim(),
    description: String(draft.description || "").trim(),   // no date: the upload stamps it (user 2026-10-23)
    build: { server: draft.server, classKey: draft.classKey, level: lv, learned: [...learned].sort((a, b) => a - b) },
    cover, modes, notes: Object.fromEntries(Object.keys(notes).map(Number).sort((a, b) => a - b).map(id => [id, notes[id]])),
  };
  const lines = [
    sim.SKILL_SIM_NAMES[draft.classKey] + " on " + sim.SKILL_SIM_SERVERS[draft.server].name + " Lv " + lv + ": " + report.join(", ") + "; points " + pools,
    "cover: " + cover.map(id => id + " " + cells[id].name).join(", ") + " | modes: " + modes.map(m => m.toUpperCase()).join(" + "),
    "notes: " + (Object.keys(guide.notes).map(id => id + " " + cells[id].name).join(", ") || "none"),
  ];
  return { guide, code: encode(guide), summary: lines.join("\n") };
}

if (require.main === module){
  const [op, a, b] = process.argv.slice(2);
  try {
    if (op === "layout" && a) console.log(layout(a, b || "tto"));
    else if (op === "build" && a){
      const r = build(JSON.parse(fs.readFileSync(a, "utf8")));
      if (b) fs.writeFileSync(b, JSON.stringify(r.guide, null, 2) + "\n");
      console.log(r.summary + "\n\n" + r.code);
    } else if (op === "--selftest"){
      const draft = { server: "tto", classKey: "rabbit", level: 95, title: "t", author: "a", date: "2026-10-17", cover: [101], modes: ["pve"],
        grid: loadSim().SKILL_SIM.rabbit.map((t, i) => rowsOf(cellsFor(loadSim(), "rabbit", "tto").cells, i).filter(r => r.length).map((r, k) => i === 0 && k === 0 ? "1" + "0".repeat(r.length - 1) : "0".repeat(r.length))), notes: { 101: "n" } };
      const r = build(draft);
      if (r.guide.build.learned.join() !== "101" || !r.code.startsWith("TG3") || r.guide.notes[101] !== "n") throw new Error("one-cell build failed");
      draft.grid[0][0] = "0" + draft.grid[0][0].slice(1).replace(/^0/, "1");
      let threw = false; try { build(draft); } catch (e){ threw = /cell before it/.test(e.message); }
      if (!threw) throw new Error("a rank without the one before it was accepted");
      console.log("guide_draft selftest: all checks passed");
    } else { console.error("usage: see the header of scripts/guide_draft.js"); process.exit(2); }
  } catch (e){ console.error("guide_draft: " + e.message); process.exit(1); }
}
