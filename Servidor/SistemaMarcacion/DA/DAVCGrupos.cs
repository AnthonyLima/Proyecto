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

        public DataTable PCGrupo(int sCodigoGrupo)
        {
            DataTable dtTemp = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoGrupos";
            object[] objetos = new object[Cantidad];
            objetos[0] = sCodigoGrupo;

            dtTemp = Conect.Consulta("PCCGrupos", Campos, objetos);

            
            return dtTemp;
        }

        public bool pcIGrupo(string sNombre)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Nombre";
            object[] objetos = new object[Cantidad];
            objetos[0] = sNombre;

            temp = Conect.IDU("PCIGrupo", Campos, objetos);

            return temp;
        }

    }
}
