namespace ComercioArtes.Forms.Dialogs
{
    partial class ObraDialog
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
            this.lblTituloObra = new System.Windows.Forms.Label();
            this.txtTituloObra = new System.Windows.Forms.TextBox();
            this.lblDescObraLabel = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTecnicaLabel = new System.Windows.Forms.Label();
            this.cmbTecnica = new System.Windows.Forms.ComboBox();
            this.lblEstadoLabel = new System.Windows.Forms.Label();
            this.cmbEstadoObra = new System.Windows.Forms.ComboBox();
            this.lblDimensionesLabel = new System.Windows.Forms.Label();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.lblAnioLabel = new System.Windows.Forms.Label();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioLabel = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblArtistaLabel = new System.Windows.Forms.Label();
            this.cmbArtistaObra = new System.Windows.Forms.ComboBox();
            this.btnGuardarObra = new System.Windows.Forms.Button();
            this.btnCancelarObra = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(494, 62);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblSubtitleDlg
            // 
            this.lblSubtitleDlg.AutoSize = true;
            this.lblSubtitleDlg.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleDlg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblSubtitleDlg.Location = new System.Drawing.Point(16, 36);
            this.lblSubtitleDlg.Name = "lblSubtitleDlg";
            this.lblSubtitleDlg.Size = new System.Drawing.Size(164, 15);
            this.lblSubtitleDlg.TabIndex = 1;
            this.lblSubtitleDlg.Text = "Completa los datos de la obra";
            // 
            // lblTitleDlg
            // 
            this.lblTitleDlg.AutoSize = true;
            this.lblTitleDlg.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDlg.ForeColor = System.Drawing.Color.White;
            this.lblTitleDlg.Location = new System.Drawing.Point(16, 8);
            this.lblTitleDlg.Name = "lblTitleDlg";
            this.lblTitleDlg.Size = new System.Drawing.Size(54, 25);
            this.lblTitleDlg.TabIndex = 0;
            this.lblTitleDlg.Text = "Obra";
            // 
            // lblTituloObra
            // 
            this.lblTituloObra.AutoSize = true;
            this.lblTituloObra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTituloObra.Location = new System.Drawing.Point(28, 76);
            this.lblTituloObra.Name = "lblTituloObra";
            this.lblTituloObra.Size = new System.Drawing.Size(47, 15);
            this.lblTituloObra.TabIndex = 1;
            this.lblTituloObra.Text = "Título *";
            // 
            // txtTituloObra
            // 
            this.txtTituloObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloObra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloObra.Location = new System.Drawing.Point(28, 96);
            this.txtTituloObra.Name = "txtTituloObra";
            this.txtTituloObra.Size = new System.Drawing.Size(422, 25);
            this.txtTituloObra.TabIndex = 2;
            // 
            // lblDescObraLabel
            // 
            this.lblDescObraLabel.AutoSize = true;
            this.lblDescObraLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescObraLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDescObraLabel.Location = new System.Drawing.Point(28, 140);
            this.lblDescObraLabel.Name = "lblDescObraLabel";
            this.lblDescObraLabel.Size = new System.Drawing.Size(72, 15);
            this.lblDescObraLabel.TabIndex = 3;
            this.lblDescObraLabel.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(28, 160);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(422, 62);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblTecnicaLabel
            // 
            this.lblTecnicaLabel.AutoSize = true;
            this.lblTecnicaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnicaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTecnicaLabel.Location = new System.Drawing.Point(28, 236);
            this.lblTecnicaLabel.Name = "lblTecnicaLabel";
            this.lblTecnicaLabel.Size = new System.Drawing.Size(56, 15);
            this.lblTecnicaLabel.TabIndex = 5;
            this.lblTecnicaLabel.Text = "Técnica *";
            // 
            // cmbTecnica
            // 
            this.cmbTecnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTecnica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTecnica.Location = new System.Drawing.Point(28, 256);
            this.cmbTecnica.Name = "cmbTecnica";
            this.cmbTecnica.Size = new System.Drawing.Size(195, 25);
            this.cmbTecnica.TabIndex = 6;
            // 
            // lblEstadoLabel
            // 
            this.lblEstadoLabel.AutoSize = true;
            this.lblEstadoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblEstadoLabel.Location = new System.Drawing.Point(249, 236);
            this.lblEstadoLabel.Name = "lblEstadoLabel";
            this.lblEstadoLabel.Size = new System.Drawing.Size(43, 15);
            this.lblEstadoLabel.TabIndex = 7;
            this.lblEstadoLabel.Text = "Estado";
            // 
            // cmbEstadoObra
            // 
            this.cmbEstadoObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoObra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoObra.Location = new System.Drawing.Point(249, 256);
            this.cmbEstadoObra.Name = "cmbEstadoObra";
            this.cmbEstadoObra.Size = new System.Drawing.Size(173, 25);
            this.cmbEstadoObra.TabIndex = 8;
            // 
            // lblDimensionesLabel
            // 
            this.lblDimensionesLabel.AutoSize = true;
            this.lblDimensionesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensionesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDimensionesLabel.Location = new System.Drawing.Point(28, 302);
            this.lblDimensionesLabel.Name = "lblDimensionesLabel";
            this.lblDimensionesLabel.Size = new System.Drawing.Size(78, 15);
            this.lblDimensionesLabel.TabIndex = 9;
            this.lblDimensionesLabel.Text = "Dimensiones";
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDimensiones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensiones.Location = new System.Drawing.Point(28, 322);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(195, 25);
            this.txtDimensiones.TabIndex = 10;
            // 
            // lblAnioLabel
            // 
            this.lblAnioLabel.AutoSize = true;
            this.lblAnioLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblAnioLabel.Location = new System.Drawing.Point(249, 302);
            this.lblAnioLabel.Name = "lblAnioLabel";
            this.lblAnioLabel.Size = new System.Drawing.Size(29, 15);
            this.lblAnioLabel.TabIndex = 11;
            this.lblAnioLabel.Text = "Año";
            // 
            // numAnio
            // 
            this.numAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAnio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAnio.Location = new System.Drawing.Point(249, 322);
            this.numAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numAnio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(100, 25);
            this.numAnio.TabIndex = 12;
            this.numAnio.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // lblPrecioLabel
            // 
            this.lblPrecioLabel.AutoSize = true;
            this.lblPrecioLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPrecioLabel.Location = new System.Drawing.Point(28, 368);
            this.lblPrecioLabel.Name = "lblPrecioLabel";
            this.lblPrecioLabel.Size = new System.Drawing.Size(86, 15);
            this.lblPrecioLabel.TabIndex = 13;
            this.lblPrecioLabel.Text = "Precio (USD) *";
            // 
            // numPrecio
            // 
            this.numPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecio.Location = new System.Drawing.Point(28, 388);
            this.numPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(195, 25);
            this.numPrecio.TabIndex = 14;
            // 
            // lblArtistaLabel
            // 
            this.lblArtistaLabel.AutoSize = true;
            this.lblArtistaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblArtistaLabel.Location = new System.Drawing.Point(249, 368);
            this.lblArtistaLabel.Name = "lblArtistaLabel";
            this.lblArtistaLabel.Size = new System.Drawing.Size(52, 15);
            this.lblArtistaLabel.TabIndex = 15;
            this.lblArtistaLabel.Text = "Artista *";
            // 
            // cmbArtistaObra
            // 
            this.cmbArtistaObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtistaObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArtistaObra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtistaObra.Location = new System.Drawing.Point(249, 388);
            this.cmbArtistaObra.Name = "cmbArtistaObra";
            this.cmbArtistaObra.Size = new System.Drawing.Size(173, 25);
            this.cmbArtistaObra.TabIndex = 16;
            // 
            // btnGuardarObra
            // 
            this.btnGuardarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGuardarObra.FlatAppearance.BorderSize = 0;
            this.btnGuardarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarObra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarObra.ForeColor = System.Drawing.Color.White;
            this.btnGuardarObra.Location = new System.Drawing.Point(28, 434);
            this.btnGuardarObra.Name = "btnGuardarObra";
            this.btnGuardarObra.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarObra.TabIndex = 17;
            this.btnGuardarObra.Text = "💾  Guardar";
            this.btnGuardarObra.UseVisualStyleBackColor = false;
            this.btnGuardarObra.Click += new System.EventHandler(this.btnGuardarObra_Click);
            // 
            // btnCancelarObra
            // 
            this.btnCancelarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelarObra.FlatAppearance.BorderSize = 0;
            this.btnCancelarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarObra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarObra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarObra.Location = new System.Drawing.Point(193, 434);
            this.btnCancelarObra.Name = "btnCancelarObra";
            this.btnCancelarObra.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarObra.TabIndex = 18;
            this.btnCancelarObra.Text = "✕  Cancelar";
            this.btnCancelarObra.UseVisualStyleBackColor = false;
            this.btnCancelarObra.Click += new System.EventHandler(this.btnCancelarObra_Click);
            // 
            // ObraDialog
            // 
            this.AcceptButton = this.btnGuardarObra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(494, 490);
            this.Controls.Add(this.btnCancelarObra);
            this.Controls.Add(this.btnGuardarObra);
            this.Controls.Add(this.cmbArtistaObra);
            this.Controls.Add(this.lblArtistaLabel);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.lblPrecioLabel);
            this.Controls.Add(this.numAnio);
            this.Controls.Add(this.lblAnioLabel);
            this.Controls.Add(this.txtDimensiones);
            this.Controls.Add(this.lblDimensionesLabel);
            this.Controls.Add(this.cmbEstadoObra);
            this.Controls.Add(this.lblEstadoLabel);
            this.Controls.Add(this.cmbTecnica);
            this.Controls.Add(this.lblTecnicaLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescObraLabel);
            this.Controls.Add(this.txtTituloObra);
            this.Controls.Add(this.lblTituloObra);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObraDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obra";
            this.Load += new System.EventHandler(this.ObraDialog_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleDlg;
        private System.Windows.Forms.Label lblSubtitleDlg;
        private System.Windows.Forms.Label lblTituloObra;
        private System.Windows.Forms.TextBox txtTituloObra;
        private System.Windows.Forms.Label lblDescObraLabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTecnicaLabel;
        private System.Windows.Forms.ComboBox cmbTecnica;
        private System.Windows.Forms.Label lblEstadoLabel;
        private System.Windows.Forms.ComboBox cmbEstadoObra;
        private System.Windows.Forms.Label lblDimensionesLabel;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.Label lblAnioLabel;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Label lblPrecioLabel;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblArtistaLabel;
        private System.Windows.Forms.ComboBox cmbArtistaObra;
        private System.Windows.Forms.Button btnGuardarObra;
        private System.Windows.Forms.Button btnCancelarObra;
    }
}
