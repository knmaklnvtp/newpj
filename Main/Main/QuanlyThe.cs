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
    public partial class QuanlyThe : Form
    {
        public QuanlyThe()
        {
            InitializeComponent();
        }
        Ketnoi tv = new Ketnoi();
        private void Xoa()
        {
            txtMaThe.Clear();
            
        }
        public static DataTable CapMathe()
        {
            string sql = "select MaSV from DOCGIA";
            Ketnoi db = new Ketnoi();
            DataTable dt;
            dt = db.Taobang(sql);
            return dt;

        }
        private void QuanlyThe_Load(object sender, EventArgs e)
        {
            tv.connect();
            string sql1 = "select*from The";
            dgrQuanlythe.DataSource = tv.Taobang(sql1);
           
            tv.disconnect();
            //hien thi ma sinh vien
           cmbMaSV.DataSource = CapMathe();
           cmbMaSV.DisplayMember = "MaSV";

        }
        private int chon = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 1;
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            txtMaThe.Text  = dtpNgaycapthe.Text = dtpNgayhethan.Text = "";
            cmbMaSV.Focus();
            Xoa();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            cmbMaSV.Focus();
            Xoa();
          
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                tv.connect();
                tv.ExcuteNonQuery("Insert into The values('" + txtMaThe.Text + "','" + cmbMaSV.Text + "','" + dtpNgaycapthe.Text + "','" + dtpNgayhethan.Text + "')");
                btnLuu.Enabled = true;
            }
            else
            {
                tv.connect();
                tv.ExcuteNonQuery("Update The set NgayCapThe='" + dtpNgaycapthe.Value.ToString() + "',NgayHetHan='" + dtpNgayhethan.Value.ToString() + "'where MaSV='" + dgrQuanlythe.Rows[dong].Cells[1].Value.ToString() + "'");
                btnLuu.Enabled = true;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {

                string sql = "Delete from The where MaSV='" + cmbMaSV.Text + "'";
                tv.ExcuteNonQuery(sql);
                string sql1 = "select*from The";
                dgrQuanlythe.DataSource = tv.Taobang(sql1);
                Xoa();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                Close();
            }
        }
        int dong;
        private void dgrQuanlythe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaThe.Text = dgrQuanlythe.Rows[dong].Cells[0].Value.ToString();
            cmbMaSV.Text = dgrQuanlythe.Rows[dong].Cells[1].Value.ToString();
            dtpNgaycapthe.Text = dgrQuanlythe.Rows[dong].Cells[2].Value.ToString();
            dtpNgayhethan.Text = dgrQuanlythe.Rows[dong].Cells[3].Value.ToString();

        }

        private void grbCapthe_Enter(object sender, EventArgs e)
        {

        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
