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
    public partial class Attendant_page : Form
    {
        public Attendant_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_close_sales scs = new start_close_sales();
            scs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sales_receipt_generation srg = new sales_receipt_generation();
            srg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sales_report_generation srig = new sales_report_generation();
            srig.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stock_audit sa = new stock_audit();
            sa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TRANSACTION_RECORD tr = new TRANSACTION_RECORD();
            tr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barcode_scanning bar = new Barcode_scanning();
            bar.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home_page hp = new Home_page();
            hp.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sales_report sr = new sales_report();
            sr.Show();
            this.Hide();
        }
    }
}
