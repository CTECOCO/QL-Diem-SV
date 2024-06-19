using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class DangKy : Form
    {
        private DangNhap dangNhapForm;
        public DangKy(DangNhap dangNhapForm)
        {
            InitializeComponent();
            this.dangNhapForm = dangNhapForm;
            txtMatKhau.PasswordChar = '*';

            txtTenDangNhap.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtMatKhau.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtHoTen.KeyDown += new KeyEventHandler(TextBox_KeyDown);

            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.KeyPreview = true; // Để form có thể nhận sự kiện KeyDown
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy_Click(sender, e);
            }
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnThoat_Click(sender, e);
                this.Close();
                dangNhapForm.Show();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở về giao diện Đăng Nhập", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                dangNhapForm.Show();
            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string hoTen = txtHoTen.Text;
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = @"Data Source=MSI;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    //trung ten dang nhap
                    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE tenDangNhap = @tenDangNhap";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string query = "INSERT INTO TaiKhoan (tenDangNhap, matKhau, hoTen) VALUES (@tenDangNhap, @matKhau, @hoTen)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@matKhau", matKhau);
                        cmd.Parameters.AddWithValue("@hoTen", hoTen);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đăng ký thành công!");
                this.Close();
                dangNhapForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
