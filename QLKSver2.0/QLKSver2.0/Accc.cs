using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Accc : Form
    {
        public Accc()
        {
            InitializeComponent();
        }

        private void Accc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTPDataSet3.Taikhoan' table. You can move, or remove it, as needed.
            this.taikhoanTableAdapter.Fill(this.qLTPDataSet3.Taikhoan);

        }
    }
}
