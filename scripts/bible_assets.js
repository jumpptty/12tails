#!/usr/bin/env node
// Bible assets split (user 2026-10-20): the images, 3D models and sounds that were embedded in 12t_projects/bible/index.html (24.4 MB of its
// 29.9 MB) live in 12t_projects/bible/assets.js, loaded by <script src="assets.js?v=<stamp>" id="bibleAssets"> just before the main script.
// A push that changes only the page then costs a returning visitor about 2 MB instead of 19 MB, and index.html stays far from GitHub's
// 50 / 100 MiB file limits. assets.js holds data only: "var BIBLE_ASSETS = {};" then one "BIBLE_ASSETS.<NAME> = <JSON>;" per MANIFEST
// container. The page keeps every container's name and place as "const <NAME> = BIBLE_ASSETS_IN.<NAME> || <empty>;", so a blocked or
// missing assets.js leaves blank icons instead of a broken page. The stamp is the first 10 hex of the SHA-256 of assets.js with CRLF read
// as LF (what git stores and GitHub serves), so it changes exactly when the file does: after editing assets.js, run stamp.
//
//   node scripts/bible_assets.js split       one-time migration: move the MANIFEST containers out of index.html (refuses once done)
//   node scripts/bible_assets.js stamp       after any edit to assets.js: rewrite the ?v= stamp in index.html
//   node scripts/bible_assets.js --selftest
"use strict";
const fs = require("fs"), path = require("path"), os = require("os"), vm = require("vm"), crypto = require("crypto"), assert = require("assert");

const ROOT = path.resolve(__dirname, ".."), INDEX_FILE = path.join(ROOT, "12t_projects/bible/index.html"), ASSETS_FILE = path.join(ROOT, "12t_projects/bible/assets.js");
const MANIFEST = [
  ...["SKILL_ICONS", "EASTER_EGG_IMAGES", "REACH_MODELS", "REACH_TEX", "REACH_SCENES", "CLASS_MINIMAL_ICONS", "CHM_ICONS", "CHM_AUDIO", "TOOL_ART", "CLASS_ART", "CLASS_HERO_ICONS", "CLASS_STORY_ART", "GEAR_ICONS", "GAME_TOOLTIP_ART"].map((name) => ({ name, empty: {} })),
  ...["REACH_BOLDAS_ICON", "MECH_BG_EVADE", "MECH_BG_MOVESPEED", "DONATE_QR", "TTO_WALLPAPER", "REBORN_WALLPAPER"].map((name) => ({ name, empty: "" })),
];
const TAG_RE = /<script src="assets\.js\?v=([0-9a-f]{10})" id="bibleAssets"><\/script>/;
const ASSET_BUDGET = 400 * 1024;   // data: URI text index.html may keep (274 KB stays after the split, mostly CSS backgrounds)
const URI_RE = /data:[a-z]+\/[a-z0-9.+-]+;base64,[A-Za-z0-9+/=]+/g;
const PRELUDE = [
  'const BIBLE_ASSETS_IN = typeof BIBLE_ASSETS === "object" && BIBLE_ASSETS ? BIBLE_ASSETS : {};   // assets.js (scripts/bible_assets.js); {} when it did not load',
  'if (!Object.keys(BIBLE_ASSETS_IN).length) console.warn("assets.js did not load: icons, art, 3D previews and sounds are missing");',
];

const stampOf = (buf) => crypto.createHash("sha256").update(buf.toString("utf8").replace(/\r\n/g, "\n")).digest("hex").slice(0, 10);
const dataUriBytes = (text) => (String(text).match(URI_RE) || []).reduce((a, m) => a + m.length, 0);
// strings, finite numbers, booleans, null, arrays and plain objects only (objects made in a vm context have that context's prototype)
const plain = (v) => v === null || typeof v === "string" || typeof v === "boolean" || (typeof v === "number" && isFinite(v))
  || (Array.isArray(v) ? v.every(plain) : Object.prototype.toString.call(v) === "[object Object]" && Object.values(v).every(plain));

function loadAssets(file = ASSETS_FILE){
  const box = {};
  vm.runInNewContext(fs.readFileSync(file, "utf8"), box, { filename: file });
  const extra = Object.keys(box).filter((k) => k !== "BIBLE_ASSETS");
  if (extra.length || !box.BIBLE_ASSETS) throw new Error(`assets.js may define only BIBLE_ASSETS (found: ${Object.keys(box).join(", ") || "nothing"})`);
  for (const [k, v] of Object.entries(box.BIBLE_ASSETS)) if (!plain(v)) throw new Error(`assets.js: BIBLE_ASSETS.${k} is not plain data`);
  return box.BIBLE_ASSETS;
}

function stamp(html, assetsBuf){
  const n = (html.match(new RegExp(TAG_RE.source, "g")) || []).length;
  if (n !== 1) throw new Error(`index.html must load assets.js exactly once (found ${n} tags)`);
  return html.replace(TAG_RE, (tag, v) => tag.replace(v, stampOf(assetsBuf)));
}

function split(html, manifest = MANIFEST){
  if (TAG_RE.test(html)) throw new Error("index.html already loads assets.js: the split is done (edit assets.js, then run stamp)");
  const eol = html.includes("\r\n") ? "\r\n" : "\n", lines = html.split(eol);
  const open = lines.indexOf("<script>"), close = lines.lastIndexOf("</script>");
  if (open < 0 || close < open) throw new Error('the main script ("<script>" ... "</script>" on their own lines) was not found');
  const inMain = (i) => i > open && i < close;
  // each container's declaration: one "const NAME = " at column 0; "{" at the end of the line runs to the next "};" line
  const decl = new Map();
  for (const { name } of manifest){
    const head = `const ${name} = `, all = [], col0 = [];
    lines.forEach((l, i) => { if (inMain(i) && l.trimStart().startsWith(head)) (l.startsWith(head) ? col0 : all).push(i); });
    if (col0.length !== 1 || all.length) throw new Error(`${name}: expected one "${head}" at column 0 of the main script, found ${col0.length} at column 0 and ${all.length} indented (not found = renamed or moved)`);
    const s = col0[0], e = /\{\s*$/.test(lines[s]) ? lines.findIndex((l, i) => i > s && l === "};") : s;
    if (e < 0 || e >= close) throw new Error(`${name}: no "};" line closes the declaration at line ${s + 1}`);
    try { new vm.Script(lines.slice(s, e + 1).join("\n")); } catch (err) { throw new Error(`${name}: lines ${s + 1}-${e + 1} do not parse alone (${err.message})`); }
    decl.set(name, { s, e });
  }
  const inDecl = (i) => [...decl.values()].some((d) => i >= d.s && i <= d.e);
  // heavy literal assignments that add to a container move with it (a data URI, or a long base64 string such as a mesh whose texture is
  // borrowed); the rest (aliases such as S["d"] = S["a"]) stay in the page. Report lines never show base64.
  const heavy = (l) => dataUriBytes(l) > 0 || /"[A-Za-z0-9+/=]{200,}"/.test(l);
  const show = (i) => `L${i + 1}: ` + lines[i].replace(URI_RE, "<uri>").replace(/"[A-Za-z0-9+/=]{40,}"/g, '"<b64>"').slice(0, 80);
  const moved = new Map(), movedLines = new Set(), keptAliases = [], keptLines = [];
  for (const { name } of manifest){
    const list = [];
    lines.forEach((l, i) => {
      if (!inMain(i) || inDecl(i) || !(l.startsWith(name + ".") || l.startsWith(name + "[") || l.startsWith(`Object.assign(${name}, `))) return;
      if (!heavy(l)){ keptAliases.push(show(i)); keptLines.push(i); return; }
      try { new vm.Script(l); } catch (err) { throw new Error(`${name}: line ${i + 1} does not parse alone (${err.message})`); }
      list.push(i); movedLines.add(i);
    });
    moved.set(name, list);
  }
  // the containers' values: their statements in file order, in one empty context
  const stmts = [];
  for (const [name, d] of decl) stmts.push({ at: d.s, what: name, text: lines.slice(d.s, d.e + 1).join("\n").replace(`const ${name} = `, `var ${name} = `) });
  for (const [name, list] of moved) for (const i of list) stmts.push({ at: i, what: `${name} (line ${i + 1})`, text: lines[i] });
  stmts.sort((a, b) => a.at - b.at);
  const ctx = vm.createContext({});
  for (const st of stmts){ try { vm.runInContext(st.text, ctx); } catch (err) { throw new Error(`not plain data: ${st.what} needs ${err.message}`); } }
  const values = {};
  for (const { name } of manifest){ if (!plain(ctx[name])) throw new Error(`not plain data: ${name} holds something other than strings, numbers, booleans, null, arrays and objects`); values[name] = ctx[name]; }
  // kept column-0 lines between a declaration and its last moved assignment that name the container (they now see the whole container)
  const readersBetween = [];
  for (const [name, d] of decl){
    const list = moved.get(name), word = new RegExp(`\\b${name}\\b`);
    if (list.length) for (let i = d.e + 1; i < list[list.length - 1]; i++)
      if (!movedLines.has(i) && !inDecl(i) && /^\S/.test(lines[i]) && !/^(\/\/|\/\*|\*)/.test(lines[i]) && word.test(lines[i])) readersBetween.push(show(i));
  }
  // assets.js: one block per container, one entry per line for objects
  const A = [
    "// 12 Tails Bible: the embedded images, 3D models and sounds, split out of index.html (user 2026-10-20). Data only, loaded by index.html",
    "// as assets.js?v=<stamp>. After any edit here run: node scripts/bible_assets.js stamp   (scripts/bible_assets.js explains the format)",
    "var BIBLE_ASSETS = {};",
  ];
  for (const { name } of manifest){
    const v = values[name], keys = v && typeof v === "object" && !Array.isArray(v) ? Object.keys(v) : null;
    A.push(keys === null ? `BIBLE_ASSETS.${name} = ${JSON.stringify(v)};` : !keys.length ? `BIBLE_ASSETS.${name} = {};`
      : `BIBLE_ASSETS.${name} = {` + eol + keys.map((k) => JSON.stringify(k) + ": " + JSON.stringify(v[k])).join("," + eol) + eol + "};");
  }
  const assets = A.join(eol) + eol;
  // the page: tag before the main script, prelude first in it, each declaration as one line, the moved assignments gone
  const one = new Map(manifest.map(({ name, empty }) => [decl.get(name).s, `const ${name} = BIBLE_ASSETS_IN.${name} || ${JSON.stringify(empty)};`]));
  const out = [];
  lines.forEach((l, i) => {
    if (i === open) out.push(`<script src="assets.js?v=${stampOf(Buffer.from(assets))}" id="bibleAssets"></script>`, l, ...PRELUDE);
    else if (one.has(i)) out.push(one.get(i));
    else if (!movedLines.has(i) && !inDecl(i)) out.push(l);
  });
  // self-check: the new page script parses, and assets.js + the new declarations give back every container exactly
  const newOpen = out.indexOf("<script>"), newMain = out.slice(newOpen + 1, out.lastIndexOf("</script>")).join(eol);
  try { new vm.Script(newMain); } catch (err) { throw new Error("the new main script does not parse: " + err.message); }
  const check = vm.createContext({ console: { warn: () => {}, log: () => {} } });
  vm.runInContext(assets + PRELUDE.join("\n") + "\n" + [...one.values()].join("\n"), check);
  for (const { name } of manifest) if (JSON.stringify(vm.runInContext(name, check)) !== JSON.stringify(values[name])) throw new Error(`self-check: ${name} differs after the split`);
  // ...and with the kept lines (aliases) run where they stand, old and new end with the same containers: a kept line that sets a key a
  // later moved line also sets would now run after it. Kept lines that need other page code are skipped in both runs.
  const before = vm.createContext({}), after = vm.createContext({ console: { warn: () => {}, log: () => {} } });
  vm.runInContext(assets + PRELUDE.join("\n"), after);
  const order = [...stmts.map((st) => ({ at: st.at, old: st.text, now: one.get(st.at) })), ...keptLines.map((i) => ({ at: i, old: lines[i], now: lines[i], kept: true }))].sort((a, b) => a.at - b.at);
  for (const st of order){
    try { vm.runInContext(st.old, before); } catch (err) { if (st.kept) continue; throw err; }
    if (st.now) vm.runInContext(st.now, after);
  }
  // values only: an alias that adds its own key between moved lines now adds it last, which changes the key order and nothing else
  const canon = (v) => JSON.stringify(v, (k, x) => x && typeof x === "object" && !Array.isArray(x) ? Object.fromEntries(Object.keys(x).sort().map((key) => [key, x[key]])) : x);
  for (const { name } of manifest) if (canon(before[name]) !== canon(vm.runInContext(name, after))) throw new Error(`self-check: the final value of ${name} would change (a kept line such as an alias sets a key that a later moved line also sets)`);
  return { html: out.join(eol), assets, report: { moved: movedLines.size + [...decl.values()].reduce((a, d) => a + d.e - d.s + 1, 0), keptAliases, readersBetween } };
}

// ---------- selftest ----------
function selftest(){
  const URI = "data:image/png;base64,QUJD", testManifest = [{ name: "S", empty: {} }, { name: "B", empty: "" }, { name: "R", empty: {} }];
  const fixture = [
    "<!doctype html><html><head><style>.x{background:url(\"data:image/png;base64,Q1NT\")}</style></head><body>",
    "<script>",
    "// the skill icons",
    "const S = {",
    `  "a": "${URI}",`,
    `  "b": "${URI}"`,
    "};",
    `const B = "${URI}";`,
    "const R = {};",
    `R.a = {"tex":"${URI}","v":"x"};`,
    `Object.assign(S, {"c":"${URI}"});`,
    'S["d"] = S["a"];',
    `function f(){ const T = {"k":"${URI}"}; }`,
    "</script>",
    "</body></html>",
  ].join("\r\n");
  // assets (optional) + the page's main script in one context; returns the named values
  const runMain = (html, assets, names = ["S", "B", "R"]) => {
    const ctx = vm.createContext({ console: { warn: () => {}, log: () => {} } });
    if (assets) vm.runInContext(assets, ctx);
    const a = html.indexOf("<script>") + 8;
    vm.runInContext(html.slice(a, html.indexOf("</script>", a)), ctx);
    return Object.fromEntries(names.map((n) => [n, vm.runInContext(n, ctx)]));
  };
  const same = (a, b) => assert.deepStrictEqual(JSON.parse(JSON.stringify(a)), b);   // objects made in a vm context have that context's prototypes
  const out = split(fixture, testManifest);
  const box = {}; vm.runInNewContext(out.assets, box);
  assert.deepStrictEqual(Object.keys(box), ["BIBLE_ASSETS"]);
  same(box.BIBLE_ASSETS.S, { a: URI, b: URI, c: URI });   // the merged Object.assign is included, the alias is not
  assert.strictEqual(box.BIBLE_ASSETS.B, URI);
  same(box.BIBLE_ASSETS.R, { a: { tex: URI, v: "x" } });
  assert.ok(out.html.includes("const S = BIBLE_ASSETS_IN.S || {};") && out.html.includes('const B = BIBLE_ASSETS_IN.B || "";'));
  assert.ok(out.html.includes('S["d"] = S["a"];') && out.report.keptAliases.length === 1);
  assert.ok(out.html.includes(`function f(){ const T = {"k":"${URI}"}; }`));   // not in the manifest: untouched
  assert.ok(out.html.includes("// the skill icons\r\nconst S = BIBLE_ASSETS_IN.S || {};"));   // the comment above stays, CRLF kept
  assert.strictEqual(dataUriBytes(out.html), dataUriBytes(`{"k":"${URI}"}`) + dataUriBytes("data:image/png;base64,Q1NT"));   // only the untouched function and the CSS keep one
  assert.ok(TAG_RE.test(out.html) && out.html.indexOf('id="bibleAssets"></script>\r\n<script>') > 0);
  // running assets + new main gives the old main's final values
  assert.deepStrictEqual(JSON.parse(JSON.stringify(runMain(out.html, out.assets))), JSON.parse(JSON.stringify(runMain(fixture))));
  // missing assets: the page still runs, containers are empty
  const bare = runMain(out.html, "");
  assert.ok(Object.keys(bare.S).join() === "d" && bare.S.d === undefined && bare.B === "" && Object.keys(bare.R).length === 0);
  // stamp: the CRLF and LF forms of the same file get the same stamp (git stores LF)
  const h = stamp(out.html.replace(TAG_RE, '<script src="assets.js?v=0000000000" id="bibleAssets"></script>'), Buffer.from(out.assets));
  assert.strictEqual(TAG_RE.exec(h)[1], stampOf(Buffer.from(out.assets)));
  assert.strictEqual(stampOf(Buffer.from("a\r\nb")), stampOf(Buffer.from("a\nb")));
  assert.notStrictEqual(stampOf(Buffer.from("a\nb")), stampOf(Buffer.from("a\nc")));
  assert.throws(() => stamp(fixture, Buffer.from("x")), /exactly once/);
  assert.throws(() => split(out.html, testManifest), /already/);
  assert.throws(() => split(fixture.replace("const B =", "  const B ="), testManifest), /column 0|not found/);
  assert.throws(() => split(fixture.replace(`R.a = {"tex"`, `R.a = {"q":missingName,"tex"`), testManifest), /not plain data/);
  // a heavy literal line without a data URI (a mesh whose texture is borrowed, "@a") moves too; the report shows no base64
  const MESH = "A".repeat(240), heavy = fixture.replace('S["d"] = S["a"];', `R.g = {"v":"${MESH}","tex":"@a"};\r\nS["d"] = S["a"];`), outH = split(heavy, testManifest);
  const boxH = {}; vm.runInNewContext(outH.assets, boxH);
  same(boxH.BIBLE_ASSETS.R.g, { v: MESH, tex: "@a" });
  assert.ok(!outH.html.includes(MESH) && outH.report.keptAliases.length === 1);
  assert.ok([...outH.report.keptAliases, ...outH.report.readersBetween].every((l) => !/[A-Za-z0-9+/=]{40}/.test(l)));
  // a kept alias that sets a key a later moved line also sets would change the final value: refused
  const inverted = fixture.replace('S["d"] = S["a"];', `S["e"] = S["a"];\r\nS["e"] = "${URI}Z";`);
  assert.throws(() => split(inverted, testManifest), /final value/);
  // an alias that only adds its own key between moved lines changes the key order, not a value: allowed
  const interleaved = fixture.replace('S["d"] = S["a"];', "").replace("Object.assign(S, ", 'S["d"] = S["a"];\r\nObject.assign(S, ');
  assert.doesNotThrow(() => split(interleaved, testManifest));
  // loadAssets accepts data only
  const tmp = path.join(require("os").tmpdir(), "bible_assets_selftest.js");
  fs.writeFileSync(tmp, out.assets); assert.deepStrictEqual(loadAssets(tmp).B, URI);
  fs.writeFileSync(tmp, out.assets + "\r\nvar sneaky = 1;"); assert.throws(() => loadAssets(tmp), /only BIBLE_ASSETS/);
  fs.unlinkSync(tmp);
  console.log("bible_assets: selftest passed");
}

module.exports = { MANIFEST, ASSETS_FILE, INDEX_FILE, TAG_RE, ASSET_BUDGET, stampOf, dataUriBytes, loadAssets, split, stamp };

if (require.main === module){
  const cmd = process.argv[2], mb = (n) => (n / 1048576).toFixed(2) + " MB";
  try {
    if (cmd === "--selftest") selftest();
    else if (cmd === "split"){
      const html = fs.readFileSync(INDEX_FILE, "utf8"), out = split(html);
      const dir = path.join(os.tmpdir(), "12t-bible-backups"); fs.mkdirSync(dir, { recursive: true });
      const bak = path.join(dir, "index." + Date.now() + ".bak"); fs.copyFileSync(INDEX_FILE, bak);
      fs.writeFileSync(ASSETS_FILE, out.assets); fs.writeFileSync(INDEX_FILE, out.html);
      console.log(`split: moved ${out.report.moved} lines; assets.js ${mb(Buffer.byteLength(out.assets))}; index.html ${mb(Buffer.byteLength(html))} -> ${mb(Buffer.byteLength(out.html))}, data: URIs left ${(dataUriBytes(out.html) / 1024).toFixed(0)} KB; stamp ${TAG_RE.exec(out.html)[1]}; backup ${bak}`);
      console.log("kept aliases:\n  " + (out.report.keptAliases.join("\n  ") || "(none)"));
      console.log("readers between a declaration and its last moved assignment:\n  " + (out.report.readersBetween.join("\n  ") || "(none)"));
    }
    else if (cmd === "stamp"){
      const html = fs.readFileSync(INDEX_FILE, "utf8"), buf = fs.readFileSync(ASSETS_FILE), next = stamp(html, buf);
      if (next !== html) fs.writeFileSync(INDEX_FILE, next);
      console.log(`assets.js stamp ${stampOf(buf)}` + (next !== html ? " (index.html updated)" : " (already current)"));
    }
    else { console.error("usage: see the header of scripts/bible_assets.js"); process.exit(2); }
  } catch (e){ console.error("bible_assets: " + e.message); process.exit(1); }
}
