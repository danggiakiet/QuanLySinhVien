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
    public partial class GUI_BaoCao : Form
    {
        public GUI_BaoCao()
        {
            InitializeComponent();
        }

        private void Form_Bao_Cao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanVienDataSet3.ThongTin' table. You can move, or remove it, as needed.
            this.thongTinTableAdapter.Fill(this.quanLyNhanVienDataSet3.ThongTin);

            this.reportViewer1.RefreshReport();
        }
    }
}
