using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class NguoiDungmod
    {


        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *  from tb_DangNhap";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(NguoiDungObj ndObj)
        {
            cmd.CommandText = "Insert into tb_DangNhap values ('" + ndObj.TenND + "',N'" + ndObj.MatKhau + "',N'" + ndObj.HoTen + "',N'" + ndObj.GioiTinh + "','" + ndObj.SoDienthoai + "','" + ndObj.Email + "','" + ndObj.PhanQuyen + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdData(NguoiDungObj ndObj)
        {
            cmd.CommandText = "Update tb_DangNhap set TenND =  N'" + ndObj.TenND + "',HoTen=N'"+ndObj.HoTen+"', GioiTinh = N'" + ndObj.GioiTinh + "', SoDienthoai = N'" + ndObj.SoDienthoai + "',Email = '" + ndObj.Email + "',PhanQuyen = '" + ndObj.PhanQuyen + "' Where MatKhau = '" + ndObj.MatKhau + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }       
        public bool DelData( string matkhau)
        {
            cmd.CommandText = "Delete tb_DangNhap Where MatKhau = '" + matkhau + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
