# Monkey — Batch 2 Skill Research (DRAFT, pending user review)

> **Status: NOT verified ground truth.** This is raw research output moved here from a
> session-scoped temp scratchpad so it survives a `/clear` / new session, per user request
> (2026-09-15). Only item 1 (Runic Flame + Fire Rune) has actually been reviewed, approved, and
> applied to `12t_projects/bible/index.html`. Items 2-8 are unreviewed — do NOT treat any formula,
> desc text, or dep constant below as final until the user has gone through each one, the same way
> Runic Flame + Fire Rune already was (see AGENTS.md Section 5.C's single-skill review gate).
>
> **To resume in a fresh session:** tell Claude to read this file and continue the review one
> skill at a time, starting at the first `[ ]` (unreviewed) item below. Once a skill is approved
> and applied, flip its `[ ]` to `[x]` and note "APPLIED" the same way item 1 does, so future
> sessions know not to re-litigate it.
>
> Batch scope: Fire Rune + Runic Flame, World Ignition, Ground Lock, Gadina, Titan Sword, Aegis of
> Earth, Planet Breaker, Titanic Earth Pulse, Stone Hammer. (Stat Plus was dropped from this batch
> per user: it's a cross-class generic passive, out of scope for Monkey-specific research.)

Status legend: `[ ]` pending review, `[x]` approved, `[~]` needs rework

---

## [x] 1. Runic Flame (active, mnk_runicFlame1, maxRank 1) + Fire Rune (passive, mnk_fireRune1-3) -- APPROVED & APPLIED

### A) Runic Flame (Active)

**Naming correction:** the method literally named `RunicFlame()` at Monkey.cs:12377 is NOT the
cast handler — it's a per-frame movement tick (called from Update() at Monkey.cs:254, throttled
0.2s) that spawns flame-trail props while the buff is active. The real cast/status-apply logic is
in coroutine class `Monkey.$RPC_runicFlame$24553` (Monkey.cs:29301-29669).

| Field | Detail |
|---|---|
| Cast Dispatch | Monkey.cs:7986-8005 skill-tree switch -> StartCoroutine_Auto(RPC_runicFlame(pos,fwd,0)); net dispatch Monkey.cs:5559, opcode 264 |
| SkillClass metadata | MonkeySkill.cs:626-657 - setReq(40,24), setMP(30), mode=instant, target=self, cType="runicFlame" |
| Cooldown | Monkey.cs:29571 - addTimeOut("runicFlame", agiAdjust(180f)). agiAdjust (CharacterControl.cs:20575-20580): AGI_eff = agi + Random(0, ceil(0.2*LCK)); Cooldown = 180 * (1 - AGI_eff/(AGI_eff+128)) |
| Duration mechanic (non-obvious) | Consumes the Monkey's entire banked "sp" combo counter at cast. Monkey.cs:29442: RPC_AddStatus("runicFlame", 1, floor(sp*0.2), 0, ActorNr); then sp=0 at :29463. sp increments +1 per landed basic-attack hit (many sites e.g. 20055, 20669, 21365). |
| Cast anchoring | Coroutine state 0 (Monkey.cs:29562-29593): actionState="attack", myCommand="runicFlame", snap to mPos, LookAt, "runicCast" animation, moveSpeed=0 (rooted), voice clip |
| Tick execution | Monkey.cs:12377-12457, throttled 0.2s (PjiHlr3T1L). Requires hp>0 and hasStatus("runicFlame") (12402). Fires new trail segment only if moved >= sqrt(2.5) ~= 1.58 units since last tick. Segment life: tID = chaAdjust(5) (12431); chaAdjust (CharacterControl.cs:20593-20620): CHA_eff=clamp(cha+Random(0,ceil(0.2*LCK)),1,512); Life = 5*(1+0.015*CHA_eff) sec. Spawns Monkey_runicFlame prefab via RPC_runicFlame_fire -> Init(gameObject, char, tID) |
| Companion damage | Monkey_runicFlame.cs:207 OnTriggerEnter -> hit(1, obj, talAdjust(24), 0, 0, Vector3.zero). talAdjust (CharacterControl.cs:20624-20654): TAL_eff=clamp(tal+Random(0,ceil(0.2*LCK)),1,512); Damage = 24*(1+0.02*TAL_eff), through normal crit/dmgAdjust/enemy-DEF pipeline. nKo=0, nHate=0. Prop self-destructs after mLife or on owner death (Monkey_runicFlame.cs:27,106-109) |
| Status Profile | sType="runicFlame", nCode=904 (StatusData.cs:1427-1431, 3709-3718), sLv=1 fixed, sTime=floor(sp*0.2) sec (variable), sValue=0. isMagicalStatus=true (5771), isBuffStatus=true (6764). Confirmed false: isPhysicalStatus, isDebuffStatus, isStateStatus, isLockStatus, isShieldStatus, isSystemStatus |
| Tooltip ENG | MonkeySkill_eng.cs:521 - "Unleash a fire trail behind Monkey, burning any targets in its path. (24 dmg, -5sp/sec)" -- DISCREPANCY: source consumes sp once at cast (sp=0), not a per-second drain. Code wins. |
| Tooltip THAI | MonkeySkill_thai.cs:543 - same discrepancy noted |
| Icon | icons/skills/monkey/runicFlame1.png (only rank; runicFlame2-4.png exist as unused leftover assets, no rank-2+ dispatch exists) |
| Applied desc (Thai, FINAL) | "ใช้ SP ทั้งหมด สร้างกำแพงไฟตามเส้นทางที่ลิงวิ่งผ่าน แผดเผาศัตรูทุกครั้งที่สัมผัสกำแพงไฟ 24 ดาเมจต่อครั้ง ระยะเวลากำแพงไฟขึ้นอยู่กับปริมาณ SP ที่ใช้ไป" |

### B) Fire Rune (Passive, maxRank 3)

| Field | Detail |
|---|---|
| Rank hook | getFireRuneLv() Monkey.cs:12229-12269: hasSkill(263)->3, hasSkill(262)->2, hasSkill(261)->1, else 0 |
| Proc hook | FireRune() Monkey.cs:12273-12330. 1s internal cooldown gate (nRiHXQ83cT). fireRuneLv<=0 -> skip. Roll: Random(0,100) >= lckAdjust(12) -> skip (proc only if roll < threshold) |
| Proc chance formula | lckAdjust(12) (CharacterControl.cs:20658-20669): LCK_eff=clamp(lck,1,512); num=12*(1+0.01*LCK_eff); chance% = floor(100*num/(num-12+100)). At LCK=0: exactly 12% (tooltip claims 20% -- DISCREPANCY, code wins). At LCK=100: 21%. |
| Heal/restore formula | RPC_AddHeal(260+fireRuneLv, 0, 4*fireRuneLv, 4*fireRuneLv, 0, 0, ActorNr) (12306). Signature (CharacterControl.cs:7130): RPC_AddHeal(ActionCode, nHp, nMp, nSp, nKo, nHate, healerID). nHp=0. Rank1: 4 MP+4 SP; Rank2: 8+8; Rank3: 12+12. No KO/Hate change. |
| Trigger scope (CORRECTED post-apply, see below) | On-hit proc from far more than 3 sources -- see the "POST-APPLY CORRECTION" note. |
| Status Profile | None -- Fire Rune applies no status |
| Tooltip ENG | Rank1 MonkeySkill_eng.cs:488: "Gives Monkey 20% chance to restore 4 sp and 4 mp everytime he or his fire summon deals damage to any target." Rank2 :499 (8/8). Rank3 :510 (12/12). |
| Tooltip THAI | Rank1 MonkeySkill_thai.cs:510 (4/4), Rank2 :521 (8/8), Rank3 :532 (12/12) |
| Requirements | MonkeySkill.cs:604 setReq(22,12) for rank1. No setMP/mode/target calls for any rank -- confirms pure passive, no cast dispatch |
| Icon | icons/skills/monkey/fireRune1/2/3.png (matches 3-rank ceiling). fireRune.png/fireRune4.png exist but unused (no rank-4 hook) |
| Applied card | id "monkey_fireRune", maxRank 3, passive:true, lckProc:{label:"SP/MP Restore Chance", chance:12}. desc (Thai, FINAL, widened post-apply): (rank)=>"มีโอกาสคืน **${4*rank} SP** และ **${4*rank} MP** ทุกครั้งที่การโจมตีของลิงหรือสกิลต่างๆ ของลิงสร้างความเสียหายโดนเป้าหมาย โอกาสสำเร็จจะสูงขึ้นตามค่า LCK ของลิง" |

**Flagged corrections vs initial assumptions:**
1. RunicFlame() method = movement tick, not cast handler (cast is in $RPC_runicFlame$24553 coroutine)
2. Runic Flame duration = floor(sp*0.2) sec, NOT the tooltip's "-5sp/sec" drain
3. Fire Rune base proc chance = 12 (pre-lckAdjust), not tooltip's flat 20%
4. Fire Rune has NO dependency on "runicFlame" status -- procs unconditionally
5. Fire Rune's "fire summon" tooltip clause verified real via Phoenix_fireBall.cs:317

**POST-APPLY CORRECTION (user caught this):** the original research/applied desc claimed FireRune()
only procs from 3 sources (Monkey basic attack, Monkey's own fireball, Phoenix's fireball) --
mirroring the in-game tooltip's own incomplete "he or his fire summon" framing. Re-verified against
ALL 16 FireRune() call sites in Monkey.cs by mapping each line to its containing generated coroutine
class (internal sealed class $RPC_... boundaries):
- 20060, 20674 -> RPC_nAttack1/nAttack2 (basic attack) -- as expected
- 21370 -> RPC_cAttack1 (CHARGE ATTACK -- not previously identified)
- 26569 -> RPC_fireBall_cast (Monkey's own Fireball) -- as expected
- 28199 -> RPC_blazingArrow -- CONFIRMED by direct read (right after "burn" status apply + sp+=1)
- 28632 -> RPC_flashFire -- very likely real (same call pattern), not line-by-line read
- 35133 -> RPC_upheaval (unidentified skill)
- 36086, 36692 -> RPC_mikeBlink1/mikeBlink2
- 37127 -> RPC_fireKeep_cast
- 38557, 38963 -> textually inside RPC_phoenixArmor_cast/nAttack BUT line 40817's gate checks
  myCommand!="earthForm" -- these later coroutines are SHARED/REUSED across multiple transformation
  states, so simple line-range-to-class mapping breaks down here; exact attribution to Mike
  Blink/Fire Keep/Earth Form/Phoenix Armor/Gadina Armor specifically needs dedicated research into
  that rank-5 ultimate-passive tier (NOT part of this batch).
- 40817, 41299, 42007, 42530 -> textually inside RPC_gadinaArmor_cast/nAttack1/2/3 (same caveat as above)
Plus 2 external sites already known: Monkey_fireBall.cs:261, Phoenix_fireBall.cs:317.

CONCLUSION: Fire Rune procs off far more than 3 sources -- confirmed real additions are the charge
attack and Blazing Arrow (direct-read verified), very likely Flash Fire, and a cluster tied to
Monkey's rank-5 transformation ultimates that needs its own future research pass. Desc was widened
post-apply to "ทุกครั้งที่การโจมตีของลิงหรือสกิลต่างๆ ของลิงสร้างความเสียหายโดนเป้าหมาย" (whenever damage
from Monkey's attacks or various skills lands) instead of naming 3 specific sources. Applied +
validate_skills.js passing.

**Also applied this session, both already live in index.html (2026-09-15):**
- `jaOwnStats()` (Monkey's Ja summon) resolved from "?" placeholders to real hex-decoded values:
  ATK/DEF/AGI/VIT/MAG/TAL/LCK = 10/20/30/40 by rank, CHA = 20/20/60/80 (rank-2 anomaly is real, not
  smoothed). HP stays source-verified 100/200/300/400 (Ja.cs:1906-1972). Colorized via the existing
  "full accent color" override list (same treatment as the base Barrel Bot card), since no formula
  in this tool reads Ja's own stats (would otherwise render fully dimmed gray).
- `monkey_ja_detonate`'s desc corrected: KO clause changed from a flat `10*rank` framing to "10% of
  Ja's CURRENT HP" (Ja.cs:1594: `Mathf.FloorToInt(0.1f * mChar.hp)` as the `nKo` param of `hit()`,
  same call whose `nDamage` param is `hitDistance * mChar.hp` -- distance-falloff 0.5x-1.0x of
  current HP). The numeric display (10/20/30/40) is unchanged since it's still correct at max HP,
  but the wording no longer implies a fixed rank-locked constant.
- Investigated but found NO evidence for: "Ja is usually summoned at half HP" (user's own live
  observation) -- checked Ja.cs's summon coroutine (hp set directly to full literal, no halving
  before/after), confirmed mhp is never touched anywhere in Ja.cs, no decay-over-time code, no
  shared onSummon hook, no HP-cost-to-summon mechanic, tooltips don't mention it. Left open --
  worth re-raising if the user has more context (exact conditions observed) in a future session.

---

## [x] 2. World Ignition (active, mnk_worldIgnition1-2) -- APPROVED & APPLIED

**Executive correction:** this is NOT an AoE and does NOT fire "4 sequential hits." No
FindAreaTarget/OverlapSphere/radius exists anywhere in its code. It's single-target only (tID).
The 4 RPC_worldIgnition_hit1..hit4 network events are per-rank variants of ONE detonation event,
not multi-hit stages -- the "stage" arg is actually skill RANK (sLv), taken from the ignite status's
own sLv. Since only ranks 1-2 exist, hit3/hit4 are dead/unreachable code (verified by reading both
generated coroutines to their end -- no loop, no repeat-4x logic).

**Real mechanic = delayed-detonation DoT-threshold:**
1. Cast time 3+3*sLv sec (6s/9s base, magAdjust). Cooldown flat 300s both ranks (agiAdjust). MP/SP
   rank1 confirmed: 40 MP/30 SP (MonkeySkill.cs:661-677). **Rank2 RESOLVED (corrected twice --
   see below): 60 MP / 35 SP.** `MonkeySkill.cs:678-684`'s "mnk_worldIgnition2" branch itself is
   genuinely empty (its one junk predicate is false, so nothing executes inside it) -- but
   execution does NOT stop there. It falls through the surrounding obfuscated goto/label structure
   into a SHARED metadata block at `MonkeySkill.cs:1914-1934`: `setReq(40,25)`, `setMPSP(60,-35)`,
   `mode=target`, `target=enemy`, `cType="worldIgnition"`. Since `SkillClass.setMPSP`/`setReq` are
   idempotent guards (`SkillClass.cs:72-140`, only write if still at the zero/-1 default), this
   shared block is a no-op for rank1 (already set by its own branch at :661-677) but is the FIRST
   and ONLY place rank2's cost actually gets set.
   **First-pass mistake (mine):** concluded "0 MP / 0 SP" from the empty branch alone, without
   checking whether a later shared block was reachable -- wrong, caught by the user relaying an
   independent Codex trace.
   **Second-pass mistake (Codex's manual trace, ALSO not fully trusted):** correctly identified the
   real shared block and its line numbers, but manually eyeballing which `goto`/fallthrough path
   reaches it in a ~2300-line obfuscated function is exactly the kind of thing prone to silent
   error (this same file's own `IL_120F`/`IL_3469` labels are shared by MULTIPLE different skills'
   branches, e.g. `mnk_groundLock1` also jumps to `IL_120F` -- a manual trace has no easy way to
   prove no earlier `break`/`return` intercepts a given path before reaching line 1914).
   **Final verification: extracted `MonkeySkill.getSkill()` VERBATIM (all ~2292 lines, unedited
   control flow) into a standalone .NET 8 console app** (stubbed only the 2 irrelevant
   Unity/obfuscator no-op calls: `LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn()` and `base..ctor()`'s decompiler
   artifact), compiled and RAN it for real, calling `getSkill("mnk_worldIgnition2")` directly.
   Ground truth: `rLv=40 rBn=25 cMP=60 cSP=-35`. This is authoritative -- the actual C# runtime
   evaluated every junk predicate and goto for real, no manual eyeballing involved. Confirmed this
   is the real cast-time cost path (not just skill-tree display metadata): `Monkey.returnMPSP()`
   (`Monkey.cs:9535`) reads cost via `SkillData.getSkillMP/SP()` (`SkillData.cs:634-646`), which
   routes `"mnk_*"` names straight to `MonkeySkill.getSkill()` (`SkillData.cs:130`).
   **Same compiled-verification run also resolved Ground Lock's own long-flagged "MP cost scaling
   ranks 2-4 unverified" gap (see item 3 below) for free: 12/16/20 MP.**
2. On cast-bar completion, applies "ignite" status: `Damage.getDebuff(60, casterCHA, targetCHA)` ->
   `RPC_AddStatus("ignite", sLv, mDuration, sLv*400+400, ActorNr)` (`Monkey.cs:29902,29907`, inside
   `$RPC_worldIgnition_cast$24561`). Duration base 60s (CHA-contested). sValue = damage
   pool = 800 (rank1) / 1200 (rank2).
3. While ignited: target's hitMod += 0.1*sLv (+10%/+20% incoming damage taken from ALL sources, not
   just caster) -- reverted on status removal. Consumed in both RPC_AddDamage and RPC_AddEffectDamage.
4. Every direct hit (not DoT/effect damage) the ignited target takes drains the sValue pool
   (`CharacterControl.cs:31080`: `sValue -= nDamage`). When pool <= 0: status removed
   (`:31090,31102`), calls back into the owner Monkey's own script (`:31151`,
   `mOwnerMonkeyScript.RPC_worldIgnition_hit(...)`), which detonates on the same target:
   `RPC_AddEffectDamage(270+sLv, 400+sLv*400, 0, 0, Vector3.zero, ActorNr)` (`Monkey.cs:30257`) --
   i.e. explosion damage exactly equals the original pool threshold (800/1200).

Status: "ignite", nCode 905, isMagicalStatus=true, isDebuffStatus=true, NOT buff/physical/state/
lock/shield/system. Cannot be applied while target hasStatus("inferno"); casting "inferno" on an
ignited target force-removes both "doom" and "ignite".

Tooltip ENG/THAI both fully corroborated by code (10%/800dmg rank1, 1200dmg rank2, 60sec duration
stated explicitly in Thai) -- EXCEPT rank2's tooltip text still says "10% more damage" instead of
20%, a tooltip imprecision (code applies 0.1*sLv = 20% at rank2).

No passive dependencies found anywhere in the traced code paths (checked shared cast-time/cooldown
switch, both generated coroutines, and all "ignite" branches in RPC_AddStatus/addStatus/removeStatus/
AddDamage). Contrast: the neighboring "ja" cast-time case DOES check a passive (rapidFireLv) --
World Ignition genuinely has none.

**Thai name (`nameTha`):** no localized skill-NAME string exists anywhere in the decompiled `.cs`
files -- `MonkeySkill_thai.cs:550-561` only holds the Thai tooltip/description text, not a name
table. Used a transliteration, `"เวิลด์อิกนิชั่น"`, same convention as Runic Flame's `"รูนิกเฟลม"`.

**Applied desc (Thai, FINAL, user-specified `hitmod` wording over the original `%`-damage framing):**
`(rank)=>"เพิ่ม hitmod ให้เป้าหมาย **+" + (0.1*rank) + "** (รับความเสียหายเพิ่มขึ้นจากทุกแหล่งที่มา)
หากเป้าหมายได้รับความเสียหายสะสม **" + (400*rank+400) + "** ระหว่างติดไฟ จะระเบิดสร้างความเสียหายเพิ่มอีก
**" + (400*rank+400) + "** ส่งผลกับเป้าหมายเดียวเท่านั้น ไม่มีพื้นที่กระจาย ระยะเวลาติดไฟพื้นฐาน **60 วินาที**
ยาวขึ้นหรือสั้นลงตามค่า CHA ของผู้ร่ายเทียบกับเป้าหมาย"`

No `dmg`/`ko` field added -- the detonation isn't `talAdjust`-scaled at all (pure rank-based flat
value, no stat scaling), and the mechanic is a status-pool threshold trigger rather than a plain
hit, so it doesn't fit this tool's `dmg` formula shapes cleanly. Same "omit rather than
misrepresent" call as Mole's `detonate` (which had its own Damage Formula chip removed entirely for
the same reason). Applied to `index.html` (`monkey_worldIgnition`, `maxRank:2`,
`cost:{mp:[40,60],sp:[30,35]}` -- corrected post-apply, see the compiled-verification note above --
`castTime:[6,9]`, `cd:300`) + `node scripts/validate_skills.js` passing (334 skills / 446 formula
permutations / 782 icons -- rank-1 icon `monkey_worldIgnition1` extracted post-apply too, per the
AGENTS.md Multi-Rank Icon Completeness rule missed on first pass).

**Post-apply fix, same day (missing Duration chip):** the original applied entry had the ignite
debuff's 60s CHA-contested duration only described in prose inside `desc`, with no real `duration`/
`durWrapped`/`durContested` chip -- inconsistent with every other CHA-contested duration in this
tool (Ground Lock's own Duration chip below is the same shape). Fixed: added
`duration:60, durWrapped:true, durContested:true`, and trimmed the now-redundant duration sentence
out of `desc`.

**Post-apply fix, same day (Monkey array reordering):** user noticed Monkey's `SKILLS` entries
weren't ordered by real in-game skill ID. Extracted `MonkeySkill.getSkillTree()` (the commandNum ->
skillname switch) verbatim into a standalone .NET 8 app, same compiled-verification method as the
cost fixes above, and swept commandNum 1-999 for the complete real ID order. Found 2 local
swaps (fireRune/runicFlame, and skyCrimson's position relative to rapidFire/intenseFire) plus a
structural issue (every rank-5 "ultimate" skill scattered mid-array instead of grouped by their real
400-series IDs). Reordered all 33 Monkey entries to match via a bracket-depth-aware Node script (not
manual cut/paste) -- verified byte-length of the reordered block identical before/after (pure
permutation), `validate_skills.js` and a full-script `new Function()` syntax check both clean
afterward. Since `SKILLS_ORDERED = SKILLS` directly (`bible/CLAUDE.md`), this also fixes Monkey's
own arrow-key navigation order, a side effect of the class's own long-deferred "Known issues" item
in that same file. Scoped to Monkey only -- the other 11 classes are untouched.

**Post-apply fix, same day (Ja - Detonate's stat-glow override):** `monkey_ja_detonate` was
initially lumped into the same "full-accent, all 9 stats glow" override list as the base `monkey_ja`
summon card. User correction: Detonate's own real formula (`Ja.cs:1594`, `nDamage =
hitDistance*mChar.hp`, `nKo = floor(0.1*mChar.hp)`) reads ONLY Ja's current HP -- the other 8 stats
play no role in this specific skill. Fixed to a dedicated `new Set(["mhp"])` for
`monkey_ja_detonate` only; the base `monkey_ja` card keeps its own full-accent treatment unchanged
(it has no formula of its own to be selective about).

## [x] 3. Ground Lock (active, mnk_groundLock1-4) -- APPROVED & APPLIED

All 4 ranks share one generic RPC_cast("groundLock",...) -> RPC_groundLock_cast -> RPC_groundLock_hit
pipeline; only sLv differs (single-target, not AoE for the main hit).

| Field | Detail |
|---|---|
| Cast time | 2 + 0.5*sLv sec base (2.5/3.0/3.5/4.0), before magAdjust. Monkey.cs:25235 |
| Cooldown | 18 + sLv*3 sec base (21/24/27/30), before agiAdjust. Monkey.cs:25240 |
| MP cost | rank1 = 8 (MonkeySkill.cs:698). **Ranks 2-4 RESOLVED: 12/16/20 MP.** Verified by compiling and running the real `MonkeySkill.getSkill()` function verbatim in a standalone .NET 8 app (same method used to correct World Ignition's rank2 cost above -- see item 2's note for the full methodology) rather than manually tracing the obfuscated fallthrough. Ground truth for all 4 ranks: `rLv=3/11/19/27, rBn=0/1/2/3, cMP=8/12/16/20`. |
| Damage formula | talAdjust(sLv*8+12) -> rank1=20,2=28,3=36,4=44 pre-talAdjust (Monkey.cs:30608-30650). DISCREPANCY: tooltip says flat 24/32/40/48 (sLv*8+16) -- off by +4 from code. Code wins per AGENTS.md. |
| nKo=1, nHate=0, small upward knock (0.5*Vector3.up) | |
| Status | "groundLock", nCode 906. sLv = sLv_cast + (hasSkill(403) ? 2 : 0). isDebuffStatus=true, isMagicalStatus=true, isLockStatus=true (genuine root/immobilize). Not buff/state/shield/system. |
| Duration formula | Damage.getDebuff(3 + getAegisOfEarthLv(), casterCHA, targetCHA) (Monkey.cs:30608). Base 3s at Aegis rank0, 4/5/6s at Aegis rank 1/2/3 -- cross-checked against Aegis of Earth's OWN tooltip text which independently states the same 4/5/6 progression. Real mechanic, not decompiler noise. |
| Hidden dep #1 | Base duration silently reads Aegis of Earth's rank (a passive whose advertised purpose is buffing the Gadina summon's shield). Ground Lock's own tooltip never mentions this -- only Aegis of Earth's tooltip documents the side effect. |
| Hidden dep #2 | hasSkill(403) = "Second Stone" passive (mnk_secondStone5, requires Ground Lock rank 4 as prereq). Adds +2 to applied STATUS LEVEL (not +2 seconds -- English tooltip wrongly says "+2 seconds duration", Thai tooltip correctly says "+2 status"). Also unlocks a 2nd AoE tick ~3s later: hit(403, talAdjust(48), 10 KO, radius 0.5) via Damage.FindAreaTarget. |
| Landing hit | grants caster +1 sp (Monkey.cs:30650) |
| Tooltip ENG | MonkeySkill_eng.cs:554,565,576,587 -- "Call stone pillars... locking target for 3 seconds and dealing 24/32/40/48 damage." Static baseline only, ignores Aegis bonus and CHA scaling entirely. |
| Tooltip THAI | MonkeySkill_thai.cs:576,587,598,609 -- same static baseline |
| Proposed dep constants | MNK_GROUNDLOCK_AEGIS_DEP (durDep, formula 3+aegisRank); MNK_GROUNDLOCK_SECONDSTONE_DEP (dmgRankDep +2 status lvl, extraHitDep +48 dmg/10ko/0.5m radius @ 3s delay) |

**Flags for live-server verification:** Damage constant mismatch (code: sLv*8+12, tooltip: sLv*8+16)
-- worth an in-game check per AGENTS.md 3.4 (live observation overrides decompiled code on
conflict). (MP cost ranks 2-4 no longer flagged -- resolved above via compiled ground truth.)

**Applied, same day.** Both proposed dep constants built for real (icons `aegisOfEarth1/2/3` and
`secondStone5` freshly extracted from `RippedAssets`, byte-verified against source):
- `MNK_GROUNDLOCK_AEGIS_DEP` (`id:"aegisOfEarth"`, `minRank:0, maxRank:3, perRank:1`) -- wired as
  Ground Lock's Duration-chip `dep`, giving the real `3+aegisRank` base before the CHA contest.
  Standalone ahead of Aegis of Earth's own future card, same precedent as `GADINA_TITANSWORD_DEP`.
- `MNK_GROUNDLOCK_SECONDSTONE_DEP` (`id:"secondStone"`, 0/1 toggle) -- the status-level bump isn't
  modeled (no status-level display exists in this tool), but the delayed 2nd hit IS, as a new
  `dmgGroups` entry (`{dmg:"talAdjust(48)", hitCount:(rank,depOn)=>depOn?1:0, dep:...}`) that only
  renders once the passive is toggled on, per direct user instruction. This needed a small engine
  fix: `renderDmgFormula` and the Raw Damage chip's group-list both used to render every
  `dmgGroups` entry unconditionally regardless of its resolved hit count -- both now filter out any
  group whose `resolveGroupHitCount` is 0, a one-line change, harmless for every pre-existing
  `dmgGroups` skill (Napalm, King Kaiser Normal Attack, Rabbit Shooting Array, Chameleon Quick Fire)
  since none of them ever had a zero-hit group to begin with. Top-level `hitCount` set to
  `1+(hitCountDepOn?1:0)` (via `hitCountDep`) so it still sums correctly with the visible groups.
- `dmg`/`ko` fields added (`talAdjust(8×sLv+12)`, `ko:"1"`) -- previously absent from the stub.
- 4 rank icons (`groundLock1/2/3`, joining the pre-existing `groundLock4`) also extracted --
  another Multi-Rank Icon Completeness gap caught before shipping this time, not after.
- Applied to `index.html` + `node scripts/validate_skills.js` passing (334 skills / 450 formula
  permutations / 789 icons) + full-script `new Function()` syntax check clean.

**Post-apply fix, same day (missing status keyword badge):** the first apply omitted the `status`
field entirely -- a real gap, not a design choice, since Ground Lock's own status classification
(`isDebuffStatus=true, isMagicalStatus=true, isLockStatus=true`, per this section's own citation
above) was already fully researched and just never wired into the card. Fixed:
`status:{name:"groundLock", sLv:(rank,depRank)=>rank+(depRank?2:0), class:"Debuff, Magical, Lock"}`,
which renders the `[groundLockN]` clickable keyword badge in the desc (`renderHero`'s existing
`statusBadgeHtml` mechanism, unrelated to any dep-toggle chip). The `+2` from Second Stone needed
`descDep: MNK_GROUNDLOCK_SECONDSTONE_DEP` added too, since the badge's own `sLv` function only ever
receives `heroDepRank` (resolved from `descDep || dep || dmgRankDep || dmgDep || cdDep`, in that
priority order) -- without `descDep`, `heroDepRank` would have resolved to `dep` (Aegis of Earth)
instead, the wrong passive for this specific formula. Ground Lock's own `desc` function ignores its
2nd parameter entirely, so redirecting `heroDepRank` to Second Stone via `descDep` doesn't cost
anything elsewhere on this card.

**Also same day: AGENTS.md's passive-card exclusion rule relaxed.** Section 5.B.6 previously said
passive cards "MUST NEVER include cd/castTime/cost/duration/ko" -- corrected per direct user
instruction to "may carry these when the passive genuinely has one, but it's rare; don't add
speculatively." Doesn't change anything for Aegis of Earth/Second Stone below (neither needs any of
these fields), just closes a false absolute in the doc.

**New standing workflow, same day, added to `AGENTS.md` Section 5.C as Step 3.5:** when a skill
introduces a real dep pointing at another skill with no card of its own yet, proactively urge doing
that related skill next (even if passive, even if it was scoped to a later batch item) instead of
silently continuing down the pre-planned queue. Applied immediately to Ground Lock's own two new
deps -- see the ad-hoc Aegis of Earth + Second Stone entries below, done next instead of jumping to
Gadina (the original next item in this batch's queue).

## [x] 3a. Aegis of Earth (passive, mnk_aegisOfEarth1-3) -- APPROVED & APPLIED (done ahead of its
original batch slot in item 5 below, per the new skillDep-loop-closure workflow -- Titan Sword,
also originally part of item 5, is still pending)

Requirements compile-verified (`MonkeySkill.getSkill()`, same standalone .NET 8 harness as every
other cost fix this session): rLv/rBn = 9/3, 17/5, 25/7 for ranks 1-3. Pure passive, no cost.

Two real effects (both already cited in item 5's own research below, repeated here for this card's
own record): (1) Gadina's DEF+VIT bonus (`Gadina.cs:649-777`, `EquipShield`) -- flat DEF
+20/35/50 by rank (tooltip claims +20/40/60, code wins), plus VIT `+floor((0.1×rank+0.1)×MonkeyVIT)`
-> 20%/30%/40% of Monkey's own VIT, indirectly raising Gadina's `mhp=10×vit`. NOT modeled yet --
Gadina has no `SKILLS` card of its own (next item in the queue), so no `GADINA_AEGIS_DEP` exists
yet either; will need one when Gadina's own card is built. (2) Ground Lock's duration extension --
already fully modeled via `MNK_GROUNDLOCK_AEGIS_DEP` (applied with item 3 above).

Applied card: `passive:true`, `maxRank:3`, `compatSkills:["monkey_groundLock","monkey_secondStone"]`
(mutual cross-link, NOT the Gadina relationship since Gadina has no card yet and "these 3 skills"
per the user's own scoping meant Ground Lock/Aegis of Earth/Second Stone specifically -- see
AGENTS.md Section 8's revised policy allowing mutual `compatSkills` for a genuine skillDep cluster,
as an exception to the summon-hub main-skill-only rule). Desc (Thai, FINAL, user-specified wording):
`(rank)=>"เพิ่มค่า **+"+[20,35,50][rank-1]+" DEF** และ **+"+[20,30,40][rank-1]+"% VIT** ให้ Gadina
เพิ่มระยะเวลาตรึงขาพื้นฐานของ **Ground Lock** "+rank+" วินาที"`. Icons `aegisOfEarth1/2/3` extracted
fresh from `RippedAssets`, byte-verified.

## [x] 3b. Second Stone (passive, mnk_secondStone5, maxRank 1) -- APPROVED & APPLIED (NOT in the
original 8-item batch scope at all -- added ad hoc per the new skillDep-loop-closure workflow,
since Ground Lock's own review surfaced it as a real, uncarded dependency)

Requirements compile-verified: rLv/rBn=55/0, **rSkill=304** (a `SkillClass` field not previously
used elsewhere in this doc -- a hard prerequisite-skill-id gate, confirmed = Ground Lock rank 4 via
`MonkeySkill.getSkillTree()`'s own commandNum map, matching this passive's own tooltip-stated
prereq exactly). No cost, pure passive.

**Exhaustively confirmed self-contained**: grepped every `hasSkill(403)` site across `Monkey.cs`/
`MonkeySkill.cs` -- exactly 2 hooks total, both already found and modeled via Ground Lock's own
review (item 3 above): the `+2` status-level bump (`Monkey.cs:30619`, not modeled -- no status-level
display exists in this tool) and the delayed 2nd-hit `dmgGroups` entry (`Monkey.cs:31096/31153`,
modeled). Second Stone touches nothing else in the game.

**Tooltip cross-check, both languages re-read directly**: EN (`MonkeySkill_eng.cs:994`) says "Add 2
seconds to 'groundlock' duration" -- confirmed wrong (code adds status LEVEL, not seconds). TH
(`MonkeySkill_thai.cs:1016`) says "เพิ่มเลเวลของสถานะ+2... หลังจาก 3 วินาที (+10ko)" -- confirmed
correct, matches code exactly on all 3 numbers (+2 level, 3s delay, +10 KO).

Applied card: `passive:true`, `maxRank:1`, `compatSkills:["monkey_groundLock","monkey_aegisOfEarth"]`.
Desc (Thai, FINAL, user-specified wording, flat string since single-rank): `"เพิ่มระดับสถานะตรึงของ
**Ground Lock** **+2** และเกิดการโจมตีซ้ำอีกครั้งหลังจากนั้น **3 วินาที**"`. Icon `secondStone5`
extracted fresh from `RippedAssets`, byte-verified. Inserted into the `SKILLS` array at its real
commandNum position (403, right before `instantBlaze5`=412), maintaining the ID-ordering this
session already fixed for the rest of Monkey's array.

Both 3a/3b applied together: `node scripts/validate_skills.js` passing (336 skills / 450 formula
permutations / 789 icons) + full-script `new Function()` syntax check clean.

## [x] 4. Gadina (main summon, active, mnk_gadina1-4) -- APPROVED & APPLIED

**CORRECTED (user caught this): the "instant cast, no cooldown" claim above was flat-out wrong.**
The original research (and an initial re-verification pass this session) both stopped at
`RPC_gadina_cast` (`Monkey.cs:31217-31593`) -- a skill-specific coroutine reachable by NAME-matching
grep, which really does contain zero `magAdjust`/`addTimeOut` calls, just 3 short fixed animation
yields (0.3s/0.1s/0.4s). But that coroutine is NOT what a real player-initiated cast goes through --
tracing the actual click-dispatch chain to its real call site (`Monkey.cs:9239`,
`this.StartCoroutine_Auto(this.RPC_cast("gadina", ...))`) shows Gadina genuinely uses the SAME shared
generic `RPC_cast` coroutine every other Monkey active skill in this doc does (World Ignition, Ground
Lock, etc.). That function's own `"gadina"` branch (`Monkey.cs:25246-25262`):
```
mCastTime = 3 + 2×sLv          -- magAdjust-wrapped (:25430) -> 5/7/9/11s by rank
mTimeOut  = 45                 -- agiAdjust-wrapped (:25450) -> real flat 45s cooldown
```
`RPC_gadina_cast` is real and reachable too, but only as stage 2 -- the generic `RPC_cast`'s own
cast-bar completion handler (`Monkey.cs:25930`) dispatches INTO `RPC_gadina_cast` afterward, purely
for the post-cast-bar summon animation/VFX sequencing, not the cast-time/cooldown gate itself.
**Lesson, now standing practice:** a skill-specific coroutine matching the skill's own name
(`RPC_<skillname>_cast`) is not automatically the function real player input calls -- verify the
actual dispatch by finding the literal `StartCoroutine_Auto(...)` call reachable from the real
player-click UI chain (the same `a2`/`num2`-accumulation pattern already used to trace World
Ignition/Ground Lock), not by grepping for a plausibly-named function and assuming it's authoritative.

MP cost: rank1=25, rank2=45, rank3=65 (RESOLVED -- was "inferred not cited," now compile-verified via
`MonkeySkill.getSkill()`, confirming the inference was exactly right), rank4=85. New cast auto-
despawns old Gadina (`ylqsaaMXIp.SendMessage("unsummon")`, `Monkey.cs:12633`, re-confirmed).

**Stat wiring at summon (Gadina.cs:6080-6280):**
- EquipSword(titanSwordLv): base ATK by form 10/20/30/40 + Titan Sword flat bonus 0/20/35/50 (skill #5)
- EquipShield(aegisOfEarthLv): base DEF by form 10/20/30/40 + Aegis of Earth flat bonus 0/20/35/50 (skill #5)
- If aegisOfEarthLv>0: VIT += floor((0.1*shieldLv+0.1) * MonkeyOwnVIT) (20%/30%/40%)
- If Monkey hasSkill(423) "Earth Soul" (mnk_earthSoul5, NOT yet researched, future batch): ALL 8 stats
  get += floor(0.1 * GadinaFormRank * MonkeyOwnStat) -- without this passive, AGI/MAG/CHA/TAL/LCK are
  NEVER touched by any code in Gadina.cs at all.
- mhp = floor(10 * finalVIT); hp = mhp

**Stat grid -- RESOLVED via binary hex-decode (12TailsOnline_Data/resources.assets), see
decode-character-stats skill for methodology:**
- ATK, DEF base (10/20/30/40 each): CODE-VERIFIED (Gadina.cs:500-707) -- runtime-overwritten by
  EquipSword/EquipShield every summon, so the binary's baked atk/def (flat 10, and 100/10/10/100
  respectively) are dead placeholder data, correctly disregarded.
- HP/MHP: formula verified (mhp=10*finalVIT), computed live -- binary's baked mhp (flat 10) is also
  dead placeholder, disregarded.
- AGI/VIT/MAG/CHA/TAL/LCK baseline (never touched by any Gadina.cs code, only ever additive deltas):
  CONFIRMED via binary decode -- all 6 stats equal within each rank: 15/30/50/75 for ranks 1-4.
  Cross-validated 2 ways: (1) VIT=15/30/50/75 matches mhp=10*vit against Thai tooltip's stated HP
  150/300/500/750 exactly, (2) all 6 unrelated stat slots landing on the same clean number is itself
  a strong signal against a coincidental/misaligned decode.
- Full 9-stat grid: ATK/DEF = 10/20/30/40 (+Titan Sword/Aegis of Earth bonuses per rank), MHP =
  10*(15/30/50/75 + Aegis VIT% + Earth Soul bonus), AGI/MAG/CHA/TAL/LCK = 15/30/50/75 baseline
  (+Earth Soul bonus only, since only Aegis of Earth and Earth Soul ever touch these post-baseline).
- **Thai tooltip's on-summon 50/100/150/200 hate and 5/10/15/20 ko per rank -- RESOLVED, found for
  real.** The original research (and this session's own first pass, checking `Monkey.cs` per direct
  user instruction and finding nothing there) both stopped reading `Gadina.cs`'s own `summon()`
  coroutine (`$summon$17985`, `Gadina.cs:5944-6561`) partway through, at the stat-wiring section
  (`:6154-6218`). Reading the REMAINING ~270 lines (never read by either the original pass or this
  session's first pass) found the real hit at `Gadina.cs:6367`:
  ```
  PAdJkeGAVL.hit(40, hitObject, 5×mGadinaLv, 5×mGadinaLv, 50×mGadinaLv, 0.2×Vector3.up)
  ```
  Decoding `hit(actionCode, target, nDamage, nKo, nHate, nForce)`: a real on-summon AoE shockwave,
  `Damage.FindAreaTarget(gadinaPos, 4×mGadinaLv+8, height 2, hitLayer)` -- radius 12/16/20/24m by
  form, gated behind `isMine` (genuinely reachable). `nKo=5×rank` (5/10/15/20) and `nHate=50×rank`
  (50/100/150/200) match the tooltip exactly; `nDamage=5×rank` (same coefficient as KO) was a NEW
  find not stated in either tooltip at all. Flat, not `talAdjust`-wrapped. Since Gadina itself is the
  attacker (`PAdJkeGAVL` = Gadina's own `CharacterControl`), this hit's `dmgAdjust` roll uses Gadina's
  OWN lck, not the player's -- same `ownLck` pattern Auto Gyro Gun's turret already established.
  **2nd lesson from this same session, reinforcing the first:** "I checked Monkey.cs like you said and
  found nothing" was itself premature -- the value was in `Gadina.cs` all along, just past where
  BOTH the original research and this session's own first read stopped. The standing practice is the
  same either way: read a coroutine to its actual closing brace before concluding something isn't
  there, regardless of which file it's in.

**gadinaSoul status** (granted by a SEPARATE skill, mnk_summonSoul5, not part of this batch): nCode
913, sLv = current Gadina form (1-4), duration flat 240s all ranks. isStateStatus=true, isBuffStatus=
true, not physical/magical/debuff/lock/shield/system. Effect: deltaDef(10*sLv) to target ally ->
+10/20/30/40 DEF for Gadina form 1-4.

Tooltip ENG generic ("lesser/medium/large/great stone golem"). Thai gives concrete per-rank hate/ko/hp
numbers not in English text at all (EN/TH completeness gap, consistent with pattern seen elsewhere).

**Child movesets discovered (not built, listed for later):**
- Normal Attack (nAttack1-4): dmg floor(0.5*ownATK), ko=titanSwordLv, cd 3s/3s/4s/4s (agiAdjust)
- Earth Guard (Gadina4-only, requires Monkey's earthGuard5): 6-tick self-heal, 20% missing HP/tick, cd 60s
- Planet Breaker (already researched as skill #6 below) -- keeps its own cost since it's a manual
  player command, not automated AI

Proposed compatSkills on this main card: titanSword(1-3), aegisOfEarth(1-3), planetBreaker1
(Gadina4-only), earthGuard5 (Gadina4-only, future batch), summonSoul5 (future batch), earthSoul5
(future batch)

**Applied, same day.** `index.html` entry: `maxRank:4`, `cost:{mp:[25,45,65,85]}`,
`castTime:[5,7,9,11]` (corrected from the wrong pre-existing stub value, which happened to already
be right at `11` for rank 4 by coincidence of an earlier hand-entry, not because it was verified),
`cd:45` (also corrected, same coincidence), `durationInfinite:true`, `dmg:"5×sLv"`, `ko:"5×sLv"`,
`ownLck:[15,30,50,75]` (Gadina's own per-rank LCK baseline, ignoring the not-yet-wired Earth Soul
bonus -- flagged in `dmgNote`), `compatSkills:["monkey_aegisOfEarth"]` (only the one dependency
that's actually carded so far; Titan Sword/Earth Guard/Summon Soul/Earth Soul all still uncarded).
Aegis of Earth's own `compatSkills` updated to add `"monkey_gadina"` back (bidirectional), now that
a real dependent card exists.

**Small engine extension needed for `ownLck` (2026-09-15):** the existing `ownLck` mechanism (Auto
Gyro Gun pilot, 2026-08-18) only supported a plain number or, for a boolean `true`, silently reusing
the skill's own `dmg` text as a stand-in for its LCK formula -- which happened to work for Auto Gyro
Gun purely because its baseline `atk` and `lck` are BOTH `10×rank` in source (the exact same
formula), not because that's a real general rule. Gadina's own `dmg` (`5×sLv`) and real LCK baseline
(`15/30/50/75`) are unrelated formulas, so reusing `dmg` as a stand-in would have been silently wrong.
Extended `ownLck` to also accept a plain per-rank array (`Array.isArray` check, resolved via the
same `resolveRank` helper `cd`/`castTime`/`duration` already use) at both consumer sites
(`rollOneHit` and `renderHero`'s Final Damage calc block) -- backward compatible, no existing
`ownLck` user (Auto Gyro Gun, Mana Vortex's flat `ownLck:0`) is affected by adding a 3rd case.

Applied + `node scripts/validate_skills.js` passing (336 skills / 454 formula permutations / 792
icons) + full-script `new Function()` syntax check clean.

**Known gap, not yet built:** the 9-stat summon grid chip (ATK/DEF/MHP/AGI/MAG/CHA/TAL/LCK, per
AGENTS.md Section 7's Main Summon Card convention, matching Barrel Bot/King Kaiser/Ja's own
precedent) does NOT exist on this card yet -- only cost/cast/cooldown/duration/dmg/ko are wired.
Building it needs a `gadinaOwnStats(rank, titanSwordLv, aegisOfEarthLv, monkeyVIT)` function plus
`GADINA_TITANSWORD_DEP`/`GADINA_AEGIS_DEP` dep objects, deferred until Titan Sword (item 5 below) is
also carded, so both deps can be wired together in one pass rather than half now/half later.

## [x] 5. Titan Sword (passive, mnk_titanSword1-3) + Aegis of Earth (passive, mnk_aegisOfEarth1-3) -- BOTH APPROVED & APPLIED

**Aegis of Earth's own card applied earlier -- see item 3a above.** Its Gadina-side effect (DEF+VIT
bonus) is now ALSO fully wired -- see the "Gadina 9-stat grid" note below. Titan Sword's own card is
now applied too, all 3 of its effects re-verified exhaustively this pass (all 5 real per-hit-bonus
sites and all 9 real KO-bearing `hit()` sites individually grepped and confirmed, not just trusting
the original "5 sites"/"+8 mirror sites" count).

Both feed Gadina.cs's `summon(titanSwordLv, aegisOfEarthLv, ownerActorNr)` call (Monkey.cs:12947-12957).
Only callers of either getter, tree-wide (exhaustive grep confirmed).

### Titan Sword (getTitanSwordLv: hasSkill 321/322/323 -> 1/2/3)

Three distinct effects in Gadina.cs, all keyed off titanSwordLv (nSwordLv):
1. Static ATK add at equip (EquipSword, Gadina.cs:478-606): rank1 +20, rank2 +35, rank3 +50 (flat, not
   cumulative -- each number is the total at that rank). Also swaps sword model.
2. Dynamic per-hit bonus (5 sites, e.g. Gadina.cs:2628): hitAtk += floor((0.1*swordLv+0.1) * MonkeyOwnATK)
   -> rank1=+20% of Monkey's live ATK, rank2=+30%, rank3=+40%, stacked onto Gadina's own hitAtk.
3. KO value on Gadina's basic attacks = getSwordLv() directly (0/1/2/3) -- rank N gives N ko (Gadina.cs:2665 +8 mirror sites).

DISCREPANCY: tooltip claims flat ATK +20/+40/+60 and ko 2/3/4; code gives +20/+35/+50 ATK and ko 1/2/3.
Both diverge (ATK at rank2-3, ko consistently off-by-one). Code wins.

Status: None. Dep constant: GADINA_TITANSWORD_DEP = { flatAtk:[0,20,35,50], hitAtkPctOfMonkeyAtk:[0,.2,.3,.4], ko:[0,1,2,3] }

### Aegis of Earth (getAegisOfEarthLv: hasSkill 331/332/333 -> 1/2/3)

Two distinct effects, verified both directions:
1. Gadina DEF+VIT bonus (EquipShield, Gadina.cs:649-777): flat DEF +20/+35/+50 by rank (same
   tooltip-vs-code drift as Titan Sword: tooltip claims +20/+40/+60). Plus VIT add at summon
   (Gadina.cs:6154-6165): vit += floor((0.1*shieldLv+0.1) * MonkeyOwnVIT) -> +20%/30%/40% of Monkey's
   VIT. Since Gadina's mhp = 10*vit (Gadina.cs:6218), this also indirectly raises Gadina's max HP.
   No dynamic per-hit shield bonus exists (unlike Titan Sword's per-hit ATK case).
2. Ground Lock duration extension (Monkey.cs:30608, cross-confirmed with skill #3 above): base
   duration = 3 + aegisOfEarthLv (4/5/6s at rank1/2/3) before CHA-vs-CHA contest scaling via
   Damage.getDebuff. This 4/5/6 progression is independently corroborated by Aegis of Earth's OWN
   tooltip text -- strong real-mechanic confirmation.

Tooltip note: Thai tooltip matches code on VIT% and groundLock duration; only flat DEF number drifts
(same pattern as Titan Sword). English tooltip omits the VIT%/HP bonus entirely (EN/TH completeness gap).

Status: None. Dep constants:
- GADINA_AEGIS_DEP = { flatDef:[0,20,35,50], vitPctOfMonkeyVit:[0,.2,.3,.4] } (summon-stat dep into Gadina)
- GROUNDLOCK_DUR_DEP = { baseDurationAdd:[0,1,2,3] } (durDep on Ground Lock's own card, independent of the Gadina dep -- same getter, two unrelated systems, both must be modeled)

Icons: titanSword1-3.png, aegisOfEarth1-3.png all present under RippedAssets .../skills/monkey/
(both fully extracted and byte-verified this pass).

**Applied, same day.** `monkey_titanSword` card: `passive:true`, `maxRank:3`, tooltip cross-checked
directly in both languages (`MonkeySkill_eng.cs:642,653,664` / `MonkeySkill_thai.cs:664,675,686` --
both say the same wrong `+20/40/60 atk`/`2/3/4 ko`, a consistent EN/TH error, not a translation gap;
code's real `+20/35/50`/`1/2/3` wins). `compatSkills:["monkey_gadina","monkey_gadina_nAttack"]`.

**Gadina 9-stat grid, built this pass (was flagged as a known gap when Gadina's own card first
shipped):** new `gadinaOwnStats(rank, titanSwordLv, aegisOfEarthLv, monkeyVIT)` function (mirrors
`barrelBotOwnStats`/`kingKaiserOwnStats`/`jaOwnStats`'s own shape) -- ATK/DEF = form base
(10/20/30/40) + Titan Sword/Aegis of Earth's own static bonus (0/20/35/50, indexed directly by each
dep's 0-3 rank); AGI/MAG/CHA/TAL/LCK = 15/30/50/75 baseline; VIT = baseline +
`floor((0.1×aegisRank+0.1)×MonkeyVIT)`; MHP = `10×VIT`. **Earth Soul's own +0.1×rank×MonkeyStat
bonus to all 8 stats is deliberately NOT folded in yet** -- Earth Soul itself hasn't been researched
as its own batch item, so adding its effect now would be modeling an unresearched mechanic. Two new
reusable dep objects: `MNK_TITANSWORD_DEP` (general -- also feeds the new Normal Attack card and a
future Planet Breaker pass) and reuse of the EXISTING `MNK_GROUNDLOCK_AEGIS_DEP` (same real passive,
same id, shared toggle state with Ground Lock's own Duration dep -- confirmed this is correct, not a
collision, since both really are the same Aegis of Earth rank).

Wired into `renderHero`'s existing `ownStats*` branch chain (`selected.ownStatsGadina ||
selected.id === "monkey_gadina"`) -- the base "Gadina" card is reference-only (full-accent, same
"nothing on this card reads these stats interactively" treatment as base Barrel Bot/Ja), while the
new "Gadina - Normal Attack" child card (below) genuinely overrides `ATK`/`AGI` for its own
`atkCoeff`/Cooldown chips, same pattern Auto Gyro Gun's turret already established.

**New "Gadina - Normal Attack" child card**, mirroring the Barrel Bot/King Kaiser "X - Move" split:
`ownStatsGadina:true`, `atkCoeff:0.5` (real formula: `dmg = floor(0.5×hitAtk)`, `hitAtk` = Gadina's
own live ATK, `Gadina.cs:2605`), `ownLck:[15,30,50,75]` (Gadina's own LCK baseline, matching the main
card), `dmgRankDep:MNK_TITANSWORD_DEP` + `ko:(rank,depLv)=>String(depLv||0)` (Titan Sword's own raw
rank IS the KO value, confirmed via `getSwordLv()`'s exact enum mapping), `hitCount:(rank)=>
[1,2,3,3][rank-1]` (real per-form hit counts, confirmed by counting exact `hit()` call sites inside
each of the 4 separate `RPC_nAttack1-4` coroutines individually -- form 4 does NOT get a 4th hit,
verified not assumed), `cd:[3,3,4,4]` using **Gadina's own AGI** (`Gadina.cs:2780,3394,4139,4901`,
`PAdJkeGAVL.agiAdjust`). `revisedArtExempt:true` (Gadina's own `CharacterControl` has an empty skill
list, so `hasSkill(424)` can never be true for its own `addTimeOut` calls -- same structural reason
Barrel Bot's moves are exempt). No `cost` field (automated AI move, per Section 7.4).

**Deliberately NOT wired as a live formula term (cited in `dmgNote` instead):** Titan Sword's dynamic
per-hit bonus, `hitAtk += floor((0.1×rank+0.1)×MonkeyOwnATK)` -- a genuinely gnarly cross-actor
formula (Gadina's OWN attack, boosted by a fraction of the PLAYER's separately-tracked live ATK
input, on top of `atkCoeff`'s own Gadina-ATK term). Extending `dmgDep`'s `calc()` signature to also
receive both the dep's own raw rank (not just the skill's rank) AND the player's ATK would need
touching 4 existing call sites for a single nested edge case -- disproportionate relative to this
tool's own established restraint elsewhere (Napalm's per-projectile scatter, Ice Twister's velocity
bump are both cited-only for the same reason). Revisit if this pattern recurs elsewhere and justifies
a real engine extension.

**Small necessary engine extension:** `ownLck` (Auto Gyro Gun pilot, 2026-08-18) previously only
accepted a plain number or, for `true`, silently reused the skill's own `dmg` text as a stand-in LCK
formula -- which only worked for Auto Gyro Gun because its baseline `atk` and `lck` happen to share
the exact same source formula (`10×rank`), not a general rule. Gadina's `dmg` (`5×sLv`) and real LCK
baseline (`15/30/50/75`) are unrelated, so reusing `dmg` would have been silently wrong. Extended
`ownLck` to also accept a plain per-rank array (`Array.isArray`, resolved via the same `resolveRank`
helper `cd`/`castTime`/`duration` already use) at both consumer sites (`rollOneHit` and `renderHero`'s
Final Damage calc) -- backward compatible, verified no existing `ownLck` user (Auto Gyro Gun, Mana
Vortex's flat `ownLck:0`) is affected.

Applied + `node scripts/validate_skills.js` passing (338 skills / 470 formula permutations / 795
icons) + full-script `new Function()` syntax check clean + hand-verified `gadinaOwnStats()` output
against 3 manually-derived cases (rank4/TS3/AE3/VIT128, rank1/TS0/AE0, rank2/TS1/AE2/VIT128 --
rank1's baseline mhp=150 also independently matches the Thai tooltip's own stated HP number).

**Correction, same day, immediate follow-up (2 real bugs, both user-caught):** the first version of
"Gadina - Normal Attack" shipped with `ownStatsGadina:true` wired only into `renderHero`'s own stat-
setup branch -- but `renderOneDmgFormula` and `rollOneHit` each declare their OWN independent local
`ATK` (re-parsed fresh from the input field, not a shared closure variable with `renderHero`), so the
override never actually reached the Damage Formula chip, Raw Damage, Simulate, or Final Damage at
all -- the card was silently still using the PLAYER's own ATK for its `atkCoeff:0.5` term the whole
time. Fixed by adding the identical `ownStatsGadina` branch to both functions independently (matching
`ownStatsGyro`/`ownStatsKaiser`'s own established precedent of needing the same override in 3
separate places for the same reason).

**2nd bug, same message: Titan Sword's dynamic per-hit bonus was cited-only, not live-computed** (the
original "disproportionate effort" call was wrong). Real formula: `hitAtk = GadinaATK +
floor((0.1×titanSwordRank+0.1)×MonkeyOwnATK)`, `dmg = floor(0.5×hitAtk)` (`Gadina.cs:2605,2628`).
User pointed out the fix is simple: since BOTH terms share the identical `0.5` coefficient,
`0.5×(GadinaATK+bonus) = 0.5×GadinaATK + 0.5×bonus` -- so folding the bonus directly into the ATK
value fed to the existing `atkCoeff:0.5` is mathematically EXACT, not an approximation, and needs no
new dep/calc engine mechanism at all. Implemented in all 3 places (`renderOneDmgFormula`, `rollOneHit`,
`renderHero`'s own branch): capture the player's own ATK into a local BEFORE overwriting it with
Gadina's, compute `dynamicBonus = titanSwordLv>0 ? floor((0.1×titanSwordLv+0.1)×monkeyATK) : 0`, then
set `ATK = gadina.atk + dynamicBonus`. Hand-verified against source: rank4/TitanSword2/playerATK200 ->
GadinaATK 75, bonus `floor(0.3×200)=60`, finalATK 135, `dmg=trunc(0.5×135)=67` -- matches the real
`hitAtk=135, (int)(0.5×135)=67` exactly. Untrained Titan Sword correctly gives `dynamicBonus=0`.
`dmgNote` on the child card corrected to remove the now-stale "not wired" caveat.

Re-ran `node scripts/validate_skills.js` (338/470/795, unchanged counts -- a formula fix, not a new
skill) + full-script syntax check, both clean.

**Correction, same day, immediate follow-up (user screenshot):** the fold above was RIGHT for the
Raw Damage/Final Damage NUMBER (still used, unchanged, in `rollOneHit` and `renderHero`'s own calc
block), but WRONG for the Damage Formula TEXT chip specifically -- collapsing Gadina's own ATK and
the Titan Sword-scaled slice of the player's own ATK into one indistinguishable "70(0.5ATK)" number
hid that two genuinely different actors' stats were contributing. User: "there should be 2 terms,
Gadina and Monkey ATK." Reverted the fold in `renderOneDmgFormula` only (`rollOneHit`/`renderHero`'s
own branches keep the folded, mathematically-exact total unchanged) -- two new function-scoped
variables (`gadinaMonkeyATK`, `gadinaTitanSwordLv`) carry the pre-fold values out of the `ownStatsGadina`
branch to the term-building code further down in the same function, where a 2nd `.dmg-atk`-colored
term is now appended: `{value: (0.1×titanSwordLv+0.1)×0.5×monkeyATK, sub:"MonkeyATK"}`, right after
the existing Gadina-ATK term. Hand-verified the 2 visual terms still sum exactly to the correct total
at the same rank4/TitanSword2/playerATK200 case (`37+30=67`, matching the single-truncation total
computed earlier) -- no drift in this case, and any future rounding-edge mismatch between the 2
independently-truncated visual terms and the 1 combined-truncation Raw/Final Damage number is the
same class of minor imprecision this tool already accepts for every other multi-term formula (e.g.
Mole's own `36 + 96(0.75ATK) + 92(0.72TAL)`).

Re-ran `node scripts/validate_skills.js` (338/470/795, unchanged) + full-script syntax check, both
clean.

**Correction, same day, 3rd fix on this same card (user screenshot of the stat-signature-glow
feature, Section 9/10):** two bugs in the "which stat glows" logic, both missing an
`ownStatsGadina` case that every other `ownStats*` variant already had:
1. `getUsedOwnStatKeys` (glows cells INSIDE the Gadina Stats summon table itself) only checked
   `skill.ownStats` for its `agi` rule (`hasAgi = !!(skill.ownStats && skill.cdWrapped)`) --
   Gadina - Normal Attack uses the separate `ownStatsGadina` flag, so its own "AGI 75" cell never
   glowed despite genuinely driving the Cooldown chip. Fixed: `hasAgi = !!((skill.ownStats ||
   skill.ownStatsGadina) && skill.cdWrapped)`.
2. `getUsedPlayerStatKeys` (glows the PLAYER's own stat-input panel) added `agi` unconditionally
   whenever `cdWrapped` is true, with no summon-sourced exclusion for this specific flag -- so the
   player's own AGI input glowed even though this skill's Cooldown never reads it at all. Fixed:
   `else if (skill.cdWrapped && !skill.ownStatsGadina) used.add("agi")`. **Deliberately NOT** added
   to the function's existing `isSummonAttacker` exclusion set (which also suppresses `atk`) --
   unlike Barrel Bot's fully summon-sourced moveset children, this skill's ATK term genuinely DOES
   read the player's own ATK too, via Titan Sword's dynamic per-hit bonus (the 2nd `.dmg-atk` term
   added in the immediately preceding fix) -- suppressing ATK here would have re-introduced a
   different wrong answer.

Hand-verified via extraction: `getUsedOwnStatKeys` on the real skill shape now returns
`["atk","agi"]`; `getUsedPlayerStatKeys` returns `["atk"]` only (agi correctly absent, atk correctly
still present). Re-ran `node scripts/validate_skills.js` (338/470/795, unchanged) + full-script
syntax check, both clean.

## [x] 5c. Earth Soul (passive, mnk_earthSoul5, maxRank 1) -- APPROVED & APPLIED (NOT in the original
8-item batch scope -- added ad hoc per the skillDep-loop-closure workflow, closing the last
remaining gap `gadinaOwnStats()` had deliberately left open when Gadina's own card first shipped)

Requirements compile-verified: rLv=70, rBn=3, **rSkill=324** (prereq = Planet Breaker rank 1, via
`MonkeySkill.getSkillTree()`'s own commandNum map). No cost, pure passive.

**Exhaustively confirmed self-contained**: grepped every `hasSkill(423)` site across `Monkey.cs`/
`Gadina.cs`/`Ja.cs`/`Phoenix.cs` -- exactly 2 hooks total. `Monkey.cs:12588` is purely cosmetic (an
`earthSoul_ring` VFX prop on Gadina's own summon, no numeric effect). `Gadina.cs:6171-6212` is the
real mechanic: `+floor(0.1×GadinaForm×MonkeyOwnStat)` to ALL 8 of Gadina's own stats (`getNoDeltaStat
(0..7)` = atk/def/agi/vit/mag/cha/tal/lck respectively) -- `mhp` has no own index but is still
indirectly boosted via the boosted `vit` (`mhp=10×vit`, computed after this block, same mechanism as
Aegis of Earth's own VIT% bonus).

**Real tooltip discrepancy, confirmed in BOTH languages, on the SAME point:** EN
(`MonkeySkill_eng.cs:1016`) says "adds 40% of Monkey's LEVEL to Gadina's stats" -- wrong on two counts
(conflates "stat" with "level," and states a flat 40% with no mention of scaling). TH
(`MonkeySkill_thai.cs:1038`) says "นำค่าพลัง stat ของลิงไปบวกให้กับ Gadina ตามเลเวล (10%,20%,30%,40%)" --
correctly identifies it as Monkey's own STAT (not level) and correctly states the 10/20/30/40%
progression, but STILL wrongly attributes that progression to "เลเวล" (level). The real code
(`getGadinaLv()`) scales the coefficient by the CURRENT GADINA FORM (1-4), not Monkey's character
level at all -- confirmed by direct re-read, code wins per standing rule.

**`gadinaOwnStats()` extended, not left as a stub any longer.** Its signature changed from
`(rank, titanSwordLv, aegisOfEarthLv, monkeyVIT)` to `(rank, titanSwordLv, aegisOfEarthLv,
monkeyStats, earthSoulOn)` -- `monkeyStats` is now a full `{atk,def,agi,vit,mag,cha,tal,lck}` object
(matching `phoenixOwnStats`'s own established object-parameter shape) since Earth Soul, unlike Aegis
of Earth's VIT-only bonus, needs all 8 of the player's own stats simultaneously. All 3 call sites
(`rollOneHit`, `renderOneDmgFormula`, `renderHero`'s own branch) updated to build and pass this
object plus a new `earthSoulOn` boolean (via `getDepRank(MONKEY_EARTHSOUL_DEP) ===
MONKEY_EARTHSOUL_DEP.maxRank`). New `MONKEY_EARTHSOUL_DEP` (0/1 toggle) added to Gadina's own Stats
chip corner alongside the existing Titan Sword/Aegis of Earth rank-cycle toggles.

Applied card: `passive:true`, `maxRank:1`, `compatSkills:["monkey_gadina","monkey_gadina_nAttack"]`,
icon `earthSoul5` extracted fresh and byte-verified. Desc explicitly calls out the form-not-level
discrepancy per the user's own "emphasize this" instruction pattern (matching how Aegis of Earth's
own desc was corrected the same day to spell out "% ของค่า VIT ของลิง").

Hand-verified via extraction: `gadinaOwnStats(4,3,3,{all stats=128},true)` -> `atk=141, vit=177,
mhp=1770` (vs. `atk=90, vit=126, mhp=1260` with Earth Soul off) -- the +51 delta on every stat matches
`floor(0.1×4×128)=51` by hand. `gadinaOwnStats(1,0,0,{all=128},true)` -> `atk=22, agi=27` matches
`floor(0.1×1×128)=12` added to each rank-1 baseline (10/15) by hand too. Applied +
`node scripts/validate_skills.js` passing (339 skills / 470 formula permutations / 796 icons) +
full-script `new Function()` syntax check clean.

## [ ] 6. Planet Breaker (active, mnk_planetBreaker1, maxRank 1)

Gadina4-gated command skill (same gate family as Titanic Earth Pulse). SkillClass: setReq(31,8),
setSP(-35), instant mode, cType "planetBreaker". Double-gated: UI-side check (Monkey.cs:8108-8169)
AND a redundant server-side re-check inside the coroutine (Monkey.cs:31750-31816, also verifies
Gadina.hp>0 and not busy -- "Gadina is not ready" message if so).

Monkey's role is purely cosmetic (animation + VFX at Monkey's position, own 60s cooldown for the
skill-bar UI, agiAdjust on MONKEY's own AGI/LCK). The real attack delegates to Gadina's own script
(Gadina.cs:5403-5931), which has a SEPARATE 60s cooldown keyed to GADINA's own AGI/LCK (used only
for Gadina's own AI auto-cast gating, not player-facing).

**Damage loop:** runs 3 times, 0.3s apart. Each tick:
- Inner circle: Damage.FindAreaTarget(Gadina's position, radius 5*rangeMod, height 3*rangeMod) --
  flat-ground circular AoE (not sphere). hitAtk = Gadina's OWN ATK stat (NOT Monkey's TAL/ATK) +
  [if Monkey's Titan Sword rank>=1: floor((0.1*swordLv+0.1) * Monkey's own ATK)]. hit(11, dmg, 10ko,
  knockback away from Gadina).
- Outer donut: radius out to fixed 12m (NOT rangeMod-scaled), excludes inner-circle targets. Flat
  5 dmg / 5 ko / 2x knockback-only ring. hit(12, ...).

No RPC_AddStatus anywhere in the coroutine -- pure damage+knockback AoE, no status applied.

Tooltip ENG (MonkeySkill_eng.cs:675): "Command Forth form Gadina to use ultimate sowrd attack. Deal
damage to adjacent area." (typo "sowrd" is authentic to the client string). THAI similar, more descriptive.

**Key mechanic to highlight:** damage source is Gadina's own ATK, not Monkey's TAL -- easy to
misattribute since it's filed under Monkey's skill list. Titan Sword passive (skill #5) adds a
Monkey-ATK-scaled bonus on top, gated at Titan Sword rank>=1. Gated by (not scaled by, beyond the
binary check) Gadina's Type=="Gadina4".

Icons: planetBreaker1.png is the correct/sole icon (maxRank=1); planetBreaker0/2/3/4.png are
leftover/shared UI-state assets, not additional ranks.

## [ ] 7. Titanic Earth Pulse (active, mnk_titanicEarthPulse1, maxRank 1)

Gadina4-gated finisher (same gate pattern as Planet Breaker). SkillClass: setReq(33,9),
setMPSP(40,-60), instant mode, cType "titanicEarthPulse". Cooldown 240s base (agiAdjust).

Gate: Monkey.cs:8171-8242 -- checks player's current summon .Type == "Gadina4" (characterControl2,
resolved from ylqsaaMXIp). Blocked -> "That skill need Gadina4" message + MP/SP refund (returnMPSP).

**Cast sequence (all instant-triggered, no cast bar, but long windup):**
1. Root self (moveSpeed=0), self-status "noForce" (sLv1, 7s) applied
2. Gadina IMMEDIATELY UNSUMMONED: base damage = Clamp(0.35 * Gadina's current HP, 1, 1999) captured
   at this moment (Monkey.cs:32472), then Gadina removed from field
3. ~5s windup (VFX + voice line) before projectile actually fires
4. Projectile: straight-line trigger, 15 units/s, 3s life (~45m range), Monkey_earthPulse.cs
5. On first hit: detonates an EXPANDING RING -- 5 ticks, Damage.FindAreaTarget(impactPoint, radius, 6m height),
   radius = 1/2/3/4/5m across the 5 ticks (never shrinks, never excludes already-hit targets)
6. Each tick: hit(334, target, nDamage, 10 ko, 0, dir) using the SAME captured nDamage each time

**Critical mechanic:** damage is NOT derived from Monkey's own ATK/TAL/MAG at all -- it's purely
35% of Gadina's HP at the moment of sacrifice, clamped 1-1999. A target within 1m of impact gets
hit by all 5 ticks (5x the per-tick damage before mitigation/crit variance); a target 3-4m away only
catches the last 1-2 ticks; beyond 5m or outside the 6m height band, never hit.

Status: "noForce" self-buff, nCode 5, isBuffStatus=true, isSystemStatus=true (non-cleansable),
NOT debuff/state/magical/physical/lock/shield. Roots + likely suppresses knockback during windup.

Tooltip ENG (MonkeySkill_eng.cs:719): "Transform Gadina4 into a gravity cannon, dealing serious
damage to enemies in front." Tooltip THAI (_thai.cs:741) similar. Neither tooltip gives any numeric
detail on the HP-consumption formula or the expanding-ring mechanic.

**Dependency:** gated by Gadina4 (hard block + refund), AND genuinely scaled by Gadina's own current
HP at time of cast (not just a rank check) -- the single most important mechanical fact about this
skill. Higher Gadina max-HP (itself a function of Aegis of Earth's VIT% bonus, see skill #5) directly
raises this skill's damage ceiling up to the 1999 cap.

Proposed desc: "Requires Gadina at Rank 4. Sacrifices Gadina, converting it into a gravity cannon:
fires a single gravity bolt (~45m range, ~5s windup) that detonates on the first target hit into an
outward pulse expanding from **1m to 5m** radius over 5 ticks, dealing damage equal to **35%** of
Gadina's own HP per tick -- a target caught near the epicenter can be struck by all 5 ticks. Roots
the Monkey in place for the duration of the cast."

## [ ] 8. Stone Hammer (active, mnk_stoneHammer1-4)

Cast time: 2+sLv sec (3/4/5/6s by rank). Cooldown: flat 60s all ranks. MP cost: rank1=12, rank2=
METADATA GAP (SkillClass.cs's idempotent setMP/setReq guards mean rank 2's branch never executes --
constructor defaults apply; doesn't affect combat formula, only UI metadata -- flag for live check),
rank3=28, rank4=36.

**Channel/interrupt mechanic (confirmed real):** ~0.8s local animation channel after cast bar
completes. Repeatedly re-checks actionState=="attack" and myCommand=="stoneHammer" at multiple
points; if either check fails (player moved/stunned/issued another command), the coroutine silently
returns false and RPC_stoneHammer_fire (the damage step) is NEVER called -- cast is cancelled with
no damage dealt. Per generic RPC_cast behavior, cooldown/MP are likely still consumed since they're
committed before the local channel starts (flag for live verification).

**Damage (Monkey.cs:33448-33492):** AoE cylinder via Damage.FindAreaTarget, radius = 1+0.5*sLv m
(1.5/2/2.5/3m), fixed height 6m, centered on landing point -- hits everyone in the cylinder
simultaneously (ground-target AoE, not single-target). Base damage pre-talAdjust: sLv*25+20
(45/70/95/120), +30 flat with hasSkill(443). KO: sLv*10+10 (20/30/40/50), +10 flat with hasSkill(443).
No directional knockback (nForce=Vector3.zero). No RPC_AddStatus anywhere -- despite the "hammer
slam" theme, NO knockdown/stun status exists; nKo only feeds the generic stagger pipeline.

Landing a hit grants caster +1 sp (same as most Monkey active hits).

Visual-only: hammer model scales 0.75+0.25*sLv (1.0x-1.75x), unrelated to the actual AoE radius formula.

**Tooltip discrepancy:** English tooltip wrong on rank2 (says 75, code+Thai say 70) and rank4 (says
115, code+Thai say 120). KO values match both languages. Thai text matches code exactly (45/70/95/120).
Trust code/Thai.

Passive dependency: hasSkill(443) = mnk_stoneSentinel5 (Stone Sentinel, rank-5 capstone) adds +30 flat
dmg / +10 flat ko to every rank of Stone Hammer -- confirmed independently by Stone Sentinel's own
tooltip text, which explicitly states it buffs Stone Hammer.

Proposed desc: "Slam a falling stone onto the target's location, hitting all enemies in a
**${(1+0.5*rank)}m** radius, 6m tall cylinder. Locks movement while channeling; canceling the
channel (by moving, being stunned, or issuing another command) aborts the cast before the stone
lands with no damage dealt."
(NOTE: per user's own Thai-primary desc rule, this needs translating to Thai before being applied --
not yet done, this is still the original English draft from the research pass.)
