using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bài_tập_lớn
{
    public partial class Search : Form
    {
        DataTable dt;
        DataView dv;
        SqlDataAdapter adapter;
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {  
            SqlConnection con=new SqlConnection(@"Data Source=FUJITSU;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            string sql = "select *from Sach";
            adapter = new SqlDataAdapter(sql,con);
            dt = new DataTable("Sach");
            adapter.Fill(dt);
            dv=new DataView(dt);
            dgrTimkiem.DataSource =dv;
            
           
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tensach = txtNhapmasach.Text;
            dv.RowFilter = "MaSach like'" + tensach + "'";
            dgrTimkiem.DataSource = dv;
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
