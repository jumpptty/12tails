#!/usr/bin/env node
// Class guide manager (user 2026-10-20): add, replace or remove a guide in ไกด์อาชีพ without a Claude session.
// With no arguments (or by double-clicking scripts/add_guide.cmd) it opens a page in the browser, served from this PC only: 127.0.0.1, a key made
// at start-up on every request, and the Host and Origin checked, so no web page can drive it.
// Every change goes through one pipeline: edit CLASS_GUIDES in 12t_projects/bible/index.html (one JSON object per line, CLASS-GUIDES.md), refresh
// CLASS_GUIDE_VIEWS, prepend the changelog entry (also the commit subject), run the full validator (which also checks that a build is legal), then
// commit and push. Any failure before the commit puts index.html back exactly as it was. It refuses while index.html has uncommitted work.
// * add: the next running id. * replace: the guide keeps its id (its link and view count), everything else comes from the new code.
// * remove: the line becomes "// #N removed <date>: <title> by <author>", so the number is never given out again (ids are never reused).
// * undo (page button or Ctrl+Z): the last change made since start-up is reversed the same way (an added guide is removed, a removed or
//   replaced one comes back).
//
//   node scripts/add_guide.js                       the page (--port <n>, --no-open)
//   node scripts/add_guide.js add <code>            the same pipeline on the command line (a bare code also means add)
//   node scripts/add_guide.js replace <N> <code>
//   node scripts/add_guide.js delete <N>
//     --dry-run   check everything, then put index.html back: no commit, no push
//     --no-push   commit, but do not push (also for the page)
//     --yes       do not ask before publishing
//     --modes pve,pvp   the guide's PVE / PVP tag when the code has none (or to change it)
"use strict";
const fs = require("fs"), path = require("path"), os = require("os"), http = require("http"), crypto = require("crypto"), readline = require("readline");
const { execFileSync, spawn } = require("child_process");
const { decode } = require("./guide_code.js");

const ROOT = path.resolve(__dirname, ".."), REL = "12t_projects/bible/index.html", FILE = path.join(ROOT, REL);
const SITE = "https://jumpptty.github.io/12tails/12t_projects/bible/";
const SERVER = { og: "BB", tot: "ToT", tto: "TTO" };
const args = process.argv.slice(2), has = (f) => args.includes(f), val = (f) => { const i = args.indexOf(f); return i >= 0 ? args[i + 1] : undefined; };
const NO_PUSH = has("--no-push");
const git = (...a) => execFileSync("git", a, { cwd: ROOT, encoding: "utf8", stdio: ["ignore", "pipe", "pipe"] }).trim();
const cap = (s) => String(s).charAt(0).toUpperCase() + String(s).slice(1);
const clean = (s) => String(s).replace(/[<>\r\n]/g, " ").replace(/\s+/g, " ").trim();
const subj = (s) => s.replace(/\*\*|["\\<>]/g, "").replace(/\s+/g, " ").trim();   // the changelog entry is compared with the commit subject character for character
const label = (g) => `${SERVER[g.build.server] || g.build.server} ${cap(g.build.classKey)} ${g.title} by ${g.author}`;
const today = () => new Date().toISOString().slice(0, 10);
const MODES = ["pve", "pvp"], pickModes = (v) => MODES.filter((m) => Array.isArray(v) && v.includes(m));   // PVE / PVP, both allowed; a finished guide needs one (user 2026-10-20)

// ---------- reading and changing CLASS_GUIDES ----------
function readGuides(){
  const html = fs.readFileSync(FILE, "utf8"), eol = html.includes("\r\n") ? "\r\n" : "\n";
  const open = "const CLASS_GUIDES = [" + eol, start = html.indexOf(open), end = start < 0 ? -1 : html.indexOf(eol + "];", start);
  if (end < 0) throw new Error("CLASS_GUIDES was not found in " + REL);
  const lines = html.slice(start + open.length, end).split(eol), guides = [], removed = [];
  lines.forEach((l, at) => {
    const t = l.trim(), r = t.match(/^\/\/ #(\d+) removed/);
    if (t.startsWith("{")) guides.push({ at, g: JSON.parse(t.replace(/,$/, "")) });
    else if (r) removed.push({ at, id: +r[1], text: t.slice(3) });
  });
  return { html, eol, head: html.slice(0, start + open.length), tail: html.slice(end), lines, guides, removed };
}
const nextId = (doc) => Math.max(0, ...doc.guides.map((x) => x.g.id), ...doc.removed.map((x) => x.id)) + 1;
const guideLine = (id, g) => "  " + JSON.stringify({ id, ...g }).replace(/</g, "\\u003c") + ",";   // no "</script>" or "<!--" inside the page script
const tombLine = (id, g) => `  // #${id} removed ${today()}: ${clean(g.title)} by ${clean(g.author)}`;
const lineAt = (doc, id) => doc.lines.findIndex((l) => { const t = l.trim(); return t.startsWith(`{"id":${id},`) || t.startsWith(`// #${id} removed`); });
function findCode(text){ return (String(text || "").match(/(?:TG2|12TG1)\.[A-Za-z0-9_-]+/) || [])[0]; }
function decodeCode(text){
  const code = findCode(text);
  if (!code) throw new Error("ไม่พบโค้ดไกด์ (ขึ้นต้นด้วย TG2.)");
  let g;
  try { g = decode(code); }
  catch (e){ throw new Error("อ่านโค้ดไม่ได้ (" + e.message + "). ถ้าโค้ดถูกส่งทาง Discord นอกกล่องโค้ด เครื่องหมาย _ อาจหายไปเพราะกลายเป็นตัวเอียง ขอให้ผู้เขียนส่งใหม่ในกล่องโค้ด (```)"); }
  if (!g || g.format !== "12t-class-guide" || !g.build || !g.title || !g.author) throw new Error("โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ");
  return g;
}
// What a change does to the lines: { id, lines, subject, undo } (undo = how to take it back; none for an undo itself).
function plan(op, doc){
  const lines = doc.lines.slice(), byId = (id) => doc.guides.find((x) => x.g.id === id);
  if (op.action === "add"){
    const g = op.guide, same = doc.guides.find((x) => x.g.title === g.title && x.g.author === g.author);
    if (same) throw new Error(`ไกด์นี้มีอยู่แล้วเป็น #${same.g.id} (ชื่อและผู้เขียนเดียวกัน) ใช้ "แทนที่" แทน`);
    const id = nextId(doc); lines.push(guideLine(id, g));
    return { id, lines, subject: subj(`feat(bible): class guide #${id} ${label(g)}`), undo: { id, before: null, g, text: `ลบไกด์ #${id} ที่เพิ่งเพิ่ม` } };
  }
  if (op.action === "replace" || op.action === "delete"){
    const t = byId(op.id); if (!t) throw new Error(`ไม่มีไกด์ #${op.id}`);
    if (op.action === "replace"){
      lines[t.at] = guideLine(op.id, op.guide);
      return { id: op.id, lines, subject: subj(`fix(bible): class guide #${op.id} is updated: ${label(op.guide)}`), undo: { id: op.id, before: doc.lines[t.at], g: op.guide, text: `คืนไกด์ #${op.id} เป็นฉบับก่อนแทนที่` } };
    }
    lines[t.at] = tombLine(op.id, t.g);
    return { id: op.id, lines, subject: subj(`fix(bible): class guide #${op.id} is removed (${t.g.title} by ${t.g.author})`), undo: { id: op.id, before: doc.lines[t.at], g: t.g, text: `คืนไกด์ #${op.id} ที่เพิ่งลบ` } };
  }
  if (op.action === "undo"){
    const u = op.entry, at = lineAt(doc, u.id); if (at < 0) throw new Error(`ไม่พบไกด์ #${u.id} ในไฟล์`);
    const wasTomb = lines[at].trim().startsWith("//");
    lines[at] = u.before === null ? tombLine(u.id, u.g) : u.before;
    const what = u.before === null ? `is removed again (undo of its addition: ${u.g.title} by ${u.g.author})` : wasTomb ? `is restored (${u.g.title} by ${u.g.author})` : "is back to its previous version";
    return { id: u.id, lines, subject: subj(`fix(bible): class guide #${u.id} ${what}`), undo: null };
  }
  throw new Error("unknown action " + op.action);
}

// ---------- the pipeline ----------
function preflight(push){
  if (git("status", "--porcelain", "--", REL)) throw new Error("index.html มีงานค้างที่ยังไม่ได้ commit (เช่นงานของ Claude) รอให้งานนั้นเสร็จหรือ commit ก่อน แล้วลองใหม่");
  const branch = git("rev-parse", "--abbrev-ref", "HEAD");
  if (branch === "HEAD") throw new Error("โฟลเดอร์นี้ไม่ได้อยู่บน branch");
  if (push){   // start from what GitHub has, so the push is a plain fast-forward
    try { git("fetch", "-q", "origin", branch); } catch (e){ throw new Error("ต่อ GitHub ไม่ได้: " + e.message.split("\n")[0]); }
    const [behind, ahead] = git("rev-list", "--left-right", "--count", `origin/${branch}...HEAD`).split(/\s+/).map(Number);
    if (behind && ahead) throw new Error("branch ในเครื่องกับบน GitHub ต่างกันทั้งสองฝั่ง ให้ git pull ก่อน");
    if (behind) git("merge", "-q", "--ff-only", `origin/${branch}`);
  }
  return branch;
}
const runNode = (file, extra) => new Promise((res) => {
  const p = spawn(process.execPath, [path.join(ROOT, file), ...extra], { cwd: ROOT });
  let out = ""; p.stdout.on("data", (d) => out += d); p.stderr.on("data", (d) => out += d);
  p.on("close", (status) => res({ status, out }));
});
// Google Drive, Defender or another git (VS Code) can hold a file in .git for a moment, and git outside a terminal gives up after ~70 ms
// ("unable to write file .git/objects/..: Permission denied", "index.lock"): wait and try again.
async function gitRetry(ui, ...a){
  for (let i = 1; ; i++){
    try { return git(...a); }
    catch (e){
      if (!/Permission denied|unable to (write|create)|\.lock/i.test(e.message)) throw e;
      if (i === 4) throw new Error("git เขียนไฟล์ในโฟลเดอร์ .git ไม่ได้ (มีโปรแกรมอื่นจับไฟล์ไว้ เช่น Google Drive, Defender หรือ VS Code) ยังไม่ได้อัปอะไรขึ้น และ index.html กลับเป็นเหมือนเดิมแล้ว ลองใหม่อีกครั้ง\n" + e.message.trim().split("\n").slice(-2).join("\n"));
      ui.log(`git ${a[0]}: มีโปรแกรมอื่นจับไฟล์ใน .git อยู่ รอแล้วลองใหม่ (${i + 1}/4)`);
      await new Promise((r) => setTimeout(r, 2000 * i));
    }
  }
}
// ui = { step(key, text, state), log(text) }; resolves to { id, subject, url, undo, dry }
async function apply(op, { dryRun = false, noPush = NO_PUSH } = {}, ui){
  ui.step("git", "ตรวจสถานะ git", "run");
  const branch = preflight(!dryRun && !noPush), doc = readGuides(), p = plan(op, doc);
  ui.step("git", "ตรวจสถานะ git", "ok");
  ui.step("edit", "แก้ไฟล์ index.html", "run");
  const dir = path.join(os.tmpdir(), "12t-bible-backups"); fs.mkdirSync(dir, { recursive: true });
  const backup = path.join(dir, "index." + Date.now() + ".bak"); fs.copyFileSync(FILE, backup);
  let committed = false;
  try {
    let out = doc.head + p.lines.join(doc.eol) + doc.tail;
    const top = "  entries: [" + doc.eol, at = out.indexOf(top, out.indexOf("const CHANGELOG_DATA = {"));
    if (at < 0) throw new Error("CHANGELOG_DATA was not found in " + REL);
    out = out.slice(0, at + top.length) + "    " + JSON.stringify([new Date().toISOString(), p.subject]) + "," + doc.eol + out.slice(at + top.length);
    fs.writeFileSync(FILE, out);
    ui.step("edit", "แก้ไฟล์ index.html", "ok");
    ui.step("views", "อัปเดตยอดเข้าชม", "run");
    const v = await runNode("scripts/guide_views.js", []);
    ui.step("views", v.status === 0 ? "อัปเดตยอดเข้าชม" : "อัปเดตยอดเข้าชม (ใช้ตัวเลขเดิม)", v.status === 0 ? "ok" : "warn");
    ui.step("check", "ตรวจด้วย validator", "run");
    const c = await runNode("scripts/validate_skills.js", ["--full"]);
    if (c.status !== 0){
      ui.step("check", "ตรวจด้วย validator", "fail");
      const lines = c.out.split(/\r?\n/).filter((l) => /ERROR|Error/.test(l));
      ui.log((lines.length ? lines : c.out.trim().split(/\r?\n/).slice(-12)).slice(0, 14).join("\n"));
      throw new Error("ไกด์ไม่ผ่านการตรวจ จึงไม่ได้อัปอะไรขึ้น และ index.html กลับเป็นเหมือนเดิมแล้ว");
    }
    ui.step("check", "ตรวจด้วย validator", "ok");
    if (dryRun){ fs.copyFileSync(backup, FILE); return { ...p, url: SITE + "#class-guide/" + p.id, dry: true }; }
    ui.step("commit", "commit", "run");
    const msg = path.join(dir, "commit-msg.txt"); fs.writeFileSync(msg, p.subject + "\n");
    await gitRetry(ui, "add", "--", REL); await gitRetry(ui, "commit", "-q", "-F", msg); committed = true;
    ui.step("commit", "commit", "ok");
    if (noPush) return { ...p, url: SITE + "#class-guide/" + p.id };
    ui.step("push", "อัปขึ้น GitHub", "run");
    try { git("push", "-q", "origin", branch); } catch (e) {}   // the local tracking ref sometimes fails to update here; what counts is what GitHub has
    const sha = git("rev-parse", "HEAD"), remote = git("ls-remote", "origin", "refs/heads/" + branch).split(/\s+/)[0];
    if (remote !== sha){ ui.step("push", "อัปขึ้น GitHub", "fail"); throw new Error("commit ในเครื่องแล้ว แต่อัปขึ้น GitHub ไม่สำเร็จ ลองใหม่ภายหลังด้วย git push"); }
    try { git("update-ref", "refs/remotes/origin/" + branch, sha); } catch (e) {}
    ui.step("push", "อัปขึ้น GitHub", "ok");
    return { ...p, url: SITE + "#class-guide/" + p.id };
  } catch (e){
    if (!committed){ try { git("reset", "-q", "--", REL); } catch (_) {} fs.copyFileSync(backup, FILE); }   // unstage too, or a failed commit leaves the new index.html staged
    throw e;
  }
}

// ---------- command line ----------
async function cli(words){
  const ask = (q) => new Promise((res) => { const rl = readline.createInterface({ input: process.stdin, output: process.stdout }); rl.question(q, (a) => { rl.close(); res(a); }); });
  let [cmd, ...rest] = words, op;
  if (findCode(cmd)){ rest = [cmd, ...rest]; cmd = "add"; }
  if (cmd === "add") op = { action: "add", guide: decodeCode(rest.join(" ") || await ask("Paste the guide code: ")) };
  else if (cmd === "replace") op = { action: "replace", id: +rest[0], guide: decodeCode(rest.slice(1).join(" ") || await ask("Paste the new code: ")) };
  else if (cmd === "delete") op = { action: "delete", id: +rest[0] };
  if (op && op.guide){ if (val("--modes")) op.guide.modes = pickModes(val("--modes").split(",").map((x) => x.trim().toLowerCase())); if (!(op.guide.modes || []).length) throw new Error("This code has no PVE / PVP tag (made with an older page). Add --modes pve, --modes pvp or --modes pve,pvp."); }
  else throw new Error("usage: see the header of scripts/add_guide.js");
  const p = plan(op, readGuides());
  console.log("\n  " + p.subject + "\n");
  if (!has("--dry-run") && !has("--yes") && !/^y/i.test((await ask("Publish this? (y/n) ")).trim())) throw new Error("Cancelled. Nothing was changed.");
  const r = await apply(op, { dryRun: has("--dry-run") }, { step: (k, text, st) => { if (st !== "run") console.log((st === "ok" ? "  ok   " : st === "warn" ? "  !!   " : "  FAIL ") + text); }, log: (t) => console.log("    " + t.replace(/\n/g, "\n    ")) });
  console.log(r.dry ? `\n✓ #${r.id} passed every check (dry run: index.html is back as it was).` : `\n✓ Done: ${r.subject}\n  ${r.url}`);
}

// ---------- the page ----------
function pageData(){
  const doc = readGuides(), html = doc.html, views = (() => { try { return JSON.parse((html.match(/^const CLASS_GUIDE_VIEWS = (\{.*?\});/m) || [])[1]).counts || {}; } catch (e){ return {}; } })();
  let faces = {}; try { faces = JSON.parse((html.match(/^const CLASS_HERO_ICONS = (\{.*?\});/m) || [])[1]); } catch (e) {}
  let dirty = false, branch = "?"; try { dirty = !!git("status", "--porcelain", "--", REL); branch = git("rev-parse", "--abbrev-ref", "HEAD"); } catch (e) {}
  return {
    branch, dirty, next: nextId(doc), push: !NO_PUSH, faces,
    guides: doc.guides.map(({ g }) => ({ id: g.id, modes: g.modes || [], title: g.title, author: g.author, classKey: g.build.classKey, server: g.build.server, level: g.build.level, date: g.date || "", views: views[g.id] || 0 })).sort((a, b) => b.id - a.id),
    removed: doc.removed.map((r) => r.text).reverse(),
  };
}
function serve(){
  const key = crypto.randomBytes(18).toString("hex"), port = +val("--port") || 4782, undos = [];
  let busy = false;
  const body = (req) => new Promise((res, rej) => { let s = ""; req.on("data", (d) => { s += d; if (s.length > 400000) req.destroy(); }); req.on("end", () => { try { res(JSON.parse(s || "{}")); } catch (e){ rej(e); } }); });
  const json = (res, code, obj) => { res.writeHead(code, { "Content-Type": "application/json; charset=utf-8", "Cache-Control": "no-store" }); res.end(JSON.stringify(obj)); };
  const server = http.createServer(async (req, res) => {
    const host = req.headers.host || "";
    if (host !== "127.0.0.1:" + port && host !== "localhost:" + port){ res.writeHead(403); res.end(); return; }
    if (req.method === "GET" && (req.url === "/" || req.url.startsWith("/?"))){
      res.writeHead(200, { "Content-Type": "text/html; charset=utf-8", "Cache-Control": "no-store", "X-Frame-Options": "DENY" });
      res.end(PAGE.replace("__KEY__", key)); return;
    }
    if (req.headers["x-key"] !== key || (req.headers.origin && req.headers.origin !== "http://" + host)){ res.writeHead(403); res.end(); return; }
    try {
      if (req.method === "GET" && req.url === "/api/state") return json(res, 200, { ...pageData(), busy, undo: undos.length ? undos[undos.length - 1].text : null });
      if (req.method === "POST" && req.url === "/api/check"){
        const b = await body(req), doc = readGuides();
        try {
          const g = decodeCode(b.code), same = doc.guides.find((x) => x.g.title === g.title && x.g.author === g.author && x.g.id !== +b.replaceId);
          return json(res, 200, { ok: true, guide: { modes: g.modes || [], title: g.title, author: g.author, classKey: g.build.classKey, server: g.build.server, level: g.build.level, date: g.date || "" }, id: b.replaceId ? +b.replaceId : nextId(doc), duplicate: same ? { id: same.g.id, title: same.g.title } : null });
        } catch (e){ return json(res, 200, { ok: false, error: e.message }); }
      }
      if (req.method === "POST" && (req.url === "/api/run" || req.url === "/api/undo")){
        if (busy) return json(res, 409, { error: "กำลังทำงานอื่นอยู่" });
        const b = await body(req);
        let op;
        if (req.url === "/api/undo"){ if (!undos.length) return json(res, 400, { error: "ไม่มีอะไรให้ย้อนกลับ" }); op = { action: "undo", entry: undos[undos.length - 1] }; }
        else if (b.action === "delete") op = { action: "delete", id: +b.id };
        else {
          const g = decodeCode(b.code); if (Array.isArray(b.modes)) g.modes = pickModes(b.modes);
          if (!(g.modes || []).length) return json(res, 400, { error: "เลือก PVE / PVP อย่างน้อยหนึ่งอย่าง" });
          op = { action: b.action === "replace" ? "replace" : "add", id: +b.id, guide: g };
        }
        busy = true;
        res.writeHead(200, { "Content-Type": "application/x-ndjson; charset=utf-8", "Cache-Control": "no-store", "X-Content-Type-Options": "nosniff" });
        const send = (o) => res.write(JSON.stringify(o) + "\n");
        try {
          const r = await apply(op, { dryRun: !!b.dryRun }, { step: (k, text, state) => send({ type: "step", key: k, text, state }), log: (text) => send({ type: "log", text }) });
          if (!r.dry){ if (op.action === "undo") undos.pop(); else if (r.undo) undos.push(r.undo); }
          send({ type: "done", ok: true, dry: !!r.dry, id: r.id, subject: r.subject, url: r.url, action: op.action });
        } catch (e){ send({ type: "done", ok: false, error: e.message }); }
        busy = false; res.end(); return;
      }
      json(res, 404, { error: "not found" });
    } catch (e){ busy = false; if (!res.headersSent) json(res, 500, { error: e.message }); else res.end(); }
  });
  const url = "http://127.0.0.1:" + port + "/";
  const open = () => { if (has("--no-open")) return; const c = process.platform === "win32" ? ["explorer.exe", [url]] : process.platform === "darwin" ? ["open", [url]] : ["xdg-open", [url]]; try { spawn(c[0], c[1], { detached: true, stdio: "ignore" }).unref(); } catch (e) {} };
  server.on("error", (e) => { if (e.code === "EADDRINUSE"){ console.log("The guide manager is already running: " + url); open(); process.exit(0); } throw e; });
  server.listen(port, "127.0.0.1", () => { console.log("Class guide manager: " + url + "\nClose this window to stop it."); open(); });
}

const PAGE = String.raw`<!doctype html>
<html lang="th">
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Guide Manager</title>
<link rel="icon" type="image/svg+xml" href="data:image/svg+xml,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%228%20-10%20110%20110%22%3E%3Cpath%20d%3D%22M14%2024%20L30%2012%20L30%2078M48%2030%20C48%2012%2078%2010%2080%2028%20C82%2044%2060%2054%2048%2078%20L82%2078%20C98%2078%20106%2066%20102%2052%22%20fill%3D%22none%22%20stroke%3D%22%23d4af37%22%20stroke-width%3D%2210%22%20stroke-linecap%3D%22round%22%20stroke-linejoin%3D%22round%22%2F%3E%3C%2Fsvg%3E">
<link rel="preconnect" href="https://fonts.googleapis.com"><link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Prompt:wght@300;400;500;600;700&family=JetBrains+Mono:wght@500;700&display=swap" rel="stylesheet">
<style>
  :root{--ink:#150f0c; --panel:#1f1712; --panel-2:#271c15; --line:#4a3a26; --text:#ece4d6; --muted:#b0a189; --gold:#c9a227; --gold-hi:#f1d27a; --seal:#c2503c; --pro:#7fcf8a; --num:'JetBrains Mono','Prompt',monospace}
  *{box-sizing:border-box}
  [hidden]{display:none !important}
  html,body{margin:0; height:100%; background:var(--ink); color:var(--text); font:400 15px/1.5 'Prompt',system-ui,sans-serif}
  button,input,textarea{font:inherit; color:inherit}
  :focus-visible{outline:2px solid var(--gold); outline-offset:2px}
  .app{height:100%; display:grid; grid-template-rows:auto auto minmax(0,1fr)}
  header{display:flex; align-items:center; gap:14px; padding:14px 24px; border-bottom:1px solid var(--line); background:linear-gradient(180deg,#1d1510,var(--ink))}
  .logo{width:34px; height:34px}
  header h1{margin:0; font-size:19px; font-weight:700; letter-spacing:.01em}
  header h1 small{display:block; font-size:12px; font-weight:400; color:var(--muted)}
  .pill{display:inline-flex; align-items:center; gap:8px; margin-left:auto; padding:6px 12px; border:1px solid var(--line); border-radius:999px; font-size:13px; color:var(--muted)}
  .pill i{width:8px; height:8px; border-radius:50%; background:var(--pro)}
  .pill.is-warn i{background:var(--seal)}
  .btn{display:inline-flex; align-items:center; justify-content:center; gap:8px; padding:9px 16px; border:1px solid var(--line); border-radius:10px; background:transparent; cursor:pointer; transition:border-color .15s, color .15s, background .15s}
  .btn:hover:not(:disabled){border-color:var(--gold); color:var(--gold-hi)}
  .btn:disabled{opacity:.4; cursor:not-allowed}
  .btn-gold{border-color:transparent; background:linear-gradient(180deg,#e2c25a,var(--gold)); color:#1a1205; font-weight:600}
  .btn-gold:hover:not(:disabled){color:#1a1205; filter:brightness(1.08)}
  .btn-red{border-color:transparent; background:var(--seal); color:#fff; font-weight:600}
  .btn-red:hover:not(:disabled){color:#fff; filter:brightness(1.1)}
  .btn-sm{padding:5px 11px; font-size:13px; border-radius:8px}
  .undo{display:none}
  .undo.is-on{display:inline-flex}
  .banner{display:none; margin:0; padding:10px 24px; background:color-mix(in srgb,var(--seal) 18%,transparent); border-bottom:1px solid color-mix(in srgb,var(--seal) 50%,transparent); font-size:14px}
  .banner.is-on{display:flex; align-items:center; gap:12px}
  main{min-height:0; display:grid; grid-template-columns:minmax(360px,460px) minmax(0,1fr); gap:20px; padding:20px 24px}
  .col{min-height:0; display:flex; flex-direction:column; gap:16px}
  .card{background:var(--panel); border:1px solid var(--line); border-radius:14px; padding:18px}
  .card h2{margin:0 0 12px; font-size:16px; font-weight:600; color:var(--gold-hi); display:flex; align-items:center; gap:10px}
  .card h2 .x{margin-left:auto}
  textarea{width:100%; min-height:110px; resize:vertical; padding:12px; border:1px solid var(--line); border-radius:10px; background:var(--ink); font:500 12.5px/1.5 var(--num); word-break:break-all}
  textarea::placeholder{font-family:'Prompt',sans-serif; color:var(--muted)}
  .preview{display:none; margin-top:14px; padding:14px; border:1px solid var(--line); border-radius:12px; background:var(--panel-2)}
  .preview.is-on{display:grid; grid-template-columns:56px minmax(0,1fr); gap:14px; align-items:center}
  .face{display:block; width:56px; height:56px; border-radius:50%; background:var(--ink) center / cover no-repeat; box-shadow:0 0 0 2px var(--gold)}
  .preview b{display:block; font-size:16px; line-height:1.35}
  .meta{display:flex; flex-wrap:wrap; gap:6px; margin-top:6px}
  .chip{padding:1px 9px; border:1px solid var(--line); border-radius:999px; font-size:12px; color:var(--muted)}
  .chip.num{font-family:var(--num); color:var(--gold-hi); border-color:color-mix(in srgb,var(--gold) 50%,transparent)}
  .msg{display:none; margin-top:12px; padding:10px 12px; border-radius:10px; font-size:13.5px}
  .msg.is-on{display:block}
  .msg.err{background:color-mix(in srgb,var(--seal) 16%,transparent); border:1px solid color-mix(in srgb,var(--seal) 45%,transparent)}
  .msg.warn{background:color-mix(in srgb,var(--gold) 12%,transparent); border:1px solid color-mix(in srgb,var(--gold) 40%,transparent)}
  .msg .btn{margin-top:8px}
  .modes{display:flex; flex-wrap:wrap; align-items:center; gap:8px; margin-top:12px; font-size:13.5px; color:var(--muted)}
  .modes[hidden]{display:none}
  .mbtn{min-width:64px; padding:6px 14px; border:1px solid var(--line); border-radius:8px; background:var(--ink); font-weight:600; letter-spacing:.03em; cursor:pointer}
  .mbtn[aria-pressed="true"]{border-color:var(--gold); background:color-mix(in srgb,var(--gold) 18%,var(--ink)); color:var(--gold-hi)}
  .modes small{flex-basis:100%; color:#f0b3a6}
  .row-actions{display:flex; align-items:center; gap:12px; margin-top:14px}
  .row-actions .btn-gold{flex:1}
  .chk{display:flex; align-items:center; gap:6px; font-size:13px; color:var(--muted); cursor:pointer}
  .steps{list-style:none; margin:0; padding:0; display:grid; gap:8px}
  .steps li{display:flex; align-items:center; gap:10px; font-size:14px; color:var(--muted)}
  .steps li.run, .steps li.ok, .steps li.fail, .steps li.warn{color:var(--text)}
  .dot{flex:none; width:20px; height:20px; border-radius:50%; display:grid; place-items:center; font-size:12px; border:1px solid var(--line)}
  .ok .dot{background:var(--pro); border-color:var(--pro); color:#0d1a10}
  .warn .dot{background:var(--gold); border-color:var(--gold); color:#1a1205}
  .fail .dot{background:var(--seal); border-color:var(--seal); color:#fff}
  .run .dot{border:2px solid var(--gold); border-top-color:transparent; animation:spin .8s linear infinite}
  @keyframes spin{to{transform:rotate(360deg)}}
  .t{margin-left:auto; font:500 12px var(--num); color:var(--muted)}
  .result{margin-top:14px; font-size:14px}
  .result a{color:var(--gold-hi)}
  pre.log{display:none; margin:12px 0 0; padding:10px; max-height:180px; overflow:auto; border-radius:8px; background:var(--ink); border:1px solid var(--line); font:500 12px/1.5 var(--num); white-space:pre-wrap; color:#f0b3a6}
  pre.log.is-on{display:block}
  .list-card{min-height:0; display:flex; flex-direction:column}
  .list-head{display:flex; align-items:center; gap:12px; margin-bottom:12px}
  .list-head h2{margin:0}
  .search{margin-left:auto; width:min(320px,50%); padding:8px 12px; border:1px solid var(--line); border-radius:10px; background:var(--ink)}
  .list{list-style:none; margin:0; padding:0 4px 0 0; overflow:auto; min-height:0; flex:1; display:grid; align-content:start; gap:6px}
  .row{display:grid; grid-template-columns:52px 40px minmax(0,1fr) auto auto; align-items:center; gap:12px; padding:8px 10px; border:1px solid transparent; border-radius:10px; background:var(--panel-2)}
  .row:hover{border-color:var(--line)}
  .row.is-target{border-color:var(--gold)}
  .row .no{font:700 14px var(--num); color:var(--gold-hi)}
  .row .face{width:40px; height:40px; box-shadow:0 0 0 1.5px var(--gold)}
  .row .tt{min-width:0}
  .row .tt b{display:block; font-weight:500; white-space:nowrap; overflow:hidden; text-overflow:ellipsis}
  .row .tt small{display:block; color:var(--muted); font-size:12.5px; white-space:nowrap; overflow:hidden; text-overflow:ellipsis}
  .views{font:500 12.5px var(--num); color:var(--muted); white-space:nowrap}
  .acts{display:flex; gap:6px}
  .acts .del:hover:not(:disabled){border-color:var(--seal); color:#f0b3a6}
  details.gone{margin-top:12px; color:var(--muted); font-size:13px}
  details.gone summary{cursor:pointer}
  details.gone li{margin:4px 0}
  .empty{padding:24px; text-align:center; color:var(--muted)}
  .modal{position:fixed; inset:0; display:none; place-items:center; background:rgba(8,6,4,.7); z-index:10}
  .modal.is-on{display:grid}
  .modal .card{width:min(460px,92vw)}
  .modal p{margin:0 0 16px; color:var(--muted)}
  .modal p b{color:var(--text)}
  .modal .row-actions{justify-content:flex-end}
  .modal .row-actions .btn-gold, .modal .row-actions .btn-red{flex:none}
  @media (max-width:900px){ main{grid-template-columns:minmax(0,1fr)} .app{height:auto} .list{overflow:visible} }
</style>
</head>
<body>
<div class="app">
  <header>
    <svg class="logo" viewBox="8 -10 110 110" aria-hidden="true"><defs><linearGradient id="g" x1="0" y1="0" x2="1" y2="1"><stop offset="0" stop-color="#f6df98"/><stop offset=".55" stop-color="#d4af37"/><stop offset="1" stop-color="#9a7622"/></linearGradient></defs><g fill="none" stroke="url(#g)" stroke-width="10" stroke-linecap="round" stroke-linejoin="round"><path d="M14 24 L30 12 L30 78"/><path d="M48 30 C48 12 78 10 80 28 C82 44 60 54 48 78 L82 78 C98 78 106 66 102 52"/></g><path d="M102 52 C96 40 102 26 116 22 C110 34 114 44 102 52Z" fill="url(#g)"/></svg>
    <h1>จัดการไกด์อาชีพ<small>เพิ่ม แทนที่ หรือลบไกด์ แล้วอัปขึ้น GitHub ให้เอง</small></h1>
    <span class="pill" id="pill"><i></i><span id="pillText">กำลังโหลด…</span></span>
    <button type="button" class="btn btn-sm undo" id="undoBtn" title="Ctrl+Z">↶ <span id="undoText"></span></button>
  </header>
  <p class="banner" id="banner"><span>index.html มีงานค้างที่ยังไม่ได้ commit (เช่นงานของ Claude) จึงยังทำรายการไม่ได้ รอให้งานนั้นเสร็จก่อน</span><button type="button" class="btn btn-sm" id="recheck">ตรวจใหม่</button></p>
  <main>
    <div class="col">
      <section class="card" id="editor">
        <h2 id="edTitle">เพิ่มไกด์ใหม่<button type="button" class="btn btn-sm x" id="cancelReplace" hidden>ยกเลิก</button></h2>
        <textarea id="code" placeholder="วางโค้ดไกด์ที่นี่ (TG2.…) จะวางทั้งข้อความที่ได้รับมาก็ได้" spellcheck="false"></textarea>
        <div class="preview" id="preview"><span class="face" id="pvFace"></span><div><b id="pvTitle"></b><span id="pvBy"></span><div class="meta" id="pvMeta"></div></div></div>
        <div class="msg" id="msg"></div>
        <div class="modes" id="modes" hidden><span>ไกด์นี้สำหรับ</span><button type="button" class="mbtn" data-m="pve" aria-pressed="false">PVE</button><button type="button" class="mbtn" data-m="pvp" aria-pressed="false">PVP</button><small id="modesHint"></small></div>
        <div class="row-actions"><label class="chk"><input type="checkbox" id="dry"> ตรวจอย่างเดียว</label><button type="button" class="btn btn-gold" id="go" disabled>เพิ่มและอัปขึ้น GitHub</button></div>
      </section>
      <section class="card" id="progress" hidden>
        <h2 id="progTitle">กำลังทำงาน</h2>
        <ul class="steps" id="steps"></ul>
        <div class="result" id="result"></div>
        <pre class="log" id="log"></pre>
      </section>
    </div>
    <section class="card list-card">
      <div class="list-head"><h2>ไกด์ทั้งหมด <span class="chip num" id="count">0</span></h2><input class="search" id="search" type="search" placeholder="ค้นหา ชื่อ ผู้เขียน อาชีพ หรือ #เลข"></div>
      <ul class="list" id="list"></ul>
      <details class="gone" id="gone" hidden><summary>ไกด์ที่ลบแล้ว</summary><ul id="goneList"></ul></details>
    </section>
  </main>
</div>
<div class="modal" id="modal" role="dialog" aria-modal="true" aria-labelledby="mdTitle"><div class="card"><h2 id="mdTitle"></h2><p id="mdText"></p><div class="row-actions"><button type="button" class="btn" id="mdNo">ยกเลิก</button><button type="button" class="btn" id="mdYes"></button></div></div></div>
<script>
const KEY = "__KEY__", SRV = { og: "BB", tot: "ToT", tto: "TTO" }, STEPS = ["git", "edit", "views", "check", "commit", "push"];
const $ = (s) => document.querySelector(s);
let state = null, mode = { kind: "add" }, check = null, checkTimer = 0, running = false, timer = 0;
const api = (url, data) => fetch(url, { method: data ? "POST" : "GET", headers: { "X-Key": KEY, "Content-Type": "application/json" }, body: data ? JSON.stringify(data) : undefined });
const esc = (s) => String(s == null ? "" : s).replace(/[&<>"']/g, (c) => ({ "&": "&amp;", "<": "&lt;", ">": "&gt;", '"': "&quot;", "'": "&#39;" })[c]);
const dmy = (d) => /^\d{4}-\d{2}-\d{2}$/.test(d) ? d.slice(8) + "/" + d.slice(5, 7) + "/" + d.slice(0, 4) : (d || "ไม่ระบุวัน");
const face = (cls) => (state && state.faces[cls.charAt(0).toUpperCase() + cls.slice(1)]) || "";
const cap = (s) => s.charAt(0).toUpperCase() + s.slice(1);
async function load(){
  try { state = await (await api("/api/state")).json(); } catch (e){ $("#pillText").textContent = "ติดต่อตัวจัดการไม่ได้ (ปิดหน้าต่างดำไปแล้ว?)"; $("#pill").classList.add("is-warn"); return; }
  $("#pillText").textContent = state.branch + (state.dirty ? " · มีงานค้าง" : state.push ? " · พร้อม" : " · ไม่อัปขึ้น GitHub");
  $("#pill").classList.toggle("is-warn", state.dirty);
  $("#banner").classList.toggle("is-on", state.dirty);
  $("#undoBtn").classList.toggle("is-on", !!state.undo);
  $("#undoText").textContent = state.undo ? "ย้อนกลับ: " + state.undo : "";
  renderList(); syncGo();
}
function renderList(){
  const q = $("#search").value.trim().toLowerCase().replace(/^#/, "");
  const rows = state.guides.filter((g) => !q || String(g.id) === q || (g.title + " " + g.author + " " + g.classKey + " " + SRV[g.server]).toLowerCase().includes(q));
  $("#count").textContent = state.guides.length;
  $("#list").innerHTML = rows.length ? rows.map((g) => '<li class="row' + (mode.kind === "replace" && mode.id === g.id ? " is-target" : "") + '" data-id="' + g.id + '"><span class="no">#' + g.id + '</span><span class="face" style="background-image:url(' + face(g.classKey) + ')"></span><div class="tt"><b>' + esc(g.title) + '</b><small>' + esc(g.author) + ' · ' + cap(g.classKey) + ' · ' + SRV[g.server] + ' · ' + (g.modes.map((m) => m.toUpperCase()).join("/") || "ไม่มีประเภท") + ' · ' + dmy(g.date) + '</small></div><span class="views" title="ผู้เข้าชม (snapshot)">👁 ' + g.views + '</span><span class="acts"><button type="button" class="btn btn-sm" data-act="replace">แทนที่</button><button type="button" class="btn btn-sm del" data-act="delete">ลบ</button></span></li>').join("") : '<li class="empty">ไม่พบไกด์</li>';
  $("#gone").hidden = !state.removed.length;
  $("#goneList").innerHTML = state.removed.map((t) => "<li>" + esc(t) + "</li>").join("");
  document.querySelectorAll(".acts button").forEach((b) => b.disabled = running || state.dirty);
}
function setMode(m){
  mode = m;
  const rep = m.kind === "replace", g = rep && state.guides.find((x) => x.id === m.id);
  $("#edTitle").firstChild.textContent = rep ? "แทนที่ไกด์ #" + m.id + " " + g.title : "เพิ่มไกด์ใหม่";
  $("#cancelReplace").hidden = !rep;
  $("#code").value = ""; check = null; showCheck(); renderList(); $("#code").focus();
}
const pressedModes = () => [...document.querySelectorAll(".mbtn")].filter((b) => b.getAttribute("aria-pressed") === "true").map((b) => b.dataset.m);
function showCheck(){
  const pv = $("#preview"), msg = $("#msg");
  pv.classList.toggle("is-on", !!(check && check.ok)); if (!(check && check.ok)) $("#modes").hidden = true; msg.className = "msg"; msg.innerHTML = "";
  if (!check) return syncGo();
  if (!check.ok){ msg.className = "msg err is-on"; msg.textContent = check.error; return syncGo(); }
  const g = check.guide;
  $("#modes").hidden = false; document.querySelectorAll(".mbtn").forEach((b) => b.setAttribute("aria-pressed", String(g.modes.includes(b.dataset.m))));
  $("#modesHint").textContent = g.modes.length ? "" : "โค้ดนี้ยังไม่ได้เลือก PVE / PVP (ทำจากหน้าเว็บรุ่นก่อน) เลือกให้ที่นี่ก่อนอัป";
  $("#pvFace").style.backgroundImage = "url(" + face(g.classKey) + ")"; $("#pvTitle").textContent = g.title; $("#pvBy").textContent = "โดย " + g.author;
  $("#pvMeta").innerHTML = ['<span class="chip num">' + (mode.kind === "replace" ? "แทนที่ #" : "จะได้เลข #") + check.id + "</span>", cap(g.classKey), SRV[g.server], "Lv " + g.level, dmy(g.date)].map((t, i) => i ? '<span class="chip">' + esc(t) + "</span>" : t).join("");
  if (check.duplicate){ msg.className = "msg warn is-on"; msg.innerHTML = "ไกด์นี้มีอยู่แล้วเป็น <b>#" + check.duplicate.id + " " + esc(check.duplicate.title) + "</b> (ชื่อและผู้เขียนเดียวกัน)<br><button type='button' class='btn btn-sm' id='useReplace'>แทนที่ #" + check.duplicate.id + " ด้วยโค้ดนี้</button>"; }
  syncGo();
}
function syncGo(){
  const ok = !!(check && check.ok && !(check.duplicate && mode.kind === "add") && pressedModes().length);
  $("#go").disabled = !ok || running || !state || state.dirty;
  $("#go").textContent = $("#dry").checked ? "ตรวจอย่างเดียว" : mode.kind === "replace" ? "แทนที่และอัปขึ้น GitHub" : "เพิ่มและอัปขึ้น GitHub";
  $("#undoBtn").disabled = running || (state && state.dirty);
}
async function runCheck(){
  const code = $("#code").value;
  if (!code.trim()){ check = null; return showCheck(); }
  const r = await (await api("/api/check", { code, replaceId: mode.kind === "replace" ? mode.id : 0 })).json();
  if ($("#code").value === code){ check = r; showCheck(); }
}
function stepRow(key, text, st){
  let li = document.querySelector('[data-step="' + key + '"]');
  if (!li){ li = document.createElement("li"); li.dataset.step = key; li.innerHTML = '<span class="dot"></span><span class="tx"></span><span class="t"></span>'; $("#steps").appendChild(li); }
  li.className = st; li.querySelector(".tx").textContent = text + (key === "check" && st === "run" ? " (ประมาณ 1 นาที)" : "");
  li.querySelector(".dot").textContent = st === "ok" ? "✓" : st === "fail" ? "✕" : st === "warn" ? "!" : "";
  clearInterval(timer);
  if (st === "run"){ const t0 = Date.now(), el = li.querySelector(".t"); timer = setInterval(() => el.textContent = Math.round((Date.now() - t0) / 1000) + " วิ", 500); }
  else li.querySelector(".t").textContent = "";
}
async function run(url, data, title){
  running = true; syncGo(); renderList();
  $("#progress").hidden = false; $("#progTitle").textContent = title; $("#steps").innerHTML = ""; $("#result").innerHTML = ""; $("#log").className = "log"; $("#log").textContent = "";
  let done = null;
  try {
    const res = await api(url, data);
    if (!res.ok || !res.body){ done = { ok: false, error: ((await res.json().catch(() => ({}))).error) || "เกิดข้อผิดพลาด (" + res.status + ")" }; }
    else {
      const reader = res.body.getReader(), dec = new TextDecoder(); let buf = "";
      for (;;){
        const { value, done: end } = await reader.read(); if (end) break;
        buf += dec.decode(value, { stream: true });
        let i; while ((i = buf.indexOf("\n")) >= 0){
          const line = buf.slice(0, i); buf = buf.slice(i + 1); if (!line) continue;
          const m = JSON.parse(line);
          if (m.type === "step") stepRow(m.key, m.text, m.state);
          else if (m.type === "log"){ $("#log").classList.add("is-on"); $("#log").textContent += m.text + "\n"; }
          else if (m.type === "done") done = m;
        }
      }
    }
  } catch (e){ done = { ok: false, error: "การเชื่อมต่อหลุด: " + e.message }; }
  clearInterval(timer); running = false;
  if (!done) done = { ok: false, error: "ไม่ได้รับผลลัพธ์" };
  if (done.ok){
    $("#progTitle").textContent = done.dry ? "ผ่านการตรวจ" : "เสร็จแล้ว";
    $("#result").innerHTML = done.dry ? "ไกด์ <b>#" + done.id + "</b> ผ่านการตรวจทั้งหมด (ตรวจอย่างเดียว ไม่ได้แก้ไฟล์ ไม่ได้ commit)" : esc(done.subject) + (done.action === "delete" ? "" : '<br><a href="' + esc(done.url) + '" target="_blank" rel="noopener">เปิดไกด์ #' + done.id + "</a> (ขึ้นเว็บภายใน 1-2 นาที)");
    if (!done.dry){ if (url === "/api/run" && data.action !== "delete") setMode({ kind: "add" }); }
  } else {
    $("#progTitle").textContent = "ไม่สำเร็จ";
    $("#result").innerHTML = '<span style="color:#f0b3a6">' + esc(done.error) + "</span>";
  }
  await load();
}
let modalYes = null;
function ask(title, html, yesText, danger, fn){
  $("#mdTitle").textContent = title; $("#mdText").innerHTML = html; $("#mdYes").textContent = yesText; $("#mdYes").className = "btn " + (danger ? "btn-red" : "btn-gold");
  modalYes = fn; $("#modal").classList.add("is-on"); $("#mdNo").focus();
}
const closeModal = () => { $("#modal").classList.remove("is-on"); modalYes = null; };
$("#mdNo").onclick = closeModal;
$("#mdYes").onclick = () => { const f = modalYes; closeModal(); if (f) f(); };
$("#modal").onclick = (e) => { if (e.target === $("#modal")) closeModal(); };
document.addEventListener("keydown", (e) => {
  if (e.key === "Escape" && $("#modal").classList.contains("is-on")) closeModal();
  if ((e.ctrlKey || e.metaKey) && !e.shiftKey && e.key.toLowerCase() === "z" && !e.target.closest("textarea,input") && state && state.undo && !running && !state.dirty){ e.preventDefault(); undo(); }
});
function undo(){ ask("ย้อนกลับ", "<b>" + esc(state.undo) + "</b><br>จะ commit และอัปขึ้น GitHub เหมือนการเปลี่ยนแปลงปกติ", "ย้อนกลับ", false, () => run("/api/undo", {}, "กำลังย้อนกลับ")); }
$("#undoBtn").onclick = undo;
$("#recheck").onclick = load;
$("#code").addEventListener("input", () => { clearTimeout(checkTimer); checkTimer = setTimeout(runCheck, 200); });
$("#dry").addEventListener("change", syncGo);
$("#modes").addEventListener("click", (e) => { const b = e.target.closest(".mbtn"); if (!b) return; b.setAttribute("aria-pressed", String(b.getAttribute("aria-pressed") !== "true")); $("#modesHint").textContent = pressedModes().length ? "" : "เลือกอย่างน้อยหนึ่งอย่าง"; syncGo(); });
$("#search").addEventListener("input", renderList);
$("#cancelReplace").onclick = () => setMode({ kind: "add" });
$("#msg").addEventListener("click", (e) => { if (e.target.id === "useReplace"){ const code = $("#code").value; setMode({ kind: "replace", id: check.duplicate.id }); $("#code").value = code; runCheck(); } });
$("#go").onclick = () => {
  const dry = $("#dry").checked, data = { action: mode.kind, id: mode.id, code: $("#code").value, modes: pressedModes(), dryRun: dry };
  if (dry) return run("/api/run", data, "กำลังตรวจ");
  const g = check.guide, rep = mode.kind === "replace";
  ask(rep ? "แทนที่ไกด์ #" + mode.id : "เพิ่มไกด์ #" + check.id, "<b>" + esc(g.title) + "</b> โดย " + esc(g.author) + "<br>" + (rep ? "ไกด์เดิมจะถูกแทนที่ด้วยฉบับนี้ (เลขเดิม ลิงก์เดิม)" : "จะขึ้นหน้าไกด์จากผู้เล่น") + " แล้ว commit และอัปขึ้น GitHub", rep ? "แทนที่และอัปขึ้น" : "เพิ่มและอัปขึ้น", false, () => run("/api/run", data, rep ? "กำลังแทนที่" : "กำลังเพิ่ม"));
};
$("#list").addEventListener("click", (e) => {
  const b = e.target.closest("button[data-act]"); if (!b || b.disabled) return;
  const id = +b.closest(".row").dataset.id, g = state.guides.find((x) => x.id === id);
  if (b.dataset.act === "replace") return setMode({ kind: "replace", id });
  ask("ลบไกด์ #" + id, "<b>" + esc(g.title) + "</b> โดย " + esc(g.author) + "<br>ไกด์จะหายจากหน้าเว็บ เลข #" + id + " จะไม่ถูกใช้ซ้ำ (ย้อนกลับได้จากปุ่มย้อนกลับ)", "ลบและอัปขึ้น GitHub", true, () => run("/api/run", { action: "delete", id }, "กำลังลบ"));
});
window.addEventListener("focus", () => { if (!running) load(); });
load();
</script>
</body>
</html>`;

// ---------- start ----------
const words = args.filter((a, i) => !a.startsWith("--") && args[i - 1] !== "--port" && args[i - 1] !== "--modes");
if (words.length) cli(words).catch((e) => { console.error("\n✗ " + e.message); process.exit(1); });
else serve();
