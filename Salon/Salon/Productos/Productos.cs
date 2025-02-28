using System;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnAgregclient_Click(object sender, EventArgs e)
        {
            AñadirProducto añadirCliente =new AñadirProducto();
            añadirCliente.ShowDialog();
        }
    }
}
