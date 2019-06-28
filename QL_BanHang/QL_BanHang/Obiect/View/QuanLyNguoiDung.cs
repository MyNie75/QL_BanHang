using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control;
using QL_BanHang.Obiect;

namespace QL_BanHang.View
{
    public partial class QuanLyNguoiDung : Form

    {
        NguoiDingCtr ndCtr = new NguoiDingCtr();
        private int flagLuu = 0;
        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = ndCtr.GetData();
            dsNguoiDung.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtmk1.DataBindings.Clear();
            txtmk1.DataBindings.Add("Text", dsNguoiDung.DataSource, "MatKhau");
            txtHT.DataBindings.Clear();
            txtHT.DataBindings.Add("Text", dsNguoiDung.DataSource, "HoTen");
            cbGT.DataBindings.Clear();
            cbGT.DataBindings.Add("Text", dsNguoiDung.DataSource, "GioiTinh");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dsNguoiDung.DataSource, "Email");
            txtDT.DataBindings.Clear();
            txtDT.DataBindings.Add("Text", dsNguoiDung.DataSource, "SDT");
            txtTk.DataBindings.Clear();
            txtTk.DataBindings.Add("Text", dsNguoiDung.DataSource, "TenND");
            cbQuyen.DataBindings.Clear();
            cbQuyen.DataBindings.Add("Text", dsNguoiDung.DataSource, "PhanQuyen");
        }
        private void loadCMB()
        {
            cbGT.Items.Clear();
            cbGT.Items.Add("Nam");
            cbGT.Items.Add("Nữ");
            cbGT.SelectedItem = 0;
        }
        private void loadCMBPQ()
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("Admin");
            cbQuyen.Items.Add("Member");
            cbQuyen.SelectedItem = 0;
        }
        private void clearData()
        {
            txtmk1.Text = "";
            txtTk.Text = "";
            txtHT.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
            loadCMB();
            loadCMBPQ();
        }
        private void DisEnl(bool e)
        {
            btThemND.Enabled = !e;
            btSuaND.Enabled = !e;
            BtXoaND.Enabled = !e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            txtmk1.Enabled = e;
            txtTk.Enabled = e;
            txtHT.Enabled = e;
            txtDT.Enabled = e;
            cbGT.Enabled = e;
            cbQuyen.Enabled = e;
            txtEmail.Enabled = e;
        }
        private void addData(NguoiDungObj nd)
        {
            nd.MatKhau = txtmk1.Text.Trim();
            if (cbGT.SelectedIndex == 0)
            {
                nd.GioiTinh = "Nam";
            }
            else
                nd.GioiTinh = "Nữ";
            nd.TenND = txtTk.Text.Trim();
            nd.HoTen = txtHT.Text.Trim();
            nd.SoDienthoai = txtDT.Text.Trim();
            nd.Email = txtEmail.Text.Trim();
            nd.Email = txtEmail.Text.Trim();
        }

        private void btThemND_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btSuaND_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMB();
            loadCMBPQ();
        }

        private void BtXoaND_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ndCtr.DelData(txtmk1.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyNguoiDung_Load(sender, e);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            NguoiDungObj NDObj = new NguoiDungObj();
            addData(NDObj);
            if (flagLuu == 0)
            {
                if (ndCtr.AddData(NDObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ndCtr.UpdData(NDObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyNguoiDung_Load(sender, e);
        }

        private void QuanLyNguoiDung_Load_1(object sender, EventArgs e)
        {

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                QuanLyNguoiDung_Load(sender, e);
            else
                return;
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
