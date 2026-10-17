#!/usr/bin/env node
// Class guide reader snapshot (user 2026-10-17): every commit push refreshes CLASS_GUIDE_VIEWS in 12t_projects/bible/index.html with each guide's
// current GoatCounter visitor count, read from the public counter (no token). The page shows the live count when GoatCounter answers and this
// snapshot when an ad / tracker blocker stops it, so blocked browsers still see the numbers as of the last push.
//
//   node scripts/guide_views.js            fetch every guide's count and rewrite the CLASS_GUIDE_VIEWS line (run before each commit push)
//   node scripts/guide_views.js --dry-run  print the counts, write nothing
"use strict";
const fs = require("fs");
const path = require("path");

const INDEX = path.join(__dirname, "..", "12t_projects", "bible", "index.html");
const SITE = "https://jumpptty.goatcounter.com";
const LINE = /^const CLASS_GUIDE_VIEWS = [^\r\n]*/m;   // the line body only: its CRLF ending stays untouched (index.html is CRLF)

async function count(id){
  const url = SITE + "/counter/" + encodeURIComponent("/bible/#class-guide/" + id) + ".json?start=2020-01-01";   // without start the counter answers 404 / 0 for every path (only TOTAL works); 2020 = all time
  const r = await fetch(url);
  if (r.status === 404) return 0;                              // no visit recorded yet
  if (!r.ok) throw new Error(url + " answered " + r.status);  // 403 = "Allow adding visitor counts" switched off in the GoatCounter settings
  const j = await r.json();
  return Number(String(j.count).replace(/[^\d]/g, "")) || 0;
}

(async () => {
  const s = fs.readFileSync(INDEX, "utf8");
  const a = s.indexOf("const CLASS_GUIDES = ["), b = s.indexOf("\n];", a);
  if (a < 0 || b < 0) throw new Error("CLASS_GUIDES not found");
  const ids = [...s.slice(a, b).matchAll(/^\s*\{"id":(\d+),/gm)].map(m => +m[1]);
  const counts = {};
  for (const id of ids) counts[id] = await count(id);
  const snap = "const CLASS_GUIDE_VIEWS = " + JSON.stringify({ at: new Date().toISOString(), counts }) + ";   // GoatCounter visitors per guide at the last push (scripts/guide_views.js); the page's fallback when the live counter is blocked";
  console.log(ids.length + " guides: " + ids.map(id => id + "=" + counts[id]).join(" "));
  if (process.argv.includes("--dry-run")) return;
  if (!LINE.test(s)) throw new Error("the CLASS_GUIDE_VIEWS line is missing from index.html");
  fs.writeFileSync(INDEX, s.replace(LINE, () => snap));
  console.log("CLASS_GUIDE_VIEWS updated");
})().catch(e => { console.error("guide_views: " + e.message); process.exit(1); });
