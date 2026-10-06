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
// Per AGENTS.md the gate covers commits that touch index.html only: compare against the latest commit that changed
// index.html (not HEAD), and require a new entry only while index.html itself has pending changes. Doc-only commits
// (12t_reference/, GEMINI.md, scripts/) need no changelog entry.
const repoRoot = path.resolve(__dirname, '..');
const INDEX_REL = '12t_projects/bible/index.html';
let indexSubject = '';
let indexDirty = false;
try {
  indexSubject = execFileSync('git', ['log', '-1', '--format=%s', '--', INDEX_REL], { cwd: repoRoot, encoding: 'utf8' }).trim();
  execFileSync('git', ['diff', '--quiet', 'HEAD', '--', INDEX_REL], { cwd: repoRoot, stdio: 'ignore' });
} catch (error) {
  indexDirty = true;
}
if (indexDirty && changelogSubject === indexSubject) {
  console.error(`[CHANGELOG ERROR] index.html has pending changes but CHANGELOG_DATA still names its last commit: '${indexSubject}'. Prepend the planned commit subject before validating.`);
  process.exit(1);
}
if (!indexDirty && changelogSubject !== indexSubject) {
  console.error(`[CHANGELOG ERROR] Newest CHANGELOG_DATA entry '${changelogSubject}' does not match the last commit that touched index.html ('${indexSubject}'). Update the panel before pushing.`);
  process.exit(1);
}
console.log(indexDirty
  ? `CHANGELOG PENDING: '${changelogSubject}' is prepared for the next commit.`
  : `CHANGELOG CURRENT: '${changelogSubject}' matches the last commit that touched index.html.`);

// Soft reminder (non-blocking, unlike the CHANGELOG gate above): index.html
// changing without the rulebook changing alongside it isn't necessarily wrong --
// most edits (desc text, a new card following existing patterns) don't touch
// any documented convention -- but it's exactly the case that let the
// Status Keyword Rendering section silently drift out of date behind the
// real implementation earlier in this project's history. This only nudges;
// it never exits non-zero. Checks the working tree diff when dirty, or the
// most recent commit's own diff when clean, so it fires at the same two
// checkpoints as the CHANGELOG gate (before commit, before push).
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
scriptCode = scriptCode.replace('const CLASS_PORTRAITS =', 'window.CLASS_PORTRAITS =');

const exposeInjection = `
  window._getDmgText = getDmgText;
  window._substituteDmgVars = substituteDmgVars;
  window._renderOneDmgFormula = renderOneDmgFormula;
  window._renderShieldFormula = renderShieldFormula;
  window._rollOneHit = rollOneHit;
  window._resolveGroupAtkCoeff = resolveGroupAtkCoeff;
  window._resolveGroupHitCount = resolveGroupHitCount;
  window._getKOValue = getKOValue;
  window._depRanks = depRanks;
  window._skillRanks = skillRanks;
  window._selectSkill = selectSkill;
  window._getUsedPlayerStatKeys = getUsedPlayerStatKeys;
  window._monsterStats = MONSTER_STATS; window._mountMonsterStats = mountMonsterStats;
  window._getRenderedHeroHtml = () => displayEl.innerHTML;
  window._statInputs = { atk: atkEl, tal: talEl, lck: lckEl, enemyLck: enemyLckEl, enemyDef: enemyDefEl, lv: lvEl };
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
          sandbox._selectSkill(sk);
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
              if (!failures.has(sk.id)) failures.set(sk.id, `rank ${r}${where}${depsOff ? " (deps off)" : " (deps on)"}${profile ? " (high stats)" : ""}: displayed ${fin[0]}-${fin[1]} but rolled ${lo}-${hi}`);
            }
          });
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
    const m = html.match(/const CLASS_STORY_ART = (\{[^\n]*\});/);
    const storyArt = m ? JSON.parse(m[1]) : {};
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
// 3m. effectProc purple mix (2026-09-24, GEMINI.md "effectProc"): Wall Puncture replace-roll rate and rank-0 off,
// Megalodon's purple Pull group, every bonus amount, and the gold total digits.
let checkedEffectProc = 0;
{
  const ep = sandbox._effectProc, inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedEffectProc++; if (!ok) { console.error(`[EFFECTPROC ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  for (let i = 0; i < 10; i++) check(`gold digit dmgdigit_y${i} present`, String(SKILL_ICONS["dmgdigit_y" + i] || "").startsWith("data:image/png"));
  const byId = id => SKILLS.find(s => s.id === id);
  const savedLck = inputs.lck.value, savedDeps = Object.assign({}, deps);
  const purpleRate = (sk, n, gi) => { let p = 0; for (let i = 0; i < n; i++) { sandbox._rollOneHit(sk, sk.maxRank, undefined, false, gi); if (ep.lastPurple()) p++; } return p / n; };
  const sweep = byId("whale_sweep");
  sandbox._skillRanks[sweep.id] = sweep.maxRank; sandbox._selectSkill(sweep);
  deps.wallPuncture = 0; check("Wall Puncture 0 never procs", purpleRate(sweep, 500) === 0);
  inputs.lck.value = "150"; deps.wallPuncture = 4;
  const expected = sandbox.lckAdjustChance(40, 150) / 100, rate = purpleRate(sweep, 4000);
  check(`Wall Puncture 4 @ LCK 150 proc rate ~${expected}`, Math.abs(rate - expected) < 0.04, rate.toFixed(3));
  // Whale Combo (Whale.cs:16238-16394): one Wall Puncture roll per swing; a proc replaces the hit with Effect Damage and skips getCritPlus (effectProc.noCrit).
  const wc = byId("whale_nAttack");
  sandbox._skillRanks[wc.id] = 2; sandbox._selectSkill(wc);
  deps.wallPuncture = 4; deps.whaleGearWeapon = 2; deps.whaleGearEquip = 2; inputs.lck.value = "300";
  { let purple = 0, purpleCrit = 0, whiteCrit = 0; for (let i = 0; i < 3000; i++) { sandbox._rollOneHit(wc, 2, undefined, false, 0); if (ep.lastPurple()) { purple++; if (ep.lastCrit()) purpleCrit++; } else if (ep.lastCrit()) whiteCrit++; }
    check("Whale Combo: Wall Puncture procs happen", purple > 0, purple);
    check("Whale Combo: a purple Wall Puncture hit never crits", purpleCrit === 0, purpleCrit);
    check("Whale Combo: white hits still crit with Champion gear", whiteCrit > 0, whiteCrit); }
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
    check("Colossal Weapon 2: splash line shown with Stage 1", on.includes('data-role="splash-line"') && /Stage 1 <span class="dmg-effect">\d/.test(on));
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
  deps.shadowFist = 4; deps.spiritFist = 1; check("Shadow Fist 4 + Spirit Fist at Lv 100 = 12 + 16", ep.bonus(wm, 1, 100) === 28, ep.bonus(wm, 1, 100));
  deps.shadowFist = 0; check("Shadow Fist 0, no bonus", ep.bonus(wm, 1, 100) === 0, ep.bonus(wm, 1, 100));
  // Cat Open Wound (#443): 30 x (target disarm Lv + bleed Lv) per landed hit, gated by the passive; hit-number gating (Cat.cs:10404, 17390-17507, 38717-39031).
  const ow = byId("cat_flyingDagger"), fbl = byId("cat_finishingBlow"), cmb = byId("cat_nAttack");
  deps.openWound = 1;
  check("Open Wound on = 30 x (Disarm 2 + Bleed 2) = 120 per hit", ep.bonus(ow, 1, 0) === 120, ep.bonus(ow, 1, 0));
  deps.openWound = 0; check("Open Wound off, no bonus", ep.bonus(ow, 1, 0) === 0, ep.bonus(ow, 1, 0));
  check("Open Wound is one toggle: no separate target Disarm/Bleed deps", !sandbox.SKILLS.some(s => s.effectProc && s.effectProc.controls && s.effectProc.controls.some(d => /^catTarget/.test(d.id))));
  check("Finishing Blow carries the bonus on hit 3 only", [0, 1, 2, 3].map(i => ep.hitOk(fbl, 1, i)).join() === "false,false,true,false", [0, 1, 2, 3].map(i => ep.hitOk(fbl, 1, i)).join());
  check("a card without effectProc.hits carries it on every hit", ep.hitOk(ow, 1, 0) && ep.hitOk(ow, 1, 2));
  deps.catComboHidden = 0; check("Combo without Hidden Blade: Open Wound on all 6 hits", [0, 1, 2, 3, 4, 5].every(i => ep.hitOk(cmb, 3, i)));
  deps.catComboHidden = 3; check("Combo with Hidden Blade: stage 2 hit has no Open Wound", [0, 1, 2, 3, 4, 5].map(i => ep.hitOk(cmb, 3, i)).join() === "true,false,true,true,true,true");
  inputs.lck.value = savedLck;
  Object.keys(deps).forEach(k => delete deps[k]); Object.assign(deps, savedDeps);
}
// 3n. Test button (2026-09-24 redesign): Thai labels per kind, starburst vs cross icon, "×N ฮิต" count only when
// there is one, the small per-mode variant, and the rendered main button on a multi-hit card.
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
  check("a multi-hit card renders the main Test button with its hit count", hero.includes('data-role="simulate-hit"') && hero.includes("×10 ฮิต"));
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
{
  const ep = sandbox._effectProc, inputs = sandbox._statInputs, deps = sandbox._depRanks;
  const check = (label, ok, got) => { checkedWolfCombo++; if (!ok) { console.error(`[WOLF COMBO ERROR] ${label}${got !== undefined ? `: got ${got}` : ""}`); errorCount++; } };
  const sk = SKILLS.find(s => s.id === "wolf_nAttack");
  const IDS = ["wolfFeralInstinct", "wildHeart", "wolfDarkEdgeOn", "wolfGearWeapon", "wolfGearEquip", "wolfKatana"];
  const savedDeps = IDS.map(id => [id, deps[id]]);
  const saved = { atk: inputs.atk.value, lck: inputs.lck.value };
  const setDeps = (o) => IDS.forEach(id => { deps[id] = o[id] || 0; });
  const select = (r) => { sandbox._skillRanks[sk.id] = r; sandbox._calcRangeFor = undefined; sandbox._finalRangeForRange = undefined; sandbox._selectSkill(sk); };
  check("Combo card has critProc, effectDamageDep and dmgControls", !!(sk && sk.critProc && sk.effectDamageDep && sk.dmgControls && sk.dmgControls.length === 6));
  // Coefficients: Feral 4 + Wild Heart = level 5 -> 0.75 / 0.6 / 0.9 (Wolf.cs:15144, :17386, :17717).
  setDeps({ wolfFeralInstinct: 4, wildHeart: 1 }); select(3);
  const coeffs = sk.dmgGroups.map(g => Math.round(sandbox._resolveGroupAtkCoeff(sk, g) * 1000) / 1000).join(",");
  check("Feral 4 + Wild Heart coefficients", coeffs === "0.75,0.75,0.75,0.6,0.9", coeffs);
  setDeps({}); select(3);
  const c0 = sk.dmgGroups.map(g => Math.round(sandbox._resolveGroupAtkCoeff(sk, g) * 1000) / 1000).join(",");
  check("Feral off coefficients", c0 === "0.5,0.5,0.5,0.4,0.6", c0);
  setDeps({ wolfFeralInstinct: 0, wildHeart: 1 }); select(3);
  check("Wild Heart without Feral Instinct adds nothing", sk.dmgGroups.every(g => sandbox._resolveGroupAtkCoeff(sk, g) === (g.label.includes("first") ? 0.4 : g.label.includes("second") ? 0.6 : 0.5)));
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
  [[{ wolfGearWeapon: 1, wolfGearEquip: 1 }, 12], [{ wolfGearWeapon: 2, wolfGearEquip: 2 }, 18]].forEach(([o, base]) => {
    const want = sandbox.lckAdjustChance(base, 150) / 100, got = rate(o, 4000).c;
    check(`${JSON.stringify(o)} crit rate ~${want} @ LCK 150`, Math.abs(got - want) < 0.03, got.toFixed(3));
  });
  check("Dark Edge off is white", rate({}, 200).p === 0);
  check("Dark Edge on is always purple", rate({ wolfDarkEdgeOn: 1 }, 200).p === 1);
  check("Test total digits turn purple with Dark Edge", html.includes('const digitColor = selected.isHeal ? "g" : (skillEffectDamageOn(selected) ? "p" : plainColor);'));
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
    [0, 2, 4].forEach(f => [0, 1].forEach(wh => [0, 1].forEach(de => [{}, { wolfGearWeapon: 1, wolfGearEquip: 1 }, { wolfGearWeapon: 2, wolfGearEquip: 2 }, { wolfGearEquip: 2 }].forEach(gearO => [0, 1].forEach(kt => {
      const gear = Object.keys(gearO).map(k => k + gearO[k]).join("+");
      const o = { wolfFeralInstinct: f, wildHeart: wh, wolfDarkEdgeOn: de, wolfKatana: kt, ...gearO };
      setDeps(o);
      for (let r = 1; r <= 3; r++) {
        select(r);
        sk.dmgGroups.forEach((g, gi) => {
          if (sandbox._resolveGroupHitCount(sk, g) === 0) return;
          const fin = sandbox._finalRangeForRange(sandbox._calcRangeFor(g.dmg, sandbox._resolveGroupAtkCoeff(sk, g), g));
          let lo = Infinity, hi = -Infinity;
          for (let i = 0; i < 400; i++) { const x = sandbox._rollOneHit(sk, r, undefined, false, gi); lo = Math.min(lo, x); hi = Math.max(hi, x); }
          check(`range/sim rank ${r} ${g.label} feral ${f} wh ${wh} de ${de} gear ${gear || "none"} katana ${kt} atk ${atk}`, lo >= fin[0] && hi <= fin[1], `${lo}-${hi} vs ${fin[0]}-${fin[1]}`);
        });
      }
    })))));
  });
  inputs.atk.value = saved.atk; inputs.lck.value = saved.lck;
  savedDeps.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
}
console.log(`Verified ${checkedWolfCombo} Wolf Combo (Feral Instinct / gear crit / Dark Edge) checks.`);
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
{
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
    setDeps(o); const want = sandbox.lckAdjustChance(base, 150) / 100, got = rate(combo, 1, 5000);
    check(`Combo crit rate ~${want} with base ${base} @ LCK 150`, Math.abs(got - want) < 0.03, got.toFixed(3));
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
  check("Extravagance is flagged on the nine ATK-based offensive skills and nowhere else in Rabbit", EXTRA_CARDS.every(s => s && s.extravagance === true) && SKILLS.filter(s => s.class === "Rabbit" && s.extravagance).length === 9);
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
  check("Onslaught is direct damage with a hate input and no TTO toggle", on.bisonHateInputs === true && on.penetrating === true && !sandbox._usesTdlRoll(on));
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
  const EXPECTED_CRIT_CARDS = ["bison_nAttack", "chameleon_leftStride", "chameleon_nAttack", "mole_nAttack", "panda_nAttack", "rabbit_nAttack", "sheep_bookBash", "sheep_nAttack", "whale_nAttack", "wolf_nAttack"];
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
  ["rabbit_cAttack", "cat_nAttack", "wolf_provoke", "bison_cAttack"].forEach(id => check(`${id} has no crit view button`, !heroOf(id).includes('data-role="crit-view"')));
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
    const CHM = ["criticalPlus", "fatalStrike", "chmGearWeapon", "chmGearMantis", "piercingVenom", "chmTargetPoison", "bowMastery"];
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
    savedChm.forEach(([id, v]) => { if (v === undefined) delete deps[id]; else deps[id] = v; });
    cv.set(false);
  }
  cv.set(true); check("crit view does not change a card that has no crit", !heroOf("rabbit_cAttack").includes("⌊") && !heroOf("cat_nAttack").includes("⌊"));
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
    if (lck === 255 && hi < fin[1] * 0.85) casinoFail(`range max not reachable: ${tag}`); else checkedCasino++;
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
  const dmgCats = SKILLS.filter(s => s.class === "Cat" && (s.dmg || s.dmgGroups || s.comboModel));
  const savedPower = sandbox._depRanks.catPower;
  for (const sk of dmgCats) {
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
  if (!/sk-tip-red[^>]*>เฉพาะฮิตที่ 3</.test(heroOf(fbl, "og"))) fail("cat_finishingBlow: Open Wound line must say hit 3 only in red"); else checkedCatPowerTto++;
  const cmb = SKILLS.find(s => s.id === "cat_nAttack");
  const cmbHtml = heroOf(cmb, "og").replace(/<span class="sk-nobr">([^<]*)<\/span>/g, "$1");   // loanword glue is markup only
  if (!cmbHtml.includes("เพิ่มเติมทุกฮิต") || !cmbHtml.includes("ฮิตที่ 2 จะไม่ติดดาเมจม่วง")) fail("cat_nAttack: Open Wound line must say every hit and that stage 2 after a Hidden Blade backstab gets no purple damage"); else checkedCatPowerTto++;
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
  for (const sk of SKILLS.filter(s => sandbox._usesTdlRoll(s) && !needsVars(s))) {
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
// TTO Magic Damage (TTO_MAGIC_DMG): on TTO a magic card at enemy DEF 2n-1 must equal the same card at DEF n with
// the magic rule off (half DEF rounded up), and BB must ignore the rule. Every listed id must be a real card.
{
  const fail = (msg) => { console.error(`[TTO MAGIC ERROR] ${msg}`); errorCount++; };
  const ins = sandbox._statInputs, magic = sandbox._ttoMagic.ids;
  const saved = [ins.atk.value, ins.tal.value, ins.lck.value, ins.enemyLck.value, ins.enemyDef.value];
  ins.atk.value = "200"; ins.tal.value = "80"; ins.lck.value = "0"; ins.enemyLck.value = "0";
  for (const id of magic) if (!SKILLS.some(s => s.id === id)) fail(`${id} is in TTO_MAGIC_DMG but has no card`);
  // Test popup draws magic hits with the aqua digit set
  for (let n = 0; n < 10; n++) if (!/^data:image\/png;base64,iVBORw0KGgo/.test(SKILL_ICONS["dmgdigit_a" + n] || "")) fail(`aqua digit texture dmgdigit_a${n} missing or not a PNG`);
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
      const magicRange = rangesAt(sk, "tto", 101);
      magic.delete(sk.id);
      const halfRange = rangesAt(sk, "tto", 51), fullRange = rangesAt(sk, "tto", 101), bbOff = rangesAt(sk, "og", 101);
      magic.add(sk.id);
      if (magicRange !== halfRange) fail(`${sk.id} on tto: DEF 101 gives ${magicRange}, expected the DEF 51 range ${halfRange}`); else checkedTtoNoLck++;
      if (rangesAt(sk, "og", 101) !== bbOff) fail(`${sk.id}: the magic rule changes the BB range`); else checkedTtoNoLck++;
      if (magicRange !== fullRange) halved++;
    } catch (e) { magic.add(sk.id); fail(`${sk.id}: range threw ${e.message}`); }
  }
  // Guards the sweep: if no card's range moves with DEF, the comparison above proves nothing.
  if (halved < 20) fail(`only ${halved} magic cards move with enemy DEF, so the half-DEF sweep proves nothing`);
  // Dep-gated magic (ttoMagicDep: Gyro shots with Synchro Mole): with the dep on, TTO DEF 101 must equal the same card
  // with the field removed at DEF 51; with it off, the field must change nothing.
  const gated = SKILLS.filter(s => s.ttoMagicDep);
  if (!gated.some(s => s.id === "mole_autoGyroGun_nAttack")) fail("mole_autoGyroGun_nAttack lost its ttoMagicDep (Synchro Mole)");
  for (const sk of gated) {
    const dep = sk.ttoMagicDep, savedRank = sandbox._depRanks[dep.id];
    const plainAt = (def) => { delete sk.ttoMagicDep; try { return rangesAt(sk, "tto", def); } finally { sk.ttoMagicDep = dep; } };
    sandbox._skillRanks[sk.id] = sk.maxRank || 1;
    try {
      sandbox._depRanks[dep.id] = dep.maxRank;
      const on = rangesAt(sk, "tto", 101);
      if (on !== plainAt(51)) fail(`${sk.id}: ${dep.id} on, TTO DEF 101 should match half DEF`); else checkedTtoNoLck++;
      if (on === plainAt(101)) fail(`${sk.id}: DEF does not move the range, the check proves nothing`); else checkedTtoNoLck++;
      sandbox._depRanks[dep.id] = 0;
      if (rangesAt(sk, "tto", 101) !== plainAt(101)) fail(`${sk.id}: ${dep.id} off, TTO should use full DEF`); else checkedTtoNoLck++;
    } catch (e) { fail(`${sk.id}: range threw ${e.message}`); }
    if (savedRank === undefined) delete sandbox._depRanks[dep.id]; else sandbox._depRanks[dep.id] = savedRank;
  }
  console.log(`Verified TTO Magic Damage: ${magic.size} listed skills, ${halved} damage cards hit against half DEF, ${gated.length} dep-gated.`);
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
    const txt = (d, r) => typeof d === "function" ? d(r, 0) : d;
    for (const sk of SKILLS) if (sk.servers) for (const srv in sk.servers) {
      const d = sk.servers[srv].desc; if (!d) continue;
      let differs = false;
      for (let r = 1; r <= (sk.maxRank || 1) && !differs; r++) { try { differs = txt(d, r) !== txt(sk.desc, r); } catch (e) { differs = true; } }
      if (!differs) { console.error(`[SERVER DESC ERROR] ${sk.id}: servers.${srv}.desc is identical to the base desc at every rank (a ttoDesc phrase swap no longer matches?)`); errorCount++; }
      else checkedDepStrip++;
    }
  }
  // 7. every card except the "sup_" support skills and mount items (mount:true, no skill number) has an internal skill ID
  //    (new cards need an entry in SKILL_INTERNAL_ID)
  {
    const table = vm.runInContext("SKILL_INTERNAL_ID", sandbox);
    const missing = SKILLS.filter(s => table[s.id] === undefined && !String(s.icon || "").startsWith("sup_") && !s.mount).map(s => s.id);
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
// BB / TTO follow Chameleon_nAttack.cs:517-668 (G.Marshal Bow +4, Mantis R set 5/4/3); ToT is the user-reported fix
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
    ok(reg.get("#chmArmDesc").textContent === "+6% Critical Chance", "ToT Champion Armor desc +6%");
    const totSet = now();
    n = popups.length; click("og");
    ok(popups.length === n, "BB opens no popup");
    ok(now() === bbSet, `BB gear restored after a ToT visit (${now()} vs ${bbSet})`);
    click("tot"); ok(now() === totSet, `ToT gear restored (${now()} vs ${totSet})`);
    n = popups.length; click("tto");
    ok(popups.length > n && popups[popups.length - 1].innerHTML.includes("Tailstopia Online (TTO)"), "TTO opens its popup");
    click("og");
  } catch (e) { fail("simulator threw: " + e.message); }
  Object.assign(doc, { addEventListener: saved.add, removeEventListener: saved.rem, createElement: saved.ce, body: saved.body });
}
console.log(`Verified ${checkedChmSim} Chameleon simulator checks.`);

// Server changes page (mountServerChanges): one row per card with a servers.<srv>.changeNote, chips rendered,
// a row opens #skill-details/<id>?server=<srv>, inline status / skill links do not navigate.
{
  const fail = (msg) => { console.error(`[SERVER PAGE ERROR] ${msg}`); errorCount++; };
  let checked = 0;
  const reg = new Map();
  const mk = () => { const e = makeEl(); e.listeners = {}; e.addEventListener = (t, fn) => { e.listeners[t] = fn; }; e.querySelectorAll = () => []; return e; };
  const root = mk(); root.querySelector = (sel) => { if (!reg.has(sel)) reg.set(sel, mk()); return reg.get(sel); };
  const savedHash = sandbox.location && sandbox.location.hash;
  if (!sandbox.location) sandbox.location = { hash: "" };
  try {
    vm.runInContext("mountServerChanges", sandbox)(root);
    const api = root._serverChanges, list = reg.get('[data-role="list"]');
    for (const srv of ["tto", "tot"]) {
      api.setServer(srv);
      const want = SKILLS.filter(s => { const o = (s.servers && s.servers[srv]) || (srv === "tot" ? s.ps : null); return o && o.changeNote; }).length;
      const rows = (list.innerHTML.match(/class="svc-item"/g) || []).length;
      if (rows !== want || want === 0) fail(`${srv}: ${rows} rows, want ${want}`); else checked++;
      if (!/sk-tag-(buff|nerf|adjust|fix)/.test(list.innerHTML)) fail(`${srv}: no change-note chips rendered`); else checked++;
    }
    const row = { dataset: { skill: "wolf_counter" } };
    list.listeners.click({ target: { closest: (sel) => sel === ".svc-item" ? row : null } });
    if (sandbox.location.hash !== "#skill-details/wolf_counter?server=tot") fail(`row click sets hash ${sandbox.location.hash}`); else checked++;
    sandbox.location.hash = "";
    list.listeners.click({ target: { closest: (sel) => sel.includes(".sk-status") ? {} : row } });
    if (sandbox.location.hash !== "") fail("clicking a status inside a note navigated away"); else checked++;
  } catch (e) { fail("page threw: " + e.message); }
  if (savedHash !== undefined) sandbox.location.hash = savedHash;
  console.log(`Verified ${checked} server changes page checks.`);
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

// Monster stats page (MONSTER_STATS, decoded from 12TailsOnline_Data): renders one table row per entry, every row is
// within the decoder's sane ranges, and First Whale still equals the hand-verified enemy preset.
{
  const fail = (m) => { console.error(`[MONSTER STATS ERROR] ${m}`); errorCount++; };
  const M = sandbox._monsterStats;
  if (!Array.isArray(M) || M.length < 300) fail(`expected 300+ rows, got ${M && M.length}`);
  else {
    M.forEach((r, i) => { if (r.length !== 20 || r[3] < 0 || r[3] > 999 || r[2] < 0 || r[2] > 6 || r.slice(4, 17).some(v => !Number.isInteger(v) || v < 0 || v > 500000)) fail(`row ${i} (${r[0]}) out of range`); });
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
      shown = sandbox._getRenderedHeroHtml().includes('<span class="sk-tooltip-note">ⓘ คำอธิบายในเกมไม่ตรงกับโค้ด: ');
    }
    if (!shown) { console.error(`[TOOLTIP NOTE ERROR] ${sk.id}: tooltipNote set but no styled line rendered at any rank`); errorCount++; }
    else checkedTip++;
  }
  console.log(`Verified ${checkedTip} tooltipNote lines (and no inline tooltip lines in any desc).`);
}
console.log("=== AUDIT SUMMARY ===");
if (errorCount === 0) {
  console.log(`SUCCESS: All ${SKILLS.length} skills, ${checkedFormulas} formula permutations, ${checkedLckFloors} LCK-floor checks, ${checkedGaosHeroRouting} Gaos render checks, and ${Object.keys(SKILL_ICONS).length} icons passed 100% of automated integrity checks!`);
} else {
  console.error(`FAILED: Found ${errorCount} error(s). Please fix before committing.`);
  process.exit(1);
}
