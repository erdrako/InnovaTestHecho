using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business_Logic_Layer
{
    public static class TipoServicio
    {
        public static Dictionary<int,Entity_Layer.TipoServicio> TipoServicios_Obtener()
        {
            Dictionary<int, Entity_Layer.TipoServicio> retorno;
            retorno = Data_Access_Layer.Procedures.TipoServicios_Obtener();
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.TipoServicio> TipoServicios_Obtener(string nombre)
        {
            Dictionary<int, Entity_Layer.TipoServicio> retorno;
            retorno = Data_Access_Layer.Procedures.TipoServicios_Obtener(nombre);
            return retorno;
        }

        public static bool TipoServicio_Ingresar(string nombre, string descripcion)
        {
            Dictionary<int, Entity_Layer.TipoServicio> dt;
            dt = Data_Access_Layer.Procedures.TipoServicios_Obtener(nombre);
            if(dt.Count == 0)
            {
                return Data_Access_Layer.Procedures.TipoServicio_Ingresar(nombre, descripcion);
            }
            else { return false; }
            
        }

    }
}
