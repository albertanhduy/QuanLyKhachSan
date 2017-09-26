namespace QLKS
{
    partial class QL_SDDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_SDDV));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sDDVDataGridView = new System.Windows.Forms.DataGridView();
            this.maHDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTPDataSet = new QLKS.QLTPDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dichvuDataGridView = new System.Windows.Forms.DataGridView();
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tv_khach = new System.Windows.Forms.TreeView();
            this.dichvuTableAdapter = new QLKS.QLTPDataSetTableAdapters.DichvuTableAdapter();
            this.sDDVTableAdapter = new QLKS.QLTPDataSetTableAdapters.SDDVTableAdapter();
            this.dichvuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dichvuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sDDVDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingNavigator)).BeginInit();
            this.dichvuBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(747, 212);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 31);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(613, 212);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(85, 31);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(479, 212);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(85, 31);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(345, 212);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 31);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sDDVDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(276, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 229);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sử dụng";
            // 
            // sDDVDataGridView
            // 
            this.sDDVDataGridView.AllowUserToAddRows = false;
            this.sDDVDataGridView.AllowUserToDeleteRows = false;
            this.sDDVDataGridView.AutoGenerateColumns = false;
            this.sDDVDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sDDVDataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.sDDVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sDDVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDVDataGridViewTextBoxColumn,
            this.cMTDataGridViewTextBoxColumn,
            this.maDVDataGridViewTextBoxColumn1,
            this.soluongDataGridViewTextBoxColumn,
            this.ngaySDDataGridViewTextBoxColumn,
            this.maPDataGridViewTextBoxColumn});
            this.sDDVDataGridView.DataSource = this.sDDVBindingSource;
            this.sDDVDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sDDVDataGridView.Location = new System.Drawing.Point(3, 16);
            this.sDDVDataGridView.Name = "sDDVDataGridView";
            this.sDDVDataGridView.Size = new System.Drawing.Size(648, 210);
            this.sDDVDataGridView.TabIndex = 0;
            // 
            // maHDDVDataGridViewTextBoxColumn
            // 
            this.maHDDVDataGridViewTextBoxColumn.DataPropertyName = "MaHDDV";
            this.maHDDVDataGridViewTextBoxColumn.HeaderText = "Mã HDDV";
            this.maHDDVDataGridViewTextBoxColumn.Name = "maHDDVDataGridViewTextBoxColumn";
            this.maHDDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMTDataGridViewTextBoxColumn
            // 
            this.cMTDataGridViewTextBoxColumn.DataPropertyName = "CMT";
            this.cMTDataGridViewTextBoxColumn.HeaderText = "Số CNND";
            this.cMTDataGridViewTextBoxColumn.Name = "cMTDataGridViewTextBoxColumn";
            // 
            // maDVDataGridViewTextBoxColumn1
            // 
            this.maDVDataGridViewTextBoxColumn1.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn1.HeaderText = "Mã dịch vụ";
            this.maDVDataGridViewTextBoxColumn1.Name = "maDVDataGridViewTextBoxColumn1";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // ngaySDDataGridViewTextBoxColumn
            // 
            this.ngaySDDataGridViewTextBoxColumn.DataPropertyName = "NgaySD";
            this.ngaySDDataGridViewTextBoxColumn.HeaderText = "Ngày sử dụng";
            this.ngaySDDataGridViewTextBoxColumn.Name = "ngaySDDataGridViewTextBoxColumn";
            // 
            // maPDataGridViewTextBoxColumn
            // 
            this.maPDataGridViewTextBoxColumn.DataPropertyName = "MaP";
            this.maPDataGridViewTextBoxColumn.HeaderText = "Mã phòng";
            this.maPDataGridViewTextBoxColumn.Name = "maPDataGridViewTextBoxColumn";
            // 
            // sDDVBindingSource
            // 
            this.sDDVBindingSource.DataMember = "SDDV";
            this.sDDVBindingSource.DataSource = this.qLTPDataSet;
            // 
            // qLTPDataSet
            // 
            this.qLTPDataSet.DataSetName = "QLTPDataSet";
            this.qLTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dichvuDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(276, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 163);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn dịch vụ";
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
            this.dichvuDataGridView.Size = new System.Drawing.Size(648, 144);
            this.dichvuDataGridView.TabIndex = 0;
            // 
            // maDVDataGridViewTextBoxColumn
            // 
            this.maDVDataGridViewTextBoxColumn.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn.HeaderText = "Mã dịch vụ";
            this.maDVDataGridViewTextBoxColumn.Name = "maDVDataGridViewTextBoxColumn";
            this.maDVDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.giaDVDataGridViewTextBoxColumn.HeaderText = "Gía dịch vụ";
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
            // tv_khach
            // 
            this.tv_khach.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tv_khach.Location = new System.Drawing.Point(57, 34);
            this.tv_khach.Name = "tv_khach";
            this.tv_khach.Size = new System.Drawing.Size(202, 444);
            this.tv_khach.TabIndex = 4;
            this.tv_khach.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_khach_AfterSelect);
            // 
            // dichvuTableAdapter
            // 
            this.dichvuTableAdapter.ClearBeforeFill = true;
            // 
            // sDDVTableAdapter
            // 
            this.sDDVTableAdapter.ClearBeforeFill = true;
            // 
            // dichvuBindingNavigator
            // 
            this.dichvuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dichvuBindingNavigator.BindingSource = this.dichvuBindingSource;
            this.dichvuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dichvuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dichvuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dichvuBindingNavigatorSaveItem});
            this.dichvuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dichvuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dichvuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dichvuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dichvuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dichvuBindingNavigator.Name = "dichvuBindingNavigator";
            this.dichvuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dichvuBindingNavigator.Size = new System.Drawing.Size(954, 25);
            this.dichvuBindingNavigator.TabIndex = 11;
            this.dichvuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dichvuBindingNavigatorSaveItem
            // 
            this.dichvuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dichvuBindingNavigatorSaveItem.Enabled = false;
            this.dichvuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dichvuBindingNavigatorSaveItem.Image")));
            this.dichvuBindingNavigatorSaveItem.Name = "dichvuBindingNavigatorSaveItem";
            this.dichvuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dichvuBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // QL_SDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(954, 540);
            this.Controls.Add(this.dichvuBindingNavigator);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tv_khach);
            this.Name = "QL_SDDV";
            this.Text = "Quản lý sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.QL_SDDV_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sDDVDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dichvuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingNavigator)).EndInit();
            this.dichvuBindingNavigator.ResumeLayout(false);
            this.dichvuBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView sDDVDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dichvuDataGridView;
        private System.Windows.Forms.TreeView tv_khach;
        private QLTPDataSet qLTPDataSet;
        private System.Windows.Forms.BindingSource dichvuBindingSource;
        private QLTPDataSetTableAdapters.DichvuTableAdapter dichvuTableAdapter;
        private System.Windows.Forms.BindingSource sDDVBindingSource;
        private QLTPDataSetTableAdapters.SDDVTableAdapter sDDVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator dichvuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dichvuBindingNavigatorSaveItem;
    }
}