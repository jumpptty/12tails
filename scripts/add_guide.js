#!/usr/bin/env node
// Class guide manager (user 2026-10-20): add, replace or remove a guide in ไกด์อาชีพ without a Claude session.
// With no arguments (or by double-clicking scripts/add_guide.cmd) it opens a page in the browser, served from this PC only: 127.0.0.1, a key made
// at start-up on every request, and the Host and Origin checked, so no web page can drive it.
// The page queues changes (user 2026-10-20: batch, e.g. add 2, replace 2, remove 1) and publishes the whole queue at once.
// Every publish goes through one pipeline: apply the changes in order to CLASS_GUIDES in 12t_projects/bible/index.html (one JSON object per line,
// CLASS-GUIDES.md), prepend one changelog entry (also the commit subject), run the validator once (plain, not --full; it also checks
// that a build is legal), then make one commit and push. Any failure before the commit puts index.html back exactly as it was, so a batch goes
// up whole or not at all. It refuses while index.html has uncommitted work.
// * add: the next running id. * replace: the guide keeps its id (its link and view count), everything else comes from the new code.
// * remove: the line becomes "// #N removed <date>: <title> by <author>", so the number is never given out again (ids are never reused).
// * undo (page button or Ctrl+Z): the last publish made since start-up, the whole batch, is reversed the same way (an added guide is removed,
//   a removed or replaced one comes back).
// * donor-add / donor-remove (user 2026-10-23, the ☕ donor list): one line per approved donation in DONORS, written by scripts/donors.js, added
//   at the end or simply taken out (no tombstone: a donor id is in no public link). A donor change makes no changelog entry (a batch with guides
//   too gets the guides' entry only), and a removal's subject never names the donor.
//
//   node scripts/add_guide.js                       the page (--port <n>, --no-open)
//   node scripts/add_guide.js add <code>            the same pipeline on the command line (a bare code also means add)
//   node scripts/add_guide.js replace <N> <code>
//   node scripts/add_guide.js delete <N>
//     --dry-run   check everything, then put index.html back: no commit, no push
//     --no-push   commit, but do not push (also for the page)
//     --yes       do not ask before publishing
//     --modes pve,pvp   the guide's PVE / PVP tag when the code has none (or to change it)
//   node scripts/add_guide.js batch <request.json> --stage git|edit|check|commit|push [--dry-run]
//                                                   one stage of the same pipeline, for the guide-manager workflow (the phone; see batch())
//   node scripts/add_guide.js --selftest            the pipeline on throwaway repos
"use strict";
const fs = require("fs"), path = require("path"), os = require("os"), http = require("http"), crypto = require("crypto"), readline = require("readline");
const { execFileSync, spawn } = require("child_process");
const { decode, CLASS_GUIDE_CLASS_KEYS, CLASS_GUIDE_SERVER_KEYS } = require("./guide_code.js");
const { checkDonation, newKey, donorLine, parseDonors } = require("./donors.js");

const ROOT = process.env.GM_ROOT ? path.resolve(process.env.GM_ROOT) : path.resolve(__dirname, ".."), REL = "12t_projects/bible/index.html", FILE = path.join(ROOT, REL);   // GM_ROOT: the self-test's throwaway repos
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
// The guide's date is the moment it is uploaded (user 2026-10-23): the author no longer picks one, and whatever date an old code carries is replaced.
// `published` is that moment in UTC (the page's ใหม่ badge shows for 24 hours after it), `date` the calendar day in Thailand (UTC+7, whatever the
// machine's time zone, so the phone's GitHub run and the PC agree). Both go right after the author.
function stampGuide(g, now = new Date()){
  const entries = Object.entries(g).filter(([k]) => k !== "date" && k !== "published");
  entries.splice(entries.findIndex(([k]) => k === "author") + 1, 0, ["date", new Date(now.getTime() + 7 * 36e5).toISOString().slice(0, 10)], ["published", now.toISOString().slice(0, 19) + "Z"]);
  for (const k of Object.keys(g)) delete g[k];
  Object.assign(g, Object.fromEntries(entries));
}
const MODES = ["pve", "pvp"], pickModes = (v) => MODES.filter((m) => Array.isArray(v) && v.includes(m));   // PVE / PVP, both allowed; a finished guide needs one (user 2026-10-20)

// ---------- reading and changing CLASS_GUIDES ----------
const readGuides = () => { const doc = parseDoc(fs.readFileSync(FILE, "utf8")); return { ...doc, donors: parseDonors(doc.html) }; };   // donors: the DONORS block
function parseDoc(html){
  const eol = html.includes("\r\n") ? "\r\n" : "\n";
  const open = "const CLASS_GUIDES = [" + eol, start = html.indexOf(open), end = start < 0 ? -1 : html.indexOf(eol + "];", start);
  if (end < 0) throw new Error("CLASS_GUIDES was not found in " + REL);
  const lines = html.slice(start + open.length, end).split(eol);
  return { html, eol, head: html.slice(0, start + open.length), tail: html.slice(end), lines, ...parse(lines) };
}
function parse(lines){
  const guides = [], removed = [];
  lines.forEach((l, at) => {
    const t = l.trim(), r = t.match(/^\/\/ #(\d+) removed/);
    if (t.startsWith("{")) guides.push({ at, g: JSON.parse(t.replace(/,$/, "")) });
    else if (r) removed.push({ at, id: +r[1], text: t.slice(3) });
  });
  return { guides, removed };
}
const nextId = (doc) => Math.max(0, ...doc.guides.map((x) => x.g.id), ...doc.removed.map((x) => x.id)) + 1;
const guideLine = (id, g) => "  " + JSON.stringify({ id, ...g }).replace(/</g, "\\u003c") + ",";   // no "</script>" or "<!--" inside the page script
const tombLine = (id, g) => `  // #${id} removed ${today()}: ${clean(g.title)} by ${clean(g.author)}`;
const lineAt = (doc, id) => doc.lines.findIndex((l) => { const t = l.trim(); return t.startsWith(`{"id":${id},`) || t.startsWith(`// #${id} removed`); });
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
// The ☕ donor list (DONORS): a donation's key k and its donor's id are 8 hex characters each.
const isHex8 = (s) => typeof s === "string" && /^[0-9a-f]{8}$/.test(s);
const isDonorOp = (op) => op.action === "donor-add" || op.action === "donor-remove" || (op.action === "undo" && op.entry.kind === "donor");
const donationsIn = (lines) => lines.flatMap((l, at) => l.trim().startsWith("{") ? [{ at, x: JSON.parse(l.trim().replace(/,$/, "")) }] : []);   // as parseDonors reads them
// What a donor change does to the DONORS lines: { k, donorLines, subject, undo }. An undo puts a removed line back at the end (the order only
// matters between two donations of one donor in the same minute) and, like a guide undo, refuses when the line has changed since.
function planDonor(op, d){
  const lines = d.lines.slice(), find = (k) => d.donations.find((t) => t.x.k === k);
  if (op.action === "donor-add"){
    if (find(op.x.k)) throw new Error(`มีการสนับสนุนรหัส ${op.x.k} อยู่แล้ว`);
    const line = donorLine(op.x); lines.push(line);
    return { k: op.x.k, donorLines: lines, subject: subj(`feat(bible): ขอบคุณผู้สนับสนุน ${op.x.name}`), undo: { kind: "donor", k: op.x.k, before: null, after: line, text: "เอาการสนับสนุนที่เพิ่งเพิ่มออก" } };
  }
  if (op.action === "donor-remove"){
    const t = find(op.k); if (!t) throw new Error(`ไม่มีการสนับสนุนรหัส ${op.k}`);
    lines.splice(t.at, 1);
    return { k: op.k, donorLines: lines, subject: "fix(bible): remove a donation", undo: { kind: "donor", k: op.k, before: d.lines[t.at], after: null, text: "คืนการสนับสนุนที่เพิ่งเอาออก" } };   // never the name: it may be going for privacy
  }
  const u = op.entry, t = find(u.k);
  if ((t ? d.lines[t.at] : null) !== u.after) throw new Error("การสนับสนุนนี้ถูกแก้หลังจากนั้นแล้ว ย้อนกลับไม่ได้");
  if (t) lines.splice(t.at, 1);
  if (u.before !== null) lines.push(u.before);
  return { k: u.k, donorLines: lines, subject: u.before === null ? "fix(bible): remove a donation" : "fix(bible): restore a donation", undo: null };
}
// A ☕ queue item as a change. The page picks the donor's id (an existing donor's, or a new one); the donation's own key is made here.
function donorOp(it){
  if (it.action === "donor-remove"){ if (!isHex8(it.k)) throw new Error("รหัสการสนับสนุนไม่ถูกต้อง"); return { action: "donor-remove", k: it.k }; }
  const d = it.donor || {};
  if (!isHex8(d.id)) throw new Error("รหัสผู้สนับสนุนไม่ถูกต้อง (ต้องเป็นตัวอักษร 0-9 a-f 8 ตัว)");
  return { action: "donor-add", x: { k: newKey(), id: d.id, ...checkDonation(d) } };
}

// What a change does to the lines: { id, lines, subject, undo } (undo = how to take it back; none for an undo itself). A donor change: planDonor.
function plan(op, doc){
  if (isDonorOp(op)) return planDonor(op, doc.donors);
  const lines = doc.lines.slice(), byId = (id) => doc.guides.find((x) => x.g.id === id);
  if (op.action === "add"){
    const g = op.guide, id = nextId(doc); lines.push(guideLine(id, g));   // the same title and author as another guide is allowed (user 2026-10-20); the page only warns
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
    if (u.after !== undefined && lines[at] !== u.after) throw new Error(`ไกด์ #${u.id} ถูกแก้หลังจากนั้นแล้ว ย้อนกลับไม่ได้`);   // an undo from a commit (the phone) never overwrites a later change
    const wasTomb = lines[at].trim().startsWith("//");
    lines[at] = u.before === null ? tombLine(u.id, u.g) : u.before;
    const what = u.before === null ? `is removed again (undo of its addition: ${u.g.title} by ${u.g.author})` : wasTomb ? `is restored (${u.g.title} by ${u.g.author})` : "is back to its previous version";
    return { id: u.id, lines, subject: subj(`fix(bible): class guide #${u.id} ${what}`), undo: null };
  }
  throw new Error("unknown action " + op.action);
}
// A batch: each change is planned on the lines the previous one left, so ids and tombstones see the earlier changes. Guide changes work on the
// CLASS_GUIDES lines and donor changes on the DONORS lines, each in queue order.
// Resolves to { lines, donorLines, items: [{ action, id | k, subject }], subject, changelog, undo: [entries, in order] }. With donor items the
// subject is every item's subject joined by "; ", and changelog is the subject the guides alone would give (null when there are none).
function planAll(ops, doc){
  const items = [], undo = [];
  ops.forEach((op, i) => {
    let p;
    try { p = plan(op, doc); } catch (e){ throw new Error(ops.length > 1 ? `รายการที่ ${i + 1}: ${e.message}` : e.message); }
    if (p.undo) undo.push(p.undo);
    if (p.donorLines){ items.push({ action: op.action, k: p.k, subject: p.subject }); doc = { ...doc, donors: { ...doc.donors, lines: p.donorLines, donations: donationsIn(p.donorLines) } }; return; }
    items.push({ action: op.action, id: p.id, subject: p.subject });
    doc = { ...doc, lines: p.lines, ...parse(p.lines) };
  });
  const gOps = ops.filter((o) => !isDonorOp(o)), gItems = items.filter((x) => !("k" in x));
  const guides = gItems.length === 1 ? gItems[0].subject
    : subj(`${gOps.some((o) => o.action === "add") ? "feat" : "fix"}(bible): class guides ${gItems.map((x) => x.subject.replace(/^(feat|fix)\(bible\): class guide /, "")).join("; ")}`);
  const subject = gItems.length === items.length ? guides : items.map((x) => x.subject).join("; ");
  return { lines: doc.lines, donorLines: doc.donors.lines, items, subject, changelog: gItems.length ? guides : null, undo };
}
// The page's queue items ({ action, id, code, modes }, { action: "donor-add", donor: { id, name, msg, amount, date } }, { action: "donor-remove", k })
// as changes; an error names its item.
function opsFromItems(items){
  if (!Array.isArray(items) || !items.length) throw new Error("ไม่มีรายการ");
  return items.map((it, i) => {
    if (it.action === "delete") return { action: "delete", id: +it.id };
    if (it.action === "donor-add" || it.action === "donor-remove"){ try { return donorOp(it); } catch (e){ throw new Error(`รายการที่ ${i + 1}: ${e.message}`); } }
    let g; try { g = decodeCode(it.code); } catch (e){ throw new Error(`รายการที่ ${i + 1}: ${e.message}`); }
    stampGuide(g); if (Array.isArray(it.modes)) g.modes = pickModes(it.modes);
    if (!(g.modes || []).length) throw new Error(`รายการที่ ${i + 1}: เลือก PVE / PVP อย่างน้อยหนึ่งอย่าง`);
    return { action: it.action === "replace" ? "replace" : "add", id: +it.id, guide: g };
  });
}
// Two guides with the same content (key order, id and PVE / PVP left out: the page sets those), for the page's "nothing would change"
// warning on a replacement (user 2026-10-20). The page's gmSameGuide does the same; the validator checks they agree.
function sameGuide(a, b){
  const norm = (v) => Array.isArray(v) ? v.map(norm) : v && typeof v === "object" ? Object.keys(v).sort().reduce((o, k) => (o[k] = norm(v[k]), o), {}) : v;
  const strip = ({ id, modes, date, published, ...g }) => g;   // the upload stamp (date, published) is set by the upload, not by the code
  return JSON.stringify(norm(strip(a))) === JSON.stringify(norm(strip(b)));
}
const undoText = (entries) => entries.length === 1 ? entries[0].text : `ย้อนกลับชุดล่าสุด ${entries.length} รายการ (${entries.map((u) => u.kind === "donor" ? "☕" : "#" + u.id).join(", ")})`;
// A CLASS_GUIDES line rewritten the way this script writes it (guideLine / tombLine), so an undo never puts a commit's raw text back.
function canonLine(line){
  const t = String(line).trim(), r = t.match(/^\/\/ #(\d+) removed (\d{4}-\d{2}-\d{2}): (.*)$/);
  if (r) return `  // #${r[1]} removed ${r[2]}: ${clean(r[3])}`;
  if (t.startsWith("{")){ const { id, ...g } = JSON.parse(t.replace(/,$/, "")); if (Number.isInteger(id) && id > 0) return guideLine(id, g); }
  throw new Error("undo: not a CLASS_GUIDES line");
}
// The undo of a publish made elsewhere (the phone), from its commit: every CLASS_GUIDES line the commit changed goes back, as the
// page's own undo does (an added guide becomes a tombstone), unless that line has changed since (after = what the commit wrote). DONORS lines
// are matched by their key k the same way, and a line put back is rebuilt by donorLine. The parent is fetched when the checkout is shallow.
function undoOpsFromCommit(sha){
  if (!/^[0-9a-f]{40}$/.test(String(sha))) throw new Error("undo: not a commit id");
  try { git("cat-file", "-e", sha + "^"); } catch (e){ git("fetch", "-q", "--depth=2", "origin", sha); }
  const show = (rev) => { const doc = parseDoc(execFileSync("git", ["show", rev + ":" + REL], { cwd: ROOT, encoding: "utf8", maxBuffer: 1 << 28 })); return { ...doc, donors: doc.html.includes("const DONORS = [") ? parseDonors(doc.html) : { lines: [], donations: [] } }; };   // none before 2026-10-23
  const was = show(sha + "^"), now = show(sha), lineOf = (doc, id) => { const at = lineAt(doc, id); return at < 0 ? null : doc.lines[at]; };
  const entries = [...now.guides.map((x) => ({ at: x.at, id: x.g.id })), ...now.removed].sort((a, b) => a.at - b.at).flatMap(({ id }) => {
    const before = lineOf(was, id), after = lineOf(now, id), g = now.guides.find((x) => x.g.id === id);
    if (before === after) return [];
    const text = before === null ? `ลบไกด์ #${id} ที่เพิ่งเพิ่ม` : g ? `คืนไกด์ #${id} เป็นฉบับก่อนแทนที่` : `คืนไกด์ #${id} ที่เพิ่งลบ`;
    return [{ id, before: before === null ? null : canonLine(before), after, g: g ? g.g : was.guides.find((x) => x.g.id === id).g, text }];
  });
  const donor = (doc, k) => doc.donors.donations.find((t) => t.x.k === k);
  const donorEntries = [...new Set([...now.donors.donations, ...was.donors.donations].map((t) => t.x.k))].flatMap((k) => {
    const b = donor(was, k), a = donor(now, k), after = a ? now.donors.lines[a.at] : null;
    if (b && a && was.donors.lines[b.at] === after) return [];
    return [{ kind: "donor", k, before: b ? donorLine(b.x) : null, after, text: b ? "คืนการสนับสนุนที่เพิ่งเอาออก" : "เอาการสนับสนุนที่เพิ่งเพิ่มออก" }];
  });
  if (!entries.length && !donorEntries.length) throw new Error("commit นี้ไม่ได้เปลี่ยนไกด์ จึงไม่มีอะไรให้ย้อนกลับ");
  return [...entries, ...donorEntries].reverse().map((entry) => ({ action: "undo", entry }));
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
// The pipeline in stages, so the guide-manager workflow (.github/workflows/guide-manager.yml) can run each as its own step and the phone can
// tick them; apply() runs them in one go on this PC. ui = { step(key, text, state), log(text) }.
function stageGit(ops, { fetch }, ui){
  ui.step("git", "ตรวจสถานะ git", "run");
  const branch = preflight(fetch), doc = readGuides(), p = planAll(ops, doc);
  ui.step("git", "ตรวจสถานะ git", "ok");
  return { branch, doc, p };
}
function stageEdit(doc, p, ui){
  ui.step("edit", "แก้ไฟล์ index.html", "run");
  let out = doc.head + p.lines.join(doc.eol) + doc.tail;
  if (JSON.stringify(p.donorLines) !== JSON.stringify(doc.donors.lines)){   // DONORS is found again in the new text: the guide lines before it may have moved it
    const d = parseDonors(out);
    out = d.head + p.donorLines.map((l) => l + d.eol).join("") + d.tail.slice(d.tail.startsWith(d.eol) ? d.eol.length : 0);   // an empty block's tail starts at "];"
  }
  if (p.changelog){   // the guides' part only: a donor change makes no changelog entry (user 2026-10-23)
    const top = "  entries: [" + doc.eol, at = out.indexOf(top, out.indexOf("const CHANGELOG_DATA = {"));
    if (at < 0) throw new Error("CHANGELOG_DATA was not found in " + REL);
    out = out.slice(0, at + top.length) + "    " + JSON.stringify([new Date().toISOString(), p.changelog]) + "," + doc.eol + out.slice(at + top.length);
  }
  fs.writeFileSync(FILE, out);
  ui.step("edit", "แก้ไฟล์ index.html", "ok");
}
// The validator's own "[XYZ ERROR] ..." lines, not the source and stack lines under them.
function validatorErrorLines(out){
  const all = out.split(/\r?\n/), tagged = all.filter((l) => /^\s*\[[A-Z0-9 _-]*ERROR\]/.test(l));
  const lines = tagged.length ? tagged : all.filter((l) => /ERROR|Error/.test(l));
  return (lines.length ? lines : out.trim().split(/\r?\n/).slice(-12)).slice(0, 14);
}
async function stageCheck(ui){
  ui.step("check", "ตรวจด้วย validator", "run");
  const c = await runNode("scripts/validate_skills.js", []);   // plain, not --full (user 2026-10-23): its extra damage-range check is for damage code, which guides and donors never touch
  if (c.status !== 0){
    ui.step("check", "ตรวจด้วย validator", "fail");
    const lines = validatorErrorLines(c.out);
    ui.log(lines.join("\n"));
    throw Object.assign(new Error("ไกด์ไม่ผ่านการตรวจ จึงไม่ได้อัปอะไรขึ้น และ index.html กลับเป็นเหมือนเดิมแล้ว"), { lines });
  }
  ui.step("check", "ตรวจด้วย validator", "ok");
}
const backupDir = () => { const dir = path.join(os.tmpdir(), "12t-bible-backups"); fs.mkdirSync(dir, { recursive: true }); return dir; };
async function stageCommit(subject, ui){
  ui.step("commit", "commit", "run");
  const msg = path.join(backupDir(), "commit-msg.txt"); fs.writeFileSync(msg, subject + "\n");
  await gitRetry(ui, "add", "--", REL); await gitRetry(ui, "commit", "-q", "-F", msg);
  ui.step("commit", "commit", "ok");
}
function stagePush(branch, ui, failText = "commit ในเครื่องแล้ว แต่อัปขึ้น GitHub ไม่สำเร็จ ลองใหม่ภายหลังด้วย git push"){
  ui.step("push", "อัปขึ้น GitHub", "run");
  try { git("push", "-q", "origin", branch); } catch (e) {}   // the local tracking ref sometimes fails to update here; what counts is what GitHub has
  const sha = git("rev-parse", "HEAD"), remote = git("ls-remote", "origin", "refs/heads/" + branch).split(/\s+/)[0];
  if (remote !== sha){ ui.step("push", "อัปขึ้น GitHub", "fail"); throw new Error(failText); }
  try { git("update-ref", "refs/remotes/origin/" + branch, sha); } catch (e) {}
  ui.step("push", "อัปขึ้น GitHub", "ok");
  return sha;
}
// ops = the changes, in order; resolves to { items: [{ action, id, subject, url } | { action, k, subject }], subject, undo, dry }
async function apply(ops, { dryRun = false, noPush = NO_PUSH } = {}, ui){
  const { branch, doc, p } = stageGit(ops, { fetch: !dryRun && !noPush }, ui);
  const result = (extra) => ({ ...p, items: p.items.map((x) => "k" in x ? x : { ...x, url: SITE + "#class-guide/" + x.id }), ...extra });
  const backup = path.join(backupDir(), "index." + Date.now() + ".bak"); fs.copyFileSync(FILE, backup);
  let committed = false;
  try {
    stageEdit(doc, p, ui);
    await stageCheck(ui);
    if (dryRun){ fs.copyFileSync(backup, FILE); return result({ dry: true }); }
    await stageCommit(p.subject, ui); committed = true;
    if (noPush) return result();
    stagePush(branch, ui);
    return result();
  } catch (e){
    if (!committed){ try { git("reset", "-q", "--", REL); } catch (_) {} fs.copyFileSync(backup, FILE); }   // unstage too, or a failed commit leaves the new index.html staged
    throw e;
  }
}

// ---------- the workflow's batch command ----------
// node scripts/add_guide.js batch <request.json> --stage git|edit|check|commit|push [--dry-run]
// request: { "items": [{ action, id, code, modes } or a donor item, see opsFromItems] } (the page's queue) or { "undo": { "sha": "<commit>" } }.
// The edit stage keeps what it planned (subject, changelog, items) in <request.json>.plan.json for the later stages, since index.html has
// changed by then. On GitHub (GITHUB_ACTIONS=true) a failure is one "gm-error" annotation (the message, then the validator's lines) and the
// last stage reports a "gm-result" annotation, which the page reads back.
const ghEscape = (s) => String(s).replace(/%/g, "%25").replace(/\r/g, "%0D").replace(/\n/g, "%0A");
const NOTE_MAX = 4000;   // GitHub cuts an annotation's message at 4,096 characters (seen 2026-10-20); a long batch subject is shortened to fit
const clip = (s, n) => s.length > n ? s.slice(0, Math.max(0, n - 1)) + "…" : s;
async function batch(file, st){
  const onGitHub = process.env.GITHUB_ACTIONS === "true", dry = has("--dry-run"), planFile = file + ".plan.json";
  const ui = { step: (k, text, state) => { if (state !== "run") console.log((state === "ok" ? "ok   " : "FAIL ") + text); }, log: (t) => console.log(String(t).replace(/^/gm, "  ")) };   // indented: a raw line must never start with "::" (a GitHub workflow command)
  const report = (o) => {
    const r = { ok: true, dry, ...o }, over = JSON.stringify(r).length - NOTE_MAX;
    if (over > 0) r.subject = clip(r.subject, r.subject.length - over);
    const json = JSON.stringify(r); console.log(onGitHub ? "::notice title=gm-result::" + ghEscape(json) : json);
  };
  try {
    if (!["git", "edit", "check", "commit", "push"].includes(st)) throw new Error("--stage must be git, edit, check, commit or push");
    const req = JSON.parse(fs.readFileSync(file, "utf8"));
    const ops = () => req.undo ? undoOpsFromCommit(req.undo.sha) : opsFromItems(req.items);
    const saved = () => JSON.parse(fs.readFileSync(planFile, "utf8"));
    const summary = (s, sha) => ({ subject: s.subject, sha, items: s.items, undoText: dry ? null : s.undoText });   // a dry run leaves nothing to undo
    if (st === "git") stageGit(ops(), { fetch: false }, ui);
    if (st === "edit"){
      const { branch, doc, p } = stageGit(ops(), { fetch: false }, { step(){}, log(){} });
      fs.writeFileSync(planFile, JSON.stringify({ branch, subject: p.subject, changelog: p.changelog, items: p.items.map(({ action, id, k }) => k === undefined ? { action, id } : { action, k }), undoText: !req.undo && p.undo.length ? undoText(p.undo) : null }));
      stageEdit(doc, p, ui);
    }
    if (st === "check"){ await stageCheck(ui); if (dry) report(summary(saved(), null)); }
    if (st === "commit") await stageCommit(saved().subject, ui);
    if (st === "push"){ const s = saved(); report(summary(s, stagePush(s.branch, ui, "มีการเปลี่ยนแปลงบน GitHub ระหว่างทำงาน ลองใหม่อีกครั้ง"))); }
  } catch (e){
    const text = clip([e.message, ...(e.lines || [])].join("\n"), NOTE_MAX);
    if (onGitHub) console.log("::error title=gm-error::" + ghEscape(text)); else console.error("✗ " + text);
    process.exit(1);
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
  if (op && op.guide){ stampGuide(op.guide); console.log(`  Date: the upload time (${op.guide.published}).`); if (val("--modes")) op.guide.modes = pickModes(val("--modes").split(",").map((x) => x.trim().toLowerCase())); if (!(op.guide.modes || []).length) throw new Error("This code has no PVE / PVP tag (made with an older page). Add --modes pve, --modes pvp or --modes pve,pvp."); }
  else throw new Error("usage: see the header of scripts/add_guide.js");
  const p = planAll([op], readGuides());
  console.log("\n  " + p.subject + "\n");
  if (!has("--dry-run") && !has("--yes") && !/^y/i.test((await ask("Publish this? (y/n) ")).trim())) throw new Error("Cancelled. Nothing was changed.");
  const r = await apply([op], { dryRun: has("--dry-run") }, { step: (k, text, st) => { if (st !== "run") console.log((st === "ok" ? "  ok   " : st === "warn" ? "  !!   " : "  FAIL ") + text); }, log: (t) => console.log("    " + t.replace(/\n/g, "\n    ")) });
  console.log(r.dry ? `\n✓ #${r.items[0].id} passed every check (dry run: index.html is back as it was).` : `\n✓ Done: ${r.subject}\n  ${r.items[0].url}`);
}

// ---------- the page ----------
// 12t_projects/guide-manager/index.html, the same file GitHub Pages serves to the phone; here it gets this run's key and talks to the API below.
const PAGE_FILE = path.resolve(__dirname, "../12t_projects/guide-manager/index.html");
function pageData(){
  const doc = readGuides(), html = doc.html, views = (() => { try { return JSON.parse((html.match(/^const CLASS_GUIDE_VIEWS = (\{.*?\});/m) || [])[1]).counts || {}; } catch (e){ return {}; } })();
  let dirty = false, branch = "?"; try { dirty = !!git("status", "--porcelain", "--", REL); branch = git("rev-parse", "--abbrev-ref", "HEAD"); } catch (e) {}
  return {
    branch, dirty, next: nextId(doc), push: !NO_PUSH,
    guides: doc.guides.map(({ g }) => ({ id: g.id, modes: g.modes || [], title: g.title, author: g.author, classKey: g.build.classKey, server: g.build.server, level: g.build.level, date: g.date || "", views: views[g.id] || 0 })).sort((a, b) => b.id - a.id),
    removed: doc.removed.map((r) => r.text).reverse(),
    donations: doc.donors.donations.map(({ x }) => ({ k: x.k, id: x.id, name: x.name, msg: x.msg, amount: x.amount, date: x.date })),   // file order
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
      res.end(fs.readFileSync(PAGE_FILE, "utf8").replace("__KEY__", key)); return;
    }
    if (req.headers["x-key"] !== key || (req.headers.origin && req.headers.origin !== "http://" + host)){ res.writeHead(403); res.end(); return; }
    try {
      if (req.method === "GET" && req.url === "/api/state") return json(res, 200, { ...pageData(), busy, undo: undos.length ? undos[undos.length - 1].text : null });   // undos: one { entries, text } per publish
      if (req.method === "POST" && req.url === "/api/check"){
        const b = await body(req), doc = readGuides();
        try {
          const g = decodeCode(b.code), same = doc.guides.find((x) => x.g.title === g.title && x.g.author === g.author && x.g.id !== +b.replaceId);
          const target = b.replaceId ? doc.guides.find((x) => x.g.id === +b.replaceId) : null;
          return json(res, 200, { ok: true, guide: { modes: g.modes || [], title: g.title, author: g.author, classKey: g.build.classKey, server: g.build.server, level: g.build.level }, id: b.replaceId ? +b.replaceId : nextId(doc), duplicate: same ? { id: same.g.id, title: same.g.title } : null, unchanged: !!target && sameGuide(g, target.g) });
        } catch (e){ return json(res, 200, { ok: false, error: e.message }); }
      }
      if (req.method === "POST" && (req.url === "/api/run" || req.url === "/api/undo")){
        if (busy) return json(res, 409, { error: "กำลังทำงานอื่นอยู่" });
        const b = await body(req), isUndo = req.url === "/api/undo", ops = [];
        if (isUndo){ if (!undos.length) return json(res, 400, { error: "ไม่มีอะไรให้ย้อนกลับ" }); undos[undos.length - 1].entries.slice().reverse().forEach((entry) => ops.push({ action: "undo", entry })); }
        else { try { ops.push(...opsFromItems(b.items)); } catch (e){ return json(res, 400, { error: e.message }); } }
        busy = true;
        res.writeHead(200, { "Content-Type": "application/x-ndjson; charset=utf-8", "Cache-Control": "no-store", "X-Content-Type-Options": "nosniff" });
        const send = (o) => res.write(JSON.stringify(o) + "\n");
        try {
          const r = await apply(ops, { dryRun: !!b.dryRun }, { step: (k, text, state) => send({ type: "step", key: k, text, state }), log: (text) => send({ type: "log", text }) });
          if (!r.dry){
            if (isUndo) undos.pop();
            else if (r.undo.length) undos.push({ entries: r.undo, text: undoText(r.undo) });
          }
          send({ type: "done", ok: true, dry: !!r.dry, subject: r.subject, items: r.items });
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

// ---------- self-test ----------
// Throwaway repos in the temp folder (a work tree with a bare origin): a tiny CRLF index.html with guides #1 and #2 and one donation, and a stub
// validator that refuses any guide titled FAILME. Each repo gets a fresh copy of this module with GM_ROOT pointing at it; the batch stages run as child processes.
async function selftest(){
  const assert = require("assert"), { spawnSync } = require("child_process"), gc = require("./guide_code.js"), dn = require("./donors.js");
  const tmp = fs.mkdtempSync(path.join(os.tmpdir(), "gm-selftest-")), day = today();
  const sh = (cwd, ...a) => execFileSync("git", a, { cwd, encoding: "utf8", stdio: ["ignore", "pipe", "pipe"] }).trim();
  const guide = (title, author) => ({ format: "12t-class-guide", version: 1, title, author, date: "2026-10-01", description: "d", build: { server: "tot", classKey: "wolf", level: 100, learned: [101] }, modes: ["pve"], notes: {} });
  const code = (title, author) => gc.encode(guide(title, author));
  const OLD = { k: "aaaaaaaa", id: "11111111", name: "Old", msg: "", amount: 100, date: "2026-10-01T10:00" }, NEW = { id: "22222222", name: "New", msg: "ขอบคุณ", amount: 50, date: "2026-10-20T09:30" };
  const donorAdd = (d) => ({ action: "donor-add", donor: { ...NEW, ...d } });
  const STUB = 'const fs = require("fs"), path = require("path"), html = fs.readFileSync(path.join(__dirname, "..", "12t_projects/bible/index.html"), "utf8");\nif (html.includes("INJECTME")){ console.log("::notice title=gm-result::{\\"Error\\":1}"); process.exit(1); }\nif (html.includes("LONGFAIL")){ for (let i = 0; i < 14; i++) console.log("[CLASS GUIDE ERROR] " + "x".repeat(400)); process.exit(1); }\nif (html.includes("FAILME")){ console.log("[CLASS GUIDE ERROR] fixture refuses FAILME"); process.exit(1); }\n';
  let n = 0;
  function fixture(){
    const dir = path.join(tmp, "f" + ++n), origin = dir + ".git";
    fs.mkdirSync(path.join(dir, "12t_projects/bible"), { recursive: true }); fs.mkdirSync(path.join(dir, "scripts"));
    fs.writeFileSync(path.join(dir, REL), ["<script>", "const CLASS_GUIDES = [", guideLine(1, guide("T1", "A1")), guideLine(2, guide("T2", "A2")), "];", "const DONORS = [", dn.donorLine(OLD), "];", "const CHANGELOG_DATA = {", "  entries: [", '    ["2026-01-01T00:00:00.000Z", "init"],', "  ],", "};", "</script>", ""].join("\r\n"));
    fs.writeFileSync(path.join(dir, "scripts/validate_skills.js"), STUB);
    sh(tmp, "init", "-q", "--bare", origin);
    for (const a of [["init", "-q", "-b", "main"], ["config", "user.name", "Test"], ["config", "user.email", "test@example.com"], ["config", "core.autocrlf", "false"], ["add", "-A"], ["commit", "-q", "-m", "init"], ["remote", "add", "origin", origin], ["push", "-q", "-u", "origin", "main"]]) sh(dir, ...a);
    return dir;
  }
  const load = (dir) => { delete require.cache[__filename]; process.env.GM_ROOT = dir; try { return require(__filename); } finally { delete process.env.GM_ROOT; } };
  const quiet = () => { const logs = []; return { logs, step(){}, log: (t) => logs.push(t) }; };
  const html = (dir) => fs.readFileSync(path.join(dir, REL), "utf8");
  const head = (dir) => sh(dir, "rev-parse", "HEAD"), subject = (dir) => sh(dir, "log", "-1", "--format=%s");
  const newestEntry = (dir) => JSON.parse(html(dir).split("\r\n")[html(dir).split("\r\n").indexOf("  entries: [") + 1].trim().replace(/,$/, ""))[1];
  const changelog = (dir) => { const ls = html(dir).split("\r\n"), at = ls.indexOf("  entries: ["); return ls.slice(at + 1, ls.indexOf("  ],", at)).map((l) => JSON.parse(l.trim().replace(/,$/, ""))[1]); };
  const donorLines = (dir) => dn.parseDonors(html(dir)).lines, donations = (dir) => dn.parseDonors(html(dir)).donations.map((t) => t.x);
  const stage = (dir, req, st, ...extra) => spawnSync(process.execPath, [__filename, "batch", req, "--stage", st, ...extra], { cwd: dir, env: { ...process.env, GM_ROOT: dir, GITHUB_ACTIONS: "true" }, encoding: "utf8" });
  const request = (dir, obj) => { const f = path.join(dir, "..", path.basename(dir) + "-request.json"); fs.writeFileSync(f, JSON.stringify(obj)); return f; };
  const notice = (out) => JSON.parse(((out.match(/^::notice title=gm-result::(.*)$/m) || [])[1]) || "null");
  const pre = ["  " + JSON.stringify({ id: 1, ...guide("T1", "A1") }) + ",", "  " + JSON.stringify({ id: 2, ...guide("T2", "A2") }) + ","];
  const batchItems = [{ action: "add", code: code("T3", "A3"), modes: ["pve"] }, { action: "replace", id: 1, code: code("T1b", "A1"), modes: ["pve"] }, { action: "delete", id: 2 }];
  const batchSubject = "feat(bible): class guides #3 ToT Wolf T3 by A3; #1 is updated: ToT Wolf T1b by A1; #2 is removed (T2 by A2)";
  const cases = [];
  const test = (name, fn) => cases.push([name, fn]);

  test("an upload stamps the guide with its own date and time, whatever date the code carries (user 2026-10-23)", async () => {
    const m = load(fixture()), g = { author: "A", date: "2020-01-01", published: "2020-01-01T00:00:00Z", title: "T" };
    m.stampGuide(g, new Date("2026-10-22T18:30:05.999Z"));
    assert.deepStrictEqual(Object.keys(g), ["author", "date", "published", "title"]);
    assert.strictEqual(g.published, "2026-10-22T18:30:05Z"); assert.strictEqual(g.date, "2026-10-23");   // 01:30 on the 23rd in Thailand
    const [it] = m.opsFromItems([{ action: "replace", id: 1, code: code("T1b", "A1"), modes: ["pve"] }]);
    assert.ok(Math.abs(Date.parse(it.guide.published) - Date.now()) < 5000 && it.guide.date.length === 10);
  });
  test("add: next id, changelog entry = commit subject, pushed", async () => {
    const dir = fixture(), m = load(dir);
    await m.apply(m.opsFromItems([{ action: "add", code: code("T3", "A3"), modes: ["pve"] }]), {}, quiet());
    assert.ok(m.readGuides().lines.some((l) => l.startsWith('  {"id":3,')));
    assert.strictEqual(newestEntry(dir), "feat(bible): class guide #3 ToT Wolf T3 by A3");
    assert.strictEqual(subject(dir), "feat(bible): class guide #3 ToT Wolf T3 by A3");
    assert.strictEqual(sh(dir, "ls-remote", "origin", "refs/heads/main").split(/\s+/)[0], head(dir));
  });
  let batchLines = null, batchSha = null, batchDir = null;
  test("batch: add + replace + delete in one commit", async () => {
    const dir = batchDir = fixture(), m = load(dir);
    await m.apply(m.opsFromItems(batchItems), { noPush: true }, quiet());
    const lines = batchLines = m.readGuides().lines; batchSha = head(dir);
    assert.ok(lines[0].startsWith('  {"id":1,"format"') && lines[0].includes('"title":"T1b"'));
    assert.strictEqual(lines[1], `  // #2 removed ${day}: T2 by A2`);
    assert.ok(lines[2].startsWith('  {"id":3,') && lines[2].includes('"title":"T3"'));
    assert.strictEqual(subject(dir), batchSubject);
    assert.strictEqual(newestEntry(dir), batchSubject);
  });
  test("a guide the validator refuses: index.html as it was, nothing committed", async () => {
    const dir = fixture(), m = load(dir), before = html(dir), sha = head(dir), ui = quiet();
    await assert.rejects(m.apply(m.opsFromItems([{ action: "add", code: code("FAILME", "A9"), modes: ["pve"] }]), { noPush: true }, ui), /ไกด์ไม่ผ่านการตรวจ/);
    assert.strictEqual(html(dir), before); assert.strictEqual(head(dir), sha);
    assert.ok(ui.logs.join("\n").includes("[CLASS GUIDE ERROR] fixture refuses FAILME"));
    assert.strictEqual(sh(dir, "status", "--porcelain"), "");
  });
  test("--dry-run: checked, then index.html as it was, no commit", async () => {
    const dir = fixture(), m = load(dir), before = html(dir), sha = head(dir);
    const r = await m.apply(m.opsFromItems([{ action: "add", code: code("T3", "A3"), modes: ["pve"] }]), { dryRun: true }, quiet());
    assert.strictEqual(r.dry, true); assert.strictEqual(html(dir), before); assert.strictEqual(head(dir), sha);
  });
  test("uncommitted work in index.html: refused", async () => {
    const dir = fixture(), m = load(dir);
    fs.appendFileSync(path.join(dir, REL), " ");
    await assert.rejects(m.apply([{ action: "delete", id: 1 }], { noPush: true }, quiet()), /index\.html มีงานค้าง/);
  });
  test("undo from a commit: the batch is reversed, the added guide becomes a tombstone", async () => {
    const m = load(batchDir), ops = m.undoOpsFromCommit(batchSha);
    assert.deepStrictEqual(ops.map((o) => o.entry.id), [3, 2, 1]);
    await m.apply(ops, { noPush: true }, quiet());
    assert.deepStrictEqual(m.readGuides().lines, [...pre, `  // #3 removed ${day}: T3 by A3`]);
  });
  test("batch stages give the same file and subject as apply, and report it", async () => {
    const dir = fixture(), req = request(dir, { items: batchItems });
    let r;
    for (const st of ["git", "edit", "check", "commit", "push"]){ r = stage(dir, req, st); assert.strictEqual(r.status, 0, st + ": " + r.stdout + r.stderr); }
    const unstamped = (ls) => ls.map((l) => l.replace(/"date":"[^"]*","published":"[^"]*"/, '"date":"D","published":"P"'));   // each run stamps its own upload time
    assert.deepStrictEqual(unstamped(load(dir).readGuides().lines), unstamped(batchLines));
    assert.strictEqual(subject(dir), batchSubject);
    assert.strictEqual(sh(dir, "ls-remote", "origin", "refs/heads/main").split(/\s+/)[0], head(dir));
    assert.deepStrictEqual(notice(r.stdout), { ok: true, dry: false, subject: batchSubject, sha: head(dir), items: [{ action: "add", id: 3 }, { action: "replace", id: 1 }, { action: "delete", id: 2 }], undoText: "ย้อนกลับชุดล่าสุด 3 รายการ (#3, #1, #2)" });
    const undo = request(dir, { undo: { sha: head(dir) } });
    for (const st of ["git", "edit", "check", "commit", "push"]){ r = stage(dir, undo, st); assert.strictEqual(r.status, 0, "undo " + st + ": " + r.stdout + r.stderr); }
    assert.deepStrictEqual(load(dir).readGuides().lines, [...pre, `  // #3 removed ${day}: T3 by A3`]);
    assert.strictEqual(notice(r.stdout).undoText, null);
  });
  test("batch --dry-run reports at the check stage without a commit", async () => {
    const dir = fixture(), req = request(dir, { items: [batchItems[0]] }), sha = head(dir);
    let r;
    for (const st of ["git", "edit", "check"]){ r = stage(dir, req, st, "--dry-run"); assert.strictEqual(r.status, 0, st + ": " + r.stdout + r.stderr); }
    assert.deepStrictEqual(notice(r.stdout), { ok: true, dry: true, subject: "feat(bible): class guide #3 ToT Wolf T3 by A3", sha: null, items: [{ action: "add", id: 3 }], undoText: null });
    assert.strictEqual(head(dir), sha);
  });
  test("batch: a refused guide reports one gm-error annotation with the validator's lines", async () => {
    const dir = fixture(), req = request(dir, { items: [{ action: "add", code: code("FAILME", "A9"), modes: ["pve"] }] });
    for (const st of ["git", "edit"]) assert.strictEqual(stage(dir, req, st).status, 0);
    const r = stage(dir, req, "check"), errs = r.stdout.split(/\r?\n/).filter((l) => l.startsWith("::error title=gm-error::"));
    assert.strictEqual(r.status, 1); assert.strictEqual(errs.length, 1);
    assert.ok(errs[0].includes("ไกด์ไม่ผ่านการตรวจ") && errs[0].includes("%0A[CLASS GUIDE ERROR] fixture refuses FAILME"), errs[0]);
    const fresh = fixture();
    assert.strictEqual(stage(fresh, request(fresh, { items: [{ action: "delete", id: 9 }] }), "git").stdout.match(/^::error title=gm-error::(.*)$/m)[1], "ไม่มีไกด์ #9");
  });
  test("undo from a commit refuses when the guide was changed after it (spec: nothing goes up)", async () => {
    const dir = fixture(), m = load(dir);
    await m.apply(m.opsFromItems([{ action: "replace", id: 1, code: code("T1b", "A1"), modes: ["pve"] }]), { noPush: true }, quiet()); const first = head(dir);
    await m.apply(m.opsFromItems([{ action: "replace", id: 1, code: code("T1c", "A1"), modes: ["pve"] }]), { noPush: true }, quiet());
    const before = html(dir);
    await assert.rejects(m.apply(m.undoOpsFromCommit(first), { noPush: true }, quiet()), /ไกด์ #1 ถูกแก้หลังจากนั้นแล้ว ย้อนกลับไม่ได้/);
    assert.strictEqual(html(dir), before);
    await m.apply(m.undoOpsFromCommit(head(dir)), { noPush: true }, quiet());
    assert.ok(m.readGuides().lines[0].includes('"title":"T1b"'), "undoing the latest commit still works");
  });
  test("undo lines are rebuilt in the standard form (a commit's raw text never goes back in as is)", async () => {
    const m = load(fixture()), g = { ...guide("</script>", "A") };
    assert.strictEqual(m.canonLine("  " + JSON.stringify({ id: 2, ...g }) + ","), guideLine(2, g));
    assert.ok(m.canonLine("  " + JSON.stringify({ id: 2, ...g }) + ",").includes("\\u003c/script>"));
    assert.strictEqual(m.canonLine("  // #2 removed 2026-01-01: <b>x</b> by y"), "  // #2 removed 2026-01-01: b x /b by y");
    assert.throws(() => m.canonLine("  alert(1)"));
  });
  test("batch: raw validator output cannot pass as a GitHub command", async () => {
    const dir = fixture(), req = request(dir, { items: [{ action: "add", code: code("INJECTME", "A"), modes: ["pve"] }] });
    for (const st of ["git", "edit"]) assert.strictEqual(stage(dir, req, st).status, 0);
    const r = stage(dir, req, "check");
    assert.strictEqual(r.status, 1); assert.ok(!/^::notice/m.test(r.stdout), r.stdout);
  });
  test("undo from a shallow clone fetches the commit's parent (GitHub checks out one commit)", async () => {
    const dir = fixture(), req = request(dir, { items: batchItems });
    for (const st of ["git", "edit", "check", "commit", "push"]) assert.strictEqual(stage(dir, req, st).status, 0);
    const shallow = path.join(tmp, "shallow" + n);
    sh(tmp, "clone", "-q", "--depth", "1", "-b", "main", "file://" + (dir + ".git").replace(/\\/g, "/"), shallow);
    assert.deepStrictEqual(load(shallow).undoOpsFromCommit(head(dir)).map((o) => o.entry.id), [3, 2, 1]);
  });
  test("a code whose class or server is not a real one is refused (it would reach the page's HTML)", async () => {
    const m = load(fixture()), bad = (build) => gc.encode1({ ...guide("T9", "A9"), build: { ...guide("T9", "A9").build, ...build } });
    assert.throws(() => m.opsFromItems([{ action: "add", code: bad({ classKey: "<img src=x onerror=alert(1)>" }), modes: ["pve"] }]), /โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ/);
    assert.throws(() => m.opsFromItems([{ action: "add", code: bad({ server: "zz" }), modes: ["pve"] }]), /โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ/);
    assert.strictEqual(m.opsFromItems([{ action: "add", code: gc.encode1(guide("T9", "A9")), modes: ["pve"] }]).length, 1);
  });
  test("batch: annotations stay within GitHub's 4,096 characters", async () => {
    const unescape = (s) => s.replace(/%0D/g, "\r").replace(/%0A/g, "\n").replace(/%25/g, "%");
    const dir = fixture(), req = request(dir, { items: Array.from({ length: 12 }, (_, i) => ({ action: "add", code: code("T".repeat(390) + i, "A"), modes: ["pve"] })) });
    let r;
    for (const st of ["git", "edit", "check"]){ r = stage(dir, req, st, "--dry-run"); assert.strictEqual(r.status, 0, st + ": " + r.stderr); }
    const msg = unescape(r.stdout.match(/^::notice title=gm-result::(.*)$/m)[1]), res = JSON.parse(msg);
    assert.ok(msg.length <= 4096, "gm-result is " + msg.length); assert.strictEqual(res.items.length, 12); assert.ok(res.subject.endsWith("…"));
    const bad = fixture(), breq = request(bad, { items: [{ action: "add", code: code("LONGFAIL", "A"), modes: ["pve"] }] });
    for (const st of ["git", "edit"]) assert.strictEqual(stage(bad, breq, st).status, 0);
    const err = unescape(stage(bad, breq, "check").stdout.match(/^::error title=gm-error::(.*)$/m)[1]);
    assert.ok(err.length <= 4096 && err.startsWith("ไกด์ไม่ผ่านการตรวจ"), "gm-error is " + err.length);
  });
  test("batch: a push GitHub rejects says the repo changed meanwhile", async () => {
    const dir = fixture(), req = request(dir, { items: [batchItems[0]] }), other = path.join(tmp, "other" + n);
    for (const st of ["git", "edit", "check", "commit"]) assert.strictEqual(stage(dir, req, st).status, 0);
    sh(tmp, "clone", "-q", "-b", "main", dir + ".git", other); sh(other, "-c", "user.name=T", "-c", "user.email=t@example.com", "commit", "-q", "--allow-empty", "-m", "meanwhile"); sh(other, "push", "-q", "origin", "main");
    const r = stage(dir, req, "push");
    assert.strictEqual(r.status, 1); assert.match(r.stdout, /^::error title=gm-error::มีการเปลี่ยนแปลงบน GitHub ระหว่างทำงาน ลองใหม่อีกครั้ง/m);
  });
  test("donor-add alone: a DONORS line, subject names the donor, no changelog entry", async () => {
    const dir = fixture(), m = load(dir);
    const r = await m.apply(m.opsFromItems([donorAdd({ name: " New\r\n" })]), { noPush: true }, quiet());   // checkDonation takes the line break out
    const [old, added] = donations(dir);
    assert.deepStrictEqual(old, OLD); assert.match(added.k, /^[0-9a-f]{8}$/); assert.deepStrictEqual(added, { k: added.k, ...NEW });
    assert.deepStrictEqual(donorLines(dir), [dn.donorLine(OLD), dn.donorLine(added)]);
    assert.deepStrictEqual(changelog(dir), ["init"]); assert.strictEqual(newestEntry(dir), "init");
    assert.strictEqual(subject(dir), "feat(bible): ขอบคุณผู้สนับสนุน New");
    assert.deepStrictEqual(r.items, [{ action: "donor-add", k: added.k, subject: "feat(bible): ขอบคุณผู้สนับสนุน New" }]);
    assert.deepStrictEqual(m.readGuides().lines, pre);
    assert.deepStrictEqual(m.pageData().donations, [OLD, added]);
  });
  test("donor-remove: the line goes, subject has no name", async () => {
    const dir = fixture(), m = load(dir);
    await assert.rejects(m.apply(m.opsFromItems([{ action: "donor-remove", k: "bbbbbbbb" }]), { noPush: true }, quiet()), /ไม่มีการสนับสนุนรหัส bbbbbbbb/);
    await m.apply(m.opsFromItems([{ action: "donor-remove", k: "aaaaaaaa" }]), { noPush: true }, quiet());
    assert.strictEqual(subject(dir), "fix(bible): remove a donation");
    assert.ok(!html(dir).includes('"Old"')); assert.ok(html(dir).includes("];\r\nconst DONORS = [\r\n];\r\nconst CHANGELOG_DATA"), "an empty block, no blank line left");
    assert.deepStrictEqual(changelog(dir), ["init"]);
    await m.apply(m.opsFromItems([donorAdd()]), { noPush: true }, quiet());   // the real list starts empty
    assert.ok(html(dir).includes("const DONORS = [\r\n" + dn.donorLine(donations(dir)[0]) + "\r\n];\r\nconst CHANGELOG_DATA"));
  });
  test("mixed batch: guide add + donor add", async () => {
    const dir = fixture(), m = load(dir);
    const r = await m.apply(m.opsFromItems([batchItems[0], donorAdd()]), { noPush: true }, quiet());
    assert.strictEqual(subject(dir), "feat(bible): class guide #3 ToT Wolf T3 by A3; feat(bible): ขอบคุณผู้สนับสนุน New");
    assert.deepStrictEqual(changelog(dir), ["feat(bible): class guide #3 ToT Wolf T3 by A3", "init"]);
    assert.deepStrictEqual(r.items.map((x) => x.url || x.k), [SITE + "#class-guide/3", donations(dir)[1].k]);
    assert.strictEqual(m.undoText(r.undo), "ย้อนกลับชุดล่าสุด 2 รายการ (#3, ☕)");
    await m.apply(r.undo.slice().reverse().map((entry) => ({ action: "undo", entry })), { noPush: true }, quiet());   // the page's own undo
    assert.deepStrictEqual(m.readGuides().lines, [...pre, `  // #3 removed ${day}: T3 by A3`]);
    assert.deepStrictEqual(donorLines(dir), [dn.donorLine(OLD)]);
    assert.strictEqual(subject(dir), "fix(bible): remove a donation; fix(bible): class guide #3 is removed again (undo of its addition: T3 by A3)");
    assert.strictEqual(newestEntry(dir), "fix(bible): class guide #3 is removed again (undo of its addition: T3 by A3)");
  });
  test("a bad donor item names its position", async () => {
    const dir = fixture(), m = load(dir), before = html(dir), sha = head(dir);
    await assert.rejects(async () => m.apply(m.opsFromItems([batchItems[0], donorAdd({ amount: 0 })]), { noPush: true }, quiet()), /รายการที่ 2: ยอดเงินต้องมากกว่า 0/);
    for (const id of ["XYZ", "1111111G", 11111111, undefined]) assert.throws(() => m.opsFromItems([donorAdd({ id })]), /รายการที่ 1: รหัสผู้สนับสนุนไม่ถูกต้อง/);
    assert.throws(() => m.opsFromItems([batchItems[0], { action: "donor-remove", k: "<b>" }]), /รายการที่ 2: รหัสการสนับสนุนไม่ถูกต้อง/);
    assert.strictEqual(html(dir), before); assert.strictEqual(head(dir), sha);
  });
  test("undo from a commit reverses donor add and remove", async () => {
    const dir = fixture(), m = load(dir), was = donorLines(dir);
    await m.apply(m.opsFromItems([donorAdd(), { action: "donor-remove", k: "aaaaaaaa" }]), { noPush: true }, quiet()); const sha = head(dir);
    assert.strictEqual(subject(dir), "feat(bible): ขอบคุณผู้สนับสนุน New; fix(bible): remove a donation");
    const ops = m.undoOpsFromCommit(sha);
    assert.deepStrictEqual(ops.map((o) => [o.entry.kind, o.entry.k, o.entry.text]), [["donor", "aaaaaaaa", "คืนการสนับสนุนที่เพิ่งเอาออก"], ["donor", donations(dir)[0].k, "เอาการสนับสนุนที่เพิ่งเพิ่มออก"]]);
    await m.apply(ops, { noPush: true }, quiet());
    assert.deepStrictEqual(donorLines(dir), was);
    assert.strictEqual(subject(dir), "fix(bible): restore a donation; fix(bible): remove a donation"); assert.deepStrictEqual(changelog(dir), ["init"]);
    await assert.rejects(m.apply(m.undoOpsFromCommit(sha), { noPush: true }, quiet()), /การสนับสนุนนี้ถูกแก้หลังจากนั้นแล้ว ย้อนกลับไม่ได้/);
  });
  test("batch stages: a donor-only request passes git→push", async () => {
    const dir = fixture(), req = request(dir, { items: [donorAdd()] });
    let r;
    for (const st of ["git", "edit", "check", "commit", "push"]){ r = stage(dir, req, st); assert.strictEqual(r.status, 0, st + ": " + r.stdout + r.stderr); }
    const k = donations(dir)[1].k;
    assert.deepStrictEqual(notice(r.stdout).items, [{ action: "donor-add", k }]);
    assert.deepStrictEqual(notice(r.stdout), { ok: true, dry: false, subject: "feat(bible): ขอบคุณผู้สนับสนุน New", sha: head(dir), items: [{ action: "donor-add", k }], undoText: "เอาการสนับสนุนที่เพิ่งเพิ่มออก" });
    assert.strictEqual(JSON.parse(fs.readFileSync(req + ".plan.json", "utf8")).changelog, null);
    assert.deepStrictEqual(changelog(dir), ["init"]);
    assert.strictEqual(sh(dir, "ls-remote", "origin", "refs/heads/main").split(/\s+/)[0], head(dir));
    const undo = request(dir, { undo: { sha: head(dir) } });
    for (const st of ["git", "edit", "check", "commit", "push"]){ r = stage(dir, undo, st); assert.strictEqual(r.status, 0, "undo " + st + ": " + r.stdout + r.stderr); }
    assert.deepStrictEqual(donorLines(dir), [dn.donorLine(OLD)]); assert.strictEqual(subject(dir), "fix(bible): remove a donation"); assert.deepStrictEqual(changelog(dir), ["init"]);
  });
  test("a name with </script> stays escaped through the batch", async () => {
    const dir = fixture(), req = request(dir, { items: [donorAdd({ name: "</script><!--x", msg: "<b>hi</b>" })] });
    let r;
    for (const st of ["git", "edit", "check", "commit", "push"]){ r = stage(dir, req, st); assert.strictEqual(r.status, 0, st + ": " + r.stdout + r.stderr); }
    const out = html(dir), x = donations(dir)[1];
    assert.strictEqual(out.split("</script>").length, 2, "only the fixture's own closing tag"); assert.ok(!out.includes("<!--"));
    assert.strictEqual(x.name, "</script><!--x"); assert.strictEqual(x.msg, "<b>hi</b>"); assert.strictEqual(donorLines(dir)[1], dn.donorLine(x));
    assert.strictEqual(subject(dir), "feat(bible): ขอบคุณผู้สนับสนุน /script!--x"); assert.strictEqual(notice(r.stdout).subject, subject(dir));
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
const words = args.filter((a, i) => !a.startsWith("--") && !["--port", "--modes", "--stage"].includes(args[i - 1]));
if (require.main !== module) module.exports = { planAll, readGuides, parseDonors, pageData, parse, nextId, findCode, stampGuide, canonLine, sameGuide, opsFromItems, undoText, undoOpsFromCommit, validatorErrorLines, stageGit, stageEdit, stageCheck, stageCommit, stagePush, apply };   // for tests
else if (has("--selftest")) selftest().catch((e) => { console.error(e.message); process.exit(1); });
else if (words[0] === "batch") batch(words[1], val("--stage"));
else if (words.length) cli(words).catch((e) => { console.error("\n✗ " + e.message); process.exit(1); });
else serve();
