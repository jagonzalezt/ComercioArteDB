namespace ComercioArtes.Forms.Dialogs
{
    partial class SeleccionarObraDialog
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
            this.gridSelObra = new System.Windows.Forms.DataGridView();
            this.colIdSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtistaSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTecnicaSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSel = new System.Windows.Forms.Button();
            this.btnCancelarSel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelObra)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(574, 62);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitleDlg
            //
            this.lblTitleDlg.AutoSize = true;
            this.lblTitleDlg.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDlg.ForeColor = System.Drawing.Color.White;
            this.lblTitleDlg.Location = new System.Drawing.Point(16, 8);
            this.lblTitleDlg.Name = "lblTitleDlg";
            this.lblTitleDlg.TabIndex = 0;
            this.lblTitleDlg.Text = "Seleccionar Obra";
            //
            // lblSubtitleDlg
            //
            this.lblSubtitleDlg.AutoSize = true;
            this.lblSubtitleDlg.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleDlg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblSubtitleDlg.Location = new System.Drawing.Point(16, 36);
            this.lblSubtitleDlg.Name = "lblSubtitleDlg";
            this.lblSubtitleDlg.TabIndex = 1;
            this.lblSubtitleDlg.Text = "Selecciona la obra que deseas agregar";
            //
            // gridSelObra
            //
            this.gridSelObra.AllowUserToAddRows = false;
            this.gridSelObra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSelObra.BackgroundColor = System.Drawing.Color.White;
            this.gridSelObra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSelObra.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridSelObra.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSelObra.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridSelObra.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridSelObra.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridSelObra.ColumnHeadersHeight = 38;
            this.gridSelObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSelObra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdSel, this.colTituloSel, this.colArtistaSel,
                this.colTecnicaSel, this.colPrecioSel});
            this.gridSelObra.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            this.gridSelObra.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridSelObra.EnableHeadersVisualStyles = false;
            this.gridSelObra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSelObra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridSelObra.Location = new System.Drawing.Point(16, 72);
            this.gridSelObra.Name = "gridSelObra";
            this.gridSelObra.ReadOnly = true;
            this.gridSelObra.RowHeadersVisible = false;
            this.gridSelObra.RowTemplate.Height = 34;
            this.gridSelObra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSelObra.Size = new System.Drawing.Size(540, 250);
            this.gridSelObra.TabIndex = 1;
            //
            // colIdSel
            //
            this.colIdSel.FillWeight = 8F;
            this.colIdSel.HeaderText = "ID";
            this.colIdSel.Name = "colIdSel";
            this.colIdSel.ReadOnly = true;
            //
            // colTituloSel
            //
            this.colTituloSel.FillWeight = 35F;
            this.colTituloSel.HeaderText = "Título";
            this.colTituloSel.Name = "colTituloSel";
            this.colTituloSel.ReadOnly = true;
            //
            // colArtistaSel
            //
            this.colArtistaSel.FillWeight = 28F;
            this.colArtistaSel.HeaderText = "Artista";
            this.colArtistaSel.Name = "colArtistaSel";
            this.colArtistaSel.ReadOnly = true;
            //
            // colTecnicaSel
            //
            this.colTecnicaSel.FillWeight = 16F;
            this.colTecnicaSel.HeaderText = "Técnica";
            this.colTecnicaSel.Name = "colTecnicaSel";
            this.colTecnicaSel.ReadOnly = true;
            //
            // colPrecioSel
            //
            this.colPrecioSel.FillWeight = 13F;
            this.colPrecioSel.HeaderText = "Precio";
            this.colPrecioSel.Name = "colPrecioSel";
            this.colPrecioSel.ReadOnly = true;
            //
            // btnAgregarSel
            //
            this.btnAgregarSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnAgregarSel.FlatAppearance.BorderSize = 0;
            this.btnAgregarSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSel.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSel.Location = new System.Drawing.Point(16, 334);
            this.btnAgregarSel.Name = "btnAgregarSel";
            this.btnAgregarSel.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarSel.TabIndex = 2;
            this.btnAgregarSel.Text = "＋ Agregar";
            this.btnAgregarSel.UseVisualStyleBackColor = false;
            this.btnAgregarSel.Click += new System.EventHandler(this.btnAgregarSel_Click);
            //
            // btnCancelarSel
            //
            this.btnCancelarSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelarSel.FlatAppearance.BorderSize = 0;
            this.btnCancelarSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSel.ForeColor = System.Drawing.Color.White;
            this.btnCancelarSel.Location = new System.Drawing.Point(178, 334);
            this.btnCancelarSel.Name = "btnCancelarSel";
            this.btnCancelarSel.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarSel.TabIndex = 3;
            this.btnCancelarSel.Text = "✕  Cancelar";
            this.btnCancelarSel.UseVisualStyleBackColor = false;
            this.btnCancelarSel.Click += new System.EventHandler(this.btnCancelarSel_Click);
            //
            // SeleccionarObraDialog
            //
            this.AcceptButton = this.btnAgregarSel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(574, 390);
            this.Controls.Add(this.btnCancelarSel);
            this.Controls.Add(this.btnAgregarSel);
            this.Controls.Add(this.gridSelObra);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionarObraDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar Obra";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelObra)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleDlg;
        private System.Windows.Forms.Label lblSubtitleDlg;
        private System.Windows.Forms.DataGridView gridSelObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtistaSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnicaSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioSel;
        private System.Windows.Forms.Button btnAgregarSel;
        private System.Windows.Forms.Button btnCancelarSel;
    }
}
