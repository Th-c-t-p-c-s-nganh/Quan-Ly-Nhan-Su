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
    public partial class frmKhenThuongKyLuat : Form
    {
        KHENTHUONG_KYLUAT _kt;
        NHANVIEN _nv;
        bool _them;
        string _shd;
        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void frmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_NHANVIEN' table. You can move, or remove it, as needed.
            this.tb_NHANVIENTableAdapter.Fill(this.qLNHANSUDataSet1.tb_NHANVIEN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet.tb_KHENTHUONG_KYLUAT' table. You can move, or remove it, as needed.
            this.tb_KHENTHUONG_KYLUATTableAdapter1.Fill(this.qLNHANSUDataSet.tb_KHENTHUONG_KYLUAT);
            //// TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_KHENTHUONG_KYLUAT' table. You can move, or remove it, as needed.
            //this.tb_KHENTHUONG_KYLUATTableAdapter.Fill(this.qLNHANSUDataSet1.tb_KHENTHUONG_KYLUAT);
            _kt = new KHENTHUONG_KYLUAT();
            _nv = new NHANVIEN();
            _showHide(true);
            _them = false;
        }

        void RefreshDataGrid()
        {
            var data = _kt.getList();
            tbKHENTHUONGKYLUATBindingSource1.DataSource = data;
            dataGridView1.DataSource = tbKHENTHUONGKYLUATBindingSource1;
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
            txtNoiDung.Enabled = !kt;
            txtSQD.Enabled = !kt;
            cboNhanVien.Enabled = !kt;
            dtNgayBD.Enabled = !kt;
        }

        void reset()
        {
            txtSQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            dtNgayBD.Value = DateTime.Now;
        }

        void SaveData()
        {
            if (_them)
            {
                var maxSHD = _kt.MaxSoHopDong();
                int so = int.Parse(maxSHD.Substring(0, 5)) + 1;
                tb_KHENTHUONG_KYLUAT dt = new tb_KHENTHUONG_KYLUAT();
                dt.SOQD = so.ToString("00000") + "/2024/HĐLĐ";
                dt.TUNGAY = dtNgayBD.Value;
                //dt.DENGAY = dtNgayKT.Value;
                dt.NOIDUNG = txtNoiDung.Text;
                dt.LYDO = txtLyDo.Text;
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                dt.CREATED_BY = 1;
                dt.CREATED_DATE = DateTime.Now;
                _kt.Add(dt);
            }
            else
            {
                var dt = _kt.getItem(_shd);
                dt.TUNGAY = dtNgayBD.Value;
                //dt.DENGAY = dtNgayKT.Value;
                dt.NOIDUNG = txtNoiDung.Text;
                dt.LYDO = txtLyDo.Text;
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                dt.UPDATED_BY = 1;
                dt.UPDATED_DATE = DateTime.Now;
                _kt.Add(dt);
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá khen thưởng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _kt.Delete(_shd);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
