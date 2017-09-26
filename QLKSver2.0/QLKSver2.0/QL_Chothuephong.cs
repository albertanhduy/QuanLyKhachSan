using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace QLKS
{
    public partial class QL_Chothuephong : Form
    {
        public QL_Chothuephong()
        {
            InitializeComponent();
        }
        QLTPDataContext db = new QLTPDataContext();
        List<ThueP> listthuep = new List<ThueP>();
        private void QL_Chothuephong_Load(object sender, EventArgs e)
        {
            
        }

        private void cbb_loaip_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_cmt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_themk_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_chonp_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_chonk_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_thue_Click(object sender, EventArgs e)
        {
            
        }
    }
}
