# Special Pet Info: design (2026-10-18)

## Intent

A new Bible hub tool that shows every pet whose code does something beyond plain stats: what it does, how often, how far, how strong at each pet level, and where the in-game tooltip is wrong. Players today only see the item tooltip, which is wrong or vague for many of these pets (S. Kumo claims to cleanse but strips your own buffs; L. Carron (P)'s anti-sleep does nothing). All facts come from the BB client code, recorded in [12Tails-Mechanics-Reference.md §4.9](../../../12t_reference/12Tails-Mechanics-Reference.md#49-pets-effects-that-are-not-stats-verified-2026-10-18).

## Goals

- One page per special pet, chosen from a list grouped by role, readable without knowing the code.
- Every number recomputes for pet level 1–9 and, where a chance uses LCK, for the owner's LCK.
- Show the area to scale, the firing rhythm, and the tooltip-versus-code differences.

## Non-goals

- Pure stat pets (balloons except Bigbug, Smash / Soccer Ball, festival kites, L. BD Mellon, Cake Carron, Disco Peppon, S. RedPanda, S. Santa Skunk, S. ClownDemion, S. Doov, S. BarrelBot, the eight S. bug pets) and S. SamuraiBug (never in game).
- Where to get a pet and upgrade materials (item names were not decoded; possible later).
- ToT / TTO differences (no code for those servers).
- New entries on the BB issues page (the hub rule: those are added only when the user asks).
- The other three mocked layouts' extras (card deck, radar sequencer, leaderboard).

## Anti-goals

- Any number not traceable to reference §4.9 (no approximations, no wiki values).
- Code names in player text (`lckAdjust`, `rangeMod` is the one allowed exception, as elsewhere in the Bible).
- A cost at hub start-up: the tool builds its page on first open only.
- A third font, a gold glow on hover, a reduced-motion gate.

## Decided with the user

- **Layout A, "Codex"** (picked from 4 mocks, 2026-10-18): roster on the left grouped by role, the selected pet in full on the right.
- **Damage words:** white damage is **ดาเมจขาว** (glossary link `^^ดาเมจขาว^^`), purple is `^^ดาเมจม่วง^^`; never ดาเมจตรง in this tool.
- **Pet families** (5 Ninja Kites, 3 Savers) are one roster entry; the hero ring shows one icon, and a row of variant buttons under the title switches icon, name and id (kites show their +7 stat in its stat colour). Fix of the mock where three icons spilled out of the ring.
- **Name:** "Special Pet Info".

## The page (layout A)

**Roster (left, ~300 px, scrolls inside itself):** four groups with a count, in this order:
1. โจมตีเอง (10): L. Mad Carron, L. Mad Peppon, L. Mad Cocon, MiniSkyBug, MiniCrystalBug, MiniAncient, MiniReef, MiniMok, MiniGolden, MiniNemesis.
2. บัฟและพื้นที่ (8 entries, 14 pets): Bigbug Balloon, Saver family, S. Kumo, S. FlowerBug, S. Ice Mixer, S. Ammonite, S. IcePenguin, Ninja Kite family.
3. ทำงานเมื่อโดน (3): S. Anubi, S. Karazo, S. PirateFish.
4. กันสถานะ (14): the 13 anti-status pets, then L. Carron (P) (no effect).

Each row: 32 px icon (`GEAR_ICONS`), game name (`GEAR_DATA`), a red ⚠ when the tooltip and the code differ, and on the right the interval (a clock glyph + number) or the status it resists. Selected row: gold left bar and soft gold fill.

**Detail (right), top to bottom:**
1. **Hero:** 96 px gold ring with the 72 px icon; name; chips: role, warnings (ดาเมจม่วง, โดนเพื่อนได้, ล้างบัฟตัวเอง, ไม่ทำงาน, ช่องข้อมูลผิด), required level, item id; the variant row for families; on the right the level pills 1–9 and, for LCK-based chances, an LCK box. Pets whose level does nothing or that cannot be upgraded show a chip instead of the pills (Kumo, Karazo, Bigbug Balloon: "อัปเลเวลไม่ได้"; PirateFish: "เลเวลไม่มีผล").
2. **Description:** one Thai paragraph in the desc house style (bible-desc-writing), rendered with `renderRichText`, numbers live.
3. **Four tiles:** attack pets: ทำงานทุก (วินาที), ดาเมจ (ขาว / ม่วง), เป้าหมาย, ระยะ. Others: when it fires, its main value, ใส่ได้ตั้งแต่ (level requirement), whether the pet level matters.
4. **Range (pets with an area):** to-scale top-down SVG, rings every 5 m to 25 m, you at the centre facing up; the pet's area filled in the role colour; areas centred on the pet or kite drawn around a separate marker (its distance from you is illustrative, say so in the caption); MiniReef draws the 18 m search dashed plus the 6 m blast; for attack pets the other Mini pets' areas as faint labelled rings.
5. **Timeline (timed pets):** the first 60 seconds (or one full interval when longer, e.g. Ammonite 120 s), a tick per firing, MiniNemesis's 4 ray ticks at +0.4 s steps, MiniReef's hit 1 s after the mark; header gives firings in the window and, for attack pets, **ดาเมจต่อนาที (คำนวณ)** for 1 and 5 targets with the assumption stated (a target always in range).
6. **Anti-status matrix (when a กันสถานะ pet is selected):** all 14 as small cells, status name and chance at the current level and LCK; the selected one outlined; L. Carron (P) in red with ✗.
7. **เกมบอก vs โค้ดจริง strip:** left, the item tooltip's `special` line at the current level plus the Thai description from the game (muted); right, what the code does. Red frame when they differ, green "ตรงกับโค้ด" frame when they match.
8. **Footer facts:** pet damage is fixed (no DEF, TAL or LCK; ^^ดาเมจขาว^^ still meets shields); timed effects run only in missions and PvP; pets level 1–9 at the pet shop; source is the BB client code.

**Phone (≤ 760 px):** the roster becomes a sticky horizontal strip of icons grouped by role; the detail stacks in one column; the range SVG scales to the width; tiles go two per row.

## Data

A `PET_INFO` array in `index.html` (near `GEAR_DATA`), one entry per roster row: id, role, required level, optional `vars` (id, label, stat), and functions of `N` (pet level) and `L` (LCK) for interval, area (radius, height, centre, max targets), hit (white / purple, damage per target `k`, KO, hits and tick, delay), chance, Thai description, game tooltip line, code note and flags (ally hit, strips own buffs, no effect, level unused, cannot upgrade). Every value is transcribed from reference §4.9; nothing is re-derived in the page. The tooltip strings come from `PetData.cs` (`itemClass.special`, English, with the level substituted as the game does) and `PetData_th.cs` (`getDes`, Thai).

Text follows bible-desc-writing: วินาที, เลเวล, `**…**` numbers, `[status]` tokens, `^^ดาเมจขาว^^` / `^^ดาเมจม่วง^^`, areas as `รัศมี **N m** สูง **3×rangeMod m** รอบตัว / รอบสัตว์เลี้ยง`, MiniNemesis `ทรงกลมรัศมี **9 m**`, chances "โอกาส … เพิ่มตามค่า LCK", token spacing rule.

New status popups (both used by other skills too): `wash` = Magical (`StatusData.cs:5681`), removes every Physical Buff of level ≤ its own (`CharacterControl.cs:36103-36189`); `float` = Buff, Magical (`:5885`, `:6944`), removes and resists heavy / groundLock / needlePrison / sticky / frost / lightBind, also resists maim, up to level 2 × its own (`CharacterControl.cs:13115-13185`, `:39790-39812`).

## Wiring

- `TOOLS` entry `pet-info`, category Reference, `fact: () => [40, "ตัว"]` computed from `PET_INFO` (every pet id with a real effect, kites and Savers counted one by one, L. Carron (P) left out), launcher art (see calls), `mount(root)` → `mountPetInfo(root)`.
- Deep link `#pet-info/<pet id>`; a variant id (e.g. `p_sky`) opens its family on that variant. Selection, level, LCK and variants remembered in `localStorage` `12t-bible-pets` (try/catch).
- Panels use the colour tokens and join `THEME_SURFACES` groups so the server looks apply.
- Validator `[PET INFO ERROR]`: every id and variant has an icon and a name; group sizes 10 / 8 / 3 / 14; a fixture of reference values at levels 1 and 9 and LCK 0 / 156 (intervals, damage, radius, KO, chances) must match the page's functions; every description renders with no unresolved token; every deep link resolves; the `TOOLS` entry exists.
- Docs: a section in `.claude/skills/bible-hub-tools/SKILL.md`; the changelog entry on commit.

## My calls (check these)

- Default level 9 and LCK 156 (the CHA / AGI optimizer's default), both remembered.
- Launcher art: a fan of real pet icons (MiniNemesis, MiniGolden, S. Anubi, Ninja Kite …) through a new `gear:<id>` art key, as a placeholder until you want art mocks; the 48 px icons will look soft at stage size.
- The tooltip side shows the item's `special` line computed at the current level plus the Thai description, both as the game shows them.
- Ammonite's timeline uses a 120 s window; IcePenguin, Anubi, Karazo, PirateFish and the anti-status pets have no timeline (they react to events).
- The pet-centred rings use a marker 1.2 m behind you, labelled as illustrative (the real follow distance is set per prefab and was not decoded).

## Left to the builder

CSS details within the Ledger tokens, code structure, the exact Thai sentences (house style, numbers from the reference only), icons for the four role headings.
