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
//PROGRAMADOR Y ANALISTA: Jose Alberto Oxcal ley
//Fecha Inicio: 13/agosto/2015      Fecha fin: 17/agosto/2015
namespace Aerolinea
{
    public partial class frmcontrolLocalizaciones : Form
    {
        //variables
        
        public frmcontrolLocalizaciones()
        {
            InitializeComponent();
        }

        private void funconsultarLugares()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squerybuscarLugar = "SELECT  ncodtipodestino as CodigoLocalizacion,vdescripcion as Lugar FROM TrDESTINO ORDER BY CodigoLocalizacion ASC;";
                MySqlCommand cmdb = new MySqlCommand(squerybuscarLugar, clasconexion.funobtenerConexion());
                DataTable dtDatosb = new DataTable();
                MySqlDataAdapter mdaDatosb = new MySqlDataAdapter(squerybuscarLugar, clasconexion.funobtenerConexion());
                mdaDatosb.Fill(dtDatosb);
                grdAertopuerto.DataSource = dtDatosb;
                grdAertopuerto.AutoResizeColumns();
                cmbLugar.DataSource = dtDatosb;
                cmbLugar.DisplayMember = "Lugar";
                clasconexion.funobtenerConexion().Close();
            }
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
            if (tabLocalizacion.SelectedIndex==0)
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
                        
                        //PROGRAMADOR Y ANALISTA: Jose Alberto Oxcal Ley
                        string sinsertaravion = "INSERT INTO aerolinea.TrDESTINO (ncodtipodestino,vdescripcion) VALUES(" + icodigoLocalizacion + ",'" + txtLugar.Text + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sinsertaravion, clasconexion.funobtenerConexion());
                        MySqlDataReader MyReader;
                        MyReader = cmd1.ExecuteReader();
                        MessageBox.Show("LOCACION ALMACENADA");
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
            else if(tabLocalizacion.SelectedIndex==1){
                using (clasconexion.funobtenerConexion()) {
                    int idestino;
                    int icodigoAeropuerto;
                    string scodigo = "SELECT ncodtipodestino as destino FROM aerolinea.TrDESTINO WHERE vdescripcion='"+ cmbLugar.Text +"'";
                    MySqlCommand ccod = new MySqlCommand(scodigo, clasconexion.funobtenerConexion());
                    idestino = Convert.ToInt32(ccod.ExecuteScalar());

                    string sposicion = "SELECT COUNT(*) As Cant FROM aerolinea.MaAEROPUERTO";
                    MySqlCommand cpos = new MySqlCommand(sposicion, clasconexion.funobtenerConexion());
                    icodigoAeropuerto = (Convert.ToInt32(cpos.ExecuteScalar())) + 1;



                    string sinsertaraeropuerto = "INSERT INTO aerolinea.MaAEROPUERTO (ncodaeropuerto,vnombreaeropuerto,ncodtipodestino) VALUES("+ icodigoAeropuerto +",'"+ txtAeropuerto.Text +"',"+ idestino +")";
                    MySqlCommand cinsertar = new MySqlCommand(sinsertaraeropuerto, clasconexion.funobtenerConexion());
                    MySqlDataReader Myguardar;
                    Myguardar = cinsertar.ExecuteReader();
                    MessageBox.Show("AEROPUERTO ALMACENADO");
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();

                    
                }
            }
        }

       

        private void funlimpiar()
        {
            txtLugar.Text = "";
            txtAeropuerto.Text = "";
            cmbLugar.Text = "";


        }

        private void frmcontrolLocalizaciones_Load(object sender, EventArgs e)
        {
            funconsultarLugares();
        }
        
        private void tabpLocalizacion_Click(object sender, EventArgs e)
        {
        }

        private void tabpaeropuerto_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarLocalización_Click(object sender, EventArgs e)
        {

        }
    }
}
