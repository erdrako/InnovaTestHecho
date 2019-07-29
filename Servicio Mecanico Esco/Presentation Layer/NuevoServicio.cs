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
    public partial class NuevoServicio : Form
    {
        private string _nuevocliente = "Nuevo Cliente...";
        private string _nuevoauto = "Nuevo Auto...";
        private string _nuevotiposervicio = "Nuevo TipoServicio...";
        public NuevoServicio()
        {
            InitializeComponent();
        }

        private void NuevoServicio_Load(object sender, EventArgs e)
        {
            Dictionary<int, Entity_Layer.Cliente> clientes = Business_Logic_Layer.Clientes.Clientes_Obtener();
            
            foreach (KeyValuePair<int, Entity_Layer.Cliente> dr in clientes)
            {
                comboBox1.Items.Add(dr.Value);
            }
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Items.Add(_nuevocliente);

            Dictionary<int, Entity_Layer.TipoServicio> tiposervicios = Business_Logic_Layer.TipoServicio.TipoServicios_Obtener();

            foreach (KeyValuePair<int, Entity_Layer.TipoServicio> dr in tiposervicios)
            {
                comboBox3.Items.Add(dr.Value);
            }
            comboBox3.DisplayMember = "Nombre";
            comboBox3.Items.Add(_nuevotiposervicio);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == _nuevocliente)
            {
                NuevoCliente frmcliente = new NuevoCliente();
                frmcliente.ShowDialog();
            }
            else
            {
                Entity_Layer.Cliente cliente = (Entity_Layer.Cliente)comboBox1.SelectedItem;
                Dictionary<int, Entity_Layer.Auto> autos = Business_Logic_Layer.Autos.Autos_Obtener(cliente.ID);
                comboBox2.Items.Clear();
                foreach (KeyValuePair<int, Entity_Layer.Auto> dr in autos)
                {
                    comboBox2.Items.Add(dr.Value);
                }
                comboBox2.DisplayMember = "Patente";
                comboBox2.Items.Add(_nuevoauto);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == _nuevoauto)
            {
                NuevoAuto frmauto = new NuevoAuto();
                frmauto.ShowDialog();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == _nuevotiposervicio)
            {
                NuevoTipoServicio frmtiposervicio = new NuevoTipoServicio();
                frmtiposervicio.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entity_Layer.Auto tmpauto = (Entity_Layer.Auto)comboBox2.SelectedItem;
            Entity_Layer.TipoServicio tmptipo = (Entity_Layer.TipoServicio)comboBox3.SelectedItem;
            try
            {
                if (Business_Logic_Layer.Servicio.Servicio_Ingresar(tmpauto.IDAuto, tmptipo.Nombre))
                {
                    MessageBox.Show("Se registro correctamente el servicio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
