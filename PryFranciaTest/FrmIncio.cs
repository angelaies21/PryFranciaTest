using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFranciaTest
{
    public partial class FrmIncio : Form
    {
        public FrmIncio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmCargaProducto ventamaProducto = new FrmCargaProducto();
            ventamaProducto.ShowDialog();


        }

        private void FrmIncio_Load(object sender, EventArgs e)
        {

        }
    }
}
