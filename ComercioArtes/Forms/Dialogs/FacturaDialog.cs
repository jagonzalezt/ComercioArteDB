using CapaDatos;   // Capa que contiene tu ConexionBD
using CapaNegocio; // Capa que contiene CN_Transacciones
using ComercioArtes.Data;
using ComercioArtes.Estructuras;
using ComercioArtes.Helpers;
using ComercioArtes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class FacturaDialog : BaseDialog
    {
        // Mantenemos tu lista visual temporal de obras añadidas
        private readonly List<Obra> _obras = new List<Obra>();

        // Pila con las obras en el orden en que se fueron agregando.
        // Sirve para deshacer la ultima obra agregada.
        private readonly Pila<Obra> _pilaAgregadas = new Pila<Obra>();
        private CN_Transacciones negocioTrans = new CN_Transacciones();
        private ConexionBD conexionBD = new ConexionBD();

        public FacturaDialog() : base("Nueva Factura")
        {
            InitializeComponent();
            CrearBotonDeshacer();
            CargarCompradoresCombobox();
            ActualizarTotal();
        }

        // Boton para deshacer la ultima obra agregada (usa la pila)
        private void CrearBotonDeshacer()
        {
            Button btnDeshacerObra = UIHelper.BotonAccion("↶ Deshacer última", UIHelper.Ambar, 130);
            btnDeshacerObra.Size = new Size(130, 36);
            btnDeshacerObra.Location = new Point(496, 256);
            btnDeshacerObra.Click += btnDeshacerObra_Click;
            Controls.Add(btnDeshacerObra);
        }

        private void btnDeshacerObra_Click(object sender, EventArgs e)
        {
            // Sacamos de la pila hasta encontrar la ultima obra que todavia esta en la factura
            while (!_pilaAgregadas.EstaVacia())
            {
                Obra ultima = _pilaAgregadas.Desapilar();
                if (_obras.Contains(ultima))
                {
                    _obras.Remove(ultima);
                    ActualizarGrid();
                    ActualizarTotal();
                    return;
                }
            }

            MessageBox.Show("No hay obras para deshacer.", "Deshacer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 1. LLENAR EL COMBOBOX DESDE LA BASE DE DATOS REAL
        private void CargarCompradoresCombobox()
        {
            try
            {
                using (SqlConnection con = conexionBD.ObtenerConexion())
                {
                    // Traemos los usuarios que tienen RolID = 3 (Compradores)
                    string query = "SELECT UsuarioID, Nombre + ' ' + Apellido AS NombreCompleto FROM Usuarios WHERE RolID = 3 AND Activo = 1";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbComprador.DataSource = dt;
                        cmbComprador.DisplayMember = "NombreCompleto"; // Lo que el usuario ve
                        cmbComprador.ValueMember = "UsuarioID";       // El ID que guardaremos en Pedidos
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compradores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarObra_Click(object sender, EventArgs e)
        {
            // Abrimos directamente el diálogo de selección (que ahora lee desde la BD usando CN_Obras)
            using (var dlg = new SeleccionarObraDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK && dlg.ObraElegida != null)
                {
                    // Validamos que la obra no se haya agregado previamente a la factura actual
                    if (_obras.Any(o => o.Id == dlg.ObraElegida.Id))
                    {
                        MessageBox.Show("Esta obra ya fue agregada a la factura.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Agregamos la obra seleccionada desde SQL Server
                    _obras.Add(dlg.ObraElegida);
                    _pilaAgregadas.Apilar(dlg.ObraElegida);

                    ActualizarGrid();
                    ActualizarTotal();
                }
            }
        }

        private void btnQuitarObra_Click(object sender, EventArgs e)
        {
            if (gridDetalles.CurrentRow == null) return;
            _obras.RemoveAt(gridDetalles.CurrentRow.Index);
            ActualizarGrid();
            ActualizarTotal();
        }

        private void ActualizarGrid()
        {
            gridDetalles.Rows.Clear();
            var ds = DataStore.Instancia;
            foreach (var o in _obras)
            {
                var artista = ds.BuscarArtista(o.IdArtista);
                gridDetalles.Rows.Add(o.Titulo, artista?.Nombre ?? "—", $"${o.Precio:N2}");
            }
        }

        private void ActualizarTotal()
        {
            decimal total = _obras.Sum(o => o.Precio);
            lblTotalValor.Text = $"${total:N2}";
        }

        // 2. PROCESAR LA FACTURA REAL EN SQL SERVER
        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (cmbComprador.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un comprador.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!_obras.Any())
            {
                MessageBox.Show("Agrega al menos una obra a la factura.", "Sin obras",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int compradorID = Convert.ToInt32(cmbComprador.SelectedValue);
                decimal total = _obras.Sum(o => o.Precio);
                int estadoPedidoID = 2; // Id 2 corresponde a 'Pagado' según tus inserts base
                string direccionEnvio = "Dirección de entrega predeterminada"; // Puedes amarrarlo a un txt si tienes

                // GENERAMOS EL CARRITO EN FORMATO DATATABLE EN MEMORIA
                DataTable dtDetalleCarrito = new DataTable();
                dtDetalleCarrito.Columns.Add("ObraID", typeof(int));
                dtDetalleCarrito.Columns.Add("Cantidad", typeof(int));
                dtDetalleCarrito.Columns.Add("PrecioUnitario", typeof(decimal));

                // Volcamos la lista de obras elegidas al DataTable carrito
                foreach (var obra in _obras)
                {
                    DataRow fila = dtDetalleCarrito.NewRow();
                    fila["ObraID"] = obra.Id;
                    fila["Cantidad"] = 1; // Al ser arte independiente la cantidad por obra suele ser 1
                    fila["PrecioUnitario"] = obra.Precio;
                    dtDetalleCarrito.Rows.Add(fila);
                }

                // LLAMAMOS A LA CAPA DE NEGOCIO TRANSACCIONAL
                bool exito = negocioTrans.InsertarTransaccion(compradorID, total, estadoPedidoID, direccionEnvio, dtDetalleCarrito);

                if (exito)
                {
                    // Cambiamos el estado en el demo local por consistencia visual
                    foreach (var obra in _obras)
                    {
                        obra.Estado = EstadoObra.Vendida;
                    }

                    MessageBox.Show(
                        $"Factura emitida exitosamente en SQL Server.\n" +
                        $"Comprador: {cmbComprador.Text}\n" +
                        $"Obras vendidas: {_obras.Count}\n" +
                        $"Total: ${total:N2}",
                        "Factura emitida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de persistencia al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarFact_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void gridDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}