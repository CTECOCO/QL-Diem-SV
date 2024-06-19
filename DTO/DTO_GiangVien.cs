using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    internal class DTO_GiangVien
    {
        public string maGV { get; set; }
        public string tenGV { get; set; }
        public string chuyenNganh { get; set; }
        public string maKhoa { get; set; }

        public DTO_GiangVien (string maGV, string tenGV, string chuyenNganh, string maKhoa)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.chuyenNganh = chuyenNganh;
            this.maKhoa = maKhoa;
        }
    }
}
