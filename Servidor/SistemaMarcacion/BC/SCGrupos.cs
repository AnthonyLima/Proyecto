using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCGrupos
    {
        private int _CodigoGrupo;
        private string _Nombre;

        public int CodigoGrupo { get { return _CodigoGrupo; } set { _CodigoGrupo = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value} }

        public SCGrupos()
        {
            CodigoGrupo = 0;
            Nombre = string.Empty;
        }
    }
}
