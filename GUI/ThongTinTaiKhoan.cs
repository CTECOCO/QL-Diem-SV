using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan(string tenDangNhap, string matKhau, string hoTen)
        {
            InitializeComponent();
            txtTDN.Text = tenDangNhap;
            txtMK.Text = matKhau;
            txtHoTen.Text = hoTen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
