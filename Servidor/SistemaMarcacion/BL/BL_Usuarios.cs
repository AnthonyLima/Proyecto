﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BL_Usuarios
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
    }
}
