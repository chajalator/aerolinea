using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PROGRAMADOR Y ANALISTA: Gerardo Santizo
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 09/Agosto/2015
namespace Aerolinea
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (claseUsuario.Autentificar(txtUser.Text, txtPass.Text) > 0)
            {
               //VALIDACIÓN DE USUARIO ADMINISTRADOR
                if (claseUsuario.user(txtUser.Text, txtPass.Text).Equals("Admin"))
                {
                    this.Hide();
                    frmMenu Menu = new frmMenu();
                    Menu.Show();
                    Menu.toolStripStatusLabel2.Text = "Usuario: " + txtUser.Text;
                    Menu.toolStripStatusLabel.Text = DateTime.Now.ToString();
                   MessageBox.Show("Bienvenid@:  " + claseUsuario.user(txtUser.Text, txtPass.Text));
                }   
                    //VALIDACIÓN DE USUARIO NORMAL (PERMISOS BÁSICOS DE INSERTAR Y CONSULTAR)
                else if (claseUsuario.user(txtUser.Text, txtPass.Text).Equals("Normal"))
                {
                    this.Hide();
                    frmMenu MenuNormal = new frmMenu();
                    MenuNormal.Show();
                    MenuNormal.toolStripStatusLabel2.Text = "Usuario: " + txtUser.Text;
                    MenuNormal.vUELOSToolStripMenuItem.Enabled = false;
                    MenuNormal.uSUARIOSToolStripMenuItem.Enabled = false;
                    MenuNormal.rEPORTESToolStripMenuItem.Enabled = false;
                    MenuNormal.toolStripStatusLabel.Text = DateTime.Now.ToString();
                    MessageBox.Show("Bienvenid@:  " + claseUsuario.user(txtUser.Text, txtPass.Text));
                }
                    //VALIDACIÓN USUARIO QUE ACCEDE A INFORMACIÓN DE VUELOS
                else if (claseUsuario.user(txtUser.Text, txtPass.Text).Equals("Vuelos")){
                    this.Hide();
                    frmMenu MenuVuelos = new frmMenu();
                    MenuVuelos.Show();
                    MenuVuelos.toolStripStatusLabel2.Text = "Usuario: " + txtUser.Text;
                    MenuVuelos.uSUARIOSToolStripMenuItem.Enabled = false;
                    MenuVuelos.pAGOSToolStripMenuItem.Enabled = false;
                    MenuVuelos.pASAJEROSToolStripMenuItem.Enabled = false;
                    MenuVuelos.rESERVACIONESToolStripMenuItem.Enabled = false;
                    MenuVuelos.rEPORTESToolStripMenuItem.Enabled = false;
                    MenuVuelos.toolStripStatusLabel.Text = DateTime.Now.ToString();

                    MessageBox.Show("Bienvenid@:  " + claseUsuario.user(txtUser.Text, txtPass.Text));
                }
                //this.Hide();
                //Menu menu = new Menu();
                //menu.Show();
            }
            else
                MessageBox.Show("Usuario o Password Incorrecto, Si el problema persiste su Usuario esta Inactivo");
                txtUser.Clear();
                txtPass.Clear();
        }
    }
}
