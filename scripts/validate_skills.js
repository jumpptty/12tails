/**
 * Automated Skill Integrity & Mechanics Linter for 12Tails Reference Tools
 *
 * Verifies:
 * 1. Formula validity & evaluation across all rank (1..maxRank) and dependency toggle (0..maxRank) permutations.
 * 2. Icon existence in SKILL_ICONS and PNG header validity (89 50 4E 47 0D 0A 1A 0A).
 * 3. Array bounds for per-rank properties (cd, castTime, duration).
 * 4. Effect damage / penetrating damage flag alignment.
 * 5. LCK-invariant floor: the Raw chip ("ดาเมจดิบ", formerly "รวมการแกว่งค่า LCK")'s own
 *    minimum, computed by the REAL index.html `calcRangeFor` (exposed via a debug
 *    hook, not re-derived here to avoid drifting out of sync with it), must never
 *    move when the player's LCK stat changes -- LCK is a swing ABOVE a fixed floor,
 *    never a reduction of it. Checked by calling the real function once at a
 *    realistic LCK and once with LCK forced to 0 and diffing the two minimums,
 *    for every skill/rank whose damage text is an actual computable formula
 *    (same talAdjust/flat-literal/dmgGroups gate index.html itself uses to decide
 *    whether to show this chip at all -- opaque prose skills like Soul Eater/Nova
 *    Flare/Backpack correctly have no chip and are skipped here too).
 */

const fs = require('fs');
const vm = require('vm');
const path = require('path');
const { execFileSync } = require('child_process');

// --index <path> validates another copy of the page (with its assets.js beside it), e.g. a split made in the scratchpad
const indexArg = process.argv.indexOf('--index');
const targetPath = indexArg > 0 ? path.resolve(process.argv[indexArg + 1]) : path.resolve(__dirname, '../12t_projects/bible/index.html');
if (!fs.existsSync(targetPath)) {
  console.error("Target index.html not found at:", targetPath);
  process.exit(1);
}

const html = fs.readFileSync(targetPath, 'utf8');

// Whether index.html has pending changes (the rulebook reminder below and the --full auto-run read it). The changelog gate that sat here
// was removed at the user's request (2026-10-20: it hindered work in progress); a CHANGELOG_DATA entry is still added by habit with each
// commit that touches index.html (12t_projects/bible/CLAUDE.md §1), just no longer enforced.
const repoRoot = path.resolve(__dirname, '..');
const INDEX_REL = '12t_projects/bible/index.html';
let indexDirty = false;
try { execFileSync('git', ['diff', '--quiet', 'HEAD', '--', INDEX_REL], { cwd: repoRoot, stdio: 'ignore' }); } catch (error) { indexDirty = true; }

// Soft reminder (non-blocking): index.html
// changing without the rulebook changing alongside it isn't necessarily wrong --
// most edits (desc text, a new card following existing patterns) don't touch
// any documented convention -- but it's exactly the case that let the
// Status Keyword Rendering section silently drift out of date behind the
// real implementation earlier in this project's history. This only nudges;
// it never exits non-zero. Checks the working tree diff when dirty, or the
// most recent commit's own diff when clean, so it fires at the same two
// checkpoints: before commit, before push.
try {
  const repoRoot = path.resolve(__dirname, '..');
  const changedFiles = indexDirty
    ? execFileSync('git', ['diff', '--name-only', 'HEAD', '--'], { cwd: repoRoot, encoding: 'utf8' })
    : execFileSync('git', ['diff', '--name-only', 'HEAD~1', 'HEAD', '--'], { cwd: repoRoot, encoding: 'utf8' });
  const files = changedFiles.split('\n').filter(Boolean);
  const touchedIndex = files.some(f => f.endsWith('12t_projects/bible/index.html'));
  // The rulebook is 12t_projects/bible/CLAUDE.md (core) + .claude/skills/bible-*/SKILL.md (topics) since 2026-10-05.
  const touchedRules = files.some(f => f.endsWith('12t_projects/bible/CLAUDE.md') || /\.claude\/skills\/bible-[^/]+\/SKILL\.md$/.test(f));
  if (touchedIndex && !touchedRules) {
    console.log(`[RULEBOOK REMINDER] index.html changed without the Bible rulebook (12t_projects/bible/CLAUDE.md or a .claude/skills/bible-* skill) changing in the same ${indexDirty ? 'working tree diff' : 'commit'} -- if this introduced or changed a convention (new desc markdown, a new schema field, a new chip/layout mechanism), document it in the skill that owns the topic before ${indexDirty ? 'committing' : 'pushing'}. If it's just desc text or a new card following existing patterns, no action needed.`);
  }
} catch (error) {
  // Best-effort only (e.g. HEAD~1 doesn't exist yet on a repo's first commit) --
  // never block validation over this.
}

// Extract script content
const scriptStart = html.indexOf('<script>');
const scriptEnd = html.lastIndexOf('</script>');
let scriptCode = html.slice(scriptStart + 8, scriptEnd);

// Expose internal functions and variables to window
scriptCode = scriptCode.replace('const SKILLS =', 'window.SKILLS =');
scriptCode = scriptCode.replace('const SKILL_ICONS =', 'window.SKILL_ICONS =');
scriptCode = scriptCode.replace('const CLASS_HERO_ICONS =', 'window.CLASS_HERO_ICONS =');

// assets.js (2026-10-20): the images, 3D previews and sounds live in a versioned assets.js beside index.html (scripts/bible_assets.js).
// When index.html loads it, check its stamp, that it holds data only, and that index.html stays light, then run it ahead of the page.
const bibleAssets = require('./bible_assets.js');
let assetErrors = 0;
const assetTag = html.match(bibleAssets.TAG_RE);
if (assetTag) {
  const assetsPath = path.join(path.dirname(targetPath), 'assets.js');
  let assets;
  try { assets = bibleAssets.loadAssets(assetsPath); } catch (e) {
    console.error(`[ASSET FORMAT ERROR] ${assetsPath}: ${e.message}`);
    process.exit(1);
  }
  const assetsBuf = fs.readFileSync(assetsPath), have = bibleAssets.stampOf(assetsBuf);
  if (have !== assetTag[1]) { assetErrors++; console.error(`[ASSET VERSION ERROR] index.html asks for assets.js?v=${assetTag[1]} but the file is ${have}; run node scripts/bible_assets.js stamp`); }
  const uriBytes = bibleAssets.dataUriBytes(html);
  if (uriBytes > bibleAssets.ASSET_BUDGET) { assetErrors++; console.error(`[ASSET BUDGET ERROR] index.html embeds ${Math.round(uriBytes / 1024)} KB of data: URIs (limit ${bibleAssets.ASSET_BUDGET / 1024} KB); move them into assets.js (scripts/bible_assets.js)`); }
  scriptCode = assetsBuf.toString('utf8') + '\n' + scriptCode;
  console.log(`Verified assets.js: ${Object.keys(assets).length} containers, stamp ${have}`);
}

const exposeInjection = `
  window._getDmgText = getDmgText;
  window._substituteDmgVars = substituteDmgVars;
  window._renderOneDmgFormula = renderOneDmgFormula;
  window._renderShieldFormula = renderShieldFormula;
  window._rollOneHit = rollOneHit;
  window._resolveGroupAtkCoeff = resolveGroupAtkCoeff;
  window._resolveGroupHitCount = resolveGroupHitCount;
  window._getKOValue = getKOValue;
  window._reachNormalize = reachNormalize; window._reachPartsWith = reachPartsWith; window._reachBadgeText = reachBadgeText; window._reachMesh = reachMesh; window._reachDims = reachDims; window._reachProject = reachProject; window._reachColorMap = reachColorMap; window._reachOnEnemy = reachOnEnemy; window._reachSeqPlan = reachSeqPlan; window._reachSeqVis = reachSeqVis;
  window._depRanks = depRanks;
  window._skillRanks = skillRanks;
  window._selectSkill = selectSkill;
  window._getAvailableServers = getAvailableServers; window._getActiveSkill = getActiveSkill;
  window._getUsedPlayerStatKeys = getUsedPlayerStatKeys;
  window._monsterStats = MONSTER_STATS; window._mountMonsterStats = mountMonsterStats;
  window._getRenderedHeroHtml = () => displayEl.innerHTML;
  window._statInputs = { atk: atkEl, tal: talEl, agi: agiEl, int: intEl, cha: chaEl, lck: lckEl, enemyLck: enemyLckEl, enemyDef: enemyDefEl, lv: lvEl };
  window._ttoMagic = { ids: TTO_MAGIC_DMG };
  window._credits = { list: CONTRIBUTORS, render: renderRichText };
  window._statVal = statVal;
  window._selectEnemyPreset = selectEnemyPreset;
  window._enemyPresets = ENEMY_PRESETS;
  window._undoEnemyChange = undoEnemyChange;
  window._renderEnemyPicker = renderEnemyPicker;
  window._enemyPickerHtml = () => enemyPickerEl.innerHTML;
  window._selectedEnemyId = () => selectedEnemyId;
  window._setServer = (s) => { currentServer = s; };
  window._activeSimSkill = activeSimSkill;
  window._renderDmgToggle = renderDmgToggle;
  window._usesTdlRoll = usesTdlRoll;
  window._finalMult = { count: finalMultCountCalc, active: activeFinalMultMods, customBd: customBd, activeCustom: activeCustom, setServer: (s) => { bdServer = s; } };
  window._effectProc = { chance: effectProcChance, bonus: effectProcBonus, hitOk: effectProcHitOk, lastPurple: () => lastRollPurple, lastCrit: () => lastRollCrit, hasMix: skillHasPurpleMix };
  window._critView = { set: (v) => { critFormulaView = v; } };
  window._chameleonCritBase = chameleonCritBase;
  window._pandaSp = { set: (v) => { pandaCurrentSp = v; }, get: () => pandaCurrentSp };
  window._bisonStun = { set: (v) => { bisonStunDistance = v; }, get: () => bisonStunDistance, setHate: (v) => { bisonHate = v; }, getHate: () => bisonHate, setWeight: (v) => { bisonWeight = v; }, getWeight: () => bisonWeight };
  window._sheepCharge = { set: (t) => { sheepChargeTime = t; }, get: () => sheepChargeTime, seconds: sheepChargeSeconds, maxTime: sheepChargeMaxTime };
  window._rabbit = { setDistance: (kind, v) => { if (kind === "charge") rabbitChargeDistance = v; else rabbitComboDistance = v; }, setAim: (v) => { rabbitAimTime = v; }, getAim: () => rabbitAimTime, getDistance: (kind) => kind === "charge" ? rabbitChargeDistance : rabbitComboDistance, depExclusive: DEP_EXCLUSIVE };
`;
scriptCode = scriptCode.replace('function onSearchInput(){', exposeInjection + '\nfunction onSearchInput(){');

function makeEl() {
  return {
    innerHTML: "",
    innerText: "",
    value: "0",
    style: { setProperty: ()=>{} },
    dataset: {},
    classList: { add: ()=>{}, remove: ()=>{}, toggle: ()=>{}, contains: ()=>false },
    appendChild: ()=>{}, insertAdjacentHTML: ()=>{}, insertBefore: (n) => n,
    addEventListener: ()=>{},
    removeEventListener: ()=>{},
    querySelector: () => makeEl(),
    querySelectorAll: () => [],
    closest: () => null,
    // .parentElement/.parentNode are read (renderHero's stat-signature-glow
    // pass, `el.parentElement.className = ...`) by code paths this suite
    // didn't exercise until the LCK-invariance check below started calling
    // the real selectSkill()/renderHero() -- a plain object is enough, since
    // nothing ever reads these classNames back in this sandbox.
    parentElement: { className: "", style: {}, classList: { add: ()=>{}, remove: ()=>{}, toggle: ()=>{}, contains: ()=>false }, querySelector: () => null, insertAdjacentHTML: ()=>{} },
    getClientRects: () => [],
    parentNode: { className: "", style: {} },
    remove: ()=>{}, focus: ()=>{}, blur: ()=>{}, click: ()=>{},
    setAttribute: ()=>{}, getAttribute: () => null, removeAttribute: ()=>{},
    hidden: false,
    getBoundingClientRect: () => ({ top: 0, left: 0, bottom: 0, right: 0, width: 100, height: 100 })
  };
}

// Realistic seed values for the mount's own stat inputs, matching the
// defaults literally declared on each <input value="..."> in index.html's
// own template -- needed so calcRangeFor's LCK-driven roll is actually
// non-zero in this sandbox (a blank makeEl() stub reads back as "0" for
// every field, which would make the LCK-invariance check below vacuously
// true no matter what calcRangeFor does, since a 0 LCK roll is always 0
// regardless of any bug).
const DATA_ROLE_DEFAULTS = {
  atk:"128", def:"128", tal:"128", agi:"128", vit:"128", cha:"128", int:"128", lck:"128", lv:"100",
  enemyAtk:"128", enemyDef:"128", enemyTal:"128", enemyAgi:"128", enemyVit:"128", enemyCha:"128", enemyInt:"128", enemyLck:"128"
};
// $(sel, root) in index.html always calls root.querySelector(sel) fresh --
// a plain makeEl() stub returns a NEW blank object every call, so mutating
// one query result (e.g. to force LCK to 0) would never be visible to a
// later query for the same selector. This registry makes querySelector
// selector-stable (same object back every time), matching how the real
// mount caches each `const xEl = $(...)` once at mount time and keeps
// reading that same element's `.value` on every render.
const elementRegistry = new Map();
function makeSmartRoot() {
  const root = makeEl();
  root.querySelector = (sel) => {
    if (!elementRegistry.has(sel)) {
      const m = sel.match(/data-role="([^"]+)"/);
      const role = m ? m[1] : null;
      const el = makeEl();
      el.value = (role && DATA_ROLE_DEFAULTS[role] !== undefined) ? DATA_ROLE_DEFAULTS[role] : "0";
      elementRegistry.set(sel, el);
    }
    return elementRegistry.get(sel);
  };
  return root;
}

const sandbox = {
  console: console,
  Math: Math,
  parseFloat: parseFloat,
  parseInt: parseInt,
  String: String,
  Array: Array,
  Function: Function,
  Set: Set,
  Map: Map,
  makeEl: makeEl,
  makeSmartRoot: makeSmartRoot,
  requestAnimationFrame: (cb) => cb(),
  document: {
    documentElement: makeEl(),
    body: makeEl(),
    head: makeEl(),
    createElement: () => makeEl(),
    getElementById: (id) => makeEl(),
    querySelectorAll: () => [],
    querySelector: () => makeEl(),
    addEventListener: () => {}
  },
  location: { hash: "skill-details" },
  history: { replaceState: () => {} },
  setTimeout: () => {},
  clearTimeout: () => {},
  addEventListener: () => {}
};
sandbox.window = sandbox;

scriptCode += `
window._root = makeSmartRoot();
mountSkillCooldownLookup(window._root);
`;

try {
  vm.runInNewContext(scriptCode, sandbox);
} catch (e) {
  console.error("FATAL: Failed to execute index.html in sandbox:", e);
  process.exit(1);
}

const SKILLS = sandbox.SKILLS;
// Formula brackets are CSS-drawn spans since 2026-10-07 (.dmg-br-floor-l …); checks below read them back as the glyphs.
const BR_GLYPH = { "floor-l": "⌊", "floor-r": "⌋", "ceil-l": "⌈", "ceil-r": "⌉", "paren-l": "(", "paren-r": ")" };
const brToGlyph = (html) => String(html).replace(/<span class="dmg-br dmg-br-([a-z]+-[lr])"[^>]*><\/span>/g, (_, k) => BR_GLYPH[k] || "");
// A setter, because sections that re-mount the page assign these functions again.
for (const fn of ["_renderOneDmgFormula", "_getRenderedHeroHtml"]) {
  let wrapped = null;
  const wrap = (f) => { wrapped = typeof f === "function" ? (...args) => brToGlyph(f(...args)) : f; };
  wrap(sandbox[fn]);
  Object.defineProperty(sandbox, fn, { configurable: true, get: () => wrapped, set: wrap });
}
const SKILL_ICONS = sandbox.SKILL_ICONS;

if (!Array.isArray(SKILLS) || !SKILL_ICONS) {
  console.error("FATAL: SKILLS or SKILL_ICONS not exported correctly.");
  process.exit(1);
}

console.log(`Auditing ${SKILLS.length} skills and ${Object.keys(SKILL_ICONS).length} icons...\n`);

let errorCount = assetErrors;
let checkedFormulas = 0;
let checkedLckFloors = 0;
const lckEl = sandbox._root.querySelector('[data-role="lck"]');

// 1. Audit Icons
const pngHeader = Buffer.from([0x89, 0x50, 0x4e, 0x47, 0x0d, 0x0a, 0x1a, 0x0a]);

function checkIcon(key, context) {
  if (!key) return;
  if (!(key in SKILL_ICONS)) {
    console.error(`[ICON ERROR] Missing icon '${key}' referenced in ${context}`);
    errorCount++;
    return;
  }
  const data = SKILL_ICONS[key];
  const isWebp = data.startsWith('data:image/webp;base64,');   // upscaled icons ship as WebP (Penguin first, 2026-10-25)
  if (!isWebp && !data.startsWith('data:image/png;base64,')) {
    console.error(`[ICON ERROR] Icon '${key}' in ${context} does not have valid PNG or WebP data URI prefix`);
    errorCount++;
    return;
  }
  const buf = Buffer.from(data.replace(/^data:image\/(png|webp);base64,/, ''), 'base64');
  if (isWebp ? (buf.length < 12 || buf.toString('latin1', 0, 4) !== 'RIFF' || buf.toString('latin1', 8, 12) !== 'WEBP') : (buf.length < 8 || !buf.subarray(0, 8).equals(pngHeader))) {
    console.error(`[ICON ERROR] Icon '${key}' in ${context} has a corrupted ${isWebp ? 'WebP' : 'PNG'} header`);
    errorCount++;
  }
}

// 2. Audit Each Skill
SKILLS.forEach(sk => {
  const ctx = `${sk.class} > ${sk.name} (${sk.id})`;
  
  // Icon check
  checkIcon(sk.icon, `${ctx} [main icon]`);
  if (sk.cdDep) checkIcon(sk.cdDep.icon, `${ctx} [cdDep icon]`);
  if (sk.castDep) checkIcon(sk.castDep.icon, `${ctx} [castDep icon]`);
  if (sk.dmgDep) checkIcon(sk.dmgDep.icon, `${ctx} [dmgDep icon]`);
  if (sk.dmgRankDep) checkIcon(sk.dmgRankDep.icon, `${ctx} [dmgRankDep icon]`);
  if (sk.dmgMultDep) checkIcon(sk.dmgMultDep.icon, `${ctx} [dmgMultDep icon]`);
  if (sk.hitCountDep) checkIcon(sk.hitCountDep.icon, `${ctx} [hitCountDep icon]`);
  if (sk.dep) checkIcon(sk.dep.icon, `${ctx} [dep icon]`);
  if (sk.descDep) checkIcon(sk.descDep.icon, `${ctx} [descDep icon]`);
  if (sk.lckDiffDep) checkIcon(sk.lckDiffDep.icon, `${ctx} [lckDiffDep icon]`);
  if (sk.lckProc && sk.lckProc.dep) checkIcon(sk.lckProc.dep.icon, `${ctx} [lckProc dep icon]`);

  // Max Rank check
  const maxRank = sk.maxRank || 1;

  // Prohibited/Abolished properties check
  if ('dmgNote' in sk || sk.dmgNote !== undefined) {
    console.error(`[SCHEMA ERROR] ${ctx}: 'dmgNote' is permanently abolished and must not be present`);
    errorCount++;
  }

  // Passive skill schema check
  // Note: cd/castTime/cost/duration are allowed on a passive when it genuinely has one
  // (e.g. an internal proc cooldown, a real MP/SP-gated active it grants) per AGENTS.md
  // Section 5.B's revised (2026-09-15) exclusion rule -- this is rare, so authors should
  // still default to omitting them for a plain stat-modifier/dependency passive.
  if (sk.passive) {
    if (!sk.desc) {
      console.error(`[PASSIVE ERROR] ${ctx}: passive skills must provide a descriptive 'desc'`);
      errorCount++;
    }
  }

  // dmgGroups requires a top-level dmg/atkCoeff/ko mirroring the primary group
  // (AGENTS.md Section 4) -- omitting it makes getDmgText() return undefined,
  // which crashes renderHero() mid-render (this happened once already, with
  // Planet Breaker's original stub->card upgrade, 2026-09-15).
  if (sk.dmgGroups && sk.dmg === undefined) {
    console.error(`[DMGGROUPS ERROR] ${ctx}: dmgGroups present but no top-level 'dmg' -- this crashes renderHero() (see AGENTS.md Section 4)`);
    errorCount++;
  }

  // dmgGroups hit counts must sum to the top-level hitCount for every dep on/off
  // combination: rollHitCount() (Simulate) uses the top-level value and
  // resolveHitDmgText() walks the groups by hit index, so a mismatch silently
  // drops or repeats hits (Tiger Toss once simulated 1 hit instead of 2).
  // dmgModes cards (alternative modes/zones, not sequential hits) are exempt.
  // Mirrors resolveGroupValue(): a group's depOn is its own dep, else hitCountDep, else dep.
  if (sk.dmgGroups && !sk.dmgModes && typeof sk.hitCount === 'function' && !sk.hitCountDuration
      && sk.dmgGroups.every(g => g.hitCount !== undefined)) {
    const deps = [];
    const addDep = d => { if (d && !deps.includes(d)) deps.push(d); };
    sk.dmgGroups.forEach(g => addDep(g.dep || sk.hitCountDep || sk.dep));
    addDep(sk.hitCountDep); addDep(sk.dmgDep);
    for (let r = 1; r <= maxRank; r++) {
      for (let mask = 0; mask < (1 << deps.length); mask++) {
        const on = d => !!d && (mask & (1 << deps.indexOf(d))) !== 0;
        // groupVariant groups count only in their own outcome (validated in the base outcome here).
        const alt = sandbox.groupVariantIsAlt ? sandbox.groupVariantIsAlt(sk, r) : false;
        const groupSum = sk.dmgGroups.reduce((s, g) => {
          if (g.variant && (g.variant === "alt") !== alt) return s;
          const hc = g.hitCount;
          return s + (typeof hc === 'function' ? hc(r, on(g.dep || sk.hitCountDep || sk.dep)) : hc);
        }, 0);
        const top = sk.hitCount(r, on(sk.dmgDep), on(sk.hitCountDep));
        if (groupSum !== top) {
          const state = deps.map(d => `${d.id}=${on(d) ? 'on' : 'off'}`).join(', ');
          console.error(`[DMGGROUPS HITCOUNT ERROR] ${ctx} Rank ${r} (${state}): dmgGroups hit counts sum to ${groupSum} but top-level hitCount is ${top} -- Simulate would roll the wrong number of hits`);
          errorCount++;
        }
      }
    }
  }

  // Cast Time array check
  if (Array.isArray(sk.castTime) && sk.castTime.length !== maxRank) {
    console.error(`[CAST TIME ERROR] ${ctx}: castTime array length (${sk.castTime.length}) does not match maxRank (${maxRank})`);
    errorCount++;
  }

  // CD array check
  if (Array.isArray(sk.cd) && sk.cd.length !== maxRank) {
    console.error(`[CD ERROR] ${ctx}: cd array length (${sk.cd.length}) does not match maxRank (${maxRank})`);
    errorCount++;
  }

  // Duration array check
  if (Array.isArray(sk.duration) && sk.duration.length !== maxRank) {
    console.error(`[DURATION ERROR] ${ctx}: duration array length (${sk.duration.length}) does not match maxRank (${maxRank})`);
    errorCount++;
  }

  // Cost check
  if (sk.cost) {
    if (Array.isArray(sk.cost.mp) && sk.cost.mp.length !== maxRank) {
      console.error(`[COST ERROR] ${ctx}: cost.mp array length (${sk.cost.mp.length}) does not match maxRank (${maxRank})`);
      errorCount++;
    }
    if (Array.isArray(sk.cost.sp) && sk.cost.sp.length !== maxRank) {
      console.error(`[COST ERROR] ${ctx}: cost.sp array length (${sk.cost.sp.length}) does not match maxRank (${maxRank})`);
      errorCount++;
    }
    if ((sk.cost.sp || Array.isArray(sk.cost.sp)) && !['red', 'blue'].includes(sk.cost.spType)) {
      console.error(`[COST ERROR] ${ctx}: sp cost defined without valid spType ('red' | 'blue')`);
      errorCount++;
    }
    // No Free pill (user 2026-10-26): a card with no cost pills already says it costs nothing, so a skill without a cost omits `cost`.
    if (sk.cost.free !== undefined) {
      console.error(`[COST ERROR] ${ctx}: cost.free is gone (no Free pill since 2026-10-26); omit cost for a skill that costs nothing`);
      errorCount++;
    }
  }

  // Status Effect Profile check
  if (sk.status) {
    const statuses = Array.isArray(sk.status) ? sk.status : [sk.status];
    statuses.forEach((st, idx) => {
      if (!st.name || typeof st.name !== 'string') {
        console.error(`[STATUS ERROR] ${ctx}: status[${idx}] missing valid string name`);
        errorCount++;
      }
      if (!st.class || typeof st.class !== 'string') {
        console.error(`[STATUS ERROR] ${ctx}: status[${idx}] missing valid string classification ('class')`);
        errorCount++;
      }
      if (Array.isArray(st.sLv) && st.sLv.length !== maxRank) {
        console.error(`[STATUS ERROR] ${ctx}: status[${idx}].sLv array length (${st.sLv.length}) does not match maxRank (${maxRank})`);
        errorCount++;
      }
      for (let r = 1; r <= maxRank; r++) {
        try {
          const sLvVal = typeof st.sLv === 'function' ? st.sLv(r, 0) : (Array.isArray(st.sLv) ? st.sLv[r - 1] : (st.sLv !== undefined ? st.sLv : r));
          if (sLvVal === null || sLvVal === undefined || isNaN(sLvVal)) {
            console.error(`[STATUS ERROR] ${ctx} Rank ${r}: evaluated to invalid sLv -> ${sLvVal}`);
            errorCount++;
          }
        } catch (e) {
          console.error(`[STATUS EXCEPTION] ${ctx} Rank ${r}: ${e.message}`);
          errorCount++;
        }
      }
    });
  }

  // Formula and KO evaluation check across all permutations
  for (let r = 1; r <= maxRank; r++) {
    if (sk.ko !== undefined) {
      try {
        const koVal = sandbox._getKOValue(sk, r);
        if (koVal === null || koVal === undefined || koVal === "" || String(koVal).includes("NaN")) {
          console.error(`[KO ERROR] ${ctx} Rank ${r}: evaluated to invalid KO value -> ${koVal}`);
          errorCount++;
        }
      } catch (e) {
        console.error(`[KO EXCEPTION] ${ctx} Rank ${r}: ${e.message}`);
        errorCount++;
      }
    }

    if (sk.dmg) {
      const depMax = sk.dmgRankDep ? (sk.dmgRankDep.maxRank || 1) : 0;
      for (let depLv = 0; depLv <= depMax; depLv++) {
        if (sk.dmgRankDep) sandbox._depRanks[sk.dmgRankDep.id] = depLv;
        
        try {
          const rawText = sandbox._getDmgText(sk, r);
          const htmlOut = sandbox._renderOneDmgFormula(sk, r, rawText);
          checkedFormulas++;

          if (!htmlOut || htmlOut.includes("NaN") || htmlOut.includes("undefined")) {
            console.error(`[FORMULA ERROR] ${ctx} Rank ${r} (dep ${depLv}): formula evaluated to invalid output -> ${htmlOut}`);
            errorCount++;
          }
        } catch (e) {
          console.error(`[FORMULA EXCEPTION] ${ctx} Rank ${r} (dep ${depLv}): ${e.message}`);
          errorCount++;
        }

        // LCK-invariant floor check (see file header, item 5). Same gate
        // index.html itself uses to decide whether the "Total LCK Variance"
        // chip is shown at all -- opaque prose (Soul Eater's "x39 (max
        // 1333)", Backpack's "InventoryWeight", ...) isn't a real formula
        // and correctly gets no chip / no check here.
        try {
          const rawText = sandbox._getDmgText(sk, r);
          const subText = sandbox._substituteDmgVars(rawText, sk, r);
          const isComputable = /talAdjust\(([^()]+)\)/.test(subText)
            || /^[\d\s×*+\-().]+$/.test(subText)
            || !!sk.dmgGroups;
          if (isComputable) {
            sandbox._skillRanks[sk.id] = r;

            // A skill with `lckDiffDep` (Lucky Card + Joker) has a DETERMINISTIC
            // 0.5*(LCK - targetLCK) term that legitimately moves the minimum with
            // LCK when the dep is on (and deps default to ON). This invariant is
            // about the random spread, so check that skill with the dep off; the
            // dep's own behavior is covered by section 3e.
            const floorJokerId = sk.lckDiffDep ? sk.lckDiffDep.id : null;
            const floorJokerSaved = floorJokerId ? sandbox._depRanks[floorJokerId] : undefined;
            if (floorJokerId) sandbox._depRanks[floorJokerId] = 0;

            lckEl.value = DATA_ROLE_DEFAULTS.lck;
            sandbox._selectSkill(sk);
            const normalRange = sandbox._calcRangeFor(rawText);

            lckEl.value = "0";
            sandbox._selectSkill(sk);
            const zeroLckRange = sandbox._calcRangeFor(rawText);
            lckEl.value = DATA_ROLE_DEFAULTS.lck; // restore before any later check reads it
            if (floorJokerId) {
              if (floorJokerSaved === undefined) delete sandbox._depRanks[floorJokerId]; else sandbox._depRanks[floorJokerId] = floorJokerSaved;
            }

            checkedLckFloors++;
            if (normalRange[0] !== zeroLckRange[0]) {
              console.error(`[LCK FLOOR ERROR] ${ctx} Rank ${r} (dep ${depLv}): minimum moved with LCK -> LCK=${DATA_ROLE_DEFAULTS.lck} min=${normalRange[0]} vs LCK=0 min=${zeroLckRange[0]}`);
              errorCount++;
            }
          }
        } catch (e) {
          console.error(`[LCK FLOOR EXCEPTION] ${ctx} Rank ${r} (dep ${depLv}): ${e.message}`);
          errorCount++;
        }
      }
    }

    if (sk.shield) {
      const depMax = sk.shieldRankDep ? (sk.shieldRankDep.maxRank || 1) : (sk.shieldDep ? (sk.shieldDep.maxRank || 1) : 0);
      for (let depLv = 0; depLv <= depMax; depLv++) {
        if (sk.shieldRankDep) sandbox._depRanks[sk.shieldRankDep.id] = depLv;
        if (sk.shieldDep) sandbox._depRanks[sk.shieldDep.id] = depLv;
        
        try {
          const htmlOut = sandbox._renderShieldFormula(sk, r);
          checkedFormulas++;
          
          if (!htmlOut || htmlOut.includes("NaN") || htmlOut.includes("undefined")) {
            console.error(`[SHIELD FORMULA ERROR] ${ctx} Rank ${r} (dep ${depLv}): formula evaluated to invalid output -> ${htmlOut}`);
            errorCount++;
          }
        } catch (e) {
          console.error(`[SHIELD FORMULA EXCEPTION] ${ctx} Rank ${r} (dep ${depLv}): ${e.message}`);
          errorCount++;
        }
      }
    }
  }
});

// 3. Gaos child moves must render entirely from Gaos's own CharacterControl
// stats. The LCK-floor check above exercises calcRangeFor()/rollOneHit(), but
// the visible aggregate LCK chip and simulation are assembled separately in
// renderHero(). Compare the rendered hero with deliberately changed Monkey
// attack/talent/luck inputs so a missing renderHero own-stat override cannot
// pass unnoticed again. Rabbit's Contract mercenary moves (ownStatsMerc) get
// the same check: they attack through the mercenary's own stats.
let checkedGaosHeroRouting = 0;
SKILLS.filter(sk => (sk.ownStatsGaos && sk.id !== "monkey_summonGaos") || (sk.ownStatsMerc && !sk.mercParent)).forEach(sk => {
  const ctx = `${sk.class} > ${sk.name} (${sk.id})`;
  for (let r = 1; r <= (sk.maxRank || 1); r++) {
    try {
      const { atk, tal, lck } = sandbox._statInputs;
      sandbox._skillRanks[sk.id] = r;
      atk.value = DATA_ROLE_DEFAULTS.atk;
      tal.value = DATA_ROLE_DEFAULTS.tal;
      lck.value = DATA_ROLE_DEFAULTS.lck;
      sandbox._selectSkill(sk);
      const gaosBaseline = sandbox._getRenderedHeroHtml();

      atk.value = "7";
      tal.value = "13";
      lck.value = "19";
      sandbox._selectSkill(sk);
      const monkeyMutated = sandbox._getRenderedHeroHtml();

      atk.value = DATA_ROLE_DEFAULTS.atk;
      tal.value = DATA_ROLE_DEFAULTS.tal;
      lck.value = DATA_ROLE_DEFAULTS.lck;
      checkedGaosHeroRouting++;
      if (gaosBaseline !== monkeyMutated) {
        console.error(`[GAOS OWN-STATS ERROR] ${ctx} Rank ${r}: rendered formula/simulation changed when the player's ATK/TAL/LCK changed`);
        errorCount++;
      }
    } catch (e) {
      console.error(`[GAOS OWN-STATS EXCEPTION] ${ctx} Rank ${r}: ${e.message}`);
      errorCount++;
    }
  }
});

// 3b. Deep links: #skill-details/<skillId>[?server=tot|tto]. Drives the real
// route() in the sandbox. selectSkill() rewrites the hash to its canonical form
// through history.replaceState, so a deliberately non-canonical start hash makes
// that rewrite observable. Also: unknown ids must not throw, and GoatCounter's
// path must stay at tool level (never one path per skill).
let checkedDeepLinks = 0;
{
  const calls = [];
  sandbox.history.replaceState = (a, b, h) => { calls.push(h); sandbox.location.hash = h; };
  const drive = (hash) => { calls.length = 0; sandbox.location.hash = hash; sandbox.route(); return calls.slice(); };
  const expect = (label, got, want) => {
    checkedDeepLinks++;
    if (JSON.stringify(got) !== JSON.stringify(want)) {
      console.error(`[DEEP LINK ERROR] ${label}: expected ${JSON.stringify(want)}, got ${JSON.stringify(got)}`);
      errorCount++;
    }
  };
  try {
    expect("opens card + keeps valid server", drive("#skill-details/penguin_frozenBlast?server=tot&x=1"), ["#skill-details/penguin_frozenBlast?server=tot"]);
    expect("drops a server the skill does not have", drive("#skill-details/penguin_frozenBlast?server=zzz"), ["#skill-details/penguin_frozenBlast"]);
    expect("plain id, no server", drive("#skill-details/penguin_iceShield?x=1"), ["#skill-details/penguin_iceShield"]);
    expect("unknown id neither throws nor rewrites", drive("#skill-details/no_such_skill"), []);
    expect("legacy #skill-cooldown-lookup alias with a skill", drive("#skill-cooldown-lookup/penguin_blizzard?x=1"), ["#skill-details/penguin_blizzard"]);
    expect("GoatCounter path ignores skill + server", (sandbox.location.hash = "#skill-details/penguin_frozenBlast?server=tot", sandbox.getGoatPath()), "/bible/#skill-details");
  } catch (e) {
    console.error(`[DEEP LINK EXCEPTION] ${e.message}`);
    errorCount++;
  }
  sandbox.location.hash = "skill-details";
}

// 3c. Status keyword sanity: every card `status:{name}` must resolve to a
// classification (STATUS_CLASS_MAP or its own status.class), and a mapped status
// must render its [name] shorthand with that classification in the popup.
let checkedStatusKeywords = 0;
SKILLS.forEach(sk => {
  const list = sk.status ? (Array.isArray(sk.status) ? sk.status : [sk.status]) : [];
  list.forEach(st => {
    checkedStatusKeywords++;
    if (!st.name || !(st.class || sandbox.STATUS_CLASS_MAP[String(st.name).toLowerCase()])) {
      console.error(`[STATUS ERROR] ${sk.id}: status "${st.name}" has no classification (add it to STATUS_CLASS_MAP after checking StatusData.cs, or give status.class).`);
      errorCount++;
    }
  });
});
[["[focusIntellect5]", "0.01"], ["[cosmicRift5]", "KO"], ["[cosmicFriday5]", "KO"]].forEach(([tag, mustContain]) => {
  checkedStatusKeywords++;
  const html = sandbox.renderStatusKeywords(tag);
  if (!html.includes("Buff, State") || !html.includes(mustContain)) {
    console.error(`[STATUS ERROR] ${tag} did not render its class + description: ${html.slice(0, 160)}`);
    errorCount++;
  }
});
// Status descriptions can cite other statuses. darkEdge -> holyWolf ->
// darkEdge is a real cycle: both mentions should be styled, with only the
// first visit to each status expanding into a popup.
{
  checkedStatusKeywords++;
  const html = sandbox.renderStatusKeywords("[darkEdge]");
  const nested = /class="sk-status"[^>]*>\[holyWolf5\]<span class="sk-status-tip"/.test(html);
  const popupCount = (html.match(/class="sk-status-tip"/g) || []).length;
  const cycleLeaf = /class="sk-status">\[darkEdge\]<\/span>/.test(html);
  if (!nested || popupCount < 2 || popupCount > 10 || !cycleLeaf) {
    console.error(`[STATUS ERROR] Nested status rendering or cycle guard failed (nested=${nested}, popups=${popupCount}, cycleLeaf=${cycleLeaf}): ${html.slice(0, 300)}`);
    errorCount++;
  }
}

// 3e. lckDiffCoeff / lckDiffDep (Cat Lucky Card + Joker, Cat.cs:20845-20856):
// raw damage = int(0.5*ATK + Random(0, coef*max(LCK - targetLCK, 0))), and Joker
// adds an UNCLAMPED 0.5*(LCK - targetLCK). Driven through the real range code
// with explicit player/enemy LCK values (the app's default enemy is Carron, LCK 2).
let checkedLckDiff = 0;
{
  const sk = SKILLS.find(s => s.id === "cat_luckyCard");
  const inputs = sandbox._statInputs;
  const saved = { atk: inputs.atk.value, lck: inputs.lck.value, enemy: inputs.enemyLck.value, joker: sandbox._depRanks[sk.lckDiffDep.id] };
  const rangeAt = (rank, atk, lck, eLck, joker) => {
    inputs.atk.value = String(atk); inputs.lck.value = String(lck); inputs.enemyLck.value = String(eLck);
    sandbox._depRanks[sk.lckDiffDep.id] = joker ? 1 : 0;
    sandbox._skillRanks[sk.id] = rank;
    sandbox._selectSkill(sk);
    return sandbox._calcRangeFor(sandbox._getDmgText(sk, rank));
  };
  const expect = (label, got, want) => {
    checkedLckDiff++;
    if (JSON.stringify(got) !== JSON.stringify(want)) {
      console.error(`[LCK-DIFF ERROR] ${label}: expected ${JSON.stringify(want)}, got ${JSON.stringify(got)}`);
      errorCount++;
    }
  };
  try {
    const base = rangeAt(4, 200, 102, 102, false);        // diff 0: only the 0.5*ATK base (+ the engine's own LCK spread)
    const lead = rangeAt(4, 200, 102, 2, false);           // diff +100, coef 2.5 -> random ceiling +250 on the max only
    expect("min never moves with the LCK lead (Joker off)", lead[0], base[0]);
    expect("random ceiling = floor(coef * diff) added to the max", lead[1] - base[1], 250);
    expect("rank 1 coefficient is 1.0", rangeAt(1, 200, 102, 2, false)[1] - rangeAt(1, 200, 102, 102, false)[1], 100);
    const jokerLead = rangeAt(4, 200, 102, 2, true);       // + trunc(0.5*100) = +50 on BOTH ends
    expect("Joker shifts min by +0.5*diff", jokerLead[0] - lead[0], 50);
    expect("Joker shifts max by +0.5*diff", jokerLead[1] - lead[1], 50);
    const behind = rangeAt(4, 200, 102, 202, false);       // diff -100: the random part is CLAMPED at 0
    expect("negative diff: random term clamped to 0", behind[1] - base[1], 0);
    const jokerBehind = rangeAt(4, 200, 102, 202, true);    // Joker is NOT clamped: -50 on both ends
    expect("negative diff + Joker reduces the min", jokerBehind[0] - behind[0], -50);
    expect("negative diff + Joker reduces the max", jokerBehind[1] - behind[1], -50);
    // Consistency: the Final Damage RANGE shown on the card must contain every simulated roll
    // (the hero range and the Test/Simulate popup share the same pipeline stages).
    const finalRangeAt = (rank, atk, lck, eLck, joker) => {
      inputs.atk.value = String(atk); inputs.lck.value = String(lck); inputs.enemyLck.value = String(eLck);
      sandbox._depRanks[sk.lckDiffDep.id] = joker ? 1 : 0;
      sandbox._skillRanks[sk.id] = rank;
      sandbox._selectSkill(sk);
      const raw = sandbox._calcRangeFor(sandbox._getDmgText(sk, rank));
      const fin = sandbox._finalRangeForRange(raw);
      let lo = Infinity, hi = -Infinity;
      for (let i = 0; i < 1500; i++) { const r = sandbox._rollOneHit(sk, rank); lo = Math.min(lo, r); hi = Math.max(hi, r); }
      return { fin, lo, hi };
    };
    [[4, 200, 102, 2, false], [4, 200, 102, 2, true], [1, 200, 102, 2, false], [4, 200, 102, 102, false], [4, 200, 102, 202, true]].forEach(([rk, atk, lck, eLck, jk]) => {
      const { fin, lo, hi } = finalRangeAt(rk, atk, lck, eLck, jk);
      const tag = `rank ${rk}, ATK ${atk}, LCK ${lck} vs ${eLck}, Joker ${jk ? "on" : "off"}`;
      expect(`final range contains every roll (${tag}) [range ${fin[0]}-${fin[1]}, rolled ${lo}-${hi}]`, lo >= fin[0] && hi <= fin[1], true);
    });
    sandbox._depRanks[sk.lckDiffDep.id] = 1;
    inputs.atk.value = "200"; inputs.lck.value = "102"; inputs.enemyLck.value = "2";
    sandbox._selectSkill(sk);
    const withJoker = sandbox._renderOneDmgFormula(sk, 4, sandbox._getDmgText(sk, 4));
    sandbox._depRanks[sk.lckDiffDep.id] = 0;
    const withoutJoker = sandbox._renderOneDmgFormula(sk, 4, sandbox._getDmgText(sk, 4));
    expect("formula shows the Joker term only when Joker is on", [withJoker.includes("Joker"), withoutJoker.includes("Joker")], [true, false]);
    expect("formula always shows the random LCK term", withoutJoker.includes("ΔLCK"), true);
    expect("formula shows the random term as a 0~max range (rank 4, LCK lead 100 -> 0~250)", withoutJoker.includes("0~250"), true);
    inputs.lck.value = "2"; sandbox._selectSkill(sk);
    const noLead = sandbox._renderOneDmgFormula(sk, 4, sandbox._getDmgText(sk, 4));
    expect("no LCK lead: the random term shows a plain 0, not 0~0", [noLead.includes("0~"), noLead.includes(">0<")], [false, true]);
    inputs.lck.value = "102"; inputs.enemyLck.value = "202"; sandbox._depRanks[sk.lckDiffDep.id] = 1; sandbox._selectSkill(sk);
    const behindJoker = sandbox._renderOneDmgFormula(sk, 4, sandbox._getDmgText(sk, 4));
    expect("behind on LCK with Joker: shown as a minus term, not \"+ -n\"", [behindJoker.includes("−"), behindJoker.includes("-50")], [true, false]);
  } catch (e) {
    console.error(`[LCK-DIFF EXCEPTION] ${e.message}`);
    errorCount++;
  }
  inputs.atk.value = saved.atk; inputs.lck.value = saved.lck; inputs.enemyLck.value = saved.enemy;
  if (saved.joker === undefined) delete sandbox._depRanks[sk.lckDiffDep.id]; else sandbox._depRanks[sk.lckDiffDep.id] = saved.joker;
}

// 3e-ii. lckDiffOwn / lckDiffExclusive + Roll the Dice (Cat Lucky Dice, Cat.cs:23939):
// raw damage = Random.Range(0, sLv*LCK) [+ LCK with Roll the Dice], reading the caster's OWN
// LCK (the Enemy Stats LCK is never subtracted) and excluding the upper bound (max = sLv*LCK - 1).
{
  const sk = SKILLS.find(s => s.id === "cat_luckyDice");
  const inputs = sandbox._statInputs;
  const saved = { lck: inputs.lck.value, enemy: inputs.enemyLck.value, dep: sandbox._depRanks[sk.lckDiffDep.id] };
  const setup = (rank, lck, eLck, dep) => {
    inputs.lck.value = String(lck); inputs.enemyLck.value = String(eLck);
    sandbox._depRanks[sk.lckDiffDep.id] = dep ? 1 : 0;
    sandbox._skillRanks[sk.id] = rank;
    sandbox._selectSkill(sk);
  };
  const rangeAt = (rank, lck, eLck, dep) => { setup(rank, lck, eLck, dep); return sandbox._calcRangeFor(sandbox._getDmgText(sk, rank)); };
  const expect = (label, got, want) => {
    checkedLckDiff++;
    if (JSON.stringify(got) !== JSON.stringify(want)) {
      console.error(`[LCK-DIFF ERROR] Lucky Dice: ${label}: expected ${JSON.stringify(want)}, got ${JSON.stringify(got)}`);
      errorCount++;
    }
  };
  try {
    expect("rank 2, LCK 128: raw range 0 .. 2*128-1", rangeAt(2, 128, 2, false), [0, 255]);
    expect("rank 1, LCK 128: raw range 0 .. 128-1", rangeAt(1, 128, 2, false), [0, 127]);
    expect("enemy LCK is ignored (own-LCK roll)", rangeAt(2, 128, 500, false), [0, 255]);
    expect("Roll the Dice rank 2: LCK .. 3*LCK-1", rangeAt(2, 128, 2, true), [128, 383]);
    expect("Roll the Dice rank 1: LCK .. 2*LCK-1", rangeAt(1, 128, 2, true), [128, 255]);
    expect("Roll the Dice ignores enemy LCK too", rangeAt(2, 128, 500, true), [128, 383]);
    expect("LCK 0 rolls exactly 0", rangeAt(2, 0, 2, false), [0, 0]);
    expect("LCK 0 + Roll the Dice is still 0", rangeAt(2, 0, 2, true), [0, 0]);
    [[2, 128, false], [2, 128, true], [1, 77, false], [1, 77, true], [2, 1, false]].forEach(([rk, lck, dep]) => {
      setup(rk, lck, 2, dep);
      const raw = sandbox._calcRangeFor(sandbox._getDmgText(sk, rk));
      const fin = sandbox._finalRangeForRange(raw);
      let lo = Infinity, hi = -Infinity;
      for (let i = 0; i < 1500; i++) { const r = sandbox._rollOneHit(sk, rk); lo = Math.min(lo, r); hi = Math.max(hi, r); }
      const tag = `rank ${rk}, LCK ${lck}, Roll the Dice ${dep ? "on" : "off"}`;
      expect(`final range contains every roll (${tag}) [range ${fin[0]}-${fin[1]}, rolled ${lo}-${hi}]`, lo >= fin[0] && hi <= fin[1], true);
    });
    setup(2, 128, 2, false);
    const off = sandbox._renderOneDmgFormula(sk, 2, sandbox._getDmgText(sk, 2));
    expect("formula shows the roll as a 0~max range on own LCK", [off.includes("0~255"), off.includes("×LCK"), off.includes("ΔLCK")], [true, true, false]);
    expect("formula shows no Roll the Dice term while it is off", off.includes("Roll the Dice"), false);
    expect("formula has no plain base number, it starts with the LCK term", [off.includes("dmg-num"), off.includes("dmg-lck")], [false, true]);
    setup(2, 128, 2, true);
    const on = sandbox._renderOneDmgFormula(sk, 2, sandbox._getDmgText(sk, 2));
    expect("formula shows the Roll the Dice term when on", on.includes("Roll the Dice"), true);
  } catch (e) {
    console.error(`[LCK-DIFF EXCEPTION] Lucky Dice: ${e.message}`);
    errorCount++;
  }
  inputs.lck.value = saved.lck; inputs.enemyLck.value = saved.enemy;
  if (saved.dep === undefined) delete sandbox._depRanks[sk.lckDiffDep.id]; else sandbox._depRanks[sk.lckDiffDep.id] = saved.dep;
}

// 3f. Range-vs-simulator consistency, EVERY single-hit skill with a computable damage
// formula: every roll of the real Test/Simulate path (rollOneHit) must fall inside the
// Final Damage range the card displays (finalRangeForRange(calcRangeFor(...))). Run twice
// per skill rank, once with every dependency at its default and once with every dependency
// switched off. dmgGroups skills are checked group by group: each active group is rolled with
// rollOneHit(..., groupIndex) against its own range (dmgModes cards and prose text are skipped).
// (Found 2026-09-19: Lucky Card's LCK-difference roll was missing from the displayed max.)
let checkedConsistency = 0;
// Slow damage checks (range-vs-simulator, Wolf Combo, Rabbit shots, ~35 s): run only with --full (use it before git push) or when the uncommitted diff of index.html touches damage code.
const DAMAGE_CODE_TOUCHED = /\b(dmg\w*|rollOneHit|calcRangeFor|finalRange\w*|substituteDmgVars|talAdjust|atkCoeff|hitCount\w*|lckDiff\w*|effectProc|critProc|rawModel)\b/;
const RUN_DAMAGE_CHECKS = process.argv.includes("--full") || (() => {
  try {
    const diff = execFileSync("git", ["diff", "HEAD", "-U0", "--", "12t_projects/bible/index.html"], { encoding: "utf8", maxBuffer: 1 << 28 });
    return diff.split(/\r?\n/).some(l => /^[-+][^-+]/.test(l) && DAMAGE_CODE_TOUCHED.test(l));
  } catch (e) { return true; }
})();
if (RUN_DAMAGE_CHECKS) {
  // Pre-existing mismatches found by this very check, NOT yet resolved. Each needs a decision
  // about which path (roll or range) matches the game; do not "fix" by widening the range.
  // Remove an entry once the skill is consistent again.
  const KNOWN_RANGE_SIM_MISMATCH = {
    // (none right now -- add "skillId: reason" only for a mismatch found by this scan and not yet resolved)
  };
  const DEP_FIELD_NAMES = ["hitOutDep", "dmgDep", "dmgMultDep", "dmgRankDep", "dmgFlagDep", "dmgReplaceDep", "hitCountDep", "lckDiffDep", "cdDep", "castDep", "koDep"];
  const inputs = sandbox._statInputs;
  const N = 1000;   // an overshoot can be a rare tail event (a few in 6000 rolls); only runs under --full / damage-code changes
  const failures = new Map();
  // Every server the card overrides is rolled against its own range (the original server always).
  SKILLS.forEach(card => ["og", "tot", "tto", "reborn"].forEach(srv => {   // reborn: user 2026-10-25
    const over = srv === "og" ? null : (card.servers && card.servers[srv]) || (srv === "tot" ? card.ps : null);
    if (srv !== "og" && !over) return;
    const sk = over ? Object.assign({}, card, over) : card, fid = sk.id + (srv === "og" ? "" : "@" + srv);
    sandbox._setServer(srv);
    if (sk.dmgGroups && sk.dmgModes) return;   // alternative modes/zones, not per-hit groups
    const depIds = [];
    DEP_FIELD_NAMES.forEach(f => { if (sk[f] && sk[f].id) depIds.push([sk[f].id, sk[f].minRank !== undefined ? sk[f].minRank : 0, sk[f].maxRank !== undefined ? sk[f].maxRank : 1]); });
    if (sk.dmgFocusIntellect) depIds.push(["focusIntellect", 0, 1]);
    // Two stat profiles: the sandbox defaults (player LCK/ATK/TAL 0) AND a high-stat profile.
    // Only the high profile gives LCK-difference skills (Lucky Card) a real LCK lead over the
    // enemy, so a range/roll gap in that term can't hide behind all-zero stats.
    [null, { atk: "200", tal: "200", lck: "150" }].forEach(profile => {
    const savedStats = profile ? { atk: inputs.atk.value, tal: inputs.tal.value, lck: inputs.lck.value } : null;
    if (profile) { inputs.atk.value = profile.atk; inputs.tal.value = profile.tal; inputs.lck.value = profile.lck; }
    [false, true].forEach(depsOff => {
      if (depsOff && depIds.length === 0) return;   // nothing to switch off
      const saved = depIds.map(([id]) => [id, sandbox._depRanks[id]]);
      depIds.forEach(([id, min, max]) => { sandbox._depRanks[id] = depsOff ? min : max; });   // every dependency starts off in the app: the passes are "all off" and "all on", never "default"
      for (let r = 1; r <= Math.max(1, sk.maxRank || 1); r++) {
        try {
          const computable = text => {
            const s = sandbox._substituteDmgVars(text, sk, r);
            return /talAdjust\(([^()]+)\)/.test(s) || /^[\d\s×*+\-().]+$/.test(s);
          };
          const rawText = sandbox._getDmgText(sk, r);
          if (!sk.dmgGroups && !computable(rawText)) continue;
          sandbox._skillRanks[sk.id] = r;
          sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined;
          sandbox._selectSkill(card);
          if (!sandbox._calcRangeFor || !sandbox._finalRangeForRange) continue;
          // One unit per active group (rolled with rollOneHit's groupIndex), or the whole skill.
          const units = sk.dmgGroups
            ? sk.dmgGroups.map((g, gi) => ({ g, gi })).filter(({ g }) => sandbox._resolveGroupHitCount(sk, g) > 0 && computable(g.dmg))
            : [{ g: null, gi: undefined }];
          units.forEach(({ g, gi }) => {
            const fin = g
              ? sandbox._finalRangeForRange(sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g))
              : sandbox._finalRangeForRange(sandbox._calcRangeFor(rawText));
            let lo = Infinity, hi = -Infinity;
            for (let i = 0; i < N; i++) { const x = sandbox._rollOneHit(sk, r, undefined, false, gi); lo = Math.min(lo, x); hi = Math.max(hi, x); }
            checkedConsistency++;
            if (lo < fin[0] || hi > fin[1]) {
              const where = g ? ` group ${gi}${g.label ? ` "${g.label}"` : ""}` : "";
              if (!failures.has(fid)) failures.set(fid, `rank ${r}${where}${depsOff ? " (deps off)" : " (deps on)"}${profile ? " (high stats)" : ""}: displayed ${fin[0]}-${fin[1]} but rolled ${lo}-${hi}`);
            }
          });
        } catch (e) {
          if (!failures.has(fid)) failures.set(fid, `rank ${r}: EXCEPTION ${e.message}`);
        }
      }
      depIds.forEach(([id]) => { delete sandbox._depRanks[id]; });
      saved.forEach(([id, val]) => { if (val !== undefined) sandbox._depRanks[id] = val; });
    });
    if (profile) { inputs.atk.value = savedStats.atk; inputs.tal.value = savedStats.tal; inputs.lck.value = savedStats.lck; }
    });
  }));
  sandbox._setServer("og");
  const known = [];
  failures.forEach((msg, id) => {
    if (KNOWN_RANGE_SIM_MISMATCH[id]) { known.push(id); return; }
    console.error(`[RANGE/SIM ERROR] ${id} ${msg}`);
    errorCount++;
  });
  if (known.length) console.log(`[RANGE/SIM KNOWN ISSUES] ${known.length} skill(s) still inconsistent, tracked in KNOWN_RANGE_SIM_MISMATCH: ${known.join(", ")}`);
}
// 3g. Sheep Benediction (Sheep.cs:22284/23284/26334/26864): talAdjust((int)((1f + 0.15f*lv) * base)) --
// the multiplier is INSIDE talAdjust, on the integer-truncated 32-bit-float product. Checked with a
// zero LCK spread (deterministic) at TAL 100, where talAdjust(p) = ceil(p * 3), so the expected raw
// damage is exact: overHeal r2 lv3 = talAdjust(int(1.45f*80)=116) = 348; revive r2 lv1 = talAdjust(int(1.15f*100)=115) = 345
// (plain double arithmetic would give 114 -> 342).
let checkedBenediction = 0;
{
  const inputs = sandbox._statInputs;
  const saved = { tal: inputs.tal.value, lck: inputs.lck.value, ben: sandbox._depRanks.benediction };
  const expectEq = (label, got, want) => {
    checkedBenediction++;
    if (got !== want) { console.error(`[BENEDICTION ERROR] ${label}: expected ${want}, got ${got}`); errorCount++; }
  };
  try {
    inputs.tal.value = "100"; inputs.lck.value = "0";
    [["sheep_overHeal", 2, 3, 348], ["sheep_overHeal", 1, 1, 171], ["sheep_revive", 2, 1, 345], ["sheep_heal", 4, 3, 303]].forEach(([id, rank, lv, want]) => {
      const sk = SKILLS.find(x => x.id === id);
      sandbox._depRanks[sk.dmgRankDep.id] = lv;
      sandbox._skillRanks[sk.id] = rank;
      sandbox._calcRangeFor = undefined;
      sandbox._selectSkill(sk);
      const raw = sandbox._calcRangeFor(sandbox._getDmgText(sk, rank));
      expectEq(`${id} r${rank} Benediction ${lv}: raw range (min)`, raw[0], want);
      expectEq(`${id} r${rank} Benediction ${lv}: raw range (max)`, raw[1], want);
      if (sk.isHeal) expectEq(`${id} r${rank} Benediction ${lv}: simulated heal`, sandbox._rollOneHit(sk, rank), want);
    });
  } catch (e) {
    console.error(`[BENEDICTION EXCEPTION] ${e.message}`);
    errorCount++;
  }
  inputs.tal.value = saved.tal; inputs.lck.value = saved.lck;
  if (saved.ben === undefined) delete sandbox._depRanks.benediction; else sandbox._depRanks.benediction = saved.ben;
}
// 3h. MULTI-RANK ICON COMPLETENESS (GEMINI.md §3: "for maxRank > 1, extract every rank variant icon
// from RippedAssets/. Zero placeholders."). The hero icon swaps to `<base><rank>` for a multi-rank skill
// and SILENTLY falls back to the max-rank icon when that key is missing, so a gap never shows up as an
// error anywhere else -- Lucky Card shipped with only rank 4 because nothing checked this.
let checkedRankIcons = 0;
SKILLS.forEach(sk => {
  if (!(sk.maxRank > 1) || !sk.icon) return;
  const base = sk.icon.replace(/\d+$/, "");
  const absent = [];
  for (let r = 1; r <= sk.maxRank; r++) { checkedRankIcons++; if (!(base + r in SKILL_ICONS)) absent.push(r); }
  if (absent.length) {
    console.error(`[ICON RANK ERROR] ${sk.id} (maxRank ${sk.maxRank}) is missing rank icon(s) ${absent.map(r => base + r).join(", ")} -- extract them from RippedAssets/.../gamegui/icons/skills/<class>/`);
    errorCount++;
  }
});
// 3i2. LCK PROC LABEL COMPLETENESS (GEMINI.md: every lckProc/secondaryLckProc chip must name what the
// chance is for -- the chip used to silently show a generic "โอกาส" for any card missing this, so a
// missing label never surfaced anywhere else until this check existed).
let checkedLckLabels = 0;
SKILLS.forEach(sk => {
  for (const field of ["lckProc", "secondaryLckProc", "tertiaryLckProc", "quaternaryLckProc"]) {
    if (!sk[field]) continue;
    checkedLckLabels++;
    if (!sk[field].label) {
      console.error(`[LCK LABEL ERROR] ${sk.id}.${field} has no label -- add one naming what the chance is for (e.g. "โอกาส Frost").`);
      errorCount++;
    }
  }
});
// 3i3. DURATION LABEL FORMAT & COMPLETENESS (GEMINI.md: duration chip labels must use "ระยะเวลา XXX")
let checkedDurLabels = 0;
SKILLS.forEach(sk => {
  if (sk.durLabel) {
    checkedDurLabels++;
    if (!sk.durLabel.startsWith("ระยะเวลา")) {
      console.error(`[DURATION LABEL ERROR] ${sk.id}.durLabel "${sk.durLabel}" must start with "ระยะเวลา" (e.g. "ระยะเวลา Frost").`);
      errorCount++;
    }
  }
  if (sk.secondaryDuration) {
    checkedDurLabels++;
    if (!sk.secondaryDuration.label || !sk.secondaryDuration.label.startsWith("ระยะเวลา")) {
      console.error(`[DURATION LABEL ERROR] ${sk.id}.secondaryDuration.label "${sk.secondaryDuration ? sk.secondaryDuration.label : undefined}" must start with "ระยะเวลา" (e.g. "ระยะเวลา Ice").`);
      errorCount++;
    }
  }
});
// 3i. Round class faces (CLASS_HERO_ICONS, user 2026-10-18: the stat panel badge, the TTO magic tabs, the class
// buttons, the roster heading, the guide gallery and the note pages): every class a skill belongs to (other than
// shared "Common" skills, which have no character art) needs a valid WebP face.
let checkedPortraits = 0;
{
  const portraits = sandbox.CLASS_HERO_ICONS;
  if (!portraits) { console.error("[PORTRAIT ERROR] CLASS_HERO_ICONS is not defined"); errorCount++; }
  else {
    [...new Set(SKILLS.map(sk => sk.class))].filter(c => c && c !== "Common").forEach(cls => {
      checkedPortraits++;
      const data = portraits[cls];
      if (!data) { console.error(`[PORTRAIT ERROR] class "${cls}" has no CLASS_HERO_ICONS entry`); errorCount++; return; }
      const buf = Buffer.from(String(data).replace("data:image/webp;base64,", ""), "base64");
      if (!String(data).startsWith("data:image/webp;base64,") || buf.length < 12 || buf.toString("latin1", 0, 4) !== "RIFF" || buf.toString("latin1", 8, 12) !== "WEBP") {
        console.error(`[PORTRAIT ERROR] class "${cls}" face is not a valid WebP data URI`); errorCount++;
      }
    });
  }
}
// 3j. Stat panel structure (2026-09-19): both badges present, Revised Art lives INSIDE the player badge,
// and the enemy show/hide toggle + the old button row are gone for good.
let checkedPanelMarkup = 0;
{
  const startIdx = html.indexOf('<div class="sk-stats-panel"');
  const endIdx = html.indexOf('<div class="sk-multihit-layer"', startIdx);
  const panel = startIdx === -1 || endIdx === -1 ? "" : html.slice(startIdx, endIdx);
  const check = (label, ok) => { checkedPanelMarkup++; if (!ok) { console.error(`[PANEL ERROR] ${label}`); errorCount++; } };
  check("stats panel template not found", panel.length > 0);
  const count = (needle) => panel.split(needle).length - 1;
  check("the player caption was replaced by the PRESET button (2026-10-05) and must stay removed", count("ค่าสถานะตัวละครของคุณ") === 0);
  check("enemy caption should appear exactly once", count("ค่าสถานะตัวละครเป้าหมาย") === 1);
  check("enemy show/hide toggle must stay removed", count("enemystat-toggle") === 0);
  check("the old .sk-controls-actions button row must stay removed", count("sk-controls-actions") === 0);
  const playerBadgeStart = panel.indexOf('class="sk-class-badge"');
  const playerBadgeEnd = panel.indexOf('<div class="sk-controls">', playerBadgeStart);
  const playerBadge = playerBadgeStart === -1 ? "" : panel.slice(playerBadgeStart, playerBadgeEnd);
  check("Revised Art button must be inside the player badge", playerBadge.includes('data-role="revisedart"'));
  const enemyBadgeStart = panel.indexOf('class="sk-class-badge sk-enemy-badge"');
  const enemyStatsStart = panel.indexOf('<div class="sk-controls">', enemyBadgeStart);
  const enemyBadge = enemyBadgeStart === -1 ? "" : panel.slice(enemyBadgeStart, enemyStatsStart);
  ["enemy-cycle-display", "enemy-name-label", "enemy-info-btn"].forEach(role =>
    check(`enemy badge is missing data-role="${role}"`, enemyBadge.includes(`data-role="${role}"`)));
  check("enemy badge must be its own card: the enemy stat inputs must not be inside it", !enemyBadge.includes('data-role="enemyAtk"') && enemyStatsStart > enemyBadgeStart);
  check("the enemy icon must be a button (click = opens the preset picker)", enemyBadge.includes('<button type="button" class="sk-enemy-cycle-icon-wrap" data-role="enemy-cycle-display"'));
  check("the enemy preset picker must live inside the enemy badge", enemyBadge.includes('data-role="enemy-picker"'));
  check("the enemy prev/next arrows must stay removed", count("enemy-prev") === 0 && count("enemy-next") === 0);
  // Stat presets (2026-10-05): a PRESET n button in the player badge opens the 5-card window; no slot bar, no save / clear buttons.
  check("the PRESET button must be inside the player badge", playerBadge.includes('data-role="preset-open"'));
  check("the old stat preset slot bar must stay removed (presets live in the PRESET window)", count("preset-row") === 0 && count("preset-slots") === 0);
  check("stat presets autosave: no save / clear buttons", count("preset-save") === 0 && count("preset-clear") === 0);
  {
    const storyArt = vm.runInContext("CLASS_STORY_ART", sandbox);
    ["Bat", "Bison", "Cat", "Chameleon", "Mole", "Monkey", "Panda", "Penguin", "Rabbit", "Sheep", "Whale", "Wolf"].forEach(c =>
      check(`CLASS_STORY_ART needs 5 colour portraits for ${c} (one per PRESET card)`,
        Array.isArray(storyArt[c]) && storyArt[c].length === 5 && storyArt[c].every(s => /^data:image\/webp;base64,/.test(s))));
  }
  check("stat presets must keep their localStorage key (renaming it would drop every saved preset)", html.includes('"12t-bible-stat-presets"'));
}
// 3k. Summon stat-feed glow (getSummonFeedPlayerStatKeys, 2026-09-19): a character stat glows in the player
// panel when a dependency feeds it into a summon stat AND the selected skill's chips read that summon stat.
let checkedSummonFeed = 0;
{
  const byId = id => SKILLS.find(x => x.id === id);
  const DEP_IDS = ["doubleBot", "synchroMole", "hiddenTurret", "fireSoul", "earthSoul", "aegisOfEarth"];
  const saved = DEP_IDS.map(id => [id, sandbox._depRanks[id]]);
  const glow = (id, deps) => {
    DEP_IDS.forEach(d => { sandbox._depRanks[d] = deps[d] !== undefined ? deps[d] : 0; });
    return sandbox.getUsedPlayerStatKeys(byId(id));
  };
  const expectKey = (label, set, key, want) => {
    checkedSummonFeed++;
    if (set.has(key) !== want) { console.error(`[SUMMON FEED ERROR] ${label}: "${key}" should ${want ? "" : "NOT "}glow, keys = ${[...set].sort().join(",")}`); errorCount++; }
  };
  try {
    // Barrel Bot: Double Bot feeds LV, Synchro Mole feeds TAL (into ATK/DEF)
    const bb = "mole_barrelBot_punch";
    expectKey("Barrel Bot, both deps on", glow(bb, { doubleBot: 1, synchroMole: 2 }), "lv", true);
    expectKey("Barrel Bot, both deps on", glow(bb, { doubleBot: 1, synchroMole: 2 }), "tal", true);
    expectKey("Barrel Bot, Double Bot only", glow(bb, { doubleBot: 1 }), "lv", true);
    expectKey("Barrel Bot, Double Bot only", glow(bb, { doubleBot: 1 }), "tal", false);
    expectKey("Barrel Bot, Synchro Mole only", glow(bb, { synchroMole: 2 }), "tal", true);
    expectKey("Barrel Bot, Synchro Mole only", glow(bb, { synchroMole: 2 }), "lv", false);
    expectKey("Barrel Bot, deps off", glow(bb, {}), "lv", false);
    expectKey("Barrel Bot, deps off", glow(bb, {}), "tal", false);
    // Auto Gyro Gun: Hidden Turret feeds LV
    expectKey("Auto Gyro Gun, Hidden Turret on", glow("mole_autoGyroGun_nAttack", { hiddenTurret: 1 }), "lv", true);
    expectKey("Auto Gyro Gun, Hidden Turret off", glow("mole_autoGyroGun_nAttack", {}), "lv", false);
    // Phoenix: Fire Soul feeds each stat the chips read (Instant Blaze reads the Phoenix's TAL only)
    expectKey("Phoenix Instant Blaze, Fire Soul on", glow("monkey_instantBlaze", { fireSoul: 1 }), "tal", true);
    expectKey("Phoenix Instant Blaze, Fire Soul on: DEF is not read", glow("monkey_instantBlaze", { fireSoul: 1 }), "def", false);
    expectKey("Phoenix Instant Blaze, Fire Soul on: VIT is not read", glow("monkey_instantBlaze", { fireSoul: 1 }), "vit", false);
    expectKey("Phoenix Instant Blaze, Fire Soul off", glow("monkey_instantBlaze", {}), "tal", false);
    // Gadina: Aegis of Earth feeds VIT into the MHP that Titanic Earth Pulse reads
    expectKey("Titanic Earth Pulse, Aegis of Earth on", glow("monkey_titanicEarthPulse", { aegisOfEarth: 2 }), "vit", true);
    expectKey("Titanic Earth Pulse, no VIT feed", glow("monkey_titanicEarthPulse", {}), "vit", false);
    // A skill with no summon is unaffected however the deps are set
    const plainOn = glow("penguin_frozenBlast", { doubleBot: 1, synchroMole: 2, hiddenTurret: 1, fireSoul: 1, earthSoul: 1, aegisOfEarth: 3 });
    const plainOff = glow("penguin_frozenBlast", {});
    checkedSummonFeed++;
    if ([...plainOn].sort().join() !== [...plainOff].sort().join()) { console.error("[SUMMON FEED ERROR] a non-summon skill's glow changed with summon dependencies"); errorCount++; }
  } catch (e) {
    console.error(`[SUMMON FEED EXCEPTION] ${e.message}`);
    errorCount++;
  }
  saved.forEach(([id, val]) => { if (val === undefined) delete sandbox._depRanks[id]; else sandbox._depRanks[id] = val; });
}
// 3l. Enemy preset picker (2026-09-24): the icon opens a grid of every preset; choosing one applies its stats,
// and Ctrl+Z (undoEnemyChange) restores the previous enemy, including hand-edited field values.
let checkedEnemyCycle = 0;
{
  const presets = sandbox._enemyPresets || [];
  const check = (label, ok) => { checkedEnemyCycle++; if (!ok) { console.error(`[ENEMY PICKER ERROR] ${label}`); errorCount++; } };
  const startId = sandbox._selectedEnemyId();
  sandbox._renderEnemyPicker();
  const pickerHtml = sandbox._enemyPickerHtml();
  check("picker lists every preset once", presets.length >= 2 && presets.every(p => pickerHtml.split(`data-enemy-id="${p.id}"`).length === 2));
  check("picker marks the current preset", pickerHtml.includes(`is-current" data-enemy-id="${startId}"`));
  const other = presets.find(p => p.id !== startId);
  sandbox._selectEnemyPreset(other.id);
  check("choosing a preset selects it", sandbox._selectedEnemyId() === other.id);
  check("choosing a preset writes its LCK into the enemy stats", String(sandbox._statInputs.enemyLck.value) === String(other.lck));
  sandbox._statInputs.enemyLck.value = "777";
  sandbox._selectEnemyPreset(startId);
  check("undo restores the previous preset", sandbox._undoEnemyChange() && sandbox._selectedEnemyId() === other.id);
  check("undo restores a hand-edited field value", String(sandbox._statInputs.enemyLck.value) === "777");
  sandbox._undoEnemyChange();
  check("second undo goes back to the start", sandbox._selectedEnemyId() === startId);
  check("undo with an empty stack does nothing", sandbox._undoEnemyChange() === false);
  // Monster search (2026-10-06): any MONSTER_STATS row can be the target as "m:<index>".
  check("picker has the monster search box", pickerHtml.includes('data-role="enemy-search"'));
  const hits = sandbox.searchMonsters("crab");
  const rows = sandbox._monsterStats;
  check("search finds CaptainCrab by name", hits.some(i => rows[i][1] === "CaptainCrab"));
  check("search skips NPCs and empty queries", sandbox.searchMonsters("").length === 0 && sandbox.searchMonsters("jerboa").length === 0);
  const ci = hits.find(i => rows[i][1] === "CaptainCrab"), mon = sandbox.enemyById("m:" + ci);
  check("a monster target takes its stats from the row", mon && mon.monster && mon.def === rows[ci][9] && mon.lck === rows[ci][15] && mon.int === rows[ci][12]);
  sandbox._selectEnemyPreset("m:" + ci);
  check("choosing a monster selects it and writes its DEF", sandbox._selectedEnemyId() === "m:" + ci && String(sandbox._statInputs.enemyDef.value) === String(rows[ci][9]));
  check("undo after a monster goes back to the preset", sandbox._undoEnemyChange() && sandbox._selectedEnemyId() === startId);
  check("an unknown monster id is ignored", sandbox.enemyById("m:999999") === null);
}
// 4. Audit compatSkills reciprocity (AGENTS.md Section 8: every edge must be
// reciprocated -- if A lists B, B must list A back). Server-specific (user 2026-10-25): servers.<srv>.compatSkills replaces
// the list on that server, and an edge must come back on the target's list for the same server (a card's base list counts on
// every server it does not override; a server-exclusive card, onlyServer, is on its own server). A link to a server-exclusive
// card from a card that is not exclusive belongs in that server's list only, never in the base list.
const skillById = new Map(SKILLS.map(s => [s.id, s]));
const compatFor = (s, srv) => { const o = srv && s.servers && s.servers[srv]; return Array.isArray(o && o.compatSkills) ? o.compatSkills : (Array.isArray(s.compatSkills) ? s.compatSkills : []); };
SKILLS.forEach(sk => {
  const lists = [[null, sk.compatSkills]].concat(Object.entries(sk.servers || {}).filter(([, o]) => o && Array.isArray(o.compatSkills)).map(([k, o]) => [k, o.compatSkills]));
  for (const [srv, list] of lists) {
    if (!Array.isArray(list)) continue;
    const ctx = `${sk.class} > ${sk.name} (${sk.id})` + (srv ? ` [servers.${srv}]` : ""), side = srv || sk.onlyServer || null;
    list.forEach(targetId => {
      const target = skillById.get(targetId);
      if (!target) {
        console.error(`[COMPAT ERROR] ${ctx}: compatSkills references unknown id '${targetId}'`);
        errorCount++;
        return;
      }
      if (!srv && target.onlyServer && !sk.onlyServer) {
        console.error(`[COMPAT ERROR] ${ctx}: links the ${target.onlyServer}-only card '${targetId}' in its base compatSkills; list it under servers.${target.onlyServer}.compatSkills`);
        errorCount++;
      }
      if (!compatFor(target, side).includes(sk.id)) {
        console.error(`[COMPAT ERROR] ${ctx}: compatSkills -> '${targetId}' is not reciprocated ('${targetId}' does not list '${sk.id}' back${side ? " on " + side : ""})`);
        errorCount++;
      }
    });
  }
});

// 4a. Every multi-rank toggle a card shows on any server draws an icon that exists for each rank: the header button takes iconFor(rank), else the
// icon with its digits swapped for the rank (2026-10-26: a 0-3 Shadow Upon Shadow toggle without iconFor drew a broken cat_shadowUponShadow1).
{ const depF = ["descDep", "cdDep", "durDep", "castDep", "dmgMultDep", "dmgRankDep", "hitCountDep", "hitOutDep", "dep", "koDep", "dmgDep", "dmgFlagDep", "cdMultDep"], listF = ["dmgControls", "infoDeps", "reachControls"], seenRank = new Set();
  SKILLS.forEach(sk => (sk.soon ? [] : sandbox._getAvailableServers(sk)).forEach(srv => {
    const a = sandbox._getActiveSkill(sk, srv);
    depF.map(k => a[k]).concat(...listF.map(k => (a[k] || []).map(d => d && d.dep ? d.dep : d))).filter(d => d && d.id && (d.maxRank || 1) - (d.minRank || 0) > 1 && !seenRank.has(d.id)).forEach(d => {
      seenRank.add(d.id);
      for (let r = d.minRank || 0; r <= d.maxRank; r++) {
        const key = d.iconFor ? d.iconFor(r) : String(d.icon || "").replace(/\d+$/, "") + (r === 0 ? 1 : r);
        if (!SKILL_ICONS[key]) { console.error(`[ICON ERROR] toggle ${d.id} (on ${sk.id} / ${srv}): rank ${r} draws '${key}', which is not in SKILL_ICONS (give the dep an iconFor)`); errorCount++; break; }
      }
    });
  }));
}
// 4b. The merged view (2026-10-26): on each server the page shows a card's own list for that server, or its base list. Every link a card shows
// on a server comes back on the target's list there (both cards offering that server); the pairs above only compare list with list.
for (const srv of ["tot", "tto", "reborn"]) {
  SKILLS.forEach(sk => {
    if (sk.soon || !sandbox._getAvailableServers(sk).includes(srv)) return;
    compatFor(sk, srv).forEach(targetId => {
      const target = skillById.get(targetId);
      if (!target || target.soon || !sandbox._getAvailableServers(target).includes(srv)) return;
      if (!compatFor(target, srv).includes(sk.id)) { console.error(`[COMPAT ERROR] ${sk.class} > ${sk.name} (${sk.id}) on ${srv}: shows '${targetId}', which does not list it back there`); errorCount++; }
    });
  });
}

// 5. Report standalone dep objects with no matching SKILLS card yet (AGENTS.md
// Section 5.C Step 3.5's "close the loop" backlog). Informational only -- never
// fails the build. A dep is "resolved" once some skill's own id matches
// "<classPrefix>_<dep.id>" (every observed dep so far lives in the same class
// as the skill(s) that reference it).
// Standalone combat-condition / stack-count toggles that do not correspond to an individual passive skill card.
const PSEUDO_DEPS = new Set(["doomStack", "slayerRaceMatch", "moleStructureTarget"]);
const DEP_FIELDS = ["cdDep", "castDep", "dmgDep", "dmgRankDep", "dmgMultDep", "hitCountDep", "dep", "descDep", "koDep", "shieldDep", "shieldRankDep", "lckDiffDep"];
const seenDeps = new Map(); // dep.id -> { label, resolved, referencedBy: [] }
SKILLS.forEach(sk => {
  const classPrefix = sk.class.toLowerCase() + "_";
  DEP_FIELDS.forEach(field => {
    const dep = sk[field];
    if (!dep || !dep.id) return;
    if (!seenDeps.has(dep.id)) {
      seenDeps.set(dep.id, { label: dep.label || dep.id, resolved: skillById.has(classPrefix + dep.id) || PSEUDO_DEPS.has(dep.id), referencedBy: [] });
    }
    seenDeps.get(dep.id).referencedBy.push(sk.id);
  });
});
const danglingDeps = [...seenDeps.entries()].filter(([, v]) => !v.resolved);
if (danglingDeps.length > 0) {
  console.log(`\n[DEP BACKLOG] ${danglingDeps.length} standalone dep(s) with no matching SKILLS card yet (AGENTS.md Step 3.5):`);
  danglingDeps.forEach(([id, v]) => {
    console.log(`  - ${v.label} (dep id "${id}"), referenced by: ${v.referencedBy.join(", ")}`);
  });
}

// 6. FIELD-LOSS GUARD (blocking). Several Penguin cards once lost their whole
// dmg/hitCount/ko/lckProc formulas because a patch script replaced entire card
// lines with hand-typed text -- and nothing failed, since a card without `dmg`
// is still "valid". So: while the tree has pending changes, every card that
// exists at HEAD must still have every top-level field it had at HEAD.
// A deliberate removal must be named explicitly:
//   node scripts/validate_skills.js --allow-field-loss=penguin_iceBlock:castTime,penguin_x:dmg
// (AGENTS.md "Editing index.html safely": never replace a whole card line.)
function splitCardFields(line) {
  const s = line.trim();
  let j = s.indexOf('{') + 1;
  const stack = [];
  let instr = null, esc = false, cur = '';
  const parts = [];
  while (j < s.length) {
    const c = s[j];
    if (instr) {
      cur += c;
      if (esc) esc = false;
      else if (c === '\\') esc = true;
      else if (instr === '`' && c === '$' && s[j + 1] === '{') { cur += '{'; j++; stack.push('${'); instr = null; }
      else if (c === instr) instr = null;
      j++; continue;
    }
    if (stack.length && stack[stack.length - 1] === '${' && c === '}') { stack.pop(); cur += c; instr = '`'; j++; continue; }
    if (c === '"' || c === "'" || c === '`') { instr = c; cur += c; j++; continue; }
    if ('{[('.includes(c)) { stack.push(c); cur += c; j++; continue; }
    if ('}])'.includes(c)) { if (!stack.length) break; stack.pop(); cur += c; j++; continue; }
    if (c === ',' && !stack.length) { parts.push(cur.trim()); cur = ''; j++; continue; }
    cur += c; j++;
  }
  if (cur.trim()) parts.push(cur.trim());
  return parts.map(p => (p.match(/^([A-Za-z_$][\w$]*)\s*:/) || [])[1]).filter(Boolean);
}
function cardFieldMap(source) {
  const lines = source.split('\n');
  const start = lines.findIndex(l => l.startsWith('const SKILLS = ['));
  const end = lines.findIndex((l, i) => i > start && l.startsWith('];'));
  const map = new Map();
  for (let i = start + 1; i < end; i++) {
    const m = lines[i].match(/^  \{ id:"([^"]+)"/);
    if (!m) continue;
    let k = i; const buf = [lines[i]];
    while (!lines[k].trimEnd().endsWith('},') && k + 1 < end) { k++; buf.push(lines[k]); }
    map.set(m[1], new Set(splitCardFields(buf.join(' '))));
  }
  return map;
}
if (indexDirty) {
  let headHtml = null;
  try {
    headHtml = execFileSync('git', ['show', 'HEAD:12t_projects/bible/index.html'], { cwd: path.resolve(__dirname, '..'), encoding: 'utf8', maxBuffer: 64 * 1024 * 1024 });
  } catch (e) { /* first commit / file untracked: nothing to compare */ }
  if (headHtml) {
    const allowArg = process.argv.find(a => a.startsWith('--allow-field-loss='));
    const allowed = new Set(allowArg ? allowArg.slice('--allow-field-loss='.length).split(',').map(x => x.trim()).filter(Boolean) : []);
    const before = cardFieldMap(headHtml), after = cardFieldMap(html);
    const losses = [];
    before.forEach((keys, id) => {
      if (!after.has(id)) return;   // whole-card removal is a separate, visible diff
      keys.forEach(k => { if (!after.get(id).has(k) && !allowed.has(id + ':' + k)) losses.push(id + ':' + k); });
    });
    if (losses.length) {
      errorCount++;
      console.error(`[FIELD LOSS ERROR] ${losses.length} field(s) present at HEAD are gone from the working tree (a script probably replaced a whole card line):`);
      losses.forEach(l => console.error('  - ' + l));
      console.error('  If intended, re-run with --allow-field-loss=<id:field,...>; otherwise restore them (git show HEAD:12t_projects/bible/index.html).');
    } else {
      console.log(`Field-loss guard: no card lost a field vs HEAD (${before.size} cards compared).`);
    }
  }
}

// 7. DOC COVERAGE BACKLOG (informational, never fails). AGENTS.md: every skill
// shown in the app must have an entry in its class's `<class>-skill-reference.md`
// under "# Damage & Mechanics" (no exclusions). Name-match heuristic: the card's
// base name must appear as a word in that section. Add --list-doc-backlog for names.
{
  const refDir = path.resolve(__dirname, '../12t_reference');
  const perClass = new Map();
  SKILLS.forEach(sk => {
    const [cls, ...rest] = sk.id.split('_');
    if (sk.soon) return;   // coming-soon stub cards (ToT EX, Reborn C6 / C7) carry no data yet, nothing to document
    if (cls === 'common') return;   // shared skills live once in 12Tails-Mechanics-Reference.md §3.5
    const base = rest.join('_');
    if (!perClass.has(cls)) {
      const f = path.join(refDir, cls + '-skill-reference.md');
      let text = '';
      if (fs.existsSync(f)) {
        const doc = fs.readFileSync(f, 'utf8');
        const i = doc.indexOf('\n# Damage & Mechanics');
        text = i === -1 ? '' : doc.slice(i);
      }
      perClass.set(cls, { text, total: 0, missing: [] });
    }
    const e = perClass.get(cls);
    e.total++;
    const re = new RegExp('(?<![A-Za-z])' + base.replace(/[.*+?^${}()|[\]\\]/g, '\\$&') + '(?:[0-9]|-[0-9])?(?![a-z])', 'i');
    if (!re.test(e.text)) e.missing.push(base);
  });
  const gaps = [...perClass.entries()].filter(([, e]) => e.missing.length);
  if (gaps.length) {
    const total = gaps.reduce((n, [, e]) => n + e.missing.length, 0);
    console.log(`\n[DOC BACKLOG] ${total} app skill(s) have no entry under "# Damage & Mechanics" in their <class>-skill-reference.md:`);
    gaps.forEach(([cls, e]) => {
      console.log(`  - ${cls}: ${e.missing.length}/${e.total} missing` + (process.argv.includes('--list-doc-backlog') ? ` -> ${e.missing.join(', ')}` : ''));
    });
  }
}

// Card cooldown vs the class reference table's "CD Base" (max rank). Catches a card whose cd drifted from
// the decoded source (Falling Comets 30 vs 60, Blink 2 vs 12, 2026-10-09). Cards with no cd are skipped
// (passives, step cards); the two below legitimately differ from the table.
let checkedCdRef = 0;
{
  const CD_REF_EXEMPT = new Set(['cat_heartRipper', 'sheep_revive']);   // table row is Finishing Blow's 120 / a per-rank pair
  const refDir = path.resolve(__dirname, '../12t_reference');
  const byId = new Map(SKILLS.map(s => [s.id, s]));
  fs.readdirSync(refDir).filter(f => f.endsWith('-skill-reference.md')).forEach(f => {
    const cls = f.replace('-skill-reference.md', '');
    fs.readFileSync(path.join(refDir, f), 'utf8').split('\n').forEach(line => {
      const p = line.split('|').map(s => s.trim());
      if (p.length < 6 || !/^[A-Za-z0-9_]+$/.test(p[1]) || !/^[\d.]+$/.test(p[4])) return;
      const sk = byId.get(cls + '_' + p[1]);
      if (!sk || sk.cd == null || CD_REF_EXEMPT.has(sk.id)) return;
      checkedCdRef++;
      const cardCd = Array.isArray(sk.cd) ? Math.max(...sk.cd) : sk.cd;
      if (cardCd !== Number(p[4])) {
        errorCount++;
        console.error(`[CD REF ERROR] ${sk.id}: card cd ${JSON.stringify(sk.cd)} but ${f} says CD Base ${p[4]}`);
      }
    });
  });
}

// Whale Wave: min damage = ceil(talAdjust(floor(weight x (0.5 + 0.5 sLv))) x (1 - 0.05 x distance)) (Whale.cs:31978);
// the distance is capped at the 6 m radius (9 m with Diving Press, which then floors 1.5x of the ceil'd value).
let checkedWhaleWave = 0;
{
  const sk = SKILLS.find(s => s.id === "whale_whaleWave"), inp = vm.runInContext("DMG_INPUT_VALS", sandbox);
  const F32 = Math.fround;
  const check = (label, ok, got) => { checkedWhaleWave++; if (!ok) { errorCount++; console.error(`[WHALE WAVE ERROR] ${label}: got ${got}`); } };
  const saved = { w: inp.whaleWeight, d: inp.whaleWaveDist }, savedDp = sandbox._depRanks.divingPress;
  check("card has the weight and distance boxes", !!sk && (sk.dmgInputs || []).map(i => i.key).join() === "whaleWeight,whaleWaveDist");
  if (sk) {
    const minAt = (rank, w, d, dp) => {
      inp.whaleWeight = w; inp.whaleWaveDist = d; sandbox._depRanks.divingPress = dp;
      sandbox._skillRanks[sk.id] = rank; sandbox._selectSkill(sk);
      return sandbox._calcRangeFor(sandbox._getDmgText(sk, rank))[0];
    };
    const tal = (rank, w) => minAt(rank, w, 0, 0);
    [[1, 100, 100], [2, 100, 150], [2, 101, 151], [1, 37, 37], [2, 37, 55]].forEach(([r, w, n]) => {
      sandbox._skillRanks[sk.id] = r; sandbox._selectSkill(sk); inp.whaleWeight = w; inp.whaleWaveDist = 0; sandbox._depRanks.divingPress = 0;
      const want = sandbox._calcRangeFor(`talAdjust(${n})`)[0];
      check(`rank ${r} weight ${w}: base talAdjust(${n})`, tal(r, w) === want, tal(r, w));
    });
    [[1, 100, 3], [2, 101, 6], [2, 100, 8]].forEach(([r, w, d]) => {
      const base = tal(r, w), reach = 6;
      check(`rank ${r} weight ${w} distance ${d}: ceil(base x (1 - 0.05 x min(d, 6)))`, minAt(r, w, d, 0) === Math.ceil(Math.fround(base * F32(1 - F32(F32(0.05) * Math.min(d, reach))))), minAt(r, w, d, 0));
    });
    const dpBase = minAt(2, 100, 0, sk.dmgMultDep.maxRank);   // Diving Press on, no falloff
    check("Diving Press at distance 8: 1.5x of the ceil'd falloff value, reach 9", minAt(2, 100, 8, sk.dmgMultDep.maxRank) === Math.trunc(Math.ceil(Math.fround(Math.trunc(dpBase / 1.5) * F32(1 - F32(F32(0.05) * 8)))) * 1.5), minAt(2, 100, 8, sk.dmgMultDep.maxRank));
  }
  // The distance box's max follows Diving Press (6 m off, 9 m on): dmgIn clamps a stored 9 back to 6 when it is off.
  const dmgInFn = vm.runInContext('dmgIn', sandbox);
  inp.whaleWaveDist = 9; sandbox._depRanks.divingPress = 0;
  check('distance box max is 6 m without Diving Press', dmgInFn('whaleWaveDist') === 6, dmgInFn('whaleWaveDist'));
  sandbox._depRanks.divingPress = sk.dmgMultDep.maxRank;
  check('distance box max is 9 m with Diving Press', dmgInFn('whaleWaveDist') === 9, dmgInFn('whaleWaveDist'));
  // The falloff is its own term (ceil bracket, caption, the factor), not folded into the base / TAL numbers; hidden at distance 0.
  const formulaAt = (d) => { inp.whaleWeight = 100; inp.whaleWaveDist = d; sandbox._depRanks.divingPress = 0; sandbox._skillRanks[sk.id] = 1; sandbox._selectSkill(sk); return sandbox._renderOneDmgFormula(sk, 1, sandbox._getDmgText(sk, 1)); };
  const at3 = formulaAt(3), at0 = formulaAt(0);
  check('distance 3 draws its own term: caption, factor 0.85 and a ceil bracket', at3.includes('ระยะ 3m') && at3.includes('0.85') && at3.includes('⌈') && at3.includes('⌉'), at3.length);
  check('distance 0 draws no distance term', !at0.includes('ระยะ 0m') && !at0.includes('⌈'), at0.length);
  inp.whaleWeight = saved.w; inp.whaleWaveDist = saved.d; sandbox._depRanks.divingPress = savedDp;
}
console.log(`Verified ${checkedWhaleWave} Whale Wave weight / distance checks.`);
// Every custom number box: integer limits, min <= def <= max (a function max is checked at both ends of its range).
let checkedInputBoxes = 0;
SKILLS.forEach(sk => (sk.dmgInputs || []).forEach(d => {
  checkedInputBoxes++;
  const max = typeof d.max === 'function' ? d.max() : d.max;
  if (!Number.isInteger(d.min) || !Number.isInteger(max) || d.min > max || (!d.auto && (d.def < d.min || d.def > max))) { errorCount++; console.error(`[INPUT BOX ERROR] ${sk.id}.${d.key}: min ${d.min}, def ${d.def}, max ${max}`); }
}));
console.log(`Verified ${checkedInputBoxes} custom input box limits.`);
// A maxlength on a skill number box rejects the digit that would exceed it (999 box + typed 1 -> nothing happens) instead of letting the clamp
// pull it to the max, so none of them may carry one.
{
  const tags = fs.readFileSync(targetPath, 'utf8').match(/<input[^>]*class="sk-current-sp-input"[^>]*>/g) || [];
  const bad = tags.filter(x => /maxlength=/.test(x));
  if (bad.length) { errorCount++; console.error(`[INPUT BOX ERROR] ${bad.length} skill number box(es) carry a maxlength: ${bad[0].slice(0, 120)}`); }
  console.log(`Verified ${tags.length} skill number box tags have no maxlength.`);
}



// Falling Comets scatter model (Penguin.cs:26266-26343 cast, :26808-26846 fire, :37542-37580 Giant fire, Damage.cs:1058-1085 FindAreaTarget).
// Landing = whole metres -8..+7 per axis (-10..+9 with Giant Star); a comet hits when |d - collider radius| < R (R 6, Giant 9; the collider point nearest the
// blast, Damage.cs:1058-1090) and deals floor(U x (1 - 0.5 d / R)), d = distance to the centre. The Bible assumes a 1 m radius monster (scatterCells(skill, radius) takes others). The cell counts below were counted by hand from those rules,
// not by running the code under test:
//   base, collider 1 m: d < 7 -> 7+9+11+(7 columns of 13)+11+9+7 = 145 of 256
//   base, collider 15 m: 9 < d -> 7+10+6+2 = 25 of 256, plus the dead-centre cell = 26 (a zero offset has no direction, Vector3.normalized is zero,
//     so the collider point collapses onto the centre and it hits; every other deep-inside cell misses, it is far from the collider edge)
//   Giant, collider 1 m: d < 10 -> 305 of 400
let checkedComets = 0;
{
  const sk = SKILLS.find(s => s.id === "penguin_fallingComets");
  const check = (label, ok, got) => { checkedComets++; if (!ok) { errorCount++; console.error(`[COMET ERROR] ${label}: got ${got}`); } };
  const gid = sk && sk.dmgMultDep ? sk.dmgMultDep.id : "giantStar", savedGiant = sandbox._depRanks[gid];
  const hitsAt = (r, giant) => { sandbox._depRanks[gid] = giant ? 1 : 0; const c = sandbox._scatterCells(sk, r).cells; return { total: c.length, hits: c.filter(x => x.hit).length, cells: c }; };
  const a = hitsAt(1, false), b = hitsAt(15, false), g = hitsAt(1, true);
  check("base scatter is 16 x 16 whole metres", a.total === 256, a.total);
  check("base, collider 1 m: 145 cells hit", a.hits === 145, a.hits);
  check("base, collider 15 m: 26 cells hit (25 ring cells + the dead centre)", b.hits === 26, b.hits);
  check("Giant Star scatter is 20 x 20 and 305 cells hit at 1 m", g.total === 400 && g.hits === 305, g.hits);
  const at = (cells, x, z) => cells.find(c => c.x === x && c.z === z);
  check("dead centre hits a small body for the full 100%", at(a.cells, 0, 0).hit && at(a.cells, 0, 0).mult === 1, JSON.stringify(at(a.cells, 0, 0)));
  check("a cell deep inside a 15 m body, (1, 0), MISSES (the collider point is 14 m from the blast)", !at(b.cells, 1, 0).hit, JSON.stringify(at(b.cells, 1, 0)));
  check("dead centre still hits a 15 m body (zero direction vector)", at(b.cells, 0, 0).hit && at(b.cells, 0, 0).mult === 1, JSON.stringify(at(b.cells, 0, 0)));
  check("(3, 4) is 5 m out: 1 - 0.5 x 5 / 6 = 0.5833", Math.abs(at(a.cells, 3, 4).mult - 7 / 12) < 1e-6, at(a.cells, 3, 4).mult);
  check("(-8, -8) hits a 15 m body with 1 - 0.5 x 11.314 / 6 = 0.0572", at(b.cells, -8, -8).hit && Math.abs(at(b.cells, -8, -8).mult - (1 - 0.5 * Math.sqrt(128) / 6)) < 1e-6, at(b.cells, -8, -8).mult);
  check("Giant Star divides by 9: (3, 4) = 1 - 0.5 x 5 / 9", Math.abs(at(g.cells, 3, 4).mult - (1 - 2.5 / 9)) < 1e-6, at(g.cells, 3, 4).mult);
  // The Raw range is the plain talAdjust range scaled by the worst / best reachable falloff, floored: farthest hit at 1 m is (6, 3), d = sqrt(45).
  if (sk) {
    sandbox._depRanks[gid] = 0; sandbox._skillRanks[sk.id] = 1; sandbox._selectSkill(sk);
    const text = sandbox._getDmgText(sk, 1), withModel = sandbox._calcRangeFor(text), flag = sk.scatterModel;
    sk.scatterModel = false; const plain = sandbox._calcRangeFor(text); sk.scatterModel = flag;
    const minMult = Math.fround(1 - Math.fround(0.5 * Math.fround(Math.fround(Math.sqrt(45)) / 6)));
    check("Raw range = floor(plain range x [worst, best] falloff)", withModel[0] === Math.floor(Math.fround(plain[0] * minMult)) && withModel[1] === Math.floor(Math.fround(plain[1] * 1)), JSON.stringify([plain, withModel]));
    const heroHtml = sandbox._getRenderedHeroHtml();
    check("the card shows the hit odds for the fixed 1 m body (145 / 256 = 57%) and has no radius slider", heroHtml.includes("โดน 57% ต่อดวง") && !heroHtml.includes("comet-radius"), heroHtml.includes("comet-radius"));
    const shared = [0, 1, 2, 3, 4, 5, 6, 7].map(() => sandbox._rollOneHit(sk, 1, 0, false, undefined, { talRoll: 3, scatterMult: 1 }));
    check("a rolled comet hit with a shared talAdjust roll and a falloff is a positive whole number", shared.every(v => Number.isInteger(v) && v >= 1), JSON.stringify(shared));
    const fullAvg = shared.reduce((s, v) => s + v, 0) / shared.length, farAvg = [0, 1, 2, 3, 4, 5, 6, 7].map(() => sandbox._rollOneHit(sk, 1, 0, false, undefined, { talRoll: 3, scatterMult: 0.3 })).reduce((s, v) => s + v, 0) / 8;
    check("a far landing (falloff 0.3) deals less than a dead-centre one on the same cast roll", farAvg < fullAvg, farAvg + " vs " + fullAvg);
    check("hit count range is 0 to 5 comets at rank 1 (a comet can miss)", JSON.stringify(sandbox._dmgHitCountRange) === "[0,5]", JSON.stringify(sandbox._dmgHitCountRange));
  }
  sandbox._depRanks[gid] = savedGiant;
}
console.log(`Verified ${checkedComets} Falling Comets scatter checks.`);
// Chiroptophobia (Bat.cs:13166-13241, CharacterControl.cs:9660-9690): purple 7 x (blind Lv + confuse Lv) + 7 per tick, nothing when the target has neither.
let checkedChiro = 0;
{
  const sk = SKILLS.find(s => s.id === "bat_chiroptophobia"), ids = ["chiroBlind", "chiroConfuse"], saved = ids.map(i => sandbox._depRanks[i]);
  const check = (label, ok, got) => { checkedChiro++; if (!ok) { errorCount++; console.error(`[CHIROPTOPHOBIA ERROR] ${label}: got ${got}`); } };
  check("Blind and Confuse go 0 to 3 (level 3 = skill Lv 2 + Shame, Bat.cs:32208) with their own level III icons", !!sk && (sk.dmgControls || []).every(d => d.maxRank === 3 && d.cycleRanks) && ["bat_blind3", "bat_confusion3"].every(k => /^data:image\/(png|webp);base64,/.test(SKILL_ICONS[k] || "")), sk && JSON.stringify((sk.dmgControls || []).map(d => d.maxRank)));
  check("the card has Blind and Confuse toggles and no input box", !!sk && (sk.dmgControls || []).map(d => d.id).join() === "chiroBlind,chiroConfuse" && !sk.dmgInputs, sk && JSON.stringify((sk.dmgControls || []).map(d => d.id)));
  if (sk) {
    [[0, 0, "0"], [1, 0, "14"], [0, 2, "21"], [2, 2, "35"], [1, 2, "28"], [3, 0, "28"], [3, 3, "49"]].forEach(([b, c, want]) => {
      sandbox._depRanks.chiroBlind = b; sandbox._depRanks.chiroConfuse = c; sandbox._skillRanks[sk.id] = 1; sandbox._selectSkill(sk);
      check(`Blind ${b} + Confuse ${c}: damage ${want}`, sandbox._getDmgText(sk, 1) === want, sandbox._getDmgText(sk, 1));
    });
    // Strip labels per level: Blind 1 / Blind 2 / Blind 3 (Shame), the same for Confuse.
    [["chiroBlind", "Blind"], ["chiroConfuse", "Confuse"]].forEach(([dep, name]) => {
      [[0, name], [1, name + " 1"], [2, name + " 2"], [3, name + " 3 (Shame)"]].forEach(([r, want]) => {
        sandbox._depRanks.chiroBlind = 2; sandbox._depRanks.chiroConfuse = 2; sandbox._depRanks[dep] = r; sandbox._selectSkill(sk);
        check(`${dep} level ${r}: the strip label is "${want}"`, sandbox._getRenderedHeroHtml().includes(`<span class="sk-dep-item-name">${want}</span>`), want);
      });
    });
    [["chiroBlind", "bat_blind"], ["chiroConfuse", "bat_confusion"]].forEach(([dep, icon]) => {
      sandbox._depRanks.chiroBlind = 2; sandbox._depRanks.chiroConfuse = 2; sandbox._depRanks[dep] = 3; sandbox._selectSkill(sk);
      const html = sandbox._getRenderedHeroHtml(), at = (n) => SKILL_ICONS[icon + n];   // the whole data URI identifies an icon (a slice of a WebP is not unique: the headers match); the compat tiles show the level-2 icon, so only the level-3 one is unique
      sandbox._depRanks[dep] = 2; sandbox._selectSkill(sk);
      const lower = sandbox._getRenderedHeroHtml();
      check(`${dep}: the custom ${icon}3 icon shows at level 3 and not at level 2`, html.includes(at(3)) && !lower.includes(at(3)), html.includes(at(3)) + "/" + lower.includes(at(3)));
    });
    sandbox._depRanks.chiroBlind = 0; sandbox._depRanks.chiroConfuse = 0; sandbox._selectSkill(sk);
    check("neither active: the formula is a plain 0, not 7 x 0 + 7", sandbox._renderOneDmgFormula(sk, 1, sandbox._getDmgText(sk, 1)).includes(">0<"), "formula");
  }
  ids.forEach((i, k) => { sandbox._depRanks[i] = saved[k]; });
}
console.log(`Verified ${checkedChiro} Chiroptophobia checks.`);
// Dependency toggle labels shrink their font to fit (fitDepLabels, run after every render, on resize and when fonts load) instead of ending in an ellipsis.
{
  const src = fs.readFileSync(targetPath, "utf8"), css = (src.match(/\.sk-dep-item-name\{[^}]*\}/) || [""])[0];
  const ok = /function fitDepLabels\(\)/.test(src) && /renderHeroNow\(\);\s*fitDepLabels\(\);/.test(src) && /addEventListener\("resize", fitDepLabels\)/.test(src) && !/text-overflow/.test(css);
  if (!ok) { errorCount++; console.error("[DEP LABEL ERROR] fitDepLabels is not wired after renderHeroNow / on resize, or .sk-dep-item-name still truncates with an ellipsis"); }
  console.log("Verified dependency toggle labels shrink instead of truncating.");
}
// fitDmgValues (the shrink-to-fit step for formulas and chip numbers) must run after the full render AND after both live-refresh paths (refreshLiveDamage and the Panda
// boxes), and a formula still too wide at its floor scrolls inside its box: a slider or input that widens a formula used to spill out of the card on a phone.
{
  const src = fs.readFileSync(targetPath, "utf8"), calls = (src.match(/fitDmgValues\(\);/g) || []).length;
  const live = /fitDmgValues\(\);\s*\};\s*const pandaSpInput/.test(src) && /fitDmgValues\(\);\s*\};\s*pandaSpInput\.addEventListener\("input", updatePandaSpLive\)/.test(src);
  const ok = /const fitDmgValues = \(\) =>/.test(src) && calls >= 3 && live && /\.sk-dmg-value\.sk-dmg-scroll\{[^}]*overflow-x:auto/.test(src);
  if (!ok) { errorCount++; console.error(`[FORMULA FIT ERROR] fitDmgValues must run after the render and both live refreshes (${calls} calls) and .sk-dmg-scroll must scroll`); }
  console.log("Verified formulas refit after live inputs and scroll when they cannot shrink.");
}


// Custom buff/debuff rules + final-multiplier maths (2026-09-20)
let checkedCustomBd = 0;
{
  const v = sandbox.validateCustomBd, adj = sandbox.finalMultiplierAdjust;
  const check = (label, cond) => {
    checkedCustomBd++;
    if (!cond) { errorCount++; console.error(`[CUSTOM BD ERROR] ${label}`); }
  };
  if (typeof v !== "function" || typeof adj !== "function") {
    errorCount++; console.error("[CUSTOM BD ERROR] validateCustomBd / finalMultiplierAdjust not exported");
  } else {
    check("stat +20 ok", v({ kind: "stat", name: "Buff", stat: "atk", value: "20" }).ok);
    check("stat all ok", v({ kind: "stat", name: "Buff", stat: "all", value: 5 }).ok);
    check("stat negative rejected", !v({ kind: "stat", name: "Buff", stat: "atk", value: -1 }).ok);
    check("stat decimal rejected", !v({ kind: "stat", name: "Buff", stat: "atk", value: 1.5 }).ok);
    check("stat bad key rejected", !v({ kind: "stat", name: "Buff", stat: "hp", value: 1 }).ok);
    check("enemyStat negative ok", v({ kind: "enemyStat", name: "Debuff", stat: "def", value: -30 }).ok);
    check("enemyStat over 9999 rejected", !v({ kind: "enemyStat", name: "Debuff", stat: "def", value: -10000 }).ok);
    check("empty name rejected", !v({ kind: "dmgMod", name: "  ", value: 0.1 }).ok);
    check("25-char name rejected", !v({ kind: "dmgMod", name: "x".repeat(25), value: 0.1 }).ok);
    check("24-char name ok", v({ kind: "dmgMod", name: "x".repeat(24), value: 0.1 }).ok);
    check("dmgMod negative decimal ok", v({ kind: "dmgMod", name: "Nerf", value: "-0.15" }).ok);
    check("hitMod rounds to 2dp", v({ kind: "hitMod", name: "H", value: "0.123" }).entry.value === 0.12);
    check("hitMod out of range rejected", !v({ kind: "hitMod", name: "H", value: 11 }).ok);
    check("finalMult 24 ok", v({ kind: "finalMult", name: "F", value: "24" }).ok);
    check("finalMult negative rejected", !v({ kind: "finalMult", name: "F", value: -1 }).ok);
    check("finalMult over 1000 rejected", !v({ kind: "finalMult", name: "F", value: 1001 }).ok);
    check("NaN rejected", !v({ kind: "dmgMod", name: "N", value: "abc" }).ok);
    check("blank value rejected", !v({ kind: "dmgMod", name: "N", value: "" }).ok);
    check("unknown kind rejected", !v({ kind: "bogus", name: "N", value: 1 }).ok);
    // legacy numeric count and the new percent-step array must agree for built-in 5% stacks
    check("legacy count 2 == [5,5]", adj(100, 2) === adj(100, [5, 5]) && adj(100, 2) === 111);
    check("no steps leaves damage alone", adj(100, []) === 100 && adj(100, 0) === 100);
    check("custom 24% steps with ceil (25 -> 31)", adj(25, [24]) === 31);
    check("built-in then custom order", adj(100, [5, 24]) === Math.ceil(105 * 124 / 100));
  }
}

console.log(`Evaluated ${checkedFormulas} formula permutations across all ranks and dependencies.`);
console.log(`Verified ${checkedCustomBd} custom buff/debuff checks.`);
console.log(`Verified ${checkedCdRef} card cooldowns against the class reference tables.`);
console.log(`Verified ${checkedLckFloors} LCK-invariant-floor permutations.`);
console.log(`Verified ${checkedGaosHeroRouting} Gaos own-stat render permutations.`);
console.log(`Verified ${checkedDeepLinks} deep-link routing checks.`);
console.log(`Verified ${checkedStatusKeywords} status keyword checks.`);
console.log(`Verified ${checkedLckDiff} LCK-difference (Lucky Card / Joker) checks.`);
console.log(`Verified ${checkedBenediction} Sheep Benediction (talAdjust base order) checks.`);
console.log(`Verified ${checkedRankIcons} multi-rank icon presence checks.`);
console.log(`Verified ${checkedLckLabels} lckProc/secondaryLckProc label checks.`);
console.log(`Verified ${checkedDurLabels} duration chip label checks.`);
console.log(`Verified ${checkedPortraits} class portrait checks.`);
console.log(`Verified ${checkedPanelMarkup} stat panel structure checks.`);
console.log(`Verified ${checkedSummonFeed} summon stat-feed glow checks.`);
// LCK glow follows what LCK really does (user 2026-10-21): a direct read glows fully (getUsed*StatKeys), numbers that move only through the
// *Adjust LCK roll glow softly (getSoft*StatKeys: less than a main stat, more than the faded grey), and a card whose numbers never move with LCK
// does neither (e.g. TTO, where talAdjust / dmgAdjust / defAdjust lost their roll). Measured on every card and server: LCK 0 against 200.
let checkedLckGlow = 0, skippedLckGlow = 0, knownLckGlow = 0;
// Soft glows whose roll is real but never reaches the shown numbers, checked by hand (2026-10-21). A card leaves this list when its display changes.
const LCK_GLOW_HIDDEN = {
  all: Object.fromEntries(["cat_luckyDice", "cat_grandCasinoArcade", "mole_stunMine", "mole_stunGrenade", "penguin_fallingComets", "rabbit_backpack", "whale_shieldBash"].map(id => [id,
    // enemy side: the range's low end is fixed (raw damage from 0, a hit that can miss, or Shield Bash's raw = the player's DEF, which this check
    // can't set) and its high end uses the target's roll at 0, so the target's LCK moves only the hits in between (ทดสอบดาเมจ), never the two ends
    "the target's roll moves only the hits inside the range"])),
  tto: Object.fromEntries(["chameleon_tormentRain", "mole_warFactory_sawMachine", "mole_warFactory_bazooka", "mole_warFactory_teslaCoil", "mole_warFactory_rollerMachine"].map(id => [id,
    // TTO (no damage roll): a 3 s cooldown shown in whole seconds; the agiAdjust roll crosses a whole second only at some AGI values (AGI 30: 3s -> 2-3s)
    "the cooldown roll crosses a whole second only at some AGI values"])),
  // ToT makes Mike Circle active with a 3 s agiAdjust cooldown shown in whole seconds (1.3-1.5 s at AGI 128 rounds up to 2 s): same case as the tto list
  tot: { monkey_mikeCircle: "the cooldown roll crosses a whole second only at some AGI values" },
};
if (RUN_DAMAGE_CHECKS) {
  const inputs = sandbox._statInputs, bad = [], savedIn = Object.fromEntries(Object.entries(inputs).map(([k, el]) => [k, el.value]));
  for (const k of Object.keys(inputs)) inputs[k].value = DATA_ROLE_DEFAULTS[k] !== undefined ? DATA_ROLE_DEFAULTS[k] : "128";   // known stats: earlier checks leave inputs changed (ATK 0 pins every hit at 1)
  const soft = (fn, sk) => typeof sandbox[fn] === "function" ? sandbox[fn](sk) : new Set();
  // a fresh render goes through another card of the SAME class: a class switch loads that class's saved stat preset over the stats set here
  const sameClass = (sk) => SKILLS.find(x => x.class === sk.class && x.id !== sk.id) || SKILLS.find(x => x.id !== sk.id);
  if (typeof sandbox.getSoftPlayerStatKeys !== "function" || typeof sandbox.getSoftEnemyStatKeys !== "function") bad.push("getSoftPlayerStatKeys / getSoftEnemyStatKeys are missing");
  for (const srv of ["og", "tot", "tto", "reborn"]) {   // reborn (user 2026-10-26): only the cards with Reborn data (the others render their BB data there)
    sandbox._setServer(srv);
    for (const sk of SKILLS) {
      if (srv === "reborn" && !(sk.servers && sk.servers.reborn) && sk.onlyServer !== "reborn") continue;
      try {
        // a fresh render each time (another card first): a changed number otherwise leaves its delta-motion markup in the next render
        const render = (p, e) => { inputs.lck.value = p; inputs.enemyLck.value = e; sandbox._selectSkill(sameClass(sk)); sandbox._setServer(srv); sandbox._selectSkill(sk); return sandbox._getRenderedHeroHtml(); };   // _setServer again: leaving a server-exclusive card restores the server before it (serverBeforeExclusive), which was the previous pass's after a Reborn-only stub
        const base = render("0", "0");
        if (render("0", "0") !== base) { skippedLckGlow++; continue; }   // a card that draws something random each render can't be measured this way
        const pHigh = render("200", "0"), pMoves = pHigh !== base, eMoves = render("200", "200") !== pHigh;   // enemy measured with the player at 200, so LCK-difference cards show
        const over = srv === "og" ? null : (sk.servers && sk.servers[srv]) || (srv === "tot" ? sk.ps : null), act = over ? Object.assign({}, sk, over) : sk;   // the page's glow reads the server-merged card
        const usedP = sandbox.getUsedPlayerStatKeys(act), usedE = sandbox.getUsedEnemyStatKeys(act);
        const pFull = usedP.has("lck"), pSoft = soft("getSoftPlayerStatKeys", act).has("lck"), eFull = usedE.has("lck"), eSoft = soft("getSoftEnemyStatKeys", act).has("lck");
        // A soft glow rolls inside another stat's step, so it may show nothing exactly when that step shows nothing at these settings (no damage
        // until a dep is on, a charge level of 0, a hit pinned at 1): then the stats it rolls with move nothing either and the glow stands.
        const stepMoves = (keys) => keys.some(k => { const el = inputs[k], was = el.value; el.value = "0"; const a = render("200", "0"); el.value = "300"; const b = render("200", "0"); el.value = was; return a !== b; });
        // ...or a roll with no room at the default stats (a hit pinned at 1, a chance at 100%): measured again at strong settings first
        const strong = (fn) => ["400", "0"].some(val => { const keep = ["atk", "tal", "agi", "int", "cha", "enemyDef"].map(k => [k, inputs[k].value]); ["atk", "tal", "agi", "int", "cha"].forEach(k => { inputs[k].value = val; }); inputs.enemyDef.value = "0"; try { return fn(); } finally { keep.forEach(([k, x]) => { inputs[k].value = x; }); } });   // strong stats, then weak ones (a short cooldown's roll shows only at low AGI)
        const pMovesStrong = () => strong(() => render("0", "0") !== render("200", "0")), eMovesStrong = () => strong(() => render("200", "0") !== render("200", "200"));
        checkedLckGlow += 2;
        const known = (srv !== "tto" && LCK_GLOW_HIDDEN[srv] || {})[sk.id] || (LCK_GLOW_HIDDEN[srv === "tto" ? "tto" : "all"] || {})[sk.id];   // a real roll the shown numbers can't reveal, checked by hand
        if (known) { knownLckGlow++; continue; }
        if (pMoves && !pFull && !pSoft) bad.push(`${srv} ${sk.id}: the player's LCK moves the numbers but does not glow`);
        if (!pMoves && pFull && !pMovesStrong()) bad.push(`${srv} ${sk.id}: the player's LCK glows fully but moves nothing`);
        if (!pMoves && pSoft && !pMovesStrong() && stepMoves(["atk", "tal", "agi", "int", "cha"].filter(k => usedP.has(k)))) bad.push(`${srv} ${sk.id}: the player's LCK glows softly but moves nothing while the stats it rolls with do`);
        if (eMoves && !eFull && !eSoft) bad.push(`${srv} ${sk.id}: the enemy's LCK moves the numbers but does not glow`);
        if (!eMoves && eFull && !eMovesStrong()) bad.push(`${srv} ${sk.id}: the enemy's LCK glows fully but moves nothing`);
        if (!eMoves && eSoft && !eMovesStrong() && stepMoves(["enemyDef"])) bad.push(`${srv} ${sk.id}: the enemy's LCK glows softly but moves nothing while DEF does`);
      } catch (e) { bad.push(`${srv} ${sk.id}: ${e.message}`); }
    }
  }
  for (const k of Object.keys(inputs)) inputs[k].value = savedIn[k];
  sandbox._setServer("og");
  bad.slice(0, +(process.env.LCK_GLOW_ALL || 40)).forEach(m => console.error("[LCK GLOW ERROR] " + m));
  if (bad.length > 40) console.error(`[LCK GLOW ERROR] ... and ${bad.length - 40} more`);
  errorCount += bad.length;
  console.log(`Verified ${checkedLckGlow} LCK glow checks (LCK 0 vs 200, every card on every server; ${skippedLckGlow} random cards skipped, ${knownLckGlow} known hidden rolls).`);
}
// ATK / DEF on damage groups glow too (user 2026-10-21: Cat Combo's ATK never glowed; its 0.5ATK terms sit on its six combo hits, not on a
// top-level atkCoeff). Every card whose groups carry a non-zero atkCoeff / defCoeff lights that stat, unless a summon with its own stats attacks.
let checkedGroupGlow = 0;
{
  const groupCoeff = (sk, key) => (sk.dmgGroups || []).some(g => g[key] !== undefined && g[key] !== 0);
  const missing = [];
  for (const sk of SKILLS) {
    if (sk.ownStats || sk.ownStatsGadina || (typeof sandbox.skillSummonAttacker === "function" && sandbox.skillSummonAttacker(sk))) continue;   // Gadina reads the player's ATK only through Titan Sword
    const used = sandbox.getUsedPlayerStatKeys(sk);
    if (groupCoeff(sk, "atkCoeff")) { checkedGroupGlow++; if (!used.has("atk")) missing.push(sk.id + " ATK"); }
    if (groupCoeff(sk, "defCoeff")) { checkedGroupGlow++; if (!used.has("def")) missing.push(sk.id + " DEF"); }
  }
  const combo = SKILLS.find(s => s.id === "cat_nAttack");
  checkedGroupGlow++;
  if (!sandbox.getUsedPlayerStatKeys(combo).has("atk")) missing.unshift("cat_nAttack ATK (Cat Combo)");
  if (missing.length) { console.error(`[STAT GLOW ERROR] ${missing.length} stat(s) read by damage groups do not glow: ${missing.join(", ")}`); errorCount++; }
  console.log(`Verified ${checkedGroupGlow} damage-group ATK / DEF glow checks.`);
}

// 3m. effectProc purple mix (2026-09-24, GEMINI.md "effectProc"): Wall Puncture rank-0 off (no rate checks: user 2026-10-21, no statistical thresholds),
// Megalodon's purple Pull group, every bonus amount, and the gold total digits.
let checkedEffectProc = 0;
{
  const ep = sandbox._effectProc, inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedEffectProc++; if (!ok) { console.error(`[EFFECTPROC ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  for (let i = 0; i < 10; i++) check(`gold digit dmgdigit_y${i} present`, /^data:image\/(png|webp);base64,/.test(String(SKILL_ICONS["dmgdigit_y" + i] || "")));
  const byId = id => SKILLS.find(s => s.id === id);
  const savedLck = inputs.lck.value, savedDeps = Object.assign({}, deps);
  const purpleRate = (sk, n, gi) => { let p = 0; for (let i = 0; i < n; i++) { sandbox._rollOneHit(sk, sk.maxRank, undefined, false, gi); if (ep.lastPurple()) p++; } return p / n; };
  const sweep = byId("whale_sweep");
  sandbox._skillRanks[sweep.id] = sweep.maxRank; sandbox._selectSkill(sweep);
  deps.wallPuncture = 0; check("Wall Puncture 0 never procs", purpleRate(sweep, 500) === 0);
  // Whale Combo (Whale.cs:16238-16394): one Wall Puncture roll per swing; a proc replaces the hit with Effect Damage and skips getCritPlus (effectProc.noCrit).
  const wc = byId("whale_nAttack");
  sandbox._skillRanks[wc.id] = 2; sandbox._selectSkill(wc);
  deps.wallPuncture = 4; deps.whaleGearWeapon = 2; deps.whaleGearEquip = 2; inputs.lck.value = "300";
  { let purple = 0, purpleCrit = 0, whiteCrit = 0; for (let i = 0; i < 3000; i++) { sandbox._rollOneHit(wc, 2, undefined, false, 0); if (ep.lastPurple()) { purple++; if (ep.lastCrit()) purpleCrit++; } else if (ep.lastCrit()) whiteCrit++; }
    check("Whale Combo: a purple Wall Puncture hit never crits", purpleCrit === 0, purpleCrit); }
  deps.wallPuncture = 0; deps.whaleGearWeapon = 0; deps.whaleGearEquip = 0;
  // Mole Smart Shell (#264): +30 Effect Damage per enemy hit on Mine, Stun Mine, Stun Grenade, Time Nuke (Mole.cs:11583, Mole_stunGrenade.cs:285, Mole_timeNuke.cs:767).
  ["mole_mine", "mole_stunMine", "mole_stunGrenade", "mole_timeNuke"].forEach(id => { const m = byId(id);
    deps.smartShell = 1; check(`${id} Smart Shell bonus 30`, ep.bonus(m, 1, 0) === 30, ep.bonus(m, 1, 0));
    deps.smartShell = 0; check(`${id} no Smart Shell, no bonus`, ep.bonus(m, 1, 0) === 0, ep.bonus(m, 1, 0)); });
  // Bat Merciless Drain (#421): +66 Effect Damage per Drain Life tick on a target left with no mpDrain / spDrain (Bat.cs:22233-22257).
  { const dl = byId("bat_cAttack"); deps.mercilessDrain = 1; check("Drain Life + Merciless Drain on a dry target: bonus 66", ep.bonus(dl, 3, 0) === 66, ep.bonus(dl, 3, 0));
    deps.mercilessDrain = 0; check("Drain Life without Merciless Drain: no bonus", ep.bonus(dl, 3, 0) === 0, ep.bonus(dl, 3, 0)); }
  // Bison Colossal Weapon (#361-362): splash line under Final Damage, only while the dep is on (user design 2026-10-01).
  { const bc = byId("bison_nAttack"); sandbox._skillRanks[bc.id] = 2;
    deps.colossalWeapon = 2; sandbox._calcRangeFor = undefined; sandbox._selectSkill(bc); const on = sandbox._getRenderedHeroHtml();
    check("Colossal Weapon 2: splash line shown with ท่าที่ 1", on.includes('data-role="splash-line"') && /ท่าที่ 1 <span class="dmg-effect">\d/.test(on));
    deps.colossalWeapon = 0; sandbox._calcRangeFor = undefined; sandbox._selectSkill(bc); const off = sandbox._getRenderedHeroHtml();
    check("Colossal Weapon off: no splash line", !off.includes('data-role="splash-line"')); }
  // Mole TNT (Mole.cs:26048): talAdjust((int)(20 + 10 x n + (Super TNT ? (0.1 n + 0.1) x Lv : 0))); at Lv 100: TNT 4 = 60 + 50 = 110, TNT 1 = 30 + 20 = 50.
  { const lvSaved = inputs.lv.value; inputs.lv.value = "100";
    check("TNT 4 + Super TNT at Lv 100 base 110", sandbox.moleTntBase(4, 1) === 110, sandbox.moleTntBase(4, 1));
    check("TNT 1 + Super TNT at Lv 100 base 50", sandbox.moleTntBase(1, 1) === 50, sandbox.moleTntBase(1, 1));
    check("TNT 4 without Super TNT base 60", sandbox.moleTntBase(4, 0) === 60, sandbox.moleTntBase(4, 0));
    inputs.lv.value = lvSaved; }
  // Mole Synchro Mole (CharacterControl.cs:37772-37777): summon ATK/DEF + floor(0.5 x rank x Mole TAL). TAL 101: rank 1 +50, rank 2 +101.
  check("Barrel Bot 4 + Synchro Mole 1 (TAL 101) ATK 110", sandbox.barrelBotOwnStats(false, 1, 100, 101, 0, 4).atk === 110, sandbox.barrelBotOwnStats(false, 1, 100, 101, 0, 4).atk);
  check("Barrel Bot 4 + Synchro Mole 2 (TAL 101) DEF 161", sandbox.barrelBotOwnStats(false, 2, 100, 101, 0, 4).def === 161, sandbox.barrelBotOwnStats(false, 2, 100, 101, 0, 4).def);
  check("Auto Gyro Gun 4 + Synchro Mole 1 (TAL 101) ATK 90", sandbox.autoGyroGunOwnStats(4, false, 1, 0, 100, 101).atk === 90, sandbox.autoGyroGunOwnStats(4, false, 1, 0, 100, 101).atk);
  // Mole Chopper (Mole.cs:33794, :33957-33986): 10 ticks, +10 Barrel Cannon ring hits with #443.
  { const ch = byId("mole_chopper"); check("Chopper 10 hits, 20 with Barrel Cannon", ch.hitCount(1, false, false) === 10 && ch.hitCount(1, false, true) === 20); }
  const mega = byId("whale_megalodon");
  check("Megalodon Pull group always purple", purpleRate(mega, 50, 0) === 1);
  check("Megalodon Bite group always white", purpleRate(mega, 50, 1) === 0);
  const aw = byId("penguin_arcticWind");
  deps.deadlyFrost = 1; deps.arcticFrost1 = 1; deps.targetFrosted = 0;
  check("Deadly Frost bonus 50 when frost can proc", ep.bonus(aw, 1, 0) === 50, ep.bonus(aw, 1, 0));
  deps.arcticFrost1 = 0; check("Deadly Frost bonus 0 when frost cannot happen", ep.bonus(aw, 1, 0) === 0, ep.bonus(aw, 1, 0));
  deps.targetFrosted = 1; check("Deadly Frost bonus 50 on an already-frosted target", ep.bonus(aw, 1, 0) === 50, ep.bonus(aw, 1, 0));
  deps.deadlyFrost = 0; check("no Deadly Frost, no bonus", ep.bonus(aw, 1, 0) === 0, ep.bonus(aw, 1, 0));
  const fb = byId("penguin_frozenBlast");
  deps.frozenBreak = 1; deps.targetIce = 3; check("Frozen Break bonus = 15 x target ice level", ep.bonus(fb, 1, 0) === 45, ep.bonus(fb, 1, 0));
  deps.frozenBreak = 0; check("no Frozen Break, no bonus", ep.bonus(fb, 1, 0) === 0, ep.bonus(fb, 1, 0));
  const wm = byId("panda_waterMonkey");
  deps.shadowFist = 5; check("Shadow Fist 4 + Spirit Fist (rank 5) at Lv 100 = 12 + 16", ep.bonus(wm, 1, 100) === 28, ep.bonus(wm, 1, 100));
  deps.shadowFist = 4; check("Shadow Fist 4 alone at Lv 100 = 12", ep.bonus(wm, 1, 100) === 12, ep.bonus(wm, 1, 100));
  deps.shadowFist = 0; check("Shadow Fist 0, no bonus", ep.bonus(wm, 1, 100) === 0, ep.bonus(wm, 1, 100));
  // Cat Open Wound (#443): 30 x (target disarm Lv + bleed Lv) per landed hit, gated by the passive; hit-number gating (Cat.cs:10404, 17390-17507, 38717-39031).
  const ow = byId("cat_flyingDagger"), fbl = byId("cat_finishingBlow"), cmb = byId("cat_nAttack");
  deps.openWound = 1;
  check("Open Wound on = 30 x (Disarm 2 + Bleed 2) = 120 per hit", ep.bonus(ow, 1, 0) === 120, ep.bonus(ow, 1, 0));
  deps.openWound = 0; check("Open Wound off, no bonus", ep.bonus(ow, 1, 0) === 0, ep.bonus(ow, 1, 0));
  check("bbBugSee points at a card that owns the bug (bbBug) and the text names it", sandbox.SKILLS.filter(s => s.bbBugSee).every(s => { const o = sandbox.SKILLS.find(x => x.id === s.bbBugSee.id); return o && o.bbBug && s.bbBugSee.text && s.bbBugSee.text.toLowerCase().includes(o.name.toLowerCase()); }));
  check("Open Wound is one toggle: no separate target Disarm/Bleed deps", !sandbox.SKILLS.some(s => s.effectProc && s.effectProc.controls && s.effectProc.controls.some(d => /^catTarget/.test(d.id))));
  check("Finishing Blow carries the bonus on hit 3 only", [0, 1, 2, 3].map(i => ep.hitOk(fbl, 1, i)).join() === "false,false,true,false", [0, 1, 2, 3].map(i => ep.hitOk(fbl, 1, i)).join());
  check("a card without effectProc.hits carries it on every hit", ep.hitOk(ow, 1, 0) && ep.hitOk(ow, 1, 2));
  deps.catComboHidden = 0; check("Combo without Hidden Blade: Open Wound on all 6 hits", [0, 1, 2, 3, 4, 5].every(i => ep.hitOk(cmb, 3, i)));
  deps.catComboHidden = 3; check("Combo with Hidden Blade: stage 2 hit has no Open Wound", [0, 1, 2, 3, 4, 5].map(i => ep.hitOk(cmb, 3, i)).join() === "true,false,true,true,true,true");
  inputs.lck.value = savedLck;
  Object.keys(deps).forEach(k => delete deps[k]); Object.assign(deps, savedDeps);
}
// 3n. Test button (2026-09-24 redesign): Thai labels per kind, starburst vs cross icon, "×N ฮิต" count only when
// there is one, the small per-mode variant, and the rendered main button on a multi-hit card. Final chip (user 2026-10-23,
// variant 5 of 5 mocks): the main Test is a bar along the chip's bottom (has-test-bar) with no count of its own, the hit
// count is the chip's top tab, and the number reads "5,112 ~ 5,964" (fmtFinalRange).
let checkedTestBtn = 0;
{
  const check = (label, ok) => { checkedTestBtn++; if (!ok) { console.error(`[TEST BUTTON ERROR] ${label}`); errorCount++; } };
  const b = sandbox.simulateBtnHtml;
  const dmg = b({ role: "simulate-hit", count: "10" }), heal = b({ role: "simulate-hit", kind: "heal" }), hate = b({ role: "simulate-hit", kind: "hate" });
  check("damage label", dmg.includes("<span>ทดสอบดาเมจ</span>"));
  check("damage count reads ×10 ฮิต", dmg.includes('<span class="sk-sim-count">×10 ฮิต</span>'));
  check("damage uses the starburst icon", dmg.includes("<polygon"));
  check("heal label + cross icon", heal.includes("<span>ทดสอบฮีล</span>") && heal.includes("<path") && !heal.includes("<polygon"));
  check("hate label + starburst icon", hate.includes("<span>ทดสอบ Hate</span>") && hate.includes("<polygon"));
  check("no count text when there is no count", !heal.includes("sk-sim-count"));
  const grp = b({ role: "simulate-group", groupIndex: 2, small: true, count: "4" });
  check("per-mode button is the small variant with its group index", grp.includes("is-sm") && grp.includes('data-group-index="2"') && grp.includes("×4 ฮิต"));
  const sk = SKILLS.find(s => s.id === "whale_peninsulaImpale");
  sandbox._skillRanks[sk.id] = sk.maxRank; sandbox._selectSkill(sk);
  const hero = sandbox._getRenderedHeroHtml();
  const fin = hero.slice(hero.indexOf("sk-stat sk-dmg-final"));
  check("a multi-hit card renders the main Test button as the Final chip's bar", fin.startsWith("sk-stat sk-dmg-final has-test-bar") && fin.includes('data-role="simulate-hit"'));
  const btnAt = fin.indexOf('data-role="simulate-hit"'), mainBtn = fin.slice(btnAt, fin.indexOf("</button>", btnAt));
  check("the hit count sits on the Final chip's tab, not on the main Test button", fin.includes('<span class="sk-dmg-hits-tab"><b>10</b>ฮิต</span>') && btnAt > 0 && !mainBtn.includes("sk-sim-count"));
  const f = sandbox.fmtFinalRange;
  check("Final range reads 5,112 ~ 5,964 with a muted separator", f([5112, 5964]) === '5,112<span class="sk-range-sep">~</span>5,964');
  check("Final range with equal ends or one value shows one number", f([4500, 4500]) === "4,500" && f([12.5]) === "12.5" && f([128450, 196320]) === '128,450<span class="sk-range-sep">~</span>196,320');
  const healSk = SKILLS.find(s => s.isHeal && s.dmg);
  if (healSk){ sandbox._skillRanks[healSk.id] = healSk.maxRank || 1; sandbox._selectSkill(healSk); const hh = sandbox._getRenderedHeroHtml(); const hf = hh.slice(hh.indexOf("sk-stat sk-dmg-final"));
    check(`a heal card (${healSk.id}) has the Test bar and no hit tab`, hh.includes("sk-stat sk-dmg-final") && hf.startsWith("sk-stat sk-dmg-final has-test-bar") && !hf.includes("sk-dmg-hits-tab")); }
  else check("a heal card exists for the Test bar check", false);
}
console.log(`Verified ${checkedTestBtn} Test button checks.`);
// 3o. Over Swing's Over Power dep feeds the stat panel ATK: min(ceil(0.5 × Lv × ATK), 256 × Lv) (Bison.cs:24764);
// other cards are untouched.
let checkedOverPowerAtk = 0;
{
  const check = (label, ok, got) => { checkedOverPowerAtk++; if (!ok) { console.error(`[OVER POWER ATK ERROR] ${label}: got ${got}`); errorCount++; } };
  const atkEl = sandbox._statInputs.atk, deps = sandbox._depRanks, savedAtk = atkEl.value, savedOp = deps.overPower;
  const savedRole = atkEl.dataset.role;
  atkEl.dataset.role = "atk"; // the mock DOM has no data-role; statVal() keys on it
  const os = SKILLS.find(s => s.id === "bison_overSwing");
  sandbox._selectSkill(os);
  [[400, 0, 400], [400, 1, 600], [400, 2, 800], [600, 1, 856], [600, 2, 1112], [301, 1, 452]].forEach(([atk, lv, want]) => {
    atkEl.value = String(atk); deps.overPower = lv;
    const got = sandbox._statVal(atkEl);
    check(`ATK ${atk} + Over Power Lv${lv} = ${want}`, got === want, got);
  });
  sandbox._selectSkill(SKILLS.find(s => s.id === "bison_overPower"));
  atkEl.value = "400"; deps.overPower = 2;
  check("another card ignores the Over Swing dep", sandbox._statVal(atkEl) === 400, sandbox._statVal(atkEl));
  atkEl.value = savedAtk; atkEl.dataset.role = savedRole; if (savedOp === undefined) delete deps.overPower; else deps.overPower = savedOp;
}
console.log(`Verified ${checkedOverPowerAtk} Over Power stat panel checks.`);
// 3o-ii. atkCoeffProc shows its ATK term as "min~max" in both the talAdjust branch (Over Swing) and the
// flat-ATK branch (Charge Attack, dmg:"0"), only while its dep is on.
{
  const deps = sandbox._depRanks, saved = deps.bruteStrength;   // Raw Strength = Brute Strength rank 5
  const check = (label, ok) => { if (!ok) { console.error(`[ATK PROC RANGE ERROR] ${label}`); errorCount++; } };
  ["bison_overSwing", "bison_cAttack"].forEach(id => {
    const sk = SKILLS.find(s => s.id === id);
    sandbox._skillRanks[id] = sk.maxRank;
    deps.bruteStrength = 5; sandbox._selectSkill(sk);
    const on = sandbox._getRenderedHeroHtml();
    check(`${id} shows min~max ATK with Raw Strength on`, /\d+~\d+/.test(on) && on.includes("ATK / "));
    deps.bruteStrength = 4; sandbox._selectSkill(sk);
    check(`${id} shows a single ATK value with Raw Strength off`, !sandbox._getRenderedHeroHtml().includes("ATK / "));
  });
  if (saved === undefined) delete deps.bruteStrength; else deps.bruteStrength = saved;
}
console.log(`Verified ${checkedEffectProc} effectProc purple-mix checks.`);
// 3o. Wolf Combo (2026-09-24, GEMINI.md "critProc / effectDamageDep"): Feral Instinct coefficients, hit counts,
// gear crit rate (lckAdjust(12) Marshal / lckAdjust(18) Champion, x1.8), Dark Edge purple path + KO 0, and
// range-vs-simulator for every toggle combination (§3f only runs deps at default/off, where crit and Dark Edge are off).
let checkedWolfCombo = 0;
if (RUN_DAMAGE_CHECKS) {
  const ep = sandbox._effectProc, inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedWolfCombo++; if (!ok) { console.error(`[WOLF COMBO ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const sk = SKILLS.find(s => s.id === "wolf_nAttack");
  const IDS = ["wolfFeralInstinct", "wolfDarkEdgeOn", "wolfGearWeapon", "wolfGearEquip", "wolfKatana"];
  const savedDeps = IDS.map(id => [id, deps[id]]);
  const saved = { atk: inputs.atk.value, lck: inputs.lck.value };
  const setDeps = (o) => IDS.forEach(id => { deps[id] = o[id] || 0; });
  const select = (r) => { sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(sk); };
  check("Combo card has critProc, effectDamageDep and dmgControls", !!(sk && sk.critProc && sk.effectDamageDep && sk.dmgControls && sk.dmgControls.length === 5));
  // Coefficients: one 0-5 toggle, rank 5 = Feral 4 + Wild Heart = level 5 -> 0.75 / 0.6 / 0.9 (Wolf.cs:15144, :17386, :17717).
  setDeps({ wolfFeralInstinct: 5 }); select(3);
  const coeffs = sk.dmgGroups.map(g => Math.round(sandbox._resolveGroupAtkCoeff(sk, g) * 1000) / 1000).join(",");
  check("Feral 4 + Wild Heart coefficients", coeffs === "0.75,0.75,0.75,0.6,0.9", coeffs);
  setDeps({}); select(3);
  const c0 = sk.dmgGroups.map(g => Math.round(sandbox._resolveGroupAtkCoeff(sk, g) * 1000) / 1000).join(",");
  check("Feral off coefficients", c0 === "0.5,0.5,0.5,0.4,0.6", c0);
  // Hit counts 2 / 3 / 5.
  [2, 3, 5].forEach((want, i) => { select(i + 1); const got = sk.dmgGroups.reduce((a, g) => a + sandbox._resolveGroupHitCount(sk, g), 0); check(`rank ${i + 1} hit count`, got === want && sk.hitCount(i + 1) === want, got); });
  // KO 1, and 0 under Dark Edge.
  setDeps({}); select(3); check("KO 1 without Dark Edge", sandbox._getKOValue(sk, 3) === 1, sandbox._getKOValue(sk, 3));
  setDeps({ wolfDarkEdgeOn: 1 }); select(3); check("KO 0 with Dark Edge", sandbox._getKOValue(sk, 3) === 0, sandbox._getKOValue(sk, 3));
  // Crit rate and purple flag.
  inputs.atk.value = "200"; inputs.lck.value = "150";
  const rate = (o, n) => { setDeps(o); select(3); let c = 0, p = 0; for (let i = 0; i < n; i++) { sandbox._rollOneHit(sk, 3, undefined, false, 0); if (ep.lastCrit()) c++; if (ep.lastPurple()) p++; } return { c: c / n, p: p / n }; };
  check("no gear never crits", rate({}, 500).c === 0);
  // Gear crit by slot: weapon Marshal 5 / Champion 7, armor + helmet Marshal 7 / Champion 11 (Wolf.cs:14044-14188).
  [[{ wolfGearWeapon: 1 }, 5], [{ wolfGearEquip: 2 }, 11], [{ wolfGearWeapon: 1, wolfGearEquip: 1 }, 12], [{ wolfGearWeapon: 2, wolfGearEquip: 2 }, 18], [{ wolfGearWeapon: 1, wolfGearEquip: 2 }, 16]].forEach(([o, base]) => {
    setDeps(o); check(`crit base ${JSON.stringify(o)} = ${base}`, sandbox.wolfComboCritBase() === base, sandbox.wolfComboCritBase());
  });
  check("Dark Edge off is white", rate({}, 200).p === 0);
  check("Dark Edge on is always purple", rate({ wolfDarkEdgeOn: 1 }, 200).p === 1);
  check("Test total digits turn purple with Dark Edge", html.includes('const digitColor = selected.isHeal ? "g" : selected.isHate ? "h" : isShieldOnly(selected) ? "s" : (skillEffectDamageOn(selected) ? "p" : plainColor);'));
  check("Katana and the crit sword switch each other off", html.includes('const DEP_EXCLUSIVE = { wolfKatana: ["wolfGearWeapon"], wolfGearWeapon: ["wolfKatana"],'));
  // Katana (w_wlf59, Wolf.cs:15159-15175, :15990-16001, :16693, :17409, :17727): crit first, then floor(0.75x), stage 2 ceil(0.5x).
  // Hand-computed at ATK 200, LCK 0, Feral off: raw (int)(c x 200) = 100 / 100 / 100 / 80 / 120.
  {
    inputs.atk.value = "200"; inputs.lck.value = "0";
    const stageRanges = () => sk.dmgGroups.map(g => sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g)).map(r => r[0] + "-" + r[1]).join(",");
    setDeps({}); select(3);
    let got = stageRanges(); check("no Katana stages 100/100/100/80/120", got === "100-100,100-100,100-100,80-80,120-120", got);
    setDeps({ wolfKatana: 1 }); select(3);
    got = stageRanges(); check("Katana stages 75/50/75/60/90", got === "75-75,50-50,75-75,60-60,90-90", got);
    // Champion set + Katana: crit can happen, so the top is the crit case: floor(0.75 x floor(1.8 x 100)) = 135, stage 2 ceil(0.5 x 180) = 90.
    setDeps({ wolfKatana: 1, wolfGearEquip: 2 }); select(3);
    got = stageRanges(); check("Katana + Champion stage tops 135/90/135/108/162", got === "75-135,50-90,75-135,60-108,90-162", got);
    check("Katana keeps hat + armor crit only (Champion 11, Marshal 7)", sandbox.wolfComboCritBase() === 11, sandbox.wolfComboCritBase());
    setDeps({ wolfKatana: 1, wolfGearEquip: 1 }); check("Katana + Marshal crit base 7", sandbox.wolfComboCritBase() === 7, sandbox.wolfComboCritBase());
    setDeps({ wolfKatana: 1 }); select(3);
    let lo = Infinity, hi = -Infinity; for (let i = 0; i < 100; i++) { const x = sandbox._rollOneHit(sk, 3, undefined, false, 1); lo = Math.min(lo, x); hi = Math.max(hi, x); }
    check("Katana stage 2 Test roll never exceeds its raw-50 final range", lo >= 0 && hi <= sandbox._finalRangeForRange(sandbox._calcRangeFor(sk.dmgGroups[1].dmg, sandbox._resolveGroupAtkCoeff(sk, sk.dmgGroups[1]), sk.dmgGroups[1]))[1], `${lo}-${hi}`);
  }
  // Range vs simulator, every toggle combination, both stat profiles.
  [["0", "0"], ["200", "150"]].forEach(([atk, lck]) => {
    inputs.atk.value = atk; inputs.lck.value = lck;
    [0, 2, 4, 5].forEach(f => [0, 1].forEach(de => [{}, { wolfGearWeapon: 1, wolfGearEquip: 1 }, { wolfGearWeapon: 2, wolfGearEquip: 2 }, { wolfGearEquip: 2 }].forEach(gearO => [0, 1].forEach(kt => {
      const gear = Object.keys(gearO).map(k => k + gearO[k]).join("+");
      const o = { wolfFeralInstinct: f, wolfDarkEdgeOn: de, wolfKatana: kt, ...gearO };
      setDeps(o);
      for (let r = 1; r <= 3; r++) {
        select(r);
        sk.dmgGroups.forEach((g, gi) => {
          if (sandbox._resolveGroupHitCount(sk, g) === 0) return;
          const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g));
          let lo = Infinity, hi = -Infinity;
          for (let i = 0; i < 400; i++) { const x = sandbox._rollOneHit(sk, r, undefined, false, gi); lo = Math.min(lo, x); hi = Math.max(hi, x); }
          check(`range/sim rank ${r} ${g.label} feral ${f} de ${de} gear ${gear || "none"} katana ${kt} atk ${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
        });
      }
    }))));
  });
  inputs.atk.value = saved.atk; inputs.lck.value = saved.lck;
  savedDeps.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
}
console.log(`Verified ${checkedWolfCombo} Wolf Combo (Feral Instinct / gear crit / Dark Edge) checks.`);
// 3o-ii. Combo crit gear + Lv 60 weapon (2026-10-06), Cat / Monkey / Penguin / Bat: standard getCritPlus table, w_<cls>59
// floor(0.75x) before the crit (Monkey also KO +2), the weapon slot exclusive with the crit weapon, and range vs simulator.
// Cat Combo: the crit wraps only the normal raw hit, before Power; Hidden Blade's hit never crits (Cat.cs:16530, :16622, :16694).
let checkedComboGear = 0;
{
  const ep = sandbox._effectProc, inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedComboGear++; if (!ok) { console.error(`[COMBO GEAR ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const saved = { atk: inputs.atk.value, lck: inputs.lck.value };
  const ALL = ["catPower", "catComboHidden", "catComboCharge", "catComboNoChance", "earthForm"];
  const savedDeps = {};
  const select = (sk, r) => { sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(sk); };
  [["cat", "cat_nAttack", 3], ["mnk", "monkey_nAttack", 1], ["pgn", "penguin_nAttack", 2], ["bat", "bat_nAttack", 3]].forEach(([k, id, maxR]) => {
    const sk = SKILLS.find(x => x.id === id);
    const IDS = [k + "GearWeapon", k + "GearEquip", k + "W59", ...ALL];
    IDS.forEach(d => { if (!(d in savedDeps)) savedDeps[d] = deps[d]; });
    const setDeps = (o) => IDS.forEach(d => { deps[d] = o[d] || 0; });
    check(`${id} has critProc.pre, lckProc and the 3 gear controls`, !!(sk && sk.critProc && sk.critProc.pre && sk.lckProc && sk.dmgControls && sk.dmgControls.map(d => d.id).join().includes(IDS.slice(0, 3).join())));
    check(`${id}: Lv 60 weapon and crit weapon switch each other off`, html.includes(`${k}W59: ["${k}GearWeapon"], ${k}GearWeapon: ["${k}W59"]`));
    [[{}, 0], [{ [k + "GearWeapon"]: 1 }, 5], [{ [k + "GearWeapon"]: 2 }, 7], [{ [k + "GearEquip"]: 1 }, 7], [{ [k + "GearEquip"]: 2 }, 11], [{ [k + "GearWeapon"]: 2, [k + "GearEquip"]: 2 }, 18], [{ [k + "W59"]: 1, [k + "GearEquip"]: 2 }, 11]].forEach(([o, base]) => {
      setDeps(o); check(`${id} crit base ${JSON.stringify(o)} = ${base}`, sk.critProc.chance(1) === base, sk.critProc.chance(1));
    });
    // ATK 200, LCK 0: raw floor(0.5 x 200) = 100; weapon floor(0.75 x 100) = 75; crit top floor(1.8 x 75) = 135.
    inputs.atk.value = "200"; inputs.lck.value = "0";
    const g0 = sk.dmgGroups ? sk.dmgGroups[0] : undefined;
    const rng = () => { const r = g0 ? sandbox._calcRangeFor(g0.dmg, sandbox._resolveGroupAtkCoeff(sk, g0), g0) : sandbox._calcRangeFor(sk.dmg); return r[0] + "-" + r[1]; };
    [[{}, "100-100"], [{ [k + "W59"]: 1 }, "75-75"], [{ [k + "W59"]: 1, [k + "GearEquip"]: 2 }, "75-135"], [{ [k + "GearWeapon"]: 2, [k + "GearEquip"]: 2 }, "100-180"]].forEach(([o, want]) => {
      setDeps(o); select(sk, maxR); const got = rng(); check(`${id} raw range ${JSON.stringify(o)}`, got === want, got);
    });
    setDeps({ [k + "W59"]: 1 }); select(sk, maxR);
    check(`${id} formula shows the 0.75 weapon scale`, /0\.75/.test(sandbox._getRenderedHeroHtml()));
    if (k === "cat") {
      // Power Seven after the crit: floor(1.7 x 75) = 127, floor(1.7 x 135) = 229.
      setDeps({ catW59: 1, catGearEquip: 2, catPower: 4 }); select(sk, 3); let got = rng(); check("Cat: Power multiplies after the crit", got === "127-229", got);
      // Charge +10/level after Power, never crit-multiplied: 127+50 / 229+50.
      setDeps({ catW59: 1, catGearEquip: 2, catPower: 4, catComboCharge: 4 }); select(sk, 3); got = rng(); check("Cat: Charge adds after the crit", got === "177-279", got);
      setDeps({ catGearWeapon: 2, catGearEquip: 2, catComboHidden: 1 }); select(sk, 3);
      let c = 0; for (let i = 0; i < 300; i++) { sandbox._rollOneHit(sk, 3, undefined, false, 0); if (ep.lastCrit()) c++; }
      check("Cat: Hidden Blade's hit never crits", c === 0, c);
    }
    if (k === "mnk") {
      [[{}, 1], [{ earthForm: 1 }, 2], [{ mnkW59: 1 }, 3], [{ earthForm: 1, mnkW59: 1 }, 4]].forEach(([o, want]) => {
        setDeps(o); select(sk, 1); check(`Monkey Combo KO ${JSON.stringify(o)}`, sandbox._getKOValue(sk, 1) === want, sandbox._getKOValue(sk, 1));
      });
    }
    // range vs simulator
    [["0", "0"], ["200", "150"]].forEach(([atk, lck]) => {
      inputs.atk.value = atk; inputs.lck.value = lck;
      [{}, { [k + "W59"]: 1 }, { [k + "GearWeapon"]: 2, [k + "GearEquip"]: 2 }, { [k + "W59"]: 1, [k + "GearEquip"]: 1 }, ...(k === "cat" ? [{ catW59: 1, catGearEquip: 2, catPower: 4, catComboCharge: 2 }, { catGearEquip: 2, catComboHidden: 3 }] : [])].forEach(o => {
        setDeps(o);
        for (let r = 1; r <= maxR; r++) {
          select(sk, r);
          (sk.dmgGroups || [undefined]).forEach((g, gi) => {
            if (g && sandbox._resolveGroupHitCount(sk, g) === 0) return;
            const fin = sandbox._finalRangeForRange(g ? sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g) : sandbox._calcRangeFor(sk.dmg));
            let lo = Infinity, hi = -Infinity;
            for (let i = 0; i < 300; i++) { const x = sandbox._rollOneHit(sk, r, undefined, false, g ? gi : undefined); lo = Math.min(lo, x); hi = Math.max(hi, x); }
            check(`${id} range/sim rank ${r} group ${gi} ${JSON.stringify(o)} atk ${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
          });
        }
      });
    });
  });
  inputs.atk.value = saved.atk; inputs.lck.value = saved.lck;
  Object.entries(savedDeps).forEach(([d, v]) => { if (v === undefined) delete deps[d]; else deps[d] = v; });
}
console.log(`Verified ${checkedComboGear} Combo crit gear / Lv 60 weapon checks (Cat, Monkey, Penguin, Bat).`);
// 3o-ii-b. Lv 60 weapons of Bison / Panda / Whale / Mole / Sheep Combo (2026-10-06) and Bat Combo's Shadow Illusion clones.
// Before the crit: Whale Star Spear, Mole Double Cannon, Sheep Holy Orb; after the crit: Bison Vacuum Hammer, Panda Force Gauntlet
// (Panda.cs:15338, Bison.cs:14776-14787). Clones: (int)(0.5 ATK), no Homing Wand cut, crit only with Illusion Effect, damageMod 0.5-1.
let checkedComboW59 = 0;
{
  const inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedComboW59++; if (!ok) { console.error(`[COMBO W59 ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const saved = { atk: inputs.atk.value, lck: inputs.lck.value }, savedDeps = {};
  const touch = (ids) => ids.forEach(d => { if (!(d in savedDeps)) savedDeps[d] = deps[d]; });
  const select = (sk, r) => { sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(sk); };
  const rawOf = (sk, gi) => { const g = sk.dmgGroups ? sk.dmgGroups[gi] : undefined; const r = g ? sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g) : sandbox._calcRangeFor(sk.dmg); return r[0] + "-" + r[1]; };
  const sweep = (sk, maxR, tag) => {
    [["0", "0"], ["200", "150"]].forEach(([atk, lck]) => {
      inputs.atk.value = atk; inputs.lck.value = lck;
      for (let r = 1; r <= maxR; r++) {
        select(sk, r);
        (sk.dmgGroups || [undefined]).forEach((g, gi) => {
          if (g && sandbox._resolveGroupHitCount(sk, g) === 0) return;
          const fin = sandbox._finalRangeForRange(g ? sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g) : sandbox._calcRangeFor(sk.dmg));
          let lo = Infinity, hi = -Infinity;
          for (let i = 0; i < 300; i++) { const x = sandbox._rollOneHit(sk, r, undefined, false, g ? gi : undefined); lo = Math.min(lo, x); hi = Math.max(hi, x); }
          check(`${sk.id} range/sim ${tag} rank ${r} group ${gi} atk ${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
        });
      }
    });
  };
  // [card, w59 id, crit weapon id, crit equip id, maxRank, raw at ATK 200 / LCK 0: off, weapon on, weapon on + Champion armor]
  [["whale_nAttack", "whlW59", "whaleGearWeapon", "whaleGearEquip", 2, "100-100", "75-75", "75-135"],
   ["mole_nAttack", "molW59", "moleGearWeapon", "moleGearEquip", 4, "100-100", "75-75", "75-135"],
   ["sheep_nAttack", "shpW59", "sheepGearWeapon", "sheepGearEquip", 2, "100-100", "75-75", "75-135"],
   ["bison_nAttack", "bsnW59", "bisonGearWeapon", "bisonGearEquip", 4, "100-100", "75-75", "75-135"],
   ["panda_nAttack", "pndW59", "pandaGearWeapon", "pandaGearEquip", 4, "40-40", "30-30", "30-54"]].forEach(([id, w, gw, ge, maxR, off, on, onCrit]) => {
    const sk = SKILLS.find(x => x.id === id);
    const ids = [w, gw, ge, "bruteStrength", "bisonSpinForce", "addedSwing", "colossalWeapon", "focusedSpirit", "auraBlast", "cannonExpert", "wallPuncture", "overPride", "improvedSwing"];
    touch(ids);
    const setDeps = (o) => ids.forEach(d => { deps[d] = o[d] || 0; });
    check(`${id} shows the ${w} toggle`, !!(sk.dmgControls && sk.dmgControls.some(d => d.id === w)));
    check(`${id}: ${w} and the crit weapon switch each other off`, html.includes(`${w}: ["${gw}"]`) && html.includes(`${gw}: ["${w}"]`));
    inputs.atk.value = "200"; inputs.lck.value = "0";
    [[{}, off], [{ [w]: 1 }, on], [{ [w]: 1, [ge]: 2 }, onCrit]].forEach(([o, want]) => { setDeps(o); select(sk, 1); const got = rawOf(sk, 0); check(`${id} raw ${JSON.stringify(o)}`, got === want, got); });
    setDeps({ [w]: 1, [ge]: 2 }); sweep(sk, maxR, "weapon+armor");
    setDeps({});
  });
  { // Panda Aura Blast keeps its own formula under Force Gauntlet: 1.25 x 200 = 250.
    const sk = SKILLS.find(x => x.id === "panda_nAttack"); touch(["pndW59", "auraBlast"]);
    deps.pndW59 = 1; deps.auraBlast = 1; inputs.atk.value = "200"; inputs.lck.value = "0"; select(sk, 4);
    const gi = sk.dmgGroups.findIndex(g => g.aura); check("Panda Aura Blast not cut by Force Gauntlet", rawOf(sk, gi) === "250-250", rawOf(sk, gi));
    deps.pndW59 = 0; deps.auraBlast = 0;
  }
  { // Bat clones
    const sk = SKILLS.find(x => x.id === "bat_nAttack");
    const ids = ["shadowIllusion", "illusionEffect", "batGearWeapon", "batGearEquip", "batW59"]; touch(ids);
    const setDeps = (o) => ids.forEach(d => { deps[d] = o[d] || 0; });
    [[0, 3, 5], [1, 3, 10], [2, 3, 15], [4, 1, 6]].forEach(([si, r, want]) => { setDeps({ shadowIllusion: si }); select(sk, r); check(`Bat Combo hits, Shadow Illusion ${si} rank ${r}`, sk.hitCount(r) === want, sk.hitCount(r)); });
    inputs.atk.value = "200"; inputs.lck.value = "0";
    setDeps({ shadowIllusion: 4, batW59: 1, batGearEquip: 2 }); select(sk, 3);
    check("Bat hit: Homing Wand then crit", rawOf(sk, 0) === "75-135", rawOf(sk, 0));
    check("clone hit: no Homing Wand cut, no crit without Illusion Effect", rawOf(sk, 1) === "100-100", rawOf(sk, 1));
    setDeps({ shadowIllusion: 4, batW59: 1, batGearEquip: 2, illusionEffect: 1 }); select(sk, 3);
    check("clone hit crits with Illusion Effect", rawOf(sk, 1) === "100-180", rawOf(sk, 1));
    [1, 2, 3, 4].forEach(si => { setDeps({ shadowIllusion: si }); check(`clone damageMod at Shadow Illusion ${si}`, sk.dmgGroups[1].damageMod() === [0, 0.5, 0.5, 0.75, 1][si], sk.dmgGroups[1].damageMod()); });
    // damageMod reaches Final: a 0.5 clone ends below the Bat's own hit at the same raw value.
    setDeps({ shadowIllusion: 1 }); select(sk, 3);
    const fb = sandbox._finalRangeForRange(sandbox._calcRangeFor("0", 0.5, sk.dmgGroups[0])), fc = sandbox._finalRangeForRange(sandbox._calcRangeFor("0", 0.5, sk.dmgGroups[1]));
    check("clone Final uses its own damageMod", fc[1] < fb[1], `${fc} vs ${fb}`);
    [{ shadowIllusion: 4 }, { shadowIllusion: 2, illusionEffect: 1, batGearWeapon: 2, batGearEquip: 2 }, { shadowIllusion: 3, batW59: 1, batGearEquip: 1 }].forEach(o => { setDeps(o); sweep(sk, 3, JSON.stringify(o)); });
  }
  inputs.atk.value = saved.atk; inputs.lck.value = saved.lck;
  Object.entries(savedDeps).forEach(([d, v]) => { if (v === undefined) delete deps[d]; else deps[d] = v; });
}
console.log(`Verified ${checkedComboW59} Combo Lv 60 weapon (Bison, Panda, Whale, Mole, Sheep) and Bat Shadow Illusion checks.`);
// 3o-iii. Bison Combo (2026-09-29): stage/spin/Added Swing hit counts (groupVariant), per-stage Raw Strength
// coefficients, inclusive spin/Over Pride chances, Over Pride KO, the gear crit chip, and range vs simulator.
let checkedBisonCombo = 0;
{
  const inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedBisonCombo++; if (!ok) { console.error(`[BISON COMBO ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const sk = SKILLS.find(s => s.id === "bison_nAttack");
  const IDS = ["bruteStrength", "improvedSwing", "addedSwing", "overPride", "bisonSpinForce", "bisonGearWeapon", "bisonGearEquip"];
  const savedDeps = IDS.map(id => [id, deps[id]]), saved = { atk: inputs.atk.value, lck: inputs.lck.value };
  const setDeps = (o) => IDS.forEach(id => { deps[id] = o[id] || 0; });
  const select = (r) => { sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(sk); };
  const hits = () => sk.dmgGroups.reduce((a, g) => a + sandbox._resolveGroupHitCount(sk, g), 0);
  // Hit counts (Bison.cs:4858-5067): 2 / 3, spin replaces stage 3 with 2 hits, Added Swing +2 from rank 2.
  [[1, {}, 2], [2, {}, 3], [4, {}, 3], [4, { bisonSpinForce: 1 }, 4], [2, { bisonSpinForce: 1 }, 3], [4, { bisonSpinForce: 1, addedSwing: 1 }, 6], [2, { addedSwing: 1 }, 5]].forEach(([r, o, want]) => {
    setDeps(o); select(r);
    check(`rank ${r} ${JSON.stringify(o)} hit count`, hits() === want && sk.hitCount(r) === want, `${hits()} / ${sk.hitCount(r)}`);
  });
  // Coefficients with Brute Strength 4, normal and Raw Strength (x5 Brute level).
  setDeps({ bruteStrength: 4, bisonSpinForce: 1, addedSwing: 1 }); select(4);
  const coef = sk.dmgGroups.map(g => +sandbox._resolveGroupAtkCoeff(sk, g).toFixed(3)).join(",");
  const proc = sk.dmgGroups.map(g => +g.atkCoeffProc().toFixed(3)).join(",");
  check("Brute 4 coefficients", coef === "0.6,0.6,0.72,0.48,0.6,0.48,0.6", coef);
  check("Raw Strength coefficients", proc === "1,1,1.2,0.8,1,0.8,1", proc);
  // Chances: spin and Over Pride roll Random(0,100) <= lckAdjust(n), so +1.
  inputs.lck.value = "0";
  setDeps({ improvedSwing: 3 });
  check("spin chance rank 4 + Improved Swing 3", sandbox.groupVariantChance(sk, 4, 0) === sandbox.lckAdjustChance(55, 0) + 1, sandbox.groupVariantChance(sk, 4, 0));
  check("no spin below rank 3", sandbox.groupVariantChance(sk, 2, 0) === 0);
  check("Over Pride chip is lckAdjust(20)+1", sk.tertiaryLckProc.calc(20, 0) === sandbox.lckAdjustChance(20, 0) + 1);
  // KO: Over Pride adds its level on success; the spin's first hit has no base KO.
  setDeps({ overPride: 4, bisonSpinForce: 1 }); select(4);
  check("Over Pride 4 KO", sandbox._getKOValue({ ...sk, ko: sk.dmgGroups[0].ko }, 4) === "1–5" && sandbox._getKOValue({ ...sk, ko: sk.dmgGroups[3].ko }, 4) === "0–4");
  // Crit chip only with gear; forced spin shows the spin rows.
  setDeps({}); select(4);
  check("no crit chip without gear", !sandbox._getRenderedHeroHtml().includes("โอกาส Critical"));
  setDeps({ bisonGearWeapon: 2, bisonGearEquip: 2 }); select(4);
  check("crit chip with Champion gear", sandbox._getRenderedHeroHtml().includes("โอกาส Critical") && sk.critProc.chance() === 18);
  // Range vs simulator for every stage including the spin and Added Swing, with Raw Strength and gear on.
  [["0", "0"], ["200", "150"]].forEach(([atk, lck]) => {
    inputs.atk.value = atk; inputs.lck.value = lck;
    [{}, { bruteStrength: 5, bisonGearWeapon: 2, bisonGearEquip: 2 }].forEach(base => {
      setDeps({ ...base, bisonSpinForce: 1, addedSwing: 1 }); select(4);
      sk.dmgGroups.forEach((g, gi) => {
        if (sandbox._resolveGroupHitCount(sk, g) === 0) return;
        const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g));
        let lo = Infinity, hi = -Infinity;
        for (let i = 0; i < 400; i++) { const x = sandbox._rollOneHit(sk, 4, undefined, false, gi); lo = Math.min(lo, x); hi = Math.max(hi, x); }
        check(`range/sim ${g.label} ${JSON.stringify(base)} atk ${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
      });
    });
  });
  inputs.atk.value = saved.atk; inputs.lck.value = saved.lck;
  savedDeps.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
}
console.log(`Verified ${checkedBisonCombo} Bison Combo checks.`);
// 3o-iv. Rabbit Combo / Charge Attack (2026-09-29, GEMINI.md "rawModel"): exact raw damage against values worked out by hand from
// Rabbit.cs (Combo :17409-17690, ricochet :18259, shotgun :36260-36332, Charge Attack :19413-19523), gear crit (:16471), header inputs,
// DEP_EXCLUSIVE, the crit rate, and range vs simulator over every toggle.
let checkedRabbitShot = 0;
if (RUN_DAMAGE_CHECKS) {
  const inputs = sandbox._statInputs, deps = sandbox._depRanks, rb = sandbox._rabbit, ep = sandbox._effectProc;
  const check = (label, ok, got) => { checkedRabbitShot++; if (!ok) { console.error(`[RABBIT SHOT ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const combo = SKILLS.find(s => s.id === "rabbit_nAttack"), charge = SKILLS.find(s => s.id === "rabbit_cAttack");
  const IDS = ["rabHyperShot", "rabBouncing", "rabShotgun", "rabW59", "rabWeapon", "rabEquip", "rabDeadShot", "rabHeadShot", "rabComboLv", "rabExtravagance"];
  const savedDeps = IDS.map(id => [id, deps[id]]), savedIn = { atk: inputs.atk.value, lck: inputs.lck.value };
  const savedDist = [rb.getDistance("combo"), rb.getDistance("charge")], savedAim = rb.getAim();
  const setDeps = (o) => IDS.forEach(id => { deps[id] = o[id] || 0; });
  const select = (sk, r) => { sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(sk); };
  check("both cards use rawModel with header inputs and no atkCoeff", [combo, charge].every(s => s.rawModel && s.rabbitShotInputs && s.atkCoeff === undefined && s.hitCount() === 1));
  check("only Combo carries a crit base", typeof combo.rawModel.critBase === "function" && charge.rawModel.critBase === undefined);
  // TTO removed the LCK roll from talAdjust/dmgAdjust/defAdjust, so every damaging Rabbit card must offer the TTO toggle (usesTdlRoll).
  const dmgCards = SKILLS.filter(s => s.class === "Rabbit" && !s.effectDamage && !s.penetrating && (s.rawModel || s.atkCoeff !== undefined || (s.dmg && s.dmg !== "0") || s.dmgGroups));
  check("every damaging Rabbit card offers the TTO toggle", dmgCards.length >= 12 && dmgCards.every(s => sandbox._usesTdlRoll(s)), dmgCards.filter(s => !sandbox._usesTdlRoll(s)).map(s => s.id).join(","));
  check("Combo and Charge Attack offer TTO", sandbox._usesTdlRoll(combo) && sandbox._usesTdlRoll(charge));
  // ---- Combo goldens: [label, rank, ATK, LV, deps, distance, crit, plain]
  const H4 = { rabHyperShot: 4 };
  [
    ["0.5 ATK, no deps", 1, 128, 100, {}, 16, 64, 0],
    ["odd ATK truncates", 1, 127, 100, {}, 16, 63, 0],
    ["ATK 0 leaves only Hyper Shot (rank 1 reaches 21 m: 5 x 4)", 1, 0, 100, H4, 30, 20, 0],
    ["Hyper 4 rank 3 at 26 m: (26-16) x 4", 3, 128, 100, H4, 26, 104, 0],
    ["Hyper 4 below 16 m gives nothing", 3, 128, 100, H4, 10, 64, 0],
    ["Hyper 4 exactly 16 m gives nothing", 3, 128, 100, H4, 16, 64, 0],
    ["Snipe Mastery counts from 0 m: floor(26 x 4)", 3, 128, 100, { rabHyperShot: 5 }, 26, 168, 0],
    ["Snipe Mastery at 5.5 m: floor(5.5 x 4)", 3, 128, 100, { rabHyperShot: 5 }, 5.5, 86, 0],
    ["Hyper 2 rank 4 at the 36 m limit", 4, 128, 100, { rabHyperShot: 2 }, 36, 104, 0],
    ["distance clamps to the rank range (rank 2 = 26 m)", 2, 128, 100, { rabHyperShot: 3 }, 100, 94, 0],
    ["no Hyper Shot learned", 3, 128, 100, {}, 30, 64, 0],
    ["w_rab59 floors 0.75 x floor(0.5 ATK)", 1, 128, 100, { rabW59: 1 }, 16, 48, 0],
    ["w_rab59 with odd base: floor(0.75 x 63)", 1, 127, 100, { rabW59: 1 }, 16, 47, 0],
    ["w_rab59 multiplies the base only, Hyper Shot added after", 4, 128, 100, { ...H4, rabW59: 1 }, 36, 128, 0],
    ["Bouncing Bullet adds floor(0.5 Lv), Lv 100", 1, 128, 100, { rabBouncing: 1 }, 16, 114, 0],
    ["Bouncing Bullet Lv 101 floors 50.5", 1, 128, 101, { rabBouncing: 1 }, 16, 114, 0],
    ["Bouncing Bullet Lv 151", 1, 128, 151, { rabBouncing: 1 }, 16, 139, 0],
    ["Bouncing Bullet extends the range to 20 + 5 x rank", 1, 128, 100, { ...H4, rabBouncing: 1 }, 25, 150, 0],
    ["Bouncing Bullet + w_rab59 + Snipe", 2, 128, 100, { rabHyperShot: 5, rabBouncing: 1, rabW59: 1 }, 20, 48 + 50 + 80, 0],
    ["shotgun: reversed Hyper Shot at 4 m, crit part is the base only", 1, 128, 100, { ...H4, rabShotgun: 1 }, 4, 64, 48],
    ["shotgun + Snipe Mastery x1.5", 1, 128, 100, { rabHyperShot: 5, rabShotgun: 1 }, 4, 64, 72],
    ["shotgun at 0 m", 1, 128, 100, { ...H4, rabShotgun: 1 }, 0, 64, 64],
    ["shotgun at 0 m + Snipe", 1, 128, 100, { rabHyperShot: 5, rabShotgun: 1 }, 0, 64, 96],
    ["shotgun reaches 13 m at most (bonus 12)", 4, 128, 100, { ...H4, rabShotgun: 1 }, 20, 64, 12],
    ["shotgun ignores w_rab59 and Bouncing Bullet", 1, 128, 100, { ...H4, rabShotgun: 1, rabW59: 1, rabBouncing: 1 }, 4, 64, 48],
    ["shotgun without Hyper Shot", 1, 128, 100, { rabShotgun: 1 }, 4, 64, 0],
  ].forEach(([label, rank, atk, lv, o, dist, crit, plain]) => {
    setDeps(o); rb.setDistance("combo", dist);
    const p = sandbox.rabbitComboParts(rank, atk, lv);
    check(`Combo ${label}`, p.crit === crit && p.plain === plain, `${p.crit}/${p.plain} want ${crit}/${plain}`);
  });
  // ---- Charge Attack goldens: [label, lv, ATK, deps, distance, aim, raw]
  const CH = (o) => ({ rabHyperShot: 0, rabDeadShot: 0, rabHeadShot: 0, rabComboLv: 4, ...o });
  [
    ["lv 1 body", 1, 128, CH({}), 16, 0, 102],
    ["lv 3 body: 0.5 x 128 + int(0.3 x 3 x 128) = 64 + 115", 3, 128, CH({}), 16, 0, 179],
    ["Hyper 4 at 30 m: (30-16) x 4", 3, 128, CH({ rabHyperShot: 4 }), 30, 0, 235],
    ["head shot adds the charge term again", 3, 128, CH({ rabHeadShot: 1 }), 16, 0, 294],
    ["head shot + Hyper", 3, 128, CH({ rabHeadShot: 1, rabHyperShot: 4 }), 30, 0, 350],
    ["Dead Shot 4 s multiplies x3 (Hyper not multiplied)", 3, 128, CH({ rabHeadShot: 1, rabDeadShot: 1, rabHyperShot: 4 }), 30, 4, 882 + 56],
    ["Dead Shot 2 s multiplies x2", 3, 128, CH({ rabHeadShot: 1, rabDeadShot: 1 }), 16, 2, 588],
    ["Dead Shot 1.3 s: float32 multiplier, floor(1.65 x 294)", 3, 128, CH({ rabHeadShot: 1, rabDeadShot: 1 }), 16, 1.3, 485],
    ["Dead Shot 0 s does nothing", 3, 128, CH({ rabHeadShot: 1, rabDeadShot: 1 }), 16, 0, 294],
    ["Dead Shot needs a head shot", 3, 128, CH({ rabDeadShot: 1 }), 16, 4, 179],
    ["range with Combo 0 is 20 m: (20-16) x 4", 3, 128, CH({ rabHyperShot: 4, rabComboLv: 0 }), 40, 0, 179 + 16],
    ["range with Combo 4 is 40 m: (40-16) x 4", 3, 128, CH({ rabHyperShot: 4, rabComboLv: 4 }), 40, 0, 179 + 96],
    ["Snipe Mastery (Hyper Shot rank 5) does nothing on Charge Attack: same as rank 4", 3, 128, CH({ rabHyperShot: 5 }), 30, 0, 235],
    ["ATK 0", 2, 0, CH({}), 16, 0, 0],
  ].forEach(([label, lv, atk, o, dist, aim, want]) => {
    setDeps(o); rb.setDistance("charge", dist); rb.setAim(aim);
    const p = sandbox.rabbitChargeParts(lv, atk);
    check(`Charge Attack ${label}`, p.crit === want && p.plain === 0, `${p.crit} want ${want}`);
  });
  // ---- Gear crit base: weapon (+5 / +7) + armor and hat (+7 / +11)
  [[{}, 0], [{ rabWeapon: 1 }, 5], [{ rabWeapon: 2 }, 7], [{ rabEquip: 1 }, 7], [{ rabEquip: 2 }, 11], [{ rabWeapon: 1, rabEquip: 1 }, 12], [{ rabWeapon: 2, rabEquip: 2 }, 18], [{ rabWeapon: 2, rabEquip: 1 }, 14], [{ rabEquip: 2, rabW59: 1 }, 11], [{ rabEquip: 1, rabShotgun: 1 }, 7], [{ rabW59: 1 }, 0], [{ rabShotgun: 1 }, 0]
  ].forEach(([o, want]) => { setDeps(o); check(`crit base ${JSON.stringify(o)}`, sandbox.rabbitCritBase() === want, sandbox.rabbitCritBase()); });
  // ---- Exclusivity: one weapon slot, one armor set, shotgun needs a shotgun weapon
  const dx = rb.depExclusive;
  const sym = Object.keys(dx).filter(k => /^rab/.test(k)).every(a => dx[a].every(b => (dx[b] || []).includes(a)));
  check("Rabbit DEP_EXCLUSIVE is symmetric", sym);
  check("the weapon slot, Gatling Gun and the shotgun are mutually exclusive", [["rabWeapon", ["rabW59", "rabShotgun"]], ["rabW59", ["rabWeapon", "rabShotgun"]], ["rabShotgun", ["rabW59", "rabWeapon"]]].every(([a, list]) => list.every(b => dx[a].includes(b))));
  check("crit equipment (armor + hat) has no exclusivity: it works with the Gatling Gun and the shotgun", !dx.rabEquip && !dx.rabW59.includes("rabEquip") && !dx.rabShotgun.includes("rabEquip") && !dx.rabWeapon.includes("rabEquip"));
  // ---- Crit rate, and crit only on Combo
  inputs.atk.value = "200"; inputs.lck.value = "150";
  const rate = (sk, r, n) => { select(sk, r); let c = 0; for (let i = 0; i < n; i++) { sandbox._rollOneHit(sk, r, undefined, false); if (ep.lastCrit()) c++; } return c / n; };
  setDeps({}); check("Combo never crits without gear", rate(combo, 1, 400) === 0);
  [[{ rabWeapon: 1, rabEquip: 1 }, 12], [{ rabWeapon: 2, rabEquip: 2 }, 18], [{ rabEquip: 2, rabW59: 1 }, 11]].forEach(([o, base]) => {
    setDeps(o);
    check("Charge Attack never crits even with the full set", rate(charge, 3, 400) === 0);
  });
  setDeps({});
  // ---- Header inputs and chips in the rendered card
  select(combo, 3); const heroC = sandbox._getRenderedHeroHtml();
  check("Combo shows the distance box but no aim slider", heroC.includes('data-role="rabbit-distance"') && !heroC.includes('data-role="rabbit-aim"'));
  check("Combo lists its dependencies", ["rabBouncing", "rabHyperShot", "rabExtravagance", "rabWeapon", "rabEquip", "rabW59", "rabShotgun"].every(id => heroC.includes(`data-dep-id="${id}"`)));
  // ---- Dependency order on Combo and the merged Hyper Shot + Snipe Mastery dep
  const strip = heroC.match(/data-dep-id="(rab[A-Za-z0-9]+)"/g).map(s => s.slice(13, -1));
  // Skill toggles by internal ID (Hyper Shot #131, Customized Shotgun #353, Bouncing Bullet #401, Extravagance #443), then gear and the Gatling Gun.
  check("Combo dependency strip order: Hyper+Snipe, shotgun, Bouncing, Extravagance, gear, Gatling Gun", ["rabHyperShot", "rabShotgun", "rabBouncing", "rabExtravagance", "rabWeapon", "rabEquip", "rabW59"].join() === [...new Set(strip)].join(), [...new Set(strip)].join());
  check("Customized Shotgun is a plain on/off toggle (rank 1 and 2 only change the hit box)", combo.dmgControls.find(d => d.id === "rabShotgun").maxRank === 1);
  check("Hyper Shot is one 0..5 dep whose rank-5 icon exists (rank 5 = Snipe Mastery)", combo.dmgControls[1].id === "rabHyperShot" && combo.dmgControls[1].maxRank === 5 && !!sandbox.SKILL_ICONS.rabbit_hyperShot5 && [1, 2, 3, 4].every(n => sandbox.SKILL_ICONS["rabbit_hyperShot" + n]));
  check("no separate Snipe Mastery dependency remains", !/rabSnipe|RABBIT_SNIPE_DEP/.test(html));
  check("concise dependency names", combo.dmgControls[1].label === "Hyper Shot / Snipe Mastery" && combo.dmgControls[3].label === "Crit Weapon" && combo.dmgControls[4].label === "Crit Armor + Helmet" && combo.dmgControls[5].id === "rabW59" && combo.dmgControls[5].label === "Gatling Gun" && combo.dmgControls[6].label === "Customized Shotgun");
  check("no crit chip without gear", !heroC.includes("โอกาส Critical"));
  setDeps({ rabEquip: 2, rabW59: 1 }); select(combo, 3);
  check("crit chip with gear", sandbox._getRenderedHeroHtml().includes("โอกาส Critical"));
  setDeps({}); select(charge, 3); const heroK = sandbox._getRenderedHeroHtml();
  check("Charge Attack shows the distance box and the aim slider (idle without a head shot)", heroK.includes('data-role="rabbit-distance"') && heroK.includes('data-role="rabbit-aim"') && heroK.includes("sk-rabbit-aim is-idle"));
  check("Charge Attack lists its dependencies", ["rabComboLv", "rabHyperShot", "rabHeadShot", "rabDeadShot", "rabExtravagance"].every(id => heroK.includes(`data-dep-id="${id}"`)));
  check("Charge Attack has no crit chip", !heroK.includes("โอกาส Critical"));
  setDeps({ rabHeadShot: 1, rabDeadShot: 1 }); select(charge, 3);
  check("aim slider is active with head shot and Dead Shot", !sandbox._getRenderedHeroHtml().includes("sk-rabbit-aim is-idle"));
  setDeps({ rabHyperShot: 4 }); rb.setDistance("combo", 26); select(combo, 3);
  check("formula shows the Hyper Shot term with its distance", sandbox._getRenderedHeroHtml().includes("Hyper Shot 26m"));
  // ---- Extravagance: a skill dependency on every ATK-based Rabbit skill (flag `extravagance`), not a Buff popup entry
  const EXTRA_CARDS = ["nAttack", "cAttack", "maimShot", "bounce", "gilShot", "fourShot", "circleShot", "shootingArray", "tenShot"].map(k => SKILLS.find(s => s.id === "rabbit_" + k));
  check("Extravagance is flagged on the nine ATK-based offensive skills and nowhere else in Rabbit, plus the Reborn-only Thousand Shot and Bullet Rain", EXTRA_CARDS.every(s => s && s.extravagance === true) && SKILLS.filter(s => s.class === "Rabbit" && s.extravagance && !s.onlyServer).length === 9 && SKILLS.filter(s => s.class === "Rabbit" && s.extravagance && s.onlyServer).map(s => s.id).sort().join() === "rabbit_bulletRain,rabbit_thousandShot");
  check("Extravagance links reciprocally with each of them", EXTRA_CARDS.every(s => (s.compatSkills || []).includes("rabbit_extravagance")) && EXTRA_CARDS.every(s => SKILLS.find(x => x.id === "rabbit_extravagance").compatSkills.includes(s.id)));
  check("the Buff popup no longer lists Extravagance", !/extravagance512/.test(html));
  const savedAtkRole = inputs.atk.dataset.role; inputs.atk.dataset.role = "atk";   // statBonus() keys off the input data-role
  setDeps({}); inputs.atk.value = "128";
  check("Extravagance off leaves ATK alone", EXTRA_CARDS.every(s => { select(s, 1); return sandbox._statVal(inputs.atk) === 128; }));
  setDeps({ rabExtravagance: 1 });
  check("Extravagance on adds its ATK on every flagged card", EXTRA_CARDS.every(s => { select(s, 1); return sandbox._statVal(inputs.atk) === 640; }), EXTRA_CARDS.map(s => { select(s, 1); return sandbox._statVal(inputs.atk); }).join(","));
  select(SKILLS.find(s => s.id === "rabbit_gorgonShot"), 1);
  check("Extravagance does not touch an unflagged card", sandbox._statVal(inputs.atk) === 128);
  select(SKILLS.find(s => s.id === "rabbit_extravagance"), 1);
  check("Extravagance does not buff itself", sandbox._statVal(inputs.atk) === 128);
  setDeps({ rabExtravagance: 1 }); rb.setDistance("combo", 16); select(combo, 1);
  check("Combo raw uses the boosted ATK: floor(0.5 x 640) = 320", sandbox._statVal(inputs.atk) === 640 && sandbox.rabbitComboParts(1, sandbox._statVal(inputs.atk), 100).crit === 320);
  check("Extravagance has no input box, it is always the 512 cap", !sandbox._getRenderedHeroHtml().includes('data-role="rabbit-extra-atk"'));
  setDeps({}); select(combo, 1);
  check("no Extravagance ATK while the dep is off", sandbox._statVal(inputs.atk) === 128);
  inputs.atk.value = "128";
  if (savedAtkRole === undefined) delete inputs.atk.dataset.role; else inputs.atk.dataset.role = savedAtkRole;
  // ---- Stat glow: rawModel declares ATK, and LV only for a live Bouncing Bullet
  setDeps({}); check("Combo glows ATK, not LV, by default", sandbox.getUsedPlayerStatKeys(combo).has("atk") && !sandbox.getUsedPlayerStatKeys(combo).has("lv"));
  setDeps({ rabBouncing: 1 }); check("Bouncing Bullet makes LV glow", sandbox.getUsedPlayerStatKeys(combo).has("lv"));
  setDeps({ rabBouncing: 1, rabShotgun: 1 }); check("shotgun mode drops LV again", !sandbox.getUsedPlayerStatKeys(combo).has("lv"));
  setDeps({}); check("Charge Attack glows ATK", sandbox.getUsedPlayerStatKeys(charge).has("atk"));
  // ---- Range vs simulator over toggle combinations, both stat profiles
  [["0", "0"], ["200", "150"]].forEach(([atk, lck]) => {
    inputs.atk.value = atk; inputs.lck.value = lck;
    const combos = [{}, H4, { rabHyperShot: 5 }, { ...H4, rabBouncing: 1 }, { ...H4, rabShotgun: 1 }, { rabHyperShot: 5, rabShotgun: 1 }, { ...H4, rabW59: 1 },
      { ...H4, rabWeapon: 2, rabEquip: 2 }, { rabHyperShot: 5, rabWeapon: 1, rabBouncing: 1 }, { rabEquip: 1 }, { ...H4, rabEquip: 2, rabW59: 1 }, { rabHyperShot: 5, rabEquip: 2, rabShotgun: 1 }, { ...H4, rabExtravagance: 1 }];
    const chargeCombos = [CH({}), CH({ rabHyperShot: 4 }), CH({ rabHeadShot: 1 }), CH({ rabHeadShot: 1, rabDeadShot: 1, rabHyperShot: 3 }), CH({ rabHyperShot: 4, rabComboLv: 0 })];
    const sweep = (sk, list, distKind, dists, aims) => list.forEach(o => dists.forEach(d => aims.forEach(a => {
      for (let r = 1; r <= sk.maxRank; r++) {
        setDeps(o); rb.setDistance(distKind, d); rb.setAim(a); select(sk, r);
        const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(sk, r)));
        let lo = Infinity, hi = -Infinity;
        for (let i = 0; i < 200; i++) { const x = sandbox._rollOneHit(sk, r, undefined, false); lo = Math.min(lo, x); hi = Math.max(hi, x); }
        check(`range/sim ${sk.id} r${r} ${JSON.stringify(o)} d${d} aim${a} atk${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
      }
    })));
    sweep(combo, combos, "combo", [0, 13, 26, 40], [0]);
    sweep(charge, chargeCombos, "charge", [0, 16, 30, 40], [0, 2.5, 4]);
  });
  inputs.atk.value = savedIn.atk; inputs.lck.value = savedIn.lck;
  rb.setDistance("combo", savedDist[0]); rb.setDistance("charge", savedDist[1]); rb.setAim(savedAim);
  savedDeps.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
}
console.log(`Verified ${checkedRabbitShot} Rabbit Combo / Charge Attack checks.`);

// 3o-iv-b. Sheep Charge Attack (2026-09-30): charge-time slider + exact raw damage against hand-worked values from RPC_cAttack
// (Sheep.cs:9780-9800): n = floor(held - 0.8), (int)Clamp((1 + 0.2 Benediction) x n x ATK, ATK, 100 x Lv), White Burst +100.
let checkedSheepCharge = 0;
{
  const deps = sandbox._depRanks, sc = sandbox._sheepCharge;
  const check = (label, ok, got) => { checkedSheepCharge++; if (!ok) { console.error(`[SHEEP CHARGE ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const card = SKILLS.find(s => s.id === "sheep_cAttack");
  const saved = { t: sc.get(), wb: deps.whiteBurst, b: deps.benediction };
  check("Charge Attack uses rawModel with the charge slider and no atkCoeff", !!(card.rawModel && card.sheepChargeInputs && card.atkCoeff === undefined && card.hitCount() === 1 && !card.rawModel.critBase));
  check("seconds: under 2 s -> 0 (no attack), 2.0 s -> 1, 2.8 s -> 2 (no float drift), 2.79 s -> 1",
    [[0, 0], [1.9, 0], [2, 1], [2.8, 2], [2.79, 1], [10, 9]].every(([t, n]) => sc.seconds(t) === n));
  // slider max = first held time that reaches the cap: [rank, ATK, benediction, expected seconds]
  [[4, 100, 0, 4.8], [4, 99, 0, 5.8], [4, 100, 3, 3.8], [1, 500, 0, 2], [1, 100, 0, 2], [3, 0, 0, 2]].forEach(([rank, ATK, b, want]) => {
    deps.benediction = b; check(`slider max rank ${rank} ATK ${ATK} Benediction ${b}`, sc.maxTime(rank, ATK) === want, sc.maxTime(rank, ATK));
  });
  deps.benediction = 0; sc.set(null);
  check("default (null) follows the max = full charge", card.rawModel.parts(4, { ATK: 100, LV: 100 }).plain === 400);
  // [label, rank, ATK, held s, benediction, white burst, expected raw]
  [
    ["rank 4, ATK 100, 4 s: 3 x 100", 4, 100, 4, 0, 0, 300],
    ["rank 4, ATK 100, held past the max: capped at 400", 4, 100, 20, 0, 0, 400],
    ["released at 1.5 s: no attack, White Burst adds nothing", 4, 100, 1.5, 0, 1, 0],
    ["White Burst adds 100 on top of the cap", 4, 100, 20, 0, 1, 500],
    ["White Burst adds 100 below the cap", 2, 50, 3, 0, 1, 200],
    ["Benediction 3: 2 s x 1.6 x 100 = 320", 4, 100, 3, 3, 0, 320],
    ["Benediction 1: (int)(1.2 x 1 x 99) = 118", 4, 99, 2, 1, 0, 118],
    ["ATK above the cap gives the cap", 1, 500, 2, 0, 0, 100],
    ["ATK 0 gives 0", 3, 0, 10, 0, 0, 0],
  ].forEach(([label, rank, ATK, t, b, wb, want]) => {
    sc.set(t); deps.benediction = b; deps.whiteBurst = wb;
    const p = card.rawModel.parts(rank, { ATK, LV: 100 });
    check(label, p.crit + p.plain === want && p.crit === 0, p.crit + p.plain);
  });
  // Reborn only (Reborn:Sheep.cs:13776-13778): Zealous Charge doubles the cap to 200 x Lv, Divine Benediction counts floor(2 x (held - 0.8)) half-seconds.
  // [label, rank, ATK, held s (null = full), zealous, divine, white burst, raw, slider max]
  { const R = (code) => vm.runInContext(code, sandbox);
    sandbox._setServer("reborn"); R("statCapCard = SKILLS.find((s) => s.id === 'sheep_cAttack')");
    [
      ["Reborn Zealous: rank 4, ATK 300, full charge = 3 s x 300 capped at 800, max 3.8 s", 4, 300, null, 1, 0, 0, 800, 3.8],
      ["Reborn no toggle: rank 4, ATK 300, full = 400 at 2.8 s", 4, 300, null, 0, 0, 0, 400, 2.8],
      ["Reborn Divine: rank 4, ATK 100, 2.5 s = floor(2 x 1.7) = 3 x 100, cap 400 at 4 / 2 + 0.8 = 2.8 s", 4, 100, 2.5, 0, 1, 0, 300, 2.8],
      ["Reborn Divine: the 2 s release counts 2", 4, 100, 2, 0, 1, 0, 200, 2.8],
      ["Reborn Divine: rank 4, ATK 300, cap 400 reached at the 2 s minimum", 4, 300, null, 0, 1, 0, 400, 2],
      ["Reborn both: rank 4, ATK 100, full = 800 at 8 / 2 + 0.8 = 4.8 s", 4, 100, null, 1, 1, 0, 800, 4.8],
      ["Reborn both + White Burst: 800 + 100", 4, 100, 20, 1, 1, 1, 900, 4.8],
    ].forEach(([label, rank, ATK, t, z, dv, wb, want, wantMax]) => {
      sc.set(t); deps.benediction = 0; deps.whiteBurst = wb; deps.zealousCharge = z; deps.divineBenediction = dv;
      const p = card.rawModel.parts(rank, { ATK, LV: 100 });
      check(label, p.crit + p.plain === want && sc.maxTime(rank, ATK) === wantMax, (p.crit + p.plain) + " / max " + sc.maxTime(rank, ATK));
    });
    sandbox._setServer("og"); sc.set(20); deps.zealousCharge = 1; deps.divineBenediction = 1; deps.whiteBurst = 0;
    check("BB ignores the Reborn toggles: rank 4, ATK 100, 20 s = 400, max 4.8 s", card.rawModel.parts(4, { ATK: 100, LV: 100 }).plain === 400 && sc.maxTime(4, 100) === 4.8, card.rawModel.parts(4, { ATK: 100, LV: 100 }).plain);
    delete deps.zealousCharge; delete deps.divineBenediction; R("statCapCard = null"); }
  sc.set(saved.t); deps.whiteBurst = saved.wb; deps.benediction = saved.b;
}
console.log(`Verified ${checkedSheepCharge} Sheep Charge Attack checks.`);

// 3o-iv-c. Server damage overrides reach the Test roll (2026-09-30, user report: Torment Rain TTO still rolled the base formula).
// The Test buttons roll activeSimSkill() = getActiveSkill(selected, currentServer); every card whose servers.* entry overrides a
// damage field must roll inside its own server range.
let checkedServerSim = 0;
{
  const check = (label, ok, got) => { checkedServerSim++; if (!ok) { console.error(`[SERVER SIM ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const inputs = sandbox._statInputs, savedIn = { atk: inputs.atk.value, tal: inputs.tal ? inputs.tal.value : undefined };
  const DMG_KEYS = ["dmg", "atkCoeff", "rawModel", "dmgGroups"];
  const cards = SKILLS.filter(s => s.servers && Object.values(s.servers).some(o => o && DMG_KEYS.some(k => k in o)) && !s.isHeal && !s.isHate);
  inputs.atk.value = "100";
  for (const sk of cards) for (const [srv, o] of Object.entries(sk.servers)) {
    if (!o || !DMG_KEYS.some(k => k in o) || o.dmgGroups || sk.dmgGroups) continue;
    const r = sk.maxRank || 1;
    sandbox._setServer(srv); sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._selectSkill(sk);
    const act = sandbox._activeSimSkill();
    check(`${sk.id} on ${srv}: Test rolls the server card`, DMG_KEYS.every(k => !(k in o) || act[k] === o[k]));
    if (typeof sandbox._calcRangeFor !== "function") continue;   // a damage row gated by a dep that is off by default draws no range (Reborn Bounce: From the Above); such a card is rolled with its deps on in its own block
    const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(act, r)));
    let lo = Infinity, hi = -Infinity; for (let i = 0; i < 300; i++) { const x = sandbox._rollOneHit(act, r); lo = Math.min(lo, x); hi = Math.max(hi, x); }
    check(`${sk.id} on ${srv}: Test rolls inside the server range`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
  }
  const tr = SKILLS.find(s => s.id === "chameleon_tormentRain");
  sandbox._setServer("tto"); sandbox._skillRanks[tr.id] = 1; sandbox._selectSkill(tr);
  const act = sandbox._activeSimSkill();
  check("Torment Rain TTO is plain 1 x ATK (dmg 0, atkCoeff 1)", act.dmg === "0" && act.atkCoeff === 1);
  sandbox._setServer("og"); sandbox._selectSkill(tr);
  check("Torment Rain original keeps 0.5 x ATK + talAdjust(60)", sandbox._activeSimSkill().atkCoeff === 0.5 && sandbox._activeSimSkill().dmg === "talAdjust(60)");
  inputs.atk.value = savedIn.atk; sandbox._setServer("og");
}
console.log(`Verified ${checkedServerSim} server-override Test roll checks.`);
// 3o-v. Bison Far Stun / Mass Stun (2026-09-29): num = (int)(0.5 x sLv x ceil(distance)) (Bison.cs:7684), KO = num (+ floor(0.5 x Lv) with Mass Stun, :9134-9150).
let checkedBisonStun = 0;
{
  const deps = sandbox._depRanks, inputs = sandbox._statInputs, bs = sandbox._bisonStun;
  const check = (label, ok, got) => { checkedBisonStun++; if (!ok) { console.error(`[BISON STUN ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const fs = SKILLS.find(s => s.id === "bison_farStun");
  const saved = { d: bs.get(), mass: deps.massStun, lv: inputs.lv.value };
  check("Far Stun carries the distance input and a talAdjust(stunNum) formula", fs.bisonStunInputs === true && fs.dmg === "talAdjust(stunNum)" && fs.hitCount() === 1);
  // [label, rank, distance, Mass Stun, Bison Lv, damage num, KO]
  [
    ["Lv.1 at 7.3 m rounds up to 8 m: floor(0.5 x 8)", 1, 7.3, 0, 100, 4, 4],
    ["Lv.1 at 6.2 m rounds up to 7 m: floor(3.5)", 1, 6.2, 0, 100, 3, 3],
    ["Lv.2 at 10 m: 100% of the distance", 2, 10, 0, 100, 10, 10],
    ["Lv.2 at 9.1 m rounds up to 10 m", 2, 9.1, 0, 100, 10, 10],
    ["Lv.2 at 0.4 m rounds up to 1 m", 2, 0.4, 0, 100, 1, 1],
    ["Lv.1 at 1 m: floor(0.5) = 0", 1, 1, 0, 100, 0, 0],
    ["distance 0", 2, 0, 0, 100, 0, 0],
    ["Mass Stun adds floor(0.5 x 100) KO", 2, 10, 1, 100, 10, 60],
    ["Mass Stun with Lv 99 floors 49.5", 2, 10, 1, 99, 10, 59],
    ["Mass Stun Lv.1 at 7.3 m, Lv 101", 1, 7.3, 1, 101, 4, 54],
  ].forEach(([label, rank, dist, mass, lv, num, ko]) => {
    bs.set(dist); deps.massStun = mass; inputs.lv.value = lv;
    const text = sandbox._substituteDmgVars(fs.dmg, fs, rank), gotKo = sandbox._getKOValue(fs, rank);
    check(`Far Stun ${label}`, text === `talAdjust(${num})` && gotKo === ko, `${text} / KO ${gotKo} want talAdjust(${num}) / ${ko}`);
  });
  bs.set(saved.d); inputs.lv.value = saved.lv; if (saved.mass === undefined) delete deps.massStun; else deps.massStun = saved.mass;
}
// Power Cleave (Bison.cs:25922 axe branch, :25984 hammer branch): axe = (ATK + talAdjust(15 sLv)) x (1 + 0.5 reel), KO 1; hammer = ATK x (1 + 0.5 reel), KO 10 x (min(hammerLv, sLv) + reel).
{
  const deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedBisonStun++; if (!ok) { console.error(`[BISON STUN ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const pc = SKILLS.find(s => s.id === "bison_powerCleave");
  const saved = [deps.powerHammer, deps.powerReel];
  // [label, rank, hammerLv, reel, dmg text, KO]
  [
    ["axe Lv.2 has a talAdjust term and KO 1", 2, 0, 0, "talAdjust(15×2)", 1],
    ["axe Lv.1", 1, 0, 0, "talAdjust(15×1)", 1],
    ["hammer 1 on Cleave 2: ATK only, KO 10", 2, 1, 0, "0", 10],
    ["hammer 2 on Cleave 2: KO 20", 2, 2, 0, "0", 20],
    ["hammer 2 on Cleave 1 is capped by Cleave: KO 10", 1, 2, 0, "0", 10],
    ["Power Reel adds 10 KO per hammer: 10 x (2 + 1)", 2, 2, 1, "0", 30],
    ["Power Reel does not change the axe KO", 2, 0, 1, "talAdjust(15×2)", 1],
  ].forEach(([label, rank, hl, reel, text, ko]) => {
    deps.powerHammer = hl; deps.powerReel = reel;
    const t = sandbox._substituteDmgVars(pc.dmg, pc, rank), k = sandbox._getKOValue(pc, rank);
    check(`Power Cleave ${label}`, t === text && k === ko, `${t} / KO ${k} want ${text} / ${ko}`);
  });
  check("Power Reel is the x1.5 multiplier dep", pc.dmgMultDep && pc.dmgMultDep.mult === 1.5 && pc.atkCoeff === 1);
  deps.powerHammer = saved[0]; deps.powerReel = saved[1];
  if (saved[0] === undefined) delete deps.powerHammer; if (saved[1] === undefined) delete deps.powerReel;
}
// Onslaught (Bison.cs:30448, 30518): clamp(sum ceil(0.1 x hate), 0, 1999); Pride Crusher (:30925): floor(clamp(0.2 x hate, 0, 999)) added to ATK + talAdjust(30); Magma Clutter (:31446): talAdjust(100 - weight).
{
  const bs = sandbox._bisonStun;
  const check = (label, ok, got) => { checkedBisonStun++; if (!ok) { console.error(`[BISON STUN ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const on = SKILLS.find(s => s.id === "bison_onslaught"), pc = SKILLS.find(s => s.id === "bison_prideCrusher"), mc = SKILLS.find(s => s.id === "bison_magmaClutter");
  const saved = [bs.getHate(), bs.getWeight()];
  // Every card with a damage Test has the TTO toggle since 2026-10-07 (user); Onslaught has no roll, so TTO equals OG.
  check("Onslaught is direct damage with a hate input", on.bisonHateInputs === true && on.penetrating === true);
  // [label, hate, Onslaught damage, Pride Crusher hate part]
  [
    ["hate 100", 100, 10, 20], ["hate 105 rounds Onslaught up", 105, 11, 21], ["hate 1", 1, 1, 0], ["hate 0", 0, 0, 0],
    ["hate 7 floors the Pride Crusher part", 7, 1, 1], ["hate 4", 4, 1, 0], ["Onslaught caps at 1999", 30000, 1999, 999],
    ["hate 19990 is exactly 1999", 19990, 1999, 999], ["hate 19991 would be 2000 and is clamped", 19991, 1999, 999],
    ["Pride Crusher caps its hate part at 999", 5000, 500, 999], ["hate 4995 reaches the 999 cap exactly", 4995, 500, 999],
  ].forEach(([label, h, o, c]) => {
    bs.setHate(h);
    const ot = sandbox._substituteDmgVars(on.dmg, on, 1), ct = sandbox._substituteDmgVars(pc.dmg, pc, 1);
    const wantO = Math.min(1999, o), okO = ot === String(wantO);
    check(`Onslaught ${label}`, okO, `${ot} want ${wantO}`);
    check(`Pride Crusher ${label}`, ct === `talAdjust(30)+${c}`, `${ct} want talAdjust(30)+${c}`);
  });
  [[30, "talAdjust(100-30)"], [0, "talAdjust(100-0)"], [100, "talAdjust(100-100)"]].forEach(([w, text]) => {
    bs.setWeight(w);
    const t = sandbox._substituteDmgVars(mc.dmgGroups[0].dmg, mc, 1);
    check(`Magma Clutter weight ${w}`, t === text, `${t} want ${text}`);
  });
  bs.setHate(saved[0]); bs.setWeight(saved[1]);
}
console.log(`Verified ${checkedBisonStun} Bison Far Stun checks.`);
// 3o-v. "ดูสูตรคริ" (crit view): a toggle on the cards that model crit (critProc or rawModel.critBase). While on, the formula is drawn as
// floor(1.8 x (...)), Raw / Final show the crit case and Test always rolls a crit; the shotgun wraps only its base term.
let checkedCritView = 0;
{
  const inputs = sandbox._statInputs, deps = sandbox._depRanks, ep = sandbox._effectProc, cv = sandbox._critView, rb = sandbox._rabbit;
  const check = (label, ok, got) => { checkedCritView++; if (!ok) { console.error(`[CRIT VIEW ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const sk = (id) => SKILLS.find(s => s.id === id);
  const select = (s, r) => { sandbox._skillRanks[s.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(s); };
  const heroOf = (id) => { const s = sk(id); select(s, s.maxRank || 1); return sandbox._getRenderedHeroHtml(); };
  const rng = (s, r) => { const g = s.dmgGroups ? s.dmgGroups.find(x => sandbox._resolveGroupHitCount(s, x) !== 0) : null; return g ? sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(s, g), g) : sandbox._calcRangeFor(sandbox._getDmgText(s, r)); };
  const roll = (s, r) => s.dmgGroups ? sandbox._rollOneHit(s, r, undefined, false, s.dmgGroups.findIndex(x => sandbox._resolveGroupHitCount(s, x) !== 0)) : sandbox._rollOneHit(s, r, undefined, false);
  const critCards = SKILLS.filter(s => s.critProc || (s.rawModel && s.rawModel.critBase)).map(s => s.id).sort();
  const EXPECTED_CRIT_CARDS = ["bat_nAttack", "bison_nAttack", "cat_nAttack", "chameleon_leftStride", "chameleon_nAttack", "mole_nAttack", "monkey_nAttack", "panda_nAttack", "penguin_nAttack", "rabbit_nAttack", "sheep_bookBash", "sheep_nAttack", "whale_nAttack", "wolf_nAttack"];
  check("the cards that model crit are " + EXPECTED_CRIT_CARDS.join(", "), critCards.join() === EXPECTED_CRIT_CARDS.join(), critCards.join());
  // Panda Combo goldens (Panda.cs:15320, :15528, :18652): ATK 100, SP 50, Focused Spirit 2 -> FS 30; stage 1 trunc(0.2 x 130) = 26, crit trunc(0.2 x (180 + 30)) = 42;
  // stage 1 punch 2 never crits; Aura Blast 125 + 30 = 155, crit floor(1.8 x 125) + 30 = 255.
  {
    const pc = sk("panda_nAttack"), g = pc.dmgGroups, sp0 = sandbox._pandaSp.get();
    const savedP = ["focusedSpirit", "auraBlast", "pandaGearWeapon", "pandaGearEquip"].map(id => [id, deps[id]]);
    inputs.atk.value = "100"; sandbox._pandaSp.set(50); deps.focusedSpirit = 2; deps.auraBlast = 1; deps.pandaGearWeapon = 2; deps.pandaGearEquip = 2;
    cv.set(false); select(pc, 4);
    const gr = (i) => sandbox._calcRangeFor(g[i].dmg, undefined, g[i]).slice(0, 2).join();
    check("Panda stage 1 hit 1 spans 26-42 with Champion gear", gr(0) === "26,42", gr(0));
    check("Panda stage 1 hit 2 never crits: 26-26", gr(1) === "26,26", gr(1));
    check("Panda Aura Blast spans 155-255", gr(6) === "155,255", gr(6));
    cv.set(true); select(pc, 4); check("Panda crit view stage 1 hit 1 = 42", gr(0) === "42,42", gr(0));
    cv.set(false); sandbox._pandaSp.set(sp0); savedP.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
  }
  const RAB = ["rabHyperShot", "rabBouncing", "rabShotgun", "rabW59", "rabWeapon", "rabEquip", "rabExtravagance"];
  const savedRab = RAB.map(id => [id, deps[id]]), savedIn = { atk: inputs.atk.value, lck: inputs.lck.value }, savedDist = rb.getDistance("combo");
  cv.set(false);
  critCards.forEach(id => check(`${id} shows the crit view button`, heroOf(id).includes('data-role="crit-view"')));
  ["rabbit_cAttack", "cat_forwardLunge", "wolf_provoke", "bison_cAttack"].forEach(id => check(`${id} has no crit view button`, !heroOf(id).includes('data-role="crit-view"')));
  // formula drawn as a crit, only while the view is on
  critCards.forEach(id => {
    cv.set(false); const off = heroOf(id);
    cv.set(true); const on = heroOf(id);
    check(`${id} formula is plain with the view off`, !off.includes("⌊"));
    // Chameleon Combo rounds its crit up (CeilToInt, Chameleon_nAttack.cs:655-663), so it draws ceil brackets
    const ceilCrit = !!(sk(id).rawModel && sk(id).rawModel.critRound === "ceil");
    check(`${id} formula is ${ceilCrit ? "ceil" : "floor"}(1.8 x ...) with the view on`, (ceilCrit ? on.includes("⌈") && on.includes("⌉") : on.includes("⌊") && on.includes("⌋")) && /1\.8/.test(on));
  });
  // Chameleon Combo goldens (Chameleon_nAttack.cs:502, :643-668): ATK 128 -> rank 4 raw floor(0.35f x 128) = 44, rank 1 floor(0.425f x 128) = 54;
  // crit view ceil(1.8f x 44) = 80; Bulls Eye with Critical Plus 4 (merged toggle rank 5): ceil(2.4f x 44) = 106; Fatal Strike 4 + Extra Arrows
  // (merged toggle rank 5) adds 6 x 5 = 30; Critical Plus 4 alone stays x1.8 (checked below).
  {
    const chm = sk("chameleon_nAttack");
    const CHM = ["criticalPlus", "fatalStrike", "chmGearWeapon", "chmGearMantis", "chmTotWeapon", "chmTotEquip", "piercingVenom", "chmTargetPoison", "bowMastery"];
    const savedChm = CHM.map(id => [id, deps[id]]);
    const chmSet = (o) => CHM.forEach(id => { deps[id] = o[id] || 0; });
    inputs.atk.value = "128"; inputs.lck.value = "0";
    chmSet({}); cv.set(false); select(chm, 4); check("Chameleon Combo rank 4 raw is 44", rng(chm, 4).join() === "44,44", rng(chm, 4).join());
    select(chm, 1); check("Chameleon Combo rank 1 raw is 54", rng(chm, 1).join() === "54,54", rng(chm, 1).join());
    cv.set(true); select(chm, 4); check("Chameleon Combo crit view is ceil(1.8 x 44) = 80", rng(chm, 4).join() === "80,80", rng(chm, 4).join());
    chmSet({ criticalPlus: 5 }); select(chm, 4); check("Chameleon Combo Critical Plus 5 (= 4 + Bulls Eye) crit is ceil(2.4 x 44) = 106", rng(chm, 4).join() === "106,106", rng(chm, 4).join());
    cv.set(false); select(chm, 4); check("Chameleon Combo with Critical Plus spans 44-106", rng(chm, 4).join() === "44,106", rng(chm, 4).join());
    chmSet({ criticalPlus: 4 }); cv.set(true); select(chm, 4); check("Chameleon Combo Critical Plus 4 without Bulls Eye stays ceil(1.8 x 44) = 80", rng(chm, 4).join() === "80,80", rng(chm, 4).join()); cv.set(false);
    chmSet({ fatalStrike: 5 }); select(chm, 4); check("Chameleon Combo Fatal Strike 5 (= 4 + Extra Arrows) adds 30", rng(chm, 4).join() === "74,74", rng(chm, 4).join());
    chmSet({ piercingVenom: 2, chmTargetPoison: 6 }); select(chm, 4); check("Chameleon Combo Deadly Venom x poison 6 adds 72", rng(chm, 4).join() === "116,116", rng(chm, 4).join());
    chmSet({ chmGearWeapon: 2, chmGearMantis: 1, criticalPlus: 4 }); check("Chameleon crit base Mantis Bow R + Mantis set + Critical Plus 4 = 32", sandbox._chameleonCritBase() === 32, sandbox._chameleonCritBase());
    // ToT and TTO fixed the gear check (user-reported 2026-10-02 / 2026-10-26): Champion bow 7 + hat and armor 11 + Critical Plus 4 (20) = 38; the BB gear toggles count for nothing there
    for (const srv of ["tot", "tto"]) { sandbox._setServer(srv); chmSet({ chmTotWeapon: 2, chmTotEquip: 2, chmGearWeapon: 2, chmGearMantis: 1, criticalPlus: 4 }); check(srv + " Chameleon crit base Champion set + Critical Plus 4 = 38", sandbox._chameleonCritBase() === 38, sandbox._chameleonCritBase()); }
    sandbox._setServer("og");
    savedChm.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
    cv.set(false);
  }
  cv.set(true); check("crit view does not change a card that has no crit", !heroOf("rabbit_cAttack").includes("⌊") && !heroOf("cat_forwardLunge").includes("⌊"));
  // Rabbit Combo goldens: ATK 128, rank 1, 16 m, no deps -> raw 64, crit floor(1.8 x 64) = 115
  inputs.atk.value = "128"; inputs.lck.value = "128";
  const rabSet = (o) => RAB.forEach(id => { deps[id] = o[id] || 0; });
  const combo = sk("rabbit_nAttack"); rb.setDistance("combo", 16);
  rabSet({}); cv.set(false); select(combo, 1); check("Rabbit raw without the view is 64", rng(combo, 1).join() === "64,64", rng(combo, 1).join());
  cv.set(true); select(combo, 1); check("Rabbit raw in the crit view is floor(1.8 x 64) = 115", rng(combo, 1).join() === "115,115", rng(combo, 1).join());
  rabSet({ rabHyperShot: 4 }); rb.setDistance("combo", 26); select(combo, 3);
  check("Rabbit rifle crit view wraps base + Hyper Shot: floor(1.8 x (64 + 40)) = 187", rng(combo, 3).join() === "187,187", rng(combo, 3).join());
  rabSet({ rabHyperShot: 4, rabShotgun: 1 }); rb.setDistance("combo", 4); select(combo, 1);
  check("Rabbit shotgun crit view wraps only the base: floor(1.8 x 64) + 48 = 163", rng(combo, 1).join() === "163,163", rng(combo, 1).join());
  const shotHtml = sandbox._getRenderedHeroHtml();
  check("shotgun formula closes the crit bracket before the Hyper Shot term", shotHtml.indexOf("⌋") > 0 && shotHtml.indexOf("⌋") < shotHtml.indexOf("Hyper Shot 4m"));
  // Test always rolls a crit in the view, and never without gear outside it
  rabSet({}); rb.setDistance("combo", 16); select(combo, 1);
  let all = true; for (let i = 0; i < 60; i++) { roll(combo, 1); if (!ep.lastCrit()) all = false; }
  check("Test rolls a crit every time in the crit view", all);
  cv.set(false); select(combo, 1); let any = false; for (let i = 0; i < 200; i++) { roll(combo, 1); if (ep.lastCrit()) any = true; }
  check("Test does not crit without gear when the view is off", !any);
  // critProc cards: view range == floor(1.8 x normal range) at both ends (no gear, so the normal range has no crit top)
  ["wolf_nAttack", "bison_nAttack", "sheep_bookBash", "sheep_nAttack"].forEach(id => {
    const s = sk(id); const r = s.maxRank || 1;
    cv.set(false); select(s, r); const n = rng(s, r);
    cv.set(true); select(s, r); const c = rng(s, r);
    check(`${id} crit view range = floor(1.8 x normal)`, c[0] === Math.floor(1.8 * n[0]) && c[1] === Math.floor(1.8 * n[1]), `${n.join("-")} -> ${c.join("-")}`);
  });
  // range vs simulator in the crit view, both stat profiles
  [["0", "0"], ["200", "150"]].forEach(([atk, lck]) => {
    inputs.atk.value = atk; inputs.lck.value = lck; cv.set(true);
    critCards.forEach(id => {
      const s = sk(id), r = s.maxRank || 1; if (id === "rabbit_nAttack") { rabSet({ rabHyperShot: 4 }); rb.setDistance("combo", 26); } else rabSet({});
      select(s, r);
      const rg = rng(s, r), fin = sandbox._finalRangeForRange(rg);
      let lo = Infinity, hi = -Infinity; for (let i = 0; i < 200; i++) { const x = roll(s, r); lo = Math.min(lo, x); hi = Math.max(hi, x); }
      check(`range/sim in the crit view ${id} atk ${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
    });
  });
  cv.set(false); inputs.atk.value = savedIn.atk; inputs.lck.value = savedIn.lck; rb.setDistance("combo", savedDist);
  savedRab.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
}
console.log(`Verified ${checkedCritView} crit view checks.`);

console.log(`Verified ${checkedEnemyCycle} enemy picker checks.`);
console.log(`Verified ${checkedConsistency} range-vs-simulator consistency checks (every single-hit skill rank, deps default and off, two stat profiles).`);

// Universal Hero Render check (every skill in SKILLS must render without runtime exceptions)
let checkedHeroRenders = 0;
for (const sk of SKILLS) {
  try {
    sandbox._selectSkill(sk);
    const heroHtml = sandbox._getRenderedHeroHtml();
    if (!heroHtml || heroHtml.length < 50) {
      console.error(`[RENDER ERROR] ${sk.id}: hero HTML is empty or too short`);
      errorCount++;
    } else {
      checkedHeroRenders++;
    }
  } catch (e) {
    console.error(`[RENDER EXCEPTION] ${sk.id}: ${e.message}`);
    errorCount++;
  }
}
console.log(`Verified ${checkedHeroRenders} hero render checks (every skill selectable without runtime exceptions).`);

// Grand Casino Arcade (Cat.cs:27993-28265): roll = Random.Range(0, clamp(LCK, 0, 255)); <5 Doom (no hit),
// <50 = 111, <90 = 222, <120 = 333, else 777. Odds chips, raw range, final range and the real simulator must agree.
let checkedCasino = 0;
{
  const casinoFail = (msg) => { console.error(`[CASINO ERROR] ${msg}`); errorCount++; };
  const near = (a, b) => Math.abs(a - b) < 1e-9;
  for (const lck of [0, 1, 5, 6, 50, 51, 120, 121, 255, 400]) {
    const sum = sandbox.casinoOdds(lck).reduce((s, o) => s + o.pct, 0);
    if (!near(sum, 100)) casinoFail(`odds at LCK ${lck} sum to ${sum}, not 100`); else checkedCasino++;
  }
  const odds = (lck, i) => sandbox.casinoOdds(lck)[i].pct;
  [[0, 0, 100], [5, 0, 100], [6, 0, 500 / 6], [6, 1, 100 / 6], [255, 0, 500 / 255], [255, 4, 13500 / 255], [120, 4, 0], [121, 4, 100 / 121]]
    .forEach(([lck, i, want]) => { if (!near(odds(lck, i), want)) casinoFail(`odds[${i}] at LCK ${lck} = ${odds(lck, i)}, want ${want}`); else checkedCasino++; });
  [[5, 0], [6, 111], [50, 111], [51, 222], [90, 222], [91, 333], [120, 333], [121, 777], [400, 777]]
    .forEach(([lck, want]) => { const r = sandbox.casinoRawRange(lck); if (r[0] !== 0 || r[1] !== want) casinoFail(`raw range at LCK ${lck} = ${r}, want 0-${want}`); else checkedCasino++; });

  const sk = SKILLS.find(s => s.id === "cat_grandCasinoArcade");
  const inputs = sandbox._statInputs;
  const savedLck = inputs.lck.value, savedPower = sandbox._depRanks.catPower;
  for (const lck of [5, 50, 121, 255]) for (const power of [0, 4]) {
    inputs.lck.value = String(lck); sandbox._depRanks.catPower = power; sandbox._skillRanks[sk.id] = 2;
    sandbox._calcRangeFor = undefined; sandbox._selectSkill(sk);
    const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(sk, 2)));
    let lo = Infinity, hi = -Infinity;
    for (let i = 0; i < 3000; i++) { const x = sandbox._rollOneHit(sk, 2); lo = Math.min(lo, x); hi = Math.max(hi, x); }
    const tag = `LCK ${lck}, Power ${power} [range ${fin[0]}-${fin[1]}, rolled ${lo}-${hi}]`;
    if (lo < fin[0] || hi > fin[1]) casinoFail(`roll outside range: ${tag}`); else checkedCasino++;
    if (lck === 5 && (hi !== 0 || fin[1] !== 0)) casinoFail(`LCK 5 must always be Doom (0 damage): ${tag}`); else checkedCasino++;
  }
  inputs.lck.value = savedLck;
  if (savedPower === undefined) delete sandbox._depRanks.catPower; else sandbox._depRanks.catPower = savedPower;
}
console.log(`Verified ${checkedCasino} Grand Casino Arcade (LCK odds / range / simulator) checks.`);

// CHA / AGI Optimizer tool (2026-09-25): caoOptimal() against an independent brute force, then the real mount (4 cards render, a toggle re-renders, Ctrl+Z restores).
let checkedCao = 0;
{
  const caoFail = (msg) => { console.error(`[CAO ERROR] ${msg}`); errorCount++; };
  const bDur = (b, c, p) => { const d = Math.floor(b * (1 + 0.015 * Math.min(Math.max(c, 1), 512))); return p ? Math.floor((1.1 + 0.2 * p) * d) : d; };
  const bCd = (b, a, r) => { const c = b * 128 / (a + 128); return r ? Math.ceil(0.88 * c) : c; };
  const bMinAgi = (cdB, d, r) => { let a = 0; while (bCd(cdB, a, r) > d) a++; return a; };
  for (const [cdB, dB] of [[120, 8], [300, 15], [120, 12], [120, 2], [120, 6], [300, 12]]) for (const p of [0, 1, 2]) for (const r of [false, true]) {
    const tag = `cd ${cdB} dur ${dB} persev ${p} revArt ${r}`;
    let best = Infinity;
    for (let c = 0; c <= 512; c++) best = Math.min(best, c + bMinAgi(cdB, bDur(dB, c, p), r));
    const o = sandbox.caoOptimal(cdB, dB, p, r);
    if (o.cha + o.agi !== best) caoFail(`${tag}: optimal total ${o.cha + o.agi}, brute force ${best}`); else checkedCao++;
    if (bCd(cdB, o.agi, r) > bDur(dB, o.cha, p)) caoFail(`${tag}: optimal CHA ${o.cha} AGI ${o.agi} has downtime`); else checkedCao++;
  }
  // Known values from the 2026-09-25 hand calculation (Dark Edge r4, Lunar Eclipse r2).
  [[120, 8, 0, false, 522], [120, 8, 2, true, 354], [300, 15, 0, false, 632], [300, 15, 2, true, 439]].forEach(([cdB, dB, p, r, want]) => {
    const o = sandbox.caoOptimal(cdB, dB, p, r);
    if (o.cha + o.agi !== want) caoFail(`known total cd ${cdB} dur ${dB} persev ${p} revArt ${r}: ${o.cha + o.agi}, want ${want}`); else checkedCao++;
  });

  // LCK + cycle chance (2026-10-06): every cast rolls R = 0..ceil(0.2 LCK)-1 separately for AGI and CHA. At 100% the
  // LCK value must change nothing; below it, the result must be the cheapest pair that cycles on at least that share
  // of the roll pairs (independent brute force over every CHA, AGI and roll pair).
  const bShare = (cdB, dB, p, r, cha, agi, m) => { let n = 0; for (let ra = 0; ra < m; ra++) for (let rc = 0; rc < m; rc++) if (bCd(cdB, agi + ra, r) <= bDur(dB, cha + rc, p)) n++; return n; };
  for (const [cdB, dB, p, r] of [[120, 8, 0, false], [120, 8, 2, true], [300, 15, 2, true]]) {
    const base = sandbox.caoOptimal(cdB, dB, p, r);
    for (const lck of [0, 37, 150]) {
      const o = sandbox.caoOptimal(cdB, dB, p, r, lck, 100);
      if (o.cha !== base.cha || o.agi !== base.agi) caoFail(`cd ${cdB} dur ${dB}: LCK ${lck} at 100% gives ${o.cha}/${o.agi}, LCK 0 gives ${base.cha}/${base.agi}`); else checkedCao++;
    }
    for (const [lck, pct] of [[150, 50], [60, 80]]) {
      const m = Math.max(1, Math.ceil(0.2 * lck)), need = Math.max(1, Math.ceil(pct / 100 * m * m - 1e-9));
      let best = Infinity;
      for (let c = 0; c <= 512; c++) { let a = 0; while (bShare(cdB, dB, p, r, c, a, m) < need) a++; if (c + a < best) best = c + a; if (c >= best) break; }
      const o = sandbox.caoOptimal(cdB, dB, p, r, lck, pct);
      if (o.cha + o.agi !== best) caoFail(`cd ${cdB} dur ${dB} LCK ${lck} ${pct}%: total ${o.cha + o.agi}, brute force ${best}`); else checkedCao++;
      if (bShare(cdB, dB, p, r, o.cha, o.agi, m) < need) caoFail(`cd ${cdB} dur ${dB} LCK ${lck} ${pct}%: ${o.cha}/${o.agi} cycles below ${pct}%`); else checkedCao++;
      if (o.cha + o.agi > base.cha + base.agi) caoFail(`cd ${cdB} dur ${dB} LCK ${lck} ${pct}%: costs more than 100%`); else checkedCao++;
    }
  }

  // Real mount with a recording stub root.
  const reg = new Map(), rootListeners = {}, docListeners = [];
  const caoRoot = makeEl();
  caoRoot.querySelector = (sel) => { if (!reg.has(sel)) reg.set(sel, makeEl()); return reg.get(sel); };
  caoRoot.addEventListener = (type, fn) => { rootListeners[type] = fn; };
  const savedDocAdd = sandbox.document.addEventListener;
  sandbox.document.addEventListener = (type, fn) => docListeners.push([type, fn]);
  try { sandbox.mountChaAgiOptimizer(caoRoot); } catch (e) { caoFail(`mount threw: ${e.message}`); }
  sandbox.document.addEventListener = savedDocAdd;
  const gridHtml = () => (reg.get('[data-role="grid"]') || {}).innerHTML || "";
  const first = gridHtml();
  const cardCount = (first.match(/class="cao-card"/g) || []).length;
  if (cardCount !== 4) caoFail(`rendered ${cardCount} cards, want 4`); else checkedCao++;
  ["Dark Edge", "Lunar Eclipse", "Rapid Trance", "Immunity"].forEach(n => { if (!first.includes(n)) caoFail(`card "${n}" missing`); else checkedCao++; });
  // The page template must carry real icon data, not a leftover patch placeholder (the Revised Art icon once shipped as
  // the literal "@@D@@{SKILL_ICONS.revisedArt}").
  const shell = String(caoRoot.innerHTML || "");
  if (/@@|\$\{/.test(shell) || !shell.includes(SKILL_ICONS.revisedArt)) caoFail("page template has an unreplaced placeholder or no Revised Art icon"); else checkedCao++;
  // Overrides (caoPair): no override = the optimum; a typed CHA gets the lowest AGI that still cycles, a typed AGI the
  // lowest CHA (null when even CHA 512 is not enough). "Lowest" = the solved value cycles and one point less does not.
  for (const [cdB, dB, p, r] of [[120, 8, 2, true], [300, 15, 0, false], [120, 12, 0, true], [120, 2, 0, false]]) {
    const tag = `cd ${cdB} dur ${dB} persev ${p} revArt ${r}`;
    const o = sandbox.caoOptimal(cdB, dB, p, r), n = sandbox.caoPair(cdB, dB, p, r, null);
    if (n.cha !== o.cha || n.agi !== o.agi) caoFail(`${tag}: no-override pair ${n.cha}/${n.agi} != optimum ${o.cha}/${o.agi}`); else checkedCao++;
    for (const cha of [0, 50, 150, 300, 512, 700]) {
      const agi = sandbox.caoPair(cdB, dB, p, r, { stat: "cha", value: cha }).agi, d = bDur(dB, cha, p);
      if (bCd(cdB, agi, r) > d || (agi > 0 && bCd(cdB, agi - 1, r) <= d)) caoFail(`${tag} CHA ${cha}: solved AGI ${agi} is not the lowest that cycles`); else checkedCao++;
    }
    for (const agi of [0, 60, 154, 400, 2000]) {
      const cha = sandbox.caoPair(cdB, dB, p, r, { stat: "agi", value: agi }).cha, c = bCd(cdB, agi, r);
      let want = null; for (let x = 0; x <= 512; x++) if (bDur(dB, x, p) >= c) { want = x; break; }
      if (cha !== want) caoFail(`${tag} AGI ${agi}: solved CHA ${cha}, want ${want}`); else checkedCao++;
    }
  }
  if (!rootListeners.click) caoFail("no click handler"); else {
    rootListeners.click({ target: { closest: (sel) => sel === '[data-role="revArt"]' ? {} : null } });
    if (gridHtml() === first) caoFail("Revised Art toggle did not re-render"); else checkedCao++;
    const keydown = docListeners.find(([t]) => t === "keydown");
    if (!keydown) caoFail("no Ctrl+Z handler"); else {
      keydown[1]({ ctrlKey: true, shiftKey: false, key: "z", preventDefault: () => {} });
      if (gridHtml() !== first) caoFail("Ctrl+Z did not restore the previous state"); else checkedCao++;
    }
  }
}
console.log(`Verified ${checkedCao} CHA/AGI Optimizer checks.`);
// 3q. Cat Power Number series on TTO (user rule 2026-09-26): only Skill Tree A keeps the Power toggle and multiplier;
// every other Cat damage card (Combo, Tree B, Class C) must show no Power control and ignore a stale Power rank on TTO.
let checkedCatPowerTto = 0;
{
  const fail = (msg) => { console.error(`[CAT POWER TTO ERROR] ${msg}`); errorCount++; };
  const treeA = new Set(["cat_luckyCard","cat_fateDraw","cat_powerShuffle","cat_lifeGamble","cat_skillGamble","cat_luckyDice","cat_doubleDown","cat_powerOne","cat_powerTwo","cat_powerThree","cat_powerSeven","cat_twoPair","cat_copycat","cat_damageRoulette","cat_nineLives","cat_grandCasinoArcade"]);
  const dmgCats = SKILLS.filter(s => s.class === "Cat" && !s.mount && (s.dmg || s.dmgGroups || s.comboModel));
  // Mount attacks (user 2026-10-17) hit as the mount character (Type "none"), so Power never applies, on any server.
  for (const sk of SKILLS.filter(s => s.class === "Cat" && s.mount)) for (const server of ["og", "tto"]) { sandbox._setServer(server); sandbox._depRanks.catPower = 4; sandbox._skillRanks[sk.id] = 1; sandbox._selectSkill(sk); if (sandbox._getRenderedHeroHtml().includes('data-dep-id="catPower"')) fail(`${sk.id} on ${server}: a mount attack shows the Power toggle`); else checkedCatPowerTto++; }
  const savedPower = sandbox._depRanks.catPower;
  for (const sk of dmgCats) {
    if (sk.onlyServer) {   // a server-exclusive card (Reborn C6 / C7) has no TTO tab: Power applies on its own server (hit(), Reborn:CharacterControl.cs:7059-7091)
      sandbox._skillRanks[sk.id] = sk.maxRank || 1; sandbox._setServer(sk.onlyServer); sandbox._depRanks.catPower = 4; sandbox._selectSkill(sk);
      if (!sandbox._getRenderedHeroHtml().includes('data-dep-id="catPower"')) fail(`${sk.id} on ${sk.onlyServer}: Power toggle missing`); else checkedCatPowerTto++;
      sandbox._setServer("og"); continue;
    }
    if (!treeA.has(sk.id) && !(sk.servers && sk.servers.tto)) fail(`${sk.id}: non-Class-A Cat damage skill has no TTO server entry, so its TTO button is missing`); else checkedCatPowerTto++;
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    for (const server of ["og", "tto"]) {
      sandbox._setServer(server);
      sandbox._depRanks.catPower = 4;
      sandbox._selectSkill(sk);
      const hasPower = sandbox._getRenderedHeroHtml().includes('data-dep-id="catPower"');
      const want = server === "og" || treeA.has(sk.id);
      if (hasPower !== want) fail(`${sk.id} on ${server}: Power toggle ${hasPower ? "shown" : "missing"}, expected ${want ? "shown" : "hidden"}`); else checkedCatPowerTto++;
    }
    if (!treeA.has(sk.id) && !sk.comboModel && !sk.dmgGroups && sk.dmg && !sk.casinoArcade) {
      // The displayed damage range must ignore a stale Power rank on TTO.
      const rangeAt = (p) => { sandbox._setServer("tto"); sandbox._depRanks.catPower = p; sandbox._calcRangeFor = undefined; sandbox._selectSkill(sk); return sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(sk, sk.maxRank || 1))).join(); };
      const r0 = rangeAt(0), r4 = rangeAt(4);
      if (r0 !== r4) fail(`${sk.id} on tto: range changes with Power (${r0} vs ${r4})`); else checkedCatPowerTto++;
    }
  }
  // Open Wound line (user rule 2026-09-26): every card that carries the Open Wound bonus says which hits get it.
  const owCards = SKILLS.filter(s => s.effectProc && s.effectProc.controls && s.effectProc.controls.some(d => d.id === "openWound"));
  const heroOf = (sk, server) => { sandbox._setServer(server); sandbox._skillRanks[sk.id] = sk.maxRank || 1; sandbox._selectSkill(sk); return sandbox._getRenderedHeroHtml(); };
  for (const sk of owCards) {
    const h = heroOf(sk, "og");
    if (!h.includes("Open Wound:") || !h.includes("เพิ่มเติม")) fail(`${sk.id}: no Open Wound bonus-damage line in the description`); else checkedCatPowerTto++;
  }
  const fbl = SKILLS.find(s => s.id === "cat_finishingBlow");
  { const fh = heroOf(fbl, "og"); if (!fh.includes("เพิ่มเติมทุกฮิต") || !/class="sk-unintended"[^>]*>[\s\S]*?ฮิตที่ 3/.test(fh) || fh.includes("เฉพาะฮิตที่ 3</")) fail("cat_finishingBlow: the Open Wound line says every hit and the hit 3 only gap sits in the unintended chip"); else checkedCatPowerTto++; }
  const cmb = SKILLS.find(s => s.id === "cat_nAttack");
  const cmbHtml = heroOf(cmb, "og").replace(/<span class="sk-nobr">([^<]*)<\/span>/g, "$1");   // loanword glue is markup only
  if (!cmbHtml.includes("เพิ่มเติมทุกฮิต") || cmbHtml.includes("ฮิตที่ 2 จะไม่ติดดาเมจม่วง") || !/class="sk-unintended"[^>]*>[\s\S]*?ไม่ติดฮิตที่ 2 เมื่อฟันหลังด้วย/.test(cmbHtml)) fail("cat_nAttack: Open Wound line says every hit and the stage 2 Hidden Blade gap sits in the unintended chip"); else checkedCatPowerTto++;
  const ttoCombo = heroOf(cmb, "tto");
  if (ttoCombo.includes("Power Seven")) fail("cat_nAttack on tto still mentions Power Seven"); else checkedCatPowerTto++;
  // Rabbit Miracle Blend (Rabbit_potion.cs:432-438): status duration chaAdjust(4 + 2 x Alchemist Lab rank) (4s unlearned), golden potion chip per bottle and per 4 bottles.
  const mb = SKILLS.find(s => s.id === "rabbit_miracleBlend");
  for (const [lab, want] of [[0, 4], [1, 6], [2, 8], [3, 10], [4, 12]]) {
    sandbox._depRanks.alchemistLab = lab;
    if (!heroOf(mb, "og").includes("base " + want + "s")) fail(`rabbit_miracleBlend at Alchemist Lab ${lab}: duration base must be ${want}s`); else checkedCatPowerTto++;
  }
  delete sandbox._depRanks.alchemistLab;
  const mbHtml = heroOf(mb, "og");
  if (!mbHtml.includes("โอกาส ยาทองต่อขวด") || !mbHtml.includes("โอกาส ยาทองต่อ 4 ขวด")) fail("rabbit_miracleBlend: needs both golden-potion chips (per bottle and per 4 bottles)"); else checkedCatPowerTto++;
  sandbox._setServer("og");
  if (savedPower === undefined) delete sandbox._depRanks.catPower; else sandbox._depRanks.catPower = savedPower;
}
console.log(`Verified ${checkedCatPowerTto} Cat Power Number TTO checks.`);
// TTO removed the LCK roll from talAdjust/dmgAdjust/defAdjust (tdlRoll). Sweep every card with a
// TTO button from usesTdlRoll: on TTO its final damage range must not move with enemy LCK (only
// defAdjust reads it) nor with player LCK (unless the card reads LCK directly).
let checkedTtoNoLck = 0;
{
  const fail = (msg) => { console.error(`[TTO NO-LCK ERROR] ${msg}`); errorCount++; };
  const ins = sandbox._statInputs;
  const saved = [ins.atk.value, ins.tal.value, ins.lck.value, ins.enemyLck.value];
  ins.atk.value = "200"; ins.tal.value = "80";
  const rangesAt = (sk, server, lck, enemyLck) => {
    sandbox._setServer(server); ins.lck.value = String(lck); ins.enemyLck.value = String(enemyLck);
    sandbox._selectSkill(sk);
    const parts = sk.dmgGroups
      ? sk.dmgGroups.map(g => sandbox._finalRangeForRange(sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g)))
      : [sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(sk, sk.maxRank || 1)))];
    return JSON.stringify(parts);
  };
  const readsLck = (sk) => !!(sk.lckProc || sk.lckCoeff !== undefined || sk.lckDiffCoeff !== undefined || sk.effectLckRoll
    || sk.casinoArcade || sk.comboModel || /lckAdjust\(|LCK/.test(String(sk.dmg) + JSON.stringify(sk.dmgGroups || [])));
  let bbVaries = 0;
  // Formulas on a runtime variable (Vortex HP, InventoryWeight) need inputs calcRangeFor alone does not have.
  const needsVars = (sk) => /Vortex|InventoryWeight/.test(sandbox._getDmgText(sk, sk.maxRank || 1) + JSON.stringify(sk.dmgGroups || []));
  for (const sk of SKILLS.filter(s => sandbox._usesTdlRoll(s) && !needsVars(s) && !(s.onlyServer && s.onlyServer !== "tto"))) {   // a server-exclusive card (Reborn C6 / C7) offers no TTO toggle
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    try {
      const base = rangesAt(sk, "tto", 150, 0);
      const enemy = rangesAt(sk, "tto", 150, 200);
      if (sk.lckDiffCoeff === undefined && base !== enemy) fail(`${sk.id} on tto: enemy LCK changes damage (${base} vs ${enemy})`); else checkedTtoNoLck++;
      if (!readsLck(sk)) {
        const player = rangesAt(sk, "tto", 0, 0);
        if (base !== player) fail(`${sk.id} on tto: player LCK changes damage (${player} vs ${base})`); else checkedTtoNoLck++;
      }
      if (rangesAt(sk, "og", 150, 0) !== rangesAt(sk, "og", 150, 200)) bbVaries++;
    } catch (e) { fail(`${sk.id}: range threw ${e.message}`); }
  }
  // Guards the sweep itself: if BB stops varying too, the ranges above are not reading LCK at all.
  if (bbVaries < 50) fail(`only ${bbVaries} cards vary with enemy LCK on BB, so the TTO sweep proves nothing`);
  sandbox._setServer("og");
  [ins.atk.value, ins.tal.value, ins.lck.value, ins.enemyLck.value] = saved;
}
// TTO Magic Damage (TTO_MAGIC_DMG): on TTO a magic card at enemy DEF 2n must equal the same card at DEF n with the
// magic rule off (exact half, no rounding: user readings 2026-10-06, pinned below), and BB must ignore the rule.
// Every listed id must be a real card.
{
  const fail = (msg) => { console.error(`[TTO MAGIC ERROR] ${msg}`); errorCount++; };
  const ins = sandbox._statInputs, magic = sandbox._ttoMagic.ids;
  const saved = [ins.atk.value, ins.tal.value, ins.lck.value, ins.enemyLck.value, ins.enemyDef.value];
  ins.atk.value = "200"; ins.tal.value = "80"; ins.lck.value = "0"; ins.enemyLck.value = "0";
  for (const id of magic) if (!SKILLS.some(s => s.id === id)) fail(`${id} is in TTO_MAGIC_DMG but has no card`);
  // Test popup draws magic hits with the aqua digit set
  for (let n = 0; n < 10; n++) if (!/^data:image\/(png;base64,iVBORw0KGgo|webp;base64,UklGR)/.test(SKILL_ICONS["dmgdigit_a" + n] || "")) fail(`aqua digit texture dmgdigit_a${n} missing or not a PNG / WebP`);
  const rangesAt = (sk, server, def) => {
    sandbox._setServer(server); ins.enemyDef.value = String(def);
    sandbox._selectSkill(sk);
    const parts = sk.dmgGroups
      ? sk.dmgGroups.map(g => sandbox._finalRangeForRange(sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g)))
      : [sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(sk, sk.maxRank || 1)))];
    return JSON.stringify(parts);
  };
  let halved = 0;
  for (const sk of SKILLS.filter(s => magic.has(s.id) && sandbox._usesTdlRoll(s) && !/Vortex|InventoryWeight/.test(String(s.dmg)))) {
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    try {
      const magicRange = rangesAt(sk, "tto", 102);
      magic.delete(sk.id);
      const halfRange = rangesAt(sk, "tto", 51), fullRange = rangesAt(sk, "tto", 102), bbOff = rangesAt(sk, "og", 102);
      magic.add(sk.id);
      if (magicRange !== halfRange) fail(`${sk.id} on tto: DEF 102 gives ${magicRange}, expected the DEF 51 range ${halfRange}`); else checkedTtoNoLck++;
      if (rangesAt(sk, "og", 102) !== bbOff) fail(`${sk.id}: the magic rule changes the BB range`); else checkedTtoNoLck++;
      if (magicRange !== fullRange) halved++;
    } catch (e) { magic.add(sk.id); fail(`${sk.id}: range threw ${e.message}`); }
  }
  // Guards the sweep: if no card's range moves with DEF, the comparison above proves nothing.
  if (halved < 20) fail(`only ${halved} magic cards move with enemy DEF, so the half-DEF sweep proves nothing`);
  // Dep-gated magic (ttoMagicDep: Gyro shots with Synchro Mole): with the dep on, TTO DEF 102 must equal the same card
  // with the field removed at DEF 51; with it off, the field must change nothing.
  const gated = SKILLS.filter(s => s.ttoMagicDep);
  if (!gated.some(s => s.id === "mole_autoGyroGun_nAttack")) fail("mole_autoGyroGun_nAttack lost its ttoMagicDep (Synchro Mole)");
  for (const sk of gated) {
    const dep = sk.ttoMagicDep, savedRank = sandbox._depRanks[dep.id];
    const plainAt = (def) => { delete sk.ttoMagicDep; try { return rangesAt(sk, "tto", def); } finally { sk.ttoMagicDep = dep; } };
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    try {
      sandbox._depRanks[dep.id] = dep.maxRank;
      const on = rangesAt(sk, "tto", 102);
      if (on !== plainAt(51)) fail(`${sk.id}: ${dep.id} on, TTO DEF 102 should match half DEF`); else checkedTtoNoLck++;
      if (on === plainAt(102)) fail(`${sk.id}: DEF does not move the range, the check proves nothing`); else checkedTtoNoLck++;
      sandbox._depRanks[dep.id] = 0;
      if (rangesAt(sk, "tto", 102) !== plainAt(102)) fail(`${sk.id}: ${dep.id} off, TTO should use full DEF`); else checkedTtoNoLck++;
    } catch (e) { fail(`${sk.id}: range threw ${e.message}`); }
    if (savedRank === undefined) delete sandbox._depRanks[dep.id]; else sandbox._depRanks[dep.id] = savedRank;
  }
  // Live readings (user, TTO, 2026-10-06): Gorgon Shot at TAL 101, LCK 0 on both sides, no buffs. Odd DEFs 5 and 15
  // separate the exact half from ceil (ceil gives 146 / 139) and 177 at rank 2 rules out floor (173).
  const GORGON_READINGS = { 2: [[2, 299], [112, 201], [177, 172], [200, 165], [300, 138]], 1: [[2, 149], [5, 147], [15, 140], [112, 96], [177, 79], [200, 74], [300, 56]] };
  const gorgon = SKILLS.find(s => s.id === "rabbit_gorgonShot");
  if (!gorgon) fail("rabbit_gorgonShot card missing");
  else {
    const savedRank = sandbox._skillRanks[gorgon.id];
    ins.tal.value = "101";
    for (const [rank, rows] of Object.entries(GORGON_READINGS)) for (const [def, want] of rows) {
      sandbox._skillRanks[gorgon.id] = Number(rank);
      sandbox._setServer("tto"); ins.enemyDef.value = String(def); sandbox._selectSkill(gorgon);
      const r = sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(gorgon, Number(rank))));
      if (r[0] !== want || r[1] !== want) fail(`Gorgon Shot rank ${rank} at DEF ${def} on TTO: ${JSON.stringify(r)}, game shows ${want}`); else checkedTtoNoLck++;
    }
    if (savedRank === undefined) delete sandbox._skillRanks[gorgon.id]; else sandbox._skillRanks[gorgon.id] = savedRank;
  }
  console.log(`Verified TTO Magic Damage: ${magic.size} listed skills, ${halved} damage cards hit against half DEF, ${gated.length} dep-gated, ${Object.values(GORGON_READINGS).flat().length} Gorgon Shot readings.`);
  sandbox._setServer("og");
  [ins.atk.value, ins.tal.value, ins.lck.value, ins.enemyLck.value, ins.enemyDef.value] = saved;
}
// Final Multiplier is ToT-only (MOD_DEFS onlyServers), built-in and custom alike: steps only with the popup on ToT.
{
  const fm = sandbox._finalMult;
  fm.active.add("finalMult1");
  fm.customBd.push({ id: "valFm", kind: "finalMult", name: "t", value: 10 });
  fm.activeCustom.add("valFm");
  for (const [srv, want] of [["og", 0], ["tto", 0], ["tot", 2]]) {
    fm.setServer(srv);
    const n = fm.count(true).length;
    if (n !== want) { console.error(`[FINAL MULT ERROR] popup server ${srv}: ${n} Final Multiplier step(s), expected ${want}`); errorCount++; } else checkedTtoNoLck++;
  }
  fm.active.delete("finalMult1");
  fm.customBd.splice(fm.customBd.findIndex(e => e.id === "valFm"), 1);
  fm.activeCustom.delete("valFm");
  fm.setServer("og");
}
// Random.Range(0, ceil(0.2*LCK)) excludes its max: LCK 50 gives the 10 rolls 0..9, not 0..10.
{
  const dist = sandbox.lckDistribution(0, 0, 50, (b, s, R) => R, v => v);
  if (dist.length !== 10 || dist[9].label !== "9" || dist[0].pct !== 10) { console.error(`[LCK DIST ERROR] LCK 50 gave ${dist.map(d => d.label).join(",")}`); errorCount++; } else checkedTtoNoLck++;
}
console.log(`Verified ${checkedTtoNoLck} TTO no-LCK-roll checks.`);
// Contributor credits: every {{credit:id}} token in the file names a CONTRIBUTORS entry (unique ids, a name and at least
// one Thai line each), and the token renders as the scroll button.
{
  const fail = (msg) => { console.error(`[CREDIT ERROR] ${msg}`); errorCount++; };
  const list = sandbox._credits.list, ids = list.map(c => c.id);
  if (new Set(ids).size !== ids.length) fail("duplicate CONTRIBUTORS id");
  list.forEach(c => { if (!c.id || !c.name || !Array.isArray(c.what) || !c.what.length || !c.what.every(t => /[฀-๿]/.test(t))) fail(`entry ${c.id || "?"} needs id, name and Thai "what" lines`); });
  const used = [...new Set([...html.matchAll(/\{\{credit:([a-z0-9_-]+)\}\}/gi)].map(m => m[1].toLowerCase()))].filter(id => id !== "id");   // "id" = the placeholder in code comments
  used.forEach(id => { if (!ids.includes(id)) fail(`{{credit:${id}}} has no CONTRIBUTORS entry`); });
  if (used.length && !sandbox._credits.render(`x {{credit:${used[0]}}}`).includes(`class="sk-credit" data-credit="${used[0]}"`)) fail("credit token does not render as .sk-credit");
  console.log(`Verified contributor credits: ${list.length} contributor(s), ${used.length} credited id(s) in use.`);
}
// Bold spacing (user 2026-10-07; ^^glossary^^ links too, user 2026-10-16): a **gold** / __red__ / ^^glossary^^ token in a card desc (every rank, server and dep rank) or a
// status popup text (STATUS_DESC_MAP / STATUS_DESC_SERVER) never touches a letter or digit, and has no double space
// beside it. Punctuation and <br> may touch it.
{
  const fail = (where, ctx, why) => { console.error(`[BOLD SPACING ERROR] ${where}: ${why} :: ${ctx}`); errorCount++; };
  const isWord = (ch) => !!ch && /[\p{L}\p{N}\p{M}]/u.test(ch);
  const seen = new Set();
  let tokens = 0;
  const check = (where, str) => {
    if (typeof str !== "string") return;
    for (const t of [...str.matchAll(/(\*\*|__)([\s\S]+?)\1/g), ...str.matchAll(/(\^\^)([^^\n]+?)\1/g)]){   // ^^glossary^^ links in a separate pass (user 2026-10-16): inside a __red__ token the first pass never reaches them
      tokens++;
      const a = t.index, b = a + t[0].length, why = [];
      if (isWord(str[a - 1])) why.push("no space before");
      if (str[a - 1] === " " && str[a - 2] === " ") why.push("double space before");
      if (isWord(str[b])) why.push("no space after");
      if (str[b] === " " && str[b + 1] === " ") why.push("double space after");
      const ctx = str.slice(Math.max(0, a - 12), b + 12);
      if (why.length && !seen.has(where + ctx)){ seen.add(where + ctx); fail(where, ctx, why.join(", ")); }
    }
  };
  for (const s of SKILLS){
    const variants = [["desc", s.desc], ...Object.entries(s.servers || {}).filter(([, o]) => o && o.desc !== undefined).map(([k, o]) => [`servers.${k}.desc`, o.desc])];
    for (const [field, d] of variants) for (const srv of ["og", "tot", "tto"]){
      sandbox._setServer(srv);
      for (let r = 0; r <= (s.maxRank || 1); r++) for (const dr of [null, 0, 1, 2, 3, 4, 5]){
        let str; try { str = typeof d === "function" ? d(r, dr) : d; } catch (e) { continue; }
        check(`${s.id} ${field}`, str);
      }
    }
  }
  sandbox._setServer("og");
  const SDM = vm.runInContext("STATUS_DESC_MAP", sandbox), SDS = vm.runInContext("STATUS_DESC_SERVER", sandbox);
  const statusEntries = [...Object.entries(SDM).map(([k, v]) => [`STATUS_DESC_MAP.${k}`, v]),
    ...Object.entries(SDS).flatMap(([srv, m]) => Object.entries(m).map(([k, v]) => [`STATUS_DESC_SERVER.${srv}.${k}`, v]))];
  for (const [where, v] of statusEntries) for (const sLv of [null, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]) for (const lck of [null, 0, 128]){
    let str; try { str = typeof v === "function" ? v(sLv, lck) : v; } catch (e) { continue; }
    check(where, str);
  }
  // every ^^glossary^^ link anywhere in the page source (change notes, bug / tooltip notes, the glossary itself): a space or punctuation on each side
  for (const t of html.matchAll(/\^\^([^^\n]{1,60}?)\^\^/g)){ const a = t.index, b = a + t[0].length, why = []; if (isWord(html[a - 1])) why.push("no space before"); if (isWord(html[b])) why.push("no space after"); if (why.length) fail("source", html.slice(Math.max(0, a - 12), b + 12), why.join(", ")); }
  console.log(`Verified bold spacing: ${tokens} rendered bold / glossary tokens in card descs and ${statusEntries.length} status texts, plus every glossary link in the source.`);
}
// Unmodelled formulas (2026-10-07, user): after substituteDmgVars a dmg text may only hold numbers, operators and
// talAdjust(...). Words mean a value the Test cannot see (Nova Flare's "Vortex HP", Hydro Blast's "TargetWeight").
{
  let checked = 0;
  for (const sk of SKILLS){
    const variants = [sk, ...Object.values(sk.servers || {}).map(o => Object.assign({}, sk, o))];
    for (const c of variants){
      if (!(c.dmg || c.dmgGroups) || c.rawModel) continue;
      const texts = c.dmgGroups ? c.dmgGroups.map(g => g.dmg) : [c.dmg];
      for (const t of texts){
        let sub = String(sandbox._substituteDmgVars(t, c, c.maxRank || 1)).replace(/talAdjust\(/g, "(");
        if (c.phoenixFireball || c.ownStatsPhoenix) sub = sub.replace(/\b(Phoenix|Monkey|Floor)\b/g, "");
        if (/[ก-๙]/.test(sub)) continue;   // Thai description: shown as text, never simulated (no TTO toggle either)
        const left = sub.replace(/[0-9+\-*/.()×÷%, ]/g, "");
        if (left) { console.error(`[UNMODELLED FORMULA ERROR] ${sk.id}: "${String(t).slice(0, 60)}" keeps "${left}"; model it with dmgInputs / a function dmg`); errorCount++; }
        else checked++;
      }
    }
  }
  console.log(`Verified ${checked} damage formulas have no unmodelled words.`);
}
// 3r. Dependency strip (spec docs/superpowers/specs/2026-09-26-dep-strip-design.md): every dep button lives in one
// .sk-dep-strip under the description, once per dep id, with at least one effect tag; no strip on a card without deps.
let checkedDepStrip = 0;
{
  const fail = (msg) => { console.error(`[DEP STRIP ERROR] ${msg}`); errorCount++; };
  const splitStrip = (html) => {
    const s = html.indexOf('<div class="sk-dep-strip">');
    if (s < 0) return { strip: "", rest: html };
    const e = html.indexOf("<!--/sk-dep-strip-->", s);
    return { strip: html.slice(s, e), rest: html.slice(0, s) + html.slice(e) };
  };
  const btnRe = /class="sk-dep-(toggle|rank-icon)[^"]*"[^>]*data-dep-id="([^"]+)"/g;
  for (const sk of SKILLS) {
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    sandbox._selectSkill(sk);
    const html = sandbox._getRenderedHeroHtml();
    const { strip, rest } = splitStrip(html);
    // 1. no dep button outside the strip
    const outside = [...rest.matchAll(btnRe)].map(m => m[2]);
    if (outside.length) fail(`${sk.id}: dep button(s) outside the strip: ${outside.join(", ")}`); else checkedDepStrip++;
    // 2. each dep id once in the strip, every item tagged
    const ids = [...strip.matchAll(btnRe)].map(m => m[2]);
    const dup = ids.filter((id, i) => ids.indexOf(id) !== i);
    if (dup.length) fail(`${sk.id}: dep id(s) repeated in the strip: ${dup.join(", ")}`); else checkedDepStrip++;
    const items = strip.split('<div class="sk-dep-item"').length - 1;
    const tagged = strip.split('<span class="sk-dep-item-tags"><span class="sk-dep-tag"').length - 1;
    if (items !== tagged) fail(`${sk.id}: ${items - tagged} strip item(s) without an effect tag`); else checkedDepStrip++;
    // 3b. no empty dep-toggle containers left behind (summon header, damage header)
    if (html.includes("sk-summon-toggles") && /<div class="sk-summon-toggles[^"]*">\s*<\/div>/.test(html)) fail(`${sk.id}: empty .sk-summon-toggles container left in the summon header`); else checkedDepStrip++;
    // 3. no empty strip
    if (strip && items === 0) fail(`${sk.id}: empty .sk-dep-strip rendered`); else checkedDepStrip++;
    // 6. skill toggles ascend by internal skill ID; non-skill toggles (empty key) come after them
    const keys = [...strip.matchAll(/<div class="sk-dep-item" data-dep-order="(\d*)"/g)].map(m => m[1] === "" ? Infinity : +m[1]);
    if (keys.length !== items) { console.error(`[DEP ORDER ERROR] ${sk.id}: ${items - keys.length} strip item(s) without data-dep-order`); errorCount++; }
    else if (keys.some((k, i) => i > 0 && k < keys[i - 1])) { console.error(`[DEP ORDER ERROR] ${sk.id}: strip not in ascending skill ID order: ${keys.join(", ")}`); errorCount++; }
    else checkedDepStrip++;
  }
  // 8. a server desc (servers.tto / tot .desc) must differ from the base desc at some rank. ttoDesc() swaps a phrase of the
  //    base text; if that phrase is reworded later the swap silently does nothing and the server card shows stale values.
  {
    //    A server change may only show while a dep is on (ToT Intense Fire % on Phoenix - Fireball), so dep ranks 0-3 count too.
    const txt = (d, r, dr) => typeof d === "function" ? d(r, dr) : d;
    for (const sk of SKILLS) if (sk.servers) for (const srv in sk.servers) {
      const d = sk.servers[srv].desc; if (!d) continue;
      let differs = false;
      for (let r = 1; r <= (sk.maxRank || 1) && !differs; r++) for (let dr = 0; dr <= 3 && !differs; dr++) { try { differs = txt(d, r, dr) !== txt(sk.desc, r, dr); } catch (e) { differs = true; } }
      if (!differs) { console.error(`[SERVER DESC ERROR] ${sk.id}: servers.${srv}.desc is identical to the base desc at every rank (a ttoDesc phrase swap no longer matches?)`); errorCount++; }
      else checkedDepStrip++;
    }
  }
  // 7. every card except the "sup_" support skills and mount items (mount:true, no skill number) has an internal skill ID
  //    (new cards need an entry in SKILL_INTERNAL_ID)
  {
    const table = vm.runInContext("SKILL_INTERNAL_ID", sandbox);
    const missing = SKILLS.filter(s => table[s.id] === undefined && !String(s.icon || "").startsWith("sup_") && !s.mount && !s.soon).map(s => s.id);
    if (missing.length) { console.error(`[DEP ORDER ERROR] cards with no SKILL_INTERNAL_ID entry: ${missing.join(", ")}`); errorCount++; } else checkedDepStrip++;
  }
  const byId = (id) => SKILLS.find(s => s.id === id);
  const stripOf = (id, server) => { if (server) sandbox._setServer(server); const sk = byId(id); sandbox._skillRanks[sk.id] = sk.maxRank || 1; sandbox._selectSkill(sk); const h = splitStrip(sandbox._getRenderedHeroHtml()).strip; sandbox._setServer("og"); return h; };
  const itemOf = (strip, depId) => { const i = strip.indexOf(`data-dep-id="${depId}"`); if (i < 0) return ""; const e = strip.indexOf('<div class="sk-dep-item"', i); return strip.slice(i, e < 0 ? undefined : e); };
  // 4. rank-cycle dep keeps its min/max attributes; toggle keeps on/off attributes
  const mb = stripOf("rabbit_miracleBlend");
  if (!/data-dep-id="alchemistLab" data-dep-min-rank="0" data-dep-max-rank="4"/.test(mb)) fail("rabbit_miracleBlend: Alchemist Lab strip button lost its rank-cycle attributes"); else checkedDepStrip++;
  const fd = stripOf("cat_flyingDagger");
  if (!/data-dep-id="threeKnives" data-dep-toggle-off="0" data-dep-toggle-on="1"/.test(fd)) fail("cat_flyingDagger: Three Knives strip button lost its toggle attributes"); else checkedDepStrip++;
  // 5. spot checks
  const dis = itemOf(stripOf("cat_disarm"), "openWound");
  if (!dis.includes(">DMG<") || !dis.includes(">DUR<")) fail("cat_disarm: Open Wound item must carry DMG and DUR tags"); else checkedDepStrip++;
  const mbDrop = itemOf(mb, "miracleDrop");
  if (!mbDrop.includes(">CHANCE<")) fail("rabbit_miracleBlend: Miracle Drop item must carry the CHANCE tag"); else checkedDepStrip++;
  if (!stripOf("cat_reverseThrust", "og").includes('data-dep-id="catPower"')) fail("cat_reverseThrust on og: Cat Power item missing"); else checkedDepStrip++;
  if (stripOf("cat_reverseThrust", "tto").includes('data-dep-id="catPower"')) fail("cat_reverseThrust on tto: Cat Power item must be absent"); else checkedDepStrip++;
  // 6. outside renderHero (no sink) a helper still returns its button
  const loose = sandbox._renderDmgToggle({ id: "zzLoose", label: "Loose", icon: "cat_openWound5", minRank: 0, maxRank: 1 });
  if (!loose.includes('data-dep-id="zzLoose"')) fail("renderDmgToggle with no sink must return the button HTML"); else checkedDepStrip++;
}
console.log(`Verified ${checkedDepStrip} dependency strip checks.`);

// Chameleon attack simulator (mountChameleonSim): gear per server, crit totals, server popups, per-server gear memory.
// BB follows Chameleon_nAttack.cs:517-668 (G.Marshal Bow +4, Mantis R set 5/4/3); ToT and TTO are the user-reported fix
// (Marshal 5/4/3, Champion 7/6/5, no Mantis). See chameleon-skill-reference.md, Server Balance Variations.
let checkedChmSim = 0;
{
  const fail = (msg) => { console.error(`[CHM SIM ERROR] ${msg}`); errorCount++; };
  const ok = (cond, msg) => { if (cond) checkedChmSim++; else fail(msg); };
  const run = (code) => vm.runInContext(code, sandbox);
  // crit totals from the item tables
  const total = (srv, ids) => run(`[${ids.map(([list, id]) => `chmItemCrit(${list}.find(x => x.id === "${id}"), "${srv}")`).join(",")}].reduce((a, b) => a + b, 0)`);
  ok(total("og", [["CHM_WEAPONS", "mantisBow"], ["CHM_HELMETS", "mantisHat"], ["CHM_ARMORS", "mantisSuit"]]) === 12, "BB Mantis R set should total 12");
  ok(total("og", [["CHM_WEAPONS", "marshalBow"]]) === 4, "BB G.Marshal Bow should be 4");
  ok(total("tot", [["CHM_WEAPONS", "marshalBow"], ["CHM_HELMETS", "marshalHelmet"], ["CHM_ARMORS", "marshalArmor"]]) === 12, "ToT Marshal set should total 12");
  ok(total("tot", [["CHM_WEAPONS", "championBow"], ["CHM_HELMETS", "championHelmet"], ["CHM_ARMORS", "championArmor"]]) === 18, "ToT Champion set should total 18");
  ok(total("tot", [["CHM_WEAPONS", "mantisBow"]]) === 0, "Mantis gives no crit on ToT");
  ok(total("tto", [["CHM_WEAPONS", "marshalBow"], ["CHM_HELMETS", "marshalHelmet"], ["CHM_ARMORS", "marshalArmor"]]) === 12, "TTO Marshal set should total 12 (fixed like ToT, 2026-10-26)");
  ok(total("tto", [["CHM_WEAPONS", "championBow"], ["CHM_HELMETS", "championHelmet"], ["CHM_ARMORS", "championArmor"]]) === 18, "TTO Champion set should total 18");
  ok(total("tto", [["CHM_WEAPONS", "mantisBow"], ["CHM_HELMETS", "mantisHat"], ["CHM_ARMORS", "mantisSuit"]]) === 0, "Mantis gives no crit on TTO");
  // mount with recording stubs
  const reg = new Map(), popups = [];
  const mk = () => { const e = makeEl(); e.listeners = {}; e.addEventListener = (t, fn) => { e.listeners[t] = fn; }; e.querySelectorAll = () => []; return e; };
  const root = mk(); root.querySelector = (sel) => { if (!reg.has(sel)) reg.set(sel, mk()); return reg.get(sel); };
  const doc = sandbox.document, saved = { add: doc.addEventListener, rem: doc.removeEventListener, ce: doc.createElement, body: doc.body };
  doc.addEventListener = () => {}; doc.removeEventListener = () => {}; doc.createElement = () => mk(); doc.body = { appendChild: (el) => popups.push(el) };
  try {
    run("mountChameleonSim")(root); checkedChmSim++;
    const opts = (sel) => (reg.get(sel).innerHTML.match(/value="([^"]+)"/g) || []).map(s => s.slice(7, -1));
    const click = (srv) => reg.get("#chmServerToggle").listeners.click({ target: { closest: () => ({ dataset: { server: srv } }) } });
    const pick = (sel, v) => { reg.get(sel).value = v; reg.get(sel).listeners.change(); };
    const now = () => ["#chmWepSelect", "#chmHelSelect", "#chmArmSelect"].map(s => reg.get(s).value).join("/");
    const has = (sel, ids) => ids.every(id => opts(sel).includes(id)), lacks = (sel, ids) => ids.every(id => !opts(sel).includes(id));
    ok(has("#chmWepSelect", ["marshalBow", "mantisBow"]) && lacks("#chmWepSelect", ["championBow"]), "BB weapons: Marshal + Mantis, no Champion");
    ok(has("#chmArmSelect", ["mantisSuit"]) && lacks("#chmArmSelect", ["championArmor", "marshalArmor"]), "BB armors: Mantis only");
    pick("#chmWepSelect", "mantisBow"); pick("#chmHelSelect", "mantisHat");
    const bbSet = now();
    let n = popups.length; click("tot");
    ok(has("#chmWepSelect", ["marshalBow", "championBow"]) && lacks("#chmWepSelect", ["mantisBow"]), "ToT weapons: Marshal + Champion, no Mantis");
    ok(has("#chmHelSelect", ["marshalHelmet", "championHelmet"]) && lacks("#chmHelSelect", ["mantisHat"]), "ToT helmets: Marshal + Champion");
    const pop = popups.length > n ? popups[popups.length - 1].innerHTML : "";
    ok(pop.includes("Tales of Tail (ToT)") && pop.includes("sk-tag-fix"), "ToT opens the crit-gear [Fix] popup");
    pick("#chmArmSelect", "championArmor");
    ok(reg.get("#chmArmDesc").textContent === "+6% คริ", "ToT Champion Armor desc +6% คริ");
    const totSet = now();
    n = popups.length; click("og");
    ok(popups.length === n, "BB opens no popup");
    ok(now() === bbSet, `BB gear restored after a ToT visit (${now()} vs ${bbSet})`);
    click("tot"); ok(now() === totSet, `ToT gear restored (${now()} vs ${totSet})`);
    n = popups.length; click("tto");
    ok(popups.length > n && popups[popups.length - 1].innerHTML.includes("Tailstopia Online (TTO)") && popups[popups.length - 1].innerHTML.includes("sk-tag-fix"), "TTO opens its popup with the crit-gear [Fix]");
    ok(has("#chmWepSelect", ["marshalBow", "championBow"]) && lacks("#chmWepSelect", ["mantisBow"]) && has("#chmArmSelect", ["marshalArmor", "championArmor"]) && lacks("#chmArmSelect", ["mantisSuit"]), "TTO gear: Marshal + Champion, no Mantis");
    click("og");
  } catch (e) { fail("simulator threw: " + e.message); }
  Object.assign(doc, { addEventListener: saved.add, removeEventListener: saved.rem, createElement: saved.ce, body: saved.body });
}
console.log(`Verified ${checkedChmSim} Chameleon simulator checks.`);

// Skill simulator (class-guide tool, 2026-10-12): the Rabbit grid data and the learn rules (skillSimValid) against hand-derived expectations from the game code.
let checkedRsim = 0;
{
  const fail = (msg) => { console.error(`[SKILL SIM ERROR] ${msg}`); errorCount++; };
  const ok = (cond, msg) => { if (cond) checkedRsim++; else fail(msg); };
  const SIM = vm.runInContext("SKILL_SIM", sandbox).rabbit, cellsFn = vm.runInContext("skillSimCells", sandbox), validFn = vm.runInContext("skillSimValid", sandbox), poolMax = vm.runInContext("skillSimPoolMax", sandbox), poolMaxC = vm.runInContext("skillSimPoolMaxC", sandbox);
  const cells = cellsFn(SIM);
  const valid = (ids, lv) => validFn(cells, SIM.length, new Set(ids), lv);
  const tile = vm.runInContext("TOOLS", sandbox).find(x => x.id === "class-guide");
  ok(tile && tile.title === "ไกด์อาชีพ" && !tile.badge && !/rsim-wip">/.test(html), "Class Guide tile keeps its name and has no in-development chip (removed user 2026-10-16)");
  ok(/data-cg-role="send"[^\n]*discord\.com\/users\/333828912830480386/.test(html) && /act === "export"\)\{[^\n]*showCopied\(\)/.test(html) && !/data-cg-role="sent"|el\("sent"\)/.test(html), "Editor step 6 names the maintainer (Discord jumpptty); คัดลอกโค้ดไกด์ only shows its check mark, no pop-up (user 2026-10-16)");
  ok(SIM.length === 4 && SIM.every(t => t.rows.length >= 5 && t.rows.every(r => r.length === 4)), "Rabbit has 4 trees of 4-column rows");
  const count = SIM.map(t => t.rows.flat().filter(Boolean).length).join("/");
  ok(count === "18/30/30/20", `cells per tree ${count}, want 18/30/30/20 (Basic/A/B/C)`);
  for (const id in cells) {
    const c = cells[id];
    ok(!!SKILL_ICONS[c.icon], `cell ${id} icon ${c.icon} missing`);
    ok(c.req.every(r => cells[r]), `cell ${id} requires a skill that is not in the grid`);
  }
  // Point pools: Basic+A+B = clamp(lv-1, 0, 49); C = clamp(floor((lv-50)/5), 0, 12).
  [[1, 0, 0], [10, 9, 0], [50, 49, 0], [60, 49, 2], [95, 49, 9]].forEach(([lv, m, mc]) => ok(poolMax(lv) === m && poolMaxC(lv) === mc, `pools at Lv ${lv}: ${poolMax(lv)}/${poolMaxC(lv)}, want ${m}/${mc}`));
  ok(poolMaxC(54) === 0 && poolMaxC(55) === 1, "first C point arrives at Lv 55");
  // Values read straight from RabbitSkill.getSkill (explicit setReq, checked by hand 2026-10-12): [reqLv, reqPoints].
  [[104, 4, 0], [254, 32, 21], [353, 28, 18], [243, 24, 12], [434, 75, 4], [444, 85, 6], [272, 40, 25]].forEach(([id, lv, bn]) => ok(cells[id] && cells[id].lv === lv && cells[id].bn === bn, `cell ${id} should be Lv ${lv} / ${bn} pts, got ${cells[id] && cells[id].lv}/${cells[id] && cells[id].bn}`));
  ok(cells[434].req.join() === "243,343" && cells[444].req.join() === "434", "Contract (434) needs Acidic Field I + Truce Trading I (rSkill 243343) and New Order (444) needs Contract");
  // Screenshot scenario (Lv 10, 9 points): Maim Shot I + II learned, 7 left.
  ok(valid([201, 202], 10) && !valid([201, 202, 203], 10), "Lv 10: Maim Shot I-II fine, III needs Lv 15");
  ok(!valid([202], 10) && !valid([211], 10) && valid([201, 211], 10), "ranks need the rank before them; Mix I needs 1 point already in tree A");
  ok(!valid([201], 2) && valid([201], 3), "Maim Shot I needs Lv 3");
  // Pool limit: Lv 5 gives 4 points.
  ok(valid([101, 102, 103, 104], 5) && !valid([101, 102, 103, 104, 201], 5), "Lv 5: 4 points in Basic fine, a 5th (tree A) is over the pool");
  // Learn-order check: three skills that each need 2 points before them cannot be the only skills in the tree.
  ok(!valid([203, 202, 201].filter(i => i !== 201), 20), "a tree cannot hold skills whose point requirement was never reached");
  // C needs its own level, its own pool and the named skill; no previous-rank rule.
  const b4 = [101, 102, 103, 104];
  ok(valid([404], 55) && !valid([404], 54), "Revised Skill (404) needs Lv 55");
  ok(!valid([401], 60) && valid([...b4, 401], 60) && !valid([...b4, 401, 404], 55), "Bouncing Bullet needs Long Shot IV; Lv 55 has only 1 C point");
  // Contract (434): Acidic Field I + Truce Trading I, Lv 75, 4 other C skills. Build the prerequisites by learning in id order.
  const learnTo = (set, tree, target) => { for (const id of Object.keys(cells).map(Number).filter(i => cells[i].tree === tree).sort((a, b) => a - b)) { if (set.has(target)) break; set.add(id); if (!valid(set, 95)) set.delete(id); } };
  const full = new Set(b4); learnTo(full, 1, 243); learnTo(full, 2, 343); [401, 404, 414, 424, 434].forEach(i => full.add(i));
  ok(valid(full, 95), "Contract build (Long Shot IV, A up to Acidic Field I, B up to Truce Trading I, 4 C skills + Contract) is legal at Lv 95");
  ok(!valid(full, 74), "...and not at Lv 74 (Contract needs Lv 75)");
  const noAcid = new Set(full); noAcid.delete(243); ok(!valid(noAcid, 95), "Contract without Acidic Field I is illegal");
  const noTruce = new Set(full); noTruce.delete(343); ok(!valid(noTruce, 95), "Contract without Truce Trading I is illegal");
  const noAim = new Set(full); noAim.delete(104); ok(!valid(noAim, 95), "Bouncing Bullet without Long Shot IV is illegal");
  // One-click learning (skillSimAutoLearn): everything a skill needs is learned with it, nothing is removed, impossible requests return null.
  const auto = vm.runInContext("skillSimAutoLearn", sandbox), A = (set, lv, id) => auto(cells, SIM.length, new Set(set), lv, id);
  const treeCount = (s, tr) => [...s].filter(i => cells[i].tree === tr).length;
  const life = A([], 95, 254);
  ok(life && valid(life, 95) && [251, 252, 253, 254].every(i => life.has(i)) && treeCount(life, 1) === 22, "Life Shot (254) in one click: the 3 ranks before it plus enough Tree A skills for its 21 points (22 in total)");
  ok(A([], 10, 254) === null, "Life Shot is out of reach at Lv 10 (Lv 32 and 21 points)");
  const keep = A([101, 102], 95, 244);
  ok(keep && keep.has(101) && keep.has(102) && keep.has(244) && valid(keep, 95), "one-click learning keeps what was already learned");
  // Class C is learned one skill at a time: refused while anything it needs is missing, added alone once everything is there.
  ok(A([], 95, 434) === null && A([], 95, 444) === null && A([], 95, 401) === null && A([], 54, 404) === null && A([], 55, 404) !== null && A([], 55, 404).size === 1, "Class C skills are not one-click: refused while a prerequisite is missing, learned alone when nothing is needed");
  const fullNoContract = new Set(full); fullNoContract.delete(434);
  const again = A([...fullNoContract], 95, 434);
  ok(again && again.size === full.size && validFn(cells, SIM.length, again, 95) && A([...fullNoContract], 74, 434) === null, "with everything it needs already learned, Contract is added alone (Lv 75 needed)");
  ok(A([], 4, 101) !== null && A([101], 95, 101) !== null && A([], 1, 201) === null, "a skill below the level is refused, a first rank learns alone");
  // Clicking a learned skill (skillSimDrop): that rank and every rank above it go, and a build that would break is refused by the caller's valid().
  const drop = vm.runInContext("skillSimDrop", sandbox), D = (set, id) => [...drop(new Set(set), id)].sort((a, b) => a - b).join();
  ok(D([201, 202, 203, 204], 201) === "" && D([201, 202, 203, 204], 202) === "201" && D([201, 202, 203, 204], 204) === "201,202,203", "clicking rank 1 of 4 unlearns the skill; rank 2 leaves rank 1; rank 4 leaves rank 3");
  ok(D([201], 201) === "" && D([101, 102, 201, 202], 101) === "201,202" && D([101, 102, 201, 202], 102) === "101,201,202", "a lone rank drops itself; other rows are untouched");
  ok(D([401, 404], 401) === "404", "Class C skills have no ranks: the click drops the skill");
  ok(!valid(drop(new Set([101, 102, 103, 104, 401]), 104), 95) && !valid(drop(new Set([101, 102, 103, 104, 401]), 102), 95) && valid(drop(new Set([101, 102, 103, 104]), 102), 95), "Long Shot cannot lose rank 4 while Bouncing Bullet needs it");
  // Mole (added 2026-10-12): same rules, its own grid and prerequisites, read from MoleSkill.getSkill / getSkillTree.
  const MOLE = vm.runInContext("SKILL_SIM", sandbox).mole, mcells = cellsFn(MOLE), mvalid = (ids, lv) => validFn(cells2(), 4, new Set(ids), lv);
  function cells2(){ return mcells; }
  const mcount = MOLE.map(t => t.rows.flat().filter(Boolean).length).join("/");
  ok(MOLE.length === 4 && mcount === "17/30/30/20", `Mole cells per tree ${mcount}, want 17/30/30/20 (Engineer/Bomber/Machinist/War Machine)`);
  ok(MOLE.map(t => t.name).join() === "Engineer,Bomber,Machinist,War Machine", "Mole tree names");
  for (const id in mcells) { ok(!!SKILL_ICONS[mcells[id].icon], `Mole cell ${id} icon ${mcells[id].icon} missing`); ok(mcells[id].req.every(r => mcells[r]), `Mole cell ${id} requires a skill that is not in the grid`); }
  const byLabel = (l) => +Object.keys(mcells).find(i => mcells[i].name === l);
  const factory = byLabel("War Factory"), capital = byLabel("War Capital");
  ok(mcells[factory].req.length === 2 && mcells[factory].lv === 75 && mcells[capital].req.join() === String(factory), "War Factory needs two skills from trees 2 and 3 (rSkill 243343) and War Capital needs War Factory");
  const mauto = (set, lv, id) => auto(mcells, 4, new Set(set), lv, id);
  ok(mauto([], 95, factory) === null && mauto([], 95, capital) === null, "Mole: War Factory and War Capital are never one-click (Class C)");
  // Values taken straight from MoleSkill (decoder + hand check): Extra Powder II / Heavy Built II come from an empty getSkill branch (Lv 28; the 2014 simulator and the TailsTails site say 27) and need a live check.
  const lvOf = (l) => mcells[byLabel(l)] && mcells[byLabel(l)].lv + "/" + mcells[byLabel(l)].bn;
  ok(lvOf("Extra Powder 1") === "24/15" && lvOf("Extra Powder 2") === "28/18" && lvOf("Extra Powder 3") === "30/21", "Extra Powder I-III Lv/points from the game code");
  // All 12 classes (2026-10-12): every grid has the size the game code gives it, every icon exists, every prerequisite is in the grid,
  // and each class's last Class C skill can be learned in one click at Lv 95 (not at Lv 50).
  const ALL = vm.runInContext("SKILL_SIM", sandbox), NAMES = vm.runInContext("SKILL_SIM_NAMES", sandbox), ORDER = vm.runInContext("CLASS_ORDER", sandbox);
  const SIZES = { rabbit: "18/30/30/20", mole: "17/30/30/20", bat: "15/30/30/20", bison: "17/30/30/20", cat: "17/30/30/20", chameleon: "17/30/30/20", monkey: "17/30/30/20", panda: "17/30/30/20", penguin: "16/30/30/20", sheep: "16/30/30/20", whale: "16/30/30/20", wolf: "16/30/30/20" };
  ok(Object.keys(ALL).sort().join() === Object.keys(SIZES).sort().join() && ORDER.every(n => ALL[n.toLowerCase()] && NAMES[n.toLowerCase()] === n), "every class of the class gate has simulator data and a display name");
  for (const cls in SIZES) {
    const trees = ALL[cls], cs = cellsFn(trees);
    ok(trees.length === 4 && trees.map(t => t.rows.flat().filter(Boolean).length).join("/") === SIZES[cls], `${cls}: cells per tree ${trees.map(t => t.rows.flat().filter(Boolean).length).join("/")}, want ${SIZES[cls]}`);
    ok(trees.every(t => t.name), `${cls}: tree names`);
    for (const id in cs) { ok(!!SKILL_ICONS[cs[id].icon], `${cls} cell ${id} icon ${cs[id].icon} missing`); ok(cs[id].req.every(r => cs[r]), `${cls} cell ${id} requires a skill that is not in the grid`); }
    // Class C is never one-click: its first skill (401) needs its prerequisite learned first (one click for that Basic / A / B skill), then it is added alone.
    const need = cs[401].req[0], pre = auto(cs, 4, new Set(), 95, need), one = pre && auto(cs, 4, pre, 95, 401);
    ok(need < 400 && pre && auto(cs, 4, new Set(), 95, 401) === null && one && one.size === pre.size + 1 && validFn(cs, 4, one, 95) && auto(cs, 4, pre, 54, 401) === null, `${cls}: Class C skill 401 is refused without its prerequisite, added alone with it, refused below Lv 55`);
  }
  // Servers (2026-10-12, user): BB 95 forever, TTO 95 for now, ToT 100. Each server has its own cap and its own cell patches (empty = same as BB).
  const SRV = vm.runInContext("SKILL_SIM_SERVERS", sandbox);
  const LVCAP = vm.runInContext("LEVEL_CAP", sandbox);
  ok(LVCAP.og === 95 && LVCAP.tot === 110 && LVCAP.tto === 110, "LEVEL_CAP: BB 95, ToT 110, TTO 110 (user 2026-10-19)");
  ok(Object.keys(SRV).join() === "og,tot,tto,reborn" && ["og", "tot", "tto"].every(k => SRV[k].cap === LVCAP[k]) && SRV.reborn.cap === 150, "server caps follow LEVEL_CAP (BB 95, ToT 110, TTO 110) and Reborn 150");
  ok(poolMaxC(95) === 9 && poolMaxC(100) === 10, "Class C points: 9 at Lv 95, 10 at Lv 100");
  for (const k of Object.keys(SRV)) {
    ok(!!SRV[k].name && !!SRV[k].full && !!SKILL_ICONS["server_" + k], `server ${k}: names and icon`);
    for (const c of Object.keys(SRV[k].patch)) {
      ok(!!ALL[c], `server ${k}: patch for an unknown class ${c}`);
      const base = cellsFn(ALL[c]), pat = cellsFn(ALL[c], SRV[k].patch[c]);
      for (const id in SRV[k].patch[c]) {
        ok(!!base[id], `server ${k} ${c}: patch for a cell that is not in the grid (${id})`);
        ok(pat[id].req.every(r => pat[r]) && Number.isInteger(pat[id].lv) && Number.isInteger(pat[id].bn), `server ${k} ${c} ${id}: patched values`);
        ok(+id >= 400 || auto(pat, 4, new Set(), SRV[k].cap, +id) !== null, `server ${k} ${c} ${id}: still learnable in one click at Lv ${SRV[k].cap}`);
      }
    }
  }
  ok(cellsFn(ALL.panda)[443].req.join() === "334" && cellsFn(ALL.panda, SRV.og.patch.panda)[443].req.join() === "334" && cellsFn(ALL.panda, SRV.tto.patch.panda)[443].req.join() === "344", "Panda Heaven Breath needs Shadow Fist IV (334) on BB and in the game code, Sacred Sage Technique II (344) on TTO (TailsTopia)");
  for (const cls in SIZES) {
    const cs = cellsFn(ALL[cls], SRV.tot.patch[cls]);
    const pre = auto(cs, 4, new Set(), SRV.tot.cap, cs[401].req[0]);
    ok(pre && auto(cs, 4, pre, SRV.tot.cap, 401) !== null, `ToT ${cls}: Class C skill 401 is added alone at Lv 100 once its prerequisite is learned`);
  }
  // Long press opens the skill card (user 2026-10-12): every cell resolves to an existing card id (Cat Power One / Two / Three open Power Seven).
  const cardOf = vm.runInContext("skillSimCardId", sandbox), cardIds = new Set(vm.runInContext("SKILLS", sandbox).map(s => s.id));
  const noCard = [], allSim = vm.runInContext("SKILL_SIM", sandbox);
  for (const cl in allSim) for (const tr of allSim[cl]) for (const r of tr.rows) for (const x of r) if (x && !cardIds.has(cardOf(x[0]))) noCard.push(x[0]);
  ok(noCard.length === 0 && cardOf("cat_powerTwo2") === "cat_powerSeven" && cardOf("rabbit_nAttack3") === "rabbit_nAttack" && cardOf("panda_rain&storm2") === "panda_rain&storm" && cardOf("statPlus2") === "common_statPlus" && cardOf("rabbit_revisedArt5") === "common_revisedArt", "long press: skill simulator cells map to skill card ids (" + noCard.join(",") + " have no card)");
  // Plus markers (user 2026-10-12): Basic / A / B green = reached by levelling only its own row, red = other rows involved too; Class C stays yellow and single-click.
  const MK = vm.runInContext("skillSimMarker", sandbox), M = (set, lv, id) => MK(cells, SIM.length, new Set(set), lv, id);
  ok(M([], 95, 201) === "green" && M([], 95, 202) === "green" && M([], 95, 204) === "green", "Maim Shot I-IV: green (only its own row is levelled)");
  ok(M([], 95, 211) === "red" && M([], 95, 254) === "red" && M([201], 95, 211) === "green", "Mix I needs one more skill in tree A: red, then green once Maim Shot I is learned; Life Shot: red");
  ok(M([], 55, 404) === "yellow" && M([], 54, 404) === "" && M([], 1, 201) === "", "a Class C skill with nothing missing is yellow; out of level or of points: no marker");
  ok(M([], 95, 401) === "" && M([101, 102, 103, 104], 95, 401) === "yellow", "Bouncing Bullet has no marker while Long Shot IV is missing (a Class C click never pulls other rows in), yellow once it is learned");
  // Learned frames follow the actual unlearn click, including rank removal and point prerequisites.
  const UM = vm.runInContext("skillSimUnlearnMarker", sandbox), U = (set, id) => UM(cells, SIM.length, new Set(set), 95, id);
  ok(U([], 201) === "" && U([201], 201) === "green", "unlearned frames stay neutral; an isolated learned skill is removable");
  ok(U([201, 202], 201) === "green" && U([201, 202], 202) === "green", "removing a rank and its higher ranks is green when the remaining build is valid");
  ok(U([201, 211], 201) === "red" && U([201, 211], 211) === "green", "Maim Shot stays red while Mix needs its tree point; Mix is removable");
  ok(U([101, 102, 103, 104, 401], 104) === "red" && U([101, 102, 103, 104, 401], 101) === "red" && U([101, 102, 103, 104, 401], 401) === "green", "Class C protects its prerequisite and earlier ranks, while Class C itself can be removed");
  ok(U([101, 102, 103, 104], 104) === "green", "removing the dependent skill releases its prerequisite");
}

// Expert guide building (2026-10-17): skillSimProblems lists exactly what skillSimValid rejects (empty <=> valid, all 12 classes with ToT EX, random builds),
// every published guide is clean, the rules are named, and skillSimBudgetOk only checks the level and the pools.
{
  const ALL = vm.runInContext("SKILL_SIM", sandbox), EXS = vm.runInContext("SKILL_SIM_EX", sandbox), cellsFn = vm.runInContext("skillSimCells", sandbox), valid = vm.runInContext("skillSimValid", sandbox);
  const probs = vm.runInContext("skillSimProblems", sandbox), budget = vm.runInContext("skillSimBudgetOk", sandbox), guideProbs = vm.runInContext("classGuideBuildProblems", sandbox), guides = vm.runInContext("CLASS_GUIDES", sandbox);
  const ok = (pass, msg) => { if (pass) checkedRsim++; else { console.error("[SKILL SIM ERROR] expert mode: " + msg); errorCount++; } };
  let seed = 20261017; const rnd = () => (seed = (seed * 1103515245 + 12345) % 2147483648) / 2147483648;
  let agree = 0, cases = 0;
  for (const cls in ALL){
    const cs = cellsFn(ALL[cls], null, EXS[cls]), names = ALL[cls].map(t => t.name), ids = Object.keys(cs).map(Number);
    for (let k = 0; k < 80; k++){
      const rate = [0.05, 0.2, 0.5, 0.9][k % 4], lv = [30, 95, 100, 120][(k >> 2) % 4], set = new Set(ids.filter(() => rnd() < rate));
      cases++; if ((probs(cs, names, set, lv).length === 0) === valid(cs, 4, set, lv)) agree++;
    }
  }
  ok(agree === cases, "problems empty exactly when the build is valid (" + agree + "/" + cases + " random builds)");
  ok(guides.every(g => guideProbs(g.build).length === 0), "every published guide build has no problems");
  const R = cellsFn(ALL.rabbit), rn = ALL.rabbit.map(t => t.name), rule = (set, lv) => probs(R, rn, new Set(set), lv).map(x => x.rule).sort().join();
  const lower = Object.keys(R).map(Number).find(id => id < 400 && id % 10 === 2 && !R[id].req.length && R[id].bn === 0 && R[id - 1].bn === 0 && R[id].lv <= 95);
  ok(lower && rule([lower], 95) === "lower", "a rank without the rank before it is a 'lower' problem");
  const gated = Object.keys(R).map(Number).find(id => id < 400 && id % 10 === 1 && !R[id].req.length && R[id].bn > 0 && R[id].lv <= 95);
  ok(gated && rule([gated], 95) === "tree" && probs(R, rn, new Set([gated]), 95)[0].text.includes(rn[R[gated].tree]), "a skill above its tree's rank threshold names the tree");
  ok(gated && budget(R, new Set([gated]), 95) && !budget(R, new Set([gated]), R[gated].lv - 1), "the budget check ignores thresholds but keeps the level");
}
// ToT EX: published server allocation rules, independent pools and reset pruning.
{
  const EX = vm.runInContext("SKILL_SIM_EX", sandbox), ALL = vm.runInContext("SKILL_SIM", sandbox);
  const cellsFn = vm.runInContext("skillSimCells", sandbox), valid = vm.runInContext("skillSimValid", sandbox), auto = vm.runInContext("skillSimAutoLearn", sandbox);
  const pool = vm.runInContext("skillSimPoolMaxEx", sandbox), clear = vm.runInContext("skillSimClearTree", sandbox), unlearn = vm.runInContext("skillSimUnlearnMarker", sandbox);
  const ok = (pass, msg) => { if (pass) checkedRsim++; else { console.error("[SKILL SIM ERROR] ToT EX: " + msg); errorCount++; } };
  [[1,0],[94,0],[95,1],[99,1],[100,2]].forEach(([lv,n]) => ok(pool(lv) === n, "pool at level " + lv));
  const expected = { bat:[[254],[354],[422]], bison:[[204,402,431,254],[354],[354]], monkey:[[254,402,432],[354,433],[372,403]], panda:[[254],[354],[364,443]], penguin:[[254,244],[354,413,443],[271,444]], wolf:[[254],[354],[422]] };
  ok(Object.keys(EX).sort().join() === Object.keys(ALL).sort().join(), "all 12 classes covered");
  for (const cls in EX){
    const cs = cellsFn(ALL[cls], null, EX[cls]), base = cellsFn(ALL[cls]);
    ok(EX[cls].map(c => c.id).join() === "451,452,453,454,461" && !base[451], cls + " ToT-only slots");
    ok(valid(cs,4,new Set([451]),95) && valid(cs,4,new Set([461]),95) && !valid(cs,4,new Set([451]),94), cls + " passive level gates");
    ok(!valid(cs,4,new Set([451,461]),100), cls + " passive mutual exclusion");
    ok(!valid(base,4,new Set([451]),95), cls + " EX rejected outside ToT without throwing");
    for (const c of EX[cls]){
      ok(c.req.every(id => cs[id]), cls + " prerequisite ids for " + c.id);
      if (!c.placeholder) ok(!!SKILL_ICONS[c.icon] && (() => { const cid = vm.runInContext("skillSimCardId", sandbox)(c.icon), card = SKILLS.find(s => s.id === cid); return cid === "" || (card && card.soon === "tot"); })(), cls + " embedded icon, and no detail card or a coming-soon stub card " + c.id);
      if (c.id === 451 || c.id === 461) continue;
      ok(c.lv === 100 && c.bn === 6 && c.choice === "row5", cls + " class EX gate " + c.id);
      if (!expected[cls]) { ok(c.placeholder && auto(cs,4,new Set(),100,c.id) === null, cls + " unpublished slot unavailable"); continue; }
      ok(c.req.join() === expected[cls][c.id-452].join() && !c.placeholder, cls + " exact published prerequisites " + c.id);
      // Build a viable ordinary layout, taking cheapest valid C choices when additional C points are needed.
      let set = new Set();
      const addCheapC = () => {
        let best = null;
        for (const id in base){
          if (+id < 400 || set.has(+id)) continue;
          let trial = new Set(set);
          for (const r of cs[id].req) { if (r >= 400) { trial = null; break; } trial = auto(cs,4,trial,100,r); if (!trial) break; }
          if (!trial) continue;
          trial = auto(cs,4,trial,100,+id);
          if (trial && (!best || trial.size < best.size)) best = trial;
        }
        if (!best) return false; set = best; return true;
      };
      const need = id => {
        if (set.has(id)) return true;
        if (id < 400) { const next = auto(cs,4,set,100,id); if (!next) return false; set = next; return true; }
        if (!cs[id].req.every(need)) return false;
        while ([...set].filter(i => i >= 400).length < cs[id].bn) if (!addCheapC()) return false;
        const next = auto(cs,4,set,100,id); if (!next) return false; set = next; return true;
      };
      let ready = c.req.every(need);
      while (ready && [...set].filter(i => i >= 400).length < 6) ready = addCheapC();
      const learned = ready && auto(cs,4,set,100,c.id);
      ok(learned && learned.size === set.size+1 && valid(cs,4,learned,100), cls + " class EX learns alone with viable prerequisites " + c.id);
      if (!learned) continue;
      ok(auto(cs,4,set,99,c.id) === null, cls + " class EX refuses level 99 " + c.id);
      const plus = auto(cs,4,learned,100,451);
      ok(plus && plus.size === learned.size+1 && valid(cs,4,plus,100), cls + " class EX plus passive uses 2 independent EX points " + c.id);
      const other = c.id === 452 ? 453 : 452;
      ok(!valid(cs,4,new Set([...learned,other]),100), cls + " only one class EX choice " + c.id);
      for (const req of c.req) ok(unlearn(cs,4,learned,100,req) === "red", cls + " prerequisite refund protected " + req);
      for (let tree=0;tree<4;tree++) ok(valid(cs,4,clear(cs,4,learned,100,tree),100), cls + " reset tree " + tree + " leaves valid EX layout " + c.id);
      // With exactly six C skills, EX cannot subsidise removing an ordinary C point.
      const ordinary = [...set].filter(i => i >= 400);
      if (ordinary.length === 6) for (const id of ordinary) ok(unlearn(cs,4,learned,100,id) === "red", cls + " six-C threshold refund protected " + id);
    }
  }
  // A minimal model isolates the two-way separation: neither pool can fund the other.
  const model = {401:{id:401,tree:3,lv:55,bn:0,req:[]},402:{id:402,tree:3,lv:55,bn:1,req:[]},451:{id:451,tree:3,lv:95,bn:0,req:[],ex:true,exclude:[],choice:""}};
  ok(!valid(model,4,new Set([402,451]),100), "EX point cannot satisfy an ordinary C tree threshold");
  ok(valid(model,4,new Set([401,402,451]),100), "ordinary C thresholds unaffected by learned EX");
}

// Exercise the mounted simulator's controls without a browser or screenshots.
{
  const ok = (pass, msg) => { if (pass) checkedRsim++; else { console.error("[SKILL SIM ERROR] mounted EX: " + msg); errorCount++; } };
  const doc = sandbox.document, saved = { create:doc.createElement, add:doc.addEventListener, storage:sandbox.localStorage, server:sandbox.openSimServerGate, gate:sandbox.openClassPickerModal, theme:sandbox.setToolServer, timer:sandbox.setTimeout, cancel:sandbox.clearTimeout, winAdd:sandbox.window.addEventListener, winOpen:sandbox.window.open, href:sandbox.location.href };
  let serverGate, classGate, clock = 0, serial = 0;
  const timers = new Map(), windowListeners = {}, opened = [];
  const tick = ms => { const end = clock + ms; for (;;) { const due = [...timers].filter(([,t])=>t.at<=end).sort((a,b)=>a[1].at-b[1].at)[0]; if(!due)break;clock=due[1].at;timers.delete(due[0]);due[1].fn(); } clock=end; };
  const emitWindow = type => (windowListeners[type] || []).forEach(fn=>fn({}));
  const mk = () => {
    const e = makeEl(), classes = new Set(); e.children = []; e.listeners = {};
    e.appendChild = c => { e.children.push(c); return c; }; e.append = (...cs) => cs.forEach(e.appendChild);
    Object.defineProperty(e,"textContent",{get:()=>e._text || "",set:v=>{e._text=v;e.children=[];}});
    e.classList = { add:c=>classes.add(c),remove:c=>classes.delete(c),toggle:(c,on)=>{if(on)classes.add(c);else classes.delete(c);},contains:c=>classes.has(c)||e.className?.split(" ").includes(c) };
    e.addEventListener = (k,fn) => { (e.listeners[k] ||= []).push(fn); };
    e.querySelectorAll = sel => { const found=[];const walk=n=>{for(const c of n.children){if(sel.startsWith(".")&&c.classList.contains(sel.slice(1)))found.push(c);walk(c);}};walk(e);return found; };
    return e;
  };
  const root = mk(), registry = new Map();
  root.querySelector = sel => { if (!registry.has(sel)) registry.set(sel,mk()); return registry.get(sel); };
  root.querySelectorAll = sel => root.querySelector('[data-role="trees"]').querySelectorAll(sel);
  const el = role => root.querySelector('[data-role="'+role+'"]');
  const click = target => root.listeners.click.forEach(fn=>fn({target:{closest:sel=>sel === ".rsim-cell" ? (target.dataset.id ? target : null) : sel === "[data-act]" ? target : null}}));
  const action = act => click({dataset:{act}});
  const cell = id => root.querySelectorAll(".rsim-cell").find(c=>+c.dataset.id===id);
  try {
    doc.createElement = mk; doc.addEventListener = () => {};
    sandbox.setTimeout = (fn,ms) => { const id=++serial;timers.set(id,{fn,at:clock+ms});return id; };
    sandbox.clearTimeout = id => timers.delete(id);
    sandbox.window.addEventListener = (type,fn) => { (windowListeners[type] ||= []).push(fn); };
    sandbox.window.open = (...args) => opened.push(args); sandbox.location.href = "https://example.invalid/bible/#class-guide";
    sandbox.localStorage = {getItem:()=>JSON.stringify({srv:"tot",cls:"wolf"}),setItem:()=>{}};
    sandbox.openSimServerGate = opts => {serverGate=opts;}; sandbox.openClassPickerModal = opts => {classGate=opts;}; sandbox.setToolServer = () => {};
    vm.runInContext("mountSkillSimulator",sandbox)(root);
    ok(!!cell(451) && !!cell(461) && !el("exPool").hidden && el("ptsEx").value === "2/2", "remembered ToT mount includes EX grid and pool");
    const down = target => root.listeners.pointerdown.forEach(fn=>fn({target:{closest:()=>target},pointerType:"mouse",button:0,clientX:0,clientY:0}));
    const up = () => root.listeners.pointerup.forEach(fn=>fn({}));
    // Repeated quick presses learn immediately, without starting animation or leaving tab timers.
    for (const id of [101,102,103,111]){
      down(cell(id)); tick(60); ok(!cell(id).classList.contains("is-charging"), "quick click has no hold animation");
      up(); click(cell(id)); ok(cell(id).classList.contains("is-learned"), "rapid click learns rank " + id);
    }
    tick(600); ok(opened.length === 0 && timers.size === 0, "rapid learning leaves no delayed new tabs");
    // The builder never long-presses (user 2026-10-15): a hold gives no feedback, opens nothing, and the click still learns.
    const beforeBuildHold = el("pts").value;
    down(cell(111)); tick(200); ok(!cell(111).classList.contains("is-charging") && timers.size === 0, "builder hold has no feedback or timers");
    tick(400); up(); ok(opened.length === 0 && el("pts").value === beforeBuildHold, "builder hold opens no card and spends nothing");
    // The class guide view (read) is where a deliberate hold opens the skill card.
    root._skillSim.setInteraction("read");
    const beforeHold = el("pts").value;
    down(cell(111)); tick(200); ok(cell(111).classList.contains("is-charging") && opened.length === 0, "view: deliberate hold receives feedback before opening");
    tick(299); ok(opened.length === 0, "view: hold does not open before 500 ms");
    tick(1); up(); click(cell(111));
    ok(opened.length === 1 && opened[0][0].includes("#skill-details/wolf_") && opened[0][0].endsWith("?server=tot") && el("pts").value === beforeHold, "view: 500 ms hold opens correct card once and the click after it is swallowed");
    tick(400);
    down(cell(111)); tick(200); emitWindow("pointerup"); tick(600);
    ok(opened.length === 1 && !cell(111).classList.contains("is-charging"), "view: outside release cancels feedback and new tab");
    down(cell(111)); tick(200); emitWindow("blur"); tick(600);
    ok(opened.length === 1 && timers.size === 0, "view: window blur cancels pending hold");
    down(cell(111)); root.listeners.pointermove.forEach(fn=>fn({clientX:9,clientY:0})); tick(600);
    ok(opened.length === 1 && timers.size === 0, "view: drag beyond threshold cancels hold");
    root._skillSim.setInteraction("annotate");
    down(cell(111)); tick(700); ok(opened.length === 1 && !cell(111).classList.contains("is-charging") && timers.size === 0, "note editor: hold opens nothing");
    up(); root._skillSim.setInteraction("build");
    action("reset");
    click(cell(451));
    { const full = (x) => { const [r, m] = String(x).split("/"); return r === m && +m > 0; }; ok(el("ptsEx").value === "1/2" && full(el("ptsC").value) && full(el("pts").value), "learning passive spends EX alone (normal and C pools untouched at the cap)"); }
    action("server"); serverGate.onSelect("og");
    ok(!cell(451) && el("exPool").hidden && el("lv").value === 95, "switching to BB removes EX rows and hides counter");
    action("undo");
    ok(!!cell(451) && !el("exPool").hidden && el("ptsEx").value === "1/2" && cell(451).classList.contains("is-learned"), "undo restores ToT grid, EX selection and counter");
    for (const name of vm.runInContext("CLASS_ORDER",sandbox)){
      action("pick"); classGate.onSelect(name);
      const placeholder = ["Cat","Chameleon","Mole","Rabbit","Sheep","Whale"].includes(name);
      ok(!!cell(452) && !!cell(461) && cell(452).classList.contains("is-placeholder") === placeholder && cell(451).classList.contains("is-passive"), name + " mounts correct EX slots and frames");
      if (placeholder){ click(cell(452)); ok(el("ptsEx").value === "2/2", name + " placeholder click cannot spend points"); }
    }
    ok(html.includes(".rsim-ex-pool[hidden]{display:none;}") && html.includes(".rsim.locked .rsim-trees{visibility:hidden}") && !html.includes("\n.rsim-trees{visibility:hidden}"), "counter hidden CSS and gate visibility remain scoped");
  } catch(e){ok(false,"UI threw: " + e.message);}
  finally { doc.createElement=saved.create;doc.addEventListener=saved.add;sandbox.localStorage=saved.storage;sandbox.openSimServerGate=saved.server;sandbox.openClassPickerModal=saved.gate;sandbox.setToolServer=saved.theme;sandbox.setTimeout=saved.timer;sandbox.clearTimeout=saved.cancel;sandbox.window.addEventListener=saved.winAdd;sandbox.window.open=saved.winOpen;sandbox.location.href=saved.href; }
}

// Class Guide portability and reader permissions: independent serialized fixtures.
{
  const norm = vm.runInContext("classGuideNormalize", sandbox), encode = vm.runInContext("classGuideExport", sandbox), decode = vm.runInContext("classGuideImport", sandbox);
  const ok = (pass, msg) => { if (pass) checkedRsim++; else { console.error("[CLASS GUIDE ERROR] " + msg); errorCount++; } };
  const rejects = (fn, msg) => { let threw=false;try{fn();}catch(e){threw=true;}ok(threw,msg); };
  const rich = vm.runInContext("classGuideRichText", sandbox), bold = vm.runInContext("classGuideBoldEdit", sandbox);
  ok(rich("Line **ทอง\nไทย** & <img src=x onerror=alert(1)>") === "Line <strong>ทอง\nไทย</strong> &amp; &lt;img src=x onerror=alert(1)&gt;", "bold multiline guide text renders without authored HTML");
  ok(rich("unfinished **bold") === "unfinished **bold", "unfinished bold markers remain readable text");
  const applyBold = (text, start, end, max=12000) => { const e=bold(text,start,end,max); return e && {value:text.slice(0,e.from)+e.text+text.slice(e.to),start:e.selectionStart,end:e.selectionEnd}; };
  const readEditor = vm.runInContext("classGuideReadEditor", sandbox);
  const tx = text => ({nodeType:3,nodeValue:text}), tag = (name,...children) => ({nodeType:1,tagName:name,childNodes:children});
  ok(readEditor(tag("ROOT",tx("ก่อน "),tag("STRONG",tx("ไทย")),tag("DIV",tx("บรรทัดสอง")))) === "ก่อน **ไทย**\nบรรทัดสอง", "rich editor serializes bold and block line breaks into portable markup");
  ok(readEditor(tag("ROOT",tx("first"),tag("DIV",tag("BR")))) === "first\n", "rich editor handles the empty line created by Enter");
  ok(readEditor(tag("ROOT",tag("DIV",tx("one")),tag("DIV",tx("two")),tx("!"))) === "one\ntwo\n!", "rich editor keeps adjacent blocks and inline text on their intended lines");
  // the description editor holds one block per line (user 2026-10-21: step 1's live box pages like the guide page), and a blank line survives the round trip
  ok(readEditor(tag("ROOT",tag("DIV",tx("a")),tag("DIV",tag("BR")),tag("DIV",tx("b")))) === "a\n\nb" && readEditor(tag("ROOT",tx("first"),tag("DIV",tag("BR")),tag("DIV",tx("x")))) === "first\n\nx", "rich editor keeps a blank line typed between two lines");
  const editHtml = vm.runInContext("classGuideEditHtml", sandbox);
  ok(editHtml("a\n\n**b**\nStatus:") === '<div>a</div><div><br></div><div><strong>b</strong></div><div class="is-head">Status:</div>' && editHtml("") === "", "the description editor renders one block per line, a heading line marked like the guide page");
  // column breaks (user 2026-10-21: start in column 3 without typing 1 and 2): a line holding only ⇥ is an empty block the editor cannot type into, read back as the same line
  ok(editHtml("⇥\n⇥\nC") === '<div class="is-colbreak" contenteditable="false">⇥</div><div class="is-colbreak" contenteditable="false">⇥</div><div>C</div>' && readEditor(tag("ROOT",tag("DIV",tx("⇥")),tag("DIV",tx("⇥")),tag("DIV",tx("C")))) === "⇥\n⇥\nC", "the description editor keeps column breaks as their own lines");
  // a click anywhere in a <label> goes to its first labelable element (user 2026-10-21: the column buttons came first, so every click in the box chose 1 column and stole the focus)
  ok(/<label class="cg-description"><textarea data-cg-field="description"[^>]*\bhidden\b/.test(html), "the description label starts with its hidden textarea, so a click in the box never presses a column button");
  const emphasized = applyBold("before ไทย after",7,10);
  ok(emphasized.value === "before **ไทย** after" && emphasized.start === 9 && emphasized.end === 12, "Ctrl+B emphasizes selected Thai text and keeps it selected");
  const unbold = applyBold(emphasized.value,emphasized.start,emphasized.end);
  ok(unbold.value === "before ไทย after" && unbold.start === 7 && unbold.end === 10, "second Ctrl+B removes surrounding emphasis");
  ok(applyBold("**gold**",0,8).value === "gold", "Ctrl+B removes selected markers too");
  ok(bold("text",1,1,3000) === null && bold("text",0,4,7) === null, "shortcut leaves empty selections and full fields unchanged");
  const shotDoc = sandbox.document, createBefore = shotDoc.createElement, dots=[];
  try {
    shotDoc.createElement = () => { const d={style:{},removed:false,remove(){this.removed=true;},animate(frames,opts){this.frames=frames;this.opts=opts;return this.animation={cancel(){this.cancelled=true;}};}};dots.push(d);return d; };
    let hits=0;const host={appendChild(){}};
    const cancel=vm.runInContext("fireShot",sandbox)({x:10,y:20},{x:110,y:20},false,()=>hits++,host);
    ok(dots.length === 3 && dots.every(d=>d.className === "sk-shot") && dots[0].frames[5].transform.includes("-35px"), "shared light ball has two trailing dots and an arcing flight");
    dots[1].animation.onfinish();dots[2].animation.onfinish();ok(hits === 0,"trailing balls cannot reveal the note early");
    dots[0].animation.onfinish();ok(hits === 1,"head arrival reveals the note exactly once");
    cancel();ok(dots.every(d=>d.removed && d.animation.cancelled && !d.animation.onfinish),"closing a note cancels and removes every light ball");
  } finally { shotDoc.createElement=createBefore; }
  const embedded = vm.runInContext("CLASS_GUIDES", sandbox);
  ok(Array.isArray(embedded), "embedded guides use a data array");
  { const ids = embedded.map((g, i) => Number.isInteger(g.id) && g.id > 0 ? String(g.id) : String(i + 1)); ok(new Set(ids).size === ids.length, "embedded guide numbers are unique (link #skill-simulator/<number>): " + ids.join(", ")); embedded.forEach((g, i) => ok(Number.isInteger(g.id) && g.id > 0, "embedded guide " + (i + 1) + " has a running number id (1, 2, 3 ...)")); }
  embedded.forEach((guide,i) => { try { norm(guide); ok(true,"embedded guide " + (i+1) + " validates"); } catch(e){ ok(false,"embedded guide " + (i+1) + ": " + e.message); } });
  const fixture = { cover:[101],modes:["pve"],format:"12t-class-guide",version:1,title:"Wolf guide",author:"ผู้เขียน 🐺",date:"2026-10-16",description:"First line\nSecond line",build:{server:"tot",classKey:"wolf",level:100,learned:[451,101,102,103]},notes:{"103":"Why this rank\n<script>alert('x')</script>","201":"Why I skipped this skill"} };
  const round = decode(encode(fixture));
  ok(round.author === fixture.author && round.description === fixture.description && round.notes[103] === fixture.notes[103] && round.notes[201] === fixture.notes[201], "UTF-8, multiline notes and skipped-skill notes round-trip as plain text");
  ok(round.build.learned.join() === "101,102,103,451", "export normalizes build ordering");
  for (const server of ["og", "tot", "tto"]){
    const tagged = {...fixture, build:{...fixture.build,server,level:server === "tot" ? 100 : 95,learned:[101,102,103]}};
    const code = encode(tagged), restored = decode(code);
    ok(JSON.parse(code).build.server === server && restored.build.server === server && restored.build.level === tagged.build.level, "export/import preserve " + server + " server tag and level");
  }
  const change = patch => ({...fixture,...patch});
  rejects(()=>decode("not JSON"),"reject malformed codes"); rejects(()=>decode("x".repeat(131073)),"limit import size");
  rejects(()=>norm(change({version:2})),"reject unsupported format version"); rejects(()=>norm(change({author:""})),"require author for export"); ok(norm(change({date:""})).date === "" && !html.includes('data-cg-field="date"'), "a guide needs no date from the author, the editor has no date field (the upload stamps it, user 2026-10-23)");rejects(()=>norm(change({date:"2026-02-30"})),"reject an impossible date");rejects(()=>norm(change({date:"16/10/2026"})),"reject a date in the wrong format");
  ok(html.split('<span>คัดลอกรูป</span></button>').length - 1 === 2 && html.includes('{ act: "copyImage", icon: "copy"') && vm.runInContext("CLASS_GUIDE_COPY_MAX", sandbox) < 10e6 && vm.runInContext("typeof classGuideCopyImage", sandbox) === "function", "คัดลอกรูป sits in the reader row, step 6 and the guide menu, and its 2K fallback starts below Discord's 10 MB");
  { const day = n => new Date(Date.now() + n * 864e5).toISOString().slice(0, 10);   // the embedded date is the upload day: no later than tomorrow (UTC), which also stops a Buddhist-era year
    ok(norm(change({date:"2569-10-20"})).date === "", "a Buddhist-era year (20/10/2569 wrapped to 2031-07-05 in two codes) is dropped, not kept"); ok(norm(change({date:day(2)})).date === "", "a guide date after tomorrow (UTC) is dropped");
    ok(norm(change({date:day(0)})).date === day(0) && norm(change({date:day(1)})).date === day(1), "today and tomorrow (UTC) pass, so a guide uploaded today in Thailand never looks future");
    ok(norm(change({date:day(0)}),{draft:true}).date === "" && norm(change({date:"2569-10-20"}),{draft:true}).date === "", "the author's draft carries no date: an imported code's date is dropped (the upload stamps it)");
    const isNew = vm.runInContext("classGuideIsNew", sandbox), t0 = Date.parse("2026-10-23T05:00:00Z"), at = (ms) => new Date(t0 + ms).toISOString().slice(0, 19) + "Z";
    ok(isNew({ published: at(0) }, t0) && isNew({ published: at(0) }, t0 + 864e5 - 1000) && !isNew({ published: at(0) }, t0 + 864e5) && !isNew({ published: at(0) }, t0 + 864e5 + 1000), "a guide is new for 24 hours after its upload stamp");
    ok(!isNew({ date: day(0) }, Date.now()) && !isNew({}, Date.now()) && !isNew(null, Date.now()) && !isNew({ published: "soon" }, Date.now()) && !isNew({ published: at(3 * 36e5) }, t0), "a guide with no stamp (every guide before 2026-10-23), a broken one or one stamped in the future is never new");
    ok(isNew({ published: at(-1000) }, t0 - 5000) && !isNew({ published: at(3 * 36e5) }, t0), "a clock a few seconds behind the stamp still shows the badge");
    ok(/const isNew = g => classGuideIsNew\(g\);/.test(html) && !/isToday|localDay\(/.test(html), "the home slide's ใหม่ badge and ordering use the 24-hour check, not the calendar day");
    const bkk = (iso) => new Date(Date.parse(iso) + 7 * 36e5).toISOString().slice(0, 10);
    vm.runInContext("CLASS_GUIDES", sandbox).forEach(g => { if (g && g.published !== undefined) ok(/^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$/.test(g.published) && !isNaN(Date.parse(g.published)) && g.date === bkk(g.published), "guide #" + g.id + " has a valid upload stamp whose date is that moment's day in Thailand"); }); }
  rejects(()=>norm(change({build:{...fixture.build,server:"og"}})),"reject ToT EX on BB");
  rejects(()=>norm(change({build:{...fixture.build,learned:[102]}})),"reject orphan rank");
  rejects(()=>norm(change({build:{...fixture.build,learned:[101,101]}})),"reject duplicate learned ids");
  rejects(()=>norm(change({build:{...fixture.build,classKey:"constructor"}})),"reject inherited class names");
  rejects(()=>norm(change({build:{...fixture.build,server:["tot"]}})),"require a string server key");
  rejects(()=>norm(change({build:{...fixture.build,server:undefined}})),"require server tag");
  rejects(()=>norm(change({build:{...fixture.build,server:"unknown"}})),"reject unknown server tag");
  rejects(()=>norm(change({notes:{"999":"unknown"}})),"reject unknown note anchor");
  rejects(()=>norm(change({notes:{"451":"x".repeat(3001)}})),"limit per-skill note length");
  rejects(()=>norm(change({build:{...fixture.build,classKey:"cat",learned:[]},notes:{"452":"not published"}})),"reject unpublished EX note anchor");
  ok(norm(change({title:"",author:"",date:""}),{draft:true}).title === "", "allow unfinished local drafts");
  rejects(()=>norm(change({modes:undefined})),"require PVE / PVP for export (user 2026-10-20)"); rejects(()=>norm(change({modes:[]})),"an empty PVE / PVP list is not a choice"); rejects(()=>norm(change({modes:["pvx"]})),"reject an unknown mode");
  ok(norm(change({modes:undefined}),{draft:true}).modes === undefined && norm(change({modes:["pvx"]}),{draft:true}).modes === undefined, "a draft may lack PVE / PVP, and drops an unknown one");
  ok(norm(change({modes:["pvp","pve"]})).modes.join() === "pve,pvp" && decode(encode(change({modes:["pve","pvp"]}))).modes.join() === "pve,pvp", "both modes are kept, in CLASS_GUIDE_MODES order, and survive export / import");
  ok(embedded.every(g => Array.isArray(g.modes) && g.modes.length), "every embedded guide has PVE / PVP (user 2026-10-20)");
  { const old = {...fixture, patch:"1.57"}; delete old.date; const opened = decode(JSON.stringify(old)); ok(opened.date === "" && !("patch" in opened), "an old code with a patch and no date still opens in the editor"); ok(typeof encode(opened) === "string", "and exports without asking for a date"); }
  // Short code (user 2026-10-16): the page's compact form and scripts/guide_code.js agree, and every embedded guide survives the round trip.
  { if (!sandbox.btoa) sandbox.btoa = btoa; if (!sandbox.atob) sandbox.atob = atob;
    const compact = vm.runInContext("classGuideCompact", sandbox), expand = vm.runInContext("classGuideExpand", sandbox), gc = require(path.join(__dirname, "guide_code.js"));
    const same = (x, y) => JSON.stringify(x) === JSON.stringify(y);
    const withStats = norm({...fixture, stats:{agi:120,lck:40}});
    ok(same(expand(compact(norm(fixture))), norm(fixture)) && same(expand(compact(withStats)), withStats), "compact guide form expands back to the same guide (page)");
    ok(same(gc.expand(compact(withStats)), withStats) && same(expand(gc.compact(withStats)), withStats), "page and scripts/guide_code.js use the same compact form");
    ok(same(norm(gc.decode(gc.encode1(withStats))), withStats) && /^12TG1\.[A-Za-z0-9_-]+$/.test(gc.encode1(withStats)), "format 1 codes (12TG1.) still decode");
    ok(gc.encode(withStats).length < gc.encode1(withStats).length * 0.7, "format 2 codes are well under the format 1 length (fixture)");
    // A long text-heavy guide deflates well in both formats (guide 12: 0.72), so an embedded guide only has to be shorter than its format 1 code (user 2026-10-17).
    embedded.forEach((g, i) => { const n = norm(g); ok(same(norm(gc.decode(gc.encode(n))), n) && gc.encode(n).length < gc.encode1(n).length, "embedded guide " + (i + 1) + " round-trips through a format 2 code, shorter than its format 1 code"); });
    // Format 2 (TG2., binary): the page and scripts/guide_code.js write the same bytes and read each other back, emoji and non-Thai text included.
    { const bin = vm.runInContext("classGuideBinary", sandbox), fromBin = vm.runInContext("classGuideFromBinary", sandbox);
      const odd = norm({...fixture, title:"Guide 🐺 **ทอง** ñ é 中文", author:"ผู้เขียน 🐺", description:"บรรทัด 1\nline 2 ✓", stats:{atk:0,lck:512}});
      ok(same(Array.from(bin(odd)), Array.from(gc.classGuideBinary(odd))), "page and scripts/guide_code.js write identical format 2 bytes");
      rejects(()=>bin({...odd, date:"2569-10-20"}), "the page's format 2 encoder refuses a date its 2 bytes cannot hold (never wraps)"); rejects(()=>gc.classGuideBinary({...odd, date:"2569-10-20"}), "guide_code.js refuses it too");
      ok(same(norm(fromBin(bin(odd))), odd) && same(norm(gc.classGuideFromBinary(Buffer.from(bin(odd)))), odd), "format 2 binary reads back emoji, accents, CJK, bold markers, newlines, stat 0 and 512");
      // description columns (user 2026-10-21): 2 or 3 in block 0x43, 1 not stored (older codes unchanged); both codecs and format 1 agree
      const cols3 = norm({...fixture, descCols:3});
      ok(cols3.descCols === 3 && norm({...fixture, descCols:1}).descCols === undefined && same(Array.from(bin(norm(fixture))), Array.from(bin(norm({...fixture, descCols:1})))) && same(Array.from(bin(cols3)), Array.from(gc.classGuideBinary(cols3))) && same(norm(fromBin(bin(cols3))), cols3) && same(norm(gc.classGuideFromBinary(Buffer.from(bin(cols3)))), cols3) && same(expand(gc.compact(cols3)), cols3) && same(gc.expand(compact(cols3)), cols3), "description columns round-trip in both codecs and format 1; one column writes nothing");
      const brk = norm({...fixture, descCols:3, description:"⇥\n⇥\nสาม\n⇥\n\n"});
      ok(brk.description === "⇥\n⇥\nสาม" && same(norm(fromBin(bin(brk))), brk) && same(norm(gc.classGuideFromBinary(Buffer.from(bin(brk)))), brk) && norm({...fixture, description:"⇥\n ⇥ \n"}).description === "", "column breaks: leading ones survive both codecs, trailing ones and a text of only breaks are dropped");
      rejects(()=>norm({...fixture, descCols:4}), "a finished guide refuses 4 description columns"); ok(vm.runInContext("classGuideNormalize", sandbox)({...fixture, descCols:"x"}, { draft:true }).descCols === undefined, "a draft drops a bad column count");
      ok(/^TG2\.[A-Za-z0-9_-]+$/.test(gc.encode2(odd)) && same(norm(gc.decode(gc.encode2(odd))), odd), "guide_code encode2 writes a TG2. code that still decodes to the same guide");
      let threw = false; try { fromBin(bin(odd).subarray(0, 30)); } catch (e) { threw = true; } ok(threw, "a cut-off format 2 code is rejected, not misread");
      // Shares, ตัน / ตาม and the author's order (user 2026-10-18): bit 14 = share, bit 13 = word, an optional 0x4F order block; older codes read the same.
      const OLD = "TG2.AdNNYWdAAwIMDJZqC3UYfzUwMHCF5-ekKaSXZqakMjoyMHgyMgAA";   // written by the pre-flask encoder: wolf, stats {atk:300,cha:250,lck:0}, statsPlus ["cha"]
      const od = gc.decode(OLD);
      ok(JSON.stringify(od.stats) === '{"atk":300,"cha":250,"lck":0}' && od.statsPlus.join() === "cha" && gc.encode2(od) === OLD, "a pre-flask TG2 code decodes the same and re-encodes to the same string");
      // Format 3 (user 2026-10-20: Discord ate "_" pairs as italics): "TG3" + the same bytes at 14 bits per CJK character (U+4E00 + n) + one check character.
      { const toCjk = vm.runInContext("classGuideToCjk", sandbox), fromCjk = vm.runInContext("classGuideFromCjk", sandbox), CJK = /^[一-跿]+$/;
        let agree = true, back = true;
        for (let len = 1; len <= 60; len++){
          const bytes = Array.from({ length: len }, (_, i) => (i * 97 + len * 31) & (i ? 255 : 1));   // byte 0 is the flag byte: 0 or 1
          const p = toCjk(Uint8Array.from(bytes)), n = gc.toCjk(Buffer.from(bytes));
          if (p !== n || !CJK.test(p)) agree = false;
          if (!same(Array.from(fromCjk(p)), Array.from(gc.fromCjk(n)).map(Number)) || !same(Array.from(fromCjk(p)).slice(1), bytes.slice(1)) || (fromCjk(p)[0] & 1) !== bytes[0]) back = false;
        }
        ok(agree, "page and scripts/guide_code.js write the same TG3 characters for 1-60 bytes, all in U+4E00-U+8DFF");
        ok(back, "TG3 characters read back to the same bytes for every length 1-60 (the padding byte is dropped)");
        const code = gc.encode(odd);
        ok(code.startsWith("TG3") && CJK.test(code.slice(3)) && !/[_*~|`>#:\\-]/.test(code), "guide_code encode writes a TG3 code: CJK only, nothing Discord formats");
        ok(same(norm(gc.decode(code)), odd), "a TG3 code decodes to the same guide");
        const pasted = "ไกด์หมาของผม > " + "`" + code.slice(0, 20) + " \n " + code.slice(20, 40) + "\n" + code.slice(40) + "`" + " ขอบคุณครับ";
        ok(same(norm(gc.decode(pasted)), odd), "a TG3 code still decodes inside a Discord message: text around it, backticks, spaces and line breaks");
        const at = 3 + Math.floor((code.length - 3) / 2), broken = code.slice(0, at) + String.fromCharCode(code.charCodeAt(at) ^ 1) + code.slice(at + 1);
        let msg = ""; try { gc.decode(broken); } catch (e) { msg = e.message; }
        ok(/คัดลอกใหม่/.test(msg), "a TG3 code with one changed character is refused with the copy-again message (guide_code.js)");
        rejects(() => fromCjk(broken.slice(3)), "the page refuses it too");
        rejects(() => gc.decode(code.slice(0, -5)), "a TG3 code cut short is refused");
        ok(embedded.every(g => { const n = norm(g), c3 = gc.encode(n); return c3.length < gc.encode2(n).length * 0.5 && c3.length <= 2000; }), "every embedded guide's TG3 code is under half its TG2 length and fits one Discord message (2000 characters)");
      }
      const flask = norm({...fixture, stats:{cha:"ตาม", agi:250, atk:"ตัน", vit:"70%", lck:"30%"}, statsPlus:["agi"]});
      ok(same(Array.from(bin(flask)), Array.from(gc.classGuideBinary(flask))), "page and guide_code.js write the same bytes for shares, words and author order");
      ok(same(norm(fromBin(bin(flask))), flask) && same(norm(gc.decode(gc.encode(flask))), flask), "shares, words, 250+ and the author's order round-trip through TG2");
      const flaskNoPlus = norm({...fixture, stats:flask.stats});   // the decode-only 12TG1 compact form never carried statsPlus (250+), only stats
      ok(same(expand(compact(flaskNoPlus)), flaskNoPlus), "the compact (12TG1) form keeps shares, words and order");
      const base = bin(norm({...fixture, stats:{agi:250}}));   // byte 24 = stats mask (checked 2026-10-18), bytes 25-26 = AGI's value
      ok(base[24] === 1 << 3, "TG2 layout: the stats mask is byte 24");
      ok([0x6001, 0xC032, 0x4000, 0x4065, 0x2002].every(v => { const b = Uint8Array.from(base); b[25] = v & 255; b[26] = v >> 8; try { fromBin(b); return false; } catch (e) { return true; } }), "invalid share / word bits in a TG2 code are rejected");
      // the order block is written last: [0x4F, 5, cha, agi, atk, vit, lck] for the flask guide (indices in CLASS_GUIDE_STAT_KEYS order)
      { const fb = Array.from(bin({ ...flask, modes: undefined })), at = fb.length - 7,   /* checked without the PVE / PVP block, which comes after it (user 2026-10-20) */ head = fb.slice(0, at), blk = fb.slice(at), throws = arr => { try { fromBin(Uint8Array.from(arr)); return false; } catch (e) { return true; } };
        ok(blk[0] === 0x4F && blk[1] === 5 && !throws(fb), "TG2 layout: the flask guide ends with its 7-byte order block");
        const bad = { duplicate: [...head, 0x4F, 5, blk[2], blk[2], blk[4], blk[5], blk[6]], indexEight: [...head, 0x4F, 5, blk[2], blk[3], blk[4], blk[5], 8], missingStat: [...head, 0x4F, 4, blk[2], blk[3], blk[4], blk[5]], extraUnsetStat: [...head, 0x4F, 6, ...blk.slice(2), 1], countZero: [...head, 0x4F, 0], twoBlocks: [...fb, ...blk] };
        ok(Object.values(bad).every(throws), "malformed stat order blocks are rejected (duplicate, index 8, a missing or extra stat, count 0, two blocks)"); }
      for (const v of ["max", "250", 513, -1, "0%", "ตัน "]) rejects(() => gc.encode({...flask, stats:{agi:v}}), "guide_code.js encode refuses stat value " + JSON.stringify(v));
    }
    const all = [101,102,103,104,111,121,131,141,191,194,201,294,301,394,401,411,421,431,441,451,454,461,491,494];
    ok(same(expand(compact({...norm(fixture), build:{...norm(fixture).build, learned:all}})).build.learned, all), "the 160-bit skill set keeps every slot from 101 to 494");
  }
  { const dt = vm.runInContext("classGuideDateText", sandbox); ok(dt("2026-10-16") === "16 ต.ค. 2026" && dt("") === "ยังไม่ระบุวันที่", "guide date shows as day, Thai month, year"); }
  // ความครบถ้วนของเนื้อหา (user 2026-10-20): 3 stars, + half a star each for a description of 70+ letters, 3+ skill notes, any stat, any gear; gallery cards only
  { const comp = vm.runInContext("classGuideCompleteness", sandbox), starsHtml = vm.runInContext("classGuideStarsHtml", sandbox);
    const base = { description: "", notes: {} }, three = { 101: "a", 102: "b", 111: "c" };
    ok(comp(base).stars === 3 && comp({ ...base, description: "ก".repeat(70), notes: three, stats: { atk: 100 }, gear: { weapon: [{ item: "x" }] } }).stars === 5, "a build-only guide gets 3 stars, one with all four parts 5");
    ok(comp({ ...base, description: "ก".repeat(69) }).stars === 3 && comp({ ...base, description: "ก".repeat(70) }).stars === 3.5, "a description counts from 70 letters");
    ok(comp({ ...base, description: "กิ่".repeat(30) + "**" + " \n ".repeat(20) + "**" }).stars === 3, "Thai vowel and tone marks, ** and runs of spaces or line breaks don't make a description count");
    ok(comp({ ...base, notes: { 101: "a", 102: "b" } }).stars === 3 && comp({ ...base, notes: three }).stars === 3.5, "skill notes count from 3 notes");
    ok(comp({ ...base, stats: { agi: 250 } }).stars === 3.5 && comp({ ...base, gear: { pet: [{ item: "x" }] } }).stars === 3.5, "any recommended stat or gear adds half a star");
    const c45 = comp({ ...base, description: "ก".repeat(70), notes: three, gear: { pet: [{ item: "x" }] } });
    ok(c45.stars === 4.5 && /4\.5\/5/.test(c45.label) && /สเตตัส/.test(c45.label) && /ความครบถ้วนของเนื้อหา/.test(c45.label), "the stars' label names the score and what is still missing");
    const h45 = starsHtml(4.5), h3 = starsHtml(3);
    ok((h45.match(/is-full/g) || []).length === 4 && (h45.match(/is-half/g) || []).length === 1 && !/is-empty/.test(h45), "4.5 stars draw as 4 full and 1 half");
    ok((h3.match(/is-full/g) || []).length === 3 && (h3.match(/is-empty/g) || []).length === 2 && !/is-half/.test(h3), "3 stars draw as 3 full and 2 empty");
    ok(embedded.every(g => [3, 3.5, 4, 4.5, 5].includes(comp(norm(g)).stars)), "every embedded guide gets 3-5 stars in half steps");
    ok(/function guideCard\([^]{0,2500}classGuideStarsHtml\(/.test(html) && /function updateSteps\(\)\{[^]{0,4000}classGuideStarsHtml\(/.test(html) && html.split("classGuideStarsHtml(").length - 1 === 3, "the stars are drawn on the gallery card and the editor's live line, nowhere else (not the reader)");
    // The page's own pop-up, not the browser's tooltip (user 2026-10-20); in the editor it shows how far each part is from counting
    const part = (c, key) => c.parts.find(p => p.key === key), mid = comp({ ...base, description: "ก".repeat(25), notes: { 101: "a", 102: "b" }, gear: { pet: [{ item: "x" }] } });
    ok(part(mid, "desc").now === 25 && part(mid, "desc").min === 70 && !part(mid, "desc").ok && part(mid, "notes").now === 2 && part(mid, "notes").min === 3 && part(mid, "gear").ok && !part(mid, "stats").ok, "each part reports whether it counts and, for the description and notes, how far it is");
    const tip = vm.runInContext("classGuideRatingTip", sandbox), tEd = tip(mid, true), tGal = tip(mid, false);
    ok(/ความครบถ้วนของเนื้อหา/.test(tEd) && /3\.5/.test(tEd) && /25\/70/.test(tEd) && /2\/3/.test(tEd) && (tEd.match(/is-miss/g) || []).length === 3 && (tEd.match(/is-ok/g) || []).length === 1, "the editor pop-up names the score and shows 25/70 letters and 2/3 skills");
    ok(!/\/70|\/3 /.test(tGal) && (tGal.match(/is-miss/g) || []).length === 3, "the gallery pop-up lists the parts without the progress numbers");
    ok(!/\.title = done\.label/.test(html) && /data-cg-role="ratingStars"/.test(html), "no browser tooltip on the stars; the editor has its live stars line");
    // the readers badge gets the same pop-up (user 2026-10-20); its "10 นาที" must match the counter query's 10-minute bucket (600000 ms)
    ok(/const viewBadge = [^]{0,1500}classGuideTipBind\(v,/.test(html) && html.includes("อัปเดตทุก 10 นาที หรือนานกว่านั้นถ้าเปิด ad blocker") && html.includes("Math.floor(Date.now() / 600000)"), "the readers badge's pop-up says it updates every 10 minutes, longer with an ad blocker (matches the 600000 ms counter bucket)");
  }
  // Recommended stats (user 2026-10-15): optional, any of the 8, only filled ones stored. Since 2026-10-18 a value is an integer 0-512, a share "N%"
  // (the shares of a finished guide total 100) or ตัน / ตาม, and the stats keep the author's order (docs/superpowers/specs/2026-10-18-guide-stat-flasks-design.md).
  { const gs = norm(change({stats:{lck:40,agi:77}}));
    ok(Object.keys(gs.stats).join() === "lck,agi" && gs.stats.agi === 77 && gs.stats.lck === 40, "recommended stats keep the author's order");
    const kind = vm.runInContext("classGuideStatKind", sandbox), level = vm.runInContext("classGuideStatLevel", sandbox);
    const numeric = vm.runInContext("classGuideNumericStats", sandbox), problem = vm.runInContext("classGuideStatsProblem", sandbox);
    const mixed = {agi:250, atk:"ตัน", vit:"70%", lck:"30%", cha:"ตาม"};
    ok(JSON.stringify(norm(change({stats:mixed})).stats) === JSON.stringify(mixed), "numbers, shares and ตัน / ตาม mix in one guide, order kept");
    for (const bad of [{agi:"0%"},{agi:"101%"},{agi:"050%"},{agi:"ตัน "},{agi:"max"},{agi:"50"},{agi:513},{agi:1.5},{agi:null}]) rejects(()=>norm(change({stats:bad})), "reject stat value " + JSON.stringify(bad));
    rejects(()=>norm(change({stats:{atk:"50%",vit:"30%"}})), "a finished guide's shares must total 100");
    ok(norm(change({title:"",author:"",date:"",stats:{atk:"50%"}}),{draft:true}).stats.atk === "50%", "drafts keep shares that do not total 100 yet");
    ok(!("statsPlus" in norm(change({stats:{atk:"ตัน",agi:250},statsPlus:["atk"]}))) && norm(change({stats:{agi:250},statsPlus:["agi"]})).statsPlus.join() === "agi", "250+ applies to numbers only");
    ok(kind(0) === "num" && kind(512) === "num" && kind("100%") === "pct" && kind("ตาม") === "word" && kind("250") === null && kind(513) === null, "stat kinds");
    ok(level("100%") === 1 && level("30%") === 0.3 && level("ตัน") === 1 && level("ตาม") === 0.2 && level(250) === null, "flask levels");
    ok(JSON.stringify(numeric(mixed)) === '{"agi":250}' && numeric({atk:"ตัน"}) === null, "only numbers reach the hover timings");
    ok(problem({atk:"ตัน",vit:"70%",lck:"30%"}) === null && problem({vit:"70%"}) === "สเตตัสแนะนำแบบ % ต้องรวมได้ 100" && problem({agi:250}) === null, "the % total ignores numbers and words");
    const tile = vm.runInContext("classGuideStatTile", sandbox), S = {key:"atk", label:"ATK"};
    ok(/is-flask/.test(tile(S, "70%", false, false)) && /data-cg-level="0.7"/.test(tile(S, "70%", false, false)) && !/is-flask/.test(tile(S, 250, true, false)), "shares and words render as flasks, numbers as dials");
    ok(/class="cg-crown"/.test(tile(S, "ตัน", false, false)) && !/class="cg-crown"/.test(tile(S, "ตาม", false, false)), "only ตัน wears the crown");
    ok(/value="250\+"/.test(tile(S, 250, true, false)), "250+ still shows its plus");
    { const id = h => (/linearGradient id="([^"]+)"/.exec(h) || [])[1]; const a = id(tile(S, "ตัน", false, false)), b = id(tile(S, "ตัน", false, false)); ok(a && b && a !== b, "every crown has its own gradient id (a crown in the hidden editor must not blank the guide view's)"); }
    const parse = vm.runInContext("classGuideStatParse", sandbox);
    ok(JSON.stringify([parse(""), parse(" 050% "), parse("250+"), parse("0"), parse("ตาม"), parse("101%"), parse("513"), parse("abc")]) === JSON.stringify(["", {value:"50%",plus:false}, {value:250,plus:true}, {value:0,plus:false}, {value:"ตาม",plus:false}, null, null, null]), "editor input parsing");
    ok(!("stats" in norm(fixture)) && !("stats" in JSON.parse(encode(change({stats:{}})))) && !JSON.stringify(fixture).includes("stats"), "a guide without stats has no stats key (old guides export unchanged)");
    const sr = decode(encode(change({stats:{atk:300,def:0,tal:120,agi:120,vit:90,cha:60,int:96,lck:40}})));
    ok(Object.keys(sr.stats).join() === "atk,def,tal,agi,vit,cha,int,lck" && sr.stats.def === 0 && sr.stats.int === 96, "all 8 recommended stats round-trip through export / import (0 is a real value)");
    for (const bad of [{foo:1},{agi:513},{agi:-1},{agi:1.5},{agi:"10"},{agi:null}]) rejects(()=>norm(change({stats:bad})),"reject stats " + JSON.stringify(bad));
    rejects(()=>norm(change({stats:[120]})),"reject stats as an array"); rejects(()=>norm(change({stats:null})),"reject null stats");
    ok(norm(change({title:"",author:"",date:"",stats:{cha:5}}),{draft:true}).stats.cha === 5, "drafts keep recommended stats");
  }
  // Recommended gear (user 2026-10-16): up to 3 ranked picks per slot, a game item the class can use or a typed name; Replica + one upgrade stat only on weapon / armor / hat.
  { const GD = vm.runInContext("GEAR_DATA", sandbox), GI = vm.runInContext("GEAR_ICONS", sandbox), gc = require(path.join(__dirname, "guide_code.js"));
    const bin = vm.runInContext("classGuideBinary", sandbox), fromBin = vm.runInContext("classGuideFromBinary", sandbox), same = (x, y) => JSON.stringify(x) === JSON.stringify(y);
    ok(["weapon","armor","hat","trinket","boot","pet"].every(k => Array.isArray(GD[k]) && GD[k].length) && GD.weapon.length > 500 && GD.pet.some(([id]) => id === "p_lcr"), "gear data covers all six slots (weapons 500+, pets as families)");
    const mv = vm.runInContext("classGuideGearMove", sandbox);   // drag within a slot column (user 2026-10-18)
    ok(JSON.stringify(mv(["a","b","c"], 0, 2)) === '["b","c","a"]' && JSON.stringify(mv(["a","b","c"], 2, 0)) === '["c","a","b"]' && JSON.stringify(mv(["a","b"], 0, 5)) === '["b","a"]', "gear moves within its column, others shift, no gaps");
    ok(Object.values(GD).every(list => list.every(e => e.length === 2 && typeof e[0] === "string" && typeof e[1] === "string" && e[1])), "gear data holds only id and name (no stats or levels, user 2026-10-16)");
    // gear picker order and nicknames (user 2026-10-16): GEAR_LV only orders the picker, GEAR_NICKNAMES replace the shown name but the game name still finds the item
    { const LV = vm.runInContext("GEAR_LV", sandbox), NK = vm.runInContext("GEAR_NICKNAMES", sandbox), list = vm.runInContext("classGuideGearList", sandbox), key = vm.runInContext("classGuideGearSortKey", sandbox), gname = vm.runInContext("classGuideGearName", sandbox);
      const allIds = new Set(Object.values(GD).flatMap(l => l.map(e => e[0])));
      ok(Object.keys(LV).length > 1400 && Object.entries(LV).every(([id, lv]) => allIds.has(id) && Number.isInteger(lv)) && LV.w_wlf1 === 0 && LV.w_wlf44 === -58 && !("p_sob" in LV), "GEAR_LV: decoded itemClass.lv for listed items (negative = rank), pet families have none");
      ok(Object.entries(NK).every(([id, n]) => allIds.has(id) && typeof n === "string" && n.trim() && n.length <= 60), "GEAR_NICKNAMES: listed items, non-empty names up to 60 characters");
      const sorted = l => l.every((e, i) => { if (!i) return true; const x = key(l[i - 1][0]), y = key(e[0]); return x[0] < y[0] || (x[0] === y[0] && (x[1] < y[1] || (x[1] === y[1] && x[2] <= y[2]))); });
      const w = list("weapon", "wolf");
      ok(["weapon","armor","hat","trinket","boot","pet"].every(s => sorted(list(s, "wolf"))) && w.findIndex(e => e[0] === "w_wlf44") < w.findIndex(e => e[0] === "w_wlf41") && w[w.length - 1][0] === "w_wlf1" && w.findIndex(e => !NK[e[0]]) === w.filter(e => NK[e[0]]).length && NK.w_wlf62 === "70 ดด" && w[0][0] === "w_wlf58" && w.findIndex(e => e[0] === "w_wlf44") < w.findIndex(e => e[0] === "w_wlf62"), "gear picker: nicknamed first, then no level data, then rank, then level, highest first");
      NK.w_wlf1 = "ไม้ตีหมา"; const w2 = list("weapon", "wolf"); const nickOk = w2.findIndex(e => e[0] === "w_wlf1") < w2.findIndex(e => !NK[e[0]]) &&gname({ item: "w_wlf1" }) === "ไม้ตีหมา"; delete NK.w_wlf1;
      ok(nickOk && html.includes('(GEAR_NICKNAMES[id] || "").toLowerCase().includes(q)') && html.includes("name.toLowerCase().includes(q) ||"), "a nicknamed item is listed first, shown by its nickname, and the search matches both names");
    }
    const ids = new Set(Object.values(GD).flatMap(l => l.map(e => e[0]))); ok(Object.keys(GI).every(id => ids.has(id) && /^data:image\/webp;base64,/.test(GI[id])) && Object.keys(GI).length > 1400, "every gear icon belongs to a listed item and is an embedded WebP");
    // server-specific gear (user 2026-10-25): GEAR_SERVERS items show only in that server's guides
    { const GS = vm.runInContext("GEAR_SERVERS", sandbox), glist = vm.runInContext("classGuideGearList", sandbox), gclean = vm.runInContext("classGuideGearClean", sandbox), allIds2 = new Set(Object.values(GD).flatMap(l => l.map(e => e[0])));
      const slotOf = (id) => Object.keys(GD).find(k => GD[k].some(e => e[0] === id)), has = (slot, cls, srv, id) => glist(slot, cls, srv).some(e => e[0] === id);
      ok(Object.entries(GS).every(([id, srvs]) => allIds2.has(id) && Array.isArray(srvs) && srvs.length && srvs.every(x => ["og", "tot", "tto", "reborn"].includes(x))) && GS.b_all_tto_shadowstrider && GS.b_all_tto_shadowstrider.join() === "tto", "GEAR_SERVERS: listed items with real server keys, Shadow Strider is TTO only");
      ok(has("boot", "wolf", "tto", "b_all_tto_shadowstrider") && !has("boot", "wolf", "og", "b_all_tto_shadowstrider") && !has("boot", "wolf", "tot", "b_all_tto_shadowstrider") && has("boot", "wolf", undefined, "b_all_tto_shadowstrider"), "the gear picker lists a TTO-only item for TTO guides and hides it for BB and ToT");
      const strict = (srv) => { try { gclean({ boot: [{ item: "b_all_tto_shadowstrider" }] }, "wolf", false, srv); return true; } catch (e) { return false; } };
      ok(strict("tto") && !strict("tot") && !strict("og") && JSON.stringify(gclean({ boot: [{ item: "b_all_tto_shadowstrider" }] }, "wolf", true, "tot")) === "{}" && gclean({ boot: [{ item: "b_all_tto_shadowstrider" }] }, "wolf", true, "tto").boot[0].item === "b_all_tto_shadowstrider", "a guide accepts a TTO-only item on TTO, refuses it on BB and ToT, and a draft drops it there");
      ok(html.includes("classGuideGearClean(value.gear, b.classKey, draft, b.server)") && html.includes("classGuideGearList(gearPick.slot, classKey, bd.server)") && html.includes("else if (draft.build.server !== build.server)"), "the guide check, the picker and the editor's server change all pass the guide's server to the gear functions");
    }
    const gear = { weapon:[{ item:"w_wlf10", replica:{ name:"ดาบใหม่ 🐺" }, stat:"atk" }, { name:"Brand New Blade" }, { item:"w_wlf11", replica:{ item:"w_wlf12" } }], hat:[{ item:"c_all1" }], trinket:[{ item:"t_all1" }], pet:[{ item:"p_lcr" }] };
    const withGear = norm(change({gear}));
    ok(same(withGear.gear, gear), "a valid gear set normalizes unchanged (order item / name, replica, stat)");
    ok(same({ ...norm(decode(encode(change({gear})))), date: "" }, { ...withGear, date: "" }), "gear round-trips through export / import (the import drops the date, user 2026-10-23)");
    ok(same(Array.from(bin(withGear)), Array.from(gc.classGuideBinary(withGear))) && same(norm(fromBin(bin(withGear))), withGear) && same(norm(gc.decode(gc.encode(withGear))), withGear), "gear round-trips through the format 2 code, page and scripts/guide_code.js identical");
    ok(same(norm(fromBin(bin(norm(fixture)))), norm(fixture)) && !("gear" in norm(fixture)), "a guide without gear has no gear key and its code has no gear block (old codes decode unchanged)");
    // support skills (user 2026-10-17): up to two (ids 901-912), a note and a cover icon on one; a guide without them has no support key and no code block
    { const base = norm(fixture), withSup = norm(change({ build: { ...base.build, support: [903, 911] }, notes: { ...base.notes, 903: "ซัพพอร์ต" }, cover: [903] }));
      ok(same(withSup.build.support, [903, 911]) && withSup.notes[903] === "ซัพพอร์ต" && same(withSup.cover, [903]), "support skills, a note and a cover icon on one normalize unchanged");
      ok(same(Array.from(bin(withSup)), Array.from(gc.classGuideBinary(withSup))) && same(norm(fromBin(bin(withSup))), withSup) && same(norm(gc.decode(gc.encode(withSup))), withSup), "support skills round-trip through the format 2 code, page and scripts/guide_code.js");
      ok(!("support" in base.build) && !("support" in norm(fromBin(bin(base))).build), "a guide without support skills has no support key, before and after its code");
      rejects(() => norm(change({ build: { ...base.build, support: [901, 902, 903] } })), "reject three support skills");
      rejects(() => norm(change({ build: { ...base.build, support: [901, 901] } })), "reject the same support skill twice");
      rejects(() => norm(change({ build: { ...base.build, support: [913] } })), "reject an unknown support skill");
      // "250+" (user 2026-10-18): the number stays a number, statsPlus lists the "or more" stats; bit 15 in the code, so older codes read the same
      const withPlus = norm(change({ stats: { atk: 250, vit: 120 }, statsPlus: ["vit", "atk", "lck"] }));
      ok(same(withPlus.stats, { atk: 250, vit: 120 }) && same(withPlus.statsPlus, ["atk", "vit"]), "statsPlus keeps only set stats, in the fixed stat order");
      ok(same(Array.from(bin(withPlus)), Array.from(gc.classGuideBinary(withPlus))) && same(norm(fromBin(bin(withPlus))), withPlus) && same(norm(gc.decode(gc.encode(withPlus))), withPlus), "250+ round-trips through the format 2 code, page and scripts/guide_code.js");
      rejects(() => norm(change({ stats: { atk: 250 }, statsPlus: "atk" })), "reject statsPlus that is not a list");
    }
    rejects(()=>norm(change({gear:{weapon:[{item:"w_cat10"}]}})), "reject another class's weapon");
    rejects(()=>norm(change({gear:{weapon:[{item:"w_wlf10"},{item:"w_wlf11"},{item:"w_wlf12"},{item:"w_wlf14"}]}})), "reject a fourth pick");
    rejects(()=>norm(change({gear:{trinket:[{item:"t_all1", stat:"atk"}]}})), "reject an upgrade stat on a trinket");
    rejects(()=>norm(change({gear:{boot:[{item:"b_all1", replica:{name:"x"}}]}})), "reject a Replica on boots");
    rejects(()=>norm(change({gear:{weapon:[{item:"w_wlf10", stat:"str"}]}})), "reject an unknown upgrade stat");
    rejects(()=>norm(change({gear:{weapon:[{name:""}]}})), "reject an empty typed name"); rejects(()=>norm(change({gear:{weapon:[{name:"x".repeat(61)}]}})), "limit typed names to 60 characters");
    rejects(()=>norm(change({gear:{ring:[{name:"x"}]}})), "reject an unknown gear slot");
    ok(same(norm(change({title:"",author:"",date:"",gear:{weapon:[{item:"w_cat10"},{item:"w_wlf10"}]}}),{draft:true}).gear, {weapon:[{item:"w_wlf10"}]}), "drafts drop gear the class cannot use (class switched in the editor)");
    // cover icons (user 2026-10-16; up to 5 since 2026-10-17): 1-5 skills of the guide's grid, in order; the codes carry them in an optional 0x49 block, page and script identical
    { const withCover = norm(change({ cover: [102, 101] }));
      ok(same(withCover.cover, [102, 101]) && same(norm(fromBin(bin(withCover))), withCover) && same(Array.from(bin(withCover)), Array.from(gc.classGuideBinary(withCover))) && same(norm(gc.decode(gc.encode(withCover))), withCover) && same({ ...norm(decode(encode(change({ cover: [102, 101] })))), date: "" }, { ...withCover, date: "" }), "cover icons round-trip through both code formats, page and scripts/guide_code.js identical");
      { const five = norm(change({ cover: [113, 101, 102, 103, 111] }));
        ok(same(five.cover, [113, 101, 102, 103, 111]) && same(norm(fromBin(bin(five))), five) && same(norm(gc.decode(gc.encode(five))), five), "five cover icons keep their order through both code formats (page and script)"); }
      rejects(() => norm(change({ cover: [101, 102, 103, 111, 112, 113] })), "reject a sixth cover icon (six real cells of the grid)");
      ok([1, 2, 3, 4, 5].every(n => { const sp = vm.runInContext("CLASS_GUIDE_COVER_SPOTS", sandbox)[n]; return sp && sp.length === n && sp.every(([x, y, d]) => x >= 0 && y >= 0 && d > 0 && x + d <= 1.001 && y + d <= 1.001); }), "every cover count 1-5 has a layout that stays inside its box");
      rejects(() => norm(change({ cover: [999] })), "reject a cover icon that is not in the grid");
      ok(same(norm(change({ title: "", author: "", date: "", cover: [101, 999, 101] }), { draft: true }).cover, [101]), "drafts drop cover icons the grid no longer has"); }
  }
  // Hover rank: a cell's rank counts the same skill's cells before it in its tree, never the column (Penguin Dispell 2 sits in column 3, user 2026-10-16).
  { const rankOf = vm.runInContext("skillSimCellRank", sandbox), cellsOf = vm.runInContext("(k, s) => skillSimCells(SKILL_SIM[k], SKILL_SIM_SERVERS[s].patch[k], s === 'tot' ? SKILL_SIM_EX[k] : null)", sandbox);
    const badRank = []; let checkedRank = 0;
    for (const k of Object.keys(vm.runInContext("SKILL_SIM", sandbox))) for (const srv of ["og", "tot"]){
      const cells = cellsOf(k, srv);
      for (const id of Object.keys(cells).map(Number)){ const c = cells[id]; const m = c && !c.placeholder && !c.ex && /(\d+)$/.exec(c.name || ""); if (!m) continue; checkedRank++; if (rankOf(cells, id) !== Number(m[1])) badRank.push(k + " " + srv + " " + id + " " + c.name + " -> " + rankOf(cells, id)); }
    }
    ok(badRank.length === 0 && checkedRank > 1000, "cell rank (counted, not the column) matches the rank number in every cell name: " + badRank.slice(0, 5).join(" | ") + " (checked " + checkedRank + ")");
    const pc = cellsOf("penguin", "og"), dId = Object.keys(pc).map(Number).find(id => pc[id].icon === "penguin_dispell2");
    ok(dId % 10 === 3 && rankOf(pc, dId) === 2, "Penguin Dispell 2 sits in column 3 and counts as rank 2");
  }
  // Hover timings: the same numbers the skill-details chips show for that card and rank (revised art on, dependencies from the build).
  { const T = vm.runInContext("classGuideTimings", sandbox), cardOf = vm.runInContext("skillSimCardId", sandbox);
    const strip = h => h.replace(/<[^>]*>/g,"").replace(/\s+/g,"").trim();
    const chip = (h, cls) => { const i = h.indexOf("sk-stat " + cls); if (i < 0) return null; const m = /<div class="sk-stat-value[^"]*">([\s\S]*?)<\/div>/.exec(h.slice(i, i + 1500)); return m ? strip(m[1]) : null; };
    const inp = sandbox._statInputs, st = {agi:77,int:45,cha:33,tal:58,lck:40}, savedIn = {agi:inp.agi.value,int:inp.int.value,cha:inp.cha.value,tal:inp.tal.value,lck:inp.lck.value};
    inp.agi.value = "77"; inp.int.value = "45"; inp.cha.value = "33"; inp.tal.value = "58"; inp.lck.value = "40";
    let compared = 0; const bad = [];
    const compare = (sk, rank, ctx, depState, label) => {
      const lines = T(sk.id, rank, st, ctx); if (!lines.length) return;
      for (const id in depState) sandbox._depRanks[id] = depState[id];
      sandbox._skillRanks[sk.id] = rank; sandbox._selectSkill(sk);
      const h = sandbox._getRenderedHeroHtml(), want = { cd: chip(h, "sk-stat-cd"), cast: chip(h, "sk-stat-cast"), dur: chip(h, "sk-stat-dur"), cd2: chip(h, "sk-stat-cd-secondary"), dur2: chip(h, "sk-stat-dur2"), lck: chip(h, 'sk-stat-lck"'), lck2: chip(h, "sk-stat-lck2"), lck3: chip(h, "sk-stat-lck3"), lck4: chip(h, "sk-stat-lck4") };
      for (const l of lines){ if (want[l.kind] === l.text.replace(/\s+/g,"")) compared++; else bad.push(label + " " + sk.id + " r" + rank + " " + l.kind + " guide=" + l.text + " page=" + want[l.kind]); }
      for (const id in depState) delete sandbox._depRanks[id];
    };
    try {
      for (const sk of SKILLS){
        const maxRank = sk.maxRank || 1;
        for (const srv of ["og", "tot", "tto"]){ sandbox._setServer(srv); for (const rank of new Set([1, maxRank])) compare(sk, rank, { server:srv, learnedByCard:new Map(), revisedArt:true }, {}, srv + " no passives"); }
        sandbox._setServer("og");
        const deps = [sk.cdDep, sk.cdMultDep, sk.castDep, sk.dep].filter(Boolean);
        for (const level of ["max","mid"]){
          const learned = new Map(), depState = {};
          for (const d of deps){ const card = d.icon ? cardOf(d.icon) : ""; if (!card) continue; const target = level === "max" ? d.maxRank : Math.max(d.minRank || 0, Math.floor(((d.minRank || 0) + d.maxRank) / 2)); learned.set(card, target); depState[d.id] = target; }
          if (learned.size) compare(sk, maxRank, { server:"og", learnedByCard:learned, revisedArt:true }, depState, "passives " + level);
        }
      }
    } catch (e) { bad.push("threw: " + e.message); }
    finally { inp.agi.value = savedIn.agi; inp.int.value = savedIn.int; inp.cha.value = savedIn.cha; inp.tal.value = savedIn.tal; inp.lck.value = savedIn.lck; }
    ok(bad.length === 0, "guide hover timings differ from the skill-details chips: " + bad.slice(0, 5).join(" | "));
    ok(compared > 2400, "guide hover timings compared against " + compared + " chips (BB, ToT and TTO)");
    // Only fields whose stat is filled appear; LCK only widens; Revised Art only when the build learned it (and never for exempt skills).
    const tri = SKILLS.find(c => c.cdWrapped && c.castWrapped && c.durWrapped && !c.lckProc && !c.secondaryLckProc && !c.cdDep && !c.cdMultDep && !c.castDep && !c.dep && !c.durContested && !c.durAdjust && !c.revisedArtExempt && !/Debuff/.test(String((c.status && c.status.class) || "")) && T(c.id, 1, {agi:1,int:1,cha:1}, { server:"og", learnedByCard:new Map(), revisedArt:false }).length === 3);
    ok(!!tri, "a card with cooldown, cast time and buff duration exists for the gating checks");
    if (tri){
      const ctx0 = { server:"og", learnedByCard:new Map(), revisedArt:false }, kinds = (stats, ctx = ctx0) => T(tri.id, 1, stats, ctx).map(l => l.kind).join();
      ok(kinds({}) === "" && kinds({agi:50}) === "cd" && kinds({int:50}) === "cast" && kinds({cha:50}) === "dur" && kinds({atk:300,lck:90}) === "" && kinds({cha:50,agi:50}) === "cd,dur", "hover shows only the fields whose AGI / INT / CHA is filled");
      const val = (stats, ctx = ctx0, kind = "cd") => T(tri.id, 1, stats, ctx).find(l => l.kind === kind).text;
      ok(!val({agi:50}).includes("–") && val({agi:50,lck:100}).includes("–"), "LCK widens the cooldown into a range, no LCK is a single value");
      const withRA = parseFloat(val({agi:50}, { ...ctx0, revisedArt:true })), without = parseFloat(val({agi:50}));
      ok(withRA <= without && withRA < without || without < 8, "Revised Art in the build shortens the cooldown");
    }
    const exempt = SKILLS.find(c => c.cdWrapped && c.revisedArtExempt && typeof (Array.isArray(c.cd) ? c.cd[0] : c.cd) === "number" && !c.cdDep && !c.cdMultDep && !Object.keys(c).some(k => /^ownStats/.test(k)) && T(c.id, 1, {agi:50}, { server:"og", learnedByCard:new Map(), revisedArt:false }).length);
    if (exempt) ok(T(exempt.id, 1, {agi:50}, { server:"og", learnedByCard:new Map(), revisedArt:true })[0].text === T(exempt.id, 1, {agi:50}, { server:"og", learnedByCard:new Map(), revisedArt:false })[0].text, "Revised Art does not touch an exempt skill");
    ok(T("bat_nightmare", 1, null, {}).length === 0 && T("no_such_card", 1, st, { server:"og", learnedByCard:new Map(), revisedArt:false }).length === 0, "no stats / unknown card give no hover lines");
    const panel = vm.runInContext("classGuideStatsHtml", sandbox), editor = vm.runInContext("classGuideStatsEditorHtml", sandbox);
    // no stats: only the reader's + dial (user 2026-10-17), no tile
    ok(!/cg-stat-tile/.test(panel(undefined)) && !/cg-stat-tile/.test(panel({})) && panel(undefined).includes('data-cg-act="addStat"') && (panel({agi:120}).match(/cg-stat-tile/g) || []).length === 1 && panel({agi:120}).includes("--stat-agi") && panel({agi:120}).includes('value="120"') && panel({agi:120}).includes('data-cg-try="agi"') && !panel({agi:120}).includes("ATK"), "reader panel renders only the filled stats in their colour");
    ok((panel({atk:1,def:2,tal:3,agi:4,vit:5,cha:6,int:7,lck:8}).match(/cg-stat-tile/g) || []).length === 8 && !panel({atk:1,def:2,tal:3,agi:4,vit:5,cha:6,int:7,lck:8}).includes('data-cg-act="addStat"'), "reader panel can show all 8 stats (and then has no + dial)");
    // the reader's tries survive a refresh (user 2026-10-21): stored per guide, cleaned on load, and ↺ คืนสู่ค่าแนะนำ starts hidden (all 8 stats too)
    const triesClean = vm.runInContext("classGuideTriesClean", sandbox);
    ok(JSON.stringify(triesClean([["agi","120"],["agi","130"],["xxx","1"],["cha","250+"],["lck","5%"],["def",7],"bad",["int","1234"],["vit",""]])) === JSON.stringify([["agi","120"],["cha","250+"]]) && !triesClean(null).length && !triesClean({}).length, "stored reader tries are cleaned: known stats once each, typed numbers only");
    ok([{agi:120}, undefined, {atk:1,def:2,tal:3,agi:4,vit:5,cha:6,int:7,lck:8}].every(st => /<span class="cg-stat-reset-row" hidden><button type="button" class="cg-stat-reset" data-cg-act="resetStats"/.test(panel(st))), "the reader panel carries a hidden ↺ คืนสู่ค่าแนะนำ link");
    // Editor (user 2026-10-18): no row of 8 boxes; the author adds stats one at a time as flasks, each with × and the ตัน / ตาม pills.
    const edFlask = vm.runInContext("classGuideStatEdHtml", sandbox);
    ok(!/data-cg-stat=/.test(editor()) && editor().includes('data-cg-role="statEd"') && editor().includes('data-cg-role="statSum"'), "the editor starts with no stat boxes, only the flask row and the % total line");
    ok(["atk","lck"].every(k => { const h = edFlask({key:k, label:k.toUpperCase()}, "30%", false); return h.includes('data-cg-stat="' + k + '"') && h.includes("--stat-" + k) && h.includes('data-cg-act="statDel"') && /data-word="ตัน"[^>]*aria-pressed="false"/.test(h) && /is-flask/.test(h); }) && /data-word="ตาม"[^>]*aria-pressed="true"/.test(edFlask({key:"cha", label:"CHA"}, "ตาม", false)), "an editor flask carries its colour, ×, and the ตัน / ตาม pills");
    ok(/inputmode="text"/.test(edFlask({key:"atk", label:"ATK"}, "30%", false)) && /inputmode="numeric"/.test(vm.runInContext("classGuideStatTile", sandbox)({key:"atk", label:"ATK"}, 250, false, false)), "an editor flask opens the full keyboard (a phone's number pad has no %), the reader's try input stays numeric");
    const hover = vm.runInContext("classGuideHoverLines", sandbox);
    ok(hover(null, {}, {icon:"wolf_x",id:101}, true) === null && hover({stats:{agi:50}}, {}, {icon:"wolf_x",id:101}, false) === null && hover({}, {}, {icon:"wolf_x",id:101}, true) === null, "hover lines only for a learned skill of a guide with stats");
  }

  // Mount the same real simulator in reader mode: clicks, controls, hold and level changes cannot mutate it.
  const doc = sandbox.document, saved = {create:doc.createElement,add:doc.addEventListener,storage:sandbox.localStorage};
  const mk = () => {
    const e=makeEl(),classes=new Set(),registry=new Map();e.children=[];e.listeners={};
    e.appendChild=c=>{e.children.push(c);return c;};e.append=(...cs)=>cs.forEach(e.appendChild);
    Object.defineProperty(e,"textContent",{get:()=>e._text||"",set:v=>{e._text=v;e.children=[];}});
    e.classList={add:c=>classes.add(c),remove:c=>classes.delete(c),toggle:(c,v)=>v?classes.add(c):classes.delete(c),contains:c=>classes.has(c)||e.className?.split(" ").includes(c)};
    e.querySelectorAll=sel=>{if(registry.has('[data-role="trees"]'))return registry.get('[data-role="trees"]').querySelectorAll(sel);const found=[];const walk=n=>{for(const c of n.children){if(sel.startsWith(".")&&c.classList.contains(sel.slice(1)))found.push(c);walk(c);}};walk(e);return found;};
    e.querySelector=sel=>{const child=e.querySelectorAll(sel)[0];if(child)return child;if(!registry.has(sel))registry.set(sel,mk());return registry.get(sel);};
    e.addEventListener=(k,fn)=>{(e.listeners[k]||=[]).push(fn);};return e;
  };
  const root=mk(),select=root.querySelector;
  const cell=id=>root.querySelectorAll(".rsim-cell").find(b=>+b.dataset.id===id),reveals=[];
  const click=target=>root.listeners.click.forEach(fn=>fn({target:{closest:sel=>sel===".rsim-cell"?(target.dataset.id?target:null):sel==="[data-act]"?target:null}}));
  const keys=[];
  try {
    doc.createElement=mk;doc.addEventListener=(type,fn)=>{if(type==="keydown")keys.push(fn);};sandbox.localStorage={getItem:()=>null,setItem:()=>{}};
    vm.runInContext("mountSkillSimulator",sandbox)(root,{onNote:info=>reveals.push(info)});
    root._skillSim.loadBuild(round.build);root._skillSim.setNotes(round.notes);root._skillSim.setInteraction("read");
    const before=JSON.stringify(root._skillSim.getBuild());
    click(cell(101));click(cell(103));click(cell(103));click(cell(201));
    ok(reveals.length===3&&reveals[0].first&& !reveals[1].first&&cell(103).classList.contains("note-seen"),"first star reveal dims it; later clicks reopen the note");
    ok(reveals[2].text===fixture.notes[201],"reader can open a note on a skipped skill");
    for(const act of ["reset","undo","server","pick"])click({dataset:{act}});
    const lv=select('[data-role="lv"]');lv.value="1";lv.listeners.change.forEach(fn=>fn());
    keys.forEach(fn=>fn({ctrlKey:true,shiftKey:false,key:"z",target:{closest:()=>null},preventDefault:()=>{}}));
    root.listeners.pointerdown.forEach(fn=>fn({target:{closest:()=>cell(103)},pointerType:"mouse",button:0,clientX:0,clientY:0}));
    ok(JSON.stringify(root._skillSim.getBuild())===before,"reader clicks, level edits, undo and controls leave expert build unchanged");
    ok(lv.disabled,"reader disables level editing");
    root._skillSim.setInteraction("annotate");click(cell(202));
    ok(reveals[reveals.length-1].id===202&&JSON.stringify(root._skillSim.getBuild())===before,"annotation selection does not learn skills");
    root._skillSim.setInteraction("build");click(cell(201));
    ok(root._skillSim.getBuild().learned.includes(201),"author build mode retains ordinary learning");
    // Hover tip with timing lines (options.tipExtra): reader view only, for learned skills.
    { const tip = mk(), savedGet = doc.getElementById, hadWidth = "innerWidth" in sandbox; doc.getElementById = id => id === "rsimTip" ? tip : makeEl(); sandbox.innerWidth = 1280;
      try {
        const root2 = mk(), calls = [];
        vm.runInContext("mountSkillSimulator",sandbox)(root2,{tipExtra:(c,learned)=>{calls.push(c.id+":"+learned);return learned?[{label:"คูลดาวน์",text:"27s",stat:"agi"},{label:"เวลาร่าย",text:"1s",stat:"int"}]:null;}});
        root2.querySelector('[data-role="lv"]');
        root2._skillSim.loadBuild(round.build);
        const cell2 = id => root2.querySelectorAll(".rsim-cell").find(b => +b.dataset.id === id);
        const over = id => root2.listeners.mouseover.forEach(fn => fn({ target:{ closest: sel => sel === ".rsim-cell" ? cell2(id) : null }, sourceCapabilities:null }));
        root2._skillSim.setInteraction("build"); over(101);
        ok(calls.length === 0 && tip.children.length === 0, "builder hover shows only the name (no timing lines)");
        root2._skillSim.setInteraction("read"); over(101);
        const lines2 = () => tip.children.filter(c => c.className === "rsim-tip-line"), hint2 = () => tip.children.filter(c => c.className === "rsim-tip-hint");
        ok(lines2().length === 2 && lines2()[0].children[1].textContent === "27s" && hint2().length === 1 && hint2()[0].textContent === "คลิกค้างเพื่อดูรายละเอียดเพิ่มเติม", "view hover of a learned skill shows its timing lines and the long-press hint");
        over(201);
        ok(lines2().length === 0 && hint2().length === 1 && calls[calls.length - 1] === "201:false", "view hover of a skipped skill shows the name and the long-press hint only");
      } finally { doc.getElementById = savedGet; if (!hadWidth) delete sandbox.innerWidth; }
    }
  } catch(e){ok(false,"reader UI threw: "+e.message);}
  finally{doc.createElement=saved.create;doc.addEventListener=saved.add;sandbox.localStorage=saved.storage;}
}
console.log(`Verified ${checkedRsim} skill simulator checks.`);

// The ☕ donor list (DONORS in index.html, edited only by scripts/add_guide.js): one approved donation per line, in the exact form
// donors.js writes it, so a hand-edited spacing or key order shows up here. Reads the same page text as everything above (--index works).
{
  const donors = require('./donors.js');
  const bad = (msg) => { console.error("[DONOR ERROR] " + msg); errorCount++; };
  let parsed = null;
  try { parsed = donors.parseDonors(html); } catch (e) { bad(e.message); }
  if (parsed) {
    const seen = new Set();
    parsed.lines.forEach((l, i) => {
      const at = "DONORS line " + (i + 1);
      if (!l.trim().startsWith("{")) { bad(at + " is not a donation"); return; }
      let x;
      try { x = JSON.parse(l.trim().replace(/,$/, "")); } catch (e) { bad(at + " does not parse: " + e.message); return; }
      if (!/^[0-9a-f]{8}$/.test(x.k)) bad(at + " has a bad k (8 hex characters)");
      else if (seen.has(x.k)) bad(at + " repeats the key " + x.k); else seen.add(x.k);
      if (!/^[0-9a-f]{8}$/.test(x.id)) bad(at + " has a bad id (8 hex characters)");
      try { donors.checkDonation(x); } catch (e) { bad(at + ": " + e.message); return; }
      if (l !== donors.donorLine(x)) bad(at + " is not in the form donors.js writes (spacing, key order or escaping)");
    });
    console.log(`Verified ${parsed.donations.length} donation(s) in DONORS.`);
  }
}

// The ☕ pop-up (user 2026-10-23): three tabs under the thank-you text, QR โอนเงิน (the QR card to scan or save, picked on every open),
// ส่งสลิป (an optional slip form of name, message and slip, sent through the Worker, 12t_projects/donate-worker; the owner types the amount
// and date from the slip in the guide manager) and รายชื่อผู้สนับสนุน (the donor list). Its copies of scripts/donors.js (DONOR_LIMITS,
// donorSlipCheck, donorRows) must agree with it; a slip straight from a phone camera is redrawn as a small JPEG (Review Focus 2); the send
// button stays disabled while a send runs (Review Focus 4) and any error keeps what was typed; donor values go in as text only; the text asks
// for ค่าพัฒนา and never mentions AI; the QR card is in assets.js. The async code (shrinkSlip, the send, the download) runs in a child Node
// process (donateChildTests below), because this validator is synchronous: the page's own functions, read from the sandbox as source, with
// stubs for document, navigator, fetch and createImageBitmap.
async function donateChildTests(env) {
  const { S, log, anchors, shares } = env, out = [], check = (pass, msg) => out.push({ pass: !!pass, msg });
  const tick = () => new Promise((r) => setImmediate(r));
  const settle = async (p) => { try { return { ok: await p }; } catch (e) { return { err: String(e && e.message) }; } };
  // shrinkSlip turns a big image into a small JPEG: at most 1600 px on the long side, never upscaled, image/jpeg at quality 0.85
  const shrink = async (w, h) => {
    S.bmp = { width: w, height: h }; log.length = 0;
    const r = await settle(env.shrinkSlip({ name: "IMG_0001.HEIC", type: "image/heic", size: 12e6 }));
    return { r, blob: log.find((x) => x[0] === "toBlob"), draw: log.find((x) => x[0] === "draw"), closed: log.some((x) => x[0] === "close") };
  };
  for (const [w, h, W, H, what] of [[4000, 3000, 1600, 1200, "a 4000×3000 photo"], [3000, 4000, 1200, 1600, "a 3000×4000 photo"], [800, 600, 800, 600, "an 800×600 screenshot (never upscaled)"]]) {
    const { r, blob, draw, closed } = await shrink(w, h);
    check(r.ok && r.ok.type === "image/jpeg" && blob && blob[1] === "image/jpeg" && blob[2] === 0.85 && blob[3] === W && blob[4] === H && draw && draw[1].join() === "0,0," + W + "," + H && closed,
      `shrinkSlip turns a big image into a small JPEG: ${what} must be drawn at ${W}×${H} and saved as image/jpeg at quality 0.85 (got ${JSON.stringify({ toBlob: blob, draw, closed, err: r.err })})`);
  }
  S.bmpFail = true; const undecodable = await settle(env.shrinkSlip({ name: "x.heic" })); S.bmpFail = false;
  S.blobNull = true; const noBlob = (await shrink(4000, 3000)).r; S.blobNull = false;
  env.dropBitmap(); const noApi = await settle(env.shrinkSlip({ name: "x.jpg" })); env.restoreBitmap();
  check([undecodable, noBlob, noApi].every((r) => r.err === env.READ_ERROR), `shrinkSlip throws "${env.READ_ERROR}" when the browser cannot decode the file, gives no JPEG or has no createImageBitmap (got ${JSON.stringify([undecodable, noBlob, noApi])})`);

  // downloadQr: the share sheet with the PNG on iPhones and iPads (บันทึกรูปภาพ puts it in Photos), a download link everywhere else
  const iphone = { userAgent: "Mozilla/5.0 (iPhone; CPU iPhone OS 17_5 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.5 Mobile/15E148 Safari/604.1", platform: "iPhone", maxTouchPoints: 5, canShare: (d) => !!(d && d.files && d.files.length), share: async (d) => { shares.push(d); } };
  const ipad = { ...iphone, userAgent: "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.5 Safari/605.1.15", platform: "MacIntel" };
  const pc = { userAgent: "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/130.0 Safari/537.36", platform: "Win32", maxTouchPoints: 0, canShare: () => true, share: async (d) => { shares.push(d); } };
  const save = async (nav) => { env.setNav(nav); anchors.length = 0; shares.length = 0; let threw = ""; try { env.downloadQr(); } catch (e) { threw = String(e && e.message); } await tick(); return threw; };
  for (const [nav, what] of [[iphone, "an iPhone"], [ipad, "an iPad"]]) {
    const threw = await save(nav), f = shares[0] && shares[0].files && shares[0].files[0];
    check(!threw && shares.length === 1 && !anchors.length && f && f.name === "12tails-bible-qr.png" && f.type === "image/png" && f.size > 0, `downloadQr on ${what} opens the share sheet with one file 12tails-bible-qr.png (image/png) (got ${JSON.stringify({ threw, shares: shares.length, anchors })})`);
  }
  for (const [nav, what] of [[pc, "a PC (canShare true, still a download)"], [{ ...iphone, canShare: () => false }, "an iPhone that cannot share files"]]) {
    const threw = await save(nav);
    check(!threw && !shares.length && anchors.length === 1 && anchors[0].download === "12tails-bible-qr.png" && /^(blob|data):/.test(anchors[0].href), `downloadQr on ${what} downloads 12tails-bible-qr.png through a link (got ${JSON.stringify({ threw, shares: shares.length, anchors })})`);
  }
  env.setQr(""); const threwEmpty = await save(iphone); const emptySaves = shares.length + anchors.length; await save(pc); env.restoreQr();
  check(!threwEmpty && !emptySaves && !shares.length && !anchors.length, "downloadQr does nothing when DONATE_QR is empty (assets.js did not load)");

  // donateSubmit: checks first (nothing obviously wrong leaves the page), the button disabled while a send runs, every error keeps the form.
  // The form is the display name, the message and the slip (user 2026-10-23: the owner reads the amount and date off the slip).
  const mkUi = (v = {}) => {
    const x = { name: "ก้อง 🐱", msg: "สู้ ๆ ครับ", file: { name: "IMG_0001.HEIC", type: "image/heic", size: 12e6 }, ...v };
    return { busy: false, name: { value: x.name }, msg: { value: x.msg },
      slip: { value: x.file ? "C:\\fakepath\\" + x.file.name : "", files: x.file ? [x.file] : [] }, btn: { disabled: false }, status: { textContent: "", dataset: {} } };
  };
  const typed = (ui) => JSON.stringify([ui.name.value, ui.msg.value, ui.slip.value, ui.slip.files.length]);
  const reply = (body) => ({ ok: !!body.ok, status: body.ok ? 200 : 400, json: async () => body });
  S.bmp = { width: 4000, height: 3000 }; S.blobBytes = 300000;
  {
    const calls = []; let answer = null;
    S.fetch = (url, opts) => { calls.push({ url, opts }); return new Promise((r) => { answer = r; }); };
    const ui = mkUi(), before = typed(ui), first = env.donateSubmit(ui);
    for (let i = 0; i < 50 && !calls.length; i++) await tick();
    const during = ui.btn.disabled;
    await env.donateSubmit(ui); await tick();
    check(calls.length === 1 && during === true, `the send button is disabled while a send runs and a second tap sends nothing (Review Focus 4) (got ${calls.length} sends, disabled ${during})`);
    const c = calls[0] || { opts: {} }, b = c.opts.body, slip = b && typeof b.get === "function" ? b.get("slip") : null;
    const keys = b && typeof b.keys === "function" ? [...b.keys()] : [];
    check(c.url === env.DONATE_WORKER_URL && c.opts.method === "POST" && !("headers" in c.opts) && b instanceof FormData && JSON.stringify(keys) === '["name","msg","slip"]' && b.get("name") === "ก้อง 🐱" && b.get("msg") === "สู้ ๆ ครับ" && slip && slip.type === "image/jpeg" && slip.size === 300000 && slip.name === "slip.jpg",
      `the send is one POST of FormData with exactly name, msg and the redrawn slip.jpg (no amount, no date) to DONATE_WORKER_URL with no custom headers (got ${JSON.stringify(keys)})`);
    if (answer) answer(reply({ ok: false, error: "rate" }));
    await first;
    check(ui.status.textContent === env.DONATE_ERRORS.rate && ui.btn.disabled === false && !ui.busy && typed(ui) === before, `a rate reply shows "${env.DONATE_ERRORS.rate}", enables the send button again and keeps every field (got ${JSON.stringify(ui.status.textContent)})`);
  }
  const send = async (v, answer) => { const calls = []; S.fetch = async (url, opts) => { calls.push(opts); return answer(); }; const ui = mkUi(v), before = typed(ui); await env.donateSubmit(ui); return { ui, before, sent: calls.length, body: calls[0] && calls[0].body }; };
  for (const [answer, want, what] of [
    [() => reply({ ok: false, error: "invalid", field: "name", message: "ชื่อยาวเกิน 40 ตัวอักษร" }), "ชื่อยาวเกิน 40 ตัวอักษร", "an invalid reply shows the Worker's message"],
    [() => reply({ ok: false, error: "discord" }), env.FAIL_TEXT, "a discord reply"],
    [() => { throw new TypeError("Failed to fetch"); }, env.FAIL_TEXT, "a network failure"],
    [() => ({ ok: false, status: 502, json: async () => { throw new SyntaxError("Unexpected token <"); } }), env.FAIL_TEXT, "a reply that is not JSON"],
  ]) {
    const { ui, before, sent } = await send({}, answer);
    check(sent === 1 && ui.status.textContent === want && typed(ui) === before && !ui.btn.disabled && !ui.busy, `${what} shows "${want}" and keeps every field (got ${JSON.stringify({ sent, status: ui.status.textContent })})`);
  }
  {
    const { ui, sent, body } = await send({ msg: "  สู้ ๆ\n ครับ " }, () => reply({ ok: true }));
    check(sent === 1 && body.get("msg") === "สู้ ๆ ครับ" && ui.status.textContent === env.THANKS && !ui.name.value && !ui.msg.value && !ui.slip.value && !ui.btn.disabled,
      `a sent slip (the message cleaned as checkSlipDetails does) shows "${env.THANKS}" and clears the form for the next one (got ${JSON.stringify({ sent, status: ui.status.textContent, msg: body && body.get("msg") })})`);
  }
  {
    const { ui, sent, body } = await send({ msg: "" }, () => reply({ ok: true }));
    check(sent === 1 && body.get("msg") === "" && ui.status.textContent === env.THANKS, `a slip with no message is sent (msg is optional) (got ${JSON.stringify({ sent, status: ui.status.textContent })})`);
  }
  const refusals = [
    [{ name: " \n " }, env.MSG.name, "no name"], [{ name: "🐱".repeat(41) }, env.MSG.longName, "a 41-emoji name (refused with the limit, never cut)"], [{ msg: "ก".repeat(201) }, env.MSG.longMsg, "a 201-letter message"],
    [{ file: null }, env.DONATE_ERRORS.missing, "no slip"],
  ];
  for (const [v, want, what] of refusals) {
    const { ui, before, sent } = await send(v, () => reply({ ok: true }));
    check(sent === 0 && ui.status.textContent === want && typed(ui) === before && !ui.btn.disabled, `${what} is refused on the page with "${want}", nothing sent, the form kept (got ${JSON.stringify({ sent, status: ui.status.textContent })})`);
  }
  S.bmpFail = true; const unread = await send({}, () => reply({ ok: true })); S.bmpFail = false;
  check(unread.sent === 0 && unread.ui.status.textContent === env.READ_ERROR && typed(unread.ui) === unread.before && !unread.ui.btn.disabled, `a slip the browser cannot read is refused with "${env.READ_ERROR}" and the form kept (Review Focus 2) (got ${JSON.stringify(unread.ui.status.textContent)})`);
  S.blobBytes = 5242881; const big = await send({}, () => reply({ ok: true })); S.blobBytes = 300000;
  check(big.sent === 0 && big.ui.status.textContent === env.DONATE_ERRORS["file-size"] && typed(big.ui) === big.before, `a redrawn slip still over 5 MB is refused with "${env.DONATE_ERRORS["file-size"]}" without sending (got ${JSON.stringify(big.ui.status.textContent)})`);
  return out;
}
{
  const dl = require('./donors.js');
  let donateChecked = 0;
  const ok = (pass, msg) => { if (pass) donateChecked++; else { console.error("[DONATE ERROR] " + msg); errorCount++; } };
  const same = (a, b) => JSON.stringify(a) === JSON.stringify(b);
  const kind = (name) => { try { return vm.runInContext("typeof " + name, sandbox); } catch (e) { return "undefined"; } };
  const page = (name) => vm.runInContext(name, sandbox);
  const FAIL_TEXT = "ส่งไม่สำเร็จ ลองใหม่อีกครั้ง", THANKS = "ได้รับแล้ว ขอบคุณครับ ชื่อจะขึ้นในรายชื่อผู้สนับสนุนหลังตรวจสลิป", READ_ERROR = "อ่านรูปสลิปไม่ได้ ลองถ่ายหน้าจอสลิปแล้วส่งใหม่";
  const need = { DONATE_QR: "string", DONATE_WORKER_URL: "string", DONOR_LIMITS: "object", DONATE_ERRORS: "object", donorSlipCheck: "function", donorRows: "function",
    shrinkSlip: "function", downloadQr: "function", donateErrorText: "function", donateSend: "function", donateSubmit: "function", renderDonorList: "function",
    renderDonorThanks: "function", donorTicker: "function", donateThanksFit: "function", donateCountFill: "function", donateTabsNudge: "function", DONATE_TICKER_SPEED: "number",
    donorRecent: "function", donorListPages: "function", donateListPage: "function", donateListFit: "function", donateListUi: "object", donateTabShown: "function",
    donateShowTab: "function", donateTabKey: "function", openDonateModal: "function", closeDonateModal: "function", donateTabs: "object", donatePanels: "object" };
  const missing = Object.keys(need).filter((n) => kind(n) !== need[n]);
  ok(!missing.length, "the pop-up's code is missing from the main script: " + missing.join(", "));
  const have = (...names) => names.every((n) => !missing.includes(n));

  // DONATE_QR: the QR card in assets.js (a MANIFEST string container), declared like the other string containers
  ok(bibleAssets.MANIFEST.some((m) => m.name === "DONATE_QR" && m.empty === ""), 'scripts/bible_assets.js MANIFEST has no { name: "DONATE_QR", empty: "" }');
  ok(/^const DONATE_QR = BIBLE_ASSETS_IN\.DONATE_QR \|\| "";\r?$/m.test(html), 'index.html does not declare const DONATE_QR = BIBLE_ASSETS_IN.DONATE_QR || "";');
  if (have("DONATE_QR")) { const q = page("DONATE_QR"), head = /^data:image\/png;base64,/.test(q) ? Buffer.from(q.slice(22, 54), "base64") : Buffer.alloc(0);
    ok(/^data:image\//.test(q) && q.length > 1000 && head.subarray(0, 8).equals(pngHeader), "DONATE_QR is not a non-empty data:image/ PNG (the QR card goes in assets.js)"); }

  // the Worker address and the error texts (every code the Worker answers has one; invalid shows the Worker's own message)
  if (have("DONATE_WORKER_URL")) ok(page("DONATE_WORKER_URL") === "https://12tails-donate.jumpthai.workers.dev/slip", "DONATE_WORKER_URL is not https://12tails-donate.jumpthai.workers.dev/slip");
  if (have("DONATE_ERRORS", "donateErrorText")) {
    const E = page("DONATE_ERRORS"), t = page("donateErrorText");
    const want = { missing: "กรอกให้ครบทุกช่องและแนบสลิป", "file-type": "สลิปต้องเป็นรูป JPG, PNG หรือ WebP", "file-size": "รูปสลิปใหญ่เกิน 5 MB", rate: "ส่งถี่เกินไป รอสักครู่แล้วลองใหม่", origin: FAIL_TEXT, method: FAIL_TEXT, discord: FAIL_TEXT };
    for (const [code, text] of Object.entries(want)) ok(t({ ok: false, error: code }) === text, `donateErrorText for ${code} gives ${JSON.stringify(t({ ok: false, error: code }))}, expected ${JSON.stringify(text)}`);
    ok(t({ ok: false, error: "invalid", field: "name", message: "ชื่อยาวเกิน 40 ตัวอักษร" }) === "ชื่อยาวเกิน 40 ตัวอักษร", "donateErrorText for invalid does not show the Worker's message");
    ok([null, undefined, {}, { ok: false }, { ok: false, error: "toString" }, { ok: false, error: "invalid" }, { ok: false, error: "invalid", message: 5 }].every((r) => t(r) === FAIL_TEXT), `donateErrorText gives "${FAIL_TEXT}" for an unknown or empty reply`);
    const codes = [...new Set([...fs.readFileSync(path.join(__dirname, "../12t_projects/donate-worker/src/handler.js"), "utf8").matchAll(/error: "([a-z-]+)"/g)].map((m) => m[1]))];
    const uncovered = codes.filter((c) => c !== "invalid" && !Object.prototype.hasOwnProperty.call(E, c));
    ok(codes.length >= 7 && !uncovered.length, "DONATE_ERRORS has no text for the Worker's error code(s) " + uncovered.join(", "));
  }

  // the page's copies of scripts/donors.js
  if (have("DONOR_LIMITS")) {
    ok(same(page("DONOR_LIMITS"), dl.LIMITS), "DONOR_LIMITS differ from LIMITS in scripts/donors.js");
    ok(/^const DONOR_LIMITS = \{[^\r\n]*\};\r?$/m.test(html), "DONOR_LIMITS is not declared on one line");
  }
  if (have("donorRows")) {
    const rows = page("donorRows"), gd = (id, name, msg, amount, date) => ({ k: id + date, id, name, msg, amount, date });
    const sets = [[gd("A", "old", "hi", 100, "2026-10-02T10:00"), gd("B", "bee", "", 150, "2026-10-01T10:00"), gd("A", "new", "", 50, "2026-10-05T10:00")], [gd("C", "c", "", 0.1, "2026-10-01T00:00"), gd("C", "c", "", 0.2, "2026-10-02T00:00")], []];
    ok(sets.every((s) => same(rows(s), dl.groupDonors(s))), "donorRows gives other rows than groupDonors on donors.js's test data (merged by id, latest name and message, total in satang, biggest first)");
    let real = null; try { real = dl.parseDonors(html).donations.map((t) => t.x); } catch (e) {}
    ok(real !== null && same(rows(page("DONORS")), dl.groupDonors(real)), "donorRows(DONORS) gives other rows than groupDonors on the page's DONORS");
    // the list tab (user 2026-10-23): newest first by each donor's latest donation, the same minute keeping the bigger total first; the names line keeps donorRows' order
    if (have("donorRecent")) {
      const recent = page("donorRecent"), r = (id, total, date) => ({ id, name: id, msg: "", total, count: 1, date, first: date });
      const input = [r("big", 500, "2026-10-23T15:29"), r("mid", 185, "2026-10-23T14:28"), r("tie", 100, "2026-10-24T09:00"), r("new", 50, "2026-10-24T09:00"), r("old", 20, "2026-10-01T00:00")], copy = JSON.stringify(input);
      ok(same(recent(input).map((x) => x.id), ["tie", "new", "big", "mid", "old"]) && JSON.stringify(input) === copy && same(recent([]), []),
        "donorRecent sorts the list rows newest first (a tie keeps the bigger total first) without changing the rows it was given");
    }
  }
  if (have("donorListPages")) {
    const pages = page("donorListPages");
    const cases = [[[], 100, [0]], [[50, 50, 50], 150, [0]], [[50, 50, 50], 120, [0, 2]], [[50, 50, 50], 60, [0, 1, 2]], [[200, 30], 100, [0, 1]], [[30, 200, 30], 100, [0, 1, 2]], [[40, 40, 40, 40, 40], 100, [0, 2, 4]]];
    const wrong = cases.filter(([h, room, want]) => !same(pages(h, room), want)).map(([h, room, want]) => `${JSON.stringify(h)} in ${room}: ${JSON.stringify(pages(h, room))}, expected ${JSON.stringify(want)}`);
    ok(!wrong.length, "donorListPages (rows in order, as many as fit a page, at least one row a page, each page's first row) gives " + wrong.join("; "));
  }
  // donorSlipCheck = checkSlipDetails: the name and message rules the Worker applies (the amount and date are no longer the donor's to send)
  const res = (fn, d) => { try { return { ok: fn(d) }; } catch (e) { return { err: String(e.message) }; } };
  if (have("donorSlipCheck")) {
    const cases = [{ name: "A" }, null, {}, { name: "  ก้อง\n 🐱 " }, { name: "🐱".repeat(40) }, { name: "🐱".repeat(41) }, { name: " \n " }, { name: 5 }, { name: "" },
      ...["ก".repeat(200), "ก".repeat(201), "a\r\n\r\n b", null, undefined, 5, ""].map((msg) => ({ name: "A", msg })), { name: "A", msg: "m", amount: "abc", date: 5 }, { name: "A", amount: 50, date: "2026-10-23T14:05" }];
    let agree = 0;
    for (const d of cases) { const a = res(page("donorSlipCheck"), d), b = res(dl.checkSlipDetails, d); if (same(a, b)) agree++; else ok(false, `donorSlipCheck and checkSlipDetails disagree on ${JSON.stringify(d).slice(0, 60)}: ${JSON.stringify(a).slice(0, 90)} vs ${JSON.stringify(b).slice(0, 90)}`); }
    ok(agree === cases.length, `donorSlipCheck gives the same result or message as checkSlipDetails on ${agree} of ${cases.length} cases`);
  }
  ok(["parseAmountInput", "donateNow", "donorCheck"].every((n) => kind(n) === "undefined"), "parseAmountInput, donateNow and donorCheck must go: the slip form has no amount or date any more");

  // the pop-up's text: support for the development cost (user 2026-10-23: one line, no server-cost mention, no Discord line), never AI; the brief's texts;
  // no one-line (nowrap) message any more
  const modal = (html.match(/<div class="donate-backdrop" id="donateModal"[\s\S]*?\r?\n<\/div>\r?\n/) || [""])[0], modalText = modal.replace(/<[^>]*>/g, " ");
  ok(modal && modalText.includes("ค่าใช้จ่ายในการพัฒนา") && !/\bAI\b/i.test(modalText) && !/\bAI\b/.test(modal), "the ☕ pop-up must ask for ค่าใช้จ่ายในการพัฒนา and never mention AI");
  for (const s of ["ร่วมสนับสนุนค่าใช้จ่ายในการพัฒนา 12 Tails Bible ขอบคุณทุกการสนับสนุนครับ 🙏", "ดาวน์โหลด QR", "อยากให้ชื่อขึ้นในรายชื่อผู้สนับสนุน?", "สลิปจะส่งถึงผู้ดูแลเท่านั้น ไม่เผยแพร่ ชื่อที่แสดง ข้อความ ยอด และวันที่จะขึ้นในรายชื่อหลังตรวจสลิป ชื่อที่แสดงเป็นข้อมูลสาธารณะ", "รายชื่อผู้สนับสนุน"])
    ok(modalText.replace(/\s+/g, " ").includes(s) || modal.includes(s), "the ☕ pop-up is missing " + JSON.stringify(s));
  // switching tabs never moves the pop-up (user 2026-10-23): the panels sit in .donate-panels, the QR panel keeps its space while hidden,
  // the slip and list panels lie on top of it
  ok(/<div class="donate-panels">\s*<div class="donate-tabpanel"[^>]*id="donatePanelQr"/.test(modal)
    && /\.donate-panels\{position:relative;/.test(html) && /#donatePanelQr\[hidden\]\{display:block; visibility:hidden\}/.test(html)
    && /#donatePanelSlip, #donatePanelList\{position:absolute;[^}]*max-height:100%;[^}]*overflow-y:auto/.test(html),
    "the ☕ tab panels must sit in .donate-panels with the QR panel setting the height (hidden = visibility:hidden) and the other two on top of it, so switching tabs never moves the pop-up");
  // it opens by itself once per device (user 2026-10-23): any open marks the device as seen; the auto open stands down while another
  // pop-up is up (the Stat Roll / Stat Gain / class guide gates, native dialogs, any aria-modal, any full-screen layer above the page)
  ok(/const DONATE_AUTO_KEY = "12t-bible-donate-seen";/.test(html)
    && /function openDonateModal\(\) \{[\s\S]*?localStorage\.setItem\(DONATE_AUTO_KEY, "1"\)[\s\S]*?\n\}/.test(html)
    && /function donateAutoBlocked\(\) \{[^\n]*\n[^\n]*\[aria-modal="true"\]:not\(\[hidden\]\):not\(#donateModal\), \.sg-gate\.open, dialog\[open\]/.test(html)
    && /elementsFromPoint\(w \/ 2, h \/ 2\)/.test(html) && (html.match(/^donateAutoOnce\(\);\r?$/gm) || []).length === 1,
    "the ☕ pop-up must open by itself once per device (DONATE_AUTO_KEY, set on every open) and stand down while another pop-up is up (donateAutoBlocked: aria-modal, .sg-gate.open, dialog[open], a full-screen layer)");
  // closing it turns it into a light ball that flies back into the ☕ button (user 2026-10-23): closeDonateModal → donateFlyHome → fireShot to btnDonate
  ok(/function closeDonateModal\(\) \{[\s\S]*?donateFlyHome\(from\);[\s\S]*?\n\}/.test(html)
    && /function donateFlyHome\(from\) \{[\s\S]*?btnDonate[\s\S]*?fireShot\(a, b, false,[\s\S]*?\n\}/.test(html) && /\.donate-fly-ghost\{position:fixed;/.test(html),
    "closing the ☕ pop-up must fly a light ball into the ☕ button (closeDonateModal → donateFlyHome → fireShot to btnDonate, .donate-fly-ghost)");
  // the three tabs (user 2026-10-23: the slip form and the donor list each get a tab, so they never crowd the QR card): role tab / tabpanel,
  // in this order, QR โอนเงิน selected in the markup; each panel holds its part (QR card, slip form with its intro and note, donor list)
  {
    const attr = (tag, a) => (tag.match(new RegExp("\\s" + a + '="([^"]*)"')) || [])[1];
    const tabs = [...modal.matchAll(/<button\b[^>]*\srole="tab"[^>]*>([\s\S]*?)<\/button>/g)].map((m) => ({ tag: m[0].slice(0, m[0].indexOf(">") + 1), label: m[1].replace(/<[^>]*>/g, "").replace(/\s+/g, " ").trim() }));
    const panels = [...modal.matchAll(/<(?:div|section)\b[^>]*\srole="tabpanel"[^>]*>/g)].map((m) => ({ tag: m[0], at: m.index }));
    const inside = (i) => panels[i] ? modal.slice(panels[i].at, i + 1 < panels.length ? panels[i + 1].at : modal.length) : "";
    ok(/<div\b[^>]*\srole="tablist"/.test(modal) && same(tabs.map((t) => t.label), ["QR โอนเงิน", "ส่งสลิป", "รายชื่อผู้สนับสนุน"]), `the ☕ pop-up has a tablist of three tabs QR โอนเงิน, ส่งสลิป, รายชื่อผู้สนับสนุน (got ${JSON.stringify(tabs.map((t) => t.label))})`);
    ok(tabs.length === 3 && same(tabs.map((t) => attr(t.tag, "aria-selected")), ["true", "false", "false"]) && same(tabs.map((t) => attr(t.tag, "tabindex") || "0"), ["0", "-1", "-1"]), "the QR โอนเงิน tab is the selected one in the markup (aria-selected, roving tabindex)");
    ok(panels.length === 3 && tabs.length === 3 && tabs.every((t, i) => attr(t.tag, "aria-controls") && attr(t.tag, "aria-controls") === attr(panels[i].tag, "id") && attr(panels[i].tag, "aria-labelledby") === attr(t.tag, "id")), "each tab's aria-controls names its tabpanel (same order) and the panel is labelled by its tab");
    ok(panels.length === 3 && !/\shidden\b/.test(panels[0].tag) && panels.slice(1).every((p) => /\shidden\b/.test(p.tag)), "only the QR panel shows in the markup; the slip and list panels start hidden");
    ok(inside(0).includes('id="donateQrImg"') && inside(0).includes('id="btnDonateQr"'), "the QR card and ดาวน์โหลด QR are in the QR โอนเงิน panel");
    ok(inside(1).includes('id="donateForm"') && inside(1).includes("อยากให้ชื่อขึ้นในรายชื่อผู้สนับสนุน?") && inside(1).includes('class="donate-note"'), "the slip form, its intro line and the privacy note are in the ส่งสลิป panel");
    ok(inside(2).includes('id="donateList"'), "the donor list is in the รายชื่อผู้สนับสนุน panel");
    ok(!/<details\b/.test(modal), "the slip form's <details> wrapper must go (the form has its own tab)");
    const form = (modal.match(/<form\b[^>]*\sid="donateForm"[\s\S]*?<\/form>/) || [""])[0];
    ok(same([...form.matchAll(/<(?:input|textarea|select)\b[^>]*\sname="([^"]+)"/g)].map((m) => m[1]), ["name", "msg", "slip"]), "the slip form's fields are exactly name, msg and slip (the owner types the amount and date from the slip)");
  }
  if (have("donateShowTab", "donateTabKey", "openDonateModal", "closeDonateModal", "donateTabs", "donatePanels")) {
    const stub = () => ({ attrs: {}, tabIndex: 0, hidden: false, focused: false, value: "typed", setAttribute(k, x) { this.attrs[k] = String(x); }, getAttribute(k) { return k in this.attrs ? this.attrs[k] : null; }, focus() { this.focused = true; } });
    const tabs = [stub(), stub(), stub()], panels = [stub(), stub(), stub()], show = page("donateShowTab"), key = page("donateTabKey");
    const picked = () => tabs.findIndex((t) => t.attrs["aria-selected"] === "true");
    const state = () => JSON.stringify([tabs.map((t) => [t.attrs["aria-selected"], t.tabIndex]), panels.map((p) => [p.hidden, p.value])]);
    show(tabs, panels, 1);
    ok(state() === JSON.stringify([[["false", -1], ["true", 0], ["false", -1]], [[true, "typed"], [false, "typed"], [true, "typed"]]]), `donateShowTab picks one tab (aria-selected, tabindex) and only hides the other panels, so what was typed stays (got ${state()})`);
    const press = (from, k) => { show(tabs, panels, from); tabs.forEach((t) => { t.focused = false; }); let prevented = false, stopped = false; key({ key: k, target: tabs[from], preventDefault() { prevented = true; }, stopPropagation() { stopped = true; } }, tabs, panels); return [picked(), prevented, stopped, picked() >= 0 && tabs[picked()].focused]; };
    const keys = [[0, "ArrowRight", 1], [2, "ArrowRight", 0], [0, "ArrowLeft", 2], [2, "ArrowLeft", 1], [2, "Home", 0], [0, "End", 2]];
    ok(keys.every(([from, k, to]) => same(press(from, k), [to, true, true, true])) && same(press(1, "a"), [1, false, false, false]) && same(press(1, "toString"), [1, false, false, false]) && same(press(1, "Enter"), [1, false, false, false]),
      "donateTabKey: the arrow keys (wrapping), Home and End move to a tab, pick it and focus it, and stop there (preventDefault + stopPropagation, so the skill page behind never sees them); other keys are left alone");
    {
      const seen = [], ev = (k, from) => ({ key: k, target: tabs[from], preventDefault() {}, stopPropagation() {} });
      show(tabs, panels, 1); key(ev("ArrowRight", 1), tabs, panels, (at) => seen.push([at, picked()])); key(ev("a", 2), tabs, panels, (at) => seen.push([at, picked()]));
      ok(same(seen, [[2, 2]]), `donateTabKey calls its shown(at) after a switch, with the new tab already picked, and not for other keys (got ${JSON.stringify(seen)})`);
    }
    // the skill details page's document ← / → (navigateSkill) must stand down behind an open pop-up and for a key already handled
    const skillKeys = (html.match(/document\.addEventListener\("keydown", \(e\) => \{[^\n]*\r?\n(?:[^\n]*\r?\n){0,8}?[^\n]*navigateSkill\(-1\)/) || [""])[0];
    ok(skillKeys.includes("e.defaultPrevented") && skillKeys.includes(`document.querySelector('[aria-modal="true"]:not([hidden])')`), "the skill details page's ← / → handler must return for e.defaultPrevented and while an [aria-modal=\"true\"]:not([hidden]) pop-up is open (the ☕ tabs use the arrows)");
    const live = page("donateTabs"), livePanels = page("donatePanels"), was = [live.slice(), livePanels.slice()];
    try {
      live.splice(0, live.length, ...tabs); livePanels.splice(0, livePanels.length, ...panels);
      show(tabs, panels, 2); page("openDonateModal")();
      const first = picked();
      show(tabs, panels, 1); page("closeDonateModal")(); page("openDonateModal")(); page("closeDonateModal")();
      ok(first === 0 && picked() === 0 && !panels[0].hidden && panels[1].hidden && panels[2].hidden, `every open of the pop-up picks QR โอนเงิน (got tab ${first}, then ${picked()})`);
    } catch (e) { ok(false, "opening the pop-up threw: " + e.message); }
    finally { live.splice(0, live.length, ...was[0]); livePanels.splice(0, livePanels.length, ...was[1]); }
  }
  // the donors' names line left the pop-up (user 2026-10-23: "this is already everywhere", the hub bar on every page and the phone menu
  // carry it): the thank-you line is followed by the tabs, and the list tab still carries the donor count, filled on the first open
  ok(/<\/p>\s*<div class="donate-tabs"/.test(modal) && !/donate-thanks|donateThanks/.test(modal) && !/donateThanksUi/.test(html)
    && /id="donateTabList"[^>]*><span class="donate-tab-icon donate-tab-heart"><svg [^>]*aria-hidden="true"[^>]*>[\s\S]*?<\/svg><span class="donate-tab-count" id="donateTabCount" hidden><\/span><\/span><span>รายชื่อผู้สนับสนุน<\/span><\/button>/.test(modal),
    "the ☕ pop-up must go straight from the thank-you line to the tabs (no names line, no donateThanksUi) and keep the list tab's #donateTabCount inside its heart");
  // the tabs are icon cards (user 2026-10-23, "การ์ดไอคอน" of three mocks, without its sub-lines): an aria-hidden icon over each label (QR, slip,
  // heart), every card its own box; opened from the thanks line onto รายชื่อผู้สนับสนุน, the QR and slip icons hop once (a plain open stays still)
  ok(/id="donateTabQr"[^>]*><svg class="donate-tab-icon" [^>]*aria-hidden="true"[\s\S]*?<\/svg><span>QR โอนเงิน<\/span><\/button>/.test(modal)
    && /id="donateTabSlip"[^>]*><svg class="donate-tab-icon" [^>]*aria-hidden="true"[\s\S]*?<\/svg><span>ส่งสลิป<\/span><\/button>/.test(modal)
    && /\.donate-tabs\{display:flex; gap:8px; width:100%\}/.test(html) && /\.donate-tab\{flex:1 1 0;[^}]*border:1px solid var\(--line\); border-radius:8px;[^}]*background:var\(--panel-2\)/.test(html)
    && /\.donate-tab\[aria-selected="true"\]\{background:var\(--gold\); border-color:var\(--gold\); color:#141311\}/.test(html),
    "the ☕ tabs must be icon cards: an aria-hidden icon over the label on QR โอนเงิน and ส่งสลิป (the heart on the list), each card its own --panel-2 box, the picked one gold");
  ok(/\.donate-tabs\.is-nudge \.donate-tab:nth-child\(-n\+2\) \.donate-tab-icon\{animation:donateTabHop \.5s [^;}]* \.35s 2 both\}/.test(html) && /@keyframes donateTabHop\{/.test(html)
    && /\.donate-tabs\.is-nudge \.donate-tab:nth-child\(2\) \.donate-tab-icon\{animation-delay:1\.35s\}/.test(html)
    && /function openDonateModal\(\) \{[\s\S]*?donateShowTab\(donateTabs, donatePanels, 0\);[^\n]*\r?\n  if \(donateTabBar\) donateTabBar\.classList\.remove\("is-nudge"\);[\s\S]*?\n\}/.test(html)
    && /function mountMenuThanks\(root\)\{[\s\S]*?donateShowTab\(donateTabs, donatePanels, at\); donateTabShown\(at\); donateTabsNudge\(\); \}\);/.test(html)
    && /function donateTabsNudge\(\)\{[\s\S]*?classList\.remove\("is-nudge"\);[\s\S]*?classList\.add\("is-nudge"\);[\s\S]*?\n\}/.test(html),
    "the QR โอนเงิน icon must hop twice, then the ส่งสลิป icon twice (user 2026-10-23), when the thanks line opens ☕ on รายชื่อผู้สนับสนุน (donateTabsNudge), and every plain open must clear it");
  ok(/function openDonateModal\(\) \{[\s\S]*?donateListUi\.rows = donorRecent\(donorRows\(DONORS\)\);[\s\S]*?if \(donateTabCount\) donateCountFill\(donateTabCount, donateListUi\.rows\.length\);[\s\S]*?\n\}/.test(html),
    "the list tab's count must be filled on the first open (donateCountFill with the number of donors)");
  // ขอบคุณผู้ร่วมสนับสนุน (user 2026-10-23): the same names line behind a label, mounted right after the launcher, in two copies: desktop
  // .hub-thanks at the very top, taking turns with the Discord note on every page (20 s: thanks 70 % first, note 30 %, paused on hover / focus;
  // the note hidden until the script decides, so a reload never flashes it first); phones .ln-thanks on the menu under the hub bar; no donors =
  // the note stays still (html.has-thanks off); a click opens ☕ on the list tab
  ok(/^mountMenuThanks\(\$\("#launch"\)\);/m.test(html) && /function mountMenuThanks\(root\)\{[\s\S]*?ขอบคุณผู้ร่วมสนับสนุน[\s\S]*?renderDonorThanks\(ui\);[\s\S]*?donateShowTab\(donateTabs, donatePanels, at\); donateTabShown\(at\);[\s\S]*?make\("ln-thanks", root, root\.firstChild\)[\s\S]*?make\("hub-thanks", hub, note \? note\.nextSibling : null\)[\s\S]*?classList\.toggle\("has-thanks", !uis\[0\]\.box\.hidden\);\r?\n\s*document\.documentElement\.classList\.add\("thanks-ready"\);[\s\S]*?\n\}/.test(html)
    && /if \(!root\)\{ document\.documentElement\.classList\.add\("thanks-ready"\); return null; \}/.test(html)
    && /@media \(min-width:901px\)\{\r?\n\s*\.donate-thanks\.ln-thanks\{display:none\}\r?\n\s*html:not\(\.thanks-ready\) \.hub-note\{visibility:hidden\}[^\n]*\r?\n\s*html\.has-thanks \.donate-thanks\.hub-thanks:not\(\[hidden\]\)\{display:inline-flex; animation:hubThanksTurn 20s linear infinite\}\r?\n\s*html\.has-thanks \.hub-note\{animation:hubNoteTurn 20s linear infinite\}/.test(html)
    && /@keyframes hubThanksTurn\{\s*0%, 67%\{opacity:1; visibility:visible; transform:translate\(-50%, -50%\);[^}]*\}\s*70%\{opacity:0; visibility:hidden; transform:translate\(-50%, calc\(-50% - 14px\)\)\}\s*70\.1%, 97%\{opacity:0; visibility:hidden; transform:translate\(-50%, calc\(-50% \+ 14px\)\);[^}]*\}\s*100%\{opacity:1; visibility:visible; transform:translate\(-50%, -50%\)\}\s*\}/.test(html)
    && /@keyframes hubNoteTurn\{\s*0%, 67\.5%\{opacity:0; visibility:hidden; transform:translate\(-50%, calc\(-50% \+ 14px\)\);[^}]*\}\s*70\.5%, 97%\{opacity:1; visibility:visible; transform:translate\(-50%, -50%\);[^}]*\}\s*99\.9%\{opacity:0; visibility:hidden; transform:translate\(-50%, calc\(-50% - 14px\)\)\}/.test(html)
    && /:has\(\.hub-note:hover, \.hub-note:focus-within, \.hub-thanks:hover, \.hub-thanks:focus-visible\) :is\(\.hub-note, \.hub-thanks\)\{animation-play-state:paused\}/.test(html)
    && /\.donate-thanks\.hub-thanks\{display:none; position:absolute; left:50%; top:50%;/.test(html),
    "the ขอบคุณผู้ร่วมสนับสนุน line (mountMenuThanks after mountLauncher): at the very top taking turns with the Discord note on every desktop page (thanks first, 70 / 30, paused on hover), under the hub bar on phones, opening the list tab");
  // the list tab's pages (user 2026-10-23): a hidden ‹ n / N › pager under the list; laid out whenever the tab shows (click, arrow keys, the
  // names line) and on resize; every open starts on the newest page
  ok(/<ol class="donate-list" id="donateList"><\/ol>\s*<div class="donate-pager" id="donatePager" hidden><button type="button" class="donate-pager-btn" id="btnDonatePrev" aria-label="หน้าก่อน">‹<\/button><span class="donate-pager-num" id="donatePagerNum" aria-live="polite"><\/span><button type="button" class="donate-pager-btn" id="btnDonateNext" aria-label="หน้าถัดไป">›<\/button><\/div>\s*<\/div>/.test(modal),
    "the รายชื่อผู้สนับสนุน panel needs its pager (#donatePager, hidden, ‹ หน้าก่อน, #donatePagerNum, › หน้าถัดไป) right under the list");
  ok(/t\.addEventListener\("click", \(\) => \{ donateShowTab\(donateTabs, donatePanels, i\); donateTabShown\(i\); \}\);/.test(html)
    && /t\.addEventListener\("keydown", \(e\) => donateTabKey\(e, donateTabs, donatePanels, donateTabShown\)\);/.test(html)
    && /function donateTabShown\(at\)\{\r?\n  if \(donatePanels\[at\] && donatePanels\[at\] === donateListUi\.box\) donateListFit\(donateListUi\);/.test(html)
    && /window\.addEventListener\("resize", \(\) => \{ if \(donateModal && !donateModal\.hidden\) donateListFit\(donateListUi\); \}\);/.test(html)
    && /function openDonateModal\(\) \{[\s\S]*?donateListUi\.rows = donorRecent\(donorRows\(DONORS\)\);[\s\S]*?donateListUi\.page = 0;[\s\S]*?\n\}/.test(html),
    "the list must lay out its pages whenever its tab shows (click, arrow keys, the menu's thanks line: donateTabShown → donateListFit) and on resize, hold its rows newest first (donorRecent) and open on page 1");
  if (have("donorTicker", "DONATE_TICKER_SPEED")) {
    const tick = page("donorTicker"), v = page("DONATE_TICKER_SPEED");
    ok(tick(100, 200, 16) === null && tick(200, 200, 16) === null && same(tick(201, 200, 16), { shift: 217, dur: 217 / v }) && same(tick(500, 120, 16), { shift: 516, dur: 516 / v }) && v > 0,
      "donorTicker: names that fit stand still (null); wider ones move by one set plus the gap to its copy, at DONATE_TICKER_SPEED px a second");
  }
  ok(/function donateThanksFit\(ui\)\{[\s\S]*?ui\.copy = ui\.set\.cloneNode\(true\);\r?\n  ui\.copy\.setAttribute\("aria-hidden", "true"\);[\s\S]*?\n\}/.test(html)
    && /\.donate-thanks:hover \.donate-thanks-track, \.donate-thanks:focus-visible \.donate-thanks-track\{animation-play-state:paused\}/.test(html),
    "the names ticker must hide its second copy from screen readers and pause under the mouse and keyboard focus");
  ok(!/\.donate-msg\{[^}]*white-space:nowrap/.test(html),"the .donate-msg{white-space:nowrap} rule must go (the message wraps now)");
  ok(/\.donate-qr img\[hidden\]\{display:none\}/.test(html), ".donate-qr img[hidden]{display:none} is missing: .donate-qr img{display:block} would keep an empty QR image on screen when assets.js did not load");
  ok(["DONATE_ERRORS", "donateSubmit", "renderDonorList"].every((n) => !missing.includes(n) && !/\bAI\b/.test(n === "DONATE_ERRORS" ? JSON.stringify(page(n)) : String(page(n)))), "the pop-up's script texts must not mention AI");
  const inSurfaces = (list, group) => { const m = html.match(new RegExp("\\n\\s*" + group + ": \\[([^\\]]*)\\]")); return !!m && list.every((s) => m[1].includes(JSON.stringify(s))); };
  ok(inSurfaces([".donate-form-box", ".donate-list-box"], "panel") && inSurfaces([".donate-form input", ".donate-form textarea"], "field") && !html.includes('".donate-tabs"')
    && /\n\s*raised: \[[^\n]*"\.donate-tab:not\(\[aria-selected=\\"true\\"\]\)"/.test(html),
    "the pop-up's panels (.donate-form-box, .donate-list-box), its tab cards not picked (.donate-tab:not([aria-selected=\"true\"]), raised; the bar itself has no box) and fields (.donate-form input / textarea) must be in THEME_SURFACES");

  // the donor list: donorRows(DONORS) as text only (names and messages are typed by donors), ×N only for a repeat donor, a Thai date
  if (have("renderDonorList")) {
    const doc = sandbox.document, savedCreate = doc.createElement;
    let htmlWrites = 0;
    const node = (tag) => {
      const n = { tagName: String(tag).toUpperCase(), className: "", children: [], _t: "", dataset: {}, attrs: {}, setAttribute(k, x) { this.attrs[k] = String(x); }, appendChild(c) { this.children.push(c); return c; }, append(...cs) { cs.forEach((c) => this.children.push(typeof c === "string" ? { textContent: c, children: [], className: "" } : c)); }, insertAdjacentHTML() { htmlWrites++; } };
      Object.defineProperty(n, "textContent", { get() { return this._t + this.children.map((c) => c.textContent).join(""); }, set(x) { this._t = String(x); this.children = []; } });
      Object.defineProperty(n, "innerHTML", { get() { return ""; }, set() { htmlWrites++; } });
      return n;
    };
    const find = (n, cls) => { if (String(n.className).split(" ").includes(cls)) return n; for (const c of n.children || []) { const f = find(c, cls); if (f) return f; } return null; };
    doc.createElement = node;
    try {
      const evil = '<img src=x onerror="alert(1)">', list = node("ol"), empty = node("ol");
      page("renderDonorList")(list, [{ id: "a", name: evil, msg: "<b>สู้ ๆ</b> 🐱", total: 1000, count: 2, date: "2026-10-23T14:05", first: "2026-10-01T10:00" }, { id: "b", name: "Mai", msg: "", total: 0.3, count: 1, date: "2026-10-01T09:00", first: "2026-10-01T09:00" }]);
      page("renderDonorList")(empty, []);
      const [r1, r2] = list.children, txt = (r, cls) => { const f = r && find(r, cls); return f ? f.textContent : null; };
      ok(htmlWrites === 0, "renderDonorList writes HTML: donor names and messages must go in with textContent only");
      ok(list.children.length === 2 && txt(r1, "donate-row-name") === evil && txt(r1, "donate-row-msg") === "<b>สู้ ๆ</b> 🐱" && txt(r2, "donate-row-name") === "Mai" && txt(r2, "donate-row-msg") === null, "renderDonorList shows each name and message as typed (no message line when there is none)");
      ok(txt(r1, "donate-row-amt") === "฿1,000" && txt(r2, "donate-row-amt") === "฿0.30" && txt(r1, "donate-row-count") === "×2" && txt(r2, "donate-row-count") === null, `renderDonorList amounts and repeat counts: ${JSON.stringify([txt(r1, "donate-row-amt"), txt(r2, "donate-row-amt"), txt(r1, "donate-row-count"), txt(r2, "donate-row-count")])}`);
      ok(txt(r1, "donate-row-date") === "23 ต.ค. 2026" && txt(r2, "donate-row-date") === "1 ต.ค. 2026", `renderDonorList dates: ${JSON.stringify([txt(r1, "donate-row-date"), txt(r2, "donate-row-date")])}`);
      ok(empty.children.length === 1 && empty.textContent === "ยังไม่มีรายชื่อ มาเป็นคนแรกกันครับ", `an empty list shows ยังไม่มีรายชื่อ มาเป็นคนแรกกันครับ (got ${JSON.stringify(empty.textContent)})`);
      if (have("renderDonorThanks")) {
        const ui = () => ({ box: node("button"), list: node("span") }), two = ui(), none = ui(), real = ui();
        const all = (n, cls, out = []) => { if (String(n.className).split(" ").includes(cls)) out.push(n); (n.children || []).forEach((c) => all(c, cls, out)); return out; };
        const names = (u) => all(u.list, "donate-thanks-name").map((c) => c.textContent);
        page("renderDonorThanks")(two, [{ id: "a", name: evil, msg: "", total: 1000, count: 2 }, { id: "b", name: "Mai", msg: "", total: 0.3, count: 1 }]);
        page("renderDonorThanks")(none, []);
        page("renderDonorThanks")(real);
        const set = two.set, heart = set && set.children[0];
        ok(htmlWrites === 0 && same(names(two), [evil, "Mai"]) && two.list.children.length === 1 && two.list.children[0] === two.track && two.track.children.length === 1 && two.track.children[0] === set
          && heart && heart.className === "donate-thanks-heart" && heart.textContent === "♥" && heart.attrs["aria-hidden"] === "true" && two.copy === null,
          "renderDonorThanks builds one set in the ticker's track: an aria-hidden ♥, then each name as typed (textContent only) in the rows' order");
        ok(two.box.hidden === false && none.box.hidden === true && names(none).length === 0,
          `renderDonorThanks shows the line only when there is someone to thank (got ${JSON.stringify([two.box.hidden, none.box.hidden])})`);
        if (have("donateCountFill")) {
          const c2 = node("span"), c0 = node("span");
          const c3 = node("span");
          page("donateCountFill")(c2, 2); page("donateCountFill")(c0, 0); page("donateCountFill")(c3, 120);
          ok(c2.textContent === "2" && c2.hidden === false && c0.textContent === "" && c0.hidden === true && c2.dataset.len === "1" && c3.textContent === "120" && c3.dataset.len === "3",
            `donateCountFill shows the number of donors in the list tab's heart, hidden at 0, with its digit count for the font (got ${JSON.stringify([c2.textContent, c2.hidden, c0.textContent, c0.hidden, c2.dataset.len, c3.dataset.len])})`);
        }
        ok(same(names(real), page("donorRows(DONORS)").map((r) => r.name)), "renderDonorThanks without rows shows donorRows(DONORS): every donor's latest name, biggest total first");
      }
      if (have("donateListPage")) {
        const btn = () => ({ disabled: false, focused: false, focus() { this.focused = true; } });
        const rowsN = (n) => Array.from({ length: n }, (_, i) => ({ id: "d" + i, name: "n" + i, msg: "", total: 10, count: 1, date: "2026-10-23T10:00", first: "2026-10-23T10:00" }));
        const lui = { list: node("ol"), pager: { hidden: true }, num: node("span"), prev: btn(), next: btn(), rows: rowsN(5), pages: [0, 2, 4], page: 1 };
        const shownNames = () => lui.list.children.map((li) => { const f = find(li, "donate-row-name"); return f ? f.textContent : null; });
        const state = () => [shownNames(), lui.num.textContent, lui.pager.hidden, lui.prev.disabled, lui.next.disabled];
        page("donateListPage")(lui); const mid = state();
        lui.page = 2; page("donateListPage")(lui); const last = state();
        lui.page = 0; lui.pages = [0]; page("donateListPage")(lui); const one = state();
        ok(same(mid, [["n2", "n3"], "2 / 3", false, false, false]) && same(last, [["n4"], "3 / 3", false, false, true]) && same(one, [["n0", "n1", "n2", "n3", "n4"], "1 / 1", true, true, true]),
          `donateListPage shows one page's rows, n / N, the arrows off at the ends and no pager for a single page (got ${JSON.stringify([mid, last, one])})`);
      }
    } catch (e) { ok(false, "renderDonorList threw: " + e.message); }
    finally { doc.createElement = savedCreate; }
  }

  // the async code in a child process: the page's functions as source, the stubs they see, donateChildTests(env)
  const childNames = ["DONATE_WORKER_URL", "DONOR_LIMITS", "DONATE_ERRORS", "donorSlipCheck", "shrinkSlip", "donateErrorText", "donateSend", "donateSubmit", "downloadQr"];
  if (have(...childNames)) {
    const decl = (name) => { const x = page(name); if (typeof x !== "function") return `const ${name} = ${JSON.stringify(x)};`; const s = String(x); return /^(async\s+)?function\b/.test(s) ? s : `const ${name} = ${s};`; };
    const msg = (d) => res(dl.checkSlipDetails, { name: "A", msg: "", ...d }).err;
    const env = { READ_ERROR, FAIL_TEXT, THANKS, MSG: { name: msg({ name: " " }), longName: msg({ name: "🐱".repeat(41) }), longMsg: msg({ msg: "ก".repeat(201) }) } };
    const script = [
      "(async () => {",
      "  const S = { bmp: { width: 4000, height: 3000 }, bmpFail: false, blobBytes: 1234, blobNull: false, fetch: async () => { throw new Error('no fetch stub'); } }, log = [], anchors = [], shares = [];",
      "  const realBitmap = async (file) => { if (S.bmpFail) throw new DOMException('The source image could not be decoded.', 'InvalidStateError'); return { width: S.bmp.width, height: S.bmp.height, close(){ log.push(['close']); } }; };",
      "  let createImageBitmap = realBitmap;",
      "  const canvas = () => { const c = { width: 0, height: 0, getContext(){ return { fillStyle: '', fillRect(){}, drawImage(img, ...a){ log.push(['draw', a]); } }; }, toBlob(cb, type, q){ log.push(['toBlob', type, q, c.width, c.height]); cb(S.blobNull ? null : new Blob([new Uint8Array(S.blobBytes)], { type })); } }; return c; };",
      "  const document = { createElement(tag){ if (String(tag).toLowerCase() === 'canvas') return canvas(); return { tagName: String(tag).toUpperCase(), style: {}, href: '', download: '', rel: '', click(){ anchors.push({ href: this.href, download: this.download }); }, remove(){} }; }, body: { appendChild(){}, removeChild(){}, style: {} } };",
      "  let navigator = {};",
      "  const fetch = (...a) => S.fetch(...a);",
      "  const setTimeout = () => 0;",
      "  const QR = 'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNk+M9QDwADhgGAWjR9awAAAABJRU5ErkJggg==';",
      "  let DONATE_QR = QR;",
      ...childNames.map(decl),
      "  const env = Object.assign(" + JSON.stringify(env) + ", { S, log, anchors, shares, shrinkSlip, donateSubmit, downloadQr, DONATE_ERRORS, DONATE_WORKER_URL,",
      "    setNav: (n) => { navigator = n; }, setQr: (q) => { DONATE_QR = q; }, restoreQr: () => { DONATE_QR = QR; }, dropBitmap: () => { createImageBitmap = undefined; }, restoreBitmap: () => { createImageBitmap = realBitmap; } });",
      "  const results = await (" + String(donateChildTests) + ")(env);",
      "  process.stdout.write(JSON.stringify(results));",
      "})().catch((e) => { process.stdout.write(JSON.stringify([{ pass: false, msg: 'the async checks threw: ' + String(e && e.stack || e) }])); });",
    ].join("\n");
    let results = null;
    try { results = JSON.parse(execFileSync(process.execPath, ["-"], { input: script, encoding: "utf8", timeout: 60000, maxBuffer: 1 << 24 })); }
    catch (e) { ok(false, "the async pop-up checks did not run: " + String(e.message).split("\n").slice(0, 3).join(" ")); }
    if (Array.isArray(results)) results.forEach((r) => ok(r.pass, r.msg));
  }
  console.log(`Verified ${donateChecked} ☕ pop-up checks (donors.js copies, tabs, slip redraw, send and errors, QR download, text-only donor list).`);
}

// Server balance + BB issues pages (mountNotePage, redesign 2026-10-18): one row per card with a servers.<srv>.changeNote, every
// line tagged, rows open #skill-details/<id>?server=<srv>, inline status / skill links do not navigate, and picking a type keeps the
// other type chips' counts (user 2026-10-18: a picked chip zeroed the others).
{
  const fail = (msg) => { console.error(`[SERVER PAGE ERROR] ${msg}`); errorCount++; };
  let checked = 0;
  const mount = (fn) => {
    const reg = new Map();
    const mk = () => { const e = makeEl(); e.listeners = {}; e.addEventListener = (t, f) => { e.listeners[t] = f; }; e.querySelectorAll = () => []; return e; };
    const root = mk(); root.querySelector = (sel) => { if (!reg.has(sel)) reg.set(sel, mk()); return reg.get(sel); };
    vm.runInContext(fn, sandbox)(root);
    const act = (a, v) => root.listeners.click({ target: { closest: (sel) => sel === "button[data-act]" ? { dataset: { act: a, v } } : null } });
    const chips = () => Object.fromEntries([...reg.get(".nl-kinds").innerHTML.matchAll(/data-v="(\w+)".*?<b>(\d+)<\/b><\/button>/g)].map(m => [m[1], +m[2]]));
    return { root, act, chips, list: () => reg.get(".nl-list").innerHTML, kinds: () => reg.get(".nl-kinds").innerHTML };
  };
  // picking one type leaves every other type chip's count as it was (and above 0), marks the pick, and a second click goes back to all
  const facets = (p, kind) => {
    const before = p.chips(); p.act("kind", kind); const after = p.chips(), others = Object.keys(before).filter(k => k !== "all" && k !== kind);
    if (!others.length || others.some(k => after[k] !== before[k] || !(after[k] > 0))) fail(`picking ${kind} changed the other type counts: ${JSON.stringify(before)} -> ${JSON.stringify(after)}`); else checked++;
    if (!new RegExp(`data-v="${kind}" class="is-on"`).test(p.kinds())) fail(`the picked type chip (${kind}) is not marked`); else checked++;
    p.act("kind", kind);
    if (!/data-v="all" class="is-on"/.test(p.kinds())) fail(`clicking ${kind} again did not go back to all`); else checked++;
  };
  const savedHash = sandbox.location && sandbox.location.hash;
  if (!sandbox.location) sandbox.location = { hash: "" };
  try {
    const p = mount("mountServerChanges"), api = p.root._serverChanges;
    for (const srv of ["tto", "tot"]) {
      api.setServer(srv);
      const want = SKILLS.filter(s => { const o = (s.servers && s.servers[srv]) || (srv === "tot" ? s.ps : null); return o && o.changeNote; }).length;
      const common = sandbox.commonServerNotes(srv).length, rows = (p.list().match(/class="nl-row[ "]/g) || []).length;
      if (rows !== want + common || want === 0) fail(`${srv}: ${rows} rows, want ${want} + ${common} Common`); else checked++;
      if (srv === "tto" ? common !== 3 : common !== 1) fail(`${srv}: ${common} Common rows`); else checked++;   // TTO: LCK, gear LCK, Magic Damage (2026-10-26)
      const opens = [...p.list().matchAll(/data-open="([^"]+)"/g)].map(m => m[1]);
      if (opens.length !== want || !opens.every(h => /^#skill-details\/[^?"]+\?server=/.test(h) && h.endsWith("?server=" + srv))) fail(`${srv}: rows do not open the card on this server`); else checked++;
      if (!/class="nl-tag is-svc" style="--kc:var\(--(pro|seal|tip)\)"/.test(p.list())) fail(`${srv}: no change-note tags rendered`); else checked++;
    }
    api.setServer("tto");
    facets(p, "nerf");
    const row = { dataset: { open: "#skill-details/wolf_counter?server=tot" } };
    p.root.listeners.click({ target: { closest: (sel) => sel === "[data-open]" ? row : null } });
    if (sandbox.location.hash !== row.dataset.open) fail(`row click sets hash ${sandbox.location.hash}`); else checked++;
    sandbox.location.hash = "";
    p.root.listeners.click({ target: { closest: (sel) => sel.includes(".sk-status") ? {} : sel === "[data-open]" ? row : null } });
    if (sandbox.location.hash !== "") fail("clicking a status inside a note navigated away"); else checked++;
    // BB issues page: one tagged line per bbIssueItems() entry, the same facet rule
    const b = mount("mountBbIssues"), items = sandbox.bbIssueItems();
    const lines = (b.list().match(/class="nl-line"/g) || []).length;
    if (lines !== items.length || !lines) fail(`BB issues: ${lines} lines, want ${items.length}`); else checked++;
    facets(b, "bug");
  } catch (e) { fail("page threw: " + e.message); }
  if (savedHash !== undefined) sandbox.location.hash = savedHash;
  console.log(`Verified ${checked} server balance / BB issues page checks.`);
}

// TTO wallpaper (user 2026-10-25): the TTO look is a wallpaper under a dark veil (TTO_WALLPAPER, a MANIFEST string container in assets.js, put on <html> as --tto-wallpaper);
// the stars, lanterns and harlequin of the old look are gone, and the page declares the container like the other string containers.
{
  let n = 0; const bad = (m) => { console.error(`[TTO THEME ERROR] ${m}`); errorCount++; }, good = (c, m) => { if (c) n++; else bad(m); };
  good(bibleAssets.MANIFEST.some((m) => m.name === "TTO_WALLPAPER" && m.empty === ""), 'scripts/bible_assets.js MANIFEST has no { name: "TTO_WALLPAPER", empty: "" }');
  good(/^const TTO_WALLPAPER = BIBLE_ASSETS_IN\.TTO_WALLPAPER \|\| "";\r?$/m.test(html), 'index.html does not declare const TTO_WALLPAPER = BIBLE_ASSETS_IN.TTO_WALLPAPER || "";');
  let wp = ""; try { wp = vm.runInContext("TTO_WALLPAPER", sandbox); } catch (e) {}
  const bytes = /^data:image\/webp;base64,/.test(wp) ? Buffer.from(wp.slice(23), "base64") : Buffer.alloc(0);
  good(bytes.length > 50000 && bytes.toString("latin1", 0, 4) === "RIFF" && bytes.toString("latin1", 8, 12) === "WEBP", "TTO_WALLPAPER is not a WebP data URI of a real picture (assets.js)");
  const tto = (/:root\[data-theme\]\[data-sk-server="tto"\]\{[\s\S]*?\n  \}/.exec(html) || [""])[0];
  good(/--th-page:[^;]*var\(--tto-wallpaper/.test(tto) && /--th-veil:/.test(tto) && /--th-solid:0%/.test(tto), "the TTO look must put --tto-wallpaper under --th-veil and use see-through surfaces");
  good(!/skTtoSky|--tto-stars|--tto-lantern|ensureServerBackdrops/.test(html), "the old TTO stars / lanterns code is still in index.html");
  good(html.includes('<div id="skWallCredit">cr. fuWaa</div>') && html.includes('html[data-sk-server="tto"] #skWallCredit{display:block}') && html.includes('octx.fillText("cr. fuWaa"'), "the wallpaper credit (cr. fuWaa) is missing: the page caption shown in the TTO look and/or the guide image text");
  good(html.includes('@media (max-width:760px){ html[data-sk-server="tto"] #skWallCredit{display:none} }'), "the cr. fuWaa caption must be hidden on phones (max-width 760px)");
  good(html.includes('html[data-sk-server="tto"] .ln-art{grid-column:1; grid-row:1}') && html.includes('html[data-sk-server="tto"] .ln-copy{grid-column:2; grid-row:1; justify-self:end}') && /@media \(min-width:901px\)\{\s*html\[data-sk-server="tto"\] \.ln-stage\{grid-template-columns:minmax\(0,58fr\) minmax\(0,42fr\)\}/.test(html), "the TTO look must mirror the hub showcase on PC (art left, text right, inside @media (min-width:901px))");
  console.log(`Verified ${n} TTO wallpaper theme checks.`);
}
// Reborn as the 4th server, infrastructure (user 2026-10-25): SERVER_INFO lists og / tot / tto / reborn, reborn is W.I.P. and its logo must be the stamped one while it is,
// the server tab shows Reborn only for a card that has servers.reborn, and the hard-coded server name maps are gone. The look is enabled (2026-10-25); class guides, the Chameleon simulator and the
// BB issues page are NOT enabled for Reborn yet (checked here so nobody enables one half way).
{
  let n = 0; const bad = (m) => { console.error(`[REBORN SERVER ERROR] ${m}`); errorCount++; }, good = (c, m) => { if (c) n++; else bad(m); };
  let info = {}; try { info = vm.runInContext("SERVER_INFO", sandbox); } catch (e) {}
  const keys = Object.keys(info);
  good(keys.join() === "og,tot,tto,reborn" && keys.every((k) => info[k].short && info[k].full), "SERVER_INFO must list og, tot, tto and reborn (in that order) with short and full names");
  const ic = (k) => String(SKILL_ICONS[k] || "");
  good(/^data:image\/webp;base64,/.test(ic("server_reborn")) && /^data:image\/webp;base64,/.test(ic("server_reborn_clean")), "server_reborn and server_reborn_clean must both be WebP icons in assets.js");
  good(info.reborn && (info.reborn.wip === true ? ic("server_reborn") !== ic("server_reborn_clean") : ic("server_reborn") === ic("server_reborn_clean")), "SERVER_INFO.reborn.wip and the logo must agree: wip true = server_reborn is the stamped logo, wip false = server_reborn equals server_reborn_clean (change both together)");
  good(!/\{ og: "BB", tot: "ToT", tto: "TTO" \}/.test(html) && !html.includes('og: "BB (BigBugStudio)", tot: "Tales of Tail (ToT)"'), "a hard-coded server name map is back in index.html: use SERVER_INFO / SERVER_FULL / SERVER_SHORT");
  { const plain = SKILLS.find((s) => !(s.servers && s.servers.reborn) && !s.ps), probe = Object.assign({}, plain, { servers: Object.assign({}, plain.servers, { reborn: { cd: 777 } }) });
    const gas = sandbox._getAvailableServers, gact = sandbox._getActiveSkill;
    good(typeof gas === "function" && !gas(plain).includes("reborn") && gas(probe).includes("reborn") && gas(probe).includes("og"), "a card lists Reborn as a server only when it has servers.reborn (and always keeps BB)");
    good(typeof gact === "function" && gact(probe, "reborn").cd === 777 && gact(plain, "reborn") === plain, "the Reborn overrides apply to the active skill, and a card without Reborn data falls back to the base card"); }
  good(!SKILLS.some((s) => s.servers && s.servers.reborn) || html.includes('SKILL_SIM_SERVERS = {') && /reborn: \{ name:/.test(html), "a card has servers.reborn: the page must also carry the Reborn simulator data (SKILL_SIM_SERVERS.reborn) before cards use it");
  good(vm.runInContext('THEME_CHOICES.join()', sandbox) === "auto,og,tot,tto,reborn" && vm.runInContext('CLASS_GUIDE_SERVER_KEYS.join()', sandbox) === "og,tot,tto,reborn", "THEME_CHOICES must be auto,og,tot,tto,reborn and the class guide server keys og,tot,tto,reborn (index 3 of the guide code)");
  // the Reborn look (user 2026-10-25): REBORN_WALLPAPER (WebP) under a dark veil, see-through glass, orange accent, in every shared surface selector
  good(bibleAssets.MANIFEST.some((m) => m.name === "REBORN_WALLPAPER" && m.empty === "") && html.includes('const REBORN_WALLPAPER = BIBLE_ASSETS_IN.REBORN_WALLPAPER || "";'), "REBORN_WALLPAPER must be a MANIFEST string container declared in index.html");
  { let rw = ""; try { rw = vm.runInContext("REBORN_WALLPAPER", sandbox); } catch (e) {}
    const rb = rw.startsWith("data:image/webp;base64,") ? Buffer.from(rw.slice(23), "base64") : Buffer.alloc(0);
    good(rb.length > 50000 && rb.toString("latin1", 0, 4) === "RIFF" && rb.toString("latin1", 8, 12) === "WEBP", "REBORN_WALLPAPER is not a WebP data URI of a real picture (assets.js)"); }
  { const i0 = html.indexOf(':root[data-theme][data-sk-server="reborn"]{'), blk = i0 < 0 ? "" : html.slice(i0, html.indexOf("\n  }", i0));
    good(blk.includes("var(--reborn-wallpaper") && blk.includes("--th-veil:") && blk.includes("--th-solid:0%") && blk.includes("--gold:#ef8a2a"), "the Reborn look must put --reborn-wallpaper under --th-veil, use see-through surfaces and the #ef8a2a orange"); }
  good(!html.includes('html:is([data-sk-server="tto"],[data-sk-server="tot"]) ') && html.includes("var G = 'html:is([data-sk-server=\"tto\"],[data-sk-server=\"tot\"],[data-sk-server=\"reborn\"]) ';") && html.includes('st === "tot" || st === "tto" || st === "reborn"'), "the theme selectors (THEME_SURFACES G, backdrop, boot script) must include reborn next to tto and tot");
  good(html.includes('urlOf("--" + look + "-wallpaper")') && html.includes('if (look !== "og"){ ctx.fillStyle = v("--th-wash")'), "the guide image export must draw the wallpaper and glass for every look but BB (Reborn included)");
  // Reborn in the skill simulator and the class guide editor (user 2026-10-25; data read from 12tails-reborn.com/skills, Reborn-Mechanics-Reference.md section 9)
  { const pools = vm.runInContext("SKILL_SIM_POOLS", sandbox), PR = pools.reborn, PB = pools.bb;
    const at = (lv) => PR.normal(lv) + "/" + PR.c(lv);
    good(at(1) === "0/0" && at(50) === "49/0" && at(55) === "49/1" && at(60) === "50/2" && at(150) === "59/20" && PR.ex(150) === 0, "Reborn pools: Lv 1 0/0, 50 49/0, 55 49/1, 60 50/2, 150 59/20 (the site's own numbers), no EX");
    good(PR.c(70) + PR.normal(70) <= 80 && PB.normal(95) === 49 && PB.c(95) === 9 && PB.ex(100) === 2, "BB / ToT / TTO pools unchanged: 49 normal and 9 C at Lv 95, 2 EX at Lv 100");
    const forEach = vm.runInContext("(fn) => Object.keys(SKILL_SIM).forEach(fn)", sandbox), cellsFor = vm.runInContext("skillSimCellsFor", sandbox), validFn = vm.runInContext("skillSimValid", sandbox), trees = vm.runInContext("skillSimTrees", sandbox), pass = vm.runInContext("skillSimPassive", sandbox);
    let classes = 0, bad2 = 0;
    forEach((cls) => {
      classes++; const rb = cellsFor("reborn", cls), bb = cellsFor("og", cls);
      const ids = [451, 452, 453, 454, 461, 462, 463, 464];
      if (!ids.every((id) => rb[id] && rb[id].tree === 3 && !rb[id].ex && rb[id].bn === 8 && rb[id].lv === (id < 460 ? 95 : 105) && rb[id].req.length > 0 && SKILL_ICONS[rb[id].icon])) { console.error(`[REBORN SERVER ERROR] ${cls}: the C6 / C7 cells 451-454 / 461-464 are missing or incomplete on Reborn`); errorCount++; bad2++; }
      if (ids.some((id) => bb[id]) || trees("og", cls) !== vm.runInContext("SKILL_SIM", sandbox)[cls] || trees("reborn", cls)[3].rows.length !== 7) { console.error(`[REBORN SERVER ERROR] ${cls}: BB must not get the Reborn rows (C tree 5 rows on BB, 7 on Reborn)`); errorCount++; bad2++; }
      if (!Object.keys(bb).every((id) => rb[id] && rb[id].lv === bb[id].lv && rb[id].bn === bb[id].bn && (cls === "panda" && id === "443" ? true : rb[id].req.join() === bb[id].req.join()))) { console.error(`[REBORN SERVER ERROR] ${cls}: Reborn cells differ from BB beyond the known Panda patch`); errorCount++; bad2++; }
      if (pass("reborn", cls).length < pass("og", cls).length) { console.error(`[REBORN SERVER ERROR] ${cls}: passive list shrank on Reborn`); errorCount++; bad2++; }
    });
    n += classes - bad2;
    const rbp = cellsFor("reborn", "panda");
    good(rbp[443].req.join() === "344" && cellsFor("og", "panda")[443].req.join() === "334", "Reborn Panda Heaven Breath (443) needs 344, BB 334");
    { const rr = cellsFor("reborn", "rabbit"), br = cellsFor("og", "rabbit");   // Reborn Rabbit (2026-10-26): Mall gone, 341-344 = Truce Trading & Co. 1-4, same Lv / bn / req
      good([341, 342, 343, 344].every((id, i) => rr[id].icon === "rabbit_truceTrading&co" + (i + 1) && rr[id].name === "Truce Trading & Co. " + (i + 1) && SKILL_ICONS[rr[id].icon] && rr[id].lv === br[id].lv && rr[id].bn === br[id].bn && rr[id].req.join() === br[id].req.join()) && br[341].icon === "rabbit_mall1" && br[343].icon === "rabbit_truceTrading&co1",
        "Reborn Rabbit 341-344 must be Truce Trading & Co. 1-4 with BB's Lv / bn / req (BB keeps Mall 1-2 and Truce Trading 1-2)");
      const drawn = trees("reborn", "rabbit").find((t) => t.base === 300).rows[4], drawnBB = trees("og", "rabbit").find((t) => t.base === 300).rows[4];   // what the grid, guide editor and guide image draw
      good(drawn.every((c, i) => c[0] === "rabbit_truceTrading&co" + (i + 1) && c[1] === "Truce Trading & Co. " + (i + 1)) && drawnBB[0][0] === "rabbit_mall1" && drawnBB[1][1] === "Mall 2",
        "the Reborn Rabbit grid rows (skillSimTrees) must draw Truce Trading & Co. 1-4 in 341-344, BB keeps Mall 1-2"); }
    // a legal Lv 150 Wolf build using the new rows: fill every skill the rules allow in id order and check the result validates and spends no more than the pools
    const wolf = cellsFor("reborn", "wolf"), set = new Set(); let used = 0, usedC = 0; const order = Object.keys(wolf).map(Number).sort((a, b) => a - b);
    let grew = true; while (grew) { grew = false; for (const id of order) { if (set.has(id)) continue; const t = new Set(set); t.add(id); const isC = id >= 400; if ((isC ? usedC + 1 > PR.c(150) : used + 1 > PR.normal(150))) continue; if (validFn(wolf, 4, t, 150)) { set.add(id); isC ? usedC++ : used++; grew = true; } } }
    good(set.size > 0 && validFn(wolf, 4, set, 150) && !validFn(wolf, 4, new Set([...set, 464].filter((x) => x !== 454)), 150), "Reborn Wolf: a greedy Lv 150 build validates, and Shadow Pack (464) without Alpha Howl (454) does not");
    good(!validFn(wolf, 4, new Set([451]), 150) && !validFn(wolf, 4, set, 94) && validFn(wolf, 4, new Set(), 150), "Reborn: a C6 skill alone, or a Lv 150 build at Lv 94, is refused");
    const gc = require(path.join(__dirname, "guide_code.js")), g = { format: "12t-class-guide", version: 1, title: "t", author: "a", date: "2026-10-25", description: "", build: { server: "reborn", classKey: "wolf", level: 150, learned: [101, 102, 103] } };
    let back = null; try { back = gc.decode(gc.encode(g)); } catch (e) {}
    good(back && back.build.server === "reborn" && back.build.level === 150 && back.build.classKey === "wolf", "a guide code with server reborn and level 150 survives encode / decode (scripts/guide_code.js)");
    good(typeof vm.runInContext("skillSimPools", sandbox) === "function" && vm.runInContext("CLASS_GUIDE_SERVER_KEYS", sandbox).indexOf("reborn") === 3, "the guide code server index of reborn is 3 (page and scripts/guide_code.js)");
    good(gc.CLASS_GUIDE_SERVER_KEYS.join() === "og,tot,tto,reborn", "scripts/guide_code.js server keys must be og,tot,tto,reborn"); }
  // Rabbit Mix Shot (Reborn C6 452, user 2026-10-25): a Reborn-only card with the Eagle Eye range toggle (desc and reach), Rapid Trance (no cooldown) and
  // Medical Enhancement (both durations), linked to its five BB skills only on Reborn; Rapid Trance's cooldown / cast toggle on the ten BB skills it affects
  { const ms = SKILLS.find(s => s.id === "rabbit_mixshot"), set = (id, r) => { sandbox._depRanks[id] = r; };
    good(ms && ms.onlyServer === "reborn" && !ms.soon && ms.cost.mp === 10 && ms.cost.sp === 30 && ms.cost.spType === "red" && ms.cd === 60 && ms.cdDep && ms.cdDep.id === "rapidTrance" && ms.cdDep.kind === "replace" && ms.cdDep.replaceValue === 0, "Mix Shot: Reborn-only, MP 10, SP 30 consumed, cooldown 60 s that Rapid Trance sets to 0");
    good(ms && !/\*\*(24|32\.4)m\*\*/.test(ms.desc(1, 0) + ms.desc(1, 1)) && /ภายในระยะยิง/.test(ms.desc(1, 0)) && /Rapid Trance/.test(ms.desc(1, 0)) && !!ms.reach, "Mix Shot desc: no sizes (24 m / 32.4 m live in its reach), and the Rapid Trance line");
    let r0 = null, r1 = null; try { set("eagleEye", 0); r0 = ms.reach()[0].r; set("eagleEye", 1); r1 = ms.reach()[0].r; set("eagleEye", 0); } catch (e) {}
    good(r0 === 24 && r1 === 32.4 && ms.reachControls && ms.reachControls[0].id === "eagleEye", "Mix Shot reach: a 24 m sphere, 32.4 m with the Eagle Eye toggle in the range popup");
    const five = ["rabbit_medicalEnhancement", "rabbit_heatShot", "rabbit_boostShot", "rabbit_lifeShot", "rabbit_rapidTrance"].map(id => SKILLS.find(s => s.id === id));
    good(five.every(s => s && !(s.compatSkills || []).includes("rabbit_mixshot") && s.servers && s.servers.reborn && s.servers.reborn.compatSkills.includes("rabbit_mixshot")), "the five BB skills link Mix Shot only in servers.reborn.compatSkills");
    const rt = ["rabbit_mix", "rabbit_shake", "rabbit_miracleBlend", "rabbit_stickyGum", "rabbit_acidicField", "rabbit_healingField", "rabbit_immuneShot", "rabbit_boostShot", "rabbit_heatShot", "rabbit_lifeShot"].map(id => SKILLS.find(s => s.id === id));
    good(rt.every(s => s && s.cdDep && s.cdDep.id === "rapidTrance" && (s.castTime === undefined || (s.castDep && s.castDep.id === "rapidTrance"))), "Rapid Trance cooldown toggle on the ten skills it affects, and the cast toggle on the six with a cast bar");
    const ee = SKILLS.find(s => s.id === "rabbit_eagleEye");
    good(ee && ee.onlyServer === "reborn" && !ee.soon && ee.passive && (ee.compatSkills || []).includes("rabbit_mixshot") && !SKILLS.some(s => s.soon && /[0-9]$/.test(s.id)), "Eagle Eye is a real Reborn-only passive card linked to Mix Shot (no stub, SOON_EXTRA empty), and stub ids drop the rank digit"); }
  // Reborn C6 / C7 Rabbit (2026-10-26): Eagle Eye's RabReach rounding, the Combo / Charge Attack distance boxes, Reborn reach sizes, and Carron Gambit's post-DEF finalOut in the Final range and the Test roll
  { const ev = (s) => vm.runInContext(s, sandbox), dr = sandbox._depRanks, saved = { ...dr }, savedAtk = sandbox._statInputs.atk.value;
    const setDeps = (o) => { for (const k of Object.keys(dr)) delete dr[k]; Object.assign(dr, saved, o); };
    good(ev("[16, 21, 26, 31, 36, 20, 25, 30, 35, 40].map(rbEyeRound).join()") === "22,28,35,42,49,27,34,40,47,54", "Eagle Eye RabReach = RoundToInt(n x 1.35f), float32, .5 to even (30 -> 40)");
    good(ev("finalOutAdjust({ finalOut: () => 1.6 }, 101)") === 162 && ev("finalOutAdjust({ finalOut: () => 1.15 }, 100)") === 115 && ev("finalOutAdjust({}, 77)") === 77 && ev("finalOutAdjust({ finalOut: () => 1.6 }, 0)") === 0, "finalOut = CeilToInt((float)dmg x factor), nothing at 1 or 0 damage");
    setDeps({ eagleEye: 1, rabComboLv: 4 }); sandbox._setServer("reborn");
    good(ev("rabbitComboMaxDistance(4)") === 49 && ev("rabbitChargeMaxDistance()") === 54, "Reborn + Eagle Eye: Combo 4 reaches 49 m, Charge Attack 54 m");
    sandbox._setServer("og");
    good(ev("rabbitComboMaxDistance(4)") === 36 && ev("rabbitChargeMaxDistance()") === 40, "BB keeps 36 m / 40 m with the Eagle Eye toggle on");
    const rr = (id, o) => { setDeps(o); const sk = SKILLS.find(s => s.id === id); return sandbox._reachNormalize(sk.servers.reborn.reach, sk.maxRank || 1); };
    good(rr("rabbit_acidicField", { eagleEye: 1 })[0].r === 16.2 && rr("rabbit_acidicField", {})[0].r === 12 && rr("rabbit_tenShot", { eagleEye: 1 }).every(p => p.r === 32.4) && rr("rabbit_gilShot", { eagleEye: 1, rabComboLv: 4 })[0].l === 49 && rr("rabbit_statScan", { eagleEye: 1 })[0].r === 54 && rr("rabbit_bounce", { eagleEye: 1, skyfallSniper: 1 })[0].r === 10.8, "Reborn reach goldens: Acidic Field 16.2 m, Ten Shot 32.4 m, Gil Shot 49 m at Combo 4, the 54 m lock, Bounce landing 10.8 m with Skyfall Sniper");
    for (const sk of SKILLS.filter(s => s.class === "Rabbit" && s.servers && s.servers.reborn && s.servers.reborn.reach)) for (const e of [0, 1]) { let ps = []; try { ps = rr(sk.id, { eagleEye: e, skyfallSniper: e, fieldPharmacy: e, rabComboLv: 4 }); } catch (x) { ps = null; } good(Array.isArray(ps) && ps.every(p => p.src && ["r", "w", "w2", "l", "h"].every(k => p[k] === undefined || p[k] === "inf" || p[k] > 0)), sk.id + " Reborn reach (Eagle Eye " + e + "): positive sizes and a src"); }
    sandbox._setServer("reborn"); sandbox._statInputs.atk.value = "300";
    for (const id of ["rabbit_maimShot", "rabbit_tenShot", "rabbit_thousandShot", "rabbit_bulletRain", "rabbit_bounce"]) { const sk = SKILLS.find(s => s.id === id), r = sk.maxRank || 1, fin = {};
      for (const h of [0, 3]) { setDeps({ carronGambit: h, fromTheAbove: 1, skyfallSniper: 1 }); sandbox._skillRanks[id] = r; sandbox._calcRangeFor = undefined; sandbox._selectSkill(sk); const act = sandbox._activeSimSkill();
        fin[h] = sandbox._finalRangeForRange(sandbox._calcRangeFor(sandbox._getDmgText(act, r))); let lo = Infinity, hi = -Infinity; for (let i = 0; i < 300; i++) { const x = sandbox._rollOneHit(act, r); lo = Math.min(lo, x); hi = Math.max(hi, x); }
        good(lo >= fin[h][0] && hi <= fin[h][1], id + " Reborn, " + h + " heads: Test " + lo + "-" + hi + " inside the Final range " + fin[h].join("-")); }
      good(fin[3][1] > fin[0][1], id + ": 3 Carron Gambit heads raise the Final range (" + fin[0][1] + " -> " + fin[3][1] + ")"); }
    setDeps({}); sandbox._statInputs.atk.value = savedAtk; sandbox._setServer("og"); }
  // a Reborn desc is the card's base desc plus the change (bible-desc-writing): it must share most of its words with that base desc. Catches an override
  // that a patch put on the wrong card (user 2026-10-25: Mimic's Reborn text showed on Dark Intention, War Capital's on Monkey nAttack). Full reworks opt out with rebornRework:true.
  { const words = (s) => new Set(String(s || "").replace(/<[^>]+>|[*_^\[\]()]/g, " ").split(/\s+/).filter((w) => w.length > 1));
    const at = (d, r) => { try { return typeof d === "function" ? d(r, 0) : d; } catch (e) { return ""; } };
    const bad = SKILLS.filter((s) => s.servers && s.servers.reborn && s.servers.reborn.desc && s.desc && !s.servers.reborn.rebornRework && !s.onlyServer).filter((s) => {
      const a = words(at(s.desc, 1)), b = words(at(s.servers.reborn.desc, 1)); if (!a.size) return false;
      let shared = 0; a.forEach((w) => { if (b.has(w)) shared++; }); return shared / a.size < 0.5; }).map((s) => s.id);
    good(!bad.length, "Reborn desc shares less than half its words with the card's own base desc (an override on the wrong card?) on: " + bad.join(", ")); }
  // every Reborn desc renders at every rank and desc dep rank (user 2026-10-26): descSwap throws when the base wording it edits has moved, and the
  // other desc loops skip a desc that throws, so a missed swap would show the BB text on Reborn without an error.
  { const thrown = [];
    sandbox._setServer("reborn");
    SKILLS.filter((s) => s.servers && s.servers.reborn && typeof s.servers.reborn.desc === "function").forEach((s) => {
      const maxDr = s.descDep && s.descDep.maxRank !== undefined ? s.descDep.maxRank : 1;
      for (let r = 1; r <= Math.max(1, s.maxRank || 1, s.servers.reborn.maxRank || 1); r++) for (let dr = 0; dr <= maxDr; dr++) {   // a Reborn maxRank (Truce Trading 4) is rendered too
        try { s.servers.reborn.desc(r, dr); } catch (e) { thrown.push(s.id + " rank " + r + " dep " + dr + ": " + e.message); return; }
      }
    });
    sandbox._setServer("og");
    if (thrown.length) { console.error("[REBORN DESC ERROR] a Reborn desc throws (descSwap found no base text?): " + thrown.join("; ")); errorCount++; } else n++; }
  // the Reborn engine rules (user 2026-10-26; Reborn-Mechanics-Reference.md §2.1, §2.2, §2.4), worked by hand, on probe cards so the result does not
  // depend on which cards carry Reborn data: ItemChance = (130n + 99) / 100 in integers (18 -> 24, 10 -> 13, not the float 14; 21 -> 28); on a card with
  // Reborn data a player's TAL 600 gives 100 x (1 + 0.02 x 600) = 1300, CHA 600 100 x (1 + 0.015 x 600) = 1000, INT 640 a cast of 30 - 640/32 = 10;
  // a summon's own TAL, a card without Reborn data and BB stay at the 512 cap (1124, 868, 14); the belt adds 3 on Reborn only; a gear chance reads no LCK.
  { const R = (code) => vm.runInContext(code, sandbox);
    good(R("itemChance(18) === 24 && itemChance(10) === 13 && itemChance(21) === 28 && itemChance(0) === 0 && itemChance(90) === 100"), "itemChance: 18 -> 24, 10 -> 13, 21 -> 28, 0 -> 0, at most 100");
    const run = (srv) => { sandbox._setServer(srv); return R(`(() => {
      const cat = SKILLS.find((s) => s.id === "cat_nAttack"), phx = SKILLS.find((s) => s.ownStatsPhoenix);
      const pl = Object.assign({}, cat, { servers: { reborn: { cd: 1 } } }), sm = Object.assign({}, phx, { servers: { reborn: { cd: 1 } } }), bb = Object.assign({}, cat, { servers: {} });
      const out = [];
      statCapCard = pl; out.push(talAdjustAtRoll(100, 600, 0), chaAdjustAtRoll(100, 600, 0), magAdjustAtRoll(30, 640, 0), talAdjustAtRoll(100, 600, 0, false));
      _depRanks.rbCritBelt = 1; out.push(rbBelt()); _depRanks.rbCritBelt = 0;
      statCapCard = sm; out.push(talAdjustAtRoll(100, 600, 0), talAdjustAtRoll(100, 600, 0, false));
      statCapCard = bb; out.push(talAdjustAtRoll(100, 600, 0), chaAdjustAtRoll(100, 600, 0));
      out.push(critChance(18, 0, pl), critChance(18, 0, bb) === lckAdjustChance(18, 0), procChance({ itemChance: true }, 18, 200, pl), procChance({ itemChance: true }, 18, 200, bb) === lckAdjustChance(18, 200));
      out.push(lckProcLive({ itemChance: true, chance: 18 }, pl), lckProcLive({ itemChance: true, chance: 18 }, bb));
      statCapCard = null; return out.join(); })()`); };
    const rb = run("reborn"), og = run("og"); sandbox._setServer("og");
    good(rb === "1300,1000,10,1300,3,1124,1300,1124,868,24,true,24,true,false,true", "Reborn engine rules on a Reborn card (TAL / CHA / INT uncapped, belt +3, summon TAL 1124, gear crit 24% with no LCK): got " + rb);
    good(og.split(",").slice(0, 3).join() === "1124,868,14" && og.split(",")[4] === "0" && og.split(",")[9] === String(vm.runInContext("lckAdjustChance(18, 0)", sandbox)), "BB keeps the 512 caps, no belt and lckAdjust for gear crit: got " + og); }
  console.log(`Verified ${n} Reborn server infrastructure checks.`);
}
// liveCheck (GEMINI.md §2): a card value that follows the code but awaits an in-game check renders as the last line of
// the description box ("⚠ ยังไม่ยืนยันในเกม: ...").
{
  let checkedLive = 0;
  for (const sk of SKILLS.filter(s => s.liveCheck)) {
    sandbox._skillRanks[sk.id] = sk.maxRank || 1; sandbox._selectSkill(sk);
    if (!sandbox._getRenderedHeroHtml().includes('<span class="sk-live-check">⚠ ยังไม่ยืนยันในเกม: ')) { console.error(`[LIVE CHECK ERROR] ${sk.id}: liveCheck set but no marker rendered`); errorCount++; }
    else checkedLive++;
  }
  console.log(`Verified ${checkedLive} liveCheck markers.`);
}

// durAdjust:"tal" (Stun Mine on BB, Mole_stunMine.cs:60): the duration chip runs talAdjust with the player's TAL,
// ignores CHA, wears the TAL colour (.sk-stat-dur-tal) and makes TAL (not CHA) glow.
{
  let ok = 0;
  const fail = (m) => { console.error(`[DUR ADJUST ERROR] ${m}`); errorCount++; };
  for (const sk of SKILLS.filter(s => s.durAdjust === "tal")) {
    const chaEl = sandbox._root.querySelector('[data-role="cha"]');
    const saved = [sandbox._statInputs.tal.value, chaEl.value];
    const durText = () => { const h = sandbox._getRenderedHeroHtml(); const i = h.indexOf('class="sk-stat sk-stat-dur'); return i < 0 ? "" : h.slice(i, i + 2000); };
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    sandbox._statInputs.tal.value = "0"; chaEl.value = "0"; sandbox._selectSkill(sk); const a = durText();
    sandbox._statInputs.tal.value = "200"; sandbox._selectSkill(sk); const b = durText();
    chaEl.value = "200"; sandbox._selectSkill(sk); const c = durText();
    [sandbox._statInputs.tal.value, chaEl.value] = saved;
    if (!a.includes("sk-stat-dur-tal")) fail(`${sk.id}: duration chip lacks the TAL class`);
    else if (a === b) fail(`${sk.id}: duration does not change with TAL`);
    else if (b !== c) fail(`${sk.id}: duration changes with CHA`);
    else if (!sandbox._getUsedPlayerStatKeys || ![...sandbox._getUsedPlayerStatKeys(sk)].includes("tal") || [...sandbox._getUsedPlayerStatKeys(sk)].includes("cha")) fail(`${sk.id}: stat glow should be TAL, not CHA`);
    else ok++;
  }
  console.log(`Verified ${ok} talAdjust duration chips.`);
}

// Special Pet Info (spec docs/superpowers/specs/2026-10-18-special-pet-info-design.md): PET_INFO against values
// transcribed from 12Tails-Mechanics-Reference.md §4.9, the renderers for every pet / level / LCK, and the tool wiring.
{
  const pf = (m) => { console.error(`[PET INFO ERROR] ${m}`); errorCount++; };
  try {
    const run = (code) => vm.runInContext(code, sandbox);
    const P = run("PET_INFO"), find = run("petInfoFind"), perMin = run("petInfoPerMin"), count = run("petInfoCount");
    const E = id => { const r = find(id); if (!r) pf(`no entry ${id}`); return r ? r.entry : null; };
    const roles = ["atk", "buff", "react", "res"].map(r => P.filter(p => p.role === r).length).join("/");
    if (roles !== "10/8/3/14") pf(`group sizes ${roles}, expected 10/8/3/14`);
    if (count() !== 40) pf(`count ${count()}, expected 40`);
    const FIX = [ // [id, N, every, dmg of target 1, radius, ko]
      ["p_lmc", 1, 6, 35, 1], ["p_lmc", 9, 6, 67, 5], ["p_lmn", 9, 3, 47, 5], ["p_lmo", 1, 9, 9, 4], ["p_lmo", 9, 9, 33, 12],
      ["p_msb", 1, 20, 14, 12], ["p_msb", 9, 12, 30, 12], ["p_mcb", 9, 12, 56, 8, 2], ["p_mab", 9, 12, 60, 24, 5],
      ["p_mrb", 1, 60, 60, 6], ["p_mrb", 9, 60, 220, 6], ["p_mmb", 1, 20, 5, 6, 5], ["p_mmb", 9, 12, 13, 6, 13],
      ["p_mgb", 1, 20, 20, 18, 2], ["p_mgb", 9, 12, 52, 18, 2], ["p_mnb", 1, 59, 20, 9], ["p_mnb", 9, 51, 60, 9],
    ];
    for (const [id, N, ev, d, r, ko] of FIX) {
      const e = E(id); if (!e) continue;
      if (e.every(N) !== ev) pf(`${id} N${N} every ${e.every(N)} != ${ev}`);
      if (e.hit.dmg(N, 1) !== d) pf(`${id} N${N} dmg ${e.hit.dmg(N, 1)} != ${d}`);
      const rr = e.area.blast || e.area.r(N); if (rr !== r) pf(`${id} N${N} radius ${rr} != ${r}`);
      if (ko !== undefined && (e.hit.ko ? e.hit.ko(N) : 0) !== ko) pf(`${id} N${N} ko != ${ko}`);
    }
    if (E("p_mgb") && E("p_mgb").hit.dmg(9, 4) !== 64) pf("MiniGolden 4th target at N9 != 64");
    if (perMin(E("p_mnb"), 9, 1) !== 282 || perMin(E("p_mgb"), 9, 5) !== 1160 || perMin(E("p_lmn"), 9, 1) !== 940) pf("per-minute values (expected 282 / 1160 / 940)");
    const CH = { 0: { res3: [4, 12], res5: [6, 14], anubi: [5, 13], karazo: 30, pirate: 4 }, 156: { res3: [9, 25], res5: [14, 29], anubi: [10, 26], karazo: 52, pirate: 9 } };
    for (const L of [0, 156]) {
      const c = CH[L];
      [[1, 0], [9, 1]].forEach(([N, i]) => {
        if (E("p_lcr").chance(N, L) !== c.res3[i]) pf(`L. Carron N${N} L${L}: ${E("p_lcr").chance(N, L)} != ${c.res3[i]}`);
        if (E("p_ldk").chance(N, L) !== c.res5[i]) pf(`L. Dead Pumpkon N${N} L${L}: ${E("p_ldk").chance(N, L)} != ${c.res5[i]}`);
        if (E("p_sab").chance(N, L) !== c.anubi[i]) pf(`S. Anubi N${N} L${L}: ${E("p_sab").chance(N, L)} != ${c.anubi[i]}`);
      });
      if (E("p_skz").chance(1, L) !== c.karazo) pf(`S. Karazo L${L}`);
      if (E("p_spf").chance(9, L) !== c.pirate) pf(`S. PirateFish L${L}`);
    }
    const B = (id, N, ev) => { const e = E(id); if (e && e.every(N) !== ev) pf(`${id} N${N} every ${e.every(N)} != ${ev}`); };
    B("p_lcs", 1, 30); B("p_lcs", 9, 14); B("p_skm", 1, 15); B("p_sfb", 9, 60); B("p_sim", 9, 45); B("p_sam", 9, 120); B("p_skr", 1, 43); B("p_skr", 9, 27); B("p_all1", 1, 60);
    const ky = find("p_sky"); if (!ky || ky.entry.id !== "p_skr" || ky.vi !== 2) pf("variant id p_sky does not open the kite family on index 2");
    if (E("p_lcp") && !E("p_lcp").flags.dead) pf("L. Carron (P) must be flagged dead");
    const GI = run("GEAR_ICONS");
    for (const p of P) for (const id of (p.vars ? p.vars.map(v => v.id) : [p.id])) if (!GI[id]) pf(`no icon for ${id}`);
    const SCM = run("STATUS_CLASS_MAP"), SDM = run("STATUS_DESC_MAP");
    for (const s of ["wash", "float"]) if (!SCM[s] || !SDM[s]) pf(`no status popup for ${s}`);
    if (SCM.wash !== "Magical" || SCM.float !== "Buff, Magical") pf("wash / float classification (StatusData.cs:5681, :5885, :6944)");
    console.log(`Verified Special Pet Info data: ${P.length} roster entries, ${count()} pets.`);
    // Renderers: every pet at levels 1 / 5 / 9 and LCK 0 / 156 / 999 renders with no raw markup, NaN or banned wording.
    const st = run("petInfoState"), det = run("petInfoDetailHtml"), ros = run("petInfoRosterHtml");
    // A rendered status is <span class="sk-status">[name]<popup …></span>: the brackets stay on screen, and the popup holds other
    // statuses' texts (e.g. drunken's own "lckAdjust(5×เลเวล)%"), so judge this tool's own text with whole status spans removed.
    const stripStatus = (html) => {
      let out = "", i = 0;
      for (;;) {
        const s = html.indexOf('<span class="sk-status"', i); if (s < 0) return out + html.slice(i);
        out += html.slice(i, s) + "[status]"; let d = 0, j = s;
        for (;;) { const o = html.indexOf("<span", j), c = html.indexOf("</span>", j); if (c < 0) return out; if (o >= 0 && o < c) { d++; j = o + 5; } else { d--; j = c + 7; if (!d) break; } }
        i = j;
      }
    };
    let renders = 0;
    for (const p of P) for (const N of [1, 5, 9]) for (const L of [0, 156, 999]) {
      const vi = {}; if (p.vars) vi[p.id] = p.vars.length - 1;
      const raw = det({ sel: p.id, vi, N, L }); renders++;
      if ((raw.match(/class="sk-status"/g) || []).length < (p.desc(N, L).match(/\[[a-zA-Z]+\d*\]/g) || []).length) pf(`${p.id} a [status] in its text did not render as a status`);
      const h = stripStatus(raw).replace(/\[status\]/g, "").replace(/data:[^"']*/g, "");   // pictures' base64 can spell "NaN" or "__" by chance (the 128 px Pumpkin icon, 2026-10-26)
      if (/NaN|undefined|\*\*|\^\^|__|\[[a-zA-Z]+\d*\]/.test(h)) pf(`${p.id} N${N} L${L} has raw markup or NaN: ${(h.match(/NaN|undefined|\*\*|\^\^|__|\[[a-zA-Z]+\d*\]/) || [])[0]}`);
      if (/ดาเมจตรง|\d\s*วิ(?!นาที)|lckAdjust|chaAdjust|talAdjust/.test(h)) pf(`${p.id} wording: ${(h.match(/ดาเมจตรง|\d\s*วิ(?!นาที)|lckAdjust|chaAdjust|talAdjust/) || [])[0]}`);
      if ((p.flags.noLv || p.flags.lvUnused) && /data-pet-lv=/.test(h)) pf(`${p.id} shows level pills although its level does nothing`);
      if (!(p.flags.noLv || p.flags.lvUnused) && !/data-pet-lv="9"/.test(h)) pf(`${p.id} has no level pills`);
      if (p.flags.lck && !/data-pet-lck/.test(h)) pf(`${p.id} uses LCK but has no LCK box`);
      if (p.code && !/pi-gvc is-diff/.test(h)) pf(`${p.id} tooltip difference not shown`);
      if (p.vars && (h.match(/data-pet-var=/g) || []).length !== p.vars.length) pf(`${p.id} variant buttons`);
    }
    const s1 = st({ sel: "p_sky", N: "x", L: -5 }); if (s1.sel !== "p_skr" || s1.vi.p_skr !== 2 || s1.N !== 9 || s1.L !== 0) pf(`petInfoState variant / clamp: ${JSON.stringify(s1)}`);
    const s2 = st({ sel: "nope", N: 12, L: 4000 }); if (s2.sel !== P[0].id || s2.N !== 9 || s2.L !== 999) pf(`petInfoState fallback: ${JSON.stringify(s2)}`);
    const s3 = st(null); if (s3.sel !== P[0].id || s3.N !== 9 || s3.L !== 156) pf(`petInfoState defaults: ${JSON.stringify(s3)}`);
    const s4 = st({ sel: "p_skr", vi: { p_skr: 7, p_lcs: "a" }, N: 4.6, L: "200" }); if (s4.vi.p_skr !== undefined || s4.vi.p_lcs !== undefined || s4.N !== 5 || s4.L !== 200) pf(`petInfoState cleaning: ${JSON.stringify(s4)}`);
    const rh = ros(st({})); if ((rh.match(/data-pet-sel=/g) || []).length !== P.length) pf("roster rows");
    if (!/pi-it is-on[^>]*data-pet-sel="p_lmc"/.test(rh)) pf("roster marks the selected pet");
    // Token spacing (bible-desc-writing): a **…** / __…__ / ^^…^^ token never touches a letter or digit.
    const touch = /[\p{L}\p{N}\p{M}]/u;
    for (const p of P) for (const N of [1, 9]) for (const t of [p.desc(N, 156), typeof p.code === "function" ? p.code(N) : p.code || ""]) {
      for (const m of t.matchAll(/(\*\*|__|\^\^)(.+?)\1/g)) {
        const before = t[m.index - 1] || "", after = t[m.index + m[0].length] || "";
        if (touch.test(before) || touch.test(after)) pf(`${p.id} token spacing: …${t.slice(Math.max(0, m.index - 6), m.index + m[0].length + 6)}…`);
      }
    }
    console.log(`Verified Special Pet Info renderers: ${renders} detail renders.`);
    // Tool wiring: TOOLS entry, launcher art, mount with storage blocked or stale, deep links, a click and an LCK change.
    const tool = run("TOOLS").find(t => t.id === "pet-info");
    if (!tool) pf("no TOOLS entry pet-info");
    else {
      if (tool.title !== "Special Pet Info" || tool.category !== "Reference") pf("pet-info title / category");
      const f = tool.fact && tool.fact(); if (!f || f[0] !== 40 || f[1] !== "ตัว") pf(`pet-info fact ${JSON.stringify(f)}`);
      const art = tool.art || []; if (art.length !== 5 || !art.every(k => /^gear:/.test(k) && GI[k.slice(5)])) pf(`pet-info art ${JSON.stringify(art)}`);
    }
    const mkRoot = () => { const reg = new Map(), r = makeEl(); r.l = {}; r.addEventListener = (t, fn) => { r.l[t] = fn; };
      r.querySelector = sel => { if (!reg.has(sel)) reg.set(sel, makeEl()); return reg.get(sel); }; return r; };
    const mount = run("mountPetInfo");
    sandbox.location.hash = "#pet-info/p_sky";
    const r1 = mkRoot(); mount(r1);   // the sandbox has no localStorage: reading it throws, the mount must not
    if (!r1._petInfo || !/S\. Ninja Kite \(y\)/.test(r1.querySelector(".pi-detail").innerHTML)) pf("deep link #pet-info/p_sky did not open the yellow kite");
    if (!r1._petInfo.openById("p_mgb") || !/MiniGolden/.test(r1.querySelector(".pi-detail").innerHTML)) pf("openById p_mgb");
    if (r1._petInfo.openById("nope") !== false) pf("openById of an unknown id must return false");
    const click = (r, attrs) => r.l.click({ target: { closest: () => ({ dataset: attrs }) } });
    click(r1, { petSel: "p_lcr" }); click(r1, { petLv: "1" });
    if (!/class="pi-n is-on" data-pet-lv="1"/.test(r1.querySelector(".pi-detail").innerHTML)) pf("level click");
    r1.l.change({ target: { matches: s => s === "[data-pet-lck]", value: "" } });
    if (!/value="156"/.test(r1.querySelector(".pi-detail").innerHTML)) pf("a blank LCK box does not fall back to 156");
    sandbox.localStorage = { getItem: () => '{"sel":"zzz","N":"q","L":"x","vi":{"p_skr":9}}', setItem: () => {} };
    sandbox.location.hash = "#pet-info";
    const r2 = mkRoot(); mount(r2);
    if (!/L\. Mad Carron/.test(r2.querySelector(".pi-detail").innerHTML)) pf("stale stored state does not fall back to the first pet");
    delete sandbox.localStorage; sandbox.location.hash = "skill-details";
    // Final review (2026-10-18): the server looks' "raised" recipe must not repaint a selected control (it outranks .is-on).
    const raised = (html.match(/raised: \[([^\]]*)\]/) || ["", ""])[1].match(/"\.pi-[^"]*"/g) || [];
    for (const s of raised) if (!/:not\(\.is-on\)/.test(s)) pf(`THEME_SURFACES raised ${s} must exclude :not(.is-on)`);
    // Keyboard focus survives a re-render: the control that was focused is focused again.
    const r3 = mkRoot(); mount(r3); const d3 = r3.querySelector(".pi-detail"); let focused = null;
    d3.querySelector = sel => ({ focus: () => { focused = sel; } });
    r3.contains = () => true;
    sandbox.document.activeElement = { dataset: { petLv: "3" }, closest: s => (s === ".pi-detail" ? d3 : null) };
    click(r3, { petLv: "3" });
    if (focused !== '[data-pet-lv="3"]') pf(`focus not restored after a level click (${focused})`);
    delete sandbox.document.activeElement;
    // Copy (final review): one clear footer sentence; anti-status tiles say "ติด <status>".
    const lcr = det({ sel: "p_lcr", vi: {}, N: 9, L: 156 });
    if (!/เอฟเฟกต์ที่ทำงานตามเวลา มีผลเฉพาะในภารกิจและ PvP/.test(lcr) || /ติด sleep/.test(lcr) === false) pf("footer / anti-status tile copy");
  } catch (e) { pf(`section threw: ${e.message}`); }
}

// Monster stats page (MONSTER_STATS, decoded from 12TailsOnline_Data): renders one table row per entry, every row is
// within the decoder's sane ranges, and First Whale still equals the hand-verified enemy preset.
{
  const fail = (m) => { console.error(`[MONSTER STATS ERROR] ${m}`); errorCount++; };
  const M = sandbox._monsterStats;
  if (!Array.isArray(M) || M.length < 300) fail(`expected 300+ rows, got ${M && M.length}`);
  else {
    M.forEach((r, i) => { if (r.length !== 22 || (r[20] !== null && !(r[20] >= 0)) || (r[21] !== null && !(r[21] > 0)) || r[3] < 0 || r[3] > 999 || r[2] < 0 || r[2] > 6 || r.slice(4, 17).some(v => !Number.isInteger(v) || v < 0 || v > 500000)) fail(`row ${i} (${r[0]}) out of range`); });
    // Collider size (RippedAssets prefabs, 2026-10-07): spot values.
    for (const [t, h, rad] of [["LionBug_y", 2, 1], ["GoldenKingBug", 4, 2], ["Fay", 4, 0.9], ["NinjaBug_b", 1, 0.3]]) { const r = M.find(x => x[1] === t); if (!r || r[20] !== h || r[21] !== rad) fail(`${t} collider should be h${h} r${rad}, got ${r && r[20]} / ${r && r[21]}`); }
    const fw = M.find(r => r[1] === "FirstWhale"), p = sandbox._enemyPresets.find(e => e.id === "firstwhale");
    if (!fw || !p || [fw[8], fw[9], fw[10], fw[11], fw[12], fw[13], fw[14], fw[15]].join() !== [p.atk, p.def, p.agi, p.vit, p.int, p.cha, p.tal, p.lck].join()) fail("First Whale row does not match the verified preset");
    const reg = {}; const root = makeSmartRoot(); root.querySelector = (sel) => reg[sel] || (reg[sel] = Object.assign(makeEl(), { value: "" }));
    try { sandbox._mountMonsterStats(root); const n = (reg['[data-role="body"]'].innerHTML.match(/<tr>/g) || []).length; if (n !== M.length) fail(`page rendered ${n} of ${M.length} rows`); }
    catch (e) { fail("page threw: " + e.message); }
  }
  console.log(`Verified monster stats page (${M ? M.length : 0} rows).`);
}

// tooltipNote (GEMINI.md §2): every Thai-tooltip mismatch lives in the card's tooltipNote and renders as the styled
// "ⓘ คำอธิบายในเกมไม่ตรงกับโค้ด: ..." line (at least one rank); a red __…คำอธิบายในเกม…__ line inside a desc is not allowed.
{
  let checkedTip = 0;
  const INLINE = /__[^_]*(คำอธิบายในเกม|คำอธิบายภาษา|tooltip|Tooltip|ในเกมระบุ|ในเกมบอก)[^_]*__/;
  for (const sk of SKILLS) {
    const variants = [sk, ...Object.values(sk.servers || {})];
    for (let r = 1; r <= (sk.maxRank || 1); r++) for (const v of variants) {
      let d = ""; try { d = typeof v.desc === "function" ? String(v.desc(r, null) || "") : String(v.desc || ""); } catch (e) {}
      if (INLINE.test(d)) { console.error(`[TOOLTIP NOTE ERROR] ${sk.id} rank ${r}: tooltip mismatch written inline in desc; move it to tooltipNote`); errorCount++; r = 99; break; }
    }
    if (!sk.tooltipNote) continue;
    let shown = false;
    for (let r = 1; r <= (sk.maxRank || 1) && !shown; r++) {
      sandbox._skillRanks[sk.id] = r; sandbox._selectSkill(sk);
      shown = sandbox._getRenderedHeroHtml().includes('<span class="sk-tooltip-note"><b>ⓘ คำอธิบายในเกมไม่ตรงกับโค้ด:</b> ');
    }
    if (!shown) { console.error(`[TOOLTIP NOTE ERROR] ${sk.id}: tooltipNote set but no styled line rendered at any rank`); errorCount++; }
    else checkedTip++;
  }
  console.log(`Verified ${checkedTip} tooltipNote lines (and no inline tooltip lines in any desc).`);
}
// 3s. Stat chip target value (2026-10-08, bible-skill-page-ui "Target value on a stat chip"): the sandbox has no real DOM, so the
// editor itself is not run here. This guards what it stands on: (1) the file's line endings (a stray \r\r\n or a lone LF in a CRLF
// file makes git store the whole 15 MB file as changed), (2) the pieces of the source the feature needs, (3) the chip markup it
// reads (every Cooldown / Cast Time / Duration / chance chip keeps a .sk-stat-value), (4) the formula directions its binary
// search relies on (Bat Doom's inverted contested duration is the one that runs the other way).
let checkedChipTarget = 0;
{
  const check = (label, ok, got) => { checkedChipTarget++; if (!ok) { console.error(`[CHIP TARGET ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  // (1) line endings
  const crlf = (html.match(/\r\n/g) || []).length, loneLf = (html.match(/(?<!\r)\n/g) || []).length, loneCr = (html.match(/\r(?!\n)/g) || []).length;
  check("index.html has no lone CR (a '\\r\\r\\n' left by a scripted edit)", loneCr === 0, loneCr);
  check("index.html is not mixed CRLF / LF", crlf === 0 || loneLf === 0, `${crlf} CRLF, ${loneLf} lone LF`);
  // (2) source pieces
  check("renderHeroNow calls setupStatTarget()", /setupStatTooltipInteractions\(\);\s*setupStatTarget\(\);/.test(html));
  check("TARGET_STAT maps AGI / INT / CHA / TAL / LCK", /const TARGET_STAT = \{ agi: agiEl, int: intEl, cha: chaEl, tal: talEl, lck: lckEl \}/.test(html));
  check("AGI has no cap in the target search", /const TARGET_HI = \{ agi: 1000000,/.test(html));
  check("the chip direction is measured (Doom is inverted)", html.includes("info.dec = a > b"));
  const ap = html.slice(html.indexOf("function applyTarget("), html.indexOf("function openTargetEdit("));
  check("applyTarget pushes an undo step before it writes the stat", ap.includes("presetPushUndo()") && ap.indexOf("presetPushUndo()") < ap.indexOf("el.value = r.stat"));
  check("applyTarget clamps to the reachable range and says so", ap.includes("Math.min(Math.max(wanted, lo), hi)") && ap.includes("เกินที่ทำได้"));
  check("the probability tooltip is hover only (no click-to-pin)", !html.includes('wrap.classList.toggle("pinned"'));
  const hov = (html.match(/\.sk-target-chip:hover[^{]*\{[^}]*\}/g) || []).join(" ");
  check("chip hover only glows the number (no transform: the stat tooltips are position:fixed)", hov.includes("text-shadow") && !/transform|background|box-shadow/.test(hov), hov.slice(0, 80));
  // (3) chip markup the editor reads
  const CHIP = /<div class="sk-stat sk-stat-(?:cd|cd-secondary|cast|dur|dur2|lck\d?)\b/g;
  let chips = 0;
  for (const sk of SKILLS) {
    sandbox._skillRanks[sk.id] = sk.maxRank || 1; sandbox._selectSkill(sk);
    const h = sandbox._getRenderedHeroHtml();
    const starts = [...h.matchAll(CHIP)].map(m => m.index);
    starts.forEach((at, i) => {
      const next = h.indexOf('<div class="sk-stat ', at + 10);
      const chunk = h.slice(at, next < 0 ? h.length : next);
      chips++;
      if (!chunk.includes('class="sk-stat-value')) check(`${sk.id}: a ${chunk.slice(10, 40)} chip has no .sk-stat-value for the editor to swap`, false);
    });
  }
  check("the cards render at least 300 editable chips", chips >= 300, chips);
  // (4) formula directions
  const mono = (fn, from, to, step, dir) => { let prev = fn(from); for (let x = from + step; x <= to; x += step) { const v = fn(x); if (dir === "down" ? v > prev + 1e-9 : v < prev - 1e-9) return false; prev = v; } return true; };
  check("agiAdjust falls as AGI rises", mono(a => sandbox.agiAdjustAtRoll(120, a, 0), 0, 1000, 8, "down"));
  check("chaAdjust rises with CHA", mono(c => sandbox.chaAdjustAtRoll(6, c, 0), 0, 512, 4, "up"));
  check("magAdjust (cast time) falls as INT rises", mono(m => sandbox.magAdjustAtRoll(8, m, 0), 0, 512, 4, "down"));
  check("lckAdjust rises with LCK", mono(l => sandbox.lckAdjustChance(20, l), 0, 512, 4, "up"));
  check("contested duration rises with CHA", mono(c => sandbox.debuffAdjust(60, c, 2), 0, 512, 4, "up"));
  check("inverted contested duration (Bat Doom) FALLS as CHA rises", mono(c => sandbox.debuffAdjust(60, 2, c), 0, 512, 4, "down"));
}
console.log(`Verified ${checkedChipTarget} stat chip target checks.`);
// 3t. BB issues page: the "Unintended behavior" type (2026-10-08). A card's `unintended` text must reach the page as kind
// "unintended" and show as the gold note on the card; the filter and tag exist. A temporary note is put on one card and removed
// again, so this passes with no real entries yet.
let checkedUnintended = 0;
{
  const check = (label, ok) => { checkedUnintended++; if (!ok) { console.error(`[UNINTENDED ERROR] ${label}`); errorCount++; } };
  const sk = SKILLS.find(s => s.id === "whale_bubbleBurst");
  const had = sk.unintended;
  sk.unintended = "ทดสอบ **1**";
  try {
    const mine = sandbox.bbIssueItems().filter(i => i.s === sk && i.kind === "unintended");
    check("a card's `unintended` shows on the BB issues page as kind unintended", mine.length === 1 && mine[0].text.includes("ทดสอบ"));
    sandbox._skillRanks[sk.id] = sk.maxRank || 1; sandbox._selectSkill(sk);
    check("the card shows the gold ⚡ note", sandbox._getRenderedHeroHtml().includes('class="sk-unintended"><b>⚡ พฤติกรรมที่ไม่ตั้งใจ (BB):</b>'));
  } finally { if (had === undefined) delete sk.unintended; else sk.unintended = had; }
  sandbox._selectSkill(sk);
  check("the note is gone again once the field is removed (or stays only if a real card sets it)", had !== undefined || !sandbox._getRenderedHeroHtml().includes("sk-unintended\">"));
  check("the BB issues page has its type chip and gold ⚡ tag", html.includes('{ k: "unintended", label: "พฤติกรรมที่ไม่ตั้งใจ", short: "ไม่ตั้งใจ", color: "var(--gold)", ico: NOTE_ICO.unintended }'));
  check("an empty category says so instead of showing a blank page", html.includes("ยังไม่มีรายการในหมวดนี้"));
}
console.log(`Verified ${checkedUnintended} Unintended-behavior page checks.`);
// Note colours (user 2026-10-09): bug red (--seal), tooltip mismatch blue (--tip), unintended gold, so the three chips never look alike.
{
  const src = fs.readFileSync(targetPath, "utf8");
  const tokens = (src.match(/--tip:#[0-9a-fA-F]{6};/g) || []).length;
  const ok = tokens === 3 && /\.sk-note-tip\{ color:var\(--tip\); \}/.test(src) && /\.sk-note-bug\{ color:var\(--seal\); \}/.test(src) && /\.sk-note-unintended\{ color:var\(--gold\); \}/.test(src)
    && /\.sk-tooltip-note, \.sk-tooltip-note \.sk-val\{ color:var\(--tip\); \}/.test(src)
    && src.includes('{ k: "bug", label: "บั๊กของตัวเกม", short: "บั๊ก", color: "var(--seal)"') && src.includes('{ k: "tip", label: "คำอธิบายไม่ตรง", short: "คำอธิบาย", color: "var(--tip)"') && src.includes('short: "ไม่ตั้งใจ", color: "var(--gold)"');
  if (!ok) { errorCount++; console.error(`[NOTE COLOUR ERROR] --tip must exist in all 3 theme blocks (${tokens}) and the tooltip chip, note and BB issues tag must use it while bug stays red and unintended gold`); }
  console.log("Verified the three note colours stay distinct.");
}
// Co-author page: each finding bolds only its parent skill (** **), which renders as a gold skill link; the pop-up renders the items as rich text.
let checkedCredits = 0;
{
  const check = (label, ok, got) => { checkedCredits++; if (!ok) { errorCount++; console.error(`[CREDITS ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); } };
  const C = vm.runInContext("CONTRIBUTORS", sandbox), rich = vm.runInContext("renderRichText", sandbox);
  C.forEach(c => (c.what || []).forEach((w, i) => {
    const bolds = (w.match(/\*\*[^*]+\*\*/g) || []);
    if (c.special) return;
    check(`${c.id} #${i + 1}: exactly one bold parent skill`, bolds.length === 1, bolds.length);
    const html = rich(w, null);
    check(`${c.id} #${i + 1}: the bold name is a skill link`, /class="sk-desc-skill-link"/.test(html), bolds[0]);
  }));
  const src = fs.readFileSync(targetPath, "utf8");
  check("the pop-up height is measured by layout (offsetHeight), not getBoundingClientRect, which includes the opening scale and clipped the page when opened from a card", /function creditsSetHeight\(\) \{[^}]*act\.offsetHeight/.test(src) && !/function creditsSetHeight\(\) \{[^}]*getBoundingClientRect/.test(src));
  check("the pop-up renders items with renderRichText and handles clicks on a skill link", /li\.innerHTML = renderRichText\(t, null\)/.test(src) && /creditsBodyEl\.addEventListener\("click"/.test(src) && /closeCreditsModal\(\);\s*location\.hash = "skill-details\/"/.test(src));
}
console.log(`Verified ${checkedCredits} co-author page checks.`);

// 3u. Raw / Final damage number colours (user 2026-10-08): white = all hits normal, purple = Effect Damage, aqua = TTO magic, gold = a mix
// (a purple proc that is on), green = heal, indigo = hate, grey = shield. Decided from the computed hits, so a toggle recolours live.
let checkedHue = 0;
{
  const check = (label, ok, got) => { checkedHue++; if (!ok) { console.error(`[HUE ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const byId = id => SKILLS.find(s => s.id === id);
  const deps = sandbox._depRanks, savedDeps = Object.assign({}, deps);
  const hues = (id, rank) => {
    const sk = byId(id);
    sandbox._skillRanks[id] = rank || sk.maxRank || 1; sandbox._selectSkill(sk);
    const h = sandbox._getRenderedHeroHtml();
    const grab = (cls) => { const i = h.indexOf(`sk-stat ${cls}`); if (i < 0) return []; const j = h.indexOf("sk-stat sk-dmg-", i + 10); const part = h.slice(i, j < 0 ? h.length : j); return [...part.matchAll(/class="sk-stat-value[^"]*?sk-hue-([a-z]+)/g)].map(m => m[1]); };
    return { raw: grab("sk-dmg-calc"), fin: grab("sk-dmg-final") };
  };
  try {
    sandbox._setServer("og");
    let r = hues("penguin_tornado");
    check("a plain damage card is white in both chips", r.raw[0] === "w" && r.fin[0] === "w", JSON.stringify(r));
    r = hues("chameleon_thunderDragon");
    check("an Effect Damage card is purple in both chips", r.raw[0] === "p" && r.fin[0] === "p", JSON.stringify(r));
    r = hues("penguin_manaMissile");
    check("a TTO magic card is white on OG", r.raw[0] === "w" && r.fin[0] === "w", JSON.stringify(r));
    sandbox._setServer("tto");
    r = hues("penguin_manaMissile");
    check("a TTO magic card is aqua on TTO", r.raw[0] === "a" && r.fin[0] === "a", JSON.stringify(r));
    sandbox._setServer("og");
    deps.wallPuncture = 0;
    r = hues("whale_javelin");
    check("a purple proc that is off stays white", r.raw[0] === "w" && r.fin[0] === "w", JSON.stringify(r));
    deps.wallPuncture = 4;
    r = hues("whale_javelin");
    check("a purple proc that is on makes the mix gold", r.raw[0] === "mix" && r.fin[0] === "mix", JSON.stringify(r));
    r = hues("whale_megalodon");
    check("groups that differ (purple pull, white bite): each line its own colour, the total gold", r.raw.includes("p") && r.raw.includes("w") && !r.fin.includes("w") , JSON.stringify(r));
    r = hues("sheep_heal");
    check("a heal is green", r.raw[0] === "heal" && r.fin[0] === "heal", JSON.stringify(r));
    r = hues("wolf_provoke");
    check("a hate card is indigo", r.raw[0] === "hate" && r.fin[0] === "hate", JSON.stringify(r));
    sandbox._skillRanks.penguin_iceShield = byId("penguin_iceShield").maxRank; sandbox._selectSkill(byId("penguin_iceShield"));
    check("the shield pool is grey", /sk-stat-value sk-hue-shield/.test(sandbox._getRenderedHeroHtml()));
    // Shield cards (2026-10-08): Formula + โล่ดิบ + โล่จริง (= the raw range, no DEF step) + a Test that rolls the pool in grey digits.
    for (const id of ["penguin_iceShield", "penguin_snowMan", "whale_bubbleShield"]) {
      const sk = byId(id); sandbox._skillRanks[id] = sk.maxRank; sandbox._selectSkill(sk);
      const h = sandbox._getRenderedHeroHtml();
      const m = h.match(/โล่ดิบ<\/p>[\s\S]*?sk-hue-shield">([^<]+)<\//), f = h.match(/โล่จริง<\/p>[\s\S]*?sk-hue-shield">([^<]+)<\//);
      check(id + " shows โล่ดิบ and โล่จริง with the same range", !!(m && f && m[1] === f[1]), m && f ? m[1] + " / " + f[1] : "missing");
      check(id + " has the ทดสอบโล่ button and no old LCK label", h.includes("ทดสอบโล่") && !h.includes("รวมการแกว่งค่า LCK"));
      if (m) {
        const [lo, hi] = m[1].replace(/,/g, "").split(/[~–]/).map(Number); const top = hi === undefined ? lo : hi;
        let ok = true; for (let i = 0; i < 300; i++) { const v = sandbox._rollOneHit(sk, sk.maxRank, 0, false); if (!(Number.isInteger(v) && v >= lo && v <= top)) { ok = false; break; } }
        check(id + " Test rolls stay inside the shield range", ok, m[1]);
      }
    }
    for (const k of ["h", "s"]) for (let i = 0; i < 10; i++) check("digit dmgdigit_" + k + i + " present", /^data:image\/(png;base64,iVBORw0KGgo|webp;base64,UklGR)/.test(SKILL_ICONS["dmgdigit_" + k + i] || ""));
    // Formula captions (2026-10-08): a term that is not a talAdjust constant carries a caption; Hate-driven terms wear the hate accent.
    for (const [id, cap] of [["bison_onslaught", "0.1Hate"], ["bison_prideCrusher", "0.2Hate"]]) {
      const sk = byId(id); sandbox._skillRanks[id] = sk.maxRank; sandbox._selectSkill(sk);
      const h = sandbox._getRenderedHeroHtml();
      check(id + " formula shows its Hate term in the hate accent with the caption " + cap, h.includes("dmg-hate") && h.includes("(" + cap + ")"));
    }
    { // Bubble Burst (2026-10-08): damage = the shield HP left; the box defaults to the average full rank 4 Bubble Shield from the Whale's TAL.
      const sk = byId("whale_bubbleBurst"); sandbox._skillRanks[sk.id] = 1; sandbox._selectSkill(sk);
      const h = sandbox._getRenderedHeroHtml();
      const full = h.match(/data-key="burstShieldHp"[^>]*value="(\d+)"/), term = h.match(/<span class="dmg-shield"[^>]*>(\d+)<\/span>/);
      check("Bubble Burst has a shield HP box that is not shield coloured and a shield coloured formula term", !!(full && term && full[1] === term[1]) && !/sk-current-sp-input[^>]*dmg-shield|dmg-shield[^>]*sk-current-sp-input/.test(h), full && term ? full[1] + " / " + term[1] : "missing");
      const lo = sandbox._rollOneHit(sk, 1, 0, false);
      check("Bubble Burst Test rolls the shield HP left (effect damage)", lo === Number(full && full[1]), lo);
    }
    // An ATK-driven formula term keeps the ATK colour on Effect Damage cards (Drain Life, Wolf Combo with Dark Edge), user 2026-10-08.
    for (const [id, dep] of [["bat_cAttack", null], ["wolf_nAttack", "wolfDarkEdgeOn"]]) {
      const sk = byId(id); sandbox._skillRanks[sk.id] = sk.maxRank; if (dep) sandbox._depRanks[dep] = 1; sandbox._selectSkill(sk);
      const h = sandbox._getRenderedHeroHtml(); const fi = h.indexOf("sk-dmg-formula"), part = h.slice(fi, h.indexOf("sk-dmg-calc", fi));
      check(id + " ATK term is red, not purple, while the card is Effect Damage", part.includes('class="dmg-atk"') && !part.includes('class="dmg-effect"'));
      if (dep) sandbox._depRanks[dep] = 0;
    }
    { // Drain Life + Shadow Illusion (2026-10-08): per tick the Bat ceil(1 x clamp) and each clone trunc(cloneMod x clamp) on the same ATK.
      const sk = byId("bat_cAttack"), inp = sandbox._statInputs, savedAtk = inp.atk.value;
      inp.atk.value = "200"; sandbox._depRanks.shadowIllusion = 3; sandbox._depRanks.darkIntention = 0; sandbox._skillRanks[sk.id] = 3; sandbox._selectSkill(sk);
      let tot = 0; for (let i = 0; i < 3; i++) tot += sandbox._rollOneHit(sk, 3, i, false);
      check("Drain Life rank 3, ATK 200, Shadow Illusion 3: Bat 24 + two clones 18 each = 60 per tick", tot === 60, tot);
      const h = sandbox._getRenderedHeroHtml();
      check("Drain Life shows the clone group and its damageMod caption", h.includes("Shadow Illusion") && h.includes("dmgMod ร่างแยก"));
      sandbox._depRanks.shadowIllusion = 0; sandbox._selectSkill(sk);
      let one = 0; for (let i = 0; i < 1; i++) one += sandbox._rollOneHit(sk, 3, i, false);
      check("Drain Life without clones is the Bat alone (24)", one === 24, one);
      // Dream Burst: the Bat and each clone also burst the drained target every 9 - lv s (normal hit, talAdjust(16 + 4 x lv), KO 1 + lv).
      sandbox._depRanks.shadowIllusion = 3; sandbox._depRanks.dreamBurst = 2; sandbox._selectSkill(sk);
      const hits = sk.dmgGroups.reduce((n, g) => n + sandbox._resolveGroupHitCount(sk, g), 0);
      check("Drain Life with Dream Burst 2 and two clones: 1 + 2 drain hits and 1 + 2 burst hits", hits === 6 && sk.hitCount(3) === 6, hits);
      const hb = sandbox._getRenderedHeroHtml();
      check("Drain Life shows the Dream Burst groups with the 7 s interval and KO 3", hb.includes("Dream Burst (ทุก 7 วินาที)") && hb.includes('ko-value">3'));
      sandbox._depRanks.dreamBurst = 0; delete sandbox._depRanks.dreamBurst;
      inp.atk.value = savedAtk; delete sandbox._depRanks.shadowIllusion;
    }
    { const sk = byId("cat_finishingBlow"); sandbox._skillRanks[sk.id] = sk.maxRank; sandbox._selectSkill(sk); check("a flat formula number carries a caption", sandbox._getRenderedHeroHtml().includes("(ค่าคงที่)")); }
    check("hate Test digits use the indigo set and shield Test digits the grey set", html.includes('selected.isHate ? "h" : isShieldOnly(selected) ? "s"'));
  } finally {
    sandbox._setServer("og");
    Object.keys(deps).forEach(k => delete deps[k]); Object.assign(deps, savedDeps);
  }
  check("the hate and shield colours exist in both themes", [/--stat-hate:#4338ca/, /--stat-hate:#818cf8/, /--stat-shield:#6b7280/, /--stat-shield:#a1a1aa/].every(re => re.test(html)));
}
console.log(`Verified ${checkedHue} damage number colour checks.`);

// ---- reach (spec 2026-10-13): the range badge's structured hit-box data ----
{
  const REACH_SHAPES = ["sphere", "cylinder", "box", "cone", "sector", "ring", "tube", "line", "self"];
  const REACH_ANCHORS = ["self", "target", "fist", "projectile"];
  const REACH_DIM = { sphere: ["r"], cylinder: ["r", "h"], box: ["w", "l", "h"], cone: ["r", "angle"], sector: ["r", "angle", "h"], ring: ["r"], tube: ["r", "l"], line: ["l"], self: [] };
  const REACH_DESC_RE = /รัศมี \*\*|ทรงกลมรัศมี|กว้าง \*\*/;
  // Backlog (2026-10-15): the three phrases above missed most formats, so an active card (not a passive modifier, not a Zombie AI list) with no `reach` is also flagged when its desc states a size or range in any common form.
  const REACH_BACKLOG_RE = /\*\*[\d.×+\-–\/ ]*\s*m\*\*|\d\s*m|รัศมี|กว้าง|ยาว/;
  // No card is exempt (2026-10-15): an active card that states a size in its desc must carry a `reach`.
  const REACH_BACKLOG_EXEMPT = new Set([]);
  const bad = (m) => { console.error(`[REACH ERROR] ${m}`); errorCount++; };
  let checkedReach = 0, reachBacklog = 0; const reachBacklogIds = [];
  for (const sk of SKILLS) {
    const maxRank = sk.maxRank || 1;
    const descAt = (r) => typeof sk.desc === "function" ? sk.desc(r) : String(sk.desc || "");
    if (!sk.reach) { const dd = descAt(maxRank); if (REACH_DESC_RE.test(dd) || (!sk.passive && !/_zombie/.test(sk.id) && !REACH_BACKLOG_EXEMPT.has(sk.id) && REACH_BACKLOG_RE.test(dd.replace(/<br>/g, " ")))){ reachBacklog++; reachBacklogIds.push(sk.id); } continue; }
    for (let r = 1; r <= maxRank; r++) {
      let parts;
      try { parts = sandbox._reachNormalize(sk.reach, r); } catch (e) { bad(`${sk.id} rank ${r}: ${e.message}`); continue; }
      for (const p of parts) {
        checkedReach++;
        if (!REACH_SHAPES.includes(p.shape)) { bad(`${sk.id} rank ${r}: unknown shape ${p.shape}`); continue; }
        if (p.anchor && !REACH_ANCHORS.includes(p.anchor)) bad(`${sk.id} rank ${r}: unknown anchor ${p.anchor}`);
        if (!p.unknown && p.shape !== "self" && !p.src) bad(`${sk.id} rank ${r}: missing src`);
        if (p.w2 !== undefined && !(typeof p.w2 === "number" && p.w2 > 0)) bad(`${sk.id} rank ${r}: w2 must be > 0, got ${p.w2}`);
        if (p.rangeMod !== undefined && p.rangeMod !== true && p.rangeMod !== false && !(Array.isArray(p.rangeMod) && p.rangeMod.length && p.rangeMod.every(k => ["r", "w", "w2", "l", "h", "z0"].includes(k)))) bad(`${sk.id} rank ${r}: rangeMod must be true or a list of r w w2 l h z0, got ${JSON.stringify(p.rangeMod)}`);
        if (p.z0 !== undefined && typeof p.z0 !== "number") bad(`${sk.id} rank ${r}: z0 must be a number`);
        if (p.x0 !== undefined && typeof p.x0 !== "number") bad(`${sk.id} rank ${r}: x0 must be a number`);
        if (p.y0 !== undefined && typeof p.y0 !== "number") bad(`${sk.id} rank ${r}: y0 must be a number`);
        if (!p.unknown) for (const k of REACH_DIM[p.shape]) {
          const v = p[k];
          if (!(v === "inf" && k === "h") && !(typeof v === "number" && v > 0)) bad(`${sk.id} rank ${r}: ${k} must be > 0, got ${v}`);
        }
      }
      if (REACH_DESC_RE.test(descAt(r))) { console.error(`[REACH DESC ERROR] ${sk.id} rank ${r}: desc still states a size`); errorCount++; }
    }
  }
  const ext = (vs, i) => +(Math.max(...vs.map(v => v[i])) - Math.min(...vs.map(v => v[i]))).toFixed(6);
  const box = sandbox._reachMesh({ shape: "box", w: 2, l: 4, h: 1, anchor: "self" });
  if (ext(box.verts, 0) !== 2 || ext(box.verts, 2) !== 4 || ext(box.verts, 1) !== 1.5) bad(`golden box extents ${ext(box.verts, 0)}x${ext(box.verts, 2)}x${ext(box.verts, 1)}`);
  const trap = sandbox._reachMesh({ shape: "box", w: 6, w2: 3.2, l: 4, h: 3, anchor: "fist", z0: -1 });
  const nearX = Math.max(...trap.verts.filter(v => Math.abs(v[2] + 1) < 1e-9).map(v => v[0])), farX = Math.max(...trap.verts.filter(v => Math.abs(v[2] - 3) < 1e-9).map(v => v[0]));
  if (nearX !== 3 || farX !== 1.6 || ext(trap.verts, 2) !== 4 || Math.min(...trap.verts.map(v => v[2])) !== -1 || ext(trap.verts, 1) !== 4.5) bad(`golden trapezoid near ${nearX} far ${farX}`);
  // a trapezoid's length label measures TargetRange (the distance between the two parallel bases, Damage.cs:1437-1446), so it sits on the centre line, not on the slanted side
  {
    const lenPill = (p) => sandbox._reachDims(p).find(d => /^[\d.]+m$/.test(d.text) && d.pick === "right" && d.opts.length >= 1 && Math.abs(Math.abs(d.opts[0][1][2] - d.opts[0][0][2]) - p.l) < 1e-9);
    const trap = lenPill({ shape: "box", w: 2, w2: 18, l: 8, h: 6, anchor: "self" }), rect = lenPill({ shape: "box", w: 2, w2: 2, l: 8, h: 6, anchor: "self" });
    if (!trap || trap.opts.length !== 1 || trap.opts[0][0][0] !== 0 || trap.opts[0][1][0] !== 0) bad("golden trapezoid length pill must run along the centre line (x = 0), not the slanted edge");
    if (!rect || rect.opts.length !== 2) bad("golden rectangle length pill keeps its two side edges");
  }
  const ringM = sandbox._reachMesh({ shape: "ring", r: 5, anchor: "self" });
  if (ext(ringM.verts, 0) !== 10 || ext(ringM.verts, 2) !== 10 || ext(ringM.verts, 1) !== 0 || ringM.faces.length !== 0) bad("golden ring r5: 10 x 10 on the ground, outline only");
  const tubeM = sandbox._reachMesh({ shape: "tube", r: 0.5, l: 6, anchor: "self" });
  if (ext(tubeM.verts, 0) !== 1 || ext(tubeM.verts, 2) !== 6 || Math.min(...tubeM.verts.map(v => v[1])) !== 0.5 || Math.max(...tubeM.verts.map(v => v[1])) !== 1.5) bad("golden tube r0.5 l6: 1 wide, 6 long, axis at 1 m");
  if (sandbox._reachBadgeText([{ shape: "ring", r: 40 }]) !== "40m" || sandbox._reachBadgeText([{ shape: "tube", r: 1, l: 25 }]) !== "25m") bad("golden badge text ring / tube");
  const off0 = sandbox._reachMesh({ shape: "box", w: 2, l: 4, h: 6, y0: -2, anchor: "self" });
  if (Math.min(...off0.verts.map(v => v[1])) !== -5 || Math.max(...off0.verts.map(v => v[1])) !== 4) bad("golden y0: a 6 m band lowered 2 m must span -5..4");
  const sec = sandbox._reachMesh({ shape: "sector", r: 10, angle: 180, h: 2, anchor: "self" });
  if (ext(sec.verts, 0) !== 20 || Math.max(...sec.verts.map(v => v[2])) !== 10 || Math.min(...sec.verts.map(v => v[2])) < -1e-9 || ext(sec.verts, 1) !== 3) bad("golden sector 180 deg r10 h2: wide 20, 10 ahead, none behind, band 3");
  if (sandbox._reachBadgeText([{ shape: "sector", r: 32.2, angle: 190, h: 2 }]) !== "32.2m 190°") bad("golden badge text sector");
  const sph = sandbox._reachMesh({ shape: "sphere", r: 3, anchor: "self" });
  if (ext(sph.verts, 0) !== 6 || ext(sph.verts, 1) !== 6 || ext(sph.verts, 2) !== 6) bad(`golden sphere extents ${ext(sph.verts, 0)}x${ext(sph.verts, 1)}x${ext(sph.verts, 2)}`);
  const cyl = sandbox._reachMesh({ shape: "cylinder", r: 2, h: 5, anchor: "self" });
  if (ext(cyl.verts, 1) !== 7.5 || Math.abs(Math.max(...cyl.verts.map(v => Math.hypot(v[0], v[2]))) - 2) > 1e-6) bad("golden cylinder");
  if (sandbox._reachBadgeText([{ shape: "sphere", r: 5 }]) !== "r 5m") bad("golden badge text sphere");
  if (sandbox._reachBadgeText([{ shape: "box", w: 6, l: 2, h: 3 }]) !== "6×2×3") bad("golden badge text box");
  if (sandbox._reachBadgeText([{ shape: "line", l: 40 }]) !== "40m") bad("golden badge text line");
  if (sandbox._reachBadgeText([{ shape: "self" }]) !== "ตัวเอง") bad("golden badge text self");
  if (sandbox._reachBadgeText([{ shape: "sphere", unknown: true }]) !== "?") bad("golden badge text unknown");
  const pr = sandbox._reachProject([0, 0, 0], 0, 0, 10, 400, 300);
  if (pr[0] !== 200) bad(`golden projection centre x ${pr[0]}`);
  for (const needle of ['class="sk-reach-badge"', ".sk-reach-badge{", "function openReachPopup", ".sk-reach-pop{"]) {
    if (!html.includes(needle)) bad(`page is missing ${needle}`);
  }
  // Reach playback vs the damage sim (user 2026-10-16): a card whose damage sim counts N hits must play N timed hits in its reach preview (distinct `at` times),
  // unless it is listed here with the reason its hits cannot be replayed honestly. A listed card that no longer mismatches fails too, so the list never goes stale.
  {
    const REACH_STATIC_OK = {
      bat_nAttack: "projectile, hit time = flight time", bat_echoes: "bouncing projectile", bat_guardianOfTheNight: "AI-driven attacks",
      bat_dreamDazzle: "single locked target, no hit box", bat_phantasmBlast: "single locked target, no hit box", bat_shatteringDream: "single locked target, no hit box",
      cat_doubleDown: "random targets", cat_broadside: "16 shells land at random spots, at most 5 on one target", cat_ghostGalleon: "targeted shells on up to 8 foes a second, then a salute at random spots",
      chameleon_quickFire: "arrows, hit time = flight time",
      chameleon_leftStride: "arrows, hit time = flight time", chameleon_rightStride: "arrows, hit time = flight time",
      mole_nAttack: "projectile", mole_mortarShot: "shells land one by one at different spots", mole_barrelBot_missile: "random targets", mole_missile: "random targets",
      mole_kingKaiser_missile: "projectile", mole_napalm: "several shells landing at different spots",
      mole_warFactory_bazooka: "projectile", mole_warCapital: "AI-driven base",
      panda_climbingCliff: "single held target, no hit box", panda_crumblingMountain: "single held target, no hit box",
      penguin_nAttack: "projectile", penguin_manaMissile: "homing projectile", penguin_fallingComets: "random spots",
      sheep_nAttack: "projectile", sheep_soulOfArms: "single locked target, no hit box", whale_12thKingdomKnight: "AI-driven knights"
    };
    const unexplained = [], stale = [];
    const shortIds = new Set();
    for (const srv of ["og", "tot", "tto"]) { sandbox._setServer(srv); for (const sk0 of SKILLS) {   // every server: a server change that adds hits must add them to the preview too (Blizzard ToT 8)
      const ov = (sk0.servers && sk0.servers[srv]) || (srv === "tot" ? sk0.ps : null), sk = ov ? Object.assign({}, sk0, ov) : sk0;
      if (!sk.reach || sk.hitCountDuration) continue;
      const rank = sk.maxRank || 1;
      let hits = 1, parts = [];
      try { hits = typeof sk.hitCount === "function" ? sk.hitCount(rank, false, false) : (sk.hitCount || 1); parts = sandbox._reachNormalize(sk.reach, rank); } catch (e) { bad(sk.id + " (" + srv + ") playback check threw: " + e.message); continue; }
      const timed = new Set(parts.filter(p => typeof p.at === "number").map(p => p.at)).size;
      const drawn = timed || (parts.some(p => !p.faint && p.shape !== "ring" && p.shape !== "self" && !p.unknown) ? 1 : 0);
      const short = hits > 1 && drawn < hits;
      if (short) shortIds.add(sk.id);
      if (short && !REACH_STATIC_OK[sk.id]) unexplained.push(sk.id + " " + srv + " (sim " + hits + ", preview " + drawn + ")");
    } } sandbox._setServer("og");
    for (const id of Object.keys(REACH_STATIC_OK)) if (!shortIds.has(id)) stale.push(id);
    if (unexplained.length) bad("reach preview plays fewer hits than the damage sim: " + unexplained.join(", "));
    if (stale.length) bad("REACH_STATIC_OK lists cards that no longer mismatch: " + stale.join(", "));
    // Server balance changes that resize or retime a hit box (user 2026-10-16): the reach follows the server it is drawn for (reachSrv), and the popup offers those servers.
    { const at = (id, srv, rank, o) => { sandbox._setServer(srv); const sk0 = SKILLS.find(x => x.id === id), ov = (sk0.servers && sk0.servers[srv]) || null, sk = ov ? Object.assign({}, sk0, ov) : sk0; const dr = sandbox._depRanks, saved = { ...dr }; Object.assign(dr, o || {}); try { return sandbox._reachNormalize(sk.reach, rank); } finally { for (const k of Object.keys(dr)) delete dr[k]; Object.assign(dr, saved); sandbox._setServer("og"); } };
      const timedN = (ps) => new Set(ps.filter(p => typeof p.at === "number").map(p => p.at)).size, cyl = (ps) => ps.filter(p => p.shape === "cylinder");
      const chk = [
        ["Blizzard ToT rank 2 plays 8 waves, BB 6", timedN(at("penguin_blizzard", "tot", 2)) === 8 && timedN(at("penguin_blizzard", "og", 2)) === 6],
        ["Flash Fire ToT 6.5 m, BB 5 m", cyl(at("monkey_flashFire", "tot", 4))[0].r === 6.5 && cyl(at("monkey_flashFire", "og", 4))[0].r === 5],
        ["Fire Barrage ToT radius x1.2", cyl(at("mole_fireBarrage", "tot", 2))[0].r === 6 && cyl(at("mole_fireBarrage", "og", 2))[0].r === 5],
        ["Planet Breaker ToT 6.25 / 15 m", cyl(at("monkey_planetBreaker", "tot", 1))[0].r === 6.25 && cyl(at("monkey_planetBreaker", "tot", 1)).some(p => p.r === 15)],
        ["Titanic Earth Pulse TTO waves 3..7 m, BB 1..5 m", cyl(at("monkey_titanicEarthPulse", "tto", 1)).map(p => p.r).join() === "3,4,5,6,7" && cyl(at("monkey_titanicEarthPulse", "og", 1)).map(p => p.r).join() === "1,2,3,4,5"],
        ["Honor TTO + Honor Stand: Hate radius one level up", cyl(at("whale_honor", "tto", 2, { honorStand: 1 }))[1].r === 36 && cyl(at("whale_honor", "og", 2, { honorStand: 1 }))[1].r === 30],
        ["Bison Charge Attack + Spin Hack: ToT 7.5 m, BB 7 m", cyl(at("bison_cAttack", "tot", 2, { spinHack: 1 }))[0].r === 7.5 && cyl(at("bison_cAttack", "og", 2, { spinHack: 1 }))[0].r === 7]
      ];
      for (const [label, ok] of chk) if (!ok) bad("server reach: " + label);
    }
    console.log("Reach playback vs damage sim: " + unexplained.length + " unexplained, " + Object.keys(REACH_STATIC_OK).length + " static on purpose");
  }
  // Panda reach: every dependency state gives positive sizes, and hand-checked goldens from the Panda.cs Find* calls
  {
    const dr = sandbox._depRanks, saved = { ...dr };
    const set = (o) => { for (const k of ["pndW59", "whlW59", "auraBlast", "ogreImpact", "tigerPounce", "qiBurst", "shadowFist", "rollTheDice", "wolfKatana", "bloodFang", "lastBlade", "giantStar", "frozenBreak", "deadlyFrost", "frostSpike", "entendedWave", "reachShieldBash", "reachKnightDeep", "tideCutter", "peninsulaAsunder", "spiralBlast", "divingPress"]) dr[k] = o[k] || 0; };
    const P = (id, rank, o, rM) => { set(o || {}); return sandbox._reachNormalize(SKILLS.find(x => x.id === id).reach, rank, rM); };
    const g = (label, ok, got) => { if (!ok) bad(`Panda golden ${label}${got !== undefined ? ": got " + JSON.stringify(got) : ""}`); };
    try {
      for (const sk of SKILLS) if (sk.class === "Panda" && sk.reach) for (let r = 1; r <= (sk.maxRank || 1); r++) for (const st of [{}, { pndW59: 1 }, { auraBlast: 1 }, { pndW59: 1, auraBlast: 1, ogreImpact: 1, tigerPounce: 1, qiBurst: 1, shadowFist: 5 }]) {
        for (const p of P(sk.id, r, st)) for (const k of ["r", "w", "l", "h"]) if (p[k] !== undefined && !(p[k] === "inf" || p[k] > 0)) bad(`${sk.id} rank ${r} ${JSON.stringify(st)}: ${k} = ${p[k]}`);
      }
      const nr = (a, b) => Math.abs(a - b) < 0.011;   // the combo chain rounds every stage to 0.01 m
      let c = P("panda_nAttack", 4); g("Combo 4: stage 1 x2, 2 x2, 3 x3, 4, 5 = 9 boxes; stage 5 is 6 to 3.2 wide, 4 long, 3 high, starting 9.3 m of chained dash on (-1 behind)", c.length === 9 && c[8].w === 6 && c[8].w2 === 3.2 && c[8].l === 4 && c[8].h === 3 && nr(c[8].z0, 8.3), c);
      c = P("panda_nAttack", 1); g("Combo 1 has stages 1-2 only: 0 / 1.0 m, then 2.8 / 3.6 m (stage 2 starts after stage 1's 2.0 m)", c.length === 4 && c[0].w === 2 && c[0].l === 2 && c[0].h === 1 && nr(c[0].z0, 0) && nr(c[1].z0, 1) && nr(c[2].z0, 2.8) && nr(c[3].z0, 3.6), c);
      c = P("panda_nAttack", 4, { auraBlast: 1 }); g("Aura Blast stage 5 (0.8 m back-step after the 9.3 m chain)", c[8].shape === "cylinder" && c[8].r === 2 && c[8].h === 3 && nr(c[8].z0, 8.5), c[8]);
      c = P("panda_nAttack", 4, { pndW59: 1 }); g("Force Gauntlet circles", c.length === 9 && c[0].r === 3 && c[4].r === 4 && c[7].r === 3 && c[8].r === 4 && c[8].h === 3, c);
      c = P("panda_nAttack", 4, { pndW59: 1, auraBlast: 1 }); g("Aura Blast ignores Force Gauntlet", c[8].r === 2 && c[8].anchor === "self", c[8]);
      c = P("panda_qiStrike", 1, { qiBurst: 1 }); g("Qi Burst 1+5", c[0].l === 6 && c[0].w === 2, c);
      c = P("panda_qiStrike", 1); g("Qi Strike starts 3.2 m ahead (16 x 0.2 s)", c.length === 1 && c[0].z0 === 3.2, c);
      c = P("panda_drunkenFist", 1); g("Drunken Fist: 4 hits at 0.6 / 1.5 / 2.41 / 3.85 m", c.length === 4 && [0.6, 1.5, 2.41, 3.85].every((d, i) => Math.abs(c[i].z0 - d) < 1e-9), c);
      c = P("panda_deathBlow", 1); g("Death Blow = Stasis Blow: 0.9 m", c.length === 1 && c[0].z0 === 0.9, c);
      c = P("panda_pummel", 1, { ogreImpact: 1 }); g("Pummel Ogre Impact: after a 1.6 m dash (16 x 0.1 s)", c[0].w === 4 && c[0].l === 3 && c[0].h === 3 && !c[0].rangeMod && c[0].z0 === 1.6, c);
      c = P("panda_threeSteps", 1); g("Three Steps: one 2x1x2 box at 1.2 / 2.4 / 4.9 m of dash, hits at 0.4 / 0.7 / 1.3 s", c.length === 3 && c[0].w === 2 && c[0].l === 1 && c[0].h === 2 && [1.2, 2.4, 4.9].every((d, i) => Math.abs(c[i].z0 - d) < 1e-9) && [0.4, 0.7, 1.3].every((t, i) => Math.abs(c[i].at - t) < 1e-9), c);
      c = P("panda_wind&cloud", 1); g("Wind & Cloud: 9 hits, the Panda drifting 0.9 / 1.8 / 2.1 / 2.1 / 2.1 / 2.1 / 2.3 / 2.5 / 2.9 m", c.length === 9 && [0.9, 1.8, 2.1, 2.1, 2.1, 2.1, 2.3, 2.5, 2.9].every((d, i) => Math.abs(c[i].z0 - d) < 1e-9) && Math.abs(c[8].at - 2.9) < 1e-9, c.map(b => b.z0));
      c = P("panda_rain&storm", 1); g("Rain & Storm: 4 hits at 1.5 / 3.3 / 5.1 / 6.3 m of drift (0.5 / 1.1 / 1.7 / 2.0 s)", c.length === 4 && [1.5, 3.3, 5.1, 6.3].every((d, i) => Math.abs(c[i].z0 - d) < 1e-9) && [0.5, 1.1, 1.7, 2.0].every((t, i) => Math.abs(c[i].at - t) < 1e-9), c.map(b => b.z0));
      c = P("panda_towerRush", 1, { ogreImpact: 1 }); g("Tower Rush Ogre Impact: r4 h6 after a 1.6 m dash", c[0].shape === "cylinder" && c[0].r === 4 && c[0].h === 6 && c[0].z0 === 1.6, c);
      c = P("panda_tigerToss", 1, { tigerPounce: 1 }); g("Tiger Pounce landing", c.length === 2 && c[1].r === 3 && c[1].h === 6 && c[1].anchor === "target", c);
      c = P("panda_waterMonkey", 2, { shadowFist: 5 }); g("Water Monkey Spirit Fist", c.length === 2 && c[0].w === 6 && c[0].l === 3 && c[0].z0 === -0.1 && c[1].z0 === 1.9, c);   // -1 / +1 plus a 0.9 m drift (3 x 0.3 s)
      c = P("panda_waterMonkey", 2); g("Water Monkey base", c[0].w === 4 && c[0].l === 2 && c[0].h === 3, c);
      c = P("panda_stasisBlow", 2, { shadowFist: 5 }); g("Stasis Blow Spirit Fist", c[0].w === 4 && c[0].l === 5 && c[0].h === 2 && c[0].z0 === 0.9, c);   // -2 plus a 2.9 m dash (3 x 0.3 s + 10 x 0.2 s)
      c = P("panda_waterCrane", 2, { shadowFist: 5 }); g("Water Crane Spirit Fist r5", c[0].r === 5 && c[0].h === 5, c);
      c = P("panda_wind&cloud", 2); g("Wind & Cloud r3 h2", c[0].r === 3 && c[0].h === 2, c);
      c = P("panda_rain&storm", 2, { shadowFist: 5 }); g("Rain & Storm Spirit Fist r6", c[0].r === 6, c);
      c = P("panda_heavenPalm", 2, { shadowFist: 5 }); g("Heaven Palm rank 2 + Spirit Fist r7", c[0].r === 7 && c[0].h === 2, c);
      c = P("panda_heavenPalm", 1); g("Heaven Palm rank 1 r4", c[0].r === 4, c);
      c = P("panda_risingDragons", 2); g("Rising Dragons: 8 uppercuts r3 h6 every 0.15 s from 0.6 s, then the r4 h3 finisher at 2.1 s", c.length === 9 && c.slice(0, 8).every((p, k) => p.r === 3 && p.h === 6 && Math.abs(p.at - (0.6 + 0.15 * k)) < 1e-6) && c[8].r === 4 && c[8].h === 3 && c[8].at === 2.1, c);
      c = P("panda_rushingFalcon", 2); g("Rushing Falcon: the 3.2-to-2 trapezoid (starts 0.5 m behind) after a 1.6 m dash (0.3 s), then 2x1x2 boxes at 2.8 m (0.5 s) and 4.4 m (0.7 s)", c.length === 3 && c[0].w === 3.2 && c[0].w2 === 2 && c[0].l === 2 && Math.abs(c[0].z0 - 1.1) < 1e-9 && c[1].l === 1 && Math.abs(c[1].z0 - 2.8) < 1e-9 && Math.abs(c[2].z0 - 4.4) < 1e-9 && [0.3, 0.5, 0.7].every((t, i) => Math.abs(c[i].at - t) < 1e-9), c);
      c = P("panda_ashura", 2); g("Ashura circle after the 3.6 m lunge", c[0].r === 3 && c[0].h === 3 && c[0].z0 === 3.6, c);
      c = P("panda_fuujinKen", 1); g("Fuujin Ken r12 h9", c[0].r === 12 && c[0].h === 9, c);
      c = P("panda_raijinKen", 1); g("Raijin Ken flat lock ring r35 (vFlat) + r8 h8", c[0].shape === "ring" && c[0].r === 35 && c[1].r === 8 && c[1].h === 8, c);
      c = P("panda_lotusPalm", 2); g("Lotus Palm 40 m lock = a flat ring", c[0].shape === "ring" && c[0].r === 40, c);
      // rangeMod (Enlarge 4 = x1.4, Reduce 4 = x0.6): only the sizes the Find* call multiplies by rangeMod scale
      c = P("panda_nAttack", 4, {}, 1.4); g("Combo stage 5 at x1.4 (start offset scales, the chained dash does not)", c[8].w === 8.4 && c[8].w2 === 4.48 && c[8].l === 5.6 && c[8].h === 4.2 && nr(c[8].z0, 7.9), c[8]);
      c = P("panda_nAttack", 4, { pndW59: 1 }, 1.4); g("Force Gauntlet circles ignore rangeMod", c[0].r === 3 && c[8].r === 4, c);
      c = P("panda_waterMonkey", 2, {}, 1.4); g("Water Monkey: height only", c[0].w === 4 && c[0].l === 2 && c[0].h === 4.2 && c[0].z0 === -0.1, c[0]);
      c = P("panda_qiStrike", 1, { qiBurst: 1 }, 1.4); g("Qi Strike: 1×rangeMod + 5, width and height scale", c[0].l === 6.4 && c[0].w === 2.8 && c[0].h === 2.8, c[0]);
      c = P("panda_stasisBlow", 2, {}, 0.6); g("Stasis Blow at x0.6: length and height", c[0].w === 2 && c[0].l === 2.4 && c[0].h === 1.2 && c[0].z0 === 0.9, c[0]);
      c = P("panda_rushingFalcon", 2, {}, 1.4); g("Rushing Falcon: the 0.5 m start is not scaled (the dash is not either)", c[0].w === 4.48 && Math.abs(c[0].z0 - 1.1) < 1e-9, c[0]);
      c = P("panda_ashura", 2, {}, 1.4); g("Ashura ignores rangeMod", c[0].r === 3, c[0]);
      c = P("panda_heavenPalm", 2, {}, 1.4); g("Heaven Palm r6 x1.4", c[0].r === 8.4 && c[0].h === 2.8 && c[0].rm === 1.4, c[0]);
      // Cat (Cat.cs Find* calls; KOIRnET4pM is the Cat's own transform)
      c = P("cat_nAttack", 1); g("Cat Combo 1: stage 1 after 2.4 m (3 x 0.2 + 9 x 0.2 s), stage 2 after 2.4 + 2.1 m", c.length === 2 && c[0].w === 2 && c[0].l === 3 && c[0].h === 2 && nr(c[0].z0, 1.4) && nr(c[1].z0, 3.5), c);
      c = P("cat_nAttack", 3); g("Cat Combo 3: stage 4 is 4 wide, hits 1.2 and 2.4 m after the 6.1 m chain", c.length === 6 && c[4].w === 4 && c[4].w2 === 4 && c[4].l === 3 && nr(c[4].z0, 6.3) && nr(c[5].z0, 7.5), c);
      c = P("cat_nAttack", 3, {}, 1.4); g("Cat Combo x1.4 scales size and start offset", c[4].w === 5.6 && c[4].l === 4.2 && c[4].h === 2.8 && nr(c[4].z0, 5.9), c[4]);
      c = P("cat_awareness", 2, {}, 1.4); g("Awareness r24 (not scaled), h3 x1.4", c[0].r === 24 && c[0].h === 4.2, c[0]);
      c = P("cat_fateDraw", 4, {}, 1.4); g("Fate Draw r15 h3 both scale", c[0].r === 21 && c[0].h === 4.2, c[0]);
      c = P("cat_doubleDown", 2); g("Double Down scan r24 + blast r1", c[0].r === 24 && c[0].h === 10 && c[1].r === 1 && c[1].h === 2 && c[1].anchor === "target", c);
      c = P("cat_doubleDown", 2, { rollTheDice: 1 }); g("Roll the Dice doubles the blast", c[1].r === 2, c[1]);
      c = P("cat_forwardLunge", 2); g("Forward Lunge: 4 flat 3 m hits at 0 / 0.9 / 1.8 / 2.7 m of dash (speed 9, 0.1 s apart) + a 4 m finisher at 3.6 m", c.length === 5 && c.slice(0, 4).every((b, i) => b.l === 3 && b.w === 2 && Math.abs(b.z0 - 0.9 * i) < 1e-9) && c[4].l === 4 && c[4].z0 === 3.6, c);
      c = P("cat_reverseThrust", 2, {}, 1.4); g("Reverse Thrust drawn behind and scaled, after a 2 m back-step (-10 x 0.2 s)", c[0].z0 === -6.2 && c[0].l === 4.2, c[0]);
      c = P("cat_heartRipper", 2, {}, 1.4); g("Heart Ripper r scales, h5 does not, 0.4 m ahead (2 x 0.2 s)", c[0].r === 1.4 && c[0].h === 5 && c[0].z0 === 0.4, c[0]);
      c = P("cat_moonBlade", 2, {}, 1.4); g("Moon Blade r4.2 / r5.6, h3, at 0.3 and 0.5 m of drift", c[0].r === 4.2 && c[1].r === 5.6 && c[0].h === 3 && c[0].z0 === 0.3 && c[1].z0 === 0.5, c);
      c = P("cat_backflip", 2); g("Backflip pass-through strip 2x4x2 starts 1 m ahead (4 x 0.25 s)", c.length === 1 && c[0].l === 4 && c[0].z0 === 1, c);
      c = P("cat_moonStorm", 2); g("Moon Storm 6 rings every 1.5 m + the 12 m blast twice (0.6 / 0.7 s)", c.length === 8 && c[5].z0 === 7.5 && c[6].z0 === 12 && c[6].r === 3 && c[7].z0 === 12 && c[6].at === 0.6 && c[7].at === 0.7, c);
      c = P("cat_deltaStrike", 1); g("Delta Strike rank 1: 2 to 12 wide, 6 long", c[0].w === 2 && c[0].w2 === 12 && c[0].l === 6 && c[0].h === 6, c);
      c = P("cat_deltaStrike", 2); g("Delta Strike rank 2: 2 to 18 wide, 8 long", c[0].w2 === 18 && c[0].l === 8, c);
      c = P("cat_pillagePlunge", 1); g("Pillage Plunge hit box 4x4x2 from 2 m behind, after a 2.4 m dash (24 x 0.1 s) + 6 m pass-through at the start", c[0].w === 4 && c[0].l === 4 && c[0].z0 === 0.4 && c[1].l === 6 && !c[1].z0, c);
      c = P("cat_supportFire", 1); const sfArea = c[0]; c = c.slice(1); g("Support Fire: a faint landing-area box (15 m wide, 20.14-28.09 m) and an endless run of r8 h3 shells from the six cannon lanes, landing 20-28.1 m ahead (the game's lowered arc), first shot after the 1 s set-up", sfArea.shape === "box" && sfArea.faint && sfArea.w === 15 && sfArea.z0 === 20.14 && sfArea.at === undefined && c.length === 48 && c.every(p => p.endless && p.r === 8 && p.h === 3 && [-7.5, -4.5, -1.5, 1.5, 4.5, 7.5].includes(p.x0) && p.z0 >= 20 && p.z0 <= 28.1) && Math.min(...c.map(p => p.at)) >= 1.6 && c.filter(p => p.final).length === 12, c.slice(0, 2));
      c = P("cat_luckyCard", 4); g("Lucky Card 20 m", c[0].shape === "line" && c[0].l === 20, c);
      c = P("cat_damageRoulette", 2); g("Damage Roulette r24 h12", c[0].r === 24 && c[0].h === 12, c);
      // Wolf (Wolf.cs Find* calls, HwwoC6K6XP = the Wolf's own transform; every size x rangeMod unless the line says otherwise)
      c = P("wolf_nAttack", 1); g("Wolf Combo 1: stage 1 4x3x2 after a 3 m dash (6 x 0.5 s), stage 2 after 3.075 + 1.28 m", c.length === 2 && c[0].w === 4 && c[0].l === 3 && c[0].h === 2 && nr(c[0].z0, 2) && nr(c[1].z0, 3.355), c);
      c = P("wolf_nAttack", 3); g("Wolf Combo 3: stage 3 starts 1.5 m behind and is 3.5 long, stage 4 has a 4 high hit and a 2 high hit 2 m later (chain 5.675 m)", c.length === 5 && c[2].l === 3.5 && nr(c[2].z0, 4.175) && c[3].h === 4 && c[3].l === 3 && nr(c[3].z0, 5.235) && c[4].h === 2 && nr(c[4].z0, 7.235), c);
      c = P("wolf_nAttack", 3, { wolfKatana: 1 }); g("Wolf Combo Katana: fixed 4x8, stage 3 3 to 4 wide 8.5 long, no rangeMod", c.length === 5 && c[0].l === 8 && c[0].w === 4 && c[2].w === 3 && c[2].w2 === 4 && c[2].l === 8.5 && nr(c[2].z0, 4.175) && c[3].h === 4 && !c[0].rangeMod, c);
      c = P("wolf_nAttack", 3, { wolfKatana: 1 }, 1.8); g("Katana ignores rangeMod (Lunar Eclipse 2)", c[0].l === 8 && c[0].z0 === 2, c[0]);
      c = P("wolf_nAttack", 2, {}, 1.4); g("Wolf Combo x1.4 scales size and start offset (the chained dash does not)", c[2].l === 4.9 && nr(c[2].z0, 3.575) && c[2].w === 5.6 && c[2].h === 2.8, c[2]);
      c = P("wolf_cAttack", 1); g("Charge Attack: 4 to 12 wide, 30 long, 6 high, band lowered 2 m", c[0].w === 4 && c[0].w2 === 12 && c[0].l === 30 && c[0].h === 6 && c[0].z0 === -1 && c[0].y0 === -2, c);
      c = P("wolf_cAttack", 1, {}, 1.4); g("Charge Attack x1.4: sizes scale, the 2 m drop does not", c[0].l === 42 && c[0].w2 === 16.8 && c[0].h === 8.4 && c[0].z0 === -1.4 && c[0].y0 === -2, c[0]);
      c = P("wolf_braveSpirit", 1, {}, 1.4); g("Brave Spirit r15 h3 both scale", c[0].r === 21 && c[0].h === 4.2, c[0]);
      c = P("wolf_crusader", 1); g("Crusader 4x4x2, hit after a 2.8 m dash (speed 7 x 0.4 s): starts 1.8 m ahead of the cast point", c.length === 1 && c[0].w === 4 && c[0].l === 4 && c[0].h === 2 && c[0].z0 === 1.8, c);
      c = P("wolf_powerBreak", 1); g("Power Break rank 1: 2 wide, 4 long, after a 1.2 m dash (6 x 0.2 s)", c[0].w === 2 && c[0].l === 4 && c[0].h === 3 && c[0].z0 === 0.2, c);
      c = P("wolf_powerBreak", 2); g("Power Break rank 2: 6 long", c[0].l === 6, c);
      c = P("wolf_armorBreak", 1); g("Armor Break rank 1: 2 wide, 3 long, after a 1.5 m dash (5 x 0.3 s)", c[0].w === 2 && c[0].l === 3 && c[0].h === 3 && c[0].z0 === 0.5, c);
      c = P("wolf_armorBreak", 2); g("Armor Break rank 2: 4 wide, 5 long", c[0].w === 4 && c[0].l === 5, c);
      c = P("wolf_crossBreak", 3); g("Cross Break r5 h8 after a 3.2 m dash (5 x 0.4 s + 3 x 0.4 s)", c[0].r === 5 && c[0].h === 8 && Math.abs(c[0].z0 - 3.2) < 1e-9, c);
      c = P("wolf_grandCross", 1); g("Grand Cross r6 h8 at the mark + a 3D 30 m command range (faint sphere)", c.length === 2 && c[0].r === 6 && c[0].h === 8 && c[0].anchor === "target" && c[1].shape === "sphere" && c[1].r === 30 && c[1].faint === true, c);
      c = P("wolf_massResurrection", 2); g("Mass Resurrection r40 h12, band lowered 4 m", c[0].r === 40 && c[0].h === 12 && c[0].y0 === -4, c);
      c = P("wolf_bladeFang", 3); g("Blade Fang rank 3: 2x4x2 boxes, 1 + rank = 4 hits at 2.4 / 3.6 / 5.4 / 7.2 m of dash", c.length === 4 && c.every((b, i) => b.w === 2 && b.l === 4 && b.h === 2 && Math.abs(b.z0 - (-1 + [2.4, 3.6, 5.4, 7.2][i])) < 1e-9), c);
      c = P("wolf_bladeFang", 1, { bloodFang: 1 }); g("Blood Fang: 4 wide 5 long, rank 1 = 2 hits", c.length === 2 && c[0].w === 4 && c[0].l === 5, c);
      c = P("wolf_bladeFang", 3, { bloodFang: 1 }, 1.4); g("Blade Fang: only height and start scale (the dash does not)", c[0].w === 4 && c[0].l === 5 && c[0].h === 2.8 && c[0].z0 === 1, c[0]);
      c = P("wolf_artCancel", 2); g("Art Cancel 6x3x2, after a 6 m dash (10 x 0.6 s)", c[0].w === 6 && c[0].l === 3 && c[0].h === 2 && c[0].z0 === 5, c);
      c = P("wolf_counter", 2); g("Counter 4x5x3, 0.1 m back then 1.8 m forward = 1.7 m", c[0].w === 4 && c[0].l === 5 && c[0].h === 3 && c[0].z0 === -0.3, c);
      c = P("wolf_impulse", 2); g("Impulse trigger sphere r3", c[0].shape === "sphere" && c[0].r === 3, c);
      c = P("wolf_feralStrike", 4); g("Feral Strike: one 4x8x3 box, hit after a 4.8 m dash (speed 16 x 0.3 s), so it starts 1.2 m behind the cast point", c.length === 1 && c[0].w === 4 && c[0].l === 8 && c[0].h === 3 && c[0].z0 === -1.2, c);
      c = P("wolf_feralAssault", 1); g("Feral Assault: four 12-to-6 wide 8 long boxes 4.2 m apart (first at the cast point) + r6 finisher at 16.8 m, no rangeMod", c.length === 5 && c.slice(0, 4).every((b, i) => b.w === 12 && b.w2 === 6 && b.l === 8 && Math.abs(b.z0 - (-6 + 4.2 * i)) < 1e-9 && !b.rangeMod) && c[4].r === 6 && c[4].z0 === 16.8, c);
      c = P("wolf_dualBrand", 1); g("Dual Brand: r5 h3 circle (0.5 m ahead) at 1.2 and 2.4 m of dash, 4x5x4 box at 3.8 and 5 m", c.length === 4 && c[0].r === 5 && c[0].h === 3 && c[0].z0 === 1.7 && c[1].z0 === 2.9 && c[2].w === 4 && c[2].l === 5 && c[2].h === 4 && c[2].z0 === 3.8 && c[3].z0 === 5, c);
      c = P("wolf_thirdRend", 1); g("Third Rend 4x4x3 after a 1.1 m dash", c.length === 1 && c[0].w === 4 && c[0].l === 4 && c[0].h === 3 && c[0].z0 === 1.1, c);
      c = P("wolf_bladeSong", 1); g("Blade Song 2 to 4 wide 6 long, 0.4 m behind the cast point, 7 slashes every 0.2 s at rank 1", c.length === 7 && c.every((p, k) => p.w === 2 && p.w2 === 4 && p.l === 6 && p.z0 === -0.4 && Math.abs(p.at - 0.2 * (k + 1)) < 1e-6), c);
      c = sandbox._reachPartsWith(SKILLS.find(x => x.id === "wolf_crusader"), 1, { reachEnlarge: 0, reachReduce: 0, reachLunar: 1 }); g("Lunar Eclipse 1: x1.4 size and start, and the 2.8 m dash scales with moveMod (+40%) = 3.92", c[0].z0 === 2.52, c);
      { const E = [0, 0, 21.54], mp = P("penguin_meteora", 2), on = sandbox._reachOnEnemy(mp, E), gc = P("wolf_grandCross", 1);
        g("Meteora with Boldas in the 40 m lock ring: the impact circle is centred on him (21.54 m), not 6 m ahead", on.find(p => p.shape === "cylinder").anchor === "self" && on.find(p => p.shape === "cylinder").z0 === 21.54 && on.find(p => p.shape === "cylinder").onEnemy === true && on.find(p => p.shape === "ring") === mp.find(p => p.shape === "ring"), on.map(p => [p.shape, p.anchor, p.z0]));
        g("Meteora with Boldas out of the lock range (60 m): the usual 6 m ahead", sandbox._reachOnEnemy(mp, [0, 0, 60]) === mp && sandbox._reachOnEnemy(mp, null) === mp, 1);
        g("Grand Cross uses the 3D 30 m sphere: Boldas at 21.54 m is in range, at 35 m he is not", sandbox._reachOnEnemy(gc, E)[0].onEnemy === true && sandbox._reachOnEnemy(gc, [0, 0, 35]) === gc, 1);
        g("A skill with no lock marker (Tiger Toss) is left alone", (() => { const t = P("panda_tigerToss", 1, { tigerPounce: 1 }); return sandbox._reachOnEnemy(t, E) === t; })(), 1); }
      c = P("wolf_twinResonance", 1); g("Twin Resonance: 40 crescents (190 degrees, h2, 2 m thick: inner 1 + 0.8 x i, outer 3 + 0.8 x i), 0.4 s apart, five in the final picture", c.length === 40 && c.every((b, i) => b.shape === "sector" && b.angle === 190 && b.h === 2 && Math.abs(b.r0 - (1 + 0.8 * i)) < 0.051 && Math.abs(b.r - b.r0 - 2) < 0.0001 && Math.abs(b.at - 0.4 * i) < 0.0051) && c[0].r0 === 1 && c[0].r === 3 && c[39].r0 === 32.2 && c[39].r === 34.2 && c[39].at === 15.6 && c.filter(b => b.final !== false).length === 5, c.length);
      { const plan = sandbox._reachSeqPlan(c), vis = (i, t) => sandbox._reachSeqVis(c[i], t, plan);
        g("Twin Resonance playback: 40 phases 0.4 s apart, then 0.7 s of hold before the final picture", plan && plan.T.length === 40 && Math.abs(plan.tEnd - 16.3) < 1e-6, plan);
        g("Playback is instant: round 1 alone at 0 s, round 2 replaces it at 0.4 s, nothing before the start, only the last round just before the end", vis(0, -0.1) === 0 && vis(0, 0) === 1 && vis(1, 0) === 0 && vis(0, 0.39) === 1 && vis(0, 0.4) === 0 && vis(1, 0.4) === 1 && vis(1, 0.79) === 1 && vis(39, 15.9) === 1 && vis(38, 15.9) === 0, [vis(0, 0), vis(1, 0.4), vis(39, 15.9)]);
        g("Playback end: at tEnd the other final rounds start to fade in (0.45 s, subtle), the last round stays, the rounds not marked final stay hidden", vis(0, 16.29) === 0 && vis(0, 16.3) === 0 && vis(0, 16.5) > 0 && vis(0, 16.5) < 1 && vis(0, 16.8) === 1 && vis(11, 16.8) === 1 && vis(39, 16.3) === 1 && vis(5, 16.8) === 0 && c[5].final === false && c[11].final === true, [vis(0, 16.5), vis(39, 16.3), vis(5, 16.8)]); }
      c = P("wolf_bladeFang", 3); g("Blade Fang hit times 0.2 / 0.4 / 0.7 / 1.0 s", [0.2, 0.4, 0.7, 1].every((t, i) => Math.abs(c[i].at - t) < 1e-9), c.map(b => b.at));
      { const cm = (id, rank, o) => sandbox._reachColorMap(P(id, rank, o)), uniq = (arr) => new Set(arr).size === arr.length, fin = (id) => { const ps = P(id, 1); return sandbox._reachColorMap(ps).filter((_, k) => ps[k].final !== false); };
        g("No two hits of a skill share a colour, even when the shape changes between them (Dual Brand circle then box, the Wolf combo stages, Blade Fang, Arctic Wind, Sweep, the Panda combo)", uniq(cm("wolf_dualBrand", 1)) && uniq(cm("wolf_nAttack", 3)) && uniq(cm("wolf_bladeFang", 3)) && uniq(cm("penguin_arcticWind", 3, { deadlyFrost: 1 })) && uniq(cm("whale_sweep", 2)) && uniq(cm("panda_nAttack", 4)), [cm("wolf_dualBrand", 1), cm("wolf_nAttack", 3)]);
        g("Twin Resonance: the five rounds of the final picture have five different colours, and neighbouring rounds differ during the playback", uniq(fin("wolf_twinResonance")) && (() => { const m = cm("wolf_twinResonance", 1); return m.every((x, i) => i === 0 || x !== m[i - 1]); })(), fin("wolf_twinResonance"));
        g("A skill with no timed hit keeps its group colours (Meteora: 4-colour scheme)", cm("penguin_meteora", 2).every(x => ["#f4f1e8", "#e5483f", "#d4af37", "#aeb4bd"].includes(x)), cm("penguin_meteora", 2)); }
      c = P("wolf_nAttack", 3); g("Wolf Combo hit times follow the game schedule (stage 2 anchored at 0.8 s, 3 at 1.44 s, 4 at 1.97 s): 0.65, 1.28, 1.77, 2.27, 2.77 s", [0.65, 1.28, 1.77, 2.27, 2.77].every((t, i) => Math.abs(c[i].at - t) < 0.0051), c.map(b => b.at));
      c = P("cat_nAttack", 3); g("Cat Combo hit times: 0.4, 1.0 (stage 2 anchored at 0.6), 1.5 / 1.7 (1.2), 2.0 / 2.2 (1.7) s", [0.4, 1.0, 1.5, 1.7, 2.0, 2.2].every((t, i) => Math.abs(c[i].at - t) < 0.0051), c.map(b => b.at));
      c = P("panda_nAttack", 4); g("Panda Combo hit times: 0.1 / 0.3, 0.8 / 1.0 (0.6), 1.7 / 1.9 / 2.1 (1.5), 2.9 (2.4), 3.3 (3.0) s", [0.1, 0.3, 0.8, 1.0, 1.7, 1.9, 2.1, 2.9, 3.3].every((t, i) => Math.abs(c[i].at - t) < 0.0051), c.map(b => b.at));
      c = P("whale_nAttack", 2); g("Whale Combo hit times: 0.5, 1.2 / 1.5 (stage 2 anchored at 0.8), 2.3 (1.8) s", [0.5, 1.2, 1.5, 2.3].every((t, i) => Math.abs(c[i].at - t) < 0.0051), c.map(b => b.at));
      c = P("penguin_arcticWind", 3, { deadlyFrost: 1 }); g("Arctic Wind: 8 hits, 0.2 s apart", c.length === 8 && Math.abs(c[7].at - 1.4) < 1e-9, c.map(b => b.at));
      c = P("wolf_feralAssault", 1); g("Feral Assault: boxes at 0 / 0.3 / 0.6 / 0.9 s, the ring at 1.2 s", [0, 0.3, 0.6, 0.9, 1.2].every((t, i) => Math.abs(c[i].at - t) < 1e-9), c.map(b => b.at));
      c = P("wolf_twinResonance", 1);
      // Penguin (Penguin.cs, ManaVortex.cs, Penguin_iceBlock.cs, Penguin_tornado.cs; sizes x rangeMod only where the card says rangeMod)
      c = P("penguin_nAttack", 1); g("Penguin Combo: a 19.6 m projectile line (14 m/s x 1.4 s)", c.length === 1 && c[0].shape === "line" && c[0].l === 19.6, c);
      c = P("penguin_nAttack", 1, {}, 1.4); g("Penguin Combo x1.4 = 27.44 m", c[0].l === 27.44, c[0]);
      c = P("penguin_cAttack", 1); g("Mana Field: a 3D sphere r8 (sqrMagnitude < 64), ticking every 1 s while charging (endless)", c.length > 1 && c.every(p => p.shape === "sphere" && p.r === 8 && p.endless) && c[1].at - c[0].at === 1, c.slice(0, 2));
      c = P("panda_cAttack", 1); g("Aura Field: a 3D sphere r8 (sqrMagnitude < 64), ticking every 1 s while charging (endless)", c.length > 1 && c.every(p => p.shape === "sphere" && p.r === 8 && p.endless) && c[1].at - c[0].at === 1, c.slice(0, 2));
      c = P("penguin_manaMissile", 4); g("Mana Missile: 40 m lock ring + a 36 m flight line", c.length === 2 && c[0].shape === "ring" && c[0].r === 40 && c[1].shape === "line" && c[1].l === 36, c);
      c = P("penguin_manaArc", 4); g("Mana Arc r3 h3", c[0].r === 3 && c[0].h === 3, c);
      c = P("penguin_dispell", 2, {}, 1.4); g("Dispell r5 h3, both scale", c[0].r === 7 && c[0].h === 4.2, c[0]);
      c = P("penguin_fallingStars", 2); g("Falling Stars rank 2: search r16 h6, burst r2 h4 at the target", c.length === 2 && c[0].r === 16 && c[0].h === 6 && c[1].r === 2 && c[1].h === 4 && c[1].anchor === "target", c);
      c = P("penguin_fallingStars", 2, { giantStar: 1 }); g("Giant Star: burst r3, the search radius stays 16 (FloorToInt(1.5) = 1)", c[0].r === 16 && c[1].r === 3, c);
      c = P("penguin_fallingComets", 1); g("Falling Comets: lock ring, scatter -8..+7 (15 square, z0 -8), blast r6 h4", c.length === 3 && c[1].w === 15 && c[1].z0 === -8 && c[1].x0 === -0.5 && c[2].r === 6 && c[2].h === 4, c);
      c = P("penguin_fallingComets", 1, { giantStar: 1 }); g("Giant Star: scatter -10..+9 (19 square), blast r9", c[1].w === 19 && c[1].z0 === -10 && c[2].r === 9, c);
      c = P("penguin_manaVortex", 3); g("Mana Vortex rank 3: r24 h6, 5 m ahead", c[0].r === 24 && c[0].h === 6 && c[0].z0 === 5, c);
      c = P("penguin_novaFlare", 1); g("Nova Flare: the vortex radii 16 / 20 / 24", c.length === 3 && c[0].r === 16 && c[1].r === 20 && c[2].r === 24 && c.every(p => p.h === 6), c);
      c = P("penguin_meteora", 2); g("Meteora rank 2: lock ring + r12 h6 at the target", c[1].r === 12 && c[1].h === 6 && c[1].anchor === "target", c);
      c = P("penguin_frozenBlast", 4); g("Frozen Blast rank 4: r6 h3", c[0].r === 6 && c[0].h === 3, c);
      c = P("penguin_frozenBlast", 4, { frozenBreak: 1 }); g("Frozen Break: +2 m", c[0].r === 8, c);
      c = P("penguin_arcticWind", 3); g("Arctic Wind: 4 boxes 4 to 5 wide, 4 long, 3 high, the wind moving 1 m per hit from the cast point", c.length === 4 && c.every((b, i) => b.w === 4 && b.w2 === 5 && b.l === 4 && b.h === 3 && b.z0 === i), c);
      c = P("penguin_arcticWind", 3, { deadlyFrost: 1 }); g("Deadly Frost: 8 boxes, the last at 7 m", c.length === 8 && c[7].z0 === 7, c);
      c = P("penguin_iceShield", 1); g("Ice Shield: lock ring only", c.length === 1 && c[0].shape === "ring", c);
      c = P("penguin_iceShield", 1, { frostSpike: 1 }); g("Frost Spike: r5 h3 around the holder", c.length === 2 && c[1].r === 5 && c[1].h === 3, c);
      c = P("penguin_iceBlock", 2); g("Ice Block rank 2: 5 blocks 1.5 m apart, r12 h6, 1.5 m ahead", c.length === 5 && c[0].x0 === -3 && c[4].x0 === 3 && c.every(p => p.r === 12 && p.h === 6 && p.z0 === 1.5), c);
      c = P("penguin_tornado", 3); g("Tornado rank 3: r3 h4 + a 30 m flat leash", c[0].r === 3 && c[0].h === 4 && c[1].shape === "ring" && c[1].r === 30, c);
      c = P("penguin_blizzard", 2); g("Blizzard rank 2: r12 h6 round the target", c[1].r === 12 && c[1].h === 6, c);
      c = P("penguin_arcticEmperor", 2); g("Arctic Emperor r8 h6", c[0].r === 8 && c[0].h === 6, c);
      c = P("penguin_parallelShift", 1); g("Parallel Shift r6 h3", c[0].r === 6 && c[0].h === 3, c);
      c = P("penguin_cosmicFriday", 1); g("Cosmic Friday r3 h3", c[0].r === 3 && c[0].h === 3, c);
      for (const id of ["penguin_mpTransfer", "penguin_manaBurn", "penguin_snowMan", "penguin_absoluteZero", "penguin_snowBall"]) { c = P(id, 1); g(id + ": 40 m lock ring only", c.length === 1 && c[0].shape === "ring" && c[0].r === 40, c); }
      // Whale (Whale.cs, Whale_overPresence.cs; sizes x rangeMod only where the card says rangeMod)
      c = P("whale_nAttack", 1); g("Whale Combo rank 1: stage 1 at 0.8 m, stage 2 at 1.6 and 2.4 m, 3x4x2 boxes, no Star Spear sphere until its toggle is on", c.length === 3 && c[0].w === 3 && c[0].l === 4 && c[0].h === 2 && Math.abs(c[0].z0 - 0.8) < 0.011 && Math.abs(c[1].z0 - 1.6) < 0.011 && Math.abs(c[2].z0 - 2.4) < 0.011, c);
      c = P("whale_nAttack", 1, { whlW59: 1 }); g("Star Spear on: the faint r9 sphere", c.length === 4 && c[3].shape === "sphere" && c[3].r === 9 && c[3].faint === true, c);
      c = P("whale_nAttack", 2, { entendedWave: 1, whlW59: 1 }); g("Whale Combo rank 2 + Entended Wave: stages 1-2 3x7, stage 3 4x7, Star Spear r12", c.length === 5 && c[0].l === 7 && c[3].w === 4 && c[3].l === 7 && c[4].r === 12, c);
      c = P("whale_nAttack", 2, {}, 1.4); g("Whale Combo x1.4: width and height scale, length does not", c[0].w === 4.2 && c[0].h === 2.8 && c[0].l === 4 && c[3].w === 5.6, c);
      c = P("whale_cAttack", 1, { reachShieldBash: 1, reachKnightDeep: 1 }); g("Charge Attack: Shield Bash r3 h3 (x rangeMod) + Knight of the Deep r4 h3", c.length > 2 && c[0].r === 3 && c[0].h === 3 && c[0].rangeMod === true && c.slice(1).every(p => p.r === 4 && p.h === 3 && p.endless) && c[2].at - c[1].at === 0.5, c.slice(0, 3));
      c = P("whale_cAttack", 1, { reachShieldBash: 1, reachKnightDeep: 1 }, 1.4); g("Charge Attack x1.4: Shield Bash scales, Knight of the Deep does not", c[0].r === 4.2 && c[0].h === 4.2 && c[1].r === 4, c);
      c = P("whale_cAttack", 1, { reachShieldBash: 0, reachKnightDeep: 1 }); g("Charge Attack with Shield Bash off keeps only the Knight cylinder (endless, every 0.5 s)", c.length > 1 && c.every(p => p.r === 4 && p.endless), c.slice(0, 2));
      c = P("whale_sweep", 2); g("Sweep: first r4 h3 at 0.71 m (back-step then 9 x 0.1 s), second r5 h3 at 2.51 m", c.length === 2 && c[0].r === 4 && c[0].h === 3 && c[0].z0 === 0.71 && c[1].r === 5 && c[1].h === 3 && c[1].z0 === 2.51, c);
      c = P("whale_sweep", 2, { tideCutter: 1 }, 1.4); g("Tide Cutter: first r6 (radius does not scale), height and the second hit scale", c[0].r === 6 && c[0].h === 4.2 && c[1].r === 7 && c[1].h === 4.2, c);
      c = P("whale_honor", 2); g("Honor rank 2: friends r15 h3, Hate r30 h6", c.length === 2 && c[0].r === 15 && c[0].h === 3 && c[1].r === 30 && c[1].h === 6, c);
      c = P("whale_shieldRush", 1, {}, 1.4); g("Shield Rush 2x2x3 all x rangeMod, dash 0.6 m per rank (6 x rank x 0.1 s) does not scale", c[0].w === 2.8 && c[0].l === 2.8 && c[0].h === 4.2 && c[0].z0 === 0.6, c);
      c = P("whale_shieldRush", 2); g("Shield Rush rank 2 dashes 1.2 m", c[0].z0 === 1.2, c);
      c = P("whale_swallow", 1); g("Swallow: 40 m lock ring + the 2x2x3 swallow box", c.length === 2 && c[0].shape === "ring" && c[0].r === 40 && c[1].w === 2 && c[1].l === 2 && c[1].h === 3, c);
      c = P("whale_gobbleUp", 1); g("Gobble Up r3 h3 at the swallowed target", c[0].r === 3 && c[0].h === 3 && c[0].anchor === "target", c);
      c = P("whale_peninsulaImpale", 2); g("Peninsula Impale 2x6x3, rank 2 = 10 hits at 0.6, 1.0, ... 4.2 m", c.length === 10 && c[0].w === 2 && c[0].l === 6 && c[0].h === 3 && c[0].z0 === 0.6 && c[1].z0 === 1 && c[9].z0 === 4.2, c);
      c = P("whale_peninsulaImpale", 1); g("Peninsula Impale rank 1 = 6 hits", c.length === 6, c);
      c = P("whale_peninsulaImpale", 2, { peninsulaAsunder: 1 }); g("Peninsula Asunder: 3x12", c[0].w === 3 && c[0].l === 12, c);
      c = P("whale_peninsulaRound", 2); g("Peninsula Round 3x4x3 after a 0.6 m dash, 7 hits every 0.4 s at rank 2, + a faint r20 redirect sphere", c.length === 8 && c[0].w === 3 && c[0].l === 4 && c[0].z0 === 0.6 && c[6].z0 === 0.6 && c[0].at === 0.2 && c[6].at === 2.6 && c[7].shape === "sphere" && c[7].r === 20 && c[7].faint === true, c);
      c = P("whale_peninsulaRound", 2, { peninsulaAsunder: 1 }); g("Peninsula Asunder: 6x5 from 1 m behind, after the 0.6 m dash", c[0].w === 6 && c[0].l === 5 && c[0].z0 === -0.4, c);
      c = P("whale_12thKingdomKnight", 2); g("12th Kingdom Knight: faint sphere r8", c[0].shape === "sphere" && c[0].r === 8 && c[0].faint === true, c);
      c = P("whale_hydroBlast", 4); g("Hydro Blast: lock ring + r1 h6 at the target", c.length === 2 && c[0].shape === "ring" && c[1].r === 1 && c[1].h === 6 && c[1].anchor === "target", c);
      c = P("whale_hydroBlast", 4, { spiralBlast: 1 }); g("Spiral Blast: r2", c[1].r === 2, c);
      c = P("whale_whaleWave", 2); g("Whale Wave r6 h3", c[0].r === 6 && c[0].h === 3, c);
      c = P("whale_whaleWave", 2, { divingPress: 1 }, 1.4); g("Diving Press: r9, only the height scales", c[0].r === 9 && c[0].h === 4.2, c);
      c = P("whale_malStorm", 2); g("Mal Storm r8 h5", c[0].r === 8 && c[0].h === 5, c);
      c = P("whale_malStorm", 2, { divingPress: 1 }, 1.4); g("Diving Press: r12, height x1.4", c[0].r === 12 && c[0].h === 7, c);
      c = P("whale_callToArm", 1); g("Call To Arm r12 h3", c[0].r === 12 && c[0].h === 3, c);
      c = P("whale_megalodon", 2); g("Megalodon rank 2: lock ring, suction r5 h5 at 0 / 1 / 2 / 3 s, bite r7 h10 at 4 / 5.5 s", c.length === 7 && [1, 2, 3, 4].every((i, k) => c[i].r === 5 && c[i].h === 5 && c[i].at === k) && c[5].r === 7 && c[5].h === 10 && c[5].at === 4 && c[6].at === 5.5, c);
      c = P("whale_bubbleBurst", 1); g("Bubble Burst: r12 h3 blast + the 200 m search (faint, not used for the zoom)", c.length === 2 && c[0].r === 12 && c[1].r === 200 && c[1].h === 50 && c[1].faint === true && c[1].noZoom === true && sandbox._reachBadgeText(c) === "r 12m", c);
      c = P("whale_bowlingWhale", 1); g("Bowling Whale r3 h3", c[0].r === 3 && c[0].h === 3, c);
      c = P("whale_grandTide", 1); g("Grand Tide 16x7x4 from 4 m behind", c[0].w === 16 && c[0].l === 7 && c[0].h === 4 && c[0].z0 === -4, c);
      c = P("whale_overPresence", 2); g("Over Presence: the prefab's SphereCollider r6", c[0].shape === "sphere" && c[0].r === 6, c);
      c = P("whale_flyingShield", 1); g("whale_flyingShield: range lives in the prefab / animation, badge ?", c.length === 1 && c[0].unknown === true, c);
      c = P("whale_javelin", 1); g("whale_javelin: the traced flight, 10 timed 0.25 m boxes from the hand (2.2 m up) down to the ground ~20 m ahead", c.length === 10 && c.every(p => p.shape === "box" && p.w === 0.25) && c[0].yBand[1] > 2.2 && c[9].yBand[0] < 0.2 && c[9].z0 + c[9].l > 19 && c[9].z0 + c[9].l < 24 && c[0].at >= 0.5, c.slice(0, 2));
      for (const id of ["whale_bubbleShield", "whale_heavyWeight", "whale_rejuvenate", "whale_homingShield"]) { c = P(id, 1); g(id + ": 40 m lock ring only", c.length === 1 && c[0].shape === "ring" && c[0].r === 40, c); }
      // preview toggles: Lunar Eclipse adds 0.4 per level to the Enlarge / Reduce factor, so Enlarge 4 + Lunar 1 = x1.8 and Lunar 2 alone = x1.8
      {
        const ct = SKILLS.find(x => x.id === "wolf_counter");
        c = sandbox._reachPartsWith(ct, 1, { reachEnlarge: 0, reachReduce: 0, reachLunar: 2 }); g("preview Lunar Eclipse 2 = x1.8 on Counter", c[0].l === 9 && c[0].w === 7.2 && c[0].z0 === -0.54, c[0]);   // -3.6 (x1.8 start) + the 1.7 m dash x1.8 moveMod
        c = sandbox._reachPartsWith(ct, 1, { reachEnlarge: 4, reachReduce: 0, reachLunar: 1 }); g("preview Enlarge 4 + Lunar 1 = x1.8", c[0].l === 9, c[0]);
      }
      // the popup preview reads its own toggle state and leaves the card's alone
      set({});
      const qs = SKILLS.find(x => x.id === "panda_qiStrike");
      c = sandbox._reachPartsWith(qs, 1, { qiBurst: 1, reachEnlarge: 4, reachReduce: 0 }); g("preview override: Qi Burst on at x1.4", c[0].l === 6.4, c[0]);
      c = sandbox._reachNormalize(qs.reach, 1); g("card state untouched after a preview", c[0].l === 1 && dr.qiBurst === 0, c[0]);
      c = sandbox._reachPartsWith(qs, 1, { qiBurst: 0, reachEnlarge: 0, reachReduce: 4 }); g("preview Reduce 4 = x0.6", c[0].l === 0.6 && c[0].w === 1.2, c[0]);
    } finally { for (const k of Object.keys(dr)) if (!(k in saved)) delete dr[k]; Object.assign(dr, saved); }
  }
  // reachControls: a plain dep (id, minRank, maxRank) or {dep, onRank, offRank}
  for (const sk of SKILLS) for (const c of sk.reachControls || []) {
    const ok = c.dep ? (c.dep.id && Number.isInteger(c.onRank) && Number.isInteger(c.offRank) && c.onRank !== c.offRank && c.onRank <= c.dep.maxRank && c.offRank >= c.dep.minRank) : (c.id && Number.isInteger(c.minRank) && Number.isInteger(c.maxRank));
    if (!ok) bad(`${sk.id}: bad reachControls entry ${JSON.stringify(c.dep ? { dep: c.dep.id, on: c.onRank, off: c.offRank } : c.id)}`);
  }
  // hero models: every embedded class model decodes to matching vertex / uv counts, in-range indices and a PNG skin
  {
    // a model line is one object literal: { v, uv, t, tex, extra: [{ v, uv, t, tex }, ...] } (extra = static accessories such as hair)
    const REACH_MODELS = vm.runInContext("REACH_MODELS", sandbox);
    let models = 0;
    // textures: a PNG or WebP data URL, "#name" (REACH_TEX, shared by several models) or "@Model" (that model's own skin); "base" variants reuse another model (user 2026-10-16)
    const REACH_TEX = vm.runInContext("REACH_TEX", sandbox);
    const imgOk = (t) => { const tex = String(t); if (tex[0] === "#") return !!REACH_TEX[tex.slice(1)] && imgOk(REACH_TEX[tex.slice(1)]); if (tex[0] === "@") return tex.slice(1) in REACH_MODELS; const b = Buffer.from(tex.replace(/^data:image\/(png|webp);base64,/, ""), "base64"); return b.readUInt32BE(0) === 0x89504e47 || (b.toString("ascii", 0, 4) === "RIFF" && b.toString("ascii", 8, 12) === "WEBP"); };
    const partInfo = (name, p, label) => {
      const vb = Buffer.from(p.v, "base64"), ub = Buffer.from(p.uv, "base64"), tb = Buffer.from(p.t, "base64");
      const nv = vb.length / 6, nu = ub.length / 4, nt = tb.length / 6;
      let maxI = 0; for (let i = 0; i < tb.length; i += 2) maxI = Math.max(maxI, tb.readUInt16LE(i));
      let minY = Infinity, maxY = -Infinity; for (let i = 0; i < vb.length; i += 6) { const y = vb.readInt16LE(i + 2) / 1000; minY = Math.min(minY, y); maxY = Math.max(maxY, y); }
      if (!Number.isInteger(nv) || nv !== nu || !Number.isInteger(nt) || maxI >= nv || !imgOk(p.tex)) bad("model " + name + " " + label + ": " + nv + " verts, " + nu + " uvs, " + nt + " tris, max index " + maxI);
      return { nv, nt, minY, maxY };
    };
    for (const [name, def] of Object.entries(REACH_MODELS)) {
      models++;
      if (def.base){   // a variant: the base model's parts plus its own extras (Monkey forms, Gadina 4 with its weapons)
        if (!(def.base in REACH_MODELS)) bad("model " + name + ": base " + def.base + " has no REACH_MODELS entry");
        const vx = (def.extra || []).map((q, i) => partInfo(name, q, "extra " + i));
        const PIN = { MonkeyEarthForm: [[2235, 1948]], Gadina4: [[443, 356], [541, 394]] };   // gadinaArmor_tri, phoenixArmor_tri; Gadina_Sword4 / Gadina_Shield4
        if (PIN[name] && JSON.stringify(vx.map(x => [x.nv, x.nt])) !== JSON.stringify(PIN[name])) bad("model " + name + ": extras " + JSON.stringify(vx.map(x => [x.nv, x.nt])) + ", expected " + JSON.stringify(PIN[name]));
        if (name === "MonkeyEarthForm" && vx[0] && (vx[0].minY < 0 || vx[0].maxY > 2)) bad("model MonkeyEarthForm: the arms should float round the Monkey (0-2 m), got " + vx[0].minY + "-" + vx[0].maxY);
        continue;
      }
      const body = partInfo(name, def, "body");
      if (body.minY < -0.05 || body.maxY < 0.3) bad("model " + name + ": stands from " + body.minY + " to " + body.maxY + " m (feet should be on the ground)");
      if (name === "Cat" && (body.nv !== 1687 || body.nt !== 1812)) bad("model Cat: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh has 1687 / 1812");
      if (name === "Panda" && (body.nv !== 1573 || body.nt !== 1212)) bad("model Panda: " + body.nv + " verts / " + body.nt + " tris, the game mesh has 1573 / 1212");
      if (name === "Wolf" && (body.nv !== 2054 || body.nt !== 1929)) bad("model Wolf: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Wolf_standard_tri) has 2054 / 1929");
      if (name === "Wolf") { const wx = (def.extra || []).map((p, i) => partInfo(name, p, "extra " + i)); if (wx.length !== 1 || wx[0].nv !== 382 || wx[0].nt !== 246) bad("model Wolf: extras should be the standard sword in both hands (2 x 191 verts / 2 x 123 tris), got " + JSON.stringify(wx)); }
      const extras = (def.extra || []).map((p, i) => partInfo(name, p, "extra " + i));
      if (name === "Penguin") {
        // armors/Penguin_standard_tri.asset 1074 / 1212; extras = the standard hat c_pgn10 (Penguin_standardHat_tri 218 / 222, on the Hat1 bone with Euler(-20, -80, -115)) and the standard wand w_pgn10 (WP_Penguin_01 106 / 130, mount_Hand_L)
        if (body.nv !== 1074 || body.nt !== 1212) bad("model Penguin: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Penguin_standard_tri) has 1074 / 1212");
        if (extras.length !== 2 || extras[0].nv !== 218 || extras[0].nt !== 222 || extras[1].nv !== 106 || extras[1].nt !== 130) bad("model Penguin: extras should be the standard hat (218 / 222) and the standard wand (106 / 130), got " + JSON.stringify(extras));
      }
      if (name === "Whale") {
        // armors/Whale_standard_tri.asset 1471 / 1692 (the standard armor, no hat); extras = standardLance in mount_Hand_R (WhaleEquipment.EquipWeapon nHand == 1, 141 / 76) and standardShield in mount_Hand_L (172 / 148), identity local transform
        if (body.nv !== 1471 || body.nt !== 1692) bad("model Whale: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Whale_standard_tri) has 1471 / 1692");
        if (extras.length !== 2 || extras[0].nv !== 141 || extras[0].nt !== 76 || extras[1].nv !== 172 || extras[1].nt !== 148) bad("model Whale: extras should be the standard lance (141 / 76) and the standard shield (172 / 148), got " + JSON.stringify(extras));
      }
      if (name === "Bison") {
        // armors/Bison_standard_tri 2964 / 2165 (no hat); extra = standardAxe (Bison_standardAxe_tri 292 / 172) in HandMount_R
        if (body.nv !== 2964 || body.nt !== 2165) bad("model Bison: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Bison_standard_tri) has 2964 / 2165");
        if (extras.length !== 1 || extras[0].nv !== 292 || extras[0].nt !== 172) bad("model Bison: the extra should be the standard axe (292 / 172), got " + JSON.stringify(extras));
      }
      if (name === "Sheep") {
        // armors/Sheep_standard_tri 2484 / 1888 (no hat); extra = standardBook (75 / 56) in mount_Hand_L
        if (body.nv !== 2484 || body.nt !== 1888) bad("model Sheep: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Sheep_standard_tri) has 2484 / 1888");
        if (extras.length !== 1 || extras[0].nv !== 75 || extras[0].nt !== 56) bad("model Sheep: the extra should be the standard book (75 / 56), got " + JSON.stringify(extras));
      }
      if (name === "Rabbit") {
        // armors/Rabbit_standard_tri 1687 / 1838; extras = starting hat standardHat (147 / 296, Head bone Euler(0,-90,90)) and standardGun (494 / 290, mountHand_R)
        if (body.nv !== 1687 || body.nt !== 1838) bad("model Rabbit: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Rabbit_standard_tri) has 1687 / 1838");
        if (extras.length !== 2 || extras[0].nv !== 147 || extras[0].nt !== 296 || extras[1].nv !== 494 || extras[1].nt !== 290) bad("model Rabbit: extras should be the standard hat (147 / 296) and the standard gun (494 / 290), got " + JSON.stringify(extras));
      }
      if (name === "Bat") {
        // armors/Bat_standard_tri 2351 / 2398 (no hat); extra = standardWand (175 / 98) in mount_Hand_L
        if (body.nv !== 2351 || body.nt !== 2398) bad("model Bat: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Bat_standard_tri) has 2351 / 2398");
        if (extras.length !== 1 || extras[0].nv !== 175 || extras[0].nt !== 98) bad("model Bat: the extra should be the standard wand (175 / 98), got " + JSON.stringify(extras));
      }
      if (name === "MonkeyFireAvatar" && (body.nv !== 2347 || body.nt !== 3993 || extras.length)) bad("model MonkeyFireAvatar: the phoenixArmor body alone (it replaces the Monkey, user 2026-10-16) should be 2347 / 3993 with no extras, got " + body.nv + " / " + body.nt + " / " + extras.length);
      const GADINA = { Gadina1: [494, 406, 115, 120, 72, 48], Gadina2: [942, 694, 204, 184, 140, 128], Gadina3: [1889, 1310, 298, 252, 365, 260] };   // each form's own Gadina prefab, sword (mount_Hand_R) and shield (mount_Hand_L)
      if (GADINA[name]){ const g = GADINA[name]; if (body.nv !== g[0] || body.nt !== g[1] || extras.length !== 2 || extras[0].nv !== g[2] || extras[0].nt !== g[3] || extras[1].nv !== g[4] || extras[1].nt !== g[5]) bad("model " + name + ": " + JSON.stringify([body.nv, body.nt].concat(...extras.map(x => [x.nv, x.nt]))) + ", expected " + g.join(" / ")); }
      const SUMMON = { LightPanther: [1499, 1648], LightLeopard: [1526, 1652], LightGolem: [1403, 2440], AutoGyroGun: [763, 652], BarrelBot: [1324, 1238], KingKaiser: [3830, 2828], MoleTank: [1724, 1420], GigaCannon: [1639, 1684], Phoenix: [1478, 1598], Ja: [526, 560], Gadina: [2453, 1694], Buiten: [860, 584], Gaos: [7130, 4446] };   // single-prefab summon meshes (Rabbit Mercenaries): Panther_tri / Leopard / LightGolem skinned meshes, no extras
      if (SUMMON[name] && (body.nv !== SUMMON[name][0] || body.nt !== SUMMON[name][1] || extras.length)) bad("model " + name + ": " + body.nv + " verts / " + body.nt + " tris / " + extras.length + " extras, expected " + SUMMON[name].join(" / ") + " and none");
      if (name === "Chameleon") {
        // armors/Chameleon_standard_tri 1783 / 1923; extras = starting goggle (58 / 66, Goggle bone Euler(-90,0,0)), standardBow (196 / 123, mount_Hand_L), standardArrow (38 / 32, mount_Hand_R)
        if (body.nv !== 1783 || body.nt !== 1923) bad("model Chameleon: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Chameleon_standard_tri) has 1783 / 1923");
        if (extras.length !== 3 || extras[0].nv !== 58 || extras[0].nt !== 66 || extras[1].nv !== 196 || extras[1].nt !== 123 || extras[2].nv !== 38 || extras[2].nt !== 32) bad("model Chameleon: extras should be goggle 58 / 66, bow 196 / 123, arrow 38 / 32, got " + JSON.stringify(extras));
      }
      if (name === "Mole") {
        // armors/Mole_standard_tri 1744 / 2014; extras = goggle (112 / 112, Head bone Euler(0,-90,90)) and the skinned standard cannon WP_Mole01 (465 / 418, mount_Cannon)
        if (body.nv !== 1744 || body.nt !== 2014) bad("model Mole: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Mole_standard_tri) has 1744 / 2014");
        if (extras.length !== 2 || extras[0].nv !== 112 || extras[0].nt !== 112 || extras[1].nv !== 465 || extras[1].nt !== 418) bad("model Mole: extras should be goggle 112 / 112 and cannon 465 / 418, got " + JSON.stringify(extras));
      }
      if (name === "Monkey") {
        // armors/Monkey_standard_tri 1506 / 1692; extras = starting bandana (110 / 152, Head bone Euler(0,-90,90)) and standardMike (258 / 220, mount_Summon)
        if (body.nv !== 1506 || body.nt !== 1692) bad("model Monkey: " + body.nv + " verts / " + body.nt + " tris, the game armor mesh (Monkey_standard_tri) has 1506 / 1692");
        if (extras.length !== 2 || extras[0].nv !== 110 || extras[0].nt !== 152 || extras[1].nv !== 258 || extras[1].nt !== 220) bad("model Monkey: extras should be bandana 110 / 152 and mike 258 / 220, got " + JSON.stringify(extras));
      }
      if (name === "Boldas") {
        // the opponent on start point 2: Boldas_tri 2306 / 1802 (skinned on the Liger_npc rig, idle pose) + his sword WEP_Boldas 308 vertices / 269 triangles, planted tip down (it reaches below the feet)
        if (body.nv !== 2306 || body.nt !== 1802) bad("model Boldas: " + body.nv + " verts / " + body.nt + " tris, the game mesh (Boldas_tri) has 2306 / 1802");
        if (extras.length !== 1 || extras[0].nv !== 308 || extras[0].nt !== 269) bad("model Boldas: the extra should be his sword (308 verts / 269 tris), got " + JSON.stringify(extras));
        else if (extras[0].minY > -0.3) bad("model Boldas: the sword is planted tip down, it should reach below the feet, got " + extras[0].minY);
      }
      // NPC coin summons (2026-10-19): each Resources prefab's own mesh on the first key of its default clip; Italus keeps his four WEP_Italus pistols (4 x 317 / 168) as one extra
      const COIN_NPC = { Dwukphu: [1077, 1236, null], Razan: [1712, 1770, null], Italus: [2332, 1930, [1268, 672]] };   // Catfish_tri, Crocodile_tri, Italus_tri
      if (COIN_NPC[name]){ const [nv, nt, ex] = COIN_NPC[name];
        if (body.nv !== nv || body.nt !== nt) bad("model " + name + ": " + body.nv + " verts / " + body.nt + " tris, the game mesh has " + nv + " / " + nt);
        if (ex ? (extras.length !== 1 || extras[0].nv !== ex[0] || extras[0].nt !== ex[1]) : extras.length) bad("model " + name + ": extras " + JSON.stringify(extras.map(x => [x.nv, x.nt])) + ", expected " + JSON.stringify(ex ? [ex] : [])); }
      if (name === "Cat") {
        // hair = accessories/default: 248 verts / 242 tris, sitting on the head (above the shoulders, within a head's height of the body top)
        if (extras.length !== 2 || extras[0].nv !== 248 || extras[0].nt !== 242 || extras[1].nv !== 244 || extras[1].nt !== 140) bad("model Cat: extras should be the default hair (248 verts / 242 tris) and the standard knife (244 / 140), got " + JSON.stringify(extras));
        else if (extras[0].minY < body.maxY - 0.6 || extras[0].maxY > body.maxY + 0.15) bad("model Cat: hair spans " + extras[0].minY + " to " + extras[0].maxY + " m, it should cover the head (body top " + body.maxY + " m)");
      }
    }
    for (const sk of SKILLS) if (sk.reachModel){   // a key, or (rank) => key (Gadina 1-4)
      const keys = typeof sk.reachModel === "function" ? Array.from({ length: sk.maxRank || 1 }, (_, i) => sk.reachModel(i + 1)) : [sk.reachModel];
      for (const k of keys) if (!(k in REACH_MODELS)) bad(sk.id + ": reachModel " + k + " has no REACH_MODELS entry");
    }
    { const mk = (id) => { const sk = SKILLS.find(x => x.id === id); return sk && (typeof sk.reachModel === "function" ? [1, 2, 3, 4].map(r => sk.reachModel(r)).join() : sk.reachModel); };
      if (mk("monkey_gadina") !== "Gadina1,Gadina2,Gadina3,Gadina4" || mk("monkey_fireAvatar") !== "MonkeyFireAvatar" || mk("monkey_earthForm_nAttack") !== "MonkeyEarthForm" || mk("monkey_planetBreaker") !== "Gadina4") bad("Monkey previews: Gadina follows its form, Fire Avatar and Earth Form show their form (user 2026-10-16)"); }
    if (!models) bad("no REACH_MODELS entries found");
  }
  // reach scenes (2026-10-14): the mission map behind the caster. Everything decodes, indices are in range, props stand on the terrain, both start points sit on it
  {
    let scenes = 0;
    const isPng = (u) => { const b = Buffer.from(String(u).split("base64,")[1] || "", "base64"); return b.readUInt32BE(0) === 0x89504e47 || (b.toString("latin1", 0, 4) === "RIFF" && b.toString("latin1", 8, 12) === "WEBP"); };   // PNG or lossless WebP (user 2026-10-25)
    for (const [name, d] of Object.entries(vm.runInContext("REACH_SCENES", sandbox))) {
      scenes++;
      const T = d.terrain, th = Buffer.from(T.h, "base64");
      if (th.length !== T.nx * T.nz * 2) bad(`scene ${name}: terrain has ${th.length / 2} heights, expected ${T.nx * T.nz}`);
      if (!isPng(T.alpha.uri) || T.tiles.length !== 4 || !T.tiles.every(isPng)) bad(`scene ${name}: terrain needs a splat map and 4 PNG tiles`);
      if (!d.tex.every(t => isPng(t.uri))) bad(`scene ${name}: a prop texture is not a PNG`);
      const ground = (x, z) => { const i = Math.round((x - T.x0) / T.step), j = Math.round((z - T.z0) / T.step); return i < 0 || j < 0 || i >= T.nx || j >= T.nz ? null : th.readInt16LE((j * T.nx + i) * 2) / 100; };
      if (d.spawns.length !== 2) bad(`scene ${name}: ${d.spawns.length} start points, expected 2`);
      for (const [k, s] of d.spawns.entries()) { const g = ground(s.x, s.z); if (g === null || Math.abs(g - s.gy) > 0.3) bad(`scene ${name}: start point ${k + 1} is at y ${s.gy} but the terrain under it is ${g}`); }
      d.meshes.forEach((mesh, i) => {
        const nv = Buffer.from(mesh.v, "base64").length / 6, nu = Buffer.from(mesh.uv, "base64").length / 4, tb = Buffer.from(mesh.t, "base64");
        let maxI = 0; for (let q = 0; q < tb.length; q += 2) maxI = Math.max(maxI, tb.readUInt16LE(q));
        if (!Number.isInteger(nv) || nv !== nu || tb.length % 6 || maxI >= nv || !d.tex[mesh.tex]) bad(`scene ${name}: mesh ${i} has ${nv} verts, ${nu} uvs, max index ${maxI}, skin ${mesh.tex}`);
      });
      for (const [q, ins] of d.inst.entries()) {
        const g = ground(ins[4], ins[12]);
        if (ins.length !== 13 || !d.meshes[ins[0]] || ins.some(v => !Number.isFinite(v))) { bad(`scene ${name}: instance ${q} is malformed`); continue; }
        // an origin may sit in a foundation below the ground (the ruins), but the prop's top must reach the terrain and its base must not float above it
        const vb = Buffer.from(d.meshes[ins[0]].v, "base64");
        let top = -Infinity, low = Infinity;
        for (let i = 0; i < vb.length; i += 6) { const px = vb.readInt16LE(i) / 1000, py = vb.readInt16LE(i + 2) / 1000, pz = vb.readInt16LE(i + 4) / 1000, wy = ins[5] * px + ins[6] * py + ins[7] * pz + ins[8]; top = Math.max(top, wy); low = Math.min(low, wy); }
        // M108 reuses M106's TerrainData (the game's own reference), so props on the rim (ruins, gates, tents far from the arena) are a few metres off it; the flat duel arena (22 m round a start point) is exact
        const inArena = d.spawns.some(s => Math.hypot(ins[4] - s.x, ins[12] - s.z) < 22);
        if (g === null || (inArena && (top < g - 0.5 || low > g + 1.5))) bad(`scene ${name}: instance ${q} spans y ${low.toFixed(2)}..${top.toFixed(2)} over terrain ${g}`);
      }
      // trimmed to a disc of 2 x the arena radius (arena = half the distance between the two border lines) round the arena centre; every prop origin is inside it
      if (!d.crop || Math.abs(d.crop.r - 2 * d.crop.arena) > 0.01) bad(`scene ${name}: crop radius ${d.crop && d.crop.r} is not 2 x the arena radius ${d.crop && d.crop.arena}`);
      else for (const [q, ins] of d.inst.entries()) if (Math.hypot(ins[4] - d.crop.x, ins[12] - d.crop.z) > d.crop.r + 0.01) bad(`scene ${name}: instance ${q} is outside the crop disc`);
      if (name === "M108" && (d.inst.length !== 17 || d.meshes.length !== 7 || Math.abs(d.crop.arena - 14.43) > 0.05)) bad(`scene M108: ${d.inst.length} props / ${d.meshes.length} meshes, arena radius ${d.crop.arena}; expected 17 / 7 / 14.43 (the visible static props inside 2 x the arena radius; the two border-line props are left out on purpose)`);
    }
    if (!scenes) bad("no REACH_SCENES entries found");
  }
  if (reachBacklog) console.log(`[REACH BACKLOG] ${reachBacklog} cards still state their reach in the desc.` + (process.argv.includes("--list-reach-backlog") ? " " + reachBacklogIds.join(", ") : ""));
  console.log(`Verified ${checkedReach} reach parts.`);
}
// Popup lag guard (user 2026-10-14): a full-viewport backdrop-filter re-blurs the whole page behind it every frame while the popup animates in,
// which made the server-balance popup and the Buff / Debuff panel lag very hard. Overlays dim with a plain rgba background instead.
// The only allowed backdrop-filter is the theme variable (default none).
{
  let blurHits = 0;
  for (const m of html.matchAll(/(?:^|[;{\s"'])(?:-webkit-)?backdrop-filter\s*:\s*([^;}"']+)/g)) {
    const v = m[1].trim();
    if (v === "none" || v.startsWith("var(--th-blur")) continue;
    console.error(`[PERF ERROR] backdrop-filter '${v}' near char ${m.index}: overlays must not blur the page behind them (see bible-skill-page-ui "Popup performance").`);
    errorCount++; blurHits++;
  }
  if (!blurHits) console.log("Verified no popup backdrop-filter blur.");
}
// Font ban (user 2026-10-18: "Prompt looks better in all places"): the angular Chakra Petch was replaced by Prompt everywhere and must not come back.
// Old changelog entries ("[<ISO date>", ...) may still name it; they are history.
{
  const fontHits = html.split(/\r?\n/).filter(ln => !/^\s*\["\d{4}-\d\d-\d\dT/.test(ln) && /Chakra[ +]Petch/i.test(ln));
  for (const ln of fontHits) { console.error(`[FONT BAN ERROR] Chakra Petch is banned, use Prompt (12t_projects/bible/CLAUDE.md §2): ${ln.trim().slice(0, 140)}`); errorCount++; }
  if (!fontHits.length) console.log("Verified no Chakra Petch (font ban).");
}
// Two fonts only (user 2026-10-18): every font list in the hub (CSS, inline styles, SVG font-family, canvas fonts) starts with Prompt
// (text) or JetBrains Mono with Prompt behind it (numbers, so Thai inside stays Prompt instead of Tahoma), with only generic fallbacks
// after it, and Google Fonts loads only those two families. fontProblems(text) lists what breaks that in one page.
function fontProblems(html) {
  const ALLOWED = new Set(["prompt", "jetbrains mono", "sans-serif", "monospace"]);
  const ITEM = String.raw`(?:'[^'\n]*'|"[^"\n]*"|(?!(?:px|em|rem|vw|vh)\b)-?[A-Za-z][\w-]*(?:[ \t]+-?[A-Za-z][\w-]*)*)`;
  const LIST = new RegExp(`(?<![\\w.%-])${ITEM}(?:[ \\t]*,[ \\t]*${ITEM})*`, "g");
  const TRIGGER = /font-family\s*:\s*|font-family="|(?<![\w-])font\s*:\s*|\.font\s*=\s*["'`]|const FONT = "/g;
  const bad = [];
  html.split(/\r?\n/).forEach((ln, i) => {
    if (ln.length > 6000 || !/font/i.test(ln) || /^\s*\["\d{4}-\d\d-\d\dT/.test(ln)) return;
    for (const t of ln.matchAll(TRIGGER)) {
      const from = t.index + t[0].length, seg = ln.slice(from, from + ln.slice(from).search(/[;}]|$/));
      let hit = null;
      for (const m of seg.matchAll(LIST)) { if (m[0].includes(",") || (/font-family/.test(t[0]) && m.index === 0 && /^(monospace|sans-serif|serif|system-ui)$/i.test(m[0]))) { hit = m[0]; break; } }
      if (!hit) continue;
      const fams = hit.split(/[ \t]*,[ \t]*/).map(x => x.replace(/^['"]|['"]$/g, "").trim().toLowerCase());
      const ok = (fams[0] === "prompt" || (fams[0] === "jetbrains mono" && fams.includes("prompt"))) && fams.every(f => ALLOWED.has(f));
      if (!ok) bad.push(`line ${i + 1}: ${hit}`);
    }
  });
  const link = (html.match(/fonts\.googleapis\.com\/css2\?[^"']*/) || [""])[0];
  const loaded = [...link.matchAll(/family=([^:&]+)/g)].map(m => m[1].replace(/\+/g, " "));
  if (loaded.join(",") !== "Prompt,JetBrains Mono") bad.push(`Google Fonts loads ${loaded.join(", ") || "nothing"}`);
  return bad;
}
{
  const bad = fontProblems(html);
  for (const b of bad) { console.error(`[FONT ERROR] two fonts only: Prompt for text, 'JetBrains Mono','Prompt',monospace for numbers (12t_projects/bible/CLAUDE.md §2): ${b.slice(0, 160)}`); errorCount++; }
  if (!bad.length) console.log("Verified two fonts only (Prompt; JetBrains Mono with Prompt behind it).");
}
// The hub bar (user 2026-10-23): no line under it on any page (no bottom border, no gold ::after), and the Discord note as big as the menu's
// thanks line that replaces it there (12.5 px, 15 / 17 px at the big-screen steps)
{
  const fail = (m) => { console.error("[HUB BAR ERROR] " + m); errorCount++; };
  const bar = (html.match(/\n  \.hub-bar\{[^}]*\}/) || [""])[0], note = (html.match(/\n  \.hub-note\{[^}]*\}/) || [""])[0];
  if (!bar || /border-bottom/.test(bar) || /\.hub-bar::after/.test(html) || /hub-bar\{[^}]*border-bottom/.test(html)) fail("the hub bar must have no bottom border and no ::after line on any page (user 2026-10-23)");
  else if (!/font-size:12\.5px;/.test(note) || /opacity/.test(note) || !/\{ \.hub-note\{font-size:15px\} \}/.test(html) || !/\{ \.hub-note\{font-size:17px\} \}/.test(html)) fail("the Discord note must be 12.5 px (15 / 17 px on big screens), the size of the menu's thanks line, and not dimmed (no opacity)");
  else console.log("Verified the hub bar: no divider, Discord note at the thanks line's size.");
}
// The Final box's Test bar (user 2026-10-23): it covers the box's own borders (2 px gold accent left, 1 px right and bottom), so its corners are
// the box's corners; inside the borders the accent ran down beside it and left a step at the corner
{
  const desk = /\.sk-dmg-final\.has-test-bar \.sk-dmg-final-controls\{align-self:stretch; margin:auto -15px -1px -16px;/.test(html), compact = /\.sk-dmg-final\.has-test-bar \.sk-dmg-final-controls\{margin:auto -11px -1px -12px;/.test(html);
  const radius = /\.sk-dmg-final\.has-test-bar \.sk-dmg-final-controls > \.sk-simulate-btn\{position:relative; border-radius:0 0 3px 3px;/.test(html);
  if (!desk || !compact || !radius) { console.error("[FINAL BAR ERROR] the Test bar must cover the Final box's borders (margins auto -15px -1px -16px, compact auto -11px -1px -12px) with the box's 3 px corners"); errorCount++; }
  else console.log("Verified the Final box's Test bar covers the box's borders.");
}
// The light balls' direction (user 2026-10-23: Auto Gyro Gun's Heavy Built 2 -> 0, then 0 -> 1 before it settled, flew the wrong way):
// deltaValue reads a field's number for better / worse, and a held or rolling field carries its old value (.sk-roll-old) and a tint copy
// (.sk-roll-tint) beside the new one, so every branch (stat chip, summon stat row, KO badge, cost badge) must read the new value alone.
// Run on a small fake DOM: the page's own deltaValue, lifted out of mountSkillCooldownLookup.
{
  const fail = (m) => { console.error("[DELTA ERROR] " + m); errorCount++; };
  const srcFn = (html.match(/\n    function deltaValue\(el\)\{[\s\S]*?\n    \}\r?\n/) || [""])[0];
  if (!srcFn) fail("function deltaValue(el) not found");
  else {
    const classesOf = (n) => n.cls || [];
    const matchOne = (n, s) => { s = s.trim(); if (s === "img[alt]") return n.tag === "IMG" && n.alt !== undefined; return s.startsWith(".") && classesOf(n).includes(s.slice(1)); };
    const matches = (n, sel) => sel.split(",").some((s) => matchOne(n, s));
    const mk = (tag, cls, kids = [], text = "") => {
      const n = { tag, cls, kids, text, parent: null,
        matches(sel) { return matches(this, sel); },
        closest(sel) { for (let e = this; e; e = e.parent) if (e.matches && e.matches(sel)) return e; return null; },
        querySelectorAll(sel) { const out = []; const walk = (e) => e.kids.forEach((k) => { if (k.matches(sel)) out.push(k); walk(k); }); walk(this); return out; },
        querySelector(sel) { return this.querySelectorAll(sel)[0] || null; },
        cloneNode() { const c = mk(this.tag, this.cls.slice(), this.kids.map((k) => k.cloneNode()), this.text); if (this.alt !== undefined) c.alt = this.alt; return c; },
        remove() { if (this.parent) this.parent.kids = this.parent.kids.filter((k) => k !== this); },
        replaceWith(t) { if (this.parent) this.parent.kids = this.parent.kids.map((k) => k === this ? mk("#text", [], [], String(t)) : k); },
        get textContent() { return this.text + this.kids.map((k) => k.textContent).join(""); } };
      kids.forEach((k) => { k.parent = n; });
      return n;
    };
    // a value mid-change: the held old value and a tint copy beside the new one (rollHold / rollPlay)
    const rolling = (cls, oldV, newV) => mk("SPAN", [cls, "sk-roll-host"], [mk("SPAN", ["sk-roll-old"], [mk("SPAN", ["sk-roll-in"], [], oldV)]), mk("SPAN", ["sk-roll-new"], [], newV), mk("SPAN", ["sk-roll-tint"], [mk("SPAN", ["sk-roll-in"], [], newV)])]);
    let deltaValue = null;
    try { deltaValue = new Function(srcFn + "\nreturn deltaValue;")(); } catch (e) { fail("deltaValue does not compile on its own: " + e.message); }
    if (deltaValue) {
      const nums = (t) => (String(t).replace(/,/g, "").match(/\d+(?:\.\d+)?/g) || []).map(Number);
      const cases = [
        ["summon stat row (Auto Gyro Gun HP 400 -> 200)", mk("DIV", ["sk-summon-stat", "sk-summon-stat-mhp"], [mk("SPAN", ["sk-summon-stat-label"], [], "HP"), rolling("sk-summon-stat-value", "400", "200")]), [200]],
        ["stat chip (cooldown 30s -> 20s)", mk("DIV", ["sk-stat", "sk-stat-cd"], [mk("P", ["sk-stat-label"], [], "คูลดาวน์"), rolling("sk-stat-value", "30s", "20s")]), [20]],
        ["KO badge", mk("SPAN", ["sk-ko-badge"], [mk("SPAN", ["sk-ko-label"], [], "KO"), rolling("sk-ko-value", "10", "5")]), [5]],
        ["cost badge", mk("SPAN", ["sk-cost-badge"], [rolling("sk-cost-num", "45", "30")]), [30]],
      ];
      const bad = cases.filter(([, el, want]) => { try { return JSON.stringify(nums(deltaValue(el))) !== JSON.stringify(want); } catch (e) { return true; } });
      if (bad.length) fail("deltaValue must read only the new value of a field mid-change (no .sk-roll-old / .sk-roll-tint): " + bad.map(([name, el, want]) => `${name} read ${JSON.stringify((() => { try { return deltaValue(el); } catch (e) { return e.message; } })())}, want ${want}`).join("; "));
      else console.log("Verified the light balls read each field's new value only (stat chip, summon stat row, KO badge, cost badge mid-change).");
    }
  }
}
// The exported guide PNG's tree names (user 2026-10-24): a long name ("Alchemist Doctor") ran into its learned/total count because the export drew
// every name at a fixed 22 px. classGuideImageFitName shrinks it to fit (the page's fitTreeNames, 8 px floor), and the export must use it.
{
  const fail = (m) => { console.error("[PNG TREE NAME ERROR] " + m); errorCount++; };
  let fit = null;
  try { fit = vm.runInContext("classGuideImageFitName", sandbox); } catch (e) { fail("classGuideImageFitName is missing"); }
  if (fit) {
    const w = (n) => (px) => n * px * 0.55;   // a fake font: width grows with the size
    const cases = [
      ["fits at full size", fit(w(10), 200, 22), 22],
      ["a long name shrinks until it fits", fit(w(20), 200, 22), 18],
      ["never below the 8 px floor", fit(w(200), 50, 22), 8],
    ];
    const bad = cases.filter(([, got, want]) => got !== want);
    const stillWide = w(20)(fit(w(20), 200, 22)) > 200;
    if (bad.length || stillWide) fail("classGuideImageFitName: " + bad.map(([n, got, want]) => `${n}: got ${got}, want ${want}`).join("; ") + (stillWide ? "; the fitted name is still wider than the room" : ""));
    else if (!/classGuideImageFitName\(px => \{ ctx\.font = font\(600, px\); return ctx\.measureText\(t\.name\)\.width; \}, t\.x \+ t\.w - 4 - cw - 10 - nameX - 10 - 24, 22\)/.test(html)
      || /ctx\.font = font\(600, 22\); ctx\.fillStyle = text; ctx\.fillText\(t\.name/.test(html)) fail("the export must draw each tree name through classGuideImageFitName (room = column width less the count, gaps and a short rule), not at a fixed 22 px");
    else console.log("Verified the exported guide image shrinks a long tree name to fit beside its count.");
  }
}
// Damage modes (user 2026-10-23): a dmgModes card (Planet Breaker's inner / outer ring, never both in one pulse) shows one complete damage row
// per mode, labelled with the mode, whose Test bar rolls that group (simulate-group); every Test of a mode lands inside its own row's Final.
// (The range-vs-simulator sweep skips dmgModes cards, so this is their check.)
{
  const fail = (m) => { console.error("[MODE ROWS ERROR] " + m); errorCount++; };
  const modeCards = SKILLS.filter((s) => s.dmgModes && s.dmgGroups);
  const nums = (t) => (String(t).replace(/<span class="sk-range-sep">~<\/span>/g, "~").replace(/<[^>]+>/g, "").replace(/,/g, "").match(/\d+(?:\.\d+)?/g) || []).map(Number);
  let rowsChecked = 0;
  modeCards.forEach((card) => ["og", "tot", "tto"].forEach((srv) => {
    const over = srv === "og" ? null : card.servers && card.servers[srv];
    if (srv !== "og" && !over) return;
    const sk = over ? Object.assign({}, card, over) : card, other = SKILLS.find((s) => s.class === card.class && s.id !== card.id);
    sandbox._setServer(srv);
    sandbox._selectSkill(other); sandbox._selectSkill(card);
    const rows = sandbox._getRenderedHeroHtml().split('<div class="sk-dmg-row">').slice(1);
    const rank = card.maxRank;
    if (rows.length !== sk.dmgGroups.length) { fail(`${card.id}@${srv}: ${rows.length} damage rows for ${sk.dmgGroups.length} modes`); return; }
    rows.forEach((row, gi) => {
      const g = sk.dmgGroups[gi], label = typeof g.label === "function" ? g.label(rank) : g.label;
      const fin = (row.match(/sk-dmg-final[\s\S]*?<div class="sk-stat-value[^"]*">([\s\S]*?)<\/div>/) || [])[1];
      const [lo, hi] = (() => { const v = nums(fin); return [v[0], v.length > 1 ? v[1] : v[0]]; })();
      if (!row.includes(`<span class="sk-dmg-mode-label">${label}</span>`)) fail(`${card.id}@${srv} row ${gi + 1}: no mode label "${label}"`);
      if (!row.includes(`data-role="simulate-group" data-group-index="${gi}"`) || row.includes('data-role="simulate-hit"')) fail(`${card.id}@${srv} row ${gi + 1}: its Test bar must roll group ${gi} (simulate-group)`);
      if (!(lo >= 0) || !(hi >= lo)) { fail(`${card.id}@${srv} row ${gi + 1}: no Final range read (${JSON.stringify(fin)})`); return; }
      const hc = typeof g.hitCount === "function" ? g.hitCount(rank) : g.hitCount;
      let mn = Infinity, mx = -Infinity;
      for (let n = 0; n < 600; n++) {
        let sum = 0;
        for (let h = 0; h < hc; h++) sum += sandbox._rollOneHit(sk, rank, h, false, gi);
        mn = Math.min(mn, sum); mx = Math.max(mx, sum);
      }
      if (mn < lo || mx > hi) fail(`${card.id}@${srv} row ${gi + 1} (${label}): Test totals ${mn}~${mx} fall outside the row's Final ${lo}~${hi}`);
      rowsChecked++;
    });
  }));
  sandbox._setServer("og");
  if (!modeCards.length) console.log("No dmgModes cards to check.");
  else console.log(`Verified ${rowsChecked} damage-mode rows (one per mode, labelled, own Test, every Test total inside its row's Final).`);
}
// No reduced-motion gates (user 2026-10-13: "bypass all reduced motion"; 12t_projects/bible/CLAUDE.md §2): every animation plays whatever
// prefers-reduced-motion says, so no @media rule and no matchMedia check for it (prose comments may still name it).
{
  const hits = html.split(/\r?\n/).filter((ln) => /@media[^{]*prefers-reduced-motion|matchMedia\(\s*["'`][^"'`]*prefers-reduced-motion/.test(ln));
  for (const ln of hits) { console.error(`[MOTION ERROR] no reduced-motion gates (12t_projects/bible/CLAUDE.md §2): ${ln.trim().slice(0, 140)}`); errorCount++; }
  if (!hits.length) console.log("Verified no reduced-motion gates.");
}
// แท็บกีตาร์เพลงธีม (theme-tab, user 2026-10-23): jumpfingerstyle's PDF of the main theme, note for note. The pin catches any change to the
// tempo, capo, chord shapes or a bar; change it only for a deliberate correction against the PDF.
{
  const THEME_TAB_PIN = "178b886e13dad1991561f8dd32f8e023b663083c0a766cbb4c14a93981ea207e";
  let n = 0;
  const ok = (pass, msg) => { if (pass) n++; else { console.error("[THEME TAB ERROR] " + msg); errorCount++; } };
  const page = (name) => vm.runInContext(name, sandbox), kind = (name) => { try { return vm.runInContext("typeof " + name, sandbox); } catch (e) { return "undefined"; } };
  const same = (a, b) => JSON.stringify(a) === JSON.stringify(b);
  const names = ["THEME_TAB", "themeTabParse", "themeTabRhythm", "themeTabRinging", "themeTabMidi", "themeTabPluck", "themeTabDiagram", "mountThemeTab"];
  const missing = names.filter((x) => kind(x) === "undefined");
  ok(!missing.length, "missing from the main script: " + missing.join(", "));
  if (!missing.length) {
    const T = page("THEME_TAB"), hash = require("crypto").createHash("sha256").update(JSON.stringify({ tempo: T.tempo, capo: T.capo, shapes: T.shapes, bars: T.bars })).digest("hex");
    ok(hash === THEME_TAB_PIN, `THEME_TAB changed (sha256 ${hash}): the tab must stay jumpfingerstyle's PDF note for note; update THEME_TAB_PIN only for a deliberate fix against the PDF`);
    ok(T.tempo === 75 && T.capo === 2 && T.title === "12 Tails Online Main Theme" && T.arranger === "jumpfingerstyle", "THEME_TAB's tempo 75, capo 2, title and arranger");
    let song = null;
    try { song = page("themeTabParse")(T); } catch (e) { ok(false, "themeTabParse threw: " + e.message); }
    if (song) {
      const lens = song.bars.map((b) => b.len);
      ok(song.bars.length === 45 && lens.slice(0, 44).every((l) => l === 12) && lens[44] === 6 && song.total === 534, `45 bars of 6/8 (12 sixteenths), the last a held dotted quarter (got ${song.bars.length} bars, lengths ${[...new Set(lens)].join("/")})`);
      const bad = song.beats.filter((b) => !b.notes.length || b.notes.some((x) => x.s < 1 || x.s > 6 || x.f < 0 || x.f > 12) || new Set(b.notes.map((x) => x.s)).size !== b.notes.length || ![1, 2, 3, 4, 6].includes(b.dur));
      ok(!bad.length, "every beat has notes on strings 1-6, frets 0-12, one note a string, and a length of 1, 2, 3, 4 or 6 sixteenths (bad: " + bad.slice(0, 3).map((b) => "bar " + (b.bar + 1)).join(", ") + ")");
      const slurs = song.beats.filter((b) => b.slur);
      ok(slurs.length === 11 && slurs.every((b) => b.notes.length === 1 && b.at > 0 && song.beats[b.i - 1].notes.some((x) => x.s === b.notes[0].s)) && slurs.filter((b) => b.slur === "p").length === 1,
        `11 slurs (10 H, 1 P), each one note on the string of the beat before it in the same bar (got ${slurs.length})`);
      ok(Object.values(T.shapes).every((s) => /^[x\d]{6}$/.test(s)) && song.beats.every((b) => T.shapes[b.chord]), "every chord in the bars has a 6-string shape");
      const midi = page("themeTabMidi");
      ok(midi(6, 0) === 42 && midi(1, 0) === 66 && midi(5, 3) === 50 && midi(2, 1) === 62, "themeTabMidi: standard tuning plus the capo on fret 2 (6th string open = F#2, MIDI 42)");
      const rh = page("themeTabRhythm"), marks = (bar) => rh(song.bars[bar - 1].beats);
      const pick = (bar, key) => marks(bar).map((m) => m[key]);
      ok(same(pick(12, "beams"), [1, 1, 1, 1, 2, 2, 2]) && same(pick(12, "dot"), [false, false, false, true, false, false, false]) && same(pick(19, "beams"), [2, 2, 1, 1, 1, 1, 1])
        && same(pick(13, "flags"), [0, 1, 0, 0, 0]) && same(pick(29, "flags"), [0, 1, 0, 1]) && same(pick(8, "dot"), [false, false, false, true]) && same(pick(8, "beams"), [1, 1, 1, 0]),
        "themeTabRhythm draws the PDF's beams, flags and dots (bars 8, 12, 13, 19, 29)");
      const g6 = song.bars[5].beats[0].i, ring = page("themeTabRinging")(song.beats, g6);
      ok(same(Object.keys(ring).map(Number).sort(), [1, 2, 3, 6]) && Object.values(ring).every((r) => r.now), "themeTabRinging: the G chord of bar 6 damps the C before it (strings 1, 2, 3, 6 only)");
      const dF = page("themeTabDiagram")(T.shapes.F), dC = page("themeTabDiagram")(T.shapes.C), dGs = page("themeTabDiagram")(T.shapes["G#"]);
      ok(/<rect class="tt-dg-dot"/.test(dF) && !/<rect class="tt-dg-dot"/.test(dC) && (dGs.match(/tt-dg-x/g) || []).length === 4 && (dC.match(/tt-dg-o/g) || []).length === 2, "themeTabDiagram: a bar for F, none for C; 4 × on G♯, 2 ○ on C");
      // the synth is in tune: the pitch of a rendered A3 (220 Hz), by autocorrelation with a parabolic peak, within 3 cents
      const fake = { createBuffer: (c, len, sr) => { const d = new Float32Array(len); return { sampleRate: sr, getChannelData: () => d, d }; } };
      const buf = page("themeTabPluck")(fake, 57), d = buf.d, sr = buf.sampleRate, lag0 = sr / 220, a0 = Math.round(sr * 0.3), win = 4000;
      const ac = (L) => { let s = 0; for (let i = 0; i < win; i++) s += d[a0 + i] * d[a0 + i + L]; return s; };
      let best = Math.round(lag0); for (let L = Math.round(lag0) - 3; L <= Math.round(lag0) + 3; L++) if (ac(L) > ac(best)) best = L;
      const y1 = ac(best - 1), y2 = ac(best), y3 = ac(best + 1), lag = best + 0.5 * (y1 - y3) / (y1 - 2 * y2 + y3), cents = 1200 * Math.log2(lag0 / lag);
      let peak = 0; for (const v of d) peak = Math.max(peak, Math.abs(v));
      ok(Math.abs(cents) < 3 && Math.abs(peak - 0.5) < 0.01, `themeTabPluck: A3 sounds ${cents.toFixed(2)} cents off 220 Hz (max 3), peak ${peak.toFixed(3)} (0.5)`);
    }
    // the sound (user 2026-10-23): chords roll from the thick string to the thin one, THEME_TAB_ROLL apart, and the roll ends on the beat
    // (with the bass on the beat the melody came up to 75 ms late: "off tempo"); one shared voice (themeTabVoice) for the tab and the music
    const roll = kind("THEME_TAB_ROLL") === "number" ? page("THEME_TAB_ROLL") : -1, ahead = kind("THEME_TAB_AHEAD") === "number" ? page("THEME_TAB_AHEAD") : -1;
    ok(roll > 0 && roll <= 0.012 && /lead = \(n - 1\) \* THEME_TAB_ROLL \/ 2;/.test(html) && /notes\.forEach\(\(x, k\) => strike\(x, at - lead \+ k \* THEME_TAB_ROLL, !!b\.slur, themeTabWeight\(n, k\)\)\)/.test(html),
      `notes struck together roll from the 6th string to the 1st, THEME_TAB_ROLL apart, centred on the beat and too short to hear as timing (user 2026-10-23, option 2: at most 12 ms; got ${roll}), each weighted by themeTabWeight`);
    ok(ahead >= 0.3 && ahead <= 1.5 && (html.match(/if \((S|M)\.time < now\) \1\.time = now \+ 0\.1;/g) || []).length === 2 && /voice\.play\(b, S\.time\);/.test(html) && /M\.voice\.play\(b, M\.time\);/.test(html),
      `both players schedule THEME_TAB_AHEAD ahead (0.3-1.5 s; got ${ahead}) through the shared voice and pick up from now after a stall`);
    // chord loudness (user 2026-10-23): first 1/√n a note (chords sounded forceful), then 1/n^¼ with the harp voice (too quiet), the lowest a
    // touch above; a gentle compressor; each player's volume (0-100, squared to a gain) feeds its guitar, room and metronome through out
    if (kind("themeTabWeight") === "function" && kind("themeTabVolume") === "function") {
      const w = page("themeTabWeight"), v = page("themeTabVolume"), near = (a, b) => Math.abs(a - b) < 1e-9;
      ok(w(1, 0) === 1 && near(w(4, 1), Math.pow(4, -0.25)) && near(w(2, 1), Math.pow(2, -0.25)) && w(4, 0) > w(4, 1) && w(4, 0) < 1 && near(v(0), 0) && v(100) > v(80) && near(v(50) / v(100), 0.25),
        "themeTabWeight (1/n^¼ a note, the lowest a little louder) and themeTabVolume (0 = silent, squared)");
    } else ok(false, "themeTabWeight / themeTabVolume are missing");
    ok(/data-role="vol" aria-label="ระดับเสียง"/.test(html) && /ctx\.createDynamicsCompressor\(\)/.test(html) && /V\.volume = \(v\) => out\.gain\.setTargetAtTime\(themeTabVolume\(v\)/.test(html)
      && /if \(voice\) voice\.volume\(opt\.vol\);/.test(html) && /g\.connect\(out\); o\.start\(at\)/.test(html),
      "the tab's volume slider (ระดับเสียง) sets its voice's out, which its guitar, room and metronome all go through; the chain has a compressor");
    // the hub bar's music button (user 2026-10-23): by the logo, muted on every visit (nothing starts it but a click or the slider), 30 % the
    // first time, the volume remembered; a hover / focus slider; the music and the tab never play together; hidden page = paused
    const hubMusic = (html.match(/<a href="#" class="brand"[^\n]*\r?\n\s*<div class="hub-music" id="hubMusic">[^\n]*<\/div><\/div>/) || [""])[0];
    ok(/<button type="button" class="hub-music-btn" aria-pressed="false" aria-label="เปิดเพลงธีม"/.test(hubMusic) && /class="hub-music-range" min="0" max="100" step="5" value="0" aria-label="ระดับเสียงเพลงธีม"/.test(hubMusic),
      "the music button and its slider sit right after the logo in the hub bar, muted in the markup");
    if (kind("mountThemeMusic") === "function") {
      const src = String(page("mountThemeMusic"));
      ok(/vol: 30,/.test(src) && page("THEME_MUSIC_KEY") === "12t-bible-music-vol" && !/start\(\);\s*\r?\n\s*paint\(\);\s*\r?\n\s*return M;/.test(src) && /paint\(\);\s*\r?\n\s*return M;/.test(src)
        && /detail: "music"/.test(src) && /if \(e\.detail !== "music"\)\{ M\.resume = false; stop\(\); \}/.test(src)
        && /\.hub-music:hover \.hub-music-pop, \.hub-music:focus-within \.hub-music-pop, \.hub-music\.is-open \.hub-music-pop\{/.test(html) && /^mountThemeMusic\(\$\("#hubMusic"\)\);/m.test(html)
        && /document\.addEventListener\("theme-audio", \(e\) => \{ if \(e\.detail !== "tab"\) pause\(\); \}\);/.test(html) && /detail: "tab" \}\)\);/.test(html),
        "mountThemeMusic: 30 % by default (12t-bible-music-vol), muted until clicked, a hover / focus / tap slider, never playing with the tab player");
      // both keep playing when the window is not focused (user 2026-10-23): no pause on a hidden page, and a 2.5 s look-ahead while hidden
      // (timers fire about once a second there); 90 % of the PDF's 75 is the 100 % (67.5), the sheet data keeps 75
      ok(!/visibilitychange/.test(src) && !/addEventListener\("visibilitychange", \(\) => \{ if \(document\.hidden\) pause\(\); \}\)/.test(html)
        && (html.match(/horizon = now \+ themeTabAhead\(\);/g) || []).length === 2 && /const themeTabAhead = \(\) => typeof document !== "undefined" && document\.hidden \? 2\.5 : THEME_TAB_AHEAD;/.test(html),
        "the tab and the music keep playing on a hidden page (no visibilitychange pause) and schedule 2.5 s ahead while hidden");
      ok(page("THEME_TAB_BPM") === 67.5 && page("themeTabBpmText")(67.5) === "67.5" && /const sixteenth = \(\) => 60 \/ \(THEME_TAB_BPM \* opt\.speed \/ 100\) \/ 4;/.test(html) && /const six = 60 \/ THEME_TAB_BPM \/ 4,/.test(html)
        && /saved\.v === 2 \? 1 : 0\.9/.test(html),
        "the playback tempo at 100 % is 67.5 (90 % of the PDF's 75) for the tab and the music, and a speed saved before is rescaled once");
      const M = page("mountThemeMusic")(makeEl());   // on stubs: mounts muted, nothing scheduled
      ok(M && M.on === false && M.vol === 30 && M.voice === null, "mountThemeMusic mounts muted at 30 % with no sound made");
    } else ok(false, "mountThemeMusic is missing");
    ok(/Math\.sin\(h \* Math\.PI \* 0\.3\)/.test(String(page("themeTabPluck"))) && /shelf\.type = "highshelf"/.test(html) && /wet\.gain\.value = 0\.3;/.test(html) && /Math\.round\(sr \* 2\.5\), pre = /.test(html),
      "the harp / music box voice (sine partials of a string plucked 30 % along; user 2026-10-23, preset 5) and its room (2.5 s, wet 0.3) are kept");
    const tool = page("TOOLS").find((t) => t.id === "theme-tab"), gi = page("GEAR_INDEX");
    ok(tool && tool.category === "Music" && page("LAUNCH_CATEGORY").Music === "ดนตรี" && tool.title === "แท็บกีตาร์เพลงธีม" && same(tool.fact(), [45, "ห้อง"]) && tool.collage === "tabRun" && !tool.art,
      "TOOLS has theme-tab (แท็บกีตาร์เพลงธีม, category Music = ดนตรี, fact 45 ห้อง, menu art LN_ART.tabRun)");
    // the menu art (user 2026-10-23: running guitar tablature): the stage runs two copies (white digits, gold digits clipped to the playhead)
    // at the playback tempo, 8 bars of 520 units in 21.33 s (67.5 bpm); the thumb is a still; ids carry the mode
    try {
      const art = page("LN_ART"), st = art.tabRun("stage"), th = art.tabRun("thumb");
      ok((st.match(/class="ln-tabrun-move" style="--run:-4160px;animation-duration:21\.33s"/g) || []).length === 2 && !/ln-tabrun-move/.test(th) && /id="stmask"/.test(st) && /id="ttmask"/.test(th)
        && /clip-path="url\(#stlens\)"/.test(st) && /@keyframes lnTabRun\{to\{transform:translateX\(var\(--run\)\)\}\}/.test(html),
        "LN_ART.tabRun: the stage runs two synced copies (white, and gold under the playhead) 4160 units in 21.33 s; the thumb is still; mask / clip ids carry the mode");
    } catch (e) { ok(false, "LN_ART.tabRun threw: " + e.message); }
    ok(/classList\.toggle\("tool-tab", tool\.id === "theme-tab"\)/.test(html) && /html\.tool-tab \.stage\{/.test(html), "showTool sets html.tool-tab for the tab's wide stage");
    const panel = (html.match(/\n\s*panel: \[([^\]]*)\]/) || [])[1] || "", raised = (html.match(/\n\s*raised: \[([^\]]*)\]/) || [])[1] || "";
    ok([".tt-bar", ".tt-sheet", ".tt-fret"].every((x) => panel.includes(JSON.stringify(x))) && raised.includes('".tt-btn:not(.is-on):not(.tt-play)"'), "the tab's panels and buttons are in THEME_SURFACES");
    // it mounts on stubs (no width yet, no storage) and builds its nine chord diagrams
    try {
      const root = makeEl(); page("mountThemeTab")(root);
      ok((root.innerHTML.match(/class="tt-chord"/g) || []).length === 9 && root._themeTab && typeof root._themeTab.play === "function", "mountThemeTab builds the page with 9 chord diagrams and exposes _themeTab");
    } catch (e) { ok(false, "mountThemeTab threw on stubs: " + e.message); }
  }
  console.log(`Verified ${n} guitar tab checks (the PDF pin, bars, rhythm marks, slurs, shapes, capo pitches, synth tuning, tool wiring).`);
}
// Guide manager page (user 2026-10-20): the same page runs on this PC (scripts/add_guide.js serves it) and on the phone (GitHub Pages).
// Its class faces are a copy of CLASS_HERO_ICONS (the phone never loads the 27 MB assets.js), so a repainted portrait must be copied there too.
// It may talk only to its own server and api.github.com, and asks search engines to stay away.
const GM_REL = "12t_projects/guide-manager/index.html", gmPath = path.join(repoRoot, GM_REL);
const gmHtml = fs.existsSync(gmPath) ? fs.readFileSync(gmPath, "utf8") : null;
{
  let gmBad = 0;
  const bad = (msg) => { console.error(`[GUIDE MANAGER ERROR] ${msg}`); errorCount++; gmBad++; };
  if (gmHtml === null) bad(`${GM_REL} not found`);
  else {
    let faces = null; try { faces = JSON.parse((gmHtml.match(/^const FACES = (\{.*\});\r?$/m) || [])[1]); } catch (e) {}
    const hero = vm.runInContext("window.CLASS_HERO_ICONS", sandbox) || {};
    if (!faces) bad(`${GM_REL}: "const FACES = {…};" (one line) not found`);
    else if (Object.keys(faces).length !== Object.keys(hero).length || Object.keys(hero).some((k) => faces[k] !== hero[k])) bad(`${GM_REL}: FACES differ from CLASS_HERO_ICONS in assets.js; copy them again`);
    if (!/<meta http-equiv="Content-Security-Policy" content="[^"]*connect-src 'self' https:\/\/api\.github\.com[;"]/.test(gmHtml)) bad(`${GM_REL}: the Content-Security-Policy meta must limit connect-src to 'self' https://api.github.com`);
    if (!gmHtml.includes('<meta name="robots" content="noindex">')) bad(`${GM_REL}: <meta name="robots" content="noindex"> is missing`);
    for (const b of fontProblems(gmHtml)) bad(`${GM_REL}: two fonts only (Prompt; 'JetBrains Mono','Prompt',monospace for numbers): ${b.slice(0, 160)}`);
    if (!gmBad) console.log("Verified the guide manager page: class faces match assets.js, connections limited, not indexed, two fonts only.");
  }
}
// The page's own reading of guide codes and of CLASS_GUIDES (its "gm-core" script, used on the phone where there is no add_guide.js) must agree
// with scripts/guide_code.js and scripts/add_guide.js, and its reading of GitHub's run, job and annotation replies must give the right outcome.
if (gmHtml !== null) {
  let gmChecked = 0, gmFailed = 0;
  const ok = (pass, msg) => { if (pass) gmChecked++; else { console.error(`[GUIDE MANAGER ERROR] gm-core: ${msg}`); errorCount++; gmFailed++; } };
  const block = (gmHtml.match(/\/\/ gm-core start\r?\n([\s\S]*?)\/\/ gm-core end/) || [])[1];
  if (!block) ok(false, "gm-core block not found (between // gm-core start and // gm-core end)");
  else {
    const zlib = require("zlib"), gc = require(path.join(__dirname, "guide_code.js")), ag = require(path.join(__dirname, "add_guide.js"));
    const ctx = vm.createContext({ TextDecoder, atob, Blob, DecompressionStream, Response, crypto });
    vm.runInContext(block, ctx, { filename: GM_REL + " (gm-core)" });
    const gm = vm.runInContext("({ gmFindCode, gmUnpack, gmFinish, gmCheckGuide, gmSameGuide, gmParseGuides, gmSummary, gmPayloadFits, gmStepsFromJobs, gmRunOutcome, gmKeyProblem })", ctx);   // const functions are not properties of ctx
    const same = (a, b) => JSON.stringify(a) === JSON.stringify(b);
    const throws = (fn) => { try { fn(); return ""; } catch (e) { return String(e.message || e); } };
    const finish = (code) => { const u = gm.gmUnpack(code); return gm.gmFinish(u, u.deflated ? zlib.inflateRawSync(u.bytes) : u.bytes); };
    const doc = ag.readGuides();
    let decoded = 0;
    for (const { g } of doc.guides) {
      const { id, ...guide } = g;
      for (const enc of [gc.encode, gc.encode2, gc.encode1]) { const code = enc(guide); if (same(finish(code), gc.decode(code))) decoded++; else ok(false, `guide #${id}: the page reads ${code.slice(0, 12)}… differently from guide_code.js`); }
    }
    ok(decoded === doc.guides.length * 3, `${decoded} of ${doc.guides.length * 3} codes read the same as guide_code.js`);
    const { id: _id, ...first } = doc.guides[0].g, c3 = gc.encode(first), wrapped = "ไกด์ `" + c3.slice(0, 9) + " \n" + c3.slice(9) + "` จบ";
    ok(same(finish(gm.gmFindCode(wrapped)), gc.decode(c3)), "a TG3 code pasted with chat text, a space and a line break is found and read");
    const at = Math.floor(c3.length / 2), broken = c3.slice(0, at) + String.fromCharCode(c3.charCodeAt(at) ^ 1) + c3.slice(at + 1);   // a data character (the last ones may hold only padding bits)
    ok(/คัดลอกใหม่/.test(throws(() => gm.gmUnpack(broken))) && /คัดลอกใหม่/.test(throws(() => gc.decode(broken))), "a TG3 code with one changed character is refused with the copy-again message, as guide_code.js refuses it");
    for (const s of [wrapped, gc.encode2(first), gc.encode1(first), "no code here", ""]) ok(gm.gmFindCode(s) === ag.findCode(s), `gmFindCode and add_guide's findCode disagree on ${JSON.stringify(s.slice(0, 20))}`);
    const pg = gm.gmParseGuides(html);
    ok(same(pg.guides.map((x) => x.id), doc.guides.map((x) => x.g.id)) && same(pg.removed.map((x) => x.id), doc.removed.map((x) => x.id)) && pg.next === ag.nextId(doc), "gmParseGuides reads the same guides, removed numbers and next number as add_guide.js");
    ok(same(gm.gmParseGuides(html.replace(/\r\n/g, "\n")).guides.map((x) => x.id), doc.guides.map((x) => x.g.id)), "gmParseGuides reads an LF copy too");
    const views = vm.runInContext("CLASS_GUIDE_VIEWS", sandbox).counts || {}, g0 = doc.guides[0].g;
    ok(same(gm.gmSummary(pg.guides[0].g, pg.views), { id: g0.id, modes: g0.modes || [], title: g0.title, author: g0.author, classKey: g0.build.classKey, server: g0.build.server, level: g0.build.level, date: g0.date || "", views: views[g0.id] || 0 }), "gmSummary gives the list row add_guide.js gives");
    const stA = { id: 9, modes: ["pve"], date: "2026-10-23", published: "2026-10-22T17:59:00Z", title: "a", build: { x: 1 } }, stB = { title: "a", build: { x: 1 }, date: "2020-01-01", published: "2020-01-01T00:00:00Z" };
    ok(ag.sameGuide(stA, stB) && gm.gmSameGuide(stA, stB) && !ag.sameGuide(stA, { ...stB, title: "b" }) && !gm.gmSameGuide(stA, { ...stB, title: "b" }), "a replacement code is compared without the upload stamp (date, published), in add_guide.js and in the page");
    const box = (n) => ({ payload: "x".repeat(n - '{"payload":""}'.length) });
    ok(gm.gmPayloadFits(box(65535)) === true && gm.gmPayloadFits(box(65536)) === false, "gmPayloadFits: 65,535 characters fit, 65,536 do not");
    // GitHub's replies, shaped as the REST API returns them (GET /actions/runs/{id}/jobs, /actions/runs/{id}, /check-runs/{job}/annotations)
    const st = (name, status, conclusion = null) => ({ name, status, conclusion });
    const job = (steps, status = "in_progress") => ({ total_count: 1, jobs: [{ id: 7, status, steps }] });
    const pre = [st("Set up job", "completed", "success"), st("ส่งงานให้ GitHub", "completed", "success"), st("ส่งงานให้ GitHub", "completed", "success"), st("ตรวจสถานะ git", "completed", "success"), st("แก้ไฟล์ index.html", "completed", "success")];
    const rows = (...r) => r.map(([key, state]) => ({ key, text: { send: "ส่งงานให้ GitHub", git: "ตรวจสถานะ git", edit: "แก้ไฟล์ index.html", check: "ตรวจด้วย validator", commit: "commit", push: "อัปขึ้น GitHub" }[key], state }));
    ok(same(gm.gmStepsFromJobs({ total_count: 0, jobs: [] }), rows(["send", "run"])), "a queued run shows ส่งงานให้ GitHub running");
    // recorded from GitHub 2026-10-20: steps not started yet are "pending"; a run is "pending" then "queued" (no steps) before it starts
    ok(same(gm.gmStepsFromJobs({ total_count: 1, jobs: [{ id: 7, status: "queued", conclusion: null, steps: [] }] }), rows(["send", "run"])), "a queued job without steps shows ส่งงานให้ GitHub running");
    ok(same(gm.gmStepsFromJobs(job([st("Set up job", "completed", "success"), st("ส่งงานให้ GitHub", "in_progress"), st("ส่งงานให้ GitHub", "pending"), st("ตรวจสถานะ git", "pending"), st("ตรวจด้วย validator", "pending"), st("Post ส่งงานให้ GitHub", "pending")])), rows(["send", "run"])), "the two ส่งงานให้ GitHub steps are one row, running until both are done; pending steps not shown");
    ok(same(gm.gmStepsFromJobs(job([...pre, st("ตรวจด้วย validator", "in_progress"), st("commit", "pending"), st("อัปขึ้น GitHub", "pending"), st("Post ส่งงานให้ GitHub", "pending"), st("Complete job", "pending")])), rows(["send", "ok"], ["git", "ok"], ["edit", "ok"], ["check", "run"])), "mid-check: done rows ticked, the validator running, pending steps not shown yet");
    ok(same(gm.gmStepsFromJobs(job([...pre, st("ตรวจด้วย validator", "completed", "success"), st("commit", "completed", "skipped"), st("อัปขึ้น GitHub", "completed", "skipped"), st("Complete job", "completed", "success")], "completed")), rows(["send", "ok"], ["git", "ok"], ["edit", "ok"], ["check", "ok"])), "a dry run: the skipped commit and push are not shown");
    ok(same(gm.gmStepsFromJobs(job([...pre, st("ตรวจด้วย validator", "completed", "failure"), st("commit", "completed", "skipped"), st("อัปขึ้น GitHub", "completed", "skipped")], "completed")), rows(["send", "ok"], ["git", "ok"], ["edit", "ok"], ["check", "fail"])), "a failed validator step shows as failed");
    const SITE = "https://jumpptty.github.io/12tails/12t_projects/bible/", run = (status, conclusion) => ({ status, conclusion, html_url: "https://github.com/jumpptty/12tails/actions/runs/1" });
    const ann = (title, message) => ({ path: ".github", annotation_level: title === "gm-error" ? "failure" : "notice", title, message });
    const result = { ok: true, dry: true, subject: "feat(bible): class guide #54 ToT Wolf T by A", sha: null, items: [{ action: "add", id: 54 }], undoText: null };
    ok(gm.gmRunOutcome(run("in_progress", null), [], SITE) === null, "no outcome while the run is going");
    ok(same(gm.gmRunOutcome(run("completed", "success"), [ann("Node.js 20 actions are deprecated", "x"), ann("gm-result", JSON.stringify(result))], SITE), { ok: true, dry: true, subject: result.subject, sha: null, undoText: null, items: [{ action: "add", id: 54, url: SITE + "#class-guide/54" }] }), "gm-result becomes the done message with guide links");
    ok(same(gm.gmRunOutcome(run("completed", "failure"), [ann("gm-error", "ไกด์ไม่ผ่านการตรวจ\n[CLASS GUIDE ERROR] a\n[CLASS GUIDE ERROR] b")], SITE), { ok: false, error: "ไกด์ไม่ผ่านการตรวจ", log: ["[CLASS GUIDE ERROR] a", "[CLASS GUIDE ERROR] b"] }), "gm-error becomes the error and the log lines");
    ok(same(gm.gmRunOutcome(run("completed", "cancelled"), [], SITE), { ok: false, error: "งานถูกยกเลิก (มีงานอื่นรออยู่บน GitHub) ลองอัปใหม่", runUrl: "https://github.com/jumpptty/12tails/actions/runs/1" }), "a cancelled run says so, with a link to it");
    // review 2026-10-20: a result note counts only from a run that succeeded; a finished run without a readable result says to check before publishing again
    const unsure = { ok: false, error: "งานบน GitHub จบแล้วแต่ไม่ได้รับผลลัพธ์ ตรวจใน GitHub ก่อนอัปซ้ำ", runUrl: "https://github.com/jumpptty/12tails/actions/runs/1", unsure: true };
    ok(same(gm.gmRunOutcome(run("completed", "failure"), [ann("gm-result", JSON.stringify(result)), ann("gm-error", "ไกด์ไม่ผ่านการตรวจ\n[X ERROR] y")], SITE), { ok: false, error: "ไกด์ไม่ผ่านการตรวจ", log: ["[X ERROR] y"] }), "a gm-result note from a failed run is not trusted");
    ok(same(gm.gmRunOutcome(run("completed", "success"), [ann("gm-result", '{"ok":true,"subj')], SITE), unsure) && same(gm.gmRunOutcome(run("completed", "success"), [], SITE), unsure), "a successful run without a readable result says to check GitHub before publishing again");
    ok(same(gm.gmRunOutcome(run("completed", "failure"), [], SITE), { ok: false, error: "GitHub ทำงานไม่สำเร็จก่อนถึงขั้นตอนของไกด์ ดูรายละเอียดใน GitHub", runUrl: "https://github.com/jumpptty/12tails/actions/runs/1" }), "a run failing before the pipeline links to GitHub");
    // review 2026-10-20: a legacy 12TG1 code can carry any class or server text, which the page puts into its HTML
    { const g = doc.guides[0].g, evil = { ...g, build: { ...g.build, classKey: "<img src=x onerror=alert(1)>" } }, evil2 = { ...g, build: { ...g.build, server: "zz" } };
      ok(/โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ/.test(throws(() => gm.gmCheckGuide(evil))) && /โค้ดนี้ไม่ใช่โค้ดไกด์อาชีพ/.test(throws(() => gm.gmCheckGuide(evil2))), "gmCheckGuide refuses a class or server that is not a real one");
      ok(doc.guides.every(({ g }) => !throws(() => gm.gmCheckGuide(g))), "gmCheckGuide accepts every embedded guide"); }
    // user 2026-10-20: a replacement identical to the guide it replaces gets a warning (PVE/PVP and the id are left out: the page sets those)
    { const g = doc.guides[0].g, reordered = JSON.parse(JSON.stringify(Object.fromEntries(Object.entries(g).reverse()))), other = { ...g, title: g.title + " v2" }, modes = { ...g, modes: ["pvp"], id: 999 };
      const pairs = [[g, reordered], [g, other], [g, modes], [g, { ...g, build: { ...g.build, level: g.build.level - 1 } }]];
      ok(gm.gmSameGuide(g, reordered) && !gm.gmSameGuide(g, other) && gm.gmSameGuide(g, modes) && !gm.gmSameGuide(...pairs[3]), "gmSameGuide: same content in any key order, PVE/PVP and id left out, any real change counts");
      ok(pairs.every(([a, b]) => gm.gmSameGuide(a, b) === ag.sameGuide(a, b)), "gmSameGuide and add_guide's sameGuide agree"); }
    ok(gm.gmKeyProblem(401) === "กุญแจใช้ไม่ได้ (หมดอายุหรือถูกลบ) ใส่กุญแจใหม่" && gm.gmKeyProblem(403) === "กุญแจนี้ยังไม่มีสิทธิ์ Actions: Read and write ของ 12tails" && gm.gmKeyProblem(404) === gm.gmKeyProblem(403) && gm.gmKeyProblem(200) === null, "gmKeyProblem names an expired key and a key without Actions write");
    // user 2026-10-23: a batch result's donor items ({ action, k }) are no guides, so they get no #class-guide link
    { const mixed = { ...result, items: [{ action: "add", id: 54 }, { action: "donor-add", k: "0a1b2c3d" }, { action: "donor-remove", k: "4e5f6a7b" }] }, out = gm.gmRunOutcome(run("completed", "success"), [ann("gm-result", JSON.stringify(mixed))], SITE);
      ok(!!out && same(out.items, [{ action: "add", id: 54, url: SITE + "#class-guide/54" }, { action: "donor-add", k: "0a1b2c3d" }, { action: "donor-remove", k: "4e5f6a7b" }]), "a donor item in gm-result gets no guide link"); }
    // The ☕ donor tab (user 2026-10-23): on the phone the page checks, reads and groups donations itself, so its copies of scripts/donors.js
    // must give the same results and messages. The อนุมัติ link's fragment is untrusted: anyone can make one.
    try {
      const dl = require(path.join(__dirname, "donors.js"));
      const dn = vm.runInContext("({ gmCheckSlipDetails, gmCheckDonation, GM_DONOR_LIMITS, gmParseDonors, gmFromFragment, gmDonorFromLink, gmGroupDonors, gmDonorMatches, gmDuplicateDonation, gmNewId })", ctx);
      ok(same(dn.GM_DONOR_LIMITS, dl.LIMITS), "GM_DONOR_LIMITS differ from LIMITS in scripts/donors.js");
      // what a donor sends since 2026-10-23 (name and message only): gmCheckSlipDetails = checkSlipDetails, whatever amount / date ride along
      const slipCases = [{ name: "A" }, null, {}, { name: "  ก้อง\n 🐱 " }, { name: "🐱".repeat(40) }, { name: "🐱".repeat(41) }, { name: " \n " }, { name: 5 }, ...["ก".repeat(200), "ก".repeat(201), "a\r\n\r\n b", null, undefined, 5, ""].map((msg) => ({ name: "A", msg })),
        { name: "A", msg: "m", amount: "abc", date: 5 }, { name: "A", amount: 50, date: "2026-10-23T14:05" }];
      const resSd = (fn, d) => { try { return { ok: fn(d) }; } catch (e) { return { err: String(e.message) }; } };
      let sdAgree = 0;
      for (const d of slipCases) { const a = resSd(dn.gmCheckSlipDetails, d), b = resSd(dl.checkSlipDetails, d); if (same(a, b)) sdAgree++; else ok(false, `gmCheckSlipDetails and checkSlipDetails disagree on ${JSON.stringify(d).slice(0, 60)}: ${JSON.stringify(a).slice(0, 90)} vs ${JSON.stringify(b).slice(0, 90)}`); }
      ok(sdAgree === slipCases.length, `gmCheckSlipDetails gives the same result or message as checkSlipDetails on ${sdAgree} of ${slipCases.length} cases`);
      // donors.js selftest's cases (now = 2026-10-23T08:00Z), and a few shapes a crafted link could carry
      const now = new Date("2026-10-23T08:00:00Z"), base = { name: "A", msg: "", amount: 50, date: "2026-10-23T14:05" }, v = (d) => ({ ...base, ...d });
      const cases = [base, null, {}, v({ name: "  ก้อง\n 🐱 " }), v({ name: "🐱".repeat(40) }), v({ name: "🐱".repeat(41) }), v({ name: " \n " }), v({ name: 5 }), v({ msg: "ก".repeat(200) }), v({ msg: "ก".repeat(201) }), v({ msg: "a\r\n\r\n b" }), v({ msg: null }), v({ msg: undefined }), v({ msg: 5 }),
        ...[50, 0.5, 1000000, 0, -1, 1.234, 1000000.01, "50", NaN, Infinity, 12.345, 0.1 + 0.2].map((amount) => v({ amount })),
        ...["2026-10-23T14:05", "2026-10-25T00:00", "2019-12-31T23:59", "2026-02-30T10:00", "2026-10-23 14:05", 5, "2020-01-01T00:00", "2026-10-24T14:59", "2026-10-24T15:01"].map((date) => v({ date }))];
      const res = (fn, d) => { try { return { ok: fn(d, now) }; } catch (e) { return { err: String(e.message) }; } };
      let agree = 0;
      for (const d of cases) { const a = res(dn.gmCheckDonation, d), b = res(dl.checkDonation, d); if (same(a, b)) agree++; else ok(false, `gmCheckDonation and checkDonation disagree on ${JSON.stringify(d).slice(0, 60)}: ${JSON.stringify(a).slice(0, 90)} vs ${JSON.stringify(b).slice(0, 90)}`); }
      ok(agree === cases.length, `gmCheckDonation gives the same result or message as checkDonation on ${agree} of ${cases.length} cases`);
      const x1 = { k: "0a1b2c3d", id: "11111111", name: "ก้อง 🐱 </script>", msg: "hi", amount: 12.5, date: "2026-10-23T14:05" }, x2 = { ...x1, k: "4e5f6a7b", name: "B", msg: "", amount: 100 };
      const fixture = (eol, xs) => ["<script>", "const CLASS_GUIDES = [", "];", "const DONORS = [", ...xs.map(dl.donorLine), "];", "</script>"].join(eol);
      const readsSame = (h) => same(dn.gmParseDonors(h), dl.parseDonors(h).donations.map((t) => t.x));
      ok(readsSame(html) && readsSame(html.replace(/\r\n/g, "\n")), "gmParseDonors reads the real page's DONORS as parseDonors does (CRLF and LF)");
      ok(["\r\n", "\n"].every((eol) => readsSame(fixture(eol, [x1, x2])) && dn.gmParseDonors(fixture(eol, [x1, x2])).length === 2 && readsSame(fixture(eol, []))), "gmParseDonors reads a fixture (two donations, an empty block) as parseDonors does");
      ok(/DONORS/.test(throws(() => dn.gmParseDonors("<script></script>"))), "gmParseDonors refuses a page without DONORS");
      const gd = (id, name, msg, amount, date) => ({ k: id + date, id, name, msg, amount, date });
      const sets = [[gd("A", "old", "hi", 100, "2026-10-02T10:00"), gd("B", "bee", "", 150, "2026-10-01T10:00"), gd("A", "new", "", 50, "2026-10-05T10:00")], [gd("C", "c", "", 0.1, "2026-10-01T00:00"), gd("C", "c", "", 0.2, "2026-10-02T00:00")], []];
      ok(sets.every((s) => same(dn.gmGroupDonors(s), dl.groupDonors(s))), "gmGroupDonors gives groupDonors' rows (merged by id, latest name and message, total in satang, biggest first)");
      // the อนุมัติ link: a new one carries { name, msg }; an older one (the first slips in the owner's Discord) also the amount and date
      const fd = { name: "ก้อง 🐱 &#=", msg: "ขอบคุณ ?x=1&y=2 #" }, frag = dl.donorFragment(fd);
      const oldLink = (o) => "#donor=" + Buffer.from(JSON.stringify(o), "utf8").toString("base64url"), fd4 = { ...fd, amount: 12.5, date: "2026-10-23T14:05" };
      const bothRead = (h) => { const a = dn.gmFromFragment(h); return same(a, dl.fromFragment(h)) ? a : { disagree: [a, dl.fromFragment(h)] }; };
      ok(same(bothRead("#" + frag), fd) && same(bothRead(frag), fd), "gmFromFragment and fromFragment give a 2-field link's { name, msg } back (Thai, emoji, &#=)");
      ok(same(bothRead(oldLink(fd4)), fd4) && same(bothRead(oldLink({ date: "2026-10-23T14:05", x: 1, name: "A", msg: "" })), { name: "A", msg: "", date: "2026-10-23T14:05" }), "gmFromFragment and fromFragment read an older 4-field link (amount and date kept, other keys dropped)");
      const odd = ["#donor=@@@", "#x=1", "", null, "#donor=" + Buffer.from("[1,2]").toString("base64url"), "#donor=" + Buffer.from("null").toString("base64url"), "#donor=" + Buffer.from([0xff, 0xfe]).toString("base64url"), "#" + frag + "&x=1"];
      ok(odd.every((h) => dn.gmFromFragment(h) === null && dl.fromFragment(h) === null), "gmFromFragment gives null for anything but a donor link, as fromFragment does");
      // what a link fills in the donor card: name and message checked like a slip; the amount and date only from an older link that passes
      // gmCheckDonation (a new link leaves both empty for the owner to type from the slip); a link that fails fills nothing
      const fromLink = (h) => { try { return { ok: dn.gmDonorFromLink(h, now) }; } catch (e) { return { err: String(e.message) }; } };
      ok(same(fromLink("#" + frag), { ok: { name: fd.name, msg: fd.msg } }), "gmDonorFromLink on a new link fills only the name and message (amount and date stay empty)");
      ok(same(fromLink(oldLink({ name: "  Kong ", msg: "", amount: 50, date: "2026-10-23T14:05" })), { ok: { name: "Kong", msg: "", amount: 50, date: "2026-10-23T14:05" } }), "gmDonorFromLink on an older link with a good amount and date fills all four");
      ok([{ amount: "50", date: "2026-10-23T14:05" }, { amount: 50, date: "2019-01-01T00:00" }, { amount: 50 }].every((x) => same(fromLink(oldLink({ name: "Kong", msg: "", ...x })), { ok: { name: "Kong", msg: "" } })), "gmDonorFromLink drops an older link's amount and date unless both pass gmCheckDonation");
      ok(same(fromLink("#donor=@@@"), { err: "อ่านข้อมูลในลิงก์ไม่ได้ (ลิงก์ไม่ครบหรือถูกแก้)" }) && same(fromLink(oldLink({ name: " ", msg: "", amount: 50, date: "2026-10-23T14:05" })), { err: "กรุณาใส่ชื่อ" }) && same(fromLink(oldLink({ name: "A", msg: "ก".repeat(201) })), { err: resSd(dl.checkSlipDetails, { name: "A", msg: "ก".repeat(201) }).err }), "gmDonorFromLink refuses an unreadable link and a bad name or message with the Thai reason");
      const rows = dl.groupDonors(sets[0]);
      ok(same(dn.gmDonorMatches(rows, "  NEW ").map((r) => r.id), ["A"]) && same(dn.gmDonorMatches(rows, "Bee").map((r) => r.id), ["B"]) && !dn.gmDonorMatches(rows, "old").length && !dn.gmDonorMatches(rows, " ").length, "gmDonorMatches: trimmed, case-insensitive, on a donor's latest name only");
      // Review Focus 5: the same อนุมัติ link opened twice
      const list = [{ k: "0a1b2c3d", id: "11111111", name: "Kong", msg: "", amount: 50, date: "2026-10-23T14:05" }], again = { name: "Kong", msg: "ขอบคุณ", amount: 50, date: "2026-10-23T14:05" };
      const qAdd = [{ action: "donor-add", donor: { id: "22222222", name: "Mai", msg: "", amount: 20, date: "2026-10-22T09:00" } }];
      ok(dn.gmDuplicateDonation(again, list, []) === true && dn.gmDuplicateDonation({ name: "Mai", msg: "", amount: 20, date: "2026-10-22T09:00" }, [], qAdd) === true && dn.gmDuplicateDonation({ ...again, amount: 51 }, list, qAdd) === false, "gmDuplicateDonation finds the same donation in list or queue");
      ok(dn.gmDuplicateDonation(again, list, [{ action: "donor-remove", k: "0a1b2c3d" }]) === false, "gmDuplicateDonation leaves out a donation queued for removal (remove, then add it again corrected)");
      const ids = new Set(Array.from({ length: 200 }, () => dn.gmNewId()));
      ok(ids.size === 200 && [...ids].every((s) => /^[0-9a-f]{8}$/.test(s)), "gmNewId gives 8 lowercase hex characters (200 without a repeat)");
    } catch (e) { ok(false, e.message + " (donor checks)"); }
    if (!gmFailed) console.log(`Verified the guide manager page's own code reader, donor rules and GitHub replies: ${gmChecked} checks (${decoded} codes read like guide_code.js).`);
  }
}
// Runs last: some deps sync the Buff / Debuff state (Amplify Damage writes the enemy debuff), which restoring their rank does not undo.
// The full glow follows the deps (user 2026-10-21: Cat Combo with Hidden Blade on reads TAL, talAdjust(10 x rank), and TAL did not glow).
// Measured: every card on BB with its default deps and with each dep its strip shows at its max rank, one at a time. A main stat (ATK, TAL,
// AGI, INT, CHA) that moves the numbers from 0 to 300 must glow, and a glowing one must move them (re-measured with the other stats strong
// and weak first, for a hit pinned at 1). The summon stat block's rows marked unused don't count: the card says they don't drive it.
let checkedDepGlow = 0;
if (RUN_DAMAGE_CHECKS) {
  const inputs = sandbox._statInputs, deps = sandbox._depRanks, bad = [], savedIn = Object.fromEntries(Object.entries(inputs).map(([k, el]) => [k, el.value]));
  const sameClass = (sk) => SKILLS.find(x => x.class === sk.class && x.id !== sk.id) || SKILLS.find(x => x.id !== sk.id);
  const STATS = ["atk", "tal", "agi", "int", "cha"];
  const strip = (h) => h.replace(/(sk-summon-stat-unused[^>]*>[\s\S]*?sk-summon-stat-value[^>]*>)[^<]*/g, "$1");   // unused summon rows' values
  sandbox._setServer("og");
  for (const sk of SKILLS) {
    try {
      for (const k of Object.keys(inputs)) inputs[k].value = DATA_ROLE_DEFAULTS[k] !== undefined ? DATA_ROLE_DEFAULTS[k] : "128";
      const render = () => { sandbox._selectSkill(sameClass(sk)); sandbox._selectSkill(sk); return strip(sandbox._getRenderedHeroHtml()); };
      const depList = [...new Map([...render().matchAll(/data-dep-id="([^"]+)"[^>]*?data-dep-(?:max-rank|toggle-on)="(\d+)"/g)].map(m => [m[1], +m[2]]))];
      for (const [id, max] of [[null, 0], ...depList]) {
        const was = id ? deps[id] : undefined;
        if (id) deps[id] = max;
        try {
          render();   // warm-up: the first render after a dep change carries its pips' pop-in classes
          const used = sandbox.getUsedPlayerStatKeys(sk);
          const moves = (st) => { const keep = inputs[st].value; inputs[st].value = "0"; const a = render(); inputs[st].value = "300"; const b = render(); inputs[st].value = keep; return a !== b; };
          const movesAnywhere = (st) => moves(st) || ["400", "0"].some(v => { const keep = STATS.filter(k => k !== st).map(k => [k, inputs[k].value]); keep.forEach(([k]) => { inputs[k].value = v; }); try { return moves(st); } finally { keep.forEach(([k, x]) => { inputs[k].value = x; }); } });
          for (const st of STATS) {
            checkedDepGlow++;
            const m = moves(st), g = used.has(st), where = sk.id + (id ? " with " + id + " " + max : "");
            if (m && !g) bad.push(`${where}: ${st.toUpperCase()} moves the numbers but does not glow`);
            if (!m && g && !movesAnywhere(st)) bad.push(`${where}: ${st.toUpperCase()} glows but moves nothing`);
          }
          // LCK in every dep state too (user 2026-10-23: Cat Combo with No Chance reads +0.3 x LCK, and it did not light): fully or softly
          checkedDepGlow++;
          if (moves("lck") && !used.has("lck") && !sandbox.getSoftPlayerStatKeys(sk).has("lck")) bad.push(`${sk.id + (id ? " with " + id + " " + max : "")}: LCK moves the numbers but does not glow`);
        } finally { if (id) { if (was === undefined) delete deps[id]; else deps[id] = was; } }
      }
    } catch (e) { bad.push(`${sk.id}: ${e.message}`); }
  }
  // TTO has no talAdjust / dmgAdjust / defAdjust luck roll, so a dep that reads LCK directly is the only way it can glow there: the same
  // dep-by-dep LCK measurement on TTO (the No Chance case was BB-soft, TTO-dark)
  sandbox._setServer("tto");
  for (const sk of SKILLS) {
    try {
      for (const k of Object.keys(inputs)) inputs[k].value = DATA_ROLE_DEFAULTS[k] !== undefined ? DATA_ROLE_DEFAULTS[k] : "128";
      const render = () => { sandbox._selectSkill(sameClass(sk)); sandbox._selectSkill(sk); return strip(sandbox._getRenderedHeroHtml()); };
      const depList = [...new Map([...render().matchAll(/data-dep-id="([^"]+)"[^>]*?data-dep-(?:max-rank|toggle-on)="(\d+)"/g)].map(m => [m[1], +m[2]]))];
      for (const [id, max] of [[null, 0], ...depList]) {
        const was = id ? deps[id] : undefined;
        if (id) deps[id] = max;
        try {
          render();
          if ((LCK_GLOW_HIDDEN.tto || {})[sk.id]) continue;   // a real roll the shown numbers can't reveal (see the LCK glow check)
          const keep = inputs.lck.value; inputs.lck.value = "0"; const a = render(); inputs.lck.value = "300"; const b = render(); inputs.lck.value = keep;
          checkedDepGlow++;
          if (a !== b && !sandbox.getUsedPlayerStatKeys(sk).has("lck") && !sandbox.getSoftPlayerStatKeys(sk).has("lck")) bad.push(`tto ${sk.id + (id ? " with " + id + " " + max : "")}: LCK moves the numbers but does not glow`);
        } finally { if (id) { if (was === undefined) delete deps[id]; else deps[id] = was; } }
      }
    } catch (e) { bad.push(`tto ${sk.id}: ${e.message}`); }
  }
  sandbox._setServer("og");
  for (const k of Object.keys(inputs)) inputs[k].value = savedIn[k];
  bad.slice(0, 40).forEach(m => console.error("[STAT GLOW ERROR] " + m));
  if (bad.length > 40) console.error(`[STAT GLOW ERROR] ... and ${bad.length - 40} more`);
  errorCount += bad.length;
  console.log(`Verified ${checkedDepGlow} stat glow checks across dep states (every card on BB, each dep at max; LCK on TTO too).`);
}
console.log("=== AUDIT SUMMARY ===");
if (errorCount === 0) {
  console.log(`SUCCESS: All ${SKILLS.length} skills, ${checkedFormulas} formula permutations, ${checkedLckFloors} LCK-floor checks, ${checkedGaosHeroRouting} Gaos render checks, and ${Object.keys(SKILL_ICONS).length} icons passed 100% of automated integrity checks!`);
} else {
  console.error(`FAILED: Found ${errorCount} error(s). Please fix before committing.`);
  process.exit(1);
}
