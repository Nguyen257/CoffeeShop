using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
namespace BUS
{
    public class HOADON_BUS
    {
        public int themHD_BUS(int id, string NgayLap, int NguoiLap)
        {
            HOADON_DAO dao = new HOADON_DAO();
            return dao.themHoaDon(id, NgayLap, NguoiLap);
        }

        public int updateHD_BUS(int id,double tongtien)
        {
            HOADON_DAO dao = new HOADON_DAO();
            return dao.updateHD(id, tongtien);

        }

        public int xoaHD_BUS(int id)
        {
            HOADON_DAO dao = new HOADON_DAO();
            return dao.xoaHD(id);
        }

        public List<HOADON_DTO> getAll_BUS()
        {
            HOADON_DAO dao = new HOADON_DAO();
            return dao.GetAll();
        }
    }
}
