using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Forms.Dialogs;
using ComercioArtes.Helpers; // Mantiene tus colores estéticos de UIHelper

namespace ComercioArtes.Forms.Panels
{
    public partial class ObrasPanel : UserControl
    {
        private CN_Obras objetoNegocio = new CN_Obras();
        private BindingSource binData = new BindingSource(); // Evita parpadeos y congelamientos

        public ObrasPanel()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ObrasPanel_Load);
        }

        private void ObrasPanel_Load(object sender, EventArgs e)
        {
            // Evitamos la duplicación de columnas con tu diseño manual
            gridObras.AutoGenerateColumns = false;

            // Enlazamos tus columnas del Diseñador con los campos exactos de SQL Server
            if (gridObras.Columns.Count >= 8)
            {
                gridObras.Columns[0].DataPropertyName = "ObraID";
                gridObras.Columns[1].DataPropertyName = "Titulo";
                gridObras.Columns[2].DataPropertyName = "NombreArtista"; // Traído vía INNER JOIN
                gridObras.Columns[3].DataPropertyName = "Tecnica";
                gridObras.Columns[4].DataPropertyName = "Anio";
                gridObras.Columns[5].DataPropertyName = "Dimensiones";
                gridObras.Columns[6].DataPropertyName = "Precio";
                gridObras.Columns[7].DataPropertyName = "Estado";
            }

            CargarDatosDesdeSQL();
        }

        private void CargarDatosDesdeSQL()
        {
            try
            {
                DataTable tablaObras = objetoNegocio.ObtenerObras();
                if (tablaObras != null)
                {
                    binData.DataSource = tablaObras;
                    gridObras.DataSource = binData;

                    // Aplicamos tus colores de estado de forma segura fila por fila
                    PintarEstadosUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las obras desde la base de datos:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Aplica los colores estéticos de tu UIHelper según el estado de la obra
        /// </summary>
        private void PintarEstadosUI()
        {
            foreach (DataGridViewRow fila in gridObras.Rows)
            {
                if (fila.Cells[7].Value != null)
                {
                    string estadoStr = fila.Cells[7].Value.ToString();
                    fila.DefaultCellStyle.BackColor = UIHelper.ColorEstadoObra(estadoStr);
                }
            }
        }

        // ── FILTRADO AVANZADO (BÚSQUEDA + ESTADO) ─────────────────────
        private void FiltrarObras()
        {
            try
            {
                if (binData.DataSource == null) return;

                string filtro = (txtBuscar.ForeColor == Color.Silver) ? "" : txtBuscar.Text.Trim().Replace("'", "''");
                string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";

                string expresionFiltro = "";

                // 1. Filtro por palabra clave (Título o Artista)
                if (!string.IsNullOrEmpty(filtro))
                {
                    expresionFiltro = $"(Titulo LIKE '%{filtro}%' OR NombreArtista LIKE '%{filtro}%')";
                }

                // 2. Filtro por ComboBox de Estado
                if (estado != "Todos")
                {
                    if (!string.IsNullOrEmpty(expresionFiltro)) expresionFiltro += " AND ";
                    expresionFiltro += $"Estado = '{estado}'";
                }

                // Aplicamos el filtro al BindingSource en memoria
                binData.Filter = expresionFiltro;

                // Repintamos los colores ya que las filas visibles cambiaron
                PintarEstadosUI();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en filtro: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => FiltrarObras();

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e) => FiltrarObras();

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.ForeColor == Color.Silver)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.FromArgb(31, 41, 55);
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar obra...";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private int? IdObraSeleccionada()
        {
            if (gridObras.CurrentRow == null || gridObras.CurrentRow.Cells[0].Value == null)
                return null;

            return Convert.ToInt32(gridObras.CurrentRow.Cells[0].Value);
        }

        private void AbrirDialogo(int? obraID) // <-- Cambia "Obra obra" por "int? obraID"
        {
            try
            {
                using (var dlg = new ObraDialog(obraID)) // Ahora le pasamos el ID numérico
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        CargarDatosDesdeSQL();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de edición: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnNueva_Click(object sender, EventArgs e) => AbrirDialogo(null);

        private void btnEditar_Click(object sender, EventArgs e) => Editar();

        private void btnEliminar_Click(object sender, EventArgs e) => Eliminar();

        private void gridObras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Editar();
        }

        private void Editar()
        {
            int? id = IdObraSeleccionada();
            if (id != null)
                AbrirDialogo(id);
            else
                MessageBox.Show("Por favor, seleccione una obra de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Eliminar()
        {
            if (gridObras.CurrentRow == null) return;

            int? id = IdObraSeleccionada();
            if (id == null) return;

            string estado = gridObras.CurrentRow.Cells[7].Value?.ToString() ?? "";
            string titulo = gridObras.CurrentRow.Cells[1].Value?.ToString() ?? "esta obra";

            if (estado == "Vendida")
            {
                MessageBox.Show("No se puede eliminar una obra que ya ha sido vendida.", "Restricción de Negocio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Está seguro de eliminar de forma permanente la obra \"{titulo}\" del sistema?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    objetoNegocio.EliminarObra(id.Value);
                    MessageBox.Show("La obra ha sido removida con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosDesdeSQL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridObras_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}