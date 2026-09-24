using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Dashboard
    {
        private CD_Dashboard objetoCapaDatos = new CD_Dashboard();
        private CD_Transacciones transaccionesDatos = new CD_Transacciones();

        public DataRow ObtenerContadores()
        {
            DataTable dt = objetoCapaDatos.ObtenerMetricasContadores();
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataTable ObtenerObras() => objetoCapaDatos.ListarObrasDashboard();

        // Reutilizamos el método de transacciones reales que ya creamos antes
        public DataTable ObtenerPedidosRecientes() => transaccionesDatos.ListarTransacciones();
    }
}