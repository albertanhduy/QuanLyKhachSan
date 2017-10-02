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
    public partial class QL_Phong : Form
    {
        public QL_Phong()
        {
            InitializeComponent();
        }

        private void QL_Phong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTPDataSet2.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.qLTPDataSet2.Phong);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
