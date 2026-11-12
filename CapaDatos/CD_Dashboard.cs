using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Dashboard
    {
        private ConexionBD conexionBD = new ConexionBD();

        // Obtiene los totales de las tarjetas (Cards) usando la columna 'Estado' y 'Activo'
        public DataTable ObtenerMetricasContadores()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT 
                    (SELECT COUNT(*) FROM Usuarios WHERE RolID = 2) AS TotalArtistas,
                    (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1) AS TotalObras,
                    (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1 AND Estado NOT IN ('Vendida', 'Agotado', 'Vendido')) AS Disponibles,
                    (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1 AND Estado IN ('Vendida', 'Agotado', 'Vendido')) AS Vendidas,
                    (SELECT ISNULL(SUM(Total), 0) FROM Pedidos) AS IngresosTotales";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader leer = cmd.ExecuteReader()) { tabla.Load(leer); }
                    }
                    catch (Exception ex) { throw new Exception("Error en contadores: " + ex.Message); }
                }
            }
            return tabla;
        }

        // Obtiene las obras con los nombres de sus artistas reales usando 'Tecnica' y 'Estado'
        public DataTable ListarObrasDashboard()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT o.ObraID, o.Titulo, (u.Nombre + ' ' + u.Apellido) AS Artista, 
                                       o.Tecnica, o.Precio, o.Estado
                                FROM ObrasArte o
                                INNER JOIN Artistas a ON o.ArtistaID = a.ArtistaID
                                INNER JOIN Usuarios u ON a.ArtistaID = u.UsuarioID
                                WHERE o.Activo = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader leer = cmd.ExecuteReader()) { tabla.Load(leer); }
                    }
                    catch (Exception ex) { throw new Exception("Error en lista obras: " + ex.Message); }
                }
            }
            return tabla;
        }
    }
}