using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMIdentificador
    {
        private BGlobal.Global conect = new BGlobal.Global();

        #region Cargar codigo identificacion de un trabajador y tipo identificacion
        public DataTable PCIdentificador(int sCodigoTrabajador, string sCodigoTipoIdentificacion)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            Campos[1] = "CodigoTipoIdentificacion";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sCodigoTrabajador;
            Objetos[1] = sCodigoTipoIdentificacion;

            dTabla = conect.Consulta("MPCIdentificadorPorCodigoTrabajadorYTipoIdent", Campos, Objetos);

            return dTabla;
        }
        #endregion

        #region generar nuevo identificador
        public bool PIIdentificador(BC.VMIdentificador svmIdentificador)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoTrabajador";
            Campos[1] = "CodigoTipoIdentificacion";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = svmIdentificador.CodigoTrabajador;
            Objetos[1] = svmIdentificador.CodigoTipoIdentificador;

            temp = conect.IDU("MPIIdentificador", Campos, Objetos);

            return temp;
        }
        #endregion

        public bool PUIdentificador(BC.VMIdentificador svmIdentificador)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoIdentificacion";
            Campos[1] = "CodigoTrabajador";
            Campos[2] = "CodigoTipoIdentificacion";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = svmIdentificador.CodigoIdentificador;
            Objetos[1] = svmIdentificador.CodigoTrabajador;
            Objetos[2] = svmIdentificador.CodigoTipoIdentificador;

            temp = conect.IDU("MPUIdentificador", Campos, Objetos);

            return temp;
        }
    }
}
