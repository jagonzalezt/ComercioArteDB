namespace ComercioArtes.Forms.Panels
{
    partial class GaleriasPanel
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnQuitarObra = new System.Windows.Forms.Button();
            this.btnAgregarObra = new System.Windows.Forms.Button();
            this.btnEliminarGaleria = new System.Windows.Forms.Button();
            this.btnEditarGaleria = new System.Windows.Forms.Button();
            this.btnNuevaGaleria = new System.Windows.Forms.Button();
            this.lblGalerias = new System.Windows.Forms.Label();
            this.gridGalerias = new System.Windows.Forms.DataGridView();
            this.colIdGal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreGal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantObras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoGal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblObrasEnGaleria = new System.Windows.Forms.Label();
            this.gridObrasGaleria = new System.Windows.Forms.DataGridView();
            this.colIdObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtistaObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGalerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridObrasGaleria)).BeginInit();
            this.SuspendLayout();
            //
            // pnlToolbar
            //
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlToolbar.Controls.Add(this.btnQuitarObra);
            this.pnlToolbar.Controls.Add(this.btnAgregarObra);
            this.pnlToolbar.Controls.Add(this.btnEliminarGaleria);
            this.pnlToolbar.Controls.Add(this.btnEditarGaleria);
            this.pnlToolbar.Controls.Add(this.btnNuevaGaleria);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(980, 46);
            this.pnlToolbar.TabIndex = 0;
            //
            // btnNuevaGaleria
            //
            this.btnNuevaGaleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnNuevaGaleria.FlatAppearance.BorderSize = 0;
            this.btnNuevaGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaGaleria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaGaleria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaGaleria.Location = new System.Drawing.Point(0, 6);
            this.btnNuevaGaleria.Name = "btnNuevaGaleria";
            this.btnNuevaGaleria.Size = new System.Drawing.Size(145, 34);
            this.btnNuevaGaleria.TabIndex = 0;
            this.btnNuevaGaleria.Text = "＋ Nueva Galería";
            this.btnNuevaGaleria.UseVisualStyleBackColor = false;
            this.btnNuevaGaleria.Click += new System.EventHandler(this.btnNuevaGaleria_Click);
            //
            // btnEditarGaleria
            //
            this.btnEditarGaleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnEditarGaleria.FlatAppearance.BorderSize = 0;
            this.btnEditarGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGaleria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGaleria.ForeColor = System.Drawing.Color.White;
            this.btnEditarGaleria.Location = new System.Drawing.Point(156, 6);
            this.btnEditarGaleria.Name = "btnEditarGaleria";
            this.btnEditarGaleria.Size = new System.Drawing.Size(110, 34);
            this.btnEditarGaleria.TabIndex = 1;
            this.btnEditarGaleria.Text = "✎  Editar";
            this.btnEditarGaleria.UseVisualStyleBackColor = false;
            this.btnEditarGaleria.Click += new System.EventHandler(this.btnEditarGaleria_Click);
            //
            // btnEliminarGaleria
            //
            this.btnEliminarGaleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEliminarGaleria.FlatAppearance.BorderSize = 0;
            this.btnEliminarGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGaleria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGaleria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarGaleria.Location = new System.Drawing.Point(277, 6);
            this.btnEliminarGaleria.Name = "btnEliminarGaleria";
            this.btnEliminarGaleria.Size = new System.Drawing.Size(110, 34);
            this.btnEliminarGaleria.TabIndex = 2;
            this.btnEliminarGaleria.Text = "✕  Eliminar";
            this.btnEliminarGaleria.UseVisualStyleBackColor = false;
            this.btnEliminarGaleria.Click += new System.EventHandler(this.btnEliminarGaleria_Click);
            //
            // btnAgregarObra
            //
            this.btnAgregarObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnAgregarObra.FlatAppearance.BorderSize = 0;
            this.btnAgregarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarObra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarObra.ForeColor = System.Drawing.Color.White;
            this.btnAgregarObra.Location = new System.Drawing.Point(400, 6);
            this.btnAgregarObra.Name = "btnAgregarObra";
            this.btnAgregarObra.Size = new System.Drawing.Size(145, 34);
            this.btnAgregarObra.TabIndex = 3;
            this.btnAgregarObra.Text = "🖼  Agregar obra";
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
            this.btnQuitarObra.Location = new System.Drawing.Point(556, 6);
            this.btnQuitarObra.Name = "btnQuitarObra";
            this.btnQuitarObra.Size = new System.Drawing.Size(130, 34);
            this.btnQuitarObra.TabIndex = 4;
            this.btnQuitarObra.Text = "✕  Quitar obra";
            this.btnQuitarObra.UseVisualStyleBackColor = false;
            this.btnQuitarObra.Click += new System.EventHandler(this.btnQuitarObra_Click);
            //
            // lblGalerias
            //
            this.lblGalerias.AutoSize = true;
            this.lblGalerias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblGalerias.Location = new System.Drawing.Point(0, 54);
            this.lblGalerias.Name = "lblGalerias";
            this.lblGalerias.TabIndex = 1;
            this.lblGalerias.Text = "Galerías";
            //
            // gridGalerias
            //
            this.gridGalerias.AllowUserToAddRows = false;
            this.gridGalerias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGalerias.BackgroundColor = System.Drawing.Color.White;
            this.gridGalerias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGalerias.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridGalerias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGalerias.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridGalerias.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridGalerias.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridGalerias.ColumnHeadersHeight = 38;
            this.gridGalerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridGalerias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdGal, this.colNombreGal, this.colUbicacion,
                this.colCantObras, this.colTelefonoGal});
            this.gridGalerias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            this.gridGalerias.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridGalerias.EnableHeadersVisualStyles = false;
            this.gridGalerias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGalerias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridGalerias.Location = new System.Drawing.Point(0, 76);
            this.gridGalerias.Name = "gridGalerias";
            this.gridGalerias.ReadOnly = true;
            this.gridGalerias.RowHeadersVisible = false;
            this.gridGalerias.RowTemplate.Height = 34;
            this.gridGalerias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGalerias.Size = new System.Drawing.Size(400, 480);
            this.gridGalerias.TabIndex = 2;
            this.gridGalerias.SelectionChanged += new System.EventHandler(this.gridGalerias_SelectionChanged);
            //
            // colIdGal
            //
            this.colIdGal.FillWeight = 8F;
            this.colIdGal.HeaderText = "ID";
            this.colIdGal.Name = "colIdGal";
            this.colIdGal.ReadOnly = true;
            //
            // colNombreGal
            //
            this.colNombreGal.FillWeight = 30F;
            this.colNombreGal.HeaderText = "Nombre";
            this.colNombreGal.Name = "colNombreGal";
            this.colNombreGal.ReadOnly = true;
            //
            // colUbicacion
            //
            this.colUbicacion.FillWeight = 35F;
            this.colUbicacion.HeaderText = "Ubicación";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            //
            // colCantObras
            //
            this.colCantObras.FillWeight = 12F;
            this.colCantObras.HeaderText = "# Obras";
            this.colCantObras.Name = "colCantObras";
            this.colCantObras.ReadOnly = true;
            //
            // colTelefonoGal
            //
            this.colTelefonoGal.FillWeight = 15F;
            this.colTelefonoGal.HeaderText = "Teléfono";
            this.colTelefonoGal.Name = "colTelefonoGal";
            this.colTelefonoGal.ReadOnly = true;
            //
            // lblObrasEnGaleria
            //
            this.lblObrasEnGaleria.AutoSize = true;
            this.lblObrasEnGaleria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrasEnGaleria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblObrasEnGaleria.Location = new System.Drawing.Point(415, 54);
            this.lblObrasEnGaleria.Name = "lblObrasEnGaleria";
            this.lblObrasEnGaleria.TabIndex = 3;
            this.lblObrasEnGaleria.Text = "Obras en la galería";
            //
            // gridObrasGaleria
            //
            this.gridObrasGaleria.AllowUserToAddRows = false;
            this.gridObrasGaleria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridObrasGaleria.BackgroundColor = System.Drawing.Color.White;
            this.gridObrasGaleria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridObrasGaleria.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridObrasGaleria.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridObrasGaleria.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridObrasGaleria.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridObrasGaleria.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridObrasGaleria.ColumnHeadersHeight = 38;
            this.gridObrasGaleria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridObrasGaleria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdObra, this.colTituloObra, this.colArtistaObra,
                this.colPrecioObra, this.colEstadoObra});
            this.gridObrasGaleria.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            this.gridObrasGaleria.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.gridObrasGaleria.EnableHeadersVisualStyles = false;
            this.gridObrasGaleria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridObrasGaleria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridObrasGaleria.Location = new System.Drawing.Point(415, 76);
            this.gridObrasGaleria.Name = "gridObrasGaleria";
            this.gridObrasGaleria.ReadOnly = true;
            this.gridObrasGaleria.RowHeadersVisible = false;
            this.gridObrasGaleria.RowTemplate.Height = 34;
            this.gridObrasGaleria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridObrasGaleria.Size = new System.Drawing.Size(550, 480);
            this.gridObrasGaleria.TabIndex = 4;
            //
            // colIdObra
            //
            this.colIdObra.FillWeight = 8F;
            this.colIdObra.HeaderText = "ID";
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.ReadOnly = true;
            //
            // colTituloObra
            //
            this.colTituloObra.FillWeight = 32F;
            this.colTituloObra.HeaderText = "Título";
            this.colTituloObra.Name = "colTituloObra";
            this.colTituloObra.ReadOnly = true;
            //
            // colArtistaObra
            //
            this.colArtistaObra.FillWeight = 28F;
            this.colArtistaObra.HeaderText = "Artista";
            this.colArtistaObra.Name = "colArtistaObra";
            this.colArtistaObra.ReadOnly = true;
            //
            // colPrecioObra
            //
            this.colPrecioObra.FillWeight = 17F;
            this.colPrecioObra.HeaderText = "Precio";
            this.colPrecioObra.Name = "colPrecioObra";
            this.colPrecioObra.ReadOnly = true;
            //
            // colEstadoObra
            //
            this.colEstadoObra.FillWeight = 15F;
            this.colEstadoObra.HeaderText = "Estado";
            this.colEstadoObra.Name = "colEstadoObra";
            this.colEstadoObra.ReadOnly = true;
            //
            // GaleriasPanel
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.gridObrasGaleria);
            this.Controls.Add(this.lblObrasEnGaleria);
            this.Controls.Add(this.gridGalerias);
            this.Controls.Add(this.lblGalerias);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "GaleriasPanel";
            this.Size = new System.Drawing.Size(980, 580);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGalerias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridObrasGaleria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnNuevaGaleria;
        private System.Windows.Forms.Button btnEditarGaleria;
        private System.Windows.Forms.Button btnEliminarGaleria;
        private System.Windows.Forms.Button btnAgregarObra;
        private System.Windows.Forms.Button btnQuitarObra;
        private System.Windows.Forms.Label lblGalerias;
        private System.Windows.Forms.DataGridView gridGalerias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdGal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreGal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantObras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoGal;
        private System.Windows.Forms.Label lblObrasEnGaleria;
        private System.Windows.Forms.DataGridView gridObrasGaleria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtistaObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoObra;
    }
}
