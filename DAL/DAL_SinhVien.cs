using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    internal class DAL_SinhVien : DBConnection
    {
        public DataTable loadSinhVien()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY SinhVien.maSV) AS STT," +
                " SinhVien.maSV AS [Mã SV]," +
                " SinhVien.tenSV AS [Tên SV]," +
                " SinhVien.gioiTinh AS [Giới tính]," +
                " SinhVien.ngaySinh AS [Ngày sinh]," +
                " SinhVien.noiSinh AS [Nơi sinh]," +
                " Lop.tenLop AS [Lớp]," +
                " Khoa.tenKhoa AS [Khoa]" +
                " FROM Khoa INNER JOIN" +
                " Lop ON Khoa.maKhoa = Lop.maKhoa INNER JOIN" +
                " SinhVien ON Lop.maLop = SinhVien.maLop;");
        }
        public bool themSinhVien(DTO_SinhVien sinhVien)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO SinhVien (maSV, tenSV, gioiTinh, ngaySinh, noiSinh, maLop) " +
                    $"VALUES('{sinhVien.maSV.Trim()}', N'{sinhVien.tenSV.Trim()}', N'{sinhVien.gioiTinh.Trim()}', N'{sinhVien.ngaySinh}', N'{sinhVien.noiSinh.Trim()}', N'{sinhVien.maLop.Trim()}');";
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
        public bool suaSinhVien(DTO_SinhVien sinhVien)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE SinhVien SET tenSV = N'{sinhVien.tenSV.Trim()}', gioiTinh = N'{sinhVien.gioiTinh}', ngaySinh = N'{sinhVien.ngaySinh}', noiSinh = N'{sinhVien.noiSinh.Trim()}', maLop = N'{sinhVien.maLop.Trim()}' WHERE(maSV = N'{sinhVien.maSV.Trim()}');";
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
        public bool xoaSinhVien(string maSV)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM SinhVien WHERE(maSV = '{maSV.Trim()}');";
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
