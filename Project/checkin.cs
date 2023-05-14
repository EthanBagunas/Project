using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class checkin : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        public checkin()
        {
            InitializeComponent();
        }

        private void cusload_click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select * from customer;";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select * from rooms;";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {

                string Query = "INSERT into transactions(transaction_date,transaction_type,customer,amount,status) values('" + currentDate + "', 'CHECK-IN', @cus, @amount, 'PENDING')";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyCommand2.Parameters.AddWithValue("@amount", 200);
                MyCommand2.Parameters.AddWithValue("@cus", textBox1.Text);

                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
