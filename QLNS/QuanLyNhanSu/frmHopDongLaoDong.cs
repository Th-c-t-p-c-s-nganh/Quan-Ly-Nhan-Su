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
    public partial class frmHopDongLaoDong : Form
    {
        HOPDONGLAODONG _hd;
        NHANVIEN _nv;
        bool _them;
        string _shd;
        public frmHopDongLaoDong()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet12.tb_HOPDONG' table. You can move, or remove it, as needed.
            this.tb_HOPDONGTableAdapter.Fill(this.qLNHANSUDataSet12.tb_HOPDONG);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet11.tb_HOPDONG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_NHANVIEN' table. You can move, or remove it, as needed.
            this.tb_NHANVIENTableAdapter.Fill(this.qLNHANSUDataSet1.tb_NHANVIEN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_HOPDONG' table. You can move, or remove it, as needed.
            _hd = new HOPDONGLAODONG();
            _nv = new NHANVIEN();
            _showHide(true);
            _them = false;
        }
        void RefreshDataGrid()
        {
            var data = _hd.getList();
            tbHOPDONGBindingSource.DataSource = data;
            dataGridView1.DataSource = tbHOPDONGBindingSource;
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
            txtSHD.Enabled = !kt;
            dtNgayBD.Enabled = !kt;
            dtNgayKT.Enabled = !kt;
            dtNgayKT.Enabled = !kt;
            txtHeSoLuong.Enabled = !kt;
            txtLanKy.Enabled = !kt;
            cboNhanVien.Enabled = !kt;
        }
        void SaveData()
        {
            if (_them)
            {
                var maxSHD = _hd.MaxSoHopDong();
                int so = int.Parse(maxSHD.Substring(0, 5)) + 1;
                tb_HOPDONG dt = new tb_HOPDONG();
                dt.SOHD = so.ToString("00000") + "/2024/HĐLĐ";
                dt.NGAYBATDAU = dtNgayBD.Value;
                dt.NGAYKETTHUC = dtNgayKT.Value;
                dt.NGAYKY = dtNgayKy.Value;
                dt.THOIHAN = int.Parse(txtThoiHan.Text);
                dt.HESOLUONG = double.Parse(txtHeSoLuong.Text);
                dt.LANKY = int.Parse(txtLanKy.Text);
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                //dt.NOIDUNG = rtbHopDong.Text;
                dt.IDCT = 0;
                dt.CREATED_BY = 1;
                dt.LUONGCOBAN = int.Parse(txtLuongCB.Text);
                dt.CREATED_DATE = DateTime.Now;
                _hd.Add(dt);
            }
            else
            {
                var dt = _hd.getItem(_shd);
                dt.NGAYBATDAU = dtNgayBD.Value;
                dt.NGAYKETTHUC = dtNgayKT.Value;
                dt.NGAYKY = dtNgayKy.Value;
                dt.THOIHAN = int.Parse(txtThoiHan.Text);
                dt.HESOLUONG = double.Parse(txtHeSoLuong.Text);
                dt.LANKY = int.Parse(txtLanKy.Text);
                dt.MANV = int.Parse(cboNhanVien.SelectedValue.ToString());
                dt.LUONGCOBAN = int.Parse(txtLuongCB.Text);
                dt.IDCT = 0;
                dt.CREATED_BY = 1;
                dt.CREATED_DATE = DateTime.Now;
                _hd.Add(dt);
            }
        }
        void reset()
        {
            txtSHD.Text = string.Empty;
            dtNgayBD.Value = DateTime.Now;
            dtNgayKT.Value = DateTime.Now.AddMonths(6);
            dtNgayKy.Value = DateTime.Now;
            txtLanKy.Text = string.Empty;
            txtHeSoLuong.Text = string.Empty;
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá hợp đồng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _hd.Delete(_shd, 1);
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
