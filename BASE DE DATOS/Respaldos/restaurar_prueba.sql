-- Restaura en una base de prueba (no toca la base real).
-- Cambiar AAAAMMDD_HHMM por los nombres reales de los archivos.
RESTORE DATABASE ComercioArtesDB_Prueba
FROM DISK = N'C:\Respaldos\ComercioArtesDB_FULL_AAAAMMDD_HHMM.bak'
WITH MOVE N'ComercioArtesDB' TO N'C:\Respaldos\prueba\ComercioArtesDB_Prueba.mdf',
     MOVE N'ComercioArtesDB_log' TO N'C:\Respaldos\prueba\ComercioArtesDB_Prueba.ldf',
     NORECOVERY, REPLACE;

RESTORE DATABASE ComercioArtesDB_Prueba
FROM DISK = N'C:\Respaldos\ComercioArtesDB_DIF_AAAAMMDD_HHMM.bak' WITH NORECOVERY;

RESTORE LOG ComercioArtesDB_Prueba
FROM DISK = N'C:\Respaldos\ComercioArtesDB_LOG_AAAAMMDD_HHMM.trn' WITH RECOVERY;

-- Comparar la cantidad de registros
SELECT (SELECT COUNT(*) FROM ComercioArtesDB.dbo.Usuarios) AS UsuariosOriginal,
       (SELECT COUNT(*) FROM ComercioArtesDB_Prueba.dbo.Usuarios) AS UsuariosPrueba;
