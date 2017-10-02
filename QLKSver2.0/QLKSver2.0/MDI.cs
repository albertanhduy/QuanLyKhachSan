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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        QLTPDataContext dt = new QLTPDataContext();
        private void MDI_Load(object sender, EventArgs e)
        {

        }
        private void btn_dnhap_Click(object sender, EventArgs e)
        {
            string tk = txt_tk.Text;
            string mk = txt_mk.Text;
            string sql = "select*from taikhoan where acc = '" + tk + "'and pass ='" + mk + "'";
            if (txt_mk == null)
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản");
            }
            else
            {
                MessageBox.Show("xin chào! bạn đã đăng nhập thành công");
                menuStrip1.Visible = true;
                panel1.Visible = false;
                this.IsMdiContainer = true;
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            this.IsMdiContainer = false;
            menuStrip1.Visible = false;
            txt_mk.Text = "";
            txt_tk.Text = "";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn đăng xuất và thoát khỏi hệ thống?", "Xóa phòng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }

        }

        private void quảnLýKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Khach khach = new QL_Khach();
            khach.ShowDialog();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Phong phong = new QL_Phong();
            phong.ShowDialog();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Dichvu dv = new QL_Dichvu();
            dv.ShowDialog();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Chothuephong tp = new QL_Chothuephong();
            tp.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sửDụngDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QL_SDDV sddv = new QL_SDDV();
            sddv.ShowDialog();
        }

        private void tìmKiếmKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
      
            this.Close();
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dnhap.PerformClick();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
