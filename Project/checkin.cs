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
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class checkin : Form
    {
        public string conn = "server=localhost;user id=root; password=rootpass; database=hotel";
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
                string strquery = "UPDATE rooms SET Status = 'OCCUPiED'\r\nWHERE rooms_id='" + comboBox1.Text + "';";
                MySqlConnection MyConn = new MySqlConnection(conn);
                MySqlCommand MyCommand = new MySqlCommand(strquery, MyConn);
                MySqlDataReader MyReader1;
                MyConn.Open();
                MyReader1 = MyCommand.ExecuteReader();
                MyConn.Close();



                string Query = "INSERT into transactions(transaction_date,transaction_type,customer,amount,status) values('" + currentDate + "', 'CHECK-IN', @cus, @amount, 'PENDING');";
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


        private void out_Click_1(object sender, EventArgs e)
        {
            try
                {
                    string receipt = "SELECT transaction_type,transaction_date, amount FROM transactions WHERE status = 'PENDING' AND customer= '" + textBox1.Text + "';";
                    string total = "SELECT SUM(amount) AS total_amount FROM transactions WHERE status = 'PENDING' AND customer = '" + textBox1.Text + "';";
                    string done = "UPDATE transactions SET status = 'COMPLETED' WHERE status = 'PENDING' AND customer = '" + textBox1.Text + "';";
                    Receipt rep = new Receipt(receipt, total, done);
                    rep.Show();
                    string Query = "UPDATE rooms SET Status = 'OPEN'\r\nWHERE rooms_id = '" + comboBox1.Text + "';";
                    MySqlConnection MyConn = new MySqlConnection(conn);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader2;
                    MyConn.Open();
                    MyReader2 = MyCommand.ExecuteReader();
                    MyConn.Close();
                    MessageBox.Show("THANK YOU!!!");
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }


        


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Query = "SELECT * FROM customer WHERE Lastname = @lname;";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);
                cmd.Parameters.AddWithValue("@lname", textBox2.Text);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string Query = "SELECT * FROM reservations WHERE check_in >= CURDATE() AND cus_id=@id;";
                    MySqlConnection myconn = new MySqlConnection(conn);
                    MySqlCommand cmd = new MySqlCommand(Query, myconn);
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
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
        }
    }
}
