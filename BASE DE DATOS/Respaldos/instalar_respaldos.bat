@echo off
rem Ejecutar como administrador, dentro de esta carpeta.
mkdir C:\Respaldos
mkdir C:\Respaldos\scripts
mkdir C:\Respaldos\prueba
copy *.sql C:\Respaldos\scripts
copy *.bat C:\Respaldos\scripts
sqlcmd -S (local) -E -i 00_Preparar_Respaldos.sql
call C:\Respaldos\scripts\respaldo_full.bat
call crear_tareas.bat
echo Listo. Revisa las tareas en el Programador de tareas de Windows.
pause
