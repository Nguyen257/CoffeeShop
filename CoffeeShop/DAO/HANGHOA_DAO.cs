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
    public class HANGHOA_DAO :AbstractDAO
    {
        public int themHang(int idnhom,string ten, string dvtinh, float giavon, float giabuon, float giale, float CKS, int tonkho)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("HH_INSERT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paidnhom = new SqlParameter("@IDNhom",SqlDbType.Int);
                paidnhom.Direction = ParameterDirection.Input;
                paidnhom.Value = idnhom;
                cm.Parameters.Add(paidnhom);

                SqlParameter paten = new SqlParameter("@Ten", SqlDbType.Char, 50);
                paten.Direction = ParameterDirection.Input;
                paten.Value = ten;
                cm.Parameters.Add(paten);

                SqlParameter padvtinh = new SqlParameter("@DVTinh", SqlDbType.Char, 20);
                padvtinh.Direction = ParameterDirection.Input;
                padvtinh.Value = dvtinh;
                cm.Parameters.Add(padvtinh);

                SqlParameter pagiavon = new SqlParameter("@GiaVon", SqlDbType.Float);
                pagiavon.Direction = ParameterDirection.Input;
                pagiavon.Value = giavon;
                cm.Parameters.Add(pagiavon);
                SqlParameter pagiabuon = new SqlParameter("@GiaBuon", SqlDbType.Float);
                pagiabuon.Direction = ParameterDirection.Input;
                pagiabuon.Value = giabuon;
                cm.Parameters.Add(pagiabuon);
                SqlParameter pagiale = new SqlParameter("@GiaLe", SqlDbType.Float);
                pagiale.Direction = ParameterDirection.Input;
                pagiale.Value = giale;
                cm.Parameters.Add(pagiale);
                SqlParameter packs = new SqlParameter("@ChietKhauXuat", SqlDbType.Float);
                packs.Direction = ParameterDirection.Input;
                packs.Value = CKS;
                cm.Parameters.Add(packs);
                SqlParameter patonkho = new SqlParameter("@TonKho", SqlDbType.Int);
                patonkho.Direction = ParameterDirection.Input;
                patonkho.Value = tonkho;
                cm.Parameters.Add(patonkho);


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
