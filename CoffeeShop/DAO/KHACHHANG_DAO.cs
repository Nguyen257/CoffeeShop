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
    public class KHACHHANG_DAO : AbstractDAO
    {

        public int themKH(string ten, string diachi,string sdt,int loaikh,string giaban)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("KH_INSERT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);

                SqlParameter padc = new SqlParameter("@DiaChi", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                padc.Value = diachi;
                cm.Parameters.Add(padc);

                SqlParameter pasdt = new SqlParameter("@SDT", SqlDbType.NVarChar, 20);
                pasdt.Direction = ParameterDirection.Input;
                pasdt.Value = sdt;
                cm.Parameters.Add(pasdt);

                SqlParameter paloaikh = new SqlParameter("@LoaiKH", SqlDbType.Int);
                pasdt.Direction = ParameterDirection.Input;
                paloaikh.Value = loaikh;
                cm.Parameters.Add(paloaikh);

                SqlParameter pagiaban = new SqlParameter("@GiaBan", SqlDbType.NVarChar, 20);
                pasdt.Direction = ParameterDirection.Input;
                pagiaban.Value = giaban;
                cm.Parameters.Add(pagiaban);

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

        public int updateKH(int id, string ten, string diachi, string sdt, int loaikh, string giaban)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("KH_UPDATE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);

                SqlParameter padc = new SqlParameter("@DiaChi", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                padc.Value = diachi;
                cm.Parameters.Add(padc);

                SqlParameter pasdt = new SqlParameter("@SDT", SqlDbType.NVarChar, 20);
                pasdt.Direction = ParameterDirection.Input;
                pasdt.Value = sdt;
                cm.Parameters.Add(pasdt);

                SqlParameter paloaikh = new SqlParameter("@LoaiKH", SqlDbType.Int);
                pasdt.Direction = ParameterDirection.Input;
                paloaikh.Value = loaikh;
                cm.Parameters.Add(paloaikh);

                SqlParameter pagiaban = new SqlParameter("@GiaBan", SqlDbType.NVarChar, 20);
                pasdt.Direction = ParameterDirection.Input;
                pagiaban.Value = giaban;
                cm.Parameters.Add(pagiaban);

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

        public int xoaKH(int id)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("KH_DELETE", cn);
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


        public List<KHACHHANG_DTO> GetAll()
        {
            List<KHACHHANG_DTO> kq = new List<KHACHHANG_DTO>();
            string str = "SELECT * FROM KHACHHANG WHERE LoaiKH = 1";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    KHACHHANG_DTO row = new KHACHHANG_DTO();
                    row.ID = (int)r["ID"];
                    if (r["Ten"] != DBNull.Value)
                        row.Ten = (String)r["Ten"];
                    if (r["DiaChi"] != DBNull.Value)
                        row.DiaChi = (String)r["DiaChi"];
                    if (r["SDT"] != DBNull.Value)
                        row.SDT = (String)r["SDT"];
                    if (r["LoaiKH"] != DBNull.Value)
                        row.LoaiKH = (int)r["LoaiKH"];
                    if (r["GiaBan"] != DBNull.Value)
                        row.GiaBan = (String)r["GiaBan"];

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
