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
    public partial class QL_TraphongTest : Form
    {
        public QL_TraphongTest()
        {
            InitializeComponent();
        }

        private void QL_TraphongTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTPDataSet3.Khach' table. You can move, or remove it, as needed.
            this.khachTableAdapter.Fill(this.qLTPDataSet3.Khach);

        }
    }
}
