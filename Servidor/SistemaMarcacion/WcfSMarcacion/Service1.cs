using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WcfSMarcacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public BC.SCUsuarios BusquedaDeUsuario(string sNombre, string sClave)
        {
            BL.BL_CUsuario BLUserTemp = new BL.BL_CUsuario();
            return BLUserTemp.BuscarUsuario(sNombre, sClave);
        }

        public BC.SCUsuarios BuscarUsuarioPorCodigoUsuario(int sCodigoUsuario)
        {
            BL.BL_CUsuario BLUserTemp = new BL.BL_CUsuario();
            return BLUserTemp.BusquedaUsuarioPorCodigo(sCodigoUsuario);
        }

        public bool CrearUsuario(string sNombreUsuario)
        {
            BL.BL_CUsuario BLUserTemp = new BL.BL_CUsuario();
            return BLUserTemp.CrearUsuario(sNombreUsuario);
        }

        public DataSet BuscarTodosUsuarios()
        {
            BL.BL_CUsuario blUserTemp = new BL.BL_CUsuario();
            DataSet dsTemp = new DataSet();
            DataTable dtTabla = new DataTable();

            dtTabla = blUserTemp.BLPCUsuarioTodos();
            dsTemp.Tables.Add(dtTabla);

            return dsTemp;
        }

        #region procesos de grupo
        public BC.SCGrupos BuscarUnGrupo(int sCodigoGrupos)
        {
            BL.BL_CGrupo BLGrupoTemp = new BL.BL_CGrupo();
            return BLGrupoTemp.BLPCUnGrupo(sCodigoGrupos);
        }


        public DataSet BuscarTodosGrupo()
        {
            BL.BL_CGrupo BlGrupoTemp = new BL.BL_CGrupo();

            DataSet dsTemp = new DataSet();
            DataTable dtTabla = new DataTable();
            dtTabla = BlGrupoTemp.BlPCGrupoTodos();
            dsTemp.Tables.Add(dtTabla);

            return dsTemp;
        }
        #endregion
    }
}
