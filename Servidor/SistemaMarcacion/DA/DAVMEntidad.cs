using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DA
{
    public class DAVMEntidad
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        public DataTable PCEntidadPorDocumentoIdentidad(string sDocumentoIdentidad)
        {
            DataTable dTabla = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "DocumentoIdentidad";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sDocumentoIdentidad;

            dTabla = Conect.Consulta("MPCEntidadPorDocumentoIdentidad", Campos, Objetos);

            return dTabla;
        }

        public bool PIEntidad(BC.VMEntidad sVMEntidad)
        {
            bool temp = false;

            int Cantidad = 6;
            string[] Campos = new string[Cantidad];
            Campos[0] = "DocumentoIdentidad";
            Campos[1] = "Nombre";
            Campos[2] = "ApellidoPaterno";
            Campos[3] = "ApellidoMaterno";
            Campos[4] = "Telefono";
            Campos[5] = "Email";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMEntidad.DocumentoIdentidad;
            Objetos[1] = sVMEntidad.Nombres;
            Objetos[2] = sVMEntidad.ApellidoPaterno;
            Objetos[3] = sVMEntidad.ApellidoMaterno;
            Objetos[4] = sVMEntidad.Telefono;
            Objetos[5] = sVMEntidad.Email;

            temp = Conect.IDU("MPIEntidad", Campos, Objetos);

            return temp;
        }

        public bool PUEntidad(BC.VMEntidad sVMEntidad)
        {
            bool temp = false;

            int Cantidad = 6;
            string[] Campos = new string[Cantidad];
            Campos[0] = "DocumentoIdentidad";
            Campos[1] = "Nombre";
            Campos[2] = "ApellidoPaterno";
            Campos[3] = "ApellidoMaterno";
            Campos[4] = "Telefono";
            Campos[5] = "Email";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sVMEntidad.DocumentoIdentidad;
            Objetos[1] = sVMEntidad.Nombres;
            Objetos[2] = sVMEntidad.ApellidoPaterno;
            Objetos[3] = sVMEntidad.ApellidoMaterno;
            Objetos[4] = sVMEntidad.Telefono;
            Objetos[5] = sVMEntidad.Email;

            temp = Conect.IDU("MPUEntidad", Campos, Objetos);

            return temp;
        }

        public bool PDEntidad(string sDocumentoIdentidad)
        {
            bool temp = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "DocumentoIdentidad";
            object[] Objetos = new object[Cantidad];
            Objetos[0] = sDocumentoIdentidad;

            temp = Conect.IDU("MPDEntidad", Campos, Objetos);

            return temp;
        }
    }
}
