using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAICA
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_LOAICA> getList()
        {
            return db.tb_LOAICA.ToList();
        }

        public tb_LOAICA getItem(int id)
        {
            var dt = db.tb_LOAICA.FirstOrDefault(_ => _.IDLOAICA == id);
            return dt;
        }

        public tb_LOAICA Add(tb_LOAICA item)
        {
            try
            {
                db.tb_LOAICA.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_LOAICA Edit(tb_LOAICA item)
        {
            try
            {
                var dt = db.tb_LOAICA.FirstOrDefault(_ => _.IDLOAICA == item.IDLOAICA);
                dt.TENLOAICA = item.TENLOAICA;
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
                var dt = db.tb_LOAICA.FirstOrDefault(_ => _.IDLOAICA == id);
                db.tb_LOAICA.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}