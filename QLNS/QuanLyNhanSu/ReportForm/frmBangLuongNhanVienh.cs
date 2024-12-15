using BusinessLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ReportForm
{
    public partial class frmBangLuongNhanVienh : Form
    {
        BANGLUONG _bl;
        int _makc;
        public frmBangLuongNhanVienh()
        {
            InitializeComponent();
        }

        public frmBangLuongNhanVienh(int mkc)
        {
            InitializeComponent();
            _makc = mkc;
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            _bl = new BANGLUONG();
            var db = _bl.getList(_makc);
            reportViewer1.LocalReport.ReportPath = "rptBangLuong.rdlc";
            var source = new ReportDataSource("DataSet1", db);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
