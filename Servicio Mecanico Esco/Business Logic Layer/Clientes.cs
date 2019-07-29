using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business_Logic_Layer
{
    public static class Clientes
    {
        public static Dictionary<int,Entity_Layer.Cliente> Clientes_Obtener()
        {
            Dictionary<int, Entity_Layer.Cliente> retorno;
            retorno = Data_Access_Layer.Procedures.Clientes_Obtener();
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.Cliente> Clientes_Obtener(string nombre, string apellido)
        {
            Dictionary<int, Entity_Layer.Cliente> retorno;
            retorno = Data_Access_Layer.Procedures.Clientes_Obtener(nombre,apellido);
            return retorno;
        }

        public static bool Cliente_Ingresar(string nombre, string apellido)
        {
            Dictionary<int, Entity_Layer.Cliente> dt;
            dt = Data_Access_Layer.Procedures.Clientes_Obtener(nombre,apellido);
            if(dt.Count == 0)
            {
                return Data_Access_Layer.Procedures.Cliente_Ingresar(nombre, apellido);
            }
            else { return false; }
            
        }

    }
}
