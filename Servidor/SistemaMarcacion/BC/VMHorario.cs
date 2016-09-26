using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMHorario
    {
        private int _CodigoHorario;
        private int _CodigoTrabajador;
        private int _CodigoHistorial;
        private DateTime _FechaIngreso;
        private DateTime _FechaFin;

        public int CodigoHorario { get { return _CodigoHorario; } set { _CodigoHorario = value; } }
        public int CodigoTrabajador { get { return _CodigoTrabajador; } set { _CodigoTrabajador = value; } }
        public int CodigoHistorial { get { return _CodigoHistorial; } set { _CodigoHistorial = value; } }
        public DateTime FechaIngreso { get { return _FechaIngreso; } set { _FechaIngreso = value; } }
        public DateTime FechaFin { get { return _FechaFin; } set { _FechaFin = value; } }

        public VMHorario()
        {
            CodigoHorario = 0;
            CodigoTrabajador = 0;
            CodigoHistorial = 0;
            FechaIngreso = DateTime.Now;
            FechaFin = DateTime.Now;
        }
    }
}
