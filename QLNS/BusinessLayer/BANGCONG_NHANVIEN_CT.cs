using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BANGCONG_NHANVIEN_CT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public tb_NHANVIEN_CHITIET getItem(int mkc , int mnv , int ngay)
        {
            return db.tb_NHANVIEN_CHITIET.FirstOrDefault(_ => _.MAKYCONG == mkc && _.MANV == mnv && _.NGAY.Value.Day == ngay);
        }

        public tb_NHANVIEN_CHITIET Add(tb_NHANVIEN_CHITIET tb)
        {
            try
            {
                db.tb_NHANVIEN_CHITIET.Add(tb);
                db.SaveChanges();
                return tb;
            }catch (Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public tb_NHANVIEN_CHITIET Update(tb_NHANVIEN_CHITIET tb)
        {
            try
            {
                var kcct = db.tb_NHANVIEN_CHITIET.FirstOrDefault(_ => _.MAKYCONG == tb.MAKYCONG && _.MANV == tb.MANV);
                kcct.KYHIEU = tb.KYHIEU;
                kcct.GIORA = tb.GIORA;
                kcct.GIOVAO = tb.GIOVAO;
                kcct.NGAYPHEP = tb.NGAYPHEP;
                kcct.NGAYCONG = tb.NGAYCONG;
                kcct.CONGCHUNHAT = tb.CONGCHUNHAT;
                kcct.CONGNGAYLE = tb.CONGNGAYLE;
                kcct.UPDATED_BY = tb.UPDATED_BY;
                kcct.UPDATED_DATE = tb.UPDATED_DATE;
                db.SaveChanges();
                return kcct;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }
        public double tongNgayPhep(int mkc , int mnv)
        {
            return db.tb_NHANVIEN_CHITIET.Where(_ => _.MAKYCONG == mkc && _.MANV == mnv && _.NGAYPHEP != 0).ToList().Sum(_ => _.NGAYPHEP.Value);
        }

        public double tongNgayCongCN(int mkc, int mnv)
        {
            return db.tb_NHANVIEN_CHITIET.Where(_ => _.MAKYCONG == mkc && _.MANV == mnv && _.CONGCHUNHAT != 0).ToList().Sum(_ => _.CONGCHUNHAT.Value);
        }

        public double tongNgayCong(int mkc, int mnv)
        {
            return db.tb_NHANVIEN_CHITIET.Where(_ => _.MAKYCONG == mkc && _.MANV == mnv && _.NGAYCONG != 0).ToList().Sum(_ => _.NGAYCONG.Value);
        }
    }
}
