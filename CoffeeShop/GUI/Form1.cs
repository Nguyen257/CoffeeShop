using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CTHD_BUS bus = new CTHD_BUS();
            /*
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-US");
            int x = bus.updateHD_BUS(4, 43.5);*/
            List<CTHOADON_DTO> kq = bus.getAll_BUS();
            dataGridViewX1.ReadOnly = true;
            dataGridViewX1.DataSource = kq;
            
            try
            {
                for (int i = 0; i < dataGridViewX1.RowCount - 1; i++)
                {
                    dataGridViewX1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (Exception ex)
            { }
        }
    }
}
