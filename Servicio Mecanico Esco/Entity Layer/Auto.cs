using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Auto
    {
        private int _idauto;
        private int _idcliente;
        private string _marca;
        private int _año;
        private string _patente;

        public int IDAuto
        {
            get { return _idauto; }
        }

        public int IDCliente
        {
            get { return _idcliente; }
        }

        public string Marca
        {
            get { return _marca; }
        }

        public int Año
        {
            get { return _año; }
        }

        public string Patente
        {
            get { return _patente; }
        }

        public Auto(int idauto, int idcliente, string marca, int año, string patente)
        {
            _idauto = idauto;
            _idcliente = idcliente;
            _marca = marca;
            _año = año;
            _patente = patente;
        }

    }
}
