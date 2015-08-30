using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
// Programador y Analista: Gerardo santizo
//Fecha inicio: 18 de Agosto  fecha de fin: 20 de Agosto
namespace Aerolinea
{
    public partial class frmbitacora : Form
    {
        public frmbitacora()
        {
            InitializeComponent();
        }
        private void funllenarGridBitacora()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodbitacora as CodigoBitacora, dfecha as FechaAccion, dthora as HoraAccion, vuser as Usuario, vaccion as Accion, vnombreEquipo as NombreMaquina, vtabla as Tabla from AEROLINEA.TrBITACORA";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdBitacora.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void frmbitacora_Load(object sender, EventArgs e)
        {
            funllenarGridBitacora();
        }

        private void rEFRESCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funllenarGridBitacora();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
