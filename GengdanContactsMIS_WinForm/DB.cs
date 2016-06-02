using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.OleDb;

namespace GengdanContactsMIS_WinForm
{
    class DB
    {
        public static string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        //执行增加、修改、删除Sql语句
        public  bool ExecuteSQL(string sql)
        {
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public OleDbDataReader GetReader(string sql)
        {
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                con.Dispose();
                cmd.Dispose();
                throw new Exception(ex.ToString());
            }
            return reader;
        }

        public DataSet GetDataSet(string sql, string tablename)
        {
            DataSet ds = new DataSet();
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, strConn);
            try
            {
                da.Fill(ds, tablename);                               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
                da.Dispose();
            }
            return ds;            
        }
        public static int GetCount(string sql)
        {
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public static string GetOneString(string sql)
        {
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                string Name = (string)cmd.ExecuteScalar();
                return Name;
            }
            catch
            {
                return "";
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }

       
    }
}
