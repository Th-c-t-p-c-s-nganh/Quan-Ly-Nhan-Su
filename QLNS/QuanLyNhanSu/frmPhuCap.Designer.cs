namespace QuanLyNhanSu
{
    partial class frmPhuCap
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhuCap = new System.Windows.Forms.ComboBox();
            this.tbPHUCAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet9 = new QuanLyNhanSu.QLNHANSUDataSet9();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.tbNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet1 = new QuanLyNhanSu.QLNHANSUDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNHANVIENPHUCAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbPHUCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PHUCAPTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet1TableAdapters.tb_PHUCAPTableAdapter();
            this.tb_PHUCAPTableAdapter1 = new QuanLyNhanSu.QLNHANSUDataSet9TableAdapters.tb_PHUCAPTableAdapter();
            this.tbNHANVIENPHUCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_NHANVIEN_PHUCAPTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet9TableAdapters.tb_NHANVIEN_PHUCAPTableAdapter();
            this.tb_NHANVIENTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet1TableAdapters.tb_NHANVIENTableAdapter();
            this.qLNHANSUDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOIDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPHUCAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENPHUCAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPHUCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENPHUCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1BindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoTien);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cboPhuCap);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cboNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(906, 421);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(112, 116);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(764, 27);
            this.txtGhiChu.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ghi chú";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(695, 57);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(181, 27);
            this.txtSoTien.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(619, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "Số tiền";
            // 
            // cboPhuCap
            // 
            this.cboPhuCap.DataSource = this.tbPHUCAPBindingSource1;
            this.cboPhuCap.DisplayMember = "TENPC";
            this.cboPhuCap.FormattingEnabled = true;
            this.cboPhuCap.Location = new System.Drawing.Point(406, 56);
            this.cboPhuCap.Name = "cboPhuCap";
            this.cboPhuCap.Size = new System.Drawing.Size(179, 24);
            this.cboPhuCap.TabIndex = 75;
            this.cboPhuCap.ValueMember = "IDPC";
            // 
            // tbPHUCAPBindingSource1
            // 
            this.tbPHUCAPBindingSource1.DataMember = "tb_PHUCAP";
            this.tbPHUCAPBindingSource1.DataSource = this.qLNHANSUDataSet9;
            // 
            // qLNHANSUDataSet9
            // 
            this.qLNHANSUDataSet9.DataSetName = "QLNHANSUDataSet9";
            this.qLNHANSUDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(332, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Phụ cấp";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DataSource = this.tbNHANVIENBindingSource;
            this.cboNhanVien.DisplayMember = "HOTEN";
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(117, 56);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(179, 24);
            this.cboNhanVien.TabIndex = 73;
            this.cboNhanVien.ValueMember = "MANV";
            // 
            // tbNHANVIENBindingSource
            // 
            this.tbNHANVIENBindingSource.DataMember = "tb_NHANVIEN";
            this.tbNHANVIENBindingSource.DataSource = this.qLNHANSUDataSet1;
            // 
            // qLNHANSUDataSet1
            // 
            this.qLNHANSUDataSet1.DataSetName = "QLNHANSUDataSet1";
            this.qLNHANSUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(28, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 72;
            this.label7.Text = "Nhân viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(247, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 39);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(490, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 39);
            this.btnDong.TabIndex = 36;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(409, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 39);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(328, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(81, 39);
            this.btnIn.TabIndex = 34;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(166, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 39);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(85, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 39);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 39);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MANV,
            this.IDPC,
            this.NGAY,
            this.NOIDUNG,
            this.SOTIEN,
            this.iDDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.iDPCDataGridViewTextBoxColumn,
            this.nGAYDataGridViewTextBoxColumn,
            this.nOIDUNGDataGridViewTextBoxColumn,
            this.sOTIENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbNHANVIENPHUCAPBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // IDPC
            // 
            this.IDPC.DataPropertyName = "IDPC";
            this.IDPC.HeaderText = "IDPC";
            this.IDPC.MinimumWidth = 6;
            this.IDPC.Name = "IDPC";
            this.IDPC.Width = 125;
            // 
            // NGAY
            // 
            this.NGAY.DataPropertyName = "NGAY";
            this.NGAY.HeaderText = "NGAY";
            this.NGAY.MinimumWidth = 6;
            this.NGAY.Name = "NGAY";
            this.NGAY.Width = 125;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "NOIDUNG";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 125;
            // 
            // SOTIEN
            // 
            this.SOTIEN.DataPropertyName = "SOTIEN";
            this.SOTIEN.HeaderText = "SOTIEN";
            this.SOTIEN.MinimumWidth = 6;
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.Width = 125;
            // 
            // tbNHANVIENPHUCAPBindingSource1
            // 
            this.tbNHANVIENPHUCAPBindingSource1.DataMember = "tb_NHANVIEN_PHUCAP";
            this.tbNHANVIENPHUCAPBindingSource1.DataSource = this.qLNHANSUDataSet9;
            // 
            // tbPHUCAPBindingSource
            // 
            this.tbPHUCAPBindingSource.DataMember = "tb_PHUCAP";
            this.tbPHUCAPBindingSource.DataSource = this.qLNHANSUDataSet1;
            // 
            // tb_PHUCAPTableAdapter
            // 
            this.tb_PHUCAPTableAdapter.ClearBeforeFill = true;
            // 
            // tb_PHUCAPTableAdapter1
            // 
            this.tb_PHUCAPTableAdapter1.ClearBeforeFill = true;
            // 
            // tbNHANVIENPHUCAPBindingSource
            // 
            this.tbNHANVIENPHUCAPBindingSource.DataMember = "tb_NHANVIEN_PHUCAP";
            this.tbNHANVIENPHUCAPBindingSource.DataSource = this.qLNHANSUDataSet9;
            // 
            // tb_NHANVIEN_PHUCAPTableAdapter
            // 
            this.tb_NHANVIEN_PHUCAPTableAdapter.ClearBeforeFill = true;
            // 
            // tb_NHANVIENTableAdapter
            // 
            this.tb_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // qLNHANSUDataSet1BindingSource
            // 
            this.qLNHANSUDataSet1BindingSource.DataSource = this.qLNHANSUDataSet1;
            this.qLNHANSUDataSet1BindingSource.Position = 0;
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
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPCDataGridViewTextBoxColumn
            // 
            this.iDPCDataGridViewTextBoxColumn.DataPropertyName = "IDPC";
            this.iDPCDataGridViewTextBoxColumn.HeaderText = "IDPC";
            this.iDPCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPCDataGridViewTextBoxColumn.Name = "iDPCDataGridViewTextBoxColumn";
            this.iDPCDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYDataGridViewTextBoxColumn
            // 
            this.nGAYDataGridViewTextBoxColumn.DataPropertyName = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.HeaderText = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYDataGridViewTextBoxColumn.Name = "nGAYDataGridViewTextBoxColumn";
            this.nGAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOIDUNGDataGridViewTextBoxColumn
            // 
            this.nOIDUNGDataGridViewTextBoxColumn.DataPropertyName = "NOIDUNG";
            this.nOIDUNGDataGridViewTextBoxColumn.HeaderText = "NOIDUNG";
            this.nOIDUNGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOIDUNGDataGridViewTextBoxColumn.Name = "nOIDUNGDataGridViewTextBoxColumn";
            this.nOIDUNGDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOTIENDataGridViewTextBoxColumn
            // 
            this.sOTIENDataGridViewTextBoxColumn.DataPropertyName = "SOTIEN";
            this.sOTIENDataGridViewTextBoxColumn.HeaderText = "SOTIEN";
            this.sOTIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOTIENDataGridViewTextBoxColumn.Name = "sOTIENDataGridViewTextBoxColumn";
            this.sOTIENDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPhuCap";
            this.Text = "frmPhuCap";
            this.Load += new System.EventHandler(this.frmPhuCap_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbPHUCAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENPHUCAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPHUCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENPHUCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhuCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHANSUDataSet1 qLNHANSUDataSet1;
        private System.Windows.Forms.BindingSource tbPHUCAPBindingSource;
        private QLNHANSUDataSet1TableAdapters.tb_PHUCAPTableAdapter tb_PHUCAPTableAdapter;
        private QLNHANSUDataSet9 qLNHANSUDataSet9;
        private System.Windows.Forms.BindingSource tbPHUCAPBindingSource1;
        private QLNHANSUDataSet9TableAdapters.tb_PHUCAPTableAdapter tb_PHUCAPTableAdapter1;
        private System.Windows.Forms.BindingSource tbNHANVIENPHUCAPBindingSource;
        private QLNHANSUDataSet9TableAdapters.tb_NHANVIEN_PHUCAPTableAdapter tb_NHANVIEN_PHUCAPTableAdapter;
        private System.Windows.Forms.BindingSource tbNHANVIENPHUCAPBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIEN;
        private System.Windows.Forms.BindingSource tbNHANVIENBindingSource;
        private QLNHANSUDataSet1TableAdapters.tb_NHANVIENTableAdapter tb_NHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource qLNHANSUDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOIDUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTIENDataGridViewTextBoxColumn;
    }
}