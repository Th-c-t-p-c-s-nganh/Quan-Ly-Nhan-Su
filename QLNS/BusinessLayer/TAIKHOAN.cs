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
        public tb_TAIKHOAN getItem(string id)
        {
            var dt = db.tb_TAIKHOAN.FirstOrDefault(_ => _.TENDN == id);
            return dt;
        }
        public bool CheckTaiKhoan(string tenTaiKhoan , string matKhauCu)
        {
            var mk = db.tb_TAIKHOAN.FirstOrDefault(_ => _.MATKHAU == matKhauCu);
            var tk = db.tb_TAIKHOAN.FirstOrDefault(_ => _.TENDN == tenTaiKhoan);
            if (tk != null && mk != null) return true;
            return false;
        }

        public tb_TAIKHOAN Edit(tb_TAIKHOAN item)
        {
            try
            {
                var dt = db.tb_TAIKHOAN.FirstOrDefault(_ => _.TENDN == item.TENDN);
                dt.TENDN = item.TENDN;
                dt.MATKHAU = item.MATKHAU;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
