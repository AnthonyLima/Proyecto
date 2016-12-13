using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMHora
    {
        private BGlobal.Global conect = new BGlobal.Global();

        public DataTable PCHora(int sCodigoHora)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoHora";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoHora;

            dTabla = conect.Consulta("MPCHora", Campos, Objetos);

            return dTabla;
        }

        public bool PIHora(BC.VMHora sVMHora)
        {
            bool temp = false;

            int Cantidad = 3;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Dia";
            Campos[1] = "HoraEntrada";
            Campos[2] = "HoraSalida";
            Campos[3] = "HorarioNocturno";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMHora.Dia;
            Objetos[1] = sVMHora.HoraEntrada;
            Objetos[2] = sVMHora.HoraSalida;
            Objetos[3] = sVMHora.HorarioNocturno;

            temp = conect.IDU("MPIHora", Campos, Objetos);

            return temp;
        }

        public bool PUHora(BC.VMHora sVMHora)
        {
            bool temp = false;

            int Cantidad = 4;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoHora";
            Campos[1] = "HoraEntrada";
            Campos[2] = "HoraSalida";
            Campos[3] = "HorarioNocturno";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMHora.CodigoHora;
            Objetos[1] = sVMHora.HoraEntrada;
            Objetos[2] = sVMHora.HoraSalida;
            Objetos[3] = sVMHora.HorarioNocturno;

            temp = conect.IDU("MPIHora", Campos, Objetos);

            return temp;
        }

        public bool PDHora(int sCodigoHora)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoHora";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoHora;

            temp = conect.IDU("MPDHora", Campos, Objetos);

            return temp;
        }
    }
}
