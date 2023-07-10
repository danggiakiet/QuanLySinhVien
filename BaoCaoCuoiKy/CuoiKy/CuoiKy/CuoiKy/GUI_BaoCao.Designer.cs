namespace CuoiKy
{
    partial class GUI_BaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyNhanVienDataSet3 = new CuoiKy.QuanLyNhanVienDataSet3();
            this.thongTinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinTableAdapter = new CuoiKy.QuanLyNhanVienDataSet3TableAdapters.ThongTinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanVienDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataBaoCao";
            reportDataSource1.Value = this.thongTinBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CuoiKy.Bao_Cao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(985, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyNhanVienDataSet3
            // 
            this.quanLyNhanVienDataSet3.DataSetName = "QuanLyNhanVienDataSet3";
            this.quanLyNhanVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinBindingSource
            // 
            this.thongTinBindingSource.DataMember = "ThongTin";
            this.thongTinBindingSource.DataSource = this.quanLyNhanVienDataSet3;
            // 
            // thongTinTableAdapter
            // 
            this.thongTinTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Bao_Cao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Bao_Cao";
            this.Text = "Form_Bao_Cao";
            this.Load += new System.EventHandler(this.Form_Bao_Cao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanVienDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyNhanVienDataSet3 quanLyNhanVienDataSet3;
        private System.Windows.Forms.BindingSource thongTinBindingSource;
        private QuanLyNhanVienDataSet3TableAdapters.ThongTinTableAdapter thongTinTableAdapter;
    }
}