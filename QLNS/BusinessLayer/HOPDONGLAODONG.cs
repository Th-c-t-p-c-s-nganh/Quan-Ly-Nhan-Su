using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class HOPDONGLAODONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_HOPDONG> getList()
        {
            return db.tb_HOPDONG.ToList();
        }

        public tb_HOPDONG getItem(string shd)
        {
            var dt = db.tb_HOPDONG.FirstOrDefault(_ => _.SOHD == shd);
            return dt;
        }

        public tb_HOPDONG Add(tb_HOPDONG item)
        {
            try
            {
                db.tb_HOPDONG.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message); 
            }
        }

        public tb_HOPDONG Edit(tb_HOPDONG item)
        {
            try
            {
                var dt = db.tb_HOPDONG.FirstOrDefault(_ => _.SOHD == item.SOHD);
                dt.SOHD = item.SOHD;
                dt.HESOLUONG = item.HESOLUONG;
                dt.NGAYKETTHUC = item.NGAYKETTHUC;
                dt.NGAYKY = item.NGAYKY;
                dt.NGAYBATDAU = item.NGAYBATDAU;
                dt.MANV = item.MANV;
                dt.THOIHAN = item.THOIHAN;
                //dt.NOIDUNG = item.NOIDUNG;
                dt.LANKY = item.LANKY;
                dt.LUONGCOBAN = item.LUONGCOBAN;
                dt.IDCT = item.IDCT;
                dt.UPDATED_BY = item.UPDATED_BY;
                dt.UPDATED_DATE = item.UPDATED_DATE;
                dt.DELETED_BY = item.DELETED_BY;
                dt.DELETED_DATE = item.DELETED_DATE;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(string shd, int mnv)
        {
            try
            {
                var dt = db.tb_HOPDONG.FirstOrDefault(_ => _.SOHD == shd);
                dt.DELETED_BY = mnv;
                dt.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public string MaxSoHopDong()
        {
            var dt = db.tb_HOPDONG.OrderByDescending(_ => _.CREATED_DATE).FirstOrDefault();
            if (dt != null)
            {
                return dt.SOHD;
            }
            return "00000";
        }
    }
}
