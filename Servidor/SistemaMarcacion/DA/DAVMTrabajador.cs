using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMTrabajador
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        public DataTable PCTrabajadorPorCodigoTrabajador(int sCodigoTrabajador)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoTrabajador;

            dTabla = Conect.Consulta("MPCTrabajadorPorCodigoTrabajador", Campos, Objetos);

            return dTabla;
        }

        public bool PITrabajador(BC.VMTrabajador sVMTrabajador)
        {
            bool temp = false;

            int Cantidad = 6;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            Campos[1] = "CodigoCategoria";
            Campos[2] = "CodigoArea";
            Campos[3] = "CodigoCargo";
            Campos[4] = "DNI";
            Campos[5] = "FechaIngreso";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMTrabajador.CodigoTrabajador;
            Objetos[1] = sVMTrabajador.CodigoCategoria;
            Objetos[2] = sVMTrabajador.CodigoArea;
            Objetos[3] = sVMTrabajador.CodigoCargo;
            Objetos[4] = sVMTrabajador.DNI;
            Objetos[5] = sVMTrabajador.FechaIngreso;

            temp = Conect.IDU("MPITrabajador", Campos, Objetos);

            return temp;
        }

        public bool PUTrabajador(BC.VMTrabajador sVMTrabajador)
        {
            bool temp = false;

            int Cantidad = 5;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            Campos[1] = "CodigoCategoria";
            Campos[2] = "CodigoArea";
            Campos[3] = "CodigoCargo";
            Campos[4] = "DNI";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMTrabajador.CodigoTrabajador;
            Objetos[1] = sVMTrabajador.CodigoCategoria;
            Objetos[2] = sVMTrabajador.CodigoArea;
            Objetos[3] = sVMTrabajador.CodigoCargo;
            Objetos[4] = sVMTrabajador.DNI;

            temp = Conect.IDU("MPUTrabajador", Campos, Objetos);

            return temp;
        }

        public bool PDTrabajador(int sCodigoTrabajador)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoTrabajador;

            temp = Conect.IDU("MPDTrabajador", Campos, Objetos);

            return temp;
        }
    }
}
