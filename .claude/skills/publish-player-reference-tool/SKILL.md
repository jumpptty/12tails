---
name: publish-player-reference-tool
description: Publish 12t_projects/player-reference-tool/index.html (the "12 Tails Tools" hub) to its live Artifact URL. Use when the user asks to publish, deploy, push, or update the reference tool artifact.
---

# Publish Player Reference Tool

Publish the current state of `12t_projects/player-reference-tool/index.html` to its existing
Artifact, in place — same URL, no duplicate.

## Steps

1. If `12t_projects/player-reference-tool/index.html` was edited this session, it's already
   current — no sync step needed (the Artifact tool publishes directly from the project file;
   there is no separate scratchpad copy to keep in step).
2. Call the Artifact tool:
   - `file_path`: `12t_projects/player-reference-tool/index.html`
   - `url`: `https://claude.ai/code/artifact/5f024957-09df-4f7c-b4d6-c9f38823e7c8` —
     **always pass this.** Omitting it creates a brand-new artifact instead of updating
     the existing one.
   - `favicon`: `🦊` (keep stable — only change on a deliberate identity pivot)
   - `label`: a short description of what changed this publish
3. Confirm the returned URL matches the one above.

If the user hasn't touched `index.html` and just wants the current file republished
(e.g. after a manual edit outside the session), do step 2 directly.
