-- 1. Jobs creados y su horario
SELECT j.name AS Job, j.enabled AS Activo, s.name AS Horario
FROM msdb.dbo.sysjobs j
LEFT JOIN msdb.dbo.sysjobschedules js ON j.job_id = js.job_id
LEFT JOIN msdb.dbo.sysschedules s ON js.schedule_id = s.schedule_id
WHERE j.name LIKE N'NicaArt[_]%';

-- 2. Historial: cada vez que corrio un job y si salio bien
SELECT j.name AS Job, h.run_date AS Fecha, h.run_time AS Hora,
       CASE h.run_status WHEN 1 THEN 'Exitoso' WHEN 0 THEN 'Fallido'
                         WHEN 2 THEN 'Reintento' WHEN 3 THEN 'Cancelado' END AS Resultado,
       h.message AS Mensaje
FROM msdb.dbo.sysjobhistory h
INNER JOIN msdb.dbo.sysjobs j ON h.job_id = j.job_id
WHERE j.name LIKE N'NicaArt[_]%' AND h.step_id = 0
ORDER BY h.instance_id DESC;

-- 3. Respaldos hechos: D = completo, I = diferencial, L = log
SELECT TOP 10 database_name, type, backup_start_date, backup_finish_date,
       backup_size, compressed_backup_size
FROM msdb.dbo.backupset
WHERE database_name = 'ComercioArtesDB'
ORDER BY backup_start_date DESC;
