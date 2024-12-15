using BusinessLayer;
using DataLayer;
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
    public partial class frmLoadBangCongTopHopReport : Form
    {
        KYCONGCHITIET _kcct;
        int _makc;
        public frmLoadBangCongTopHopReport()
        {
            InitializeComponent();
        }
        public frmLoadBangCongTopHopReport(int makc)
        {
            InitializeComponent();
            _makc = makc;
        }
        private void frmLoadBangCongTopHop_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            var db = _kcct.getList(_makc);
            reportViewer1.LocalReport.ReportPath = "BangCongTongHop.rdlc";
            var source = new ReportDataSource("DataSet1", db);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
