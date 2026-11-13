#!/usr/bin/env node
// Replace or remove a class guide embedded in ไกด์อาชีพ (CLASS_GUIDES in 12t_projects/bible/index.html), for Claude on the command line.
// New guides are not added here (2026-11-13): the author's ส่งไกด์ in the Bible's guide editor posts them to the owner's Discord, the owner ✅s
// the post and the 12tails-donate Worker numbers it from GUIDE_NUM_FLOOR + 1 (12t_projects/donate-worker/wrangler.toml), so the Worker is the one
// authority over new numbers; `add` refuses with ADD_RETIRED. The guide manager page, its phone workflow and its local server were retired the
// same day (user 2026-11-13: "Editing old guides will be done thru Claude anyway").
// One pipeline: change CLASS_GUIDES (one JSON object per line, CLASS-GUIDES.md), prepend one changelog entry (also the commit subject), run the
// validator once (plain, not --full; it also checks that a build is legal), then make one commit and push. Any failure before the commit puts
// index.html back exactly as it was. It refuses while index.html has uncommitted work.
// * replace: the guide keeps its id (its link and view count), everything else comes from the new code, stamped with the upload time.
// * delete: the line becomes "// #N removed <date>: <title> by <author>", so the number is never given out again.
//
//   node scripts/add_guide.js replace <N> <code>
//   node scripts/add_guide.js delete <N>
//     --dry-run   check everything, then put index.html back: no commit, no push
//     --no-push   commit, but do not push
//     --yes       do not ask before publishing
//     --modes pve,pvp   the guide's PVE / PVP tag when the code has none (or to change it)
//   node scripts/add_guide.js add <code>            retired: refuses
//   node scripts/add_guide.js --selftest            the pipeline on throwaway repos
"use strict";
const fs = require("fs"), path = require("path"), os = require("os"), readline = require("readline");
const { execFileSync, spawn } = require("child_process");
const { decode, CLASS_GUIDE_CLASS_KEYS, CLASS_GUIDE_SERVER_KEYS } = require("./guide_code.js");

const ROOT = process.env.GM_ROOT ? path.resolve(process.env.GM_ROOT) : path.resolve(__dirname, ".."), REL = "12t_projects/bible/index.html", FILE = path.join(ROOT, REL);   // GM_ROOT: the self-test's throwaway repos
const SITE = "https://jumpptty.github.io/12tails/12t_projects/bible/";
const SERVER = { og: "BB", tot: "ToT", tto: "TTO" };
const ADD_RETIRED = "ไกด์ใหม่ส่งผ่าน Discord แล้ว (ให้ผู้เขียนกดส่งไกด์ในหน้าเขียนไกด์ของคัมภีร์ไบเบิ้ล)";
const args = process.argv.slice(2), has = (f) => args.includes(f), val = (f) => { const i = args.indexOf(f); return i >= 0 ? args[i + 1] : undefined; };
const git = (...a) => execFileSync("git", a, { cwd: ROOT, encoding: "utf8", stdio: ["ignore", "pipe", "pipe"] }).trim();
const cap = (s) => String(s).charAt(0).toUpperCase() + String(s).slice(1);
const clean = (s) => String(s).replace(/[<>\r\n]/g, " ").replace(/\s+/g, " ").trim();
const subj = (s) => s.replace(/\*\*|["\\<>]/g, "").replace(/\s+/g, " ").trim();   // the changelog entry is compared with the commit subject character for character
const label = (g) => `${SERVER[g.build.server] || g.build.server} ${cap(g.build.classKey)} ${g.title} by ${g.author}`;
const today = () => new Date().toISOString().slice(0, 10);
// The guide's date is the moment it is uploaded (user 2026-10-23): whatever date an old code carries is replaced. `published` is that moment in
// UTC (the page's ใหม่ badge shows for 24 hours after it), `date` the calendar day in Thailand (UTC+7, whatever the machine's time zone). Both go
// right after the author.
function stampGuide(g, now = new Date()){
  const entries = Object.entries(g).filter(([k]) => k !== "date" && k !== "published");
  entries.splice(entries.findIndex(([k]) => k === "author") + 1, 0, ["date", new Date(now.getTime() + 7 * 36e5).toISOString().slice(0, 10)], ["published", now.toISOString().slice(0, 19) + "Z"]);
  for (const k of Object.keys(g)) delete g[k];
  Object.assign(g, Object.fromEntries(entries));
}
const MODES = ["pve", "pvp"], pickModes = (v) => MODES.filter((m) => Array.isArray(v) && v.includes(m));   // PVE / PVP, both allowed; a finished guide needs one (user 2026-10-20)

// ---------- reading and changing CLASS_GUIDES ----------
function readGuides(){
  const html = fs.readFileSync(FILE, "utf8"), eol = html.includes("\r\n") ? "\r\n" : "\n";
  const open = "const CLASS_GUIDES = [" + eol, start = html.indexOf(open), end = start < 0 ? -1 : html.indexOf(eol + "];", start);
  if (end < 0) throw new Error("CLASS_GUIDES was not found in " + REL);
  const lines = html.slice(start + open.length, end).split(eol), guides = [];
  lines.forEach((l, at) => { const t = l.trim(); if (t.startsWith("{")) guides.push({ at, g: JSON.parse(t.replace(/,$/, "")) }); });
  return { html, eol, head: html.slice(0, start + open.length), tail: html.slice(end), lines, guides };
}
const guideLine = (id, g) => "  " + JSON.stringify({ id, ...g }).replace(/</g, "\\u003c") + ",";   // no "</script>" or "<!--" inside the page script
const tombLine = (id, g) => `  // #${id} removed ${today()}: ${clean(g.title)} by ${clean(g.author)}`;
function findCode(text){ return (String(text || "").match(/TG3[一-跿\s`]*[一-跿]|(?:TG2|12TG1)\.[A-Za-z0-9_-]+/) || [])[0]; }   // TG3 (2026-10-20) may carry spaces, line breaks and backticks from a chat message
function decodeCode(text){
  const code = findCode(text);
  if (!code) throw new Error("ไม่พบโค้ดไกด์ (ขึ้นต้นด้วย TG3 หรือ TG2.)");
  let g;
  try { g = decode(code); }
  catch (e){ throw new Error("อ่านโค้ดไม่ได้ (" + e.message + "). ถ้าโค้ดถูกส่งทาง Discord นอกกล่องโค้ด เครื่องหมาย _ อาจหายไปเพราะกลายเป็นตัวเอียง ขอให้ผู้เขียนส่งใหม่ในกล่องโค้ด (```)"); }
  if (!g || g.format !== "12t-class-guide" || !g.build || !g.title || !g.author) throw new Error("โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ");
  if (!CLASS_GUIDE_CLASS_KEYS.includes(g.build.classKey) || !CLASS_GUIDE_SERVER_KEYS.includes(g.build.server)) throw new Error("โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ");   // a legacy 12TG1 code can carry any text there, and the page puts it into HTML (review 2026-10-20)
  return g;
}
// What a change does to the lines: { id, lines, subject }.
function plan(op, doc){
  const t = doc.guides.find((x) => x.g.id === op.id); if (!t) throw new Error(`ไม่มีไกด์ #${op.id}`);
  const lines = doc.lines.slice();
  if (op.action === "replace"){
    lines[t.at] = guideLine(op.id, op.guide);
    return { id: op.id, lines, subject: subj(`fix(bible): class guide #${op.id} is updated: ${label(op.guide)}`) };
  }
  lines[t.at] = tombLine(op.id, t.g);
  return { id: op.id, lines, subject: subj(`fix(bible): class guide #${op.id} is removed (${t.g.title} by ${t.g.author})`) };
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
// Google Drive, Defender, NVIDIA Overlay or another git (VS Code) can hold a file in .git for a moment ("unable to write file .git/objects/..:
// Permission denied", "index.lock"): wait and try again.
async function gitRetry(log, ...a){
  for (let i = 1; ; i++){
    try { return git(...a); }
    catch (e){
      if (!/Permission denied|unable to (write|create)|\.lock/i.test(e.message)) throw e;
      if (i === 4) throw new Error("git เขียนไฟล์ในโฟลเดอร์ .git ไม่ได้ (มีโปรแกรมอื่นจับไฟล์ไว้) ยังไม่ได้อัปอะไรขึ้น และ index.html กลับเป็นเหมือนเดิมแล้ว ลองใหม่อีกครั้ง\n" + e.message.trim().split("\n").slice(-2).join("\n"));
      log(`git ${a[0]}: another program holds a file in .git, retrying (${i + 1}/4)`);
      await new Promise((r) => setTimeout(r, 2000 * i));
    }
  }
}
// The validator's own "[XYZ ERROR] ..." lines, not the source and stack lines under them.
function validatorErrorLines(out){
  const all = out.split(/\r?\n/), tagged = all.filter((l) => /^\s*\[[A-Z0-9 _-]*ERROR\]/.test(l));
  const lines = tagged.length ? tagged : all.filter((l) => /ERROR|Error/.test(l));
  return (lines.length ? lines : out.trim().split(/\r?\n/).slice(-12)).slice(0, 14);
}
const backupDir = () => { const dir = path.join(os.tmpdir(), "12t-bible-backups"); fs.mkdirSync(dir, { recursive: true }); return dir; };
// One change through the pipeline; resolves to { id, subject, url, dry }. log(text) prints progress.
async function apply(op, { dryRun = false, noPush = false } = {}, log = () => {}){
  const branch = preflight(!dryRun && !noPush), doc = readGuides(), p = plan(op, doc);
  const backup = path.join(backupDir(), "index." + Date.now() + ".bak"); fs.copyFileSync(FILE, backup);
  const result = (extra) => ({ id: p.id, subject: p.subject, url: SITE + "#class-guide/" + p.id, dry: false, ...extra });
  let committed = false;
  try {
    let out = doc.head + p.lines.join(doc.eol) + doc.tail;
    const top = "  entries: [" + doc.eol, at = out.indexOf(top, out.indexOf("const CHANGELOG_DATA = {"));
    if (at < 0) throw new Error("CHANGELOG_DATA was not found in " + REL);
    out = out.slice(0, at + top.length) + "    " + JSON.stringify([new Date().toISOString(), p.subject]) + "," + doc.eol + out.slice(at + top.length);
    fs.writeFileSync(FILE, out); log("ok   edited index.html");
    const c = await runNode("scripts/validate_skills.js", []);   // plain, not --full (user 2026-10-23): its damage-range check is for damage code, which guides never touch
    if (c.status !== 0){
      log(validatorErrorLines(c.out).join("\n"));
      throw new Error("ไกด์ไม่ผ่านการตรวจ จึงไม่ได้อัปอะไรขึ้น และ index.html กลับเป็นเหมือนเดิมแล้ว");
    }
    log("ok   validator");
    if (dryRun){ fs.copyFileSync(backup, FILE); return result({ dry: true }); }
    const msg = path.join(backupDir(), "commit-msg.txt"); fs.writeFileSync(msg, p.subject + "\n");
    await gitRetry(log, "add", "--", REL); await gitRetry(log, "commit", "-q", "-F", msg); committed = true; log("ok   commit");
    if (noPush) return result();
    try { git("push", "-q", "origin", branch); } catch (e) {}   // the local tracking ref sometimes fails to update here; what counts is what GitHub has
    const sha = git("rev-parse", "HEAD"), remote = git("ls-remote", "origin", "refs/heads/" + branch).split(/\s+/)[0];
    if (remote !== sha) throw new Error("commit ในเครื่องแล้ว แต่อัปขึ้น GitHub ไม่สำเร็จ ลองใหม่ภายหลังด้วย git push");
    try { git("update-ref", "refs/remotes/origin/" + branch, sha); } catch (e) {}
    log("ok   pushed");
    return result();
  } catch (e){
    if (!committed){ try { git("reset", "-q", "--", REL); } catch (_) {} fs.copyFileSync(backup, FILE); }   // unstage too, or a failed commit leaves the new index.html staged
    throw e;
  }
}

// ---------- command line ----------
async function cli(words){
  const ask = (q) => new Promise((res) => { const rl = readline.createInterface({ input: process.stdin, output: process.stdout }); rl.question(q, (a) => { rl.close(); res(a); }); });
  const [cmd, ...rest] = words;
  let op;
  if (cmd === "add" || findCode(cmd)) throw new Error(ADD_RETIRED);   // a bare code used to mean add
  if (cmd === "replace") op = { action: "replace", id: +rest[0], guide: decodeCode(rest.slice(1).join(" ") || await ask("Paste the new code: ")) };
  else if (cmd === "delete") op = { action: "delete", id: +rest[0] };
  else throw new Error("usage: see the header of scripts/add_guide.js");
  if (op.guide){
    stampGuide(op.guide); console.log(`  Date: the upload time (${op.guide.published}).`);
    if (val("--modes")) op.guide.modes = pickModes(val("--modes").split(",").map((x) => x.trim().toLowerCase()));
    if (!(op.guide.modes || []).length) throw new Error("This code has no PVE / PVP tag (made with an older page). Add --modes pve, --modes pvp or --modes pve,pvp.");
  }
  console.log("\n  " + plan(op, readGuides()).subject + "\n");
  if (!has("--dry-run") && !has("--yes") && !/^y/i.test((await ask("Publish this? (y/n) ")).trim())) throw new Error("Cancelled. Nothing was changed.");
  const r = await apply(op, { dryRun: has("--dry-run"), noPush: has("--no-push") }, (t) => console.log("  " + t.replace(/\n/g, "\n    ")));
  console.log(r.dry ? `\n✓ #${r.id} passed every check (dry run: index.html is back as it was).` : `\n✓ Done: ${r.subject}\n  ${r.url}`);
}

// ---------- self-test ----------
// Throwaway repos in the temp folder (a work tree with a bare origin): a tiny CRLF index.html with guides #1 and #2, and a stub validator that
// refuses any guide titled FAILME. The command line runs as a child process with GM_ROOT pointing at the repo.
async function selftest(){
  const assert = require("assert"), { spawnSync } = require("child_process"), gc = require("./guide_code.js");
  const tmp = fs.mkdtempSync(path.join(os.tmpdir(), "gm-selftest-")), day = today();
  const sh = (cwd, ...a) => execFileSync("git", a, { cwd, encoding: "utf8", stdio: ["ignore", "pipe", "pipe"] }).trim();
  const guide = (title, author) => ({ format: "12t-class-guide", version: 1, title, author, date: "2026-10-01", description: "d", build: { server: "tot", classKey: "wolf", level: 100, learned: [101] }, modes: ["pve"], notes: {} });
  const code = (title, author = "A1") => gc.encode(guide(title, author));
  const STUB = 'const fs = require("fs"), path = require("path"), html = fs.readFileSync(path.join(__dirname, "..", "12t_projects/bible/index.html"), "utf8");\nif (html.includes("FAILME")){ console.log("[CLASS GUIDE ERROR] fixture refuses FAILME"); process.exit(1); }\n';
  let n = 0;
  function fixture(){
    const dir = path.join(tmp, "f" + ++n), origin = dir + ".git";
    fs.mkdirSync(path.join(dir, "12t_projects/bible"), { recursive: true }); fs.mkdirSync(path.join(dir, "scripts"));
    fs.writeFileSync(path.join(dir, REL), ["<script>", "const CLASS_GUIDES = [", guideLine(1, guide("T1", "A1")), guideLine(2, guide("T2", "A2")), "];", "const CHANGELOG_DATA = {", "  entries: [", '    ["2026-01-01T00:00:00.000Z", "init"],', "  ],", "};", "</script>", ""].join("\r\n"));
    fs.writeFileSync(path.join(dir, "scripts/validate_skills.js"), STUB);
    sh(tmp, "init", "-q", "--bare", origin);
    for (const a of [["init", "-q", "-b", "main"], ["config", "user.name", "Test"], ["config", "user.email", "test@example.com"], ["config", "core.autocrlf", "false"], ["add", "-A"], ["commit", "-q", "-m", "init"], ["remote", "add", "origin", origin], ["push", "-q", "-u", "origin", "main"]]) sh(dir, ...a);
    return dir;
  }
  const html = (dir) => fs.readFileSync(path.join(dir, REL), "utf8");
  const lines = (dir) => { const ls = html(dir).split("\r\n"), at = ls.indexOf("const CLASS_GUIDES = ["); return ls.slice(at + 1, ls.indexOf("];", at)); };
  const head = (dir) => sh(dir, "rev-parse", "HEAD"), subject = (dir) => sh(dir, "log", "-1", "--format=%s");
  const newestEntry = (dir) => JSON.parse(html(dir).split("\r\n")[html(dir).split("\r\n").indexOf("  entries: [") + 1].trim().replace(/,$/, ""))[1];
  const run = (dir, ...argv) => spawnSync(process.execPath, [__filename, ...argv], { cwd: dir, env: { ...process.env, GM_ROOT: dir }, encoding: "utf8" });
  const unchanged = (dir, f) => { const before = html(dir), sha = head(dir); f(); assert.strictEqual(html(dir), before); assert.strictEqual(head(dir), sha); assert.strictEqual(sh(dir, "status", "--porcelain"), ""); };
  const cases = [];
  const test = (name, fn) => cases.push([name, fn]);

  test("an upload stamps the guide with its own date and time, whatever date the code carries (user 2026-10-23)", async () => {
    const g = { author: "A", date: "2020-01-01", published: "2020-01-01T00:00:00Z", title: "T" };
    stampGuide(g, new Date("2026-10-22T18:30:05.999Z"));
    assert.deepStrictEqual(Object.keys(g), ["author", "date", "published", "title"]);
    assert.strictEqual(g.published, "2026-10-22T18:30:05Z"); assert.strictEqual(g.date, "2026-10-23");   // 01:30 on the 23rd in Thailand
  });
  test("add is retired (2026-11-13): add <code> and a bare code refuse, nothing changes", async () => {
    const dir = fixture();
    unchanged(dir, () => { for (const argv of [["add", code("T3")], [code("T3")]]){ const c = run(dir, ...argv, "--yes", "--no-push"); assert.strictEqual(c.status, 1); assert.ok(c.stderr.includes(ADD_RETIRED), c.stdout + c.stderr); } });
  });
  test("replace: same id, stamped, changelog entry = commit subject, pushed", async () => {
    const dir = fixture(), c = run(dir, "replace", "1", code("T1b"), "--yes");
    assert.strictEqual(c.status, 0, c.stdout + c.stderr);
    const [l1, l2] = lines(dir), g = JSON.parse(l1.trim().replace(/,$/, ""));
    assert.strictEqual(g.id, 1); assert.strictEqual(g.title, "T1b"); assert.ok(Math.abs(Date.parse(g.published) - Date.now()) < 60000);
    assert.strictEqual(l2, guideLine(2, guide("T2", "A2")));
    assert.strictEqual(subject(dir), "fix(bible): class guide #1 is updated: ToT Wolf T1b by A1"); assert.strictEqual(newestEntry(dir), subject(dir));
    assert.strictEqual(sh(dir, "ls-remote", "origin", "refs/heads/main").split(/\s+/)[0], head(dir));
  });
  test("delete --no-push: a tombstone keeps the number, committed but not pushed", async () => {
    const dir = fixture(), sha = head(dir), c = run(dir, "delete", "2", "--yes", "--no-push");
    assert.strictEqual(c.status, 0, c.stdout + c.stderr);
    assert.strictEqual(lines(dir)[1], `  // #2 removed ${day}: T2 by A2`);
    assert.strictEqual(subject(dir), "fix(bible): class guide #2 is removed (T2 by A2)"); assert.strictEqual(newestEntry(dir), subject(dir));
    assert.strictEqual(sh(dir, "ls-remote", "origin", "refs/heads/main").split(/\s+/)[0], sha);
  });
  test("a guide the validator refuses: index.html as it was, nothing committed, the validator's line shown", async () => {
    const dir = fixture();
    unchanged(dir, () => { const c = run(dir, "replace", "1", code("FAILME"), "--yes", "--no-push"); assert.strictEqual(c.status, 1); assert.ok(c.stdout.includes("[CLASS GUIDE ERROR] fixture refuses FAILME") && c.stderr.includes("ไกด์ไม่ผ่านการตรวจ"), c.stdout + c.stderr); });
  });
  test("--dry-run: checked, then index.html as it was, no commit", async () => {
    const dir = fixture();
    unchanged(dir, () => { const c = run(dir, "replace", "1", code("T1b"), "--dry-run"); assert.strictEqual(c.status, 0, c.stdout + c.stderr); assert.ok(c.stdout.includes("passed every check")); });
  });
  test("refused: uncommitted work in index.html, an unknown number, a code whose class or server is not real, a bad command", async () => {
    const dir = fixture(), bad = (build) => gc.encode1({ ...guide("T9", "A9"), build: { ...guide("T9", "A9").build, ...build } });
    unchanged(dir, () => {
      assert.ok(run(dir, "delete", "9", "--yes", "--no-push").stderr.includes("ไม่มีไกด์ #9"));
      for (const c of [bad({ classKey: "<img src=x onerror=alert(1)>" }), bad({ server: "zz" })]) assert.ok(run(dir, "replace", "1", c, "--yes", "--no-push").stderr.includes("โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ"));
      assert.ok(run(dir, "rename", "1").stderr.includes("usage"));
    });
    fs.appendFileSync(path.join(dir, REL), " ");
    assert.ok(run(dir, "delete", "1", "--yes", "--no-push").stderr.includes("index.html มีงานค้าง"));
  });
  test("a title with </script> stays escaped in the page script", async () => {
    assert.ok(guideLine(2, guide("</script><!--", "A")).includes("\\u003c/script>\\u003c!--"));
  });

  let failed = 0;
  for (const [name, fn] of cases){
    try { await fn(); console.log("  ok   " + name); }
    catch (e){ failed++; console.log("  FAIL " + name + "\n       " + String(e.message).split("\n").join("\n       ")); }
  }
  try { fs.rmSync(tmp, { recursive: true, force: true }); } catch (e) {}
  if (failed) throw new Error(`add_guide selftest: ${failed} of ${cases.length} failed`);
  console.log(`add_guide selftest: all checks passed (${cases.length})`);
}

// ---------- start ----------
const words = args.filter((a, i) => !a.startsWith("--") && args[i - 1] !== "--modes");
if (require.main !== module) { /* required, not run: start nothing */ }
else if (has("--selftest")) selftest().catch((e) => { console.error(e.message); process.exit(1); });
else cli(words).catch((e) => { console.error("\n✗ " + e.message); process.exit(1); });
