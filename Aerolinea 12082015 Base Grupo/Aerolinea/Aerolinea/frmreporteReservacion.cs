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

namespace Aerolinea
{
    public partial class frmreporteReservacion : Form
    {
         DataTable dtSelectReporte= new DataTable();
         DataSet  dsSelectReporte = new DataSet();
         String recibeReporte;
         String recibeReporte2;
         String recibeReporte3;
         String recibeReporte4;
        public frmreporteReservacion()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            funReporte();
        }
        
        
        
        private void funconsultaUnoReporte()
        {
            //consulta para obtener monto pagado  
            dsSelectReporte = new DataSet();
            dtSelectReporte = dsSelectReporte.Tables.Add();
            MySqlCommand consulta = new MySqlCommand("select  ncodvuelo from mareservacion",clasconexion.funobtenerConexion());
            try
            {
                consulta.ExecuteNonQuery();
                MySqlDataAdapter daSelectReporte = new MySqlDataAdapter(consulta);
                DataTable dtDat = new DataTable();
                daSelectReporte.Fill(dtSelectReporte);
                recibeReporte = Convert.ToString(dtSelectReporte.Rows[0][0]);
                //daSelectReporte.Fill(dtDat);
                //dgwReporte.DataSource = dtDat;

                //MessageBox.Show("el resultado de la consulta es " + recibeReporte);


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error ---------------", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void funconsultaDosReporte()
        {
            //consulta para obtener monto pagado  
            dsSelectReporte = new DataSet();
            dtSelectReporte = dsSelectReporte.Tables.Add();
            MySqlCommand consulta = new MySqlCommand("Select ncodtipodestino from mavuelo where ncodvuelo =  " +recibeReporte + ";", clasconexion.funobtenerConexion());
            try
            {
                consulta.ExecuteNonQuery();
                MySqlDataAdapter daSelectReporte = new MySqlDataAdapter(consulta);
                DataTable dtDat = new DataTable();
                daSelectReporte.Fill(dtSelectReporte);
                recibeReporte2 = Convert.ToString(dtSelectReporte.Rows[0][0]);
                //daSelectReporte.Fill(dtDat);
                //dgwReporte.DataSource = dtDat;

                MessageBox.Show("el resultado de la consulta es " + recibeReporte2);


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error ---------------", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void funconsultaTresReporte()
        {
            //consulta para obtener monto pagado  
            dsSelectReporte = new DataSet();
            dtSelectReporte = dsSelectReporte.Tables.Add();
            MySqlCommand consulta = new MySqlCommand("Select vdescripcion from trdestino where ncodtipodestino =  " + recibeReporte2 + ";", clasconexion.funobtenerConexion());
            try
            {
                consulta.ExecuteNonQuery();
                MySqlDataAdapter daSelectReporte = new MySqlDataAdapter(consulta);
                DataTable dtDat = new DataTable();
                daSelectReporte.Fill(dtSelectReporte);
                recibeReporte4= Convert.ToString(dtSelectReporte.Rows[0][0]);
                daSelectReporte.Fill(dtDat);
                dgwReporte.DataSource = dtDat;

                //MessageBox.Show("el resultado de la consulta es " + recibeReporte3);


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error ---------------", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        
        private void funReporte(){
                string squeryReporteReservacion = "select vdescripcion, count(vdescripcion) as total from trdestino group by vdescripcion order by 5 desc where ncodtipodestino =  " + recibeReporte4 + "'";
                MySqlCommand cmdc = new MySqlCommand(squeryReporteReservacion, clasconexion.funobtenerConexion());
                DataTable dtDat = new DataTable();
                MySqlDataAdapter mdaDat = new MySqlDataAdapter(squeryReporteReservacion, clasconexion.funobtenerConexion());
                mdaDat.Fill(dtDat);
                dgwReporte.DataSource = dtDat;
                clasconexion.funobtenerConexion().Close();


            }
        

        private void frmreporteReservacion_Load(object sender, EventArgs e)
        {
            
            funconsultaUnoReporte();
            funconsultaDosReporte();
            funconsultaTresReporte();
            funReporte();
        }

        private void gbCodigo_Enter(object sender, EventArgs e)
        {

        }

        }
    }

