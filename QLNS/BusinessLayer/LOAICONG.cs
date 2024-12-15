using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAICONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_LOAICONG> getList()
        {
            return db.tb_LOAICONG.ToList();
        }

        public tb_LOAICONG getItem(int id)
        {
            var dt = db.tb_LOAICONG.FirstOrDefault(_ => _.IDLC == id);
            return dt;
        }

        public tb_LOAICONG Add(tb_LOAICONG item)
        {
            try
            {
                db.tb_LOAICONG.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_LOAICONG Edit(tb_LOAICONG item)
        {
            try
            {
                var dt = db.tb_LOAICONG.FirstOrDefault(_ => _.IDLC == item.IDLC);
                dt.TENLC = item.TENLC;
                dt.HESO = item.HESO;
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
                var dt = db.tb_LOAICONG.FirstOrDefault(_ => _.IDLC == id);
                db.tb_LOAICONG.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}