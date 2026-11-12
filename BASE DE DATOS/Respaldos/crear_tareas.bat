@echo off
schtasks /create /tn "NicaArt_Full" /tr "C:\Respaldos\scripts\respaldo_full.bat" /sc weekly /d SUN /st 23:00 /f
schtasks /create /tn "NicaArt_Diferencial" /tr "C:\Respaldos\scripts\respaldo_dif.bat" /sc weekly /d MON,TUE,WED,THU,FRI,SAT /st 23:00 /f
schtasks /create /tn "NicaArt_Log" /tr "C:\Respaldos\scripts\respaldo_log.bat" /sc hourly /mo 2 /f
