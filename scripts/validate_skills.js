/**
 * Automated Skill Integrity & Mechanics Linter for 12Tails Reference Tools
 *
 * Verifies:
 * 1. Formula validity & evaluation across all rank (1..maxRank) and dependency toggle (0..maxRank) permutations.
 * 2. Icon existence in SKILL_ICONS and PNG header validity (89 50 4E 47 0D 0A 1A 0A).
 * 3. Array bounds for per-rank properties (cd, castTime, duration).
 * 4. Effect damage / penetrating damage flag alignment.
 * 5. LCK-invariant floor: the "รวมการแกว่งค่า LCK" (Total LCK Variance) chip's own
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

const targetPath = path.resolve(__dirname, '../12t_projects/bible/index.html');
if (!fs.existsSync(targetPath)) {
  console.error("Target index.html not found at:", targetPath);
  process.exit(1);
}

const html = fs.readFileSync(targetPath, 'utf8');

// The player-facing update panel is static data, so it otherwise silently
// drifts behind Git history. A dirty tracked tree must carry a newly prepared
// top entry; a clean tree must have that entry match HEAD's commit subject.
const changelogMatch = html.match(/const CHANGELOG_DATA\s*=\s*\{[\s\S]*?entries:\s*\[\s*\["([^"]+)","([^"]+)"\]/);
if (!changelogMatch) {
  console.error('[CHANGELOG ERROR] Could not read the newest CHANGELOG_DATA entry.');
  process.exit(1);
}
const [, changelogTime, changelogSubject] = changelogMatch;
if (Number.isNaN(Date.parse(changelogTime))) {
  console.error(`[CHANGELOG ERROR] Newest entry has an invalid ISO timestamp: '${changelogTime}'.`);
  process.exit(1);
}
let headSubject = '';
let trackedTreeDirty = false;
try {
  headSubject = execFileSync('git', ['log', '-1', '--format=%s'], { cwd: path.resolve(__dirname, '..'), encoding: 'utf8' }).trim();
  execFileSync('git', ['diff', '--quiet', 'HEAD', '--'], { cwd: path.resolve(__dirname, '..'), stdio: 'ignore' });
} catch (error) {
  trackedTreeDirty = true;
}
if (trackedTreeDirty && changelogSubject === headSubject) {
  console.error(`[CHANGELOG ERROR] Tracked changes are pending but CHANGELOG_DATA still names HEAD: '${headSubject}'. Prepend the planned commit subject before validating.`);
  process.exit(1);
}
if (!trackedTreeDirty && changelogSubject !== headSubject) {
  console.error(`[CHANGELOG ERROR] Newest CHANGELOG_DATA entry '${changelogSubject}' does not match HEAD '${headSubject}'. Update the panel before pushing.`);
  process.exit(1);
}
console.log(trackedTreeDirty
  ? `CHANGELOG PENDING: '${changelogSubject}' is prepared for the next commit.`
  : `CHANGELOG CURRENT: '${changelogSubject}' matches HEAD.`);

// Soft reminder (non-blocking, unlike the CHANGELOG gate above): index.html
// changing without GEMINI.md changing alongside it isn't necessarily wrong --
// most edits (desc text, a new card following existing patterns) don't touch
// any documented convention -- but it's exactly the case that let the
// Status Keyword Rendering section silently drift out of date behind the
// real implementation earlier in this project's history. This only nudges;
// it never exits non-zero. Checks the working tree diff when dirty, or the
// most recent commit's own diff when clean, so it fires at the same two
// checkpoints as the CHANGELOG gate (before commit, before push).
try {
  const repoRoot = path.resolve(__dirname, '..');
  const changedFiles = trackedTreeDirty
    ? execFileSync('git', ['diff', '--name-only', 'HEAD', '--'], { cwd: repoRoot, encoding: 'utf8' })
    : execFileSync('git', ['diff', '--name-only', 'HEAD~1', 'HEAD', '--'], { cwd: repoRoot, encoding: 'utf8' });
  const files = changedFiles.split('\n').filter(Boolean);
  const touchedIndex = files.some(f => f.endsWith('12t_projects/bible/index.html'));
  const touchedGemini = files.some(f => f.endsWith('12t_projects/bible/GEMINI.md'));
  if (touchedIndex && !touchedGemini) {
    console.log(`[GEMINI.md REMINDER] index.html changed without GEMINI.md changing in the same ${trackedTreeDirty ? 'working tree diff' : 'commit'} -- if this introduced or changed a convention (new desc markdown, a new schema field, a new chip/layout mechanism), document it there before ${trackedTreeDirty ? 'committing' : 'pushing'}. If it's just desc text or a new card following existing patterns, no action needed.`);
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
scriptCode = scriptCode.replace('const CLASS_PORTRAITS =', 'window.CLASS_PORTRAITS =');

const exposeInjection = `
  window._getDmgText = getDmgText;
  window._substituteDmgVars = substituteDmgVars;
  window._renderOneDmgFormula = renderOneDmgFormula;
  window._renderShieldFormula = renderShieldFormula;
  window._rollOneHit = rollOneHit;
  window._getKOValue = getKOValue;
  window._depRanks = depRanks;
  window._skillRanks = skillRanks;
  window._selectSkill = selectSkill;
  window._getRenderedHeroHtml = () => displayEl.innerHTML;
  window._statInputs = { atk: atkEl, tal: talEl, lck: lckEl, enemyLck: enemyLckEl };
  window._cycleEnemyPreset = cycleEnemyPreset;
  window._selectedEnemyId = () => selectedEnemyId;
`;
scriptCode = scriptCode.replace('function onSearchInput(){', exposeInjection + '\nfunction onSearchInput(){');

function makeEl() {
  return {
    innerHTML: "",
    innerText: "",
    value: "0",
    style: {},
    dataset: {},
    classList: { add: ()=>{}, remove: ()=>{}, toggle: ()=>{}, contains: ()=>false },
    appendChild: ()=>{},
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
    parentElement: { className: "", style: {} },
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
const SKILL_ICONS = sandbox.SKILL_ICONS;

if (!Array.isArray(SKILLS) || !SKILL_ICONS) {
  console.error("FATAL: SKILLS or SKILL_ICONS not exported correctly.");
  process.exit(1);
}

console.log(`Auditing ${SKILLS.length} skills and ${Object.keys(SKILL_ICONS).length} icons...\n`);

let errorCount = 0;
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
  if (!data.startsWith('data:image/png;base64,')) {
    console.error(`[ICON ERROR] Icon '${key}' in ${context} does not have valid PNG data URI prefix`);
    errorCount++;
    return;
  }
  const buf = Buffer.from(data.replace('data:image/png;base64,', ''), 'base64');
  if (buf.length < 8 || !buf.subarray(0, 8).equals(pngHeader)) {
    console.error(`[ICON ERROR] Icon '${key}' in ${context} has corrupted PNG header`);
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
    // Automated summon/companion AI moves must never show a "Free" badge --
    // they must omit cost completely (AGENTS.md Section 7.4). Real player-paid
    // spends on a summon-attacker skill (e.g. Titanic Earth Pulse's ownStatsGadinaHP,
    // Barrel Cannon's ownStatsDmgOnly) are unaffected since they don't set cost.free.
    const isSummonAttacker = !!(sk.ownStats || sk.ownStatsDmgOnly || sk.ownStatsKaiser || sk.ownStatsGyro || sk.ownStatsPhoenix || sk.ownStatsGadinaHP);
    if (isSummonAttacker && sk.cost.free === true) {
      console.error(`[COST ERROR] ${ctx}: automated summon/companion move must omit cost completely, not show a Free badge (AGENTS.md Section 7.4)`);
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
// pass unnoticed again.
let checkedGaosHeroRouting = 0;
SKILLS.filter(sk => sk.ownStatsGaos && sk.id !== "monkey_summonGaos").forEach(sk => {
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
        console.error(`[GAOS OWN-STATS ERROR] ${ctx} Rank ${r}: rendered formula/simulation changed when Monkey ATK/TAL/LCK changed`);
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
    // The real roll path (rollOneHit) draws its own random numbers, so compare
    // AVERAGES over many rolls. Expected gaps are large next to the noise (one
    // roll's spread is ~70, so 400 rolls give a standard error of ~3.5).
    const avgRoll = (atk, lck, eLck, joker) => {
      inputs.atk.value = String(atk); inputs.lck.value = String(lck); inputs.enemyLck.value = String(eLck);
      sandbox._depRanks[sk.lckDiffDep.id] = joker ? 1 : 0;
      sandbox._skillRanks[sk.id] = 4;
      sandbox._selectSkill(sk);
      let sum = 0;
      for (let i = 0; i < 400; i++) sum += sandbox._rollOneHit(sk, 4);
      return sum / 400;
    };
    // Consistency: the Final Damage RANGE shown on the card must contain every simulated roll
    // (the hero range and the Test/Simulate popup share the same pipeline stages), and its
    // maximum must be reachable, not wildly above what rolls ever produce.
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
      expect(`final range max is reachable (${tag}) [range max ${fin[1]}, top roll ${hi}]`, hi >= fin[1] * 0.85, true);
    });
    const rollBase = avgRoll(200, 102, 102, false);
    const rollLead = avgRoll(200, 102, 2, false);
    expect("roll: an LCK lead adds a random 0..250 (mean ~+125, minus enemy-LCK mitigation noise)", rollLead - rollBase > 80, true);
    const rollLeadJoker = avgRoll(200, 102, 2, true);
    expect("roll: Joker with an LCK lead adds ~+50 on top", rollLeadJoker - rollLead > 35, true);
    const rollBehind = avgRoll(200, 102, 202, false);
    const rollBehindJoker = avgRoll(200, 102, 202, true);
    expect("roll: Joker while BEHIND on LCK lowers damage by ~50 (unclamped)", rollBehindJoker - rollBehind < -35, true);
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

// 3f. Range-vs-simulator consistency, EVERY single-hit skill with a computable damage
// formula: every roll of the real Test/Simulate path (rollOneHit) must fall inside the
// Final Damage range the card displays (finalRangeForRange(calcRangeFor(...))). Run twice
// per skill rank, once with every dependency at its default and once with every dependency
// switched off. Skipped: dmgGroups skills (per-group sums) and prose/non-computable text.
// (Found 2026-09-19: Lucky Card's LCK-difference roll was missing from the displayed max.)
let checkedConsistency = 0;
{
  // Pre-existing mismatches found by this very check, NOT yet resolved. Each needs a decision
  // about which path (roll or range) matches the game; do not "fix" by widening the range.
  // Remove an entry once the skill is consistent again.
  const KNOWN_RANGE_SIM_MISMATCH = {
    // (none right now -- add "skillId: reason" only for a mismatch found by this scan and not yet resolved)
  };
  const DEP_FIELD_NAMES = ["dmgDep", "dmgMultDep", "dmgRankDep", "dmgFlagDep", "dmgReplaceDep", "hitCountDep", "lckDiffDep", "cdDep", "castDep", "koDep"];
  const inputs = sandbox._statInputs;
  const N = 2000;   // large on purpose: an overshoot can be a rare tail event (a few in 6000 rolls)
  const failures = new Map();
  SKILLS.forEach(sk => {
    if (sk.dmgGroups) return;
    const depIds = [];
    DEP_FIELD_NAMES.forEach(f => { if (sk[f] && sk[f].id) depIds.push([sk[f].id, sk[f].minRank !== undefined ? sk[f].minRank : 0]); });
    if (sk.dmgFocusIntellect) depIds.push(["focusIntellect", 0]);
    // Two stat profiles: the sandbox defaults (player LCK/ATK/TAL 0) AND a high-stat profile.
    // Only the high profile gives LCK-difference skills (Lucky Card) a real LCK lead over the
    // enemy, so a range/roll gap in that term can't hide behind all-zero stats.
    [null, { atk: "200", tal: "200", lck: "150" }].forEach(profile => {
    const savedStats = profile ? { atk: inputs.atk.value, tal: inputs.tal.value, lck: inputs.lck.value } : null;
    if (profile) { inputs.atk.value = profile.atk; inputs.tal.value = profile.tal; inputs.lck.value = profile.lck; }
    [false, true].forEach(depsOff => {
      if (depsOff && depIds.length === 0) return;   // nothing to switch off
      const saved = depIds.map(([id]) => [id, sandbox._depRanks[id]]);
      depIds.forEach(([id, min]) => { if (depsOff) sandbox._depRanks[id] = min; else delete sandbox._depRanks[id]; });
      for (let r = 1; r <= Math.max(1, sk.maxRank || 1); r++) {
        try {
          const rawText = sandbox._getDmgText(sk, r);
          const subText = sandbox._substituteDmgVars(rawText, sk, r);
          if (!(/talAdjust\(([^()]+)\)/.test(subText) || /^[\d\s×*+\-().]+$/.test(subText))) continue;
          sandbox._skillRanks[sk.id] = r;
          sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined;
          sandbox._selectSkill(sk);
          if (!sandbox._calcRangeFor || !sandbox._finalRangeForRange) continue;
          const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(rawText));
          let lo = Infinity, hi = -Infinity;
          for (let i = 0; i < N; i++) { const x = sandbox._rollOneHit(sk, r); lo = Math.min(lo, x); hi = Math.max(hi, x); }
          checkedConsistency++;
          if (lo < fin[0] || hi > fin[1]) {
            if (!failures.has(sk.id)) failures.set(sk.id, `rank ${r}${depsOff ? " (deps off)" : ""}${profile ? " (high stats)" : ""}: displayed ${fin[0]}-${fin[1]} but rolled ${lo}-${hi}`);
          }
        } catch (e) {
          if (!failures.has(sk.id)) failures.set(sk.id, `rank ${r}: EXCEPTION ${e.message}`);
        }
      }
      depIds.forEach(([id]) => { delete sandbox._depRanks[id]; });
      saved.forEach(([id, val]) => { if (val !== undefined) sandbox._depRanks[id] = val; });
    });
    if (profile) { inputs.atk.value = savedStats.atk; inputs.tal.value = savedStats.tal; inputs.lck.value = savedStats.lck; }
    });
  });
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
// 3i. Class portraits for the stat panel badge (CLASS_PORTRAITS): every class a skill belongs to (other
// than shared "Common" skills, which have no character art) needs a valid PNG portrait.
let checkedPortraits = 0;
{
  const portraits = sandbox.CLASS_PORTRAITS;
  if (!portraits) { console.error("[PORTRAIT ERROR] CLASS_PORTRAITS is not defined"); errorCount++; }
  else {
    [...new Set(SKILLS.map(sk => sk.class))].filter(c => c && c !== "Common").forEach(cls => {
      checkedPortraits++;
      const data = portraits[cls];
      if (!data) { console.error(`[PORTRAIT ERROR] class "${cls}" has no CLASS_PORTRAITS entry`); errorCount++; return; }
      const buf = Buffer.from(String(data).replace("data:image/png;base64,", ""), "base64");
      if (!String(data).startsWith("data:image/png;base64,") || buf.length < 8 || !buf.subarray(0, 8).equals(pngHeader)) {
        console.error(`[PORTRAIT ERROR] class "${cls}" portrait is not a valid PNG data URI`); errorCount++;
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
  check("player caption should appear exactly once", count("ค่าสถานะตัวละครของคุณ") === 1);
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
  check("the enemy icon must be a button (click = next preset)", enemyBadge.includes('<button type="button" class="sk-enemy-cycle-icon-wrap" data-role="enemy-cycle-display"'));
  check("the enemy prev/next arrows must stay removed", count("enemy-prev") === 0 && count("enemy-next") === 0);
}
// 3k. Summon stat-feed glow (getSummonFeedPlayerStatKeys, 2026-09-19): a character stat glows in the player
// panel when a dependency feeds it into a summon stat AND the selected skill's chips read that summon stat.
let checkedSummonFeed = 0;
{
  const byId = id => SKILLS.find(x => x.id === id);
  const DEP_IDS = ["doubleBot", "synchroMole2", "hiddenTurret", "fireSoul", "earthSoul", "aegisOfEarth"];
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
    expectKey("Barrel Bot, both deps on", glow(bb, { doubleBot: 1, synchroMole2: 1 }), "lv", true);
    expectKey("Barrel Bot, both deps on", glow(bb, { doubleBot: 1, synchroMole2: 1 }), "tal", true);
    expectKey("Barrel Bot, Double Bot only", glow(bb, { doubleBot: 1 }), "lv", true);
    expectKey("Barrel Bot, Double Bot only", glow(bb, { doubleBot: 1 }), "tal", false);
    expectKey("Barrel Bot, Synchro Mole only", glow(bb, { synchroMole2: 1 }), "tal", true);
    expectKey("Barrel Bot, Synchro Mole only", glow(bb, { synchroMole2: 1 }), "lv", false);
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
    const plainOn = glow("penguin_frozenBlast", { doubleBot: 1, synchroMole2: 1, hiddenTurret: 1, fireSoul: 1, earthSoul: 1, aegisOfEarth: 3 });
    const plainOff = glow("penguin_frozenBlast", {});
    checkedSummonFeed++;
    if ([...plainOn].sort().join() !== [...plainOff].sort().join()) { console.error("[SUMMON FEED ERROR] a non-summon skill's glow changed with summon dependencies"); errorCount++; }
  } catch (e) {
    console.error(`[SUMMON FEED EXCEPTION] ${e.message}`);
    errorCount++;
  }
  saved.forEach(([id, val]) => { if (val === undefined) delete sandbox._depRanks[id]; else sandbox._depRanks[id] = val; });
}
// 3l. Enemy icon click = next preset (cycleEnemyPreset(1)): it must visit every preset exactly once, forward,
// and wrap back to the start. (The prev/next arrows are gone, so this is the only way to change the target.)
let checkedEnemyCycle = 0;
{
  const startId = sandbox._selectedEnemyId();
  const visited = [startId];
  let guard = 0;
  do { sandbox._cycleEnemyPreset(1); visited.push(sandbox._selectedEnemyId()); } while (visited[visited.length - 1] !== startId && ++guard < 50);
  const lap = visited.slice(0, -1);
  const check = (label, ok) => { checkedEnemyCycle++; if (!ok) { console.error(`[ENEMY CYCLE ERROR] ${label}: visited ${visited.join(" > ")}`); errorCount++; } };
  check("a lap must return to the starting preset", visited[visited.length - 1] === startId);
  check("a lap must visit at least two presets", lap.length >= 2);
  check("every preset must be visited exactly once per lap", new Set(lap).size === lap.length);
  const afterLap = sandbox._selectedEnemyId();
  sandbox._cycleEnemyPreset(1);
  check("one more click after a lap moves on to the second preset again", sandbox._selectedEnemyId() === lap[1]);
  for (let i = 1; i < lap.length; i++) sandbox._cycleEnemyPreset(1);   // finish that lap so the sandbox ends where it started
  check("state restored after the test", sandbox._selectedEnemyId() === afterLap);
}
// 4. Audit compatSkills reciprocity (AGENTS.md Section 8: every edge must be
// reciprocated -- if A lists B, B must list A back).
const skillById = new Map(SKILLS.map(s => [s.id, s]));
SKILLS.forEach(sk => {
  if (!Array.isArray(sk.compatSkills)) return;
  const ctx = `${sk.class} > ${sk.name} (${sk.id})`;
  sk.compatSkills.forEach(targetId => {
    const target = skillById.get(targetId);
    if (!target) {
      console.error(`[COMPAT ERROR] ${ctx}: compatSkills references unknown id '${targetId}'`);
      errorCount++;
      return;
    }
    const targetCompat = Array.isArray(target.compatSkills) ? target.compatSkills : [];
    if (!targetCompat.includes(sk.id)) {
      console.error(`[COMPAT ERROR] ${ctx}: compatSkills -> '${targetId}' is not reciprocated ('${targetId}' does not list '${sk.id}' back)`);
      errorCount++;
    }
  });
});

// 5. Report standalone dep objects with no matching SKILLS card yet (AGENTS.md
// Section 5.C Step 3.5's "close the loop" backlog). Informational only -- never
// fails the build. A dep is "resolved" once some skill's own id matches
// "<classPrefix>_<dep.id>" (every observed dep so far lives in the same class
// as the skill(s) that reference it).
const DEP_FIELDS = ["cdDep", "castDep", "dmgDep", "dmgRankDep", "dmgMultDep", "hitCountDep", "dep", "descDep", "koDep", "shieldDep", "shieldRankDep", "lckDiffDep"];
const seenDeps = new Map(); // dep.id -> { label, resolved, referencedBy: [] }
SKILLS.forEach(sk => {
  const classPrefix = sk.class.toLowerCase() + "_";
  DEP_FIELDS.forEach(field => {
    const dep = sk[field];
    if (!dep || !dep.id) return;
    if (!seenDeps.has(dep.id)) {
      seenDeps.set(dep.id, { label: dep.label || dep.id, resolved: skillById.has(classPrefix + dep.id), referencedBy: [] });
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
if (trackedTreeDirty) {
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

console.log(`Evaluated ${checkedFormulas} formula permutations across all ranks and dependencies.`);
console.log(`Verified ${checkedLckFloors} LCK-invariant-floor permutations.`);
console.log(`Verified ${checkedGaosHeroRouting} Gaos own-stat render permutations.`);
console.log(`Verified ${checkedDeepLinks} deep-link routing checks.`);
console.log(`Verified ${checkedStatusKeywords} status keyword checks.`);
console.log(`Verified ${checkedLckDiff} LCK-difference (Lucky Card / Joker) checks.`);
console.log(`Verified ${checkedBenediction} Sheep Benediction (talAdjust base order) checks.`);
console.log(`Verified ${checkedRankIcons} multi-rank icon presence checks.`);
console.log(`Verified ${checkedPortraits} class portrait checks.`);
console.log(`Verified ${checkedPanelMarkup} stat panel structure checks.`);
console.log(`Verified ${checkedSummonFeed} summon stat-feed glow checks.`);
console.log(`Verified ${checkedEnemyCycle} enemy icon-cycle checks.`);
console.log(`Verified ${checkedConsistency} range-vs-simulator consistency checks (every single-hit skill rank, deps default and off, two stat profiles).`);
console.log("=== AUDIT SUMMARY ===");
if (errorCount === 0) {
  console.log(`SUCCESS: All ${SKILLS.length} skills, ${checkedFormulas} formula permutations, ${checkedLckFloors} LCK-floor checks, ${checkedGaosHeroRouting} Gaos render checks, and ${Object.keys(SKILL_ICONS).length} icons passed 100% of automated integrity checks!`);
} else {
  console.error(`FAILED: Found ${errorCount} error(s). Please fix before committing.`);
  process.exit(1);
}
