using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class Da
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        #region busqueda del usuario por nombre y clave
        public BC.SCUsuarios BuscarUsuario(string sNombre, string sClave)
        {
            BC.SCUsuarios tempUsuario = new BC.SCUsuarios();
            DataTable dtTemp = new DataTable();

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Nombre";
            Campos[1] = "Clave";
            object[] objetos = new object[Cantidad];
            objetos[0] = sNombre;
            objetos[1] = sClave;

            dtTemp = Conect.Consulta("SelectUsuario",Campos,objetos);

            if(dtTemp.Rows.Count > 0)
            {
                tempUsuario.CodigoUsuario = int.Parse(dtTemp.Rows[0]["CodigoUsuarios"].ToString());
                tempUsuario.Nombre = dtTemp.Rows[0]["Nombre"].ToString();
                tempUsuario.Clave = dtTemp.Rows[0]["Clave"].ToString();
            }

            return tempUsuario;
        }
        #endregion
    }
}
