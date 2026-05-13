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
                txtNombre.Focus();  //eparece el mesnaje de error 
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            grbDatosClientes.Visible=false;  //oculta el grupobox de datos del cliente
            grbdatos.Visible = true;        //muestra el grupobox de datos del producto
            this.Size = new System.Drawing.Size(429, 321);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                
                cmbPrioducto.Items.Add((string)txtNombre.Text); //agrega lo q escribio
                cmbListaProd.Items.Add((string)txtNombre.Text); //agrega lo mismo

                MessageBox.Show("Nombre regristrado con exito", "Gestión de producto");

                txtNombre.Text = ""; //lo limpia
                txtNombre.Focus();               

            }               
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            if (opRepuesto.Checked || opEquipo.Checked)
            {
                string adicionales = "";
                double price = 0;
                double totalprice = 0;
                if (opRepuesto.Checked)
                {
                    adicionales += "Repuesto(Precio base de $350.000), ";
                    price = 350000;
                }
                if (opEquipo.Checked)
                {
                    adicionales += "Equipo(Precio base de $1.000.000), ";
                    price = 1000000;
                }
                if (chbInstalacion.Checked)
                {
                    adicionales += "Instalación (+ 15% del precio base), ";
                    totalprice = price * 1.15;
                }
                if (chbEnvio.Checked)
                {
                    adicionales += "Envío (+5% del precio base), ";
                    totalprice = price * 1.05;
                }
                if (chbGarantia.Checked)
                {
                    adicionales += "Garantía (+20% del precio total), ";
                    totalprice = totalprice * 1.2;
                }
                totalprice = totalprice * 1.21;
                adicionales += "Impuesto del IVA (+21% del precio total).";
                MessageBox.Show("Carga completa\nAdicionales: " + adicionales + "\ncosto total: $" + totalprice);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo", "Gestión de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (opRepuesto.Checked || opEquipo.Checked)

            {
                string adicionales = "";

                if (opRepuesto.Checked) adicionales += "\n Respuesto \n";
                if (opEquipo.Checked) adicionales += " Equipo \n";
                if (chbInstalacion.Checked) adicionales += " Instalación \n";
                if (chbEnvio.Checked) adicionales += " Envío \n";
                if (chbGarantia.Checked) adicionales += " Garantía \n";
                
                MessageBox.Show("Carga completa \n Adicionales: " + adicionales);

            }
            else
            {
                MessageBox.Show("Seleccione un tipo","Tìtulo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                



        }

        private void chbInstalacion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
