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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //This is my connection string I have assigned the database file address path
                string cn = "datasource=127.0.0.1;port=3306;username=root;password=LIVERPOOL;";

                //This is my insert query in which I am taking input from the user through windows forms
                string Query = "insert into shoprite_inventory.sign_up(USERNAME, PASSWORD) values('" + this.username_textbox.Text + "','" + this.passwd_textbox.Text + "');";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection Con5 = new MySqlConnection(cn);

                //This is command class which will handle the query and connection object.
                MySqlCommand Com5 = new MySqlCommand(Query, Con5);

                MySqlDataReader MyReader4;
                Con5.Open();
                MyReader4 = Com5.ExecuteReader();     // Here our query will be executed and data saved into the database.
                while (MyReader4.Read())
                {
                }
                Con5.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            USER_LOGIN ul = new USER_LOGIN();
            ul.Show();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwd_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwd_textbox.UseSystemPasswordChar = true;
            }
        }
    }
}
