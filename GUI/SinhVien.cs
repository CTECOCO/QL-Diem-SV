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
    public partial class SinhVien : Form
    {
        BLL_SinhVien bllSV = new BLL_SinhVien();
        TrangChu trangChu;
        public SinhVien(TrangChu trangChu)
        {
            InitializeComponent();
            this.trangChu = trangChu;
        }
        private void clearTextBox()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
            rbNam.Checked = false;
            rbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
        }
        public void loadSV()
        {
            clearTextBox();
            dgv_SV.DataSource = bllSV.loadSV();
            dgv_SV.Columns[0].Width = 40;
        }
        private void SinhVien_Load(object sender, EventArgs e)
        {
            loadSV();
        }

        private void SinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_SV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (bllSV.xoaSV(txtMaSV.Text.Trim()))
                    {
                        MessageBox.Show("Xoá thành công");
                        loadSV();
                    }
                    else
                        MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sinh viên muốn xoá");
            }
        }

        private void dgv_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgv_SV.CurrentRow.Cells[1].Value.ToString();
            txtTenSV.Text = dgv_SV.CurrentRow.Cells[2].Value.ToString();
            string gioiTinh = dgv_SV.CurrentRow.Cells[3].Value.ToString();
            if (gioiTinh == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            dtpNgaySinh.Value = Convert.ToDateTime(dgv_SV.CurrentRow.Cells[4].Value.ToString());
            txtNoiSinh.Text = dgv_SV.CurrentRow.Cells[5].Value.ToString();
            txtLop.Text = dgv_SV.CurrentRow.Cells[6].Value.ToString();
            txtKhoa.Text = dgv_SV.CurrentRow.Cells[7].Value.ToString();
        }

        private void bthThem_Click(object sender, EventArgs e)
        {
            ThemSuaSinhVien themSV = new ThemSuaSinhVien(this, "Thêm sinh viên", true);
            themSV.Show();
            this.Hide();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_SV.SelectedRows.Count > 0)
            {
                string gioiTinh = (rbNam.Checked) ? "Nam" : "Nữ";
                DataTable dtKhoa = bllSV.getData($"SELECT maKhoa FROM Khoa WHERE tenKhoa = N'{txtKhoa.Text.Trim()}'");
                string maKhoa = "";
                if (dtKhoa.Rows.Count > 0)
                {
                    maKhoa = dtKhoa.Rows[0][0].ToString().Trim();
                }
                DataTable dtLop = bllSV.getData($"SELECT maLop FROM Lop WHERE tenLop = N'{txtLop.Text.Trim()}'");
                string maLop = "";
                if (dtLop.Rows.Count > 0)
                {
                    maLop = dtLop.Rows[0][0].ToString().Trim();
                }
                ThemSuaSinhVien suaSV = new ThemSuaSinhVien(this, "Sửa sinh viên", false, txtMaSV.Text.Trim(), txtTenSV.Text.Trim(), gioiTinh, dtpNgaySinh.Value.ToString(), txtNoiSinh.Text.Trim(), maLop, maKhoa);
                suaSV.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy chọn sinh viên muốn sửa");
            }
        }
        double diemMax(string maSV, string maMH)
        {
            DataTable dtDiem = bllSV.getData($"SELECT MAX(diemThi) FROM DiemThi WHERE maSV = '{maSV}' AND maMH = '{maMH}'");
            return (dtDiem.Rows.Count > 0) ? Convert.ToDouble(dtDiem.Rows[0][0].ToString()) : 0;
        }
        int soTiet(string maMH)
        {
            DataTable dtSoTiet = bllSV.getData($"SELECT soTiet FROM MonHoc WHERE maMH = '{maMH}'");
            return (dtSoTiet.Rows.Count > 0) ? Convert.ToInt32(dtSoTiet.Rows[0][0].ToString()) : 0;
        }
        double diemTK(string maSV)
        {
            List<string> list = new List<string>();
            DataTable dtDiem = bllSV.getData($"SELECT maMH FROM DiemThi WHERE maSV = '{maSV}'");
            double tongDiem = 0;
            int tongTinChi = 0;
            foreach (DataRow dr in dtDiem.Rows)
            {
                string svMon = dr[0].ToString();
                if (!list.Contains(svMon))
                {
                    list.Add(svMon);
                    int soTinChi = soTiet(dr[0].ToString().Trim());
                    tongTinChi += soTinChi;
                    tongDiem += diemMax(maSV, dr[0].ToString().Trim()) * soTinChi;
                }
            }
            return (double)tongDiem / tongTinChi;
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgv_SV.SelectedRows.Count > 0)
            {
                string maSV = dgv_SV.CurrentRow.Cells[1].Value.ToString().Trim();
                ChiTietSinhVien ctsv = new ChiTietSinhVien(maSV, diemTK(maSV));
                ctsv.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn sinh viên muốn xem chi tiết");
            }
        }
    }
}