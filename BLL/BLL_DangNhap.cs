using QuanLySinhVien.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    internal class BLL_DangNhap
    {
        DAL_DangNhap dalDangNhap = new DAL_DangNhap();
        public DataTable getData(string sql)
        {
            return dalDangNhap.getData(sql);
        }
    }
}
