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
    public class NHOMHANG_DAO :AbstractDAO
    {
        public int themNhom(string ten)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("NH_INSERT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);

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

        public int updateNhom(int id, string ten)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("NH_UPDATE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);


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

        public int xoaNhom(int id)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("NH_DELETE", cn);
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


        public List<NHOMHANG_DTO> GetAll()
        {
            List<NHOMHANG_DTO> kq = new List<NHOMHANG_DTO>();
            string str = "SELECT * FROM NHOMHANG";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    NHOMHANG_DTO row = new NHOMHANG_DTO();
                    row.ID = (int)r["ID"];
                    if (r["TenNhom"] != DBNull.Value)
                        row.TenNhom = (String)r["TenNhom"];

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
