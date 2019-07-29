using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public static class EntityMapper
    {

        public static Entity_Layer.Cliente Cliente_Mapear(SqlDataReader rdr)
        {
            Entity_Layer.Cliente retorno;
            retorno = new Entity_Layer.Cliente((int)rdr[0], rdr[1].ToString(), rdr[2].ToString());
            return retorno;
        }

        public static Entity_Layer.Auto Auto_Mapear(SqlDataReader rdr)
        {
            Entity_Layer.Auto retorno;
            retorno = new Entity_Layer.Auto((int)rdr[0],(int)rdr[1],rdr[2].ToString(),(int)rdr[3],rdr[4].ToString());
            return retorno;
        }

        public static Entity_Layer.TipoServicio TipoServicio_Mapear(SqlDataReader rdr)
        {
            Entity_Layer.TipoServicio retorno;
            retorno = new Entity_Layer.TipoServicio((int)rdr[0], rdr[1].ToString(), rdr[2].ToString());
            return retorno;
        }

    }
}
