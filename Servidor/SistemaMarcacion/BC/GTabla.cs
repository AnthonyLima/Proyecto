using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class GTabla
    {
        private string _Tabla;
        private string _Codigo;
        private string _Cadena;

        public string Tabla { get { return _Tabla; } set { _Tabla = value; } }
        public string Codigo { get { return _Codigo; } set { _Codigo = value; } }
        public string Cadena { get { return _Cadena; } set { _Cadena = value; } }

        public GTabla()
        {
            Tabla = string.Empty;
            Codigo = string.Empty;
            Cadena = string.Empty;
        }
    }
}
