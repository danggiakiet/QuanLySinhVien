namespace CuoiKy
{
    partial class GUI_ThongTin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttTimTen = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.MaskedTextBox();
            this.txtTen = new System.Windows.Forms.MaskedTextBox();
            this.bttBaoCao = new System.Windows.Forms.Button();
            this.txtTenTimKiem = new System.Windows.Forms.TextBox();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrinhDo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbLoaiNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.bttUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(48, 388);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.ShowCellErrors = false;
            this.dgvDanhSach.Size = new System.Drawing.Size(894, 231);
            this.dgvDanhSach.TabIndex = 82;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // bttThoat
            // 
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThoat.Location = new System.Drawing.Point(753, 627);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(189, 43);
            this.bttThoat.TabIndex = 11;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttTimTen
            // 
            this.bttTimTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttTimTen.Location = new System.Drawing.Point(758, 334);
            this.bttTimTen.Name = "bttTimTen";
            this.bttTimTen.Size = new System.Drawing.Size(184, 46);
            this.bttTimTen.TabIndex = 10;
            this.bttTimTen.Text = "Tìm theo tên";
            this.bttTimTen.UseVisualStyleBackColor = true;
            this.bttTimTen.Click += new System.EventHandler(this.bttTimTen_Click);
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttSua.Location = new System.Drawing.Point(279, 334);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(106, 46);
            this.bttSua.TabIndex = 9;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttXoa.Location = new System.Drawing.Point(161, 334);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(111, 46);
            this.bttXoa.TabIndex = 8;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThem.Location = new System.Drawing.Point(49, 334);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(106, 46);
            this.bttThem.TabIndex = 7;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(73, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 75;
            this.label2.Text = "Mã nhân viên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(122, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 70;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(139, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 68;
            this.label5.Text = "Trình độ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 51);
            this.label1.TabIndex = 65;
            this.label1.Text = "Phần mềm quản lý nhân viên";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(279, 265);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(215, 40);
            this.txtLuong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(512, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 69;
            this.label3.Text = "Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(205, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 32);
            this.label7.TabIndex = 75;
            this.label7.Text = "Họ: ";
            // 
            // txtHo
            // 
            this.txtHo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(279, 123);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(215, 40);
            this.txtHo.TabIndex = 3;
            this.txtHo.Tag = "";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(660, 123);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(234, 40);
            this.txtTen.TabIndex = 4;
            this.txtTen.Tag = "";
            // 
            // bttBaoCao
            // 
            this.bttBaoCao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttBaoCao.Location = new System.Drawing.Point(49, 627);
            this.bttBaoCao.Name = "bttBaoCao";
            this.bttBaoCao.Size = new System.Drawing.Size(184, 46);
            this.bttBaoCao.TabIndex = 10;
            this.bttBaoCao.Text = "Báo cáo";
            this.bttBaoCao.UseVisualStyleBackColor = true;
            this.bttBaoCao.Click += new System.EventHandler(this.bttBaoCao_Click);
            // 
            // txtTenTimKiem
            // 
            this.txtTenTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTimKiem.Location = new System.Drawing.Point(652, 337);
            this.txtTenTimKiem.Name = "txtTenTimKiem";
            this.txtTenTimKiem.Size = new System.Drawing.Size(225, 40);
            this.txtTenTimKiem.TabIndex = 83;
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTimKiem.Location = new System.Drawing.Point(883, 334);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(59, 44);
            this.bttTimKiem.TabIndex = 84;
            this.bttTimKiem.Text = "🔎\r\n";
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(279, 170);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(215, 40);
            this.txtNgaySinh.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(512, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 69;
            this.label4.Text = "Giới tính: ";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrinhDo.Location = new System.Drawing.Point(279, 219);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(215, 40);
            this.txtTrinhDo.TabIndex = 4;
            this.txtTrinhDo.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(523, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 32);
            this.label8.TabIndex = 69;
            this.label8.Text = "Loại NV: ";
            // 
            // cbbLoaiNV
            // 
            this.cbbLoaiNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNV.FormattingEnabled = true;
            this.cbbLoaiNV.Items.AddRange(new object[] {
            "Văn phòng",
            "Công nhân",
            "Quản Lý"});
            this.cbbLoaiNV.Location = new System.Drawing.Point(660, 216);
            this.cbbLoaiNV.Name = "cbbLoaiNV";
            this.cbbLoaiNV.Size = new System.Drawing.Size(234, 40);
            this.cbbLoaiNV.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(161, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 32);
            this.label9.TabIndex = 68;
            this.label9.Text = "Lương:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(279, 72);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(615, 40);
            this.txtMaNV.TabIndex = 87;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(660, 170);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(234, 40);
            this.cbbGioiTinh.TabIndex = 86;
            // 
            // bttUndo
            // 
            this.bttUndo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUndo.Location = new System.Drawing.Point(391, 334);
            this.bttUndo.Name = "bttUndo";
            this.bttUndo.Size = new System.Drawing.Size(94, 46);
            this.bttUndo.TabIndex = 88;
            this.bttUndo.Text = "Undo";
            this.bttUndo.UseVisualStyleBackColor = true;
            this.bttUndo.Click += new System.EventHandler(this.bttUndo_Click);
            // 
            // GUI_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(977, 685);
            this.Controls.Add(this.bttUndo);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.cbbLoaiNV);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.bttTimKiem);
            this.Controls.Add(this.txtTenTimKiem);
            this.Controls.Add(this.txtTrinhDo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttBaoCao);
            this.Controls.Add(this.bttTimTen);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GUI_ThongTin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_ThongTin_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GUI_ThongTin_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttTimTen;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtHo;
        private System.Windows.Forms.MaskedTextBox txtTen;
        private System.Windows.Forms.Button bttBaoCao;
        private System.Windows.Forms.TextBox txtTenTimKiem;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTrinhDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbLoaiNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Button bttUndo;
    }
}

