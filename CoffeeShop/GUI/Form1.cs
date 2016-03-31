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
            BAN_BUS bus = new BAN_BUS();
            

            bus.themBan_BUS("cai ban");
            bus.updateBan_BUS(2, "cai ban moi");
            bus.xoaBan_BUS(3);
            List<BAN_DTO> kq = bus.getAll_BUS();
            dataGridViewX1.ReadOnly = true;
            dataGridViewX1.DataSource = kq;
            dataGridViewX1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewX1.Columns[1].HeaderText = "Họ và Tên";
        }
    }
}
