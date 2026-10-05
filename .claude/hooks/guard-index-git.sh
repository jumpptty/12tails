#!/bin/sh
# PreToolUse guard for Bash/PowerShell: blocks git commands that can overwrite
# uncommitted work in 12t_projects/bible/index.html (AGENTS.md "Editing
# index.html safely": never checkout / restore / reset / stash it; recover from
# the scratch-dir backup instead). Denied:
#   git checkout|restore ... index.html, or ... .  (whole tree)
#   git reset --hard
#   git stash (except list / show)
# Only a real git subcommand counts (git [-C dir] checkout ...), not the words inside a commit message.
# Allowed: branch switches, reset --soft/--mixed, stash list/show, everything else.
cmd=$(cat | tr '\n' ' ')
deny() {
  printf '{"hookSpecificOutput":{"hookEventName":"PreToolUse","permissionDecision":"deny","permissionDecisionReason":"%s"}}\n' "$1"
  exit 0
}
printf '%s' "$cmd" | grep -Eq 'git([[:space:]]+(-C[[:space:]]+[^[:space:]]+|-c[[:space:]]+[^[:space:]]+|-[^[:space:]]+))*[[:space:]]+(checkout|restore|reset|stash)([[:space:]]|\\"|"|$)' || exit 0
if printf '%s' "$cmd" | grep -Eq 'git([[:space:]]+(-C[[:space:]]+[^[:space:]]+|-c[[:space:]]+[^[:space:]]+|-[^[:space:]]+))*[[:space:]]+(checkout|restore)(([[:space:]][^|;&]*)?[[:space:]]\.([[:space:]]|\\"|"|$)|[[:space:]][^|;&]*index\.html)'; then
  deny "Blocked: git checkout/restore on index.html (or the whole tree) can silently drop uncommitted card work. Recover from the scratch-dir backup instead (AGENTS.md, Editing index.html safely)."
fi
if printf '%s' "$cmd" | grep -Eq 'git([[:space:]]+(-C[[:space:]]+[^[:space:]]+|-c[[:space:]]+[^[:space:]]+|-[^[:space:]]+))*[[:space:]]+reset[[:space:]][^|;&]*--hard'; then
  deny "Blocked: git reset --hard can silently drop uncommitted work in index.html. Recover from the scratch-dir backup instead (AGENTS.md, Editing index.html safely)."
fi
if printf '%s' "$cmd" | grep -Eq 'git([[:space:]]+(-C[[:space:]]+[^[:space:]]+|-c[[:space:]]+[^[:space:]]+|-[^[:space:]]+))*[[:space:]]+stash([[:space:]]|\\"|"|$)' && ! printf '%s' "$cmd" | grep -Eq 'git([[:space:]]+(-C[[:space:]]+[^[:space:]]+|-c[[:space:]]+[^[:space:]]+|-[^[:space:]]+))*[[:space:]]+stash[[:space:]]+(list|show)'; then
  deny "Blocked: git stash can drop uncommitted work in index.html. Make a WIP commit instead (12t_projects/bible/CLAUDE.md section 1)."
fi
exit 0
