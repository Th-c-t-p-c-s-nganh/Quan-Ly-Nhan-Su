using BusinessLayer;
using DataLayer;
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

namespace QuanLyNhanSu
{
    public partial class frmPhongBan : Form
    {
        PHONGBAN _PHONGBAN;
        bool _them;
        int _id;
        public frmPhongBan()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_PHONGBAN' table. You can move, or remove it, as needed.
            this.tb_PHONGBANTableAdapter.Fill(this.qLNHANSUDataSet1.tb_PHONGBAN);
            _them = false;
            _PHONGBAN = new PHONGBAN();
            _showHide(true);
        }

        void RefreshDataGrid()
        {
            var data = _PHONGBAN.getList();
            tbPHONGBANBindingSource.DataSource = data;
            dataGridView1.DataSource = tbPHONGBANBindingSource;
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
            txtPhongBan.Enabled = !kt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            _them = false;
            _showHide(true);
            RefreshDataGrid();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtPhongBan.Text = string.Empty;
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá phòng ban này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _PHONGBAN.Delete(_id);
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
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                tb_PHONGBAN dt = new tb_PHONGBAN();
                dt.TENPB = txtPhongBan.Text;
                _PHONGBAN.Add(dt);
            }
            else
            {
                var dt = _PHONGBAN.getItem(_id);
                dt.TENPB = txtPhongBan.Text;
                _PHONGBAN.Edit(dt);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value);
                txtPhongBan.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
