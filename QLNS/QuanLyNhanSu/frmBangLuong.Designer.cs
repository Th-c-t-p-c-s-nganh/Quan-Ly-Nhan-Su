namespace QuanLyNhanSu
{
    partial class frmBangLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.Năm = new System.Windows.Forms.Label();
            this.btnBangCong = new System.Windows.Forms.Button();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKYCONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYPHEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHONGPHEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYCHUNHATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYTHUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tANGCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNGLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHUCAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHUCLANHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBANGLUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet10 = new QuanLyNhanSu.QLNHANSUDataSet10();
            this.tb_BANGLUONGTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet10TableAdapters.tb_BANGLUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBANGLUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet10)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Năm);
            this.splitContainer1.Panel1.Controls.Add(this.btnBangCong);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnTinhLuong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 450);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Năm";
            // 
            // Năm
            // 
            this.Năm.AutoSize = true;
            this.Năm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Năm.Location = new System.Drawing.Point(326, 55);
            this.Năm.Name = "Năm";
            this.Năm.Size = new System.Drawing.Size(55, 20);
            this.Năm.TabIndex = 33;
            this.Năm.Text = "Tháng";
            // 
            // btnBangCong
            // 
            this.btnBangCong.Location = new System.Drawing.Point(630, 47);
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.Size = new System.Drawing.Size(135, 38);
            this.btnBangCong.TabIndex = 32;
            this.btnBangCong.Text = "Xem bảng công";
            this.btnBangCong.UseVisualStyleBackColor = true;
            this.btnBangCong.Click += new System.EventHandler(this.btnBangCong_Click);
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
            this.cboThang.Location = new System.Drawing.Point(390, 55);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 24);
            this.cboThang.TabIndex = 31;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cboNam.Location = new System.Drawing.Point(144, 55);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 24);
            this.cboNam.TabIndex = 30;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(247, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 36);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(144, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(97, 36);
            this.btnIn.TabIndex = 27;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTinhLuong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTinhLuong.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnTinhLuong.Location = new System.Drawing.Point(0, 3);
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(0);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(141, 36);
            this.btnTinhLuong.TabIndex = 26;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mAKYCONGDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn,
            this.nGAYPHEPDataGridViewTextBoxColumn,
            this.kHONGPHEPDataGridViewTextBoxColumn,
            this.nGAYLEDataGridViewTextBoxColumn,
            this.nGAYCHUNHATDataGridViewTextBoxColumn,
            this.nGAYTHUONGDataGridViewTextBoxColumn,
            this.tANGCADataGridViewTextBoxColumn,
            this.uNGLUONGDataGridViewTextBoxColumn,
            this.pHUCAPDataGridViewTextBoxColumn,
            this.tHUCLANHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbBANGLUONGBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAKYCONGDataGridViewTextBoxColumn
            // 
            this.mAKYCONGDataGridViewTextBoxColumn.DataPropertyName = "MAKYCONG";
            this.mAKYCONGDataGridViewTextBoxColumn.HeaderText = "Mã kỳ công";
            this.mAKYCONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKYCONGDataGridViewTextBoxColumn.Name = "mAKYCONGDataGridViewTextBoxColumn";
            this.mAKYCONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Visible = false;
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hOTENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYCONGTRONGTHANGDataGridViewTextBoxColumn
            // 
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.DataPropertyName = "NGAYCONGTRONGTHANG";
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.HeaderText = "Ngày công trong tháng";
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.Name = "nGAYCONGTRONGTHANGDataGridViewTextBoxColumn";
            this.nGAYCONGTRONGTHANGDataGridViewTextBoxColumn.Width = 200;
            // 
            // nGAYPHEPDataGridViewTextBoxColumn
            // 
            this.nGAYPHEPDataGridViewTextBoxColumn.DataPropertyName = "NGAYPHEP";
            this.nGAYPHEPDataGridViewTextBoxColumn.HeaderText = "Công ngày phép";
            this.nGAYPHEPDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nGAYPHEPDataGridViewTextBoxColumn.Name = "nGAYPHEPDataGridViewTextBoxColumn";
            this.nGAYPHEPDataGridViewTextBoxColumn.Width = 200;
            // 
            // kHONGPHEPDataGridViewTextBoxColumn
            // 
            this.kHONGPHEPDataGridViewTextBoxColumn.DataPropertyName = "KHONGPHEP";
            this.kHONGPHEPDataGridViewTextBoxColumn.HeaderText = "Công không phép";
            this.kHONGPHEPDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.kHONGPHEPDataGridViewTextBoxColumn.Name = "kHONGPHEPDataGridViewTextBoxColumn";
            this.kHONGPHEPDataGridViewTextBoxColumn.Width = 200;
            // 
            // nGAYLEDataGridViewTextBoxColumn
            // 
            this.nGAYLEDataGridViewTextBoxColumn.DataPropertyName = "NGAYLE";
            this.nGAYLEDataGridViewTextBoxColumn.HeaderText = "Công ngày lễ";
            this.nGAYLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYLEDataGridViewTextBoxColumn.Name = "nGAYLEDataGridViewTextBoxColumn";
            this.nGAYLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYCHUNHATDataGridViewTextBoxColumn
            // 
            this.nGAYCHUNHATDataGridViewTextBoxColumn.DataPropertyName = "NGAYCHUNHAT";
            this.nGAYCHUNHATDataGridViewTextBoxColumn.HeaderText = "Công ngày CN";
            this.nGAYCHUNHATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYCHUNHATDataGridViewTextBoxColumn.Name = "nGAYCHUNHATDataGridViewTextBoxColumn";
            this.nGAYCHUNHATDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYTHUONGDataGridViewTextBoxColumn
            // 
            this.nGAYTHUONGDataGridViewTextBoxColumn.DataPropertyName = "NGAYTHUONG";
            this.nGAYTHUONGDataGridViewTextBoxColumn.HeaderText = "Ngày thường";
            this.nGAYTHUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYTHUONGDataGridViewTextBoxColumn.Name = "nGAYTHUONGDataGridViewTextBoxColumn";
            this.nGAYTHUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // tANGCADataGridViewTextBoxColumn
            // 
            this.tANGCADataGridViewTextBoxColumn.DataPropertyName = "TANGCA";
            this.tANGCADataGridViewTextBoxColumn.HeaderText = "Tăng ca";
            this.tANGCADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tANGCADataGridViewTextBoxColumn.Name = "tANGCADataGridViewTextBoxColumn";
            this.tANGCADataGridViewTextBoxColumn.Width = 125;
            // 
            // uNGLUONGDataGridViewTextBoxColumn
            // 
            this.uNGLUONGDataGridViewTextBoxColumn.DataPropertyName = "UNGLUONG";
            this.uNGLUONGDataGridViewTextBoxColumn.HeaderText = "Ứng lương";
            this.uNGLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNGLUONGDataGridViewTextBoxColumn.Name = "uNGLUONGDataGridViewTextBoxColumn";
            this.uNGLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHUCAPDataGridViewTextBoxColumn
            // 
            this.pHUCAPDataGridViewTextBoxColumn.DataPropertyName = "PHUCAP";
            this.pHUCAPDataGridViewTextBoxColumn.HeaderText = "Phụ cấp";
            this.pHUCAPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHUCAPDataGridViewTextBoxColumn.Name = "pHUCAPDataGridViewTextBoxColumn";
            this.pHUCAPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tHUCLANHDataGridViewTextBoxColumn
            // 
            this.tHUCLANHDataGridViewTextBoxColumn.DataPropertyName = "THUCLANH";
            this.tHUCLANHDataGridViewTextBoxColumn.HeaderText = "Thực lãnh";
            this.tHUCLANHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHUCLANHDataGridViewTextBoxColumn.Name = "tHUCLANHDataGridViewTextBoxColumn";
            this.tHUCLANHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbBANGLUONGBindingSource
            // 
            this.tbBANGLUONGBindingSource.DataMember = "tb_BANGLUONG";
            this.tbBANGLUONGBindingSource.DataSource = this.qLNHANSUDataSet10;
            // 
            // qLNHANSUDataSet10
            // 
            this.qLNHANSUDataSet10.DataSetName = "QLNHANSUDataSet10";
            this.qLNHANSUDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_BANGLUONGTableAdapter
            // 
            this.tb_BANGLUONGTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBangLuong";
            this.Text = "Bảng lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBANGLUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBangCong;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Năm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHANSUDataSet10 qLNHANSUDataSet10;
        private System.Windows.Forms.BindingSource tbBANGLUONGBindingSource;
        private QLNHANSUDataSet10TableAdapters.tb_BANGLUONGTableAdapter tb_BANGLUONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKYCONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYCONGTRONGTHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYPHEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kHONGPHEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYCHUNHATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTHUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tANGCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNGLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHUCAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHUCLANHDataGridViewTextBoxColumn;
    }
}