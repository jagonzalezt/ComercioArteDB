using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Forms.Dialogs;
using ComercioArtes.Helpers;

namespace ComercioArtes.Forms.Panels
{
    // Panel para abrir los reportes del sistema.
    // Solo lo ve el Administrador.
    public class ReportesPanel : UserControl
    {
        private CN_Obras negocioObras = new CN_Obras();
        private CN_Transacciones negocioTrans = new CN_Transacciones();

        private TextBox txtFiltroObras;

        public ReportesPanel()
        {
            BackColor = UIHelper.ContentBg;
            Dock = DockStyle.Fill;
            Padding = new Padding(24);

            // ── Reporte de obras ──
            Label lblObras = CrearTitulo("Reporte de obras", 24);
            Label lblInfoObras = CrearTexto("Lista de las obras con su artista, técnica, precio, stock y estado. " +
                                            "Puedes filtrar por el título de la obra o por el nombre del artista.", 56);

            Label lblFiltro = CrearTexto("Filtro (opcional):", 98);

            txtFiltroObras = new TextBox();
            txtFiltroObras.Font = new Font("Segoe UI", 10F);
            txtFiltroObras.Location = new Point(24, 122);
            txtFiltroObras.Size = new Size(300, 27);

            Button btnReporteObras = UIHelper.BotonAccion("Ver reporte de obras", UIHelper.Indigo, 190);
            btnReporteObras.Location = new Point(340, 120);
            btnReporteObras.Click += btnReporteObras_Click;

            // ── Reporte de ventas ──
            Label lblVentas = CrearTitulo("Reporte de ventas", 190);
            Label lblInfoVentas = CrearTexto("Lista de los pedidos con el comprador, la fecha, el total y el estado.", 222);

            Button btnReporteVentas = UIHelper.BotonAccion("Ver reporte de ventas", UIHelper.Verde, 190);
            btnReporteVentas.Location = new Point(24, 256);
            btnReporteVentas.Click += btnReporteVentas_Click;

            Controls.Add(lblObras);
            Controls.Add(lblInfoObras);
            Controls.Add(lblFiltro);
            Controls.Add(txtFiltroObras);
            Controls.Add(btnReporteObras);
            Controls.Add(lblVentas);
            Controls.Add(lblInfoVentas);
            Controls.Add(btnReporteVentas);
        }

        private Label CrearTitulo(string texto, int y)
        {
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbl.ForeColor = UIHelper.TextPrimary;
            lbl.AutoSize = true;
            lbl.Location = new Point(24, y);
            return lbl;
        }

        private Label CrearTexto(string texto, int y)
        {
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 9.5F);
            lbl.ForeColor = UIHelper.TextSecondary;
            lbl.AutoSize = true;
            lbl.Location = new Point(24, y);
            return lbl;
        }

        private void btnReporteObras_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = negocioObras.ObtenerObras();
                string filtro = txtFiltroObras.Text.Trim();

                // Si escribieron un filtro, nos quedamos solo con las filas que coinciden
                if (filtro != "")
                    tabla = FiltrarObras(tabla, filtro);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron obras para mostrar.", "Reporte de obras",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FrmVisorReporte visor = new FrmVisorReporte("Reporte de obras",
                    "ComercioArtes.Reportes.RptObras.rdlc", "DataSet1", tabla, filtro);
                visor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = negocioTrans.ObtenerTransacciones();

                FrmVisorReporte visor = new FrmVisorReporte("Reporte de ventas",
                    "ComercioArtes.Reportes.RptVentas.rdlc", "DataSet1", tabla, "");
                visor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filtra la tabla en memoria por titulo o por nombre del artista
        // (no se arma ningun SQL con el texto, asi que no hay inyeccion SQL)
        private DataTable FiltrarObras(DataTable tabla, string filtro)
        {
            string texto = PrepararTextoParaFiltro(filtro);

            DataView vista = new DataView(tabla);
            vista.RowFilter = "Titulo LIKE '%" + texto + "%' OR NombreArtista LIKE '%" + texto + "%'";
            return vista.ToTable();
        }

        // Evita errores con las comillas y con los caracteres especiales del LIKE
        private string PrepararTextoParaFiltro(string texto)
        {
            texto = texto.Replace("'", "''");
            texto = texto.Replace("[", "[[]").Replace("%", "[%]").Replace("*", "[*]");
            return texto;
        }
    }
}
