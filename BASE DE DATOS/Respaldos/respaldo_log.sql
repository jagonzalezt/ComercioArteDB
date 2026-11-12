-- Respaldo del log de transacciones (necesita el modelo de recuperacion FULL
-- y un respaldo completo hecho antes)
DECLARE @archivo NVARCHAR(260) =
  N'C:\Respaldos\ComercioArtesDB_LOG_' + FORMAT(GETDATE(), 'yyyyMMdd_HHmm') + N'.trn';
BACKUP LOG ComercioArtesDB
TO DISK = @archivo
WITH INIT, CHECKSUM, NAME = N'NicaArt respaldo de log';
