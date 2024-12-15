using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHUCAP
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_NHANVIEN_PHUCAP> getList()
        {
            return db.tb_NHANVIEN_PHUCAP.ToList();
        }

        public List<NHANVIEN_PHUCAP_DTO> getFullList()
        {
            var lst = db.tb_NHANVIEN_PHUCAP.ToList();
            List<NHANVIEN_PHUCAP_DTO> lstDTO = new List<NHANVIEN_PHUCAP_DTO>();
            NHANVIEN_PHUCAP_DTO nvpc;
            NHANVIEN nv = new NHANVIEN();
            foreach(var item in lst)
            {
                nvpc = new NHANVIEN_PHUCAP_DTO();
                nvpc.ID = item.ID;
                nvpc.MANV = item.MANV;
                nvpc.IDPC = item.IDPC;
                var pc = db.tb_PHUCAP.FirstOrDefault(_ => _.IDPC == item.IDPC);
                nvpc.TENPHUCAP = pc.TENPC;
                nvpc.NOIDUNG = item.NOIDUNG;
                nvpc.NGAY = item.NGAY;
                nvpc.SOTIEN = item.SOTIEN;
                lstDTO.Add(nvpc);
            }
            return lstDTO;
        }

        public tb_NHANVIEN_PHUCAP getItem(int id)
        {
            var dt = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(_ => _.IDPC == id);
            return dt;
        }

        public tb_NHANVIEN_PHUCAP Add(tb_NHANVIEN_PHUCAP item)
        {
            try
            {
                db.tb_NHANVIEN_PHUCAP.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_NHANVIEN_PHUCAP Edit(tb_NHANVIEN_PHUCAP item)
        {
            try
            {
                var dt = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(_ => _.IDPC == item.IDPC);
                dt.IDPC = item.IDPC;
                dt.SOTIEN = item.SOTIEN;
                dt.MANV = item.MANV;
                dt.NOIDUNG = item.NOIDUNG;
                dt.NGAY = item.NGAY;
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
                var dt = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(_ => _.IDPC == id);
                db.tb_NHANVIEN_PHUCAP.Remove(dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
