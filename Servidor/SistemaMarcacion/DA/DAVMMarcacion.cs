using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMMarcacion
    {
        private BGlobal.Global conect = new BGlobal.Global();

        public DataTable PCMarcacionPorCodigoTrabajador(int sCodigoTrabajador)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoTrabajador;

            dTabla = conect.Consulta("MPCMarcacionPorCodigoTrabajador", Campos, Objetos);

            return dTabla;
        }

        public bool PIMarcacion(BC.VMMarcacion sVMMarcacion)
        {
            bool temp = false;

            int Cantidad = 3;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            Campos[1] = "FechaYHora";
            Campos[2] = "CodigoTipoMarcacion";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMMarcacion.CodigoTrabajador;
            Objetos[1] = sVMMarcacion.FechaYHora;
            Objetos[2] = sVMMarcacion.CodigoTipoMarcacion;

            temp = conect.IDU("MPIMarcacion", Campos, Objetos);

            return temp;
        }
    }
}
