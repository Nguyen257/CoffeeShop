using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BAN_DTO
    {
        public int ID { get; set; }
        public string TenBan { get; set; }

        public BAN_DTO ()
        {
            ID = 0;
            TenBan = "";
        }
    }
}
