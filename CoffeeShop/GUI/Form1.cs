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
            KHACHHANG_BUS bus = new KHACHHANG_BUS();
            

            List<KHACHHANG_DTO> kq = bus.getAll_BUS();
            dataGridViewX1.ReadOnly = true;
            dataGridViewX1.DataSource = kq;
            dataGridViewX1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewX1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
    }
}
