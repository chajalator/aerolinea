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
//PROGRAMADOR Y ANALISTA: Jose Alberto Oxcal Ley
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 09/Agosto/2015
namespace Aerolinea
{
    public partial class frmcontrolAvion : Form
    {
        public frmcontrolAvion()
        {
            InitializeComponent();
        }

        private void funconsultarAviones()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodavion as Codigo_Avion,nnoasientos as No_Asientos,nnofilas as No_Filas,vdescripciontipoavion as Descripcion FROM aerolinea.maavion WHERE ndisponibilidadavion=1";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdaviones.DataSource = dtDatos;
                grdaviones.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funlimpiar() {
            
            txtdescripcionAvion.Text = "";
            txtNoAsientos.Text = "";
            txtNoFilas.Text = "";
        }

        private void frmcontrolAvion_Load(object sender, EventArgs e)
        {
           funconsultarAviones();
        }

        private void btnGuardarAvion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void btnGuardarAvion_Click_2(object sender, EventArgs e)
        {
            try
            {
                int ifilas;
                int icodigoAvion;

                using (clasconexion.funobtenerConexion())
                {
                    //PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.MaAVION ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    ifilas = Convert.ToInt32(cmd.ExecuteScalar());
                    icodigoAvion = ifilas + 1;
                    clasconexion.funobtenerConexion().Close();


                }
                using (clasconexion.funobtenerConexion())
                {
                    string sinsertaravion = "INSERT INTO aerolinea.maavion (ncodavion,nnoasientos,nnofilas,vdescripciontipoavion,ndisponibilidadavion) VALUES(" + icodigoAvion + "," + txtNoAsientos.Text + "," + txtNoFilas.Text + ",'" + txtdescripcionAvion.Text + "',1)";
                    MySqlCommand cmd1 = new MySqlCommand(sinsertaravion, clasconexion.funobtenerConexion());
                    MySqlDataReader MyReader;
                    MyReader = cmd1.ExecuteReader();
                    MessageBox.Show("AVION ALMACENADO");
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();
                    funconsultarAviones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
