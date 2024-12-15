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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
        private void btnDanToc_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmDanToc));
            this.Close();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmTonGiao));
            this.Close();
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmTrinhDo));
            this.Close();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmPhongBan));
            this.Close();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmChucVu));
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmNhanVien));
            this.Close();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmHopDongLaoDong));
            this.Close();
        }

        private void btnKTKL_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmKhenThuongKyLuat));
            this.Close();
        }

        private void btnDieuChuyen_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmDieuChuyen));
            this.Close();
        }

        private void btnLoaiCa_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmLoaiCa));
            this.Close();
        }

        private void btnLoaiCong_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmLoaiCong));
            this.Close();
        }

        private void btnBangCong_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmBangCong));
            this.Close();
        }

        private void btnBangCongChiTiet_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmBangCongChiTiet));
            this.Close();
        }

        private void btnPhuCap_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmPhuCap));
            this.Close();
        }

        private void frmBangLuong_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmBangLuong));
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmDoiMatKhau));
            this.Close();
        }
    }
}
