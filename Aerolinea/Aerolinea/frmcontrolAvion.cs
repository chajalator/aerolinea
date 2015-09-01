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

        private void funtipoavion() {
            try {
                using (clasconexion.funobtenerConexion()) {
                    string StipoA = "SELECT vdescripciontipoavion as TipoAvion From TrTIPOAVION order by vdescripciontipoavion asc";
                    MySqlCommand cmdTipoA = new MySqlCommand(StipoA, clasconexion.funobtenerConexion());
                    DataTable dtTipoA = new DataTable();
                    MySqlDataAdapter mdTipoA = new MySqlDataAdapter(StipoA, clasconexion.funobtenerConexion());
                    mdTipoA.Fill(dtTipoA);
                    cmbtipoAvion.DataSource = dtTipoA;
                    cmbtipoAvion.DisplayMember = "TipoAvion";
                    clasconexion.funobtenerConexion().Close();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funcomboElimnar() {
            try {
                using (clasconexion.funobtenerConexion()) {
                    string scomboE = "SELECT ncodavion as codigo from MaAVION where vdisponibilidad='ACTIVO' order by ncodavion asc";
                    MySqlCommand cmdcomboE = new MySqlCommand(scomboE, clasconexion.funobtenerConexion());
                    DataTable dtComboE = new DataTable();
                    MySqlDataAdapter mdComboE = new MySqlDataAdapter(scomboE, clasconexion.funobtenerConexion());
                    mdComboE.Fill(dtComboE);
                    cmbelimiar.DataSource = dtComboE;
                    cmbelimiar.DisplayMember = "codigo";
                    clasconexion.funobtenerConexion().Close();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void funconsultarAviones(){
            try {
                using (clasconexion.funobtenerConexion()){
                    string squery = "SELECT ncodavion as CodigoAvion,vaerolinea as Aerolinea,vmodelo as Modelo,vmatricula as Matricula,vdescripciontipoavion as TipoAvion FROM MaAVION "+
                        "inner join TrTIPOAVION on MaAVION.ncodtipoavion=TrTIPOAVION.ncodtipoavion where MaAVION.vdisponibilidad='ACTIVO' order by MaAVION.ncodavion asc ";
                    MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    DataTable dtDatos = new DataTable();
                    MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                    mdaDatos.Fill(dtDatos);
                    grdaviones.DataSource = dtDatos;
                    grdaviones.AutoResizeColumns();
                    clasconexion.funobtenerConexion().Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }            
        }

        private void funlimpiar() {
            txtaerolinea.Text = "";
            txtmatricula.Text = "";
            txtmodelo.Text = "";
            cmbtipoAvion.Text = "";
            cmbelimiar.Text = "";
        }

        private void funeliminar() {
            try {
                string seliminar = "UPDATE MaAVION set vdisponibilidad='INACTIVO' where ncodavion="+ cmbelimiar.Text ;
                MySqlCommand cmdelimiar = new MySqlCommand(seliminar, clasconexion.funobtenerConexion());
                cmdelimiar.ExecuteNonQuery();
                clasconexion.funobtenerConexion().Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funbuscaravion() {
            try {
                string sbuscarA = "SELECT ncodavion as CodigoAvion,vaerolinea as Aerolinea,vmodelo as Modelo,vmatricula as Matricula,vdescripciontipoavion as TipoAvion FROM MaAVION " +
                        "inner join TrTIPOAVION on MaAVION.ncodtipoavion=TrTIPOAVION.ncodtipoavion "+
                        "WHERE MaAVION.vaerolinea='"+ txtbuscarAvion.Text +"' order by MaAVION.ncodavion asc ";
                MySqlCommand cmdbuscarA = new MySqlCommand(sbuscarA, clasconexion.funobtenerConexion());
                DataTable dtbuscarA = new DataTable();
                MySqlDataAdapter mdbuscarA = new MySqlDataAdapter(sbuscarA, clasconexion.funobtenerConexion());
                mdbuscarA.Fill(dtbuscarA);
                grdaviones.DataSource = dtbuscarA;
                grdaviones.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
                funlimpiar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmcontrolAvion_Load(object sender, EventArgs e)
        {
           funconsultarAviones();
           funtipoavion();
           funcomboElimnar();
           funlimpiar();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnGuardarAvion_Click_2(object sender, EventArgs e)
        {
            if ((cmbtipoAvion.Text != "") && (txtaerolinea.Text != "") && (txtmatricula.Text != "") && (txtmodelo.Text != ""))
            {
                try
                {

                    int icodigoAvion;
                    int icodTipoA;

                    using (clasconexion.funobtenerConexion())
                    {

                        //PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
                        string squery = "SELECT COUNT(*) As Cant FROM AEROLINEA.MaAVION ";
                        MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                        icodigoAvion = (Convert.ToInt32(cmd.ExecuteScalar())) + 1;

                        //Programador y analista: Jose Alberto Oxcal Ley 
                        string scodTipoA = "Select ncodtipoavion as Codigo FROM TrTIPOAVION WHERE vdescripciontipoavion='" + cmbtipoAvion.Text + "'";
                        MySqlCommand cmdcodTipoA = new MySqlCommand(scodTipoA, clasconexion.funobtenerConexion());
                        icodTipoA = Convert.ToInt32(cmdcodTipoA.ExecuteScalar());

                        string sinsertaravion = "INSERT INTO MaAVION (ncodavion,vaerolinea,vmodelo,vmatricula,vdisponibilidad,ncodtipoavion)" +
                            "VALUES(" + icodigoAvion + ",'" + txtaerolinea.Text + "','" + txtmodelo.Text + "','" + txtmatricula.Text + "','ACTIVO'," + icodTipoA + ")";
                        MySqlCommand cmd1 = new MySqlCommand(sinsertaravion, clasconexion.funobtenerConexion());
                        MySqlDataReader MyReader;
                        MyReader = cmd1.ExecuteReader();
                        MessageBox.Show("AVION ALMACENADO");
                        clasconexion.funobtenerConexion().Close();
                        funlimpiar();
                        funconsultarAviones();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("CAMPOS VACIOS"); }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aGREGARTIPOAVIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipoAvion ta = new frmtipoAvion();
            ta.Show();
            this.Hide();
        }

        private void cmbrefrescar_Click(object sender, EventArgs e)
        {
            funcomboElimnar();
            funconsultarAviones();
            funlimpiar();

        }

        private void btnBuscarAvion_Click(object sender, EventArgs e)
        {
            funbuscaravion();
            funlimpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            funeliminar();
            funconsultarAviones();
            funlimpiar();
                    }
    }
}
