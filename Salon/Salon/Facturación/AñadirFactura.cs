using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Facturación
{
    public partial class AñadirFactura : Form
    {
        public AñadirFactura()
        {
            InitializeComponent();
        }

        private void DgvDatosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AñadirFactura_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    
        private void Closeagregfactu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            MostrarServicios mostrarServicios = new MostrarServicios();
            mostrarServicios.ShowDialog();
        }

   
        private void btnProducto_Click(object sender, EventArgs e)
        {
            MostrarProductos mostrarProductos = new MostrarProductos(); 
            mostrarProductos.ShowDialog();
        }
    }
}
