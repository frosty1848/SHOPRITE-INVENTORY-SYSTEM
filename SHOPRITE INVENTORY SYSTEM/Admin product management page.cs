using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHOPRITE_INVENTORY_SYSTEM
{
    public partial class Admin_Page : Form
    {
      

        Inventory con = new Inventory();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;


        public Admin_Page()
        {
            InitializeComponent();
            con.Connect();
            
        }

        

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
           
        }

        private void button1_Click(object sender, EventArgs e)   
        {
           

            try
            {
                //This is my connection string I have assigned the database file address path
                string cn = "datasource=127.0.0.1;port=3306;username=root;password= LIVERPOOL;";

                //This is my insert query in which I am taking input from the user through windows forms
                string Query = "insert into shoprite_inventory.admin_page(PRODUCT, PRODUCT_ID, PRODUCT_CATEGORY_ID,SALES_NUMBER,DATE_SOLD) values('" + this.PRODUCT.Text + "','" + this.PRODUCTID.Text + "','" + this.PRODUCTCATEGORYID.Text + "','" + this.SALESNUMBER.Text + "','" + this.DATESOLD.Text +"'); ";

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


            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * from admin_page",con.cn);
                command.ExecuteNonQuery();
                da = new MySqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.cn.Close();
                MessageBox.Show("Record inserted!");
            }
            catch(Exception ex)
            
            {
                MessageBox.Show(ex.Message);
            }
              
        }
        
       
        private void button4_Click(object sender, EventArgs e)
        {
            ADMINISTRATOR_PAGE AP = new ADMINISTRATOR_PAGE();
            AP.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ADMINISTRATOR_PAGE AP = new ADMINISTRATOR_PAGE();
            AP.Show();
            this.Hide();
        }

        private void PRODUCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRODUCTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRODUCTCATEGORYID_TextChanged(object sender, EventArgs e)
        {

        }

        private void SALESNUMBER_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=127.0.0.1;port=3306;username=root;password=LIVERPOOL;";
                string Qu = "delete from shoprite_inventory.admin_page where (PRODUCT ='" + this.PRODUCT.Text + "');";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Qu, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

