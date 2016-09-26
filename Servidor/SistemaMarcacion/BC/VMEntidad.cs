using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BC
{
    public class VMEntidad
    {
        private string _DocumentoIdentidad;
        private string _Nombres;
        private string _ApellidoPaterno;
        private string _ApellidoMaterno;
        private string _Telefono;
        private string _Email;

        public string DocumentoIdentidad { get { return _DocumentoIdentidad; } set { _DocumentoIdentidad = value; } }
        public string Nombres { get { return _Nombres; } set { _Nombres = value; } }
        public string ApellidoPaterno { get { return _ApellidoPaterno; } set { _ApellidoPaterno = value; } }
        public string ApellidoMaterno { get { return _ApellidoMaterno; } set { _ApellidoMaterno = value; } }
        public string Telefono { get { return _Telefono; } set { _Telefono = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }

        public VMEntidad()
        {
            DocumentoIdentidad = string.Empty;
            Nombres = string.Empty;
            ApellidoPaterno = string.Empty;
            ApellidoMaterno = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
        }
    }
}
