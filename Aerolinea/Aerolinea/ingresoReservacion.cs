﻿using System;
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
    public partial class ingresoReservacion : Form
    {
        public ingresoReservacion()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu rpb = new Menu();
            rpb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionReservacion fm3 = new seleccionReservacion();
            fm3.Show();
        }
    }
}
