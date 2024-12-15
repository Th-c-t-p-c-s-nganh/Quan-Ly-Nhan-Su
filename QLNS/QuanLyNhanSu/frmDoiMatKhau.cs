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

namespace QuanLyNhanSu
{
    public partial class frmDoiMatKhau : Form
    {
        TAIKHOAN tk;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMKcu.UseSystemPasswordChar = true;
            txtMKmoi.UseSystemPasswordChar = true;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            tk = new TAIKHOAN();
            var tdn = txtTaiKhoan.Text;
            var pw = txtMKcu.Text;
            var pw2 = txtMKmoi.Text;
            if (tk.DangNhap(tdn, pw) == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var taiKhoan = tk.getItem(tdn);
                taiKhoan.MATKHAU = txtMKmoi.Text;
                tk.Edit(taiKhoan);
                MessageBox.Show("Cập nhật thành công ! " , "Thông báo" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
