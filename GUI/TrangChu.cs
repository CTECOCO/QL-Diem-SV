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
    public partial class TrangChu : Form
    {
        string tenDangNhap, matKhau, hoTen;
        DangNhap dangNhap = null;
        public TrangChu()
        {
            InitializeComponent();
        }
        public TrangChu(DangNhap dangNhap, string tenDangNhap, string matKhau, string hoTen)
        {
            InitializeComponent();
            this.dangNhap = dangNhap;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void qlKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa(this);
            khoa.Show();
            this.Hide();
        }

        private void qlGV_Click(object sender, EventArgs e)
        {
            GiangVien giangVien = new GiangVien(this);
            giangVien.Show();
            this.Hide();
        }

        private void qlLop_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(this);
            lop.Show();
            this.Hide();
        }

        private void qlMH_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc(this);
            monHoc.Show();
            this.Hide();
        }

        private void qlSV_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(this);
            sv.Show();
            this.Hide();
        }

        private void menuThongTin_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan thongTin = new ThongTinTaiKhoan(tenDangNhap, matKhau, hoTen);
            thongTin.Show();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            dangNhap.Show();
            dangNhap.reDangNhap();
            this.Close();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void menuTrangChu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void qlDiem_Click(object sender, EventArgs e)
        {
            DiemThi diem = new DiemThi(this);
            diem.Show();
            this.Hide();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe(this);
            thongKe.Show();
            this.Hide();
        }
    }
}
