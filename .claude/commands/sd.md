---
description: Research and implement a 12 Tails Online skill into the Bible skill-detail tool. Usage: /sd <Class> <Skill Name>
argument-hint: <Class> <Skill Name>
---

# Skill Detail Research & Implementation Workflow (/sd)

This command was invoked with `/sd $ARGUMENTS`.

Execute the full **Skill Verification & Quality Assurance Pipeline** defined in `AGENTS.md` (Section 5) and `12t_projects/bible/GEMINI.md`:

---

## 1. Mandatory Pre-Flight Research (Zero Assumptions)
1. **Reference Review First:** Check `12t_reference/12Tails-Mechanics-Reference.md` and `12t_reference/<class>-skill-reference.md`.
2. **Cost / Mode / Requirements:** Run `python scripts/decode_skilldata.py DecompiledSource/<Class>Skill.cs` to verify exact MP/SP/reqLv/reqBn and SP type (`red` for consumed vs `blue` for threshold).
3. **Decompiled Code Trace:**
   - `<Class>.cs`: Cast dispatch (`RPC_<name>`), timeouts, cooldowns, cast times, damage calculations, and animation/voice handlers.
   - Companion scripts: `<Class>_<skill>.cs` (multi-hit loops, projectiles, summons, collision triggers).
   - Status effects: Trace `sType`, `sLv`, `nCode`, and verify exact classification in `StatusData.cs` (`isBuffStatus`, `isDebuffStatus`, `isStateStatus`, `isMagicalStatus`, `isPhysicalStatus`, `isLockStatus`, `isShieldStatus`).
   - Client Tooltips: Read raw in-game strings from `DecompiledSource/<Class>Skill_thai.cs` and `DecompiledSource/<Class>Skill_eng.cs`.
   - Multi-Rank Icons: Extract/verify rank-numbered icons from `RippedAssets/.../skills/<class>/` or `SKILL_ICONS` in `12t_projects/bible/index.html`.

---

## 2. Present Step 1 & 2 Observable Proof Review Table
Output a structured review table containing:
1. **Identity Mapping:** Internal source key, user-facing name (EN & TH), planned `SKILLS.id`, class, max rank, skill type.
2. **Source Code Proof & Citations:** Exact snippets and `file:line` references for dispatch, modifiers, hit loops, and status applications.
3. **Client In-Game Tooltips:** Thai and English tooltips cited from `*Skill_thai.cs` and `*Skill_eng.cs`.
4. **Proposed Header Description (`desc`):** Authentic client phrasing as baseline, qualitative over quantitative, dynamic highlights with `**bold**`, clear mention of hidden mechanics and verified geometries.
5. **Proposed Card Schema:** Complete `SKILLS` JavaScript object ready for `12t_projects/bible/index.html` (following `12t_projects/bible/GEMINI.md`).

---

## 3. Implementation & Validation (Upon User Confirmation)
1. Update card definition in `12t_projects/bible/index.html` using out-of-process Node patch scripts (adhering to `12t_projects/bible/GEMINI.md §1`).
2. Ensure reciprocal `compatSkills` links on all related skills.
3. Prepend planned commit subject to `CHANGELOG_DATA` in `index.html`.
4. Run `node scripts/validate_skills.js` to ensure 100% integrity pass before committing.
