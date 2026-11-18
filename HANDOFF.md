# Handoff (office PC → home PC, 18/11/2026)

Read this after `git pull` (and see the branch `tto170-cards` below). Delete items as they get done, and delete the file when it is empty.

## What went live in this push

- **Halo skill list:** round skill icons with no boxes, rank stars and a ติดตัว tag on passives; 239 icons show no roman numeral.
- **Class gates:** in the game's Character Select ring, with no title or card. Each opening shows one random colour (1, 4 or 5) for all 12 classes.
- **Skill view counts:** 👁 in the skill header, counted once per skill per browser session.
- **TTO patch pop-up:** a "ไม่ได้เล่น … ไม่ต้องแสดงอัปเดตแบบนี้อีก" checkbox.
- **TTO 1.7.0 cards:** Sheep and Rabbit.

## Upscale at home (Real-ESRGAN, the same 60/40 anime / general blend as the skill icons)

All four are placeholders drawn bigger than their source, so they look soft. Paths are repo-relative. Run `node scripts/bible_assets.js stamp` after any edit to `12t_projects/bible/assets.js`, then `node scripts/validate_skills.js`.

### 1. `CLASS_HERO_COLORS` (60 pictures, 75 px)

- **What:** the round class faces, 12 classes × 5 colours.
- **Shown:** in both class gates, up to about 121 px (the face is 71.4 % of a ring up to 170 px), and on the PRESET tabs.
- **Source:** `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/heroes/<Class>1..5.png`.
- **Put back:** replace the data URIs in `BIBLE_ASSETS.CLASS_HERO_COLORS` as WebP. Keep the order: index 0–4 = colour 1–5. The gates use colours 1, 4 and 5 (`CLASS_GATE_COLORS = [0, 3, 4]` in `index.html`).

### 2. `CLASS_GATE_FRAME.ring` (1 picture, 105 px)

- **What:** the copper and rope ring behind each class face.
- **Shown:** up to 170 px.
- **Source:** one ring cut from `gamegui/change/window.png` (300 × 161, the Character Select window). Take the square of radius 52 around pixel (69, 98), the first face slot, and mirror its clean bottom-left quarter into all four quarters. The top touches the title banner and the right side joins the next ring, which is why only that quarter is used.
- **Do:** either upscale `window.png` and recut at the same geometry × the scale, or upscale the 105 px ring directly. Both should look fine.

### 3. `CLASS_GATE_FRAME.hover` (1 picture, 75 px)

- **What:** the game's cyan hover glow over the face.
- **Shown:** up to about 121 px.
- **Source:** `gamegui/change/button_char_h.png`.

### 4. `SKILL_ICONS_R0` (239 icons, rebuilt by a script)

- **What:** the Halo list's art with no roman numeral. Each is the Bible's sharp 128 px icon with only its numeral patch replaced by the game's numeral-free "rank 0" picture enlarged from 64 px, so that corner is the soft part.
- **Do:**
  1. Upscale the rank-0 pictures: `gamegui/icons/skills/<class>/*0.png`, 282 files across 12 class folders.
  2. Put them in a folder with the same layout: `<folder>/<class>/<name>0.png`.
  3. Run `py scripts/build_skill_icons_r0.py --r0-dir <folder> --sheet check.png`, then look at `check.png` (rows: before, after, mask).
  4. Run the same with `--write`, then `node scripts/bible_assets.js stamp`.
  5. Run the validator. `[HALO ROSTER ERROR]` checks this container.
- The script explains itself at the top. Without `--r0-dir` it rebuilds today's set from RippedAssets.

### 5. Not solvable by upscaling yet: icons with no rank-0 picture

- **What:** 377 of the 616 card icons have no rank-0 file, so their numeral still shows in the Halo list. Examples: Lucky Card, Life Gamble, Skill Gamble, Power Seven, and every basic attack.
- **Idea:** paint the numeral out (inpainting) and store the result in `SKILL_ICONS_R0` under the same icon key. The list already prefers that container.
- Skill Gamble's "II" is its series number (Life Gamble I → Skill Gamble II), not a data error.

## Finish the TTO 1.7.0 cards at home

The other 7 groups' card updates are merged on the branch **`tto170-cards`**: Bat, Bison, Cat, Mole, Penguin, Panda / Wolf / Chameleon / Monkey / Whale, and Engine. It is one commit on top of the live site, and the full validator passed on it. The live site doesn't change until that branch is merged into `skill-cooldown-lookup`.

**Bring this by flash drive first:** the TTO decompile, `DecompiledSource_TTO_2026-11-18\`.
- It is git-ignored and 1.5 GB. Without its `tools\` folder it is about 0.5 GB; `tools\` is only needed to redo the decompile.
- Put it in the home repo root, next to the other decompile folders.
- Steps 2 and 3 read its `research\patch_1118\pseudo_new\` and `pseudo_old\`, `dump.cs` and `BUILD.md`.
- Home keeps at most 3 TTO builds (AGENTS.md). If this is a 4th, delete the oldest after checking nothing borrows from it.

**Steps:**
1. `git fetch`, then `git switch tto170-cards`. To read the work: `git diff skill-cooldown-lookup...tto170-cards`.
2. Re-review two groups. Bison and Panda / Wolf / Chameleon / Monkey / Whale stopped after 2 review rounds, so their last fixes were never re-reviewed. Have Claude adversarially review those two groups' changes against `pseudo_new`.
3. Settle the critic's gaps, listed at the end of this file:
   - Mole's `AutoGyroGun::AIControl` change;
   - the cross-class Fire Arena summon cleanup;
   - the 80 s potion cooldown (BUILD.md wrongly says it isn't in the client);
   - whether the non-skill patch-note lines get pop-up lines.
4. Write the `tto-1.7.0` `PATCH_HISTORY` entry:
   - title `TAILSTOPIA 1.7.0`, at the top of the array;
   - one ranked list built from the Sheep and Rabbit lines above plus the groups' lines below, with `tiers`;
   - follow the house style of the `tto-1.6.2.4` entry; the validator refuses เซิร์ฟเวอร์, server-side and โค้ด in a line.
5. Finish: run `node scripts/validate_skills.js --full`, add the changelog entry, commit, merge into `skill-cooldown-lookup` (a fast-forward), push, and delete the branch (`git push origin --delete tto170-cards`).

### Sheep: open points

- With the Lucent Barrier toggle on, Reverse / Repel's guide hover and stat glow may still show CHA ranges. The cause is a function-valued `durWrapped`, which is treated as always true.
- Whether the Free Cast fix covers each Revive refusal path isn't traced yet.
- Divinity ×1.35 inside Grand Codex and the Codex slow (45 % for 5 s) may be unannounced. If the full patch notes lack them, tag those lines `"sneak"`.

## Watch

- **Skill view counts:** they started on 18/11/2026. GoatCounter's free plan has a monthly cap, so check the dashboard's monthly hits after a week. Each skill counts once per browser session.

## Saved pop-up lines for tto-1.7.0 (Thai, ranked within each class)

**Sheep.** Lines 1 and 4 are adjustments.
1. `["Sheep", "**Grand Codex** อยู่ได้ **20 วินาที** คงที่ → **6 วินาที** เพิ่มตาม CHA สูงสุด **25 วินาที** เปิดหน้าทุก **2 → 1.5 วินาที** รัศมี **12 → 13 m** ฮีลและหอกแสงเพิ่มตาม INT แทน TAL ฮีลเฉพาะเผ่า Tails / Elementals (**Auto Gyro Gun** / **Barrel Bot** ไม่ได้ฮีล) และศัตรูช้าลง **50% 2 วินาที → 45% 5 วินาที** (มี **World Encarta**: **62% → 60%**)"]`
2. `["Sheep", "**Grand Codex** ศัตรูในวงคัมภีร์ของฝ่ายเราโดน **Divinity Sword**, **Divinity Spear** และ **Divinity Axe** แรงขึ้น **×1.35**"]`
3. `["Sheep", "**Gleaming Breath** ไม่ให้ DEF **+30** / VIT **+20** แล้ว เป้าหมายที่ฟื้นไม่รับดาเมจ **3 วินาที** ได้ Illuminate / Bless เลเวลเดียวกับที่แกะร่ายเอง เพื่อนในรัศมี **20 m** รอบเป้าหมายฟื้น HP **10%** และ KO เต็ม คูลดาวน์ **Revive** เลเวล **2** **180 → 108 วินาที** และท่าเร็วขึ้น (ยืนนิ่ง **1.7 → 1.31 วินาที**)"]`
4. `["Sheep", "**Lucent Barrier** ได้ผลกับ **Repel** ด้วย สะท้อน **10% / 20% → 35%** ระหว่างมีบาเรียดาเมจม่วงที่โดนลดลงครึ่งหนึ่ง อยู่ **3 วินาที** + CHA → **5 วินาที** (Reverse) / **6 วินาที** (Repel) คงที่ คูลดาวน์ **Reverse 240 → 180** และ **Repel 120 → 114 วินาที** และท่าเร็วขึ้น (ยืนนิ่ง **1.4 → 1.04 วินาที**)"]`
5. `["C6", "สกิล C6 ของ Sheep เปลี่ยนสกิลที่ต้องเรียนก่อน: **Gleaming Breath** ต้องมีแค่ **Revive** เลเวล **2** (ไม่ต้องมี **Purify**) **Lucent Barrier** แค่ **Reverse** เลเวล **2** (ไม่ต้องมี **Eden Sanctuary**) **Grand Codex** ต้องมี **Over Heal** เลเวล **2** + **Repel** เลเวล **2** แทน **World Encarta**"]`
6. `["Sheep", "**Free Cast** / **Return Cast** ไม่สุ่มคืน MP เมื่อกดใช้สกิลแล้วถูกปฏิเสธจนได้ MP คืน (เช่นกด **Revive** ใส่ตัวเอง)", "bug"]`

**Rabbit.** Lines 1, 4 and 8 are adjustments.
1. `["Rabbit", "**Medic Turret** ป้อมอยู่ **15 วินาที → 15 วินาที + CHA** (สูงสุด **45 วินาที**) ฮีลรอบป้อมและยิงแคปซูลได้ **10 → สูงสุด 30** ครั้ง"]`
2. `["Rabbit", "**Bounty Hunt** ฆ่าเป้าที่ติด Bounty ได้ ตัวเองและเพื่อนทั้งทีม (ไม่จำกัดระยะ) ฟื้น HP **10% → 25%** + MP **30** + SP **35** (เดิมฮีลแค่เพื่อนในวง **12 m** และ SP **+20** เข้าตัวเองคนเดียว) ไม่รวมสัตว์อัญเชิญและทหารรับจ้าง"]`
3. `["Rabbit", "**Coin Ricochet** MP / SP **40 / 45 → 35 / 35** เด้งได้ **3 → 6** เป้าต่อเหรียญ (รวม **12 → 24** ฮิต) ค่าเหรียญตอนกด **100 G → 0** จ่ายฮิตละ **25 → 15 G** (สูงสุด **360 G**)"]`
4. `["Rabbit", "**Medic Turret** แคปซูลยิงใส่เพื่อน **1** คนแบบสุ่มในระยะ **8 m** (เดิมคนที่ HP น้อยสุดใน **10 m**) ยาเริ่มเลเวล **1** โดนชนิดเดิมซ้ำ **+1** (สูงสุด **4**) แทนการสุ่มเลเวล **1–4**"]`
5. `["Rabbit", "**Bounty Hunt** MP / SP **55 / 50 → 35 / 40** ระยะ **22 → 30 m** เป้าที่ติด Bounty รับดาเมจ **+15% → +20%**"]`
6. `["Rabbit", "**Shooting Array** ทุกนัดแรงขึ้น **×1.35** (ปัดลง) กับเป้าที่ติด Gilded จาก **Coin Ricochet**"]`
7. `["Rabbit", "**Medic Turret** ป้อม HP **10 × (เลเวล ÷ 2) → 2500** (เลเวล 100: **500 → 2500**) วงฮีลรอบป้อม **6 → 8 m**"]`
8. `["Rabbit", "**Bounty Hunt** Bounty อยู่ **12 วินาที → 12 วินาที + CHA** (สูงสุด **35 วินาที**) เวลาที่ฆ่าแล้วได้รางวัลยาวขึ้นตาม"]`
9. `["Rabbit", "**Medic Turret** แคปซูลลอยไปถึง **0.25 → 0.32 วินาที** (โค้งตามตัวเพื่อน)", "sneak-nerf"]`
10. `["Rabbit", "**Bounty Hunt** การตายของเป้าที่ระบบยืนยันมาช้า ยังได้รางวัลถ้ายืนยันภายใน **4 วินาที** หลัง Bounty หมดเวลา", "sneak"]` (optional; only in the modes where the game decides HP itself)

## Saved pop-up lines from the other groups (merged on branch `tto170-cards`)

Each line is `[tag, text, kind?]` for `PATCH_HISTORY`. "adj" marks an adjustment (fixed ↔ stat-scaled, or a weaker-but-longer trade).

### Bat

- **Cards:** `bat_crimsonVerdict`, `bat_massCast`, `bat_mimic`, `bat_evilTwin`, `bat_nightfallSwarm`.
- **Review:** needs-fix → clean.

1. `["Bat","**Mimic** แปลงร่างเป็นมอนสเตอร์ได้ถึงเลเวลของตัวเอง: มอนสเตอร์เลเวลไม่เกิน **35 / 50** (เลเวลสกิล **1 / 2**) → ไม่เกิน **35 / 50** หรือเลเวลของค้างคาว (ค่าที่สูงกว่า) ส่วนฮีโร่ยังต้องเลเวลไม่เกินค้างคาวเหมือนเดิม"]` — Announced. max(Bat level, 15 x rank + 20) is never lower than before, so it is a buff for every build
2. `["Bat","**Evil Twin** ร่างวิญญาณของบอสตัวใหญ่ไม่จมลงพื้นแล้ว มองเห็นและตีปกติโดนตามเดิม ตัวที่สูงเกิน **6 m** ตอนกระชากออกมายังตัวเท่าของจริง แล้วย่อลงระหว่างลอยมาข้างค้างคาวจนสูง **6 m** ขนาดตัวที่ตีโดนก็ย่อตาม (HP และดาเมจเหมือนเดิม)","bug"]` — Announced fix. Size-based (any body taller than 6 m), not tied to boss names
3. `["Bat","**Mass Cast** เป้าหมายที่เลือกอยู่ใน **6** ตัวที่โดนเวทกระจายเสมอ (เดิมถ้ามีศัตรูรอบเป้าหมายเกิน **6** ตัว เป้าหมายที่เลือกอาจไม่โดน) ได้ผลกับทุกเวทที่กระจายได้ รวม **Shadow Gaze**","bug"]` — Announced as 'แก้ไข Masscast คาวทำงานไม่ถูกต้อง' (1.7.0 notes line 40); MassCastTargets is the patch's only Mass Cast logic change. BB has the same skip (Bat.cs:25376)
4. `["Bat","**Crimson Verdict** SP **50 → 35**"]`
5. `["Bat","คำอธิบายในเกมของ **Crimson Verdict** บอกถูกแล้วว่า **Mass Cast** แค่ขยายวงเลือกเป้า ไม่เพิ่มดาเมจ และ **Nightfall Swarm** บอกโบนัส **+5%** ต่อดีบัฟกับสถานะสุ่ม **2** อย่าง ส่วนที่เพิ่มว่า PvP เริ่มเกมติดคูลดาวน์เต็ม ที่จริงติดคูลดาวน์เต็มตอนเริ่มทุกภารกิจ ทั้งภารกิจปกติ PvP และ Arena (เหมือนเดิม)"]` — Text-only line, ranked last; drop it if the pop-up should list mechanics only. Kind left empty: the notes claim only a text addition, which is true, it just names fewer modes than the code covers

Open questions:
- Mass Cast's TTO [Fix] line implies a BB bug: in BB the clicked target can be skipped with more than 6 enemies (Bat.cs:25376 takes the first 6 alive in FindAreaTarget order). The BB Mass Cast card has no bbBug for it. Should a bbBug go on the BB card and the BB issues page? I left it alone because it is outside the TTO 1.7.0 scope
- BatEvilSpirit::MeasureShape and RPC_mimic_cast are not in pseudo_new (not in targets_new.tsv). I checked them by calls only: Init -> MeasureShape -> CharacterController set_radius / set_height / set_center, mimic_cast -> MimicMonsterCap, plus the dump.cs constants MaxSpiritHeight 6 and LiftFit 0.5. The mLift = max(0, -minY) and mFit = 6 / height formulas come from BUILD.md's readers; I did not re-
- RPC_mimic_over: no receiver found in the client, so its effect (if any) is unknown

### Bison

- **Cards:** `bison_unchainedFury`, `bison_berserkerRush`.
- **Review:** needs-fix → needs-fix (the last fixes were not re-reviewed: re-check them).

1. `["Bison","**Unchained Fury** MP **40 → 25** SP **40 → 30** และทั้งท่าเร็วขึ้น จบท่าแล้วเดินได้ที่ **1.80 → 0.75 วินาที** (ได้ **Berserker Rush** ที่ **0.62 → 0.26 วินาที** ช่วงที่ไม่โดน KO และไม่กระเด็นระหว่างท่าก็สั้นลงตามท่า)"]` — The patch notes cover it (ท่าเร็วขึ้น 1.8 → 0.75 วิ, MP 40 → 25 / SP 40 → 30), so kind is empty. I counted it as a buff. The only thing that gets worse is the KO-free window during the action, and it shrinks only because

Open questions:
- Buff or [Adjust]? A cheaper, shorter action is better for nearly every build, but the KO / knock-back immunity, which only lasts while the action runs, drops from 1.8 to 0.75 s. I set adjustment: false. Flip it if the user counts that as a trade-off.
- The TailsTopia site table at the end of the TTO Lv 100 section still says 40 / 40 for cell 452. I left it because it is the record of what the site said on 2026-10-31. The code-based subsection above it now says 25 / 30.

### Cat

- **Cards:** `cat_royalFlush`, `cat_swiftPace`.
- **Review:** needs-fix → clean.

1. `["Cat","**Royal Flush** ดาเมจลดลง: ระเบิดลูกละ **160% → 140% LCK** ดาบไพ่ **500% → 440% LCK** รัศมีระเบิด **8 → 7 m** ดาบไพ่ **9 → 8 m** และทั้งท่าช้าลง (ขยับได้ที่ **0.74 → 0.83 วินาที** ระเบิดลูกแรก **1.35 → 1.52 วินาที** ห่างกันลูกละ **0.12 → 0.135 วินาที** ดาบลง **2.55 → 2.875 วินาที**) ตัวอย่างที่ LCK **100** มือ Royal Flush โพดำ **5** ใบ: ระเบิดลูกละ **460 → 403** ดาบ **500 → 440** รวม **2,800 → 2,455** (ก่อนหัก DEF)"]` — All of it is in the patch notes ('ร่ายช้าลงเล็กน้อย' covers the slower blast and sword times). It is worse for every build, so it is a plain nerf.
2. `["Cat","**Swift Pace** วาร์ปทะลุกำแพงไม่ได้แล้ว: จุดด้านหลังเป้าหมายต้องไม่มีสิ่งกีดขวางคั่นจากเป้าหมาย และสูงหรือต่ำกว่าเป้าหมายไม่เกิน **1.5 m** ไม่อย่างนั้นใช้ไม่ได้ (คืน SP)","bug"]` — Matches the patch note 'แก้ไข แมวโดดหลังแล้วทะลุแมพ' (TTO1118:Cat::doSkill@0x1BF06F0). Backflip's code is unchanged. The refund names only SP because the skill costs only SP (cost:{sp:10}, ttoTip mp:0).

Open questions:
- Swift Pace is tagged [Fix] on the card and 'bug' in the pop-up. The BB code (Cat.cs:6557-6600) has no wall or height check, so this is a BB bug that TTO fixed, and the notes call it a fix. It also blocks warps across thin walls that used to work. If the user wants that counted as a restriction, retag it ([Nerf] / [Adjust]). No bbBug line was added to the BB card, because the BB behaviour was not c
- The Swift Pace Linecast uses layer mask 5 (layers 0 and 2) and ignores triggers. Which map objects sit on those layers in TTO was not traced, so the desc says กำแพงหรือสิ่งกีดขวาง in general terms.

### Mole

- **Cards:** `mole_twinWarhead`.
- **Review:** needs-fix → clean.

1. `["Mole","**Twin Warhead** ระเบิดทอง KO **20 → 5** (ทั้งของตุ่นและของ **Barrel Bot**) ดาเมจและรัศมีเท่าเดิม"]` — Announced change (notes: KO ระเบิดทอง 20 → 5 ต่อลูก). The blast happens once per pair, which the card already says. It is worse for every build, so it is not an adjustment.
2. `["ระบบ","**Fire Arena** ขึ้นรอบใหม่ (เปลี่ยนคู่) ซัมมอนทุกตัวที่ค้างจากรอบก่อนถูกลบทั้งหมด ทั้งป้อม **Auto Gyro Gun**, **Barrel Bot** และ **War Capital** ของ Mole และซัมมอนของ Monkey, Bat และ Rabbit",["bug","sneak"]]` — Retagged from 'Mole' to 'ระบบ', as the 1.6.2.4 cross-class lines are tagged. TTO1118:M6001_FireArena::DestroyLeftoverSummons@0x17508f0 destroys every CharacterControl with isSummon (0x2f1), called from InitNextRound d__8
3. `["Mole","ตอนขี่มู ตัวนับป้อม **Auto Gyro Gun** เช็ก **Hidden Turret** จากตัวตุ่นแล้ว (เพดาน **8** / **12** ตัว) เดิมเช็กจากตัวมู","bug"]` — AutoGyroGunCap / reportAutoGyroGunCount read hasSkill(403) through CharacterControl.mTransformer. The cap is still only displayed.
4. `["Mole","**War Capital** เลือกเป้าแบบเดิมทุกอย่าง: ฐานยิงทุก **24 วินาที** เมื่อมีศัตรูในระยะ **36 m** รอบตุ่น ใส่ศัตรูที่สุ่มเลือก","fix"]` — The notes claim 'แก้ไข WarCapital ล็อค Target ไม่ได้', but no War Capital method changes its logic.
5. `["Mole","ท่าทาง **6-7** ของ Mole และ Bison: วิธีเล่นท่าเหมือนเดิม ไม่มีส่วนที่แก้เฉพาะสองอาชีพนี้ ไฟล์ท่าทางของทุกอาชีพถูกแพ็กใหม่ทั้งหมด จึงอาจแก้ที่ตัวท่าเอง","fix"]` — The notes claim 'แก้ไขท่า 67 ตุ่นและ ไบสัน'. The play logic is unchanged. The animation bundles are not in the client folder, so a fix inside the assets cannot be checked offline.

Open questions:
- 6-7 emote (Mole / Bison): the sixseven clips are in each class's animation bundle. That bundle is downloaded from the CDN and is not in the local client folder. All 12 classes' bundles changed name, size and CRC in aa/catalog.bin (a full rebuild), so a fix inside the animation itself can't be ruled out offline. The pop-up line is the claimed-fix chip the brief asks for, and the line hedges this. I
- War Capital 'ล็อค Target ไม่ได้': the claim is ambiguous. It may mean players could not select the base as a target, not that the base could not aim. No War Capital method (OnWarCapital, RPC_warCapital_create / _fire, RPC_warMissile_fire, Mole_warCapital.*) changes logic, and no targeting method references it. A live check would settle it.
- Fire Arena summon cleanup covers every class, but it is written only in the Mole class file, to keep this group's diff inside Mole. The applier may also want a line in 12Tails-Mechanics-Reference.md, since AGENTS.md puts cross-class findings there. The pop-up line is now tagged 'ระบบ'.
- Validator: one pin was added inside the Mole C6 block of scripts/validate_skills.js, next to the Kaiser Arsenal check. It is class-local, not shared: tw.ko === "5" && tw.dmg === "talAdjust(40)".

### Penguin

- **Cards:** `penguin_iceBlock`.
- **Review:** needs-fix → clean.

1. `["Penguin","**Ice Block** ใครที่ยืนอยู่ตรงจุดที่ก้อนน้ำแข็งเกิด (ตัวเอง เพื่อนร่วมทีม หรือศัตรู) เดินทะลุก้อนนั้นได้ ก้อนอื่นยังขวางตามปกติ","sneak"]` (adj) — Penguin_iceBlock::IgnoreBodiesInside@0x1E0D6E0: an OverlapBox over each block mesh (mask 0xFFFFFFFB, triggers ignored), then Physics.IgnoreCollision for every CharacterController found. It is not in PATCH_NOTES_1.7.0. 'b

Open questions:
- How did a character inside a freshly spawned ice block behave before 1.7.0: pushed out, or stuck? That depends on prefab physics, not code (BB Penguin_iceBlock.cs and TTO1109 have no collision step). A live check on BB or old TTO would settle whether the pop-up line should also carry 'bug'. The card's change note would stay [Adjust] either way, unless the user counts the BB behaviour as a BB bug.
- The relayed user request ('Class gate, mock be the placeholder unupscaled version first') is not part of this Penguin staging step. Nothing was done for it here.

### Panda / Wolf / Chameleon / Monkey / Whale

- **Cards:** `wolf_nAttack`.
- **Review:** needs-fix → needs-fix (the last fixes were not re-reviewed: re-check them).

1. `["Wolf","**nAttack** ตอนเปิด **Dark Edge** ได้ผลจากบัฟ / ดีบัฟที่ปรับดาเมจแล้ว เช่น **Brave Spirit** เลเวล **4** ฮิต **100 → 110** (คูณก่อนบวกค่าสุ่มจาก LCK)","bug"]` — TTO1118:Wolf.<RPC_nAttack1..4>d__N::MoveNext: dmgAdjust(hitDmg) + roll, was hitDmg + roll
2. `["Panda","**Wind & Cloud** และ **Rain & Storm** หันไปทางเป้าที่เลือกก่อนออกท่าเมื่อเปิด **Auto Skill** เหมือนสกิลเล็งเป้าอื่นของ Panda เช่น **Three Steps** (เดิมออกท่าไปทางที่หันหน้าอยู่เสมอ)","bug"]` — TTO1118:Panda::doSkill@0x1d9a2e0 (autoAimSkill read only on the aimed casts: Three Steps, Rushing Falcon, Pummel, Tower Rush, Drunken Fist, Water Monkey, Water Crane, Qi Strike, Roll, now Rain & Storm and Wind & Cloud)
3. `["Monkey","ร่าง **Fire Avatar** ไม่แสดงชุดแฟชั่นทับร่างแล้ว","bug"]` — TTO1118:CharacterControl::ShowFireAvatarOnly@0x2519c30

Open questions:
- Tag for the wolf_nAttack line: I used [Buff]. It is not [Fix], because BB also leaves damageMod out of Effect Damage by engine design, not by a code bug. With a buff it is better for every build. Under a damageMod debuff on the Wolf (TTO windBound -0.25, Miracle Blend enlarge) the hit is now lower. Say if you want [Adjust] instead. The pop-up line uses kind 'bug' because the patch notes present it
- Panda Wind & Cloud / Rain & Storm: no card change, following the Whale aim-option precedent. If you want the TTO tab to say it, a desc line like '• เปิด **Auto Skill** และเลือกเป้าไว้ จะหันไปทางเป้าก่อนออกท่า' could go on both cards.
- The glossary entry 'ดาเมจม่วง' says purple damage skips dmgMod and uses Dark Edge as its first example. On TTO 1.7.0 Dark Edge is an exception. The TTO [darkEdge] popup now says so; the glossary is not server-aware and was left as it is.
- Risk found, not fixed (shared code, out of scope): the shared dmgAdjustAtRoll used by every hit() card computes ceil(damageMod x d) in double. The game works in float32 (BB CharacterControl.cs:20489, and TTO). At damageMod 1.1 (Brave Spirit 4) on raw 100 the page shows 111 while the game deals 110. This affects every card's Final when a Mods-popup dmgMod is active. The new Dark Edge path uses floa

### Engine and Common

- **Cards:** `rabbit_medResearch`.
- **Review:** clean.

1. `["ระบบ","คูลดาวน์ **Potion** เป็น **80 วินาที** ทุกขั้น เดิมคิดตามขั้นของยา ขั้นละ **15 วินาที** (ขั้น **1–5** = **15–75 วินาที**) จึงรอนานขึ้นทุกขั้น และ Demonic Potion ของทีม **150 → 80 วินาที**"]` — TTO1118:GameGui.<UseGeneralFieldItem>d__1152@0x20C8C80 (potion 15 x the item code's last digit -> 80 flat) and <UseTeamDemonicPotion>d__1151@0x20C9C70 (150 -> 80). The note says 'ให้เหลือ 80' (cut to 80), but against 1.6
2. `["ระบบ","คูลดาวน์ **Flag** **720 → 80 วินาที** และ **Drug** (เช่น ยาจากห้องแล็บกระต่าย) **90 → 80 วินาที** กระต่ายที่มี **Med Research** **45 → 40 วินาที**"]` — Same method. BUILD.md's 'Not in the client' line about these cooldowns is wrong: the client sets them.
3. `["ระบบ","**Pandora Strike** (บัฟจาก PandoraBug ในแคมป์กิลด์) ทอยเมื่อตีปกติโดนศัตรูที่ไม่ใช่ผู้เล่น ขยะตกลงจุดนั้นหลัง **0.5 วินาที** ทำดาเมจม่วง **29** และ **10 KO** กับศัตรูที่ไม่ใช่ผู้เล่นทุกตัวในรัศมี **2 m** (ไม่คิด DEF และสเตตัส) คูลดาวน์ **18 วินาที** นับจากครั้งที่ออก"]` — TTO1118:BaseHero.<onNormalAttackHit>d__N@0x1B58BA0 and <PandoraStrike>d__187@0x1B468F0. The chance is the buff's value, set by the server. The client checks no game type.
4. `["ระบบ","บัฟต้านสถานะจากสัตว์ในแคมป์กิลด์ทอยตรงๆ ไม่คิด LCK (ต้าน **30%** ได้ **30%** เสมอ) และทอยแยกต่อจากค่าต้านของอุปกรณ์"]` — TTO1118:CharacterControl::CampWardChance@0x25067A0, rolled in RPC_AddStatus#2@0x25126C0 after the per-status gear resist. The code covers 15 statuses; the notes' pets name 7.

Open questions:
- BUILD.md (DecompiledSource_TTO_2026-11-18, read-only for me) says the Drug / Potion / Flag 80 s cooldown is 'Not in the client'. That is wrong. The client sets all three by cType in TTO1118:GameGui.<UseGeneralFieldItem>d__1152::MoveNext@0x20C8C80 (flag 720 -> 80, potion 15 x last digit -> 80, drug 90 / 45 -> 80 / 40, new brew 3 s) and <UseTeamDemonicPotion>d__1151@0x20C9C70 (150 -> 80). semdiff4 s
- In 1.6.2.4 a potion's cooldown was 15 x the last digit of the item code. TTO's item codes come from the server's item table. I assumed BB's f_hpp/mpp/spp 1-5 (15-75 s), which makes 80 s worse at every level. A TTO potion whose code ends in 6 or more would have waited 90 s or longer before. This cannot be settled from the client.
- Proposal, not added: a COMMON_SERVER_NOTES.tto row 'คูลดาวน์ยา' like Reborn's potion row, e.g. '• [Buff] คูลดาวน์ของยา (Potion) และ Drug **150 → 80 วินาที** และ Flag **720 → 80 วินาที**'. Today no TTO page shows potion or flag cooldowns.
- Proposal, not added: status-glossary / Special Pet Info entries for the new guild-pet statuses (pandoraStrike 9119, resistSleep..resistAcid 9102-9116, hpUp 9117, mpUp 9118, mkoUp 9101). Their values come from the server, and hpUp / mpUp / mkoUp were not traced past their addStatus branch.
- Pop-up tag: I used 'ระบบ', as the tto-1.6.2.4 entry does for game-wide lines, rather than 'C6' (none of these lines is a Lv 100 rule).
- The Rabbit group sets Bounty to +0.2. Its card-level hitModAdd is added in double precision, so the snapped float32 value 1.2f - 1 differs from 0.2 by 5e-8. This is harmless and I left it.

## Critic: what no group covered yet

- **mole:** BUILD.md Mole bullet: 'AutoGyroGun::AIControl@0x1ccd070 changed' (named as a candidate for the arena-pairing turret removal) is not accounted for. The Mole group found DestroyLeftoverSummons for the Fire Arena fix but never says what AIControl changed. (Every BUILD.md bullet needs a mapping. A quick read-only check of fp_old/fp_new.json shows the same string, call and TypeInfo token counts (0 added, 0 removed). Only registers moved (rdi->rbx) and fie)
- **engine:** Patch note '[CHANGED] ปรับให้เสาในอารีน่า 7v7 ทำดาเมจแรงขึ้น' (7v7 arena towers deal more damage) (The engine group lists only 'arena tower gating and kill feed' (the 5v5 / 10v10 order rule). 7v7 tower damage is not mapped anywhere. It has no Bible surface, so it only needs a noCardChange line.)
- **engine:** Patch note '[FIXED] แก้ไขช่อง skill support สามารถกดใช้ได้เลย ไม่ต้องลากลง hotbar' (the support-skill slot can be clicked directly) (Not mapped. The Bible has 12 per-class support-skill cards under Common, but a grep of index.html finds no desc that tells players to drag them to the hotbar, so no card changes. It still needs a noCa)
- **engine:** The other non-skill patch-note lines: ADD items and Krathong mount, login/OPW theme, endless Mimi quest, champion weapon with hidden slot disappearing, Mimi vanishing, arena rewards outside the schedule, ChatLog limit, party-portrait camera, Raffle chat zone, quest rerun 20/28, friend list over 50, dance stage, and the whole guild-system / guild-page block except the pet buffs (The engine group covers only 'Arena..., Krathong cart seats, guild camp, quests and storage: no Bible surface'. One blanket noCardChange line naming the rest closes the coverage list. None of these ne)
- **engine:** Fire Arena leftover-summon cleanup (M6001_FireArena::DestroyLeftoverSummons) is cross-class (Mole, Monkey, Bat and Rabbit summons) but is written only in mole-skill-reference.md (AGENTS.md §4 puts cross-class engine findings in 12Tails-Mechanics-Reference.md. The engine worktree adds a new 'TTO patch 1.7.0, game-wide' section (Mechanics ref, new lines after 767). The line belo)
- **engine:** BUILD.md line 'Not in the client: the Drug / Potion / Flag 80 s cooldown' is wrong (GameGui.<UseGeneralFieldItem>d__1152@0x20C8C80 sets it) (The engine group found it but could not edit the file. DecompiledSource_TTO_2026-11-18/BUILD.md is a git-ignored .md, not a .cs file, so the edit guard allows the edit. The applier should correct it, )
- **sheep / rabbit (main checkout):** Sheep and Rabbit pop-up lines for a new tto-1.7.0 PATCH_HISTORY entry (HEAD 84d08722 already ships the Sheep and Rabbit cards, but PATCH_HISTORY has no 1.7.0 entry yet (validator output: '2 entries, newest tto-1.6.2.4'). None of the 7 staged results includes Sheep or Rab)
