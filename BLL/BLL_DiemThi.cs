using QuanLySinhVien.DAL;
using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    internal class BLL_DiemThi
    {
        DAL_DiemThi dalDiem = new DAL_DiemThi();
        public DataTable loadDiem()
        {
            return dalDiem.loadDiem();
        }
        public DataTable getData(string sql)
        {
            return dalDiem.getData(sql);
        }
        public bool themDiem(DTO_DiemThi diem)
        {
            return dalDiem.themDiem(diem);
        }
        public bool suaDiem(DTO_DiemThi diem)
        {
            return dalDiem.suaDiem(diem);
        }
        public bool xoaDiem(string maSV, string maMH, int lanThi)
        {
            return dalDiem.xoaDiem(maSV, maMH, lanThi);
        }
    }
}
