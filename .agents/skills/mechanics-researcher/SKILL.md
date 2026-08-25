---
name: mechanics-researcher
description: Use when investigating 12TailsOnline game mechanics, skill formulas, damage/heal/status calculations, or hidden multipliers from DecompiledSource/.
---

# 12 Tails Mechanics Researcher Skill

## Purpose
Investigate and trace verified game mechanics directly from `DecompiledSource/` rather than trusting in-game tooltips (which are frequently inaccurate).

## Source Reading Heuristics
1. **Metadata vs Cast-Site:**
   * `*Skill.cs` only contains UI tooltip strings, costs, and requirements — **never real damage multipliers**.
   * Real coefficients are hardcoded at the cast site inside `<Race>.cs` (or companion `<Race>_<skill>.cs`), where `nDamage` is computed before calling `hit(...)`.
2. **Fixed Combat Pipeline:**
   * Outgoing damage: `CharacterControl.hit(actionCode, tObject, nDamage, nKo, nHate, nForce)`.
   * Defense mitigation: `Damage.getDamage(mDamage, mDefense)` -> `mDamage * (1 - defense / (defense + 64))`.
   * Incoming damage & reductions: `RPC_AddDamage` / `AddDamage` (checks `getStatusLv(...)` for shields, drunkenness, percentage cuts).
   * Buffs & Status effects: `RPC_AddStatus(sType, sLv, sTime, sValue, sID)`.
3. **Citing Rules:**
   * Always cite extracted facts with exact `file:line` references.
