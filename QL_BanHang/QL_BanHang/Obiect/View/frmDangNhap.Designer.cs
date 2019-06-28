namespace QL_BanHang.View
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtMkND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoay = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(178, 257);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(241, 22);
            this.txtDN.TabIndex = 1;
            // 
            // txtMkND
            // 
            this.txtMkND.Location = new System.Drawing.Point(178, 303);
            this.txtMkND.Name = "txtMkND";
            this.txtMkND.PasswordChar = '*';
            this.txtMkND.Size = new System.Drawing.Size(241, 22);
            this.txtMkND.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.Location = new System.Drawing.Point(49, 353);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(159, 60);
            this.btDangNhap.TabIndex = 5;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoay
            // 
            this.btThoay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoay.Location = new System.Drawing.Point(260, 353);
            this.btThoay.Name = "btThoay";
            this.btThoay.Size = new System.Drawing.Size(159, 60);
            this.btThoay.TabIndex = 6;
            this.btThoay.Text = "Thoát";
            this.btThoay.UseVisualStyleBackColor = true;
            this.btThoay.Click += new System.EventHandler(this.btThoay_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 558);
            this.Controls.Add(this.btThoay);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMkND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtMkND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}