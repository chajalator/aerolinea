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
        
        public frmcontrolLocalizaciones()
        {
            InitializeComponent();
        }

        private void funconsultarLugares()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squerybuscarLugar = "SELECT  vdescripcion as Lugar,ncodtipodestino as CodigoLocacion FROM aerolinea.TrDESTINO ORDER BY CodigoLocacion ASC;";
                MySqlCommand cmdb = new MySqlCommand(squerybuscarLugar, clasconexion.funobtenerConexion());
                DataTable dtDatosb = new DataTable();
                MySqlDataAdapter mdaDatosb = new MySqlDataAdapter(squerybuscarLugar, clasconexion.funobtenerConexion());
                mdaDatosb.Fill(dtDatosb);
                grdLocacion.DataSource = dtDatosb;
                grdLocacion.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funaeropuerto()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryaeropuerto = "SELECT vdescripcion as Lugar,ncodtipodestino as Destin FROM TrDESTINO ORDER BY vdescripcion ASC;";
                MySqlCommand cmdA = new MySqlCommand(squeryaeropuerto, clasconexion.funobtenerConexion());
                DataTable dtAeropuerto = new DataTable();
                MySqlDataAdapter mdaDatosA = new MySqlDataAdapter(squeryaeropuerto, clasconexion.funobtenerConexion());
                mdaDatosA.Fill(dtAeropuerto);
                cmbLugar.DataSource = dtAeropuerto;
                cmbLugar.DisplayMember = "Lugar";
                cmbLugar.ValueMember = "Destin";
                clasconexion.funobtenerConexion().Close();
            }
        }
        
        private void funconsultarAeropuerto() { 
            string sbuscarAeropuerto="SELECT vdescripcion as Locacion, vnombreaeropuerto as Aeropuerto from maaeropuerto "+
                "inner join trdestino on maaeropuerto.ncodtipodestino=trdestino.ncodtipodestino order by trdestino.vdescripcion asc";
            MySqlCommand cbuscarAeropuerto = new MySqlCommand(sbuscarAeropuerto,clasconexion.funobtenerConexion());
            DataTable dtAeropuerto = new DataTable();
            MySqlDataAdapter mdaAerolinea = new MySqlDataAdapter(sbuscarAeropuerto,clasconexion.funobtenerConexion());
            mdaAerolinea.Fill(dtAeropuerto);
            grdAeropuerto.DataSource = dtAeropuerto;
            grdAeropuerto.AutoResizeColumns();
            clasconexion.funobtenerConexion().Close();
        }

        private void funbuscarLocalizacion() {
            using (clasconexion.funobtenerConexion()) {
                string sbuscarL = "SELECT vdescripcion as Lugar,ncodtipodestino as CodigoLocacion FROM aerolinea.TrDESTINO WHERE vdescripcion='" + txtBuscarLocalizacion.Text + "';";
                MySqlCommand buscarL = new MySqlCommand(sbuscarL, clasconexion.funobtenerConexion());
                DataTable dtDatosL = new DataTable();
                MySqlDataAdapter mdDatosL = new MySqlDataAdapter(sbuscarL, clasconexion.funobtenerConexion());
                mdDatosL.Fill(dtDatosL);
                grdLocacion.DataSource = dtDatosL;
                grdLocacion.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();

            }
        }

        private void funbuscarAeropuerto() {
            string sbuscarA = "SELECT vdescripcion as Locacion, vnombreaeropuerto as Aeropuerto from maaeropuerto " +
                "inner join trdestino on maaeropuerto.ncodtipodestino=trdestino.ncodtipodestino "+
                "WHERE trdestino.vdescripcion='" + txtBuscarAeropuerto.Text + "' or maaeropuerto.vnombreaeropuerto='"+ txtBuscarAeropuerto.Text +"' order by trdestino.vdescripcion asc";
            MySqlCommand buscarA = new MySqlCommand(sbuscarA, clasconexion.funobtenerConexion());
            DataTable dtDatosA=new DataTable();
            MySqlDataAdapter mdDatosA = new MySqlDataAdapter(sbuscarA, clasconexion.funobtenerConexion());
            mdDatosA.Fill(dtDatosA);
            grdAeropuerto.DataSource = dtDatosA;
            grdAeropuerto.AutoResizeColumns();
            clasconexion.funobtenerConexion().Close();

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
                    if (txtLugar.Text != "")
                    {
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
                    else { MessageBox.Show("Ingrese Lugar"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (tabLocalizacion.SelectedIndex == 1)
            {
                
                try
                {
                    if ((txtAeropuerto.Text != "") && (cmbLugar.Text != ""))
                    {
                        using (clasconexion.funobtenerConexion())
                        {
                            int idestino;
                            int icodigoAeropuerto;
                            string scodigo = "SELECT ncodtipodestino as destino FROM aerolinea.TrDESTINO WHERE vdescripcion='" + cmbLugar.Text + "'";
                            MySqlCommand ccod = new MySqlCommand(scodigo, clasconexion.funobtenerConexion());
                            idestino = Convert.ToInt32(ccod.ExecuteScalar());

                            string sposicion = "SELECT COUNT(*) As Cant FROM aerolinea.MaAEROPUERTO";
                            MySqlCommand cpos = new MySqlCommand(sposicion, clasconexion.funobtenerConexion());
                            icodigoAeropuerto = (Convert.ToInt32(cpos.ExecuteScalar())) + 1;

                            string sinsertaraeropuerto = "INSERT INTO aerolinea.MaAEROPUERTO (ncodaeropuerto,vnombreaeropuerto,ncodtipodestino) VALUES(" + icodigoAeropuerto + ",'" + txtAeropuerto.Text + "'," + idestino + ")";
                            MySqlCommand cinsertar = new MySqlCommand(sinsertaraeropuerto, clasconexion.funobtenerConexion());
                            MySqlDataReader Myguardar;
                            Myguardar = cinsertar.ExecuteReader();
                            MessageBox.Show("AEROPUERTO ALMACENADO");
                            clasconexion.funobtenerConexion().Close();
                            funlimpiar();
                            funconsultarAeropuerto();

                        }
                    }
                    else { MessageBox.Show("Ingrese Lugar y Aeropuerto"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void funlimpiar()
        {
            txtLugar.Text = "";
            txtAeropuerto.Text = "";
            cmbLugar.Text = "";
            txtBuscarLocalizacion.Text = "";
            txtBuscarAeropuerto.Text = "";

        }

        private void frmcontrolLocalizaciones_Load(object sender, EventArgs e)
        {
            funconsultarLugares();
            funconsultarAeropuerto();
            funaeropuerto();
            funlimpiar();
        }
        
        private void tabpLocalizacion_Click(object sender, EventArgs e)
        {
        }

        private void tabpaeropuerto_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarLocalización_Click(object sender, EventArgs e)
        {
            if (tabLocalizacion.SelectedIndex == 0) {
                funbuscarLocalizacion();
            }
            else if (tabLocalizacion.SelectedIndex == 1) {
                funbuscarAeropuerto();
            }
            
            funlimpiar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (tabLocalizacion.SelectedIndex == 0) {
                funconsultarLugares();
            }else if(tabLocalizacion.SelectedIndex==1){
                funconsultarAeropuerto();
            }
                
        }
    }
}
