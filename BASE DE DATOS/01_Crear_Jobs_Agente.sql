-- Crea los tres jobs de respaldo en el Agente SQL Server.
-- Se puede ejecutar varias veces: borra los jobs viejos y los crea de nuevo.
-- Antes hay que ejecutar 00_Preparar_Respaldos.sql y tener el Agente SQL Server encendido.
USE msdb;
GO

IF (SELECT recovery_model_desc FROM sys.databases WHERE name = N'ComercioArtesDB') <> N'FULL'
    PRINT N'AVISO: ejecuta primero 00_Preparar_Respaldos.sql (la base debe estar en modelo FULL).';

DECLARE @cmd NVARCHAR(MAX);

-- ------------------------------------------------------------
-- JOB 1: respaldo completo, domingo 11:00 pm
-- ------------------------------------------------------------
IF EXISTS (SELECT 1 FROM dbo.sysjobs WHERE name = N'NicaArt_Full')
    EXEC dbo.sp_delete_job @job_name = N'NicaArt_Full';

EXEC dbo.sp_add_job @job_name = N'NicaArt_Full', @enabled = 1,
     @description = N'Respaldo completo de ComercioArtesDB';

SET @cmd = N'DECLARE @archivo NVARCHAR(260) = N''C:\Respaldos\ComercioArtesDB_FULL_'' + FORMAT(GETDATE(), ''yyyyMMdd_HHmm'') + N''.bak'';
BACKUP DATABASE ComercioArtesDB TO DISK = @archivo
WITH COMPRESSION, INIT, CHECKSUM, STATS = 10, NAME = N''NicaArt respaldo completo'';';

EXEC dbo.sp_add_jobstep @job_name = N'NicaArt_Full', @step_name = N'Respaldo completo',
     @subsystem = N'TSQL', @database_name = N'master', @command = @cmd;

-- freq_type 8 = semanal, freq_interval 1 = domingo, 230000 = 11:00 pm
EXEC dbo.sp_add_jobschedule @job_name = N'NicaArt_Full', @name = N'Domingo 11:00 pm',
     @freq_type = 8, @freq_interval = 1, @freq_recurrence_factor = 1, @active_start_time = 230000;

EXEC dbo.sp_add_jobserver @job_name = N'NicaArt_Full', @server_name = N'(local)';

-- ------------------------------------------------------------
-- JOB 2: respaldo diferencial, lunes a sabado 11:00 pm
-- ------------------------------------------------------------
IF EXISTS (SELECT 1 FROM dbo.sysjobs WHERE name = N'NicaArt_Diferencial')
    EXEC dbo.sp_delete_job @job_name = N'NicaArt_Diferencial';

EXEC dbo.sp_add_job @job_name = N'NicaArt_Diferencial', @enabled = 1,
     @description = N'Respaldo diferencial de ComercioArtesDB';

SET @cmd = N'DECLARE @archivo NVARCHAR(260) = N''C:\Respaldos\ComercioArtesDB_DIF_'' + FORMAT(GETDATE(), ''yyyyMMdd_HHmm'') + N''.bak'';
BACKUP DATABASE ComercioArtesDB TO DISK = @archivo
WITH DIFFERENTIAL, COMPRESSION, INIT, CHECKSUM, STATS = 10, NAME = N''NicaArt respaldo diferencial'';';

EXEC dbo.sp_add_jobstep @job_name = N'NicaArt_Diferencial', @step_name = N'Respaldo diferencial',
     @subsystem = N'TSQL', @database_name = N'master', @command = @cmd;

-- freq_interval 126 = lunes(2) + martes(4) + miercoles(8) + jueves(16) + viernes(32) + sabado(64)
EXEC dbo.sp_add_jobschedule @job_name = N'NicaArt_Diferencial', @name = N'Lunes a sabado 11:00 pm',
     @freq_type = 8, @freq_interval = 126, @freq_recurrence_factor = 1, @active_start_time = 230000;

EXEC dbo.sp_add_jobserver @job_name = N'NicaArt_Diferencial', @server_name = N'(local)';

-- ------------------------------------------------------------
-- JOB 3: respaldo del log, cada 2 horas
-- ------------------------------------------------------------
IF EXISTS (SELECT 1 FROM dbo.sysjobs WHERE name = N'NicaArt_Log')
    EXEC dbo.sp_delete_job @job_name = N'NicaArt_Log';

EXEC dbo.sp_add_job @job_name = N'NicaArt_Log', @enabled = 1,
     @description = N'Respaldo del log de transacciones de ComercioArtesDB';

SET @cmd = N'DECLARE @archivo NVARCHAR(260) = N''C:\Respaldos\ComercioArtesDB_LOG_'' + FORMAT(GETDATE(), ''yyyyMMdd_HHmm'') + N''.trn'';
BACKUP LOG ComercioArtesDB TO DISK = @archivo
WITH COMPRESSION, INIT, CHECKSUM, NAME = N''NicaArt respaldo de log'';';

EXEC dbo.sp_add_jobstep @job_name = N'NicaArt_Log', @step_name = N'Respaldo del log',
     @subsystem = N'TSQL', @database_name = N'master', @command = @cmd;

-- freq_type 4 = diario, freq_subday_type 8 = horas, cada 2 horas
EXEC dbo.sp_add_jobschedule @job_name = N'NicaArt_Log', @name = N'Cada 2 horas',
     @freq_type = 4, @freq_interval = 1, @freq_subday_type = 8, @freq_subday_interval = 2,
     @active_start_time = 0;

EXEC dbo.sp_add_jobserver @job_name = N'NicaArt_Log', @server_name = N'(local)';

-- ------------------------------------------------------------
-- Primer respaldo completo ahora mismo (el log necesita uno antes)
-- ------------------------------------------------------------
EXEC dbo.sp_start_job @job_name = N'NicaArt_Full';
GO
