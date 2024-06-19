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
    public partial class BangDiemChiTiet : Form
    {
        BLL_SinhVien bllSV = new BLL_SinhVien();
        string maSV;
        public BangDiemChiTiet(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        private void loadBangDiem(string maSV)
        {
            dgvBangDiem.DataSource = bllSV.getData("SELECT ROW_NUMBER() OVER(ORDER BY MonHoc.maMH) AS STT, tenMH AS [Tên môn học], soTiet AS [Số tín chỉ], lanThi AS [Lần thi], diemThi AS [Điểm thi]" +
                " FROM MonHoc INNER JOIN DiemThi ON MonHoc.maMH = DiemThi.maMH" +
                $" WHERE maSV = '{maSV}'");
            dgvBangDiem.Columns[0].Width = 40;
        }
        private void BangDiemChiTiet_Load(object sender, EventArgs e)
        {
            loadBangDiem(maSV);
        }
    }
}
