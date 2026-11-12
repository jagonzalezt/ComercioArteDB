namespace ComercioArtes.Forms.Dialogs
{
    partial class GaleriaDialog
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
            this.lblNombreGal = new System.Windows.Forms.Label();
            this.txtNombreGal = new System.Windows.Forms.TextBox();
            this.lblDescGal = new System.Windows.Forms.Label();
            this.txtDescGal = new System.Windows.Forms.TextBox();
            this.lblUbicacionGal = new System.Windows.Forms.Label();
            this.txtUbicacionGal = new System.Windows.Forms.TextBox();
            this.lblTelefonoGal = new System.Windows.Forms.Label();
            this.txtTelefonoGal = new System.Windows.Forms.TextBox();
            this.btnGuardarGal = new System.Windows.Forms.Button();
            this.btnCancelarGal = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(452, 62);
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
            this.lblTitleDlg.Text = "Galería";
            //
            // lblSubtitleDlg
            //
            this.lblSubtitleDlg.AutoSize = true;
            this.lblSubtitleDlg.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleDlg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblSubtitleDlg.Location = new System.Drawing.Point(16, 36);
            this.lblSubtitleDlg.Name = "lblSubtitleDlg";
            this.lblSubtitleDlg.TabIndex = 1;
            this.lblSubtitleDlg.Text = "Completa los datos de la galería";
            //
            // lblNombreGal
            //
            this.lblNombreGal.AutoSize = true;
            this.lblNombreGal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNombreGal.Location = new System.Drawing.Point(28, 76);
            this.lblNombreGal.Name = "lblNombreGal";
            this.lblNombreGal.TabIndex = 1;
            this.lblNombreGal.Text = "Nombre *";
            //
            // txtNombreGal
            //
            this.txtNombreGal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreGal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreGal.Location = new System.Drawing.Point(28, 96);
            this.txtNombreGal.Name = "txtNombreGal";
            this.txtNombreGal.Size = new System.Drawing.Size(422, 30);
            this.txtNombreGal.TabIndex = 2;
            //
            // lblDescGal
            //
            this.lblDescGal.AutoSize = true;
            this.lblDescGal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescGal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDescGal.Location = new System.Drawing.Point(28, 140);
            this.lblDescGal.Name = "lblDescGal";
            this.lblDescGal.TabIndex = 3;
            this.lblDescGal.Text = "Descripción";
            //
            // txtDescGal
            //
            this.txtDescGal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescGal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescGal.Location = new System.Drawing.Point(28, 160);
            this.txtDescGal.Multiline = true;
            this.txtDescGal.Name = "txtDescGal";
            this.txtDescGal.Size = new System.Drawing.Size(422, 62);
            this.txtDescGal.TabIndex = 4;
            //
            // lblUbicacionGal
            //
            this.lblUbicacionGal.AutoSize = true;
            this.lblUbicacionGal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionGal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblUbicacionGal.Location = new System.Drawing.Point(28, 236);
            this.lblUbicacionGal.Name = "lblUbicacionGal";
            this.lblUbicacionGal.TabIndex = 5;
            this.lblUbicacionGal.Text = "Ubicación *";
            //
            // txtUbicacionGal
            //
            this.txtUbicacionGal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUbicacionGal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionGal.Location = new System.Drawing.Point(28, 256);
            this.txtUbicacionGal.Name = "txtUbicacionGal";
            this.txtUbicacionGal.Size = new System.Drawing.Size(422, 30);
            this.txtUbicacionGal.TabIndex = 6;
            //
            // lblTelefonoGal
            //
            this.lblTelefonoGal.AutoSize = true;
            this.lblTelefonoGal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoGal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTelefonoGal.Location = new System.Drawing.Point(28, 300);
            this.lblTelefonoGal.Name = "lblTelefonoGal";
            this.lblTelefonoGal.TabIndex = 7;
            this.lblTelefonoGal.Text = "Teléfono";
            //
            // txtTelefonoGal
            //
            this.txtTelefonoGal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoGal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoGal.Location = new System.Drawing.Point(28, 320);
            this.txtTelefonoGal.Name = "txtTelefonoGal";
            this.txtTelefonoGal.Size = new System.Drawing.Size(195, 30);
            this.txtTelefonoGal.TabIndex = 8;
            //
            // btnGuardarGal
            //
            this.btnGuardarGal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGuardarGal.FlatAppearance.BorderSize = 0;
            this.btnGuardarGal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarGal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarGal.Location = new System.Drawing.Point(28, 366);
            this.btnGuardarGal.Name = "btnGuardarGal";
            this.btnGuardarGal.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarGal.TabIndex = 9;
            this.btnGuardarGal.Text = "💾  Guardar";
            this.btnGuardarGal.UseVisualStyleBackColor = false;
            this.btnGuardarGal.Click += new System.EventHandler(this.btnGuardarGal_Click);
            //
            // btnCancelarGal
            //
            this.btnCancelarGal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelarGal.FlatAppearance.BorderSize = 0;
            this.btnCancelarGal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarGal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarGal.ForeColor = System.Drawing.Color.White;
            this.btnCancelarGal.Location = new System.Drawing.Point(190, 366);
            this.btnCancelarGal.Name = "btnCancelarGal";
            this.btnCancelarGal.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarGal.TabIndex = 10;
            this.btnCancelarGal.Text = "✕  Cancelar";
            this.btnCancelarGal.UseVisualStyleBackColor = false;
            this.btnCancelarGal.Click += new System.EventHandler(this.btnCancelarGal_Click);
            //
            // GaleriaDialog
            //
            this.AcceptButton = this.btnGuardarGal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(452, 420);
            this.Controls.Add(this.btnCancelarGal);
            this.Controls.Add(this.btnGuardarGal);
            this.Controls.Add(this.txtTelefonoGal);
            this.Controls.Add(this.lblTelefonoGal);
            this.Controls.Add(this.txtUbicacionGal);
            this.Controls.Add(this.lblUbicacionGal);
            this.Controls.Add(this.txtDescGal);
            this.Controls.Add(this.lblDescGal);
            this.Controls.Add(this.txtNombreGal);
            this.Controls.Add(this.lblNombreGal);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GaleriaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Galería";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleDlg;
        private System.Windows.Forms.Label lblSubtitleDlg;
        private System.Windows.Forms.Label lblNombreGal;
        private System.Windows.Forms.TextBox txtNombreGal;
        private System.Windows.Forms.Label lblDescGal;
        private System.Windows.Forms.TextBox txtDescGal;
        private System.Windows.Forms.Label lblUbicacionGal;
        private System.Windows.Forms.TextBox txtUbicacionGal;
        private System.Windows.Forms.Label lblTelefonoGal;
        private System.Windows.Forms.TextBox txtTelefonoGal;
        private System.Windows.Forms.Button btnGuardarGal;
        private System.Windows.Forms.Button btnCancelarGal;
    }
}
