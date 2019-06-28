namespace QL_BanHang.View
{
    partial class QuanLyNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtXoaND = new System.Windows.Forms.Button();
            this.btSuaND = new System.Windows.Forms.Button();
            this.btThemND = new System.Windows.Forms.Button();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmk1 = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dsNguoiDung = new System.Windows.Forms.DataGridView();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bthuy);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.BtXoaND);
            this.groupBox1.Controls.Add(this.btSuaND);
            this.groupBox1.Controls.Add(this.btThemND);
            this.groupBox1.Controls.Add(this.cbQuyen);
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmk1);
            this.groupBox1.Controls.Add(this.txtTk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Ký Thông tin Người Dùng";
            // 
            // BtXoaND
            // 
            this.BtXoaND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtXoaND.Location = new System.Drawing.Point(470, 231);
            this.BtXoaND.Name = "BtXoaND";
            this.BtXoaND.Size = new System.Drawing.Size(130, 45);
            this.BtXoaND.TabIndex = 20;
            this.BtXoaND.Text = "Xóa";
            this.BtXoaND.UseVisualStyleBackColor = true;
            this.BtXoaND.Click += new System.EventHandler(this.BtXoaND_Click);
            // 
            // btSuaND
            // 
            this.btSuaND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaND.Location = new System.Drawing.Point(280, 231);
            this.btSuaND.Name = "btSuaND";
            this.btSuaND.Size = new System.Drawing.Size(130, 45);
            this.btSuaND.TabIndex = 19;
            this.btSuaND.Text = "Sữa";
            this.btSuaND.UseVisualStyleBackColor = true;
            this.btSuaND.Click += new System.EventHandler(this.btSuaND_Click);
            // 
            // btThemND
            // 
            this.btThemND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemND.Location = new System.Drawing.Point(70, 231);
            this.btThemND.Name = "btThemND";
            this.btThemND.Size = new System.Drawing.Size(130, 45);
            this.btThemND.TabIndex = 18;
            this.btThemND.Text = "Thêm";
            this.btThemND.UseVisualStyleBackColor = true;
            this.btThemND.Click += new System.EventHandler(this.btThemND_Click);
            // 
            // cbQuyen
            // 
            this.cbQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cbQuyen.Location = new System.Drawing.Point(729, 132);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(269, 26);
            this.cbQuyen.TabIndex = 17;
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(240, 87);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(230, 26);
            this.cbGT.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quyền";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(240, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 24);
            this.txtEmail.TabIndex = 11;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(240, 134);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(230, 24);
            this.txtDT.TabIndex = 10;
            this.txtDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Điện thoại";
            // 
            // txtmk1
            // 
            this.txtmk1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmk1.Location = new System.Drawing.Point(729, 84);
            this.txtmk1.Name = "txtmk1";
            this.txtmk1.Size = new System.Drawing.Size(269, 24);
            this.txtmk1.TabIndex = 7;
            // 
            // txtTk
            // 
            this.txtTk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTk.Location = new System.Drawing.Point(729, 40);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(269, 24);
            this.txtTk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Tài Khoản";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(240, 47);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(230, 24);
            this.txtHT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dsNguoiDung);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dành Sách Người Dùng";
            // 
            // dsNguoiDung
            // 
            this.dsNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNguoiDung.Location = new System.Drawing.Point(7, 22);
            this.dsNguoiDung.Name = "dsNguoiDung";
            this.dsNguoiDung.RowTemplate.Height = 24;
            this.dsNguoiDung.Size = new System.Drawing.Size(1028, 222);
            this.dsNguoiDung.TabIndex = 0;
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Location = new System.Drawing.Point(855, 231);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(130, 45);
            this.bthuy.TabIndex = 22;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Location = new System.Drawing.Point(665, 231);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(130, 45);
            this.btluu.TabIndex = 21;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyNguoiDung";
            this.Text = "QuanLyNguoiDung";
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmk1;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Button BtXoaND;
        private System.Windows.Forms.Button btSuaND;
        private System.Windows.Forms.Button btThemND;
        private System.Windows.Forms.DataGridView dsNguoiDung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
    }
}