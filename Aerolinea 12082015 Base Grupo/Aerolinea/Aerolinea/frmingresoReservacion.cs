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
//PROGRAMADOR Y ANALISTA: Sabrina Maria Gomez Giron y Jose Andres Chajon Cueto
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
        MySqlDataAdapter daActualiza;
        DataSet ds4 = new DataSet();
        DataTable dt4 = new DataTable();
        DataSet dsSelect = new DataSet();
        DataTable dtSelect = new DataTable();
        DataSet dsSelectCorrelativo = new DataSet();
        DataTable dtSelectCorrelativo = new DataTable();
        DataSet dsSelectVuelo = new DataSet();
        DataTable dtSelectVuelo = new DataTable();
        DataSet dsSelect4 = new DataSet();
        DataTable dtSelect4 = new DataTable();
        String svalorSeleccionado;
        String svalorSeleccionado2;
        String recibeMonto;
        String recibeCorrelativo;
        int conversionRecibe;
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


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {


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
            MySqlCommand com1 = new MySqlCommand("Select ntelefono from TrTELEFONO where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
            MySqlCommand com2 = new MySqlCommand("Select vcorreo from TrCORREO where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());


            try
            {

                //MessageBox.Show("entrando a consulta");
                com.ExecuteNonQuery();
                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                MySqlDataAdapter da1 = new MySqlDataAdapter(com1);
                MySqlDataAdapter da2 = new MySqlDataAdapter(com2);

                da.Fill(dt);
                da1.Fill(dt1);
                da2.Fill(dt2);
                // MessageBox.Show("esto lleva prueba"+da);
                txtReservacion.Text = Convert.ToString(dt.Rows[0][0]);
                txtNombre1.Text = Convert.ToString(dt.Rows[0][1]);
                txtApellido1.Text = Convert.ToString(dt.Rows[0][2]);
                txtDireccion.Text = Convert.ToString(dt.Rows[0][3]);
                txtEdad.Text = Convert.ToString(dt.Rows[0][4]);
                txtDireccion.Text = Convert.ToString(dt.Rows[0][5]);
                txtPasaporte.Text = Convert.ToString(dt.Rows[0][7]);
                txtFecha.Text = Convert.ToString(dt.Rows[0][6]);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void funcomboDestino()
        {
            MySqlDataAdapter daItinerario = new MySqlDataAdapter("SELECT ncodtipodestino,(vdescripcion) as DATOSCOMPLETOS FROM TrDESTINO", clasconexion.funobtenerConexion());
            //se indica el nombre de la tabla
            daItinerario.Fill(dsItinerario, "TrDESTINO");

            //lo que mostrará sera la variable Name_Full la cual tiene concatenados los campos Nombre y Apellido_P
            CbDestinos.DataSource = dsItinerario.Tables[0].DefaultView;

            //se especifica el campo de la tabla
            CbDestinos.ValueMember = "ncodtipodestino";
            CbDestinos.DisplayMember = "DATOSCOMPLETOS";

        }

        public void btnReservar_Click(object sender, EventArgs e)
        {
            //MySqlConnection conectar = new MySqlConnection("server=192.168.15.1; database=AEROLINEA; Uid=Aerolinea; pwd=aerolinea2015;");
            MySqlConnection conectar = new MySqlConnection("server=localhost;userid=root;password= ;database=aerolinea");
            svalorSeleccionado = CbSeleccionCodigo.SelectedValue.ToString();
            ds = new DataSet();
            dt = ds.Tables.Add();

            MySqlCommand com = new MySqlCommand("Select  ncodpasajero,vnompasajero ,vapepasajero ,vdireccion,nedadpasajero, vdpi ,dfechanacimiento , vnopasaporte,vestado from MaPASAJERO where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
            com.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            da.Fill(dt);
            int result = 0;

           

            //MySqlConnection conectar2 = new MySqlConnection("server=192.168.15.1; database=AEROLINEA; Uid=Aerolinea; pwd=aerolinea2015;");
            MySqlConnection conectar2 = new MySqlConnection("server=localhost;userid=root;password= ;database=aerolinea");
            svalorSeleccionado2 = CbSeleccionCodigo.SelectedValue.ToString();
            ds3 = new DataSet();
            dt3 = ds3.Tables.Add();

            MySqlCommand com2 = new MySqlCommand("Select  ncodpasajero from MaPASAJERO where ncodpasajero =  " + svalorSeleccionado2 + ";", clasconexion.funobtenerConexion());
            com2.ExecuteNonQuery();
            MySqlDataAdapter da3 = new MySqlDataAdapter(com2);
            da3.Fill(dt3);
            int result2 = 0;
            //MessageBox.Show("esto lleva cod pasajero", svalorSeleccionado2);

            MySqlConnection cn2 = new MySqlConnection();
            cn2 = clasconexion.funobtenerConexion();
            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = cn2;
            cmd2.CommandText = "UPDATE MaRESERVACION2 SET   vextranombre = " + "'" + txtNombreExtra.Text + "'" + " WHERE ncodpasajero = '" + svalorSeleccionado2 + "'";
            cmd2.CommandText = "UPDATE MaRESERVACION2 SET   nextratelefono = " + "'" + txtTelefonoExtra.Text + "'" + " WHERE ncodpasajero = '" + svalorSeleccionado2 + "'";
            int numRowsUpdated2 = cmd2.ExecuteNonQuery();
            //llamada a funciones consulta
            funconsultaUno();
            funconsultaDos();
            funconsultaTres();
            funinserta();

            this.Hide();
            frmseleccionReservacion asientos = new frmseleccionReservacion();
            asientos.Show();



        }




        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            svalorSeleccionado = CbDestinos.SelectedValue.ToString();
            ds2 = new DataSet();
            dt2 = ds2.Tables.Add();

            MySqlCommand com = new MySqlCommand("Select ncodvuelo, vlugarsalida,dthoradespegue,dthoraaterrisaje from MaVuelo2", clasconexion.funobtenerConexion());
            try
            {

                com.ExecuteNonQuery();
                MySqlDataAdapter da3 = new MySqlDataAdapter(com);
                da3.Fill(dt2);
                txtCodDestino.Text = Convert.ToString(dt2.Rows[0][0]);
                txtLugarSalida.Text = Convert.ToString(dt2.Rows[0][1]);
                txtHoraDespegue.Text = Convert.ToString(dt2.Rows[0][2]);
                txtHoraAterrizaje.Text = Convert.ToString(dt2.Rows[0][3]);

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

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcontrolPasajero pasajero = new frmcontrolPasajero();
            pasajero.Show();

        }
        private void funcomboPasajero()
        {

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT ncodpasajero,(vnompasajero) as DATOSCOMPLETOS FROM MaPASAJERO", clasconexion.funobtenerConexion());
            //se indica el nombre de la tabla
            da.Fill(ds, "MaPASAJERO");

            //lo que mostrará sera la variable Name_Full la cual tiene concatenados los campos Nombre y Apellido_P

            CbSeleccionCodigo.DataSource = ds.Tables[0].DefaultView;

            //se especifica el campo de la tabla
            CbSeleccionCodigo.ValueMember = "ncodpasajero";
            CbSeleccionCodigo.DisplayMember = "DATOSCOMPLETOS";

        }


        private void funinsertaReservacion()
        {

            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    String estado = "reservado";
                    string insertaReserva2 = "INSERT INTO MaReservaContinua (ncodreservacion,dfecha, vdescripcionreserv, vextranombre  , nextratelefono ,vestadoreserv  , ncodvuelo  ,ncodpasajero)values('" + conversionRecibe + "','" + dtpFecha.Text + "', '" + cbRequerimiento.Text + "','" + txtNombreExtra.Text + "','" + txtTelefonoExtra.Text + "','" + estado + "','" + txtCodDestino.Text + "' ,  '" + svalorSeleccionado2 + "');";
                    DateTime saveNow = DateTime.Now;
                    if (dtpFecha.Value > saveNow)
                    {
                        MySqlCommand cmdInsertaFinal2 = new MySqlCommand(insertaReserva2, clasconexion.funobtenerConexion());
                        MySqlDataReader MyReaderReservacion2;
                        MyReaderReservacion2 = cmdInsertaFinal2.ExecuteReader();
                        MessageBox.Show("inserta exitosamente");

                    }
                    else
                    {
                        MessageBox.Show("Fecha no valida ");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("FALLO AL GENERAR LA CONSULTA: " + ex);
                }
            }

        }






        private void funinserta()
        {
            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    String estado = "reservado";
                    //string insertaReserva = "INSERT INTO MaReservacion (ncodreservacion,dfecha,nanticipo, vdescripcionreserv, vextranombre  , nextratelefono ,vestadoreserv  , ncodvuelo  ,ncodpasajero)values('" + conversionRecibe + ",'" + txtFechaReserva.Text + "','" + recibeMonto + "','" + cbRequerimiento.Text + "','" + txtNombreExtra.Text + "','" + txtTelefonoExtra.Text + "','" + estado + "','" + "56" + "','" + svalorSeleccionado2 + ");";
                    string insertaReserva = "INSERT INTO MaRESERVACION2 (ncodreservacion,dfecha, vdescripcionreserv, vextranombre  , nextratelefono ,vestadoreserv  , ncodvuelo  ,ncodpasajero)values('" + conversionRecibe + "','" + dtpFecha.Text + "', '" + cbRequerimiento.Text + "','" + txtNombreExtra.Text + "','" + txtTelefonoExtra.Text + "','" + estado + "','" + txtCodDestino.Text + "' ,  '" + svalorSeleccionado2 + "');";
                    DateTime saveNow = DateTime.Now;
                    if (dtpFecha.Value > saveNow)
                    {
                        MySqlCommand cmdInsertaFinal = new MySqlCommand(insertaReserva, clasconexion.funobtenerConexion());
                        MySqlDataReader MyReaderReservacion;
                        MyReaderReservacion = cmdInsertaFinal.ExecuteReader();
                        MessageBox.Show("inserta exitosamente");

                    }
                    else
                    {
                        MessageBox.Show("Fecha no valida ");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("FALLO AL GENERAR LA CONSULTA: " + ex);
                }
            }

        }





        private void funconsultaUno()
        {
            //consulta para obtener monto pagado  
            dsSelect = new DataSet();
            dtSelect = dsSelect.Tables.Add();
            MySqlCommand consulta = new MySqlCommand("Select  nmontoefectivo from MaPAGO where ncodpasajero  =  '" + svalorSeleccionado2 + "'", clasconexion.funobtenerConexion());
            try
            {
                consulta.ExecuteNonQuery();
                MySqlDataAdapter daSelect = new MySqlDataAdapter(consulta);
                daSelect.Fill(dtSelect);
                recibeMonto = Convert.ToString(dtSelect.Rows[0][0]);
                //MessageBox.Show("el resultado de la consulta es " + recibeMonto);


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error ---------------", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void funconsultaDos()
        {

            dsSelectCorrelativo = new DataSet();
            dtSelectCorrelativo = dsSelectCorrelativo.Tables.Add();
           // MySqlCommand consultaCorrelativo = new MySqlCommand("select  max(ncodreservacion) from MaRESERVACION2 ", clasconexion.funobtenerConexion());
            MySqlCommand consultaCorrelativo = new MySqlCommand("SELECT MAX(ncodreservacion)  FROM mareservacion2", clasconexion.funobtenerConexion());
           
            try
            {
                consultaCorrelativo.ExecuteNonQuery();
                MySqlDataAdapter daSelectCorrelativo = new MySqlDataAdapter(consultaCorrelativo);
                daSelectCorrelativo.Fill(dtSelectCorrelativo);
                recibeCorrelativo = Convert.ToString(dtSelectCorrelativo.Rows[0][0]);

                conversionRecibe = Int32.Parse(recibeCorrelativo);
                int a = 1;
                conversionRecibe++;
                MessageBox.Show("el resultado del codigo es  revision ----" + conversionRecibe);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error de consulta dos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }




        }
        private void funconsultaTres()
        {
            //consulta para codigo de vuelo


            MySqlCommand consultaVuelo = new MySqlCommand("Select ncodvuelo from MaVUELO ", clasconexion.funobtenerConexion());
            try
            {
                consultaVuelo.ExecuteNonQuery();
                MySqlDataAdapter daSelectVuelo = new MySqlDataAdapter(consultaVuelo);
                daSelectVuelo.Fill(dtSelectVuelo);
                String recibeVuelo = Convert.ToString(dtSelect.Rows[0][1]);
                //MessageBox.Show("el resultado de la consulta de vuelo es " + recibeVuelo);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error en vuelo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }



        private void frmingresoReservacion_Load(object sender, EventArgs e)
        {
            funcomboPasajero();

            funcomboDestino();


        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable tabla;

            MySqlConnection cn = new MySqlConnection();
            cn = clasconexion.funobtenerConexion();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "Select *from MaTIPOUSUARIO";
            ds4 = new DataSet();
            cmd.Connection = cn;


            daActualiza = new MySqlDataAdapter(cmd);
            daActualiza.Fill(ds4, "MaTIPOUSUARIO");
            tabla = ds4.Tables["MaTIPOUSUARIO"];

            try
            {
                DataRow[] filas;
                filas = tabla.Select(null, null, DataViewRowState.ModifiedCurrent);

                daActualiza.Update(tabla);

                filas = tabla.Select(null, null, DataViewRowState.Added);

                daActualiza.Update(tabla);

                MessageBox.Show("Actualizando registros");

            }


            catch (Exception Ex)
            {
                MessageBox.Show(" NO Actualizando registros");

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            clasconexion.funobtenerConexion();
            MessageBox.Show("conectando con servidor UBUNTU");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void funlimpiarReservacion()
        {
            txtReservacion.Text = "";
            txtNombre1.Text = "";
            txtApellido1.Text = "";
            txtDireccion.Text = "";
            //txtFechaReserva.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtPasaporte.Text = "";
            
            txtCodDestino.Text = "";
            txtLugarSalida.Text = "";
            txtHoraDespegue.Text = "";
            txtNombreExtra.Text = "";
            txtTelefonoExtra.Text = "";
            txtFecha.Text = "";
            txtHoraAterrizaje.Text = "";
        }
       int  suma;
     
        private void button2_Click(object sender, EventArgs e)
        {

            suma += 1;
            btnContador.Text = suma.ToString();
            MessageBox.Show(" esto lleva el boton" + suma);
         
            

            if (suma == 1)
            {
                //MySqlConnection conectar = new MySqlConnection("server=192.168.15.1; database=AEROLINEA; Uid=Aerolinea; pwd=aerolinea2015;");
                MySqlConnection conectar = new MySqlConnection("server=localhost;userid=root;password= ;database=aerolinea");
                svalorSeleccionado = CbSeleccionCodigo.SelectedValue.ToString();
                ds = new DataSet();
                dt = ds.Tables.Add();

                MySqlCommand com = new MySqlCommand("Select  ncodpasajero,vnompasajero ,vapepasajero ,vdireccion,nedadpasajero, vdpi ,dfechanacimiento , vnopasaporte,vestado from MaPASAJERO where ncodpasajero =  " + svalorSeleccionado + ";", clasconexion.funobtenerConexion());
                com.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                da.Fill(dt);
                int result = 0;



                //MySqlConnection conectar2 = new MySqlConnection("server=192.168.15.1; database=AEROLINEA; Uid=Aerolinea; pwd=aerolinea2015;");
                MySqlConnection conectar2 = new MySqlConnection("server=localhost;userid=root;password= ;database=aerolinea");
                svalorSeleccionado2 = CbSeleccionCodigo.SelectedValue.ToString();
                ds3 = new DataSet();
                dt3 = ds3.Tables.Add();

                MySqlCommand com2 = new MySqlCommand("Select  ncodpasajero from MaPASAJERO where ncodpasajero =  " + svalorSeleccionado2 + ";", clasconexion.funobtenerConexion());
                com2.ExecuteNonQuery();
                MySqlDataAdapter da3 = new MySqlDataAdapter(com2);
                da3.Fill(dt3);
                int result2 = 0;



                //llamada a funciones consulta
                funconsultaUno();
                funconsultaDos();
                funconsultaTres();
                funinserta();
                funlimpiarReservacion();
                
                if (MessageBox.Show("Desea finalizar su reservacion ", "RESERVACION",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
             
                    frmseleccionReservacion frm2 = new frmseleccionReservacion();
                    string ss = Convert.ToString(suma);
                    frm2.pasoVariable = ss.ToString();
                    MessageBox.Show("esto lleva la variable paso" + suma.ToString());
                    this.Hide();
                    //frmseleccionReservacion asientos = new frmseleccionReservacion();
                    frm2.Show();

                }



            }
            else
            {
                MessageBox.Show("el contador es mayor que 2");
                funconsultaUno();

                funconsultaTres();
                funinsertaReservacion();
                funlimpiarReservacion();
                if (MessageBox.Show("Desea finalizar su reservacion ", "RESERVACION",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    frmseleccionReservacion asientos = new frmseleccionReservacion();
                    asientos.Show();

                }

                {

                }


            }
        }
    }
}
        

        
          



           
        

        

       


   
























