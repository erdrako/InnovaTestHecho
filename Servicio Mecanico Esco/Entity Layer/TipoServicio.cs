using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class TipoServicio
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        public int ID
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public TipoServicio(int id, string nombre, string descripcion)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
