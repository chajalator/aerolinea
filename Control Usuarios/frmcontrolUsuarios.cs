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

namespace Aerolinea
{
    public partial class frmcontrolUsuarios : Form
    {
        public frmcontrolUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void frmControlUsuarios_Load(object sender, EventArgs e)
        {
            funconsultarUsuario();
            funLlenarComboTipoUsuario();
            funllenarComboEliminarUsuario();
            //funbuscarUsuario();
        }

    private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int ifilas;
                int iCodigoUsuario;
                using (clasconexion.funobtenerConexion())
                {
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.MaUSUARIO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    ifilas = Convert.ToInt32(cmd.ExecuteScalar());
                    iCodigoUsuario = ifilas + 1;
                    clasconexion.funobtenerConexion().Close();
                }
                using (clasconexion.funobtenerConexion())
                {
                    string sInsertarUsuario = "INSERT INTO aerolinea.MaUSUARIO  (ncodusuario, vnomusuario, vapeusuario, vuser, vpassword,vestado, ncodtipousuario)values(" + iCodigoUsuario + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtUser.Text + "'," + txtPassword.Text + ",'" + "ACTIVO" +"','" + cmbSeleccionartipo.SelectedValue+ "')";
                    MySqlCommand cmd2 = new MySqlCommand(sInsertarUsuario, clasconexion.funobtenerConexion());
                    MySqlDataReader MyReader;
                    MyReader = cmd2.ExecuteReader();
                    MessageBox.Show("USUARIO REGISTRADO");
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void funlimpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void funconsultarUsuario()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodusuario as CodigoUsuario, vnomusuario as NombreUsuario, vapeusuario as ApellidoUsuario, vuser as Usuario, vpassword as Password, ncodtipousuario as TipoUsuario, vestado as Estado from aerolinea.MaUSUARIO where vestado = 'ACTIVO'";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdUsuarios.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void funLlenarComboTipoUsuario() {
            using (clasconexion.funobtenerConexion())
            {
               
                string squery = "SELECT ncodtipousuario, vdescripciontipo FROM aerolinea.MaTIPOUSUARIO";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbSeleccionartipo.ValueMember = "ncodtipousuario";
                cmbSeleccionartipo.DisplayMember = "vdescripciontipo";
                cmbSeleccionartipo.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void funbuscarUsuario()
        {
            using (clasconexion.funobtenerConexion())
            {

                string squeryBuscarUsuario = "SELECT ncodusuario as CodigoUsuario, vnomusuario as NombreUsuario,vapeusuario as ApellidoUsuario, vuser as Usuario,vpassword as Password, ncodtipousuario as TipoUsuario,vestado as EstadoUsuario FROM aerolinea.MaUSUARIO  where vnomusuario='" + txtbusquedaUsuario.Text +"'";
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarUsuario, clasconexion.funobtenerConexion());
                DataTable dtDat = new DataTable();
                MySqlDataAdapter mdaDat = new MySqlDataAdapter(squeryBuscarUsuario, clasconexion.funobtenerConexion());
                mdaDat.Fill(dtDat);
                grdUsuarios.DataSource = dtDat;
                clasconexion.funobtenerConexion().Close();


            }
        }
        private void funllenarComboEliminarUsuario()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodusuario, vuser FROM aerolinea.MaUSUARIO where vestado='ACTIVO'";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbeliminarUsuario.ValueMember = "ncodusuario";
                cmbeliminarUsuario.DisplayMember = "vuser";
                cmbeliminarUsuario.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void funeliminarUsuario()
        {
            using (clasconexion.funobtenerConexion())
            {
                try
                {
                    //string sfechaNacimiento = dtpasajero.Value.ToShortDateString();
                    //MessageBox.Show(sfechaNacimiento);
                    string seliminarUsuario = "UPDATE aerolinea.MaUSUARIO set vestado = 'INACTIVO' where ncodusuario = '" + cmbeliminarUsuario.SelectedValue + "'"; 
                    MySqlCommand cmd2 = new MySqlCommand(seliminarUsuario, clasconexion.funobtenerConexion());
                    cmd2.ExecuteNonQuery();
                    clasconexion.funobtenerConexion().Close();
                    funconsultarUsuario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
 
        private void cmbSeleccionartipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            funbuscarUsuario();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            funeliminarUsuario();
            funllenarComboEliminarUsuario();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmodificarUsuario modificar = new frmmodificarUsuario();
            modificar.Show();
        }

        private void rEFRESCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funconsultarUsuario();
            funllenarComboEliminarUsuario();
        }
    }
}
