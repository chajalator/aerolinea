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
    public partial class frmmodificarUsuario : Form
    {
        public frmmodificarUsuario()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmcontrolUsuarios regresar = new frmcontrolUsuarios();
            regresar.Show();
        }

        private void funLlenarComboTipoUsuarioModificar()
        {
            using (clasconexion.funobtenerConexion())
            {

                string squery = "SELECT ncodtipousuario, vdescripciontipo FROM aerolinea.MaTIPOUSUARIO";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbSeleccionartipoModificar.ValueMember = "ncodtipousuario";
                cmbSeleccionartipoModificar.DisplayMember = "vdescripciontipo";
                cmbSeleccionartipoModificar.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void funLlenarComboSeleccionarUsuarioModificar()
        {
            using (clasconexion.funobtenerConexion())
            {

                string squery = "SELECT ncodusuario, vuser FROM aerolinea.MaUSUARIO";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                cmbusuarioModificar.ValueMember = "ncodusuario";
                cmbusuarioModificar.DisplayMember = "vuser";
                cmbusuarioModificar.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }
        private void funLlenarTextBox()
        {
            using (clasconexion.funobtenerConexion())
            {
                string squeryBuscarUsuario = "SELECT ncodusuario, vnomusuario, vapeusuario, vuser, vpassword, vestado, ncodtipousuario FROM aerolinea.MaUSUARIO where vuser = '" + cmbusuarioModificar.Text+ "';";
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarUsuario, clasconexion.funobtenerConexion());
                MySqlDataReader drdr = cmdc.ExecuteReader();
                if (drdr.Read())
                {
                    txtNombreModificar.Text= Convert.ToString(drdr["vnomusuario"]);
                    txtApellidoModificar.Text= Convert.ToString(drdr["vapeusuario"]);
                    txtUserModificar.Text = Convert.ToString(drdr["vuser"]);
                    txtPasswordModificar.Text = Convert.ToString(drdr["vpassword"]);
                    cmbModificarEstado.Text = Convert.ToString(drdr["vestado"]);
                    cmbSeleccionartipoModificar.Text= Convert.ToString(drdr["ncodtipousuario"]);
                }
            }
        }
        private void funguardarModificacion() {
            using (clasconexion.funobtenerConexion()) {
                MySqlConnection cn2 = new MySqlConnection();
                cn2 = clasconexion.funobtenerConexion();
                MySqlCommand cmd2 = new MySqlCommand();
                string usuarioSeleccionado = cmbusuarioModificar.SelectedValue.ToString();
                cmd2.Connection = cn2;
                cmd2.CommandText = "UPDATE MaUSUARIO SET vnomusuario = " + "'" + txtNombreModificar.Text + "'" + " WHERE ncodusuario = '" + usuarioSeleccionado + "'";
                cmd2.CommandText = "UPDATE MaUSUARIO SET vapeusuario     = " + "'" + txtApellidoModificar.Text+ "'" + " WHERE ncodusuario= '" + usuarioSeleccionado + "'";
                cmd2.CommandText = "UPDATE MaUSUARIO SET   vuser = " + "'" + txtUserModificar.Text + "'" + " WHERE ncodusuario = '" + usuarioSeleccionado + "'";
                cmd2.CommandText = "UPDATE MaUSUARIO SET   vpassword = " + "'" + txtPasswordModificar.Text + "'" + " WHERE ncodusuario = '" + usuarioSeleccionado + "'";
                cmd2.CommandText = "UPDATE MaUSUARIO SET   ncodtipousuario = " + "'" + cmbSeleccionartipoModificar.SelectedValue + "'" + " WHERE ncodusuario = '" + usuarioSeleccionado + "'";        
                cmd2.CommandText = "UPDATE MaUSUARIO SET   vestado = " + "'" + cmbModificarEstado.SelectedItem + "'" + " WHERE ncodusuario = '" + usuarioSeleccionado + "'";
                
                int numRowsUpdated2 = cmd2.ExecuteNonQuery();
                MessageBox.Show("Usuario Modificado");
            }


        
        }
        private void frmmodificarUsuario_Load(object sender, EventArgs e)
        {
            funLlenarComboTipoUsuarioModificar();
            funLlenarComboSeleccionarUsuarioModificar();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            funLlenarTextBox();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            funguardarModificacion();
            this.Close();
            frmcontrolUsuarios usuarios = new frmcontrolUsuarios();
            usuarios.Show();
        }
    }
}
