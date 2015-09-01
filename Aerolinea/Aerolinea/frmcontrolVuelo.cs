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
                string squery = "SELECT vdescripcion as Lugar FROM TrDESTINO order by vdescripcion asc";
                MySqlCommand cmd1 = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbdestino.DataSource = dtDatos;
                cmbdestino.DisplayMember = "Lugar";
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funconsultaLocalidad2()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryL = "SELECT vdescripcion as Lugar FROM TrDESTINO order by vdescripcion asc";
                MySqlCommand cmdl = new MySqlCommand(squeryL, clasconexion.funobtenerConexion());
                DataTable dtDatosL = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squeryL, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatosL);
                cmborigen.DataSource = dtDatosL;
                cmborigen.DisplayMember = "Lugar";
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funcodVuelo()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery2 = "SELECT vaerolinea as aerolinea FROM MaAVION order by vaerolinea asc";
                MySqlCommand cmd2 = new MySqlCommand(squery2, clasconexion.funobtenerConexion());
                DataTable dtDatos2 = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery2, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos2);
                cmbaerolinea.DataSource = dtDatos2;
                cmbaerolinea.DisplayMember = "aerolinea";
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funconsultaTv() {
            try{
                using (clasconexion.funobtenerConexion()) {
                    string sconsultaTv = "SELECT vdescripcion as TipoVuelo From MaTIPOVUELO order by vdescripcion asc";
                    MySqlCommand cmdconsultaTv = new MySqlCommand(sconsultaTv, clasconexion.funobtenerConexion());
                    DataTable dtconsultaTv = new DataTable();
                    MySqlDataAdapter mdConsultaTv = new MySqlDataAdapter(sconsultaTv, clasconexion.funobtenerConexion());
                    mdConsultaTv.Fill(dtconsultaTv);
                    cmbtipoVuelo.DataSource = dtconsultaTv;
                    cmbtipoVuelo.DisplayMember = "TipoVuelo";
                    clasconexion.funobtenerConexion().Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funconsultaAeropuerto() {
            try {
                using (clasconexion.funobtenerConexion()) {
                    int icodl;
                    string slugar = "select ncodtipodestino as Destino from TrDESTINO where vdescripcion='"+ cmbdestino.Text +"'";
                    MySqlCommand scodl = new MySqlCommand(slugar, clasconexion.funobtenerConexion());
                    icodl = Convert.ToInt32(scodl.ExecuteScalar());
                    
                    string sconsultaA = "SELECT vnombreaeropuerto as Aeropuerto from MaAEROPUERTO where ncodtipodestino="+icodl+" order by vnombreaeropuerto asc";
                    MySqlCommand cmdconsultaA = new MySqlCommand(sconsultaA, clasconexion.funobtenerConexion());
                    DataTable dtconsultaA = new DataTable();
                    MySqlDataAdapter mdconsultaA = new MySqlDataAdapter(sconsultaA, clasconexion.funobtenerConexion());
                    mdconsultaA.Fill(dtconsultaA);
                    cmbaeropuerto.DataSource = dtconsultaA;
                    cmbaeropuerto.DisplayMember = "Aeropuerto";
                    clasconexion.funobtenerConexion().Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funconsultarVuelos()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery3 = "SELECT  ncodvuelo as Codigo_vuelo,vlugarsalida as Lugar_salida,dfechavuelo as Fecha_vuelo,dthoradespegue as Hora_Despegue,dthoraaterrisaje as Hora_Aterrisaje, ncodavion as Codigo_avion,ncodtipodestino as Codigo_Destino FROM MaVUELO";
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
                string squeryb = "SELECT  ncodvuelo as Codigo_vuelo,vlugarsalida as Lugar_salida,dfechavuelo as Fecha_vuelo,dthoradespegue as Hora_Despegue,dthoraaterrisaje as Hora_Aterrisaje, ncodavion as Codigo_avion,ncodtipodestino as Codigo_Destino FROM MaVUELO WHERE vlugarsalida='" + txtBuscar.Text + "' or ncodtipodestino='" + txtBuscar.Text + "' or ncodvuelo='" + txtBuscar.Text + "' or dfechavuelo like '%"+txtBuscar.Text+"%'";
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
            cmbaerolinea.Text = "";
            cmbaeropuerto.Text = "";
            cmbdestino.Text = "";
            cmbembarque.Text="";
            cmborigen.Text = "";
            cmbterminal.Text = "";
            cmbtipoVuelo.Text = "";
            txtBuscar.Text = "";
            mtxhoraDespegue.Text="";
            mtxhoraLlegada.Text="";

        }

        private void frmcontrolVuelo_Load(object sender, EventArgs e)
        {
            funconsultaLocalidad();
            funconsultaLocalidad2();
            funcodVuelo();
            funconsultarVuelos();
            funconsultaTv();
            funlimpiar();
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            funbuscarVuelo();
        }
        
        private void btnGuardarVuelo_Click_1(object sender, EventArgs e)
        {
            try
            {

                int icodigoVuelo;
                int icodavion;
                int icodtipoV;
                int icoddestino;
                int icodaeropuerto;
                using (clasconexion.funobtenerConexion()){
                    //PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
                    string squery = "SELECT COUNT(*) As Cant FROM AEROLINEA.MaVUELO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    icodigoVuelo = (Convert.ToInt32(cmd.ExecuteScalar())) + 1;

                    string scodavion = "SELECT ncodavion as codigoavion from MaAVION where vaerolinea='"+ cmbaerolinea.Text +"';";
                    MySqlCommand cmdcodavion = new MySqlCommand(scodavion, clasconexion.funobtenerConexion());
                    icodavion = Convert.ToInt32(cmdcodavion.ExecuteScalar());

                    string scodtipoV = "SELECT ncodtipovuelo as codigotipovuelo from MaTIPOVUELO where vdescripcion='"+ cmbtipoVuelo.Text +"';";
                    MySqlCommand cmdcodtipov = new MySqlCommand(scodtipoV,clasconexion.funobtenerConexion());
                    icodtipoV = Convert.ToInt32(cmdcodtipov.ExecuteScalar());

                    string scoddestino = "SELECT ncodtipodestino as destino from TrDESTINO where vdescripcion='"+ cmbdestino.Text +"';";
                    MySqlCommand cmddestino = new MySqlCommand(scoddestino, clasconexion.funobtenerConexion());
                    icoddestino = Convert.ToInt32(cmddestino.ExecuteScalar());

                    string scodaeropuerto = "SELECT ncodaeropuerto as aeropuerto from MaAEROPUERTO where vnombreaeropuerto='"+ cmbaeropuerto.Text +"';";
                    MySqlCommand cmdaeropuerto = new MySqlCommand(scodaeropuerto, clasconexion.funobtenerConexion());
                    icodaeropuerto = Convert.ToInt32(cmdaeropuerto.ExecuteScalar());
                    
                    //Programado Y Analista: Jose Alberto Oxcal Ley
                 
                    string sinsertarVuelo = "INSERT INTO MaVUELO (ncodvuelo,vlugarsalida,dfechavuelo,dthoradespegue,dthoraaterrisaje,vdisponibilidad,nterminal,nembarque,ncodavion,ncodtipovuelo,ncodtipodestino,ncodaeropuerto)"+
                        " VALUES("+ icodigoVuelo + ",'" + cmborigen.Text + "','" + dtFechaVuelo.Text + "','" + mtxhoraDespegue.Text + "','" + mtxhoraLlegada.Text + "','ACTIVO','"+ cmbterminal.Text +"','"+ cmbembarque.Text +"',"+icodavion+","+ icodtipoV +","+ icoddestino +","+ icodaeropuerto +");";
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

        private void cmbdestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            funconsultaAeropuerto();
            cmbaeropuerto.Text = "";
        }

      
    }
}
