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
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.GUI
{
    public partial class Khoa : Form
    {
        BLL_Khoa bllKhoa = new BLL_Khoa();
        TrangChu trangChu;
        public Khoa(TrangChu trangChu)
        {
            InitializeComponent();
            this.trangChu = trangChu;
        }
        private void clearTextBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }
        public void loadKhoa()
        {
            clearTextBox();
            dgv_Khoa.DataSource = bllKhoa.loadKhoa();
            dgv_Khoa.Columns[0].Width = 40;
        }
        private void Khoa_Load(object sender, EventArgs e)
        {
            loadKhoa();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            ThemSuaKhoa themKhoa = new ThemSuaKhoa(this, "Thêm khoa", true, "", "");
            themKhoa.Show();
            //this.Hide();
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            if (dgv_Khoa.SelectedRows.Count > 0)
            {
                ThemSuaKhoa suaKhoa = new ThemSuaKhoa(this, "Sửa khoa", false, txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim());
                suaKhoa.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy chọn khoa muốn sửa");
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            if (dgv_Khoa.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (bllKhoa.xoaKhoa(txtMaKhoa.Text.Trim()))
                    {
                        MessageBox.Show("Xoá thành công");
                        loadKhoa();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khoa muốn xoá");
            }
        }

        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Khoa.CurrentRow;
            txtMaKhoa.Text = row.Cells[1].Value.ToString().Trim();
            txtTenKhoa.Text = row.Cells[2].Value.ToString().Trim();
        }

        private void Khoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
