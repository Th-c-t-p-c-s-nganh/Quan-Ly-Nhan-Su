namespace QuanLyNhanSu
{
    partial class frmKhenThuongKyLuat
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
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSQD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sOQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lYDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOIDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUNGAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dENGAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEDBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELETEDBYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELETEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKHENTHUONGKYLUATBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet = new QuanLyNhanSu.QLNHANSUDataSet();
            this.qLNHANSUDataSet1 = new QuanLyNhanSu.QLNHANSUDataSet1();
            this.tb_KHENTHUONG_KYLUATTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet1TableAdapters.tb_KHENTHUONG_KYLUATTableAdapter();
            this.tb_KHENTHUONG_KYLUATTableAdapter1 = new QuanLyNhanSu.QLNHANSUDataSetTableAdapters.tb_KHENTHUONG_KYLUATTableAdapter();
            this.tbNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_NHANVIENTableAdapter = new QuanLyNhanSu.QLNHANSUDataSet1TableAdapters.tb_NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKHENTHUONGKYLUATBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBD);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtLyDo);
            this.splitContainer1.Panel1.Controls.Add(this.cboNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtSQD);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1195, 450);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBD.Location = new System.Drawing.Point(451, 44);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(238, 28);
            this.dtNgayBD.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(364, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ngày BĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(65, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNoiDung.Location = new System.Drawing.Point(149, 158);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(599, 26);
            this.txtNoiDung.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Lý do";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLyDo.Location = new System.Drawing.Point(149, 108);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(599, 26);
            this.txtLyDo.TabIndex = 57;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DataSource = this.tbNHANVIENBindingSource;
            this.cboNhanVien.DisplayMember = "HOTEN";
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(897, 51);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(179, 24);
            this.cboNhanVien.TabIndex = 56;
            this.cboNhanVien.ValueMember = "MANV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(747, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nhân viên";
            // 
            // txtSQD
            // 
            this.txtSQD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSQD.Location = new System.Drawing.Point(149, 44);
            this.txtSQD.Name = "txtSQD";
            this.txtSQD.ReadOnly = true;
            this.txtSQD.Size = new System.Drawing.Size(147, 28);
            this.txtSQD.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Số QĐ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(247, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(490, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 43;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(166, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(328, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 41;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(409, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 42;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(85, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOQDDataGridViewTextBoxColumn,
            this.lYDODataGridViewTextBoxColumn,
            this.nOIDUNGDataGridViewTextBoxColumn,
            this.nGAYDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.lOAIDataGridViewTextBoxColumn,
            this.tUNGAYDataGridViewTextBoxColumn,
            this.dENGAYDataGridViewTextBoxColumn,
            this.cREATEDBYDataGridViewTextBoxColumn,
            this.cREATEDDATEDataGridViewTextBoxColumn,
            this.uPDATEDBYDataGridViewTextBoxColumn,
            this.uPDATEDDATEDataGridViewTextBoxColumn,
            this.dELETEDBYDataGridViewTextBoxColumn,
            this.dELETEDDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbKHENTHUONGKYLUATBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sOQDDataGridViewTextBoxColumn
            // 
            this.sOQDDataGridViewTextBoxColumn.DataPropertyName = "SOQD";
            this.sOQDDataGridViewTextBoxColumn.HeaderText = "Số QĐ";
            this.sOQDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOQDDataGridViewTextBoxColumn.Name = "sOQDDataGridViewTextBoxColumn";
            this.sOQDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lYDODataGridViewTextBoxColumn
            // 
            this.lYDODataGridViewTextBoxColumn.DataPropertyName = "LYDO";
            this.lYDODataGridViewTextBoxColumn.HeaderText = "Lý do";
            this.lYDODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lYDODataGridViewTextBoxColumn.Name = "lYDODataGridViewTextBoxColumn";
            this.lYDODataGridViewTextBoxColumn.Width = 125;
            // 
            // nOIDUNGDataGridViewTextBoxColumn
            // 
            this.nOIDUNGDataGridViewTextBoxColumn.DataPropertyName = "NOIDUNG";
            this.nOIDUNGDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.nOIDUNGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOIDUNGDataGridViewTextBoxColumn.Name = "nOIDUNGDataGridViewTextBoxColumn";
            this.nOIDUNGDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYDataGridViewTextBoxColumn
            // 
            this.nGAYDataGridViewTextBoxColumn.DataPropertyName = "NGAY";
            this.nGAYDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.nGAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYDataGridViewTextBoxColumn.Name = "nGAYDataGridViewTextBoxColumn";
            this.nGAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOAIDataGridViewTextBoxColumn
            // 
            this.lOAIDataGridViewTextBoxColumn.DataPropertyName = "LOAI";
            this.lOAIDataGridViewTextBoxColumn.HeaderText = "Loại";
            this.lOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOAIDataGridViewTextBoxColumn.Name = "lOAIDataGridViewTextBoxColumn";
            this.lOAIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tUNGAYDataGridViewTextBoxColumn
            // 
            this.tUNGAYDataGridViewTextBoxColumn.DataPropertyName = "TUNGAY";
            this.tUNGAYDataGridViewTextBoxColumn.HeaderText = "Từ ngày";
            this.tUNGAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tUNGAYDataGridViewTextBoxColumn.Name = "tUNGAYDataGridViewTextBoxColumn";
            this.tUNGAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // dENGAYDataGridViewTextBoxColumn
            // 
            this.dENGAYDataGridViewTextBoxColumn.DataPropertyName = "DENGAY";
            this.dENGAYDataGridViewTextBoxColumn.HeaderText = "Đến ngày";
            this.dENGAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dENGAYDataGridViewTextBoxColumn.Name = "dENGAYDataGridViewTextBoxColumn";
            this.dENGAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // cREATEDBYDataGridViewTextBoxColumn
            // 
            this.cREATEDBYDataGridViewTextBoxColumn.DataPropertyName = "CREATED_BY";
            this.cREATEDBYDataGridViewTextBoxColumn.HeaderText = "CREATED_BY";
            this.cREATEDBYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cREATEDBYDataGridViewTextBoxColumn.Name = "cREATEDBYDataGridViewTextBoxColumn";
            this.cREATEDBYDataGridViewTextBoxColumn.Width = 125;
            // 
            // cREATEDDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATED_DATE";
            this.cREATEDDATEDataGridViewTextBoxColumn.HeaderText = "CREATED_DATE";
            this.cREATEDDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cREATEDDATEDataGridViewTextBoxColumn.Name = "cREATEDDATEDataGridViewTextBoxColumn";
            this.cREATEDDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // uPDATEDBYDataGridViewTextBoxColumn
            // 
            this.uPDATEDBYDataGridViewTextBoxColumn.DataPropertyName = "UPDATED_BY";
            this.uPDATEDBYDataGridViewTextBoxColumn.HeaderText = "UPDATED_BY";
            this.uPDATEDBYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uPDATEDBYDataGridViewTextBoxColumn.Name = "uPDATEDBYDataGridViewTextBoxColumn";
            this.uPDATEDBYDataGridViewTextBoxColumn.Width = 125;
            // 
            // uPDATEDDATEDataGridViewTextBoxColumn
            // 
            this.uPDATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "UPDATED_DATE";
            this.uPDATEDDATEDataGridViewTextBoxColumn.HeaderText = "UPDATED_DATE";
            this.uPDATEDDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uPDATEDDATEDataGridViewTextBoxColumn.Name = "uPDATEDDATEDataGridViewTextBoxColumn";
            this.uPDATEDDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELETEDBYDataGridViewTextBoxColumn
            // 
            this.dELETEDBYDataGridViewTextBoxColumn.DataPropertyName = "DELETED_BY";
            this.dELETEDBYDataGridViewTextBoxColumn.HeaderText = "DELETED_BY";
            this.dELETEDBYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELETEDBYDataGridViewTextBoxColumn.Name = "dELETEDBYDataGridViewTextBoxColumn";
            this.dELETEDBYDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELETEDDATEDataGridViewTextBoxColumn
            // 
            this.dELETEDDATEDataGridViewTextBoxColumn.DataPropertyName = "DELETED_DATE";
            this.dELETEDDATEDataGridViewTextBoxColumn.HeaderText = "DELETED_DATE";
            this.dELETEDDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELETEDDATEDataGridViewTextBoxColumn.Name = "dELETEDDATEDataGridViewTextBoxColumn";
            this.dELETEDDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbKHENTHUONGKYLUATBindingSource1
            // 
            this.tbKHENTHUONGKYLUATBindingSource1.DataMember = "tb_KHENTHUONG_KYLUAT";
            this.tbKHENTHUONGKYLUATBindingSource1.DataSource = this.qLNHANSUDataSet;
            // 
            // qLNHANSUDataSet
            // 
            this.qLNHANSUDataSet.DataSetName = "QLNHANSUDataSet";
            this.qLNHANSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNHANSUDataSet1
            // 
            this.qLNHANSUDataSet1.DataSetName = "QLNHANSUDataSet1";
            this.qLNHANSUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_KHENTHUONG_KYLUATTableAdapter
            // 
            this.tb_KHENTHUONG_KYLUATTableAdapter.ClearBeforeFill = true;
            // 
            // tb_KHENTHUONG_KYLUATTableAdapter1
            // 
            this.tb_KHENTHUONG_KYLUATTableAdapter1.ClearBeforeFill = true;
            // 
            // tbNHANVIENBindingSource
            // 
            this.tbNHANVIENBindingSource.DataMember = "tb_NHANVIEN";
            this.tbNHANVIENBindingSource.DataSource = this.qLNHANSUDataSet1;
            // 
            // tb_NHANVIENTableAdapter
            // 
            this.tb_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhenThuongKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKhenThuongKyLuat";
            this.Text = "frmKhenThuongKyLuat";
            this.Load += new System.EventHandler(this.frmKhenThuongKyLuat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKHENTHUONGKYLUATBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtSQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private QLNHANSUDataSet1 qLNHANSUDataSet1;
        private QLNHANSUDataSet1TableAdapters.tb_KHENTHUONG_KYLUATTableAdapter tb_KHENTHUONG_KYLUATTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHANSUDataSet qLNHANSUDataSet;
        private System.Windows.Forms.BindingSource tbKHENTHUONGKYLUATBindingSource1;
        private QLNHANSUDataSetTableAdapters.tb_KHENTHUONG_KYLUATTableAdapter tb_KHENTHUONG_KYLUATTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lYDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOIDUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUNGAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dENGAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPDATEDBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPDATEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELETEDBYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELETEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tbNHANVIENBindingSource;
        private QLNHANSUDataSet1TableAdapters.tb_NHANVIENTableAdapter tb_NHANVIENTableAdapter;
    }
}