@echo off
@echo  >gamestats.log
@cd "%~dp0"
@start "" "..\..\common\Half-Life 2\hl2.exe" -game "%~dp0" -novid -developer 99 -console %*