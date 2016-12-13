using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BL
{
    public class BL_MPermiso
    {
        DA.DAVMPermiso DaTemp = new DA.DAVMPermiso();

        #region Busqueda de permiso por trabajador
        public DataTable BLPMCPermisoPorCodigoTrabajador(int sCodigoTrabajador)
        {
            DataTable dtLista = new DataTable();
            dtLista = DaTemp.PCPermisoPorCodigoTrabajador(sCodigoTrabajador);
            return dtLista;
        }
        #endregion

        #region insertar permiso
        public bool BLPMIPermiso(BC.VMPermiso svmPermiso)
        {
            return DaTemp.PIPermiso(svmPermiso);
        }
        #endregion

        #region eliminar permiso
        public bool BLPMDPermiso(string sCodigoPermiso)
        {
            return DaTemp.PDPermiso(sCodigoPermiso);
        }
        #endregion
    }
}
