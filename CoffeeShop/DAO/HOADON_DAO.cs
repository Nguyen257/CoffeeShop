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

        public int themHoaDon(int id, string NgayLap,int NguoiLap)
        {
             SqlConnection cn = this.KetNoiCSDL();
             try
             {
                 cn.Open();
                 SqlCommand cm = new SqlCommand("HD_INSERT", cn);
                 cm.CommandType = CommandType.StoredProcedure;

                 SqlParameter paid = new SqlParameter("@id", SqlDbType.Int);
                 paid.Direction = ParameterDirection.Input;
                 paid.Value = id;
                 cm.Parameters.Add(paid);

                 SqlParameter paNgayLap = new SqlParameter("@NgayLap", SqlDbType.Char, 50);
                 paNgayLap.Direction = ParameterDirection.Input;
                 paNgayLap.Value = NgayLap;
                 cm.Parameters.Add(paNgayLap);

                 SqlParameter paNguoiLap = new SqlParameter("@NguoiLap", SqlDbType.Int);
                 paNguoiLap.Direction = ParameterDirection.Input;
                 paNguoiLap.Value = NguoiLap;
                 cm.Parameters.Add(paNguoiLap);

                 try
                 {
                     cm.ExecuteNonQuery();
                     cn.Close();
                     return 1;
                 }
                 catch
                 {
                     cn.Close();
                     return 0;
                 }
             }
             catch
             {
                 cn.Close();
                 return 0;
             }
        }

        public int updateHD(int id, double tongtien)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("HD_UPDATE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter patongtien = new SqlParameter("@TongTien", SqlDbType.Float);
                patongtien.Direction = ParameterDirection.Input;
                patongtien.Value = tongtien;
                cm.Parameters.Add(patongtien);



                try
                {
                    cm.ExecuteNonQuery();
                    cn.Close();
                    return 1;
                }
                catch
                {
                    cn.Close();
                    return 0;
                }
            }
            catch
            {
                cn.Close();
                return 0;
            }
        }

        public int xoaHD(int id)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("HD_DELETE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);


                try
                {
                    cm.ExecuteNonQuery();
                    cn.Close();
                    return 1;
                }
                catch
                {
                    cn.Close();
                    return 0;
                }
            }
            catch
            {
                cn.Close();
                return 0;
            }
        }

        public List<HOADON_DTO> GetAll()
        {
            List<HOADON_DTO> kq = new List<HOADON_DTO>();
            string str = "SELECT * FROM HOADON";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    HOADON_DTO row = new HOADON_DTO();
                    row.ID = (int)r["ID"];
                    if (r["NgayLap"] != DBNull.Value)
                        row.NgayLap = (String)r["NgayLap"].ToString();
                    if (r["NguoiLap"] != DBNull.Value)
                        row.NguoiLap = (int)r["NguoiLap"];
                    if (r["TongTien"] != DBNull.Value)
                        row.TongTien = (double)r["TongTien"];
            

                    kq.Add(row);
                }
                cn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }
}
