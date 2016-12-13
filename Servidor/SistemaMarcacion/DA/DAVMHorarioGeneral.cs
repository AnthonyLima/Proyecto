using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMHorarioGeneral
    {
        private BGlobal.Global conect = new BGlobal.Global();

        public bool PIHorarioGeneral(int sCodigoHora,string sDias)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoHora";
            Campos[1] = "Dia";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoHora;
            Objetos[1] = sDias;

            temp = conect.IDU("MPIHorarioGeneral", Campos, Objetos);

            return temp;
        }

        public bool PDHorarioGeneral(int sCodigoHorario,int sCodigoHora = 0)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoHorario";
            Campos[1] = "CodigoHora";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoHorario;
            Objetos[1] = sCodigoHora;

            temp = conect.IDU("MPDHorarioGeneral", Campos, Objetos);

            return temp;
        }
    }
}
