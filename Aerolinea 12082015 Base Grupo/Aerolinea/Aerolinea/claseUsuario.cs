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
        public static string varibaleUsuario;

        public static int Autentificar(String txtUsuario, String txtContra)
        {
            int resultado = -1;
            MySqlConnection conexion = clasconexion.funobtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from MaUSUARIO where vuser = '{0}' and vpassword = '{1}' and vestado = 'ACTIVO'", txtUsuario, txtContra), conexion);
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
            MySqlCommand comando = new MySqlCommand(String.Format("select MaUSUARIO.vapeusuario , MaUSUARIO.vuser , MaTIPOUSUARIO.vdescripciontipo from MaUSUARIO inner join MaTIPOUSUARIO on MaTIPOUSUARIO.ncodtipousuario = MaUSUARIO.ncodtipousuario where vuser = '{0}' and vpassword = '{1}'", txtUsuario, txtContra), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                total = reader.GetString(2);
            }
            conexion.Close();
            return total;
        }
        public static void funobtenerBitacora(String txtUsuario, String Accion, String table)
        {
            string sMachineName = Environment.MachineName;
            string query = string.Format("INSERT INTO TRBITACORA (vuser, dthora, dfecha, vnombreEquipo, vaccion, vtabla) VALUES('{0}',DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),'{1}','{2}','{3}')", txtUsuario, sMachineName, Accion, table);
            clasconexion.insertar(query);
        }

    }
}
