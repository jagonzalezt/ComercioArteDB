namespace ComercioArtes.Forms.Dialogs
{
    partial class FacturaDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitleDlg = new System.Windows.Forms.Label();
            this.lblTitleDlg = new System.Windows.Forms.Label();
            this.lblComprador = new System.Windows.Forms.Label();
            this.cmbComprador = new System.Windows.Forms.ComboBox();
            this.lblObrasFactura = new System.Windows.Forms.Label();
            this.gridDetalles = new System.Windows.Forms.DataGridView();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarObra = new System.Windows.Forms.Button();
            this.btnQuitarObra = new System.Windows.Forms.Button();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnCancelarFact = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(648, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitleDlg
            // 
            this.lblSubtitleDlg.AutoSize = true;
            this.lblSubtitleDlg.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleDlg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblSubtitleDlg.Location = new System.Drawing.Point(16, 36);
            this.lblSubtitleDlg.Name = "lblSubtitleDlg";
            this.lblSubtitleDlg.Size = new System.Drawing.Size(282, 15);
            this.lblSubtitleDlg.TabIndex = 1;
            this.lblSubtitleDlg.Text = "Selecciona comprador y agrega las obras de la venta";
            // 
            // lblTitleDlg
            // 
            this.lblTitleDlg.AutoSize = true;
            this.lblTitleDlg.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDlg.ForeColor = System.Drawing.Color.White;
            this.lblTitleDlg.Location = new System.Drawing.Point(16, 8);
            this.lblTitleDlg.Name = "lblTitleDlg";
            this.lblTitleDlg.Size = new System.Drawing.Size(134, 25);
            this.lblTitleDlg.TabIndex = 0;
            this.lblTitleDlg.Text = "Nueva Factura";
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblComprador.Location = new System.Drawing.Point(28, 76);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(77, 15);
            this.lblComprador.TabIndex = 1;
            this.lblComprador.Text = "Comprador *";
            // 
            // cmbComprador
            // 
            this.cmbComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComprador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComprador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComprador.Location = new System.Drawing.Point(28, 96);
            this.cmbComprador.Name = "cmbComprador";
            this.cmbComprador.Size = new System.Drawing.Size(580, 25);
            this.cmbComprador.TabIndex = 2;
            // 
            // lblObrasFactura
            // 
            this.lblObrasFactura.AutoSize = true;
            this.lblObrasFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrasFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblObrasFactura.Location = new System.Drawing.Point(28, 142);
            this.lblObrasFactura.Name = "lblObrasFactura";
            this.lblObrasFactura.Size = new System.Drawing.Size(111, 15);
            this.lblObrasFactura.TabIndex = 3;
            this.lblObrasFactura.Text = "Obras en la factura";
            // 
            // gridDetalles
            // 
            this.gridDetalles.AllowUserToAddRows = false;
            this.gridDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalles.BackgroundColor = System.Drawing.Color.White;
            this.gridDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetalles.ColumnHeadersHeight = 36;
            this.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colArtista,
            this.colPrecio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetalles.EnableHeadersVisualStyles = false;
            this.gridDetalles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetalles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridDetalles.Location = new System.Drawing.Point(28, 164);
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.ReadOnly = true;
            this.gridDetalles.RowHeadersVisible = false;
            this.gridDetalles.RowTemplate.Height = 32;
            this.gridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalles.Size = new System.Drawing.Size(456, 218);
            this.gridDetalles.TabIndex = 4;
            this.gridDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalles_CellContentClick);
            // 
            // colTitulo
            // 
            this.colTitulo.FillWeight = 44F;
            this.colTitulo.HeaderText = "Obra";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // colArtista
            // 
            this.colArtista.FillWeight = 34F;
            this.colArtista.HeaderText = "Artista";
            this.colArtista.Name = "colArtista";
            this.colArtista.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 22F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // btnAgregarObra
            // 
            this.btnAgregarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnAgregarObra.FlatAppearance.BorderSize = 0;
            this.btnAgregarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarObra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarObra.ForeColor = System.Drawing.Color.White;
            this.btnAgregarObra.Location = new System.Drawing.Point(496, 164);
            this.btnAgregarObra.Name = "btnAgregarObra";
            this.btnAgregarObra.Size = new System.Drawing.Size(130, 36);
            this.btnAgregarObra.TabIndex = 5;
            this.btnAgregarObra.Text = "＋ Agregar obra";
            this.btnAgregarObra.UseVisualStyleBackColor = false;
            this.btnAgregarObra.Click += new System.EventHandler(this.btnAgregarObra_Click);
            // 
            // btnQuitarObra
            // 
            this.btnQuitarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnQuitarObra.FlatAppearance.BorderSize = 0;
            this.btnQuitarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarObra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarObra.ForeColor = System.Drawing.Color.White;
            this.btnQuitarObra.Location = new System.Drawing.Point(496, 210);
            this.btnQuitarObra.Name = "btnQuitarObra";
            this.btnQuitarObra.Size = new System.Drawing.Size(130, 36);
            this.btnQuitarObra.TabIndex = 6;
            this.btnQuitarObra.Text = "✕ Quitar obra";
            this.btnQuitarObra.UseVisualStyleBackColor = false;
            this.btnQuitarObra.Click += new System.EventHandler(this.btnQuitarObra_Click);
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(28, 402);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(58, 20);
            this.lblTotalLabel.TabIndex = 7;
            this.lblTotalLabel.Text = "TOTAL:";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblTotalValor.Location = new System.Drawing.Point(120, 396);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(77, 32);
            this.lblTotalValor.TabIndex = 8;
            this.lblTotalValor.Text = "$0.00";
            // 
            // btnEmitir
            // 
            this.btnEmitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnEmitir.FlatAppearance.BorderSize = 0;
            this.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.ForeColor = System.Drawing.Color.White;
            this.btnEmitir.Location = new System.Drawing.Point(28, 454);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(160, 40);
            this.btnEmitir.TabIndex = 9;
            this.btnEmitir.Text = "✔  Emitir Factura";
            this.btnEmitir.UseVisualStyleBackColor = false;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // btnCancelarFact
            // 
            this.btnCancelarFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelarFact.FlatAppearance.BorderSize = 0;
            this.btnCancelarFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFact.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFact.Location = new System.Drawing.Point(200, 454);
            this.btnCancelarFact.Name = "btnCancelarFact";
            this.btnCancelarFact.Size = new System.Drawing.Size(140, 40);
            this.btnCancelarFact.TabIndex = 10;
            this.btnCancelarFact.Text = "✕  Cancelar";
            this.btnCancelarFact.UseVisualStyleBackColor = false;
            this.btnCancelarFact.Click += new System.EventHandler(this.btnCancelarFact_Click);
            // 
            // FacturaDialog
            // 
            this.AcceptButton = this.btnEmitir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(648, 510);
            this.Controls.Add(this.btnCancelarFact);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.btnQuitarObra);
            this.Controls.Add(this.btnAgregarObra);
            this.Controls.Add(this.gridDetalles);
            this.Controls.Add(this.lblObrasFactura);
            this.Controls.Add(this.cmbComprador);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Factura";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleDlg;
        private System.Windows.Forms.Label lblSubtitleDlg;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.ComboBox cmbComprador;
        private System.Windows.Forms.Label lblObrasFactura;
        private System.Windows.Forms.DataGridView gridDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Button btnAgregarObra;
        private System.Windows.Forms.Button btnQuitarObra;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnCancelarFact;
    }
}
