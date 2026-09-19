# Wolf — Skill Damage & Mechanics Reference

## Server Balance Variations (ToT)

Private-server values are documented from the Bible skill-detail schema; BigBug source remains the original-server baseline.

| Skill | Original BigBug baseline | ToT delta |
|---|---|---|
| Cross Break | KO is 5 / 10 / 15 by rank. | KO increased to 10 / 20 / 30. |
| Grand Cross | 120s base cooldown. | Base cooldown reduced to 60s. |

Source of server deltas: `12t_projects/bible/index.html:10761,10769`.

## Class-C Passives

Class-C (Lv.5) passive-only skills are documented here even though they have no cooldown row in [wolf-skill-reference.md](wolf-skill-reference.md). Only Fortitude is written up so far; `continuousBlade5`, `skySlasher5`, `sublimeArt5`, `gloriousSpirit5`, `lawBringer5`, `bloodFang5` and `wildHeart5` still need their own entries.

### wlf_fortitude5 (421) — passive

- `WolfSkill.cs:955-` (`mode = eSkillMode.passive`, no `cType`), `setReq(70, 3)` → reqLv 70, reqBn 3, MP 0, SP 0. Flavor text: "Passively decreases the duration of the all negative status on Wolf by 25%." (`WolfSkill_eng.cs:895`).
- Effect lives in the shared base class, not `Wolf.cs` (the only `hasSkill(421)` in the source is here): `CharacterControl.cs:13421-13434`, inside `RPC_AddStatus`, in the same `if (this.Type == "Wolf")` block (L13379) as Perseverance:

```csharp
if (this.hasSkill(421))
{
    if (StatusData.isDebuffStatus(sType))
    {
        sTime = Mathf.CeilToInt(0.75f * (float)sTime);
    }
}
```

- `this` is the character *receiving* the status, so every debuff applied to a Wolf who knows Fortitude has its duration cut to `⌈0.75×sTime⌉`, whichever skill or source applied it. The check is nested in the Wolf-only block, so other classes' slot-421 skills (e.g. Penguin's Focus Intellect) do not get it.
- Order within `RPC_AddStatus`: the Perseverance buff-duration bonus (`hasSkill(121/122)`, `L13385-13419`, buffs only) runs first, then Fortitude; Perseverance is gated on `isBuffStatus` and Fortitude on `isDebuffStatus`.
