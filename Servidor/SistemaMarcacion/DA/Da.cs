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
        private SqlConnection cn = new SqlConnection("Data Source=.;Database=Login_1;Integrated Security=True");
        private SqlCommand cmd = new SqlCommand();

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

            dtTemp = Consulta("SelectUsuario",Campos,objetos);

            if(dtTemp.Rows.Count > 0)
            {
                tempUsuario.CodigoUsuario = int.Parse(dtTemp.Rows[0]["CodigoUsuario"].ToString());
                tempUsuario.Nombre = dtTemp.Rows[0]["Nombre"].ToString();
                tempUsuario.Clave = dtTemp.Rows[0]["Clave"].ToString();
            }

            return tempUsuario;
        }
        #endregion



        #region procedimiento para consulta
        private DataTable Consulta(string sNombreProc, string[] Campos, object[] Objetos)
        {
            DataTable dtLista = new DataTable();

            cmd.Connection = cn;
            cmd.CommandText = sNombreProc;

            for (int i = 0; i < Campos.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr;
            cn.Open();
            dr = cmd.ExecuteReader();
            dtLista.Load(dr);
            return dtLista;
            cn.Close();
        }
        #endregion

        #region procedimiento para insert, update o delete
        private bool IDU(string sNombreProc, string[] Campos, object[] Objetos)
        {
            cmd.Connection = cn;
            cmd.CommandText = sNombreProc;

            for (int i = 0; i < Campos.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@return", "false");
            cmd.Parameters["@return"].Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@return"].Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
            //return bool.Parse(cmd.Parameters["@return"].Value.ToString());
            cn.Close();
        }
        #endregion
    }
}
