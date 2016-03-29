using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHOMHANG_DTO
    {
        public int ID { get; set; }
        public string TenNhom { get; set; }

        public NHOMHANG_DTO ()
        {
            ID = 0;
            TenNhom = "";

        }
    }
}
