using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Cliente
    {
        private int _id;
        private string _nombre;
        private string _apellido;

        public int ID
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Apellido
        {
            get { return _apellido; }
        }

        public Cliente(int id, string nombre, string apellido)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
        }
    }
}
