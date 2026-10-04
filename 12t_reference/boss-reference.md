# Boss Reference (verified 2026-10-03)

Ground truth for the Bible **Boss Guide** page. Every value below is read from `DecompiledSource/`. Line numbers are in the original files; the coroutine bodies were read with the junk-predicate evaluator (constant `if (A - B op C)` checks resolved, dead branches dropped). Damage pipeline terms (`hit()`, `RPC_AddEffectDamage`, `talAdjust`, `getDebuff`, `defAdjust`) are defined in [12Tails-Mechanics-Reference.md](12Tails-Mechanics-Reference.md).

Common engine rules that both bosses rely on:

- **SP gain:** every damage instance a character takes runs `ApplyDamage()`, which does `sp++` (`CharacterControl.cs:2117-2122`). Outside combat actions SP drifts back to `msp` by 1 per ~1 s (`:1945-1990`, only while `standby`/`run` and 2 s after the last action when above `msp`).
- **Target pickers:** `getRandomHateTarget(maxRange)` (`CharacterControl.cs:8514`) returns a **random** living hate-list entry within `maxRange` m, so the amount of Hate does not matter. `getHateTarget(prefer, maxRange)` (`:8034`) returns the entry with the highest `hate − time + maxRange − |prefer − distance|` within `maxRange`, i.e. the top-Hate attacker with a small bonus for standing about `prefer` m away.
- **AI cycle:** each AI runs fixed-length phases (`AI_selectTarget`, `AI_idle`, `AI_attack` …) back to back; a phase that fires a skill ends early.

---

## Shadow Italus (`DarkFalcon`) — 12/6 Crossing Destiny

Fought in `M936_CrossingDestiny3` (spawned by `Game.createActor`, `M936_CrossingDestiny3.cs:655-680`); `M936_CrossingDestiny2` is the transformation cutscene (`DarkFalcon_transform`, `DarkFalcon_cast`, `:4080-4329`). Story name "Shadow Italus" (`M936_CrossingDestiny2.cs:4219`).

### Stats and immunities (`DarkFalcon.cs:25-80`)

Set in `Start()`: **HP 170,000**, KO 700, ATK 370, DEF 270, AGI 370, VIT 17,000, INT (`mag`) 170, CHA 170, TAL 370, LCK 170 (prefab: Lv 270, MP 700, resting SP 30, see the monster stats page). `mImmuneList`: `artCancel`, `swallow`, `paralysis`, `needlePrison`, `invisible`, `petrify`, `snowMan`, `snowBall`, `sleep`, `nightmare`, `charm`, `mindControl`. Outside test mode `thousandShot` starts on a 60 s timeout. KO lasts 4.8 s (`RPC_ko`, `:6796-6860`).

### AI (`DarkFalcon_AI.cs`)

- Idle (not alert): `AI_idle(3)` then `AI_visionCheck` (enemies within 32 m, every 1-2 s) (`:87-140`, `:1168`).
- Alert loop: `AI_selectTarget(1)` → `AI_idle(1)` → `AI_patrol(2)` → `AI_attack(13)` (`:120-130`). Target = `getRandomHateTarget(50)` (`:476-560`).
- `AI_attack` (`:627-1140`), first match wins, `d` = distance to the target minus its collider half-width:
  1. HP ≤ 130,000 and `shadowRain` ready → **Shadow Rain**.
  2. HP ≤ 140,000, SP ≥ 50, `darkStorm` ready, `d > 7` → **Dark Storm**.
  3. HP ≤ 145,000, SP ≥ 50, `darkFall` ready, `d < 13` → **Dark Fall**.
  4. HP ≤ 160,000, MP ≥ 50, `nightmare` ready → **Nightmare**.
  5. `d ≥ 5` and `thousandShot` ready → **Thousand Shot**.
  6. `d < 5` and `cAttack` ready → **Charge (dash)**.
  7. `nAttack` ready: `d < 3` → **Combo 3**; else 40% **Combo 2**, 60% **Combo 1**.
  8. Otherwise run at the target when `d > 12`, else stand facing it.
- None of the skills subtracts MP or SP; MP ≥ 50 / SP ≥ 50 are gates only. HP thresholds are 94.1 / 85.3 / 82.4 / 76.5 % of max HP.

### Moves (`DarkFalcon.cs`)

| Move | Timing | Hit | Area | Extra | Lock |
|---|---|---|---|---|---|
| Combo 1 (`RPC_nAttack1`, `:1952`) | aims 0.5 s | `hit(1, 0.6×ATK + talAdjust(66), KO 1)` on the first object a 60 m raycast at the target's centre meets | line | on a landed hit `corruption` Lv 5 for `getDebuff(15)` | `nAttack` 3 s |
| Combo 2 (`RPC_nAttack2` `:2511`, `RPC_nAttack2_hit` `:3000`) | aims 0.5 s, target position fixed then | 2 rings 0.2 s apart at that position: `FindAreaTarget(r = 1 + 2i, h = 2i)`, i = 1, 2 → radius 3 m then 5 m; `hit(2, 0.6×ATK + talAdjust(45), KO 10)` | circle 3 m + 5 m | inside 3 m takes both | `nAttack` 5 s |
| Combo 3 (`RPC_nAttack3`, `:3258`) | 0.7 s windup | `FindAreaTarget(self, 4, 4)`, `hit(3, ATK + talAdjust(33), KO 5)`, push ×5 | circle 4 m | — | `nAttack` 2 s |
| Charge (`RPC_cAttack`, `:3684`) | dash `moveSpeed 16 → 6 → 3 → 0`, collision with characters off | 3 checks (`i < 3`) of `FindRecTarget(pos, −forward, 4, 4, 3, 3)` (8 m wide, 3 m deep box **behind** him), `hit(11, 0.6×ATK + talAdjust(66), KO 5)` each | box behind | can hit the same target 3 times | `cAttack` 13 s |
| Thousand Shot (`RPC_thousandShot`, `:4340`) | tracks the target 2 s, then fires | `FindRecTarget(pos, forward, 5, 5, 40, 10)`: 10 m wide, 40 m long, 10 m tall; `hit(21, 499, KO 9)` once | beam | flat 499 (still `defAdjust`ed) | 60 s (also at spawn) |
| Nightmare (`RPC_nightmare`, `:4945`) | 0.5 + 0.7 s | every enemy in `FindAreaTarget(self, 50, 10)` gets `nightmare` Lv 4 for `getDebuff(6)` | circle 50 m | no damage hit | 90 s |
| Dark Fall (`RPC_darkFall` `:5383`, `RPC_darkFall_fire` `:1680`, `DarkFalcon_darkFall.cs`) | 0.5 + 1 s, then 3.2 s recovery | 8 orbs at 45° steps, 9 m/s for 4 s (≈36 m); each orb `RPC_AddEffectDamage(21, 699)` on every character it touches (`OnTriggerEnter`, orb not destroyed) | 8 rays | Effect Damage: no DEF, no dodge | 15 s |
| Dark Storm (`RPC_darkStorm`, `:5765`) | 0.5 + 1.5 s, 2 pulses 0.2 s apart, 0.7 s recovery | `FindDonutTarget(self, 6, 27, 13)`: between 6 m and 27 m; `RPC_AddEffectDamage(21, 499)` per pulse; first pulse also `armorBreak` Lv 4 for `getDebuff(15)` with `sValue = clamp(floor(0.1 × target DEF), …)` | donut 6–27 m | inside 6 m is safe | 15 s |
| Shadow Rain (`RPC_shadowRain`, `:6290`) | 2 s windup; gives himself `hide` for 3 s; 9 pulses 0.3 s apart; 3 s recovery | every enemy in `FindAreaTarget(self, 50, 10)`: `hit(61, 399, KO 9)` per pulse | circle 50 m | up to 9 × 399 and KO 81; a normal `hit()`, so it can be dodged and is blocked by the target-state exits (`salvation`, `noDamage` …) | 90 s |

---

## Captain Crab / Red Claw (`CaptainCrab`) — Pirate Cave

`M973_PirateCave` stages 5, 8 and 10 (story name "Red Claw", `M973_PirateCave5.cs:2430`, `8.cs:2447`, `10.cs:2527`) and the ship battle on stage 9 (special AI below). Loaded from `GameAssets/Characters/Tails/CaptainCrab/CaptainCrab` (`Game.cs:5570`).

### Stats and damage reduction

`Start()` sets **HP 7,300** (`CaptainCrab.cs:27`); the other stats come from the prefab: Lv 98, ATK 218, DEF 315, AGI 93, VIT 730, CHA 63, TAL 232, LCK 87, resting SP 35, KO 90. No immune list. **Every direct hit is reduced by a flat 100** after `defAdjust` (`CharacterControl.cs:31639`, `if (Type == "CaptainCrab") nDamage = max(0, nDamage − 100)`, in the `AddDamage` path only); Effect Damage is not reduced. KO lasts 1 + 3 s (`RPC_ko`).

### AI (`CaptainCrab_AI.cs`)

- Land (every map except `mGameCode 973`, `mGameStage 9`): not alert `AI_idle(3)` + `AI_patrol(1)`; alert loop `AI_selectTarget(1)` → `AI_idle(1)` → `AI_attack(6)` (`:87-180`). Target = `getHateTarget(5, 50)` (`:683-760`).
- `AI_attack` (`:834-1000`), `d` = distance minus the target's collider half-width:
  1. `d < 5`, SP ≥ 45, `cAttack` ready → **Charge**.
  2. `d < 3` and both claws ready → 50/50 **Claw 1** / **Claw 2**; then whichever claw is ready.
  3. When ≤ 1 s of the 6 s phase is left: HP < 50% and `kitchenDrop` ready → **Kitchen Drop**, else **Food Drop** (no `foodDrop` cooldown check on this path).
  4. Otherwise run at the target when `d > 2.4`, else stand facing it.
- Ship (Pirate Cave stage 9): faces −Z and never walks; loop `AI_selectTarget(1)` → `AI_sail(3)` → `AI_sailAttack(6)` (`:100-118`). `AI_sailAttack` (`:1265`): HP < 50% and `kitchenDrop` ready → Kitchen Drop; else `foodDrop` ready → Food Drop; else `d < 3` → a claw (50/50).

### Moves (`CaptainCrab.cs`)

| Move | Timing | Hit | Area | Extra | Lock |
|---|---|---|---|---|---|
| Claw 1 (`RPC_nAttack1`, `:437`) | 0.3 + 0.2 s | `FindRecTarget(pos − right, forward, 2, 2, 5, 3)`: 4 m wide (shifted 1 m left), 5 m long; `hit(1, ATK, KO 5)` | box | landed hit: crab `sp + 1`; 35% `dissolute` Lv 4 for `getDebuff(6)` | `nAttack1` 3 s |
| Claw 2 (`RPC_nAttack2`, `:603`) | 0.3 + 0.2 s | `FindRecTarget(pos, forward, 3, 3, 4, 3)`: 6 m wide, 4 m long; `hit(1, ATK, KO 5)` | box | same as Claw 1 | `nAttack2` 3 s |
| Charge (`RPC_cAttack`, `:764`) | 4 strikes, ~0.2-0.4 s apart | each `FindRecTarget(pos, forward, 2, 2, 3, 3)` (4 m wide, 3 m long), `hit(1, ATK, KO 5)`, crab `sp + 1` per landed hit | box | needs SP ≥ 45 (not spent) | `cAttack` 9 s |
| Food Drop (`RPC_foodDrop` `:1039`, `_hit` `:1182`) | 0.5 s windup; lands 0.4 s later at the target's position at that moment | `FindAreaTarget(hitPos, 5, 3)`: `hit(21, talAdjust(60), KO 10)` | circle 5 m | landed hit: `dissolute` Lv 4 for `getDebuff(6)` | `foodDrop` 6 s |
| Kitchen Drop (`RPC_kitchenDrop` `:1286`, `_hit` `:1450`) | 0.5 + 0.2 s, then a mark per enemy | marks every living enemy in `FindAreaTarget(self, 30, 6)` at its feet; 0.5 s later `hit(31, talAdjust(30), KO 3)` only if the target is still within √2 m (≈1.4 m) of its mark | circle 30 m | moving 1.5 m dodges it | `kitchenDrop` 15 s |

## Ewiniar (`Ewiniar`) — Pirate Cave stage 10 (true final boss)

Fought on the pirate ship in `M973_PirateCave10` (scene `level245`). Loaded from `GameAssets/Characters/Elementals/Ewiniar/Ewiniar` (`Game.cs:7026`).

### Stats and the shared HP pool

`Start()` sets **HP 61,500** (`Ewiniar.cs:47`). The other stats come from the prefab (`MONSTER_STATS` row `Ewiniar`): Lv 154, MP 999, resting SP 45, KO 215, ATK 315, DEF 215, AGI 215, VIT 6150, INT 415, CHA 115, TAL 315, LCK 215, weight 100. The tail parts have TAL 215. No immune list.

The boss is **five CharacterControls**: the main body plus Body, Head, Tail1 and Tail2, with ActorNr +1…+4 (`Ewiniar.cs:191, 291, 391, 491`). On every update the main HP loses the sum of `max(0, main.hp − part.hp)` over the four parts, and then every part is re-synced to the main HP (`Ewiniar.cs:645-685`). Damage to any part therefore comes off one pool, and **an area hit damages the pool once for every part it catches**, up to 5×.

### AI (`Ewiniar_AI.cs`)

Ewiniar has two states, set by `actionState` (`Ewiniar.cs:38`; it starts in `swim`, and `hold` gets a 60 s timeout at spawn, `:595`).

- **Swim:** `AI_idle(3, rand 1)` → `AI_swim(10)`.
  1. `hold` timeout ready → **Jump** (`:261`).
  2. Else, if HP < 80% and `follow` is ready → 50/50 **Follow Left** / **Follow Right** (`:292-298`).
  3. Else 50/50 **Swim Left** / **Swim Right**.
- **Hold:** `AI_hold(9, rand 6)` → `AI_attack(10)`.
  1. `swim` timeout ready → **Release** (`:500`).
  2. Else, if HP < 70% and `cyclone` is ready → **Cyclone** (`:531-537`).
  3. Else, if `nAttack` is ready → 50/50 **Water Blast** / **Lightning** (`:568`).
- **Jump** sets `actionState = "hold"` and a 60 s `swim` timeout (`Ewiniar.cs:2183, 2244`). **Release** returns to `swim` and sets the 60 s `hold` timeout again. So the boss alternates about 60 s swimming and 60 s holding the ship.
- No target selection: every attack is centred on the boss or hits every player.

### Moves (`Ewiniar.cs`)

| Move | Timing | Hit | Extra | Lock |
|---|---|---|---|---|
| Swim Left / Right | 1 + 5.5 + 17.5 s | none | movement only. Water rings at local (±36, 0, 81) and (±36, 0, −89), i.e. a lane 36 m to the side of the ship | — |
| Jump | 3 + 4 s | none | enters `hold` | `swim` 60 s |
| Release | 4 + 4 s | none | back to `swim` | `hold` 60 s |
| Water Blast | 1 s windup; 5 pulses 0.2 s apart | each pulse: `FindRecTarget(self + (0, 12, −30 + 6i), forward, 12, 12, 30, 30)` (24 m wide, 30 m long, advancing 6 m per pulse) and `hit(11, 0.5 × ATK = 157, KO 1, push 3)` (`:2928`) | up to 5 hits | `nAttack` 6 s |
| Lightning | 1.5 s windup, 1.5 s recovery | everyone in `FindAreaTarget(self, 80, 30)`: `hit(21, talAdjust(120) ≈ 876–976, KO 1)` (`:3203-3242`) | landed hit: `paralysis` Lv 2 for `getDebuff(6)` (`:3286`) | `nAttack` 9 s |
| Cyclone | 1.5 s windup | one `Ewiniar_cyclone` under every player in `FindPlayerTarget(self, 80)` (`:3653`) | see below | `cyclone` 24 s |
| Follow Left | 2 + 2 + 6 + 8 s | Lightning on everyone within 80 m, `talAdjust(120)` (`:4090-4129`) | `paralysis` Lv 2 for a flat 3 s | `follow` 30 s |
| Follow Right | 2 + 2 + 6 + 8 s | cyclones on every player within 80 m | — | `follow` 30 s |

**Cyclone** (`Ewiniar_cyclone.cs`): it lasts 10 s and homes on the player it spawned under. Every 0.35 s (`:191`) it deals `RPC_AddEffectDamage(31, talAdjust(15) ≈ 109–122)` (purple, no DEF) to every character within `FindAreaTarget(pos, 2, 6)` (mask `130816` minus Ewiniar's own layer, `:196-247`). It ends when its target or Ewiniar dies.

### Ship mechanics (`M973_PirateCave10.cs`, `PirateCannon_fire.cs`)

Positions are level245 world coordinates. The ship is at (0, 50, 0) facing −Z, so the bow is −Z and the ship's right is −X. Ewiniar spawns at (0, 51, 0).

**Cannons:** `PirateCannon1-6`, each an IconControl `UsePirateCannon n` with use range 2 m.

- `UsePirateCannon` (`:329`): fires only if that cannon's own 2 s timer has expired; otherwise it shows "Cannon*n* time out". The shot is synced to the other players through mission event 9733 (`:361`).
- `OnPirateCannonFire` (`:376-426`): spawns `PirateCannon_fire` at the cannon + `TransformDirection(0, 1, 3)`, with rotation `LookRotation(forward + 0.2·up)`.
- **Projectile** (`PirateCannon_fire.cs`). The prefab overrides the constructor defaults (decoded from `sharedassets246`):
  - mVelocity 18, mBackVelocity −2, mWaterLimit 51, mDamage 800, mRange 24;
  - Rigidbody with gravity, so it flies on a ballistic arc;
  - every FixedUpdate moves it −2 m/s along world Z, i.e. toward the bow.
  - It explodes when its y drops below 51 or when its trigger touches any layer > 2.
- **Explosion:** `FindAreaTarget(pos, 24, 24, mask 130816)`, which includes players. Each character in range takes `RPC_AddDamage(9733, floor(800 × (1 − 0.5 × dist / 24)))` (`:236`): no DEF, 800 at the centre down to 400 at the edge, once per boss part caught.

| Cannon | Position (x, z) | Fires | Lands (x, z) | Distance from cannon | Flight time |
|---|---|---|---|---|---|
| 1 | (−9.06, 1.41) | ship's right | (−43.5, −2.2) | ~34.6 m | ~1.8 s |
| 3 | (−9.28, −3.94) | ship's right | (−43.7, −7.5) | ~34.6 m | ~1.8 s |
| 2 | (9.28, 1.46) | ship's left | (43.7, −2.1) | ~34.6 m | ~1.8 s |
| 4 | (9.28, −4.04) | ship's left | (43.7, −7.6) | ~34.6 m | ~1.8 s |
| 5 | (−3.98, −33.72), y 68 | bow, 30° right | (−27.9, −80.1) | ~52 m | ~2.6 s |
| 6 | (3.94, −33.69), y 68 | bow, 30° left | (26.9, −78.1) | ~50 m | ~2.5 s |

The landing points come from integrating the decoded physics (gravity −9.8, drag 0) to y < 51. A side shot lands about 7.5 m beyond Ewiniar's 36 m swim lane, about 673 per part. A bow shot lands about 8–10 m from the bow end of the swim lane.

**Armed saw:** `PirateShipBlade` at (0, 60, 18.5) on the stern, with `BladeSwitch1` (−7.29, 63.59, 19.61) and `BladeSwitch2` (7.29, 63.59, 19.61). Each switch has use range 3 m.

- **Arming:** `UseBladeSwitch1/2` (`:470`, `:571`). If that switch is already armed the message is "Use other switch". During the 12 s lockout it is "ShipBlade Time out". Otherwise the switch arms ("Ship's Blade switch *n* activated!", `:3788`, `:3816`).
- An armed switch stays armed with no timeout. The blade fires once both switches are armed (`:685`, `:711`).
- **`OnBladeSwitch`:** the blade animation plays, then a 0.5 s wait, then `FindAreaTarget(blade, 20, 6, mask 32768)` (enemy layer only, `:3690`). Each part in range takes `RPC_AddDamage(9733, 3499)` (`:3735`): flat, no DEF.
- **Reset:** after 12 s both switches reset.
- So one player can pre-arm one switch and fire the blade from the other when Ewiniar is near the stern. That is 3,499 per part, up to 17,495 (28% of HP) when all five parts are caught.
