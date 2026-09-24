using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Transacciones
    {
        private ConexionBD conexionBD = new ConexionBD();

        // 1. LISTAR TRANSACCIONES
        public DataTable ListarTransacciones()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT p.PedidoID, u.Nombre + ' ' + u.Apellido AS Comprador, p.FechaPedido, 
                                       p.Total, ep.DescripcionEstado AS Estado, p.DireccionEnvio
                                FROM Pedidos p
                                INNER JOIN Usuarios u ON p.CompradorID = u.UsuarioID
                                INNER JOIN EstadosPedido ep ON p.EstadoPedidoID = ep.EstadoPedidoID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            tabla.Load(leer);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en CapaDatos al listar transacciones: " + ex.Message);
                    }
                }
            }
            return tabla;
        }

        // 2. REGISTRAR TRANSACCIÓN (Maestro y Detalle)
        public bool RegistrarTransaccion(int compradorID, decimal total, int estadoPedidoID, string direccionEnvio, DataTable detalles)
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
                            string queryPedido = @"INSERT INTO Pedidos (CompradorID, Total, EstadoPedidoID, DireccionEnvio) 
                                                   VALUES (@compradorID, @total, @estadoPedidoID, @direccionEnvio);
                                                   SELECT SCOPE_IDENTITY();";

                            int nuevoPedidoID = 0;
                            using (SqlCommand cmdPedido = new SqlCommand(queryPedido, con, transaccion))
                            {
                                cmdPedido.Parameters.AddWithValue("@compradorID", compradorID);
                                cmdPedido.Parameters.AddWithValue("@total", total);
                                cmdPedido.Parameters.AddWithValue("@estadoPedidoID", estadoPedidoID);
                                cmdPedido.Parameters.AddWithValue("@direccionEnvio", (object)direccionEnvio ?? DBNull.Value);

                                nuevoPedidoID = Convert.ToInt32(cmdPedido.ExecuteScalar());
                            }

                            if (nuevoPedidoID > 0)
                            {
                                string queryDetalle = @"INSERT INTO DetallesPedido (PedidoID, ObraID, Cantidad, PrecioUnitario) 
                                                       VALUES (@pedidoID, @obraID, @cantidad, @precioUnitario)";

                                foreach (DataRow fila in detalles.Rows)
                                {
                                    using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con, transaccion))
                                    {
                                        cmdDetalle.Parameters.AddWithValue("@pedidoID", nuevoPedidoID);
                                        cmdDetalle.Parameters.AddWithValue("@obraID", Convert.ToInt32(fila["ObraID"]));
                                        cmdDetalle.Parameters.AddWithValue("@cantidad", Convert.ToInt32(fila["Cantidad"]));
                                        cmdDetalle.Parameters.AddWithValue("@precioUnitario", Convert.ToDecimal(fila["PrecioUnitario"]));

                                        cmdDetalle.ExecuteNonQuery();
                                    }
                                }
                                exito = true;
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
                    throw new Exception("Error transaccional al registrar la venta: " + ex.Message);
                }
            }
            return exito;
        }

        // 3. OBTENER DETALLES DE UN PEDIDO ESPECÍFICO
        public DataTable ListarDetallesPedido(int pedidoID)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexionBD.ObtenerConexion())
            {
                string query = @"SELECT dp.DetalleID, oa.Titulo AS Obra, u.Nombre + ' ' + u.Apellido AS Artista, dp.PrecioUnitario
                                FROM DetallesPedido dp
                                INNER JOIN ObrasArte oa ON dp.ObraID = oa.ObraID
                                INNER JOIN Usuarios u ON oa.ArtistaID = u.UsuarioID
                                WHERE dp.PedidoID = @pedidoID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoID", pedidoID);
                    try
                    {
                        con.Open();
                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            tabla.Load(leer);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error en CapaDatos al obtener detalles del pedido: " + ex.Message);
                    }
                }
            }
            return tabla;
        }
    } 
} 