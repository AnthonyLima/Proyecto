using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BGlobal
{
    public class Global
    {
        private SqlConnection cn = new SqlConnection("Data Source=.;Database=Login_1;Integrated Security=True");
        private SqlCommand cmd = new SqlCommand();

        #region procedimiento para consulta
        public DataTable Consulta(string sNombreProc, string[] Campos, object[] Objetos)
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
            cn.Close();
            return dtLista;
            //cn.Close();
        }
        #endregion

        #region procedimiento para insert, update o delete
        public bool IDU(string sNombreProc, string[] Campos, object[] Objetos)
        {
            cmd.Connection = cn;
            cmd.CommandText = sNombreProc;

            for (int i = 0; i < Campos.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            //parametro agregado cuando se realiza el insert, update o delete par averificar que se completo la accion o no
            //se puede agregar el usuario a futuro pero este dato no retornara
            cmd.Parameters.AddWithValue("@return", 1);
            cmd.Parameters["@return"].Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@return"].Value.ToString() == "1")
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }
            //return bool.Parse(cmd.Parameters["@return"].Value.ToString());
            //cn.Close();
        }
        #endregion
    }
}
