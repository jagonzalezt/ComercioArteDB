-- Se ejecuta una sola vez.
-- La base estaba en modelo SIMPLE, que no permite respaldar el log.
USE master;
GO
ALTER DATABASE ComercioArtesDB SET RECOVERY FULL;
GO
