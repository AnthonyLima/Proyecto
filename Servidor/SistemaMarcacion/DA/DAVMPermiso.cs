using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMPermiso
    {
        private BGlobal.Global conect = new BGlobal.Global();

        public DataTable PCPermisoPorCodigoTrabajador(int sCodigoTrabajador)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoTrabajador;

            dTabla = conect.Consulta("MPCPermisoPorCodigoTrabajador", Campos, Objetos);

            return dTabla;
        }

        public bool PIPermiso(BC.VMPermiso sVMPermiso)
        {
            bool temp = false;

            int Cantidad = 6;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoPermiso";
            Campos[1] = "CodigoTrabajador";
            Campos[2] = "FechaInicio";
            Campos[3] = "FechaFin";
            Campos[4] = "CodigoTipoPermiso";
            Campos[5] = "Obseervacion";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMPermiso.CodigoPermiso;
            Objetos[1] = sVMPermiso.CodigoTrabajador;
            Objetos[2] = sVMPermiso.FechaInicio;
            Objetos[3] = sVMPermiso.FechaFin;
            Objetos[4] = sVMPermiso.CodigoTipoPermiso;
            Objetos[5] = sVMPermiso.Observacion;

            temp = conect.IDU("MPIPermiso", Campos, Objetos);

            return temp;
        }

        public bool PDPermiso(string sCodigoPermiso)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoPermiso";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoPermiso;

            temp = conect.IDU("MPDPermiso", Campos, Objetos);

            return temp;
        }
    }
}
