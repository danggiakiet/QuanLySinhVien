using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_ThongTinDangNhap
    {
        DAL_ThongTinDangNhap daldangnhap = new DAL_ThongTinDangNhap();
        public bool KiemTraDangNhap(DTO_ThongTinUser TT)
        {
            return daldangnhap.KiemTraThongTinDangNhap(TT);
        }
    }
}
