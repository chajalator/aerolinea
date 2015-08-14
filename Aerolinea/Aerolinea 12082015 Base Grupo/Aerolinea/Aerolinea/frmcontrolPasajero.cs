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
using MySql.Data;
//PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 09/Agosto/2015
namespace Aerolinea
{
    public partial class frmcontrolPasajero : Form
    {
        public frmcontrolPasajero()
        {
            InitializeComponent();
        }

      

        private void ingresoPasajero_Load(object sender, EventArgs e)
        {
           
            //label14.Visible = false;
            //cmbestadoPasajero.Visible = false;
            funconsultarPasajeros();
            funllenarComboModificarPasajero();
            funllenarComboEliminarPasajero();
            funllenarComboAdicionalesPasajero();
            

        }

        private void funllenarComboAdicionalesPasajero()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodpasajero  FROM aerolinea.MaPASAJERO";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbcodPasajero.ValueMember = "ncodpasajero";
                cmbcodPasajero.DisplayMember = "ncodpasajero";
                cmbcodPasajero.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funllenarComboEliminarPasajero()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodpasajero  FROM aerolinea.MaPASAJERO where vestado='ACTIVO'";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbeliminarPasajero.ValueMember = "ncodpasajero";
                cmbeliminarPasajero.DisplayMember = "ncodpasajero";
                cmbeliminarPasajero.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void funllenarComboModificarPasajero()
        {

            using (clasconexion.funobtenerConexion())
            {
                string squeryModificar = "SELECT ncodpasajero  FROM aerolinea.MaPASAJERO";
                MySqlCommand cmdc = new MySqlCommand(squeryModificar, clasconexion.funobtenerConexion());
                DataTable dtdatosModificar = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squeryModificar, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtdatosModificar);

                cmbmodificoPasajero.ValueMember = "ncodpasajero";
                cmbmodificoPasajero.DisplayMember = "ncodpasajero";
                cmbmodificoPasajero.DataSource = dtdatosModificar;
                clasconexion.funobtenerConexion().Close();
                               
               
            }
            clasconexion.funobtenerConexion().Close();
        }

        private void funconsultarPasajeros()
        {
          using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodpasajero as CodigoPasajero,vnompasajero as NombrePasajero,vapepasajero as ApellidoPasajero,vdireccion as DireccionPasajero,nedadpasajero as EdadPasajero,vdpi as DPI, DATE_FORMAT(dfechanacimiento, '%d-%m-%Y') as FechaNacimiento, vnopasaporte as PasaportePasajero,vestado as EstadoPasajero FROM aerolinea.MaPASAJERO  where vestado='ACTIVO'";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdPasajeros.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void btnGuardarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                
                int ifilas;
                int icodigoPasajero;
                using (clasconexion.funobtenerConexion())
                {
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.MaPASAJERO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    ifilas = Convert.ToInt32(cmd.ExecuteScalar());
                    icodigoPasajero = ifilas + 1;
                    clasconexion.funobtenerConexion().Close();
                   

                }
                using (clasconexion.funobtenerConexion())
                {
    
                    string sfechaNacimiento = dtpasajero.Value.ToShortDateString();
                    //MessageBox.Show(sfechaNacimiento);
                    string sinsertarPasajero = "INSERT INTO aerolinea.MaPASAJERO  (ncodpasajero,vnompasajero,vapepasajero,vdireccion,nedadpasajero,vdpi,dfechanacimiento,vnopasaporte,vestado)values(" + icodigoPasajero + ",'" + txtNomPasajero.Text + "','" + txtApellidoPasajero.Text + "','" + txtDireccionPasajero.Text + "'," + txtEdadPasajero.Text + ",'" + txtdpiPasajero.Text + "','" + dtpasajero.Text + "','" + txtnoPasaporte.Text + "','" + "ACTIVO" + "')";
                    MySqlCommand cmd2 = new MySqlCommand(sinsertarPasajero, clasconexion.funobtenerConexion());
                    MySqlDataReader MyReader;
                    MyReader = cmd2.ExecuteReader();  
                    MessageBox.Show("PASAJERO ALMACENADO");

                     
                        
                          for (int itelefono=0; itelefono < icontadorTelefonosPasajeros; itelefono++) {
                           string sinsertartelefono1 = "INSERT INTO aerolinea.TrTELEFONO (ncodpasajero,ntelefono)values(" + icodigoPasajero + "," + stelefono[itelefono] +  ");";
                            MySqlCommand cmd3 = new MySqlCommand(sinsertartelefono1, clasconexion.funobtenerConexion());
                            cmd3.ExecuteNonQuery();
                        }

                          for (int icorreo = 0; icorreo < icontadorCorreosPasajeros; icorreo++) {
                              string sinsertarcorreo1 = "INSERT INTO aerolinea.TrCORREO (ncodpasajero,vcorreo)values(" + icodigoPasajero + ",'" + scorreo[icorreo] + "');";
                              MySqlCommand cmd5 = new MySqlCommand(sinsertarcorreo1, clasconexion.funobtenerConexion());
                              cmd5.ExecuteNonQuery();
                          
                          }


                              

                   
                    
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();
                    funconsultarPasajeros(); 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void funlimpiar()
        {
            txtNomPasajero.Text = "";
            txtApellidoPasajero.Text = "";
            txtCorreoPasajero.Text = "";
         //   txtCorreoPasajero2.Text = "";
            txtDireccionPasajero.Text = "";
            txtEdadPasajero.Text = "";
            txtnoPasaporte.Text = "";
            txtTelefonoPasajero.Text = "";
         //   txtTelefonoPasajero2.Text = "";
            txtdpiPasajero.Text = "";
            


        }

        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            funbuscarPasajero();
        }

        private void funbuscarPasajero()
        {


            using (clasconexion.funobtenerConexion())
            {

                string squeryBuscarPasajero = "SELECT ncodpasajero as CodigoPasajero,vnompasajero as NombrePasajero,vapepasajero as ApellidoPasajero,vdireccion as DireccionPasajero,nedadpasajero as Edad,vdpi as DPI,dfechanacimiento  as FechaNacimiento,vnopasaporte as PasaportePasajero,vestado as EstadoPasajero FROM aerolinea.MaPASAJERO  where vnopasaporte='" + txtBusquedaPasajero.Text + "' or ncodpasajero=" + txtBusquedaPasajero.Text;
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                DataTable dtDat = new DataTable();
                MySqlDataAdapter mdaDat = new MySqlDataAdapter(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                mdaDat.Fill(dtDat);
                grdPasajeros.DataSource = dtDat;
                clasconexion.funobtenerConexion().Close();


            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            funeliminarPasajero();
            funllenarComboEliminarPasajero();
        }

        private void funeliminarPasajero()
        {
            using (clasconexion.funobtenerConexion())
            {
                try { 
                string sfechaNacimiento = dtpasajero.Value.ToShortDateString();
                //MessageBox.Show(sfechaNacimiento);
                string seliminarPasajero = "UPDATE aerolinea.MaPASAJERO  set vestado = 'INACTIVO' where ncodpasajero=" + cmbeliminarPasajero.Text ;
                MySqlCommand cmd2 = new MySqlCommand(seliminarPasajero, clasconexion.funobtenerConexion());
                cmd2.ExecuteNonQuery();
                clasconexion.funobtenerConexion().Close();
               
                funconsultarPasajeros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbmodificarPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void funbuscarPasajeroAModificar()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodpasajero as CodigoPasajero,vnompasajero as NombrePasajero,vapepasajero as ApellidoPasajero,vdireccion as DireccionPasajero,nedadpasajero as EdadPasajero,vdpi as DPI, DATE_FORMAT(dfechanacimiento, '%Y-%m-%d') as FechaNacimiento, vnopasaporte as PasaportePasajero,vestado as EstadoPasajero FROM aerolinea.MaPASAJERO  where ncodpasajero=" + cmbmodificoPasajero.Text;
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtdatosPasajero = new DataTable();
                MySqlDataAdapter mdadatosPasajero = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdadatosPasajero.Fill(dtdatosPasajero);
                grdPasajeros.DataSource = dtdatosPasajero;
                clasconexion.funobtenerConexion().Close();
            }


            
        }

        private void btnModificarPasajero_Click(object sender, EventArgs e)
        {
            funmodificarPasajero();
            //label14.Visible = false;
            //cmbestadoPasajero.Visible = false;
        }

        private void funmodificarPasajero()
        {
           
                using (clasconexion.funobtenerConexion())
                {
                    try
                    {
                        MySqlCommand cmd = clasconexion.funobtenerConexion().CreateCommand();
                        cmd.CommandText = "UPDATE aerolinea.MaPASAJERO  set vnompasajero = @nompasajero,vapepasajero = @apepasajero,vdireccion = @dirpasajero,nedadpasajero = @edadpasajero,vdpi = @dpipasajero,dfechanacimiento = @fechapasajero,vnopasaporte = @paspasajero,vestado = @estadopasajero where ncodpasajero=" + cmbmodificoPasajero.Text;
                        cmd.Parameters.Add("@nompasajero", MySqlDbType.VarChar);  cmd.Parameters.Add("@apepasajero", MySqlDbType.VarChar);
                        cmd.Parameters.Add("@dirpasajero", MySqlDbType.VarChar);  cmd.Parameters.Add("@edadpasajero", MySqlDbType.Decimal);
                        cmd.Parameters.Add("@dpipasajero", MySqlDbType.VarChar);  cmd.Parameters.Add("@fechapasajero", MySqlDbType.Date);
                        cmd.Parameters.Add("@paspasajero", MySqlDbType.VarChar);  cmd.Parameters.Add("@estadopasajero", MySqlDbType.VarChar);
                                            

                        for (int i = 0; i < this.grdPasajeros.Rows.Count - 1; i++)
                        {

                            cmd.Parameters["@nompasajero"].Value = this.grdPasajeros[1, i].Value;
                            cmd.Parameters["@apepasajero"].Value = this.grdPasajeros[2, i].Value;
                            cmd.Parameters["@dirpasajero"].Value = this.grdPasajeros[3, i].Value;
                            cmd.Parameters["@edadpasajero"].Value = this.grdPasajeros[4, i].Value;
                            cmd.Parameters["@dpipasajero"].Value = this.grdPasajeros[5, i].Value;
                            cmd.Parameters["@fechapasajero"].Value = this.grdPasajeros[6, i].Value;
                            cmd.Parameters["@paspasajero"].Value = this.grdPasajeros[7, i].Value;
                            cmd.Parameters["@estadopasajero"].Value = this.grdPasajeros[8, i].Value;
                           
                            cmd.ExecuteNonQuery();
                        }      

                        clasconexion.funobtenerConexion().Close();

                        funconsultarPasajeros();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
        }

       

        
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnrefrescarBd_Click(object sender, EventArgs e)
        {
            funrefrescarDatosBD();
        }

        private void funrefrescarDatosBD()
        {
            funllenarComboEliminarPasajero();
            funllenarComboModificarPasajero();
            funllenarComboAdicionalesPasajero();
        }

        private int icontadorTelefonosPasajeros=0;
        private int[] stelefono = new int[50];
        private int icontadorCorreosPasajeros = 0;
        private string[] scorreo = new string[50];
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
           
            lstTelefonoPasajero.Items.Add(txtTelefonoPasajero.Text);
            stelefono[icontadorTelefonosPasajeros] = Convert.ToInt32(txtTelefonoPasajero.Text);                
            icontadorTelefonosPasajeros++;
            txtTelefonoPasajero.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstCorreoPasajero.Items.Add(txtCorreoPasajero.Text);
            scorreo[icontadorCorreosPasajeros] = txtCorreoPasajero.Text.ToString();
            icontadorCorreosPasajeros++;
            txtCorreoPasajero.Text = "";
        }


        private void funbuscarAdicionalesPasajero()
        {
            using (clasconexion.funobtenerConexion())
            {

                string squeryBuscarPasajero = "SELECT ncodpasajero as CodigoPasajero,ntelefono as TelefonoPasajero FROM aerolinea.TrTELEFONO  where ncodpasajero=" + cmbcodPasajero.Text;
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                DataTable dtDat = new DataTable();
                MySqlDataAdapter mdaDat = new MySqlDataAdapter(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                mdaDat.Fill(dtDat);
                grdtelefonoPasajero.DataSource = dtDat;
                string squeryBuscarCorreos = "SELECT ncodpasajero as CodigoPasajero,vcorreo as CorreoPasajero FROM aerolinea.TrCORREO where ncodpasajero=" + cmbcodPasajero.Text;
                MySqlCommand cmndco = new MySqlCommand(squeryBuscarCorreos, clasconexion.funobtenerConexion());
                DataTable dtDatCorreo = new DataTable();
                MySqlDataAdapter mDatCorreo = new MySqlDataAdapter(squeryBuscarCorreos, clasconexion.funobtenerConexion());
                mDatCorreo.Fill(dtDatCorreo);
                grdcorreoPasajero.DataSource = dtDatCorreo;
                clasconexion.funobtenerConexion().Close();


            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbcodPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            funbuscarAdicionalesPasajero();
        }

        private void cmbmodificoPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            funbuscarPasajeroAModificar();
        }
    }
}
