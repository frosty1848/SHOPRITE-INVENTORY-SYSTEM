using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SHOPRITE_INVENTORY_SYSTEM
{
    public partial class Attendant_login : Form
    {
        static string var;
        static int attempt = 3;
        public Attendant_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var = Hash_password.Hash_SHA1(att_password_box.Text);
          

            if ((att_username_box.Text == "MICHEAL ANGELO") && (att_password_box.Text == "hellafella"))
            {


                attempt = 0;
                MessageBox.Show("You have been given access");
               
                Attendant_page ap = new Attendant_page();
                ap.Show();
                this.Hide();
                
                try
                {
                    //This is my connection string I have assigned the database file address path
                    string cn = "datasource=127.0.0.1;port=3306;username=root;password= LIVERPOOL;";

                    //This is my insert query in which I am taking input from the user through windows forms
                    string Query = "insert into shoprite_inventory.attendant_login(USERNAME, PASSWORD) values('" + this.att_username_box.Text + "','" + var + "');";

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
            else if ((attempt == 3)&&(attempt > 0))
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
            Home_page hp = new Home_page();
            hp.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                att_password_box.UseSystemPasswordChar = false;
            }
            else
            {
                att_password_box.UseSystemPasswordChar = true;
            }
        }
    }
}
