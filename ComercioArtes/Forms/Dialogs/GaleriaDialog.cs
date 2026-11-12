using System;
using System.Windows.Forms;
using ComercioArtes.Data;
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class GaleriaDialog : BaseDialog
    {
        private readonly Galeria _galeria;

        public GaleriaDialog() : this(null) { }

        public GaleriaDialog(Galeria galeria)
            : base(galeria == null ? "Nueva Galería" : "Editar Galería")
        {
            _galeria = galeria;
            InitializeComponent();

            lblSubtitleDlg.Text = galeria == null
                ? "Registra una nueva galería de arte"
                : $"Modificando: {galeria.Nombre}";

            if (_galeria != null) PreCargar();
        }

        private void PreCargar()
        {
            txtNombreGal.Text   = _galeria.Nombre;
            txtDescGal.Text     = _galeria.Descripcion;
            txtUbicacionGal.Text = _galeria.Ubicacion;
            txtTelefonoGal.Text = _galeria.Telefono;
        }

        private void btnGuardarGal_Click(object sender, EventArgs e)
        {
            if (!Validar(txtNombreGal, txtUbicacionGal)) return;

            var ds = DataStore.Instancia;
            if (_galeria == null)
            {
                ds.Galerias.Add(new Galeria(ds.SiguienteIdGaleria(),
                    txtNombreGal.Text.Trim(), txtDescGal.Text.Trim(),
                    txtUbicacionGal.Text.Trim(), txtTelefonoGal.Text.Trim()));
            }
            else
            {
                _galeria.Nombre      = txtNombreGal.Text.Trim();
                _galeria.Descripcion = txtDescGal.Text.Trim();
                _galeria.Ubicacion   = txtUbicacionGal.Text.Trim();
                _galeria.Telefono    = txtTelefonoGal.Text.Trim();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelarGal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
