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
    public partial class ThemSuaSinhVien : Form
    {
        SinhVien sv;
        BLL_SinhVien bllSV = new BLL_SinhVien();
        DTO_SinhVien dtoSV = null;
        bool themSua;
        public void loadKhoa()
        {
            cbKhoa.DataSource = bllSV.getData("SELECT maKhoa, tenKhoa FROM Khoa");
            cbKhoa.DisplayMember = "tenKhoa";
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.SelectedItem = null;
        }
        public void loadLop(string maKhoa)
        {
            cbLop.DataSource = bllSV.getData($"SELECT maLop, tenLop FROM Lop WHERE maKhoa = '{maKhoa}'");
            cbLop.DisplayMember = "tenLop";
            cbLop.ValueMember = "maLop";
            cbLop.SelectedItem = null;
        }
        public void selectedKhoa(string maKhoa)
        {
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa;
        }
        public void selectedLop(string maLop)
        {
            loadLop(cbKhoa.SelectedValue.ToString());
            cbLop.SelectedValue = maLop;
        }
        public ThemSuaSinhVien(SinhVien sv, string formName, bool themSua)
        {
            InitializeComponent();
            this.sv = sv;
            Text = formName;
            this.themSua = themSua;
            loadKhoa();
        }
        public ThemSuaSinhVien(SinhVien sv, string formName, bool themSua, string maSV, string tenSV, string gioiTinh, string ngaySinh, string noiSinh, string maLop, string maKhoa)
        {
            InitializeComponent();
            this.sv = sv;
            Text = formName;
            this.themSua = themSua;
            txtMaSV.Text = maSV;
            txtTenSV.Text = tenSV;
            if (gioiTinh.Trim() == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            dtpNgaySinh.Value = Convert.ToDateTime(ngaySinh);
            txtNoiSinh.Text = noiSinh;
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa.Trim();
            loadLop(maKhoa.Trim());
            cbLop.SelectedValue = maLop.Trim();
            dtoSV = new DTO_SinhVien(maSV, tenSV, gioiTinh, ngaySinh, noiSinh, maLop);
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

        private void textChanged(object sender, EventArgs e)
        {
            if (themSua)
            {
                btnLuu.Enabled = (txtMaSV.Text.Trim().Length > 0 &&
                    txtTenSV.Text.Trim().Length > 0 &&
                    (rbNam.Checked|| rbNu.Checked) &&
                    txtNoiSinh.Text.Trim().Length > 0 &&
                    cbKhoa.SelectedIndex >= 0 && cbLop.SelectedIndex >= 0);
            }
            else
            {
                string gioiTinh = (rbNam.Checked) ? "Nam" : "Nữ";
                btnLuu.Enabled = (dtoSV == null) ? false : (txtTenSV.Text.Trim().Length > 0 && txtTenSV.Text.Trim() != dtoSV.tenSV ||
                    gioiTinh != dtoSV.gioiTinh ||
                    dtpNgaySinh.Value.ToString().Trim().Length > 0 && dtpNgaySinh.Value.ToString().Trim() != dtoSV.ngaySinh ||
                    txtNoiSinh.Text.Trim().Length > 0 && txtNoiSinh.Text.Trim() != dtoSV.noiSinh ||
                    cbKhoa.SelectedIndex >= 0 && cbLop.SelectedIndex >= 0 && cbLop.SelectedValue.ToString() != dtoSV.maLop);
            }
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cbLop.SelectedItem = null;
            if (cbKhoa.SelectedIndex >= 0)
            {
                string maKhoa = cbKhoa.SelectedValue.ToString().Trim();
                loadLop(maKhoa);
            }
        }

        private void ThemSuaSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            sv.loadSV();
            sv.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
    {
        string gioiTinh = (rbNam.Checked) ? "Nam" : "Nữ";
        DTO_SinhVien newSV = new DTO_SinhVien(
            txtMaSV.Text.Trim(), 
            txtTenSV.Text.Trim(), 
            gioiTinh, 
            dtpNgaySinh.Value.ToString("yyyy-MM-dd"), // Ensuring proper date format
            txtNoiSinh.Text.Trim(), 
            cbLop.SelectedValue.ToString()
        );

        if (themSua)
        {
            if (bllSV.themSV(newSV))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại dữ liệu.");
                txtMaSV.Focus();
            }    
        }
        else
        {
            if (bllSV.suaSV(newSV))
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại dữ liệu.");
            }    
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
    }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            ThemSuaKhoa themKhoa = new ThemSuaKhoa(this, "Thêm khoa", true);
            themKhoa.Show();
            this.Hide();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            ThemSuaLop themLop = new ThemSuaLop(this, "Thêm lớp", true, cbKhoa.SelectedValue.ToString());
            themLop.Show();
            this.Hide();
        }
    }
}
