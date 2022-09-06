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
using System.Security.Cryptography;

namespace SHOPRITE_INVENTORY_SYSTEM
{
    public partial class Admin_login : Form
    {
        static string admin;
        static int attempt = 3;
        public Admin_login()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            admin = Hash_password.Hash_SHA1(textBox2.Text);
           
            
      
           
            if ((textBox1.Text == "Ernest Kwabena Otu") && (textBox2.Text == "harleyrace"))
            {

                ADMINISTRATOR_PAGE ap = new ADMINISTRATOR_PAGE();
                ap.Show();
                this.Hide();
                MessageBox.Show("You have been given access");

                try
                {
                    //This is my connection string I have assigned the database file address path
                    string cn = "datasource=127.0.0.1;port=3306;username=root;password= LIVERPOOL;";

                    //This is my insert query in which I am taking input from the user through windows forms
                    string Query = "insert into shoprite_inventory.administrator_login(USERNAME, PASSWORD) values('" + this.textBox1.Text + "','" + admin + "');";

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
            else if ((attempt == 3) && (attempt > 0))
            {
                MessageBox.Show("You only have " + Convert.ToString(attempt) + " attempt to try");
            }
            else
            {
                MessageBox.Show("You are not granted access");

            }
          

        }
        
    

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home_page hp = new Home_page();
            hp.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }
    }
 }



