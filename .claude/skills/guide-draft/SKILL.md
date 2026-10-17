---
name: guide-draft
description: Use when the user shares a Skill Simulator screenshot (often with a player's post or explanation) and wants a class guide drafted from it, i.e. the build read off the screenshot, a description and skill notes from the text, as a TG2 guide code for ไกด์อาชีพ.
---

# Draft a class guide from a screenshot

Input: a screenshot of the Bible's Skill Simulator (class portrait picked, Lv box, point pools, the four trees), usually with the author's text (a Discord post, a chat message). Output: a checked guide JSON and its `TG2.` code, which the user imports in เขียนไกด์ → นำเข้า to review, or asks to embed.

Skip recommended stats and gear (user 2026-10-17): they come from the author in the editor, never from a guess.

## 1. Read the screenshot

- **Class:** the highlighted portrait. **Level:** the Lv box. **Server:** the user says it (the grid does not show it); ask if they did not. The pool lines (แต้มสกิล `left / max`, แต้ม C, EX on ToT) say how many points are unspent.
- Print the layout: `node scripts/guide_draft.js layout <class> <server>`. It lists every tree row with cell ids, names, Lv, tree points needed and required skills. Check that the screenshot's row lengths match it.
- Mark every cell **lit (1)** or **dim (0)**, left to right, one string per row, top to bottom, per tree (Basic, A, B, C; on ToT the C tree's EX rows follow its 5 rows). Lit = full colour with a glow; dim = grey or dark. A rank row is always lit from the left.
- **Checksum:** each tree header shows `learned/total` (e.g. `A 19/30`): every tree's count of 1s must equal it. The pools must match too: normal used = max − left.

## 2. Build and check

Write the draft JSON in the session scratchpad (never in the repo):

```json
{ "server": "tto", "classKey": "monkey", "level": 95,
  "grid": [["100", "1100", "1111", "11", "1111"], ["..."], ["..."], ["0111", "0001", "1000", "1001", "1010"]],
  "title": "...", "author": "", "description": "...",
  "notes": { "Volcanic Eruption": "...", "304": "..." },
  "cover": ["Volcanic Eruption", "Summon Soul", "Ground Lock"] }
```

Then run `node scripts/guide_draft.js build <draft.json> <guide.json>`. It applies the page's own learn rules (`skillSimValid` and the pools, loaded from `index.html`) and names every broken rule. A broken rule almost always means a misread cell, so look at the screenshot again; never "fix" the build to make it pass. The summary prints the tree counts and pools; compare them with the screenshot's headers. Unspent points are fine (the page marks them as flex points).

## 3. Write the text from the author's words

- **Thai, in the author's voice, with light edits only.** Cut chat filler and references to the chat room ("ห้องนี้", "เดี๋ยวจะอธิบาย"). Keep their slang and nicknames. Never add a claim, number or tip that is not in their text.
- **Description:** the general part: the build's purpose, modes or arenas, playstyle, the key-skill summary. **Notes:** each skill-specific explanation goes on that skill (`notes`, keyed by skill name or cell id; a bare name means its highest learned rank). Text that only explains one skill leaves the description.
- **Nicknames → skills:** match the author's Thai names to the layout names, using `12t_reference/<class>-skill-reference.md` when the link is not obvious (e.g. Monkey "ล็อค 6" = Ground Lock, whose lock Aegis Of Earth 3 raises to 6 s; "ท่าชาร์ตรวมร่างลิงดิน" that adds KO to Stone Hammer = Stone Sentinel). If a nickname stays unclear, keep the sentence in the description and say so to the user.
- **Bold** with `**text**`, with a space before and after it (the editor adds those spaces), on the key points only: modes, key skills, numbers.
- **Cover:** 1-5 skills, the ones the author calls the build's core, most important first.
- **Title:** short and in the community's style (class nickname + role or mode, e.g. ลิง PVP อารีน่าใหญ่). **Author:** only a name the user or the post gives; otherwise leave it empty and ask. **Date:** today unless given.
- Limits: title 160, author 120, description 12000, each note 3000 characters.

## 4. Hand it over

Give the user the `TG2.` code, the build summary (class, server, Lv, tree counts, pools), the cover and notes chosen, the nickname mappings, and anything left open (author, unclear nicknames). Embed it in `CLASS_GUIDES` only when the user asks; then follow [12t_projects/bible/CLASS-GUIDES.md](../../../12t_projects/bible/CLASS-GUIDES.md) (next running `id`, `cover` after it) and the changelog gate.
