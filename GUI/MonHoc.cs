using QuanLySinhVien.BLL;
using QuanLySinhVien.DAL;
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
    public partial class MonHoc : Form
    {
        BLL_MonHoc bllMonhoc = new BLL_MonHoc();
        TrangChu trangChu;
        public MonHoc(TrangChu trangChu)
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
        public void loadMonHoc()
        {
            clearTextBox();
            dgv_Monhoc.DataSource = bllMonhoc.loadMH();
            dgv_Monhoc.Columns[0].Width = 40;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSuaMonHoc themMH = new ThemSuaMonHoc(this, "Thêm môn học", true);
            themMH.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_Monhoc.SelectedRows.Count > 0)
            {
                ThemSuaMonHoc suaMH = new ThemSuaMonHoc(this, "Sửa môn học", false, txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), Convert.ToInt32(txtSotiet.Text));
                suaMH.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy chọn môn học muốn sửa");
            }
        }

        private void dgv_Monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgv_Monhoc.CurrentRow.Cells[1].Value.ToString();
            txtTenMH.Text = dgv_Monhoc.CurrentRow.Cells[2].Value.ToString();
            txtSotiet.Text = dgv_Monhoc.CurrentRow.Cells[3].Value.ToString();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            loadMonHoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_Monhoc.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DAL_MonCuaKhoa dalMonKhoa = new DAL_MonCuaKhoa();
                    
                    if (dalMonKhoa.xoaMonCuaKhoa(txtMaMH.Text.Trim()))
                    {
                        if (bllMonhoc.xoaMH(txtMaMH.Text.Trim()))
                        {
                            MessageBox.Show("Xoá môn học thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá môn học không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá môn học không thành công");
                    }
                    loadMonHoc();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn môn học muốn xoá");
            }
        }

        private void btnMonKhoa_Click(object sender, EventArgs e)
        {
            MonCuaKhoa monKhoa = new MonCuaKhoa(this);
            monKhoa.Show();
        }
    }
}
