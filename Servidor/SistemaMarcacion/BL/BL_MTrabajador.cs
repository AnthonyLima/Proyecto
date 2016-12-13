using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BL
{
    public class BL_MTrabajador
    {
        DA.DAVMTrabajador DaTemp = new DA.DAVMTrabajador();

        #region Busqueda un Trabajador
        public BC.VMTrabajador BLPMCTrabajadorPorCodigoTrabajador(int sCodigoTrabajador)
        {
            BC.VMTrabajador Temp = new BC.VMTrabajador();
            DataTable dtTemp = new DataTable();
            dtTemp = DaTemp.PCTrabajadorPorCodigoTrabajador(sCodigoTrabajador);
            if (dtTemp.Rows.Count > 0)
            {
                Temp.CodigoTrabajador = int.Parse(dtTemp.Rows[0]["CodigoTrabajador"].ToString());
                Temp.CodigoCategoria = dtTemp.Rows[0]["CodigoCategoria"].ToString();
                Temp.CodigoCargo = dtTemp.Rows[0]["CodigoCargo"].ToString();
                Temp.CodigoArea = dtTemp.Rows[0]["CodigoArea"].ToString();
                Temp.DNI = dtTemp.Rows[0]["DNI"].ToString();
                Temp.FechaIngreso = DateTime.Parse(dtTemp.Rows[0]["FechaIngreso"].ToString());
            }
            return Temp;
        }
        #endregion

        #region Insertar Trabajador
        public bool BLPMITrabajador(BC.VMTrabajador svmTrabajador)
        {
            return DaTemp.PITrabajador(svmTrabajador);
        }
        #endregion

        #region Update Trabajador
        public bool BLPMUTrabajador(BC.VMTrabajador svmTrabajador)
        {
            return DaTemp.PUTrabajador(svmTrabajador);
        }
        #endregion

        #region Eliminar Trabajador
        public bool BLPMDTrabajador(int sCodigoTrabajador)
        {
            return DaTemp.PDTrabajador(sCodigoTrabajador);
        }
        #endregion

    }
}
