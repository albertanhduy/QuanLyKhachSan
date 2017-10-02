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
        public void ShowPhong()
        {
            List<Phong> list = new List<Phong>();
            var query = (from n in db.Phongs
                         where n.Tinhtrang == "Trống"
                         select n);
            list = query.ToList<Phong>();
            phongBindingSource.DataSource = list;
        }

        public void ShowKhach()
        {
            List<Khach> list = new List<Khach>();
            var query = (from n in db.Khaches
                         select n);
            list = query.ToList<Khach>();
            khachBindingSource.DataSource = list;
        }
        List<ThueP> listthuep = new List<ThueP>();
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
        public void ShowPhong()
        {
            List<Phong> list = new List<Phong>();
            var query = (from n in db.Phongs
                         where n.Tinhtrang == "Trống"
                         select n);
            list = query.ToList<Phong>();
            phongBindingSource.DataSource = list;
        }
        public void ShowKhach()
        {
            List<Khach> list = new List<Khach>();
            var query = (from n in db.Khaches
                         select n);
            list = query.ToList<Khach>();
            khachBindingSource.DataSource = list;
        }
<<<<<<< HEAD
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
=======
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
        public void ShowThueP()
        {
            thuePBindingSource.DataSource = listthuep;
        }
        private void QL_Chothuephong_Load(object sender, EventArgs e)
        {
            ShowPhong();
            ShowKhach();
            btn_chonp.Enabled = false;
            btn_thue.Enabled = false;
        }

        private void cbb_loaip_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            List<Phong> list = new List<Phong>();
=======
           List<Phong> list = new List<Phong>();
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
=======
           List<Phong> list = new List<Phong>();
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
            var query2 = (from phong in db.Phongs
                          where phong.LoaiP == cbb_loaip.Text && phong.Tinhtrang == "Trống"
                          select phong);
            list = query2.ToList<Phong>();
            phongBindingSource.DataSource = list;
        }

        private void txt_cmt_TextChanged(object sender, EventArgs e)
        {
            var query = (from n in db.Khaches
                         where n.CMT.Contains(txt_cmt.Text)
                         select n);
            khachBindingSource.DataSource = query.ToList<Khach>();
        }

        private void btn_themk_Click(object sender, EventArgs e)
        {
            if (btn_themk.Text == "Thêm khách")
            {
                btn_chonk.Enabled = false;

                btn_themk.Text = "Cập nhật bảng";
                QL_Khach khach = new QL_Khach();
                khach.ShowDialog();
            }
            else
            {
                khachBindingSource.DataSource = null;
                ShowKhach();
                btn_themk.Text = "Thêm khách";
                btn_chonk.Enabled = true;
            }
        }

        private void btn_chonp_Click(object sender, EventArgs e)
        {

            btn_thue.Enabled = true;
            try
            {
                if (thuePDataGridView.CurrentRow.Cells[2].Value != null)
                {
                    //                   thuePBindingSource.AddNew();
                    //                    CurrencyManager cm;
                    //                   cm = this.BindingContext[thuePBindingSource];
                    thuePDataGridView.CurrentRow.Cells[1].Value = khachDataGridView.CurrentRow.Cells[0].Value.ToString();
                }
                //            phongDataGridView.CurrentRow.Cells[4].Value = "Dang duoc chon";
                thuePDataGridView.CurrentRow.Cells[2].Value = phongDataGridView.CurrentRow.Cells[0].Value.ToString();
                thuePDataGridView.CurrentRow.Cells[3].Value = DateTime.Now.Date;
            }
            catch
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        private void btn_chonk_Click(object sender, EventArgs e)
        {
            thuePBindingSource.AddNew();
            thuePDataGridView.CurrentRow.Cells[1].Value = khachDataGridView.CurrentRow.Cells[0].Value.ToString();
            btn_chonk.Enabled = false;
            btn_chonp.Enabled = true;
        }

        private void btn_thue_Click(object sender, EventArgs e)
        {
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên", "Lỗi");
            }
            else
            {
<<<<<<< HEAD
<<<<<<< HEAD
=======
                
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
=======
                
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
                DataGridViewRow row = thuePDataGridView.Rows[thuePDataGridView.Rows.Count - 2];
                thuePDataGridView.Rows[thuePDataGridView.Rows.Count - 2].Cells[5].Value = txt_tennv.Text;
                ThueP thuep = new ThueP();
                thuep.CMT = row.Cells[1].Value.ToString();
                thuep.MaP = row.Cells[2].Value.ToString();
                thuep.Ngayden = DateTime.Now.Date;
                thuep.TenNV = txt_tennv.Text;
                db.ThuePs.InsertOnSubmit(thuep);
                //                   Phong phong = db.Phongs.FirstOrDefault(s => s.MaP == row.Cells[2].Value.ToString());
                listthuep.Add(thuep);
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
=======
>>>>>>> ff080dd176d698732f92114dd949d56327b6a365
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Thuê phòng thành công", "Thuê phòng");
            }
            catch
            {
            }
            finally
            {
                btn_chonk.Enabled = true;
                btn_thue.Enabled = false;
                //                thuePBindingSource.DataSource = null;
                //               ShowThueP();
                txt_tennv.Text = "";
            }
        }
    }
}
