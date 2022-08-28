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
    public partial class start_close_sales : Form
    {
        public start_close_sales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Today's sales has started!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Today's sales have been closed!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Attendant_page ap = new Attendant_page();   
            ap.Show();
            this.Hide();
        }
    }
}
