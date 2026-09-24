namespace ComercioArtes.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnNavTransacciones = new System.Windows.Forms.Button();
            this.btnNavCompradores = new System.Windows.Forms.Button();
            this.btnNavGalerias = new System.Windows.Forms.Button();
            this.btnNavObras = new System.Windows.Forms.Button();
            this.btnNavArtistas = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.pnlSeparadorNav = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.lblVersion);
            this.pnlSidebar.Controls.Add(this.btnNavTransacciones);
            this.pnlSidebar.Controls.Add(this.btnNavCompradores);
            this.pnlSidebar.Controls.Add(this.btnNavGalerias);
            this.pnlSidebar.Controls.Add(this.btnNavObras);
            this.pnlSidebar.Controls.Add(this.btnNavArtistas);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlSeparadorNav);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(225, 609);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComercioArtes.Properties.Resources.WhatsApp_Image_2026_06_13_at_9_05_31_AM;
            this.pictureBox1.Location = new System.Drawing.Point(18, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 581);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(225, 28);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "v1.0  •  Demo en memoria";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavTransacciones
            // 
            this.btnNavTransacciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNavTransacciones.FlatAppearance.BorderSize = 0;
            this.btnNavTransacciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnNavTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransacciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnNavTransacciones.Location = new System.Drawing.Point(0, 332);
            this.btnNavTransacciones.Name = "btnNavTransacciones";
            this.btnNavTransacciones.Size = new System.Drawing.Size(225, 52);
            this.btnNavTransacciones.TabIndex = 7;
            this.btnNavTransacciones.Text = "  💳   Transacciones";
            this.btnNavTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransacciones.UseVisualStyleBackColor = false;
            this.btnNavTransacciones.Click += new System.EventHandler(this.btnNavTransacciones_Click);
            // 
            // btnNavCompradores
            // 
            this.btnNavCompradores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNavCompradores.FlatAppearance.BorderSize = 0;
            this.btnNavCompradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnNavCompradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCompradores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCompradores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnNavCompradores.Location = new System.Drawing.Point(0, 280);
            this.btnNavCompradores.Name = "btnNavCompradores";
            this.btnNavCompradores.Size = new System.Drawing.Size(225, 52);
            this.btnNavCompradores.TabIndex = 6;
            this.btnNavCompradores.Text = "  🛒   Compradores";
            this.btnNavCompradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCompradores.UseVisualStyleBackColor = false;
            this.btnNavCompradores.Click += new System.EventHandler(this.btnNavCompradores_Click);
            // 
            // btnNavGalerias
            // 
            this.btnNavGalerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNavGalerias.FlatAppearance.BorderSize = 0;
            this.btnNavGalerias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnNavGalerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGalerias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavGalerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnNavGalerias.Location = new System.Drawing.Point(0, 228);
            this.btnNavGalerias.Name = "btnNavGalerias";
            this.btnNavGalerias.Size = new System.Drawing.Size(225, 52);
            this.btnNavGalerias.TabIndex = 5;
            this.btnNavGalerias.Text = "  🏛    Galerías";
            this.btnNavGalerias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavGalerias.UseVisualStyleBackColor = false;
            this.btnNavGalerias.Click += new System.EventHandler(this.btnNavGalerias_Click);
            // 
            // btnNavObras
            // 
            this.btnNavObras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNavObras.FlatAppearance.BorderSize = 0;
            this.btnNavObras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnNavObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavObras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavObras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnNavObras.Location = new System.Drawing.Point(0, 176);
            this.btnNavObras.Name = "btnNavObras";
            this.btnNavObras.Size = new System.Drawing.Size(225, 52);
            this.btnNavObras.TabIndex = 4;
            this.btnNavObras.Text = "  🖼    Obras";
            this.btnNavObras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavObras.UseVisualStyleBackColor = false;
            this.btnNavObras.Click += new System.EventHandler(this.btnNavObras_Click);
            // 
            // btnNavArtistas
            // 
            this.btnNavArtistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNavArtistas.FlatAppearance.BorderSize = 0;
            this.btnNavArtistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnNavArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavArtistas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavArtistas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnNavArtistas.Location = new System.Drawing.Point(0, 124);
            this.btnNavArtistas.Name = "btnNavArtistas";
            this.btnNavArtistas.Size = new System.Drawing.Size(225, 52);
            this.btnNavArtistas.TabIndex = 3;
            this.btnNavArtistas.Text = "  🎨   Artistas";
            this.btnNavArtistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavArtistas.UseVisualStyleBackColor = false;
            this.btnNavArtistas.Click += new System.EventHandler(this.btnNavArtistas_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(65)))));
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 72);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(225, 52);
            this.btnNavDashboard.TabIndex = 2;
            this.btnNavDashboard.Text = "  📊   Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // pnlSeparadorNav
            // 
            this.pnlSeparadorNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.pnlSeparadorNav.Location = new System.Drawing.Point(18, 64);
            this.pnlSeparadorNav.Name = "pnlSeparadorNav";
            this.pnlSeparadorNav.Size = new System.Drawing.Size(190, 1);
            this.pnlSeparadorNav.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblFecha);
            this.pnlHeader.Controls.Add(this.lblPaginaActual);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(225, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(803, 62);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(544, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(36, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "fecha";
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lblPaginaActual.Location = new System.Drawing.Point(22, 14);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(138, 32);
            this.lblPaginaActual.TabIndex = 0;
            this.lblPaginaActual.Text = "Dashboard";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(225, 62);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(22);
            this.pnlContenido.Size = new System.Drawing.Size(803, 547);
            this.pnlContenido.TabIndex = 2;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(999, 591);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComercioArtes — Sistema de Gestión";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSeparadorNav;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavArtistas;
        private System.Windows.Forms.Button btnNavObras;
        private System.Windows.Forms.Button btnNavGalerias;
        private System.Windows.Forms.Button btnNavCompradores;
        private System.Windows.Forms.Button btnNavTransacciones;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
