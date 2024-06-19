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
    public partial class ThemSuaLop : Form
    {
        Lop lop;
        BLL_Lop bllLop = new BLL_Lop();
        bool themSua;
        DTO_Lop dtoLop;
        ThemSuaSinhVien tsSV = null;
        public void loadKhoa()
        {
            cbKhoa.DataSource = bllLop.getData("SELECT maKhoa, tenKhoa FROM Khoa");
            cbKhoa.DisplayMember = "tenKhoa";
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.SelectedItem = null;
        }
        public void selectedKhoa(string maKhoa)
        {
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa;
        }
        public ThemSuaLop(ThemSuaSinhVien tsSV, string formName, bool themSua, string maKhoa)
        {
            InitializeComponent();
            this.tsSV = tsSV;
            Text = formName;
            this.themSua = themSua;
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa.Trim();
        }
        public ThemSuaLop(Lop lop, string formName, bool themSua, string maLop, string tenLop, string maKhoa)
        {
            InitializeComponent();
            dtoLop = new DTO_Lop(maLop, tenLop, maKhoa);
            Text = formName;
            this.lop = lop;
            this.themSua = themSua;
            loadKhoa();
            if (!themSua)
            {
                txtMaLop.Enabled = false;
                txtMaLop.BackColor = Color.White;
                txtMaLop.Text = maLop;
                txtTenLop.Text = tenLop;
                cbKhoa.SelectedValue = maKhoa;
            }
        }

        private void ThemSuaLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsSV != null)
            {
                tsSV.selectedLop(txtMaLop.Text.Trim());
                tsSV.Show();
            }
            else
            {
                lop.loadData();
                lop.Show();
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

        private void textChanged(object sender, EventArgs e)
        {
            if (themSua)
            {
                btnLuu.Enabled = (txtMaLop.Text.Trim().Length > 0 && txtTenLop.Text.Trim().Length > 0 && cbKhoa.SelectedIndex >= 0);
            }
            else
            {
                btnLuu.Enabled = ((txtTenLop.Text.Trim().Length > 0 && txtTenLop.Text.Trim() != dtoLop.tenLop) || (cbKhoa.SelectedIndex >= 0 && cbKhoa.SelectedValue.ToString().Trim() != dtoLop.maKhoa));
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_Lop newLop = new DTO_Lop(txtMaLop.Text.Trim(), txtTenLop.Text.Trim(), cbKhoa.SelectedValue.ToString().Trim());
            if (themSua) // Thêm lớp
            {
                if (bllLop.themLop(newLop))
                {
                    MessageBox.Show("Thêm lớp thành công");
                    this.Close();
                }    
                else
                {
                    MessageBox.Show("Thêm lớp không thành công");
                    txtMaLop.Focus();
                }
            }    
            else
            {
                if (bllLop.suaLop(newLop))
                {
                    MessageBox.Show("Sửa lớp thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa lớp không thành công");
                }
            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            ThemSuaKhoa themKhoa = new ThemSuaKhoa(this, "Thêm khoa", true);
            themKhoa.Show();
            this.Hide();
        }

        private void ThemSuaLop_Load(object sender, EventArgs e)
        {

        }
    }
}
