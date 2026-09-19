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
  window._statInputs = { atk: atkEl, tal: talEl, lck: lckEl };
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

            lckEl.value = DATA_ROLE_DEFAULTS.lck;
            sandbox._selectSkill(sk);
            const normalRange = sandbox._calcRangeFor(rawText);

            lckEl.value = "0";
            sandbox._selectSkill(sk);
            const zeroLckRange = sandbox._calcRangeFor(rawText);
            lckEl.value = DATA_ROLE_DEFAULTS.lck; // restore before any later check reads it

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
const DEP_FIELDS = ["cdDep", "castDep", "dmgDep", "dmgRankDep", "dmgMultDep", "hitCountDep", "dep", "descDep", "koDep", "shieldDep", "shieldRankDep"];
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
console.log("=== AUDIT SUMMARY ===");
if (errorCount === 0) {
  console.log(`SUCCESS: All ${SKILLS.length} skills, ${checkedFormulas} formula permutations, ${checkedLckFloors} LCK-floor checks, ${checkedGaosHeroRouting} Gaos render checks, and ${Object.keys(SKILL_ICONS).length} icons passed 100% of automated integrity checks!`);
} else {
  console.error(`FAILED: Found ${errorCount} error(s). Please fix before committing.`);
  process.exit(1);
}
