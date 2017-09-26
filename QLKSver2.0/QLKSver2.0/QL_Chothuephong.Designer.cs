namespace QLKS
{
    partial class QL_Chothuephong
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thuePDataGridView = new System.Windows.Forms.DataGridView();
            this.thuePBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTPDataSet = new QLKS.QLTPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.btn_thue = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_loaip = new System.Windows.Forms.ComboBox();
            this.btn_chonp = new System.Windows.Forms.Button();
            this.phongDataGridView = new System.Windows.Forms.DataGridView();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cmt = new System.Windows.Forms.TextBox();
            this.btn_chonk = new System.Windows.Forms.Button();
            this.btn_themk = new System.Windows.Forms.Button();
            this.khachDataGridView = new System.Windows.Forms.DataGridView();
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachTableAdapter = new QLKS.QLTPDataSetTableAdapters.KhachTableAdapter();
            this.phongTableAdapter = new QLKS.QLTPDataSetTableAdapters.PhongTableAdapter();
            this.thuePTableAdapter = new QLKS.QLTPDataSetTableAdapters.ThuePTableAdapter();
            this.cMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuePDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuePBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.thuePDataGridView);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_tennv);
            this.groupBox3.Controls.Add(this.btn_thue);
            this.groupBox3.Location = new System.Drawing.Point(8, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(975, 192);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thuê phòng";
            // 
            // thuePDataGridView
            // 
            this.thuePDataGridView.AutoGenerateColumns = false;
            this.thuePDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thuePDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuePDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.cMTDataGridViewTextBoxColumn1,
            this.maPDataGridViewTextBoxColumn1,
            this.ngaydenDataGridViewTextBoxColumn,
            this.ngaydiDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn});
            this.thuePDataGridView.DataSource = this.thuePBindingSource;
            this.thuePDataGridView.Location = new System.Drawing.Point(21, 28);
            this.thuePDataGridView.Name = "thuePDataGridView";
            this.thuePDataGridView.ReadOnly = true;
            this.thuePDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.thuePDataGridView.Size = new System.Drawing.Size(777, 158);
            this.thuePDataGridView.TabIndex = 4;
            // 
            // thuePBindingSource
            // 
            this.thuePBindingSource.DataMember = "ThueP";
            this.thuePBindingSource.DataSource = this.qLTPDataSet;
            // 
            // qLTPDataSet
            // 
            this.qLTPDataSet.DataSetName = "QLTPDataSet";
            this.qLTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân viên";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(830, 71);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(125, 20);
            this.txt_tennv.TabIndex = 3;
            // 
            // btn_thue
            // 
            this.btn_thue.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thue.Location = new System.Drawing.Point(830, 115);
            this.btn_thue.Name = "btn_thue";
            this.btn_thue.Size = new System.Drawing.Size(125, 33);
            this.btn_thue.TabIndex = 1;
            this.btn_thue.Text = "Thuê phòng";
            this.btn_thue.UseVisualStyleBackColor = true;
            this.btn_thue.Click += new System.EventHandler(this.btn_thue_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_loaip);
            this.groupBox2.Controls.Add(this.btn_chonp);
            this.groupBox2.Controls.Add(this.phongDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(8, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng thuê";
            // 
            // cbb_loaip
            // 
            this.cbb_loaip.FormattingEnabled = true;
            this.cbb_loaip.Items.AddRange(new object[] {
            "Đơn thường",
            "Đôi thường",
            "Ba thường",
            "VIP đơn",
            "VIP đôi",
            "VIP ba"});
            this.cbb_loaip.Location = new System.Drawing.Point(830, 41);
            this.cbb_loaip.Name = "cbb_loaip";
            this.cbb_loaip.Size = new System.Drawing.Size(121, 21);
            this.cbb_loaip.TabIndex = 2;
            this.cbb_loaip.Text = "-- Chọn loại --";
            this.cbb_loaip.SelectedIndexChanged += new System.EventHandler(this.cbb_loaip_SelectedIndexChanged);
            // 
            // btn_chonp
            // 
            this.btn_chonp.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonp.Location = new System.Drawing.Point(830, 91);
            this.btn_chonp.Name = "btn_chonp";
            this.btn_chonp.Size = new System.Drawing.Size(125, 33);
            this.btn_chonp.TabIndex = 1;
            this.btn_chonp.Text = "Chọn phòng";
            this.btn_chonp.UseVisualStyleBackColor = true;
            this.btn_chonp.Click += new System.EventHandler(this.btn_chonp_Click);
            // 
            // phongDataGridView
            // 
            this.phongDataGridView.AllowUserToAddRows = false;
            this.phongDataGridView.AllowUserToDeleteRows = false;
            this.phongDataGridView.AutoGenerateColumns = false;
            this.phongDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPDataGridViewTextBoxColumn,
            this.tenPDataGridViewTextBoxColumn,
            this.loaiPDataGridViewTextBoxColumn,
            this.giaPDataGridViewTextBoxColumn,
            this.tinhtrangDataGridViewTextBoxColumn});
            this.phongDataGridView.DataSource = this.phongBindingSource;
            this.phongDataGridView.Location = new System.Drawing.Point(21, 26);
            this.phongDataGridView.Name = "phongDataGridView";
            this.phongDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phongDataGridView.Size = new System.Drawing.Size(777, 130);
            this.phongDataGridView.TabIndex = 0;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.qLTPDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cmt);
            this.groupBox1.Controls.Add(this.btn_chonk);
            this.groupBox1.Controls.Add(this.btn_themk);
            this.groupBox1.Controls.Add(this.khachDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_cmt
            // 
            this.txt_cmt.Location = new System.Drawing.Point(829, 26);
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Size = new System.Drawing.Size(125, 20);
            this.txt_cmt.TabIndex = 2;
            this.txt_cmt.Text = "Số CMND";
            this.txt_cmt.TextChanged += new System.EventHandler(this.txt_cmt_TextChanged);
            // 
            // btn_chonk
            // 
            this.btn_chonk.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonk.Location = new System.Drawing.Point(829, 118);
            this.btn_chonk.Name = "btn_chonk";
            this.btn_chonk.Size = new System.Drawing.Size(125, 33);
            this.btn_chonk.TabIndex = 1;
            this.btn_chonk.Text = "Chọn khách";
            this.btn_chonk.UseVisualStyleBackColor = true;
            this.btn_chonk.Click += new System.EventHandler(this.btn_chonk_Click);
            // 
            // btn_themk
            // 
            this.btn_themk.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themk.Location = new System.Drawing.Point(829, 67);
            this.btn_themk.Name = "btn_themk";
            this.btn_themk.Size = new System.Drawing.Size(125, 33);
            this.btn_themk.TabIndex = 1;
            this.btn_themk.Text = "Thêm khách";
            this.btn_themk.UseVisualStyleBackColor = true;
            this.btn_themk.Click += new System.EventHandler(this.btn_themk_Click);
            // 
            // khachDataGridView
            // 
            this.khachDataGridView.AllowUserToAddRows = false;
            this.khachDataGridView.AllowUserToDeleteRows = false;
            this.khachDataGridView.AutoGenerateColumns = false;
            this.khachDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMTDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.khachDataGridView.DataSource = this.khachBindingSource;
            this.khachDataGridView.Location = new System.Drawing.Point(20, 25);
            this.khachDataGridView.Name = "khachDataGridView";
            this.khachDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachDataGridView.Size = new System.Drawing.Size(777, 138);
            this.khachDataGridView.TabIndex = 0;
            // 
            // khachBindingSource
            // 
            this.khachBindingSource.DataMember = "Khach";
            this.khachBindingSource.DataSource = this.qLTPDataSet;
            // 
            // khachTableAdapter
            // 
            this.khachTableAdapter.ClearBeforeFill = true;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // thuePTableAdapter
            // 
            this.thuePTableAdapter.ClearBeforeFill = true;
            // 
            // cMTDataGridViewTextBoxColumn
            // 
            this.cMTDataGridViewTextBoxColumn.DataPropertyName = "CMT";
            this.cMTDataGridViewTextBoxColumn.HeaderText = "Số CMT";
            this.cMTDataGridViewTextBoxColumn.Name = "cMTDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "Hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // maPDataGridViewTextBoxColumn
            // 
            this.maPDataGridViewTextBoxColumn.DataPropertyName = "MaP";
            this.maPDataGridViewTextBoxColumn.HeaderText = "Mã phòng";
            this.maPDataGridViewTextBoxColumn.Name = "maPDataGridViewTextBoxColumn";
            // 
            // tenPDataGridViewTextBoxColumn
            // 
            this.tenPDataGridViewTextBoxColumn.DataPropertyName = "TenP";
            this.tenPDataGridViewTextBoxColumn.HeaderText = "Tên phòng";
            this.tenPDataGridViewTextBoxColumn.Name = "tenPDataGridViewTextBoxColumn";
            // 
            // loaiPDataGridViewTextBoxColumn
            // 
            this.loaiPDataGridViewTextBoxColumn.DataPropertyName = "LoaiP";
            this.loaiPDataGridViewTextBoxColumn.HeaderText = "Loại phòng";
            this.loaiPDataGridViewTextBoxColumn.Name = "loaiPDataGridViewTextBoxColumn";
            // 
            // giaPDataGridViewTextBoxColumn
            // 
            this.giaPDataGridViewTextBoxColumn.DataPropertyName = "GiaP";
            this.giaPDataGridViewTextBoxColumn.HeaderText = "Gía phòng";
            this.giaPDataGridViewTextBoxColumn.Name = "giaPDataGridViewTextBoxColumn";
            // 
            // tinhtrangDataGridViewTextBoxColumn
            // 
            this.tinhtrangDataGridViewTextBoxColumn.DataPropertyName = "Tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhtrangDataGridViewTextBoxColumn.Name = "tinhtrangDataGridViewTextBoxColumn";
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMTDataGridViewTextBoxColumn1
            // 
            this.cMTDataGridViewTextBoxColumn1.DataPropertyName = "CMT";
            this.cMTDataGridViewTextBoxColumn1.HeaderText = "Số CMT";
            this.cMTDataGridViewTextBoxColumn1.Name = "cMTDataGridViewTextBoxColumn1";
            this.cMTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maPDataGridViewTextBoxColumn1
            // 
            this.maPDataGridViewTextBoxColumn1.DataPropertyName = "MaP";
            this.maPDataGridViewTextBoxColumn1.HeaderText = "Mã phòng";
            this.maPDataGridViewTextBoxColumn1.Name = "maPDataGridViewTextBoxColumn1";
            this.maPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ngaydenDataGridViewTextBoxColumn
            // 
            this.ngaydenDataGridViewTextBoxColumn.DataPropertyName = "Ngayden";
            this.ngaydenDataGridViewTextBoxColumn.HeaderText = "Ngày đến";
            this.ngaydenDataGridViewTextBoxColumn.Name = "ngaydenDataGridViewTextBoxColumn";
            this.ngaydenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaydiDataGridViewTextBoxColumn
            // 
            this.ngaydiDataGridViewTextBoxColumn.DataPropertyName = "Ngaydi";
            this.ngaydiDataGridViewTextBoxColumn.HeaderText = "Ngày đi";
            this.ngaydiDataGridViewTextBoxColumn.Name = "ngaydiDataGridViewTextBoxColumn";
            this.ngaydiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QL_Chothuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QL_Chothuephong";
            this.Text = "QL_Chothuephong";
            this.Load += new System.EventHandler(this.QL_Chothuephong_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuePDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuePBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView thuePDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Button btn_thue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_loaip;
        private System.Windows.Forms.Button btn_chonp;
        private System.Windows.Forms.DataGridView phongDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cmt;
        private System.Windows.Forms.Button btn_chonk;
        private System.Windows.Forms.Button btn_themk;
        private System.Windows.Forms.DataGridView khachDataGridView;
        private QLTPDataSet qLTPDataSet;
        private System.Windows.Forms.BindingSource khachBindingSource;
        private QLTPDataSetTableAdapters.KhachTableAdapter khachTableAdapter;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private QLTPDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.BindingSource thuePBindingSource;
        private QLTPDataSetTableAdapters.ThuePTableAdapter thuePTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
    }
}