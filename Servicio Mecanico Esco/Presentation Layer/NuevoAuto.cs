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
    public partial class NuevoAuto : Form
    {
        string _nuevocliente = "Nuevo Cliente...";
        public NuevoAuto()
        {
            InitializeComponent();
        }

        private void NuevoAuto_Load(object sender, EventArgs e)
        {
            Dictionary<int, Entity_Layer.Cliente> dt = Business_Logic_Layer.Clientes.Clientes_Obtener();
            foreach (KeyValuePair<int, Entity_Layer.Cliente> dr in dt)
            {
                //comboBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
                comboBox1.Items.Add(dr.Value);
            }
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Items.Add(_nuevocliente);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == _nuevocliente)
            {
                NuevoCliente frm = new NuevoCliente();
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entity_Layer.Cliente cliente = (Entity_Layer.Cliente)comboBox1.SelectedItem;
            try
            {
                if(Business_Logic_Layer.Autos.Auto_Ingresar(cliente.ID, textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text))
                {
                    MessageBox.Show("Se ingreso correctamente el auto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
