#!/usr/bin/env python3
# Sub-move symbol icons (user 2026-11-19). A summon's, mount's or form's move that only borrowed its parent's picture gets a symbol of its verified hit
# pattern (the card's desc, hitCount and reach): glowing strokes, top view with the caster below facing up, one colour per summon (PAL), auto-centred
# and fitted inside the circle the halo list shows (FIT_R). Keys: "mv_" + card id, a trailing level number written as a roman numeral (haloArt would
# swap a key ending in 2 for its rank-1 icon). Cards point at them through icon; a card that shows its parent's in-game tooltip keeps the old picture
# in tipIcon, and a card that sat in its parent's tree tab keeps it through rosterParent (bible-card-fields).
#
#   py scripts/build_move_icons.py --sheet <png> [card id ...]   draw every icon (or the listed ones) into a labelled contact sheet to review
#   py scripts/build_move_icons.py --out <dir> [card id ...]     also save each 256 px source
#   py scripts/build_move_icons.py --write                       rewrite every mv_* entry of BIBLE_ASSETS.SKILL_ICONS in 12t_projects/bible/assets.js
# After --write: node scripts/bible_assets.js stamp, then node scripts/validate_skills.js ([MOVE ICON ERROR] checks the cards).
# A new move: one more icon function below (decorated with its card id and palette, a comment naming the verified behaviour it draws); --sheet, then --write.
import argparse, base64, io, math, os, re, sys
import numpy as np
from PIL import Image, ImageDraw, ImageFilter
REPO = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
ASSETS = os.path.join(REPO, "12t_projects", "bible", "assets.js")
N, SS = 256, 4; W = N * SS
FIT_R = 90   # the visible circle in the halo (art at 1.3x): radius ~98 px of 256; keep a margin

PAL = {   # core, hot, edge (glow)
    "fire":   ((255, 236, 180), (255, 150, 50), (230, 70, 30)),
    "steel":  ((242, 244, 248), (182, 194, 210), (92, 108, 132)),
    "flame":  ((255, 246, 200), (255, 205, 80), (240, 130, 20)),
    "sun":    ((255, 252, 220), (255, 232, 110), (220, 160, 40)),
    "earth":  ((246, 238, 205), (206, 178, 112), (128, 102, 52)),
    "violet": ((250, 232, 255), (204, 146, 255), (130, 64, 222)),
    "rune":   ((222, 255, 250), (96, 230, 212), (22, 140, 140)),
    "star":   ((240, 248, 255), (156, 202, 255), (72, 112, 230)),
    "light":  ((255, 253, 238), (255, 238, 170), (206, 172, 80)),
    "gold":   ((255, 250, 214), (255, 206, 64), (204, 138, 18)),
    "swamp":  ((236, 255, 218), (152, 222, 94), (60, 132, 44)),
    "crimson": ((255, 226, 216), (255, 96, 86), (172, 22, 34)),
    "sky":    ((240, 250, 255), (170, 216, 255), (78, 140, 214)),
    "bronze": ((255, 240, 214), (226, 166, 96), (150, 90, 40)),
}
BG = {"fire": (44, 16, 10), "steel": (24, 28, 36), "flame": (46, 26, 8), "sun": (42, 32, 8), "earth": (34, 28, 16), "violet": (32, 16, 44),
      "rune": (10, 34, 36), "star": (14, 20, 44), "light": (40, 34, 18), "gold": (42, 30, 6), "swamp": (16, 32, 12), "crimson": (44, 10, 12),
      "sky": (12, 26, 42), "bronze": (40, 24, 12)}

class G:   # one icon's two masks: strokes (the lines) and soft (a faint area fill)
    def __init__(s):
        s.a = Image.new("L", (W, W), 0); s.s = Image.new("L", (W, W), 0); s.d = ImageDraw.Draw(s.a); s.ds = ImageDraw.Draw(s.s)
def P(x, y): return (x * SS, y * SS)
def tapered(g, p0, p1, w, bend=0.0, head=False, soft=False):   # a lens slash (or, head=True, thin at p0 and widest near p1)
    L_, R_ = [], []; dx, dy = p1[0] - p0[0], p1[1] - p0[1]; ln = math.hypot(dx, dy) or 1; nx, ny = -dy / ln, dx / ln
    for i in range(41):
        t = i / 40; x, y = p0[0] + dx * t, p0[1] + dy * t; b = bend * math.sin(math.pi * t)
        hw = w / 2 * ((t ** 0.7) * (1 - max(0, t - 0.85) / 0.15) if head else math.sin(math.pi * t) ** 0.8)
        L_.append(P(x + nx * (b + hw), y + ny * (b + hw))); R_.append(P(x + nx * (b - hw), y + ny * (b - hw)))
    (g.ds if soft else g.d).polygon(L_ + R_[::-1], fill=255)
def crescent(g, c, r, a0, a1, w):   # a slash along an arc, widest in the middle (angles: 0 = right, 90 = down)
    L_, R_ = [], []
    for i in range(49):
        t = i / 48; a = math.radians(a0 + (a1 - a0) * t); hw = w / 2 * math.sin(math.pi * t) ** 0.75
        L_.append(P(c[0] + math.cos(a) * (r + hw), c[1] + math.sin(a) * (r + hw))); R_.append(P(c[0] + math.cos(a) * (r - hw), c[1] + math.sin(a) * (r - hw)))
    g.d.polygon(L_ + R_[::-1], fill=255)
def arc(g, c, r, a0, a1, w): g.d.arc([c[0] * SS - r * SS, c[1] * SS - r * SS, c[0] * SS + r * SS, c[1] * SS + r * SS], a0, a1, fill=255, width=max(1, round(w * SS)))
def ring(g, c, r, w): arc(g, c, r, 0, 360, w)
def disc(g, c, r, soft=False): (g.ds if soft else g.d).ellipse([(c[0] - r) * SS, (c[1] - r) * SS, (c[0] + r) * SS, (c[1] + r) * SS], fill=255)
def line(g, p0, p1, w):
    g.d.line([P(*p0), P(*p1)], fill=255, width=max(1, round(w * SS))); disc(g, p0, w / 2); disc(g, p1, w / 2)
def poly(g, pts, soft=False): (g.ds if soft else g.d).polygon([P(*p) for p in pts], fill=255)
def burst(g, c, r0, r1, n, w, rot=0.0, alt=None):
    for i in range(n):
        t = math.radians(rot + 360 * i / n); rr = r1 if not alt or i % 2 == 0 else r0 + (r1 - r0) * alt
        tapered(g, (c[0] + math.cos(t) * r0, c[1] + math.sin(t) * r0), (c[0] + math.cos(t) * rr, c[1] + math.sin(t) * rr), w)
def chevrons(g, cx, y, n, size=34, gap=20, w=8):
    for i in range(n):
        yy = y - i * gap; s = size - i * 3; line(g, (cx - s, yy + s * 0.42), (cx, yy), w); line(g, (cx + s, yy + s * 0.42), (cx, yy), w)
def zigzag(g, p0, p1, n, amp, w):
    dx, dy = p1[0] - p0[0], p1[1] - p0[1]; ln = math.hypot(dx, dy) or 1; nx, ny = -dy / ln, dx / ln; pts = [p0]
    for i in range(1, n): t = i / n; s = amp * (1 if i % 2 else -1); pts.append((p0[0] + dx * t + nx * s, p0[1] + dy * t + ny * s))
    pts.append(p1)
    for a, b in zip(pts, pts[1:]): line(g, a, b, w)
def star(g, c, r, k=5, inner=0.45, rot=-90):
    pts = []
    for i in range(2 * k): a = math.radians(rot + 180 * i / k); rr = r if i % 2 == 0 else r * inner; pts.append((c[0] + math.cos(a) * rr, c[1] + math.sin(a) * rr))
    poly(g, pts)
def arrowhead(g, tip, ang, size, w):
    for s in (-1, 1):
        a = math.radians(ang + 180 + s * 32); line(g, tip, (tip[0] + math.cos(a) * size, tip[1] + math.sin(a) * size), w)
def bezier(p0, c1, p1, n=40): return [((1 - t) ** 2 * p0[0] + 2 * (1 - t) * t * c1[0] + t * t * p1[0], (1 - t) ** 2 * p0[1] + 2 * (1 - t) * t * c1[1] + t * t * p1[1]) for t in (i / n for i in range(n + 1))]
def trail(g, pts, w0, w1, dashed=False):
    for i, (a, b) in enumerate(zip(pts, pts[1:])):
        if dashed and (i // 3) % 2: continue
        line(g, a, b, w0 + (w1 - w0) * i / max(1, len(pts) - 2))
def spiral(g, c, r, turns, w):
    pts = [(c[0] + math.cos(t) * r * t / (2 * math.pi * turns), c[1] + math.sin(t) * r * t / (2 * math.pi * turns)) for t in np.linspace(0.6, 2 * math.pi * turns, 60)]
    trail(g, pts, w * 0.6, w)
def plus(g, c, s, w): line(g, (c[0] - s, c[1]), (c[0] + s, c[1]), w); line(g, (c[0], c[1] - s), (c[0], c[1] + s), w)
def snowflake(g, c, r, w):
    for i in range(6):
        a = math.radians(-90 + 60 * i); e = (c[0] + math.cos(a) * r, c[1] + math.sin(a) * r); line(g, c, e, w)
        for f in (0.55, 0.78):
            m = (c[0] + math.cos(a) * r * f, c[1] + math.sin(a) * r * f)
            for s in (-1, 1): b = a + s * math.radians(55); line(g, m, (m[0] + math.cos(b) * r * 0.24, m[1] + math.sin(b) * r * 0.24), w * 0.7)
def bomb(g, c, r):
    ring(g, c, r, 6); disc(g, (c[0] - r * 0.3, c[1] - r * 0.3), r * 0.22); line(g, (c[0] + r * 0.6, c[1] - r * 0.6), (c[0] + r * 1.05, c[1] - r * 1.1), 5); star(g, (c[0] + r * 1.18, c[1] - r * 1.25), r * 0.42, 4, 0.35, -45)
def coin(g, c, r): ring(g, c, r, 3.2); line(g, (c[0], c[1] - r * 0.5), (c[0], c[1] + r * 0.5), 3)
def saw(g, c, r, teeth=12):
    ring(g, c, r, 7); disc(g, c, r * 0.28)
    for i in range(teeth):
        a = math.radians(360 * i / teeth); b = math.radians(360 * (i + 0.5) / teeth)
        poly(g, [(c[0] + math.cos(a) * (r + 2), c[1] + math.sin(a) * (r + 2)), (c[0] + math.cos(b) * (r + 2), c[1] + math.sin(b) * (r + 2)), (c[0] + math.cos(a) * (r + 13), c[1] + math.sin(a) * (r + 13))])
def cracks(g, c, r0, r1, n, w, rot=15):
    for i in range(n):
        a = math.radians(rot + 360 * i / n); zigzag(g, (c[0] + math.cos(a) * r0, c[1] + math.sin(a) * r0), (c[0] + math.cos(a) * r1, c[1] + math.sin(a) * r1), 3, 5, w)
def tracer(g, p0, p1, w): tapered(g, p0, p1, w, head=True); disc(g, p1, w * 0.62)
def muzzle(g, c, r): burst(g, c, r * 0.3, r, 6, r * 0.42, -90)
def comet(g, head, tail, r): tapered(g, tail, head, r * 1.9, head=True); disc(g, head, r)

def render(g, pal):
    core, hot, edge = PAL[pal]
    a = np.asarray(g.a, np.float32) / 255; s = np.asarray(g.s, np.float32) / 255
    m = np.maximum(a, (s > 0.5) * 1.0); ys, xs = np.nonzero(m[::4, ::4] > 0.2); ys, xs = ys * 4, xs * 4
    cx, cy = (xs.min() + xs.max()) / 2, (ys.min() + ys.max()) / 2; rad = np.sqrt(((xs - cx) ** 2 + (ys - cy) ** 2).max()) + 4 * SS
    k = (FIT_R * SS) / rad   # scale so the farthest stroke sits on the fit circle (grows a small symbol, shrinks a big one)
    tf = lambda im: im.transform((W, W), Image.AFFINE, (1 / k, 0, cx - W / 2 / k, 0, 1 / k, cy - W / 2 / k), resample=Image.BICUBIC)
    A = tf(g.a).resize((N, N), Image.LANCZOS); Sx = tf(g.s).resize((N, N), Image.LANCZOS)
    yy, xx = np.mgrid[0:N, 0:N].astype(np.float32); r = np.clip(np.hypot(xx - N / 2, yy - N / 2) / (N * 0.7), 0, 1)[..., None]
    img = np.array(BG[pal], np.float32) * (1 - r) + np.array((12, 10, 10), np.float32) * r
    sm = np.asarray(Sx.filter(ImageFilter.GaussianBlur(6)), np.float32)[..., None] / 255
    img = img + np.array(edge, np.float32) * sm * 0.34
    glow = np.asarray(A.filter(ImageFilter.GaussianBlur(7)), np.float32)[..., None] / 255
    img = img + np.array(edge, np.float32) * glow * 0.9
    mm = np.asarray(A, np.float32)[..., None] / 255; img = img * (1 - mm) + np.array(hot, np.float32) * mm
    cr = np.asarray(A.filter(ImageFilter.MinFilter(3)).filter(ImageFilter.GaussianBlur(0.8)), np.float32)[..., None] / 255
    img = img * (1 - cr * 0.85) + np.array(core, np.float32) * cr * 0.85
    return Image.fromarray(np.clip(img, 0, 255).astype(np.uint8), "RGB")

ICONS = {}
RANKS = {}   # card -> top rank, for a card whose symbol changes with its rank: fn(g, rank) also writes <key><rank> (the card header swaps to it)
def icon(card, pal, ranks=0):
    def wrap(fn):
        ICONS[card] = (pal, fn)
        if ranks: RANKS[card] = ranks
        return fn
    return wrap

# ---------------- Gaos (fire) ----------------
@icon("monkey_gaos_nAttack1", "fire")   # swipe in front, area 4 -> 6 m wide, 7 m long: 3 claw slashes in a widening wedge
def _(g):
    poly(g, [(110, 196), (146, 196), (196, 52), (60, 52)], soft=True)
    for off in (-34, 0, 34): tapered(g, (128 + off * 1.25 - 26, 66), (128 + off * 0.55 + 26, 182), 15, bend=-10)
@icon("monkey_gaos_nAttack2", "fire")   # round blast in front (r 5 m): impact ring with spikes
def _(g): disc(g, (128, 128), 66, True); ring(g, (128, 128), 62, 9); disc(g, (128, 128), 13); burst(g, (128, 128), 22, 48, 8, 9, 22.5)
@icon("monkey_gaos_tailSpin", "fire")   # 4 waves, 120-degree fan, r 6 -> 9 m: 4 expanding arcs
def _(g):
    g.ds.pieslice([P(128 - 104, 192 - 104), P(128 + 104, 192 + 104)], -150, -30, fill=255)
    for i, r in enumerate((40, 58, 76, 94)): arc(g, (128, 192), r, -150 + i * 3, -30 - i * 3, 10 - i * 1.5)
@icon("monkey_gaos_fire", "fire")   # shot at a target over 12 m away, explodes where it lands: long arc + burst
def _(g):
    t = (156, 96); disc(g, t, 44, True); trail(g, bezier((88, 204), (60, 110), t)[:-4], 3, 10); ring(g, t, 30, 7); disc(g, t, 12); burst(g, t, 36, 52, 8, 6)
@icon("monkey_gaos_rampage", "fire")   # 8 s charge, 14 hits ahead: chevrons + impacts ahead
def _(g):
    chevrons(g, 128, 196, 3, 36, 20, 8)
    for y, r in ((118, 22), (78, 16), (48, 11)): ring(g, (128, y), r, 6); disc(g, (128, y), r + 10, True)

# ---------------- Mole machines (steel) ----------------
@icon("mole_autoGyroGun_nAttack", "steel")   # turret shot along a line that widens (0.4 -> 1 m), every 2 s
def _(g): poly(g, [(124, 200), (132, 200), (150, 40), (106, 40)], soft=True); poly(g, [(125, 196), (131, 196), (142, 48), (114, 48)]); muzzle(g, (128, 206), 22)
@icon("mole_barrelBot_nAttack", "steel")   # 2 punches, each hits all round the robot (r 1.5 m)
def _(g): disc(g, (128, 128), 70, True); ring(g, (128, 128), 30, 9); ring(g, (128, 128), 56, 7); burst(g, (128, 128), 64, 84, 8, 9, 22.5)
@icon("mole_kingKaiser_nAttack", "steel")   # 3 slashes per press, each a front area of a different size
def _(g):
    for c, r, w in (((128, 190), 96, 16), ((128, 190), 70, 14), ((128, 190), 44, 11)): crescent(g, c, r, -150, -30, w)
@icon("mole_moleTank_cannon", "steel")   # shell flies straight, explodes on contact (r 5 m round the blast)
def _(g): t = (128, 70); disc(g, t, 40, True); tracer(g, (128, 214), (128, 104), 12); ring(g, t, 28, 7); disc(g, t, 10); burst(g, t, 34, 50, 8, 6)
@icon("mole_moleTank_ram", "steel")   # charge 0.9 s, the area ahead checked 6 times
def _(g):
    chevrons(g, 128, 210, 3, 38, 22, 9); poly(g, [(80, 112), (176, 112), (176, 60), (80, 60)], soft=True); line(g, (84, 100), (172, 100), 10)
    for x in (96, 112, 128, 144, 160): tapered(g, (x, 92), (x + (x - 128) * 0.25, 56), 7)
@icon("mole_gigaCannon_shot", "steel")   # arcing shell (gravity, ~92 m at 45 deg), huge blast r 24 m
def _(g): t = (176, 150); disc(g, t, 52, True); trail(g, bezier((50, 214), (100, -10), t)[:-3], 3, 9, dashed=True); ring(g, t, 40, 8); disc(g, t, 14); burst(g, t, 46, 64, 10, 7)
@icon("mole_warFactory_sawMachine", "steel")   # saw cuts 4 times: once behind, 3 times in front
def _(g):
    saw(g, (128, 132), 30)
    for i, r in enumerate((52, 64, 76)): crescent(g, (128, 132), r, -135 + i * 6, -45 - i * 6, 9)
    crescent(g, (128, 132), 56, 45, 135, 9)
@icon("mole_warFactory_bazooka", "steel")   # rockets fired in a row, each explodes where it hits
def _(g):
    for x, y in ((94, 76), (128, 54), (162, 76)): tracer(g, (x, 210), (x, y + 18), 9); burst(g, (x, y), 6, 18, 8, 5); disc(g, (x, y), 18, True)
@icon("mole_warFactory_teslaCoil", "steel")   # electricity all round, 7 hits (r 5 m)
def _(g):
    disc(g, (128, 128), 86, True); disc(g, (128, 128), 12); ring(g, (128, 128), 22, 5)
    for i in range(8): a = math.radians(22.5 + 45 * i); zigzag(g, (128 + math.cos(a) * 28, 128 + math.sin(a) * 28), (128 + math.cos(a) * 84, 128 + math.sin(a) * 84), 4, 7, 5)
@icon("mole_warFactory_rollerMachine", "steel")   # roller crawls forward crushing the area ahead, 11 hits
def _(g):
    line(g, (78, 150), (178, 150), 30); disc(g, (78, 150), 0)
    for x in (100, 128, 156): line(g, (x, 140), (x, 160), 4)
    for x in (88, 120, 152): line(g, (x + 8, 182), (x - 8, 206), 5)
    chevrons(g, 128, 104, 2, 34, 22, 8); poly(g, [(70, 130), (186, 130), (186, 60), (70, 60)], soft=True)
@icon("mole_warFactory_cartBomb", "steel")   # steerable bomb cart (6 m/s), explodes after 3 s (r 6 m)
def _(g): b = (150, 80); disc(g, b, 56, True); trail(g, bezier((96, 214), (40, 130), (b[0] - 12, b[1] + 40)), 5, 5, dashed=True); bomb(g, b, 24); ring(g, (b[0] - 15, b[1] + 30), 7, 4); ring(g, (b[0] + 15, b[1] + 30), 7, 4)

# ---------------- Monkey summons ----------------
@icon("monkey_phoenix_fireBall", "flame")   # straight fireball at the target, 30 m/s
def _(g): comet(g, (160, 70), (84, 206), 22); tapered(g, (70, 176), (132, 84), 8); tapered(g, (112, 214), (160, 108), 8)
@icon("monkey_ja_detonate", "sun")   # Ja rushes in and blows itself up round itself (100 % in the middle -> 50 % at the edge)
def _(g): chevrons(g, 128, 214, 2, 30, 18, 7); disc(g, (128, 104), 70, True); disc(g, (128, 104), 16); ring(g, (128, 104), 36, 9); ring(g, (128, 104), 60, 4); burst(g, (128, 104), 64, 84, 12, 6)
@icon("monkey_gadina_nAttack", "earth", ranks=4)   # Gadina's sword: 1 / 2 / 3 / 3 slashes by level (hitCount [1, 2, 3, 3]); the list shows level 4
def _(g, rank=4):
    for off in {1: (0,), 2: (-22, 22)}.get(rank, (-36, 0, 36)): tapered(g, (128 + off - 40, 52), (128 + off + 40, 204), 12)
@icon("monkey_earthForm_nAttack", "earth")   # 3 beats: 2 punches in front, 2 hits all round, 1 heavy hit in front
def _(g): c = (128, 178); ring(g, c, 34, 7); disc(g, c, 38, True); t = (128, 72); disc(g, t, 44, True); disc(g, t, 11); cracks(g, t, 15, 46, 7, 6, -90); burst(g, (102, 132), 2, 11, 5, 4); burst(g, (154, 132), 2, 11, 5, 4)
@icon("monkey_elementalSovereign_flash", "violet")   # fire all round every 0.3 s, up to 10 times, while charging (r 6 m)
def _(g):
    disc(g, (128, 128), 90, True)
    for r, w in ((24, 9), (46, 7), (68, 5)): ring(g, (128, 128), r, w)
    burst(g, (128, 128), 74, 96, 10, 9)
@icon("monkey_runeGolem_fist", "rune")   # punches one target, alternating hands every 1.6 s
def _(g): t = (128, 84); ring(g, t, 20, 6); tapered(g, (64, 206), (t[0] - 10, t[1] + 14), 20, head=True); tapered(g, (192, 206), (t[0] + 10, t[1] + 14), 20, head=True); burst(g, t, 26, 40, 8, 5)
@icon("monkey_runeGolem_pound", "rune")   # pounds the ground in front (r 3 m), 50 % at the edge
def _(g): c = (128, 128); disc(g, c, 52, True); ring(g, c, 46, 9); disc(g, c, 10); cracks(g, c, 14, 40, 6, 5)
@icon("monkey_runeGolem_quake", "rune")   # Rune Quake: a big slam in front (r 7 m) that leaves Rune Fracture
def _(g):
    c = (128, 128); disc(g, c, 88, True); ring(g, c, 82, 8); ring(g, c, 50, 4); cracks(g, c, 12, 70, 6, 5, 0)
    for i in range(6): a = math.radians(30 + 60 * i); m = (c[0] + math.cos(a) * 82, c[1] + math.sin(a) * 82); poly(g, [(m[0], m[1] - 11), (m[0] + 8, m[1]), (m[0], m[1] + 11), (m[0] - 8, m[1])])

# ---------------- RecurrentNova (ToT) ----------------
@icon("tot_ex_recurrentnova_stars", "star")   # stars fall on up to 5 enemies, each explodes after 0.6 s (r 2 m)
def _(g):
    for (x, y), r in (((86, 150), 16), ((150, 112), 18), ((176, 186), 14)): tapered(g, (x + 46, y - 62), (x, y), 10, head=True); star(g, (x, y), r); ring(g, (x + 4, y + 22), 12, 4)
@icon("tot_ex_recurrentnova_comets", "star")   # 5 waves of comets landing at random round up to 3 enemies (r 6 m)
def _(g):
    for hx, hy in ((80, 170), (124, 150), (164, 178), (110, 196), (150, 120)): comet(g, (hx, hy), (hx + 64, hy - 96), 9)
    ring(g, (124, 176), 40, 4); disc(g, (124, 176), 46, True)

# ---------------- Rabbit: Light summons (light) ----------------
@icon("rabbit_lightPanther_nAttack", "light")   # 3 slashes in front while lunging
def _(g):
    for (cx, cy), a0, a1 in (((110, 150), -160, -60), ((146, 128), -120, -20), ((120, 96), -150, -50)): crescent(g, (cx, cy), 46, a0, a1, 12)
@icon("rabbit_lightPanther_javelin", "light")   # javelin thrown in an arc, piercing every enemy it passes, stops at the ground
def _(g): pts = bezier((52, 210), (96, 0), (204, 150)); trail(g, pts[:-2], 4, 9); arrowhead(g, pts[-1], math.degrees(math.atan2(pts[-1][1] - pts[-4][1], pts[-1][0] - pts[-4][0])), 24, 7); ring(g, pts[18], 8, 3); ring(g, pts[28], 8, 3)
@icon("rabbit_lightLeopard_nAttack", "light")   # one swipe in front (4 m wide, 2 m deep)
def _(g):
    for r, w in ((96, 11), (78, 11), (60, 11)): crescent(g, (128, 200), r, -140, -40, w)
@icon("rabbit_lightLeopard_leoSmash", "light")   # one heavy smash in front
def _(g): tapered(g, (128, 30), (128, 108), 26, head=True); disc(g, (128, 150), 54, True); burst(g, (128, 150), 18, 54, 12, 9, 0, 0.6); line(g, (66, 150), (190, 150), 6)
@icon("rabbit_lightGolem_nAttack", "light")   # random each time: smash the box ahead (39 %), a raised sweep (30 %), a ring further ahead (31 %)
def _(g):
    for a, b in (((60, 150), (100, 150)), ((100, 150), (100, 190)), ((100, 190), (60, 190)), ((60, 190), (60, 150))): line(g, a, b, 6)
    burst(g, (80, 170), 3, 13, 6, 4)
    crescent(g, (128, 140), 40, -150, -30, 13)
    ring(g, (178, 166), 18, 6); disc(g, (178, 166), 5)

# ---------------- Rabbit: coin mercenaries ----------------
@icon("rabbit_coinDwukphu_millionaire", "gold")   # 2 rings round itself, 0.5 s apart (r 7 m)
def _(g):
    disc(g, (128, 128), 84, True); ring(g, (128, 128), 46, 8); ring(g, (128, 128), 76, 6)
    for i in range(6): a = math.radians(-90 + 60 * i); coin(g, (128 + math.cos(a) * 76, 128 + math.sin(a) * 76), 12)
@icon("rabbit_coinRazan_nAttack", "swamp")   # 2 swipes in front, the second one wider (r 2 m, then 3 m)
def _(g): c = (128, 150); crescent(g, c, 44, -160, -20, 14); crescent(g, c, 74, -168, -12, 13)
@icon("rabbit_coinRazan_cAttack", "swamp")   # one heavy slam that launches everyone in the area (r 4 m)
def _(g):
    c = (128, 156); disc(g, c, 58, True); ring(g, c, 52, 8); burst(g, c, 8, 34, 8, 7)
    for x in (92, 128, 164): line(g, (x, 96), (x, 52), 6); arrowhead(g, (x, 46), -90, 16, 6)
@icon("rabbit_coinBoldas_nAttack", "crimson")   # rushes in with 2 slashes in front, then one swing all round
def _(g): c = (128, 132); arc(g, c, 76, 20, 330, 7); crescent(g, (118, 120), 42, -170, -60, 13); crescent(g, (140, 108), 42, -120, -10, 13)
@icon("rabbit_coinBoldas_leapingLion", "crimson")   # leaps forward and slashes down once
def _(g): pts = bezier((70, 212), (64, 40), (150, 64)); trail(g, pts[:-3], 4, 7, dashed=True); arrowhead(g, pts[-1], math.degrees(math.atan2(pts[-1][1] - pts[-3][1], pts[-1][0] - pts[-3][0])), 20, 6); crescent(g, (176, 150), 52, -100, 40, 16)
@icon("rabbit_coinBoldas_ligerSwing", "crimson")   # 2 s stance, 2 spins, then a spinning chase with 14 more (16 hits): a looping spin path moving forward
def _(g):
    pts = [(128 + 40 * math.cos(t), 206 - 7.2 * t - 26 * math.sin(t)) for t in np.linspace(0, 6 * math.pi, 140)]
    trail(g, pts, 5, 8); a = math.degrees(math.atan2(pts[-1][1] - pts[-3][1], pts[-1][0] - pts[-3][0])); arrowhead(g, pts[-1], a, 18, 7)
@icon("rabbit_coinBoldas_crushingTiger", "crimson")   # slams the ground round itself twice (r 16 m) and pushes everyone away
def _(g):
    c = (128, 128); disc(g, c, 90, True); ring(g, c, 34, 9); ring(g, c, 56, 6)
    for i in range(8): a = math.radians(22.5 + 45 * i); e = (c[0] + math.cos(a) * 88, c[1] + math.sin(a) * 88); line(g, (c[0] + math.cos(a) * 66, c[1] + math.sin(a) * 66), e, 6); arrowhead(g, e, math.degrees(a), 14, 6)
@icon("rabbit_coinItalus_pointBlank", "sky")   # 4 shots 0.1 s apart, each hits the first target in the way
def _(g):
    ring(g, (128, 50), 16, 5); disc(g, (128, 50), 5)
    for y in (88, 118, 148, 178): tracer(g, (128, y + 20), (128, y), 9)
@icon("rabbit_coinItalus_backDraw", "sky")   # hops back, then one shot that hits everyone along the line ahead
def _(g): line(g, (96, 196), (128, 214), 8); line(g, (160, 196), (128, 214), 8); poly(g, [(116, 170), (140, 170), (140, 30), (116, 30)], soft=True); tracer(g, (128, 168), (128, 36), 16); muzzle(g, (128, 172), 18)
@icon("rabbit_coinItalus_bulletRain", "sky")   # bullets rain on everyone in the area 10 times (r 16 m)
def _(g):
    disc(g, (128, 128), 86, True)
    for x, y in ((80, 90), (112, 70), (150, 84), (182, 110), (96, 132), (136, 120), (168, 156), (84, 176), (124, 168), (150, 198)): tracer(g, (x + 14, y - 30), (x, y), 7)
@icon("rabbit_coinItalus_thousandShot", "sky")   # 10 rapid shots ahead, each hits everyone in the line (4 m wide, 24 m long)
def _(g):
    poly(g, [(96, 196), (160, 196), (160, 30), (96, 30)], soft=True)
    for x, y in ((104, 52), (116, 40), (128, 30), (140, 40), (152, 52)): tracer(g, (x, 190), (x, y), 7)
    muzzle(g, (128, 204), 20)

# ---------------- Mounts (bronze; each class's mount has its own moves) ----------------
@icon("wolf_mountAttack", "bronze")   # slash in front (2 x 3 m)
def _(g): crescent(g, (128, 176), 66, -140, -40, 16)
@icon("wolf_mountDash", "bronze")   # dash forward (16 -> 8) slashing all along the path
def _(g): chevrons(g, 128, 212, 2, 30, 20, 8); poly(g, [(104, 180), (152, 180), (152, 36), (104, 36)], soft=True); tapered(g, (128, 186), (128, 34), 22)
@icon("bison_mountAttack", "bronze")   # smash in front, wide (6 x 3 m)
def _(g): poly(g, [(54, 150), (202, 150), (202, 100), (54, 100)], soft=True); tapered(g, (50, 130), (206, 130), 22); burst(g, (128, 120), 30, 56, 7, 7, -168, None)
@icon("bison_mountDash", "bronze")   # slams the ground round itself (r 8 m)
def _(g): c = (128, 128); disc(g, c, 88, True); ring(g, c, 80, 9); disc(g, c, 14); cracks(g, c, 22, 66, 6, 6)
@icon("panda_mountAttack", "bronze")   # hits in front (2 x 3 m)
def _(g): disc(g, (128, 110), 40, True); burst(g, (128, 110), 12, 44, 8, 10, 0, 0.55); line(g, (128, 210), (128, 160), 12)
@icon("panda_mountDash", "bronze")   # spins, hitting all round (r 6 m)
def _(g):
    c = (128, 128); disc(g, c, 80, True)
    for i in range(3): a0 = -90 + 120 * i; arc(g, c, 70, a0 + 10, a0 + 95, 9); e = math.radians(a0 + 95); arrowhead(g, (c[0] + math.cos(e) * 70, c[1] + math.sin(e) * 70), a0 + 95 + 90, 20, 8)
    disc(g, c, 12)
@icon("whale_mountAttack", "bronze")   # wide swipe in front (8 -> 6 m wide, 4 m deep)
def _(g): crescent(g, (128, 250), 150, -158, -22, 22); crescent(g, (128, 250), 118, -146, -34, 7)
@icon("whale_mountDash", "bronze")   # lance thrust forward (3 x 8 m), a little to the right
def _(g): x = 140; tapered(g, (x, 214), (x, 70), 14, head=True); poly(g, [(x, 22), (x + 13, 66), (x, 80), (x - 13, 66)]); line(g, (x - 26, 196), (x + 26, 196), 7)
@icon("cat_mountAttack", "bronze")   # swipe all round (r 7 m)
def _(g):
    c = (128, 128); disc(g, c, 84, True)
    for i in range(4): crescent(g, c, 72, -80 + 90 * i, -10 + 90 * i, 15)
@icon("cat_mountDash", "bronze")   # one straight shot, hits the first target (40 m)
def _(g): tracer(g, (128, 204), (128, 40), 15); muzzle(g, (128, 210), 22)
@icon("chameleon_mountAttack", "bronze")   # arrow forward (30 m/s, 0.8 s), hits the first target
def _(g): tapered(g, (128, 214), (128, 70), 10, head=True); poly(g, [(128, 34), (146, 74), (128, 64), (110, 74)]); line(g, (112, 210), (128, 190), 5); line(g, (144, 210), (128, 190), 5)
@icon("chameleon_mountDash", "bronze")   # piercing shot along a line, hits everyone on it (36 m)
def _(g): line(g, (128, 214), (128, 30), 8); arrowhead(g, (128, 26), -90, 22, 8); [ring(g, (128, y), 14, 5) for y in (78, 124, 170)]
@icon("rabbit_mountAttack", "bronze")   # straight shot, hits the first target (32 m)
def _(g): tracer(g, (128, 212), (128, 72), 12); ring(g, (128, 50), 22, 5); line(g, (128, 20), (128, 34), 5); line(g, (98, 50), (112, 50), 5); line(g, (144, 50), (158, 50), 5)
@icon("rabbit_mountDash", "bronze")   # the same straight shot, fired while riding fast
def _(g): chevrons(g, 128, 216, 2, 28, 18, 7); tracer(g, (128, 176), (128, 72), 12); ring(g, (128, 50), 22, 5); line(g, (128, 20), (128, 34), 5); line(g, (98, 50), (112, 50), 5); line(g, (144, 50), (158, 50), 5)
@icon("mole_mountAttack", "bronze")   # bomb shot forward, explodes on contact (r 4 m)
def _(g): t = (128, 74); disc(g, t, 46, True); trail(g, bezier((128, 214), (176, 150), (t[0], t[1] + 36)), 4, 8, dashed=True); bomb(g, t, 22)
@icon("mole_mountDash", "bronze")   # drops a bomb where it stands, explodes after 1 s (r 4 m)
def _(g): c = (128, 136); disc(g, c, 76, True); bomb(g, c, 28); arc(g, c, 70, 0, 360, 4)
@icon("monkey_mountAttack", "bronze")   # hits in front (2 x 3 m) with the staff
def _(g): line(g, (84, 210), (160, 84), 14); burst(g, (168, 72), 12, 40, 8, 8)
@icon("monkey_mountDash", "bronze")   # releases power all round (TAL, r 6 m)
def _(g): c = (128, 128); disc(g, c, 84, True); ring(g, c, 40, 9); disc(g, c, 14); burst(g, c, 52, 84, 12, 8)
@icon("sheep_mountAttack", "bronze")   # a slow orb of light forward (8 m/s), hits the first target
def _(g): disc(g, (128, 70), 26); ring(g, (128, 70), 38, 4); [disc(g, (128, y), r) for y, r in ((122, 7), (152, 6), (178, 5), (200, 4))]
@icon("sheep_mountDash", "bronze")   # heals itself and the team round it (r 6 m)
def _(g): c = (128, 128); disc(g, c, 82, True); ring(g, c, 76, 7); plus(g, c, 40, 22)
@icon("penguin_mountAttack", "bronze")   # ice shard forward, hits the first target and stacks Ice
def _(g): tapered(g, (128, 214), (128, 92), 12, head=True); snowflake(g, (128, 60), 30, 6)
@icon("penguin_mountDash", "bronze")   # cold blast all round (TAL, r 6 m)
def _(g): c = (128, 128); disc(g, c, 84, True); ring(g, c, 80, 6); snowflake(g, c, 58, 9)
@icon("bat_mountAttack", "bronze")   # 3 magic bolts in a fan, 15 degrees apart
def _(g):
    for a in (-15, 0, 15): e = (128 + math.sin(math.radians(a)) * 170, 214 - math.cos(math.radians(a)) * 170); tracer(g, (128, 214), e, 12)
@icon("bat_mountDash", "bronze")   # releases power all round and stacks Curse (TAL, r 6 m)
def _(g): c = (128, 128); disc(g, c, 84, True); ring(g, c, 78, 7); spiral(g, c, 52, 2.2, 9)
@icon("common_championMount_charge", "bronze")   # charge, then rush forward (10) hitting the front once 0.2 s in
def _(g): chevrons(g, 128, 214, 3, 36, 22, 9); poly(g, [(80, 120), (176, 120), (176, 60), (80, 60)], soft=True); line(g, (78, 96), (178, 96), 14); burst(g, (128, 70), 6, 26, 7, 7, -180, None)

ROMAN = {1: "I", 2: "II", 3: "III", 4: "IV", 5: "V"}
def key_for(card):
    m = re.match(r"^(.*?)(\d+)$", card)
    return "mv_" + (m.group(1) + ROMAN[int(m.group(2))] if m else card)

if __name__ == "__main__":
    ap = argparse.ArgumentParser(); ap.add_argument("ids", nargs="*"); ap.add_argument("--sheet"); ap.add_argument("--out"); ap.add_argument("--write", action="store_true")
    a = ap.parse_args()
    unknown = [i for i in a.ids if i not in ICONS]
    if unknown: sys.exit("no icon for: " + ", ".join(unknown))
    if a.write and a.ids: sys.exit("--write rebuilds every icon: run it without card ids")
    imgs = {}
    for card, (pal, fn) in ICONS.items():
        if a.ids and card not in a.ids: continue
        g = G(); fn(g); imgs[card] = render(g, pal)
        if a.out: os.makedirs(a.out, exist_ok=True); imgs[card].save(os.path.join(a.out, card + ".png"))
    if a.sheet:
        S, C = 150, 9; rows = (len(imgs) + C - 1) // C; sheet = Image.new("RGB", (C * S, rows * (S + 14)), (30, 26, 34)); d = ImageDraw.Draw(sheet)
        for i, (card, im) in enumerate(imgs.items()):
            x, y = (i % C) * S, (i // C) * (S + 14); sheet.paste(im.resize((S - 6, S - 6), Image.LANCZOS), (x + 3, y + 3)); d.text((x + 4, y + S - 4), card[-24:], fill=(255, 230, 180))
        sheet.save(a.sheet); print("sheet:", a.sheet)
    if a.write:
        s = open(ASSETS, encoding="utf-8", newline="").read()
        i = s.index("BIBLE_ASSETS.SKILL_ICONS = {"); eol = s.index("\n", i) + 1; j = s.index("\n};", i)
        nl = "\r\n" if s[eol - 2:eol] == "\r\n" else "\n"
        body = re.sub(r'^"mv_[^"]*":[^\n]*\n', "", s[eol:j], flags=re.M)   # the old mv_ entries (always written first, never the block's last line)
        lines = []
        def emit(k, im):
            buf = io.BytesIO(); im.resize((128, 128), Image.LANCZOS).save(buf, "WEBP", quality=90, method=6)
            lines.append('"%s": "data:image/webp;base64,%s",' % (k, base64.b64encode(buf.getvalue()).decode()))
        for card, im in imgs.items():
            emit(key_for(card), im)
            for r in range(1, RANKS.get(card, 0) + 1):
                g = G(); ICONS[card][1](g, r); emit(key_for(card) + str(r), render(g, ICONS[card][0]))
        open(ASSETS, "w", encoding="utf-8", newline="").write(s[:eol] + nl.join(lines) + nl + body + s[j:])
        print("wrote", len(lines), "mv_ icons into", ASSETS, "- now run: node scripts/bible_assets.js stamp")
    if not (a.sheet or a.out or a.write): print(len(imgs), "icons drawn; pass --sheet <png>, --out <dir> or --write")
