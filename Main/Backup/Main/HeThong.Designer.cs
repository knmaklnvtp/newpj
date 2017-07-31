namespace Bài_tập_lớn
{
    partial class HeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong));
            this.button = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnQuanLyThe = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTheodoimuontrasach = new System.Windows.Forms.Button();
            this.btnQuanLyDocGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button.ForeColor = System.Drawing.Color.Red;
            this.button.Location = new System.Drawing.Point(146, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(563, 61);
            this.button.TabIndex = 0;
            this.button.Text = "Quản lý thư viện Trường ĐH Mỏ-Địa Chất";
            this.button.UseVisualStyleBackColor = false;
            // 
            // btnThongke
            // 
            this.btnThongke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongke.BackgroundImage")));
            this.btnThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongke.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongke.ForeColor = System.Drawing.Color.Red;
            this.btnThongke.Location = new System.Drawing.Point(615, 270);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(189, 147);
            this.btnThongke.TabIndex = 6;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnQuanLyThe
            // 
            this.btnQuanLyThe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThe.BackgroundImage")));
            this.btnQuanLyThe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyThe.ForeColor = System.Drawing.Color.Red;
            this.btnQuanLyThe.Location = new System.Drawing.Point(92, 270);
            this.btnQuanLyThe.Name = "btnQuanLyThe";
            this.btnQuanLyThe.Size = new System.Drawing.Size(184, 147);
            this.btnQuanLyThe.TabIndex = 12;
            this.btnQuanLyThe.Text = "Quản lý thẻ ";
            this.btnQuanLyThe.UseVisualStyleBackColor = true;
            this.btnQuanLyThe.Click += new System.EventHandler(this.btnQuanLyThe_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLySach.BackgroundImage")));
            this.btnQuanLySach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLySach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLySach.ForeColor = System.Drawing.Color.Red;
            this.btnQuanLySach.Location = new System.Drawing.Point(92, 105);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(189, 128);
            this.btnQuanLySach.TabIndex = 4;
            this.btnQuanLySach.Text = "Quản lý sách";
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.BackgroundImage")));
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimkiem.Location = new System.Drawing.Point(349, 270);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(174, 147);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm sách";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTheodoimuontrasach
            // 
            this.btnTheodoimuontrasach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTheodoimuontrasach.BackgroundImage")));
            this.btnTheodoimuontrasach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheodoimuontrasach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTheodoimuontrasach.ForeColor = System.Drawing.Color.Red;
            this.btnTheodoimuontrasach.Location = new System.Drawing.Point(613, 105);
            this.btnTheodoimuontrasach.Name = "btnTheodoimuontrasach";
            this.btnTheodoimuontrasach.Size = new System.Drawing.Size(191, 128);
            this.btnTheodoimuontrasach.TabIndex = 14;
            this.btnTheodoimuontrasach.Text = "Theo dõi mượn trả sách";
            this.btnTheodoimuontrasach.UseVisualStyleBackColor = true;
            this.btnTheodoimuontrasach.Click += new System.EventHandler(this.btnTheodoimuontrasach_Click);
            // 
            // btnQuanLyDocGia
            // 
            this.btnQuanLyDocGia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDocGia.BackgroundImage")));
            this.btnQuanLyDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyDocGia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyDocGia.ForeColor = System.Drawing.Color.Red;
            this.btnQuanLyDocGia.Location = new System.Drawing.Point(349, 105);
            this.btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            this.btnQuanLyDocGia.Size = new System.Drawing.Size(185, 128);
            this.btnQuanLyDocGia.TabIndex = 15;
            this.btnQuanLyDocGia.Text = "Quản lý độc giả";
            this.btnQuanLyDocGia.UseVisualStyleBackColor = true;
            this.btnQuanLyDocGia.Click += new System.EventHandler(this.btnQuanLyDocGia_Click);
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 471);
            this.Controls.Add(this.btnQuanLyDocGia);
            this.Controls.Add(this.btnTheodoimuontrasach);
            this.Controls.Add(this.btnQuanLyThe);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnQuanLySach);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.button);
            this.Name = "HeThong";
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnQuanLyThe;
        private System.Windows.Forms.Button btnTheodoimuontrasach;
        private System.Windows.Forms.Button btnQuanLyDocGia;

    }
}

