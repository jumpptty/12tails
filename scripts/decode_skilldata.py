"""Decode obfuscated <Class>Skill.getSkill(skillname) tables from 12Tails decompiled code.

Parses the C# subset used by the decompiler output (if/else blocks, IL_ labels,
goto, break, continue inside a single for(;;)) and simulates execution for each
skill name, honoring SkillClass first-setter-wins semantics.
"""
import re, sys, json

SRC = sys.argv[1]
FUNC_NAME = "getSkill"

text = open(SRC, encoding="utf-8-sig").read()
# isolate function body: from 'public static SkillClass getSkill' to matching brace
m = re.search(r"public static SkillClass getSkill\(string skillname\)\s*\{", text)
if not m:
    raise SystemExit("getSkill not found")
i = m.end()
depth = 1
start = i
while depth > 0:
    c = text[i]
    if c == '{': depth += 1
    elif c == '}': depth -= 1
    i += 1
body = text[start:i-1]

# ---------------- tokenizer / parser ----------------
# We parse into a list of statements; blocks are nested lists.
pos = 0
n = len(body)

def skip_ws(p):
    while p < n and body[p] in ' \t\r\n':
        p += 1
    return p

def parse_block(p):
    """p points just after '{'. Returns (stmts, p_after_closing_brace)."""
    stmts = []
    while True:
        p = skip_ws(p)
        if body[p] == '}':
            return stmts, p+1
        stmt, p = parse_stmt(p)
        if stmt is not None:
            stmts.append(stmt)

def parse_stmt(p):
    p = skip_ws(p)
    # label
    mm = re.match(r"(IL_[0-9A-Fa-f]+):", body[p:])
    if mm:
        return ("label", mm.group(1)), p+mm.end()
    if body.startswith("if", p) and re.match(r"if\s*\(", body[p:]):
        mm = re.match(r"if\s*\(", body[p:])
        p2 = p + mm.end()
        # find matching close paren
        d = 1; q = p2
        while d:
            if body[q] == '(': d += 1
            elif body[q] == ')': d -= 1
            q += 1
        cond = body[p2:q-1]
        q = skip_ws(q)
        assert body[q] == '{', body[q:q+40]
        then, q = parse_block(q+1)
        q2 = skip_ws(q)
        els = None
        if body.startswith("else", q2):
            q3 = skip_ws(q2+4)
            if body.startswith("if", q3):
                stmt, q4 = parse_stmt(q3)
                els = [stmt]
                q = q4
            else:
                assert body[q3] == '{'
                els, q = parse_block(q3+1)
        return ("if", cond, then, els), q
    if body.startswith("for (;;)", p) or body.startswith("for(;;)", p):
        q = body.index('{', p)
        blk, q = parse_block(q+1)
        return ("loop", blk), q
    if body.startswith("while", p):
        mm = re.match(r"while\s*\(", body[p:])
        p2 = p + mm.end()
        d = 1; q = p2
        while d:
            if body[q] == '(': d += 1
            elif body[q] == ')': d -= 1
            q += 1
        cond = body[p2:q-1]
        q = skip_ws(q)
        assert body[q] == '{'
        blk, q = parse_block(q+1)
        return ("while", cond, blk), q
    # simple statement to ';'
    q = body.index(';', p)
    s = body[p:q].strip()
    return ("stmt", s), q+1

stmts, _ = parse_block(0) if False else (None, None)
# top-level isn't a brace block; parse sequentially
stmts = []
p = 0
while True:
    p = skip_ws(p)
    if p >= n: break
    st, p = parse_stmt(p)
    stmts.append(st)

# ---------------- evaluator ----------------
class Done(Exception):
    pass

def eval_cond(cond, name):
    cond = cond.strip()
    # handle && / || at top level
    def split_top(c, op):
        d = 0; parts = []; last = 0; i = 0
        while i < len(c):
            ch = c[i]
            if ch == '(': d += 1
            elif ch == ')': d -= 1
            elif d == 0 and c.startswith(op, i):
                parts.append(c[last:i]); last = i+2; i += 2; continue
            i += 1
        parts.append(c[last:])
        return parts if len(parts) > 1 else None
    for op, fn in (("||", any), ("&&", all)):
        parts = split_top(cond, op)
        if parts:
            return fn(eval_cond(x, name) for x in parts)
    if cond.startswith('!(') and cond.endswith(')'):
        return not eval_cond(cond[2:-1], name)
    mm = re.match(r'^\(?\s*skillname\s*(==|!=)\s*"([^"]*)"\s*\)?$', cond)
    if mm:
        r = (name == mm.group(2))
        return r if mm.group(1) == '==' else not r
    mm = re.match(r"^\(?\s*(-?\d+)\s*-\s*(\d+)\s*(==|!=)\s*(-?\d+)\s*\)?$", cond)
    if mm:
        a, b, op, c = int(mm.group(1)), int(mm.group(2)), mm.group(3), int(mm.group(4))
        r = (a - b == c)
        return r if op == '==' else not r
    raise ValueError("cannot eval: " + cond)

class Sim:
    def __init__(self, name):
        self.name = name
        self.reset()
        self.steps = 0

    def reset(self):
        self.obj = {"reqLv": None, "reqBn": None, "MP": 0, "SP": 0,
                    "mode": None, "target": None, "cType": None}

    def call(self, s):
        o = self.obj
        mm = re.match(r"skillClass\.setReq\((-?\d+), (-?\d+)\)", s)
        if mm:
            if o["reqLv"] is None:
                o["reqLv"], o["reqBn"] = int(mm.group(1)), int(mm.group(2))
            return
        mm = re.match(r"skillClass\.setMPSP\((-?\d+), (-?\d+)\)", s)
        if mm:
            if o["MP"] == 0: o["MP"] = int(mm.group(1))
            if o["SP"] == 0: o["SP"] = int(mm.group(2))
            return
        mm = re.match(r"skillClass\.setMP\((-?\d+)\)", s)
        if mm:
            if o["MP"] == 0: o["MP"] = int(mm.group(1))
            return
        mm = re.match(r"skillClass\.setSP\((-?\d+)\)", s)
        if mm:
            if o["SP"] == 0: o["SP"] = int(mm.group(1))
            return
        mm = re.match(r"skillClass\.mode = eSkillMode\.(\w+)", s)
        if mm:
            o["mode"] = mm.group(1); return
        mm = re.match(r"skillClass\.target = eSkillTarget\.(\w+)", s)
        if mm:
            o["target"] = mm.group(1); return
        mm = re.match(r'skillClass\.cType = "([^"]*)"', s)
        if mm:
            o["cType"] = mm.group(1); return
        if s.startswith("skillClass = new SkillClass()"):
            self.reset(); return
        if s.startswith("return"):
            raise Done()
        # SkillClass skillClass; declarations etc: ignore
        return

    # execution with goto support: we flatten the AST into linear ops
    def run(self, flat, labels):
        ip = 0
        loop_stack = []
        while ip < len(flat):
            self.steps += 1
            if self.steps > 200000:
                raise RuntimeError("step limit " + self.name)
            op = flat[ip]
            kind = op[0]
            if kind == "label":
                ip += 1
            elif kind == "stmt":
                s = op[1]
                if s == "break":
                    ip = op[2]  # pre-resolved jump target
                elif s == "continue":
                    ip = op[2]
                elif s.startswith("goto "):
                    ip = labels[s[5:].strip()]
                else:
                    self.call(s)
                    ip += 1
            elif kind == "if":
                cond, tgt_else, tgt_end = op[1], op[2], op[3]
                if eval_cond(cond, self.name):
                    ip += 1
                else:
                    ip = tgt_else
            elif kind == "jmp":
                ip = op[1]
            elif kind == "loopstart":
                ip += 1
            else:
                raise ValueError(kind)
        return self.obj

# flatten AST -> linear ops with resolved jumps
flat = []
labels = {}

def emit(op):
    flat.append(op)
    return len(flat)-1

def flatten(stmts, loop_ctx):
    for st in stmts:
        k = st[0]
        if k == "label":
            labels[st[1]] = len(flat)
            emit(("label", st[1]))
        elif k == "stmt":
            s = st[1]
            if s == "break":
                idx = emit(("stmt", "break", None))
                loop_ctx["breaks"].append(idx)
            elif s == "continue":
                idx = emit(("stmt", "continue", None))
                loop_ctx["continues"].append(idx)
            else:
                emit(("stmt", s))
        elif k == "if":
            cond, then, els = st[1], st[2], st[3]
            jidx = emit(("if", cond, None, None))
            flatten(then, loop_ctx)
            if els:
                skip = emit(("jmp", None))
                flat[jidx] = ("if", cond, len(flat), None)
                flatten(els, loop_ctx)
                flat[skip] = ("jmp", len(flat))
            else:
                flat[jidx] = ("if", cond, len(flat), None)
        elif k == "loop":
            start = len(flat)
            ctx = {"breaks": [], "continues": []}
            emit(("loopstart",))
            flatten(st[1], ctx)
            emit(("jmp", start))
            end = len(flat)
            for b in ctx["breaks"]:
                flat[b] = ("stmt", "break", end)
            for c in ctx["continues"]:
                flat[c] = ("stmt", "continue", start)
        elif k == "while":
            # rare; treat cond loop
            start = len(flat)
            ctx = {"breaks": [], "continues": []}
            jidx = emit(("if", st[1], None, None))
            flatten(st[2], ctx)
            emit(("jmp", start))
            flat[jidx] = ("if", st[1], len(flat), None)
            end = len(flat)
            for b in ctx["breaks"]:
                flat[b] = ("stmt", "break", end)
            for c in ctx["continues"]:
                flat[c] = ("stmt", "continue", start)
        else:
            raise ValueError(k)

root_ctx = {"breaks": [], "continues": []}
flatten(stmts, root_ctx)

# collect all skill names referenced
names = sorted(set(re.findall(r'skillname == "([^"]+)"', body)))
out = {}
for nm in names:
    sim = Sim(nm)
    try:
        sim.run(flat, labels)
    except Done:
        pass
    out[nm] = sim.obj
print(json.dumps(out, indent=1))
