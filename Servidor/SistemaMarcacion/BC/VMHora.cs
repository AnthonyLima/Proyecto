using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMHora
    {
        private int _CodigoHora;
        private int _Dia;
        private DateTime _HoraEntrada;
        private DateTime _HoraSalida;
        private bool _HorarioNocturno;

        public int CodigoHora { get { return _CodigoHora; } set { _CodigoHora = value; } }
        public int Dia { get { return _Dia; } set { _Dia = value; } }
        public DateTime HoraEntrada { get { return _HoraEntrada; } set { _HoraEntrada = value; } }
        public DateTime HoraSalida { get { return _HoraSalida; } set { _HoraSalida = value; } }
        public bool HorarioNocturno { get { return _HorarioNocturno; } set { _HorarioNocturno = value; } }

        public VMHora()
        {
            CodigoHora = 0;
            Dia = 0;
            HoraEntrada = DateTime.Now;
            HoraSalida = DateTime.Now;
            HorarioNocturno = false;
        }
    }
}
