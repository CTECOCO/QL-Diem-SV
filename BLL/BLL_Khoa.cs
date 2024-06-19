using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DAL;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.BLL
{
    internal class BLL_Khoa
    {
        DAL_Khoa dalKhoa = new DAL_Khoa();
        public DataTable loadKhoa()
        {
            return dalKhoa.loadKhoa();
        }
        public DataTable getData(string sql)
        {
            return dalKhoa.getData(sql);
        }
        public bool themKhoa(DTO_Khoa khoa)
        {
            return dalKhoa.themKhoa(khoa);
        }
        public bool suaKhoa(DTO_Khoa khoa)
        {
            return dalKhoa.suaKhoa(khoa);
        }
        public bool xoaKhoa(string maKhoa)
        {
            return dalKhoa.xoaKhoa(maKhoa);
        }
    }
}
