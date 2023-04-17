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

namespace Project
{
    public partial class Customer : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";

        public Customer()
        {
            InitializeComponent();
        }


        private void load_click(object sender, EventArgs e)
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



        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "DELETE FROM customer WHERE cus_id = @id;";
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

        private void update_Click(object sender, EventArgs e)
        {/*
            try
            {

                string Query = "update hotel.customer set Lastname='" + this.textBox2.Text + "',Firstname='" + this.textBox3.Text + "',Contact='" + this.textBox3.Text + "'where idStudentInfo='" + this.IdTextBox.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "insert into customer(Lastname,Firstname,Contact) values('" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";
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
