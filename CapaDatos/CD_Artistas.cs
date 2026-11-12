using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Artistas
    {
        private ConexionBD conexion = new ConexionBD();

        public DataTable ListarArtistas()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = @"SELECT U.UsuarioID, U.Nombre, U.Apellido, U.Email, U.Telefono, 
                                            A.Seudonimo, A.Biografia, A.SitioWeb 
                                     FROM Usuarios U
                                     INNER JOIN Artistas A ON U.UsuarioID = A.ArtistaID
                                     WHERE U.Activo = 1";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            con.Open();
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al listar: " + ex.Message); }
            return tabla;
        }

        // NUEVO: Insertar Artista (Primero crea el Usuario, luego obtiene su ID y crea el Perfil de Artista)
        public bool InsertarArtista(string nombre, string apellido, string email, string password, string telefono, string seudonimo, string biografia, string sitioWeb)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    // Usamos una transacción para asegurarnos de que se guarden ambas tablas o ninguna
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            string queryUsuario = @"INSERT INTO Usuarios (RolID, Nombre, Apellido, Email, PasswordHash, Telefono, Activo) 
                                                     VALUES (2, @nombre, @apellido, @email, HASHBYTES('SHA2_512', @password), @telefono, 1);
                                                     SELECT SCOPE_IDENTITY();"; // Nos da el ID recién creado

                            int nuevoUsuarioID = 0;
                            using (SqlCommand cmdU = new SqlCommand(queryUsuario, con, trans))
                            {
                                cmdU.Parameters.AddWithValue("@nombre", nombre);
                                cmdU.Parameters.AddWithValue("@apellido", apellido);
                                cmdU.Parameters.AddWithValue("@email", email);
                                cmdU.Parameters.AddWithValue("@password", password);
                                cmdU.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);
                                nuevoUsuarioID = Convert.ToInt32(cmdU.ExecuteScalar());
                            }

                            string queryArtista = @"INSERT INTO Artistas (ArtistaID, Seudonimo, Biografia, SitioWeb) 
                                                     VALUES (@artistaID, @seudonimo, @biografia, @sitioWeb);";

                            using (SqlCommand cmdA = new SqlCommand(queryArtista, con, trans))
                            {
                                cmdA.Parameters.AddWithValue("@artistaID", nuevoUsuarioID);
                                cmdA.Parameters.AddWithValue("@seudonimo", (object)seudonimo ?? DBNull.Value);
                                cmdA.Parameters.AddWithValue("@biografia", (object)biografia ?? DBNull.Value);
                                cmdA.Parameters.AddWithValue("@sitioWeb", (object)sitioWeb ?? DBNull.Value);
                                cmdA.ExecuteNonQuery();
                            }

                            trans.Commit();
                            return true;
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al insertar artista: " + ex.Message); }
        }

        // NUEVO: Editar Artista
        public bool EditarArtista(int artistaID, string nombre, string apellido, string email, string telefono, string seudonimo, string biografia, string sitioWeb)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            string queryUsuario = @"UPDATE Usuarios SET Nombre=@nombre, Apellido=@apellido, Email=@email, Telefono=@telefono 
                                                     WHERE UsuarioID=@id";
                            using (SqlCommand cmdU = new SqlCommand(queryUsuario, con, trans))
                            {
                                cmdU.Parameters.AddWithValue("@nombre", nombre);
                                cmdU.Parameters.AddWithValue("@apellido", apellido);
                                cmdU.Parameters.AddWithValue("@email", email);
                                cmdU.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);
                                cmdU.Parameters.AddWithValue("@id", artistaID);
                                cmdU.ExecuteNonQuery();
                            }

                            string queryArtista = @"UPDATE Artistas SET Seudonimo=@seudonimo, Biografia=@biografia, SitioWeb=@sitioWeb 
                                                     WHERE ArtistaID=@id";
                            using (SqlCommand cmdA = new SqlCommand(queryArtista, con, trans))
                            {
                                cmdA.Parameters.AddWithValue("@seudonimo", (object)seudonimo ?? DBNull.Value);
                                cmdA.Parameters.AddWithValue("@biografia", (object)biografia ?? DBNull.Value);
                                cmdA.Parameters.AddWithValue("@sitioWeb", (object)sitioWeb ?? DBNull.Value);
                                cmdA.Parameters.AddWithValue("@id", artistaID);
                                cmdA.ExecuteNonQuery();
                            }

                            trans.Commit();
                            return true;
                        }
                        catch { trans.Rollback(); throw; }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al editar artista: " + ex.Message); }
        }

        // NUEVO: Eliminar Artista (Lógico: Cambia Activo a 0)
        public bool EliminarArtista(int artistaID)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = "UPDATE Usuarios SET Activo = 0 WHERE UsuarioID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", artistaID);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al eliminar artista: " + ex.Message); }
        }

        // NUEVO: Verificar si tiene obras asociadas en SQL
        public bool TieneObras(int artistaID)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = "SELECT COUNT(*) FROM ObrasArte WHERE ArtistaID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", artistaID);
                        con.Open();
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch { return false; }
        }
    }
}