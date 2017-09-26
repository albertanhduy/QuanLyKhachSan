namespace QLKS
{
    partial class QL_Dichvu
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
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label giaDVLabel;
            System.Windows.Forms.Label maDVLabel;
            System.Windows.Forms.Label tenDVLabel;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dichvuDataGridView = new System.Windows.Forms.DataGridView();
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTPDataSet = new QLKS.QLTPDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dichvuTableAdapter = new QLKS.QLTPDataSetTableAdapters.DichvuTableAdapter();
            dVTLabel = new System.Windows.Forms.Label();
            giaDVLabel = new System.Windows.Forms.Label();
            maDVLabel = new System.Windows.Forms.Label();
            tenDVLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(441, 34);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(60, 13);
            dVTLabel.TabIndex = 8;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // giaDVLabel
            // 
            giaDVLabel.AutoSize = true;
            giaDVLabel.Location = new System.Drawing.Point(441, 82);
            giaDVLabel.Name = "giaDVLabel";
            giaDVLabel.Size = new System.Drawing.Size(61, 13);
            giaDVLabel.TabIndex = 10;
            giaDVLabel.Text = "Giá dịch vụ";
            // 
            // maDVLabel
            // 
            maDVLabel.AutoSize = true;
            maDVLabel.Location = new System.Drawing.Point(26, 34);
            maDVLabel.Name = "maDVLabel";
            maDVLabel.Size = new System.Drawing.Size(60, 13);
            maDVLabel.TabIndex = 12;
            maDVLabel.Text = "Mã dịch vụ";
            // 
            // tenDVLabel
            // 
            tenDVLabel.AutoSize = true;
            tenDVLabel.Location = new System.Drawing.Point(26, 82);
            tenDVLabel.Name = "tenDVLabel";
            tenDVLabel.Size = new System.Drawing.Size(64, 13);
            tenDVLabel.TabIndex = 14;
            tenDVLabel.Text = "Tên dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dichvuDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 232);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ";
            // 
            // dichvuDataGridView
            // 
            this.dichvuDataGridView.AllowUserToAddRows = false;
            this.dichvuDataGridView.AllowUserToDeleteRows = false;
            this.dichvuDataGridView.AutoGenerateColumns = false;
            this.dichvuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dichvuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichvuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.giaDVDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn});
            this.dichvuDataGridView.DataSource = this.dichvuBindingSource;
            this.dichvuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dichvuDataGridView.Location = new System.Drawing.Point(3, 16);
            this.dichvuDataGridView.Name = "dichvuDataGridView";
            this.dichvuDataGridView.ReadOnly = true;
            this.dichvuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dichvuDataGridView.Size = new System.Drawing.Size(804, 213);
            this.dichvuDataGridView.TabIndex = 0;
            this.dichvuDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dichvuDataGridView_RowEnter);
            // 
            // maDVDataGridViewTextBoxColumn
            // 
            this.maDVDataGridViewTextBoxColumn.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn.HeaderText = "Mã dịch vụ";
            this.maDVDataGridViewTextBoxColumn.Name = "maDVDataGridViewTextBoxColumn";
            this.maDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDVDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDVDataGridViewTextBoxColumn
            // 
            this.tenDVDataGridViewTextBoxColumn.DataPropertyName = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tenDVDataGridViewTextBoxColumn.Name = "tenDVDataGridViewTextBoxColumn";
            this.tenDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDVDataGridViewTextBoxColumn
            // 
            this.giaDVDataGridViewTextBoxColumn.DataPropertyName = "GiaDV";
            this.giaDVDataGridViewTextBoxColumn.HeaderText = "Giá dịch vụ";
            this.giaDVDataGridViewTextBoxColumn.Name = "giaDVDataGridViewTextBoxColumn";
            this.giaDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            this.dVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dichvuBindingSource
            // 
            this.dichvuBindingSource.DataMember = "Dichvu";
            this.dichvuBindingSource.DataSource = this.qLTPDataSet;
            // 
            // qLTPDataSet
            // 
            this.qLTPDataSet.DataSetName = "QLTPDataSet";
            this.qLTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(this.txt_dvt);
            this.groupBox1.Controls.Add(giaDVLabel);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(maDVLabel);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(tenDVLabel);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(810, 182);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(546, 31);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(238, 20);
            this.txt_dvt.TabIndex = 9;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(546, 79);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(238, 20);
            this.txt_gia.TabIndex = 11;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(169, 31);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(238, 20);
            this.txt_ma.TabIndex = 13;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(169, 79);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(238, 20);
            this.txt_ten.TabIndex = 15;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(635, 131);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 33);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(438, 131);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(114, 33);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(241, 131);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(114, 33);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(44, 131);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(114, 33);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // dichvuTableAdapter
            // 
            this.dichvuTableAdapter.ClearBeforeFill = true;
            // 
            // QL_Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QL_Dichvu";
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.QL_Dichvu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dichvuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dichvuDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private QLTPDataSet qLTPDataSet;
        private System.Windows.Forms.BindingSource dichvuBindingSource;
        private QLTPDataSetTableAdapters.DichvuTableAdapter dichvuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
    }
}