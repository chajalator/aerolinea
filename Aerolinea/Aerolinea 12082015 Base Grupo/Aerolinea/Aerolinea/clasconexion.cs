using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//Programador y Analista: Sabrina Maria Gómez Giron
namespace Aerolinea
{
    public class clasconexion
    {
        public static MySqlConnection funobtenerConexion() {
            MySqlConnection conectar = new MySqlConnection("server=localhost;userid=root;password= ;database=xx");
            //MySqlConnection conectar = new MySqlConnection("server=192.168.15.1; database=AEROLINEA; Uid=Aerolinea; pwd=aerolinea2015;");
            conectar.Open();
            return conectar;
        }
       

    }
}
