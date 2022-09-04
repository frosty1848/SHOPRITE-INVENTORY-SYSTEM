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
    public partial class Home_page : Form
    {
        public Home_page()

        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_login ap = new Admin_login();
            ap.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Attendant_login al = new Attendant_login();
            al.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
