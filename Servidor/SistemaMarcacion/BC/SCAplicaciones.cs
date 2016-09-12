using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCAplicaciones
    {
        private int _CodigoAplicacion;
        private string _Nombre;

        public int CodigoAplicacion { get { return _CodigoAplicacion; } set { _CodigoAplicacion = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }

        public SCAplicaciones()
        {
            CodigoAplicacion = 0;
            Nombre = string.Empty;
        }
    }
}
