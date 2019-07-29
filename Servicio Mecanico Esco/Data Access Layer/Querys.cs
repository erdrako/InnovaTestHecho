using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public static class Querys
    {
        #region Clientes
        public static SqlCommand Clientes_Obtener()
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("SELECT * FROM Clientes",Accesos.Conexion);
            return retorno;
        }

        public static SqlCommand Clientes_Obtener(string nombre, string apellido)
        {
            SqlCommand retorno = null;
            retorno = Clientes_Obtener();
            retorno.CommandText += " WHERE Nombre = @nombre AND apellido = @apellido";
            retorno.Parameters.AddWithValue("@nombre", nombre);
            retorno.Parameters.AddWithValue("@apellido", apellido);
            return retorno;
        }

        public static SqlCommand Usuario_Cargar(string nombre, string apellido)
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("INSERT INTO Clientes (Nombre, Apellido) VALUES (@nombre,@apellido)",Accesos.Conexion);
            retorno.Parameters.AddWithValue("@nombre", nombre);
            retorno.Parameters.AddWithValue("@apellido", apellido);
            return retorno;
        }
        #endregion

        #region Autos
        public static SqlCommand Autos_Obtener()
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("SELECT * FROM Autos", Accesos.Conexion);
            return retorno;
        }

        public static SqlCommand Autos_Obtener(string patente)
        {
            SqlCommand retorno = null;
            retorno = Autos_Obtener();
            retorno.CommandText += " WHERE Patente = @patente";
            retorno.Parameters.AddWithValue("@patente", patente);
            return retorno;
        }

        public static SqlCommand Autos_Obtener(int idcliente)
        {
            SqlCommand retorno = null;
            retorno = Autos_Obtener();
            retorno.CommandText += " WHERE IDCliente = @idcliente";
            retorno.Parameters.AddWithValue("@idcliente", idcliente);
            return retorno;
        }

        public static SqlCommand Auto_Ingresar(int idcliente, string marca, int año, string patente)
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("INSERT INTO Autos (IDCliente, Marca, Año, Patente) VALUES (@idcliente,@marca,@año,@patente)", Accesos.Conexion);
            retorno.Parameters.AddWithValue("@idcliente", idcliente);
            retorno.Parameters.AddWithValue("@marca", marca);
            retorno.Parameters.AddWithValue("@año", año);
            retorno.Parameters.AddWithValue("@patente", patente);
            return retorno;
        }
        #endregion

        #region TiposDeServicio

        public static SqlCommand TipoServicios_Obtener()
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("SELECT * FROM Servicios_Tipos", Accesos.Conexion);
            return retorno;
        }

        public static SqlCommand TipoServicios_Obtener(string nombre)
        {
            SqlCommand retorno = null;
            retorno = TipoServicios_Obtener();
            retorno.CommandText += " WHERE nombre = @nombre";
            retorno.Parameters.AddWithValue("@nombre", nombre);
            return retorno;
        }

        public static SqlCommand TipoServicios_Obtener(int id)
        {
            SqlCommand retorno = null;
            retorno = TipoServicios_Obtener();
            retorno.CommandText += " WHERE ID = @id";
            retorno.Parameters.AddWithValue("@id", id);
            return retorno;
        }

        public static SqlCommand TipoServicio_Ingresar(string nombre, string descripcion)
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("INSERT INTO Servicios_Tipos (Nombre, Descripcion) VALUES (@nombre,@descripcion)", Accesos.Conexion);
            retorno.Parameters.AddWithValue("@nombre", nombre);
            retorno.Parameters.AddWithValue("@descripcion", descripcion);
            return retorno;
        }


        #endregion

        #region Servicios

        public static SqlCommand Servicios_Obtener()
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("SELECT * FROM Servicios_Realizados", Accesos.Conexion);
            return retorno;
        }

        public static SqlCommand Servicios_Obtener(string nombre)
        {
            SqlCommand retorno = null;
            retorno = Servicios_Obtener();
            retorno.CommandText += " WHERE nombre = @nombre";
            retorno.Parameters.AddWithValue("@nombre", nombre);
            return retorno;
        }

        public static SqlCommand Servicios_Obtener(int id)
        {
            SqlCommand retorno = null;
            retorno = Servicios_Obtener();
            retorno.CommandText += " WHERE ID = @id";
            retorno.Parameters.AddWithValue("@id", id);
            return retorno;
        }

        public static SqlCommand Servicio_Ingresar(int idauto, string servicio)
        {
            SqlCommand retorno = null;
            retorno = new SqlCommand("INSERT INTO Servicios_Realizados (IDAuto, Servicio) VALUES (@idauto,@servicio)", Accesos.Conexion);
            retorno.Parameters.AddWithValue("@idauto", idauto);
            retorno.Parameters.AddWithValue("@servicio", servicio);

            return retorno;
        }


        #endregion

    }
}
