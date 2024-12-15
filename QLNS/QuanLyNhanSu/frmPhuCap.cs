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
    public partial class frmPhuCap : Form
    {
        PHUCAP _pc;
        bool _them;
        int _id;
        public frmPhuCap()
        {
            InitializeComponent();
        }

        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_NHANVIEN' table. You can move, or remove it, as needed.
            this.tb_NHANVIENTableAdapter.Fill(this.qLNHANSUDataSet1.tb_NHANVIEN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_LOAICONG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLNHANSUDataSet9.tb_NHANVIEN_PHUCAP' table. You can move, or remove it, as needed.
            this.tb_NHANVIEN_PHUCAPTableAdapter.Fill(this.qLNHANSUDataSet9.tb_NHANVIEN_PHUCAP);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet9.tb_PHUCAP' table. You can move, or remove it, as needed.
            this.tb_PHUCAPTableAdapter1.Fill(this.qLNHANSUDataSet9.tb_PHUCAP);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_PHUCAP' table. You can move, or remove it, as needed.
            _pc = new PHUCAP();
            _them = false;
            _showHide(true);
        }

        void RefreshDataGrid()
        {
            var data = _pc.getFullList();
            tbNHANVIENPHUCAPBindingSource1.DataSource = data;
            dataGridView1.DataSource = tbNHANVIENPHUCAPBindingSource1;
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnDong.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnIn.Enabled = kt;
            txtGhiChu.Enabled = !kt;
            txtSoTien.Enabled = !kt;
            cboNhanVien.Enabled = !kt;
            cboPhuCap.Enabled = !kt;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN_PHUCAP dt = new tb_NHANVIEN_PHUCAP();
                dt.NOIDUNG = txtGhiChu.Text;
                dt.NGAY = DateTime.Now;
                dt.SOTIEN = int.Parse(txtSoTien.Text);
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                _pc.Add(dt);
            }
            else
            {
                var dt = _pc.getItem(_id);
                dt.NGAY = DateTime.Now;
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                dt.SOTIEN = int.Parse(txtSoTien.Text.ToString());
                dt.NOIDUNG = txtGhiChu.Text;
                _pc.Edit(dt);
            }
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = string.Empty;
            txtSoTien.Text = string.Empty;
            _them = true;
            _showHide(false);
            RefreshDataGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _showHide(false);
            RefreshDataGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá chức vụ này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _pc.Delete(_id);
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value);
                cboNhanVien.Text = row.Cells[1].Value.ToString();
                cboPhuCap.Text = row.Cells[2].Value.ToString();
                txtSoTien.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
