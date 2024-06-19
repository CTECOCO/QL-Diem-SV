using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.BLL;

namespace QuanLySinhVien.GUI
{
    public partial class ChiTietSinhVien : Form
    {
        BLL_SinhVien bllSV = new BLL_SinhVien();
        string maSV;
        double diemTk;
        public ChiTietSinhVien(string maSV, double diemTk)
        {
            InitializeComponent();
            this.maSV = maSV;
            this.diemTk = diemTk;
            DataTable dtSV = bllSV.getData("SELECT SinhVien.maSV AS [Mã SV], SinhVien.tenSV AS [Tên SV], SinhVien.gioiTinh AS [Giới tính], SinhVien.ngaySinh AS [Ngày sinh], SinhVien.noiSinh AS [Nơi sinh], Khoa.tenKhoa AS Khoa, Lop.tenLop AS Lớp" +
                " FROM SinhVien INNER JOIN" +
                " Lop ON SinhVien.maLop = Lop.maLop INNER JOIN Khoa ON Lop.maKhoa = Khoa.maKhoa" +
                $" WHERE(SinhVien.maSV = '{maSV}')");
            txtMaSV.Text = maSV;
            txtTenSV.Text = dtSV.Rows[0][1].ToString(); // ten
            if (dtSV.Rows[0][2].ToString().Equals("Nam"))
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }// gioiTinh
            dtpNgaySinh.Value = Convert.ToDateTime(dtSV.Rows[0][3].ToString()); // ngaySinh
            txtNoiSinh.Text = dtSV.Rows[0][4].ToString(); // noiSinh
            txtKhoa.Text = dtSV.Rows[0][5].ToString(); // Khoa
            txtLop.Text = dtSV.Rows[0][6].ToString(); // Lop
            txtDiemTK.Text = (Math.Round(diemTk, 2)).ToString();
            txtHocLuc.Text = (diemTk >= 9) ? "Xuất sắc" : (diemTk >= 8.5) ? "Giỏi" : (diemTk >= 7) ? "Khá" : (diemTk >= 5) ? "Trung bình" : "Yếu";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            BangDiemChiTiet bangDiem = new BangDiemChiTiet(txtMaSV.Text.Trim());
            bangDiem.Show();
        }
    }
}
