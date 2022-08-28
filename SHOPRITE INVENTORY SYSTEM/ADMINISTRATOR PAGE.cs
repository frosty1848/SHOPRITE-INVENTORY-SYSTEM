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
    public partial class ADMINISTRATOR_PAGE : Form
    {
        public ADMINISTRATOR_PAGE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Page ap = new Admin_Page();
            ap.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            USER_LOGIN ul = new USER_LOGIN();
            ul.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_page hp = new Home_page();
            hp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock_management sm = new Stock_management();
            sm.Show();
            this.Hide();
        }
    }
}
