using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;

namespace BUS
{
    public class BAN_BUS
    {
        public int themBan_BUS(string ten)
        {
            BAN_DAO dao = new BAN_DAO();
            return dao.themBan(ten);
        }

        public int updateBan_BUS(int id, string ten)
        {
            BAN_DAO dao = new BAN_DAO();
            return dao.updateBan(id, ten);
        }
        public int xoaBan_BUS(int id)
        {
            BAN_DAO dao = new BAN_DAO();
            return dao.xoaBan(id);
        }
        public List<BAN_DTO> getAll_BUS()
        {
            BAN_DAO dao = new BAN_DAO();
            return dao.GetAll();
        }
    }
}
