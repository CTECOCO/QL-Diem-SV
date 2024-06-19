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
    public partial class GiangVien : Form
    {
        TrangChu trangChu;
        BLL_GiangVien bllGV = new BLL_GiangVien();
        public GiangVien(TrangChu trangChu)
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
        }
        public void loadGV()
        {
            clearTextBox();
            dgvGiangVien.DataSource = bllGV.loadGV();
            dgvGiangVien.Columns[0].Width = 40;
        }
        private void GiangVien_Load(object sender, EventArgs e)
        {
            loadGV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvGiangVien.CurrentRow;
            txtMaGV.Text = row.Cells[1].Value.ToString();
            txtTenGV.Text = row.Cells[2].Value.ToString();
            txtChuyenNganh.Text = row.Cells[3].Value.ToString();
            txtKhoa.Text = row.Cells[4].Value.ToString();
        }

        private void GiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSuaGiangVien themGV = new ThemSuaGiangVien(this, "Thêm giảng viên", true, "", "", "", "");
            themGV.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiangVien.SelectedRows.Count > 0)
            {
                DataTable dtKhoa = bllGV.getData($"SELECT maKhoa FROM Khoa WHERE tenKhoa = N'{txtKhoa.Text.Trim()}'");
                string maKhoa = "";
                if (dtKhoa.Rows.Count > 0)
                {
                    maKhoa = dtKhoa.Rows[0][0].ToString().Trim();
                }
                ThemSuaGiangVien suaGV = new ThemSuaGiangVien(this, "Sửa giảng viên", false, txtMaGV.Text.Trim(), txtTenGV.Text.Trim(), txtChuyenNganh.Text.Trim(), maKhoa);
                suaGV.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy chọn giảng viên muốn sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiangVien.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (bllGV.xoaGV(txtMaGV.Text.Trim()))
                    {
                        MessageBox.Show("Xoá thành công");
                        loadGV();
                    }
                    else
                        MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn giảng viên muốn xoá");
            }
        }
    }
}
