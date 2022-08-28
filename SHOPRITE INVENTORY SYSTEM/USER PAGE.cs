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
    public partial class USER_PAGE : Form
    {
        public static double due = 0, change;
        public USER_PAGE()
        {
            InitializeComponent();
        }

        private void USER_PAGE_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           richTextBox1.Text = richTextBox1.Text + "\nFROZEN CHICKEN\t\t50.00GHC";
            due = due + 50.00;
            due_lbl.Text = "GHC" + due.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\n1 LITRE SPRITE\t\t20.00GHC";
            due = due + 20.00;
            due_lbl.Text = "GHC" + due.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nGUSTO'S CHICKEN PIZZA\t\t70.00GHC";
            due = due + 70.00;
            due_lbl.Text = "GHC" + due.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nKELLOG'S CORN FLAKES\t\t25.00GHC";
            due = due + 25.00;
            due_lbl.Text = "GHC" + due.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nCAN COCA-COLA\t\t10.00GHC";
            due = due + 10.00;
            due_lbl.Text = "GHC"+ due.ToString();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(cash_box.Text);
            change = cash - due;

            if (change < 0)
             MessageBox.Show("Not enough funds!");
            Change_lbl.Text = "GHC" + change.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            change = 0;
            due = 0;
            richTextBox1.Text = "";
            Change_lbl.Text = "0";
            due_lbl.Text = "0";
            cash_box.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_page hp = new Home_page();
            hp.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string I have assigned the database file address path
                string cn = "datasource=127.0.0.1;port=3306;username=root;password= LIVERPOOL;";

                //This is my insert query in which I am taking input from the user through windows forms
                string Query = "insert into shoprite_inventory.receipt(AMOUNT_PAID, AMOUNT_OWED, DATE_OF_PAYMENT) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +  "'); ";

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nSANDY'S CHEESE BURGER\t\t70.00GHC";
            due = due + 70.00;
            due_lbl.Text = "GHC" + due.ToString();
        }
    }
}
