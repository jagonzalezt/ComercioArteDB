using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Obras
    {
        // Instanciamos tu clase de conexión existente
        private ConexionBD conexion = new ConexionBD();

        /// <summary>
        /// Consulta SQL que une la tabla ObrasArte con Usuarios para traer el nombre del artista ejecutor
        /// </summary>
        public DataTable ListarObras()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    // Ajustamos el query con los campos reales de tu diseño (Título, Técnica, Año, Dimensiones, Precio, Estado)
                    string query = @"SELECT O.ObraID, O.ArtistaID, O.Titulo, O.Descripcion, 
                                            O.Precio, O.Stock, O.ImagenURL, O.Tecnica, O.Anio, O.Dimensiones, O.Estado,
                                            (U.Nombre + ' ' + U.Apellido) AS NombreArtista
                                     FROM ObrasArte O
                                     INNER JOIN Artistas A ON O.ArtistaID = A.ArtistaID
                                     INNER JOIN Usuarios U ON A.ArtistaID = U.UsuarioID
                                     WHERE O.Activo = 1";

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
            catch (Exception ex)
            {
                throw new Exception("Error en CD_Obras -> ListarObras: " + ex.Message);
            }
            return tabla;
        }

        public bool InsertarObra(int artistaID, string titulo, string descripcion, decimal precio, int stock, string imagenURL, string tecnica, string anio, string dimensiones, string estado)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = @"INSERT INTO ObrasArte (ArtistaID, Titulo, Descripcion, Precio, Stock, ImagenURL, Tecnica, Anio, Dimensiones, Estado, Activo) 
                                     VALUES (@artistaID, @titulo, @descripcion, @precio, @stock, @imagenURL, @tecnica, @anio, @dimensiones, @estado, 1)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@artistaID", artistaID);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@imagenURL", (object)imagenURL ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@tecnica", (object)tecnica ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@anio", (object)anio ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@dimensiones", (object)dimensiones ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", estado ?? "Disponible");

                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al insertar obra en SQL: " + ex.Message); }
        }

        public bool EditarObra(int obraID, int artistaID, string titulo, string descripcion, decimal precio, int stock, string imagenURL, string tecnica, string anio, string dimensiones, string estado)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    string query = @"UPDATE ObrasArte 
                                     SET ArtistaID=@artistaID, Titulo=@titulo, Descripcion=@descripcion, 
                                         Precio=@precio, Stock=@stock, ImagenURL=@imagenURL,
                                         Tecnica=@tecnica, Anio=@anio, Dimensiones=@dimensiones, Estado=@estado
                                     WHERE ObraID=@obraID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@obraID", obraID);
                        cmd.Parameters.AddWithValue("@artistaID", artistaID);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descripcion", (object)descripcion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@imagenURL", (object)imagenURL ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@tecnica", (object)tecnica ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@anio", (object)anio ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@dimensiones", (object)dimensiones ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", estado);

                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al editar obra en SQL: " + ex.Message); }
        }

        public bool EliminarObra(int obraID)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    // Hacemos una baja lógica cambiando el estado Activo a 0
                    string query = "UPDATE ObrasArte SET Activo = 0 WHERE ObraID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", obraID);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al eliminar obra de SQL: " + ex.Message); }
        }
    }
}