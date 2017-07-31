using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_tập_lớn
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        Ketnoi tv = new Ketnoi();

        private void Thongke_Load(object sender, EventArgs e)
        {
            tv.connect();
            string sql = "select * from Theloai";
            cmbMatheloai.DataSource = tv.Taobang(sql);
            cmbMatheloai.DisplayMember = "MaTheLoai";
            dgrThongke.DataSource = tv.Taobang("select * from Sach");
            tv.disconnect();
            
        }

        private void cmbMatheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cmbMatheloai.SelectedValue.ToString();
            dgrThongke.DataSource=tv.Taobang("select * from Sach where Sach.MaTheLoai='"+ma+"'");
            string sql2 = "select count(*) from Sach" + "where MaTheLoai='" + cmbMatheloai.Text + "'group by MaTheLoai";
            txtTongso.Text = (dgrThongke.Rows.Count).ToString();
           

        }

        private void dgrThongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                Close();
            }
        }

    }
}
