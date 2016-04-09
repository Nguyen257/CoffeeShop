using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHOADON_DTO
    {
        public int ID { get; set; }
        public int MaHang { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public CTHOADON_DTO ()
        {
            ID = 0;
            MaHang = 0;
            SoLuong = 0;
            DonGia = 0;

        }
    }
}
