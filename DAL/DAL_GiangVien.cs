using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    internal class DAL_GiangVien : DBConnection
    {
        public DataTable loadGV()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY maGV) as STT, GiangVien.maGV AS [Mã GV], GiangVien.tenGV AS [Tên GV], GiangVien.chuyenNganh AS [Chuyên ngành], Khoa.tenKhoa AS Khoa FROM GiangVien INNER JOIN Khoa ON GiangVien.maKhoa = Khoa.maKhoa");
        }
        public bool themGV(DTO_GiangVien giangVien)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO GiangVien (maGV, tenGV, chuyenNganh, maKhoa) VALUES('{giangVien.maGV.Trim()}', N'{giangVien.tenGV.Trim()}', N'{giangVien.chuyenNganh}', '{giangVien.maKhoa.Trim()}');";
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

        public bool suaGV(DTO_GiangVien giangVien)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE GiangVien SET tenGV = N'{giangVien.tenGV}', chuyenNganh = N'{giangVien.chuyenNganh}', maKhoa = '{giangVien.maKhoa}' WHERE(maGV = '{giangVien.maGV}');";
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

        public bool xoaGV(string maGV)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM GiangVien WHERE(maGV = N'{maGV}');";
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
