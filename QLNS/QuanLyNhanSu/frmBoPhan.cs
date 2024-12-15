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
    public partial class frmBoPhan : Form
    {
        BOPHAN _bp;
        bool _them;
        int _id;
        public frmBoPhan()
        {
            InitializeComponent();
            //this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_BOPHAN' table. You can move, or remove it, as needed.
            this.tb_BOPHANTableAdapter.Fill(this.qLNHANSUDataSet1.tb_BOPHAN);
            _bp = new BOPHAN();
        }
        void RefreshDataGrid()
        {
            var data = _bp.getList();
            tbBOPHANBindingSource.DataSource = data;
            dataGridView1.DataSource = tbBOPHANBindingSource;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm frm = new MainForm();
            frm.Show();
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
            txtBoPhan.Enabled = !kt;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_BOPHAN dt = new tb_BOPHAN();
                dt.TENBP = txtBoPhan.Text;
                _bp.Add(dt);
            }
            else
            {
                var dt = _bp.getItem(_id);
                dt.TENBP = txtBoPhan.Text;
                _bp.Edit(dt);
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
            txtBoPhan.Text = string.Empty;
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
                _bp.Delete(_id);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value);
                txtBoPhan.Text = row.Cells[1].Value.ToString();
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
