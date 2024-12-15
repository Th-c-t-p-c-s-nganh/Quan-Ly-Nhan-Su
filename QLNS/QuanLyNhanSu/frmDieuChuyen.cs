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
    public partial class frmDieuChuyen : Form
    {
        DIEUCHUYEN _dc;
        NHANVIEN _nv;
        bool _them;
        string _shd;
        public frmDieuChuyen()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet3.tb_NHANVIEN_DIEUCHUYEN' table. You can move, or remove it, as needed.
            this.tb_NHANVIEN_DIEUCHUYENTableAdapter.Fill(this.qLNHANSUDataSet3.tb_NHANVIEN_DIEUCHUYEN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_PHONGBAN' table. You can move, or remove it, as needed.
            this.tb_PHONGBANTableAdapter.Fill(this.qLNHANSUDataSet1.tb_PHONGBAN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_NHANVIEN' table. You can move, or remove it, as needed.
            this.tb_NHANVIENTableAdapter.Fill(this.qLNHANSUDataSet1.tb_NHANVIEN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet2.tb_NHANVIEN_DIEUCHUYEN' table. You can move, or remove it, as needed.
            //this.tb_NHANVIEN_DIEUCHUYENTableAdapter.Fill(this.qLNHANSUDataSet2.tb_NHANVIEN_DIEUCHUYEN);
            _dc = new DIEUCHUYEN();
            _nv = new NHANVIEN();
            _showHide(true);
            _them = false;
        }

        void RefreshDataGrid()
        {
            var data = _dc.getList();
            tbNHANVIENDIEUCHUYENBindingSource.DataSource = data;
            dataGridView1.DataSource = tbNHANVIENDIEUCHUYENBindingSource;
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
            txtLyDo.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtSHD.Enabled = !kt;
            cboNhanVien.Enabled = !kt;
            dtNgayBD.Enabled = !kt;
            cboDieuChuyen.Enabled = !kt;
        }

        void reset()
        {
            txtSHD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtNgayBD.Value = DateTime.Now;
        }

        void SaveData()
        {
            if (_them)
            {
                var maxSHD = _dc.MaxSoHopDong();
                int so = int.Parse(maxSHD.Substring(0, 5)) + 1;
                tb_NHANVIEN_DIEUCHUYEN dt = new tb_NHANVIEN_DIEUCHUYEN();
                dt.SQQD = so.ToString("00000") + "/2024/QĐĐC";
                dt.NGAY = dtNgayBD.Value;
                //dt.DENGAY = dtNgayKT.Value;
                dt.MAPB = _nv.getItem(int.Parse(cboNhanVien.SelectedValue.ToString())).IDPB;
                dt.MAPB2 = int.Parse(cboDieuChuyen.SelectedValue.ToString()); 
                dt.GHICHU = txtGhiChu.Text;
                dt.LYDO = txtLyDo.Text;
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                dt.CREATED_BY = 1;
                dt.CREATED_DATE = DateTime.Now;
                _dc.Add(dt);
            }
            else
            {
                var dt = _dc.getItem(_shd);
                dt.NGAY = dtNgayBD.Value;
                //dt.DENGAY = dtNgayKT.Value;
                dt.GHICHU = txtGhiChu.Text;
                dt.LYDO = txtLyDo.Text;
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                dt.MAPB = _nv.getItem(int.Parse(cboNhanVien.SelectedValue.ToString())).IDPB;
                dt.MAPB2 = int.Parse(cboDieuChuyen.SelectedValue.ToString());
                dt.UPDATED_BY = 1;
                dt.UPDATED_DATE = DateTime.Now;
                _dc.Add(dt);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá điều chỉnh này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _dc.Delete(_shd);
                RefreshDataGrid();
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

        private void btnIn_Click(object sender, EventArgs e)
        {

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
