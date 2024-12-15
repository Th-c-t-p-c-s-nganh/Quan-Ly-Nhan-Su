using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class KYCONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_KYCONG> getList()
        {
            return db.tb_KYCONG.ToList();
        }

        public tb_KYCONG getItem(int id)
        {
            var dt = db.tb_KYCONG.FirstOrDefault(_ => _.MAKYCONG == id);
            return dt;
        }

        public tb_KYCONG Add(tb_KYCONG item)
        {
            try
            {
                db.tb_KYCONG.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public tb_KYCONG Edit(tb_KYCONG item)
        {
            try
            {
                var dt = db.tb_KYCONG.FirstOrDefault(_ => _.MAKYCONG == item.MAKYCONG);
                dt.MAKYCONG = item.MAKYCONG;
                dt.NAM = item.NAM;
                dt.THANG = item.THANG;
                dt.KHOA = item.KHOA;
                dt.NGAYCONGTRONGTHANG = item.NGAYCONGTRONGTHANG;
                dt.NGAYTINHCONG = item.NGAYTINHCONG;
                dt.TRANGTHAI = item.TRANGTHAI;
                dt.IDCT = item.IDCT;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var dt = db.tb_KYCONG.FirstOrDefault(_ => _.MAKYCONG == id);
                db.tb_KYCONG.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public bool check(int mkc)
        {
            var kc = db.tb_KYCONG.FirstOrDefault(_ => _.MAKYCONG == mkc);
            if (kc == null) return false;
            else
            {
                if(kc.TRANGTHAI == true) return true;
                return false;
            }
        }
    }
}
