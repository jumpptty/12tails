#!/bin/sh
# PreToolUse guard for Edit/Write/NotebookEdit: blocks edits to the decompiled
# .cs source (DecompiledSource/, moved out of the repo root 2026-08-18 --
# this repo has no build step, see CLAUDE.md) and to RippedAssets/ /
# 12TailsOnline_Data/ (binary game data, git-ignored). Both are read-and-
# analysis only per this repo's CLAUDE.md. The *.cs match below is
# path-agnostic (any .cs anywhere in the repo, not just DecompiledSource/),
# so this hook needed no functional change when the files moved.
p=$(sed -n 's/.*"\(file_path\|notebook_path\)" *: *"\([^"]*\)".*/\2/p')
[ -z "$p" ] && exit 0
low=$(printf '%s' "$p" | tr '\\' '/' | tr '[:upper:]' '[:lower:]')
case "$low" in
  *.cs)
    printf '{"hookSpecificOutput":{"hookEventName":"PreToolUse","permissionDecision":"deny","permissionDecisionReason":"Decompiled .cs source is read-and-analysis only, never edited -- this repo has no build step. See CLAUDE.md."}}\n'
    ;;
  */rippedassets/*)
    printf '{"hookSpecificOutput":{"hookEventName":"PreToolUse","permissionDecision":"deny","permissionDecisionReason":"RippedAssets/ is raw AssetRipper export data, not source -- never edited. See CLAUDE.md."}}\n'
    ;;
  */12tailsonline_data/*)
    printf '{"hookSpecificOutput":{"hookEventName":"PreToolUse","permissionDecision":"deny","permissionDecisionReason":"12TailsOnline_Data/ is the installed game build -- binaries, assets, and manifests are data, not source. Never edited. See CLAUDE.md."}}\n'
    ;;
esac
