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
        private void QL_Khach_Load(object sender, EventArgs e)
        {
            
        }
        public bool ktra_cmt(string cmt)
        {
            
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
