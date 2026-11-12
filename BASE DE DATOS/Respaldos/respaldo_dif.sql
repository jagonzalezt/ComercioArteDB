-- Respaldo diferencial (solo lo que cambio desde el ultimo completo)
DECLARE @archivo NVARCHAR(260) =
  N'C:\Respaldos\ComercioArtesDB_DIF_' + FORMAT(GETDATE(), 'yyyyMMdd_HHmm') + N'.bak';
BACKUP DATABASE ComercioArtesDB
TO DISK = @archivo
WITH DIFFERENTIAL, INIT, CHECKSUM, STATS = 10, NAME = N'NicaArt respaldo diferencial';
