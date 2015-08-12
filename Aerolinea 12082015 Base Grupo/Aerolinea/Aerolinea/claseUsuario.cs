using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;
namespace Aerolinea
{
    class claseUsuario
    {
        public static int Autentificar(String txtUsuario, String txtContra)
        {
            int resultado = -1;

            MySqlConnection conexion = clasconexion.funobtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from mausuario where vuser = '{0}' and vpassword = '{1}'", txtUsuario, txtContra), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        public static String user(String txtUsuario, String txtContra)
        {
            //int resultado = -1;
            String total = "";
            MySqlConnection conexion = clasconexion.funobtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("select mausuario.vapeusuario , mausuario.vuser , trtipousuario.vdescripciontipo from mausuario inner join trtipousuario on trtipousuario.ncodtipousuario = mausuario.ncodtipousuario where vuser = '{0}' and vpassword = '{1}'", txtUsuario, txtContra), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                total = reader.GetString(2);
            }

            conexion.Close();
            return total;
        }

    }
}
