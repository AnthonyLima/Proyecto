using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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

        public DataTable BLPCUsuarioTodos()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = DATemp.pcUsuarios(0);
            return dtTemp;
        }

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
