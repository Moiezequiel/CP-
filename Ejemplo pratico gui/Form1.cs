﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_pratico_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnsesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este momento no se puede iniciar sesion", "PIZZA HUT",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}