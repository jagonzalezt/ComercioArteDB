using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace ComercioArtes.Forms
{
    public partial class LoginForm : Form
    {
        private CN_Usuarios objetoNegocio = new CN_Usuarios();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = ""; // Limpia la advertencia visual

                // Cambia 'txtEmail' por el Name real de tu cuadro de correo si fuese distinto
                DataTable resultado = objetoNegocio.LoguearUsuario(txtEmail.Text.Trim(), txtPassword.Text);

                if (resultado.Rows.Count > 0)
                {
                    string nombreUsuario = resultado.Rows[0]["Nombre"].ToString();
                    MessageBox.Show("¡Bienvenido al sistema, " + nombreUsuario + "!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    new MainForm().ShowDialog();
                    Close();
                }
                else
                {
                    lblError.Text = "⚠  Usuario o contraseña incorrectos.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Si añadiste el LinkLabel para abrir el registro, pon este código en su evento:
        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComercioArtes.Forms.Dialogs.UsuarioDialog ventanaRegistro = new ComercioArtes.Forms.Dialogs.UsuarioDialog();
            ventanaRegistro.ShowDialog();
        }

        private void pnlDerecho_Paint(object sender, PaintEventArgs e) { }
        private void pnlIzquierdo_Paint(object sender, PaintEventArgs e) { }
        private void LoginForm_Load(object sender, EventArgs e) { }
        private void lblPista_Click(object sender, EventArgs e) { }

        private void txtRegistar_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario flotante que está dentro de la carpeta Dialogs
            ComercioArtes.Forms.Dialogs.UsuarioDialog ventanaRegistro = new ComercioArtes.Forms.Dialogs.UsuarioDialog();

            // Lo mostramos como ShowDialog para que aparezca centrado y encima del Login
            ventanaRegistro.ShowDialog();
        }
    }
}
