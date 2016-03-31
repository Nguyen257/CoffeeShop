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
    public class NHANVIEN_DAO : AbstractDAO
    {
        public int themNhanVien(string ten,string sdt)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("NV_INSERT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);

                SqlParameter pasdt = new SqlParameter("@SDT", SqlDbType.NVarChar, 20);
                pasdt.Direction = ParameterDirection.Input;
                pasdt.Value = sdt;
                cm.Parameters.Add(pasdt);

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

        public int updateNhanVien(int id,string ten,string sdt)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("NV_UPDATE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);

                SqlParameter pasdt = new SqlParameter("@SDT", SqlDbType.NVarChar, 20);
                pasdt.Direction = ParameterDirection.Input;
                pasdt.Value = sdt;
                cm.Parameters.Add(pasdt);

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

        public int xoaNhanVien (int id)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("NV_DELETE", cn);
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
    

        public List<NHANVIEN_DTO> GetAll()
        {
            List<NHANVIEN_DTO> kq = new List<NHANVIEN_DTO>();
            string str = "SELECT * FROM NHANVIEN";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    NHANVIEN_DTO row = new NHANVIEN_DTO();
                    row.ID = (int)r["ID"];
                    if (r["Ten"] != DBNull.Value)
                        row.Ten = (String)r["Ten"];
                    if (r["SDT"] != DBNull.Value)
                        row.SDT = (String)r["SDT"];

                    kq.Add(row);
                }
                cn.Close();
                return kq;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
