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
            int sdthoai;
            Regex reg = new Regex("\\d{10,11}");
            if (reg.IsMatch(sdt) && (int.TryParse(sdt, out sdthoai) == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Set_Empty()
        {
            txt_cmt.Text = "";
            txt_dchi.Text = "";
            txt_dt.Text = "";
            txt_ten.Text = "";
            cbb_gtinh.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                btn_them.Text = "Lưu lại";
                anhien(true);
                khachBindingSource.AddNew();
                khachdataGridView1.BeginEdit(true);
                khoacn(false);
                txt_cmt.Focus();
                btn_them.Enabled = true;
            }
            else
            {
                if ((txt_cmt.Text != "") && (txt_ten.Text != "") && (txt_dchi.Text != "") && (cbb_gtinh.Text != "") && (txt_dt.Text != ""))
                {
                    if (ktra_cmt(txt_cmt.Text) == true)
                    {
                        if (ktra_sdt(txt_dt.Text) == true)
                        {
                            Khach ktra = (from khach in db.Khaches
                                          where khach.CMT == txt_cmt.Text.Trim()
                                          select khach).SingleOrDefault();
                            if (ktra == null)
                            {
                                khachBindingSource.EndEdit();
                                Khach khachs = new Khach();
                                khachs.CMT = txt_cmt.Text;
                                khachs.Hoten = txt_ten.Text;
                                khachs.Diachi = txt_dchi.Text;
                                khachs.GT = cbb_gtinh.Text;
                                khachs.SDT = txt_dt.Text;
                                db.Khaches.InsertOnSubmit(khachs);
                                db.SubmitChanges();
                                anhien(false);
                                MessageBox.Show("Thành công!", "Thêm khách hàng");
                                btn_them.Text = "Thêm";
                                khoacn(true);
                                khachDataGridView.Refresh();
                                Display();
                            }
                            else
                            {
                                khachBindingSource.CancelEdit();
                                Set_Empty();
                                MessageBox.Show("Số CMND này đã được đăng ký. Vui lòng kiểm tra lại");
                                txt_cmt.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập vào số điện thoại không đúng", "Lỗi");
                            txt_dt.Text = "";
                            txt_dt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập chính xác số chứng minh nhân dân", "Lỗi");
                        txt_cmt.Text = "";
                        txt_cmt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập vào đầy đủ dữ liệu", "Lỗi");
                }
            }
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
