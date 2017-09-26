namespace QLKS
{
    partial class QL_Khach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.khachdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLTPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTPDataSet1 = new QLKS.QLTPDataSet1();
            this.khachDataGridView = new System.Windows.Forms.DataGridView();
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cMTLabel = new System.Windows.Forms.Label();
            this.txt_cmt = new System.Windows.Forms.TextBox();
            this.diachiLabel = new System.Windows.Forms.Label();
            this.txt_dchi = new System.Windows.Forms.TextBox();
            this.gTLabel = new System.Windows.Forms.Label();
            this.cbb_gtinh = new System.Windows.Forms.ComboBox();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.sDTLabel = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.khachTableAdapter = new QLKS.QLTPDataSetTableAdapters.KhachTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.khachdataGridView1);
            this.groupBox2.Controls.Add(this.khachDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1075, 274);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // khachdataGridView1
            // 
            this.khachdataGridView1.AllowUserToAddRows = false;
            this.khachdataGridView1.AllowUserToDeleteRows = false;
            this.khachdataGridView1.AutoGenerateColumns = false;
            this.khachdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.khachdataGridView1.DataSource = this.khachBindingSource;
            this.khachdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachdataGridView1.Location = new System.Drawing.Point(4, 23);
            this.khachdataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khachdataGridView1.Name = "khachdataGridView1";
            this.khachdataGridView1.ReadOnly = true;
            this.khachdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachdataGridView1.Size = new System.Drawing.Size(1067, 247);
            this.khachdataGridView1.TabIndex = 1;
            this.khachdataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.khachdataGridView1_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CMT";
            this.Column1.HeaderText = "Số CMND";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Hoten";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Diachi";
            this.Column3.HeaderText = "ĐỊa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GT";
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Số ĐT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // qLTPDataSet1BindingSource
            // 
            this.qLTPDataSet1BindingSource.DataSource = this.qLTPDataSet1;
            this.qLTPDataSet1BindingSource.Position = 0;
            // 
            // qLTPDataSet1
            // 
            this.qLTPDataSet1.DataSetName = "QLTPDataSet1";
            this.qLTPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachDataGridView
            // 
            this.khachDataGridView.AllowUserToAddRows = false;
            this.khachDataGridView.AllowUserToDeleteRows = false;
            this.khachDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachDataGridView.Location = new System.Drawing.Point(4, 23);
            this.khachDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.khachDataGridView.Name = "khachDataGridView";
            this.khachDataGridView.ReadOnly = true;
            this.khachDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachDataGridView.Size = new System.Drawing.Size(1067, 247);
            this.khachDataGridView.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 45);
            this.label6.TabIndex = 6;
            this.label6.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cMTLabel);
            this.groupBox1.Controls.Add(this.txt_cmt);
            this.groupBox1.Controls.Add(this.diachiLabel);
            this.groupBox1.Controls.Add(this.txt_dchi);
            this.groupBox1.Controls.Add(this.gTLabel);
            this.groupBox1.Controls.Add(this.cbb_gtinh);
            this.groupBox1.Controls.Add(this.hotenLabel);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.sDTLabel);
            this.groupBox1.Controls.Add(this.txt_dt);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1075, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cMTLabel
            // 
            this.cMTLabel.AutoSize = true;
            this.cMTLabel.Location = new System.Drawing.Point(49, 37);
            this.cMTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cMTLabel.Name = "cMTLabel";
            this.cMTLabel.Size = new System.Drawing.Size(92, 20);
            this.cMTLabel.TabIndex = 6;
            this.cMTLabel.Text = "Số CMND";
            // 
            // txt_cmt
            // 
            this.txt_cmt.Location = new System.Drawing.Point(191, 33);
            this.txt_cmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cmt.MaxLength = 12;
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Size = new System.Drawing.Size(307, 26);
            this.txt_cmt.TabIndex = 0;
            // 
            // diachiLabel
            // 
            this.diachiLabel.AutoSize = true;
            this.diachiLabel.Location = new System.Drawing.Point(49, 130);
            this.diachiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diachiLabel.Name = "diachiLabel";
            this.diachiLabel.Size = new System.Drawing.Size(68, 20);
            this.diachiLabel.TabIndex = 8;
            this.diachiLabel.Text = "Địa chỉ";
            // 
            // txt_dchi
            // 
            this.txt_dchi.Location = new System.Drawing.Point(191, 127);
            this.txt_dchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dchi.Name = "txt_dchi";
            this.txt_dchi.Size = new System.Drawing.Size(307, 26);
            this.txt_dchi.TabIndex = 2;
            // 
            // gTLabel
            // 
            this.gTLabel.AutoSize = true;
            this.gTLabel.Location = new System.Drawing.Point(565, 37);
            this.gTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gTLabel.Name = "gTLabel";
            this.gTLabel.Size = new System.Drawing.Size(80, 20);
            this.gTLabel.TabIndex = 10;
            this.gTLabel.Text = "Giới tính";
            // 
            // cbb_gtinh
            // 
            this.cbb_gtinh.FormattingEnabled = true;
            this.cbb_gtinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gtinh.Location = new System.Drawing.Point(717, 33);
            this.cbb_gtinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_gtinh.Name = "cbb_gtinh";
            this.cbb_gtinh.Size = new System.Drawing.Size(307, 28);
            this.cbb_gtinh.TabIndex = 3;
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Location = new System.Drawing.Point(49, 84);
            this.hotenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(65, 20);
            this.hotenLabel.TabIndex = 12;
            this.hotenLabel.Text = "Họ tên";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(191, 80);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(307, 26);
            this.txt_ten.TabIndex = 1;
            // 
            // sDTLabel
            // 
            this.sDTLabel.AutoSize = true;
            this.sDTLabel.Location = new System.Drawing.Point(565, 84);
            this.sDTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sDTLabel.Name = "sDTLabel";
            this.sDTLabel.Size = new System.Drawing.Size(119, 20);
            this.sDTLabel.TabIndex = 14;
            this.sDTLabel.Text = "Số điện thoại";
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(717, 80);
            this.txt_dt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(307, 26);
            this.txt_dt.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_them.Location = new System.Drawing.Point(160, 171);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 33);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(372, 171);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 33);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(812, 171);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 33);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(592, 171);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 33);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // khachTableAdapter
            // 
            this.khachTableAdapter.ClearBeforeFill = true;
            // 
            // QL_Khach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1105, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QL_Khach";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.QL_Khach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView khachdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView khachDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cMTLabel;
        private System.Windows.Forms.TextBox txt_cmt;
        private System.Windows.Forms.Label diachiLabel;
        private System.Windows.Forms.TextBox txt_dchi;
        private System.Windows.Forms.Label gTLabel;
        private System.Windows.Forms.ComboBox cbb_gtinh;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label sDTLabel;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.BindingSource khachBindingSource;
        private QLTPDataSetTableAdapters.KhachTableAdapter khachTableAdapter;
        private System.Windows.Forms.BindingSource qLTPDataSet1BindingSource;
        private QLTPDataSet1 qLTPDataSet1;
    }
}