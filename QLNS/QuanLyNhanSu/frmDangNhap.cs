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
    public partial class frmDangNhap : Form
    {
        TAIKHOAN tk;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tk = new TAIKHOAN();
            var tdn = txtTDN.Text;
            var pw = txtPW.Text;
            if(tk.DangNhap(tdn, pw) == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng" , "Thông Báo" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                openForm(typeof(MainForm));   
            }
        }

        private void txtTDN_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
