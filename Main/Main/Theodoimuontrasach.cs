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
    public partial class Theodoimuontrasach : Form
    {
        public Theodoimuontrasach()
        {
            InitializeComponent();
        }
       Ketnoi tv = new Ketnoi();
       private void Xoa()
       {
           txtSophieu.Clear();
       }
       private void Hienthi()
       {
           string sql = "select *from Chitietphieumuon";
           dgrMuonsach.DataSource = tv.Taobang(sql);
       }
       public static DataTable Sophieu()
       {
           string sql = "select DISTINCT SoPhieu from Chitietphieumuon";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }
       public static DataTable MatheSV()
       {
           string sql = "select MaThe from The";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }
       public static DataTable MatheMuon()
       {
           string sql = "select DISTINCT MaThe from Chitietphieumuon";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }
       public static DataTable MaSV()
       {
           string sql = "select MaSV from The";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }
       public static DataTable MaSach()
       {
           string sql = "select MaSach from Sach";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }
       public static DataTable TenSach()
       {
           string sql = "select TenSach from Sach";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }
       public static DataTable NgayHenTra()
       {
           string sql = "select NgayTra from Chitietphieumuon";
           Ketnoi db = new Ketnoi();
           DataTable ds;
           ds = db.Taobang(sql);
           return ds;
       }

       private void Theodoimuontrasach_Load(object sender, EventArgs e)
       {
           //lay ma the cua SV muon sach
           cmbMathe.DataSource = MatheSV();
           cmbMathe.DisplayMember = "MaThe";
           //lay ma the da muon de theo doi viec tra sach
           cmbMathetra.DataSource = MatheMuon();
           cmbMathetra.DisplayMember = "MaThe";
           //lay so phieu muon
           cmbSophieu.DataSource = Sophieu();
           cmbSophieu.DisplayMember = "SoPhieu";
           //Lay ma sach SV muon
           cmbMasach.DataSource = MaSach();
           cmbMasach.DisplayMember = "MaSach";
           //Lay ten sach SV muon
           cmbTensach.DataSource = TenSach();
           cmbTensach.DisplayMember = "TenSach";
           //Lay ngay hen tra sach cua SV
           cmbNgayhentra.DataSource = NgayHenTra();
           cmbNgayhentra.DisplayMember = "NgayTra";
           cmbTinhtrangsach.SelectedItem = "Tốt";
           Hienthi();
           Xoa();
       }
       int dong;

       private void dgrMuonsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           dong = e.RowIndex;
           txtSophieu.Text = dgrMuonsach.Rows[dong].Cells[1].Value.ToString();
           cmbMasach.Text = dgrMuonsach.Rows[dong].Cells[3].Value.ToString();

       }

       private void btnMuon_Click(object sender, EventArgs e)
       {
           //lay ma sv
           string SV = "select MaSV from The where MaThe='" + cmbMathe.Text.ToString() + "'";
           string MaSV = Convert.ToString(tv.executeScalar(SV));
           //lay ten SV tu bang docgia
           string SV1 = "select TenSV from Docgia where MaSV='" + MaSV + "'";
           string TenSV = Convert.ToString(tv.executeScalar(SV1));
           //lay ma the loai
           string theloai = "select MaTheLoai from Sach where MaSach='" + cmbMasach.Text.ToString() + "'";
           string Matheloai = Convert.ToString(tv.executeScalar(theloai));
           //lay ma nha xuat ban
           string NXB = "select MaNXB from Sach where MaSach='" + cmbMasach.Text.ToString() + "'";
           string MaNXB = Convert.ToString(tv.executeScalar(NXB));
           //số sách mượn
           int sosach = Convert.ToInt32(cmbSoluongmuon.Text.ToString());
           string sql2 = "select COUNT(SoPhieu) from Chitietphieumuon where MaThe='" + cmbMathe.Text.ToString() + "'";
           int soluongmuon = Convert.ToInt32(tv.executeScalar(sql2));

           string sql1 = "select NgayHetHan from The where MaThe='" + cmbMathe.Text.ToString() + "'";
           string NgayHetHan = Convert.ToString(tv.executeScalar(sql1));
           
           int ngay = Convert.ToInt32(NgayHetHan.Substring(3, 2));
           int thang = Convert.ToInt32(NgayHetHan.Substring(0, 2));
           int nam = Convert.ToInt32(NgayHetHan.Substring(6, 4));
           DateTime dt1 = new DateTime(nam, thang, ngay);
           DateTime dt2 = new DateTime();
           dt2 = DateTime.Today;

           string sql = "Insert into Chitietphieumuon values(" + txtSophieu.Text + ",'" + cmbMathe.Text.ToString() + "','" + MaSV + "','" + cmbMasach.Text.ToString() + "','" + Matheloai + "','" + MaNXB + "',N'" + cmbTensach.Text.ToString() + "','" + dtNgaymuon.Value.ToString() + "','" + dtNgaytra.Value.ToString() + "'";

           if (txtSophieu.Text.Length != 0)
           {
               if (dt1 > dt2)
               {
                   if (soluongmuon < Convert.ToInt32(cmbSoluongmuon.Text.ToString()))
                   {
                       try
                       {
                           tv.ExcuteNonQuery(sql);
                           Hienthi();
                           Xoa();
                       }
                       catch (Exception)
                       {
                           MessageBox.Show("Đã mượn sách này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           txtSophieu.Clear();
                       }
                   }
                   else
                       MessageBox.Show("Hết sách mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else
                   MessageBox.Show("Thẻ đã hết hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           }
           else
               MessageBox.Show("Chưa nhập số phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

       private void btnXoa_Click(object sender, EventArgs e)
       {
           string sql = "Delete from Chitietphieumuon where SoPhieu=" + txtSophieu.Text + "";
           DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa Nhà Phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (traloi == DialogResult.Yes)
           {
               tv.ExcuteNonQuery(sql);
               Hienthi();
               Xoa();
           }
       }

       private void btnThoat_Click(object sender, EventArgs e)
       {
           DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if (traloi == DialogResult.OK)
           {
               Close();
           }
       }

       private void btnTra_Click(object sender, EventArgs e)
       {
           string ngaytra = dtNgaythuctra.Value.ToString();
           string ngayhentra = cmbNgayhentra.Text.ToString();
           string sql = "Delete from Chitietphieumuon where MaThe='" + cmbMathetra.Text.ToString() + "'";
        
           int ngay1 = Convert.ToInt32(ngaytra.Substring(3, 2));
           int thang1 = Convert.ToInt32(ngaytra.Substring(0, 2));
           int nam1 = Convert.ToInt32(ngaytra.Substring(6, 4));
           int ngay2 = Convert.ToInt32(ngayhentra.Substring(3, 2));
           int thang2 = Convert.ToInt32(ngayhentra.Substring(0, 2));
           int nam2 = Convert.ToInt32(ngayhentra.Substring(6, 4));

           DateTime ngaytrathuc = new DateTime(nam1, thang1, ngay1);
           DateTime ngayhenTra = new DateTime(nam2, thang2, ngay2);
           if (ngaytrathuc <= ngayhenTra && cmbTinhtrangsach.Text.ToString() == "Tốt")
           {
               tv.ExcuteNonQuery(sql);
               Hienthi();
               txtThongbao.Text = "Đã trả sách và tình tạng sách" + cmbTinhtrangsach.Text.ToString() + "";

           }
           else
           {
               TimeSpan songay = ngaytrathuc - ngayhenTra;
               int ngay = Convert.ToInt32(songay.TotalDays);
               float sotien = (float)(ngay * 0.1);
               tv.ExcuteNonQuery(sql);
               Hienthi();
               txtThongbao.Text = "Đã trả sách và tình trạng sách" + cmbTinhtrangsach.Text.ToString() + "đã trả muộn sách" + ngay + "ngày và số tiền bị phạt là :" + sotien + "vnđ";

           }
       }

       private void cmbMathe_SelectedIndexChanged(object sender, EventArgs e)
       {
       }

       private void cmbMasach_SelectedIndexChanged(object sender, EventArgs e)
       {
           string sach = "select MaSach from Sach where MaSach='" + cmbMasach.Text.ToString() + "'";
           string MaSach = Convert.ToString(tv.executeScalar(sach));
           cmbMasach.Text = MaSach;
       }

       private void cmbTensach_SelectedIndexChanged(object sender, EventArgs e)
       {
           string sach = "select TenSach from Sach where TenSach=N'" + cmbTensach.Text.ToString() + "'";
           string TenSach = Convert.ToString(tv.executeScalar(sach));
           cmbTensach.Text = TenSach;
       }

       private void txtSophieu_TextChanged(object sender, EventArgs e)
       {
           string ngayhentra = "select NgayTra from Chitietphieumuon where SoPhieu='" + txtSophieu.Text.ToString() + "'";
           string ngay = Convert.ToString(tv.executeScalar(ngayhentra));
           dtNgaytra.Text = ngay;
       }

       private void cmbMathetra_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void tabPage3_Click(object sender, EventArgs e)
       {

       }

       private void tabPage4_Click(object sender, EventArgs e)
       {

       }




       

    }
}
