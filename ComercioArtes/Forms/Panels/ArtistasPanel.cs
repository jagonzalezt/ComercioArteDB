using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Forms.Dialogs;

namespace ComercioArtes.Forms.Panels
{
    public partial class ArtistasPanel : UserControl
    {
        private CN_Artistas objetoNegocio = new CN_Artistas();
        private BindingSource binData = new BindingSource(); // El secreto para un filtrado perfecto

        public ArtistasPanel()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ArtistasPanel_Load);
        }

        private void ArtistasPanel_Load(object sender, EventArgs e)
        {
            // CONFIGURACIÓN CRUCIAL DE LA GRILLA:
            // Para que no se dupliquen columnas con tus cabeceras hechas a mano, 
            // mapeamos cada columna visual con el nombre exacto del campo que viene de SQL.
            gridArtistas.AutoGenerateColumns = false;

            // Asegúrate de que los nombres de tus columnas coincidan con estos DataPropertyName:
            if (gridArtistas.Columns.Count >= 6)
            {
                gridArtistas.Columns[0].DataPropertyName = "UsuarioID";
                gridArtistas.Columns[1].DataPropertyName = "Nombre"; // Nota: si unes Nombre+Apellido en SQL se mapea directo
                gridArtistas.Columns[2].DataPropertyName = "Email";
                gridArtistas.Columns[3].DataPropertyName = "Seudonimo";
                gridArtistas.Columns[4].DataPropertyName = "Telefono";
                gridArtistas.Columns[5].DataPropertyName = "Biografia";
            }

            CargarDatosDesdeSQL();
        }

        private void CargarDatosDesdeSQL()
        {
            try
            {
                DataTable tablaArtistas = objetoNegocio.ObtenerArtistas();

                if (tablaArtistas != null)
                {
                    // Agregamos una columna calculada para el Nombre Completo si tu SQL los manda separados
                    if (!tablaArtistas.Columns.Contains("NombreCompleto"))
                    {
                        tablaArtistas.Columns.Add("NombreCompleto", typeof(string), "Nombre + ' ' + Apellido");
                    }

                    // Ajustamos el mapeo de la columna 1 para que use el Nombre Completo dinámico
                    if (gridArtistas.Columns.Count >= 2)
                    {
                        gridArtistas.Columns[1].DataPropertyName = "NombreCompleto";
                    }

                    // Enlazamos mediante el BindingSource intermedio
                    binData.DataSource = tablaArtistas;
                    gridArtistas.DataSource = binData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde SQL Server:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── FILTRADO ULTRA RÁPIDO SIN PARPADEO NI TRABAS ──────────────────
        private void FiltrarArtistas()
        {
            try
            {
                if (binData.DataSource == null) return;

                string filtro = (txtBuscar.ForeColor == Color.Silver) ? "" : txtBuscar.Text.Trim().Replace("'", "''");

                if (string.IsNullOrEmpty(filtro))
                {
                    binData.Filter = ""; // Limpia el filtro, muestra todo
                }
                else
                {
                    // Filtra de forma asíncrona sobre la memoria del DataTable
                    binData.Filter = $"NombreCompleto LIKE '%{filtro}%' OR Seudonimo LIKE '%{filtro}%'";
                }
            }
            catch (Exception ex)
            {
                // Evitamos que se caiga la app si hay caracteres extraños
                System.Diagnostics.Debug.WriteLine("Error en filtro: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarArtistas();
        }

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
                txtBuscar.Text = "Buscar artista...";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private int? IdArtistaSeleccionado()
        {
            if (gridArtistas.CurrentRow == null) return null;

            // Al usar DataSource, leemos la celda de forma directa y segura
            var cellValue = gridArtistas.CurrentRow.Cells[0].Value;
            if (cellValue == null || cellValue == DBNull.Value) return null;

            return Convert.ToInt32(cellValue);
        }

        private void AbrirDialogo(int? artistaID)
        {
            try
            {
                using (ArtistaDialog dlg = new ArtistaDialog(artistaID))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        CargarDatosDesdeSQL();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir ventana: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e) => AbrirDialogo(null);

        private void btnEditar_Click(object sender, EventArgs e) => Editar();

        private void btnEliminar_Click(object sender, EventArgs e) => Eliminar();

        private void Editar()
        {
            int? id = IdArtistaSeleccionado();
            if (id != null)
                AbrirDialogo(id);
            else
                MessageBox.Show("Por favor, seleccione un artista de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Eliminar()
        {
            int? id = IdArtistaSeleccionado();
            if (id == null) return;

            if (MessageBox.Show("¿Está seguro de eliminar al artista seleccionado?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    objetoNegocio.Eliminar(id.Value);
                    MessageBox.Show("Artista eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosDesdeSQL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void gridArtistas_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void gridArtistas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Editar();
        }
    }
}