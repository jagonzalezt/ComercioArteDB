using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class UsuarioDialog : Form
    {
        private CN_Usuarios objetoNegocio = new CN_Usuarios();

        public UsuarioDialog()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mapeamos la selección del ComboBox a los IDs de tu base de datos
                // En tu script: 2 = Artista, 3 = Comprador
                int rolID = (cmbRol.SelectedItem?.ToString() == "Artista") ? 2 : 3;

                if (cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de usuario (Rol).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool insertado = objetoNegocio.ValidarYRegistrar(
                    rolID,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtEmail.Text,
                    txtPassword.Text,
                    txtTelefono.Text
                );

                if (insertado)
                {
                    MessageBox.Show("¡Cuenta creada con éxito! Ya puedes iniciar sesión.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerramos el diálogo de registro
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}