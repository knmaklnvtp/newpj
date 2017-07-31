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
    public partial class QuanlySach : Form
    {
        public QuanlySach()
        {
            InitializeComponent();
        }

        Ketnoi tv = new Ketnoi();

        private void Xoasach()
        {
            txtTensach.Clear();
            txtSoluong.Clear();
            txtMasach.Clear();
        }
        private void XoaTheloai()
        {
            txtMatheloai.Clear();
            txtTentheloai.Clear();
        }
        private void XoaNXB()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiachi.Clear();
        }
        public static DataTable TenTheLoai()
        {
            string sql = "select TenTheLoai from Theloai";
            Ketnoi db = new Ketnoi();
            DataTable ds;
            ds = db.Taobang(sql);
            return ds;

        }
        public static DataTable TenNXB()
        {
            string sql = "select TenNXB from Nhaxuatban";
            Ketnoi db = new Ketnoi();
            DataTable ds;
            ds = db.Taobang(sql);
            return ds;

        }

        private void QuanlySach_Load(object sender, EventArgs e)
        {
            cmbTinhtrangsach.Items.Add("Tốt");
            cmbTinhtrangsach.Items.Add("Xấu");
            cmbTinhtrangsach.Items.Add("Bình thường");
            cmbTinhtrangsach.SelectedItem = "Tốt";
            cmbNgonngu.SelectedItem = "Tiếng việt";
           
            string sql1 = "select * from Sach";
            dgrThongtin.DataSource = tv.Taobang(sql1);
            Xoasach();

            string sql2 = "select * from Theloai";
            dgrTheloai.DataSource = tv.Taobang(sql2);
            XoaTheloai();

            string sql3 = "select * from Nhaxuatban";
            dgrNhaxuatban.DataSource = tv.Taobang(sql3);
            XoaNXB();

            cmbTenNXB.DataSource = TenNXB();
            cmbTenNXB.DisplayMember = "TenNXB";

            cmbTentheloai.DataSource = TenTheLoai();
            cmbTentheloai.DisplayMember = "Tentheloai";
        }

        private void btnThemtheloai_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TheLoai values('" + txtMatheloai.Text + "',N'" + txtTentheloai.Text + "')";
            try
            {
                tv.ExcuteNonQuery(sql);
                string sql1 = "Select *from TheLoai";
                dgrTheloai.DataSource = tv.Taobang(sql1);
                XoaTheloai();

            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại thể loại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatheloai.Clear();
                txtMatheloai.Focus();

            }
        }

        private void btnSuatheloai_Click(object sender, EventArgs e)
        {
            string sql = "Update TheLoai set TenTheLoai = N'" + txtTentheloai.Text + "' where MaTheLoai='" + txtMatheloai.Text + "'";
            tv.ExcuteNonQuery(sql);
            string sql1 = "Select *from TheLoai";
            dgrTheloai.DataSource = tv.Taobang(sql1);
            XoaTheloai();
        }

        private void btnXoatheloai_Click(object sender, EventArgs e)
        {
            string sql = "Delete from TheLoai where MaTheLoai='" +txtMatheloai.Text + "'";
            DialogResult thongbao = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                tv.ExcuteNonQuery(sql);
                string sql1 = "Select *from TheLoai";
                dgrTheloai.DataSource = tv.Taobang(sql1);
                XoaTheloai();
            }
        }
        int tl;
        private void dgrTheloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tl = e.RowIndex;
            txtMatheloai.Text = dgrTheloai.Rows[tl].Cells[0].Value.ToString();
            txtTentheloai.Text = dgrTheloai.Rows[tl].Cells[1].Value.ToString();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhaXuatBan values('" + txtMaNXB.Text + "',N'" + txtTenNXB.Text + "',N'" + txtDiachi.Text + "','" + dtNgaythanhlap.Value.ToString() + "')";
            try
            {
                tv.ExcuteNonQuery(sql);
                string sql1 = "Select *from NhaXuatBan";
                dgrNhaxuatban.DataSource = tv.Taobang(sql1);
                XoaNXB();

            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại NXB !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNXB.Clear();
                txtMaNXB.Focus();

            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            string sql = "Update NhaXuatBan set TenNXB =N'" + txtTenNXB.Text + "',DiaChi =N'" + txtDiachi.Text + "',NgayThanhLap='" + dtNgaythanhlap.Value.ToString() + "' where MaNXB='" + txtMaNXB.Text + "'";
            tv.ExcuteNonQuery(sql);
            string sql1 = "Select *from NhaXuatBan";
            dgrNhaxuatban.DataSource = tv.Taobang(sql1);
            XoaNXB();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            string sql1 = "Delete from NhaXuatBan where MaNXB ='" + txtMaNXB.Text + "'";
            string sql2 = "Delete from Sach where MaNXB='" + txtMaNXB.Text + "'";
            DialogResult thongbao = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                tv.ExcuteNonQuery(sql1);
                tv.ExcuteNonQuery(sql2);
                string sql3 = "Select *from NhaXuatBan";
                dgrNhaxuatban.DataSource = tv.Taobang(sql3);
                XoaNXB();
            }
        }
        int NXB;

        private void dgrNhaxuatban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NXB = e.RowIndex;
            txtMaNXB.Text = dgrNhaxuatban.Rows[NXB].Cells[0].Value.ToString();
            txtTenNXB.Text = dgrNhaxuatban.Rows[NXB].Cells[1].Value.ToString();
            txtDiachi.Text = dgrNhaxuatban.Rows[NXB].Cells[2].Value.ToString();

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            //lấy mã thể loại
            string theloai = "Select MaTheLoai from TheLoai where TenTheLoai=N'" + cmbTentheloai.Text.ToString() + "'";
            string MaTL = Convert.ToString(tv.executeScalar(theloai));
            //Lấy mã NXB
            string nxb = "Select MaNXB from NhaXuatBan where TenNXB=N'" + cmbTenNXB.Text.ToString() + "'";
            string MaNXB = Convert.ToString(tv.executeScalar(nxb));
            string sql = "Insert into Sach values('" + txtMasach.Text + "',N'" + txtTensach.Text + "'," + cmbTenNXB.Text.ToString() + "," + cmbTentheloai.Text.ToString() + "," + txtSoluong.Text + "," + cmbTinhtrangsach.Text.ToString() + "," + cmbNgonngu.Text.ToString() + "','" + MaTL + "','" + MaNXB + "')";
            if (txtMasach.Text.Length != 0 && txtTensach.Text.Length != 0)
            {
                try
                {
                    tv.ExcuteNonQuery(sql);
                    string sql1 = "select * from Sach";
                    dgrThongtin.DataSource = tv.Taobang(sql1);
                    Xoasach();
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sách đã tồn !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMasach.Clear();
                }
            }
            else
                MessageBox.Show("Mã sách và tên sách không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string theloai = "Select MaTheLoai from TheLoai where TenTheLoai=N'" + cmbTentheloai.Text.ToString() + "'";
            string MaTheLoai = Convert.ToString(tv.executeScalar(theloai));
            //Lấy mã NXB
            string NXB = "Select MaNXB from NhaXuatBan where TenNXB=N'" + cmbTenNXB.Text.ToString() + "'";
            string MaNXB = Convert.ToString(tv.executeScalar(NXB));

            string sql = "Update Sach set TenSach=N'" + txtTensach.Text + "',TinhTrangSach=N'" +cmbTinhtrangsach.Text.ToString() + "',NgonNgu=N'"
            + cmbNgonngu.Text.ToString() + "',MaTheLoai='" + MaTheLoai + "',MaNXB='"+ MaNXB + "' where MaSach ='" + txtMasach.Text + "'";

            tv.ExcuteNonQuery(sql);
            string sql1 = "Select *from Sach";
            dgrThongtin.DataSource = tv.Taobang(sql1);
            Xoasach();
       
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Sach where MaSach = '" + txtMasach.Text + "'";
            DialogResult thongbao = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                tv.ExcuteNonQuery(sql);
                string sql1 = "Select *from Sach";
                dgrThongtin.DataSource = tv.Taobang(sql1);
            }
            Xoasach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                Close();
            }
        }





       


    }
}
