using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Data_Access_Layer
{

    public static class Procedures
    {
        #region Clientes
        public static Dictionary<int,Entity_Layer.Cliente> Clientes_Obtener()
        {
            Dictionary<int, Entity_Layer.Cliente> retorno = new Dictionary<int, Entity_Layer.Cliente>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.Cliente tmpcliente;
            cmd = Querys.Clientes_Obtener();
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpcliente = EntityMapper.Cliente_Mapear(rdr);
                    retorno.Add(tmpcliente.ID, tmpcliente);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.Cliente> Clientes_Obtener(string nombre, string apellido)
        {
            Dictionary<int, Entity_Layer.Cliente> retorno = new Dictionary<int, Entity_Layer.Cliente>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.Cliente tmpcliente;
            cmd = Querys.Clientes_Obtener(nombre,apellido);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpcliente = EntityMapper.Cliente_Mapear(rdr);
                    retorno.Add(tmpcliente.ID, tmpcliente);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static bool Cliente_Ingresar(string nombre, string apellido)
        {
            SqlCommand cmd;
            cmd = Querys.Usuario_Cargar(nombre, apellido);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }
        #endregion

        #region Autos
        public static Dictionary<int,Entity_Layer.Auto> Autos_Obtener()
        {
            Dictionary<int, Entity_Layer.Auto> retorno = new Dictionary<int, Entity_Layer.Auto>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.Auto tmpauto;
            cmd = Querys.Autos_Obtener();
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpauto = EntityMapper.Auto_Mapear(rdr);
                    retorno.Add(tmpauto.IDAuto, tmpauto);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.Auto> Autos_Obtener(int idcliente)
        {
            Dictionary<int, Entity_Layer.Auto> retorno = new Dictionary<int, Entity_Layer.Auto>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.Auto tmpauto;
            cmd = Querys.Autos_Obtener(idcliente);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpauto = EntityMapper.Auto_Mapear(rdr);
                    retorno.Add(tmpauto.IDAuto, tmpauto);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.Auto> Autos_Obtener(string patente)
        {
            Dictionary<int, Entity_Layer.Auto> retorno = new Dictionary<int, Entity_Layer.Auto>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.Auto tmpauto;
            cmd = Querys.Autos_Obtener(patente);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpauto = EntityMapper.Auto_Mapear(rdr);
                    retorno.Add(tmpauto.IDAuto, tmpauto);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static bool Auto_Ingresar(int idcliente, string marca, int año, string patente)
        {
            SqlCommand cmd;
            cmd = Querys.Auto_Ingresar(idcliente, marca,año,patente);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
        #endregion

        #region TiposServicios

        public static Dictionary<int, Entity_Layer.TipoServicio> TipoServicios_Obtener()
        {
            Dictionary<int, Entity_Layer.TipoServicio> retorno = new Dictionary<int, Entity_Layer.TipoServicio>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.TipoServicio tmpserv;
            cmd = Querys.TipoServicios_Obtener();
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpserv = EntityMapper.TipoServicio_Mapear(rdr);
                    retorno.Add(tmpserv.ID, tmpserv);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.TipoServicio> TipoServicios_Obtener(int idtiposervicio)
        {
            Dictionary<int, Entity_Layer.TipoServicio> retorno = new Dictionary<int, Entity_Layer.TipoServicio>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.TipoServicio tmpserv;
            cmd = Querys.TipoServicios_Obtener(idtiposervicio);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpserv = EntityMapper.TipoServicio_Mapear(rdr);
                    retorno.Add(tmpserv.ID, tmpserv);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static Dictionary<int, Entity_Layer.TipoServicio> TipoServicios_Obtener(string nombre)
        {
            Dictionary<int, Entity_Layer.TipoServicio> retorno = new Dictionary<int, Entity_Layer.TipoServicio>();
            SqlCommand cmd;
            SqlDataReader rdr = null;
            Entity_Layer.TipoServicio tmpserv;
            cmd = Querys.TipoServicios_Obtener(nombre);
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpserv = EntityMapper.TipoServicio_Mapear(rdr);
                    retorno.Add(tmpserv.ID, tmpserv);
                }
                //retorno.Load(rdr);
                rdr.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                MessageBox.Show(e.Message);
            }
            return retorno;
        }

        public static bool TipoServicio_Ingresar(string nombre, string descripcion)
        {
            SqlCommand cmd;
            cmd = Querys.TipoServicio_Ingresar(nombre, descripcion);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }


        #endregion

        #region Servicios

        public static bool Servicio_Ingresar(int idauto, string servicio)
        {
            SqlCommand cmd;
            cmd = Querys.Servicio_Ingresar(idauto, servicio);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }


        #endregion
    }
}
