using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business_Logic_Layer
{
    public static class Servicio
    {
        public static bool Servicio_Ingresar(int idauto, string servicio)
        {
            try
            {
                return Data_Access_Layer.Procedures.Servicio_Ingresar(idauto, servicio);

            }
            catch (Exception e)
            {
                return false;
            }
            
        }

    }
}
