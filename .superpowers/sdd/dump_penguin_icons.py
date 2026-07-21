import base64, json, os

ICON_DIR = r"C:\Users\Jump\Desktop\Assembly-UnityScript\RippedAssets\ExportedProject\Assets\Resources\gamegui\icons\skills\penguin"
OUT_PATH = r"C:\Users\Jump\AppData\Local\Temp\claude\c--Users-Jump-Desktop-Assembly-UnityScript\290fdda7-f77e-454a-81f6-2b3239f85942\scratchpad\penguin_icons_b64.json"

# Only the exact icon files the sheet will reference (base cType + rank suffix).
# Populated from the skill-tree/rank-family mapping in the data reference doc.
NEEDED = [
    "nAttack1","nAttack2","cAttack1","cAttack2","cAttack3","cAttack4",
    "intellect1","intellect2","intellect3","intellect4",
    "doubleCast1","tripleCast2","statPlus1","statPlus2","statPlus3","statPlus4",
    "manaMissile1","manaMissile2","manaMissile3","manaMissile4",
    "manaArc1","manaArc2","manaArc3","manaArc4",
    "dispell1","dispell2","blink1","blink2",
    "mpTransfer1","mpTransfer2","manaBurn1","manaBurn2",
    "fallingStars1","fallingStars2","fallingComets1","fallingComets2",
    "manaVortex1","manaVortex2","manaVortex3","novaFlare1",
    "astralTalent1","astralTalent2","astralTalent3","astralTalent4",
    "meteora1","meteora2",
    "frozenBlast1","frozenBlast2","frozenBlast3","frozenBlast4",
    "arcticWind1","arcticWind2","arcticWind3","arcticFrost1",
    "iceShield1","iceShield2","iceShield3","iceShield4",
    "iceBlock1","iceBlock2","snowMan1","snowMan2",
    "tornado1","tornado2","tornado3","typhoon1",
    "frostBite1","frostBite2","frostBite3","frostBite4",
    "absoluteZero1","absoluteZero2","blizzard1","blizzard2",
    "arcticEmperor1","arcticEmperor2",
    "spreadShot5","moreMissile5","frozenBreak5","revisedSkill5",
    "manaField5","penguinOfArc5","deadlyFrost5","revisedMagic5",
    "focusIntellect5","parallelShift5","frostSpike5","revisedArt5",
    "doubleSpell5","manaSurge5","snowBall5","cosmicRift5",
    "superStatPlus5","giantStar5","iceTwister5","cosmicFriday5",
]

out = {}
missing = []
for name in NEEDED:
    path = os.path.join(ICON_DIR, name + ".png")
    if not os.path.exists(path):
        missing.append(name)
        continue
    with open(path, "rb") as f:
        out[name] = "data:image/png;base64," + base64.b64encode(f.read()).decode()

if missing:
    raise SystemExit("Missing icon files:\n  " + "\n  ".join(missing))

with open(OUT_PATH, "w", encoding="utf-8") as f:
    json.dump(out, f)

print(f"OK: {len(out)} icons dumped, {os.path.getsize(OUT_PATH)//1024} KB -> {OUT_PATH}")
