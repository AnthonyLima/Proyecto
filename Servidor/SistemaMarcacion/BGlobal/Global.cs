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
            SqlDataReader dr;
            //---------------------------------------------
            using (cn)
            {
                cmd.Connection = cn;
                cmd.CommandText = sNombreProc;
                
                SqlTransaction tran = cn.BeginTransaction();
                try
                {
                    for (int i = 0; i < Campos.Length; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dtLista.Load(dr);
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
            cmd.Connection = cn;
            cmd.CommandText = sNombreProc;

            //-----------------------------------------------
            //using (cn)
            //{
            //    cmd.Connection = cn;
            //    cmd.CommandText = sNombreProc;

            //    SqlTransaction tran = cn.BeginTransaction();

            //    cmd.Transaction = tran;

            //    try
            //    {
            //        for (int i = 0; i < Campos.Length; i++)
            //        {
            //            cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
            //        }
            //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //        cn.Open();

            //        cmd.Parameters.AddWithValue("@return", "1");
            //        cmd.Parameters["@return"].Direction = System.Data.ParameterDirection.ReturnValue;
            //        cmd.ExecuteNonQuery();

            //        tran.Commit();
            //        return System.Data.ParameterDirection.ReturnValue.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        return ex.Message;
            //        throw;
            //    }
            //    //se podria cambiar a string para mostrar cuando tenga datos y cuando no tenga estara en blanco el error
            //    //esto solo se utilizara en las operaiones de insert,update,delete
            //}
            //-----------------------------------------------

            for (int i = 0; i < Campos.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + Campos[i], Objetos[i]);
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            //parametro agregado cuando se realiza el insert, update o delete par averificar que se completo la accion o no
            //se puede agregar el usuario a futuro pero este dato no retornara
            cmd.Parameters.AddWithValue("@return", 1);
            cmd.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
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
