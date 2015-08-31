using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
//Programador y Analista: Gerardo Santizo
//Fecha inicio: 29/08/2015  Fecha finalizacion: 30/08/2015

namespace Aerolinea
{
    public partial class frmreporteUsuarios : Form
    {
        public frmreporteUsuarios()
        {
            InitializeComponent();
        }

        private void fromreporteUsuarios_Load(object sender, EventArgs e)
        {
            funllenarGridReporte();
            funllenarGridReporteGeneral();
        }
        private void funllenarGridReporte()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT vuser as NombreUsuario, vaccion as Accion, count(vaccion) as transacciones from TrBITACORA group by vaccion";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdReporte.DataSource = dtDatos;

            }
        }
        private void funllenarGridReporteGeneral()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT vuser as NombreUsuario, count(vaccion) as transacciones from TrBITACORA group by vuser";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdReporte2.DataSource = dtDatos;
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rEFRESCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funllenarGridReporte();
            funllenarGridReporte();
        }

    }
}
