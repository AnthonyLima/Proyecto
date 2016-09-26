using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMIdentificador
    {
        private string _CodigoIdentificador;
        private int _CodigoTrabajador;
        private bool _Estado;

        public string CodigoIdentificador { get { return _CodigoIdentificador; } set { _CodigoIdentificador = value; } }
        public int CodigoTrabajador { get { return _CodigoTrabajador; } set { _CodigoTrabajador = value; } }
        public bool Estado { get { return _Estado; } set { _Estado = value; } }

        public VMIdentificador()
        {
            CodigoIdentificador = string.Empty;
            CodigoTrabajador = 0;
            Estado = false;
        }
    }
}
