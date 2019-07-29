using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Access_Layer
{
    public static class Accesos
    {
        private static SqlConnection _conexion;

        public static SqlConnection Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

        public static void Conexion_Iniciar(string url)
        {
            try
            {
                _conexion = new SqlConnection(url);
                //_conexion = new SqlConnection(@"Server=MAIN-PC\DEVEL;Database=SistemasEscoTest;Trusted_Connection=True;");
                _conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
