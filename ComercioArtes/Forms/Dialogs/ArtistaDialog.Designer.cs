namespace ComercioArtes.Forms.Dialogs
{
    partial class ArtistaDialog
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitleDlg = new System.Windows.Forms.Label();
            this.lblTitleDlg = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblBiografia = new System.Windows.Forms.Label();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.lblTrayectoria = new System.Windows.Forms.Label();
            this.txtTrayectoria = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlHeader.Controls.Add(this.lblSubtitleDlg);
            this.pnlHeader.Controls.Add(this.lblTitleDlg);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(464, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitleDlg
            // 
            this.lblSubtitleDlg.AutoSize = true;
            this.lblSubtitleDlg.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleDlg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblSubtitleDlg.Location = new System.Drawing.Point(16, 36);
            this.lblSubtitleDlg.Name = "lblSubtitleDlg";
            this.lblSubtitleDlg.Size = new System.Drawing.Size(163, 15);
            this.lblSubtitleDlg.TabIndex = 1;
            this.lblSubtitleDlg.Text = "Completa los datos del artista";
            // 
            // lblTitleDlg
            // 
            this.lblTitleDlg.AutoSize = true;
            this.lblTitleDlg.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDlg.ForeColor = System.Drawing.Color.White;
            this.lblTitleDlg.Location = new System.Drawing.Point(16, 8);
            this.lblTitleDlg.Name = "lblTitleDlg";
            this.lblTitleDlg.Size = new System.Drawing.Size(70, 25);
            this.lblTitleDlg.TabIndex = 0;
            this.lblTitleDlg.Text = "Artista";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNombre.Location = new System.Drawing.Point(28, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre *";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(28, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(408, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCorreo.Location = new System.Drawing.Point(28, 140);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(119, 15);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo electrónico *";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(28, 160);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(408, 25);
            this.txtCorreo.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTelefono.Location = new System.Drawing.Point(28, 204);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 15);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(28, 224);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(190, 25);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPais.Location = new System.Drawing.Point(234, 204);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 15);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "País *";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            "Colombia",
            "Costa Rica",
            "Cuba",
            "Ecuador",
            "El Salvador",
            "España",
            "Guatemala",
            "Honduras",
            "México",
            "Nicaragua",
            "Panamá",
            "Paraguay",
            "Perú",
            "Puerto Rico",
            "República Dominicana",
            "Uruguay",
            "Venezuela",
            "Alemania",
            "China",
            "Estados Unidos",
            "Francia",
            "Italia",
            "Japón",
            "Portugal",
            "Reino Unido",
            "Otro"});
            this.cmbPais.Location = new System.Drawing.Point(234, 224);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(202, 25);
            this.cmbPais.TabIndex = 8;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiografia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblBiografia.Location = new System.Drawing.Point(28, 268);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(57, 15);
            this.lblBiografia.TabIndex = 9;
            this.lblBiografia.Text = "Biografía";
            // 
            // txtBiografia
            // 
            this.txtBiografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBiografia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiografia.Location = new System.Drawing.Point(28, 288);
            this.txtBiografia.Multiline = true;
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(408, 62);
            this.txtBiografia.TabIndex = 10;
            // 
            // lblTrayectoria
            // 
            this.lblTrayectoria.AutoSize = true;
            this.lblTrayectoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrayectoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTrayectoria.Location = new System.Drawing.Point(28, 364);
            this.lblTrayectoria.Name = "lblTrayectoria";
            this.lblTrayectoria.Size = new System.Drawing.Size(116, 15);
            this.lblTrayectoria.TabIndex = 11;
            this.lblTrayectoria.Text = "Trayectoria artística";
            // 
            // txtTrayectoria
            // 
            this.txtTrayectoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrayectoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrayectoria.Location = new System.Drawing.Point(28, 384);
            this.txtTrayectoria.Multiline = true;
            this.txtTrayectoria.Name = "txtTrayectoria";
            this.txtTrayectoria.Size = new System.Drawing.Size(408, 62);
            this.txtTrayectoria.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(28, 462);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "💾  Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(190, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "✕  Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ArtistaDialog
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(464, 518);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTrayectoria);
            this.Controls.Add(this.lblTrayectoria);
            this.Controls.Add(this.txtBiografia);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtistaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artista";
            this.Load += new System.EventHandler(this.ArtistaDialog_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleDlg;
        private System.Windows.Forms.Label lblSubtitleDlg;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblBiografia;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.Label lblTrayectoria;
        private System.Windows.Forms.TextBox txtTrayectoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
