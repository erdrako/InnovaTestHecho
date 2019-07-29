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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NuevoServicio frm = new NuevoServicio();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente frm = new NuevoCliente();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoAuto frm = new NuevoAuto();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoTipoServicio frm = new NuevoTipoServicio();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Data_Access_Layer.Accesos.Conexion_Iniciar("");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data_Access_Layer.Accesos.Conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Access_Layer.Accesos.Conexion_Iniciar(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
