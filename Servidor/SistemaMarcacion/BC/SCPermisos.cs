using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCPermisos
    {
        private int _CodigoPermiso;
        private string _Nombre;

        public int CodigoPermiso { get { return _CodigoPermiso; } set { _CodigoPermiso = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }

        public SCPermisos()
        {
            CodigoPermiso = 0;
            Nombre = string.Empty;
        }
    }
}
