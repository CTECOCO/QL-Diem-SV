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
using QuanLySinhVien.DAL;

namespace QuanLySinhVien.GUI
{
    public partial class MonCuaKhoa : Form
    {
        MonHoc monHoc;
        public MonCuaKhoa(MonHoc monHoc)
        {
            InitializeComponent();
            this.monHoc = monHoc;
        }
        BLL_Khoa bllKhoa = new BLL_Khoa();
        BLL_MonHoc bllMH = new BLL_MonHoc();
        DAL_MonCuaKhoa dalMonKhoa = new DAL_MonCuaKhoa();
        public void loadKhoa()
        {
            cbKhoa.DataSource = bllKhoa.getData("SELECT maKhoa, tenKhoa FROM Khoa");
            cbKhoa.DisplayMember = "tenKhoa";
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.SelectedItem = null;
        }
        public void selectedKhoa(string maKhoa)
        {
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa;
        }
        public void loadMH()
        {
            cbMonhoc.DataSource = bllMH.getData("SELECT maMH, tenMH FROM MonHoc");
            cbMonhoc.DisplayMember = "tenMH";
            cbMonhoc.ValueMember = "maMH";
            cbMonhoc.SelectedItem = null;
        }
        public void selectedMH(string maMH)
        {
            loadMH();
            cbMonhoc.SelectedValue = maMH;
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

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            ThemSuaKhoa themKhoa = new ThemSuaKhoa(this, "Thêm khoa", true);
            themKhoa.Show();
        }

        private void MonCuaKhoa_Load(object sender, EventArgs e)
        {
            loadKhoa();
            loadMH();
        }

        private void btnThemMonhoc_Click(object sender, EventArgs e)
        {
            ThemSuaMonHoc themMon = new ThemSuaMonHoc(this, "Thêm môn học", true);
            themMon.Show();
        }

        private void change(object sender, EventArgs e)
        {
            btnLuu.Enabled = (cbMonhoc.SelectedIndex >= 0 && cbMonhoc.SelectedIndex >= 0);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dtMonKhoa = bllMH.getData($"SELECT * FROM MonCuaKhoa WHERE maMH = '{cbMonhoc.SelectedValue.ToString()}' AND maKhoa = '{cbKhoa.SelectedValue.ToString()}';");
            if (dtMonKhoa.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại môn học trong khoa");
            }
            else
            {
                if (dalMonKhoa.themMonCuaKhoa(cbMonhoc.SelectedValue.ToString(), cbKhoa.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm thành công");
                    cbMonhoc.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }
    }
}
