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
    internal class BLL_GiangVien
    {
        DAL_GiangVien dalGV = new DAL_GiangVien();
        public DataTable loadGV()
        {
            return dalGV.loadGV();
        }
        public DataTable getData(string sql)
        {
            return dalGV.getData(sql);
        }
        public bool themGV(DTO_GiangVien gv)
        {
            return dalGV.themGV(gv);
        }
        public bool suaGV(DTO_GiangVien gv)
        {
            return dalGV.suaGV(gv);
        }
        public bool xoaGV(string maGV)
        {
            return dalGV.xoaGV(maGV);
        }
    }
}
