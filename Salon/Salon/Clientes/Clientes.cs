﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAgregclient_Click(object sender, EventArgs e)
        {
            AñadirCliente añadirCliente =new AñadirCliente();
            añadirCliente.ShowDialog();
        }
    }
}
