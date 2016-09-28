using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMHorario
    {
        private BGlobal.Global conect = new BGlobal.Global();

        public bool PIHorario(BC.VMHorario sVMHorario)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoHorario";
            Campos[1] = "CodigoTrabajador";
            Campos[2] = "FechaInicio";
            Campos[3] = "FechaFin";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMHorario.CodigoHorario;
            Objetos[1] = sVMHorario.CodigoTrabajador;
            Objetos[2] = sVMHorario.FechaInicio;
            Objetos[3] = sVMHorario.FechaFin;

            temp = conect.IDU("MPIHorario", Campos, Objetos);

            return temp;
        }
    }
}
