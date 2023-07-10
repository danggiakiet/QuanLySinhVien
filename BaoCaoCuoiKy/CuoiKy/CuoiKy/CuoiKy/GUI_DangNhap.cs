using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy
{
    public partial class GUI_DangNhap : Form
    {
        BUS_ThongTinDangNhap busTT = new BUS_ThongTinDangNhap();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                DTO_ThongTinUser TT = new DTO_ThongTinUser(txtTaiKhoan.Text, txtMatKhau.Text);
                if(busTT.KiemTraDangNhap(TT))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUI_ThongTin form = new GUI_ThongTin();
                    form.ShowDialog();
                }   
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                }    
            }   
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
