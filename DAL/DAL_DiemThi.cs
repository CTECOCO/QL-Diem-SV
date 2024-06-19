using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAL
{
    internal class DAL_DiemThi : DBConnection
    {
        public DataTable loadDiem()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY DiemThi.maSV) AS STT, DiemThi.maSV AS [Mã SV], MonHoc.tenMH AS [Môn học], DiemThi.lanThi AS [Lần thi], DiemThi.diemThi AS [Điểm thi], Khoa.tenKhoa AS Khoa " +
                "FROM MonHoc INNER JOIN" +
                " DiemThi ON MonHoc.maMH = DiemThi.maMH INNER JOIN" +
                " SinhVien ON DiemThi.maSV = SinhVien.maSV INNER JOIN" +
                " Lop INNER JOIN" +
                " Khoa ON Lop.maKhoa = Khoa.maKhoa ON SinhVien.maLop = Lop.maLop");
        }
        public bool themDiem(DTO_DiemThi diem)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO DiemThi (maSV, maMH, lanThi, diemThi) VALUES('{diem.maSV.Trim()}', N'{diem.maMH.Trim()}', {diem.lanThi}, {diem.diemThi});";
                if (excute(sql) > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaDiem(DTO_DiemThi diem)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE DiemThi SET lanThi = {diem.lanThi}, diemThi = {diem.diemThi} WHERE(maSV = '{diem.maSV.Trim()}') AND (maMH = '{diem.maMH.Trim()}');";
                if (excute(sql) > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaDiem(string maSV, string maMH, int lanThi)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM DiemThi WHERE(maSV = '{maSV.Trim()}') AND (maMH = '{maMH.Trim()}' AND lanThi = {lanThi});";
                if (excute(sql) > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
