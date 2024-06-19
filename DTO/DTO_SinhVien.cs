using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    internal class DTO_SinhVien
    {
        public string maSV { get; set; }
        public string tenSV { get; set; }
        public string gioiTinh { get; set; }
        public string ngaySinh { get; set; }
        public string noiSinh { get; set; }
        public string maLop { get; set; }

        public DTO_SinhVien(string maSV, string tenSV, string gioiTinh, string ngaySinh, string noiSinh, string maLop)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.maLop = maLop;
        }
    }
}
