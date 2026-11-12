using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Compradores
    {
        private ConexionBD conexionBD = new ConexionBD();

        public DataTable ListarCompradores()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT c.CompradorID, u.Nombre, u.Email AS Correo, c.Telefono, c.Direccion, c.MetodoPago 
                                 FROM Compradores c 
                                 INNER JOIN Usuarios u ON c.UsuarioID = u.UsuarioID 
                                 WHERE c.Activo = 1";

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            tabla.Load(leer);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en CapaDatos al listar: " + ex.Message);
                    }
                }
            }
            return tabla;
        }

        public bool InsertarComprador(string nombre, string correo, string telefono, string direccion, string metodoPago)
        {
            bool exito = false;

            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlTransaction transaccion = con.BeginTransaction())
                    {
                        try
                        {
                            // Se usa '0x' directamente para insertar un valor binario vacío en PasswordHash
                            string queryUsuario = @"INSERT INTO Usuarios (Nombre, Apellido, Email, PasswordHash, RolID, Activo) 
                                                    VALUES (@nombre, @apellido, @correo, 0x, 3, 1); 
                                                    SELECT SCOPE_IDENTITY();";

                            int nuevoUsuarioID = 0;
                            using (SqlCommand cmdUsuario = new SqlCommand(queryUsuario, con, transaccion))
                            {
                                cmdUsuario.Parameters.AddWithValue("@nombre", nombre);
                                cmdUsuario.Parameters.AddWithValue("@apellido", "");
                                cmdUsuario.Parameters.AddWithValue("@correo", correo);
                                nuevoUsuarioID = Convert.ToInt32(cmdUsuario.ExecuteScalar());
                            }

                            string queryComprador = @"INSERT INTO Compradores (UsuarioID, Telefono, Direccion, MetodoPago, Activo) 
                                                      VALUES (@usuarioID, @telefono, @direccion, @metodoPago, 1)";

                            using (SqlCommand cmdComprador = new SqlCommand(queryComprador, con, transaccion))
                            {
                                cmdComprador.Parameters.AddWithValue("@usuarioID", nuevoUsuarioID);
                                cmdComprador.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);
                                cmdComprador.Parameters.AddWithValue("@direccion", (object)direccion ?? DBNull.Value);
                                cmdComprador.Parameters.AddWithValue("@metodoPago", metodoPago);

                                exito = cmdComprador.ExecuteNonQuery() > 0;
                            }

                            transaccion.Commit();
                        }
                        catch (Exception)
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error transaccional en CapaDatos al insertar: " + ex.Message);
                }
            }
            return exito;
        }

        public bool EditarComprador(int compradorID, string nombre, string correo, string telefono, string direccion, string metodoPago)
        {
            bool exito = false;

            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlTransaction transaccion = con.BeginTransaction())
                    {
                        try
                        {
                            string queryId = "SELECT UsuarioID FROM Compradores WHERE CompradorID = @compradorID";
                            int usuarioID = 0;

                            using (SqlCommand cmdId = new SqlCommand(queryId, con, transaccion))
                            {
                                cmdId.Parameters.AddWithValue("@compradorID", compradorID);
                                object result = cmdId.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    usuarioID = Convert.ToInt32(result);
                                }
                            }

                            if (usuarioID > 0)
                            {
                                // Mantenemos la actualización íntegra usando 0x para el campo varbinary
                                string queryUsuario = "UPDATE Usuarios SET Nombre = @nombre, Apellido = @apellido, Email = @correo, PasswordHash = 0x WHERE UsuarioID = @usuarioID";
                                using (SqlCommand cmdUsuario = new SqlCommand(queryUsuario, con, transaccion))
                                {
                                    cmdUsuario.Parameters.AddWithValue("@nombre", nombre);
                                    cmdUsuario.Parameters.AddWithValue("@apellido", "");
                                    cmdUsuario.Parameters.AddWithValue("@correo", correo);
                                    cmdUsuario.Parameters.AddWithValue("@usuarioID", usuarioID);
                                    cmdUsuario.ExecuteNonQuery();
                                }
                            }

                            string queryComprador = @"UPDATE Compradores 
                                                      SET Telefono = @telefono, Direccion = @direccion, MetodoPago = @metodoPago 
                                                      WHERE CompradorID = @id";

                            using (SqlCommand cmdComprador = new SqlCommand(queryComprador, con, transaccion))
                            {
                                cmdComprador.Parameters.AddWithValue("@id", compradorID);
                                cmdComprador.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);
                                cmdComprador.Parameters.AddWithValue("@direccion", (object)direccion ?? DBNull.Value);
                                cmdComprador.Parameters.AddWithValue("@metodoPago", metodoPago);

                                exito = cmdComprador.ExecuteNonQuery() > 0;
                            }

                            transaccion.Commit();
                        }
                        catch (Exception)
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CapaDatos al editar de forma relacional: " + ex.Message);
                }
            }
            return exito;
        }

        public bool EliminarComprador(int compradorID)
        {
            bool exito = false;

            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = "UPDATE Compradores SET Activo = 0 WHERE CompradorID = @id";

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@id", compradorID);

                    try
                    {
                        con.Open();
                        exito = comando.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en CapaDatos al eliminar: " + ex.Message);
                    }
                }
            }
            return exito;
        }
    }
}