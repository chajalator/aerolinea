using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//Programador y Analista: Sabrina G�mez
namespace Aerolinea
{
    public class clasconexion
    {
        public static MySqlConnection funobtenerConexion() {
            MySqlConnection conectar = new MySqlConnection("server=localhost;user=root;Password=negritalinda;database =aerolinea");
            conectar.Open();
            return conectar;
        }
       

    }
}
