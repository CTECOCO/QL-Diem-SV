using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAL
{
    internal class DAL_Lop : DBConnection
    {
        public DataTable loadLop()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY maLop) AS STT, Lop.maLop AS [Mã lớp], Lop.tenLop AS [Tên lớp], Khoa.tenKhoa AS Khoa" +
                " FROM Lop INNER JOIN Khoa ON Lop.maKhoa = Khoa.maKhoa;");
        }
        public bool themLop(DTO_Lop Lop)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO Lop (maLop, tenLop, maKhoa) VALUES('{Lop.maLop.Trim()}', N'{Lop.tenLop.Trim()}', '{Lop.maKhoa.Trim()}');";
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
        public bool suaLop(DTO_Lop Lop)
        {
            try
            {
                conn.Open();
                string sql = "";
                if (conn.State == ConnectionState.Open)
                {
                    sql = $"UPDATE Lop SET tenLop = N'{Lop.tenLop.Trim()}', maKhoa = '{Lop.maKhoa.Trim()}' WHERE(maLop = '{Lop.maLop.Trim()}')";
                }
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
        public bool xoaLop(string maLop)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM Lop WHERE(maLop = N'{maLop.Trim()}');";
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
