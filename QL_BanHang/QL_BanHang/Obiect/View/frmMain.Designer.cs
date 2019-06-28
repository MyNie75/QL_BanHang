namespace QL_BanHang
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MnStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripDN = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripND = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripDX = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripKH = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripSp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStripHeThong,
            this.MnStripNhanVien,
            this.MnStripKH,
            this.MnStripSp,
            this.MnStripHD});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1195, 36);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MnStripHeThong
            // 
            this.MnStripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStripDN,
            this.MnStripND,
            this.MnStripDX,
            this.MnStripThoat});
            this.MnStripHeThong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripHeThong.Name = "MnStripHeThong";
            this.MnStripHeThong.Size = new System.Drawing.Size(125, 30);
            this.MnStripHeThong.Text = "Hệ Thống";
            this.MnStripHeThong.Click += new System.EventHandler(this.MnStripHeThong_Click);
            // 
            // MnStripDN
            // 
            this.MnStripDN.Name = "MnStripDN";
            this.MnStripDN.Size = new System.Drawing.Size(311, 30);
            this.MnStripDN.Text = "Đăng Nhập";
            // 
            // MnStripND
            // 
            this.MnStripND.Name = "MnStripND";
            this.MnStripND.Size = new System.Drawing.Size(311, 30);
            this.MnStripND.Text = "Quản Lý Người Dùng";
            this.MnStripND.Click += new System.EventHandler(this.MnStripND_Click);
            // 
            // MnStripDX
            // 
            this.MnStripDX.Name = "MnStripDX";
            this.MnStripDX.Size = new System.Drawing.Size(311, 30);
            this.MnStripDX.Text = "Đăng Xuất";
            // 
            // MnStripThoat
            // 
            this.MnStripThoat.Name = "MnStripThoat";
            this.MnStripThoat.Size = new System.Drawing.Size(311, 30);
            this.MnStripThoat.Text = "Thoát";
            // 
            // MnStripNhanVien
            // 
            this.MnStripNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripNhanVien.Name = "MnStripNhanVien";
            this.MnStripNhanVien.Size = new System.Drawing.Size(132, 30);
            this.MnStripNhanVien.Text = "Nhân Viên";
            this.MnStripNhanVien.Click += new System.EventHandler(this.MnStripNhanVien_Click);
            // 
            // MnStripKH
            // 
            this.MnStripKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripKH.Name = "MnStripKH";
            this.MnStripKH.Size = new System.Drawing.Size(154, 30);
            this.MnStripKH.Text = "Khách Hàng";
            this.MnStripKH.Click += new System.EventHandler(this.MnStripKH_Click);
            // 
            // MnStripSp
            // 
            this.MnStripSp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripSp.Name = "MnStripSp";
            this.MnStripSp.Size = new System.Drawing.Size(127, 30);
            this.MnStripSp.Text = "Sản Phẩm";
            this.MnStripSp.Click += new System.EventHandler(this.MnStripSp_Click);
            // 
            // MnStripHD
            // 
            this.MnStripHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripHD.Name = "MnStripHD";
            this.MnStripHD.Size = new System.Drawing.Size(116, 30);
            this.MnStripHD.Text = "Hóa Đơn";
            this.MnStripHD.Click += new System.EventHandler(this.MnStripHD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_BanHang.Properties.Resources.pou__2_;
            this.ClientSize = new System.Drawing.Size(1195, 794);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "FORM CHÍNH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MnStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem MnStripDN;
        private System.Windows.Forms.ToolStripMenuItem MnStripND;
        private System.Windows.Forms.ToolStripMenuItem MnStripDX;
        private System.Windows.Forms.ToolStripMenuItem MnStripThoat;
        private System.Windows.Forms.ToolStripMenuItem MnStripNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MnStripKH;
        private System.Windows.Forms.ToolStripMenuItem MnStripSp;
        private System.Windows.Forms.ToolStripMenuItem MnStripHD;
    }
}

