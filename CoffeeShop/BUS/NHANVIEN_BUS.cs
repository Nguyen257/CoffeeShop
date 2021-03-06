﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;

namespace BUS
{
    public class NHANVIEN_BUS
    {
        public int themNhanVien_BUS(string ten,string sdt)
        {
            NHANVIEN_DAO dao = new NHANVIEN_DAO();
            return dao.themNhanVien(ten, sdt);
        }

        public int updateNhanVien_BUS (int id,string ten,string sdt)
        {
            NHANVIEN_DAO dao = new NHANVIEN_DAO();
            return dao.updateNhanVien(id, ten, sdt);
        }
        public int xoaNhanVien_BUS(int id)
        {
            NHANVIEN_DAO dao = new NHANVIEN_DAO();
            return dao.xoaNhanVien(id);
        }
        public List<NHANVIEN_DTO> getAll_BUS ()
        {
            NHANVIEN_DAO dao = new NHANVIEN_DAO();
            return dao.GetAll();
        }
    }
}
