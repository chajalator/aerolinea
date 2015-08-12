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
//PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
//Fecha Inicio:  10/Agosto/2015      Fecha Fin: 10/Agosto/2015
namespace Aerolinea
{
    public partial class frmcontrolLocalizaciones : Form
    {
        public frmcontrolLocalizaciones()
        {
            InitializeComponent();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void rEGRESARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrolVuelo mn = new frmcontrolVuelo();
            mn.Show();
            this.Hide();
        }

        private void btnGuardarAvion_Click(object sender, EventArgs e)
        {
            try
            {
                int ifilas;
                int icodigoLocalizacion;

                using (clasconexion.funobtenerConexion())
                {
                    //PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.TrDESTINO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    ifilas = Convert.ToInt32(cmd.ExecuteScalar());
                    icodigoLocalizacion = ifilas + 1;
                    clasconexion.funobtenerConexion().Close();


                }
                using (clasconexion.funobtenerConexion())
                {
                    string sinsertaravion = "INSERT INTO aerolinea.TrDESTINO (ncodtipodestino,vdescripcion) VALUES(" + icodigoLocalizacion +  ",'" + txtLugar.Text + "')";
                    MySqlCommand cmd1 = new MySqlCommand(sinsertaravion, clasconexion.funobtenerConexion());
                    MySqlDataReader MyReader;
                    MyReader = cmd1.ExecuteReader();
                    MessageBox.Show("AVION ALMACENADO");
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();
                    funconsultarLugares();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void funconsultarLugares()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squerybuscarLugar = "SELECT  ncodtipodestino as CodigoLocalizacion,vdescripcion as Lugar FROM TrDESTINO;";
                MySqlCommand cmdb = new MySqlCommand(squerybuscarLugar, clasconexion.funobtenerConexion());
                DataTable dtDatosb = new DataTable();
                MySqlDataAdapter mdaDatosb = new MySqlDataAdapter(squerybuscarLugar, clasconexion.funobtenerConexion());
                mdaDatosb.Fill(dtDatosb);
                grdLocalizaciones.DataSource = dtDatosb;
                grdLocalizaciones.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funlimpiar()
        {
            txtLugar.Text = "";

        }

        private void frmcontrolLocalizaciones_Load(object sender, EventArgs e)
        {
            funconsultarLugares();
        }
    }
}
