namespace Bài_tập_lớn
{
    partial class QuanlySach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanlySach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNgonngu = new System.Windows.Forms.ComboBox();
            this.cmbTinhtrangsach = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cmbTentheloai = new System.Windows.Forms.ComboBox();
            this.cmbTenNXB = new System.Windows.Forms.ComboBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.dgrNhaxuatban = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.dtNgaythanhlap = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoatheloai = new System.Windows.Forms.Button();
            this.btnSuatheloai = new System.Windows.Forms.Button();
            this.btnThemtheloai = new System.Windows.Forms.Button();
            this.dgrTheloai = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTentheloai = new System.Windows.Forms.TextBox();
            this.txtMatheloai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhaxuatban)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTheloai)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(390, 551);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 43);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(32, 12);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(824, 533);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(824, 533);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "SÁCH";
            this.tabNavigationPage1.Controls.Add(this.pdfViewer1);
            this.tabNavigationPage1.Controls.Add(this.simpleButton3);
            this.tabNavigationPage1.Controls.Add(this.simpleButton2);
            this.tabNavigationPage1.Controls.Add(this.simpleButton1);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(800, 490);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(21, 254);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(667, 151);
            this.pdfViewer1.TabIndex = 12;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(536, 443);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(127, 40);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "THOÁT";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(312, 443);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(124, 41);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "SỬA";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(80, 443);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 42);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "THÊM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMasach);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbNgonngu);
            this.groupBox1.Controls.Add(this.cmbTinhtrangsach);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.cmbTentheloai);
            this.groupBox1.Controls.Add(this.cmbTenNXB);
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập sách";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(149, 79);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(121, 22);
            this.txtMasach.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Mã sách";
            // 
            // cmbNgonngu
            // 
            this.cmbNgonngu.FormattingEnabled = true;
            this.cmbNgonngu.Location = new System.Drawing.Point(500, 126);
            this.cmbNgonngu.Name = "cmbNgonngu";
            this.cmbNgonngu.Size = new System.Drawing.Size(121, 24);
            this.cmbNgonngu.TabIndex = 11;
            // 
            // cmbTinhtrangsach
            // 
            this.cmbTinhtrangsach.FormattingEnabled = true;
            this.cmbTinhtrangsach.Location = new System.Drawing.Point(500, 86);
            this.cmbTinhtrangsach.Name = "cmbTinhtrangsach";
            this.cmbTinhtrangsach.Size = new System.Drawing.Size(121, 24);
            this.cmbTinhtrangsach.TabIndex = 10;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(500, 44);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 22);
            this.txtSoluong.TabIndex = 9;
            // 
            // cmbTentheloai
            // 
            this.cmbTentheloai.FormattingEnabled = true;
            this.cmbTentheloai.Location = new System.Drawing.Point(149, 160);
            this.cmbTentheloai.Name = "cmbTentheloai";
            this.cmbTentheloai.Size = new System.Drawing.Size(121, 24);
            this.cmbTentheloai.TabIndex = 8;
            // 
            // cmbTenNXB
            // 
            this.cmbTenNXB.FormattingEnabled = true;
            this.cmbTenNXB.Location = new System.Drawing.Point(149, 118);
            this.cmbTenNXB.Name = "cmbTenNXB";
            this.cmbTenNXB.Size = new System.Drawing.Size(121, 24);
            this.cmbTenNXB.TabIndex = 7;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(149, 42);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(121, 22);
            this.txtTensach.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngôn ngữ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NXB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "THỂ LOẠI - NXB";
            this.tabNavigationPage2.Controls.Add(this.groupBox4);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(800, 490);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaNXB);
            this.groupBox4.Controls.Add(this.btnSuaNXB);
            this.groupBox4.Controls.Add(this.btnThemNXB);
            this.groupBox4.Controls.Add(this.dgrNhaxuatban);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(385, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 466);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(230, 410);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(75, 32);
            this.btnXoaNXB.TabIndex = 4;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.Location = new System.Drawing.Point(129, 410);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(75, 32);
            this.btnSuaNXB.TabIndex = 3;
            this.btnSuaNXB.Text = "Sửa";
            this.btnSuaNXB.UseVisualStyleBackColor = true;
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(16, 410);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(75, 32);
            this.btnThemNXB.TabIndex = 2;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            // 
            // dgrNhaxuatban
            // 
            this.dgrNhaxuatban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrNhaxuatban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrNhaxuatban.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrNhaxuatban.Location = new System.Drawing.Point(16, 224);
            this.dgrNhaxuatban.Name = "dgrNhaxuatban";
            this.dgrNhaxuatban.Size = new System.Drawing.Size(289, 157);
            this.dgrNhaxuatban.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDiachi);
            this.groupBox5.Controls.Add(this.txtTenNXB);
            this.groupBox5.Controls.Add(this.txtMaNXB);
            this.groupBox5.Controls.Add(this.dtNgaythanhlap);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(16, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 201);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhà xuất bản";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(145, 117);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(128, 22);
            this.txtDiachi.TabIndex = 7;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(145, 74);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(128, 22);
            this.txtTenNXB.TabIndex = 6;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(145, 37);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(128, 22);
            this.txtMaNXB.TabIndex = 5;
            // 
            // dtNgaythanhlap
            // 
            this.dtNgaythanhlap.Location = new System.Drawing.Point(145, 161);
            this.dtNgaythanhlap.Name = "dtNgaythanhlap";
            this.dtNgaythanhlap.Size = new System.Drawing.Size(128, 22);
            this.dtNgaythanhlap.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày thành lập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên NXB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã NXB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoatheloai);
            this.groupBox2.Controls.Add(this.btnSuatheloai);
            this.groupBox2.Controls.Add(this.btnThemtheloai);
            this.groupBox2.Controls.Add(this.dgrTheloai);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(25, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 466);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnXoatheloai
            // 
            this.btnXoatheloai.Location = new System.Drawing.Point(249, 410);
            this.btnXoatheloai.Name = "btnXoatheloai";
            this.btnXoatheloai.Size = new System.Drawing.Size(75, 32);
            this.btnXoatheloai.TabIndex = 4;
            this.btnXoatheloai.Text = "Xóa";
            this.btnXoatheloai.UseVisualStyleBackColor = true;
            // 
            // btnSuatheloai
            // 
            this.btnSuatheloai.Location = new System.Drawing.Point(128, 410);
            this.btnSuatheloai.Name = "btnSuatheloai";
            this.btnSuatheloai.Size = new System.Drawing.Size(75, 32);
            this.btnSuatheloai.TabIndex = 3;
            this.btnSuatheloai.Text = "Sửa";
            this.btnSuatheloai.UseVisualStyleBackColor = true;
            // 
            // btnThemtheloai
            // 
            this.btnThemtheloai.Location = new System.Drawing.Point(13, 410);
            this.btnThemtheloai.Name = "btnThemtheloai";
            this.btnThemtheloai.Size = new System.Drawing.Size(75, 32);
            this.btnThemtheloai.TabIndex = 2;
            this.btnThemtheloai.Text = "Thêm";
            this.btnThemtheloai.UseVisualStyleBackColor = true;
            // 
            // dgrTheloai
            // 
            this.dgrTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrTheloai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrTheloai.Location = new System.Drawing.Point(13, 224);
            this.dgrTheloai.Name = "dgrTheloai";
            this.dgrTheloai.Size = new System.Drawing.Size(311, 157);
            this.dgrTheloai.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTentheloai);
            this.groupBox3.Controls.Add(this.txtMatheloai);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(13, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 201);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thể loại";
            // 
            // txtTentheloai
            // 
            this.txtTentheloai.Location = new System.Drawing.Point(140, 87);
            this.txtTentheloai.Name = "txtTentheloai";
            this.txtTentheloai.Size = new System.Drawing.Size(121, 22);
            this.txtTentheloai.TabIndex = 3;
            // 
            // txtMatheloai
            // 
            this.txtMatheloai.Location = new System.Drawing.Point(140, 38);
            this.txtMatheloai.Name = "txtMatheloai";
            this.txtMatheloai.Size = new System.Drawing.Size(121, 22);
            this.txtMatheloai.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên thể loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã thể loại";
            // 
            // QuanlySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 620);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.btnThoat);
            this.Name = "QuanlySach";
            this.Text = "QuanlySach";
            this.Load += new System.EventHandler(this.QuanlySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhaxuatban)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTheloai)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNgonngu;
        private System.Windows.Forms.ComboBox cmbTinhtrangsach;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cmbTentheloai;
        private System.Windows.Forms.ComboBox cmbTenNXB;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnSuaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.DataGridView dgrNhaxuatban;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.DateTimePicker dtNgaythanhlap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoatheloai;
        private System.Windows.Forms.Button btnSuatheloai;
        private System.Windows.Forms.Button btnThemtheloai;
        private System.Windows.Forms.DataGridView dgrTheloai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTentheloai;
        private System.Windows.Forms.TextBox txtMatheloai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}