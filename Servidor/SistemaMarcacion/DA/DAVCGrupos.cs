using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVCGrupos
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        private BC.SCGrupos BuscarGrupo(int sCodigoGrupo)
        {
            BC.SCGrupos tempGrupo = new BC.SCGrupos();
            DataTable dtTemp = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoGrupos";
            object[] objetos = new object[Cantidad];
            objetos[0] = sCodigoGrupo;

            dtTemp = Conect.Consulta("SelectUsuario", Campos, objetos);

            if (dtTemp.Rows.Count > 0)
            {
                tempGrupo.CodigoGrupo = int.Parse(dtTemp.Rows[0]["CodigoUsuario"].ToString());
                tempGrupo.Nombre = dtTemp.Rows[1]["Npmbre"].ToString();
            }
            return tempGrupo;
        }

    }
}
