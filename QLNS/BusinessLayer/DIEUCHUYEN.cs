using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DIEUCHUYEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_NHANVIEN_DIEUCHUYEN> getList()
        {
            return db.tb_NHANVIEN_DIEUCHUYEN.ToList();
        }

        public tb_NHANVIEN_DIEUCHUYEN getItem(string sqd)
        {
            var dt = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(_ => _.SQQD == sqd);
            return dt;
        }

        public tb_NHANVIEN_DIEUCHUYEN Add(tb_NHANVIEN_DIEUCHUYEN item)
        {
            try
            {
                db.tb_NHANVIEN_DIEUCHUYEN.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public tb_NHANVIEN_DIEUCHUYEN Edit(tb_NHANVIEN_DIEUCHUYEN item)
        {
            try
            {
                var dt = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(_ => _.SQQD == item.SQQD);
                dt.LYDO = item.LYDO;
                dt.GHICHU = item.GHICHU;
                dt.MAPB = item.MAPB;
                dt.MAPB2 = item.MAPB2;
                dt.MANV = item.MANV;
                dt.UPDATED_BY = 1;
                dt.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(string sqd)
        {
            try
            {
                var dt = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(_ => _.SQQD == sqd);
                db.tb_NHANVIEN_DIEUCHUYEN.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
        public string MaxSoHopDong()
        {
            var dt = db.tb_NHANVIEN_DIEUCHUYEN.OrderByDescending(_ => _.CREATED_DATE).FirstOrDefault();
            if (dt != null)
            {
                return dt.SQQD;
            }
            return "00000";
        }
    }
}