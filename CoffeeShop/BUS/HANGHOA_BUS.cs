using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HANGHOA_BUS
    {
        public int themHang_BUS(int idnhom, string ten, string dvtinh, double giavon, double giabuon, double giale, double CKS, int tonkho)
        {
            HANGHOA_DAO dao = new HANGHOA_DAO();
            return dao.themHang(idnhom,ten,dvtinh,giavon,giabuon,giale,CKS,tonkho);
        }

        public int updateHang_BUS(int id, int idnhom, string ten, string dvtinh, double giavon, double giabuon, double giale, double CKS, int tonkho)
        {
            HANGHOA_DAO dao = new HANGHOA_DAO();
            return dao.updateHang(id,idnhom,ten,dvtinh,giavon,giabuon,giale,CKS,tonkho);
        }
        public int xoaHang_BUS(int id)
        {
            HANGHOA_DAO dao = new HANGHOA_DAO();
            return dao.xoaHang(id);
        }
        public List<HANGHOA_DTO> getAll_BUS()
        {
            HANGHOA_DAO dao = new HANGHOA_DAO();
            return dao.GetAll();
        } 
    }
}
