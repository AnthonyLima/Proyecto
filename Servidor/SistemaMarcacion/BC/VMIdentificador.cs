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
        private string _CodigoTipoidentificador;

        public string CodigoIdentificador { get { return _CodigoIdentificador; } set { _CodigoIdentificador = value; } }
        public int CodigoTrabajador { get { return _CodigoTrabajador; } set { _CodigoTrabajador = value; } }
        public bool Estado { get { return _Estado; } set { _Estado = value; } }
        public string CodigoTipoIdentificador { get { return _CodigoTipoidentificador; } set { _CodigoTipoidentificador = value; } }

        public VMIdentificador()
        {
            CodigoIdentificador = string.Empty;
            CodigoTrabajador = 0;
            Estado = false;
            CodigoTipoIdentificador = string.Empty;
        }
    }
}
