using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class ArtistaDialog : BaseDialog
    {
        private CN_Artistas objetoNegocio = new CN_Artistas();
        private readonly int? _artistaID;

        public ArtistaDialog() : this(null) { }

        public ArtistaDialog(int? artistaID)
            : base(artistaID == null ? "Nuevo Artista" : "Editar Artista")
        {
            _artistaID = artistaID;
            InitializeComponent();

            lblSubtitleDlg.Text = _artistaID == null
                ? "Completa los datos del artista"
                : "Modificando los datos del artista en el sistema";

            // Forzamos el amarre del Load de la ventana por código
            this.Load += new System.EventHandler(this.ArtistaDialog_Load);
        }

        private void ArtistaDialog_Load(object sender, EventArgs e)
        {
            if (_artistaID != null)
            {
                PreCargarDatosReal();
            }
        }

        private void PreCargarDatosReal()
        {
            try
            {
                DataTable artistas = objetoNegocio.ObtenerArtistas();
                if (artistas == null) return;

                DataRow[] filas = artistas.Select($"UsuarioID = {_artistaID}");

                if (filas.Length > 0)
                {
                    DataRow artista = filas[0];

                    txtNombre.Text = artista["Nombre"] != DBNull.Value ? artista["Nombre"].ToString() : "";
                    txtCorreo.Text = artista["Email"] != DBNull.Value ? artista["Email"].ToString() : "";
                    txtTelefono.Text = artista["Telefono"] != DBNull.Value ? artista["Telefono"].ToString() : "";
                    txtBiografia.Text = artista["Biografia"] != DBNull.Value ? artista["Biografia"].ToString() : "";
                    txtTrayectoria.Text = artista["SitioWeb"] != DBNull.Value ? artista["SitioWeb"].ToString() : "";

                    string seudonimo = artista["Seudonimo"] != DBNull.Value ? artista["Seudonimo"].ToString() : "";
                    int idx = cmbPais.Items.IndexOf(seudonimo);
                    if (idx >= 0)
                        cmbPais.SelectedIndex = idx;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del registro seleccionado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar(txtNombre, txtCorreo)) return;

            if (cmbPais.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una opción o país válido para continuar.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPais.Focus();
                return;
            }

            string valorCombo = cmbPais.SelectedItem.ToString();

            try
            {
                // Dividimos el string de nombre para insertarlo en Nombre y Apellido de la tabla Usuarios
                string[] partesNombre = txtNombre.Text.Trim().Split(new char[] { ' ' }, 2);
                string nombre = partesNombre[0];
                string apellido = partesNombre.Length > 1 ? partesNombre[1] : " ";

                if (_artistaID == null)
                {
                    // Operación: NUEVO REGISTRO
                    string passwordProvisional = "NicaArt2026";

                    objetoNegocio.Guardar(
                        nombre,
                        apellido,
                        txtCorreo.Text.Trim(),
                        passwordProvisional,
                        txtTelefono.Text.Trim(),
                        valorCombo,
                        txtBiografia.Text.Trim(),
                        txtTrayectoria.Text.Trim()
                    );
                }
                else
                {
                    // Operación: ACTUALIZAR REGISTRO
                    objetoNegocio.Actualizar(
                        _artistaID.Value,
                        nombre,
                        apellido,
                        txtCorreo.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        valorCombo,
                        txtBiografia.Text.Trim(),
                        txtTrayectoria.Text.Trim()
                    );
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar las modificaciones en la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}