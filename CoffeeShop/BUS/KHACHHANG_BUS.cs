using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
namespace BUS
{
    public class KHACHHANG_BUS
    {
        public int themKH_BUS (string ten, string diachi,string sdt,int loaikh,string giaban)
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            return dao.themKH(ten, diachi, sdt, loaikh, giaban);
        }

        public int updateKH_BUS(int id, string ten, string diachi, string sdt, int loaikh, string giaban){
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            return dao.updateKH(id, ten, diachi, sdt, loaikh, giaban);
        }

        public int xoaKH_BUS(int id)
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            return dao.xoaKH(id);

        }

        public List<KHACHHANG_DTO> getAll_BUS()
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            return dao.GetAll();
        }
    }
}
