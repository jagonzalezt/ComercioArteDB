-- Roles y permisos dentro de SQL Server (permisos minimos).
-- La aplicacion no debe entrar como administrador del servidor.
USE [ComercioArtesDB]
GO

-- Rol para la aplicacion: puede leer, agregar y modificar datos,
-- pero no puede modificar ni borrar la bitacora.
CREATE ROLE rol_nicaart_app;
GRANT SELECT, INSERT, UPDATE ON SCHEMA::dbo TO rol_nicaart_app;
DENY UPDATE, DELETE ON dbo.Bitacora TO rol_nicaart_app;
GO

-- Rol para reportes: solo lectura, sin ver PasswordHash ni Salt
CREATE ROLE rol_nicaart_reportes;
GRANT SELECT ON SCHEMA::dbo TO rol_nicaart_reportes;
DENY SELECT ON dbo.Usuarios (PasswordHash, Salt) TO rol_nicaart_reportes;
GO

-- Login y usuario de la aplicacion (poner una clave segura)
CREATE LOGIN nicaart_app WITH PASSWORD = 'PONER_UNA_CLAVE_SEGURA';
CREATE USER nicaart_app FOR LOGIN nicaart_app;
ALTER ROLE rol_nicaart_app ADD MEMBER nicaart_app;
GO

-- Nota: la aplicacion hoy se conecta con la autenticacion de Windows (ConexionBD.cs).
-- Si se quiere usar este login, hay que cambiar la cadena de conexion.
