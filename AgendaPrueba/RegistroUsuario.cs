using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaPrueba
{
    class RegistroUsuario
    {
        public static int RegistrarUser(string NomUsuario, string Constraseña)
        {
            int result = 0;

            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RN767F9\SQLEXPRESS;Initial Catalog=Agendaa;Integrated Security=True");
            cn.Open();

            SqlCommand cmm = new SqlCommand(string.Format("Insert into Usuar (Nombre,Contraseña) Values('{0}',('{1}'))", NomUsuario, Constraseña),cn);
            result = cmm.ExecuteNonQuery();
            cn.Close();

            return result;

        }
    }
}
