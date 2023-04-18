using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project
{
    public partial class Reservations : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";


        public Reservations()
        {
            InitializeComponent();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";



        }

        private void newcus_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "select * from reservations;";
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "DELETE FROM reservations WHERE res_id = @id;";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyCommand2.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
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

        private void reserve_Click(object sender, EventArgs e)
        {

            string room = comboBox1.SelectedItem.ToString();
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            DateTime inDateTime = dateTimePicker1.Value;
            string inDate = inDateTime.ToString("yyyy-MM-dd");
            
            int days = int.Parse(daytext.Text);
            
            DateTime outDateTime = inDateTime.AddDays(days);
            string outDate = outDateTime.ToString("yyyy-MM-dd");
            
            

            try
            {
                string Query = "insert into reservations(cus_id,room_id,check_in,check_out,res_date,res_time) values('" + this.textBox2.Text + "','" + room + "','" + inDate + "','" + outDate + "','" + currentDate + "','" + currentTime + "');";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, myconn);
                MySqlDataReader MyReader2;
                myconn.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
