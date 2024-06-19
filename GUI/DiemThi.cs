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
    public partial class DiemThi : Form
    {
        TrangChu trangChu;
        BLL_DiemThi bllDiem = new BLL_DiemThi();
        public DiemThi(TrangChu trangChu)
        {
            InitializeComponent();
            this.trangChu = trangChu;
        }
        public void loadDiem()
        {
            dgv_Diem.DataSource = bllDiem.loadDiem();
            dgv_Diem.Columns[0].Width = 40;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiemThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void DiemThi_Load(object sender, EventArgs e)
        {
            loadDiem();
        }

        private void dgv_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgv_Diem.CurrentRow.Cells[1].Value.ToString();
            txtMH.Text = dgv_Diem.CurrentRow.Cells[2].Value.ToString();
            txtLanThi.Text = dgv_Diem.CurrentRow.Cells[3].Value.ToString();
            txtDiem.Text = dgv_Diem.CurrentRow.Cells[4].Value.ToString();
            txtKhoa.Text = dgv_Diem.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_Diem.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string maMH = "";
                    DataTable dtMH = bllDiem.getData($"SELECT maMH from MonHoc where tenMH like N'{txtMH.Text.Trim()}'");
                    if (dtMH.Rows.Count > 0)
                    {
                        maMH = dtMH.Rows[0][0].ToString();
                    }
                    if (bllDiem.xoaDiem(txtMaSV.Text.Trim(), maMH, Convert.ToInt32(txtLanThi.Text)))
                    {
                        MessageBox.Show("Xoá thành công");
                        loadDiem();
                    }
                    else
                        MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn điểm thi muốn xoá");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSuaDiemThi themDiem = new ThemSuaDiemThi(this, "Thêm điểm", true);
            themDiem.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_Diem.SelectedRows.Count > 0)
            {
                string maMH = "";
                DataTable dtMH = bllDiem.getData($"SELECT maMH FROM MonHoc WHERE tenMH like N'{txtMH.Text.Trim()}'");
                if (dtMH.Rows.Count > 0)
                {
                    maMH = dtMH.Rows[0][0].ToString();
                }
                string maKhoa = "";
                DataTable dtKhoa = bllDiem.getData($"SELECT maKhoa FROM Khoa WHERE tenKhoa like N'{txtKhoa.Text.Trim()}'");
                if (dtKhoa.Rows.Count > 0)
                {
                    maKhoa = dtKhoa.Rows[0][0].ToString();
                }
                ThemSuaDiemThi suaDiem = new ThemSuaDiemThi(this, "Sửa điểm", false, txtMaSV.Text.Trim(), maMH, Convert.ToInt32(txtLanThi.Text.Trim()), Convert.ToDouble(txtDiem.Text.Trim()), maKhoa);
                suaDiem.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn điểm thi muốn sửa");
            }
        }
    }
}
