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
    }
}
