using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.View;

namespace QL_BanHang
{
    public partial class Form1 : Form
    {
        string quyen = "";
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string quyendn)
        {
            quyen = quyendn;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (quyen == "Member")
            {
                Form1 frm1 = new Form1();
                frm1.Show();

            }
            else
            {
                MnStripHeThong.Visible = false;
                /* MnStripNhanVien.Visible = false;*/
            }
        }

        private void MnStripND_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung frmND = new QuanLyNguoiDung();
           
            frmND.Show();
           
        }

        private void MnStripNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.Show();
            
        }

        private void MnStripKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
            
        }

        private void MnStripSp_Click(object sender, EventArgs e)
        {
            frmHangHoa frmSP = new frmHangHoa();
            frmSP.Show();
           
        }

        private void MnStripHD_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.Show();
            
        }

        private void MnStripHeThong_Click(object sender, EventArgs e)
        {

        }
    }
}
