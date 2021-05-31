using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaPrueba
{
    
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
          //  if (RegistroUsuario.RegistrarUser(txtNombrUsuario.Text, txtContraUsuario.Text)>0)
          //  {
           //     MessageBox.Show("Usuario registrado con exito");
           // }
           // else
           // {
            //    MessageBox.Show("No se registro con exito");
           // }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (RegistroUsuario.RegistrarUser(txtNombrUsuario.Text, txtContraUsuario.Text) > 0)
            {
                //MessageBox.Show("Usuario registrado con exito");

                this.Hide();

                frmLogin frmLog = new frmLogin();

                frmLog.Show();
            }
            else
            {
                MessageBox.Show("No se registro con exito");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frmLog = new frmLogin();
            frmLog.Show();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContraUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContraUsuario.UseSystemPasswordChar = true;
        }
    }
}
