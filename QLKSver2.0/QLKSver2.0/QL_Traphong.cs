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
using System.Data.SqlClient;

namespace QLKS
{
    public partial class QL_Traphong : Form
    {
        QLTPDataContext db = new QLTPDataContext();
        public QL_Traphong()
        {
            InitializeComponent();
        }

        private void QL_Traphong_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLTPDataSet.Khach' table. You can move, or remove it, as needed.
            //this.khachTableAdapter.Fill(this.qLTPDataSet.Khach);
            //// TODO: This line of code loads data into the 'qLTPDataSet.ThueP' table. You can move, or remove it, as needed.
            //this.thuePTableAdapter.Fill(this.qLTPDataSet.ThueP);
            btn_trap.Enabled = false;
            btn_ttoan.Enabled = false;
            panel1.Visible = false;
        }
        public void Show_Phong(string map)
        {
            List<Phong> phong = new List<Phong>();
            var query = (from n in db.Phongs
                         where n.MaP == map
                         select n);
            phong = query.ToList<Phong>();
            phongBindingSource.DataSource = phong;
        }
        public void Show_Khach(string ten)
        {
            List<Khach> khach = new List<Khach>();
            var query = (from n in db.Khaches
                         where n.Hoten.Contains(ten)
                         select n);
            khach = query.ToList<Khach>();
            khachBindingSource.DataSource = khach;
        }

        public void Show_ThueP(string cmt)
        {
            List<ThueP> thue = new List<ThueP>();
            var query = (from n in db.ThuePs
                         where n.CMT == cmt && n.Ngaydi == null
                         select n);
            thue = query.ToList<ThueP>();
            thuePBindingSource.DataSource = thue;
        }

        private void btn_trap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trả phòng " + txt_tenphong.Text + " không?", "Trả phòng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                ThueP tra = db.ThuePs.FirstOrDefault(s => s.MaHD == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                tra.Ngaydi = DateTime.Now.Date;
                dataGridView1.CurrentRow.Cells[4].Value = DateTime.Now.Date;
                Phong phong = db.Phongs.FirstOrDefault(s => s.TenP == txt_tenphong.Text);
                phong.Tinhtrang = "Trống";
                try
                {
                    db.SubmitChanges();
                    thuePBindingSource.MoveNext();
                }
                catch { }
            }
            btn_ttoan.Enabled = true;
        }
        
        
        private void btn_ttoan_Click(object sender, EventArgs e)
        {
            //SqlConnectionStringBuilder ctring;
            //ctring = new SqlConnectionStringBuilder(Properties.Settings.Default.QLTPConnectionString2);
            ////truyền parametter cho hóa đơn dịch vụ
            //crhdondv.SetParameterValue(0, dataGridView2.CurrentRow.Cells[0].Value.ToString());
            //crhdondv.SetParameterValue(1, dataGridView1.CurrentRow.Cells[3].Value.ToString());
            //crhdondv.SetParameterValue(2, dataGridView1.CurrentRow.Cells[2].Value.ToString());
            //// truyền parametter cho hóa đơn phòng
            //crhoadon.SetParameterValue(0, dataGridView2.CurrentRow.Cells[0].Value.ToString());
            //CrystalDecisions.CrystalReports.Engine.Tables tables = crhoadon.Database.Tables;
            //foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            //{
            //    CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
            //    tableLogOnInfo.ConnectionInfo.ServerName = ctring.DataSource;
            //    tableLogOnInfo.ConnectionInfo.IntegratedSecurity = ctring.IntegratedSecurity;
            //    tableLogOnInfo.ConnectionInfo.DatabaseName = ctring.InitialCatalog;
            //    table.ApplyLogOnInfo(tableLogOnInfo);
            //}

            //panel1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Show_Khach(txt_tkiem.Text);
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Show_Phong(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                btn_trap.Enabled = true;
            }
            catch
            {

            }
        }
    }
}
