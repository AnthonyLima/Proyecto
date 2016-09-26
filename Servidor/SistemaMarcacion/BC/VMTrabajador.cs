using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMTrabajador
    {
        private int _CodigoTrabajador;
        private string _CodigoCategoria;
        private string _CodigoArea;
        private string _CodigoCargo;
        private string _DNI;
        private DateTime _FechaIngreso;

        public int CodigoTrabajador { get { return _CodigoTrabajador; } set { _CodigoTrabajador = value; } }
        public string CodigoCategoria { get { return _CodigoCategoria; } set { _CodigoCategoria = value; } }
        public string CodigoArea { get { return _CodigoArea; } set { _CodigoArea = value; } }
        public string CodigoCargo { get { return _CodigoCargo; } set { _CodigoCargo = value; } }
        public string DNI { get { return _DNI; } set { _DNI = value; } }
        public DateTime FechaIngreso { get { return _FechaIngreso; } set { _FechaIngreso = value; } }

        public VMTrabajador()
        {
            CodigoTrabajador = 0;
            CodigoCategoria = string.Empty;
            CodigoArea = string.Empty;
            CodigoCargo = string.Empty;
            DNI = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
