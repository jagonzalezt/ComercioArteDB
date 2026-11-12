-- Muestra los ultimos respaldos: D = completo, I = diferencial, L = log
SELECT TOP 10 database_name, type, backup_start_date, backup_finish_date
FROM msdb.dbo.backupset
WHERE database_name = 'ComercioArtesDB'
ORDER BY backup_start_date DESC;

-- Revisa que un archivo no este dañado (cambiar AAAAMMDD_HHMM por el nombre real)
RESTORE VERIFYONLY
FROM DISK = N'C:\Respaldos\ComercioArtesDB_FULL_AAAAMMDD_HHMM.bak' WITH CHECKSUM;
