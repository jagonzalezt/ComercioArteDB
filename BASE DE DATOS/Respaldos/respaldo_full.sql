-- Respaldo completo
DECLARE @archivo NVARCHAR(260) =
  N'C:\Respaldos\ComercioArtesDB_FULL_' + FORMAT(GETDATE(), 'yyyyMMdd_HHmm') + N'.bak';
BACKUP DATABASE ComercioArtesDB
TO DISK = @archivo
WITH INIT, CHECKSUM, STATS = 10, NAME = N'NicaArt respaldo completo';
