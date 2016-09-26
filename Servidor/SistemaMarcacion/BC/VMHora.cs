using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMHora
    {
        private int _CodigoHora;
        private DateTime _HoraEntrada;
        private DateTime _HoraSalida;

        public int CodigoHora { get { return _CodigoHora; } set { _CodigoHora = value; } }
        public DateTime HoraEntrada { get { return _HoraEntrada; } set { _HoraEntrada = value; } }
        public DateTime HoraSalida { get { return _HoraSalida; } set { _HoraSalida = value; } }

        public VMHora()
        {
            CodigoHora = 0;
            HoraEntrada = DateTime.Now;
            HoraSalida = DateTime.Now;
        }
    }
}
