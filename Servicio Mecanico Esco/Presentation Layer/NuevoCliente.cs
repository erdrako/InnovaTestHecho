using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    if (Business_Logic_Layer.Clientes.Cliente_Ingresar(textBox1.Text, textBox2.Text))
                    {
                        MessageBox.Show("Se cargo correctamente el cliente.");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar el cliente.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre y un apellido.");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
