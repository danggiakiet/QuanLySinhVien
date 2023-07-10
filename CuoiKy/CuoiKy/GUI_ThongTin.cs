using BUS_QuanLy;
using DTO_QuanLy;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CuoiKy
{
    public partial class GUI_ThongTin : Form
    {
        BUS_ThongTin busTT = new BUS_ThongTin();
        List<DTO_ThongTin> list = new List<DTO_ThongTin>();
        public GUI_ThongTin()
        {
            InitializeComponent();
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtNgaySinh.Mask = "00/00/0000";
            txtTenTimKiem.Hide();
            bttTimKiem.Hide();
            bttUndo.Hide();
        }
        private void bttThoat_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private bool KiemTraDate(string NgayKiemTra)
        {
            try 
            {
                DateTime.ParseExact(NgayKiemTra, "dd/MM/yyyy", null);
                return true;
            }
            catch 
            {
                MessageBox.Show("Ngày không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private void bttThem_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text != "" && txtHo.Text != "" && txtTen.Text != "" && txtNgaySinh.Text != "" && txtTrinhDo.Text != "" && txtLuong.Text != "")
            {
                if(KiemTraDate(txtNgaySinh.Text))
                {
                    if(busTT.KiemTraMaNV(txtMaNV.Text))
                    {
                        //Tạo DTO
                        //ID tự tăng nên để số nào cx đc
                        DTO_ThongTin thongtin = new DTO_ThongTin(txtMaNV.Text, txtHo.Text, txtTen.Text, txtNgaySinh.Text, cbbGioiTinh.Text, txtTrinhDo.Text, cbbLoaiNV.Text, Convert.ToDouble(txtLuong.Text));
                        //Thêm thông tin
                        if (busTT.ThemThongTin(thongtin))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Đưa thông tin lên bảng
                            dgvDanhSach.DataSource = busTT.getThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                    else
                    {
                        MessageBox.Show("Thêm không thành công vì mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNV.Clear();
                    }    
                }
                else
                {
                    txtNgaySinh.ResetText();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUI_ThongTin_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = busTT.getThongTin();
        }
        private void UndoThongTin(DTO_ThongTin TT)
        {
            if(busTT.UndoThongTin(TT))
            {
                MessageBox.Show("Hoàn tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSach.DataSource = busTT.getThongTin(); // refresh datagridview
            }    
        }
        private void bttSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                string MaNV = row.Cells[0].Value.ToString();
                string Ho = row.Cells[1].Value.ToString();
                string Ten = row.Cells[2].Value.ToString();
                string NgaySinh = row.Cells[3].Value.ToString();
                string GioiTinh = row.Cells[4].Value.ToString();
                string TrinhDo = row.Cells[5].Value.ToString();
                string LoaiNV = row.Cells[6].Value.ToString();
                string Luong = row.Cells[7].Value.ToString();
                DTO_ThongTin thongtinold = new DTO_ThongTin(MaNV, Ho, Ten, NgaySinh, GioiTinh, TrinhDo, LoaiNV, Convert.ToDouble(Luong));
                list.Add(thongtinold);
                if (txtHo.Text != "" && txtTen.Text != "" && txtNgaySinh.Text != "" && txtTrinhDo.Text != "" && txtLuong.Text != "")
                {
                    if (KiemTraDate(txtNgaySinh.Text))
                    {
                            // Tạo DTo
                            DTO_ThongTin thongtin = new DTO_ThongTin(MaNV, txtHo.Text, txtTen.Text, txtNgaySinh.Text, cbbGioiTinh.Text, txtTrinhDo.Text, cbbLoaiNV.Text, Convert.ToDouble(txtLuong.Text));
                            // Sửa
                            if (busTT.SuaThongTin(thongtin))
                            {
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDanhSach.DataSource = busTT.getThongTin(); // refresh datagridview
                                bttUndo.Show();
                            }
                            else
                            {
                                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                    else
                    {
                        txtNgaySinh.ResetText();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thông tin muốn sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            DataGridViewRow row = dgvDanhSach.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtHo.Text = row.Cells[1].Value.ToString();
            txtTen.Text = row.Cells[2].Value.ToString();
            txtNgaySinh.Text = row.Cells[3].Value.ToString();
            cbbGioiTinh.Text = row.Cells[4].Value.ToString();
            txtTrinhDo.Text = row.Cells[5].Value.ToString();
            cbbLoaiNV.Text = row.Cells[6].Value.ToString();
            txtLuong.Text = row.Cells[7].Value.ToString();
        }
        private void bttXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvDanhSach.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                string MaNV = row.Cells[0].Value.ToString();

                // Xóa
                if (busTT.XoaThongTin(MaNV))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDanhSach.DataSource = busTT.getThongTin(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void bttTimTen_Click(object sender, EventArgs e)
        {
            bttTimTen.Hide();
            bttTimKiem.Show();
            txtTenTimKiem.Show();  
        }
        private void bttBaoCao_Click(object sender, EventArgs e)
        {
            GUI_BaoCao form2 = new GUI_BaoCao();
            form2.Show();
        }
        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            string DsKetQua = busTT.TimTheoTen(txtTenTimKiem.Text);
            if (txtTenTimKiem.Text != "")
            {
                if (DsKetQua != "")
                {
                    MessageBox.Show($"Tìm thấy tên, mã nhân viên là : {DsKetQua}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenTimKiem.ResetText();
                    bttTimKiem.Hide();
                    txtTenTimKiem.Hide();
                    bttTimTen.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền tên muốn tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GUI_ThongTin_MouseClick(object sender, MouseEventArgs e)
        {
            bttTimTen.Show();
            bttTimKiem.Hide();
            txtTenTimKiem.Hide();
        }
        private void bttUndo_Click(object sender, EventArgs e)
        {
            string MaNV = list[0].MaNV;
            string Ho = list[0].Ho;
            string Ten = list[0].Ten;
            string NgaySinh = list[0].NgaySinh;
            string GioiTinh = list[0].GioiTinh;
            string TrinhDo = list[0].TrinhDo;
            string LoaiNV = list[0].LoaiNV;
            double Luong = list[0].Luong;
            DTO_ThongTin thongtinold = new DTO_ThongTin(MaNV, Ho, Ten, NgaySinh, GioiTinh, TrinhDo, LoaiNV, Luong);
            UndoThongTin(thongtinold);
            bttUndo.Hide();
            list.Clear();
        }
    }
}
