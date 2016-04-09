using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NHOMHANG_BUS
    {
        public int themNhom_BUS(string ten)
        {
            NHOMHANG_DAO dao = new NHOMHANG_DAO();
            return dao.themNhom(ten);
        }

        public int updateBan_BUS(int id, string ten)
        {
            NHOMHANG_DAO dao = new NHOMHANG_DAO();
            return dao.updateNhom(id, ten);
        }
        public int xoaBan_BUS(int id)
        {
            NHOMHANG_DAO dao = new NHOMHANG_DAO();
            return dao.xoaNhom(id);
        }
        public List<NHOMHANG_DTO> getAll_BUS()
        {
            NHOMHANG_DAO dao = new NHOMHANG_DAO();
            return dao.GetAll();
        } 
    }
}
