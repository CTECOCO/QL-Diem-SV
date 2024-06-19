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
    public partial class ThemSuaMonHoc : Form
    {
        MonHoc monHoc;
        DTO_MonHoc dtoMonhoc;
        BLL_MonHoc bllMonhoc = new BLL_MonHoc();
        MonCuaKhoa monKhoa = null;
        bool themSua;

        public ThemSuaMonHoc(MonHoc monHoc, string formName, bool themSua)
        {
            InitializeComponent();
            this.monHoc = monHoc;
            Text = formName;
            this.themSua = themSua;
        }
        public ThemSuaMonHoc(MonCuaKhoa monKhoa, string formName, bool themSua)
        {
            InitializeComponent();
            this.monKhoa = monKhoa;
            Text = formName;
            this.themSua = themSua;
        }
        public ThemSuaMonHoc(MonHoc monHoc, string formName, bool themSua, string maMH, string tenMH, int soTiet)
        {
            InitializeComponent();
            this.monHoc = monHoc;
            Text = formName;
            this.themSua = themSua;
            txtMaMH.Enabled = false;
            txtMaMH.Text = maMH;
            txtTenMH.Text = tenMH;
            nudSotiet.Value = soTiet;
            dtoMonhoc = new DTO_MonHoc(maMH.Trim(), tenMH.Trim(), soTiet);
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (themSua)
            {
                btnLuu.Enabled = (txtMaMH.Text.Trim().Length > 0 && txtTenMH.Text.Trim().Length > 0 && nudSotiet.Value > 0);
            }
            else
            {
                btnLuu.Enabled = (dtoMonhoc == null) ? false : ((txtTenMH.Text.Trim() != dtoMonhoc.tenMH && txtTenMH.Text.Trim().Length > 0) ||
                    (Convert.ToInt32(nudSotiet.Value) != dtoMonhoc.soTiet && nudSotiet.Value > 0));
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_MonHoc newMH = new DTO_MonHoc(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), (int)nudSotiet.Value);
            if (themSua) // Thêm môn học
            {
                if (bllMonhoc.themMH(newMH))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                    txtMaMH.Focus();
                }
            }
            else // Sửa môn học
            {
                if (bllMonhoc.suaMH(newMH))
                {
                    MessageBox.Show("Sửa môn học thành công");
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa môn học không thành công");
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

        private void ThemSuaMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (monKhoa != null)
            {
                monKhoa.selectedMH(txtMaMH.Text.Trim());
            }
            else
            {
                monHoc.loadMonHoc();
                monHoc.Show();
            }
        }
    }
}
