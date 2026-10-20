@echo off
rem Double-click: opens the class guide manager (add, replace or remove guides, then push to GitHub) in the browser; see add_guide.js.
rem Keep this window open while you use the page; close it to stop.
chcp 65001 >nul
cd /d "%~dp0.."
node scripts\add_guide.js %*
if errorlevel 1 pause
