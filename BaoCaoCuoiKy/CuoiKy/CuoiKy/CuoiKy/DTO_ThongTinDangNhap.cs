﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThongTinDangNhap
    {
        private string _TaiKhoan;
        private string _MatKhau;

        /* getter/setter */

        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        /* === Constructor === */
        public DTO_ThongTinDangNhap()
        {

        }
        public DTO_ThongTinDangNhap(string taiKhoan, string matKhau)
        {
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
        }
    }
}
