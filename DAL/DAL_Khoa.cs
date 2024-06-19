using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAL
{
    internal class DAL_Khoa : DBConnection
    {
        public DataTable loadKhoa()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY maKhoa) as STT, maKhoa AS [Mã khoa], tenKhoa AS [Tên khoa] FROM Khoa;");
        }
        public bool themKhoa(DTO_Khoa khoa)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO Khoa(maKhoa, tenKhoa) VALUES('{khoa.maKhoa.Trim()}', N'{khoa.tenKhoa}');";
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
        public bool suaKhoa(DTO_Khoa khoa)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE Khoa SET tenKhoa = N'{khoa.tenKhoa}' WHERE(maKhoa = '{khoa.maKhoa.Trim()}');";
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
        public bool xoaKhoa(string maKhoa)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM Khoa WHERE(maKhoa = N'{maKhoa}');";
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
