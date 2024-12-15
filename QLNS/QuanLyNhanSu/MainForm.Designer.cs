namespace QuanLyNhanSu
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaoLuuMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKhoiPhucDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDanToc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTonGiao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTrinhDo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKTKL = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDieuChuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoaiCa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoaiCong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBangCong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhuCap = new System.Windows.Forms.ToolStripMenuItem();
            this.frmBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhanSu,
            this.nhânSựToolStripMenuItem,
            this.chấmCôngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDoiMatKhau,
            this.btnSaoLuuMatKhau,
            this.btnKhoiPhucDuLieu});
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(85, 24);
            this.btnNhanSu.Text = "Hệ thống";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(224, 26);
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnSaoLuuMatKhau
            // 
            this.btnSaoLuuMatKhau.Name = "btnSaoLuuMatKhau";
            this.btnSaoLuuMatKhau.Size = new System.Drawing.Size(224, 26);
            this.btnSaoLuuMatKhau.Text = "Sao lưu dữ liệu";
            // 
            // btnKhoiPhucDuLieu
            // 
            this.btnKhoiPhucDuLieu.Name = "btnKhoiPhucDuLieu";
            this.btnKhoiPhucDuLieu.Size = new System.Drawing.Size(224, 26);
            this.btnKhoiPhucDuLieu.Text = "Khôi phục dữ liệu";
            // 
            // nhânSựToolStripMenuItem
            // 
            this.nhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnPhongBan,
            this.btnChucVu,
            this.btnBoPhan,
            this.btnNhanVien,
            this.btnHopDong,
            this.btnKTKL,
            this.btnDieuChuyen});
            this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            this.nhânSựToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.nhânSựToolStripMenuItem.Text = "Nhân sự";
            // 
            // btnDanToc
            // 
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.Size = new System.Drawing.Size(228, 26);
            this.btnDanToc.Text = "Dân tộc";
            this.btnDanToc.Click += new System.EventHandler(this.btnDanToc_Click);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.Size = new System.Drawing.Size(228, 26);
            this.btnTonGiao.Text = "Tôn giáo";
            this.btnTonGiao.Click += new System.EventHandler(this.btnTonGiao_Click);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.Size = new System.Drawing.Size(228, 26);
            this.btnTrinhDo.Text = "Trình độ";
            this.btnTrinhDo.Click += new System.EventHandler(this.btnTrinhDo_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(228, 26);
            this.btnPhongBan.Text = "Phòng ban";
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(228, 26);
            this.btnChucVu.Text = "Chức vụ";
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.Size = new System.Drawing.Size(228, 26);
            this.btnBoPhan.Text = "Bộ phận";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(228, 26);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(228, 26);
            this.btnHopDong.Text = "Hợp đồng";
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnKTKL
            // 
            this.btnKTKL.Name = "btnKTKL";
            this.btnKTKL.Size = new System.Drawing.Size(228, 26);
            this.btnKTKL.Text = "Thi đua khen thưởng";
            this.btnKTKL.Click += new System.EventHandler(this.btnKTKL_Click);
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.Size = new System.Drawing.Size(228, 26);
            this.btnDieuChuyen.Text = "Điều chuyển";
            this.btnDieuChuyen.Click += new System.EventHandler(this.btnDieuChuyen_Click);
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoaiCa,
            this.btnLoaiCong,
            this.btnBangCong,
            this.btnPhuCap,
            this.frmBangLuong});
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.chấmCôngToolStripMenuItem.Text = "Chấm công";
            // 
            // btnLoaiCa
            // 
            this.btnLoaiCa.Name = "btnLoaiCa";
            this.btnLoaiCa.Size = new System.Drawing.Size(169, 26);
            this.btnLoaiCa.Text = "Loại ca";
            this.btnLoaiCa.Click += new System.EventHandler(this.btnLoaiCa_Click);
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Name = "btnLoaiCong";
            this.btnLoaiCong.Size = new System.Drawing.Size(169, 26);
            this.btnLoaiCong.Text = "Loại công";
            this.btnLoaiCong.Click += new System.EventHandler(this.btnLoaiCong_Click);
            // 
            // btnBangCong
            // 
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.Size = new System.Drawing.Size(169, 26);
            this.btnBangCong.Text = "Bảng công";
            this.btnBangCong.Click += new System.EventHandler(this.btnBangCong_Click);
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.Size = new System.Drawing.Size(169, 26);
            this.btnPhuCap.Text = "Phụ cấp";
            this.btnPhuCap.Click += new System.EventHandler(this.btnPhuCap_Click);
            // 
            // frmBangLuong
            // 
            this.frmBangLuong.Name = "frmBangLuong";
            this.frmBangLuong.Size = new System.Drawing.Size(169, 26);
            this.frmBangLuong.Text = "Bảng lương";
            this.frmBangLuong.Click += new System.EventHandler(this.frmBangLuong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.phan_mem_quan_ly_nhan_su;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý nhân sự công ty MISA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNhanSu;
        private System.Windows.Forms.ToolStripMenuItem btnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem btnSaoLuuMatKhau;
        private System.Windows.Forms.ToolStripMenuItem btnKhoiPhucDuLieu;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDanToc;
        private System.Windows.Forms.ToolStripMenuItem btnTonGiao;
        private System.Windows.Forms.ToolStripMenuItem btnTrinhDo;
        private System.Windows.Forms.ToolStripMenuItem btnPhongBan;
        private System.Windows.Forms.ToolStripMenuItem btnChucVu;
        private System.Windows.Forms.ToolStripMenuItem btnBoPhan;
        private System.Windows.Forms.ToolStripMenuItem btnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnHopDong;
        private System.Windows.Forms.ToolStripMenuItem btnKTKL;
        private System.Windows.Forms.ToolStripMenuItem btnDieuChuyen;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLoaiCa;
        private System.Windows.Forms.ToolStripMenuItem btnLoaiCong;
        private System.Windows.Forms.ToolStripMenuItem btnBangCong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnPhuCap;
        private System.Windows.Forms.ToolStripMenuItem frmBangLuong;
    }
}

