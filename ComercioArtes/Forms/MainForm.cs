using System;
using System.Drawing;
using System.Windows.Forms;
using ComercioArtes.Forms.Panels;
using ComercioArtes.Helpers;

namespace ComercioArtes.Forms
{
    public partial class MainForm : Form
    {
        private Button _btnActivo;

        public MainForm()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
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
    }
}
