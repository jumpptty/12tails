# Handoff (office PC → home PC, 18/11/2026)

Read this after `git pull`. Delete items as they get done, and delete the file when it is empty.

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

## Still in progress on the office PC (can't be finished at home)

### TTO 1.7.0 cards for the other classes

- **Status:** 7 groups were staging their card updates in git worktrees at `C:\tmp\tto170\<group>` on the office PC (workflow run `wf_c9ca55e9-a06`). The groups are Bat, Bison, Cat, Mole, Penguin, Panda / Wolf / Chameleon / Monkey / Whale, and Engine.
- **Why not at home:** they need the TTO 2026-11-18 decompile, which exists only there.
- **To finish:** merge them on the office PC (root `CLAUDE.md`, "Parallel agents on one file"), then run `node scripts/validate_skills.js --full` with every group's `--allow-field-loss` pairs plus these already-committed ones:
  - Sheep: `sheep_gleamingBreath:dep,sheep_grandCodex:hitCount`
  - Rabbit: `rabbit_medicTurret:lckProc,rabbit_medicTurret:secondaryLckProc,rabbit_medicTurret:tertiaryLckProc,rabbit_medicTurret:quaternaryLckProc`

  Those removals are in this commit, so after it the flag is only needed for new removals.

### The tto-1.7.0 patch pop-up

- **Status:** not written yet; it waits for all groups. It becomes one new `PATCH_HISTORY` entry, `key: "tto-1.7.0"`, `title: "TAILSTOPIA 1.7.0"`.
- The Sheep and Rabbit lines are saved below.

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
