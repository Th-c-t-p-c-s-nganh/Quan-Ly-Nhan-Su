using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using DataLayer;

namespace QuanLyNhanSu
{
    public partial class frmDanToc : Form
    {
        DANTOC _dantoc;
        bool _them;
        int _id;
        public frmDanToc()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }
        void RefreshDataGrid()
        {
            var data = _dantoc.getList();
            tbDANTOCBindingSource1.DataSource = data; 
            dataGridView1.DataSource = tbDANTOCBindingSource1; 
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_DANTOC' table. You can move, or remove it, as needed.
            this.tb_DANTOCTableAdapter1.Fill(this.qLNHANSUDataSet1.tb_DANTOC);
            _them = false;
            _dantoc = new DANTOC();
            _showHide(true);
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
            txtDanToc.Enabled = !kt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                _them = false;
                _showHide(true);
                MessageBox.Show("Cập nhật thành công ! " , "Thông báo" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                RefreshDataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                txtDanToc.Text = string.Empty;
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá dân tộc này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _dantoc.Delete(_id);
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

        void SaveData()
        {
            if (_them)
            {
                tb_DANTOC dt = new tb_DANTOC();
                dt.TENDT = txtDanToc.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TENDT = txtDanToc.Text;
                _dantoc.Edit(dt);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value); 
                txtDanToc.Text = row.Cells[1].Value.ToString();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
