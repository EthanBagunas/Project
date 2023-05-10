using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Receipt : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";

        public Receipt()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                string Query = "insert into transactions(transaction_date,transaction_type,customer,amount,status) values('" + currentDate + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','Pending');";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, myconn);
                MySqlDataReader MyReader2;
                myconn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                myconn.Close();
                MessageBox.Show("Transaction complete");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
