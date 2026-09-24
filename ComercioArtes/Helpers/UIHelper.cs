using System.Drawing;
using System.Windows.Forms;

namespace ComercioArtes.Helpers
{
    internal static class UIHelper
    {
        // ── Paleta de colores central ─────────────────────────────
        public static readonly Color SidebarBg     = Color.FromArgb(26, 26, 46);
        public static readonly Color AccentGold    = Color.FromArgb(232, 184, 109);
        public static readonly Color ContentBg     = Color.FromArgb(244, 246, 249);
        public static readonly Color CardBg        = Color.White;
        public static readonly Color TextPrimary   = Color.FromArgb(31, 41, 55);
        public static readonly Color TextSecondary = Color.FromArgb(107, 114, 128);
        public static readonly Color Verde         = Color.FromArgb(16, 185, 129);
        public static readonly Color Indigo        = Color.FromArgb(99, 102, 241);
        public static readonly Color Ambar         = Color.FromArgb(245, 158, 11);
        public static readonly Color Rojo          = Color.FromArgb(239, 68, 68);
        public static readonly Color Cyan          = Color.FromArgb(6, 182, 212);

        // ── Fábrica de botones de acción ─────────────────────────
        public static Button BotonAccion(string texto, Color color, int ancho = 130)
        {
            var btn = new Button
            {
                Text = texto,
                Size = new Size(ancho, 34),
                FlatStyle = FlatStyle.Flat,
                BackColor = color,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9f),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(color, 0.1f);
            return btn;
        }

        // ── Estilo homogéneo para DataGridView ───────────────────
        public static void EstiloGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = SidebarBg;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9f, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding   = new Padding(8, 0, 0, 0);
            grid.ColumnHeadersHeight = 38;
            grid.RowTemplate.Height  = 34;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 252);
            grid.DefaultCellStyle.SelectionBackColor = AccentGold;
            grid.DefaultCellStyle.SelectionForeColor = SidebarBg;
            grid.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            grid.GridColor = Color.FromArgb(229, 231, 235);
        }

        // ── Tarjeta de estadística para el Dashboard ─────────────
        public static Panel TarjetaEstadistica(string titulo, string valor, Color acento,
                                                int x, int y, int ancho = 170, int alto = 90)
        {
            var p = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                BackColor = CardBg
            };
            p.Paint += (s, e) =>
                e.Graphics.FillRectangle(new SolidBrush(acento), 0, 0, 5, alto);

            p.Controls.Add(new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = TextSecondary,
                AutoSize = false,
                Size = new Size(ancho - 14, 22),
                Location = new Point(14, 10),
                TextAlign = ContentAlignment.MiddleLeft
            });
            p.Controls.Add(new Label
            {
                Text = valor,
                Font = new Font("Segoe UI", 20f, FontStyle.Bold),
                ForeColor = TextPrimary,
                AutoSize = false,
                Size = new Size(ancho - 14, 40),
                Location = new Point(14, 34),
                TextAlign = ContentAlignment.MiddleLeft
            });
            return p;
        }

        // ── Label de campo ────────────────────────────────────────
        public static Label LabelCampo(string texto, Point pos)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = TextPrimary,
                AutoSize = true,
                Location = pos
            };
        }

        // ── TextBox estándar ──────────────────────────────────────
        public static TextBox TextBoxCampo(Point pos, int ancho = 340, bool multilinea = false)
        {
            return new TextBox
            {
                Location = pos,
                Size = new Size(ancho, multilinea ? 65 : 30),
                Font = new Font("Segoe UI", 10f),
                BorderStyle = BorderStyle.FixedSingle,
                Multiline = multilinea
            };
        }

        // ── ComboBox estándar ─────────────────────────────────────
        public static ComboBox ComboCampo(Point pos, int ancho = 340)
        {
            return new ComboBox
            {
                Location = pos,
                Size = new Size(ancho, 30),
                Font = new Font("Segoe UI", 10f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
        }

        // ── Color de estado de obra ───────────────────────────────
        public static Color ColorEstadoObra(string estado)
        {
            return estado switch
            {
                "Disponible" => Color.FromArgb(220, 252, 231),
                "Reservada"  => Color.FromArgb(254, 243, 199),
                "Vendida"    => Color.FromArgb(254, 226, 226),
                _            => Color.White
            };
        }

        public static Color ColorEstadoFactura(string estado)
        {
            return estado switch
            {
                "Emitida"   => Color.FromArgb(220, 252, 231),
                "Cancelada" => Color.FromArgb(254, 226, 226),
                _           => Color.White
            };
        }
    }
}
