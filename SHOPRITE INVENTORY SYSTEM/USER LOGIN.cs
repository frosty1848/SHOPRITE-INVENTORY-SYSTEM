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
    public partial class USER_LOGIN : Form
    {
        static string user;
        static int attempt = 3;
        public USER_LOGIN()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            user = Hash_password.Hash_SHA1(password_box.Text);


            if ((username_box.Text == "JEFF HENDRICK") && (password_box.Text == "YNWA"))
            {
                attempt = 0;
                MessageBox.Show("You have been given access");

                USER_PAGE up = new USER_PAGE();
                up.Show();
                this.Hide();

                try
                {
                    //This is my connection string I have assigned the database file address path
                    string cn = "datasource=127.0.0.1;port=3306;username=root;password=LIVERPOOL;";

                    //This is my insert query in which I am taking input from the user through windows forms
                    string Query = "insert into shoprite_inventory.user_login(USERNAME, PASSWORD) values('" + this.username_box.Text + "','" + user + "');";

                    //This is  MySqlConnection here i have created the object and pass my connection string.
                    MySqlConnection Con3 = new MySqlConnection(cn);

                    //This is command class which will handle the query and connection object.
                    MySqlCommand Com3 = new MySqlCommand(Query, Con3);
                          

                    MySqlDataReader MyReader4;
                    Con3.Open();
                    MyReader4 = Com3.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    while (MyReader4.Read())
                    {
                    }
                    Con3.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if ((attempt == 3) && (attempt > 0))
            {
                MessageBox.Show("You only have " + Convert.ToString(attempt) + " attempt to try");
            }
            else
            {
                MessageBox.Show("You are not granted access");

            }
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup su = new signup();
            su.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ADMINISTRATOR_PAGE AP = new ADMINISTRATOR_PAGE();
            AP.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
            }
        }
    }
}
