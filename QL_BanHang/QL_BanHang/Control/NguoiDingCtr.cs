using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;


namespace QL_BanHang.Control
{
    class NguoiDingCtr
    {

        NguoiDungmod ndMod = new NguoiDungmod();
        public DataTable GetData()
        {
            return ndMod.GetData();
        }
        public bool AddData(NguoiDungObj ndObj)
        {
            return ndMod.AddData(ndObj);
        }
        public bool UpdData(NguoiDungObj ndObj)
        {
            return ndMod.UpdData(ndObj);
        }   

        public bool DelData(string matkhau)
        {
            return ndMod.DelData(matkhau);
        }
    }
}
