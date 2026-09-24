using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio; // Referencia a las capas lógicas de SQL Server
using ComercioArtes.Forms.Dialogs;

namespace ComercioArtes.Forms.Panels
{
    public partial class CompradoresPanel : UserControl
    {
        // Instanciamos la Capa de Negocio para la conexión a la base de datos SQL
        private CN_Compradores negocioCompradores = new CN_Compradores();
        private DataTable tablaCompradores;

        public CompradoresPanel()
        {
            InitializeComponent();
            Refrescar();
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
                txtBuscar.Text = "Buscar comprador...";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => FiltrarLocalmente();

        private void btnNuevo_Click(object sender, EventArgs e) => AbrirDialogo(null);

        private void btnEditar_Click(object sender, EventArgs e) => Editar();

        private void btnEliminar_Click(object sender, EventArgs e) => Eliminar();

        private void gridCompradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Editar();
        }

        // ── Lógica SQL ───────────────────────────────────────────

        /// <summary>
        /// Obtiene los datos actualizados desde la base de datos SQL Server y los carga en el Grid.
        /// </summary>
        private void Refrescar()
        {
            try
            {
                // Obtenemos los compradores mediante INNER JOIN desde SQL
                tablaCompradores = negocioCompradores.ObtenerCompradores();

                // Limpiamos las filas antes de cargar los datos de SQL
                gridCompradores.Rows.Clear();

                if (tablaCompradores != null)
                {
                    foreach (DataRow fila in tablaCompradores.Rows)
                    {
                        gridCompradores.Rows.Add(
                            fila["CompradorID"],
                            fila["Nombre"],
                            fila["Correo"],
                            fila["Telefono"],
                            fila["Direccion"],
                            fila["MetodoPago"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compradores desde la BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Filtra los datos directamente en las filas de la Grid sin re-consultar al servidor de SQL.
        /// </summary>
        private void FiltrarLocalmente()
        {
            string filtro = txtBuscar.ForeColor == Color.Silver ? "" : txtBuscar.Text.Trim().ToLower();

            gridCompradores.Rows.Clear();

            if (tablaCompradores == null) return;

            foreach (DataRow fila in tablaCompradores.Rows)
            {
                string nombre = fila["Nombre"].ToString().ToLower();
                string correo = fila["Correo"].ToString().ToLower();

                if (filtro != "" && !nombre.Contains(filtro) && !correo.Contains(filtro))
                    continue;

                gridCompradores.Rows.Add(
                    fila["CompradorID"],
                    fila["Nombre"],
                    fila["Correo"],
                    fila["Telefono"],
                    fila["Direccion"],
                    fila["MetodoPago"]
                );
            }
        }

        /// <summary>
        /// Obtiene el ID numérico de la fila seleccionada actualmente.
        /// </summary>
        private int? ObtenerIDSeleccionado()
        {
            if (gridCompradores.CurrentRow == null) return null;

            // Retorna el valor de la celda de ID (Columna 0)
            return Convert.ToInt32(gridCompradores.CurrentRow.Cells[0].Value);
        }

        private void AbrirDialogo(int? compradorID)
        {
            // Cambiado el constructor para enviar el ID nuleable siguiendo la regla de Obras
            using (var dlg = new CompradorDialog(compradorID))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    Refrescar();
            }
        }

        private void Editar()
        {
            int? id = ObtenerIDSeleccionado();
            if (id != null)
                AbrirDialogo(id);
        }

        private void Eliminar()
        {
            int? id = ObtenerIDSeleccionado();
            if (id == null) return;

            string nombreComprador = gridCompradores.CurrentRow.Cells[1].Value.ToString();

            // Mensaje de confirmación antes de la baja lógica en SQL
            if (MessageBox.Show($"¿Desea dar de baja al comprador \"{nombreComprador}\" en el sistema?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = negocioCompradores.EliminarComprador(id.Value);
                    if (eliminado)
                    {
                        MessageBox.Show("Comprador eliminado con éxito.", "Gestión de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refrescar();
                    }
                }
                catch (Exception ex)
                {
                    // Maneja automáticamente las excepciones de llaves foráneas de SQL Server
                    MessageBox.Show("No se pudo eliminar el cliente debido a dependencias con transacciones: " + ex.Message,
                        "Restricción de SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridCompradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}