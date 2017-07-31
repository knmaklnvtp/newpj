namespace Bài_tập_lớn
{
    partial class QuanLyDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NhapThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.rbnNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.mkbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMathe = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgrQuanlydocgia = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.NhapThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuanlydocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // NhapThongTin
            // 
            this.NhapThongTin.Controls.Add(this.groupBox1);
            this.NhapThongTin.Controls.Add(this.label1);
            this.NhapThongTin.Controls.Add(this.txtKhoa);
            this.NhapThongTin.Controls.Add(this.mkbNgaySinh);
            this.NhapThongTin.Controls.Add(this.txtLop);
            this.NhapThongTin.Controls.Add(this.txtHoTen);
            this.NhapThongTin.Controls.Add(this.txtMaSV);
            this.NhapThongTin.Controls.Add(this.lblKhoa);
            this.NhapThongTin.Controls.Add(this.lblLop);
            this.NhapThongTin.Controls.Add(this.lblNgaySinh);
            this.NhapThongTin.Controls.Add(this.lblHoTen);
            this.NhapThongTin.Controls.Add(this.lblMathe);
            this.NhapThongTin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NhapThongTin.ForeColor = System.Drawing.Color.Blue;
            this.NhapThongTin.Location = new System.Drawing.Point(34, 12);
            this.NhapThongTin.Name = "NhapThongTin";
            this.NhapThongTin.Size = new System.Drawing.Size(645, 170);
            this.NhapThongTin.TabIndex = 0;
            this.NhapThongTin.TabStop = false;
            this.NhapThongTin.Text = "Nhập Thông Tin";
            this.NhapThongTin.Enter += new System.EventHandler(this.NhapThongTin_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnNam);
            this.groupBox1.Controls.Add(this.rbnNu);
            this.groupBox1.Location = new System.Drawing.Point(178, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 36);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Location = new System.Drawing.Point(6, 9);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(49, 19);
            this.rbnNam.TabIndex = 13;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // rbnNu
            // 
            this.rbnNu.AutoSize = true;
            this.rbnNu.Location = new System.Drawing.Point(75, 11);
            this.rbnNu.Name = "rbnNu";
            this.rbnNu.Size = new System.Drawing.Size(41, 19);
            this.rbnNu.TabIndex = 14;
            this.rbnNu.Text = "Nữ";
            this.rbnNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(62, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giới tính";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(466, 115);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(121, 22);
            this.txtKhoa.TabIndex = 10;
            // 
            // mkbNgaySinh
            // 
            this.mkbNgaySinh.Location = new System.Drawing.Point(466, 28);
            this.mkbNgaySinh.Mask = "00/00/0000";
            this.mkbNgaySinh.Name = "mkbNgaySinh";
            this.mkbNgaySinh.Size = new System.Drawing.Size(121, 22);
            this.mkbNgaySinh.TabIndex = 9;
            this.mkbNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(466, 76);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(121, 22);
            this.txtLop.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(178, 69);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(139, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(178, 34);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(139, 22);
            this.txtMaSV.TabIndex = 6;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhoa.Location = new System.Drawing.Point(378, 121);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(43, 19);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLop.Location = new System.Drawing.Point(378, 79);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(34, 19);
            this.lblLop.TabIndex = 3;
            this.lblLop.Text = "Lớp";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinh.Location = new System.Drawing.Point(378, 31);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 19);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(58, 79);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 19);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMathe
            // 
            this.lblMathe.AutoSize = true;
            this.lblMathe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMathe.Location = new System.Drawing.Point(58, 34);
            this.lblMathe.Name = "lblMathe";
            this.lblMathe.Size = new System.Drawing.Size(54, 19);
            this.lblMathe.TabIndex = 0;
            this.lblMathe.Text = "Mã SV";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(34, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(168, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(444, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(604, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgrQuanlydocgia
            // 
            this.dgrQuanlydocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrQuanlydocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQuanlydocgia.Location = new System.Drawing.Point(34, 201);
            this.dgrQuanlydocgia.Name = "dgrQuanlydocgia";
            this.dgrQuanlydocgia.Size = new System.Drawing.Size(645, 138);
            this.dgrQuanlydocgia.TabIndex = 6;
            this.dgrQuanlydocgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQuanlydocgia_CellContentClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Red;
            this.btnCapNhat.Location = new System.Drawing.Point(299, 360);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 33);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 422);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgrQuanlydocgia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.NhapThongTin);
            this.Name = "QuanLyDocGia";
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            this.NhapThongTin.ResumeLayout(false);
            this.NhapThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuanlydocgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NhapThongTin;
        private System.Windows.Forms.MaskedTextBox mkbNgaySinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMathe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.RadioButton rbnNu;
        private System.Windows.Forms.RadioButton rbnNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrQuanlydocgia;
       
    }
}