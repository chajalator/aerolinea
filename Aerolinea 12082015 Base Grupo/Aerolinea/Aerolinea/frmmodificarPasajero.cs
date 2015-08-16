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
//Fecha Inicio: 14/Agosto/2015      Fecha Fin: 15/Agosto/2015
namespace Aerolinea
{
    public partial class frmmodificarPasajero : Form
    {
        public frmmodificarPasajero()
        {
            InitializeComponent();
        }

        private void rEGRESARToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
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

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmmodificarPasajero_Load(object sender, EventArgs e)
        {
            funllenarComboModificarPasajero();
            funllenarComboModificarCorreooTelefono();
            cmbcodigoModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbmodificoPasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void funllenarComboModificarCorreooTelefono()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryModificar = "SELECT ncodpasajero  FROM aerolinea.MaPASAJERO";
                MySqlCommand cmdc = new MySqlCommand(squeryModificar, clasconexion.funobtenerConexion());
                DataTable dtdatosModificar = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squeryModificar, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtdatosModificar);

                cmbcodigoModificar.ValueMember = "ncodpasajero";
                cmbcodigoModificar.DisplayMember = "ncodpasajero";
                cmbcodigoModificar.DataSource = dtdatosModificar;
                clasconexion.funobtenerConexion().Close();


            }
            clasconexion.funobtenerConexion().Close();
        }

        private void cmbmodificoPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void funbuscarPasajeroAModificar()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryBuscarPasajero = "SELECT ncodpasajero ,vnompasajero ,vapepasajero ,vdireccion ,nedadpasajero,vdpi,DATE_FORMAT(dfechanacimiento, '%Y') as anio,DATE_FORMAT(dfechanacimiento, '%m') as mes,DATE_FORMAT(dfechanacimiento, '%d') as dia,vnopasaporte,vestado FROM aerolinea.MaPASAJERO where ncodpasajero=" + cmbmodificoPasajero.Text + ";";
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                MySqlDataReader drdr = cmdc.ExecuteReader();
                if (drdr.Read())
                {
                    txtNomPasajero.Text = Convert.ToString(drdr["vnompasajero"]);
                    txtApellidoPasajero.Text = Convert.ToString(drdr["vapepasajero"]);
                    txtDireccionPasajero.Text = Convert.ToString(drdr["vdireccion"]);
                    txtEdadPasajero.Text = Convert.ToString(drdr["nedadpasajero"]);
                    txtdpiPasajero.Text = Convert.ToString(drdr["vdpi"]);
                    //dtpasajero.Text = Convert.ToString(drdr["dfechanacimiento"]);
                    string sanio, smes, sdia;

                    sanio = Convert.ToString(drdr["anio"]);
                    smes = Convert.ToString(drdr["mes"]);
                    sdia = Convert.ToString(drdr["dia"]);
                    dtpasajero.Value = new DateTime(Convert.ToInt32(sanio), Convert.ToInt32(smes), Convert.ToInt32(sdia));
                    txtnoPasaporte.Text = Convert.ToString(drdr["vnopasaporte"]);
                    cmbestadoPasajero.Text = Convert.ToString(drdr["vestado"]);

                }
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            funbuscarPasajeroAModificar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarPasajero_Click(object sender, EventArgs e)
        {
            funmodificarPasajero();
        }

        private void funmodificarPasajero()
        {

            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = clasconexion.funobtenerConexion().CreateCommand();
                    cmd.CommandText = "UPDATE aerolinea.MaPASAJERO  set vnompasajero = @nompasajero,vapepasajero = @apepasajero,vdireccion = @dirpasajero,nedadpasajero = @edadpasajero,vdpi = @dpipasajero,dfechanacimiento = @fechapasajero,vnopasaporte = @paspasajero,vestado = @estadopasajero where ncodpasajero=" + cmbmodificoPasajero.Text;
                    cmd.Parameters.Add("@nompasajero", MySqlDbType.VarChar); cmd.Parameters.Add("@apepasajero", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@dirpasajero", MySqlDbType.VarChar); cmd.Parameters.Add("@edadpasajero", MySqlDbType.Decimal);
                    cmd.Parameters.Add("@dpipasajero", MySqlDbType.VarChar); cmd.Parameters.Add("@fechapasajero", MySqlDbType.Date);
                    cmd.Parameters.Add("@paspasajero", MySqlDbType.VarChar); cmd.Parameters.Add("@estadopasajero", MySqlDbType.VarChar);

                    cmd.Parameters["@nompasajero"].Value = this.txtNomPasajero.Text;
                    cmd.Parameters["@apepasajero"].Value = this.txtApellidoPasajero.Text;
                    cmd.Parameters["@dirpasajero"].Value = this.txtDireccionPasajero.Text;
                    cmd.Parameters["@edadpasajero"].Value = this.txtEdadPasajero.Text;
                    cmd.Parameters["@dpipasajero"].Value = this.txtdpiPasajero.Text;
                    cmd.Parameters["@fechapasajero"].Value = this.dtpasajero.Text;
                    cmd.Parameters["@paspasajero"].Value = this.txtnoPasaporte.Text;
                    cmd.Parameters["@estadopasajero"].Value = this.cmbestadoPasajero.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pasajero Modificado");
                    clasconexion.funobtenerConexion().Close();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnbuscarCodModificar_Click(object sender, EventArgs e)
        {
            funllenarCombocorreos();
            funllenarCombotelefonos();
        }

        private void funllenarCombotelefonos()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryModificarTelefono = "SELECT ntelefono FROM aerolinea.TrTELEFONO where ncodpasajero=" + cmbcodigoModificar.Text;
                MySqlCommand cmdtelefono = new MySqlCommand(squeryModificarTelefono, clasconexion.funobtenerConexion());
                DataTable dtdatosModificarTelefono = new DataTable();
                MySqlDataAdapter mdaDatosTelefono = new MySqlDataAdapter(squeryModificarTelefono, clasconexion.funobtenerConexion());
                mdaDatosTelefono.Fill(dtdatosModificarTelefono);

                cmbtelefonosPasajero.ValueMember = "ntelefono";
                cmbtelefonosPasajero.DisplayMember = "ntelefono";
                cmbtelefonosPasajero.DataSource = dtdatosModificarTelefono;


                clasconexion.funobtenerConexion().Close();


            }
            clasconexion.funobtenerConexion().Close();
        }

        private void funllenarCombocorreos()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryModificarCorreo = "SELECT vcorreo FROM aerolinea.TrCORREO where ncodpasajero=" + cmbcodigoModificar.Text;
                MySqlCommand cmdcorreo = new MySqlCommand(squeryModificarCorreo, clasconexion.funobtenerConexion());
                DataTable dtdatosModificarCorreo = new DataTable();
                MySqlDataAdapter mdaDatosCorreo = new MySqlDataAdapter(squeryModificarCorreo, clasconexion.funobtenerConexion());
                mdaDatosCorreo.Fill(dtdatosModificarCorreo);

                cmbcorreosPasajero.ValueMember = "vcorreo";
                cmbcorreosPasajero.DisplayMember = "vcorreo";
                cmbcorreosPasajero.DataSource = dtdatosModificarCorreo;
                
                
                clasconexion.funobtenerConexion().Close();


            }
            clasconexion.funobtenerConexion().Close();
        }

        private void radnuevoCorreo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            txtCorreoPasajero.Visible = true;
            label14.Visible = false;
            cmbcorreosPasajero.Visible = false;
            btnagregarCorreo.Visible = true;
            btnmodificarCorreo.Visible = false;
            btneliminarCorreo.Visible = false;

        }

        private void radmodificarCorreo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtCorreoPasajero.Visible = false;
            label14.Visible = true;
            cmbcorreosPasajero.Visible = true;
            btnagregarCorreo.Visible = false;
            btnmodificarCorreo.Visible = true;
            btneliminarCorreo.Visible = false;
        }

        private void radeliminarCorreo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtCorreoPasajero.Visible = false;
            label14.Visible = true;
            cmbcorreosPasajero.Visible = true;
            btnagregarCorreo.Visible = false;
            btnmodificarCorreo.Visible = false;
            btneliminarCorreo.Visible = true;
            cmbcorreosPasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            
        }

        private void btnagregarCorreo_Click(object sender, EventArgs e)
        {
            using (clasconexion.funobtenerConexion())
            {
                    string sinsertartelefono1 = "INSERT INTO aerolinea.TrCORREO (ncodpasajero,vcorreo)values(" + cmbcodigoModificar.Text  + ",'" + txtCorreoPasajero.Text  + "');";
                    MySqlCommand cmd3 = new MySqlCommand(sinsertartelefono1, clasconexion.funobtenerConexion());
                    cmd3.ExecuteNonQuery();
                    txtCorreoPasajero.Text = "";
                    MessageBox.Show("Correo Agregado");
                clasconexion.funobtenerConexion().Close();
               
            }
        }

        private void rEFRESCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funllenarComboModificarCorreooTelefono();
        }
        string scorreo;
        private void cmbcorreosPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            scorreo = cmbcorreosPasajero.Text;
            //MessageBox.Show("CORREO SELECCIONADO: " + scorreo);

        }

        private void btnmodificarCorreo_Click(object sender, EventArgs e)
        {
            funmodificoCorreo();
        }

        private void funmodificoCorreo()
        {
            using (clasconexion.funobtenerConexion())
            {
                try
                {
                        string smodificarCorreo = "UPDATE aerolinea.TrCORREO set vcorreo='" + cmbcorreosPasajero.Text + "' where ncodpasajero =" +cmbcodigoModificar.Text + " and vcorreo='" + scorreo + "';";
                        MySqlCommand cmd3 = new MySqlCommand(smodificarCorreo, clasconexion.funobtenerConexion());
                        cmd3.ExecuteNonQuery();
                       
                        MessageBox.Show("Correo Modificado");
                        clasconexion.funobtenerConexion().Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btneliminarCorreo_Click(object sender, EventArgs e)
        {
            funeliminarcorreo();
        }

        private void funeliminarcorreo()
        {
            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    string seliminarCorreo = "delete from aerolinea.TrCORREO  where vcorreo='" + cmbcorreosPasajero.Text + "' and ncodpasajero =" + cmbcodigoModificar.Text + ";";
                    MySqlCommand cmdeliminar = new MySqlCommand(seliminarCorreo, clasconexion.funobtenerConexion());
                    cmdeliminar.ExecuteNonQuery();

                    MessageBox.Show("Correo Eliminado");
                    clasconexion.funobtenerConexion().Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radnuevoTelefono_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            txtTelefonoPasajero.Visible = true;
            label15.Visible = false;
            cmbtelefonosPasajero.Visible = false;
            btnnuevoTelefono.Visible = true;
            btneliminarTelefono.Visible = false;
            btnmodificarTelefono.Visible = false;

        }

        private void radmodificarTelefono_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            txtTelefonoPasajero.Visible = false;
            label15.Visible = true;
            cmbtelefonosPasajero.Visible = true;
            btnnuevoTelefono.Visible = false;
            btneliminarTelefono.Visible = false;
            btnmodificarTelefono.Visible = true;
        }

        private void radeliminarTelefono_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            txtTelefonoPasajero.Visible = false;
            label15.Visible = true;
            cmbtelefonosPasajero.Visible = true;
            
            btnnuevoTelefono.Visible = false;
            btneliminarTelefono.Visible = true;
            btnmodificarTelefono.Visible = false;
            cmbtelefonosPasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void btnnuevoTelefono_Click(object sender, EventArgs e)
        {
            using (clasconexion.funobtenerConexion())
            {
                string sinsertartelefono1 = "INSERT INTO aerolinea.TrTELEFONO (ncodpasajero,ntelefono)values(" + cmbcodigoModificar.Text + "," + txtTelefonoPasajero.Text + ");";
                MySqlCommand cmd3 = new MySqlCommand(sinsertartelefono1, clasconexion.funobtenerConexion());
                cmd3.ExecuteNonQuery();
                txtTelefonoPasajero.Text = "";
                MessageBox.Show("Teléfono Agregado");
                clasconexion.funobtenerConexion().Close();

            }
        }

        private void btnmodificarTelefono_Click(object sender, EventArgs e)
        {
            funmodificoTelefono();
        }

        private void funmodificoTelefono()
        {
            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    string smodificarTelefono = "UPDATE aerolinea.TrTELEFONO set ntelefono=" + cmbtelefonosPasajero.Text + " where ncodpasajero =" + cmbcodigoModificar.Text + " and ntelefono='" + stelefono + "';";
                    MySqlCommand cmdTelefono = new MySqlCommand(smodificarTelefono, clasconexion.funobtenerConexion());
                    cmdTelefono.ExecuteNonQuery();

                    MessageBox.Show("Teléfono Modificado");
                    clasconexion.funobtenerConexion().Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string stelefono;
        private void cmbtelefonosPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            stelefono = cmbtelefonosPasajero.Text;
        }

        private void btneliminarTelefono_Click(object sender, EventArgs e)
        {
            funeliminartelefono();
        }

        private void funeliminartelefono()
        {
            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    string seliminarTelefono = "delete from aerolinea.TrTELEFONO where ntelefono=" + cmbtelefonosPasajero.Text + " and ncodpasajero =" + cmbcodigoModificar.Text + ";";
                    MySqlCommand cmdeliminar = new MySqlCommand(seliminarTelefono, clasconexion.funobtenerConexion());
                    cmdeliminar.ExecuteNonQuery();

                    MessageBox.Show("Telefono Eliminado");
                    clasconexion.funobtenerConexion().Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
