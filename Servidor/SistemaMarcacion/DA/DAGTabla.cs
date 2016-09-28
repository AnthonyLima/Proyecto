using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAGTabla
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        public DataTable PCGTabla(string sTabla)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Tabla";
            object[] objetos = new object[Cantidad];
            objetos[0] = sTabla;

            dTabla = Conect.Consulta("MPCGTabla", Campos, objetos);

            return dTabla;
        }

        public bool PIGTabla(string sTabla,string sCadena)
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Tabla";
            Campos[1] = "Cadena";
            object[] objetos = new object[Cantidad];
            objetos[0] = sTabla;
            objetos[1] = sCadena;

            temp = Conect.IDU("MPITabla", Campos, objetos);

            return temp;
        }

        public bool PUGTabla(string sTabla,string sCodigo,string sCadena)
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

            temp = Conect.IDU("MPUTabla", Campos, objetos);

            return temp;
        }

        public bool PDGTabla(string sTabla, string sCodigo = "")
        {
            bool temp = false;

            int Cantidad = 2;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Tabla";
            Campos[1] = "Codigo";
            object[] objetos = new object[Cantidad];
            objetos[0] = sTabla;
            objetos[1] = sCodigo;

            temp = Conect.IDU("MPDTabla", Campos, objetos);

            return temp;
        }
    }
}
