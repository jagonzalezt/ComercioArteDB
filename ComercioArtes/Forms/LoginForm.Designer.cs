namespace ComercioArtes.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.txtRegistar = new System.Windows.Forms.Button();
            this.lblPista = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCampoPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCampoUsuario = new System.Windows.Forms.Label();
            this.lblTextoIngresa = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlIzquierdo.Controls.Add(this.pictureBox2);
            this.pnlIzquierdo.Controls.Add(this.lblCaracteristicas);
            this.pnlIzquierdo.Controls.Add(this.pnlLinea);
            this.pnlIzquierdo.Controls.Add(this.lblSubtitulo);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(373, 512);
            this.pnlIzquierdo.TabIndex = 0;
            this.pnlIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIzquierdo_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ComercioArtes.Properties.Resources.WhatsApp_Image_2026_06_13_at_9_05_31_AM;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
            this.lblCaracteristicas.Location = new System.Drawing.Point(54, 278);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(171, 51);
            this.lblCaracteristicas.TabIndex = 4;
            this.lblCaracteristicas.Text = "• Gestiona artistas y obras\r\n• Administra galerías\r\n• Registra compras y ventas";
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            this.pnlLinea.Location = new System.Drawing.Point(54, 264);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(220, 2);
            this.pnlLinea.TabIndex = 3;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(64, 238);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(164, 19);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gestión de arte y galerías";
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlDerecho.Controls.Add(this.txtRegistar);
            this.pnlDerecho.Controls.Add(this.lblPista);
            this.pnlDerecho.Controls.Add(this.btnIngresar);
            this.pnlDerecho.Controls.Add(this.lblError);
            this.pnlDerecho.Controls.Add(this.txtPassword);
            this.pnlDerecho.Controls.Add(this.lblCampoPassword);
            this.pnlDerecho.Controls.Add(this.txtEmail);
            this.pnlDerecho.Controls.Add(this.lblCampoUsuario);
            this.pnlDerecho.Controls.Add(this.lblTextoIngresa);
            this.pnlDerecho.Controls.Add(this.lblBienvenido);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Location = new System.Drawing.Point(373, 0);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(431, 512);
            this.pnlDerecho.TabIndex = 1;
            this.pnlDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDerecho_Paint);
            // 
            // txtRegistar
            // 
            this.txtRegistar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtRegistar.FlatAppearance.BorderSize = 0;
            this.txtRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRegistar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtRegistar.Location = new System.Drawing.Point(150, 462);
            this.txtRegistar.Name = "txtRegistar";
            this.txtRegistar.Size = new System.Drawing.Size(140, 28);
            this.txtRegistar.TabIndex = 9;
            this.txtRegistar.Text = "REGISTRARSE  →";
            this.txtRegistar.UseVisualStyleBackColor = false;
            this.txtRegistar.Click += new System.EventHandler(this.txtRegistar_Click);
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPista.ForeColor = System.Drawing.Color.Black;
            this.lblPista.Location = new System.Drawing.Point(158, 444);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(132, 15);
            this.lblPista.TabIndex = 8;
            this.lblPista.Text = "Registar usuario Nuevo:";
            this.lblPista.Click += new System.EventHandler(this.lblPista_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(184)))), ((int)(((byte)(109)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btnIngresar.Location = new System.Drawing.Point(66, 328);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(320, 44);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "  INGRESAR  →";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblError.Location = new System.Drawing.Point(66, 310);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(66, 269);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(320, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // lblCampoPassword
            // 
            this.lblCampoPassword.AutoSize = true;
            this.lblCampoPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCampoPassword.Location = new System.Drawing.Point(66, 248);
            this.lblCampoPassword.Name = "lblCampoPassword";
            this.lblCampoPassword.Size = new System.Drawing.Size(69, 15);
            this.lblCampoPassword.TabIndex = 4;
            this.lblCampoPassword.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(66, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lblCampoUsuario
            // 
            this.lblCampoUsuario.AutoSize = true;
            this.lblCampoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCampoUsuario.Location = new System.Drawing.Point(66, 183);
            this.lblCampoUsuario.Name = "lblCampoUsuario";
            this.lblCampoUsuario.Size = new System.Drawing.Size(36, 15);
            this.lblCampoUsuario.TabIndex = 2;
            this.lblCampoUsuario.Text = "Email";
            // 
            // lblTextoIngresa
            // 
            this.lblTextoIngresa.AutoSize = true;
            this.lblTextoIngresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoIngresa.ForeColor = System.Drawing.Color.Gray;
            this.lblTextoIngresa.Location = new System.Drawing.Point(66, 128);
            this.lblTextoIngresa.Name = "lblTextoIngresa";
            this.lblTextoIngresa.Size = new System.Drawing.Size(212, 15);
            this.lblTextoIngresa.TabIndex = 1;
            this.lblTextoIngresa.Text = "Ingresa tus credenciales para continuar";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lblBienvenido.Location = new System.Drawing.Point(66, 88);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(176, 41);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComercioArtes — Iniciar sesión";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblTextoIngresa;
        private System.Windows.Forms.Label lblCampoUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCampoPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button txtRegistar;
        private System.Windows.Forms.Label lblPista;
    }
}
