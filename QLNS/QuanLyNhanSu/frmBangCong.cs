using BusinessLayer;
using DataLayer;
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
    public partial class frmBangCong : Form
    {
        KYCONG _kc;
        bool _them;
        int _id;
        void RefreshDataGrid()
        {
            var data = _kc.getList();
            tbKYCONGBindingSource.DataSource = data;
            dataGridView1.DataSource = tbKYCONGBindingSource;
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnXemBangCong.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            cboNam.Enabled = !kt;
            cboKhoa.Enabled = !kt;
            cboThang.Enabled = !kt;
            cboTrangThai.Enabled = !kt;
        }
        void SaveData()
        {
            if (_them)
            {
                tb_KYCONG dt = new tb_KYCONG();
                dt.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                dt.NAM = int.Parse(cboNam.Text);
                dt.THANG = int.Parse(cboThang.Text);
                dt.KHOA = cboKhoa.Checked;
                dt.IDCT = 0;
                dt.TRANGTHAI = cboTrangThai.Checked;
                dt.NGAYCONGTRONGTHANG = Function.laySoNgayCuaThang(int.Parse(cboNam.Text) , int.Parse(cboThang.Text));
                dt.NGAYTINHCONG = DateTime.Now;
                _kc.Add(dt);
            }
            else
            {
                var dt = _kc.getItem(_id);
                dt.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                dt.NAM = int.Parse(cboNam.Text);
                dt.THANG = int.Parse(cboThang.Text);
                dt.KHOA = cboKhoa.Checked;
                dt.TRANGTHAI = cboTrangThai.Checked;
                dt.NGAYCONGTRONGTHANG = Function.laySoNgayCuaThang(int.Parse(cboNam.Text), int.Parse(cboThang.Text));
                dt.NGAYTINHCONG = DateTime.Now;
                dt.IDCT = 0;
                _kc.Edit(dt);
            }
        }

        public frmBangCong()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
        }

        private void frnBangCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet5.tb_KYCONG' table. You can move, or remove it, as needed.
            this.tb_KYCONGTableAdapter1.Fill(this.qLNHANSUDataSet5.tb_KYCONG);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet4.tb_KYCONG' table. You can move, or remove it, as needed.
            //this.tb_KYCONGTableAdapter.Fill(this.qLNHANSUDataSet4.tb_KYCONG);
            _kc = new KYCONG();
            _showHide(true);
            _them = false;
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                _them = false;
                _showHide(true);
                MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _showHide(false);
            RefreshDataGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bảng công này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _kc.Delete(_id);
                RefreshDataGrid();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            _showHide(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _showHide(false);
            _them = true;
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
            cboKhoa.Checked = false;
            cboTrangThai.Checked = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value);
                cboNam.Text = row.Cells[2].Value.ToString();
                cboThang.Text = row.Cells[1].Value.ToString();
                //cboTrangThai.Checked = row.Cells[8].Value is bool trangThai && trangThai;
                //cboKhoa.Checked = row.Cells[1].Value is bool khoa && khoa;
            }
        }

        private void btnXemBangCong_Click(object sender, EventArgs e)
        {
            frmBangCongChiTiet frm = new frmBangCongChiTiet();
            frm._makycong = _id;
            frm._thang = int.Parse(cboThang.Text);
            frm._nam = int.Parse(cboNam.Text);
            frm._idct = 0;
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Close();
        }
    }
}
