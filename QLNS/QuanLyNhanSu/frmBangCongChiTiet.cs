using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Security.Cryptography;
using QuanLyNhanSu.ReportForm;

namespace QuanLyNhanSu
{
    public partial class frmBangCongChiTiet : Form
    {
        KYCONG _kc;
        NHANVIEN _nv;
        KYCONGCHITIET _kcct;
        BANGCONG_NHANVIEN_CT _nvct;
        public int _makycong;
        public int _idct;
        public int _thang;
        public int _nam;
        public frmBangCongChiTiet()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        public void RefreshDataGrid()
        {
            var data = _kcct.getList(_makycong);
            tbKYCONGCHITIETBindingSource1.DataSource = data;
            dataGridView1.DataSource = tbKYCONGCHITIETBindingSource1;
        }

        private void frmBangCongChiTiet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet6.tb_KYCONGCHITIET' table. You can move, or remove it, as needed.
            this.tb_KYCONGCHITIETTableAdapter1.Fill(this.qLNHANSUDataSet6.tb_KYCONGCHITIET);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet4.tb_KYCONGCHITIET' table. You can move, or remove it, as needed.
            //this.tb_KYCONGCHITIETTableAdapter.Fill(this.qLNHANSUDataSet4.tb_KYCONGCHITIET);
            _kcct = new KYCONGCHITIET();
            _kc = new KYCONG();
            _nv = new NHANVIEN();
            _nvct = new BANGCONG_NHANVIEN_CT();
            cboNam.Text = _nam.ToString();
            cboThang.Text = _thang.ToString();
            dataGridView1.ReadOnly = true;
            RefreshDataGrid();
        }

        private void btnXemBangCong_Click(object sender, EventArgs e)
        {
            frmBangCongChiTiet frm = new frmBangCongChiTiet();
            frm._idct = 0;
            frm._makycong = _makycong;
            frm._nam = int.Parse(cboNam.Text);
            frm._thang = int.Parse(cboThang.Text);
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

    

        private void btnPhatSinh_Click(object sender, EventArgs e)
        {
            if(_kc.check(_makycong) == true)
            {
                MessageBox.Show("Kỳ công đã phát sinh" , "Thông báo");
                return;
            }
            List<tb_NHANVIEN> lstNv = _nv.getList();
            foreach(var item in lstNv)
            {
                for(int i = 1; i <= Function.laySoNgayCuaThang(int.Parse(cboNam.Text) , int.Parse(cboThang.Text)) ; i++){
                    tb_NHANVIEN_CHITIET nv = new tb_NHANVIEN_CHITIET();
                    nv.MANV = item.MANV;
                    nv.IDCT = item.IDCT;
                    nv.HOTEN = item.HOTEN;
                    nv.GIORA = "17:00";
                    nv.GIOVAO = "8:00";
                    nv.NGAY = DateTime.Parse(cboNam.Text + "-" + cboThang.Text + "-" + i.ToString());
                    nv.THU = Function.layThuTrongTuan(int.Parse(cboNam.Text), int.Parse(cboThang.Text), i);
                    nv.NGAYPHEP = 0;
                    nv.CONGNGAYLE = 0;
                    nv.CONGCHUNHAT = 0;
                    if(nv.THU == "Chủ nhật")
                    {
                        nv.KYHIEU = "CN";
                        nv.NGAYCONG = 0;
                    }
                    else
                    {
                        nv.KYHIEU = "X";
                        nv.NGAYCONG = 1;
                    }
                    nv.MAKYCONG = _makycong;
                    nv.CREATED_BY = 1;
                    nv.CREATED_DATE = DateTime.Now;
                    _nvct.Add(nv); 
                }
            }
            _kcct.phatSinhKyCong(_idct, _thang, _nam);
            _kcct.getList(_makycong);
            var kc = _kc.getItem(_makycong);
            kc.TRANGTHAI = true;
            _kc.Edit(kc);
            RefreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải hàng hợp lệ không
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //_makycong = int.Parse(row.Cells[0].ToString());
            }
        }

        private void mnCapNhatNgayCong_Click(object sender, EventArgs e)
        {
            frmCapNhatNgayCong frm = new frmCapNhatNgayCong();
            //frm._makycong = _makycong;
            //frm._manv = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            ////frm._hoten = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //frm._ngay = int.Parse(dataGridView1.CurrentRow.Cells["NGAY"].Value.ToString());
            frm.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmLoadBangCongTopHopReport frm = new frmLoadBangCongTopHopReport(_makycong);
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ngay = e.ColumnIndex - 1; // Suy ra ngày từ chỉ số cột
            frmCapNhatNgayCong frm = new frmCapNhatNgayCong();

            frm._makycong = _makycong;
            frm._manv = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm._ngay = ngay;
            frm._hoten = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }
    }
}
