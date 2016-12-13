using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BL
{
    public class BL_CGrupo
    {
        DA.DAVCGrupos DaTemp = new DA.DAVCGrupos();

        #region Buscar un grupo
        public BC.SCGrupos BLPCUnGrupo(int sCodigoGrupo)
        {
            BC.SCGrupos temp = new BC.SCGrupos();
            DataTable dtTemp = new DataTable();
            dtTemp = DaTemp.PCGrupo(sCodigoGrupo);

            if (dtTemp.Rows.Count > 0)
            {
                temp.CodigoGrupo = int.Parse(dtTemp.Rows[0]["CodigoUsuario"].ToString());
                temp.Nombre = dtTemp.Rows[1]["Npmbre"].ToString();
            }
            return temp;
        }
        #endregion

        #region Buscar Todos los grupos
        public DataTable BlPCGrupoTodos()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = DaTemp.PCGrupo(0);
            return dtTemp;
        }
        #endregion

        #region ingresar usuario
        public bool pcIGrupo(string sNombre)
        {
            return DaTemp.pcIGrupo(sNombre);
        }
        #endregion
    }
}
