using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOPRITE_INVENTORY_SYSTEM
{
    public partial class Form2 : Form
    {
        Admin_login al = new Admin_login();

        public Form2(Admin_login f2)
        {
            InitializeComponent();
            al = f2;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            al.Show();
            this.Close();

            try
            {

                string cn = "datasource=127.0.0.1;port=3306;username=root;password=LIVERPOOL;";

                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update shoprite_inventory.administrator_login set PASSWORD ='" + this.reset_password_box.Text + "'; ";

                //This is  MySqlConnection here I have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(cn);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Data Updated");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                nw_password_box.UseSystemPasswordChar = false;
            }
            else
            {
                nw_password_box.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                reset_password_box.UseSystemPasswordChar = false;
            }
            else
            {
                reset_password_box.UseSystemPasswordChar = true;
            }
        }
    }
}
