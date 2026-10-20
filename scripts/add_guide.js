#!/usr/bin/env node
// Publish a submitted class guide to ไกด์อาชีพ without a Claude session (user 2026-10-20).
// Paste the guide code (TG2.… or 12TG1.…): the script decodes it, adds it to CLASS_GUIDES in 12t_projects/bible/index.html with the next running
// id (12t_projects/bible/CLASS-GUIDES.md), refreshes CLASS_GUIDE_VIEWS, prepends the changelog entry, runs the full validator (which also checks
// that the build is legal) and, when everything passes, commits and pushes. Any failure puts index.html back exactly as it was.
//
//   node scripts/add_guide.js [code]   without a code it asks you to paste one (an empty line reads the clipboard)
//     --dry-run   check everything, then put index.html back: no commit, no push
//     --no-push   commit, but do not push
//   scripts/add_guide.cmd             the same by double-click on Windows
"use strict";
const fs = require("fs"), path = require("path"), os = require("os"), readline = require("readline");
const { execFileSync, spawnSync } = require("child_process");
const { decode } = require("./guide_code.js");

const ROOT = path.resolve(__dirname, ".."), REL = "12t_projects/bible/index.html", FILE = path.join(ROOT, REL);
const SITE = "https://jumpptty.github.io/12tails/12t_projects/bible/";
const SERVER = { og: "BB", tot: "ToT", tto: "TTO" };
const args = process.argv.slice(2), dryRun = args.includes("--dry-run"), noPush = args.includes("--no-push");
const git = (...a) => execFileSync("git", a, { cwd: ROOT, encoding: "utf8", stdio: ["ignore", "pipe", "pipe"] }).trim();
const fail = (msg) => { console.error("\n✗ " + msg); process.exit(1); };
const ask = (q) => new Promise((res) => { const rl = readline.createInterface({ input: process.stdin, output: process.stdout }); rl.question(q, (a) => { rl.close(); res(a); }); });
const findCode = (text) => (String(text || "").match(/(?:TG2|12TG1)\.[A-Za-z0-9_-]+/) || [])[0];
function clipboard(){
  try {
    if (process.platform === "win32") return execFileSync("powershell", ["-NoProfile", "-Command", "Get-Clipboard -Raw"], { encoding: "utf8" });
    if (process.platform === "darwin") return execFileSync("pbpaste", { encoding: "utf8" });
  } catch (e) {}
  return "";
}
// A step that runs another script; its output is shown only when it fails.
function run(label, file, extra){
  process.stdout.write(label + " ... ");
  const r = spawnSync(process.execPath, [path.join(ROOT, file), ...extra], { cwd: ROOT, encoding: "utf8", maxBuffer: 1 << 26 });
  console.log(r.status === 0 ? "ok" : "failed");
  return r;
}

(async () => {
  // 1. index.html must hold no unfinished work (a Claude session's, say): this commit is the new guide only
  try { if (git("status", "--porcelain", "--", REL)) fail(REL + " has uncommitted changes. Finish or commit that work first, then run this again."); }
  catch (e) { fail("git did not answer here: " + e.message.split("\n")[0]); }
  const branch = git("rev-parse", "--abbrev-ref", "HEAD");
  if (branch === "HEAD") fail("This checkout is not on a branch.");
  if (!dryRun && !noPush){   // start from what GitHub has, so the push is a plain fast-forward
    try { git("fetch", "-q", "origin", branch); } catch (e) { fail("Could not reach GitHub: " + e.message.split("\n")[0]); }
    const [behind, ahead] = git("rev-list", "--left-right", "--count", "origin/" + branch + "...HEAD").split(/\s+/).map(Number);
    if (behind && ahead) fail("This branch and GitHub have both moved on. Sync them first (git pull), then run this again.");
    if (behind) git("merge", "-q", "--ff-only", "origin/" + branch);
  }

  // 2. the code: from the command line, else pasted, else the clipboard
  let code = findCode(args.filter((a) => !a.startsWith("--")).join(" "));
  if (!code){
    const typed = await ask("Paste the guide code and press Enter (an empty line uses the clipboard): ");
    code = findCode(typed) || (typed.trim() ? "" : findCode(clipboard()));
  }
  if (!code) fail("No guide code found (it starts with TG2.).");
  let guide;
  try { guide = decode(code); } catch (e) { fail("The code could not be read: " + e.message); }
  if (!guide || guide.format !== "12t-class-guide" || !guide.build || !guide.title || !guide.author) fail("That is not a class guide code.");

  // 3. CLASS_GUIDES holds one JSON object per line; a guide already in it (same title and author) is refused
  const html = fs.readFileSync(FILE, "utf8"), eol = html.includes("\r\n") ? "\r\n" : "\n";
  const start = html.indexOf("const CLASS_GUIDES = [" + eol), end = start < 0 ? -1 : html.indexOf(eol + "];", start);
  if (end < 0) fail("CLASS_GUIDES was not found in " + REL);
  const known = html.slice(start, end).split(eol).map((l) => l.trim()).filter((l) => l.startsWith("{")).map((l) => JSON.parse(l.replace(/,$/, "")));
  const same = known.find((g) => g.title === guide.title && g.author === guide.author);
  if (same) fail(`Guide #${same.id} "${same.title}" by ${same.author} is already in the Bible. (To replace it, ask Claude.)`);
  const id = Math.max(0, ...known.map((g) => g.id)) + 1;
  const cls = guide.build.classKey.charAt(0).toUpperCase() + guide.build.classKey.slice(1), srv = SERVER[guide.build.server] || guide.build.server;
  // the commit subject is also the changelog entry, compared character for character by the validator: no quote, backslash or < > (the entry sits
  // in the page script as a plain string), no ** markup, one line
  const subject = `feat(bible): class guide #${id} ${srv} ${cls} ${guide.title} by ${guide.author}`.replace(/\*\*|["\\<>]/g, "").replace(/\s+/g, " ").trim();
  console.log(`\n  #${id}  ${guide.title}\n  by ${guide.author}  ·  ${cls}  ·  ${srv}  ·  Lv ${guide.build.level}  ·  ${guide.date || "no date"}\n`);
  if (!dryRun && !/^y/i.test((await ask("Add this guide and publish it to GitHub? (y/n) ")).trim())) fail("Cancelled. Nothing was changed.");

  // 4. write the guide line and the changelog entry, keeping a backup to put back on any failure
  const dir = path.join(os.tmpdir(), "12t-bible-backups"); fs.mkdirSync(dir, { recursive: true });
  const backup = path.join(dir, "index." + Date.now() + ".bak"); fs.copyFileSync(FILE, backup);
  const restore = () => fs.copyFileSync(backup, FILE);
  const safe = (v) => JSON.stringify(v).replace(/</g, "\\u003c");   // no "</script>" or "<!--" can end up inside the page script
  let out = html.slice(0, end) + eol + "  " + safe({ id, ...guide }) + "," + html.slice(end);
  const top = "  entries: [" + eol, at = out.indexOf(top, out.indexOf("const CHANGELOG_DATA = {"));
  if (at < 0) fail("CHANGELOG_DATA was not found in " + REL);
  out = out.slice(0, at + top.length) + "    " + JSON.stringify([new Date().toISOString(), subject]) + "," + eol + out.slice(at + top.length);
  fs.writeFileSync(FILE, out);

  // 5. the view snapshot (a failure only keeps the old numbers), then the full validator, as before every push
  if (run("Refreshing guide view counts", "scripts/guide_views.js", []).status !== 0) console.log("  (kept the old view counts)");
  console.log("Checking with the validator (about a minute) ...");
  const v = run("Validator", "scripts/validate_skills.js", ["--full"]);
  if (v.status !== 0){
    restore();
    const lines = (v.stdout + "\n" + v.stderr).split(/\r?\n/).filter((l) => /ERROR|Error|error/.test(l));
    fail("The guide did not pass, so nothing was published and index.html is back as it was:\n  " + (lines.slice(0, 12).join("\n  ") || (v.stdout + v.stderr).trim().split(/\r?\n/).slice(-12).join("\n  ")));
  }
  if (dryRun){ restore(); console.log(`\n✓ Guide #${id} is valid. (Dry run: index.html is back as it was, nothing was committed.)`); return; }

  // 6. commit and push (the push's local tracking ref sometimes fails to update here: what counts is what GitHub has)
  const msgFile = path.join(dir, "commit-msg.txt"); fs.writeFileSync(msgFile, subject + "\n");
  try { git("add", "--", REL); git("commit", "-q", "-F", msgFile); }
  catch (e) { restore(); fail("The commit failed: " + e.message.split("\n")[0]); }
  if (noPush){ console.log(`\n✓ Guide #${id} committed (not pushed).`); return; }
  try { git("push", "-q", "origin", branch); } catch (e) {}
  const sha = git("rev-parse", "HEAD"), remote = git("ls-remote", "origin", "refs/heads/" + branch).split(/\s+/)[0];
  if (remote !== sha) fail("The guide is committed on this PC, but the push to GitHub did not go through. Push it later with: git push");
  try { git("update-ref", "refs/remotes/origin/" + branch, sha); } catch (e) {}
  console.log(`\n✓ Guide #${id} published. It shows up in a minute or two at ${SITE}#class-guide/${id}`);
})().catch((e) => fail(e.message));
