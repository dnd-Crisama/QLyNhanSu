using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.Sql;

using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
namespace QLyNhanSu.DAL
{
    internal class DataAccess
    {
        public static DataAccess ac = new DataAccess();
        public static DataAccess dt = new DataAccess();

        public SqlConnection cn;
        public SqlCommand cmd;

        public static string chuoi = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public string chuoiketnoipublic = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static SqlConnection getConnect()
        {
            string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            return cn;
        }
        public SqlConnection getConnectPublic() 
        {
            string strcon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection();
            cn.Open();
            return cn;
        }
        public void closeConnect ()
        {
            SqlConnection cn = new SqlConnection();
            cn.Close();
        }
        public DataTable GetDataTable_Text(String query)
        {
            try
            {
                cn = getConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                DataTable result = new DataTable();
                SqlDataAdapter dapter = new SqlDataAdapter();

                dapter.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }
        }
        public DataTable GetDataTable_Store(string query)
        {
            try
            {
                cn = getConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                DataTable result = new DataTable();
                SqlDataAdapter dapter = new SqlDataAdapter();

                dapter.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }
        }
        public DataTable GetDataTable_Store_Paramater (string TenStoreProcedure, SqlParameter[] sqlParam)
        {
            DataTable dtbTmp = new DataTable();
            try
            {
                cn = getConnect();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandTimeout = 2000;
                sqlCmd.Connection = cn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = TenStoreProcedure;
                for (int i = 0; i < sqlParam.Length; i++)
                {
                    sqlCmd.Parameters.Add(sqlParam[i]);
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = sqlCmd;
                sqlDA.Fill(dtbTmp);
                closeConnect();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }
            return dtbTmp;
        }
        public int ExecuteCommandtext (string query)
        {
            int returnValue = -1;
            try
            {
                cn = getConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                // return cmd.ExecuteNonQuery();
                // return (int)cmd.ExecuteScalar();
                object returnObj = cmd.ExecuteScalar();
                int.TryParse(returnObj.ToString(), out returnValue);
                return returnValue;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }
        }
        public string ExecuteScalar (string sql)
        {
            SqlConnection con = getConnect();
            SqlCommand cmd = new SqlCommand(sql,con);
            string kq = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }
        public SqlDataReader ExecuteReader (string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
            cmd.Dispose();

            return dr;
        }
        public Boolean kiemtra_dangnhap (string tenbang, string user, string pass, string tb_user, string tb_pass)
        {
            int c = 0;
            string sql = "select count(*) from " + tenbang + " where " + tb_user + "= '" + user + "' and " + tb_pass + " = '" + pass + "' ";
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn = getConnect();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                c = (int)cmd.ExecuteScalar();
                cn.Close();
                cmd.Dispose();
            }
            catch 
            {
                return false;
            }
            finally
            {
                cn.Close();
                cmd.Dispose() ;
            }
            return (c != 0);
        }
        public Boolean check_tontai (string tenbang, string tentruong, string giatri)
        {
            int c = 0;
            string sql = "select count(*) from " + tenbang + " where " + tentruong + " = '" + giatri + "' ";
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn = getConnect();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                c = (int)cmd.ExecuteScalar();
                cn.Close();
                cmd.Dispose();
            }
            catch
            { 
                return false; 
            }
            finally 
            { 
                cn.Close();
                cmd.Dispose();
            }
            return (c != 0);
        }
        public string Lay_GiaTri_Tubang(string tenbang, string tentruong, string giatri, string cot)
        {
            string connection = ac.chuoiketnoipublic;
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string finddata = "select * from " + tenbang + " where " + tentruong + " = '" + giatri + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;
            cmd.CommandText= finddata;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(finddata,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string kq;
            kq = ds.Tables[0].Rows[0][cot].ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public DataTable Load_Theo_ma(string tenstore, string ma)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para =
            {
                new SqlParameter("@ma",ma),
            };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, int ma)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para =
            {
                new SqlParameter("@ma",ma),
            };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, int ma, int ma2)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para =
            {
                new SqlParameter("@ma",ma),
                new SqlParameter ("@ma2",ma2)
            };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma (string tenstore, int ma, string ma2)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para =
            {
                new SqlParameter("@ma",ma),
                new SqlParameter ("@ma2",ma2)
            };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, string ma, string ma2)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para =
            {
                new SqlParameter("@ma",ma),
                new SqlParameter ("@ma2",ma2)
            };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_Theo_ma(string tenstore, string ma1, string ma2,string ma3)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para =
            {
                new SqlParameter("@ma",ma1),
                new SqlParameter ("@ma2",ma2),
                new SqlParameter ("@ma3",ma3)
            };
            dt = ac.GetDataTable_Store_Paramater(tenstore, para);
            return dt;
        }
        public DataTable Load_store (string tenstore)
        {
            DataTable dt = new DataTable ();
            dt = ac.GetDataTable_Store(tenstore);
            return dt;
        }
    }
}
