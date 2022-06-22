using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYXETNGHIEM.DAL
{
    public static class MySQLConnection
    {
        /// <summary>
        /// Đọc dữ liệu lấy về một DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable excuteQuery(String query)
        {
            SqlDataAdapter dtAd = new SqlDataAdapter(query, MySQLConnection.GetSqlLisConnection());
            DataTable tb = new DataTable();
            try
            {
                dtAd.Fill(tb);
            }
            catch
            {}
            return tb;
        }
        /// <summary>
        /// Cập nhật dữ liệu và trả về số bản ghi đã được cập nhật
        /// </summary>
        /// <param name="query">Câu lệnh update hoặc insert</param>
        /// <returns></returns>
        public static int excuteUpdate(String query)
        {
            SqlCommand sqlcom = new SqlCommand(query, MySQLConnection.GetSqlLisConnection());
            int kt = 0;
            try
            {
                kt = sqlcom.ExecuteNonQuery();
            }
            catch
            {}
            return kt;

        }
        /// <summary>
        /// Tạo kế nối máy chủ không thông qua ODBC - ADD BY THANGVT
        /// </summary>
        /// <param name="servername">Tên máy chủ hoặc IP</param>
        /// <param name="database">Tên cơ sở dữ liệu</param>
        /// <returns></returns>
        public static SqlConnection GetSqlLisConnection()
        {
            String host = "118.70.81.222";
            String username = "qlxn";
            String password = "123456";
            String database = "QLXN";
            SqlConnection connection = new SqlConnection("Data Source=" + host + ";Initial Catalog=" + database + ";User ID="+ username + ";Password="+ password);
            openConnection(connection);
            return connection;
        }
        /// <summary>
        /// Mở kế nối nếu đang đóng
        /// </summary>
        /// <returns></returns>
        public static SqlConnection openConnection(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }
    }
}
