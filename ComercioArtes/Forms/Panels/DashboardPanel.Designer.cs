namespace ComercioArtes.Forms.Panels
{
    partial class DashboardPanel
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
            this.lblTituloResumen = new System.Windows.Forms.Label();
            this.pnlCardArtistas = new System.Windows.Forms.Panel();
            this.pnlAccentCard1 = new System.Windows.Forms.Panel();
            this.lblTitCard1 = new System.Windows.Forms.Label();
            this.lblValCard1 = new System.Windows.Forms.Label();
            this.pnlCardObras = new System.Windows.Forms.Panel();
            this.pnlAccentCard2 = new System.Windows.Forms.Panel();
            this.lblTitCard2 = new System.Windows.Forms.Label();
            this.lblValCard2 = new System.Windows.Forms.Label();
            this.pnlCardDisponibles = new System.Windows.Forms.Panel();
            this.pnlAccentCard3 = new System.Windows.Forms.Panel();
            this.lblTitCard3 = new System.Windows.Forms.Label();
            this.lblValCard3 = new System.Windows.Forms.Label();
            this.pnlCardVendidas = new System.Windows.Forms.Panel();
            this.pnlAccentCard4 = new System.Windows.Forms.Panel();
            this.lblTitCard4 = new System.Windows.Forms.Label();
            this.lblValCard4 = new System.Windows.Forms.Label();
            this.pnlCardIngresos = new System.Windows.Forms.Panel();
            this.pnlAccentCard5 = new System.Windows.Forms.Panel();
            this.lblTitCard5 = new System.Windows.Forms.Label();
            this.lblValCard5 = new System.Windows.Forms.Label();
            this.lblTituloObras = new System.Windows.Forms.Label();
            this.gridObrasDB = new System.Windows.Forms.DataGridView();
            this.colIdDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloObraDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtistaObraDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTecnicaDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioObraDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoObraDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloTrans = new System.Windows.Forms.Label();
            this.gridTransDB = new System.Windows.Forms.DataGridView();
            this.colIdTransDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompradorDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTransDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoTransDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoTransDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCardArtistas.SuspendLayout();
            this.pnlCardObras.SuspendLayout();
            this.pnlCardDisponibles.SuspendLayout();
            this.pnlCardVendidas.SuspendLayout();
            this.pnlCardIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridObrasDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloResumen
            // 
            this.lblTituloResumen.AutoSize = true;
            this.lblTituloResumen.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTituloResumen.Location = new System.Drawing.Point(0, 0);
            this.lblTituloResumen.Name = "lblTituloResumen";
            this.lblTituloResumen.Size = new System.Drawing.Size(159, 25);
            this.lblTituloResumen.TabIndex = 0;
            this.lblTituloResumen.Text = "Resumen general";
            // 
            // pnlCardArtistas
            // 
            this.pnlCardArtistas.BackColor = System.Drawing.Color.White;
            this.pnlCardArtistas.Controls.Add(this.pnlAccentCard1);
            this.pnlCardArtistas.Controls.Add(this.lblTitCard1);
            this.pnlCardArtistas.Controls.Add(this.lblValCard1);
            this.pnlCardArtistas.Location = new System.Drawing.Point(0, 28);
            this.pnlCardArtistas.Name = "pnlCardArtistas";
            this.pnlCardArtistas.Size = new System.Drawing.Size(168, 88);
            this.pnlCardArtistas.TabIndex = 1;
            // 
            // pnlAccentCard1
            // 
            this.pnlAccentCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.pnlAccentCard1.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentCard1.Name = "pnlAccentCard1";
            this.pnlAccentCard1.Size = new System.Drawing.Size(5, 88);
            this.pnlAccentCard1.TabIndex = 0;
            // 
            // lblTitCard1
            // 
            this.lblTitCard1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitCard1.Location = new System.Drawing.Point(14, 10);
            this.lblTitCard1.Name = "lblTitCard1";
            this.lblTitCard1.Size = new System.Drawing.Size(154, 22);
            this.lblTitCard1.TabIndex = 1;
            this.lblTitCard1.Text = "Artistas registrados";
            this.lblTitCard1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValCard1
            // 
            this.lblValCard1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblValCard1.Location = new System.Drawing.Point(14, 34);
            this.lblValCard1.Name = "lblValCard1";
            this.lblValCard1.Size = new System.Drawing.Size(154, 40);
            this.lblValCard1.TabIndex = 2;
            this.lblValCard1.Text = "0";
            this.lblValCard1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCardObras
            // 
            this.pnlCardObras.BackColor = System.Drawing.Color.White;
            this.pnlCardObras.Controls.Add(this.pnlAccentCard2);
            this.pnlCardObras.Controls.Add(this.lblTitCard2);
            this.pnlCardObras.Controls.Add(this.lblValCard2);
            this.pnlCardObras.Location = new System.Drawing.Point(180, 28);
            this.pnlCardObras.Name = "pnlCardObras";
            this.pnlCardObras.Size = new System.Drawing.Size(168, 88);
            this.pnlCardObras.TabIndex = 2;
            // 
            // pnlAccentCard2
            // 
            this.pnlAccentCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlAccentCard2.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentCard2.Name = "pnlAccentCard2";
            this.pnlAccentCard2.Size = new System.Drawing.Size(5, 88);
            this.pnlAccentCard2.TabIndex = 0;
            // 
            // lblTitCard2
            // 
            this.lblTitCard2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitCard2.Location = new System.Drawing.Point(14, 10);
            this.lblTitCard2.Name = "lblTitCard2";
            this.lblTitCard2.Size = new System.Drawing.Size(154, 22);
            this.lblTitCard2.TabIndex = 1;
            this.lblTitCard2.Text = "Obras en catálogo";
            this.lblTitCard2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValCard2
            // 
            this.lblValCard2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblValCard2.Location = new System.Drawing.Point(14, 34);
            this.lblValCard2.Name = "lblValCard2";
            this.lblValCard2.Size = new System.Drawing.Size(154, 40);
            this.lblValCard2.TabIndex = 2;
            this.lblValCard2.Text = "0";
            this.lblValCard2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCardDisponibles
            // 
            this.pnlCardDisponibles.BackColor = System.Drawing.Color.White;
            this.pnlCardDisponibles.Controls.Add(this.pnlAccentCard3);
            this.pnlCardDisponibles.Controls.Add(this.lblTitCard3);
            this.pnlCardDisponibles.Controls.Add(this.lblValCard3);
            this.pnlCardDisponibles.Location = new System.Drawing.Point(360, 28);
            this.pnlCardDisponibles.Name = "pnlCardDisponibles";
            this.pnlCardDisponibles.Size = new System.Drawing.Size(168, 88);
            this.pnlCardDisponibles.TabIndex = 3;
            // 
            // pnlAccentCard3
            // 
            this.pnlAccentCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlAccentCard3.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentCard3.Name = "pnlAccentCard3";
            this.pnlAccentCard3.Size = new System.Drawing.Size(5, 88);
            this.pnlAccentCard3.TabIndex = 0;
            // 
            // lblTitCard3
            // 
            this.lblTitCard3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitCard3.Location = new System.Drawing.Point(14, 10);
            this.lblTitCard3.Name = "lblTitCard3";
            this.lblTitCard3.Size = new System.Drawing.Size(154, 22);
            this.lblTitCard3.TabIndex = 1;
            this.lblTitCard3.Text = "Disponibles";
            this.lblTitCard3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValCard3
            // 
            this.lblValCard3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblValCard3.Location = new System.Drawing.Point(14, 34);
            this.lblValCard3.Name = "lblValCard3";
            this.lblValCard3.Size = new System.Drawing.Size(154, 40);
            this.lblValCard3.TabIndex = 2;
            this.lblValCard3.Text = "0";
            this.lblValCard3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCardVendidas
            // 
            this.pnlCardVendidas.BackColor = System.Drawing.Color.White;
            this.pnlCardVendidas.Controls.Add(this.pnlAccentCard4);
            this.pnlCardVendidas.Controls.Add(this.lblTitCard4);
            this.pnlCardVendidas.Controls.Add(this.lblValCard4);
            this.pnlCardVendidas.Location = new System.Drawing.Point(540, 28);
            this.pnlCardVendidas.Name = "pnlCardVendidas";
            this.pnlCardVendidas.Size = new System.Drawing.Size(168, 88);
            this.pnlCardVendidas.TabIndex = 4;
            // 
            // pnlAccentCard4
            // 
            this.pnlAccentCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlAccentCard4.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentCard4.Name = "pnlAccentCard4";
            this.pnlAccentCard4.Size = new System.Drawing.Size(5, 88);
            this.pnlAccentCard4.TabIndex = 0;
            // 
            // lblTitCard4
            // 
            this.lblTitCard4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitCard4.Location = new System.Drawing.Point(14, 10);
            this.lblTitCard4.Name = "lblTitCard4";
            this.lblTitCard4.Size = new System.Drawing.Size(154, 22);
            this.lblTitCard4.TabIndex = 1;
            this.lblTitCard4.Text = "Vendidas";
            this.lblTitCard4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValCard4
            // 
            this.lblValCard4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblValCard4.Location = new System.Drawing.Point(14, 34);
            this.lblValCard4.Name = "lblValCard4";
            this.lblValCard4.Size = new System.Drawing.Size(154, 40);
            this.lblValCard4.TabIndex = 2;
            this.lblValCard4.Text = "0";
            this.lblValCard4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCardIngresos
            // 
            this.pnlCardIngresos.BackColor = System.Drawing.Color.White;
            this.pnlCardIngresos.Controls.Add(this.pnlAccentCard5);
            this.pnlCardIngresos.Controls.Add(this.lblTitCard5);
            this.pnlCardIngresos.Controls.Add(this.lblValCard5);
            this.pnlCardIngresos.Location = new System.Drawing.Point(720, 28);
            this.pnlCardIngresos.Name = "pnlCardIngresos";
            this.pnlCardIngresos.Size = new System.Drawing.Size(168, 88);
            this.pnlCardIngresos.TabIndex = 5;
            // 
            // pnlAccentCard5
            // 
            this.pnlAccentCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.pnlAccentCard5.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentCard5.Name = "pnlAccentCard5";
            this.pnlAccentCard5.Size = new System.Drawing.Size(5, 88);
            this.pnlAccentCard5.TabIndex = 0;
            // 
            // lblTitCard5
            // 
            this.lblTitCard5.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitCard5.Location = new System.Drawing.Point(14, 10);
            this.lblTitCard5.Name = "lblTitCard5";
            this.lblTitCard5.Size = new System.Drawing.Size(154, 22);
            this.lblTitCard5.TabIndex = 1;
            this.lblTitCard5.Text = "Ingresos";
            this.lblTitCard5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValCard5
            // 
            this.lblValCard5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblValCard5.Location = new System.Drawing.Point(14, 34);
            this.lblValCard5.Name = "lblValCard5";
            this.lblValCard5.Size = new System.Drawing.Size(154, 40);
            this.lblValCard5.TabIndex = 2;
            this.lblValCard5.Text = "$0";
            this.lblValCard5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloObras
            // 
            this.lblTituloObras.AutoSize = true;
            this.lblTituloObras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloObras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTituloObras.Location = new System.Drawing.Point(0, 136);
            this.lblTituloObras.Name = "lblTituloObras";
            this.lblTituloObras.Size = new System.Drawing.Size(148, 21);
            this.lblTituloObras.TabIndex = 6;
            this.lblTituloObras.Text = "Catálogo de obras";
            // 
            // gridObrasDB
            // 
            this.gridObrasDB.AllowUserToAddRows = false;
            this.gridObrasDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridObrasDB.BackgroundColor = System.Drawing.Color.White;
            this.gridObrasDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridObrasDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridObrasDB.ColumnHeadersHeight = 38;
            this.gridObrasDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridObrasDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdDB,
            this.colTituloObraDB,
            this.colArtistaObraDB,
            this.colTecnicaDB,
            this.colPrecioObraDB,
            this.colEstadoObraDB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridObrasDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridObrasDB.EnableHeadersVisualStyles = false;
            this.gridObrasDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridObrasDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridObrasDB.Location = new System.Drawing.Point(0, 162);
            this.gridObrasDB.Name = "gridObrasDB";
            this.gridObrasDB.ReadOnly = true;
            this.gridObrasDB.RowHeadersVisible = false;
            this.gridObrasDB.RowTemplate.Height = 34;
            this.gridObrasDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridObrasDB.Size = new System.Drawing.Size(900, 220);
            this.gridObrasDB.TabIndex = 7;
            this.gridObrasDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridObrasDB_CellContentClick);
            // 
            // colIdDB
            // 
            this.colIdDB.FillWeight = 5F;
            this.colIdDB.HeaderText = "ID";
            this.colIdDB.Name = "colIdDB";
            this.colIdDB.ReadOnly = true;
            // 
            // colTituloObraDB
            // 
            this.colTituloObraDB.FillWeight = 28F;
            this.colTituloObraDB.HeaderText = "Título";
            this.colTituloObraDB.Name = "colTituloObraDB";
            this.colTituloObraDB.ReadOnly = true;
            // 
            // colArtistaObraDB
            // 
            this.colArtistaObraDB.FillWeight = 22F;
            this.colArtistaObraDB.HeaderText = "Artista";
            this.colArtistaObraDB.Name = "colArtistaObraDB";
            this.colArtistaObraDB.ReadOnly = true;
            // 
            // colTecnicaDB
            // 
            this.colTecnicaDB.FillWeight = 15F;
            this.colTecnicaDB.HeaderText = "Técnica";
            this.colTecnicaDB.Name = "colTecnicaDB";
            this.colTecnicaDB.ReadOnly = true;
            // 
            // colPrecioObraDB
            // 
            this.colPrecioObraDB.FillWeight = 15F;
            this.colPrecioObraDB.HeaderText = "Precio";
            this.colPrecioObraDB.Name = "colPrecioObraDB";
            this.colPrecioObraDB.ReadOnly = true;
            // 
            // colEstadoObraDB
            // 
            this.colEstadoObraDB.FillWeight = 15F;
            this.colEstadoObraDB.HeaderText = "Estado";
            this.colEstadoObraDB.Name = "colEstadoObraDB";
            this.colEstadoObraDB.ReadOnly = true;
            // 
            // lblTituloTrans
            // 
            this.lblTituloTrans.AutoSize = true;
            this.lblTituloTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTituloTrans.Location = new System.Drawing.Point(0, 398);
            this.lblTituloTrans.Name = "lblTituloTrans";
            this.lblTituloTrans.Size = new System.Drawing.Size(146, 21);
            this.lblTituloTrans.TabIndex = 8;
            this.lblTituloTrans.Text = "Facturas recientes";
            // 
            // gridTransDB
            // 
            this.gridTransDB.AllowUserToAddRows = false;
            this.gridTransDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransDB.BackgroundColor = System.Drawing.Color.White;
            this.gridTransDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTransDB.ColumnHeadersHeight = 38;
            this.gridTransDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTransDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTransDB,
            this.colFechaDB,
            this.colCompradorDB,
            this.colMontoTransDB,
            this.colTipoTransDB,
            this.colEstadoTransDB});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTransDB.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridTransDB.EnableHeadersVisualStyles = false;
            this.gridTransDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTransDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.gridTransDB.Location = new System.Drawing.Point(0, 422);
            this.gridTransDB.Name = "gridTransDB";
            this.gridTransDB.ReadOnly = true;
            this.gridTransDB.RowHeadersVisible = false;
            this.gridTransDB.RowTemplate.Height = 34;
            this.gridTransDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransDB.Size = new System.Drawing.Size(900, 170);
            this.gridTransDB.TabIndex = 9;
            // 
            // colIdTransDB
            // 
            this.colIdTransDB.FillWeight = 5F;
            this.colIdTransDB.HeaderText = "ID";
            this.colIdTransDB.Name = "colIdTransDB";
            this.colIdTransDB.ReadOnly = true;
            // 
            // colFechaDB
            // 
            this.colFechaDB.FillWeight = 20F;
            this.colFechaDB.HeaderText = "Fecha";
            this.colFechaDB.Name = "colFechaDB";
            this.colFechaDB.ReadOnly = true;
            // 
            // colCompradorDB
            // 
            this.colCompradorDB.FillWeight = 22F;
            this.colCompradorDB.HeaderText = "Comprador";
            this.colCompradorDB.Name = "colCompradorDB";
            this.colCompradorDB.ReadOnly = true;
            // 
            // colMontoTransDB
            // 
            this.colMontoTransDB.FillWeight = 15F;
            this.colMontoTransDB.HeaderText = "Monto";
            this.colMontoTransDB.Name = "colMontoTransDB";
            this.colMontoTransDB.ReadOnly = true;
            // 
            // colTipoTransDB
            // 
            this.colTipoTransDB.FillWeight = 13F;
            this.colTipoTransDB.HeaderText = "# Obras";
            this.colTipoTransDB.Name = "colTipoTransDB";
            this.colTipoTransDB.ReadOnly = true;
            // 
            // colEstadoTransDB
            // 
            this.colEstadoTransDB.FillWeight = 15F;
            this.colEstadoTransDB.HeaderText = "Estado";
            this.colEstadoTransDB.Name = "colEstadoTransDB";
            this.colEstadoTransDB.ReadOnly = true;
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.gridTransDB);
            this.Controls.Add(this.lblTituloTrans);
            this.Controls.Add(this.gridObrasDB);
            this.Controls.Add(this.lblTituloObras);
            this.Controls.Add(this.pnlCardIngresos);
            this.Controls.Add(this.pnlCardVendidas);
            this.Controls.Add(this.pnlCardDisponibles);
            this.Controls.Add(this.pnlCardObras);
            this.Controls.Add(this.pnlCardArtistas);
            this.Controls.Add(this.lblTituloResumen);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(963, 580);
            this.pnlCardArtistas.ResumeLayout(false);
            this.pnlCardObras.ResumeLayout(false);
            this.pnlCardDisponibles.ResumeLayout(false);
            this.pnlCardVendidas.ResumeLayout(false);
            this.pnlCardIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridObrasDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloResumen;
        private System.Windows.Forms.Panel pnlCardArtistas;
        private System.Windows.Forms.Panel pnlAccentCard1;
        private System.Windows.Forms.Label lblTitCard1;
        private System.Windows.Forms.Label lblValCard1;
        private System.Windows.Forms.Panel pnlCardObras;
        private System.Windows.Forms.Panel pnlAccentCard2;
        private System.Windows.Forms.Label lblTitCard2;
        private System.Windows.Forms.Label lblValCard2;
        private System.Windows.Forms.Panel pnlCardDisponibles;
        private System.Windows.Forms.Panel pnlAccentCard3;
        private System.Windows.Forms.Label lblTitCard3;
        private System.Windows.Forms.Label lblValCard3;
        private System.Windows.Forms.Panel pnlCardVendidas;
        private System.Windows.Forms.Panel pnlAccentCard4;
        private System.Windows.Forms.Label lblTitCard4;
        private System.Windows.Forms.Label lblValCard4;
        private System.Windows.Forms.Panel pnlCardIngresos;
        private System.Windows.Forms.Panel pnlAccentCard5;
        private System.Windows.Forms.Label lblTitCard5;
        private System.Windows.Forms.Label lblValCard5;
        private System.Windows.Forms.Label lblTituloObras;
        private System.Windows.Forms.DataGridView gridObrasDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloObraDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtistaObraDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnicaDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioObraDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoObraDB;
        private System.Windows.Forms.Label lblTituloTrans;
        private System.Windows.Forms.DataGridView gridTransDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTransDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompradorDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTransDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoTransDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoTransDB;
    }
}
