using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace QLKS
{
    public partial class QL_Dichvu : Form
    {
        public QL_Dichvu()
        {
            InitializeComponent();
        }
        QLTPDataContext dt;

        public void anhien(Boolean gt)
        {
            txt_ma.Enabled = gt;
            txt_ten.Enabled = gt;
            txt_gia.Enabled = gt;
            txt_dvt.Enabled = gt;
        }
        public void khoacn(Boolean gt)
        {
            btn_sua.Enabled = gt;
            btn_them.Enabled = gt;
            btn_xoa.Enabled = gt;
        }
        public bool ktra_gia(string gia)
        {
            int a;
            if (int.TryParse(txt_gia.Text, out a) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Display()
        {
            anhien(false);
            dt = new QLTPDataContext();
            List<Dichvu> list = new List<Dichvu>();
            var query = (from n in dt.Dichvus
                         select n);
            list = query.ToList<Dichvu>();
            dichvuBindingSource.DataSource = list;
        }
        private void QL_Dichvu_Load(object sender, EventArgs e)
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

        private void dichvuDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
