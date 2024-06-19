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
    internal class BLL_Lop
    {
        DAL_Lop dalLop = new DAL_Lop();
        public DataTable loadLop()
        {
            return dalLop.loadLop();
        }
        public DataTable getData(string sql)
        {
            return dalLop.getData(sql);
        }
        public bool themLop(DTO_Lop lop)
        {
            return dalLop.themLop(lop);
        }
        public bool suaLop(DTO_Lop lop)
        {
            return dalLop.suaLop(lop);
        }
        public bool xoaLop(string maLop)
        {
            return dalLop.xoaLop(maLop);
        }
    }
}
