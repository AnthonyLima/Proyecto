using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class DAVCUsuarios
    {
        private BGlobal.Global Conect = new BGlobal.Global();

        #region Encontrar Grupo Del Usuario
        public BC.SCGrupos pcGrupoDelUsuario(int sCodigoUsuario)
        {
            BC.SCGrupos tempGrupo = new BC.SCGrupos();
            DataTable dtTemp = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoUsuario";
            object[] objetos = new object[Cantidad];
            objetos[0] = sCodigoUsuario;

            dtTemp = Conect.Consulta("PCCUsuarioPorNombreYClave", Campos, objetos);

            if (dtTemp.Rows.Count > 0)
            {
                tempGrupo.CodigoGrupo = int.Parse(dtTemp.Rows[0]["CodigoGrupo"].ToString());
                tempGrupo.Nombre = dtTemp.Rows[0]["Nombre"].ToString();
            }
            return tempGrupo;
        }
        #endregion

        #region Buscar usuario por nombre y usuario
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

            dtTemp = Conect.Consulta("PCCUsuarioPorNombreYClave", Campos, objetos);

            if (dtTemp.Rows.Count > 0)
            {
                tempUsuario.CodigoUsuarios = int.Parse(dtTemp.Rows[0]["CodigoUsuarios"].ToString());
                tempUsuario.Nombre = dtTemp.Rows[0]["Nombre"].ToString();
                tempUsuario.Clave = dtTemp.Rows[0]["Clave"].ToString();
            }
            return tempUsuario;
        }
        #endregion

        #region Buscar usuario por codigo usuarios
        public BC.SCUsuarios pcUsuarioPorCodigoUsuario(int sCodigoUsuario)
        {
            BC.SCUsuarios tempUsuario = new BC.SCUsuarios();
            DataTable dtTemp = new DataTable();

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "CodigoUsuarios";
            object[] objetos = new object[Cantidad];
            objetos[0] = sCodigoUsuario;

            dtTemp = Conect.Consulta("PCCUsuarioPorCodigoUsuario", Campos, objetos);

            if (dtTemp.Rows.Count > 0)
            {
                tempUsuario.CodigoUsuarios = int.Parse(dtTemp.Rows[0]["CodigoUsuarios"].ToString());
                tempUsuario.Nombre = dtTemp.Rows[0]["Nombre"].ToString();
                tempUsuario.Clave = dtTemp.Rows[0]["Clave"].ToString();
            }
            return tempUsuario;
        }
        #endregion

        #region CrearUsuario
        public bool PICrearUsuario(string sNombreUsuario)
        {
            bool estado = false;

            int Cantidad = 1;
            string[] Campos = new string[Cantidad];
            Campos[0] = "Nombre";
            object[] objetos = new object[Cantidad];
            objetos[0] = sNombreUsuario;

            estado = Conect.IDU("PCIUsuario", Campos, objetos);

            return estado;
        }
        #endregion
    }
}
