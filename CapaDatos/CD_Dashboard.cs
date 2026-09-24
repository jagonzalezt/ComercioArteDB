using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Dashboard
    {
        private ConexionBD conexionBD = new ConexionBD();

        // Obtiene los totales de las tarjetas (Cards)
        public DataTable ObtenerMetricasContadores()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT 
                    (SELECT COUNT(*) FROM Usuarios WHERE RolID = 2) AS TotalArtistas,
                    (SELECT COUNT(*) FROM ObrasArte) AS TotalObras,
                    (SELECT COUNT(*) FROM ObrasArte WHERE Disponible = 1) AS Disponibles,
                    (SELECT COUNT(*) FROM ObrasArte WHERE Disponible = 0) AS Vendidas,
                    (SELECT ISNULL(SUM(Total), 0) FROM Pedidos WHERE EstadoPedidoID <> 4) AS IngresosTotales";

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

        // Obtiene las obras con los nombres de sus artistas reales
        public DataTable ListarObrasDashboard()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT o.ObraID, o.Titulo, u.Nombre + ' ' + u.Apellido AS Artista, 
                                       c.NombreCategoria AS Tecnica, o.Precio, 
                                       CASE WHEN o.Disponible = 1 THEN 'Disponible' ELSE 'Vendido' END AS Estado
                                FROM ObrasArte o
                                INNER JOIN Usuarios u ON o.ArtistaID = u.UsuarioID
                                INNER JOIN Categorias c ON o.CategoriaID = c.CategoriaID";

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