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
    public partial class sales_report_generation : Form
    {
        Inventory con = new Inventory();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;
        public sales_report_generation()
        {
            InitializeComponent();
            con.Connect();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Attendant_page ap = new Attendant_page();
            ap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * from sales_report", con.cn);
                command.ExecuteNonQuery();
                da = new MySqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.cn.Close();
                MessageBox.Show("Record inserted!");
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
