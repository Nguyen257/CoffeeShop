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
            /*
            HOADON_BUS bus = new HOADON_BUS();
            
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-US");
            int x = bus.updateHD_BUS(4, 43.5);
            bus.themHD_BUS(5);
            List<HOADON_DTO> kq = bus.getAll_BUS();
            dataGridViewX1.ReadOnly = true;
            dataGridViewX1.DataSource = kq;
            
            try
            {
                for (int i = 0; i < dataGridViewX1.RowCount ; i++)
                {
                    dataGridViewX1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (Exception ex)
            { }
            */
        }
    }
}
