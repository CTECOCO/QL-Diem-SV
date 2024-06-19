using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    internal class DTO_Lop
    {
        public string maLop { get; set; }
        public string tenLop { get; set; }
        public string maKhoa { get; set; }
        
        public DTO_Lop (string maLop, string tenLop, string maKhoa)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoa = maKhoa;
        }
    }
}
