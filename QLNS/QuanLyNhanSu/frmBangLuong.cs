using BusinessLayer;
using QuanLyNhanSu.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmBangLuong : Form
    {
        BANGLUONG _bl;
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet10.tb_BANGLUONG' table. You can move, or remove it, as needed.
            this.tb_BANGLUONGTableAdapter.Fill(this.qLNHANSUDataSet10.tb_BANGLUONG);
            _bl = new BANGLUONG();
        }
        void RefreshDataGrid()
        {
            var data = _bl.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            tbBANGLUONGBindingSource.DataSource = data;
            dataGridView1.DataSource = tbBANGLUONGBindingSource;
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            _bl.TinhLuongNhanVien(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            RefreshDataGrid();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmBangLuongNhanVienh frm = new frmBangLuongNhanVienh(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBangCong_Click(object sender, EventArgs e)
        {
            frmBangCongChiTiet frm = new frmBangCongChiTiet();
            frm._idct = 0;
            frm._makycong = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
            frm._nam = int.Parse(cboNam.Text);
            frm._thang = int.Parse(cboThang.Text);
            frm.ShowDialog();
        }
    }
}
