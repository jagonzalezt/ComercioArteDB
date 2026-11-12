using ComercioArtes.Forms.Panels;
using ComercioArtes.Helpers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ComercioArtes.Forms
{
    public partial class MainForm : Form
    {
        private Button _btnActivo;
        private Button btnNavEstructuras;
        private Button btnNavReportes;

        public MainForm()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            CrearBotonEstructuras();
            CrearBotonReportes();
            AplicarRol();
            // Activar Dashboard al iniciar
            btnNavDashboard.PerformClick();
        }

        // ── Navegación ────────────────────────────────────────────
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavDashboard);
            lblPaginaActual.Text = "Dashboard";
            CargarPanel(new DashboardPanel());
        }

        private void btnNavArtistas_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavArtistas);
            lblPaginaActual.Text = "Artistas";
            CargarPanel(new ArtistasPanel());
        }

        private void btnNavObras_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavObras);
            lblPaginaActual.Text = "Obras";
            CargarPanel(new ObrasPanel());
        }

        private void btnNavGalerias_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavGalerias);
            lblPaginaActual.Text = "Galerías";
            CargarPanel(new GaleriasPanel());
        }

        private void btnNavCompradores_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavCompradores);
            lblPaginaActual.Text = "Compradores";
            CargarPanel(new CompradoresPanel());
        }

        private void btnNavTransacciones_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavTransacciones);
            lblPaginaActual.Text = "Transacciones";
            CargarPanel(new TransaccionesPanel());
        }

        private void btnNavEstructuras_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavEstructuras);
            lblPaginaActual.Text = "Estructuras de datos";
            CargarPanel(new EstructurasPanel());
        }

        private void btnNavReportes_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnNavReportes);
            lblPaginaActual.Text = "Reportes";
            CargarPanel(new ReportesPanel());
        }

        // ── Roles ─────────────────────────────────────────────────
        // Crea el boton del modulo de estructuras con el mismo estilo de los demas
        private void CrearBotonEstructuras()
        {
            btnNavEstructuras = new Button();
            btnNavEstructuras.Name = "btnNavEstructuras";
            btnNavEstructuras.BackColor = btnNavDashboard.BackColor;
            btnNavEstructuras.FlatStyle = FlatStyle.Flat;
            btnNavEstructuras.FlatAppearance.BorderSize = 0;
            btnNavEstructuras.FlatAppearance.MouseOverBackColor = btnNavDashboard.FlatAppearance.MouseOverBackColor;
            btnNavEstructuras.Font = btnNavDashboard.Font;
            btnNavEstructuras.ForeColor = btnNavDashboard.ForeColor;
            btnNavEstructuras.Size = btnNavDashboard.Size;
            btnNavEstructuras.TextAlign = ContentAlignment.MiddleLeft;
            btnNavEstructuras.Text = "  🌳   Estructuras";
            btnNavEstructuras.UseVisualStyleBackColor = false;
            btnNavEstructuras.Click += btnNavEstructuras_Click;
            pnlSidebar.Controls.Add(btnNavEstructuras);
        }

        // Crea el boton de reportes con el mismo estilo de los demas
        private void CrearBotonReportes()
        {
            btnNavReportes = new Button();
            btnNavReportes.Name = "btnNavReportes";
            btnNavReportes.BackColor = btnNavDashboard.BackColor;
            btnNavReportes.FlatStyle = FlatStyle.Flat;
            btnNavReportes.FlatAppearance.BorderSize = 0;
            btnNavReportes.FlatAppearance.MouseOverBackColor = btnNavDashboard.FlatAppearance.MouseOverBackColor;
            btnNavReportes.Font = btnNavDashboard.Font;
            btnNavReportes.ForeColor = btnNavDashboard.ForeColor;
            btnNavReportes.Size = btnNavDashboard.Size;
            btnNavReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReportes.Text = "  📄   Reportes";
            btnNavReportes.UseVisualStyleBackColor = false;
            btnNavReportes.Click += btnNavReportes_Click;
            pnlSidebar.Controls.Add(btnNavReportes);
        }

        // Muestra solo los botones del menu que le corresponden al rol del usuario
        private void AplicarRol()
        {
            // Botones en el orden en que salen en el menu, y el modulo de cada uno
            Button[] botones = { btnNavDashboard, btnNavArtistas, btnNavObras, btnNavGalerias,
                                 btnNavCompradores, btnNavTransacciones, btnNavEstructuras, btnNavReportes };
            string[] modulos = { "Dashboard", "Artistas", "Obras", "Galerias",
                                 "Compradores", "Transacciones", "Estructuras", "Reportes" };

            int y = btnNavDashboard.Top;
            for (int i = 0; i < botones.Length; i++)
            {
                if (Sesion.PuedeVer(modulos[i]))
                {
                    botones[i].Visible = true;
                    botones[i].Top = y;       // se acomodan uno debajo del otro, sin huecos
                    y = y + botones[i].Height;
                }
                else
                {
                    botones[i].Visible = false;
                }
            }

            lblVersion.Text = "v1.2.0  •  " + Sesion.NombreRol();
        }

        // ── Helpers ───────────────────────────────────────────────
        private void CargarPanel(UserControl panel)
        {
            pnlContenido.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(panel);
        }

        private void MarcarActivo(Button btn)
        {
            if (_btnActivo != null)
            {
                _btnActivo.BackColor = UIHelper.SidebarBg;
                _btnActivo.ForeColor = Color.FromArgb(190, 190, 215);
                _btnActivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }
            btn.BackColor = Color.FromArgb(46, 46, 75);
            btn.ForeColor = UIHelper.AccentGold;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _btnActivo = btn;
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Reemplaza esta ruta con la ubicación exacta donde tienes tu archivo ComercioArte.py
                string rutaScript = @"C:\ComercioArtes(1)\ComercioArtes\ComercioArtes.py";

                Process.Start("cmd.exe", $"/k python \"{rutaScript}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar el script de Python: " + ex.Message,
                                "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
