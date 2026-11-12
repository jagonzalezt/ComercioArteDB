-- Crea los roles base y el usuario administrador de NicaArt.
-- Se puede ejecutar varias veces: no repite lo que ya existe.
USE [ComercioArtesDB]
GO

-- Roles: 1 = Administrador, 2 = Artista, 3 = Comprador
SET IDENTITY_INSERT dbo.Roles ON;

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RolID = 1 OR NombreRol = 'Administrador')
    INSERT INTO dbo.Roles (RolID, NombreRol, Descripcion) VALUES (1, 'Administrador', 'Controla todo el sistema');
IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RolID = 2 OR NombreRol = 'Artista')
    INSERT INTO dbo.Roles (RolID, NombreRol, Descripcion) VALUES (2, 'Artista', 'Publica y administra sus obras');
IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RolID = 3 OR NombreRol = 'Comprador')
    INSERT INTO dbo.Roles (RolID, NombreRol, Descripcion) VALUES (3, 'Comprador', 'Consulta obras y compra');

SET IDENTITY_INSERT dbo.Roles OFF;
GO

-- Usuario administrador (la contraseña se guarda con hash y sal)
-- Correo: admin@nicaart.com   Contraseña: Admin2026
-- IMPORTANTE: cambiar esta contraseña despues de la primera prueba.
IF NOT EXISTS (SELECT 1 FROM dbo.Usuarios WHERE Email = 'admin@nicaart.com')
BEGIN
    DECLARE @sal UNIQUEIDENTIFIER = NEWID();

    INSERT INTO dbo.Usuarios (RolID, Nombre, Apellido, Email, PasswordHash, Salt, Telefono, Activo)
    VALUES (1, 'Administrador', 'NicaArt', 'admin@nicaart.com',
            HASHBYTES('SHA2_512', N'Admin2026' + CONVERT(NVARCHAR(36), @sal)),
            @sal, NULL, 1);
END
GO
