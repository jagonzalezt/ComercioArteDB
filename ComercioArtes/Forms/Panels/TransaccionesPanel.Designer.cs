namespace ComercioArtes.Forms.Panels
{
    partial class TransaccionesPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnCancelarTrans = new System.Windows.Forms.Button();
            this.btnNuevaTrans = new System.Windows.Forms.Button();
            this.lblTransacciones = new System.Windows.Forms.Label();
            this.gridTransacciones = new System.Windows.Forms.DataGridView();
            this.colIdTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumObras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetalleTrans = new System.Windows.Forms.Label();
            this.gridDetalle = new System.Windows.Forms.DataGridView();
            this.colIdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObraDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtistaDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlToolbar.Controls.Add(this.btnCancelarTrans);
            this.pnlToolbar.Controls.Add(this.btnNuevaTrans);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(980, 46);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnCancelarTrans
            // 
            this.btnCancelarTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelarTrans.FlatAppearance.BorderSize = 0;
            this.btnCancelarTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTrans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTrans.ForeColor = System.Drawing.Color.White;
            this.btnCancelarTrans.Location = new System.Drawing.Point(166, 6);
            this.btnCancelarTrans.Name = "btnCancelarTrans";
            this.btnCancelarTrans.Size = new System.Drawing.Size(140, 34);
            this.btnCancelarTrans.TabIndex = 1;
            this.btnCancelarTrans.Text = "✕  Anular Factura";
            this.btnCancelarTrans.UseVisualStyleBackColor = false;
            this.btnCancelarTrans.Click += new System.EventHandler(this.btnCancelarTrans_Click);
            // 
            // btnNuevaTrans
            // 
            this.btnNuevaTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnNuevaTrans.FlatAppearance.BorderSize = 0;
            this.btnNuevaTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTrans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTrans.ForeColor = System.Drawing.Color.White;
            this.btnNuevaTrans.Location = new System.Drawing.Point(0, 6);
            this.btnNuevaTrans.Name = "btnNuevaTrans";
            this.btnNuevaTrans.Size = new System.Drawing.Size(155, 34);
            this.btnNuevaTrans.TabIndex = 0;
            this.btnNuevaTrans.Text = "＋ Nueva Factura";
            this.btnNuevaTrans.UseVisualStyleBackColor = false;
            this.btnNuevaTrans.Click += new System.EventHandler(this.btnNuevaTrans_Click);
            // 
            // lblTransacciones
            // 
            this.lblTransacciones.AutoSize = true;
            this.lblTransacciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTransacciones.Location = new System.Drawing.Point(0, 54);
            this.lblTransacciones.Name = "lblTransacciones";
            this.lblTransacciones.Size = new System.Drawing.Size(150, 20);
            this.lblTransacciones.TabIndex = 1;
            this.lblTransacciones.Text = "Historial de facturas";
            // 
            // gridTransacciones
            // 
            this.gridTransacciones.AllowUserToAddRows = false;
            this.gridTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransacciones.BackgroundColor = System.Drawing.Color.White;
            this.gridTransacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTransacciones.ColumnHeadersHeight = 38;
            this.gridTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTrans,
            this.colFecha,
            this.colComprador,
            this.colNumObras,
            this.colMonto,
            this.colEstadoTrans});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTransacciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTransacciones.EnableHeadersVisualStyles = false;
            this.gridTransacciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridTransacciones.Location = new System.Drawing.Point(0, 76);
            this.gridTransacciones.Name = "gridTransacciones";
            this.gridTransacciones.ReadOnly = true;
            this.gridTransacciones.RowHeadersVisible = false;
            this.gridTransacciones.RowTemplate.Height = 34;
            this.gridTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransacciones.Size = new System.Drawing.Size(980, 290);
            this.gridTransacciones.TabIndex = 2;
            this.gridTransacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransacciones_CellContentClick);
            this.gridTransacciones.SelectionChanged += new System.EventHandler(this.gridTransacciones_SelectionChanged);
            // 
            // colIdTrans
            // 
            this.colIdTrans.FillWeight = 5F;
            this.colIdTrans.HeaderText = "ID";
            this.colIdTrans.Name = "colIdTrans";
            this.colIdTrans.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 18F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colComprador
            // 
            this.colComprador.FillWeight = 26F;
            this.colComprador.HeaderText = "Comprador";
            this.colComprador.Name = "colComprador";
            this.colComprador.ReadOnly = true;
            // 
            // colNumObras
            // 
            this.colNumObras.FillWeight = 10F;
            this.colNumObras.HeaderText = "# Obras";
            this.colNumObras.Name = "colNumObras";
            this.colNumObras.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.FillWeight = 15F;
            this.colMonto.HeaderText = "Total";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colEstadoTrans
            // 
            this.colEstadoTrans.FillWeight = 14F;
            this.colEstadoTrans.HeaderText = "Estado";
            this.colEstadoTrans.Name = "colEstadoTrans";
            this.colEstadoTrans.ReadOnly = true;
            // 
            // lblDetalleTrans
            // 
            this.lblDetalleTrans.AutoSize = true;
            this.lblDetalleTrans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDetalleTrans.Location = new System.Drawing.Point(0, 376);
            this.lblDetalleTrans.Name = "lblDetalleTrans";
            this.lblDetalleTrans.Size = new System.Drawing.Size(241, 20);
            this.lblDetalleTrans.TabIndex = 3;
            this.lblDetalleTrans.Text = "Detalle de la factura seleccionada";
            // 
            // gridDetalle
            // 
            this.gridDetalle.AllowUserToAddRows = false;
            this.gridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetalle.BackgroundColor = System.Drawing.Color.White;
            this.gridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetalle.ColumnHeadersHeight = 38;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdDetalle,
            this.colObraDetalle,
            this.colArtistaDetalle,
            this.colPrecioVenta});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridDetalle.EnableHeadersVisualStyles = false;
            this.gridDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridDetalle.Location = new System.Drawing.Point(0, 400);
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.ReadOnly = true;
            this.gridDetalle.RowHeadersVisible = false;
            this.gridDetalle.RowTemplate.Height = 34;
            this.gridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalle.Size = new System.Drawing.Size(980, 155);
            this.gridDetalle.TabIndex = 4;
            // 
            // colIdDetalle
            // 
            this.colIdDetalle.FillWeight = 10F;
            this.colIdDetalle.HeaderText = "# Detalle";
            this.colIdDetalle.Name = "colIdDetalle";
            this.colIdDetalle.ReadOnly = true;
            // 
            // colObraDetalle
            // 
            this.colObraDetalle.FillWeight = 40F;
            this.colObraDetalle.HeaderText = "Obra";
            this.colObraDetalle.Name = "colObraDetalle";
            this.colObraDetalle.ReadOnly = true;
            // 
            // colArtistaDetalle
            // 
            this.colArtistaDetalle.FillWeight = 28F;
            this.colArtistaDetalle.HeaderText = "Artista";
            this.colArtistaDetalle.Name = "colArtistaDetalle";
            this.colArtistaDetalle.ReadOnly = true;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.FillWeight = 22F;
            this.colPrecioVenta.HeaderText = "Precio Venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            // 
            // TransaccionesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.lblDetalleTrans);
            this.Controls.Add(this.gridTransacciones);
            this.Controls.Add(this.lblTransacciones);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "TransaccionesPanel";
            this.Size = new System.Drawing.Size(980, 580);
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnNuevaTrans;
        private System.Windows.Forms.Button btnCancelarTrans;
        private System.Windows.Forms.Label lblTransacciones;
        private System.Windows.Forms.DataGridView gridTransacciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumObras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoTrans;
        private System.Windows.Forms.Label lblDetalleTrans;
        private System.Windows.Forms.DataGridView gridDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtistaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
    }
}
