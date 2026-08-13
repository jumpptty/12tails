import base64, glob, json, os, re

# Paths are resolved relative to this script's own location so the script
# works from any machine (home/workplace share this repo via Google Drive
# Streaming under different drive letters) without editing a hardcoded path.
SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
REPO_ROOT = os.path.abspath(os.path.join(SCRIPT_DIR, "..", ".."))
REF_DIR = os.path.join(REPO_ROOT, "12t_reference")
ICON_ROOT = os.path.join(
    REPO_ROOT, "RippedAssets", "ExportedProject", "Assets", "Resources",
    "gamegui", "icons", "skills",
)

# Session-scratchpad output — this run's JSON is consumed immediately by
# Task 15, not meant to be re-run later without pointing this at a fresh
# scratchpad dir.
OUT_PATH = r"C:\Users\Jump\AppData\Local\Temp\claude\c--Users-Jump-Google-Drive-Streaming-My-Drive-Claude-projects-12tails\262e6d79-a61f-42b6-9abc-5dc56864fb9f\scratchpad\skill_cooldown_icons_b64.json"

# 12t_reference/<class>-skill-cooldown-reference.md filename -> icon subfolder name
# (both already match the class's lowercase name, confirmed against
# RippedAssets/.../icons/skills/<class>/ on disk).
CLASSES = [
    "bat", "bison", "cat", "chameleon", "mole", "monkey",
    "panda", "penguin", "rabbit", "sheep", "whale", "wolf",
]

ROW_RE = re.compile(r"^\|\s*([A-Za-z0-9]+)\s*\|[^|]*\|\s*(\d+)\s*\|")


def load_needed(cls):
    path = os.path.join(REF_DIR, f"{cls}-skill-cooldown-reference.md")
    with open(path, encoding="utf-8") as f:
        lines = f.readlines()

    in_table = False
    needed = []
    for line in lines:
        if line.startswith("| Skill ID"):
            in_table = True
            continue
        if in_table:
            if line.startswith("|---"):
                continue
            m = ROW_RE.match(line)
            if not m:
                break  # table ended
            skill_id, max_rank = m.group(1), int(m.group(2))
            needed.append((cls, skill_id, max_rank))
    return needed


NEEDED = []
for cls in CLASSES:
    NEEDED.extend(load_needed(cls))

# A handful of doc rows have no icon file matching their own Skill ID at all,
# because the doc merges several differently-named in-source skills into one
# cooldown-representative row (verified per-case against each doc's own
# judgment-call notes before adding here):
#   - Chameleon's "slayer"/"allSlayer" rows merge 4 differently-elemental-typed
#     skills (bugSlayer/tailSlayer/elementalSlayer/machineSlayer) sharing one
#     flat cooldown -- represented by the max-tier (req-33/rank-4) variant icon.
#   - Sheep's "seal" row merges 4 differently-named sealOf* skills
#     (sealOfAttack/Defense/Earth/Heaven) sharing one flat cooldown --
#     represented by sealOfAttack (the family member traced in the doc's own
#     citations as the primary example).
#   - Monkey's pet-command skills (summonAttack/summonDefense/summonRelease/
#     unsummon) and Rabbit's "truceTrading & Co." use real icon filenames with
#     no numeric rank suffix, or (`buiten`/`truceTrading`) a different base
#     name (buitenHouHou / "truceTrading&co") than their Skill ID.
ICON_ALIASES = {
    ("chameleon", "slayer"): ("machineSlayer", True),
    ("chameleon", "allSlayer"): ("allMachineSlayer", True),
    ("sheep", "seal"): ("sealOfAttack", True),
    ("monkey", "summonAttack"): ("summonAttack", False),
    ("monkey", "summonDefense"): ("summonDefense", False),
    ("monkey", "summonRelease"): ("summonRelease", False),
    ("monkey", "unsummon"): ("unsummon", False),
    ("monkey", "buiten"): ("buitenHouHou", True),
    ("rabbit", "truceTrading"): ("truceTrading&co", True),
}

# The doc's "Max Rank" column counts how many learnable tiers a skill family
# has (always 1 for a singleton skill) -- it is NOT always the same as the
# real numeric suffix baked into that skill's actual in-source name (e.g. a
# Class-C singleton is genuinely named "wlf_holySword5", not "...1", and its
# icon file is holySword5.png). Resolve the real suffix by falling back to
# whatever numbered icon file actually exists on disk for that skillId.
def resolve_icon(cls, skill_id, max_rank):
    if (cls, skill_id) in ICON_ALIASES:
        basename, use_rank = ICON_ALIASES[(cls, skill_id)]
        fname = f"{basename}{max_rank}.png" if use_rank else f"{basename}.png"
        path = os.path.join(ICON_ROOT, cls, fname)
        return (path, max_rank) if os.path.exists(path) else (None, None)

    exact = os.path.join(ICON_ROOT, cls, f"{skill_id}{max_rank}.png")
    if os.path.exists(exact):
        return exact, max_rank
    candidates = glob.glob(os.path.join(ICON_ROOT, cls, f"{skill_id}[1-9].png"))
    if len(candidates) == 1:
        m = re.search(r"(\d+)\.png$", candidates[0])
        return candidates[0], int(m.group(1))
    return None, None


out = {}
missing = []
fallback_used = []
for cls, skill_id, max_rank in NEEDED:
    path, resolved_rank = resolve_icon(cls, skill_id, max_rank)
    if path is None:
        missing.append(f"{cls}/{skill_id}{max_rank}.png (no unambiguous fallback on disk)")
        continue
    if resolved_rank != max_rank:
        fallback_used.append(f"{cls}/{skill_id}: doc Max Rank {max_rank} -> icon file {skill_id}{resolved_rank}.png")
    with open(path, "rb") as f:
        out[f"{cls}_{skill_id}{max_rank}"] = "data:image/png;base64," + base64.b64encode(f.read()).decode()

if fallback_used:
    print(f"NOTE: {len(fallback_used)} icons resolved via real-suffix fallback (doc Max Rank != icon rank):")
    for line in fallback_used:
        print(f"  {line}")

if missing:
    raise SystemExit("Missing/ambiguous icon files:\n  " + "\n  ".join(missing))

os.makedirs(os.path.dirname(OUT_PATH), exist_ok=True)
with open(OUT_PATH, "w", encoding="utf-8") as f:
    json.dump(out, f)

print(f"OK: {len(out)} icons dumped, {os.path.getsize(OUT_PATH) // 1024} KB -> {OUT_PATH}")
