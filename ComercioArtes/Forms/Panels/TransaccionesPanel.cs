using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio; // Asegura tener la referencia a tu CapaNegocio
using ComercioArtes.Forms.Dialogs;
using ComercioArtes.Helpers;

namespace ComercioArtes.Forms.Panels
{
    public partial class TransaccionesPanel : UserControl
    {
        private CN_Transacciones negocioTrans = new CN_Transacciones();

        public TransaccionesPanel()
        {
            InitializeComponent();
            Refrescar();
        }

        private void btnNuevaTrans_Click(object sender, EventArgs e) => NuevaFactura();

        private void btnCancelarTrans_Click(object sender, EventArgs e) => AnularFactura();

        private void gridTransacciones_SelectionChanged(object sender, EventArgs e) => RefrescarDetalle();

        // ── 1. LISTAR FACTURAS DESDE LA BASE DE DATOS ───────────────────
        private void Refrescar()
        {
            try
            {
                gridTransacciones.Rows.Clear();

                // Traemos los datos reales de SQL Server usando la Capa de Negocio
                DataTable dt = negocioTrans.ObtenerTransacciones();

                foreach (DataRow fila in dt.Rows)
                {
                    // Convertimos la fecha de la BD a formato texto
                    DateTime fechaBD = Convert.ToDateTime(fila["FechaPedido"]);

                    // Añadimos la fila mapeando las columnas exactas de la consulta SQL
                    int idx = gridTransacciones.Rows.Add(
                        fila["PedidoID"],
                        fechaBD.ToString("dd/MM/yyyy HH:mm"),
                        fila["Comprador"].ToString(),
                        "1", // Dejado provisionalmente
                        string.Format("${0:N2}", fila["Total"]),
                        fila["Estado"].ToString()
                    );

                    // Mantenemos tus colores bonitos del UIHelper según el estado que viene de SQL
                    gridTransacciones.Rows[idx].DefaultCellStyle.BackColor =
                        UIHelper.ColorEstadoFactura(fila["Estado"].ToString());
                }

                // Forzar la carga del detalle para la primera fila seleccionada por defecto
                RefrescarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── 2. SELECCIÓN DE DETALLES CONECTADO A LA BASE DE DATOS ──────
        private void RefrescarDetalle()
        {
            try
            {
                gridDetalle.Rows.Clear();

                // Validación de seguridad para evitar excepciones de referencia nula
                if (gridTransacciones.CurrentRow == null ||
                    gridTransacciones.CurrentRow.Cells[0].Value == null ||
                    gridTransacciones.CurrentRow.Index < 0)
                {
                    return;
                }

                // Extraemos el PedidoID real de la fila activa de arriba
                int idFact = Convert.ToInt32(gridTransacciones.CurrentRow.Cells[0].Value);

                // Mandamos a traer el detalle desde SQL Server pasando por la Capa de Negocio
                DataTable dtDetalles = negocioTrans.ObtenerDetallesPedido(idFact);

                // Poblamos la grilla de abajo
                foreach (DataRow fila in dtDetalles.Rows)
                {
                    gridDetalle.Rows.Add(
                        fila["DetalleID"],
                        fila["Obra"].ToString(),
                        fila["Artista"].ToString(),
                        string.Format("${0:N2}", fila["PrecioUnitario"])
                    );
                }
            }
            catch (Exception ex)
            {
                // Un log sutil para evitar alertas intrusivas durante el rediseño de filas
                Console.WriteLine("Error al refrescar detalle: " + ex.Message);
            }
        }

        private void NuevaFactura()
        {
            using (var dlg = new FacturaDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    Refrescar();
            }
        }

        private void AnularFactura()
        {
            if (gridTransacciones.CurrentRow == null) return;

            string estado = gridTransacciones.CurrentRow.Cells[5].Value.ToString();

            if (estado == "Cancelado")
            {
                MessageBox.Show("Esta factura ya fue anulada.", "Operación no permitida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                    "¿Anular la factura seleccionada en la base de datos?",
                    "Confirmar anulación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Próximamente programaremos el update de EstadoPedidoID = 4 (Cancelado)
                Refrescar();
            }
        }

        private void gridTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}