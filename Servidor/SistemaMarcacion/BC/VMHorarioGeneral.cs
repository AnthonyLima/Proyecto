using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMHorarioGeneral
    {
        private int _CodigoHorario;
        private int _CodigoHora;
        private string _Dias;

        public int CodigoHorario { get { return _CodigoHorario; } set { _CodigoHorario = value; } }
        public int CodigoHora { get { return _CodigoHora; } set { _CodigoHora = value; } }
        public string Dias { get { return _Dias; } set { _Dias = value; } }

        public VMHorarioGeneral()
        {
            CodigoHorario = 0;
            CodigoHora = 0;
            Dias = string.Empty;
        }
    }
}
