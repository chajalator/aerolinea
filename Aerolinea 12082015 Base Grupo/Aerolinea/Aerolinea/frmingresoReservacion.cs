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
//PROGRAMADOR Y ANALISTA: Sabrina Gomez
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 


namespace Aerolinea
{

    public partial class frmingresoReservacion : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataSet ds1 = new DataSet();
        DataTable dt1 = new DataTable();
        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable();
        DataSet dsItinerario = new DataSet();
        DataTable dtItinerario = new DataTable();
        DataSet ds3 = new DataSet();
        DataTable dt3 = new DataTable();
        public frmingresoReservacion()
        {
            InitializeComponent();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {








        }

        private void CbSeleccionCodigo_SelectedIndexChanged(object sender, EventArgs e, String guardaNombre)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ncodpasajero,(vnompasajero) as DATOSCOMPLETOS FROM MaPasajero", clasconexion.funobtenerConexion());
            //se indica el nombre de la tabla
            da.Fill(ds, "MaPasajero");

            //lo que mostrará sera la variable Name_Full la cual tiene concatenados los campos Nombre y Apellido_P

            CbSeleccionCodigo.DataSource = ds.Tables[0].DefaultView;

            //se especifica el campo de la tabla
            CbSeleccionCodigo.ValueMember = "ncodpasajero";
            CbSeleccionCodigo.DisplayMember = "DATOSCOMPLETOS";

        }

        private void CbSeleccionCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string svalorSeleccionado = CbSeleccionCodigo.SelectedValue.ToString();
            ds = new DataSet();
            dt = ds.Tables.Add();
            ds1 = new DataSet();
            dt1 = ds1.Tables.Add();
            ds2 = new DataSet();
            dt2 = ds2.Tables.Add();



            MySqlCommand com = new MySqlCommand("Select  ncodpasajero,vnompasajero ,vapepasajero ,vdireccion,nedadpasajero, vdpi ,dfechanacimiento , vnopasaporte,vestado from MaPASAJERO where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
            MySqlCommand com1 = new MySqlCommand("Select ntelefono from TrTelefono where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
            MySqlCommand com2 = new MySqlCommand("Select vcorreo from TrCorreo where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
          
           
            try
            {

             
                com.ExecuteNonQuery();
                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                MySqlDataAdapter da1 = new MySqlDataAdapter(com1);
                MySqlDataAdapter da2 = new MySqlDataAdapter(com2);
                da.Fill(dt);
                da1.Fill(dt1);
                da2.Fill(dt2);
                txtReservacion.Text = Convert.ToString(dt.Rows[0][0]);
                txtNombre1.Text = Convert.ToString(dt.Rows[0][1]);
                txtApellido1.Text = Convert.ToString(dt.Rows[0][2]);
                txtDireccion.Text = Convert.ToString(dt.Rows[0][3]);
                txtEdad.Text = Convert.ToString(dt.Rows[0][4]);
                txtDpi.Text = Convert.ToString(dt.Rows[0][5]);
                txtPasaporte.Text = Convert.ToString(dt.Rows[0][7]);
                txtFecha.Text = Convert.ToString(dt.Rows[0][6]);

                txtTelefono1.Text = Convert.ToString(dt1.Rows[0][0]);
                txtEmail.Text = Convert.ToString(dt2.Rows[0][0]);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public void btnReservar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;userid=root;password=negritalinda ;database=aerolinea");
            string svalorSeleccionado = CbSeleccionCodigo.SelectedValue.ToString();
            ds = new DataSet();
            dt = ds.Tables.Add();

            MySqlCommand com = new MySqlCommand("Select  ncodpasajero,vnompasajero ,vapepasajero ,vdireccion,nedadpasajero, vdpi ,dfechanacimiento , vnopasaporte,vestado from MaPASAJERO where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
             com.ExecuteNonQuery();
             MySqlDataAdapter da = new MySqlDataAdapter(com);
             da.Fill(dt);
             int result = 0;

            MySqlConnection cn = new MySqlConnection();
            cn = clasconexion.funobtenerConexion();
          MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = cn;

            cmd.CommandText = "UPDATE TrCorreo SET vcorreo = " + "'" + txtEmail.Text + "'" + "WHERE ncodpasajero = '" + svalorSeleccionado + "'";
            cmd.CommandText = "UPDATE TrTelefono SET ntelefono = " + "'" + txtTelefono1.Text + "'" + "WHERE ncodpasajero = '" + svalorSeleccionado + "'";
            int numRowsUpdated = cmd.ExecuteNonQuery();
           // MessageBox.Show("actualizado");

            MySqlConnection conectar2 = new MySqlConnection("server=localhost;userid=root;password= ;database=aerolinea");
            string svalorSeleccionado2 = CbSeleccionCodigo.SelectedValue.ToString();
            ds3 = new DataSet();
            dt3 = ds3.Tables.Add();

            MySqlCommand com2 = new MySqlCommand("Select  ncodpasajero from MaReservacion where ncodpasajero =  " + svalorSeleccionado2 + ";", clasconexion.funobtenerConexion());
            com2.ExecuteNonQuery();
            MySqlDataAdapter da3 = new MySqlDataAdapter(com2);
            da3.Fill(dt3);
            int result2 = 0;
            //MessageBox.Show("esto lleva cod pasajero", svalorSeleccionado2);

            MySqlConnection cn2 = new MySqlConnection();
            cn2 = clasconexion.funobtenerConexion();
            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = cn2;

            cmd2.CommandText = "UPDATE MaReservacion SET vdescripcionreserv = " +"'"+ richRequerimiento1.Text+"'"+" WHERE ncodpasajero = '" + svalorSeleccionado2 + "'";

            cmd2.CommandText = "UPDATE MaReservacion SET vextrasituacion = " + "'" + txtExtra.Text + "'" + " WHERE ncodpasajero = '" + svalorSeleccionado2 + "'";
            cmd2.CommandText = "UPDATE MaReservacion SET   vextranombre = " + "'" + txtNombreExtra.Text + "'" + " WHERE ncodpasajero = '" + svalorSeleccionado2 + "'";
            cmd2.CommandText = "UPDATE MaReservacion SET   nextratelefono = " + "'" + txtTelefonoExtra.Text + "'" + " WHERE ncodpasajero = '" + svalorSeleccionado2 + "'";
            int numRowsUpdated2 = cmd2.ExecuteNonQuery();
            MessageBox.Show("actualizado");
            string variable = svalorSeleccionado;
            frmseleccionReservacion frm3 = new frmseleccionReservacion();
          //  frmseleccionReservacion frm3 = new Form3(variable); //Pasando Variable en el constructor            
            frm3.Show();
            this.Hide();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter daItinerario = new MySqlDataAdapter("SELECT ncodtipodestino,(vdescripcion) as DATOSCOMPLETOS FROM TrDESTINO", clasconexion.funobtenerConexion());
            //se indica el nombre de la tabla
            daItinerario.Fill(dsItinerario, "TrDESTINO");

            //lo que mostrará sera la variable Name_Full la cual tiene concatenados los campos Nombre y Apellido_P

            CbDestino.DataSource = dsItinerario.Tables[0].DefaultView;

            //se especifica el campo de la tabla
            CbDestino.ValueMember = "ncodtipodestino";
            CbDestino.DisplayMember = "DATOSCOMPLETOS";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string svalorSeleccionado = CbSeleccionCodigo.SelectedValue.ToString();
            ds2 = new DataSet();
            dt2 = ds2.Tables.Add();

            MySqlCommand com = new MySqlCommand("Select  vlugarsalida,dthoradespegue,dthoraaterrisaje from MaVuelo2", clasconexion.funobtenerConexion());
            try
            {

                com.ExecuteNonQuery();
                MySqlDataAdapter da3 = new MySqlDataAdapter(com);
                da3.Fill(dt2);
                txtLugarSalida.Text = Convert.ToString(dt2.Rows[0][0]);
                txtHoraDespegue.Text = Convert.ToString(dt2.Rows[0][1]);
                txtHoraAterrizaje.Text = Convert.ToString(dt2.Rows[0][2]);
                




            }
            catch (Exception Ex)
            {

            }
        }

        private void txtReservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clasconexion.funobtenerConexion();
            MessageBox.Show("conectando con servidor UBUNTU");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void frmingresoReservacion_Load(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
            
        }
        }



        
    

    


          
        
        

           
            
           
            
     
    
            

       
           

           
