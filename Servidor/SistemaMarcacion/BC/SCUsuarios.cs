using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCUsuarios
    {
        private int _CodigoUsuarios;
        private string _Nombre;
        private string _Clave;

        public int CodigoUsuarios { get { return _CodigoUsuarios; } set { _CodigoUsuarios = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        public string Clave { get { return _Clave; } set { _Clave = value; } }

        public SCUsuarios()
        {
            CodigoUsuarios = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
        }
    }
}
