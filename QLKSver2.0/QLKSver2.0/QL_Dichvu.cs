﻿using System;
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
            this.dichvuTableAdapter.Fill(this.qLTPDataSet.Dichvu);
            Display();
            anhien(false);
            khoacn(true);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                btn_them.Text = "Lưu lại";
                anhien(true);
                dichvuBindingSource.AddNew();
                dichvuDataGridView.BeginEdit(true);
                khoacn(false);
                txt_ma.Focus();
                btn_them.Enabled = true;

            }
            else
            {
                if ((txt_gia.Text != "") && (txt_ma.Text != "") && (txt_ten.Text != "") && (txt_gia.Text != ""))
                {
                    if (ktra_gia(txt_gia.Text) == true)
                    {
                        Khach ktra = (from khach in dt.Khaches
                                      where khach.CMT == txt_ma.Text.Trim()
                                      select khach).SingleOrDefault();
                        if (ktra == null)
                        {
                            dichvuBindingSource.EndEdit();
                            Dichvu dv = new Dichvu();
                            dv.MaDV = txt_ma.Text;
                            dv.TenDV = txt_ten.Text;
                            dv.GiaDV = Double.Parse(txt_gia.Text);
                            dv.DVT = txt_dvt.Text;
                            dt.Dichvus.InsertOnSubmit(dv);
                            dt.SubmitChanges();
                            anhien(false);
                            MessageBox.Show("Thành công!", "Thêm dịch vụ");
                            btn_them.Text = "Thêm";
                            khoacn(true);
                            Display();
                        }
                        else
                        {
                            MessageBox.Show("Mã dịch vụ đã tồn tại. Vui lòng kiểm tra lại");
                            txt_ma.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập giá là một số nguyên", "Lỗi");
                        txt_gia.Text = "";
                        txt_gia.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào", "Lỗi");
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

        private void dichvuDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
