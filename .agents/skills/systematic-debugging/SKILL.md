---
name: systematic-debugging
description: Use when diagnosing bugs, unexpected values, formula mismatches, UI rendering glitches, or runtime errors. Enforces disciplined root-cause isolation.
---

# Systematic Debugging Skill

## Purpose
Enforce a disciplined, hypothesis-driven debugging process to find the true root cause of issues rather than guessing or applying surface-level patches.

## Workflow

### 1. Characterize the Symptom & Establish Baseline
* Capture exact observed behavior vs. expected behavior.
* Gather relevant inputs, environment state, and error logs (e.g. browser console, node error, formula output).

### 2. Formulate Testable Hypotheses
* Propose 1–3 specific, testable explanations for why the failure occurs (e.g. operator precedence, async timing, missing dependency, CSS selector conflict, obfuscated loop exit).
* Rank hypotheses by likelihood.

### 3. Isolate & Inspect (No Guessing)
* Trace the code execution path from input to point of failure.
* Verify against ground-truth source citations (`DecompiledSource/`, `CharacterControl.cs`, `*-skill-reference.md`).
* Add minimal targeted logging or assertions to confirm or refute each hypothesis.

### 4. Apply Minimal Root-Cause Fix
* Fix the fundamental defect at the source without introducing collateral side effects.
* Avoid band-aid workarounds (e.g., adding `!important` to CSS or arbitrarily multiplying a factor).

### 5. Verification & Regression Check
* Verify that the original error is resolved under the reproduction conditions.
* Test boundary/edge cases (e.g., min/max stats, 0-value inputs, multi-hit skills).
* Check for unintended regressions in adjacent components.
