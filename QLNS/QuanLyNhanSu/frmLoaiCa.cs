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
    public partial class frmLoaiCa : Form
    {
        LOAICA _lc;
        bool _them;
        int _id;
        public frmLoaiCa()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }
        void RefreshDataGrid()
        {
            var data = _lc.getList();
            tbLOAICABindingSource.DataSource = data;
            dataGridView1.DataSource = tbLOAICABindingSource;
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
            txtHeSo.Enabled = !kt;
            txtLoaiCa.Enabled = !kt;
        }
        void SaveData()
        {
            if (_them)
            {
                tb_LOAICA dt = new tb_LOAICA();
                dt.TENLOAICA = txtLoaiCa.Text;
                dt.HESO = double.Parse(txtHeSo.Text);
                _lc.Add(dt);
            }
            else
            {
                var dt = _lc.getItem(_id);
                dt.TENLOAICA = txtLoaiCa.Text;
                dt.HESO = double.Parse(txtHeSo.Text);
                _lc.Edit(dt);
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
            txtHeSo.Text = string.Empty;
            txtLoaiCa.Text = string.Empty;
            _them = true;
            _showHide(false);
            //RefreshDataGrid();
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
                _lc.Delete(_id);
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

        private void frmLoaiCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_LOAICA' table. You can move, or remove it, as needed.
            this.tb_LOAICATableAdapter.Fill(this.qLNHANSUDataSet1.tb_LOAICA);
            _them = false;
            _lc = new LOAICA();
            _showHide(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value);
                txtLoaiCa.Text = row.Cells[1].Value.ToString();
                txtHeSo.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
