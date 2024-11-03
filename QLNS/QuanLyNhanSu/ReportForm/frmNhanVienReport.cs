using BusinessLayer;
using BusinessLayer.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ReportForm
{
    public partial class frmNhanVienReport : Form
    {
        NHANVIEN _nv;
        public frmNhanVienReport()
        {
            InitializeComponent();
        }

        private void frmNhanVienReport_Load(object sender, EventArgs e)
        {
            _nv = new NHANVIEN();
            var _db = _nv.getFullList();
            reportViewer1.LocalReport.ReportPath = "rptNhanVien.rdlc";
            var source = new ReportDataSource("DataSet1", _db);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
