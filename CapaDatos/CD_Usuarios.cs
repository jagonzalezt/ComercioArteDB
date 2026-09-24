using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private ConexionBD conexion = new ConexionBD();

        // Método para registrar usuarios
        public bool RegistrarUsuario(int rolID, string nombre, string apellido, string email, string password, string telefono)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO Usuarios (RolID, Nombre, Apellido, Email, PasswordHash, Telefono, Activo) 
                                     VALUES (@rolID, @nombre, @apellido, @email, 
                                             HASHBYTES('SHA2_512', @password), 
                                             @telefono, 1)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@rolID", rolID);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CD_Usuarios (Registrar): " + ex.Message);
            }
        }

        // Método para validar inicio de sesión
        public DataTable ValidarLogin(string email, string password)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = @"SELECT UsuarioID, RolID, Nombre, Apellido, Email 
                                     FROM Usuarios 
                                     WHERE Email = @email 
                                       AND PasswordHash = HASHBYTES('SHA2_512', @password)
                                       AND Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            con.Open();
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CD_Usuarios (Login): " + ex.Message);
            }
            return tabla;
        }
    }
}