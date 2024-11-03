using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHENTHUONG_KYLUAT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_KHENTHUONG_KYLUAT getItem(string SoQD)
        {
            return db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(_ => _.SOQD == SoQD);
        }
        public List<tb_KHENTHUONG_KYLUAT> getList()
        {
            return db.tb_KHENTHUONG_KYLUAT.ToList();
        }
        public tb_KHENTHUONG_KYLUAT Add(tb_KHENTHUONG_KYLUAT item)
        {
            try
            {
                db.tb_KHENTHUONG_KYLUAT.Add(item);
                db.SaveChanges();
                return item;
            }catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public tb_KHENTHUONG_KYLUAT Update(tb_KHENTHUONG_KYLUAT item)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(_ => _.SOQD == item.SOQD);
                _kt.NGAY = item.NGAY;
                _kt.LOAI = item.LOAI;
                _kt.LYDO = item.LYDO;
                _kt.TUNGAY = item.TUNGAY;
                _kt.DENGAY = item.DENGAY;
                _kt.MANV = item.MANV;
                _kt.NOIDUNG = item.NOIDUNG;
                _kt.UPDATED_BY = item.UPDATED_BY;
                _kt.UPDATED_DATE = item.UPDATED_DATE;
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public void Delete(string SoQD)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(_ => _.SOQD == SoQD);
                _kt.DELETED_BY = _kt.DELETED_BY;
                _kt.DELETED_DATE = _kt.DELETED_DATE;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public string MaxSoHopDong()
        {
            var dt = db.tb_KHENTHUONG_KYLUAT.OrderByDescending(_ => _.CREATED_DATE).FirstOrDefault();
            if (dt != null)
            {
                return dt.SOQD;
            }
            return "00000";
        }
    }
}
