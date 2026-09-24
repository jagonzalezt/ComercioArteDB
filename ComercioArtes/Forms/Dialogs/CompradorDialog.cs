using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class CompradorDialog : BaseDialog
    {
        private CN_Compradores objetoNegocio = new CN_Compradores();
        private readonly int? _compradorID;

        public CompradorDialog() : this(null) { }

        public CompradorDialog(int? compradorID)
            : base(compradorID == null ? "Nuevo Comprador" : "Editar Comprador")
        {
            _compradorID = compradorID;
            InitializeComponent();

            foreach (var m in Enum.GetValues(typeof(MetodoPago)))
                cmbMetodoPago.Items.Add(m);
            if (cmbMetodoPago.Items.Count > 0) cmbMetodoPago.SelectedIndex = 0;

            if (_compradorID != null)
            {
                lblSubtitleDlg.Text = "Modificando los datos del comprador seleccionado";
                PreCargar();
            }
            else
            {
                lblSubtitleDlg.Text = "Registra un nuevo comprador en el sistema";
            }
        }

        private void PreCargar()
        {
            try
            {
                DataTable compradores = objetoNegocio.ObtenerCompradores();
                if (compradores == null) return;

                DataRow[] filas = compradores.Select($"CompradorID = {_compradorID}");

                if (filas.Length > 0)
                {
                    DataRow comprador = filas[0];

                    txtNombreComp.Text = comprador["Nombre"].ToString();
                    txtCorreoComp.Text = comprador["Correo"].ToString();
                    txtTelefonoComp.Text = comprador["Telefono"].ToString();
                    txtDireccionComp.Text = comprador["Direccion"].ToString();

                    string metodoStr = comprador["MetodoPago"].ToString();
                    if (Enum.TryParse<MetodoPago>(metodoStr, true, out MetodoPago metodoEnum))
                    {
                        cmbMetodoPago.SelectedItem = metodoEnum;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del comprador desde la BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarComp_Click(object sender, EventArgs e)
        {
            if (!Validar(txtNombreComp, txtCorreoComp)) return;

            try
            {
                string nombre = txtNombreComp.Text.Trim();
                string correo = txtCorreoComp.Text.Trim();
                string telefono = txtTelefonoComp.Text.Trim();
                string direccion = txtDireccionComp.Text.Trim();
                string metodoPago = cmbMetodoPago.SelectedItem.ToString();

                if (_compradorID == null)
                {
                    objetoNegocio.GuardarComprador(nombre, correo, telefono, direccion, metodoPago);
                    MessageBox.Show("Comprador y Usuario registrados con éxito en SQL Server.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objetoNegocio.ActualizarComprador(_compradorID.Value, nombre, correo, telefono, direccion, metodoPago);
                    MessageBox.Show("Datos del comprador y usuario actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error de Persistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarComp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CompradorDialog_Load(object sender, EventArgs e) { }

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    }
}