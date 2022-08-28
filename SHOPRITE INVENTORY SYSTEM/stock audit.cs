using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPRITE_INVENTORY_SYSTEM
{
    public partial class stock_audit : Form
    {
        public stock_audit()
        {
            InitializeComponent();
        }

        private void stock_audit_Load(object sender, EventArgs e)
        {
            chart1.Series["Series 1"].Points.AddXY("AMAZON", 1000);
            chart1.Series["Series 1"].Points.AddXY("SAMSUNG", 5000);
            chart1.Series["Series 1"].Points.AddXY("COCA-COLA", 1500);
            chart1.Series["Series 1"].Points.AddXY("GUSTO'S", 7000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Attendant_page ap = new Attendant_page();
            ap.Show();
            this.Hide();
        }
    }
}
