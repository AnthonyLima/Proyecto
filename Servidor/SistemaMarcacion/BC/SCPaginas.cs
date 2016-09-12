using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCPaginas
    {
        private int _CodigoPagina;
        private string _Nombre;
        private string _Enlace;

        public int CodigoPagina { get { return _CodigoPagina; } set { _CodigoPagina = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        public string Enlace { get { return _Enlace; } set { _Enlace = value; } }

        public SCPaginas()
        {
            CodigoPagina = 0;
            Nombre = string.Empty;
            Enlace = string.Empty;
        }
    }
}
