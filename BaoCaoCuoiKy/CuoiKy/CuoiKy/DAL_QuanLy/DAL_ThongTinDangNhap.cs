using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_ThongTinDangNhap : DBConnect
    {
        public bool KiemTraThongTinDangNhap(DTO_ThongTinUser TT)
        {
            try
            {
                //Kết nối
                _conn.Open();
                //Query String
                string SQL = string.Format("select * from ThongTinDangNhap");
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToString(reader["TaiKhoan"]) == TT.TaiKhoan && Convert.ToString(reader["MatKhau"]) == TT.MatKhau)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Đóng kết nối
                _conn.Close();
            }
            return false;
        }
    }
}
