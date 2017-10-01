using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKS
{
    public partial class QL_Khach : Form
    {
        public QL_Khach()
        {
            InitializeComponent();
        }
        QLTPDataContext db = new QLTPDataContext();
        public void anhien(Boolean gt)
        {
            txt_cmt.Enabled = gt;
            txt_dchi.Enabled = gt;
            txt_dt.Enabled = gt;
            cbb_gtinh.Enabled = gt;
            txt_ten.Enabled = gt;
        }

        public void khoacn(Boolean gt)
        {
            btn_sua.Enabled = gt;
            btn_them.Enabled = gt;
            btn_xoa.Enabled = gt;
        }
        private void Display()
        {
            List<Khach> list = new List<Khach>();
            var query = (from n in db.Khaches
                         select n);
            list = query.ToList<Khach>();
            khachBindingSource.DataSource = list;
            //            khachDataGridView.AutoGenerateColumns = false;
        }
        private void QL_Khach_Load(object sender, EventArgs e)
        {
            Display();
            anhien(false);
            khoacn(true);
            db = new QLTPDataContext();
        }
        public bool ktra_cmt(string cmt)
        {
            int cmnd;
            if ((int.TryParse(cmt, out cmnd) == true) && (cmt.Length < 10))
            {
                return false;
            }
            else
                return true;
        }
        public bool ktra_sdt(string sdt)
        {
            
        }
        public void Set_Empty()
        {
            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void khachdataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
