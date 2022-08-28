using MySql.Data.MySqlClient;
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
    public partial class sales_report : Form
    {
        public sales_report()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string I have assigned the database file address path
                string cn = "datasource=127.0.0.1;port=3306;username=root;password= LIVERPOOL;";

                //This is my insert query in which I am taking input from the user through windows forms
                string Query = "insert into shoprite_inventory.sales_report(STOCKS_IN_DEMAND, OUT_OF_STOCK_PROD, STOCK_IN_EXCESS) values('" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "'); ";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(cn);

                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Attendant_page ap = new Attendant_page();
            ap.Show();
            this.Hide();
        }
    }
}
