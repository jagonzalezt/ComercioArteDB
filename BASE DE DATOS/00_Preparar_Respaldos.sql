-- Se ejecuta una sola vez, antes de crear los jobs.
USE master;
GO

-- Carpetas donde se guardan los respaldos
-- (si da error, crear a mano C:\Respaldos y C:\Respaldos\prueba)
EXEC master.sys.xp_create_subdir N'C:\Respaldos';
EXEC master.sys.xp_create_subdir N'C:\Respaldos\prueba';
GO

-- La base estaba en modelo SIMPLE, que no permite respaldar el log.
ALTER DATABASE ComercioArtesDB SET RECOVERY FULL;
GO
