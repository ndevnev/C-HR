using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Common
{
    public class DatabaseHelper
    {
        static SqlConnection con = new SqlConnection();
        //Hàm tạo kết nối
        public static void taoKetNoi()
        {
            //Cấu trúc chuỗi kết nối đến CSDL SQLServer
            con.ConnectionString = "Data Source = .; Initial Catalog = QUANLYNHANSU; User ID= sa; Password=sa;";
            try
            {
                con.Open();//Mở kết nối đến CSDL
            }
            catch (Exception)
            {
                throw;
            }
        }
        //hàm đóng kết nối
        public static void dongKetNoi()
        {
            con.Close();
        }
        //Hàm đổ dữ liệu vào datable
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }
        //Hàm lấy dữ liệu bằng Dataset
        public static DataSet getDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static void execQuery(string qr)
        {
            taoKetNoi();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }
    }
}
