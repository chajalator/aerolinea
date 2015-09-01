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
//Analista y Programador: Jose Alberto Oxcal Ley
//fecha inicio: 13/agosto/2015 a 17/agosto/2015
namespace Aerolinea
{
    public partial class frmtipoAvion : Form
    {
        public frmtipoAvion()
        {
            InitializeComponent();
        }
        private void funconsultaAvion() {
            try {
                using (clasconexion.funobtenerConexion()) {
                    string scolsultaA = "SELECT ncodtipoavion as CodigoAvion,vdescripciontipoavion as TipoAvion FROM trtipoavion order by ncodtipoavion asc";
                    MySqlCommand cmdCavion = new MySqlCommand(scolsultaA,clasconexion.funobtenerConexion());
                    DataTable dtCavion = new DataTable();
                    MySqlDataAdapter mdCavion = new MySqlDataAdapter(scolsultaA,clasconexion.funobtenerConexion());
                    mdCavion.Fill(dtCavion);
                    grdavion.DataSource = dtCavion;
                    grdavion.AutoResizeColumns();
                    clasconexion.funobtenerConexion().Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funconsultaVuelo() {
            try {
                using(clasconexion.funobtenerConexion()){
                    string sconsultaV = "SELECT ncodtipovuelo as CodigoVuelo,vdescripcion as TipoVuelo FROM MaTIPOVUELO ORDER BY ncodtipovuelo asc";
                    MySqlCommand cmdCvuelo = new MySqlCommand(sconsultaV, clasconexion.funobtenerConexion());
                    DataTable dtCvuelo = new DataTable();
                    MySqlDataAdapter mdCvuelo = new MySqlDataAdapter(sconsultaV, clasconexion.funobtenerConexion());
                    mdCvuelo.Fill(dtCvuelo);
                    grdVuelo.DataSource = dtCvuelo;
                    grdVuelo.AutoResizeColumns();
                    clasconexion.funobtenerConexion().Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funlimpiar() {
            txtavion.Text = "";
            txtbuscarAvion.Text = "";
            txtbuscarVuelo.Text = "";
            txtvuelo.Text = "";
                
        }

        private void funbuscarA() {
            try {
                string sbuscarA = "SELECT ncodtipoavion as CodigoAvion,vdescripciontipoavion as TipoAvion FROM trtipoavion WHERE vdescripciontipoavion='"+ txtbuscarAvion.Text +"' order by ncodtipoavion asc";
                MySqlCommand cmdBavion = new MySqlCommand(sbuscarA, clasconexion.funobtenerConexion());
                DataTable dtBavion = new DataTable();
                MySqlDataAdapter mdBavion = new MySqlDataAdapter(sbuscarA, clasconexion.funobtenerConexion());
                mdBavion.Fill(dtBavion);
                grdavion.DataSource = dtBavion;
                grdavion.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void funbuscarV() {
            try {
                string sbuscarV = "SELECT ncodtipovuelo as CodigoVuelo,vdescripcion as TipoVuelo FROM MaTIPOVUELO WHERE vdescripcion='"+ txtbuscarVuelo.Text +"' order by ncodtipovuelo asc";
                MySqlCommand cmdBvuelo = new MySqlCommand(sbuscarV, clasconexion.funobtenerConexion());
                DataTable dtBvuelo = new DataTable();
                MySqlDataAdapter mdBavion = new MySqlDataAdapter(sbuscarV, clasconexion.funobtenerConexion());
                mdBavion.Fill(dtBvuelo);
                grdVuelo.DataSource = dtBvuelo;
                grdVuelo.AutoResizeColumns();
                clasconexion.funobtenerConexion().Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void rEGRESARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrolAvion mn = new frmcontrolAvion();
            mn.Show();
            this.Hide();
        }

        private void frmtipoAvion_Load(object sender, EventArgs e)
        {
            funconsultaAvion();
            funconsultaVuelo();
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            if (tabtipoAvion.SelectedIndex == 0) {
                if (txtavion.Text != "")
                {
                    try
                    {
                        int icodigoA;
                        using (clasconexion.funobtenerConexion())
                        {
                            string scodigoa = "SELECT COUNT(*) AS cant FROM aerolinea.trtipoavion";
                            MySqlCommand cmdCa = new MySqlCommand(scodigoa, clasconexion.funobtenerConexion());
                            icodigoA = (Convert.ToInt32(cmdCa.ExecuteScalar())) + 1;

                            string sguardarA = "INSERT INTO trtipoavion (ncodtipoavion,vdescripciontipoavion) VALUES(" + icodigoA + ",'" + txtavion.Text + "')";
                            MySqlCommand cinsertarA = new MySqlCommand(sguardarA, clasconexion.funobtenerConexion());
                            MySqlDataReader myGuardarA;
                            myGuardarA = cinsertarA.ExecuteReader();
                            MessageBox.Show("TIPO AVION ALMACENADO");
                            clasconexion.funobtenerConexion().Close();
                            funlimpiar();
                            funconsultaAvion();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("INGRESE AVION"); }
            }
            else if (tabtipoAvion.SelectedIndex == 1) {
                if (txtvuelo.Text != "")
                {
                    try
                    {
                        int icodigoV;
                        using (clasconexion.funobtenerConexion())
                        {
                            string scodigov = "SELECT COUNT(*) AS cant FROM aerolinea.matipovuelo";
                            MySqlCommand cmdCv = new MySqlCommand(scodigov, clasconexion.funobtenerConexion());
                            icodigoV = (Convert.ToInt32(cmdCv.ExecuteScalar())) + 1;

                            string sguardarV = "INSERT INTO matipovuelo (ncodtipovuelo,vdescripcion) VALUES(" + icodigoV + ",'" + txtvuelo.Text + "')";
                            MySqlCommand cinsertarV = new MySqlCommand(sguardarV, clasconexion.funobtenerConexion());
                            MySqlDataReader myGuardarV;
                            myGuardarV = cinsertarV.ExecuteReader();
                            MessageBox.Show("TIPO VUELO ALMACENADO");
                            clasconexion.funobtenerConexion().Close();
                            funlimpiar();
                            funconsultaVuelo();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { MessageBox.Show("INGRESE VUELO"); }
            }
        }

        private void btnRefrescarTipo_Click(object sender, EventArgs e)
        {
            if (tabtipoAvion.SelectedIndex == 0) {
                funconsultaAvion();
            } else if (tabtipoAvion.SelectedIndex == 1) {
                funconsultaVuelo();
            }
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            if (tabtipoAvion.SelectedIndex == 0) {
                funbuscarA();
               
            } else if (tabtipoAvion.SelectedIndex == 1) {
                funbuscarV();
            }
            funlimpiar();
        }
    }
}
