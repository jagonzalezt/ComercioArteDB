using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class SeleccionarObraDialog : BaseDialog
    {
        public Obra ObraElegida { get; private set; }

        // Instanciamos la Capa de Negocio
        private CN_Obras cnObras = new CN_Obras();

        public SeleccionarObraDialog() : this(null) { }

        public SeleccionarObraDialog(List<Obra> obrasIgnoradas) : base("Seleccionar Obra")
        {
            InitializeComponent();
            CargarObrasEnGrid();
        }

        private void CargarObrasEnGrid()
        {
            try
            {
                // Limpiamos cualquier fila anterior
                gridSelObra.Rows.Clear();

                // Obtenemos únicamente las obras disponibles desde la Capa de Negocio
                DataTable dtObras = cnObras.ObtenerObrasDisponibles();

                // Recorremos cada registro y lo agregamos directamente a las filas del grid
                foreach (DataRow row in dtObras.Rows)
                {
                    int id = Convert.ToInt32(row["ObraID"]);
                    string titulo = row["Titulo"].ToString();
                    string artista = row["NombreArtista"].ToString();
                    string tecnica = row["Tecnica"].ToString();
                    decimal precio = Convert.ToDecimal(row["Precio"]);

                    // Agregamos la fila respetando el orden de tus columnas en el diseño visual:
                    // [0] ID | [1] Título | [2] Artista | [3] Técnica | [4] Precio
                    gridSelObra.Rows.Add(id, titulo, artista, tecnica, precio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las obras: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarSel_Click(object sender, EventArgs e)
        {
            if (gridSelObra.CurrentRow == null) return;

            try
            {
                // Leemos directamente de las celdas de la fila seleccionada
                int idReal = Convert.ToInt32(gridSelObra.CurrentRow.Cells[0].Value);
                string titulo = gridSelObra.CurrentRow.Cells[1].Value.ToString();
                decimal precioReal = Convert.ToDecimal(gridSelObra.CurrentRow.Cells[4].Value);

                ObraElegida = new Obra
                {
                    Id = idReal,
                    Titulo = titulo,
                    Precio = precioReal
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la obra: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarSel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}