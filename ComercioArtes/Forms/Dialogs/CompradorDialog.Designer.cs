namespace ComercioArtes.Forms.Dialogs
{
    partial class CompradorDialog
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
            this.lblNombreComp = new System.Windows.Forms.Label();
            this.txtNombreComp = new System.Windows.Forms.TextBox();
            this.lblCorreoComp = new System.Windows.Forms.Label();
            this.txtCorreoComp = new System.Windows.Forms.TextBox();
            this.lblTelefonoComp = new System.Windows.Forms.Label();
            this.txtTelefonoComp = new System.Windows.Forms.TextBox();
            this.lblMetodoPagoLabel = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblDireccionComp = new System.Windows.Forms.Label();
            this.txtDireccionComp = new System.Windows.Forms.TextBox();
            this.btnGuardarComp = new System.Windows.Forms.Button();
            this.btnCancelarComp = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(468, 62);
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
            this.lblSubtitleDlg.Size = new System.Drawing.Size(190, 15);
            this.lblSubtitleDlg.TabIndex = 1;
            this.lblSubtitleDlg.Text = "Completa los datos del comprador";
            // 
            // lblTitleDlg
            // 
            this.lblTitleDlg.AutoSize = true;
            this.lblTitleDlg.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDlg.ForeColor = System.Drawing.Color.White;
            this.lblTitleDlg.Location = new System.Drawing.Point(16, 8);
            this.lblTitleDlg.Name = "lblTitleDlg";
            this.lblTitleDlg.Size = new System.Drawing.Size(107, 25);
            this.lblTitleDlg.TabIndex = 0;
            this.lblTitleDlg.Text = "Comprador";
            // 
            // lblNombreComp
            // 
            this.lblNombreComp.AutoSize = true;
            this.lblNombreComp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNombreComp.Location = new System.Drawing.Point(28, 76);
            this.lblNombreComp.Name = "lblNombreComp";
            this.lblNombreComp.Size = new System.Drawing.Size(117, 15);
            this.lblNombreComp.TabIndex = 1;
            this.lblNombreComp.Text = "Nombre completo *";
            // 
            // txtNombreComp
            // 
            this.txtNombreComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComp.Location = new System.Drawing.Point(28, 96);
            this.txtNombreComp.Name = "txtNombreComp";
            this.txtNombreComp.Size = new System.Drawing.Size(404, 25);
            this.txtNombreComp.TabIndex = 2;
            // 
            // lblCorreoComp
            // 
            this.lblCorreoComp.AutoSize = true;
            this.lblCorreoComp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCorreoComp.Location = new System.Drawing.Point(28, 140);
            this.lblCorreoComp.Name = "lblCorreoComp";
            this.lblCorreoComp.Size = new System.Drawing.Size(119, 15);
            this.lblCorreoComp.TabIndex = 3;
            this.lblCorreoComp.Text = "Correo electrónico *";
            // 
            // txtCorreoComp
            // 
            this.txtCorreoComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoComp.Location = new System.Drawing.Point(28, 160);
            this.txtCorreoComp.Name = "txtCorreoComp";
            this.txtCorreoComp.Size = new System.Drawing.Size(404, 25);
            this.txtCorreoComp.TabIndex = 4;
            // 
            // lblTelefonoComp
            // 
            this.lblTelefonoComp.AutoSize = true;
            this.lblTelefonoComp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTelefonoComp.Location = new System.Drawing.Point(28, 204);
            this.lblTelefonoComp.Name = "lblTelefonoComp";
            this.lblTelefonoComp.Size = new System.Drawing.Size(56, 15);
            this.lblTelefonoComp.TabIndex = 5;
            this.lblTelefonoComp.Text = "Teléfono";
            // 
            // txtTelefonoComp
            // 
            this.txtTelefonoComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoComp.Location = new System.Drawing.Point(28, 224);
            this.txtTelefonoComp.Name = "txtTelefonoComp";
            this.txtTelefonoComp.Size = new System.Drawing.Size(185, 25);
            this.txtTelefonoComp.TabIndex = 6;
            // 
            // lblMetodoPagoLabel
            // 
            this.lblMetodoPagoLabel.AutoSize = true;
            this.lblMetodoPagoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPagoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblMetodoPagoLabel.Location = new System.Drawing.Point(203, 204);
            this.lblMetodoPagoLabel.Name = "lblMetodoPagoLabel";
            this.lblMetodoPagoLabel.Size = new System.Drawing.Size(106, 15);
            this.lblMetodoPagoLabel.TabIndex = 7;
            this.lblMetodoPagoLabel.Text = "Método de pago *";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPago.Location = new System.Drawing.Point(203, 224);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(201, 25);
            this.cmbMetodoPago.TabIndex = 8;
            // 
            // lblDireccionComp
            // 
            this.lblDireccionComp.AutoSize = true;
            this.lblDireccionComp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDireccionComp.Location = new System.Drawing.Point(28, 268);
            this.lblDireccionComp.Name = "lblDireccionComp";
            this.lblDireccionComp.Size = new System.Drawing.Size(60, 15);
            this.lblDireccionComp.TabIndex = 9;
            this.lblDireccionComp.Text = "Dirección";
            // 
            // txtDireccionComp
            // 
            this.txtDireccionComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionComp.Location = new System.Drawing.Point(28, 288);
            this.txtDireccionComp.Multiline = true;
            this.txtDireccionComp.Name = "txtDireccionComp";
            this.txtDireccionComp.Size = new System.Drawing.Size(404, 62);
            this.txtDireccionComp.TabIndex = 10;
            // 
            // btnGuardarComp
            // 
            this.btnGuardarComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGuardarComp.FlatAppearance.BorderSize = 0;
            this.btnGuardarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarComp.ForeColor = System.Drawing.Color.White;
            this.btnGuardarComp.Location = new System.Drawing.Point(28, 366);
            this.btnGuardarComp.Name = "btnGuardarComp";
            this.btnGuardarComp.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarComp.TabIndex = 11;
            this.btnGuardarComp.Text = "💾  Guardar";
            this.btnGuardarComp.UseVisualStyleBackColor = false;
            this.btnGuardarComp.Click += new System.EventHandler(this.btnGuardarComp_Click);
            // 
            // btnCancelarComp
            // 
            this.btnCancelarComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelarComp.FlatAppearance.BorderSize = 0;
            this.btnCancelarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarComp.ForeColor = System.Drawing.Color.White;
            this.btnCancelarComp.Location = new System.Drawing.Point(190, 366);
            this.btnCancelarComp.Name = "btnCancelarComp";
            this.btnCancelarComp.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarComp.TabIndex = 12;
            this.btnCancelarComp.Text = "✕  Cancelar";
            this.btnCancelarComp.UseVisualStyleBackColor = false;
            this.btnCancelarComp.Click += new System.EventHandler(this.btnCancelarComp_Click);
            // 
            // CompradorDialog
            // 
            this.AcceptButton = this.btnGuardarComp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(468, 420);
            this.Controls.Add(this.btnCancelarComp);
            this.Controls.Add(this.btnGuardarComp);
            this.Controls.Add(this.txtDireccionComp);
            this.Controls.Add(this.lblDireccionComp);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.lblMetodoPagoLabel);
            this.Controls.Add(this.txtTelefonoComp);
            this.Controls.Add(this.lblTelefonoComp);
            this.Controls.Add(this.txtCorreoComp);
            this.Controls.Add(this.lblCorreoComp);
            this.Controls.Add(this.txtNombreComp);
            this.Controls.Add(this.lblNombreComp);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompradorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comprador";
            this.Load += new System.EventHandler(this.CompradorDialog_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleDlg;
        private System.Windows.Forms.Label lblSubtitleDlg;
        private System.Windows.Forms.Label lblNombreComp;
        private System.Windows.Forms.TextBox txtNombreComp;
        private System.Windows.Forms.Label lblCorreoComp;
        private System.Windows.Forms.TextBox txtCorreoComp;
        private System.Windows.Forms.Label lblTelefonoComp;
        private System.Windows.Forms.TextBox txtTelefonoComp;
        private System.Windows.Forms.Label lblMetodoPagoLabel;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label lblDireccionComp;
        private System.Windows.Forms.TextBox txtDireccionComp;
        private System.Windows.Forms.Button btnGuardarComp;
        private System.Windows.Forms.Button btnCancelarComp;
    }
}
