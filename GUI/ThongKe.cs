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

namespace QuanLySinhVien.GUI
{
    public partial class ThongKe : Form
    {
        TrangChu trangChu;
        BLL_MonHoc bllMH = new BLL_MonHoc();
        BLL_Khoa bllKhoa = new BLL_Khoa();
        BLL_GiangVien bllGV = new BLL_GiangVien();
        BLL_SinhVien bllSV = new BLL_SinhVien();
        BLL_Lop bllLop = new BLL_Lop();

        public ThongKe(TrangChu trangChu)
        {
            InitializeComponent();
            this.trangChu = trangChu;
        }
        
        private void btnTim_MonHoc_Click(object sender, EventArgs e)
        {
            if (cbKhoa_MonHoc.SelectedIndex >= 0)
            {
                DataTable dtMH = bllMH.getData("SELECT ROW_NUMBER() OVER(ORDER BY MonHoc.maMH) AS STT, MonHoc.maMH AS [Mã MH], MonHoc.tenMH AS [Tên MH], MonHoc.soTiet AS [Số tiết], Khoa.tenKhoa AS Khoa " +
                    " FROM Khoa INNER JOIN" +
                    " MonCuaKhoa ON Khoa.maKhoa = MonCuaKhoa.maKhoa INNER JOIN" +
                    $" MonHoc ON MonCuaKhoa.maMH = MonHoc.maMH WHERE(MonCuaKhoa.maKhoa = '{cbKhoa_MonHoc.SelectedValue.ToString()}')");
                if (dtMH.Rows.Count > 0)
                {
                    MessageBox.Show($"Đã tìm thấy {dtMH.Rows.Count} môn học thoả mãn");
                    dgvMonHoc.DataSource = dtMH;
                    dgvMonHoc.Columns[0].Width = 40;
                }
                else
                {
                    MessageBox.Show("Không có môn học nào thuộc khoa này");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa");
                cbKhoa_MonHoc.Focus();
            }
        }
        void loadKhoa(ComboBox cb)
        {
            cb.DataSource = bllKhoa.getData("SELECT maKhoa, tenKhoa FROM Khoa");
            cb.DisplayMember = "tenKhoa";
            cb.ValueMember = "maKhoa";
            cb.SelectedItem = null;
        }
        void loadLop(string maKhoa)
        {
            cbLop_SinhVien.DataSource = bllLop.getData($"SELECT maLop, tenLop FROM Lop WHERE maKhoa = '{maKhoa}'");
            cbLop_SinhVien.DisplayMember = "tenLop";
            cbLop_SinhVien.ValueMember = "maLop";
            cbLop_SinhVien.SelectedItem = null;
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            loadKhoa(cbKhoa_MonHoc);
            loadKhoa(cbKhoa_GiangVien);
            loadKhoa(cbKhoa_SinhVien);
        }

        private void ThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_GiangVien_Click(object sender, EventArgs e)
        {
            if (cbKhoa_GiangVien.SelectedIndex >= 0)
            {
                DataTable dtGV = bllGV.getData("SELECT ROW_NUMBER() OVER(ORDER BY maGV) AS STT, GiangVien.maGV AS [Mã GV], GiangVien.tenGV AS [Tên GV], GiangVien.chuyenNganh AS [Chuyên ngành], Khoa.tenKhoa AS Khoa" +
                    " FROM GiangVien INNER JOIN" +
                    $" Khoa ON GiangVien.maKhoa = Khoa.maKhoa WHERE(Khoa.maKhoa = '{cbKhoa_GiangVien.SelectedValue.ToString()}');");
                if (dtGV.Rows.Count > 0)
                {
                    MessageBox.Show($"Đã tìm thấy {dtGV.Rows.Count} giảng viên thoả mãn");
                    dgvGiangVien.DataSource = dtGV;
                    dgvGiangVien.Columns[0].Width = 40;
                }
                else
                {
                    MessageBox.Show("Không có giảng viên nào thuộc khoa này");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa");
            }
        }
        double diemMax(string maSV, string maMH)
        {
            DataTable dtDiem = bllSV.getData($"SELECT MAX(diemThi) FROM DiemThi WHERE maSV = '{maSV}' AND maMH = '{maMH}'");
            return (dtDiem.Rows.Count > 0) ? Convert.ToDouble(dtDiem.Rows[0][0].ToString()) : 0;
        }
        int soTiet(string maMH)
        {
            DataTable dtSoTiet = bllMH.getData($"SELECT soTiet FROM MonHoc WHERE maMH = '{maMH}'");
            return (dtSoTiet.Rows.Count > 0) ? Convert.ToInt32(dtSoTiet.Rows[0][0].ToString()) : 0;
        }
        double diemTK(string maSV)
        {
            List<string> list = new List<string>();
            DataTable dtDiem = bllSV.getData($"SELECT maMH FROM DiemThi WHERE maSV = '{maSV}'");
            double tongDiem = 0;
            int tongTinChi = 0;
            foreach (DataRow dr in dtDiem.Rows)
            {
                string svMon = dr[0].ToString();
                if (!list.Contains(svMon))
                {
                    list.Add(svMon);
                    int soTinChi = soTiet(dr[0].ToString().Trim());
                    tongTinChi += soTinChi;
                    tongDiem += diemMax(maSV, dr[0].ToString().Trim()) * soTinChi;
                }
            }
            return (double) tongDiem / tongTinChi;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<string> where = new List<string>();
            string sqlSinhVien = "SELECT ROW_NUMBER() OVER(ORDER BY SinhVien.maSV) AS STT, SinhVien.maSV AS [Mã SV], SinhVien.tenSV AS [Tên SV], SinhVien.gioiTinh AS [Giới tính], SinhVien.ngaySinh AS [Ngày sinh], SinhVien.noiSinh AS [Nơi sinh], Khoa.tenKhoa AS Khoa, Lop.tenLop AS Lớp " +
                                "FROM Khoa INNER JOIN" +
                                " Lop ON Khoa.maKhoa = Lop.maKhoa INNER JOIN" +
                                " SinhVien ON SinhVien.maLop = Lop.maLop";

            //MessageBox.Show("Điểm tổng kết: " + diemTK("001"));

            if (txtMaSV.Text.Length > 0)
            {
                where.Add($" maSV = '{txtMaSV.Text.Trim()}'");
            }
            else
            {
                if (txtHoTen.Text.Length > 0)
                {
                    where.Add($" tenSV like N'%{txtHoTen.Text.Trim()}%'");
                }
                if (txtNoiSinh.Text.Length > 0)
                {
                    where.Add($" noiSinh like N'{txtNoiSinh.Text.Trim()}'");
                }
                if (rbNam.Checked || rbNu.Checked)
                {
                    string gioiTinh = (rbNam.Checked) ? "Nam" : "Nữ";
                    where.Add($" gioiTinh = N'{gioiTinh}'");
                }
                if (cbKhoa_SinhVien.SelectedIndex >= 0)
                {
                    where.Add($" Khoa.maKhoa = '{cbKhoa_SinhVien.SelectedValue.ToString()}'");
                }
                if (cbLop_SinhVien.SelectedIndex >= 0)
                {
                    where.Add($" Lop.maLop = '{cbLop_SinhVien.SelectedValue.ToString()}'");
                }
                DataTable dtNgaySinh = bllSV.getData("SELECT MAX(ngaySinh) FROM SinhVien");
                if (DateTime.Compare(Convert.ToDateTime(dtpNgaySinh.Value), Convert.ToDateTime(dtNgaySinh.Rows[0][0].ToString())) <= 0)
                {
                    where.Add($" ngaySinh = '{dtpNgaySinh.Value.ToString()}'");
                }
            }
            string strWhere = String.Join(" AND ", where);
            if (strWhere.Length > 0)
            {
                sqlSinhVien += " WHERE " + strWhere;
            }
            DataTable dtSV = bllSV.getData(sqlSinhVien);
            bool hocLuc = rbXS.Checked || rbG.Checked || rbK.Checked || rbTB.Checked ||  rbY.Checked;
            int count = 0;
            string strHocLuc = (rbXS.Checked) ? "xuất sắc" : (rbG.Checked) ? "giỏi" : (rbK.Checked) ? "khá" : (rbTB.Checked) ? "trung bình" : (rbY.Checked) ? "Yếu" : "";
            if (hocLuc)
            {
                foreach (DataRow dr in dtSV.Rows)
                {
                    if (rbXS.Checked)
                    {
                        if (diemTK(dr[1].ToString().Trim()) >= 9.0)
                        {
                            count++;
                        }
                    }
                    else if (rbG.Checked)
                    {
                        double dtk = diemTK(dr[1].ToString().Trim());
                        if (dtk >= 8.5 && dtk < 9)
                        {
                            count++;
                        }
                    }
                    else if (rbK.Checked)
                    {
                        double dtk = diemTK(dr[1].ToString().Trim());
                        if (dtk >= 7 && dtk < 8.5)
                        {
                            count++;
                        }
                    }
                    else if (rbTB.Checked)
                    {
                        double dtk = diemTK(dr[1].ToString().Trim());
                        if (dtk >= 5 && dtk < 7)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        double dtk = diemTK(dr[1].ToString().Trim());
                        if (dtk < 5)
                        {
                            count++;
                        }
                    }
                }
            }

            if (dtSV.Rows.Count > 0)
            {
                MessageBox.Show($"Đã tìm thấy {dtSV.Rows.Count} sinh viên thoả mãn");
                dgvSinhVien.DataSource = dtSV;
                dgvSinhVien.Columns[0].Width = 40;
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào thoả mãn");
                dgvSinhVien.DataSource = null;
            }    
            if (hocLuc)
            {
                MessageBox.Show($"Có {count} sinh viên có học lực {strHocLuc}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNoiSinh.Clear();
            rbNam.Checked = rbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            cbKhoa_SinhVien.SelectedItem = null;
            cbLop_SinhVien.SelectedItem = null;
            rbXS.Checked = rbG.Checked = rbK.Checked = rbTB.Checked = rbY.Checked = false;
        }

        private void cbKhoa_SinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa_SinhVien.SelectedIndex >= 0)
                loadLop(cbKhoa_SinhVien.SelectedValue.ToString().Trim());
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                string maSV = dgvSinhVien.CurrentRow.Cells[1].Value.ToString().Trim();
                ChiTietSinhVien ctsv = new ChiTietSinhVien(maSV, diemTK(maSV));
                ctsv.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn sinh viên muốn xem chi tiết");
            }
        }
    }
}
