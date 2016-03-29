using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHANVIEN_DTO
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }

        public NHANVIEN_DTO ()
        {
            ID = 0;
            Ten = "";
            SDT = "";

        }
    }
}
