using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    internal class DAL_MonHoc : DBConnection
    {
        public DataTable loadMonHoc()
        {
            return getData("SELECT ROW_NUMBER() OVER(ORDER BY maMH) as STT, maMH AS [Mã MH], tenMH AS [Tên MH], soTiet AS [Số tiết] FROM MonHoc");
        }
        public bool themMonHoc(DTO_MonHoc monHoc)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO MonHoc (maMH, tenMH, soTiet) VALUES('{monHoc.maMH.Trim()}', N'{monHoc.tenMH.Trim()}', {monHoc.soTiet})";
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

        public bool suaMonHoc(DTO_MonHoc monHoc)
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE MonHoc SET tenMH = N'{monHoc.tenMH.Trim()}', soTiet = {monHoc.soTiet} WHERE(maMH = '{monHoc.maMH.Trim()}')";
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

        public bool xoaMonHoc(string maMH)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM MonHoc WHERE(maMH = '{maMH.Trim()}');";
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
