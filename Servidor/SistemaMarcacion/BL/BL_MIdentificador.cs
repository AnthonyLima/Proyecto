using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BL
{
    public class BL_MIdentificador
    {
        DA.DAVMIdentificador DaTemp = new DA.DAVMIdentificador();

        #region cargar identificador de un trabajador
        public DataTable BLPMCIdentificadorPorTrabYTipoIdent(int sCodigoTrabajador, string sCodigoTipoIdent)
        {
            DataTable dtLista = new DataTable();
            dtLista = DaTemp.PCIdentificador(sCodigoTrabajador, sCodigoTipoIdent);
            return dtLista;
        }
        #endregion

        public bool BLPMIIdentificador(BC.VMIdentificador svmIdentificador)
        {
            return DaTemp.PIIdentificador(svmIdentificador);
        }

        public bool BLPMUIdentificador(BC.VMIdentificador svmIdenificador)
        {
            return DaTemp.PUIdentificador(svmIdenificador);
        }
    }
}
