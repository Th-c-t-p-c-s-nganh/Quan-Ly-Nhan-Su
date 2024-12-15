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
            if (Properties.Settings.Default.LuuMatKhau)
            {
                txtTDN.Text = Properties.Settings.Default.TenDangNhap;
                txtPW.Text = Properties.Settings.Default.MatKhau;
                cboxLuuMK.Checked = true;
            }
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
                if (cboxLuuMK.Checked)
                {
                    Properties.Settings.Default.TenDangNhap = tdn;
                    Properties.Settings.Default.MatKhau = pw;
                    Properties.Settings.Default.LuuMatKhau = true;
                }
                else
                {
                    Properties.Settings.Default.TenDangNhap = string.Empty;
                    Properties.Settings.Default.MatKhau = string.Empty;
                    Properties.Settings.Default.LuuMatKhau = false;
                }

                Properties.Settings.Default.Save();
                openForm(typeof(MainForm));   
                //this.Hide();
            }

        }

        private void cboxLuuMK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
