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
    public partial class frmrealizacionPago : Form
    {
        public frmrealizacionPago()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNoReservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu rpb = new frmMenu();
            rpb.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
