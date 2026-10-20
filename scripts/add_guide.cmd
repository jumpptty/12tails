@echo off
rem Double-click: paste a class guide code (TG2....); it is checked, added to the Bible and pushed to GitHub (see add_guide.js).
chcp 65001 >nul
cd /d "%~dp0.."
node scripts\add_guide.js %*
echo.
pause
