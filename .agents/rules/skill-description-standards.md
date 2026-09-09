# Skill Description Container & Dynamic Variable Highlight Standards

This rule governs the design, typography, container styling, and dynamic variable highlights for qualitative skill descriptions across all 12 classes in `12t_projects/player-reference-tool/index.html`.

---

## 1. Skill Description Container (`.sk-hero-desc`)

The skill description is displayed inline inside the hero header card, directly to the right of the skill icon and title.

### Layout & Placement
* **Desktop**: `flex: 1; min-width: 0; margin-left: 14px;` (sits to the right of the title block).
* **Mobile Viewport**: `margin-left: 0; margin-top: 8px; width: 100%; text-align: left;` (stretches full width beneath the title block).

### Visual Styling: Gold Accent Bar
* **Background**: `var(--panel)` (`#1f1712` in Dark Mode, `#efe6d5` in Light Mode).
* **Border**: `1px solid var(--line)` (`#4a3a26` in Dark Mode).
* **Left Accent Bar**: `border-left: 3px solid var(--gold)` (`#c9a227` in Dark Mode, `#8a6a1f` in Light Mode).
* **Border Radius**: `4px`.
* **Padding**: `6px 12px`.
* **Shadow**: `box-shadow: 0 1px 3px rgba(0,0,0,0.3)`.

### Typography
* **Font Family**: `'Prompt', -apple-system, "Segoe UI", sans-serif`.
* **Font Size**: `12px` base with `line-height: 1.45`.
* **Text Color**: `var(--muted)` (`#b0a189` in Dark Mode, `#7a6a55` in Light Mode).
* **Max Clamp**: 2 lines with `-webkit-line-clamp: 2; overflow: hidden; text-overflow: ellipsis; word-break: break-word;`.
* **Auto-Shrinking Font Logic**: An auto-shrink loop checks `scrollHeight > clientHeight` and reduces font size down to `10.5px` if text slightly exceeds 2 lines.

---

## 2. Dynamic Variable Highlight System (Brass Gold)

When a skill description contains values that change based on `rank` (e.g. Blink range `5m` vs `8m`, Falling Stars `12m` vs `16m`) or a passive dependency / toggle (e.g. Dispell cleanse threshold `เลเวล 3` vs `เลเวล 6` with Parallel Shift), they must be dynamically calculated and highlighted.

### Authoring Syntax
In `SKILLS`, author `desc` as a function:
```javascript
// Example: Blink (rank-dependent distance)
desc: (rank) => `วาร์ปเพนกวินพุ่งตรงไปข้างหน้าทันที **${3 * rank + 2}m** ตามทิศทางที่หันหน้าอยู่`,

// Example: Dispell (rank and dependency-dependent cleanse level)
desc: (rank, depRank) => {
  const pShift = (depRank !== null && depRank !== undefined) ? depRank : getDepRank(PENGUIN_PARALLEL_SHIFT_DEP);
  const x = 2 * rank + (pShift ? 1 : 0) + 1;
  return `ปลดปล่อยคลื่นเวทมนตร์ลบล้างสถานะ isMagical() ที่ต่ำกว่า **เลเวล ${x}** ทั้งหมดในระยะ 5m รอบตัว ทั้งเพื่อนและศัตรู`;
},
```

### Parser & Rendering Logic
In `renderHero()`, descriptions are processed as follows:
```javascript
const heroDep = selected.dep || selected.dmgRankDep || selected.dmgDep || selected.cdDep;
const heroDepRank = heroDep ? getDepRank(heroDep) : null;
const descRaw = typeof selected.desc === "function" ? selected.desc(rank, heroDepRank) : selected.desc;
const descStr = descRaw ? String(descRaw) : "";
const descClean = descStr.replace(/\*\*([^*]+)\*\*/g, "$1");
const descFormatted = descStr.replace(/\*\*([^*]+)\*\*/g, '<span class="sk-val">$1</span>');
const heroDescHtml = descStr ? `<div class="sk-hero-desc" title="${descClean}">${descFormatted}</div>` : "";
```

### Highlight Styling
```css
.sk-hero-desc .sk-val {
  color: var(--gold);
  font-weight: 600;
}
```
* **Contrast**: Uses `--gold` (`#c9a227` in Dark Mode, `#8a6a1f` in Light Mode) for high contrast and seamless harmony with the Gold Accent Bar.
* **Typography Safety**: Uses plain inline text styling without padding or borders to avoid clipping Thai tone marks (ไม้เอก, ไม้โท, สระบน/ล่าง).
* **Hover Tooltip**: Raw asterisks `**...**` are stripped for clean native `title` attribute tooltips.

---

## 3. Authoring Guidelines
1. **Qualitative Over Quantitative**: Never include base cooldowns or raw damage formulas inside `desc` (they are shown in the CD chip and Damage chip).
2. **Dynamic Geometry & Thresholds**: Always highlight rank-scaled geometries (radii, distance, arc degrees) and cleanse/dispel thresholds using `**${val}**`.
3. **Authentic Thai Flavor**: Prioritize authentic Thai client text (`<Class>Skill_th.cs` or in-game client terminology) as baseline phrasing.

---

## 4. Multi-Rank Icon Completeness

* Whenever a skill has `maxRank > 1`, **every single rank must have its authentic in-game icon** registered (`<skill>1`, `<skill>2`, `<skill>3`, `<skill>4`, `<skill>5`).
* Icons must be extracted directly from `RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills/<class>/` with valid PNG headers (`89 50 4E 47 0D 0A 1A 0A`).
* **Zero Placeholders**: Never reuse a single rank's icon across all ranks or use placeholders when rank-numbered assets exist in the game files. The UI engine automatically switches icons on rank selection (`selected.icon.replace(/\d+$/, '') + rank`).

---

## 5. Status Effect Profiling Protocol

Whenever a skill applies or interacts with a status effect on self, ally, or enemy via `RPC_AddStatus(sType, sLv, sTime, sValue, sID)`:
1. **Status Name (`sType`) & Numeric ID (`nCode`)**: Trace exact string passed and integer ID in `StatusData.cs`.
2. **Status Level (`sLv`)**: Document the exact level passed across ranks 1..maxRank.
3. **Classification (from `StatusData.cs`)**:
   - `isBuffStatus(sType)` / `isDebuffStatus(sType)`
   - `isStateStatus(sType)`
   - `isMagicalStatus(sType)` (can be cleansed by Dispell) vs `isPhysicalStatus(sType)` (physical cleanses)
   - `isLockStatus(sType)` / `isShieldStatus(sType)` / `isSystemStatus(sType)`
4. **Target & Stat Deltas**: Target (`self`, `ally`, `enemy`), class restrictions, and stat adjustments in `CharacterControl.cs`.
