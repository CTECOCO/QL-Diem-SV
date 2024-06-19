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
    public partial class Lop : Form
    {
        TrangChu trangChu;
        BLL_Lop bllLop = new BLL_Lop();
        public Lop(TrangChu trangChu)
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
        public void loadData()
        {
            clearTextBox();
            dgvLop.DataSource = bllLop.loadLop();
            dgvLop.Columns[0].Width = 40;
        }

        private void Lop_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
            txtTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();
            txtKhoa.Text = dgvLop.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSuaLop themLop = new ThemSuaLop(this, "Thêm lớp", true, "", "", "");
            themLop.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.SelectedRows.Count > 0)
            {
                string maKhoa = "";
                DataTable dt = bllLop.getData($"SELECT maKhoa FROM Khoa WHERE tenKhoa = N'{txtKhoa.Text.Trim()}';");
                if (dt.Rows.Count > 0)
                {
                    maKhoa = dt.Rows[0][0].ToString().Trim();
                }

                ThemSuaLop suaLop = new ThemSuaLop(this, "Sửa lớp", false, txtMaLop.Text.Trim(), txtTenLop.Text.Trim(), maKhoa);
                suaLop.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy chọn lớp muốn sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (bllLop.xoaLop(txtMaLop.Text.Trim()))
                    {
                        MessageBox.Show("Xoá thành công");
                        loadData();
                    }
                    else
                        MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn lớp muốn xoá");
            }
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
