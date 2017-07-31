using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bài_tập_lớn
{
    public class Ketnoi
    {
        protected string tv_connectionString;
        protected SqlConnection connection;
        protected SqlDataAdapter da = null;
        protected SqlCommand cmd;
        //phuong thuc
        public Ketnoi()
        {
            tv_connectionString = @"Data Source=FUJITSU;Initial Catalog=QLTHUVIEN;Integrated Security=True";
        }
        //Ket noi
        public void connect()
        {
                connection = new SqlConnection(tv_connectionString);
                connection.Open();
        }
        //Tat ket noi
        public void disconnect()
        {
                connection.Close();
        }
      //Lay du lieu ra table
        public DataTable Taobang(string sql)
        {
            connect();  
            da = new SqlDataAdapter(sql,connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disconnect();
            return dt;
        }
        //dung cho cac thao tac them, sua, xoa
        public void ExcuteNonQuery(string sql)
        {
            connect();
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            disconnect();
        }
        //lay 1 gia tri du lieu ra
        public object executeScalar(string sql)
        {
            connect();
            cmd = new SqlCommand(sql, connection);
            object a = cmd.ExecuteScalar();
            disconnect();
            return a;
        }
       
    }
}
