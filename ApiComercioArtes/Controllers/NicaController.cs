using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace ApiComercioArtes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NicaController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public NicaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: api/nica
        [HttpGet]
        public IActionResult GetDashboardCompleto()
        {
            string conexionString = _configuration.GetConnectionString("ConexionSQL");

            var metricas = new Dictionary<string, object>();
            var listaObras = new List<Dictionary<string, object>>();
            var listaPedidos = new List<Dictionary<string, object>>();

            try
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    con.Open();

                    // 1. Obtener métricas generales del sistema
                    string queryMetricas = @"
                        SELECT 
                            (SELECT COUNT(*) FROM Usuarios WHERE RolID = 2) AS TotalArtistas,
                            (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1) AS TotalObras,
                            (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1 AND Estado NOT IN ('Vendida', 'Agotado', 'Vendido')) AS Disponibles,
                            (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1 AND Estado IN ('Vendida', 'Agotado', 'Vendido')) AS Vendidas,
                            (SELECT ISNULL(SUM(Total), 0) FROM Pedidos) AS IngresosTotales";

                    using (SqlCommand cmd = new SqlCommand(queryMetricas, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    metricas[reader.GetName(i)] = reader.GetValue(i);
                                }
                            }
                        }
                    }

                    // 2. Obtener el catálogo de obras activas
                    string queryObras = @"
                        SELECT o.ObraID, o.Titulo, ISNULL(u.Nombre + ' ' + u.Apellido, 'Sin Asignar') AS Artista, 
                               o.Tecnica, o.Precio, o.Estado
                        FROM ObrasArte o
                        LEFT JOIN Artistas a ON o.ArtistaID = a.ArtistaID
                        LEFT JOIN Usuarios u ON a.ArtistaID = u.UsuarioID
                        WHERE o.Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(queryObras, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var fila = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    fila[reader.GetName(i)] = reader.GetValue(i) == DBNull.Value ? null : reader.GetValue(i);
                                }
                                listaObras.Add(fila);
                            }
                        }
                    }

                    // 3. Obtener las últimas transacciones / pedidos
                    string queryPedidos = @"
                        SELECT TOP 5 p.PedidoID, p.FechaPedido, 
                               ISNULL(u.Nombre + ' ' + u.Apellido, 'Cliente General') AS Comprador, p.Total
                        FROM Pedidos p
                        LEFT JOIN Compradores c ON p.CompradorID = c.CompradorID
                        LEFT JOIN Usuarios u ON c.CompradorID = u.UsuarioID OR p.CompradorID = u.UsuarioID
                        ORDER BY p.FechaPedido DESC";

                    using (SqlCommand cmd = new SqlCommand(queryPedidos, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var fila = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    fila[reader.GetName(i)] = reader.GetValue(i) == DBNull.Value ? null : reader.GetValue(i);
                                }
                                listaPedidos.Add(fila);
                            }
                        }
                    }
                }

                // Estructura final del JSON unificado
                var resultadoDashboard = new
                {
                    ResumenMetricas = metricas,
                    CatalogoObras = listaObras,
                    TransaccionesRecientes = listaPedidos
                };

                return Ok(resultadoDashboard);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}