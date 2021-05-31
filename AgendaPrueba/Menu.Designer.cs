
namespace AgendaPrueba
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEditarContacto = new System.Windows.Forms.Label();
            this.btnEditarContacto = new System.Windows.Forms.PictureBox();
            this.lblBorraContacto = new System.Windows.Forms.Label();
            this.btnBorrarInfo = new System.Windows.Forms.PictureBox();
            this.lblAgregarContacto = new System.Windows.Forms.Label();
            this.btnAgregarContacto = new System.Windows.Forms.PictureBox();
            this.lblMostrarContactos = new System.Windows.Forms.Label();
            this.btnMostrarContactos = new System.Windows.Forms.PictureBox();
            this.dtgVisualizar = new System.Windows.Forms.DataGridView();
            this.lblidcontacto = new System.Windows.Forms.Label();
            this.txtidcontacto = new System.Windows.Forms.TextBox();
            this.lblNombrecontacto = new System.Windows.Forms.Label();
            this.txtNombrecontacto = new System.Windows.Forms.TextBox();
            this.lblNoTelefono = new System.Windows.Forms.Label();
            this.txtNotelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTipoContacto = new System.Windows.Forms.Label();
            this.txtTipoContacto = new System.Windows.Forms.TextBox();
            this.btnCerrarPagina = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblEditarContacto);
            this.panel1.Controls.Add(this.btnEditarContacto);
            this.panel1.Controls.Add(this.lblBorraContacto);
            this.panel1.Controls.Add(this.btnBorrarInfo);
            this.panel1.Controls.Add(this.lblAgregarContacto);
            this.panel1.Controls.Add(this.btnAgregarContacto);
            this.panel1.Controls.Add(this.lblMostrarContactos);
            this.panel1.Controls.Add(this.btnMostrarContactos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 523);
            this.panel1.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(49, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 25);
            this.lblHora.TabIndex = 8;
            // 
            // lblEditarContacto
            // 
            this.lblEditarContacto.AutoSize = true;
            this.lblEditarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarContacto.ForeColor = System.Drawing.Color.Black;
            this.lblEditarContacto.Location = new System.Drawing.Point(26, 376);
            this.lblEditarContacto.Name = "lblEditarContacto";
            this.lblEditarContacto.Size = new System.Drawing.Size(137, 24);
            this.lblEditarContacto.TabIndex = 7;
            this.lblEditarContacto.Text = "Editar Contacto";
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEditarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarContacto.Image")));
            this.btnEditarContacto.Location = new System.Drawing.Point(51, 306);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(77, 67);
            this.btnEditarContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarContacto.TabIndex = 6;
            this.btnEditarContacto.TabStop = false;
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // lblBorraContacto
            // 
            this.lblBorraContacto.AutoSize = true;
            this.lblBorraContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorraContacto.ForeColor = System.Drawing.Color.Black;
            this.lblBorraContacto.Location = new System.Drawing.Point(26, 486);
            this.lblBorraContacto.Name = "lblBorraContacto";
            this.lblBorraContacto.Size = new System.Drawing.Size(140, 24);
            this.lblBorraContacto.TabIndex = 5;
            this.lblBorraContacto.Text = "Borrar Contacto";
            // 
            // btnBorrarInfo
            // 
            this.btnBorrarInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBorrarInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarInfo.Image")));
            this.btnBorrarInfo.Location = new System.Drawing.Point(51, 416);
            this.btnBorrarInfo.Name = "btnBorrarInfo";
            this.btnBorrarInfo.Size = new System.Drawing.Size(77, 67);
            this.btnBorrarInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBorrarInfo.TabIndex = 4;
            this.btnBorrarInfo.TabStop = false;
            this.btnBorrarInfo.Click += new System.EventHandler(this.btnBorrarInfo_Click);
            // 
            // lblAgregarContacto
            // 
            this.lblAgregarContacto.AutoSize = true;
            this.lblAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarContacto.ForeColor = System.Drawing.Color.Black;
            this.lblAgregarContacto.Location = new System.Drawing.Point(15, 268);
            this.lblAgregarContacto.Name = "lblAgregarContacto";
            this.lblAgregarContacto.Size = new System.Drawing.Size(157, 24);
            this.lblAgregarContacto.TabIndex = 3;
            this.lblAgregarContacto.Text = "Agregar Contacto";
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAgregarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarContacto.Image")));
            this.btnAgregarContacto.Location = new System.Drawing.Point(51, 198);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(77, 67);
            this.btnAgregarContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregarContacto.TabIndex = 2;
            this.btnAgregarContacto.TabStop = false;
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            // 
            // lblMostrarContactos
            // 
            this.lblMostrarContactos.AutoSize = true;
            this.lblMostrarContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarContactos.ForeColor = System.Drawing.Color.Black;
            this.lblMostrarContactos.Location = new System.Drawing.Point(12, 161);
            this.lblMostrarContactos.Name = "lblMostrarContactos";
            this.lblMostrarContactos.Size = new System.Drawing.Size(160, 24);
            this.lblMostrarContactos.TabIndex = 1;
            this.lblMostrarContactos.Text = "Mostrar Contactos";
            // 
            // btnMostrarContactos
            // 
            this.btnMostrarContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnMostrarContactos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarContactos.Image")));
            this.btnMostrarContactos.Location = new System.Drawing.Point(54, 98);
            this.btnMostrarContactos.Name = "btnMostrarContactos";
            this.btnMostrarContactos.Size = new System.Drawing.Size(77, 67);
            this.btnMostrarContactos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMostrarContactos.TabIndex = 0;
            this.btnMostrarContactos.TabStop = false;
            this.btnMostrarContactos.Click += new System.EventHandler(this.btnMostrarContactos_Click);
            // 
            // dtgVisualizar
            // 
            this.dtgVisualizar.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dtgVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisualizar.Location = new System.Drawing.Point(232, 311);
            this.dtgVisualizar.Name = "dtgVisualizar";
            this.dtgVisualizar.Size = new System.Drawing.Size(530, 199);
            this.dtgVisualizar.TabIndex = 1;
            this.dtgVisualizar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgVisualizar_RowHeaderMouseClick);
            // 
            // lblidcontacto
            // 
            this.lblidcontacto.AutoSize = true;
            this.lblidcontacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblidcontacto.ForeColor = System.Drawing.Color.DimGray;
            this.lblidcontacto.Location = new System.Drawing.Point(212, 111);
            this.lblidcontacto.Name = "lblidcontacto";
            this.lblidcontacto.Size = new System.Drawing.Size(158, 25);
            this.lblidcontacto.TabIndex = 2;
            this.lblidcontacto.Text = "Id del contacto:";
            // 
            // txtidcontacto
            // 
            this.txtidcontacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtidcontacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidcontacto.ForeColor = System.Drawing.Color.DimGray;
            this.txtidcontacto.Location = new System.Drawing.Point(426, 116);
            this.txtidcontacto.Name = "txtidcontacto";
            this.txtidcontacto.Size = new System.Drawing.Size(139, 20);
            this.txtidcontacto.TabIndex = 3;
            // 
            // lblNombrecontacto
            // 
            this.lblNombrecontacto.AutoSize = true;
            this.lblNombrecontacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblNombrecontacto.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombrecontacto.Location = new System.Drawing.Point(212, 147);
            this.lblNombrecontacto.Name = "lblNombrecontacto";
            this.lblNombrecontacto.Size = new System.Drawing.Size(191, 25);
            this.lblNombrecontacto.TabIndex = 4;
            this.lblNombrecontacto.Text = "Nombre y apellido:";
            // 
            // txtNombrecontacto
            // 
            this.txtNombrecontacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombrecontacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrecontacto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrecontacto.Location = new System.Drawing.Point(426, 152);
            this.txtNombrecontacto.Name = "txtNombrecontacto";
            this.txtNombrecontacto.Size = new System.Drawing.Size(206, 20);
            this.txtNombrecontacto.TabIndex = 5;
            // 
            // lblNoTelefono
            // 
            this.lblNoTelefono.AutoSize = true;
            this.lblNoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblNoTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.lblNoTelefono.Location = new System.Drawing.Point(212, 186);
            this.lblNoTelefono.Name = "lblNoTelefono";
            this.lblNoTelefono.Size = new System.Drawing.Size(206, 25);
            this.lblNoTelefono.TabIndex = 6;
            this.lblNoTelefono.Text = "Numero de telefono:";
            // 
            // txtNotelefono
            // 
            this.txtNotelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNotelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtNotelefono.Location = new System.Drawing.Point(426, 191);
            this.txtNotelefono.Name = "txtNotelefono";
            this.txtNotelefono.Size = new System.Drawing.Size(206, 20);
            this.txtNotelefono.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCorreo.Location = new System.Drawing.Point(212, 222);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(83, 25);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(426, 227);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(206, 20);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblTipoContacto
            // 
            this.lblTipoContacto.AutoSize = true;
            this.lblTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTipoContacto.ForeColor = System.Drawing.Color.DimGray;
            this.lblTipoContacto.Location = new System.Drawing.Point(212, 257);
            this.lblTipoContacto.Name = "lblTipoContacto";
            this.lblTipoContacto.Size = new System.Drawing.Size(182, 25);
            this.lblTipoContacto.TabIndex = 10;
            this.lblTipoContacto.Text = "Tipo de Contacto:";
            // 
            // txtTipoContacto
            // 
            this.txtTipoContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTipoContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoContacto.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipoContacto.Location = new System.Drawing.Point(426, 262);
            this.txtTipoContacto.Name = "txtTipoContacto";
            this.txtTipoContacto.Size = new System.Drawing.Size(206, 20);
            this.txtTipoContacto.TabIndex = 11;
            // 
            // btnCerrarPagina
            // 
            this.btnCerrarPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarPagina.Image")));
            this.btnCerrarPagina.Location = new System.Drawing.Point(776, 0);
            this.btnCerrarPagina.Name = "btnCerrarPagina";
            this.btnCerrarPagina.Size = new System.Drawing.Size(30, 28);
            this.btnCerrarPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarPagina.TabIndex = 12;
            this.btnCerrarPagina.TabStop = false;
            this.btnCerrarPagina.Click += new System.EventHandler(this.btnCerrarPagina_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(740, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(438, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(49, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 25);
            this.lblFecha.TabIndex = 9;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(806, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrarPagina);
            this.Controls.Add(this.txtTipoContacto);
            this.Controls.Add(this.lblTipoContacto);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNotelefono);
            this.Controls.Add(this.lblNoTelefono);
            this.Controls.Add(this.txtNombrecontacto);
            this.Controls.Add(this.lblNombrecontacto);
            this.Controls.Add(this.txtidcontacto);
            this.Controls.Add(this.lblidcontacto);
            this.Controls.Add(this.dtgVisualizar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMostrarContactos;
        private System.Windows.Forms.PictureBox btnMostrarContactos;
        private System.Windows.Forms.DataGridView dtgVisualizar;
        private System.Windows.Forms.Label lblAgregarContacto;
        private System.Windows.Forms.PictureBox btnAgregarContacto;
        private System.Windows.Forms.Label lblidcontacto;
        private System.Windows.Forms.TextBox txtidcontacto;
        private System.Windows.Forms.Label lblNombrecontacto;
        private System.Windows.Forms.TextBox txtNombrecontacto;
        private System.Windows.Forms.Label lblNoTelefono;
        private System.Windows.Forms.TextBox txtNotelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblBorraContacto;
        private System.Windows.Forms.PictureBox btnBorrarInfo;
        private System.Windows.Forms.Label lblTipoContacto;
        private System.Windows.Forms.TextBox txtTipoContacto;
        private System.Windows.Forms.Label lblEditarContacto;
        private System.Windows.Forms.PictureBox btnEditarContacto;
        private System.Windows.Forms.PictureBox btnCerrarPagina;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}