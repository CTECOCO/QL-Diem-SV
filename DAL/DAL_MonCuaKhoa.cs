using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    internal class DAL_MonCuaKhoa : DBConnection
    {
        public DataTable getData(string sql)
        {
            return getData(sql);
        }

        public bool themMonCuaKhoa(string maMH, string maKhoa)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO MonCuaKhoa (maMH, maKhoa) VALUES ('" + maMH.Trim() + "', '" + maKhoa.Trim() + "');";
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
        public bool xoaMonCuaKhoa(string ma)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM MonCuaKhoa WHERE maMH = '" + ma.Trim() + "' OR maKhoa = '" + ma.Trim() + "'";
                if (excute(sql) > 0)
                    return true;
            }
            catch(Exception ex) { }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
