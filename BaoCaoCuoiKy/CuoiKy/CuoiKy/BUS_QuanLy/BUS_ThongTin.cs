using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{   
    public class BUS_ThongTin
    {
        //Khởi tạo dal
        DAL_ThongTin dalThongTin = new DAL_ThongTin();
        //get thông tin lên gui
        public DataTable getThongTin()
        {
            return dalThongTin.GetThongTin();
        }
        //Thêm thông tin
        public bool ThemThongTin(DTO_ThongTin TT)
        {
            return dalThongTin.ThemThongTin(TT);
        }
        //sửa thông tin
        public bool SuaThongTin(DTO_ThongTin TT)
        {
            return dalThongTin.SuaThongTin(TT);
        }
        //Undo thông tin vừa sửa
        public bool UndoThongTin(DTO_ThongTin TT)
        {
            return dalThongTin.UndoThongTin(TT);
        }
        //xóa thông tin
        public bool XoaThongTin(string TT_MaNV)
        {
            return dalThongTin.XoaThongTin(TT_MaNV);
        }
        //tìm kiếm tên
        public string TimTheoTen(string Name)
        {
            string ketqua = dalThongTin.TimTheoTen(Name);
            if(ketqua != "")
            {
                return ketqua;
            }    
            else
            {
                return ketqua="";
            }    
        }
        //kiểm tra mã nv đã có hay chưa
        public bool KiemTraMaNV(string MaNV)
        {
            return dalThongTin.KiemTraMaNV(MaNV);
        }
    }
}
