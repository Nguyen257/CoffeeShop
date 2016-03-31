using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHACHHANG_DTO
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int LoaiKH { get; set; }
        public string GiaBan { get; set; }

        public KHACHHANG_DTO ()
        {
            ID = 0;
            Ten = "";
            DiaChi = "";
            SDT = "";
            LoaiKH = 0;
            GiaBan = "";

        }
    }
}
