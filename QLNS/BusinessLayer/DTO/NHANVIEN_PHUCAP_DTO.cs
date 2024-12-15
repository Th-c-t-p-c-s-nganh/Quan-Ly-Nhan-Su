using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NHANVIEN_PHUCAP_DTO
    {
        public int ID { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public string TENPHUCAP { get; set; }
        public string TENCHUCVU { get; set; }
        public Nullable<int> IDPC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<int> SOTIEN { get; set; }
    }
}
