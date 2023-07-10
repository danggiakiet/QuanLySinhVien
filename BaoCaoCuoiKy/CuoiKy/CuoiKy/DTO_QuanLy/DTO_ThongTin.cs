using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThongTin
    {
        private string _MaNV;
        private string _Ho;
        private string _Ten;
        private string _NgaySinh;
        private string _GioiTinh;
        private String _TrinhDo;
        private String _LoaiNV;
        private double _Luong;

        /* ==== Getter // setter === */
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public String TrinhDo
        {
            get { return _TrinhDo; }
            set { _TrinhDo = value; }
        }
        public string LoaiNV
        {
            get { return _LoaiNV; }
            set { _LoaiNV = value; }
        }
        public double Luong
        {
            get { return _Luong; }
            set { _Luong = value; }
        }
        /* === Constructor === */
        public DTO_ThongTin()
        {
            
        }
        public DTO_ThongTin(string maNV, string ho, string ten, string ngaySinh, string gioiTinh, string trinhDo, string loaiNV, double luong)
        {
            MaNV = maNV;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            TrinhDo = trinhDo;
            LoaiNV = loaiNV;
            Luong = luong;
        }
    }
}
