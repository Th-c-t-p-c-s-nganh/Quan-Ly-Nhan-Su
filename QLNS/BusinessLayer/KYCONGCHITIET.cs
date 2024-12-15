using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KYCONGCHITIET
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_KYCONGCHITIET> getList(int mkc)
        {
            return db.tb_KYCONGCHITIET.Where(_ => _.MAKYCONG == mkc).ToList();
        }

        public tb_KYCONGCHITIET getItem(int mkc , int mnv)
        {
            return db.tb_KYCONGCHITIET.FirstOrDefault(_ => _.MAKYCONG == mkc && _.MANV == mnv);
        }

        public void phatSinhKyCong(int idct , int thang , int nam)
        {
            var lstNV = db.tb_NHANVIEN.ToList();
            if (lstNV.Count == 0) return;
            foreach (var item in lstNV)
            {
                List<String> listDay = new List<String>();
                for(int j = 1; j <= GetDayNumber(thang , nam); j++)
                {
                    DateTime dt = new DateTime(nam,thang, j);
                    switch(dt.DayOfWeek.ToString())
                    {
                        case "Sunday" :
                            listDay.Add("CN");
                            break;
                        case "Saturday":
                            listDay.Add("T7");
                            break;
                        default:
                            listDay.Add("X");
                            break;
                    }
                    switch(listDay.Count)
                    {
                        case 28:
                            listDay.Add("");
                            listDay.Add("");
                            listDay.Add("");
                            break;
                        case 29:
                            listDay.Add("");
                            listDay.Add("");
                            break;
                        case 30:
                            listDay.Add("");
                            break;
                    }

                }
                    tb_KYCONGCHITIET kcct = new tb_KYCONGCHITIET();
                    
                    kcct.MAKYCONG = nam * 100 + thang;
                    kcct.MANV = item.MANV;
                    kcct.HOTEN = item.HOTEN;
                    kcct.IDCT = item.IDCT;
                    kcct.D1 = listDay[0];
                    kcct.D2 = listDay[1];
                    kcct.D3 = listDay[2];
                    kcct.D4 = listDay[3];
                    kcct.D5 = listDay[4];
                    kcct.D6 = listDay[5];
                    kcct.D7 = listDay[6];
                    kcct.D8 = listDay[7];
                    kcct.D9 = listDay[8];
                    kcct.D10 = listDay[9];
                    kcct.D11 = listDay[10];
                    kcct.D12 = listDay[11];
                    kcct.D13 = listDay[12];
                    kcct.D14 = listDay[13];
                    kcct.D15 = listDay[14];
                    kcct.D16 = listDay[15];
                    kcct.D17 = listDay[16];
                    kcct.D18 = listDay[17];
                    kcct.D19 = listDay[18];
                    kcct.D20 = listDay[19];
                    kcct.D21 = listDay[20];
                    kcct.D22 = listDay[21];
                    kcct.D23 = listDay[22];
                    kcct.D24 = listDay[23];
                    kcct.D25 = listDay[24];
                    kcct.D26 = listDay[25];
                    kcct.D27 = listDay[26];
                    kcct.D28 = listDay[27];
                    kcct.D29 = listDay[28];
                    kcct.D30 = listDay[29];
                    kcct.D31 = listDay[30];
                    kcct.NGAYCONG = demSoNgayLamViecTrongThang(thang, nam);
                    kcct.TONGNGAYCONG = demSoNgayLamViecTrongThang(thang, nam);
                    db.tb_KYCONGCHITIET.Add(kcct);
                    db.SaveChanges();
            }
        }

        public tb_KYCONGCHITIET Update(tb_KYCONGCHITIET tb)
        {
            var kcct = db.tb_KYCONGCHITIET.FirstOrDefault(_ => _.MAKYCONG == tb.MAKYCONG && _.MANV == tb.MANV);
            kcct.D1 = tb.D1;
            kcct.D2 = tb.D2;
            kcct.D3 = tb.D3;
            kcct.D4 = tb.D4;
            kcct.D5 = tb.D5;
            kcct.D6 = tb.D6;
            kcct.D7 = tb.D7;
            kcct.D8 = tb.D8;
            kcct.D9 = tb.D9;
            kcct.D10 =tb.D10;
            kcct.D11 =tb.D11;
            kcct.D12 =tb.D12;
            kcct.D13 =tb.D13;
            kcct.D14 =tb.D14;
            kcct.D15 =tb.D15;
            kcct.D16 =tb.D16;
            kcct.D17 =tb.D17;
            kcct.D18 =tb.D18;
            kcct.D19 =tb.D19;
            kcct.D20 =tb.D20;
            kcct.D21 =tb.D21;
            kcct.D22 =tb.D22;
            kcct.D23 =tb.D23;
            kcct.D24 =tb.D24;
            kcct.D25 =tb.D25;
            kcct.D26 =tb.D26;
            kcct.D27 =tb.D27;
            kcct.D28 =tb.D28;
            kcct.D29 =tb.D29;
            kcct.D30 =tb.D30;
            kcct.D31 =tb.D31;
            kcct.NGAYNGHI = tb.NGAYNGHI;
            kcct.CONGNGAYLE = tb.CONGNGAYLE;
            kcct.CONGNGAYCHUNHAT = tb.CONGNGAYCHUNHAT;
            kcct.NGHIKHONGPHEP = tb.NGHIKHONGPHEP;
            kcct.TONGNGAYCONG = tb.TONGNGAYCONG;
            db.SaveChanges();
            return kcct;
        }
        public int GetDayNumber(int thang , int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }
            return dayNumber;
        }
        public static int demSoNgayLamViecTrongThang(int thang, int nam)
        {
            int dem = 0;
            DateTime dt = new DateTime(nam, thang, 01);
            int x = dt.Month + 1;
            while (dt.Month < x)
            {
                dem++;
                if (dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    dem--;
                }
                dt = dt.AddDays(1);
            }
            return dem;
        }
    }
}
