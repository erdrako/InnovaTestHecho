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
    public partial class NuevoTipoServicio : Form
    {
        public NuevoTipoServicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Business_Logic_Layer.TipoServicio.TipoServicio_Ingresar(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Se ingreso correctamente el Tipo de Servicio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
