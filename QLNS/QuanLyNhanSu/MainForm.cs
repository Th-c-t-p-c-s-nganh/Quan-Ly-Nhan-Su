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
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmNhanVien));
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmHopDongLaoDong));
        }

        private void btnKTKL_Click(object sender, EventArgs e)
        {
            openForm(typeof(frmKhenThuongKyLuat));
        }
    }
}
