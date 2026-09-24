using System;
using System.Data;
using CapaDatos; // Asegúrate de tener la referencia a CapaDatos

namespace CapaNegocio
{
    public class CN_Transacciones
    {
        private CD_Transacciones objetoCapaDatos = new CD_Transacciones();

        // 1. Obtener todas las facturas/pedidos principales
        public DataTable ObtenerTransacciones()
        {
            return objetoCapaDatos.ListarTransacciones();
        }

        // 2. Insertar una nueva transacción completa (Maestro-Detalle)
        public bool InsertarTransaccion(int compradorID, decimal total, int estadoPedidoID, string direccionEnvio, DataTable detalles)
        {
            return objetoCapaDatos.RegistrarTransaccion(compradorID, total, estadoPedidoID, direccionEnvio, detalles);
        }

        // 3. ESTE ES EL MÉTODO QUE FALTA COMPLEMENTAR:
        public DataTable ObtenerDetallesPedido(int pedidoID)
        {
            if (pedidoID <= 0)
                throw new Exception("El ID de pedido proporcionado no es válido.");

            return objetoCapaDatos.ListarDetallesPedido(pedidoID);
        }
    }
}