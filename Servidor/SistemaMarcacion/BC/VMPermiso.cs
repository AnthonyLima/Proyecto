using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMPermiso
    {
        private string _CodigoPermiso;
        private int _CodigoTrabajador;
        private DateTime _FechaInicio;
        private DateTime _FechaFin;
        private string _CodigoTipoPermiso;
        private string _Observacion;

        public string CodigoPermiso { get { return _CodigoPermiso; } set { _CodigoPermiso = value; } }
        public int CodigoTrabajador { get { return _CodigoTrabajador; } set { _CodigoTrabajador = value; } }
        public DateTime FechaInicio { get { return _FechaInicio; } set { _FechaInicio = value; } }
        public DateTime FechaFin { get { return _FechaFin; } set { _FechaFin = value; } }
        public string CodigoTipoPermiso { get { return _CodigoTipoPermiso; } set { _CodigoTipoPermiso = value; } }
        public string Observacion { get { return _Observacion; } set { _Observacion = value; } }

        public VMPermiso()
        {
            CodigoPermiso = string.Empty;
            CodigoTrabajador = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            CodigoTipoPermiso = string.Empty;
            Observacion = string.Empty;
        }
    }
}
