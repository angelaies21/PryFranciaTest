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
    public partial class FrmCargaProducto : Form
    {
        public FrmCargaProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCargaProducto_Load(object sender, EventArgs e)
        {

        }

        private void grbDatosClientes_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
       {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("ingrese el nombre del producto", "Producto regristrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
            else
            {
                cmbListaProd.Items.Add((string)txtNombre.Text);
                cmbPrioducto.Items.Add((string)txtNombre.Text);
                MessageBox.Show("Nombre regristrado con exito");

                txtNombre.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            grbDatosClientes.Visible=false;
            grbdatos.Visible = true;
            this.Size = new System.Drawing.Size(429, 321);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                
                cmbPrioducto.Items.Add((string)txtNombre.Text);
                cmbListaProd.Items.Add((string)txtNombre.Text);

                MessageBox.Show("Nombre regristrado con exito", "Gestión de producto");

                txtNombre.Text = "";
                txtNombre.Focus();               

            }               
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {


        }
    }
}
