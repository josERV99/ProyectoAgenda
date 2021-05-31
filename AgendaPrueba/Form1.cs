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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //Este es el metodo en el que creamos la conexion con la base de datos//
        private void login()
        {
            //Aqui declaramos esta variable que guardara la direccion de la base de datos a la que nos conectaremos//
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RN767F9\SQLEXPRESS;Initial Catalog=Agendaa;Integrated Security=True");
            //Aqui abrimos la conexion//
            cn.Open();
            //Con este comando decimos donde se colocaran los valores de nuestra base de datos en este caso es en un textbox//
            SqlCommand cm = new SqlCommand("select Nombre, Contraseña from Usuar where Nombre= '" + txtUsuario.Text + "' and Contraseña= '" + txtContrseña.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();

            //Y utilizamos un if para controlar las opciones en dado caso que sea corecto despliega "Bienvenid@",
            //si es incorrecto dspliega "Mnesaje de que hay algo mal".
            if (dr.Read())
            {
                MessageBox.Show("Bienvenid@" + "" + txtUsuario.Text);

                //si los datos son correctos abre el form//


            } else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta");
            }

        }

        //Este boton es para mandar a llamar el metodo Login y que inicie sesion//
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            login();

            this.Hide();

            frmMenu frmMenu = new frmMenu();

            frmMenu.Show();
        }

        //Este metodo es para que no se muestre la contraseña al escribir//
        private void txtContrseña_Enter(object sender, EventArgs e)
        {
            txtContrseña.UseSystemPasswordChar = true;
        }

        //Este boton se usa para cerrar la ventana//
        private void pctbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Este boton se usa para minimizar la ventana//
        private void pctbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Con este boton mandamos a llamar el form de registro de usuario//
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Este se utiliza para esconder la ventana de Login//
            this.Hide();

            frmAddUser frm = new frmAddUser();

            frm.Show();
        }
    }
}