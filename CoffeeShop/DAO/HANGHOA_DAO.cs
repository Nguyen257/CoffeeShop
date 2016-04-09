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
        public int themHang(int idnhom, string ten, string dvtinh, double giavon, double giabuon, double giale, double CKS, int tonkho)
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

        public int updateHang(int id, int idnhom, string ten, string dvtinh, double giavon, double giabuon, double giale, double CKS, int tonkho)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("HH_UPDATE", cn);
                cm.CommandType = CommandType.StoredProcedure;

                SqlParameter paid = new SqlParameter("@ID", SqlDbType.Int);
                paid.Direction = ParameterDirection.Input;
                paid.Value = id;
                cm.Parameters.Add(paid);

                SqlParameter paidnhom = new SqlParameter("@IDNhom", SqlDbType.Int);
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

        public int xoaHang(int id)
        {
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("HH_DELETE", cn);
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


        public List<HANGHOA_DTO> GetAll()
        {
            List<HANGHOA_DTO> kq = new List<HANGHOA_DTO>();
            string str = "SELECT * FROM HANGHOA";
            SqlConnection cn = this.KetNoiCSDL();
            try
            {
                cn.Open();
                SqlCommand command = new SqlCommand(str, cn);
                SqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    HANGHOA_DTO row = new HANGHOA_DTO();
                    row.ID = (int)r["ID"];
                    if (r["IDNhom"] != DBNull.Value)
                        row.IDNhom = (int)r["IDNhom"];
                    if (r["DVTinh"] != DBNull.Value)
                        row.DVTinh = (String)r["DVTinh"];
                    if (r["GiaLe"] != DBNull.Value)
                        row.GiaLe = (float)r["GiaLe"];
                    if (r["GiaBuon"] != DBNull.Value)
                        row.GiaBuon = (float)r["GiaBuon"];
                    if (r["GiaVon"] != DBNull.Value)
                        row.GiaVon = (float)r["GiaVon"];
                    if (r["ChietKhauXuat"] != DBNull.Value)
                        row.ChietKhauXuat = (float)r["ChietKhauXuat"];
                    if (r["TonKho"] != DBNull.Value)
                        row.TonKho = (int)r["TonKho"];

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
