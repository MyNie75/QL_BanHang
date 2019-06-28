using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Obiect
{
    class NguoiDungObj
    {
        string tennd, matkhau, hoten, gioitinh, sodienthoai, email, phanquyen;
        public string TenND
        {
            get { return tennd; }
            set { tennd = value; }
        }
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string SoDienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhanQuyen
        {
            get { return phanquyen; }
            set { phanquyen = value; }
        }


        public NguoiDungObj() { }
        public NguoiDungObj(string tennd, string matkhau, string hoten, string gioitinh, string sodienthoai, string email, string phanquyen)
        {
            this.tennd = tennd;
            this.matkhau = matkhau;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.sodienthoai = sodienthoai;
            this.email = email;
            this.phanquyen = phanquyen;
        }
    }
}
