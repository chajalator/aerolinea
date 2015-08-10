using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
