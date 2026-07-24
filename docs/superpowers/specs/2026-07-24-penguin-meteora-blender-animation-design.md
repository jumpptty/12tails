# Penguin Meteora — Blender Animation Design

Date: 2026-07-24
Status: Approved

## Goal

Produce a high-quality Blender animation of the Penguin class's **meteora** skill (Class A, IDs 271/272), using the real extracted game assets, timed to match in-game mechanics as closely as the decompiled source permits — with one deliberate artistic override to the cast time.

## Source of truth

- `Penguin.cs` — `RPC_meteora_cast` / `RPC_meteora_fire` coroutines (state machine at `Penguin.cs:28224-28577`, class `$RPC_meteora_fire$26268`).
- `docs/superpowers/specs/2026-07-21-penguin-skill-data-reference.md:146-151` — stat table (reqLv, MP/SP, cast time, CD, damage formula, radius).
- `RippedAssets/ExportedProject/Assets/` — AssetRipper YAML export containing the real prefabs, mesh, material, and textures for this skill.

## Rank scope

Depict **rank 2** (`meteora2`, sLv=2): radius `6+2×3=12m`, damage `talAdjust(200+150×2)=500`, visual scale ×1.25 (per `RPC_meteora_fire` case sLv==2 branch at `Penguin.cs:28365-28378`).

## Assets used

| Asset | Path | Role |
|---|---|---|
| Mesh | `RippedAssets/ExportedProject/Assets/Mesh/meteora_tri.asset` | Meteor rock geometry (588 verts / 696 tris, local AABB extent ~0.64×0.63×1.05) |
| Material | `RippedAssets/ExportedProject/Assets/Material/meteora.mat` | `_MainTex`=`meteora.png`, `_Color`=RGB(0.7479, 0.7385, 1.0), `_Emission`=RGB(0.2178, 0.2378, 0.6154) — light blue-violet, ice/frost tint |
| Texture | `RippedAssets/ExportedProject/Assets/Texture2D/meteora.png` | Base color map |
| Prefab (reference only) | `.../effects/meteora.prefab` | Confirms root spawns at local Y=50, falls to child mesh position; carries `ImageEmitter` + 2×`RingEmitter` legacy particle components (not mesh-importable) |
| Prefab (reference only) | `.../effects/meteora_ring.prefab` | Ground AoE telegraph ring — legacy `RingEmitter`/`LineEmitter` particle components, no importable mesh |
| Converter | `RippedAssets/unity_mesh_to_obj.py` | Existing stdlib-only script that parses AssetRipper YAML mesh assets into `.obj`; used as-is, no modification needed |

**Not in scope:** Penguin character model/rig, `meteora_hit` prefab geometry (impact handled via camera/flash, not a modeled asset), audio (`meteora.wav`, `meteora1/2.wav` voice clips).

## Scene composition

- Meteor rock mesh (converted via `unity_mesh_to_obj.py`), material recreated in Blender as Principled BSDF + Emission shader mix matching `meteora.mat`'s color/emission values (Unity's legacy unlit shader has no 1:1 Blender equivalent, so this is a faithful recreation, not a raw import).
- Flat ground plane, neutral gray/ice material, sized to comfortably contain the 12m-radius ring.
- Ground AoE ring: rebuilt in Blender as a flat emissive circle (thin torus/cylinder) that scales and fades in — a reasonable approximation of the original particle-based ring, since the legacy `RingEmitter`/`LineEmitter` emission curves are not recoverable from the decompiled data.
- Static wide camera shot framing the full 12m ring; no character, no camera-follow rig.

## Timeline (24fps)

| Time | Event | Source |
|---|---|---|
| 0.0s–2.0s | **Cast phase (compressed to 2s)** — ground telegraph fades in at target point, camera holds | User override: real cast time is `magAdjust(6+6×2)=18s`; explicitly compressed to 2s for watchability. All other timings below are exact game speed. |
| 2.0s | `meteora_ring` appears at full 12m radius (scale ×1.25 applied) | `RPC_meteora_fire` state 0 — ring instantiated before fall |
| 2.0s–3.2s | Meteor rock falls **linearly** from y=50 to y=0 (1.2s duration), scaled ×1.25 | `Yield(3, new WaitForSeconds(1.2f))` at `Penguin.cs:28567`. Linear interpolation chosen deliberately (no in-between keyframe data exists in decompiled source to justify an eased curve). |
| 3.2s | Impact beat: camera shake magnitude 1, white color-ramp flash, impact burst (in place of `meteora_hit` prefab) | `Camera.main.SendMessage("AddCamereShake", 1)` + `AddColorRamp("whiteRamp", ...)` at `Penguin.cs:28391-28401` |
| 3.2s–3.6s | Hold on impact flash/settle | `WaitForSeconds(0.4f)` at `Penguin.cs:28572` |
| 3.6s | Second, stronger camera shake (damage-application beat) | `Camera.main.SendMessage("AddCamereShake", 2)` at `Penguin.cs:28442` |
| 3.6s–4.6s | Dissipate/settle | `WaitForSeconds(1f)` at `Penguin.cs:28574` |
| ~4.6s | End of animation | Total duration ≈ 4.6s |

Camera shake is approximated with small random-offset keyframes at the two shake timestamps (magnitude 1 = subtler, magnitude 2 = stronger), since the exact `AddCamereShake` curve implementation is not part of the decompiled `Penguin.cs` and isn't recoverable from this source alone.

## Rendering

- Engine: Eevee (Blender's realtime renderer) — matches the realtime-game character of the source material rather than a raytraced/offline look.
- Output: single static wide shot, no camera movement/follow, rendered as a short video (MP4) covering the full ~4.6s sequence.

## Explicitly out of scope

- Penguin character rig or animation.
- Exact reverse-engineering of legacy Unity particle curves for `ImageEmitter`/`RingEmitter`/`LineEmitter` — approximated only.
- Audio mixing of the skill's `.wav` assets (can be added later if requested).
- `meteora_hit` prefab geometry — impact represented via camera shake + flash + a generic burst rather than importing/rebuilding that prefab's particle system.

## Open ambiguities resolved

- **Cast time**: user explicitly requested a 2s override instead of the real 18s (rank 2) cast, for watchability, while everything else stays at real game speed.
- **Fall curve**: user explicitly chose linear interpolation over an eased/accelerating curve, given no in-between position data exists in source.
