using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public static class Function
    {
        public static int demSoNgayLamViecTrongThang(int nam , int thang)
        {
            int dem = 0;
            DateTime dt = new DateTime(nam, thang, 01);
            int x = dt.Month + 1;
            while(dt.Month < x)
            {
                dem++;
                if (dt.DayOfWeek == DayOfWeek.Sunday) dem--;
                dt = dt.AddDays(1);
            }
            return dem;
        }

        public static int laySoNgayCuaThang(int nam , int thang)
        {
            return DateTime.DaysInMonth(nam, thang);
        }

        public static string layThuTrongTuan(int nam , int thang , int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch(newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ hai";
                    break;
                case "Tuesday":
                    thu = "Thứ ba";
                    break;
                case "Wednesday":
                    thu = "Thứ tư";
                    break;
                case "Thursday":
                    thu = "Thứ năm";
                    break;
                case "Friday":
                    thu = "Thứ sáu";
                    break;
                case "Saturday":
                    thu = "Thứ bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            return thu;
        }


        static SqlConnection con = new SqlConnection();
        public static void taoKetNot()
        {
            con.ConnectionString = "Data Source=BEKEND\\SQLEXPRESS; Initial Catalog=QLNhanSu; Integrated Security=True;";
            try
            {
                con.Open();
            }catch(Exception ex)
            {
                throw new Exception("Lỗi " + ex.Message);
            }
        }

        public static void dongKetNoi()
        {
            con.Close();
        }

        public static DataTable getData(string query)
        {
            taoKetNot();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dt);
            dongKetNoi();
            return dt;
        }

        public static DataSet GetData(string query)
        {
            taoKetNot();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static void execQuery(string query)
        {
            taoKetNot();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }
    }
}
