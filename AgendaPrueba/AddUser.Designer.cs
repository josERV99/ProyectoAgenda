namespace AgendaPrueba
{
    partial class frmAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.lblNombrUsuario = new System.Windows.Forms.Label();
            this.lblContraUsuario = new System.Windows.Forms.Label();
            this.txtNombrUsuario = new System.Windows.Forms.TextBox();
            this.txtContraUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.btnMinimVentana = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrUsuario
            // 
            this.lblNombrUsuario.AutoSize = true;
            this.lblNombrUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblNombrUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombrUsuario.Location = new System.Drawing.Point(181, 127);
            this.lblNombrUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrUsuario.Name = "lblNombrUsuario";
            this.lblNombrUsuario.Size = new System.Drawing.Size(203, 25);
            this.lblNombrUsuario.TabIndex = 0;
            this.lblNombrUsuario.Text = "Nombre de Usuario:";
            // 
            // lblContraUsuario
            // 
            this.lblContraUsuario.AutoSize = true;
            this.lblContraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblContraUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblContraUsuario.Location = new System.Drawing.Point(181, 220);
            this.lblContraUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraUsuario.Name = "lblContraUsuario";
            this.lblContraUsuario.Size = new System.Drawing.Size(129, 25);
            this.lblContraUsuario.TabIndex = 1;
            this.lblContraUsuario.Text = "Contraseña:";
            // 
            // txtNombrUsuario
            // 
            this.txtNombrUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombrUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrUsuario.Location = new System.Drawing.Point(186, 174);
            this.txtNombrUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombrUsuario.Name = "txtNombrUsuario";
            this.txtNombrUsuario.Size = new System.Drawing.Size(378, 26);
            this.txtNombrUsuario.TabIndex = 2;
            // 
            // txtContraUsuario
            // 
            this.txtContraUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraUsuario.Location = new System.Drawing.Point(186, 267);
            this.txtContraUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraUsuario.Name = "txtContraUsuario";
            this.txtContraUsuario.Size = new System.Drawing.Size(378, 26);
            this.txtContraUsuario.TabIndex = 3;
            this.txtContraUsuario.TextChanged += new System.EventHandler(this.txtContraUsuario_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Turquoise;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(267, 354);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(208, 35);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(267, 423);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(208, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 508);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(616, 1);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(36, 32);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarVentana.TabIndex = 7;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // btnMinimVentana
            // 
            this.btnMinimVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimVentana.Image")));
            this.btnMinimVentana.Location = new System.Drawing.Point(575, 1);
            this.btnMinimVentana.Name = "btnMinimVentana";
            this.btnMinimVentana.Size = new System.Drawing.Size(35, 32);
            this.btnMinimVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimVentana.TabIndex = 8;
            this.btnMinimVentana.TabStop = false;
            this.btnMinimVentana.Click += new System.EventHandler(this.btnMinimVentana_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(321, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(655, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMinimVentana);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContraUsuario);
            this.Controls.Add(this.txtNombrUsuario);
            this.Controls.Add(this.lblContraUsuario);
            this.Controls.Add(this.lblNombrUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUser";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrUsuario;
        private System.Windows.Forms.Label lblContraUsuario;
        private System.Windows.Forms.TextBox txtNombrUsuario;
        private System.Windows.Forms.TextBox txtContraUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private System.Windows.Forms.PictureBox btnMinimVentana;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}