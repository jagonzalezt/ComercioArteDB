using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
        // Al ser MSSQLSERVER (instancia predeterminada), solo se usa (local) o localhost
        private string cadenaConexion = @"Server=(local);Initial Catalog=ComercioArtesDB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}