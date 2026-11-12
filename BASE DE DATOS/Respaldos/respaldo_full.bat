@echo off
sqlcmd -S (local) -E -i C:\Respaldos\scripts\respaldo_full.sql
powershell -NoProfile -Command "$f = Get-ChildItem C:\Respaldos\*_FULL_*.bak | Sort-Object LastWriteTime -Descending | Select-Object -First 1; Compress-Archive -Path $f.FullName -DestinationPath ($f.FullName + \x27.zip\x27) -Force"
