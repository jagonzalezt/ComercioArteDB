USE [ComercioArtesDB]
GO

-- ============================================================================
-- 1. CREACIÓN DE LA TABLA DE BITÁCORA DE AUDITORÍA
-- ============================================================================
IF OBJECT_ID('dbo.Bitacora', 'U') IS NOT NULL
    DROP TABLE dbo.Bitacora;
GO

CREATE TABLE dbo.Bitacora (
    BitacoraID INT IDENTITY(1,1) PRIMARY KEY,
    TablaAfectada VARCHAR(100) NOT NULL,
    Accion VARCHAR(20) NOT NULL,               -- INSERT, UPDATE, DELETE
    UsuarioSQL VARCHAR(100) NOT NULL DEFAULT SUSER_SNAME(),
    HostName VARCHAR(100) NOT NULL DEFAULT HOST_NAME(),
    FechaRegistro DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    LlavePrimaria VARCHAR(100) NULL,           -- ID del registro afectado
    DetalleCambio NVARCHAR(MAX) NULL            -- Resumen de datos agregados/modificados/eliminados
);
GO

-- ============================================================================
-- 2. TRIGGERS DE AUDITORÍA (BITÁCORA)
-- ============================================================================

-------------------------------------------------------------------------------
-- Trigger Bitácora: TABLA USUARIOS
-------------------------------------------------------------------------------
CREATE OR ALTER TRIGGER dbo.TR_Usuarios_Bitacora
ON dbo.Usuarios
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- REGISTRO DE INSERT
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'Usuarios', 
            'INSERT', 
            CAST(i.UsuarioID AS VARCHAR),
            CONCAT('Nombre: ', i.Nombre, ' ', i.Apellido, ' | Email: ', i.Email, ' | RolID: ', i.RolID)
        FROM inserted i;
    END

    -- REGISTRO DE UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'Usuarios', 
            'UPDATE', 
            CAST(i.UsuarioID AS VARCHAR),
            CONCAT('Anterior: ', d.Nombre, ' ', d.Apellido, ' (', d.Email, ') -> Nuevo: ', i.Nombre, ' ', i.Apellido, ' (', i.Email, ')')
        FROM inserted i
        INNER JOIN deleted d ON i.UsuarioID = d.UsuarioID;
    END

    -- REGISTRO DE DELETE
    IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'Usuarios', 
            'DELETE', 
            CAST(d.UsuarioID AS VARCHAR),
            CONCAT('Eliminado: ', d.Nombre, ' ', d.Apellido, ' | Email: ', d.Email)
        FROM deleted d;
    END
END;
GO

-------------------------------------------------------------------------------
-- Trigger Bitácora: TABLA OBRAS DE ARTE
-------------------------------------------------------------------------------
CREATE OR ALTER TRIGGER dbo.TR_ObrasArte_Bitacora
ON dbo.ObrasArte
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- INSERT
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'ObrasArte', 
            'INSERT', 
            CAST(i.ObraID AS VARCHAR),
            CONCAT('Título: ', i.Titulo, ' | Precio: ', i.Precio, ' | Stock: ', i.Stock)
        FROM inserted i;
    END

    -- UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'ObrasArte', 
            'UPDATE', 
            CAST(i.ObraID AS VARCHAR),
            CONCAT('Precio ant: ', d.Precio, ' -> nuev: ', i.Precio, ' | Stock ant: ', d.Stock, ' -> nuev: ', i.Stock)
        FROM inserted i
        INNER JOIN deleted d ON i.ObraID = d.ObraID;
    END

    -- DELETE
    IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'ObrasArte', 
            'DELETE', 
            CAST(d.ObraID AS VARCHAR),
            CONCAT('Obra eliminada: ', d.Titulo)
        FROM deleted d;
    END
END;
GO

-------------------------------------------------------------------------------
-- Trigger Bitácora: TABLA PEDIDOS
-------------------------------------------------------------------------------
CREATE OR ALTER TRIGGER dbo.TR_Pedidos_Bitacora
ON dbo.Pedidos
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- INSERT
    IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'Pedidos', 
            'INSERT', 
            CAST(i.PedidoID AS VARCHAR),
            CONCAT('CompradorID: ', i.CompradorID, ' | Total: ', i.Total, ' | EstadoID: ', i.EstadoPedidoID)
        FROM inserted i;
    END

    -- UPDATE
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'Pedidos', 
            'UPDATE', 
            CAST(i.PedidoID AS VARCHAR),
            CONCAT('Estado anterior: ', d.EstadoPedidoID, ' -> Nuevo estado: ', i.EstadoPedidoID, ' | Total: ', i.Total)
        FROM inserted i
        INNER JOIN deleted d ON i.PedidoID = d.PedidoID;
    END

    -- DELETE
    IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO dbo.Bitacora (TablaAfectada, Accion, LlavePrimaria, DetalleCambio)
        SELECT 
            'Pedidos', 
            'DELETE', 
            CAST(d.PedidoID AS VARCHAR),
            CONCAT('Pedido eliminado ID: ', d.PedidoID)
        FROM deleted d;
    END
END;
GO

-- ============================================================================
-- 3. TRIGGER DE LÓGICA DE NEGOCIO: ACTUALIZAR STOCK AL VENDER
-- ============================================================================
CREATE OR ALTER TRIGGER dbo.TR_DetallesPedido_DescontarStock
ON dbo.DetallesPedido
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Descontar el stock según las obras compradas
    UPDATE o
    SET o.Stock = o.Stock - i.Cantidad
    FROM dbo.ObrasArte o
    INNER JOIN inserted i ON o.ObraID = i.ObraID;

    -- Si el stock llega a 0, actualizamos el campo Disponible a 0
    UPDATE o
    SET o.Disponible = 0,
        o.Estado = 'Agotado'
    FROM dbo.ObrasArte o
    INNER JOIN inserted i ON o.ObraID = i.ObraID
    WHERE o.Stock <= 0;
END;
GO