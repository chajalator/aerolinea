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
    public partial class frmcontrolVuelo : Form
    {
        public frmcontrolVuelo()
        {
            InitializeComponent();
        }

        private void funconsultaLocalidad() { 
            using (clasconexion.funobtenerConexion()){
                string squery = "SELECT vdescripcion as Lugar FROM trdestino";
                MySqlCommand cmd1 = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbDestino.DataSource = dtDatos;
                cmbDestino.DisplayMember = "Lugar";
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funconsultaLocalidad2()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryL = "SELECT vdescripcion as Lugar FROM trdestino";
                MySqlCommand cmdl = new MySqlCommand(squeryL, clasconexion.funobtenerConexion());
                DataTable dtDatosL = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squeryL, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatosL);
                cmbOrigen.DataSource = dtDatosL;
                cmbOrigen.DisplayMember = "Lugar";
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funcodVuelo()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery2 = "SELECT ncodavion as codigo FROM maavion";
                MySqlCommand cmd2 = new MySqlCommand(squery2, clasconexion.funobtenerConexion());
                DataTable dtDatos2 = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery2, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos2);
                cmbCodAvion.DataSource = dtDatos2;
                cmbCodAvion.DisplayMember = "codigo";
                clasconexion.funobtenerConexion().Close();
            }
        }


        private void funconsultarVuelos()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery3 = "SELECT  ncodvuelo as Codigo_vuelo,vlugarsalida as Lugar_salida,dfechavuelo as Fecha_vuelo,dthoradespegue as Hora_Despegue,dthoraaterrisaje as Hora_Aterrisaje, ncodavion as Codigo_avion,ncodtipodestino as Codigo_Destino FROM mavuelo";
                MySqlCommand cmdv = new MySqlCommand(squery3, clasconexion.funobtenerConexion());
                DataTable dtDatos3 = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery3, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos3);
                grdVuelo.DataSource = dtDatos3;
                grdVuelo.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funbuscarVuelo() {
            using (clasconexion.funobtenerConexion()) {
                string squeryb = "SELECT  ncodvuelo as Codigo_vuelo,vlugarsalida as Lugar_salida,dfechavuelo as Fecha_vuelo,dthoradespegue as Hora_Despegue,dthoraaterrisaje as Hora_Aterrisaje, ncodavion as Codigo_avion,ncodtipodestino as Codigo_Destino FROM mavuelo WHERE vlugarsalida='" + txtBuscar.Text + "' or ncodtipodestino='" + txtBuscar.Text + "' or ncodvuelo='" + txtBuscar.Text + "' or dfechavuelo like '%"+txtBuscar.Text+"%'";
                MySqlCommand cmdb = new MySqlCommand(squeryb, clasconexion.funobtenerConexion());
                DataTable dtDatosb = new DataTable();
                MySqlDataAdapter mdaDatosb = new MySqlDataAdapter(squeryb, clasconexion.funobtenerConexion());
                mdaDatosb.Fill(dtDatosb);
                grdVuelo.DataSource = dtDatosb;
                grdVuelo.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void funlimpiar() {
            
            cmbCodAvion.Text = "";
            cmbDestino.Text = "";
            cmbOrigen.Text = "";
            mtxhoraDespegue.Text = "";
            mtxhoraLlegada.Text = "";
        }


        

       

        private void frmcontrolVuelo_Load(object sender, EventArgs e)
        {
            funconsultaLocalidad();
            funconsultaLocalidad2();
            funcodVuelo();
            funconsultarVuelos();
            funlimpiar();
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            funbuscarVuelo();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarVuelo_Click_1(object sender, EventArgs e)
        {
            try
            {

                int ifilas;
                int icodigoVuelo;

                using (clasconexion.funobtenerConexion())
                {
                    //PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.MaVUELO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    ifilas = Convert.ToInt32(cmd.ExecuteScalar());
                    icodigoVuelo = ifilas + 1;
                    clasconexion.funobtenerConexion().Close();


                }
                using (clasconexion.funobtenerConexion())
                {
                    //if((txtCodVuelo.Text="") || (cmbCodAvion.Text="") || (cmbDestino.Text="") || (cmbOrigen.Text="") || (mtxhoraDespegue.Text="") || (mtxhoraLlegada.Text="")){
                    string sinsertarVuelo = "INSERT INTO MaVUELO (ncodvuelo,vlugarsalida,dfechavuelo,dthoradespegue,dthoraaterrisaje,ncodavion,ncodtipodestino,ndisponibilidad) VALUES('" + icodigoVuelo + "','" + cmbOrigen.Text + "','" + dtFechaVuelo.Text + "','" + mtxhoraDespegue.Text + "','" + mtxhoraLlegada.Text + "','" + cmbCodAvion.Text + "',' ',1)";
                    MySqlCommand cmd3 = new MySqlCommand(sinsertarVuelo, clasconexion.funobtenerConexion());
                    MySqlDataReader MyReader;
                    MyReader = cmd3.ExecuteReader();
                    MessageBox.Show("VUELO GUARDADO");
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();
                    funconsultarVuelos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarVuelo_Click_1(object sender, EventArgs e)
        {
            funbuscarVuelo();
        }

        private void btnModificarVuelo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void aGREGARLOCALIZACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrolLocalizaciones ctrllocalizaciones = new frmcontrolLocalizaciones();
            ctrllocalizaciones.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
