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
    public partial class stock_entry : Form
    {
        public stock_entry()
        {
            InitializeComponent();
        }

        private void SUBMIT_btn_Click(object sender, EventArgs e)
        {
            stock_audit sa = new stock_audit();
            sa.Show();
            this.Hide();
        }
    }
}
