namespace Bài_tập_lớn
{
    partial class QuanlyThe
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbCapthe = new System.Windows.Forms.GroupBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.dtpNgayhethan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaycapthe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrQuanlythe = new System.Windows.Forms.DataGridView();
            this.grbCapthe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuanlythe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(298, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày cấp thẻ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(299, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày hết hạn";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(84, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(220, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(354, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(477, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(615, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbCapthe
            // 
            this.grbCapthe.Controls.Add(this.cmbMaSV);
            this.grbCapthe.Controls.Add(this.txtMaThe);
            this.grbCapthe.Controls.Add(this.dtpNgayhethan);
            this.grbCapthe.Controls.Add(this.dtpNgaycapthe);
            this.grbCapthe.Controls.Add(this.label2);
            this.grbCapthe.Controls.Add(this.label1);
            this.grbCapthe.Controls.Add(this.label3);
            this.grbCapthe.Controls.Add(this.label4);
            this.grbCapthe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbCapthe.ForeColor = System.Drawing.Color.Red;
            this.grbCapthe.Location = new System.Drawing.Point(84, 32);
            this.grbCapthe.Name = "grbCapthe";
            this.grbCapthe.Size = new System.Drawing.Size(606, 162);
            this.grbCapthe.TabIndex = 10;
            this.grbCapthe.TabStop = false;
            this.grbCapthe.Text = "Cấp thẻ";
            this.grbCapthe.Enter += new System.EventHandler(this.grbCapthe_Enter);
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(121, 91);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(141, 29);
            this.cmbMaSV.TabIndex = 16;
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(121, 36);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(141, 29);
            this.txtMaThe.TabIndex = 15;
            // 
            // dtpNgayhethan
            // 
            this.dtpNgayhethan.Location = new System.Drawing.Point(415, 94);
            this.dtpNgayhethan.Name = "dtpNgayhethan";
            this.dtpNgayhethan.Size = new System.Drawing.Size(149, 29);
            this.dtpNgayhethan.TabIndex = 14;
            // 
            // dtpNgaycapthe
            // 
            this.dtpNgaycapthe.Location = new System.Drawing.Point(415, 34);
            this.dtpNgaycapthe.Name = "dtpNgaycapthe";
            this.dtpNgaycapthe.Size = new System.Drawing.Size(149, 29);
            this.dtpNgaycapthe.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã SV";
            // 
            // dgrQuanlythe
            // 
            this.dgrQuanlythe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrQuanlythe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQuanlythe.Location = new System.Drawing.Point(84, 220);
            this.dgrQuanlythe.Name = "dgrQuanlythe";
            this.dgrQuanlythe.Size = new System.Drawing.Size(606, 157);
            this.dgrQuanlythe.TabIndex = 11;
            this.dgrQuanlythe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQuanlythe_CellContentClick);
            // 
            // QuanlyThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 486);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgrQuanlythe);
            this.Controls.Add(this.grbCapthe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "QuanlyThe";
            this.Text = "Quản lý thẻ";
            this.Load += new System.EventHandler(this.QuanlyThe_Load);
            this.grbCapthe.ResumeLayout(false);
            this.grbCapthe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuanlythe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbCapthe;
        private System.Windows.Forms.DateTimePicker dtpNgayhethan;
        private System.Windows.Forms.DateTimePicker dtpNgaycapthe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrQuanlythe;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Button btnLuu;
    }
}