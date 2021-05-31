using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaPrueba
{
    
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        //Aqui se establece la conexion con la base de datos//
        private ConexionContactosDataContext cn = new ConexionContactosDataContext();
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        //Este metodo es para la creacion del boton mostrar contactos//
        private void btnMostrarContactos_Click(object sender, EventArgs e)
        {
            dtgVisualizar.DataSource = cn.MostrarContactos_Test();
        }

        //Este metodo es para limpiar los textbox//

        private void limpiar()
        {
            txtidcontacto.Text="";
            txtNombrecontacto.Text = "";
            txtNotelefono.Text = "";
            txtCorreo.Text = "";
            txtTipoContacto.Text = "";

        }

        //Aqui se manda a llamar el procedimiento almacenado "EliminarContacto"//
        private void btnBorrarInfo_Click(object sender, EventArgs e)
        {
            int idContacto = Convert.ToInt32(dtgVisualizar.CurrentRow.Cells[0].Value);


            cn.EliminarContacto_Test(idContacto);

            MessageBox.Show("Contacto eliminado");

            dtgVisualizar.DataSource = cn.MostrarContactos_Test();

            limpiar();

        }

        private void dtgVisualizar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dtgVisualizar.CurrentRow.Cells[0].Value != null)
            {
                txtidcontacto.Text = dtgVisualizar.CurrentRow.Cells[0].Value.ToString();
                txtNombrecontacto.Text = dtgVisualizar.CurrentRow.Cells[1].Value.ToString();
                txtNotelefono.Text = dtgVisualizar.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = dtgVisualizar.CurrentRow.Cells[3].Value.ToString();
                txtTipoContacto.Text= dtgVisualizar.CurrentRow.Cells[4].Value.ToString();


            }
            else
            {
                limpiar();
            }
        }

        //Aqui se manda a llamar el procedimientos almacenado "AgregarContacto"//
        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            cn.AgregarContacto_Test(Convert.ToInt32(txtidcontacto.Text), txtNombrecontacto.Text, txtNotelefono.Text, txtCorreo.Text, txtTipoContacto.Text);

            MessageBox.Show("Contacto Agregado");

            dtgVisualizar.DataSource = cn.MostrarContactos_Test();

            limpiar();
        }

        //Aqui se manda a llamar el procedimientos almacenado "EditarContacto"//
        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            int idContacto = Convert.ToInt32(dtgVisualizar.CurrentRow.Cells[0].Value);

            cn.ActualizarDatos_Test(Convert.ToInt32(txtidcontacto.Text), txtNombrecontacto.Text, txtNotelefono.Text, txtCorreo.Text, txtTipoContacto.Text);

            MessageBox.Show("Informacion de contacto actulizada");

            dtgVisualizar.DataSource = cn.MostrarContactos_Test();

            limpiar();
        }

        private void btnCerrarPagina_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
    }
}
