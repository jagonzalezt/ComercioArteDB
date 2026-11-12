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
                    // Cada usuario tiene su propia sal (un GUID distinto).
                    // La contraseña se guarda como hash de: contraseña + sal.
                    string query = @"INSERT INTO Usuarios (RolID, Nombre, Apellido, Email, PasswordHash, Salt, Telefono, Activo) 
                                     VALUES (@rolID, @nombre, @apellido, @email, 
                                             HASHBYTES('SHA2_512', @password + CONVERT(NVARCHAR(36), @salt)), 
                                             @salt, @telefono, 1)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@salt", Guid.NewGuid());
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
                    con.Open();

                    // 1. Se compara el hash de: contraseña + sal del usuario
                    string query = @"SELECT UsuarioID, RolID, Nombre, Apellido, Email 
                                     FROM Usuarios 
                                     WHERE Email = @email 
                                       AND Salt IS NOT NULL
                                       AND PasswordHash = HASHBYTES('SHA2_512', @password + CONVERT(NVARCHAR(36), Salt))
                                       AND Activo = 1";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }

                    // 2. Los usuarios que se registraron antes guardaron la contraseña sin sal.
                    //    Si entran bien con la forma vieja, se actualiza su contraseña a la forma nueva.
                    if (tabla.Rows.Count == 0)
                    {
                        string queryViejo = @"SELECT UsuarioID, RolID, Nombre, Apellido, Email 
                                              FROM Usuarios 
                                              WHERE Email = @email 
                                                AND PasswordHash = HASHBYTES('SHA2_512', @password)
                                                AND Activo = 1";

                        using (SqlCommand cmd = new SqlCommand(queryViejo, con))
                        {
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(tabla);
                            }
                        }

                        if (tabla.Rows.Count > 0)
                        {
                            string queryActualizar = @"UPDATE Usuarios 
                                                       SET Salt = @salt,
                                                           PasswordHash = HASHBYTES('SHA2_512', @password + CONVERT(NVARCHAR(36), @salt))
                                                       WHERE UsuarioID = @id";

                            using (SqlCommand cmd = new SqlCommand(queryActualizar, con))
                            {
                                cmd.Parameters.AddWithValue("@salt", Guid.NewGuid());
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tabla.Rows[0]["UsuarioID"]));
                                cmd.ExecuteNonQuery();
                            }
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