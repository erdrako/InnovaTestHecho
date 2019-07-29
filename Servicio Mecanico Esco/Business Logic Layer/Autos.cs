using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business_Logic_Layer
{
    public static class Autos
    {

        public static Dictionary<int,Entity_Layer.Auto> Autos_Obtener()
        {
            Dictionary<int, Entity_Layer.Auto> retorno;
            retorno = Data_Access_Layer.Procedures.Autos_Obtener();
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.Auto> Autos_Obtener(int idcliente)
        {
            Dictionary<int, Entity_Layer.Auto> retorno;
            retorno = Data_Access_Layer.Procedures.Autos_Obtener(idcliente);
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.Auto> Autos_Obtener(string patente)
        {
            Dictionary<int, Entity_Layer.Auto> retorno;
            retorno = Data_Access_Layer.Procedures.Autos_Obtener(patente);
            return retorno;
        }

        public static bool Auto_Ingresar(int idcliente, string marca, int año, string patente)
        {
            Dictionary<int, Entity_Layer.Auto> dt;
            dt = Data_Access_Layer.Procedures.Autos_Obtener(patente);
            if (dt.Count == 0)
            {
                return Data_Access_Layer.Procedures.Auto_Ingresar(idcliente, marca, año, patente);
            }
            else { return false; }

        }

    }
}
