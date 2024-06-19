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
    public partial class ThemSuaDiemThi : Form
    {

        DiemThi diem;
        bool themSua;
        DTO_DiemThi dtoDiem;
        BLL_DiemThi bllDiem = new BLL_DiemThi();
        void loadKhoa()
        {
            cbKhoa.DataSource = bllDiem.getData("SELECT maKhoa, tenKhoa FROM Khoa");
            cbKhoa.DisplayMember = "tenKhoa";
            cbKhoa.ValueMember = "maKhoa";
            cbKhoa.SelectedItem = null;
        }
        void selectedKhoa(string maKhoa)
        {
            loadKhoa();
            cbKhoa.SelectedValue = maKhoa;
        }
        void loadLop(string maKhoa)
        {
            cbLop.DataSource = bllDiem.getData($"SELECT maLop, tenLop FROM Lop where Lop.maKhoa = '{maKhoa}'");
            cbLop.DisplayMember = "tenLop";
            cbLop.ValueMember = "maLop";
            cbLop.SelectedItem = null;
        }
        void selectedLop(string maLop)
        {
            loadLop(cbKhoa.SelectedValue.ToString());
            cbLop.SelectedValue = maLop;
        }
        void loadMaSV(string maLop)
        {
            cbMaSV.DataSource = bllDiem.getData($"SELECT SinhVien.maSV FROM SinhVien WHERE maLop = '{maLop}'");
            cbMaSV.DisplayMember = "maSV";
            cbMaSV.ValueMember = "maSV";
            cbMaSV.SelectedItem = null;
        }
        void selectedMaSV(string maSV)
        {
            loadMaSV(cbLop.SelectedValue.ToString());
            cbMaSV.SelectedValue = maSV;
        }
        void loadMH(string maKhoa)
        {
            cbMH.DataSource = bllDiem.getData($"SELECT MonHoc.maMH, tenMH from MonHoc INNER JOIN MonCuaKhoa ON MonHoc.maMH = MonCuaKhoa.maMH WHERE maKhoa = '{maKhoa}'");
            cbMH.DisplayMember = "tenMH";
            cbMH.ValueMember = "maMH";
            cbMH.SelectedItem = null;
        }
        void selectedMH(string maMH)
        {
            loadMH(cbKhoa.SelectedValue.ToString());
            cbMH.SelectedValue = maMH;
        }
        void loadLanThi()
        {
            cbLanThi.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                cbLanThi.Items.Add(i);
            }
            cbLanThi.SelectedItem = 1;
        }
        public ThemSuaDiemThi(DiemThi diem, string formName, bool themSua)
        {
            InitializeComponent();
            this.diem = diem;
            Text = formName;
            this.themSua = themSua;
            loadKhoa();
            loadLanThi();
        }
        public ThemSuaDiemThi(DiemThi diem, string formName, bool themSua, string maSV, string maMH, int lanThi, double diemThi, string maKhoa)
        {
            InitializeComponent();
            this.diem = diem;
            Text = formName;
            this.themSua = themSua;
            selectedKhoa(maKhoa);
            DataTable dtLop = bllDiem.getData($"SELECT maLop FROM SinhVien WHERE maSV = '{maSV}'");
            if (dtLop.Rows.Count > 0)
            {
                selectedLop(dtLop.Rows[0][0].ToString().Trim());
            }
            selectedMaSV(maSV);
            selectedMH(maMH);
            loadLanThi();
            cbLanThi.SelectedItem = lanThi;
            cbKhoa.Enabled = cbLop.Enabled = cbMaSV.Enabled = cbMH.Enabled = false;
            cbKhoa.BackColor = cbLop.BackColor = cbMaSV.BackColor = cbMH.BackColor = Color.White;
            txtDiemThi.Text = diemThi.ToString();
            txtDiemThi.Focus();
            dtoDiem = new DTO_DiemThi(maSV, maMH, lanThi, diemThi);
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue != null)
            {
                loadLop(cbKhoa.SelectedValue.ToString());
                loadMH(cbKhoa.SelectedValue.ToString());
            }
        }

        void change(object sender, EventArgs e)
        {
            if (themSua)
            {
                btnLuu.Enabled = (cbKhoa.SelectedIndex >= 0 && cbMaSV.SelectedIndex >= 0 && cbMH.SelectedIndex >= 0 && txtDiemThi.Text.Trim().Length > 0);
            }
            else
            {
                btnLuu.Enabled = (dtoDiem == null) ? false : (txtDiemThi.Text.Trim().Length > 0 && !txtDiemThi.Text.Trim().Equals(dtoDiem.diemThi.ToString())); 
            }
            if (sender.Equals(txtDiemThi))
            {
                if (txtDiemThi.Text.Trim().Length > 0 && !char.IsDigit(txtDiemThi.Text, txtDiemThi.Text.Length - 1))
                {
                    this.errorProvider1.SetError(txtDiemThi, "Điểm thi phải là chữ số");
                }
                else
                {
                    this.errorProvider1.Clear();
                    double diem = 0;
                    if (txtDiemThi.Text.Trim().Length > 0)
                        diem = Convert.ToDouble(txtDiemThi.Text);
                    if (diem < 0 || diem > 10)
                    {
                        this.errorProvider1.SetError(txtDiemThi, "Điểm thi phải nằm trong khoảng từ 0 đến 10");
                    }
                    else
                    {
                        this.errorProvider1.Clear();
                    }    
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_DiemThi newDiem = new DTO_DiemThi(cbMaSV.SelectedValue.ToString(), cbMH.SelectedValue.ToString(), Convert.ToInt32(cbLanThi.SelectedItem), Convert.ToDouble(txtDiemThi.Text.Trim()));
            if (themSua)
            {
                if (bllDiem.themDiem(newDiem))
                {
                    MessageBox.Show("Thêm thành công");
                    diem.loadDiem();
                    cbMaSV.SelectedItem = null;
                    cbMH.SelectedItem = null;
                    cbLanThi.SelectedItem = 1;
                    txtDiemThi.Clear();
                    cbMaSV.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                if (bllDiem.suaDiem(newDiem))
                {
                    MessageBox.Show("Sửa thành công");
                    diem.loadDiem();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
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
        private void changeValue(object sender, EventArgs e)
        {
            int lanThi = 0;
            if (cbMaSV.SelectedItem != null && cbMH.SelectedItem != null)
            {
                DataTable tbDiem = bllDiem.getData($"SELECT COUNT(*) FROM DiemThi WHERE maSV = '{cbMaSV.SelectedValue.ToString()}' and maMH = '{cbMH.SelectedValue.ToString()}'");
                if (tbDiem.Rows.Count > 0)
                {
                    lanThi = Convert.ToInt32(tbDiem.Rows[0][0].ToString());
                }
            }
            cbLanThi.SelectedItem = (lanThi + 1) > 5 ? 5 : (lanThi + 1);
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                loadMaSV(cbLop.SelectedValue.ToString());
            }
        }
    }
}
