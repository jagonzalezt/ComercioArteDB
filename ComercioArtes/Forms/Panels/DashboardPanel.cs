using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Helpers;

namespace ComercioArtes.Forms.Panels
{
    public partial class DashboardPanel : UserControl
    {
        private CN_Dashboard negocioDashboard = new CN_Dashboard();

        public DashboardPanel()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                // 1. Cargar las Tarjetas Superiores (Cards)
                DataRow contadores = negocioDashboard.ObtenerContadores();
                if (contadores != null)
                {
                    lblValCard1.Text = contadores["TotalArtistas"].ToString();
                    lblValCard2.Text = contadores["TotalObras"].ToString();
                    lblValCard3.Text = contadores["Disponibles"].ToString();
                    lblValCard4.Text = contadores["Vendidas"].ToString();
                    lblValCard5.Text = string.Format("${0:N2}", Convert.ToDecimal(contadores["IngresosTotales"]));
                }

                // 2. Llenar grid de obras reales
                gridObrasDB.Rows.Clear();
                DataTable dtObras = negocioDashboard.ObtenerObras();
                foreach (DataRow fila in dtObras.Rows)
                {
                    int idx = gridObrasDB.Rows.Add(
                        fila["ObraID"],
                        fila["Titulo"].ToString(),
                        fila["Artista"].ToString(),
                        fila["Tecnica"].ToString(),
                        string.Format("${0:N2}", Convert.ToDecimal(fila["Precio"])),
                        fila["Estado"].ToString()
                    );

                    gridObrasDB.Rows[idx].DefaultCellStyle.BackColor =
                        UIHelper.ColorEstadoObra(fila["Estado"].ToString());
                }

                // 3. Llenar grid de facturas/pedidos reales
                gridTransDB.Rows.Clear();
                DataTable dtPedidos = negocioDashboard.ObtenerPedidosRecientes();
                foreach (DataRow fila in dtPedidos.Rows)
                {
                    DateTime fechaBD = Convert.ToDateTime(fila["FechaPedido"]);

                    // Nota: Modificamos el orden según las columnas de tu gridTransDB de tu diseño (ID, Fecha, Comprador, Monto, # Obras)
                    int idx = gridTransDB.Rows.Add(
                        fila["PedidoID"],
                        fechaBD.ToString("dd/MM/yyyy HH:mm"),
                        fila["Comprador"].ToString(),
                        string.Format("${0:N2}", Convert.ToDecimal(fila["Total"])),
                        "1" // Marcador temporal para cantidad
                    );

                    gridTransDB.Rows[idx].DefaultCellStyle.BackColor =
                        UIHelper.ColorEstadoFactura(fila["Estado"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del Dashboard real: " + ex.Message,
                                "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridObrasDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}