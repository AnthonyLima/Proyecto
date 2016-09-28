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
            object[] objetos = new object[Cantidad];
            objetos[0] = sCodigoTrabajador;

            dTabla = Conect.Consulta("MPCTrabajadorPorCodigoTrabajador", Campos, objetos);

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
            object[] objetos = new object[Cantidad];
            objetos[0] = sVMTrabajador.CodigoTrabajador;
            objetos[1] = sVMTrabajador.CodigoCategoria;
            objetos[2] = sVMTrabajador.CodigoArea;
            objetos[3] = sVMTrabajador.CodigoCargo;
            objetos[4] = sVMTrabajador.DNI;
            objetos[5] = sVMTrabajador.FechaIngreso;

            temp = Conect.IDU("MPITrabajador", Campos, objetos);

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
            object[] objetos = new object[Cantidad];
            objetos[0] = sVMTrabajador.CodigoTrabajador;
            objetos[1] = sVMTrabajador.CodigoCategoria;
            objetos[2] = sVMTrabajador.CodigoArea;
            objetos[3] = sVMTrabajador.CodigoCargo;
            objetos[4] = sVMTrabajador.DNI;

            temp = Conect.IDU("MPUTrabajador", Campos, objetos);

            return temp;
        }

        public bool PDTrabajador(int sCodigoTrabajador)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            object[] objetos = new object[Cantidad];
            objetos[0] = sCodigoTrabajador;

            temp = Conect.IDU("MPDTrabajador", Campos, objetos);

            return temp;
        }
    }
}
