using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TAIKHOAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public bool DangNhap(string tenTaiKoan , string matKhau)
        {
            var tk = db.tb_TAIKHOAN.FirstOrDefault(_ => _.TENDN == tenTaiKoan);
            var mk = db.tb_TAIKHOAN.FirstOrDefault(_ => _.MATKHAU == matKhau);
            if (tk != null && mk != null) return true;
            return false;
        }
    }
}
