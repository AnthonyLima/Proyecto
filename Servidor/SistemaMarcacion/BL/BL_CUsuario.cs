using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BL_CUsuario
    {
        DA.DAVCUsuarios DATemp = new DA.DAVCUsuarios();

        #region busqueda de usuario
        public BC.SCUsuarios BuscarUsuario(string sNombre, string sClave)
        {
            BC.SCUsuarios UserTemp = new BC.SCUsuarios();
            UserTemp = DATemp.BuscarUsuario(sNombre, sClave);
            return UserTemp;
        }
        #endregion

        public BC.SCUsuarios BusquedaUsuarioPorCodigo(int sCodigoUsuario)
        {
            BC.SCUsuarios UserTemp = new BC.SCUsuarios();
            UserTemp = DATemp.pcUsuarioPorCodigoUsuario(sCodigoUsuario);
            return UserTemp;
        }

        public bool CrearUsuario(string sNombreUsuario)
        {
            return DATemp.PICrearUsuario(sNombreUsuario);
        }
    }
}
