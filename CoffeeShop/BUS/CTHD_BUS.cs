using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
namespace BUS
{
    public class CTHD_BUS
    {
        public int themCTHD_BUS(int id,int mahang,int soluong,double dongia)
        {
            CTHD_DAO dao = new CTHD_DAO();
            return dao.themCTHD(id,mahang,soluong,dongia);
        }

        public int updateCTHD_BUS(int id,int mahang,int soluong)
        {
            CTHD_DAO dao = new CTHD_DAO();
            return dao.updateCTHD(id, mahang, soluong);

        }

        public int xoaCTHD_BUS(int id,int mahang)
        {
            CTHD_DAO dao = new CTHD_DAO();
            return dao.xoaCTHD(id,mahang);
        }

        public List<CTHOADON_DTO> getAll_BUS()
        {
            CTHD_DAO dao = new CTHD_DAO();
            return dao.getAll();
        }
    }
}
