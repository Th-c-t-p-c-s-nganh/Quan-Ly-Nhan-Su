using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BANGLUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_BANGLUONG> getList(int mkc)
        {
            return db.tb_BANGLUONG.Where(_ => _.MAKYCONG == mkc).ToList();
        }

        public tb_BANGLUONG getItem(int mkc , int mnv)
        {
            var dt = db.tb_BANGLUONG.FirstOrDefault(_ => _.MAKYCONG == mkc && _.MANV == mnv);
            return dt;
        }

        public void TinhLuongNhanVien(int mkc)
        {
            double luongTrongNgay, luongPhep, luongChuNhat, luongNgayThuong, thucLanh;
            var lstNV = db.tb_NHANVIEN.ToList();
            foreach(var item in lstNV)
            {
                var hd = db.tb_HOPDONG.FirstOrDefault(_ => _.MANV == item.MANV);
                if(hd != null)
                {
                    var kcct = db.tb_KYCONGCHITIET.FirstOrDefault(_ => _.MAKYCONG == mkc && _.MANV == item.MANV);
                    var luongMotNgayCong = Math.Round(Convert.ToDouble(hd.LUONGCOBAN * hd.HESOLUONG / kcct.NGAYCONG) , 2);

                    luongNgayThuong = Math.Round(Convert.ToDouble(kcct.TONGNGAYCONG * luongMotNgayCong), 2);
                    luongPhep = Math.Round(Convert.ToDouble(kcct.NGAYNGHI * luongMotNgayCong * 0.3), 2);
                    luongChuNhat = Math.Round(Convert.ToDouble(kcct.CONGNGAYCHUNHAT * luongMotNgayCong * 2), 2);
                    luongTrongNgay = Math.Round(Convert.ToDouble(kcct.TONGNGAYCONG * luongMotNgayCong), 2);

                    thucLanh = luongPhep + luongChuNhat + luongTrongNgay;

                    tb_BANGLUONG tb = new tb_BANGLUONG();
                    tb.MANV = item.MANV;
                    tb.MAKYCONG = mkc;
                    tb.HOTEN = item.HOTEN;
                    tb.NGAYCONGTRONGTHANG = int.Parse(kcct.TONGNGAYCONG.ToString());
                    tb.NGAYPHEP = luongPhep;
                    tb.THUCLANH = thucLanh;
                    tb.NGAYCHUNHAT = luongChuNhat;
                    tb.NGAYTHUONG = luongNgayThuong;
                    Add(tb);
                }
            }
        }


        public tb_BANGLUONG Add(tb_BANGLUONG item)
        {
            try
            {
                db.tb_BANGLUONG.Add(item);
                db.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_BANGLUONG Edit(tb_BANGLUONG item)
        {
            try
            {
                var dt = db.tb_BANGLUONG.FirstOrDefault(_ => _.MAKYCONG == item.MAKYCONG && _.MANV == item.MANV);
                dt.MAKYCONG = item.MAKYCONG;
                dt.MANV = item.MANV;
                dt.HOTEN = item.HOTEN;
                dt.NGAYCONGTRONGTHANG = item.NGAYCONGTRONGTHANG;
                dt.NGAYPHEP = item.NGAYPHEP;
                dt.NGAYLE = item.NGAYLE;
                dt.NGAYCHUNHAT = item.NGAYCHUNHAT;
                dt.NGAYTHUONG = item.NGAYTHUONG;
                dt.THUCLANH = item.THUCLANH;
                dt.NGAYCONGTRONGTHANG = item.NGAYCONGTRONGTHANG;
                dt.UNGLUONG = item.UNGLUONG;
                dt.PHUCAP = item.PHUCAP;
                dt.TANGCA = item.TANGCA;
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
