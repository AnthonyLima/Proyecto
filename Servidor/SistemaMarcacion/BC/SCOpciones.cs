using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCOpciones
    {
        private int _CodigoOpcion;
        private string _Nombre;

        public int CodigoOpcion { get { return _CodigoOpcion; } set { _CodigoOpcion = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }

        public SCOpciones()
        {
            CodigoOpcion = 0;
            Nombre = string.Empty;
        }
    }
}
