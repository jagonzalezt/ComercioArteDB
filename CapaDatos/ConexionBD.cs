using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
        // CORRECCIÓN: Asegurar que apunte a ComercioArtesDB y no al catálogo maestro
        private string cadenaConexion = @"Server=(local)\SQLEXPRESS;Initial Catalog=ComercioArtesDB;Integrated Security=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}