using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    internal class DTO_Khoa
    {
        public string maKhoa { get; set; }
        public string tenKhoa { get; set; }

        public DTO_Khoa(string maKhoa, string tenKhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
        }
    }
}
