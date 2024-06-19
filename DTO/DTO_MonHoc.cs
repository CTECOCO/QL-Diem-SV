using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    internal class DTO_MonHoc
    {
        public string maMH { get; set; }
        public string tenMH { get; set; }
        public int soTiet { get; set; }
        public DTO_MonHoc(string maMH, string tenMH, int soTiet)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTiet = soTiet;
        }
    }
}
