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
using Microsoft.VisualBasic;

namespace QLKS
{
    public partial class QL_SDDV : Form
    {
        public QL_SDDV()
        {
            InitializeComponent();
        }
        QLTPDataContext db;
        public void Show_TreeView()
        {
            tv_khach.Nodes.Clear();
            var query_cha = (from kh in db.Khaches
                             select kh);
            List<Khach> khg = new List<Khach>();
            khg = query_cha.ToList<Khach>();
            for (int i = 0; i < khg.Count - 1; i++)
            {
                tv_khach.Nodes.Add(khg[i].CMT, khg[i].Hoten);
                string cmt = khg[i].CMT;
                var query_con = (from tp in db.ThuePs
                                 where tp.CMT == cmt && tp.Ngaydi == null
                                 select tp);
                List<ThueP> tpg = new List<ThueP>();
                tpg = query_con.ToList<ThueP>();
                for (int j = 0; j < tpg.Count - 1; j++)
                {
                    var query = (from ph in db.Phongs
                                     //group ph by ph.MaP into kq
                                 where ph.MaP == tpg[j].MaP
                                 select ph);
                    List<Phong> phong = new List<Phong>();
                    phong = query.ToList<Phong>();
                    tv_khach.Nodes[i].Nodes.Add(phong[0].MaP, phong[0].TenP);
                }
            }
        }
        public void Show_DV()
        {
            var query = (from n in db.Dichvus
                         select n);
            dichvuBindingSource.DataSource = query.ToList<Dichvu>();
        }

        private void QL_SDDV_Load(object sender, EventArgs e)
        {
            db = new QLTPDataContext();
            Show_TreeView();
            Show_DV();
        }

        public void Show_theokh()
        {
            //           string str =  tv_khach.SelectedNode.Name;
            var query = (from n in db.SDDVs
                         where n.CMT == tv_khach.SelectedNode.Name
                         select n);
            sDDVBindingSource.DataSource = query.ToList();
        }
        public void Show_theoph()
        {
            var query = (from n in db.SDDVs
                         where n.CMT == tv_khach.SelectedNode.Parent.Name && n.MaP == tv_khach.SelectedNode.Name
                         select n);
            sDDVBindingSource.DataSource = query.ToList();
        }

        private void tv_khach_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
        }
        //}

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }
    }
}
