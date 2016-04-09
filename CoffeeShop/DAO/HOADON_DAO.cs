using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DAO
{
    public class HOADON_DAO:AbstractDAO
    {

        public int themHoaDon(string NgayLap,string NguoiLap,double TongTien)
        {
             SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("HH_INSERT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter pangaylap = new SqlParameter("@NgayLap",SqlDbType.Int);
                pangaylap.Direction = ParameterDirection.Input;
                pangaylap.Value = NgayLap;
                cm.Parameters.Add(pangaylap);

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);
        }
    }
}
