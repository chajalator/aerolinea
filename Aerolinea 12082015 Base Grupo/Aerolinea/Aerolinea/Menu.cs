using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ingresoReservacion ires = new ingresoReservacion();
            ires.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void rESERVACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            agregarVuelo avuelo = new agregarVuelo();
            avuelo.Show();
            this.Hide();
        }

        private void pASAJEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoPasajero ipasaj = new ingresoPasajero();
            ipasaj.Show();
            this.Hide();
            
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cancelaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realizacionPago rP = new realizacionPago();
            rP.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionReservacion fm3 = new seleccionReservacion();
            fm3.Show();
        }
    }
}
