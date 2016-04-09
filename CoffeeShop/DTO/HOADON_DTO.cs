using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOADON_DTO
    {
        public int ID { get; set; }
        public string NgayLap {get;set;}
        public int NguoiLap { get; set; }
        public double TongTien { get; set; }

        public HOADON_DTO ()
        {
            ID = 0;
            NgayLap = "";
            NguoiLap = 0;
            TongTien = 0;

        }
    }
}
