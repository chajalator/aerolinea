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
                string squery = "SELECT vdescripcion as Lugar FROM trdestino order by vdescripcion asc";
                MySqlCommand cmd1 = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbdestino.DataSource = dtDatos;
                cmbdestino.DisplayMember = "Lugar";
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funeliminar()
        {
            try
            {
                string seliminarV = "UPDATE MaVUELO set vdisponibilidad='INACTIVO' WHERE ncodvuelo=" + cmbeliminarVuelo.Text;
                MySqlCommand cmdelimiarV = new MySqlCommand(seliminarV, clasconexion.funobtenerConexion());
                cmdelimiarV.ExecuteNonQuery();
                clasconexion.funobtenerConexion().Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            funconsultarVuelos();
            funcomboE();
            funlimpiar();
        }

        private void funcomboE() {
            try {
                using (clasconexion.funobtenerConexion()) {
                    string scomboE = "SELECT ncodvuelo as Codigo from MaVuelo WHERE vdisponibilidad='ACTIVO' ORDER BY ncodvuelo ASC";
                    MySqlCommand cmdComboE = new MySqlCommand(scomboE,clasconexion.funobtenerConexion());
                    DataTable dtcomboE = new DataTable();
                    MySqlDataAdapter mdcomboE = new MySqlDataAdapter(scomboE,clasconexion.funobtenerConexion());
                    mdcomboE.Fill(dtcomboE);
                    cmbeliminarVuelo.DataSource = dtcomboE;
                    cmbeliminarVuelo.DisplayMember = "Codigo";
                    clasconexion.funobtenerConexion().Close();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funconsultaLocalidad2()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryL = "SELECT vdescripcion as Lugar FROM trdestino order by vdescripcion asc";
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
                string squery2 = "SELECT vaerolinea as aerolinea FROM maavion order by vaerolinea asc";
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
                    string sconsultaTv = "SELECT vdescripcion as TipoVuelo From matipovuelo order by vdescripcion asc";
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
                    string slugar = "select ncodtipodestino as Destino from trdestino where vdescripcion='"+ cmbdestino.Text +"'";
                    MySqlCommand scodl = new MySqlCommand(slugar, clasconexion.funobtenerConexion());
                    icodl = Convert.ToInt32(scodl.ExecuteScalar());
                    
                    string sconsultaA = "SELECT vnombreaeropuerto as Aeropuerto from maaeropuerto where ncodtipodestino="+icodl+" order by vnombreaeropuerto asc";
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
                string squery3 = "SELECT ncodvuelo as Codigo,dfechavuelo as FechaVuelo,vlugarsalida as Origen, dthoradespegue as HoraDespegue,trdestino.vdescripcion as Destino,dthoraaterrisaje as HoraAterrisaje,vnombreaeropuerto as Aeropuerto,nterminal as Terminal,nembarque as Embarque,matipovuelo.vdescripcion as TipoVuelo,maavion.vaerolinea as Aerolinea "+
                    "from mavuelo inner join trdestino on trdestino.ncodtipodestino=mavuelo.ncodtipodestino "+
                    "inner join maaeropuerto on maaeropuerto.ncodaeropuerto=mavuelo.ncodaeropuerto "+
                    "inner join matipovuelo on mavuelo.ncodtipovuelo=matipovuelo.ncodtipovuelo "+
                    "inner join maavion on maavion.ncodavion=mavuelo.ncodavion WHERE mavuelo.vdisponibilidad='ACTIVO' order by mavuelo.ncodvuelo asc;";
                MySqlCommand cmdv = new MySqlCommand(squery3, clasconexion.funobtenerConexion());
                DataTable dtDatos3 = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery3, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos3);
                grdVuelo.DataSource = dtDatos3;
                grdVuelo.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funconsultaV() {
            try {
                using (clasconexion.funobtenerConexion()) {
                    string sbuscarV = "SELECT ncodvuelo as Codigo,dfechavuelo as FechaVuelo,vlugarsalida as Origen, dthoradespegue as HoraDespegue,trdestino.vdescripcion as Destino,dthoraaterrisaje as HoraAterrisaje,vnombreaeropuerto as Aeropuerto,nterminal as Terminal,nembarque as Embarque,matipovuelo.vdescripcion as TipoVuelo,maavion.vaerolinea as Aerolinea,mavuelo.vdisponibilidad as Disponibilidad " +
                    "from mavuelo inner join trdestino on trdestino.ncodtipodestino=mavuelo.ncodtipodestino " +
                    "inner join maaeropuerto on maaeropuerto.ncodaeropuerto=mavuelo.ncodaeropuerto " +
                    "inner join matipovuelo on mavuelo.ncodtipovuelo=matipovuelo.ncodtipovuelo " +
                    "inner join maavion on maavion.ncodavion=mavuelo.ncodavion WHERE vlugarsalida='"+ txtBuscar.Text +"' or  mavuelo.vdisponibilidad='ACTIVO' order by mavuelo.ncodvuelo asc;";
                    MySqlCommand cmdbuscarV = new MySqlCommand(sbuscarV,clasconexion.funobtenerConexion());
                    DataTable dtbuscarV = new DataTable();
                    MySqlDataAdapter mdbuscarV = new MySqlDataAdapter(sbuscarV,clasconexion.funobtenerConexion());
                    mdbuscarV.Fill(dtbuscarV);
                    grdVuelo.DataSource = dtbuscarV;
                    grdVuelo.AutoResizeColumns();
                    clasconexion.funobtenerConexion().Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            cmbeliminarVuelo.Text = "";

        }

        private void frmcontrolVuelo_Load(object sender, EventArgs e)
        {
            funconsultaLocalidad();
            funconsultaLocalidad2();
            funcodVuelo();
            funconsultarVuelos();
            funconsultaTv();
            funcomboE();
            funlimpiar();
        }

        
        
        private void btnGuardarVuelo_Click_1(object sender, EventArgs e)
        {
            if((mtxhoraDespegue.Text!="")&&(mtxhoraLlegada.Text!="")&&(cmbaerolinea.Text!="")&&(cmbaeropuerto.Text!="")&&(cmbdestino.Text!="")&&(cmbembarque.Text!="")&&(cmborigen.Text!="")&&(cmbterminal.Text!="")&&(cmbtipoVuelo.Text!="")){
            try
            {

                int icodigoVuelo;
                int icodavion;
                int icodtipoV;
                int icoddestino;
                int icodaeropuerto;
                using (clasconexion.funobtenerConexion()){
                    //PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.MaVUELO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    icodigoVuelo = (Convert.ToInt32(cmd.ExecuteScalar())) + 1;

                    string scodavion = "SELECT ncodavion as codigoavion from maavion where vaerolinea='"+ cmbaerolinea.Text +"';";
                    MySqlCommand cmdcodavion = new MySqlCommand(scodavion, clasconexion.funobtenerConexion());
                    icodavion = Convert.ToInt32(cmdcodavion.ExecuteScalar());

                    string scodtipoV = "SELECT ncodtipovuelo as codigotipovuelo from matipovuelo where vdescripcion='"+ cmbtipoVuelo.Text +"';";
                    MySqlCommand cmdcodtipov = new MySqlCommand(scodtipoV,clasconexion.funobtenerConexion());
                    icodtipoV = Convert.ToInt32(cmdcodtipov.ExecuteScalar());

                    string scoddestino = "SELECT ncodtipodestino as destino from trdestino where vdescripcion='"+ cmbdestino.Text +"';";
                    MySqlCommand cmddestino = new MySqlCommand(scoddestino, clasconexion.funobtenerConexion());
                    icoddestino = Convert.ToInt32(cmddestino.ExecuteScalar());

                    string scodaeropuerto = "SELECT ncodaeropuerto as aeropuerto from maaeropuerto where vnombreaeropuerto='"+ cmbaeropuerto.Text +"';";
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
            }else{MessageBox.Show("CAMPOS VACION");}
        }

        private void btnBuscarVuelo_Click_1(object sender, EventArgs e)
        {
            funconsultaV();
            funlimpiar();
        }

        private void btnModificarVuelo_Click(object sender, EventArgs e)
        {
            funconsultarVuelos();
            funlimpiar();
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

        private void btnEliminarVuelo_Click(object sender, EventArgs e)
        {
            if (cmbeliminarVuelo.Text != "")
            {
                funeliminar();
            }
            else { MessageBox.Show("NO HAY VUELO A ELIMINAR"); }
            
        }

      
    }
}
