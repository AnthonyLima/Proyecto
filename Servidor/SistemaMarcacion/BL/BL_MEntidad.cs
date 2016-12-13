using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BL
{
    public class BL_MEntidad
    {
        DA.DAVMEntidad DaTemp = new DA.DAVMEntidad();

        public BC.VMEntidad BLPMIEntidadSoloUno(string sDocumentoIdentidad)
        {
            BC.VMEntidad temp = new BC.VMEntidad();
            DataTable dtLista = new DataTable();
            dtLista = DaTemp.PCEntidadPorDocumentoIdentidad(sDocumentoIdentidad);
            if (dtLista.Rows.Count > 0)
            {
                temp.DocumentoIdentidad = dtLista.Rows[0]["Documentoidentidad"].ToString();
                temp.ApellidoPaterno = dtLista.Rows[0]["ApellidoPaterno"].ToString();
                temp.ApellidoMaterno = dtLista.Rows[0]["ApellidoMaterno"].ToString();
                temp.Nombres = dtLista.Rows[0]["Nombres"].ToString();
                temp.Telefono = dtLista.Rows[0]["Telefono"].ToString();
                temp.Email = dtLista.Rows[0]["Email"].ToString();
                temp.FechaIngreso = DateTime.Parse(dtLista.Rows[0]["FechaIngreso"].ToString());
            }
            return temp;
        }

        #region insertar entidad
        public bool BLPMIEntidad(BC.VMEntidad svmEntidad)
        {
            return DaTemp.PIEntidad(svmEntidad);
        }
        #endregion

        #region actualizar entidad
        public bool BLPMUEntidad(BC.VMEntidad svmEntidad)
        {
            return DaTemp.PUEntidad(svmEntidad);
        }
        #endregion

        #region eliminar Entidad
        public bool BLPMDEntidad(string sDocumentoIdentidad)
        {
            return DaTemp.PDEntidad(sDocumentoIdentidad);
        }
        #endregion
    }
}
