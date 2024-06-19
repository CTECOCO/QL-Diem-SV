using QuanLySinhVien.BLL;
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
    public partial class DangNhap : Form
    {
        BLL_DangNhap bllDangNhap = new BLL_DangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }
        int dem = 0;
        void newDangNhap()
        {
            txtTDN.Clear();
            txtMK.Clear();
            txtTDN.Focus();
        }
        public void reDangNhap()
        {
            txtMK.Clear();
            txtMK.Focus();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dtDN = bllDangNhap.getData($"SELECT tenDangNhap, matKhau, hoTen FROM TaiKhoan WHERE tenDangNhap = '{txtTDN.Text.Trim()}' AND matKhau = '{txtMK.Text.Trim()}'");
            if (dtDN.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                dem = 0;
                string tenDN = dtDN.Rows[0][0].ToString().Trim();
                string matKhau = dtDN.Rows[0][1].ToString().Trim();
                string hoTen = dtDN.Rows[0][2].ToString().Trim();
                TrangChu trangChu = new TrangChu(this, tenDN, matKhau, hoTen);
                trangChu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                newDangNhap();
                dem++;
            }
            if (dem == 3)
            {
                MessageBox.Show("Bạn đã nhập sai 3 lần liên tiếp, đóng ứng dụng");
                Application.Exit();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKyForm = new DangKy(this);
            dangKyForm.Show();
            this.Hide();
        }
    }
}
