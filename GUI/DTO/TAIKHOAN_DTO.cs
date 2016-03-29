using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TAIKHOAN_DTO
    {
        public int ID {get;set; }
	    public string HoTen {get;set; }
	    public string TenDN  {get;set; }
	    public string Pass {get;set; }
	    public bool IsAdmin {get;set; }
	    public bool SLDL {get;set; }
	    public bool NH_XEM {get;set; }
	    public bool NH_THEM {get;set; }
	    public bool NH_SUA {get;set; }
	    public bool NH_XOA {get;set; }
	    public bool HH_XEM {get;set; }
	    public bool HH_THEM {get;set; }
	    public bool HH_SUA {get;set; }
	    public bool HH_XOA {get;set; }
	    public bool KH_XEM {get;set; }
	    public bool KH_THEM {get;set; }
	    public bool KH_SUA {get;set; }
	    public bool KH_XOA {get;set; }
	    public bool NCC_XEM {get;set; }
	    public bool NCC_THEM {get;set; }
	    public bool NCC_SUA {get;set; }
	    public bool NCC_XOA {get;set; }
	    public bool HDN_XEM {get;set; }
	    public bool HDN_THEM {get;set; }
	    public bool HDN_SUA {get;set; }
	    public bool HDN_XOA {get;set; }
	    public bool HDX_XEM {get;set; }
	    public bool HDX_THEM {get;set; }
	    public bool HDX_SUA {get;set; }
	    public bool HDX_XOA {get;set; }
	    public bool PT_XEM {get;set; }
	    public bool PT_THEM {get;set; }
	    public bool PT_SUA {get;set; }
	    public bool PT_XOA {get;set; }
	    public bool PC_XEM {get;set; }
	    public bool PC_THEM {get;set; }
	    public bool PC_SUA {get;set; }
	    public bool PC_XOA {get;set; }
	    public bool LAP_ORDER {get;set; }
	    public bool IN_MA {get;set; }
	    public bool BCNHAP {get;set; }
	    public bool BCXUAT {get;set; }
	    public bool BCTHU {get;set; }
	    public bool BCCHI {get;set; }
	    public bool BCCNKH {get;set; }
	    public bool BCCNNCC {get;set; }
        public bool BCLAIKH { get; set; }


        public TAIKHOAN_DTO ()
        {
            ID = 0;
            HoTen = "";
            TenDN = "";
            Pass = "";

        }
    }
}
