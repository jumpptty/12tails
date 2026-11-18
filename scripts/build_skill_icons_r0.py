#!/usr/bin/env python3
# SKILL_ICONS_R0 builder (Halo skill roster, user 2026-11-18). For every skill-card icon that has a game rank-0 picture (the same art with no roman
# numeral: gamegui/icons/skills/<class>/<stem>0.png), keep the Bible's sharp 128 px icon and replace only its baked numeral with the rank-0 art
# enlarged to 128 px. The numeral = where the two differ in the bottom-right part (x and y past 40 %), grown 4 px and feathered.
#
#   py scripts/build_skill_icons_r0.py                      check: count, size, writes a before / after sheet to --sheet (default: none)
#   py scripts/build_skill_icons_r0.py --write              rewrite the BIBLE_ASSETS.SKILL_ICONS_R0 line in 12t_projects/bible/assets.js
#   --r0-dir <dir>   read the rank-0 pictures from <dir>/<class>/<stem>0.png (e.g. Real-ESRGAN upscales) instead of RippedAssets
#   --rip <dir>      the RippedAssets skills folder (default: <repo>/RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills)
#   --sheet <png>    save a before / after / mask sheet of a sample
# After --write: node scripts/bible_assets.js stamp, then node scripts/validate_skills.js ([HALO ROSTER ERROR] checks the container).
import argparse, base64, io, json, os, re, subprocess, sys
from PIL import Image, ImageChops, ImageFilter

REPO = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
ap = argparse.ArgumentParser()
ap.add_argument("--write", action="store_true")
ap.add_argument("--r0-dir")
ap.add_argument("--rip", default=os.path.join(REPO, "RippedAssets/ExportedProject/Assets/Resources/gamegui/icons/skills"))
ap.add_argument("--sheet")
a = ap.parse_args()

INDEX, ASSETS = os.path.join(REPO, "12t_projects/bible/index.html"), os.path.join(REPO, "12t_projects/bible/assets.js")
# Icons with no rank-0 picture are left out: the Halo list shows their rank-1 icon instead (haloArt in index.html; user 2026-11-18: painted-out numerals looked bad).
# every skill icon key a card or dep names, written icon:"…" or icon: "…" (the multi-line cards, e.g. the Bat C tree, use the spaced form; 2026-11-18)
card_keys = sorted(k for k in set(re.findall(r'icon\s*:\s*"([a-z]+_[A-Za-z]+\d+)"', open(INDEX, encoding="utf-8").read())) if not k.startswith(("item_", "status_", "mount_", "server_")))
js = "const fs=require('fs'),vm=require('vm');const b={};vm.createContext(b);vm.runInContext(fs.readFileSync(process.argv[1],'utf8'),b);process.stdout.write(JSON.stringify(b.BIBLE_ASSETS.SKILL_ICONS))"
icons = json.loads(subprocess.run(["node", "-e", js, ASSETS], capture_output=True, check=True).stdout)

def rank0_files(base):   # (class folder, stem lower case) -> path; matched case-insensitively (twopair0.png serves twoPair)
    out = {}
    if not base or not os.path.isdir(base): return out
    for d in os.listdir(base):
        p = os.path.join(base, d)
        if os.path.isdir(p):
            for f in os.listdir(p):
                if f.lower().endswith("0.png"): out[(d.lower(), f[:-5].lower())] = os.path.join(p, f)
    return out
files = rank0_files(a.rip)
files.update(rank0_files(a.r0_dir))   # upscaled pictures win where given
if not files: sys.exit("no rank-0 pictures found (RippedAssets missing? pass --rip or --r0-dir)")

result, samples = {}, []
for key in card_keys:
    if key not in icons: continue
    prefix, _, rest = key.partition("_")
    src = files.get(("support" if prefix in ("common", "support") else prefix, re.sub(r"\d+$", "", rest).lower()))
    if not src: continue
    ico = Image.open(io.BytesIO(base64.b64decode(icons[key].split(",", 1)[1]))).convert("RGBA")
    if ico.size != (128, 128): continue
    r0 = Image.open(src).convert("RGBA").resize((128, 128), Image.LANCZOS)
    diff = ImageChops.difference(ico.convert("RGB"), r0.convert("RGB")).convert("L")
    region = Image.new("L", ico.size, 0); region.paste(255, (51, 51, 128, 128))
    m = ImageChops.multiply(diff.point(lambda v: 255 if v > 48 else 0), region).filter(ImageFilter.MaxFilter(9)).filter(ImageFilter.GaussianBlur(2.5))
    if m.getbbox() is None: continue   # no numeral found: nothing to replace
    comp = Image.composite(r0, ico, m)
    b = io.BytesIO(); comp.save(b, "WEBP", quality=90, method=6)
    result[key] = "data:image/webp;base64," + base64.b64encode(b.getvalue()).decode()
    if len(samples) < 24 and len(result) % 6 == 1: samples.append((ico, comp, m))

print(len(card_keys), "card icon keys;", len(result), "numeral-free icons;", round(sum(map(len, result.values())) / 1024), "KB")
if a.sheet and samples:
    sheet = Image.new("RGBA", (len(samples) * 136 + 8, 3 * 136 + 8), (36, 27, 21, 255))
    for i, (x, c, m) in enumerate(samples):
        sheet.alpha_composite(x, (8 + i * 136, 8)); sheet.alpha_composite(c, (8 + i * 136, 144)); sheet.alpha_composite(m.convert("RGBA"), (8 + i * 136, 280))
    sheet.save(a.sheet); print("sheet:", a.sheet)
if a.write:
    s = open(ASSETS, encoding="utf-8", newline="").read()
    line = "BIBLE_ASSETS.SKILL_ICONS_R0 = " + json.dumps(result, separators=(",", ":")) + ";"
    new, n = re.subn(r"^BIBLE_ASSETS\.SKILL_ICONS_R0 = [^\r\n]*", lambda _: line, s, count=1, flags=re.M)
    if n != 1: sys.exit("assets.js has no BIBLE_ASSETS.SKILL_ICONS_R0 line")
    open(ASSETS, "w", encoding="utf-8", newline="").write(new); print("wrote", ASSETS, "- now run: node scripts/bible_assets.js stamp")
