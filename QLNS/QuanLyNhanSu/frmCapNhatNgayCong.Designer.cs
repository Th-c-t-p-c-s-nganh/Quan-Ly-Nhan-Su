namespace QuanLyNhanSu
{
    partial class frmCapNhatNgayCong
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cldNgayCong = new System.Windows.Forms.MonthCalendar();
            this.grpChamCong = new System.Windows.Forms.GroupBox();
            this.rdCT = new System.Windows.Forms.RadioButton();
            this.rdViecRieng = new System.Windows.Forms.RadioButton();
            this.rpVang = new System.Windows.Forms.RadioButton();
            this.rdNghiPhep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNguyenNgay = new System.Windows.Forms.RadioButton();
            this.rdChieu = new System.Windows.Forms.RadioButton();
            this.rdSang = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChamCong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(442, 284);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 40);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cldNgayCong
            // 
            this.cldNgayCong.Location = new System.Drawing.Point(64, 38);
            this.cldNgayCong.Name = "cldNgayCong";
            this.cldNgayCong.TabIndex = 1;
            this.cldNgayCong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldNgayCong_DateSelected);
            // 
            // grpChamCong
            // 
            this.grpChamCong.Controls.Add(this.rdCT);
            this.grpChamCong.Controls.Add(this.rdViecRieng);
            this.grpChamCong.Controls.Add(this.rpVang);
            this.grpChamCong.Controls.Add(this.rdNghiPhep);
            this.grpChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChamCong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpChamCong.Location = new System.Drawing.Point(405, 38);
            this.grpChamCong.Name = "grpChamCong";
            this.grpChamCong.Size = new System.Drawing.Size(135, 165);
            this.grpChamCong.TabIndex = 2;
            this.grpChamCong.TabStop = false;
            this.grpChamCong.Text = "Chấm công";
            this.grpChamCong.Enter += new System.EventHandler(this.grpChamCong_Enter);
            // 
            // rdCT
            // 
            this.rdCT.AutoSize = true;
            this.rdCT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdCT.Location = new System.Drawing.Point(7, 139);
            this.rdCT.Name = "rdCT";
            this.rdCT.Size = new System.Drawing.Size(89, 20);
            this.rdCT.TabIndex = 3;
            this.rdCT.TabStop = true;
            this.rdCT.Text = "Công tác";
            this.rdCT.UseVisualStyleBackColor = true;
            this.rdCT.CheckedChanged += new System.EventHandler(this.rdCT_CheckedChanged);
            // 
            // rdViecRieng
            // 
            this.rdViecRieng.AutoSize = true;
            this.rdViecRieng.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdViecRieng.Location = new System.Drawing.Point(6, 107);
            this.rdViecRieng.Name = "rdViecRieng";
            this.rdViecRieng.Size = new System.Drawing.Size(98, 20);
            this.rdViecRieng.TabIndex = 2;
            this.rdViecRieng.TabStop = true;
            this.rdViecRieng.Text = "Việc riêng";
            this.rdViecRieng.UseVisualStyleBackColor = true;
            this.rdViecRieng.CheckedChanged += new System.EventHandler(this.rdViecRieng_CheckedChanged);
            // 
            // rpVang
            // 
            this.rpVang.AutoSize = true;
            this.rpVang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rpVang.Location = new System.Drawing.Point(6, 69);
            this.rpVang.Name = "rpVang";
            this.rpVang.Size = new System.Drawing.Size(64, 20);
            this.rpVang.TabIndex = 1;
            this.rpVang.TabStop = true;
            this.rpVang.Text = "Vắng";
            this.rpVang.UseVisualStyleBackColor = true;
            this.rpVang.CheckedChanged += new System.EventHandler(this.rpVang_CheckedChanged);
            // 
            // rdNghiPhep
            // 
            this.rdNghiPhep.AutoSize = true;
            this.rdNghiPhep.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdNghiPhep.Location = new System.Drawing.Point(6, 31);
            this.rdNghiPhep.Name = "rdNghiPhep";
            this.rdNghiPhep.Size = new System.Drawing.Size(99, 20);
            this.rdNghiPhep.TabIndex = 0;
            this.rdNghiPhep.TabStop = true;
            this.rdNghiPhep.Text = "Nghỉ phép";
            this.rdNghiPhep.UseVisualStyleBackColor = true;
            this.rdNghiPhep.CheckedChanged += new System.EventHandler(this.rdNghiPhep_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNguyenNgay);
            this.groupBox1.Controls.Add(this.rdChieu);
            this.groupBox1.Controls.Add(this.rdSang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(590, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian nghỉ";
            // 
            // rdNguyenNgay
            // 
            this.rdNguyenNgay.AutoSize = true;
            this.rdNguyenNgay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdNguyenNgay.Location = new System.Drawing.Point(9, 101);
            this.rdNguyenNgay.Name = "rdNguyenNgay";
            this.rdNguyenNgay.Size = new System.Drawing.Size(119, 20);
            this.rdNguyenNgay.TabIndex = 2;
            this.rdNguyenNgay.TabStop = true;
            this.rdNguyenNgay.Text = "Nguyên ngày";
            this.rdNguyenNgay.UseVisualStyleBackColor = true;
            this.rdNguyenNgay.CheckedChanged += new System.EventHandler(this.rdNguyenNgay_CheckedChanged);
            // 
            // rdChieu
            // 
            this.rdChieu.AutoSize = true;
            this.rdChieu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdChieu.Location = new System.Drawing.Point(9, 69);
            this.rdChieu.Name = "rdChieu";
            this.rdChieu.Size = new System.Drawing.Size(67, 20);
            this.rdChieu.TabIndex = 1;
            this.rdChieu.TabStop = true;
            this.rdChieu.Text = "Chiều";
            this.rdChieu.UseVisualStyleBackColor = true;
            this.rdChieu.CheckedChanged += new System.EventHandler(this.rdChieu_CheckedChanged);
            // 
            // rdSang
            // 
            this.rdSang.AutoSize = true;
            this.rdSang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdSang.Location = new System.Drawing.Point(9, 31);
            this.rdSang.Name = "rdSang";
            this.rdSang.Size = new System.Drawing.Size(64, 20);
            this.rdSang.TabIndex = 0;
            this.rdSang.TabStop = true;
            this.rdSang.Text = "Sáng";
            this.rdSang.UseVisualStyleBackColor = true;
            this.rdSang.CheckedChanged += new System.EventHandler(this.rdSang_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(590, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.lbID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(64, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbHoTen.Location = new System.Drawing.Point(111, 65);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(73, 20);
            this.lbHoTen.TabIndex = 9;
            this.lbHoTen.Text = "HOTEN";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbID.Location = new System.Drawing.Point(111, 33);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(53, 20);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "IDNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID : ";
            // 
            // frmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpChamCong);
            this.Controls.Add(this.cldNgayCong);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "frmCapNhatNgayCong";
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.frmCapNhatNgayCong_Load);
            this.grpChamCong.ResumeLayout(false);
            this.grpChamCong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.MonthCalendar cldNgayCong;
        private System.Windows.Forms.GroupBox grpChamCong;
        private System.Windows.Forms.RadioButton rdViecRieng;
        private System.Windows.Forms.RadioButton rpVang;
        private System.Windows.Forms.RadioButton rdNghiPhep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNguyenNgay;
        private System.Windows.Forms.RadioButton rdChieu;
        private System.Windows.Forms.RadioButton rdSang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdCT;
    }
}