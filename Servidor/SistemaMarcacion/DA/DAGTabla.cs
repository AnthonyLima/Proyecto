using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class DAGTabla
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        public bool IngresoGTabla(string sTabla,string sCadena)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Tabla";
            Campos[1] = "Cadena";
            object[] objetos = new object[Cantidad];
            objetos[0] = sTabla;
            objetos[1] = sCadena;

            temp = Conect.IDU("PITabla", Campos, objetos);

            return temp;
        }

        public bool ActualizarGTabla(string sTabla,string sCodigo,string sCadena)
        {
            bool temp = false;

            int Cantidad = 3;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Tabla";
            Campos[1] = "Codigo";
            Campos[2] = "Cadena";
            object[] objetos = new object[Cantidad];
            objetos[0] = sTabla;
            objetos[1] = sCodigo;
            objetos[2] = sCadena;

            temp = Conect.IDU("PUTabla", Campos, objetos);

            return temp;
        }

        public bool EliminarGTabla(string sTabla, string sCodigo)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Tabla";
            Campos[1] = "Codigo";
            object[] objetos = new object[Cantidad];
            objetos[0] = sTabla;
            objetos[1] = sCodigo;

            temp = Conect.IDU("PDTabla", Campos, objetos);

            return temp;
        }
    }
}
