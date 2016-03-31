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
    public class BAN_DAO :AbstractDAO
    {
        public int themBan(string ten)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("BAN_INSERT", cn);
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

        public int updateBan(int id, string ten)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("BAN_UPDATE", cn);
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

        public int xoaBan(int id)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("BAN_DELETE", cn);
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


        public List<BAN_DTO> GetAll()
        {
            List<BAN_DTO> kq = new List<BAN_DTO>();
            string str = "SELECT * FROM BAN";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    BAN_DTO row = new BAN_DTO();
                    row.ID = (int)r["ID"];
                    if (r["TenBan"] != DBNull.Value)
                        row.TenBan = (String)r["TenBan"];

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
