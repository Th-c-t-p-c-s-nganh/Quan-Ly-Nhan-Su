namespace QuanLyNhanSu
{
    partial class frmBangCong
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.CheckBox();
            this.cboKhoa = new System.Windows.Forms.CheckBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXemBangCong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAKYCONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHOADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nGAYTINHCONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbKYCONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet5 = new QuanLyNhanSu.QLNHANSUDataSet5();
            this.tbKYCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet4 = new QuanLyNhanSu.QLNHANSUDataSet4();
            this.tb_KYCONGTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet4TableAdapters.tb_KYCONGTableAdapter();
            this.tb_KYCONGTableAdapter1 = new QuanLyNhanSu.QLNHANSUDataSet5TableAdapters.tb_KYCONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKYCONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKYCONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.cboTrangThai);
            this.splitContainer1.Panel1.Controls.Add(this.cboKhoa);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXemBangCong);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(621, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 78;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.AutoSize = true;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTrangThai.Location = new System.Drawing.Point(557, 73);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(106, 24);
            this.cboTrangThai.TabIndex = 77;
            this.cboTrangThai.Text = "Trạng thái";
            this.cboTrangThai.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            this.cboKhoa.AutoSize = true;
            this.cboKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboKhoa.Location = new System.Drawing.Point(722, 73);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(69, 24);
            this.cboKhoa.TabIndex = 76;
            this.cboKhoa.Text = "Khoá";
            this.cboKhoa.UseVisualStyleBackColor = true;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(365, 70);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(96, 24);
            this.cboThang.TabIndex = 75;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboNam.Location = new System.Drawing.Point(105, 70);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(109, 24);
            this.cboNam.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(303, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Năm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(247, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 71;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXemBangCong
            // 
            this.btnXemBangCong.Location = new System.Drawing.Point(490, 3);
            this.btnXemBangCong.Name = "btnXemBangCong";
            this.btnXemBangCong.Size = new System.Drawing.Size(125, 23);
            this.btnXemBangCong.TabIndex = 70;
            this.btnXemBangCong.Text = "Xem bảng công";
            this.btnXemBangCong.UseVisualStyleBackColor = true;
            this.btnXemBangCong.Click += new System.EventHandler(this.btnXemBangCong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(409, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 69;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(328, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 68;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(166, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(85, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKYCONGDataGridViewTextBoxColumn,
            this.tHANGDataGridViewTextBoxColumn,
            this.nAMDataGridViewTextBoxColumn,
            this.kHOADataGridViewCheckBoxColumn,
            this.nGAYTINHCONGDataGridViewTextBoxColumn,
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn,
            this.iDCTDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tbKYCONGBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // mAKYCONGDataGridViewTextBoxColumn
            // 
            this.mAKYCONGDataGridViewTextBoxColumn.DataPropertyName = "MAKYCONG";
            this.mAKYCONGDataGridViewTextBoxColumn.HeaderText = "MAKYCONG";
            this.mAKYCONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKYCONGDataGridViewTextBoxColumn.Name = "mAKYCONGDataGridViewTextBoxColumn";
            this.mAKYCONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // tHANGDataGridViewTextBoxColumn
            // 
            this.tHANGDataGridViewTextBoxColumn.DataPropertyName = "THANG";
            this.tHANGDataGridViewTextBoxColumn.HeaderText = "THANG";
            this.tHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHANGDataGridViewTextBoxColumn.Name = "tHANGDataGridViewTextBoxColumn";
            this.tHANGDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMDataGridViewTextBoxColumn
            // 
            this.nAMDataGridViewTextBoxColumn.DataPropertyName = "NAM";
            this.nAMDataGridViewTextBoxColumn.HeaderText = "NAM";
            this.nAMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMDataGridViewTextBoxColumn.Name = "nAMDataGridViewTextBoxColumn";
            this.nAMDataGridViewTextBoxColumn.Width = 125;
            // 
            // kHOADataGridViewCheckBoxColumn
            // 
            this.kHOADataGridViewCheckBoxColumn.DataPropertyName = "KHOA";
            this.kHOADataGridViewCheckBoxColumn.HeaderText = "KHOA";
            this.kHOADataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.kHOADataGridViewCheckBoxColumn.Name = "kHOADataGridViewCheckBoxColumn";
            this.kHOADataGridViewCheckBoxColumn.Width = 125;
            // 
            // nGAYTINHCONGDataGridViewTextBoxColumn
            // 
            this.nGAYTINHCONGDataGridViewTextBoxColumn.DataPropertyName = "NGAYTINHCONG";
            this.nGAYTINHCONGDataGridViewTextBoxColumn.HeaderText = "NGAYTINHCONG";
            this.nGAYTINHCONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYTINHCONGDataGridViewTextBoxColumn.Name = "nGAYTINHCONGDataGridViewTextBoxColumn";
            this.nGAYTINHCONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYCONGTRONGTHANGDataGridViewTextBoxColumn
            // 
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.DataPropertyName = "NGAYCONGTRONGTHANG";
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.HeaderText = "NGAYCONGTRONGTHANG";
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.Name = "nGAYCONGTRONGTHANGDataGridViewTextBoxColumn";
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCTDataGridViewTextBoxColumn
            // 
            this.iDCTDataGridViewTextBoxColumn.DataPropertyName = "IDCT";
            this.iDCTDataGridViewTextBoxColumn.HeaderText = "IDCT";
            this.iDCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCTDataGridViewTextBoxColumn.Name = "iDCTDataGridViewTextBoxColumn";
            this.iDCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tRANGTHAIDataGridViewCheckBoxColumn
            // 
            this.tRANGTHAIDataGridViewCheckBoxColumn.DataPropertyName = "TRANGTHAI";
            this.tRANGTHAIDataGridViewCheckBoxColumn.HeaderText = "TRANGTHAI";
            this.tRANGTHAIDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.tRANGTHAIDataGridViewCheckBoxColumn.Name = "tRANGTHAIDataGridViewCheckBoxColumn";
            this.tRANGTHAIDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tbKYCONGBindingSource1
            // 
            this.tbKYCONGBindingSource1.DataMember = "tb_KYCONG";
            this.tbKYCONGBindingSource1.DataSource = this.qLNHANSUDataSet5;
            // 
            // qLNHANSUDataSet5
            // 
            this.qLNHANSUDataSet5.DataSetName = "QLNHANSUDataSet5";
            this.qLNHANSUDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbKYCONGBindingSource
            // 
            this.tbKYCONGBindingSource.DataMember = "tb_KYCONG";
            this.tbKYCONGBindingSource.DataSource = this.qLNHANSUDataSet4;
            // 
            // qLNHANSUDataSet4
            // 
            this.qLNHANSUDataSet4.DataSetName = "QLNHANSUDataSet4";
            this.qLNHANSUDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_KYCONGTableAdapter
            // 
            this.tb_KYCONGTableAdapter.ClearBeforeFill = true;
            // 
            // tb_KYCONGTableAdapter1
            // 
            this.tb_KYCONGTableAdapter1.ClearBeforeFill = true;
            // 
            // frmBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBangCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Bảng công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frnBangCong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKYCONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKYCONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXemBangCong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboKhoa;
        private QLNHANSUDataSet4 qLNHANSUDataSet4;
        private System.Windows.Forms.BindingSource tbKYCONGBindingSource;
        private QLNHANSUDataSet4TableAdapters.tb_KYCONGTableAdapter tb_KYCONGTableAdapter;
        private System.Windows.Forms.CheckBox cboTrangThai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHANSUDataSet5 qLNHANSUDataSet5;
        private System.Windows.Forms.BindingSource tbKYCONGBindingSource1;
        private QLNHANSUDataSet5TableAdapters.tb_KYCONGTableAdapter tb_KYCONGTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKYCONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kHOADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTINHCONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYCONGTRONGTHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tRANGTHAIDataGridViewCheckBoxColumn;
    }
}