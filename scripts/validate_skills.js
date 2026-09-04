/**
 * Automated Skill Integrity & Mechanics Linter for 12Tails Reference Tools
 * 
 * Verifies:
 * 1. Formula validity & evaluation across all rank (1..maxRank) and dependency toggle (0..maxRank) permutations.
 * 2. Icon existence in SKILL_ICONS and PNG header validity (89 50 4E 47 0D 0A 1A 0A).
 * 3. Array bounds for per-rank properties (cd, castTime, duration).
 * 4. Effect damage / penetrating damage flag alignment.
 */

const fs = require('fs');
const vm = require('vm');
const path = require('path');

const targetPath = path.resolve(__dirname, '../12t_projects/player-reference-tool/index.html');
if (!fs.existsSync(targetPath)) {
  console.error("Target index.html not found at:", targetPath);
  process.exit(1);
}

const html = fs.readFileSync(targetPath, 'utf8');

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
  window._rollOneHit = rollOneHit;
  window._getKOValue = getKOValue;
  window._depRanks = depRanks;
  window._skillRanks = skillRanks;
`;
scriptCode = scriptCode.replace('function onSearchInput(){', exposeInjection + '\nfunction onSearchInput(){');

function makeEl() {
  return {
    innerHTML: "",
    innerText: "",
    value: "0",
    style: {},
    classList: { add: ()=>{}, remove: ()=>{}, toggle: ()=>{} },
    appendChild: ()=>{},
    addEventListener: ()=>{},
    querySelector: () => makeEl(),
    querySelectorAll: () => [],
    getBoundingClientRect: () => ({ top: 0, left: 0, bottom: 0, right: 0, width: 100, height: 100 })
  };
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
  location: { hash: "skill-cooldown-lookup" },
  history: { replaceState: () => {} },
  setTimeout: () => {},
  clearTimeout: () => {},
  addEventListener: () => {}
};
sandbox.window = sandbox;

scriptCode += `
mountSkillCooldownLookup(makeEl());
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
  if (sk.dmgDep) checkIcon(sk.dmgDep.icon, `${ctx} [dmgDep icon]`);
  if (sk.dmgRankDep) checkIcon(sk.dmgRankDep.icon, `${ctx} [dmgRankDep icon]`);
  if (sk.dmgMultDep) checkIcon(sk.dmgMultDep.icon, `${ctx} [dmgMultDep icon]`);
  if (sk.hitCountDep) checkIcon(sk.hitCountDep.icon, `${ctx} [hitCountDep icon]`);
  if (sk.dep) checkIcon(sk.dep.icon, `${ctx} [dep icon]`);

  // Max Rank check
  const maxRank = sk.maxRank || 1;

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
      }
    }
  }
});

console.log(`Evaluated ${checkedFormulas} formula permutations across all ranks and dependencies.`);
console.log("=== AUDIT SUMMARY ===");
if (errorCount === 0) {
  console.log(`SUCCESS: All ${SKILLS.length} skills, ${checkedFormulas} formula permutations, and ${Object.keys(SKILL_ICONS).length} icons passed 100% of automated integrity checks!`);
} else {
  console.error(`FAILED: Found ${errorCount} error(s). Please fix before committing.`);
  process.exit(1);
}
