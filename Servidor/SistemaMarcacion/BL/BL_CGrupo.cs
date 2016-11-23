using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BL_CGrupo
    {
        DA.DAVCGrupos DaTemp = new DA.DAVCGrupos();

        #region Buscar Grupo
        public BC.SCGrupos BuscarGrupo(int sCodigoGrupo)
        {
            BC.SCGrupos temp = new BC.SCGrupos();
            temp = DaTemp.BuscarGrupo(sCodigoGrupo);
            return temp;
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
