# Strict Prohibition: Zero LaTeX and Zero Dollar-Sign Delimiters

> ⛔ **CRITICAL MANDATORY INSTRUCTION — ZERO LATEX IN CHAT & DELIVERABLES**
> 
> The chat interface and project markdown files **DO NOT** have a LaTeX renderer (no KaTeX, no MathJax).
> Any LaTeX syntax renders as broken, raw, unreadable text.

---

### 1. Absolute Ban on Dollar Signs (`$`) in Explanations
* **NEVER** use the `$` symbol to wrap numbers, measurements, dimensions, or coordinates.
  * ❌ **WRONG:** `$48\text{px}$`, `$48px$`, `$100\text{px}$`, `$258\text{px}$`, `$100\%$`, `$0.7\text{s}$`
  * ✅ **RIGHT:** `48px`, `100px`, `~258px`, `100%`, `0.7s`
* The `$` character is ONLY permitted inside actual programming code (e.g. bash variables `$var`, PHP `$foo`, decompiled identifiers `$mSpawnPoint`). It is **NEVER** permitted in prose, numbers, or bullet points.

---

### 2. Forbidden Commands & Delimiters
Never output any of the following:
* **Math Delimiters:** `$ ... $`, `$$ ... $$`
* **LaTeX Macros:** `\text{...}`, `\frac{...}{...}`, `\times`, `\approx`, `\le`, `\ge`, `\neq`, `\pm`, `\cdot`, `\left`, `\right`, `\dots`
* **Subscripts/Superscripts via TeX:** `\text{TAL}_{\text{eff}}` (use plain text `TAL_eff` or code blocks)

---

### 3. Required Plain-Text Substitutions
Always use standard typography, native Unicode, or plain code blocks:
* **Dimensions & Numbers:** `48px`, `158px`, `100px`, `12vw`, `100%`
* **Approximation & Arrows:** `~258px`, `approx 258px`, `->`, `<-`
* **Comparisons & Arithmetic:** `<=`, `>=`, `!=`, `*`, `/`, `+`, `-`, `x`
* **Formulas:** Always place formulas inside standard multi-line or inline code blocks:
  ```
  Final Damage = Base Damage * (64 / (EnemyDef + 64))
  ```

---

### 4. Mandatory Pre-Response Self-Audit
Before outputting any final response to the user, you must scan your response text:
1. Did you write any `$` around numbers or units? **Delete them immediately.**
2. Did you write any `\text` or LaTeX command? **Convert them to plain text immediately.**
