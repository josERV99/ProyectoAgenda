namespace AgendaPrueba
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.picbxLOGIN = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.linlblHolvidarContra = new System.Windows.Forms.LinkLabel();
            this.pctbxCerrar = new System.Windows.Forms.PictureBox();
            this.pctbxMinimizar = new System.Windows.Forms.PictureBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLOGIN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsuario.Location = new System.Drawing.Point(314, 173);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.lblContraseña.Location = new System.Drawing.Point(314, 264);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(129, 25);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(320, 224);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(385, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrseña
            // 
            this.txtContrseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContrseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrseña.Location = new System.Drawing.Point(320, 312);
            this.txtContrseña.Name = "txtContrseña";
            this.txtContrseña.Size = new System.Drawing.Size(385, 26);
            this.txtContrseña.TabIndex = 3;
            this.txtContrseña.Enter += new System.EventHandler(this.txtContrseña_Enter);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.LightGray;
            this.btnIniciarSesion.Location = new System.Drawing.Point(320, 369);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(385, 31);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // picbxLOGIN
            // 
            this.picbxLOGIN.ErrorImage = null;
            this.picbxLOGIN.Image = ((System.Drawing.Image)(resources.GetObject("picbxLOGIN.Image")));
            this.picbxLOGIN.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbxLOGIN.InitialImage")));
            this.picbxLOGIN.Location = new System.Drawing.Point(470, 12);
            this.picbxLOGIN.Name = "picbxLOGIN";
            this.picbxLOGIN.Size = new System.Drawing.Size(100, 100);
            this.picbxLOGIN.TabIndex = 5;
            this.picbxLOGIN.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pctbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 529);
            this.panel1.TabIndex = 6;
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctbxLogo.Image")));
            this.pctbxLogo.Location = new System.Drawing.Point(22, 173);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(187, 180);
            this.pctbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxLogo.TabIndex = 0;
            this.pctbxLogo.TabStop = false;
            // 
            // linlblHolvidarContra
            // 
            this.linlblHolvidarContra.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linlblHolvidarContra.AutoSize = true;
            this.linlblHolvidarContra.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linlblHolvidarContra.LinkColor = System.Drawing.Color.DimGray;
            this.linlblHolvidarContra.Location = new System.Drawing.Point(424, 462);
            this.linlblHolvidarContra.Name = "linlblHolvidarContra";
            this.linlblHolvidarContra.Size = new System.Drawing.Size(166, 67);
            this.linlblHolvidarContra.TabIndex = 7;
            this.linlblHolvidarContra.TabStop = true;
            this.linlblHolvidarContra.Text = "¿Ha olvidad la contraseña?";
            // 
            // pctbxCerrar
            // 
            this.pctbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pctbxCerrar.Image")));
            this.pctbxCerrar.Location = new System.Drawing.Point(735, 12);
            this.pctbxCerrar.Name = "pctbxCerrar";
            this.pctbxCerrar.Size = new System.Drawing.Size(33, 32);
            this.pctbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxCerrar.TabIndex = 1;
            this.pctbxCerrar.TabStop = false;
            this.pctbxCerrar.Click += new System.EventHandler(this.pctbxCerrar_Click);
            // 
            // pctbxMinimizar
            // 
            this.pctbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctbxMinimizar.Image")));
            this.pctbxMinimizar.Location = new System.Drawing.Point(687, 12);
            this.pctbxMinimizar.Name = "pctbxMinimizar";
            this.pctbxMinimizar.Size = new System.Drawing.Size(33, 34);
            this.pctbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMinimizar.TabIndex = 1;
            this.pctbxMinimizar.TabStop = false;
            this.pctbxMinimizar.Click += new System.EventHandler(this.pctbxMinimizar_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Turquoise;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(320, 415);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(385, 31);
            this.btnAgregarUsuario.TabIndex = 4;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(780, 529);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.pctbxMinimizar);
            this.Controls.Add(this.pctbxCerrar);
            this.Controls.Add(this.linlblHolvidarContra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picbxLOGIN);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLOGIN)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox picbxLOGIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linlblHolvidarContra;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.PictureBox pctbxCerrar;
        private System.Windows.Forms.PictureBox pctbxMinimizar;
        private System.Windows.Forms.Button btnAgregarUsuario;
    }
}

