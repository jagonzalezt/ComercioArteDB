using System.Drawing;
using System.Windows.Forms;
using ComercioArtes.Helpers;

namespace ComercioArtes.Forms.Dialogs
{
    /// <summary>
    /// Clase base para todos los diálogos. No es abstracta para que
    /// el Diseñador de VS pueda instanciarla al mostrar subclases.
    /// </summary>
    public class BaseDialog : Form
    {
        // Constructor sin parámetros requerido por el Diseñador de VS
        protected BaseDialog() { }

        protected BaseDialog(string titulo)
        {
            Text = titulo;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = UIHelper.ContentBg;
        }

        // ── Fábrica de controles ──────────────────────────────────
        protected Label MkLabel(string texto, Point pos)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = UIHelper.TextPrimary,
                AutoSize = true,
                Location = pos
            };
        }

        protected TextBox MkTextBox(Point pos, int ancho = 360, bool multi = false)
        {
            return new TextBox
            {
                Location = pos,
                Size = new Size(ancho, multi ? 65 : 30),
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle,
                Multiline = multi
            };
        }

        protected ComboBox MkCombo(Point pos, int ancho = 360)
        {
            return new ComboBox
            {
                Location = pos,
                Size = new Size(ancho, 30),
                Font = new Font("Segoe UI", 10F),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
        }

        protected Button MkBoton(string texto, Color color, Point pos, int ancho = 150)
        {
            var btn = new Button
            {
                Text = texto,
                Location = pos,
                Size = new Size(ancho, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = color,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        protected bool Validar(params TextBox[] campos)
        {
            foreach (var t in campos)
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    MessageBox.Show("Por favor completa todos los campos obligatorios.",
                        "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
