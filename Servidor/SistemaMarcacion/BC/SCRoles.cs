using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCRoles
    {
        private int _CodigoRol;
        private string _Nombre;

        public int CodigoRol { get { return _CodigoRol; } set { _CodigoRol = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value} }

        public SCRoles()
        {
            CodigoRol = 0;
            Nombre = string.Empty;
        }
    }
}
