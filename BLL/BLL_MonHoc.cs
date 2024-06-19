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
    internal class BLL_MonHoc
    {
        DAL_MonHoc dalMH = new DAL_MonHoc();
        public DataTable loadMH()
        {
            return dalMH.loadMonHoc();
        }
        public DataTable getData(string sql)
        {
            return dalMH.getData(sql);
        }
        public bool themMH(DTO_MonHoc mh)
        {
            return dalMH.themMonHoc(mh);
        }
        public bool suaMH(DTO_MonHoc mh)
        {
            return dalMH.suaMonHoc(mh);
        }
        public bool xoaMH(string maMH)
        {
            return dalMH.xoaMonHoc(maMH);
        }
    }
}
