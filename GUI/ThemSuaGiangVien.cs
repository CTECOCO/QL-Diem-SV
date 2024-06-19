using QuanLySinhVien.BLL;
using QuanLySinhVien.DTO;
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
    public partial class ThemSuaGiangVien : Form
    {
        DTO_GiangVien dtoGV;
        BLL_GiangVien bllGV = new BLL_GiangVien();
        GiangVien gv;
        bool themSua;
        public void loadKhoa()
        {
            cbKhoa.DataSource = bllGV.getData("SELECT maKhoa, tenKhoa FROM Khoa");
            cbKhoa.DisplayMember = "tenKhoa";
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.SelectedItem = null;
        }
        public ThemSuaGiangVien(GiangVien gv, string formName, bool themSua, string maGV, string tenGV, string chuyenNganh, string maKhoa)
        {
            InitializeComponent();
            dtoGV = new DTO_GiangVien(maGV, tenGV, chuyenNganh, maKhoa);
            this.gv = gv;
            Text = formName;
            this.themSua = themSua;
            loadKhoa();
            if (!themSua)
            {
                txtMaGV.Enabled = false;
                txtMaGV.BackColor = Color.White;
                txtMaGV.Text = maGV;
                txtTenGV.Text = tenGV;
                txtChuyenNganh.Text = chuyenNganh;
                cbKhoa.SelectedValue = maKhoa;
            }
        }
        public void selectedKhoa(string maKhoa)
        {
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_GiangVien newGV = new DTO_GiangVien(txtMaGV.Text.Trim(), txtTenGV.Text.Trim(), txtChuyenNganh.Text.Trim(), cbKhoa.SelectedValue.ToString().Trim());
            if (themSua) // Thêm giảng viên
            {
                if (bllGV.themGV(newGV))
                {
                    MessageBox.Show("Thêm giảng viên thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên không thành công");
                    txtMaGV.Focus();
                }
            }
            else // Sửa giảng viên
            {
                if (bllGV.suaGV(newGV))
                {
                    MessageBox.Show("Sửa giảng viên thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa giảng viên không thành công");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn huỷ thao tác vừa rồi không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThemSuaGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            gv.loadGV();
            gv.Show();
        }

        private void change(object sender, EventArgs e)
        {
            if (themSua)
            {
                btnLuu.Enabled = (txtMaGV.Text.Trim().Length > 0 &&
                    txtTenGV.Text.Trim().Length > 0 &&
                    txtChuyenNganh.Text.Trim().Length > 0 &&
                    cbKhoa.SelectedItem != null);
            }
            else
            {
                btnLuu.Enabled = ((txtTenGV.Text.Trim() != dtoGV.tenGV && txtTenGV.Text.Trim().Length > 0) ||
                    (txtChuyenNganh.Text.Trim() != dtoGV.chuyenNganh && txtChuyenNganh.Text.Trim().Length > 0) ||
                    ((cbKhoa.SelectedValue == null) ? false : (cbKhoa.SelectedValue.ToString().Trim() != dtoGV.maKhoa)));
            }
        }

        private void themKhoa_Click(object sender, EventArgs e)
        {
            ThemSuaKhoa themKhoa = new ThemSuaKhoa(this, "Thêm khoa", true);
            themKhoa.Show();
            this.Hide();
        }
    }
}
