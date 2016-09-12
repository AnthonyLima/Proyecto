using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class SCMenus
    {
        private int _CodigoMenu;
        private string _Nombre;

        public int CodigoMenu { get { return _CodigoMenu; } set { _CodigoMenu = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }

        public SCMenus()
        {
            CodigoMenu = 0;
            Nombre = string.Empty;
        }
    }
}
