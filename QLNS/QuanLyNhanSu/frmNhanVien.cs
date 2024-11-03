using BusinessLayer.DTO;
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
using System.IO;
using QuanLyNhanSu.ReportForm;

namespace QuanLyNhanSu
{
    public partial class frmNhanVien : Form
    {
        NHANVIEN _NHANVIEN;
        PHONGBAN _phongban;
        BOPHAN _bophan;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        TRINHDO _trinhdo;
        CHUCVU _chucvu;
        bool _them;
        int _id;
        public frmNhanVien()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            txtName.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtSDT.Enabled = !kt;
            cboxGT.Enabled = !kt;
            frmHinhAnh.Enabled = !kt;
            cboBoPhan.Enabled = !kt;
            cbPhongBan.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            btnChonAnh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet1.tb_NHANVIEN' table. You can move, or remove it, as needed.
            _them = false;
            _NHANVIEN = new NHANVIEN();
            _bophan = new BOPHAN();
            _chucvu = new CHUCVU();
            _tongiao = new TONGIAO();
            _dantoc = new DANTOC();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            LoadCombo();
            _showHide(true);
            this.tb_NHANVIENTableAdapter.Fill(this.qLNHANSUDataSet1.tb_NHANVIEN);
        
        }

        void openForm(Type type)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == type)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(type);
            f.Show();
        }

        void RefreshDataGrid()
        {
            var data = _NHANVIEN.getFullList();
            tbNHANVIENBindingSource.DataSource = data;
            dataGridView1.DataSource = tbNHANVIENBindingSource;
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
            RefreshDataGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _NHANVIEN.Delete(_id);
            }
            RefreshDataGrid();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            RefreshDataGrid();
            _them = false;
            _showHide(true);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmNhanVienReport));
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

        void LoadCombo()
        {
            cboBoPhan.DataSource = _bophan.getList();
            cboBoPhan.DisplayMember = "TENBP";
            cboBoPhan.ValueMember = "IDBP";

            cbPhongBan.DataSource = _phongban.getList();
            cbPhongBan.DisplayMember = "TENPB";
            cbPhongBan.ValueMember = "IDPB";

            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "IDCV";

            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TENDT";
            cboDanToc.ValueMember = "IDDT";

            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TENTG";
            cboTonGiao.ValueMember = "IDTG";

            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TENTD";
            cboTrinhDo.ValueMember = "IDTD";
        }

        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN dt = new tb_NHANVIEN();
                dt.HOTEN = txtName.Text;
                dt.NGAYSINH = dtNgaySinh.Value;
                dt.GIOITINH = cboxGT.Checked;
                dt.CCCD = txtCCCD.Text;
                dt.DIENTHOAI = txtSDT.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.HINHANH = ImageToBase64(frmHinhAnh.Image, frmHinhAnh.Image.RawFormat);
                dt.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                dt.IDCT = 0;
                dt.IDPB = int.Parse(cbPhongBan.SelectedValue.ToString());
                dt.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                dt.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                dt.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                dt.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                _NHANVIEN.Add(dt);
            }
            else
            {
                var dt = _NHANVIEN.getItem(_id);
                dt.HOTEN = txtName.Text;
                dt.GIOITINH = cboxGT.Checked;
                dt.NGAYSINH = dtNgaySinh.Value;
                dt.CCCD = txtCCCD.Text;
                dt.DIENTHOAI = txtSDT.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.HINHANH = ImageToBase64(frmHinhAnh.Image, frmHinhAnh.Image.RawFormat);
                dt.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                dt.IDCT = 0;
                dt.IDPB = int.Parse(cbPhongBan.SelectedValue.ToString());
                dt.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                dt.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                dt.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                dt.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                _NHANVIEN.Edit(dt);
            }
        }
        void reset()
        {
            txtCCCD.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            cboxGT.Checked = false;
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] img = ms.ToArray();

                return img;
            }
        }

        public Image Base64ToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data, 0, data.Length);
            ms.Write(data, 0, data.Length);
            Image img = Image.FromStream(ms, true);
            return img;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture file(.png , .jgp)| *.png; *.jgp";
            ofd.Title = "Chọn hình ảnh";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                frmHinhAnh.Image = Image.FromFile(ofd.FileName);
                frmHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _id = Convert.ToInt32(row.Cells[0].Value); 

                txtName.Text = row.Cells[1].Value?.ToString(); 
                cboxGT.Checked = row.Cells[3].Value is bool ? (bool)row.Cells[3].Value : false; 
                dtNgaySinh.Value = row.Cells[4].Value is DateTime ? (DateTime)row.Cells[4].Value : DateTime.Now; 
                txtCCCD.Text = row.Cells[6].Value?.ToString(); 
                txtSDT.Text = row.Cells[5].Value?.ToString(); 
                txtDiaChi.Text = row.Cells[7].Value?.ToString(); 

                if (row.Cells[2].Value != null)
                {
                    if (row.Cells[2].Value is byte[] imgData) 
                    {
                        frmHinhAnh.Image = Base64ToImage(imgData);
                    }
                }
            }
        }

    }
}
