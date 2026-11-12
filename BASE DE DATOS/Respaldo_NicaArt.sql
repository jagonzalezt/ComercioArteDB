
---1- Domingo (Completo)
BACKUP DATABASE ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH FORMAT,
NAME = 'COMPLETO',
DESCRIPTION = 'RESPALDO COMPLETO',
COMPRESSION

/*INSERT DEL DIA LUNES*/
INSERT INTO ComercioArtesDB.dbo.Categorias (NombreCategoria, Descripcion)
VALUES ('Prueba respaldo DD1', 'LUNES')

---2- Lunes (Log/Transaccional) busca domingo y lunes
BACKUP LOG ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH NAME = 'RESPALDO LOG',
DESCRIPTION = 'LUNES LOG',
COMPRESSION

/*INSERT DEL DIA MARTES*/
INSERT INTO ComercioArtesDB.dbo.Categorias (NombreCategoria, Descripcion)
VALUES ('Prueba respaldo DD2', 'MARTES')

---3- Martes (Log/Transaccional) busca domingo, lunes y martes
BACKUP LOG ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH NAME = 'RESPALDO LOG',
DESCRIPTION = 'MARTES LOG',
COMPRESSION

/*INSERT DEL DIA MIERCOLES*/
INSERT INTO ComercioArtesDB.dbo.Categorias (NombreCategoria, Descripcion)
VALUES ('Prueba respaldo DD3', 'MIERCOLES')

---4- Miercoles (Diferencial) busca domingo y miercoles
BACKUP DATABASE ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH NAME = 'RESPALDO DIFF',
DESCRIPTION = 'MIERCOLES DIFF',
COMPRESSION,
DIFFERENTIAL

/*INSERT DEL DIA JUEVES*/
INSERT INTO ComercioArtesDB.dbo.Categorias (NombreCategoria, Descripcion)
VALUES ('Prueba respaldo DD4', 'JUEVES')

---5- Jueves (Log/Transaccional) busca en anterior y el dia actual
BACKUP LOG ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH NAME = 'RESPALDO LOG',
DESCRIPTION = 'JUEVES LOG',
COMPRESSION

/*INSERT DEL DIA VIERNES*/
INSERT INTO ComercioArtesDB.dbo.Categorias (NombreCategoria, Descripcion)
VALUES ('Prueba respaldo DD5', 'VIERNES')

---6- Viernes (Log/Transaccional) busca el anterior y el dia actual
BACKUP LOG ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH NAME = 'RESPALDO LOG',
DESCRIPTION = 'VIERNES LOG',
COMPRESSION

/*INSERT DEL DIA SABADO*/
INSERT INTO ComercioArtesDB.dbo.Categorias (NombreCategoria, Descripcion)
VALUES ('Prueba respaldo DD6', 'SABADO')

---7- Sabado (Diferencial) salta hasta el sabado desde el completo
BACKUP DATABASE ComercioArtesDB
TO DISK = 'C:\Respaldo\NicaArt_backup.bak'
WITH NAME = 'RESPALDO DIFF',
DESCRIPTION = 'SABADO DIFF',
COMPRESSION,
DIFFERENTIAL

/*CONFIRMAR LOS RESPALDOS*/
-- Debe mostrar 7 respaldos: 1 completo, 2 log, 3 log, 4 diferencial, 5 log, 6 log, 7 diferencial
RESTORE HEADERONLY
FROM DISK = 'C:\Respaldo\NicaArt_backup.bak'

/*DATOS DE PRUEBA QUE QUEDARON EN LA BASE (deben ser 6)*/
SELECT NombreCategoria, Descripcion
FROM ComercioArtesDB.dbo.Categorias
WHERE NombreCategoria LIKE 'Prueba respaldo%'

/* Cuando termine la prueba, se pueden borrar los datos de prueba:
DELETE FROM ComercioArtesDB.dbo.Categorias WHERE NombreCategoria LIKE 'Prueba respaldo%'
*/
