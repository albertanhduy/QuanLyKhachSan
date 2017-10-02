namespace QLKS
{
    partial class Accc
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
            this.khachTableAdapter1 = new QLKS.QLTPDataSet1TableAdapters.KhachTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.qLTPDataSet3 = new QLKS.QLTPDataSet3();
            this.taikhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taikhoanTableAdapter = new QLKS.QLTPDataSet3TableAdapters.TaikhoanTableAdapter();
            this.accDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // khachTableAdapter1
            // 
            this.khachTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.phanQuyenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taikhoanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // qLTPDataSet3
            // 
            this.qLTPDataSet3.DataSetName = "QLTPDataSet3";
            this.qLTPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taikhoanBindingSource
            // 
            this.taikhoanBindingSource.DataMember = "Taikhoan";
            this.taikhoanBindingSource.DataSource = this.qLTPDataSet3;
            // 
            // taikhoanTableAdapter
            // 
            this.taikhoanTableAdapter.ClearBeforeFill = true;
            // 
            // accDataGridViewTextBoxColumn
            // 
            this.accDataGridViewTextBoxColumn.DataPropertyName = "Acc";
            this.accDataGridViewTextBoxColumn.HeaderText = "Acc";
            this.accDataGridViewTextBoxColumn.Name = "accDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // phanQuyenDataGridViewTextBoxColumn
            // 
            this.phanQuyenDataGridViewTextBoxColumn.DataPropertyName = "PhanQuyen";
            this.phanQuyenDataGridViewTextBoxColumn.HeaderText = "PhanQuyen";
            this.phanQuyenDataGridViewTextBoxColumn.Name = "phanQuyenDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // Accc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Accc";
            this.Text = "Accc";
            this.Load += new System.EventHandler(this.Accc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLTPDataSet1TableAdapters.KhachTableAdapter khachTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private QLTPDataSet3 qLTPDataSet3;
        private System.Windows.Forms.BindingSource taikhoanBindingSource;
        private QLTPDataSet3TableAdapters.TaikhoanTableAdapter taikhoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanQuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}