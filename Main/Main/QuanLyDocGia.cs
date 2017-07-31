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
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
        }
        Ketnoi tv = new Ketnoi();
        public void Xoa()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtLop.Clear();
            txtKhoa.Clear();
        }
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            tv.connect();
            string sql = "Select*from Docgia";
            dgrQuanlydocgia.DataSource = tv.Taobang(sql);
            Xoa();
            tv.disconnect();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            action = 1;
            btnCapNhat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string MaSV = dgrQuanlydocgia.Rows[dong].Cells[0].Value.ToString();
                string HoTen = dgrQuanlydocgia.Rows[dong].Cells[1].Value.ToString();
                string gioitinh = dgrQuanlydocgia.Rows[dong].Cells[2].Value.ToString();
                string NgaySinh = dgrQuanlydocgia.Rows[dong].Cells[3].Value.ToString();
                string Lop = dgrQuanlydocgia.Rows[dong].Cells[4].Value.ToString();
                string Khoa = dgrQuanlydocgia.Rows[dong].Cells[5].Value.ToString();
                string sql = "Delete from Docgia where MaSV='" + MaSV + "',HoTen='" + HoTen + "',GioiTinh='"+gioitinh+"',NgaySinh='" + NgaySinh + "',Lop='" + Lop + "',Khoa='" + Khoa + "'";
                if (DialogResult == DialogResult.OK)
                 {
                tv.ExcuteNonQuery(sql);
                 Xoa();
                }
                 sql = "select MaSV as 'Mã SV',Hoten as 'Họ Tên',GioiTinh as 'Giới tính',NgaySinh as 'Ngày Sinh',Lop as 'Lớp',Khoa as 'Khoa' from DOCGIA";
                 dgrQuanlydocgia.DataSource = tv.Taobang(sql);

            }

        private static int action;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (action.Equals("Insert"))
            {
                if (rbnNam.Checked)
                {
                    sql = "Insert into DOCGIA values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "',N'Nam','" + mkbNgaySinh.Text + "',N'" + txtLop.Text + "'," + txtKhoa.Text + ")";
                    tv.ExcuteNonQuery(sql);
                }
                else
                    if (rbnNu.Checked)
                    {
                        sql = "Insert into DOCGIA values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "',N'Nu','" + mkbNgaySinh.Text + "',N'" + txtLop.Text + "'," + txtKhoa.Text + ")";
                        tv.ExcuteNonQuery(sql);
                    }

                    else
                    {
                        MessageBox.Show("Chưa chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }

            else
            {
                if (rbnNam.Checked)
                {
                    string sql1 = "update Docgia set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'Nam',NgaySinh=N'" + mkbNgaySinh.Text + "',Lop=N'" + txtLop + "',Khoa=N'" + txtKhoa.Text + " where MaSV='" + txtMaSV.Text + "'";
                    tv.ExcuteNonQuery(sql1);

                }
                else
                    if (rbnNu.Checked)
                    {
                        string sql1 = "update Docgia set HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'Nu',NgaySinh=N'" + mkbNgaySinh.Text + "',Lop=N'" + txtLop + "',Khoa=N'" + txtKhoa.Text + " where MaSV='" + txtMaSV.Text + "'";
                        tv.ExcuteNonQuery(sql1);

                    }
                    else
                    {
                        MessageBox.Show("chưa chọn giới tính!", "Lỗi", MessageBoxButtons.OK);

                    }
            }
            sql = "select MaSV as 'Mã SV',Hoten as 'Họ Tên',GioiTinh as 'Giới tính',NgaySinh as 'Ngày Sinh',Lop as 'Lớp',Khoa as 'Khoa' from DOCGIA";
            dgrQuanlydocgia.DataSource = tv.Taobang(sql);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

           action=2;
            btnCapNhat.Enabled = true;
        }
        int dong;
        private void dgrQuanlydocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaSV.Text = dgrQuanlydocgia.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgrQuanlydocgia.Rows[dong].Cells[1].Value.ToString();
            string gioitinh = dgrQuanlydocgia.Rows[dong].Cells[2].Value.ToString();
            mkbNgaySinh.Text = dgrQuanlydocgia.Rows[dong].Cells[3].Value.ToString();
            txtLop.Text = dgrQuanlydocgia.Rows[dong].Cells[4].Value.ToString();
            txtKhoa.Text = dgrQuanlydocgia.Rows[dong].Cells[5].Value.ToString();
            if (gioitinh.Trim() == "Nam")
            {
                rbnNam.Checked = true;
            }
            if (gioitinh.Trim() == "Nu")
            {
                rbnNu.Checked = true;
            }
        }

        private void NhapThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}
