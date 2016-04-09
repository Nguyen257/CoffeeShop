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
    public class CTHD_DAO:AbstractDAO
    {

        public int themCTHD(int id,int mahang,int soluong,double dongia)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("CTHD_INSERT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@id", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter pamahang = new SqlParameter("@MaHang", SqlDbType.Int);
                pamahang.Direction = ParameterDirection.Input;
                pamahang.Value = mahang;
                cm.Parameters.Add(pamahang);

                SqlParameter pasoluong = new SqlParameter("@SoLuong", SqlDbType.Int);
                pasoluong.Direction = ParameterDirection.Input;
                pasoluong.Value = soluong;
                cm.Parameters.Add(pasoluong);

                SqlParameter padongia = new SqlParameter("@DonGia", SqlDbType.Float);
                padongia.Direction = ParameterDirection.Input;
                padongia.Value = dongia;
                cm.Parameters.Add(padongia);

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
    
        public int updateCTHD(int id,int mahang,int soluong)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("CTHD_UPDATE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter pamahang = new SqlParameter("@MaHang", SqlDbType.Float);
                pamahang.Direction = ParameterDirection.Input;
                pamahang.Value = mahang;
                cm.Parameters.Add(pamahang);

                SqlParameter pasoluong = new SqlParameter("@SoLuong", SqlDbType.Float);
                pasoluong.Direction = ParameterDirection.Input;
                pasoluong.Value = soluong;
                cm.Parameters.Add(pasoluong);

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
    
        public int xoaCTHD(int id,int mahang)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("CTHD_DELETE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter pamahang = new SqlParameter("@MaHang", SqlDbType.Int);
                pamahang.Direction = ParameterDirection.Input;
                pamahang.Value = mahang;
                cm.Parameters.Add(pamahang);

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

        public List<CTHOADON_DTO> getAll()
        {
            List<CTHOADON_DTO> kq = new List<CTHOADON_DTO>();
            string str = "SELECT * FROM CTHOADON";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    CTHOADON_DTO row = new CTHOADON_DTO();
                    row.ID = (int)r["ID"];
                    if (r["MaHang"] != DBNull.Value)
                        row.MaHang = (int)r["MaHang"];
                    if (r["SoLuong"] != DBNull.Value)
                        row.SoLuong = (int)r["SoLuong"];
                    if (r["DonGia"] != DBNull.Value)
                        row.DonGia = (double)r["DonGia"];


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
