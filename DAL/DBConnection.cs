using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class DBConnection
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NRA0KSQ;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True");

        public DataTable getData(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int excute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}
