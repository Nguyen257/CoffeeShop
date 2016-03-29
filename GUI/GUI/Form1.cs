using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NHANVIEN_BUS bus = new NHANVIEN_BUS();
            string a = "12345678901234567891231230";
            bus.updateNhanVien_BUS(5,a,"00055");
        }
    }
}
