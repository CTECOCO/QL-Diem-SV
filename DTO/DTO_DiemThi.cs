using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    internal class DTO_DiemThi
    {
        public string maSV { get; set; }
        public string maMH { get; set; }
        public int lanThi { get; set; }
        public double diemThi { get; set; }
        public DTO_DiemThi(string maSV, string maMH, int lanThi, double diemThi)
        {
            this.maSV = maSV;
            this.maMH = maMH;
            this.lanThi = lanThi;
            this.diemThi = diemThi;
        }
    }
}
