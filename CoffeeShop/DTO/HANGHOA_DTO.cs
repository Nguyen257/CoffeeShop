using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HANGHOA_DTO
    {
        public int ID { get; set; }
        public int IDNhom { get; set; }
        public string Ten { get; set; }
        public string DVTinh { get; set; }
        public double GiaVon { get; set; }
        public double GiaBuon { get; set; }
        public double GiaLe { get; set; }
        public double ChietKhauXuat { get; set; }
        public int TonKho { get; set; }

        public HANGHOA_DTO ()
        {
            ID = 0;
            IDNhom = 0;
            Ten = "";
            DVTinh = "";
            GiaVon = 0;
            GiaBuon = 0;
            GiaLe = 0;
            ChietKhauXuat = 0;
            TonKho = 0;

        }
    }
}
