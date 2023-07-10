using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace DAL_QuanLy
{
    public class DAL_ThongTin : DBConnect
    {
        //Get tất cả thông tin
        public DataTable GetThongTin()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ThongTin", _conn);
            DataTable tableThongTin = new DataTable();
            da.Fill(tableThongTin);
            return tableThongTin;
        }    
        //Thêm thông tin
        public bool ThemThongTin(DTO_ThongTin TT)
        {
            try
            {
                //Kết nối
                _conn.Open();
                string SQL = string.Format("Insert into ThongTin(MaNV, Ho, Ten, NgaySinh, GioiTinh, TrinhDo, LoaiNhanVien, Luong) Values ('{0}', N'{1}', N'{2}', '{3}', N'{4}', N'{5}', N'{6}', '{7}')",
                                           TT.MaNV, TT.Ho, TT.Ten, TT.NgaySinh, TT.GioiTinh, TT.TrinhDo, TT.LoaiNV, TT.Luong);
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                //Query 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }    
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Đóng kết nối
                _conn.Close();
            }
            return false;
        }
        //Sửa thông tin
        public bool SuaThongTin(DTO_ThongTin TT)
        {
            try
            {
                //Kết nối
                _conn.Open();
                string SQL = string.Format("UPDATE ThongTin SET Ho = N'{0}' , Ten = N'{1}', NgaySinh = '{2}', GioiTinh = N'{3}', TrinhDo = N'{4}', LoaiNhanVien = N'{5}', Luong = '{6}' Where MaNV = '{7}'",
                    TT.Ho, TT.Ten, TT.NgaySinh, TT.GioiTinh, TT.TrinhDo, TT.LoaiNV, TT.Luong, TT.MaNV);
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                //Query 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
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
        //Undo thông tin vừa sửa
        public bool UndoThongTin(DTO_ThongTin TT)
        {
            try
            {
                //Kết nối
                _conn.Open();
                string SQL = string.Format("UPDATE ThongTin SET Ho = N'{0}' , Ten = N'{1}', NgaySinh = '{2}', GioiTinh = N'{3}', TrinhDo = N'{4}', LoaiNhanVien = N'{5}', Luong = '{6}' Where MaNV = '{7}'",
                    TT.Ho, TT.Ten, TT.NgaySinh, TT.GioiTinh, TT.TrinhDo, TT.LoaiNV, TT.Luong, TT.MaNV);
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                //Query 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
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
        //Xóa thông tin
        public bool XoaThongTin(string MaNV)
        {
            try
            {
                //Kết nối
                _conn.Open();
                //Query String
                string SQL = string.Format("Delete from ThongTin Where MaNV = '{0}'", MaNV);
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                //Query 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;

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
        //Tìm theo tên nhập vào
        public string TimTheoTen(string Ten)
        {
            string DsKetQua = "";
            try
            {
                //Kết nối
                _conn.Open();
                //Query String
                string SQL = string.Format("select * from ThongTin");
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(Convert.ToString(reader["Ten"]).ToLower() == Ten.ToLower())
                    {
                        DsKetQua += Convert.ToString(reader["MaNV"])+", ";
                    }    
                }  
                return DsKetQua;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Đóng kết nối
                _conn.Close();
            }
            return DsKetQua = "";
        }
        //Kiểm tra mã nhân viên có đã có hay chưa
        public bool KiemTraMaNV(string MaNV)
        {
            string DsKetQua = "";
            try
            {
                //Kết nối
                _conn.Open();
                //Query String
                string SQL = string.Format("select * from ThongTin");
                //Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToString(reader["MaNV"]) == MaNV)
                    {
                        return false;
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
            return true;
        }
    }
}
