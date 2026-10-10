# CLAUDE.md — GoldenKingBug Spawn Map

Source of truth for the **"GoldenKingBug Spawn Map"** — an interactive 3D (Three.js) boss-spawn
and warp-point map of Needle Cave.

- `GoldenKingBug-spawn-map.html` is the full source — edit it directly here. **Never publish it as an
  Artifact** (project rule, 2026-10-06); changes ship through git only.
- Embedded in the "12 Tails Bible" hub (`12t_projects/bible/index.html`, tool id `goldenkingbug-map`, since 2026-10-10):
  `GKB_PAYLOAD` there is a gzip+base64 blob of Three.js + the cave mesh (mirror baked in, unused `WAYPOINTS` dropped)
  + the map code, unpacked by `mountGoldenKingBugMap` with `DecompressionStream` on first open. This standalone file is
  still the source: after changing it, rebuild the payload with a scratch script (see `mountGoldenKingBugMap`'s comment)
  and patch it into the hub out-of-process per `12t_projects/bible/CLAUDE.md` §1.
- The right-hand panel holds the boss-search strategy table (routes for 1-12 players, derived with a 5 units/s, 30-unit-sight
  model; method in `12t_reference/12Tails-Mechanics-Reference.md` §4.7) and a playable simulation. Simulation markers walk
  shortest paths over the cave mesh's own edges (floor-projected), so they stay inside the tunnels.
