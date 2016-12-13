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
        private SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Login_1;Integrated Security=SSPI");
        private SqlCommand cmd = new SqlCommand();

        #region procedimiento para consulta
        public DataTable Consulta(string sNombreProc, string[] Campos, object[] Objetos)
        {
            DataTable dtLista = new DataTable();
            SqlDataReader dr;
            //---------------------------------------------
            using (cn)
            {
                cmd.Connection = cn;
                cmd.CommandText = sNombreProc;

                //SqlTransaction tran = cn.BeginTransaction();
                try
                {
                    for (int i = 0; i < Objetos.Length; i++)
                    {
                        string dato = Campos[i];
                        cmd.Parameters.AddWithValue(dato, Objetos[i]);
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dtLista.Load(dr);
                    cn.Close();
                    return dtLista;
                    
                }
                catch (Exception)
                {
                    dtLista = new DataTable();
                    throw;
                }
            } 
                //---------------------------------------------
            //    cmd.Connection = cn;
            //cmd.CommandText = sNombreProc;

            //for (int i = 0; i < Campos.Length; i++)
            //{
            //    cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
            //}
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //SqlDataReader dr;
            //cn.Open();
            //dr = cmd.ExecuteReader();
            //dtLista.Load(dr);
            //cn.Close();
            //return dtLista;
            ////cn.Close();
        }
        #endregion

        #region procedimiento para insert, update o delete
        public bool IDU(string sNombreProc, string[] Campos, object[] Objetos)
        {
            try
            {
                object Retorno = new object();
                cmd.Connection = cn;
                cmd.CommandText = sNombreProc.Trim();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                for (int i = 0; i < Objetos.Length; i++)
                {
                    string dato = Campos[i];
                    cmd.Parameters.AddWithValue(dato, Objetos[i]);
                }
                cmd.Parameters.Add("@Return", SqlDbType.Bit);
                cmd.Parameters["@Return"].Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                return bool.Parse(cmd.Parameters["@Return"].Value.ToString());
            }
            catch(SqlException exsql)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            

        }
        #endregion
    }
}
