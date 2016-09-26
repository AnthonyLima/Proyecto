using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMMarcacion
    {
        private int _CodigoTrabajador;
        private int _CodigoMarcacion;
        private DateTime _FechaYHora;
        private string _CodigoTipoMarcacion;

        public int CodigoTrabajador { get { return _CodigoTrabajador; } set { _CodigoTrabajador = value; } }
        public int CodigoMarcacion { get { return _CodigoMarcacion; } set { _CodigoMarcacion = value; } }
        public DateTime FechaYHora { get { return _FechaYHora; } set { _FechaYHora = value; } }
        public string CodigoTipoMarcacion { get { return _CodigoTipoMarcacion; } set { _CodigoTipoMarcacion = value; } }

        public VMMarcacion()
        {
            CodigoTrabajador = 0;
            CodigoMarcacion = 0;
            FechaYHora = DateTime.Now;
            CodigoTipoMarcacion = string.Empty;
        }
    }
}
